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
        public IBodyWorkflowAction<GetMachineNameResponse> GetMachineName(Expression<Func<string>> getMachineNameworkflow)
        {
            var __workflow_getMachineNameworkflow = WorkflowExpression.Compile(getMachineNameworkflow, nameof(getMachineNameworkflow), required: true);
            return new DeferredBodyAction<GetMachineNameResponse>(() =>
            {
                var apiCallPath = "/Environment/GetMachineName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getMachineName = new JObject();
                var getMachineNamepropCount = 0;
                getMachineNamepropCount++;
                getMachineName["Workflow"] = ExpressionConverter.ConvertO(__workflow_getMachineNameworkflow);
                if (getMachineNamepropCount > 0)
                {
                    callPayload.Body = getMachineName;
                }

                return new ApiConnectionAction<GetMachineNameResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMachineDomainResponse> GetMachineDomain(Expression<Func<string>> getMachineDomainworkflow)
        {
            var __workflow_getMachineDomainworkflow = WorkflowExpression.Compile(getMachineDomainworkflow, nameof(getMachineDomainworkflow), required: true);
            return new DeferredBodyAction<GetMachineDomainResponse>(() =>
            {
                var apiCallPath = "/Environment/GetMachineDomain";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getMachineDomain = new JObject();
                var getMachineDomainpropCount = 0;
                getMachineDomainpropCount++;
                getMachineDomain["Workflow"] = ExpressionConverter.ConvertO(__workflow_getMachineDomainworkflow);
                if (getMachineDomainpropCount > 0)
                {
                    callPayload.Body = getMachineDomain;
                }

                return new ApiConnectionAction<GetMachineDomainResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteSessionClientHostnameResponse> GetRemoteSessionClientHostname(Expression<Func<string>> getRemoteSessionClientHostnameworkflow)
        {
            var __workflow_getRemoteSessionClientHostnameworkflow = WorkflowExpression.Compile(getRemoteSessionClientHostnameworkflow, nameof(getRemoteSessionClientHostnameworkflow), required: true);
            return new DeferredBodyAction<GetRemoteSessionClientHostnameResponse>(() =>
            {
                var apiCallPath = "/Environment/GetRemoteSessionClientHostname";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRemoteSessionClientHostname = new JObject();
                var getRemoteSessionClientHostnamepropCount = 0;
                getRemoteSessionClientHostnamepropCount++;
                getRemoteSessionClientHostname["Workflow"] = ExpressionConverter.ConvertO(__workflow_getRemoteSessionClientHostnameworkflow);
                if (getRemoteSessionClientHostnamepropCount > 0)
                {
                    callPayload.Body = getRemoteSessionClientHostname;
                }

                return new ApiConnectionAction<GetRemoteSessionClientHostnameResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ExpandEnvironmentVariableResponse> ExpandEnvironmentVariable(Expression<Func<string>> expandEnvironmentVariableinputString, Expression<Func<string>> expandEnvironmentVariableworkflow)
        {
            var __workflow_expandEnvironmentVariableinputString = WorkflowExpression.Compile(expandEnvironmentVariableinputString, nameof(expandEnvironmentVariableinputString), required: true);
            var __workflow_expandEnvironmentVariableworkflow = WorkflowExpression.Compile(expandEnvironmentVariableworkflow, nameof(expandEnvironmentVariableworkflow), required: true);
            return new DeferredBodyAction<ExpandEnvironmentVariableResponse>(() =>
            {
                var apiCallPath = "/Environment/ExpandEnvironmentVariable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var expandEnvironmentVariable = new JObject();
                var expandEnvironmentVariablepropCount = 0;
                expandEnvironmentVariablepropCount++;
                expandEnvironmentVariable["InputString"] = ExpressionConverter.ConvertO(__workflow_expandEnvironmentVariableinputString);
                expandEnvironmentVariablepropCount++;
                expandEnvironmentVariable["Workflow"] = ExpressionConverter.ConvertO(__workflow_expandEnvironmentVariableworkflow);
                if (expandEnvironmentVariablepropCount > 0)
                {
                    callPayload.Body = expandEnvironmentVariable;
                }

                return new ApiConnectionAction<ExpandEnvironmentVariableResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillProcessResponse> KillProcess(Expression<Func<string>> killProcessprocessName, Expression<Func<string>> killProcessworkflow)
        {
            var __workflow_killProcessprocessName = WorkflowExpression.Compile(killProcessprocessName, nameof(killProcessprocessName), required: true);
            var __workflow_killProcessworkflow = WorkflowExpression.Compile(killProcessworkflow, nameof(killProcessworkflow), required: true);
            return new DeferredBodyAction<KillProcessResponse>(() =>
            {
                var apiCallPath = "/Environment/KillProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var killProcess = new JObject();
                var killProcesspropCount = 0;
                killProcesspropCount++;
                killProcess["ProcessName"] = ExpressionConverter.ConvertO(__workflow_killProcessprocessName);
                killProcesspropCount++;
                killProcess["Workflow"] = ExpressionConverter.ConvertO(__workflow_killProcessworkflow);
                if (killProcesspropCount > 0)
                {
                    callPayload.Body = killProcess;
                }

                return new ApiConnectionAction<KillProcessResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillProcessIDResponse> KillProcessID(Expression<Func<int>> killProcessIDprocessID, Expression<Func<string>> killProcessIDworkflow)
        {
            var __workflow_killProcessIDprocessID = WorkflowExpression.Compile(killProcessIDprocessID, nameof(killProcessIDprocessID), required: true);
            var __workflow_killProcessIDworkflow = WorkflowExpression.Compile(killProcessIDworkflow, nameof(killProcessIDworkflow), required: true);
            return new DeferredBodyAction<KillProcessIDResponse>(() =>
            {
                var apiCallPath = "/Environment/KillProcessID";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var killProcessID = new JObject();
                var killProcessIDpropCount = 0;
                killProcessIDpropCount++;
                killProcessID["ProcessID"] = ExpressionConverter.ConvertO(__workflow_killProcessIDprocessID);
                killProcessIDpropCount++;
                killProcessID["Workflow"] = ExpressionConverter.ConvertO(__workflow_killProcessIDworkflow);
                if (killProcessIDpropCount > 0)
                {
                    callPayload.Body = killProcessID;
                }

                return new ApiConnectionAction<KillProcessIDResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessCountByNameResponse> GetProcessCountByName(Expression<Func<string>> getProcessCountByNameprocessName, Expression<Func<string>> getProcessCountByNameworkflow)
        {
            var __workflow_getProcessCountByNameprocessName = WorkflowExpression.Compile(getProcessCountByNameprocessName, nameof(getProcessCountByNameprocessName), required: true);
            var __workflow_getProcessCountByNameworkflow = WorkflowExpression.Compile(getProcessCountByNameworkflow, nameof(getProcessCountByNameworkflow), required: true);
            return new DeferredBodyAction<GetProcessCountByNameResponse>(() =>
            {
                var apiCallPath = "/Environment/GetProcessCountByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getProcessCountByName = new JObject();
                var getProcessCountByNamepropCount = 0;
                getProcessCountByNamepropCount++;
                getProcessCountByName["ProcessName"] = ExpressionConverter.ConvertO(__workflow_getProcessCountByNameprocessName);
                getProcessCountByNamepropCount++;
                getProcessCountByName["Workflow"] = ExpressionConverter.ConvertO(__workflow_getProcessCountByNameworkflow);
                if (getProcessCountByNamepropCount > 0)
                {
                    callPayload.Body = getProcessCountByName;
                }

                return new ApiConnectionAction<GetProcessCountByNameResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentProcessCountResponse> GetAgentProcessCount(Expression<Func<string>> getAgentProcessCountworkflow)
        {
            var __workflow_getAgentProcessCountworkflow = WorkflowExpression.Compile(getAgentProcessCountworkflow, nameof(getAgentProcessCountworkflow), required: true);
            return new DeferredBodyAction<GetAgentProcessCountResponse>(() =>
            {
                var apiCallPath = "/Environment/GetAgentProcessCount";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getAgentProcessCount = new JObject();
                var getAgentProcessCountpropCount = 0;
                getAgentProcessCountpropCount++;
                getAgentProcessCount["Workflow"] = ExpressionConverter.ConvertO(__workflow_getAgentProcessCountworkflow);
                if (getAgentProcessCountpropCount > 0)
                {
                    callPayload.Body = getAgentProcessCount;
                }

                return new ApiConnectionAction<GetAgentProcessCountResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillAllOtherAgentsResponse> KillAllOtherAgents(Expression<Func<string>> killAllOtherAgentsworkflow)
        {
            var __workflow_killAllOtherAgentsworkflow = WorkflowExpression.Compile(killAllOtherAgentsworkflow, nameof(killAllOtherAgentsworkflow), required: true);
            return new DeferredBodyAction<KillAllOtherAgentsResponse>(() =>
            {
                var apiCallPath = "/Environment/KillAllOtherAgents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var killAllOtherAgents = new JObject();
                var killAllOtherAgentspropCount = 0;
                killAllOtherAgentspropCount++;
                killAllOtherAgents["Workflow"] = ExpressionConverter.ConvertO(__workflow_killAllOtherAgentsworkflow);
                if (killAllOtherAgentspropCount > 0)
                {
                    callPayload.Body = killAllOtherAgents;
                }

                return new ApiConnectionAction<KillAllOtherAgentsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessByPIDResponse> GetProcessByPID(Expression<Func<int>> getProcessByPIDprocessId, Expression<Func<string>> getProcessByPIDworkflow)
        {
            var __workflow_getProcessByPIDprocessId = WorkflowExpression.Compile(getProcessByPIDprocessId, nameof(getProcessByPIDprocessId), required: true);
            var __workflow_getProcessByPIDworkflow = WorkflowExpression.Compile(getProcessByPIDworkflow, nameof(getProcessByPIDworkflow), required: true);
            return new DeferredBodyAction<GetProcessByPIDResponse>(() =>
            {
                var apiCallPath = "/Environment/GetProcessByPID";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getProcessByPID = new JObject();
                var getProcessByPIDpropCount = 0;
                getProcessByPIDpropCount++;
                getProcessByPID["ProcessId"] = ExpressionConverter.ConvertO(__workflow_getProcessByPIDprocessId);
                getProcessByPIDpropCount++;
                getProcessByPID["Workflow"] = ExpressionConverter.ConvertO(__workflow_getProcessByPIDworkflow);
                if (getProcessByPIDpropCount > 0)
                {
                    callPayload.Body = getProcessByPID;
                }

                return new ApiConnectionAction<GetProcessByPIDResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessesResponse> GetProcesses(Expression<Func<string>> getProcessesworkflow, Expression<Func<string>> getProcessesprocessName = null, Expression<Func<bool>> getProcessesgetProcessCommandLine = null)
        {
            var __workflow_getProcessesworkflow = WorkflowExpression.Compile(getProcessesworkflow, nameof(getProcessesworkflow), required: true);
            var __workflow_getProcessesprocessName = WorkflowExpression.Compile(getProcessesprocessName, nameof(getProcessesprocessName), required: false);
            var __workflow_getProcessesgetProcessCommandLine = WorkflowExpression.Compile(getProcessesgetProcessCommandLine, nameof(getProcessesgetProcessCommandLine), required: false);
            return new DeferredBodyAction<GetProcessesResponse>(() =>
            {
                var apiCallPath = "/Environment/GetProcesses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getProcesses = new JObject();
                var getProcessespropCount = 0;
                if (__workflow_getProcessesprocessName != null)
                {
                    getProcesses["ProcessName"] = ExpressionConverter.ConvertO(__workflow_getProcessesprocessName);
                    getProcessespropCount++;
                }

                if (__workflow_getProcessesgetProcessCommandLine != null)
                {
                    if (__workflow_getProcessesgetProcessCommandLine != null)
                    {
                        getProcesses["GetProcessCommandLine"] = ExpressionConverter.ConvertO(__workflow_getProcessesgetProcessCommandLine);
                        getProcessespropCount++;
                    }

                    getProcessespropCount++;
                }
                else
                {
                    getProcesses["GetProcessCommandLine"] = false;
                    getProcessespropCount++;
                }

                getProcessespropCount++;
                getProcesses["Workflow"] = ExpressionConverter.ConvertO(__workflow_getProcessesworkflow);
                if (getProcessespropCount > 0)
                {
                    callPayload.Body = getProcesses;
                }

                return new ApiConnectionAction<GetProcessesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunProcessResponse> RunProcess(Expression<Func<string>> runProcessprocessName, Expression<Func<string>> runProcessworkflow, Expression<Func<string>> runProcessarguments = null, Expression<Func<string>> runProcessworkingDirectory = null, Expression<Func<bool>> runProcessuseShellExecute = null, Expression<Func<bool>> runProcesscreateNoWindow = null, Expression<Func<runProcesswindowStyleInput>> runProcesswindowStyle = null, Expression<Func<bool>> runProcesswaitForProcess = null, Expression<Func<bool>> runProcessredirectStandardOutput = null, Expression<Func<bool>> runProcessredirectStandardError = null, Expression<Func<bool>> runProcessredirectStandardErrorToOutput = null, Expression<Func<runProcessstandardOutputEncodingInput>> runProcessstandardOutputEncoding = null, Expression<Func<runProcessstandardErrorEncodingInput>> runProcessstandardErrorEncoding = null, Expression<Func<string>> runProcessrunAsDomain = null, Expression<Func<string>> runProcessrunAsUsername = null, Expression<Func<string>> runProcessrunAsPassword = null, Expression<Func<bool>> runProcessrunAsLoadUserProfile = null, Expression<Func<bool>> runProcessrunAsElevate = null, Expression<Func<int>> runProcesstimeoutInSeconds = null)
        {
            var __workflow_runProcessprocessName = WorkflowExpression.Compile(runProcessprocessName, nameof(runProcessprocessName), required: true);
            var __workflow_runProcessworkflow = WorkflowExpression.Compile(runProcessworkflow, nameof(runProcessworkflow), required: true);
            var __workflow_runProcessarguments = WorkflowExpression.Compile(runProcessarguments, nameof(runProcessarguments), required: false);
            var __workflow_runProcessworkingDirectory = WorkflowExpression.Compile(runProcessworkingDirectory, nameof(runProcessworkingDirectory), required: false);
            var __workflow_runProcessuseShellExecute = WorkflowExpression.Compile(runProcessuseShellExecute, nameof(runProcessuseShellExecute), required: false);
            var __workflow_runProcesscreateNoWindow = WorkflowExpression.Compile(runProcesscreateNoWindow, nameof(runProcesscreateNoWindow), required: false);
            var __workflow_runProcesswindowStyle = WorkflowExpression.Compile(runProcesswindowStyle, nameof(runProcesswindowStyle), required: false);
            var __workflow_runProcesswaitForProcess = WorkflowExpression.Compile(runProcesswaitForProcess, nameof(runProcesswaitForProcess), required: false);
            var __workflow_runProcessredirectStandardOutput = WorkflowExpression.Compile(runProcessredirectStandardOutput, nameof(runProcessredirectStandardOutput), required: false);
            var __workflow_runProcessredirectStandardError = WorkflowExpression.Compile(runProcessredirectStandardError, nameof(runProcessredirectStandardError), required: false);
            var __workflow_runProcessredirectStandardErrorToOutput = WorkflowExpression.Compile(runProcessredirectStandardErrorToOutput, nameof(runProcessredirectStandardErrorToOutput), required: false);
            var __workflow_runProcessstandardOutputEncoding = WorkflowExpression.Compile(runProcessstandardOutputEncoding, nameof(runProcessstandardOutputEncoding), required: false);
            var __workflow_runProcessstandardErrorEncoding = WorkflowExpression.Compile(runProcessstandardErrorEncoding, nameof(runProcessstandardErrorEncoding), required: false);
            var __workflow_runProcessrunAsDomain = WorkflowExpression.Compile(runProcessrunAsDomain, nameof(runProcessrunAsDomain), required: false);
            var __workflow_runProcessrunAsUsername = WorkflowExpression.Compile(runProcessrunAsUsername, nameof(runProcessrunAsUsername), required: false);
            var __workflow_runProcessrunAsPassword = WorkflowExpression.Compile(runProcessrunAsPassword, nameof(runProcessrunAsPassword), required: false);
            var __workflow_runProcessrunAsLoadUserProfile = WorkflowExpression.Compile(runProcessrunAsLoadUserProfile, nameof(runProcessrunAsLoadUserProfile), required: false);
            var __workflow_runProcessrunAsElevate = WorkflowExpression.Compile(runProcessrunAsElevate, nameof(runProcessrunAsElevate), required: false);
            var __workflow_runProcesstimeoutInSeconds = WorkflowExpression.Compile(runProcesstimeoutInSeconds, nameof(runProcesstimeoutInSeconds), required: false);
            return new DeferredBodyAction<RunProcessResponse>(() =>
            {
                var apiCallPath = "/Environment/RunProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runProcess = new JObject();
                var runProcesspropCount = 0;
                runProcesspropCount++;
                runProcess["ProcessName"] = ExpressionConverter.ConvertO(__workflow_runProcessprocessName);
                if (__workflow_runProcessarguments != null)
                {
                    runProcess["Arguments"] = ExpressionConverter.ConvertO(__workflow_runProcessarguments);
                    runProcesspropCount++;
                }

                if (__workflow_runProcessworkingDirectory != null)
                {
                    runProcess["WorkingDirectory"] = ExpressionConverter.ConvertO(__workflow_runProcessworkingDirectory);
                    runProcesspropCount++;
                }

                if (__workflow_runProcessuseShellExecute != null)
                {
                    if (__workflow_runProcessuseShellExecute != null)
                    {
                        runProcess["UseShellExecute"] = ExpressionConverter.ConvertO(__workflow_runProcessuseShellExecute);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["UseShellExecute"] = true;
                    runProcesspropCount++;
                }

                if (__workflow_runProcesscreateNoWindow != null)
                {
                    if (__workflow_runProcesscreateNoWindow != null)
                    {
                        runProcess["CreateNoWindow"] = ExpressionConverter.ConvertO(__workflow_runProcesscreateNoWindow);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["CreateNoWindow"] = false;
                    runProcesspropCount++;
                }

                if (__workflow_runProcesswindowStyle != null)
                {
                    if (__workflow_runProcesswindowStyle != null)
                    {
                        runProcess["WindowStyle"] = ExpressionConverter.ConvertO(__workflow_runProcesswindowStyle);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["WindowStyle"] = "normal";
                    runProcesspropCount++;
                }

                if (__workflow_runProcesswaitForProcess != null)
                {
                    if (__workflow_runProcesswaitForProcess != null)
                    {
                        runProcess["WaitForProcess"] = ExpressionConverter.ConvertO(__workflow_runProcesswaitForProcess);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["WaitForProcess"] = false;
                    runProcesspropCount++;
                }

                if (__workflow_runProcessredirectStandardOutput != null)
                {
                    if (__workflow_runProcessredirectStandardOutput != null)
                    {
                        runProcess["RedirectStandardOutput"] = ExpressionConverter.ConvertO(__workflow_runProcessredirectStandardOutput);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["RedirectStandardOutput"] = false;
                    runProcesspropCount++;
                }

                if (__workflow_runProcessredirectStandardError != null)
                {
                    if (__workflow_runProcessredirectStandardError != null)
                    {
                        runProcess["RedirectStandardError"] = ExpressionConverter.ConvertO(__workflow_runProcessredirectStandardError);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["RedirectStandardError"] = false;
                    runProcesspropCount++;
                }

                if (__workflow_runProcessredirectStandardErrorToOutput != null)
                {
                    if (__workflow_runProcessredirectStandardErrorToOutput != null)
                    {
                        runProcess["RedirectStandardErrorToOutput"] = ExpressionConverter.ConvertO(__workflow_runProcessredirectStandardErrorToOutput);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["RedirectStandardErrorToOutput"] = false;
                    runProcesspropCount++;
                }

                if (__workflow_runProcessstandardOutputEncoding != null)
                {
                    runProcess["StandardOutputEncoding"] = ExpressionConverter.ConvertO(__workflow_runProcessstandardOutputEncoding);
                    runProcesspropCount++;
                }

                if (__workflow_runProcessstandardErrorEncoding != null)
                {
                    runProcess["StandardErrorEncoding"] = ExpressionConverter.ConvertO(__workflow_runProcessstandardErrorEncoding);
                    runProcesspropCount++;
                }

                if (__workflow_runProcessrunAsDomain != null)
                {
                    runProcess["RunAsDomain"] = ExpressionConverter.ConvertO(__workflow_runProcessrunAsDomain);
                    runProcesspropCount++;
                }

                if (__workflow_runProcessrunAsUsername != null)
                {
                    runProcess["RunAsUsername"] = ExpressionConverter.ConvertO(__workflow_runProcessrunAsUsername);
                    runProcesspropCount++;
                }

                if (__workflow_runProcessrunAsPassword != null)
                {
                    runProcess["RunAsPassword"] = ExpressionConverter.ConvertO(__workflow_runProcessrunAsPassword);
                    runProcesspropCount++;
                }

                if (__workflow_runProcessrunAsLoadUserProfile != null)
                {
                    if (__workflow_runProcessrunAsLoadUserProfile != null)
                    {
                        runProcess["RunAsLoadUserProfile"] = ExpressionConverter.ConvertO(__workflow_runProcessrunAsLoadUserProfile);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["RunAsLoadUserProfile"] = false;
                    runProcesspropCount++;
                }

                if (__workflow_runProcessrunAsElevate != null)
                {
                    if (__workflow_runProcessrunAsElevate != null)
                    {
                        runProcess["RunAsElevate"] = ExpressionConverter.ConvertO(__workflow_runProcessrunAsElevate);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["RunAsElevate"] = false;
                    runProcesspropCount++;
                }

                if (__workflow_runProcesstimeoutInSeconds != null)
                {
                    if (__workflow_runProcesstimeoutInSeconds != null)
                    {
                        runProcess["TimeoutInSeconds"] = ExpressionConverter.ConvertO(__workflow_runProcesstimeoutInSeconds);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["TimeoutInSeconds"] = 10;
                    runProcesspropCount++;
                }

                runProcesspropCount++;
                runProcess["Workflow"] = ExpressionConverter.ConvertO(__workflow_runProcessworkflow);
                if (runProcesspropCount > 0)
                {
                    callPayload.Body = runProcess;
                }

                return new ApiConnectionAction<RunProcessResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunPowerShellProcessResponse> RunPowerShellProcess(Expression<Func<string>> runPowerShellProcessworkflow, Expression<Func<string>> runPowerShellProcesspowerShellExecutable = null, Expression<Func<string>> runPowerShellProcesspowerShellScriptFilePath = null, Expression<Func<string>> runPowerShellProcesspowerShellScriptContents = null, Expression<Func<string>> runPowerShellProcessworkingDirectory = null, Expression<Func<bool>> runPowerShellProcesscreateNoWindow = null, Expression<Func<runPowerShellProcesswindowStyleInput>> runPowerShellProcesswindowStyle = null, Expression<Func<bool>> runPowerShellProcesswaitForProcess = null, Expression<Func<bool>> runPowerShellProcessredirectStandardOutput = null, Expression<Func<bool>> runPowerShellProcessredirectStandardError = null, Expression<Func<bool>> runPowerShellProcessredirectStandardErrorToOutput = null, Expression<Func<runPowerShellProcessstandardOutputEncodingInput>> runPowerShellProcessstandardOutputEncoding = null, Expression<Func<runPowerShellProcessstandardErrorEncodingInput>> runPowerShellProcessstandardErrorEncoding = null, Expression<Func<string>> runPowerShellProcessrunAsDomain = null, Expression<Func<string>> runPowerShellProcessrunAsUsername = null, Expression<Func<string>> runPowerShellProcessrunAsPassword = null, Expression<Func<bool>> runPowerShellProcessrunAsLoadUserProfile = null, Expression<Func<bool>> runPowerShellProcessrunAsElevate = null, Expression<Func<int>> runPowerShellProcesstimeoutInSeconds = null, Expression<Func<string>> runPowerShellProcesspowerShellScriptTempFolder = null)
        {
            var __workflow_runPowerShellProcessworkflow = WorkflowExpression.Compile(runPowerShellProcessworkflow, nameof(runPowerShellProcessworkflow), required: true);
            var __workflow_runPowerShellProcesspowerShellExecutable = WorkflowExpression.Compile(runPowerShellProcesspowerShellExecutable, nameof(runPowerShellProcesspowerShellExecutable), required: false);
            var __workflow_runPowerShellProcesspowerShellScriptFilePath = WorkflowExpression.Compile(runPowerShellProcesspowerShellScriptFilePath, nameof(runPowerShellProcesspowerShellScriptFilePath), required: false);
            var __workflow_runPowerShellProcesspowerShellScriptContents = WorkflowExpression.Compile(runPowerShellProcesspowerShellScriptContents, nameof(runPowerShellProcesspowerShellScriptContents), required: false);
            var __workflow_runPowerShellProcessworkingDirectory = WorkflowExpression.Compile(runPowerShellProcessworkingDirectory, nameof(runPowerShellProcessworkingDirectory), required: false);
            var __workflow_runPowerShellProcesscreateNoWindow = WorkflowExpression.Compile(runPowerShellProcesscreateNoWindow, nameof(runPowerShellProcesscreateNoWindow), required: false);
            var __workflow_runPowerShellProcesswindowStyle = WorkflowExpression.Compile(runPowerShellProcesswindowStyle, nameof(runPowerShellProcesswindowStyle), required: false);
            var __workflow_runPowerShellProcesswaitForProcess = WorkflowExpression.Compile(runPowerShellProcesswaitForProcess, nameof(runPowerShellProcesswaitForProcess), required: false);
            var __workflow_runPowerShellProcessredirectStandardOutput = WorkflowExpression.Compile(runPowerShellProcessredirectStandardOutput, nameof(runPowerShellProcessredirectStandardOutput), required: false);
            var __workflow_runPowerShellProcessredirectStandardError = WorkflowExpression.Compile(runPowerShellProcessredirectStandardError, nameof(runPowerShellProcessredirectStandardError), required: false);
            var __workflow_runPowerShellProcessredirectStandardErrorToOutput = WorkflowExpression.Compile(runPowerShellProcessredirectStandardErrorToOutput, nameof(runPowerShellProcessredirectStandardErrorToOutput), required: false);
            var __workflow_runPowerShellProcessstandardOutputEncoding = WorkflowExpression.Compile(runPowerShellProcessstandardOutputEncoding, nameof(runPowerShellProcessstandardOutputEncoding), required: false);
            var __workflow_runPowerShellProcessstandardErrorEncoding = WorkflowExpression.Compile(runPowerShellProcessstandardErrorEncoding, nameof(runPowerShellProcessstandardErrorEncoding), required: false);
            var __workflow_runPowerShellProcessrunAsDomain = WorkflowExpression.Compile(runPowerShellProcessrunAsDomain, nameof(runPowerShellProcessrunAsDomain), required: false);
            var __workflow_runPowerShellProcessrunAsUsername = WorkflowExpression.Compile(runPowerShellProcessrunAsUsername, nameof(runPowerShellProcessrunAsUsername), required: false);
            var __workflow_runPowerShellProcessrunAsPassword = WorkflowExpression.Compile(runPowerShellProcessrunAsPassword, nameof(runPowerShellProcessrunAsPassword), required: false);
            var __workflow_runPowerShellProcessrunAsLoadUserProfile = WorkflowExpression.Compile(runPowerShellProcessrunAsLoadUserProfile, nameof(runPowerShellProcessrunAsLoadUserProfile), required: false);
            var __workflow_runPowerShellProcessrunAsElevate = WorkflowExpression.Compile(runPowerShellProcessrunAsElevate, nameof(runPowerShellProcessrunAsElevate), required: false);
            var __workflow_runPowerShellProcesstimeoutInSeconds = WorkflowExpression.Compile(runPowerShellProcesstimeoutInSeconds, nameof(runPowerShellProcesstimeoutInSeconds), required: false);
            var __workflow_runPowerShellProcesspowerShellScriptTempFolder = WorkflowExpression.Compile(runPowerShellProcesspowerShellScriptTempFolder, nameof(runPowerShellProcesspowerShellScriptTempFolder), required: false);
            return new DeferredBodyAction<RunPowerShellProcessResponse>(() =>
            {
                var apiCallPath = "/Environment/RunPowerShellProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runPowerShellProcess = new JObject();
                var runPowerShellProcesspropCount = 0;
                if (__workflow_runPowerShellProcesspowerShellExecutable != null)
                {
                    if (__workflow_runPowerShellProcesspowerShellExecutable != null)
                    {
                        runPowerShellProcess["PowerShellExecutable"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcesspowerShellExecutable);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["PowerShellExecutable"] = "PowerShell.exe";
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcesspowerShellScriptFilePath != null)
                {
                    runPowerShellProcess["PowerShellScriptFilePath"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcesspowerShellScriptFilePath);
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcesspowerShellScriptContents != null)
                {
                    runPowerShellProcess["PowerShellScriptContents"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcesspowerShellScriptContents);
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcessworkingDirectory != null)
                {
                    runPowerShellProcess["WorkingDirectory"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcessworkingDirectory);
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcesscreateNoWindow != null)
                {
                    if (__workflow_runPowerShellProcesscreateNoWindow != null)
                    {
                        runPowerShellProcess["CreateNoWindow"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcesscreateNoWindow);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["CreateNoWindow"] = true;
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcesswindowStyle != null)
                {
                    if (__workflow_runPowerShellProcesswindowStyle != null)
                    {
                        runPowerShellProcess["WindowStyle"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcesswindowStyle);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["WindowStyle"] = "normal";
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcesswaitForProcess != null)
                {
                    if (__workflow_runPowerShellProcesswaitForProcess != null)
                    {
                        runPowerShellProcess["WaitForProcess"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcesswaitForProcess);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["WaitForProcess"] = true;
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcessredirectStandardOutput != null)
                {
                    if (__workflow_runPowerShellProcessredirectStandardOutput != null)
                    {
                        runPowerShellProcess["RedirectStandardOutput"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcessredirectStandardOutput);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["RedirectStandardOutput"] = true;
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcessredirectStandardError != null)
                {
                    if (__workflow_runPowerShellProcessredirectStandardError != null)
                    {
                        runPowerShellProcess["RedirectStandardError"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcessredirectStandardError);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["RedirectStandardError"] = false;
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcessredirectStandardErrorToOutput != null)
                {
                    if (__workflow_runPowerShellProcessredirectStandardErrorToOutput != null)
                    {
                        runPowerShellProcess["RedirectStandardErrorToOutput"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcessredirectStandardErrorToOutput);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["RedirectStandardErrorToOutput"] = false;
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcessstandardOutputEncoding != null)
                {
                    runPowerShellProcess["StandardOutputEncoding"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcessstandardOutputEncoding);
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcessstandardErrorEncoding != null)
                {
                    runPowerShellProcess["StandardErrorEncoding"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcessstandardErrorEncoding);
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcessrunAsDomain != null)
                {
                    runPowerShellProcess["RunAsDomain"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcessrunAsDomain);
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcessrunAsUsername != null)
                {
                    runPowerShellProcess["RunAsUsername"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcessrunAsUsername);
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcessrunAsPassword != null)
                {
                    runPowerShellProcess["RunAsPassword"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcessrunAsPassword);
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcessrunAsLoadUserProfile != null)
                {
                    if (__workflow_runPowerShellProcessrunAsLoadUserProfile != null)
                    {
                        runPowerShellProcess["RunAsLoadUserProfile"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcessrunAsLoadUserProfile);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["RunAsLoadUserProfile"] = false;
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcessrunAsElevate != null)
                {
                    if (__workflow_runPowerShellProcessrunAsElevate != null)
                    {
                        runPowerShellProcess["RunAsElevate"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcessrunAsElevate);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["RunAsElevate"] = false;
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcesstimeoutInSeconds != null)
                {
                    if (__workflow_runPowerShellProcesstimeoutInSeconds != null)
                    {
                        runPowerShellProcess["TimeoutInSeconds"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcesstimeoutInSeconds);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["TimeoutInSeconds"] = 10;
                    runPowerShellProcesspropCount++;
                }

                if (__workflow_runPowerShellProcesspowerShellScriptTempFolder != null)
                {
                    runPowerShellProcess["PowerShellScriptTempFolder"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcesspowerShellScriptTempFolder);
                    runPowerShellProcesspropCount++;
                }

                runPowerShellProcesspropCount++;
                runPowerShellProcess["Workflow"] = ExpressionConverter.ConvertO(__workflow_runPowerShellProcessworkflow);
                if (runPowerShellProcesspropCount > 0)
                {
                    callPayload.Body = runPowerShellProcess;
                }

                return new ApiConnectionAction<RunPowerShellProcessResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetScreenResolutionResponse> GetScreenResolution(Expression<Func<string>> getScreenResolutionworkflow)
        {
            var __workflow_getScreenResolutionworkflow = WorkflowExpression.Compile(getScreenResolutionworkflow, nameof(getScreenResolutionworkflow), required: true);
            return new DeferredBodyAction<GetScreenResolutionResponse>(() =>
            {
                var apiCallPath = "/Environment/GetScreenResolution";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getScreenResolution = new JObject();
                var getScreenResolutionpropCount = 0;
                getScreenResolutionpropCount++;
                getScreenResolution["Workflow"] = ExpressionConverter.ConvertO(__workflow_getScreenResolutionworkflow);
                if (getScreenResolutionpropCount > 0)
                {
                    callPayload.Body = getScreenResolution;
                }

                return new ApiConnectionAction<GetScreenResolutionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetDefaultPrinter(Expression<Func<string>> setDefaultPrinterdefaultPrinterName, Expression<Func<string>> setDefaultPrinterworkflow)
        {
            var __workflow_setDefaultPrinterdefaultPrinterName = WorkflowExpression.Compile(setDefaultPrinterdefaultPrinterName, nameof(setDefaultPrinterdefaultPrinterName), required: true);
            var __workflow_setDefaultPrinterworkflow = WorkflowExpression.Compile(setDefaultPrinterworkflow, nameof(setDefaultPrinterworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SetDefaultPrinter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setDefaultPrinter = new JObject();
                var setDefaultPrinterpropCount = 0;
                setDefaultPrinterpropCount++;
                setDefaultPrinter["DefaultPrinterName"] = ExpressionConverter.ConvertO(__workflow_setDefaultPrinterdefaultPrinterName);
                setDefaultPrinterpropCount++;
                setDefaultPrinter["Workflow"] = ExpressionConverter.ConvertO(__workflow_setDefaultPrinterworkflow);
                if (setDefaultPrinterpropCount > 0)
                {
                    callPayload.Body = setDefaultPrinter;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDefaultPrinterResponse> GetDefaultPrinter(Expression<Func<string>> getDefaultPrinterworkflow)
        {
            var __workflow_getDefaultPrinterworkflow = WorkflowExpression.Compile(getDefaultPrinterworkflow, nameof(getDefaultPrinterworkflow), required: true);
            return new DeferredBodyAction<GetDefaultPrinterResponse>(() =>
            {
                var apiCallPath = "/Environment/GetDefaultPrinter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getDefaultPrinter = new JObject();
                var getDefaultPrinterpropCount = 0;
                getDefaultPrinterpropCount++;
                getDefaultPrinter["Workflow"] = ExpressionConverter.ConvertO(__workflow_getDefaultPrinterworkflow);
                if (getDefaultPrinterpropCount > 0)
                {
                    callPayload.Body = getDefaultPrinter;
                }

                return new ApiConnectionAction<GetDefaultPrinterResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfPrintersResponse> GetListOfPrinters(Expression<Func<string>> getListOfPrintersworkflow, Expression<Func<bool>> getListOfPrinterslistLocalPrinters = null, Expression<Func<bool>> getListOfPrinterslistNetworkPrinters = null, Expression<Func<bool>> getListOfPrintersreturnDetailedInformation = null)
        {
            var __workflow_getListOfPrintersworkflow = WorkflowExpression.Compile(getListOfPrintersworkflow, nameof(getListOfPrintersworkflow), required: true);
            var __workflow_getListOfPrinterslistLocalPrinters = WorkflowExpression.Compile(getListOfPrinterslistLocalPrinters, nameof(getListOfPrinterslistLocalPrinters), required: false);
            var __workflow_getListOfPrinterslistNetworkPrinters = WorkflowExpression.Compile(getListOfPrinterslistNetworkPrinters, nameof(getListOfPrinterslistNetworkPrinters), required: false);
            var __workflow_getListOfPrintersreturnDetailedInformation = WorkflowExpression.Compile(getListOfPrintersreturnDetailedInformation, nameof(getListOfPrintersreturnDetailedInformation), required: false);
            return new DeferredBodyAction<GetListOfPrintersResponse>(() =>
            {
                var apiCallPath = "/Environment/GetListOfPrinters";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getListOfPrinters = new JObject();
                var getListOfPrinterspropCount = 0;
                if (__workflow_getListOfPrinterslistLocalPrinters != null)
                {
                    if (__workflow_getListOfPrinterslistLocalPrinters != null)
                    {
                        getListOfPrinters["ListLocalPrinters"] = ExpressionConverter.ConvertO(__workflow_getListOfPrinterslistLocalPrinters);
                        getListOfPrinterspropCount++;
                    }

                    getListOfPrinterspropCount++;
                }
                else
                {
                    getListOfPrinters["ListLocalPrinters"] = true;
                    getListOfPrinterspropCount++;
                }

                if (__workflow_getListOfPrinterslistNetworkPrinters != null)
                {
                    if (__workflow_getListOfPrinterslistNetworkPrinters != null)
                    {
                        getListOfPrinters["ListNetworkPrinters"] = ExpressionConverter.ConvertO(__workflow_getListOfPrinterslistNetworkPrinters);
                        getListOfPrinterspropCount++;
                    }

                    getListOfPrinterspropCount++;
                }
                else
                {
                    getListOfPrinters["ListNetworkPrinters"] = false;
                    getListOfPrinterspropCount++;
                }

                if (__workflow_getListOfPrintersreturnDetailedInformation != null)
                {
                    if (__workflow_getListOfPrintersreturnDetailedInformation != null)
                    {
                        getListOfPrinters["ReturnDetailedInformation"] = ExpressionConverter.ConvertO(__workflow_getListOfPrintersreturnDetailedInformation);
                        getListOfPrinterspropCount++;
                    }

                    getListOfPrinterspropCount++;
                }
                else
                {
                    getListOfPrinters["ReturnDetailedInformation"] = false;
                    getListOfPrinterspropCount++;
                }

                getListOfPrinterspropCount++;
                getListOfPrinters["Workflow"] = ExpressionConverter.ConvertO(__workflow_getListOfPrintersworkflow);
                if (getListOfPrinterspropCount > 0)
                {
                    callPayload.Body = getListOfPrinters;
                }

                return new ApiConnectionAction<GetListOfPrintersResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetMouseMultiplier(Expression<Func<string>> setMouseMultiplierworkflow, Expression<Func<double>> setMouseMultipliermouseXMultiplier = null, Expression<Func<double>> setMouseMultipliermouseYMultiplier = null, Expression<Func<bool>> setMouseMultiplierapplyToMouseEvent = null, Expression<Func<bool>> setMouseMultiplierapplyToSetCursorPos = null, Expression<Func<bool>> setMouseMultiplierapplyToCurrentMouseMoveMethod = null)
        {
            var __workflow_setMouseMultiplierworkflow = WorkflowExpression.Compile(setMouseMultiplierworkflow, nameof(setMouseMultiplierworkflow), required: true);
            var __workflow_setMouseMultipliermouseXMultiplier = WorkflowExpression.Compile(setMouseMultipliermouseXMultiplier, nameof(setMouseMultipliermouseXMultiplier), required: false);
            var __workflow_setMouseMultipliermouseYMultiplier = WorkflowExpression.Compile(setMouseMultipliermouseYMultiplier, nameof(setMouseMultipliermouseYMultiplier), required: false);
            var __workflow_setMouseMultiplierapplyToMouseEvent = WorkflowExpression.Compile(setMouseMultiplierapplyToMouseEvent, nameof(setMouseMultiplierapplyToMouseEvent), required: false);
            var __workflow_setMouseMultiplierapplyToSetCursorPos = WorkflowExpression.Compile(setMouseMultiplierapplyToSetCursorPos, nameof(setMouseMultiplierapplyToSetCursorPos), required: false);
            var __workflow_setMouseMultiplierapplyToCurrentMouseMoveMethod = WorkflowExpression.Compile(setMouseMultiplierapplyToCurrentMouseMoveMethod, nameof(setMouseMultiplierapplyToCurrentMouseMoveMethod), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SetMouseMultiplier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setMouseMultiplier = new JObject();
                var setMouseMultiplierpropCount = 0;
                if (__workflow_setMouseMultipliermouseXMultiplier != null)
                {
                    if (__workflow_setMouseMultipliermouseXMultiplier != null)
                    {
                        setMouseMultiplier["MouseXMultiplier"] = ExpressionConverter.ConvertO(__workflow_setMouseMultipliermouseXMultiplier);
                        setMouseMultiplierpropCount++;
                    }

                    setMouseMultiplierpropCount++;
                }
                else
                {
                    setMouseMultiplier["MouseXMultiplier"] = 1;
                    setMouseMultiplierpropCount++;
                }

                if (__workflow_setMouseMultipliermouseYMultiplier != null)
                {
                    if (__workflow_setMouseMultipliermouseYMultiplier != null)
                    {
                        setMouseMultiplier["MouseYMultiplier"] = ExpressionConverter.ConvertO(__workflow_setMouseMultipliermouseYMultiplier);
                        setMouseMultiplierpropCount++;
                    }

                    setMouseMultiplierpropCount++;
                }
                else
                {
                    setMouseMultiplier["MouseYMultiplier"] = 1;
                    setMouseMultiplierpropCount++;
                }

                if (__workflow_setMouseMultiplierapplyToMouseEvent != null)
                {
                    if (__workflow_setMouseMultiplierapplyToMouseEvent != null)
                    {
                        setMouseMultiplier["ApplyToMouseEvent"] = ExpressionConverter.ConvertO(__workflow_setMouseMultiplierapplyToMouseEvent);
                        setMouseMultiplierpropCount++;
                    }

                    setMouseMultiplierpropCount++;
                }
                else
                {
                    setMouseMultiplier["ApplyToMouseEvent"] = true;
                    setMouseMultiplierpropCount++;
                }

                if (__workflow_setMouseMultiplierapplyToSetCursorPos != null)
                {
                    if (__workflow_setMouseMultiplierapplyToSetCursorPos != null)
                    {
                        setMouseMultiplier["ApplyToSetCursorPos"] = ExpressionConverter.ConvertO(__workflow_setMouseMultiplierapplyToSetCursorPos);
                        setMouseMultiplierpropCount++;
                    }

                    setMouseMultiplierpropCount++;
                }
                else
                {
                    setMouseMultiplier["ApplyToSetCursorPos"] = false;
                    setMouseMultiplierpropCount++;
                }

                if (__workflow_setMouseMultiplierapplyToCurrentMouseMoveMethod != null)
                {
                    if (__workflow_setMouseMultiplierapplyToCurrentMouseMoveMethod != null)
                    {
                        setMouseMultiplier["ApplyToCurrentMouseMoveMethod"] = ExpressionConverter.ConvertO(__workflow_setMouseMultiplierapplyToCurrentMouseMoveMethod);
                        setMouseMultiplierpropCount++;
                    }

                    setMouseMultiplierpropCount++;
                }
                else
                {
                    setMouseMultiplier["ApplyToCurrentMouseMoveMethod"] = false;
                    setMouseMultiplierpropCount++;
                }

                setMouseMultiplierpropCount++;
                setMouseMultiplier["Workflow"] = ExpressionConverter.ConvertO(__workflow_setMouseMultiplierworkflow);
                if (setMouseMultiplierpropCount > 0)
                {
                    callPayload.Body = setMouseMultiplier;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMouseMultiplierResponse> GetMouseMultiplier(Expression<Func<string>> getMouseMultiplierworkflow)
        {
            var __workflow_getMouseMultiplierworkflow = WorkflowExpression.Compile(getMouseMultiplierworkflow, nameof(getMouseMultiplierworkflow), required: true);
            return new DeferredBodyAction<GetMouseMultiplierResponse>(() =>
            {
                var apiCallPath = "/Environment/GetMouseMultiplier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getMouseMultiplier = new JObject();
                var getMouseMultiplierpropCount = 0;
                getMouseMultiplierpropCount++;
                getMouseMultiplier["Workflow"] = ExpressionConverter.ConvertO(__workflow_getMouseMultiplierworkflow);
                if (getMouseMultiplierpropCount > 0)
                {
                    callPayload.Body = getMouseMultiplier;
                }

                return new ApiConnectionAction<GetMouseMultiplierResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseToCoordinate(Expression<Func<int>> moveMouseToCoordinatexCoord, Expression<Func<int>> moveMouseToCoordinateyCoord, Expression<Func<string>> moveMouseToCoordinateworkflow)
        {
            var __workflow_moveMouseToCoordinatexCoord = WorkflowExpression.Compile(moveMouseToCoordinatexCoord, nameof(moveMouseToCoordinatexCoord), required: true);
            var __workflow_moveMouseToCoordinateyCoord = WorkflowExpression.Compile(moveMouseToCoordinateyCoord, nameof(moveMouseToCoordinateyCoord), required: true);
            var __workflow_moveMouseToCoordinateworkflow = WorkflowExpression.Compile(moveMouseToCoordinateworkflow, nameof(moveMouseToCoordinateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MoveMouseToCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var moveMouseToCoordinate = new JObject();
                var moveMouseToCoordinatepropCount = 0;
                moveMouseToCoordinatepropCount++;
                moveMouseToCoordinate["XCoord"] = ExpressionConverter.ConvertO(__workflow_moveMouseToCoordinatexCoord);
                moveMouseToCoordinatepropCount++;
                moveMouseToCoordinate["YCoord"] = ExpressionConverter.ConvertO(__workflow_moveMouseToCoordinateyCoord);
                moveMouseToCoordinatepropCount++;
                moveMouseToCoordinate["Workflow"] = ExpressionConverter.ConvertO(__workflow_moveMouseToCoordinateworkflow);
                if (moveMouseToCoordinatepropCount > 0)
                {
                    callPayload.Body = moveMouseToCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseRelative(Expression<Func<int>> moveMouseRelativexCoord, Expression<Func<int>> moveMouseRelativeyCoord, Expression<Func<string>> moveMouseRelativeworkflow)
        {
            var __workflow_moveMouseRelativexCoord = WorkflowExpression.Compile(moveMouseRelativexCoord, nameof(moveMouseRelativexCoord), required: true);
            var __workflow_moveMouseRelativeyCoord = WorkflowExpression.Compile(moveMouseRelativeyCoord, nameof(moveMouseRelativeyCoord), required: true);
            var __workflow_moveMouseRelativeworkflow = WorkflowExpression.Compile(moveMouseRelativeworkflow, nameof(moveMouseRelativeworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MoveMouseRelative";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var moveMouseRelative = new JObject();
                var moveMouseRelativepropCount = 0;
                moveMouseRelativepropCount++;
                moveMouseRelative["XCoord"] = ExpressionConverter.ConvertO(__workflow_moveMouseRelativexCoord);
                moveMouseRelativepropCount++;
                moveMouseRelative["YCoord"] = ExpressionConverter.ConvertO(__workflow_moveMouseRelativeyCoord);
                moveMouseRelativepropCount++;
                moveMouseRelative["Workflow"] = ExpressionConverter.ConvertO(__workflow_moveMouseRelativeworkflow);
                if (moveMouseRelativepropCount > 0)
                {
                    callPayload.Body = moveMouseRelative;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseButtonDown(Expression<Func<string>> leftMouseButtonDownworkflow)
        {
            var __workflow_leftMouseButtonDownworkflow = WorkflowExpression.Compile(leftMouseButtonDownworkflow, nameof(leftMouseButtonDownworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/LeftMouseButtonDown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var leftMouseButtonDown = new JObject();
                var leftMouseButtonDownpropCount = 0;
                leftMouseButtonDownpropCount++;
                leftMouseButtonDown["Workflow"] = ExpressionConverter.ConvertO(__workflow_leftMouseButtonDownworkflow);
                if (leftMouseButtonDownpropCount > 0)
                {
                    callPayload.Body = leftMouseButtonDown;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseButtonUp(Expression<Func<string>> leftMouseButtonUpworkflow)
        {
            var __workflow_leftMouseButtonUpworkflow = WorkflowExpression.Compile(leftMouseButtonUpworkflow, nameof(leftMouseButtonUpworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/LeftMouseButtonUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var leftMouseButtonUp = new JObject();
                var leftMouseButtonUppropCount = 0;
                leftMouseButtonUppropCount++;
                leftMouseButtonUp["Workflow"] = ExpressionConverter.ConvertO(__workflow_leftMouseButtonUpworkflow);
                if (leftMouseButtonUppropCount > 0)
                {
                    callPayload.Body = leftMouseButtonUp;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftClickMouse(Expression<Func<string>> leftClickMouseworkflow)
        {
            var __workflow_leftClickMouseworkflow = WorkflowExpression.Compile(leftClickMouseworkflow, nameof(leftClickMouseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/LeftClickMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var leftClickMouse = new JObject();
                var leftClickMousepropCount = 0;
                leftClickMousepropCount++;
                leftClickMouse["Workflow"] = ExpressionConverter.ConvertO(__workflow_leftClickMouseworkflow);
                if (leftClickMousepropCount > 0)
                {
                    callPayload.Body = leftClickMouse;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftClickMouseAtCoordinate(Expression<Func<int>> leftClickMouseAtCoordinatexCoord, Expression<Func<int>> leftClickMouseAtCoordinateyCoord, Expression<Func<string>> leftClickMouseAtCoordinateworkflow)
        {
            var __workflow_leftClickMouseAtCoordinatexCoord = WorkflowExpression.Compile(leftClickMouseAtCoordinatexCoord, nameof(leftClickMouseAtCoordinatexCoord), required: true);
            var __workflow_leftClickMouseAtCoordinateyCoord = WorkflowExpression.Compile(leftClickMouseAtCoordinateyCoord, nameof(leftClickMouseAtCoordinateyCoord), required: true);
            var __workflow_leftClickMouseAtCoordinateworkflow = WorkflowExpression.Compile(leftClickMouseAtCoordinateworkflow, nameof(leftClickMouseAtCoordinateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/LeftClickMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var leftClickMouseAtCoordinate = new JObject();
                var leftClickMouseAtCoordinatepropCount = 0;
                leftClickMouseAtCoordinatepropCount++;
                leftClickMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(__workflow_leftClickMouseAtCoordinatexCoord);
                leftClickMouseAtCoordinatepropCount++;
                leftClickMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(__workflow_leftClickMouseAtCoordinateyCoord);
                leftClickMouseAtCoordinatepropCount++;
                leftClickMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(__workflow_leftClickMouseAtCoordinateworkflow);
                if (leftClickMouseAtCoordinatepropCount > 0)
                {
                    callPayload.Body = leftClickMouseAtCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftHoldMouse(Expression<Func<double>> leftHoldMousesecondsToHold, Expression<Func<string>> leftHoldMouseworkflow)
        {
            var __workflow_leftHoldMousesecondsToHold = WorkflowExpression.Compile(leftHoldMousesecondsToHold, nameof(leftHoldMousesecondsToHold), required: true);
            var __workflow_leftHoldMouseworkflow = WorkflowExpression.Compile(leftHoldMouseworkflow, nameof(leftHoldMouseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/LeftHoldMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var leftHoldMouse = new JObject();
                var leftHoldMousepropCount = 0;
                leftHoldMousepropCount++;
                leftHoldMouse["SecondsToHold"] = ExpressionConverter.ConvertO(__workflow_leftHoldMousesecondsToHold);
                leftHoldMousepropCount++;
                leftHoldMouse["Workflow"] = ExpressionConverter.ConvertO(__workflow_leftHoldMouseworkflow);
                if (leftHoldMousepropCount > 0)
                {
                    callPayload.Body = leftHoldMouse;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftHoldMouseAtCoordinate(Expression<Func<int>> leftHoldMouseAtCoordinatexCoord, Expression<Func<int>> leftHoldMouseAtCoordinateyCoord, Expression<Func<double>> leftHoldMouseAtCoordinatesecondsToHold, Expression<Func<string>> leftHoldMouseAtCoordinateworkflow)
        {
            var __workflow_leftHoldMouseAtCoordinatexCoord = WorkflowExpression.Compile(leftHoldMouseAtCoordinatexCoord, nameof(leftHoldMouseAtCoordinatexCoord), required: true);
            var __workflow_leftHoldMouseAtCoordinateyCoord = WorkflowExpression.Compile(leftHoldMouseAtCoordinateyCoord, nameof(leftHoldMouseAtCoordinateyCoord), required: true);
            var __workflow_leftHoldMouseAtCoordinatesecondsToHold = WorkflowExpression.Compile(leftHoldMouseAtCoordinatesecondsToHold, nameof(leftHoldMouseAtCoordinatesecondsToHold), required: true);
            var __workflow_leftHoldMouseAtCoordinateworkflow = WorkflowExpression.Compile(leftHoldMouseAtCoordinateworkflow, nameof(leftHoldMouseAtCoordinateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/LeftHoldMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var leftHoldMouseAtCoordinate = new JObject();
                var leftHoldMouseAtCoordinatepropCount = 0;
                leftHoldMouseAtCoordinatepropCount++;
                leftHoldMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(__workflow_leftHoldMouseAtCoordinatexCoord);
                leftHoldMouseAtCoordinatepropCount++;
                leftHoldMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(__workflow_leftHoldMouseAtCoordinateyCoord);
                leftHoldMouseAtCoordinatepropCount++;
                leftHoldMouseAtCoordinate["SecondsToHold"] = ExpressionConverter.ConvertO(__workflow_leftHoldMouseAtCoordinatesecondsToHold);
                leftHoldMouseAtCoordinatepropCount++;
                leftHoldMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(__workflow_leftHoldMouseAtCoordinateworkflow);
                if (leftHoldMouseAtCoordinatepropCount > 0)
                {
                    callPayload.Body = leftHoldMouseAtCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseButtonDown(Expression<Func<string>> rightMouseButtonDownworkflow)
        {
            var __workflow_rightMouseButtonDownworkflow = WorkflowExpression.Compile(rightMouseButtonDownworkflow, nameof(rightMouseButtonDownworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/RightMouseButtonDown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rightMouseButtonDown = new JObject();
                var rightMouseButtonDownpropCount = 0;
                rightMouseButtonDownpropCount++;
                rightMouseButtonDown["Workflow"] = ExpressionConverter.ConvertO(__workflow_rightMouseButtonDownworkflow);
                if (rightMouseButtonDownpropCount > 0)
                {
                    callPayload.Body = rightMouseButtonDown;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseButtonUp(Expression<Func<string>> rightMouseButtonUpworkflow)
        {
            var __workflow_rightMouseButtonUpworkflow = WorkflowExpression.Compile(rightMouseButtonUpworkflow, nameof(rightMouseButtonUpworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/RightMouseButtonUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rightMouseButtonUp = new JObject();
                var rightMouseButtonUppropCount = 0;
                rightMouseButtonUppropCount++;
                rightMouseButtonUp["Workflow"] = ExpressionConverter.ConvertO(__workflow_rightMouseButtonUpworkflow);
                if (rightMouseButtonUppropCount > 0)
                {
                    callPayload.Body = rightMouseButtonUp;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightClickMouse(Expression<Func<string>> rightClickMouseworkflow)
        {
            var __workflow_rightClickMouseworkflow = WorkflowExpression.Compile(rightClickMouseworkflow, nameof(rightClickMouseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/RightClickMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rightClickMouse = new JObject();
                var rightClickMousepropCount = 0;
                rightClickMousepropCount++;
                rightClickMouse["Workflow"] = ExpressionConverter.ConvertO(__workflow_rightClickMouseworkflow);
                if (rightClickMousepropCount > 0)
                {
                    callPayload.Body = rightClickMouse;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightClickMouseAtCoordinate(Expression<Func<int>> rightClickMouseAtCoordinatexCoord, Expression<Func<int>> rightClickMouseAtCoordinateyCoord, Expression<Func<string>> rightClickMouseAtCoordinateworkflow)
        {
            var __workflow_rightClickMouseAtCoordinatexCoord = WorkflowExpression.Compile(rightClickMouseAtCoordinatexCoord, nameof(rightClickMouseAtCoordinatexCoord), required: true);
            var __workflow_rightClickMouseAtCoordinateyCoord = WorkflowExpression.Compile(rightClickMouseAtCoordinateyCoord, nameof(rightClickMouseAtCoordinateyCoord), required: true);
            var __workflow_rightClickMouseAtCoordinateworkflow = WorkflowExpression.Compile(rightClickMouseAtCoordinateworkflow, nameof(rightClickMouseAtCoordinateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/RightClickMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rightClickMouseAtCoordinate = new JObject();
                var rightClickMouseAtCoordinatepropCount = 0;
                rightClickMouseAtCoordinatepropCount++;
                rightClickMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(__workflow_rightClickMouseAtCoordinatexCoord);
                rightClickMouseAtCoordinatepropCount++;
                rightClickMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(__workflow_rightClickMouseAtCoordinateyCoord);
                rightClickMouseAtCoordinatepropCount++;
                rightClickMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(__workflow_rightClickMouseAtCoordinateworkflow);
                if (rightClickMouseAtCoordinatepropCount > 0)
                {
                    callPayload.Body = rightClickMouseAtCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightHoldMouse(Expression<Func<double>> rightHoldMousesecondsToHold, Expression<Func<string>> rightHoldMouseworkflow)
        {
            var __workflow_rightHoldMousesecondsToHold = WorkflowExpression.Compile(rightHoldMousesecondsToHold, nameof(rightHoldMousesecondsToHold), required: true);
            var __workflow_rightHoldMouseworkflow = WorkflowExpression.Compile(rightHoldMouseworkflow, nameof(rightHoldMouseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/RightHoldMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rightHoldMouse = new JObject();
                var rightHoldMousepropCount = 0;
                rightHoldMousepropCount++;
                rightHoldMouse["SecondsToHold"] = ExpressionConverter.ConvertO(__workflow_rightHoldMousesecondsToHold);
                rightHoldMousepropCount++;
                rightHoldMouse["Workflow"] = ExpressionConverter.ConvertO(__workflow_rightHoldMouseworkflow);
                if (rightHoldMousepropCount > 0)
                {
                    callPayload.Body = rightHoldMouse;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightHoldMouseAtCoordinate(Expression<Func<int>> rightHoldMouseAtCoordinatexCoord, Expression<Func<int>> rightHoldMouseAtCoordinateyCoord, Expression<Func<double>> rightHoldMouseAtCoordinatesecondsToHold, Expression<Func<string>> rightHoldMouseAtCoordinateworkflow)
        {
            var __workflow_rightHoldMouseAtCoordinatexCoord = WorkflowExpression.Compile(rightHoldMouseAtCoordinatexCoord, nameof(rightHoldMouseAtCoordinatexCoord), required: true);
            var __workflow_rightHoldMouseAtCoordinateyCoord = WorkflowExpression.Compile(rightHoldMouseAtCoordinateyCoord, nameof(rightHoldMouseAtCoordinateyCoord), required: true);
            var __workflow_rightHoldMouseAtCoordinatesecondsToHold = WorkflowExpression.Compile(rightHoldMouseAtCoordinatesecondsToHold, nameof(rightHoldMouseAtCoordinatesecondsToHold), required: true);
            var __workflow_rightHoldMouseAtCoordinateworkflow = WorkflowExpression.Compile(rightHoldMouseAtCoordinateworkflow, nameof(rightHoldMouseAtCoordinateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/RightHoldMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rightHoldMouseAtCoordinate = new JObject();
                var rightHoldMouseAtCoordinatepropCount = 0;
                rightHoldMouseAtCoordinatepropCount++;
                rightHoldMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(__workflow_rightHoldMouseAtCoordinatexCoord);
                rightHoldMouseAtCoordinatepropCount++;
                rightHoldMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(__workflow_rightHoldMouseAtCoordinateyCoord);
                rightHoldMouseAtCoordinatepropCount++;
                rightHoldMouseAtCoordinate["SecondsToHold"] = ExpressionConverter.ConvertO(__workflow_rightHoldMouseAtCoordinatesecondsToHold);
                rightHoldMouseAtCoordinatepropCount++;
                rightHoldMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(__workflow_rightHoldMouseAtCoordinateworkflow);
                if (rightHoldMouseAtCoordinatepropCount > 0)
                {
                    callPayload.Body = rightHoldMouseAtCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseButtonDown(Expression<Func<string>> middleMouseButtonDownworkflow)
        {
            var __workflow_middleMouseButtonDownworkflow = WorkflowExpression.Compile(middleMouseButtonDownworkflow, nameof(middleMouseButtonDownworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MiddleMouseButtonDown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var middleMouseButtonDown = new JObject();
                var middleMouseButtonDownpropCount = 0;
                middleMouseButtonDownpropCount++;
                middleMouseButtonDown["Workflow"] = ExpressionConverter.ConvertO(__workflow_middleMouseButtonDownworkflow);
                if (middleMouseButtonDownpropCount > 0)
                {
                    callPayload.Body = middleMouseButtonDown;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseButtonUp(Expression<Func<string>> middleMouseButtonUpworkflow)
        {
            var __workflow_middleMouseButtonUpworkflow = WorkflowExpression.Compile(middleMouseButtonUpworkflow, nameof(middleMouseButtonUpworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MiddleMouseButtonUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var middleMouseButtonUp = new JObject();
                var middleMouseButtonUppropCount = 0;
                middleMouseButtonUppropCount++;
                middleMouseButtonUp["Workflow"] = ExpressionConverter.ConvertO(__workflow_middleMouseButtonUpworkflow);
                if (middleMouseButtonUppropCount > 0)
                {
                    callPayload.Body = middleMouseButtonUp;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleClickMouse(Expression<Func<string>> middleClickMouseworkflow)
        {
            var __workflow_middleClickMouseworkflow = WorkflowExpression.Compile(middleClickMouseworkflow, nameof(middleClickMouseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MiddleClickMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var middleClickMouse = new JObject();
                var middleClickMousepropCount = 0;
                middleClickMousepropCount++;
                middleClickMouse["Workflow"] = ExpressionConverter.ConvertO(__workflow_middleClickMouseworkflow);
                if (middleClickMousepropCount > 0)
                {
                    callPayload.Body = middleClickMouse;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleClickMouseAtCoordinate(Expression<Func<int>> middleClickMouseAtCoordinatexCoord, Expression<Func<int>> middleClickMouseAtCoordinateyCoord, Expression<Func<string>> middleClickMouseAtCoordinateworkflow)
        {
            var __workflow_middleClickMouseAtCoordinatexCoord = WorkflowExpression.Compile(middleClickMouseAtCoordinatexCoord, nameof(middleClickMouseAtCoordinatexCoord), required: true);
            var __workflow_middleClickMouseAtCoordinateyCoord = WorkflowExpression.Compile(middleClickMouseAtCoordinateyCoord, nameof(middleClickMouseAtCoordinateyCoord), required: true);
            var __workflow_middleClickMouseAtCoordinateworkflow = WorkflowExpression.Compile(middleClickMouseAtCoordinateworkflow, nameof(middleClickMouseAtCoordinateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MiddleClickMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var middleClickMouseAtCoordinate = new JObject();
                var middleClickMouseAtCoordinatepropCount = 0;
                middleClickMouseAtCoordinatepropCount++;
                middleClickMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(__workflow_middleClickMouseAtCoordinatexCoord);
                middleClickMouseAtCoordinatepropCount++;
                middleClickMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(__workflow_middleClickMouseAtCoordinateyCoord);
                middleClickMouseAtCoordinatepropCount++;
                middleClickMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(__workflow_middleClickMouseAtCoordinateworkflow);
                if (middleClickMouseAtCoordinatepropCount > 0)
                {
                    callPayload.Body = middleClickMouseAtCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleHoldMouse(Expression<Func<double>> middleHoldMousesecondsToHold, Expression<Func<string>> middleHoldMouseworkflow)
        {
            var __workflow_middleHoldMousesecondsToHold = WorkflowExpression.Compile(middleHoldMousesecondsToHold, nameof(middleHoldMousesecondsToHold), required: true);
            var __workflow_middleHoldMouseworkflow = WorkflowExpression.Compile(middleHoldMouseworkflow, nameof(middleHoldMouseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MiddleHoldMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var middleHoldMouse = new JObject();
                var middleHoldMousepropCount = 0;
                middleHoldMousepropCount++;
                middleHoldMouse["SecondsToHold"] = ExpressionConverter.ConvertO(__workflow_middleHoldMousesecondsToHold);
                middleHoldMousepropCount++;
                middleHoldMouse["Workflow"] = ExpressionConverter.ConvertO(__workflow_middleHoldMouseworkflow);
                if (middleHoldMousepropCount > 0)
                {
                    callPayload.Body = middleHoldMouse;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleHoldMouseAtCoordinate(Expression<Func<int>> middleHoldMouseAtCoordinatexCoord, Expression<Func<int>> middleHoldMouseAtCoordinateyCoord, Expression<Func<double>> middleHoldMouseAtCoordinatesecondsToHold, Expression<Func<string>> middleHoldMouseAtCoordinateworkflow)
        {
            var __workflow_middleHoldMouseAtCoordinatexCoord = WorkflowExpression.Compile(middleHoldMouseAtCoordinatexCoord, nameof(middleHoldMouseAtCoordinatexCoord), required: true);
            var __workflow_middleHoldMouseAtCoordinateyCoord = WorkflowExpression.Compile(middleHoldMouseAtCoordinateyCoord, nameof(middleHoldMouseAtCoordinateyCoord), required: true);
            var __workflow_middleHoldMouseAtCoordinatesecondsToHold = WorkflowExpression.Compile(middleHoldMouseAtCoordinatesecondsToHold, nameof(middleHoldMouseAtCoordinatesecondsToHold), required: true);
            var __workflow_middleHoldMouseAtCoordinateworkflow = WorkflowExpression.Compile(middleHoldMouseAtCoordinateworkflow, nameof(middleHoldMouseAtCoordinateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MiddleHoldMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var middleHoldMouseAtCoordinate = new JObject();
                var middleHoldMouseAtCoordinatepropCount = 0;
                middleHoldMouseAtCoordinatepropCount++;
                middleHoldMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(__workflow_middleHoldMouseAtCoordinatexCoord);
                middleHoldMouseAtCoordinatepropCount++;
                middleHoldMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(__workflow_middleHoldMouseAtCoordinateyCoord);
                middleHoldMouseAtCoordinatepropCount++;
                middleHoldMouseAtCoordinate["SecondsToHold"] = ExpressionConverter.ConvertO(__workflow_middleHoldMouseAtCoordinatesecondsToHold);
                middleHoldMouseAtCoordinatepropCount++;
                middleHoldMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(__workflow_middleHoldMouseAtCoordinateworkflow);
                if (middleHoldMouseAtCoordinatepropCount > 0)
                {
                    callPayload.Body = middleHoldMouseAtCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DoubleLeftClickMouse(Expression<Func<string>> doubleLeftClickMouseworkflow, Expression<Func<int>> doubleLeftClickMousedelayInMilliseconds = null)
        {
            var __workflow_doubleLeftClickMouseworkflow = WorkflowExpression.Compile(doubleLeftClickMouseworkflow, nameof(doubleLeftClickMouseworkflow), required: true);
            var __workflow_doubleLeftClickMousedelayInMilliseconds = WorkflowExpression.Compile(doubleLeftClickMousedelayInMilliseconds, nameof(doubleLeftClickMousedelayInMilliseconds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/DoubleLeftClickMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var doubleLeftClickMouse = new JObject();
                var doubleLeftClickMousepropCount = 0;
                if (__workflow_doubleLeftClickMousedelayInMilliseconds != null)
                {
                    if (__workflow_doubleLeftClickMousedelayInMilliseconds != null)
                    {
                        doubleLeftClickMouse["DelayInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_doubleLeftClickMousedelayInMilliseconds);
                        doubleLeftClickMousepropCount++;
                    }

                    doubleLeftClickMousepropCount++;
                }
                else
                {
                    doubleLeftClickMouse["DelayInMilliseconds"] = 10;
                    doubleLeftClickMousepropCount++;
                }

                doubleLeftClickMousepropCount++;
                doubleLeftClickMouse["Workflow"] = ExpressionConverter.ConvertO(__workflow_doubleLeftClickMouseworkflow);
                if (doubleLeftClickMousepropCount > 0)
                {
                    callPayload.Body = doubleLeftClickMouse;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DoubleLeftClickMouseAtCoordinate(Expression<Func<int>> doubleLeftClickMouseAtCoordinatexCoord, Expression<Func<int>> doubleLeftClickMouseAtCoordinateyCoord, Expression<Func<string>> doubleLeftClickMouseAtCoordinateworkflow, Expression<Func<int>> doubleLeftClickMouseAtCoordinatedelayInMilliseconds = null)
        {
            var __workflow_doubleLeftClickMouseAtCoordinatexCoord = WorkflowExpression.Compile(doubleLeftClickMouseAtCoordinatexCoord, nameof(doubleLeftClickMouseAtCoordinatexCoord), required: true);
            var __workflow_doubleLeftClickMouseAtCoordinateyCoord = WorkflowExpression.Compile(doubleLeftClickMouseAtCoordinateyCoord, nameof(doubleLeftClickMouseAtCoordinateyCoord), required: true);
            var __workflow_doubleLeftClickMouseAtCoordinateworkflow = WorkflowExpression.Compile(doubleLeftClickMouseAtCoordinateworkflow, nameof(doubleLeftClickMouseAtCoordinateworkflow), required: true);
            var __workflow_doubleLeftClickMouseAtCoordinatedelayInMilliseconds = WorkflowExpression.Compile(doubleLeftClickMouseAtCoordinatedelayInMilliseconds, nameof(doubleLeftClickMouseAtCoordinatedelayInMilliseconds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/DoubleLeftClickMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var doubleLeftClickMouseAtCoordinate = new JObject();
                var doubleLeftClickMouseAtCoordinatepropCount = 0;
                doubleLeftClickMouseAtCoordinatepropCount++;
                doubleLeftClickMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(__workflow_doubleLeftClickMouseAtCoordinatexCoord);
                doubleLeftClickMouseAtCoordinatepropCount++;
                doubleLeftClickMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(__workflow_doubleLeftClickMouseAtCoordinateyCoord);
                if (__workflow_doubleLeftClickMouseAtCoordinatedelayInMilliseconds != null)
                {
                    if (__workflow_doubleLeftClickMouseAtCoordinatedelayInMilliseconds != null)
                    {
                        doubleLeftClickMouseAtCoordinate["DelayInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_doubleLeftClickMouseAtCoordinatedelayInMilliseconds);
                        doubleLeftClickMouseAtCoordinatepropCount++;
                    }

                    doubleLeftClickMouseAtCoordinatepropCount++;
                }
                else
                {
                    doubleLeftClickMouseAtCoordinate["DelayInMilliseconds"] = 10;
                    doubleLeftClickMouseAtCoordinatepropCount++;
                }

                doubleLeftClickMouseAtCoordinatepropCount++;
                doubleLeftClickMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(__workflow_doubleLeftClickMouseAtCoordinateworkflow);
                if (doubleLeftClickMouseAtCoordinatepropCount > 0)
                {
                    callPayload.Body = doubleLeftClickMouseAtCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseDragBetweenCoordinates(Expression<Func<int>> leftMouseDragBetweenCoordinatesstartXCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesstartYCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesendXCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesendYCoord, Expression<Func<string>> leftMouseDragBetweenCoordinatesworkflow, Expression<Func<int>> leftMouseDragBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> leftMouseDragBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            var __workflow_leftMouseDragBetweenCoordinatesstartXCoord = WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesstartXCoord, nameof(leftMouseDragBetweenCoordinatesstartXCoord), required: true);
            var __workflow_leftMouseDragBetweenCoordinatesstartYCoord = WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesstartYCoord, nameof(leftMouseDragBetweenCoordinatesstartYCoord), required: true);
            var __workflow_leftMouseDragBetweenCoordinatesendXCoord = WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesendXCoord, nameof(leftMouseDragBetweenCoordinatesendXCoord), required: true);
            var __workflow_leftMouseDragBetweenCoordinatesendYCoord = WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesendYCoord, nameof(leftMouseDragBetweenCoordinatesendYCoord), required: true);
            var __workflow_leftMouseDragBetweenCoordinatesworkflow = WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesworkflow, nameof(leftMouseDragBetweenCoordinatesworkflow), required: true);
            var __workflow_leftMouseDragBetweenCoordinatesnumberOfSteps = WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesnumberOfSteps, nameof(leftMouseDragBetweenCoordinatesnumberOfSteps), required: false);
            var __workflow_leftMouseDragBetweenCoordinatestotalTimeInSeconds = WorkflowExpression.Compile(leftMouseDragBetweenCoordinatestotalTimeInSeconds, nameof(leftMouseDragBetweenCoordinatestotalTimeInSeconds), required: false);
            var __workflow_leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter = WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter, nameof(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter), required: false);
            var __workflow_leftMouseDragBetweenCoordinatesmaximumEndPixelJitter = WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesmaximumEndPixelJitter, nameof(leftMouseDragBetweenCoordinatesmaximumEndPixelJitter), required: false);
            var __workflow_leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta, nameof(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/LeftMouseDragBetweenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var leftMouseDragBetweenCoordinates = new JObject();
                var leftMouseDragBetweenCoordinatespropCount = 0;
                leftMouseDragBetweenCoordinatespropCount++;
                leftMouseDragBetweenCoordinates["StartXCoord"] = ExpressionConverter.ConvertO(__workflow_leftMouseDragBetweenCoordinatesstartXCoord);
                leftMouseDragBetweenCoordinatespropCount++;
                leftMouseDragBetweenCoordinates["StartYCoord"] = ExpressionConverter.ConvertO(__workflow_leftMouseDragBetweenCoordinatesstartYCoord);
                leftMouseDragBetweenCoordinatespropCount++;
                leftMouseDragBetweenCoordinates["EndXCoord"] = ExpressionConverter.ConvertO(__workflow_leftMouseDragBetweenCoordinatesendXCoord);
                leftMouseDragBetweenCoordinatespropCount++;
                leftMouseDragBetweenCoordinates["EndYCoord"] = ExpressionConverter.ConvertO(__workflow_leftMouseDragBetweenCoordinatesendYCoord);
                if (__workflow_leftMouseDragBetweenCoordinatesnumberOfSteps != null)
                {
                    if (__workflow_leftMouseDragBetweenCoordinatesnumberOfSteps != null)
                    {
                        leftMouseDragBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(__workflow_leftMouseDragBetweenCoordinatesnumberOfSteps);
                        leftMouseDragBetweenCoordinatespropCount++;
                    }

                    leftMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    leftMouseDragBetweenCoordinates["NumberOfSteps"] = 20;
                    leftMouseDragBetweenCoordinatespropCount++;
                }

                if (__workflow_leftMouseDragBetweenCoordinatestotalTimeInSeconds != null)
                {
                    if (__workflow_leftMouseDragBetweenCoordinatestotalTimeInSeconds != null)
                    {
                        leftMouseDragBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(__workflow_leftMouseDragBetweenCoordinatestotalTimeInSeconds);
                        leftMouseDragBetweenCoordinatespropCount++;
                    }

                    leftMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    leftMouseDragBetweenCoordinates["TotalTimeInSeconds"] = 0.5;
                    leftMouseDragBetweenCoordinatespropCount++;
                }

                if (__workflow_leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter != null)
                {
                    leftMouseDragBetweenCoordinates["MaximumMovementPixelJitter"] = ExpressionConverter.ConvertO(__workflow_leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter);
                    leftMouseDragBetweenCoordinatespropCount++;
                }

                if (__workflow_leftMouseDragBetweenCoordinatesmaximumEndPixelJitter != null)
                {
                    leftMouseDragBetweenCoordinates["MaximumEndPixelJitter"] = ExpressionConverter.ConvertO(__workflow_leftMouseDragBetweenCoordinatesmaximumEndPixelJitter);
                    leftMouseDragBetweenCoordinatespropCount++;
                }

                if (__workflow_leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                {
                    if (__workflow_leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                    {
                        leftMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(__workflow_leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
                        leftMouseDragBetweenCoordinatespropCount++;
                    }

                    leftMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    leftMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = 2;
                    leftMouseDragBetweenCoordinatespropCount++;
                }

                leftMouseDragBetweenCoordinatespropCount++;
                leftMouseDragBetweenCoordinates["Workflow"] = ExpressionConverter.ConvertO(__workflow_leftMouseDragBetweenCoordinatesworkflow);
                if (leftMouseDragBetweenCoordinatespropCount > 0)
                {
                    callPayload.Body = leftMouseDragBetweenCoordinates;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseDragBetweenCoordinates(Expression<Func<int>> rightMouseDragBetweenCoordinatesstartXCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesstartYCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesendXCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesendYCoord, Expression<Func<string>> rightMouseDragBetweenCoordinatesworkflow, Expression<Func<int>> rightMouseDragBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> rightMouseDragBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            var __workflow_rightMouseDragBetweenCoordinatesstartXCoord = WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesstartXCoord, nameof(rightMouseDragBetweenCoordinatesstartXCoord), required: true);
            var __workflow_rightMouseDragBetweenCoordinatesstartYCoord = WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesstartYCoord, nameof(rightMouseDragBetweenCoordinatesstartYCoord), required: true);
            var __workflow_rightMouseDragBetweenCoordinatesendXCoord = WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesendXCoord, nameof(rightMouseDragBetweenCoordinatesendXCoord), required: true);
            var __workflow_rightMouseDragBetweenCoordinatesendYCoord = WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesendYCoord, nameof(rightMouseDragBetweenCoordinatesendYCoord), required: true);
            var __workflow_rightMouseDragBetweenCoordinatesworkflow = WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesworkflow, nameof(rightMouseDragBetweenCoordinatesworkflow), required: true);
            var __workflow_rightMouseDragBetweenCoordinatesnumberOfSteps = WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesnumberOfSteps, nameof(rightMouseDragBetweenCoordinatesnumberOfSteps), required: false);
            var __workflow_rightMouseDragBetweenCoordinatestotalTimeInSeconds = WorkflowExpression.Compile(rightMouseDragBetweenCoordinatestotalTimeInSeconds, nameof(rightMouseDragBetweenCoordinatestotalTimeInSeconds), required: false);
            var __workflow_rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter = WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter, nameof(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter), required: false);
            var __workflow_rightMouseDragBetweenCoordinatesmaximumEndPixelJitter = WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesmaximumEndPixelJitter, nameof(rightMouseDragBetweenCoordinatesmaximumEndPixelJitter), required: false);
            var __workflow_rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta, nameof(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/RightMouseDragBetweenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rightMouseDragBetweenCoordinates = new JObject();
                var rightMouseDragBetweenCoordinatespropCount = 0;
                rightMouseDragBetweenCoordinatespropCount++;
                rightMouseDragBetweenCoordinates["StartXCoord"] = ExpressionConverter.ConvertO(__workflow_rightMouseDragBetweenCoordinatesstartXCoord);
                rightMouseDragBetweenCoordinatespropCount++;
                rightMouseDragBetweenCoordinates["StartYCoord"] = ExpressionConverter.ConvertO(__workflow_rightMouseDragBetweenCoordinatesstartYCoord);
                rightMouseDragBetweenCoordinatespropCount++;
                rightMouseDragBetweenCoordinates["EndXCoord"] = ExpressionConverter.ConvertO(__workflow_rightMouseDragBetweenCoordinatesendXCoord);
                rightMouseDragBetweenCoordinatespropCount++;
                rightMouseDragBetweenCoordinates["EndYCoord"] = ExpressionConverter.ConvertO(__workflow_rightMouseDragBetweenCoordinatesendYCoord);
                if (__workflow_rightMouseDragBetweenCoordinatesnumberOfSteps != null)
                {
                    if (__workflow_rightMouseDragBetweenCoordinatesnumberOfSteps != null)
                    {
                        rightMouseDragBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(__workflow_rightMouseDragBetweenCoordinatesnumberOfSteps);
                        rightMouseDragBetweenCoordinatespropCount++;
                    }

                    rightMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    rightMouseDragBetweenCoordinates["NumberOfSteps"] = 20;
                    rightMouseDragBetweenCoordinatespropCount++;
                }

                if (__workflow_rightMouseDragBetweenCoordinatestotalTimeInSeconds != null)
                {
                    if (__workflow_rightMouseDragBetweenCoordinatestotalTimeInSeconds != null)
                    {
                        rightMouseDragBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(__workflow_rightMouseDragBetweenCoordinatestotalTimeInSeconds);
                        rightMouseDragBetweenCoordinatespropCount++;
                    }

                    rightMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    rightMouseDragBetweenCoordinates["TotalTimeInSeconds"] = 0.5;
                    rightMouseDragBetweenCoordinatespropCount++;
                }

                if (__workflow_rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter != null)
                {
                    rightMouseDragBetweenCoordinates["MaximumMovementPixelJitter"] = ExpressionConverter.ConvertO(__workflow_rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter);
                    rightMouseDragBetweenCoordinatespropCount++;
                }

                if (__workflow_rightMouseDragBetweenCoordinatesmaximumEndPixelJitter != null)
                {
                    rightMouseDragBetweenCoordinates["MaximumEndPixelJitter"] = ExpressionConverter.ConvertO(__workflow_rightMouseDragBetweenCoordinatesmaximumEndPixelJitter);
                    rightMouseDragBetweenCoordinatespropCount++;
                }

                if (__workflow_rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                {
                    if (__workflow_rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                    {
                        rightMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(__workflow_rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
                        rightMouseDragBetweenCoordinatespropCount++;
                    }

                    rightMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    rightMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = 2;
                    rightMouseDragBetweenCoordinatespropCount++;
                }

                rightMouseDragBetweenCoordinatespropCount++;
                rightMouseDragBetweenCoordinates["Workflow"] = ExpressionConverter.ConvertO(__workflow_rightMouseDragBetweenCoordinatesworkflow);
                if (rightMouseDragBetweenCoordinatespropCount > 0)
                {
                    callPayload.Body = rightMouseDragBetweenCoordinates;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseDragBetweenCoordinates(Expression<Func<int>> middleMouseDragBetweenCoordinatesstartXCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesstartYCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesendXCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesendYCoord, Expression<Func<string>> middleMouseDragBetweenCoordinatesworkflow, Expression<Func<int>> middleMouseDragBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> middleMouseDragBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            var __workflow_middleMouseDragBetweenCoordinatesstartXCoord = WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesstartXCoord, nameof(middleMouseDragBetweenCoordinatesstartXCoord), required: true);
            var __workflow_middleMouseDragBetweenCoordinatesstartYCoord = WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesstartYCoord, nameof(middleMouseDragBetweenCoordinatesstartYCoord), required: true);
            var __workflow_middleMouseDragBetweenCoordinatesendXCoord = WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesendXCoord, nameof(middleMouseDragBetweenCoordinatesendXCoord), required: true);
            var __workflow_middleMouseDragBetweenCoordinatesendYCoord = WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesendYCoord, nameof(middleMouseDragBetweenCoordinatesendYCoord), required: true);
            var __workflow_middleMouseDragBetweenCoordinatesworkflow = WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesworkflow, nameof(middleMouseDragBetweenCoordinatesworkflow), required: true);
            var __workflow_middleMouseDragBetweenCoordinatesnumberOfSteps = WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesnumberOfSteps, nameof(middleMouseDragBetweenCoordinatesnumberOfSteps), required: false);
            var __workflow_middleMouseDragBetweenCoordinatestotalTimeInSeconds = WorkflowExpression.Compile(middleMouseDragBetweenCoordinatestotalTimeInSeconds, nameof(middleMouseDragBetweenCoordinatestotalTimeInSeconds), required: false);
            var __workflow_middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter = WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter, nameof(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter), required: false);
            var __workflow_middleMouseDragBetweenCoordinatesmaximumEndPixelJitter = WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesmaximumEndPixelJitter, nameof(middleMouseDragBetweenCoordinatesmaximumEndPixelJitter), required: false);
            var __workflow_middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta, nameof(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MiddleMouseDragBetweenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var middleMouseDragBetweenCoordinates = new JObject();
                var middleMouseDragBetweenCoordinatespropCount = 0;
                middleMouseDragBetweenCoordinatespropCount++;
                middleMouseDragBetweenCoordinates["StartXCoord"] = ExpressionConverter.ConvertO(__workflow_middleMouseDragBetweenCoordinatesstartXCoord);
                middleMouseDragBetweenCoordinatespropCount++;
                middleMouseDragBetweenCoordinates["StartYCoord"] = ExpressionConverter.ConvertO(__workflow_middleMouseDragBetweenCoordinatesstartYCoord);
                middleMouseDragBetweenCoordinatespropCount++;
                middleMouseDragBetweenCoordinates["EndXCoord"] = ExpressionConverter.ConvertO(__workflow_middleMouseDragBetweenCoordinatesendXCoord);
                middleMouseDragBetweenCoordinatespropCount++;
                middleMouseDragBetweenCoordinates["EndYCoord"] = ExpressionConverter.ConvertO(__workflow_middleMouseDragBetweenCoordinatesendYCoord);
                if (__workflow_middleMouseDragBetweenCoordinatesnumberOfSteps != null)
                {
                    if (__workflow_middleMouseDragBetweenCoordinatesnumberOfSteps != null)
                    {
                        middleMouseDragBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(__workflow_middleMouseDragBetweenCoordinatesnumberOfSteps);
                        middleMouseDragBetweenCoordinatespropCount++;
                    }

                    middleMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    middleMouseDragBetweenCoordinates["NumberOfSteps"] = 20;
                    middleMouseDragBetweenCoordinatespropCount++;
                }

                if (__workflow_middleMouseDragBetweenCoordinatestotalTimeInSeconds != null)
                {
                    if (__workflow_middleMouseDragBetweenCoordinatestotalTimeInSeconds != null)
                    {
                        middleMouseDragBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(__workflow_middleMouseDragBetweenCoordinatestotalTimeInSeconds);
                        middleMouseDragBetweenCoordinatespropCount++;
                    }

                    middleMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    middleMouseDragBetweenCoordinates["TotalTimeInSeconds"] = 0.5;
                    middleMouseDragBetweenCoordinatespropCount++;
                }

                if (__workflow_middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter != null)
                {
                    middleMouseDragBetweenCoordinates["MaximumMovementPixelJitter"] = ExpressionConverter.ConvertO(__workflow_middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter);
                    middleMouseDragBetweenCoordinatespropCount++;
                }

                if (__workflow_middleMouseDragBetweenCoordinatesmaximumEndPixelJitter != null)
                {
                    middleMouseDragBetweenCoordinates["MaximumEndPixelJitter"] = ExpressionConverter.ConvertO(__workflow_middleMouseDragBetweenCoordinatesmaximumEndPixelJitter);
                    middleMouseDragBetweenCoordinatespropCount++;
                }

                if (__workflow_middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                {
                    if (__workflow_middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                    {
                        middleMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(__workflow_middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
                        middleMouseDragBetweenCoordinatespropCount++;
                    }

                    middleMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    middleMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = 2;
                    middleMouseDragBetweenCoordinatespropCount++;
                }

                middleMouseDragBetweenCoordinatespropCount++;
                middleMouseDragBetweenCoordinates["Workflow"] = ExpressionConverter.ConvertO(__workflow_middleMouseDragBetweenCoordinatesworkflow);
                if (middleMouseDragBetweenCoordinatespropCount > 0)
                {
                    callPayload.Body = middleMouseDragBetweenCoordinates;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseBetweenCoordinates(Expression<Func<int>> moveMouseBetweenCoordinatesstartXCoord, Expression<Func<int>> moveMouseBetweenCoordinatesstartYCoord, Expression<Func<int>> moveMouseBetweenCoordinatesendXCoord, Expression<Func<int>> moveMouseBetweenCoordinatesendYCoord, Expression<Func<string>> moveMouseBetweenCoordinatesworkflow, Expression<Func<int>> moveMouseBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> moveMouseBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> moveMouseBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> moveMouseBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            var __workflow_moveMouseBetweenCoordinatesstartXCoord = WorkflowExpression.Compile(moveMouseBetweenCoordinatesstartXCoord, nameof(moveMouseBetweenCoordinatesstartXCoord), required: true);
            var __workflow_moveMouseBetweenCoordinatesstartYCoord = WorkflowExpression.Compile(moveMouseBetweenCoordinatesstartYCoord, nameof(moveMouseBetweenCoordinatesstartYCoord), required: true);
            var __workflow_moveMouseBetweenCoordinatesendXCoord = WorkflowExpression.Compile(moveMouseBetweenCoordinatesendXCoord, nameof(moveMouseBetweenCoordinatesendXCoord), required: true);
            var __workflow_moveMouseBetweenCoordinatesendYCoord = WorkflowExpression.Compile(moveMouseBetweenCoordinatesendYCoord, nameof(moveMouseBetweenCoordinatesendYCoord), required: true);
            var __workflow_moveMouseBetweenCoordinatesworkflow = WorkflowExpression.Compile(moveMouseBetweenCoordinatesworkflow, nameof(moveMouseBetweenCoordinatesworkflow), required: true);
            var __workflow_moveMouseBetweenCoordinatesnumberOfSteps = WorkflowExpression.Compile(moveMouseBetweenCoordinatesnumberOfSteps, nameof(moveMouseBetweenCoordinatesnumberOfSteps), required: false);
            var __workflow_moveMouseBetweenCoordinatestotalTimeInSeconds = WorkflowExpression.Compile(moveMouseBetweenCoordinatestotalTimeInSeconds, nameof(moveMouseBetweenCoordinatestotalTimeInSeconds), required: false);
            var __workflow_moveMouseBetweenCoordinatesmaximumMovementPixelJitter = WorkflowExpression.Compile(moveMouseBetweenCoordinatesmaximumMovementPixelJitter, nameof(moveMouseBetweenCoordinatesmaximumMovementPixelJitter), required: false);
            var __workflow_moveMouseBetweenCoordinatesmaximumEndPixelJitter = WorkflowExpression.Compile(moveMouseBetweenCoordinatesmaximumEndPixelJitter, nameof(moveMouseBetweenCoordinatesmaximumEndPixelJitter), required: false);
            var __workflow_moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta = WorkflowExpression.Compile(moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta, nameof(moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MoveMouseBetweenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var moveMouseBetweenCoordinates = new JObject();
                var moveMouseBetweenCoordinatespropCount = 0;
                moveMouseBetweenCoordinatespropCount++;
                moveMouseBetweenCoordinates["StartXCoord"] = ExpressionConverter.ConvertO(__workflow_moveMouseBetweenCoordinatesstartXCoord);
                moveMouseBetweenCoordinatespropCount++;
                moveMouseBetweenCoordinates["StartYCoord"] = ExpressionConverter.ConvertO(__workflow_moveMouseBetweenCoordinatesstartYCoord);
                moveMouseBetweenCoordinatespropCount++;
                moveMouseBetweenCoordinates["EndXCoord"] = ExpressionConverter.ConvertO(__workflow_moveMouseBetweenCoordinatesendXCoord);
                moveMouseBetweenCoordinatespropCount++;
                moveMouseBetweenCoordinates["EndYCoord"] = ExpressionConverter.ConvertO(__workflow_moveMouseBetweenCoordinatesendYCoord);
                if (__workflow_moveMouseBetweenCoordinatesnumberOfSteps != null)
                {
                    if (__workflow_moveMouseBetweenCoordinatesnumberOfSteps != null)
                    {
                        moveMouseBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(__workflow_moveMouseBetweenCoordinatesnumberOfSteps);
                        moveMouseBetweenCoordinatespropCount++;
                    }

                    moveMouseBetweenCoordinatespropCount++;
                }
                else
                {
                    moveMouseBetweenCoordinates["NumberOfSteps"] = 20;
                    moveMouseBetweenCoordinatespropCount++;
                }

                if (__workflow_moveMouseBetweenCoordinatestotalTimeInSeconds != null)
                {
                    if (__workflow_moveMouseBetweenCoordinatestotalTimeInSeconds != null)
                    {
                        moveMouseBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(__workflow_moveMouseBetweenCoordinatestotalTimeInSeconds);
                        moveMouseBetweenCoordinatespropCount++;
                    }

                    moveMouseBetweenCoordinatespropCount++;
                }
                else
                {
                    moveMouseBetweenCoordinates["TotalTimeInSeconds"] = 0.5;
                    moveMouseBetweenCoordinatespropCount++;
                }

                if (__workflow_moveMouseBetweenCoordinatesmaximumMovementPixelJitter != null)
                {
                    moveMouseBetweenCoordinates["MaximumMovementPixelJitter"] = ExpressionConverter.ConvertO(__workflow_moveMouseBetweenCoordinatesmaximumMovementPixelJitter);
                    moveMouseBetweenCoordinatespropCount++;
                }

                if (__workflow_moveMouseBetweenCoordinatesmaximumEndPixelJitter != null)
                {
                    moveMouseBetweenCoordinates["MaximumEndPixelJitter"] = ExpressionConverter.ConvertO(__workflow_moveMouseBetweenCoordinatesmaximumEndPixelJitter);
                    moveMouseBetweenCoordinatespropCount++;
                }

                if (__workflow_moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                {
                    if (__workflow_moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                    {
                        moveMouseBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(__workflow_moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta);
                        moveMouseBetweenCoordinatespropCount++;
                    }

                    moveMouseBetweenCoordinatespropCount++;
                }
                else
                {
                    moveMouseBetweenCoordinates["MaximumMovementPixelJitterDelta"] = 2;
                    moveMouseBetweenCoordinatespropCount++;
                }

                moveMouseBetweenCoordinatespropCount++;
                moveMouseBetweenCoordinates["Workflow"] = ExpressionConverter.ConvertO(__workflow_moveMouseBetweenCoordinatesworkflow);
                if (moveMouseBetweenCoordinatespropCount > 0)
                {
                    callPayload.Body = moveMouseBetweenCoordinates;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction TurnMouseWheel(Expression<Func<int>> turnMouseWheelwheelTurns, Expression<Func<string>> turnMouseWheelworkflow)
        {
            var __workflow_turnMouseWheelwheelTurns = WorkflowExpression.Compile(turnMouseWheelwheelTurns, nameof(turnMouseWheelwheelTurns), required: true);
            var __workflow_turnMouseWheelworkflow = WorkflowExpression.Compile(turnMouseWheelworkflow, nameof(turnMouseWheelworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/TurnMouseWheel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var turnMouseWheel = new JObject();
                var turnMouseWheelpropCount = 0;
                turnMouseWheelpropCount++;
                turnMouseWheel["WheelTurns"] = ExpressionConverter.ConvertO(__workflow_turnMouseWheelwheelTurns);
                turnMouseWheelpropCount++;
                turnMouseWheel["Workflow"] = ExpressionConverter.ConvertO(__workflow_turnMouseWheelworkflow);
                if (turnMouseWheelpropCount > 0)
                {
                    callPayload.Body = turnMouseWheel;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetCursorPos(Expression<Func<int>> setCursorPosx, Expression<Func<int>> setCursorPosy, Expression<Func<string>> setCursorPosworkflow)
        {
            var __workflow_setCursorPosx = WorkflowExpression.Compile(setCursorPosx, nameof(setCursorPosx), required: true);
            var __workflow_setCursorPosy = WorkflowExpression.Compile(setCursorPosy, nameof(setCursorPosy), required: true);
            var __workflow_setCursorPosworkflow = WorkflowExpression.Compile(setCursorPosworkflow, nameof(setCursorPosworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setCursorPos = new JObject();
                var setCursorPospropCount = 0;
                setCursorPospropCount++;
                setCursorPos["X"] = ExpressionConverter.ConvertO(__workflow_setCursorPosx);
                setCursorPospropCount++;
                setCursorPos["Y"] = ExpressionConverter.ConvertO(__workflow_setCursorPosy);
                setCursorPospropCount++;
                setCursorPos["Workflow"] = ExpressionConverter.ConvertO(__workflow_setCursorPosworkflow);
                if (setCursorPospropCount > 0)
                {
                    callPayload.Body = setCursorPos;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetCursorPosResponse> GetCursorPos(Expression<Func<string>> getCursorPosworkflow)
        {
            var __workflow_getCursorPosworkflow = WorkflowExpression.Compile(getCursorPosworkflow, nameof(getCursorPosworkflow), required: true);
            return new DeferredBodyAction<GetCursorPosResponse>(() =>
            {
                var apiCallPath = "/Environment/GetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getCursorPos = new JObject();
                var getCursorPospropCount = 0;
                getCursorPospropCount++;
                getCursorPos["Workflow"] = ExpressionConverter.ConvertO(__workflow_getCursorPosworkflow);
                if (getCursorPospropCount > 0)
                {
                    callPayload.Body = getCursorPos;
                }

                return new ApiConnectionAction<GetCursorPosResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CalibrateMouseEventResponse> CalibrateMouseEvent(Expression<Func<string>> calibrateMouseEventworkflow, Expression<Func<int>> calibrateMouseEventcalibrationSizeInPixels = null)
        {
            var __workflow_calibrateMouseEventworkflow = WorkflowExpression.Compile(calibrateMouseEventworkflow, nameof(calibrateMouseEventworkflow), required: true);
            var __workflow_calibrateMouseEventcalibrationSizeInPixels = WorkflowExpression.Compile(calibrateMouseEventcalibrationSizeInPixels, nameof(calibrateMouseEventcalibrationSizeInPixels), required: false);
            return new DeferredBodyAction<CalibrateMouseEventResponse>(() =>
            {
                var apiCallPath = "/Environment/CalibrateMouseEvent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var calibrateMouseEvent = new JObject();
                var calibrateMouseEventpropCount = 0;
                if (__workflow_calibrateMouseEventcalibrationSizeInPixels != null)
                {
                    if (__workflow_calibrateMouseEventcalibrationSizeInPixels != null)
                    {
                        calibrateMouseEvent["CalibrationSizeInPixels"] = ExpressionConverter.ConvertO(__workflow_calibrateMouseEventcalibrationSizeInPixels);
                        calibrateMouseEventpropCount++;
                    }

                    calibrateMouseEventpropCount++;
                }
                else
                {
                    calibrateMouseEvent["CalibrationSizeInPixels"] = 200;
                    calibrateMouseEventpropCount++;
                }

                calibrateMouseEventpropCount++;
                calibrateMouseEvent["Workflow"] = ExpressionConverter.ConvertO(__workflow_calibrateMouseEventworkflow);
                if (calibrateMouseEventpropCount > 0)
                {
                    callPayload.Body = calibrateMouseEvent;
                }

                return new ApiConnectionAction<CalibrateMouseEventResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMouseMoveMethodResponse> GetMouseMoveMethod(Expression<Func<string>> getMouseMoveMethodworkflow)
        {
            var __workflow_getMouseMoveMethodworkflow = WorkflowExpression.Compile(getMouseMoveMethodworkflow, nameof(getMouseMoveMethodworkflow), required: true);
            return new DeferredBodyAction<GetMouseMoveMethodResponse>(() =>
            {
                var apiCallPath = "/Environment/GetMouseMoveMethod";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getMouseMoveMethod = new JObject();
                var getMouseMoveMethodpropCount = 0;
                getMouseMoveMethodpropCount++;
                getMouseMoveMethod["Workflow"] = ExpressionConverter.ConvertO(__workflow_getMouseMoveMethodworkflow);
                if (getMouseMoveMethodpropCount > 0)
                {
                    callPayload.Body = getMouseMoveMethod;
                }

                return new ApiConnectionAction<GetMouseMoveMethodResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetMouseMoveMethod(Expression<Func<setMouseMoveMethodmouseMoveMethodInput>> setMouseMoveMethodmouseMoveMethod, Expression<Func<string>> setMouseMoveMethodworkflow)
        {
            var __workflow_setMouseMoveMethodmouseMoveMethod = WorkflowExpression.Compile(setMouseMoveMethodmouseMoveMethod, nameof(setMouseMoveMethodmouseMoveMethod), required: true);
            var __workflow_setMouseMoveMethodworkflow = WorkflowExpression.Compile(setMouseMoveMethodworkflow, nameof(setMouseMoveMethodworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SetMouseMoveMethod";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setMouseMoveMethod = new JObject();
                var setMouseMoveMethodpropCount = 0;
                setMouseMoveMethodpropCount++;
                setMouseMoveMethod["MouseMoveMethod"] = ExpressionConverter.ConvertO(__workflow_setMouseMoveMethodmouseMoveMethod);
                setMouseMoveMethodpropCount++;
                setMouseMoveMethod["Workflow"] = ExpressionConverter.ConvertO(__workflow_setMouseMoveMethodworkflow);
                if (setMouseMoveMethodpropCount > 0)
                {
                    callPayload.Body = setMouseMoveMethod;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WiggleMouse(Expression<Func<string>> wiggleMouseworkflow, Expression<Func<int>> wiggleMousexWiggle = null, Expression<Func<int>> wiggleMouseyWiggle = null, Expression<Func<double>> wiggleMousewiggleDelayInSeconds = null)
        {
            var __workflow_wiggleMouseworkflow = WorkflowExpression.Compile(wiggleMouseworkflow, nameof(wiggleMouseworkflow), required: true);
            var __workflow_wiggleMousexWiggle = WorkflowExpression.Compile(wiggleMousexWiggle, nameof(wiggleMousexWiggle), required: false);
            var __workflow_wiggleMouseyWiggle = WorkflowExpression.Compile(wiggleMouseyWiggle, nameof(wiggleMouseyWiggle), required: false);
            var __workflow_wiggleMousewiggleDelayInSeconds = WorkflowExpression.Compile(wiggleMousewiggleDelayInSeconds, nameof(wiggleMousewiggleDelayInSeconds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/WiggleMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var wiggleMouse = new JObject();
                var wiggleMousepropCount = 0;
                if (__workflow_wiggleMousexWiggle != null)
                {
                    if (__workflow_wiggleMousexWiggle != null)
                    {
                        wiggleMouse["XWiggle"] = ExpressionConverter.ConvertO(__workflow_wiggleMousexWiggle);
                        wiggleMousepropCount++;
                    }

                    wiggleMousepropCount++;
                }
                else
                {
                    wiggleMouse["XWiggle"] = 2;
                    wiggleMousepropCount++;
                }

                if (__workflow_wiggleMouseyWiggle != null)
                {
                    wiggleMouse["YWiggle"] = ExpressionConverter.ConvertO(__workflow_wiggleMouseyWiggle);
                    wiggleMousepropCount++;
                }

                if (__workflow_wiggleMousewiggleDelayInSeconds != null)
                {
                    if (__workflow_wiggleMousewiggleDelayInSeconds != null)
                    {
                        wiggleMouse["WiggleDelayInSeconds"] = ExpressionConverter.ConvertO(__workflow_wiggleMousewiggleDelayInSeconds);
                        wiggleMousepropCount++;
                    }

                    wiggleMousepropCount++;
                }
                else
                {
                    wiggleMouse["WiggleDelayInSeconds"] = 0.1;
                    wiggleMousepropCount++;
                }

                wiggleMousepropCount++;
                wiggleMouse["Workflow"] = ExpressionConverter.ConvertO(__workflow_wiggleMouseworkflow);
                if (wiggleMousepropCount > 0)
                {
                    callPayload.Body = wiggleMouse;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendKeyEvents(Expression<Func<string>> sendKeyEventstext, Expression<Func<string>> sendKeyEventsworkflow, Expression<Func<int>> sendKeyEventsinterval = null, Expression<Func<bool>> sendKeyEventsisPassword = null, Expression<Func<bool>> sendKeyEventsdontInterpretSymbols = null)
        {
            var __workflow_sendKeyEventstext = WorkflowExpression.Compile(sendKeyEventstext, nameof(sendKeyEventstext), required: true);
            var __workflow_sendKeyEventsworkflow = WorkflowExpression.Compile(sendKeyEventsworkflow, nameof(sendKeyEventsworkflow), required: true);
            var __workflow_sendKeyEventsinterval = WorkflowExpression.Compile(sendKeyEventsinterval, nameof(sendKeyEventsinterval), required: false);
            var __workflow_sendKeyEventsisPassword = WorkflowExpression.Compile(sendKeyEventsisPassword, nameof(sendKeyEventsisPassword), required: false);
            var __workflow_sendKeyEventsdontInterpretSymbols = WorkflowExpression.Compile(sendKeyEventsdontInterpretSymbols, nameof(sendKeyEventsdontInterpretSymbols), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SendKeyEvents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendKeyEvents = new JObject();
                var sendKeyEventspropCount = 0;
                sendKeyEventspropCount++;
                sendKeyEvents["Text"] = ExpressionConverter.ConvertO(__workflow_sendKeyEventstext);
                if (__workflow_sendKeyEventsinterval != null)
                {
                    if (__workflow_sendKeyEventsinterval != null)
                    {
                        sendKeyEvents["Interval"] = ExpressionConverter.ConvertO(__workflow_sendKeyEventsinterval);
                        sendKeyEventspropCount++;
                    }

                    sendKeyEventspropCount++;
                }
                else
                {
                    sendKeyEvents["Interval"] = 10;
                    sendKeyEventspropCount++;
                }

                if (__workflow_sendKeyEventsisPassword != null)
                {
                    if (__workflow_sendKeyEventsisPassword != null)
                    {
                        sendKeyEvents["IsPassword"] = ExpressionConverter.ConvertO(__workflow_sendKeyEventsisPassword);
                        sendKeyEventspropCount++;
                    }

                    sendKeyEventspropCount++;
                }
                else
                {
                    sendKeyEvents["IsPassword"] = false;
                    sendKeyEventspropCount++;
                }

                if (__workflow_sendKeyEventsdontInterpretSymbols != null)
                {
                    if (__workflow_sendKeyEventsdontInterpretSymbols != null)
                    {
                        sendKeyEvents["DontInterpretSymbols"] = ExpressionConverter.ConvertO(__workflow_sendKeyEventsdontInterpretSymbols);
                        sendKeyEventspropCount++;
                    }

                    sendKeyEventspropCount++;
                }
                else
                {
                    sendKeyEvents["DontInterpretSymbols"] = false;
                    sendKeyEventspropCount++;
                }

                sendKeyEventspropCount++;
                sendKeyEvents["Workflow"] = ExpressionConverter.ConvertO(__workflow_sendKeyEventsworkflow);
                if (sendKeyEventspropCount > 0)
                {
                    callPayload.Body = sendKeyEvents;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendPasswordKeyEvents(Expression<Func<string>> sendPasswordKeyEventspassword, Expression<Func<string>> sendPasswordKeyEventsworkflow, Expression<Func<int>> sendPasswordKeyEventsinterval = null, Expression<Func<bool>> sendPasswordKeyEventsdontInterpretSymbols = null, Expression<Func<bool>> sendPasswordKeyEventspasswordContainsStoredPassword = null)
        {
            var __workflow_sendPasswordKeyEventspassword = WorkflowExpression.Compile(sendPasswordKeyEventspassword, nameof(sendPasswordKeyEventspassword), required: true);
            var __workflow_sendPasswordKeyEventsworkflow = WorkflowExpression.Compile(sendPasswordKeyEventsworkflow, nameof(sendPasswordKeyEventsworkflow), required: true);
            var __workflow_sendPasswordKeyEventsinterval = WorkflowExpression.Compile(sendPasswordKeyEventsinterval, nameof(sendPasswordKeyEventsinterval), required: false);
            var __workflow_sendPasswordKeyEventsdontInterpretSymbols = WorkflowExpression.Compile(sendPasswordKeyEventsdontInterpretSymbols, nameof(sendPasswordKeyEventsdontInterpretSymbols), required: false);
            var __workflow_sendPasswordKeyEventspasswordContainsStoredPassword = WorkflowExpression.Compile(sendPasswordKeyEventspasswordContainsStoredPassword, nameof(sendPasswordKeyEventspasswordContainsStoredPassword), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SendPasswordKeyEvents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendPasswordKeyEvents = new JObject();
                var sendPasswordKeyEventspropCount = 0;
                sendPasswordKeyEventspropCount++;
                sendPasswordKeyEvents["Password"] = ExpressionConverter.ConvertO(__workflow_sendPasswordKeyEventspassword);
                if (__workflow_sendPasswordKeyEventsinterval != null)
                {
                    if (__workflow_sendPasswordKeyEventsinterval != null)
                    {
                        sendPasswordKeyEvents["Interval"] = ExpressionConverter.ConvertO(__workflow_sendPasswordKeyEventsinterval);
                        sendPasswordKeyEventspropCount++;
                    }

                    sendPasswordKeyEventspropCount++;
                }
                else
                {
                    sendPasswordKeyEvents["Interval"] = 10;
                    sendPasswordKeyEventspropCount++;
                }

                if (__workflow_sendPasswordKeyEventsdontInterpretSymbols != null)
                {
                    if (__workflow_sendPasswordKeyEventsdontInterpretSymbols != null)
                    {
                        sendPasswordKeyEvents["DontInterpretSymbols"] = ExpressionConverter.ConvertO(__workflow_sendPasswordKeyEventsdontInterpretSymbols);
                        sendPasswordKeyEventspropCount++;
                    }

                    sendPasswordKeyEventspropCount++;
                }
                else
                {
                    sendPasswordKeyEvents["DontInterpretSymbols"] = false;
                    sendPasswordKeyEventspropCount++;
                }

                if (__workflow_sendPasswordKeyEventspasswordContainsStoredPassword != null)
                {
                    if (__workflow_sendPasswordKeyEventspasswordContainsStoredPassword != null)
                    {
                        sendPasswordKeyEvents["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_sendPasswordKeyEventspasswordContainsStoredPassword);
                        sendPasswordKeyEventspropCount++;
                    }

                    sendPasswordKeyEventspropCount++;
                }
                else
                {
                    sendPasswordKeyEvents["PasswordContainsStoredPassword"] = false;
                    sendPasswordKeyEventspropCount++;
                }

                sendPasswordKeyEventspropCount++;
                sendPasswordKeyEvents["Workflow"] = ExpressionConverter.ConvertO(__workflow_sendPasswordKeyEventsworkflow);
                if (sendPasswordKeyEventspropCount > 0)
                {
                    callPayload.Body = sendPasswordKeyEvents;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendKeys(Expression<Func<string>> sendKeystext, Expression<Func<string>> sendKeysworkflow, Expression<Func<int>> sendKeysinterval = null, Expression<Func<bool>> sendKeysisPassword = null, Expression<Func<bool>> sendKeysdontInterpretSymbols = null)
        {
            var __workflow_sendKeystext = WorkflowExpression.Compile(sendKeystext, nameof(sendKeystext), required: true);
            var __workflow_sendKeysworkflow = WorkflowExpression.Compile(sendKeysworkflow, nameof(sendKeysworkflow), required: true);
            var __workflow_sendKeysinterval = WorkflowExpression.Compile(sendKeysinterval, nameof(sendKeysinterval), required: false);
            var __workflow_sendKeysisPassword = WorkflowExpression.Compile(sendKeysisPassword, nameof(sendKeysisPassword), required: false);
            var __workflow_sendKeysdontInterpretSymbols = WorkflowExpression.Compile(sendKeysdontInterpretSymbols, nameof(sendKeysdontInterpretSymbols), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SendKeys";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendKeys = new JObject();
                var sendKeyspropCount = 0;
                sendKeyspropCount++;
                sendKeys["Text"] = ExpressionConverter.ConvertO(__workflow_sendKeystext);
                if (__workflow_sendKeysinterval != null)
                {
                    if (__workflow_sendKeysinterval != null)
                    {
                        sendKeys["Interval"] = ExpressionConverter.ConvertO(__workflow_sendKeysinterval);
                        sendKeyspropCount++;
                    }

                    sendKeyspropCount++;
                }
                else
                {
                    sendKeys["Interval"] = 10;
                    sendKeyspropCount++;
                }

                if (__workflow_sendKeysisPassword != null)
                {
                    if (__workflow_sendKeysisPassword != null)
                    {
                        sendKeys["IsPassword"] = ExpressionConverter.ConvertO(__workflow_sendKeysisPassword);
                        sendKeyspropCount++;
                    }

                    sendKeyspropCount++;
                }
                else
                {
                    sendKeys["IsPassword"] = false;
                    sendKeyspropCount++;
                }

                if (__workflow_sendKeysdontInterpretSymbols != null)
                {
                    if (__workflow_sendKeysdontInterpretSymbols != null)
                    {
                        sendKeys["DontInterpretSymbols"] = ExpressionConverter.ConvertO(__workflow_sendKeysdontInterpretSymbols);
                        sendKeyspropCount++;
                    }

                    sendKeyspropCount++;
                }
                else
                {
                    sendKeys["DontInterpretSymbols"] = false;
                    sendKeyspropCount++;
                }

                sendKeyspropCount++;
                sendKeys["Workflow"] = ExpressionConverter.ConvertO(__workflow_sendKeysworkflow);
                if (sendKeyspropCount > 0)
                {
                    callPayload.Body = sendKeys;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendPasswordKeys(Expression<Func<string>> sendPasswordKeyspassword, Expression<Func<string>> sendPasswordKeysworkflow, Expression<Func<int>> sendPasswordKeysinterval = null, Expression<Func<bool>> sendPasswordKeysdontInterpretSymbols = null, Expression<Func<bool>> sendPasswordKeyspasswordContainsStoredPassword = null)
        {
            var __workflow_sendPasswordKeyspassword = WorkflowExpression.Compile(sendPasswordKeyspassword, nameof(sendPasswordKeyspassword), required: true);
            var __workflow_sendPasswordKeysworkflow = WorkflowExpression.Compile(sendPasswordKeysworkflow, nameof(sendPasswordKeysworkflow), required: true);
            var __workflow_sendPasswordKeysinterval = WorkflowExpression.Compile(sendPasswordKeysinterval, nameof(sendPasswordKeysinterval), required: false);
            var __workflow_sendPasswordKeysdontInterpretSymbols = WorkflowExpression.Compile(sendPasswordKeysdontInterpretSymbols, nameof(sendPasswordKeysdontInterpretSymbols), required: false);
            var __workflow_sendPasswordKeyspasswordContainsStoredPassword = WorkflowExpression.Compile(sendPasswordKeyspasswordContainsStoredPassword, nameof(sendPasswordKeyspasswordContainsStoredPassword), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SendPasswordKeys";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendPasswordKeys = new JObject();
                var sendPasswordKeyspropCount = 0;
                sendPasswordKeyspropCount++;
                sendPasswordKeys["Password"] = ExpressionConverter.ConvertO(__workflow_sendPasswordKeyspassword);
                if (__workflow_sendPasswordKeysinterval != null)
                {
                    if (__workflow_sendPasswordKeysinterval != null)
                    {
                        sendPasswordKeys["Interval"] = ExpressionConverter.ConvertO(__workflow_sendPasswordKeysinterval);
                        sendPasswordKeyspropCount++;
                    }

                    sendPasswordKeyspropCount++;
                }
                else
                {
                    sendPasswordKeys["Interval"] = 10;
                    sendPasswordKeyspropCount++;
                }

                if (__workflow_sendPasswordKeysdontInterpretSymbols != null)
                {
                    if (__workflow_sendPasswordKeysdontInterpretSymbols != null)
                    {
                        sendPasswordKeys["DontInterpretSymbols"] = ExpressionConverter.ConvertO(__workflow_sendPasswordKeysdontInterpretSymbols);
                        sendPasswordKeyspropCount++;
                    }

                    sendPasswordKeyspropCount++;
                }
                else
                {
                    sendPasswordKeys["DontInterpretSymbols"] = false;
                    sendPasswordKeyspropCount++;
                }

                if (__workflow_sendPasswordKeyspasswordContainsStoredPassword != null)
                {
                    if (__workflow_sendPasswordKeyspasswordContainsStoredPassword != null)
                    {
                        sendPasswordKeys["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_sendPasswordKeyspasswordContainsStoredPassword);
                        sendPasswordKeyspropCount++;
                    }

                    sendPasswordKeyspropCount++;
                }
                else
                {
                    sendPasswordKeys["PasswordContainsStoredPassword"] = false;
                    sendPasswordKeyspropCount++;
                }

                sendPasswordKeyspropCount++;
                sendPasswordKeys["Workflow"] = ExpressionConverter.ConvertO(__workflow_sendPasswordKeysworkflow);
                if (sendPasswordKeyspropCount > 0)
                {
                    callPayload.Body = sendPasswordKeys;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ClearClipboard(Expression<Func<string>> clearClipboardworkflow)
        {
            var __workflow_clearClipboardworkflow = WorkflowExpression.Compile(clearClipboardworkflow, nameof(clearClipboardworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/ClearClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var clearClipboard = new JObject();
                var clearClipboardpropCount = 0;
                clearClipboardpropCount++;
                clearClipboard["Workflow"] = ExpressionConverter.ConvertO(__workflow_clearClipboardworkflow);
                if (clearClipboardpropCount > 0)
                {
                    callPayload.Body = clearClipboard;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetClipboardData(Expression<Func<string>> setClipboardDataworkflow, Expression<Func<string>> setClipboardDatanewClipboardData = null)
        {
            var __workflow_setClipboardDataworkflow = WorkflowExpression.Compile(setClipboardDataworkflow, nameof(setClipboardDataworkflow), required: true);
            var __workflow_setClipboardDatanewClipboardData = WorkflowExpression.Compile(setClipboardDatanewClipboardData, nameof(setClipboardDatanewClipboardData), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SetClipboardData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setClipboardData = new JObject();
                var setClipboardDatapropCount = 0;
                if (__workflow_setClipboardDatanewClipboardData != null)
                {
                    setClipboardData["NewClipboardData"] = ExpressionConverter.ConvertO(__workflow_setClipboardDatanewClipboardData);
                    setClipboardDatapropCount++;
                }

                setClipboardDatapropCount++;
                setClipboardData["Workflow"] = ExpressionConverter.ConvertO(__workflow_setClipboardDataworkflow);
                if (setClipboardDatapropCount > 0)
                {
                    callPayload.Body = setClipboardData;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetClipboardDataResponse> GetClipboardData(Expression<Func<string>> getClipboardDataworkflow)
        {
            var __workflow_getClipboardDataworkflow = WorkflowExpression.Compile(getClipboardDataworkflow, nameof(getClipboardDataworkflow), required: true);
            return new DeferredBodyAction<GetClipboardDataResponse>(() =>
            {
                var apiCallPath = "/Environment/GetClipboardData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getClipboardData = new JObject();
                var getClipboardDatapropCount = 0;
                getClipboardDatapropCount++;
                getClipboardData["Workflow"] = ExpressionConverter.ConvertO(__workflow_getClipboardDataworkflow);
                if (getClipboardDatapropCount > 0)
                {
                    callPayload.Body = getClipboardData;
                }

                return new ApiConnectionAction<GetClipboardDataResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TakeScreenshotResponse> TakeScreenshot(Expression<Func<string>> takeScreenshotworkflow, Expression<Func<bool>> takeScreenshotfullscreen = null, Expression<Func<int>> takeScreenshotleftXPixels = null, Expression<Func<int>> takeScreenshottopYPixels = null, Expression<Func<int>> takeScreenshotwidthPixels = null, Expression<Func<int>> takeScreenshotheightPixels = null, Expression<Func<takeScreenshotimageFormatInput>> takeScreenshotimageFormat = null, Expression<Func<bool>> takeScreenshotuseDisplayDevice = null, Expression<Func<bool>> takeScreenshotraiseExceptionOnError = null, Expression<Func<bool>> takeScreenshothideAgent = null, Expression<Func<bool>> takeScreenshotusePhysicalCoordinates = null, Expression<Func<int>> takeScreenshotdisplayDeviceId = null)
        {
            var __workflow_takeScreenshotworkflow = WorkflowExpression.Compile(takeScreenshotworkflow, nameof(takeScreenshotworkflow), required: true);
            var __workflow_takeScreenshotfullscreen = WorkflowExpression.Compile(takeScreenshotfullscreen, nameof(takeScreenshotfullscreen), required: false);
            var __workflow_takeScreenshotleftXPixels = WorkflowExpression.Compile(takeScreenshotleftXPixels, nameof(takeScreenshotleftXPixels), required: false);
            var __workflow_takeScreenshottopYPixels = WorkflowExpression.Compile(takeScreenshottopYPixels, nameof(takeScreenshottopYPixels), required: false);
            var __workflow_takeScreenshotwidthPixels = WorkflowExpression.Compile(takeScreenshotwidthPixels, nameof(takeScreenshotwidthPixels), required: false);
            var __workflow_takeScreenshotheightPixels = WorkflowExpression.Compile(takeScreenshotheightPixels, nameof(takeScreenshotheightPixels), required: false);
            var __workflow_takeScreenshotimageFormat = WorkflowExpression.Compile(takeScreenshotimageFormat, nameof(takeScreenshotimageFormat), required: false);
            var __workflow_takeScreenshotuseDisplayDevice = WorkflowExpression.Compile(takeScreenshotuseDisplayDevice, nameof(takeScreenshotuseDisplayDevice), required: false);
            var __workflow_takeScreenshotraiseExceptionOnError = WorkflowExpression.Compile(takeScreenshotraiseExceptionOnError, nameof(takeScreenshotraiseExceptionOnError), required: false);
            var __workflow_takeScreenshothideAgent = WorkflowExpression.Compile(takeScreenshothideAgent, nameof(takeScreenshothideAgent), required: false);
            var __workflow_takeScreenshotusePhysicalCoordinates = WorkflowExpression.Compile(takeScreenshotusePhysicalCoordinates, nameof(takeScreenshotusePhysicalCoordinates), required: false);
            var __workflow_takeScreenshotdisplayDeviceId = WorkflowExpression.Compile(takeScreenshotdisplayDeviceId, nameof(takeScreenshotdisplayDeviceId), required: false);
            return new DeferredBodyAction<TakeScreenshotResponse>(() =>
            {
                var apiCallPath = "/Environment/TakeScreenshot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var takeScreenshot = new JObject();
                var takeScreenshotpropCount = 0;
                if (__workflow_takeScreenshotfullscreen != null)
                {
                    if (__workflow_takeScreenshotfullscreen != null)
                    {
                        takeScreenshot["Fullscreen"] = ExpressionConverter.ConvertO(__workflow_takeScreenshotfullscreen);
                        takeScreenshotpropCount++;
                    }

                    takeScreenshotpropCount++;
                }
                else
                {
                    takeScreenshot["Fullscreen"] = true;
                    takeScreenshotpropCount++;
                }

                if (__workflow_takeScreenshotleftXPixels != null)
                {
                    takeScreenshot["LeftXPixels"] = ExpressionConverter.ConvertO(__workflow_takeScreenshotleftXPixels);
                    takeScreenshotpropCount++;
                }

                if (__workflow_takeScreenshottopYPixels != null)
                {
                    takeScreenshot["TopYPixels"] = ExpressionConverter.ConvertO(__workflow_takeScreenshottopYPixels);
                    takeScreenshotpropCount++;
                }

                if (__workflow_takeScreenshotwidthPixels != null)
                {
                    takeScreenshot["WidthPixels"] = ExpressionConverter.ConvertO(__workflow_takeScreenshotwidthPixels);
                    takeScreenshotpropCount++;
                }

                if (__workflow_takeScreenshotheightPixels != null)
                {
                    takeScreenshot["HeightPixels"] = ExpressionConverter.ConvertO(__workflow_takeScreenshotheightPixels);
                    takeScreenshotpropCount++;
                }

                if (__workflow_takeScreenshotimageFormat != null)
                {
                    takeScreenshot["ImageFormat"] = ExpressionConverter.ConvertO(__workflow_takeScreenshotimageFormat);
                    takeScreenshotpropCount++;
                }

                if (__workflow_takeScreenshotuseDisplayDevice != null)
                {
                    if (__workflow_takeScreenshotuseDisplayDevice != null)
                    {
                        takeScreenshot["UseDisplayDevice"] = ExpressionConverter.ConvertO(__workflow_takeScreenshotuseDisplayDevice);
                        takeScreenshotpropCount++;
                    }

                    takeScreenshotpropCount++;
                }
                else
                {
                    takeScreenshot["UseDisplayDevice"] = false;
                    takeScreenshotpropCount++;
                }

                if (__workflow_takeScreenshotraiseExceptionOnError != null)
                {
                    if (__workflow_takeScreenshotraiseExceptionOnError != null)
                    {
                        takeScreenshot["RaiseExceptionOnError"] = ExpressionConverter.ConvertO(__workflow_takeScreenshotraiseExceptionOnError);
                        takeScreenshotpropCount++;
                    }

                    takeScreenshotpropCount++;
                }
                else
                {
                    takeScreenshot["RaiseExceptionOnError"] = true;
                    takeScreenshotpropCount++;
                }

                if (__workflow_takeScreenshothideAgent != null)
                {
                    if (__workflow_takeScreenshothideAgent != null)
                    {
                        takeScreenshot["HideAgent"] = ExpressionConverter.ConvertO(__workflow_takeScreenshothideAgent);
                        takeScreenshotpropCount++;
                    }

                    takeScreenshotpropCount++;
                }
                else
                {
                    takeScreenshot["HideAgent"] = false;
                    takeScreenshotpropCount++;
                }

                if (__workflow_takeScreenshotusePhysicalCoordinates != null)
                {
                    if (__workflow_takeScreenshotusePhysicalCoordinates != null)
                    {
                        takeScreenshot["UsePhysicalCoordinates"] = ExpressionConverter.ConvertO(__workflow_takeScreenshotusePhysicalCoordinates);
                        takeScreenshotpropCount++;
                    }

                    takeScreenshotpropCount++;
                }
                else
                {
                    takeScreenshot["UsePhysicalCoordinates"] = false;
                    takeScreenshotpropCount++;
                }

                if (__workflow_takeScreenshotdisplayDeviceId != null)
                {
                    takeScreenshot["DisplayDeviceId"] = ExpressionConverter.ConvertO(__workflow_takeScreenshotdisplayDeviceId);
                    takeScreenshotpropCount++;
                }

                takeScreenshotpropCount++;
                takeScreenshot["Workflow"] = ExpressionConverter.ConvertO(__workflow_takeScreenshotworkflow);
                if (takeScreenshotpropCount > 0)
                {
                    callPayload.Body = takeScreenshot;
                }

                return new ApiConnectionAction<TakeScreenshotResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetEnvironmentInfoResponse> GetEnvironmentInfo(Expression<Func<string>> getEnvironmentInfoworkflow)
        {
            var __workflow_getEnvironmentInfoworkflow = WorkflowExpression.Compile(getEnvironmentInfoworkflow, nameof(getEnvironmentInfoworkflow), required: true);
            return new DeferredBodyAction<GetEnvironmentInfoResponse>(() =>
            {
                var apiCallPath = "/Environment/GetEnvironmentInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getEnvironmentInfo = new JObject();
                var getEnvironmentInfopropCount = 0;
                getEnvironmentInfopropCount++;
                getEnvironmentInfo["Workflow"] = ExpressionConverter.ConvertO(__workflow_getEnvironmentInfoworkflow);
                if (getEnvironmentInfopropCount > 0)
                {
                    callPayload.Body = getEnvironmentInfo;
                }

                return new ApiConnectionAction<GetEnvironmentInfoResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsScreenReaderEnabledResponse> IsScreenReaderEnabled(Expression<Func<string>> isScreenReaderEnabledworkflow)
        {
            var __workflow_isScreenReaderEnabledworkflow = WorkflowExpression.Compile(isScreenReaderEnabledworkflow, nameof(isScreenReaderEnabledworkflow), required: true);
            return new DeferredBodyAction<IsScreenReaderEnabledResponse>(() =>
            {
                var apiCallPath = "/Environment/IsScreenReaderEnabled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isScreenReaderEnabled = new JObject();
                var isScreenReaderEnabledpropCount = 0;
                isScreenReaderEnabledpropCount++;
                isScreenReaderEnabled["Workflow"] = ExpressionConverter.ConvertO(__workflow_isScreenReaderEnabledworkflow);
                if (isScreenReaderEnabledpropCount > 0)
                {
                    callPayload.Body = isScreenReaderEnabled;
                }

                return new ApiConnectionAction<IsScreenReaderEnabledResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetScreenReader(Expression<Func<string>> setScreenReaderworkflow, Expression<Func<bool>> setScreenReaderenableScreenReader = null)
        {
            var __workflow_setScreenReaderworkflow = WorkflowExpression.Compile(setScreenReaderworkflow, nameof(setScreenReaderworkflow), required: true);
            var __workflow_setScreenReaderenableScreenReader = WorkflowExpression.Compile(setScreenReaderenableScreenReader, nameof(setScreenReaderenableScreenReader), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SetScreenReader";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setScreenReader = new JObject();
                var setScreenReaderpropCount = 0;
                if (__workflow_setScreenReaderenableScreenReader != null)
                {
                    if (__workflow_setScreenReaderenableScreenReader != null)
                    {
                        setScreenReader["EnableScreenReader"] = ExpressionConverter.ConvertO(__workflow_setScreenReaderenableScreenReader);
                        setScreenReaderpropCount++;
                    }

                    setScreenReaderpropCount++;
                }
                else
                {
                    setScreenReader["EnableScreenReader"] = true;
                    setScreenReaderpropCount++;
                }

                setScreenReaderpropCount++;
                setScreenReader["Workflow"] = ExpressionConverter.ConvertO(__workflow_setScreenReaderworkflow);
                if (setScreenReaderpropCount > 0)
                {
                    callPayload.Body = setScreenReader;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetParentProcessIdResponse> GetParentProcessId(Expression<Func<int>> getParentProcessIdprocessId, Expression<Func<string>> getParentProcessIdworkflow)
        {
            var __workflow_getParentProcessIdprocessId = WorkflowExpression.Compile(getParentProcessIdprocessId, nameof(getParentProcessIdprocessId), required: true);
            var __workflow_getParentProcessIdworkflow = WorkflowExpression.Compile(getParentProcessIdworkflow, nameof(getParentProcessIdworkflow), required: true);
            return new DeferredBodyAction<GetParentProcessIdResponse>(() =>
            {
                var apiCallPath = "/Environment/GetParentProcessId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getParentProcessId = new JObject();
                var getParentProcessIdpropCount = 0;
                getParentProcessIdpropCount++;
                getParentProcessId["ProcessId"] = ExpressionConverter.ConvertO(__workflow_getParentProcessIdprocessId);
                getParentProcessIdpropCount++;
                getParentProcessId["Workflow"] = ExpressionConverter.ConvertO(__workflow_getParentProcessIdworkflow);
                if (getParentProcessIdpropCount > 0)
                {
                    callPayload.Body = getParentProcessId;
                }

                return new ApiConnectionAction<GetParentProcessIdResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessIdCommandLineResponse> GetProcessIdCommandLine(Expression<Func<int>> getProcessIdCommandLineprocessId, Expression<Func<string>> getProcessIdCommandLineworkflow)
        {
            var __workflow_getProcessIdCommandLineprocessId = WorkflowExpression.Compile(getProcessIdCommandLineprocessId, nameof(getProcessIdCommandLineprocessId), required: true);
            var __workflow_getProcessIdCommandLineworkflow = WorkflowExpression.Compile(getProcessIdCommandLineworkflow, nameof(getProcessIdCommandLineworkflow), required: true);
            return new DeferredBodyAction<GetProcessIdCommandLineResponse>(() =>
            {
                var apiCallPath = "/Environment/GetProcessIdCommandLine";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getProcessIdCommandLine = new JObject();
                var getProcessIdCommandLinepropCount = 0;
                getProcessIdCommandLinepropCount++;
                getProcessIdCommandLine["ProcessId"] = ExpressionConverter.ConvertO(__workflow_getProcessIdCommandLineprocessId);
                getProcessIdCommandLinepropCount++;
                getProcessIdCommandLine["Workflow"] = ExpressionConverter.ConvertO(__workflow_getProcessIdCommandLineworkflow);
                if (getProcessIdCommandLinepropCount > 0)
                {
                    callPayload.Body = getProcessIdCommandLine;
                }

                return new ApiConnectionAction<GetProcessIdCommandLineResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLastInputInfoResponse> GetLastInputInfo(Expression<Func<string>> getLastInputInfoworkflow)
        {
            var __workflow_getLastInputInfoworkflow = WorkflowExpression.Compile(getLastInputInfoworkflow, nameof(getLastInputInfoworkflow), required: true);
            return new DeferredBodyAction<GetLastInputInfoResponse>(() =>
            {
                var apiCallPath = "/Environment/GetLastInputInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getLastInputInfo = new JObject();
                var getLastInputInfopropCount = 0;
                getLastInputInfopropCount++;
                getLastInputInfo["Workflow"] = ExpressionConverter.ConvertO(__workflow_getLastInputInfoworkflow);
                if (getLastInputInfopropCount > 0)
                {
                    callPayload.Body = getLastInputInfo;
                }

                return new ApiConnectionAction<GetLastInputInfoResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KeepSessionAliveResponse> KeepSessionAlive(Expression<Func<string>> keepSessionAliveworkflow, Expression<Func<int>> keepSessionAlivexWiggle = null, Expression<Func<int>> keepSessionAliveyWiggle = null, Expression<Func<double>> keepSessionAlivewiggleDelayInSeconds = null, Expression<Func<int>> keepSessionAliveidleThresholdInSeconds = null, Expression<Func<int>> keepSessionAliveidleCheckPeriodInSeconds = null, Expression<Func<int>> keepSessionAlivetotalKeepaliveRuntimeInSeconds = null)
        {
            var __workflow_keepSessionAliveworkflow = WorkflowExpression.Compile(keepSessionAliveworkflow, nameof(keepSessionAliveworkflow), required: true);
            var __workflow_keepSessionAlivexWiggle = WorkflowExpression.Compile(keepSessionAlivexWiggle, nameof(keepSessionAlivexWiggle), required: false);
            var __workflow_keepSessionAliveyWiggle = WorkflowExpression.Compile(keepSessionAliveyWiggle, nameof(keepSessionAliveyWiggle), required: false);
            var __workflow_keepSessionAlivewiggleDelayInSeconds = WorkflowExpression.Compile(keepSessionAlivewiggleDelayInSeconds, nameof(keepSessionAlivewiggleDelayInSeconds), required: false);
            var __workflow_keepSessionAliveidleThresholdInSeconds = WorkflowExpression.Compile(keepSessionAliveidleThresholdInSeconds, nameof(keepSessionAliveidleThresholdInSeconds), required: false);
            var __workflow_keepSessionAliveidleCheckPeriodInSeconds = WorkflowExpression.Compile(keepSessionAliveidleCheckPeriodInSeconds, nameof(keepSessionAliveidleCheckPeriodInSeconds), required: false);
            var __workflow_keepSessionAlivetotalKeepaliveRuntimeInSeconds = WorkflowExpression.Compile(keepSessionAlivetotalKeepaliveRuntimeInSeconds, nameof(keepSessionAlivetotalKeepaliveRuntimeInSeconds), required: false);
            return new DeferredBodyAction<KeepSessionAliveResponse>(() =>
            {
                var apiCallPath = "/Environment/KeepSessionAlive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var keepSessionAlive = new JObject();
                var keepSessionAlivepropCount = 0;
                if (__workflow_keepSessionAlivexWiggle != null)
                {
                    if (__workflow_keepSessionAlivexWiggle != null)
                    {
                        keepSessionAlive["XWiggle"] = ExpressionConverter.ConvertO(__workflow_keepSessionAlivexWiggle);
                        keepSessionAlivepropCount++;
                    }

                    keepSessionAlivepropCount++;
                }
                else
                {
                    keepSessionAlive["XWiggle"] = 2;
                    keepSessionAlivepropCount++;
                }

                if (__workflow_keepSessionAliveyWiggle != null)
                {
                    keepSessionAlive["YWiggle"] = ExpressionConverter.ConvertO(__workflow_keepSessionAliveyWiggle);
                    keepSessionAlivepropCount++;
                }

                if (__workflow_keepSessionAlivewiggleDelayInSeconds != null)
                {
                    if (__workflow_keepSessionAlivewiggleDelayInSeconds != null)
                    {
                        keepSessionAlive["WiggleDelayInSeconds"] = ExpressionConverter.ConvertO(__workflow_keepSessionAlivewiggleDelayInSeconds);
                        keepSessionAlivepropCount++;
                    }

                    keepSessionAlivepropCount++;
                }
                else
                {
                    keepSessionAlive["WiggleDelayInSeconds"] = 0.1;
                    keepSessionAlivepropCount++;
                }

                if (__workflow_keepSessionAliveidleThresholdInSeconds != null)
                {
                    if (__workflow_keepSessionAliveidleThresholdInSeconds != null)
                    {
                        keepSessionAlive["IdleThresholdInSeconds"] = ExpressionConverter.ConvertO(__workflow_keepSessionAliveidleThresholdInSeconds);
                        keepSessionAlivepropCount++;
                    }

                    keepSessionAlivepropCount++;
                }
                else
                {
                    keepSessionAlive["IdleThresholdInSeconds"] = 120;
                    keepSessionAlivepropCount++;
                }

                if (__workflow_keepSessionAliveidleCheckPeriodInSeconds != null)
                {
                    if (__workflow_keepSessionAliveidleCheckPeriodInSeconds != null)
                    {
                        keepSessionAlive["IdleCheckPeriodInSeconds"] = ExpressionConverter.ConvertO(__workflow_keepSessionAliveidleCheckPeriodInSeconds);
                        keepSessionAlivepropCount++;
                    }

                    keepSessionAlivepropCount++;
                }
                else
                {
                    keepSessionAlive["IdleCheckPeriodInSeconds"] = 30;
                    keepSessionAlivepropCount++;
                }

                if (__workflow_keepSessionAlivetotalKeepaliveRuntimeInSeconds != null)
                {
                    if (__workflow_keepSessionAlivetotalKeepaliveRuntimeInSeconds != null)
                    {
                        keepSessionAlive["TotalKeepaliveRuntimeInSeconds"] = ExpressionConverter.ConvertO(__workflow_keepSessionAlivetotalKeepaliveRuntimeInSeconds);
                        keepSessionAlivepropCount++;
                    }

                    keepSessionAlivepropCount++;
                }
                else
                {
                    keepSessionAlive["TotalKeepaliveRuntimeInSeconds"] = -1;
                    keepSessionAlivepropCount++;
                }

                keepSessionAlivepropCount++;
                keepSessionAlive["Workflow"] = ExpressionConverter.ConvertO(__workflow_keepSessionAliveworkflow);
                if (keepSessionAlivepropCount > 0)
                {
                    callPayload.Body = keepSessionAlive;
                }

                return new ApiConnectionAction<KeepSessionAliveResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<StopKeepSessionAliveResponse> StopKeepSessionAlive(Expression<Func<string>> stopKeepSessionAliveworkflow)
        {
            var __workflow_stopKeepSessionAliveworkflow = WorkflowExpression.Compile(stopKeepSessionAliveworkflow, nameof(stopKeepSessionAliveworkflow), required: true);
            return new DeferredBodyAction<StopKeepSessionAliveResponse>(() =>
            {
                var apiCallPath = "/Environment/StopKeepSessionAlive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var stopKeepSessionAlive = new JObject();
                var stopKeepSessionAlivepropCount = 0;
                stopKeepSessionAlivepropCount++;
                stopKeepSessionAlive["Workflow"] = ExpressionConverter.ConvertO(__workflow_stopKeepSessionAliveworkflow);
                if (stopKeepSessionAlivepropCount > 0)
                {
                    callPayload.Body = stopKeepSessionAlive;
                }

                return new ApiConnectionAction<StopKeepSessionAliveResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CopyFileToClipboardResponse> CopyFileToClipboard(Expression<Func<string>> copyFileToClipboardfilepath, Expression<Func<string>> copyFileToClipboardworkflow, Expression<Func<bool>> copyFileToClipboardcut = null)
        {
            var __workflow_copyFileToClipboardfilepath = WorkflowExpression.Compile(copyFileToClipboardfilepath, nameof(copyFileToClipboardfilepath), required: true);
            var __workflow_copyFileToClipboardworkflow = WorkflowExpression.Compile(copyFileToClipboardworkflow, nameof(copyFileToClipboardworkflow), required: true);
            var __workflow_copyFileToClipboardcut = WorkflowExpression.Compile(copyFileToClipboardcut, nameof(copyFileToClipboardcut), required: false);
            return new DeferredBodyAction<CopyFileToClipboardResponse>(() =>
            {
                var apiCallPath = "/Environment/CopyFileToClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var copyFileToClipboard = new JObject();
                var copyFileToClipboardpropCount = 0;
                copyFileToClipboardpropCount++;
                copyFileToClipboard["Filepath"] = ExpressionConverter.ConvertO(__workflow_copyFileToClipboardfilepath);
                if (__workflow_copyFileToClipboardcut != null)
                {
                    if (__workflow_copyFileToClipboardcut != null)
                    {
                        copyFileToClipboard["Cut"] = ExpressionConverter.ConvertO(__workflow_copyFileToClipboardcut);
                        copyFileToClipboardpropCount++;
                    }

                    copyFileToClipboardpropCount++;
                }
                else
                {
                    copyFileToClipboard["Cut"] = false;
                    copyFileToClipboardpropCount++;
                }

                copyFileToClipboardpropCount++;
                copyFileToClipboard["Workflow"] = ExpressionConverter.ConvertO(__workflow_copyFileToClipboardworkflow);
                if (copyFileToClipboardpropCount > 0)
                {
                    callPayload.Body = copyFileToClipboard;
                }

                return new ApiConnectionAction<CopyFileToClipboardResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteSessionInfoResponse> GetRemoteSessionInfo(Expression<Func<string>> getRemoteSessionInfoworkflow)
        {
            var __workflow_getRemoteSessionInfoworkflow = WorkflowExpression.Compile(getRemoteSessionInfoworkflow, nameof(getRemoteSessionInfoworkflow), required: true);
            return new DeferredBodyAction<GetRemoteSessionInfoResponse>(() =>
            {
                var apiCallPath = "/Environment/GetRemoteSessionInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRemoteSessionInfo = new JObject();
                var getRemoteSessionInfopropCount = 0;
                getRemoteSessionInfopropCount++;
                getRemoteSessionInfo["Workflow"] = ExpressionConverter.ConvertO(__workflow_getRemoteSessionInfoworkflow);
                if (getRemoteSessionInfopropCount > 0)
                {
                    callPayload.Body = getRemoteSessionInfo;
                }

                return new ApiConnectionAction<GetRemoteSessionInfoResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GeneratePasswordResponse> GeneratePassword(Expression<Func<string>> generatePasswordpasswordFormat, Expression<Func<string>> generatePasswordworkflow, Expression<Func<int>> generatePasswordminimumLength = null, Expression<Func<bool>> generatePasswordreturnAsPlainText = null, Expression<Func<string>> generatePasswordstorePasswordAsIdentifier = null, Expression<Func<string>> generatePasswordsupportedSymbols = null, Expression<Func<bool>> generatePasswordattemptUniquePasswords = null, Expression<Func<generatePasswordgenerateAtInput>> generatePasswordgenerateAt = null, Expression<Func<int>> generatePasswordminimumLowercase = null, Expression<Func<int>> generatePasswordminimumUppercase = null, Expression<Func<int>> generatePasswordminimumNumbers = null, Expression<Func<int>> generatePasswordminimumSymbols = null)
        {
            var __workflow_generatePasswordpasswordFormat = WorkflowExpression.Compile(generatePasswordpasswordFormat, nameof(generatePasswordpasswordFormat), required: true);
            var __workflow_generatePasswordworkflow = WorkflowExpression.Compile(generatePasswordworkflow, nameof(generatePasswordworkflow), required: true);
            var __workflow_generatePasswordminimumLength = WorkflowExpression.Compile(generatePasswordminimumLength, nameof(generatePasswordminimumLength), required: false);
            var __workflow_generatePasswordreturnAsPlainText = WorkflowExpression.Compile(generatePasswordreturnAsPlainText, nameof(generatePasswordreturnAsPlainText), required: false);
            var __workflow_generatePasswordstorePasswordAsIdentifier = WorkflowExpression.Compile(generatePasswordstorePasswordAsIdentifier, nameof(generatePasswordstorePasswordAsIdentifier), required: false);
            var __workflow_generatePasswordsupportedSymbols = WorkflowExpression.Compile(generatePasswordsupportedSymbols, nameof(generatePasswordsupportedSymbols), required: false);
            var __workflow_generatePasswordattemptUniquePasswords = WorkflowExpression.Compile(generatePasswordattemptUniquePasswords, nameof(generatePasswordattemptUniquePasswords), required: false);
            var __workflow_generatePasswordgenerateAt = WorkflowExpression.Compile(generatePasswordgenerateAt, nameof(generatePasswordgenerateAt), required: false);
            var __workflow_generatePasswordminimumLowercase = WorkflowExpression.Compile(generatePasswordminimumLowercase, nameof(generatePasswordminimumLowercase), required: false);
            var __workflow_generatePasswordminimumUppercase = WorkflowExpression.Compile(generatePasswordminimumUppercase, nameof(generatePasswordminimumUppercase), required: false);
            var __workflow_generatePasswordminimumNumbers = WorkflowExpression.Compile(generatePasswordminimumNumbers, nameof(generatePasswordminimumNumbers), required: false);
            var __workflow_generatePasswordminimumSymbols = WorkflowExpression.Compile(generatePasswordminimumSymbols, nameof(generatePasswordminimumSymbols), required: false);
            return new DeferredBodyAction<GeneratePasswordResponse>(() =>
            {
                var apiCallPath = "/Environment/GeneratePassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var generatePassword = new JObject();
                var generatePasswordpropCount = 0;
                generatePasswordpropCount++;
                generatePassword["PasswordFormat"] = ExpressionConverter.ConvertO(__workflow_generatePasswordpasswordFormat);
                if (__workflow_generatePasswordminimumLength != null)
                {
                    generatePassword["MinimumLength"] = ExpressionConverter.ConvertO(__workflow_generatePasswordminimumLength);
                    generatePasswordpropCount++;
                }

                if (__workflow_generatePasswordreturnAsPlainText != null)
                {
                    if (__workflow_generatePasswordreturnAsPlainText != null)
                    {
                        generatePassword["ReturnAsPlainText"] = ExpressionConverter.ConvertO(__workflow_generatePasswordreturnAsPlainText);
                        generatePasswordpropCount++;
                    }

                    generatePasswordpropCount++;
                }
                else
                {
                    generatePassword["ReturnAsPlainText"] = false;
                    generatePasswordpropCount++;
                }

                if (__workflow_generatePasswordstorePasswordAsIdentifier != null)
                {
                    generatePassword["StorePasswordAsIdentifier"] = ExpressionConverter.ConvertO(__workflow_generatePasswordstorePasswordAsIdentifier);
                    generatePasswordpropCount++;
                }

                if (__workflow_generatePasswordsupportedSymbols != null)
                {
                    generatePassword["SupportedSymbols"] = ExpressionConverter.ConvertO(__workflow_generatePasswordsupportedSymbols);
                    generatePasswordpropCount++;
                }

                if (__workflow_generatePasswordattemptUniquePasswords != null)
                {
                    if (__workflow_generatePasswordattemptUniquePasswords != null)
                    {
                        generatePassword["AttemptUniquePasswords"] = ExpressionConverter.ConvertO(__workflow_generatePasswordattemptUniquePasswords);
                        generatePasswordpropCount++;
                    }

                    generatePasswordpropCount++;
                }
                else
                {
                    generatePassword["AttemptUniquePasswords"] = true;
                    generatePasswordpropCount++;
                }

                if (__workflow_generatePasswordgenerateAt != null)
                {
                    if (__workflow_generatePasswordgenerateAt != null)
                    {
                        generatePassword["GenerateAt"] = ExpressionConverter.ConvertO(__workflow_generatePasswordgenerateAt);
                        generatePasswordpropCount++;
                    }

                    generatePasswordpropCount++;
                }
                else
                {
                    generatePassword["GenerateAt"] = "Agent";
                    generatePasswordpropCount++;
                }

                if (__workflow_generatePasswordminimumLowercase != null)
                {
                    if (__workflow_generatePasswordminimumLowercase != null)
                    {
                        generatePassword["MinimumLowercase"] = ExpressionConverter.ConvertO(__workflow_generatePasswordminimumLowercase);
                        generatePasswordpropCount++;
                    }

                    generatePasswordpropCount++;
                }
                else
                {
                    generatePassword["MinimumLowercase"] = 0;
                    generatePasswordpropCount++;
                }

                if (__workflow_generatePasswordminimumUppercase != null)
                {
                    if (__workflow_generatePasswordminimumUppercase != null)
                    {
                        generatePassword["MinimumUppercase"] = ExpressionConverter.ConvertO(__workflow_generatePasswordminimumUppercase);
                        generatePasswordpropCount++;
                    }

                    generatePasswordpropCount++;
                }
                else
                {
                    generatePassword["MinimumUppercase"] = 0;
                    generatePasswordpropCount++;
                }

                if (__workflow_generatePasswordminimumNumbers != null)
                {
                    if (__workflow_generatePasswordminimumNumbers != null)
                    {
                        generatePassword["MinimumNumbers"] = ExpressionConverter.ConvertO(__workflow_generatePasswordminimumNumbers);
                        generatePasswordpropCount++;
                    }

                    generatePasswordpropCount++;
                }
                else
                {
                    generatePassword["MinimumNumbers"] = 0;
                    generatePasswordpropCount++;
                }

                if (__workflow_generatePasswordminimumSymbols != null)
                {
                    if (__workflow_generatePasswordminimumSymbols != null)
                    {
                        generatePassword["MinimumSymbols"] = ExpressionConverter.ConvertO(__workflow_generatePasswordminimumSymbols);
                        generatePasswordpropCount++;
                    }

                    generatePasswordpropCount++;
                }
                else
                {
                    generatePassword["MinimumSymbols"] = 0;
                    generatePasswordpropCount++;
                }

                generatePasswordpropCount++;
                generatePassword["Workflow"] = ExpressionConverter.ConvertO(__workflow_generatePasswordworkflow);
                if (generatePasswordpropCount > 0)
                {
                    callPayload.Body = generatePassword;
                }

                return new ApiConnectionAction<GeneratePasswordResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetStoredPasswordResponse> GetStoredPassword(Expression<Func<string>> getStoredPasswordworkflow, Expression<Func<string>> getStoredPasswordpasswordIdentifier = null)
        {
            var __workflow_getStoredPasswordworkflow = WorkflowExpression.Compile(getStoredPasswordworkflow, nameof(getStoredPasswordworkflow), required: true);
            var __workflow_getStoredPasswordpasswordIdentifier = WorkflowExpression.Compile(getStoredPasswordpasswordIdentifier, nameof(getStoredPasswordpasswordIdentifier), required: false);
            return new DeferredBodyAction<GetStoredPasswordResponse>(() =>
            {
                var apiCallPath = "/Environment/GetStoredPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getStoredPassword = new JObject();
                var getStoredPasswordpropCount = 0;
                if (__workflow_getStoredPasswordpasswordIdentifier != null)
                {
                    getStoredPassword["PasswordIdentifier"] = ExpressionConverter.ConvertO(__workflow_getStoredPasswordpasswordIdentifier);
                    getStoredPasswordpropCount++;
                }

                getStoredPasswordpropCount++;
                getStoredPassword["Workflow"] = ExpressionConverter.ConvertO(__workflow_getStoredPasswordworkflow);
                if (getStoredPasswordpropCount > 0)
                {
                    callPayload.Body = getStoredPassword;
                }

                return new ApiConnectionAction<GetStoredPasswordResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ExpandPasswordStringResponse> ExpandPasswordString(Expression<Func<string>> expandPasswordStringworkflow, Expression<Func<string>> expandPasswordStringinputString = null)
        {
            var __workflow_expandPasswordStringworkflow = WorkflowExpression.Compile(expandPasswordStringworkflow, nameof(expandPasswordStringworkflow), required: true);
            var __workflow_expandPasswordStringinputString = WorkflowExpression.Compile(expandPasswordStringinputString, nameof(expandPasswordStringinputString), required: false);
            return new DeferredBodyAction<ExpandPasswordStringResponse>(() =>
            {
                var apiCallPath = "/Environment/ExpandPasswordString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var expandPasswordString = new JObject();
                var expandPasswordStringpropCount = 0;
                if (__workflow_expandPasswordStringinputString != null)
                {
                    expandPasswordString["InputString"] = ExpressionConverter.ConvertO(__workflow_expandPasswordStringinputString);
                    expandPasswordStringpropCount++;
                }

                expandPasswordStringpropCount++;
                expandPasswordString["Workflow"] = ExpressionConverter.ConvertO(__workflow_expandPasswordStringworkflow);
                if (expandPasswordStringpropCount > 0)
                {
                    callPayload.Body = expandPasswordString;
                }

                return new ApiConnectionAction<ExpandPasswordStringResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<StorePasswordInAgentMemoryResponse> StorePasswordInAgentMemory(Expression<Func<string>> storePasswordInAgentMemoryidentifier, Expression<Func<string>> storePasswordInAgentMemorypassword, Expression<Func<string>> storePasswordInAgentMemoryworkflow)
        {
            var __workflow_storePasswordInAgentMemoryidentifier = WorkflowExpression.Compile(storePasswordInAgentMemoryidentifier, nameof(storePasswordInAgentMemoryidentifier), required: true);
            var __workflow_storePasswordInAgentMemorypassword = WorkflowExpression.Compile(storePasswordInAgentMemorypassword, nameof(storePasswordInAgentMemorypassword), required: true);
            var __workflow_storePasswordInAgentMemoryworkflow = WorkflowExpression.Compile(storePasswordInAgentMemoryworkflow, nameof(storePasswordInAgentMemoryworkflow), required: true);
            return new DeferredBodyAction<StorePasswordInAgentMemoryResponse>(() =>
            {
                var apiCallPath = "/Environment/StorePasswordInAgentMemory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var storePasswordInAgentMemory = new JObject();
                var storePasswordInAgentMemorypropCount = 0;
                storePasswordInAgentMemorypropCount++;
                storePasswordInAgentMemory["Identifier"] = ExpressionConverter.ConvertO(__workflow_storePasswordInAgentMemoryidentifier);
                storePasswordInAgentMemorypropCount++;
                storePasswordInAgentMemory["Password"] = ExpressionConverter.ConvertO(__workflow_storePasswordInAgentMemorypassword);
                storePasswordInAgentMemorypropCount++;
                storePasswordInAgentMemory["Workflow"] = ExpressionConverter.ConvertO(__workflow_storePasswordInAgentMemoryworkflow);
                if (storePasswordInAgentMemorypropCount > 0)
                {
                    callPayload.Body = storePasswordInAgentMemory;
                }

                return new ApiConnectionAction<StorePasswordInAgentMemoryResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeletePasswordInAgentMemoryResponse> DeletePasswordInAgentMemory(Expression<Func<string>> deletePasswordInAgentMemoryworkflow, Expression<Func<bool>> deletePasswordInAgentMemorydeleteAllPasswords = null, Expression<Func<string>> deletePasswordInAgentMemoryidentifier = null)
        {
            var __workflow_deletePasswordInAgentMemoryworkflow = WorkflowExpression.Compile(deletePasswordInAgentMemoryworkflow, nameof(deletePasswordInAgentMemoryworkflow), required: true);
            var __workflow_deletePasswordInAgentMemorydeleteAllPasswords = WorkflowExpression.Compile(deletePasswordInAgentMemorydeleteAllPasswords, nameof(deletePasswordInAgentMemorydeleteAllPasswords), required: false);
            var __workflow_deletePasswordInAgentMemoryidentifier = WorkflowExpression.Compile(deletePasswordInAgentMemoryidentifier, nameof(deletePasswordInAgentMemoryidentifier), required: false);
            return new DeferredBodyAction<DeletePasswordInAgentMemoryResponse>(() =>
            {
                var apiCallPath = "/Environment/DeletePasswordInAgentMemory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deletePasswordInAgentMemory = new JObject();
                var deletePasswordInAgentMemorypropCount = 0;
                if (__workflow_deletePasswordInAgentMemorydeleteAllPasswords != null)
                {
                    if (__workflow_deletePasswordInAgentMemorydeleteAllPasswords != null)
                    {
                        deletePasswordInAgentMemory["DeleteAllPasswords"] = ExpressionConverter.ConvertO(__workflow_deletePasswordInAgentMemorydeleteAllPasswords);
                        deletePasswordInAgentMemorypropCount++;
                    }

                    deletePasswordInAgentMemorypropCount++;
                }
                else
                {
                    deletePasswordInAgentMemory["DeleteAllPasswords"] = false;
                    deletePasswordInAgentMemorypropCount++;
                }

                if (__workflow_deletePasswordInAgentMemoryidentifier != null)
                {
                    deletePasswordInAgentMemory["Identifier"] = ExpressionConverter.ConvertO(__workflow_deletePasswordInAgentMemoryidentifier);
                    deletePasswordInAgentMemorypropCount++;
                }

                deletePasswordInAgentMemorypropCount++;
                deletePasswordInAgentMemory["Workflow"] = ExpressionConverter.ConvertO(__workflow_deletePasswordInAgentMemoryworkflow);
                if (deletePasswordInAgentMemorypropCount > 0)
                {
                    callPayload.Body = deletePasswordInAgentMemory;
                }

                return new ApiConnectionAction<DeletePasswordInAgentMemoryResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialWriteResponse> CredentialWrite(Expression<Func<string>> credentialWritecredentialAddress, Expression<Func<string>> credentialWriteuserName, Expression<Func<string>> credentialWritepassword, Expression<Func<credentialWritecredentialTypeInput>> credentialWritecredentialType, Expression<Func<string>> credentialWriteworkflow, Expression<Func<credentialWritecredentialPersistenceInput>> credentialWritecredentialPersistence = null, Expression<Func<string>> credentialWritesymmetricKey = null, Expression<Func<string>> credentialWritestorePasswordAsIdentifier = null)
        {
            var __workflow_credentialWritecredentialAddress = WorkflowExpression.Compile(credentialWritecredentialAddress, nameof(credentialWritecredentialAddress), required: true);
            var __workflow_credentialWriteuserName = WorkflowExpression.Compile(credentialWriteuserName, nameof(credentialWriteuserName), required: true);
            var __workflow_credentialWritepassword = WorkflowExpression.Compile(credentialWritepassword, nameof(credentialWritepassword), required: true);
            var __workflow_credentialWritecredentialType = WorkflowExpression.Compile(credentialWritecredentialType, nameof(credentialWritecredentialType), required: true);
            var __workflow_credentialWriteworkflow = WorkflowExpression.Compile(credentialWriteworkflow, nameof(credentialWriteworkflow), required: true);
            var __workflow_credentialWritecredentialPersistence = WorkflowExpression.Compile(credentialWritecredentialPersistence, nameof(credentialWritecredentialPersistence), required: false);
            var __workflow_credentialWritesymmetricKey = WorkflowExpression.Compile(credentialWritesymmetricKey, nameof(credentialWritesymmetricKey), required: false);
            var __workflow_credentialWritestorePasswordAsIdentifier = WorkflowExpression.Compile(credentialWritestorePasswordAsIdentifier, nameof(credentialWritestorePasswordAsIdentifier), required: false);
            return new DeferredBodyAction<CredentialWriteResponse>(() =>
            {
                var apiCallPath = "/Environment/CredentialWrite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var credentialWrite = new JObject();
                var credentialWritepropCount = 0;
                credentialWritepropCount++;
                credentialWrite["CredentialAddress"] = ExpressionConverter.ConvertO(__workflow_credentialWritecredentialAddress);
                credentialWritepropCount++;
                credentialWrite["UserName"] = ExpressionConverter.ConvertO(__workflow_credentialWriteuserName);
                credentialWritepropCount++;
                credentialWrite["Password"] = ExpressionConverter.ConvertO(__workflow_credentialWritepassword);
                credentialWritepropCount++;
                credentialWrite["CredentialType"] = ExpressionConverter.ConvertO(__workflow_credentialWritecredentialType);
                if (__workflow_credentialWritecredentialPersistence != null)
                {
                    if (__workflow_credentialWritecredentialPersistence != null)
                    {
                        credentialWrite["CredentialPersistence"] = ExpressionConverter.ConvertO(__workflow_credentialWritecredentialPersistence);
                        credentialWritepropCount++;
                    }

                    credentialWritepropCount++;
                }
                else
                {
                    credentialWrite["CredentialPersistence"] = "LocalMachine";
                    credentialWritepropCount++;
                }

                if (__workflow_credentialWritesymmetricKey != null)
                {
                    credentialWrite["SymmetricKey"] = ExpressionConverter.ConvertO(__workflow_credentialWritesymmetricKey);
                    credentialWritepropCount++;
                }

                if (__workflow_credentialWritestorePasswordAsIdentifier != null)
                {
                    credentialWrite["StorePasswordAsIdentifier"] = ExpressionConverter.ConvertO(__workflow_credentialWritestorePasswordAsIdentifier);
                    credentialWritepropCount++;
                }

                credentialWritepropCount++;
                credentialWrite["Workflow"] = ExpressionConverter.ConvertO(__workflow_credentialWriteworkflow);
                if (credentialWritepropCount > 0)
                {
                    callPayload.Body = credentialWrite;
                }

                return new ApiConnectionAction<CredentialWriteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialReadResponse> CredentialRead(Expression<Func<string>> credentialReadcredentialAddress, Expression<Func<credentialReadcredentialTypeInput>> credentialReadcredentialType, Expression<Func<string>> credentialReadworkflow, Expression<Func<string>> credentialReadsymmetricKey = null, Expression<Func<string>> credentialReadstorePasswordAsIdentifier = null, Expression<Func<bool>> credentialReaddontReturnPassword = null)
        {
            var __workflow_credentialReadcredentialAddress = WorkflowExpression.Compile(credentialReadcredentialAddress, nameof(credentialReadcredentialAddress), required: true);
            var __workflow_credentialReadcredentialType = WorkflowExpression.Compile(credentialReadcredentialType, nameof(credentialReadcredentialType), required: true);
            var __workflow_credentialReadworkflow = WorkflowExpression.Compile(credentialReadworkflow, nameof(credentialReadworkflow), required: true);
            var __workflow_credentialReadsymmetricKey = WorkflowExpression.Compile(credentialReadsymmetricKey, nameof(credentialReadsymmetricKey), required: false);
            var __workflow_credentialReadstorePasswordAsIdentifier = WorkflowExpression.Compile(credentialReadstorePasswordAsIdentifier, nameof(credentialReadstorePasswordAsIdentifier), required: false);
            var __workflow_credentialReaddontReturnPassword = WorkflowExpression.Compile(credentialReaddontReturnPassword, nameof(credentialReaddontReturnPassword), required: false);
            return new DeferredBodyAction<CredentialReadResponse>(() =>
            {
                var apiCallPath = "/Environment/CredentialRead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var credentialRead = new JObject();
                var credentialReadpropCount = 0;
                credentialReadpropCount++;
                credentialRead["CredentialAddress"] = ExpressionConverter.ConvertO(__workflow_credentialReadcredentialAddress);
                credentialReadpropCount++;
                credentialRead["CredentialType"] = ExpressionConverter.ConvertO(__workflow_credentialReadcredentialType);
                if (__workflow_credentialReadsymmetricKey != null)
                {
                    credentialRead["SymmetricKey"] = ExpressionConverter.ConvertO(__workflow_credentialReadsymmetricKey);
                    credentialReadpropCount++;
                }

                if (__workflow_credentialReadstorePasswordAsIdentifier != null)
                {
                    credentialRead["StorePasswordAsIdentifier"] = ExpressionConverter.ConvertO(__workflow_credentialReadstorePasswordAsIdentifier);
                    credentialReadpropCount++;
                }

                if (__workflow_credentialReaddontReturnPassword != null)
                {
                    if (__workflow_credentialReaddontReturnPassword != null)
                    {
                        credentialRead["DontReturnPassword"] = ExpressionConverter.ConvertO(__workflow_credentialReaddontReturnPassword);
                        credentialReadpropCount++;
                    }

                    credentialReadpropCount++;
                }
                else
                {
                    credentialRead["DontReturnPassword"] = false;
                    credentialReadpropCount++;
                }

                credentialReadpropCount++;
                credentialRead["Workflow"] = ExpressionConverter.ConvertO(__workflow_credentialReadworkflow);
                if (credentialReadpropCount > 0)
                {
                    callPayload.Body = credentialRead;
                }

                return new ApiConnectionAction<CredentialReadResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialDeleteResponse> CredentialDelete(Expression<Func<string>> credentialDeletecredentialAddress, Expression<Func<credentialDeletecredentialTypeInput>> credentialDeletecredentialType, Expression<Func<string>> credentialDeleteworkflow)
        {
            var __workflow_credentialDeletecredentialAddress = WorkflowExpression.Compile(credentialDeletecredentialAddress, nameof(credentialDeletecredentialAddress), required: true);
            var __workflow_credentialDeletecredentialType = WorkflowExpression.Compile(credentialDeletecredentialType, nameof(credentialDeletecredentialType), required: true);
            var __workflow_credentialDeleteworkflow = WorkflowExpression.Compile(credentialDeleteworkflow, nameof(credentialDeleteworkflow), required: true);
            return new DeferredBodyAction<CredentialDeleteResponse>(() =>
            {
                var apiCallPath = "/Environment/CredentialDelete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var credentialDelete = new JObject();
                var credentialDeletepropCount = 0;
                credentialDeletepropCount++;
                credentialDelete["CredentialAddress"] = ExpressionConverter.ConvertO(__workflow_credentialDeletecredentialAddress);
                credentialDeletepropCount++;
                credentialDelete["CredentialType"] = ExpressionConverter.ConvertO(__workflow_credentialDeletecredentialType);
                credentialDeletepropCount++;
                credentialDelete["Workflow"] = ExpressionConverter.ConvertO(__workflow_credentialDeleteworkflow);
                if (credentialDeletepropCount > 0)
                {
                    callPayload.Body = credentialDelete;
                }

                return new ApiConnectionAction<CredentialDeleteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GenerateRDPFileResponse> GenerateRDPFile(Expression<Func<string>> generateRDPFileremoteAddress, Expression<Func<string>> generateRDPFileoutputFolderPath, Expression<Func<string>> generateRDPFilerDPFileName, Expression<Func<string>> generateRDPFileworkflow, Expression<Func<bool>> generateRDPFileoverwriteRDPFileIfAlreadyExists = null, Expression<Func<bool>> generateRDPFiletrustRemoteComputer = null, Expression<Func<bool>> generateRDPFilestoreCredentials = null, Expression<Func<string>> generateRDPFileuserName = null, Expression<Func<string>> generateRDPFilepassword = null, Expression<Func<generateRDPFilecredentialTypeInput>> generateRDPFilecredentialType = null, Expression<Func<generateRDPFilecredentialPersistenceInput>> generateRDPFilecredentialPersistence = null, Expression<Func<bool>> generateRDPFileredirectPrinters = null, Expression<Func<bool>> generateRDPFileredirectAllDrives = null, Expression<Func<bool>> generateRDPFileredirectClipboard = null, Expression<Func<bool>> generateRDPFilefullscreen = null, Expression<Func<int>> generateRDPFiledesktopWidth = null, Expression<Func<int>> generateRDPFiledesktopHeight = null, Expression<Func<bool>> generateRDPFileuseMultiMonitor = null, Expression<Func<int>> generateRDPFilesessionBPP = null, Expression<Func<bool>> generateRDPFilesmartSizing = null)
        {
            var __workflow_generateRDPFileremoteAddress = WorkflowExpression.Compile(generateRDPFileremoteAddress, nameof(generateRDPFileremoteAddress), required: true);
            var __workflow_generateRDPFileoutputFolderPath = WorkflowExpression.Compile(generateRDPFileoutputFolderPath, nameof(generateRDPFileoutputFolderPath), required: true);
            var __workflow_generateRDPFilerDPFileName = WorkflowExpression.Compile(generateRDPFilerDPFileName, nameof(generateRDPFilerDPFileName), required: true);
            var __workflow_generateRDPFileworkflow = WorkflowExpression.Compile(generateRDPFileworkflow, nameof(generateRDPFileworkflow), required: true);
            var __workflow_generateRDPFileoverwriteRDPFileIfAlreadyExists = WorkflowExpression.Compile(generateRDPFileoverwriteRDPFileIfAlreadyExists, nameof(generateRDPFileoverwriteRDPFileIfAlreadyExists), required: false);
            var __workflow_generateRDPFiletrustRemoteComputer = WorkflowExpression.Compile(generateRDPFiletrustRemoteComputer, nameof(generateRDPFiletrustRemoteComputer), required: false);
            var __workflow_generateRDPFilestoreCredentials = WorkflowExpression.Compile(generateRDPFilestoreCredentials, nameof(generateRDPFilestoreCredentials), required: false);
            var __workflow_generateRDPFileuserName = WorkflowExpression.Compile(generateRDPFileuserName, nameof(generateRDPFileuserName), required: false);
            var __workflow_generateRDPFilepassword = WorkflowExpression.Compile(generateRDPFilepassword, nameof(generateRDPFilepassword), required: false);
            var __workflow_generateRDPFilecredentialType = WorkflowExpression.Compile(generateRDPFilecredentialType, nameof(generateRDPFilecredentialType), required: false);
            var __workflow_generateRDPFilecredentialPersistence = WorkflowExpression.Compile(generateRDPFilecredentialPersistence, nameof(generateRDPFilecredentialPersistence), required: false);
            var __workflow_generateRDPFileredirectPrinters = WorkflowExpression.Compile(generateRDPFileredirectPrinters, nameof(generateRDPFileredirectPrinters), required: false);
            var __workflow_generateRDPFileredirectAllDrives = WorkflowExpression.Compile(generateRDPFileredirectAllDrives, nameof(generateRDPFileredirectAllDrives), required: false);
            var __workflow_generateRDPFileredirectClipboard = WorkflowExpression.Compile(generateRDPFileredirectClipboard, nameof(generateRDPFileredirectClipboard), required: false);
            var __workflow_generateRDPFilefullscreen = WorkflowExpression.Compile(generateRDPFilefullscreen, nameof(generateRDPFilefullscreen), required: false);
            var __workflow_generateRDPFiledesktopWidth = WorkflowExpression.Compile(generateRDPFiledesktopWidth, nameof(generateRDPFiledesktopWidth), required: false);
            var __workflow_generateRDPFiledesktopHeight = WorkflowExpression.Compile(generateRDPFiledesktopHeight, nameof(generateRDPFiledesktopHeight), required: false);
            var __workflow_generateRDPFileuseMultiMonitor = WorkflowExpression.Compile(generateRDPFileuseMultiMonitor, nameof(generateRDPFileuseMultiMonitor), required: false);
            var __workflow_generateRDPFilesessionBPP = WorkflowExpression.Compile(generateRDPFilesessionBPP, nameof(generateRDPFilesessionBPP), required: false);
            var __workflow_generateRDPFilesmartSizing = WorkflowExpression.Compile(generateRDPFilesmartSizing, nameof(generateRDPFilesmartSizing), required: false);
            return new DeferredBodyAction<GenerateRDPFileResponse>(() =>
            {
                var apiCallPath = "/Environment/GenerateRDPFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var generateRDPFile = new JObject();
                var generateRDPFilepropCount = 0;
                generateRDPFilepropCount++;
                generateRDPFile["RemoteAddress"] = ExpressionConverter.ConvertO(__workflow_generateRDPFileremoteAddress);
                generateRDPFilepropCount++;
                generateRDPFile["OutputFolderPath"] = ExpressionConverter.ConvertO(__workflow_generateRDPFileoutputFolderPath);
                generateRDPFilepropCount++;
                generateRDPFile["RDPFileName"] = ExpressionConverter.ConvertO(__workflow_generateRDPFilerDPFileName);
                if (__workflow_generateRDPFileoverwriteRDPFileIfAlreadyExists != null)
                {
                    if (__workflow_generateRDPFileoverwriteRDPFileIfAlreadyExists != null)
                    {
                        generateRDPFile["OverwriteRDPFileIfAlreadyExists"] = ExpressionConverter.ConvertO(__workflow_generateRDPFileoverwriteRDPFileIfAlreadyExists);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["OverwriteRDPFileIfAlreadyExists"] = true;
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFiletrustRemoteComputer != null)
                {
                    if (__workflow_generateRDPFiletrustRemoteComputer != null)
                    {
                        generateRDPFile["TrustRemoteComputer"] = ExpressionConverter.ConvertO(__workflow_generateRDPFiletrustRemoteComputer);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["TrustRemoteComputer"] = true;
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFilestoreCredentials != null)
                {
                    if (__workflow_generateRDPFilestoreCredentials != null)
                    {
                        generateRDPFile["StoreCredentials"] = ExpressionConverter.ConvertO(__workflow_generateRDPFilestoreCredentials);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["StoreCredentials"] = true;
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFileuserName != null)
                {
                    generateRDPFile["UserName"] = ExpressionConverter.ConvertO(__workflow_generateRDPFileuserName);
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFilepassword != null)
                {
                    generateRDPFile["Password"] = ExpressionConverter.ConvertO(__workflow_generateRDPFilepassword);
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFilecredentialType != null)
                {
                    if (__workflow_generateRDPFilecredentialType != null)
                    {
                        generateRDPFile["CredentialType"] = ExpressionConverter.ConvertO(__workflow_generateRDPFilecredentialType);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["CredentialType"] = "Windows";
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFilecredentialPersistence != null)
                {
                    if (__workflow_generateRDPFilecredentialPersistence != null)
                    {
                        generateRDPFile["CredentialPersistence"] = ExpressionConverter.ConvertO(__workflow_generateRDPFilecredentialPersistence);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["CredentialPersistence"] = "Session";
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFileredirectPrinters != null)
                {
                    if (__workflow_generateRDPFileredirectPrinters != null)
                    {
                        generateRDPFile["RedirectPrinters"] = ExpressionConverter.ConvertO(__workflow_generateRDPFileredirectPrinters);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["RedirectPrinters"] = false;
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFileredirectAllDrives != null)
                {
                    if (__workflow_generateRDPFileredirectAllDrives != null)
                    {
                        generateRDPFile["RedirectAllDrives"] = ExpressionConverter.ConvertO(__workflow_generateRDPFileredirectAllDrives);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["RedirectAllDrives"] = false;
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFileredirectClipboard != null)
                {
                    if (__workflow_generateRDPFileredirectClipboard != null)
                    {
                        generateRDPFile["RedirectClipboard"] = ExpressionConverter.ConvertO(__workflow_generateRDPFileredirectClipboard);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["RedirectClipboard"] = true;
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFilefullscreen != null)
                {
                    if (__workflow_generateRDPFilefullscreen != null)
                    {
                        generateRDPFile["Fullscreen"] = ExpressionConverter.ConvertO(__workflow_generateRDPFilefullscreen);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["Fullscreen"] = true;
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFiledesktopWidth != null)
                {
                    if (__workflow_generateRDPFiledesktopWidth != null)
                    {
                        generateRDPFile["DesktopWidth"] = ExpressionConverter.ConvertO(__workflow_generateRDPFiledesktopWidth);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["DesktopWidth"] = 1280;
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFiledesktopHeight != null)
                {
                    if (__workflow_generateRDPFiledesktopHeight != null)
                    {
                        generateRDPFile["DesktopHeight"] = ExpressionConverter.ConvertO(__workflow_generateRDPFiledesktopHeight);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["DesktopHeight"] = 1024;
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFileuseMultiMonitor != null)
                {
                    if (__workflow_generateRDPFileuseMultiMonitor != null)
                    {
                        generateRDPFile["UseMultiMonitor"] = ExpressionConverter.ConvertO(__workflow_generateRDPFileuseMultiMonitor);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["UseMultiMonitor"] = false;
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFilesessionBPP != null)
                {
                    if (__workflow_generateRDPFilesessionBPP != null)
                    {
                        generateRDPFile["SessionBPP"] = ExpressionConverter.ConvertO(__workflow_generateRDPFilesessionBPP);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["SessionBPP"] = 32;
                    generateRDPFilepropCount++;
                }

                if (__workflow_generateRDPFilesmartSizing != null)
                {
                    if (__workflow_generateRDPFilesmartSizing != null)
                    {
                        generateRDPFile["SmartSizing"] = ExpressionConverter.ConvertO(__workflow_generateRDPFilesmartSizing);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["SmartSizing"] = true;
                    generateRDPFilepropCount++;
                }

                generateRDPFilepropCount++;
                generateRDPFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_generateRDPFileworkflow);
                if (generateRDPFilepropCount > 0)
                {
                    callPayload.Body = generateRDPFile;
                }

                return new ApiConnectionAction<GenerateRDPFileResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<LaunchRemoteDesktopSessionResponse> LaunchRemoteDesktopSession(Expression<Func<string>> launchRemoteDesktopSessionrDPFilePath, Expression<Func<string>> launchRemoteDesktopSessionworkflow, Expression<Func<bool>> launchRemoteDesktopSessiontrustRemoteComputer = null)
        {
            var __workflow_launchRemoteDesktopSessionrDPFilePath = WorkflowExpression.Compile(launchRemoteDesktopSessionrDPFilePath, nameof(launchRemoteDesktopSessionrDPFilePath), required: true);
            var __workflow_launchRemoteDesktopSessionworkflow = WorkflowExpression.Compile(launchRemoteDesktopSessionworkflow, nameof(launchRemoteDesktopSessionworkflow), required: true);
            var __workflow_launchRemoteDesktopSessiontrustRemoteComputer = WorkflowExpression.Compile(launchRemoteDesktopSessiontrustRemoteComputer, nameof(launchRemoteDesktopSessiontrustRemoteComputer), required: false);
            return new DeferredBodyAction<LaunchRemoteDesktopSessionResponse>(() =>
            {
                var apiCallPath = "/Environment/LaunchRemoteDesktopSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var launchRemoteDesktopSession = new JObject();
                var launchRemoteDesktopSessionpropCount = 0;
                launchRemoteDesktopSessionpropCount++;
                launchRemoteDesktopSession["RDPFilePath"] = ExpressionConverter.ConvertO(__workflow_launchRemoteDesktopSessionrDPFilePath);
                if (__workflow_launchRemoteDesktopSessiontrustRemoteComputer != null)
                {
                    if (__workflow_launchRemoteDesktopSessiontrustRemoteComputer != null)
                    {
                        launchRemoteDesktopSession["TrustRemoteComputer"] = ExpressionConverter.ConvertO(__workflow_launchRemoteDesktopSessiontrustRemoteComputer);
                        launchRemoteDesktopSessionpropCount++;
                    }

                    launchRemoteDesktopSessionpropCount++;
                }
                else
                {
                    launchRemoteDesktopSession["TrustRemoteComputer"] = true;
                    launchRemoteDesktopSessionpropCount++;
                }

                launchRemoteDesktopSessionpropCount++;
                launchRemoteDesktopSession["Workflow"] = ExpressionConverter.ConvertO(__workflow_launchRemoteDesktopSessionworkflow);
                if (launchRemoteDesktopSessionpropCount > 0)
                {
                    callPayload.Body = launchRemoteDesktopSession;
                }

                return new ApiConnectionAction<LaunchRemoteDesktopSessionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsTCPPortRespondingResponse> IsTCPPortResponding(Expression<Func<string>> isTCPPortRespondingremoteHost, Expression<Func<int>> isTCPPortRespondingtCPPort, Expression<Func<string>> isTCPPortRespondingworkflow, Expression<Func<int>> isTCPPortRespondingtimeoutInSeconds = null)
        {
            var __workflow_isTCPPortRespondingremoteHost = WorkflowExpression.Compile(isTCPPortRespondingremoteHost, nameof(isTCPPortRespondingremoteHost), required: true);
            var __workflow_isTCPPortRespondingtCPPort = WorkflowExpression.Compile(isTCPPortRespondingtCPPort, nameof(isTCPPortRespondingtCPPort), required: true);
            var __workflow_isTCPPortRespondingworkflow = WorkflowExpression.Compile(isTCPPortRespondingworkflow, nameof(isTCPPortRespondingworkflow), required: true);
            var __workflow_isTCPPortRespondingtimeoutInSeconds = WorkflowExpression.Compile(isTCPPortRespondingtimeoutInSeconds, nameof(isTCPPortRespondingtimeoutInSeconds), required: false);
            return new DeferredBodyAction<IsTCPPortRespondingResponse>(() =>
            {
                var apiCallPath = "/Environment/IsTCPPortResponding";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isTCPPortResponding = new JObject();
                var isTCPPortRespondingpropCount = 0;
                isTCPPortRespondingpropCount++;
                isTCPPortResponding["RemoteHost"] = ExpressionConverter.ConvertO(__workflow_isTCPPortRespondingremoteHost);
                isTCPPortRespondingpropCount++;
                isTCPPortResponding["TCPPort"] = ExpressionConverter.ConvertO(__workflow_isTCPPortRespondingtCPPort);
                if (__workflow_isTCPPortRespondingtimeoutInSeconds != null)
                {
                    if (__workflow_isTCPPortRespondingtimeoutInSeconds != null)
                    {
                        isTCPPortResponding["TimeoutInSeconds"] = ExpressionConverter.ConvertO(__workflow_isTCPPortRespondingtimeoutInSeconds);
                        isTCPPortRespondingpropCount++;
                    }

                    isTCPPortRespondingpropCount++;
                }
                else
                {
                    isTCPPortResponding["TimeoutInSeconds"] = 10;
                    isTCPPortRespondingpropCount++;
                }

                isTCPPortRespondingpropCount++;
                isTCPPortResponding["Workflow"] = ExpressionConverter.ConvertO(__workflow_isTCPPortRespondingworkflow);
                if (isTCPPortRespondingpropCount > 0)
                {
                    callPayload.Body = isTCPPortResponding;
                }

                return new ApiConnectionAction<IsTCPPortRespondingResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UnlockSessionResponse> UnlockSession(Expression<Func<string>> unlockSessionunlockPassword, Expression<Func<bool>> unlockSessiondetectIfLocked, Expression<Func<bool>> unlockSessiondetectCredentialProvider, Expression<Func<string>> unlockSessionworkflow, Expression<Func<bool>> unlockSessionpasswordContainsStoredPassword = null, Expression<Func<int>> unlockSessionsecondsToWaitForUnlock = null)
        {
            var __workflow_unlockSessionunlockPassword = WorkflowExpression.Compile(unlockSessionunlockPassword, nameof(unlockSessionunlockPassword), required: true);
            var __workflow_unlockSessiondetectIfLocked = WorkflowExpression.Compile(unlockSessiondetectIfLocked, nameof(unlockSessiondetectIfLocked), required: true);
            var __workflow_unlockSessiondetectCredentialProvider = WorkflowExpression.Compile(unlockSessiondetectCredentialProvider, nameof(unlockSessiondetectCredentialProvider), required: true);
            var __workflow_unlockSessionworkflow = WorkflowExpression.Compile(unlockSessionworkflow, nameof(unlockSessionworkflow), required: true);
            var __workflow_unlockSessionpasswordContainsStoredPassword = WorkflowExpression.Compile(unlockSessionpasswordContainsStoredPassword, nameof(unlockSessionpasswordContainsStoredPassword), required: false);
            var __workflow_unlockSessionsecondsToWaitForUnlock = WorkflowExpression.Compile(unlockSessionsecondsToWaitForUnlock, nameof(unlockSessionsecondsToWaitForUnlock), required: false);
            return new DeferredBodyAction<UnlockSessionResponse>(() =>
            {
                var apiCallPath = "/Environment/UnlockSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var unlockSession = new JObject();
                var unlockSessionpropCount = 0;
                unlockSessionpropCount++;
                unlockSession["UnlockPassword"] = ExpressionConverter.ConvertO(__workflow_unlockSessionunlockPassword);
                if (__workflow_unlockSessionpasswordContainsStoredPassword != null)
                {
                    if (__workflow_unlockSessionpasswordContainsStoredPassword != null)
                    {
                        unlockSession["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_unlockSessionpasswordContainsStoredPassword);
                        unlockSessionpropCount++;
                    }

                    unlockSessionpropCount++;
                }
                else
                {
                    unlockSession["PasswordContainsStoredPassword"] = false;
                    unlockSessionpropCount++;
                }

                unlockSessionpropCount++;
                unlockSession["DetectIfLocked"] = ExpressionConverter.ConvertO(__workflow_unlockSessiondetectIfLocked);
                unlockSessionpropCount++;
                unlockSession["DetectCredentialProvider"] = ExpressionConverter.ConvertO(__workflow_unlockSessiondetectCredentialProvider);
                if (__workflow_unlockSessionsecondsToWaitForUnlock != null)
                {
                    if (__workflow_unlockSessionsecondsToWaitForUnlock != null)
                    {
                        unlockSession["SecondsToWaitForUnlock"] = ExpressionConverter.ConvertO(__workflow_unlockSessionsecondsToWaitForUnlock);
                        unlockSessionpropCount++;
                    }

                    unlockSessionpropCount++;
                }
                else
                {
                    unlockSession["SecondsToWaitForUnlock"] = 5;
                    unlockSessionpropCount++;
                }

                unlockSessionpropCount++;
                unlockSession["Workflow"] = ExpressionConverter.ConvertO(__workflow_unlockSessionworkflow);
                if (unlockSessionpropCount > 0)
                {
                    callPayload.Body = unlockSession;
                }

                return new ApiConnectionAction<UnlockSessionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<LockSessionResponse> LockSession(Expression<Func<string>> lockSessionworkflow, Expression<Func<int>> lockSessionlockAfterMinutesOfActionInactivity = null, Expression<Func<int>> lockSessionsecondsToWaitAfterLock = null)
        {
            var __workflow_lockSessionworkflow = WorkflowExpression.Compile(lockSessionworkflow, nameof(lockSessionworkflow), required: true);
            var __workflow_lockSessionlockAfterMinutesOfActionInactivity = WorkflowExpression.Compile(lockSessionlockAfterMinutesOfActionInactivity, nameof(lockSessionlockAfterMinutesOfActionInactivity), required: false);
            var __workflow_lockSessionsecondsToWaitAfterLock = WorkflowExpression.Compile(lockSessionsecondsToWaitAfterLock, nameof(lockSessionsecondsToWaitAfterLock), required: false);
            return new DeferredBodyAction<LockSessionResponse>(() =>
            {
                var apiCallPath = "/Environment/LockSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lockSession = new JObject();
                var lockSessionpropCount = 0;
                if (__workflow_lockSessionlockAfterMinutesOfActionInactivity != null)
                {
                    if (__workflow_lockSessionlockAfterMinutesOfActionInactivity != null)
                    {
                        lockSession["LockAfterMinutesOfActionInactivity"] = ExpressionConverter.ConvertO(__workflow_lockSessionlockAfterMinutesOfActionInactivity);
                        lockSessionpropCount++;
                    }

                    lockSessionpropCount++;
                }
                else
                {
                    lockSession["LockAfterMinutesOfActionInactivity"] = 5;
                    lockSessionpropCount++;
                }

                if (__workflow_lockSessionsecondsToWaitAfterLock != null)
                {
                    if (__workflow_lockSessionsecondsToWaitAfterLock != null)
                    {
                        lockSession["SecondsToWaitAfterLock"] = ExpressionConverter.ConvertO(__workflow_lockSessionsecondsToWaitAfterLock);
                        lockSessionpropCount++;
                    }

                    lockSessionpropCount++;
                }
                else
                {
                    lockSession["SecondsToWaitAfterLock"] = 3;
                    lockSessionpropCount++;
                }

                lockSessionpropCount++;
                lockSession["Workflow"] = ExpressionConverter.ConvertO(__workflow_lockSessionworkflow);
                if (lockSessionpropCount > 0)
                {
                    callPayload.Body = lockSession;
                }

                return new ApiConnectionAction<LockSessionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsSessionLockedResponse> IsSessionLocked(Expression<Func<string>> isSessionLockedworkflow)
        {
            var __workflow_isSessionLockedworkflow = WorkflowExpression.Compile(isSessionLockedworkflow, nameof(isSessionLockedworkflow), required: true);
            return new DeferredBodyAction<IsSessionLockedResponse>(() =>
            {
                var apiCallPath = "/Environment/IsSessionLocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isSessionLocked = new JObject();
                var isSessionLockedpropCount = 0;
                isSessionLockedpropCount++;
                isSessionLocked["Workflow"] = ExpressionConverter.ConvertO(__workflow_isSessionLockedworkflow);
                if (isSessionLockedpropCount > 0)
                {
                    callPayload.Body = isSessionLocked;
                }

                return new ApiConnectionAction<IsSessionLockedResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetGenericCredentialFromOrchestratorResponse> GetGenericCredentialFromOrchestrator(Expression<Func<string>> getGenericCredentialFromOrchestratorfriendlyName = null, Expression<Func<bool>> getGenericCredentialFromOrchestratorretrievePlainTextPassword = null)
        {
            var __workflow_getGenericCredentialFromOrchestratorfriendlyName = WorkflowExpression.Compile(getGenericCredentialFromOrchestratorfriendlyName, nameof(getGenericCredentialFromOrchestratorfriendlyName), required: false);
            var __workflow_getGenericCredentialFromOrchestratorretrievePlainTextPassword = WorkflowExpression.Compile(getGenericCredentialFromOrchestratorretrievePlainTextPassword, nameof(getGenericCredentialFromOrchestratorretrievePlainTextPassword), required: false);
            return new DeferredBodyAction<GetGenericCredentialFromOrchestratorResponse>(() =>
            {
                var apiCallPath = "/Environment/GetGenericCredentialFromOrchestrator";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getGenericCredentialFromOrchestrator = new JObject();
                var getGenericCredentialFromOrchestratorpropCount = 0;
                if (__workflow_getGenericCredentialFromOrchestratorfriendlyName != null)
                {
                    getGenericCredentialFromOrchestrator["FriendlyName"] = ExpressionConverter.ConvertO(__workflow_getGenericCredentialFromOrchestratorfriendlyName);
                    getGenericCredentialFromOrchestratorpropCount++;
                }

                if (__workflow_getGenericCredentialFromOrchestratorretrievePlainTextPassword != null)
                {
                    if (__workflow_getGenericCredentialFromOrchestratorretrievePlainTextPassword != null)
                    {
                        getGenericCredentialFromOrchestrator["RetrievePlainTextPassword"] = ExpressionConverter.ConvertO(__workflow_getGenericCredentialFromOrchestratorretrievePlainTextPassword);
                        getGenericCredentialFromOrchestratorpropCount++;
                    }

                    getGenericCredentialFromOrchestratorpropCount++;
                }
                else
                {
                    getGenericCredentialFromOrchestrator["RetrievePlainTextPassword"] = false;
                    getGenericCredentialFromOrchestratorpropCount++;
                }

                if (getGenericCredentialFromOrchestratorpropCount > 0)
                {
                    callPayload.Body = getGenericCredentialFromOrchestrator;
                }

                return new ApiConnectionAction<GetGenericCredentialFromOrchestratorResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DrawRectangleOnScreenResponse> DrawRectangleOnScreen(Expression<Func<int>> drawRectangleOnScreenrectangleLeftPixelXCoord, Expression<Func<int>> drawRectangleOnScreenrectangleRightPixelXCoord, Expression<Func<int>> drawRectangleOnScreenrectangleTopPixelYCoord, Expression<Func<int>> drawRectangleOnScreenrectangleBottomPixelYCoord, Expression<Func<string>> drawRectangleOnScreenworkflow, Expression<Func<string>> drawRectangleOnScreenpenColour = null, Expression<Func<int>> drawRectangleOnScreenpenThicknessPixels = null, Expression<Func<int>> drawRectangleOnScreensecondsToDisplay = null, Expression<Func<bool>> drawRectangleOnScreencoordinatesArePhysical = null)
        {
            var __workflow_drawRectangleOnScreenrectangleLeftPixelXCoord = WorkflowExpression.Compile(drawRectangleOnScreenrectangleLeftPixelXCoord, nameof(drawRectangleOnScreenrectangleLeftPixelXCoord), required: true);
            var __workflow_drawRectangleOnScreenrectangleRightPixelXCoord = WorkflowExpression.Compile(drawRectangleOnScreenrectangleRightPixelXCoord, nameof(drawRectangleOnScreenrectangleRightPixelXCoord), required: true);
            var __workflow_drawRectangleOnScreenrectangleTopPixelYCoord = WorkflowExpression.Compile(drawRectangleOnScreenrectangleTopPixelYCoord, nameof(drawRectangleOnScreenrectangleTopPixelYCoord), required: true);
            var __workflow_drawRectangleOnScreenrectangleBottomPixelYCoord = WorkflowExpression.Compile(drawRectangleOnScreenrectangleBottomPixelYCoord, nameof(drawRectangleOnScreenrectangleBottomPixelYCoord), required: true);
            var __workflow_drawRectangleOnScreenworkflow = WorkflowExpression.Compile(drawRectangleOnScreenworkflow, nameof(drawRectangleOnScreenworkflow), required: true);
            var __workflow_drawRectangleOnScreenpenColour = WorkflowExpression.Compile(drawRectangleOnScreenpenColour, nameof(drawRectangleOnScreenpenColour), required: false);
            var __workflow_drawRectangleOnScreenpenThicknessPixels = WorkflowExpression.Compile(drawRectangleOnScreenpenThicknessPixels, nameof(drawRectangleOnScreenpenThicknessPixels), required: false);
            var __workflow_drawRectangleOnScreensecondsToDisplay = WorkflowExpression.Compile(drawRectangleOnScreensecondsToDisplay, nameof(drawRectangleOnScreensecondsToDisplay), required: false);
            var __workflow_drawRectangleOnScreencoordinatesArePhysical = WorkflowExpression.Compile(drawRectangleOnScreencoordinatesArePhysical, nameof(drawRectangleOnScreencoordinatesArePhysical), required: false);
            return new DeferredBodyAction<DrawRectangleOnScreenResponse>(() =>
            {
                var apiCallPath = "/Environment/DrawRectangleOnScreen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var drawRectangleOnScreen = new JObject();
                var drawRectangleOnScreenpropCount = 0;
                drawRectangleOnScreenpropCount++;
                drawRectangleOnScreen["RectangleLeftPixelXCoord"] = ExpressionConverter.ConvertO(__workflow_drawRectangleOnScreenrectangleLeftPixelXCoord);
                drawRectangleOnScreenpropCount++;
                drawRectangleOnScreen["RectangleRightPixelXCoord"] = ExpressionConverter.ConvertO(__workflow_drawRectangleOnScreenrectangleRightPixelXCoord);
                drawRectangleOnScreenpropCount++;
                drawRectangleOnScreen["RectangleTopPixelYCoord"] = ExpressionConverter.ConvertO(__workflow_drawRectangleOnScreenrectangleTopPixelYCoord);
                drawRectangleOnScreenpropCount++;
                drawRectangleOnScreen["RectangleBottomPixelYCoord"] = ExpressionConverter.ConvertO(__workflow_drawRectangleOnScreenrectangleBottomPixelYCoord);
                if (__workflow_drawRectangleOnScreenpenColour != null)
                {
                    if (__workflow_drawRectangleOnScreenpenColour != null)
                    {
                        drawRectangleOnScreen["PenColour"] = ExpressionConverter.ConvertO(__workflow_drawRectangleOnScreenpenColour);
                        drawRectangleOnScreenpropCount++;
                    }

                    drawRectangleOnScreenpropCount++;
                }
                else
                {
                    drawRectangleOnScreen["PenColour"] = "#800080";
                    drawRectangleOnScreenpropCount++;
                }

                if (__workflow_drawRectangleOnScreenpenThicknessPixels != null)
                {
                    if (__workflow_drawRectangleOnScreenpenThicknessPixels != null)
                    {
                        drawRectangleOnScreen["PenThicknessPixels"] = ExpressionConverter.ConvertO(__workflow_drawRectangleOnScreenpenThicknessPixels);
                        drawRectangleOnScreenpropCount++;
                    }

                    drawRectangleOnScreenpropCount++;
                }
                else
                {
                    drawRectangleOnScreen["PenThicknessPixels"] = 4;
                    drawRectangleOnScreenpropCount++;
                }

                if (__workflow_drawRectangleOnScreensecondsToDisplay != null)
                {
                    if (__workflow_drawRectangleOnScreensecondsToDisplay != null)
                    {
                        drawRectangleOnScreen["SecondsToDisplay"] = ExpressionConverter.ConvertO(__workflow_drawRectangleOnScreensecondsToDisplay);
                        drawRectangleOnScreenpropCount++;
                    }

                    drawRectangleOnScreenpropCount++;
                }
                else
                {
                    drawRectangleOnScreen["SecondsToDisplay"] = 5;
                    drawRectangleOnScreenpropCount++;
                }

                if (__workflow_drawRectangleOnScreencoordinatesArePhysical != null)
                {
                    if (__workflow_drawRectangleOnScreencoordinatesArePhysical != null)
                    {
                        drawRectangleOnScreen["CoordinatesArePhysical"] = ExpressionConverter.ConvertO(__workflow_drawRectangleOnScreencoordinatesArePhysical);
                        drawRectangleOnScreenpropCount++;
                    }

                    drawRectangleOnScreenpropCount++;
                }
                else
                {
                    drawRectangleOnScreen["CoordinatesArePhysical"] = false;
                    drawRectangleOnScreenpropCount++;
                }

                drawRectangleOnScreenpropCount++;
                drawRectangleOnScreen["Workflow"] = ExpressionConverter.ConvertO(__workflow_drawRectangleOnScreenworkflow);
                if (drawRectangleOnScreenpropCount > 0)
                {
                    callPayload.Body = drawRectangleOnScreen;
                }

                return new ApiConnectionAction<DrawRectangleOnScreenResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFailedActionErrorMessageFromPowerAutomateResultJSONResponse> GetFailedActionErrorMessageFromPowerAutomateResultJSON(Expression<Func<string[]>> getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON, Expression<Func<string>> getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus = null)
        {
            var __workflow_getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON = WorkflowExpression.Compile(getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON, nameof(getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON), required: true);
            var __workflow_getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus = WorkflowExpression.Compile(getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus, nameof(getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus), required: false);
            return new DeferredBodyAction<GetFailedActionErrorMessageFromPowerAutomateResultJSONResponse>(() =>
            {
                var apiCallPath = "/Environment/GetFailedActionErrorMessageFromPowerAutomateResultJSON";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getFailedActionErrorMessageFromPowerAutomateResultJSON = new JObject();
                var getFailedActionErrorMessageFromPowerAutomateResultJSONpropCount = 0;
                getFailedActionErrorMessageFromPowerAutomateResultJSONpropCount++;
                getFailedActionErrorMessageFromPowerAutomateResultJSON["PowerAutomateResultJSON"] = ExpressionConverter.ConvertO(__workflow_getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON);
                if (__workflow_getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus != null)
                {
                    if (__workflow_getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus != null)
                    {
                        getFailedActionErrorMessageFromPowerAutomateResultJSON["SearchStatus"] = ExpressionConverter.ConvertO(__workflow_getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus);
                        getFailedActionErrorMessageFromPowerAutomateResultJSONpropCount++;
                    }

                    getFailedActionErrorMessageFromPowerAutomateResultJSONpropCount++;
                }
                else
                {
                    getFailedActionErrorMessageFromPowerAutomateResultJSON["SearchStatus"] = "Failed";
                    getFailedActionErrorMessageFromPowerAutomateResultJSONpropCount++;
                }

                if (getFailedActionErrorMessageFromPowerAutomateResultJSONpropCount > 0)
                {
                    callPayload.Body = getFailedActionErrorMessageFromPowerAutomateResultJSON;
                }

                return new ApiConnectionAction<GetFailedActionErrorMessageFromPowerAutomateResultJSONResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetPixelColourAtCoordinateResponse> GetPixelColourAtCoordinate(Expression<Func<int>> getPixelColourAtCoordinateleftXPixels, Expression<Func<int>> getPixelColourAtCoordinatetopYPixels, Expression<Func<string>> getPixelColourAtCoordinateworkflow, Expression<Func<bool>> getPixelColourAtCoordinatehideAgent = null, Expression<Func<bool>> getPixelColourAtCoordinateusePhysicalCoordinates = null)
        {
            var __workflow_getPixelColourAtCoordinateleftXPixels = WorkflowExpression.Compile(getPixelColourAtCoordinateleftXPixels, nameof(getPixelColourAtCoordinateleftXPixels), required: true);
            var __workflow_getPixelColourAtCoordinatetopYPixels = WorkflowExpression.Compile(getPixelColourAtCoordinatetopYPixels, nameof(getPixelColourAtCoordinatetopYPixels), required: true);
            var __workflow_getPixelColourAtCoordinateworkflow = WorkflowExpression.Compile(getPixelColourAtCoordinateworkflow, nameof(getPixelColourAtCoordinateworkflow), required: true);
            var __workflow_getPixelColourAtCoordinatehideAgent = WorkflowExpression.Compile(getPixelColourAtCoordinatehideAgent, nameof(getPixelColourAtCoordinatehideAgent), required: false);
            var __workflow_getPixelColourAtCoordinateusePhysicalCoordinates = WorkflowExpression.Compile(getPixelColourAtCoordinateusePhysicalCoordinates, nameof(getPixelColourAtCoordinateusePhysicalCoordinates), required: false);
            return new DeferredBodyAction<GetPixelColourAtCoordinateResponse>(() =>
            {
                var apiCallPath = "/Environment/GetPixelColourAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getPixelColourAtCoordinate = new JObject();
                var getPixelColourAtCoordinatepropCount = 0;
                getPixelColourAtCoordinatepropCount++;
                getPixelColourAtCoordinate["LeftXPixels"] = ExpressionConverter.ConvertO(__workflow_getPixelColourAtCoordinateleftXPixels);
                getPixelColourAtCoordinatepropCount++;
                getPixelColourAtCoordinate["TopYPixels"] = ExpressionConverter.ConvertO(__workflow_getPixelColourAtCoordinatetopYPixels);
                if (__workflow_getPixelColourAtCoordinatehideAgent != null)
                {
                    if (__workflow_getPixelColourAtCoordinatehideAgent != null)
                    {
                        getPixelColourAtCoordinate["HideAgent"] = ExpressionConverter.ConvertO(__workflow_getPixelColourAtCoordinatehideAgent);
                        getPixelColourAtCoordinatepropCount++;
                    }

                    getPixelColourAtCoordinatepropCount++;
                }
                else
                {
                    getPixelColourAtCoordinate["HideAgent"] = false;
                    getPixelColourAtCoordinatepropCount++;
                }

                if (__workflow_getPixelColourAtCoordinateusePhysicalCoordinates != null)
                {
                    if (__workflow_getPixelColourAtCoordinateusePhysicalCoordinates != null)
                    {
                        getPixelColourAtCoordinate["UsePhysicalCoordinates"] = ExpressionConverter.ConvertO(__workflow_getPixelColourAtCoordinateusePhysicalCoordinates);
                        getPixelColourAtCoordinatepropCount++;
                    }

                    getPixelColourAtCoordinatepropCount++;
                }
                else
                {
                    getPixelColourAtCoordinate["UsePhysicalCoordinates"] = false;
                    getPixelColourAtCoordinatepropCount++;
                }

                getPixelColourAtCoordinatepropCount++;
                getPixelColourAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(__workflow_getPixelColourAtCoordinateworkflow);
                if (getPixelColourAtCoordinatepropCount > 0)
                {
                    callPayload.Body = getPixelColourAtCoordinate;
                }

                return new ApiConnectionAction<GetPixelColourAtCoordinateResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ConvertRectangleCoordinatesResponse> ConvertRectangleCoordinates(Expression<Func<int>> convertRectangleCoordinatesrectangleLeftPixelXCoord, Expression<Func<int>> convertRectangleCoordinatesrectangleTopPixelYCoord, Expression<Func<int>> convertRectangleCoordinatesrectangleRightPixelXCoord, Expression<Func<int>> convertRectangleCoordinatesrectangleBottomPixelYCoord, Expression<Func<convertRectangleCoordinatesconversionTypeInput>> convertRectangleCoordinatesconversionType, Expression<Func<string>> convertRectangleCoordinatesworkflow)
        {
            var __workflow_convertRectangleCoordinatesrectangleLeftPixelXCoord = WorkflowExpression.Compile(convertRectangleCoordinatesrectangleLeftPixelXCoord, nameof(convertRectangleCoordinatesrectangleLeftPixelXCoord), required: true);
            var __workflow_convertRectangleCoordinatesrectangleTopPixelYCoord = WorkflowExpression.Compile(convertRectangleCoordinatesrectangleTopPixelYCoord, nameof(convertRectangleCoordinatesrectangleTopPixelYCoord), required: true);
            var __workflow_convertRectangleCoordinatesrectangleRightPixelXCoord = WorkflowExpression.Compile(convertRectangleCoordinatesrectangleRightPixelXCoord, nameof(convertRectangleCoordinatesrectangleRightPixelXCoord), required: true);
            var __workflow_convertRectangleCoordinatesrectangleBottomPixelYCoord = WorkflowExpression.Compile(convertRectangleCoordinatesrectangleBottomPixelYCoord, nameof(convertRectangleCoordinatesrectangleBottomPixelYCoord), required: true);
            var __workflow_convertRectangleCoordinatesconversionType = WorkflowExpression.Compile(convertRectangleCoordinatesconversionType, nameof(convertRectangleCoordinatesconversionType), required: true);
            var __workflow_convertRectangleCoordinatesworkflow = WorkflowExpression.Compile(convertRectangleCoordinatesworkflow, nameof(convertRectangleCoordinatesworkflow), required: true);
            return new DeferredBodyAction<ConvertRectangleCoordinatesResponse>(() =>
            {
                var apiCallPath = "/Environment/ConvertRectangleCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var convertRectangleCoordinates = new JObject();
                var convertRectangleCoordinatespropCount = 0;
                convertRectangleCoordinatespropCount++;
                convertRectangleCoordinates["RectangleLeftPixelXCoord"] = ExpressionConverter.ConvertO(__workflow_convertRectangleCoordinatesrectangleLeftPixelXCoord);
                convertRectangleCoordinatespropCount++;
                convertRectangleCoordinates["RectangleTopPixelYCoord"] = ExpressionConverter.ConvertO(__workflow_convertRectangleCoordinatesrectangleTopPixelYCoord);
                convertRectangleCoordinatespropCount++;
                convertRectangleCoordinates["RectangleRightPixelXCoord"] = ExpressionConverter.ConvertO(__workflow_convertRectangleCoordinatesrectangleRightPixelXCoord);
                convertRectangleCoordinatespropCount++;
                convertRectangleCoordinates["RectangleBottomPixelYCoord"] = ExpressionConverter.ConvertO(__workflow_convertRectangleCoordinatesrectangleBottomPixelYCoord);
                convertRectangleCoordinatespropCount++;
                convertRectangleCoordinates["ConversionType"] = ExpressionConverter.ConvertO(__workflow_convertRectangleCoordinatesconversionType);
                convertRectangleCoordinatespropCount++;
                convertRectangleCoordinates["Workflow"] = ExpressionConverter.ConvertO(__workflow_convertRectangleCoordinatesworkflow);
                if (convertRectangleCoordinatespropCount > 0)
                {
                    callPayload.Body = convertRectangleCoordinates;
                }

                return new ApiConnectionAction<ConvertRectangleCoordinatesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SendMessageToWebAPIResponse> SendMessageToWebAPI(Expression<Func<string>> sendMessageToWebAPIworkflow, Expression<Func<string>> sendMessageToWebAPIuRL = null, Expression<Func<sendMessageToWebAPImethodInput>> sendMessageToWebAPImethod = null, Expression<Func<int>> sendMessageToWebAPItimeoutInSeconds = null, Expression<Func<string>> sendMessageToWebAPIcontentType = null, Expression<Func<string>> sendMessageToWebAPIaccept = null, Expression<Func<string>> sendMessageToWebAPImessageBody = null, Expression<Func<sendMessageToWebAPItransmitEncodingInput>> sendMessageToWebAPItransmitEncoding = null, Expression<Func<sendMessageToWebAPIresponseEncodingInput>> sendMessageToWebAPIresponseEncoding = null, Expression<Func<int>> sendMessageToWebAPIbufferSize = null, Expression<Func<sendMessageToWebAPIhTTPRequestHeadersListInputItem[]>> sendMessageToWebAPIhTTPRequestHeadersList = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS10 = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS11 = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS12 = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS13 = null, Expression<Func<bool>> sendMessageToWebAPIkeepAlive = null, Expression<Func<bool>> sendMessageToWebAPIexpect100Continue = null, Expression<Func<bool>> sendMessageToWebAPIreturnResponseHeaders = null, Expression<Func<bool>> sendMessageToWebAPIrunAsThread = null, Expression<Func<bool>> sendMessageToWebAPIwaitForThread = null, Expression<Func<int>> sendMessageToWebAPIretrieveOutputDataFromThreadId = null)
        {
            var __workflow_sendMessageToWebAPIworkflow = WorkflowExpression.Compile(sendMessageToWebAPIworkflow, nameof(sendMessageToWebAPIworkflow), required: true);
            var __workflow_sendMessageToWebAPIuRL = WorkflowExpression.Compile(sendMessageToWebAPIuRL, nameof(sendMessageToWebAPIuRL), required: false);
            var __workflow_sendMessageToWebAPImethod = WorkflowExpression.Compile(sendMessageToWebAPImethod, nameof(sendMessageToWebAPImethod), required: false);
            var __workflow_sendMessageToWebAPItimeoutInSeconds = WorkflowExpression.Compile(sendMessageToWebAPItimeoutInSeconds, nameof(sendMessageToWebAPItimeoutInSeconds), required: false);
            var __workflow_sendMessageToWebAPIcontentType = WorkflowExpression.Compile(sendMessageToWebAPIcontentType, nameof(sendMessageToWebAPIcontentType), required: false);
            var __workflow_sendMessageToWebAPIaccept = WorkflowExpression.Compile(sendMessageToWebAPIaccept, nameof(sendMessageToWebAPIaccept), required: false);
            var __workflow_sendMessageToWebAPImessageBody = WorkflowExpression.Compile(sendMessageToWebAPImessageBody, nameof(sendMessageToWebAPImessageBody), required: false);
            var __workflow_sendMessageToWebAPItransmitEncoding = WorkflowExpression.Compile(sendMessageToWebAPItransmitEncoding, nameof(sendMessageToWebAPItransmitEncoding), required: false);
            var __workflow_sendMessageToWebAPIresponseEncoding = WorkflowExpression.Compile(sendMessageToWebAPIresponseEncoding, nameof(sendMessageToWebAPIresponseEncoding), required: false);
            var __workflow_sendMessageToWebAPIbufferSize = WorkflowExpression.Compile(sendMessageToWebAPIbufferSize, nameof(sendMessageToWebAPIbufferSize), required: false);
            var __workflow_sendMessageToWebAPIhTTPRequestHeadersList = WorkflowExpression.Compile(sendMessageToWebAPIhTTPRequestHeadersList, nameof(sendMessageToWebAPIhTTPRequestHeadersList), required: false);
            var __workflow_sendMessageToWebAPInegotiateTLS10 = WorkflowExpression.Compile(sendMessageToWebAPInegotiateTLS10, nameof(sendMessageToWebAPInegotiateTLS10), required: false);
            var __workflow_sendMessageToWebAPInegotiateTLS11 = WorkflowExpression.Compile(sendMessageToWebAPInegotiateTLS11, nameof(sendMessageToWebAPInegotiateTLS11), required: false);
            var __workflow_sendMessageToWebAPInegotiateTLS12 = WorkflowExpression.Compile(sendMessageToWebAPInegotiateTLS12, nameof(sendMessageToWebAPInegotiateTLS12), required: false);
            var __workflow_sendMessageToWebAPInegotiateTLS13 = WorkflowExpression.Compile(sendMessageToWebAPInegotiateTLS13, nameof(sendMessageToWebAPInegotiateTLS13), required: false);
            var __workflow_sendMessageToWebAPIkeepAlive = WorkflowExpression.Compile(sendMessageToWebAPIkeepAlive, nameof(sendMessageToWebAPIkeepAlive), required: false);
            var __workflow_sendMessageToWebAPIexpect100Continue = WorkflowExpression.Compile(sendMessageToWebAPIexpect100Continue, nameof(sendMessageToWebAPIexpect100Continue), required: false);
            var __workflow_sendMessageToWebAPIreturnResponseHeaders = WorkflowExpression.Compile(sendMessageToWebAPIreturnResponseHeaders, nameof(sendMessageToWebAPIreturnResponseHeaders), required: false);
            var __workflow_sendMessageToWebAPIrunAsThread = WorkflowExpression.Compile(sendMessageToWebAPIrunAsThread, nameof(sendMessageToWebAPIrunAsThread), required: false);
            var __workflow_sendMessageToWebAPIwaitForThread = WorkflowExpression.Compile(sendMessageToWebAPIwaitForThread, nameof(sendMessageToWebAPIwaitForThread), required: false);
            var __workflow_sendMessageToWebAPIretrieveOutputDataFromThreadId = WorkflowExpression.Compile(sendMessageToWebAPIretrieveOutputDataFromThreadId, nameof(sendMessageToWebAPIretrieveOutputDataFromThreadId), required: false);
            return new DeferredBodyAction<SendMessageToWebAPIResponse>(() =>
            {
                var apiCallPath = "/Environment/SendMessageToWebAPI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendMessageToWebAPI = new JObject();
                var sendMessageToWebAPIpropCount = 0;
                if (__workflow_sendMessageToWebAPIuRL != null)
                {
                    sendMessageToWebAPI["URL"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPIuRL);
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPImethod != null)
                {
                    if (__workflow_sendMessageToWebAPImethod != null)
                    {
                        sendMessageToWebAPI["Method"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPImethod);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["Method"] = "GET";
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPItimeoutInSeconds != null)
                {
                    if (__workflow_sendMessageToWebAPItimeoutInSeconds != null)
                    {
                        sendMessageToWebAPI["TimeoutInSeconds"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPItimeoutInSeconds);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["TimeoutInSeconds"] = 20;
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPIcontentType != null)
                {
                    if (__workflow_sendMessageToWebAPIcontentType != null)
                    {
                        sendMessageToWebAPI["ContentType"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPIcontentType);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["ContentType"] = "application/json; charset=utf-8";
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPIaccept != null)
                {
                    if (__workflow_sendMessageToWebAPIaccept != null)
                    {
                        sendMessageToWebAPI["Accept"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPIaccept);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["Accept"] = "application/json";
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPImessageBody != null)
                {
                    sendMessageToWebAPI["MessageBody"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPImessageBody);
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPItransmitEncoding != null)
                {
                    if (__workflow_sendMessageToWebAPItransmitEncoding != null)
                    {
                        sendMessageToWebAPI["TransmitEncoding"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPItransmitEncoding);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["TransmitEncoding"] = "UTF-8";
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPIresponseEncoding != null)
                {
                    if (__workflow_sendMessageToWebAPIresponseEncoding != null)
                    {
                        sendMessageToWebAPI["ResponseEncoding"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPIresponseEncoding);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["ResponseEncoding"] = "UTF-8";
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPIbufferSize != null)
                {
                    if (__workflow_sendMessageToWebAPIbufferSize != null)
                    {
                        sendMessageToWebAPI["BufferSize"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPIbufferSize);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["BufferSize"] = 16384;
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPIhTTPRequestHeadersList != null)
                {
                    sendMessageToWebAPI["HTTPRequestHeadersList"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPIhTTPRequestHeadersList);
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPInegotiateTLS10 != null)
                {
                    if (__workflow_sendMessageToWebAPInegotiateTLS10 != null)
                    {
                        sendMessageToWebAPI["NegotiateTLS10"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPInegotiateTLS10);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["NegotiateTLS10"] = false;
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPInegotiateTLS11 != null)
                {
                    if (__workflow_sendMessageToWebAPInegotiateTLS11 != null)
                    {
                        sendMessageToWebAPI["NegotiateTLS11"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPInegotiateTLS11);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["NegotiateTLS11"] = false;
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPInegotiateTLS12 != null)
                {
                    if (__workflow_sendMessageToWebAPInegotiateTLS12 != null)
                    {
                        sendMessageToWebAPI["NegotiateTLS12"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPInegotiateTLS12);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["NegotiateTLS12"] = true;
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPInegotiateTLS13 != null)
                {
                    if (__workflow_sendMessageToWebAPInegotiateTLS13 != null)
                    {
                        sendMessageToWebAPI["NegotiateTLS13"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPInegotiateTLS13);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["NegotiateTLS13"] = false;
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPIkeepAlive != null)
                {
                    if (__workflow_sendMessageToWebAPIkeepAlive != null)
                    {
                        sendMessageToWebAPI["KeepAlive"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPIkeepAlive);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["KeepAlive"] = true;
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPIexpect100Continue != null)
                {
                    if (__workflow_sendMessageToWebAPIexpect100Continue != null)
                    {
                        sendMessageToWebAPI["Expect100Continue"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPIexpect100Continue);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["Expect100Continue"] = false;
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPIreturnResponseHeaders != null)
                {
                    if (__workflow_sendMessageToWebAPIreturnResponseHeaders != null)
                    {
                        sendMessageToWebAPI["ReturnResponseHeaders"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPIreturnResponseHeaders);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["ReturnResponseHeaders"] = false;
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPIrunAsThread != null)
                {
                    if (__workflow_sendMessageToWebAPIrunAsThread != null)
                    {
                        sendMessageToWebAPI["RunAsThread"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPIrunAsThread);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["RunAsThread"] = true;
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPIwaitForThread != null)
                {
                    if (__workflow_sendMessageToWebAPIwaitForThread != null)
                    {
                        sendMessageToWebAPI["WaitForThread"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPIwaitForThread);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["WaitForThread"] = true;
                    sendMessageToWebAPIpropCount++;
                }

                if (__workflow_sendMessageToWebAPIretrieveOutputDataFromThreadId != null)
                {
                    sendMessageToWebAPI["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPIretrieveOutputDataFromThreadId);
                    sendMessageToWebAPIpropCount++;
                }

                sendMessageToWebAPIpropCount++;
                sendMessageToWebAPI["Workflow"] = ExpressionConverter.ConvertO(__workflow_sendMessageToWebAPIworkflow);
                if (sendMessageToWebAPIpropCount > 0)
                {
                    callPayload.Body = sendMessageToWebAPI;
                }

                return new ApiConnectionAction<SendMessageToWebAPIResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewTaskResponse> TasksAddNewTask(Expression<Func<string>> tasksAddNewTaskworkflow, Expression<Func<tasksAddNewTasksetAutomationNameInput>> tasksAddNewTasksetAutomationName = null, Expression<Func<string>> tasksAddNewTaskautomationName = null, Expression<Func<string>> tasksAddNewTasktaskInputData = null, Expression<Func<string>> tasksAddNewTaskprocessStage = null, Expression<Func<int>> tasksAddNewTaskpriority = null, Expression<Func<int>> tasksAddNewTasksLA = null, Expression<Func<bool>> tasksAddNewTasktaskOnHold = null, Expression<Func<string>> tasksAddNewTaskorganisation = null, Expression<Func<string>> tasksAddNewTaskdepartment = null, Expression<Func<string>> tasksAddNewTaskdescription = null, Expression<Func<string>> tasksAddNewTasktags = null)
        {
            var __workflow_tasksAddNewTaskworkflow = WorkflowExpression.Compile(tasksAddNewTaskworkflow, nameof(tasksAddNewTaskworkflow), required: true);
            var __workflow_tasksAddNewTasksetAutomationName = WorkflowExpression.Compile(tasksAddNewTasksetAutomationName, nameof(tasksAddNewTasksetAutomationName), required: false);
            var __workflow_tasksAddNewTaskautomationName = WorkflowExpression.Compile(tasksAddNewTaskautomationName, nameof(tasksAddNewTaskautomationName), required: false);
            var __workflow_tasksAddNewTasktaskInputData = WorkflowExpression.Compile(tasksAddNewTasktaskInputData, nameof(tasksAddNewTasktaskInputData), required: false);
            var __workflow_tasksAddNewTaskprocessStage = WorkflowExpression.Compile(tasksAddNewTaskprocessStage, nameof(tasksAddNewTaskprocessStage), required: false);
            var __workflow_tasksAddNewTaskpriority = WorkflowExpression.Compile(tasksAddNewTaskpriority, nameof(tasksAddNewTaskpriority), required: false);
            var __workflow_tasksAddNewTasksLA = WorkflowExpression.Compile(tasksAddNewTasksLA, nameof(tasksAddNewTasksLA), required: false);
            var __workflow_tasksAddNewTasktaskOnHold = WorkflowExpression.Compile(tasksAddNewTasktaskOnHold, nameof(tasksAddNewTasktaskOnHold), required: false);
            var __workflow_tasksAddNewTaskorganisation = WorkflowExpression.Compile(tasksAddNewTaskorganisation, nameof(tasksAddNewTaskorganisation), required: false);
            var __workflow_tasksAddNewTaskdepartment = WorkflowExpression.Compile(tasksAddNewTaskdepartment, nameof(tasksAddNewTaskdepartment), required: false);
            var __workflow_tasksAddNewTaskdescription = WorkflowExpression.Compile(tasksAddNewTaskdescription, nameof(tasksAddNewTaskdescription), required: false);
            var __workflow_tasksAddNewTasktags = WorkflowExpression.Compile(tasksAddNewTasktags, nameof(tasksAddNewTasktags), required: false);
            return new DeferredBodyAction<TasksAddNewTaskResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNewTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksAddNewTask = new JObject();
                var tasksAddNewTaskpropCount = 0;
                if (__workflow_tasksAddNewTasksetAutomationName != null)
                {
                    if (__workflow_tasksAddNewTasksetAutomationName != null)
                    {
                        tasksAddNewTask["SetAutomationName"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTasksetAutomationName);
                        tasksAddNewTaskpropCount++;
                    }

                    tasksAddNewTaskpropCount++;
                }
                else
                {
                    tasksAddNewTask["SetAutomationName"] = "Auto";
                    tasksAddNewTaskpropCount++;
                }

                if (__workflow_tasksAddNewTaskautomationName != null)
                {
                    tasksAddNewTask["AutomationName"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskautomationName);
                    tasksAddNewTaskpropCount++;
                }

                if (__workflow_tasksAddNewTasktaskInputData != null)
                {
                    tasksAddNewTask["TaskInputData"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTasktaskInputData);
                    tasksAddNewTaskpropCount++;
                }

                if (__workflow_tasksAddNewTaskprocessStage != null)
                {
                    tasksAddNewTask["ProcessStage"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskprocessStage);
                    tasksAddNewTaskpropCount++;
                }

                if (__workflow_tasksAddNewTaskpriority != null)
                {
                    if (__workflow_tasksAddNewTaskpriority != null)
                    {
                        tasksAddNewTask["Priority"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskpriority);
                        tasksAddNewTaskpropCount++;
                    }

                    tasksAddNewTaskpropCount++;
                }
                else
                {
                    tasksAddNewTask["Priority"] = 3;
                    tasksAddNewTaskpropCount++;
                }

                if (__workflow_tasksAddNewTasksLA != null)
                {
                    tasksAddNewTask["SLA"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTasksLA);
                    tasksAddNewTaskpropCount++;
                }

                if (__workflow_tasksAddNewTasktaskOnHold != null)
                {
                    if (__workflow_tasksAddNewTasktaskOnHold != null)
                    {
                        tasksAddNewTask["TaskOnHold"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTasktaskOnHold);
                        tasksAddNewTaskpropCount++;
                    }

                    tasksAddNewTaskpropCount++;
                }
                else
                {
                    tasksAddNewTask["TaskOnHold"] = false;
                    tasksAddNewTaskpropCount++;
                }

                if (__workflow_tasksAddNewTaskorganisation != null)
                {
                    tasksAddNewTask["Organisation"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskorganisation);
                    tasksAddNewTaskpropCount++;
                }

                if (__workflow_tasksAddNewTaskdepartment != null)
                {
                    tasksAddNewTask["Department"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskdepartment);
                    tasksAddNewTaskpropCount++;
                }

                if (__workflow_tasksAddNewTaskdescription != null)
                {
                    tasksAddNewTask["Description"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskdescription);
                    tasksAddNewTaskpropCount++;
                }

                if (__workflow_tasksAddNewTasktags != null)
                {
                    tasksAddNewTask["Tags"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTasktags);
                    tasksAddNewTaskpropCount++;
                }

                tasksAddNewTaskpropCount++;
                tasksAddNewTask["Workflow"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskworkflow);
                if (tasksAddNewTaskpropCount > 0)
                {
                    callPayload.Body = tasksAddNewTask;
                }

                return new ApiConnectionAction<TasksAddNewTaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewDeferralResponse> TasksAddNewDeferral(Expression<Func<string>> tasksAddNewDeferralworkflow, Expression<Func<tasksAddNewDeferralsetAutomationNameInput>> tasksAddNewDeferralsetAutomationName = null, Expression<Func<string>> tasksAddNewDeferralautomationName = null, Expression<Func<int>> tasksAddNewDeferraldeferralTimeInMinutes = null, Expression<Func<string>> tasksAddNewDeferraltaskInputData = null, Expression<Func<string>> tasksAddNewDeferraldeferralStoredData = null, Expression<Func<string>> tasksAddNewDeferralprocessStage = null, Expression<Func<int>> tasksAddNewDeferralpriority = null, Expression<Func<bool>> tasksAddNewDeferraltaskOnHold = null, Expression<Func<string>> tasksAddNewDeferralorganisation = null, Expression<Func<string>> tasksAddNewDeferraldepartment = null, Expression<Func<string>> tasksAddNewDeferraldescription = null, Expression<Func<string>> tasksAddNewDeferraltags = null)
        {
            var __workflow_tasksAddNewDeferralworkflow = WorkflowExpression.Compile(tasksAddNewDeferralworkflow, nameof(tasksAddNewDeferralworkflow), required: true);
            var __workflow_tasksAddNewDeferralsetAutomationName = WorkflowExpression.Compile(tasksAddNewDeferralsetAutomationName, nameof(tasksAddNewDeferralsetAutomationName), required: false);
            var __workflow_tasksAddNewDeferralautomationName = WorkflowExpression.Compile(tasksAddNewDeferralautomationName, nameof(tasksAddNewDeferralautomationName), required: false);
            var __workflow_tasksAddNewDeferraldeferralTimeInMinutes = WorkflowExpression.Compile(tasksAddNewDeferraldeferralTimeInMinutes, nameof(tasksAddNewDeferraldeferralTimeInMinutes), required: false);
            var __workflow_tasksAddNewDeferraltaskInputData = WorkflowExpression.Compile(tasksAddNewDeferraltaskInputData, nameof(tasksAddNewDeferraltaskInputData), required: false);
            var __workflow_tasksAddNewDeferraldeferralStoredData = WorkflowExpression.Compile(tasksAddNewDeferraldeferralStoredData, nameof(tasksAddNewDeferraldeferralStoredData), required: false);
            var __workflow_tasksAddNewDeferralprocessStage = WorkflowExpression.Compile(tasksAddNewDeferralprocessStage, nameof(tasksAddNewDeferralprocessStage), required: false);
            var __workflow_tasksAddNewDeferralpriority = WorkflowExpression.Compile(tasksAddNewDeferralpriority, nameof(tasksAddNewDeferralpriority), required: false);
            var __workflow_tasksAddNewDeferraltaskOnHold = WorkflowExpression.Compile(tasksAddNewDeferraltaskOnHold, nameof(tasksAddNewDeferraltaskOnHold), required: false);
            var __workflow_tasksAddNewDeferralorganisation = WorkflowExpression.Compile(tasksAddNewDeferralorganisation, nameof(tasksAddNewDeferralorganisation), required: false);
            var __workflow_tasksAddNewDeferraldepartment = WorkflowExpression.Compile(tasksAddNewDeferraldepartment, nameof(tasksAddNewDeferraldepartment), required: false);
            var __workflow_tasksAddNewDeferraldescription = WorkflowExpression.Compile(tasksAddNewDeferraldescription, nameof(tasksAddNewDeferraldescription), required: false);
            var __workflow_tasksAddNewDeferraltags = WorkflowExpression.Compile(tasksAddNewDeferraltags, nameof(tasksAddNewDeferraltags), required: false);
            return new DeferredBodyAction<TasksAddNewDeferralResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNewDeferral";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksAddNewDeferral = new JObject();
                var tasksAddNewDeferralpropCount = 0;
                if (__workflow_tasksAddNewDeferralsetAutomationName != null)
                {
                    if (__workflow_tasksAddNewDeferralsetAutomationName != null)
                    {
                        tasksAddNewDeferral["SetAutomationName"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralsetAutomationName);
                        tasksAddNewDeferralpropCount++;
                    }

                    tasksAddNewDeferralpropCount++;
                }
                else
                {
                    tasksAddNewDeferral["SetAutomationName"] = "Auto";
                    tasksAddNewDeferralpropCount++;
                }

                if (__workflow_tasksAddNewDeferralautomationName != null)
                {
                    tasksAddNewDeferral["AutomationName"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralautomationName);
                    tasksAddNewDeferralpropCount++;
                }

                if (__workflow_tasksAddNewDeferraldeferralTimeInMinutes != null)
                {
                    tasksAddNewDeferral["DeferralTimeInMinutes"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferraldeferralTimeInMinutes);
                    tasksAddNewDeferralpropCount++;
                }

                if (__workflow_tasksAddNewDeferraltaskInputData != null)
                {
                    tasksAddNewDeferral["TaskInputData"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferraltaskInputData);
                    tasksAddNewDeferralpropCount++;
                }

                if (__workflow_tasksAddNewDeferraldeferralStoredData != null)
                {
                    tasksAddNewDeferral["DeferralStoredData"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferraldeferralStoredData);
                    tasksAddNewDeferralpropCount++;
                }

                if (__workflow_tasksAddNewDeferralprocessStage != null)
                {
                    tasksAddNewDeferral["ProcessStage"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralprocessStage);
                    tasksAddNewDeferralpropCount++;
                }

                if (__workflow_tasksAddNewDeferralpriority != null)
                {
                    if (__workflow_tasksAddNewDeferralpriority != null)
                    {
                        tasksAddNewDeferral["Priority"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralpriority);
                        tasksAddNewDeferralpropCount++;
                    }

                    tasksAddNewDeferralpropCount++;
                }
                else
                {
                    tasksAddNewDeferral["Priority"] = 3;
                    tasksAddNewDeferralpropCount++;
                }

                if (__workflow_tasksAddNewDeferraltaskOnHold != null)
                {
                    if (__workflow_tasksAddNewDeferraltaskOnHold != null)
                    {
                        tasksAddNewDeferral["TaskOnHold"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferraltaskOnHold);
                        tasksAddNewDeferralpropCount++;
                    }

                    tasksAddNewDeferralpropCount++;
                }
                else
                {
                    tasksAddNewDeferral["TaskOnHold"] = false;
                    tasksAddNewDeferralpropCount++;
                }

                if (__workflow_tasksAddNewDeferralorganisation != null)
                {
                    tasksAddNewDeferral["Organisation"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralorganisation);
                    tasksAddNewDeferralpropCount++;
                }

                if (__workflow_tasksAddNewDeferraldepartment != null)
                {
                    tasksAddNewDeferral["Department"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferraldepartment);
                    tasksAddNewDeferralpropCount++;
                }

                if (__workflow_tasksAddNewDeferraldescription != null)
                {
                    tasksAddNewDeferral["Description"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferraldescription);
                    tasksAddNewDeferralpropCount++;
                }

                if (__workflow_tasksAddNewDeferraltags != null)
                {
                    tasksAddNewDeferral["Tags"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferraltags);
                    tasksAddNewDeferralpropCount++;
                }

                tasksAddNewDeferralpropCount++;
                tasksAddNewDeferral["Workflow"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralworkflow);
                if (tasksAddNewDeferralpropCount > 0)
                {
                    callPayload.Body = tasksAddNewDeferral;
                }

                return new ApiConnectionAction<TasksAddNewDeferralResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeferExistingTaskResponse> TasksDeferExistingTask(Expression<Func<int>> tasksDeferExistingTasktaskId, Expression<Func<int>> tasksDeferExistingTaskdeferralTimeInMinutes = null, Expression<Func<string>> tasksDeferExistingTaskdeferralStoredData = null, Expression<Func<string>> tasksDeferExistingTaskprocessStage = null, Expression<Func<int>> tasksDeferExistingTaskpriority = null, Expression<Func<bool>> tasksDeferExistingTasktaskOnHold = null)
        {
            var __workflow_tasksDeferExistingTasktaskId = WorkflowExpression.Compile(tasksDeferExistingTasktaskId, nameof(tasksDeferExistingTasktaskId), required: true);
            var __workflow_tasksDeferExistingTaskdeferralTimeInMinutes = WorkflowExpression.Compile(tasksDeferExistingTaskdeferralTimeInMinutes, nameof(tasksDeferExistingTaskdeferralTimeInMinutes), required: false);
            var __workflow_tasksDeferExistingTaskdeferralStoredData = WorkflowExpression.Compile(tasksDeferExistingTaskdeferralStoredData, nameof(tasksDeferExistingTaskdeferralStoredData), required: false);
            var __workflow_tasksDeferExistingTaskprocessStage = WorkflowExpression.Compile(tasksDeferExistingTaskprocessStage, nameof(tasksDeferExistingTaskprocessStage), required: false);
            var __workflow_tasksDeferExistingTaskpriority = WorkflowExpression.Compile(tasksDeferExistingTaskpriority, nameof(tasksDeferExistingTaskpriority), required: false);
            var __workflow_tasksDeferExistingTasktaskOnHold = WorkflowExpression.Compile(tasksDeferExistingTasktaskOnHold, nameof(tasksDeferExistingTasktaskOnHold), required: false);
            return new DeferredBodyAction<TasksDeferExistingTaskResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksDeferExistingTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksDeferExistingTask = new JObject();
                var tasksDeferExistingTaskpropCount = 0;
                tasksDeferExistingTaskpropCount++;
                tasksDeferExistingTask["TaskId"] = ExpressionConverter.ConvertO(__workflow_tasksDeferExistingTasktaskId);
                if (__workflow_tasksDeferExistingTaskdeferralTimeInMinutes != null)
                {
                    tasksDeferExistingTask["DeferralTimeInMinutes"] = ExpressionConverter.ConvertO(__workflow_tasksDeferExistingTaskdeferralTimeInMinutes);
                    tasksDeferExistingTaskpropCount++;
                }

                if (__workflow_tasksDeferExistingTaskdeferralStoredData != null)
                {
                    tasksDeferExistingTask["DeferralStoredData"] = ExpressionConverter.ConvertO(__workflow_tasksDeferExistingTaskdeferralStoredData);
                    tasksDeferExistingTaskpropCount++;
                }

                if (__workflow_tasksDeferExistingTaskprocessStage != null)
                {
                    tasksDeferExistingTask["ProcessStage"] = ExpressionConverter.ConvertO(__workflow_tasksDeferExistingTaskprocessStage);
                    tasksDeferExistingTaskpropCount++;
                }

                if (__workflow_tasksDeferExistingTaskpriority != null)
                {
                    if (__workflow_tasksDeferExistingTaskpriority != null)
                    {
                        tasksDeferExistingTask["Priority"] = ExpressionConverter.ConvertO(__workflow_tasksDeferExistingTaskpriority);
                        tasksDeferExistingTaskpropCount++;
                    }

                    tasksDeferExistingTaskpropCount++;
                }
                else
                {
                    tasksDeferExistingTask["Priority"] = 3;
                    tasksDeferExistingTaskpropCount++;
                }

                if (__workflow_tasksDeferExistingTasktaskOnHold != null)
                {
                    if (__workflow_tasksDeferExistingTasktaskOnHold != null)
                    {
                        tasksDeferExistingTask["TaskOnHold"] = ExpressionConverter.ConvertO(__workflow_tasksDeferExistingTasktaskOnHold);
                        tasksDeferExistingTaskpropCount++;
                    }

                    tasksDeferExistingTaskpropCount++;
                }
                else
                {
                    tasksDeferExistingTask["TaskOnHold"] = false;
                    tasksDeferExistingTaskpropCount++;
                }

                if (tasksDeferExistingTaskpropCount > 0)
                {
                    callPayload.Body = tasksDeferExistingTask;
                }

                return new ApiConnectionAction<TasksDeferExistingTaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeferExistingTaskOperationResponse> TasksDeferExistingTaskOperation(Expression<Func<string>> tasksDeferExistingTaskOperationoperationId, Expression<Func<int>> tasksDeferExistingTaskOperationdeferralTimeInMinutes = null, Expression<Func<string>> tasksDeferExistingTaskOperationdeferralStoredData = null, Expression<Func<string>> tasksDeferExistingTaskOperationprocessStage = null, Expression<Func<int>> tasksDeferExistingTaskOperationpriority = null)
        {
            var __workflow_tasksDeferExistingTaskOperationoperationId = WorkflowExpression.Compile(tasksDeferExistingTaskOperationoperationId, nameof(tasksDeferExistingTaskOperationoperationId), required: true);
            var __workflow_tasksDeferExistingTaskOperationdeferralTimeInMinutes = WorkflowExpression.Compile(tasksDeferExistingTaskOperationdeferralTimeInMinutes, nameof(tasksDeferExistingTaskOperationdeferralTimeInMinutes), required: false);
            var __workflow_tasksDeferExistingTaskOperationdeferralStoredData = WorkflowExpression.Compile(tasksDeferExistingTaskOperationdeferralStoredData, nameof(tasksDeferExistingTaskOperationdeferralStoredData), required: false);
            var __workflow_tasksDeferExistingTaskOperationprocessStage = WorkflowExpression.Compile(tasksDeferExistingTaskOperationprocessStage, nameof(tasksDeferExistingTaskOperationprocessStage), required: false);
            var __workflow_tasksDeferExistingTaskOperationpriority = WorkflowExpression.Compile(tasksDeferExistingTaskOperationpriority, nameof(tasksDeferExistingTaskOperationpriority), required: false);
            return new DeferredBodyAction<TasksDeferExistingTaskOperationResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksDeferExistingTaskOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksDeferExistingTaskOperation = new JObject();
                var tasksDeferExistingTaskOperationpropCount = 0;
                tasksDeferExistingTaskOperationpropCount++;
                tasksDeferExistingTaskOperation["OperationId"] = ExpressionConverter.ConvertO(__workflow_tasksDeferExistingTaskOperationoperationId);
                if (__workflow_tasksDeferExistingTaskOperationdeferralTimeInMinutes != null)
                {
                    tasksDeferExistingTaskOperation["DeferralTimeInMinutes"] = ExpressionConverter.ConvertO(__workflow_tasksDeferExistingTaskOperationdeferralTimeInMinutes);
                    tasksDeferExistingTaskOperationpropCount++;
                }

                if (__workflow_tasksDeferExistingTaskOperationdeferralStoredData != null)
                {
                    tasksDeferExistingTaskOperation["DeferralStoredData"] = ExpressionConverter.ConvertO(__workflow_tasksDeferExistingTaskOperationdeferralStoredData);
                    tasksDeferExistingTaskOperationpropCount++;
                }

                if (__workflow_tasksDeferExistingTaskOperationprocessStage != null)
                {
                    tasksDeferExistingTaskOperation["ProcessStage"] = ExpressionConverter.ConvertO(__workflow_tasksDeferExistingTaskOperationprocessStage);
                    tasksDeferExistingTaskOperationpropCount++;
                }

                if (__workflow_tasksDeferExistingTaskOperationpriority != null)
                {
                    if (__workflow_tasksDeferExistingTaskOperationpriority != null)
                    {
                        tasksDeferExistingTaskOperation["Priority"] = ExpressionConverter.ConvertO(__workflow_tasksDeferExistingTaskOperationpriority);
                        tasksDeferExistingTaskOperationpropCount++;
                    }

                    tasksDeferExistingTaskOperationpropCount++;
                }
                else
                {
                    tasksDeferExistingTaskOperation["Priority"] = 3;
                    tasksDeferExistingTaskOperationpropCount++;
                }

                if (tasksDeferExistingTaskOperationpropCount > 0)
                {
                    callPayload.Body = tasksDeferExistingTaskOperation;
                }

                return new ApiConnectionAction<TasksDeferExistingTaskOperationResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeleteTaskResponse> TasksDeleteTask(Expression<Func<int>> tasksDeleteTasktaskId, Expression<Func<bool>> tasksDeleteTaskupdateSourceSystem = null)
        {
            var __workflow_tasksDeleteTasktaskId = WorkflowExpression.Compile(tasksDeleteTasktaskId, nameof(tasksDeleteTasktaskId), required: true);
            var __workflow_tasksDeleteTaskupdateSourceSystem = WorkflowExpression.Compile(tasksDeleteTaskupdateSourceSystem, nameof(tasksDeleteTaskupdateSourceSystem), required: false);
            return new DeferredBodyAction<TasksDeleteTaskResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksDeleteTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksDeleteTask = new JObject();
                var tasksDeleteTaskpropCount = 0;
                tasksDeleteTaskpropCount++;
                tasksDeleteTask["TaskId"] = ExpressionConverter.ConvertO(__workflow_tasksDeleteTasktaskId);
                if (__workflow_tasksDeleteTaskupdateSourceSystem != null)
                {
                    if (__workflow_tasksDeleteTaskupdateSourceSystem != null)
                    {
                        tasksDeleteTask["UpdateSourceSystem"] = ExpressionConverter.ConvertO(__workflow_tasksDeleteTaskupdateSourceSystem);
                        tasksDeleteTaskpropCount++;
                    }

                    tasksDeleteTaskpropCount++;
                }
                else
                {
                    tasksDeleteTask["UpdateSourceSystem"] = true;
                    tasksDeleteTaskpropCount++;
                }

                if (tasksDeleteTaskpropCount > 0)
                {
                    callPayload.Body = tasksDeleteTask;
                }

                return new ApiConnectionAction<TasksDeleteTaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeleteTaskOperationResponse> TasksDeleteTaskOperation(Expression<Func<string>> tasksDeleteTaskOperationoperationId, Expression<Func<bool>> tasksDeleteTaskOperationupdateSourceSystem = null)
        {
            var __workflow_tasksDeleteTaskOperationoperationId = WorkflowExpression.Compile(tasksDeleteTaskOperationoperationId, nameof(tasksDeleteTaskOperationoperationId), required: true);
            var __workflow_tasksDeleteTaskOperationupdateSourceSystem = WorkflowExpression.Compile(tasksDeleteTaskOperationupdateSourceSystem, nameof(tasksDeleteTaskOperationupdateSourceSystem), required: false);
            return new DeferredBodyAction<TasksDeleteTaskOperationResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksDeleteTaskOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksDeleteTaskOperation = new JObject();
                var tasksDeleteTaskOperationpropCount = 0;
                tasksDeleteTaskOperationpropCount++;
                tasksDeleteTaskOperation["OperationId"] = ExpressionConverter.ConvertO(__workflow_tasksDeleteTaskOperationoperationId);
                if (__workflow_tasksDeleteTaskOperationupdateSourceSystem != null)
                {
                    if (__workflow_tasksDeleteTaskOperationupdateSourceSystem != null)
                    {
                        tasksDeleteTaskOperation["UpdateSourceSystem"] = ExpressionConverter.ConvertO(__workflow_tasksDeleteTaskOperationupdateSourceSystem);
                        tasksDeleteTaskOperationpropCount++;
                    }

                    tasksDeleteTaskOperationpropCount++;
                }
                else
                {
                    tasksDeleteTaskOperation["UpdateSourceSystem"] = true;
                    tasksDeleteTaskOperationpropCount++;
                }

                if (tasksDeleteTaskOperationpropCount > 0)
                {
                    callPayload.Body = tasksDeleteTaskOperation;
                }

                return new ApiConnectionAction<TasksDeleteTaskOperationResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetAllTasksResponse> TasksGetAllTasks(Expression<Func<string>> tasksGetAllTasksautomationName = null, Expression<Func<tasksGetAllTasksautomationTaskStatusInput>> tasksGetAllTasksautomationTaskStatus = null, Expression<Func<string>> tasksGetAllTasksfilterByPropertyQuery = null, Expression<Func<int>> tasksGetAllTasksminutesUntilDeferralDate = null, Expression<Func<int>> tasksGetAllTasksminimumPriorityLevel = null, Expression<Func<bool>> tasksGetAllTaskssortByDeferralDate = null, Expression<Func<bool>> tasksGetAllTasksretrieveOnHoldTasks = null, Expression<Func<int>> tasksGetAllTasksskip = null, Expression<Func<int>> tasksGetAllTasksmaxResults = null, Expression<Func<bool>> tasksGetAllTasksexcludeTaskData = null)
        {
            var __workflow_tasksGetAllTasksautomationName = WorkflowExpression.Compile(tasksGetAllTasksautomationName, nameof(tasksGetAllTasksautomationName), required: false);
            var __workflow_tasksGetAllTasksautomationTaskStatus = WorkflowExpression.Compile(tasksGetAllTasksautomationTaskStatus, nameof(tasksGetAllTasksautomationTaskStatus), required: false);
            var __workflow_tasksGetAllTasksfilterByPropertyQuery = WorkflowExpression.Compile(tasksGetAllTasksfilterByPropertyQuery, nameof(tasksGetAllTasksfilterByPropertyQuery), required: false);
            var __workflow_tasksGetAllTasksminutesUntilDeferralDate = WorkflowExpression.Compile(tasksGetAllTasksminutesUntilDeferralDate, nameof(tasksGetAllTasksminutesUntilDeferralDate), required: false);
            var __workflow_tasksGetAllTasksminimumPriorityLevel = WorkflowExpression.Compile(tasksGetAllTasksminimumPriorityLevel, nameof(tasksGetAllTasksminimumPriorityLevel), required: false);
            var __workflow_tasksGetAllTaskssortByDeferralDate = WorkflowExpression.Compile(tasksGetAllTaskssortByDeferralDate, nameof(tasksGetAllTaskssortByDeferralDate), required: false);
            var __workflow_tasksGetAllTasksretrieveOnHoldTasks = WorkflowExpression.Compile(tasksGetAllTasksretrieveOnHoldTasks, nameof(tasksGetAllTasksretrieveOnHoldTasks), required: false);
            var __workflow_tasksGetAllTasksskip = WorkflowExpression.Compile(tasksGetAllTasksskip, nameof(tasksGetAllTasksskip), required: false);
            var __workflow_tasksGetAllTasksmaxResults = WorkflowExpression.Compile(tasksGetAllTasksmaxResults, nameof(tasksGetAllTasksmaxResults), required: false);
            var __workflow_tasksGetAllTasksexcludeTaskData = WorkflowExpression.Compile(tasksGetAllTasksexcludeTaskData, nameof(tasksGetAllTasksexcludeTaskData), required: false);
            return new DeferredBodyAction<TasksGetAllTasksResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksGetAllTasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksGetAllTasks = new JObject();
                var tasksGetAllTaskspropCount = 0;
                if (__workflow_tasksGetAllTasksautomationName != null)
                {
                    tasksGetAllTasks["AutomationName"] = ExpressionConverter.ConvertO(__workflow_tasksGetAllTasksautomationName);
                    tasksGetAllTaskspropCount++;
                }

                if (__workflow_tasksGetAllTasksautomationTaskStatus != null)
                {
                    tasksGetAllTasks["AutomationTaskStatus"] = ExpressionConverter.ConvertO(__workflow_tasksGetAllTasksautomationTaskStatus);
                    tasksGetAllTaskspropCount++;
                }

                if (__workflow_tasksGetAllTasksfilterByPropertyQuery != null)
                {
                    tasksGetAllTasks["FilterByPropertyQuery"] = ExpressionConverter.ConvertO(__workflow_tasksGetAllTasksfilterByPropertyQuery);
                    tasksGetAllTaskspropCount++;
                }

                if (__workflow_tasksGetAllTasksminutesUntilDeferralDate != null)
                {
                    tasksGetAllTasks["MinutesUntilDeferralDate"] = ExpressionConverter.ConvertO(__workflow_tasksGetAllTasksminutesUntilDeferralDate);
                    tasksGetAllTaskspropCount++;
                }

                if (__workflow_tasksGetAllTasksminimumPriorityLevel != null)
                {
                    tasksGetAllTasks["MinimumPriorityLevel"] = ExpressionConverter.ConvertO(__workflow_tasksGetAllTasksminimumPriorityLevel);
                    tasksGetAllTaskspropCount++;
                }

                if (__workflow_tasksGetAllTaskssortByDeferralDate != null)
                {
                    if (__workflow_tasksGetAllTaskssortByDeferralDate != null)
                    {
                        tasksGetAllTasks["SortByDeferralDate"] = ExpressionConverter.ConvertO(__workflow_tasksGetAllTaskssortByDeferralDate);
                        tasksGetAllTaskspropCount++;
                    }

                    tasksGetAllTaskspropCount++;
                }
                else
                {
                    tasksGetAllTasks["SortByDeferralDate"] = false;
                    tasksGetAllTaskspropCount++;
                }

                if (__workflow_tasksGetAllTasksretrieveOnHoldTasks != null)
                {
                    if (__workflow_tasksGetAllTasksretrieveOnHoldTasks != null)
                    {
                        tasksGetAllTasks["RetrieveOnHoldTasks"] = ExpressionConverter.ConvertO(__workflow_tasksGetAllTasksretrieveOnHoldTasks);
                        tasksGetAllTaskspropCount++;
                    }

                    tasksGetAllTaskspropCount++;
                }
                else
                {
                    tasksGetAllTasks["RetrieveOnHoldTasks"] = true;
                    tasksGetAllTaskspropCount++;
                }

                if (__workflow_tasksGetAllTasksskip != null)
                {
                    if (__workflow_tasksGetAllTasksskip != null)
                    {
                        tasksGetAllTasks["Skip"] = ExpressionConverter.ConvertO(__workflow_tasksGetAllTasksskip);
                        tasksGetAllTaskspropCount++;
                    }

                    tasksGetAllTaskspropCount++;
                }
                else
                {
                    tasksGetAllTasks["Skip"] = 0;
                    tasksGetAllTaskspropCount++;
                }

                if (__workflow_tasksGetAllTasksmaxResults != null)
                {
                    if (__workflow_tasksGetAllTasksmaxResults != null)
                    {
                        tasksGetAllTasks["MaxResults"] = ExpressionConverter.ConvertO(__workflow_tasksGetAllTasksmaxResults);
                        tasksGetAllTaskspropCount++;
                    }

                    tasksGetAllTaskspropCount++;
                }
                else
                {
                    tasksGetAllTasks["MaxResults"] = 0;
                    tasksGetAllTaskspropCount++;
                }

                if (__workflow_tasksGetAllTasksexcludeTaskData != null)
                {
                    if (__workflow_tasksGetAllTasksexcludeTaskData != null)
                    {
                        tasksGetAllTasks["ExcludeTaskData"] = ExpressionConverter.ConvertO(__workflow_tasksGetAllTasksexcludeTaskData);
                        tasksGetAllTaskspropCount++;
                    }

                    tasksGetAllTaskspropCount++;
                }
                else
                {
                    tasksGetAllTasks["ExcludeTaskData"] = false;
                    tasksGetAllTaskspropCount++;
                }

                if (tasksGetAllTaskspropCount > 0)
                {
                    callPayload.Body = tasksGetAllTasks;
                }

                return new ApiConnectionAction<TasksGetAllTasksResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetTaskResponse> TasksGetTask(Expression<Func<int>> tasksGetTasktaskId, Expression<Func<tasksGetTaskstatusChangeInput>> tasksGetTaskstatusChange = null)
        {
            var __workflow_tasksGetTasktaskId = WorkflowExpression.Compile(tasksGetTasktaskId, nameof(tasksGetTasktaskId), required: true);
            var __workflow_tasksGetTaskstatusChange = WorkflowExpression.Compile(tasksGetTaskstatusChange, nameof(tasksGetTaskstatusChange), required: false);
            return new DeferredBodyAction<TasksGetTaskResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksGetTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksGetTask = new JObject();
                var tasksGetTaskpropCount = 0;
                tasksGetTaskpropCount++;
                tasksGetTask["TaskId"] = ExpressionConverter.ConvertO(__workflow_tasksGetTasktaskId);
                if (__workflow_tasksGetTaskstatusChange != null)
                {
                    if (__workflow_tasksGetTaskstatusChange != null)
                    {
                        tasksGetTask["StatusChange"] = ExpressionConverter.ConvertO(__workflow_tasksGetTaskstatusChange);
                        tasksGetTaskpropCount++;
                    }

                    tasksGetTaskpropCount++;
                }
                else
                {
                    tasksGetTask["StatusChange"] = "Retrieved";
                    tasksGetTaskpropCount++;
                }

                if (tasksGetTaskpropCount > 0)
                {
                    callPayload.Body = tasksGetTask;
                }

                return new ApiConnectionAction<TasksGetTaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetNextTaskResponse> TasksGetNextTask(Expression<Func<string>> tasksGetNextTaskautomationName = null, Expression<Func<string[]>> tasksGetNextTaskautomationNames = null, Expression<Func<int>> tasksGetNextTaskminimumPriorityLevel = null, Expression<Func<tasksGetNextTaskstatusChangeInput>> tasksGetNextTaskstatusChange = null, Expression<Func<int>> tasksGetNextTaskminutesUntilDeferralDate = null, Expression<Func<bool>> tasksGetNextTaskignoreSLA = null, Expression<Func<int[]>> tasksGetNextTaskexcludeTaskIds = null)
        {
            var __workflow_tasksGetNextTaskautomationName = WorkflowExpression.Compile(tasksGetNextTaskautomationName, nameof(tasksGetNextTaskautomationName), required: false);
            var __workflow_tasksGetNextTaskautomationNames = WorkflowExpression.Compile(tasksGetNextTaskautomationNames, nameof(tasksGetNextTaskautomationNames), required: false);
            var __workflow_tasksGetNextTaskminimumPriorityLevel = WorkflowExpression.Compile(tasksGetNextTaskminimumPriorityLevel, nameof(tasksGetNextTaskminimumPriorityLevel), required: false);
            var __workflow_tasksGetNextTaskstatusChange = WorkflowExpression.Compile(tasksGetNextTaskstatusChange, nameof(tasksGetNextTaskstatusChange), required: false);
            var __workflow_tasksGetNextTaskminutesUntilDeferralDate = WorkflowExpression.Compile(tasksGetNextTaskminutesUntilDeferralDate, nameof(tasksGetNextTaskminutesUntilDeferralDate), required: false);
            var __workflow_tasksGetNextTaskignoreSLA = WorkflowExpression.Compile(tasksGetNextTaskignoreSLA, nameof(tasksGetNextTaskignoreSLA), required: false);
            var __workflow_tasksGetNextTaskexcludeTaskIds = WorkflowExpression.Compile(tasksGetNextTaskexcludeTaskIds, nameof(tasksGetNextTaskexcludeTaskIds), required: false);
            return new DeferredBodyAction<TasksGetNextTaskResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksGetNextTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksGetNextTask = new JObject();
                var tasksGetNextTaskpropCount = 0;
                if (__workflow_tasksGetNextTaskautomationName != null)
                {
                    tasksGetNextTask["AutomationName"] = ExpressionConverter.ConvertO(__workflow_tasksGetNextTaskautomationName);
                    tasksGetNextTaskpropCount++;
                }

                if (__workflow_tasksGetNextTaskautomationNames != null)
                {
                    tasksGetNextTask["AutomationNames"] = ExpressionConverter.ConvertO(__workflow_tasksGetNextTaskautomationNames);
                    tasksGetNextTaskpropCount++;
                }

                if (__workflow_tasksGetNextTaskminimumPriorityLevel != null)
                {
                    tasksGetNextTask["MinimumPriorityLevel"] = ExpressionConverter.ConvertO(__workflow_tasksGetNextTaskminimumPriorityLevel);
                    tasksGetNextTaskpropCount++;
                }

                if (__workflow_tasksGetNextTaskstatusChange != null)
                {
                    if (__workflow_tasksGetNextTaskstatusChange != null)
                    {
                        tasksGetNextTask["StatusChange"] = ExpressionConverter.ConvertO(__workflow_tasksGetNextTaskstatusChange);
                        tasksGetNextTaskpropCount++;
                    }

                    tasksGetNextTaskpropCount++;
                }
                else
                {
                    tasksGetNextTask["StatusChange"] = "Retrieved";
                    tasksGetNextTaskpropCount++;
                }

                if (__workflow_tasksGetNextTaskminutesUntilDeferralDate != null)
                {
                    if (__workflow_tasksGetNextTaskminutesUntilDeferralDate != null)
                    {
                        tasksGetNextTask["MinutesUntilDeferralDate"] = ExpressionConverter.ConvertO(__workflow_tasksGetNextTaskminutesUntilDeferralDate);
                        tasksGetNextTaskpropCount++;
                    }

                    tasksGetNextTaskpropCount++;
                }
                else
                {
                    tasksGetNextTask["MinutesUntilDeferralDate"] = 0;
                    tasksGetNextTaskpropCount++;
                }

                if (__workflow_tasksGetNextTaskignoreSLA != null)
                {
                    if (__workflow_tasksGetNextTaskignoreSLA != null)
                    {
                        tasksGetNextTask["IgnoreSLA"] = ExpressionConverter.ConvertO(__workflow_tasksGetNextTaskignoreSLA);
                        tasksGetNextTaskpropCount++;
                    }

                    tasksGetNextTaskpropCount++;
                }
                else
                {
                    tasksGetNextTask["IgnoreSLA"] = false;
                    tasksGetNextTaskpropCount++;
                }

                if (__workflow_tasksGetNextTaskexcludeTaskIds != null)
                {
                    tasksGetNextTask["ExcludeTaskIds"] = ExpressionConverter.ConvertO(__workflow_tasksGetNextTaskexcludeTaskIds);
                    tasksGetNextTaskpropCount++;
                }

                if (tasksGetNextTaskpropCount > 0)
                {
                    callPayload.Body = tasksGetNextTask;
                }

                return new ApiConnectionAction<TasksGetNextTaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksChangeTaskStatusResponse> TasksChangeTaskStatus(Expression<Func<int>> tasksChangeTaskStatustaskId, Expression<Func<tasksChangeTaskStatusautomationTaskStatusInput>> tasksChangeTaskStatusautomationTaskStatus = null, Expression<Func<bool>> tasksChangeTaskStatustaskOnHold = null, Expression<Func<bool>> tasksChangeTaskStatuseraseTaskInputData = null, Expression<Func<bool>> tasksChangeTaskStatuseraseDeferralStoredData = null, Expression<Func<bool>> tasksChangeTaskStatusupdateSourceSystem = null, Expression<Func<string>> tasksChangeTaskStatustaskClosureReason = null)
        {
            var __workflow_tasksChangeTaskStatustaskId = WorkflowExpression.Compile(tasksChangeTaskStatustaskId, nameof(tasksChangeTaskStatustaskId), required: true);
            var __workflow_tasksChangeTaskStatusautomationTaskStatus = WorkflowExpression.Compile(tasksChangeTaskStatusautomationTaskStatus, nameof(tasksChangeTaskStatusautomationTaskStatus), required: false);
            var __workflow_tasksChangeTaskStatustaskOnHold = WorkflowExpression.Compile(tasksChangeTaskStatustaskOnHold, nameof(tasksChangeTaskStatustaskOnHold), required: false);
            var __workflow_tasksChangeTaskStatuseraseTaskInputData = WorkflowExpression.Compile(tasksChangeTaskStatuseraseTaskInputData, nameof(tasksChangeTaskStatuseraseTaskInputData), required: false);
            var __workflow_tasksChangeTaskStatuseraseDeferralStoredData = WorkflowExpression.Compile(tasksChangeTaskStatuseraseDeferralStoredData, nameof(tasksChangeTaskStatuseraseDeferralStoredData), required: false);
            var __workflow_tasksChangeTaskStatusupdateSourceSystem = WorkflowExpression.Compile(tasksChangeTaskStatusupdateSourceSystem, nameof(tasksChangeTaskStatusupdateSourceSystem), required: false);
            var __workflow_tasksChangeTaskStatustaskClosureReason = WorkflowExpression.Compile(tasksChangeTaskStatustaskClosureReason, nameof(tasksChangeTaskStatustaskClosureReason), required: false);
            return new DeferredBodyAction<TasksChangeTaskStatusResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksChangeTaskStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksChangeTaskStatus = new JObject();
                var tasksChangeTaskStatuspropCount = 0;
                tasksChangeTaskStatuspropCount++;
                tasksChangeTaskStatus["TaskId"] = ExpressionConverter.ConvertO(__workflow_tasksChangeTaskStatustaskId);
                if (__workflow_tasksChangeTaskStatusautomationTaskStatus != null)
                {
                    tasksChangeTaskStatus["AutomationTaskStatus"] = ExpressionConverter.ConvertO(__workflow_tasksChangeTaskStatusautomationTaskStatus);
                    tasksChangeTaskStatuspropCount++;
                }

                if (__workflow_tasksChangeTaskStatustaskOnHold != null)
                {
                    if (__workflow_tasksChangeTaskStatustaskOnHold != null)
                    {
                        tasksChangeTaskStatus["TaskOnHold"] = ExpressionConverter.ConvertO(__workflow_tasksChangeTaskStatustaskOnHold);
                        tasksChangeTaskStatuspropCount++;
                    }

                    tasksChangeTaskStatuspropCount++;
                }
                else
                {
                    tasksChangeTaskStatus["TaskOnHold"] = false;
                    tasksChangeTaskStatuspropCount++;
                }

                if (__workflow_tasksChangeTaskStatuseraseTaskInputData != null)
                {
                    if (__workflow_tasksChangeTaskStatuseraseTaskInputData != null)
                    {
                        tasksChangeTaskStatus["EraseTaskInputData"] = ExpressionConverter.ConvertO(__workflow_tasksChangeTaskStatuseraseTaskInputData);
                        tasksChangeTaskStatuspropCount++;
                    }

                    tasksChangeTaskStatuspropCount++;
                }
                else
                {
                    tasksChangeTaskStatus["EraseTaskInputData"] = true;
                    tasksChangeTaskStatuspropCount++;
                }

                if (__workflow_tasksChangeTaskStatuseraseDeferralStoredData != null)
                {
                    if (__workflow_tasksChangeTaskStatuseraseDeferralStoredData != null)
                    {
                        tasksChangeTaskStatus["EraseDeferralStoredData"] = ExpressionConverter.ConvertO(__workflow_tasksChangeTaskStatuseraseDeferralStoredData);
                        tasksChangeTaskStatuspropCount++;
                    }

                    tasksChangeTaskStatuspropCount++;
                }
                else
                {
                    tasksChangeTaskStatus["EraseDeferralStoredData"] = true;
                    tasksChangeTaskStatuspropCount++;
                }

                if (__workflow_tasksChangeTaskStatusupdateSourceSystem != null)
                {
                    if (__workflow_tasksChangeTaskStatusupdateSourceSystem != null)
                    {
                        tasksChangeTaskStatus["UpdateSourceSystem"] = ExpressionConverter.ConvertO(__workflow_tasksChangeTaskStatusupdateSourceSystem);
                        tasksChangeTaskStatuspropCount++;
                    }

                    tasksChangeTaskStatuspropCount++;
                }
                else
                {
                    tasksChangeTaskStatus["UpdateSourceSystem"] = true;
                    tasksChangeTaskStatuspropCount++;
                }

                if (__workflow_tasksChangeTaskStatustaskClosureReason != null)
                {
                    tasksChangeTaskStatus["TaskClosureReason"] = ExpressionConverter.ConvertO(__workflow_tasksChangeTaskStatustaskClosureReason);
                    tasksChangeTaskStatuspropCount++;
                }

                if (tasksChangeTaskStatuspropCount > 0)
                {
                    callPayload.Body = tasksChangeTaskStatus;
                }

                return new ApiConnectionAction<TasksChangeTaskStatusResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNoteResponse> TasksAddNote(Expression<Func<int>> tasksAddNotetaskId, Expression<Func<string>> tasksAddNotenoteText, Expression<Func<tasksAddNotenoteTypeInput>> tasksAddNotenoteType = null, Expression<Func<string>> tasksAddNotenoteTypeOther = null)
        {
            var __workflow_tasksAddNotetaskId = WorkflowExpression.Compile(tasksAddNotetaskId, nameof(tasksAddNotetaskId), required: true);
            var __workflow_tasksAddNotenoteText = WorkflowExpression.Compile(tasksAddNotenoteText, nameof(tasksAddNotenoteText), required: true);
            var __workflow_tasksAddNotenoteType = WorkflowExpression.Compile(tasksAddNotenoteType, nameof(tasksAddNotenoteType), required: false);
            var __workflow_tasksAddNotenoteTypeOther = WorkflowExpression.Compile(tasksAddNotenoteTypeOther, nameof(tasksAddNotenoteTypeOther), required: false);
            return new DeferredBodyAction<TasksAddNoteResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNote";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksAddNote = new JObject();
                var tasksAddNotepropCount = 0;
                tasksAddNotepropCount++;
                tasksAddNote["TaskId"] = ExpressionConverter.ConvertO(__workflow_tasksAddNotetaskId);
                tasksAddNotepropCount++;
                tasksAddNote["NoteText"] = ExpressionConverter.ConvertO(__workflow_tasksAddNotenoteText);
                if (__workflow_tasksAddNotenoteType != null)
                {
                    if (__workflow_tasksAddNotenoteType != null)
                    {
                        tasksAddNote["NoteType"] = ExpressionConverter.ConvertO(__workflow_tasksAddNotenoteType);
                        tasksAddNotepropCount++;
                    }

                    tasksAddNotepropCount++;
                }
                else
                {
                    tasksAddNote["NoteType"] = "WorkNote";
                    tasksAddNotepropCount++;
                }

                if (__workflow_tasksAddNotenoteTypeOther != null)
                {
                    tasksAddNote["NoteTypeOther"] = ExpressionConverter.ConvertO(__workflow_tasksAddNotenoteTypeOther);
                    tasksAddNotepropCount++;
                }

                if (tasksAddNotepropCount > 0)
                {
                    callPayload.Body = tasksAddNote;
                }

                return new ApiConnectionAction<TasksAddNoteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAssignTaskResponse> TasksAssignTask(Expression<Func<int>> tasksAssignTasktaskId, Expression<Func<string>> tasksAssignTaskassignToUserId = null, Expression<Func<string>> tasksAssignTaskassignToUserName = null, Expression<Func<string>> tasksAssignTaskassignToGroupId = null, Expression<Func<string>> tasksAssignTaskassignToGroupName = null, Expression<Func<bool>> tasksAssignTaskremoveUserAssignmentIfBlank = null, Expression<Func<bool>> tasksAssignTaskremoveGroupAssignmentIfBlank = null)
        {
            var __workflow_tasksAssignTasktaskId = WorkflowExpression.Compile(tasksAssignTasktaskId, nameof(tasksAssignTasktaskId), required: true);
            var __workflow_tasksAssignTaskassignToUserId = WorkflowExpression.Compile(tasksAssignTaskassignToUserId, nameof(tasksAssignTaskassignToUserId), required: false);
            var __workflow_tasksAssignTaskassignToUserName = WorkflowExpression.Compile(tasksAssignTaskassignToUserName, nameof(tasksAssignTaskassignToUserName), required: false);
            var __workflow_tasksAssignTaskassignToGroupId = WorkflowExpression.Compile(tasksAssignTaskassignToGroupId, nameof(tasksAssignTaskassignToGroupId), required: false);
            var __workflow_tasksAssignTaskassignToGroupName = WorkflowExpression.Compile(tasksAssignTaskassignToGroupName, nameof(tasksAssignTaskassignToGroupName), required: false);
            var __workflow_tasksAssignTaskremoveUserAssignmentIfBlank = WorkflowExpression.Compile(tasksAssignTaskremoveUserAssignmentIfBlank, nameof(tasksAssignTaskremoveUserAssignmentIfBlank), required: false);
            var __workflow_tasksAssignTaskremoveGroupAssignmentIfBlank = WorkflowExpression.Compile(tasksAssignTaskremoveGroupAssignmentIfBlank, nameof(tasksAssignTaskremoveGroupAssignmentIfBlank), required: false);
            return new DeferredBodyAction<TasksAssignTaskResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksAssignTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksAssignTask = new JObject();
                var tasksAssignTaskpropCount = 0;
                tasksAssignTaskpropCount++;
                tasksAssignTask["TaskId"] = ExpressionConverter.ConvertO(__workflow_tasksAssignTasktaskId);
                if (__workflow_tasksAssignTaskassignToUserId != null)
                {
                    tasksAssignTask["AssignToUserId"] = ExpressionConverter.ConvertO(__workflow_tasksAssignTaskassignToUserId);
                    tasksAssignTaskpropCount++;
                }

                if (__workflow_tasksAssignTaskassignToUserName != null)
                {
                    tasksAssignTask["AssignToUserName"] = ExpressionConverter.ConvertO(__workflow_tasksAssignTaskassignToUserName);
                    tasksAssignTaskpropCount++;
                }

                if (__workflow_tasksAssignTaskassignToGroupId != null)
                {
                    tasksAssignTask["AssignToGroupId"] = ExpressionConverter.ConvertO(__workflow_tasksAssignTaskassignToGroupId);
                    tasksAssignTaskpropCount++;
                }

                if (__workflow_tasksAssignTaskassignToGroupName != null)
                {
                    tasksAssignTask["AssignToGroupName"] = ExpressionConverter.ConvertO(__workflow_tasksAssignTaskassignToGroupName);
                    tasksAssignTaskpropCount++;
                }

                if (__workflow_tasksAssignTaskremoveUserAssignmentIfBlank != null)
                {
                    if (__workflow_tasksAssignTaskremoveUserAssignmentIfBlank != null)
                    {
                        tasksAssignTask["RemoveUserAssignmentIfBlank"] = ExpressionConverter.ConvertO(__workflow_tasksAssignTaskremoveUserAssignmentIfBlank);
                        tasksAssignTaskpropCount++;
                    }

                    tasksAssignTaskpropCount++;
                }
                else
                {
                    tasksAssignTask["RemoveUserAssignmentIfBlank"] = true;
                    tasksAssignTaskpropCount++;
                }

                if (__workflow_tasksAssignTaskremoveGroupAssignmentIfBlank != null)
                {
                    if (__workflow_tasksAssignTaskremoveGroupAssignmentIfBlank != null)
                    {
                        tasksAssignTask["RemoveGroupAssignmentIfBlank"] = ExpressionConverter.ConvertO(__workflow_tasksAssignTaskremoveGroupAssignmentIfBlank);
                        tasksAssignTaskpropCount++;
                    }

                    tasksAssignTaskpropCount++;
                }
                else
                {
                    tasksAssignTask["RemoveGroupAssignmentIfBlank"] = true;
                    tasksAssignTaskpropCount++;
                }

                if (tasksAssignTaskpropCount > 0)
                {
                    callPayload.Body = tasksAssignTask;
                }

                return new ApiConnectionAction<TasksAssignTaskResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksSetOutputDataResponse> TasksSetOutputData(Expression<Func<int>> tasksSetOutputDatataskId, Expression<Func<string>> tasksSetOutputDatataskOutputData = null)
        {
            var __workflow_tasksSetOutputDatataskId = WorkflowExpression.Compile(tasksSetOutputDatataskId, nameof(tasksSetOutputDatataskId), required: true);
            var __workflow_tasksSetOutputDatataskOutputData = WorkflowExpression.Compile(tasksSetOutputDatataskOutputData, nameof(tasksSetOutputDatataskOutputData), required: false);
            return new DeferredBodyAction<TasksSetOutputDataResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksSetOutputData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksSetOutputData = new JObject();
                var tasksSetOutputDatapropCount = 0;
                tasksSetOutputDatapropCount++;
                tasksSetOutputData["TaskId"] = ExpressionConverter.ConvertO(__workflow_tasksSetOutputDatataskId);
                if (__workflow_tasksSetOutputDatataskOutputData != null)
                {
                    tasksSetOutputData["TaskOutputData"] = ExpressionConverter.ConvertO(__workflow_tasksSetOutputDatataskOutputData);
                    tasksSetOutputDatapropCount++;
                }

                if (tasksSetOutputDatapropCount > 0)
                {
                    callPayload.Body = tasksSetOutputData;
                }

                return new ApiConnectionAction<TasksSetOutputDataResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewTaskOperationResponse> TasksAddNewTaskOperation(Expression<Func<string>> tasksAddNewTaskOperationautomationName = null, Expression<Func<string>> tasksAddNewTaskOperationtaskInputData = null, Expression<Func<string>> tasksAddNewTaskOperationprocessStage = null, Expression<Func<int>> tasksAddNewTaskOperationpriority = null, Expression<Func<int>> tasksAddNewTaskOperationsLA = null, Expression<Func<string>> tasksAddNewTaskOperationorganisation = null, Expression<Func<string>> tasksAddNewTaskOperationdepartment = null, Expression<Func<string>> tasksAddNewTaskOperationdescription = null, Expression<Func<string>> tasksAddNewTaskOperationtags = null)
        {
            var __workflow_tasksAddNewTaskOperationautomationName = WorkflowExpression.Compile(tasksAddNewTaskOperationautomationName, nameof(tasksAddNewTaskOperationautomationName), required: false);
            var __workflow_tasksAddNewTaskOperationtaskInputData = WorkflowExpression.Compile(tasksAddNewTaskOperationtaskInputData, nameof(tasksAddNewTaskOperationtaskInputData), required: false);
            var __workflow_tasksAddNewTaskOperationprocessStage = WorkflowExpression.Compile(tasksAddNewTaskOperationprocessStage, nameof(tasksAddNewTaskOperationprocessStage), required: false);
            var __workflow_tasksAddNewTaskOperationpriority = WorkflowExpression.Compile(tasksAddNewTaskOperationpriority, nameof(tasksAddNewTaskOperationpriority), required: false);
            var __workflow_tasksAddNewTaskOperationsLA = WorkflowExpression.Compile(tasksAddNewTaskOperationsLA, nameof(tasksAddNewTaskOperationsLA), required: false);
            var __workflow_tasksAddNewTaskOperationorganisation = WorkflowExpression.Compile(tasksAddNewTaskOperationorganisation, nameof(tasksAddNewTaskOperationorganisation), required: false);
            var __workflow_tasksAddNewTaskOperationdepartment = WorkflowExpression.Compile(tasksAddNewTaskOperationdepartment, nameof(tasksAddNewTaskOperationdepartment), required: false);
            var __workflow_tasksAddNewTaskOperationdescription = WorkflowExpression.Compile(tasksAddNewTaskOperationdescription, nameof(tasksAddNewTaskOperationdescription), required: false);
            var __workflow_tasksAddNewTaskOperationtags = WorkflowExpression.Compile(tasksAddNewTaskOperationtags, nameof(tasksAddNewTaskOperationtags), required: false);
            return new DeferredBodyAction<TasksAddNewTaskOperationResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNewTaskOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksAddNewTaskOperation = new JObject();
                var tasksAddNewTaskOperationpropCount = 0;
                if (__workflow_tasksAddNewTaskOperationautomationName != null)
                {
                    tasksAddNewTaskOperation["AutomationName"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskOperationautomationName);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (__workflow_tasksAddNewTaskOperationtaskInputData != null)
                {
                    tasksAddNewTaskOperation["TaskInputData"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskOperationtaskInputData);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (__workflow_tasksAddNewTaskOperationprocessStage != null)
                {
                    tasksAddNewTaskOperation["ProcessStage"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskOperationprocessStage);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (__workflow_tasksAddNewTaskOperationpriority != null)
                {
                    if (__workflow_tasksAddNewTaskOperationpriority != null)
                    {
                        tasksAddNewTaskOperation["Priority"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskOperationpriority);
                        tasksAddNewTaskOperationpropCount++;
                    }

                    tasksAddNewTaskOperationpropCount++;
                }
                else
                {
                    tasksAddNewTaskOperation["Priority"] = 3;
                    tasksAddNewTaskOperationpropCount++;
                }

                if (__workflow_tasksAddNewTaskOperationsLA != null)
                {
                    tasksAddNewTaskOperation["SLA"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskOperationsLA);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (__workflow_tasksAddNewTaskOperationorganisation != null)
                {
                    tasksAddNewTaskOperation["Organisation"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskOperationorganisation);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (__workflow_tasksAddNewTaskOperationdepartment != null)
                {
                    tasksAddNewTaskOperation["Department"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskOperationdepartment);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (__workflow_tasksAddNewTaskOperationdescription != null)
                {
                    tasksAddNewTaskOperation["Description"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskOperationdescription);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (__workflow_tasksAddNewTaskOperationtags != null)
                {
                    tasksAddNewTaskOperation["Tags"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskOperationtags);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (tasksAddNewTaskOperationpropCount > 0)
                {
                    callPayload.Body = tasksAddNewTaskOperation;
                }

                return new ApiConnectionAction<TasksAddNewTaskOperationResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewDeferralOperationResponse> TasksAddNewDeferralOperation(Expression<Func<string>> tasksAddNewDeferralOperationautomationName = null, Expression<Func<int>> tasksAddNewDeferralOperationdeferralTimeInMinutes = null, Expression<Func<string>> tasksAddNewDeferralOperationtaskInputData = null, Expression<Func<string>> tasksAddNewDeferralOperationdeferralStoredData = null, Expression<Func<string>> tasksAddNewDeferralOperationprocessStage = null, Expression<Func<int>> tasksAddNewDeferralOperationpriority = null, Expression<Func<string>> tasksAddNewDeferralOperationorganisation = null, Expression<Func<string>> tasksAddNewDeferralOperationdepartment = null, Expression<Func<string>> tasksAddNewDeferralOperationdescription = null, Expression<Func<string>> tasksAddNewDeferralOperationtags = null)
        {
            var __workflow_tasksAddNewDeferralOperationautomationName = WorkflowExpression.Compile(tasksAddNewDeferralOperationautomationName, nameof(tasksAddNewDeferralOperationautomationName), required: false);
            var __workflow_tasksAddNewDeferralOperationdeferralTimeInMinutes = WorkflowExpression.Compile(tasksAddNewDeferralOperationdeferralTimeInMinutes, nameof(tasksAddNewDeferralOperationdeferralTimeInMinutes), required: false);
            var __workflow_tasksAddNewDeferralOperationtaskInputData = WorkflowExpression.Compile(tasksAddNewDeferralOperationtaskInputData, nameof(tasksAddNewDeferralOperationtaskInputData), required: false);
            var __workflow_tasksAddNewDeferralOperationdeferralStoredData = WorkflowExpression.Compile(tasksAddNewDeferralOperationdeferralStoredData, nameof(tasksAddNewDeferralOperationdeferralStoredData), required: false);
            var __workflow_tasksAddNewDeferralOperationprocessStage = WorkflowExpression.Compile(tasksAddNewDeferralOperationprocessStage, nameof(tasksAddNewDeferralOperationprocessStage), required: false);
            var __workflow_tasksAddNewDeferralOperationpriority = WorkflowExpression.Compile(tasksAddNewDeferralOperationpriority, nameof(tasksAddNewDeferralOperationpriority), required: false);
            var __workflow_tasksAddNewDeferralOperationorganisation = WorkflowExpression.Compile(tasksAddNewDeferralOperationorganisation, nameof(tasksAddNewDeferralOperationorganisation), required: false);
            var __workflow_tasksAddNewDeferralOperationdepartment = WorkflowExpression.Compile(tasksAddNewDeferralOperationdepartment, nameof(tasksAddNewDeferralOperationdepartment), required: false);
            var __workflow_tasksAddNewDeferralOperationdescription = WorkflowExpression.Compile(tasksAddNewDeferralOperationdescription, nameof(tasksAddNewDeferralOperationdescription), required: false);
            var __workflow_tasksAddNewDeferralOperationtags = WorkflowExpression.Compile(tasksAddNewDeferralOperationtags, nameof(tasksAddNewDeferralOperationtags), required: false);
            return new DeferredBodyAction<TasksAddNewDeferralOperationResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNewDeferralOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksAddNewDeferralOperation = new JObject();
                var tasksAddNewDeferralOperationpropCount = 0;
                if (__workflow_tasksAddNewDeferralOperationautomationName != null)
                {
                    tasksAddNewDeferralOperation["AutomationName"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralOperationautomationName);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (__workflow_tasksAddNewDeferralOperationdeferralTimeInMinutes != null)
                {
                    tasksAddNewDeferralOperation["DeferralTimeInMinutes"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralOperationdeferralTimeInMinutes);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (__workflow_tasksAddNewDeferralOperationtaskInputData != null)
                {
                    tasksAddNewDeferralOperation["TaskInputData"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralOperationtaskInputData);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (__workflow_tasksAddNewDeferralOperationdeferralStoredData != null)
                {
                    tasksAddNewDeferralOperation["DeferralStoredData"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralOperationdeferralStoredData);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (__workflow_tasksAddNewDeferralOperationprocessStage != null)
                {
                    tasksAddNewDeferralOperation["ProcessStage"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralOperationprocessStage);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (__workflow_tasksAddNewDeferralOperationpriority != null)
                {
                    if (__workflow_tasksAddNewDeferralOperationpriority != null)
                    {
                        tasksAddNewDeferralOperation["Priority"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralOperationpriority);
                        tasksAddNewDeferralOperationpropCount++;
                    }

                    tasksAddNewDeferralOperationpropCount++;
                }
                else
                {
                    tasksAddNewDeferralOperation["Priority"] = 3;
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (__workflow_tasksAddNewDeferralOperationorganisation != null)
                {
                    tasksAddNewDeferralOperation["Organisation"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralOperationorganisation);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (__workflow_tasksAddNewDeferralOperationdepartment != null)
                {
                    tasksAddNewDeferralOperation["Department"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralOperationdepartment);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (__workflow_tasksAddNewDeferralOperationdescription != null)
                {
                    tasksAddNewDeferralOperation["Description"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralOperationdescription);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (__workflow_tasksAddNewDeferralOperationtags != null)
                {
                    tasksAddNewDeferralOperation["Tags"] = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralOperationtags);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (tasksAddNewDeferralOperationpropCount > 0)
                {
                    callPayload.Body = tasksAddNewDeferralOperation;
                }

                return new ApiConnectionAction<TasksAddNewDeferralOperationResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetTaskOperationResponse> TasksGetTaskOperation(Expression<Func<string>> tasksGetTaskOperationoperationId)
        {
            var __workflow_tasksGetTaskOperationoperationId = WorkflowExpression.Compile(tasksGetTaskOperationoperationId, nameof(tasksGetTaskOperationoperationId), required: true);
            return new DeferredBodyAction<TasksGetTaskOperationResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksGetTaskOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksGetTaskOperation = new JObject();
                var tasksGetTaskOperationpropCount = 0;
                tasksGetTaskOperationpropCount++;
                tasksGetTaskOperation["OperationId"] = ExpressionConverter.ConvertO(__workflow_tasksGetTaskOperationoperationId);
                if (tasksGetTaskOperationpropCount > 0)
                {
                    callPayload.Body = tasksGetTaskOperation;
                }

                return new ApiConnectionAction<TasksGetTaskOperationResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRemoteLoggingLevel(Expression<Func<int>> setRemoteLoggingLevelloggingLevel, Expression<Func<string>> setRemoteLoggingLevelworkflow)
        {
            var __workflow_setRemoteLoggingLevelloggingLevel = WorkflowExpression.Compile(setRemoteLoggingLevelloggingLevel, nameof(setRemoteLoggingLevelloggingLevel), required: true);
            var __workflow_setRemoteLoggingLevelworkflow = WorkflowExpression.Compile(setRemoteLoggingLevelworkflow, nameof(setRemoteLoggingLevelworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/SetRemoteLoggingLevel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setRemoteLoggingLevel = new JObject();
                var setRemoteLoggingLevelpropCount = 0;
                setRemoteLoggingLevelpropCount++;
                setRemoteLoggingLevel["LoggingLevel"] = ExpressionConverter.ConvertO(__workflow_setRemoteLoggingLevelloggingLevel);
                setRemoteLoggingLevelpropCount++;
                setRemoteLoggingLevel["Workflow"] = ExpressionConverter.ConvertO(__workflow_setRemoteLoggingLevelworkflow);
                if (setRemoteLoggingLevelpropCount > 0)
                {
                    callPayload.Body = setRemoteLoggingLevel;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteLoggingLevelResponse> GetRemoteLoggingLevel(Expression<Func<string>> getRemoteLoggingLevelworkflow)
        {
            var __workflow_getRemoteLoggingLevelworkflow = WorkflowExpression.Compile(getRemoteLoggingLevelworkflow, nameof(getRemoteLoggingLevelworkflow), required: true);
            return new DeferredBodyAction<GetRemoteLoggingLevelResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetRemoteLoggingLevel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRemoteLoggingLevel = new JObject();
                var getRemoteLoggingLevelpropCount = 0;
                getRemoteLoggingLevelpropCount++;
                getRemoteLoggingLevel["Workflow"] = ExpressionConverter.ConvertO(__workflow_getRemoteLoggingLevelworkflow);
                if (getRemoteLoggingLevelpropCount > 0)
                {
                    callPayload.Body = getRemoteLoggingLevel;
                }

                return new ApiConnectionAction<GetRemoteLoggingLevelResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetLicenseCode(Expression<Func<string>> setLicenseCodecustomerNETBIOSDomainName, Expression<Func<string>> setLicenseCodecustomerDisplayName, Expression<Func<string>> setLicenseCodevendorName, Expression<Func<string>> setLicenseCodelicenseExpiryDate, Expression<Func<string>> setLicenseCodeactivationCode, Expression<Func<string>> setLicenseCodeworkflow, Expression<Func<bool>> setLicenseCodestoreInRegistry = null)
        {
            var __workflow_setLicenseCodecustomerNETBIOSDomainName = WorkflowExpression.Compile(setLicenseCodecustomerNETBIOSDomainName, nameof(setLicenseCodecustomerNETBIOSDomainName), required: true);
            var __workflow_setLicenseCodecustomerDisplayName = WorkflowExpression.Compile(setLicenseCodecustomerDisplayName, nameof(setLicenseCodecustomerDisplayName), required: true);
            var __workflow_setLicenseCodevendorName = WorkflowExpression.Compile(setLicenseCodevendorName, nameof(setLicenseCodevendorName), required: true);
            var __workflow_setLicenseCodelicenseExpiryDate = WorkflowExpression.Compile(setLicenseCodelicenseExpiryDate, nameof(setLicenseCodelicenseExpiryDate), required: true);
            var __workflow_setLicenseCodeactivationCode = WorkflowExpression.Compile(setLicenseCodeactivationCode, nameof(setLicenseCodeactivationCode), required: true);
            var __workflow_setLicenseCodeworkflow = WorkflowExpression.Compile(setLicenseCodeworkflow, nameof(setLicenseCodeworkflow), required: true);
            var __workflow_setLicenseCodestoreInRegistry = WorkflowExpression.Compile(setLicenseCodestoreInRegistry, nameof(setLicenseCodestoreInRegistry), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/SetLicenseCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setLicenseCode = new JObject();
                var setLicenseCodepropCount = 0;
                setLicenseCodepropCount++;
                setLicenseCode["CustomerNETBIOSDomainName"] = ExpressionConverter.ConvertO(__workflow_setLicenseCodecustomerNETBIOSDomainName);
                setLicenseCodepropCount++;
                setLicenseCode["CustomerDisplayName"] = ExpressionConverter.ConvertO(__workflow_setLicenseCodecustomerDisplayName);
                setLicenseCodepropCount++;
                setLicenseCode["VendorName"] = ExpressionConverter.ConvertO(__workflow_setLicenseCodevendorName);
                setLicenseCodepropCount++;
                setLicenseCode["LicenseExpiryDate"] = ExpressionConverter.ConvertO(__workflow_setLicenseCodelicenseExpiryDate);
                setLicenseCodepropCount++;
                setLicenseCode["ActivationCode"] = ExpressionConverter.ConvertO(__workflow_setLicenseCodeactivationCode);
                if (__workflow_setLicenseCodestoreInRegistry != null)
                {
                    if (__workflow_setLicenseCodestoreInRegistry != null)
                    {
                        setLicenseCode["StoreInRegistry"] = ExpressionConverter.ConvertO(__workflow_setLicenseCodestoreInRegistry);
                        setLicenseCodepropCount++;
                    }

                    setLicenseCodepropCount++;
                }
                else
                {
                    setLicenseCode["StoreInRegistry"] = true;
                    setLicenseCodepropCount++;
                }

                setLicenseCodepropCount++;
                setLicenseCode["Workflow"] = ExpressionConverter.ConvertO(__workflow_setLicenseCodeworkflow);
                if (setLicenseCodepropCount > 0)
                {
                    callPayload.Body = setLicenseCode;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetLicenseStringResponse> SetLicenseString(Expression<Func<string>> setLicenseStringlicenseString, Expression<Func<string>> setLicenseStringworkflow, Expression<Func<bool>> setLicenseStringstoreInRegistry = null)
        {
            var __workflow_setLicenseStringlicenseString = WorkflowExpression.Compile(setLicenseStringlicenseString, nameof(setLicenseStringlicenseString), required: true);
            var __workflow_setLicenseStringworkflow = WorkflowExpression.Compile(setLicenseStringworkflow, nameof(setLicenseStringworkflow), required: true);
            var __workflow_setLicenseStringstoreInRegistry = WorkflowExpression.Compile(setLicenseStringstoreInRegistry, nameof(setLicenseStringstoreInRegistry), required: false);
            return new DeferredBodyAction<SetLicenseStringResponse>(() =>
            {
                var apiCallPath = "/DriverControl/SetLicenseString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setLicenseString = new JObject();
                var setLicenseStringpropCount = 0;
                setLicenseStringpropCount++;
                setLicenseString["LicenseString"] = ExpressionConverter.ConvertO(__workflow_setLicenseStringlicenseString);
                if (__workflow_setLicenseStringstoreInRegistry != null)
                {
                    if (__workflow_setLicenseStringstoreInRegistry != null)
                    {
                        setLicenseString["StoreInRegistry"] = ExpressionConverter.ConvertO(__workflow_setLicenseStringstoreInRegistry);
                        setLicenseStringpropCount++;
                    }

                    setLicenseStringpropCount++;
                }
                else
                {
                    setLicenseString["StoreInRegistry"] = true;
                    setLicenseStringpropCount++;
                }

                setLicenseStringpropCount++;
                setLicenseString["Workflow"] = ExpressionConverter.ConvertO(__workflow_setLicenseStringworkflow);
                if (setLicenseStringpropCount > 0)
                {
                    callPayload.Body = setLicenseString;
                }

                return new ApiConnectionAction<SetLicenseStringResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLicenseStateResponse> GetLicenseState(Expression<Func<string>> getLicenseStateworkflow)
        {
            var __workflow_getLicenseStateworkflow = WorkflowExpression.Compile(getLicenseStateworkflow, nameof(getLicenseStateworkflow), required: true);
            return new DeferredBodyAction<GetLicenseStateResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetLicenseState";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getLicenseState = new JObject();
                var getLicenseStatepropCount = 0;
                getLicenseStatepropCount++;
                getLicenseState["Workflow"] = ExpressionConverter.ConvertO(__workflow_getLicenseStateworkflow);
                if (getLicenseStatepropCount > 0)
                {
                    callPayload.Body = getLicenseState;
                }

                return new ApiConnectionAction<GetLicenseStateResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUITopmost(Expression<Func<string>> setRSAGUITopmostworkflow, Expression<Func<bool>> setRSAGUITopmosttopMost = null)
        {
            var __workflow_setRSAGUITopmostworkflow = WorkflowExpression.Compile(setRSAGUITopmostworkflow, nameof(setRSAGUITopmostworkflow), required: true);
            var __workflow_setRSAGUITopmosttopMost = WorkflowExpression.Compile(setRSAGUITopmosttopMost, nameof(setRSAGUITopmosttopMost), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/SetRSAGUITopmost";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setRSAGUITopmost = new JObject();
                var setRSAGUITopmostpropCount = 0;
                if (__workflow_setRSAGUITopmosttopMost != null)
                {
                    if (__workflow_setRSAGUITopmosttopMost != null)
                    {
                        setRSAGUITopmost["TopMost"] = ExpressionConverter.ConvertO(__workflow_setRSAGUITopmosttopMost);
                        setRSAGUITopmostpropCount++;
                    }

                    setRSAGUITopmostpropCount++;
                }
                else
                {
                    setRSAGUITopmost["TopMost"] = true;
                    setRSAGUITopmostpropCount++;
                }

                setRSAGUITopmostpropCount++;
                setRSAGUITopmost["Workflow"] = ExpressionConverter.ConvertO(__workflow_setRSAGUITopmostworkflow);
                if (setRSAGUITopmostpropCount > 0)
                {
                    callPayload.Body = setRSAGUITopmost;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUIOpacity(Expression<Func<double>> setRSAGUIOpacityopacity, Expression<Func<string>> setRSAGUIOpacityworkflow)
        {
            var __workflow_setRSAGUIOpacityopacity = WorkflowExpression.Compile(setRSAGUIOpacityopacity, nameof(setRSAGUIOpacityopacity), required: true);
            var __workflow_setRSAGUIOpacityworkflow = WorkflowExpression.Compile(setRSAGUIOpacityworkflow, nameof(setRSAGUIOpacityworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/SetRSAGUIOpacity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setRSAGUIOpacity = new JObject();
                var setRSAGUIOpacitypropCount = 0;
                setRSAGUIOpacitypropCount++;
                setRSAGUIOpacity["Opacity"] = ExpressionConverter.ConvertO(__workflow_setRSAGUIOpacityopacity);
                setRSAGUIOpacitypropCount++;
                setRSAGUIOpacity["Workflow"] = ExpressionConverter.ConvertO(__workflow_setRSAGUIOpacityworkflow);
                if (setRSAGUIOpacitypropCount > 0)
                {
                    callPayload.Body = setRSAGUIOpacity;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUIPosition(Expression<Func<int>> setRSAGUIPositionx, Expression<Func<int>> setRSAGUIPositiony, Expression<Func<string>> setRSAGUIPositionworkflow)
        {
            var __workflow_setRSAGUIPositionx = WorkflowExpression.Compile(setRSAGUIPositionx, nameof(setRSAGUIPositionx), required: true);
            var __workflow_setRSAGUIPositiony = WorkflowExpression.Compile(setRSAGUIPositiony, nameof(setRSAGUIPositiony), required: true);
            var __workflow_setRSAGUIPositionworkflow = WorkflowExpression.Compile(setRSAGUIPositionworkflow, nameof(setRSAGUIPositionworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/SetRSAGUIPosition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setRSAGUIPosition = new JObject();
                var setRSAGUIPositionpropCount = 0;
                setRSAGUIPositionpropCount++;
                setRSAGUIPosition["X"] = ExpressionConverter.ConvertO(__workflow_setRSAGUIPositionx);
                setRSAGUIPositionpropCount++;
                setRSAGUIPosition["Y"] = ExpressionConverter.ConvertO(__workflow_setRSAGUIPositiony);
                setRSAGUIPositionpropCount++;
                setRSAGUIPosition["Workflow"] = ExpressionConverter.ConvertO(__workflow_setRSAGUIPositionworkflow);
                if (setRSAGUIPositionpropCount > 0)
                {
                    callPayload.Body = setRSAGUIPosition;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction BringRSAGUIToFront(Expression<Func<string>> bringRSAGUIToFrontworkflow, Expression<Func<bool>> bringRSAGUIToFrontfocus = null, Expression<Func<bool>> bringRSAGUIToFrontglobalLeftMouseClick = null)
        {
            var __workflow_bringRSAGUIToFrontworkflow = WorkflowExpression.Compile(bringRSAGUIToFrontworkflow, nameof(bringRSAGUIToFrontworkflow), required: true);
            var __workflow_bringRSAGUIToFrontfocus = WorkflowExpression.Compile(bringRSAGUIToFrontfocus, nameof(bringRSAGUIToFrontfocus), required: false);
            var __workflow_bringRSAGUIToFrontglobalLeftMouseClick = WorkflowExpression.Compile(bringRSAGUIToFrontglobalLeftMouseClick, nameof(bringRSAGUIToFrontglobalLeftMouseClick), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/BringRSAGUIToFront";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var bringRSAGUIToFront = new JObject();
                var bringRSAGUIToFrontpropCount = 0;
                if (__workflow_bringRSAGUIToFrontfocus != null)
                {
                    if (__workflow_bringRSAGUIToFrontfocus != null)
                    {
                        bringRSAGUIToFront["Focus"] = ExpressionConverter.ConvertO(__workflow_bringRSAGUIToFrontfocus);
                        bringRSAGUIToFrontpropCount++;
                    }

                    bringRSAGUIToFrontpropCount++;
                }
                else
                {
                    bringRSAGUIToFront["Focus"] = true;
                    bringRSAGUIToFrontpropCount++;
                }

                if (__workflow_bringRSAGUIToFrontglobalLeftMouseClick != null)
                {
                    if (__workflow_bringRSAGUIToFrontglobalLeftMouseClick != null)
                    {
                        bringRSAGUIToFront["GlobalLeftMouseClick"] = ExpressionConverter.ConvertO(__workflow_bringRSAGUIToFrontglobalLeftMouseClick);
                        bringRSAGUIToFrontpropCount++;
                    }

                    bringRSAGUIToFrontpropCount++;
                }
                else
                {
                    bringRSAGUIToFront["GlobalLeftMouseClick"] = true;
                    bringRSAGUIToFrontpropCount++;
                }

                bringRSAGUIToFrontpropCount++;
                bringRSAGUIToFront["Workflow"] = ExpressionConverter.ConvertO(__workflow_bringRSAGUIToFrontworkflow);
                if (bringRSAGUIToFrontpropCount > 0)
                {
                    callPayload.Body = bringRSAGUIToFront;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DisconnectSession(Expression<Func<string>> disconnectSessionworkflow, Expression<Func<int>> disconnectSessionsecondsToWait = null, Expression<Func<bool>> disconnectSessiondoNotDisconnectIfLocalAgent = null)
        {
            var __workflow_disconnectSessionworkflow = WorkflowExpression.Compile(disconnectSessionworkflow, nameof(disconnectSessionworkflow), required: true);
            var __workflow_disconnectSessionsecondsToWait = WorkflowExpression.Compile(disconnectSessionsecondsToWait, nameof(disconnectSessionsecondsToWait), required: false);
            var __workflow_disconnectSessiondoNotDisconnectIfLocalAgent = WorkflowExpression.Compile(disconnectSessiondoNotDisconnectIfLocalAgent, nameof(disconnectSessiondoNotDisconnectIfLocalAgent), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/DisconnectSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var disconnectSession = new JObject();
                var disconnectSessionpropCount = 0;
                if (__workflow_disconnectSessionsecondsToWait != null)
                {
                    if (__workflow_disconnectSessionsecondsToWait != null)
                    {
                        disconnectSession["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_disconnectSessionsecondsToWait);
                        disconnectSessionpropCount++;
                    }

                    disconnectSessionpropCount++;
                }
                else
                {
                    disconnectSession["SecondsToWait"] = 3;
                    disconnectSessionpropCount++;
                }

                if (__workflow_disconnectSessiondoNotDisconnectIfLocalAgent != null)
                {
                    if (__workflow_disconnectSessiondoNotDisconnectIfLocalAgent != null)
                    {
                        disconnectSession["DoNotDisconnectIfLocalAgent"] = ExpressionConverter.ConvertO(__workflow_disconnectSessiondoNotDisconnectIfLocalAgent);
                        disconnectSessionpropCount++;
                    }

                    disconnectSessionpropCount++;
                }
                else
                {
                    disconnectSession["DoNotDisconnectIfLocalAgent"] = false;
                    disconnectSessionpropCount++;
                }

                disconnectSessionpropCount++;
                disconnectSession["Workflow"] = ExpressionConverter.ConvertO(__workflow_disconnectSessionworkflow);
                if (disconnectSessionpropCount > 0)
                {
                    callPayload.Body = disconnectSession;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LogoffSession(Expression<Func<string>> logoffSessionworkflow, Expression<Func<int>> logoffSessionsecondsToWait = null)
        {
            var __workflow_logoffSessionworkflow = WorkflowExpression.Compile(logoffSessionworkflow, nameof(logoffSessionworkflow), required: true);
            var __workflow_logoffSessionsecondsToWait = WorkflowExpression.Compile(logoffSessionsecondsToWait, nameof(logoffSessionsecondsToWait), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/LogoffSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var logoffSession = new JObject();
                var logoffSessionpropCount = 0;
                if (__workflow_logoffSessionsecondsToWait != null)
                {
                    if (__workflow_logoffSessionsecondsToWait != null)
                    {
                        logoffSession["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_logoffSessionsecondsToWait);
                        logoffSessionpropCount++;
                    }

                    logoffSessionpropCount++;
                }
                else
                {
                    logoffSession["SecondsToWait"] = 3;
                    logoffSessionpropCount++;
                }

                logoffSessionpropCount++;
                logoffSession["Workflow"] = ExpressionConverter.ConvertO(__workflow_logoffSessionworkflow);
                if (logoffSessionpropCount > 0)
                {
                    callPayload.Body = logoffSession;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CloseRSAServer(Expression<Func<string>> closeRSAServerworkflow, Expression<Func<int>> closeRSAServersecondsToWait = null)
        {
            var __workflow_closeRSAServerworkflow = WorkflowExpression.Compile(closeRSAServerworkflow, nameof(closeRSAServerworkflow), required: true);
            var __workflow_closeRSAServersecondsToWait = WorkflowExpression.Compile(closeRSAServersecondsToWait, nameof(closeRSAServersecondsToWait), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/CloseRSAServer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var closeRSAServer = new JObject();
                var closeRSAServerpropCount = 0;
                if (__workflow_closeRSAServersecondsToWait != null)
                {
                    if (__workflow_closeRSAServersecondsToWait != null)
                    {
                        closeRSAServer["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_closeRSAServersecondsToWait);
                        closeRSAServerpropCount++;
                    }

                    closeRSAServerpropCount++;
                }
                else
                {
                    closeRSAServer["SecondsToWait"] = 3;
                    closeRSAServerpropCount++;
                }

                closeRSAServerpropCount++;
                closeRSAServer["Workflow"] = ExpressionConverter.ConvertO(__workflow_closeRSAServerworkflow);
                if (closeRSAServerpropCount > 0)
                {
                    callPayload.Body = closeRSAServer;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRPACommandTimeout(Expression<Func<int>> setRPACommandTimeoutcommandTimeoutInSeconds, Expression<Func<string>> setRPACommandTimeoutworkflow, Expression<Func<bool>> setRPACommandTimeoutterminateTimedoutRPACommandThreads = null)
        {
            var __workflow_setRPACommandTimeoutcommandTimeoutInSeconds = WorkflowExpression.Compile(setRPACommandTimeoutcommandTimeoutInSeconds, nameof(setRPACommandTimeoutcommandTimeoutInSeconds), required: true);
            var __workflow_setRPACommandTimeoutworkflow = WorkflowExpression.Compile(setRPACommandTimeoutworkflow, nameof(setRPACommandTimeoutworkflow), required: true);
            var __workflow_setRPACommandTimeoutterminateTimedoutRPACommandThreads = WorkflowExpression.Compile(setRPACommandTimeoutterminateTimedoutRPACommandThreads, nameof(setRPACommandTimeoutterminateTimedoutRPACommandThreads), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/SetRPACommandTimeout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setRPACommandTimeout = new JObject();
                var setRPACommandTimeoutpropCount = 0;
                setRPACommandTimeoutpropCount++;
                setRPACommandTimeout["CommandTimeoutInSeconds"] = ExpressionConverter.ConvertO(__workflow_setRPACommandTimeoutcommandTimeoutInSeconds);
                if (__workflow_setRPACommandTimeoutterminateTimedoutRPACommandThreads != null)
                {
                    if (__workflow_setRPACommandTimeoutterminateTimedoutRPACommandThreads != null)
                    {
                        setRPACommandTimeout["TerminateTimedoutRPACommandThreads"] = ExpressionConverter.ConvertO(__workflow_setRPACommandTimeoutterminateTimedoutRPACommandThreads);
                        setRPACommandTimeoutpropCount++;
                    }

                    setRPACommandTimeoutpropCount++;
                }
                else
                {
                    setRPACommandTimeout["TerminateTimedoutRPACommandThreads"] = true;
                    setRPACommandTimeoutpropCount++;
                }

                setRPACommandTimeoutpropCount++;
                setRPACommandTimeout["Workflow"] = ExpressionConverter.ConvertO(__workflow_setRPACommandTimeoutworkflow);
                if (setRPACommandTimeoutpropCount > 0)
                {
                    callPayload.Body = setRPACommandTimeout;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RunAlternativeIAConnect(Expression<Func<string>> runAlternativeIAConnectfilename, Expression<Func<string>> runAlternativeIAConnectworkflow, Expression<Func<string>> runAlternativeIAConnectarguments = null, Expression<Func<bool>> runAlternativeIAConnectloadIntoMemory = null)
        {
            var __workflow_runAlternativeIAConnectfilename = WorkflowExpression.Compile(runAlternativeIAConnectfilename, nameof(runAlternativeIAConnectfilename), required: true);
            var __workflow_runAlternativeIAConnectworkflow = WorkflowExpression.Compile(runAlternativeIAConnectworkflow, nameof(runAlternativeIAConnectworkflow), required: true);
            var __workflow_runAlternativeIAConnectarguments = WorkflowExpression.Compile(runAlternativeIAConnectarguments, nameof(runAlternativeIAConnectarguments), required: false);
            var __workflow_runAlternativeIAConnectloadIntoMemory = WorkflowExpression.Compile(runAlternativeIAConnectloadIntoMemory, nameof(runAlternativeIAConnectloadIntoMemory), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/RunAlternativeIAConnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runAlternativeIAConnect = new JObject();
                var runAlternativeIAConnectpropCount = 0;
                runAlternativeIAConnectpropCount++;
                runAlternativeIAConnect["Filename"] = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnectfilename);
                if (__workflow_runAlternativeIAConnectarguments != null)
                {
                    runAlternativeIAConnect["Arguments"] = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnectarguments);
                    runAlternativeIAConnectpropCount++;
                }

                if (__workflow_runAlternativeIAConnectloadIntoMemory != null)
                {
                    if (__workflow_runAlternativeIAConnectloadIntoMemory != null)
                    {
                        runAlternativeIAConnect["LoadIntoMemory"] = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnectloadIntoMemory);
                        runAlternativeIAConnectpropCount++;
                    }

                    runAlternativeIAConnectpropCount++;
                }
                else
                {
                    runAlternativeIAConnect["LoadIntoMemory"] = true;
                    runAlternativeIAConnectpropCount++;
                }

                runAlternativeIAConnectpropCount++;
                runAlternativeIAConnect["Workflow"] = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnectworkflow);
                if (runAlternativeIAConnectpropCount > 0)
                {
                    callPayload.Body = runAlternativeIAConnect;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunAlternativeIAConnectSentFromDirectorResponse> RunAlternativeIAConnectSentFromDirector(Expression<Func<string>> runAlternativeIAConnectSentFromDirectorlocalFilename, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorworkflow, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorremoteFilename = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorcompress = null, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorarguments = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorpermitDowngrade = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorskipVersionCheck = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorloadIntoMemory = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory = null)
        {
            var __workflow_runAlternativeIAConnectSentFromDirectorlocalFilename = WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorlocalFilename, nameof(runAlternativeIAConnectSentFromDirectorlocalFilename), required: true);
            var __workflow_runAlternativeIAConnectSentFromDirectorworkflow = WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorworkflow, nameof(runAlternativeIAConnectSentFromDirectorworkflow), required: true);
            var __workflow_runAlternativeIAConnectSentFromDirectorremoteFilename = WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorremoteFilename, nameof(runAlternativeIAConnectSentFromDirectorremoteFilename), required: false);
            var __workflow_runAlternativeIAConnectSentFromDirectorcompress = WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorcompress, nameof(runAlternativeIAConnectSentFromDirectorcompress), required: false);
            var __workflow_runAlternativeIAConnectSentFromDirectorarguments = WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorarguments, nameof(runAlternativeIAConnectSentFromDirectorarguments), required: false);
            var __workflow_runAlternativeIAConnectSentFromDirectorpermitDowngrade = WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorpermitDowngrade, nameof(runAlternativeIAConnectSentFromDirectorpermitDowngrade), required: false);
            var __workflow_runAlternativeIAConnectSentFromDirectorskipVersionCheck = WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorskipVersionCheck, nameof(runAlternativeIAConnectSentFromDirectorskipVersionCheck), required: false);
            var __workflow_runAlternativeIAConnectSentFromDirectorloadIntoMemory = WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorloadIntoMemory, nameof(runAlternativeIAConnectSentFromDirectorloadIntoMemory), required: false);
            var __workflow_runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory = WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory, nameof(runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory), required: false);
            return new DeferredBodyAction<RunAlternativeIAConnectSentFromDirectorResponse>(() =>
            {
                var apiCallPath = "/DriverControl/RunAlternativeIAConnectSentFromDirector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runAlternativeIAConnectSentFromDirector = new JObject();
                var runAlternativeIAConnectSentFromDirectorpropCount = 0;
                runAlternativeIAConnectSentFromDirectorpropCount++;
                runAlternativeIAConnectSentFromDirector["LocalFilename"] = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnectSentFromDirectorlocalFilename);
                if (__workflow_runAlternativeIAConnectSentFromDirectorremoteFilename != null)
                {
                    runAlternativeIAConnectSentFromDirector["RemoteFilename"] = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnectSentFromDirectorremoteFilename);
                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }

                if (__workflow_runAlternativeIAConnectSentFromDirectorcompress != null)
                {
                    if (__workflow_runAlternativeIAConnectSentFromDirectorcompress != null)
                    {
                        runAlternativeIAConnectSentFromDirector["Compress"] = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnectSentFromDirectorcompress);
                        runAlternativeIAConnectSentFromDirectorpropCount++;
                    }

                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }
                else
                {
                    runAlternativeIAConnectSentFromDirector["Compress"] = true;
                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }

                if (__workflow_runAlternativeIAConnectSentFromDirectorarguments != null)
                {
                    runAlternativeIAConnectSentFromDirector["Arguments"] = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnectSentFromDirectorarguments);
                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }

                if (__workflow_runAlternativeIAConnectSentFromDirectorpermitDowngrade != null)
                {
                    if (__workflow_runAlternativeIAConnectSentFromDirectorpermitDowngrade != null)
                    {
                        runAlternativeIAConnectSentFromDirector["PermitDowngrade"] = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnectSentFromDirectorpermitDowngrade);
                        runAlternativeIAConnectSentFromDirectorpropCount++;
                    }

                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }
                else
                {
                    runAlternativeIAConnectSentFromDirector["PermitDowngrade"] = false;
                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }

                if (__workflow_runAlternativeIAConnectSentFromDirectorskipVersionCheck != null)
                {
                    if (__workflow_runAlternativeIAConnectSentFromDirectorskipVersionCheck != null)
                    {
                        runAlternativeIAConnectSentFromDirector["SkipVersionCheck"] = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnectSentFromDirectorskipVersionCheck);
                        runAlternativeIAConnectSentFromDirectorpropCount++;
                    }

                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }
                else
                {
                    runAlternativeIAConnectSentFromDirector["SkipVersionCheck"] = false;
                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }

                if (__workflow_runAlternativeIAConnectSentFromDirectorloadIntoMemory != null)
                {
                    if (__workflow_runAlternativeIAConnectSentFromDirectorloadIntoMemory != null)
                    {
                        runAlternativeIAConnectSentFromDirector["LoadIntoMemory"] = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnectSentFromDirectorloadIntoMemory);
                        runAlternativeIAConnectSentFromDirectorpropCount++;
                    }

                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }
                else
                {
                    runAlternativeIAConnectSentFromDirector["LoadIntoMemory"] = true;
                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }

                if (__workflow_runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory != null)
                {
                    if (__workflow_runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory != null)
                    {
                        runAlternativeIAConnectSentFromDirector["SaveToDiskEvenIfRunningFromMemory"] = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory);
                        runAlternativeIAConnectSentFromDirectorpropCount++;
                    }

                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }
                else
                {
                    runAlternativeIAConnectSentFromDirector["SaveToDiskEvenIfRunningFromMemory"] = false;
                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }

                runAlternativeIAConnectSentFromDirectorpropCount++;
                runAlternativeIAConnectSentFromDirector["Workflow"] = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnectSentFromDirectorworkflow);
                if (runAlternativeIAConnectSentFromDirectorpropCount > 0)
                {
                    callPayload.Body = runAlternativeIAConnectSentFromDirector;
                }

                return new ApiConnectionAction<RunAlternativeIAConnectSentFromDirectorResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectAgentInfoResponse> GetIAConnectAgentInfo(Expression<Func<string>> getIAConnectAgentInfoworkflow)
        {
            var __workflow_getIAConnectAgentInfoworkflow = WorkflowExpression.Compile(getIAConnectAgentInfoworkflow, nameof(getIAConnectAgentInfoworkflow), required: true);
            return new DeferredBodyAction<GetIAConnectAgentInfoResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetIAConnectAgentInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectAgentInfo = new JObject();
                var getIAConnectAgentInfopropCount = 0;
                getIAConnectAgentInfopropCount++;
                getIAConnectAgentInfo["Workflow"] = ExpressionConverter.ConvertO(__workflow_getIAConnectAgentInfoworkflow);
                if (getIAConnectAgentInfopropCount > 0)
                {
                    callPayload.Body = getIAConnectAgentInfo;
                }

                return new ApiConnectionAction<GetIAConnectAgentInfoResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectAgentLogResponse> GetIAConnectAgentLog(Expression<Func<string>> getIAConnectAgentLogworkflow, Expression<Func<bool>> getIAConnectAgentLogcompress = null, Expression<Func<bool>> getIAConnectAgentLogreturnLastCommandOnly = null, Expression<Func<bool>> getIAConnectAgentLogsaveLogToFile = null, Expression<Func<bool>> getIAConnectAgentLogplaceLogContentInDataItem = null, Expression<Func<string>> getIAConnectAgentLoglocalSaveFolder = null, Expression<Func<bool>> getIAConnectAgentLoguseAgentLogFilename = null, Expression<Func<string>> getIAConnectAgentLoglocalSaveFilename = null, Expression<Func<int>> getIAConnectAgentLogmaxBytesToRead = null)
        {
            var __workflow_getIAConnectAgentLogworkflow = WorkflowExpression.Compile(getIAConnectAgentLogworkflow, nameof(getIAConnectAgentLogworkflow), required: true);
            var __workflow_getIAConnectAgentLogcompress = WorkflowExpression.Compile(getIAConnectAgentLogcompress, nameof(getIAConnectAgentLogcompress), required: false);
            var __workflow_getIAConnectAgentLogreturnLastCommandOnly = WorkflowExpression.Compile(getIAConnectAgentLogreturnLastCommandOnly, nameof(getIAConnectAgentLogreturnLastCommandOnly), required: false);
            var __workflow_getIAConnectAgentLogsaveLogToFile = WorkflowExpression.Compile(getIAConnectAgentLogsaveLogToFile, nameof(getIAConnectAgentLogsaveLogToFile), required: false);
            var __workflow_getIAConnectAgentLogplaceLogContentInDataItem = WorkflowExpression.Compile(getIAConnectAgentLogplaceLogContentInDataItem, nameof(getIAConnectAgentLogplaceLogContentInDataItem), required: false);
            var __workflow_getIAConnectAgentLoglocalSaveFolder = WorkflowExpression.Compile(getIAConnectAgentLoglocalSaveFolder, nameof(getIAConnectAgentLoglocalSaveFolder), required: false);
            var __workflow_getIAConnectAgentLoguseAgentLogFilename = WorkflowExpression.Compile(getIAConnectAgentLoguseAgentLogFilename, nameof(getIAConnectAgentLoguseAgentLogFilename), required: false);
            var __workflow_getIAConnectAgentLoglocalSaveFilename = WorkflowExpression.Compile(getIAConnectAgentLoglocalSaveFilename, nameof(getIAConnectAgentLoglocalSaveFilename), required: false);
            var __workflow_getIAConnectAgentLogmaxBytesToRead = WorkflowExpression.Compile(getIAConnectAgentLogmaxBytesToRead, nameof(getIAConnectAgentLogmaxBytesToRead), required: false);
            return new DeferredBodyAction<GetIAConnectAgentLogResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetIAConnectAgentLog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectAgentLog = new JObject();
                var getIAConnectAgentLogpropCount = 0;
                if (__workflow_getIAConnectAgentLogcompress != null)
                {
                    if (__workflow_getIAConnectAgentLogcompress != null)
                    {
                        getIAConnectAgentLog["Compress"] = ExpressionConverter.ConvertO(__workflow_getIAConnectAgentLogcompress);
                        getIAConnectAgentLogpropCount++;
                    }

                    getIAConnectAgentLogpropCount++;
                }
                else
                {
                    getIAConnectAgentLog["Compress"] = true;
                    getIAConnectAgentLogpropCount++;
                }

                if (__workflow_getIAConnectAgentLogreturnLastCommandOnly != null)
                {
                    if (__workflow_getIAConnectAgentLogreturnLastCommandOnly != null)
                    {
                        getIAConnectAgentLog["ReturnLastCommandOnly"] = ExpressionConverter.ConvertO(__workflow_getIAConnectAgentLogreturnLastCommandOnly);
                        getIAConnectAgentLogpropCount++;
                    }

                    getIAConnectAgentLogpropCount++;
                }
                else
                {
                    getIAConnectAgentLog["ReturnLastCommandOnly"] = false;
                    getIAConnectAgentLogpropCount++;
                }

                if (__workflow_getIAConnectAgentLogsaveLogToFile != null)
                {
                    if (__workflow_getIAConnectAgentLogsaveLogToFile != null)
                    {
                        getIAConnectAgentLog["SaveLogToFile"] = ExpressionConverter.ConvertO(__workflow_getIAConnectAgentLogsaveLogToFile);
                        getIAConnectAgentLogpropCount++;
                    }

                    getIAConnectAgentLogpropCount++;
                }
                else
                {
                    getIAConnectAgentLog["SaveLogToFile"] = true;
                    getIAConnectAgentLogpropCount++;
                }

                if (__workflow_getIAConnectAgentLogplaceLogContentInDataItem != null)
                {
                    if (__workflow_getIAConnectAgentLogplaceLogContentInDataItem != null)
                    {
                        getIAConnectAgentLog["PlaceLogContentInDataItem"] = ExpressionConverter.ConvertO(__workflow_getIAConnectAgentLogplaceLogContentInDataItem);
                        getIAConnectAgentLogpropCount++;
                    }

                    getIAConnectAgentLogpropCount++;
                }
                else
                {
                    getIAConnectAgentLog["PlaceLogContentInDataItem"] = false;
                    getIAConnectAgentLogpropCount++;
                }

                if (__workflow_getIAConnectAgentLoglocalSaveFolder != null)
                {
                    getIAConnectAgentLog["LocalSaveFolder"] = ExpressionConverter.ConvertO(__workflow_getIAConnectAgentLoglocalSaveFolder);
                    getIAConnectAgentLogpropCount++;
                }

                if (__workflow_getIAConnectAgentLoguseAgentLogFilename != null)
                {
                    if (__workflow_getIAConnectAgentLoguseAgentLogFilename != null)
                    {
                        getIAConnectAgentLog["UseAgentLogFilename"] = ExpressionConverter.ConvertO(__workflow_getIAConnectAgentLoguseAgentLogFilename);
                        getIAConnectAgentLogpropCount++;
                    }

                    getIAConnectAgentLogpropCount++;
                }
                else
                {
                    getIAConnectAgentLog["UseAgentLogFilename"] = true;
                    getIAConnectAgentLogpropCount++;
                }

                if (__workflow_getIAConnectAgentLoglocalSaveFilename != null)
                {
                    getIAConnectAgentLog["LocalSaveFilename"] = ExpressionConverter.ConvertO(__workflow_getIAConnectAgentLoglocalSaveFilename);
                    getIAConnectAgentLogpropCount++;
                }

                if (__workflow_getIAConnectAgentLogmaxBytesToRead != null)
                {
                    if (__workflow_getIAConnectAgentLogmaxBytesToRead != null)
                    {
                        getIAConnectAgentLog["MaxBytesToRead"] = ExpressionConverter.ConvertO(__workflow_getIAConnectAgentLogmaxBytesToRead);
                        getIAConnectAgentLogpropCount++;
                    }

                    getIAConnectAgentLogpropCount++;
                }
                else
                {
                    getIAConnectAgentLog["MaxBytesToRead"] = 4000;
                    getIAConnectAgentLogpropCount++;
                }

                getIAConnectAgentLogpropCount++;
                getIAConnectAgentLog["Workflow"] = ExpressionConverter.ConvertO(__workflow_getIAConnectAgentLogworkflow);
                if (getIAConnectAgentLogpropCount > 0)
                {
                    callPayload.Body = getIAConnectAgentLog;
                }

                return new ApiConnectionAction<GetIAConnectAgentLogResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ResetCommandStats(Expression<Func<string>> resetCommandStatsworkflow)
        {
            var __workflow_resetCommandStatsworkflow = WorkflowExpression.Compile(resetCommandStatsworkflow, nameof(resetCommandStatsworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/ResetCommandStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var resetCommandStats = new JObject();
                var resetCommandStatspropCount = 0;
                resetCommandStatspropCount++;
                resetCommandStats["Workflow"] = ExpressionConverter.ConvertO(__workflow_resetCommandStatsworkflow);
                if (resetCommandStatspropCount > 0)
                {
                    callPayload.Body = resetCommandStats;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAllCommandStatsResponse> GetAllCommandStats(Expression<Func<string>> getAllCommandStatsworkflow)
        {
            var __workflow_getAllCommandStatsworkflow = WorkflowExpression.Compile(getAllCommandStatsworkflow, nameof(getAllCommandStatsworkflow), required: true);
            return new DeferredBodyAction<GetAllCommandStatsResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetAllCommandStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getAllCommandStats = new JObject();
                var getAllCommandStatspropCount = 0;
                getAllCommandStatspropCount++;
                getAllCommandStats["Workflow"] = ExpressionConverter.ConvertO(__workflow_getAllCommandStatsworkflow);
                if (getAllCommandStatspropCount > 0)
                {
                    callPayload.Body = getAllCommandStats;
                }

                return new ApiConnectionAction<GetAllCommandStatsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<EnableNextHopResponse> EnableNextHop(Expression<Func<string>> enableNextHopworkflow, Expression<Func<string>> enableNextHopnextHopDirectorAddress = null, Expression<Func<int>> enableNextHopnextHopDirectorTCPPort = null, Expression<Func<bool>> enableNextHopnextHopDirectorUsesHTTPS = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsLocalhostname = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsHostname = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsFQDN = null, Expression<Func<bool>> enableNextHopincrementNextHopDirectorTCPPortBySessionId = null, Expression<Func<bool>> enableNextHopdisableBeforeEnable = null, Expression<Func<bool>> enableNextHopcheckNextHopDirectorIsRunning = null, Expression<Func<bool>> enableNextHopcheckNextHopAgentIsRunning = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsNamedPipe = null)
        {
            var __workflow_enableNextHopworkflow = WorkflowExpression.Compile(enableNextHopworkflow, nameof(enableNextHopworkflow), required: true);
            var __workflow_enableNextHopnextHopDirectorAddress = WorkflowExpression.Compile(enableNextHopnextHopDirectorAddress, nameof(enableNextHopnextHopDirectorAddress), required: false);
            var __workflow_enableNextHopnextHopDirectorTCPPort = WorkflowExpression.Compile(enableNextHopnextHopDirectorTCPPort, nameof(enableNextHopnextHopDirectorTCPPort), required: false);
            var __workflow_enableNextHopnextHopDirectorUsesHTTPS = WorkflowExpression.Compile(enableNextHopnextHopDirectorUsesHTTPS, nameof(enableNextHopnextHopDirectorUsesHTTPS), required: false);
            var __workflow_enableNextHopnextHopDirectorAddressIsLocalhostname = WorkflowExpression.Compile(enableNextHopnextHopDirectorAddressIsLocalhostname, nameof(enableNextHopnextHopDirectorAddressIsLocalhostname), required: false);
            var __workflow_enableNextHopnextHopDirectorAddressIsHostname = WorkflowExpression.Compile(enableNextHopnextHopDirectorAddressIsHostname, nameof(enableNextHopnextHopDirectorAddressIsHostname), required: false);
            var __workflow_enableNextHopnextHopDirectorAddressIsFQDN = WorkflowExpression.Compile(enableNextHopnextHopDirectorAddressIsFQDN, nameof(enableNextHopnextHopDirectorAddressIsFQDN), required: false);
            var __workflow_enableNextHopincrementNextHopDirectorTCPPortBySessionId = WorkflowExpression.Compile(enableNextHopincrementNextHopDirectorTCPPortBySessionId, nameof(enableNextHopincrementNextHopDirectorTCPPortBySessionId), required: false);
            var __workflow_enableNextHopdisableBeforeEnable = WorkflowExpression.Compile(enableNextHopdisableBeforeEnable, nameof(enableNextHopdisableBeforeEnable), required: false);
            var __workflow_enableNextHopcheckNextHopDirectorIsRunning = WorkflowExpression.Compile(enableNextHopcheckNextHopDirectorIsRunning, nameof(enableNextHopcheckNextHopDirectorIsRunning), required: false);
            var __workflow_enableNextHopcheckNextHopAgentIsRunning = WorkflowExpression.Compile(enableNextHopcheckNextHopAgentIsRunning, nameof(enableNextHopcheckNextHopAgentIsRunning), required: false);
            var __workflow_enableNextHopnextHopDirectorAddressIsNamedPipe = WorkflowExpression.Compile(enableNextHopnextHopDirectorAddressIsNamedPipe, nameof(enableNextHopnextHopDirectorAddressIsNamedPipe), required: false);
            return new DeferredBodyAction<EnableNextHopResponse>(() =>
            {
                var apiCallPath = "/DriverControl/EnableNextHop";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var enableNextHop = new JObject();
                var enableNextHoppropCount = 0;
                if (__workflow_enableNextHopnextHopDirectorAddress != null)
                {
                    enableNextHop["NextHopDirectorAddress"] = ExpressionConverter.ConvertO(__workflow_enableNextHopnextHopDirectorAddress);
                    enableNextHoppropCount++;
                }

                if (__workflow_enableNextHopnextHopDirectorTCPPort != null)
                {
                    if (__workflow_enableNextHopnextHopDirectorTCPPort != null)
                    {
                        enableNextHop["NextHopDirectorTCPPort"] = ExpressionConverter.ConvertO(__workflow_enableNextHopnextHopDirectorTCPPort);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["NextHopDirectorTCPPort"] = 8002;
                    enableNextHoppropCount++;
                }

                if (__workflow_enableNextHopnextHopDirectorUsesHTTPS != null)
                {
                    if (__workflow_enableNextHopnextHopDirectorUsesHTTPS != null)
                    {
                        enableNextHop["NextHopDirectorUsesHTTPS"] = ExpressionConverter.ConvertO(__workflow_enableNextHopnextHopDirectorUsesHTTPS);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["NextHopDirectorUsesHTTPS"] = false;
                    enableNextHoppropCount++;
                }

                if (__workflow_enableNextHopnextHopDirectorAddressIsLocalhostname != null)
                {
                    if (__workflow_enableNextHopnextHopDirectorAddressIsLocalhostname != null)
                    {
                        enableNextHop["NextHopDirectorAddressIsLocalhostname"] = ExpressionConverter.ConvertO(__workflow_enableNextHopnextHopDirectorAddressIsLocalhostname);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["NextHopDirectorAddressIsLocalhostname"] = false;
                    enableNextHoppropCount++;
                }

                if (__workflow_enableNextHopnextHopDirectorAddressIsHostname != null)
                {
                    if (__workflow_enableNextHopnextHopDirectorAddressIsHostname != null)
                    {
                        enableNextHop["NextHopDirectorAddressIsHostname"] = ExpressionConverter.ConvertO(__workflow_enableNextHopnextHopDirectorAddressIsHostname);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["NextHopDirectorAddressIsHostname"] = false;
                    enableNextHoppropCount++;
                }

                if (__workflow_enableNextHopnextHopDirectorAddressIsFQDN != null)
                {
                    if (__workflow_enableNextHopnextHopDirectorAddressIsFQDN != null)
                    {
                        enableNextHop["NextHopDirectorAddressIsFQDN"] = ExpressionConverter.ConvertO(__workflow_enableNextHopnextHopDirectorAddressIsFQDN);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["NextHopDirectorAddressIsFQDN"] = false;
                    enableNextHoppropCount++;
                }

                if (__workflow_enableNextHopincrementNextHopDirectorTCPPortBySessionId != null)
                {
                    if (__workflow_enableNextHopincrementNextHopDirectorTCPPortBySessionId != null)
                    {
                        enableNextHop["IncrementNextHopDirectorTCPPortBySessionId"] = ExpressionConverter.ConvertO(__workflow_enableNextHopincrementNextHopDirectorTCPPortBySessionId);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["IncrementNextHopDirectorTCPPortBySessionId"] = true;
                    enableNextHoppropCount++;
                }

                if (__workflow_enableNextHopdisableBeforeEnable != null)
                {
                    if (__workflow_enableNextHopdisableBeforeEnable != null)
                    {
                        enableNextHop["DisableBeforeEnable"] = ExpressionConverter.ConvertO(__workflow_enableNextHopdisableBeforeEnable);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["DisableBeforeEnable"] = true;
                    enableNextHoppropCount++;
                }

                if (__workflow_enableNextHopcheckNextHopDirectorIsRunning != null)
                {
                    if (__workflow_enableNextHopcheckNextHopDirectorIsRunning != null)
                    {
                        enableNextHop["CheckNextHopDirectorIsRunning"] = ExpressionConverter.ConvertO(__workflow_enableNextHopcheckNextHopDirectorIsRunning);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["CheckNextHopDirectorIsRunning"] = false;
                    enableNextHoppropCount++;
                }

                if (__workflow_enableNextHopcheckNextHopAgentIsRunning != null)
                {
                    if (__workflow_enableNextHopcheckNextHopAgentIsRunning != null)
                    {
                        enableNextHop["CheckNextHopAgentIsRunning"] = ExpressionConverter.ConvertO(__workflow_enableNextHopcheckNextHopAgentIsRunning);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["CheckNextHopAgentIsRunning"] = false;
                    enableNextHoppropCount++;
                }

                if (__workflow_enableNextHopnextHopDirectorAddressIsNamedPipe != null)
                {
                    if (__workflow_enableNextHopnextHopDirectorAddressIsNamedPipe != null)
                    {
                        enableNextHop["NextHopDirectorAddressIsNamedPipe"] = ExpressionConverter.ConvertO(__workflow_enableNextHopnextHopDirectorAddressIsNamedPipe);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["NextHopDirectorAddressIsNamedPipe"] = true;
                    enableNextHoppropCount++;
                }

                enableNextHoppropCount++;
                enableNextHop["Workflow"] = ExpressionConverter.ConvertO(__workflow_enableNextHopworkflow);
                if (enableNextHoppropCount > 0)
                {
                    callPayload.Body = enableNextHop;
                }

                return new ApiConnectionAction<EnableNextHopResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DisableNextHop(Expression<Func<string>> disableNextHopworkflow)
        {
            var __workflow_disableNextHopworkflow = WorkflowExpression.Compile(disableNextHopworkflow, nameof(disableNextHopworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/DisableNextHop";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var disableNextHop = new JObject();
                var disableNextHoppropCount = 0;
                disableNextHoppropCount++;
                disableNextHop["Workflow"] = ExpressionConverter.ConvertO(__workflow_disableNextHopworkflow);
                if (disableNextHoppropCount > 0)
                {
                    callPayload.Body = disableNextHop;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetNextHopStatusResponse> GetNextHopStatus(Expression<Func<string>> getNextHopStatusworkflow, Expression<Func<bool>> getNextHopStatuscheckNextHopDirectorIsRunning = null, Expression<Func<bool>> getNextHopStatuscheckNextHopAgentIsRunning = null)
        {
            var __workflow_getNextHopStatusworkflow = WorkflowExpression.Compile(getNextHopStatusworkflow, nameof(getNextHopStatusworkflow), required: true);
            var __workflow_getNextHopStatuscheckNextHopDirectorIsRunning = WorkflowExpression.Compile(getNextHopStatuscheckNextHopDirectorIsRunning, nameof(getNextHopStatuscheckNextHopDirectorIsRunning), required: false);
            var __workflow_getNextHopStatuscheckNextHopAgentIsRunning = WorkflowExpression.Compile(getNextHopStatuscheckNextHopAgentIsRunning, nameof(getNextHopStatuscheckNextHopAgentIsRunning), required: false);
            return new DeferredBodyAction<GetNextHopStatusResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetNextHopStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getNextHopStatus = new JObject();
                var getNextHopStatuspropCount = 0;
                if (__workflow_getNextHopStatuscheckNextHopDirectorIsRunning != null)
                {
                    if (__workflow_getNextHopStatuscheckNextHopDirectorIsRunning != null)
                    {
                        getNextHopStatus["CheckNextHopDirectorIsRunning"] = ExpressionConverter.ConvertO(__workflow_getNextHopStatuscheckNextHopDirectorIsRunning);
                        getNextHopStatuspropCount++;
                    }

                    getNextHopStatuspropCount++;
                }
                else
                {
                    getNextHopStatus["CheckNextHopDirectorIsRunning"] = false;
                    getNextHopStatuspropCount++;
                }

                if (__workflow_getNextHopStatuscheckNextHopAgentIsRunning != null)
                {
                    if (__workflow_getNextHopStatuscheckNextHopAgentIsRunning != null)
                    {
                        getNextHopStatus["CheckNextHopAgentIsRunning"] = ExpressionConverter.ConvertO(__workflow_getNextHopStatuscheckNextHopAgentIsRunning);
                        getNextHopStatuspropCount++;
                    }

                    getNextHopStatuspropCount++;
                }
                else
                {
                    getNextHopStatus["CheckNextHopAgentIsRunning"] = false;
                    getNextHopStatuspropCount++;
                }

                getNextHopStatuspropCount++;
                getNextHopStatus["Workflow"] = ExpressionConverter.ConvertO(__workflow_getNextHopStatusworkflow);
                if (getNextHopStatuspropCount > 0)
                {
                    callPayload.Body = getNextHopStatus;
                }

                return new ApiConnectionAction<GetNextHopStatusResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForNextHopSessionToConnectResponse> WaitForNextHopSessionToConnect(Expression<Func<string>> waitForNextHopSessionToConnectworkflow, Expression<Func<string>> waitForNextHopSessionToConnectnextHopDirectorAddress = null, Expression<Func<int>> waitForNextHopSessionToConnectnextHopDirectorTCPPort = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN = null, Expression<Func<bool>> waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId = null, Expression<Func<double>> waitForNextHopSessionToConnectsecondsToWait = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe = null, Expression<Func<bool>> waitForNextHopSessionToConnectdisableExistingNextHop = null)
        {
            var __workflow_waitForNextHopSessionToConnectworkflow = WorkflowExpression.Compile(waitForNextHopSessionToConnectworkflow, nameof(waitForNextHopSessionToConnectworkflow), required: true);
            var __workflow_waitForNextHopSessionToConnectnextHopDirectorAddress = WorkflowExpression.Compile(waitForNextHopSessionToConnectnextHopDirectorAddress, nameof(waitForNextHopSessionToConnectnextHopDirectorAddress), required: false);
            var __workflow_waitForNextHopSessionToConnectnextHopDirectorTCPPort = WorkflowExpression.Compile(waitForNextHopSessionToConnectnextHopDirectorTCPPort, nameof(waitForNextHopSessionToConnectnextHopDirectorTCPPort), required: false);
            var __workflow_waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS = WorkflowExpression.Compile(waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS, nameof(waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS), required: false);
            var __workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname = WorkflowExpression.Compile(waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname, nameof(waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname), required: false);
            var __workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname = WorkflowExpression.Compile(waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname, nameof(waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname), required: false);
            var __workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN = WorkflowExpression.Compile(waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN, nameof(waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN), required: false);
            var __workflow_waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId = WorkflowExpression.Compile(waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId, nameof(waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId), required: false);
            var __workflow_waitForNextHopSessionToConnectsecondsToWait = WorkflowExpression.Compile(waitForNextHopSessionToConnectsecondsToWait, nameof(waitForNextHopSessionToConnectsecondsToWait), required: false);
            var __workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe = WorkflowExpression.Compile(waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe, nameof(waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe), required: false);
            var __workflow_waitForNextHopSessionToConnectdisableExistingNextHop = WorkflowExpression.Compile(waitForNextHopSessionToConnectdisableExistingNextHop, nameof(waitForNextHopSessionToConnectdisableExistingNextHop), required: false);
            return new DeferredBodyAction<WaitForNextHopSessionToConnectResponse>(() =>
            {
                var apiCallPath = "/DriverControl/WaitForNextHopSessionToConnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var waitForNextHopSessionToConnect = new JObject();
                var waitForNextHopSessionToConnectpropCount = 0;
                if (__workflow_waitForNextHopSessionToConnectnextHopDirectorAddress != null)
                {
                    waitForNextHopSessionToConnect["NextHopDirectorAddress"] = ExpressionConverter.ConvertO(__workflow_waitForNextHopSessionToConnectnextHopDirectorAddress);
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (__workflow_waitForNextHopSessionToConnectnextHopDirectorTCPPort != null)
                {
                    if (__workflow_waitForNextHopSessionToConnectnextHopDirectorTCPPort != null)
                    {
                        waitForNextHopSessionToConnect["NextHopDirectorTCPPort"] = ExpressionConverter.ConvertO(__workflow_waitForNextHopSessionToConnectnextHopDirectorTCPPort);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["NextHopDirectorTCPPort"] = 8002;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (__workflow_waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS != null)
                {
                    if (__workflow_waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS != null)
                    {
                        waitForNextHopSessionToConnect["NextHopDirectorUsesHTTPS"] = ExpressionConverter.ConvertO(__workflow_waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["NextHopDirectorUsesHTTPS"] = false;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname != null)
                {
                    if (__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname != null)
                    {
                        waitForNextHopSessionToConnect["NextHopDirectorAddressIsLocalhostname"] = ExpressionConverter.ConvertO(__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["NextHopDirectorAddressIsLocalhostname"] = false;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname != null)
                {
                    if (__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname != null)
                    {
                        waitForNextHopSessionToConnect["NextHopDirectorAddressIsHostname"] = ExpressionConverter.ConvertO(__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["NextHopDirectorAddressIsHostname"] = false;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN != null)
                {
                    if (__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN != null)
                    {
                        waitForNextHopSessionToConnect["NextHopDirectorAddressIsFQDN"] = ExpressionConverter.ConvertO(__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["NextHopDirectorAddressIsFQDN"] = false;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (__workflow_waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId != null)
                {
                    if (__workflow_waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId != null)
                    {
                        waitForNextHopSessionToConnect["IncrementNextHopDirectorTCPPortBySessionId"] = ExpressionConverter.ConvertO(__workflow_waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["IncrementNextHopDirectorTCPPortBySessionId"] = true;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (__workflow_waitForNextHopSessionToConnectsecondsToWait != null)
                {
                    if (__workflow_waitForNextHopSessionToConnectsecondsToWait != null)
                    {
                        waitForNextHopSessionToConnect["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_waitForNextHopSessionToConnectsecondsToWait);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["SecondsToWait"] = 35;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe != null)
                {
                    if (__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe != null)
                    {
                        waitForNextHopSessionToConnect["NextHopDirectorAddressIsNamedPipe"] = ExpressionConverter.ConvertO(__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["NextHopDirectorAddressIsNamedPipe"] = true;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (__workflow_waitForNextHopSessionToConnectdisableExistingNextHop != null)
                {
                    if (__workflow_waitForNextHopSessionToConnectdisableExistingNextHop != null)
                    {
                        waitForNextHopSessionToConnect["DisableExistingNextHop"] = ExpressionConverter.ConvertO(__workflow_waitForNextHopSessionToConnectdisableExistingNextHop);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["DisableExistingNextHop"] = true;
                    waitForNextHopSessionToConnectpropCount++;
                }

                waitForNextHopSessionToConnectpropCount++;
                waitForNextHopSessionToConnect["Workflow"] = ExpressionConverter.ConvertO(__workflow_waitForNextHopSessionToConnectworkflow);
                if (waitForNextHopSessionToConnectpropCount > 0)
                {
                    callPayload.Body = waitForNextHopSessionToConnect;
                }

                return new ApiConnectionAction<WaitForNextHopSessionToConnectResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ConfigureNextHopDirector(Expression<Func<string>> configureNextHopDirectorworkflow, Expression<Func<bool>> configureNextHopDirectorsOAPEnabled = null, Expression<Func<bool>> configureNextHopDirectorrESTEnabled = null, Expression<Func<bool>> configureNextHopDirectorwebServerEnabled = null, Expression<Func<bool>> configureNextHopDirectordirectorIsLocalhostOnly = null, Expression<Func<int>> configureNextHopDirectorsOAPTCPPort = null, Expression<Func<int>> configureNextHopDirectorrESTTCPPort = null, Expression<Func<bool>> configureNextHopDirectorsOAPUsesHTTPS = null, Expression<Func<bool>> configureNextHopDirectorrESTUsesHTTPS = null, Expression<Func<bool>> configureNextHopDirectorincrementDirectorTCPPortBySessionId = null, Expression<Func<bool>> configureNextHopDirectorsOAPUsesUserAuthentication = null, Expression<Func<bool>> configureNextHopDirectorrESTUsesUserAuthentication = null, Expression<Func<bool>> configureNextHopDirectorcommandNamedPipeEnabled = null)
        {
            var __workflow_configureNextHopDirectorworkflow = WorkflowExpression.Compile(configureNextHopDirectorworkflow, nameof(configureNextHopDirectorworkflow), required: true);
            var __workflow_configureNextHopDirectorsOAPEnabled = WorkflowExpression.Compile(configureNextHopDirectorsOAPEnabled, nameof(configureNextHopDirectorsOAPEnabled), required: false);
            var __workflow_configureNextHopDirectorrESTEnabled = WorkflowExpression.Compile(configureNextHopDirectorrESTEnabled, nameof(configureNextHopDirectorrESTEnabled), required: false);
            var __workflow_configureNextHopDirectorwebServerEnabled = WorkflowExpression.Compile(configureNextHopDirectorwebServerEnabled, nameof(configureNextHopDirectorwebServerEnabled), required: false);
            var __workflow_configureNextHopDirectordirectorIsLocalhostOnly = WorkflowExpression.Compile(configureNextHopDirectordirectorIsLocalhostOnly, nameof(configureNextHopDirectordirectorIsLocalhostOnly), required: false);
            var __workflow_configureNextHopDirectorsOAPTCPPort = WorkflowExpression.Compile(configureNextHopDirectorsOAPTCPPort, nameof(configureNextHopDirectorsOAPTCPPort), required: false);
            var __workflow_configureNextHopDirectorrESTTCPPort = WorkflowExpression.Compile(configureNextHopDirectorrESTTCPPort, nameof(configureNextHopDirectorrESTTCPPort), required: false);
            var __workflow_configureNextHopDirectorsOAPUsesHTTPS = WorkflowExpression.Compile(configureNextHopDirectorsOAPUsesHTTPS, nameof(configureNextHopDirectorsOAPUsesHTTPS), required: false);
            var __workflow_configureNextHopDirectorrESTUsesHTTPS = WorkflowExpression.Compile(configureNextHopDirectorrESTUsesHTTPS, nameof(configureNextHopDirectorrESTUsesHTTPS), required: false);
            var __workflow_configureNextHopDirectorincrementDirectorTCPPortBySessionId = WorkflowExpression.Compile(configureNextHopDirectorincrementDirectorTCPPortBySessionId, nameof(configureNextHopDirectorincrementDirectorTCPPortBySessionId), required: false);
            var __workflow_configureNextHopDirectorsOAPUsesUserAuthentication = WorkflowExpression.Compile(configureNextHopDirectorsOAPUsesUserAuthentication, nameof(configureNextHopDirectorsOAPUsesUserAuthentication), required: false);
            var __workflow_configureNextHopDirectorrESTUsesUserAuthentication = WorkflowExpression.Compile(configureNextHopDirectorrESTUsesUserAuthentication, nameof(configureNextHopDirectorrESTUsesUserAuthentication), required: false);
            var __workflow_configureNextHopDirectorcommandNamedPipeEnabled = WorkflowExpression.Compile(configureNextHopDirectorcommandNamedPipeEnabled, nameof(configureNextHopDirectorcommandNamedPipeEnabled), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/ConfigureNextHopDirector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var configureNextHopDirector = new JObject();
                var configureNextHopDirectorpropCount = 0;
                if (__workflow_configureNextHopDirectorsOAPEnabled != null)
                {
                    if (__workflow_configureNextHopDirectorsOAPEnabled != null)
                    {
                        configureNextHopDirector["SOAPEnabled"] = ExpressionConverter.ConvertO(__workflow_configureNextHopDirectorsOAPEnabled);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["SOAPEnabled"] = false;
                    configureNextHopDirectorpropCount++;
                }

                if (__workflow_configureNextHopDirectorrESTEnabled != null)
                {
                    if (__workflow_configureNextHopDirectorrESTEnabled != null)
                    {
                        configureNextHopDirector["RESTEnabled"] = ExpressionConverter.ConvertO(__workflow_configureNextHopDirectorrESTEnabled);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["RESTEnabled"] = false;
                    configureNextHopDirectorpropCount++;
                }

                if (__workflow_configureNextHopDirectorwebServerEnabled != null)
                {
                    if (__workflow_configureNextHopDirectorwebServerEnabled != null)
                    {
                        configureNextHopDirector["WebServerEnabled"] = ExpressionConverter.ConvertO(__workflow_configureNextHopDirectorwebServerEnabled);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["WebServerEnabled"] = false;
                    configureNextHopDirectorpropCount++;
                }

                if (__workflow_configureNextHopDirectordirectorIsLocalhostOnly != null)
                {
                    if (__workflow_configureNextHopDirectordirectorIsLocalhostOnly != null)
                    {
                        configureNextHopDirector["DirectorIsLocalhostOnly"] = ExpressionConverter.ConvertO(__workflow_configureNextHopDirectordirectorIsLocalhostOnly);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["DirectorIsLocalhostOnly"] = true;
                    configureNextHopDirectorpropCount++;
                }

                if (__workflow_configureNextHopDirectorsOAPTCPPort != null)
                {
                    if (__workflow_configureNextHopDirectorsOAPTCPPort != null)
                    {
                        configureNextHopDirector["SOAPTCPPort"] = ExpressionConverter.ConvertO(__workflow_configureNextHopDirectorsOAPTCPPort);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["SOAPTCPPort"] = 8002;
                    configureNextHopDirectorpropCount++;
                }

                if (__workflow_configureNextHopDirectorrESTTCPPort != null)
                {
                    if (__workflow_configureNextHopDirectorrESTTCPPort != null)
                    {
                        configureNextHopDirector["RESTTCPPort"] = ExpressionConverter.ConvertO(__workflow_configureNextHopDirectorrESTTCPPort);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["RESTTCPPort"] = 8002;
                    configureNextHopDirectorpropCount++;
                }

                if (__workflow_configureNextHopDirectorsOAPUsesHTTPS != null)
                {
                    if (__workflow_configureNextHopDirectorsOAPUsesHTTPS != null)
                    {
                        configureNextHopDirector["SOAPUsesHTTPS"] = ExpressionConverter.ConvertO(__workflow_configureNextHopDirectorsOAPUsesHTTPS);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["SOAPUsesHTTPS"] = false;
                    configureNextHopDirectorpropCount++;
                }

                if (__workflow_configureNextHopDirectorrESTUsesHTTPS != null)
                {
                    if (__workflow_configureNextHopDirectorrESTUsesHTTPS != null)
                    {
                        configureNextHopDirector["RESTUsesHTTPS"] = ExpressionConverter.ConvertO(__workflow_configureNextHopDirectorrESTUsesHTTPS);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["RESTUsesHTTPS"] = false;
                    configureNextHopDirectorpropCount++;
                }

                if (__workflow_configureNextHopDirectorincrementDirectorTCPPortBySessionId != null)
                {
                    if (__workflow_configureNextHopDirectorincrementDirectorTCPPortBySessionId != null)
                    {
                        configureNextHopDirector["IncrementDirectorTCPPortBySessionId"] = ExpressionConverter.ConvertO(__workflow_configureNextHopDirectorincrementDirectorTCPPortBySessionId);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["IncrementDirectorTCPPortBySessionId"] = true;
                    configureNextHopDirectorpropCount++;
                }

                if (__workflow_configureNextHopDirectorsOAPUsesUserAuthentication != null)
                {
                    if (__workflow_configureNextHopDirectorsOAPUsesUserAuthentication != null)
                    {
                        configureNextHopDirector["SOAPUsesUserAuthentication"] = ExpressionConverter.ConvertO(__workflow_configureNextHopDirectorsOAPUsesUserAuthentication);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["SOAPUsesUserAuthentication"] = false;
                    configureNextHopDirectorpropCount++;
                }

                if (__workflow_configureNextHopDirectorrESTUsesUserAuthentication != null)
                {
                    if (__workflow_configureNextHopDirectorrESTUsesUserAuthentication != null)
                    {
                        configureNextHopDirector["RESTUsesUserAuthentication"] = ExpressionConverter.ConvertO(__workflow_configureNextHopDirectorrESTUsesUserAuthentication);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["RESTUsesUserAuthentication"] = false;
                    configureNextHopDirectorpropCount++;
                }

                if (__workflow_configureNextHopDirectorcommandNamedPipeEnabled != null)
                {
                    if (__workflow_configureNextHopDirectorcommandNamedPipeEnabled != null)
                    {
                        configureNextHopDirector["CommandNamedPipeEnabled"] = ExpressionConverter.ConvertO(__workflow_configureNextHopDirectorcommandNamedPipeEnabled);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["CommandNamedPipeEnabled"] = true;
                    configureNextHopDirectorpropCount++;
                }

                configureNextHopDirectorpropCount++;
                configureNextHopDirector["Workflow"] = ExpressionConverter.ConvertO(__workflow_configureNextHopDirectorworkflow);
                if (configureNextHopDirectorpropCount > 0)
                {
                    callPayload.Body = configureNextHopDirector;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ResetNextHopDirectorSettings(Expression<Func<string>> resetNextHopDirectorSettingsworkflow)
        {
            var __workflow_resetNextHopDirectorSettingsworkflow = WorkflowExpression.Compile(resetNextHopDirectorSettingsworkflow, nameof(resetNextHopDirectorSettingsworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/ResetNextHopDirectorSettings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var resetNextHopDirectorSettings = new JObject();
                var resetNextHopDirectorSettingspropCount = 0;
                resetNextHopDirectorSettingspropCount++;
                resetNextHopDirectorSettings["Workflow"] = ExpressionConverter.ConvertO(__workflow_resetNextHopDirectorSettingsworkflow);
                if (resetNextHopDirectorSettingspropCount > 0)
                {
                    callPayload.Body = resetNextHopDirectorSettings;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WorkflowCompleted(Expression<Func<string>> workflowCompletedworkflow)
        {
            var __workflow_workflowCompletedworkflow = WorkflowExpression.Compile(workflowCompletedworkflow, nameof(workflowCompletedworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/WorkflowCompleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var workflowCompleted = new JObject();
                var workflowCompletedpropCount = 0;
                workflowCompletedpropCount++;
                workflowCompleted["Workflow"] = ExpressionConverter.ConvertO(__workflow_workflowCompletedworkflow);
                if (workflowCompletedpropCount > 0)
                {
                    callPayload.Body = workflowCompleted;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RaiseExceptionResponse> RaiseException(Expression<Func<string>> raiseExceptioninputException = null, Expression<Func<string>> raiseExceptionexceptionMessage = null)
        {
            var __workflow_raiseExceptioninputException = WorkflowExpression.Compile(raiseExceptioninputException, nameof(raiseExceptioninputException), required: false);
            var __workflow_raiseExceptionexceptionMessage = WorkflowExpression.Compile(raiseExceptionexceptionMessage, nameof(raiseExceptionexceptionMessage), required: false);
            return new DeferredBodyAction<RaiseExceptionResponse>(() =>
            {
                var apiCallPath = "/DriverControl/RaiseException";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var raiseException = new JObject();
                var raiseExceptionpropCount = 0;
                if (__workflow_raiseExceptioninputException != null)
                {
                    raiseException["InputException"] = ExpressionConverter.ConvertO(__workflow_raiseExceptioninputException);
                    raiseExceptionpropCount++;
                }

                if (__workflow_raiseExceptionexceptionMessage != null)
                {
                    raiseException["ExceptionMessage"] = ExpressionConverter.ConvertO(__workflow_raiseExceptionexceptionMessage);
                    raiseExceptionpropCount++;
                }

                if (raiseExceptionpropCount > 0)
                {
                    callPayload.Body = raiseException;
                }

                return new ApiConnectionAction<RaiseExceptionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UpdateOrchestratorFlowStatsResultResponse> UpdateOrchestratorFlowStatsResult(Expression<Func<string>> updateOrchestratorFlowStatsResultworkflow, Expression<Func<bool>> updateOrchestratorFlowStatsResultflowLastActionSuccess = null, Expression<Func<string>> updateOrchestratorFlowStatsResultflowLastActionErrorMessage = null, Expression<Func<int>> updateOrchestratorFlowStatsResultflowLastActionCode = null)
        {
            var __workflow_updateOrchestratorFlowStatsResultworkflow = WorkflowExpression.Compile(updateOrchestratorFlowStatsResultworkflow, nameof(updateOrchestratorFlowStatsResultworkflow), required: true);
            var __workflow_updateOrchestratorFlowStatsResultflowLastActionSuccess = WorkflowExpression.Compile(updateOrchestratorFlowStatsResultflowLastActionSuccess, nameof(updateOrchestratorFlowStatsResultflowLastActionSuccess), required: false);
            var __workflow_updateOrchestratorFlowStatsResultflowLastActionErrorMessage = WorkflowExpression.Compile(updateOrchestratorFlowStatsResultflowLastActionErrorMessage, nameof(updateOrchestratorFlowStatsResultflowLastActionErrorMessage), required: false);
            var __workflow_updateOrchestratorFlowStatsResultflowLastActionCode = WorkflowExpression.Compile(updateOrchestratorFlowStatsResultflowLastActionCode, nameof(updateOrchestratorFlowStatsResultflowLastActionCode), required: false);
            return new DeferredBodyAction<UpdateOrchestratorFlowStatsResultResponse>(() =>
            {
                var apiCallPath = "/DriverControl/UpdateOrchestratorFlowStatsResult";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var updateOrchestratorFlowStatsResult = new JObject();
                var updateOrchestratorFlowStatsResultpropCount = 0;
                if (__workflow_updateOrchestratorFlowStatsResultflowLastActionSuccess != null)
                {
                    updateOrchestratorFlowStatsResult["FlowLastActionSuccess"] = ExpressionConverter.ConvertO(__workflow_updateOrchestratorFlowStatsResultflowLastActionSuccess);
                    updateOrchestratorFlowStatsResultpropCount++;
                }

                if (__workflow_updateOrchestratorFlowStatsResultflowLastActionErrorMessage != null)
                {
                    updateOrchestratorFlowStatsResult["FlowLastActionErrorMessage"] = ExpressionConverter.ConvertO(__workflow_updateOrchestratorFlowStatsResultflowLastActionErrorMessage);
                    updateOrchestratorFlowStatsResultpropCount++;
                }

                if (__workflow_updateOrchestratorFlowStatsResultflowLastActionCode != null)
                {
                    updateOrchestratorFlowStatsResult["FlowLastActionCode"] = ExpressionConverter.ConvertO(__workflow_updateOrchestratorFlowStatsResultflowLastActionCode);
                    updateOrchestratorFlowStatsResultpropCount++;
                }

                updateOrchestratorFlowStatsResultpropCount++;
                updateOrchestratorFlowStatsResult["Workflow"] = ExpressionConverter.ConvertO(__workflow_updateOrchestratorFlowStatsResultworkflow);
                if (updateOrchestratorFlowStatsResultpropCount > 0)
                {
                    callPayload.Body = updateOrchestratorFlowStatsResult;
                }

                return new ApiConnectionAction<UpdateOrchestratorFlowStatsResultResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLastFailedActionFromOrchestratorFlowStatsResponse> GetLastFailedActionFromOrchestratorFlowStats(Expression<Func<string>> getLastFailedActionFromOrchestratorFlowStatsworkflow)
        {
            var __workflow_getLastFailedActionFromOrchestratorFlowStatsworkflow = WorkflowExpression.Compile(getLastFailedActionFromOrchestratorFlowStatsworkflow, nameof(getLastFailedActionFromOrchestratorFlowStatsworkflow), required: true);
            return new DeferredBodyAction<GetLastFailedActionFromOrchestratorFlowStatsResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetLastFailedActionFromOrchestratorFlowStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getLastFailedActionFromOrchestratorFlowStats = new JObject();
                var getLastFailedActionFromOrchestratorFlowStatspropCount = 0;
                getLastFailedActionFromOrchestratorFlowStatspropCount++;
                getLastFailedActionFromOrchestratorFlowStats["Workflow"] = ExpressionConverter.ConvertO(__workflow_getLastFailedActionFromOrchestratorFlowStatsworkflow);
                if (getLastFailedActionFromOrchestratorFlowStatspropCount > 0)
                {
                    callPayload.Body = getLastFailedActionFromOrchestratorFlowStats;
                }

                return new ApiConnectionAction<GetLastFailedActionFromOrchestratorFlowStatsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorFlowStatsResponse> GetOrchestratorFlowStats(Expression<Func<int>> getOrchestratorFlowStatswithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorFlowStatssearchFlowName = null, Expression<Func<bool>> getOrchestratorFlowStatssearchFlowLastActionResult = null, Expression<Func<string>> getOrchestratorFlowStatssearchFlowStartTimeStartWindow = null, Expression<Func<string>> getOrchestratorFlowStatssearchFlowStartTimeEndWindow = null)
        {
            var __workflow_getOrchestratorFlowStatswithinLastNumberOfDays = WorkflowExpression.Compile(getOrchestratorFlowStatswithinLastNumberOfDays, nameof(getOrchestratorFlowStatswithinLastNumberOfDays), required: false);
            var __workflow_getOrchestratorFlowStatssearchFlowName = WorkflowExpression.Compile(getOrchestratorFlowStatssearchFlowName, nameof(getOrchestratorFlowStatssearchFlowName), required: false);
            var __workflow_getOrchestratorFlowStatssearchFlowLastActionResult = WorkflowExpression.Compile(getOrchestratorFlowStatssearchFlowLastActionResult, nameof(getOrchestratorFlowStatssearchFlowLastActionResult), required: false);
            var __workflow_getOrchestratorFlowStatssearchFlowStartTimeStartWindow = WorkflowExpression.Compile(getOrchestratorFlowStatssearchFlowStartTimeStartWindow, nameof(getOrchestratorFlowStatssearchFlowStartTimeStartWindow), required: false);
            var __workflow_getOrchestratorFlowStatssearchFlowStartTimeEndWindow = WorkflowExpression.Compile(getOrchestratorFlowStatssearchFlowStartTimeEndWindow, nameof(getOrchestratorFlowStatssearchFlowStartTimeEndWindow), required: false);
            return new DeferredBodyAction<GetOrchestratorFlowStatsResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorFlowStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getOrchestratorFlowStats = new JObject();
                var getOrchestratorFlowStatspropCount = 0;
                if (__workflow_getOrchestratorFlowStatswithinLastNumberOfDays != null)
                {
                    getOrchestratorFlowStats["WithinLastNumberOfDays"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorFlowStatswithinLastNumberOfDays);
                    getOrchestratorFlowStatspropCount++;
                }

                if (__workflow_getOrchestratorFlowStatssearchFlowName != null)
                {
                    getOrchestratorFlowStats["SearchFlowName"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorFlowStatssearchFlowName);
                    getOrchestratorFlowStatspropCount++;
                }

                if (__workflow_getOrchestratorFlowStatssearchFlowLastActionResult != null)
                {
                    getOrchestratorFlowStats["SearchFlowLastActionResult"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorFlowStatssearchFlowLastActionResult);
                    getOrchestratorFlowStatspropCount++;
                }

                if (__workflow_getOrchestratorFlowStatssearchFlowStartTimeStartWindow != null)
                {
                    getOrchestratorFlowStats["SearchFlowStartTimeStartWindow"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorFlowStatssearchFlowStartTimeStartWindow);
                    getOrchestratorFlowStatspropCount++;
                }

                if (__workflow_getOrchestratorFlowStatssearchFlowStartTimeEndWindow != null)
                {
                    getOrchestratorFlowStats["SearchFlowStartTimeEndWindow"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorFlowStatssearchFlowStartTimeEndWindow);
                    getOrchestratorFlowStatspropCount++;
                }

                if (getOrchestratorFlowStatspropCount > 0)
                {
                    callPayload.Body = getOrchestratorFlowStats;
                }

                return new ApiConnectionAction<GetOrchestratorFlowStatsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerAvailabilityStatsResponse> GetOrchestratorWorkerAvailabilityStats(Expression<Func<int>> getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorWorkerAvailabilityStatssearchFlowName = null, Expression<Func<string>> getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow = null)
        {
            var __workflow_getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays = WorkflowExpression.Compile(getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays, nameof(getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays), required: false);
            var __workflow_getOrchestratorWorkerAvailabilityStatssearchFlowName = WorkflowExpression.Compile(getOrchestratorWorkerAvailabilityStatssearchFlowName, nameof(getOrchestratorWorkerAvailabilityStatssearchFlowName), required: false);
            var __workflow_getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow = WorkflowExpression.Compile(getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow, nameof(getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow), required: false);
            return new DeferredBodyAction<GetOrchestratorWorkerAvailabilityStatsResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorWorkerAvailabilityStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getOrchestratorWorkerAvailabilityStats = new JObject();
                var getOrchestratorWorkerAvailabilityStatspropCount = 0;
                if (__workflow_getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays != null)
                {
                    getOrchestratorWorkerAvailabilityStats["WithinLastNumberOfDays"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays);
                    getOrchestratorWorkerAvailabilityStatspropCount++;
                }

                if (__workflow_getOrchestratorWorkerAvailabilityStatssearchFlowName != null)
                {
                    getOrchestratorWorkerAvailabilityStats["SearchFlowName"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorWorkerAvailabilityStatssearchFlowName);
                    getOrchestratorWorkerAvailabilityStatspropCount++;
                }

                if (__workflow_getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow != null)
                {
                    getOrchestratorWorkerAvailabilityStats["SearchFlowStartTimeStartWindow"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow);
                    getOrchestratorWorkerAvailabilityStatspropCount++;
                }

                if (getOrchestratorWorkerAvailabilityStatspropCount > 0)
                {
                    callPayload.Body = getOrchestratorWorkerAvailabilityStats;
                }

                return new ApiConnectionAction<GetOrchestratorWorkerAvailabilityStatsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerFlowUsageHeatmapResponse> GetOrchestratorWorkerFlowUsageHeatmap(Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow, Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow, Expression<Func<int>> getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC = null, Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapworkerNames = null)
        {
            var __workflow_getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow = WorkflowExpression.Compile(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow, nameof(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow), required: true);
            var __workflow_getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow = WorkflowExpression.Compile(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow, nameof(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow), required: true);
            var __workflow_getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC = WorkflowExpression.Compile(getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC, nameof(getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC), required: false);
            var __workflow_getOrchestratorWorkerFlowUsageHeatmapworkerNames = WorkflowExpression.Compile(getOrchestratorWorkerFlowUsageHeatmapworkerNames, nameof(getOrchestratorWorkerFlowUsageHeatmapworkerNames), required: false);
            return new DeferredBodyAction<GetOrchestratorWorkerFlowUsageHeatmapResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorWorkerFlowUsageHeatmap";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getOrchestratorWorkerFlowUsageHeatmap = new JObject();
                var getOrchestratorWorkerFlowUsageHeatmappropCount = 0;
                getOrchestratorWorkerFlowUsageHeatmappropCount++;
                getOrchestratorWorkerFlowUsageHeatmap["SearchStartDateStartWindow"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow);
                getOrchestratorWorkerFlowUsageHeatmappropCount++;
                getOrchestratorWorkerFlowUsageHeatmap["SearchStartDateEndWindow"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow);
                if (__workflow_getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC != null)
                {
                    if (__workflow_getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC != null)
                    {
                        getOrchestratorWorkerFlowUsageHeatmap["TimeZoneMinutesOffsetFromUTC"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC);
                        getOrchestratorWorkerFlowUsageHeatmappropCount++;
                    }

                    getOrchestratorWorkerFlowUsageHeatmappropCount++;
                }
                else
                {
                    getOrchestratorWorkerFlowUsageHeatmap["TimeZoneMinutesOffsetFromUTC"] = 0;
                    getOrchestratorWorkerFlowUsageHeatmappropCount++;
                }

                if (__workflow_getOrchestratorWorkerFlowUsageHeatmapworkerNames != null)
                {
                    getOrchestratorWorkerFlowUsageHeatmap["WorkerNames"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorWorkerFlowUsageHeatmapworkerNames);
                    getOrchestratorWorkerFlowUsageHeatmappropCount++;
                }

                if (getOrchestratorWorkerFlowUsageHeatmappropCount > 0)
                {
                    callPayload.Body = getOrchestratorWorkerFlowUsageHeatmap;
                }

                return new ApiConnectionAction<GetOrchestratorWorkerFlowUsageHeatmapResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorLoginHistoryResponse> GetOrchestratorLoginHistory(Expression<Func<int>> getOrchestratorLoginHistorywithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorLoginHistorysearchByEmail = null, Expression<Func<string>> getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow = null, Expression<Func<string>> getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow = null)
        {
            var __workflow_getOrchestratorLoginHistorywithinLastNumberOfDays = WorkflowExpression.Compile(getOrchestratorLoginHistorywithinLastNumberOfDays, nameof(getOrchestratorLoginHistorywithinLastNumberOfDays), required: false);
            var __workflow_getOrchestratorLoginHistorysearchByEmail = WorkflowExpression.Compile(getOrchestratorLoginHistorysearchByEmail, nameof(getOrchestratorLoginHistorysearchByEmail), required: false);
            var __workflow_getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow = WorkflowExpression.Compile(getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow, nameof(getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow), required: false);
            var __workflow_getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow = WorkflowExpression.Compile(getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow, nameof(getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow), required: false);
            return new DeferredBodyAction<GetOrchestratorLoginHistoryResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorLoginHistory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getOrchestratorLoginHistory = new JObject();
                var getOrchestratorLoginHistorypropCount = 0;
                if (__workflow_getOrchestratorLoginHistorywithinLastNumberOfDays != null)
                {
                    getOrchestratorLoginHistory["WithinLastNumberOfDays"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorLoginHistorywithinLastNumberOfDays);
                    getOrchestratorLoginHistorypropCount++;
                }

                if (__workflow_getOrchestratorLoginHistorysearchByEmail != null)
                {
                    getOrchestratorLoginHistory["SearchByEmail"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorLoginHistorysearchByEmail);
                    getOrchestratorLoginHistorypropCount++;
                }

                if (__workflow_getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow != null)
                {
                    getOrchestratorLoginHistory["SearchLoginHistoryTimeStartWindow"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow);
                    getOrchestratorLoginHistorypropCount++;
                }

                if (__workflow_getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow != null)
                {
                    getOrchestratorLoginHistory["SearchLoginHistoryTimeEndWindow"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow);
                    getOrchestratorLoginHistorypropCount++;
                }

                if (getOrchestratorLoginHistorypropCount > 0)
                {
                    callPayload.Body = getOrchestratorLoginHistory;
                }

                return new ApiConnectionAction<GetOrchestratorLoginHistoryResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetLocalLoggingLevel(Expression<Func<int>> setLocalLoggingLevelloggingLevel, Expression<Func<string>> setLocalLoggingLevelworkflow)
        {
            var __workflow_setLocalLoggingLevelloggingLevel = WorkflowExpression.Compile(setLocalLoggingLevelloggingLevel, nameof(setLocalLoggingLevelloggingLevel), required: true);
            var __workflow_setLocalLoggingLevelworkflow = WorkflowExpression.Compile(setLocalLoggingLevelworkflow, nameof(setLocalLoggingLevelworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/SetLocalLoggingLevel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setLocalLoggingLevel = new JObject();
                var setLocalLoggingLevelpropCount = 0;
                setLocalLoggingLevelpropCount++;
                setLocalLoggingLevel["LoggingLevel"] = ExpressionConverter.ConvertO(__workflow_setLocalLoggingLevelloggingLevel);
                setLocalLoggingLevelpropCount++;
                setLocalLoggingLevel["Workflow"] = ExpressionConverter.ConvertO(__workflow_setLocalLoggingLevelworkflow);
                if (setLocalLoggingLevelpropCount > 0)
                {
                    callPayload.Body = setLocalLoggingLevel;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunCommandResponse> RunCommand(Expression<Func<string>> runCommandcommandName, Expression<Func<string>> runCommandworkflow, Expression<Func<string>> runCommandinputJSON = null)
        {
            var __workflow_runCommandcommandName = WorkflowExpression.Compile(runCommandcommandName, nameof(runCommandcommandName), required: true);
            var __workflow_runCommandworkflow = WorkflowExpression.Compile(runCommandworkflow, nameof(runCommandworkflow), required: true);
            var __workflow_runCommandinputJSON = WorkflowExpression.Compile(runCommandinputJSON, nameof(runCommandinputJSON), required: false);
            return new DeferredBodyAction<RunCommandResponse>(() =>
            {
                var apiCallPath = "/DriverControl/RunCommand";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runCommand = new JObject();
                var runCommandpropCount = 0;
                runCommandpropCount++;
                runCommand["CommandName"] = ExpressionConverter.ConvertO(__workflow_runCommandcommandName);
                if (__workflow_runCommandinputJSON != null)
                {
                    runCommand["InputJSON"] = ExpressionConverter.ConvertO(__workflow_runCommandinputJSON);
                    runCommandpropCount++;
                }

                runCommandpropCount++;
                runCommand["Workflow"] = ExpressionConverter.ConvertO(__workflow_runCommandworkflow);
                if (runCommandpropCount > 0)
                {
                    callPayload.Body = runCommand;
                }

                return new ApiConnectionAction<RunCommandResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLocalLoggingLevelResponse> GetLocalLoggingLevel(Expression<Func<string>> getLocalLoggingLevelworkflow)
        {
            var __workflow_getLocalLoggingLevelworkflow = WorkflowExpression.Compile(getLocalLoggingLevelworkflow, nameof(getLocalLoggingLevelworkflow), required: true);
            return new DeferredBodyAction<GetLocalLoggingLevelResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetLocalLoggingLevel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getLocalLoggingLevel = new JObject();
                var getLocalLoggingLevelpropCount = 0;
                getLocalLoggingLevelpropCount++;
                getLocalLoggingLevel["Workflow"] = ExpressionConverter.ConvertO(__workflow_getLocalLoggingLevelworkflow);
                if (getLocalLoggingLevelpropCount > 0)
                {
                    callPayload.Body = getLocalLoggingLevel;
                }

                return new ApiConnectionAction<GetLocalLoggingLevelResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteClientTypeResponse> GetRemoteClientType(Expression<Func<string>> getRemoteClientTypeworkflow)
        {
            var __workflow_getRemoteClientTypeworkflow = WorkflowExpression.Compile(getRemoteClientTypeworkflow, nameof(getRemoteClientTypeworkflow), required: true);
            return new DeferredBodyAction<GetRemoteClientTypeResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetRemoteClientType";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRemoteClientType = new JObject();
                var getRemoteClientTypepropCount = 0;
                getRemoteClientTypepropCount++;
                getRemoteClientType["Workflow"] = ExpressionConverter.ConvertO(__workflow_getRemoteClientTypeworkflow);
                if (getRemoteClientTypepropCount > 0)
                {
                    callPayload.Body = getRemoteClientType;
                }

                return new ApiConnectionAction<GetRemoteClientTypeResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectDirectorInfoResponse> GetIAConnectDirectorInfo(Expression<Func<string>> getIAConnectDirectorInfoworkflow)
        {
            var __workflow_getIAConnectDirectorInfoworkflow = WorkflowExpression.Compile(getIAConnectDirectorInfoworkflow, nameof(getIAConnectDirectorInfoworkflow), required: true);
            return new DeferredBodyAction<GetIAConnectDirectorInfoResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetIAConnectDirectorInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectDirectorInfo = new JObject();
                var getIAConnectDirectorInfopropCount = 0;
                getIAConnectDirectorInfopropCount++;
                getIAConnectDirectorInfo["Workflow"] = ExpressionConverter.ConvertO(__workflow_getIAConnectDirectorInfoworkflow);
                if (getIAConnectDirectorInfopropCount > 0)
                {
                    callPayload.Body = getIAConnectDirectorInfo;
                }

                return new ApiConnectionAction<GetIAConnectDirectorInfoResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAvailableIAConnectSessionsResponse> GetAvailableIAConnectSessions(Expression<Func<string>> getAvailableIAConnectSessionsworkflow)
        {
            var __workflow_getAvailableIAConnectSessionsworkflow = WorkflowExpression.Compile(getAvailableIAConnectSessionsworkflow, nameof(getAvailableIAConnectSessionsworkflow), required: true);
            return new DeferredBodyAction<GetAvailableIAConnectSessionsResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetAvailableIAConnectSessions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getAvailableIAConnectSessions = new JObject();
                var getAvailableIAConnectSessionspropCount = 0;
                getAvailableIAConnectSessionspropCount++;
                getAvailableIAConnectSessions["Workflow"] = ExpressionConverter.ConvertO(__workflow_getAvailableIAConnectSessionsworkflow);
                if (getAvailableIAConnectSessionspropCount > 0)
                {
                    callPayload.Body = getAvailableIAConnectSessions;
                }

                return new ApiConnectionAction<GetAvailableIAConnectSessionsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AttachToIAConnectSessionByName(Expression<Func<string>> attachToIAConnectSessionByNameiAConnectSessionName, Expression<Func<string>> attachToIAConnectSessionByNameworkflow, Expression<Func<bool>> attachToIAConnectSessionByNamevirtualChannelMustBeConnected = null)
        {
            var __workflow_attachToIAConnectSessionByNameiAConnectSessionName = WorkflowExpression.Compile(attachToIAConnectSessionByNameiAConnectSessionName, nameof(attachToIAConnectSessionByNameiAConnectSessionName), required: true);
            var __workflow_attachToIAConnectSessionByNameworkflow = WorkflowExpression.Compile(attachToIAConnectSessionByNameworkflow, nameof(attachToIAConnectSessionByNameworkflow), required: true);
            var __workflow_attachToIAConnectSessionByNamevirtualChannelMustBeConnected = WorkflowExpression.Compile(attachToIAConnectSessionByNamevirtualChannelMustBeConnected, nameof(attachToIAConnectSessionByNamevirtualChannelMustBeConnected), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/AttachToIAConnectSessionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var attachToIAConnectSessionByName = new JObject();
                var attachToIAConnectSessionByNamepropCount = 0;
                attachToIAConnectSessionByNamepropCount++;
                attachToIAConnectSessionByName["IAConnectSessionName"] = ExpressionConverter.ConvertO(__workflow_attachToIAConnectSessionByNameiAConnectSessionName);
                if (__workflow_attachToIAConnectSessionByNamevirtualChannelMustBeConnected != null)
                {
                    if (__workflow_attachToIAConnectSessionByNamevirtualChannelMustBeConnected != null)
                    {
                        attachToIAConnectSessionByName["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(__workflow_attachToIAConnectSessionByNamevirtualChannelMustBeConnected);
                        attachToIAConnectSessionByNamepropCount++;
                    }

                    attachToIAConnectSessionByNamepropCount++;
                }
                else
                {
                    attachToIAConnectSessionByName["VirtualChannelMustBeConnected"] = true;
                    attachToIAConnectSessionByNamepropCount++;
                }

                attachToIAConnectSessionByNamepropCount++;
                attachToIAConnectSessionByName["Workflow"] = ExpressionConverter.ConvertO(__workflow_attachToIAConnectSessionByNameworkflow);
                if (attachToIAConnectSessionByNamepropCount > 0)
                {
                    callPayload.Body = attachToIAConnectSessionByName;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToTier1IAConnectSessionResponse> AttachToTier1IAConnectSession(Expression<Func<string>> attachToTier1IAConnectSessionworkflow, Expression<Func<bool>> attachToTier1IAConnectSessionvirtualChannelMustBeConnected = null)
        {
            var __workflow_attachToTier1IAConnectSessionworkflow = WorkflowExpression.Compile(attachToTier1IAConnectSessionworkflow, nameof(attachToTier1IAConnectSessionworkflow), required: true);
            var __workflow_attachToTier1IAConnectSessionvirtualChannelMustBeConnected = WorkflowExpression.Compile(attachToTier1IAConnectSessionvirtualChannelMustBeConnected, nameof(attachToTier1IAConnectSessionvirtualChannelMustBeConnected), required: false);
            return new DeferredBodyAction<AttachToTier1IAConnectSessionResponse>(() =>
            {
                var apiCallPath = "/DriverControl/AttachToTier1IAConnectSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var attachToTier1IAConnectSession = new JObject();
                var attachToTier1IAConnectSessionpropCount = 0;
                if (__workflow_attachToTier1IAConnectSessionvirtualChannelMustBeConnected != null)
                {
                    if (__workflow_attachToTier1IAConnectSessionvirtualChannelMustBeConnected != null)
                    {
                        attachToTier1IAConnectSession["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(__workflow_attachToTier1IAConnectSessionvirtualChannelMustBeConnected);
                        attachToTier1IAConnectSessionpropCount++;
                    }

                    attachToTier1IAConnectSessionpropCount++;
                }
                else
                {
                    attachToTier1IAConnectSession["VirtualChannelMustBeConnected"] = true;
                    attachToTier1IAConnectSessionpropCount++;
                }

                attachToTier1IAConnectSessionpropCount++;
                attachToTier1IAConnectSession["Workflow"] = ExpressionConverter.ConvertO(__workflow_attachToTier1IAConnectSessionworkflow);
                if (attachToTier1IAConnectSessionpropCount > 0)
                {
                    callPayload.Body = attachToTier1IAConnectSession;
                }

                return new ApiConnectionAction<AttachToTier1IAConnectSessionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToIAConnectSessionByIndexResponse> AttachToIAConnectSessionByIndex(Expression<Func<string>> attachToIAConnectSessionByIndexworkflow, Expression<Func<attachToIAConnectSessionByIndexsearchIAConnectSessionTypeInput>> attachToIAConnectSessionByIndexsearchIAConnectSessionType = null, Expression<Func<int>> attachToIAConnectSessionByIndexsearchIAConnectSessionIndex = null, Expression<Func<int>> attachToIAConnectSessionByIndextimeToWaitInSeconds = null, Expression<Func<bool>> attachToIAConnectSessionByIndexraiseExceptionIfTimedout = null, Expression<Func<bool>> attachToIAConnectSessionByIndexvirtualChannelMustBeConnected = null, Expression<Func<bool>> attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore = null)
        {
            var __workflow_attachToIAConnectSessionByIndexworkflow = WorkflowExpression.Compile(attachToIAConnectSessionByIndexworkflow, nameof(attachToIAConnectSessionByIndexworkflow), required: true);
            var __workflow_attachToIAConnectSessionByIndexsearchIAConnectSessionType = WorkflowExpression.Compile(attachToIAConnectSessionByIndexsearchIAConnectSessionType, nameof(attachToIAConnectSessionByIndexsearchIAConnectSessionType), required: false);
            var __workflow_attachToIAConnectSessionByIndexsearchIAConnectSessionIndex = WorkflowExpression.Compile(attachToIAConnectSessionByIndexsearchIAConnectSessionIndex, nameof(attachToIAConnectSessionByIndexsearchIAConnectSessionIndex), required: false);
            var __workflow_attachToIAConnectSessionByIndextimeToWaitInSeconds = WorkflowExpression.Compile(attachToIAConnectSessionByIndextimeToWaitInSeconds, nameof(attachToIAConnectSessionByIndextimeToWaitInSeconds), required: false);
            var __workflow_attachToIAConnectSessionByIndexraiseExceptionIfTimedout = WorkflowExpression.Compile(attachToIAConnectSessionByIndexraiseExceptionIfTimedout, nameof(attachToIAConnectSessionByIndexraiseExceptionIfTimedout), required: false);
            var __workflow_attachToIAConnectSessionByIndexvirtualChannelMustBeConnected = WorkflowExpression.Compile(attachToIAConnectSessionByIndexvirtualChannelMustBeConnected, nameof(attachToIAConnectSessionByIndexvirtualChannelMustBeConnected), required: false);
            var __workflow_attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore = WorkflowExpression.Compile(attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore, nameof(attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore), required: false);
            return new DeferredBodyAction<AttachToIAConnectSessionByIndexResponse>(() =>
            {
                var apiCallPath = "/DriverControl/AttachToIAConnectSessionByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var attachToIAConnectSessionByIndex = new JObject();
                var attachToIAConnectSessionByIndexpropCount = 0;
                if (__workflow_attachToIAConnectSessionByIndexsearchIAConnectSessionType != null)
                {
                    attachToIAConnectSessionByIndex["SearchIAConnectSessionType"] = ExpressionConverter.ConvertO(__workflow_attachToIAConnectSessionByIndexsearchIAConnectSessionType);
                    attachToIAConnectSessionByIndexpropCount++;
                }

                if (__workflow_attachToIAConnectSessionByIndexsearchIAConnectSessionIndex != null)
                {
                    attachToIAConnectSessionByIndex["SearchIAConnectSessionIndex"] = ExpressionConverter.ConvertO(__workflow_attachToIAConnectSessionByIndexsearchIAConnectSessionIndex);
                    attachToIAConnectSessionByIndexpropCount++;
                }

                if (__workflow_attachToIAConnectSessionByIndextimeToWaitInSeconds != null)
                {
                    attachToIAConnectSessionByIndex["TimeToWaitInSeconds"] = ExpressionConverter.ConvertO(__workflow_attachToIAConnectSessionByIndextimeToWaitInSeconds);
                    attachToIAConnectSessionByIndexpropCount++;
                }

                if (__workflow_attachToIAConnectSessionByIndexraiseExceptionIfTimedout != null)
                {
                    if (__workflow_attachToIAConnectSessionByIndexraiseExceptionIfTimedout != null)
                    {
                        attachToIAConnectSessionByIndex["RaiseExceptionIfTimedout"] = ExpressionConverter.ConvertO(__workflow_attachToIAConnectSessionByIndexraiseExceptionIfTimedout);
                        attachToIAConnectSessionByIndexpropCount++;
                    }

                    attachToIAConnectSessionByIndexpropCount++;
                }
                else
                {
                    attachToIAConnectSessionByIndex["RaiseExceptionIfTimedout"] = true;
                    attachToIAConnectSessionByIndexpropCount++;
                }

                if (__workflow_attachToIAConnectSessionByIndexvirtualChannelMustBeConnected != null)
                {
                    if (__workflow_attachToIAConnectSessionByIndexvirtualChannelMustBeConnected != null)
                    {
                        attachToIAConnectSessionByIndex["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(__workflow_attachToIAConnectSessionByIndexvirtualChannelMustBeConnected);
                        attachToIAConnectSessionByIndexpropCount++;
                    }

                    attachToIAConnectSessionByIndexpropCount++;
                }
                else
                {
                    attachToIAConnectSessionByIndex["VirtualChannelMustBeConnected"] = true;
                    attachToIAConnectSessionByIndexpropCount++;
                }

                if (__workflow_attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore != null)
                {
                    if (__workflow_attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore != null)
                    {
                        attachToIAConnectSessionByIndex["OnlyCountSessionsNotSeenBefore"] = ExpressionConverter.ConvertO(__workflow_attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore);
                        attachToIAConnectSessionByIndexpropCount++;
                    }

                    attachToIAConnectSessionByIndexpropCount++;
                }
                else
                {
                    attachToIAConnectSessionByIndex["OnlyCountSessionsNotSeenBefore"] = false;
                    attachToIAConnectSessionByIndexpropCount++;
                }

                attachToIAConnectSessionByIndexpropCount++;
                attachToIAConnectSessionByIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_attachToIAConnectSessionByIndexworkflow);
                if (attachToIAConnectSessionByIndexpropCount > 0)
                {
                    callPayload.Body = attachToIAConnectSessionByIndex;
                }

                return new ApiConnectionAction<AttachToIAConnectSessionByIndexResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToMostRecentIAConnectSessionResponse> AttachToMostRecentIAConnectSession(Expression<Func<string>> attachToMostRecentIAConnectSessionworkflow, Expression<Func<attachToMostRecentIAConnectSessionsearchIAConnectSessionTypeInput>> attachToMostRecentIAConnectSessionsearchIAConnectSessionType = null, Expression<Func<int>> attachToMostRecentIAConnectSessiontimeToWaitInSeconds = null, Expression<Func<bool>> attachToMostRecentIAConnectSessionraiseExceptionIfTimedout = null, Expression<Func<bool>> attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected = null, Expression<Func<bool>> attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore = null)
        {
            var __workflow_attachToMostRecentIAConnectSessionworkflow = WorkflowExpression.Compile(attachToMostRecentIAConnectSessionworkflow, nameof(attachToMostRecentIAConnectSessionworkflow), required: true);
            var __workflow_attachToMostRecentIAConnectSessionsearchIAConnectSessionType = WorkflowExpression.Compile(attachToMostRecentIAConnectSessionsearchIAConnectSessionType, nameof(attachToMostRecentIAConnectSessionsearchIAConnectSessionType), required: false);
            var __workflow_attachToMostRecentIAConnectSessiontimeToWaitInSeconds = WorkflowExpression.Compile(attachToMostRecentIAConnectSessiontimeToWaitInSeconds, nameof(attachToMostRecentIAConnectSessiontimeToWaitInSeconds), required: false);
            var __workflow_attachToMostRecentIAConnectSessionraiseExceptionIfTimedout = WorkflowExpression.Compile(attachToMostRecentIAConnectSessionraiseExceptionIfTimedout, nameof(attachToMostRecentIAConnectSessionraiseExceptionIfTimedout), required: false);
            var __workflow_attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected = WorkflowExpression.Compile(attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected, nameof(attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected), required: false);
            var __workflow_attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore = WorkflowExpression.Compile(attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore, nameof(attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore), required: false);
            return new DeferredBodyAction<AttachToMostRecentIAConnectSessionResponse>(() =>
            {
                var apiCallPath = "/DriverControl/AttachToMostRecentIAConnectSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var attachToMostRecentIAConnectSession = new JObject();
                var attachToMostRecentIAConnectSessionpropCount = 0;
                if (__workflow_attachToMostRecentIAConnectSessionsearchIAConnectSessionType != null)
                {
                    attachToMostRecentIAConnectSession["SearchIAConnectSessionType"] = ExpressionConverter.ConvertO(__workflow_attachToMostRecentIAConnectSessionsearchIAConnectSessionType);
                    attachToMostRecentIAConnectSessionpropCount++;
                }

                if (__workflow_attachToMostRecentIAConnectSessiontimeToWaitInSeconds != null)
                {
                    attachToMostRecentIAConnectSession["TimeToWaitInSeconds"] = ExpressionConverter.ConvertO(__workflow_attachToMostRecentIAConnectSessiontimeToWaitInSeconds);
                    attachToMostRecentIAConnectSessionpropCount++;
                }

                if (__workflow_attachToMostRecentIAConnectSessionraiseExceptionIfTimedout != null)
                {
                    if (__workflow_attachToMostRecentIAConnectSessionraiseExceptionIfTimedout != null)
                    {
                        attachToMostRecentIAConnectSession["RaiseExceptionIfTimedout"] = ExpressionConverter.ConvertO(__workflow_attachToMostRecentIAConnectSessionraiseExceptionIfTimedout);
                        attachToMostRecentIAConnectSessionpropCount++;
                    }

                    attachToMostRecentIAConnectSessionpropCount++;
                }
                else
                {
                    attachToMostRecentIAConnectSession["RaiseExceptionIfTimedout"] = true;
                    attachToMostRecentIAConnectSessionpropCount++;
                }

                if (__workflow_attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected != null)
                {
                    if (__workflow_attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected != null)
                    {
                        attachToMostRecentIAConnectSession["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(__workflow_attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected);
                        attachToMostRecentIAConnectSessionpropCount++;
                    }

                    attachToMostRecentIAConnectSessionpropCount++;
                }
                else
                {
                    attachToMostRecentIAConnectSession["VirtualChannelMustBeConnected"] = true;
                    attachToMostRecentIAConnectSessionpropCount++;
                }

                if (__workflow_attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore != null)
                {
                    if (__workflow_attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore != null)
                    {
                        attachToMostRecentIAConnectSession["OnlyCountSessionsNotSeenBefore"] = ExpressionConverter.ConvertO(__workflow_attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore);
                        attachToMostRecentIAConnectSessionpropCount++;
                    }

                    attachToMostRecentIAConnectSessionpropCount++;
                }
                else
                {
                    attachToMostRecentIAConnectSession["OnlyCountSessionsNotSeenBefore"] = false;
                    attachToMostRecentIAConnectSessionpropCount++;
                }

                attachToMostRecentIAConnectSessionpropCount++;
                attachToMostRecentIAConnectSession["Workflow"] = ExpressionConverter.ConvertO(__workflow_attachToMostRecentIAConnectSessionworkflow);
                if (attachToMostRecentIAConnectSessionpropCount > 0)
                {
                    callPayload.Body = attachToMostRecentIAConnectSession;
                }

                return new ApiConnectionAction<AttachToMostRecentIAConnectSessionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDirectorUpTimeResponse> GetDirectorUpTime(Expression<Func<string>> getDirectorUpTimeworkflow)
        {
            var __workflow_getDirectorUpTimeworkflow = WorkflowExpression.Compile(getDirectorUpTimeworkflow, nameof(getDirectorUpTimeworkflow), required: true);
            return new DeferredBodyAction<GetDirectorUpTimeResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetDirectorUpTime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getDirectorUpTime = new JObject();
                var getDirectorUpTimepropCount = 0;
                getDirectorUpTimepropCount++;
                getDirectorUpTime["Workflow"] = ExpressionConverter.ConvertO(__workflow_getDirectorUpTimeworkflow);
                if (getDirectorUpTimepropCount > 0)
                {
                    callPayload.Body = getDirectorUpTime;
                }

                return new ApiConnectionAction<GetDirectorUpTimeResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DoesIAConnectSessionExistByNameResponse> DoesIAConnectSessionExistByName(Expression<Func<string>> doesIAConnectSessionExistByNameiAConnectSessionName, Expression<Func<string>> doesIAConnectSessionExistByNameworkflow)
        {
            var __workflow_doesIAConnectSessionExistByNameiAConnectSessionName = WorkflowExpression.Compile(doesIAConnectSessionExistByNameiAConnectSessionName, nameof(doesIAConnectSessionExistByNameiAConnectSessionName), required: true);
            var __workflow_doesIAConnectSessionExistByNameworkflow = WorkflowExpression.Compile(doesIAConnectSessionExistByNameworkflow, nameof(doesIAConnectSessionExistByNameworkflow), required: true);
            return new DeferredBodyAction<DoesIAConnectSessionExistByNameResponse>(() =>
            {
                var apiCallPath = "/DriverControl/DoesIAConnectSessionExistByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var doesIAConnectSessionExistByName = new JObject();
                var doesIAConnectSessionExistByNamepropCount = 0;
                doesIAConnectSessionExistByNamepropCount++;
                doesIAConnectSessionExistByName["IAConnectSessionName"] = ExpressionConverter.ConvertO(__workflow_doesIAConnectSessionExistByNameiAConnectSessionName);
                doesIAConnectSessionExistByNamepropCount++;
                doesIAConnectSessionExistByName["Workflow"] = ExpressionConverter.ConvertO(__workflow_doesIAConnectSessionExistByNameworkflow);
                if (doesIAConnectSessionExistByNamepropCount > 0)
                {
                    callPayload.Body = doesIAConnectSessionExistByName;
                }

                return new ApiConnectionAction<DoesIAConnectSessionExistByNameResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForIAConnectSessionToCloseByNameResponse> WaitForIAConnectSessionToCloseByName(Expression<Func<string>> waitForIAConnectSessionToCloseByNameiAConnectSessionName, Expression<Func<string>> waitForIAConnectSessionToCloseByNameworkflow, Expression<Func<int>> waitForIAConnectSessionToCloseByNametimeToWaitInSeconds = null, Expression<Func<bool>> waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout = null, Expression<Func<bool>> waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess = null)
        {
            var __workflow_waitForIAConnectSessionToCloseByNameiAConnectSessionName = WorkflowExpression.Compile(waitForIAConnectSessionToCloseByNameiAConnectSessionName, nameof(waitForIAConnectSessionToCloseByNameiAConnectSessionName), required: true);
            var __workflow_waitForIAConnectSessionToCloseByNameworkflow = WorkflowExpression.Compile(waitForIAConnectSessionToCloseByNameworkflow, nameof(waitForIAConnectSessionToCloseByNameworkflow), required: true);
            var __workflow_waitForIAConnectSessionToCloseByNametimeToWaitInSeconds = WorkflowExpression.Compile(waitForIAConnectSessionToCloseByNametimeToWaitInSeconds, nameof(waitForIAConnectSessionToCloseByNametimeToWaitInSeconds), required: false);
            var __workflow_waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout = WorkflowExpression.Compile(waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout, nameof(waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout), required: false);
            var __workflow_waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess = WorkflowExpression.Compile(waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess, nameof(waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess), required: false);
            return new DeferredBodyAction<WaitForIAConnectSessionToCloseByNameResponse>(() =>
            {
                var apiCallPath = "/DriverControl/WaitForIAConnectSessionToCloseByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var waitForIAConnectSessionToCloseByName = new JObject();
                var waitForIAConnectSessionToCloseByNamepropCount = 0;
                waitForIAConnectSessionToCloseByNamepropCount++;
                waitForIAConnectSessionToCloseByName["IAConnectSessionName"] = ExpressionConverter.ConvertO(__workflow_waitForIAConnectSessionToCloseByNameiAConnectSessionName);
                if (__workflow_waitForIAConnectSessionToCloseByNametimeToWaitInSeconds != null)
                {
                    waitForIAConnectSessionToCloseByName["TimeToWaitInSeconds"] = ExpressionConverter.ConvertO(__workflow_waitForIAConnectSessionToCloseByNametimeToWaitInSeconds);
                    waitForIAConnectSessionToCloseByNamepropCount++;
                }

                if (__workflow_waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout != null)
                {
                    if (__workflow_waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout != null)
                    {
                        waitForIAConnectSessionToCloseByName["RaiseExceptionIfTimedout"] = ExpressionConverter.ConvertO(__workflow_waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout);
                        waitForIAConnectSessionToCloseByNamepropCount++;
                    }

                    waitForIAConnectSessionToCloseByNamepropCount++;
                }
                else
                {
                    waitForIAConnectSessionToCloseByName["RaiseExceptionIfTimedout"] = true;
                    waitForIAConnectSessionToCloseByNamepropCount++;
                }

                if (__workflow_waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess != null)
                {
                    if (__workflow_waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess != null)
                    {
                        waitForIAConnectSessionToCloseByName["AttachToTier1IAConnectSessionOnSuccess"] = ExpressionConverter.ConvertO(__workflow_waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess);
                        waitForIAConnectSessionToCloseByNamepropCount++;
                    }

                    waitForIAConnectSessionToCloseByNamepropCount++;
                }
                else
                {
                    waitForIAConnectSessionToCloseByName["AttachToTier1IAConnectSessionOnSuccess"] = true;
                    waitForIAConnectSessionToCloseByNamepropCount++;
                }

                waitForIAConnectSessionToCloseByNamepropCount++;
                waitForIAConnectSessionToCloseByName["Workflow"] = ExpressionConverter.ConvertO(__workflow_waitForIAConnectSessionToCloseByNameworkflow);
                if (waitForIAConnectSessionToCloseByNamepropCount > 0)
                {
                    callPayload.Body = waitForIAConnectSessionToCloseByName;
                }

                return new ApiConnectionAction<WaitForIAConnectSessionToCloseByNameResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillIAConnectSessionByNameResponse> KillIAConnectSessionByName(Expression<Func<string>> killIAConnectSessionByNameiAConnectSessionName, Expression<Func<string>> killIAConnectSessionByNameworkflow, Expression<Func<bool>> killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess = null)
        {
            var __workflow_killIAConnectSessionByNameiAConnectSessionName = WorkflowExpression.Compile(killIAConnectSessionByNameiAConnectSessionName, nameof(killIAConnectSessionByNameiAConnectSessionName), required: true);
            var __workflow_killIAConnectSessionByNameworkflow = WorkflowExpression.Compile(killIAConnectSessionByNameworkflow, nameof(killIAConnectSessionByNameworkflow), required: true);
            var __workflow_killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess = WorkflowExpression.Compile(killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess, nameof(killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess), required: false);
            return new DeferredBodyAction<KillIAConnectSessionByNameResponse>(() =>
            {
                var apiCallPath = "/DriverControl/KillIAConnectSessionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var killIAConnectSessionByName = new JObject();
                var killIAConnectSessionByNamepropCount = 0;
                killIAConnectSessionByNamepropCount++;
                killIAConnectSessionByName["IAConnectSessionName"] = ExpressionConverter.ConvertO(__workflow_killIAConnectSessionByNameiAConnectSessionName);
                if (__workflow_killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess != null)
                {
                    if (__workflow_killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess != null)
                    {
                        killIAConnectSessionByName["AttachToTier1IAConnectSessionOnSuccess"] = ExpressionConverter.ConvertO(__workflow_killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess);
                        killIAConnectSessionByNamepropCount++;
                    }

                    killIAConnectSessionByNamepropCount++;
                }
                else
                {
                    killIAConnectSessionByName["AttachToTier1IAConnectSessionOnSuccess"] = true;
                    killIAConnectSessionByNamepropCount++;
                }

                killIAConnectSessionByNamepropCount++;
                killIAConnectSessionByName["Workflow"] = ExpressionConverter.ConvertO(__workflow_killIAConnectSessionByNameworkflow);
                if (killIAConnectSessionByNamepropCount > 0)
                {
                    callPayload.Body = killIAConnectSessionByName;
                }

                return new ApiConnectionAction<KillIAConnectSessionByNameResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetAgentGlobalCoordinateConfigurationResponse> SetAgentGlobalCoordinateConfiguration(Expression<Func<string>> setAgentGlobalCoordinateConfigurationworkflow, Expression<Func<setAgentGlobalCoordinateConfigurationmultiMonitorFunctionalityInput>> setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality = null, Expression<Func<setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplierInput>> setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier = null, Expression<Func<setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplierInput>> setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod = null, Expression<Func<setAgentGlobalCoordinateConfigurationjavaCoordinateSystemInput>> setAgentGlobalCoordinateConfigurationjavaCoordinateSystem = null, Expression<Func<setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystemInput>> setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem = null)
        {
            var __workflow_setAgentGlobalCoordinateConfigurationworkflow = WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationworkflow, nameof(setAgentGlobalCoordinateConfigurationworkflow), required: true);
            var __workflow_setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality = WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality, nameof(setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier = WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier, nameof(setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier = WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier, nameof(setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier = WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier, nameof(setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier = WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier, nameof(setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier = WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier, nameof(setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier = WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier, nameof(setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent = WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent, nameof(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos = WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos, nameof(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod = WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod, nameof(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationjavaCoordinateSystem = WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationjavaCoordinateSystem, nameof(setAgentGlobalCoordinateConfigurationjavaCoordinateSystem), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem = WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem, nameof(setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem), required: false);
            return new DeferredBodyAction<SetAgentGlobalCoordinateConfigurationResponse>(() =>
            {
                var apiCallPath = "/DriverControl/SetAgentGlobalCoordinateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setAgentGlobalCoordinateConfiguration = new JObject();
                var setAgentGlobalCoordinateConfigurationpropCount = 0;
                if (__workflow_setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality != null)
                {
                    if (__workflow_setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality != null)
                    {
                        setAgentGlobalCoordinateConfiguration["MultiMonitorFunctionality"] = ExpressionConverter.ConvertO(__workflow_setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["MultiMonitorFunctionality"] = "NotSet";
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (__workflow_setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier != null)
                {
                    if (__workflow_setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier != null)
                    {
                        setAgentGlobalCoordinateConfiguration["AutoSetMouseInspectionMultiplier"] = ExpressionConverter.ConvertO(__workflow_setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["AutoSetMouseInspectionMultiplier"] = "NotSet";
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (__workflow_setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier != null)
                {
                    if (__workflow_setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier != null)
                    {
                        setAgentGlobalCoordinateConfiguration["AutoSetGlobalMouseMultiplier"] = ExpressionConverter.ConvertO(__workflow_setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["AutoSetGlobalMouseMultiplier"] = "NotSet";
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (__workflow_setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier != null)
                {
                    if (__workflow_setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier != null)
                    {
                        setAgentGlobalCoordinateConfiguration["MouseInspectionXMultiplier"] = ExpressionConverter.ConvertO(__workflow_setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["MouseInspectionXMultiplier"] = 0;
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (__workflow_setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier != null)
                {
                    if (__workflow_setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier != null)
                    {
                        setAgentGlobalCoordinateConfiguration["MouseInspectionYMultiplier"] = ExpressionConverter.ConvertO(__workflow_setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["MouseInspectionYMultiplier"] = 0;
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (__workflow_setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier != null)
                {
                    if (__workflow_setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier != null)
                    {
                        setAgentGlobalCoordinateConfiguration["GlobalMouseXMultiplier"] = ExpressionConverter.ConvertO(__workflow_setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["GlobalMouseXMultiplier"] = 0;
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (__workflow_setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier != null)
                {
                    if (__workflow_setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier != null)
                    {
                        setAgentGlobalCoordinateConfiguration["GlobalMouseYMultiplier"] = ExpressionConverter.ConvertO(__workflow_setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["GlobalMouseYMultiplier"] = 0;
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (__workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent != null)
                {
                    if (__workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent != null)
                    {
                        setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToMouseEvent"] = ExpressionConverter.ConvertO(__workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToMouseEvent"] = true;
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (__workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos != null)
                {
                    if (__workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos != null)
                    {
                        setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToSetCursorPos"] = ExpressionConverter.ConvertO(__workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToSetCursorPos"] = false;
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (__workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod != null)
                {
                    if (__workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod != null)
                    {
                        setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToCurrentMouseMoveMethod"] = ExpressionConverter.ConvertO(__workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToCurrentMouseMoveMethod"] = false;
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (__workflow_setAgentGlobalCoordinateConfigurationjavaCoordinateSystem != null)
                {
                    if (__workflow_setAgentGlobalCoordinateConfigurationjavaCoordinateSystem != null)
                    {
                        setAgentGlobalCoordinateConfiguration["JavaCoordinateSystem"] = ExpressionConverter.ConvertO(__workflow_setAgentGlobalCoordinateConfigurationjavaCoordinateSystem);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["JavaCoordinateSystem"] = "NotSet";
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (__workflow_setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem != null)
                {
                    if (__workflow_setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem != null)
                    {
                        setAgentGlobalCoordinateConfiguration["SAPGUICoordinateSystem"] = ExpressionConverter.ConvertO(__workflow_setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["SAPGUICoordinateSystem"] = "NotSet";
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                setAgentGlobalCoordinateConfigurationpropCount++;
                setAgentGlobalCoordinateConfiguration["Workflow"] = ExpressionConverter.ConvertO(__workflow_setAgentGlobalCoordinateConfigurationworkflow);
                if (setAgentGlobalCoordinateConfigurationpropCount > 0)
                {
                    callPayload.Body = setAgentGlobalCoordinateConfiguration;
                }

                return new ApiConnectionAction<SetAgentGlobalCoordinateConfigurationResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentGlobalCoordinateConfigurationResponse> GetAgentGlobalCoordinateConfiguration(Expression<Func<string>> getAgentGlobalCoordinateConfigurationworkflow)
        {
            var __workflow_getAgentGlobalCoordinateConfigurationworkflow = WorkflowExpression.Compile(getAgentGlobalCoordinateConfigurationworkflow, nameof(getAgentGlobalCoordinateConfigurationworkflow), required: true);
            return new DeferredBodyAction<GetAgentGlobalCoordinateConfigurationResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetAgentGlobalCoordinateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getAgentGlobalCoordinateConfiguration = new JObject();
                var getAgentGlobalCoordinateConfigurationpropCount = 0;
                getAgentGlobalCoordinateConfigurationpropCount++;
                getAgentGlobalCoordinateConfiguration["Workflow"] = ExpressionConverter.ConvertO(__workflow_getAgentGlobalCoordinateConfigurationworkflow);
                if (getAgentGlobalCoordinateConfigurationpropCount > 0)
                {
                    callPayload.Body = getAgentGlobalCoordinateConfiguration;
                }

                return new ApiConnectionAction<GetAgentGlobalCoordinateConfigurationResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentThreadStatusResponse> GetAgentThreadStatus(Expression<Func<int>> getAgentThreadStatusthreadId, Expression<Func<string>> getAgentThreadStatusworkflow, Expression<Func<bool>> getAgentThreadStatusretrieveThreadOutputData = null, Expression<Func<bool>> getAgentThreadStatusclearOutputDataFromMemoryOnceRead = null)
        {
            var __workflow_getAgentThreadStatusthreadId = WorkflowExpression.Compile(getAgentThreadStatusthreadId, nameof(getAgentThreadStatusthreadId), required: true);
            var __workflow_getAgentThreadStatusworkflow = WorkflowExpression.Compile(getAgentThreadStatusworkflow, nameof(getAgentThreadStatusworkflow), required: true);
            var __workflow_getAgentThreadStatusretrieveThreadOutputData = WorkflowExpression.Compile(getAgentThreadStatusretrieveThreadOutputData, nameof(getAgentThreadStatusretrieveThreadOutputData), required: false);
            var __workflow_getAgentThreadStatusclearOutputDataFromMemoryOnceRead = WorkflowExpression.Compile(getAgentThreadStatusclearOutputDataFromMemoryOnceRead, nameof(getAgentThreadStatusclearOutputDataFromMemoryOnceRead), required: false);
            return new DeferredBodyAction<GetAgentThreadStatusResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetAgentThreadStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getAgentThreadStatus = new JObject();
                var getAgentThreadStatuspropCount = 0;
                getAgentThreadStatuspropCount++;
                getAgentThreadStatus["ThreadId"] = ExpressionConverter.ConvertO(__workflow_getAgentThreadStatusthreadId);
                if (__workflow_getAgentThreadStatusretrieveThreadOutputData != null)
                {
                    if (__workflow_getAgentThreadStatusretrieveThreadOutputData != null)
                    {
                        getAgentThreadStatus["RetrieveThreadOutputData"] = ExpressionConverter.ConvertO(__workflow_getAgentThreadStatusretrieveThreadOutputData);
                        getAgentThreadStatuspropCount++;
                    }

                    getAgentThreadStatuspropCount++;
                }
                else
                {
                    getAgentThreadStatus["RetrieveThreadOutputData"] = false;
                    getAgentThreadStatuspropCount++;
                }

                if (__workflow_getAgentThreadStatusclearOutputDataFromMemoryOnceRead != null)
                {
                    if (__workflow_getAgentThreadStatusclearOutputDataFromMemoryOnceRead != null)
                    {
                        getAgentThreadStatus["ClearOutputDataFromMemoryOnceRead"] = ExpressionConverter.ConvertO(__workflow_getAgentThreadStatusclearOutputDataFromMemoryOnceRead);
                        getAgentThreadStatuspropCount++;
                    }

                    getAgentThreadStatuspropCount++;
                }
                else
                {
                    getAgentThreadStatus["ClearOutputDataFromMemoryOnceRead"] = true;
                    getAgentThreadStatuspropCount++;
                }

                getAgentThreadStatuspropCount++;
                getAgentThreadStatus["Workflow"] = ExpressionConverter.ConvertO(__workflow_getAgentThreadStatusworkflow);
                if (getAgentThreadStatuspropCount > 0)
                {
                    callPayload.Body = getAgentThreadStatus;
                }

                return new ApiConnectionAction<GetAgentThreadStatusResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForAgentThreadToCompleteSuccessfullyResponse> WaitForAgentThreadToCompleteSuccessfully(Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullythreadId, Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread, Expression<Func<string>> waitForAgentThreadToCompleteSuccessfullyworkflow, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError = null, Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall = null)
        {
            var __workflow_waitForAgentThreadToCompleteSuccessfullythreadId = WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullythreadId, nameof(waitForAgentThreadToCompleteSuccessfullythreadId), required: true);
            var __workflow_waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread = WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread, nameof(waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread), required: true);
            var __workflow_waitForAgentThreadToCompleteSuccessfullyworkflow = WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullyworkflow, nameof(waitForAgentThreadToCompleteSuccessfullyworkflow), required: true);
            var __workflow_waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData = WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData, nameof(waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData), required: false);
            var __workflow_waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead = WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead, nameof(waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead), required: false);
            var __workflow_waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted = WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted, nameof(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted), required: false);
            var __workflow_waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError = WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError, nameof(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError), required: false);
            var __workflow_waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall = WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall, nameof(waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall), required: false);
            return new DeferredBodyAction<WaitForAgentThreadToCompleteSuccessfullyResponse>(() =>
            {
                var apiCallPath = "/DriverControl/WaitForAgentThreadToCompleteSuccessfully";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var waitForAgentThreadToCompleteSuccessfully = new JObject();
                var waitForAgentThreadToCompleteSuccessfullypropCount = 0;
                waitForAgentThreadToCompleteSuccessfullypropCount++;
                waitForAgentThreadToCompleteSuccessfully["ThreadId"] = ExpressionConverter.ConvertO(__workflow_waitForAgentThreadToCompleteSuccessfullythreadId);
                waitForAgentThreadToCompleteSuccessfullypropCount++;
                waitForAgentThreadToCompleteSuccessfully["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(__workflow_waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread);
                if (__workflow_waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData != null)
                {
                    if (__workflow_waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData != null)
                    {
                        waitForAgentThreadToCompleteSuccessfully["RetrieveThreadOutputData"] = ExpressionConverter.ConvertO(__workflow_waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData);
                        waitForAgentThreadToCompleteSuccessfullypropCount++;
                    }

                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }
                else
                {
                    waitForAgentThreadToCompleteSuccessfully["RetrieveThreadOutputData"] = false;
                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }

                if (__workflow_waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead != null)
                {
                    if (__workflow_waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead != null)
                    {
                        waitForAgentThreadToCompleteSuccessfully["ClearOutputDataFromMemoryOnceRead"] = ExpressionConverter.ConvertO(__workflow_waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead);
                        waitForAgentThreadToCompleteSuccessfullypropCount++;
                    }

                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }
                else
                {
                    waitForAgentThreadToCompleteSuccessfully["ClearOutputDataFromMemoryOnceRead"] = true;
                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }

                if (__workflow_waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted != null)
                {
                    if (__workflow_waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted != null)
                    {
                        waitForAgentThreadToCompleteSuccessfully["RaiseExceptionIfThreadNotCompleted"] = ExpressionConverter.ConvertO(__workflow_waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted);
                        waitForAgentThreadToCompleteSuccessfullypropCount++;
                    }

                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }
                else
                {
                    waitForAgentThreadToCompleteSuccessfully["RaiseExceptionIfThreadNotCompleted"] = true;
                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }

                if (__workflow_waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError != null)
                {
                    if (__workflow_waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError != null)
                    {
                        waitForAgentThreadToCompleteSuccessfully["RaiseExceptionIfThreadError"] = ExpressionConverter.ConvertO(__workflow_waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError);
                        waitForAgentThreadToCompleteSuccessfullypropCount++;
                    }

                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }
                else
                {
                    waitForAgentThreadToCompleteSuccessfully["RaiseExceptionIfThreadError"] = true;
                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }

                if (__workflow_waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall != null)
                {
                    if (__workflow_waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall != null)
                    {
                        waitForAgentThreadToCompleteSuccessfully["SecondsToWaitPerCall"] = ExpressionConverter.ConvertO(__workflow_waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall);
                        waitForAgentThreadToCompleteSuccessfullypropCount++;
                    }

                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }
                else
                {
                    waitForAgentThreadToCompleteSuccessfully["SecondsToWaitPerCall"] = 5;
                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }

                waitForAgentThreadToCompleteSuccessfullypropCount++;
                waitForAgentThreadToCompleteSuccessfully["Workflow"] = ExpressionConverter.ConvertO(__workflow_waitForAgentThreadToCompleteSuccessfullyworkflow);
                if (waitForAgentThreadToCompleteSuccessfullypropCount > 0)
                {
                    callPayload.Body = waitForAgentThreadToCompleteSuccessfully;
                }

                return new ApiConnectionAction<WaitForAgentThreadToCompleteSuccessfullyResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentThreadsResponse> GetAgentThreads(Expression<Func<string>> getAgentThreadsworkflow, Expression<Func<getAgentThreadssortOrderInput>> getAgentThreadssortOrder = null)
        {
            var __workflow_getAgentThreadsworkflow = WorkflowExpression.Compile(getAgentThreadsworkflow, nameof(getAgentThreadsworkflow), required: true);
            var __workflow_getAgentThreadssortOrder = WorkflowExpression.Compile(getAgentThreadssortOrder, nameof(getAgentThreadssortOrder), required: false);
            return new DeferredBodyAction<GetAgentThreadsResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetAgentThreads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getAgentThreads = new JObject();
                var getAgentThreadspropCount = 0;
                if (__workflow_getAgentThreadssortOrder != null)
                {
                    getAgentThreads["SortOrder"] = ExpressionConverter.ConvertO(__workflow_getAgentThreadssortOrder);
                    getAgentThreadspropCount++;
                }

                getAgentThreadspropCount++;
                getAgentThreads["Workflow"] = ExpressionConverter.ConvertO(__workflow_getAgentThreadsworkflow);
                if (getAgentThreadspropCount > 0)
                {
                    callPayload.Body = getAgentThreads;
                }

                return new ApiConnectionAction<GetAgentThreadsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillAgentThreadResponse> KillAgentThread(Expression<Func<int>> killAgentThreadthreadId, Expression<Func<string>> killAgentThreadworkflow)
        {
            var __workflow_killAgentThreadthreadId = WorkflowExpression.Compile(killAgentThreadthreadId, nameof(killAgentThreadthreadId), required: true);
            var __workflow_killAgentThreadworkflow = WorkflowExpression.Compile(killAgentThreadworkflow, nameof(killAgentThreadworkflow), required: true);
            return new DeferredBodyAction<KillAgentThreadResponse>(() =>
            {
                var apiCallPath = "/DriverControl/KillAgentThread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var killAgentThread = new JObject();
                var killAgentThreadpropCount = 0;
                killAgentThreadpropCount++;
                killAgentThread["ThreadId"] = ExpressionConverter.ConvertO(__workflow_killAgentThreadthreadId);
                killAgentThreadpropCount++;
                killAgentThread["Workflow"] = ExpressionConverter.ConvertO(__workflow_killAgentThreadworkflow);
                if (killAgentThreadpropCount > 0)
                {
                    callPayload.Body = killAgentThread;
                }

                return new ApiConnectionAction<KillAgentThreadResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeleteAgentThreadResponse> DeleteAgentThread(Expression<Func<string>> deleteAgentThreadworkflow, Expression<Func<int>> deleteAgentThreadthreadId = null, Expression<Func<bool>> deleteAgentThreaddeleteAllAgentThreads = null, Expression<Func<bool>> deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete = null)
        {
            var __workflow_deleteAgentThreadworkflow = WorkflowExpression.Compile(deleteAgentThreadworkflow, nameof(deleteAgentThreadworkflow), required: true);
            var __workflow_deleteAgentThreadthreadId = WorkflowExpression.Compile(deleteAgentThreadthreadId, nameof(deleteAgentThreadthreadId), required: false);
            var __workflow_deleteAgentThreaddeleteAllAgentThreads = WorkflowExpression.Compile(deleteAgentThreaddeleteAllAgentThreads, nameof(deleteAgentThreaddeleteAllAgentThreads), required: false);
            var __workflow_deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete = WorkflowExpression.Compile(deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete, nameof(deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete), required: false);
            return new DeferredBodyAction<DeleteAgentThreadResponse>(() =>
            {
                var apiCallPath = "/DriverControl/DeleteAgentThread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteAgentThread = new JObject();
                var deleteAgentThreadpropCount = 0;
                if (__workflow_deleteAgentThreadthreadId != null)
                {
                    deleteAgentThread["ThreadId"] = ExpressionConverter.ConvertO(__workflow_deleteAgentThreadthreadId);
                    deleteAgentThreadpropCount++;
                }

                if (__workflow_deleteAgentThreaddeleteAllAgentThreads != null)
                {
                    if (__workflow_deleteAgentThreaddeleteAllAgentThreads != null)
                    {
                        deleteAgentThread["DeleteAllAgentThreads"] = ExpressionConverter.ConvertO(__workflow_deleteAgentThreaddeleteAllAgentThreads);
                        deleteAgentThreadpropCount++;
                    }

                    deleteAgentThreadpropCount++;
                }
                else
                {
                    deleteAgentThread["DeleteAllAgentThreads"] = false;
                    deleteAgentThreadpropCount++;
                }

                if (__workflow_deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete != null)
                {
                    if (__workflow_deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete != null)
                    {
                        deleteAgentThread["RaiseExceptionIfAgentThreadFailsToDelete"] = ExpressionConverter.ConvertO(__workflow_deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete);
                        deleteAgentThreadpropCount++;
                    }

                    deleteAgentThreadpropCount++;
                }
                else
                {
                    deleteAgentThread["RaiseExceptionIfAgentThreadFailsToDelete"] = false;
                    deleteAgentThreadpropCount++;
                }

                deleteAgentThreadpropCount++;
                deleteAgentThread["Workflow"] = ExpressionConverter.ConvertO(__workflow_deleteAgentThreadworkflow);
                if (deleteAgentThreadpropCount > 0)
                {
                    callPayload.Body = deleteAgentThread;
                }

                return new ApiConnectionAction<DeleteAgentThreadResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AllocateWorkerFromOrchestratorResponse> AllocateWorkerFromOrchestrator(Expression<Func<string>> allocateWorkerFromOrchestratorworkflow, Expression<Func<string>> allocateWorkerFromOrchestratorworkerTag = null, Expression<Func<string>> allocateWorkerFromOrchestratorworkerName = null, Expression<Func<bool>> allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable = null)
        {
            var __workflow_allocateWorkerFromOrchestratorworkflow = WorkflowExpression.Compile(allocateWorkerFromOrchestratorworkflow, nameof(allocateWorkerFromOrchestratorworkflow), required: true);
            var __workflow_allocateWorkerFromOrchestratorworkerTag = WorkflowExpression.Compile(allocateWorkerFromOrchestratorworkerTag, nameof(allocateWorkerFromOrchestratorworkerTag), required: false);
            var __workflow_allocateWorkerFromOrchestratorworkerName = WorkflowExpression.Compile(allocateWorkerFromOrchestratorworkerName, nameof(allocateWorkerFromOrchestratorworkerName), required: false);
            var __workflow_allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable = WorkflowExpression.Compile(allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable, nameof(allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable), required: false);
            return new DeferredBodyAction<AllocateWorkerFromOrchestratorResponse>(() =>
            {
                var apiCallPath = "/DriverControl/AllocateWorkerFromOrchestrator";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var allocateWorkerFromOrchestrator = new JObject();
                var allocateWorkerFromOrchestratorpropCount = 0;
                if (__workflow_allocateWorkerFromOrchestratorworkerTag != null)
                {
                    allocateWorkerFromOrchestrator["WorkerTag"] = ExpressionConverter.ConvertO(__workflow_allocateWorkerFromOrchestratorworkerTag);
                    allocateWorkerFromOrchestratorpropCount++;
                }

                if (__workflow_allocateWorkerFromOrchestratorworkerName != null)
                {
                    allocateWorkerFromOrchestrator["WorkerName"] = ExpressionConverter.ConvertO(__workflow_allocateWorkerFromOrchestratorworkerName);
                    allocateWorkerFromOrchestratorpropCount++;
                }

                if (__workflow_allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable != null)
                {
                    if (__workflow_allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable != null)
                    {
                        allocateWorkerFromOrchestrator["RaiseExceptionIfWorkerNotImmediatelyAvailable"] = ExpressionConverter.ConvertO(__workflow_allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable);
                        allocateWorkerFromOrchestratorpropCount++;
                    }

                    allocateWorkerFromOrchestratorpropCount++;
                }
                else
                {
                    allocateWorkerFromOrchestrator["RaiseExceptionIfWorkerNotImmediatelyAvailable"] = false;
                    allocateWorkerFromOrchestratorpropCount++;
                }

                allocateWorkerFromOrchestratorpropCount++;
                allocateWorkerFromOrchestrator["Workflow"] = ExpressionConverter.ConvertO(__workflow_allocateWorkerFromOrchestratorworkflow);
                if (allocateWorkerFromOrchestratorpropCount > 0)
                {
                    callPayload.Body = allocateWorkerFromOrchestrator;
                }

                return new ApiConnectionAction<AllocateWorkerFromOrchestratorResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetOrchestratorWorkerMaintenanceModeResponse> SetOrchestratorWorkerMaintenanceMode(Expression<Func<int>> setOrchestratorWorkerMaintenanceModeworkerId = null, Expression<Func<string>> setOrchestratorWorkerMaintenanceModeworkerName = null, Expression<Func<bool>> setOrchestratorWorkerMaintenanceModemaintenanceMode = null)
        {
            var __workflow_setOrchestratorWorkerMaintenanceModeworkerId = WorkflowExpression.Compile(setOrchestratorWorkerMaintenanceModeworkerId, nameof(setOrchestratorWorkerMaintenanceModeworkerId), required: false);
            var __workflow_setOrchestratorWorkerMaintenanceModeworkerName = WorkflowExpression.Compile(setOrchestratorWorkerMaintenanceModeworkerName, nameof(setOrchestratorWorkerMaintenanceModeworkerName), required: false);
            var __workflow_setOrchestratorWorkerMaintenanceModemaintenanceMode = WorkflowExpression.Compile(setOrchestratorWorkerMaintenanceModemaintenanceMode, nameof(setOrchestratorWorkerMaintenanceModemaintenanceMode), required: false);
            return new DeferredBodyAction<SetOrchestratorWorkerMaintenanceModeResponse>(() =>
            {
                var apiCallPath = "/DriverControl/SetOrchestratorWorkerMaintenanceMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setOrchestratorWorkerMaintenanceMode = new JObject();
                var setOrchestratorWorkerMaintenanceModepropCount = 0;
                if (__workflow_setOrchestratorWorkerMaintenanceModeworkerId != null)
                {
                    if (__workflow_setOrchestratorWorkerMaintenanceModeworkerId != null)
                    {
                        setOrchestratorWorkerMaintenanceMode["WorkerId"] = ExpressionConverter.ConvertO(__workflow_setOrchestratorWorkerMaintenanceModeworkerId);
                        setOrchestratorWorkerMaintenanceModepropCount++;
                    }

                    setOrchestratorWorkerMaintenanceModepropCount++;
                }
                else
                {
                    setOrchestratorWorkerMaintenanceMode["WorkerId"] = 0;
                    setOrchestratorWorkerMaintenanceModepropCount++;
                }

                if (__workflow_setOrchestratorWorkerMaintenanceModeworkerName != null)
                {
                    setOrchestratorWorkerMaintenanceMode["WorkerName"] = ExpressionConverter.ConvertO(__workflow_setOrchestratorWorkerMaintenanceModeworkerName);
                    setOrchestratorWorkerMaintenanceModepropCount++;
                }

                if (__workflow_setOrchestratorWorkerMaintenanceModemaintenanceMode != null)
                {
                    if (__workflow_setOrchestratorWorkerMaintenanceModemaintenanceMode != null)
                    {
                        setOrchestratorWorkerMaintenanceMode["MaintenanceMode"] = ExpressionConverter.ConvertO(__workflow_setOrchestratorWorkerMaintenanceModemaintenanceMode);
                        setOrchestratorWorkerMaintenanceModepropCount++;
                    }

                    setOrchestratorWorkerMaintenanceModepropCount++;
                }
                else
                {
                    setOrchestratorWorkerMaintenanceMode["MaintenanceMode"] = true;
                    setOrchestratorWorkerMaintenanceModepropCount++;
                }

                if (setOrchestratorWorkerMaintenanceModepropCount > 0)
                {
                    callPayload.Body = setOrchestratorWorkerMaintenanceMode;
                }

                return new ApiConnectionAction<SetOrchestratorWorkerMaintenanceModeResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CreateOrchestratorOneTimeSecretResponse> CreateOrchestratorOneTimeSecret(Expression<Func<string>> createOrchestratorOneTimeSecretfriendlyName, Expression<Func<string>> createOrchestratorOneTimeSecretsecretValue = null, Expression<Func<string>> createOrchestratorOneTimeSecretretrievalPhrase1 = null, Expression<Func<string>> createOrchestratorOneTimeSecretretrievalPhrase2 = null, Expression<Func<int>> createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion = null, Expression<Func<bool>> createOrchestratorOneTimeSecretsecretHasAStartDate = null, Expression<Func<string>> createOrchestratorOneTimeSecretsecretStartDateTime = null, Expression<Func<int>> createOrchestratorOneTimeSecrethoursUntilSecretStartTime = null, Expression<Func<bool>> createOrchestratorOneTimeSecretsecretHasAnExpiryDate = null, Expression<Func<string>> createOrchestratorOneTimeSecretsecretExpiryDateTime = null, Expression<Func<int>> createOrchestratorOneTimeSecrethoursUntilSecretExpiry = null)
        {
            var __workflow_createOrchestratorOneTimeSecretfriendlyName = WorkflowExpression.Compile(createOrchestratorOneTimeSecretfriendlyName, nameof(createOrchestratorOneTimeSecretfriendlyName), required: true);
            var __workflow_createOrchestratorOneTimeSecretsecretValue = WorkflowExpression.Compile(createOrchestratorOneTimeSecretsecretValue, nameof(createOrchestratorOneTimeSecretsecretValue), required: false);
            var __workflow_createOrchestratorOneTimeSecretretrievalPhrase1 = WorkflowExpression.Compile(createOrchestratorOneTimeSecretretrievalPhrase1, nameof(createOrchestratorOneTimeSecretretrievalPhrase1), required: false);
            var __workflow_createOrchestratorOneTimeSecretretrievalPhrase2 = WorkflowExpression.Compile(createOrchestratorOneTimeSecretretrievalPhrase2, nameof(createOrchestratorOneTimeSecretretrievalPhrase2), required: false);
            var __workflow_createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion = WorkflowExpression.Compile(createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion, nameof(createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion), required: false);
            var __workflow_createOrchestratorOneTimeSecretsecretHasAStartDate = WorkflowExpression.Compile(createOrchestratorOneTimeSecretsecretHasAStartDate, nameof(createOrchestratorOneTimeSecretsecretHasAStartDate), required: false);
            var __workflow_createOrchestratorOneTimeSecretsecretStartDateTime = WorkflowExpression.Compile(createOrchestratorOneTimeSecretsecretStartDateTime, nameof(createOrchestratorOneTimeSecretsecretStartDateTime), required: false);
            var __workflow_createOrchestratorOneTimeSecrethoursUntilSecretStartTime = WorkflowExpression.Compile(createOrchestratorOneTimeSecrethoursUntilSecretStartTime, nameof(createOrchestratorOneTimeSecrethoursUntilSecretStartTime), required: false);
            var __workflow_createOrchestratorOneTimeSecretsecretHasAnExpiryDate = WorkflowExpression.Compile(createOrchestratorOneTimeSecretsecretHasAnExpiryDate, nameof(createOrchestratorOneTimeSecretsecretHasAnExpiryDate), required: false);
            var __workflow_createOrchestratorOneTimeSecretsecretExpiryDateTime = WorkflowExpression.Compile(createOrchestratorOneTimeSecretsecretExpiryDateTime, nameof(createOrchestratorOneTimeSecretsecretExpiryDateTime), required: false);
            var __workflow_createOrchestratorOneTimeSecrethoursUntilSecretExpiry = WorkflowExpression.Compile(createOrchestratorOneTimeSecrethoursUntilSecretExpiry, nameof(createOrchestratorOneTimeSecrethoursUntilSecretExpiry), required: false);
            return new DeferredBodyAction<CreateOrchestratorOneTimeSecretResponse>(() =>
            {
                var apiCallPath = "/DriverControl/CreateOrchestratorOneTimeSecret";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createOrchestratorOneTimeSecret = new JObject();
                var createOrchestratorOneTimeSecretpropCount = 0;
                createOrchestratorOneTimeSecretpropCount++;
                createOrchestratorOneTimeSecret["FriendlyName"] = ExpressionConverter.ConvertO(__workflow_createOrchestratorOneTimeSecretfriendlyName);
                if (__workflow_createOrchestratorOneTimeSecretsecretValue != null)
                {
                    createOrchestratorOneTimeSecret["SecretValue"] = ExpressionConverter.ConvertO(__workflow_createOrchestratorOneTimeSecretsecretValue);
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (__workflow_createOrchestratorOneTimeSecretretrievalPhrase1 != null)
                {
                    createOrchestratorOneTimeSecret["RetrievalPhrase1"] = ExpressionConverter.ConvertO(__workflow_createOrchestratorOneTimeSecretretrievalPhrase1);
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (__workflow_createOrchestratorOneTimeSecretretrievalPhrase2 != null)
                {
                    createOrchestratorOneTimeSecret["RetrievalPhrase2"] = ExpressionConverter.ConvertO(__workflow_createOrchestratorOneTimeSecretretrievalPhrase2);
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (__workflow_createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion != null)
                {
                    if (__workflow_createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion != null)
                    {
                        createOrchestratorOneTimeSecret["MaximumRetrievalsBeforeDeletion"] = ExpressionConverter.ConvertO(__workflow_createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion);
                        createOrchestratorOneTimeSecretpropCount++;
                    }

                    createOrchestratorOneTimeSecretpropCount++;
                }
                else
                {
                    createOrchestratorOneTimeSecret["MaximumRetrievalsBeforeDeletion"] = 1;
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (__workflow_createOrchestratorOneTimeSecretsecretHasAStartDate != null)
                {
                    if (__workflow_createOrchestratorOneTimeSecretsecretHasAStartDate != null)
                    {
                        createOrchestratorOneTimeSecret["SecretHasAStartDate"] = ExpressionConverter.ConvertO(__workflow_createOrchestratorOneTimeSecretsecretHasAStartDate);
                        createOrchestratorOneTimeSecretpropCount++;
                    }

                    createOrchestratorOneTimeSecretpropCount++;
                }
                else
                {
                    createOrchestratorOneTimeSecret["SecretHasAStartDate"] = false;
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (__workflow_createOrchestratorOneTimeSecretsecretStartDateTime != null)
                {
                    createOrchestratorOneTimeSecret["SecretStartDateTime"] = ExpressionConverter.ConvertO(__workflow_createOrchestratorOneTimeSecretsecretStartDateTime);
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (__workflow_createOrchestratorOneTimeSecrethoursUntilSecretStartTime != null)
                {
                    createOrchestratorOneTimeSecret["HoursUntilSecretStartTime"] = ExpressionConverter.ConvertO(__workflow_createOrchestratorOneTimeSecrethoursUntilSecretStartTime);
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (__workflow_createOrchestratorOneTimeSecretsecretHasAnExpiryDate != null)
                {
                    if (__workflow_createOrchestratorOneTimeSecretsecretHasAnExpiryDate != null)
                    {
                        createOrchestratorOneTimeSecret["SecretHasAnExpiryDate"] = ExpressionConverter.ConvertO(__workflow_createOrchestratorOneTimeSecretsecretHasAnExpiryDate);
                        createOrchestratorOneTimeSecretpropCount++;
                    }

                    createOrchestratorOneTimeSecretpropCount++;
                }
                else
                {
                    createOrchestratorOneTimeSecret["SecretHasAnExpiryDate"] = false;
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (__workflow_createOrchestratorOneTimeSecretsecretExpiryDateTime != null)
                {
                    createOrchestratorOneTimeSecret["SecretExpiryDateTime"] = ExpressionConverter.ConvertO(__workflow_createOrchestratorOneTimeSecretsecretExpiryDateTime);
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (__workflow_createOrchestratorOneTimeSecrethoursUntilSecretExpiry != null)
                {
                    createOrchestratorOneTimeSecret["HoursUntilSecretExpiry"] = ExpressionConverter.ConvertO(__workflow_createOrchestratorOneTimeSecrethoursUntilSecretExpiry);
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (createOrchestratorOneTimeSecretpropCount > 0)
                {
                    callPayload.Body = createOrchestratorOneTimeSecret;
                }

                return new ApiConnectionAction<CreateOrchestratorOneTimeSecretResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfOrchestratorWorkersResponse> GetListOfOrchestratorWorkers(Expression<Func<bool>> getListOfOrchestratorWorkersonlyReturnLiveWorkers = null)
        {
            var __workflow_getListOfOrchestratorWorkersonlyReturnLiveWorkers = WorkflowExpression.Compile(getListOfOrchestratorWorkersonlyReturnLiveWorkers, nameof(getListOfOrchestratorWorkersonlyReturnLiveWorkers), required: false);
            return new DeferredBodyAction<GetListOfOrchestratorWorkersResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetListOfOrchestratorWorkers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getListOfOrchestratorWorkers = new JObject();
                var getListOfOrchestratorWorkerspropCount = 0;
                if (__workflow_getListOfOrchestratorWorkersonlyReturnLiveWorkers != null)
                {
                    if (__workflow_getListOfOrchestratorWorkersonlyReturnLiveWorkers != null)
                    {
                        getListOfOrchestratorWorkers["OnlyReturnLiveWorkers"] = ExpressionConverter.ConvertO(__workflow_getListOfOrchestratorWorkersonlyReturnLiveWorkers);
                        getListOfOrchestratorWorkerspropCount++;
                    }

                    getListOfOrchestratorWorkerspropCount++;
                }
                else
                {
                    getListOfOrchestratorWorkers["OnlyReturnLiveWorkers"] = false;
                    getListOfOrchestratorWorkerspropCount++;
                }

                if (getListOfOrchestratorWorkerspropCount > 0)
                {
                    callPayload.Body = getListOfOrchestratorWorkers;
                }

                return new ApiConnectionAction<GetListOfOrchestratorWorkersResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerResponse> GetOrchestratorWorker(Expression<Func<int>> getOrchestratorWorkersearchWorkerId = null, Expression<Func<string>> getOrchestratorWorkersearchWorkerName = null)
        {
            var __workflow_getOrchestratorWorkersearchWorkerId = WorkflowExpression.Compile(getOrchestratorWorkersearchWorkerId, nameof(getOrchestratorWorkersearchWorkerId), required: false);
            var __workflow_getOrchestratorWorkersearchWorkerName = WorkflowExpression.Compile(getOrchestratorWorkersearchWorkerName, nameof(getOrchestratorWorkersearchWorkerName), required: false);
            return new DeferredBodyAction<GetOrchestratorWorkerResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorWorker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getOrchestratorWorker = new JObject();
                var getOrchestratorWorkerpropCount = 0;
                if (__workflow_getOrchestratorWorkersearchWorkerId != null)
                {
                    getOrchestratorWorker["SearchWorkerId"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorWorkersearchWorkerId);
                    getOrchestratorWorkerpropCount++;
                }

                if (__workflow_getOrchestratorWorkersearchWorkerName != null)
                {
                    getOrchestratorWorker["SearchWorkerName"] = ExpressionConverter.ConvertO(__workflow_getOrchestratorWorkersearchWorkerName);
                    getOrchestratorWorkerpropCount++;
                }

                if (getOrchestratorWorkerpropCount > 0)
                {
                    callPayload.Body = getOrchestratorWorker;
                }

                return new ApiConnectionAction<GetOrchestratorWorkerResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<OrchestratorGetStatusResponse> OrchestratorGetStatus()
        {
            var apiCallPath = "/OrchestratorController/OrchestratorGetStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OrchestratorGetStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<OrchestratorGetWorkerAvailabilityStatusOverviewResponse> OrchestratorGetWorkerAvailabilityStatusOverview()
        {
            var apiCallPath = "/OrchestratorController/OrchestratorGetWorkerAvailabilityStatusOverview";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OrchestratorGetWorkerAvailabilityStatusOverviewResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<FileExistsResponse> FileExists(Expression<Func<string>> fileExistsfilename, Expression<Func<string>> fileExistsworkflow)
        {
            var __workflow_fileExistsfilename = WorkflowExpression.Compile(fileExistsfilename, nameof(fileExistsfilename), required: true);
            var __workflow_fileExistsworkflow = WorkflowExpression.Compile(fileExistsworkflow, nameof(fileExistsworkflow), required: true);
            return new DeferredBodyAction<FileExistsResponse>(() =>
            {
                var apiCallPath = "/FileManagement/FileExists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileExists = new JObject();
                var fileExistspropCount = 0;
                fileExistspropCount++;
                fileExists["Filename"] = ExpressionConverter.ConvertO(__workflow_fileExistsfilename);
                fileExistspropCount++;
                fileExists["Workflow"] = ExpressionConverter.ConvertO(__workflow_fileExistsworkflow);
                if (fileExistspropCount > 0)
                {
                    callPayload.Body = fileExists;
                }

                return new ApiConnectionAction<FileExistsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DirectoryExistsResponse> DirectoryExists(Expression<Func<string>> directoryExistsdirectoryPath, Expression<Func<string>> directoryExistsworkflow)
        {
            var __workflow_directoryExistsdirectoryPath = WorkflowExpression.Compile(directoryExistsdirectoryPath, nameof(directoryExistsdirectoryPath), required: true);
            var __workflow_directoryExistsworkflow = WorkflowExpression.Compile(directoryExistsworkflow, nameof(directoryExistsworkflow), required: true);
            return new DeferredBodyAction<DirectoryExistsResponse>(() =>
            {
                var apiCallPath = "/FileManagement/DirectoryExists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var directoryExists = new JObject();
                var directoryExistspropCount = 0;
                directoryExistspropCount++;
                directoryExists["DirectoryPath"] = ExpressionConverter.ConvertO(__workflow_directoryExistsdirectoryPath);
                directoryExistspropCount++;
                directoryExists["Workflow"] = ExpressionConverter.ConvertO(__workflow_directoryExistsworkflow);
                if (directoryExistspropCount > 0)
                {
                    callPayload.Body = directoryExists;
                }

                return new ApiConnectionAction<DirectoryExistsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DeleteFile(Expression<Func<string>> deleteFilefilename, Expression<Func<string>> deleteFileworkflow)
        {
            var __workflow_deleteFilefilename = WorkflowExpression.Compile(deleteFilefilename, nameof(deleteFilefilename), required: true);
            var __workflow_deleteFileworkflow = WorkflowExpression.Compile(deleteFileworkflow, nameof(deleteFileworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/DeleteFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteFile = new JObject();
                var deleteFilepropCount = 0;
                deleteFilepropCount++;
                deleteFile["Filename"] = ExpressionConverter.ConvertO(__workflow_deleteFilefilename);
                deleteFilepropCount++;
                deleteFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_deleteFileworkflow);
                if (deleteFilepropCount > 0)
                {
                    callPayload.Body = deleteFile;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DeleteDirectory(Expression<Func<string>> deleteDirectorydirectoryPath, Expression<Func<string>> deleteDirectoryworkflow, Expression<Func<bool>> deleteDirectoryrecursive = null)
        {
            var __workflow_deleteDirectorydirectoryPath = WorkflowExpression.Compile(deleteDirectorydirectoryPath, nameof(deleteDirectorydirectoryPath), required: true);
            var __workflow_deleteDirectoryworkflow = WorkflowExpression.Compile(deleteDirectoryworkflow, nameof(deleteDirectoryworkflow), required: true);
            var __workflow_deleteDirectoryrecursive = WorkflowExpression.Compile(deleteDirectoryrecursive, nameof(deleteDirectoryrecursive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/DeleteDirectory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteDirectory = new JObject();
                var deleteDirectorypropCount = 0;
                deleteDirectorypropCount++;
                deleteDirectory["DirectoryPath"] = ExpressionConverter.ConvertO(__workflow_deleteDirectorydirectoryPath);
                if (__workflow_deleteDirectoryrecursive != null)
                {
                    if (__workflow_deleteDirectoryrecursive != null)
                    {
                        deleteDirectory["Recursive"] = ExpressionConverter.ConvertO(__workflow_deleteDirectoryrecursive);
                        deleteDirectorypropCount++;
                    }

                    deleteDirectorypropCount++;
                }
                else
                {
                    deleteDirectory["Recursive"] = false;
                    deleteDirectorypropCount++;
                }

                deleteDirectorypropCount++;
                deleteDirectory["Workflow"] = ExpressionConverter.ConvertO(__workflow_deleteDirectoryworkflow);
                if (deleteDirectorypropCount > 0)
                {
                    callPayload.Body = deleteDirectory;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction PurgeDirectory(Expression<Func<string>> purgeDirectorydirectoryPath, Expression<Func<string>> purgeDirectoryworkflow, Expression<Func<bool>> purgeDirectoryrecursive = null, Expression<Func<bool>> purgeDirectorydeleteTopLevel = null)
        {
            var __workflow_purgeDirectorydirectoryPath = WorkflowExpression.Compile(purgeDirectorydirectoryPath, nameof(purgeDirectorydirectoryPath), required: true);
            var __workflow_purgeDirectoryworkflow = WorkflowExpression.Compile(purgeDirectoryworkflow, nameof(purgeDirectoryworkflow), required: true);
            var __workflow_purgeDirectoryrecursive = WorkflowExpression.Compile(purgeDirectoryrecursive, nameof(purgeDirectoryrecursive), required: false);
            var __workflow_purgeDirectorydeleteTopLevel = WorkflowExpression.Compile(purgeDirectorydeleteTopLevel, nameof(purgeDirectorydeleteTopLevel), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/PurgeDirectory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var purgeDirectory = new JObject();
                var purgeDirectorypropCount = 0;
                purgeDirectorypropCount++;
                purgeDirectory["DirectoryPath"] = ExpressionConverter.ConvertO(__workflow_purgeDirectorydirectoryPath);
                if (__workflow_purgeDirectoryrecursive != null)
                {
                    if (__workflow_purgeDirectoryrecursive != null)
                    {
                        purgeDirectory["Recursive"] = ExpressionConverter.ConvertO(__workflow_purgeDirectoryrecursive);
                        purgeDirectorypropCount++;
                    }

                    purgeDirectorypropCount++;
                }
                else
                {
                    purgeDirectory["Recursive"] = false;
                    purgeDirectorypropCount++;
                }

                if (__workflow_purgeDirectorydeleteTopLevel != null)
                {
                    if (__workflow_purgeDirectorydeleteTopLevel != null)
                    {
                        purgeDirectory["DeleteTopLevel"] = ExpressionConverter.ConvertO(__workflow_purgeDirectorydeleteTopLevel);
                        purgeDirectorypropCount++;
                    }

                    purgeDirectorypropCount++;
                }
                else
                {
                    purgeDirectory["DeleteTopLevel"] = false;
                    purgeDirectorypropCount++;
                }

                purgeDirectorypropCount++;
                purgeDirectory["Workflow"] = ExpressionConverter.ConvertO(__workflow_purgeDirectoryworkflow);
                if (purgeDirectorypropCount > 0)
                {
                    callPayload.Body = purgeDirectory;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CopyFile(Expression<Func<string>> copyFilesourceFilePath, Expression<Func<string>> copyFiledestFilePath, Expression<Func<string>> copyFileworkflow)
        {
            var __workflow_copyFilesourceFilePath = WorkflowExpression.Compile(copyFilesourceFilePath, nameof(copyFilesourceFilePath), required: true);
            var __workflow_copyFiledestFilePath = WorkflowExpression.Compile(copyFiledestFilePath, nameof(copyFiledestFilePath), required: true);
            var __workflow_copyFileworkflow = WorkflowExpression.Compile(copyFileworkflow, nameof(copyFileworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/CopyFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var copyFile = new JObject();
                var copyFilepropCount = 0;
                copyFilepropCount++;
                copyFile["SourceFilePath"] = ExpressionConverter.ConvertO(__workflow_copyFilesourceFilePath);
                copyFilepropCount++;
                copyFile["DestFilePath"] = ExpressionConverter.ConvertO(__workflow_copyFiledestFilePath);
                copyFilepropCount++;
                copyFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_copyFileworkflow);
                if (copyFilepropCount > 0)
                {
                    callPayload.Body = copyFile;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveFile(Expression<Func<string>> moveFilesourceFilePath, Expression<Func<string>> moveFiledestFilePath, Expression<Func<string>> moveFileworkflow)
        {
            var __workflow_moveFilesourceFilePath = WorkflowExpression.Compile(moveFilesourceFilePath, nameof(moveFilesourceFilePath), required: true);
            var __workflow_moveFiledestFilePath = WorkflowExpression.Compile(moveFiledestFilePath, nameof(moveFiledestFilePath), required: true);
            var __workflow_moveFileworkflow = WorkflowExpression.Compile(moveFileworkflow, nameof(moveFileworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/MoveFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var moveFile = new JObject();
                var moveFilepropCount = 0;
                moveFilepropCount++;
                moveFile["SourceFilePath"] = ExpressionConverter.ConvertO(__workflow_moveFilesourceFilePath);
                moveFilepropCount++;
                moveFile["DestFilePath"] = ExpressionConverter.ConvertO(__workflow_moveFiledestFilePath);
                moveFilepropCount++;
                moveFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_moveFileworkflow);
                if (moveFilepropCount > 0)
                {
                    callPayload.Body = moveFile;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CreateDirectory(Expression<Func<string>> createDirectorydirectoryPath, Expression<Func<string>> createDirectoryworkflow, Expression<Func<bool>> createDirectoryerrorIfAlreadyExists = null)
        {
            var __workflow_createDirectorydirectoryPath = WorkflowExpression.Compile(createDirectorydirectoryPath, nameof(createDirectorydirectoryPath), required: true);
            var __workflow_createDirectoryworkflow = WorkflowExpression.Compile(createDirectoryworkflow, nameof(createDirectoryworkflow), required: true);
            var __workflow_createDirectoryerrorIfAlreadyExists = WorkflowExpression.Compile(createDirectoryerrorIfAlreadyExists, nameof(createDirectoryerrorIfAlreadyExists), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/CreateDirectory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createDirectory = new JObject();
                var createDirectorypropCount = 0;
                createDirectorypropCount++;
                createDirectory["DirectoryPath"] = ExpressionConverter.ConvertO(__workflow_createDirectorydirectoryPath);
                if (__workflow_createDirectoryerrorIfAlreadyExists != null)
                {
                    if (__workflow_createDirectoryerrorIfAlreadyExists != null)
                    {
                        createDirectory["ErrorIfAlreadyExists"] = ExpressionConverter.ConvertO(__workflow_createDirectoryerrorIfAlreadyExists);
                        createDirectorypropCount++;
                    }

                    createDirectorypropCount++;
                }
                else
                {
                    createDirectory["ErrorIfAlreadyExists"] = false;
                    createDirectorypropCount++;
                }

                createDirectorypropCount++;
                createDirectory["Workflow"] = ExpressionConverter.ConvertO(__workflow_createDirectoryworkflow);
                if (createDirectorypropCount > 0)
                {
                    callPayload.Body = createDirectory;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileSizeResponse> GetFileSize(Expression<Func<string>> getFileSizefilename, Expression<Func<string>> getFileSizeworkflow)
        {
            var __workflow_getFileSizefilename = WorkflowExpression.Compile(getFileSizefilename, nameof(getFileSizefilename), required: true);
            var __workflow_getFileSizeworkflow = WorkflowExpression.Compile(getFileSizeworkflow, nameof(getFileSizeworkflow), required: true);
            return new DeferredBodyAction<GetFileSizeResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetFileSize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getFileSize = new JObject();
                var getFileSizepropCount = 0;
                getFileSizepropCount++;
                getFileSize["Filename"] = ExpressionConverter.ConvertO(__workflow_getFileSizefilename);
                getFileSizepropCount++;
                getFileSize["Workflow"] = ExpressionConverter.ConvertO(__workflow_getFileSizeworkflow);
                if (getFileSizepropCount > 0)
                {
                    callPayload.Body = getFileSize;
                }

                return new ApiConnectionAction<GetFileSizeResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WriteTextFile(Expression<Func<string>> writeTextFilefilename, Expression<Func<string>> writeTextFileworkflow, Expression<Func<string>> writeTextFiletextToWrite = null, Expression<Func<bool>> writeTextFileappendExistingFile = null, Expression<Func<writeTextFileencodingInput>> writeTextFileencoding = null, Expression<Func<bool>> writeTextFilecreateFolderIfRequired = null)
        {
            var __workflow_writeTextFilefilename = WorkflowExpression.Compile(writeTextFilefilename, nameof(writeTextFilefilename), required: true);
            var __workflow_writeTextFileworkflow = WorkflowExpression.Compile(writeTextFileworkflow, nameof(writeTextFileworkflow), required: true);
            var __workflow_writeTextFiletextToWrite = WorkflowExpression.Compile(writeTextFiletextToWrite, nameof(writeTextFiletextToWrite), required: false);
            var __workflow_writeTextFileappendExistingFile = WorkflowExpression.Compile(writeTextFileappendExistingFile, nameof(writeTextFileappendExistingFile), required: false);
            var __workflow_writeTextFileencoding = WorkflowExpression.Compile(writeTextFileencoding, nameof(writeTextFileencoding), required: false);
            var __workflow_writeTextFilecreateFolderIfRequired = WorkflowExpression.Compile(writeTextFilecreateFolderIfRequired, nameof(writeTextFilecreateFolderIfRequired), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/WriteTextFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var writeTextFile = new JObject();
                var writeTextFilepropCount = 0;
                writeTextFilepropCount++;
                writeTextFile["Filename"] = ExpressionConverter.ConvertO(__workflow_writeTextFilefilename);
                if (__workflow_writeTextFiletextToWrite != null)
                {
                    writeTextFile["TextToWrite"] = ExpressionConverter.ConvertO(__workflow_writeTextFiletextToWrite);
                    writeTextFilepropCount++;
                }

                if (__workflow_writeTextFileappendExistingFile != null)
                {
                    if (__workflow_writeTextFileappendExistingFile != null)
                    {
                        writeTextFile["AppendExistingFile"] = ExpressionConverter.ConvertO(__workflow_writeTextFileappendExistingFile);
                        writeTextFilepropCount++;
                    }

                    writeTextFilepropCount++;
                }
                else
                {
                    writeTextFile["AppendExistingFile"] = false;
                    writeTextFilepropCount++;
                }

                if (__workflow_writeTextFileencoding != null)
                {
                    writeTextFile["Encoding"] = ExpressionConverter.ConvertO(__workflow_writeTextFileencoding);
                    writeTextFilepropCount++;
                }

                if (__workflow_writeTextFilecreateFolderIfRequired != null)
                {
                    if (__workflow_writeTextFilecreateFolderIfRequired != null)
                    {
                        writeTextFile["CreateFolderIfRequired"] = ExpressionConverter.ConvertO(__workflow_writeTextFilecreateFolderIfRequired);
                        writeTextFilepropCount++;
                    }

                    writeTextFilepropCount++;
                }
                else
                {
                    writeTextFile["CreateFolderIfRequired"] = true;
                    writeTextFilepropCount++;
                }

                writeTextFilepropCount++;
                writeTextFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_writeTextFileworkflow);
                if (writeTextFilepropCount > 0)
                {
                    callPayload.Body = writeTextFile;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ReadAllTextFromFileResponse> ReadAllTextFromFile(Expression<Func<string>> readAllTextFromFilefilename, Expression<Func<string>> readAllTextFromFileworkflow)
        {
            var __workflow_readAllTextFromFilefilename = WorkflowExpression.Compile(readAllTextFromFilefilename, nameof(readAllTextFromFilefilename), required: true);
            var __workflow_readAllTextFromFileworkflow = WorkflowExpression.Compile(readAllTextFromFileworkflow, nameof(readAllTextFromFileworkflow), required: true);
            return new DeferredBodyAction<ReadAllTextFromFileResponse>(() =>
            {
                var apiCallPath = "/FileManagement/ReadAllTextFromFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var readAllTextFromFile = new JObject();
                var readAllTextFromFilepropCount = 0;
                readAllTextFromFilepropCount++;
                readAllTextFromFile["Filename"] = ExpressionConverter.ConvertO(__workflow_readAllTextFromFilefilename);
                readAllTextFromFilepropCount++;
                readAllTextFromFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_readAllTextFromFileworkflow);
                if (readAllTextFromFilepropCount > 0)
                {
                    callPayload.Body = readAllTextFromFile;
                }

                return new ApiConnectionAction<ReadAllTextFromFileResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFilesResponse> GetFiles(Expression<Func<string>> getFilesdirectoryPath, Expression<Func<string>> getFilespatternsCSV, Expression<Func<string>> getFilesworkflow)
        {
            var __workflow_getFilesdirectoryPath = WorkflowExpression.Compile(getFilesdirectoryPath, nameof(getFilesdirectoryPath), required: true);
            var __workflow_getFilespatternsCSV = WorkflowExpression.Compile(getFilespatternsCSV, nameof(getFilespatternsCSV), required: true);
            var __workflow_getFilesworkflow = WorkflowExpression.Compile(getFilesworkflow, nameof(getFilesworkflow), required: true);
            return new DeferredBodyAction<GetFilesResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetFiles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getFiles = new JObject();
                var getFilespropCount = 0;
                getFilespropCount++;
                getFiles["DirectoryPath"] = ExpressionConverter.ConvertO(__workflow_getFilesdirectoryPath);
                getFilespropCount++;
                getFiles["PatternsCSV"] = ExpressionConverter.ConvertO(__workflow_getFilespatternsCSV);
                getFilespropCount++;
                getFiles["Workflow"] = ExpressionConverter.ConvertO(__workflow_getFilesworkflow);
                if (getFilespropCount > 0)
                {
                    callPayload.Body = getFiles;
                }

                return new ApiConnectionAction<GetFilesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFoldersResponse> GetFolders(Expression<Func<string>> getFoldersdirectoryPath, Expression<Func<string>> getFoldersworkflow)
        {
            var __workflow_getFoldersdirectoryPath = WorkflowExpression.Compile(getFoldersdirectoryPath, nameof(getFoldersdirectoryPath), required: true);
            var __workflow_getFoldersworkflow = WorkflowExpression.Compile(getFoldersworkflow, nameof(getFoldersworkflow), required: true);
            return new DeferredBodyAction<GetFoldersResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetFolders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getFolders = new JObject();
                var getFolderspropCount = 0;
                getFolderspropCount++;
                getFolders["DirectoryPath"] = ExpressionConverter.ConvertO(__workflow_getFoldersdirectoryPath);
                getFolderspropCount++;
                getFolders["Workflow"] = ExpressionConverter.ConvertO(__workflow_getFoldersworkflow);
                if (getFolderspropCount > 0)
                {
                    callPayload.Body = getFolders;
                }

                return new ApiConnectionAction<GetFoldersResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeleteFilesResponse> DeleteFiles(Expression<Func<string>> deleteFilesdirectoryPath, Expression<Func<string>> deleteFilesworkflow, Expression<Func<string>> deleteFilespattern = null)
        {
            var __workflow_deleteFilesdirectoryPath = WorkflowExpression.Compile(deleteFilesdirectoryPath, nameof(deleteFilesdirectoryPath), required: true);
            var __workflow_deleteFilesworkflow = WorkflowExpression.Compile(deleteFilesworkflow, nameof(deleteFilesworkflow), required: true);
            var __workflow_deleteFilespattern = WorkflowExpression.Compile(deleteFilespattern, nameof(deleteFilespattern), required: false);
            return new DeferredBodyAction<DeleteFilesResponse>(() =>
            {
                var apiCallPath = "/FileManagement/DeleteFiles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteFiles = new JObject();
                var deleteFilespropCount = 0;
                deleteFilespropCount++;
                deleteFiles["DirectoryPath"] = ExpressionConverter.ConvertO(__workflow_deleteFilesdirectoryPath);
                if (__workflow_deleteFilespattern != null)
                {
                    deleteFiles["Pattern"] = ExpressionConverter.ConvertO(__workflow_deleteFilespattern);
                    deleteFilespropCount++;
                }

                deleteFilespropCount++;
                deleteFiles["Workflow"] = ExpressionConverter.ConvertO(__workflow_deleteFilesworkflow);
                if (deleteFilespropCount > 0)
                {
                    callPayload.Body = deleteFiles;
                }

                return new ApiConnectionAction<DeleteFilesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDiskFreeSpaceResponse> GetDiskFreeSpace(Expression<Func<string>> getDiskFreeSpacedriveLetter, Expression<Func<string>> getDiskFreeSpaceworkflow)
        {
            var __workflow_getDiskFreeSpacedriveLetter = WorkflowExpression.Compile(getDiskFreeSpacedriveLetter, nameof(getDiskFreeSpacedriveLetter), required: true);
            var __workflow_getDiskFreeSpaceworkflow = WorkflowExpression.Compile(getDiskFreeSpaceworkflow, nameof(getDiskFreeSpaceworkflow), required: true);
            return new DeferredBodyAction<GetDiskFreeSpaceResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetDiskFreeSpace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getDiskFreeSpace = new JObject();
                var getDiskFreeSpacepropCount = 0;
                getDiskFreeSpacepropCount++;
                getDiskFreeSpace["DriveLetter"] = ExpressionConverter.ConvertO(__workflow_getDiskFreeSpacedriveLetter);
                getDiskFreeSpacepropCount++;
                getDiskFreeSpace["Workflow"] = ExpressionConverter.ConvertO(__workflow_getDiskFreeSpaceworkflow);
                if (getDiskFreeSpacepropCount > 0)
                {
                    callPayload.Body = getDiskFreeSpace;
                }

                return new ApiConnectionAction<GetDiskFreeSpaceResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfDrivesResponse> GetListOfDrives(Expression<Func<string>> getListOfDrivesworkflow)
        {
            var __workflow_getListOfDrivesworkflow = WorkflowExpression.Compile(getListOfDrivesworkflow, nameof(getListOfDrivesworkflow), required: true);
            return new DeferredBodyAction<GetListOfDrivesResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetListOfDrives";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getListOfDrives = new JObject();
                var getListOfDrivespropCount = 0;
                getListOfDrivespropCount++;
                getListOfDrives["Workflow"] = ExpressionConverter.ConvertO(__workflow_getListOfDrivesworkflow);
                if (getListOfDrivespropCount > 0)
                {
                    callPayload.Body = getListOfDrives;
                }

                return new ApiConnectionAction<GetListOfDrivesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DirectoryIsAccessibleResponse> DirectoryIsAccessible(Expression<Func<string>> directoryIsAccessibledirectoryPath, Expression<Func<string>> directoryIsAccessibleworkflow)
        {
            var __workflow_directoryIsAccessibledirectoryPath = WorkflowExpression.Compile(directoryIsAccessibledirectoryPath, nameof(directoryIsAccessibledirectoryPath), required: true);
            var __workflow_directoryIsAccessibleworkflow = WorkflowExpression.Compile(directoryIsAccessibleworkflow, nameof(directoryIsAccessibleworkflow), required: true);
            return new DeferredBodyAction<DirectoryIsAccessibleResponse>(() =>
            {
                var apiCallPath = "/FileManagement/DirectoryIsAccessible";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var directoryIsAccessible = new JObject();
                var directoryIsAccessiblepropCount = 0;
                directoryIsAccessiblepropCount++;
                directoryIsAccessible["DirectoryPath"] = ExpressionConverter.ConvertO(__workflow_directoryIsAccessibledirectoryPath);
                directoryIsAccessiblepropCount++;
                directoryIsAccessible["Workflow"] = ExpressionConverter.ConvertO(__workflow_directoryIsAccessibleworkflow);
                if (directoryIsAccessiblepropCount > 0)
                {
                    callPayload.Body = directoryIsAccessible;
                }

                return new ApiConnectionAction<DirectoryIsAccessibleResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetCSVTextAsCollectionResponse> GetCSVTextAsCollection(Expression<Func<string>> getCSVTextAsCollectioncSVFilePath, Expression<Func<string>> getCSVTextAsCollectionworkflow, Expression<Func<bool>> getCSVTextAsCollectionfirstLineIsHeader = null, Expression<Func<bool>> getCSVTextAsCollectiontrimHeaders = null, Expression<Func<bool>> getCSVTextAsCollectionallowBlankRows = null, Expression<Func<bool>> getCSVTextAsCollectionextendColumnsIfRequired = null)
        {
            var __workflow_getCSVTextAsCollectioncSVFilePath = WorkflowExpression.Compile(getCSVTextAsCollectioncSVFilePath, nameof(getCSVTextAsCollectioncSVFilePath), required: true);
            var __workflow_getCSVTextAsCollectionworkflow = WorkflowExpression.Compile(getCSVTextAsCollectionworkflow, nameof(getCSVTextAsCollectionworkflow), required: true);
            var __workflow_getCSVTextAsCollectionfirstLineIsHeader = WorkflowExpression.Compile(getCSVTextAsCollectionfirstLineIsHeader, nameof(getCSVTextAsCollectionfirstLineIsHeader), required: false);
            var __workflow_getCSVTextAsCollectiontrimHeaders = WorkflowExpression.Compile(getCSVTextAsCollectiontrimHeaders, nameof(getCSVTextAsCollectiontrimHeaders), required: false);
            var __workflow_getCSVTextAsCollectionallowBlankRows = WorkflowExpression.Compile(getCSVTextAsCollectionallowBlankRows, nameof(getCSVTextAsCollectionallowBlankRows), required: false);
            var __workflow_getCSVTextAsCollectionextendColumnsIfRequired = WorkflowExpression.Compile(getCSVTextAsCollectionextendColumnsIfRequired, nameof(getCSVTextAsCollectionextendColumnsIfRequired), required: false);
            return new DeferredBodyAction<GetCSVTextAsCollectionResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetCSVTextAsCollection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getCSVTextAsCollection = new JObject();
                var getCSVTextAsCollectionpropCount = 0;
                getCSVTextAsCollectionpropCount++;
                getCSVTextAsCollection["CSVFilePath"] = ExpressionConverter.ConvertO(__workflow_getCSVTextAsCollectioncSVFilePath);
                if (__workflow_getCSVTextAsCollectionfirstLineIsHeader != null)
                {
                    if (__workflow_getCSVTextAsCollectionfirstLineIsHeader != null)
                    {
                        getCSVTextAsCollection["FirstLineIsHeader"] = ExpressionConverter.ConvertO(__workflow_getCSVTextAsCollectionfirstLineIsHeader);
                        getCSVTextAsCollectionpropCount++;
                    }

                    getCSVTextAsCollectionpropCount++;
                }
                else
                {
                    getCSVTextAsCollection["FirstLineIsHeader"] = true;
                    getCSVTextAsCollectionpropCount++;
                }

                if (__workflow_getCSVTextAsCollectiontrimHeaders != null)
                {
                    if (__workflow_getCSVTextAsCollectiontrimHeaders != null)
                    {
                        getCSVTextAsCollection["TrimHeaders"] = ExpressionConverter.ConvertO(__workflow_getCSVTextAsCollectiontrimHeaders);
                        getCSVTextAsCollectionpropCount++;
                    }

                    getCSVTextAsCollectionpropCount++;
                }
                else
                {
                    getCSVTextAsCollection["TrimHeaders"] = true;
                    getCSVTextAsCollectionpropCount++;
                }

                if (__workflow_getCSVTextAsCollectionallowBlankRows != null)
                {
                    if (__workflow_getCSVTextAsCollectionallowBlankRows != null)
                    {
                        getCSVTextAsCollection["AllowBlankRows"] = ExpressionConverter.ConvertO(__workflow_getCSVTextAsCollectionallowBlankRows);
                        getCSVTextAsCollectionpropCount++;
                    }

                    getCSVTextAsCollectionpropCount++;
                }
                else
                {
                    getCSVTextAsCollection["AllowBlankRows"] = true;
                    getCSVTextAsCollectionpropCount++;
                }

                if (__workflow_getCSVTextAsCollectionextendColumnsIfRequired != null)
                {
                    if (__workflow_getCSVTextAsCollectionextendColumnsIfRequired != null)
                    {
                        getCSVTextAsCollection["ExtendColumnsIfRequired"] = ExpressionConverter.ConvertO(__workflow_getCSVTextAsCollectionextendColumnsIfRequired);
                        getCSVTextAsCollectionpropCount++;
                    }

                    getCSVTextAsCollectionpropCount++;
                }
                else
                {
                    getCSVTextAsCollection["ExtendColumnsIfRequired"] = false;
                    getCSVTextAsCollectionpropCount++;
                }

                getCSVTextAsCollectionpropCount++;
                getCSVTextAsCollection["Workflow"] = ExpressionConverter.ConvertO(__workflow_getCSVTextAsCollectionworkflow);
                if (getCSVTextAsCollectionpropCount > 0)
                {
                    callPayload.Body = getCSVTextAsCollection;
                }

                return new ApiConnectionAction<GetCSVTextAsCollectionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WriteCollectionToCSVFileResponse> WriteCollectionToCSVFile(Expression<Func<string>> writeCollectionToCSVFilecSVFilePath, Expression<Func<string>> writeCollectionToCSVFileworkflow, Expression<Func<JToken[]>> writeCollectionToCSVFileinputTable = null, Expression<Func<string>> writeCollectionToCSVFileinputTableJSON = null, Expression<Func<writeCollectionToCSVFileoutputEncodingInput>> writeCollectionToCSVFileoutputEncoding = null)
        {
            var __workflow_writeCollectionToCSVFilecSVFilePath = WorkflowExpression.Compile(writeCollectionToCSVFilecSVFilePath, nameof(writeCollectionToCSVFilecSVFilePath), required: true);
            var __workflow_writeCollectionToCSVFileworkflow = WorkflowExpression.Compile(writeCollectionToCSVFileworkflow, nameof(writeCollectionToCSVFileworkflow), required: true);
            var __workflow_writeCollectionToCSVFileinputTable = WorkflowExpression.Compile(writeCollectionToCSVFileinputTable, nameof(writeCollectionToCSVFileinputTable), required: false);
            var __workflow_writeCollectionToCSVFileinputTableJSON = WorkflowExpression.Compile(writeCollectionToCSVFileinputTableJSON, nameof(writeCollectionToCSVFileinputTableJSON), required: false);
            var __workflow_writeCollectionToCSVFileoutputEncoding = WorkflowExpression.Compile(writeCollectionToCSVFileoutputEncoding, nameof(writeCollectionToCSVFileoutputEncoding), required: false);
            return new DeferredBodyAction<WriteCollectionToCSVFileResponse>(() =>
            {
                var apiCallPath = "/FileManagement/WriteCollectionToCSVFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var writeCollectionToCSVFile = new JObject();
                var writeCollectionToCSVFilepropCount = 0;
                if (__workflow_writeCollectionToCSVFileinputTable != null)
                {
                    writeCollectionToCSVFile["InputTable"] = ExpressionConverter.ConvertO(__workflow_writeCollectionToCSVFileinputTable);
                    writeCollectionToCSVFilepropCount++;
                }

                if (__workflow_writeCollectionToCSVFileinputTableJSON != null)
                {
                    writeCollectionToCSVFile["InputTableJSON"] = ExpressionConverter.ConvertO(__workflow_writeCollectionToCSVFileinputTableJSON);
                    writeCollectionToCSVFilepropCount++;
                }

                writeCollectionToCSVFilepropCount++;
                writeCollectionToCSVFile["CSVFilePath"] = ExpressionConverter.ConvertO(__workflow_writeCollectionToCSVFilecSVFilePath);
                if (__workflow_writeCollectionToCSVFileoutputEncoding != null)
                {
                    if (__workflow_writeCollectionToCSVFileoutputEncoding != null)
                    {
                        writeCollectionToCSVFile["OutputEncoding"] = ExpressionConverter.ConvertO(__workflow_writeCollectionToCSVFileoutputEncoding);
                        writeCollectionToCSVFilepropCount++;
                    }

                    writeCollectionToCSVFilepropCount++;
                }
                else
                {
                    writeCollectionToCSVFile["OutputEncoding"] = "UTF8";
                    writeCollectionToCSVFilepropCount++;
                }

                writeCollectionToCSVFilepropCount++;
                writeCollectionToCSVFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_writeCollectionToCSVFileworkflow);
                if (writeCollectionToCSVFilepropCount > 0)
                {
                    callPayload.Body = writeCollectionToCSVFile;
                }

                return new ApiConnectionAction<WriteCollectionToCSVFileResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetOwnerOnFolder(Expression<Func<string>> setOwnerOnFolderfolderPath, Expression<Func<string>> setOwnerOnFolderuserIdentity, Expression<Func<string>> setOwnerOnFolderworkflow)
        {
            var __workflow_setOwnerOnFolderfolderPath = WorkflowExpression.Compile(setOwnerOnFolderfolderPath, nameof(setOwnerOnFolderfolderPath), required: true);
            var __workflow_setOwnerOnFolderuserIdentity = WorkflowExpression.Compile(setOwnerOnFolderuserIdentity, nameof(setOwnerOnFolderuserIdentity), required: true);
            var __workflow_setOwnerOnFolderworkflow = WorkflowExpression.Compile(setOwnerOnFolderworkflow, nameof(setOwnerOnFolderworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/SetOwnerOnFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setOwnerOnFolder = new JObject();
                var setOwnerOnFolderpropCount = 0;
                setOwnerOnFolderpropCount++;
                setOwnerOnFolder["FolderPath"] = ExpressionConverter.ConvertO(__workflow_setOwnerOnFolderfolderPath);
                setOwnerOnFolderpropCount++;
                setOwnerOnFolder["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_setOwnerOnFolderuserIdentity);
                setOwnerOnFolderpropCount++;
                setOwnerOnFolder["Workflow"] = ExpressionConverter.ConvertO(__workflow_setOwnerOnFolderworkflow);
                if (setOwnerOnFolderpropCount > 0)
                {
                    callPayload.Body = setOwnerOnFolder;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetOwnerOnFile(Expression<Func<string>> setOwnerOnFilefilePath, Expression<Func<string>> setOwnerOnFileuserIdentity, Expression<Func<string>> setOwnerOnFileworkflow)
        {
            var __workflow_setOwnerOnFilefilePath = WorkflowExpression.Compile(setOwnerOnFilefilePath, nameof(setOwnerOnFilefilePath), required: true);
            var __workflow_setOwnerOnFileuserIdentity = WorkflowExpression.Compile(setOwnerOnFileuserIdentity, nameof(setOwnerOnFileuserIdentity), required: true);
            var __workflow_setOwnerOnFileworkflow = WorkflowExpression.Compile(setOwnerOnFileworkflow, nameof(setOwnerOnFileworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/SetOwnerOnFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setOwnerOnFile = new JObject();
                var setOwnerOnFilepropCount = 0;
                setOwnerOnFilepropCount++;
                setOwnerOnFile["FilePath"] = ExpressionConverter.ConvertO(__workflow_setOwnerOnFilefilePath);
                setOwnerOnFilepropCount++;
                setOwnerOnFile["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_setOwnerOnFileuserIdentity);
                setOwnerOnFilepropCount++;
                setOwnerOnFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_setOwnerOnFileworkflow);
                if (setOwnerOnFilepropCount > 0)
                {
                    callPayload.Body = setOwnerOnFile;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddPermissionToFolder(Expression<Func<string>> addPermissionToFolderfolderPath, Expression<Func<string>> addPermissionToFolderidentity, Expression<Func<addPermissionToFolderpermissionInput>> addPermissionToFolderpermission, Expression<Func<string>> addPermissionToFolderworkflow, Expression<Func<bool>> addPermissionToFolderapplyToFolder = null, Expression<Func<bool>> addPermissionToFolderapplyToSubFolders = null, Expression<Func<bool>> addPermissionToFolderapplyToFiles = null, Expression<Func<bool>> addPermissionToFolderdeny = null)
        {
            var __workflow_addPermissionToFolderfolderPath = WorkflowExpression.Compile(addPermissionToFolderfolderPath, nameof(addPermissionToFolderfolderPath), required: true);
            var __workflow_addPermissionToFolderidentity = WorkflowExpression.Compile(addPermissionToFolderidentity, nameof(addPermissionToFolderidentity), required: true);
            var __workflow_addPermissionToFolderpermission = WorkflowExpression.Compile(addPermissionToFolderpermission, nameof(addPermissionToFolderpermission), required: true);
            var __workflow_addPermissionToFolderworkflow = WorkflowExpression.Compile(addPermissionToFolderworkflow, nameof(addPermissionToFolderworkflow), required: true);
            var __workflow_addPermissionToFolderapplyToFolder = WorkflowExpression.Compile(addPermissionToFolderapplyToFolder, nameof(addPermissionToFolderapplyToFolder), required: false);
            var __workflow_addPermissionToFolderapplyToSubFolders = WorkflowExpression.Compile(addPermissionToFolderapplyToSubFolders, nameof(addPermissionToFolderapplyToSubFolders), required: false);
            var __workflow_addPermissionToFolderapplyToFiles = WorkflowExpression.Compile(addPermissionToFolderapplyToFiles, nameof(addPermissionToFolderapplyToFiles), required: false);
            var __workflow_addPermissionToFolderdeny = WorkflowExpression.Compile(addPermissionToFolderdeny, nameof(addPermissionToFolderdeny), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/AddPermissionToFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addPermissionToFolder = new JObject();
                var addPermissionToFolderpropCount = 0;
                addPermissionToFolderpropCount++;
                addPermissionToFolder["FolderPath"] = ExpressionConverter.ConvertO(__workflow_addPermissionToFolderfolderPath);
                addPermissionToFolderpropCount++;
                addPermissionToFolder["Identity"] = ExpressionConverter.ConvertO(__workflow_addPermissionToFolderidentity);
                addPermissionToFolderpropCount++;
                addPermissionToFolder["Permission"] = ExpressionConverter.ConvertO(__workflow_addPermissionToFolderpermission);
                if (__workflow_addPermissionToFolderapplyToFolder != null)
                {
                    if (__workflow_addPermissionToFolderapplyToFolder != null)
                    {
                        addPermissionToFolder["ApplyToFolder"] = ExpressionConverter.ConvertO(__workflow_addPermissionToFolderapplyToFolder);
                        addPermissionToFolderpropCount++;
                    }

                    addPermissionToFolderpropCount++;
                }
                else
                {
                    addPermissionToFolder["ApplyToFolder"] = false;
                    addPermissionToFolderpropCount++;
                }

                if (__workflow_addPermissionToFolderapplyToSubFolders != null)
                {
                    if (__workflow_addPermissionToFolderapplyToSubFolders != null)
                    {
                        addPermissionToFolder["ApplyToSubFolders"] = ExpressionConverter.ConvertO(__workflow_addPermissionToFolderapplyToSubFolders);
                        addPermissionToFolderpropCount++;
                    }

                    addPermissionToFolderpropCount++;
                }
                else
                {
                    addPermissionToFolder["ApplyToSubFolders"] = true;
                    addPermissionToFolderpropCount++;
                }

                if (__workflow_addPermissionToFolderapplyToFiles != null)
                {
                    if (__workflow_addPermissionToFolderapplyToFiles != null)
                    {
                        addPermissionToFolder["ApplyToFiles"] = ExpressionConverter.ConvertO(__workflow_addPermissionToFolderapplyToFiles);
                        addPermissionToFolderpropCount++;
                    }

                    addPermissionToFolderpropCount++;
                }
                else
                {
                    addPermissionToFolder["ApplyToFiles"] = true;
                    addPermissionToFolderpropCount++;
                }

                if (__workflow_addPermissionToFolderdeny != null)
                {
                    if (__workflow_addPermissionToFolderdeny != null)
                    {
                        addPermissionToFolder["Deny"] = ExpressionConverter.ConvertO(__workflow_addPermissionToFolderdeny);
                        addPermissionToFolderpropCount++;
                    }

                    addPermissionToFolderpropCount++;
                }
                else
                {
                    addPermissionToFolder["Deny"] = false;
                    addPermissionToFolderpropCount++;
                }

                addPermissionToFolderpropCount++;
                addPermissionToFolder["Workflow"] = ExpressionConverter.ConvertO(__workflow_addPermissionToFolderworkflow);
                if (addPermissionToFolderpropCount > 0)
                {
                    callPayload.Body = addPermissionToFolder;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddPermissionToFile(Expression<Func<string>> addPermissionToFilefilePath, Expression<Func<string>> addPermissionToFileidentity, Expression<Func<addPermissionToFilepermissionInput>> addPermissionToFilepermission, Expression<Func<string>> addPermissionToFileworkflow, Expression<Func<bool>> addPermissionToFiledeny = null)
        {
            var __workflow_addPermissionToFilefilePath = WorkflowExpression.Compile(addPermissionToFilefilePath, nameof(addPermissionToFilefilePath), required: true);
            var __workflow_addPermissionToFileidentity = WorkflowExpression.Compile(addPermissionToFileidentity, nameof(addPermissionToFileidentity), required: true);
            var __workflow_addPermissionToFilepermission = WorkflowExpression.Compile(addPermissionToFilepermission, nameof(addPermissionToFilepermission), required: true);
            var __workflow_addPermissionToFileworkflow = WorkflowExpression.Compile(addPermissionToFileworkflow, nameof(addPermissionToFileworkflow), required: true);
            var __workflow_addPermissionToFiledeny = WorkflowExpression.Compile(addPermissionToFiledeny, nameof(addPermissionToFiledeny), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/AddPermissionToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addPermissionToFile = new JObject();
                var addPermissionToFilepropCount = 0;
                addPermissionToFilepropCount++;
                addPermissionToFile["FilePath"] = ExpressionConverter.ConvertO(__workflow_addPermissionToFilefilePath);
                addPermissionToFilepropCount++;
                addPermissionToFile["Identity"] = ExpressionConverter.ConvertO(__workflow_addPermissionToFileidentity);
                addPermissionToFilepropCount++;
                addPermissionToFile["Permission"] = ExpressionConverter.ConvertO(__workflow_addPermissionToFilepermission);
                if (__workflow_addPermissionToFiledeny != null)
                {
                    if (__workflow_addPermissionToFiledeny != null)
                    {
                        addPermissionToFile["Deny"] = ExpressionConverter.ConvertO(__workflow_addPermissionToFiledeny);
                        addPermissionToFilepropCount++;
                    }

                    addPermissionToFilepropCount++;
                }
                else
                {
                    addPermissionToFile["Deny"] = false;
                    addPermissionToFilepropCount++;
                }

                addPermissionToFilepropCount++;
                addPermissionToFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_addPermissionToFileworkflow);
                if (addPermissionToFilepropCount > 0)
                {
                    callPayload.Body = addPermissionToFile;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction BreakFolderSecurityInheritance(Expression<Func<string>> breakFolderSecurityInheritancefolderPath, Expression<Func<string>> breakFolderSecurityInheritanceworkflow, Expression<Func<bool>> breakFolderSecurityInheritanceconvertInheritedToExplicit = null)
        {
            var __workflow_breakFolderSecurityInheritancefolderPath = WorkflowExpression.Compile(breakFolderSecurityInheritancefolderPath, nameof(breakFolderSecurityInheritancefolderPath), required: true);
            var __workflow_breakFolderSecurityInheritanceworkflow = WorkflowExpression.Compile(breakFolderSecurityInheritanceworkflow, nameof(breakFolderSecurityInheritanceworkflow), required: true);
            var __workflow_breakFolderSecurityInheritanceconvertInheritedToExplicit = WorkflowExpression.Compile(breakFolderSecurityInheritanceconvertInheritedToExplicit, nameof(breakFolderSecurityInheritanceconvertInheritedToExplicit), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/BreakFolderSecurityInheritance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var breakFolderSecurityInheritance = new JObject();
                var breakFolderSecurityInheritancepropCount = 0;
                breakFolderSecurityInheritancepropCount++;
                breakFolderSecurityInheritance["FolderPath"] = ExpressionConverter.ConvertO(__workflow_breakFolderSecurityInheritancefolderPath);
                if (__workflow_breakFolderSecurityInheritanceconvertInheritedToExplicit != null)
                {
                    if (__workflow_breakFolderSecurityInheritanceconvertInheritedToExplicit != null)
                    {
                        breakFolderSecurityInheritance["ConvertInheritedToExplicit"] = ExpressionConverter.ConvertO(__workflow_breakFolderSecurityInheritanceconvertInheritedToExplicit);
                        breakFolderSecurityInheritancepropCount++;
                    }

                    breakFolderSecurityInheritancepropCount++;
                }
                else
                {
                    breakFolderSecurityInheritance["ConvertInheritedToExplicit"] = true;
                    breakFolderSecurityInheritancepropCount++;
                }

                breakFolderSecurityInheritancepropCount++;
                breakFolderSecurityInheritance["Workflow"] = ExpressionConverter.ConvertO(__workflow_breakFolderSecurityInheritanceworkflow);
                if (breakFolderSecurityInheritancepropCount > 0)
                {
                    callPayload.Body = breakFolderSecurityInheritance;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction EnableFolderSecurityInheritance(Expression<Func<string>> enableFolderSecurityInheritancefolderPath, Expression<Func<string>> enableFolderSecurityInheritanceworkflow)
        {
            var __workflow_enableFolderSecurityInheritancefolderPath = WorkflowExpression.Compile(enableFolderSecurityInheritancefolderPath, nameof(enableFolderSecurityInheritancefolderPath), required: true);
            var __workflow_enableFolderSecurityInheritanceworkflow = WorkflowExpression.Compile(enableFolderSecurityInheritanceworkflow, nameof(enableFolderSecurityInheritanceworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/EnableFolderSecurityInheritance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var enableFolderSecurityInheritance = new JObject();
                var enableFolderSecurityInheritancepropCount = 0;
                enableFolderSecurityInheritancepropCount++;
                enableFolderSecurityInheritance["FolderPath"] = ExpressionConverter.ConvertO(__workflow_enableFolderSecurityInheritancefolderPath);
                enableFolderSecurityInheritancepropCount++;
                enableFolderSecurityInheritance["Workflow"] = ExpressionConverter.ConvertO(__workflow_enableFolderSecurityInheritanceworkflow);
                if (enableFolderSecurityInheritancepropCount > 0)
                {
                    callPayload.Body = enableFolderSecurityInheritance;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFolderSecurityPermissionsResponse> GetFolderSecurityPermissions(Expression<Func<string>> getFolderSecurityPermissionsfolderPath, Expression<Func<string>> getFolderSecurityPermissionsworkflow)
        {
            var __workflow_getFolderSecurityPermissionsfolderPath = WorkflowExpression.Compile(getFolderSecurityPermissionsfolderPath, nameof(getFolderSecurityPermissionsfolderPath), required: true);
            var __workflow_getFolderSecurityPermissionsworkflow = WorkflowExpression.Compile(getFolderSecurityPermissionsworkflow, nameof(getFolderSecurityPermissionsworkflow), required: true);
            return new DeferredBodyAction<GetFolderSecurityPermissionsResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetFolderSecurityPermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getFolderSecurityPermissions = new JObject();
                var getFolderSecurityPermissionspropCount = 0;
                getFolderSecurityPermissionspropCount++;
                getFolderSecurityPermissions["FolderPath"] = ExpressionConverter.ConvertO(__workflow_getFolderSecurityPermissionsfolderPath);
                getFolderSecurityPermissionspropCount++;
                getFolderSecurityPermissions["Workflow"] = ExpressionConverter.ConvertO(__workflow_getFolderSecurityPermissionsworkflow);
                if (getFolderSecurityPermissionspropCount > 0)
                {
                    callPayload.Body = getFolderSecurityPermissions;
                }

                return new ApiConnectionAction<GetFolderSecurityPermissionsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileSecurityPermissionsResponse> GetFileSecurityPermissions(Expression<Func<string>> getFileSecurityPermissionsfilePath, Expression<Func<string>> getFileSecurityPermissionsworkflow)
        {
            var __workflow_getFileSecurityPermissionsfilePath = WorkflowExpression.Compile(getFileSecurityPermissionsfilePath, nameof(getFileSecurityPermissionsfilePath), required: true);
            var __workflow_getFileSecurityPermissionsworkflow = WorkflowExpression.Compile(getFileSecurityPermissionsworkflow, nameof(getFileSecurityPermissionsworkflow), required: true);
            return new DeferredBodyAction<GetFileSecurityPermissionsResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetFileSecurityPermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getFileSecurityPermissions = new JObject();
                var getFileSecurityPermissionspropCount = 0;
                getFileSecurityPermissionspropCount++;
                getFileSecurityPermissions["FilePath"] = ExpressionConverter.ConvertO(__workflow_getFileSecurityPermissionsfilePath);
                getFileSecurityPermissionspropCount++;
                getFileSecurityPermissions["Workflow"] = ExpressionConverter.ConvertO(__workflow_getFileSecurityPermissionsworkflow);
                if (getFileSecurityPermissionspropCount > 0)
                {
                    callPayload.Body = getFileSecurityPermissions;
                }

                return new ApiConnectionAction<GetFileSecurityPermissionsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RemoveIdentityFromFolderSecurityResponse> RemoveIdentityFromFolderSecurity(Expression<Func<string>> removeIdentityFromFolderSecurityfolderPath, Expression<Func<string>> removeIdentityFromFolderSecurityidentityToRemove, Expression<Func<string>> removeIdentityFromFolderSecurityworkflow)
        {
            var __workflow_removeIdentityFromFolderSecurityfolderPath = WorkflowExpression.Compile(removeIdentityFromFolderSecurityfolderPath, nameof(removeIdentityFromFolderSecurityfolderPath), required: true);
            var __workflow_removeIdentityFromFolderSecurityidentityToRemove = WorkflowExpression.Compile(removeIdentityFromFolderSecurityidentityToRemove, nameof(removeIdentityFromFolderSecurityidentityToRemove), required: true);
            var __workflow_removeIdentityFromFolderSecurityworkflow = WorkflowExpression.Compile(removeIdentityFromFolderSecurityworkflow, nameof(removeIdentityFromFolderSecurityworkflow), required: true);
            return new DeferredBodyAction<RemoveIdentityFromFolderSecurityResponse>(() =>
            {
                var apiCallPath = "/FileManagement/RemoveIdentityFromFolderSecurity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var removeIdentityFromFolderSecurity = new JObject();
                var removeIdentityFromFolderSecuritypropCount = 0;
                removeIdentityFromFolderSecuritypropCount++;
                removeIdentityFromFolderSecurity["FolderPath"] = ExpressionConverter.ConvertO(__workflow_removeIdentityFromFolderSecurityfolderPath);
                removeIdentityFromFolderSecuritypropCount++;
                removeIdentityFromFolderSecurity["IdentityToRemove"] = ExpressionConverter.ConvertO(__workflow_removeIdentityFromFolderSecurityidentityToRemove);
                removeIdentityFromFolderSecuritypropCount++;
                removeIdentityFromFolderSecurity["Workflow"] = ExpressionConverter.ConvertO(__workflow_removeIdentityFromFolderSecurityworkflow);
                if (removeIdentityFromFolderSecuritypropCount > 0)
                {
                    callPayload.Body = removeIdentityFromFolderSecurity;
                }

                return new ApiConnectionAction<RemoveIdentityFromFolderSecurityResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RemoveIdentityFromFileSecurityResponse> RemoveIdentityFromFileSecurity(Expression<Func<string>> removeIdentityFromFileSecurityfilePath, Expression<Func<string>> removeIdentityFromFileSecurityidentityToRemove, Expression<Func<string>> removeIdentityFromFileSecurityworkflow)
        {
            var __workflow_removeIdentityFromFileSecurityfilePath = WorkflowExpression.Compile(removeIdentityFromFileSecurityfilePath, nameof(removeIdentityFromFileSecurityfilePath), required: true);
            var __workflow_removeIdentityFromFileSecurityidentityToRemove = WorkflowExpression.Compile(removeIdentityFromFileSecurityidentityToRemove, nameof(removeIdentityFromFileSecurityidentityToRemove), required: true);
            var __workflow_removeIdentityFromFileSecurityworkflow = WorkflowExpression.Compile(removeIdentityFromFileSecurityworkflow, nameof(removeIdentityFromFileSecurityworkflow), required: true);
            return new DeferredBodyAction<RemoveIdentityFromFileSecurityResponse>(() =>
            {
                var apiCallPath = "/FileManagement/RemoveIdentityFromFileSecurity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var removeIdentityFromFileSecurity = new JObject();
                var removeIdentityFromFileSecuritypropCount = 0;
                removeIdentityFromFileSecuritypropCount++;
                removeIdentityFromFileSecurity["FilePath"] = ExpressionConverter.ConvertO(__workflow_removeIdentityFromFileSecurityfilePath);
                removeIdentityFromFileSecuritypropCount++;
                removeIdentityFromFileSecurity["IdentityToRemove"] = ExpressionConverter.ConvertO(__workflow_removeIdentityFromFileSecurityidentityToRemove);
                removeIdentityFromFileSecuritypropCount++;
                removeIdentityFromFileSecurity["Workflow"] = ExpressionConverter.ConvertO(__workflow_removeIdentityFromFileSecurityworkflow);
                if (removeIdentityFromFileSecuritypropCount > 0)
                {
                    callPayload.Body = removeIdentityFromFileSecurity;
                }

                return new ApiConnectionAction<RemoveIdentityFromFileSecurityResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CopyFileFromClientToServer(Expression<Func<string>> copyFileFromClientToServerclientFilePath, Expression<Func<string>> copyFileFromClientToServerserverFilePath, Expression<Func<string>> copyFileFromClientToServerworkflow, Expression<Func<bool>> copyFileFromClientToServercompress = null)
        {
            var __workflow_copyFileFromClientToServerclientFilePath = WorkflowExpression.Compile(copyFileFromClientToServerclientFilePath, nameof(copyFileFromClientToServerclientFilePath), required: true);
            var __workflow_copyFileFromClientToServerserverFilePath = WorkflowExpression.Compile(copyFileFromClientToServerserverFilePath, nameof(copyFileFromClientToServerserverFilePath), required: true);
            var __workflow_copyFileFromClientToServerworkflow = WorkflowExpression.Compile(copyFileFromClientToServerworkflow, nameof(copyFileFromClientToServerworkflow), required: true);
            var __workflow_copyFileFromClientToServercompress = WorkflowExpression.Compile(copyFileFromClientToServercompress, nameof(copyFileFromClientToServercompress), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/CopyFileFromClientToServer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var copyFileFromClientToServer = new JObject();
                var copyFileFromClientToServerpropCount = 0;
                copyFileFromClientToServerpropCount++;
                copyFileFromClientToServer["ClientFilePath"] = ExpressionConverter.ConvertO(__workflow_copyFileFromClientToServerclientFilePath);
                copyFileFromClientToServerpropCount++;
                copyFileFromClientToServer["ServerFilePath"] = ExpressionConverter.ConvertO(__workflow_copyFileFromClientToServerserverFilePath);
                if (__workflow_copyFileFromClientToServercompress != null)
                {
                    if (__workflow_copyFileFromClientToServercompress != null)
                    {
                        copyFileFromClientToServer["Compress"] = ExpressionConverter.ConvertO(__workflow_copyFileFromClientToServercompress);
                        copyFileFromClientToServerpropCount++;
                    }

                    copyFileFromClientToServerpropCount++;
                }
                else
                {
                    copyFileFromClientToServer["Compress"] = true;
                    copyFileFromClientToServerpropCount++;
                }

                copyFileFromClientToServerpropCount++;
                copyFileFromClientToServer["Workflow"] = ExpressionConverter.ConvertO(__workflow_copyFileFromClientToServerworkflow);
                if (copyFileFromClientToServerpropCount > 0)
                {
                    callPayload.Body = copyFileFromClientToServer;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ReplaceVariableDataInINIFile(Expression<Func<string>> replaceVariableDataInINIFileinputFilename, Expression<Func<string>> replaceVariableDataInINIFileworkflow, Expression<Func<string>> replaceVariableDataInINIFileoutputFilename = null, Expression<Func<string>> replaceVariableDataInINIFilesearchSection = null, Expression<Func<string>> replaceVariableDataInINIFilesearchVariable = null, Expression<Func<string>> replaceVariableDataInINIFilereplaceData = null, Expression<Func<string>> replaceVariableDataInINIFileinputFilenameEncoding = null, Expression<Func<bool>> replaceVariableDataInINIFilecreateNewFileIfNotExists = null, Expression<Func<bool>> replaceVariableDataInINIFilewriteSpaceBeforeEquals = null, Expression<Func<bool>> replaceVariableDataInINIFilewriteSpaceAfterEquals = null)
        {
            var __workflow_replaceVariableDataInINIFileinputFilename = WorkflowExpression.Compile(replaceVariableDataInINIFileinputFilename, nameof(replaceVariableDataInINIFileinputFilename), required: true);
            var __workflow_replaceVariableDataInINIFileworkflow = WorkflowExpression.Compile(replaceVariableDataInINIFileworkflow, nameof(replaceVariableDataInINIFileworkflow), required: true);
            var __workflow_replaceVariableDataInINIFileoutputFilename = WorkflowExpression.Compile(replaceVariableDataInINIFileoutputFilename, nameof(replaceVariableDataInINIFileoutputFilename), required: false);
            var __workflow_replaceVariableDataInINIFilesearchSection = WorkflowExpression.Compile(replaceVariableDataInINIFilesearchSection, nameof(replaceVariableDataInINIFilesearchSection), required: false);
            var __workflow_replaceVariableDataInINIFilesearchVariable = WorkflowExpression.Compile(replaceVariableDataInINIFilesearchVariable, nameof(replaceVariableDataInINIFilesearchVariable), required: false);
            var __workflow_replaceVariableDataInINIFilereplaceData = WorkflowExpression.Compile(replaceVariableDataInINIFilereplaceData, nameof(replaceVariableDataInINIFilereplaceData), required: false);
            var __workflow_replaceVariableDataInINIFileinputFilenameEncoding = WorkflowExpression.Compile(replaceVariableDataInINIFileinputFilenameEncoding, nameof(replaceVariableDataInINIFileinputFilenameEncoding), required: false);
            var __workflow_replaceVariableDataInINIFilecreateNewFileIfNotExists = WorkflowExpression.Compile(replaceVariableDataInINIFilecreateNewFileIfNotExists, nameof(replaceVariableDataInINIFilecreateNewFileIfNotExists), required: false);
            var __workflow_replaceVariableDataInINIFilewriteSpaceBeforeEquals = WorkflowExpression.Compile(replaceVariableDataInINIFilewriteSpaceBeforeEquals, nameof(replaceVariableDataInINIFilewriteSpaceBeforeEquals), required: false);
            var __workflow_replaceVariableDataInINIFilewriteSpaceAfterEquals = WorkflowExpression.Compile(replaceVariableDataInINIFilewriteSpaceAfterEquals, nameof(replaceVariableDataInINIFilewriteSpaceAfterEquals), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/ReplaceVariableDataInINIFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var replaceVariableDataInINIFile = new JObject();
                var replaceVariableDataInINIFilepropCount = 0;
                replaceVariableDataInINIFilepropCount++;
                replaceVariableDataInINIFile["InputFilename"] = ExpressionConverter.ConvertO(__workflow_replaceVariableDataInINIFileinputFilename);
                if (__workflow_replaceVariableDataInINIFileoutputFilename != null)
                {
                    replaceVariableDataInINIFile["OutputFilename"] = ExpressionConverter.ConvertO(__workflow_replaceVariableDataInINIFileoutputFilename);
                    replaceVariableDataInINIFilepropCount++;
                }

                if (__workflow_replaceVariableDataInINIFilesearchSection != null)
                {
                    replaceVariableDataInINIFile["SearchSection"] = ExpressionConverter.ConvertO(__workflow_replaceVariableDataInINIFilesearchSection);
                    replaceVariableDataInINIFilepropCount++;
                }

                if (__workflow_replaceVariableDataInINIFilesearchVariable != null)
                {
                    replaceVariableDataInINIFile["SearchVariable"] = ExpressionConverter.ConvertO(__workflow_replaceVariableDataInINIFilesearchVariable);
                    replaceVariableDataInINIFilepropCount++;
                }

                if (__workflow_replaceVariableDataInINIFilereplaceData != null)
                {
                    replaceVariableDataInINIFile["ReplaceData"] = ExpressionConverter.ConvertO(__workflow_replaceVariableDataInINIFilereplaceData);
                    replaceVariableDataInINIFilepropCount++;
                }

                if (__workflow_replaceVariableDataInINIFileinputFilenameEncoding != null)
                {
                    replaceVariableDataInINIFile["InputFilenameEncoding"] = ExpressionConverter.ConvertO(__workflow_replaceVariableDataInINIFileinputFilenameEncoding);
                    replaceVariableDataInINIFilepropCount++;
                }

                if (__workflow_replaceVariableDataInINIFilecreateNewFileIfNotExists != null)
                {
                    if (__workflow_replaceVariableDataInINIFilecreateNewFileIfNotExists != null)
                    {
                        replaceVariableDataInINIFile["CreateNewFileIfNotExists"] = ExpressionConverter.ConvertO(__workflow_replaceVariableDataInINIFilecreateNewFileIfNotExists);
                        replaceVariableDataInINIFilepropCount++;
                    }

                    replaceVariableDataInINIFilepropCount++;
                }
                else
                {
                    replaceVariableDataInINIFile["CreateNewFileIfNotExists"] = true;
                    replaceVariableDataInINIFilepropCount++;
                }

                if (__workflow_replaceVariableDataInINIFilewriteSpaceBeforeEquals != null)
                {
                    if (__workflow_replaceVariableDataInINIFilewriteSpaceBeforeEquals != null)
                    {
                        replaceVariableDataInINIFile["WriteSpaceBeforeEquals"] = ExpressionConverter.ConvertO(__workflow_replaceVariableDataInINIFilewriteSpaceBeforeEquals);
                        replaceVariableDataInINIFilepropCount++;
                    }

                    replaceVariableDataInINIFilepropCount++;
                }
                else
                {
                    replaceVariableDataInINIFile["WriteSpaceBeforeEquals"] = true;
                    replaceVariableDataInINIFilepropCount++;
                }

                if (__workflow_replaceVariableDataInINIFilewriteSpaceAfterEquals != null)
                {
                    if (__workflow_replaceVariableDataInINIFilewriteSpaceAfterEquals != null)
                    {
                        replaceVariableDataInINIFile["WriteSpaceAfterEquals"] = ExpressionConverter.ConvertO(__workflow_replaceVariableDataInINIFilewriteSpaceAfterEquals);
                        replaceVariableDataInINIFilepropCount++;
                    }

                    replaceVariableDataInINIFilepropCount++;
                }
                else
                {
                    replaceVariableDataInINIFile["WriteSpaceAfterEquals"] = true;
                    replaceVariableDataInINIFilepropCount++;
                }

                replaceVariableDataInINIFilepropCount++;
                replaceVariableDataInINIFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_replaceVariableDataInINIFileworkflow);
                if (replaceVariableDataInINIFilepropCount > 0)
                {
                    callPayload.Body = replaceVariableDataInINIFile;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DownloadHTTPFileResponse> DownloadHTTPFile(Expression<Func<string>> downloadHTTPFiledownloadURL, Expression<Func<string>> downloadHTTPFileworkflow, Expression<Func<string>> downloadHTTPFilesaveFilename = null, Expression<Func<bool>> downloadHTTPFileoverwriteExistingFile = null, Expression<Func<bool>> downloadHTTPFilepassthroughAuthentication = null, Expression<Func<string>> downloadHTTPFileuserAgent = null, Expression<Func<string>> downloadHTTPFileaccept = null, Expression<Func<bool>> downloadHTTPFilesupportTLS10 = null, Expression<Func<bool>> downloadHTTPFilesupportTLS11 = null, Expression<Func<bool>> downloadHTTPFilesupportTLS12 = null, Expression<Func<bool>> downloadHTTPFileautoDecompressDeflate = null, Expression<Func<bool>> downloadHTTPFileautoDecompressGZIP = null, Expression<Func<bool>> downloadHTTPFilereturnContentsAsString = null, Expression<Func<downloadHTTPFilereturnContentEncodingInput>> downloadHTTPFilereturnContentEncoding = null)
        {
            var __workflow_downloadHTTPFiledownloadURL = WorkflowExpression.Compile(downloadHTTPFiledownloadURL, nameof(downloadHTTPFiledownloadURL), required: true);
            var __workflow_downloadHTTPFileworkflow = WorkflowExpression.Compile(downloadHTTPFileworkflow, nameof(downloadHTTPFileworkflow), required: true);
            var __workflow_downloadHTTPFilesaveFilename = WorkflowExpression.Compile(downloadHTTPFilesaveFilename, nameof(downloadHTTPFilesaveFilename), required: false);
            var __workflow_downloadHTTPFileoverwriteExistingFile = WorkflowExpression.Compile(downloadHTTPFileoverwriteExistingFile, nameof(downloadHTTPFileoverwriteExistingFile), required: false);
            var __workflow_downloadHTTPFilepassthroughAuthentication = WorkflowExpression.Compile(downloadHTTPFilepassthroughAuthentication, nameof(downloadHTTPFilepassthroughAuthentication), required: false);
            var __workflow_downloadHTTPFileuserAgent = WorkflowExpression.Compile(downloadHTTPFileuserAgent, nameof(downloadHTTPFileuserAgent), required: false);
            var __workflow_downloadHTTPFileaccept = WorkflowExpression.Compile(downloadHTTPFileaccept, nameof(downloadHTTPFileaccept), required: false);
            var __workflow_downloadHTTPFilesupportTLS10 = WorkflowExpression.Compile(downloadHTTPFilesupportTLS10, nameof(downloadHTTPFilesupportTLS10), required: false);
            var __workflow_downloadHTTPFilesupportTLS11 = WorkflowExpression.Compile(downloadHTTPFilesupportTLS11, nameof(downloadHTTPFilesupportTLS11), required: false);
            var __workflow_downloadHTTPFilesupportTLS12 = WorkflowExpression.Compile(downloadHTTPFilesupportTLS12, nameof(downloadHTTPFilesupportTLS12), required: false);
            var __workflow_downloadHTTPFileautoDecompressDeflate = WorkflowExpression.Compile(downloadHTTPFileautoDecompressDeflate, nameof(downloadHTTPFileautoDecompressDeflate), required: false);
            var __workflow_downloadHTTPFileautoDecompressGZIP = WorkflowExpression.Compile(downloadHTTPFileautoDecompressGZIP, nameof(downloadHTTPFileautoDecompressGZIP), required: false);
            var __workflow_downloadHTTPFilereturnContentsAsString = WorkflowExpression.Compile(downloadHTTPFilereturnContentsAsString, nameof(downloadHTTPFilereturnContentsAsString), required: false);
            var __workflow_downloadHTTPFilereturnContentEncoding = WorkflowExpression.Compile(downloadHTTPFilereturnContentEncoding, nameof(downloadHTTPFilereturnContentEncoding), required: false);
            return new DeferredBodyAction<DownloadHTTPFileResponse>(() =>
            {
                var apiCallPath = "/FileManagement/DownloadHTTPFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var downloadHTTPFile = new JObject();
                var downloadHTTPFilepropCount = 0;
                downloadHTTPFilepropCount++;
                downloadHTTPFile["DownloadURL"] = ExpressionConverter.ConvertO(__workflow_downloadHTTPFiledownloadURL);
                if (__workflow_downloadHTTPFilesaveFilename != null)
                {
                    downloadHTTPFile["SaveFilename"] = ExpressionConverter.ConvertO(__workflow_downloadHTTPFilesaveFilename);
                    downloadHTTPFilepropCount++;
                }

                if (__workflow_downloadHTTPFileoverwriteExistingFile != null)
                {
                    if (__workflow_downloadHTTPFileoverwriteExistingFile != null)
                    {
                        downloadHTTPFile["OverwriteExistingFile"] = ExpressionConverter.ConvertO(__workflow_downloadHTTPFileoverwriteExistingFile);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["OverwriteExistingFile"] = true;
                    downloadHTTPFilepropCount++;
                }

                if (__workflow_downloadHTTPFilepassthroughAuthentication != null)
                {
                    if (__workflow_downloadHTTPFilepassthroughAuthentication != null)
                    {
                        downloadHTTPFile["PassthroughAuthentication"] = ExpressionConverter.ConvertO(__workflow_downloadHTTPFilepassthroughAuthentication);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["PassthroughAuthentication"] = false;
                    downloadHTTPFilepropCount++;
                }

                if (__workflow_downloadHTTPFileuserAgent != null)
                {
                    if (__workflow_downloadHTTPFileuserAgent != null)
                    {
                        downloadHTTPFile["UserAgent"] = ExpressionConverter.ConvertO(__workflow_downloadHTTPFileuserAgent);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["UserAgent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.193 Safari/537.36";
                    downloadHTTPFilepropCount++;
                }

                if (__workflow_downloadHTTPFileaccept != null)
                {
                    if (__workflow_downloadHTTPFileaccept != null)
                    {
                        downloadHTTPFile["Accept"] = ExpressionConverter.ConvertO(__workflow_downloadHTTPFileaccept);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["Accept"] = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                    downloadHTTPFilepropCount++;
                }

                if (__workflow_downloadHTTPFilesupportTLS10 != null)
                {
                    if (__workflow_downloadHTTPFilesupportTLS10 != null)
                    {
                        downloadHTTPFile["SupportTLS10"] = ExpressionConverter.ConvertO(__workflow_downloadHTTPFilesupportTLS10);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["SupportTLS10"] = true;
                    downloadHTTPFilepropCount++;
                }

                if (__workflow_downloadHTTPFilesupportTLS11 != null)
                {
                    if (__workflow_downloadHTTPFilesupportTLS11 != null)
                    {
                        downloadHTTPFile["SupportTLS11"] = ExpressionConverter.ConvertO(__workflow_downloadHTTPFilesupportTLS11);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["SupportTLS11"] = true;
                    downloadHTTPFilepropCount++;
                }

                if (__workflow_downloadHTTPFilesupportTLS12 != null)
                {
                    if (__workflow_downloadHTTPFilesupportTLS12 != null)
                    {
                        downloadHTTPFile["SupportTLS12"] = ExpressionConverter.ConvertO(__workflow_downloadHTTPFilesupportTLS12);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["SupportTLS12"] = true;
                    downloadHTTPFilepropCount++;
                }

                if (__workflow_downloadHTTPFileautoDecompressDeflate != null)
                {
                    if (__workflow_downloadHTTPFileautoDecompressDeflate != null)
                    {
                        downloadHTTPFile["AutoDecompressDeflate"] = ExpressionConverter.ConvertO(__workflow_downloadHTTPFileautoDecompressDeflate);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["AutoDecompressDeflate"] = true;
                    downloadHTTPFilepropCount++;
                }

                if (__workflow_downloadHTTPFileautoDecompressGZIP != null)
                {
                    if (__workflow_downloadHTTPFileautoDecompressGZIP != null)
                    {
                        downloadHTTPFile["AutoDecompressGZIP"] = ExpressionConverter.ConvertO(__workflow_downloadHTTPFileautoDecompressGZIP);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["AutoDecompressGZIP"] = true;
                    downloadHTTPFilepropCount++;
                }

                if (__workflow_downloadHTTPFilereturnContentsAsString != null)
                {
                    if (__workflow_downloadHTTPFilereturnContentsAsString != null)
                    {
                        downloadHTTPFile["ReturnContentsAsString"] = ExpressionConverter.ConvertO(__workflow_downloadHTTPFilereturnContentsAsString);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["ReturnContentsAsString"] = false;
                    downloadHTTPFilepropCount++;
                }

                if (__workflow_downloadHTTPFilereturnContentEncoding != null)
                {
                    if (__workflow_downloadHTTPFilereturnContentEncoding != null)
                    {
                        downloadHTTPFile["ReturnContentEncoding"] = ExpressionConverter.ConvertO(__workflow_downloadHTTPFilereturnContentEncoding);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["ReturnContentEncoding"] = "UTF8";
                    downloadHTTPFilepropCount++;
                }

                downloadHTTPFilepropCount++;
                downloadHTTPFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_downloadHTTPFileworkflow);
                if (downloadHTTPFilepropCount > 0)
                {
                    callPayload.Body = downloadHTTPFile;
                }

                return new ApiConnectionAction<DownloadHTTPFileResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UnZIPFileResponse> UnZIPFile(Expression<Func<string>> unZIPFilezIPFilename, Expression<Func<string>> unZIPFileworkflow, Expression<Func<string>> unZIPFileextractFolder = null, Expression<Func<bool>> unZIPFileextractAllFilesToSingleFolder = null, Expression<Func<string>> unZIPFileincludeFilesRegEx = null, Expression<Func<string>> unZIPFileexcludeFilesRegEx = null)
        {
            var __workflow_unZIPFilezIPFilename = WorkflowExpression.Compile(unZIPFilezIPFilename, nameof(unZIPFilezIPFilename), required: true);
            var __workflow_unZIPFileworkflow = WorkflowExpression.Compile(unZIPFileworkflow, nameof(unZIPFileworkflow), required: true);
            var __workflow_unZIPFileextractFolder = WorkflowExpression.Compile(unZIPFileextractFolder, nameof(unZIPFileextractFolder), required: false);
            var __workflow_unZIPFileextractAllFilesToSingleFolder = WorkflowExpression.Compile(unZIPFileextractAllFilesToSingleFolder, nameof(unZIPFileextractAllFilesToSingleFolder), required: false);
            var __workflow_unZIPFileincludeFilesRegEx = WorkflowExpression.Compile(unZIPFileincludeFilesRegEx, nameof(unZIPFileincludeFilesRegEx), required: false);
            var __workflow_unZIPFileexcludeFilesRegEx = WorkflowExpression.Compile(unZIPFileexcludeFilesRegEx, nameof(unZIPFileexcludeFilesRegEx), required: false);
            return new DeferredBodyAction<UnZIPFileResponse>(() =>
            {
                var apiCallPath = "/FileManagement/UnZIPFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var unZIPFile = new JObject();
                var unZIPFilepropCount = 0;
                unZIPFilepropCount++;
                unZIPFile["ZIPFilename"] = ExpressionConverter.ConvertO(__workflow_unZIPFilezIPFilename);
                if (__workflow_unZIPFileextractFolder != null)
                {
                    unZIPFile["ExtractFolder"] = ExpressionConverter.ConvertO(__workflow_unZIPFileextractFolder);
                    unZIPFilepropCount++;
                }

                if (__workflow_unZIPFileextractAllFilesToSingleFolder != null)
                {
                    if (__workflow_unZIPFileextractAllFilesToSingleFolder != null)
                    {
                        unZIPFile["ExtractAllFilesToSingleFolder"] = ExpressionConverter.ConvertO(__workflow_unZIPFileextractAllFilesToSingleFolder);
                        unZIPFilepropCount++;
                    }

                    unZIPFilepropCount++;
                }
                else
                {
                    unZIPFile["ExtractAllFilesToSingleFolder"] = false;
                    unZIPFilepropCount++;
                }

                if (__workflow_unZIPFileincludeFilesRegEx != null)
                {
                    unZIPFile["IncludeFilesRegEx"] = ExpressionConverter.ConvertO(__workflow_unZIPFileincludeFilesRegEx);
                    unZIPFilepropCount++;
                }

                if (__workflow_unZIPFileexcludeFilesRegEx != null)
                {
                    unZIPFile["ExcludeFilesRegEx"] = ExpressionConverter.ConvertO(__workflow_unZIPFileexcludeFilesRegEx);
                    unZIPFilepropCount++;
                }

                unZIPFilepropCount++;
                unZIPFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_unZIPFileworkflow);
                if (unZIPFilepropCount > 0)
                {
                    callPayload.Body = unZIPFile;
                }

                return new ApiConnectionAction<UnZIPFileResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddFileToZIP(Expression<Func<string>> addFileToZIPsourceFilenameToAddToZIP, Expression<Func<string>> addFileToZIPoutputZIPFilename, Expression<Func<string>> addFileToZIPworkflow, Expression<Func<string>> addFileToZIPaddFilenameToFolderInZIP = null, Expression<Func<string>> addFileToZIPsourceFilenameToAddToZIPComment = null, Expression<Func<bool>> addFileToZIPcompress = null, Expression<Func<bool>> addFileToZIPaddToExistingZIPFile = null)
        {
            var __workflow_addFileToZIPsourceFilenameToAddToZIP = WorkflowExpression.Compile(addFileToZIPsourceFilenameToAddToZIP, nameof(addFileToZIPsourceFilenameToAddToZIP), required: true);
            var __workflow_addFileToZIPoutputZIPFilename = WorkflowExpression.Compile(addFileToZIPoutputZIPFilename, nameof(addFileToZIPoutputZIPFilename), required: true);
            var __workflow_addFileToZIPworkflow = WorkflowExpression.Compile(addFileToZIPworkflow, nameof(addFileToZIPworkflow), required: true);
            var __workflow_addFileToZIPaddFilenameToFolderInZIP = WorkflowExpression.Compile(addFileToZIPaddFilenameToFolderInZIP, nameof(addFileToZIPaddFilenameToFolderInZIP), required: false);
            var __workflow_addFileToZIPsourceFilenameToAddToZIPComment = WorkflowExpression.Compile(addFileToZIPsourceFilenameToAddToZIPComment, nameof(addFileToZIPsourceFilenameToAddToZIPComment), required: false);
            var __workflow_addFileToZIPcompress = WorkflowExpression.Compile(addFileToZIPcompress, nameof(addFileToZIPcompress), required: false);
            var __workflow_addFileToZIPaddToExistingZIPFile = WorkflowExpression.Compile(addFileToZIPaddToExistingZIPFile, nameof(addFileToZIPaddToExistingZIPFile), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/AddFileToZIP";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addFileToZIP = new JObject();
                var addFileToZIPpropCount = 0;
                addFileToZIPpropCount++;
                addFileToZIP["SourceFilenameToAddToZIP"] = ExpressionConverter.ConvertO(__workflow_addFileToZIPsourceFilenameToAddToZIP);
                addFileToZIPpropCount++;
                addFileToZIP["OutputZIPFilename"] = ExpressionConverter.ConvertO(__workflow_addFileToZIPoutputZIPFilename);
                if (__workflow_addFileToZIPaddFilenameToFolderInZIP != null)
                {
                    addFileToZIP["AddFilenameToFolderInZIP"] = ExpressionConverter.ConvertO(__workflow_addFileToZIPaddFilenameToFolderInZIP);
                    addFileToZIPpropCount++;
                }

                if (__workflow_addFileToZIPsourceFilenameToAddToZIPComment != null)
                {
                    addFileToZIP["SourceFilenameToAddToZIPComment"] = ExpressionConverter.ConvertO(__workflow_addFileToZIPsourceFilenameToAddToZIPComment);
                    addFileToZIPpropCount++;
                }

                if (__workflow_addFileToZIPcompress != null)
                {
                    if (__workflow_addFileToZIPcompress != null)
                    {
                        addFileToZIP["Compress"] = ExpressionConverter.ConvertO(__workflow_addFileToZIPcompress);
                        addFileToZIPpropCount++;
                    }

                    addFileToZIPpropCount++;
                }
                else
                {
                    addFileToZIP["Compress"] = true;
                    addFileToZIPpropCount++;
                }

                if (__workflow_addFileToZIPaddToExistingZIPFile != null)
                {
                    if (__workflow_addFileToZIPaddToExistingZIPFile != null)
                    {
                        addFileToZIP["AddToExistingZIPFile"] = ExpressionConverter.ConvertO(__workflow_addFileToZIPaddToExistingZIPFile);
                        addFileToZIPpropCount++;
                    }

                    addFileToZIPpropCount++;
                }
                else
                {
                    addFileToZIP["AddToExistingZIPFile"] = false;
                    addFileToZIPpropCount++;
                }

                addFileToZIPpropCount++;
                addFileToZIP["Workflow"] = ExpressionConverter.ConvertO(__workflow_addFileToZIPworkflow);
                if (addFileToZIPpropCount > 0)
                {
                    callPayload.Body = addFileToZIP;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AddFolderToZIPResponse> AddFolderToZIP(Expression<Func<string>> addFolderToZIPsourceFolderToAddToZIP, Expression<Func<string>> addFolderToZIPoutputZIPFilename, Expression<Func<string>> addFolderToZIPworkflow, Expression<Func<string>> addFolderToZIPaddFilesToFolderInZIP = null, Expression<Func<bool>> addFolderToZIPcompress = null, Expression<Func<bool>> addFolderToZIPaddToExistingZIPFile = null, Expression<Func<bool>> addFolderToZIPincludeSubfolders = null, Expression<Func<string>> addFolderToZIPincludeFilesRegEx = null, Expression<Func<string>> addFolderToZIPexcludeFilesRegEx = null)
        {
            var __workflow_addFolderToZIPsourceFolderToAddToZIP = WorkflowExpression.Compile(addFolderToZIPsourceFolderToAddToZIP, nameof(addFolderToZIPsourceFolderToAddToZIP), required: true);
            var __workflow_addFolderToZIPoutputZIPFilename = WorkflowExpression.Compile(addFolderToZIPoutputZIPFilename, nameof(addFolderToZIPoutputZIPFilename), required: true);
            var __workflow_addFolderToZIPworkflow = WorkflowExpression.Compile(addFolderToZIPworkflow, nameof(addFolderToZIPworkflow), required: true);
            var __workflow_addFolderToZIPaddFilesToFolderInZIP = WorkflowExpression.Compile(addFolderToZIPaddFilesToFolderInZIP, nameof(addFolderToZIPaddFilesToFolderInZIP), required: false);
            var __workflow_addFolderToZIPcompress = WorkflowExpression.Compile(addFolderToZIPcompress, nameof(addFolderToZIPcompress), required: false);
            var __workflow_addFolderToZIPaddToExistingZIPFile = WorkflowExpression.Compile(addFolderToZIPaddToExistingZIPFile, nameof(addFolderToZIPaddToExistingZIPFile), required: false);
            var __workflow_addFolderToZIPincludeSubfolders = WorkflowExpression.Compile(addFolderToZIPincludeSubfolders, nameof(addFolderToZIPincludeSubfolders), required: false);
            var __workflow_addFolderToZIPincludeFilesRegEx = WorkflowExpression.Compile(addFolderToZIPincludeFilesRegEx, nameof(addFolderToZIPincludeFilesRegEx), required: false);
            var __workflow_addFolderToZIPexcludeFilesRegEx = WorkflowExpression.Compile(addFolderToZIPexcludeFilesRegEx, nameof(addFolderToZIPexcludeFilesRegEx), required: false);
            return new DeferredBodyAction<AddFolderToZIPResponse>(() =>
            {
                var apiCallPath = "/FileManagement/AddFolderToZIP";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addFolderToZIP = new JObject();
                var addFolderToZIPpropCount = 0;
                addFolderToZIPpropCount++;
                addFolderToZIP["SourceFolderToAddToZIP"] = ExpressionConverter.ConvertO(__workflow_addFolderToZIPsourceFolderToAddToZIP);
                addFolderToZIPpropCount++;
                addFolderToZIP["OutputZIPFilename"] = ExpressionConverter.ConvertO(__workflow_addFolderToZIPoutputZIPFilename);
                if (__workflow_addFolderToZIPaddFilesToFolderInZIP != null)
                {
                    addFolderToZIP["AddFilesToFolderInZIP"] = ExpressionConverter.ConvertO(__workflow_addFolderToZIPaddFilesToFolderInZIP);
                    addFolderToZIPpropCount++;
                }

                if (__workflow_addFolderToZIPcompress != null)
                {
                    if (__workflow_addFolderToZIPcompress != null)
                    {
                        addFolderToZIP["Compress"] = ExpressionConverter.ConvertO(__workflow_addFolderToZIPcompress);
                        addFolderToZIPpropCount++;
                    }

                    addFolderToZIPpropCount++;
                }
                else
                {
                    addFolderToZIP["Compress"] = true;
                    addFolderToZIPpropCount++;
                }

                if (__workflow_addFolderToZIPaddToExistingZIPFile != null)
                {
                    if (__workflow_addFolderToZIPaddToExistingZIPFile != null)
                    {
                        addFolderToZIP["AddToExistingZIPFile"] = ExpressionConverter.ConvertO(__workflow_addFolderToZIPaddToExistingZIPFile);
                        addFolderToZIPpropCount++;
                    }

                    addFolderToZIPpropCount++;
                }
                else
                {
                    addFolderToZIP["AddToExistingZIPFile"] = false;
                    addFolderToZIPpropCount++;
                }

                if (__workflow_addFolderToZIPincludeSubfolders != null)
                {
                    if (__workflow_addFolderToZIPincludeSubfolders != null)
                    {
                        addFolderToZIP["IncludeSubfolders"] = ExpressionConverter.ConvertO(__workflow_addFolderToZIPincludeSubfolders);
                        addFolderToZIPpropCount++;
                    }

                    addFolderToZIPpropCount++;
                }
                else
                {
                    addFolderToZIP["IncludeSubfolders"] = true;
                    addFolderToZIPpropCount++;
                }

                if (__workflow_addFolderToZIPincludeFilesRegEx != null)
                {
                    addFolderToZIP["IncludeFilesRegEx"] = ExpressionConverter.ConvertO(__workflow_addFolderToZIPincludeFilesRegEx);
                    addFolderToZIPpropCount++;
                }

                if (__workflow_addFolderToZIPexcludeFilesRegEx != null)
                {
                    addFolderToZIP["ExcludeFilesRegEx"] = ExpressionConverter.ConvertO(__workflow_addFolderToZIPexcludeFilesRegEx);
                    addFolderToZIPpropCount++;
                }

                addFolderToZIPpropCount++;
                addFolderToZIP["Workflow"] = ExpressionConverter.ConvertO(__workflow_addFolderToZIPworkflow);
                if (addFolderToZIPpropCount > 0)
                {
                    callPayload.Body = addFolderToZIP;
                }

                return new ApiConnectionAction<AddFolderToZIPResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileContentsAsBase64Response> GetFileContentsAsBase64(Expression<Func<string>> getFileContentsAsBase64filePath, Expression<Func<string>> getFileContentsAsBase64workflow, Expression<Func<bool>> getFileContentsAsBase64compress = null, Expression<Func<int>> getFileContentsAsBase64maxFileSize = null)
        {
            var __workflow_getFileContentsAsBase64filePath = WorkflowExpression.Compile(getFileContentsAsBase64filePath, nameof(getFileContentsAsBase64filePath), required: true);
            var __workflow_getFileContentsAsBase64workflow = WorkflowExpression.Compile(getFileContentsAsBase64workflow, nameof(getFileContentsAsBase64workflow), required: true);
            var __workflow_getFileContentsAsBase64compress = WorkflowExpression.Compile(getFileContentsAsBase64compress, nameof(getFileContentsAsBase64compress), required: false);
            var __workflow_getFileContentsAsBase64maxFileSize = WorkflowExpression.Compile(getFileContentsAsBase64maxFileSize, nameof(getFileContentsAsBase64maxFileSize), required: false);
            return new DeferredBodyAction<GetFileContentsAsBase64Response>(() =>
            {
                var apiCallPath = "/FileManagement/GetFileContentsAsBase64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getFileContentsAsBase64 = new JObject();
                var getFileContentsAsBase64propCount = 0;
                getFileContentsAsBase64propCount++;
                getFileContentsAsBase64["FilePath"] = ExpressionConverter.ConvertO(__workflow_getFileContentsAsBase64filePath);
                if (__workflow_getFileContentsAsBase64compress != null)
                {
                    if (__workflow_getFileContentsAsBase64compress != null)
                    {
                        getFileContentsAsBase64["Compress"] = ExpressionConverter.ConvertO(__workflow_getFileContentsAsBase64compress);
                        getFileContentsAsBase64propCount++;
                    }

                    getFileContentsAsBase64propCount++;
                }
                else
                {
                    getFileContentsAsBase64["Compress"] = false;
                    getFileContentsAsBase64propCount++;
                }

                if (__workflow_getFileContentsAsBase64maxFileSize != null)
                {
                    if (__workflow_getFileContentsAsBase64maxFileSize != null)
                    {
                        getFileContentsAsBase64["MaxFileSize"] = ExpressionConverter.ConvertO(__workflow_getFileContentsAsBase64maxFileSize);
                        getFileContentsAsBase64propCount++;
                    }

                    getFileContentsAsBase64propCount++;
                }
                else
                {
                    getFileContentsAsBase64["MaxFileSize"] = 1024000;
                    getFileContentsAsBase64propCount++;
                }

                getFileContentsAsBase64propCount++;
                getFileContentsAsBase64["Workflow"] = ExpressionConverter.ConvertO(__workflow_getFileContentsAsBase64workflow);
                if (getFileContentsAsBase64propCount > 0)
                {
                    callPayload.Body = getFileContentsAsBase64;
                }

                return new ApiConnectionAction<GetFileContentsAsBase64Response>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class IaconnectsessionTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetMachineNameResponse
    {
        public string MachineName { get; set; }
    }

    public class GetMachineDomainResponse
    {
        public string DomainName { get; set; }
        public string DNSDomainName { get; set; }
    }

    public class GetRemoteSessionClientHostnameResponse
    {
        public string ClientHostname { get; set; }
    }

    public class ExpandEnvironmentVariableResponse
    {
        public string OutputString { get; set; }
    }

    public class KillProcessResponse
    {
        public int NumberOfProcessesKilled { get; set; }
    }

    public class KillProcessIDResponse
    {
        public int NumberOfProcessesKilled { get; set; }
    }

    public class GetProcessCountByNameResponse
    {
        public int NumberOfProcesses { get; set; }
    }

    public class GetAgentProcessCountResponse
    {
        public int NumberOfProcesses { get; set; }
    }

    public class KillAllOtherAgentsResponse
    {
        public int NumberOfAgentsKilled { get; set; }
        public int NumberOfAgentsFailedToKill { get; set; }
    }

    public class GetProcessByPIDResponse
    {
        public bool ProcessRunning { get; set; }
    }

    public class GetProcessesResponse
    {
        public int NumberOfProcesses { get; set; }
        public string ProcessesJSON { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum runProcesswindowStyleInput
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
    public enum runProcessstandardOutputEncodingInput
    {
        UTF8,
        UTF7,
        UTF16,
        ASCII,
        UTF16BE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum runProcessstandardErrorEncodingInput
    {
        UTF8,
        UTF7,
        UTF16,
        ASCII,
        UTF16BE
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum runPowerShellProcesswindowStyleInput
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
    public enum runPowerShellProcessstandardOutputEncodingInput
    {
        UTF8,
        UTF7,
        UTF16,
        ASCII,
        UTF16BE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum runPowerShellProcessstandardErrorEncodingInput
    {
        UTF8,
        UTF7,
        UTF16,
        ASCII,
        UTF16BE
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

    public class GetDefaultPrinterResponse
    {
        public string DefaultPrinterName { get; set; }
    }

    public class GetListOfPrintersResponse
    {
        public string PrintersJSON { get; set; }
        public int NumberOfPrinters { get; set; }
    }

    public class GetMouseMultiplierResponse
    {
        public double MouseXMultiplier { get; set; }
        public double MouseYMultiplier { get; set; }
        public string MouseMoveMethod { get; set; }
    }

    public class GetCursorPosResponse
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class CalibrateMouseEventResponse
    {
        public double MouseXMultiplier { get; set; }
        public double MouseYMultiplier { get; set; }
    }

    public class GetMouseMoveMethodResponse
    {
        public string MouseMoveMethod { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum setMouseMoveMethodmouseMoveMethodInput
    {
        [EnumMember(Value = "mouse_event")]
        MouseEvent,
        [EnumMember(Value = "setcursorpos")]
        Setcursorpos
    }

    public class GetClipboardDataResponse
    {
        public string ClipboardData { get; set; }
    }

    public class TakeScreenshotResponse
    {
        public string ScreenBitmapBase64 { get; set; }
        public bool ScreenshotSuccessful { get; set; }
        public string ScreenshotErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum takeScreenshotimageFormatInput
    {
        PNG,
        JPG,
        BMP,
        GIF
    }

    public class GetEnvironmentInfoResponse
    {
        public int OSVersionMajor { get; set; }
        public int OSVersionMinor { get; set; }
        public int OSVersionBuild { get; set; }
        public bool OSIs64Bit { get; set; }
        public int ProcessorCount { get; set; }
        public int TotalPhysicalRAMInMB { get; set; }
        public int TotalVirtualRAMInMB { get; set; }
        public int AvailablePhysicalRAMInMB { get; set; }
        public int AvailableVirtualRAMInMB { get; set; }
        public string OSFullName { get; set; }
        public string InstalledUICultureName { get; set; }
        public string CurrentUICultureName { get; set; }
        public string CurrentCultureName { get; set; }
    }

    public class IsScreenReaderEnabledResponse
    {
        public bool ScreenReaderEnabled { get; set; }
    }

    public class GetParentProcessIdResponse
    {
        public int ParentProcessId { get; set; }
        public bool ParentProcessStillRunning { get; set; }
        public string ParentProcessName { get; set; }
    }

    public class GetProcessIdCommandLineResponse
    {
        public string ProcessCommandLine { get; set; }
        public string ProcessArguments { get; set; }
        public string ProcessCurrentWorkingDirectory { get; set; }
        public string ProcessImagePathName { get; set; }
    }

    public class GetLastInputInfoResponse
    {
        public int LastInputTotalSeconds { get; set; }
        public int LastInputTotalMinutes { get; set; }
        public int LastInputTotalHours { get; set; }
    }

    public class KeepSessionAliveResponse
    {
        public bool KeepSessionAliveResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class StopKeepSessionAliveResponse
    {
        public bool StopKeepSessionAliveResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class CopyFileToClipboardResponse
    {
        public bool CopyFileToClipboardResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class GetRemoteSessionInfoResponse
    {
        public int SessionId { get; set; }
        public int SessionType { get; set; }
        public string SessionTypeName { get; set; }
    }

    public class GeneratePasswordResponse
    {
        public string PlainTextPassword { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum generatePasswordgenerateAtInput
    {
        Agent,
        Orchestrator
    }

    public class GetStoredPasswordResponse
    {
        public string PlainTextPassword { get; set; }
    }

    public class ExpandPasswordStringResponse
    {
        public string OutputString { get; set; }
    }

    public class StorePasswordInAgentMemoryResponse
    {
        public bool StorePasswordInAgentMemoryResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class DeletePasswordInAgentMemoryResponse
    {
        public bool DeletePasswordInAgentMemoryResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class CredentialWriteResponse
    {
        public bool CredentialWriteResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum credentialWritecredentialTypeInput
    {
        Windows,
        Generic
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum credentialWritecredentialPersistenceInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum credentialReadcredentialTypeInput
    {
        Windows,
        Generic
    }

    public class CredentialDeleteResponse
    {
        public bool CredentialDeleteResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum credentialDeletecredentialTypeInput
    {
        Windows,
        Generic
    }

    public class GenerateRDPFileResponse
    {
        public string RDPFilePath { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum generateRDPFilecredentialTypeInput
    {
        Windows,
        Generic
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum generateRDPFilecredentialPersistenceInput
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

    public class IsTCPPortRespondingResponse
    {
        public bool TCPPortConnected { get; set; }
        public string ConnectionErrorMessage { get; set; }
    }

    public class UnlockSessionResponse
    {
        public bool SessionUnlockPerformed { get; set; }
    }

    public class LockSessionResponse
    {
        public bool LockSessionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class IsSessionLockedResponse
    {
        public bool SessionIsLocked { get; set; }
    }

    public class GetGenericCredentialFromOrchestratorResponse
    {
        public string Username { get; set; }
        public string PlainTextPassword { get; set; }
        public string Hostname { get; set; }
        public string Url { get; set; }
        public string GenericProperty1 { get; set; }
        public string GenericProperty2 { get; set; }
        public string GenericProperty3 { get; set; }
    }

    public class DrawRectangleOnScreenResponse
    {
        public bool DrawRectangleOnScreenResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class GetFailedActionErrorMessageFromPowerAutomateResultJSONResponse
    {
        public string ActionErrorMessage { get; set; }
        public string ActionName { get; set; }
        public string ActionCode { get; set; }
    }

    public class GetPixelColourAtCoordinateResponse
    {
        public int RedValue { get; set; }
        public int GreenValue { get; set; }
        public int BlueValue { get; set; }
        public int AlphaValue { get; set; }
        public string RRGGBBHexValue { get; set; }
        public string AARRGGBBHexValue { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum convertRectangleCoordinatesconversionTypeInput
    {
        [EnumMember(Value = "P2V")]
        PhysicalToVirtual,
        [EnumMember(Value = "V2P")]
        VirtualToPhysical
    }

    public class SendMessageToWebAPIResponse
    {
        public int ResponseStatusCode { get; set; }
        public string ResponseMessage { get; set; }
        public string ResponseContentType { get; set; }
        public string ResponseHeadersJSON { get; set; }
        public int ThreadId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sendMessageToWebAPImethodInput
    {
        GET,
        PUT,
        POST,
        PATCH,
        DELETE,
        HEAD,
        OPTIONS,
        TRACE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sendMessageToWebAPItransmitEncodingInput
    {
        [EnumMember(Value = "UTF-8")]
        UTF8,
        [EnumMember(Value = "UTF-7")]
        UTF7,
        [EnumMember(Value = "UTF-16")]
        UTF16,
        ASCII,
        [EnumMember(Value = "UTF-16BE")]
        UTF16BE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sendMessageToWebAPIresponseEncodingInput
    {
        [EnumMember(Value = "UTF-8")]
        UTF8,
        [EnumMember(Value = "UTF-7")]
        UTF7,
        [EnumMember(Value = "UTF-16")]
        UTF16,
        ASCII,
        [EnumMember(Value = "UTF-16BE")]
        UTF16BE
    }

    public class sendMessageToWebAPIhTTPRequestHeadersListInputItem
    {
        public string Property { get; set; }
        public string Value { get; set; }
    }

    public class TasksAddNewTaskResponse
    {
        public int TaskId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum tasksAddNewTasksetAutomationNameInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum tasksAddNewDeferralsetAutomationNameInput
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

    public class TasksDeferExistingTaskOperationResponse
    {
        public bool TasksDeferExistingTaskOperationResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class TasksDeleteTaskResponse
    {
        public bool TasksDeleteTaskResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class TasksDeleteTaskOperationResponse
    {
        public bool TasksDeleteTaskOperationResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class TasksGetAllTasksResponse
    {
        public JToken[] AutomationTasks { get; set; }
        public int NumberOfAutomationTasks { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum tasksGetAllTasksautomationTaskStatusInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum tasksGetTaskstatusChangeInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum tasksGetNextTaskstatusChangeInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum tasksChangeTaskStatusautomationTaskStatusInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum tasksAddNotenoteTypeInput
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

    public class TasksSetOutputDataResponse
    {
        public bool TasksSetOutputDataResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class TasksAddNewTaskOperationResponse
    {
        public string OperationId { get; set; }
    }

    public class TasksAddNewDeferralOperationResponse
    {
        public string OperationId { get; set; }
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

    public class GetRemoteLoggingLevelResponse
    {
        public int LoggingLevel { get; set; }
        public string IAConnectAgentLogFilename { get; set; }
    }

    public class SetLicenseStringResponse
    {
        public int DaysUntilLicenseExpires { get; set; }
    }

    public class GetLicenseStateResponse
    {
        public bool IsLicensed { get; set; }
        public string LicenseType { get; set; }
        public string CustomerNETBIOSDomainName { get; set; }
        public string DirectorHostnameCSV { get; set; }
        public string CustomerDisplayName { get; set; }
        public string VendorName { get; set; }
        public string LicenseExpiryDate { get; set; }
        public int DaysUntilLicenseExpires { get; set; }
        public string LicenseFeatures { get; set; }
        public bool IsJMLLicense { get; set; }
    }

    public class RunAlternativeIAConnectSentFromDirectorResponse
    {
        public bool AlternativeFileCopied { get; set; }
    }

    public class GetIAConnectAgentInfoResponse
    {
        public string IAConnectAgentVersion { get; set; }
        public string DotNetCLRVersion { get; set; }
        public string IAConnectAgentRunAsUsername { get; set; }
        public string IAConnectAgentRunAsUserdomain { get; set; }
        public string IAConnectAgentPath { get; set; }
        public bool IAConnectAgentIs64bitProcess { get; set; }
        public string IAConnectAgentReleaseVersion { get; set; }
        public int IAConnectAgentRPACommandTimeout { get; set; }
        public string IAConnectAgentLogFilename { get; set; }
    }

    public class GetIAConnectAgentLogResponse
    {
        public string IAConnectAgentLogContentsBase64 { get; set; }
        public string IAConnectAgentLogFilenameOnly { get; set; }
    }

    public class GetAllCommandStatsResponse
    {
        public string CommandStatsJSON { get; set; }
    }

    public class EnableNextHopResponse
    {
        public string ActiveNextHopDirectorAddress { get; set; }
        public int ActiveNextHopDirectorTCPPort { get; set; }
        public bool ActiveNextHopDirectorUsesHTTPS { get; set; }
        public string ActiveNextHopDirectorURL { get; set; }
    }

    public class GetNextHopStatusResponse
    {
        public bool NextHopEnabled { get; set; }
        public string ActiveNextHopDirectorAddress { get; set; }
        public int ActiveNextHopDirectorTCPPort { get; set; }
        public bool ActiveNextHopDirectorUsesHTTPS { get; set; }
        public bool ActiveNextHopDirectorIsRunning { get; set; }
        public string ActiveNextHopDirectorURL { get; set; }
        public bool ActiveNextHopAgentIsRunning { get; set; }
    }

    public class WaitForNextHopSessionToConnectResponse
    {
        public bool NextHopSessionConnected { get; set; }
    }

    public class RaiseExceptionResponse
    {
        public bool RaiseExceptionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UpdateOrchestratorFlowStatsResultResponse
    {
        public bool UpdateOrchestratorFlowStatsResultResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class GetLastFailedActionFromOrchestratorFlowStatsResponse
    {
        public bool WorkerAllocatedToFlowRun { get; set; }
        public bool LastActionFailed { get; set; }
        public string LastFailedActionRequestPath { get; set; }
        public string LastFailedActionErrorMessage { get; set; }
    }

    public class GetOrchestratorFlowStatsResponse
    {
        public string OrchestratorFlowStatsJSON { get; set; }
        public int NumberOfOrchestratorFlowStats { get; set; }
    }

    public class GetOrchestratorWorkerAvailabilityStatsResponse
    {
        public string WorkerAvailabilityStatsJSON { get; set; }
        public int NumberOfWorkerAvailabilityStats { get; set; }
    }

    public class GetOrchestratorWorkerFlowUsageHeatmapResponse
    {
        public string WorkerFlowUsageHeatmapJSON { get; set; }
        public int NumberOfWorkerFlowUsageHeatmapItems { get; set; }
    }

    public class GetOrchestratorLoginHistoryResponse
    {
        public string OrchestratorLoginHistoryJSON { get; set; }
        public int NumberOfOrchestratorLogins { get; set; }
    }

    public class RunCommandResponse
    {
        public string OutputJSON { get; set; }
    }

    public class GetLocalLoggingLevelResponse
    {
        public int LoggingLevel { get; set; }
        public string IAConnectDirectorLogFilename { get; set; }
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
        public string DirectorNetBIOSDomainName { get; set; }
        public string DirectorDNSDomainName { get; set; }
        public bool AttachedToNextHopDirector { get; set; }
        public string NextHopDirectorSessionType { get; set; }
    }

    public class GetIAConnectDirectorInfoResponse
    {
        public string IAConnectDirectorVersion { get; set; }
        public string DotNetCLRVersion { get; set; }
        public string IAConnectDirectorRunAsUsername { get; set; }
        public string IAConnectDirectorRunAsUserdomain { get; set; }
        public string IAConnectDirectorPath { get; set; }
        public bool IAConnectDirectorIs64bitProcess { get; set; }
        public string IAConnectDirectorReleaseVersion { get; set; }
        public string IAConnectDirectorLogFilename { get; set; }
    }

    public class GetAvailableIAConnectSessionsResponse
    {
        public string IAConnectSessionsJSON { get; set; }
        public int NumberOfIAConnectSessions { get; set; }
        public int NumberOfLocalIAConnectSessions { get; set; }
        public int NumberOfCitrixICAIAConnectSessions { get; set; }
        public int NumberOfMicrosoftRDPIAConnectSessions { get; set; }
    }

    public class AttachToTier1IAConnectSessionResponse
    {
        public string AttachedTier1IAConnectSessionName { get; set; }
    }

    public class AttachToIAConnectSessionByIndexResponse
    {
        public string AttachedIAConnectSessionName { get; set; }
        public bool AttachedToSession { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum attachToIAConnectSessionByIndexsearchIAConnectSessionTypeInput
    {
        [EnumMember(Value = "Local Agent")]
        LocalAgent,
        [EnumMember(Value = "Microsoft RDP")]
        MicrosoftRDP,
        [EnumMember(Value = "Citrix ICA")]
        CitrixICA,
        Remote
    }

    public class AttachToMostRecentIAConnectSessionResponse
    {
        public string AttachedIAConnectSessionName { get; set; }
        public bool AttachedToSession { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum attachToMostRecentIAConnectSessionsearchIAConnectSessionTypeInput
    {
        [EnumMember(Value = "Local Agent")]
        LocalAgent,
        [EnumMember(Value = "Microsoft RDP")]
        MicrosoftRDP,
        [EnumMember(Value = "Citrix ICA")]
        CitrixICA,
        Remote
    }

    public class GetDirectorUpTimeResponse
    {
        public int UpTimeInSeconds { get; set; }
    }

    public class DoesIAConnectSessionExistByNameResponse
    {
        public bool IAConnectSessionExists { get; set; }
    }

    public class WaitForIAConnectSessionToCloseByNameResponse
    {
        public bool IAConnectSessionClosed { get; set; }
        public string AttachedTier1IAConnectSessionName { get; set; }
    }

    public class KillIAConnectSessionByNameResponse
    {
        public bool IAConnectSessionKilled { get; set; }
        public string AttachedTier1IAConnectSessionName { get; set; }
    }

    public class SetAgentGlobalCoordinateConfigurationResponse
    {
        public bool SetAgentGlobalCoordinateConfigurationResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum setAgentGlobalCoordinateConfigurationmultiMonitorFunctionalityInput
    {
        NotSet,
        [EnumMember(Value = "PrimaryMonitor")]
        PrimaryDisplayOnly,
        [EnumMember(Value = "MultiMonitor")]
        AllDisplays
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplierInput
    {
        [EnumMember(Value = "Auto")]
        Automatic,
        Manual,
        NotSet
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplierInput
    {
        [EnumMember(Value = "Auto")]
        Automatic,
        Manual,
        NotSet
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum setAgentGlobalCoordinateConfigurationjavaCoordinateSystemInput
    {
        NotSet,
        Virtual,
        Physical
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystemInput
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
        public string SAPGUICoordinateSystem { get; set; }
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
        public string ThreadOutputJSON { get; set; }
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
        public string ThreadOutputJSON { get; set; }
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
        public string ThreadStartDateTimeUTC { get; set; }
        public string ThreadCompletedDateTimeUTC { get; set; }
        public int ThreadRuntimeInSeconds { get; set; }
        public bool ThreadStarted { get; set; }
        public bool ThreadRunning { get; set; }
        public bool ThreadCompleted { get; set; }
        public bool ThreadSuccess { get; set; }
        public string ThreadStatusMessage { get; set; }
        public string ThreadErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum getAgentThreadssortOrderInput
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

    public class DeleteAgentThreadResponse
    {
        public int NumberOfAgentThreadsDeleted { get; set; }
    }

    public class AllocateWorkerFromOrchestratorResponse
    {
        public string WorkerNameAllocated { get; set; }
    }

    public class SetOrchestratorWorkerMaintenanceModeResponse
    {
        public bool SetOrchestratorWorkerMaintenanceModeResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class CreateOrchestratorOneTimeSecretResponse
    {
        public string RetrievalURL { get; set; }
        public string RetrievalId { get; set; }
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
        public string AzureWCFRelayName { get; set; }
        public string IAConnectAgentConnectionTypeName { get; set; }
        public bool AttachedToNextHopDirector { get; set; }
        public string NextHopDirectorSessionType { get; set; }
        public string DirectorVersion { get; set; }
        public string AgentVersion { get; set; }
        public double DirectorReleaseVersion { get; set; }
        public double AgentReleaseVersion { get; set; }
        public string DirectorHostname { get; set; }
        public string DirectorNetBIOSDomainName { get; set; }
        public string DirectorDNSDomainName { get; set; }
        public int SupportedFlowEnvironmentIdsCount { get; set; }
        public int SupportedFlowNamesCount { get; set; }
        public int UnsupportedFlowNamesCount { get; set; }
        public int WorkerTagsCount { get; set; }
        public int WorkerMandatoryTagsCount { get; set; }
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

    public class DirectoryExistsResponse
    {
        public bool DirectoryExists { get; set; }
    }

    public class GetFileSizeResponse
    {
        public int FileSize { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum writeTextFileencodingInput
    {
        Unicode,
        UTF8,
        UTF7,
        ASCII
    }

    public class ReadAllTextFromFileResponse
    {
        public string FileTextContents { get; set; }
    }

    public class GetFilesResponse
    {
        public string FilesJSON { get; set; }
        public int NumberOfFilesReadSuccessfully { get; set; }
        public int NumberOfFilesFailedToRead { get; set; }
    }

    public class GetFoldersResponse
    {
        public string FoldersJSON { get; set; }
        public int NumberOfFoldersReadSuccessfully { get; set; }
        public int NumberOfFoldersFailedToRead { get; set; }
    }

    public class DeleteFilesResponse
    {
        public int NumberOfFilesDeleted { get; set; }
        public int NumberOfFilesFailedToDelete { get; set; }
    }

    public class GetDiskFreeSpaceResponse
    {
        public int FreeSpaceBytes { get; set; }
        public int FreeSpaceKB { get; set; }
        public int FreeSpaceMB { get; set; }
        public int FreeSpaceGB { get; set; }
    }

    public class GetListOfDrivesResponse
    {
        public string DrivesJSON { get; set; }
    }

    public class DirectoryIsAccessibleResponse
    {
        public bool DirectoryAccessible { get; set; }
        public bool DirectoryAccessUnauthorised { get; set; }
    }

    public class GetCSVTextAsCollectionResponse
    {
        public string CSVDataJSON { get; set; }
    }

    public class WriteCollectionToCSVFileResponse
    {
        public bool WriteCollectionToCSVFileResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum writeCollectionToCSVFileoutputEncodingInput
    {
        UTF8,
        UTF7,
        Unicode,
        ASCII
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addPermissionToFolderpermissionInput
    {
        Read,
        ReadAndExecute,
        Modify,
        FullControl
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addPermissionToFilepermissionInput
    {
        Read,
        ReadAndExecute,
        Modify,
        FullControl
    }

    public class GetFolderSecurityPermissionsResponse
    {
        public string SecurityPermissionsJSON { get; set; }
    }

    public class GetFileSecurityPermissionsResponse
    {
        public string SecurityPermissionsJSON { get; set; }
    }

    public class RemoveIdentityFromFolderSecurityResponse
    {
        public bool PermissionWasRemoved { get; set; }
    }

    public class RemoveIdentityFromFileSecurityResponse
    {
        public bool PermissionWasRemoved { get; set; }
    }

    public class DownloadHTTPFileResponse
    {
        public string DownloadFileContents { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum downloadHTTPFilereturnContentEncodingInput
    {
        ASCII,
        UTF7,
        UTF8,
        UTF16,
        UTF16BE
    }

    public class UnZIPFileResponse
    {
        public int FilesExtractedSuccessfully { get; set; }
        public int FilesFailedToExtract { get; set; }
        public int FilesExcluded { get; set; }
    }

    public class AddFolderToZIPResponse
    {
        public int FilesAddedSuccessfully { get; set; }
        public int FilesExcluded { get; set; }
    }

    public class GetFileContentsAsBase64Response
    {
        public string FileContentsAsBase64 { get; set; }
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
