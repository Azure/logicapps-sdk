//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class IaconnectsessionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMachineNameResponse> GetMachineName(Expression<Func<string>> getMachineNameworkflow)
        {
            var __workflow_getMachineNameworkflow = getMachineNameworkflow == null ? null : WorkflowExpression.Compile(getMachineNameworkflow);
            WorkflowExpression.Validate(__workflow_getMachineNameworkflow, nameof(getMachineNameworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMachineDomainResponse> GetMachineDomain(Expression<Func<string>> getMachineDomainworkflow)
        {
            var __workflow_getMachineDomainworkflow = getMachineDomainworkflow == null ? null : WorkflowExpression.Compile(getMachineDomainworkflow);
            WorkflowExpression.Validate(__workflow_getMachineDomainworkflow, nameof(getMachineDomainworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteSessionClientHostnameResponse> GetRemoteSessionClientHostname(Expression<Func<string>> getRemoteSessionClientHostnameworkflow)
        {
            var __workflow_getRemoteSessionClientHostnameworkflow = getRemoteSessionClientHostnameworkflow == null ? null : WorkflowExpression.Compile(getRemoteSessionClientHostnameworkflow);
            WorkflowExpression.Validate(__workflow_getRemoteSessionClientHostnameworkflow, nameof(getRemoteSessionClientHostnameworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ExpandEnvironmentVariableResponse> ExpandEnvironmentVariable(Expression<Func<string>> expandEnvironmentVariableinputString, Expression<Func<string>> expandEnvironmentVariableworkflow)
        {
            var __workflow_expandEnvironmentVariableinputString = expandEnvironmentVariableinputString == null ? null : WorkflowExpression.Compile(expandEnvironmentVariableinputString);
            WorkflowExpression.Validate(__workflow_expandEnvironmentVariableinputString, nameof(expandEnvironmentVariableinputString), required: true);
            var __workflow_expandEnvironmentVariableworkflow = expandEnvironmentVariableworkflow == null ? null : WorkflowExpression.Compile(expandEnvironmentVariableworkflow);
            WorkflowExpression.Validate(__workflow_expandEnvironmentVariableworkflow, nameof(expandEnvironmentVariableworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillProcessResponse> KillProcess(Expression<Func<string>> killProcessprocessName, Expression<Func<string>> killProcessworkflow)
        {
            var __workflow_killProcessprocessName = killProcessprocessName == null ? null : WorkflowExpression.Compile(killProcessprocessName);
            WorkflowExpression.Validate(__workflow_killProcessprocessName, nameof(killProcessprocessName), required: true);
            var __workflow_killProcessworkflow = killProcessworkflow == null ? null : WorkflowExpression.Compile(killProcessworkflow);
            WorkflowExpression.Validate(__workflow_killProcessworkflow, nameof(killProcessworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillProcessIDResponse> KillProcessID(Expression<Func<int>> killProcessIDprocessID, Expression<Func<string>> killProcessIDworkflow)
        {
            var __workflow_killProcessIDprocessID = killProcessIDprocessID == null ? null : WorkflowExpression.Compile(killProcessIDprocessID);
            WorkflowExpression.Validate(__workflow_killProcessIDprocessID, nameof(killProcessIDprocessID), required: true);
            var __workflow_killProcessIDworkflow = killProcessIDworkflow == null ? null : WorkflowExpression.Compile(killProcessIDworkflow);
            WorkflowExpression.Validate(__workflow_killProcessIDworkflow, nameof(killProcessIDworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessCountByNameResponse> GetProcessCountByName(Expression<Func<string>> getProcessCountByNameprocessName, Expression<Func<string>> getProcessCountByNameworkflow)
        {
            var __workflow_getProcessCountByNameprocessName = getProcessCountByNameprocessName == null ? null : WorkflowExpression.Compile(getProcessCountByNameprocessName);
            WorkflowExpression.Validate(__workflow_getProcessCountByNameprocessName, nameof(getProcessCountByNameprocessName), required: true);
            var __workflow_getProcessCountByNameworkflow = getProcessCountByNameworkflow == null ? null : WorkflowExpression.Compile(getProcessCountByNameworkflow);
            WorkflowExpression.Validate(__workflow_getProcessCountByNameworkflow, nameof(getProcessCountByNameworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentProcessCountResponse> GetAgentProcessCount(Expression<Func<string>> getAgentProcessCountworkflow)
        {
            var __workflow_getAgentProcessCountworkflow = getAgentProcessCountworkflow == null ? null : WorkflowExpression.Compile(getAgentProcessCountworkflow);
            WorkflowExpression.Validate(__workflow_getAgentProcessCountworkflow, nameof(getAgentProcessCountworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillAllOtherAgentsResponse> KillAllOtherAgents(Expression<Func<string>> killAllOtherAgentsworkflow)
        {
            var __workflow_killAllOtherAgentsworkflow = killAllOtherAgentsworkflow == null ? null : WorkflowExpression.Compile(killAllOtherAgentsworkflow);
            WorkflowExpression.Validate(__workflow_killAllOtherAgentsworkflow, nameof(killAllOtherAgentsworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessByPIDResponse> GetProcessByPID(Expression<Func<int>> getProcessByPIDprocessId, Expression<Func<string>> getProcessByPIDworkflow)
        {
            var __workflow_getProcessByPIDprocessId = getProcessByPIDprocessId == null ? null : WorkflowExpression.Compile(getProcessByPIDprocessId);
            WorkflowExpression.Validate(__workflow_getProcessByPIDprocessId, nameof(getProcessByPIDprocessId), required: true);
            var __workflow_getProcessByPIDworkflow = getProcessByPIDworkflow == null ? null : WorkflowExpression.Compile(getProcessByPIDworkflow);
            WorkflowExpression.Validate(__workflow_getProcessByPIDworkflow, nameof(getProcessByPIDworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessesResponse> GetProcesses(Expression<Func<string>> getProcessesworkflow, Expression<Func<string>> getProcessesprocessName = null, Expression<Func<bool>> getProcessesgetProcessCommandLine = null)
        {
            var __workflow_getProcessesworkflow = getProcessesworkflow == null ? null : WorkflowExpression.Compile(getProcessesworkflow);
            WorkflowExpression.Validate(__workflow_getProcessesworkflow, nameof(getProcessesworkflow), required: true);
            var __workflow_getProcessesprocessName = getProcessesprocessName == null ? null : WorkflowExpression.Compile(getProcessesprocessName);
            WorkflowExpression.Validate(__workflow_getProcessesprocessName, nameof(getProcessesprocessName), required: false);
            var __workflow_getProcessesgetProcessCommandLine = getProcessesgetProcessCommandLine == null ? null : WorkflowExpression.Compile(getProcessesgetProcessCommandLine);
            WorkflowExpression.Validate(__workflow_getProcessesgetProcessCommandLine, nameof(getProcessesgetProcessCommandLine), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunProcessResponse> RunProcess(Expression<Func<string>> runProcessprocessName, Expression<Func<string>> runProcessworkflow, Expression<Func<string>> runProcessarguments = null, Expression<Func<string>> runProcessworkingDirectory = null, Expression<Func<bool>> runProcessuseShellExecute = null, Expression<Func<bool>> runProcesscreateNoWindow = null, Expression<Func<runProcesswindowStyleInput>> runProcesswindowStyle = null, Expression<Func<bool>> runProcesswaitForProcess = null, Expression<Func<bool>> runProcessredirectStandardOutput = null, Expression<Func<bool>> runProcessredirectStandardError = null, Expression<Func<bool>> runProcessredirectStandardErrorToOutput = null, Expression<Func<runProcessstandardOutputEncodingInput>> runProcessstandardOutputEncoding = null, Expression<Func<runProcessstandardErrorEncodingInput>> runProcessstandardErrorEncoding = null, Expression<Func<string>> runProcessrunAsDomain = null, Expression<Func<string>> runProcessrunAsUsername = null, Expression<Func<string>> runProcessrunAsPassword = null, Expression<Func<bool>> runProcessrunAsLoadUserProfile = null, Expression<Func<bool>> runProcessrunAsElevate = null, Expression<Func<int>> runProcesstimeoutInSeconds = null)
        {
            var __workflow_runProcessprocessName = runProcessprocessName == null ? null : WorkflowExpression.Compile(runProcessprocessName);
            WorkflowExpression.Validate(__workflow_runProcessprocessName, nameof(runProcessprocessName), required: true);
            var __workflow_runProcessworkflow = runProcessworkflow == null ? null : WorkflowExpression.Compile(runProcessworkflow);
            WorkflowExpression.Validate(__workflow_runProcessworkflow, nameof(runProcessworkflow), required: true);
            var __workflow_runProcessarguments = runProcessarguments == null ? null : WorkflowExpression.Compile(runProcessarguments);
            WorkflowExpression.Validate(__workflow_runProcessarguments, nameof(runProcessarguments), required: false);
            var __workflow_runProcessworkingDirectory = runProcessworkingDirectory == null ? null : WorkflowExpression.Compile(runProcessworkingDirectory);
            WorkflowExpression.Validate(__workflow_runProcessworkingDirectory, nameof(runProcessworkingDirectory), required: false);
            var __workflow_runProcessuseShellExecute = runProcessuseShellExecute == null ? null : WorkflowExpression.Compile(runProcessuseShellExecute);
            WorkflowExpression.Validate(__workflow_runProcessuseShellExecute, nameof(runProcessuseShellExecute), required: false);
            var __workflow_runProcesscreateNoWindow = runProcesscreateNoWindow == null ? null : WorkflowExpression.Compile(runProcesscreateNoWindow);
            WorkflowExpression.Validate(__workflow_runProcesscreateNoWindow, nameof(runProcesscreateNoWindow), required: false);
            var __workflow_runProcesswindowStyle = runProcesswindowStyle == null ? null : WorkflowExpression.Compile(runProcesswindowStyle);
            WorkflowExpression.Validate(__workflow_runProcesswindowStyle, nameof(runProcesswindowStyle), required: false);
            var __workflow_runProcesswaitForProcess = runProcesswaitForProcess == null ? null : WorkflowExpression.Compile(runProcesswaitForProcess);
            WorkflowExpression.Validate(__workflow_runProcesswaitForProcess, nameof(runProcesswaitForProcess), required: false);
            var __workflow_runProcessredirectStandardOutput = runProcessredirectStandardOutput == null ? null : WorkflowExpression.Compile(runProcessredirectStandardOutput);
            WorkflowExpression.Validate(__workflow_runProcessredirectStandardOutput, nameof(runProcessredirectStandardOutput), required: false);
            var __workflow_runProcessredirectStandardError = runProcessredirectStandardError == null ? null : WorkflowExpression.Compile(runProcessredirectStandardError);
            WorkflowExpression.Validate(__workflow_runProcessredirectStandardError, nameof(runProcessredirectStandardError), required: false);
            var __workflow_runProcessredirectStandardErrorToOutput = runProcessredirectStandardErrorToOutput == null ? null : WorkflowExpression.Compile(runProcessredirectStandardErrorToOutput);
            WorkflowExpression.Validate(__workflow_runProcessredirectStandardErrorToOutput, nameof(runProcessredirectStandardErrorToOutput), required: false);
            var __workflow_runProcessstandardOutputEncoding = runProcessstandardOutputEncoding == null ? null : WorkflowExpression.Compile(runProcessstandardOutputEncoding);
            WorkflowExpression.Validate(__workflow_runProcessstandardOutputEncoding, nameof(runProcessstandardOutputEncoding), required: false);
            var __workflow_runProcessstandardErrorEncoding = runProcessstandardErrorEncoding == null ? null : WorkflowExpression.Compile(runProcessstandardErrorEncoding);
            WorkflowExpression.Validate(__workflow_runProcessstandardErrorEncoding, nameof(runProcessstandardErrorEncoding), required: false);
            var __workflow_runProcessrunAsDomain = runProcessrunAsDomain == null ? null : WorkflowExpression.Compile(runProcessrunAsDomain);
            WorkflowExpression.Validate(__workflow_runProcessrunAsDomain, nameof(runProcessrunAsDomain), required: false);
            var __workflow_runProcessrunAsUsername = runProcessrunAsUsername == null ? null : WorkflowExpression.Compile(runProcessrunAsUsername);
            WorkflowExpression.Validate(__workflow_runProcessrunAsUsername, nameof(runProcessrunAsUsername), required: false);
            var __workflow_runProcessrunAsPassword = runProcessrunAsPassword == null ? null : WorkflowExpression.Compile(runProcessrunAsPassword);
            WorkflowExpression.Validate(__workflow_runProcessrunAsPassword, nameof(runProcessrunAsPassword), required: false);
            var __workflow_runProcessrunAsLoadUserProfile = runProcessrunAsLoadUserProfile == null ? null : WorkflowExpression.Compile(runProcessrunAsLoadUserProfile);
            WorkflowExpression.Validate(__workflow_runProcessrunAsLoadUserProfile, nameof(runProcessrunAsLoadUserProfile), required: false);
            var __workflow_runProcessrunAsElevate = runProcessrunAsElevate == null ? null : WorkflowExpression.Compile(runProcessrunAsElevate);
            WorkflowExpression.Validate(__workflow_runProcessrunAsElevate, nameof(runProcessrunAsElevate), required: false);
            var __workflow_runProcesstimeoutInSeconds = runProcesstimeoutInSeconds == null ? null : WorkflowExpression.Compile(runProcesstimeoutInSeconds);
            WorkflowExpression.Validate(__workflow_runProcesstimeoutInSeconds, nameof(runProcesstimeoutInSeconds), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunPowerShellProcessResponse> RunPowerShellProcess(Expression<Func<string>> runPowerShellProcessworkflow, Expression<Func<string>> runPowerShellProcesspowerShellExecutable = null, Expression<Func<string>> runPowerShellProcesspowerShellScriptFilePath = null, Expression<Func<string>> runPowerShellProcesspowerShellScriptContents = null, Expression<Func<string>> runPowerShellProcessworkingDirectory = null, Expression<Func<bool>> runPowerShellProcesscreateNoWindow = null, Expression<Func<runPowerShellProcesswindowStyleInput>> runPowerShellProcesswindowStyle = null, Expression<Func<bool>> runPowerShellProcesswaitForProcess = null, Expression<Func<bool>> runPowerShellProcessredirectStandardOutput = null, Expression<Func<bool>> runPowerShellProcessredirectStandardError = null, Expression<Func<bool>> runPowerShellProcessredirectStandardErrorToOutput = null, Expression<Func<runPowerShellProcessstandardOutputEncodingInput>> runPowerShellProcessstandardOutputEncoding = null, Expression<Func<runPowerShellProcessstandardErrorEncodingInput>> runPowerShellProcessstandardErrorEncoding = null, Expression<Func<string>> runPowerShellProcessrunAsDomain = null, Expression<Func<string>> runPowerShellProcessrunAsUsername = null, Expression<Func<string>> runPowerShellProcessrunAsPassword = null, Expression<Func<bool>> runPowerShellProcessrunAsLoadUserProfile = null, Expression<Func<bool>> runPowerShellProcessrunAsElevate = null, Expression<Func<int>> runPowerShellProcesstimeoutInSeconds = null, Expression<Func<string>> runPowerShellProcesspowerShellScriptTempFolder = null)
        {
            var __workflow_runPowerShellProcessworkflow = runPowerShellProcessworkflow == null ? null : WorkflowExpression.Compile(runPowerShellProcessworkflow);
            WorkflowExpression.Validate(__workflow_runPowerShellProcessworkflow, nameof(runPowerShellProcessworkflow), required: true);
            var __workflow_runPowerShellProcesspowerShellExecutable = runPowerShellProcesspowerShellExecutable == null ? null : WorkflowExpression.Compile(runPowerShellProcesspowerShellExecutable);
            WorkflowExpression.Validate(__workflow_runPowerShellProcesspowerShellExecutable, nameof(runPowerShellProcesspowerShellExecutable), required: false);
            var __workflow_runPowerShellProcesspowerShellScriptFilePath = runPowerShellProcesspowerShellScriptFilePath == null ? null : WorkflowExpression.Compile(runPowerShellProcesspowerShellScriptFilePath);
            WorkflowExpression.Validate(__workflow_runPowerShellProcesspowerShellScriptFilePath, nameof(runPowerShellProcesspowerShellScriptFilePath), required: false);
            var __workflow_runPowerShellProcesspowerShellScriptContents = runPowerShellProcesspowerShellScriptContents == null ? null : WorkflowExpression.Compile(runPowerShellProcesspowerShellScriptContents);
            WorkflowExpression.Validate(__workflow_runPowerShellProcesspowerShellScriptContents, nameof(runPowerShellProcesspowerShellScriptContents), required: false);
            var __workflow_runPowerShellProcessworkingDirectory = runPowerShellProcessworkingDirectory == null ? null : WorkflowExpression.Compile(runPowerShellProcessworkingDirectory);
            WorkflowExpression.Validate(__workflow_runPowerShellProcessworkingDirectory, nameof(runPowerShellProcessworkingDirectory), required: false);
            var __workflow_runPowerShellProcesscreateNoWindow = runPowerShellProcesscreateNoWindow == null ? null : WorkflowExpression.Compile(runPowerShellProcesscreateNoWindow);
            WorkflowExpression.Validate(__workflow_runPowerShellProcesscreateNoWindow, nameof(runPowerShellProcesscreateNoWindow), required: false);
            var __workflow_runPowerShellProcesswindowStyle = runPowerShellProcesswindowStyle == null ? null : WorkflowExpression.Compile(runPowerShellProcesswindowStyle);
            WorkflowExpression.Validate(__workflow_runPowerShellProcesswindowStyle, nameof(runPowerShellProcesswindowStyle), required: false);
            var __workflow_runPowerShellProcesswaitForProcess = runPowerShellProcesswaitForProcess == null ? null : WorkflowExpression.Compile(runPowerShellProcesswaitForProcess);
            WorkflowExpression.Validate(__workflow_runPowerShellProcesswaitForProcess, nameof(runPowerShellProcesswaitForProcess), required: false);
            var __workflow_runPowerShellProcessredirectStandardOutput = runPowerShellProcessredirectStandardOutput == null ? null : WorkflowExpression.Compile(runPowerShellProcessredirectStandardOutput);
            WorkflowExpression.Validate(__workflow_runPowerShellProcessredirectStandardOutput, nameof(runPowerShellProcessredirectStandardOutput), required: false);
            var __workflow_runPowerShellProcessredirectStandardError = runPowerShellProcessredirectStandardError == null ? null : WorkflowExpression.Compile(runPowerShellProcessredirectStandardError);
            WorkflowExpression.Validate(__workflow_runPowerShellProcessredirectStandardError, nameof(runPowerShellProcessredirectStandardError), required: false);
            var __workflow_runPowerShellProcessredirectStandardErrorToOutput = runPowerShellProcessredirectStandardErrorToOutput == null ? null : WorkflowExpression.Compile(runPowerShellProcessredirectStandardErrorToOutput);
            WorkflowExpression.Validate(__workflow_runPowerShellProcessredirectStandardErrorToOutput, nameof(runPowerShellProcessredirectStandardErrorToOutput), required: false);
            var __workflow_runPowerShellProcessstandardOutputEncoding = runPowerShellProcessstandardOutputEncoding == null ? null : WorkflowExpression.Compile(runPowerShellProcessstandardOutputEncoding);
            WorkflowExpression.Validate(__workflow_runPowerShellProcessstandardOutputEncoding, nameof(runPowerShellProcessstandardOutputEncoding), required: false);
            var __workflow_runPowerShellProcessstandardErrorEncoding = runPowerShellProcessstandardErrorEncoding == null ? null : WorkflowExpression.Compile(runPowerShellProcessstandardErrorEncoding);
            WorkflowExpression.Validate(__workflow_runPowerShellProcessstandardErrorEncoding, nameof(runPowerShellProcessstandardErrorEncoding), required: false);
            var __workflow_runPowerShellProcessrunAsDomain = runPowerShellProcessrunAsDomain == null ? null : WorkflowExpression.Compile(runPowerShellProcessrunAsDomain);
            WorkflowExpression.Validate(__workflow_runPowerShellProcessrunAsDomain, nameof(runPowerShellProcessrunAsDomain), required: false);
            var __workflow_runPowerShellProcessrunAsUsername = runPowerShellProcessrunAsUsername == null ? null : WorkflowExpression.Compile(runPowerShellProcessrunAsUsername);
            WorkflowExpression.Validate(__workflow_runPowerShellProcessrunAsUsername, nameof(runPowerShellProcessrunAsUsername), required: false);
            var __workflow_runPowerShellProcessrunAsPassword = runPowerShellProcessrunAsPassword == null ? null : WorkflowExpression.Compile(runPowerShellProcessrunAsPassword);
            WorkflowExpression.Validate(__workflow_runPowerShellProcessrunAsPassword, nameof(runPowerShellProcessrunAsPassword), required: false);
            var __workflow_runPowerShellProcessrunAsLoadUserProfile = runPowerShellProcessrunAsLoadUserProfile == null ? null : WorkflowExpression.Compile(runPowerShellProcessrunAsLoadUserProfile);
            WorkflowExpression.Validate(__workflow_runPowerShellProcessrunAsLoadUserProfile, nameof(runPowerShellProcessrunAsLoadUserProfile), required: false);
            var __workflow_runPowerShellProcessrunAsElevate = runPowerShellProcessrunAsElevate == null ? null : WorkflowExpression.Compile(runPowerShellProcessrunAsElevate);
            WorkflowExpression.Validate(__workflow_runPowerShellProcessrunAsElevate, nameof(runPowerShellProcessrunAsElevate), required: false);
            var __workflow_runPowerShellProcesstimeoutInSeconds = runPowerShellProcesstimeoutInSeconds == null ? null : WorkflowExpression.Compile(runPowerShellProcesstimeoutInSeconds);
            WorkflowExpression.Validate(__workflow_runPowerShellProcesstimeoutInSeconds, nameof(runPowerShellProcesstimeoutInSeconds), required: false);
            var __workflow_runPowerShellProcesspowerShellScriptTempFolder = runPowerShellProcesspowerShellScriptTempFolder == null ? null : WorkflowExpression.Compile(runPowerShellProcesspowerShellScriptTempFolder);
            WorkflowExpression.Validate(__workflow_runPowerShellProcesspowerShellScriptTempFolder, nameof(runPowerShellProcesspowerShellScriptTempFolder), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetScreenResolutionResponse> GetScreenResolution(Expression<Func<string>> getScreenResolutionworkflow)
        {
            var __workflow_getScreenResolutionworkflow = getScreenResolutionworkflow == null ? null : WorkflowExpression.Compile(getScreenResolutionworkflow);
            WorkflowExpression.Validate(__workflow_getScreenResolutionworkflow, nameof(getScreenResolutionworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetDefaultPrinter(Expression<Func<string>> setDefaultPrinterdefaultPrinterName, Expression<Func<string>> setDefaultPrinterworkflow)
        {
            var __workflow_setDefaultPrinterdefaultPrinterName = setDefaultPrinterdefaultPrinterName == null ? null : WorkflowExpression.Compile(setDefaultPrinterdefaultPrinterName);
            WorkflowExpression.Validate(__workflow_setDefaultPrinterdefaultPrinterName, nameof(setDefaultPrinterdefaultPrinterName), required: true);
            var __workflow_setDefaultPrinterworkflow = setDefaultPrinterworkflow == null ? null : WorkflowExpression.Compile(setDefaultPrinterworkflow);
            WorkflowExpression.Validate(__workflow_setDefaultPrinterworkflow, nameof(setDefaultPrinterworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDefaultPrinterResponse> GetDefaultPrinter(Expression<Func<string>> getDefaultPrinterworkflow)
        {
            var __workflow_getDefaultPrinterworkflow = getDefaultPrinterworkflow == null ? null : WorkflowExpression.Compile(getDefaultPrinterworkflow);
            WorkflowExpression.Validate(__workflow_getDefaultPrinterworkflow, nameof(getDefaultPrinterworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfPrintersResponse> GetListOfPrinters(Expression<Func<string>> getListOfPrintersworkflow, Expression<Func<bool>> getListOfPrinterslistLocalPrinters = null, Expression<Func<bool>> getListOfPrinterslistNetworkPrinters = null, Expression<Func<bool>> getListOfPrintersreturnDetailedInformation = null)
        {
            var __workflow_getListOfPrintersworkflow = getListOfPrintersworkflow == null ? null : WorkflowExpression.Compile(getListOfPrintersworkflow);
            WorkflowExpression.Validate(__workflow_getListOfPrintersworkflow, nameof(getListOfPrintersworkflow), required: true);
            var __workflow_getListOfPrinterslistLocalPrinters = getListOfPrinterslistLocalPrinters == null ? null : WorkflowExpression.Compile(getListOfPrinterslistLocalPrinters);
            WorkflowExpression.Validate(__workflow_getListOfPrinterslistLocalPrinters, nameof(getListOfPrinterslistLocalPrinters), required: false);
            var __workflow_getListOfPrinterslistNetworkPrinters = getListOfPrinterslistNetworkPrinters == null ? null : WorkflowExpression.Compile(getListOfPrinterslistNetworkPrinters);
            WorkflowExpression.Validate(__workflow_getListOfPrinterslistNetworkPrinters, nameof(getListOfPrinterslistNetworkPrinters), required: false);
            var __workflow_getListOfPrintersreturnDetailedInformation = getListOfPrintersreturnDetailedInformation == null ? null : WorkflowExpression.Compile(getListOfPrintersreturnDetailedInformation);
            WorkflowExpression.Validate(__workflow_getListOfPrintersreturnDetailedInformation, nameof(getListOfPrintersreturnDetailedInformation), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetMouseMultiplier(Expression<Func<string>> setMouseMultiplierworkflow, Expression<Func<double>> setMouseMultipliermouseXMultiplier = null, Expression<Func<double>> setMouseMultipliermouseYMultiplier = null, Expression<Func<bool>> setMouseMultiplierapplyToMouseEvent = null, Expression<Func<bool>> setMouseMultiplierapplyToSetCursorPos = null, Expression<Func<bool>> setMouseMultiplierapplyToCurrentMouseMoveMethod = null)
        {
            var __workflow_setMouseMultiplierworkflow = setMouseMultiplierworkflow == null ? null : WorkflowExpression.Compile(setMouseMultiplierworkflow);
            WorkflowExpression.Validate(__workflow_setMouseMultiplierworkflow, nameof(setMouseMultiplierworkflow), required: true);
            var __workflow_setMouseMultipliermouseXMultiplier = setMouseMultipliermouseXMultiplier == null ? null : WorkflowExpression.Compile(setMouseMultipliermouseXMultiplier);
            WorkflowExpression.Validate(__workflow_setMouseMultipliermouseXMultiplier, nameof(setMouseMultipliermouseXMultiplier), required: false);
            var __workflow_setMouseMultipliermouseYMultiplier = setMouseMultipliermouseYMultiplier == null ? null : WorkflowExpression.Compile(setMouseMultipliermouseYMultiplier);
            WorkflowExpression.Validate(__workflow_setMouseMultipliermouseYMultiplier, nameof(setMouseMultipliermouseYMultiplier), required: false);
            var __workflow_setMouseMultiplierapplyToMouseEvent = setMouseMultiplierapplyToMouseEvent == null ? null : WorkflowExpression.Compile(setMouseMultiplierapplyToMouseEvent);
            WorkflowExpression.Validate(__workflow_setMouseMultiplierapplyToMouseEvent, nameof(setMouseMultiplierapplyToMouseEvent), required: false);
            var __workflow_setMouseMultiplierapplyToSetCursorPos = setMouseMultiplierapplyToSetCursorPos == null ? null : WorkflowExpression.Compile(setMouseMultiplierapplyToSetCursorPos);
            WorkflowExpression.Validate(__workflow_setMouseMultiplierapplyToSetCursorPos, nameof(setMouseMultiplierapplyToSetCursorPos), required: false);
            var __workflow_setMouseMultiplierapplyToCurrentMouseMoveMethod = setMouseMultiplierapplyToCurrentMouseMoveMethod == null ? null : WorkflowExpression.Compile(setMouseMultiplierapplyToCurrentMouseMoveMethod);
            WorkflowExpression.Validate(__workflow_setMouseMultiplierapplyToCurrentMouseMoveMethod, nameof(setMouseMultiplierapplyToCurrentMouseMoveMethod), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMouseMultiplierResponse> GetMouseMultiplier(Expression<Func<string>> getMouseMultiplierworkflow)
        {
            var __workflow_getMouseMultiplierworkflow = getMouseMultiplierworkflow == null ? null : WorkflowExpression.Compile(getMouseMultiplierworkflow);
            WorkflowExpression.Validate(__workflow_getMouseMultiplierworkflow, nameof(getMouseMultiplierworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseToCoordinate(Expression<Func<int>> moveMouseToCoordinatexCoord, Expression<Func<int>> moveMouseToCoordinateyCoord, Expression<Func<string>> moveMouseToCoordinateworkflow)
        {
            var __workflow_moveMouseToCoordinatexCoord = moveMouseToCoordinatexCoord == null ? null : WorkflowExpression.Compile(moveMouseToCoordinatexCoord);
            WorkflowExpression.Validate(__workflow_moveMouseToCoordinatexCoord, nameof(moveMouseToCoordinatexCoord), required: true);
            var __workflow_moveMouseToCoordinateyCoord = moveMouseToCoordinateyCoord == null ? null : WorkflowExpression.Compile(moveMouseToCoordinateyCoord);
            WorkflowExpression.Validate(__workflow_moveMouseToCoordinateyCoord, nameof(moveMouseToCoordinateyCoord), required: true);
            var __workflow_moveMouseToCoordinateworkflow = moveMouseToCoordinateworkflow == null ? null : WorkflowExpression.Compile(moveMouseToCoordinateworkflow);
            WorkflowExpression.Validate(__workflow_moveMouseToCoordinateworkflow, nameof(moveMouseToCoordinateworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseRelative(Expression<Func<int>> moveMouseRelativexCoord, Expression<Func<int>> moveMouseRelativeyCoord, Expression<Func<string>> moveMouseRelativeworkflow)
        {
            var __workflow_moveMouseRelativexCoord = moveMouseRelativexCoord == null ? null : WorkflowExpression.Compile(moveMouseRelativexCoord);
            WorkflowExpression.Validate(__workflow_moveMouseRelativexCoord, nameof(moveMouseRelativexCoord), required: true);
            var __workflow_moveMouseRelativeyCoord = moveMouseRelativeyCoord == null ? null : WorkflowExpression.Compile(moveMouseRelativeyCoord);
            WorkflowExpression.Validate(__workflow_moveMouseRelativeyCoord, nameof(moveMouseRelativeyCoord), required: true);
            var __workflow_moveMouseRelativeworkflow = moveMouseRelativeworkflow == null ? null : WorkflowExpression.Compile(moveMouseRelativeworkflow);
            WorkflowExpression.Validate(__workflow_moveMouseRelativeworkflow, nameof(moveMouseRelativeworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseButtonDown(Expression<Func<string>> leftMouseButtonDownworkflow)
        {
            var __workflow_leftMouseButtonDownworkflow = leftMouseButtonDownworkflow == null ? null : WorkflowExpression.Compile(leftMouseButtonDownworkflow);
            WorkflowExpression.Validate(__workflow_leftMouseButtonDownworkflow, nameof(leftMouseButtonDownworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseButtonUp(Expression<Func<string>> leftMouseButtonUpworkflow)
        {
            var __workflow_leftMouseButtonUpworkflow = leftMouseButtonUpworkflow == null ? null : WorkflowExpression.Compile(leftMouseButtonUpworkflow);
            WorkflowExpression.Validate(__workflow_leftMouseButtonUpworkflow, nameof(leftMouseButtonUpworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftClickMouse(Expression<Func<string>> leftClickMouseworkflow)
        {
            var __workflow_leftClickMouseworkflow = leftClickMouseworkflow == null ? null : WorkflowExpression.Compile(leftClickMouseworkflow);
            WorkflowExpression.Validate(__workflow_leftClickMouseworkflow, nameof(leftClickMouseworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftClickMouseAtCoordinate(Expression<Func<int>> leftClickMouseAtCoordinatexCoord, Expression<Func<int>> leftClickMouseAtCoordinateyCoord, Expression<Func<string>> leftClickMouseAtCoordinateworkflow)
        {
            var __workflow_leftClickMouseAtCoordinatexCoord = leftClickMouseAtCoordinatexCoord == null ? null : WorkflowExpression.Compile(leftClickMouseAtCoordinatexCoord);
            WorkflowExpression.Validate(__workflow_leftClickMouseAtCoordinatexCoord, nameof(leftClickMouseAtCoordinatexCoord), required: true);
            var __workflow_leftClickMouseAtCoordinateyCoord = leftClickMouseAtCoordinateyCoord == null ? null : WorkflowExpression.Compile(leftClickMouseAtCoordinateyCoord);
            WorkflowExpression.Validate(__workflow_leftClickMouseAtCoordinateyCoord, nameof(leftClickMouseAtCoordinateyCoord), required: true);
            var __workflow_leftClickMouseAtCoordinateworkflow = leftClickMouseAtCoordinateworkflow == null ? null : WorkflowExpression.Compile(leftClickMouseAtCoordinateworkflow);
            WorkflowExpression.Validate(__workflow_leftClickMouseAtCoordinateworkflow, nameof(leftClickMouseAtCoordinateworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftHoldMouse(Expression<Func<double>> leftHoldMousesecondsToHold, Expression<Func<string>> leftHoldMouseworkflow)
        {
            var __workflow_leftHoldMousesecondsToHold = leftHoldMousesecondsToHold == null ? null : WorkflowExpression.Compile(leftHoldMousesecondsToHold);
            WorkflowExpression.Validate(__workflow_leftHoldMousesecondsToHold, nameof(leftHoldMousesecondsToHold), required: true);
            var __workflow_leftHoldMouseworkflow = leftHoldMouseworkflow == null ? null : WorkflowExpression.Compile(leftHoldMouseworkflow);
            WorkflowExpression.Validate(__workflow_leftHoldMouseworkflow, nameof(leftHoldMouseworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftHoldMouseAtCoordinate(Expression<Func<int>> leftHoldMouseAtCoordinatexCoord, Expression<Func<int>> leftHoldMouseAtCoordinateyCoord, Expression<Func<double>> leftHoldMouseAtCoordinatesecondsToHold, Expression<Func<string>> leftHoldMouseAtCoordinateworkflow)
        {
            var __workflow_leftHoldMouseAtCoordinatexCoord = leftHoldMouseAtCoordinatexCoord == null ? null : WorkflowExpression.Compile(leftHoldMouseAtCoordinatexCoord);
            WorkflowExpression.Validate(__workflow_leftHoldMouseAtCoordinatexCoord, nameof(leftHoldMouseAtCoordinatexCoord), required: true);
            var __workflow_leftHoldMouseAtCoordinateyCoord = leftHoldMouseAtCoordinateyCoord == null ? null : WorkflowExpression.Compile(leftHoldMouseAtCoordinateyCoord);
            WorkflowExpression.Validate(__workflow_leftHoldMouseAtCoordinateyCoord, nameof(leftHoldMouseAtCoordinateyCoord), required: true);
            var __workflow_leftHoldMouseAtCoordinatesecondsToHold = leftHoldMouseAtCoordinatesecondsToHold == null ? null : WorkflowExpression.Compile(leftHoldMouseAtCoordinatesecondsToHold);
            WorkflowExpression.Validate(__workflow_leftHoldMouseAtCoordinatesecondsToHold, nameof(leftHoldMouseAtCoordinatesecondsToHold), required: true);
            var __workflow_leftHoldMouseAtCoordinateworkflow = leftHoldMouseAtCoordinateworkflow == null ? null : WorkflowExpression.Compile(leftHoldMouseAtCoordinateworkflow);
            WorkflowExpression.Validate(__workflow_leftHoldMouseAtCoordinateworkflow, nameof(leftHoldMouseAtCoordinateworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseButtonDown(Expression<Func<string>> rightMouseButtonDownworkflow)
        {
            var __workflow_rightMouseButtonDownworkflow = rightMouseButtonDownworkflow == null ? null : WorkflowExpression.Compile(rightMouseButtonDownworkflow);
            WorkflowExpression.Validate(__workflow_rightMouseButtonDownworkflow, nameof(rightMouseButtonDownworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseButtonUp(Expression<Func<string>> rightMouseButtonUpworkflow)
        {
            var __workflow_rightMouseButtonUpworkflow = rightMouseButtonUpworkflow == null ? null : WorkflowExpression.Compile(rightMouseButtonUpworkflow);
            WorkflowExpression.Validate(__workflow_rightMouseButtonUpworkflow, nameof(rightMouseButtonUpworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightClickMouse(Expression<Func<string>> rightClickMouseworkflow)
        {
            var __workflow_rightClickMouseworkflow = rightClickMouseworkflow == null ? null : WorkflowExpression.Compile(rightClickMouseworkflow);
            WorkflowExpression.Validate(__workflow_rightClickMouseworkflow, nameof(rightClickMouseworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightClickMouseAtCoordinate(Expression<Func<int>> rightClickMouseAtCoordinatexCoord, Expression<Func<int>> rightClickMouseAtCoordinateyCoord, Expression<Func<string>> rightClickMouseAtCoordinateworkflow)
        {
            var __workflow_rightClickMouseAtCoordinatexCoord = rightClickMouseAtCoordinatexCoord == null ? null : WorkflowExpression.Compile(rightClickMouseAtCoordinatexCoord);
            WorkflowExpression.Validate(__workflow_rightClickMouseAtCoordinatexCoord, nameof(rightClickMouseAtCoordinatexCoord), required: true);
            var __workflow_rightClickMouseAtCoordinateyCoord = rightClickMouseAtCoordinateyCoord == null ? null : WorkflowExpression.Compile(rightClickMouseAtCoordinateyCoord);
            WorkflowExpression.Validate(__workflow_rightClickMouseAtCoordinateyCoord, nameof(rightClickMouseAtCoordinateyCoord), required: true);
            var __workflow_rightClickMouseAtCoordinateworkflow = rightClickMouseAtCoordinateworkflow == null ? null : WorkflowExpression.Compile(rightClickMouseAtCoordinateworkflow);
            WorkflowExpression.Validate(__workflow_rightClickMouseAtCoordinateworkflow, nameof(rightClickMouseAtCoordinateworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightHoldMouse(Expression<Func<double>> rightHoldMousesecondsToHold, Expression<Func<string>> rightHoldMouseworkflow)
        {
            var __workflow_rightHoldMousesecondsToHold = rightHoldMousesecondsToHold == null ? null : WorkflowExpression.Compile(rightHoldMousesecondsToHold);
            WorkflowExpression.Validate(__workflow_rightHoldMousesecondsToHold, nameof(rightHoldMousesecondsToHold), required: true);
            var __workflow_rightHoldMouseworkflow = rightHoldMouseworkflow == null ? null : WorkflowExpression.Compile(rightHoldMouseworkflow);
            WorkflowExpression.Validate(__workflow_rightHoldMouseworkflow, nameof(rightHoldMouseworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightHoldMouseAtCoordinate(Expression<Func<int>> rightHoldMouseAtCoordinatexCoord, Expression<Func<int>> rightHoldMouseAtCoordinateyCoord, Expression<Func<double>> rightHoldMouseAtCoordinatesecondsToHold, Expression<Func<string>> rightHoldMouseAtCoordinateworkflow)
        {
            var __workflow_rightHoldMouseAtCoordinatexCoord = rightHoldMouseAtCoordinatexCoord == null ? null : WorkflowExpression.Compile(rightHoldMouseAtCoordinatexCoord);
            WorkflowExpression.Validate(__workflow_rightHoldMouseAtCoordinatexCoord, nameof(rightHoldMouseAtCoordinatexCoord), required: true);
            var __workflow_rightHoldMouseAtCoordinateyCoord = rightHoldMouseAtCoordinateyCoord == null ? null : WorkflowExpression.Compile(rightHoldMouseAtCoordinateyCoord);
            WorkflowExpression.Validate(__workflow_rightHoldMouseAtCoordinateyCoord, nameof(rightHoldMouseAtCoordinateyCoord), required: true);
            var __workflow_rightHoldMouseAtCoordinatesecondsToHold = rightHoldMouseAtCoordinatesecondsToHold == null ? null : WorkflowExpression.Compile(rightHoldMouseAtCoordinatesecondsToHold);
            WorkflowExpression.Validate(__workflow_rightHoldMouseAtCoordinatesecondsToHold, nameof(rightHoldMouseAtCoordinatesecondsToHold), required: true);
            var __workflow_rightHoldMouseAtCoordinateworkflow = rightHoldMouseAtCoordinateworkflow == null ? null : WorkflowExpression.Compile(rightHoldMouseAtCoordinateworkflow);
            WorkflowExpression.Validate(__workflow_rightHoldMouseAtCoordinateworkflow, nameof(rightHoldMouseAtCoordinateworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseButtonDown(Expression<Func<string>> middleMouseButtonDownworkflow)
        {
            var __workflow_middleMouseButtonDownworkflow = middleMouseButtonDownworkflow == null ? null : WorkflowExpression.Compile(middleMouseButtonDownworkflow);
            WorkflowExpression.Validate(__workflow_middleMouseButtonDownworkflow, nameof(middleMouseButtonDownworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseButtonUp(Expression<Func<string>> middleMouseButtonUpworkflow)
        {
            var __workflow_middleMouseButtonUpworkflow = middleMouseButtonUpworkflow == null ? null : WorkflowExpression.Compile(middleMouseButtonUpworkflow);
            WorkflowExpression.Validate(__workflow_middleMouseButtonUpworkflow, nameof(middleMouseButtonUpworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleClickMouse(Expression<Func<string>> middleClickMouseworkflow)
        {
            var __workflow_middleClickMouseworkflow = middleClickMouseworkflow == null ? null : WorkflowExpression.Compile(middleClickMouseworkflow);
            WorkflowExpression.Validate(__workflow_middleClickMouseworkflow, nameof(middleClickMouseworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleClickMouseAtCoordinate(Expression<Func<int>> middleClickMouseAtCoordinatexCoord, Expression<Func<int>> middleClickMouseAtCoordinateyCoord, Expression<Func<string>> middleClickMouseAtCoordinateworkflow)
        {
            var __workflow_middleClickMouseAtCoordinatexCoord = middleClickMouseAtCoordinatexCoord == null ? null : WorkflowExpression.Compile(middleClickMouseAtCoordinatexCoord);
            WorkflowExpression.Validate(__workflow_middleClickMouseAtCoordinatexCoord, nameof(middleClickMouseAtCoordinatexCoord), required: true);
            var __workflow_middleClickMouseAtCoordinateyCoord = middleClickMouseAtCoordinateyCoord == null ? null : WorkflowExpression.Compile(middleClickMouseAtCoordinateyCoord);
            WorkflowExpression.Validate(__workflow_middleClickMouseAtCoordinateyCoord, nameof(middleClickMouseAtCoordinateyCoord), required: true);
            var __workflow_middleClickMouseAtCoordinateworkflow = middleClickMouseAtCoordinateworkflow == null ? null : WorkflowExpression.Compile(middleClickMouseAtCoordinateworkflow);
            WorkflowExpression.Validate(__workflow_middleClickMouseAtCoordinateworkflow, nameof(middleClickMouseAtCoordinateworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleHoldMouse(Expression<Func<double>> middleHoldMousesecondsToHold, Expression<Func<string>> middleHoldMouseworkflow)
        {
            var __workflow_middleHoldMousesecondsToHold = middleHoldMousesecondsToHold == null ? null : WorkflowExpression.Compile(middleHoldMousesecondsToHold);
            WorkflowExpression.Validate(__workflow_middleHoldMousesecondsToHold, nameof(middleHoldMousesecondsToHold), required: true);
            var __workflow_middleHoldMouseworkflow = middleHoldMouseworkflow == null ? null : WorkflowExpression.Compile(middleHoldMouseworkflow);
            WorkflowExpression.Validate(__workflow_middleHoldMouseworkflow, nameof(middleHoldMouseworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleHoldMouseAtCoordinate(Expression<Func<int>> middleHoldMouseAtCoordinatexCoord, Expression<Func<int>> middleHoldMouseAtCoordinateyCoord, Expression<Func<double>> middleHoldMouseAtCoordinatesecondsToHold, Expression<Func<string>> middleHoldMouseAtCoordinateworkflow)
        {
            var __workflow_middleHoldMouseAtCoordinatexCoord = middleHoldMouseAtCoordinatexCoord == null ? null : WorkflowExpression.Compile(middleHoldMouseAtCoordinatexCoord);
            WorkflowExpression.Validate(__workflow_middleHoldMouseAtCoordinatexCoord, nameof(middleHoldMouseAtCoordinatexCoord), required: true);
            var __workflow_middleHoldMouseAtCoordinateyCoord = middleHoldMouseAtCoordinateyCoord == null ? null : WorkflowExpression.Compile(middleHoldMouseAtCoordinateyCoord);
            WorkflowExpression.Validate(__workflow_middleHoldMouseAtCoordinateyCoord, nameof(middleHoldMouseAtCoordinateyCoord), required: true);
            var __workflow_middleHoldMouseAtCoordinatesecondsToHold = middleHoldMouseAtCoordinatesecondsToHold == null ? null : WorkflowExpression.Compile(middleHoldMouseAtCoordinatesecondsToHold);
            WorkflowExpression.Validate(__workflow_middleHoldMouseAtCoordinatesecondsToHold, nameof(middleHoldMouseAtCoordinatesecondsToHold), required: true);
            var __workflow_middleHoldMouseAtCoordinateworkflow = middleHoldMouseAtCoordinateworkflow == null ? null : WorkflowExpression.Compile(middleHoldMouseAtCoordinateworkflow);
            WorkflowExpression.Validate(__workflow_middleHoldMouseAtCoordinateworkflow, nameof(middleHoldMouseAtCoordinateworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DoubleLeftClickMouse(Expression<Func<string>> doubleLeftClickMouseworkflow, Expression<Func<int>> doubleLeftClickMousedelayInMilliseconds = null)
        {
            var __workflow_doubleLeftClickMouseworkflow = doubleLeftClickMouseworkflow == null ? null : WorkflowExpression.Compile(doubleLeftClickMouseworkflow);
            WorkflowExpression.Validate(__workflow_doubleLeftClickMouseworkflow, nameof(doubleLeftClickMouseworkflow), required: true);
            var __workflow_doubleLeftClickMousedelayInMilliseconds = doubleLeftClickMousedelayInMilliseconds == null ? null : WorkflowExpression.Compile(doubleLeftClickMousedelayInMilliseconds);
            WorkflowExpression.Validate(__workflow_doubleLeftClickMousedelayInMilliseconds, nameof(doubleLeftClickMousedelayInMilliseconds), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DoubleLeftClickMouseAtCoordinate(Expression<Func<int>> doubleLeftClickMouseAtCoordinatexCoord, Expression<Func<int>> doubleLeftClickMouseAtCoordinateyCoord, Expression<Func<string>> doubleLeftClickMouseAtCoordinateworkflow, Expression<Func<int>> doubleLeftClickMouseAtCoordinatedelayInMilliseconds = null)
        {
            var __workflow_doubleLeftClickMouseAtCoordinatexCoord = doubleLeftClickMouseAtCoordinatexCoord == null ? null : WorkflowExpression.Compile(doubleLeftClickMouseAtCoordinatexCoord);
            WorkflowExpression.Validate(__workflow_doubleLeftClickMouseAtCoordinatexCoord, nameof(doubleLeftClickMouseAtCoordinatexCoord), required: true);
            var __workflow_doubleLeftClickMouseAtCoordinateyCoord = doubleLeftClickMouseAtCoordinateyCoord == null ? null : WorkflowExpression.Compile(doubleLeftClickMouseAtCoordinateyCoord);
            WorkflowExpression.Validate(__workflow_doubleLeftClickMouseAtCoordinateyCoord, nameof(doubleLeftClickMouseAtCoordinateyCoord), required: true);
            var __workflow_doubleLeftClickMouseAtCoordinateworkflow = doubleLeftClickMouseAtCoordinateworkflow == null ? null : WorkflowExpression.Compile(doubleLeftClickMouseAtCoordinateworkflow);
            WorkflowExpression.Validate(__workflow_doubleLeftClickMouseAtCoordinateworkflow, nameof(doubleLeftClickMouseAtCoordinateworkflow), required: true);
            var __workflow_doubleLeftClickMouseAtCoordinatedelayInMilliseconds = doubleLeftClickMouseAtCoordinatedelayInMilliseconds == null ? null : WorkflowExpression.Compile(doubleLeftClickMouseAtCoordinatedelayInMilliseconds);
            WorkflowExpression.Validate(__workflow_doubleLeftClickMouseAtCoordinatedelayInMilliseconds, nameof(doubleLeftClickMouseAtCoordinatedelayInMilliseconds), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseDragBetweenCoordinates(Expression<Func<int>> leftMouseDragBetweenCoordinatesstartXCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesstartYCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesendXCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesendYCoord, Expression<Func<string>> leftMouseDragBetweenCoordinatesworkflow, Expression<Func<int>> leftMouseDragBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> leftMouseDragBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            var __workflow_leftMouseDragBetweenCoordinatesstartXCoord = leftMouseDragBetweenCoordinatesstartXCoord == null ? null : WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesstartXCoord);
            WorkflowExpression.Validate(__workflow_leftMouseDragBetweenCoordinatesstartXCoord, nameof(leftMouseDragBetweenCoordinatesstartXCoord), required: true);
            var __workflow_leftMouseDragBetweenCoordinatesstartYCoord = leftMouseDragBetweenCoordinatesstartYCoord == null ? null : WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesstartYCoord);
            WorkflowExpression.Validate(__workflow_leftMouseDragBetweenCoordinatesstartYCoord, nameof(leftMouseDragBetweenCoordinatesstartYCoord), required: true);
            var __workflow_leftMouseDragBetweenCoordinatesendXCoord = leftMouseDragBetweenCoordinatesendXCoord == null ? null : WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesendXCoord);
            WorkflowExpression.Validate(__workflow_leftMouseDragBetweenCoordinatesendXCoord, nameof(leftMouseDragBetweenCoordinatesendXCoord), required: true);
            var __workflow_leftMouseDragBetweenCoordinatesendYCoord = leftMouseDragBetweenCoordinatesendYCoord == null ? null : WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesendYCoord);
            WorkflowExpression.Validate(__workflow_leftMouseDragBetweenCoordinatesendYCoord, nameof(leftMouseDragBetweenCoordinatesendYCoord), required: true);
            var __workflow_leftMouseDragBetweenCoordinatesworkflow = leftMouseDragBetweenCoordinatesworkflow == null ? null : WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesworkflow);
            WorkflowExpression.Validate(__workflow_leftMouseDragBetweenCoordinatesworkflow, nameof(leftMouseDragBetweenCoordinatesworkflow), required: true);
            var __workflow_leftMouseDragBetweenCoordinatesnumberOfSteps = leftMouseDragBetweenCoordinatesnumberOfSteps == null ? null : WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesnumberOfSteps);
            WorkflowExpression.Validate(__workflow_leftMouseDragBetweenCoordinatesnumberOfSteps, nameof(leftMouseDragBetweenCoordinatesnumberOfSteps), required: false);
            var __workflow_leftMouseDragBetweenCoordinatestotalTimeInSeconds = leftMouseDragBetweenCoordinatestotalTimeInSeconds == null ? null : WorkflowExpression.Compile(leftMouseDragBetweenCoordinatestotalTimeInSeconds);
            WorkflowExpression.Validate(__workflow_leftMouseDragBetweenCoordinatestotalTimeInSeconds, nameof(leftMouseDragBetweenCoordinatestotalTimeInSeconds), required: false);
            var __workflow_leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter = leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter == null ? null : WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter);
            WorkflowExpression.Validate(__workflow_leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter, nameof(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter), required: false);
            var __workflow_leftMouseDragBetweenCoordinatesmaximumEndPixelJitter = leftMouseDragBetweenCoordinatesmaximumEndPixelJitter == null ? null : WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesmaximumEndPixelJitter);
            WorkflowExpression.Validate(__workflow_leftMouseDragBetweenCoordinatesmaximumEndPixelJitter, nameof(leftMouseDragBetweenCoordinatesmaximumEndPixelJitter), required: false);
            var __workflow_leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta == null ? null : WorkflowExpression.Compile(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
            WorkflowExpression.Validate(__workflow_leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta, nameof(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseDragBetweenCoordinates(Expression<Func<int>> rightMouseDragBetweenCoordinatesstartXCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesstartYCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesendXCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesendYCoord, Expression<Func<string>> rightMouseDragBetweenCoordinatesworkflow, Expression<Func<int>> rightMouseDragBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> rightMouseDragBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            var __workflow_rightMouseDragBetweenCoordinatesstartXCoord = rightMouseDragBetweenCoordinatesstartXCoord == null ? null : WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesstartXCoord);
            WorkflowExpression.Validate(__workflow_rightMouseDragBetweenCoordinatesstartXCoord, nameof(rightMouseDragBetweenCoordinatesstartXCoord), required: true);
            var __workflow_rightMouseDragBetweenCoordinatesstartYCoord = rightMouseDragBetweenCoordinatesstartYCoord == null ? null : WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesstartYCoord);
            WorkflowExpression.Validate(__workflow_rightMouseDragBetweenCoordinatesstartYCoord, nameof(rightMouseDragBetweenCoordinatesstartYCoord), required: true);
            var __workflow_rightMouseDragBetweenCoordinatesendXCoord = rightMouseDragBetweenCoordinatesendXCoord == null ? null : WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesendXCoord);
            WorkflowExpression.Validate(__workflow_rightMouseDragBetweenCoordinatesendXCoord, nameof(rightMouseDragBetweenCoordinatesendXCoord), required: true);
            var __workflow_rightMouseDragBetweenCoordinatesendYCoord = rightMouseDragBetweenCoordinatesendYCoord == null ? null : WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesendYCoord);
            WorkflowExpression.Validate(__workflow_rightMouseDragBetweenCoordinatesendYCoord, nameof(rightMouseDragBetweenCoordinatesendYCoord), required: true);
            var __workflow_rightMouseDragBetweenCoordinatesworkflow = rightMouseDragBetweenCoordinatesworkflow == null ? null : WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesworkflow);
            WorkflowExpression.Validate(__workflow_rightMouseDragBetweenCoordinatesworkflow, nameof(rightMouseDragBetweenCoordinatesworkflow), required: true);
            var __workflow_rightMouseDragBetweenCoordinatesnumberOfSteps = rightMouseDragBetweenCoordinatesnumberOfSteps == null ? null : WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesnumberOfSteps);
            WorkflowExpression.Validate(__workflow_rightMouseDragBetweenCoordinatesnumberOfSteps, nameof(rightMouseDragBetweenCoordinatesnumberOfSteps), required: false);
            var __workflow_rightMouseDragBetweenCoordinatestotalTimeInSeconds = rightMouseDragBetweenCoordinatestotalTimeInSeconds == null ? null : WorkflowExpression.Compile(rightMouseDragBetweenCoordinatestotalTimeInSeconds);
            WorkflowExpression.Validate(__workflow_rightMouseDragBetweenCoordinatestotalTimeInSeconds, nameof(rightMouseDragBetweenCoordinatestotalTimeInSeconds), required: false);
            var __workflow_rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter = rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter == null ? null : WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter);
            WorkflowExpression.Validate(__workflow_rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter, nameof(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter), required: false);
            var __workflow_rightMouseDragBetweenCoordinatesmaximumEndPixelJitter = rightMouseDragBetweenCoordinatesmaximumEndPixelJitter == null ? null : WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesmaximumEndPixelJitter);
            WorkflowExpression.Validate(__workflow_rightMouseDragBetweenCoordinatesmaximumEndPixelJitter, nameof(rightMouseDragBetweenCoordinatesmaximumEndPixelJitter), required: false);
            var __workflow_rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta == null ? null : WorkflowExpression.Compile(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
            WorkflowExpression.Validate(__workflow_rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta, nameof(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseDragBetweenCoordinates(Expression<Func<int>> middleMouseDragBetweenCoordinatesstartXCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesstartYCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesendXCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesendYCoord, Expression<Func<string>> middleMouseDragBetweenCoordinatesworkflow, Expression<Func<int>> middleMouseDragBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> middleMouseDragBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            var __workflow_middleMouseDragBetweenCoordinatesstartXCoord = middleMouseDragBetweenCoordinatesstartXCoord == null ? null : WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesstartXCoord);
            WorkflowExpression.Validate(__workflow_middleMouseDragBetweenCoordinatesstartXCoord, nameof(middleMouseDragBetweenCoordinatesstartXCoord), required: true);
            var __workflow_middleMouseDragBetweenCoordinatesstartYCoord = middleMouseDragBetweenCoordinatesstartYCoord == null ? null : WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesstartYCoord);
            WorkflowExpression.Validate(__workflow_middleMouseDragBetweenCoordinatesstartYCoord, nameof(middleMouseDragBetweenCoordinatesstartYCoord), required: true);
            var __workflow_middleMouseDragBetweenCoordinatesendXCoord = middleMouseDragBetweenCoordinatesendXCoord == null ? null : WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesendXCoord);
            WorkflowExpression.Validate(__workflow_middleMouseDragBetweenCoordinatesendXCoord, nameof(middleMouseDragBetweenCoordinatesendXCoord), required: true);
            var __workflow_middleMouseDragBetweenCoordinatesendYCoord = middleMouseDragBetweenCoordinatesendYCoord == null ? null : WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesendYCoord);
            WorkflowExpression.Validate(__workflow_middleMouseDragBetweenCoordinatesendYCoord, nameof(middleMouseDragBetweenCoordinatesendYCoord), required: true);
            var __workflow_middleMouseDragBetweenCoordinatesworkflow = middleMouseDragBetweenCoordinatesworkflow == null ? null : WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesworkflow);
            WorkflowExpression.Validate(__workflow_middleMouseDragBetweenCoordinatesworkflow, nameof(middleMouseDragBetweenCoordinatesworkflow), required: true);
            var __workflow_middleMouseDragBetweenCoordinatesnumberOfSteps = middleMouseDragBetweenCoordinatesnumberOfSteps == null ? null : WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesnumberOfSteps);
            WorkflowExpression.Validate(__workflow_middleMouseDragBetweenCoordinatesnumberOfSteps, nameof(middleMouseDragBetweenCoordinatesnumberOfSteps), required: false);
            var __workflow_middleMouseDragBetweenCoordinatestotalTimeInSeconds = middleMouseDragBetweenCoordinatestotalTimeInSeconds == null ? null : WorkflowExpression.Compile(middleMouseDragBetweenCoordinatestotalTimeInSeconds);
            WorkflowExpression.Validate(__workflow_middleMouseDragBetweenCoordinatestotalTimeInSeconds, nameof(middleMouseDragBetweenCoordinatestotalTimeInSeconds), required: false);
            var __workflow_middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter = middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter == null ? null : WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter);
            WorkflowExpression.Validate(__workflow_middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter, nameof(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter), required: false);
            var __workflow_middleMouseDragBetweenCoordinatesmaximumEndPixelJitter = middleMouseDragBetweenCoordinatesmaximumEndPixelJitter == null ? null : WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesmaximumEndPixelJitter);
            WorkflowExpression.Validate(__workflow_middleMouseDragBetweenCoordinatesmaximumEndPixelJitter, nameof(middleMouseDragBetweenCoordinatesmaximumEndPixelJitter), required: false);
            var __workflow_middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta == null ? null : WorkflowExpression.Compile(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
            WorkflowExpression.Validate(__workflow_middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta, nameof(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseBetweenCoordinates(Expression<Func<int>> moveMouseBetweenCoordinatesstartXCoord, Expression<Func<int>> moveMouseBetweenCoordinatesstartYCoord, Expression<Func<int>> moveMouseBetweenCoordinatesendXCoord, Expression<Func<int>> moveMouseBetweenCoordinatesendYCoord, Expression<Func<string>> moveMouseBetweenCoordinatesworkflow, Expression<Func<int>> moveMouseBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> moveMouseBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> moveMouseBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> moveMouseBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            var __workflow_moveMouseBetweenCoordinatesstartXCoord = moveMouseBetweenCoordinatesstartXCoord == null ? null : WorkflowExpression.Compile(moveMouseBetweenCoordinatesstartXCoord);
            WorkflowExpression.Validate(__workflow_moveMouseBetweenCoordinatesstartXCoord, nameof(moveMouseBetweenCoordinatesstartXCoord), required: true);
            var __workflow_moveMouseBetweenCoordinatesstartYCoord = moveMouseBetweenCoordinatesstartYCoord == null ? null : WorkflowExpression.Compile(moveMouseBetweenCoordinatesstartYCoord);
            WorkflowExpression.Validate(__workflow_moveMouseBetweenCoordinatesstartYCoord, nameof(moveMouseBetweenCoordinatesstartYCoord), required: true);
            var __workflow_moveMouseBetweenCoordinatesendXCoord = moveMouseBetweenCoordinatesendXCoord == null ? null : WorkflowExpression.Compile(moveMouseBetweenCoordinatesendXCoord);
            WorkflowExpression.Validate(__workflow_moveMouseBetweenCoordinatesendXCoord, nameof(moveMouseBetweenCoordinatesendXCoord), required: true);
            var __workflow_moveMouseBetweenCoordinatesendYCoord = moveMouseBetweenCoordinatesendYCoord == null ? null : WorkflowExpression.Compile(moveMouseBetweenCoordinatesendYCoord);
            WorkflowExpression.Validate(__workflow_moveMouseBetweenCoordinatesendYCoord, nameof(moveMouseBetweenCoordinatesendYCoord), required: true);
            var __workflow_moveMouseBetweenCoordinatesworkflow = moveMouseBetweenCoordinatesworkflow == null ? null : WorkflowExpression.Compile(moveMouseBetweenCoordinatesworkflow);
            WorkflowExpression.Validate(__workflow_moveMouseBetweenCoordinatesworkflow, nameof(moveMouseBetweenCoordinatesworkflow), required: true);
            var __workflow_moveMouseBetweenCoordinatesnumberOfSteps = moveMouseBetweenCoordinatesnumberOfSteps == null ? null : WorkflowExpression.Compile(moveMouseBetweenCoordinatesnumberOfSteps);
            WorkflowExpression.Validate(__workflow_moveMouseBetweenCoordinatesnumberOfSteps, nameof(moveMouseBetweenCoordinatesnumberOfSteps), required: false);
            var __workflow_moveMouseBetweenCoordinatestotalTimeInSeconds = moveMouseBetweenCoordinatestotalTimeInSeconds == null ? null : WorkflowExpression.Compile(moveMouseBetweenCoordinatestotalTimeInSeconds);
            WorkflowExpression.Validate(__workflow_moveMouseBetweenCoordinatestotalTimeInSeconds, nameof(moveMouseBetweenCoordinatestotalTimeInSeconds), required: false);
            var __workflow_moveMouseBetweenCoordinatesmaximumMovementPixelJitter = moveMouseBetweenCoordinatesmaximumMovementPixelJitter == null ? null : WorkflowExpression.Compile(moveMouseBetweenCoordinatesmaximumMovementPixelJitter);
            WorkflowExpression.Validate(__workflow_moveMouseBetweenCoordinatesmaximumMovementPixelJitter, nameof(moveMouseBetweenCoordinatesmaximumMovementPixelJitter), required: false);
            var __workflow_moveMouseBetweenCoordinatesmaximumEndPixelJitter = moveMouseBetweenCoordinatesmaximumEndPixelJitter == null ? null : WorkflowExpression.Compile(moveMouseBetweenCoordinatesmaximumEndPixelJitter);
            WorkflowExpression.Validate(__workflow_moveMouseBetweenCoordinatesmaximumEndPixelJitter, nameof(moveMouseBetweenCoordinatesmaximumEndPixelJitter), required: false);
            var __workflow_moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta = moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta == null ? null : WorkflowExpression.Compile(moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta);
            WorkflowExpression.Validate(__workflow_moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta, nameof(moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction TurnMouseWheel(Expression<Func<int>> turnMouseWheelwheelTurns, Expression<Func<string>> turnMouseWheelworkflow)
        {
            var __workflow_turnMouseWheelwheelTurns = turnMouseWheelwheelTurns == null ? null : WorkflowExpression.Compile(turnMouseWheelwheelTurns);
            WorkflowExpression.Validate(__workflow_turnMouseWheelwheelTurns, nameof(turnMouseWheelwheelTurns), required: true);
            var __workflow_turnMouseWheelworkflow = turnMouseWheelworkflow == null ? null : WorkflowExpression.Compile(turnMouseWheelworkflow);
            WorkflowExpression.Validate(__workflow_turnMouseWheelworkflow, nameof(turnMouseWheelworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetCursorPos(Expression<Func<int>> setCursorPosx, Expression<Func<int>> setCursorPosy, Expression<Func<string>> setCursorPosworkflow)
        {
            var __workflow_setCursorPosx = setCursorPosx == null ? null : WorkflowExpression.Compile(setCursorPosx);
            WorkflowExpression.Validate(__workflow_setCursorPosx, nameof(setCursorPosx), required: true);
            var __workflow_setCursorPosy = setCursorPosy == null ? null : WorkflowExpression.Compile(setCursorPosy);
            WorkflowExpression.Validate(__workflow_setCursorPosy, nameof(setCursorPosy), required: true);
            var __workflow_setCursorPosworkflow = setCursorPosworkflow == null ? null : WorkflowExpression.Compile(setCursorPosworkflow);
            WorkflowExpression.Validate(__workflow_setCursorPosworkflow, nameof(setCursorPosworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetCursorPosResponse> GetCursorPos(Expression<Func<string>> getCursorPosworkflow)
        {
            var __workflow_getCursorPosworkflow = getCursorPosworkflow == null ? null : WorkflowExpression.Compile(getCursorPosworkflow);
            WorkflowExpression.Validate(__workflow_getCursorPosworkflow, nameof(getCursorPosworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CalibrateMouseEventResponse> CalibrateMouseEvent(Expression<Func<string>> calibrateMouseEventworkflow, Expression<Func<int>> calibrateMouseEventcalibrationSizeInPixels = null)
        {
            var __workflow_calibrateMouseEventworkflow = calibrateMouseEventworkflow == null ? null : WorkflowExpression.Compile(calibrateMouseEventworkflow);
            WorkflowExpression.Validate(__workflow_calibrateMouseEventworkflow, nameof(calibrateMouseEventworkflow), required: true);
            var __workflow_calibrateMouseEventcalibrationSizeInPixels = calibrateMouseEventcalibrationSizeInPixels == null ? null : WorkflowExpression.Compile(calibrateMouseEventcalibrationSizeInPixels);
            WorkflowExpression.Validate(__workflow_calibrateMouseEventcalibrationSizeInPixels, nameof(calibrateMouseEventcalibrationSizeInPixels), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMouseMoveMethodResponse> GetMouseMoveMethod(Expression<Func<string>> getMouseMoveMethodworkflow)
        {
            var __workflow_getMouseMoveMethodworkflow = getMouseMoveMethodworkflow == null ? null : WorkflowExpression.Compile(getMouseMoveMethodworkflow);
            WorkflowExpression.Validate(__workflow_getMouseMoveMethodworkflow, nameof(getMouseMoveMethodworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetMouseMoveMethod(Expression<Func<setMouseMoveMethodmouseMoveMethodInput>> setMouseMoveMethodmouseMoveMethod, Expression<Func<string>> setMouseMoveMethodworkflow)
        {
            var __workflow_setMouseMoveMethodmouseMoveMethod = setMouseMoveMethodmouseMoveMethod == null ? null : WorkflowExpression.Compile(setMouseMoveMethodmouseMoveMethod);
            WorkflowExpression.Validate(__workflow_setMouseMoveMethodmouseMoveMethod, nameof(setMouseMoveMethodmouseMoveMethod), required: true);
            var __workflow_setMouseMoveMethodworkflow = setMouseMoveMethodworkflow == null ? null : WorkflowExpression.Compile(setMouseMoveMethodworkflow);
            WorkflowExpression.Validate(__workflow_setMouseMoveMethodworkflow, nameof(setMouseMoveMethodworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WiggleMouse(Expression<Func<string>> wiggleMouseworkflow, Expression<Func<int>> wiggleMousexWiggle = null, Expression<Func<int>> wiggleMouseyWiggle = null, Expression<Func<double>> wiggleMousewiggleDelayInSeconds = null)
        {
            var __workflow_wiggleMouseworkflow = wiggleMouseworkflow == null ? null : WorkflowExpression.Compile(wiggleMouseworkflow);
            WorkflowExpression.Validate(__workflow_wiggleMouseworkflow, nameof(wiggleMouseworkflow), required: true);
            var __workflow_wiggleMousexWiggle = wiggleMousexWiggle == null ? null : WorkflowExpression.Compile(wiggleMousexWiggle);
            WorkflowExpression.Validate(__workflow_wiggleMousexWiggle, nameof(wiggleMousexWiggle), required: false);
            var __workflow_wiggleMouseyWiggle = wiggleMouseyWiggle == null ? null : WorkflowExpression.Compile(wiggleMouseyWiggle);
            WorkflowExpression.Validate(__workflow_wiggleMouseyWiggle, nameof(wiggleMouseyWiggle), required: false);
            var __workflow_wiggleMousewiggleDelayInSeconds = wiggleMousewiggleDelayInSeconds == null ? null : WorkflowExpression.Compile(wiggleMousewiggleDelayInSeconds);
            WorkflowExpression.Validate(__workflow_wiggleMousewiggleDelayInSeconds, nameof(wiggleMousewiggleDelayInSeconds), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendKeyEvents(Expression<Func<string>> sendKeyEventstext, Expression<Func<string>> sendKeyEventsworkflow, Expression<Func<int>> sendKeyEventsinterval = null, Expression<Func<bool>> sendKeyEventsisPassword = null, Expression<Func<bool>> sendKeyEventsdontInterpretSymbols = null)
        {
            var __workflow_sendKeyEventstext = sendKeyEventstext == null ? null : WorkflowExpression.Compile(sendKeyEventstext);
            WorkflowExpression.Validate(__workflow_sendKeyEventstext, nameof(sendKeyEventstext), required: true);
            var __workflow_sendKeyEventsworkflow = sendKeyEventsworkflow == null ? null : WorkflowExpression.Compile(sendKeyEventsworkflow);
            WorkflowExpression.Validate(__workflow_sendKeyEventsworkflow, nameof(sendKeyEventsworkflow), required: true);
            var __workflow_sendKeyEventsinterval = sendKeyEventsinterval == null ? null : WorkflowExpression.Compile(sendKeyEventsinterval);
            WorkflowExpression.Validate(__workflow_sendKeyEventsinterval, nameof(sendKeyEventsinterval), required: false);
            var __workflow_sendKeyEventsisPassword = sendKeyEventsisPassword == null ? null : WorkflowExpression.Compile(sendKeyEventsisPassword);
            WorkflowExpression.Validate(__workflow_sendKeyEventsisPassword, nameof(sendKeyEventsisPassword), required: false);
            var __workflow_sendKeyEventsdontInterpretSymbols = sendKeyEventsdontInterpretSymbols == null ? null : WorkflowExpression.Compile(sendKeyEventsdontInterpretSymbols);
            WorkflowExpression.Validate(__workflow_sendKeyEventsdontInterpretSymbols, nameof(sendKeyEventsdontInterpretSymbols), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendPasswordKeyEvents(Expression<Func<string>> sendPasswordKeyEventspassword, Expression<Func<string>> sendPasswordKeyEventsworkflow, Expression<Func<int>> sendPasswordKeyEventsinterval = null, Expression<Func<bool>> sendPasswordKeyEventsdontInterpretSymbols = null, Expression<Func<bool>> sendPasswordKeyEventspasswordContainsStoredPassword = null)
        {
            var __workflow_sendPasswordKeyEventspassword = sendPasswordKeyEventspassword == null ? null : WorkflowExpression.Compile(sendPasswordKeyEventspassword);
            WorkflowExpression.Validate(__workflow_sendPasswordKeyEventspassword, nameof(sendPasswordKeyEventspassword), required: true);
            var __workflow_sendPasswordKeyEventsworkflow = sendPasswordKeyEventsworkflow == null ? null : WorkflowExpression.Compile(sendPasswordKeyEventsworkflow);
            WorkflowExpression.Validate(__workflow_sendPasswordKeyEventsworkflow, nameof(sendPasswordKeyEventsworkflow), required: true);
            var __workflow_sendPasswordKeyEventsinterval = sendPasswordKeyEventsinterval == null ? null : WorkflowExpression.Compile(sendPasswordKeyEventsinterval);
            WorkflowExpression.Validate(__workflow_sendPasswordKeyEventsinterval, nameof(sendPasswordKeyEventsinterval), required: false);
            var __workflow_sendPasswordKeyEventsdontInterpretSymbols = sendPasswordKeyEventsdontInterpretSymbols == null ? null : WorkflowExpression.Compile(sendPasswordKeyEventsdontInterpretSymbols);
            WorkflowExpression.Validate(__workflow_sendPasswordKeyEventsdontInterpretSymbols, nameof(sendPasswordKeyEventsdontInterpretSymbols), required: false);
            var __workflow_sendPasswordKeyEventspasswordContainsStoredPassword = sendPasswordKeyEventspasswordContainsStoredPassword == null ? null : WorkflowExpression.Compile(sendPasswordKeyEventspasswordContainsStoredPassword);
            WorkflowExpression.Validate(__workflow_sendPasswordKeyEventspasswordContainsStoredPassword, nameof(sendPasswordKeyEventspasswordContainsStoredPassword), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendKeys(Expression<Func<string>> sendKeystext, Expression<Func<string>> sendKeysworkflow, Expression<Func<int>> sendKeysinterval = null, Expression<Func<bool>> sendKeysisPassword = null, Expression<Func<bool>> sendKeysdontInterpretSymbols = null)
        {
            var __workflow_sendKeystext = sendKeystext == null ? null : WorkflowExpression.Compile(sendKeystext);
            WorkflowExpression.Validate(__workflow_sendKeystext, nameof(sendKeystext), required: true);
            var __workflow_sendKeysworkflow = sendKeysworkflow == null ? null : WorkflowExpression.Compile(sendKeysworkflow);
            WorkflowExpression.Validate(__workflow_sendKeysworkflow, nameof(sendKeysworkflow), required: true);
            var __workflow_sendKeysinterval = sendKeysinterval == null ? null : WorkflowExpression.Compile(sendKeysinterval);
            WorkflowExpression.Validate(__workflow_sendKeysinterval, nameof(sendKeysinterval), required: false);
            var __workflow_sendKeysisPassword = sendKeysisPassword == null ? null : WorkflowExpression.Compile(sendKeysisPassword);
            WorkflowExpression.Validate(__workflow_sendKeysisPassword, nameof(sendKeysisPassword), required: false);
            var __workflow_sendKeysdontInterpretSymbols = sendKeysdontInterpretSymbols == null ? null : WorkflowExpression.Compile(sendKeysdontInterpretSymbols);
            WorkflowExpression.Validate(__workflow_sendKeysdontInterpretSymbols, nameof(sendKeysdontInterpretSymbols), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendPasswordKeys(Expression<Func<string>> sendPasswordKeyspassword, Expression<Func<string>> sendPasswordKeysworkflow, Expression<Func<int>> sendPasswordKeysinterval = null, Expression<Func<bool>> sendPasswordKeysdontInterpretSymbols = null, Expression<Func<bool>> sendPasswordKeyspasswordContainsStoredPassword = null)
        {
            var __workflow_sendPasswordKeyspassword = sendPasswordKeyspassword == null ? null : WorkflowExpression.Compile(sendPasswordKeyspassword);
            WorkflowExpression.Validate(__workflow_sendPasswordKeyspassword, nameof(sendPasswordKeyspassword), required: true);
            var __workflow_sendPasswordKeysworkflow = sendPasswordKeysworkflow == null ? null : WorkflowExpression.Compile(sendPasswordKeysworkflow);
            WorkflowExpression.Validate(__workflow_sendPasswordKeysworkflow, nameof(sendPasswordKeysworkflow), required: true);
            var __workflow_sendPasswordKeysinterval = sendPasswordKeysinterval == null ? null : WorkflowExpression.Compile(sendPasswordKeysinterval);
            WorkflowExpression.Validate(__workflow_sendPasswordKeysinterval, nameof(sendPasswordKeysinterval), required: false);
            var __workflow_sendPasswordKeysdontInterpretSymbols = sendPasswordKeysdontInterpretSymbols == null ? null : WorkflowExpression.Compile(sendPasswordKeysdontInterpretSymbols);
            WorkflowExpression.Validate(__workflow_sendPasswordKeysdontInterpretSymbols, nameof(sendPasswordKeysdontInterpretSymbols), required: false);
            var __workflow_sendPasswordKeyspasswordContainsStoredPassword = sendPasswordKeyspasswordContainsStoredPassword == null ? null : WorkflowExpression.Compile(sendPasswordKeyspasswordContainsStoredPassword);
            WorkflowExpression.Validate(__workflow_sendPasswordKeyspasswordContainsStoredPassword, nameof(sendPasswordKeyspasswordContainsStoredPassword), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ClearClipboard(Expression<Func<string>> clearClipboardworkflow)
        {
            var __workflow_clearClipboardworkflow = clearClipboardworkflow == null ? null : WorkflowExpression.Compile(clearClipboardworkflow);
            WorkflowExpression.Validate(__workflow_clearClipboardworkflow, nameof(clearClipboardworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetClipboardData(Expression<Func<string>> setClipboardDataworkflow, Expression<Func<string>> setClipboardDatanewClipboardData = null)
        {
            var __workflow_setClipboardDataworkflow = setClipboardDataworkflow == null ? null : WorkflowExpression.Compile(setClipboardDataworkflow);
            WorkflowExpression.Validate(__workflow_setClipboardDataworkflow, nameof(setClipboardDataworkflow), required: true);
            var __workflow_setClipboardDatanewClipboardData = setClipboardDatanewClipboardData == null ? null : WorkflowExpression.Compile(setClipboardDatanewClipboardData);
            WorkflowExpression.Validate(__workflow_setClipboardDatanewClipboardData, nameof(setClipboardDatanewClipboardData), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetClipboardDataResponse> GetClipboardData(Expression<Func<string>> getClipboardDataworkflow)
        {
            var __workflow_getClipboardDataworkflow = getClipboardDataworkflow == null ? null : WorkflowExpression.Compile(getClipboardDataworkflow);
            WorkflowExpression.Validate(__workflow_getClipboardDataworkflow, nameof(getClipboardDataworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TakeScreenshotResponse> TakeScreenshot(Expression<Func<string>> takeScreenshotworkflow, Expression<Func<bool>> takeScreenshotfullscreen = null, Expression<Func<int>> takeScreenshotleftXPixels = null, Expression<Func<int>> takeScreenshottopYPixels = null, Expression<Func<int>> takeScreenshotwidthPixels = null, Expression<Func<int>> takeScreenshotheightPixels = null, Expression<Func<takeScreenshotimageFormatInput>> takeScreenshotimageFormat = null, Expression<Func<bool>> takeScreenshotuseDisplayDevice = null, Expression<Func<bool>> takeScreenshotraiseExceptionOnError = null, Expression<Func<bool>> takeScreenshothideAgent = null, Expression<Func<bool>> takeScreenshotusePhysicalCoordinates = null, Expression<Func<int>> takeScreenshotdisplayDeviceId = null)
        {
            var __workflow_takeScreenshotworkflow = takeScreenshotworkflow == null ? null : WorkflowExpression.Compile(takeScreenshotworkflow);
            WorkflowExpression.Validate(__workflow_takeScreenshotworkflow, nameof(takeScreenshotworkflow), required: true);
            var __workflow_takeScreenshotfullscreen = takeScreenshotfullscreen == null ? null : WorkflowExpression.Compile(takeScreenshotfullscreen);
            WorkflowExpression.Validate(__workflow_takeScreenshotfullscreen, nameof(takeScreenshotfullscreen), required: false);
            var __workflow_takeScreenshotleftXPixels = takeScreenshotleftXPixels == null ? null : WorkflowExpression.Compile(takeScreenshotleftXPixels);
            WorkflowExpression.Validate(__workflow_takeScreenshotleftXPixels, nameof(takeScreenshotleftXPixels), required: false);
            var __workflow_takeScreenshottopYPixels = takeScreenshottopYPixels == null ? null : WorkflowExpression.Compile(takeScreenshottopYPixels);
            WorkflowExpression.Validate(__workflow_takeScreenshottopYPixels, nameof(takeScreenshottopYPixels), required: false);
            var __workflow_takeScreenshotwidthPixels = takeScreenshotwidthPixels == null ? null : WorkflowExpression.Compile(takeScreenshotwidthPixels);
            WorkflowExpression.Validate(__workflow_takeScreenshotwidthPixels, nameof(takeScreenshotwidthPixels), required: false);
            var __workflow_takeScreenshotheightPixels = takeScreenshotheightPixels == null ? null : WorkflowExpression.Compile(takeScreenshotheightPixels);
            WorkflowExpression.Validate(__workflow_takeScreenshotheightPixels, nameof(takeScreenshotheightPixels), required: false);
            var __workflow_takeScreenshotimageFormat = takeScreenshotimageFormat == null ? null : WorkflowExpression.Compile(takeScreenshotimageFormat);
            WorkflowExpression.Validate(__workflow_takeScreenshotimageFormat, nameof(takeScreenshotimageFormat), required: false);
            var __workflow_takeScreenshotuseDisplayDevice = takeScreenshotuseDisplayDevice == null ? null : WorkflowExpression.Compile(takeScreenshotuseDisplayDevice);
            WorkflowExpression.Validate(__workflow_takeScreenshotuseDisplayDevice, nameof(takeScreenshotuseDisplayDevice), required: false);
            var __workflow_takeScreenshotraiseExceptionOnError = takeScreenshotraiseExceptionOnError == null ? null : WorkflowExpression.Compile(takeScreenshotraiseExceptionOnError);
            WorkflowExpression.Validate(__workflow_takeScreenshotraiseExceptionOnError, nameof(takeScreenshotraiseExceptionOnError), required: false);
            var __workflow_takeScreenshothideAgent = takeScreenshothideAgent == null ? null : WorkflowExpression.Compile(takeScreenshothideAgent);
            WorkflowExpression.Validate(__workflow_takeScreenshothideAgent, nameof(takeScreenshothideAgent), required: false);
            var __workflow_takeScreenshotusePhysicalCoordinates = takeScreenshotusePhysicalCoordinates == null ? null : WorkflowExpression.Compile(takeScreenshotusePhysicalCoordinates);
            WorkflowExpression.Validate(__workflow_takeScreenshotusePhysicalCoordinates, nameof(takeScreenshotusePhysicalCoordinates), required: false);
            var __workflow_takeScreenshotdisplayDeviceId = takeScreenshotdisplayDeviceId == null ? null : WorkflowExpression.Compile(takeScreenshotdisplayDeviceId);
            WorkflowExpression.Validate(__workflow_takeScreenshotdisplayDeviceId, nameof(takeScreenshotdisplayDeviceId), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetEnvironmentInfoResponse> GetEnvironmentInfo(Expression<Func<string>> getEnvironmentInfoworkflow)
        {
            var __workflow_getEnvironmentInfoworkflow = getEnvironmentInfoworkflow == null ? null : WorkflowExpression.Compile(getEnvironmentInfoworkflow);
            WorkflowExpression.Validate(__workflow_getEnvironmentInfoworkflow, nameof(getEnvironmentInfoworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsScreenReaderEnabledResponse> IsScreenReaderEnabled(Expression<Func<string>> isScreenReaderEnabledworkflow)
        {
            var __workflow_isScreenReaderEnabledworkflow = isScreenReaderEnabledworkflow == null ? null : WorkflowExpression.Compile(isScreenReaderEnabledworkflow);
            WorkflowExpression.Validate(__workflow_isScreenReaderEnabledworkflow, nameof(isScreenReaderEnabledworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetScreenReader(Expression<Func<string>> setScreenReaderworkflow, Expression<Func<bool>> setScreenReaderenableScreenReader = null)
        {
            var __workflow_setScreenReaderworkflow = setScreenReaderworkflow == null ? null : WorkflowExpression.Compile(setScreenReaderworkflow);
            WorkflowExpression.Validate(__workflow_setScreenReaderworkflow, nameof(setScreenReaderworkflow), required: true);
            var __workflow_setScreenReaderenableScreenReader = setScreenReaderenableScreenReader == null ? null : WorkflowExpression.Compile(setScreenReaderenableScreenReader);
            WorkflowExpression.Validate(__workflow_setScreenReaderenableScreenReader, nameof(setScreenReaderenableScreenReader), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetParentProcessIdResponse> GetParentProcessId(Expression<Func<int>> getParentProcessIdprocessId, Expression<Func<string>> getParentProcessIdworkflow)
        {
            var __workflow_getParentProcessIdprocessId = getParentProcessIdprocessId == null ? null : WorkflowExpression.Compile(getParentProcessIdprocessId);
            WorkflowExpression.Validate(__workflow_getParentProcessIdprocessId, nameof(getParentProcessIdprocessId), required: true);
            var __workflow_getParentProcessIdworkflow = getParentProcessIdworkflow == null ? null : WorkflowExpression.Compile(getParentProcessIdworkflow);
            WorkflowExpression.Validate(__workflow_getParentProcessIdworkflow, nameof(getParentProcessIdworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessIdCommandLineResponse> GetProcessIdCommandLine(Expression<Func<int>> getProcessIdCommandLineprocessId, Expression<Func<string>> getProcessIdCommandLineworkflow)
        {
            var __workflow_getProcessIdCommandLineprocessId = getProcessIdCommandLineprocessId == null ? null : WorkflowExpression.Compile(getProcessIdCommandLineprocessId);
            WorkflowExpression.Validate(__workflow_getProcessIdCommandLineprocessId, nameof(getProcessIdCommandLineprocessId), required: true);
            var __workflow_getProcessIdCommandLineworkflow = getProcessIdCommandLineworkflow == null ? null : WorkflowExpression.Compile(getProcessIdCommandLineworkflow);
            WorkflowExpression.Validate(__workflow_getProcessIdCommandLineworkflow, nameof(getProcessIdCommandLineworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLastInputInfoResponse> GetLastInputInfo(Expression<Func<string>> getLastInputInfoworkflow)
        {
            var __workflow_getLastInputInfoworkflow = getLastInputInfoworkflow == null ? null : WorkflowExpression.Compile(getLastInputInfoworkflow);
            WorkflowExpression.Validate(__workflow_getLastInputInfoworkflow, nameof(getLastInputInfoworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KeepSessionAliveResponse> KeepSessionAlive(Expression<Func<string>> keepSessionAliveworkflow, Expression<Func<int>> keepSessionAlivexWiggle = null, Expression<Func<int>> keepSessionAliveyWiggle = null, Expression<Func<double>> keepSessionAlivewiggleDelayInSeconds = null, Expression<Func<int>> keepSessionAliveidleThresholdInSeconds = null, Expression<Func<int>> keepSessionAliveidleCheckPeriodInSeconds = null, Expression<Func<int>> keepSessionAlivetotalKeepaliveRuntimeInSeconds = null)
        {
            var __workflow_keepSessionAliveworkflow = keepSessionAliveworkflow == null ? null : WorkflowExpression.Compile(keepSessionAliveworkflow);
            WorkflowExpression.Validate(__workflow_keepSessionAliveworkflow, nameof(keepSessionAliveworkflow), required: true);
            var __workflow_keepSessionAlivexWiggle = keepSessionAlivexWiggle == null ? null : WorkflowExpression.Compile(keepSessionAlivexWiggle);
            WorkflowExpression.Validate(__workflow_keepSessionAlivexWiggle, nameof(keepSessionAlivexWiggle), required: false);
            var __workflow_keepSessionAliveyWiggle = keepSessionAliveyWiggle == null ? null : WorkflowExpression.Compile(keepSessionAliveyWiggle);
            WorkflowExpression.Validate(__workflow_keepSessionAliveyWiggle, nameof(keepSessionAliveyWiggle), required: false);
            var __workflow_keepSessionAlivewiggleDelayInSeconds = keepSessionAlivewiggleDelayInSeconds == null ? null : WorkflowExpression.Compile(keepSessionAlivewiggleDelayInSeconds);
            WorkflowExpression.Validate(__workflow_keepSessionAlivewiggleDelayInSeconds, nameof(keepSessionAlivewiggleDelayInSeconds), required: false);
            var __workflow_keepSessionAliveidleThresholdInSeconds = keepSessionAliveidleThresholdInSeconds == null ? null : WorkflowExpression.Compile(keepSessionAliveidleThresholdInSeconds);
            WorkflowExpression.Validate(__workflow_keepSessionAliveidleThresholdInSeconds, nameof(keepSessionAliveidleThresholdInSeconds), required: false);
            var __workflow_keepSessionAliveidleCheckPeriodInSeconds = keepSessionAliveidleCheckPeriodInSeconds == null ? null : WorkflowExpression.Compile(keepSessionAliveidleCheckPeriodInSeconds);
            WorkflowExpression.Validate(__workflow_keepSessionAliveidleCheckPeriodInSeconds, nameof(keepSessionAliveidleCheckPeriodInSeconds), required: false);
            var __workflow_keepSessionAlivetotalKeepaliveRuntimeInSeconds = keepSessionAlivetotalKeepaliveRuntimeInSeconds == null ? null : WorkflowExpression.Compile(keepSessionAlivetotalKeepaliveRuntimeInSeconds);
            WorkflowExpression.Validate(__workflow_keepSessionAlivetotalKeepaliveRuntimeInSeconds, nameof(keepSessionAlivetotalKeepaliveRuntimeInSeconds), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<StopKeepSessionAliveResponse> StopKeepSessionAlive(Expression<Func<string>> stopKeepSessionAliveworkflow)
        {
            var __workflow_stopKeepSessionAliveworkflow = stopKeepSessionAliveworkflow == null ? null : WorkflowExpression.Compile(stopKeepSessionAliveworkflow);
            WorkflowExpression.Validate(__workflow_stopKeepSessionAliveworkflow, nameof(stopKeepSessionAliveworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CopyFileToClipboardResponse> CopyFileToClipboard(Expression<Func<string>> copyFileToClipboardfilepath, Expression<Func<string>> copyFileToClipboardworkflow, Expression<Func<bool>> copyFileToClipboardcut = null)
        {
            var __workflow_copyFileToClipboardfilepath = copyFileToClipboardfilepath == null ? null : WorkflowExpression.Compile(copyFileToClipboardfilepath);
            WorkflowExpression.Validate(__workflow_copyFileToClipboardfilepath, nameof(copyFileToClipboardfilepath), required: true);
            var __workflow_copyFileToClipboardworkflow = copyFileToClipboardworkflow == null ? null : WorkflowExpression.Compile(copyFileToClipboardworkflow);
            WorkflowExpression.Validate(__workflow_copyFileToClipboardworkflow, nameof(copyFileToClipboardworkflow), required: true);
            var __workflow_copyFileToClipboardcut = copyFileToClipboardcut == null ? null : WorkflowExpression.Compile(copyFileToClipboardcut);
            WorkflowExpression.Validate(__workflow_copyFileToClipboardcut, nameof(copyFileToClipboardcut), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteSessionInfoResponse> GetRemoteSessionInfo(Expression<Func<string>> getRemoteSessionInfoworkflow)
        {
            var __workflow_getRemoteSessionInfoworkflow = getRemoteSessionInfoworkflow == null ? null : WorkflowExpression.Compile(getRemoteSessionInfoworkflow);
            WorkflowExpression.Validate(__workflow_getRemoteSessionInfoworkflow, nameof(getRemoteSessionInfoworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GeneratePasswordResponse> GeneratePassword(Expression<Func<string>> generatePasswordpasswordFormat, Expression<Func<string>> generatePasswordworkflow, Expression<Func<int>> generatePasswordminimumLength = null, Expression<Func<bool>> generatePasswordreturnAsPlainText = null, Expression<Func<string>> generatePasswordstorePasswordAsIdentifier = null, Expression<Func<string>> generatePasswordsupportedSymbols = null, Expression<Func<bool>> generatePasswordattemptUniquePasswords = null, Expression<Func<generatePasswordgenerateAtInput>> generatePasswordgenerateAt = null, Expression<Func<int>> generatePasswordminimumLowercase = null, Expression<Func<int>> generatePasswordminimumUppercase = null, Expression<Func<int>> generatePasswordminimumNumbers = null, Expression<Func<int>> generatePasswordminimumSymbols = null)
        {
            var __workflow_generatePasswordpasswordFormat = generatePasswordpasswordFormat == null ? null : WorkflowExpression.Compile(generatePasswordpasswordFormat);
            WorkflowExpression.Validate(__workflow_generatePasswordpasswordFormat, nameof(generatePasswordpasswordFormat), required: true);
            var __workflow_generatePasswordworkflow = generatePasswordworkflow == null ? null : WorkflowExpression.Compile(generatePasswordworkflow);
            WorkflowExpression.Validate(__workflow_generatePasswordworkflow, nameof(generatePasswordworkflow), required: true);
            var __workflow_generatePasswordminimumLength = generatePasswordminimumLength == null ? null : WorkflowExpression.Compile(generatePasswordminimumLength);
            WorkflowExpression.Validate(__workflow_generatePasswordminimumLength, nameof(generatePasswordminimumLength), required: false);
            var __workflow_generatePasswordreturnAsPlainText = generatePasswordreturnAsPlainText == null ? null : WorkflowExpression.Compile(generatePasswordreturnAsPlainText);
            WorkflowExpression.Validate(__workflow_generatePasswordreturnAsPlainText, nameof(generatePasswordreturnAsPlainText), required: false);
            var __workflow_generatePasswordstorePasswordAsIdentifier = generatePasswordstorePasswordAsIdentifier == null ? null : WorkflowExpression.Compile(generatePasswordstorePasswordAsIdentifier);
            WorkflowExpression.Validate(__workflow_generatePasswordstorePasswordAsIdentifier, nameof(generatePasswordstorePasswordAsIdentifier), required: false);
            var __workflow_generatePasswordsupportedSymbols = generatePasswordsupportedSymbols == null ? null : WorkflowExpression.Compile(generatePasswordsupportedSymbols);
            WorkflowExpression.Validate(__workflow_generatePasswordsupportedSymbols, nameof(generatePasswordsupportedSymbols), required: false);
            var __workflow_generatePasswordattemptUniquePasswords = generatePasswordattemptUniquePasswords == null ? null : WorkflowExpression.Compile(generatePasswordattemptUniquePasswords);
            WorkflowExpression.Validate(__workflow_generatePasswordattemptUniquePasswords, nameof(generatePasswordattemptUniquePasswords), required: false);
            var __workflow_generatePasswordgenerateAt = generatePasswordgenerateAt == null ? null : WorkflowExpression.Compile(generatePasswordgenerateAt);
            WorkflowExpression.Validate(__workflow_generatePasswordgenerateAt, nameof(generatePasswordgenerateAt), required: false);
            var __workflow_generatePasswordminimumLowercase = generatePasswordminimumLowercase == null ? null : WorkflowExpression.Compile(generatePasswordminimumLowercase);
            WorkflowExpression.Validate(__workflow_generatePasswordminimumLowercase, nameof(generatePasswordminimumLowercase), required: false);
            var __workflow_generatePasswordminimumUppercase = generatePasswordminimumUppercase == null ? null : WorkflowExpression.Compile(generatePasswordminimumUppercase);
            WorkflowExpression.Validate(__workflow_generatePasswordminimumUppercase, nameof(generatePasswordminimumUppercase), required: false);
            var __workflow_generatePasswordminimumNumbers = generatePasswordminimumNumbers == null ? null : WorkflowExpression.Compile(generatePasswordminimumNumbers);
            WorkflowExpression.Validate(__workflow_generatePasswordminimumNumbers, nameof(generatePasswordminimumNumbers), required: false);
            var __workflow_generatePasswordminimumSymbols = generatePasswordminimumSymbols == null ? null : WorkflowExpression.Compile(generatePasswordminimumSymbols);
            WorkflowExpression.Validate(__workflow_generatePasswordminimumSymbols, nameof(generatePasswordminimumSymbols), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetStoredPasswordResponse> GetStoredPassword(Expression<Func<string>> getStoredPasswordworkflow, Expression<Func<string>> getStoredPasswordpasswordIdentifier = null)
        {
            var __workflow_getStoredPasswordworkflow = getStoredPasswordworkflow == null ? null : WorkflowExpression.Compile(getStoredPasswordworkflow);
            WorkflowExpression.Validate(__workflow_getStoredPasswordworkflow, nameof(getStoredPasswordworkflow), required: true);
            var __workflow_getStoredPasswordpasswordIdentifier = getStoredPasswordpasswordIdentifier == null ? null : WorkflowExpression.Compile(getStoredPasswordpasswordIdentifier);
            WorkflowExpression.Validate(__workflow_getStoredPasswordpasswordIdentifier, nameof(getStoredPasswordpasswordIdentifier), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ExpandPasswordStringResponse> ExpandPasswordString(Expression<Func<string>> expandPasswordStringworkflow, Expression<Func<string>> expandPasswordStringinputString = null)
        {
            var __workflow_expandPasswordStringworkflow = expandPasswordStringworkflow == null ? null : WorkflowExpression.Compile(expandPasswordStringworkflow);
            WorkflowExpression.Validate(__workflow_expandPasswordStringworkflow, nameof(expandPasswordStringworkflow), required: true);
            var __workflow_expandPasswordStringinputString = expandPasswordStringinputString == null ? null : WorkflowExpression.Compile(expandPasswordStringinputString);
            WorkflowExpression.Validate(__workflow_expandPasswordStringinputString, nameof(expandPasswordStringinputString), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<StorePasswordInAgentMemoryResponse> StorePasswordInAgentMemory(Expression<Func<string>> storePasswordInAgentMemoryidentifier, Expression<Func<string>> storePasswordInAgentMemorypassword, Expression<Func<string>> storePasswordInAgentMemoryworkflow)
        {
            var __workflow_storePasswordInAgentMemoryidentifier = storePasswordInAgentMemoryidentifier == null ? null : WorkflowExpression.Compile(storePasswordInAgentMemoryidentifier);
            WorkflowExpression.Validate(__workflow_storePasswordInAgentMemoryidentifier, nameof(storePasswordInAgentMemoryidentifier), required: true);
            var __workflow_storePasswordInAgentMemorypassword = storePasswordInAgentMemorypassword == null ? null : WorkflowExpression.Compile(storePasswordInAgentMemorypassword);
            WorkflowExpression.Validate(__workflow_storePasswordInAgentMemorypassword, nameof(storePasswordInAgentMemorypassword), required: true);
            var __workflow_storePasswordInAgentMemoryworkflow = storePasswordInAgentMemoryworkflow == null ? null : WorkflowExpression.Compile(storePasswordInAgentMemoryworkflow);
            WorkflowExpression.Validate(__workflow_storePasswordInAgentMemoryworkflow, nameof(storePasswordInAgentMemoryworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeletePasswordInAgentMemoryResponse> DeletePasswordInAgentMemory(Expression<Func<string>> deletePasswordInAgentMemoryworkflow, Expression<Func<bool>> deletePasswordInAgentMemorydeleteAllPasswords = null, Expression<Func<string>> deletePasswordInAgentMemoryidentifier = null)
        {
            var __workflow_deletePasswordInAgentMemoryworkflow = deletePasswordInAgentMemoryworkflow == null ? null : WorkflowExpression.Compile(deletePasswordInAgentMemoryworkflow);
            WorkflowExpression.Validate(__workflow_deletePasswordInAgentMemoryworkflow, nameof(deletePasswordInAgentMemoryworkflow), required: true);
            var __workflow_deletePasswordInAgentMemorydeleteAllPasswords = deletePasswordInAgentMemorydeleteAllPasswords == null ? null : WorkflowExpression.Compile(deletePasswordInAgentMemorydeleteAllPasswords);
            WorkflowExpression.Validate(__workflow_deletePasswordInAgentMemorydeleteAllPasswords, nameof(deletePasswordInAgentMemorydeleteAllPasswords), required: false);
            var __workflow_deletePasswordInAgentMemoryidentifier = deletePasswordInAgentMemoryidentifier == null ? null : WorkflowExpression.Compile(deletePasswordInAgentMemoryidentifier);
            WorkflowExpression.Validate(__workflow_deletePasswordInAgentMemoryidentifier, nameof(deletePasswordInAgentMemoryidentifier), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialWriteResponse> CredentialWrite(Expression<Func<string>> credentialWritecredentialAddress, Expression<Func<string>> credentialWriteuserName, Expression<Func<string>> credentialWritepassword, Expression<Func<credentialWritecredentialTypeInput>> credentialWritecredentialType, Expression<Func<string>> credentialWriteworkflow, Expression<Func<credentialWritecredentialPersistenceInput>> credentialWritecredentialPersistence = null, Expression<Func<string>> credentialWritesymmetricKey = null, Expression<Func<string>> credentialWritestorePasswordAsIdentifier = null)
        {
            var __workflow_credentialWritecredentialAddress = credentialWritecredentialAddress == null ? null : WorkflowExpression.Compile(credentialWritecredentialAddress);
            WorkflowExpression.Validate(__workflow_credentialWritecredentialAddress, nameof(credentialWritecredentialAddress), required: true);
            var __workflow_credentialWriteuserName = credentialWriteuserName == null ? null : WorkflowExpression.Compile(credentialWriteuserName);
            WorkflowExpression.Validate(__workflow_credentialWriteuserName, nameof(credentialWriteuserName), required: true);
            var __workflow_credentialWritepassword = credentialWritepassword == null ? null : WorkflowExpression.Compile(credentialWritepassword);
            WorkflowExpression.Validate(__workflow_credentialWritepassword, nameof(credentialWritepassword), required: true);
            var __workflow_credentialWritecredentialType = credentialWritecredentialType == null ? null : WorkflowExpression.Compile(credentialWritecredentialType);
            WorkflowExpression.Validate(__workflow_credentialWritecredentialType, nameof(credentialWritecredentialType), required: true);
            var __workflow_credentialWriteworkflow = credentialWriteworkflow == null ? null : WorkflowExpression.Compile(credentialWriteworkflow);
            WorkflowExpression.Validate(__workflow_credentialWriteworkflow, nameof(credentialWriteworkflow), required: true);
            var __workflow_credentialWritecredentialPersistence = credentialWritecredentialPersistence == null ? null : WorkflowExpression.Compile(credentialWritecredentialPersistence);
            WorkflowExpression.Validate(__workflow_credentialWritecredentialPersistence, nameof(credentialWritecredentialPersistence), required: false);
            var __workflow_credentialWritesymmetricKey = credentialWritesymmetricKey == null ? null : WorkflowExpression.Compile(credentialWritesymmetricKey);
            WorkflowExpression.Validate(__workflow_credentialWritesymmetricKey, nameof(credentialWritesymmetricKey), required: false);
            var __workflow_credentialWritestorePasswordAsIdentifier = credentialWritestorePasswordAsIdentifier == null ? null : WorkflowExpression.Compile(credentialWritestorePasswordAsIdentifier);
            WorkflowExpression.Validate(__workflow_credentialWritestorePasswordAsIdentifier, nameof(credentialWritestorePasswordAsIdentifier), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialReadResponse> CredentialRead(Expression<Func<string>> credentialReadcredentialAddress, Expression<Func<credentialReadcredentialTypeInput>> credentialReadcredentialType, Expression<Func<string>> credentialReadworkflow, Expression<Func<string>> credentialReadsymmetricKey = null, Expression<Func<string>> credentialReadstorePasswordAsIdentifier = null, Expression<Func<bool>> credentialReaddontReturnPassword = null)
        {
            var __workflow_credentialReadcredentialAddress = credentialReadcredentialAddress == null ? null : WorkflowExpression.Compile(credentialReadcredentialAddress);
            WorkflowExpression.Validate(__workflow_credentialReadcredentialAddress, nameof(credentialReadcredentialAddress), required: true);
            var __workflow_credentialReadcredentialType = credentialReadcredentialType == null ? null : WorkflowExpression.Compile(credentialReadcredentialType);
            WorkflowExpression.Validate(__workflow_credentialReadcredentialType, nameof(credentialReadcredentialType), required: true);
            var __workflow_credentialReadworkflow = credentialReadworkflow == null ? null : WorkflowExpression.Compile(credentialReadworkflow);
            WorkflowExpression.Validate(__workflow_credentialReadworkflow, nameof(credentialReadworkflow), required: true);
            var __workflow_credentialReadsymmetricKey = credentialReadsymmetricKey == null ? null : WorkflowExpression.Compile(credentialReadsymmetricKey);
            WorkflowExpression.Validate(__workflow_credentialReadsymmetricKey, nameof(credentialReadsymmetricKey), required: false);
            var __workflow_credentialReadstorePasswordAsIdentifier = credentialReadstorePasswordAsIdentifier == null ? null : WorkflowExpression.Compile(credentialReadstorePasswordAsIdentifier);
            WorkflowExpression.Validate(__workflow_credentialReadstorePasswordAsIdentifier, nameof(credentialReadstorePasswordAsIdentifier), required: false);
            var __workflow_credentialReaddontReturnPassword = credentialReaddontReturnPassword == null ? null : WorkflowExpression.Compile(credentialReaddontReturnPassword);
            WorkflowExpression.Validate(__workflow_credentialReaddontReturnPassword, nameof(credentialReaddontReturnPassword), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialDeleteResponse> CredentialDelete(Expression<Func<string>> credentialDeletecredentialAddress, Expression<Func<credentialDeletecredentialTypeInput>> credentialDeletecredentialType, Expression<Func<string>> credentialDeleteworkflow)
        {
            var __workflow_credentialDeletecredentialAddress = credentialDeletecredentialAddress == null ? null : WorkflowExpression.Compile(credentialDeletecredentialAddress);
            WorkflowExpression.Validate(__workflow_credentialDeletecredentialAddress, nameof(credentialDeletecredentialAddress), required: true);
            var __workflow_credentialDeletecredentialType = credentialDeletecredentialType == null ? null : WorkflowExpression.Compile(credentialDeletecredentialType);
            WorkflowExpression.Validate(__workflow_credentialDeletecredentialType, nameof(credentialDeletecredentialType), required: true);
            var __workflow_credentialDeleteworkflow = credentialDeleteworkflow == null ? null : WorkflowExpression.Compile(credentialDeleteworkflow);
            WorkflowExpression.Validate(__workflow_credentialDeleteworkflow, nameof(credentialDeleteworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GenerateRDPFileResponse> GenerateRDPFile(Expression<Func<string>> generateRDPFileremoteAddress, Expression<Func<string>> generateRDPFileoutputFolderPath, Expression<Func<string>> generateRDPFilerDPFileName, Expression<Func<string>> generateRDPFileworkflow, Expression<Func<bool>> generateRDPFileoverwriteRDPFileIfAlreadyExists = null, Expression<Func<bool>> generateRDPFiletrustRemoteComputer = null, Expression<Func<bool>> generateRDPFilestoreCredentials = null, Expression<Func<string>> generateRDPFileuserName = null, Expression<Func<string>> generateRDPFilepassword = null, Expression<Func<generateRDPFilecredentialTypeInput>> generateRDPFilecredentialType = null, Expression<Func<generateRDPFilecredentialPersistenceInput>> generateRDPFilecredentialPersistence = null, Expression<Func<bool>> generateRDPFileredirectPrinters = null, Expression<Func<bool>> generateRDPFileredirectAllDrives = null, Expression<Func<bool>> generateRDPFileredirectClipboard = null, Expression<Func<bool>> generateRDPFilefullscreen = null, Expression<Func<int>> generateRDPFiledesktopWidth = null, Expression<Func<int>> generateRDPFiledesktopHeight = null, Expression<Func<bool>> generateRDPFileuseMultiMonitor = null, Expression<Func<int>> generateRDPFilesessionBPP = null, Expression<Func<bool>> generateRDPFilesmartSizing = null)
        {
            var __workflow_generateRDPFileremoteAddress = generateRDPFileremoteAddress == null ? null : WorkflowExpression.Compile(generateRDPFileremoteAddress);
            WorkflowExpression.Validate(__workflow_generateRDPFileremoteAddress, nameof(generateRDPFileremoteAddress), required: true);
            var __workflow_generateRDPFileoutputFolderPath = generateRDPFileoutputFolderPath == null ? null : WorkflowExpression.Compile(generateRDPFileoutputFolderPath);
            WorkflowExpression.Validate(__workflow_generateRDPFileoutputFolderPath, nameof(generateRDPFileoutputFolderPath), required: true);
            var __workflow_generateRDPFilerDPFileName = generateRDPFilerDPFileName == null ? null : WorkflowExpression.Compile(generateRDPFilerDPFileName);
            WorkflowExpression.Validate(__workflow_generateRDPFilerDPFileName, nameof(generateRDPFilerDPFileName), required: true);
            var __workflow_generateRDPFileworkflow = generateRDPFileworkflow == null ? null : WorkflowExpression.Compile(generateRDPFileworkflow);
            WorkflowExpression.Validate(__workflow_generateRDPFileworkflow, nameof(generateRDPFileworkflow), required: true);
            var __workflow_generateRDPFileoverwriteRDPFileIfAlreadyExists = generateRDPFileoverwriteRDPFileIfAlreadyExists == null ? null : WorkflowExpression.Compile(generateRDPFileoverwriteRDPFileIfAlreadyExists);
            WorkflowExpression.Validate(__workflow_generateRDPFileoverwriteRDPFileIfAlreadyExists, nameof(generateRDPFileoverwriteRDPFileIfAlreadyExists), required: false);
            var __workflow_generateRDPFiletrustRemoteComputer = generateRDPFiletrustRemoteComputer == null ? null : WorkflowExpression.Compile(generateRDPFiletrustRemoteComputer);
            WorkflowExpression.Validate(__workflow_generateRDPFiletrustRemoteComputer, nameof(generateRDPFiletrustRemoteComputer), required: false);
            var __workflow_generateRDPFilestoreCredentials = generateRDPFilestoreCredentials == null ? null : WorkflowExpression.Compile(generateRDPFilestoreCredentials);
            WorkflowExpression.Validate(__workflow_generateRDPFilestoreCredentials, nameof(generateRDPFilestoreCredentials), required: false);
            var __workflow_generateRDPFileuserName = generateRDPFileuserName == null ? null : WorkflowExpression.Compile(generateRDPFileuserName);
            WorkflowExpression.Validate(__workflow_generateRDPFileuserName, nameof(generateRDPFileuserName), required: false);
            var __workflow_generateRDPFilepassword = generateRDPFilepassword == null ? null : WorkflowExpression.Compile(generateRDPFilepassword);
            WorkflowExpression.Validate(__workflow_generateRDPFilepassword, nameof(generateRDPFilepassword), required: false);
            var __workflow_generateRDPFilecredentialType = generateRDPFilecredentialType == null ? null : WorkflowExpression.Compile(generateRDPFilecredentialType);
            WorkflowExpression.Validate(__workflow_generateRDPFilecredentialType, nameof(generateRDPFilecredentialType), required: false);
            var __workflow_generateRDPFilecredentialPersistence = generateRDPFilecredentialPersistence == null ? null : WorkflowExpression.Compile(generateRDPFilecredentialPersistence);
            WorkflowExpression.Validate(__workflow_generateRDPFilecredentialPersistence, nameof(generateRDPFilecredentialPersistence), required: false);
            var __workflow_generateRDPFileredirectPrinters = generateRDPFileredirectPrinters == null ? null : WorkflowExpression.Compile(generateRDPFileredirectPrinters);
            WorkflowExpression.Validate(__workflow_generateRDPFileredirectPrinters, nameof(generateRDPFileredirectPrinters), required: false);
            var __workflow_generateRDPFileredirectAllDrives = generateRDPFileredirectAllDrives == null ? null : WorkflowExpression.Compile(generateRDPFileredirectAllDrives);
            WorkflowExpression.Validate(__workflow_generateRDPFileredirectAllDrives, nameof(generateRDPFileredirectAllDrives), required: false);
            var __workflow_generateRDPFileredirectClipboard = generateRDPFileredirectClipboard == null ? null : WorkflowExpression.Compile(generateRDPFileredirectClipboard);
            WorkflowExpression.Validate(__workflow_generateRDPFileredirectClipboard, nameof(generateRDPFileredirectClipboard), required: false);
            var __workflow_generateRDPFilefullscreen = generateRDPFilefullscreen == null ? null : WorkflowExpression.Compile(generateRDPFilefullscreen);
            WorkflowExpression.Validate(__workflow_generateRDPFilefullscreen, nameof(generateRDPFilefullscreen), required: false);
            var __workflow_generateRDPFiledesktopWidth = generateRDPFiledesktopWidth == null ? null : WorkflowExpression.Compile(generateRDPFiledesktopWidth);
            WorkflowExpression.Validate(__workflow_generateRDPFiledesktopWidth, nameof(generateRDPFiledesktopWidth), required: false);
            var __workflow_generateRDPFiledesktopHeight = generateRDPFiledesktopHeight == null ? null : WorkflowExpression.Compile(generateRDPFiledesktopHeight);
            WorkflowExpression.Validate(__workflow_generateRDPFiledesktopHeight, nameof(generateRDPFiledesktopHeight), required: false);
            var __workflow_generateRDPFileuseMultiMonitor = generateRDPFileuseMultiMonitor == null ? null : WorkflowExpression.Compile(generateRDPFileuseMultiMonitor);
            WorkflowExpression.Validate(__workflow_generateRDPFileuseMultiMonitor, nameof(generateRDPFileuseMultiMonitor), required: false);
            var __workflow_generateRDPFilesessionBPP = generateRDPFilesessionBPP == null ? null : WorkflowExpression.Compile(generateRDPFilesessionBPP);
            WorkflowExpression.Validate(__workflow_generateRDPFilesessionBPP, nameof(generateRDPFilesessionBPP), required: false);
            var __workflow_generateRDPFilesmartSizing = generateRDPFilesmartSizing == null ? null : WorkflowExpression.Compile(generateRDPFilesmartSizing);
            WorkflowExpression.Validate(__workflow_generateRDPFilesmartSizing, nameof(generateRDPFilesmartSizing), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<LaunchRemoteDesktopSessionResponse> LaunchRemoteDesktopSession(Expression<Func<string>> launchRemoteDesktopSessionrDPFilePath, Expression<Func<string>> launchRemoteDesktopSessionworkflow, Expression<Func<bool>> launchRemoteDesktopSessiontrustRemoteComputer = null)
        {
            var __workflow_launchRemoteDesktopSessionrDPFilePath = launchRemoteDesktopSessionrDPFilePath == null ? null : WorkflowExpression.Compile(launchRemoteDesktopSessionrDPFilePath);
            WorkflowExpression.Validate(__workflow_launchRemoteDesktopSessionrDPFilePath, nameof(launchRemoteDesktopSessionrDPFilePath), required: true);
            var __workflow_launchRemoteDesktopSessionworkflow = launchRemoteDesktopSessionworkflow == null ? null : WorkflowExpression.Compile(launchRemoteDesktopSessionworkflow);
            WorkflowExpression.Validate(__workflow_launchRemoteDesktopSessionworkflow, nameof(launchRemoteDesktopSessionworkflow), required: true);
            var __workflow_launchRemoteDesktopSessiontrustRemoteComputer = launchRemoteDesktopSessiontrustRemoteComputer == null ? null : WorkflowExpression.Compile(launchRemoteDesktopSessiontrustRemoteComputer);
            WorkflowExpression.Validate(__workflow_launchRemoteDesktopSessiontrustRemoteComputer, nameof(launchRemoteDesktopSessiontrustRemoteComputer), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsTCPPortRespondingResponse> IsTCPPortResponding(Expression<Func<string>> isTCPPortRespondingremoteHost, Expression<Func<int>> isTCPPortRespondingtCPPort, Expression<Func<string>> isTCPPortRespondingworkflow, Expression<Func<int>> isTCPPortRespondingtimeoutInSeconds = null)
        {
            var __workflow_isTCPPortRespondingremoteHost = isTCPPortRespondingremoteHost == null ? null : WorkflowExpression.Compile(isTCPPortRespondingremoteHost);
            WorkflowExpression.Validate(__workflow_isTCPPortRespondingremoteHost, nameof(isTCPPortRespondingremoteHost), required: true);
            var __workflow_isTCPPortRespondingtCPPort = isTCPPortRespondingtCPPort == null ? null : WorkflowExpression.Compile(isTCPPortRespondingtCPPort);
            WorkflowExpression.Validate(__workflow_isTCPPortRespondingtCPPort, nameof(isTCPPortRespondingtCPPort), required: true);
            var __workflow_isTCPPortRespondingworkflow = isTCPPortRespondingworkflow == null ? null : WorkflowExpression.Compile(isTCPPortRespondingworkflow);
            WorkflowExpression.Validate(__workflow_isTCPPortRespondingworkflow, nameof(isTCPPortRespondingworkflow), required: true);
            var __workflow_isTCPPortRespondingtimeoutInSeconds = isTCPPortRespondingtimeoutInSeconds == null ? null : WorkflowExpression.Compile(isTCPPortRespondingtimeoutInSeconds);
            WorkflowExpression.Validate(__workflow_isTCPPortRespondingtimeoutInSeconds, nameof(isTCPPortRespondingtimeoutInSeconds), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UnlockSessionResponse> UnlockSession(Expression<Func<string>> unlockSessionunlockPassword, Expression<Func<bool>> unlockSessiondetectIfLocked, Expression<Func<bool>> unlockSessiondetectCredentialProvider, Expression<Func<string>> unlockSessionworkflow, Expression<Func<bool>> unlockSessionpasswordContainsStoredPassword = null, Expression<Func<int>> unlockSessionsecondsToWaitForUnlock = null)
        {
            var __workflow_unlockSessionunlockPassword = unlockSessionunlockPassword == null ? null : WorkflowExpression.Compile(unlockSessionunlockPassword);
            WorkflowExpression.Validate(__workflow_unlockSessionunlockPassword, nameof(unlockSessionunlockPassword), required: true);
            var __workflow_unlockSessiondetectIfLocked = unlockSessiondetectIfLocked == null ? null : WorkflowExpression.Compile(unlockSessiondetectIfLocked);
            WorkflowExpression.Validate(__workflow_unlockSessiondetectIfLocked, nameof(unlockSessiondetectIfLocked), required: true);
            var __workflow_unlockSessiondetectCredentialProvider = unlockSessiondetectCredentialProvider == null ? null : WorkflowExpression.Compile(unlockSessiondetectCredentialProvider);
            WorkflowExpression.Validate(__workflow_unlockSessiondetectCredentialProvider, nameof(unlockSessiondetectCredentialProvider), required: true);
            var __workflow_unlockSessionworkflow = unlockSessionworkflow == null ? null : WorkflowExpression.Compile(unlockSessionworkflow);
            WorkflowExpression.Validate(__workflow_unlockSessionworkflow, nameof(unlockSessionworkflow), required: true);
            var __workflow_unlockSessionpasswordContainsStoredPassword = unlockSessionpasswordContainsStoredPassword == null ? null : WorkflowExpression.Compile(unlockSessionpasswordContainsStoredPassword);
            WorkflowExpression.Validate(__workflow_unlockSessionpasswordContainsStoredPassword, nameof(unlockSessionpasswordContainsStoredPassword), required: false);
            var __workflow_unlockSessionsecondsToWaitForUnlock = unlockSessionsecondsToWaitForUnlock == null ? null : WorkflowExpression.Compile(unlockSessionsecondsToWaitForUnlock);
            WorkflowExpression.Validate(__workflow_unlockSessionsecondsToWaitForUnlock, nameof(unlockSessionsecondsToWaitForUnlock), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<LockSessionResponse> LockSession(Expression<Func<string>> lockSessionworkflow, Expression<Func<int>> lockSessionlockAfterMinutesOfActionInactivity = null, Expression<Func<int>> lockSessionsecondsToWaitAfterLock = null)
        {
            var __workflow_lockSessionworkflow = lockSessionworkflow == null ? null : WorkflowExpression.Compile(lockSessionworkflow);
            WorkflowExpression.Validate(__workflow_lockSessionworkflow, nameof(lockSessionworkflow), required: true);
            var __workflow_lockSessionlockAfterMinutesOfActionInactivity = lockSessionlockAfterMinutesOfActionInactivity == null ? null : WorkflowExpression.Compile(lockSessionlockAfterMinutesOfActionInactivity);
            WorkflowExpression.Validate(__workflow_lockSessionlockAfterMinutesOfActionInactivity, nameof(lockSessionlockAfterMinutesOfActionInactivity), required: false);
            var __workflow_lockSessionsecondsToWaitAfterLock = lockSessionsecondsToWaitAfterLock == null ? null : WorkflowExpression.Compile(lockSessionsecondsToWaitAfterLock);
            WorkflowExpression.Validate(__workflow_lockSessionsecondsToWaitAfterLock, nameof(lockSessionsecondsToWaitAfterLock), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsSessionLockedResponse> IsSessionLocked(Expression<Func<string>> isSessionLockedworkflow)
        {
            var __workflow_isSessionLockedworkflow = isSessionLockedworkflow == null ? null : WorkflowExpression.Compile(isSessionLockedworkflow);
            WorkflowExpression.Validate(__workflow_isSessionLockedworkflow, nameof(isSessionLockedworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetGenericCredentialFromOrchestratorResponse> GetGenericCredentialFromOrchestrator(Expression<Func<string>> getGenericCredentialFromOrchestratorfriendlyName = null, Expression<Func<bool>> getGenericCredentialFromOrchestratorretrievePlainTextPassword = null)
        {
            var __workflow_getGenericCredentialFromOrchestratorfriendlyName = getGenericCredentialFromOrchestratorfriendlyName == null ? null : WorkflowExpression.Compile(getGenericCredentialFromOrchestratorfriendlyName);
            WorkflowExpression.Validate(__workflow_getGenericCredentialFromOrchestratorfriendlyName, nameof(getGenericCredentialFromOrchestratorfriendlyName), required: false);
            var __workflow_getGenericCredentialFromOrchestratorretrievePlainTextPassword = getGenericCredentialFromOrchestratorretrievePlainTextPassword == null ? null : WorkflowExpression.Compile(getGenericCredentialFromOrchestratorretrievePlainTextPassword);
            WorkflowExpression.Validate(__workflow_getGenericCredentialFromOrchestratorretrievePlainTextPassword, nameof(getGenericCredentialFromOrchestratorretrievePlainTextPassword), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DrawRectangleOnScreenResponse> DrawRectangleOnScreen(Expression<Func<int>> drawRectangleOnScreenrectangleLeftPixelXCoord, Expression<Func<int>> drawRectangleOnScreenrectangleRightPixelXCoord, Expression<Func<int>> drawRectangleOnScreenrectangleTopPixelYCoord, Expression<Func<int>> drawRectangleOnScreenrectangleBottomPixelYCoord, Expression<Func<string>> drawRectangleOnScreenworkflow, Expression<Func<string>> drawRectangleOnScreenpenColour = null, Expression<Func<int>> drawRectangleOnScreenpenThicknessPixels = null, Expression<Func<int>> drawRectangleOnScreensecondsToDisplay = null, Expression<Func<bool>> drawRectangleOnScreencoordinatesArePhysical = null)
        {
            var __workflow_drawRectangleOnScreenrectangleLeftPixelXCoord = drawRectangleOnScreenrectangleLeftPixelXCoord == null ? null : WorkflowExpression.Compile(drawRectangleOnScreenrectangleLeftPixelXCoord);
            WorkflowExpression.Validate(__workflow_drawRectangleOnScreenrectangleLeftPixelXCoord, nameof(drawRectangleOnScreenrectangleLeftPixelXCoord), required: true);
            var __workflow_drawRectangleOnScreenrectangleRightPixelXCoord = drawRectangleOnScreenrectangleRightPixelXCoord == null ? null : WorkflowExpression.Compile(drawRectangleOnScreenrectangleRightPixelXCoord);
            WorkflowExpression.Validate(__workflow_drawRectangleOnScreenrectangleRightPixelXCoord, nameof(drawRectangleOnScreenrectangleRightPixelXCoord), required: true);
            var __workflow_drawRectangleOnScreenrectangleTopPixelYCoord = drawRectangleOnScreenrectangleTopPixelYCoord == null ? null : WorkflowExpression.Compile(drawRectangleOnScreenrectangleTopPixelYCoord);
            WorkflowExpression.Validate(__workflow_drawRectangleOnScreenrectangleTopPixelYCoord, nameof(drawRectangleOnScreenrectangleTopPixelYCoord), required: true);
            var __workflow_drawRectangleOnScreenrectangleBottomPixelYCoord = drawRectangleOnScreenrectangleBottomPixelYCoord == null ? null : WorkflowExpression.Compile(drawRectangleOnScreenrectangleBottomPixelYCoord);
            WorkflowExpression.Validate(__workflow_drawRectangleOnScreenrectangleBottomPixelYCoord, nameof(drawRectangleOnScreenrectangleBottomPixelYCoord), required: true);
            var __workflow_drawRectangleOnScreenworkflow = drawRectangleOnScreenworkflow == null ? null : WorkflowExpression.Compile(drawRectangleOnScreenworkflow);
            WorkflowExpression.Validate(__workflow_drawRectangleOnScreenworkflow, nameof(drawRectangleOnScreenworkflow), required: true);
            var __workflow_drawRectangleOnScreenpenColour = drawRectangleOnScreenpenColour == null ? null : WorkflowExpression.Compile(drawRectangleOnScreenpenColour);
            WorkflowExpression.Validate(__workflow_drawRectangleOnScreenpenColour, nameof(drawRectangleOnScreenpenColour), required: false);
            var __workflow_drawRectangleOnScreenpenThicknessPixels = drawRectangleOnScreenpenThicknessPixels == null ? null : WorkflowExpression.Compile(drawRectangleOnScreenpenThicknessPixels);
            WorkflowExpression.Validate(__workflow_drawRectangleOnScreenpenThicknessPixels, nameof(drawRectangleOnScreenpenThicknessPixels), required: false);
            var __workflow_drawRectangleOnScreensecondsToDisplay = drawRectangleOnScreensecondsToDisplay == null ? null : WorkflowExpression.Compile(drawRectangleOnScreensecondsToDisplay);
            WorkflowExpression.Validate(__workflow_drawRectangleOnScreensecondsToDisplay, nameof(drawRectangleOnScreensecondsToDisplay), required: false);
            var __workflow_drawRectangleOnScreencoordinatesArePhysical = drawRectangleOnScreencoordinatesArePhysical == null ? null : WorkflowExpression.Compile(drawRectangleOnScreencoordinatesArePhysical);
            WorkflowExpression.Validate(__workflow_drawRectangleOnScreencoordinatesArePhysical, nameof(drawRectangleOnScreencoordinatesArePhysical), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFailedActionErrorMessageFromPowerAutomateResultJSONResponse> GetFailedActionErrorMessageFromPowerAutomateResultJSON(Expression<Func<string[]>> getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON, Expression<Func<string>> getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus = null)
        {
            var __workflow_getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON = getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON == null ? null : WorkflowExpression.Compile(getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON);
            WorkflowExpression.Validate(__workflow_getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON, nameof(getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON), required: true);
            var __workflow_getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus = getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus == null ? null : WorkflowExpression.Compile(getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus);
            WorkflowExpression.Validate(__workflow_getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus, nameof(getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetPixelColourAtCoordinateResponse> GetPixelColourAtCoordinate(Expression<Func<int>> getPixelColourAtCoordinateleftXPixels, Expression<Func<int>> getPixelColourAtCoordinatetopYPixels, Expression<Func<string>> getPixelColourAtCoordinateworkflow, Expression<Func<bool>> getPixelColourAtCoordinatehideAgent = null, Expression<Func<bool>> getPixelColourAtCoordinateusePhysicalCoordinates = null)
        {
            var __workflow_getPixelColourAtCoordinateleftXPixels = getPixelColourAtCoordinateleftXPixels == null ? null : WorkflowExpression.Compile(getPixelColourAtCoordinateleftXPixels);
            WorkflowExpression.Validate(__workflow_getPixelColourAtCoordinateleftXPixels, nameof(getPixelColourAtCoordinateleftXPixels), required: true);
            var __workflow_getPixelColourAtCoordinatetopYPixels = getPixelColourAtCoordinatetopYPixels == null ? null : WorkflowExpression.Compile(getPixelColourAtCoordinatetopYPixels);
            WorkflowExpression.Validate(__workflow_getPixelColourAtCoordinatetopYPixels, nameof(getPixelColourAtCoordinatetopYPixels), required: true);
            var __workflow_getPixelColourAtCoordinateworkflow = getPixelColourAtCoordinateworkflow == null ? null : WorkflowExpression.Compile(getPixelColourAtCoordinateworkflow);
            WorkflowExpression.Validate(__workflow_getPixelColourAtCoordinateworkflow, nameof(getPixelColourAtCoordinateworkflow), required: true);
            var __workflow_getPixelColourAtCoordinatehideAgent = getPixelColourAtCoordinatehideAgent == null ? null : WorkflowExpression.Compile(getPixelColourAtCoordinatehideAgent);
            WorkflowExpression.Validate(__workflow_getPixelColourAtCoordinatehideAgent, nameof(getPixelColourAtCoordinatehideAgent), required: false);
            var __workflow_getPixelColourAtCoordinateusePhysicalCoordinates = getPixelColourAtCoordinateusePhysicalCoordinates == null ? null : WorkflowExpression.Compile(getPixelColourAtCoordinateusePhysicalCoordinates);
            WorkflowExpression.Validate(__workflow_getPixelColourAtCoordinateusePhysicalCoordinates, nameof(getPixelColourAtCoordinateusePhysicalCoordinates), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ConvertRectangleCoordinatesResponse> ConvertRectangleCoordinates(Expression<Func<int>> convertRectangleCoordinatesrectangleLeftPixelXCoord, Expression<Func<int>> convertRectangleCoordinatesrectangleTopPixelYCoord, Expression<Func<int>> convertRectangleCoordinatesrectangleRightPixelXCoord, Expression<Func<int>> convertRectangleCoordinatesrectangleBottomPixelYCoord, Expression<Func<convertRectangleCoordinatesconversionTypeInput>> convertRectangleCoordinatesconversionType, Expression<Func<string>> convertRectangleCoordinatesworkflow)
        {
            var __workflow_convertRectangleCoordinatesrectangleLeftPixelXCoord = convertRectangleCoordinatesrectangleLeftPixelXCoord == null ? null : WorkflowExpression.Compile(convertRectangleCoordinatesrectangleLeftPixelXCoord);
            WorkflowExpression.Validate(__workflow_convertRectangleCoordinatesrectangleLeftPixelXCoord, nameof(convertRectangleCoordinatesrectangleLeftPixelXCoord), required: true);
            var __workflow_convertRectangleCoordinatesrectangleTopPixelYCoord = convertRectangleCoordinatesrectangleTopPixelYCoord == null ? null : WorkflowExpression.Compile(convertRectangleCoordinatesrectangleTopPixelYCoord);
            WorkflowExpression.Validate(__workflow_convertRectangleCoordinatesrectangleTopPixelYCoord, nameof(convertRectangleCoordinatesrectangleTopPixelYCoord), required: true);
            var __workflow_convertRectangleCoordinatesrectangleRightPixelXCoord = convertRectangleCoordinatesrectangleRightPixelXCoord == null ? null : WorkflowExpression.Compile(convertRectangleCoordinatesrectangleRightPixelXCoord);
            WorkflowExpression.Validate(__workflow_convertRectangleCoordinatesrectangleRightPixelXCoord, nameof(convertRectangleCoordinatesrectangleRightPixelXCoord), required: true);
            var __workflow_convertRectangleCoordinatesrectangleBottomPixelYCoord = convertRectangleCoordinatesrectangleBottomPixelYCoord == null ? null : WorkflowExpression.Compile(convertRectangleCoordinatesrectangleBottomPixelYCoord);
            WorkflowExpression.Validate(__workflow_convertRectangleCoordinatesrectangleBottomPixelYCoord, nameof(convertRectangleCoordinatesrectangleBottomPixelYCoord), required: true);
            var __workflow_convertRectangleCoordinatesconversionType = convertRectangleCoordinatesconversionType == null ? null : WorkflowExpression.Compile(convertRectangleCoordinatesconversionType);
            WorkflowExpression.Validate(__workflow_convertRectangleCoordinatesconversionType, nameof(convertRectangleCoordinatesconversionType), required: true);
            var __workflow_convertRectangleCoordinatesworkflow = convertRectangleCoordinatesworkflow == null ? null : WorkflowExpression.Compile(convertRectangleCoordinatesworkflow);
            WorkflowExpression.Validate(__workflow_convertRectangleCoordinatesworkflow, nameof(convertRectangleCoordinatesworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SendMessageToWebAPIResponse> SendMessageToWebAPI(Expression<Func<string>> sendMessageToWebAPIworkflow, Expression<Func<string>> sendMessageToWebAPIuRL = null, Expression<Func<sendMessageToWebAPImethodInput>> sendMessageToWebAPImethod = null, Expression<Func<int>> sendMessageToWebAPItimeoutInSeconds = null, Expression<Func<string>> sendMessageToWebAPIcontentType = null, Expression<Func<string>> sendMessageToWebAPIaccept = null, Expression<Func<string>> sendMessageToWebAPImessageBody = null, Expression<Func<sendMessageToWebAPItransmitEncodingInput>> sendMessageToWebAPItransmitEncoding = null, Expression<Func<sendMessageToWebAPIresponseEncodingInput>> sendMessageToWebAPIresponseEncoding = null, Expression<Func<int>> sendMessageToWebAPIbufferSize = null, Expression<Func<sendMessageToWebAPIhTTPRequestHeadersListInputItem[]>> sendMessageToWebAPIhTTPRequestHeadersList = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS10 = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS11 = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS12 = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS13 = null, Expression<Func<bool>> sendMessageToWebAPIkeepAlive = null, Expression<Func<bool>> sendMessageToWebAPIexpect100Continue = null, Expression<Func<bool>> sendMessageToWebAPIreturnResponseHeaders = null, Expression<Func<bool>> sendMessageToWebAPIrunAsThread = null, Expression<Func<bool>> sendMessageToWebAPIwaitForThread = null, Expression<Func<int>> sendMessageToWebAPIretrieveOutputDataFromThreadId = null)
        {
            var __workflow_sendMessageToWebAPIworkflow = sendMessageToWebAPIworkflow == null ? null : WorkflowExpression.Compile(sendMessageToWebAPIworkflow);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPIworkflow, nameof(sendMessageToWebAPIworkflow), required: true);
            var __workflow_sendMessageToWebAPIuRL = sendMessageToWebAPIuRL == null ? null : WorkflowExpression.Compile(sendMessageToWebAPIuRL);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPIuRL, nameof(sendMessageToWebAPIuRL), required: false);
            var __workflow_sendMessageToWebAPImethod = sendMessageToWebAPImethod == null ? null : WorkflowExpression.Compile(sendMessageToWebAPImethod);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPImethod, nameof(sendMessageToWebAPImethod), required: false);
            var __workflow_sendMessageToWebAPItimeoutInSeconds = sendMessageToWebAPItimeoutInSeconds == null ? null : WorkflowExpression.Compile(sendMessageToWebAPItimeoutInSeconds);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPItimeoutInSeconds, nameof(sendMessageToWebAPItimeoutInSeconds), required: false);
            var __workflow_sendMessageToWebAPIcontentType = sendMessageToWebAPIcontentType == null ? null : WorkflowExpression.Compile(sendMessageToWebAPIcontentType);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPIcontentType, nameof(sendMessageToWebAPIcontentType), required: false);
            var __workflow_sendMessageToWebAPIaccept = sendMessageToWebAPIaccept == null ? null : WorkflowExpression.Compile(sendMessageToWebAPIaccept);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPIaccept, nameof(sendMessageToWebAPIaccept), required: false);
            var __workflow_sendMessageToWebAPImessageBody = sendMessageToWebAPImessageBody == null ? null : WorkflowExpression.Compile(sendMessageToWebAPImessageBody);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPImessageBody, nameof(sendMessageToWebAPImessageBody), required: false);
            var __workflow_sendMessageToWebAPItransmitEncoding = sendMessageToWebAPItransmitEncoding == null ? null : WorkflowExpression.Compile(sendMessageToWebAPItransmitEncoding);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPItransmitEncoding, nameof(sendMessageToWebAPItransmitEncoding), required: false);
            var __workflow_sendMessageToWebAPIresponseEncoding = sendMessageToWebAPIresponseEncoding == null ? null : WorkflowExpression.Compile(sendMessageToWebAPIresponseEncoding);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPIresponseEncoding, nameof(sendMessageToWebAPIresponseEncoding), required: false);
            var __workflow_sendMessageToWebAPIbufferSize = sendMessageToWebAPIbufferSize == null ? null : WorkflowExpression.Compile(sendMessageToWebAPIbufferSize);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPIbufferSize, nameof(sendMessageToWebAPIbufferSize), required: false);
            var __workflow_sendMessageToWebAPIhTTPRequestHeadersList = sendMessageToWebAPIhTTPRequestHeadersList == null ? null : WorkflowExpression.Compile(sendMessageToWebAPIhTTPRequestHeadersList);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPIhTTPRequestHeadersList, nameof(sendMessageToWebAPIhTTPRequestHeadersList), required: false);
            var __workflow_sendMessageToWebAPInegotiateTLS10 = sendMessageToWebAPInegotiateTLS10 == null ? null : WorkflowExpression.Compile(sendMessageToWebAPInegotiateTLS10);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPInegotiateTLS10, nameof(sendMessageToWebAPInegotiateTLS10), required: false);
            var __workflow_sendMessageToWebAPInegotiateTLS11 = sendMessageToWebAPInegotiateTLS11 == null ? null : WorkflowExpression.Compile(sendMessageToWebAPInegotiateTLS11);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPInegotiateTLS11, nameof(sendMessageToWebAPInegotiateTLS11), required: false);
            var __workflow_sendMessageToWebAPInegotiateTLS12 = sendMessageToWebAPInegotiateTLS12 == null ? null : WorkflowExpression.Compile(sendMessageToWebAPInegotiateTLS12);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPInegotiateTLS12, nameof(sendMessageToWebAPInegotiateTLS12), required: false);
            var __workflow_sendMessageToWebAPInegotiateTLS13 = sendMessageToWebAPInegotiateTLS13 == null ? null : WorkflowExpression.Compile(sendMessageToWebAPInegotiateTLS13);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPInegotiateTLS13, nameof(sendMessageToWebAPInegotiateTLS13), required: false);
            var __workflow_sendMessageToWebAPIkeepAlive = sendMessageToWebAPIkeepAlive == null ? null : WorkflowExpression.Compile(sendMessageToWebAPIkeepAlive);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPIkeepAlive, nameof(sendMessageToWebAPIkeepAlive), required: false);
            var __workflow_sendMessageToWebAPIexpect100Continue = sendMessageToWebAPIexpect100Continue == null ? null : WorkflowExpression.Compile(sendMessageToWebAPIexpect100Continue);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPIexpect100Continue, nameof(sendMessageToWebAPIexpect100Continue), required: false);
            var __workflow_sendMessageToWebAPIreturnResponseHeaders = sendMessageToWebAPIreturnResponseHeaders == null ? null : WorkflowExpression.Compile(sendMessageToWebAPIreturnResponseHeaders);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPIreturnResponseHeaders, nameof(sendMessageToWebAPIreturnResponseHeaders), required: false);
            var __workflow_sendMessageToWebAPIrunAsThread = sendMessageToWebAPIrunAsThread == null ? null : WorkflowExpression.Compile(sendMessageToWebAPIrunAsThread);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPIrunAsThread, nameof(sendMessageToWebAPIrunAsThread), required: false);
            var __workflow_sendMessageToWebAPIwaitForThread = sendMessageToWebAPIwaitForThread == null ? null : WorkflowExpression.Compile(sendMessageToWebAPIwaitForThread);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPIwaitForThread, nameof(sendMessageToWebAPIwaitForThread), required: false);
            var __workflow_sendMessageToWebAPIretrieveOutputDataFromThreadId = sendMessageToWebAPIretrieveOutputDataFromThreadId == null ? null : WorkflowExpression.Compile(sendMessageToWebAPIretrieveOutputDataFromThreadId);
            WorkflowExpression.Validate(__workflow_sendMessageToWebAPIretrieveOutputDataFromThreadId, nameof(sendMessageToWebAPIretrieveOutputDataFromThreadId), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewTaskResponse> TasksAddNewTask(Expression<Func<string>> tasksAddNewTaskworkflow, Expression<Func<tasksAddNewTasksetAutomationNameInput>> tasksAddNewTasksetAutomationName = null, Expression<Func<string>> tasksAddNewTaskautomationName = null, Expression<Func<string>> tasksAddNewTasktaskInputData = null, Expression<Func<string>> tasksAddNewTaskprocessStage = null, Expression<Func<int>> tasksAddNewTaskpriority = null, Expression<Func<int>> tasksAddNewTasksLA = null, Expression<Func<bool>> tasksAddNewTasktaskOnHold = null, Expression<Func<string>> tasksAddNewTaskorganisation = null, Expression<Func<string>> tasksAddNewTaskdepartment = null, Expression<Func<string>> tasksAddNewTaskdescription = null, Expression<Func<string>> tasksAddNewTasktags = null)
        {
            var __workflow_tasksAddNewTaskworkflow = tasksAddNewTaskworkflow == null ? null : WorkflowExpression.Compile(tasksAddNewTaskworkflow);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskworkflow, nameof(tasksAddNewTaskworkflow), required: true);
            var __workflow_tasksAddNewTasksetAutomationName = tasksAddNewTasksetAutomationName == null ? null : WorkflowExpression.Compile(tasksAddNewTasksetAutomationName);
            WorkflowExpression.Validate(__workflow_tasksAddNewTasksetAutomationName, nameof(tasksAddNewTasksetAutomationName), required: false);
            var __workflow_tasksAddNewTaskautomationName = tasksAddNewTaskautomationName == null ? null : WorkflowExpression.Compile(tasksAddNewTaskautomationName);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskautomationName, nameof(tasksAddNewTaskautomationName), required: false);
            var __workflow_tasksAddNewTasktaskInputData = tasksAddNewTasktaskInputData == null ? null : WorkflowExpression.Compile(tasksAddNewTasktaskInputData);
            WorkflowExpression.Validate(__workflow_tasksAddNewTasktaskInputData, nameof(tasksAddNewTasktaskInputData), required: false);
            var __workflow_tasksAddNewTaskprocessStage = tasksAddNewTaskprocessStage == null ? null : WorkflowExpression.Compile(tasksAddNewTaskprocessStage);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskprocessStage, nameof(tasksAddNewTaskprocessStage), required: false);
            var __workflow_tasksAddNewTaskpriority = tasksAddNewTaskpriority == null ? null : WorkflowExpression.Compile(tasksAddNewTaskpriority);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskpriority, nameof(tasksAddNewTaskpriority), required: false);
            var __workflow_tasksAddNewTasksLA = tasksAddNewTasksLA == null ? null : WorkflowExpression.Compile(tasksAddNewTasksLA);
            WorkflowExpression.Validate(__workflow_tasksAddNewTasksLA, nameof(tasksAddNewTasksLA), required: false);
            var __workflow_tasksAddNewTasktaskOnHold = tasksAddNewTasktaskOnHold == null ? null : WorkflowExpression.Compile(tasksAddNewTasktaskOnHold);
            WorkflowExpression.Validate(__workflow_tasksAddNewTasktaskOnHold, nameof(tasksAddNewTasktaskOnHold), required: false);
            var __workflow_tasksAddNewTaskorganisation = tasksAddNewTaskorganisation == null ? null : WorkflowExpression.Compile(tasksAddNewTaskorganisation);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskorganisation, nameof(tasksAddNewTaskorganisation), required: false);
            var __workflow_tasksAddNewTaskdepartment = tasksAddNewTaskdepartment == null ? null : WorkflowExpression.Compile(tasksAddNewTaskdepartment);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskdepartment, nameof(tasksAddNewTaskdepartment), required: false);
            var __workflow_tasksAddNewTaskdescription = tasksAddNewTaskdescription == null ? null : WorkflowExpression.Compile(tasksAddNewTaskdescription);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskdescription, nameof(tasksAddNewTaskdescription), required: false);
            var __workflow_tasksAddNewTasktags = tasksAddNewTasktags == null ? null : WorkflowExpression.Compile(tasksAddNewTasktags);
            WorkflowExpression.Validate(__workflow_tasksAddNewTasktags, nameof(tasksAddNewTasktags), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewDeferralResponse> TasksAddNewDeferral(Expression<Func<string>> tasksAddNewDeferralworkflow, Expression<Func<tasksAddNewDeferralsetAutomationNameInput>> tasksAddNewDeferralsetAutomationName = null, Expression<Func<string>> tasksAddNewDeferralautomationName = null, Expression<Func<int>> tasksAddNewDeferraldeferralTimeInMinutes = null, Expression<Func<string>> tasksAddNewDeferraltaskInputData = null, Expression<Func<string>> tasksAddNewDeferraldeferralStoredData = null, Expression<Func<string>> tasksAddNewDeferralprocessStage = null, Expression<Func<int>> tasksAddNewDeferralpriority = null, Expression<Func<bool>> tasksAddNewDeferraltaskOnHold = null, Expression<Func<string>> tasksAddNewDeferralorganisation = null, Expression<Func<string>> tasksAddNewDeferraldepartment = null, Expression<Func<string>> tasksAddNewDeferraldescription = null, Expression<Func<string>> tasksAddNewDeferraltags = null)
        {
            var __workflow_tasksAddNewDeferralworkflow = tasksAddNewDeferralworkflow == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralworkflow);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralworkflow, nameof(tasksAddNewDeferralworkflow), required: true);
            var __workflow_tasksAddNewDeferralsetAutomationName = tasksAddNewDeferralsetAutomationName == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralsetAutomationName);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralsetAutomationName, nameof(tasksAddNewDeferralsetAutomationName), required: false);
            var __workflow_tasksAddNewDeferralautomationName = tasksAddNewDeferralautomationName == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralautomationName);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralautomationName, nameof(tasksAddNewDeferralautomationName), required: false);
            var __workflow_tasksAddNewDeferraldeferralTimeInMinutes = tasksAddNewDeferraldeferralTimeInMinutes == null ? null : WorkflowExpression.Compile(tasksAddNewDeferraldeferralTimeInMinutes);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferraldeferralTimeInMinutes, nameof(tasksAddNewDeferraldeferralTimeInMinutes), required: false);
            var __workflow_tasksAddNewDeferraltaskInputData = tasksAddNewDeferraltaskInputData == null ? null : WorkflowExpression.Compile(tasksAddNewDeferraltaskInputData);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferraltaskInputData, nameof(tasksAddNewDeferraltaskInputData), required: false);
            var __workflow_tasksAddNewDeferraldeferralStoredData = tasksAddNewDeferraldeferralStoredData == null ? null : WorkflowExpression.Compile(tasksAddNewDeferraldeferralStoredData);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferraldeferralStoredData, nameof(tasksAddNewDeferraldeferralStoredData), required: false);
            var __workflow_tasksAddNewDeferralprocessStage = tasksAddNewDeferralprocessStage == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralprocessStage);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralprocessStage, nameof(tasksAddNewDeferralprocessStage), required: false);
            var __workflow_tasksAddNewDeferralpriority = tasksAddNewDeferralpriority == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralpriority);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralpriority, nameof(tasksAddNewDeferralpriority), required: false);
            var __workflow_tasksAddNewDeferraltaskOnHold = tasksAddNewDeferraltaskOnHold == null ? null : WorkflowExpression.Compile(tasksAddNewDeferraltaskOnHold);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferraltaskOnHold, nameof(tasksAddNewDeferraltaskOnHold), required: false);
            var __workflow_tasksAddNewDeferralorganisation = tasksAddNewDeferralorganisation == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralorganisation);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralorganisation, nameof(tasksAddNewDeferralorganisation), required: false);
            var __workflow_tasksAddNewDeferraldepartment = tasksAddNewDeferraldepartment == null ? null : WorkflowExpression.Compile(tasksAddNewDeferraldepartment);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferraldepartment, nameof(tasksAddNewDeferraldepartment), required: false);
            var __workflow_tasksAddNewDeferraldescription = tasksAddNewDeferraldescription == null ? null : WorkflowExpression.Compile(tasksAddNewDeferraldescription);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferraldescription, nameof(tasksAddNewDeferraldescription), required: false);
            var __workflow_tasksAddNewDeferraltags = tasksAddNewDeferraltags == null ? null : WorkflowExpression.Compile(tasksAddNewDeferraltags);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferraltags, nameof(tasksAddNewDeferraltags), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeferExistingTaskResponse> TasksDeferExistingTask(Expression<Func<int>> tasksDeferExistingTasktaskId, Expression<Func<int>> tasksDeferExistingTaskdeferralTimeInMinutes = null, Expression<Func<string>> tasksDeferExistingTaskdeferralStoredData = null, Expression<Func<string>> tasksDeferExistingTaskprocessStage = null, Expression<Func<int>> tasksDeferExistingTaskpriority = null, Expression<Func<bool>> tasksDeferExistingTasktaskOnHold = null)
        {
            var __workflow_tasksDeferExistingTasktaskId = tasksDeferExistingTasktaskId == null ? null : WorkflowExpression.Compile(tasksDeferExistingTasktaskId);
            WorkflowExpression.Validate(__workflow_tasksDeferExistingTasktaskId, nameof(tasksDeferExistingTasktaskId), required: true);
            var __workflow_tasksDeferExistingTaskdeferralTimeInMinutes = tasksDeferExistingTaskdeferralTimeInMinutes == null ? null : WorkflowExpression.Compile(tasksDeferExistingTaskdeferralTimeInMinutes);
            WorkflowExpression.Validate(__workflow_tasksDeferExistingTaskdeferralTimeInMinutes, nameof(tasksDeferExistingTaskdeferralTimeInMinutes), required: false);
            var __workflow_tasksDeferExistingTaskdeferralStoredData = tasksDeferExistingTaskdeferralStoredData == null ? null : WorkflowExpression.Compile(tasksDeferExistingTaskdeferralStoredData);
            WorkflowExpression.Validate(__workflow_tasksDeferExistingTaskdeferralStoredData, nameof(tasksDeferExistingTaskdeferralStoredData), required: false);
            var __workflow_tasksDeferExistingTaskprocessStage = tasksDeferExistingTaskprocessStage == null ? null : WorkflowExpression.Compile(tasksDeferExistingTaskprocessStage);
            WorkflowExpression.Validate(__workflow_tasksDeferExistingTaskprocessStage, nameof(tasksDeferExistingTaskprocessStage), required: false);
            var __workflow_tasksDeferExistingTaskpriority = tasksDeferExistingTaskpriority == null ? null : WorkflowExpression.Compile(tasksDeferExistingTaskpriority);
            WorkflowExpression.Validate(__workflow_tasksDeferExistingTaskpriority, nameof(tasksDeferExistingTaskpriority), required: false);
            var __workflow_tasksDeferExistingTasktaskOnHold = tasksDeferExistingTasktaskOnHold == null ? null : WorkflowExpression.Compile(tasksDeferExistingTasktaskOnHold);
            WorkflowExpression.Validate(__workflow_tasksDeferExistingTasktaskOnHold, nameof(tasksDeferExistingTasktaskOnHold), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeferExistingTaskOperationResponse> TasksDeferExistingTaskOperation(Expression<Func<string>> tasksDeferExistingTaskOperationoperationId, Expression<Func<int>> tasksDeferExistingTaskOperationdeferralTimeInMinutes = null, Expression<Func<string>> tasksDeferExistingTaskOperationdeferralStoredData = null, Expression<Func<string>> tasksDeferExistingTaskOperationprocessStage = null, Expression<Func<int>> tasksDeferExistingTaskOperationpriority = null)
        {
            var __workflow_tasksDeferExistingTaskOperationoperationId = tasksDeferExistingTaskOperationoperationId == null ? null : WorkflowExpression.Compile(tasksDeferExistingTaskOperationoperationId);
            WorkflowExpression.Validate(__workflow_tasksDeferExistingTaskOperationoperationId, nameof(tasksDeferExistingTaskOperationoperationId), required: true);
            var __workflow_tasksDeferExistingTaskOperationdeferralTimeInMinutes = tasksDeferExistingTaskOperationdeferralTimeInMinutes == null ? null : WorkflowExpression.Compile(tasksDeferExistingTaskOperationdeferralTimeInMinutes);
            WorkflowExpression.Validate(__workflow_tasksDeferExistingTaskOperationdeferralTimeInMinutes, nameof(tasksDeferExistingTaskOperationdeferralTimeInMinutes), required: false);
            var __workflow_tasksDeferExistingTaskOperationdeferralStoredData = tasksDeferExistingTaskOperationdeferralStoredData == null ? null : WorkflowExpression.Compile(tasksDeferExistingTaskOperationdeferralStoredData);
            WorkflowExpression.Validate(__workflow_tasksDeferExistingTaskOperationdeferralStoredData, nameof(tasksDeferExistingTaskOperationdeferralStoredData), required: false);
            var __workflow_tasksDeferExistingTaskOperationprocessStage = tasksDeferExistingTaskOperationprocessStage == null ? null : WorkflowExpression.Compile(tasksDeferExistingTaskOperationprocessStage);
            WorkflowExpression.Validate(__workflow_tasksDeferExistingTaskOperationprocessStage, nameof(tasksDeferExistingTaskOperationprocessStage), required: false);
            var __workflow_tasksDeferExistingTaskOperationpriority = tasksDeferExistingTaskOperationpriority == null ? null : WorkflowExpression.Compile(tasksDeferExistingTaskOperationpriority);
            WorkflowExpression.Validate(__workflow_tasksDeferExistingTaskOperationpriority, nameof(tasksDeferExistingTaskOperationpriority), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeleteTaskResponse> TasksDeleteTask(Expression<Func<int>> tasksDeleteTasktaskId, Expression<Func<bool>> tasksDeleteTaskupdateSourceSystem = null)
        {
            var __workflow_tasksDeleteTasktaskId = tasksDeleteTasktaskId == null ? null : WorkflowExpression.Compile(tasksDeleteTasktaskId);
            WorkflowExpression.Validate(__workflow_tasksDeleteTasktaskId, nameof(tasksDeleteTasktaskId), required: true);
            var __workflow_tasksDeleteTaskupdateSourceSystem = tasksDeleteTaskupdateSourceSystem == null ? null : WorkflowExpression.Compile(tasksDeleteTaskupdateSourceSystem);
            WorkflowExpression.Validate(__workflow_tasksDeleteTaskupdateSourceSystem, nameof(tasksDeleteTaskupdateSourceSystem), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeleteTaskOperationResponse> TasksDeleteTaskOperation(Expression<Func<string>> tasksDeleteTaskOperationoperationId, Expression<Func<bool>> tasksDeleteTaskOperationupdateSourceSystem = null)
        {
            var __workflow_tasksDeleteTaskOperationoperationId = tasksDeleteTaskOperationoperationId == null ? null : WorkflowExpression.Compile(tasksDeleteTaskOperationoperationId);
            WorkflowExpression.Validate(__workflow_tasksDeleteTaskOperationoperationId, nameof(tasksDeleteTaskOperationoperationId), required: true);
            var __workflow_tasksDeleteTaskOperationupdateSourceSystem = tasksDeleteTaskOperationupdateSourceSystem == null ? null : WorkflowExpression.Compile(tasksDeleteTaskOperationupdateSourceSystem);
            WorkflowExpression.Validate(__workflow_tasksDeleteTaskOperationupdateSourceSystem, nameof(tasksDeleteTaskOperationupdateSourceSystem), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetAllTasksResponse> TasksGetAllTasks(Expression<Func<string>> tasksGetAllTasksautomationName = null, Expression<Func<tasksGetAllTasksautomationTaskStatusInput>> tasksGetAllTasksautomationTaskStatus = null, Expression<Func<string>> tasksGetAllTasksfilterByPropertyQuery = null, Expression<Func<int>> tasksGetAllTasksminutesUntilDeferralDate = null, Expression<Func<int>> tasksGetAllTasksminimumPriorityLevel = null, Expression<Func<bool>> tasksGetAllTaskssortByDeferralDate = null, Expression<Func<bool>> tasksGetAllTasksretrieveOnHoldTasks = null, Expression<Func<int>> tasksGetAllTasksskip = null, Expression<Func<int>> tasksGetAllTasksmaxResults = null, Expression<Func<bool>> tasksGetAllTasksexcludeTaskData = null)
        {
            var __workflow_tasksGetAllTasksautomationName = tasksGetAllTasksautomationName == null ? null : WorkflowExpression.Compile(tasksGetAllTasksautomationName);
            WorkflowExpression.Validate(__workflow_tasksGetAllTasksautomationName, nameof(tasksGetAllTasksautomationName), required: false);
            var __workflow_tasksGetAllTasksautomationTaskStatus = tasksGetAllTasksautomationTaskStatus == null ? null : WorkflowExpression.Compile(tasksGetAllTasksautomationTaskStatus);
            WorkflowExpression.Validate(__workflow_tasksGetAllTasksautomationTaskStatus, nameof(tasksGetAllTasksautomationTaskStatus), required: false);
            var __workflow_tasksGetAllTasksfilterByPropertyQuery = tasksGetAllTasksfilterByPropertyQuery == null ? null : WorkflowExpression.Compile(tasksGetAllTasksfilterByPropertyQuery);
            WorkflowExpression.Validate(__workflow_tasksGetAllTasksfilterByPropertyQuery, nameof(tasksGetAllTasksfilterByPropertyQuery), required: false);
            var __workflow_tasksGetAllTasksminutesUntilDeferralDate = tasksGetAllTasksminutesUntilDeferralDate == null ? null : WorkflowExpression.Compile(tasksGetAllTasksminutesUntilDeferralDate);
            WorkflowExpression.Validate(__workflow_tasksGetAllTasksminutesUntilDeferralDate, nameof(tasksGetAllTasksminutesUntilDeferralDate), required: false);
            var __workflow_tasksGetAllTasksminimumPriorityLevel = tasksGetAllTasksminimumPriorityLevel == null ? null : WorkflowExpression.Compile(tasksGetAllTasksminimumPriorityLevel);
            WorkflowExpression.Validate(__workflow_tasksGetAllTasksminimumPriorityLevel, nameof(tasksGetAllTasksminimumPriorityLevel), required: false);
            var __workflow_tasksGetAllTaskssortByDeferralDate = tasksGetAllTaskssortByDeferralDate == null ? null : WorkflowExpression.Compile(tasksGetAllTaskssortByDeferralDate);
            WorkflowExpression.Validate(__workflow_tasksGetAllTaskssortByDeferralDate, nameof(tasksGetAllTaskssortByDeferralDate), required: false);
            var __workflow_tasksGetAllTasksretrieveOnHoldTasks = tasksGetAllTasksretrieveOnHoldTasks == null ? null : WorkflowExpression.Compile(tasksGetAllTasksretrieveOnHoldTasks);
            WorkflowExpression.Validate(__workflow_tasksGetAllTasksretrieveOnHoldTasks, nameof(tasksGetAllTasksretrieveOnHoldTasks), required: false);
            var __workflow_tasksGetAllTasksskip = tasksGetAllTasksskip == null ? null : WorkflowExpression.Compile(tasksGetAllTasksskip);
            WorkflowExpression.Validate(__workflow_tasksGetAllTasksskip, nameof(tasksGetAllTasksskip), required: false);
            var __workflow_tasksGetAllTasksmaxResults = tasksGetAllTasksmaxResults == null ? null : WorkflowExpression.Compile(tasksGetAllTasksmaxResults);
            WorkflowExpression.Validate(__workflow_tasksGetAllTasksmaxResults, nameof(tasksGetAllTasksmaxResults), required: false);
            var __workflow_tasksGetAllTasksexcludeTaskData = tasksGetAllTasksexcludeTaskData == null ? null : WorkflowExpression.Compile(tasksGetAllTasksexcludeTaskData);
            WorkflowExpression.Validate(__workflow_tasksGetAllTasksexcludeTaskData, nameof(tasksGetAllTasksexcludeTaskData), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetTaskResponse> TasksGetTask(Expression<Func<int>> tasksGetTasktaskId, Expression<Func<tasksGetTaskstatusChangeInput>> tasksGetTaskstatusChange = null)
        {
            var __workflow_tasksGetTasktaskId = tasksGetTasktaskId == null ? null : WorkflowExpression.Compile(tasksGetTasktaskId);
            WorkflowExpression.Validate(__workflow_tasksGetTasktaskId, nameof(tasksGetTasktaskId), required: true);
            var __workflow_tasksGetTaskstatusChange = tasksGetTaskstatusChange == null ? null : WorkflowExpression.Compile(tasksGetTaskstatusChange);
            WorkflowExpression.Validate(__workflow_tasksGetTaskstatusChange, nameof(tasksGetTaskstatusChange), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetNextTaskResponse> TasksGetNextTask(Expression<Func<string>> tasksGetNextTaskautomationName = null, Expression<Func<string[]>> tasksGetNextTaskautomationNames = null, Expression<Func<int>> tasksGetNextTaskminimumPriorityLevel = null, Expression<Func<tasksGetNextTaskstatusChangeInput>> tasksGetNextTaskstatusChange = null, Expression<Func<int>> tasksGetNextTaskminutesUntilDeferralDate = null, Expression<Func<bool>> tasksGetNextTaskignoreSLA = null, Expression<Func<int[]>> tasksGetNextTaskexcludeTaskIds = null)
        {
            var __workflow_tasksGetNextTaskautomationName = tasksGetNextTaskautomationName == null ? null : WorkflowExpression.Compile(tasksGetNextTaskautomationName);
            WorkflowExpression.Validate(__workflow_tasksGetNextTaskautomationName, nameof(tasksGetNextTaskautomationName), required: false);
            var __workflow_tasksGetNextTaskautomationNames = tasksGetNextTaskautomationNames == null ? null : WorkflowExpression.Compile(tasksGetNextTaskautomationNames);
            WorkflowExpression.Validate(__workflow_tasksGetNextTaskautomationNames, nameof(tasksGetNextTaskautomationNames), required: false);
            var __workflow_tasksGetNextTaskminimumPriorityLevel = tasksGetNextTaskminimumPriorityLevel == null ? null : WorkflowExpression.Compile(tasksGetNextTaskminimumPriorityLevel);
            WorkflowExpression.Validate(__workflow_tasksGetNextTaskminimumPriorityLevel, nameof(tasksGetNextTaskminimumPriorityLevel), required: false);
            var __workflow_tasksGetNextTaskstatusChange = tasksGetNextTaskstatusChange == null ? null : WorkflowExpression.Compile(tasksGetNextTaskstatusChange);
            WorkflowExpression.Validate(__workflow_tasksGetNextTaskstatusChange, nameof(tasksGetNextTaskstatusChange), required: false);
            var __workflow_tasksGetNextTaskminutesUntilDeferralDate = tasksGetNextTaskminutesUntilDeferralDate == null ? null : WorkflowExpression.Compile(tasksGetNextTaskminutesUntilDeferralDate);
            WorkflowExpression.Validate(__workflow_tasksGetNextTaskminutesUntilDeferralDate, nameof(tasksGetNextTaskminutesUntilDeferralDate), required: false);
            var __workflow_tasksGetNextTaskignoreSLA = tasksGetNextTaskignoreSLA == null ? null : WorkflowExpression.Compile(tasksGetNextTaskignoreSLA);
            WorkflowExpression.Validate(__workflow_tasksGetNextTaskignoreSLA, nameof(tasksGetNextTaskignoreSLA), required: false);
            var __workflow_tasksGetNextTaskexcludeTaskIds = tasksGetNextTaskexcludeTaskIds == null ? null : WorkflowExpression.Compile(tasksGetNextTaskexcludeTaskIds);
            WorkflowExpression.Validate(__workflow_tasksGetNextTaskexcludeTaskIds, nameof(tasksGetNextTaskexcludeTaskIds), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksChangeTaskStatusResponse> TasksChangeTaskStatus(Expression<Func<int>> tasksChangeTaskStatustaskId, Expression<Func<tasksChangeTaskStatusautomationTaskStatusInput>> tasksChangeTaskStatusautomationTaskStatus = null, Expression<Func<bool>> tasksChangeTaskStatustaskOnHold = null, Expression<Func<bool>> tasksChangeTaskStatuseraseTaskInputData = null, Expression<Func<bool>> tasksChangeTaskStatuseraseDeferralStoredData = null, Expression<Func<bool>> tasksChangeTaskStatusupdateSourceSystem = null, Expression<Func<string>> tasksChangeTaskStatustaskClosureReason = null)
        {
            var __workflow_tasksChangeTaskStatustaskId = tasksChangeTaskStatustaskId == null ? null : WorkflowExpression.Compile(tasksChangeTaskStatustaskId);
            WorkflowExpression.Validate(__workflow_tasksChangeTaskStatustaskId, nameof(tasksChangeTaskStatustaskId), required: true);
            var __workflow_tasksChangeTaskStatusautomationTaskStatus = tasksChangeTaskStatusautomationTaskStatus == null ? null : WorkflowExpression.Compile(tasksChangeTaskStatusautomationTaskStatus);
            WorkflowExpression.Validate(__workflow_tasksChangeTaskStatusautomationTaskStatus, nameof(tasksChangeTaskStatusautomationTaskStatus), required: false);
            var __workflow_tasksChangeTaskStatustaskOnHold = tasksChangeTaskStatustaskOnHold == null ? null : WorkflowExpression.Compile(tasksChangeTaskStatustaskOnHold);
            WorkflowExpression.Validate(__workflow_tasksChangeTaskStatustaskOnHold, nameof(tasksChangeTaskStatustaskOnHold), required: false);
            var __workflow_tasksChangeTaskStatuseraseTaskInputData = tasksChangeTaskStatuseraseTaskInputData == null ? null : WorkflowExpression.Compile(tasksChangeTaskStatuseraseTaskInputData);
            WorkflowExpression.Validate(__workflow_tasksChangeTaskStatuseraseTaskInputData, nameof(tasksChangeTaskStatuseraseTaskInputData), required: false);
            var __workflow_tasksChangeTaskStatuseraseDeferralStoredData = tasksChangeTaskStatuseraseDeferralStoredData == null ? null : WorkflowExpression.Compile(tasksChangeTaskStatuseraseDeferralStoredData);
            WorkflowExpression.Validate(__workflow_tasksChangeTaskStatuseraseDeferralStoredData, nameof(tasksChangeTaskStatuseraseDeferralStoredData), required: false);
            var __workflow_tasksChangeTaskStatusupdateSourceSystem = tasksChangeTaskStatusupdateSourceSystem == null ? null : WorkflowExpression.Compile(tasksChangeTaskStatusupdateSourceSystem);
            WorkflowExpression.Validate(__workflow_tasksChangeTaskStatusupdateSourceSystem, nameof(tasksChangeTaskStatusupdateSourceSystem), required: false);
            var __workflow_tasksChangeTaskStatustaskClosureReason = tasksChangeTaskStatustaskClosureReason == null ? null : WorkflowExpression.Compile(tasksChangeTaskStatustaskClosureReason);
            WorkflowExpression.Validate(__workflow_tasksChangeTaskStatustaskClosureReason, nameof(tasksChangeTaskStatustaskClosureReason), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNoteResponse> TasksAddNote(Expression<Func<int>> tasksAddNotetaskId, Expression<Func<string>> tasksAddNotenoteText, Expression<Func<tasksAddNotenoteTypeInput>> tasksAddNotenoteType = null, Expression<Func<string>> tasksAddNotenoteTypeOther = null)
        {
            var __workflow_tasksAddNotetaskId = tasksAddNotetaskId == null ? null : WorkflowExpression.Compile(tasksAddNotetaskId);
            WorkflowExpression.Validate(__workflow_tasksAddNotetaskId, nameof(tasksAddNotetaskId), required: true);
            var __workflow_tasksAddNotenoteText = tasksAddNotenoteText == null ? null : WorkflowExpression.Compile(tasksAddNotenoteText);
            WorkflowExpression.Validate(__workflow_tasksAddNotenoteText, nameof(tasksAddNotenoteText), required: true);
            var __workflow_tasksAddNotenoteType = tasksAddNotenoteType == null ? null : WorkflowExpression.Compile(tasksAddNotenoteType);
            WorkflowExpression.Validate(__workflow_tasksAddNotenoteType, nameof(tasksAddNotenoteType), required: false);
            var __workflow_tasksAddNotenoteTypeOther = tasksAddNotenoteTypeOther == null ? null : WorkflowExpression.Compile(tasksAddNotenoteTypeOther);
            WorkflowExpression.Validate(__workflow_tasksAddNotenoteTypeOther, nameof(tasksAddNotenoteTypeOther), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAssignTaskResponse> TasksAssignTask(Expression<Func<int>> tasksAssignTasktaskId, Expression<Func<string>> tasksAssignTaskassignToUserId = null, Expression<Func<string>> tasksAssignTaskassignToUserName = null, Expression<Func<string>> tasksAssignTaskassignToGroupId = null, Expression<Func<string>> tasksAssignTaskassignToGroupName = null, Expression<Func<bool>> tasksAssignTaskremoveUserAssignmentIfBlank = null, Expression<Func<bool>> tasksAssignTaskremoveGroupAssignmentIfBlank = null)
        {
            var __workflow_tasksAssignTasktaskId = tasksAssignTasktaskId == null ? null : WorkflowExpression.Compile(tasksAssignTasktaskId);
            WorkflowExpression.Validate(__workflow_tasksAssignTasktaskId, nameof(tasksAssignTasktaskId), required: true);
            var __workflow_tasksAssignTaskassignToUserId = tasksAssignTaskassignToUserId == null ? null : WorkflowExpression.Compile(tasksAssignTaskassignToUserId);
            WorkflowExpression.Validate(__workflow_tasksAssignTaskassignToUserId, nameof(tasksAssignTaskassignToUserId), required: false);
            var __workflow_tasksAssignTaskassignToUserName = tasksAssignTaskassignToUserName == null ? null : WorkflowExpression.Compile(tasksAssignTaskassignToUserName);
            WorkflowExpression.Validate(__workflow_tasksAssignTaskassignToUserName, nameof(tasksAssignTaskassignToUserName), required: false);
            var __workflow_tasksAssignTaskassignToGroupId = tasksAssignTaskassignToGroupId == null ? null : WorkflowExpression.Compile(tasksAssignTaskassignToGroupId);
            WorkflowExpression.Validate(__workflow_tasksAssignTaskassignToGroupId, nameof(tasksAssignTaskassignToGroupId), required: false);
            var __workflow_tasksAssignTaskassignToGroupName = tasksAssignTaskassignToGroupName == null ? null : WorkflowExpression.Compile(tasksAssignTaskassignToGroupName);
            WorkflowExpression.Validate(__workflow_tasksAssignTaskassignToGroupName, nameof(tasksAssignTaskassignToGroupName), required: false);
            var __workflow_tasksAssignTaskremoveUserAssignmentIfBlank = tasksAssignTaskremoveUserAssignmentIfBlank == null ? null : WorkflowExpression.Compile(tasksAssignTaskremoveUserAssignmentIfBlank);
            WorkflowExpression.Validate(__workflow_tasksAssignTaskremoveUserAssignmentIfBlank, nameof(tasksAssignTaskremoveUserAssignmentIfBlank), required: false);
            var __workflow_tasksAssignTaskremoveGroupAssignmentIfBlank = tasksAssignTaskremoveGroupAssignmentIfBlank == null ? null : WorkflowExpression.Compile(tasksAssignTaskremoveGroupAssignmentIfBlank);
            WorkflowExpression.Validate(__workflow_tasksAssignTaskremoveGroupAssignmentIfBlank, nameof(tasksAssignTaskremoveGroupAssignmentIfBlank), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksSetOutputDataResponse> TasksSetOutputData(Expression<Func<int>> tasksSetOutputDatataskId, Expression<Func<string>> tasksSetOutputDatataskOutputData = null)
        {
            var __workflow_tasksSetOutputDatataskId = tasksSetOutputDatataskId == null ? null : WorkflowExpression.Compile(tasksSetOutputDatataskId);
            WorkflowExpression.Validate(__workflow_tasksSetOutputDatataskId, nameof(tasksSetOutputDatataskId), required: true);
            var __workflow_tasksSetOutputDatataskOutputData = tasksSetOutputDatataskOutputData == null ? null : WorkflowExpression.Compile(tasksSetOutputDatataskOutputData);
            WorkflowExpression.Validate(__workflow_tasksSetOutputDatataskOutputData, nameof(tasksSetOutputDatataskOutputData), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewTaskOperationResponse> TasksAddNewTaskOperation(Expression<Func<string>> tasksAddNewTaskOperationautomationName = null, Expression<Func<string>> tasksAddNewTaskOperationtaskInputData = null, Expression<Func<string>> tasksAddNewTaskOperationprocessStage = null, Expression<Func<int>> tasksAddNewTaskOperationpriority = null, Expression<Func<int>> tasksAddNewTaskOperationsLA = null, Expression<Func<string>> tasksAddNewTaskOperationorganisation = null, Expression<Func<string>> tasksAddNewTaskOperationdepartment = null, Expression<Func<string>> tasksAddNewTaskOperationdescription = null, Expression<Func<string>> tasksAddNewTaskOperationtags = null)
        {
            var __workflow_tasksAddNewTaskOperationautomationName = tasksAddNewTaskOperationautomationName == null ? null : WorkflowExpression.Compile(tasksAddNewTaskOperationautomationName);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskOperationautomationName, nameof(tasksAddNewTaskOperationautomationName), required: false);
            var __workflow_tasksAddNewTaskOperationtaskInputData = tasksAddNewTaskOperationtaskInputData == null ? null : WorkflowExpression.Compile(tasksAddNewTaskOperationtaskInputData);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskOperationtaskInputData, nameof(tasksAddNewTaskOperationtaskInputData), required: false);
            var __workflow_tasksAddNewTaskOperationprocessStage = tasksAddNewTaskOperationprocessStage == null ? null : WorkflowExpression.Compile(tasksAddNewTaskOperationprocessStage);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskOperationprocessStage, nameof(tasksAddNewTaskOperationprocessStage), required: false);
            var __workflow_tasksAddNewTaskOperationpriority = tasksAddNewTaskOperationpriority == null ? null : WorkflowExpression.Compile(tasksAddNewTaskOperationpriority);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskOperationpriority, nameof(tasksAddNewTaskOperationpriority), required: false);
            var __workflow_tasksAddNewTaskOperationsLA = tasksAddNewTaskOperationsLA == null ? null : WorkflowExpression.Compile(tasksAddNewTaskOperationsLA);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskOperationsLA, nameof(tasksAddNewTaskOperationsLA), required: false);
            var __workflow_tasksAddNewTaskOperationorganisation = tasksAddNewTaskOperationorganisation == null ? null : WorkflowExpression.Compile(tasksAddNewTaskOperationorganisation);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskOperationorganisation, nameof(tasksAddNewTaskOperationorganisation), required: false);
            var __workflow_tasksAddNewTaskOperationdepartment = tasksAddNewTaskOperationdepartment == null ? null : WorkflowExpression.Compile(tasksAddNewTaskOperationdepartment);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskOperationdepartment, nameof(tasksAddNewTaskOperationdepartment), required: false);
            var __workflow_tasksAddNewTaskOperationdescription = tasksAddNewTaskOperationdescription == null ? null : WorkflowExpression.Compile(tasksAddNewTaskOperationdescription);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskOperationdescription, nameof(tasksAddNewTaskOperationdescription), required: false);
            var __workflow_tasksAddNewTaskOperationtags = tasksAddNewTaskOperationtags == null ? null : WorkflowExpression.Compile(tasksAddNewTaskOperationtags);
            WorkflowExpression.Validate(__workflow_tasksAddNewTaskOperationtags, nameof(tasksAddNewTaskOperationtags), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewDeferralOperationResponse> TasksAddNewDeferralOperation(Expression<Func<string>> tasksAddNewDeferralOperationautomationName = null, Expression<Func<int>> tasksAddNewDeferralOperationdeferralTimeInMinutes = null, Expression<Func<string>> tasksAddNewDeferralOperationtaskInputData = null, Expression<Func<string>> tasksAddNewDeferralOperationdeferralStoredData = null, Expression<Func<string>> tasksAddNewDeferralOperationprocessStage = null, Expression<Func<int>> tasksAddNewDeferralOperationpriority = null, Expression<Func<string>> tasksAddNewDeferralOperationorganisation = null, Expression<Func<string>> tasksAddNewDeferralOperationdepartment = null, Expression<Func<string>> tasksAddNewDeferralOperationdescription = null, Expression<Func<string>> tasksAddNewDeferralOperationtags = null)
        {
            var __workflow_tasksAddNewDeferralOperationautomationName = tasksAddNewDeferralOperationautomationName == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralOperationautomationName);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralOperationautomationName, nameof(tasksAddNewDeferralOperationautomationName), required: false);
            var __workflow_tasksAddNewDeferralOperationdeferralTimeInMinutes = tasksAddNewDeferralOperationdeferralTimeInMinutes == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralOperationdeferralTimeInMinutes);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralOperationdeferralTimeInMinutes, nameof(tasksAddNewDeferralOperationdeferralTimeInMinutes), required: false);
            var __workflow_tasksAddNewDeferralOperationtaskInputData = tasksAddNewDeferralOperationtaskInputData == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralOperationtaskInputData);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralOperationtaskInputData, nameof(tasksAddNewDeferralOperationtaskInputData), required: false);
            var __workflow_tasksAddNewDeferralOperationdeferralStoredData = tasksAddNewDeferralOperationdeferralStoredData == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralOperationdeferralStoredData);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralOperationdeferralStoredData, nameof(tasksAddNewDeferralOperationdeferralStoredData), required: false);
            var __workflow_tasksAddNewDeferralOperationprocessStage = tasksAddNewDeferralOperationprocessStage == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralOperationprocessStage);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralOperationprocessStage, nameof(tasksAddNewDeferralOperationprocessStage), required: false);
            var __workflow_tasksAddNewDeferralOperationpriority = tasksAddNewDeferralOperationpriority == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralOperationpriority);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralOperationpriority, nameof(tasksAddNewDeferralOperationpriority), required: false);
            var __workflow_tasksAddNewDeferralOperationorganisation = tasksAddNewDeferralOperationorganisation == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralOperationorganisation);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralOperationorganisation, nameof(tasksAddNewDeferralOperationorganisation), required: false);
            var __workflow_tasksAddNewDeferralOperationdepartment = tasksAddNewDeferralOperationdepartment == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralOperationdepartment);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralOperationdepartment, nameof(tasksAddNewDeferralOperationdepartment), required: false);
            var __workflow_tasksAddNewDeferralOperationdescription = tasksAddNewDeferralOperationdescription == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralOperationdescription);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralOperationdescription, nameof(tasksAddNewDeferralOperationdescription), required: false);
            var __workflow_tasksAddNewDeferralOperationtags = tasksAddNewDeferralOperationtags == null ? null : WorkflowExpression.Compile(tasksAddNewDeferralOperationtags);
            WorkflowExpression.Validate(__workflow_tasksAddNewDeferralOperationtags, nameof(tasksAddNewDeferralOperationtags), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetTaskOperationResponse> TasksGetTaskOperation(Expression<Func<string>> tasksGetTaskOperationoperationId)
        {
            var __workflow_tasksGetTaskOperationoperationId = tasksGetTaskOperationoperationId == null ? null : WorkflowExpression.Compile(tasksGetTaskOperationoperationId);
            WorkflowExpression.Validate(__workflow_tasksGetTaskOperationoperationId, nameof(tasksGetTaskOperationoperationId), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRemoteLoggingLevel(Expression<Func<int>> setRemoteLoggingLevelloggingLevel, Expression<Func<string>> setRemoteLoggingLevelworkflow)
        {
            var __workflow_setRemoteLoggingLevelloggingLevel = setRemoteLoggingLevelloggingLevel == null ? null : WorkflowExpression.Compile(setRemoteLoggingLevelloggingLevel);
            WorkflowExpression.Validate(__workflow_setRemoteLoggingLevelloggingLevel, nameof(setRemoteLoggingLevelloggingLevel), required: true);
            var __workflow_setRemoteLoggingLevelworkflow = setRemoteLoggingLevelworkflow == null ? null : WorkflowExpression.Compile(setRemoteLoggingLevelworkflow);
            WorkflowExpression.Validate(__workflow_setRemoteLoggingLevelworkflow, nameof(setRemoteLoggingLevelworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteLoggingLevelResponse> GetRemoteLoggingLevel(Expression<Func<string>> getRemoteLoggingLevelworkflow)
        {
            var __workflow_getRemoteLoggingLevelworkflow = getRemoteLoggingLevelworkflow == null ? null : WorkflowExpression.Compile(getRemoteLoggingLevelworkflow);
            WorkflowExpression.Validate(__workflow_getRemoteLoggingLevelworkflow, nameof(getRemoteLoggingLevelworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetLicenseCode(Expression<Func<string>> setLicenseCodecustomerNETBIOSDomainName, Expression<Func<string>> setLicenseCodecustomerDisplayName, Expression<Func<string>> setLicenseCodevendorName, Expression<Func<string>> setLicenseCodelicenseExpiryDate, Expression<Func<string>> setLicenseCodeactivationCode, Expression<Func<string>> setLicenseCodeworkflow, Expression<Func<bool>> setLicenseCodestoreInRegistry = null)
        {
            var __workflow_setLicenseCodecustomerNETBIOSDomainName = setLicenseCodecustomerNETBIOSDomainName == null ? null : WorkflowExpression.Compile(setLicenseCodecustomerNETBIOSDomainName);
            WorkflowExpression.Validate(__workflow_setLicenseCodecustomerNETBIOSDomainName, nameof(setLicenseCodecustomerNETBIOSDomainName), required: true);
            var __workflow_setLicenseCodecustomerDisplayName = setLicenseCodecustomerDisplayName == null ? null : WorkflowExpression.Compile(setLicenseCodecustomerDisplayName);
            WorkflowExpression.Validate(__workflow_setLicenseCodecustomerDisplayName, nameof(setLicenseCodecustomerDisplayName), required: true);
            var __workflow_setLicenseCodevendorName = setLicenseCodevendorName == null ? null : WorkflowExpression.Compile(setLicenseCodevendorName);
            WorkflowExpression.Validate(__workflow_setLicenseCodevendorName, nameof(setLicenseCodevendorName), required: true);
            var __workflow_setLicenseCodelicenseExpiryDate = setLicenseCodelicenseExpiryDate == null ? null : WorkflowExpression.Compile(setLicenseCodelicenseExpiryDate);
            WorkflowExpression.Validate(__workflow_setLicenseCodelicenseExpiryDate, nameof(setLicenseCodelicenseExpiryDate), required: true);
            var __workflow_setLicenseCodeactivationCode = setLicenseCodeactivationCode == null ? null : WorkflowExpression.Compile(setLicenseCodeactivationCode);
            WorkflowExpression.Validate(__workflow_setLicenseCodeactivationCode, nameof(setLicenseCodeactivationCode), required: true);
            var __workflow_setLicenseCodeworkflow = setLicenseCodeworkflow == null ? null : WorkflowExpression.Compile(setLicenseCodeworkflow);
            WorkflowExpression.Validate(__workflow_setLicenseCodeworkflow, nameof(setLicenseCodeworkflow), required: true);
            var __workflow_setLicenseCodestoreInRegistry = setLicenseCodestoreInRegistry == null ? null : WorkflowExpression.Compile(setLicenseCodestoreInRegistry);
            WorkflowExpression.Validate(__workflow_setLicenseCodestoreInRegistry, nameof(setLicenseCodestoreInRegistry), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetLicenseStringResponse> SetLicenseString(Expression<Func<string>> setLicenseStringlicenseString, Expression<Func<string>> setLicenseStringworkflow, Expression<Func<bool>> setLicenseStringstoreInRegistry = null)
        {
            var __workflow_setLicenseStringlicenseString = setLicenseStringlicenseString == null ? null : WorkflowExpression.Compile(setLicenseStringlicenseString);
            WorkflowExpression.Validate(__workflow_setLicenseStringlicenseString, nameof(setLicenseStringlicenseString), required: true);
            var __workflow_setLicenseStringworkflow = setLicenseStringworkflow == null ? null : WorkflowExpression.Compile(setLicenseStringworkflow);
            WorkflowExpression.Validate(__workflow_setLicenseStringworkflow, nameof(setLicenseStringworkflow), required: true);
            var __workflow_setLicenseStringstoreInRegistry = setLicenseStringstoreInRegistry == null ? null : WorkflowExpression.Compile(setLicenseStringstoreInRegistry);
            WorkflowExpression.Validate(__workflow_setLicenseStringstoreInRegistry, nameof(setLicenseStringstoreInRegistry), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLicenseStateResponse> GetLicenseState(Expression<Func<string>> getLicenseStateworkflow)
        {
            var __workflow_getLicenseStateworkflow = getLicenseStateworkflow == null ? null : WorkflowExpression.Compile(getLicenseStateworkflow);
            WorkflowExpression.Validate(__workflow_getLicenseStateworkflow, nameof(getLicenseStateworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUITopmost(Expression<Func<string>> setRSAGUITopmostworkflow, Expression<Func<bool>> setRSAGUITopmosttopMost = null)
        {
            var __workflow_setRSAGUITopmostworkflow = setRSAGUITopmostworkflow == null ? null : WorkflowExpression.Compile(setRSAGUITopmostworkflow);
            WorkflowExpression.Validate(__workflow_setRSAGUITopmostworkflow, nameof(setRSAGUITopmostworkflow), required: true);
            var __workflow_setRSAGUITopmosttopMost = setRSAGUITopmosttopMost == null ? null : WorkflowExpression.Compile(setRSAGUITopmosttopMost);
            WorkflowExpression.Validate(__workflow_setRSAGUITopmosttopMost, nameof(setRSAGUITopmosttopMost), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUIOpacity(Expression<Func<double>> setRSAGUIOpacityopacity, Expression<Func<string>> setRSAGUIOpacityworkflow)
        {
            var __workflow_setRSAGUIOpacityopacity = setRSAGUIOpacityopacity == null ? null : WorkflowExpression.Compile(setRSAGUIOpacityopacity);
            WorkflowExpression.Validate(__workflow_setRSAGUIOpacityopacity, nameof(setRSAGUIOpacityopacity), required: true);
            var __workflow_setRSAGUIOpacityworkflow = setRSAGUIOpacityworkflow == null ? null : WorkflowExpression.Compile(setRSAGUIOpacityworkflow);
            WorkflowExpression.Validate(__workflow_setRSAGUIOpacityworkflow, nameof(setRSAGUIOpacityworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUIPosition(Expression<Func<int>> setRSAGUIPositionx, Expression<Func<int>> setRSAGUIPositiony, Expression<Func<string>> setRSAGUIPositionworkflow)
        {
            var __workflow_setRSAGUIPositionx = setRSAGUIPositionx == null ? null : WorkflowExpression.Compile(setRSAGUIPositionx);
            WorkflowExpression.Validate(__workflow_setRSAGUIPositionx, nameof(setRSAGUIPositionx), required: true);
            var __workflow_setRSAGUIPositiony = setRSAGUIPositiony == null ? null : WorkflowExpression.Compile(setRSAGUIPositiony);
            WorkflowExpression.Validate(__workflow_setRSAGUIPositiony, nameof(setRSAGUIPositiony), required: true);
            var __workflow_setRSAGUIPositionworkflow = setRSAGUIPositionworkflow == null ? null : WorkflowExpression.Compile(setRSAGUIPositionworkflow);
            WorkflowExpression.Validate(__workflow_setRSAGUIPositionworkflow, nameof(setRSAGUIPositionworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction BringRSAGUIToFront(Expression<Func<string>> bringRSAGUIToFrontworkflow, Expression<Func<bool>> bringRSAGUIToFrontfocus = null, Expression<Func<bool>> bringRSAGUIToFrontglobalLeftMouseClick = null)
        {
            var __workflow_bringRSAGUIToFrontworkflow = bringRSAGUIToFrontworkflow == null ? null : WorkflowExpression.Compile(bringRSAGUIToFrontworkflow);
            WorkflowExpression.Validate(__workflow_bringRSAGUIToFrontworkflow, nameof(bringRSAGUIToFrontworkflow), required: true);
            var __workflow_bringRSAGUIToFrontfocus = bringRSAGUIToFrontfocus == null ? null : WorkflowExpression.Compile(bringRSAGUIToFrontfocus);
            WorkflowExpression.Validate(__workflow_bringRSAGUIToFrontfocus, nameof(bringRSAGUIToFrontfocus), required: false);
            var __workflow_bringRSAGUIToFrontglobalLeftMouseClick = bringRSAGUIToFrontglobalLeftMouseClick == null ? null : WorkflowExpression.Compile(bringRSAGUIToFrontglobalLeftMouseClick);
            WorkflowExpression.Validate(__workflow_bringRSAGUIToFrontglobalLeftMouseClick, nameof(bringRSAGUIToFrontglobalLeftMouseClick), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DisconnectSession(Expression<Func<string>> disconnectSessionworkflow, Expression<Func<int>> disconnectSessionsecondsToWait = null, Expression<Func<bool>> disconnectSessiondoNotDisconnectIfLocalAgent = null)
        {
            var __workflow_disconnectSessionworkflow = disconnectSessionworkflow == null ? null : WorkflowExpression.Compile(disconnectSessionworkflow);
            WorkflowExpression.Validate(__workflow_disconnectSessionworkflow, nameof(disconnectSessionworkflow), required: true);
            var __workflow_disconnectSessionsecondsToWait = disconnectSessionsecondsToWait == null ? null : WorkflowExpression.Compile(disconnectSessionsecondsToWait);
            WorkflowExpression.Validate(__workflow_disconnectSessionsecondsToWait, nameof(disconnectSessionsecondsToWait), required: false);
            var __workflow_disconnectSessiondoNotDisconnectIfLocalAgent = disconnectSessiondoNotDisconnectIfLocalAgent == null ? null : WorkflowExpression.Compile(disconnectSessiondoNotDisconnectIfLocalAgent);
            WorkflowExpression.Validate(__workflow_disconnectSessiondoNotDisconnectIfLocalAgent, nameof(disconnectSessiondoNotDisconnectIfLocalAgent), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LogoffSession(Expression<Func<string>> logoffSessionworkflow, Expression<Func<int>> logoffSessionsecondsToWait = null)
        {
            var __workflow_logoffSessionworkflow = logoffSessionworkflow == null ? null : WorkflowExpression.Compile(logoffSessionworkflow);
            WorkflowExpression.Validate(__workflow_logoffSessionworkflow, nameof(logoffSessionworkflow), required: true);
            var __workflow_logoffSessionsecondsToWait = logoffSessionsecondsToWait == null ? null : WorkflowExpression.Compile(logoffSessionsecondsToWait);
            WorkflowExpression.Validate(__workflow_logoffSessionsecondsToWait, nameof(logoffSessionsecondsToWait), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CloseRSAServer(Expression<Func<string>> closeRSAServerworkflow, Expression<Func<int>> closeRSAServersecondsToWait = null)
        {
            var __workflow_closeRSAServerworkflow = closeRSAServerworkflow == null ? null : WorkflowExpression.Compile(closeRSAServerworkflow);
            WorkflowExpression.Validate(__workflow_closeRSAServerworkflow, nameof(closeRSAServerworkflow), required: true);
            var __workflow_closeRSAServersecondsToWait = closeRSAServersecondsToWait == null ? null : WorkflowExpression.Compile(closeRSAServersecondsToWait);
            WorkflowExpression.Validate(__workflow_closeRSAServersecondsToWait, nameof(closeRSAServersecondsToWait), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRPACommandTimeout(Expression<Func<int>> setRPACommandTimeoutcommandTimeoutInSeconds, Expression<Func<string>> setRPACommandTimeoutworkflow, Expression<Func<bool>> setRPACommandTimeoutterminateTimedoutRPACommandThreads = null)
        {
            var __workflow_setRPACommandTimeoutcommandTimeoutInSeconds = setRPACommandTimeoutcommandTimeoutInSeconds == null ? null : WorkflowExpression.Compile(setRPACommandTimeoutcommandTimeoutInSeconds);
            WorkflowExpression.Validate(__workflow_setRPACommandTimeoutcommandTimeoutInSeconds, nameof(setRPACommandTimeoutcommandTimeoutInSeconds), required: true);
            var __workflow_setRPACommandTimeoutworkflow = setRPACommandTimeoutworkflow == null ? null : WorkflowExpression.Compile(setRPACommandTimeoutworkflow);
            WorkflowExpression.Validate(__workflow_setRPACommandTimeoutworkflow, nameof(setRPACommandTimeoutworkflow), required: true);
            var __workflow_setRPACommandTimeoutterminateTimedoutRPACommandThreads = setRPACommandTimeoutterminateTimedoutRPACommandThreads == null ? null : WorkflowExpression.Compile(setRPACommandTimeoutterminateTimedoutRPACommandThreads);
            WorkflowExpression.Validate(__workflow_setRPACommandTimeoutterminateTimedoutRPACommandThreads, nameof(setRPACommandTimeoutterminateTimedoutRPACommandThreads), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RunAlternativeIAConnect(Expression<Func<string>> runAlternativeIAConnectfilename, Expression<Func<string>> runAlternativeIAConnectworkflow, Expression<Func<string>> runAlternativeIAConnectarguments = null, Expression<Func<bool>> runAlternativeIAConnectloadIntoMemory = null)
        {
            var __workflow_runAlternativeIAConnectfilename = runAlternativeIAConnectfilename == null ? null : WorkflowExpression.Compile(runAlternativeIAConnectfilename);
            WorkflowExpression.Validate(__workflow_runAlternativeIAConnectfilename, nameof(runAlternativeIAConnectfilename), required: true);
            var __workflow_runAlternativeIAConnectworkflow = runAlternativeIAConnectworkflow == null ? null : WorkflowExpression.Compile(runAlternativeIAConnectworkflow);
            WorkflowExpression.Validate(__workflow_runAlternativeIAConnectworkflow, nameof(runAlternativeIAConnectworkflow), required: true);
            var __workflow_runAlternativeIAConnectarguments = runAlternativeIAConnectarguments == null ? null : WorkflowExpression.Compile(runAlternativeIAConnectarguments);
            WorkflowExpression.Validate(__workflow_runAlternativeIAConnectarguments, nameof(runAlternativeIAConnectarguments), required: false);
            var __workflow_runAlternativeIAConnectloadIntoMemory = runAlternativeIAConnectloadIntoMemory == null ? null : WorkflowExpression.Compile(runAlternativeIAConnectloadIntoMemory);
            WorkflowExpression.Validate(__workflow_runAlternativeIAConnectloadIntoMemory, nameof(runAlternativeIAConnectloadIntoMemory), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunAlternativeIAConnectSentFromDirectorResponse> RunAlternativeIAConnectSentFromDirector(Expression<Func<string>> runAlternativeIAConnectSentFromDirectorlocalFilename, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorworkflow, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorremoteFilename = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorcompress = null, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorarguments = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorpermitDowngrade = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorskipVersionCheck = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorloadIntoMemory = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory = null)
        {
            var __workflow_runAlternativeIAConnectSentFromDirectorlocalFilename = runAlternativeIAConnectSentFromDirectorlocalFilename == null ? null : WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorlocalFilename);
            WorkflowExpression.Validate(__workflow_runAlternativeIAConnectSentFromDirectorlocalFilename, nameof(runAlternativeIAConnectSentFromDirectorlocalFilename), required: true);
            var __workflow_runAlternativeIAConnectSentFromDirectorworkflow = runAlternativeIAConnectSentFromDirectorworkflow == null ? null : WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorworkflow);
            WorkflowExpression.Validate(__workflow_runAlternativeIAConnectSentFromDirectorworkflow, nameof(runAlternativeIAConnectSentFromDirectorworkflow), required: true);
            var __workflow_runAlternativeIAConnectSentFromDirectorremoteFilename = runAlternativeIAConnectSentFromDirectorremoteFilename == null ? null : WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorremoteFilename);
            WorkflowExpression.Validate(__workflow_runAlternativeIAConnectSentFromDirectorremoteFilename, nameof(runAlternativeIAConnectSentFromDirectorremoteFilename), required: false);
            var __workflow_runAlternativeIAConnectSentFromDirectorcompress = runAlternativeIAConnectSentFromDirectorcompress == null ? null : WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorcompress);
            WorkflowExpression.Validate(__workflow_runAlternativeIAConnectSentFromDirectorcompress, nameof(runAlternativeIAConnectSentFromDirectorcompress), required: false);
            var __workflow_runAlternativeIAConnectSentFromDirectorarguments = runAlternativeIAConnectSentFromDirectorarguments == null ? null : WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorarguments);
            WorkflowExpression.Validate(__workflow_runAlternativeIAConnectSentFromDirectorarguments, nameof(runAlternativeIAConnectSentFromDirectorarguments), required: false);
            var __workflow_runAlternativeIAConnectSentFromDirectorpermitDowngrade = runAlternativeIAConnectSentFromDirectorpermitDowngrade == null ? null : WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorpermitDowngrade);
            WorkflowExpression.Validate(__workflow_runAlternativeIAConnectSentFromDirectorpermitDowngrade, nameof(runAlternativeIAConnectSentFromDirectorpermitDowngrade), required: false);
            var __workflow_runAlternativeIAConnectSentFromDirectorskipVersionCheck = runAlternativeIAConnectSentFromDirectorskipVersionCheck == null ? null : WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorskipVersionCheck);
            WorkflowExpression.Validate(__workflow_runAlternativeIAConnectSentFromDirectorskipVersionCheck, nameof(runAlternativeIAConnectSentFromDirectorskipVersionCheck), required: false);
            var __workflow_runAlternativeIAConnectSentFromDirectorloadIntoMemory = runAlternativeIAConnectSentFromDirectorloadIntoMemory == null ? null : WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorloadIntoMemory);
            WorkflowExpression.Validate(__workflow_runAlternativeIAConnectSentFromDirectorloadIntoMemory, nameof(runAlternativeIAConnectSentFromDirectorloadIntoMemory), required: false);
            var __workflow_runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory = runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory == null ? null : WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory);
            WorkflowExpression.Validate(__workflow_runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory, nameof(runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectAgentInfoResponse> GetIAConnectAgentInfo(Expression<Func<string>> getIAConnectAgentInfoworkflow)
        {
            var __workflow_getIAConnectAgentInfoworkflow = getIAConnectAgentInfoworkflow == null ? null : WorkflowExpression.Compile(getIAConnectAgentInfoworkflow);
            WorkflowExpression.Validate(__workflow_getIAConnectAgentInfoworkflow, nameof(getIAConnectAgentInfoworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectAgentLogResponse> GetIAConnectAgentLog(Expression<Func<string>> getIAConnectAgentLogworkflow, Expression<Func<bool>> getIAConnectAgentLogcompress = null, Expression<Func<bool>> getIAConnectAgentLogreturnLastCommandOnly = null, Expression<Func<bool>> getIAConnectAgentLogsaveLogToFile = null, Expression<Func<bool>> getIAConnectAgentLogplaceLogContentInDataItem = null, Expression<Func<string>> getIAConnectAgentLoglocalSaveFolder = null, Expression<Func<bool>> getIAConnectAgentLoguseAgentLogFilename = null, Expression<Func<string>> getIAConnectAgentLoglocalSaveFilename = null, Expression<Func<int>> getIAConnectAgentLogmaxBytesToRead = null)
        {
            var __workflow_getIAConnectAgentLogworkflow = getIAConnectAgentLogworkflow == null ? null : WorkflowExpression.Compile(getIAConnectAgentLogworkflow);
            WorkflowExpression.Validate(__workflow_getIAConnectAgentLogworkflow, nameof(getIAConnectAgentLogworkflow), required: true);
            var __workflow_getIAConnectAgentLogcompress = getIAConnectAgentLogcompress == null ? null : WorkflowExpression.Compile(getIAConnectAgentLogcompress);
            WorkflowExpression.Validate(__workflow_getIAConnectAgentLogcompress, nameof(getIAConnectAgentLogcompress), required: false);
            var __workflow_getIAConnectAgentLogreturnLastCommandOnly = getIAConnectAgentLogreturnLastCommandOnly == null ? null : WorkflowExpression.Compile(getIAConnectAgentLogreturnLastCommandOnly);
            WorkflowExpression.Validate(__workflow_getIAConnectAgentLogreturnLastCommandOnly, nameof(getIAConnectAgentLogreturnLastCommandOnly), required: false);
            var __workflow_getIAConnectAgentLogsaveLogToFile = getIAConnectAgentLogsaveLogToFile == null ? null : WorkflowExpression.Compile(getIAConnectAgentLogsaveLogToFile);
            WorkflowExpression.Validate(__workflow_getIAConnectAgentLogsaveLogToFile, nameof(getIAConnectAgentLogsaveLogToFile), required: false);
            var __workflow_getIAConnectAgentLogplaceLogContentInDataItem = getIAConnectAgentLogplaceLogContentInDataItem == null ? null : WorkflowExpression.Compile(getIAConnectAgentLogplaceLogContentInDataItem);
            WorkflowExpression.Validate(__workflow_getIAConnectAgentLogplaceLogContentInDataItem, nameof(getIAConnectAgentLogplaceLogContentInDataItem), required: false);
            var __workflow_getIAConnectAgentLoglocalSaveFolder = getIAConnectAgentLoglocalSaveFolder == null ? null : WorkflowExpression.Compile(getIAConnectAgentLoglocalSaveFolder);
            WorkflowExpression.Validate(__workflow_getIAConnectAgentLoglocalSaveFolder, nameof(getIAConnectAgentLoglocalSaveFolder), required: false);
            var __workflow_getIAConnectAgentLoguseAgentLogFilename = getIAConnectAgentLoguseAgentLogFilename == null ? null : WorkflowExpression.Compile(getIAConnectAgentLoguseAgentLogFilename);
            WorkflowExpression.Validate(__workflow_getIAConnectAgentLoguseAgentLogFilename, nameof(getIAConnectAgentLoguseAgentLogFilename), required: false);
            var __workflow_getIAConnectAgentLoglocalSaveFilename = getIAConnectAgentLoglocalSaveFilename == null ? null : WorkflowExpression.Compile(getIAConnectAgentLoglocalSaveFilename);
            WorkflowExpression.Validate(__workflow_getIAConnectAgentLoglocalSaveFilename, nameof(getIAConnectAgentLoglocalSaveFilename), required: false);
            var __workflow_getIAConnectAgentLogmaxBytesToRead = getIAConnectAgentLogmaxBytesToRead == null ? null : WorkflowExpression.Compile(getIAConnectAgentLogmaxBytesToRead);
            WorkflowExpression.Validate(__workflow_getIAConnectAgentLogmaxBytesToRead, nameof(getIAConnectAgentLogmaxBytesToRead), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ResetCommandStats(Expression<Func<string>> resetCommandStatsworkflow)
        {
            var __workflow_resetCommandStatsworkflow = resetCommandStatsworkflow == null ? null : WorkflowExpression.Compile(resetCommandStatsworkflow);
            WorkflowExpression.Validate(__workflow_resetCommandStatsworkflow, nameof(resetCommandStatsworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAllCommandStatsResponse> GetAllCommandStats(Expression<Func<string>> getAllCommandStatsworkflow)
        {
            var __workflow_getAllCommandStatsworkflow = getAllCommandStatsworkflow == null ? null : WorkflowExpression.Compile(getAllCommandStatsworkflow);
            WorkflowExpression.Validate(__workflow_getAllCommandStatsworkflow, nameof(getAllCommandStatsworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<EnableNextHopResponse> EnableNextHop(Expression<Func<string>> enableNextHopworkflow, Expression<Func<string>> enableNextHopnextHopDirectorAddress = null, Expression<Func<int>> enableNextHopnextHopDirectorTCPPort = null, Expression<Func<bool>> enableNextHopnextHopDirectorUsesHTTPS = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsLocalhostname = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsHostname = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsFQDN = null, Expression<Func<bool>> enableNextHopincrementNextHopDirectorTCPPortBySessionId = null, Expression<Func<bool>> enableNextHopdisableBeforeEnable = null, Expression<Func<bool>> enableNextHopcheckNextHopDirectorIsRunning = null, Expression<Func<bool>> enableNextHopcheckNextHopAgentIsRunning = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsNamedPipe = null)
        {
            var __workflow_enableNextHopworkflow = enableNextHopworkflow == null ? null : WorkflowExpression.Compile(enableNextHopworkflow);
            WorkflowExpression.Validate(__workflow_enableNextHopworkflow, nameof(enableNextHopworkflow), required: true);
            var __workflow_enableNextHopnextHopDirectorAddress = enableNextHopnextHopDirectorAddress == null ? null : WorkflowExpression.Compile(enableNextHopnextHopDirectorAddress);
            WorkflowExpression.Validate(__workflow_enableNextHopnextHopDirectorAddress, nameof(enableNextHopnextHopDirectorAddress), required: false);
            var __workflow_enableNextHopnextHopDirectorTCPPort = enableNextHopnextHopDirectorTCPPort == null ? null : WorkflowExpression.Compile(enableNextHopnextHopDirectorTCPPort);
            WorkflowExpression.Validate(__workflow_enableNextHopnextHopDirectorTCPPort, nameof(enableNextHopnextHopDirectorTCPPort), required: false);
            var __workflow_enableNextHopnextHopDirectorUsesHTTPS = enableNextHopnextHopDirectorUsesHTTPS == null ? null : WorkflowExpression.Compile(enableNextHopnextHopDirectorUsesHTTPS);
            WorkflowExpression.Validate(__workflow_enableNextHopnextHopDirectorUsesHTTPS, nameof(enableNextHopnextHopDirectorUsesHTTPS), required: false);
            var __workflow_enableNextHopnextHopDirectorAddressIsLocalhostname = enableNextHopnextHopDirectorAddressIsLocalhostname == null ? null : WorkflowExpression.Compile(enableNextHopnextHopDirectorAddressIsLocalhostname);
            WorkflowExpression.Validate(__workflow_enableNextHopnextHopDirectorAddressIsLocalhostname, nameof(enableNextHopnextHopDirectorAddressIsLocalhostname), required: false);
            var __workflow_enableNextHopnextHopDirectorAddressIsHostname = enableNextHopnextHopDirectorAddressIsHostname == null ? null : WorkflowExpression.Compile(enableNextHopnextHopDirectorAddressIsHostname);
            WorkflowExpression.Validate(__workflow_enableNextHopnextHopDirectorAddressIsHostname, nameof(enableNextHopnextHopDirectorAddressIsHostname), required: false);
            var __workflow_enableNextHopnextHopDirectorAddressIsFQDN = enableNextHopnextHopDirectorAddressIsFQDN == null ? null : WorkflowExpression.Compile(enableNextHopnextHopDirectorAddressIsFQDN);
            WorkflowExpression.Validate(__workflow_enableNextHopnextHopDirectorAddressIsFQDN, nameof(enableNextHopnextHopDirectorAddressIsFQDN), required: false);
            var __workflow_enableNextHopincrementNextHopDirectorTCPPortBySessionId = enableNextHopincrementNextHopDirectorTCPPortBySessionId == null ? null : WorkflowExpression.Compile(enableNextHopincrementNextHopDirectorTCPPortBySessionId);
            WorkflowExpression.Validate(__workflow_enableNextHopincrementNextHopDirectorTCPPortBySessionId, nameof(enableNextHopincrementNextHopDirectorTCPPortBySessionId), required: false);
            var __workflow_enableNextHopdisableBeforeEnable = enableNextHopdisableBeforeEnable == null ? null : WorkflowExpression.Compile(enableNextHopdisableBeforeEnable);
            WorkflowExpression.Validate(__workflow_enableNextHopdisableBeforeEnable, nameof(enableNextHopdisableBeforeEnable), required: false);
            var __workflow_enableNextHopcheckNextHopDirectorIsRunning = enableNextHopcheckNextHopDirectorIsRunning == null ? null : WorkflowExpression.Compile(enableNextHopcheckNextHopDirectorIsRunning);
            WorkflowExpression.Validate(__workflow_enableNextHopcheckNextHopDirectorIsRunning, nameof(enableNextHopcheckNextHopDirectorIsRunning), required: false);
            var __workflow_enableNextHopcheckNextHopAgentIsRunning = enableNextHopcheckNextHopAgentIsRunning == null ? null : WorkflowExpression.Compile(enableNextHopcheckNextHopAgentIsRunning);
            WorkflowExpression.Validate(__workflow_enableNextHopcheckNextHopAgentIsRunning, nameof(enableNextHopcheckNextHopAgentIsRunning), required: false);
            var __workflow_enableNextHopnextHopDirectorAddressIsNamedPipe = enableNextHopnextHopDirectorAddressIsNamedPipe == null ? null : WorkflowExpression.Compile(enableNextHopnextHopDirectorAddressIsNamedPipe);
            WorkflowExpression.Validate(__workflow_enableNextHopnextHopDirectorAddressIsNamedPipe, nameof(enableNextHopnextHopDirectorAddressIsNamedPipe), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DisableNextHop(Expression<Func<string>> disableNextHopworkflow)
        {
            var __workflow_disableNextHopworkflow = disableNextHopworkflow == null ? null : WorkflowExpression.Compile(disableNextHopworkflow);
            WorkflowExpression.Validate(__workflow_disableNextHopworkflow, nameof(disableNextHopworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetNextHopStatusResponse> GetNextHopStatus(Expression<Func<string>> getNextHopStatusworkflow, Expression<Func<bool>> getNextHopStatuscheckNextHopDirectorIsRunning = null, Expression<Func<bool>> getNextHopStatuscheckNextHopAgentIsRunning = null)
        {
            var __workflow_getNextHopStatusworkflow = getNextHopStatusworkflow == null ? null : WorkflowExpression.Compile(getNextHopStatusworkflow);
            WorkflowExpression.Validate(__workflow_getNextHopStatusworkflow, nameof(getNextHopStatusworkflow), required: true);
            var __workflow_getNextHopStatuscheckNextHopDirectorIsRunning = getNextHopStatuscheckNextHopDirectorIsRunning == null ? null : WorkflowExpression.Compile(getNextHopStatuscheckNextHopDirectorIsRunning);
            WorkflowExpression.Validate(__workflow_getNextHopStatuscheckNextHopDirectorIsRunning, nameof(getNextHopStatuscheckNextHopDirectorIsRunning), required: false);
            var __workflow_getNextHopStatuscheckNextHopAgentIsRunning = getNextHopStatuscheckNextHopAgentIsRunning == null ? null : WorkflowExpression.Compile(getNextHopStatuscheckNextHopAgentIsRunning);
            WorkflowExpression.Validate(__workflow_getNextHopStatuscheckNextHopAgentIsRunning, nameof(getNextHopStatuscheckNextHopAgentIsRunning), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForNextHopSessionToConnectResponse> WaitForNextHopSessionToConnect(Expression<Func<string>> waitForNextHopSessionToConnectworkflow, Expression<Func<string>> waitForNextHopSessionToConnectnextHopDirectorAddress = null, Expression<Func<int>> waitForNextHopSessionToConnectnextHopDirectorTCPPort = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN = null, Expression<Func<bool>> waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId = null, Expression<Func<double>> waitForNextHopSessionToConnectsecondsToWait = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe = null, Expression<Func<bool>> waitForNextHopSessionToConnectdisableExistingNextHop = null)
        {
            var __workflow_waitForNextHopSessionToConnectworkflow = waitForNextHopSessionToConnectworkflow == null ? null : WorkflowExpression.Compile(waitForNextHopSessionToConnectworkflow);
            WorkflowExpression.Validate(__workflow_waitForNextHopSessionToConnectworkflow, nameof(waitForNextHopSessionToConnectworkflow), required: true);
            var __workflow_waitForNextHopSessionToConnectnextHopDirectorAddress = waitForNextHopSessionToConnectnextHopDirectorAddress == null ? null : WorkflowExpression.Compile(waitForNextHopSessionToConnectnextHopDirectorAddress);
            WorkflowExpression.Validate(__workflow_waitForNextHopSessionToConnectnextHopDirectorAddress, nameof(waitForNextHopSessionToConnectnextHopDirectorAddress), required: false);
            var __workflow_waitForNextHopSessionToConnectnextHopDirectorTCPPort = waitForNextHopSessionToConnectnextHopDirectorTCPPort == null ? null : WorkflowExpression.Compile(waitForNextHopSessionToConnectnextHopDirectorTCPPort);
            WorkflowExpression.Validate(__workflow_waitForNextHopSessionToConnectnextHopDirectorTCPPort, nameof(waitForNextHopSessionToConnectnextHopDirectorTCPPort), required: false);
            var __workflow_waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS = waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS == null ? null : WorkflowExpression.Compile(waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS);
            WorkflowExpression.Validate(__workflow_waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS, nameof(waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS), required: false);
            var __workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname = waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname == null ? null : WorkflowExpression.Compile(waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname);
            WorkflowExpression.Validate(__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname, nameof(waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname), required: false);
            var __workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname = waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname == null ? null : WorkflowExpression.Compile(waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname);
            WorkflowExpression.Validate(__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname, nameof(waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname), required: false);
            var __workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN = waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN == null ? null : WorkflowExpression.Compile(waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN);
            WorkflowExpression.Validate(__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN, nameof(waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN), required: false);
            var __workflow_waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId = waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId == null ? null : WorkflowExpression.Compile(waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId);
            WorkflowExpression.Validate(__workflow_waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId, nameof(waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId), required: false);
            var __workflow_waitForNextHopSessionToConnectsecondsToWait = waitForNextHopSessionToConnectsecondsToWait == null ? null : WorkflowExpression.Compile(waitForNextHopSessionToConnectsecondsToWait);
            WorkflowExpression.Validate(__workflow_waitForNextHopSessionToConnectsecondsToWait, nameof(waitForNextHopSessionToConnectsecondsToWait), required: false);
            var __workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe = waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe == null ? null : WorkflowExpression.Compile(waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe);
            WorkflowExpression.Validate(__workflow_waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe, nameof(waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe), required: false);
            var __workflow_waitForNextHopSessionToConnectdisableExistingNextHop = waitForNextHopSessionToConnectdisableExistingNextHop == null ? null : WorkflowExpression.Compile(waitForNextHopSessionToConnectdisableExistingNextHop);
            WorkflowExpression.Validate(__workflow_waitForNextHopSessionToConnectdisableExistingNextHop, nameof(waitForNextHopSessionToConnectdisableExistingNextHop), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ConfigureNextHopDirector(Expression<Func<string>> configureNextHopDirectorworkflow, Expression<Func<bool>> configureNextHopDirectorsOAPEnabled = null, Expression<Func<bool>> configureNextHopDirectorrESTEnabled = null, Expression<Func<bool>> configureNextHopDirectorwebServerEnabled = null, Expression<Func<bool>> configureNextHopDirectordirectorIsLocalhostOnly = null, Expression<Func<int>> configureNextHopDirectorsOAPTCPPort = null, Expression<Func<int>> configureNextHopDirectorrESTTCPPort = null, Expression<Func<bool>> configureNextHopDirectorsOAPUsesHTTPS = null, Expression<Func<bool>> configureNextHopDirectorrESTUsesHTTPS = null, Expression<Func<bool>> configureNextHopDirectorincrementDirectorTCPPortBySessionId = null, Expression<Func<bool>> configureNextHopDirectorsOAPUsesUserAuthentication = null, Expression<Func<bool>> configureNextHopDirectorrESTUsesUserAuthentication = null, Expression<Func<bool>> configureNextHopDirectorcommandNamedPipeEnabled = null)
        {
            var __workflow_configureNextHopDirectorworkflow = configureNextHopDirectorworkflow == null ? null : WorkflowExpression.Compile(configureNextHopDirectorworkflow);
            WorkflowExpression.Validate(__workflow_configureNextHopDirectorworkflow, nameof(configureNextHopDirectorworkflow), required: true);
            var __workflow_configureNextHopDirectorsOAPEnabled = configureNextHopDirectorsOAPEnabled == null ? null : WorkflowExpression.Compile(configureNextHopDirectorsOAPEnabled);
            WorkflowExpression.Validate(__workflow_configureNextHopDirectorsOAPEnabled, nameof(configureNextHopDirectorsOAPEnabled), required: false);
            var __workflow_configureNextHopDirectorrESTEnabled = configureNextHopDirectorrESTEnabled == null ? null : WorkflowExpression.Compile(configureNextHopDirectorrESTEnabled);
            WorkflowExpression.Validate(__workflow_configureNextHopDirectorrESTEnabled, nameof(configureNextHopDirectorrESTEnabled), required: false);
            var __workflow_configureNextHopDirectorwebServerEnabled = configureNextHopDirectorwebServerEnabled == null ? null : WorkflowExpression.Compile(configureNextHopDirectorwebServerEnabled);
            WorkflowExpression.Validate(__workflow_configureNextHopDirectorwebServerEnabled, nameof(configureNextHopDirectorwebServerEnabled), required: false);
            var __workflow_configureNextHopDirectordirectorIsLocalhostOnly = configureNextHopDirectordirectorIsLocalhostOnly == null ? null : WorkflowExpression.Compile(configureNextHopDirectordirectorIsLocalhostOnly);
            WorkflowExpression.Validate(__workflow_configureNextHopDirectordirectorIsLocalhostOnly, nameof(configureNextHopDirectordirectorIsLocalhostOnly), required: false);
            var __workflow_configureNextHopDirectorsOAPTCPPort = configureNextHopDirectorsOAPTCPPort == null ? null : WorkflowExpression.Compile(configureNextHopDirectorsOAPTCPPort);
            WorkflowExpression.Validate(__workflow_configureNextHopDirectorsOAPTCPPort, nameof(configureNextHopDirectorsOAPTCPPort), required: false);
            var __workflow_configureNextHopDirectorrESTTCPPort = configureNextHopDirectorrESTTCPPort == null ? null : WorkflowExpression.Compile(configureNextHopDirectorrESTTCPPort);
            WorkflowExpression.Validate(__workflow_configureNextHopDirectorrESTTCPPort, nameof(configureNextHopDirectorrESTTCPPort), required: false);
            var __workflow_configureNextHopDirectorsOAPUsesHTTPS = configureNextHopDirectorsOAPUsesHTTPS == null ? null : WorkflowExpression.Compile(configureNextHopDirectorsOAPUsesHTTPS);
            WorkflowExpression.Validate(__workflow_configureNextHopDirectorsOAPUsesHTTPS, nameof(configureNextHopDirectorsOAPUsesHTTPS), required: false);
            var __workflow_configureNextHopDirectorrESTUsesHTTPS = configureNextHopDirectorrESTUsesHTTPS == null ? null : WorkflowExpression.Compile(configureNextHopDirectorrESTUsesHTTPS);
            WorkflowExpression.Validate(__workflow_configureNextHopDirectorrESTUsesHTTPS, nameof(configureNextHopDirectorrESTUsesHTTPS), required: false);
            var __workflow_configureNextHopDirectorincrementDirectorTCPPortBySessionId = configureNextHopDirectorincrementDirectorTCPPortBySessionId == null ? null : WorkflowExpression.Compile(configureNextHopDirectorincrementDirectorTCPPortBySessionId);
            WorkflowExpression.Validate(__workflow_configureNextHopDirectorincrementDirectorTCPPortBySessionId, nameof(configureNextHopDirectorincrementDirectorTCPPortBySessionId), required: false);
            var __workflow_configureNextHopDirectorsOAPUsesUserAuthentication = configureNextHopDirectorsOAPUsesUserAuthentication == null ? null : WorkflowExpression.Compile(configureNextHopDirectorsOAPUsesUserAuthentication);
            WorkflowExpression.Validate(__workflow_configureNextHopDirectorsOAPUsesUserAuthentication, nameof(configureNextHopDirectorsOAPUsesUserAuthentication), required: false);
            var __workflow_configureNextHopDirectorrESTUsesUserAuthentication = configureNextHopDirectorrESTUsesUserAuthentication == null ? null : WorkflowExpression.Compile(configureNextHopDirectorrESTUsesUserAuthentication);
            WorkflowExpression.Validate(__workflow_configureNextHopDirectorrESTUsesUserAuthentication, nameof(configureNextHopDirectorrESTUsesUserAuthentication), required: false);
            var __workflow_configureNextHopDirectorcommandNamedPipeEnabled = configureNextHopDirectorcommandNamedPipeEnabled == null ? null : WorkflowExpression.Compile(configureNextHopDirectorcommandNamedPipeEnabled);
            WorkflowExpression.Validate(__workflow_configureNextHopDirectorcommandNamedPipeEnabled, nameof(configureNextHopDirectorcommandNamedPipeEnabled), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ResetNextHopDirectorSettings(Expression<Func<string>> resetNextHopDirectorSettingsworkflow)
        {
            var __workflow_resetNextHopDirectorSettingsworkflow = resetNextHopDirectorSettingsworkflow == null ? null : WorkflowExpression.Compile(resetNextHopDirectorSettingsworkflow);
            WorkflowExpression.Validate(__workflow_resetNextHopDirectorSettingsworkflow, nameof(resetNextHopDirectorSettingsworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WorkflowCompleted(Expression<Func<string>> workflowCompletedworkflow)
        {
            var __workflow_workflowCompletedworkflow = workflowCompletedworkflow == null ? null : WorkflowExpression.Compile(workflowCompletedworkflow);
            WorkflowExpression.Validate(__workflow_workflowCompletedworkflow, nameof(workflowCompletedworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RaiseExceptionResponse> RaiseException(Expression<Func<string>> raiseExceptioninputException = null, Expression<Func<string>> raiseExceptionexceptionMessage = null)
        {
            var __workflow_raiseExceptioninputException = raiseExceptioninputException == null ? null : WorkflowExpression.Compile(raiseExceptioninputException);
            WorkflowExpression.Validate(__workflow_raiseExceptioninputException, nameof(raiseExceptioninputException), required: false);
            var __workflow_raiseExceptionexceptionMessage = raiseExceptionexceptionMessage == null ? null : WorkflowExpression.Compile(raiseExceptionexceptionMessage);
            WorkflowExpression.Validate(__workflow_raiseExceptionexceptionMessage, nameof(raiseExceptionexceptionMessage), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UpdateOrchestratorFlowStatsResultResponse> UpdateOrchestratorFlowStatsResult(Expression<Func<string>> updateOrchestratorFlowStatsResultworkflow, Expression<Func<bool>> updateOrchestratorFlowStatsResultflowLastActionSuccess = null, Expression<Func<string>> updateOrchestratorFlowStatsResultflowLastActionErrorMessage = null, Expression<Func<int>> updateOrchestratorFlowStatsResultflowLastActionCode = null)
        {
            var __workflow_updateOrchestratorFlowStatsResultworkflow = updateOrchestratorFlowStatsResultworkflow == null ? null : WorkflowExpression.Compile(updateOrchestratorFlowStatsResultworkflow);
            WorkflowExpression.Validate(__workflow_updateOrchestratorFlowStatsResultworkflow, nameof(updateOrchestratorFlowStatsResultworkflow), required: true);
            var __workflow_updateOrchestratorFlowStatsResultflowLastActionSuccess = updateOrchestratorFlowStatsResultflowLastActionSuccess == null ? null : WorkflowExpression.Compile(updateOrchestratorFlowStatsResultflowLastActionSuccess);
            WorkflowExpression.Validate(__workflow_updateOrchestratorFlowStatsResultflowLastActionSuccess, nameof(updateOrchestratorFlowStatsResultflowLastActionSuccess), required: false);
            var __workflow_updateOrchestratorFlowStatsResultflowLastActionErrorMessage = updateOrchestratorFlowStatsResultflowLastActionErrorMessage == null ? null : WorkflowExpression.Compile(updateOrchestratorFlowStatsResultflowLastActionErrorMessage);
            WorkflowExpression.Validate(__workflow_updateOrchestratorFlowStatsResultflowLastActionErrorMessage, nameof(updateOrchestratorFlowStatsResultflowLastActionErrorMessage), required: false);
            var __workflow_updateOrchestratorFlowStatsResultflowLastActionCode = updateOrchestratorFlowStatsResultflowLastActionCode == null ? null : WorkflowExpression.Compile(updateOrchestratorFlowStatsResultflowLastActionCode);
            WorkflowExpression.Validate(__workflow_updateOrchestratorFlowStatsResultflowLastActionCode, nameof(updateOrchestratorFlowStatsResultflowLastActionCode), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLastFailedActionFromOrchestratorFlowStatsResponse> GetLastFailedActionFromOrchestratorFlowStats(Expression<Func<string>> getLastFailedActionFromOrchestratorFlowStatsworkflow)
        {
            var __workflow_getLastFailedActionFromOrchestratorFlowStatsworkflow = getLastFailedActionFromOrchestratorFlowStatsworkflow == null ? null : WorkflowExpression.Compile(getLastFailedActionFromOrchestratorFlowStatsworkflow);
            WorkflowExpression.Validate(__workflow_getLastFailedActionFromOrchestratorFlowStatsworkflow, nameof(getLastFailedActionFromOrchestratorFlowStatsworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorFlowStatsResponse> GetOrchestratorFlowStats(Expression<Func<int>> getOrchestratorFlowStatswithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorFlowStatssearchFlowName = null, Expression<Func<bool>> getOrchestratorFlowStatssearchFlowLastActionResult = null, Expression<Func<string>> getOrchestratorFlowStatssearchFlowStartTimeStartWindow = null, Expression<Func<string>> getOrchestratorFlowStatssearchFlowStartTimeEndWindow = null)
        {
            var __workflow_getOrchestratorFlowStatswithinLastNumberOfDays = getOrchestratorFlowStatswithinLastNumberOfDays == null ? null : WorkflowExpression.Compile(getOrchestratorFlowStatswithinLastNumberOfDays);
            WorkflowExpression.Validate(__workflow_getOrchestratorFlowStatswithinLastNumberOfDays, nameof(getOrchestratorFlowStatswithinLastNumberOfDays), required: false);
            var __workflow_getOrchestratorFlowStatssearchFlowName = getOrchestratorFlowStatssearchFlowName == null ? null : WorkflowExpression.Compile(getOrchestratorFlowStatssearchFlowName);
            WorkflowExpression.Validate(__workflow_getOrchestratorFlowStatssearchFlowName, nameof(getOrchestratorFlowStatssearchFlowName), required: false);
            var __workflow_getOrchestratorFlowStatssearchFlowLastActionResult = getOrchestratorFlowStatssearchFlowLastActionResult == null ? null : WorkflowExpression.Compile(getOrchestratorFlowStatssearchFlowLastActionResult);
            WorkflowExpression.Validate(__workflow_getOrchestratorFlowStatssearchFlowLastActionResult, nameof(getOrchestratorFlowStatssearchFlowLastActionResult), required: false);
            var __workflow_getOrchestratorFlowStatssearchFlowStartTimeStartWindow = getOrchestratorFlowStatssearchFlowStartTimeStartWindow == null ? null : WorkflowExpression.Compile(getOrchestratorFlowStatssearchFlowStartTimeStartWindow);
            WorkflowExpression.Validate(__workflow_getOrchestratorFlowStatssearchFlowStartTimeStartWindow, nameof(getOrchestratorFlowStatssearchFlowStartTimeStartWindow), required: false);
            var __workflow_getOrchestratorFlowStatssearchFlowStartTimeEndWindow = getOrchestratorFlowStatssearchFlowStartTimeEndWindow == null ? null : WorkflowExpression.Compile(getOrchestratorFlowStatssearchFlowStartTimeEndWindow);
            WorkflowExpression.Validate(__workflow_getOrchestratorFlowStatssearchFlowStartTimeEndWindow, nameof(getOrchestratorFlowStatssearchFlowStartTimeEndWindow), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerAvailabilityStatsResponse> GetOrchestratorWorkerAvailabilityStats(Expression<Func<int>> getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorWorkerAvailabilityStatssearchFlowName = null, Expression<Func<string>> getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow = null)
        {
            var __workflow_getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays = getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays == null ? null : WorkflowExpression.Compile(getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays);
            WorkflowExpression.Validate(__workflow_getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays, nameof(getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays), required: false);
            var __workflow_getOrchestratorWorkerAvailabilityStatssearchFlowName = getOrchestratorWorkerAvailabilityStatssearchFlowName == null ? null : WorkflowExpression.Compile(getOrchestratorWorkerAvailabilityStatssearchFlowName);
            WorkflowExpression.Validate(__workflow_getOrchestratorWorkerAvailabilityStatssearchFlowName, nameof(getOrchestratorWorkerAvailabilityStatssearchFlowName), required: false);
            var __workflow_getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow = getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow == null ? null : WorkflowExpression.Compile(getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow);
            WorkflowExpression.Validate(__workflow_getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow, nameof(getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerFlowUsageHeatmapResponse> GetOrchestratorWorkerFlowUsageHeatmap(Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow, Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow, Expression<Func<int>> getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC = null, Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapworkerNames = null)
        {
            var __workflow_getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow = getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow == null ? null : WorkflowExpression.Compile(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow);
            WorkflowExpression.Validate(__workflow_getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow, nameof(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow), required: true);
            var __workflow_getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow = getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow == null ? null : WorkflowExpression.Compile(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow);
            WorkflowExpression.Validate(__workflow_getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow, nameof(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow), required: true);
            var __workflow_getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC = getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC == null ? null : WorkflowExpression.Compile(getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC);
            WorkflowExpression.Validate(__workflow_getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC, nameof(getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC), required: false);
            var __workflow_getOrchestratorWorkerFlowUsageHeatmapworkerNames = getOrchestratorWorkerFlowUsageHeatmapworkerNames == null ? null : WorkflowExpression.Compile(getOrchestratorWorkerFlowUsageHeatmapworkerNames);
            WorkflowExpression.Validate(__workflow_getOrchestratorWorkerFlowUsageHeatmapworkerNames, nameof(getOrchestratorWorkerFlowUsageHeatmapworkerNames), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorLoginHistoryResponse> GetOrchestratorLoginHistory(Expression<Func<int>> getOrchestratorLoginHistorywithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorLoginHistorysearchByEmail = null, Expression<Func<string>> getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow = null, Expression<Func<string>> getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow = null)
        {
            var __workflow_getOrchestratorLoginHistorywithinLastNumberOfDays = getOrchestratorLoginHistorywithinLastNumberOfDays == null ? null : WorkflowExpression.Compile(getOrchestratorLoginHistorywithinLastNumberOfDays);
            WorkflowExpression.Validate(__workflow_getOrchestratorLoginHistorywithinLastNumberOfDays, nameof(getOrchestratorLoginHistorywithinLastNumberOfDays), required: false);
            var __workflow_getOrchestratorLoginHistorysearchByEmail = getOrchestratorLoginHistorysearchByEmail == null ? null : WorkflowExpression.Compile(getOrchestratorLoginHistorysearchByEmail);
            WorkflowExpression.Validate(__workflow_getOrchestratorLoginHistorysearchByEmail, nameof(getOrchestratorLoginHistorysearchByEmail), required: false);
            var __workflow_getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow = getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow == null ? null : WorkflowExpression.Compile(getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow);
            WorkflowExpression.Validate(__workflow_getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow, nameof(getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow), required: false);
            var __workflow_getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow = getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow == null ? null : WorkflowExpression.Compile(getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow);
            WorkflowExpression.Validate(__workflow_getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow, nameof(getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetLocalLoggingLevel(Expression<Func<int>> setLocalLoggingLevelloggingLevel, Expression<Func<string>> setLocalLoggingLevelworkflow)
        {
            var __workflow_setLocalLoggingLevelloggingLevel = setLocalLoggingLevelloggingLevel == null ? null : WorkflowExpression.Compile(setLocalLoggingLevelloggingLevel);
            WorkflowExpression.Validate(__workflow_setLocalLoggingLevelloggingLevel, nameof(setLocalLoggingLevelloggingLevel), required: true);
            var __workflow_setLocalLoggingLevelworkflow = setLocalLoggingLevelworkflow == null ? null : WorkflowExpression.Compile(setLocalLoggingLevelworkflow);
            WorkflowExpression.Validate(__workflow_setLocalLoggingLevelworkflow, nameof(setLocalLoggingLevelworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunCommandResponse> RunCommand(Expression<Func<string>> runCommandcommandName, Expression<Func<string>> runCommandworkflow, Expression<Func<string>> runCommandinputJSON = null)
        {
            var __workflow_runCommandcommandName = runCommandcommandName == null ? null : WorkflowExpression.Compile(runCommandcommandName);
            WorkflowExpression.Validate(__workflow_runCommandcommandName, nameof(runCommandcommandName), required: true);
            var __workflow_runCommandworkflow = runCommandworkflow == null ? null : WorkflowExpression.Compile(runCommandworkflow);
            WorkflowExpression.Validate(__workflow_runCommandworkflow, nameof(runCommandworkflow), required: true);
            var __workflow_runCommandinputJSON = runCommandinputJSON == null ? null : WorkflowExpression.Compile(runCommandinputJSON);
            WorkflowExpression.Validate(__workflow_runCommandinputJSON, nameof(runCommandinputJSON), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLocalLoggingLevelResponse> GetLocalLoggingLevel(Expression<Func<string>> getLocalLoggingLevelworkflow)
        {
            var __workflow_getLocalLoggingLevelworkflow = getLocalLoggingLevelworkflow == null ? null : WorkflowExpression.Compile(getLocalLoggingLevelworkflow);
            WorkflowExpression.Validate(__workflow_getLocalLoggingLevelworkflow, nameof(getLocalLoggingLevelworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteClientTypeResponse> GetRemoteClientType(Expression<Func<string>> getRemoteClientTypeworkflow)
        {
            var __workflow_getRemoteClientTypeworkflow = getRemoteClientTypeworkflow == null ? null : WorkflowExpression.Compile(getRemoteClientTypeworkflow);
            WorkflowExpression.Validate(__workflow_getRemoteClientTypeworkflow, nameof(getRemoteClientTypeworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectDirectorInfoResponse> GetIAConnectDirectorInfo(Expression<Func<string>> getIAConnectDirectorInfoworkflow)
        {
            var __workflow_getIAConnectDirectorInfoworkflow = getIAConnectDirectorInfoworkflow == null ? null : WorkflowExpression.Compile(getIAConnectDirectorInfoworkflow);
            WorkflowExpression.Validate(__workflow_getIAConnectDirectorInfoworkflow, nameof(getIAConnectDirectorInfoworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAvailableIAConnectSessionsResponse> GetAvailableIAConnectSessions(Expression<Func<string>> getAvailableIAConnectSessionsworkflow)
        {
            var __workflow_getAvailableIAConnectSessionsworkflow = getAvailableIAConnectSessionsworkflow == null ? null : WorkflowExpression.Compile(getAvailableIAConnectSessionsworkflow);
            WorkflowExpression.Validate(__workflow_getAvailableIAConnectSessionsworkflow, nameof(getAvailableIAConnectSessionsworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AttachToIAConnectSessionByName(Expression<Func<string>> attachToIAConnectSessionByNameiAConnectSessionName, Expression<Func<string>> attachToIAConnectSessionByNameworkflow, Expression<Func<bool>> attachToIAConnectSessionByNamevirtualChannelMustBeConnected = null)
        {
            var __workflow_attachToIAConnectSessionByNameiAConnectSessionName = attachToIAConnectSessionByNameiAConnectSessionName == null ? null : WorkflowExpression.Compile(attachToIAConnectSessionByNameiAConnectSessionName);
            WorkflowExpression.Validate(__workflow_attachToIAConnectSessionByNameiAConnectSessionName, nameof(attachToIAConnectSessionByNameiAConnectSessionName), required: true);
            var __workflow_attachToIAConnectSessionByNameworkflow = attachToIAConnectSessionByNameworkflow == null ? null : WorkflowExpression.Compile(attachToIAConnectSessionByNameworkflow);
            WorkflowExpression.Validate(__workflow_attachToIAConnectSessionByNameworkflow, nameof(attachToIAConnectSessionByNameworkflow), required: true);
            var __workflow_attachToIAConnectSessionByNamevirtualChannelMustBeConnected = attachToIAConnectSessionByNamevirtualChannelMustBeConnected == null ? null : WorkflowExpression.Compile(attachToIAConnectSessionByNamevirtualChannelMustBeConnected);
            WorkflowExpression.Validate(__workflow_attachToIAConnectSessionByNamevirtualChannelMustBeConnected, nameof(attachToIAConnectSessionByNamevirtualChannelMustBeConnected), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToTier1IAConnectSessionResponse> AttachToTier1IAConnectSession(Expression<Func<string>> attachToTier1IAConnectSessionworkflow, Expression<Func<bool>> attachToTier1IAConnectSessionvirtualChannelMustBeConnected = null)
        {
            var __workflow_attachToTier1IAConnectSessionworkflow = attachToTier1IAConnectSessionworkflow == null ? null : WorkflowExpression.Compile(attachToTier1IAConnectSessionworkflow);
            WorkflowExpression.Validate(__workflow_attachToTier1IAConnectSessionworkflow, nameof(attachToTier1IAConnectSessionworkflow), required: true);
            var __workflow_attachToTier1IAConnectSessionvirtualChannelMustBeConnected = attachToTier1IAConnectSessionvirtualChannelMustBeConnected == null ? null : WorkflowExpression.Compile(attachToTier1IAConnectSessionvirtualChannelMustBeConnected);
            WorkflowExpression.Validate(__workflow_attachToTier1IAConnectSessionvirtualChannelMustBeConnected, nameof(attachToTier1IAConnectSessionvirtualChannelMustBeConnected), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToIAConnectSessionByIndexResponse> AttachToIAConnectSessionByIndex(Expression<Func<string>> attachToIAConnectSessionByIndexworkflow, Expression<Func<attachToIAConnectSessionByIndexsearchIAConnectSessionTypeInput>> attachToIAConnectSessionByIndexsearchIAConnectSessionType = null, Expression<Func<int>> attachToIAConnectSessionByIndexsearchIAConnectSessionIndex = null, Expression<Func<int>> attachToIAConnectSessionByIndextimeToWaitInSeconds = null, Expression<Func<bool>> attachToIAConnectSessionByIndexraiseExceptionIfTimedout = null, Expression<Func<bool>> attachToIAConnectSessionByIndexvirtualChannelMustBeConnected = null, Expression<Func<bool>> attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore = null)
        {
            var __workflow_attachToIAConnectSessionByIndexworkflow = attachToIAConnectSessionByIndexworkflow == null ? null : WorkflowExpression.Compile(attachToIAConnectSessionByIndexworkflow);
            WorkflowExpression.Validate(__workflow_attachToIAConnectSessionByIndexworkflow, nameof(attachToIAConnectSessionByIndexworkflow), required: true);
            var __workflow_attachToIAConnectSessionByIndexsearchIAConnectSessionType = attachToIAConnectSessionByIndexsearchIAConnectSessionType == null ? null : WorkflowExpression.Compile(attachToIAConnectSessionByIndexsearchIAConnectSessionType);
            WorkflowExpression.Validate(__workflow_attachToIAConnectSessionByIndexsearchIAConnectSessionType, nameof(attachToIAConnectSessionByIndexsearchIAConnectSessionType), required: false);
            var __workflow_attachToIAConnectSessionByIndexsearchIAConnectSessionIndex = attachToIAConnectSessionByIndexsearchIAConnectSessionIndex == null ? null : WorkflowExpression.Compile(attachToIAConnectSessionByIndexsearchIAConnectSessionIndex);
            WorkflowExpression.Validate(__workflow_attachToIAConnectSessionByIndexsearchIAConnectSessionIndex, nameof(attachToIAConnectSessionByIndexsearchIAConnectSessionIndex), required: false);
            var __workflow_attachToIAConnectSessionByIndextimeToWaitInSeconds = attachToIAConnectSessionByIndextimeToWaitInSeconds == null ? null : WorkflowExpression.Compile(attachToIAConnectSessionByIndextimeToWaitInSeconds);
            WorkflowExpression.Validate(__workflow_attachToIAConnectSessionByIndextimeToWaitInSeconds, nameof(attachToIAConnectSessionByIndextimeToWaitInSeconds), required: false);
            var __workflow_attachToIAConnectSessionByIndexraiseExceptionIfTimedout = attachToIAConnectSessionByIndexraiseExceptionIfTimedout == null ? null : WorkflowExpression.Compile(attachToIAConnectSessionByIndexraiseExceptionIfTimedout);
            WorkflowExpression.Validate(__workflow_attachToIAConnectSessionByIndexraiseExceptionIfTimedout, nameof(attachToIAConnectSessionByIndexraiseExceptionIfTimedout), required: false);
            var __workflow_attachToIAConnectSessionByIndexvirtualChannelMustBeConnected = attachToIAConnectSessionByIndexvirtualChannelMustBeConnected == null ? null : WorkflowExpression.Compile(attachToIAConnectSessionByIndexvirtualChannelMustBeConnected);
            WorkflowExpression.Validate(__workflow_attachToIAConnectSessionByIndexvirtualChannelMustBeConnected, nameof(attachToIAConnectSessionByIndexvirtualChannelMustBeConnected), required: false);
            var __workflow_attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore = attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore == null ? null : WorkflowExpression.Compile(attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore);
            WorkflowExpression.Validate(__workflow_attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore, nameof(attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToMostRecentIAConnectSessionResponse> AttachToMostRecentIAConnectSession(Expression<Func<string>> attachToMostRecentIAConnectSessionworkflow, Expression<Func<attachToMostRecentIAConnectSessionsearchIAConnectSessionTypeInput>> attachToMostRecentIAConnectSessionsearchIAConnectSessionType = null, Expression<Func<int>> attachToMostRecentIAConnectSessiontimeToWaitInSeconds = null, Expression<Func<bool>> attachToMostRecentIAConnectSessionraiseExceptionIfTimedout = null, Expression<Func<bool>> attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected = null, Expression<Func<bool>> attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore = null)
        {
            var __workflow_attachToMostRecentIAConnectSessionworkflow = attachToMostRecentIAConnectSessionworkflow == null ? null : WorkflowExpression.Compile(attachToMostRecentIAConnectSessionworkflow);
            WorkflowExpression.Validate(__workflow_attachToMostRecentIAConnectSessionworkflow, nameof(attachToMostRecentIAConnectSessionworkflow), required: true);
            var __workflow_attachToMostRecentIAConnectSessionsearchIAConnectSessionType = attachToMostRecentIAConnectSessionsearchIAConnectSessionType == null ? null : WorkflowExpression.Compile(attachToMostRecentIAConnectSessionsearchIAConnectSessionType);
            WorkflowExpression.Validate(__workflow_attachToMostRecentIAConnectSessionsearchIAConnectSessionType, nameof(attachToMostRecentIAConnectSessionsearchIAConnectSessionType), required: false);
            var __workflow_attachToMostRecentIAConnectSessiontimeToWaitInSeconds = attachToMostRecentIAConnectSessiontimeToWaitInSeconds == null ? null : WorkflowExpression.Compile(attachToMostRecentIAConnectSessiontimeToWaitInSeconds);
            WorkflowExpression.Validate(__workflow_attachToMostRecentIAConnectSessiontimeToWaitInSeconds, nameof(attachToMostRecentIAConnectSessiontimeToWaitInSeconds), required: false);
            var __workflow_attachToMostRecentIAConnectSessionraiseExceptionIfTimedout = attachToMostRecentIAConnectSessionraiseExceptionIfTimedout == null ? null : WorkflowExpression.Compile(attachToMostRecentIAConnectSessionraiseExceptionIfTimedout);
            WorkflowExpression.Validate(__workflow_attachToMostRecentIAConnectSessionraiseExceptionIfTimedout, nameof(attachToMostRecentIAConnectSessionraiseExceptionIfTimedout), required: false);
            var __workflow_attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected = attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected == null ? null : WorkflowExpression.Compile(attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected);
            WorkflowExpression.Validate(__workflow_attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected, nameof(attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected), required: false);
            var __workflow_attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore = attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore == null ? null : WorkflowExpression.Compile(attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore);
            WorkflowExpression.Validate(__workflow_attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore, nameof(attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDirectorUpTimeResponse> GetDirectorUpTime(Expression<Func<string>> getDirectorUpTimeworkflow)
        {
            var __workflow_getDirectorUpTimeworkflow = getDirectorUpTimeworkflow == null ? null : WorkflowExpression.Compile(getDirectorUpTimeworkflow);
            WorkflowExpression.Validate(__workflow_getDirectorUpTimeworkflow, nameof(getDirectorUpTimeworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DoesIAConnectSessionExistByNameResponse> DoesIAConnectSessionExistByName(Expression<Func<string>> doesIAConnectSessionExistByNameiAConnectSessionName, Expression<Func<string>> doesIAConnectSessionExistByNameworkflow)
        {
            var __workflow_doesIAConnectSessionExistByNameiAConnectSessionName = doesIAConnectSessionExistByNameiAConnectSessionName == null ? null : WorkflowExpression.Compile(doesIAConnectSessionExistByNameiAConnectSessionName);
            WorkflowExpression.Validate(__workflow_doesIAConnectSessionExistByNameiAConnectSessionName, nameof(doesIAConnectSessionExistByNameiAConnectSessionName), required: true);
            var __workflow_doesIAConnectSessionExistByNameworkflow = doesIAConnectSessionExistByNameworkflow == null ? null : WorkflowExpression.Compile(doesIAConnectSessionExistByNameworkflow);
            WorkflowExpression.Validate(__workflow_doesIAConnectSessionExistByNameworkflow, nameof(doesIAConnectSessionExistByNameworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForIAConnectSessionToCloseByNameResponse> WaitForIAConnectSessionToCloseByName(Expression<Func<string>> waitForIAConnectSessionToCloseByNameiAConnectSessionName, Expression<Func<string>> waitForIAConnectSessionToCloseByNameworkflow, Expression<Func<int>> waitForIAConnectSessionToCloseByNametimeToWaitInSeconds = null, Expression<Func<bool>> waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout = null, Expression<Func<bool>> waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess = null)
        {
            var __workflow_waitForIAConnectSessionToCloseByNameiAConnectSessionName = waitForIAConnectSessionToCloseByNameiAConnectSessionName == null ? null : WorkflowExpression.Compile(waitForIAConnectSessionToCloseByNameiAConnectSessionName);
            WorkflowExpression.Validate(__workflow_waitForIAConnectSessionToCloseByNameiAConnectSessionName, nameof(waitForIAConnectSessionToCloseByNameiAConnectSessionName), required: true);
            var __workflow_waitForIAConnectSessionToCloseByNameworkflow = waitForIAConnectSessionToCloseByNameworkflow == null ? null : WorkflowExpression.Compile(waitForIAConnectSessionToCloseByNameworkflow);
            WorkflowExpression.Validate(__workflow_waitForIAConnectSessionToCloseByNameworkflow, nameof(waitForIAConnectSessionToCloseByNameworkflow), required: true);
            var __workflow_waitForIAConnectSessionToCloseByNametimeToWaitInSeconds = waitForIAConnectSessionToCloseByNametimeToWaitInSeconds == null ? null : WorkflowExpression.Compile(waitForIAConnectSessionToCloseByNametimeToWaitInSeconds);
            WorkflowExpression.Validate(__workflow_waitForIAConnectSessionToCloseByNametimeToWaitInSeconds, nameof(waitForIAConnectSessionToCloseByNametimeToWaitInSeconds), required: false);
            var __workflow_waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout = waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout == null ? null : WorkflowExpression.Compile(waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout);
            WorkflowExpression.Validate(__workflow_waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout, nameof(waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout), required: false);
            var __workflow_waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess = waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess == null ? null : WorkflowExpression.Compile(waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess);
            WorkflowExpression.Validate(__workflow_waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess, nameof(waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillIAConnectSessionByNameResponse> KillIAConnectSessionByName(Expression<Func<string>> killIAConnectSessionByNameiAConnectSessionName, Expression<Func<string>> killIAConnectSessionByNameworkflow, Expression<Func<bool>> killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess = null)
        {
            var __workflow_killIAConnectSessionByNameiAConnectSessionName = killIAConnectSessionByNameiAConnectSessionName == null ? null : WorkflowExpression.Compile(killIAConnectSessionByNameiAConnectSessionName);
            WorkflowExpression.Validate(__workflow_killIAConnectSessionByNameiAConnectSessionName, nameof(killIAConnectSessionByNameiAConnectSessionName), required: true);
            var __workflow_killIAConnectSessionByNameworkflow = killIAConnectSessionByNameworkflow == null ? null : WorkflowExpression.Compile(killIAConnectSessionByNameworkflow);
            WorkflowExpression.Validate(__workflow_killIAConnectSessionByNameworkflow, nameof(killIAConnectSessionByNameworkflow), required: true);
            var __workflow_killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess = killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess == null ? null : WorkflowExpression.Compile(killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess);
            WorkflowExpression.Validate(__workflow_killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess, nameof(killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetAgentGlobalCoordinateConfigurationResponse> SetAgentGlobalCoordinateConfiguration(Expression<Func<string>> setAgentGlobalCoordinateConfigurationworkflow, Expression<Func<setAgentGlobalCoordinateConfigurationmultiMonitorFunctionalityInput>> setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality = null, Expression<Func<setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplierInput>> setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier = null, Expression<Func<setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplierInput>> setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod = null, Expression<Func<setAgentGlobalCoordinateConfigurationjavaCoordinateSystemInput>> setAgentGlobalCoordinateConfigurationjavaCoordinateSystem = null, Expression<Func<setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystemInput>> setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem = null)
        {
            var __workflow_setAgentGlobalCoordinateConfigurationworkflow = setAgentGlobalCoordinateConfigurationworkflow == null ? null : WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationworkflow);
            WorkflowExpression.Validate(__workflow_setAgentGlobalCoordinateConfigurationworkflow, nameof(setAgentGlobalCoordinateConfigurationworkflow), required: true);
            var __workflow_setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality = setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality == null ? null : WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality);
            WorkflowExpression.Validate(__workflow_setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality, nameof(setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier = setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier == null ? null : WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier);
            WorkflowExpression.Validate(__workflow_setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier, nameof(setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier = setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier == null ? null : WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier);
            WorkflowExpression.Validate(__workflow_setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier, nameof(setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier = setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier == null ? null : WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier);
            WorkflowExpression.Validate(__workflow_setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier, nameof(setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier = setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier == null ? null : WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier);
            WorkflowExpression.Validate(__workflow_setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier, nameof(setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier = setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier == null ? null : WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier);
            WorkflowExpression.Validate(__workflow_setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier, nameof(setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier = setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier == null ? null : WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier);
            WorkflowExpression.Validate(__workflow_setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier, nameof(setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent = setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent == null ? null : WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent);
            WorkflowExpression.Validate(__workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent, nameof(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos = setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos == null ? null : WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos);
            WorkflowExpression.Validate(__workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos, nameof(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod = setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod == null ? null : WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod);
            WorkflowExpression.Validate(__workflow_setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod, nameof(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationjavaCoordinateSystem = setAgentGlobalCoordinateConfigurationjavaCoordinateSystem == null ? null : WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationjavaCoordinateSystem);
            WorkflowExpression.Validate(__workflow_setAgentGlobalCoordinateConfigurationjavaCoordinateSystem, nameof(setAgentGlobalCoordinateConfigurationjavaCoordinateSystem), required: false);
            var __workflow_setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem = setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem == null ? null : WorkflowExpression.Compile(setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem);
            WorkflowExpression.Validate(__workflow_setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem, nameof(setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentGlobalCoordinateConfigurationResponse> GetAgentGlobalCoordinateConfiguration(Expression<Func<string>> getAgentGlobalCoordinateConfigurationworkflow)
        {
            var __workflow_getAgentGlobalCoordinateConfigurationworkflow = getAgentGlobalCoordinateConfigurationworkflow == null ? null : WorkflowExpression.Compile(getAgentGlobalCoordinateConfigurationworkflow);
            WorkflowExpression.Validate(__workflow_getAgentGlobalCoordinateConfigurationworkflow, nameof(getAgentGlobalCoordinateConfigurationworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentThreadStatusResponse> GetAgentThreadStatus(Expression<Func<int>> getAgentThreadStatusthreadId, Expression<Func<string>> getAgentThreadStatusworkflow, Expression<Func<bool>> getAgentThreadStatusretrieveThreadOutputData = null, Expression<Func<bool>> getAgentThreadStatusclearOutputDataFromMemoryOnceRead = null)
        {
            var __workflow_getAgentThreadStatusthreadId = getAgentThreadStatusthreadId == null ? null : WorkflowExpression.Compile(getAgentThreadStatusthreadId);
            WorkflowExpression.Validate(__workflow_getAgentThreadStatusthreadId, nameof(getAgentThreadStatusthreadId), required: true);
            var __workflow_getAgentThreadStatusworkflow = getAgentThreadStatusworkflow == null ? null : WorkflowExpression.Compile(getAgentThreadStatusworkflow);
            WorkflowExpression.Validate(__workflow_getAgentThreadStatusworkflow, nameof(getAgentThreadStatusworkflow), required: true);
            var __workflow_getAgentThreadStatusretrieveThreadOutputData = getAgentThreadStatusretrieveThreadOutputData == null ? null : WorkflowExpression.Compile(getAgentThreadStatusretrieveThreadOutputData);
            WorkflowExpression.Validate(__workflow_getAgentThreadStatusretrieveThreadOutputData, nameof(getAgentThreadStatusretrieveThreadOutputData), required: false);
            var __workflow_getAgentThreadStatusclearOutputDataFromMemoryOnceRead = getAgentThreadStatusclearOutputDataFromMemoryOnceRead == null ? null : WorkflowExpression.Compile(getAgentThreadStatusclearOutputDataFromMemoryOnceRead);
            WorkflowExpression.Validate(__workflow_getAgentThreadStatusclearOutputDataFromMemoryOnceRead, nameof(getAgentThreadStatusclearOutputDataFromMemoryOnceRead), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForAgentThreadToCompleteSuccessfullyResponse> WaitForAgentThreadToCompleteSuccessfully(Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullythreadId, Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread, Expression<Func<string>> waitForAgentThreadToCompleteSuccessfullyworkflow, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError = null, Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall = null)
        {
            var __workflow_waitForAgentThreadToCompleteSuccessfullythreadId = waitForAgentThreadToCompleteSuccessfullythreadId == null ? null : WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullythreadId);
            WorkflowExpression.Validate(__workflow_waitForAgentThreadToCompleteSuccessfullythreadId, nameof(waitForAgentThreadToCompleteSuccessfullythreadId), required: true);
            var __workflow_waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread = waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread == null ? null : WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread);
            WorkflowExpression.Validate(__workflow_waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread, nameof(waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread), required: true);
            var __workflow_waitForAgentThreadToCompleteSuccessfullyworkflow = waitForAgentThreadToCompleteSuccessfullyworkflow == null ? null : WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullyworkflow);
            WorkflowExpression.Validate(__workflow_waitForAgentThreadToCompleteSuccessfullyworkflow, nameof(waitForAgentThreadToCompleteSuccessfullyworkflow), required: true);
            var __workflow_waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData = waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData == null ? null : WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData);
            WorkflowExpression.Validate(__workflow_waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData, nameof(waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData), required: false);
            var __workflow_waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead = waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead == null ? null : WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead);
            WorkflowExpression.Validate(__workflow_waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead, nameof(waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead), required: false);
            var __workflow_waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted = waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted == null ? null : WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted);
            WorkflowExpression.Validate(__workflow_waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted, nameof(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted), required: false);
            var __workflow_waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError = waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError == null ? null : WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError);
            WorkflowExpression.Validate(__workflow_waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError, nameof(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError), required: false);
            var __workflow_waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall = waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall == null ? null : WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall);
            WorkflowExpression.Validate(__workflow_waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall, nameof(waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentThreadsResponse> GetAgentThreads(Expression<Func<string>> getAgentThreadsworkflow, Expression<Func<getAgentThreadssortOrderInput>> getAgentThreadssortOrder = null)
        {
            var __workflow_getAgentThreadsworkflow = getAgentThreadsworkflow == null ? null : WorkflowExpression.Compile(getAgentThreadsworkflow);
            WorkflowExpression.Validate(__workflow_getAgentThreadsworkflow, nameof(getAgentThreadsworkflow), required: true);
            var __workflow_getAgentThreadssortOrder = getAgentThreadssortOrder == null ? null : WorkflowExpression.Compile(getAgentThreadssortOrder);
            WorkflowExpression.Validate(__workflow_getAgentThreadssortOrder, nameof(getAgentThreadssortOrder), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillAgentThreadResponse> KillAgentThread(Expression<Func<int>> killAgentThreadthreadId, Expression<Func<string>> killAgentThreadworkflow)
        {
            var __workflow_killAgentThreadthreadId = killAgentThreadthreadId == null ? null : WorkflowExpression.Compile(killAgentThreadthreadId);
            WorkflowExpression.Validate(__workflow_killAgentThreadthreadId, nameof(killAgentThreadthreadId), required: true);
            var __workflow_killAgentThreadworkflow = killAgentThreadworkflow == null ? null : WorkflowExpression.Compile(killAgentThreadworkflow);
            WorkflowExpression.Validate(__workflow_killAgentThreadworkflow, nameof(killAgentThreadworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeleteAgentThreadResponse> DeleteAgentThread(Expression<Func<string>> deleteAgentThreadworkflow, Expression<Func<int>> deleteAgentThreadthreadId = null, Expression<Func<bool>> deleteAgentThreaddeleteAllAgentThreads = null, Expression<Func<bool>> deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete = null)
        {
            var __workflow_deleteAgentThreadworkflow = deleteAgentThreadworkflow == null ? null : WorkflowExpression.Compile(deleteAgentThreadworkflow);
            WorkflowExpression.Validate(__workflow_deleteAgentThreadworkflow, nameof(deleteAgentThreadworkflow), required: true);
            var __workflow_deleteAgentThreadthreadId = deleteAgentThreadthreadId == null ? null : WorkflowExpression.Compile(deleteAgentThreadthreadId);
            WorkflowExpression.Validate(__workflow_deleteAgentThreadthreadId, nameof(deleteAgentThreadthreadId), required: false);
            var __workflow_deleteAgentThreaddeleteAllAgentThreads = deleteAgentThreaddeleteAllAgentThreads == null ? null : WorkflowExpression.Compile(deleteAgentThreaddeleteAllAgentThreads);
            WorkflowExpression.Validate(__workflow_deleteAgentThreaddeleteAllAgentThreads, nameof(deleteAgentThreaddeleteAllAgentThreads), required: false);
            var __workflow_deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete = deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete == null ? null : WorkflowExpression.Compile(deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete);
            WorkflowExpression.Validate(__workflow_deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete, nameof(deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AllocateWorkerFromOrchestratorResponse> AllocateWorkerFromOrchestrator(Expression<Func<string>> allocateWorkerFromOrchestratorworkflow, Expression<Func<string>> allocateWorkerFromOrchestratorworkerTag = null, Expression<Func<string>> allocateWorkerFromOrchestratorworkerName = null, Expression<Func<bool>> allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable = null)
        {
            var __workflow_allocateWorkerFromOrchestratorworkflow = allocateWorkerFromOrchestratorworkflow == null ? null : WorkflowExpression.Compile(allocateWorkerFromOrchestratorworkflow);
            WorkflowExpression.Validate(__workflow_allocateWorkerFromOrchestratorworkflow, nameof(allocateWorkerFromOrchestratorworkflow), required: true);
            var __workflow_allocateWorkerFromOrchestratorworkerTag = allocateWorkerFromOrchestratorworkerTag == null ? null : WorkflowExpression.Compile(allocateWorkerFromOrchestratorworkerTag);
            WorkflowExpression.Validate(__workflow_allocateWorkerFromOrchestratorworkerTag, nameof(allocateWorkerFromOrchestratorworkerTag), required: false);
            var __workflow_allocateWorkerFromOrchestratorworkerName = allocateWorkerFromOrchestratorworkerName == null ? null : WorkflowExpression.Compile(allocateWorkerFromOrchestratorworkerName);
            WorkflowExpression.Validate(__workflow_allocateWorkerFromOrchestratorworkerName, nameof(allocateWorkerFromOrchestratorworkerName), required: false);
            var __workflow_allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable = allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable == null ? null : WorkflowExpression.Compile(allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable);
            WorkflowExpression.Validate(__workflow_allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable, nameof(allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetOrchestratorWorkerMaintenanceModeResponse> SetOrchestratorWorkerMaintenanceMode(Expression<Func<int>> setOrchestratorWorkerMaintenanceModeworkerId = null, Expression<Func<string>> setOrchestratorWorkerMaintenanceModeworkerName = null, Expression<Func<bool>> setOrchestratorWorkerMaintenanceModemaintenanceMode = null)
        {
            var __workflow_setOrchestratorWorkerMaintenanceModeworkerId = setOrchestratorWorkerMaintenanceModeworkerId == null ? null : WorkflowExpression.Compile(setOrchestratorWorkerMaintenanceModeworkerId);
            WorkflowExpression.Validate(__workflow_setOrchestratorWorkerMaintenanceModeworkerId, nameof(setOrchestratorWorkerMaintenanceModeworkerId), required: false);
            var __workflow_setOrchestratorWorkerMaintenanceModeworkerName = setOrchestratorWorkerMaintenanceModeworkerName == null ? null : WorkflowExpression.Compile(setOrchestratorWorkerMaintenanceModeworkerName);
            WorkflowExpression.Validate(__workflow_setOrchestratorWorkerMaintenanceModeworkerName, nameof(setOrchestratorWorkerMaintenanceModeworkerName), required: false);
            var __workflow_setOrchestratorWorkerMaintenanceModemaintenanceMode = setOrchestratorWorkerMaintenanceModemaintenanceMode == null ? null : WorkflowExpression.Compile(setOrchestratorWorkerMaintenanceModemaintenanceMode);
            WorkflowExpression.Validate(__workflow_setOrchestratorWorkerMaintenanceModemaintenanceMode, nameof(setOrchestratorWorkerMaintenanceModemaintenanceMode), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CreateOrchestratorOneTimeSecretResponse> CreateOrchestratorOneTimeSecret(Expression<Func<string>> createOrchestratorOneTimeSecretfriendlyName, Expression<Func<string>> createOrchestratorOneTimeSecretsecretValue = null, Expression<Func<string>> createOrchestratorOneTimeSecretretrievalPhrase1 = null, Expression<Func<string>> createOrchestratorOneTimeSecretretrievalPhrase2 = null, Expression<Func<int>> createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion = null, Expression<Func<bool>> createOrchestratorOneTimeSecretsecretHasAStartDate = null, Expression<Func<string>> createOrchestratorOneTimeSecretsecretStartDateTime = null, Expression<Func<int>> createOrchestratorOneTimeSecrethoursUntilSecretStartTime = null, Expression<Func<bool>> createOrchestratorOneTimeSecretsecretHasAnExpiryDate = null, Expression<Func<string>> createOrchestratorOneTimeSecretsecretExpiryDateTime = null, Expression<Func<int>> createOrchestratorOneTimeSecrethoursUntilSecretExpiry = null)
        {
            var __workflow_createOrchestratorOneTimeSecretfriendlyName = createOrchestratorOneTimeSecretfriendlyName == null ? null : WorkflowExpression.Compile(createOrchestratorOneTimeSecretfriendlyName);
            WorkflowExpression.Validate(__workflow_createOrchestratorOneTimeSecretfriendlyName, nameof(createOrchestratorOneTimeSecretfriendlyName), required: true);
            var __workflow_createOrchestratorOneTimeSecretsecretValue = createOrchestratorOneTimeSecretsecretValue == null ? null : WorkflowExpression.Compile(createOrchestratorOneTimeSecretsecretValue);
            WorkflowExpression.Validate(__workflow_createOrchestratorOneTimeSecretsecretValue, nameof(createOrchestratorOneTimeSecretsecretValue), required: false);
            var __workflow_createOrchestratorOneTimeSecretretrievalPhrase1 = createOrchestratorOneTimeSecretretrievalPhrase1 == null ? null : WorkflowExpression.Compile(createOrchestratorOneTimeSecretretrievalPhrase1);
            WorkflowExpression.Validate(__workflow_createOrchestratorOneTimeSecretretrievalPhrase1, nameof(createOrchestratorOneTimeSecretretrievalPhrase1), required: false);
            var __workflow_createOrchestratorOneTimeSecretretrievalPhrase2 = createOrchestratorOneTimeSecretretrievalPhrase2 == null ? null : WorkflowExpression.Compile(createOrchestratorOneTimeSecretretrievalPhrase2);
            WorkflowExpression.Validate(__workflow_createOrchestratorOneTimeSecretretrievalPhrase2, nameof(createOrchestratorOneTimeSecretretrievalPhrase2), required: false);
            var __workflow_createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion = createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion == null ? null : WorkflowExpression.Compile(createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion);
            WorkflowExpression.Validate(__workflow_createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion, nameof(createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion), required: false);
            var __workflow_createOrchestratorOneTimeSecretsecretHasAStartDate = createOrchestratorOneTimeSecretsecretHasAStartDate == null ? null : WorkflowExpression.Compile(createOrchestratorOneTimeSecretsecretHasAStartDate);
            WorkflowExpression.Validate(__workflow_createOrchestratorOneTimeSecretsecretHasAStartDate, nameof(createOrchestratorOneTimeSecretsecretHasAStartDate), required: false);
            var __workflow_createOrchestratorOneTimeSecretsecretStartDateTime = createOrchestratorOneTimeSecretsecretStartDateTime == null ? null : WorkflowExpression.Compile(createOrchestratorOneTimeSecretsecretStartDateTime);
            WorkflowExpression.Validate(__workflow_createOrchestratorOneTimeSecretsecretStartDateTime, nameof(createOrchestratorOneTimeSecretsecretStartDateTime), required: false);
            var __workflow_createOrchestratorOneTimeSecrethoursUntilSecretStartTime = createOrchestratorOneTimeSecrethoursUntilSecretStartTime == null ? null : WorkflowExpression.Compile(createOrchestratorOneTimeSecrethoursUntilSecretStartTime);
            WorkflowExpression.Validate(__workflow_createOrchestratorOneTimeSecrethoursUntilSecretStartTime, nameof(createOrchestratorOneTimeSecrethoursUntilSecretStartTime), required: false);
            var __workflow_createOrchestratorOneTimeSecretsecretHasAnExpiryDate = createOrchestratorOneTimeSecretsecretHasAnExpiryDate == null ? null : WorkflowExpression.Compile(createOrchestratorOneTimeSecretsecretHasAnExpiryDate);
            WorkflowExpression.Validate(__workflow_createOrchestratorOneTimeSecretsecretHasAnExpiryDate, nameof(createOrchestratorOneTimeSecretsecretHasAnExpiryDate), required: false);
            var __workflow_createOrchestratorOneTimeSecretsecretExpiryDateTime = createOrchestratorOneTimeSecretsecretExpiryDateTime == null ? null : WorkflowExpression.Compile(createOrchestratorOneTimeSecretsecretExpiryDateTime);
            WorkflowExpression.Validate(__workflow_createOrchestratorOneTimeSecretsecretExpiryDateTime, nameof(createOrchestratorOneTimeSecretsecretExpiryDateTime), required: false);
            var __workflow_createOrchestratorOneTimeSecrethoursUntilSecretExpiry = createOrchestratorOneTimeSecrethoursUntilSecretExpiry == null ? null : WorkflowExpression.Compile(createOrchestratorOneTimeSecrethoursUntilSecretExpiry);
            WorkflowExpression.Validate(__workflow_createOrchestratorOneTimeSecrethoursUntilSecretExpiry, nameof(createOrchestratorOneTimeSecrethoursUntilSecretExpiry), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfOrchestratorWorkersResponse> GetListOfOrchestratorWorkers(Expression<Func<bool>> getListOfOrchestratorWorkersonlyReturnLiveWorkers = null)
        {
            var __workflow_getListOfOrchestratorWorkersonlyReturnLiveWorkers = getListOfOrchestratorWorkersonlyReturnLiveWorkers == null ? null : WorkflowExpression.Compile(getListOfOrchestratorWorkersonlyReturnLiveWorkers);
            WorkflowExpression.Validate(__workflow_getListOfOrchestratorWorkersonlyReturnLiveWorkers, nameof(getListOfOrchestratorWorkersonlyReturnLiveWorkers), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerResponse> GetOrchestratorWorker(Expression<Func<int>> getOrchestratorWorkersearchWorkerId = null, Expression<Func<string>> getOrchestratorWorkersearchWorkerName = null)
        {
            var __workflow_getOrchestratorWorkersearchWorkerId = getOrchestratorWorkersearchWorkerId == null ? null : WorkflowExpression.Compile(getOrchestratorWorkersearchWorkerId);
            WorkflowExpression.Validate(__workflow_getOrchestratorWorkersearchWorkerId, nameof(getOrchestratorWorkersearchWorkerId), required: false);
            var __workflow_getOrchestratorWorkersearchWorkerName = getOrchestratorWorkersearchWorkerName == null ? null : WorkflowExpression.Compile(getOrchestratorWorkersearchWorkerName);
            WorkflowExpression.Validate(__workflow_getOrchestratorWorkersearchWorkerName, nameof(getOrchestratorWorkersearchWorkerName), required: false);
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
            });
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
            var __workflow_fileExistsfilename = fileExistsfilename == null ? null : WorkflowExpression.Compile(fileExistsfilename);
            WorkflowExpression.Validate(__workflow_fileExistsfilename, nameof(fileExistsfilename), required: true);
            var __workflow_fileExistsworkflow = fileExistsworkflow == null ? null : WorkflowExpression.Compile(fileExistsworkflow);
            WorkflowExpression.Validate(__workflow_fileExistsworkflow, nameof(fileExistsworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DirectoryExistsResponse> DirectoryExists(Expression<Func<string>> directoryExistsdirectoryPath, Expression<Func<string>> directoryExistsworkflow)
        {
            var __workflow_directoryExistsdirectoryPath = directoryExistsdirectoryPath == null ? null : WorkflowExpression.Compile(directoryExistsdirectoryPath);
            WorkflowExpression.Validate(__workflow_directoryExistsdirectoryPath, nameof(directoryExistsdirectoryPath), required: true);
            var __workflow_directoryExistsworkflow = directoryExistsworkflow == null ? null : WorkflowExpression.Compile(directoryExistsworkflow);
            WorkflowExpression.Validate(__workflow_directoryExistsworkflow, nameof(directoryExistsworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DeleteFile(Expression<Func<string>> deleteFilefilename, Expression<Func<string>> deleteFileworkflow)
        {
            var __workflow_deleteFilefilename = deleteFilefilename == null ? null : WorkflowExpression.Compile(deleteFilefilename);
            WorkflowExpression.Validate(__workflow_deleteFilefilename, nameof(deleteFilefilename), required: true);
            var __workflow_deleteFileworkflow = deleteFileworkflow == null ? null : WorkflowExpression.Compile(deleteFileworkflow);
            WorkflowExpression.Validate(__workflow_deleteFileworkflow, nameof(deleteFileworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DeleteDirectory(Expression<Func<string>> deleteDirectorydirectoryPath, Expression<Func<string>> deleteDirectoryworkflow, Expression<Func<bool>> deleteDirectoryrecursive = null)
        {
            var __workflow_deleteDirectorydirectoryPath = deleteDirectorydirectoryPath == null ? null : WorkflowExpression.Compile(deleteDirectorydirectoryPath);
            WorkflowExpression.Validate(__workflow_deleteDirectorydirectoryPath, nameof(deleteDirectorydirectoryPath), required: true);
            var __workflow_deleteDirectoryworkflow = deleteDirectoryworkflow == null ? null : WorkflowExpression.Compile(deleteDirectoryworkflow);
            WorkflowExpression.Validate(__workflow_deleteDirectoryworkflow, nameof(deleteDirectoryworkflow), required: true);
            var __workflow_deleteDirectoryrecursive = deleteDirectoryrecursive == null ? null : WorkflowExpression.Compile(deleteDirectoryrecursive);
            WorkflowExpression.Validate(__workflow_deleteDirectoryrecursive, nameof(deleteDirectoryrecursive), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction PurgeDirectory(Expression<Func<string>> purgeDirectorydirectoryPath, Expression<Func<string>> purgeDirectoryworkflow, Expression<Func<bool>> purgeDirectoryrecursive = null, Expression<Func<bool>> purgeDirectorydeleteTopLevel = null)
        {
            var __workflow_purgeDirectorydirectoryPath = purgeDirectorydirectoryPath == null ? null : WorkflowExpression.Compile(purgeDirectorydirectoryPath);
            WorkflowExpression.Validate(__workflow_purgeDirectorydirectoryPath, nameof(purgeDirectorydirectoryPath), required: true);
            var __workflow_purgeDirectoryworkflow = purgeDirectoryworkflow == null ? null : WorkflowExpression.Compile(purgeDirectoryworkflow);
            WorkflowExpression.Validate(__workflow_purgeDirectoryworkflow, nameof(purgeDirectoryworkflow), required: true);
            var __workflow_purgeDirectoryrecursive = purgeDirectoryrecursive == null ? null : WorkflowExpression.Compile(purgeDirectoryrecursive);
            WorkflowExpression.Validate(__workflow_purgeDirectoryrecursive, nameof(purgeDirectoryrecursive), required: false);
            var __workflow_purgeDirectorydeleteTopLevel = purgeDirectorydeleteTopLevel == null ? null : WorkflowExpression.Compile(purgeDirectorydeleteTopLevel);
            WorkflowExpression.Validate(__workflow_purgeDirectorydeleteTopLevel, nameof(purgeDirectorydeleteTopLevel), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CopyFile(Expression<Func<string>> copyFilesourceFilePath, Expression<Func<string>> copyFiledestFilePath, Expression<Func<string>> copyFileworkflow)
        {
            var __workflow_copyFilesourceFilePath = copyFilesourceFilePath == null ? null : WorkflowExpression.Compile(copyFilesourceFilePath);
            WorkflowExpression.Validate(__workflow_copyFilesourceFilePath, nameof(copyFilesourceFilePath), required: true);
            var __workflow_copyFiledestFilePath = copyFiledestFilePath == null ? null : WorkflowExpression.Compile(copyFiledestFilePath);
            WorkflowExpression.Validate(__workflow_copyFiledestFilePath, nameof(copyFiledestFilePath), required: true);
            var __workflow_copyFileworkflow = copyFileworkflow == null ? null : WorkflowExpression.Compile(copyFileworkflow);
            WorkflowExpression.Validate(__workflow_copyFileworkflow, nameof(copyFileworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveFile(Expression<Func<string>> moveFilesourceFilePath, Expression<Func<string>> moveFiledestFilePath, Expression<Func<string>> moveFileworkflow)
        {
            var __workflow_moveFilesourceFilePath = moveFilesourceFilePath == null ? null : WorkflowExpression.Compile(moveFilesourceFilePath);
            WorkflowExpression.Validate(__workflow_moveFilesourceFilePath, nameof(moveFilesourceFilePath), required: true);
            var __workflow_moveFiledestFilePath = moveFiledestFilePath == null ? null : WorkflowExpression.Compile(moveFiledestFilePath);
            WorkflowExpression.Validate(__workflow_moveFiledestFilePath, nameof(moveFiledestFilePath), required: true);
            var __workflow_moveFileworkflow = moveFileworkflow == null ? null : WorkflowExpression.Compile(moveFileworkflow);
            WorkflowExpression.Validate(__workflow_moveFileworkflow, nameof(moveFileworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CreateDirectory(Expression<Func<string>> createDirectorydirectoryPath, Expression<Func<string>> createDirectoryworkflow, Expression<Func<bool>> createDirectoryerrorIfAlreadyExists = null)
        {
            var __workflow_createDirectorydirectoryPath = createDirectorydirectoryPath == null ? null : WorkflowExpression.Compile(createDirectorydirectoryPath);
            WorkflowExpression.Validate(__workflow_createDirectorydirectoryPath, nameof(createDirectorydirectoryPath), required: true);
            var __workflow_createDirectoryworkflow = createDirectoryworkflow == null ? null : WorkflowExpression.Compile(createDirectoryworkflow);
            WorkflowExpression.Validate(__workflow_createDirectoryworkflow, nameof(createDirectoryworkflow), required: true);
            var __workflow_createDirectoryerrorIfAlreadyExists = createDirectoryerrorIfAlreadyExists == null ? null : WorkflowExpression.Compile(createDirectoryerrorIfAlreadyExists);
            WorkflowExpression.Validate(__workflow_createDirectoryerrorIfAlreadyExists, nameof(createDirectoryerrorIfAlreadyExists), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileSizeResponse> GetFileSize(Expression<Func<string>> getFileSizefilename, Expression<Func<string>> getFileSizeworkflow)
        {
            var __workflow_getFileSizefilename = getFileSizefilename == null ? null : WorkflowExpression.Compile(getFileSizefilename);
            WorkflowExpression.Validate(__workflow_getFileSizefilename, nameof(getFileSizefilename), required: true);
            var __workflow_getFileSizeworkflow = getFileSizeworkflow == null ? null : WorkflowExpression.Compile(getFileSizeworkflow);
            WorkflowExpression.Validate(__workflow_getFileSizeworkflow, nameof(getFileSizeworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WriteTextFile(Expression<Func<string>> writeTextFilefilename, Expression<Func<string>> writeTextFileworkflow, Expression<Func<string>> writeTextFiletextToWrite = null, Expression<Func<bool>> writeTextFileappendExistingFile = null, Expression<Func<writeTextFileencodingInput>> writeTextFileencoding = null, Expression<Func<bool>> writeTextFilecreateFolderIfRequired = null)
        {
            var __workflow_writeTextFilefilename = writeTextFilefilename == null ? null : WorkflowExpression.Compile(writeTextFilefilename);
            WorkflowExpression.Validate(__workflow_writeTextFilefilename, nameof(writeTextFilefilename), required: true);
            var __workflow_writeTextFileworkflow = writeTextFileworkflow == null ? null : WorkflowExpression.Compile(writeTextFileworkflow);
            WorkflowExpression.Validate(__workflow_writeTextFileworkflow, nameof(writeTextFileworkflow), required: true);
            var __workflow_writeTextFiletextToWrite = writeTextFiletextToWrite == null ? null : WorkflowExpression.Compile(writeTextFiletextToWrite);
            WorkflowExpression.Validate(__workflow_writeTextFiletextToWrite, nameof(writeTextFiletextToWrite), required: false);
            var __workflow_writeTextFileappendExistingFile = writeTextFileappendExistingFile == null ? null : WorkflowExpression.Compile(writeTextFileappendExistingFile);
            WorkflowExpression.Validate(__workflow_writeTextFileappendExistingFile, nameof(writeTextFileappendExistingFile), required: false);
            var __workflow_writeTextFileencoding = writeTextFileencoding == null ? null : WorkflowExpression.Compile(writeTextFileencoding);
            WorkflowExpression.Validate(__workflow_writeTextFileencoding, nameof(writeTextFileencoding), required: false);
            var __workflow_writeTextFilecreateFolderIfRequired = writeTextFilecreateFolderIfRequired == null ? null : WorkflowExpression.Compile(writeTextFilecreateFolderIfRequired);
            WorkflowExpression.Validate(__workflow_writeTextFilecreateFolderIfRequired, nameof(writeTextFilecreateFolderIfRequired), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ReadAllTextFromFileResponse> ReadAllTextFromFile(Expression<Func<string>> readAllTextFromFilefilename, Expression<Func<string>> readAllTextFromFileworkflow)
        {
            var __workflow_readAllTextFromFilefilename = readAllTextFromFilefilename == null ? null : WorkflowExpression.Compile(readAllTextFromFilefilename);
            WorkflowExpression.Validate(__workflow_readAllTextFromFilefilename, nameof(readAllTextFromFilefilename), required: true);
            var __workflow_readAllTextFromFileworkflow = readAllTextFromFileworkflow == null ? null : WorkflowExpression.Compile(readAllTextFromFileworkflow);
            WorkflowExpression.Validate(__workflow_readAllTextFromFileworkflow, nameof(readAllTextFromFileworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFilesResponse> GetFiles(Expression<Func<string>> getFilesdirectoryPath, Expression<Func<string>> getFilespatternsCSV, Expression<Func<string>> getFilesworkflow)
        {
            var __workflow_getFilesdirectoryPath = getFilesdirectoryPath == null ? null : WorkflowExpression.Compile(getFilesdirectoryPath);
            WorkflowExpression.Validate(__workflow_getFilesdirectoryPath, nameof(getFilesdirectoryPath), required: true);
            var __workflow_getFilespatternsCSV = getFilespatternsCSV == null ? null : WorkflowExpression.Compile(getFilespatternsCSV);
            WorkflowExpression.Validate(__workflow_getFilespatternsCSV, nameof(getFilespatternsCSV), required: true);
            var __workflow_getFilesworkflow = getFilesworkflow == null ? null : WorkflowExpression.Compile(getFilesworkflow);
            WorkflowExpression.Validate(__workflow_getFilesworkflow, nameof(getFilesworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFoldersResponse> GetFolders(Expression<Func<string>> getFoldersdirectoryPath, Expression<Func<string>> getFoldersworkflow)
        {
            var __workflow_getFoldersdirectoryPath = getFoldersdirectoryPath == null ? null : WorkflowExpression.Compile(getFoldersdirectoryPath);
            WorkflowExpression.Validate(__workflow_getFoldersdirectoryPath, nameof(getFoldersdirectoryPath), required: true);
            var __workflow_getFoldersworkflow = getFoldersworkflow == null ? null : WorkflowExpression.Compile(getFoldersworkflow);
            WorkflowExpression.Validate(__workflow_getFoldersworkflow, nameof(getFoldersworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeleteFilesResponse> DeleteFiles(Expression<Func<string>> deleteFilesdirectoryPath, Expression<Func<string>> deleteFilesworkflow, Expression<Func<string>> deleteFilespattern = null)
        {
            var __workflow_deleteFilesdirectoryPath = deleteFilesdirectoryPath == null ? null : WorkflowExpression.Compile(deleteFilesdirectoryPath);
            WorkflowExpression.Validate(__workflow_deleteFilesdirectoryPath, nameof(deleteFilesdirectoryPath), required: true);
            var __workflow_deleteFilesworkflow = deleteFilesworkflow == null ? null : WorkflowExpression.Compile(deleteFilesworkflow);
            WorkflowExpression.Validate(__workflow_deleteFilesworkflow, nameof(deleteFilesworkflow), required: true);
            var __workflow_deleteFilespattern = deleteFilespattern == null ? null : WorkflowExpression.Compile(deleteFilespattern);
            WorkflowExpression.Validate(__workflow_deleteFilespattern, nameof(deleteFilespattern), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDiskFreeSpaceResponse> GetDiskFreeSpace(Expression<Func<string>> getDiskFreeSpacedriveLetter, Expression<Func<string>> getDiskFreeSpaceworkflow)
        {
            var __workflow_getDiskFreeSpacedriveLetter = getDiskFreeSpacedriveLetter == null ? null : WorkflowExpression.Compile(getDiskFreeSpacedriveLetter);
            WorkflowExpression.Validate(__workflow_getDiskFreeSpacedriveLetter, nameof(getDiskFreeSpacedriveLetter), required: true);
            var __workflow_getDiskFreeSpaceworkflow = getDiskFreeSpaceworkflow == null ? null : WorkflowExpression.Compile(getDiskFreeSpaceworkflow);
            WorkflowExpression.Validate(__workflow_getDiskFreeSpaceworkflow, nameof(getDiskFreeSpaceworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfDrivesResponse> GetListOfDrives(Expression<Func<string>> getListOfDrivesworkflow)
        {
            var __workflow_getListOfDrivesworkflow = getListOfDrivesworkflow == null ? null : WorkflowExpression.Compile(getListOfDrivesworkflow);
            WorkflowExpression.Validate(__workflow_getListOfDrivesworkflow, nameof(getListOfDrivesworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DirectoryIsAccessibleResponse> DirectoryIsAccessible(Expression<Func<string>> directoryIsAccessibledirectoryPath, Expression<Func<string>> directoryIsAccessibleworkflow)
        {
            var __workflow_directoryIsAccessibledirectoryPath = directoryIsAccessibledirectoryPath == null ? null : WorkflowExpression.Compile(directoryIsAccessibledirectoryPath);
            WorkflowExpression.Validate(__workflow_directoryIsAccessibledirectoryPath, nameof(directoryIsAccessibledirectoryPath), required: true);
            var __workflow_directoryIsAccessibleworkflow = directoryIsAccessibleworkflow == null ? null : WorkflowExpression.Compile(directoryIsAccessibleworkflow);
            WorkflowExpression.Validate(__workflow_directoryIsAccessibleworkflow, nameof(directoryIsAccessibleworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetCSVTextAsCollectionResponse> GetCSVTextAsCollection(Expression<Func<string>> getCSVTextAsCollectioncSVFilePath, Expression<Func<string>> getCSVTextAsCollectionworkflow, Expression<Func<bool>> getCSVTextAsCollectionfirstLineIsHeader = null, Expression<Func<bool>> getCSVTextAsCollectiontrimHeaders = null, Expression<Func<bool>> getCSVTextAsCollectionallowBlankRows = null, Expression<Func<bool>> getCSVTextAsCollectionextendColumnsIfRequired = null)
        {
            var __workflow_getCSVTextAsCollectioncSVFilePath = getCSVTextAsCollectioncSVFilePath == null ? null : WorkflowExpression.Compile(getCSVTextAsCollectioncSVFilePath);
            WorkflowExpression.Validate(__workflow_getCSVTextAsCollectioncSVFilePath, nameof(getCSVTextAsCollectioncSVFilePath), required: true);
            var __workflow_getCSVTextAsCollectionworkflow = getCSVTextAsCollectionworkflow == null ? null : WorkflowExpression.Compile(getCSVTextAsCollectionworkflow);
            WorkflowExpression.Validate(__workflow_getCSVTextAsCollectionworkflow, nameof(getCSVTextAsCollectionworkflow), required: true);
            var __workflow_getCSVTextAsCollectionfirstLineIsHeader = getCSVTextAsCollectionfirstLineIsHeader == null ? null : WorkflowExpression.Compile(getCSVTextAsCollectionfirstLineIsHeader);
            WorkflowExpression.Validate(__workflow_getCSVTextAsCollectionfirstLineIsHeader, nameof(getCSVTextAsCollectionfirstLineIsHeader), required: false);
            var __workflow_getCSVTextAsCollectiontrimHeaders = getCSVTextAsCollectiontrimHeaders == null ? null : WorkflowExpression.Compile(getCSVTextAsCollectiontrimHeaders);
            WorkflowExpression.Validate(__workflow_getCSVTextAsCollectiontrimHeaders, nameof(getCSVTextAsCollectiontrimHeaders), required: false);
            var __workflow_getCSVTextAsCollectionallowBlankRows = getCSVTextAsCollectionallowBlankRows == null ? null : WorkflowExpression.Compile(getCSVTextAsCollectionallowBlankRows);
            WorkflowExpression.Validate(__workflow_getCSVTextAsCollectionallowBlankRows, nameof(getCSVTextAsCollectionallowBlankRows), required: false);
            var __workflow_getCSVTextAsCollectionextendColumnsIfRequired = getCSVTextAsCollectionextendColumnsIfRequired == null ? null : WorkflowExpression.Compile(getCSVTextAsCollectionextendColumnsIfRequired);
            WorkflowExpression.Validate(__workflow_getCSVTextAsCollectionextendColumnsIfRequired, nameof(getCSVTextAsCollectionextendColumnsIfRequired), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WriteCollectionToCSVFileResponse> WriteCollectionToCSVFile(Expression<Func<string>> writeCollectionToCSVFilecSVFilePath, Expression<Func<string>> writeCollectionToCSVFileworkflow, Expression<Func<JToken[]>> writeCollectionToCSVFileinputTable = null, Expression<Func<string>> writeCollectionToCSVFileinputTableJSON = null, Expression<Func<writeCollectionToCSVFileoutputEncodingInput>> writeCollectionToCSVFileoutputEncoding = null)
        {
            var __workflow_writeCollectionToCSVFilecSVFilePath = writeCollectionToCSVFilecSVFilePath == null ? null : WorkflowExpression.Compile(writeCollectionToCSVFilecSVFilePath);
            WorkflowExpression.Validate(__workflow_writeCollectionToCSVFilecSVFilePath, nameof(writeCollectionToCSVFilecSVFilePath), required: true);
            var __workflow_writeCollectionToCSVFileworkflow = writeCollectionToCSVFileworkflow == null ? null : WorkflowExpression.Compile(writeCollectionToCSVFileworkflow);
            WorkflowExpression.Validate(__workflow_writeCollectionToCSVFileworkflow, nameof(writeCollectionToCSVFileworkflow), required: true);
            var __workflow_writeCollectionToCSVFileinputTable = writeCollectionToCSVFileinputTable == null ? null : WorkflowExpression.Compile(writeCollectionToCSVFileinputTable);
            WorkflowExpression.Validate(__workflow_writeCollectionToCSVFileinputTable, nameof(writeCollectionToCSVFileinputTable), required: false);
            var __workflow_writeCollectionToCSVFileinputTableJSON = writeCollectionToCSVFileinputTableJSON == null ? null : WorkflowExpression.Compile(writeCollectionToCSVFileinputTableJSON);
            WorkflowExpression.Validate(__workflow_writeCollectionToCSVFileinputTableJSON, nameof(writeCollectionToCSVFileinputTableJSON), required: false);
            var __workflow_writeCollectionToCSVFileoutputEncoding = writeCollectionToCSVFileoutputEncoding == null ? null : WorkflowExpression.Compile(writeCollectionToCSVFileoutputEncoding);
            WorkflowExpression.Validate(__workflow_writeCollectionToCSVFileoutputEncoding, nameof(writeCollectionToCSVFileoutputEncoding), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetOwnerOnFolder(Expression<Func<string>> setOwnerOnFolderfolderPath, Expression<Func<string>> setOwnerOnFolderuserIdentity, Expression<Func<string>> setOwnerOnFolderworkflow)
        {
            var __workflow_setOwnerOnFolderfolderPath = setOwnerOnFolderfolderPath == null ? null : WorkflowExpression.Compile(setOwnerOnFolderfolderPath);
            WorkflowExpression.Validate(__workflow_setOwnerOnFolderfolderPath, nameof(setOwnerOnFolderfolderPath), required: true);
            var __workflow_setOwnerOnFolderuserIdentity = setOwnerOnFolderuserIdentity == null ? null : WorkflowExpression.Compile(setOwnerOnFolderuserIdentity);
            WorkflowExpression.Validate(__workflow_setOwnerOnFolderuserIdentity, nameof(setOwnerOnFolderuserIdentity), required: true);
            var __workflow_setOwnerOnFolderworkflow = setOwnerOnFolderworkflow == null ? null : WorkflowExpression.Compile(setOwnerOnFolderworkflow);
            WorkflowExpression.Validate(__workflow_setOwnerOnFolderworkflow, nameof(setOwnerOnFolderworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetOwnerOnFile(Expression<Func<string>> setOwnerOnFilefilePath, Expression<Func<string>> setOwnerOnFileuserIdentity, Expression<Func<string>> setOwnerOnFileworkflow)
        {
            var __workflow_setOwnerOnFilefilePath = setOwnerOnFilefilePath == null ? null : WorkflowExpression.Compile(setOwnerOnFilefilePath);
            WorkflowExpression.Validate(__workflow_setOwnerOnFilefilePath, nameof(setOwnerOnFilefilePath), required: true);
            var __workflow_setOwnerOnFileuserIdentity = setOwnerOnFileuserIdentity == null ? null : WorkflowExpression.Compile(setOwnerOnFileuserIdentity);
            WorkflowExpression.Validate(__workflow_setOwnerOnFileuserIdentity, nameof(setOwnerOnFileuserIdentity), required: true);
            var __workflow_setOwnerOnFileworkflow = setOwnerOnFileworkflow == null ? null : WorkflowExpression.Compile(setOwnerOnFileworkflow);
            WorkflowExpression.Validate(__workflow_setOwnerOnFileworkflow, nameof(setOwnerOnFileworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddPermissionToFolder(Expression<Func<string>> addPermissionToFolderfolderPath, Expression<Func<string>> addPermissionToFolderidentity, Expression<Func<addPermissionToFolderpermissionInput>> addPermissionToFolderpermission, Expression<Func<string>> addPermissionToFolderworkflow, Expression<Func<bool>> addPermissionToFolderapplyToFolder = null, Expression<Func<bool>> addPermissionToFolderapplyToSubFolders = null, Expression<Func<bool>> addPermissionToFolderapplyToFiles = null, Expression<Func<bool>> addPermissionToFolderdeny = null)
        {
            var __workflow_addPermissionToFolderfolderPath = addPermissionToFolderfolderPath == null ? null : WorkflowExpression.Compile(addPermissionToFolderfolderPath);
            WorkflowExpression.Validate(__workflow_addPermissionToFolderfolderPath, nameof(addPermissionToFolderfolderPath), required: true);
            var __workflow_addPermissionToFolderidentity = addPermissionToFolderidentity == null ? null : WorkflowExpression.Compile(addPermissionToFolderidentity);
            WorkflowExpression.Validate(__workflow_addPermissionToFolderidentity, nameof(addPermissionToFolderidentity), required: true);
            var __workflow_addPermissionToFolderpermission = addPermissionToFolderpermission == null ? null : WorkflowExpression.Compile(addPermissionToFolderpermission);
            WorkflowExpression.Validate(__workflow_addPermissionToFolderpermission, nameof(addPermissionToFolderpermission), required: true);
            var __workflow_addPermissionToFolderworkflow = addPermissionToFolderworkflow == null ? null : WorkflowExpression.Compile(addPermissionToFolderworkflow);
            WorkflowExpression.Validate(__workflow_addPermissionToFolderworkflow, nameof(addPermissionToFolderworkflow), required: true);
            var __workflow_addPermissionToFolderapplyToFolder = addPermissionToFolderapplyToFolder == null ? null : WorkflowExpression.Compile(addPermissionToFolderapplyToFolder);
            WorkflowExpression.Validate(__workflow_addPermissionToFolderapplyToFolder, nameof(addPermissionToFolderapplyToFolder), required: false);
            var __workflow_addPermissionToFolderapplyToSubFolders = addPermissionToFolderapplyToSubFolders == null ? null : WorkflowExpression.Compile(addPermissionToFolderapplyToSubFolders);
            WorkflowExpression.Validate(__workflow_addPermissionToFolderapplyToSubFolders, nameof(addPermissionToFolderapplyToSubFolders), required: false);
            var __workflow_addPermissionToFolderapplyToFiles = addPermissionToFolderapplyToFiles == null ? null : WorkflowExpression.Compile(addPermissionToFolderapplyToFiles);
            WorkflowExpression.Validate(__workflow_addPermissionToFolderapplyToFiles, nameof(addPermissionToFolderapplyToFiles), required: false);
            var __workflow_addPermissionToFolderdeny = addPermissionToFolderdeny == null ? null : WorkflowExpression.Compile(addPermissionToFolderdeny);
            WorkflowExpression.Validate(__workflow_addPermissionToFolderdeny, nameof(addPermissionToFolderdeny), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddPermissionToFile(Expression<Func<string>> addPermissionToFilefilePath, Expression<Func<string>> addPermissionToFileidentity, Expression<Func<addPermissionToFilepermissionInput>> addPermissionToFilepermission, Expression<Func<string>> addPermissionToFileworkflow, Expression<Func<bool>> addPermissionToFiledeny = null)
        {
            var __workflow_addPermissionToFilefilePath = addPermissionToFilefilePath == null ? null : WorkflowExpression.Compile(addPermissionToFilefilePath);
            WorkflowExpression.Validate(__workflow_addPermissionToFilefilePath, nameof(addPermissionToFilefilePath), required: true);
            var __workflow_addPermissionToFileidentity = addPermissionToFileidentity == null ? null : WorkflowExpression.Compile(addPermissionToFileidentity);
            WorkflowExpression.Validate(__workflow_addPermissionToFileidentity, nameof(addPermissionToFileidentity), required: true);
            var __workflow_addPermissionToFilepermission = addPermissionToFilepermission == null ? null : WorkflowExpression.Compile(addPermissionToFilepermission);
            WorkflowExpression.Validate(__workflow_addPermissionToFilepermission, nameof(addPermissionToFilepermission), required: true);
            var __workflow_addPermissionToFileworkflow = addPermissionToFileworkflow == null ? null : WorkflowExpression.Compile(addPermissionToFileworkflow);
            WorkflowExpression.Validate(__workflow_addPermissionToFileworkflow, nameof(addPermissionToFileworkflow), required: true);
            var __workflow_addPermissionToFiledeny = addPermissionToFiledeny == null ? null : WorkflowExpression.Compile(addPermissionToFiledeny);
            WorkflowExpression.Validate(__workflow_addPermissionToFiledeny, nameof(addPermissionToFiledeny), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction BreakFolderSecurityInheritance(Expression<Func<string>> breakFolderSecurityInheritancefolderPath, Expression<Func<string>> breakFolderSecurityInheritanceworkflow, Expression<Func<bool>> breakFolderSecurityInheritanceconvertInheritedToExplicit = null)
        {
            var __workflow_breakFolderSecurityInheritancefolderPath = breakFolderSecurityInheritancefolderPath == null ? null : WorkflowExpression.Compile(breakFolderSecurityInheritancefolderPath);
            WorkflowExpression.Validate(__workflow_breakFolderSecurityInheritancefolderPath, nameof(breakFolderSecurityInheritancefolderPath), required: true);
            var __workflow_breakFolderSecurityInheritanceworkflow = breakFolderSecurityInheritanceworkflow == null ? null : WorkflowExpression.Compile(breakFolderSecurityInheritanceworkflow);
            WorkflowExpression.Validate(__workflow_breakFolderSecurityInheritanceworkflow, nameof(breakFolderSecurityInheritanceworkflow), required: true);
            var __workflow_breakFolderSecurityInheritanceconvertInheritedToExplicit = breakFolderSecurityInheritanceconvertInheritedToExplicit == null ? null : WorkflowExpression.Compile(breakFolderSecurityInheritanceconvertInheritedToExplicit);
            WorkflowExpression.Validate(__workflow_breakFolderSecurityInheritanceconvertInheritedToExplicit, nameof(breakFolderSecurityInheritanceconvertInheritedToExplicit), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction EnableFolderSecurityInheritance(Expression<Func<string>> enableFolderSecurityInheritancefolderPath, Expression<Func<string>> enableFolderSecurityInheritanceworkflow)
        {
            var __workflow_enableFolderSecurityInheritancefolderPath = enableFolderSecurityInheritancefolderPath == null ? null : WorkflowExpression.Compile(enableFolderSecurityInheritancefolderPath);
            WorkflowExpression.Validate(__workflow_enableFolderSecurityInheritancefolderPath, nameof(enableFolderSecurityInheritancefolderPath), required: true);
            var __workflow_enableFolderSecurityInheritanceworkflow = enableFolderSecurityInheritanceworkflow == null ? null : WorkflowExpression.Compile(enableFolderSecurityInheritanceworkflow);
            WorkflowExpression.Validate(__workflow_enableFolderSecurityInheritanceworkflow, nameof(enableFolderSecurityInheritanceworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFolderSecurityPermissionsResponse> GetFolderSecurityPermissions(Expression<Func<string>> getFolderSecurityPermissionsfolderPath, Expression<Func<string>> getFolderSecurityPermissionsworkflow)
        {
            var __workflow_getFolderSecurityPermissionsfolderPath = getFolderSecurityPermissionsfolderPath == null ? null : WorkflowExpression.Compile(getFolderSecurityPermissionsfolderPath);
            WorkflowExpression.Validate(__workflow_getFolderSecurityPermissionsfolderPath, nameof(getFolderSecurityPermissionsfolderPath), required: true);
            var __workflow_getFolderSecurityPermissionsworkflow = getFolderSecurityPermissionsworkflow == null ? null : WorkflowExpression.Compile(getFolderSecurityPermissionsworkflow);
            WorkflowExpression.Validate(__workflow_getFolderSecurityPermissionsworkflow, nameof(getFolderSecurityPermissionsworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileSecurityPermissionsResponse> GetFileSecurityPermissions(Expression<Func<string>> getFileSecurityPermissionsfilePath, Expression<Func<string>> getFileSecurityPermissionsworkflow)
        {
            var __workflow_getFileSecurityPermissionsfilePath = getFileSecurityPermissionsfilePath == null ? null : WorkflowExpression.Compile(getFileSecurityPermissionsfilePath);
            WorkflowExpression.Validate(__workflow_getFileSecurityPermissionsfilePath, nameof(getFileSecurityPermissionsfilePath), required: true);
            var __workflow_getFileSecurityPermissionsworkflow = getFileSecurityPermissionsworkflow == null ? null : WorkflowExpression.Compile(getFileSecurityPermissionsworkflow);
            WorkflowExpression.Validate(__workflow_getFileSecurityPermissionsworkflow, nameof(getFileSecurityPermissionsworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RemoveIdentityFromFolderSecurityResponse> RemoveIdentityFromFolderSecurity(Expression<Func<string>> removeIdentityFromFolderSecurityfolderPath, Expression<Func<string>> removeIdentityFromFolderSecurityidentityToRemove, Expression<Func<string>> removeIdentityFromFolderSecurityworkflow)
        {
            var __workflow_removeIdentityFromFolderSecurityfolderPath = removeIdentityFromFolderSecurityfolderPath == null ? null : WorkflowExpression.Compile(removeIdentityFromFolderSecurityfolderPath);
            WorkflowExpression.Validate(__workflow_removeIdentityFromFolderSecurityfolderPath, nameof(removeIdentityFromFolderSecurityfolderPath), required: true);
            var __workflow_removeIdentityFromFolderSecurityidentityToRemove = removeIdentityFromFolderSecurityidentityToRemove == null ? null : WorkflowExpression.Compile(removeIdentityFromFolderSecurityidentityToRemove);
            WorkflowExpression.Validate(__workflow_removeIdentityFromFolderSecurityidentityToRemove, nameof(removeIdentityFromFolderSecurityidentityToRemove), required: true);
            var __workflow_removeIdentityFromFolderSecurityworkflow = removeIdentityFromFolderSecurityworkflow == null ? null : WorkflowExpression.Compile(removeIdentityFromFolderSecurityworkflow);
            WorkflowExpression.Validate(__workflow_removeIdentityFromFolderSecurityworkflow, nameof(removeIdentityFromFolderSecurityworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RemoveIdentityFromFileSecurityResponse> RemoveIdentityFromFileSecurity(Expression<Func<string>> removeIdentityFromFileSecurityfilePath, Expression<Func<string>> removeIdentityFromFileSecurityidentityToRemove, Expression<Func<string>> removeIdentityFromFileSecurityworkflow)
        {
            var __workflow_removeIdentityFromFileSecurityfilePath = removeIdentityFromFileSecurityfilePath == null ? null : WorkflowExpression.Compile(removeIdentityFromFileSecurityfilePath);
            WorkflowExpression.Validate(__workflow_removeIdentityFromFileSecurityfilePath, nameof(removeIdentityFromFileSecurityfilePath), required: true);
            var __workflow_removeIdentityFromFileSecurityidentityToRemove = removeIdentityFromFileSecurityidentityToRemove == null ? null : WorkflowExpression.Compile(removeIdentityFromFileSecurityidentityToRemove);
            WorkflowExpression.Validate(__workflow_removeIdentityFromFileSecurityidentityToRemove, nameof(removeIdentityFromFileSecurityidentityToRemove), required: true);
            var __workflow_removeIdentityFromFileSecurityworkflow = removeIdentityFromFileSecurityworkflow == null ? null : WorkflowExpression.Compile(removeIdentityFromFileSecurityworkflow);
            WorkflowExpression.Validate(__workflow_removeIdentityFromFileSecurityworkflow, nameof(removeIdentityFromFileSecurityworkflow), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CopyFileFromClientToServer(Expression<Func<string>> copyFileFromClientToServerclientFilePath, Expression<Func<string>> copyFileFromClientToServerserverFilePath, Expression<Func<string>> copyFileFromClientToServerworkflow, Expression<Func<bool>> copyFileFromClientToServercompress = null)
        {
            var __workflow_copyFileFromClientToServerclientFilePath = copyFileFromClientToServerclientFilePath == null ? null : WorkflowExpression.Compile(copyFileFromClientToServerclientFilePath);
            WorkflowExpression.Validate(__workflow_copyFileFromClientToServerclientFilePath, nameof(copyFileFromClientToServerclientFilePath), required: true);
            var __workflow_copyFileFromClientToServerserverFilePath = copyFileFromClientToServerserverFilePath == null ? null : WorkflowExpression.Compile(copyFileFromClientToServerserverFilePath);
            WorkflowExpression.Validate(__workflow_copyFileFromClientToServerserverFilePath, nameof(copyFileFromClientToServerserverFilePath), required: true);
            var __workflow_copyFileFromClientToServerworkflow = copyFileFromClientToServerworkflow == null ? null : WorkflowExpression.Compile(copyFileFromClientToServerworkflow);
            WorkflowExpression.Validate(__workflow_copyFileFromClientToServerworkflow, nameof(copyFileFromClientToServerworkflow), required: true);
            var __workflow_copyFileFromClientToServercompress = copyFileFromClientToServercompress == null ? null : WorkflowExpression.Compile(copyFileFromClientToServercompress);
            WorkflowExpression.Validate(__workflow_copyFileFromClientToServercompress, nameof(copyFileFromClientToServercompress), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ReplaceVariableDataInINIFile(Expression<Func<string>> replaceVariableDataInINIFileinputFilename, Expression<Func<string>> replaceVariableDataInINIFileworkflow, Expression<Func<string>> replaceVariableDataInINIFileoutputFilename = null, Expression<Func<string>> replaceVariableDataInINIFilesearchSection = null, Expression<Func<string>> replaceVariableDataInINIFilesearchVariable = null, Expression<Func<string>> replaceVariableDataInINIFilereplaceData = null, Expression<Func<string>> replaceVariableDataInINIFileinputFilenameEncoding = null, Expression<Func<bool>> replaceVariableDataInINIFilecreateNewFileIfNotExists = null, Expression<Func<bool>> replaceVariableDataInINIFilewriteSpaceBeforeEquals = null, Expression<Func<bool>> replaceVariableDataInINIFilewriteSpaceAfterEquals = null)
        {
            var __workflow_replaceVariableDataInINIFileinputFilename = replaceVariableDataInINIFileinputFilename == null ? null : WorkflowExpression.Compile(replaceVariableDataInINIFileinputFilename);
            WorkflowExpression.Validate(__workflow_replaceVariableDataInINIFileinputFilename, nameof(replaceVariableDataInINIFileinputFilename), required: true);
            var __workflow_replaceVariableDataInINIFileworkflow = replaceVariableDataInINIFileworkflow == null ? null : WorkflowExpression.Compile(replaceVariableDataInINIFileworkflow);
            WorkflowExpression.Validate(__workflow_replaceVariableDataInINIFileworkflow, nameof(replaceVariableDataInINIFileworkflow), required: true);
            var __workflow_replaceVariableDataInINIFileoutputFilename = replaceVariableDataInINIFileoutputFilename == null ? null : WorkflowExpression.Compile(replaceVariableDataInINIFileoutputFilename);
            WorkflowExpression.Validate(__workflow_replaceVariableDataInINIFileoutputFilename, nameof(replaceVariableDataInINIFileoutputFilename), required: false);
            var __workflow_replaceVariableDataInINIFilesearchSection = replaceVariableDataInINIFilesearchSection == null ? null : WorkflowExpression.Compile(replaceVariableDataInINIFilesearchSection);
            WorkflowExpression.Validate(__workflow_replaceVariableDataInINIFilesearchSection, nameof(replaceVariableDataInINIFilesearchSection), required: false);
            var __workflow_replaceVariableDataInINIFilesearchVariable = replaceVariableDataInINIFilesearchVariable == null ? null : WorkflowExpression.Compile(replaceVariableDataInINIFilesearchVariable);
            WorkflowExpression.Validate(__workflow_replaceVariableDataInINIFilesearchVariable, nameof(replaceVariableDataInINIFilesearchVariable), required: false);
            var __workflow_replaceVariableDataInINIFilereplaceData = replaceVariableDataInINIFilereplaceData == null ? null : WorkflowExpression.Compile(replaceVariableDataInINIFilereplaceData);
            WorkflowExpression.Validate(__workflow_replaceVariableDataInINIFilereplaceData, nameof(replaceVariableDataInINIFilereplaceData), required: false);
            var __workflow_replaceVariableDataInINIFileinputFilenameEncoding = replaceVariableDataInINIFileinputFilenameEncoding == null ? null : WorkflowExpression.Compile(replaceVariableDataInINIFileinputFilenameEncoding);
            WorkflowExpression.Validate(__workflow_replaceVariableDataInINIFileinputFilenameEncoding, nameof(replaceVariableDataInINIFileinputFilenameEncoding), required: false);
            var __workflow_replaceVariableDataInINIFilecreateNewFileIfNotExists = replaceVariableDataInINIFilecreateNewFileIfNotExists == null ? null : WorkflowExpression.Compile(replaceVariableDataInINIFilecreateNewFileIfNotExists);
            WorkflowExpression.Validate(__workflow_replaceVariableDataInINIFilecreateNewFileIfNotExists, nameof(replaceVariableDataInINIFilecreateNewFileIfNotExists), required: false);
            var __workflow_replaceVariableDataInINIFilewriteSpaceBeforeEquals = replaceVariableDataInINIFilewriteSpaceBeforeEquals == null ? null : WorkflowExpression.Compile(replaceVariableDataInINIFilewriteSpaceBeforeEquals);
            WorkflowExpression.Validate(__workflow_replaceVariableDataInINIFilewriteSpaceBeforeEquals, nameof(replaceVariableDataInINIFilewriteSpaceBeforeEquals), required: false);
            var __workflow_replaceVariableDataInINIFilewriteSpaceAfterEquals = replaceVariableDataInINIFilewriteSpaceAfterEquals == null ? null : WorkflowExpression.Compile(replaceVariableDataInINIFilewriteSpaceAfterEquals);
            WorkflowExpression.Validate(__workflow_replaceVariableDataInINIFilewriteSpaceAfterEquals, nameof(replaceVariableDataInINIFilewriteSpaceAfterEquals), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DownloadHTTPFileResponse> DownloadHTTPFile(Expression<Func<string>> downloadHTTPFiledownloadURL, Expression<Func<string>> downloadHTTPFileworkflow, Expression<Func<string>> downloadHTTPFilesaveFilename = null, Expression<Func<bool>> downloadHTTPFileoverwriteExistingFile = null, Expression<Func<bool>> downloadHTTPFilepassthroughAuthentication = null, Expression<Func<string>> downloadHTTPFileuserAgent = null, Expression<Func<string>> downloadHTTPFileaccept = null, Expression<Func<bool>> downloadHTTPFilesupportTLS10 = null, Expression<Func<bool>> downloadHTTPFilesupportTLS11 = null, Expression<Func<bool>> downloadHTTPFilesupportTLS12 = null, Expression<Func<bool>> downloadHTTPFileautoDecompressDeflate = null, Expression<Func<bool>> downloadHTTPFileautoDecompressGZIP = null, Expression<Func<bool>> downloadHTTPFilereturnContentsAsString = null, Expression<Func<downloadHTTPFilereturnContentEncodingInput>> downloadHTTPFilereturnContentEncoding = null)
        {
            var __workflow_downloadHTTPFiledownloadURL = downloadHTTPFiledownloadURL == null ? null : WorkflowExpression.Compile(downloadHTTPFiledownloadURL);
            WorkflowExpression.Validate(__workflow_downloadHTTPFiledownloadURL, nameof(downloadHTTPFiledownloadURL), required: true);
            var __workflow_downloadHTTPFileworkflow = downloadHTTPFileworkflow == null ? null : WorkflowExpression.Compile(downloadHTTPFileworkflow);
            WorkflowExpression.Validate(__workflow_downloadHTTPFileworkflow, nameof(downloadHTTPFileworkflow), required: true);
            var __workflow_downloadHTTPFilesaveFilename = downloadHTTPFilesaveFilename == null ? null : WorkflowExpression.Compile(downloadHTTPFilesaveFilename);
            WorkflowExpression.Validate(__workflow_downloadHTTPFilesaveFilename, nameof(downloadHTTPFilesaveFilename), required: false);
            var __workflow_downloadHTTPFileoverwriteExistingFile = downloadHTTPFileoverwriteExistingFile == null ? null : WorkflowExpression.Compile(downloadHTTPFileoverwriteExistingFile);
            WorkflowExpression.Validate(__workflow_downloadHTTPFileoverwriteExistingFile, nameof(downloadHTTPFileoverwriteExistingFile), required: false);
            var __workflow_downloadHTTPFilepassthroughAuthentication = downloadHTTPFilepassthroughAuthentication == null ? null : WorkflowExpression.Compile(downloadHTTPFilepassthroughAuthentication);
            WorkflowExpression.Validate(__workflow_downloadHTTPFilepassthroughAuthentication, nameof(downloadHTTPFilepassthroughAuthentication), required: false);
            var __workflow_downloadHTTPFileuserAgent = downloadHTTPFileuserAgent == null ? null : WorkflowExpression.Compile(downloadHTTPFileuserAgent);
            WorkflowExpression.Validate(__workflow_downloadHTTPFileuserAgent, nameof(downloadHTTPFileuserAgent), required: false);
            var __workflow_downloadHTTPFileaccept = downloadHTTPFileaccept == null ? null : WorkflowExpression.Compile(downloadHTTPFileaccept);
            WorkflowExpression.Validate(__workflow_downloadHTTPFileaccept, nameof(downloadHTTPFileaccept), required: false);
            var __workflow_downloadHTTPFilesupportTLS10 = downloadHTTPFilesupportTLS10 == null ? null : WorkflowExpression.Compile(downloadHTTPFilesupportTLS10);
            WorkflowExpression.Validate(__workflow_downloadHTTPFilesupportTLS10, nameof(downloadHTTPFilesupportTLS10), required: false);
            var __workflow_downloadHTTPFilesupportTLS11 = downloadHTTPFilesupportTLS11 == null ? null : WorkflowExpression.Compile(downloadHTTPFilesupportTLS11);
            WorkflowExpression.Validate(__workflow_downloadHTTPFilesupportTLS11, nameof(downloadHTTPFilesupportTLS11), required: false);
            var __workflow_downloadHTTPFilesupportTLS12 = downloadHTTPFilesupportTLS12 == null ? null : WorkflowExpression.Compile(downloadHTTPFilesupportTLS12);
            WorkflowExpression.Validate(__workflow_downloadHTTPFilesupportTLS12, nameof(downloadHTTPFilesupportTLS12), required: false);
            var __workflow_downloadHTTPFileautoDecompressDeflate = downloadHTTPFileautoDecompressDeflate == null ? null : WorkflowExpression.Compile(downloadHTTPFileautoDecompressDeflate);
            WorkflowExpression.Validate(__workflow_downloadHTTPFileautoDecompressDeflate, nameof(downloadHTTPFileautoDecompressDeflate), required: false);
            var __workflow_downloadHTTPFileautoDecompressGZIP = downloadHTTPFileautoDecompressGZIP == null ? null : WorkflowExpression.Compile(downloadHTTPFileautoDecompressGZIP);
            WorkflowExpression.Validate(__workflow_downloadHTTPFileautoDecompressGZIP, nameof(downloadHTTPFileautoDecompressGZIP), required: false);
            var __workflow_downloadHTTPFilereturnContentsAsString = downloadHTTPFilereturnContentsAsString == null ? null : WorkflowExpression.Compile(downloadHTTPFilereturnContentsAsString);
            WorkflowExpression.Validate(__workflow_downloadHTTPFilereturnContentsAsString, nameof(downloadHTTPFilereturnContentsAsString), required: false);
            var __workflow_downloadHTTPFilereturnContentEncoding = downloadHTTPFilereturnContentEncoding == null ? null : WorkflowExpression.Compile(downloadHTTPFilereturnContentEncoding);
            WorkflowExpression.Validate(__workflow_downloadHTTPFilereturnContentEncoding, nameof(downloadHTTPFilereturnContentEncoding), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UnZIPFileResponse> UnZIPFile(Expression<Func<string>> unZIPFilezIPFilename, Expression<Func<string>> unZIPFileworkflow, Expression<Func<string>> unZIPFileextractFolder = null, Expression<Func<bool>> unZIPFileextractAllFilesToSingleFolder = null, Expression<Func<string>> unZIPFileincludeFilesRegEx = null, Expression<Func<string>> unZIPFileexcludeFilesRegEx = null)
        {
            var __workflow_unZIPFilezIPFilename = unZIPFilezIPFilename == null ? null : WorkflowExpression.Compile(unZIPFilezIPFilename);
            WorkflowExpression.Validate(__workflow_unZIPFilezIPFilename, nameof(unZIPFilezIPFilename), required: true);
            var __workflow_unZIPFileworkflow = unZIPFileworkflow == null ? null : WorkflowExpression.Compile(unZIPFileworkflow);
            WorkflowExpression.Validate(__workflow_unZIPFileworkflow, nameof(unZIPFileworkflow), required: true);
            var __workflow_unZIPFileextractFolder = unZIPFileextractFolder == null ? null : WorkflowExpression.Compile(unZIPFileextractFolder);
            WorkflowExpression.Validate(__workflow_unZIPFileextractFolder, nameof(unZIPFileextractFolder), required: false);
            var __workflow_unZIPFileextractAllFilesToSingleFolder = unZIPFileextractAllFilesToSingleFolder == null ? null : WorkflowExpression.Compile(unZIPFileextractAllFilesToSingleFolder);
            WorkflowExpression.Validate(__workflow_unZIPFileextractAllFilesToSingleFolder, nameof(unZIPFileextractAllFilesToSingleFolder), required: false);
            var __workflow_unZIPFileincludeFilesRegEx = unZIPFileincludeFilesRegEx == null ? null : WorkflowExpression.Compile(unZIPFileincludeFilesRegEx);
            WorkflowExpression.Validate(__workflow_unZIPFileincludeFilesRegEx, nameof(unZIPFileincludeFilesRegEx), required: false);
            var __workflow_unZIPFileexcludeFilesRegEx = unZIPFileexcludeFilesRegEx == null ? null : WorkflowExpression.Compile(unZIPFileexcludeFilesRegEx);
            WorkflowExpression.Validate(__workflow_unZIPFileexcludeFilesRegEx, nameof(unZIPFileexcludeFilesRegEx), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddFileToZIP(Expression<Func<string>> addFileToZIPsourceFilenameToAddToZIP, Expression<Func<string>> addFileToZIPoutputZIPFilename, Expression<Func<string>> addFileToZIPworkflow, Expression<Func<string>> addFileToZIPaddFilenameToFolderInZIP = null, Expression<Func<string>> addFileToZIPsourceFilenameToAddToZIPComment = null, Expression<Func<bool>> addFileToZIPcompress = null, Expression<Func<bool>> addFileToZIPaddToExistingZIPFile = null)
        {
            var __workflow_addFileToZIPsourceFilenameToAddToZIP = addFileToZIPsourceFilenameToAddToZIP == null ? null : WorkflowExpression.Compile(addFileToZIPsourceFilenameToAddToZIP);
            WorkflowExpression.Validate(__workflow_addFileToZIPsourceFilenameToAddToZIP, nameof(addFileToZIPsourceFilenameToAddToZIP), required: true);
            var __workflow_addFileToZIPoutputZIPFilename = addFileToZIPoutputZIPFilename == null ? null : WorkflowExpression.Compile(addFileToZIPoutputZIPFilename);
            WorkflowExpression.Validate(__workflow_addFileToZIPoutputZIPFilename, nameof(addFileToZIPoutputZIPFilename), required: true);
            var __workflow_addFileToZIPworkflow = addFileToZIPworkflow == null ? null : WorkflowExpression.Compile(addFileToZIPworkflow);
            WorkflowExpression.Validate(__workflow_addFileToZIPworkflow, nameof(addFileToZIPworkflow), required: true);
            var __workflow_addFileToZIPaddFilenameToFolderInZIP = addFileToZIPaddFilenameToFolderInZIP == null ? null : WorkflowExpression.Compile(addFileToZIPaddFilenameToFolderInZIP);
            WorkflowExpression.Validate(__workflow_addFileToZIPaddFilenameToFolderInZIP, nameof(addFileToZIPaddFilenameToFolderInZIP), required: false);
            var __workflow_addFileToZIPsourceFilenameToAddToZIPComment = addFileToZIPsourceFilenameToAddToZIPComment == null ? null : WorkflowExpression.Compile(addFileToZIPsourceFilenameToAddToZIPComment);
            WorkflowExpression.Validate(__workflow_addFileToZIPsourceFilenameToAddToZIPComment, nameof(addFileToZIPsourceFilenameToAddToZIPComment), required: false);
            var __workflow_addFileToZIPcompress = addFileToZIPcompress == null ? null : WorkflowExpression.Compile(addFileToZIPcompress);
            WorkflowExpression.Validate(__workflow_addFileToZIPcompress, nameof(addFileToZIPcompress), required: false);
            var __workflow_addFileToZIPaddToExistingZIPFile = addFileToZIPaddToExistingZIPFile == null ? null : WorkflowExpression.Compile(addFileToZIPaddToExistingZIPFile);
            WorkflowExpression.Validate(__workflow_addFileToZIPaddToExistingZIPFile, nameof(addFileToZIPaddToExistingZIPFile), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AddFolderToZIPResponse> AddFolderToZIP(Expression<Func<string>> addFolderToZIPsourceFolderToAddToZIP, Expression<Func<string>> addFolderToZIPoutputZIPFilename, Expression<Func<string>> addFolderToZIPworkflow, Expression<Func<string>> addFolderToZIPaddFilesToFolderInZIP = null, Expression<Func<bool>> addFolderToZIPcompress = null, Expression<Func<bool>> addFolderToZIPaddToExistingZIPFile = null, Expression<Func<bool>> addFolderToZIPincludeSubfolders = null, Expression<Func<string>> addFolderToZIPincludeFilesRegEx = null, Expression<Func<string>> addFolderToZIPexcludeFilesRegEx = null)
        {
            var __workflow_addFolderToZIPsourceFolderToAddToZIP = addFolderToZIPsourceFolderToAddToZIP == null ? null : WorkflowExpression.Compile(addFolderToZIPsourceFolderToAddToZIP);
            WorkflowExpression.Validate(__workflow_addFolderToZIPsourceFolderToAddToZIP, nameof(addFolderToZIPsourceFolderToAddToZIP), required: true);
            var __workflow_addFolderToZIPoutputZIPFilename = addFolderToZIPoutputZIPFilename == null ? null : WorkflowExpression.Compile(addFolderToZIPoutputZIPFilename);
            WorkflowExpression.Validate(__workflow_addFolderToZIPoutputZIPFilename, nameof(addFolderToZIPoutputZIPFilename), required: true);
            var __workflow_addFolderToZIPworkflow = addFolderToZIPworkflow == null ? null : WorkflowExpression.Compile(addFolderToZIPworkflow);
            WorkflowExpression.Validate(__workflow_addFolderToZIPworkflow, nameof(addFolderToZIPworkflow), required: true);
            var __workflow_addFolderToZIPaddFilesToFolderInZIP = addFolderToZIPaddFilesToFolderInZIP == null ? null : WorkflowExpression.Compile(addFolderToZIPaddFilesToFolderInZIP);
            WorkflowExpression.Validate(__workflow_addFolderToZIPaddFilesToFolderInZIP, nameof(addFolderToZIPaddFilesToFolderInZIP), required: false);
            var __workflow_addFolderToZIPcompress = addFolderToZIPcompress == null ? null : WorkflowExpression.Compile(addFolderToZIPcompress);
            WorkflowExpression.Validate(__workflow_addFolderToZIPcompress, nameof(addFolderToZIPcompress), required: false);
            var __workflow_addFolderToZIPaddToExistingZIPFile = addFolderToZIPaddToExistingZIPFile == null ? null : WorkflowExpression.Compile(addFolderToZIPaddToExistingZIPFile);
            WorkflowExpression.Validate(__workflow_addFolderToZIPaddToExistingZIPFile, nameof(addFolderToZIPaddToExistingZIPFile), required: false);
            var __workflow_addFolderToZIPincludeSubfolders = addFolderToZIPincludeSubfolders == null ? null : WorkflowExpression.Compile(addFolderToZIPincludeSubfolders);
            WorkflowExpression.Validate(__workflow_addFolderToZIPincludeSubfolders, nameof(addFolderToZIPincludeSubfolders), required: false);
            var __workflow_addFolderToZIPincludeFilesRegEx = addFolderToZIPincludeFilesRegEx == null ? null : WorkflowExpression.Compile(addFolderToZIPincludeFilesRegEx);
            WorkflowExpression.Validate(__workflow_addFolderToZIPincludeFilesRegEx, nameof(addFolderToZIPincludeFilesRegEx), required: false);
            var __workflow_addFolderToZIPexcludeFilesRegEx = addFolderToZIPexcludeFilesRegEx == null ? null : WorkflowExpression.Compile(addFolderToZIPexcludeFilesRegEx);
            WorkflowExpression.Validate(__workflow_addFolderToZIPexcludeFilesRegEx, nameof(addFolderToZIPexcludeFilesRegEx), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileContentsAsBase64Response> GetFileContentsAsBase64(Expression<Func<string>> getFileContentsAsBase64filePath, Expression<Func<string>> getFileContentsAsBase64workflow, Expression<Func<bool>> getFileContentsAsBase64compress = null, Expression<Func<int>> getFileContentsAsBase64maxFileSize = null)
        {
            var __workflow_getFileContentsAsBase64filePath = getFileContentsAsBase64filePath == null ? null : WorkflowExpression.Compile(getFileContentsAsBase64filePath);
            WorkflowExpression.Validate(__workflow_getFileContentsAsBase64filePath, nameof(getFileContentsAsBase64filePath), required: true);
            var __workflow_getFileContentsAsBase64workflow = getFileContentsAsBase64workflow == null ? null : WorkflowExpression.Compile(getFileContentsAsBase64workflow);
            WorkflowExpression.Validate(__workflow_getFileContentsAsBase64workflow, nameof(getFileContentsAsBase64workflow), required: true);
            var __workflow_getFileContentsAsBase64compress = getFileContentsAsBase64compress == null ? null : WorkflowExpression.Compile(getFileContentsAsBase64compress);
            WorkflowExpression.Validate(__workflow_getFileContentsAsBase64compress, nameof(getFileContentsAsBase64compress), required: false);
            var __workflow_getFileContentsAsBase64maxFileSize = getFileContentsAsBase64maxFileSize == null ? null : WorkflowExpression.Compile(getFileContentsAsBase64maxFileSize);
            WorkflowExpression.Validate(__workflow_getFileContentsAsBase64maxFileSize, nameof(getFileContentsAsBase64maxFileSize), required: false);
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
