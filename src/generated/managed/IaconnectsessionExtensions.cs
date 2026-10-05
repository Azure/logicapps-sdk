//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectsessionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetMachineName))]
        public IBodyWorkflowAction<GetMachineNameResponse> GetMachineName([WorkflowExpression] Func<string> getMachineNameworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMachineNameResponse> __BuildGetMachineName(WorkflowValue<string> getMachineNameworkflow)
        {
            WorkflowValue.Validate(getMachineNameworkflow, nameof(getMachineNameworkflow), required: true);
            return new DeferredBodyAction<GetMachineNameResponse>(() =>
            {
                var apiCallPath = "/Environment/GetMachineName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getMachineName = new JObject();
                var getMachineNamepropCount = 0;
                getMachineNamepropCount++;
                getMachineName["Workflow"] = ExpressionConverter.ConvertO(getMachineNameworkflow);
                if (getMachineNamepropCount > 0)
                {
                    callPayload.Body = getMachineName;
                }

                return new ApiConnectionAction<GetMachineNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetMachineDomain))]
        public IBodyWorkflowAction<GetMachineDomainResponse> GetMachineDomain([WorkflowExpression] Func<string> getMachineDomainworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMachineDomainResponse> __BuildGetMachineDomain(WorkflowValue<string> getMachineDomainworkflow)
        {
            WorkflowValue.Validate(getMachineDomainworkflow, nameof(getMachineDomainworkflow), required: true);
            return new DeferredBodyAction<GetMachineDomainResponse>(() =>
            {
                var apiCallPath = "/Environment/GetMachineDomain";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getMachineDomain = new JObject();
                var getMachineDomainpropCount = 0;
                getMachineDomainpropCount++;
                getMachineDomain["Workflow"] = ExpressionConverter.ConvertO(getMachineDomainworkflow);
                if (getMachineDomainpropCount > 0)
                {
                    callPayload.Body = getMachineDomain;
                }

                return new ApiConnectionAction<GetMachineDomainResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetRemoteSessionClientHostname))]
        public IBodyWorkflowAction<GetRemoteSessionClientHostnameResponse> GetRemoteSessionClientHostname([WorkflowExpression] Func<string> getRemoteSessionClientHostnameworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRemoteSessionClientHostnameResponse> __BuildGetRemoteSessionClientHostname(WorkflowValue<string> getRemoteSessionClientHostnameworkflow)
        {
            WorkflowValue.Validate(getRemoteSessionClientHostnameworkflow, nameof(getRemoteSessionClientHostnameworkflow), required: true);
            return new DeferredBodyAction<GetRemoteSessionClientHostnameResponse>(() =>
            {
                var apiCallPath = "/Environment/GetRemoteSessionClientHostname";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRemoteSessionClientHostname = new JObject();
                var getRemoteSessionClientHostnamepropCount = 0;
                getRemoteSessionClientHostnamepropCount++;
                getRemoteSessionClientHostname["Workflow"] = ExpressionConverter.ConvertO(getRemoteSessionClientHostnameworkflow);
                if (getRemoteSessionClientHostnamepropCount > 0)
                {
                    callPayload.Body = getRemoteSessionClientHostname;
                }

                return new ApiConnectionAction<GetRemoteSessionClientHostnameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildExpandEnvironmentVariable))]
        public IBodyWorkflowAction<ExpandEnvironmentVariableResponse> ExpandEnvironmentVariable([WorkflowExpression] Func<string> expandEnvironmentVariableinputString, [WorkflowExpression] Func<string> expandEnvironmentVariableworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExpandEnvironmentVariableResponse> __BuildExpandEnvironmentVariable(WorkflowValue<string> expandEnvironmentVariableinputString, WorkflowValue<string> expandEnvironmentVariableworkflow)
        {
            WorkflowValue.Validate(expandEnvironmentVariableinputString, nameof(expandEnvironmentVariableinputString), required: true);
            WorkflowValue.Validate(expandEnvironmentVariableworkflow, nameof(expandEnvironmentVariableworkflow), required: true);
            return new DeferredBodyAction<ExpandEnvironmentVariableResponse>(() =>
            {
                var apiCallPath = "/Environment/ExpandEnvironmentVariable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var expandEnvironmentVariable = new JObject();
                var expandEnvironmentVariablepropCount = 0;
                expandEnvironmentVariablepropCount++;
                expandEnvironmentVariable["InputString"] = ExpressionConverter.ConvertO(expandEnvironmentVariableinputString);
                expandEnvironmentVariablepropCount++;
                expandEnvironmentVariable["Workflow"] = ExpressionConverter.ConvertO(expandEnvironmentVariableworkflow);
                if (expandEnvironmentVariablepropCount > 0)
                {
                    callPayload.Body = expandEnvironmentVariable;
                }

                return new ApiConnectionAction<ExpandEnvironmentVariableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildKillProcess))]
        public IBodyWorkflowAction<KillProcessResponse> KillProcess([WorkflowExpression] Func<string> killProcessprocessName, [WorkflowExpression] Func<string> killProcessworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KillProcessResponse> __BuildKillProcess(WorkflowValue<string> killProcessprocessName, WorkflowValue<string> killProcessworkflow)
        {
            WorkflowValue.Validate(killProcessprocessName, nameof(killProcessprocessName), required: true);
            WorkflowValue.Validate(killProcessworkflow, nameof(killProcessworkflow), required: true);
            return new DeferredBodyAction<KillProcessResponse>(() =>
            {
                var apiCallPath = "/Environment/KillProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var killProcess = new JObject();
                var killProcesspropCount = 0;
                killProcesspropCount++;
                killProcess["ProcessName"] = ExpressionConverter.ConvertO(killProcessprocessName);
                killProcesspropCount++;
                killProcess["Workflow"] = ExpressionConverter.ConvertO(killProcessworkflow);
                if (killProcesspropCount > 0)
                {
                    callPayload.Body = killProcess;
                }

                return new ApiConnectionAction<KillProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildKillProcessID))]
        public IBodyWorkflowAction<KillProcessIDResponse> KillProcessID([WorkflowExpression] Func<int> killProcessIDprocessID, [WorkflowExpression] Func<string> killProcessIDworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KillProcessIDResponse> __BuildKillProcessID(WorkflowValue<int> killProcessIDprocessID, WorkflowValue<string> killProcessIDworkflow)
        {
            WorkflowValue.Validate(killProcessIDprocessID, nameof(killProcessIDprocessID), required: true);
            WorkflowValue.Validate(killProcessIDworkflow, nameof(killProcessIDworkflow), required: true);
            return new DeferredBodyAction<KillProcessIDResponse>(() =>
            {
                var apiCallPath = "/Environment/KillProcessID";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var killProcessID = new JObject();
                var killProcessIDpropCount = 0;
                killProcessIDpropCount++;
                killProcessID["ProcessID"] = ExpressionConverter.ConvertO(killProcessIDprocessID);
                killProcessIDpropCount++;
                killProcessID["Workflow"] = ExpressionConverter.ConvertO(killProcessIDworkflow);
                if (killProcessIDpropCount > 0)
                {
                    callPayload.Body = killProcessID;
                }

                return new ApiConnectionAction<KillProcessIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetProcessCountByName))]
        public IBodyWorkflowAction<GetProcessCountByNameResponse> GetProcessCountByName([WorkflowExpression] Func<string> getProcessCountByNameprocessName, [WorkflowExpression] Func<string> getProcessCountByNameworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProcessCountByNameResponse> __BuildGetProcessCountByName(WorkflowValue<string> getProcessCountByNameprocessName, WorkflowValue<string> getProcessCountByNameworkflow)
        {
            WorkflowValue.Validate(getProcessCountByNameprocessName, nameof(getProcessCountByNameprocessName), required: true);
            WorkflowValue.Validate(getProcessCountByNameworkflow, nameof(getProcessCountByNameworkflow), required: true);
            return new DeferredBodyAction<GetProcessCountByNameResponse>(() =>
            {
                var apiCallPath = "/Environment/GetProcessCountByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getProcessCountByName = new JObject();
                var getProcessCountByNamepropCount = 0;
                getProcessCountByNamepropCount++;
                getProcessCountByName["ProcessName"] = ExpressionConverter.ConvertO(getProcessCountByNameprocessName);
                getProcessCountByNamepropCount++;
                getProcessCountByName["Workflow"] = ExpressionConverter.ConvertO(getProcessCountByNameworkflow);
                if (getProcessCountByNamepropCount > 0)
                {
                    callPayload.Body = getProcessCountByName;
                }

                return new ApiConnectionAction<GetProcessCountByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetAgentProcessCount))]
        public IBodyWorkflowAction<GetAgentProcessCountResponse> GetAgentProcessCount([WorkflowExpression] Func<string> getAgentProcessCountworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAgentProcessCountResponse> __BuildGetAgentProcessCount(WorkflowValue<string> getAgentProcessCountworkflow)
        {
            WorkflowValue.Validate(getAgentProcessCountworkflow, nameof(getAgentProcessCountworkflow), required: true);
            return new DeferredBodyAction<GetAgentProcessCountResponse>(() =>
            {
                var apiCallPath = "/Environment/GetAgentProcessCount";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getAgentProcessCount = new JObject();
                var getAgentProcessCountpropCount = 0;
                getAgentProcessCountpropCount++;
                getAgentProcessCount["Workflow"] = ExpressionConverter.ConvertO(getAgentProcessCountworkflow);
                if (getAgentProcessCountpropCount > 0)
                {
                    callPayload.Body = getAgentProcessCount;
                }

                return new ApiConnectionAction<GetAgentProcessCountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildKillAllOtherAgents))]
        public IBodyWorkflowAction<KillAllOtherAgentsResponse> KillAllOtherAgents([WorkflowExpression] Func<string> killAllOtherAgentsworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KillAllOtherAgentsResponse> __BuildKillAllOtherAgents(WorkflowValue<string> killAllOtherAgentsworkflow)
        {
            WorkflowValue.Validate(killAllOtherAgentsworkflow, nameof(killAllOtherAgentsworkflow), required: true);
            return new DeferredBodyAction<KillAllOtherAgentsResponse>(() =>
            {
                var apiCallPath = "/Environment/KillAllOtherAgents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var killAllOtherAgents = new JObject();
                var killAllOtherAgentspropCount = 0;
                killAllOtherAgentspropCount++;
                killAllOtherAgents["Workflow"] = ExpressionConverter.ConvertO(killAllOtherAgentsworkflow);
                if (killAllOtherAgentspropCount > 0)
                {
                    callPayload.Body = killAllOtherAgents;
                }

                return new ApiConnectionAction<KillAllOtherAgentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetProcessByPID))]
        public IBodyWorkflowAction<GetProcessByPIDResponse> GetProcessByPID([WorkflowExpression] Func<int> getProcessByPIDprocessId, [WorkflowExpression] Func<string> getProcessByPIDworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProcessByPIDResponse> __BuildGetProcessByPID(WorkflowValue<int> getProcessByPIDprocessId, WorkflowValue<string> getProcessByPIDworkflow)
        {
            WorkflowValue.Validate(getProcessByPIDprocessId, nameof(getProcessByPIDprocessId), required: true);
            WorkflowValue.Validate(getProcessByPIDworkflow, nameof(getProcessByPIDworkflow), required: true);
            return new DeferredBodyAction<GetProcessByPIDResponse>(() =>
            {
                var apiCallPath = "/Environment/GetProcessByPID";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getProcessByPID = new JObject();
                var getProcessByPIDpropCount = 0;
                getProcessByPIDpropCount++;
                getProcessByPID["ProcessId"] = ExpressionConverter.ConvertO(getProcessByPIDprocessId);
                getProcessByPIDpropCount++;
                getProcessByPID["Workflow"] = ExpressionConverter.ConvertO(getProcessByPIDworkflow);
                if (getProcessByPIDpropCount > 0)
                {
                    callPayload.Body = getProcessByPID;
                }

                return new ApiConnectionAction<GetProcessByPIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetProcesses))]
        public IBodyWorkflowAction<GetProcessesResponse> GetProcesses([WorkflowExpression] Func<string> getProcessesworkflow, [WorkflowExpression] Func<string> getProcessesprocessName = null, [WorkflowExpression] Func<bool> getProcessesgetProcessCommandLine = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProcessesResponse> __BuildGetProcesses(WorkflowValue<string> getProcessesworkflow, WorkflowValue<string> getProcessesprocessName = null, WorkflowValue<bool> getProcessesgetProcessCommandLine = null)
        {
            WorkflowValue.Validate(getProcessesworkflow, nameof(getProcessesworkflow), required: true);
            WorkflowValue.Validate(getProcessesprocessName, nameof(getProcessesprocessName), required: false);
            WorkflowValue.Validate(getProcessesgetProcessCommandLine, nameof(getProcessesgetProcessCommandLine), required: false);
            return new DeferredBodyAction<GetProcessesResponse>(() =>
            {
                var apiCallPath = "/Environment/GetProcesses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getProcesses = new JObject();
                var getProcessespropCount = 0;
                if (getProcessesprocessName != null)
                {
                    getProcesses["ProcessName"] = ExpressionConverter.ConvertO(getProcessesprocessName);
                    getProcessespropCount++;
                }

                if (getProcessesgetProcessCommandLine != null)
                {
                    if (getProcessesgetProcessCommandLine != null)
                    {
                        getProcesses["GetProcessCommandLine"] = ExpressionConverter.ConvertO(getProcessesgetProcessCommandLine);
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
                getProcesses["Workflow"] = ExpressionConverter.ConvertO(getProcessesworkflow);
                if (getProcessespropCount > 0)
                {
                    callPayload.Body = getProcesses;
                }

                return new ApiConnectionAction<GetProcessesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRunProcess))]
        public IBodyWorkflowAction<RunProcessResponse> RunProcess([WorkflowExpression] Func<string> runProcessprocessName, [WorkflowExpression] Func<string> runProcessworkflow, [WorkflowExpression] Func<string> runProcessarguments = null, [WorkflowExpression] Func<string> runProcessworkingDirectory = null, [WorkflowExpression] Func<bool> runProcessuseShellExecute = null, [WorkflowExpression] Func<bool> runProcesscreateNoWindow = null, [WorkflowExpression] Func<runProcesswindowStyleInput> runProcesswindowStyle = null, [WorkflowExpression] Func<bool> runProcesswaitForProcess = null, [WorkflowExpression] Func<bool> runProcessredirectStandardOutput = null, [WorkflowExpression] Func<bool> runProcessredirectStandardError = null, [WorkflowExpression] Func<bool> runProcessredirectStandardErrorToOutput = null, [WorkflowExpression] Func<runProcessstandardOutputEncodingInput> runProcessstandardOutputEncoding = null, [WorkflowExpression] Func<runProcessstandardErrorEncodingInput> runProcessstandardErrorEncoding = null, [WorkflowExpression] Func<string> runProcessrunAsDomain = null, [WorkflowExpression] Func<string> runProcessrunAsUsername = null, [WorkflowExpression] Func<string> runProcessrunAsPassword = null, [WorkflowExpression] Func<bool> runProcessrunAsLoadUserProfile = null, [WorkflowExpression] Func<bool> runProcessrunAsElevate = null, [WorkflowExpression] Func<int> runProcesstimeoutInSeconds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunProcessResponse> __BuildRunProcess(WorkflowValue<string> runProcessprocessName, WorkflowValue<string> runProcessworkflow, WorkflowValue<string> runProcessarguments = null, WorkflowValue<string> runProcessworkingDirectory = null, WorkflowValue<bool> runProcessuseShellExecute = null, WorkflowValue<bool> runProcesscreateNoWindow = null, WorkflowValue<runProcesswindowStyleInput> runProcesswindowStyle = null, WorkflowValue<bool> runProcesswaitForProcess = null, WorkflowValue<bool> runProcessredirectStandardOutput = null, WorkflowValue<bool> runProcessredirectStandardError = null, WorkflowValue<bool> runProcessredirectStandardErrorToOutput = null, WorkflowValue<runProcessstandardOutputEncodingInput> runProcessstandardOutputEncoding = null, WorkflowValue<runProcessstandardErrorEncodingInput> runProcessstandardErrorEncoding = null, WorkflowValue<string> runProcessrunAsDomain = null, WorkflowValue<string> runProcessrunAsUsername = null, WorkflowValue<string> runProcessrunAsPassword = null, WorkflowValue<bool> runProcessrunAsLoadUserProfile = null, WorkflowValue<bool> runProcessrunAsElevate = null, WorkflowValue<int> runProcesstimeoutInSeconds = null)
        {
            WorkflowValue.Validate(runProcessprocessName, nameof(runProcessprocessName), required: true);
            WorkflowValue.Validate(runProcessworkflow, nameof(runProcessworkflow), required: true);
            WorkflowValue.Validate(runProcessarguments, nameof(runProcessarguments), required: false);
            WorkflowValue.Validate(runProcessworkingDirectory, nameof(runProcessworkingDirectory), required: false);
            WorkflowValue.Validate(runProcessuseShellExecute, nameof(runProcessuseShellExecute), required: false);
            WorkflowValue.Validate(runProcesscreateNoWindow, nameof(runProcesscreateNoWindow), required: false);
            WorkflowValue.Validate(runProcesswindowStyle, nameof(runProcesswindowStyle), required: false);
            WorkflowValue.Validate(runProcesswaitForProcess, nameof(runProcesswaitForProcess), required: false);
            WorkflowValue.Validate(runProcessredirectStandardOutput, nameof(runProcessredirectStandardOutput), required: false);
            WorkflowValue.Validate(runProcessredirectStandardError, nameof(runProcessredirectStandardError), required: false);
            WorkflowValue.Validate(runProcessredirectStandardErrorToOutput, nameof(runProcessredirectStandardErrorToOutput), required: false);
            WorkflowValue.Validate(runProcessstandardOutputEncoding, nameof(runProcessstandardOutputEncoding), required: false);
            WorkflowValue.Validate(runProcessstandardErrorEncoding, nameof(runProcessstandardErrorEncoding), required: false);
            WorkflowValue.Validate(runProcessrunAsDomain, nameof(runProcessrunAsDomain), required: false);
            WorkflowValue.Validate(runProcessrunAsUsername, nameof(runProcessrunAsUsername), required: false);
            WorkflowValue.Validate(runProcessrunAsPassword, nameof(runProcessrunAsPassword), required: false);
            WorkflowValue.Validate(runProcessrunAsLoadUserProfile, nameof(runProcessrunAsLoadUserProfile), required: false);
            WorkflowValue.Validate(runProcessrunAsElevate, nameof(runProcessrunAsElevate), required: false);
            WorkflowValue.Validate(runProcesstimeoutInSeconds, nameof(runProcesstimeoutInSeconds), required: false);
            return new DeferredBodyAction<RunProcessResponse>(() =>
            {
                var apiCallPath = "/Environment/RunProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runProcess = new JObject();
                var runProcesspropCount = 0;
                runProcesspropCount++;
                runProcess["ProcessName"] = ExpressionConverter.ConvertO(runProcessprocessName);
                if (runProcessarguments != null)
                {
                    runProcess["Arguments"] = ExpressionConverter.ConvertO(runProcessarguments);
                    runProcesspropCount++;
                }

                if (runProcessworkingDirectory != null)
                {
                    runProcess["WorkingDirectory"] = ExpressionConverter.ConvertO(runProcessworkingDirectory);
                    runProcesspropCount++;
                }

                if (runProcessuseShellExecute != null)
                {
                    if (runProcessuseShellExecute != null)
                    {
                        runProcess["UseShellExecute"] = ExpressionConverter.ConvertO(runProcessuseShellExecute);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["UseShellExecute"] = true;
                    runProcesspropCount++;
                }

                if (runProcesscreateNoWindow != null)
                {
                    if (runProcesscreateNoWindow != null)
                    {
                        runProcess["CreateNoWindow"] = ExpressionConverter.ConvertO(runProcesscreateNoWindow);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["CreateNoWindow"] = false;
                    runProcesspropCount++;
                }

                if (runProcesswindowStyle != null)
                {
                    if (runProcesswindowStyle != null)
                    {
                        runProcess["WindowStyle"] = ExpressionConverter.ConvertO(runProcesswindowStyle);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["WindowStyle"] = "normal";
                    runProcesspropCount++;
                }

                if (runProcesswaitForProcess != null)
                {
                    if (runProcesswaitForProcess != null)
                    {
                        runProcess["WaitForProcess"] = ExpressionConverter.ConvertO(runProcesswaitForProcess);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["WaitForProcess"] = false;
                    runProcesspropCount++;
                }

                if (runProcessredirectStandardOutput != null)
                {
                    if (runProcessredirectStandardOutput != null)
                    {
                        runProcess["RedirectStandardOutput"] = ExpressionConverter.ConvertO(runProcessredirectStandardOutput);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["RedirectStandardOutput"] = false;
                    runProcesspropCount++;
                }

                if (runProcessredirectStandardError != null)
                {
                    if (runProcessredirectStandardError != null)
                    {
                        runProcess["RedirectStandardError"] = ExpressionConverter.ConvertO(runProcessredirectStandardError);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["RedirectStandardError"] = false;
                    runProcesspropCount++;
                }

                if (runProcessredirectStandardErrorToOutput != null)
                {
                    if (runProcessredirectStandardErrorToOutput != null)
                    {
                        runProcess["RedirectStandardErrorToOutput"] = ExpressionConverter.ConvertO(runProcessredirectStandardErrorToOutput);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["RedirectStandardErrorToOutput"] = false;
                    runProcesspropCount++;
                }

                if (runProcessstandardOutputEncoding != null)
                {
                    runProcess["StandardOutputEncoding"] = ExpressionConverter.ConvertO(runProcessstandardOutputEncoding);
                    runProcesspropCount++;
                }

                if (runProcessstandardErrorEncoding != null)
                {
                    runProcess["StandardErrorEncoding"] = ExpressionConverter.ConvertO(runProcessstandardErrorEncoding);
                    runProcesspropCount++;
                }

                if (runProcessrunAsDomain != null)
                {
                    runProcess["RunAsDomain"] = ExpressionConverter.ConvertO(runProcessrunAsDomain);
                    runProcesspropCount++;
                }

                if (runProcessrunAsUsername != null)
                {
                    runProcess["RunAsUsername"] = ExpressionConverter.ConvertO(runProcessrunAsUsername);
                    runProcesspropCount++;
                }

                if (runProcessrunAsPassword != null)
                {
                    runProcess["RunAsPassword"] = ExpressionConverter.ConvertO(runProcessrunAsPassword);
                    runProcesspropCount++;
                }

                if (runProcessrunAsLoadUserProfile != null)
                {
                    if (runProcessrunAsLoadUserProfile != null)
                    {
                        runProcess["RunAsLoadUserProfile"] = ExpressionConverter.ConvertO(runProcessrunAsLoadUserProfile);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["RunAsLoadUserProfile"] = false;
                    runProcesspropCount++;
                }

                if (runProcessrunAsElevate != null)
                {
                    if (runProcessrunAsElevate != null)
                    {
                        runProcess["RunAsElevate"] = ExpressionConverter.ConvertO(runProcessrunAsElevate);
                        runProcesspropCount++;
                    }

                    runProcesspropCount++;
                }
                else
                {
                    runProcess["RunAsElevate"] = false;
                    runProcesspropCount++;
                }

                if (runProcesstimeoutInSeconds != null)
                {
                    if (runProcesstimeoutInSeconds != null)
                    {
                        runProcess["TimeoutInSeconds"] = ExpressionConverter.ConvertO(runProcesstimeoutInSeconds);
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
                runProcess["Workflow"] = ExpressionConverter.ConvertO(runProcessworkflow);
                if (runProcesspropCount > 0)
                {
                    callPayload.Body = runProcess;
                }

                return new ApiConnectionAction<RunProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRunPowerShellProcess))]
        public IBodyWorkflowAction<RunPowerShellProcessResponse> RunPowerShellProcess([WorkflowExpression] Func<string> runPowerShellProcessworkflow, [WorkflowExpression] Func<string> runPowerShellProcesspowerShellExecutable = null, [WorkflowExpression] Func<string> runPowerShellProcesspowerShellScriptFilePath = null, [WorkflowExpression] Func<string> runPowerShellProcesspowerShellScriptContents = null, [WorkflowExpression] Func<string> runPowerShellProcessworkingDirectory = null, [WorkflowExpression] Func<bool> runPowerShellProcesscreateNoWindow = null, [WorkflowExpression] Func<runPowerShellProcesswindowStyleInput> runPowerShellProcesswindowStyle = null, [WorkflowExpression] Func<bool> runPowerShellProcesswaitForProcess = null, [WorkflowExpression] Func<bool> runPowerShellProcessredirectStandardOutput = null, [WorkflowExpression] Func<bool> runPowerShellProcessredirectStandardError = null, [WorkflowExpression] Func<bool> runPowerShellProcessredirectStandardErrorToOutput = null, [WorkflowExpression] Func<runPowerShellProcessstandardOutputEncodingInput> runPowerShellProcessstandardOutputEncoding = null, [WorkflowExpression] Func<runPowerShellProcessstandardErrorEncodingInput> runPowerShellProcessstandardErrorEncoding = null, [WorkflowExpression] Func<string> runPowerShellProcessrunAsDomain = null, [WorkflowExpression] Func<string> runPowerShellProcessrunAsUsername = null, [WorkflowExpression] Func<string> runPowerShellProcessrunAsPassword = null, [WorkflowExpression] Func<bool> runPowerShellProcessrunAsLoadUserProfile = null, [WorkflowExpression] Func<bool> runPowerShellProcessrunAsElevate = null, [WorkflowExpression] Func<int> runPowerShellProcesstimeoutInSeconds = null, [WorkflowExpression] Func<string> runPowerShellProcesspowerShellScriptTempFolder = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunPowerShellProcessResponse> __BuildRunPowerShellProcess(WorkflowValue<string> runPowerShellProcessworkflow, WorkflowValue<string> runPowerShellProcesspowerShellExecutable = null, WorkflowValue<string> runPowerShellProcesspowerShellScriptFilePath = null, WorkflowValue<string> runPowerShellProcesspowerShellScriptContents = null, WorkflowValue<string> runPowerShellProcessworkingDirectory = null, WorkflowValue<bool> runPowerShellProcesscreateNoWindow = null, WorkflowValue<runPowerShellProcesswindowStyleInput> runPowerShellProcesswindowStyle = null, WorkflowValue<bool> runPowerShellProcesswaitForProcess = null, WorkflowValue<bool> runPowerShellProcessredirectStandardOutput = null, WorkflowValue<bool> runPowerShellProcessredirectStandardError = null, WorkflowValue<bool> runPowerShellProcessredirectStandardErrorToOutput = null, WorkflowValue<runPowerShellProcessstandardOutputEncodingInput> runPowerShellProcessstandardOutputEncoding = null, WorkflowValue<runPowerShellProcessstandardErrorEncodingInput> runPowerShellProcessstandardErrorEncoding = null, WorkflowValue<string> runPowerShellProcessrunAsDomain = null, WorkflowValue<string> runPowerShellProcessrunAsUsername = null, WorkflowValue<string> runPowerShellProcessrunAsPassword = null, WorkflowValue<bool> runPowerShellProcessrunAsLoadUserProfile = null, WorkflowValue<bool> runPowerShellProcessrunAsElevate = null, WorkflowValue<int> runPowerShellProcesstimeoutInSeconds = null, WorkflowValue<string> runPowerShellProcesspowerShellScriptTempFolder = null)
        {
            WorkflowValue.Validate(runPowerShellProcessworkflow, nameof(runPowerShellProcessworkflow), required: true);
            WorkflowValue.Validate(runPowerShellProcesspowerShellExecutable, nameof(runPowerShellProcesspowerShellExecutable), required: false);
            WorkflowValue.Validate(runPowerShellProcesspowerShellScriptFilePath, nameof(runPowerShellProcesspowerShellScriptFilePath), required: false);
            WorkflowValue.Validate(runPowerShellProcesspowerShellScriptContents, nameof(runPowerShellProcesspowerShellScriptContents), required: false);
            WorkflowValue.Validate(runPowerShellProcessworkingDirectory, nameof(runPowerShellProcessworkingDirectory), required: false);
            WorkflowValue.Validate(runPowerShellProcesscreateNoWindow, nameof(runPowerShellProcesscreateNoWindow), required: false);
            WorkflowValue.Validate(runPowerShellProcesswindowStyle, nameof(runPowerShellProcesswindowStyle), required: false);
            WorkflowValue.Validate(runPowerShellProcesswaitForProcess, nameof(runPowerShellProcesswaitForProcess), required: false);
            WorkflowValue.Validate(runPowerShellProcessredirectStandardOutput, nameof(runPowerShellProcessredirectStandardOutput), required: false);
            WorkflowValue.Validate(runPowerShellProcessredirectStandardError, nameof(runPowerShellProcessredirectStandardError), required: false);
            WorkflowValue.Validate(runPowerShellProcessredirectStandardErrorToOutput, nameof(runPowerShellProcessredirectStandardErrorToOutput), required: false);
            WorkflowValue.Validate(runPowerShellProcessstandardOutputEncoding, nameof(runPowerShellProcessstandardOutputEncoding), required: false);
            WorkflowValue.Validate(runPowerShellProcessstandardErrorEncoding, nameof(runPowerShellProcessstandardErrorEncoding), required: false);
            WorkflowValue.Validate(runPowerShellProcessrunAsDomain, nameof(runPowerShellProcessrunAsDomain), required: false);
            WorkflowValue.Validate(runPowerShellProcessrunAsUsername, nameof(runPowerShellProcessrunAsUsername), required: false);
            WorkflowValue.Validate(runPowerShellProcessrunAsPassword, nameof(runPowerShellProcessrunAsPassword), required: false);
            WorkflowValue.Validate(runPowerShellProcessrunAsLoadUserProfile, nameof(runPowerShellProcessrunAsLoadUserProfile), required: false);
            WorkflowValue.Validate(runPowerShellProcessrunAsElevate, nameof(runPowerShellProcessrunAsElevate), required: false);
            WorkflowValue.Validate(runPowerShellProcesstimeoutInSeconds, nameof(runPowerShellProcesstimeoutInSeconds), required: false);
            WorkflowValue.Validate(runPowerShellProcesspowerShellScriptTempFolder, nameof(runPowerShellProcesspowerShellScriptTempFolder), required: false);
            return new DeferredBodyAction<RunPowerShellProcessResponse>(() =>
            {
                var apiCallPath = "/Environment/RunPowerShellProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runPowerShellProcess = new JObject();
                var runPowerShellProcesspropCount = 0;
                if (runPowerShellProcesspowerShellExecutable != null)
                {
                    if (runPowerShellProcesspowerShellExecutable != null)
                    {
                        runPowerShellProcess["PowerShellExecutable"] = ExpressionConverter.ConvertO(runPowerShellProcesspowerShellExecutable);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["PowerShellExecutable"] = "PowerShell.exe";
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcesspowerShellScriptFilePath != null)
                {
                    runPowerShellProcess["PowerShellScriptFilePath"] = ExpressionConverter.ConvertO(runPowerShellProcesspowerShellScriptFilePath);
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcesspowerShellScriptContents != null)
                {
                    runPowerShellProcess["PowerShellScriptContents"] = ExpressionConverter.ConvertO(runPowerShellProcesspowerShellScriptContents);
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcessworkingDirectory != null)
                {
                    runPowerShellProcess["WorkingDirectory"] = ExpressionConverter.ConvertO(runPowerShellProcessworkingDirectory);
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcesscreateNoWindow != null)
                {
                    if (runPowerShellProcesscreateNoWindow != null)
                    {
                        runPowerShellProcess["CreateNoWindow"] = ExpressionConverter.ConvertO(runPowerShellProcesscreateNoWindow);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["CreateNoWindow"] = true;
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcesswindowStyle != null)
                {
                    if (runPowerShellProcesswindowStyle != null)
                    {
                        runPowerShellProcess["WindowStyle"] = ExpressionConverter.ConvertO(runPowerShellProcesswindowStyle);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["WindowStyle"] = "normal";
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcesswaitForProcess != null)
                {
                    if (runPowerShellProcesswaitForProcess != null)
                    {
                        runPowerShellProcess["WaitForProcess"] = ExpressionConverter.ConvertO(runPowerShellProcesswaitForProcess);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["WaitForProcess"] = true;
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcessredirectStandardOutput != null)
                {
                    if (runPowerShellProcessredirectStandardOutput != null)
                    {
                        runPowerShellProcess["RedirectStandardOutput"] = ExpressionConverter.ConvertO(runPowerShellProcessredirectStandardOutput);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["RedirectStandardOutput"] = true;
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcessredirectStandardError != null)
                {
                    if (runPowerShellProcessredirectStandardError != null)
                    {
                        runPowerShellProcess["RedirectStandardError"] = ExpressionConverter.ConvertO(runPowerShellProcessredirectStandardError);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["RedirectStandardError"] = false;
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcessredirectStandardErrorToOutput != null)
                {
                    if (runPowerShellProcessredirectStandardErrorToOutput != null)
                    {
                        runPowerShellProcess["RedirectStandardErrorToOutput"] = ExpressionConverter.ConvertO(runPowerShellProcessredirectStandardErrorToOutput);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["RedirectStandardErrorToOutput"] = false;
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcessstandardOutputEncoding != null)
                {
                    runPowerShellProcess["StandardOutputEncoding"] = ExpressionConverter.ConvertO(runPowerShellProcessstandardOutputEncoding);
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcessstandardErrorEncoding != null)
                {
                    runPowerShellProcess["StandardErrorEncoding"] = ExpressionConverter.ConvertO(runPowerShellProcessstandardErrorEncoding);
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcessrunAsDomain != null)
                {
                    runPowerShellProcess["RunAsDomain"] = ExpressionConverter.ConvertO(runPowerShellProcessrunAsDomain);
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcessrunAsUsername != null)
                {
                    runPowerShellProcess["RunAsUsername"] = ExpressionConverter.ConvertO(runPowerShellProcessrunAsUsername);
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcessrunAsPassword != null)
                {
                    runPowerShellProcess["RunAsPassword"] = ExpressionConverter.ConvertO(runPowerShellProcessrunAsPassword);
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcessrunAsLoadUserProfile != null)
                {
                    if (runPowerShellProcessrunAsLoadUserProfile != null)
                    {
                        runPowerShellProcess["RunAsLoadUserProfile"] = ExpressionConverter.ConvertO(runPowerShellProcessrunAsLoadUserProfile);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["RunAsLoadUserProfile"] = false;
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcessrunAsElevate != null)
                {
                    if (runPowerShellProcessrunAsElevate != null)
                    {
                        runPowerShellProcess["RunAsElevate"] = ExpressionConverter.ConvertO(runPowerShellProcessrunAsElevate);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["RunAsElevate"] = false;
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcesstimeoutInSeconds != null)
                {
                    if (runPowerShellProcesstimeoutInSeconds != null)
                    {
                        runPowerShellProcess["TimeoutInSeconds"] = ExpressionConverter.ConvertO(runPowerShellProcesstimeoutInSeconds);
                        runPowerShellProcesspropCount++;
                    }

                    runPowerShellProcesspropCount++;
                }
                else
                {
                    runPowerShellProcess["TimeoutInSeconds"] = 10;
                    runPowerShellProcesspropCount++;
                }

                if (runPowerShellProcesspowerShellScriptTempFolder != null)
                {
                    runPowerShellProcess["PowerShellScriptTempFolder"] = ExpressionConverter.ConvertO(runPowerShellProcesspowerShellScriptTempFolder);
                    runPowerShellProcesspropCount++;
                }

                runPowerShellProcesspropCount++;
                runPowerShellProcess["Workflow"] = ExpressionConverter.ConvertO(runPowerShellProcessworkflow);
                if (runPowerShellProcesspropCount > 0)
                {
                    callPayload.Body = runPowerShellProcess;
                }

                return new ApiConnectionAction<RunPowerShellProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetScreenResolution))]
        public IBodyWorkflowAction<GetScreenResolutionResponse> GetScreenResolution([WorkflowExpression] Func<string> getScreenResolutionworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetScreenResolutionResponse> __BuildGetScreenResolution(WorkflowValue<string> getScreenResolutionworkflow)
        {
            WorkflowValue.Validate(getScreenResolutionworkflow, nameof(getScreenResolutionworkflow), required: true);
            return new DeferredBodyAction<GetScreenResolutionResponse>(() =>
            {
                var apiCallPath = "/Environment/GetScreenResolution";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getScreenResolution = new JObject();
                var getScreenResolutionpropCount = 0;
                getScreenResolutionpropCount++;
                getScreenResolution["Workflow"] = ExpressionConverter.ConvertO(getScreenResolutionworkflow);
                if (getScreenResolutionpropCount > 0)
                {
                    callPayload.Body = getScreenResolution;
                }

                return new ApiConnectionAction<GetScreenResolutionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetDefaultPrinter))]
        public IWorkflowAction SetDefaultPrinter([WorkflowExpression] Func<string> setDefaultPrinterdefaultPrinterName, [WorkflowExpression] Func<string> setDefaultPrinterworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetDefaultPrinter(WorkflowValue<string> setDefaultPrinterdefaultPrinterName, WorkflowValue<string> setDefaultPrinterworkflow)
        {
            WorkflowValue.Validate(setDefaultPrinterdefaultPrinterName, nameof(setDefaultPrinterdefaultPrinterName), required: true);
            WorkflowValue.Validate(setDefaultPrinterworkflow, nameof(setDefaultPrinterworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SetDefaultPrinter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setDefaultPrinter = new JObject();
                var setDefaultPrinterpropCount = 0;
                setDefaultPrinterpropCount++;
                setDefaultPrinter["DefaultPrinterName"] = ExpressionConverter.ConvertO(setDefaultPrinterdefaultPrinterName);
                setDefaultPrinterpropCount++;
                setDefaultPrinter["Workflow"] = ExpressionConverter.ConvertO(setDefaultPrinterworkflow);
                if (setDefaultPrinterpropCount > 0)
                {
                    callPayload.Body = setDefaultPrinter;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetDefaultPrinter))]
        public IBodyWorkflowAction<GetDefaultPrinterResponse> GetDefaultPrinter([WorkflowExpression] Func<string> getDefaultPrinterworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDefaultPrinterResponse> __BuildGetDefaultPrinter(WorkflowValue<string> getDefaultPrinterworkflow)
        {
            WorkflowValue.Validate(getDefaultPrinterworkflow, nameof(getDefaultPrinterworkflow), required: true);
            return new DeferredBodyAction<GetDefaultPrinterResponse>(() =>
            {
                var apiCallPath = "/Environment/GetDefaultPrinter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getDefaultPrinter = new JObject();
                var getDefaultPrinterpropCount = 0;
                getDefaultPrinterpropCount++;
                getDefaultPrinter["Workflow"] = ExpressionConverter.ConvertO(getDefaultPrinterworkflow);
                if (getDefaultPrinterpropCount > 0)
                {
                    callPayload.Body = getDefaultPrinter;
                }

                return new ApiConnectionAction<GetDefaultPrinterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetListOfPrinters))]
        public IBodyWorkflowAction<GetListOfPrintersResponse> GetListOfPrinters([WorkflowExpression] Func<string> getListOfPrintersworkflow, [WorkflowExpression] Func<bool> getListOfPrinterslistLocalPrinters = null, [WorkflowExpression] Func<bool> getListOfPrinterslistNetworkPrinters = null, [WorkflowExpression] Func<bool> getListOfPrintersreturnDetailedInformation = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetListOfPrintersResponse> __BuildGetListOfPrinters(WorkflowValue<string> getListOfPrintersworkflow, WorkflowValue<bool> getListOfPrinterslistLocalPrinters = null, WorkflowValue<bool> getListOfPrinterslistNetworkPrinters = null, WorkflowValue<bool> getListOfPrintersreturnDetailedInformation = null)
        {
            WorkflowValue.Validate(getListOfPrintersworkflow, nameof(getListOfPrintersworkflow), required: true);
            WorkflowValue.Validate(getListOfPrinterslistLocalPrinters, nameof(getListOfPrinterslistLocalPrinters), required: false);
            WorkflowValue.Validate(getListOfPrinterslistNetworkPrinters, nameof(getListOfPrinterslistNetworkPrinters), required: false);
            WorkflowValue.Validate(getListOfPrintersreturnDetailedInformation, nameof(getListOfPrintersreturnDetailedInformation), required: false);
            return new DeferredBodyAction<GetListOfPrintersResponse>(() =>
            {
                var apiCallPath = "/Environment/GetListOfPrinters";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getListOfPrinters = new JObject();
                var getListOfPrinterspropCount = 0;
                if (getListOfPrinterslistLocalPrinters != null)
                {
                    if (getListOfPrinterslistLocalPrinters != null)
                    {
                        getListOfPrinters["ListLocalPrinters"] = ExpressionConverter.ConvertO(getListOfPrinterslistLocalPrinters);
                        getListOfPrinterspropCount++;
                    }

                    getListOfPrinterspropCount++;
                }
                else
                {
                    getListOfPrinters["ListLocalPrinters"] = true;
                    getListOfPrinterspropCount++;
                }

                if (getListOfPrinterslistNetworkPrinters != null)
                {
                    if (getListOfPrinterslistNetworkPrinters != null)
                    {
                        getListOfPrinters["ListNetworkPrinters"] = ExpressionConverter.ConvertO(getListOfPrinterslistNetworkPrinters);
                        getListOfPrinterspropCount++;
                    }

                    getListOfPrinterspropCount++;
                }
                else
                {
                    getListOfPrinters["ListNetworkPrinters"] = false;
                    getListOfPrinterspropCount++;
                }

                if (getListOfPrintersreturnDetailedInformation != null)
                {
                    if (getListOfPrintersreturnDetailedInformation != null)
                    {
                        getListOfPrinters["ReturnDetailedInformation"] = ExpressionConverter.ConvertO(getListOfPrintersreturnDetailedInformation);
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
                getListOfPrinters["Workflow"] = ExpressionConverter.ConvertO(getListOfPrintersworkflow);
                if (getListOfPrinterspropCount > 0)
                {
                    callPayload.Body = getListOfPrinters;
                }

                return new ApiConnectionAction<GetListOfPrintersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetMouseMultiplier))]
        public IWorkflowAction SetMouseMultiplier([WorkflowExpression] Func<string> setMouseMultiplierworkflow, [WorkflowExpression] Func<double> setMouseMultipliermouseXMultiplier = null, [WorkflowExpression] Func<double> setMouseMultipliermouseYMultiplier = null, [WorkflowExpression] Func<bool> setMouseMultiplierapplyToMouseEvent = null, [WorkflowExpression] Func<bool> setMouseMultiplierapplyToSetCursorPos = null, [WorkflowExpression] Func<bool> setMouseMultiplierapplyToCurrentMouseMoveMethod = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetMouseMultiplier(WorkflowValue<string> setMouseMultiplierworkflow, WorkflowValue<double> setMouseMultipliermouseXMultiplier = null, WorkflowValue<double> setMouseMultipliermouseYMultiplier = null, WorkflowValue<bool> setMouseMultiplierapplyToMouseEvent = null, WorkflowValue<bool> setMouseMultiplierapplyToSetCursorPos = null, WorkflowValue<bool> setMouseMultiplierapplyToCurrentMouseMoveMethod = null)
        {
            WorkflowValue.Validate(setMouseMultiplierworkflow, nameof(setMouseMultiplierworkflow), required: true);
            WorkflowValue.Validate(setMouseMultipliermouseXMultiplier, nameof(setMouseMultipliermouseXMultiplier), required: false);
            WorkflowValue.Validate(setMouseMultipliermouseYMultiplier, nameof(setMouseMultipliermouseYMultiplier), required: false);
            WorkflowValue.Validate(setMouseMultiplierapplyToMouseEvent, nameof(setMouseMultiplierapplyToMouseEvent), required: false);
            WorkflowValue.Validate(setMouseMultiplierapplyToSetCursorPos, nameof(setMouseMultiplierapplyToSetCursorPos), required: false);
            WorkflowValue.Validate(setMouseMultiplierapplyToCurrentMouseMoveMethod, nameof(setMouseMultiplierapplyToCurrentMouseMoveMethod), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SetMouseMultiplier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setMouseMultiplier = new JObject();
                var setMouseMultiplierpropCount = 0;
                if (setMouseMultipliermouseXMultiplier != null)
                {
                    if (setMouseMultipliermouseXMultiplier != null)
                    {
                        setMouseMultiplier["MouseXMultiplier"] = ExpressionConverter.ConvertO(setMouseMultipliermouseXMultiplier);
                        setMouseMultiplierpropCount++;
                    }

                    setMouseMultiplierpropCount++;
                }
                else
                {
                    setMouseMultiplier["MouseXMultiplier"] = 1;
                    setMouseMultiplierpropCount++;
                }

                if (setMouseMultipliermouseYMultiplier != null)
                {
                    if (setMouseMultipliermouseYMultiplier != null)
                    {
                        setMouseMultiplier["MouseYMultiplier"] = ExpressionConverter.ConvertO(setMouseMultipliermouseYMultiplier);
                        setMouseMultiplierpropCount++;
                    }

                    setMouseMultiplierpropCount++;
                }
                else
                {
                    setMouseMultiplier["MouseYMultiplier"] = 1;
                    setMouseMultiplierpropCount++;
                }

                if (setMouseMultiplierapplyToMouseEvent != null)
                {
                    if (setMouseMultiplierapplyToMouseEvent != null)
                    {
                        setMouseMultiplier["ApplyToMouseEvent"] = ExpressionConverter.ConvertO(setMouseMultiplierapplyToMouseEvent);
                        setMouseMultiplierpropCount++;
                    }

                    setMouseMultiplierpropCount++;
                }
                else
                {
                    setMouseMultiplier["ApplyToMouseEvent"] = true;
                    setMouseMultiplierpropCount++;
                }

                if (setMouseMultiplierapplyToSetCursorPos != null)
                {
                    if (setMouseMultiplierapplyToSetCursorPos != null)
                    {
                        setMouseMultiplier["ApplyToSetCursorPos"] = ExpressionConverter.ConvertO(setMouseMultiplierapplyToSetCursorPos);
                        setMouseMultiplierpropCount++;
                    }

                    setMouseMultiplierpropCount++;
                }
                else
                {
                    setMouseMultiplier["ApplyToSetCursorPos"] = false;
                    setMouseMultiplierpropCount++;
                }

                if (setMouseMultiplierapplyToCurrentMouseMoveMethod != null)
                {
                    if (setMouseMultiplierapplyToCurrentMouseMoveMethod != null)
                    {
                        setMouseMultiplier["ApplyToCurrentMouseMoveMethod"] = ExpressionConverter.ConvertO(setMouseMultiplierapplyToCurrentMouseMoveMethod);
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
                setMouseMultiplier["Workflow"] = ExpressionConverter.ConvertO(setMouseMultiplierworkflow);
                if (setMouseMultiplierpropCount > 0)
                {
                    callPayload.Body = setMouseMultiplier;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetMouseMultiplier))]
        public IBodyWorkflowAction<GetMouseMultiplierResponse> GetMouseMultiplier([WorkflowExpression] Func<string> getMouseMultiplierworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMouseMultiplierResponse> __BuildGetMouseMultiplier(WorkflowValue<string> getMouseMultiplierworkflow)
        {
            WorkflowValue.Validate(getMouseMultiplierworkflow, nameof(getMouseMultiplierworkflow), required: true);
            return new DeferredBodyAction<GetMouseMultiplierResponse>(() =>
            {
                var apiCallPath = "/Environment/GetMouseMultiplier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getMouseMultiplier = new JObject();
                var getMouseMultiplierpropCount = 0;
                getMouseMultiplierpropCount++;
                getMouseMultiplier["Workflow"] = ExpressionConverter.ConvertO(getMouseMultiplierworkflow);
                if (getMouseMultiplierpropCount > 0)
                {
                    callPayload.Body = getMouseMultiplier;
                }

                return new ApiConnectionAction<GetMouseMultiplierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildMoveMouseToCoordinate))]
        public IWorkflowAction MoveMouseToCoordinate([WorkflowExpression] Func<int> moveMouseToCoordinatexCoord, [WorkflowExpression] Func<int> moveMouseToCoordinateyCoord, [WorkflowExpression] Func<string> moveMouseToCoordinateworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveMouseToCoordinate(WorkflowValue<int> moveMouseToCoordinatexCoord, WorkflowValue<int> moveMouseToCoordinateyCoord, WorkflowValue<string> moveMouseToCoordinateworkflow)
        {
            WorkflowValue.Validate(moveMouseToCoordinatexCoord, nameof(moveMouseToCoordinatexCoord), required: true);
            WorkflowValue.Validate(moveMouseToCoordinateyCoord, nameof(moveMouseToCoordinateyCoord), required: true);
            WorkflowValue.Validate(moveMouseToCoordinateworkflow, nameof(moveMouseToCoordinateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MoveMouseToCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var moveMouseToCoordinate = new JObject();
                var moveMouseToCoordinatepropCount = 0;
                moveMouseToCoordinatepropCount++;
                moveMouseToCoordinate["XCoord"] = ExpressionConverter.ConvertO(moveMouseToCoordinatexCoord);
                moveMouseToCoordinatepropCount++;
                moveMouseToCoordinate["YCoord"] = ExpressionConverter.ConvertO(moveMouseToCoordinateyCoord);
                moveMouseToCoordinatepropCount++;
                moveMouseToCoordinate["Workflow"] = ExpressionConverter.ConvertO(moveMouseToCoordinateworkflow);
                if (moveMouseToCoordinatepropCount > 0)
                {
                    callPayload.Body = moveMouseToCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildMoveMouseRelative))]
        public IWorkflowAction MoveMouseRelative([WorkflowExpression] Func<int> moveMouseRelativexCoord, [WorkflowExpression] Func<int> moveMouseRelativeyCoord, [WorkflowExpression] Func<string> moveMouseRelativeworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveMouseRelative(WorkflowValue<int> moveMouseRelativexCoord, WorkflowValue<int> moveMouseRelativeyCoord, WorkflowValue<string> moveMouseRelativeworkflow)
        {
            WorkflowValue.Validate(moveMouseRelativexCoord, nameof(moveMouseRelativexCoord), required: true);
            WorkflowValue.Validate(moveMouseRelativeyCoord, nameof(moveMouseRelativeyCoord), required: true);
            WorkflowValue.Validate(moveMouseRelativeworkflow, nameof(moveMouseRelativeworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MoveMouseRelative";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var moveMouseRelative = new JObject();
                var moveMouseRelativepropCount = 0;
                moveMouseRelativepropCount++;
                moveMouseRelative["XCoord"] = ExpressionConverter.ConvertO(moveMouseRelativexCoord);
                moveMouseRelativepropCount++;
                moveMouseRelative["YCoord"] = ExpressionConverter.ConvertO(moveMouseRelativeyCoord);
                moveMouseRelativepropCount++;
                moveMouseRelative["Workflow"] = ExpressionConverter.ConvertO(moveMouseRelativeworkflow);
                if (moveMouseRelativepropCount > 0)
                {
                    callPayload.Body = moveMouseRelative;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildLeftMouseButtonDown))]
        public IWorkflowAction LeftMouseButtonDown([WorkflowExpression] Func<string> leftMouseButtonDownworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLeftMouseButtonDown(WorkflowValue<string> leftMouseButtonDownworkflow)
        {
            WorkflowValue.Validate(leftMouseButtonDownworkflow, nameof(leftMouseButtonDownworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/LeftMouseButtonDown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var leftMouseButtonDown = new JObject();
                var leftMouseButtonDownpropCount = 0;
                leftMouseButtonDownpropCount++;
                leftMouseButtonDown["Workflow"] = ExpressionConverter.ConvertO(leftMouseButtonDownworkflow);
                if (leftMouseButtonDownpropCount > 0)
                {
                    callPayload.Body = leftMouseButtonDown;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildLeftMouseButtonUp))]
        public IWorkflowAction LeftMouseButtonUp([WorkflowExpression] Func<string> leftMouseButtonUpworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLeftMouseButtonUp(WorkflowValue<string> leftMouseButtonUpworkflow)
        {
            WorkflowValue.Validate(leftMouseButtonUpworkflow, nameof(leftMouseButtonUpworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/LeftMouseButtonUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var leftMouseButtonUp = new JObject();
                var leftMouseButtonUppropCount = 0;
                leftMouseButtonUppropCount++;
                leftMouseButtonUp["Workflow"] = ExpressionConverter.ConvertO(leftMouseButtonUpworkflow);
                if (leftMouseButtonUppropCount > 0)
                {
                    callPayload.Body = leftMouseButtonUp;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildLeftClickMouse))]
        public IWorkflowAction LeftClickMouse([WorkflowExpression] Func<string> leftClickMouseworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLeftClickMouse(WorkflowValue<string> leftClickMouseworkflow)
        {
            WorkflowValue.Validate(leftClickMouseworkflow, nameof(leftClickMouseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/LeftClickMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var leftClickMouse = new JObject();
                var leftClickMousepropCount = 0;
                leftClickMousepropCount++;
                leftClickMouse["Workflow"] = ExpressionConverter.ConvertO(leftClickMouseworkflow);
                if (leftClickMousepropCount > 0)
                {
                    callPayload.Body = leftClickMouse;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildLeftClickMouseAtCoordinate))]
        public IWorkflowAction LeftClickMouseAtCoordinate([WorkflowExpression] Func<int> leftClickMouseAtCoordinatexCoord, [WorkflowExpression] Func<int> leftClickMouseAtCoordinateyCoord, [WorkflowExpression] Func<string> leftClickMouseAtCoordinateworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLeftClickMouseAtCoordinate(WorkflowValue<int> leftClickMouseAtCoordinatexCoord, WorkflowValue<int> leftClickMouseAtCoordinateyCoord, WorkflowValue<string> leftClickMouseAtCoordinateworkflow)
        {
            WorkflowValue.Validate(leftClickMouseAtCoordinatexCoord, nameof(leftClickMouseAtCoordinatexCoord), required: true);
            WorkflowValue.Validate(leftClickMouseAtCoordinateyCoord, nameof(leftClickMouseAtCoordinateyCoord), required: true);
            WorkflowValue.Validate(leftClickMouseAtCoordinateworkflow, nameof(leftClickMouseAtCoordinateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/LeftClickMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var leftClickMouseAtCoordinate = new JObject();
                var leftClickMouseAtCoordinatepropCount = 0;
                leftClickMouseAtCoordinatepropCount++;
                leftClickMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(leftClickMouseAtCoordinatexCoord);
                leftClickMouseAtCoordinatepropCount++;
                leftClickMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(leftClickMouseAtCoordinateyCoord);
                leftClickMouseAtCoordinatepropCount++;
                leftClickMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(leftClickMouseAtCoordinateworkflow);
                if (leftClickMouseAtCoordinatepropCount > 0)
                {
                    callPayload.Body = leftClickMouseAtCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildLeftHoldMouse))]
        public IWorkflowAction LeftHoldMouse([WorkflowExpression] Func<double> leftHoldMousesecondsToHold, [WorkflowExpression] Func<string> leftHoldMouseworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLeftHoldMouse(WorkflowValue<double> leftHoldMousesecondsToHold, WorkflowValue<string> leftHoldMouseworkflow)
        {
            WorkflowValue.Validate(leftHoldMousesecondsToHold, nameof(leftHoldMousesecondsToHold), required: true);
            WorkflowValue.Validate(leftHoldMouseworkflow, nameof(leftHoldMouseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/LeftHoldMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var leftHoldMouse = new JObject();
                var leftHoldMousepropCount = 0;
                leftHoldMousepropCount++;
                leftHoldMouse["SecondsToHold"] = ExpressionConverter.ConvertO(leftHoldMousesecondsToHold);
                leftHoldMousepropCount++;
                leftHoldMouse["Workflow"] = ExpressionConverter.ConvertO(leftHoldMouseworkflow);
                if (leftHoldMousepropCount > 0)
                {
                    callPayload.Body = leftHoldMouse;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildLeftHoldMouseAtCoordinate))]
        public IWorkflowAction LeftHoldMouseAtCoordinate([WorkflowExpression] Func<int> leftHoldMouseAtCoordinatexCoord, [WorkflowExpression] Func<int> leftHoldMouseAtCoordinateyCoord, [WorkflowExpression] Func<double> leftHoldMouseAtCoordinatesecondsToHold, [WorkflowExpression] Func<string> leftHoldMouseAtCoordinateworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLeftHoldMouseAtCoordinate(WorkflowValue<int> leftHoldMouseAtCoordinatexCoord, WorkflowValue<int> leftHoldMouseAtCoordinateyCoord, WorkflowValue<double> leftHoldMouseAtCoordinatesecondsToHold, WorkflowValue<string> leftHoldMouseAtCoordinateworkflow)
        {
            WorkflowValue.Validate(leftHoldMouseAtCoordinatexCoord, nameof(leftHoldMouseAtCoordinatexCoord), required: true);
            WorkflowValue.Validate(leftHoldMouseAtCoordinateyCoord, nameof(leftHoldMouseAtCoordinateyCoord), required: true);
            WorkflowValue.Validate(leftHoldMouseAtCoordinatesecondsToHold, nameof(leftHoldMouseAtCoordinatesecondsToHold), required: true);
            WorkflowValue.Validate(leftHoldMouseAtCoordinateworkflow, nameof(leftHoldMouseAtCoordinateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/LeftHoldMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var leftHoldMouseAtCoordinate = new JObject();
                var leftHoldMouseAtCoordinatepropCount = 0;
                leftHoldMouseAtCoordinatepropCount++;
                leftHoldMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(leftHoldMouseAtCoordinatexCoord);
                leftHoldMouseAtCoordinatepropCount++;
                leftHoldMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(leftHoldMouseAtCoordinateyCoord);
                leftHoldMouseAtCoordinatepropCount++;
                leftHoldMouseAtCoordinate["SecondsToHold"] = ExpressionConverter.ConvertO(leftHoldMouseAtCoordinatesecondsToHold);
                leftHoldMouseAtCoordinatepropCount++;
                leftHoldMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(leftHoldMouseAtCoordinateworkflow);
                if (leftHoldMouseAtCoordinatepropCount > 0)
                {
                    callPayload.Body = leftHoldMouseAtCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRightMouseButtonDown))]
        public IWorkflowAction RightMouseButtonDown([WorkflowExpression] Func<string> rightMouseButtonDownworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRightMouseButtonDown(WorkflowValue<string> rightMouseButtonDownworkflow)
        {
            WorkflowValue.Validate(rightMouseButtonDownworkflow, nameof(rightMouseButtonDownworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/RightMouseButtonDown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rightMouseButtonDown = new JObject();
                var rightMouseButtonDownpropCount = 0;
                rightMouseButtonDownpropCount++;
                rightMouseButtonDown["Workflow"] = ExpressionConverter.ConvertO(rightMouseButtonDownworkflow);
                if (rightMouseButtonDownpropCount > 0)
                {
                    callPayload.Body = rightMouseButtonDown;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRightMouseButtonUp))]
        public IWorkflowAction RightMouseButtonUp([WorkflowExpression] Func<string> rightMouseButtonUpworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRightMouseButtonUp(WorkflowValue<string> rightMouseButtonUpworkflow)
        {
            WorkflowValue.Validate(rightMouseButtonUpworkflow, nameof(rightMouseButtonUpworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/RightMouseButtonUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rightMouseButtonUp = new JObject();
                var rightMouseButtonUppropCount = 0;
                rightMouseButtonUppropCount++;
                rightMouseButtonUp["Workflow"] = ExpressionConverter.ConvertO(rightMouseButtonUpworkflow);
                if (rightMouseButtonUppropCount > 0)
                {
                    callPayload.Body = rightMouseButtonUp;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRightClickMouse))]
        public IWorkflowAction RightClickMouse([WorkflowExpression] Func<string> rightClickMouseworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRightClickMouse(WorkflowValue<string> rightClickMouseworkflow)
        {
            WorkflowValue.Validate(rightClickMouseworkflow, nameof(rightClickMouseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/RightClickMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rightClickMouse = new JObject();
                var rightClickMousepropCount = 0;
                rightClickMousepropCount++;
                rightClickMouse["Workflow"] = ExpressionConverter.ConvertO(rightClickMouseworkflow);
                if (rightClickMousepropCount > 0)
                {
                    callPayload.Body = rightClickMouse;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRightClickMouseAtCoordinate))]
        public IWorkflowAction RightClickMouseAtCoordinate([WorkflowExpression] Func<int> rightClickMouseAtCoordinatexCoord, [WorkflowExpression] Func<int> rightClickMouseAtCoordinateyCoord, [WorkflowExpression] Func<string> rightClickMouseAtCoordinateworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRightClickMouseAtCoordinate(WorkflowValue<int> rightClickMouseAtCoordinatexCoord, WorkflowValue<int> rightClickMouseAtCoordinateyCoord, WorkflowValue<string> rightClickMouseAtCoordinateworkflow)
        {
            WorkflowValue.Validate(rightClickMouseAtCoordinatexCoord, nameof(rightClickMouseAtCoordinatexCoord), required: true);
            WorkflowValue.Validate(rightClickMouseAtCoordinateyCoord, nameof(rightClickMouseAtCoordinateyCoord), required: true);
            WorkflowValue.Validate(rightClickMouseAtCoordinateworkflow, nameof(rightClickMouseAtCoordinateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/RightClickMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rightClickMouseAtCoordinate = new JObject();
                var rightClickMouseAtCoordinatepropCount = 0;
                rightClickMouseAtCoordinatepropCount++;
                rightClickMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(rightClickMouseAtCoordinatexCoord);
                rightClickMouseAtCoordinatepropCount++;
                rightClickMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(rightClickMouseAtCoordinateyCoord);
                rightClickMouseAtCoordinatepropCount++;
                rightClickMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(rightClickMouseAtCoordinateworkflow);
                if (rightClickMouseAtCoordinatepropCount > 0)
                {
                    callPayload.Body = rightClickMouseAtCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRightHoldMouse))]
        public IWorkflowAction RightHoldMouse([WorkflowExpression] Func<double> rightHoldMousesecondsToHold, [WorkflowExpression] Func<string> rightHoldMouseworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRightHoldMouse(WorkflowValue<double> rightHoldMousesecondsToHold, WorkflowValue<string> rightHoldMouseworkflow)
        {
            WorkflowValue.Validate(rightHoldMousesecondsToHold, nameof(rightHoldMousesecondsToHold), required: true);
            WorkflowValue.Validate(rightHoldMouseworkflow, nameof(rightHoldMouseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/RightHoldMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rightHoldMouse = new JObject();
                var rightHoldMousepropCount = 0;
                rightHoldMousepropCount++;
                rightHoldMouse["SecondsToHold"] = ExpressionConverter.ConvertO(rightHoldMousesecondsToHold);
                rightHoldMousepropCount++;
                rightHoldMouse["Workflow"] = ExpressionConverter.ConvertO(rightHoldMouseworkflow);
                if (rightHoldMousepropCount > 0)
                {
                    callPayload.Body = rightHoldMouse;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRightHoldMouseAtCoordinate))]
        public IWorkflowAction RightHoldMouseAtCoordinate([WorkflowExpression] Func<int> rightHoldMouseAtCoordinatexCoord, [WorkflowExpression] Func<int> rightHoldMouseAtCoordinateyCoord, [WorkflowExpression] Func<double> rightHoldMouseAtCoordinatesecondsToHold, [WorkflowExpression] Func<string> rightHoldMouseAtCoordinateworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRightHoldMouseAtCoordinate(WorkflowValue<int> rightHoldMouseAtCoordinatexCoord, WorkflowValue<int> rightHoldMouseAtCoordinateyCoord, WorkflowValue<double> rightHoldMouseAtCoordinatesecondsToHold, WorkflowValue<string> rightHoldMouseAtCoordinateworkflow)
        {
            WorkflowValue.Validate(rightHoldMouseAtCoordinatexCoord, nameof(rightHoldMouseAtCoordinatexCoord), required: true);
            WorkflowValue.Validate(rightHoldMouseAtCoordinateyCoord, nameof(rightHoldMouseAtCoordinateyCoord), required: true);
            WorkflowValue.Validate(rightHoldMouseAtCoordinatesecondsToHold, nameof(rightHoldMouseAtCoordinatesecondsToHold), required: true);
            WorkflowValue.Validate(rightHoldMouseAtCoordinateworkflow, nameof(rightHoldMouseAtCoordinateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/RightHoldMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rightHoldMouseAtCoordinate = new JObject();
                var rightHoldMouseAtCoordinatepropCount = 0;
                rightHoldMouseAtCoordinatepropCount++;
                rightHoldMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(rightHoldMouseAtCoordinatexCoord);
                rightHoldMouseAtCoordinatepropCount++;
                rightHoldMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(rightHoldMouseAtCoordinateyCoord);
                rightHoldMouseAtCoordinatepropCount++;
                rightHoldMouseAtCoordinate["SecondsToHold"] = ExpressionConverter.ConvertO(rightHoldMouseAtCoordinatesecondsToHold);
                rightHoldMouseAtCoordinatepropCount++;
                rightHoldMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(rightHoldMouseAtCoordinateworkflow);
                if (rightHoldMouseAtCoordinatepropCount > 0)
                {
                    callPayload.Body = rightHoldMouseAtCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildMiddleMouseButtonDown))]
        public IWorkflowAction MiddleMouseButtonDown([WorkflowExpression] Func<string> middleMouseButtonDownworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMiddleMouseButtonDown(WorkflowValue<string> middleMouseButtonDownworkflow)
        {
            WorkflowValue.Validate(middleMouseButtonDownworkflow, nameof(middleMouseButtonDownworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MiddleMouseButtonDown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var middleMouseButtonDown = new JObject();
                var middleMouseButtonDownpropCount = 0;
                middleMouseButtonDownpropCount++;
                middleMouseButtonDown["Workflow"] = ExpressionConverter.ConvertO(middleMouseButtonDownworkflow);
                if (middleMouseButtonDownpropCount > 0)
                {
                    callPayload.Body = middleMouseButtonDown;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildMiddleMouseButtonUp))]
        public IWorkflowAction MiddleMouseButtonUp([WorkflowExpression] Func<string> middleMouseButtonUpworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMiddleMouseButtonUp(WorkflowValue<string> middleMouseButtonUpworkflow)
        {
            WorkflowValue.Validate(middleMouseButtonUpworkflow, nameof(middleMouseButtonUpworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MiddleMouseButtonUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var middleMouseButtonUp = new JObject();
                var middleMouseButtonUppropCount = 0;
                middleMouseButtonUppropCount++;
                middleMouseButtonUp["Workflow"] = ExpressionConverter.ConvertO(middleMouseButtonUpworkflow);
                if (middleMouseButtonUppropCount > 0)
                {
                    callPayload.Body = middleMouseButtonUp;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildMiddleClickMouse))]
        public IWorkflowAction MiddleClickMouse([WorkflowExpression] Func<string> middleClickMouseworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMiddleClickMouse(WorkflowValue<string> middleClickMouseworkflow)
        {
            WorkflowValue.Validate(middleClickMouseworkflow, nameof(middleClickMouseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MiddleClickMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var middleClickMouse = new JObject();
                var middleClickMousepropCount = 0;
                middleClickMousepropCount++;
                middleClickMouse["Workflow"] = ExpressionConverter.ConvertO(middleClickMouseworkflow);
                if (middleClickMousepropCount > 0)
                {
                    callPayload.Body = middleClickMouse;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildMiddleClickMouseAtCoordinate))]
        public IWorkflowAction MiddleClickMouseAtCoordinate([WorkflowExpression] Func<int> middleClickMouseAtCoordinatexCoord, [WorkflowExpression] Func<int> middleClickMouseAtCoordinateyCoord, [WorkflowExpression] Func<string> middleClickMouseAtCoordinateworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMiddleClickMouseAtCoordinate(WorkflowValue<int> middleClickMouseAtCoordinatexCoord, WorkflowValue<int> middleClickMouseAtCoordinateyCoord, WorkflowValue<string> middleClickMouseAtCoordinateworkflow)
        {
            WorkflowValue.Validate(middleClickMouseAtCoordinatexCoord, nameof(middleClickMouseAtCoordinatexCoord), required: true);
            WorkflowValue.Validate(middleClickMouseAtCoordinateyCoord, nameof(middleClickMouseAtCoordinateyCoord), required: true);
            WorkflowValue.Validate(middleClickMouseAtCoordinateworkflow, nameof(middleClickMouseAtCoordinateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MiddleClickMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var middleClickMouseAtCoordinate = new JObject();
                var middleClickMouseAtCoordinatepropCount = 0;
                middleClickMouseAtCoordinatepropCount++;
                middleClickMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(middleClickMouseAtCoordinatexCoord);
                middleClickMouseAtCoordinatepropCount++;
                middleClickMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(middleClickMouseAtCoordinateyCoord);
                middleClickMouseAtCoordinatepropCount++;
                middleClickMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(middleClickMouseAtCoordinateworkflow);
                if (middleClickMouseAtCoordinatepropCount > 0)
                {
                    callPayload.Body = middleClickMouseAtCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildMiddleHoldMouse))]
        public IWorkflowAction MiddleHoldMouse([WorkflowExpression] Func<double> middleHoldMousesecondsToHold, [WorkflowExpression] Func<string> middleHoldMouseworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMiddleHoldMouse(WorkflowValue<double> middleHoldMousesecondsToHold, WorkflowValue<string> middleHoldMouseworkflow)
        {
            WorkflowValue.Validate(middleHoldMousesecondsToHold, nameof(middleHoldMousesecondsToHold), required: true);
            WorkflowValue.Validate(middleHoldMouseworkflow, nameof(middleHoldMouseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MiddleHoldMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var middleHoldMouse = new JObject();
                var middleHoldMousepropCount = 0;
                middleHoldMousepropCount++;
                middleHoldMouse["SecondsToHold"] = ExpressionConverter.ConvertO(middleHoldMousesecondsToHold);
                middleHoldMousepropCount++;
                middleHoldMouse["Workflow"] = ExpressionConverter.ConvertO(middleHoldMouseworkflow);
                if (middleHoldMousepropCount > 0)
                {
                    callPayload.Body = middleHoldMouse;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildMiddleHoldMouseAtCoordinate))]
        public IWorkflowAction MiddleHoldMouseAtCoordinate([WorkflowExpression] Func<int> middleHoldMouseAtCoordinatexCoord, [WorkflowExpression] Func<int> middleHoldMouseAtCoordinateyCoord, [WorkflowExpression] Func<double> middleHoldMouseAtCoordinatesecondsToHold, [WorkflowExpression] Func<string> middleHoldMouseAtCoordinateworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMiddleHoldMouseAtCoordinate(WorkflowValue<int> middleHoldMouseAtCoordinatexCoord, WorkflowValue<int> middleHoldMouseAtCoordinateyCoord, WorkflowValue<double> middleHoldMouseAtCoordinatesecondsToHold, WorkflowValue<string> middleHoldMouseAtCoordinateworkflow)
        {
            WorkflowValue.Validate(middleHoldMouseAtCoordinatexCoord, nameof(middleHoldMouseAtCoordinatexCoord), required: true);
            WorkflowValue.Validate(middleHoldMouseAtCoordinateyCoord, nameof(middleHoldMouseAtCoordinateyCoord), required: true);
            WorkflowValue.Validate(middleHoldMouseAtCoordinatesecondsToHold, nameof(middleHoldMouseAtCoordinatesecondsToHold), required: true);
            WorkflowValue.Validate(middleHoldMouseAtCoordinateworkflow, nameof(middleHoldMouseAtCoordinateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MiddleHoldMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var middleHoldMouseAtCoordinate = new JObject();
                var middleHoldMouseAtCoordinatepropCount = 0;
                middleHoldMouseAtCoordinatepropCount++;
                middleHoldMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(middleHoldMouseAtCoordinatexCoord);
                middleHoldMouseAtCoordinatepropCount++;
                middleHoldMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(middleHoldMouseAtCoordinateyCoord);
                middleHoldMouseAtCoordinatepropCount++;
                middleHoldMouseAtCoordinate["SecondsToHold"] = ExpressionConverter.ConvertO(middleHoldMouseAtCoordinatesecondsToHold);
                middleHoldMouseAtCoordinatepropCount++;
                middleHoldMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(middleHoldMouseAtCoordinateworkflow);
                if (middleHoldMouseAtCoordinatepropCount > 0)
                {
                    callPayload.Body = middleHoldMouseAtCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildDoubleLeftClickMouse))]
        public IWorkflowAction DoubleLeftClickMouse([WorkflowExpression] Func<string> doubleLeftClickMouseworkflow, [WorkflowExpression] Func<int> doubleLeftClickMousedelayInMilliseconds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDoubleLeftClickMouse(WorkflowValue<string> doubleLeftClickMouseworkflow, WorkflowValue<int> doubleLeftClickMousedelayInMilliseconds = null)
        {
            WorkflowValue.Validate(doubleLeftClickMouseworkflow, nameof(doubleLeftClickMouseworkflow), required: true);
            WorkflowValue.Validate(doubleLeftClickMousedelayInMilliseconds, nameof(doubleLeftClickMousedelayInMilliseconds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/DoubleLeftClickMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var doubleLeftClickMouse = new JObject();
                var doubleLeftClickMousepropCount = 0;
                if (doubleLeftClickMousedelayInMilliseconds != null)
                {
                    if (doubleLeftClickMousedelayInMilliseconds != null)
                    {
                        doubleLeftClickMouse["DelayInMilliseconds"] = ExpressionConverter.ConvertO(doubleLeftClickMousedelayInMilliseconds);
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
                doubleLeftClickMouse["Workflow"] = ExpressionConverter.ConvertO(doubleLeftClickMouseworkflow);
                if (doubleLeftClickMousepropCount > 0)
                {
                    callPayload.Body = doubleLeftClickMouse;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildDoubleLeftClickMouseAtCoordinate))]
        public IWorkflowAction DoubleLeftClickMouseAtCoordinate([WorkflowExpression] Func<int> doubleLeftClickMouseAtCoordinatexCoord, [WorkflowExpression] Func<int> doubleLeftClickMouseAtCoordinateyCoord, [WorkflowExpression] Func<string> doubleLeftClickMouseAtCoordinateworkflow, [WorkflowExpression] Func<int> doubleLeftClickMouseAtCoordinatedelayInMilliseconds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDoubleLeftClickMouseAtCoordinate(WorkflowValue<int> doubleLeftClickMouseAtCoordinatexCoord, WorkflowValue<int> doubleLeftClickMouseAtCoordinateyCoord, WorkflowValue<string> doubleLeftClickMouseAtCoordinateworkflow, WorkflowValue<int> doubleLeftClickMouseAtCoordinatedelayInMilliseconds = null)
        {
            WorkflowValue.Validate(doubleLeftClickMouseAtCoordinatexCoord, nameof(doubleLeftClickMouseAtCoordinatexCoord), required: true);
            WorkflowValue.Validate(doubleLeftClickMouseAtCoordinateyCoord, nameof(doubleLeftClickMouseAtCoordinateyCoord), required: true);
            WorkflowValue.Validate(doubleLeftClickMouseAtCoordinateworkflow, nameof(doubleLeftClickMouseAtCoordinateworkflow), required: true);
            WorkflowValue.Validate(doubleLeftClickMouseAtCoordinatedelayInMilliseconds, nameof(doubleLeftClickMouseAtCoordinatedelayInMilliseconds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/DoubleLeftClickMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var doubleLeftClickMouseAtCoordinate = new JObject();
                var doubleLeftClickMouseAtCoordinatepropCount = 0;
                doubleLeftClickMouseAtCoordinatepropCount++;
                doubleLeftClickMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(doubleLeftClickMouseAtCoordinatexCoord);
                doubleLeftClickMouseAtCoordinatepropCount++;
                doubleLeftClickMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(doubleLeftClickMouseAtCoordinateyCoord);
                if (doubleLeftClickMouseAtCoordinatedelayInMilliseconds != null)
                {
                    if (doubleLeftClickMouseAtCoordinatedelayInMilliseconds != null)
                    {
                        doubleLeftClickMouseAtCoordinate["DelayInMilliseconds"] = ExpressionConverter.ConvertO(doubleLeftClickMouseAtCoordinatedelayInMilliseconds);
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
                doubleLeftClickMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(doubleLeftClickMouseAtCoordinateworkflow);
                if (doubleLeftClickMouseAtCoordinatepropCount > 0)
                {
                    callPayload.Body = doubleLeftClickMouseAtCoordinate;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildLeftMouseDragBetweenCoordinates))]
        public IWorkflowAction LeftMouseDragBetweenCoordinates([WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesstartXCoord, [WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesstartYCoord, [WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesendXCoord, [WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesendYCoord, [WorkflowExpression] Func<string> leftMouseDragBetweenCoordinatesworkflow, [WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesnumberOfSteps = null, [WorkflowExpression] Func<double> leftMouseDragBetweenCoordinatestotalTimeInSeconds = null, [WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, [WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, [WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLeftMouseDragBetweenCoordinates(WorkflowValue<int> leftMouseDragBetweenCoordinatesstartXCoord, WorkflowValue<int> leftMouseDragBetweenCoordinatesstartYCoord, WorkflowValue<int> leftMouseDragBetweenCoordinatesendXCoord, WorkflowValue<int> leftMouseDragBetweenCoordinatesendYCoord, WorkflowValue<string> leftMouseDragBetweenCoordinatesworkflow, WorkflowValue<int> leftMouseDragBetweenCoordinatesnumberOfSteps = null, WorkflowValue<double> leftMouseDragBetweenCoordinatestotalTimeInSeconds = null, WorkflowValue<int> leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, WorkflowValue<int> leftMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, WorkflowValue<int> leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            WorkflowValue.Validate(leftMouseDragBetweenCoordinatesstartXCoord, nameof(leftMouseDragBetweenCoordinatesstartXCoord), required: true);
            WorkflowValue.Validate(leftMouseDragBetweenCoordinatesstartYCoord, nameof(leftMouseDragBetweenCoordinatesstartYCoord), required: true);
            WorkflowValue.Validate(leftMouseDragBetweenCoordinatesendXCoord, nameof(leftMouseDragBetweenCoordinatesendXCoord), required: true);
            WorkflowValue.Validate(leftMouseDragBetweenCoordinatesendYCoord, nameof(leftMouseDragBetweenCoordinatesendYCoord), required: true);
            WorkflowValue.Validate(leftMouseDragBetweenCoordinatesworkflow, nameof(leftMouseDragBetweenCoordinatesworkflow), required: true);
            WorkflowValue.Validate(leftMouseDragBetweenCoordinatesnumberOfSteps, nameof(leftMouseDragBetweenCoordinatesnumberOfSteps), required: false);
            WorkflowValue.Validate(leftMouseDragBetweenCoordinatestotalTimeInSeconds, nameof(leftMouseDragBetweenCoordinatestotalTimeInSeconds), required: false);
            WorkflowValue.Validate(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter, nameof(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter), required: false);
            WorkflowValue.Validate(leftMouseDragBetweenCoordinatesmaximumEndPixelJitter, nameof(leftMouseDragBetweenCoordinatesmaximumEndPixelJitter), required: false);
            WorkflowValue.Validate(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta, nameof(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/LeftMouseDragBetweenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var leftMouseDragBetweenCoordinates = new JObject();
                var leftMouseDragBetweenCoordinatespropCount = 0;
                leftMouseDragBetweenCoordinatespropCount++;
                leftMouseDragBetweenCoordinates["StartXCoord"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesstartXCoord);
                leftMouseDragBetweenCoordinatespropCount++;
                leftMouseDragBetweenCoordinates["StartYCoord"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesstartYCoord);
                leftMouseDragBetweenCoordinatespropCount++;
                leftMouseDragBetweenCoordinates["EndXCoord"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesendXCoord);
                leftMouseDragBetweenCoordinatespropCount++;
                leftMouseDragBetweenCoordinates["EndYCoord"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesendYCoord);
                if (leftMouseDragBetweenCoordinatesnumberOfSteps != null)
                {
                    if (leftMouseDragBetweenCoordinatesnumberOfSteps != null)
                    {
                        leftMouseDragBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesnumberOfSteps);
                        leftMouseDragBetweenCoordinatespropCount++;
                    }

                    leftMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    leftMouseDragBetweenCoordinates["NumberOfSteps"] = 20;
                    leftMouseDragBetweenCoordinatespropCount++;
                }

                if (leftMouseDragBetweenCoordinatestotalTimeInSeconds != null)
                {
                    if (leftMouseDragBetweenCoordinatestotalTimeInSeconds != null)
                    {
                        leftMouseDragBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatestotalTimeInSeconds);
                        leftMouseDragBetweenCoordinatespropCount++;
                    }

                    leftMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    leftMouseDragBetweenCoordinates["TotalTimeInSeconds"] = 0.5;
                    leftMouseDragBetweenCoordinatespropCount++;
                }

                if (leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter != null)
                {
                    leftMouseDragBetweenCoordinates["MaximumMovementPixelJitter"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter);
                    leftMouseDragBetweenCoordinatespropCount++;
                }

                if (leftMouseDragBetweenCoordinatesmaximumEndPixelJitter != null)
                {
                    leftMouseDragBetweenCoordinates["MaximumEndPixelJitter"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesmaximumEndPixelJitter);
                    leftMouseDragBetweenCoordinatespropCount++;
                }

                if (leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                {
                    if (leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                    {
                        leftMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
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
                leftMouseDragBetweenCoordinates["Workflow"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesworkflow);
                if (leftMouseDragBetweenCoordinatespropCount > 0)
                {
                    callPayload.Body = leftMouseDragBetweenCoordinates;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRightMouseDragBetweenCoordinates))]
        public IWorkflowAction RightMouseDragBetweenCoordinates([WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesstartXCoord, [WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesstartYCoord, [WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesendXCoord, [WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesendYCoord, [WorkflowExpression] Func<string> rightMouseDragBetweenCoordinatesworkflow, [WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesnumberOfSteps = null, [WorkflowExpression] Func<double> rightMouseDragBetweenCoordinatestotalTimeInSeconds = null, [WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, [WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, [WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRightMouseDragBetweenCoordinates(WorkflowValue<int> rightMouseDragBetweenCoordinatesstartXCoord, WorkflowValue<int> rightMouseDragBetweenCoordinatesstartYCoord, WorkflowValue<int> rightMouseDragBetweenCoordinatesendXCoord, WorkflowValue<int> rightMouseDragBetweenCoordinatesendYCoord, WorkflowValue<string> rightMouseDragBetweenCoordinatesworkflow, WorkflowValue<int> rightMouseDragBetweenCoordinatesnumberOfSteps = null, WorkflowValue<double> rightMouseDragBetweenCoordinatestotalTimeInSeconds = null, WorkflowValue<int> rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, WorkflowValue<int> rightMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, WorkflowValue<int> rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            WorkflowValue.Validate(rightMouseDragBetweenCoordinatesstartXCoord, nameof(rightMouseDragBetweenCoordinatesstartXCoord), required: true);
            WorkflowValue.Validate(rightMouseDragBetweenCoordinatesstartYCoord, nameof(rightMouseDragBetweenCoordinatesstartYCoord), required: true);
            WorkflowValue.Validate(rightMouseDragBetweenCoordinatesendXCoord, nameof(rightMouseDragBetweenCoordinatesendXCoord), required: true);
            WorkflowValue.Validate(rightMouseDragBetweenCoordinatesendYCoord, nameof(rightMouseDragBetweenCoordinatesendYCoord), required: true);
            WorkflowValue.Validate(rightMouseDragBetweenCoordinatesworkflow, nameof(rightMouseDragBetweenCoordinatesworkflow), required: true);
            WorkflowValue.Validate(rightMouseDragBetweenCoordinatesnumberOfSteps, nameof(rightMouseDragBetweenCoordinatesnumberOfSteps), required: false);
            WorkflowValue.Validate(rightMouseDragBetweenCoordinatestotalTimeInSeconds, nameof(rightMouseDragBetweenCoordinatestotalTimeInSeconds), required: false);
            WorkflowValue.Validate(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter, nameof(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter), required: false);
            WorkflowValue.Validate(rightMouseDragBetweenCoordinatesmaximumEndPixelJitter, nameof(rightMouseDragBetweenCoordinatesmaximumEndPixelJitter), required: false);
            WorkflowValue.Validate(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta, nameof(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/RightMouseDragBetweenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rightMouseDragBetweenCoordinates = new JObject();
                var rightMouseDragBetweenCoordinatespropCount = 0;
                rightMouseDragBetweenCoordinatespropCount++;
                rightMouseDragBetweenCoordinates["StartXCoord"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesstartXCoord);
                rightMouseDragBetweenCoordinatespropCount++;
                rightMouseDragBetweenCoordinates["StartYCoord"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesstartYCoord);
                rightMouseDragBetweenCoordinatespropCount++;
                rightMouseDragBetweenCoordinates["EndXCoord"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesendXCoord);
                rightMouseDragBetweenCoordinatespropCount++;
                rightMouseDragBetweenCoordinates["EndYCoord"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesendYCoord);
                if (rightMouseDragBetweenCoordinatesnumberOfSteps != null)
                {
                    if (rightMouseDragBetweenCoordinatesnumberOfSteps != null)
                    {
                        rightMouseDragBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesnumberOfSteps);
                        rightMouseDragBetweenCoordinatespropCount++;
                    }

                    rightMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    rightMouseDragBetweenCoordinates["NumberOfSteps"] = 20;
                    rightMouseDragBetweenCoordinatespropCount++;
                }

                if (rightMouseDragBetweenCoordinatestotalTimeInSeconds != null)
                {
                    if (rightMouseDragBetweenCoordinatestotalTimeInSeconds != null)
                    {
                        rightMouseDragBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatestotalTimeInSeconds);
                        rightMouseDragBetweenCoordinatespropCount++;
                    }

                    rightMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    rightMouseDragBetweenCoordinates["TotalTimeInSeconds"] = 0.5;
                    rightMouseDragBetweenCoordinatespropCount++;
                }

                if (rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter != null)
                {
                    rightMouseDragBetweenCoordinates["MaximumMovementPixelJitter"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter);
                    rightMouseDragBetweenCoordinatespropCount++;
                }

                if (rightMouseDragBetweenCoordinatesmaximumEndPixelJitter != null)
                {
                    rightMouseDragBetweenCoordinates["MaximumEndPixelJitter"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesmaximumEndPixelJitter);
                    rightMouseDragBetweenCoordinatespropCount++;
                }

                if (rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                {
                    if (rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                    {
                        rightMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
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
                rightMouseDragBetweenCoordinates["Workflow"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesworkflow);
                if (rightMouseDragBetweenCoordinatespropCount > 0)
                {
                    callPayload.Body = rightMouseDragBetweenCoordinates;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildMiddleMouseDragBetweenCoordinates))]
        public IWorkflowAction MiddleMouseDragBetweenCoordinates([WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesstartXCoord, [WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesstartYCoord, [WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesendXCoord, [WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesendYCoord, [WorkflowExpression] Func<string> middleMouseDragBetweenCoordinatesworkflow, [WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesnumberOfSteps = null, [WorkflowExpression] Func<double> middleMouseDragBetweenCoordinatestotalTimeInSeconds = null, [WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, [WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, [WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMiddleMouseDragBetweenCoordinates(WorkflowValue<int> middleMouseDragBetweenCoordinatesstartXCoord, WorkflowValue<int> middleMouseDragBetweenCoordinatesstartYCoord, WorkflowValue<int> middleMouseDragBetweenCoordinatesendXCoord, WorkflowValue<int> middleMouseDragBetweenCoordinatesendYCoord, WorkflowValue<string> middleMouseDragBetweenCoordinatesworkflow, WorkflowValue<int> middleMouseDragBetweenCoordinatesnumberOfSteps = null, WorkflowValue<double> middleMouseDragBetweenCoordinatestotalTimeInSeconds = null, WorkflowValue<int> middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, WorkflowValue<int> middleMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, WorkflowValue<int> middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            WorkflowValue.Validate(middleMouseDragBetweenCoordinatesstartXCoord, nameof(middleMouseDragBetweenCoordinatesstartXCoord), required: true);
            WorkflowValue.Validate(middleMouseDragBetweenCoordinatesstartYCoord, nameof(middleMouseDragBetweenCoordinatesstartYCoord), required: true);
            WorkflowValue.Validate(middleMouseDragBetweenCoordinatesendXCoord, nameof(middleMouseDragBetweenCoordinatesendXCoord), required: true);
            WorkflowValue.Validate(middleMouseDragBetweenCoordinatesendYCoord, nameof(middleMouseDragBetweenCoordinatesendYCoord), required: true);
            WorkflowValue.Validate(middleMouseDragBetweenCoordinatesworkflow, nameof(middleMouseDragBetweenCoordinatesworkflow), required: true);
            WorkflowValue.Validate(middleMouseDragBetweenCoordinatesnumberOfSteps, nameof(middleMouseDragBetweenCoordinatesnumberOfSteps), required: false);
            WorkflowValue.Validate(middleMouseDragBetweenCoordinatestotalTimeInSeconds, nameof(middleMouseDragBetweenCoordinatestotalTimeInSeconds), required: false);
            WorkflowValue.Validate(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter, nameof(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter), required: false);
            WorkflowValue.Validate(middleMouseDragBetweenCoordinatesmaximumEndPixelJitter, nameof(middleMouseDragBetweenCoordinatesmaximumEndPixelJitter), required: false);
            WorkflowValue.Validate(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta, nameof(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MiddleMouseDragBetweenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var middleMouseDragBetweenCoordinates = new JObject();
                var middleMouseDragBetweenCoordinatespropCount = 0;
                middleMouseDragBetweenCoordinatespropCount++;
                middleMouseDragBetweenCoordinates["StartXCoord"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesstartXCoord);
                middleMouseDragBetweenCoordinatespropCount++;
                middleMouseDragBetweenCoordinates["StartYCoord"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesstartYCoord);
                middleMouseDragBetweenCoordinatespropCount++;
                middleMouseDragBetweenCoordinates["EndXCoord"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesendXCoord);
                middleMouseDragBetweenCoordinatespropCount++;
                middleMouseDragBetweenCoordinates["EndYCoord"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesendYCoord);
                if (middleMouseDragBetweenCoordinatesnumberOfSteps != null)
                {
                    if (middleMouseDragBetweenCoordinatesnumberOfSteps != null)
                    {
                        middleMouseDragBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesnumberOfSteps);
                        middleMouseDragBetweenCoordinatespropCount++;
                    }

                    middleMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    middleMouseDragBetweenCoordinates["NumberOfSteps"] = 20;
                    middleMouseDragBetweenCoordinatespropCount++;
                }

                if (middleMouseDragBetweenCoordinatestotalTimeInSeconds != null)
                {
                    if (middleMouseDragBetweenCoordinatestotalTimeInSeconds != null)
                    {
                        middleMouseDragBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatestotalTimeInSeconds);
                        middleMouseDragBetweenCoordinatespropCount++;
                    }

                    middleMouseDragBetweenCoordinatespropCount++;
                }
                else
                {
                    middleMouseDragBetweenCoordinates["TotalTimeInSeconds"] = 0.5;
                    middleMouseDragBetweenCoordinatespropCount++;
                }

                if (middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter != null)
                {
                    middleMouseDragBetweenCoordinates["MaximumMovementPixelJitter"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter);
                    middleMouseDragBetweenCoordinatespropCount++;
                }

                if (middleMouseDragBetweenCoordinatesmaximumEndPixelJitter != null)
                {
                    middleMouseDragBetweenCoordinates["MaximumEndPixelJitter"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesmaximumEndPixelJitter);
                    middleMouseDragBetweenCoordinatespropCount++;
                }

                if (middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                {
                    if (middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                    {
                        middleMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
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
                middleMouseDragBetweenCoordinates["Workflow"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesworkflow);
                if (middleMouseDragBetweenCoordinatespropCount > 0)
                {
                    callPayload.Body = middleMouseDragBetweenCoordinates;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildMoveMouseBetweenCoordinates))]
        public IWorkflowAction MoveMouseBetweenCoordinates([WorkflowExpression] Func<int> moveMouseBetweenCoordinatesstartXCoord, [WorkflowExpression] Func<int> moveMouseBetweenCoordinatesstartYCoord, [WorkflowExpression] Func<int> moveMouseBetweenCoordinatesendXCoord, [WorkflowExpression] Func<int> moveMouseBetweenCoordinatesendYCoord, [WorkflowExpression] Func<string> moveMouseBetweenCoordinatesworkflow, [WorkflowExpression] Func<int> moveMouseBetweenCoordinatesnumberOfSteps = null, [WorkflowExpression] Func<double> moveMouseBetweenCoordinatestotalTimeInSeconds = null, [WorkflowExpression] Func<int> moveMouseBetweenCoordinatesmaximumMovementPixelJitter = null, [WorkflowExpression] Func<int> moveMouseBetweenCoordinatesmaximumEndPixelJitter = null, [WorkflowExpression] Func<int> moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveMouseBetweenCoordinates(WorkflowValue<int> moveMouseBetweenCoordinatesstartXCoord, WorkflowValue<int> moveMouseBetweenCoordinatesstartYCoord, WorkflowValue<int> moveMouseBetweenCoordinatesendXCoord, WorkflowValue<int> moveMouseBetweenCoordinatesendYCoord, WorkflowValue<string> moveMouseBetweenCoordinatesworkflow, WorkflowValue<int> moveMouseBetweenCoordinatesnumberOfSteps = null, WorkflowValue<double> moveMouseBetweenCoordinatestotalTimeInSeconds = null, WorkflowValue<int> moveMouseBetweenCoordinatesmaximumMovementPixelJitter = null, WorkflowValue<int> moveMouseBetweenCoordinatesmaximumEndPixelJitter = null, WorkflowValue<int> moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            WorkflowValue.Validate(moveMouseBetweenCoordinatesstartXCoord, nameof(moveMouseBetweenCoordinatesstartXCoord), required: true);
            WorkflowValue.Validate(moveMouseBetweenCoordinatesstartYCoord, nameof(moveMouseBetweenCoordinatesstartYCoord), required: true);
            WorkflowValue.Validate(moveMouseBetweenCoordinatesendXCoord, nameof(moveMouseBetweenCoordinatesendXCoord), required: true);
            WorkflowValue.Validate(moveMouseBetweenCoordinatesendYCoord, nameof(moveMouseBetweenCoordinatesendYCoord), required: true);
            WorkflowValue.Validate(moveMouseBetweenCoordinatesworkflow, nameof(moveMouseBetweenCoordinatesworkflow), required: true);
            WorkflowValue.Validate(moveMouseBetweenCoordinatesnumberOfSteps, nameof(moveMouseBetweenCoordinatesnumberOfSteps), required: false);
            WorkflowValue.Validate(moveMouseBetweenCoordinatestotalTimeInSeconds, nameof(moveMouseBetweenCoordinatestotalTimeInSeconds), required: false);
            WorkflowValue.Validate(moveMouseBetweenCoordinatesmaximumMovementPixelJitter, nameof(moveMouseBetweenCoordinatesmaximumMovementPixelJitter), required: false);
            WorkflowValue.Validate(moveMouseBetweenCoordinatesmaximumEndPixelJitter, nameof(moveMouseBetweenCoordinatesmaximumEndPixelJitter), required: false);
            WorkflowValue.Validate(moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta, nameof(moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/MoveMouseBetweenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var moveMouseBetweenCoordinates = new JObject();
                var moveMouseBetweenCoordinatespropCount = 0;
                moveMouseBetweenCoordinatespropCount++;
                moveMouseBetweenCoordinates["StartXCoord"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesstartXCoord);
                moveMouseBetweenCoordinatespropCount++;
                moveMouseBetweenCoordinates["StartYCoord"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesstartYCoord);
                moveMouseBetweenCoordinatespropCount++;
                moveMouseBetweenCoordinates["EndXCoord"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesendXCoord);
                moveMouseBetweenCoordinatespropCount++;
                moveMouseBetweenCoordinates["EndYCoord"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesendYCoord);
                if (moveMouseBetweenCoordinatesnumberOfSteps != null)
                {
                    if (moveMouseBetweenCoordinatesnumberOfSteps != null)
                    {
                        moveMouseBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesnumberOfSteps);
                        moveMouseBetweenCoordinatespropCount++;
                    }

                    moveMouseBetweenCoordinatespropCount++;
                }
                else
                {
                    moveMouseBetweenCoordinates["NumberOfSteps"] = 20;
                    moveMouseBetweenCoordinatespropCount++;
                }

                if (moveMouseBetweenCoordinatestotalTimeInSeconds != null)
                {
                    if (moveMouseBetweenCoordinatestotalTimeInSeconds != null)
                    {
                        moveMouseBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatestotalTimeInSeconds);
                        moveMouseBetweenCoordinatespropCount++;
                    }

                    moveMouseBetweenCoordinatespropCount++;
                }
                else
                {
                    moveMouseBetweenCoordinates["TotalTimeInSeconds"] = 0.5;
                    moveMouseBetweenCoordinatespropCount++;
                }

                if (moveMouseBetweenCoordinatesmaximumMovementPixelJitter != null)
                {
                    moveMouseBetweenCoordinates["MaximumMovementPixelJitter"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesmaximumMovementPixelJitter);
                    moveMouseBetweenCoordinatespropCount++;
                }

                if (moveMouseBetweenCoordinatesmaximumEndPixelJitter != null)
                {
                    moveMouseBetweenCoordinates["MaximumEndPixelJitter"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesmaximumEndPixelJitter);
                    moveMouseBetweenCoordinatespropCount++;
                }

                if (moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                {
                    if (moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                    {
                        moveMouseBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta);
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
                moveMouseBetweenCoordinates["Workflow"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesworkflow);
                if (moveMouseBetweenCoordinatespropCount > 0)
                {
                    callPayload.Body = moveMouseBetweenCoordinates;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildTurnMouseWheel))]
        public IWorkflowAction TurnMouseWheel([WorkflowExpression] Func<int> turnMouseWheelwheelTurns, [WorkflowExpression] Func<string> turnMouseWheelworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTurnMouseWheel(WorkflowValue<int> turnMouseWheelwheelTurns, WorkflowValue<string> turnMouseWheelworkflow)
        {
            WorkflowValue.Validate(turnMouseWheelwheelTurns, nameof(turnMouseWheelwheelTurns), required: true);
            WorkflowValue.Validate(turnMouseWheelworkflow, nameof(turnMouseWheelworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/TurnMouseWheel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var turnMouseWheel = new JObject();
                var turnMouseWheelpropCount = 0;
                turnMouseWheelpropCount++;
                turnMouseWheel["WheelTurns"] = ExpressionConverter.ConvertO(turnMouseWheelwheelTurns);
                turnMouseWheelpropCount++;
                turnMouseWheel["Workflow"] = ExpressionConverter.ConvertO(turnMouseWheelworkflow);
                if (turnMouseWheelpropCount > 0)
                {
                    callPayload.Body = turnMouseWheel;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetCursorPos))]
        public IWorkflowAction SetCursorPos([WorkflowExpression] Func<int> setCursorPosx, [WorkflowExpression] Func<int> setCursorPosy, [WorkflowExpression] Func<string> setCursorPosworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetCursorPos(WorkflowValue<int> setCursorPosx, WorkflowValue<int> setCursorPosy, WorkflowValue<string> setCursorPosworkflow)
        {
            WorkflowValue.Validate(setCursorPosx, nameof(setCursorPosx), required: true);
            WorkflowValue.Validate(setCursorPosy, nameof(setCursorPosy), required: true);
            WorkflowValue.Validate(setCursorPosworkflow, nameof(setCursorPosworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setCursorPos = new JObject();
                var setCursorPospropCount = 0;
                setCursorPospropCount++;
                setCursorPos["X"] = ExpressionConverter.ConvertO(setCursorPosx);
                setCursorPospropCount++;
                setCursorPos["Y"] = ExpressionConverter.ConvertO(setCursorPosy);
                setCursorPospropCount++;
                setCursorPos["Workflow"] = ExpressionConverter.ConvertO(setCursorPosworkflow);
                if (setCursorPospropCount > 0)
                {
                    callPayload.Body = setCursorPos;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetCursorPos))]
        public IBodyWorkflowAction<GetCursorPosResponse> GetCursorPos([WorkflowExpression] Func<string> getCursorPosworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCursorPosResponse> __BuildGetCursorPos(WorkflowValue<string> getCursorPosworkflow)
        {
            WorkflowValue.Validate(getCursorPosworkflow, nameof(getCursorPosworkflow), required: true);
            return new DeferredBodyAction<GetCursorPosResponse>(() =>
            {
                var apiCallPath = "/Environment/GetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getCursorPos = new JObject();
                var getCursorPospropCount = 0;
                getCursorPospropCount++;
                getCursorPos["Workflow"] = ExpressionConverter.ConvertO(getCursorPosworkflow);
                if (getCursorPospropCount > 0)
                {
                    callPayload.Body = getCursorPos;
                }

                return new ApiConnectionAction<GetCursorPosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildCalibrateMouseEvent))]
        public IBodyWorkflowAction<CalibrateMouseEventResponse> CalibrateMouseEvent([WorkflowExpression] Func<string> calibrateMouseEventworkflow, [WorkflowExpression] Func<int> calibrateMouseEventcalibrationSizeInPixels = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalibrateMouseEventResponse> __BuildCalibrateMouseEvent(WorkflowValue<string> calibrateMouseEventworkflow, WorkflowValue<int> calibrateMouseEventcalibrationSizeInPixels = null)
        {
            WorkflowValue.Validate(calibrateMouseEventworkflow, nameof(calibrateMouseEventworkflow), required: true);
            WorkflowValue.Validate(calibrateMouseEventcalibrationSizeInPixels, nameof(calibrateMouseEventcalibrationSizeInPixels), required: false);
            return new DeferredBodyAction<CalibrateMouseEventResponse>(() =>
            {
                var apiCallPath = "/Environment/CalibrateMouseEvent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var calibrateMouseEvent = new JObject();
                var calibrateMouseEventpropCount = 0;
                if (calibrateMouseEventcalibrationSizeInPixels != null)
                {
                    if (calibrateMouseEventcalibrationSizeInPixels != null)
                    {
                        calibrateMouseEvent["CalibrationSizeInPixels"] = ExpressionConverter.ConvertO(calibrateMouseEventcalibrationSizeInPixels);
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
                calibrateMouseEvent["Workflow"] = ExpressionConverter.ConvertO(calibrateMouseEventworkflow);
                if (calibrateMouseEventpropCount > 0)
                {
                    callPayload.Body = calibrateMouseEvent;
                }

                return new ApiConnectionAction<CalibrateMouseEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetMouseMoveMethod))]
        public IBodyWorkflowAction<GetMouseMoveMethodResponse> GetMouseMoveMethod([WorkflowExpression] Func<string> getMouseMoveMethodworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMouseMoveMethodResponse> __BuildGetMouseMoveMethod(WorkflowValue<string> getMouseMoveMethodworkflow)
        {
            WorkflowValue.Validate(getMouseMoveMethodworkflow, nameof(getMouseMoveMethodworkflow), required: true);
            return new DeferredBodyAction<GetMouseMoveMethodResponse>(() =>
            {
                var apiCallPath = "/Environment/GetMouseMoveMethod";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getMouseMoveMethod = new JObject();
                var getMouseMoveMethodpropCount = 0;
                getMouseMoveMethodpropCount++;
                getMouseMoveMethod["Workflow"] = ExpressionConverter.ConvertO(getMouseMoveMethodworkflow);
                if (getMouseMoveMethodpropCount > 0)
                {
                    callPayload.Body = getMouseMoveMethod;
                }

                return new ApiConnectionAction<GetMouseMoveMethodResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetMouseMoveMethod))]
        public IWorkflowAction SetMouseMoveMethod([WorkflowExpression] Func<setMouseMoveMethodmouseMoveMethodInput> setMouseMoveMethodmouseMoveMethod, [WorkflowExpression] Func<string> setMouseMoveMethodworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetMouseMoveMethod(WorkflowValue<setMouseMoveMethodmouseMoveMethodInput> setMouseMoveMethodmouseMoveMethod, WorkflowValue<string> setMouseMoveMethodworkflow)
        {
            WorkflowValue.Validate(setMouseMoveMethodmouseMoveMethod, nameof(setMouseMoveMethodmouseMoveMethod), required: true);
            WorkflowValue.Validate(setMouseMoveMethodworkflow, nameof(setMouseMoveMethodworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SetMouseMoveMethod";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setMouseMoveMethod = new JObject();
                var setMouseMoveMethodpropCount = 0;
                setMouseMoveMethodpropCount++;
                setMouseMoveMethod["MouseMoveMethod"] = ExpressionConverter.ConvertO(setMouseMoveMethodmouseMoveMethod);
                setMouseMoveMethodpropCount++;
                setMouseMoveMethod["Workflow"] = ExpressionConverter.ConvertO(setMouseMoveMethodworkflow);
                if (setMouseMoveMethodpropCount > 0)
                {
                    callPayload.Body = setMouseMoveMethod;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildWiggleMouse))]
        public IWorkflowAction WiggleMouse([WorkflowExpression] Func<string> wiggleMouseworkflow, [WorkflowExpression] Func<int> wiggleMousexWiggle = null, [WorkflowExpression] Func<int> wiggleMouseyWiggle = null, [WorkflowExpression] Func<double> wiggleMousewiggleDelayInSeconds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildWiggleMouse(WorkflowValue<string> wiggleMouseworkflow, WorkflowValue<int> wiggleMousexWiggle = null, WorkflowValue<int> wiggleMouseyWiggle = null, WorkflowValue<double> wiggleMousewiggleDelayInSeconds = null)
        {
            WorkflowValue.Validate(wiggleMouseworkflow, nameof(wiggleMouseworkflow), required: true);
            WorkflowValue.Validate(wiggleMousexWiggle, nameof(wiggleMousexWiggle), required: false);
            WorkflowValue.Validate(wiggleMouseyWiggle, nameof(wiggleMouseyWiggle), required: false);
            WorkflowValue.Validate(wiggleMousewiggleDelayInSeconds, nameof(wiggleMousewiggleDelayInSeconds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/WiggleMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var wiggleMouse = new JObject();
                var wiggleMousepropCount = 0;
                if (wiggleMousexWiggle != null)
                {
                    if (wiggleMousexWiggle != null)
                    {
                        wiggleMouse["XWiggle"] = ExpressionConverter.ConvertO(wiggleMousexWiggle);
                        wiggleMousepropCount++;
                    }

                    wiggleMousepropCount++;
                }
                else
                {
                    wiggleMouse["XWiggle"] = 2;
                    wiggleMousepropCount++;
                }

                if (wiggleMouseyWiggle != null)
                {
                    wiggleMouse["YWiggle"] = ExpressionConverter.ConvertO(wiggleMouseyWiggle);
                    wiggleMousepropCount++;
                }

                if (wiggleMousewiggleDelayInSeconds != null)
                {
                    if (wiggleMousewiggleDelayInSeconds != null)
                    {
                        wiggleMouse["WiggleDelayInSeconds"] = ExpressionConverter.ConvertO(wiggleMousewiggleDelayInSeconds);
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
                wiggleMouse["Workflow"] = ExpressionConverter.ConvertO(wiggleMouseworkflow);
                if (wiggleMousepropCount > 0)
                {
                    callPayload.Body = wiggleMouse;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSendKeyEvents))]
        public IWorkflowAction SendKeyEvents([WorkflowExpression] Func<string> sendKeyEventstext, [WorkflowExpression] Func<string> sendKeyEventsworkflow, [WorkflowExpression] Func<int> sendKeyEventsinterval = null, [WorkflowExpression] Func<bool> sendKeyEventsisPassword = null, [WorkflowExpression] Func<bool> sendKeyEventsdontInterpretSymbols = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendKeyEvents(WorkflowValue<string> sendKeyEventstext, WorkflowValue<string> sendKeyEventsworkflow, WorkflowValue<int> sendKeyEventsinterval = null, WorkflowValue<bool> sendKeyEventsisPassword = null, WorkflowValue<bool> sendKeyEventsdontInterpretSymbols = null)
        {
            WorkflowValue.Validate(sendKeyEventstext, nameof(sendKeyEventstext), required: true);
            WorkflowValue.Validate(sendKeyEventsworkflow, nameof(sendKeyEventsworkflow), required: true);
            WorkflowValue.Validate(sendKeyEventsinterval, nameof(sendKeyEventsinterval), required: false);
            WorkflowValue.Validate(sendKeyEventsisPassword, nameof(sendKeyEventsisPassword), required: false);
            WorkflowValue.Validate(sendKeyEventsdontInterpretSymbols, nameof(sendKeyEventsdontInterpretSymbols), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SendKeyEvents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendKeyEvents = new JObject();
                var sendKeyEventspropCount = 0;
                sendKeyEventspropCount++;
                sendKeyEvents["Text"] = ExpressionConverter.ConvertO(sendKeyEventstext);
                if (sendKeyEventsinterval != null)
                {
                    if (sendKeyEventsinterval != null)
                    {
                        sendKeyEvents["Interval"] = ExpressionConverter.ConvertO(sendKeyEventsinterval);
                        sendKeyEventspropCount++;
                    }

                    sendKeyEventspropCount++;
                }
                else
                {
                    sendKeyEvents["Interval"] = 10;
                    sendKeyEventspropCount++;
                }

                if (sendKeyEventsisPassword != null)
                {
                    if (sendKeyEventsisPassword != null)
                    {
                        sendKeyEvents["IsPassword"] = ExpressionConverter.ConvertO(sendKeyEventsisPassword);
                        sendKeyEventspropCount++;
                    }

                    sendKeyEventspropCount++;
                }
                else
                {
                    sendKeyEvents["IsPassword"] = false;
                    sendKeyEventspropCount++;
                }

                if (sendKeyEventsdontInterpretSymbols != null)
                {
                    if (sendKeyEventsdontInterpretSymbols != null)
                    {
                        sendKeyEvents["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sendKeyEventsdontInterpretSymbols);
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
                sendKeyEvents["Workflow"] = ExpressionConverter.ConvertO(sendKeyEventsworkflow);
                if (sendKeyEventspropCount > 0)
                {
                    callPayload.Body = sendKeyEvents;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSendPasswordKeyEvents))]
        public IWorkflowAction SendPasswordKeyEvents([WorkflowExpression] Func<string> sendPasswordKeyEventspassword, [WorkflowExpression] Func<string> sendPasswordKeyEventsworkflow, [WorkflowExpression] Func<int> sendPasswordKeyEventsinterval = null, [WorkflowExpression] Func<bool> sendPasswordKeyEventsdontInterpretSymbols = null, [WorkflowExpression] Func<bool> sendPasswordKeyEventspasswordContainsStoredPassword = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendPasswordKeyEvents(WorkflowValue<string> sendPasswordKeyEventspassword, WorkflowValue<string> sendPasswordKeyEventsworkflow, WorkflowValue<int> sendPasswordKeyEventsinterval = null, WorkflowValue<bool> sendPasswordKeyEventsdontInterpretSymbols = null, WorkflowValue<bool> sendPasswordKeyEventspasswordContainsStoredPassword = null)
        {
            WorkflowValue.Validate(sendPasswordKeyEventspassword, nameof(sendPasswordKeyEventspassword), required: true);
            WorkflowValue.Validate(sendPasswordKeyEventsworkflow, nameof(sendPasswordKeyEventsworkflow), required: true);
            WorkflowValue.Validate(sendPasswordKeyEventsinterval, nameof(sendPasswordKeyEventsinterval), required: false);
            WorkflowValue.Validate(sendPasswordKeyEventsdontInterpretSymbols, nameof(sendPasswordKeyEventsdontInterpretSymbols), required: false);
            WorkflowValue.Validate(sendPasswordKeyEventspasswordContainsStoredPassword, nameof(sendPasswordKeyEventspasswordContainsStoredPassword), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SendPasswordKeyEvents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendPasswordKeyEvents = new JObject();
                var sendPasswordKeyEventspropCount = 0;
                sendPasswordKeyEventspropCount++;
                sendPasswordKeyEvents["Password"] = ExpressionConverter.ConvertO(sendPasswordKeyEventspassword);
                if (sendPasswordKeyEventsinterval != null)
                {
                    if (sendPasswordKeyEventsinterval != null)
                    {
                        sendPasswordKeyEvents["Interval"] = ExpressionConverter.ConvertO(sendPasswordKeyEventsinterval);
                        sendPasswordKeyEventspropCount++;
                    }

                    sendPasswordKeyEventspropCount++;
                }
                else
                {
                    sendPasswordKeyEvents["Interval"] = 10;
                    sendPasswordKeyEventspropCount++;
                }

                if (sendPasswordKeyEventsdontInterpretSymbols != null)
                {
                    if (sendPasswordKeyEventsdontInterpretSymbols != null)
                    {
                        sendPasswordKeyEvents["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sendPasswordKeyEventsdontInterpretSymbols);
                        sendPasswordKeyEventspropCount++;
                    }

                    sendPasswordKeyEventspropCount++;
                }
                else
                {
                    sendPasswordKeyEvents["DontInterpretSymbols"] = false;
                    sendPasswordKeyEventspropCount++;
                }

                if (sendPasswordKeyEventspasswordContainsStoredPassword != null)
                {
                    if (sendPasswordKeyEventspasswordContainsStoredPassword != null)
                    {
                        sendPasswordKeyEvents["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(sendPasswordKeyEventspasswordContainsStoredPassword);
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
                sendPasswordKeyEvents["Workflow"] = ExpressionConverter.ConvertO(sendPasswordKeyEventsworkflow);
                if (sendPasswordKeyEventspropCount > 0)
                {
                    callPayload.Body = sendPasswordKeyEvents;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSendKeys))]
        public IWorkflowAction SendKeys([WorkflowExpression] Func<string> sendKeystext, [WorkflowExpression] Func<string> sendKeysworkflow, [WorkflowExpression] Func<int> sendKeysinterval = null, [WorkflowExpression] Func<bool> sendKeysisPassword = null, [WorkflowExpression] Func<bool> sendKeysdontInterpretSymbols = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendKeys(WorkflowValue<string> sendKeystext, WorkflowValue<string> sendKeysworkflow, WorkflowValue<int> sendKeysinterval = null, WorkflowValue<bool> sendKeysisPassword = null, WorkflowValue<bool> sendKeysdontInterpretSymbols = null)
        {
            WorkflowValue.Validate(sendKeystext, nameof(sendKeystext), required: true);
            WorkflowValue.Validate(sendKeysworkflow, nameof(sendKeysworkflow), required: true);
            WorkflowValue.Validate(sendKeysinterval, nameof(sendKeysinterval), required: false);
            WorkflowValue.Validate(sendKeysisPassword, nameof(sendKeysisPassword), required: false);
            WorkflowValue.Validate(sendKeysdontInterpretSymbols, nameof(sendKeysdontInterpretSymbols), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SendKeys";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendKeys = new JObject();
                var sendKeyspropCount = 0;
                sendKeyspropCount++;
                sendKeys["Text"] = ExpressionConverter.ConvertO(sendKeystext);
                if (sendKeysinterval != null)
                {
                    if (sendKeysinterval != null)
                    {
                        sendKeys["Interval"] = ExpressionConverter.ConvertO(sendKeysinterval);
                        sendKeyspropCount++;
                    }

                    sendKeyspropCount++;
                }
                else
                {
                    sendKeys["Interval"] = 10;
                    sendKeyspropCount++;
                }

                if (sendKeysisPassword != null)
                {
                    if (sendKeysisPassword != null)
                    {
                        sendKeys["IsPassword"] = ExpressionConverter.ConvertO(sendKeysisPassword);
                        sendKeyspropCount++;
                    }

                    sendKeyspropCount++;
                }
                else
                {
                    sendKeys["IsPassword"] = false;
                    sendKeyspropCount++;
                }

                if (sendKeysdontInterpretSymbols != null)
                {
                    if (sendKeysdontInterpretSymbols != null)
                    {
                        sendKeys["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sendKeysdontInterpretSymbols);
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
                sendKeys["Workflow"] = ExpressionConverter.ConvertO(sendKeysworkflow);
                if (sendKeyspropCount > 0)
                {
                    callPayload.Body = sendKeys;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSendPasswordKeys))]
        public IWorkflowAction SendPasswordKeys([WorkflowExpression] Func<string> sendPasswordKeyspassword, [WorkflowExpression] Func<string> sendPasswordKeysworkflow, [WorkflowExpression] Func<int> sendPasswordKeysinterval = null, [WorkflowExpression] Func<bool> sendPasswordKeysdontInterpretSymbols = null, [WorkflowExpression] Func<bool> sendPasswordKeyspasswordContainsStoredPassword = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendPasswordKeys(WorkflowValue<string> sendPasswordKeyspassword, WorkflowValue<string> sendPasswordKeysworkflow, WorkflowValue<int> sendPasswordKeysinterval = null, WorkflowValue<bool> sendPasswordKeysdontInterpretSymbols = null, WorkflowValue<bool> sendPasswordKeyspasswordContainsStoredPassword = null)
        {
            WorkflowValue.Validate(sendPasswordKeyspassword, nameof(sendPasswordKeyspassword), required: true);
            WorkflowValue.Validate(sendPasswordKeysworkflow, nameof(sendPasswordKeysworkflow), required: true);
            WorkflowValue.Validate(sendPasswordKeysinterval, nameof(sendPasswordKeysinterval), required: false);
            WorkflowValue.Validate(sendPasswordKeysdontInterpretSymbols, nameof(sendPasswordKeysdontInterpretSymbols), required: false);
            WorkflowValue.Validate(sendPasswordKeyspasswordContainsStoredPassword, nameof(sendPasswordKeyspasswordContainsStoredPassword), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SendPasswordKeys";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendPasswordKeys = new JObject();
                var sendPasswordKeyspropCount = 0;
                sendPasswordKeyspropCount++;
                sendPasswordKeys["Password"] = ExpressionConverter.ConvertO(sendPasswordKeyspassword);
                if (sendPasswordKeysinterval != null)
                {
                    if (sendPasswordKeysinterval != null)
                    {
                        sendPasswordKeys["Interval"] = ExpressionConverter.ConvertO(sendPasswordKeysinterval);
                        sendPasswordKeyspropCount++;
                    }

                    sendPasswordKeyspropCount++;
                }
                else
                {
                    sendPasswordKeys["Interval"] = 10;
                    sendPasswordKeyspropCount++;
                }

                if (sendPasswordKeysdontInterpretSymbols != null)
                {
                    if (sendPasswordKeysdontInterpretSymbols != null)
                    {
                        sendPasswordKeys["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sendPasswordKeysdontInterpretSymbols);
                        sendPasswordKeyspropCount++;
                    }

                    sendPasswordKeyspropCount++;
                }
                else
                {
                    sendPasswordKeys["DontInterpretSymbols"] = false;
                    sendPasswordKeyspropCount++;
                }

                if (sendPasswordKeyspasswordContainsStoredPassword != null)
                {
                    if (sendPasswordKeyspasswordContainsStoredPassword != null)
                    {
                        sendPasswordKeys["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(sendPasswordKeyspasswordContainsStoredPassword);
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
                sendPasswordKeys["Workflow"] = ExpressionConverter.ConvertO(sendPasswordKeysworkflow);
                if (sendPasswordKeyspropCount > 0)
                {
                    callPayload.Body = sendPasswordKeys;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildClearClipboard))]
        public IWorkflowAction ClearClipboard([WorkflowExpression] Func<string> clearClipboardworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildClearClipboard(WorkflowValue<string> clearClipboardworkflow)
        {
            WorkflowValue.Validate(clearClipboardworkflow, nameof(clearClipboardworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/ClearClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var clearClipboard = new JObject();
                var clearClipboardpropCount = 0;
                clearClipboardpropCount++;
                clearClipboard["Workflow"] = ExpressionConverter.ConvertO(clearClipboardworkflow);
                if (clearClipboardpropCount > 0)
                {
                    callPayload.Body = clearClipboard;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetClipboardData))]
        public IWorkflowAction SetClipboardData([WorkflowExpression] Func<string> setClipboardDataworkflow, [WorkflowExpression] Func<string> setClipboardDatanewClipboardData = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetClipboardData(WorkflowValue<string> setClipboardDataworkflow, WorkflowValue<string> setClipboardDatanewClipboardData = null)
        {
            WorkflowValue.Validate(setClipboardDataworkflow, nameof(setClipboardDataworkflow), required: true);
            WorkflowValue.Validate(setClipboardDatanewClipboardData, nameof(setClipboardDatanewClipboardData), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SetClipboardData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setClipboardData = new JObject();
                var setClipboardDatapropCount = 0;
                if (setClipboardDatanewClipboardData != null)
                {
                    setClipboardData["NewClipboardData"] = ExpressionConverter.ConvertO(setClipboardDatanewClipboardData);
                    setClipboardDatapropCount++;
                }

                setClipboardDatapropCount++;
                setClipboardData["Workflow"] = ExpressionConverter.ConvertO(setClipboardDataworkflow);
                if (setClipboardDatapropCount > 0)
                {
                    callPayload.Body = setClipboardData;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetClipboardData))]
        public IBodyWorkflowAction<GetClipboardDataResponse> GetClipboardData([WorkflowExpression] Func<string> getClipboardDataworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetClipboardDataResponse> __BuildGetClipboardData(WorkflowValue<string> getClipboardDataworkflow)
        {
            WorkflowValue.Validate(getClipboardDataworkflow, nameof(getClipboardDataworkflow), required: true);
            return new DeferredBodyAction<GetClipboardDataResponse>(() =>
            {
                var apiCallPath = "/Environment/GetClipboardData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getClipboardData = new JObject();
                var getClipboardDatapropCount = 0;
                getClipboardDatapropCount++;
                getClipboardData["Workflow"] = ExpressionConverter.ConvertO(getClipboardDataworkflow);
                if (getClipboardDatapropCount > 0)
                {
                    callPayload.Body = getClipboardData;
                }

                return new ApiConnectionAction<GetClipboardDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildTakeScreenshot))]
        public IBodyWorkflowAction<TakeScreenshotResponse> TakeScreenshot([WorkflowExpression] Func<string> takeScreenshotworkflow, [WorkflowExpression] Func<bool> takeScreenshotfullscreen = null, [WorkflowExpression] Func<int> takeScreenshotleftXPixels = null, [WorkflowExpression] Func<int> takeScreenshottopYPixels = null, [WorkflowExpression] Func<int> takeScreenshotwidthPixels = null, [WorkflowExpression] Func<int> takeScreenshotheightPixels = null, [WorkflowExpression] Func<takeScreenshotimageFormatInput> takeScreenshotimageFormat = null, [WorkflowExpression] Func<bool> takeScreenshotuseDisplayDevice = null, [WorkflowExpression] Func<bool> takeScreenshotraiseExceptionOnError = null, [WorkflowExpression] Func<bool> takeScreenshothideAgent = null, [WorkflowExpression] Func<bool> takeScreenshotusePhysicalCoordinates = null, [WorkflowExpression] Func<int> takeScreenshotdisplayDeviceId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TakeScreenshotResponse> __BuildTakeScreenshot(WorkflowValue<string> takeScreenshotworkflow, WorkflowValue<bool> takeScreenshotfullscreen = null, WorkflowValue<int> takeScreenshotleftXPixels = null, WorkflowValue<int> takeScreenshottopYPixels = null, WorkflowValue<int> takeScreenshotwidthPixels = null, WorkflowValue<int> takeScreenshotheightPixels = null, WorkflowValue<takeScreenshotimageFormatInput> takeScreenshotimageFormat = null, WorkflowValue<bool> takeScreenshotuseDisplayDevice = null, WorkflowValue<bool> takeScreenshotraiseExceptionOnError = null, WorkflowValue<bool> takeScreenshothideAgent = null, WorkflowValue<bool> takeScreenshotusePhysicalCoordinates = null, WorkflowValue<int> takeScreenshotdisplayDeviceId = null)
        {
            WorkflowValue.Validate(takeScreenshotworkflow, nameof(takeScreenshotworkflow), required: true);
            WorkflowValue.Validate(takeScreenshotfullscreen, nameof(takeScreenshotfullscreen), required: false);
            WorkflowValue.Validate(takeScreenshotleftXPixels, nameof(takeScreenshotleftXPixels), required: false);
            WorkflowValue.Validate(takeScreenshottopYPixels, nameof(takeScreenshottopYPixels), required: false);
            WorkflowValue.Validate(takeScreenshotwidthPixels, nameof(takeScreenshotwidthPixels), required: false);
            WorkflowValue.Validate(takeScreenshotheightPixels, nameof(takeScreenshotheightPixels), required: false);
            WorkflowValue.Validate(takeScreenshotimageFormat, nameof(takeScreenshotimageFormat), required: false);
            WorkflowValue.Validate(takeScreenshotuseDisplayDevice, nameof(takeScreenshotuseDisplayDevice), required: false);
            WorkflowValue.Validate(takeScreenshotraiseExceptionOnError, nameof(takeScreenshotraiseExceptionOnError), required: false);
            WorkflowValue.Validate(takeScreenshothideAgent, nameof(takeScreenshothideAgent), required: false);
            WorkflowValue.Validate(takeScreenshotusePhysicalCoordinates, nameof(takeScreenshotusePhysicalCoordinates), required: false);
            WorkflowValue.Validate(takeScreenshotdisplayDeviceId, nameof(takeScreenshotdisplayDeviceId), required: false);
            return new DeferredBodyAction<TakeScreenshotResponse>(() =>
            {
                var apiCallPath = "/Environment/TakeScreenshot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var takeScreenshot = new JObject();
                var takeScreenshotpropCount = 0;
                if (takeScreenshotfullscreen != null)
                {
                    if (takeScreenshotfullscreen != null)
                    {
                        takeScreenshot["Fullscreen"] = ExpressionConverter.ConvertO(takeScreenshotfullscreen);
                        takeScreenshotpropCount++;
                    }

                    takeScreenshotpropCount++;
                }
                else
                {
                    takeScreenshot["Fullscreen"] = true;
                    takeScreenshotpropCount++;
                }

                if (takeScreenshotleftXPixels != null)
                {
                    takeScreenshot["LeftXPixels"] = ExpressionConverter.ConvertO(takeScreenshotleftXPixels);
                    takeScreenshotpropCount++;
                }

                if (takeScreenshottopYPixels != null)
                {
                    takeScreenshot["TopYPixels"] = ExpressionConverter.ConvertO(takeScreenshottopYPixels);
                    takeScreenshotpropCount++;
                }

                if (takeScreenshotwidthPixels != null)
                {
                    takeScreenshot["WidthPixels"] = ExpressionConverter.ConvertO(takeScreenshotwidthPixels);
                    takeScreenshotpropCount++;
                }

                if (takeScreenshotheightPixels != null)
                {
                    takeScreenshot["HeightPixels"] = ExpressionConverter.ConvertO(takeScreenshotheightPixels);
                    takeScreenshotpropCount++;
                }

                if (takeScreenshotimageFormat != null)
                {
                    takeScreenshot["ImageFormat"] = ExpressionConverter.ConvertO(takeScreenshotimageFormat);
                    takeScreenshotpropCount++;
                }

                if (takeScreenshotuseDisplayDevice != null)
                {
                    if (takeScreenshotuseDisplayDevice != null)
                    {
                        takeScreenshot["UseDisplayDevice"] = ExpressionConverter.ConvertO(takeScreenshotuseDisplayDevice);
                        takeScreenshotpropCount++;
                    }

                    takeScreenshotpropCount++;
                }
                else
                {
                    takeScreenshot["UseDisplayDevice"] = false;
                    takeScreenshotpropCount++;
                }

                if (takeScreenshotraiseExceptionOnError != null)
                {
                    if (takeScreenshotraiseExceptionOnError != null)
                    {
                        takeScreenshot["RaiseExceptionOnError"] = ExpressionConverter.ConvertO(takeScreenshotraiseExceptionOnError);
                        takeScreenshotpropCount++;
                    }

                    takeScreenshotpropCount++;
                }
                else
                {
                    takeScreenshot["RaiseExceptionOnError"] = true;
                    takeScreenshotpropCount++;
                }

                if (takeScreenshothideAgent != null)
                {
                    if (takeScreenshothideAgent != null)
                    {
                        takeScreenshot["HideAgent"] = ExpressionConverter.ConvertO(takeScreenshothideAgent);
                        takeScreenshotpropCount++;
                    }

                    takeScreenshotpropCount++;
                }
                else
                {
                    takeScreenshot["HideAgent"] = false;
                    takeScreenshotpropCount++;
                }

                if (takeScreenshotusePhysicalCoordinates != null)
                {
                    if (takeScreenshotusePhysicalCoordinates != null)
                    {
                        takeScreenshot["UsePhysicalCoordinates"] = ExpressionConverter.ConvertO(takeScreenshotusePhysicalCoordinates);
                        takeScreenshotpropCount++;
                    }

                    takeScreenshotpropCount++;
                }
                else
                {
                    takeScreenshot["UsePhysicalCoordinates"] = false;
                    takeScreenshotpropCount++;
                }

                if (takeScreenshotdisplayDeviceId != null)
                {
                    takeScreenshot["DisplayDeviceId"] = ExpressionConverter.ConvertO(takeScreenshotdisplayDeviceId);
                    takeScreenshotpropCount++;
                }

                takeScreenshotpropCount++;
                takeScreenshot["Workflow"] = ExpressionConverter.ConvertO(takeScreenshotworkflow);
                if (takeScreenshotpropCount > 0)
                {
                    callPayload.Body = takeScreenshot;
                }

                return new ApiConnectionAction<TakeScreenshotResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetEnvironmentInfo))]
        public IBodyWorkflowAction<GetEnvironmentInfoResponse> GetEnvironmentInfo([WorkflowExpression] Func<string> getEnvironmentInfoworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEnvironmentInfoResponse> __BuildGetEnvironmentInfo(WorkflowValue<string> getEnvironmentInfoworkflow)
        {
            WorkflowValue.Validate(getEnvironmentInfoworkflow, nameof(getEnvironmentInfoworkflow), required: true);
            return new DeferredBodyAction<GetEnvironmentInfoResponse>(() =>
            {
                var apiCallPath = "/Environment/GetEnvironmentInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getEnvironmentInfo = new JObject();
                var getEnvironmentInfopropCount = 0;
                getEnvironmentInfopropCount++;
                getEnvironmentInfo["Workflow"] = ExpressionConverter.ConvertO(getEnvironmentInfoworkflow);
                if (getEnvironmentInfopropCount > 0)
                {
                    callPayload.Body = getEnvironmentInfo;
                }

                return new ApiConnectionAction<GetEnvironmentInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildIsScreenReaderEnabled))]
        public IBodyWorkflowAction<IsScreenReaderEnabledResponse> IsScreenReaderEnabled([WorkflowExpression] Func<string> isScreenReaderEnabledworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsScreenReaderEnabledResponse> __BuildIsScreenReaderEnabled(WorkflowValue<string> isScreenReaderEnabledworkflow)
        {
            WorkflowValue.Validate(isScreenReaderEnabledworkflow, nameof(isScreenReaderEnabledworkflow), required: true);
            return new DeferredBodyAction<IsScreenReaderEnabledResponse>(() =>
            {
                var apiCallPath = "/Environment/IsScreenReaderEnabled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isScreenReaderEnabled = new JObject();
                var isScreenReaderEnabledpropCount = 0;
                isScreenReaderEnabledpropCount++;
                isScreenReaderEnabled["Workflow"] = ExpressionConverter.ConvertO(isScreenReaderEnabledworkflow);
                if (isScreenReaderEnabledpropCount > 0)
                {
                    callPayload.Body = isScreenReaderEnabled;
                }

                return new ApiConnectionAction<IsScreenReaderEnabledResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetScreenReader))]
        public IWorkflowAction SetScreenReader([WorkflowExpression] Func<string> setScreenReaderworkflow, [WorkflowExpression] Func<bool> setScreenReaderenableScreenReader = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetScreenReader(WorkflowValue<string> setScreenReaderworkflow, WorkflowValue<bool> setScreenReaderenableScreenReader = null)
        {
            WorkflowValue.Validate(setScreenReaderworkflow, nameof(setScreenReaderworkflow), required: true);
            WorkflowValue.Validate(setScreenReaderenableScreenReader, nameof(setScreenReaderenableScreenReader), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Environment/SetScreenReader";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setScreenReader = new JObject();
                var setScreenReaderpropCount = 0;
                if (setScreenReaderenableScreenReader != null)
                {
                    if (setScreenReaderenableScreenReader != null)
                    {
                        setScreenReader["EnableScreenReader"] = ExpressionConverter.ConvertO(setScreenReaderenableScreenReader);
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
                setScreenReader["Workflow"] = ExpressionConverter.ConvertO(setScreenReaderworkflow);
                if (setScreenReaderpropCount > 0)
                {
                    callPayload.Body = setScreenReader;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetParentProcessId))]
        public IBodyWorkflowAction<GetParentProcessIdResponse> GetParentProcessId([WorkflowExpression] Func<int> getParentProcessIdprocessId, [WorkflowExpression] Func<string> getParentProcessIdworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetParentProcessIdResponse> __BuildGetParentProcessId(WorkflowValue<int> getParentProcessIdprocessId, WorkflowValue<string> getParentProcessIdworkflow)
        {
            WorkflowValue.Validate(getParentProcessIdprocessId, nameof(getParentProcessIdprocessId), required: true);
            WorkflowValue.Validate(getParentProcessIdworkflow, nameof(getParentProcessIdworkflow), required: true);
            return new DeferredBodyAction<GetParentProcessIdResponse>(() =>
            {
                var apiCallPath = "/Environment/GetParentProcessId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getParentProcessId = new JObject();
                var getParentProcessIdpropCount = 0;
                getParentProcessIdpropCount++;
                getParentProcessId["ProcessId"] = ExpressionConverter.ConvertO(getParentProcessIdprocessId);
                getParentProcessIdpropCount++;
                getParentProcessId["Workflow"] = ExpressionConverter.ConvertO(getParentProcessIdworkflow);
                if (getParentProcessIdpropCount > 0)
                {
                    callPayload.Body = getParentProcessId;
                }

                return new ApiConnectionAction<GetParentProcessIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetProcessIdCommandLine))]
        public IBodyWorkflowAction<GetProcessIdCommandLineResponse> GetProcessIdCommandLine([WorkflowExpression] Func<int> getProcessIdCommandLineprocessId, [WorkflowExpression] Func<string> getProcessIdCommandLineworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProcessIdCommandLineResponse> __BuildGetProcessIdCommandLine(WorkflowValue<int> getProcessIdCommandLineprocessId, WorkflowValue<string> getProcessIdCommandLineworkflow)
        {
            WorkflowValue.Validate(getProcessIdCommandLineprocessId, nameof(getProcessIdCommandLineprocessId), required: true);
            WorkflowValue.Validate(getProcessIdCommandLineworkflow, nameof(getProcessIdCommandLineworkflow), required: true);
            return new DeferredBodyAction<GetProcessIdCommandLineResponse>(() =>
            {
                var apiCallPath = "/Environment/GetProcessIdCommandLine";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getProcessIdCommandLine = new JObject();
                var getProcessIdCommandLinepropCount = 0;
                getProcessIdCommandLinepropCount++;
                getProcessIdCommandLine["ProcessId"] = ExpressionConverter.ConvertO(getProcessIdCommandLineprocessId);
                getProcessIdCommandLinepropCount++;
                getProcessIdCommandLine["Workflow"] = ExpressionConverter.ConvertO(getProcessIdCommandLineworkflow);
                if (getProcessIdCommandLinepropCount > 0)
                {
                    callPayload.Body = getProcessIdCommandLine;
                }

                return new ApiConnectionAction<GetProcessIdCommandLineResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetLastInputInfo))]
        public IBodyWorkflowAction<GetLastInputInfoResponse> GetLastInputInfo([WorkflowExpression] Func<string> getLastInputInfoworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLastInputInfoResponse> __BuildGetLastInputInfo(WorkflowValue<string> getLastInputInfoworkflow)
        {
            WorkflowValue.Validate(getLastInputInfoworkflow, nameof(getLastInputInfoworkflow), required: true);
            return new DeferredBodyAction<GetLastInputInfoResponse>(() =>
            {
                var apiCallPath = "/Environment/GetLastInputInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getLastInputInfo = new JObject();
                var getLastInputInfopropCount = 0;
                getLastInputInfopropCount++;
                getLastInputInfo["Workflow"] = ExpressionConverter.ConvertO(getLastInputInfoworkflow);
                if (getLastInputInfopropCount > 0)
                {
                    callPayload.Body = getLastInputInfo;
                }

                return new ApiConnectionAction<GetLastInputInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildKeepSessionAlive))]
        public IBodyWorkflowAction<KeepSessionAliveResponse> KeepSessionAlive([WorkflowExpression] Func<string> keepSessionAliveworkflow, [WorkflowExpression] Func<int> keepSessionAlivexWiggle = null, [WorkflowExpression] Func<int> keepSessionAliveyWiggle = null, [WorkflowExpression] Func<double> keepSessionAlivewiggleDelayInSeconds = null, [WorkflowExpression] Func<int> keepSessionAliveidleThresholdInSeconds = null, [WorkflowExpression] Func<int> keepSessionAliveidleCheckPeriodInSeconds = null, [WorkflowExpression] Func<int> keepSessionAlivetotalKeepaliveRuntimeInSeconds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KeepSessionAliveResponse> __BuildKeepSessionAlive(WorkflowValue<string> keepSessionAliveworkflow, WorkflowValue<int> keepSessionAlivexWiggle = null, WorkflowValue<int> keepSessionAliveyWiggle = null, WorkflowValue<double> keepSessionAlivewiggleDelayInSeconds = null, WorkflowValue<int> keepSessionAliveidleThresholdInSeconds = null, WorkflowValue<int> keepSessionAliveidleCheckPeriodInSeconds = null, WorkflowValue<int> keepSessionAlivetotalKeepaliveRuntimeInSeconds = null)
        {
            WorkflowValue.Validate(keepSessionAliveworkflow, nameof(keepSessionAliveworkflow), required: true);
            WorkflowValue.Validate(keepSessionAlivexWiggle, nameof(keepSessionAlivexWiggle), required: false);
            WorkflowValue.Validate(keepSessionAliveyWiggle, nameof(keepSessionAliveyWiggle), required: false);
            WorkflowValue.Validate(keepSessionAlivewiggleDelayInSeconds, nameof(keepSessionAlivewiggleDelayInSeconds), required: false);
            WorkflowValue.Validate(keepSessionAliveidleThresholdInSeconds, nameof(keepSessionAliveidleThresholdInSeconds), required: false);
            WorkflowValue.Validate(keepSessionAliveidleCheckPeriodInSeconds, nameof(keepSessionAliveidleCheckPeriodInSeconds), required: false);
            WorkflowValue.Validate(keepSessionAlivetotalKeepaliveRuntimeInSeconds, nameof(keepSessionAlivetotalKeepaliveRuntimeInSeconds), required: false);
            return new DeferredBodyAction<KeepSessionAliveResponse>(() =>
            {
                var apiCallPath = "/Environment/KeepSessionAlive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var keepSessionAlive = new JObject();
                var keepSessionAlivepropCount = 0;
                if (keepSessionAlivexWiggle != null)
                {
                    if (keepSessionAlivexWiggle != null)
                    {
                        keepSessionAlive["XWiggle"] = ExpressionConverter.ConvertO(keepSessionAlivexWiggle);
                        keepSessionAlivepropCount++;
                    }

                    keepSessionAlivepropCount++;
                }
                else
                {
                    keepSessionAlive["XWiggle"] = 2;
                    keepSessionAlivepropCount++;
                }

                if (keepSessionAliveyWiggle != null)
                {
                    keepSessionAlive["YWiggle"] = ExpressionConverter.ConvertO(keepSessionAliveyWiggle);
                    keepSessionAlivepropCount++;
                }

                if (keepSessionAlivewiggleDelayInSeconds != null)
                {
                    if (keepSessionAlivewiggleDelayInSeconds != null)
                    {
                        keepSessionAlive["WiggleDelayInSeconds"] = ExpressionConverter.ConvertO(keepSessionAlivewiggleDelayInSeconds);
                        keepSessionAlivepropCount++;
                    }

                    keepSessionAlivepropCount++;
                }
                else
                {
                    keepSessionAlive["WiggleDelayInSeconds"] = 0.1;
                    keepSessionAlivepropCount++;
                }

                if (keepSessionAliveidleThresholdInSeconds != null)
                {
                    if (keepSessionAliveidleThresholdInSeconds != null)
                    {
                        keepSessionAlive["IdleThresholdInSeconds"] = ExpressionConverter.ConvertO(keepSessionAliveidleThresholdInSeconds);
                        keepSessionAlivepropCount++;
                    }

                    keepSessionAlivepropCount++;
                }
                else
                {
                    keepSessionAlive["IdleThresholdInSeconds"] = 120;
                    keepSessionAlivepropCount++;
                }

                if (keepSessionAliveidleCheckPeriodInSeconds != null)
                {
                    if (keepSessionAliveidleCheckPeriodInSeconds != null)
                    {
                        keepSessionAlive["IdleCheckPeriodInSeconds"] = ExpressionConverter.ConvertO(keepSessionAliveidleCheckPeriodInSeconds);
                        keepSessionAlivepropCount++;
                    }

                    keepSessionAlivepropCount++;
                }
                else
                {
                    keepSessionAlive["IdleCheckPeriodInSeconds"] = 30;
                    keepSessionAlivepropCount++;
                }

                if (keepSessionAlivetotalKeepaliveRuntimeInSeconds != null)
                {
                    if (keepSessionAlivetotalKeepaliveRuntimeInSeconds != null)
                    {
                        keepSessionAlive["TotalKeepaliveRuntimeInSeconds"] = ExpressionConverter.ConvertO(keepSessionAlivetotalKeepaliveRuntimeInSeconds);
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
                keepSessionAlive["Workflow"] = ExpressionConverter.ConvertO(keepSessionAliveworkflow);
                if (keepSessionAlivepropCount > 0)
                {
                    callPayload.Body = keepSessionAlive;
                }

                return new ApiConnectionAction<KeepSessionAliveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildStopKeepSessionAlive))]
        public IBodyWorkflowAction<StopKeepSessionAliveResponse> StopKeepSessionAlive([WorkflowExpression] Func<string> stopKeepSessionAliveworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StopKeepSessionAliveResponse> __BuildStopKeepSessionAlive(WorkflowValue<string> stopKeepSessionAliveworkflow)
        {
            WorkflowValue.Validate(stopKeepSessionAliveworkflow, nameof(stopKeepSessionAliveworkflow), required: true);
            return new DeferredBodyAction<StopKeepSessionAliveResponse>(() =>
            {
                var apiCallPath = "/Environment/StopKeepSessionAlive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var stopKeepSessionAlive = new JObject();
                var stopKeepSessionAlivepropCount = 0;
                stopKeepSessionAlivepropCount++;
                stopKeepSessionAlive["Workflow"] = ExpressionConverter.ConvertO(stopKeepSessionAliveworkflow);
                if (stopKeepSessionAlivepropCount > 0)
                {
                    callPayload.Body = stopKeepSessionAlive;
                }

                return new ApiConnectionAction<StopKeepSessionAliveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildCopyFileToClipboard))]
        public IBodyWorkflowAction<CopyFileToClipboardResponse> CopyFileToClipboard([WorkflowExpression] Func<string> copyFileToClipboardfilepath, [WorkflowExpression] Func<string> copyFileToClipboardworkflow, [WorkflowExpression] Func<bool> copyFileToClipboardcut = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CopyFileToClipboardResponse> __BuildCopyFileToClipboard(WorkflowValue<string> copyFileToClipboardfilepath, WorkflowValue<string> copyFileToClipboardworkflow, WorkflowValue<bool> copyFileToClipboardcut = null)
        {
            WorkflowValue.Validate(copyFileToClipboardfilepath, nameof(copyFileToClipboardfilepath), required: true);
            WorkflowValue.Validate(copyFileToClipboardworkflow, nameof(copyFileToClipboardworkflow), required: true);
            WorkflowValue.Validate(copyFileToClipboardcut, nameof(copyFileToClipboardcut), required: false);
            return new DeferredBodyAction<CopyFileToClipboardResponse>(() =>
            {
                var apiCallPath = "/Environment/CopyFileToClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var copyFileToClipboard = new JObject();
                var copyFileToClipboardpropCount = 0;
                copyFileToClipboardpropCount++;
                copyFileToClipboard["Filepath"] = ExpressionConverter.ConvertO(copyFileToClipboardfilepath);
                if (copyFileToClipboardcut != null)
                {
                    if (copyFileToClipboardcut != null)
                    {
                        copyFileToClipboard["Cut"] = ExpressionConverter.ConvertO(copyFileToClipboardcut);
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
                copyFileToClipboard["Workflow"] = ExpressionConverter.ConvertO(copyFileToClipboardworkflow);
                if (copyFileToClipboardpropCount > 0)
                {
                    callPayload.Body = copyFileToClipboard;
                }

                return new ApiConnectionAction<CopyFileToClipboardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetRemoteSessionInfo))]
        public IBodyWorkflowAction<GetRemoteSessionInfoResponse> GetRemoteSessionInfo([WorkflowExpression] Func<string> getRemoteSessionInfoworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRemoteSessionInfoResponse> __BuildGetRemoteSessionInfo(WorkflowValue<string> getRemoteSessionInfoworkflow)
        {
            WorkflowValue.Validate(getRemoteSessionInfoworkflow, nameof(getRemoteSessionInfoworkflow), required: true);
            return new DeferredBodyAction<GetRemoteSessionInfoResponse>(() =>
            {
                var apiCallPath = "/Environment/GetRemoteSessionInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRemoteSessionInfo = new JObject();
                var getRemoteSessionInfopropCount = 0;
                getRemoteSessionInfopropCount++;
                getRemoteSessionInfo["Workflow"] = ExpressionConverter.ConvertO(getRemoteSessionInfoworkflow);
                if (getRemoteSessionInfopropCount > 0)
                {
                    callPayload.Body = getRemoteSessionInfo;
                }

                return new ApiConnectionAction<GetRemoteSessionInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGeneratePassword))]
        public IBodyWorkflowAction<GeneratePasswordResponse> GeneratePassword([WorkflowExpression] Func<string> generatePasswordpasswordFormat, [WorkflowExpression] Func<string> generatePasswordworkflow, [WorkflowExpression] Func<int> generatePasswordminimumLength = null, [WorkflowExpression] Func<bool> generatePasswordreturnAsPlainText = null, [WorkflowExpression] Func<string> generatePasswordstorePasswordAsIdentifier = null, [WorkflowExpression] Func<string> generatePasswordsupportedSymbols = null, [WorkflowExpression] Func<bool> generatePasswordattemptUniquePasswords = null, [WorkflowExpression] Func<generatePasswordgenerateAtInput> generatePasswordgenerateAt = null, [WorkflowExpression] Func<int> generatePasswordminimumLowercase = null, [WorkflowExpression] Func<int> generatePasswordminimumUppercase = null, [WorkflowExpression] Func<int> generatePasswordminimumNumbers = null, [WorkflowExpression] Func<int> generatePasswordminimumSymbols = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GeneratePasswordResponse> __BuildGeneratePassword(WorkflowValue<string> generatePasswordpasswordFormat, WorkflowValue<string> generatePasswordworkflow, WorkflowValue<int> generatePasswordminimumLength = null, WorkflowValue<bool> generatePasswordreturnAsPlainText = null, WorkflowValue<string> generatePasswordstorePasswordAsIdentifier = null, WorkflowValue<string> generatePasswordsupportedSymbols = null, WorkflowValue<bool> generatePasswordattemptUniquePasswords = null, WorkflowValue<generatePasswordgenerateAtInput> generatePasswordgenerateAt = null, WorkflowValue<int> generatePasswordminimumLowercase = null, WorkflowValue<int> generatePasswordminimumUppercase = null, WorkflowValue<int> generatePasswordminimumNumbers = null, WorkflowValue<int> generatePasswordminimumSymbols = null)
        {
            WorkflowValue.Validate(generatePasswordpasswordFormat, nameof(generatePasswordpasswordFormat), required: true);
            WorkflowValue.Validate(generatePasswordworkflow, nameof(generatePasswordworkflow), required: true);
            WorkflowValue.Validate(generatePasswordminimumLength, nameof(generatePasswordminimumLength), required: false);
            WorkflowValue.Validate(generatePasswordreturnAsPlainText, nameof(generatePasswordreturnAsPlainText), required: false);
            WorkflowValue.Validate(generatePasswordstorePasswordAsIdentifier, nameof(generatePasswordstorePasswordAsIdentifier), required: false);
            WorkflowValue.Validate(generatePasswordsupportedSymbols, nameof(generatePasswordsupportedSymbols), required: false);
            WorkflowValue.Validate(generatePasswordattemptUniquePasswords, nameof(generatePasswordattemptUniquePasswords), required: false);
            WorkflowValue.Validate(generatePasswordgenerateAt, nameof(generatePasswordgenerateAt), required: false);
            WorkflowValue.Validate(generatePasswordminimumLowercase, nameof(generatePasswordminimumLowercase), required: false);
            WorkflowValue.Validate(generatePasswordminimumUppercase, nameof(generatePasswordminimumUppercase), required: false);
            WorkflowValue.Validate(generatePasswordminimumNumbers, nameof(generatePasswordminimumNumbers), required: false);
            WorkflowValue.Validate(generatePasswordminimumSymbols, nameof(generatePasswordminimumSymbols), required: false);
            return new DeferredBodyAction<GeneratePasswordResponse>(() =>
            {
                var apiCallPath = "/Environment/GeneratePassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var generatePassword = new JObject();
                var generatePasswordpropCount = 0;
                generatePasswordpropCount++;
                generatePassword["PasswordFormat"] = ExpressionConverter.ConvertO(generatePasswordpasswordFormat);
                if (generatePasswordminimumLength != null)
                {
                    generatePassword["MinimumLength"] = ExpressionConverter.ConvertO(generatePasswordminimumLength);
                    generatePasswordpropCount++;
                }

                if (generatePasswordreturnAsPlainText != null)
                {
                    if (generatePasswordreturnAsPlainText != null)
                    {
                        generatePassword["ReturnAsPlainText"] = ExpressionConverter.ConvertO(generatePasswordreturnAsPlainText);
                        generatePasswordpropCount++;
                    }

                    generatePasswordpropCount++;
                }
                else
                {
                    generatePassword["ReturnAsPlainText"] = false;
                    generatePasswordpropCount++;
                }

                if (generatePasswordstorePasswordAsIdentifier != null)
                {
                    generatePassword["StorePasswordAsIdentifier"] = ExpressionConverter.ConvertO(generatePasswordstorePasswordAsIdentifier);
                    generatePasswordpropCount++;
                }

                if (generatePasswordsupportedSymbols != null)
                {
                    generatePassword["SupportedSymbols"] = ExpressionConverter.ConvertO(generatePasswordsupportedSymbols);
                    generatePasswordpropCount++;
                }

                if (generatePasswordattemptUniquePasswords != null)
                {
                    if (generatePasswordattemptUniquePasswords != null)
                    {
                        generatePassword["AttemptUniquePasswords"] = ExpressionConverter.ConvertO(generatePasswordattemptUniquePasswords);
                        generatePasswordpropCount++;
                    }

                    generatePasswordpropCount++;
                }
                else
                {
                    generatePassword["AttemptUniquePasswords"] = true;
                    generatePasswordpropCount++;
                }

                if (generatePasswordgenerateAt != null)
                {
                    if (generatePasswordgenerateAt != null)
                    {
                        generatePassword["GenerateAt"] = ExpressionConverter.ConvertO(generatePasswordgenerateAt);
                        generatePasswordpropCount++;
                    }

                    generatePasswordpropCount++;
                }
                else
                {
                    generatePassword["GenerateAt"] = "Agent";
                    generatePasswordpropCount++;
                }

                if (generatePasswordminimumLowercase != null)
                {
                    if (generatePasswordminimumLowercase != null)
                    {
                        generatePassword["MinimumLowercase"] = ExpressionConverter.ConvertO(generatePasswordminimumLowercase);
                        generatePasswordpropCount++;
                    }

                    generatePasswordpropCount++;
                }
                else
                {
                    generatePassword["MinimumLowercase"] = 0;
                    generatePasswordpropCount++;
                }

                if (generatePasswordminimumUppercase != null)
                {
                    if (generatePasswordminimumUppercase != null)
                    {
                        generatePassword["MinimumUppercase"] = ExpressionConverter.ConvertO(generatePasswordminimumUppercase);
                        generatePasswordpropCount++;
                    }

                    generatePasswordpropCount++;
                }
                else
                {
                    generatePassword["MinimumUppercase"] = 0;
                    generatePasswordpropCount++;
                }

                if (generatePasswordminimumNumbers != null)
                {
                    if (generatePasswordminimumNumbers != null)
                    {
                        generatePassword["MinimumNumbers"] = ExpressionConverter.ConvertO(generatePasswordminimumNumbers);
                        generatePasswordpropCount++;
                    }

                    generatePasswordpropCount++;
                }
                else
                {
                    generatePassword["MinimumNumbers"] = 0;
                    generatePasswordpropCount++;
                }

                if (generatePasswordminimumSymbols != null)
                {
                    if (generatePasswordminimumSymbols != null)
                    {
                        generatePassword["MinimumSymbols"] = ExpressionConverter.ConvertO(generatePasswordminimumSymbols);
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
                generatePassword["Workflow"] = ExpressionConverter.ConvertO(generatePasswordworkflow);
                if (generatePasswordpropCount > 0)
                {
                    callPayload.Body = generatePassword;
                }

                return new ApiConnectionAction<GeneratePasswordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetStoredPassword))]
        public IBodyWorkflowAction<GetStoredPasswordResponse> GetStoredPassword([WorkflowExpression] Func<string> getStoredPasswordworkflow, [WorkflowExpression] Func<string> getStoredPasswordpasswordIdentifier = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStoredPasswordResponse> __BuildGetStoredPassword(WorkflowValue<string> getStoredPasswordworkflow, WorkflowValue<string> getStoredPasswordpasswordIdentifier = null)
        {
            WorkflowValue.Validate(getStoredPasswordworkflow, nameof(getStoredPasswordworkflow), required: true);
            WorkflowValue.Validate(getStoredPasswordpasswordIdentifier, nameof(getStoredPasswordpasswordIdentifier), required: false);
            return new DeferredBodyAction<GetStoredPasswordResponse>(() =>
            {
                var apiCallPath = "/Environment/GetStoredPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getStoredPassword = new JObject();
                var getStoredPasswordpropCount = 0;
                if (getStoredPasswordpasswordIdentifier != null)
                {
                    getStoredPassword["PasswordIdentifier"] = ExpressionConverter.ConvertO(getStoredPasswordpasswordIdentifier);
                    getStoredPasswordpropCount++;
                }

                getStoredPasswordpropCount++;
                getStoredPassword["Workflow"] = ExpressionConverter.ConvertO(getStoredPasswordworkflow);
                if (getStoredPasswordpropCount > 0)
                {
                    callPayload.Body = getStoredPassword;
                }

                return new ApiConnectionAction<GetStoredPasswordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildExpandPasswordString))]
        public IBodyWorkflowAction<ExpandPasswordStringResponse> ExpandPasswordString([WorkflowExpression] Func<string> expandPasswordStringworkflow, [WorkflowExpression] Func<string> expandPasswordStringinputString = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExpandPasswordStringResponse> __BuildExpandPasswordString(WorkflowValue<string> expandPasswordStringworkflow, WorkflowValue<string> expandPasswordStringinputString = null)
        {
            WorkflowValue.Validate(expandPasswordStringworkflow, nameof(expandPasswordStringworkflow), required: true);
            WorkflowValue.Validate(expandPasswordStringinputString, nameof(expandPasswordStringinputString), required: false);
            return new DeferredBodyAction<ExpandPasswordStringResponse>(() =>
            {
                var apiCallPath = "/Environment/ExpandPasswordString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var expandPasswordString = new JObject();
                var expandPasswordStringpropCount = 0;
                if (expandPasswordStringinputString != null)
                {
                    expandPasswordString["InputString"] = ExpressionConverter.ConvertO(expandPasswordStringinputString);
                    expandPasswordStringpropCount++;
                }

                expandPasswordStringpropCount++;
                expandPasswordString["Workflow"] = ExpressionConverter.ConvertO(expandPasswordStringworkflow);
                if (expandPasswordStringpropCount > 0)
                {
                    callPayload.Body = expandPasswordString;
                }

                return new ApiConnectionAction<ExpandPasswordStringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildStorePasswordInAgentMemory))]
        public IBodyWorkflowAction<StorePasswordInAgentMemoryResponse> StorePasswordInAgentMemory([WorkflowExpression] Func<string> storePasswordInAgentMemoryidentifier, [WorkflowExpression] Func<string> storePasswordInAgentMemorypassword, [WorkflowExpression] Func<string> storePasswordInAgentMemoryworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StorePasswordInAgentMemoryResponse> __BuildStorePasswordInAgentMemory(WorkflowValue<string> storePasswordInAgentMemoryidentifier, WorkflowValue<string> storePasswordInAgentMemorypassword, WorkflowValue<string> storePasswordInAgentMemoryworkflow)
        {
            WorkflowValue.Validate(storePasswordInAgentMemoryidentifier, nameof(storePasswordInAgentMemoryidentifier), required: true);
            WorkflowValue.Validate(storePasswordInAgentMemorypassword, nameof(storePasswordInAgentMemorypassword), required: true);
            WorkflowValue.Validate(storePasswordInAgentMemoryworkflow, nameof(storePasswordInAgentMemoryworkflow), required: true);
            return new DeferredBodyAction<StorePasswordInAgentMemoryResponse>(() =>
            {
                var apiCallPath = "/Environment/StorePasswordInAgentMemory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var storePasswordInAgentMemory = new JObject();
                var storePasswordInAgentMemorypropCount = 0;
                storePasswordInAgentMemorypropCount++;
                storePasswordInAgentMemory["Identifier"] = ExpressionConverter.ConvertO(storePasswordInAgentMemoryidentifier);
                storePasswordInAgentMemorypropCount++;
                storePasswordInAgentMemory["Password"] = ExpressionConverter.ConvertO(storePasswordInAgentMemorypassword);
                storePasswordInAgentMemorypropCount++;
                storePasswordInAgentMemory["Workflow"] = ExpressionConverter.ConvertO(storePasswordInAgentMemoryworkflow);
                if (storePasswordInAgentMemorypropCount > 0)
                {
                    callPayload.Body = storePasswordInAgentMemory;
                }

                return new ApiConnectionAction<StorePasswordInAgentMemoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildDeletePasswordInAgentMemory))]
        public IBodyWorkflowAction<DeletePasswordInAgentMemoryResponse> DeletePasswordInAgentMemory([WorkflowExpression] Func<string> deletePasswordInAgentMemoryworkflow, [WorkflowExpression] Func<bool> deletePasswordInAgentMemorydeleteAllPasswords = null, [WorkflowExpression] Func<string> deletePasswordInAgentMemoryidentifier = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeletePasswordInAgentMemoryResponse> __BuildDeletePasswordInAgentMemory(WorkflowValue<string> deletePasswordInAgentMemoryworkflow, WorkflowValue<bool> deletePasswordInAgentMemorydeleteAllPasswords = null, WorkflowValue<string> deletePasswordInAgentMemoryidentifier = null)
        {
            WorkflowValue.Validate(deletePasswordInAgentMemoryworkflow, nameof(deletePasswordInAgentMemoryworkflow), required: true);
            WorkflowValue.Validate(deletePasswordInAgentMemorydeleteAllPasswords, nameof(deletePasswordInAgentMemorydeleteAllPasswords), required: false);
            WorkflowValue.Validate(deletePasswordInAgentMemoryidentifier, nameof(deletePasswordInAgentMemoryidentifier), required: false);
            return new DeferredBodyAction<DeletePasswordInAgentMemoryResponse>(() =>
            {
                var apiCallPath = "/Environment/DeletePasswordInAgentMemory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deletePasswordInAgentMemory = new JObject();
                var deletePasswordInAgentMemorypropCount = 0;
                if (deletePasswordInAgentMemorydeleteAllPasswords != null)
                {
                    if (deletePasswordInAgentMemorydeleteAllPasswords != null)
                    {
                        deletePasswordInAgentMemory["DeleteAllPasswords"] = ExpressionConverter.ConvertO(deletePasswordInAgentMemorydeleteAllPasswords);
                        deletePasswordInAgentMemorypropCount++;
                    }

                    deletePasswordInAgentMemorypropCount++;
                }
                else
                {
                    deletePasswordInAgentMemory["DeleteAllPasswords"] = false;
                    deletePasswordInAgentMemorypropCount++;
                }

                if (deletePasswordInAgentMemoryidentifier != null)
                {
                    deletePasswordInAgentMemory["Identifier"] = ExpressionConverter.ConvertO(deletePasswordInAgentMemoryidentifier);
                    deletePasswordInAgentMemorypropCount++;
                }

                deletePasswordInAgentMemorypropCount++;
                deletePasswordInAgentMemory["Workflow"] = ExpressionConverter.ConvertO(deletePasswordInAgentMemoryworkflow);
                if (deletePasswordInAgentMemorypropCount > 0)
                {
                    callPayload.Body = deletePasswordInAgentMemory;
                }

                return new ApiConnectionAction<DeletePasswordInAgentMemoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildCredentialWrite))]
        public IBodyWorkflowAction<CredentialWriteResponse> CredentialWrite([WorkflowExpression] Func<string> credentialWritecredentialAddress, [WorkflowExpression] Func<string> credentialWriteuserName, [WorkflowExpression] Func<string> credentialWritepassword, [WorkflowExpression] Func<credentialWritecredentialTypeInput> credentialWritecredentialType, [WorkflowExpression] Func<string> credentialWriteworkflow, [WorkflowExpression] Func<credentialWritecredentialPersistenceInput> credentialWritecredentialPersistence = null, [WorkflowExpression] Func<string> credentialWritesymmetricKey = null, [WorkflowExpression] Func<string> credentialWritestorePasswordAsIdentifier = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CredentialWriteResponse> __BuildCredentialWrite(WorkflowValue<string> credentialWritecredentialAddress, WorkflowValue<string> credentialWriteuserName, WorkflowValue<string> credentialWritepassword, WorkflowValue<credentialWritecredentialTypeInput> credentialWritecredentialType, WorkflowValue<string> credentialWriteworkflow, WorkflowValue<credentialWritecredentialPersistenceInput> credentialWritecredentialPersistence = null, WorkflowValue<string> credentialWritesymmetricKey = null, WorkflowValue<string> credentialWritestorePasswordAsIdentifier = null)
        {
            WorkflowValue.Validate(credentialWritecredentialAddress, nameof(credentialWritecredentialAddress), required: true);
            WorkflowValue.Validate(credentialWriteuserName, nameof(credentialWriteuserName), required: true);
            WorkflowValue.Validate(credentialWritepassword, nameof(credentialWritepassword), required: true);
            WorkflowValue.Validate(credentialWritecredentialType, nameof(credentialWritecredentialType), required: true);
            WorkflowValue.Validate(credentialWriteworkflow, nameof(credentialWriteworkflow), required: true);
            WorkflowValue.Validate(credentialWritecredentialPersistence, nameof(credentialWritecredentialPersistence), required: false);
            WorkflowValue.Validate(credentialWritesymmetricKey, nameof(credentialWritesymmetricKey), required: false);
            WorkflowValue.Validate(credentialWritestorePasswordAsIdentifier, nameof(credentialWritestorePasswordAsIdentifier), required: false);
            return new DeferredBodyAction<CredentialWriteResponse>(() =>
            {
                var apiCallPath = "/Environment/CredentialWrite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var credentialWrite = new JObject();
                var credentialWritepropCount = 0;
                credentialWritepropCount++;
                credentialWrite["CredentialAddress"] = ExpressionConverter.ConvertO(credentialWritecredentialAddress);
                credentialWritepropCount++;
                credentialWrite["UserName"] = ExpressionConverter.ConvertO(credentialWriteuserName);
                credentialWritepropCount++;
                credentialWrite["Password"] = ExpressionConverter.ConvertO(credentialWritepassword);
                credentialWritepropCount++;
                credentialWrite["CredentialType"] = ExpressionConverter.ConvertO(credentialWritecredentialType);
                if (credentialWritecredentialPersistence != null)
                {
                    if (credentialWritecredentialPersistence != null)
                    {
                        credentialWrite["CredentialPersistence"] = ExpressionConverter.ConvertO(credentialWritecredentialPersistence);
                        credentialWritepropCount++;
                    }

                    credentialWritepropCount++;
                }
                else
                {
                    credentialWrite["CredentialPersistence"] = "LocalMachine";
                    credentialWritepropCount++;
                }

                if (credentialWritesymmetricKey != null)
                {
                    credentialWrite["SymmetricKey"] = ExpressionConverter.ConvertO(credentialWritesymmetricKey);
                    credentialWritepropCount++;
                }

                if (credentialWritestorePasswordAsIdentifier != null)
                {
                    credentialWrite["StorePasswordAsIdentifier"] = ExpressionConverter.ConvertO(credentialWritestorePasswordAsIdentifier);
                    credentialWritepropCount++;
                }

                credentialWritepropCount++;
                credentialWrite["Workflow"] = ExpressionConverter.ConvertO(credentialWriteworkflow);
                if (credentialWritepropCount > 0)
                {
                    callPayload.Body = credentialWrite;
                }

                return new ApiConnectionAction<CredentialWriteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildCredentialRead))]
        public IBodyWorkflowAction<CredentialReadResponse> CredentialRead([WorkflowExpression] Func<string> credentialReadcredentialAddress, [WorkflowExpression] Func<credentialReadcredentialTypeInput> credentialReadcredentialType, [WorkflowExpression] Func<string> credentialReadworkflow, [WorkflowExpression] Func<string> credentialReadsymmetricKey = null, [WorkflowExpression] Func<string> credentialReadstorePasswordAsIdentifier = null, [WorkflowExpression] Func<bool> credentialReaddontReturnPassword = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CredentialReadResponse> __BuildCredentialRead(WorkflowValue<string> credentialReadcredentialAddress, WorkflowValue<credentialReadcredentialTypeInput> credentialReadcredentialType, WorkflowValue<string> credentialReadworkflow, WorkflowValue<string> credentialReadsymmetricKey = null, WorkflowValue<string> credentialReadstorePasswordAsIdentifier = null, WorkflowValue<bool> credentialReaddontReturnPassword = null)
        {
            WorkflowValue.Validate(credentialReadcredentialAddress, nameof(credentialReadcredentialAddress), required: true);
            WorkflowValue.Validate(credentialReadcredentialType, nameof(credentialReadcredentialType), required: true);
            WorkflowValue.Validate(credentialReadworkflow, nameof(credentialReadworkflow), required: true);
            WorkflowValue.Validate(credentialReadsymmetricKey, nameof(credentialReadsymmetricKey), required: false);
            WorkflowValue.Validate(credentialReadstorePasswordAsIdentifier, nameof(credentialReadstorePasswordAsIdentifier), required: false);
            WorkflowValue.Validate(credentialReaddontReturnPassword, nameof(credentialReaddontReturnPassword), required: false);
            return new DeferredBodyAction<CredentialReadResponse>(() =>
            {
                var apiCallPath = "/Environment/CredentialRead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var credentialRead = new JObject();
                var credentialReadpropCount = 0;
                credentialReadpropCount++;
                credentialRead["CredentialAddress"] = ExpressionConverter.ConvertO(credentialReadcredentialAddress);
                credentialReadpropCount++;
                credentialRead["CredentialType"] = ExpressionConverter.ConvertO(credentialReadcredentialType);
                if (credentialReadsymmetricKey != null)
                {
                    credentialRead["SymmetricKey"] = ExpressionConverter.ConvertO(credentialReadsymmetricKey);
                    credentialReadpropCount++;
                }

                if (credentialReadstorePasswordAsIdentifier != null)
                {
                    credentialRead["StorePasswordAsIdentifier"] = ExpressionConverter.ConvertO(credentialReadstorePasswordAsIdentifier);
                    credentialReadpropCount++;
                }

                if (credentialReaddontReturnPassword != null)
                {
                    if (credentialReaddontReturnPassword != null)
                    {
                        credentialRead["DontReturnPassword"] = ExpressionConverter.ConvertO(credentialReaddontReturnPassword);
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
                credentialRead["Workflow"] = ExpressionConverter.ConvertO(credentialReadworkflow);
                if (credentialReadpropCount > 0)
                {
                    callPayload.Body = credentialRead;
                }

                return new ApiConnectionAction<CredentialReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildCredentialDelete))]
        public IBodyWorkflowAction<CredentialDeleteResponse> CredentialDelete([WorkflowExpression] Func<string> credentialDeletecredentialAddress, [WorkflowExpression] Func<credentialDeletecredentialTypeInput> credentialDeletecredentialType, [WorkflowExpression] Func<string> credentialDeleteworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CredentialDeleteResponse> __BuildCredentialDelete(WorkflowValue<string> credentialDeletecredentialAddress, WorkflowValue<credentialDeletecredentialTypeInput> credentialDeletecredentialType, WorkflowValue<string> credentialDeleteworkflow)
        {
            WorkflowValue.Validate(credentialDeletecredentialAddress, nameof(credentialDeletecredentialAddress), required: true);
            WorkflowValue.Validate(credentialDeletecredentialType, nameof(credentialDeletecredentialType), required: true);
            WorkflowValue.Validate(credentialDeleteworkflow, nameof(credentialDeleteworkflow), required: true);
            return new DeferredBodyAction<CredentialDeleteResponse>(() =>
            {
                var apiCallPath = "/Environment/CredentialDelete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var credentialDelete = new JObject();
                var credentialDeletepropCount = 0;
                credentialDeletepropCount++;
                credentialDelete["CredentialAddress"] = ExpressionConverter.ConvertO(credentialDeletecredentialAddress);
                credentialDeletepropCount++;
                credentialDelete["CredentialType"] = ExpressionConverter.ConvertO(credentialDeletecredentialType);
                credentialDeletepropCount++;
                credentialDelete["Workflow"] = ExpressionConverter.ConvertO(credentialDeleteworkflow);
                if (credentialDeletepropCount > 0)
                {
                    callPayload.Body = credentialDelete;
                }

                return new ApiConnectionAction<CredentialDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateRDPFile))]
        public IBodyWorkflowAction<GenerateRDPFileResponse> GenerateRDPFile([WorkflowExpression] Func<string> generateRDPFileremoteAddress, [WorkflowExpression] Func<string> generateRDPFileoutputFolderPath, [WorkflowExpression] Func<string> generateRDPFilerDPFileName, [WorkflowExpression] Func<string> generateRDPFileworkflow, [WorkflowExpression] Func<bool> generateRDPFileoverwriteRDPFileIfAlreadyExists = null, [WorkflowExpression] Func<bool> generateRDPFiletrustRemoteComputer = null, [WorkflowExpression] Func<bool> generateRDPFilestoreCredentials = null, [WorkflowExpression] Func<string> generateRDPFileuserName = null, [WorkflowExpression] Func<string> generateRDPFilepassword = null, [WorkflowExpression] Func<generateRDPFilecredentialTypeInput> generateRDPFilecredentialType = null, [WorkflowExpression] Func<generateRDPFilecredentialPersistenceInput> generateRDPFilecredentialPersistence = null, [WorkflowExpression] Func<bool> generateRDPFileredirectPrinters = null, [WorkflowExpression] Func<bool> generateRDPFileredirectAllDrives = null, [WorkflowExpression] Func<bool> generateRDPFileredirectClipboard = null, [WorkflowExpression] Func<bool> generateRDPFilefullscreen = null, [WorkflowExpression] Func<int> generateRDPFiledesktopWidth = null, [WorkflowExpression] Func<int> generateRDPFiledesktopHeight = null, [WorkflowExpression] Func<bool> generateRDPFileuseMultiMonitor = null, [WorkflowExpression] Func<int> generateRDPFilesessionBPP = null, [WorkflowExpression] Func<bool> generateRDPFilesmartSizing = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateRDPFileResponse> __BuildGenerateRDPFile(WorkflowValue<string> generateRDPFileremoteAddress, WorkflowValue<string> generateRDPFileoutputFolderPath, WorkflowValue<string> generateRDPFilerDPFileName, WorkflowValue<string> generateRDPFileworkflow, WorkflowValue<bool> generateRDPFileoverwriteRDPFileIfAlreadyExists = null, WorkflowValue<bool> generateRDPFiletrustRemoteComputer = null, WorkflowValue<bool> generateRDPFilestoreCredentials = null, WorkflowValue<string> generateRDPFileuserName = null, WorkflowValue<string> generateRDPFilepassword = null, WorkflowValue<generateRDPFilecredentialTypeInput> generateRDPFilecredentialType = null, WorkflowValue<generateRDPFilecredentialPersistenceInput> generateRDPFilecredentialPersistence = null, WorkflowValue<bool> generateRDPFileredirectPrinters = null, WorkflowValue<bool> generateRDPFileredirectAllDrives = null, WorkflowValue<bool> generateRDPFileredirectClipboard = null, WorkflowValue<bool> generateRDPFilefullscreen = null, WorkflowValue<int> generateRDPFiledesktopWidth = null, WorkflowValue<int> generateRDPFiledesktopHeight = null, WorkflowValue<bool> generateRDPFileuseMultiMonitor = null, WorkflowValue<int> generateRDPFilesessionBPP = null, WorkflowValue<bool> generateRDPFilesmartSizing = null)
        {
            WorkflowValue.Validate(generateRDPFileremoteAddress, nameof(generateRDPFileremoteAddress), required: true);
            WorkflowValue.Validate(generateRDPFileoutputFolderPath, nameof(generateRDPFileoutputFolderPath), required: true);
            WorkflowValue.Validate(generateRDPFilerDPFileName, nameof(generateRDPFilerDPFileName), required: true);
            WorkflowValue.Validate(generateRDPFileworkflow, nameof(generateRDPFileworkflow), required: true);
            WorkflowValue.Validate(generateRDPFileoverwriteRDPFileIfAlreadyExists, nameof(generateRDPFileoverwriteRDPFileIfAlreadyExists), required: false);
            WorkflowValue.Validate(generateRDPFiletrustRemoteComputer, nameof(generateRDPFiletrustRemoteComputer), required: false);
            WorkflowValue.Validate(generateRDPFilestoreCredentials, nameof(generateRDPFilestoreCredentials), required: false);
            WorkflowValue.Validate(generateRDPFileuserName, nameof(generateRDPFileuserName), required: false);
            WorkflowValue.Validate(generateRDPFilepassword, nameof(generateRDPFilepassword), required: false);
            WorkflowValue.Validate(generateRDPFilecredentialType, nameof(generateRDPFilecredentialType), required: false);
            WorkflowValue.Validate(generateRDPFilecredentialPersistence, nameof(generateRDPFilecredentialPersistence), required: false);
            WorkflowValue.Validate(generateRDPFileredirectPrinters, nameof(generateRDPFileredirectPrinters), required: false);
            WorkflowValue.Validate(generateRDPFileredirectAllDrives, nameof(generateRDPFileredirectAllDrives), required: false);
            WorkflowValue.Validate(generateRDPFileredirectClipboard, nameof(generateRDPFileredirectClipboard), required: false);
            WorkflowValue.Validate(generateRDPFilefullscreen, nameof(generateRDPFilefullscreen), required: false);
            WorkflowValue.Validate(generateRDPFiledesktopWidth, nameof(generateRDPFiledesktopWidth), required: false);
            WorkflowValue.Validate(generateRDPFiledesktopHeight, nameof(generateRDPFiledesktopHeight), required: false);
            WorkflowValue.Validate(generateRDPFileuseMultiMonitor, nameof(generateRDPFileuseMultiMonitor), required: false);
            WorkflowValue.Validate(generateRDPFilesessionBPP, nameof(generateRDPFilesessionBPP), required: false);
            WorkflowValue.Validate(generateRDPFilesmartSizing, nameof(generateRDPFilesmartSizing), required: false);
            return new DeferredBodyAction<GenerateRDPFileResponse>(() =>
            {
                var apiCallPath = "/Environment/GenerateRDPFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var generateRDPFile = new JObject();
                var generateRDPFilepropCount = 0;
                generateRDPFilepropCount++;
                generateRDPFile["RemoteAddress"] = ExpressionConverter.ConvertO(generateRDPFileremoteAddress);
                generateRDPFilepropCount++;
                generateRDPFile["OutputFolderPath"] = ExpressionConverter.ConvertO(generateRDPFileoutputFolderPath);
                generateRDPFilepropCount++;
                generateRDPFile["RDPFileName"] = ExpressionConverter.ConvertO(generateRDPFilerDPFileName);
                if (generateRDPFileoverwriteRDPFileIfAlreadyExists != null)
                {
                    if (generateRDPFileoverwriteRDPFileIfAlreadyExists != null)
                    {
                        generateRDPFile["OverwriteRDPFileIfAlreadyExists"] = ExpressionConverter.ConvertO(generateRDPFileoverwriteRDPFileIfAlreadyExists);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["OverwriteRDPFileIfAlreadyExists"] = true;
                    generateRDPFilepropCount++;
                }

                if (generateRDPFiletrustRemoteComputer != null)
                {
                    if (generateRDPFiletrustRemoteComputer != null)
                    {
                        generateRDPFile["TrustRemoteComputer"] = ExpressionConverter.ConvertO(generateRDPFiletrustRemoteComputer);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["TrustRemoteComputer"] = true;
                    generateRDPFilepropCount++;
                }

                if (generateRDPFilestoreCredentials != null)
                {
                    if (generateRDPFilestoreCredentials != null)
                    {
                        generateRDPFile["StoreCredentials"] = ExpressionConverter.ConvertO(generateRDPFilestoreCredentials);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["StoreCredentials"] = true;
                    generateRDPFilepropCount++;
                }

                if (generateRDPFileuserName != null)
                {
                    generateRDPFile["UserName"] = ExpressionConverter.ConvertO(generateRDPFileuserName);
                    generateRDPFilepropCount++;
                }

                if (generateRDPFilepassword != null)
                {
                    generateRDPFile["Password"] = ExpressionConverter.ConvertO(generateRDPFilepassword);
                    generateRDPFilepropCount++;
                }

                if (generateRDPFilecredentialType != null)
                {
                    if (generateRDPFilecredentialType != null)
                    {
                        generateRDPFile["CredentialType"] = ExpressionConverter.ConvertO(generateRDPFilecredentialType);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["CredentialType"] = "Windows";
                    generateRDPFilepropCount++;
                }

                if (generateRDPFilecredentialPersistence != null)
                {
                    if (generateRDPFilecredentialPersistence != null)
                    {
                        generateRDPFile["CredentialPersistence"] = ExpressionConverter.ConvertO(generateRDPFilecredentialPersistence);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["CredentialPersistence"] = "Session";
                    generateRDPFilepropCount++;
                }

                if (generateRDPFileredirectPrinters != null)
                {
                    if (generateRDPFileredirectPrinters != null)
                    {
                        generateRDPFile["RedirectPrinters"] = ExpressionConverter.ConvertO(generateRDPFileredirectPrinters);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["RedirectPrinters"] = false;
                    generateRDPFilepropCount++;
                }

                if (generateRDPFileredirectAllDrives != null)
                {
                    if (generateRDPFileredirectAllDrives != null)
                    {
                        generateRDPFile["RedirectAllDrives"] = ExpressionConverter.ConvertO(generateRDPFileredirectAllDrives);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["RedirectAllDrives"] = false;
                    generateRDPFilepropCount++;
                }

                if (generateRDPFileredirectClipboard != null)
                {
                    if (generateRDPFileredirectClipboard != null)
                    {
                        generateRDPFile["RedirectClipboard"] = ExpressionConverter.ConvertO(generateRDPFileredirectClipboard);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["RedirectClipboard"] = true;
                    generateRDPFilepropCount++;
                }

                if (generateRDPFilefullscreen != null)
                {
                    if (generateRDPFilefullscreen != null)
                    {
                        generateRDPFile["Fullscreen"] = ExpressionConverter.ConvertO(generateRDPFilefullscreen);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["Fullscreen"] = true;
                    generateRDPFilepropCount++;
                }

                if (generateRDPFiledesktopWidth != null)
                {
                    if (generateRDPFiledesktopWidth != null)
                    {
                        generateRDPFile["DesktopWidth"] = ExpressionConverter.ConvertO(generateRDPFiledesktopWidth);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["DesktopWidth"] = 1280;
                    generateRDPFilepropCount++;
                }

                if (generateRDPFiledesktopHeight != null)
                {
                    if (generateRDPFiledesktopHeight != null)
                    {
                        generateRDPFile["DesktopHeight"] = ExpressionConverter.ConvertO(generateRDPFiledesktopHeight);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["DesktopHeight"] = 1024;
                    generateRDPFilepropCount++;
                }

                if (generateRDPFileuseMultiMonitor != null)
                {
                    if (generateRDPFileuseMultiMonitor != null)
                    {
                        generateRDPFile["UseMultiMonitor"] = ExpressionConverter.ConvertO(generateRDPFileuseMultiMonitor);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["UseMultiMonitor"] = false;
                    generateRDPFilepropCount++;
                }

                if (generateRDPFilesessionBPP != null)
                {
                    if (generateRDPFilesessionBPP != null)
                    {
                        generateRDPFile["SessionBPP"] = ExpressionConverter.ConvertO(generateRDPFilesessionBPP);
                        generateRDPFilepropCount++;
                    }

                    generateRDPFilepropCount++;
                }
                else
                {
                    generateRDPFile["SessionBPP"] = 32;
                    generateRDPFilepropCount++;
                }

                if (generateRDPFilesmartSizing != null)
                {
                    if (generateRDPFilesmartSizing != null)
                    {
                        generateRDPFile["SmartSizing"] = ExpressionConverter.ConvertO(generateRDPFilesmartSizing);
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
                generateRDPFile["Workflow"] = ExpressionConverter.ConvertO(generateRDPFileworkflow);
                if (generateRDPFilepropCount > 0)
                {
                    callPayload.Body = generateRDPFile;
                }

                return new ApiConnectionAction<GenerateRDPFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildLaunchRemoteDesktopSession))]
        public IBodyWorkflowAction<LaunchRemoteDesktopSessionResponse> LaunchRemoteDesktopSession([WorkflowExpression] Func<string> launchRemoteDesktopSessionrDPFilePath, [WorkflowExpression] Func<string> launchRemoteDesktopSessionworkflow, [WorkflowExpression] Func<bool> launchRemoteDesktopSessiontrustRemoteComputer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LaunchRemoteDesktopSessionResponse> __BuildLaunchRemoteDesktopSession(WorkflowValue<string> launchRemoteDesktopSessionrDPFilePath, WorkflowValue<string> launchRemoteDesktopSessionworkflow, WorkflowValue<bool> launchRemoteDesktopSessiontrustRemoteComputer = null)
        {
            WorkflowValue.Validate(launchRemoteDesktopSessionrDPFilePath, nameof(launchRemoteDesktopSessionrDPFilePath), required: true);
            WorkflowValue.Validate(launchRemoteDesktopSessionworkflow, nameof(launchRemoteDesktopSessionworkflow), required: true);
            WorkflowValue.Validate(launchRemoteDesktopSessiontrustRemoteComputer, nameof(launchRemoteDesktopSessiontrustRemoteComputer), required: false);
            return new DeferredBodyAction<LaunchRemoteDesktopSessionResponse>(() =>
            {
                var apiCallPath = "/Environment/LaunchRemoteDesktopSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var launchRemoteDesktopSession = new JObject();
                var launchRemoteDesktopSessionpropCount = 0;
                launchRemoteDesktopSessionpropCount++;
                launchRemoteDesktopSession["RDPFilePath"] = ExpressionConverter.ConvertO(launchRemoteDesktopSessionrDPFilePath);
                if (launchRemoteDesktopSessiontrustRemoteComputer != null)
                {
                    if (launchRemoteDesktopSessiontrustRemoteComputer != null)
                    {
                        launchRemoteDesktopSession["TrustRemoteComputer"] = ExpressionConverter.ConvertO(launchRemoteDesktopSessiontrustRemoteComputer);
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
                launchRemoteDesktopSession["Workflow"] = ExpressionConverter.ConvertO(launchRemoteDesktopSessionworkflow);
                if (launchRemoteDesktopSessionpropCount > 0)
                {
                    callPayload.Body = launchRemoteDesktopSession;
                }

                return new ApiConnectionAction<LaunchRemoteDesktopSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildIsTCPPortResponding))]
        public IBodyWorkflowAction<IsTCPPortRespondingResponse> IsTCPPortResponding([WorkflowExpression] Func<string> isTCPPortRespondingremoteHost, [WorkflowExpression] Func<int> isTCPPortRespondingtCPPort, [WorkflowExpression] Func<string> isTCPPortRespondingworkflow, [WorkflowExpression] Func<int> isTCPPortRespondingtimeoutInSeconds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsTCPPortRespondingResponse> __BuildIsTCPPortResponding(WorkflowValue<string> isTCPPortRespondingremoteHost, WorkflowValue<int> isTCPPortRespondingtCPPort, WorkflowValue<string> isTCPPortRespondingworkflow, WorkflowValue<int> isTCPPortRespondingtimeoutInSeconds = null)
        {
            WorkflowValue.Validate(isTCPPortRespondingremoteHost, nameof(isTCPPortRespondingremoteHost), required: true);
            WorkflowValue.Validate(isTCPPortRespondingtCPPort, nameof(isTCPPortRespondingtCPPort), required: true);
            WorkflowValue.Validate(isTCPPortRespondingworkflow, nameof(isTCPPortRespondingworkflow), required: true);
            WorkflowValue.Validate(isTCPPortRespondingtimeoutInSeconds, nameof(isTCPPortRespondingtimeoutInSeconds), required: false);
            return new DeferredBodyAction<IsTCPPortRespondingResponse>(() =>
            {
                var apiCallPath = "/Environment/IsTCPPortResponding";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isTCPPortResponding = new JObject();
                var isTCPPortRespondingpropCount = 0;
                isTCPPortRespondingpropCount++;
                isTCPPortResponding["RemoteHost"] = ExpressionConverter.ConvertO(isTCPPortRespondingremoteHost);
                isTCPPortRespondingpropCount++;
                isTCPPortResponding["TCPPort"] = ExpressionConverter.ConvertO(isTCPPortRespondingtCPPort);
                if (isTCPPortRespondingtimeoutInSeconds != null)
                {
                    if (isTCPPortRespondingtimeoutInSeconds != null)
                    {
                        isTCPPortResponding["TimeoutInSeconds"] = ExpressionConverter.ConvertO(isTCPPortRespondingtimeoutInSeconds);
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
                isTCPPortResponding["Workflow"] = ExpressionConverter.ConvertO(isTCPPortRespondingworkflow);
                if (isTCPPortRespondingpropCount > 0)
                {
                    callPayload.Body = isTCPPortResponding;
                }

                return new ApiConnectionAction<IsTCPPortRespondingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildUnlockSession))]
        public IBodyWorkflowAction<UnlockSessionResponse> UnlockSession([WorkflowExpression] Func<string> unlockSessionunlockPassword, [WorkflowExpression] Func<bool> unlockSessiondetectIfLocked, [WorkflowExpression] Func<bool> unlockSessiondetectCredentialProvider, [WorkflowExpression] Func<string> unlockSessionworkflow, [WorkflowExpression] Func<bool> unlockSessionpasswordContainsStoredPassword = null, [WorkflowExpression] Func<int> unlockSessionsecondsToWaitForUnlock = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UnlockSessionResponse> __BuildUnlockSession(WorkflowValue<string> unlockSessionunlockPassword, WorkflowValue<bool> unlockSessiondetectIfLocked, WorkflowValue<bool> unlockSessiondetectCredentialProvider, WorkflowValue<string> unlockSessionworkflow, WorkflowValue<bool> unlockSessionpasswordContainsStoredPassword = null, WorkflowValue<int> unlockSessionsecondsToWaitForUnlock = null)
        {
            WorkflowValue.Validate(unlockSessionunlockPassword, nameof(unlockSessionunlockPassword), required: true);
            WorkflowValue.Validate(unlockSessiondetectIfLocked, nameof(unlockSessiondetectIfLocked), required: true);
            WorkflowValue.Validate(unlockSessiondetectCredentialProvider, nameof(unlockSessiondetectCredentialProvider), required: true);
            WorkflowValue.Validate(unlockSessionworkflow, nameof(unlockSessionworkflow), required: true);
            WorkflowValue.Validate(unlockSessionpasswordContainsStoredPassword, nameof(unlockSessionpasswordContainsStoredPassword), required: false);
            WorkflowValue.Validate(unlockSessionsecondsToWaitForUnlock, nameof(unlockSessionsecondsToWaitForUnlock), required: false);
            return new DeferredBodyAction<UnlockSessionResponse>(() =>
            {
                var apiCallPath = "/Environment/UnlockSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var unlockSession = new JObject();
                var unlockSessionpropCount = 0;
                unlockSessionpropCount++;
                unlockSession["UnlockPassword"] = ExpressionConverter.ConvertO(unlockSessionunlockPassword);
                if (unlockSessionpasswordContainsStoredPassword != null)
                {
                    if (unlockSessionpasswordContainsStoredPassword != null)
                    {
                        unlockSession["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(unlockSessionpasswordContainsStoredPassword);
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
                unlockSession["DetectIfLocked"] = ExpressionConverter.ConvertO(unlockSessiondetectIfLocked);
                unlockSessionpropCount++;
                unlockSession["DetectCredentialProvider"] = ExpressionConverter.ConvertO(unlockSessiondetectCredentialProvider);
                if (unlockSessionsecondsToWaitForUnlock != null)
                {
                    if (unlockSessionsecondsToWaitForUnlock != null)
                    {
                        unlockSession["SecondsToWaitForUnlock"] = ExpressionConverter.ConvertO(unlockSessionsecondsToWaitForUnlock);
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
                unlockSession["Workflow"] = ExpressionConverter.ConvertO(unlockSessionworkflow);
                if (unlockSessionpropCount > 0)
                {
                    callPayload.Body = unlockSession;
                }

                return new ApiConnectionAction<UnlockSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildLockSession))]
        public IBodyWorkflowAction<LockSessionResponse> LockSession([WorkflowExpression] Func<string> lockSessionworkflow, [WorkflowExpression] Func<int> lockSessionlockAfterMinutesOfActionInactivity = null, [WorkflowExpression] Func<int> lockSessionsecondsToWaitAfterLock = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LockSessionResponse> __BuildLockSession(WorkflowValue<string> lockSessionworkflow, WorkflowValue<int> lockSessionlockAfterMinutesOfActionInactivity = null, WorkflowValue<int> lockSessionsecondsToWaitAfterLock = null)
        {
            WorkflowValue.Validate(lockSessionworkflow, nameof(lockSessionworkflow), required: true);
            WorkflowValue.Validate(lockSessionlockAfterMinutesOfActionInactivity, nameof(lockSessionlockAfterMinutesOfActionInactivity), required: false);
            WorkflowValue.Validate(lockSessionsecondsToWaitAfterLock, nameof(lockSessionsecondsToWaitAfterLock), required: false);
            return new DeferredBodyAction<LockSessionResponse>(() =>
            {
                var apiCallPath = "/Environment/LockSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lockSession = new JObject();
                var lockSessionpropCount = 0;
                if (lockSessionlockAfterMinutesOfActionInactivity != null)
                {
                    if (lockSessionlockAfterMinutesOfActionInactivity != null)
                    {
                        lockSession["LockAfterMinutesOfActionInactivity"] = ExpressionConverter.ConvertO(lockSessionlockAfterMinutesOfActionInactivity);
                        lockSessionpropCount++;
                    }

                    lockSessionpropCount++;
                }
                else
                {
                    lockSession["LockAfterMinutesOfActionInactivity"] = 5;
                    lockSessionpropCount++;
                }

                if (lockSessionsecondsToWaitAfterLock != null)
                {
                    if (lockSessionsecondsToWaitAfterLock != null)
                    {
                        lockSession["SecondsToWaitAfterLock"] = ExpressionConverter.ConvertO(lockSessionsecondsToWaitAfterLock);
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
                lockSession["Workflow"] = ExpressionConverter.ConvertO(lockSessionworkflow);
                if (lockSessionpropCount > 0)
                {
                    callPayload.Body = lockSession;
                }

                return new ApiConnectionAction<LockSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildIsSessionLocked))]
        public IBodyWorkflowAction<IsSessionLockedResponse> IsSessionLocked([WorkflowExpression] Func<string> isSessionLockedworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsSessionLockedResponse> __BuildIsSessionLocked(WorkflowValue<string> isSessionLockedworkflow)
        {
            WorkflowValue.Validate(isSessionLockedworkflow, nameof(isSessionLockedworkflow), required: true);
            return new DeferredBodyAction<IsSessionLockedResponse>(() =>
            {
                var apiCallPath = "/Environment/IsSessionLocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isSessionLocked = new JObject();
                var isSessionLockedpropCount = 0;
                isSessionLockedpropCount++;
                isSessionLocked["Workflow"] = ExpressionConverter.ConvertO(isSessionLockedworkflow);
                if (isSessionLockedpropCount > 0)
                {
                    callPayload.Body = isSessionLocked;
                }

                return new ApiConnectionAction<IsSessionLockedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetGenericCredentialFromOrchestrator))]
        public IBodyWorkflowAction<GetGenericCredentialFromOrchestratorResponse> GetGenericCredentialFromOrchestrator([WorkflowExpression] Func<string> getGenericCredentialFromOrchestratorfriendlyName = null, [WorkflowExpression] Func<bool> getGenericCredentialFromOrchestratorretrievePlainTextPassword = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGenericCredentialFromOrchestratorResponse> __BuildGetGenericCredentialFromOrchestrator(WorkflowValue<string> getGenericCredentialFromOrchestratorfriendlyName = null, WorkflowValue<bool> getGenericCredentialFromOrchestratorretrievePlainTextPassword = null)
        {
            WorkflowValue.Validate(getGenericCredentialFromOrchestratorfriendlyName, nameof(getGenericCredentialFromOrchestratorfriendlyName), required: false);
            WorkflowValue.Validate(getGenericCredentialFromOrchestratorretrievePlainTextPassword, nameof(getGenericCredentialFromOrchestratorretrievePlainTextPassword), required: false);
            return new DeferredBodyAction<GetGenericCredentialFromOrchestratorResponse>(() =>
            {
                var apiCallPath = "/Environment/GetGenericCredentialFromOrchestrator";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getGenericCredentialFromOrchestrator = new JObject();
                var getGenericCredentialFromOrchestratorpropCount = 0;
                if (getGenericCredentialFromOrchestratorfriendlyName != null)
                {
                    getGenericCredentialFromOrchestrator["FriendlyName"] = ExpressionConverter.ConvertO(getGenericCredentialFromOrchestratorfriendlyName);
                    getGenericCredentialFromOrchestratorpropCount++;
                }

                if (getGenericCredentialFromOrchestratorretrievePlainTextPassword != null)
                {
                    if (getGenericCredentialFromOrchestratorretrievePlainTextPassword != null)
                    {
                        getGenericCredentialFromOrchestrator["RetrievePlainTextPassword"] = ExpressionConverter.ConvertO(getGenericCredentialFromOrchestratorretrievePlainTextPassword);
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
        [WorkflowExpressionFactory(nameof(__BuildDrawRectangleOnScreen))]
        public IBodyWorkflowAction<DrawRectangleOnScreenResponse> DrawRectangleOnScreen([WorkflowExpression] Func<int> drawRectangleOnScreenrectangleLeftPixelXCoord, [WorkflowExpression] Func<int> drawRectangleOnScreenrectangleRightPixelXCoord, [WorkflowExpression] Func<int> drawRectangleOnScreenrectangleTopPixelYCoord, [WorkflowExpression] Func<int> drawRectangleOnScreenrectangleBottomPixelYCoord, [WorkflowExpression] Func<string> drawRectangleOnScreenworkflow, [WorkflowExpression] Func<string> drawRectangleOnScreenpenColour = null, [WorkflowExpression] Func<int> drawRectangleOnScreenpenThicknessPixels = null, [WorkflowExpression] Func<int> drawRectangleOnScreensecondsToDisplay = null, [WorkflowExpression] Func<bool> drawRectangleOnScreencoordinatesArePhysical = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DrawRectangleOnScreenResponse> __BuildDrawRectangleOnScreen(WorkflowValue<int> drawRectangleOnScreenrectangleLeftPixelXCoord, WorkflowValue<int> drawRectangleOnScreenrectangleRightPixelXCoord, WorkflowValue<int> drawRectangleOnScreenrectangleTopPixelYCoord, WorkflowValue<int> drawRectangleOnScreenrectangleBottomPixelYCoord, WorkflowValue<string> drawRectangleOnScreenworkflow, WorkflowValue<string> drawRectangleOnScreenpenColour = null, WorkflowValue<int> drawRectangleOnScreenpenThicknessPixels = null, WorkflowValue<int> drawRectangleOnScreensecondsToDisplay = null, WorkflowValue<bool> drawRectangleOnScreencoordinatesArePhysical = null)
        {
            WorkflowValue.Validate(drawRectangleOnScreenrectangleLeftPixelXCoord, nameof(drawRectangleOnScreenrectangleLeftPixelXCoord), required: true);
            WorkflowValue.Validate(drawRectangleOnScreenrectangleRightPixelXCoord, nameof(drawRectangleOnScreenrectangleRightPixelXCoord), required: true);
            WorkflowValue.Validate(drawRectangleOnScreenrectangleTopPixelYCoord, nameof(drawRectangleOnScreenrectangleTopPixelYCoord), required: true);
            WorkflowValue.Validate(drawRectangleOnScreenrectangleBottomPixelYCoord, nameof(drawRectangleOnScreenrectangleBottomPixelYCoord), required: true);
            WorkflowValue.Validate(drawRectangleOnScreenworkflow, nameof(drawRectangleOnScreenworkflow), required: true);
            WorkflowValue.Validate(drawRectangleOnScreenpenColour, nameof(drawRectangleOnScreenpenColour), required: false);
            WorkflowValue.Validate(drawRectangleOnScreenpenThicknessPixels, nameof(drawRectangleOnScreenpenThicknessPixels), required: false);
            WorkflowValue.Validate(drawRectangleOnScreensecondsToDisplay, nameof(drawRectangleOnScreensecondsToDisplay), required: false);
            WorkflowValue.Validate(drawRectangleOnScreencoordinatesArePhysical, nameof(drawRectangleOnScreencoordinatesArePhysical), required: false);
            return new DeferredBodyAction<DrawRectangleOnScreenResponse>(() =>
            {
                var apiCallPath = "/Environment/DrawRectangleOnScreen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var drawRectangleOnScreen = new JObject();
                var drawRectangleOnScreenpropCount = 0;
                drawRectangleOnScreenpropCount++;
                drawRectangleOnScreen["RectangleLeftPixelXCoord"] = ExpressionConverter.ConvertO(drawRectangleOnScreenrectangleLeftPixelXCoord);
                drawRectangleOnScreenpropCount++;
                drawRectangleOnScreen["RectangleRightPixelXCoord"] = ExpressionConverter.ConvertO(drawRectangleOnScreenrectangleRightPixelXCoord);
                drawRectangleOnScreenpropCount++;
                drawRectangleOnScreen["RectangleTopPixelYCoord"] = ExpressionConverter.ConvertO(drawRectangleOnScreenrectangleTopPixelYCoord);
                drawRectangleOnScreenpropCount++;
                drawRectangleOnScreen["RectangleBottomPixelYCoord"] = ExpressionConverter.ConvertO(drawRectangleOnScreenrectangleBottomPixelYCoord);
                if (drawRectangleOnScreenpenColour != null)
                {
                    if (drawRectangleOnScreenpenColour != null)
                    {
                        drawRectangleOnScreen["PenColour"] = ExpressionConverter.ConvertO(drawRectangleOnScreenpenColour);
                        drawRectangleOnScreenpropCount++;
                    }

                    drawRectangleOnScreenpropCount++;
                }
                else
                {
                    drawRectangleOnScreen["PenColour"] = "#800080";
                    drawRectangleOnScreenpropCount++;
                }

                if (drawRectangleOnScreenpenThicknessPixels != null)
                {
                    if (drawRectangleOnScreenpenThicknessPixels != null)
                    {
                        drawRectangleOnScreen["PenThicknessPixels"] = ExpressionConverter.ConvertO(drawRectangleOnScreenpenThicknessPixels);
                        drawRectangleOnScreenpropCount++;
                    }

                    drawRectangleOnScreenpropCount++;
                }
                else
                {
                    drawRectangleOnScreen["PenThicknessPixels"] = 4;
                    drawRectangleOnScreenpropCount++;
                }

                if (drawRectangleOnScreensecondsToDisplay != null)
                {
                    if (drawRectangleOnScreensecondsToDisplay != null)
                    {
                        drawRectangleOnScreen["SecondsToDisplay"] = ExpressionConverter.ConvertO(drawRectangleOnScreensecondsToDisplay);
                        drawRectangleOnScreenpropCount++;
                    }

                    drawRectangleOnScreenpropCount++;
                }
                else
                {
                    drawRectangleOnScreen["SecondsToDisplay"] = 5;
                    drawRectangleOnScreenpropCount++;
                }

                if (drawRectangleOnScreencoordinatesArePhysical != null)
                {
                    if (drawRectangleOnScreencoordinatesArePhysical != null)
                    {
                        drawRectangleOnScreen["CoordinatesArePhysical"] = ExpressionConverter.ConvertO(drawRectangleOnScreencoordinatesArePhysical);
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
                drawRectangleOnScreen["Workflow"] = ExpressionConverter.ConvertO(drawRectangleOnScreenworkflow);
                if (drawRectangleOnScreenpropCount > 0)
                {
                    callPayload.Body = drawRectangleOnScreen;
                }

                return new ApiConnectionAction<DrawRectangleOnScreenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetFailedActionErrorMessageFromPowerAutomateResultJSON))]
        public IBodyWorkflowAction<GetFailedActionErrorMessageFromPowerAutomateResultJSONResponse> GetFailedActionErrorMessageFromPowerAutomateResultJSON([WorkflowExpression] Func<string[]> getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON, [WorkflowExpression] Func<string> getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFailedActionErrorMessageFromPowerAutomateResultJSONResponse> __BuildGetFailedActionErrorMessageFromPowerAutomateResultJSON(WorkflowValue<string[]> getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON, WorkflowValue<string> getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus = null)
        {
            WorkflowValue.Validate(getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON, nameof(getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON), required: true);
            WorkflowValue.Validate(getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus, nameof(getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus), required: false);
            return new DeferredBodyAction<GetFailedActionErrorMessageFromPowerAutomateResultJSONResponse>(() =>
            {
                var apiCallPath = "/Environment/GetFailedActionErrorMessageFromPowerAutomateResultJSON";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getFailedActionErrorMessageFromPowerAutomateResultJSON = new JObject();
                var getFailedActionErrorMessageFromPowerAutomateResultJSONpropCount = 0;
                getFailedActionErrorMessageFromPowerAutomateResultJSONpropCount++;
                getFailedActionErrorMessageFromPowerAutomateResultJSON["PowerAutomateResultJSON"] = ExpressionConverter.ConvertO(getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON);
                if (getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus != null)
                {
                    if (getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus != null)
                    {
                        getFailedActionErrorMessageFromPowerAutomateResultJSON["SearchStatus"] = ExpressionConverter.ConvertO(getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus);
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
        [WorkflowExpressionFactory(nameof(__BuildGetPixelColourAtCoordinate))]
        public IBodyWorkflowAction<GetPixelColourAtCoordinateResponse> GetPixelColourAtCoordinate([WorkflowExpression] Func<int> getPixelColourAtCoordinateleftXPixels, [WorkflowExpression] Func<int> getPixelColourAtCoordinatetopYPixels, [WorkflowExpression] Func<string> getPixelColourAtCoordinateworkflow, [WorkflowExpression] Func<bool> getPixelColourAtCoordinatehideAgent = null, [WorkflowExpression] Func<bool> getPixelColourAtCoordinateusePhysicalCoordinates = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPixelColourAtCoordinateResponse> __BuildGetPixelColourAtCoordinate(WorkflowValue<int> getPixelColourAtCoordinateleftXPixels, WorkflowValue<int> getPixelColourAtCoordinatetopYPixels, WorkflowValue<string> getPixelColourAtCoordinateworkflow, WorkflowValue<bool> getPixelColourAtCoordinatehideAgent = null, WorkflowValue<bool> getPixelColourAtCoordinateusePhysicalCoordinates = null)
        {
            WorkflowValue.Validate(getPixelColourAtCoordinateleftXPixels, nameof(getPixelColourAtCoordinateleftXPixels), required: true);
            WorkflowValue.Validate(getPixelColourAtCoordinatetopYPixels, nameof(getPixelColourAtCoordinatetopYPixels), required: true);
            WorkflowValue.Validate(getPixelColourAtCoordinateworkflow, nameof(getPixelColourAtCoordinateworkflow), required: true);
            WorkflowValue.Validate(getPixelColourAtCoordinatehideAgent, nameof(getPixelColourAtCoordinatehideAgent), required: false);
            WorkflowValue.Validate(getPixelColourAtCoordinateusePhysicalCoordinates, nameof(getPixelColourAtCoordinateusePhysicalCoordinates), required: false);
            return new DeferredBodyAction<GetPixelColourAtCoordinateResponse>(() =>
            {
                var apiCallPath = "/Environment/GetPixelColourAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getPixelColourAtCoordinate = new JObject();
                var getPixelColourAtCoordinatepropCount = 0;
                getPixelColourAtCoordinatepropCount++;
                getPixelColourAtCoordinate["LeftXPixels"] = ExpressionConverter.ConvertO(getPixelColourAtCoordinateleftXPixels);
                getPixelColourAtCoordinatepropCount++;
                getPixelColourAtCoordinate["TopYPixels"] = ExpressionConverter.ConvertO(getPixelColourAtCoordinatetopYPixels);
                if (getPixelColourAtCoordinatehideAgent != null)
                {
                    if (getPixelColourAtCoordinatehideAgent != null)
                    {
                        getPixelColourAtCoordinate["HideAgent"] = ExpressionConverter.ConvertO(getPixelColourAtCoordinatehideAgent);
                        getPixelColourAtCoordinatepropCount++;
                    }

                    getPixelColourAtCoordinatepropCount++;
                }
                else
                {
                    getPixelColourAtCoordinate["HideAgent"] = false;
                    getPixelColourAtCoordinatepropCount++;
                }

                if (getPixelColourAtCoordinateusePhysicalCoordinates != null)
                {
                    if (getPixelColourAtCoordinateusePhysicalCoordinates != null)
                    {
                        getPixelColourAtCoordinate["UsePhysicalCoordinates"] = ExpressionConverter.ConvertO(getPixelColourAtCoordinateusePhysicalCoordinates);
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
                getPixelColourAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(getPixelColourAtCoordinateworkflow);
                if (getPixelColourAtCoordinatepropCount > 0)
                {
                    callPayload.Body = getPixelColourAtCoordinate;
                }

                return new ApiConnectionAction<GetPixelColourAtCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildConvertRectangleCoordinates))]
        public IBodyWorkflowAction<ConvertRectangleCoordinatesResponse> ConvertRectangleCoordinates([WorkflowExpression] Func<int> convertRectangleCoordinatesrectangleLeftPixelXCoord, [WorkflowExpression] Func<int> convertRectangleCoordinatesrectangleTopPixelYCoord, [WorkflowExpression] Func<int> convertRectangleCoordinatesrectangleRightPixelXCoord, [WorkflowExpression] Func<int> convertRectangleCoordinatesrectangleBottomPixelYCoord, [WorkflowExpression] Func<convertRectangleCoordinatesconversionTypeInput> convertRectangleCoordinatesconversionType, [WorkflowExpression] Func<string> convertRectangleCoordinatesworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConvertRectangleCoordinatesResponse> __BuildConvertRectangleCoordinates(WorkflowValue<int> convertRectangleCoordinatesrectangleLeftPixelXCoord, WorkflowValue<int> convertRectangleCoordinatesrectangleTopPixelYCoord, WorkflowValue<int> convertRectangleCoordinatesrectangleRightPixelXCoord, WorkflowValue<int> convertRectangleCoordinatesrectangleBottomPixelYCoord, WorkflowValue<convertRectangleCoordinatesconversionTypeInput> convertRectangleCoordinatesconversionType, WorkflowValue<string> convertRectangleCoordinatesworkflow)
        {
            WorkflowValue.Validate(convertRectangleCoordinatesrectangleLeftPixelXCoord, nameof(convertRectangleCoordinatesrectangleLeftPixelXCoord), required: true);
            WorkflowValue.Validate(convertRectangleCoordinatesrectangleTopPixelYCoord, nameof(convertRectangleCoordinatesrectangleTopPixelYCoord), required: true);
            WorkflowValue.Validate(convertRectangleCoordinatesrectangleRightPixelXCoord, nameof(convertRectangleCoordinatesrectangleRightPixelXCoord), required: true);
            WorkflowValue.Validate(convertRectangleCoordinatesrectangleBottomPixelYCoord, nameof(convertRectangleCoordinatesrectangleBottomPixelYCoord), required: true);
            WorkflowValue.Validate(convertRectangleCoordinatesconversionType, nameof(convertRectangleCoordinatesconversionType), required: true);
            WorkflowValue.Validate(convertRectangleCoordinatesworkflow, nameof(convertRectangleCoordinatesworkflow), required: true);
            return new DeferredBodyAction<ConvertRectangleCoordinatesResponse>(() =>
            {
                var apiCallPath = "/Environment/ConvertRectangleCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var convertRectangleCoordinates = new JObject();
                var convertRectangleCoordinatespropCount = 0;
                convertRectangleCoordinatespropCount++;
                convertRectangleCoordinates["RectangleLeftPixelXCoord"] = ExpressionConverter.ConvertO(convertRectangleCoordinatesrectangleLeftPixelXCoord);
                convertRectangleCoordinatespropCount++;
                convertRectangleCoordinates["RectangleTopPixelYCoord"] = ExpressionConverter.ConvertO(convertRectangleCoordinatesrectangleTopPixelYCoord);
                convertRectangleCoordinatespropCount++;
                convertRectangleCoordinates["RectangleRightPixelXCoord"] = ExpressionConverter.ConvertO(convertRectangleCoordinatesrectangleRightPixelXCoord);
                convertRectangleCoordinatespropCount++;
                convertRectangleCoordinates["RectangleBottomPixelYCoord"] = ExpressionConverter.ConvertO(convertRectangleCoordinatesrectangleBottomPixelYCoord);
                convertRectangleCoordinatespropCount++;
                convertRectangleCoordinates["ConversionType"] = ExpressionConverter.ConvertO(convertRectangleCoordinatesconversionType);
                convertRectangleCoordinatespropCount++;
                convertRectangleCoordinates["Workflow"] = ExpressionConverter.ConvertO(convertRectangleCoordinatesworkflow);
                if (convertRectangleCoordinatespropCount > 0)
                {
                    callPayload.Body = convertRectangleCoordinates;
                }

                return new ApiConnectionAction<ConvertRectangleCoordinatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessageToWebAPI))]
        public IBodyWorkflowAction<SendMessageToWebAPIResponse> SendMessageToWebAPI([WorkflowExpression] Func<string> sendMessageToWebAPIworkflow, [WorkflowExpression] Func<string> sendMessageToWebAPIuRL = null, [WorkflowExpression] Func<sendMessageToWebAPImethodInput> sendMessageToWebAPImethod = null, [WorkflowExpression] Func<int> sendMessageToWebAPItimeoutInSeconds = null, [WorkflowExpression] Func<string> sendMessageToWebAPIcontentType = null, [WorkflowExpression] Func<string> sendMessageToWebAPIaccept = null, [WorkflowExpression] Func<string> sendMessageToWebAPImessageBody = null, [WorkflowExpression] Func<sendMessageToWebAPItransmitEncodingInput> sendMessageToWebAPItransmitEncoding = null, [WorkflowExpression] Func<sendMessageToWebAPIresponseEncodingInput> sendMessageToWebAPIresponseEncoding = null, [WorkflowExpression] Func<int> sendMessageToWebAPIbufferSize = null, [WorkflowExpression] Func<sendMessageToWebAPIhTTPRequestHeadersListInputItem[]> sendMessageToWebAPIhTTPRequestHeadersList = null, [WorkflowExpression] Func<bool> sendMessageToWebAPInegotiateTLS10 = null, [WorkflowExpression] Func<bool> sendMessageToWebAPInegotiateTLS11 = null, [WorkflowExpression] Func<bool> sendMessageToWebAPInegotiateTLS12 = null, [WorkflowExpression] Func<bool> sendMessageToWebAPInegotiateTLS13 = null, [WorkflowExpression] Func<bool> sendMessageToWebAPIkeepAlive = null, [WorkflowExpression] Func<bool> sendMessageToWebAPIexpect100Continue = null, [WorkflowExpression] Func<bool> sendMessageToWebAPIreturnResponseHeaders = null, [WorkflowExpression] Func<bool> sendMessageToWebAPIrunAsThread = null, [WorkflowExpression] Func<bool> sendMessageToWebAPIwaitForThread = null, [WorkflowExpression] Func<int> sendMessageToWebAPIretrieveOutputDataFromThreadId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageToWebAPIResponse> __BuildSendMessageToWebAPI(WorkflowValue<string> sendMessageToWebAPIworkflow, WorkflowValue<string> sendMessageToWebAPIuRL = null, WorkflowValue<sendMessageToWebAPImethodInput> sendMessageToWebAPImethod = null, WorkflowValue<int> sendMessageToWebAPItimeoutInSeconds = null, WorkflowValue<string> sendMessageToWebAPIcontentType = null, WorkflowValue<string> sendMessageToWebAPIaccept = null, WorkflowValue<string> sendMessageToWebAPImessageBody = null, WorkflowValue<sendMessageToWebAPItransmitEncodingInput> sendMessageToWebAPItransmitEncoding = null, WorkflowValue<sendMessageToWebAPIresponseEncodingInput> sendMessageToWebAPIresponseEncoding = null, WorkflowValue<int> sendMessageToWebAPIbufferSize = null, WorkflowValue<sendMessageToWebAPIhTTPRequestHeadersListInputItem[]> sendMessageToWebAPIhTTPRequestHeadersList = null, WorkflowValue<bool> sendMessageToWebAPInegotiateTLS10 = null, WorkflowValue<bool> sendMessageToWebAPInegotiateTLS11 = null, WorkflowValue<bool> sendMessageToWebAPInegotiateTLS12 = null, WorkflowValue<bool> sendMessageToWebAPInegotiateTLS13 = null, WorkflowValue<bool> sendMessageToWebAPIkeepAlive = null, WorkflowValue<bool> sendMessageToWebAPIexpect100Continue = null, WorkflowValue<bool> sendMessageToWebAPIreturnResponseHeaders = null, WorkflowValue<bool> sendMessageToWebAPIrunAsThread = null, WorkflowValue<bool> sendMessageToWebAPIwaitForThread = null, WorkflowValue<int> sendMessageToWebAPIretrieveOutputDataFromThreadId = null)
        {
            WorkflowValue.Validate(sendMessageToWebAPIworkflow, nameof(sendMessageToWebAPIworkflow), required: true);
            WorkflowValue.Validate(sendMessageToWebAPIuRL, nameof(sendMessageToWebAPIuRL), required: false);
            WorkflowValue.Validate(sendMessageToWebAPImethod, nameof(sendMessageToWebAPImethod), required: false);
            WorkflowValue.Validate(sendMessageToWebAPItimeoutInSeconds, nameof(sendMessageToWebAPItimeoutInSeconds), required: false);
            WorkflowValue.Validate(sendMessageToWebAPIcontentType, nameof(sendMessageToWebAPIcontentType), required: false);
            WorkflowValue.Validate(sendMessageToWebAPIaccept, nameof(sendMessageToWebAPIaccept), required: false);
            WorkflowValue.Validate(sendMessageToWebAPImessageBody, nameof(sendMessageToWebAPImessageBody), required: false);
            WorkflowValue.Validate(sendMessageToWebAPItransmitEncoding, nameof(sendMessageToWebAPItransmitEncoding), required: false);
            WorkflowValue.Validate(sendMessageToWebAPIresponseEncoding, nameof(sendMessageToWebAPIresponseEncoding), required: false);
            WorkflowValue.Validate(sendMessageToWebAPIbufferSize, nameof(sendMessageToWebAPIbufferSize), required: false);
            WorkflowValue.Validate(sendMessageToWebAPIhTTPRequestHeadersList, nameof(sendMessageToWebAPIhTTPRequestHeadersList), required: false);
            WorkflowValue.Validate(sendMessageToWebAPInegotiateTLS10, nameof(sendMessageToWebAPInegotiateTLS10), required: false);
            WorkflowValue.Validate(sendMessageToWebAPInegotiateTLS11, nameof(sendMessageToWebAPInegotiateTLS11), required: false);
            WorkflowValue.Validate(sendMessageToWebAPInegotiateTLS12, nameof(sendMessageToWebAPInegotiateTLS12), required: false);
            WorkflowValue.Validate(sendMessageToWebAPInegotiateTLS13, nameof(sendMessageToWebAPInegotiateTLS13), required: false);
            WorkflowValue.Validate(sendMessageToWebAPIkeepAlive, nameof(sendMessageToWebAPIkeepAlive), required: false);
            WorkflowValue.Validate(sendMessageToWebAPIexpect100Continue, nameof(sendMessageToWebAPIexpect100Continue), required: false);
            WorkflowValue.Validate(sendMessageToWebAPIreturnResponseHeaders, nameof(sendMessageToWebAPIreturnResponseHeaders), required: false);
            WorkflowValue.Validate(sendMessageToWebAPIrunAsThread, nameof(sendMessageToWebAPIrunAsThread), required: false);
            WorkflowValue.Validate(sendMessageToWebAPIwaitForThread, nameof(sendMessageToWebAPIwaitForThread), required: false);
            WorkflowValue.Validate(sendMessageToWebAPIretrieveOutputDataFromThreadId, nameof(sendMessageToWebAPIretrieveOutputDataFromThreadId), required: false);
            return new DeferredBodyAction<SendMessageToWebAPIResponse>(() =>
            {
                var apiCallPath = "/Environment/SendMessageToWebAPI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendMessageToWebAPI = new JObject();
                var sendMessageToWebAPIpropCount = 0;
                if (sendMessageToWebAPIuRL != null)
                {
                    sendMessageToWebAPI["URL"] = ExpressionConverter.ConvertO(sendMessageToWebAPIuRL);
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPImethod != null)
                {
                    if (sendMessageToWebAPImethod != null)
                    {
                        sendMessageToWebAPI["Method"] = ExpressionConverter.ConvertO(sendMessageToWebAPImethod);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["Method"] = "GET";
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPItimeoutInSeconds != null)
                {
                    if (sendMessageToWebAPItimeoutInSeconds != null)
                    {
                        sendMessageToWebAPI["TimeoutInSeconds"] = ExpressionConverter.ConvertO(sendMessageToWebAPItimeoutInSeconds);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["TimeoutInSeconds"] = 20;
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPIcontentType != null)
                {
                    if (sendMessageToWebAPIcontentType != null)
                    {
                        sendMessageToWebAPI["ContentType"] = ExpressionConverter.ConvertO(sendMessageToWebAPIcontentType);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["ContentType"] = "application/json; charset=utf-8";
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPIaccept != null)
                {
                    if (sendMessageToWebAPIaccept != null)
                    {
                        sendMessageToWebAPI["Accept"] = ExpressionConverter.ConvertO(sendMessageToWebAPIaccept);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["Accept"] = "application/json";
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPImessageBody != null)
                {
                    sendMessageToWebAPI["MessageBody"] = ExpressionConverter.ConvertO(sendMessageToWebAPImessageBody);
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPItransmitEncoding != null)
                {
                    if (sendMessageToWebAPItransmitEncoding != null)
                    {
                        sendMessageToWebAPI["TransmitEncoding"] = ExpressionConverter.ConvertO(sendMessageToWebAPItransmitEncoding);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["TransmitEncoding"] = "UTF-8";
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPIresponseEncoding != null)
                {
                    if (sendMessageToWebAPIresponseEncoding != null)
                    {
                        sendMessageToWebAPI["ResponseEncoding"] = ExpressionConverter.ConvertO(sendMessageToWebAPIresponseEncoding);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["ResponseEncoding"] = "UTF-8";
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPIbufferSize != null)
                {
                    if (sendMessageToWebAPIbufferSize != null)
                    {
                        sendMessageToWebAPI["BufferSize"] = ExpressionConverter.ConvertO(sendMessageToWebAPIbufferSize);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["BufferSize"] = 16384;
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPIhTTPRequestHeadersList != null)
                {
                    sendMessageToWebAPI["HTTPRequestHeadersList"] = ExpressionConverter.ConvertO(sendMessageToWebAPIhTTPRequestHeadersList);
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPInegotiateTLS10 != null)
                {
                    if (sendMessageToWebAPInegotiateTLS10 != null)
                    {
                        sendMessageToWebAPI["NegotiateTLS10"] = ExpressionConverter.ConvertO(sendMessageToWebAPInegotiateTLS10);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["NegotiateTLS10"] = false;
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPInegotiateTLS11 != null)
                {
                    if (sendMessageToWebAPInegotiateTLS11 != null)
                    {
                        sendMessageToWebAPI["NegotiateTLS11"] = ExpressionConverter.ConvertO(sendMessageToWebAPInegotiateTLS11);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["NegotiateTLS11"] = false;
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPInegotiateTLS12 != null)
                {
                    if (sendMessageToWebAPInegotiateTLS12 != null)
                    {
                        sendMessageToWebAPI["NegotiateTLS12"] = ExpressionConverter.ConvertO(sendMessageToWebAPInegotiateTLS12);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["NegotiateTLS12"] = true;
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPInegotiateTLS13 != null)
                {
                    if (sendMessageToWebAPInegotiateTLS13 != null)
                    {
                        sendMessageToWebAPI["NegotiateTLS13"] = ExpressionConverter.ConvertO(sendMessageToWebAPInegotiateTLS13);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["NegotiateTLS13"] = false;
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPIkeepAlive != null)
                {
                    if (sendMessageToWebAPIkeepAlive != null)
                    {
                        sendMessageToWebAPI["KeepAlive"] = ExpressionConverter.ConvertO(sendMessageToWebAPIkeepAlive);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["KeepAlive"] = true;
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPIexpect100Continue != null)
                {
                    if (sendMessageToWebAPIexpect100Continue != null)
                    {
                        sendMessageToWebAPI["Expect100Continue"] = ExpressionConverter.ConvertO(sendMessageToWebAPIexpect100Continue);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["Expect100Continue"] = false;
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPIreturnResponseHeaders != null)
                {
                    if (sendMessageToWebAPIreturnResponseHeaders != null)
                    {
                        sendMessageToWebAPI["ReturnResponseHeaders"] = ExpressionConverter.ConvertO(sendMessageToWebAPIreturnResponseHeaders);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["ReturnResponseHeaders"] = false;
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPIrunAsThread != null)
                {
                    if (sendMessageToWebAPIrunAsThread != null)
                    {
                        sendMessageToWebAPI["RunAsThread"] = ExpressionConverter.ConvertO(sendMessageToWebAPIrunAsThread);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["RunAsThread"] = true;
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPIwaitForThread != null)
                {
                    if (sendMessageToWebAPIwaitForThread != null)
                    {
                        sendMessageToWebAPI["WaitForThread"] = ExpressionConverter.ConvertO(sendMessageToWebAPIwaitForThread);
                        sendMessageToWebAPIpropCount++;
                    }

                    sendMessageToWebAPIpropCount++;
                }
                else
                {
                    sendMessageToWebAPI["WaitForThread"] = true;
                    sendMessageToWebAPIpropCount++;
                }

                if (sendMessageToWebAPIretrieveOutputDataFromThreadId != null)
                {
                    sendMessageToWebAPI["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(sendMessageToWebAPIretrieveOutputDataFromThreadId);
                    sendMessageToWebAPIpropCount++;
                }

                sendMessageToWebAPIpropCount++;
                sendMessageToWebAPI["Workflow"] = ExpressionConverter.ConvertO(sendMessageToWebAPIworkflow);
                if (sendMessageToWebAPIpropCount > 0)
                {
                    callPayload.Body = sendMessageToWebAPI;
                }

                return new ApiConnectionAction<SendMessageToWebAPIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildTasksAddNewTask))]
        public IBodyWorkflowAction<TasksAddNewTaskResponse> TasksAddNewTask([WorkflowExpression] Func<string> tasksAddNewTaskworkflow, [WorkflowExpression] Func<tasksAddNewTasksetAutomationNameInput> tasksAddNewTasksetAutomationName = null, [WorkflowExpression] Func<string> tasksAddNewTaskautomationName = null, [WorkflowExpression] Func<string> tasksAddNewTasktaskInputData = null, [WorkflowExpression] Func<string> tasksAddNewTaskprocessStage = null, [WorkflowExpression] Func<int> tasksAddNewTaskpriority = null, [WorkflowExpression] Func<int> tasksAddNewTasksLA = null, [WorkflowExpression] Func<bool> tasksAddNewTasktaskOnHold = null, [WorkflowExpression] Func<string> tasksAddNewTaskorganisation = null, [WorkflowExpression] Func<string> tasksAddNewTaskdepartment = null, [WorkflowExpression] Func<string> tasksAddNewTaskdescription = null, [WorkflowExpression] Func<string> tasksAddNewTasktags = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksAddNewTaskResponse> __BuildTasksAddNewTask(WorkflowValue<string> tasksAddNewTaskworkflow, WorkflowValue<tasksAddNewTasksetAutomationNameInput> tasksAddNewTasksetAutomationName = null, WorkflowValue<string> tasksAddNewTaskautomationName = null, WorkflowValue<string> tasksAddNewTasktaskInputData = null, WorkflowValue<string> tasksAddNewTaskprocessStage = null, WorkflowValue<int> tasksAddNewTaskpriority = null, WorkflowValue<int> tasksAddNewTasksLA = null, WorkflowValue<bool> tasksAddNewTasktaskOnHold = null, WorkflowValue<string> tasksAddNewTaskorganisation = null, WorkflowValue<string> tasksAddNewTaskdepartment = null, WorkflowValue<string> tasksAddNewTaskdescription = null, WorkflowValue<string> tasksAddNewTasktags = null)
        {
            WorkflowValue.Validate(tasksAddNewTaskworkflow, nameof(tasksAddNewTaskworkflow), required: true);
            WorkflowValue.Validate(tasksAddNewTasksetAutomationName, nameof(tasksAddNewTasksetAutomationName), required: false);
            WorkflowValue.Validate(tasksAddNewTaskautomationName, nameof(tasksAddNewTaskautomationName), required: false);
            WorkflowValue.Validate(tasksAddNewTasktaskInputData, nameof(tasksAddNewTasktaskInputData), required: false);
            WorkflowValue.Validate(tasksAddNewTaskprocessStage, nameof(tasksAddNewTaskprocessStage), required: false);
            WorkflowValue.Validate(tasksAddNewTaskpriority, nameof(tasksAddNewTaskpriority), required: false);
            WorkflowValue.Validate(tasksAddNewTasksLA, nameof(tasksAddNewTasksLA), required: false);
            WorkflowValue.Validate(tasksAddNewTasktaskOnHold, nameof(tasksAddNewTasktaskOnHold), required: false);
            WorkflowValue.Validate(tasksAddNewTaskorganisation, nameof(tasksAddNewTaskorganisation), required: false);
            WorkflowValue.Validate(tasksAddNewTaskdepartment, nameof(tasksAddNewTaskdepartment), required: false);
            WorkflowValue.Validate(tasksAddNewTaskdescription, nameof(tasksAddNewTaskdescription), required: false);
            WorkflowValue.Validate(tasksAddNewTasktags, nameof(tasksAddNewTasktags), required: false);
            return new DeferredBodyAction<TasksAddNewTaskResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNewTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksAddNewTask = new JObject();
                var tasksAddNewTaskpropCount = 0;
                if (tasksAddNewTasksetAutomationName != null)
                {
                    if (tasksAddNewTasksetAutomationName != null)
                    {
                        tasksAddNewTask["SetAutomationName"] = ExpressionConverter.ConvertO(tasksAddNewTasksetAutomationName);
                        tasksAddNewTaskpropCount++;
                    }

                    tasksAddNewTaskpropCount++;
                }
                else
                {
                    tasksAddNewTask["SetAutomationName"] = "Auto";
                    tasksAddNewTaskpropCount++;
                }

                if (tasksAddNewTaskautomationName != null)
                {
                    tasksAddNewTask["AutomationName"] = ExpressionConverter.ConvertO(tasksAddNewTaskautomationName);
                    tasksAddNewTaskpropCount++;
                }

                if (tasksAddNewTasktaskInputData != null)
                {
                    tasksAddNewTask["TaskInputData"] = ExpressionConverter.ConvertO(tasksAddNewTasktaskInputData);
                    tasksAddNewTaskpropCount++;
                }

                if (tasksAddNewTaskprocessStage != null)
                {
                    tasksAddNewTask["ProcessStage"] = ExpressionConverter.ConvertO(tasksAddNewTaskprocessStage);
                    tasksAddNewTaskpropCount++;
                }

                if (tasksAddNewTaskpriority != null)
                {
                    if (tasksAddNewTaskpriority != null)
                    {
                        tasksAddNewTask["Priority"] = ExpressionConverter.ConvertO(tasksAddNewTaskpriority);
                        tasksAddNewTaskpropCount++;
                    }

                    tasksAddNewTaskpropCount++;
                }
                else
                {
                    tasksAddNewTask["Priority"] = 3;
                    tasksAddNewTaskpropCount++;
                }

                if (tasksAddNewTasksLA != null)
                {
                    tasksAddNewTask["SLA"] = ExpressionConverter.ConvertO(tasksAddNewTasksLA);
                    tasksAddNewTaskpropCount++;
                }

                if (tasksAddNewTasktaskOnHold != null)
                {
                    if (tasksAddNewTasktaskOnHold != null)
                    {
                        tasksAddNewTask["TaskOnHold"] = ExpressionConverter.ConvertO(tasksAddNewTasktaskOnHold);
                        tasksAddNewTaskpropCount++;
                    }

                    tasksAddNewTaskpropCount++;
                }
                else
                {
                    tasksAddNewTask["TaskOnHold"] = false;
                    tasksAddNewTaskpropCount++;
                }

                if (tasksAddNewTaskorganisation != null)
                {
                    tasksAddNewTask["Organisation"] = ExpressionConverter.ConvertO(tasksAddNewTaskorganisation);
                    tasksAddNewTaskpropCount++;
                }

                if (tasksAddNewTaskdepartment != null)
                {
                    tasksAddNewTask["Department"] = ExpressionConverter.ConvertO(tasksAddNewTaskdepartment);
                    tasksAddNewTaskpropCount++;
                }

                if (tasksAddNewTaskdescription != null)
                {
                    tasksAddNewTask["Description"] = ExpressionConverter.ConvertO(tasksAddNewTaskdescription);
                    tasksAddNewTaskpropCount++;
                }

                if (tasksAddNewTasktags != null)
                {
                    tasksAddNewTask["Tags"] = ExpressionConverter.ConvertO(tasksAddNewTasktags);
                    tasksAddNewTaskpropCount++;
                }

                tasksAddNewTaskpropCount++;
                tasksAddNewTask["Workflow"] = ExpressionConverter.ConvertO(tasksAddNewTaskworkflow);
                if (tasksAddNewTaskpropCount > 0)
                {
                    callPayload.Body = tasksAddNewTask;
                }

                return new ApiConnectionAction<TasksAddNewTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildTasksAddNewDeferral))]
        public IBodyWorkflowAction<TasksAddNewDeferralResponse> TasksAddNewDeferral([WorkflowExpression] Func<string> tasksAddNewDeferralworkflow, [WorkflowExpression] Func<tasksAddNewDeferralsetAutomationNameInput> tasksAddNewDeferralsetAutomationName = null, [WorkflowExpression] Func<string> tasksAddNewDeferralautomationName = null, [WorkflowExpression] Func<int> tasksAddNewDeferraldeferralTimeInMinutes = null, [WorkflowExpression] Func<string> tasksAddNewDeferraltaskInputData = null, [WorkflowExpression] Func<string> tasksAddNewDeferraldeferralStoredData = null, [WorkflowExpression] Func<string> tasksAddNewDeferralprocessStage = null, [WorkflowExpression] Func<int> tasksAddNewDeferralpriority = null, [WorkflowExpression] Func<bool> tasksAddNewDeferraltaskOnHold = null, [WorkflowExpression] Func<string> tasksAddNewDeferralorganisation = null, [WorkflowExpression] Func<string> tasksAddNewDeferraldepartment = null, [WorkflowExpression] Func<string> tasksAddNewDeferraldescription = null, [WorkflowExpression] Func<string> tasksAddNewDeferraltags = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksAddNewDeferralResponse> __BuildTasksAddNewDeferral(WorkflowValue<string> tasksAddNewDeferralworkflow, WorkflowValue<tasksAddNewDeferralsetAutomationNameInput> tasksAddNewDeferralsetAutomationName = null, WorkflowValue<string> tasksAddNewDeferralautomationName = null, WorkflowValue<int> tasksAddNewDeferraldeferralTimeInMinutes = null, WorkflowValue<string> tasksAddNewDeferraltaskInputData = null, WorkflowValue<string> tasksAddNewDeferraldeferralStoredData = null, WorkflowValue<string> tasksAddNewDeferralprocessStage = null, WorkflowValue<int> tasksAddNewDeferralpriority = null, WorkflowValue<bool> tasksAddNewDeferraltaskOnHold = null, WorkflowValue<string> tasksAddNewDeferralorganisation = null, WorkflowValue<string> tasksAddNewDeferraldepartment = null, WorkflowValue<string> tasksAddNewDeferraldescription = null, WorkflowValue<string> tasksAddNewDeferraltags = null)
        {
            WorkflowValue.Validate(tasksAddNewDeferralworkflow, nameof(tasksAddNewDeferralworkflow), required: true);
            WorkflowValue.Validate(tasksAddNewDeferralsetAutomationName, nameof(tasksAddNewDeferralsetAutomationName), required: false);
            WorkflowValue.Validate(tasksAddNewDeferralautomationName, nameof(tasksAddNewDeferralautomationName), required: false);
            WorkflowValue.Validate(tasksAddNewDeferraldeferralTimeInMinutes, nameof(tasksAddNewDeferraldeferralTimeInMinutes), required: false);
            WorkflowValue.Validate(tasksAddNewDeferraltaskInputData, nameof(tasksAddNewDeferraltaskInputData), required: false);
            WorkflowValue.Validate(tasksAddNewDeferraldeferralStoredData, nameof(tasksAddNewDeferraldeferralStoredData), required: false);
            WorkflowValue.Validate(tasksAddNewDeferralprocessStage, nameof(tasksAddNewDeferralprocessStage), required: false);
            WorkflowValue.Validate(tasksAddNewDeferralpriority, nameof(tasksAddNewDeferralpriority), required: false);
            WorkflowValue.Validate(tasksAddNewDeferraltaskOnHold, nameof(tasksAddNewDeferraltaskOnHold), required: false);
            WorkflowValue.Validate(tasksAddNewDeferralorganisation, nameof(tasksAddNewDeferralorganisation), required: false);
            WorkflowValue.Validate(tasksAddNewDeferraldepartment, nameof(tasksAddNewDeferraldepartment), required: false);
            WorkflowValue.Validate(tasksAddNewDeferraldescription, nameof(tasksAddNewDeferraldescription), required: false);
            WorkflowValue.Validate(tasksAddNewDeferraltags, nameof(tasksAddNewDeferraltags), required: false);
            return new DeferredBodyAction<TasksAddNewDeferralResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNewDeferral";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksAddNewDeferral = new JObject();
                var tasksAddNewDeferralpropCount = 0;
                if (tasksAddNewDeferralsetAutomationName != null)
                {
                    if (tasksAddNewDeferralsetAutomationName != null)
                    {
                        tasksAddNewDeferral["SetAutomationName"] = ExpressionConverter.ConvertO(tasksAddNewDeferralsetAutomationName);
                        tasksAddNewDeferralpropCount++;
                    }

                    tasksAddNewDeferralpropCount++;
                }
                else
                {
                    tasksAddNewDeferral["SetAutomationName"] = "Auto";
                    tasksAddNewDeferralpropCount++;
                }

                if (tasksAddNewDeferralautomationName != null)
                {
                    tasksAddNewDeferral["AutomationName"] = ExpressionConverter.ConvertO(tasksAddNewDeferralautomationName);
                    tasksAddNewDeferralpropCount++;
                }

                if (tasksAddNewDeferraldeferralTimeInMinutes != null)
                {
                    tasksAddNewDeferral["DeferralTimeInMinutes"] = ExpressionConverter.ConvertO(tasksAddNewDeferraldeferralTimeInMinutes);
                    tasksAddNewDeferralpropCount++;
                }

                if (tasksAddNewDeferraltaskInputData != null)
                {
                    tasksAddNewDeferral["TaskInputData"] = ExpressionConverter.ConvertO(tasksAddNewDeferraltaskInputData);
                    tasksAddNewDeferralpropCount++;
                }

                if (tasksAddNewDeferraldeferralStoredData != null)
                {
                    tasksAddNewDeferral["DeferralStoredData"] = ExpressionConverter.ConvertO(tasksAddNewDeferraldeferralStoredData);
                    tasksAddNewDeferralpropCount++;
                }

                if (tasksAddNewDeferralprocessStage != null)
                {
                    tasksAddNewDeferral["ProcessStage"] = ExpressionConverter.ConvertO(tasksAddNewDeferralprocessStage);
                    tasksAddNewDeferralpropCount++;
                }

                if (tasksAddNewDeferralpriority != null)
                {
                    if (tasksAddNewDeferralpriority != null)
                    {
                        tasksAddNewDeferral["Priority"] = ExpressionConverter.ConvertO(tasksAddNewDeferralpriority);
                        tasksAddNewDeferralpropCount++;
                    }

                    tasksAddNewDeferralpropCount++;
                }
                else
                {
                    tasksAddNewDeferral["Priority"] = 3;
                    tasksAddNewDeferralpropCount++;
                }

                if (tasksAddNewDeferraltaskOnHold != null)
                {
                    if (tasksAddNewDeferraltaskOnHold != null)
                    {
                        tasksAddNewDeferral["TaskOnHold"] = ExpressionConverter.ConvertO(tasksAddNewDeferraltaskOnHold);
                        tasksAddNewDeferralpropCount++;
                    }

                    tasksAddNewDeferralpropCount++;
                }
                else
                {
                    tasksAddNewDeferral["TaskOnHold"] = false;
                    tasksAddNewDeferralpropCount++;
                }

                if (tasksAddNewDeferralorganisation != null)
                {
                    tasksAddNewDeferral["Organisation"] = ExpressionConverter.ConvertO(tasksAddNewDeferralorganisation);
                    tasksAddNewDeferralpropCount++;
                }

                if (tasksAddNewDeferraldepartment != null)
                {
                    tasksAddNewDeferral["Department"] = ExpressionConverter.ConvertO(tasksAddNewDeferraldepartment);
                    tasksAddNewDeferralpropCount++;
                }

                if (tasksAddNewDeferraldescription != null)
                {
                    tasksAddNewDeferral["Description"] = ExpressionConverter.ConvertO(tasksAddNewDeferraldescription);
                    tasksAddNewDeferralpropCount++;
                }

                if (tasksAddNewDeferraltags != null)
                {
                    tasksAddNewDeferral["Tags"] = ExpressionConverter.ConvertO(tasksAddNewDeferraltags);
                    tasksAddNewDeferralpropCount++;
                }

                tasksAddNewDeferralpropCount++;
                tasksAddNewDeferral["Workflow"] = ExpressionConverter.ConvertO(tasksAddNewDeferralworkflow);
                if (tasksAddNewDeferralpropCount > 0)
                {
                    callPayload.Body = tasksAddNewDeferral;
                }

                return new ApiConnectionAction<TasksAddNewDeferralResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildTasksDeferExistingTask))]
        public IBodyWorkflowAction<TasksDeferExistingTaskResponse> TasksDeferExistingTask([WorkflowExpression] Func<int> tasksDeferExistingTasktaskId, [WorkflowExpression] Func<int> tasksDeferExistingTaskdeferralTimeInMinutes = null, [WorkflowExpression] Func<string> tasksDeferExistingTaskdeferralStoredData = null, [WorkflowExpression] Func<string> tasksDeferExistingTaskprocessStage = null, [WorkflowExpression] Func<int> tasksDeferExistingTaskpriority = null, [WorkflowExpression] Func<bool> tasksDeferExistingTasktaskOnHold = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksDeferExistingTaskResponse> __BuildTasksDeferExistingTask(WorkflowValue<int> tasksDeferExistingTasktaskId, WorkflowValue<int> tasksDeferExistingTaskdeferralTimeInMinutes = null, WorkflowValue<string> tasksDeferExistingTaskdeferralStoredData = null, WorkflowValue<string> tasksDeferExistingTaskprocessStage = null, WorkflowValue<int> tasksDeferExistingTaskpriority = null, WorkflowValue<bool> tasksDeferExistingTasktaskOnHold = null)
        {
            WorkflowValue.Validate(tasksDeferExistingTasktaskId, nameof(tasksDeferExistingTasktaskId), required: true);
            WorkflowValue.Validate(tasksDeferExistingTaskdeferralTimeInMinutes, nameof(tasksDeferExistingTaskdeferralTimeInMinutes), required: false);
            WorkflowValue.Validate(tasksDeferExistingTaskdeferralStoredData, nameof(tasksDeferExistingTaskdeferralStoredData), required: false);
            WorkflowValue.Validate(tasksDeferExistingTaskprocessStage, nameof(tasksDeferExistingTaskprocessStage), required: false);
            WorkflowValue.Validate(tasksDeferExistingTaskpriority, nameof(tasksDeferExistingTaskpriority), required: false);
            WorkflowValue.Validate(tasksDeferExistingTasktaskOnHold, nameof(tasksDeferExistingTasktaskOnHold), required: false);
            return new DeferredBodyAction<TasksDeferExistingTaskResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksDeferExistingTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksDeferExistingTask = new JObject();
                var tasksDeferExistingTaskpropCount = 0;
                tasksDeferExistingTaskpropCount++;
                tasksDeferExistingTask["TaskId"] = ExpressionConverter.ConvertO(tasksDeferExistingTasktaskId);
                if (tasksDeferExistingTaskdeferralTimeInMinutes != null)
                {
                    tasksDeferExistingTask["DeferralTimeInMinutes"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskdeferralTimeInMinutes);
                    tasksDeferExistingTaskpropCount++;
                }

                if (tasksDeferExistingTaskdeferralStoredData != null)
                {
                    tasksDeferExistingTask["DeferralStoredData"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskdeferralStoredData);
                    tasksDeferExistingTaskpropCount++;
                }

                if (tasksDeferExistingTaskprocessStage != null)
                {
                    tasksDeferExistingTask["ProcessStage"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskprocessStage);
                    tasksDeferExistingTaskpropCount++;
                }

                if (tasksDeferExistingTaskpriority != null)
                {
                    if (tasksDeferExistingTaskpriority != null)
                    {
                        tasksDeferExistingTask["Priority"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskpriority);
                        tasksDeferExistingTaskpropCount++;
                    }

                    tasksDeferExistingTaskpropCount++;
                }
                else
                {
                    tasksDeferExistingTask["Priority"] = 3;
                    tasksDeferExistingTaskpropCount++;
                }

                if (tasksDeferExistingTasktaskOnHold != null)
                {
                    if (tasksDeferExistingTasktaskOnHold != null)
                    {
                        tasksDeferExistingTask["TaskOnHold"] = ExpressionConverter.ConvertO(tasksDeferExistingTasktaskOnHold);
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
        [WorkflowExpressionFactory(nameof(__BuildTasksDeferExistingTaskOperation))]
        public IBodyWorkflowAction<TasksDeferExistingTaskOperationResponse> TasksDeferExistingTaskOperation([WorkflowExpression] Func<string> tasksDeferExistingTaskOperationoperationId, [WorkflowExpression] Func<int> tasksDeferExistingTaskOperationdeferralTimeInMinutes = null, [WorkflowExpression] Func<string> tasksDeferExistingTaskOperationdeferralStoredData = null, [WorkflowExpression] Func<string> tasksDeferExistingTaskOperationprocessStage = null, [WorkflowExpression] Func<int> tasksDeferExistingTaskOperationpriority = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksDeferExistingTaskOperationResponse> __BuildTasksDeferExistingTaskOperation(WorkflowValue<string> tasksDeferExistingTaskOperationoperationId, WorkflowValue<int> tasksDeferExistingTaskOperationdeferralTimeInMinutes = null, WorkflowValue<string> tasksDeferExistingTaskOperationdeferralStoredData = null, WorkflowValue<string> tasksDeferExistingTaskOperationprocessStage = null, WorkflowValue<int> tasksDeferExistingTaskOperationpriority = null)
        {
            WorkflowValue.Validate(tasksDeferExistingTaskOperationoperationId, nameof(tasksDeferExistingTaskOperationoperationId), required: true);
            WorkflowValue.Validate(tasksDeferExistingTaskOperationdeferralTimeInMinutes, nameof(tasksDeferExistingTaskOperationdeferralTimeInMinutes), required: false);
            WorkflowValue.Validate(tasksDeferExistingTaskOperationdeferralStoredData, nameof(tasksDeferExistingTaskOperationdeferralStoredData), required: false);
            WorkflowValue.Validate(tasksDeferExistingTaskOperationprocessStage, nameof(tasksDeferExistingTaskOperationprocessStage), required: false);
            WorkflowValue.Validate(tasksDeferExistingTaskOperationpriority, nameof(tasksDeferExistingTaskOperationpriority), required: false);
            return new DeferredBodyAction<TasksDeferExistingTaskOperationResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksDeferExistingTaskOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksDeferExistingTaskOperation = new JObject();
                var tasksDeferExistingTaskOperationpropCount = 0;
                tasksDeferExistingTaskOperationpropCount++;
                tasksDeferExistingTaskOperation["OperationId"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskOperationoperationId);
                if (tasksDeferExistingTaskOperationdeferralTimeInMinutes != null)
                {
                    tasksDeferExistingTaskOperation["DeferralTimeInMinutes"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskOperationdeferralTimeInMinutes);
                    tasksDeferExistingTaskOperationpropCount++;
                }

                if (tasksDeferExistingTaskOperationdeferralStoredData != null)
                {
                    tasksDeferExistingTaskOperation["DeferralStoredData"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskOperationdeferralStoredData);
                    tasksDeferExistingTaskOperationpropCount++;
                }

                if (tasksDeferExistingTaskOperationprocessStage != null)
                {
                    tasksDeferExistingTaskOperation["ProcessStage"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskOperationprocessStage);
                    tasksDeferExistingTaskOperationpropCount++;
                }

                if (tasksDeferExistingTaskOperationpriority != null)
                {
                    if (tasksDeferExistingTaskOperationpriority != null)
                    {
                        tasksDeferExistingTaskOperation["Priority"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskOperationpriority);
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
        [WorkflowExpressionFactory(nameof(__BuildTasksDeleteTask))]
        public IBodyWorkflowAction<TasksDeleteTaskResponse> TasksDeleteTask([WorkflowExpression] Func<int> tasksDeleteTasktaskId, [WorkflowExpression] Func<bool> tasksDeleteTaskupdateSourceSystem = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksDeleteTaskResponse> __BuildTasksDeleteTask(WorkflowValue<int> tasksDeleteTasktaskId, WorkflowValue<bool> tasksDeleteTaskupdateSourceSystem = null)
        {
            WorkflowValue.Validate(tasksDeleteTasktaskId, nameof(tasksDeleteTasktaskId), required: true);
            WorkflowValue.Validate(tasksDeleteTaskupdateSourceSystem, nameof(tasksDeleteTaskupdateSourceSystem), required: false);
            return new DeferredBodyAction<TasksDeleteTaskResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksDeleteTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksDeleteTask = new JObject();
                var tasksDeleteTaskpropCount = 0;
                tasksDeleteTaskpropCount++;
                tasksDeleteTask["TaskId"] = ExpressionConverter.ConvertO(tasksDeleteTasktaskId);
                if (tasksDeleteTaskupdateSourceSystem != null)
                {
                    if (tasksDeleteTaskupdateSourceSystem != null)
                    {
                        tasksDeleteTask["UpdateSourceSystem"] = ExpressionConverter.ConvertO(tasksDeleteTaskupdateSourceSystem);
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
        [WorkflowExpressionFactory(nameof(__BuildTasksDeleteTaskOperation))]
        public IBodyWorkflowAction<TasksDeleteTaskOperationResponse> TasksDeleteTaskOperation([WorkflowExpression] Func<string> tasksDeleteTaskOperationoperationId, [WorkflowExpression] Func<bool> tasksDeleteTaskOperationupdateSourceSystem = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksDeleteTaskOperationResponse> __BuildTasksDeleteTaskOperation(WorkflowValue<string> tasksDeleteTaskOperationoperationId, WorkflowValue<bool> tasksDeleteTaskOperationupdateSourceSystem = null)
        {
            WorkflowValue.Validate(tasksDeleteTaskOperationoperationId, nameof(tasksDeleteTaskOperationoperationId), required: true);
            WorkflowValue.Validate(tasksDeleteTaskOperationupdateSourceSystem, nameof(tasksDeleteTaskOperationupdateSourceSystem), required: false);
            return new DeferredBodyAction<TasksDeleteTaskOperationResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksDeleteTaskOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksDeleteTaskOperation = new JObject();
                var tasksDeleteTaskOperationpropCount = 0;
                tasksDeleteTaskOperationpropCount++;
                tasksDeleteTaskOperation["OperationId"] = ExpressionConverter.ConvertO(tasksDeleteTaskOperationoperationId);
                if (tasksDeleteTaskOperationupdateSourceSystem != null)
                {
                    if (tasksDeleteTaskOperationupdateSourceSystem != null)
                    {
                        tasksDeleteTaskOperation["UpdateSourceSystem"] = ExpressionConverter.ConvertO(tasksDeleteTaskOperationupdateSourceSystem);
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
        [WorkflowExpressionFactory(nameof(__BuildTasksGetAllTasks))]
        public IBodyWorkflowAction<TasksGetAllTasksResponse> TasksGetAllTasks([WorkflowExpression] Func<string> tasksGetAllTasksautomationName = null, [WorkflowExpression] Func<tasksGetAllTasksautomationTaskStatusInput> tasksGetAllTasksautomationTaskStatus = null, [WorkflowExpression] Func<string> tasksGetAllTasksfilterByPropertyQuery = null, [WorkflowExpression] Func<int> tasksGetAllTasksminutesUntilDeferralDate = null, [WorkflowExpression] Func<int> tasksGetAllTasksminimumPriorityLevel = null, [WorkflowExpression] Func<bool> tasksGetAllTaskssortByDeferralDate = null, [WorkflowExpression] Func<bool> tasksGetAllTasksretrieveOnHoldTasks = null, [WorkflowExpression] Func<int> tasksGetAllTasksskip = null, [WorkflowExpression] Func<int> tasksGetAllTasksmaxResults = null, [WorkflowExpression] Func<bool> tasksGetAllTasksexcludeTaskData = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksGetAllTasksResponse> __BuildTasksGetAllTasks(WorkflowValue<string> tasksGetAllTasksautomationName = null, WorkflowValue<tasksGetAllTasksautomationTaskStatusInput> tasksGetAllTasksautomationTaskStatus = null, WorkflowValue<string> tasksGetAllTasksfilterByPropertyQuery = null, WorkflowValue<int> tasksGetAllTasksminutesUntilDeferralDate = null, WorkflowValue<int> tasksGetAllTasksminimumPriorityLevel = null, WorkflowValue<bool> tasksGetAllTaskssortByDeferralDate = null, WorkflowValue<bool> tasksGetAllTasksretrieveOnHoldTasks = null, WorkflowValue<int> tasksGetAllTasksskip = null, WorkflowValue<int> tasksGetAllTasksmaxResults = null, WorkflowValue<bool> tasksGetAllTasksexcludeTaskData = null)
        {
            WorkflowValue.Validate(tasksGetAllTasksautomationName, nameof(tasksGetAllTasksautomationName), required: false);
            WorkflowValue.Validate(tasksGetAllTasksautomationTaskStatus, nameof(tasksGetAllTasksautomationTaskStatus), required: false);
            WorkflowValue.Validate(tasksGetAllTasksfilterByPropertyQuery, nameof(tasksGetAllTasksfilterByPropertyQuery), required: false);
            WorkflowValue.Validate(tasksGetAllTasksminutesUntilDeferralDate, nameof(tasksGetAllTasksminutesUntilDeferralDate), required: false);
            WorkflowValue.Validate(tasksGetAllTasksminimumPriorityLevel, nameof(tasksGetAllTasksminimumPriorityLevel), required: false);
            WorkflowValue.Validate(tasksGetAllTaskssortByDeferralDate, nameof(tasksGetAllTaskssortByDeferralDate), required: false);
            WorkflowValue.Validate(tasksGetAllTasksretrieveOnHoldTasks, nameof(tasksGetAllTasksretrieveOnHoldTasks), required: false);
            WorkflowValue.Validate(tasksGetAllTasksskip, nameof(tasksGetAllTasksskip), required: false);
            WorkflowValue.Validate(tasksGetAllTasksmaxResults, nameof(tasksGetAllTasksmaxResults), required: false);
            WorkflowValue.Validate(tasksGetAllTasksexcludeTaskData, nameof(tasksGetAllTasksexcludeTaskData), required: false);
            return new DeferredBodyAction<TasksGetAllTasksResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksGetAllTasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksGetAllTasks = new JObject();
                var tasksGetAllTaskspropCount = 0;
                if (tasksGetAllTasksautomationName != null)
                {
                    tasksGetAllTasks["AutomationName"] = ExpressionConverter.ConvertO(tasksGetAllTasksautomationName);
                    tasksGetAllTaskspropCount++;
                }

                if (tasksGetAllTasksautomationTaskStatus != null)
                {
                    tasksGetAllTasks["AutomationTaskStatus"] = ExpressionConverter.ConvertO(tasksGetAllTasksautomationTaskStatus);
                    tasksGetAllTaskspropCount++;
                }

                if (tasksGetAllTasksfilterByPropertyQuery != null)
                {
                    tasksGetAllTasks["FilterByPropertyQuery"] = ExpressionConverter.ConvertO(tasksGetAllTasksfilterByPropertyQuery);
                    tasksGetAllTaskspropCount++;
                }

                if (tasksGetAllTasksminutesUntilDeferralDate != null)
                {
                    tasksGetAllTasks["MinutesUntilDeferralDate"] = ExpressionConverter.ConvertO(tasksGetAllTasksminutesUntilDeferralDate);
                    tasksGetAllTaskspropCount++;
                }

                if (tasksGetAllTasksminimumPriorityLevel != null)
                {
                    tasksGetAllTasks["MinimumPriorityLevel"] = ExpressionConverter.ConvertO(tasksGetAllTasksminimumPriorityLevel);
                    tasksGetAllTaskspropCount++;
                }

                if (tasksGetAllTaskssortByDeferralDate != null)
                {
                    if (tasksGetAllTaskssortByDeferralDate != null)
                    {
                        tasksGetAllTasks["SortByDeferralDate"] = ExpressionConverter.ConvertO(tasksGetAllTaskssortByDeferralDate);
                        tasksGetAllTaskspropCount++;
                    }

                    tasksGetAllTaskspropCount++;
                }
                else
                {
                    tasksGetAllTasks["SortByDeferralDate"] = false;
                    tasksGetAllTaskspropCount++;
                }

                if (tasksGetAllTasksretrieveOnHoldTasks != null)
                {
                    if (tasksGetAllTasksretrieveOnHoldTasks != null)
                    {
                        tasksGetAllTasks["RetrieveOnHoldTasks"] = ExpressionConverter.ConvertO(tasksGetAllTasksretrieveOnHoldTasks);
                        tasksGetAllTaskspropCount++;
                    }

                    tasksGetAllTaskspropCount++;
                }
                else
                {
                    tasksGetAllTasks["RetrieveOnHoldTasks"] = true;
                    tasksGetAllTaskspropCount++;
                }

                if (tasksGetAllTasksskip != null)
                {
                    if (tasksGetAllTasksskip != null)
                    {
                        tasksGetAllTasks["Skip"] = ExpressionConverter.ConvertO(tasksGetAllTasksskip);
                        tasksGetAllTaskspropCount++;
                    }

                    tasksGetAllTaskspropCount++;
                }
                else
                {
                    tasksGetAllTasks["Skip"] = 0;
                    tasksGetAllTaskspropCount++;
                }

                if (tasksGetAllTasksmaxResults != null)
                {
                    if (tasksGetAllTasksmaxResults != null)
                    {
                        tasksGetAllTasks["MaxResults"] = ExpressionConverter.ConvertO(tasksGetAllTasksmaxResults);
                        tasksGetAllTaskspropCount++;
                    }

                    tasksGetAllTaskspropCount++;
                }
                else
                {
                    tasksGetAllTasks["MaxResults"] = 0;
                    tasksGetAllTaskspropCount++;
                }

                if (tasksGetAllTasksexcludeTaskData != null)
                {
                    if (tasksGetAllTasksexcludeTaskData != null)
                    {
                        tasksGetAllTasks["ExcludeTaskData"] = ExpressionConverter.ConvertO(tasksGetAllTasksexcludeTaskData);
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
        [WorkflowExpressionFactory(nameof(__BuildTasksGetTask))]
        public IBodyWorkflowAction<TasksGetTaskResponse> TasksGetTask([WorkflowExpression] Func<int> tasksGetTasktaskId, [WorkflowExpression] Func<tasksGetTaskstatusChangeInput> tasksGetTaskstatusChange = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksGetTaskResponse> __BuildTasksGetTask(WorkflowValue<int> tasksGetTasktaskId, WorkflowValue<tasksGetTaskstatusChangeInput> tasksGetTaskstatusChange = null)
        {
            WorkflowValue.Validate(tasksGetTasktaskId, nameof(tasksGetTasktaskId), required: true);
            WorkflowValue.Validate(tasksGetTaskstatusChange, nameof(tasksGetTaskstatusChange), required: false);
            return new DeferredBodyAction<TasksGetTaskResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksGetTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksGetTask = new JObject();
                var tasksGetTaskpropCount = 0;
                tasksGetTaskpropCount++;
                tasksGetTask["TaskId"] = ExpressionConverter.ConvertO(tasksGetTasktaskId);
                if (tasksGetTaskstatusChange != null)
                {
                    if (tasksGetTaskstatusChange != null)
                    {
                        tasksGetTask["StatusChange"] = ExpressionConverter.ConvertO(tasksGetTaskstatusChange);
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
        [WorkflowExpressionFactory(nameof(__BuildTasksGetNextTask))]
        public IBodyWorkflowAction<TasksGetNextTaskResponse> TasksGetNextTask([WorkflowExpression] Func<string> tasksGetNextTaskautomationName = null, [WorkflowExpression] Func<string[]> tasksGetNextTaskautomationNames = null, [WorkflowExpression] Func<int> tasksGetNextTaskminimumPriorityLevel = null, [WorkflowExpression] Func<tasksGetNextTaskstatusChangeInput> tasksGetNextTaskstatusChange = null, [WorkflowExpression] Func<int> tasksGetNextTaskminutesUntilDeferralDate = null, [WorkflowExpression] Func<bool> tasksGetNextTaskignoreSLA = null, [WorkflowExpression] Func<int[]> tasksGetNextTaskexcludeTaskIds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksGetNextTaskResponse> __BuildTasksGetNextTask(WorkflowValue<string> tasksGetNextTaskautomationName = null, WorkflowValue<string[]> tasksGetNextTaskautomationNames = null, WorkflowValue<int> tasksGetNextTaskminimumPriorityLevel = null, WorkflowValue<tasksGetNextTaskstatusChangeInput> tasksGetNextTaskstatusChange = null, WorkflowValue<int> tasksGetNextTaskminutesUntilDeferralDate = null, WorkflowValue<bool> tasksGetNextTaskignoreSLA = null, WorkflowValue<int[]> tasksGetNextTaskexcludeTaskIds = null)
        {
            WorkflowValue.Validate(tasksGetNextTaskautomationName, nameof(tasksGetNextTaskautomationName), required: false);
            WorkflowValue.Validate(tasksGetNextTaskautomationNames, nameof(tasksGetNextTaskautomationNames), required: false);
            WorkflowValue.Validate(tasksGetNextTaskminimumPriorityLevel, nameof(tasksGetNextTaskminimumPriorityLevel), required: false);
            WorkflowValue.Validate(tasksGetNextTaskstatusChange, nameof(tasksGetNextTaskstatusChange), required: false);
            WorkflowValue.Validate(tasksGetNextTaskminutesUntilDeferralDate, nameof(tasksGetNextTaskminutesUntilDeferralDate), required: false);
            WorkflowValue.Validate(tasksGetNextTaskignoreSLA, nameof(tasksGetNextTaskignoreSLA), required: false);
            WorkflowValue.Validate(tasksGetNextTaskexcludeTaskIds, nameof(tasksGetNextTaskexcludeTaskIds), required: false);
            return new DeferredBodyAction<TasksGetNextTaskResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksGetNextTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksGetNextTask = new JObject();
                var tasksGetNextTaskpropCount = 0;
                if (tasksGetNextTaskautomationName != null)
                {
                    tasksGetNextTask["AutomationName"] = ExpressionConverter.ConvertO(tasksGetNextTaskautomationName);
                    tasksGetNextTaskpropCount++;
                }

                if (tasksGetNextTaskautomationNames != null)
                {
                    tasksGetNextTask["AutomationNames"] = ExpressionConverter.ConvertO(tasksGetNextTaskautomationNames);
                    tasksGetNextTaskpropCount++;
                }

                if (tasksGetNextTaskminimumPriorityLevel != null)
                {
                    tasksGetNextTask["MinimumPriorityLevel"] = ExpressionConverter.ConvertO(tasksGetNextTaskminimumPriorityLevel);
                    tasksGetNextTaskpropCount++;
                }

                if (tasksGetNextTaskstatusChange != null)
                {
                    if (tasksGetNextTaskstatusChange != null)
                    {
                        tasksGetNextTask["StatusChange"] = ExpressionConverter.ConvertO(tasksGetNextTaskstatusChange);
                        tasksGetNextTaskpropCount++;
                    }

                    tasksGetNextTaskpropCount++;
                }
                else
                {
                    tasksGetNextTask["StatusChange"] = "Retrieved";
                    tasksGetNextTaskpropCount++;
                }

                if (tasksGetNextTaskminutesUntilDeferralDate != null)
                {
                    if (tasksGetNextTaskminutesUntilDeferralDate != null)
                    {
                        tasksGetNextTask["MinutesUntilDeferralDate"] = ExpressionConverter.ConvertO(tasksGetNextTaskminutesUntilDeferralDate);
                        tasksGetNextTaskpropCount++;
                    }

                    tasksGetNextTaskpropCount++;
                }
                else
                {
                    tasksGetNextTask["MinutesUntilDeferralDate"] = 0;
                    tasksGetNextTaskpropCount++;
                }

                if (tasksGetNextTaskignoreSLA != null)
                {
                    if (tasksGetNextTaskignoreSLA != null)
                    {
                        tasksGetNextTask["IgnoreSLA"] = ExpressionConverter.ConvertO(tasksGetNextTaskignoreSLA);
                        tasksGetNextTaskpropCount++;
                    }

                    tasksGetNextTaskpropCount++;
                }
                else
                {
                    tasksGetNextTask["IgnoreSLA"] = false;
                    tasksGetNextTaskpropCount++;
                }

                if (tasksGetNextTaskexcludeTaskIds != null)
                {
                    tasksGetNextTask["ExcludeTaskIds"] = ExpressionConverter.ConvertO(tasksGetNextTaskexcludeTaskIds);
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
        [WorkflowExpressionFactory(nameof(__BuildTasksChangeTaskStatus))]
        public IBodyWorkflowAction<TasksChangeTaskStatusResponse> TasksChangeTaskStatus([WorkflowExpression] Func<int> tasksChangeTaskStatustaskId, [WorkflowExpression] Func<tasksChangeTaskStatusautomationTaskStatusInput> tasksChangeTaskStatusautomationTaskStatus = null, [WorkflowExpression] Func<bool> tasksChangeTaskStatustaskOnHold = null, [WorkflowExpression] Func<bool> tasksChangeTaskStatuseraseTaskInputData = null, [WorkflowExpression] Func<bool> tasksChangeTaskStatuseraseDeferralStoredData = null, [WorkflowExpression] Func<bool> tasksChangeTaskStatusupdateSourceSystem = null, [WorkflowExpression] Func<string> tasksChangeTaskStatustaskClosureReason = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksChangeTaskStatusResponse> __BuildTasksChangeTaskStatus(WorkflowValue<int> tasksChangeTaskStatustaskId, WorkflowValue<tasksChangeTaskStatusautomationTaskStatusInput> tasksChangeTaskStatusautomationTaskStatus = null, WorkflowValue<bool> tasksChangeTaskStatustaskOnHold = null, WorkflowValue<bool> tasksChangeTaskStatuseraseTaskInputData = null, WorkflowValue<bool> tasksChangeTaskStatuseraseDeferralStoredData = null, WorkflowValue<bool> tasksChangeTaskStatusupdateSourceSystem = null, WorkflowValue<string> tasksChangeTaskStatustaskClosureReason = null)
        {
            WorkflowValue.Validate(tasksChangeTaskStatustaskId, nameof(tasksChangeTaskStatustaskId), required: true);
            WorkflowValue.Validate(tasksChangeTaskStatusautomationTaskStatus, nameof(tasksChangeTaskStatusautomationTaskStatus), required: false);
            WorkflowValue.Validate(tasksChangeTaskStatustaskOnHold, nameof(tasksChangeTaskStatustaskOnHold), required: false);
            WorkflowValue.Validate(tasksChangeTaskStatuseraseTaskInputData, nameof(tasksChangeTaskStatuseraseTaskInputData), required: false);
            WorkflowValue.Validate(tasksChangeTaskStatuseraseDeferralStoredData, nameof(tasksChangeTaskStatuseraseDeferralStoredData), required: false);
            WorkflowValue.Validate(tasksChangeTaskStatusupdateSourceSystem, nameof(tasksChangeTaskStatusupdateSourceSystem), required: false);
            WorkflowValue.Validate(tasksChangeTaskStatustaskClosureReason, nameof(tasksChangeTaskStatustaskClosureReason), required: false);
            return new DeferredBodyAction<TasksChangeTaskStatusResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksChangeTaskStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksChangeTaskStatus = new JObject();
                var tasksChangeTaskStatuspropCount = 0;
                tasksChangeTaskStatuspropCount++;
                tasksChangeTaskStatus["TaskId"] = ExpressionConverter.ConvertO(tasksChangeTaskStatustaskId);
                if (tasksChangeTaskStatusautomationTaskStatus != null)
                {
                    tasksChangeTaskStatus["AutomationTaskStatus"] = ExpressionConverter.ConvertO(tasksChangeTaskStatusautomationTaskStatus);
                    tasksChangeTaskStatuspropCount++;
                }

                if (tasksChangeTaskStatustaskOnHold != null)
                {
                    if (tasksChangeTaskStatustaskOnHold != null)
                    {
                        tasksChangeTaskStatus["TaskOnHold"] = ExpressionConverter.ConvertO(tasksChangeTaskStatustaskOnHold);
                        tasksChangeTaskStatuspropCount++;
                    }

                    tasksChangeTaskStatuspropCount++;
                }
                else
                {
                    tasksChangeTaskStatus["TaskOnHold"] = false;
                    tasksChangeTaskStatuspropCount++;
                }

                if (tasksChangeTaskStatuseraseTaskInputData != null)
                {
                    if (tasksChangeTaskStatuseraseTaskInputData != null)
                    {
                        tasksChangeTaskStatus["EraseTaskInputData"] = ExpressionConverter.ConvertO(tasksChangeTaskStatuseraseTaskInputData);
                        tasksChangeTaskStatuspropCount++;
                    }

                    tasksChangeTaskStatuspropCount++;
                }
                else
                {
                    tasksChangeTaskStatus["EraseTaskInputData"] = true;
                    tasksChangeTaskStatuspropCount++;
                }

                if (tasksChangeTaskStatuseraseDeferralStoredData != null)
                {
                    if (tasksChangeTaskStatuseraseDeferralStoredData != null)
                    {
                        tasksChangeTaskStatus["EraseDeferralStoredData"] = ExpressionConverter.ConvertO(tasksChangeTaskStatuseraseDeferralStoredData);
                        tasksChangeTaskStatuspropCount++;
                    }

                    tasksChangeTaskStatuspropCount++;
                }
                else
                {
                    tasksChangeTaskStatus["EraseDeferralStoredData"] = true;
                    tasksChangeTaskStatuspropCount++;
                }

                if (tasksChangeTaskStatusupdateSourceSystem != null)
                {
                    if (tasksChangeTaskStatusupdateSourceSystem != null)
                    {
                        tasksChangeTaskStatus["UpdateSourceSystem"] = ExpressionConverter.ConvertO(tasksChangeTaskStatusupdateSourceSystem);
                        tasksChangeTaskStatuspropCount++;
                    }

                    tasksChangeTaskStatuspropCount++;
                }
                else
                {
                    tasksChangeTaskStatus["UpdateSourceSystem"] = true;
                    tasksChangeTaskStatuspropCount++;
                }

                if (tasksChangeTaskStatustaskClosureReason != null)
                {
                    tasksChangeTaskStatus["TaskClosureReason"] = ExpressionConverter.ConvertO(tasksChangeTaskStatustaskClosureReason);
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
        [WorkflowExpressionFactory(nameof(__BuildTasksAddNote))]
        public IBodyWorkflowAction<TasksAddNoteResponse> TasksAddNote([WorkflowExpression] Func<int> tasksAddNotetaskId, [WorkflowExpression] Func<string> tasksAddNotenoteText, [WorkflowExpression] Func<tasksAddNotenoteTypeInput> tasksAddNotenoteType = null, [WorkflowExpression] Func<string> tasksAddNotenoteTypeOther = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksAddNoteResponse> __BuildTasksAddNote(WorkflowValue<int> tasksAddNotetaskId, WorkflowValue<string> tasksAddNotenoteText, WorkflowValue<tasksAddNotenoteTypeInput> tasksAddNotenoteType = null, WorkflowValue<string> tasksAddNotenoteTypeOther = null)
        {
            WorkflowValue.Validate(tasksAddNotetaskId, nameof(tasksAddNotetaskId), required: true);
            WorkflowValue.Validate(tasksAddNotenoteText, nameof(tasksAddNotenoteText), required: true);
            WorkflowValue.Validate(tasksAddNotenoteType, nameof(tasksAddNotenoteType), required: false);
            WorkflowValue.Validate(tasksAddNotenoteTypeOther, nameof(tasksAddNotenoteTypeOther), required: false);
            return new DeferredBodyAction<TasksAddNoteResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNote";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksAddNote = new JObject();
                var tasksAddNotepropCount = 0;
                tasksAddNotepropCount++;
                tasksAddNote["TaskId"] = ExpressionConverter.ConvertO(tasksAddNotetaskId);
                tasksAddNotepropCount++;
                tasksAddNote["NoteText"] = ExpressionConverter.ConvertO(tasksAddNotenoteText);
                if (tasksAddNotenoteType != null)
                {
                    if (tasksAddNotenoteType != null)
                    {
                        tasksAddNote["NoteType"] = ExpressionConverter.ConvertO(tasksAddNotenoteType);
                        tasksAddNotepropCount++;
                    }

                    tasksAddNotepropCount++;
                }
                else
                {
                    tasksAddNote["NoteType"] = "WorkNote";
                    tasksAddNotepropCount++;
                }

                if (tasksAddNotenoteTypeOther != null)
                {
                    tasksAddNote["NoteTypeOther"] = ExpressionConverter.ConvertO(tasksAddNotenoteTypeOther);
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
        [WorkflowExpressionFactory(nameof(__BuildTasksAssignTask))]
        public IBodyWorkflowAction<TasksAssignTaskResponse> TasksAssignTask([WorkflowExpression] Func<int> tasksAssignTasktaskId, [WorkflowExpression] Func<string> tasksAssignTaskassignToUserId = null, [WorkflowExpression] Func<string> tasksAssignTaskassignToUserName = null, [WorkflowExpression] Func<string> tasksAssignTaskassignToGroupId = null, [WorkflowExpression] Func<string> tasksAssignTaskassignToGroupName = null, [WorkflowExpression] Func<bool> tasksAssignTaskremoveUserAssignmentIfBlank = null, [WorkflowExpression] Func<bool> tasksAssignTaskremoveGroupAssignmentIfBlank = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksAssignTaskResponse> __BuildTasksAssignTask(WorkflowValue<int> tasksAssignTasktaskId, WorkflowValue<string> tasksAssignTaskassignToUserId = null, WorkflowValue<string> tasksAssignTaskassignToUserName = null, WorkflowValue<string> tasksAssignTaskassignToGroupId = null, WorkflowValue<string> tasksAssignTaskassignToGroupName = null, WorkflowValue<bool> tasksAssignTaskremoveUserAssignmentIfBlank = null, WorkflowValue<bool> tasksAssignTaskremoveGroupAssignmentIfBlank = null)
        {
            WorkflowValue.Validate(tasksAssignTasktaskId, nameof(tasksAssignTasktaskId), required: true);
            WorkflowValue.Validate(tasksAssignTaskassignToUserId, nameof(tasksAssignTaskassignToUserId), required: false);
            WorkflowValue.Validate(tasksAssignTaskassignToUserName, nameof(tasksAssignTaskassignToUserName), required: false);
            WorkflowValue.Validate(tasksAssignTaskassignToGroupId, nameof(tasksAssignTaskassignToGroupId), required: false);
            WorkflowValue.Validate(tasksAssignTaskassignToGroupName, nameof(tasksAssignTaskassignToGroupName), required: false);
            WorkflowValue.Validate(tasksAssignTaskremoveUserAssignmentIfBlank, nameof(tasksAssignTaskremoveUserAssignmentIfBlank), required: false);
            WorkflowValue.Validate(tasksAssignTaskremoveGroupAssignmentIfBlank, nameof(tasksAssignTaskremoveGroupAssignmentIfBlank), required: false);
            return new DeferredBodyAction<TasksAssignTaskResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksAssignTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksAssignTask = new JObject();
                var tasksAssignTaskpropCount = 0;
                tasksAssignTaskpropCount++;
                tasksAssignTask["TaskId"] = ExpressionConverter.ConvertO(tasksAssignTasktaskId);
                if (tasksAssignTaskassignToUserId != null)
                {
                    tasksAssignTask["AssignToUserId"] = ExpressionConverter.ConvertO(tasksAssignTaskassignToUserId);
                    tasksAssignTaskpropCount++;
                }

                if (tasksAssignTaskassignToUserName != null)
                {
                    tasksAssignTask["AssignToUserName"] = ExpressionConverter.ConvertO(tasksAssignTaskassignToUserName);
                    tasksAssignTaskpropCount++;
                }

                if (tasksAssignTaskassignToGroupId != null)
                {
                    tasksAssignTask["AssignToGroupId"] = ExpressionConverter.ConvertO(tasksAssignTaskassignToGroupId);
                    tasksAssignTaskpropCount++;
                }

                if (tasksAssignTaskassignToGroupName != null)
                {
                    tasksAssignTask["AssignToGroupName"] = ExpressionConverter.ConvertO(tasksAssignTaskassignToGroupName);
                    tasksAssignTaskpropCount++;
                }

                if (tasksAssignTaskremoveUserAssignmentIfBlank != null)
                {
                    if (tasksAssignTaskremoveUserAssignmentIfBlank != null)
                    {
                        tasksAssignTask["RemoveUserAssignmentIfBlank"] = ExpressionConverter.ConvertO(tasksAssignTaskremoveUserAssignmentIfBlank);
                        tasksAssignTaskpropCount++;
                    }

                    tasksAssignTaskpropCount++;
                }
                else
                {
                    tasksAssignTask["RemoveUserAssignmentIfBlank"] = true;
                    tasksAssignTaskpropCount++;
                }

                if (tasksAssignTaskremoveGroupAssignmentIfBlank != null)
                {
                    if (tasksAssignTaskremoveGroupAssignmentIfBlank != null)
                    {
                        tasksAssignTask["RemoveGroupAssignmentIfBlank"] = ExpressionConverter.ConvertO(tasksAssignTaskremoveGroupAssignmentIfBlank);
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
        [WorkflowExpressionFactory(nameof(__BuildTasksSetOutputData))]
        public IBodyWorkflowAction<TasksSetOutputDataResponse> TasksSetOutputData([WorkflowExpression] Func<int> tasksSetOutputDatataskId, [WorkflowExpression] Func<string> tasksSetOutputDatataskOutputData = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksSetOutputDataResponse> __BuildTasksSetOutputData(WorkflowValue<int> tasksSetOutputDatataskId, WorkflowValue<string> tasksSetOutputDatataskOutputData = null)
        {
            WorkflowValue.Validate(tasksSetOutputDatataskId, nameof(tasksSetOutputDatataskId), required: true);
            WorkflowValue.Validate(tasksSetOutputDatataskOutputData, nameof(tasksSetOutputDatataskOutputData), required: false);
            return new DeferredBodyAction<TasksSetOutputDataResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksSetOutputData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksSetOutputData = new JObject();
                var tasksSetOutputDatapropCount = 0;
                tasksSetOutputDatapropCount++;
                tasksSetOutputData["TaskId"] = ExpressionConverter.ConvertO(tasksSetOutputDatataskId);
                if (tasksSetOutputDatataskOutputData != null)
                {
                    tasksSetOutputData["TaskOutputData"] = ExpressionConverter.ConvertO(tasksSetOutputDatataskOutputData);
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
        [WorkflowExpressionFactory(nameof(__BuildTasksAddNewTaskOperation))]
        public IBodyWorkflowAction<TasksAddNewTaskOperationResponse> TasksAddNewTaskOperation([WorkflowExpression] Func<string> tasksAddNewTaskOperationautomationName = null, [WorkflowExpression] Func<string> tasksAddNewTaskOperationtaskInputData = null, [WorkflowExpression] Func<string> tasksAddNewTaskOperationprocessStage = null, [WorkflowExpression] Func<int> tasksAddNewTaskOperationpriority = null, [WorkflowExpression] Func<int> tasksAddNewTaskOperationsLA = null, [WorkflowExpression] Func<string> tasksAddNewTaskOperationorganisation = null, [WorkflowExpression] Func<string> tasksAddNewTaskOperationdepartment = null, [WorkflowExpression] Func<string> tasksAddNewTaskOperationdescription = null, [WorkflowExpression] Func<string> tasksAddNewTaskOperationtags = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksAddNewTaskOperationResponse> __BuildTasksAddNewTaskOperation(WorkflowValue<string> tasksAddNewTaskOperationautomationName = null, WorkflowValue<string> tasksAddNewTaskOperationtaskInputData = null, WorkflowValue<string> tasksAddNewTaskOperationprocessStage = null, WorkflowValue<int> tasksAddNewTaskOperationpriority = null, WorkflowValue<int> tasksAddNewTaskOperationsLA = null, WorkflowValue<string> tasksAddNewTaskOperationorganisation = null, WorkflowValue<string> tasksAddNewTaskOperationdepartment = null, WorkflowValue<string> tasksAddNewTaskOperationdescription = null, WorkflowValue<string> tasksAddNewTaskOperationtags = null)
        {
            WorkflowValue.Validate(tasksAddNewTaskOperationautomationName, nameof(tasksAddNewTaskOperationautomationName), required: false);
            WorkflowValue.Validate(tasksAddNewTaskOperationtaskInputData, nameof(tasksAddNewTaskOperationtaskInputData), required: false);
            WorkflowValue.Validate(tasksAddNewTaskOperationprocessStage, nameof(tasksAddNewTaskOperationprocessStage), required: false);
            WorkflowValue.Validate(tasksAddNewTaskOperationpriority, nameof(tasksAddNewTaskOperationpriority), required: false);
            WorkflowValue.Validate(tasksAddNewTaskOperationsLA, nameof(tasksAddNewTaskOperationsLA), required: false);
            WorkflowValue.Validate(tasksAddNewTaskOperationorganisation, nameof(tasksAddNewTaskOperationorganisation), required: false);
            WorkflowValue.Validate(tasksAddNewTaskOperationdepartment, nameof(tasksAddNewTaskOperationdepartment), required: false);
            WorkflowValue.Validate(tasksAddNewTaskOperationdescription, nameof(tasksAddNewTaskOperationdescription), required: false);
            WorkflowValue.Validate(tasksAddNewTaskOperationtags, nameof(tasksAddNewTaskOperationtags), required: false);
            return new DeferredBodyAction<TasksAddNewTaskOperationResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNewTaskOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksAddNewTaskOperation = new JObject();
                var tasksAddNewTaskOperationpropCount = 0;
                if (tasksAddNewTaskOperationautomationName != null)
                {
                    tasksAddNewTaskOperation["AutomationName"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationautomationName);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (tasksAddNewTaskOperationtaskInputData != null)
                {
                    tasksAddNewTaskOperation["TaskInputData"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationtaskInputData);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (tasksAddNewTaskOperationprocessStage != null)
                {
                    tasksAddNewTaskOperation["ProcessStage"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationprocessStage);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (tasksAddNewTaskOperationpriority != null)
                {
                    if (tasksAddNewTaskOperationpriority != null)
                    {
                        tasksAddNewTaskOperation["Priority"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationpriority);
                        tasksAddNewTaskOperationpropCount++;
                    }

                    tasksAddNewTaskOperationpropCount++;
                }
                else
                {
                    tasksAddNewTaskOperation["Priority"] = 3;
                    tasksAddNewTaskOperationpropCount++;
                }

                if (tasksAddNewTaskOperationsLA != null)
                {
                    tasksAddNewTaskOperation["SLA"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationsLA);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (tasksAddNewTaskOperationorganisation != null)
                {
                    tasksAddNewTaskOperation["Organisation"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationorganisation);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (tasksAddNewTaskOperationdepartment != null)
                {
                    tasksAddNewTaskOperation["Department"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationdepartment);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (tasksAddNewTaskOperationdescription != null)
                {
                    tasksAddNewTaskOperation["Description"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationdescription);
                    tasksAddNewTaskOperationpropCount++;
                }

                if (tasksAddNewTaskOperationtags != null)
                {
                    tasksAddNewTaskOperation["Tags"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationtags);
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
        [WorkflowExpressionFactory(nameof(__BuildTasksAddNewDeferralOperation))]
        public IBodyWorkflowAction<TasksAddNewDeferralOperationResponse> TasksAddNewDeferralOperation([WorkflowExpression] Func<string> tasksAddNewDeferralOperationautomationName = null, [WorkflowExpression] Func<int> tasksAddNewDeferralOperationdeferralTimeInMinutes = null, [WorkflowExpression] Func<string> tasksAddNewDeferralOperationtaskInputData = null, [WorkflowExpression] Func<string> tasksAddNewDeferralOperationdeferralStoredData = null, [WorkflowExpression] Func<string> tasksAddNewDeferralOperationprocessStage = null, [WorkflowExpression] Func<int> tasksAddNewDeferralOperationpriority = null, [WorkflowExpression] Func<string> tasksAddNewDeferralOperationorganisation = null, [WorkflowExpression] Func<string> tasksAddNewDeferralOperationdepartment = null, [WorkflowExpression] Func<string> tasksAddNewDeferralOperationdescription = null, [WorkflowExpression] Func<string> tasksAddNewDeferralOperationtags = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksAddNewDeferralOperationResponse> __BuildTasksAddNewDeferralOperation(WorkflowValue<string> tasksAddNewDeferralOperationautomationName = null, WorkflowValue<int> tasksAddNewDeferralOperationdeferralTimeInMinutes = null, WorkflowValue<string> tasksAddNewDeferralOperationtaskInputData = null, WorkflowValue<string> tasksAddNewDeferralOperationdeferralStoredData = null, WorkflowValue<string> tasksAddNewDeferralOperationprocessStage = null, WorkflowValue<int> tasksAddNewDeferralOperationpriority = null, WorkflowValue<string> tasksAddNewDeferralOperationorganisation = null, WorkflowValue<string> tasksAddNewDeferralOperationdepartment = null, WorkflowValue<string> tasksAddNewDeferralOperationdescription = null, WorkflowValue<string> tasksAddNewDeferralOperationtags = null)
        {
            WorkflowValue.Validate(tasksAddNewDeferralOperationautomationName, nameof(tasksAddNewDeferralOperationautomationName), required: false);
            WorkflowValue.Validate(tasksAddNewDeferralOperationdeferralTimeInMinutes, nameof(tasksAddNewDeferralOperationdeferralTimeInMinutes), required: false);
            WorkflowValue.Validate(tasksAddNewDeferralOperationtaskInputData, nameof(tasksAddNewDeferralOperationtaskInputData), required: false);
            WorkflowValue.Validate(tasksAddNewDeferralOperationdeferralStoredData, nameof(tasksAddNewDeferralOperationdeferralStoredData), required: false);
            WorkflowValue.Validate(tasksAddNewDeferralOperationprocessStage, nameof(tasksAddNewDeferralOperationprocessStage), required: false);
            WorkflowValue.Validate(tasksAddNewDeferralOperationpriority, nameof(tasksAddNewDeferralOperationpriority), required: false);
            WorkflowValue.Validate(tasksAddNewDeferralOperationorganisation, nameof(tasksAddNewDeferralOperationorganisation), required: false);
            WorkflowValue.Validate(tasksAddNewDeferralOperationdepartment, nameof(tasksAddNewDeferralOperationdepartment), required: false);
            WorkflowValue.Validate(tasksAddNewDeferralOperationdescription, nameof(tasksAddNewDeferralOperationdescription), required: false);
            WorkflowValue.Validate(tasksAddNewDeferralOperationtags, nameof(tasksAddNewDeferralOperationtags), required: false);
            return new DeferredBodyAction<TasksAddNewDeferralOperationResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNewDeferralOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksAddNewDeferralOperation = new JObject();
                var tasksAddNewDeferralOperationpropCount = 0;
                if (tasksAddNewDeferralOperationautomationName != null)
                {
                    tasksAddNewDeferralOperation["AutomationName"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationautomationName);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (tasksAddNewDeferralOperationdeferralTimeInMinutes != null)
                {
                    tasksAddNewDeferralOperation["DeferralTimeInMinutes"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationdeferralTimeInMinutes);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (tasksAddNewDeferralOperationtaskInputData != null)
                {
                    tasksAddNewDeferralOperation["TaskInputData"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationtaskInputData);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (tasksAddNewDeferralOperationdeferralStoredData != null)
                {
                    tasksAddNewDeferralOperation["DeferralStoredData"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationdeferralStoredData);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (tasksAddNewDeferralOperationprocessStage != null)
                {
                    tasksAddNewDeferralOperation["ProcessStage"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationprocessStage);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (tasksAddNewDeferralOperationpriority != null)
                {
                    if (tasksAddNewDeferralOperationpriority != null)
                    {
                        tasksAddNewDeferralOperation["Priority"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationpriority);
                        tasksAddNewDeferralOperationpropCount++;
                    }

                    tasksAddNewDeferralOperationpropCount++;
                }
                else
                {
                    tasksAddNewDeferralOperation["Priority"] = 3;
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (tasksAddNewDeferralOperationorganisation != null)
                {
                    tasksAddNewDeferralOperation["Organisation"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationorganisation);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (tasksAddNewDeferralOperationdepartment != null)
                {
                    tasksAddNewDeferralOperation["Department"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationdepartment);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (tasksAddNewDeferralOperationdescription != null)
                {
                    tasksAddNewDeferralOperation["Description"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationdescription);
                    tasksAddNewDeferralOperationpropCount++;
                }

                if (tasksAddNewDeferralOperationtags != null)
                {
                    tasksAddNewDeferralOperation["Tags"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationtags);
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
        [WorkflowExpressionFactory(nameof(__BuildTasksGetTaskOperation))]
        public IBodyWorkflowAction<TasksGetTaskOperationResponse> TasksGetTaskOperation([WorkflowExpression] Func<string> tasksGetTaskOperationoperationId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksGetTaskOperationResponse> __BuildTasksGetTaskOperation(WorkflowValue<string> tasksGetTaskOperationoperationId)
        {
            WorkflowValue.Validate(tasksGetTaskOperationoperationId, nameof(tasksGetTaskOperationoperationId), required: true);
            return new DeferredBodyAction<TasksGetTaskOperationResponse>(() =>
            {
                var apiCallPath = "/Environment/TasksGetTaskOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var tasksGetTaskOperation = new JObject();
                var tasksGetTaskOperationpropCount = 0;
                tasksGetTaskOperationpropCount++;
                tasksGetTaskOperation["OperationId"] = ExpressionConverter.ConvertO(tasksGetTaskOperationoperationId);
                if (tasksGetTaskOperationpropCount > 0)
                {
                    callPayload.Body = tasksGetTaskOperation;
                }

                return new ApiConnectionAction<TasksGetTaskOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetRemoteLoggingLevel))]
        public IWorkflowAction SetRemoteLoggingLevel([WorkflowExpression] Func<int> setRemoteLoggingLevelloggingLevel, [WorkflowExpression] Func<string> setRemoteLoggingLevelworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetRemoteLoggingLevel(WorkflowValue<int> setRemoteLoggingLevelloggingLevel, WorkflowValue<string> setRemoteLoggingLevelworkflow)
        {
            WorkflowValue.Validate(setRemoteLoggingLevelloggingLevel, nameof(setRemoteLoggingLevelloggingLevel), required: true);
            WorkflowValue.Validate(setRemoteLoggingLevelworkflow, nameof(setRemoteLoggingLevelworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/SetRemoteLoggingLevel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setRemoteLoggingLevel = new JObject();
                var setRemoteLoggingLevelpropCount = 0;
                setRemoteLoggingLevelpropCount++;
                setRemoteLoggingLevel["LoggingLevel"] = ExpressionConverter.ConvertO(setRemoteLoggingLevelloggingLevel);
                setRemoteLoggingLevelpropCount++;
                setRemoteLoggingLevel["Workflow"] = ExpressionConverter.ConvertO(setRemoteLoggingLevelworkflow);
                if (setRemoteLoggingLevelpropCount > 0)
                {
                    callPayload.Body = setRemoteLoggingLevel;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetRemoteLoggingLevel))]
        public IBodyWorkflowAction<GetRemoteLoggingLevelResponse> GetRemoteLoggingLevel([WorkflowExpression] Func<string> getRemoteLoggingLevelworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRemoteLoggingLevelResponse> __BuildGetRemoteLoggingLevel(WorkflowValue<string> getRemoteLoggingLevelworkflow)
        {
            WorkflowValue.Validate(getRemoteLoggingLevelworkflow, nameof(getRemoteLoggingLevelworkflow), required: true);
            return new DeferredBodyAction<GetRemoteLoggingLevelResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetRemoteLoggingLevel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRemoteLoggingLevel = new JObject();
                var getRemoteLoggingLevelpropCount = 0;
                getRemoteLoggingLevelpropCount++;
                getRemoteLoggingLevel["Workflow"] = ExpressionConverter.ConvertO(getRemoteLoggingLevelworkflow);
                if (getRemoteLoggingLevelpropCount > 0)
                {
                    callPayload.Body = getRemoteLoggingLevel;
                }

                return new ApiConnectionAction<GetRemoteLoggingLevelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetLicenseCode))]
        public IWorkflowAction SetLicenseCode([WorkflowExpression] Func<string> setLicenseCodecustomerNETBIOSDomainName, [WorkflowExpression] Func<string> setLicenseCodecustomerDisplayName, [WorkflowExpression] Func<string> setLicenseCodevendorName, [WorkflowExpression] Func<string> setLicenseCodelicenseExpiryDate, [WorkflowExpression] Func<string> setLicenseCodeactivationCode, [WorkflowExpression] Func<string> setLicenseCodeworkflow, [WorkflowExpression] Func<bool> setLicenseCodestoreInRegistry = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetLicenseCode(WorkflowValue<string> setLicenseCodecustomerNETBIOSDomainName, WorkflowValue<string> setLicenseCodecustomerDisplayName, WorkflowValue<string> setLicenseCodevendorName, WorkflowValue<string> setLicenseCodelicenseExpiryDate, WorkflowValue<string> setLicenseCodeactivationCode, WorkflowValue<string> setLicenseCodeworkflow, WorkflowValue<bool> setLicenseCodestoreInRegistry = null)
        {
            WorkflowValue.Validate(setLicenseCodecustomerNETBIOSDomainName, nameof(setLicenseCodecustomerNETBIOSDomainName), required: true);
            WorkflowValue.Validate(setLicenseCodecustomerDisplayName, nameof(setLicenseCodecustomerDisplayName), required: true);
            WorkflowValue.Validate(setLicenseCodevendorName, nameof(setLicenseCodevendorName), required: true);
            WorkflowValue.Validate(setLicenseCodelicenseExpiryDate, nameof(setLicenseCodelicenseExpiryDate), required: true);
            WorkflowValue.Validate(setLicenseCodeactivationCode, nameof(setLicenseCodeactivationCode), required: true);
            WorkflowValue.Validate(setLicenseCodeworkflow, nameof(setLicenseCodeworkflow), required: true);
            WorkflowValue.Validate(setLicenseCodestoreInRegistry, nameof(setLicenseCodestoreInRegistry), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/SetLicenseCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setLicenseCode = new JObject();
                var setLicenseCodepropCount = 0;
                setLicenseCodepropCount++;
                setLicenseCode["CustomerNETBIOSDomainName"] = ExpressionConverter.ConvertO(setLicenseCodecustomerNETBIOSDomainName);
                setLicenseCodepropCount++;
                setLicenseCode["CustomerDisplayName"] = ExpressionConverter.ConvertO(setLicenseCodecustomerDisplayName);
                setLicenseCodepropCount++;
                setLicenseCode["VendorName"] = ExpressionConverter.ConvertO(setLicenseCodevendorName);
                setLicenseCodepropCount++;
                setLicenseCode["LicenseExpiryDate"] = ExpressionConverter.ConvertO(setLicenseCodelicenseExpiryDate);
                setLicenseCodepropCount++;
                setLicenseCode["ActivationCode"] = ExpressionConverter.ConvertO(setLicenseCodeactivationCode);
                if (setLicenseCodestoreInRegistry != null)
                {
                    if (setLicenseCodestoreInRegistry != null)
                    {
                        setLicenseCode["StoreInRegistry"] = ExpressionConverter.ConvertO(setLicenseCodestoreInRegistry);
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
                setLicenseCode["Workflow"] = ExpressionConverter.ConvertO(setLicenseCodeworkflow);
                if (setLicenseCodepropCount > 0)
                {
                    callPayload.Body = setLicenseCode;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetLicenseString))]
        public IBodyWorkflowAction<SetLicenseStringResponse> SetLicenseString([WorkflowExpression] Func<string> setLicenseStringlicenseString, [WorkflowExpression] Func<string> setLicenseStringworkflow, [WorkflowExpression] Func<bool> setLicenseStringstoreInRegistry = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetLicenseStringResponse> __BuildSetLicenseString(WorkflowValue<string> setLicenseStringlicenseString, WorkflowValue<string> setLicenseStringworkflow, WorkflowValue<bool> setLicenseStringstoreInRegistry = null)
        {
            WorkflowValue.Validate(setLicenseStringlicenseString, nameof(setLicenseStringlicenseString), required: true);
            WorkflowValue.Validate(setLicenseStringworkflow, nameof(setLicenseStringworkflow), required: true);
            WorkflowValue.Validate(setLicenseStringstoreInRegistry, nameof(setLicenseStringstoreInRegistry), required: false);
            return new DeferredBodyAction<SetLicenseStringResponse>(() =>
            {
                var apiCallPath = "/DriverControl/SetLicenseString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setLicenseString = new JObject();
                var setLicenseStringpropCount = 0;
                setLicenseStringpropCount++;
                setLicenseString["LicenseString"] = ExpressionConverter.ConvertO(setLicenseStringlicenseString);
                if (setLicenseStringstoreInRegistry != null)
                {
                    if (setLicenseStringstoreInRegistry != null)
                    {
                        setLicenseString["StoreInRegistry"] = ExpressionConverter.ConvertO(setLicenseStringstoreInRegistry);
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
                setLicenseString["Workflow"] = ExpressionConverter.ConvertO(setLicenseStringworkflow);
                if (setLicenseStringpropCount > 0)
                {
                    callPayload.Body = setLicenseString;
                }

                return new ApiConnectionAction<SetLicenseStringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetLicenseState))]
        public IBodyWorkflowAction<GetLicenseStateResponse> GetLicenseState([WorkflowExpression] Func<string> getLicenseStateworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLicenseStateResponse> __BuildGetLicenseState(WorkflowValue<string> getLicenseStateworkflow)
        {
            WorkflowValue.Validate(getLicenseStateworkflow, nameof(getLicenseStateworkflow), required: true);
            return new DeferredBodyAction<GetLicenseStateResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetLicenseState";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getLicenseState = new JObject();
                var getLicenseStatepropCount = 0;
                getLicenseStatepropCount++;
                getLicenseState["Workflow"] = ExpressionConverter.ConvertO(getLicenseStateworkflow);
                if (getLicenseStatepropCount > 0)
                {
                    callPayload.Body = getLicenseState;
                }

                return new ApiConnectionAction<GetLicenseStateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetRSAGUITopmost))]
        public IWorkflowAction SetRSAGUITopmost([WorkflowExpression] Func<string> setRSAGUITopmostworkflow, [WorkflowExpression] Func<bool> setRSAGUITopmosttopMost = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetRSAGUITopmost(WorkflowValue<string> setRSAGUITopmostworkflow, WorkflowValue<bool> setRSAGUITopmosttopMost = null)
        {
            WorkflowValue.Validate(setRSAGUITopmostworkflow, nameof(setRSAGUITopmostworkflow), required: true);
            WorkflowValue.Validate(setRSAGUITopmosttopMost, nameof(setRSAGUITopmosttopMost), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/SetRSAGUITopmost";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setRSAGUITopmost = new JObject();
                var setRSAGUITopmostpropCount = 0;
                if (setRSAGUITopmosttopMost != null)
                {
                    if (setRSAGUITopmosttopMost != null)
                    {
                        setRSAGUITopmost["TopMost"] = ExpressionConverter.ConvertO(setRSAGUITopmosttopMost);
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
                setRSAGUITopmost["Workflow"] = ExpressionConverter.ConvertO(setRSAGUITopmostworkflow);
                if (setRSAGUITopmostpropCount > 0)
                {
                    callPayload.Body = setRSAGUITopmost;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetRSAGUIOpacity))]
        public IWorkflowAction SetRSAGUIOpacity([WorkflowExpression] Func<double> setRSAGUIOpacityopacity, [WorkflowExpression] Func<string> setRSAGUIOpacityworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetRSAGUIOpacity(WorkflowValue<double> setRSAGUIOpacityopacity, WorkflowValue<string> setRSAGUIOpacityworkflow)
        {
            WorkflowValue.Validate(setRSAGUIOpacityopacity, nameof(setRSAGUIOpacityopacity), required: true);
            WorkflowValue.Validate(setRSAGUIOpacityworkflow, nameof(setRSAGUIOpacityworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/SetRSAGUIOpacity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setRSAGUIOpacity = new JObject();
                var setRSAGUIOpacitypropCount = 0;
                setRSAGUIOpacitypropCount++;
                setRSAGUIOpacity["Opacity"] = ExpressionConverter.ConvertO(setRSAGUIOpacityopacity);
                setRSAGUIOpacitypropCount++;
                setRSAGUIOpacity["Workflow"] = ExpressionConverter.ConvertO(setRSAGUIOpacityworkflow);
                if (setRSAGUIOpacitypropCount > 0)
                {
                    callPayload.Body = setRSAGUIOpacity;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetRSAGUIPosition))]
        public IWorkflowAction SetRSAGUIPosition([WorkflowExpression] Func<int> setRSAGUIPositionx, [WorkflowExpression] Func<int> setRSAGUIPositiony, [WorkflowExpression] Func<string> setRSAGUIPositionworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetRSAGUIPosition(WorkflowValue<int> setRSAGUIPositionx, WorkflowValue<int> setRSAGUIPositiony, WorkflowValue<string> setRSAGUIPositionworkflow)
        {
            WorkflowValue.Validate(setRSAGUIPositionx, nameof(setRSAGUIPositionx), required: true);
            WorkflowValue.Validate(setRSAGUIPositiony, nameof(setRSAGUIPositiony), required: true);
            WorkflowValue.Validate(setRSAGUIPositionworkflow, nameof(setRSAGUIPositionworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/SetRSAGUIPosition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setRSAGUIPosition = new JObject();
                var setRSAGUIPositionpropCount = 0;
                setRSAGUIPositionpropCount++;
                setRSAGUIPosition["X"] = ExpressionConverter.ConvertO(setRSAGUIPositionx);
                setRSAGUIPositionpropCount++;
                setRSAGUIPosition["Y"] = ExpressionConverter.ConvertO(setRSAGUIPositiony);
                setRSAGUIPositionpropCount++;
                setRSAGUIPosition["Workflow"] = ExpressionConverter.ConvertO(setRSAGUIPositionworkflow);
                if (setRSAGUIPositionpropCount > 0)
                {
                    callPayload.Body = setRSAGUIPosition;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildBringRSAGUIToFront))]
        public IWorkflowAction BringRSAGUIToFront([WorkflowExpression] Func<string> bringRSAGUIToFrontworkflow, [WorkflowExpression] Func<bool> bringRSAGUIToFrontfocus = null, [WorkflowExpression] Func<bool> bringRSAGUIToFrontglobalLeftMouseClick = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBringRSAGUIToFront(WorkflowValue<string> bringRSAGUIToFrontworkflow, WorkflowValue<bool> bringRSAGUIToFrontfocus = null, WorkflowValue<bool> bringRSAGUIToFrontglobalLeftMouseClick = null)
        {
            WorkflowValue.Validate(bringRSAGUIToFrontworkflow, nameof(bringRSAGUIToFrontworkflow), required: true);
            WorkflowValue.Validate(bringRSAGUIToFrontfocus, nameof(bringRSAGUIToFrontfocus), required: false);
            WorkflowValue.Validate(bringRSAGUIToFrontglobalLeftMouseClick, nameof(bringRSAGUIToFrontglobalLeftMouseClick), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/BringRSAGUIToFront";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var bringRSAGUIToFront = new JObject();
                var bringRSAGUIToFrontpropCount = 0;
                if (bringRSAGUIToFrontfocus != null)
                {
                    if (bringRSAGUIToFrontfocus != null)
                    {
                        bringRSAGUIToFront["Focus"] = ExpressionConverter.ConvertO(bringRSAGUIToFrontfocus);
                        bringRSAGUIToFrontpropCount++;
                    }

                    bringRSAGUIToFrontpropCount++;
                }
                else
                {
                    bringRSAGUIToFront["Focus"] = true;
                    bringRSAGUIToFrontpropCount++;
                }

                if (bringRSAGUIToFrontglobalLeftMouseClick != null)
                {
                    if (bringRSAGUIToFrontglobalLeftMouseClick != null)
                    {
                        bringRSAGUIToFront["GlobalLeftMouseClick"] = ExpressionConverter.ConvertO(bringRSAGUIToFrontglobalLeftMouseClick);
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
                bringRSAGUIToFront["Workflow"] = ExpressionConverter.ConvertO(bringRSAGUIToFrontworkflow);
                if (bringRSAGUIToFrontpropCount > 0)
                {
                    callPayload.Body = bringRSAGUIToFront;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildDisconnectSession))]
        public IWorkflowAction DisconnectSession([WorkflowExpression] Func<string> disconnectSessionworkflow, [WorkflowExpression] Func<int> disconnectSessionsecondsToWait = null, [WorkflowExpression] Func<bool> disconnectSessiondoNotDisconnectIfLocalAgent = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDisconnectSession(WorkflowValue<string> disconnectSessionworkflow, WorkflowValue<int> disconnectSessionsecondsToWait = null, WorkflowValue<bool> disconnectSessiondoNotDisconnectIfLocalAgent = null)
        {
            WorkflowValue.Validate(disconnectSessionworkflow, nameof(disconnectSessionworkflow), required: true);
            WorkflowValue.Validate(disconnectSessionsecondsToWait, nameof(disconnectSessionsecondsToWait), required: false);
            WorkflowValue.Validate(disconnectSessiondoNotDisconnectIfLocalAgent, nameof(disconnectSessiondoNotDisconnectIfLocalAgent), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/DisconnectSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var disconnectSession = new JObject();
                var disconnectSessionpropCount = 0;
                if (disconnectSessionsecondsToWait != null)
                {
                    if (disconnectSessionsecondsToWait != null)
                    {
                        disconnectSession["SecondsToWait"] = ExpressionConverter.ConvertO(disconnectSessionsecondsToWait);
                        disconnectSessionpropCount++;
                    }

                    disconnectSessionpropCount++;
                }
                else
                {
                    disconnectSession["SecondsToWait"] = 3;
                    disconnectSessionpropCount++;
                }

                if (disconnectSessiondoNotDisconnectIfLocalAgent != null)
                {
                    if (disconnectSessiondoNotDisconnectIfLocalAgent != null)
                    {
                        disconnectSession["DoNotDisconnectIfLocalAgent"] = ExpressionConverter.ConvertO(disconnectSessiondoNotDisconnectIfLocalAgent);
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
                disconnectSession["Workflow"] = ExpressionConverter.ConvertO(disconnectSessionworkflow);
                if (disconnectSessionpropCount > 0)
                {
                    callPayload.Body = disconnectSession;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildLogoffSession))]
        public IWorkflowAction LogoffSession([WorkflowExpression] Func<string> logoffSessionworkflow, [WorkflowExpression] Func<int> logoffSessionsecondsToWait = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLogoffSession(WorkflowValue<string> logoffSessionworkflow, WorkflowValue<int> logoffSessionsecondsToWait = null)
        {
            WorkflowValue.Validate(logoffSessionworkflow, nameof(logoffSessionworkflow), required: true);
            WorkflowValue.Validate(logoffSessionsecondsToWait, nameof(logoffSessionsecondsToWait), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/LogoffSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var logoffSession = new JObject();
                var logoffSessionpropCount = 0;
                if (logoffSessionsecondsToWait != null)
                {
                    if (logoffSessionsecondsToWait != null)
                    {
                        logoffSession["SecondsToWait"] = ExpressionConverter.ConvertO(logoffSessionsecondsToWait);
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
                logoffSession["Workflow"] = ExpressionConverter.ConvertO(logoffSessionworkflow);
                if (logoffSessionpropCount > 0)
                {
                    callPayload.Body = logoffSession;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildCloseRSAServer))]
        public IWorkflowAction CloseRSAServer([WorkflowExpression] Func<string> closeRSAServerworkflow, [WorkflowExpression] Func<int> closeRSAServersecondsToWait = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCloseRSAServer(WorkflowValue<string> closeRSAServerworkflow, WorkflowValue<int> closeRSAServersecondsToWait = null)
        {
            WorkflowValue.Validate(closeRSAServerworkflow, nameof(closeRSAServerworkflow), required: true);
            WorkflowValue.Validate(closeRSAServersecondsToWait, nameof(closeRSAServersecondsToWait), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/CloseRSAServer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var closeRSAServer = new JObject();
                var closeRSAServerpropCount = 0;
                if (closeRSAServersecondsToWait != null)
                {
                    if (closeRSAServersecondsToWait != null)
                    {
                        closeRSAServer["SecondsToWait"] = ExpressionConverter.ConvertO(closeRSAServersecondsToWait);
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
                closeRSAServer["Workflow"] = ExpressionConverter.ConvertO(closeRSAServerworkflow);
                if (closeRSAServerpropCount > 0)
                {
                    callPayload.Body = closeRSAServer;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetRPACommandTimeout))]
        public IWorkflowAction SetRPACommandTimeout([WorkflowExpression] Func<int> setRPACommandTimeoutcommandTimeoutInSeconds, [WorkflowExpression] Func<string> setRPACommandTimeoutworkflow, [WorkflowExpression] Func<bool> setRPACommandTimeoutterminateTimedoutRPACommandThreads = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetRPACommandTimeout(WorkflowValue<int> setRPACommandTimeoutcommandTimeoutInSeconds, WorkflowValue<string> setRPACommandTimeoutworkflow, WorkflowValue<bool> setRPACommandTimeoutterminateTimedoutRPACommandThreads = null)
        {
            WorkflowValue.Validate(setRPACommandTimeoutcommandTimeoutInSeconds, nameof(setRPACommandTimeoutcommandTimeoutInSeconds), required: true);
            WorkflowValue.Validate(setRPACommandTimeoutworkflow, nameof(setRPACommandTimeoutworkflow), required: true);
            WorkflowValue.Validate(setRPACommandTimeoutterminateTimedoutRPACommandThreads, nameof(setRPACommandTimeoutterminateTimedoutRPACommandThreads), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/SetRPACommandTimeout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setRPACommandTimeout = new JObject();
                var setRPACommandTimeoutpropCount = 0;
                setRPACommandTimeoutpropCount++;
                setRPACommandTimeout["CommandTimeoutInSeconds"] = ExpressionConverter.ConvertO(setRPACommandTimeoutcommandTimeoutInSeconds);
                if (setRPACommandTimeoutterminateTimedoutRPACommandThreads != null)
                {
                    if (setRPACommandTimeoutterminateTimedoutRPACommandThreads != null)
                    {
                        setRPACommandTimeout["TerminateTimedoutRPACommandThreads"] = ExpressionConverter.ConvertO(setRPACommandTimeoutterminateTimedoutRPACommandThreads);
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
                setRPACommandTimeout["Workflow"] = ExpressionConverter.ConvertO(setRPACommandTimeoutworkflow);
                if (setRPACommandTimeoutpropCount > 0)
                {
                    callPayload.Body = setRPACommandTimeout;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRunAlternativeIAConnect))]
        public IWorkflowAction RunAlternativeIAConnect([WorkflowExpression] Func<string> runAlternativeIAConnectfilename, [WorkflowExpression] Func<string> runAlternativeIAConnectworkflow, [WorkflowExpression] Func<string> runAlternativeIAConnectarguments = null, [WorkflowExpression] Func<bool> runAlternativeIAConnectloadIntoMemory = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRunAlternativeIAConnect(WorkflowValue<string> runAlternativeIAConnectfilename, WorkflowValue<string> runAlternativeIAConnectworkflow, WorkflowValue<string> runAlternativeIAConnectarguments = null, WorkflowValue<bool> runAlternativeIAConnectloadIntoMemory = null)
        {
            WorkflowValue.Validate(runAlternativeIAConnectfilename, nameof(runAlternativeIAConnectfilename), required: true);
            WorkflowValue.Validate(runAlternativeIAConnectworkflow, nameof(runAlternativeIAConnectworkflow), required: true);
            WorkflowValue.Validate(runAlternativeIAConnectarguments, nameof(runAlternativeIAConnectarguments), required: false);
            WorkflowValue.Validate(runAlternativeIAConnectloadIntoMemory, nameof(runAlternativeIAConnectloadIntoMemory), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/RunAlternativeIAConnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runAlternativeIAConnect = new JObject();
                var runAlternativeIAConnectpropCount = 0;
                runAlternativeIAConnectpropCount++;
                runAlternativeIAConnect["Filename"] = ExpressionConverter.ConvertO(runAlternativeIAConnectfilename);
                if (runAlternativeIAConnectarguments != null)
                {
                    runAlternativeIAConnect["Arguments"] = ExpressionConverter.ConvertO(runAlternativeIAConnectarguments);
                    runAlternativeIAConnectpropCount++;
                }

                if (runAlternativeIAConnectloadIntoMemory != null)
                {
                    if (runAlternativeIAConnectloadIntoMemory != null)
                    {
                        runAlternativeIAConnect["LoadIntoMemory"] = ExpressionConverter.ConvertO(runAlternativeIAConnectloadIntoMemory);
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
                runAlternativeIAConnect["Workflow"] = ExpressionConverter.ConvertO(runAlternativeIAConnectworkflow);
                if (runAlternativeIAConnectpropCount > 0)
                {
                    callPayload.Body = runAlternativeIAConnect;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRunAlternativeIAConnectSentFromDirector))]
        public IBodyWorkflowAction<RunAlternativeIAConnectSentFromDirectorResponse> RunAlternativeIAConnectSentFromDirector([WorkflowExpression] Func<string> runAlternativeIAConnectSentFromDirectorlocalFilename, [WorkflowExpression] Func<string> runAlternativeIAConnectSentFromDirectorworkflow, [WorkflowExpression] Func<string> runAlternativeIAConnectSentFromDirectorremoteFilename = null, [WorkflowExpression] Func<bool> runAlternativeIAConnectSentFromDirectorcompress = null, [WorkflowExpression] Func<string> runAlternativeIAConnectSentFromDirectorarguments = null, [WorkflowExpression] Func<bool> runAlternativeIAConnectSentFromDirectorpermitDowngrade = null, [WorkflowExpression] Func<bool> runAlternativeIAConnectSentFromDirectorskipVersionCheck = null, [WorkflowExpression] Func<bool> runAlternativeIAConnectSentFromDirectorloadIntoMemory = null, [WorkflowExpression] Func<bool> runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunAlternativeIAConnectSentFromDirectorResponse> __BuildRunAlternativeIAConnectSentFromDirector(WorkflowValue<string> runAlternativeIAConnectSentFromDirectorlocalFilename, WorkflowValue<string> runAlternativeIAConnectSentFromDirectorworkflow, WorkflowValue<string> runAlternativeIAConnectSentFromDirectorremoteFilename = null, WorkflowValue<bool> runAlternativeIAConnectSentFromDirectorcompress = null, WorkflowValue<string> runAlternativeIAConnectSentFromDirectorarguments = null, WorkflowValue<bool> runAlternativeIAConnectSentFromDirectorpermitDowngrade = null, WorkflowValue<bool> runAlternativeIAConnectSentFromDirectorskipVersionCheck = null, WorkflowValue<bool> runAlternativeIAConnectSentFromDirectorloadIntoMemory = null, WorkflowValue<bool> runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory = null)
        {
            WorkflowValue.Validate(runAlternativeIAConnectSentFromDirectorlocalFilename, nameof(runAlternativeIAConnectSentFromDirectorlocalFilename), required: true);
            WorkflowValue.Validate(runAlternativeIAConnectSentFromDirectorworkflow, nameof(runAlternativeIAConnectSentFromDirectorworkflow), required: true);
            WorkflowValue.Validate(runAlternativeIAConnectSentFromDirectorremoteFilename, nameof(runAlternativeIAConnectSentFromDirectorremoteFilename), required: false);
            WorkflowValue.Validate(runAlternativeIAConnectSentFromDirectorcompress, nameof(runAlternativeIAConnectSentFromDirectorcompress), required: false);
            WorkflowValue.Validate(runAlternativeIAConnectSentFromDirectorarguments, nameof(runAlternativeIAConnectSentFromDirectorarguments), required: false);
            WorkflowValue.Validate(runAlternativeIAConnectSentFromDirectorpermitDowngrade, nameof(runAlternativeIAConnectSentFromDirectorpermitDowngrade), required: false);
            WorkflowValue.Validate(runAlternativeIAConnectSentFromDirectorskipVersionCheck, nameof(runAlternativeIAConnectSentFromDirectorskipVersionCheck), required: false);
            WorkflowValue.Validate(runAlternativeIAConnectSentFromDirectorloadIntoMemory, nameof(runAlternativeIAConnectSentFromDirectorloadIntoMemory), required: false);
            WorkflowValue.Validate(runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory, nameof(runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory), required: false);
            return new DeferredBodyAction<RunAlternativeIAConnectSentFromDirectorResponse>(() =>
            {
                var apiCallPath = "/DriverControl/RunAlternativeIAConnectSentFromDirector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runAlternativeIAConnectSentFromDirector = new JObject();
                var runAlternativeIAConnectSentFromDirectorpropCount = 0;
                runAlternativeIAConnectSentFromDirectorpropCount++;
                runAlternativeIAConnectSentFromDirector["LocalFilename"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorlocalFilename);
                if (runAlternativeIAConnectSentFromDirectorremoteFilename != null)
                {
                    runAlternativeIAConnectSentFromDirector["RemoteFilename"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorremoteFilename);
                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }

                if (runAlternativeIAConnectSentFromDirectorcompress != null)
                {
                    if (runAlternativeIAConnectSentFromDirectorcompress != null)
                    {
                        runAlternativeIAConnectSentFromDirector["Compress"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorcompress);
                        runAlternativeIAConnectSentFromDirectorpropCount++;
                    }

                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }
                else
                {
                    runAlternativeIAConnectSentFromDirector["Compress"] = true;
                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }

                if (runAlternativeIAConnectSentFromDirectorarguments != null)
                {
                    runAlternativeIAConnectSentFromDirector["Arguments"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorarguments);
                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }

                if (runAlternativeIAConnectSentFromDirectorpermitDowngrade != null)
                {
                    if (runAlternativeIAConnectSentFromDirectorpermitDowngrade != null)
                    {
                        runAlternativeIAConnectSentFromDirector["PermitDowngrade"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorpermitDowngrade);
                        runAlternativeIAConnectSentFromDirectorpropCount++;
                    }

                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }
                else
                {
                    runAlternativeIAConnectSentFromDirector["PermitDowngrade"] = false;
                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }

                if (runAlternativeIAConnectSentFromDirectorskipVersionCheck != null)
                {
                    if (runAlternativeIAConnectSentFromDirectorskipVersionCheck != null)
                    {
                        runAlternativeIAConnectSentFromDirector["SkipVersionCheck"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorskipVersionCheck);
                        runAlternativeIAConnectSentFromDirectorpropCount++;
                    }

                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }
                else
                {
                    runAlternativeIAConnectSentFromDirector["SkipVersionCheck"] = false;
                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }

                if (runAlternativeIAConnectSentFromDirectorloadIntoMemory != null)
                {
                    if (runAlternativeIAConnectSentFromDirectorloadIntoMemory != null)
                    {
                        runAlternativeIAConnectSentFromDirector["LoadIntoMemory"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorloadIntoMemory);
                        runAlternativeIAConnectSentFromDirectorpropCount++;
                    }

                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }
                else
                {
                    runAlternativeIAConnectSentFromDirector["LoadIntoMemory"] = true;
                    runAlternativeIAConnectSentFromDirectorpropCount++;
                }

                if (runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory != null)
                {
                    if (runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory != null)
                    {
                        runAlternativeIAConnectSentFromDirector["SaveToDiskEvenIfRunningFromMemory"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory);
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
                runAlternativeIAConnectSentFromDirector["Workflow"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorworkflow);
                if (runAlternativeIAConnectSentFromDirectorpropCount > 0)
                {
                    callPayload.Body = runAlternativeIAConnectSentFromDirector;
                }

                return new ApiConnectionAction<RunAlternativeIAConnectSentFromDirectorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetIAConnectAgentInfo))]
        public IBodyWorkflowAction<GetIAConnectAgentInfoResponse> GetIAConnectAgentInfo([WorkflowExpression] Func<string> getIAConnectAgentInfoworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIAConnectAgentInfoResponse> __BuildGetIAConnectAgentInfo(WorkflowValue<string> getIAConnectAgentInfoworkflow)
        {
            WorkflowValue.Validate(getIAConnectAgentInfoworkflow, nameof(getIAConnectAgentInfoworkflow), required: true);
            return new DeferredBodyAction<GetIAConnectAgentInfoResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetIAConnectAgentInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectAgentInfo = new JObject();
                var getIAConnectAgentInfopropCount = 0;
                getIAConnectAgentInfopropCount++;
                getIAConnectAgentInfo["Workflow"] = ExpressionConverter.ConvertO(getIAConnectAgentInfoworkflow);
                if (getIAConnectAgentInfopropCount > 0)
                {
                    callPayload.Body = getIAConnectAgentInfo;
                }

                return new ApiConnectionAction<GetIAConnectAgentInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetIAConnectAgentLog))]
        public IBodyWorkflowAction<GetIAConnectAgentLogResponse> GetIAConnectAgentLog([WorkflowExpression] Func<string> getIAConnectAgentLogworkflow, [WorkflowExpression] Func<bool> getIAConnectAgentLogcompress = null, [WorkflowExpression] Func<bool> getIAConnectAgentLogreturnLastCommandOnly = null, [WorkflowExpression] Func<bool> getIAConnectAgentLogsaveLogToFile = null, [WorkflowExpression] Func<bool> getIAConnectAgentLogplaceLogContentInDataItem = null, [WorkflowExpression] Func<string> getIAConnectAgentLoglocalSaveFolder = null, [WorkflowExpression] Func<bool> getIAConnectAgentLoguseAgentLogFilename = null, [WorkflowExpression] Func<string> getIAConnectAgentLoglocalSaveFilename = null, [WorkflowExpression] Func<int> getIAConnectAgentLogmaxBytesToRead = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIAConnectAgentLogResponse> __BuildGetIAConnectAgentLog(WorkflowValue<string> getIAConnectAgentLogworkflow, WorkflowValue<bool> getIAConnectAgentLogcompress = null, WorkflowValue<bool> getIAConnectAgentLogreturnLastCommandOnly = null, WorkflowValue<bool> getIAConnectAgentLogsaveLogToFile = null, WorkflowValue<bool> getIAConnectAgentLogplaceLogContentInDataItem = null, WorkflowValue<string> getIAConnectAgentLoglocalSaveFolder = null, WorkflowValue<bool> getIAConnectAgentLoguseAgentLogFilename = null, WorkflowValue<string> getIAConnectAgentLoglocalSaveFilename = null, WorkflowValue<int> getIAConnectAgentLogmaxBytesToRead = null)
        {
            WorkflowValue.Validate(getIAConnectAgentLogworkflow, nameof(getIAConnectAgentLogworkflow), required: true);
            WorkflowValue.Validate(getIAConnectAgentLogcompress, nameof(getIAConnectAgentLogcompress), required: false);
            WorkflowValue.Validate(getIAConnectAgentLogreturnLastCommandOnly, nameof(getIAConnectAgentLogreturnLastCommandOnly), required: false);
            WorkflowValue.Validate(getIAConnectAgentLogsaveLogToFile, nameof(getIAConnectAgentLogsaveLogToFile), required: false);
            WorkflowValue.Validate(getIAConnectAgentLogplaceLogContentInDataItem, nameof(getIAConnectAgentLogplaceLogContentInDataItem), required: false);
            WorkflowValue.Validate(getIAConnectAgentLoglocalSaveFolder, nameof(getIAConnectAgentLoglocalSaveFolder), required: false);
            WorkflowValue.Validate(getIAConnectAgentLoguseAgentLogFilename, nameof(getIAConnectAgentLoguseAgentLogFilename), required: false);
            WorkflowValue.Validate(getIAConnectAgentLoglocalSaveFilename, nameof(getIAConnectAgentLoglocalSaveFilename), required: false);
            WorkflowValue.Validate(getIAConnectAgentLogmaxBytesToRead, nameof(getIAConnectAgentLogmaxBytesToRead), required: false);
            return new DeferredBodyAction<GetIAConnectAgentLogResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetIAConnectAgentLog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectAgentLog = new JObject();
                var getIAConnectAgentLogpropCount = 0;
                if (getIAConnectAgentLogcompress != null)
                {
                    if (getIAConnectAgentLogcompress != null)
                    {
                        getIAConnectAgentLog["Compress"] = ExpressionConverter.ConvertO(getIAConnectAgentLogcompress);
                        getIAConnectAgentLogpropCount++;
                    }

                    getIAConnectAgentLogpropCount++;
                }
                else
                {
                    getIAConnectAgentLog["Compress"] = true;
                    getIAConnectAgentLogpropCount++;
                }

                if (getIAConnectAgentLogreturnLastCommandOnly != null)
                {
                    if (getIAConnectAgentLogreturnLastCommandOnly != null)
                    {
                        getIAConnectAgentLog["ReturnLastCommandOnly"] = ExpressionConverter.ConvertO(getIAConnectAgentLogreturnLastCommandOnly);
                        getIAConnectAgentLogpropCount++;
                    }

                    getIAConnectAgentLogpropCount++;
                }
                else
                {
                    getIAConnectAgentLog["ReturnLastCommandOnly"] = false;
                    getIAConnectAgentLogpropCount++;
                }

                if (getIAConnectAgentLogsaveLogToFile != null)
                {
                    if (getIAConnectAgentLogsaveLogToFile != null)
                    {
                        getIAConnectAgentLog["SaveLogToFile"] = ExpressionConverter.ConvertO(getIAConnectAgentLogsaveLogToFile);
                        getIAConnectAgentLogpropCount++;
                    }

                    getIAConnectAgentLogpropCount++;
                }
                else
                {
                    getIAConnectAgentLog["SaveLogToFile"] = true;
                    getIAConnectAgentLogpropCount++;
                }

                if (getIAConnectAgentLogplaceLogContentInDataItem != null)
                {
                    if (getIAConnectAgentLogplaceLogContentInDataItem != null)
                    {
                        getIAConnectAgentLog["PlaceLogContentInDataItem"] = ExpressionConverter.ConvertO(getIAConnectAgentLogplaceLogContentInDataItem);
                        getIAConnectAgentLogpropCount++;
                    }

                    getIAConnectAgentLogpropCount++;
                }
                else
                {
                    getIAConnectAgentLog["PlaceLogContentInDataItem"] = false;
                    getIAConnectAgentLogpropCount++;
                }

                if (getIAConnectAgentLoglocalSaveFolder != null)
                {
                    getIAConnectAgentLog["LocalSaveFolder"] = ExpressionConverter.ConvertO(getIAConnectAgentLoglocalSaveFolder);
                    getIAConnectAgentLogpropCount++;
                }

                if (getIAConnectAgentLoguseAgentLogFilename != null)
                {
                    if (getIAConnectAgentLoguseAgentLogFilename != null)
                    {
                        getIAConnectAgentLog["UseAgentLogFilename"] = ExpressionConverter.ConvertO(getIAConnectAgentLoguseAgentLogFilename);
                        getIAConnectAgentLogpropCount++;
                    }

                    getIAConnectAgentLogpropCount++;
                }
                else
                {
                    getIAConnectAgentLog["UseAgentLogFilename"] = true;
                    getIAConnectAgentLogpropCount++;
                }

                if (getIAConnectAgentLoglocalSaveFilename != null)
                {
                    getIAConnectAgentLog["LocalSaveFilename"] = ExpressionConverter.ConvertO(getIAConnectAgentLoglocalSaveFilename);
                    getIAConnectAgentLogpropCount++;
                }

                if (getIAConnectAgentLogmaxBytesToRead != null)
                {
                    if (getIAConnectAgentLogmaxBytesToRead != null)
                    {
                        getIAConnectAgentLog["MaxBytesToRead"] = ExpressionConverter.ConvertO(getIAConnectAgentLogmaxBytesToRead);
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
                getIAConnectAgentLog["Workflow"] = ExpressionConverter.ConvertO(getIAConnectAgentLogworkflow);
                if (getIAConnectAgentLogpropCount > 0)
                {
                    callPayload.Body = getIAConnectAgentLog;
                }

                return new ApiConnectionAction<GetIAConnectAgentLogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildResetCommandStats))]
        public IWorkflowAction ResetCommandStats([WorkflowExpression] Func<string> resetCommandStatsworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildResetCommandStats(WorkflowValue<string> resetCommandStatsworkflow)
        {
            WorkflowValue.Validate(resetCommandStatsworkflow, nameof(resetCommandStatsworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/ResetCommandStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var resetCommandStats = new JObject();
                var resetCommandStatspropCount = 0;
                resetCommandStatspropCount++;
                resetCommandStats["Workflow"] = ExpressionConverter.ConvertO(resetCommandStatsworkflow);
                if (resetCommandStatspropCount > 0)
                {
                    callPayload.Body = resetCommandStats;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllCommandStats))]
        public IBodyWorkflowAction<GetAllCommandStatsResponse> GetAllCommandStats([WorkflowExpression] Func<string> getAllCommandStatsworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllCommandStatsResponse> __BuildGetAllCommandStats(WorkflowValue<string> getAllCommandStatsworkflow)
        {
            WorkflowValue.Validate(getAllCommandStatsworkflow, nameof(getAllCommandStatsworkflow), required: true);
            return new DeferredBodyAction<GetAllCommandStatsResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetAllCommandStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getAllCommandStats = new JObject();
                var getAllCommandStatspropCount = 0;
                getAllCommandStatspropCount++;
                getAllCommandStats["Workflow"] = ExpressionConverter.ConvertO(getAllCommandStatsworkflow);
                if (getAllCommandStatspropCount > 0)
                {
                    callPayload.Body = getAllCommandStats;
                }

                return new ApiConnectionAction<GetAllCommandStatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildEnableNextHop))]
        public IBodyWorkflowAction<EnableNextHopResponse> EnableNextHop([WorkflowExpression] Func<string> enableNextHopworkflow, [WorkflowExpression] Func<string> enableNextHopnextHopDirectorAddress = null, [WorkflowExpression] Func<int> enableNextHopnextHopDirectorTCPPort = null, [WorkflowExpression] Func<bool> enableNextHopnextHopDirectorUsesHTTPS = null, [WorkflowExpression] Func<bool> enableNextHopnextHopDirectorAddressIsLocalhostname = null, [WorkflowExpression] Func<bool> enableNextHopnextHopDirectorAddressIsHostname = null, [WorkflowExpression] Func<bool> enableNextHopnextHopDirectorAddressIsFQDN = null, [WorkflowExpression] Func<bool> enableNextHopincrementNextHopDirectorTCPPortBySessionId = null, [WorkflowExpression] Func<bool> enableNextHopdisableBeforeEnable = null, [WorkflowExpression] Func<bool> enableNextHopcheckNextHopDirectorIsRunning = null, [WorkflowExpression] Func<bool> enableNextHopcheckNextHopAgentIsRunning = null, [WorkflowExpression] Func<bool> enableNextHopnextHopDirectorAddressIsNamedPipe = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EnableNextHopResponse> __BuildEnableNextHop(WorkflowValue<string> enableNextHopworkflow, WorkflowValue<string> enableNextHopnextHopDirectorAddress = null, WorkflowValue<int> enableNextHopnextHopDirectorTCPPort = null, WorkflowValue<bool> enableNextHopnextHopDirectorUsesHTTPS = null, WorkflowValue<bool> enableNextHopnextHopDirectorAddressIsLocalhostname = null, WorkflowValue<bool> enableNextHopnextHopDirectorAddressIsHostname = null, WorkflowValue<bool> enableNextHopnextHopDirectorAddressIsFQDN = null, WorkflowValue<bool> enableNextHopincrementNextHopDirectorTCPPortBySessionId = null, WorkflowValue<bool> enableNextHopdisableBeforeEnable = null, WorkflowValue<bool> enableNextHopcheckNextHopDirectorIsRunning = null, WorkflowValue<bool> enableNextHopcheckNextHopAgentIsRunning = null, WorkflowValue<bool> enableNextHopnextHopDirectorAddressIsNamedPipe = null)
        {
            WorkflowValue.Validate(enableNextHopworkflow, nameof(enableNextHopworkflow), required: true);
            WorkflowValue.Validate(enableNextHopnextHopDirectorAddress, nameof(enableNextHopnextHopDirectorAddress), required: false);
            WorkflowValue.Validate(enableNextHopnextHopDirectorTCPPort, nameof(enableNextHopnextHopDirectorTCPPort), required: false);
            WorkflowValue.Validate(enableNextHopnextHopDirectorUsesHTTPS, nameof(enableNextHopnextHopDirectorUsesHTTPS), required: false);
            WorkflowValue.Validate(enableNextHopnextHopDirectorAddressIsLocalhostname, nameof(enableNextHopnextHopDirectorAddressIsLocalhostname), required: false);
            WorkflowValue.Validate(enableNextHopnextHopDirectorAddressIsHostname, nameof(enableNextHopnextHopDirectorAddressIsHostname), required: false);
            WorkflowValue.Validate(enableNextHopnextHopDirectorAddressIsFQDN, nameof(enableNextHopnextHopDirectorAddressIsFQDN), required: false);
            WorkflowValue.Validate(enableNextHopincrementNextHopDirectorTCPPortBySessionId, nameof(enableNextHopincrementNextHopDirectorTCPPortBySessionId), required: false);
            WorkflowValue.Validate(enableNextHopdisableBeforeEnable, nameof(enableNextHopdisableBeforeEnable), required: false);
            WorkflowValue.Validate(enableNextHopcheckNextHopDirectorIsRunning, nameof(enableNextHopcheckNextHopDirectorIsRunning), required: false);
            WorkflowValue.Validate(enableNextHopcheckNextHopAgentIsRunning, nameof(enableNextHopcheckNextHopAgentIsRunning), required: false);
            WorkflowValue.Validate(enableNextHopnextHopDirectorAddressIsNamedPipe, nameof(enableNextHopnextHopDirectorAddressIsNamedPipe), required: false);
            return new DeferredBodyAction<EnableNextHopResponse>(() =>
            {
                var apiCallPath = "/DriverControl/EnableNextHop";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var enableNextHop = new JObject();
                var enableNextHoppropCount = 0;
                if (enableNextHopnextHopDirectorAddress != null)
                {
                    enableNextHop["NextHopDirectorAddress"] = ExpressionConverter.ConvertO(enableNextHopnextHopDirectorAddress);
                    enableNextHoppropCount++;
                }

                if (enableNextHopnextHopDirectorTCPPort != null)
                {
                    if (enableNextHopnextHopDirectorTCPPort != null)
                    {
                        enableNextHop["NextHopDirectorTCPPort"] = ExpressionConverter.ConvertO(enableNextHopnextHopDirectorTCPPort);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["NextHopDirectorTCPPort"] = 8002;
                    enableNextHoppropCount++;
                }

                if (enableNextHopnextHopDirectorUsesHTTPS != null)
                {
                    if (enableNextHopnextHopDirectorUsesHTTPS != null)
                    {
                        enableNextHop["NextHopDirectorUsesHTTPS"] = ExpressionConverter.ConvertO(enableNextHopnextHopDirectorUsesHTTPS);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["NextHopDirectorUsesHTTPS"] = false;
                    enableNextHoppropCount++;
                }

                if (enableNextHopnextHopDirectorAddressIsLocalhostname != null)
                {
                    if (enableNextHopnextHopDirectorAddressIsLocalhostname != null)
                    {
                        enableNextHop["NextHopDirectorAddressIsLocalhostname"] = ExpressionConverter.ConvertO(enableNextHopnextHopDirectorAddressIsLocalhostname);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["NextHopDirectorAddressIsLocalhostname"] = false;
                    enableNextHoppropCount++;
                }

                if (enableNextHopnextHopDirectorAddressIsHostname != null)
                {
                    if (enableNextHopnextHopDirectorAddressIsHostname != null)
                    {
                        enableNextHop["NextHopDirectorAddressIsHostname"] = ExpressionConverter.ConvertO(enableNextHopnextHopDirectorAddressIsHostname);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["NextHopDirectorAddressIsHostname"] = false;
                    enableNextHoppropCount++;
                }

                if (enableNextHopnextHopDirectorAddressIsFQDN != null)
                {
                    if (enableNextHopnextHopDirectorAddressIsFQDN != null)
                    {
                        enableNextHop["NextHopDirectorAddressIsFQDN"] = ExpressionConverter.ConvertO(enableNextHopnextHopDirectorAddressIsFQDN);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["NextHopDirectorAddressIsFQDN"] = false;
                    enableNextHoppropCount++;
                }

                if (enableNextHopincrementNextHopDirectorTCPPortBySessionId != null)
                {
                    if (enableNextHopincrementNextHopDirectorTCPPortBySessionId != null)
                    {
                        enableNextHop["IncrementNextHopDirectorTCPPortBySessionId"] = ExpressionConverter.ConvertO(enableNextHopincrementNextHopDirectorTCPPortBySessionId);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["IncrementNextHopDirectorTCPPortBySessionId"] = true;
                    enableNextHoppropCount++;
                }

                if (enableNextHopdisableBeforeEnable != null)
                {
                    if (enableNextHopdisableBeforeEnable != null)
                    {
                        enableNextHop["DisableBeforeEnable"] = ExpressionConverter.ConvertO(enableNextHopdisableBeforeEnable);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["DisableBeforeEnable"] = true;
                    enableNextHoppropCount++;
                }

                if (enableNextHopcheckNextHopDirectorIsRunning != null)
                {
                    if (enableNextHopcheckNextHopDirectorIsRunning != null)
                    {
                        enableNextHop["CheckNextHopDirectorIsRunning"] = ExpressionConverter.ConvertO(enableNextHopcheckNextHopDirectorIsRunning);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["CheckNextHopDirectorIsRunning"] = false;
                    enableNextHoppropCount++;
                }

                if (enableNextHopcheckNextHopAgentIsRunning != null)
                {
                    if (enableNextHopcheckNextHopAgentIsRunning != null)
                    {
                        enableNextHop["CheckNextHopAgentIsRunning"] = ExpressionConverter.ConvertO(enableNextHopcheckNextHopAgentIsRunning);
                        enableNextHoppropCount++;
                    }

                    enableNextHoppropCount++;
                }
                else
                {
                    enableNextHop["CheckNextHopAgentIsRunning"] = false;
                    enableNextHoppropCount++;
                }

                if (enableNextHopnextHopDirectorAddressIsNamedPipe != null)
                {
                    if (enableNextHopnextHopDirectorAddressIsNamedPipe != null)
                    {
                        enableNextHop["NextHopDirectorAddressIsNamedPipe"] = ExpressionConverter.ConvertO(enableNextHopnextHopDirectorAddressIsNamedPipe);
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
                enableNextHop["Workflow"] = ExpressionConverter.ConvertO(enableNextHopworkflow);
                if (enableNextHoppropCount > 0)
                {
                    callPayload.Body = enableNextHop;
                }

                return new ApiConnectionAction<EnableNextHopResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildDisableNextHop))]
        public IWorkflowAction DisableNextHop([WorkflowExpression] Func<string> disableNextHopworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDisableNextHop(WorkflowValue<string> disableNextHopworkflow)
        {
            WorkflowValue.Validate(disableNextHopworkflow, nameof(disableNextHopworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/DisableNextHop";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var disableNextHop = new JObject();
                var disableNextHoppropCount = 0;
                disableNextHoppropCount++;
                disableNextHop["Workflow"] = ExpressionConverter.ConvertO(disableNextHopworkflow);
                if (disableNextHoppropCount > 0)
                {
                    callPayload.Body = disableNextHop;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetNextHopStatus))]
        public IBodyWorkflowAction<GetNextHopStatusResponse> GetNextHopStatus([WorkflowExpression] Func<string> getNextHopStatusworkflow, [WorkflowExpression] Func<bool> getNextHopStatuscheckNextHopDirectorIsRunning = null, [WorkflowExpression] Func<bool> getNextHopStatuscheckNextHopAgentIsRunning = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetNextHopStatusResponse> __BuildGetNextHopStatus(WorkflowValue<string> getNextHopStatusworkflow, WorkflowValue<bool> getNextHopStatuscheckNextHopDirectorIsRunning = null, WorkflowValue<bool> getNextHopStatuscheckNextHopAgentIsRunning = null)
        {
            WorkflowValue.Validate(getNextHopStatusworkflow, nameof(getNextHopStatusworkflow), required: true);
            WorkflowValue.Validate(getNextHopStatuscheckNextHopDirectorIsRunning, nameof(getNextHopStatuscheckNextHopDirectorIsRunning), required: false);
            WorkflowValue.Validate(getNextHopStatuscheckNextHopAgentIsRunning, nameof(getNextHopStatuscheckNextHopAgentIsRunning), required: false);
            return new DeferredBodyAction<GetNextHopStatusResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetNextHopStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getNextHopStatus = new JObject();
                var getNextHopStatuspropCount = 0;
                if (getNextHopStatuscheckNextHopDirectorIsRunning != null)
                {
                    if (getNextHopStatuscheckNextHopDirectorIsRunning != null)
                    {
                        getNextHopStatus["CheckNextHopDirectorIsRunning"] = ExpressionConverter.ConvertO(getNextHopStatuscheckNextHopDirectorIsRunning);
                        getNextHopStatuspropCount++;
                    }

                    getNextHopStatuspropCount++;
                }
                else
                {
                    getNextHopStatus["CheckNextHopDirectorIsRunning"] = false;
                    getNextHopStatuspropCount++;
                }

                if (getNextHopStatuscheckNextHopAgentIsRunning != null)
                {
                    if (getNextHopStatuscheckNextHopAgentIsRunning != null)
                    {
                        getNextHopStatus["CheckNextHopAgentIsRunning"] = ExpressionConverter.ConvertO(getNextHopStatuscheckNextHopAgentIsRunning);
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
                getNextHopStatus["Workflow"] = ExpressionConverter.ConvertO(getNextHopStatusworkflow);
                if (getNextHopStatuspropCount > 0)
                {
                    callPayload.Body = getNextHopStatus;
                }

                return new ApiConnectionAction<GetNextHopStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildWaitForNextHopSessionToConnect))]
        public IBodyWorkflowAction<WaitForNextHopSessionToConnectResponse> WaitForNextHopSessionToConnect([WorkflowExpression] Func<string> waitForNextHopSessionToConnectworkflow, [WorkflowExpression] Func<string> waitForNextHopSessionToConnectnextHopDirectorAddress = null, [WorkflowExpression] Func<int> waitForNextHopSessionToConnectnextHopDirectorTCPPort = null, [WorkflowExpression] Func<bool> waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS = null, [WorkflowExpression] Func<bool> waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname = null, [WorkflowExpression] Func<bool> waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname = null, [WorkflowExpression] Func<bool> waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN = null, [WorkflowExpression] Func<bool> waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId = null, [WorkflowExpression] Func<double> waitForNextHopSessionToConnectsecondsToWait = null, [WorkflowExpression] Func<bool> waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe = null, [WorkflowExpression] Func<bool> waitForNextHopSessionToConnectdisableExistingNextHop = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WaitForNextHopSessionToConnectResponse> __BuildWaitForNextHopSessionToConnect(WorkflowValue<string> waitForNextHopSessionToConnectworkflow, WorkflowValue<string> waitForNextHopSessionToConnectnextHopDirectorAddress = null, WorkflowValue<int> waitForNextHopSessionToConnectnextHopDirectorTCPPort = null, WorkflowValue<bool> waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS = null, WorkflowValue<bool> waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname = null, WorkflowValue<bool> waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname = null, WorkflowValue<bool> waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN = null, WorkflowValue<bool> waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId = null, WorkflowValue<double> waitForNextHopSessionToConnectsecondsToWait = null, WorkflowValue<bool> waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe = null, WorkflowValue<bool> waitForNextHopSessionToConnectdisableExistingNextHop = null)
        {
            WorkflowValue.Validate(waitForNextHopSessionToConnectworkflow, nameof(waitForNextHopSessionToConnectworkflow), required: true);
            WorkflowValue.Validate(waitForNextHopSessionToConnectnextHopDirectorAddress, nameof(waitForNextHopSessionToConnectnextHopDirectorAddress), required: false);
            WorkflowValue.Validate(waitForNextHopSessionToConnectnextHopDirectorTCPPort, nameof(waitForNextHopSessionToConnectnextHopDirectorTCPPort), required: false);
            WorkflowValue.Validate(waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS, nameof(waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS), required: false);
            WorkflowValue.Validate(waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname, nameof(waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname), required: false);
            WorkflowValue.Validate(waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname, nameof(waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname), required: false);
            WorkflowValue.Validate(waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN, nameof(waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN), required: false);
            WorkflowValue.Validate(waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId, nameof(waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId), required: false);
            WorkflowValue.Validate(waitForNextHopSessionToConnectsecondsToWait, nameof(waitForNextHopSessionToConnectsecondsToWait), required: false);
            WorkflowValue.Validate(waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe, nameof(waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe), required: false);
            WorkflowValue.Validate(waitForNextHopSessionToConnectdisableExistingNextHop, nameof(waitForNextHopSessionToConnectdisableExistingNextHop), required: false);
            return new DeferredBodyAction<WaitForNextHopSessionToConnectResponse>(() =>
            {
                var apiCallPath = "/DriverControl/WaitForNextHopSessionToConnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var waitForNextHopSessionToConnect = new JObject();
                var waitForNextHopSessionToConnectpropCount = 0;
                if (waitForNextHopSessionToConnectnextHopDirectorAddress != null)
                {
                    waitForNextHopSessionToConnect["NextHopDirectorAddress"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectnextHopDirectorAddress);
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (waitForNextHopSessionToConnectnextHopDirectorTCPPort != null)
                {
                    if (waitForNextHopSessionToConnectnextHopDirectorTCPPort != null)
                    {
                        waitForNextHopSessionToConnect["NextHopDirectorTCPPort"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectnextHopDirectorTCPPort);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["NextHopDirectorTCPPort"] = 8002;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS != null)
                {
                    if (waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS != null)
                    {
                        waitForNextHopSessionToConnect["NextHopDirectorUsesHTTPS"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["NextHopDirectorUsesHTTPS"] = false;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname != null)
                {
                    if (waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname != null)
                    {
                        waitForNextHopSessionToConnect["NextHopDirectorAddressIsLocalhostname"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["NextHopDirectorAddressIsLocalhostname"] = false;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname != null)
                {
                    if (waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname != null)
                    {
                        waitForNextHopSessionToConnect["NextHopDirectorAddressIsHostname"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["NextHopDirectorAddressIsHostname"] = false;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN != null)
                {
                    if (waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN != null)
                    {
                        waitForNextHopSessionToConnect["NextHopDirectorAddressIsFQDN"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["NextHopDirectorAddressIsFQDN"] = false;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId != null)
                {
                    if (waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId != null)
                    {
                        waitForNextHopSessionToConnect["IncrementNextHopDirectorTCPPortBySessionId"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["IncrementNextHopDirectorTCPPortBySessionId"] = true;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (waitForNextHopSessionToConnectsecondsToWait != null)
                {
                    if (waitForNextHopSessionToConnectsecondsToWait != null)
                    {
                        waitForNextHopSessionToConnect["SecondsToWait"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectsecondsToWait);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["SecondsToWait"] = 35;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe != null)
                {
                    if (waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe != null)
                    {
                        waitForNextHopSessionToConnect["NextHopDirectorAddressIsNamedPipe"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe);
                        waitForNextHopSessionToConnectpropCount++;
                    }

                    waitForNextHopSessionToConnectpropCount++;
                }
                else
                {
                    waitForNextHopSessionToConnect["NextHopDirectorAddressIsNamedPipe"] = true;
                    waitForNextHopSessionToConnectpropCount++;
                }

                if (waitForNextHopSessionToConnectdisableExistingNextHop != null)
                {
                    if (waitForNextHopSessionToConnectdisableExistingNextHop != null)
                    {
                        waitForNextHopSessionToConnect["DisableExistingNextHop"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectdisableExistingNextHop);
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
                waitForNextHopSessionToConnect["Workflow"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectworkflow);
                if (waitForNextHopSessionToConnectpropCount > 0)
                {
                    callPayload.Body = waitForNextHopSessionToConnect;
                }

                return new ApiConnectionAction<WaitForNextHopSessionToConnectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildConfigureNextHopDirector))]
        public IWorkflowAction ConfigureNextHopDirector([WorkflowExpression] Func<string> configureNextHopDirectorworkflow, [WorkflowExpression] Func<bool> configureNextHopDirectorsOAPEnabled = null, [WorkflowExpression] Func<bool> configureNextHopDirectorrESTEnabled = null, [WorkflowExpression] Func<bool> configureNextHopDirectorwebServerEnabled = null, [WorkflowExpression] Func<bool> configureNextHopDirectordirectorIsLocalhostOnly = null, [WorkflowExpression] Func<int> configureNextHopDirectorsOAPTCPPort = null, [WorkflowExpression] Func<int> configureNextHopDirectorrESTTCPPort = null, [WorkflowExpression] Func<bool> configureNextHopDirectorsOAPUsesHTTPS = null, [WorkflowExpression] Func<bool> configureNextHopDirectorrESTUsesHTTPS = null, [WorkflowExpression] Func<bool> configureNextHopDirectorincrementDirectorTCPPortBySessionId = null, [WorkflowExpression] Func<bool> configureNextHopDirectorsOAPUsesUserAuthentication = null, [WorkflowExpression] Func<bool> configureNextHopDirectorrESTUsesUserAuthentication = null, [WorkflowExpression] Func<bool> configureNextHopDirectorcommandNamedPipeEnabled = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildConfigureNextHopDirector(WorkflowValue<string> configureNextHopDirectorworkflow, WorkflowValue<bool> configureNextHopDirectorsOAPEnabled = null, WorkflowValue<bool> configureNextHopDirectorrESTEnabled = null, WorkflowValue<bool> configureNextHopDirectorwebServerEnabled = null, WorkflowValue<bool> configureNextHopDirectordirectorIsLocalhostOnly = null, WorkflowValue<int> configureNextHopDirectorsOAPTCPPort = null, WorkflowValue<int> configureNextHopDirectorrESTTCPPort = null, WorkflowValue<bool> configureNextHopDirectorsOAPUsesHTTPS = null, WorkflowValue<bool> configureNextHopDirectorrESTUsesHTTPS = null, WorkflowValue<bool> configureNextHopDirectorincrementDirectorTCPPortBySessionId = null, WorkflowValue<bool> configureNextHopDirectorsOAPUsesUserAuthentication = null, WorkflowValue<bool> configureNextHopDirectorrESTUsesUserAuthentication = null, WorkflowValue<bool> configureNextHopDirectorcommandNamedPipeEnabled = null)
        {
            WorkflowValue.Validate(configureNextHopDirectorworkflow, nameof(configureNextHopDirectorworkflow), required: true);
            WorkflowValue.Validate(configureNextHopDirectorsOAPEnabled, nameof(configureNextHopDirectorsOAPEnabled), required: false);
            WorkflowValue.Validate(configureNextHopDirectorrESTEnabled, nameof(configureNextHopDirectorrESTEnabled), required: false);
            WorkflowValue.Validate(configureNextHopDirectorwebServerEnabled, nameof(configureNextHopDirectorwebServerEnabled), required: false);
            WorkflowValue.Validate(configureNextHopDirectordirectorIsLocalhostOnly, nameof(configureNextHopDirectordirectorIsLocalhostOnly), required: false);
            WorkflowValue.Validate(configureNextHopDirectorsOAPTCPPort, nameof(configureNextHopDirectorsOAPTCPPort), required: false);
            WorkflowValue.Validate(configureNextHopDirectorrESTTCPPort, nameof(configureNextHopDirectorrESTTCPPort), required: false);
            WorkflowValue.Validate(configureNextHopDirectorsOAPUsesHTTPS, nameof(configureNextHopDirectorsOAPUsesHTTPS), required: false);
            WorkflowValue.Validate(configureNextHopDirectorrESTUsesHTTPS, nameof(configureNextHopDirectorrESTUsesHTTPS), required: false);
            WorkflowValue.Validate(configureNextHopDirectorincrementDirectorTCPPortBySessionId, nameof(configureNextHopDirectorincrementDirectorTCPPortBySessionId), required: false);
            WorkflowValue.Validate(configureNextHopDirectorsOAPUsesUserAuthentication, nameof(configureNextHopDirectorsOAPUsesUserAuthentication), required: false);
            WorkflowValue.Validate(configureNextHopDirectorrESTUsesUserAuthentication, nameof(configureNextHopDirectorrESTUsesUserAuthentication), required: false);
            WorkflowValue.Validate(configureNextHopDirectorcommandNamedPipeEnabled, nameof(configureNextHopDirectorcommandNamedPipeEnabled), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/ConfigureNextHopDirector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var configureNextHopDirector = new JObject();
                var configureNextHopDirectorpropCount = 0;
                if (configureNextHopDirectorsOAPEnabled != null)
                {
                    if (configureNextHopDirectorsOAPEnabled != null)
                    {
                        configureNextHopDirector["SOAPEnabled"] = ExpressionConverter.ConvertO(configureNextHopDirectorsOAPEnabled);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["SOAPEnabled"] = false;
                    configureNextHopDirectorpropCount++;
                }

                if (configureNextHopDirectorrESTEnabled != null)
                {
                    if (configureNextHopDirectorrESTEnabled != null)
                    {
                        configureNextHopDirector["RESTEnabled"] = ExpressionConverter.ConvertO(configureNextHopDirectorrESTEnabled);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["RESTEnabled"] = false;
                    configureNextHopDirectorpropCount++;
                }

                if (configureNextHopDirectorwebServerEnabled != null)
                {
                    if (configureNextHopDirectorwebServerEnabled != null)
                    {
                        configureNextHopDirector["WebServerEnabled"] = ExpressionConverter.ConvertO(configureNextHopDirectorwebServerEnabled);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["WebServerEnabled"] = false;
                    configureNextHopDirectorpropCount++;
                }

                if (configureNextHopDirectordirectorIsLocalhostOnly != null)
                {
                    if (configureNextHopDirectordirectorIsLocalhostOnly != null)
                    {
                        configureNextHopDirector["DirectorIsLocalhostOnly"] = ExpressionConverter.ConvertO(configureNextHopDirectordirectorIsLocalhostOnly);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["DirectorIsLocalhostOnly"] = true;
                    configureNextHopDirectorpropCount++;
                }

                if (configureNextHopDirectorsOAPTCPPort != null)
                {
                    if (configureNextHopDirectorsOAPTCPPort != null)
                    {
                        configureNextHopDirector["SOAPTCPPort"] = ExpressionConverter.ConvertO(configureNextHopDirectorsOAPTCPPort);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["SOAPTCPPort"] = 8002;
                    configureNextHopDirectorpropCount++;
                }

                if (configureNextHopDirectorrESTTCPPort != null)
                {
                    if (configureNextHopDirectorrESTTCPPort != null)
                    {
                        configureNextHopDirector["RESTTCPPort"] = ExpressionConverter.ConvertO(configureNextHopDirectorrESTTCPPort);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["RESTTCPPort"] = 8002;
                    configureNextHopDirectorpropCount++;
                }

                if (configureNextHopDirectorsOAPUsesHTTPS != null)
                {
                    if (configureNextHopDirectorsOAPUsesHTTPS != null)
                    {
                        configureNextHopDirector["SOAPUsesHTTPS"] = ExpressionConverter.ConvertO(configureNextHopDirectorsOAPUsesHTTPS);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["SOAPUsesHTTPS"] = false;
                    configureNextHopDirectorpropCount++;
                }

                if (configureNextHopDirectorrESTUsesHTTPS != null)
                {
                    if (configureNextHopDirectorrESTUsesHTTPS != null)
                    {
                        configureNextHopDirector["RESTUsesHTTPS"] = ExpressionConverter.ConvertO(configureNextHopDirectorrESTUsesHTTPS);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["RESTUsesHTTPS"] = false;
                    configureNextHopDirectorpropCount++;
                }

                if (configureNextHopDirectorincrementDirectorTCPPortBySessionId != null)
                {
                    if (configureNextHopDirectorincrementDirectorTCPPortBySessionId != null)
                    {
                        configureNextHopDirector["IncrementDirectorTCPPortBySessionId"] = ExpressionConverter.ConvertO(configureNextHopDirectorincrementDirectorTCPPortBySessionId);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["IncrementDirectorTCPPortBySessionId"] = true;
                    configureNextHopDirectorpropCount++;
                }

                if (configureNextHopDirectorsOAPUsesUserAuthentication != null)
                {
                    if (configureNextHopDirectorsOAPUsesUserAuthentication != null)
                    {
                        configureNextHopDirector["SOAPUsesUserAuthentication"] = ExpressionConverter.ConvertO(configureNextHopDirectorsOAPUsesUserAuthentication);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["SOAPUsesUserAuthentication"] = false;
                    configureNextHopDirectorpropCount++;
                }

                if (configureNextHopDirectorrESTUsesUserAuthentication != null)
                {
                    if (configureNextHopDirectorrESTUsesUserAuthentication != null)
                    {
                        configureNextHopDirector["RESTUsesUserAuthentication"] = ExpressionConverter.ConvertO(configureNextHopDirectorrESTUsesUserAuthentication);
                        configureNextHopDirectorpropCount++;
                    }

                    configureNextHopDirectorpropCount++;
                }
                else
                {
                    configureNextHopDirector["RESTUsesUserAuthentication"] = false;
                    configureNextHopDirectorpropCount++;
                }

                if (configureNextHopDirectorcommandNamedPipeEnabled != null)
                {
                    if (configureNextHopDirectorcommandNamedPipeEnabled != null)
                    {
                        configureNextHopDirector["CommandNamedPipeEnabled"] = ExpressionConverter.ConvertO(configureNextHopDirectorcommandNamedPipeEnabled);
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
                configureNextHopDirector["Workflow"] = ExpressionConverter.ConvertO(configureNextHopDirectorworkflow);
                if (configureNextHopDirectorpropCount > 0)
                {
                    callPayload.Body = configureNextHopDirector;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildResetNextHopDirectorSettings))]
        public IWorkflowAction ResetNextHopDirectorSettings([WorkflowExpression] Func<string> resetNextHopDirectorSettingsworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildResetNextHopDirectorSettings(WorkflowValue<string> resetNextHopDirectorSettingsworkflow)
        {
            WorkflowValue.Validate(resetNextHopDirectorSettingsworkflow, nameof(resetNextHopDirectorSettingsworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/ResetNextHopDirectorSettings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var resetNextHopDirectorSettings = new JObject();
                var resetNextHopDirectorSettingspropCount = 0;
                resetNextHopDirectorSettingspropCount++;
                resetNextHopDirectorSettings["Workflow"] = ExpressionConverter.ConvertO(resetNextHopDirectorSettingsworkflow);
                if (resetNextHopDirectorSettingspropCount > 0)
                {
                    callPayload.Body = resetNextHopDirectorSettings;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildWorkflowCompleted))]
        public IWorkflowAction WorkflowCompleted([WorkflowExpression] Func<string> workflowCompletedworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildWorkflowCompleted(WorkflowValue<string> workflowCompletedworkflow)
        {
            WorkflowValue.Validate(workflowCompletedworkflow, nameof(workflowCompletedworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/WorkflowCompleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var workflowCompleted = new JObject();
                var workflowCompletedpropCount = 0;
                workflowCompletedpropCount++;
                workflowCompleted["Workflow"] = ExpressionConverter.ConvertO(workflowCompletedworkflow);
                if (workflowCompletedpropCount > 0)
                {
                    callPayload.Body = workflowCompleted;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRaiseException))]
        public IBodyWorkflowAction<RaiseExceptionResponse> RaiseException([WorkflowExpression] Func<string> raiseExceptioninputException = null, [WorkflowExpression] Func<string> raiseExceptionexceptionMessage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RaiseExceptionResponse> __BuildRaiseException(WorkflowValue<string> raiseExceptioninputException = null, WorkflowValue<string> raiseExceptionexceptionMessage = null)
        {
            WorkflowValue.Validate(raiseExceptioninputException, nameof(raiseExceptioninputException), required: false);
            WorkflowValue.Validate(raiseExceptionexceptionMessage, nameof(raiseExceptionexceptionMessage), required: false);
            return new DeferredBodyAction<RaiseExceptionResponse>(() =>
            {
                var apiCallPath = "/DriverControl/RaiseException";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var raiseException = new JObject();
                var raiseExceptionpropCount = 0;
                if (raiseExceptioninputException != null)
                {
                    raiseException["InputException"] = ExpressionConverter.ConvertO(raiseExceptioninputException);
                    raiseExceptionpropCount++;
                }

                if (raiseExceptionexceptionMessage != null)
                {
                    raiseException["ExceptionMessage"] = ExpressionConverter.ConvertO(raiseExceptionexceptionMessage);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateOrchestratorFlowStatsResult))]
        public IBodyWorkflowAction<UpdateOrchestratorFlowStatsResultResponse> UpdateOrchestratorFlowStatsResult([WorkflowExpression] Func<string> updateOrchestratorFlowStatsResultworkflow, [WorkflowExpression] Func<bool> updateOrchestratorFlowStatsResultflowLastActionSuccess = null, [WorkflowExpression] Func<string> updateOrchestratorFlowStatsResultflowLastActionErrorMessage = null, [WorkflowExpression] Func<int> updateOrchestratorFlowStatsResultflowLastActionCode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateOrchestratorFlowStatsResultResponse> __BuildUpdateOrchestratorFlowStatsResult(WorkflowValue<string> updateOrchestratorFlowStatsResultworkflow, WorkflowValue<bool> updateOrchestratorFlowStatsResultflowLastActionSuccess = null, WorkflowValue<string> updateOrchestratorFlowStatsResultflowLastActionErrorMessage = null, WorkflowValue<int> updateOrchestratorFlowStatsResultflowLastActionCode = null)
        {
            WorkflowValue.Validate(updateOrchestratorFlowStatsResultworkflow, nameof(updateOrchestratorFlowStatsResultworkflow), required: true);
            WorkflowValue.Validate(updateOrchestratorFlowStatsResultflowLastActionSuccess, nameof(updateOrchestratorFlowStatsResultflowLastActionSuccess), required: false);
            WorkflowValue.Validate(updateOrchestratorFlowStatsResultflowLastActionErrorMessage, nameof(updateOrchestratorFlowStatsResultflowLastActionErrorMessage), required: false);
            WorkflowValue.Validate(updateOrchestratorFlowStatsResultflowLastActionCode, nameof(updateOrchestratorFlowStatsResultflowLastActionCode), required: false);
            return new DeferredBodyAction<UpdateOrchestratorFlowStatsResultResponse>(() =>
            {
                var apiCallPath = "/DriverControl/UpdateOrchestratorFlowStatsResult";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var updateOrchestratorFlowStatsResult = new JObject();
                var updateOrchestratorFlowStatsResultpropCount = 0;
                if (updateOrchestratorFlowStatsResultflowLastActionSuccess != null)
                {
                    updateOrchestratorFlowStatsResult["FlowLastActionSuccess"] = ExpressionConverter.ConvertO(updateOrchestratorFlowStatsResultflowLastActionSuccess);
                    updateOrchestratorFlowStatsResultpropCount++;
                }

                if (updateOrchestratorFlowStatsResultflowLastActionErrorMessage != null)
                {
                    updateOrchestratorFlowStatsResult["FlowLastActionErrorMessage"] = ExpressionConverter.ConvertO(updateOrchestratorFlowStatsResultflowLastActionErrorMessage);
                    updateOrchestratorFlowStatsResultpropCount++;
                }

                if (updateOrchestratorFlowStatsResultflowLastActionCode != null)
                {
                    updateOrchestratorFlowStatsResult["FlowLastActionCode"] = ExpressionConverter.ConvertO(updateOrchestratorFlowStatsResultflowLastActionCode);
                    updateOrchestratorFlowStatsResultpropCount++;
                }

                updateOrchestratorFlowStatsResultpropCount++;
                updateOrchestratorFlowStatsResult["Workflow"] = ExpressionConverter.ConvertO(updateOrchestratorFlowStatsResultworkflow);
                if (updateOrchestratorFlowStatsResultpropCount > 0)
                {
                    callPayload.Body = updateOrchestratorFlowStatsResult;
                }

                return new ApiConnectionAction<UpdateOrchestratorFlowStatsResultResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetLastFailedActionFromOrchestratorFlowStats))]
        public IBodyWorkflowAction<GetLastFailedActionFromOrchestratorFlowStatsResponse> GetLastFailedActionFromOrchestratorFlowStats([WorkflowExpression] Func<string> getLastFailedActionFromOrchestratorFlowStatsworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLastFailedActionFromOrchestratorFlowStatsResponse> __BuildGetLastFailedActionFromOrchestratorFlowStats(WorkflowValue<string> getLastFailedActionFromOrchestratorFlowStatsworkflow)
        {
            WorkflowValue.Validate(getLastFailedActionFromOrchestratorFlowStatsworkflow, nameof(getLastFailedActionFromOrchestratorFlowStatsworkflow), required: true);
            return new DeferredBodyAction<GetLastFailedActionFromOrchestratorFlowStatsResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetLastFailedActionFromOrchestratorFlowStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getLastFailedActionFromOrchestratorFlowStats = new JObject();
                var getLastFailedActionFromOrchestratorFlowStatspropCount = 0;
                getLastFailedActionFromOrchestratorFlowStatspropCount++;
                getLastFailedActionFromOrchestratorFlowStats["Workflow"] = ExpressionConverter.ConvertO(getLastFailedActionFromOrchestratorFlowStatsworkflow);
                if (getLastFailedActionFromOrchestratorFlowStatspropCount > 0)
                {
                    callPayload.Body = getLastFailedActionFromOrchestratorFlowStats;
                }

                return new ApiConnectionAction<GetLastFailedActionFromOrchestratorFlowStatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetOrchestratorFlowStats))]
        public IBodyWorkflowAction<GetOrchestratorFlowStatsResponse> GetOrchestratorFlowStats([WorkflowExpression] Func<int> getOrchestratorFlowStatswithinLastNumberOfDays = null, [WorkflowExpression] Func<string> getOrchestratorFlowStatssearchFlowName = null, [WorkflowExpression] Func<bool> getOrchestratorFlowStatssearchFlowLastActionResult = null, [WorkflowExpression] Func<string> getOrchestratorFlowStatssearchFlowStartTimeStartWindow = null, [WorkflowExpression] Func<string> getOrchestratorFlowStatssearchFlowStartTimeEndWindow = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOrchestratorFlowStatsResponse> __BuildGetOrchestratorFlowStats(WorkflowValue<int> getOrchestratorFlowStatswithinLastNumberOfDays = null, WorkflowValue<string> getOrchestratorFlowStatssearchFlowName = null, WorkflowValue<bool> getOrchestratorFlowStatssearchFlowLastActionResult = null, WorkflowValue<string> getOrchestratorFlowStatssearchFlowStartTimeStartWindow = null, WorkflowValue<string> getOrchestratorFlowStatssearchFlowStartTimeEndWindow = null)
        {
            WorkflowValue.Validate(getOrchestratorFlowStatswithinLastNumberOfDays, nameof(getOrchestratorFlowStatswithinLastNumberOfDays), required: false);
            WorkflowValue.Validate(getOrchestratorFlowStatssearchFlowName, nameof(getOrchestratorFlowStatssearchFlowName), required: false);
            WorkflowValue.Validate(getOrchestratorFlowStatssearchFlowLastActionResult, nameof(getOrchestratorFlowStatssearchFlowLastActionResult), required: false);
            WorkflowValue.Validate(getOrchestratorFlowStatssearchFlowStartTimeStartWindow, nameof(getOrchestratorFlowStatssearchFlowStartTimeStartWindow), required: false);
            WorkflowValue.Validate(getOrchestratorFlowStatssearchFlowStartTimeEndWindow, nameof(getOrchestratorFlowStatssearchFlowStartTimeEndWindow), required: false);
            return new DeferredBodyAction<GetOrchestratorFlowStatsResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorFlowStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getOrchestratorFlowStats = new JObject();
                var getOrchestratorFlowStatspropCount = 0;
                if (getOrchestratorFlowStatswithinLastNumberOfDays != null)
                {
                    getOrchestratorFlowStats["WithinLastNumberOfDays"] = ExpressionConverter.ConvertO(getOrchestratorFlowStatswithinLastNumberOfDays);
                    getOrchestratorFlowStatspropCount++;
                }

                if (getOrchestratorFlowStatssearchFlowName != null)
                {
                    getOrchestratorFlowStats["SearchFlowName"] = ExpressionConverter.ConvertO(getOrchestratorFlowStatssearchFlowName);
                    getOrchestratorFlowStatspropCount++;
                }

                if (getOrchestratorFlowStatssearchFlowLastActionResult != null)
                {
                    getOrchestratorFlowStats["SearchFlowLastActionResult"] = ExpressionConverter.ConvertO(getOrchestratorFlowStatssearchFlowLastActionResult);
                    getOrchestratorFlowStatspropCount++;
                }

                if (getOrchestratorFlowStatssearchFlowStartTimeStartWindow != null)
                {
                    getOrchestratorFlowStats["SearchFlowStartTimeStartWindow"] = ExpressionConverter.ConvertO(getOrchestratorFlowStatssearchFlowStartTimeStartWindow);
                    getOrchestratorFlowStatspropCount++;
                }

                if (getOrchestratorFlowStatssearchFlowStartTimeEndWindow != null)
                {
                    getOrchestratorFlowStats["SearchFlowStartTimeEndWindow"] = ExpressionConverter.ConvertO(getOrchestratorFlowStatssearchFlowStartTimeEndWindow);
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
        [WorkflowExpressionFactory(nameof(__BuildGetOrchestratorWorkerAvailabilityStats))]
        public IBodyWorkflowAction<GetOrchestratorWorkerAvailabilityStatsResponse> GetOrchestratorWorkerAvailabilityStats([WorkflowExpression] Func<int> getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays = null, [WorkflowExpression] Func<string> getOrchestratorWorkerAvailabilityStatssearchFlowName = null, [WorkflowExpression] Func<string> getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOrchestratorWorkerAvailabilityStatsResponse> __BuildGetOrchestratorWorkerAvailabilityStats(WorkflowValue<int> getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays = null, WorkflowValue<string> getOrchestratorWorkerAvailabilityStatssearchFlowName = null, WorkflowValue<string> getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow = null)
        {
            WorkflowValue.Validate(getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays, nameof(getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays), required: false);
            WorkflowValue.Validate(getOrchestratorWorkerAvailabilityStatssearchFlowName, nameof(getOrchestratorWorkerAvailabilityStatssearchFlowName), required: false);
            WorkflowValue.Validate(getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow, nameof(getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow), required: false);
            return new DeferredBodyAction<GetOrchestratorWorkerAvailabilityStatsResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorWorkerAvailabilityStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getOrchestratorWorkerAvailabilityStats = new JObject();
                var getOrchestratorWorkerAvailabilityStatspropCount = 0;
                if (getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays != null)
                {
                    getOrchestratorWorkerAvailabilityStats["WithinLastNumberOfDays"] = ExpressionConverter.ConvertO(getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays);
                    getOrchestratorWorkerAvailabilityStatspropCount++;
                }

                if (getOrchestratorWorkerAvailabilityStatssearchFlowName != null)
                {
                    getOrchestratorWorkerAvailabilityStats["SearchFlowName"] = ExpressionConverter.ConvertO(getOrchestratorWorkerAvailabilityStatssearchFlowName);
                    getOrchestratorWorkerAvailabilityStatspropCount++;
                }

                if (getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow != null)
                {
                    getOrchestratorWorkerAvailabilityStats["SearchFlowStartTimeStartWindow"] = ExpressionConverter.ConvertO(getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow);
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
        [WorkflowExpressionFactory(nameof(__BuildGetOrchestratorWorkerFlowUsageHeatmap))]
        public IBodyWorkflowAction<GetOrchestratorWorkerFlowUsageHeatmapResponse> GetOrchestratorWorkerFlowUsageHeatmap([WorkflowExpression] Func<string> getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow, [WorkflowExpression] Func<string> getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow, [WorkflowExpression] Func<int> getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC = null, [WorkflowExpression] Func<string> getOrchestratorWorkerFlowUsageHeatmapworkerNames = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOrchestratorWorkerFlowUsageHeatmapResponse> __BuildGetOrchestratorWorkerFlowUsageHeatmap(WorkflowValue<string> getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow, WorkflowValue<string> getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow, WorkflowValue<int> getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC = null, WorkflowValue<string> getOrchestratorWorkerFlowUsageHeatmapworkerNames = null)
        {
            WorkflowValue.Validate(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow, nameof(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow), required: true);
            WorkflowValue.Validate(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow, nameof(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow), required: true);
            WorkflowValue.Validate(getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC, nameof(getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC), required: false);
            WorkflowValue.Validate(getOrchestratorWorkerFlowUsageHeatmapworkerNames, nameof(getOrchestratorWorkerFlowUsageHeatmapworkerNames), required: false);
            return new DeferredBodyAction<GetOrchestratorWorkerFlowUsageHeatmapResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorWorkerFlowUsageHeatmap";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getOrchestratorWorkerFlowUsageHeatmap = new JObject();
                var getOrchestratorWorkerFlowUsageHeatmappropCount = 0;
                getOrchestratorWorkerFlowUsageHeatmappropCount++;
                getOrchestratorWorkerFlowUsageHeatmap["SearchStartDateStartWindow"] = ExpressionConverter.ConvertO(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow);
                getOrchestratorWorkerFlowUsageHeatmappropCount++;
                getOrchestratorWorkerFlowUsageHeatmap["SearchStartDateEndWindow"] = ExpressionConverter.ConvertO(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow);
                if (getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC != null)
                {
                    if (getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC != null)
                    {
                        getOrchestratorWorkerFlowUsageHeatmap["TimeZoneMinutesOffsetFromUTC"] = ExpressionConverter.ConvertO(getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC);
                        getOrchestratorWorkerFlowUsageHeatmappropCount++;
                    }

                    getOrchestratorWorkerFlowUsageHeatmappropCount++;
                }
                else
                {
                    getOrchestratorWorkerFlowUsageHeatmap["TimeZoneMinutesOffsetFromUTC"] = 0;
                    getOrchestratorWorkerFlowUsageHeatmappropCount++;
                }

                if (getOrchestratorWorkerFlowUsageHeatmapworkerNames != null)
                {
                    getOrchestratorWorkerFlowUsageHeatmap["WorkerNames"] = ExpressionConverter.ConvertO(getOrchestratorWorkerFlowUsageHeatmapworkerNames);
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
        [WorkflowExpressionFactory(nameof(__BuildGetOrchestratorLoginHistory))]
        public IBodyWorkflowAction<GetOrchestratorLoginHistoryResponse> GetOrchestratorLoginHistory([WorkflowExpression] Func<int> getOrchestratorLoginHistorywithinLastNumberOfDays = null, [WorkflowExpression] Func<string> getOrchestratorLoginHistorysearchByEmail = null, [WorkflowExpression] Func<string> getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow = null, [WorkflowExpression] Func<string> getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOrchestratorLoginHistoryResponse> __BuildGetOrchestratorLoginHistory(WorkflowValue<int> getOrchestratorLoginHistorywithinLastNumberOfDays = null, WorkflowValue<string> getOrchestratorLoginHistorysearchByEmail = null, WorkflowValue<string> getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow = null, WorkflowValue<string> getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow = null)
        {
            WorkflowValue.Validate(getOrchestratorLoginHistorywithinLastNumberOfDays, nameof(getOrchestratorLoginHistorywithinLastNumberOfDays), required: false);
            WorkflowValue.Validate(getOrchestratorLoginHistorysearchByEmail, nameof(getOrchestratorLoginHistorysearchByEmail), required: false);
            WorkflowValue.Validate(getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow, nameof(getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow), required: false);
            WorkflowValue.Validate(getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow, nameof(getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow), required: false);
            return new DeferredBodyAction<GetOrchestratorLoginHistoryResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorLoginHistory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getOrchestratorLoginHistory = new JObject();
                var getOrchestratorLoginHistorypropCount = 0;
                if (getOrchestratorLoginHistorywithinLastNumberOfDays != null)
                {
                    getOrchestratorLoginHistory["WithinLastNumberOfDays"] = ExpressionConverter.ConvertO(getOrchestratorLoginHistorywithinLastNumberOfDays);
                    getOrchestratorLoginHistorypropCount++;
                }

                if (getOrchestratorLoginHistorysearchByEmail != null)
                {
                    getOrchestratorLoginHistory["SearchByEmail"] = ExpressionConverter.ConvertO(getOrchestratorLoginHistorysearchByEmail);
                    getOrchestratorLoginHistorypropCount++;
                }

                if (getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow != null)
                {
                    getOrchestratorLoginHistory["SearchLoginHistoryTimeStartWindow"] = ExpressionConverter.ConvertO(getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow);
                    getOrchestratorLoginHistorypropCount++;
                }

                if (getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow != null)
                {
                    getOrchestratorLoginHistory["SearchLoginHistoryTimeEndWindow"] = ExpressionConverter.ConvertO(getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow);
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
        [WorkflowExpressionFactory(nameof(__BuildSetLocalLoggingLevel))]
        public IWorkflowAction SetLocalLoggingLevel([WorkflowExpression] Func<int> setLocalLoggingLevelloggingLevel, [WorkflowExpression] Func<string> setLocalLoggingLevelworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetLocalLoggingLevel(WorkflowValue<int> setLocalLoggingLevelloggingLevel, WorkflowValue<string> setLocalLoggingLevelworkflow)
        {
            WorkflowValue.Validate(setLocalLoggingLevelloggingLevel, nameof(setLocalLoggingLevelloggingLevel), required: true);
            WorkflowValue.Validate(setLocalLoggingLevelworkflow, nameof(setLocalLoggingLevelworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/SetLocalLoggingLevel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setLocalLoggingLevel = new JObject();
                var setLocalLoggingLevelpropCount = 0;
                setLocalLoggingLevelpropCount++;
                setLocalLoggingLevel["LoggingLevel"] = ExpressionConverter.ConvertO(setLocalLoggingLevelloggingLevel);
                setLocalLoggingLevelpropCount++;
                setLocalLoggingLevel["Workflow"] = ExpressionConverter.ConvertO(setLocalLoggingLevelworkflow);
                if (setLocalLoggingLevelpropCount > 0)
                {
                    callPayload.Body = setLocalLoggingLevel;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRunCommand))]
        public IBodyWorkflowAction<RunCommandResponse> RunCommand([WorkflowExpression] Func<string> runCommandcommandName, [WorkflowExpression] Func<string> runCommandworkflow, [WorkflowExpression] Func<string> runCommandinputJSON = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunCommandResponse> __BuildRunCommand(WorkflowValue<string> runCommandcommandName, WorkflowValue<string> runCommandworkflow, WorkflowValue<string> runCommandinputJSON = null)
        {
            WorkflowValue.Validate(runCommandcommandName, nameof(runCommandcommandName), required: true);
            WorkflowValue.Validate(runCommandworkflow, nameof(runCommandworkflow), required: true);
            WorkflowValue.Validate(runCommandinputJSON, nameof(runCommandinputJSON), required: false);
            return new DeferredBodyAction<RunCommandResponse>(() =>
            {
                var apiCallPath = "/DriverControl/RunCommand";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runCommand = new JObject();
                var runCommandpropCount = 0;
                runCommandpropCount++;
                runCommand["CommandName"] = ExpressionConverter.ConvertO(runCommandcommandName);
                if (runCommandinputJSON != null)
                {
                    runCommand["InputJSON"] = ExpressionConverter.ConvertO(runCommandinputJSON);
                    runCommandpropCount++;
                }

                runCommandpropCount++;
                runCommand["Workflow"] = ExpressionConverter.ConvertO(runCommandworkflow);
                if (runCommandpropCount > 0)
                {
                    callPayload.Body = runCommand;
                }

                return new ApiConnectionAction<RunCommandResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetLocalLoggingLevel))]
        public IBodyWorkflowAction<GetLocalLoggingLevelResponse> GetLocalLoggingLevel([WorkflowExpression] Func<string> getLocalLoggingLevelworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLocalLoggingLevelResponse> __BuildGetLocalLoggingLevel(WorkflowValue<string> getLocalLoggingLevelworkflow)
        {
            WorkflowValue.Validate(getLocalLoggingLevelworkflow, nameof(getLocalLoggingLevelworkflow), required: true);
            return new DeferredBodyAction<GetLocalLoggingLevelResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetLocalLoggingLevel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getLocalLoggingLevel = new JObject();
                var getLocalLoggingLevelpropCount = 0;
                getLocalLoggingLevelpropCount++;
                getLocalLoggingLevel["Workflow"] = ExpressionConverter.ConvertO(getLocalLoggingLevelworkflow);
                if (getLocalLoggingLevelpropCount > 0)
                {
                    callPayload.Body = getLocalLoggingLevel;
                }

                return new ApiConnectionAction<GetLocalLoggingLevelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetRemoteClientType))]
        public IBodyWorkflowAction<GetRemoteClientTypeResponse> GetRemoteClientType([WorkflowExpression] Func<string> getRemoteClientTypeworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRemoteClientTypeResponse> __BuildGetRemoteClientType(WorkflowValue<string> getRemoteClientTypeworkflow)
        {
            WorkflowValue.Validate(getRemoteClientTypeworkflow, nameof(getRemoteClientTypeworkflow), required: true);
            return new DeferredBodyAction<GetRemoteClientTypeResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetRemoteClientType";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRemoteClientType = new JObject();
                var getRemoteClientTypepropCount = 0;
                getRemoteClientTypepropCount++;
                getRemoteClientType["Workflow"] = ExpressionConverter.ConvertO(getRemoteClientTypeworkflow);
                if (getRemoteClientTypepropCount > 0)
                {
                    callPayload.Body = getRemoteClientType;
                }

                return new ApiConnectionAction<GetRemoteClientTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetIAConnectDirectorInfo))]
        public IBodyWorkflowAction<GetIAConnectDirectorInfoResponse> GetIAConnectDirectorInfo([WorkflowExpression] Func<string> getIAConnectDirectorInfoworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIAConnectDirectorInfoResponse> __BuildGetIAConnectDirectorInfo(WorkflowValue<string> getIAConnectDirectorInfoworkflow)
        {
            WorkflowValue.Validate(getIAConnectDirectorInfoworkflow, nameof(getIAConnectDirectorInfoworkflow), required: true);
            return new DeferredBodyAction<GetIAConnectDirectorInfoResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetIAConnectDirectorInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectDirectorInfo = new JObject();
                var getIAConnectDirectorInfopropCount = 0;
                getIAConnectDirectorInfopropCount++;
                getIAConnectDirectorInfo["Workflow"] = ExpressionConverter.ConvertO(getIAConnectDirectorInfoworkflow);
                if (getIAConnectDirectorInfopropCount > 0)
                {
                    callPayload.Body = getIAConnectDirectorInfo;
                }

                return new ApiConnectionAction<GetIAConnectDirectorInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetAvailableIAConnectSessions))]
        public IBodyWorkflowAction<GetAvailableIAConnectSessionsResponse> GetAvailableIAConnectSessions([WorkflowExpression] Func<string> getAvailableIAConnectSessionsworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAvailableIAConnectSessionsResponse> __BuildGetAvailableIAConnectSessions(WorkflowValue<string> getAvailableIAConnectSessionsworkflow)
        {
            WorkflowValue.Validate(getAvailableIAConnectSessionsworkflow, nameof(getAvailableIAConnectSessionsworkflow), required: true);
            return new DeferredBodyAction<GetAvailableIAConnectSessionsResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetAvailableIAConnectSessions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getAvailableIAConnectSessions = new JObject();
                var getAvailableIAConnectSessionspropCount = 0;
                getAvailableIAConnectSessionspropCount++;
                getAvailableIAConnectSessions["Workflow"] = ExpressionConverter.ConvertO(getAvailableIAConnectSessionsworkflow);
                if (getAvailableIAConnectSessionspropCount > 0)
                {
                    callPayload.Body = getAvailableIAConnectSessions;
                }

                return new ApiConnectionAction<GetAvailableIAConnectSessionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildAttachToIAConnectSessionByName))]
        public IWorkflowAction AttachToIAConnectSessionByName([WorkflowExpression] Func<string> attachToIAConnectSessionByNameiAConnectSessionName, [WorkflowExpression] Func<string> attachToIAConnectSessionByNameworkflow, [WorkflowExpression] Func<bool> attachToIAConnectSessionByNamevirtualChannelMustBeConnected = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAttachToIAConnectSessionByName(WorkflowValue<string> attachToIAConnectSessionByNameiAConnectSessionName, WorkflowValue<string> attachToIAConnectSessionByNameworkflow, WorkflowValue<bool> attachToIAConnectSessionByNamevirtualChannelMustBeConnected = null)
        {
            WorkflowValue.Validate(attachToIAConnectSessionByNameiAConnectSessionName, nameof(attachToIAConnectSessionByNameiAConnectSessionName), required: true);
            WorkflowValue.Validate(attachToIAConnectSessionByNameworkflow, nameof(attachToIAConnectSessionByNameworkflow), required: true);
            WorkflowValue.Validate(attachToIAConnectSessionByNamevirtualChannelMustBeConnected, nameof(attachToIAConnectSessionByNamevirtualChannelMustBeConnected), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DriverControl/AttachToIAConnectSessionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var attachToIAConnectSessionByName = new JObject();
                var attachToIAConnectSessionByNamepropCount = 0;
                attachToIAConnectSessionByNamepropCount++;
                attachToIAConnectSessionByName["IAConnectSessionName"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByNameiAConnectSessionName);
                if (attachToIAConnectSessionByNamevirtualChannelMustBeConnected != null)
                {
                    if (attachToIAConnectSessionByNamevirtualChannelMustBeConnected != null)
                    {
                        attachToIAConnectSessionByName["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByNamevirtualChannelMustBeConnected);
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
                attachToIAConnectSessionByName["Workflow"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByNameworkflow);
                if (attachToIAConnectSessionByNamepropCount > 0)
                {
                    callPayload.Body = attachToIAConnectSessionByName;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildAttachToTier1IAConnectSession))]
        public IBodyWorkflowAction<AttachToTier1IAConnectSessionResponse> AttachToTier1IAConnectSession([WorkflowExpression] Func<string> attachToTier1IAConnectSessionworkflow, [WorkflowExpression] Func<bool> attachToTier1IAConnectSessionvirtualChannelMustBeConnected = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AttachToTier1IAConnectSessionResponse> __BuildAttachToTier1IAConnectSession(WorkflowValue<string> attachToTier1IAConnectSessionworkflow, WorkflowValue<bool> attachToTier1IAConnectSessionvirtualChannelMustBeConnected = null)
        {
            WorkflowValue.Validate(attachToTier1IAConnectSessionworkflow, nameof(attachToTier1IAConnectSessionworkflow), required: true);
            WorkflowValue.Validate(attachToTier1IAConnectSessionvirtualChannelMustBeConnected, nameof(attachToTier1IAConnectSessionvirtualChannelMustBeConnected), required: false);
            return new DeferredBodyAction<AttachToTier1IAConnectSessionResponse>(() =>
            {
                var apiCallPath = "/DriverControl/AttachToTier1IAConnectSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var attachToTier1IAConnectSession = new JObject();
                var attachToTier1IAConnectSessionpropCount = 0;
                if (attachToTier1IAConnectSessionvirtualChannelMustBeConnected != null)
                {
                    if (attachToTier1IAConnectSessionvirtualChannelMustBeConnected != null)
                    {
                        attachToTier1IAConnectSession["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(attachToTier1IAConnectSessionvirtualChannelMustBeConnected);
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
                attachToTier1IAConnectSession["Workflow"] = ExpressionConverter.ConvertO(attachToTier1IAConnectSessionworkflow);
                if (attachToTier1IAConnectSessionpropCount > 0)
                {
                    callPayload.Body = attachToTier1IAConnectSession;
                }

                return new ApiConnectionAction<AttachToTier1IAConnectSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildAttachToIAConnectSessionByIndex))]
        public IBodyWorkflowAction<AttachToIAConnectSessionByIndexResponse> AttachToIAConnectSessionByIndex([WorkflowExpression] Func<string> attachToIAConnectSessionByIndexworkflow, [WorkflowExpression] Func<attachToIAConnectSessionByIndexsearchIAConnectSessionTypeInput> attachToIAConnectSessionByIndexsearchIAConnectSessionType = null, [WorkflowExpression] Func<int> attachToIAConnectSessionByIndexsearchIAConnectSessionIndex = null, [WorkflowExpression] Func<int> attachToIAConnectSessionByIndextimeToWaitInSeconds = null, [WorkflowExpression] Func<bool> attachToIAConnectSessionByIndexraiseExceptionIfTimedout = null, [WorkflowExpression] Func<bool> attachToIAConnectSessionByIndexvirtualChannelMustBeConnected = null, [WorkflowExpression] Func<bool> attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AttachToIAConnectSessionByIndexResponse> __BuildAttachToIAConnectSessionByIndex(WorkflowValue<string> attachToIAConnectSessionByIndexworkflow, WorkflowValue<attachToIAConnectSessionByIndexsearchIAConnectSessionTypeInput> attachToIAConnectSessionByIndexsearchIAConnectSessionType = null, WorkflowValue<int> attachToIAConnectSessionByIndexsearchIAConnectSessionIndex = null, WorkflowValue<int> attachToIAConnectSessionByIndextimeToWaitInSeconds = null, WorkflowValue<bool> attachToIAConnectSessionByIndexraiseExceptionIfTimedout = null, WorkflowValue<bool> attachToIAConnectSessionByIndexvirtualChannelMustBeConnected = null, WorkflowValue<bool> attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore = null)
        {
            WorkflowValue.Validate(attachToIAConnectSessionByIndexworkflow, nameof(attachToIAConnectSessionByIndexworkflow), required: true);
            WorkflowValue.Validate(attachToIAConnectSessionByIndexsearchIAConnectSessionType, nameof(attachToIAConnectSessionByIndexsearchIAConnectSessionType), required: false);
            WorkflowValue.Validate(attachToIAConnectSessionByIndexsearchIAConnectSessionIndex, nameof(attachToIAConnectSessionByIndexsearchIAConnectSessionIndex), required: false);
            WorkflowValue.Validate(attachToIAConnectSessionByIndextimeToWaitInSeconds, nameof(attachToIAConnectSessionByIndextimeToWaitInSeconds), required: false);
            WorkflowValue.Validate(attachToIAConnectSessionByIndexraiseExceptionIfTimedout, nameof(attachToIAConnectSessionByIndexraiseExceptionIfTimedout), required: false);
            WorkflowValue.Validate(attachToIAConnectSessionByIndexvirtualChannelMustBeConnected, nameof(attachToIAConnectSessionByIndexvirtualChannelMustBeConnected), required: false);
            WorkflowValue.Validate(attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore, nameof(attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore), required: false);
            return new DeferredBodyAction<AttachToIAConnectSessionByIndexResponse>(() =>
            {
                var apiCallPath = "/DriverControl/AttachToIAConnectSessionByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var attachToIAConnectSessionByIndex = new JObject();
                var attachToIAConnectSessionByIndexpropCount = 0;
                if (attachToIAConnectSessionByIndexsearchIAConnectSessionType != null)
                {
                    attachToIAConnectSessionByIndex["SearchIAConnectSessionType"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexsearchIAConnectSessionType);
                    attachToIAConnectSessionByIndexpropCount++;
                }

                if (attachToIAConnectSessionByIndexsearchIAConnectSessionIndex != null)
                {
                    attachToIAConnectSessionByIndex["SearchIAConnectSessionIndex"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexsearchIAConnectSessionIndex);
                    attachToIAConnectSessionByIndexpropCount++;
                }

                if (attachToIAConnectSessionByIndextimeToWaitInSeconds != null)
                {
                    attachToIAConnectSessionByIndex["TimeToWaitInSeconds"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndextimeToWaitInSeconds);
                    attachToIAConnectSessionByIndexpropCount++;
                }

                if (attachToIAConnectSessionByIndexraiseExceptionIfTimedout != null)
                {
                    if (attachToIAConnectSessionByIndexraiseExceptionIfTimedout != null)
                    {
                        attachToIAConnectSessionByIndex["RaiseExceptionIfTimedout"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexraiseExceptionIfTimedout);
                        attachToIAConnectSessionByIndexpropCount++;
                    }

                    attachToIAConnectSessionByIndexpropCount++;
                }
                else
                {
                    attachToIAConnectSessionByIndex["RaiseExceptionIfTimedout"] = true;
                    attachToIAConnectSessionByIndexpropCount++;
                }

                if (attachToIAConnectSessionByIndexvirtualChannelMustBeConnected != null)
                {
                    if (attachToIAConnectSessionByIndexvirtualChannelMustBeConnected != null)
                    {
                        attachToIAConnectSessionByIndex["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexvirtualChannelMustBeConnected);
                        attachToIAConnectSessionByIndexpropCount++;
                    }

                    attachToIAConnectSessionByIndexpropCount++;
                }
                else
                {
                    attachToIAConnectSessionByIndex["VirtualChannelMustBeConnected"] = true;
                    attachToIAConnectSessionByIndexpropCount++;
                }

                if (attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore != null)
                {
                    if (attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore != null)
                    {
                        attachToIAConnectSessionByIndex["OnlyCountSessionsNotSeenBefore"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore);
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
                attachToIAConnectSessionByIndex["Workflow"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexworkflow);
                if (attachToIAConnectSessionByIndexpropCount > 0)
                {
                    callPayload.Body = attachToIAConnectSessionByIndex;
                }

                return new ApiConnectionAction<AttachToIAConnectSessionByIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildAttachToMostRecentIAConnectSession))]
        public IBodyWorkflowAction<AttachToMostRecentIAConnectSessionResponse> AttachToMostRecentIAConnectSession([WorkflowExpression] Func<string> attachToMostRecentIAConnectSessionworkflow, [WorkflowExpression] Func<attachToMostRecentIAConnectSessionsearchIAConnectSessionTypeInput> attachToMostRecentIAConnectSessionsearchIAConnectSessionType = null, [WorkflowExpression] Func<int> attachToMostRecentIAConnectSessiontimeToWaitInSeconds = null, [WorkflowExpression] Func<bool> attachToMostRecentIAConnectSessionraiseExceptionIfTimedout = null, [WorkflowExpression] Func<bool> attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected = null, [WorkflowExpression] Func<bool> attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AttachToMostRecentIAConnectSessionResponse> __BuildAttachToMostRecentIAConnectSession(WorkflowValue<string> attachToMostRecentIAConnectSessionworkflow, WorkflowValue<attachToMostRecentIAConnectSessionsearchIAConnectSessionTypeInput> attachToMostRecentIAConnectSessionsearchIAConnectSessionType = null, WorkflowValue<int> attachToMostRecentIAConnectSessiontimeToWaitInSeconds = null, WorkflowValue<bool> attachToMostRecentIAConnectSessionraiseExceptionIfTimedout = null, WorkflowValue<bool> attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected = null, WorkflowValue<bool> attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore = null)
        {
            WorkflowValue.Validate(attachToMostRecentIAConnectSessionworkflow, nameof(attachToMostRecentIAConnectSessionworkflow), required: true);
            WorkflowValue.Validate(attachToMostRecentIAConnectSessionsearchIAConnectSessionType, nameof(attachToMostRecentIAConnectSessionsearchIAConnectSessionType), required: false);
            WorkflowValue.Validate(attachToMostRecentIAConnectSessiontimeToWaitInSeconds, nameof(attachToMostRecentIAConnectSessiontimeToWaitInSeconds), required: false);
            WorkflowValue.Validate(attachToMostRecentIAConnectSessionraiseExceptionIfTimedout, nameof(attachToMostRecentIAConnectSessionraiseExceptionIfTimedout), required: false);
            WorkflowValue.Validate(attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected, nameof(attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected), required: false);
            WorkflowValue.Validate(attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore, nameof(attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore), required: false);
            return new DeferredBodyAction<AttachToMostRecentIAConnectSessionResponse>(() =>
            {
                var apiCallPath = "/DriverControl/AttachToMostRecentIAConnectSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var attachToMostRecentIAConnectSession = new JObject();
                var attachToMostRecentIAConnectSessionpropCount = 0;
                if (attachToMostRecentIAConnectSessionsearchIAConnectSessionType != null)
                {
                    attachToMostRecentIAConnectSession["SearchIAConnectSessionType"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessionsearchIAConnectSessionType);
                    attachToMostRecentIAConnectSessionpropCount++;
                }

                if (attachToMostRecentIAConnectSessiontimeToWaitInSeconds != null)
                {
                    attachToMostRecentIAConnectSession["TimeToWaitInSeconds"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessiontimeToWaitInSeconds);
                    attachToMostRecentIAConnectSessionpropCount++;
                }

                if (attachToMostRecentIAConnectSessionraiseExceptionIfTimedout != null)
                {
                    if (attachToMostRecentIAConnectSessionraiseExceptionIfTimedout != null)
                    {
                        attachToMostRecentIAConnectSession["RaiseExceptionIfTimedout"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessionraiseExceptionIfTimedout);
                        attachToMostRecentIAConnectSessionpropCount++;
                    }

                    attachToMostRecentIAConnectSessionpropCount++;
                }
                else
                {
                    attachToMostRecentIAConnectSession["RaiseExceptionIfTimedout"] = true;
                    attachToMostRecentIAConnectSessionpropCount++;
                }

                if (attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected != null)
                {
                    if (attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected != null)
                    {
                        attachToMostRecentIAConnectSession["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected);
                        attachToMostRecentIAConnectSessionpropCount++;
                    }

                    attachToMostRecentIAConnectSessionpropCount++;
                }
                else
                {
                    attachToMostRecentIAConnectSession["VirtualChannelMustBeConnected"] = true;
                    attachToMostRecentIAConnectSessionpropCount++;
                }

                if (attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore != null)
                {
                    if (attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore != null)
                    {
                        attachToMostRecentIAConnectSession["OnlyCountSessionsNotSeenBefore"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore);
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
                attachToMostRecentIAConnectSession["Workflow"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessionworkflow);
                if (attachToMostRecentIAConnectSessionpropCount > 0)
                {
                    callPayload.Body = attachToMostRecentIAConnectSession;
                }

                return new ApiConnectionAction<AttachToMostRecentIAConnectSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetDirectorUpTime))]
        public IBodyWorkflowAction<GetDirectorUpTimeResponse> GetDirectorUpTime([WorkflowExpression] Func<string> getDirectorUpTimeworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDirectorUpTimeResponse> __BuildGetDirectorUpTime(WorkflowValue<string> getDirectorUpTimeworkflow)
        {
            WorkflowValue.Validate(getDirectorUpTimeworkflow, nameof(getDirectorUpTimeworkflow), required: true);
            return new DeferredBodyAction<GetDirectorUpTimeResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetDirectorUpTime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getDirectorUpTime = new JObject();
                var getDirectorUpTimepropCount = 0;
                getDirectorUpTimepropCount++;
                getDirectorUpTime["Workflow"] = ExpressionConverter.ConvertO(getDirectorUpTimeworkflow);
                if (getDirectorUpTimepropCount > 0)
                {
                    callPayload.Body = getDirectorUpTime;
                }

                return new ApiConnectionAction<GetDirectorUpTimeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildDoesIAConnectSessionExistByName))]
        public IBodyWorkflowAction<DoesIAConnectSessionExistByNameResponse> DoesIAConnectSessionExistByName([WorkflowExpression] Func<string> doesIAConnectSessionExistByNameiAConnectSessionName, [WorkflowExpression] Func<string> doesIAConnectSessionExistByNameworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DoesIAConnectSessionExistByNameResponse> __BuildDoesIAConnectSessionExistByName(WorkflowValue<string> doesIAConnectSessionExistByNameiAConnectSessionName, WorkflowValue<string> doesIAConnectSessionExistByNameworkflow)
        {
            WorkflowValue.Validate(doesIAConnectSessionExistByNameiAConnectSessionName, nameof(doesIAConnectSessionExistByNameiAConnectSessionName), required: true);
            WorkflowValue.Validate(doesIAConnectSessionExistByNameworkflow, nameof(doesIAConnectSessionExistByNameworkflow), required: true);
            return new DeferredBodyAction<DoesIAConnectSessionExistByNameResponse>(() =>
            {
                var apiCallPath = "/DriverControl/DoesIAConnectSessionExistByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var doesIAConnectSessionExistByName = new JObject();
                var doesIAConnectSessionExistByNamepropCount = 0;
                doesIAConnectSessionExistByNamepropCount++;
                doesIAConnectSessionExistByName["IAConnectSessionName"] = ExpressionConverter.ConvertO(doesIAConnectSessionExistByNameiAConnectSessionName);
                doesIAConnectSessionExistByNamepropCount++;
                doesIAConnectSessionExistByName["Workflow"] = ExpressionConverter.ConvertO(doesIAConnectSessionExistByNameworkflow);
                if (doesIAConnectSessionExistByNamepropCount > 0)
                {
                    callPayload.Body = doesIAConnectSessionExistByName;
                }

                return new ApiConnectionAction<DoesIAConnectSessionExistByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildWaitForIAConnectSessionToCloseByName))]
        public IBodyWorkflowAction<WaitForIAConnectSessionToCloseByNameResponse> WaitForIAConnectSessionToCloseByName([WorkflowExpression] Func<string> waitForIAConnectSessionToCloseByNameiAConnectSessionName, [WorkflowExpression] Func<string> waitForIAConnectSessionToCloseByNameworkflow, [WorkflowExpression] Func<int> waitForIAConnectSessionToCloseByNametimeToWaitInSeconds = null, [WorkflowExpression] Func<bool> waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout = null, [WorkflowExpression] Func<bool> waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WaitForIAConnectSessionToCloseByNameResponse> __BuildWaitForIAConnectSessionToCloseByName(WorkflowValue<string> waitForIAConnectSessionToCloseByNameiAConnectSessionName, WorkflowValue<string> waitForIAConnectSessionToCloseByNameworkflow, WorkflowValue<int> waitForIAConnectSessionToCloseByNametimeToWaitInSeconds = null, WorkflowValue<bool> waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout = null, WorkflowValue<bool> waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess = null)
        {
            WorkflowValue.Validate(waitForIAConnectSessionToCloseByNameiAConnectSessionName, nameof(waitForIAConnectSessionToCloseByNameiAConnectSessionName), required: true);
            WorkflowValue.Validate(waitForIAConnectSessionToCloseByNameworkflow, nameof(waitForIAConnectSessionToCloseByNameworkflow), required: true);
            WorkflowValue.Validate(waitForIAConnectSessionToCloseByNametimeToWaitInSeconds, nameof(waitForIAConnectSessionToCloseByNametimeToWaitInSeconds), required: false);
            WorkflowValue.Validate(waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout, nameof(waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout), required: false);
            WorkflowValue.Validate(waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess, nameof(waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess), required: false);
            return new DeferredBodyAction<WaitForIAConnectSessionToCloseByNameResponse>(() =>
            {
                var apiCallPath = "/DriverControl/WaitForIAConnectSessionToCloseByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var waitForIAConnectSessionToCloseByName = new JObject();
                var waitForIAConnectSessionToCloseByNamepropCount = 0;
                waitForIAConnectSessionToCloseByNamepropCount++;
                waitForIAConnectSessionToCloseByName["IAConnectSessionName"] = ExpressionConverter.ConvertO(waitForIAConnectSessionToCloseByNameiAConnectSessionName);
                if (waitForIAConnectSessionToCloseByNametimeToWaitInSeconds != null)
                {
                    waitForIAConnectSessionToCloseByName["TimeToWaitInSeconds"] = ExpressionConverter.ConvertO(waitForIAConnectSessionToCloseByNametimeToWaitInSeconds);
                    waitForIAConnectSessionToCloseByNamepropCount++;
                }

                if (waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout != null)
                {
                    if (waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout != null)
                    {
                        waitForIAConnectSessionToCloseByName["RaiseExceptionIfTimedout"] = ExpressionConverter.ConvertO(waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout);
                        waitForIAConnectSessionToCloseByNamepropCount++;
                    }

                    waitForIAConnectSessionToCloseByNamepropCount++;
                }
                else
                {
                    waitForIAConnectSessionToCloseByName["RaiseExceptionIfTimedout"] = true;
                    waitForIAConnectSessionToCloseByNamepropCount++;
                }

                if (waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess != null)
                {
                    if (waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess != null)
                    {
                        waitForIAConnectSessionToCloseByName["AttachToTier1IAConnectSessionOnSuccess"] = ExpressionConverter.ConvertO(waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess);
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
                waitForIAConnectSessionToCloseByName["Workflow"] = ExpressionConverter.ConvertO(waitForIAConnectSessionToCloseByNameworkflow);
                if (waitForIAConnectSessionToCloseByNamepropCount > 0)
                {
                    callPayload.Body = waitForIAConnectSessionToCloseByName;
                }

                return new ApiConnectionAction<WaitForIAConnectSessionToCloseByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildKillIAConnectSessionByName))]
        public IBodyWorkflowAction<KillIAConnectSessionByNameResponse> KillIAConnectSessionByName([WorkflowExpression] Func<string> killIAConnectSessionByNameiAConnectSessionName, [WorkflowExpression] Func<string> killIAConnectSessionByNameworkflow, [WorkflowExpression] Func<bool> killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KillIAConnectSessionByNameResponse> __BuildKillIAConnectSessionByName(WorkflowValue<string> killIAConnectSessionByNameiAConnectSessionName, WorkflowValue<string> killIAConnectSessionByNameworkflow, WorkflowValue<bool> killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess = null)
        {
            WorkflowValue.Validate(killIAConnectSessionByNameiAConnectSessionName, nameof(killIAConnectSessionByNameiAConnectSessionName), required: true);
            WorkflowValue.Validate(killIAConnectSessionByNameworkflow, nameof(killIAConnectSessionByNameworkflow), required: true);
            WorkflowValue.Validate(killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess, nameof(killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess), required: false);
            return new DeferredBodyAction<KillIAConnectSessionByNameResponse>(() =>
            {
                var apiCallPath = "/DriverControl/KillIAConnectSessionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var killIAConnectSessionByName = new JObject();
                var killIAConnectSessionByNamepropCount = 0;
                killIAConnectSessionByNamepropCount++;
                killIAConnectSessionByName["IAConnectSessionName"] = ExpressionConverter.ConvertO(killIAConnectSessionByNameiAConnectSessionName);
                if (killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess != null)
                {
                    if (killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess != null)
                    {
                        killIAConnectSessionByName["AttachToTier1IAConnectSessionOnSuccess"] = ExpressionConverter.ConvertO(killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess);
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
                killIAConnectSessionByName["Workflow"] = ExpressionConverter.ConvertO(killIAConnectSessionByNameworkflow);
                if (killIAConnectSessionByNamepropCount > 0)
                {
                    callPayload.Body = killIAConnectSessionByName;
                }

                return new ApiConnectionAction<KillIAConnectSessionByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetAgentGlobalCoordinateConfiguration))]
        public IBodyWorkflowAction<SetAgentGlobalCoordinateConfigurationResponse> SetAgentGlobalCoordinateConfiguration([WorkflowExpression] Func<string> setAgentGlobalCoordinateConfigurationworkflow, [WorkflowExpression] Func<setAgentGlobalCoordinateConfigurationmultiMonitorFunctionalityInput> setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality = null, [WorkflowExpression] Func<setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplierInput> setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier = null, [WorkflowExpression] Func<setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplierInput> setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier = null, [WorkflowExpression] Func<double> setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier = null, [WorkflowExpression] Func<double> setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier = null, [WorkflowExpression] Func<double> setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier = null, [WorkflowExpression] Func<double> setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier = null, [WorkflowExpression] Func<bool> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent = null, [WorkflowExpression] Func<bool> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos = null, [WorkflowExpression] Func<bool> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod = null, [WorkflowExpression] Func<setAgentGlobalCoordinateConfigurationjavaCoordinateSystemInput> setAgentGlobalCoordinateConfigurationjavaCoordinateSystem = null, [WorkflowExpression] Func<setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystemInput> setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetAgentGlobalCoordinateConfigurationResponse> __BuildSetAgentGlobalCoordinateConfiguration(WorkflowValue<string> setAgentGlobalCoordinateConfigurationworkflow, WorkflowValue<setAgentGlobalCoordinateConfigurationmultiMonitorFunctionalityInput> setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality = null, WorkflowValue<setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplierInput> setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier = null, WorkflowValue<setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplierInput> setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier = null, WorkflowValue<double> setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier = null, WorkflowValue<double> setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier = null, WorkflowValue<double> setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier = null, WorkflowValue<double> setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier = null, WorkflowValue<bool> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent = null, WorkflowValue<bool> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos = null, WorkflowValue<bool> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod = null, WorkflowValue<setAgentGlobalCoordinateConfigurationjavaCoordinateSystemInput> setAgentGlobalCoordinateConfigurationjavaCoordinateSystem = null, WorkflowValue<setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystemInput> setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem = null)
        {
            WorkflowValue.Validate(setAgentGlobalCoordinateConfigurationworkflow, nameof(setAgentGlobalCoordinateConfigurationworkflow), required: true);
            WorkflowValue.Validate(setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality, nameof(setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality), required: false);
            WorkflowValue.Validate(setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier, nameof(setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier), required: false);
            WorkflowValue.Validate(setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier, nameof(setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier), required: false);
            WorkflowValue.Validate(setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier, nameof(setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier), required: false);
            WorkflowValue.Validate(setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier, nameof(setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier), required: false);
            WorkflowValue.Validate(setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier, nameof(setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier), required: false);
            WorkflowValue.Validate(setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier, nameof(setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier), required: false);
            WorkflowValue.Validate(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent, nameof(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent), required: false);
            WorkflowValue.Validate(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos, nameof(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos), required: false);
            WorkflowValue.Validate(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod, nameof(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod), required: false);
            WorkflowValue.Validate(setAgentGlobalCoordinateConfigurationjavaCoordinateSystem, nameof(setAgentGlobalCoordinateConfigurationjavaCoordinateSystem), required: false);
            WorkflowValue.Validate(setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem, nameof(setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem), required: false);
            return new DeferredBodyAction<SetAgentGlobalCoordinateConfigurationResponse>(() =>
            {
                var apiCallPath = "/DriverControl/SetAgentGlobalCoordinateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setAgentGlobalCoordinateConfiguration = new JObject();
                var setAgentGlobalCoordinateConfigurationpropCount = 0;
                if (setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality != null)
                {
                    if (setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality != null)
                    {
                        setAgentGlobalCoordinateConfiguration["MultiMonitorFunctionality"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["MultiMonitorFunctionality"] = "NotSet";
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier != null)
                {
                    if (setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier != null)
                    {
                        setAgentGlobalCoordinateConfiguration["AutoSetMouseInspectionMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["AutoSetMouseInspectionMultiplier"] = "NotSet";
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier != null)
                {
                    if (setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier != null)
                    {
                        setAgentGlobalCoordinateConfiguration["AutoSetGlobalMouseMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["AutoSetGlobalMouseMultiplier"] = "NotSet";
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier != null)
                {
                    if (setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier != null)
                    {
                        setAgentGlobalCoordinateConfiguration["MouseInspectionXMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["MouseInspectionXMultiplier"] = 0;
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier != null)
                {
                    if (setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier != null)
                    {
                        setAgentGlobalCoordinateConfiguration["MouseInspectionYMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["MouseInspectionYMultiplier"] = 0;
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier != null)
                {
                    if (setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier != null)
                    {
                        setAgentGlobalCoordinateConfiguration["GlobalMouseXMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["GlobalMouseXMultiplier"] = 0;
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier != null)
                {
                    if (setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier != null)
                    {
                        setAgentGlobalCoordinateConfiguration["GlobalMouseYMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["GlobalMouseYMultiplier"] = 0;
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent != null)
                {
                    if (setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent != null)
                    {
                        setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToMouseEvent"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToMouseEvent"] = true;
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos != null)
                {
                    if (setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos != null)
                    {
                        setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToSetCursorPos"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToSetCursorPos"] = false;
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod != null)
                {
                    if (setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod != null)
                    {
                        setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToCurrentMouseMoveMethod"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToCurrentMouseMoveMethod"] = false;
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (setAgentGlobalCoordinateConfigurationjavaCoordinateSystem != null)
                {
                    if (setAgentGlobalCoordinateConfigurationjavaCoordinateSystem != null)
                    {
                        setAgentGlobalCoordinateConfiguration["JavaCoordinateSystem"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationjavaCoordinateSystem);
                        setAgentGlobalCoordinateConfigurationpropCount++;
                    }

                    setAgentGlobalCoordinateConfigurationpropCount++;
                }
                else
                {
                    setAgentGlobalCoordinateConfiguration["JavaCoordinateSystem"] = "NotSet";
                    setAgentGlobalCoordinateConfigurationpropCount++;
                }

                if (setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem != null)
                {
                    if (setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem != null)
                    {
                        setAgentGlobalCoordinateConfiguration["SAPGUICoordinateSystem"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem);
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
                setAgentGlobalCoordinateConfiguration["Workflow"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationworkflow);
                if (setAgentGlobalCoordinateConfigurationpropCount > 0)
                {
                    callPayload.Body = setAgentGlobalCoordinateConfiguration;
                }

                return new ApiConnectionAction<SetAgentGlobalCoordinateConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetAgentGlobalCoordinateConfiguration))]
        public IBodyWorkflowAction<GetAgentGlobalCoordinateConfigurationResponse> GetAgentGlobalCoordinateConfiguration([WorkflowExpression] Func<string> getAgentGlobalCoordinateConfigurationworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAgentGlobalCoordinateConfigurationResponse> __BuildGetAgentGlobalCoordinateConfiguration(WorkflowValue<string> getAgentGlobalCoordinateConfigurationworkflow)
        {
            WorkflowValue.Validate(getAgentGlobalCoordinateConfigurationworkflow, nameof(getAgentGlobalCoordinateConfigurationworkflow), required: true);
            return new DeferredBodyAction<GetAgentGlobalCoordinateConfigurationResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetAgentGlobalCoordinateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getAgentGlobalCoordinateConfiguration = new JObject();
                var getAgentGlobalCoordinateConfigurationpropCount = 0;
                getAgentGlobalCoordinateConfigurationpropCount++;
                getAgentGlobalCoordinateConfiguration["Workflow"] = ExpressionConverter.ConvertO(getAgentGlobalCoordinateConfigurationworkflow);
                if (getAgentGlobalCoordinateConfigurationpropCount > 0)
                {
                    callPayload.Body = getAgentGlobalCoordinateConfiguration;
                }

                return new ApiConnectionAction<GetAgentGlobalCoordinateConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetAgentThreadStatus))]
        public IBodyWorkflowAction<GetAgentThreadStatusResponse> GetAgentThreadStatus([WorkflowExpression] Func<int> getAgentThreadStatusthreadId, [WorkflowExpression] Func<string> getAgentThreadStatusworkflow, [WorkflowExpression] Func<bool> getAgentThreadStatusretrieveThreadOutputData = null, [WorkflowExpression] Func<bool> getAgentThreadStatusclearOutputDataFromMemoryOnceRead = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAgentThreadStatusResponse> __BuildGetAgentThreadStatus(WorkflowValue<int> getAgentThreadStatusthreadId, WorkflowValue<string> getAgentThreadStatusworkflow, WorkflowValue<bool> getAgentThreadStatusretrieveThreadOutputData = null, WorkflowValue<bool> getAgentThreadStatusclearOutputDataFromMemoryOnceRead = null)
        {
            WorkflowValue.Validate(getAgentThreadStatusthreadId, nameof(getAgentThreadStatusthreadId), required: true);
            WorkflowValue.Validate(getAgentThreadStatusworkflow, nameof(getAgentThreadStatusworkflow), required: true);
            WorkflowValue.Validate(getAgentThreadStatusretrieveThreadOutputData, nameof(getAgentThreadStatusretrieveThreadOutputData), required: false);
            WorkflowValue.Validate(getAgentThreadStatusclearOutputDataFromMemoryOnceRead, nameof(getAgentThreadStatusclearOutputDataFromMemoryOnceRead), required: false);
            return new DeferredBodyAction<GetAgentThreadStatusResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetAgentThreadStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getAgentThreadStatus = new JObject();
                var getAgentThreadStatuspropCount = 0;
                getAgentThreadStatuspropCount++;
                getAgentThreadStatus["ThreadId"] = ExpressionConverter.ConvertO(getAgentThreadStatusthreadId);
                if (getAgentThreadStatusretrieveThreadOutputData != null)
                {
                    if (getAgentThreadStatusretrieveThreadOutputData != null)
                    {
                        getAgentThreadStatus["RetrieveThreadOutputData"] = ExpressionConverter.ConvertO(getAgentThreadStatusretrieveThreadOutputData);
                        getAgentThreadStatuspropCount++;
                    }

                    getAgentThreadStatuspropCount++;
                }
                else
                {
                    getAgentThreadStatus["RetrieveThreadOutputData"] = false;
                    getAgentThreadStatuspropCount++;
                }

                if (getAgentThreadStatusclearOutputDataFromMemoryOnceRead != null)
                {
                    if (getAgentThreadStatusclearOutputDataFromMemoryOnceRead != null)
                    {
                        getAgentThreadStatus["ClearOutputDataFromMemoryOnceRead"] = ExpressionConverter.ConvertO(getAgentThreadStatusclearOutputDataFromMemoryOnceRead);
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
                getAgentThreadStatus["Workflow"] = ExpressionConverter.ConvertO(getAgentThreadStatusworkflow);
                if (getAgentThreadStatuspropCount > 0)
                {
                    callPayload.Body = getAgentThreadStatus;
                }

                return new ApiConnectionAction<GetAgentThreadStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildWaitForAgentThreadToCompleteSuccessfully))]
        public IBodyWorkflowAction<WaitForAgentThreadToCompleteSuccessfullyResponse> WaitForAgentThreadToCompleteSuccessfully([WorkflowExpression] Func<int> waitForAgentThreadToCompleteSuccessfullythreadId, [WorkflowExpression] Func<int> waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread, [WorkflowExpression] Func<string> waitForAgentThreadToCompleteSuccessfullyworkflow, [WorkflowExpression] Func<bool> waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData = null, [WorkflowExpression] Func<bool> waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead = null, [WorkflowExpression] Func<bool> waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted = null, [WorkflowExpression] Func<bool> waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError = null, [WorkflowExpression] Func<int> waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WaitForAgentThreadToCompleteSuccessfullyResponse> __BuildWaitForAgentThreadToCompleteSuccessfully(WorkflowValue<int> waitForAgentThreadToCompleteSuccessfullythreadId, WorkflowValue<int> waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread, WorkflowValue<string> waitForAgentThreadToCompleteSuccessfullyworkflow, WorkflowValue<bool> waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData = null, WorkflowValue<bool> waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead = null, WorkflowValue<bool> waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted = null, WorkflowValue<bool> waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError = null, WorkflowValue<int> waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall = null)
        {
            WorkflowValue.Validate(waitForAgentThreadToCompleteSuccessfullythreadId, nameof(waitForAgentThreadToCompleteSuccessfullythreadId), required: true);
            WorkflowValue.Validate(waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread, nameof(waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread), required: true);
            WorkflowValue.Validate(waitForAgentThreadToCompleteSuccessfullyworkflow, nameof(waitForAgentThreadToCompleteSuccessfullyworkflow), required: true);
            WorkflowValue.Validate(waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData, nameof(waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData), required: false);
            WorkflowValue.Validate(waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead, nameof(waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead), required: false);
            WorkflowValue.Validate(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted, nameof(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted), required: false);
            WorkflowValue.Validate(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError, nameof(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError), required: false);
            WorkflowValue.Validate(waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall, nameof(waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall), required: false);
            return new DeferredBodyAction<WaitForAgentThreadToCompleteSuccessfullyResponse>(() =>
            {
                var apiCallPath = "/DriverControl/WaitForAgentThreadToCompleteSuccessfully";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var waitForAgentThreadToCompleteSuccessfully = new JObject();
                var waitForAgentThreadToCompleteSuccessfullypropCount = 0;
                waitForAgentThreadToCompleteSuccessfullypropCount++;
                waitForAgentThreadToCompleteSuccessfully["ThreadId"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullythreadId);
                waitForAgentThreadToCompleteSuccessfullypropCount++;
                waitForAgentThreadToCompleteSuccessfully["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread);
                if (waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData != null)
                {
                    if (waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData != null)
                    {
                        waitForAgentThreadToCompleteSuccessfully["RetrieveThreadOutputData"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData);
                        waitForAgentThreadToCompleteSuccessfullypropCount++;
                    }

                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }
                else
                {
                    waitForAgentThreadToCompleteSuccessfully["RetrieveThreadOutputData"] = false;
                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }

                if (waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead != null)
                {
                    if (waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead != null)
                    {
                        waitForAgentThreadToCompleteSuccessfully["ClearOutputDataFromMemoryOnceRead"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead);
                        waitForAgentThreadToCompleteSuccessfullypropCount++;
                    }

                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }
                else
                {
                    waitForAgentThreadToCompleteSuccessfully["ClearOutputDataFromMemoryOnceRead"] = true;
                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }

                if (waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted != null)
                {
                    if (waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted != null)
                    {
                        waitForAgentThreadToCompleteSuccessfully["RaiseExceptionIfThreadNotCompleted"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted);
                        waitForAgentThreadToCompleteSuccessfullypropCount++;
                    }

                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }
                else
                {
                    waitForAgentThreadToCompleteSuccessfully["RaiseExceptionIfThreadNotCompleted"] = true;
                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }

                if (waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError != null)
                {
                    if (waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError != null)
                    {
                        waitForAgentThreadToCompleteSuccessfully["RaiseExceptionIfThreadError"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError);
                        waitForAgentThreadToCompleteSuccessfullypropCount++;
                    }

                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }
                else
                {
                    waitForAgentThreadToCompleteSuccessfully["RaiseExceptionIfThreadError"] = true;
                    waitForAgentThreadToCompleteSuccessfullypropCount++;
                }

                if (waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall != null)
                {
                    if (waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall != null)
                    {
                        waitForAgentThreadToCompleteSuccessfully["SecondsToWaitPerCall"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall);
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
                waitForAgentThreadToCompleteSuccessfully["Workflow"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyworkflow);
                if (waitForAgentThreadToCompleteSuccessfullypropCount > 0)
                {
                    callPayload.Body = waitForAgentThreadToCompleteSuccessfully;
                }

                return new ApiConnectionAction<WaitForAgentThreadToCompleteSuccessfullyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetAgentThreads))]
        public IBodyWorkflowAction<GetAgentThreadsResponse> GetAgentThreads([WorkflowExpression] Func<string> getAgentThreadsworkflow, [WorkflowExpression] Func<getAgentThreadssortOrderInput> getAgentThreadssortOrder = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAgentThreadsResponse> __BuildGetAgentThreads(WorkflowValue<string> getAgentThreadsworkflow, WorkflowValue<getAgentThreadssortOrderInput> getAgentThreadssortOrder = null)
        {
            WorkflowValue.Validate(getAgentThreadsworkflow, nameof(getAgentThreadsworkflow), required: true);
            WorkflowValue.Validate(getAgentThreadssortOrder, nameof(getAgentThreadssortOrder), required: false);
            return new DeferredBodyAction<GetAgentThreadsResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetAgentThreads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getAgentThreads = new JObject();
                var getAgentThreadspropCount = 0;
                if (getAgentThreadssortOrder != null)
                {
                    getAgentThreads["SortOrder"] = ExpressionConverter.ConvertO(getAgentThreadssortOrder);
                    getAgentThreadspropCount++;
                }

                getAgentThreadspropCount++;
                getAgentThreads["Workflow"] = ExpressionConverter.ConvertO(getAgentThreadsworkflow);
                if (getAgentThreadspropCount > 0)
                {
                    callPayload.Body = getAgentThreads;
                }

                return new ApiConnectionAction<GetAgentThreadsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildKillAgentThread))]
        public IBodyWorkflowAction<KillAgentThreadResponse> KillAgentThread([WorkflowExpression] Func<int> killAgentThreadthreadId, [WorkflowExpression] Func<string> killAgentThreadworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KillAgentThreadResponse> __BuildKillAgentThread(WorkflowValue<int> killAgentThreadthreadId, WorkflowValue<string> killAgentThreadworkflow)
        {
            WorkflowValue.Validate(killAgentThreadthreadId, nameof(killAgentThreadthreadId), required: true);
            WorkflowValue.Validate(killAgentThreadworkflow, nameof(killAgentThreadworkflow), required: true);
            return new DeferredBodyAction<KillAgentThreadResponse>(() =>
            {
                var apiCallPath = "/DriverControl/KillAgentThread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var killAgentThread = new JObject();
                var killAgentThreadpropCount = 0;
                killAgentThreadpropCount++;
                killAgentThread["ThreadId"] = ExpressionConverter.ConvertO(killAgentThreadthreadId);
                killAgentThreadpropCount++;
                killAgentThread["Workflow"] = ExpressionConverter.ConvertO(killAgentThreadworkflow);
                if (killAgentThreadpropCount > 0)
                {
                    callPayload.Body = killAgentThread;
                }

                return new ApiConnectionAction<KillAgentThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAgentThread))]
        public IBodyWorkflowAction<DeleteAgentThreadResponse> DeleteAgentThread([WorkflowExpression] Func<string> deleteAgentThreadworkflow, [WorkflowExpression] Func<int> deleteAgentThreadthreadId = null, [WorkflowExpression] Func<bool> deleteAgentThreaddeleteAllAgentThreads = null, [WorkflowExpression] Func<bool> deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteAgentThreadResponse> __BuildDeleteAgentThread(WorkflowValue<string> deleteAgentThreadworkflow, WorkflowValue<int> deleteAgentThreadthreadId = null, WorkflowValue<bool> deleteAgentThreaddeleteAllAgentThreads = null, WorkflowValue<bool> deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete = null)
        {
            WorkflowValue.Validate(deleteAgentThreadworkflow, nameof(deleteAgentThreadworkflow), required: true);
            WorkflowValue.Validate(deleteAgentThreadthreadId, nameof(deleteAgentThreadthreadId), required: false);
            WorkflowValue.Validate(deleteAgentThreaddeleteAllAgentThreads, nameof(deleteAgentThreaddeleteAllAgentThreads), required: false);
            WorkflowValue.Validate(deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete, nameof(deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete), required: false);
            return new DeferredBodyAction<DeleteAgentThreadResponse>(() =>
            {
                var apiCallPath = "/DriverControl/DeleteAgentThread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteAgentThread = new JObject();
                var deleteAgentThreadpropCount = 0;
                if (deleteAgentThreadthreadId != null)
                {
                    deleteAgentThread["ThreadId"] = ExpressionConverter.ConvertO(deleteAgentThreadthreadId);
                    deleteAgentThreadpropCount++;
                }

                if (deleteAgentThreaddeleteAllAgentThreads != null)
                {
                    if (deleteAgentThreaddeleteAllAgentThreads != null)
                    {
                        deleteAgentThread["DeleteAllAgentThreads"] = ExpressionConverter.ConvertO(deleteAgentThreaddeleteAllAgentThreads);
                        deleteAgentThreadpropCount++;
                    }

                    deleteAgentThreadpropCount++;
                }
                else
                {
                    deleteAgentThread["DeleteAllAgentThreads"] = false;
                    deleteAgentThreadpropCount++;
                }

                if (deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete != null)
                {
                    if (deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete != null)
                    {
                        deleteAgentThread["RaiseExceptionIfAgentThreadFailsToDelete"] = ExpressionConverter.ConvertO(deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete);
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
                deleteAgentThread["Workflow"] = ExpressionConverter.ConvertO(deleteAgentThreadworkflow);
                if (deleteAgentThreadpropCount > 0)
                {
                    callPayload.Body = deleteAgentThread;
                }

                return new ApiConnectionAction<DeleteAgentThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildAllocateWorkerFromOrchestrator))]
        public IBodyWorkflowAction<AllocateWorkerFromOrchestratorResponse> AllocateWorkerFromOrchestrator([WorkflowExpression] Func<string> allocateWorkerFromOrchestratorworkflow, [WorkflowExpression] Func<string> allocateWorkerFromOrchestratorworkerTag = null, [WorkflowExpression] Func<string> allocateWorkerFromOrchestratorworkerName = null, [WorkflowExpression] Func<bool> allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AllocateWorkerFromOrchestratorResponse> __BuildAllocateWorkerFromOrchestrator(WorkflowValue<string> allocateWorkerFromOrchestratorworkflow, WorkflowValue<string> allocateWorkerFromOrchestratorworkerTag = null, WorkflowValue<string> allocateWorkerFromOrchestratorworkerName = null, WorkflowValue<bool> allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable = null)
        {
            WorkflowValue.Validate(allocateWorkerFromOrchestratorworkflow, nameof(allocateWorkerFromOrchestratorworkflow), required: true);
            WorkflowValue.Validate(allocateWorkerFromOrchestratorworkerTag, nameof(allocateWorkerFromOrchestratorworkerTag), required: false);
            WorkflowValue.Validate(allocateWorkerFromOrchestratorworkerName, nameof(allocateWorkerFromOrchestratorworkerName), required: false);
            WorkflowValue.Validate(allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable, nameof(allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable), required: false);
            return new DeferredBodyAction<AllocateWorkerFromOrchestratorResponse>(() =>
            {
                var apiCallPath = "/DriverControl/AllocateWorkerFromOrchestrator";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var allocateWorkerFromOrchestrator = new JObject();
                var allocateWorkerFromOrchestratorpropCount = 0;
                if (allocateWorkerFromOrchestratorworkerTag != null)
                {
                    allocateWorkerFromOrchestrator["WorkerTag"] = ExpressionConverter.ConvertO(allocateWorkerFromOrchestratorworkerTag);
                    allocateWorkerFromOrchestratorpropCount++;
                }

                if (allocateWorkerFromOrchestratorworkerName != null)
                {
                    allocateWorkerFromOrchestrator["WorkerName"] = ExpressionConverter.ConvertO(allocateWorkerFromOrchestratorworkerName);
                    allocateWorkerFromOrchestratorpropCount++;
                }

                if (allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable != null)
                {
                    if (allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable != null)
                    {
                        allocateWorkerFromOrchestrator["RaiseExceptionIfWorkerNotImmediatelyAvailable"] = ExpressionConverter.ConvertO(allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable);
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
                allocateWorkerFromOrchestrator["Workflow"] = ExpressionConverter.ConvertO(allocateWorkerFromOrchestratorworkflow);
                if (allocateWorkerFromOrchestratorpropCount > 0)
                {
                    callPayload.Body = allocateWorkerFromOrchestrator;
                }

                return new ApiConnectionAction<AllocateWorkerFromOrchestratorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetOrchestratorWorkerMaintenanceMode))]
        public IBodyWorkflowAction<SetOrchestratorWorkerMaintenanceModeResponse> SetOrchestratorWorkerMaintenanceMode([WorkflowExpression] Func<int> setOrchestratorWorkerMaintenanceModeworkerId = null, [WorkflowExpression] Func<string> setOrchestratorWorkerMaintenanceModeworkerName = null, [WorkflowExpression] Func<bool> setOrchestratorWorkerMaintenanceModemaintenanceMode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetOrchestratorWorkerMaintenanceModeResponse> __BuildSetOrchestratorWorkerMaintenanceMode(WorkflowValue<int> setOrchestratorWorkerMaintenanceModeworkerId = null, WorkflowValue<string> setOrchestratorWorkerMaintenanceModeworkerName = null, WorkflowValue<bool> setOrchestratorWorkerMaintenanceModemaintenanceMode = null)
        {
            WorkflowValue.Validate(setOrchestratorWorkerMaintenanceModeworkerId, nameof(setOrchestratorWorkerMaintenanceModeworkerId), required: false);
            WorkflowValue.Validate(setOrchestratorWorkerMaintenanceModeworkerName, nameof(setOrchestratorWorkerMaintenanceModeworkerName), required: false);
            WorkflowValue.Validate(setOrchestratorWorkerMaintenanceModemaintenanceMode, nameof(setOrchestratorWorkerMaintenanceModemaintenanceMode), required: false);
            return new DeferredBodyAction<SetOrchestratorWorkerMaintenanceModeResponse>(() =>
            {
                var apiCallPath = "/DriverControl/SetOrchestratorWorkerMaintenanceMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setOrchestratorWorkerMaintenanceMode = new JObject();
                var setOrchestratorWorkerMaintenanceModepropCount = 0;
                if (setOrchestratorWorkerMaintenanceModeworkerId != null)
                {
                    if (setOrchestratorWorkerMaintenanceModeworkerId != null)
                    {
                        setOrchestratorWorkerMaintenanceMode["WorkerId"] = ExpressionConverter.ConvertO(setOrchestratorWorkerMaintenanceModeworkerId);
                        setOrchestratorWorkerMaintenanceModepropCount++;
                    }

                    setOrchestratorWorkerMaintenanceModepropCount++;
                }
                else
                {
                    setOrchestratorWorkerMaintenanceMode["WorkerId"] = 0;
                    setOrchestratorWorkerMaintenanceModepropCount++;
                }

                if (setOrchestratorWorkerMaintenanceModeworkerName != null)
                {
                    setOrchestratorWorkerMaintenanceMode["WorkerName"] = ExpressionConverter.ConvertO(setOrchestratorWorkerMaintenanceModeworkerName);
                    setOrchestratorWorkerMaintenanceModepropCount++;
                }

                if (setOrchestratorWorkerMaintenanceModemaintenanceMode != null)
                {
                    if (setOrchestratorWorkerMaintenanceModemaintenanceMode != null)
                    {
                        setOrchestratorWorkerMaintenanceMode["MaintenanceMode"] = ExpressionConverter.ConvertO(setOrchestratorWorkerMaintenanceModemaintenanceMode);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateOrchestratorOneTimeSecret))]
        public IBodyWorkflowAction<CreateOrchestratorOneTimeSecretResponse> CreateOrchestratorOneTimeSecret([WorkflowExpression] Func<string> createOrchestratorOneTimeSecretfriendlyName, [WorkflowExpression] Func<string> createOrchestratorOneTimeSecretsecretValue = null, [WorkflowExpression] Func<string> createOrchestratorOneTimeSecretretrievalPhrase1 = null, [WorkflowExpression] Func<string> createOrchestratorOneTimeSecretretrievalPhrase2 = null, [WorkflowExpression] Func<int> createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion = null, [WorkflowExpression] Func<bool> createOrchestratorOneTimeSecretsecretHasAStartDate = null, [WorkflowExpression] Func<string> createOrchestratorOneTimeSecretsecretStartDateTime = null, [WorkflowExpression] Func<int> createOrchestratorOneTimeSecrethoursUntilSecretStartTime = null, [WorkflowExpression] Func<bool> createOrchestratorOneTimeSecretsecretHasAnExpiryDate = null, [WorkflowExpression] Func<string> createOrchestratorOneTimeSecretsecretExpiryDateTime = null, [WorkflowExpression] Func<int> createOrchestratorOneTimeSecrethoursUntilSecretExpiry = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateOrchestratorOneTimeSecretResponse> __BuildCreateOrchestratorOneTimeSecret(WorkflowValue<string> createOrchestratorOneTimeSecretfriendlyName, WorkflowValue<string> createOrchestratorOneTimeSecretsecretValue = null, WorkflowValue<string> createOrchestratorOneTimeSecretretrievalPhrase1 = null, WorkflowValue<string> createOrchestratorOneTimeSecretretrievalPhrase2 = null, WorkflowValue<int> createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion = null, WorkflowValue<bool> createOrchestratorOneTimeSecretsecretHasAStartDate = null, WorkflowValue<string> createOrchestratorOneTimeSecretsecretStartDateTime = null, WorkflowValue<int> createOrchestratorOneTimeSecrethoursUntilSecretStartTime = null, WorkflowValue<bool> createOrchestratorOneTimeSecretsecretHasAnExpiryDate = null, WorkflowValue<string> createOrchestratorOneTimeSecretsecretExpiryDateTime = null, WorkflowValue<int> createOrchestratorOneTimeSecrethoursUntilSecretExpiry = null)
        {
            WorkflowValue.Validate(createOrchestratorOneTimeSecretfriendlyName, nameof(createOrchestratorOneTimeSecretfriendlyName), required: true);
            WorkflowValue.Validate(createOrchestratorOneTimeSecretsecretValue, nameof(createOrchestratorOneTimeSecretsecretValue), required: false);
            WorkflowValue.Validate(createOrchestratorOneTimeSecretretrievalPhrase1, nameof(createOrchestratorOneTimeSecretretrievalPhrase1), required: false);
            WorkflowValue.Validate(createOrchestratorOneTimeSecretretrievalPhrase2, nameof(createOrchestratorOneTimeSecretretrievalPhrase2), required: false);
            WorkflowValue.Validate(createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion, nameof(createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion), required: false);
            WorkflowValue.Validate(createOrchestratorOneTimeSecretsecretHasAStartDate, nameof(createOrchestratorOneTimeSecretsecretHasAStartDate), required: false);
            WorkflowValue.Validate(createOrchestratorOneTimeSecretsecretStartDateTime, nameof(createOrchestratorOneTimeSecretsecretStartDateTime), required: false);
            WorkflowValue.Validate(createOrchestratorOneTimeSecrethoursUntilSecretStartTime, nameof(createOrchestratorOneTimeSecrethoursUntilSecretStartTime), required: false);
            WorkflowValue.Validate(createOrchestratorOneTimeSecretsecretHasAnExpiryDate, nameof(createOrchestratorOneTimeSecretsecretHasAnExpiryDate), required: false);
            WorkflowValue.Validate(createOrchestratorOneTimeSecretsecretExpiryDateTime, nameof(createOrchestratorOneTimeSecretsecretExpiryDateTime), required: false);
            WorkflowValue.Validate(createOrchestratorOneTimeSecrethoursUntilSecretExpiry, nameof(createOrchestratorOneTimeSecrethoursUntilSecretExpiry), required: false);
            return new DeferredBodyAction<CreateOrchestratorOneTimeSecretResponse>(() =>
            {
                var apiCallPath = "/DriverControl/CreateOrchestratorOneTimeSecret";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createOrchestratorOneTimeSecret = new JObject();
                var createOrchestratorOneTimeSecretpropCount = 0;
                createOrchestratorOneTimeSecretpropCount++;
                createOrchestratorOneTimeSecret["FriendlyName"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretfriendlyName);
                if (createOrchestratorOneTimeSecretsecretValue != null)
                {
                    createOrchestratorOneTimeSecret["SecretValue"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretsecretValue);
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (createOrchestratorOneTimeSecretretrievalPhrase1 != null)
                {
                    createOrchestratorOneTimeSecret["RetrievalPhrase1"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretretrievalPhrase1);
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (createOrchestratorOneTimeSecretretrievalPhrase2 != null)
                {
                    createOrchestratorOneTimeSecret["RetrievalPhrase2"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretretrievalPhrase2);
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion != null)
                {
                    if (createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion != null)
                    {
                        createOrchestratorOneTimeSecret["MaximumRetrievalsBeforeDeletion"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion);
                        createOrchestratorOneTimeSecretpropCount++;
                    }

                    createOrchestratorOneTimeSecretpropCount++;
                }
                else
                {
                    createOrchestratorOneTimeSecret["MaximumRetrievalsBeforeDeletion"] = 1;
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (createOrchestratorOneTimeSecretsecretHasAStartDate != null)
                {
                    if (createOrchestratorOneTimeSecretsecretHasAStartDate != null)
                    {
                        createOrchestratorOneTimeSecret["SecretHasAStartDate"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretsecretHasAStartDate);
                        createOrchestratorOneTimeSecretpropCount++;
                    }

                    createOrchestratorOneTimeSecretpropCount++;
                }
                else
                {
                    createOrchestratorOneTimeSecret["SecretHasAStartDate"] = false;
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (createOrchestratorOneTimeSecretsecretStartDateTime != null)
                {
                    createOrchestratorOneTimeSecret["SecretStartDateTime"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretsecretStartDateTime);
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (createOrchestratorOneTimeSecrethoursUntilSecretStartTime != null)
                {
                    createOrchestratorOneTimeSecret["HoursUntilSecretStartTime"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecrethoursUntilSecretStartTime);
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (createOrchestratorOneTimeSecretsecretHasAnExpiryDate != null)
                {
                    if (createOrchestratorOneTimeSecretsecretHasAnExpiryDate != null)
                    {
                        createOrchestratorOneTimeSecret["SecretHasAnExpiryDate"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretsecretHasAnExpiryDate);
                        createOrchestratorOneTimeSecretpropCount++;
                    }

                    createOrchestratorOneTimeSecretpropCount++;
                }
                else
                {
                    createOrchestratorOneTimeSecret["SecretHasAnExpiryDate"] = false;
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (createOrchestratorOneTimeSecretsecretExpiryDateTime != null)
                {
                    createOrchestratorOneTimeSecret["SecretExpiryDateTime"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretsecretExpiryDateTime);
                    createOrchestratorOneTimeSecretpropCount++;
                }

                if (createOrchestratorOneTimeSecrethoursUntilSecretExpiry != null)
                {
                    createOrchestratorOneTimeSecret["HoursUntilSecretExpiry"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecrethoursUntilSecretExpiry);
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
        [WorkflowExpressionFactory(nameof(__BuildGetListOfOrchestratorWorkers))]
        public IBodyWorkflowAction<GetListOfOrchestratorWorkersResponse> GetListOfOrchestratorWorkers([WorkflowExpression] Func<bool> getListOfOrchestratorWorkersonlyReturnLiveWorkers = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetListOfOrchestratorWorkersResponse> __BuildGetListOfOrchestratorWorkers(WorkflowValue<bool> getListOfOrchestratorWorkersonlyReturnLiveWorkers = null)
        {
            WorkflowValue.Validate(getListOfOrchestratorWorkersonlyReturnLiveWorkers, nameof(getListOfOrchestratorWorkersonlyReturnLiveWorkers), required: false);
            return new DeferredBodyAction<GetListOfOrchestratorWorkersResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetListOfOrchestratorWorkers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getListOfOrchestratorWorkers = new JObject();
                var getListOfOrchestratorWorkerspropCount = 0;
                if (getListOfOrchestratorWorkersonlyReturnLiveWorkers != null)
                {
                    if (getListOfOrchestratorWorkersonlyReturnLiveWorkers != null)
                    {
                        getListOfOrchestratorWorkers["OnlyReturnLiveWorkers"] = ExpressionConverter.ConvertO(getListOfOrchestratorWorkersonlyReturnLiveWorkers);
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
        [WorkflowExpressionFactory(nameof(__BuildGetOrchestratorWorker))]
        public IBodyWorkflowAction<GetOrchestratorWorkerResponse> GetOrchestratorWorker([WorkflowExpression] Func<int> getOrchestratorWorkersearchWorkerId = null, [WorkflowExpression] Func<string> getOrchestratorWorkersearchWorkerName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOrchestratorWorkerResponse> __BuildGetOrchestratorWorker(WorkflowValue<int> getOrchestratorWorkersearchWorkerId = null, WorkflowValue<string> getOrchestratorWorkersearchWorkerName = null)
        {
            WorkflowValue.Validate(getOrchestratorWorkersearchWorkerId, nameof(getOrchestratorWorkersearchWorkerId), required: false);
            WorkflowValue.Validate(getOrchestratorWorkersearchWorkerName, nameof(getOrchestratorWorkersearchWorkerName), required: false);
            return new DeferredBodyAction<GetOrchestratorWorkerResponse>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorWorker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getOrchestratorWorker = new JObject();
                var getOrchestratorWorkerpropCount = 0;
                if (getOrchestratorWorkersearchWorkerId != null)
                {
                    getOrchestratorWorker["SearchWorkerId"] = ExpressionConverter.ConvertO(getOrchestratorWorkersearchWorkerId);
                    getOrchestratorWorkerpropCount++;
                }

                if (getOrchestratorWorkersearchWorkerName != null)
                {
                    getOrchestratorWorker["SearchWorkerName"] = ExpressionConverter.ConvertO(getOrchestratorWorkersearchWorkerName);
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
        [WorkflowExpressionFactory(nameof(__BuildFileExists))]
        public IBodyWorkflowAction<FileExistsResponse> FileExists([WorkflowExpression] Func<string> fileExistsfilename, [WorkflowExpression] Func<string> fileExistsworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FileExistsResponse> __BuildFileExists(WorkflowValue<string> fileExistsfilename, WorkflowValue<string> fileExistsworkflow)
        {
            WorkflowValue.Validate(fileExistsfilename, nameof(fileExistsfilename), required: true);
            WorkflowValue.Validate(fileExistsworkflow, nameof(fileExistsworkflow), required: true);
            return new DeferredBodyAction<FileExistsResponse>(() =>
            {
                var apiCallPath = "/FileManagement/FileExists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileExists = new JObject();
                var fileExistspropCount = 0;
                fileExistspropCount++;
                fileExists["Filename"] = ExpressionConverter.ConvertO(fileExistsfilename);
                fileExistspropCount++;
                fileExists["Workflow"] = ExpressionConverter.ConvertO(fileExistsworkflow);
                if (fileExistspropCount > 0)
                {
                    callPayload.Body = fileExists;
                }

                return new ApiConnectionAction<FileExistsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildDirectoryExists))]
        public IBodyWorkflowAction<DirectoryExistsResponse> DirectoryExists([WorkflowExpression] Func<string> directoryExistsdirectoryPath, [WorkflowExpression] Func<string> directoryExistsworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DirectoryExistsResponse> __BuildDirectoryExists(WorkflowValue<string> directoryExistsdirectoryPath, WorkflowValue<string> directoryExistsworkflow)
        {
            WorkflowValue.Validate(directoryExistsdirectoryPath, nameof(directoryExistsdirectoryPath), required: true);
            WorkflowValue.Validate(directoryExistsworkflow, nameof(directoryExistsworkflow), required: true);
            return new DeferredBodyAction<DirectoryExistsResponse>(() =>
            {
                var apiCallPath = "/FileManagement/DirectoryExists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var directoryExists = new JObject();
                var directoryExistspropCount = 0;
                directoryExistspropCount++;
                directoryExists["DirectoryPath"] = ExpressionConverter.ConvertO(directoryExistsdirectoryPath);
                directoryExistspropCount++;
                directoryExists["Workflow"] = ExpressionConverter.ConvertO(directoryExistsworkflow);
                if (directoryExistspropCount > 0)
                {
                    callPayload.Body = directoryExists;
                }

                return new ApiConnectionAction<DirectoryExistsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFile))]
        public IWorkflowAction DeleteFile([WorkflowExpression] Func<string> deleteFilefilename, [WorkflowExpression] Func<string> deleteFileworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteFile(WorkflowValue<string> deleteFilefilename, WorkflowValue<string> deleteFileworkflow)
        {
            WorkflowValue.Validate(deleteFilefilename, nameof(deleteFilefilename), required: true);
            WorkflowValue.Validate(deleteFileworkflow, nameof(deleteFileworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/DeleteFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteFile = new JObject();
                var deleteFilepropCount = 0;
                deleteFilepropCount++;
                deleteFile["Filename"] = ExpressionConverter.ConvertO(deleteFilefilename);
                deleteFilepropCount++;
                deleteFile["Workflow"] = ExpressionConverter.ConvertO(deleteFileworkflow);
                if (deleteFilepropCount > 0)
                {
                    callPayload.Body = deleteFile;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDirectory))]
        public IWorkflowAction DeleteDirectory([WorkflowExpression] Func<string> deleteDirectorydirectoryPath, [WorkflowExpression] Func<string> deleteDirectoryworkflow, [WorkflowExpression] Func<bool> deleteDirectoryrecursive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteDirectory(WorkflowValue<string> deleteDirectorydirectoryPath, WorkflowValue<string> deleteDirectoryworkflow, WorkflowValue<bool> deleteDirectoryrecursive = null)
        {
            WorkflowValue.Validate(deleteDirectorydirectoryPath, nameof(deleteDirectorydirectoryPath), required: true);
            WorkflowValue.Validate(deleteDirectoryworkflow, nameof(deleteDirectoryworkflow), required: true);
            WorkflowValue.Validate(deleteDirectoryrecursive, nameof(deleteDirectoryrecursive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/DeleteDirectory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteDirectory = new JObject();
                var deleteDirectorypropCount = 0;
                deleteDirectorypropCount++;
                deleteDirectory["DirectoryPath"] = ExpressionConverter.ConvertO(deleteDirectorydirectoryPath);
                if (deleteDirectoryrecursive != null)
                {
                    if (deleteDirectoryrecursive != null)
                    {
                        deleteDirectory["Recursive"] = ExpressionConverter.ConvertO(deleteDirectoryrecursive);
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
                deleteDirectory["Workflow"] = ExpressionConverter.ConvertO(deleteDirectoryworkflow);
                if (deleteDirectorypropCount > 0)
                {
                    callPayload.Body = deleteDirectory;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildPurgeDirectory))]
        public IWorkflowAction PurgeDirectory([WorkflowExpression] Func<string> purgeDirectorydirectoryPath, [WorkflowExpression] Func<string> purgeDirectoryworkflow, [WorkflowExpression] Func<bool> purgeDirectoryrecursive = null, [WorkflowExpression] Func<bool> purgeDirectorydeleteTopLevel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPurgeDirectory(WorkflowValue<string> purgeDirectorydirectoryPath, WorkflowValue<string> purgeDirectoryworkflow, WorkflowValue<bool> purgeDirectoryrecursive = null, WorkflowValue<bool> purgeDirectorydeleteTopLevel = null)
        {
            WorkflowValue.Validate(purgeDirectorydirectoryPath, nameof(purgeDirectorydirectoryPath), required: true);
            WorkflowValue.Validate(purgeDirectoryworkflow, nameof(purgeDirectoryworkflow), required: true);
            WorkflowValue.Validate(purgeDirectoryrecursive, nameof(purgeDirectoryrecursive), required: false);
            WorkflowValue.Validate(purgeDirectorydeleteTopLevel, nameof(purgeDirectorydeleteTopLevel), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/PurgeDirectory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var purgeDirectory = new JObject();
                var purgeDirectorypropCount = 0;
                purgeDirectorypropCount++;
                purgeDirectory["DirectoryPath"] = ExpressionConverter.ConvertO(purgeDirectorydirectoryPath);
                if (purgeDirectoryrecursive != null)
                {
                    if (purgeDirectoryrecursive != null)
                    {
                        purgeDirectory["Recursive"] = ExpressionConverter.ConvertO(purgeDirectoryrecursive);
                        purgeDirectorypropCount++;
                    }

                    purgeDirectorypropCount++;
                }
                else
                {
                    purgeDirectory["Recursive"] = false;
                    purgeDirectorypropCount++;
                }

                if (purgeDirectorydeleteTopLevel != null)
                {
                    if (purgeDirectorydeleteTopLevel != null)
                    {
                        purgeDirectory["DeleteTopLevel"] = ExpressionConverter.ConvertO(purgeDirectorydeleteTopLevel);
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
                purgeDirectory["Workflow"] = ExpressionConverter.ConvertO(purgeDirectoryworkflow);
                if (purgeDirectorypropCount > 0)
                {
                    callPayload.Body = purgeDirectory;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildCopyFile))]
        public IWorkflowAction CopyFile([WorkflowExpression] Func<string> copyFilesourceFilePath, [WorkflowExpression] Func<string> copyFiledestFilePath, [WorkflowExpression] Func<string> copyFileworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCopyFile(WorkflowValue<string> copyFilesourceFilePath, WorkflowValue<string> copyFiledestFilePath, WorkflowValue<string> copyFileworkflow)
        {
            WorkflowValue.Validate(copyFilesourceFilePath, nameof(copyFilesourceFilePath), required: true);
            WorkflowValue.Validate(copyFiledestFilePath, nameof(copyFiledestFilePath), required: true);
            WorkflowValue.Validate(copyFileworkflow, nameof(copyFileworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/CopyFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var copyFile = new JObject();
                var copyFilepropCount = 0;
                copyFilepropCount++;
                copyFile["SourceFilePath"] = ExpressionConverter.ConvertO(copyFilesourceFilePath);
                copyFilepropCount++;
                copyFile["DestFilePath"] = ExpressionConverter.ConvertO(copyFiledestFilePath);
                copyFilepropCount++;
                copyFile["Workflow"] = ExpressionConverter.ConvertO(copyFileworkflow);
                if (copyFilepropCount > 0)
                {
                    callPayload.Body = copyFile;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildMoveFile))]
        public IWorkflowAction MoveFile([WorkflowExpression] Func<string> moveFilesourceFilePath, [WorkflowExpression] Func<string> moveFiledestFilePath, [WorkflowExpression] Func<string> moveFileworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveFile(WorkflowValue<string> moveFilesourceFilePath, WorkflowValue<string> moveFiledestFilePath, WorkflowValue<string> moveFileworkflow)
        {
            WorkflowValue.Validate(moveFilesourceFilePath, nameof(moveFilesourceFilePath), required: true);
            WorkflowValue.Validate(moveFiledestFilePath, nameof(moveFiledestFilePath), required: true);
            WorkflowValue.Validate(moveFileworkflow, nameof(moveFileworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/MoveFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var moveFile = new JObject();
                var moveFilepropCount = 0;
                moveFilepropCount++;
                moveFile["SourceFilePath"] = ExpressionConverter.ConvertO(moveFilesourceFilePath);
                moveFilepropCount++;
                moveFile["DestFilePath"] = ExpressionConverter.ConvertO(moveFiledestFilePath);
                moveFilepropCount++;
                moveFile["Workflow"] = ExpressionConverter.ConvertO(moveFileworkflow);
                if (moveFilepropCount > 0)
                {
                    callPayload.Body = moveFile;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDirectory))]
        public IWorkflowAction CreateDirectory([WorkflowExpression] Func<string> createDirectorydirectoryPath, [WorkflowExpression] Func<string> createDirectoryworkflow, [WorkflowExpression] Func<bool> createDirectoryerrorIfAlreadyExists = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateDirectory(WorkflowValue<string> createDirectorydirectoryPath, WorkflowValue<string> createDirectoryworkflow, WorkflowValue<bool> createDirectoryerrorIfAlreadyExists = null)
        {
            WorkflowValue.Validate(createDirectorydirectoryPath, nameof(createDirectorydirectoryPath), required: true);
            WorkflowValue.Validate(createDirectoryworkflow, nameof(createDirectoryworkflow), required: true);
            WorkflowValue.Validate(createDirectoryerrorIfAlreadyExists, nameof(createDirectoryerrorIfAlreadyExists), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/CreateDirectory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createDirectory = new JObject();
                var createDirectorypropCount = 0;
                createDirectorypropCount++;
                createDirectory["DirectoryPath"] = ExpressionConverter.ConvertO(createDirectorydirectoryPath);
                if (createDirectoryerrorIfAlreadyExists != null)
                {
                    if (createDirectoryerrorIfAlreadyExists != null)
                    {
                        createDirectory["ErrorIfAlreadyExists"] = ExpressionConverter.ConvertO(createDirectoryerrorIfAlreadyExists);
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
                createDirectory["Workflow"] = ExpressionConverter.ConvertO(createDirectoryworkflow);
                if (createDirectorypropCount > 0)
                {
                    callPayload.Body = createDirectory;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileSize))]
        public IBodyWorkflowAction<GetFileSizeResponse> GetFileSize([WorkflowExpression] Func<string> getFileSizefilename, [WorkflowExpression] Func<string> getFileSizeworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFileSizeResponse> __BuildGetFileSize(WorkflowValue<string> getFileSizefilename, WorkflowValue<string> getFileSizeworkflow)
        {
            WorkflowValue.Validate(getFileSizefilename, nameof(getFileSizefilename), required: true);
            WorkflowValue.Validate(getFileSizeworkflow, nameof(getFileSizeworkflow), required: true);
            return new DeferredBodyAction<GetFileSizeResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetFileSize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getFileSize = new JObject();
                var getFileSizepropCount = 0;
                getFileSizepropCount++;
                getFileSize["Filename"] = ExpressionConverter.ConvertO(getFileSizefilename);
                getFileSizepropCount++;
                getFileSize["Workflow"] = ExpressionConverter.ConvertO(getFileSizeworkflow);
                if (getFileSizepropCount > 0)
                {
                    callPayload.Body = getFileSize;
                }

                return new ApiConnectionAction<GetFileSizeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildWriteTextFile))]
        public IWorkflowAction WriteTextFile([WorkflowExpression] Func<string> writeTextFilefilename, [WorkflowExpression] Func<string> writeTextFileworkflow, [WorkflowExpression] Func<string> writeTextFiletextToWrite = null, [WorkflowExpression] Func<bool> writeTextFileappendExistingFile = null, [WorkflowExpression] Func<writeTextFileencodingInput> writeTextFileencoding = null, [WorkflowExpression] Func<bool> writeTextFilecreateFolderIfRequired = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildWriteTextFile(WorkflowValue<string> writeTextFilefilename, WorkflowValue<string> writeTextFileworkflow, WorkflowValue<string> writeTextFiletextToWrite = null, WorkflowValue<bool> writeTextFileappendExistingFile = null, WorkflowValue<writeTextFileencodingInput> writeTextFileencoding = null, WorkflowValue<bool> writeTextFilecreateFolderIfRequired = null)
        {
            WorkflowValue.Validate(writeTextFilefilename, nameof(writeTextFilefilename), required: true);
            WorkflowValue.Validate(writeTextFileworkflow, nameof(writeTextFileworkflow), required: true);
            WorkflowValue.Validate(writeTextFiletextToWrite, nameof(writeTextFiletextToWrite), required: false);
            WorkflowValue.Validate(writeTextFileappendExistingFile, nameof(writeTextFileappendExistingFile), required: false);
            WorkflowValue.Validate(writeTextFileencoding, nameof(writeTextFileencoding), required: false);
            WorkflowValue.Validate(writeTextFilecreateFolderIfRequired, nameof(writeTextFilecreateFolderIfRequired), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/WriteTextFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var writeTextFile = new JObject();
                var writeTextFilepropCount = 0;
                writeTextFilepropCount++;
                writeTextFile["Filename"] = ExpressionConverter.ConvertO(writeTextFilefilename);
                if (writeTextFiletextToWrite != null)
                {
                    writeTextFile["TextToWrite"] = ExpressionConverter.ConvertO(writeTextFiletextToWrite);
                    writeTextFilepropCount++;
                }

                if (writeTextFileappendExistingFile != null)
                {
                    if (writeTextFileappendExistingFile != null)
                    {
                        writeTextFile["AppendExistingFile"] = ExpressionConverter.ConvertO(writeTextFileappendExistingFile);
                        writeTextFilepropCount++;
                    }

                    writeTextFilepropCount++;
                }
                else
                {
                    writeTextFile["AppendExistingFile"] = false;
                    writeTextFilepropCount++;
                }

                if (writeTextFileencoding != null)
                {
                    writeTextFile["Encoding"] = ExpressionConverter.ConvertO(writeTextFileencoding);
                    writeTextFilepropCount++;
                }

                if (writeTextFilecreateFolderIfRequired != null)
                {
                    if (writeTextFilecreateFolderIfRequired != null)
                    {
                        writeTextFile["CreateFolderIfRequired"] = ExpressionConverter.ConvertO(writeTextFilecreateFolderIfRequired);
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
                writeTextFile["Workflow"] = ExpressionConverter.ConvertO(writeTextFileworkflow);
                if (writeTextFilepropCount > 0)
                {
                    callPayload.Body = writeTextFile;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildReadAllTextFromFile))]
        public IBodyWorkflowAction<ReadAllTextFromFileResponse> ReadAllTextFromFile([WorkflowExpression] Func<string> readAllTextFromFilefilename, [WorkflowExpression] Func<string> readAllTextFromFileworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadAllTextFromFileResponse> __BuildReadAllTextFromFile(WorkflowValue<string> readAllTextFromFilefilename, WorkflowValue<string> readAllTextFromFileworkflow)
        {
            WorkflowValue.Validate(readAllTextFromFilefilename, nameof(readAllTextFromFilefilename), required: true);
            WorkflowValue.Validate(readAllTextFromFileworkflow, nameof(readAllTextFromFileworkflow), required: true);
            return new DeferredBodyAction<ReadAllTextFromFileResponse>(() =>
            {
                var apiCallPath = "/FileManagement/ReadAllTextFromFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var readAllTextFromFile = new JObject();
                var readAllTextFromFilepropCount = 0;
                readAllTextFromFilepropCount++;
                readAllTextFromFile["Filename"] = ExpressionConverter.ConvertO(readAllTextFromFilefilename);
                readAllTextFromFilepropCount++;
                readAllTextFromFile["Workflow"] = ExpressionConverter.ConvertO(readAllTextFromFileworkflow);
                if (readAllTextFromFilepropCount > 0)
                {
                    callPayload.Body = readAllTextFromFile;
                }

                return new ApiConnectionAction<ReadAllTextFromFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetFiles))]
        public IBodyWorkflowAction<GetFilesResponse> GetFiles([WorkflowExpression] Func<string> getFilesdirectoryPath, [WorkflowExpression] Func<string> getFilespatternsCSV, [WorkflowExpression] Func<string> getFilesworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFilesResponse> __BuildGetFiles(WorkflowValue<string> getFilesdirectoryPath, WorkflowValue<string> getFilespatternsCSV, WorkflowValue<string> getFilesworkflow)
        {
            WorkflowValue.Validate(getFilesdirectoryPath, nameof(getFilesdirectoryPath), required: true);
            WorkflowValue.Validate(getFilespatternsCSV, nameof(getFilespatternsCSV), required: true);
            WorkflowValue.Validate(getFilesworkflow, nameof(getFilesworkflow), required: true);
            return new DeferredBodyAction<GetFilesResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetFiles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getFiles = new JObject();
                var getFilespropCount = 0;
                getFilespropCount++;
                getFiles["DirectoryPath"] = ExpressionConverter.ConvertO(getFilesdirectoryPath);
                getFilespropCount++;
                getFiles["PatternsCSV"] = ExpressionConverter.ConvertO(getFilespatternsCSV);
                getFilespropCount++;
                getFiles["Workflow"] = ExpressionConverter.ConvertO(getFilesworkflow);
                if (getFilespropCount > 0)
                {
                    callPayload.Body = getFiles;
                }

                return new ApiConnectionAction<GetFilesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetFolders))]
        public IBodyWorkflowAction<GetFoldersResponse> GetFolders([WorkflowExpression] Func<string> getFoldersdirectoryPath, [WorkflowExpression] Func<string> getFoldersworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFoldersResponse> __BuildGetFolders(WorkflowValue<string> getFoldersdirectoryPath, WorkflowValue<string> getFoldersworkflow)
        {
            WorkflowValue.Validate(getFoldersdirectoryPath, nameof(getFoldersdirectoryPath), required: true);
            WorkflowValue.Validate(getFoldersworkflow, nameof(getFoldersworkflow), required: true);
            return new DeferredBodyAction<GetFoldersResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetFolders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getFolders = new JObject();
                var getFolderspropCount = 0;
                getFolderspropCount++;
                getFolders["DirectoryPath"] = ExpressionConverter.ConvertO(getFoldersdirectoryPath);
                getFolderspropCount++;
                getFolders["Workflow"] = ExpressionConverter.ConvertO(getFoldersworkflow);
                if (getFolderspropCount > 0)
                {
                    callPayload.Body = getFolders;
                }

                return new ApiConnectionAction<GetFoldersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFiles))]
        public IBodyWorkflowAction<DeleteFilesResponse> DeleteFiles([WorkflowExpression] Func<string> deleteFilesdirectoryPath, [WorkflowExpression] Func<string> deleteFilesworkflow, [WorkflowExpression] Func<string> deleteFilespattern = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteFilesResponse> __BuildDeleteFiles(WorkflowValue<string> deleteFilesdirectoryPath, WorkflowValue<string> deleteFilesworkflow, WorkflowValue<string> deleteFilespattern = null)
        {
            WorkflowValue.Validate(deleteFilesdirectoryPath, nameof(deleteFilesdirectoryPath), required: true);
            WorkflowValue.Validate(deleteFilesworkflow, nameof(deleteFilesworkflow), required: true);
            WorkflowValue.Validate(deleteFilespattern, nameof(deleteFilespattern), required: false);
            return new DeferredBodyAction<DeleteFilesResponse>(() =>
            {
                var apiCallPath = "/FileManagement/DeleteFiles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteFiles = new JObject();
                var deleteFilespropCount = 0;
                deleteFilespropCount++;
                deleteFiles["DirectoryPath"] = ExpressionConverter.ConvertO(deleteFilesdirectoryPath);
                if (deleteFilespattern != null)
                {
                    deleteFiles["Pattern"] = ExpressionConverter.ConvertO(deleteFilespattern);
                    deleteFilespropCount++;
                }

                deleteFilespropCount++;
                deleteFiles["Workflow"] = ExpressionConverter.ConvertO(deleteFilesworkflow);
                if (deleteFilespropCount > 0)
                {
                    callPayload.Body = deleteFiles;
                }

                return new ApiConnectionAction<DeleteFilesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetDiskFreeSpace))]
        public IBodyWorkflowAction<GetDiskFreeSpaceResponse> GetDiskFreeSpace([WorkflowExpression] Func<string> getDiskFreeSpacedriveLetter, [WorkflowExpression] Func<string> getDiskFreeSpaceworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDiskFreeSpaceResponse> __BuildGetDiskFreeSpace(WorkflowValue<string> getDiskFreeSpacedriveLetter, WorkflowValue<string> getDiskFreeSpaceworkflow)
        {
            WorkflowValue.Validate(getDiskFreeSpacedriveLetter, nameof(getDiskFreeSpacedriveLetter), required: true);
            WorkflowValue.Validate(getDiskFreeSpaceworkflow, nameof(getDiskFreeSpaceworkflow), required: true);
            return new DeferredBodyAction<GetDiskFreeSpaceResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetDiskFreeSpace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getDiskFreeSpace = new JObject();
                var getDiskFreeSpacepropCount = 0;
                getDiskFreeSpacepropCount++;
                getDiskFreeSpace["DriveLetter"] = ExpressionConverter.ConvertO(getDiskFreeSpacedriveLetter);
                getDiskFreeSpacepropCount++;
                getDiskFreeSpace["Workflow"] = ExpressionConverter.ConvertO(getDiskFreeSpaceworkflow);
                if (getDiskFreeSpacepropCount > 0)
                {
                    callPayload.Body = getDiskFreeSpace;
                }

                return new ApiConnectionAction<GetDiskFreeSpaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetListOfDrives))]
        public IBodyWorkflowAction<GetListOfDrivesResponse> GetListOfDrives([WorkflowExpression] Func<string> getListOfDrivesworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetListOfDrivesResponse> __BuildGetListOfDrives(WorkflowValue<string> getListOfDrivesworkflow)
        {
            WorkflowValue.Validate(getListOfDrivesworkflow, nameof(getListOfDrivesworkflow), required: true);
            return new DeferredBodyAction<GetListOfDrivesResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetListOfDrives";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getListOfDrives = new JObject();
                var getListOfDrivespropCount = 0;
                getListOfDrivespropCount++;
                getListOfDrives["Workflow"] = ExpressionConverter.ConvertO(getListOfDrivesworkflow);
                if (getListOfDrivespropCount > 0)
                {
                    callPayload.Body = getListOfDrives;
                }

                return new ApiConnectionAction<GetListOfDrivesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildDirectoryIsAccessible))]
        public IBodyWorkflowAction<DirectoryIsAccessibleResponse> DirectoryIsAccessible([WorkflowExpression] Func<string> directoryIsAccessibledirectoryPath, [WorkflowExpression] Func<string> directoryIsAccessibleworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DirectoryIsAccessibleResponse> __BuildDirectoryIsAccessible(WorkflowValue<string> directoryIsAccessibledirectoryPath, WorkflowValue<string> directoryIsAccessibleworkflow)
        {
            WorkflowValue.Validate(directoryIsAccessibledirectoryPath, nameof(directoryIsAccessibledirectoryPath), required: true);
            WorkflowValue.Validate(directoryIsAccessibleworkflow, nameof(directoryIsAccessibleworkflow), required: true);
            return new DeferredBodyAction<DirectoryIsAccessibleResponse>(() =>
            {
                var apiCallPath = "/FileManagement/DirectoryIsAccessible";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var directoryIsAccessible = new JObject();
                var directoryIsAccessiblepropCount = 0;
                directoryIsAccessiblepropCount++;
                directoryIsAccessible["DirectoryPath"] = ExpressionConverter.ConvertO(directoryIsAccessibledirectoryPath);
                directoryIsAccessiblepropCount++;
                directoryIsAccessible["Workflow"] = ExpressionConverter.ConvertO(directoryIsAccessibleworkflow);
                if (directoryIsAccessiblepropCount > 0)
                {
                    callPayload.Body = directoryIsAccessible;
                }

                return new ApiConnectionAction<DirectoryIsAccessibleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetCSVTextAsCollection))]
        public IBodyWorkflowAction<GetCSVTextAsCollectionResponse> GetCSVTextAsCollection([WorkflowExpression] Func<string> getCSVTextAsCollectioncSVFilePath, [WorkflowExpression] Func<string> getCSVTextAsCollectionworkflow, [WorkflowExpression] Func<bool> getCSVTextAsCollectionfirstLineIsHeader = null, [WorkflowExpression] Func<bool> getCSVTextAsCollectiontrimHeaders = null, [WorkflowExpression] Func<bool> getCSVTextAsCollectionallowBlankRows = null, [WorkflowExpression] Func<bool> getCSVTextAsCollectionextendColumnsIfRequired = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCSVTextAsCollectionResponse> __BuildGetCSVTextAsCollection(WorkflowValue<string> getCSVTextAsCollectioncSVFilePath, WorkflowValue<string> getCSVTextAsCollectionworkflow, WorkflowValue<bool> getCSVTextAsCollectionfirstLineIsHeader = null, WorkflowValue<bool> getCSVTextAsCollectiontrimHeaders = null, WorkflowValue<bool> getCSVTextAsCollectionallowBlankRows = null, WorkflowValue<bool> getCSVTextAsCollectionextendColumnsIfRequired = null)
        {
            WorkflowValue.Validate(getCSVTextAsCollectioncSVFilePath, nameof(getCSVTextAsCollectioncSVFilePath), required: true);
            WorkflowValue.Validate(getCSVTextAsCollectionworkflow, nameof(getCSVTextAsCollectionworkflow), required: true);
            WorkflowValue.Validate(getCSVTextAsCollectionfirstLineIsHeader, nameof(getCSVTextAsCollectionfirstLineIsHeader), required: false);
            WorkflowValue.Validate(getCSVTextAsCollectiontrimHeaders, nameof(getCSVTextAsCollectiontrimHeaders), required: false);
            WorkflowValue.Validate(getCSVTextAsCollectionallowBlankRows, nameof(getCSVTextAsCollectionallowBlankRows), required: false);
            WorkflowValue.Validate(getCSVTextAsCollectionextendColumnsIfRequired, nameof(getCSVTextAsCollectionextendColumnsIfRequired), required: false);
            return new DeferredBodyAction<GetCSVTextAsCollectionResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetCSVTextAsCollection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getCSVTextAsCollection = new JObject();
                var getCSVTextAsCollectionpropCount = 0;
                getCSVTextAsCollectionpropCount++;
                getCSVTextAsCollection["CSVFilePath"] = ExpressionConverter.ConvertO(getCSVTextAsCollectioncSVFilePath);
                if (getCSVTextAsCollectionfirstLineIsHeader != null)
                {
                    if (getCSVTextAsCollectionfirstLineIsHeader != null)
                    {
                        getCSVTextAsCollection["FirstLineIsHeader"] = ExpressionConverter.ConvertO(getCSVTextAsCollectionfirstLineIsHeader);
                        getCSVTextAsCollectionpropCount++;
                    }

                    getCSVTextAsCollectionpropCount++;
                }
                else
                {
                    getCSVTextAsCollection["FirstLineIsHeader"] = true;
                    getCSVTextAsCollectionpropCount++;
                }

                if (getCSVTextAsCollectiontrimHeaders != null)
                {
                    if (getCSVTextAsCollectiontrimHeaders != null)
                    {
                        getCSVTextAsCollection["TrimHeaders"] = ExpressionConverter.ConvertO(getCSVTextAsCollectiontrimHeaders);
                        getCSVTextAsCollectionpropCount++;
                    }

                    getCSVTextAsCollectionpropCount++;
                }
                else
                {
                    getCSVTextAsCollection["TrimHeaders"] = true;
                    getCSVTextAsCollectionpropCount++;
                }

                if (getCSVTextAsCollectionallowBlankRows != null)
                {
                    if (getCSVTextAsCollectionallowBlankRows != null)
                    {
                        getCSVTextAsCollection["AllowBlankRows"] = ExpressionConverter.ConvertO(getCSVTextAsCollectionallowBlankRows);
                        getCSVTextAsCollectionpropCount++;
                    }

                    getCSVTextAsCollectionpropCount++;
                }
                else
                {
                    getCSVTextAsCollection["AllowBlankRows"] = true;
                    getCSVTextAsCollectionpropCount++;
                }

                if (getCSVTextAsCollectionextendColumnsIfRequired != null)
                {
                    if (getCSVTextAsCollectionextendColumnsIfRequired != null)
                    {
                        getCSVTextAsCollection["ExtendColumnsIfRequired"] = ExpressionConverter.ConvertO(getCSVTextAsCollectionextendColumnsIfRequired);
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
                getCSVTextAsCollection["Workflow"] = ExpressionConverter.ConvertO(getCSVTextAsCollectionworkflow);
                if (getCSVTextAsCollectionpropCount > 0)
                {
                    callPayload.Body = getCSVTextAsCollection;
                }

                return new ApiConnectionAction<GetCSVTextAsCollectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildWriteCollectionToCSVFile))]
        public IBodyWorkflowAction<WriteCollectionToCSVFileResponse> WriteCollectionToCSVFile([WorkflowExpression] Func<string> writeCollectionToCSVFilecSVFilePath, [WorkflowExpression] Func<string> writeCollectionToCSVFileworkflow, [WorkflowExpression] Func<JToken[]> writeCollectionToCSVFileinputTable = null, [WorkflowExpression] Func<string> writeCollectionToCSVFileinputTableJSON = null, [WorkflowExpression] Func<writeCollectionToCSVFileoutputEncodingInput> writeCollectionToCSVFileoutputEncoding = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WriteCollectionToCSVFileResponse> __BuildWriteCollectionToCSVFile(WorkflowValue<string> writeCollectionToCSVFilecSVFilePath, WorkflowValue<string> writeCollectionToCSVFileworkflow, WorkflowValue<JToken[]> writeCollectionToCSVFileinputTable = null, WorkflowValue<string> writeCollectionToCSVFileinputTableJSON = null, WorkflowValue<writeCollectionToCSVFileoutputEncodingInput> writeCollectionToCSVFileoutputEncoding = null)
        {
            WorkflowValue.Validate(writeCollectionToCSVFilecSVFilePath, nameof(writeCollectionToCSVFilecSVFilePath), required: true);
            WorkflowValue.Validate(writeCollectionToCSVFileworkflow, nameof(writeCollectionToCSVFileworkflow), required: true);
            WorkflowValue.Validate(writeCollectionToCSVFileinputTable, nameof(writeCollectionToCSVFileinputTable), required: false);
            WorkflowValue.Validate(writeCollectionToCSVFileinputTableJSON, nameof(writeCollectionToCSVFileinputTableJSON), required: false);
            WorkflowValue.Validate(writeCollectionToCSVFileoutputEncoding, nameof(writeCollectionToCSVFileoutputEncoding), required: false);
            return new DeferredBodyAction<WriteCollectionToCSVFileResponse>(() =>
            {
                var apiCallPath = "/FileManagement/WriteCollectionToCSVFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var writeCollectionToCSVFile = new JObject();
                var writeCollectionToCSVFilepropCount = 0;
                if (writeCollectionToCSVFileinputTable != null)
                {
                    writeCollectionToCSVFile["InputTable"] = ExpressionConverter.ConvertO(writeCollectionToCSVFileinputTable);
                    writeCollectionToCSVFilepropCount++;
                }

                if (writeCollectionToCSVFileinputTableJSON != null)
                {
                    writeCollectionToCSVFile["InputTableJSON"] = ExpressionConverter.ConvertO(writeCollectionToCSVFileinputTableJSON);
                    writeCollectionToCSVFilepropCount++;
                }

                writeCollectionToCSVFilepropCount++;
                writeCollectionToCSVFile["CSVFilePath"] = ExpressionConverter.ConvertO(writeCollectionToCSVFilecSVFilePath);
                if (writeCollectionToCSVFileoutputEncoding != null)
                {
                    if (writeCollectionToCSVFileoutputEncoding != null)
                    {
                        writeCollectionToCSVFile["OutputEncoding"] = ExpressionConverter.ConvertO(writeCollectionToCSVFileoutputEncoding);
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
                writeCollectionToCSVFile["Workflow"] = ExpressionConverter.ConvertO(writeCollectionToCSVFileworkflow);
                if (writeCollectionToCSVFilepropCount > 0)
                {
                    callPayload.Body = writeCollectionToCSVFile;
                }

                return new ApiConnectionAction<WriteCollectionToCSVFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetOwnerOnFolder))]
        public IWorkflowAction SetOwnerOnFolder([WorkflowExpression] Func<string> setOwnerOnFolderfolderPath, [WorkflowExpression] Func<string> setOwnerOnFolderuserIdentity, [WorkflowExpression] Func<string> setOwnerOnFolderworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetOwnerOnFolder(WorkflowValue<string> setOwnerOnFolderfolderPath, WorkflowValue<string> setOwnerOnFolderuserIdentity, WorkflowValue<string> setOwnerOnFolderworkflow)
        {
            WorkflowValue.Validate(setOwnerOnFolderfolderPath, nameof(setOwnerOnFolderfolderPath), required: true);
            WorkflowValue.Validate(setOwnerOnFolderuserIdentity, nameof(setOwnerOnFolderuserIdentity), required: true);
            WorkflowValue.Validate(setOwnerOnFolderworkflow, nameof(setOwnerOnFolderworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/SetOwnerOnFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setOwnerOnFolder = new JObject();
                var setOwnerOnFolderpropCount = 0;
                setOwnerOnFolderpropCount++;
                setOwnerOnFolder["FolderPath"] = ExpressionConverter.ConvertO(setOwnerOnFolderfolderPath);
                setOwnerOnFolderpropCount++;
                setOwnerOnFolder["UserIdentity"] = ExpressionConverter.ConvertO(setOwnerOnFolderuserIdentity);
                setOwnerOnFolderpropCount++;
                setOwnerOnFolder["Workflow"] = ExpressionConverter.ConvertO(setOwnerOnFolderworkflow);
                if (setOwnerOnFolderpropCount > 0)
                {
                    callPayload.Body = setOwnerOnFolder;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildSetOwnerOnFile))]
        public IWorkflowAction SetOwnerOnFile([WorkflowExpression] Func<string> setOwnerOnFilefilePath, [WorkflowExpression] Func<string> setOwnerOnFileuserIdentity, [WorkflowExpression] Func<string> setOwnerOnFileworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetOwnerOnFile(WorkflowValue<string> setOwnerOnFilefilePath, WorkflowValue<string> setOwnerOnFileuserIdentity, WorkflowValue<string> setOwnerOnFileworkflow)
        {
            WorkflowValue.Validate(setOwnerOnFilefilePath, nameof(setOwnerOnFilefilePath), required: true);
            WorkflowValue.Validate(setOwnerOnFileuserIdentity, nameof(setOwnerOnFileuserIdentity), required: true);
            WorkflowValue.Validate(setOwnerOnFileworkflow, nameof(setOwnerOnFileworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/SetOwnerOnFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setOwnerOnFile = new JObject();
                var setOwnerOnFilepropCount = 0;
                setOwnerOnFilepropCount++;
                setOwnerOnFile["FilePath"] = ExpressionConverter.ConvertO(setOwnerOnFilefilePath);
                setOwnerOnFilepropCount++;
                setOwnerOnFile["UserIdentity"] = ExpressionConverter.ConvertO(setOwnerOnFileuserIdentity);
                setOwnerOnFilepropCount++;
                setOwnerOnFile["Workflow"] = ExpressionConverter.ConvertO(setOwnerOnFileworkflow);
                if (setOwnerOnFilepropCount > 0)
                {
                    callPayload.Body = setOwnerOnFile;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildAddPermissionToFolder))]
        public IWorkflowAction AddPermissionToFolder([WorkflowExpression] Func<string> addPermissionToFolderfolderPath, [WorkflowExpression] Func<string> addPermissionToFolderidentity, [WorkflowExpression] Func<addPermissionToFolderpermissionInput> addPermissionToFolderpermission, [WorkflowExpression] Func<string> addPermissionToFolderworkflow, [WorkflowExpression] Func<bool> addPermissionToFolderapplyToFolder = null, [WorkflowExpression] Func<bool> addPermissionToFolderapplyToSubFolders = null, [WorkflowExpression] Func<bool> addPermissionToFolderapplyToFiles = null, [WorkflowExpression] Func<bool> addPermissionToFolderdeny = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddPermissionToFolder(WorkflowValue<string> addPermissionToFolderfolderPath, WorkflowValue<string> addPermissionToFolderidentity, WorkflowValue<addPermissionToFolderpermissionInput> addPermissionToFolderpermission, WorkflowValue<string> addPermissionToFolderworkflow, WorkflowValue<bool> addPermissionToFolderapplyToFolder = null, WorkflowValue<bool> addPermissionToFolderapplyToSubFolders = null, WorkflowValue<bool> addPermissionToFolderapplyToFiles = null, WorkflowValue<bool> addPermissionToFolderdeny = null)
        {
            WorkflowValue.Validate(addPermissionToFolderfolderPath, nameof(addPermissionToFolderfolderPath), required: true);
            WorkflowValue.Validate(addPermissionToFolderidentity, nameof(addPermissionToFolderidentity), required: true);
            WorkflowValue.Validate(addPermissionToFolderpermission, nameof(addPermissionToFolderpermission), required: true);
            WorkflowValue.Validate(addPermissionToFolderworkflow, nameof(addPermissionToFolderworkflow), required: true);
            WorkflowValue.Validate(addPermissionToFolderapplyToFolder, nameof(addPermissionToFolderapplyToFolder), required: false);
            WorkflowValue.Validate(addPermissionToFolderapplyToSubFolders, nameof(addPermissionToFolderapplyToSubFolders), required: false);
            WorkflowValue.Validate(addPermissionToFolderapplyToFiles, nameof(addPermissionToFolderapplyToFiles), required: false);
            WorkflowValue.Validate(addPermissionToFolderdeny, nameof(addPermissionToFolderdeny), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/AddPermissionToFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addPermissionToFolder = new JObject();
                var addPermissionToFolderpropCount = 0;
                addPermissionToFolderpropCount++;
                addPermissionToFolder["FolderPath"] = ExpressionConverter.ConvertO(addPermissionToFolderfolderPath);
                addPermissionToFolderpropCount++;
                addPermissionToFolder["Identity"] = ExpressionConverter.ConvertO(addPermissionToFolderidentity);
                addPermissionToFolderpropCount++;
                addPermissionToFolder["Permission"] = ExpressionConverter.ConvertO(addPermissionToFolderpermission);
                if (addPermissionToFolderapplyToFolder != null)
                {
                    if (addPermissionToFolderapplyToFolder != null)
                    {
                        addPermissionToFolder["ApplyToFolder"] = ExpressionConverter.ConvertO(addPermissionToFolderapplyToFolder);
                        addPermissionToFolderpropCount++;
                    }

                    addPermissionToFolderpropCount++;
                }
                else
                {
                    addPermissionToFolder["ApplyToFolder"] = false;
                    addPermissionToFolderpropCount++;
                }

                if (addPermissionToFolderapplyToSubFolders != null)
                {
                    if (addPermissionToFolderapplyToSubFolders != null)
                    {
                        addPermissionToFolder["ApplyToSubFolders"] = ExpressionConverter.ConvertO(addPermissionToFolderapplyToSubFolders);
                        addPermissionToFolderpropCount++;
                    }

                    addPermissionToFolderpropCount++;
                }
                else
                {
                    addPermissionToFolder["ApplyToSubFolders"] = true;
                    addPermissionToFolderpropCount++;
                }

                if (addPermissionToFolderapplyToFiles != null)
                {
                    if (addPermissionToFolderapplyToFiles != null)
                    {
                        addPermissionToFolder["ApplyToFiles"] = ExpressionConverter.ConvertO(addPermissionToFolderapplyToFiles);
                        addPermissionToFolderpropCount++;
                    }

                    addPermissionToFolderpropCount++;
                }
                else
                {
                    addPermissionToFolder["ApplyToFiles"] = true;
                    addPermissionToFolderpropCount++;
                }

                if (addPermissionToFolderdeny != null)
                {
                    if (addPermissionToFolderdeny != null)
                    {
                        addPermissionToFolder["Deny"] = ExpressionConverter.ConvertO(addPermissionToFolderdeny);
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
                addPermissionToFolder["Workflow"] = ExpressionConverter.ConvertO(addPermissionToFolderworkflow);
                if (addPermissionToFolderpropCount > 0)
                {
                    callPayload.Body = addPermissionToFolder;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildAddPermissionToFile))]
        public IWorkflowAction AddPermissionToFile([WorkflowExpression] Func<string> addPermissionToFilefilePath, [WorkflowExpression] Func<string> addPermissionToFileidentity, [WorkflowExpression] Func<addPermissionToFilepermissionInput> addPermissionToFilepermission, [WorkflowExpression] Func<string> addPermissionToFileworkflow, [WorkflowExpression] Func<bool> addPermissionToFiledeny = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddPermissionToFile(WorkflowValue<string> addPermissionToFilefilePath, WorkflowValue<string> addPermissionToFileidentity, WorkflowValue<addPermissionToFilepermissionInput> addPermissionToFilepermission, WorkflowValue<string> addPermissionToFileworkflow, WorkflowValue<bool> addPermissionToFiledeny = null)
        {
            WorkflowValue.Validate(addPermissionToFilefilePath, nameof(addPermissionToFilefilePath), required: true);
            WorkflowValue.Validate(addPermissionToFileidentity, nameof(addPermissionToFileidentity), required: true);
            WorkflowValue.Validate(addPermissionToFilepermission, nameof(addPermissionToFilepermission), required: true);
            WorkflowValue.Validate(addPermissionToFileworkflow, nameof(addPermissionToFileworkflow), required: true);
            WorkflowValue.Validate(addPermissionToFiledeny, nameof(addPermissionToFiledeny), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/AddPermissionToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addPermissionToFile = new JObject();
                var addPermissionToFilepropCount = 0;
                addPermissionToFilepropCount++;
                addPermissionToFile["FilePath"] = ExpressionConverter.ConvertO(addPermissionToFilefilePath);
                addPermissionToFilepropCount++;
                addPermissionToFile["Identity"] = ExpressionConverter.ConvertO(addPermissionToFileidentity);
                addPermissionToFilepropCount++;
                addPermissionToFile["Permission"] = ExpressionConverter.ConvertO(addPermissionToFilepermission);
                if (addPermissionToFiledeny != null)
                {
                    if (addPermissionToFiledeny != null)
                    {
                        addPermissionToFile["Deny"] = ExpressionConverter.ConvertO(addPermissionToFiledeny);
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
                addPermissionToFile["Workflow"] = ExpressionConverter.ConvertO(addPermissionToFileworkflow);
                if (addPermissionToFilepropCount > 0)
                {
                    callPayload.Body = addPermissionToFile;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildBreakFolderSecurityInheritance))]
        public IWorkflowAction BreakFolderSecurityInheritance([WorkflowExpression] Func<string> breakFolderSecurityInheritancefolderPath, [WorkflowExpression] Func<string> breakFolderSecurityInheritanceworkflow, [WorkflowExpression] Func<bool> breakFolderSecurityInheritanceconvertInheritedToExplicit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBreakFolderSecurityInheritance(WorkflowValue<string> breakFolderSecurityInheritancefolderPath, WorkflowValue<string> breakFolderSecurityInheritanceworkflow, WorkflowValue<bool> breakFolderSecurityInheritanceconvertInheritedToExplicit = null)
        {
            WorkflowValue.Validate(breakFolderSecurityInheritancefolderPath, nameof(breakFolderSecurityInheritancefolderPath), required: true);
            WorkflowValue.Validate(breakFolderSecurityInheritanceworkflow, nameof(breakFolderSecurityInheritanceworkflow), required: true);
            WorkflowValue.Validate(breakFolderSecurityInheritanceconvertInheritedToExplicit, nameof(breakFolderSecurityInheritanceconvertInheritedToExplicit), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/BreakFolderSecurityInheritance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var breakFolderSecurityInheritance = new JObject();
                var breakFolderSecurityInheritancepropCount = 0;
                breakFolderSecurityInheritancepropCount++;
                breakFolderSecurityInheritance["FolderPath"] = ExpressionConverter.ConvertO(breakFolderSecurityInheritancefolderPath);
                if (breakFolderSecurityInheritanceconvertInheritedToExplicit != null)
                {
                    if (breakFolderSecurityInheritanceconvertInheritedToExplicit != null)
                    {
                        breakFolderSecurityInheritance["ConvertInheritedToExplicit"] = ExpressionConverter.ConvertO(breakFolderSecurityInheritanceconvertInheritedToExplicit);
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
                breakFolderSecurityInheritance["Workflow"] = ExpressionConverter.ConvertO(breakFolderSecurityInheritanceworkflow);
                if (breakFolderSecurityInheritancepropCount > 0)
                {
                    callPayload.Body = breakFolderSecurityInheritance;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildEnableFolderSecurityInheritance))]
        public IWorkflowAction EnableFolderSecurityInheritance([WorkflowExpression] Func<string> enableFolderSecurityInheritancefolderPath, [WorkflowExpression] Func<string> enableFolderSecurityInheritanceworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEnableFolderSecurityInheritance(WorkflowValue<string> enableFolderSecurityInheritancefolderPath, WorkflowValue<string> enableFolderSecurityInheritanceworkflow)
        {
            WorkflowValue.Validate(enableFolderSecurityInheritancefolderPath, nameof(enableFolderSecurityInheritancefolderPath), required: true);
            WorkflowValue.Validate(enableFolderSecurityInheritanceworkflow, nameof(enableFolderSecurityInheritanceworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/EnableFolderSecurityInheritance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var enableFolderSecurityInheritance = new JObject();
                var enableFolderSecurityInheritancepropCount = 0;
                enableFolderSecurityInheritancepropCount++;
                enableFolderSecurityInheritance["FolderPath"] = ExpressionConverter.ConvertO(enableFolderSecurityInheritancefolderPath);
                enableFolderSecurityInheritancepropCount++;
                enableFolderSecurityInheritance["Workflow"] = ExpressionConverter.ConvertO(enableFolderSecurityInheritanceworkflow);
                if (enableFolderSecurityInheritancepropCount > 0)
                {
                    callPayload.Body = enableFolderSecurityInheritance;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetFolderSecurityPermissions))]
        public IBodyWorkflowAction<GetFolderSecurityPermissionsResponse> GetFolderSecurityPermissions([WorkflowExpression] Func<string> getFolderSecurityPermissionsfolderPath, [WorkflowExpression] Func<string> getFolderSecurityPermissionsworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFolderSecurityPermissionsResponse> __BuildGetFolderSecurityPermissions(WorkflowValue<string> getFolderSecurityPermissionsfolderPath, WorkflowValue<string> getFolderSecurityPermissionsworkflow)
        {
            WorkflowValue.Validate(getFolderSecurityPermissionsfolderPath, nameof(getFolderSecurityPermissionsfolderPath), required: true);
            WorkflowValue.Validate(getFolderSecurityPermissionsworkflow, nameof(getFolderSecurityPermissionsworkflow), required: true);
            return new DeferredBodyAction<GetFolderSecurityPermissionsResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetFolderSecurityPermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getFolderSecurityPermissions = new JObject();
                var getFolderSecurityPermissionspropCount = 0;
                getFolderSecurityPermissionspropCount++;
                getFolderSecurityPermissions["FolderPath"] = ExpressionConverter.ConvertO(getFolderSecurityPermissionsfolderPath);
                getFolderSecurityPermissionspropCount++;
                getFolderSecurityPermissions["Workflow"] = ExpressionConverter.ConvertO(getFolderSecurityPermissionsworkflow);
                if (getFolderSecurityPermissionspropCount > 0)
                {
                    callPayload.Body = getFolderSecurityPermissions;
                }

                return new ApiConnectionAction<GetFolderSecurityPermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileSecurityPermissions))]
        public IBodyWorkflowAction<GetFileSecurityPermissionsResponse> GetFileSecurityPermissions([WorkflowExpression] Func<string> getFileSecurityPermissionsfilePath, [WorkflowExpression] Func<string> getFileSecurityPermissionsworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFileSecurityPermissionsResponse> __BuildGetFileSecurityPermissions(WorkflowValue<string> getFileSecurityPermissionsfilePath, WorkflowValue<string> getFileSecurityPermissionsworkflow)
        {
            WorkflowValue.Validate(getFileSecurityPermissionsfilePath, nameof(getFileSecurityPermissionsfilePath), required: true);
            WorkflowValue.Validate(getFileSecurityPermissionsworkflow, nameof(getFileSecurityPermissionsworkflow), required: true);
            return new DeferredBodyAction<GetFileSecurityPermissionsResponse>(() =>
            {
                var apiCallPath = "/FileManagement/GetFileSecurityPermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getFileSecurityPermissions = new JObject();
                var getFileSecurityPermissionspropCount = 0;
                getFileSecurityPermissionspropCount++;
                getFileSecurityPermissions["FilePath"] = ExpressionConverter.ConvertO(getFileSecurityPermissionsfilePath);
                getFileSecurityPermissionspropCount++;
                getFileSecurityPermissions["Workflow"] = ExpressionConverter.ConvertO(getFileSecurityPermissionsworkflow);
                if (getFileSecurityPermissionspropCount > 0)
                {
                    callPayload.Body = getFileSecurityPermissions;
                }

                return new ApiConnectionAction<GetFileSecurityPermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveIdentityFromFolderSecurity))]
        public IBodyWorkflowAction<RemoveIdentityFromFolderSecurityResponse> RemoveIdentityFromFolderSecurity([WorkflowExpression] Func<string> removeIdentityFromFolderSecurityfolderPath, [WorkflowExpression] Func<string> removeIdentityFromFolderSecurityidentityToRemove, [WorkflowExpression] Func<string> removeIdentityFromFolderSecurityworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemoveIdentityFromFolderSecurityResponse> __BuildRemoveIdentityFromFolderSecurity(WorkflowValue<string> removeIdentityFromFolderSecurityfolderPath, WorkflowValue<string> removeIdentityFromFolderSecurityidentityToRemove, WorkflowValue<string> removeIdentityFromFolderSecurityworkflow)
        {
            WorkflowValue.Validate(removeIdentityFromFolderSecurityfolderPath, nameof(removeIdentityFromFolderSecurityfolderPath), required: true);
            WorkflowValue.Validate(removeIdentityFromFolderSecurityidentityToRemove, nameof(removeIdentityFromFolderSecurityidentityToRemove), required: true);
            WorkflowValue.Validate(removeIdentityFromFolderSecurityworkflow, nameof(removeIdentityFromFolderSecurityworkflow), required: true);
            return new DeferredBodyAction<RemoveIdentityFromFolderSecurityResponse>(() =>
            {
                var apiCallPath = "/FileManagement/RemoveIdentityFromFolderSecurity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var removeIdentityFromFolderSecurity = new JObject();
                var removeIdentityFromFolderSecuritypropCount = 0;
                removeIdentityFromFolderSecuritypropCount++;
                removeIdentityFromFolderSecurity["FolderPath"] = ExpressionConverter.ConvertO(removeIdentityFromFolderSecurityfolderPath);
                removeIdentityFromFolderSecuritypropCount++;
                removeIdentityFromFolderSecurity["IdentityToRemove"] = ExpressionConverter.ConvertO(removeIdentityFromFolderSecurityidentityToRemove);
                removeIdentityFromFolderSecuritypropCount++;
                removeIdentityFromFolderSecurity["Workflow"] = ExpressionConverter.ConvertO(removeIdentityFromFolderSecurityworkflow);
                if (removeIdentityFromFolderSecuritypropCount > 0)
                {
                    callPayload.Body = removeIdentityFromFolderSecurity;
                }

                return new ApiConnectionAction<RemoveIdentityFromFolderSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveIdentityFromFileSecurity))]
        public IBodyWorkflowAction<RemoveIdentityFromFileSecurityResponse> RemoveIdentityFromFileSecurity([WorkflowExpression] Func<string> removeIdentityFromFileSecurityfilePath, [WorkflowExpression] Func<string> removeIdentityFromFileSecurityidentityToRemove, [WorkflowExpression] Func<string> removeIdentityFromFileSecurityworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemoveIdentityFromFileSecurityResponse> __BuildRemoveIdentityFromFileSecurity(WorkflowValue<string> removeIdentityFromFileSecurityfilePath, WorkflowValue<string> removeIdentityFromFileSecurityidentityToRemove, WorkflowValue<string> removeIdentityFromFileSecurityworkflow)
        {
            WorkflowValue.Validate(removeIdentityFromFileSecurityfilePath, nameof(removeIdentityFromFileSecurityfilePath), required: true);
            WorkflowValue.Validate(removeIdentityFromFileSecurityidentityToRemove, nameof(removeIdentityFromFileSecurityidentityToRemove), required: true);
            WorkflowValue.Validate(removeIdentityFromFileSecurityworkflow, nameof(removeIdentityFromFileSecurityworkflow), required: true);
            return new DeferredBodyAction<RemoveIdentityFromFileSecurityResponse>(() =>
            {
                var apiCallPath = "/FileManagement/RemoveIdentityFromFileSecurity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var removeIdentityFromFileSecurity = new JObject();
                var removeIdentityFromFileSecuritypropCount = 0;
                removeIdentityFromFileSecuritypropCount++;
                removeIdentityFromFileSecurity["FilePath"] = ExpressionConverter.ConvertO(removeIdentityFromFileSecurityfilePath);
                removeIdentityFromFileSecuritypropCount++;
                removeIdentityFromFileSecurity["IdentityToRemove"] = ExpressionConverter.ConvertO(removeIdentityFromFileSecurityidentityToRemove);
                removeIdentityFromFileSecuritypropCount++;
                removeIdentityFromFileSecurity["Workflow"] = ExpressionConverter.ConvertO(removeIdentityFromFileSecurityworkflow);
                if (removeIdentityFromFileSecuritypropCount > 0)
                {
                    callPayload.Body = removeIdentityFromFileSecurity;
                }

                return new ApiConnectionAction<RemoveIdentityFromFileSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildCopyFileFromClientToServer))]
        public IWorkflowAction CopyFileFromClientToServer([WorkflowExpression] Func<string> copyFileFromClientToServerclientFilePath, [WorkflowExpression] Func<string> copyFileFromClientToServerserverFilePath, [WorkflowExpression] Func<string> copyFileFromClientToServerworkflow, [WorkflowExpression] Func<bool> copyFileFromClientToServercompress = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCopyFileFromClientToServer(WorkflowValue<string> copyFileFromClientToServerclientFilePath, WorkflowValue<string> copyFileFromClientToServerserverFilePath, WorkflowValue<string> copyFileFromClientToServerworkflow, WorkflowValue<bool> copyFileFromClientToServercompress = null)
        {
            WorkflowValue.Validate(copyFileFromClientToServerclientFilePath, nameof(copyFileFromClientToServerclientFilePath), required: true);
            WorkflowValue.Validate(copyFileFromClientToServerserverFilePath, nameof(copyFileFromClientToServerserverFilePath), required: true);
            WorkflowValue.Validate(copyFileFromClientToServerworkflow, nameof(copyFileFromClientToServerworkflow), required: true);
            WorkflowValue.Validate(copyFileFromClientToServercompress, nameof(copyFileFromClientToServercompress), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/CopyFileFromClientToServer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var copyFileFromClientToServer = new JObject();
                var copyFileFromClientToServerpropCount = 0;
                copyFileFromClientToServerpropCount++;
                copyFileFromClientToServer["ClientFilePath"] = ExpressionConverter.ConvertO(copyFileFromClientToServerclientFilePath);
                copyFileFromClientToServerpropCount++;
                copyFileFromClientToServer["ServerFilePath"] = ExpressionConverter.ConvertO(copyFileFromClientToServerserverFilePath);
                if (copyFileFromClientToServercompress != null)
                {
                    if (copyFileFromClientToServercompress != null)
                    {
                        copyFileFromClientToServer["Compress"] = ExpressionConverter.ConvertO(copyFileFromClientToServercompress);
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
                copyFileFromClientToServer["Workflow"] = ExpressionConverter.ConvertO(copyFileFromClientToServerworkflow);
                if (copyFileFromClientToServerpropCount > 0)
                {
                    callPayload.Body = copyFileFromClientToServer;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildReplaceVariableDataInINIFile))]
        public IWorkflowAction ReplaceVariableDataInINIFile([WorkflowExpression] Func<string> replaceVariableDataInINIFileinputFilename, [WorkflowExpression] Func<string> replaceVariableDataInINIFileworkflow, [WorkflowExpression] Func<string> replaceVariableDataInINIFileoutputFilename = null, [WorkflowExpression] Func<string> replaceVariableDataInINIFilesearchSection = null, [WorkflowExpression] Func<string> replaceVariableDataInINIFilesearchVariable = null, [WorkflowExpression] Func<string> replaceVariableDataInINIFilereplaceData = null, [WorkflowExpression] Func<string> replaceVariableDataInINIFileinputFilenameEncoding = null, [WorkflowExpression] Func<bool> replaceVariableDataInINIFilecreateNewFileIfNotExists = null, [WorkflowExpression] Func<bool> replaceVariableDataInINIFilewriteSpaceBeforeEquals = null, [WorkflowExpression] Func<bool> replaceVariableDataInINIFilewriteSpaceAfterEquals = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReplaceVariableDataInINIFile(WorkflowValue<string> replaceVariableDataInINIFileinputFilename, WorkflowValue<string> replaceVariableDataInINIFileworkflow, WorkflowValue<string> replaceVariableDataInINIFileoutputFilename = null, WorkflowValue<string> replaceVariableDataInINIFilesearchSection = null, WorkflowValue<string> replaceVariableDataInINIFilesearchVariable = null, WorkflowValue<string> replaceVariableDataInINIFilereplaceData = null, WorkflowValue<string> replaceVariableDataInINIFileinputFilenameEncoding = null, WorkflowValue<bool> replaceVariableDataInINIFilecreateNewFileIfNotExists = null, WorkflowValue<bool> replaceVariableDataInINIFilewriteSpaceBeforeEquals = null, WorkflowValue<bool> replaceVariableDataInINIFilewriteSpaceAfterEquals = null)
        {
            WorkflowValue.Validate(replaceVariableDataInINIFileinputFilename, nameof(replaceVariableDataInINIFileinputFilename), required: true);
            WorkflowValue.Validate(replaceVariableDataInINIFileworkflow, nameof(replaceVariableDataInINIFileworkflow), required: true);
            WorkflowValue.Validate(replaceVariableDataInINIFileoutputFilename, nameof(replaceVariableDataInINIFileoutputFilename), required: false);
            WorkflowValue.Validate(replaceVariableDataInINIFilesearchSection, nameof(replaceVariableDataInINIFilesearchSection), required: false);
            WorkflowValue.Validate(replaceVariableDataInINIFilesearchVariable, nameof(replaceVariableDataInINIFilesearchVariable), required: false);
            WorkflowValue.Validate(replaceVariableDataInINIFilereplaceData, nameof(replaceVariableDataInINIFilereplaceData), required: false);
            WorkflowValue.Validate(replaceVariableDataInINIFileinputFilenameEncoding, nameof(replaceVariableDataInINIFileinputFilenameEncoding), required: false);
            WorkflowValue.Validate(replaceVariableDataInINIFilecreateNewFileIfNotExists, nameof(replaceVariableDataInINIFilecreateNewFileIfNotExists), required: false);
            WorkflowValue.Validate(replaceVariableDataInINIFilewriteSpaceBeforeEquals, nameof(replaceVariableDataInINIFilewriteSpaceBeforeEquals), required: false);
            WorkflowValue.Validate(replaceVariableDataInINIFilewriteSpaceAfterEquals, nameof(replaceVariableDataInINIFilewriteSpaceAfterEquals), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/ReplaceVariableDataInINIFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var replaceVariableDataInINIFile = new JObject();
                var replaceVariableDataInINIFilepropCount = 0;
                replaceVariableDataInINIFilepropCount++;
                replaceVariableDataInINIFile["InputFilename"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFileinputFilename);
                if (replaceVariableDataInINIFileoutputFilename != null)
                {
                    replaceVariableDataInINIFile["OutputFilename"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFileoutputFilename);
                    replaceVariableDataInINIFilepropCount++;
                }

                if (replaceVariableDataInINIFilesearchSection != null)
                {
                    replaceVariableDataInINIFile["SearchSection"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFilesearchSection);
                    replaceVariableDataInINIFilepropCount++;
                }

                if (replaceVariableDataInINIFilesearchVariable != null)
                {
                    replaceVariableDataInINIFile["SearchVariable"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFilesearchVariable);
                    replaceVariableDataInINIFilepropCount++;
                }

                if (replaceVariableDataInINIFilereplaceData != null)
                {
                    replaceVariableDataInINIFile["ReplaceData"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFilereplaceData);
                    replaceVariableDataInINIFilepropCount++;
                }

                if (replaceVariableDataInINIFileinputFilenameEncoding != null)
                {
                    replaceVariableDataInINIFile["InputFilenameEncoding"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFileinputFilenameEncoding);
                    replaceVariableDataInINIFilepropCount++;
                }

                if (replaceVariableDataInINIFilecreateNewFileIfNotExists != null)
                {
                    if (replaceVariableDataInINIFilecreateNewFileIfNotExists != null)
                    {
                        replaceVariableDataInINIFile["CreateNewFileIfNotExists"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFilecreateNewFileIfNotExists);
                        replaceVariableDataInINIFilepropCount++;
                    }

                    replaceVariableDataInINIFilepropCount++;
                }
                else
                {
                    replaceVariableDataInINIFile["CreateNewFileIfNotExists"] = true;
                    replaceVariableDataInINIFilepropCount++;
                }

                if (replaceVariableDataInINIFilewriteSpaceBeforeEquals != null)
                {
                    if (replaceVariableDataInINIFilewriteSpaceBeforeEquals != null)
                    {
                        replaceVariableDataInINIFile["WriteSpaceBeforeEquals"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFilewriteSpaceBeforeEquals);
                        replaceVariableDataInINIFilepropCount++;
                    }

                    replaceVariableDataInINIFilepropCount++;
                }
                else
                {
                    replaceVariableDataInINIFile["WriteSpaceBeforeEquals"] = true;
                    replaceVariableDataInINIFilepropCount++;
                }

                if (replaceVariableDataInINIFilewriteSpaceAfterEquals != null)
                {
                    if (replaceVariableDataInINIFilewriteSpaceAfterEquals != null)
                    {
                        replaceVariableDataInINIFile["WriteSpaceAfterEquals"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFilewriteSpaceAfterEquals);
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
                replaceVariableDataInINIFile["Workflow"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFileworkflow);
                if (replaceVariableDataInINIFilepropCount > 0)
                {
                    callPayload.Body = replaceVariableDataInINIFile;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadHTTPFile))]
        public IBodyWorkflowAction<DownloadHTTPFileResponse> DownloadHTTPFile([WorkflowExpression] Func<string> downloadHTTPFiledownloadURL, [WorkflowExpression] Func<string> downloadHTTPFileworkflow, [WorkflowExpression] Func<string> downloadHTTPFilesaveFilename = null, [WorkflowExpression] Func<bool> downloadHTTPFileoverwriteExistingFile = null, [WorkflowExpression] Func<bool> downloadHTTPFilepassthroughAuthentication = null, [WorkflowExpression] Func<string> downloadHTTPFileuserAgent = null, [WorkflowExpression] Func<string> downloadHTTPFileaccept = null, [WorkflowExpression] Func<bool> downloadHTTPFilesupportTLS10 = null, [WorkflowExpression] Func<bool> downloadHTTPFilesupportTLS11 = null, [WorkflowExpression] Func<bool> downloadHTTPFilesupportTLS12 = null, [WorkflowExpression] Func<bool> downloadHTTPFileautoDecompressDeflate = null, [WorkflowExpression] Func<bool> downloadHTTPFileautoDecompressGZIP = null, [WorkflowExpression] Func<bool> downloadHTTPFilereturnContentsAsString = null, [WorkflowExpression] Func<downloadHTTPFilereturnContentEncodingInput> downloadHTTPFilereturnContentEncoding = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DownloadHTTPFileResponse> __BuildDownloadHTTPFile(WorkflowValue<string> downloadHTTPFiledownloadURL, WorkflowValue<string> downloadHTTPFileworkflow, WorkflowValue<string> downloadHTTPFilesaveFilename = null, WorkflowValue<bool> downloadHTTPFileoverwriteExistingFile = null, WorkflowValue<bool> downloadHTTPFilepassthroughAuthentication = null, WorkflowValue<string> downloadHTTPFileuserAgent = null, WorkflowValue<string> downloadHTTPFileaccept = null, WorkflowValue<bool> downloadHTTPFilesupportTLS10 = null, WorkflowValue<bool> downloadHTTPFilesupportTLS11 = null, WorkflowValue<bool> downloadHTTPFilesupportTLS12 = null, WorkflowValue<bool> downloadHTTPFileautoDecompressDeflate = null, WorkflowValue<bool> downloadHTTPFileautoDecompressGZIP = null, WorkflowValue<bool> downloadHTTPFilereturnContentsAsString = null, WorkflowValue<downloadHTTPFilereturnContentEncodingInput> downloadHTTPFilereturnContentEncoding = null)
        {
            WorkflowValue.Validate(downloadHTTPFiledownloadURL, nameof(downloadHTTPFiledownloadURL), required: true);
            WorkflowValue.Validate(downloadHTTPFileworkflow, nameof(downloadHTTPFileworkflow), required: true);
            WorkflowValue.Validate(downloadHTTPFilesaveFilename, nameof(downloadHTTPFilesaveFilename), required: false);
            WorkflowValue.Validate(downloadHTTPFileoverwriteExistingFile, nameof(downloadHTTPFileoverwriteExistingFile), required: false);
            WorkflowValue.Validate(downloadHTTPFilepassthroughAuthentication, nameof(downloadHTTPFilepassthroughAuthentication), required: false);
            WorkflowValue.Validate(downloadHTTPFileuserAgent, nameof(downloadHTTPFileuserAgent), required: false);
            WorkflowValue.Validate(downloadHTTPFileaccept, nameof(downloadHTTPFileaccept), required: false);
            WorkflowValue.Validate(downloadHTTPFilesupportTLS10, nameof(downloadHTTPFilesupportTLS10), required: false);
            WorkflowValue.Validate(downloadHTTPFilesupportTLS11, nameof(downloadHTTPFilesupportTLS11), required: false);
            WorkflowValue.Validate(downloadHTTPFilesupportTLS12, nameof(downloadHTTPFilesupportTLS12), required: false);
            WorkflowValue.Validate(downloadHTTPFileautoDecompressDeflate, nameof(downloadHTTPFileautoDecompressDeflate), required: false);
            WorkflowValue.Validate(downloadHTTPFileautoDecompressGZIP, nameof(downloadHTTPFileautoDecompressGZIP), required: false);
            WorkflowValue.Validate(downloadHTTPFilereturnContentsAsString, nameof(downloadHTTPFilereturnContentsAsString), required: false);
            WorkflowValue.Validate(downloadHTTPFilereturnContentEncoding, nameof(downloadHTTPFilereturnContentEncoding), required: false);
            return new DeferredBodyAction<DownloadHTTPFileResponse>(() =>
            {
                var apiCallPath = "/FileManagement/DownloadHTTPFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var downloadHTTPFile = new JObject();
                var downloadHTTPFilepropCount = 0;
                downloadHTTPFilepropCount++;
                downloadHTTPFile["DownloadURL"] = ExpressionConverter.ConvertO(downloadHTTPFiledownloadURL);
                if (downloadHTTPFilesaveFilename != null)
                {
                    downloadHTTPFile["SaveFilename"] = ExpressionConverter.ConvertO(downloadHTTPFilesaveFilename);
                    downloadHTTPFilepropCount++;
                }

                if (downloadHTTPFileoverwriteExistingFile != null)
                {
                    if (downloadHTTPFileoverwriteExistingFile != null)
                    {
                        downloadHTTPFile["OverwriteExistingFile"] = ExpressionConverter.ConvertO(downloadHTTPFileoverwriteExistingFile);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["OverwriteExistingFile"] = true;
                    downloadHTTPFilepropCount++;
                }

                if (downloadHTTPFilepassthroughAuthentication != null)
                {
                    if (downloadHTTPFilepassthroughAuthentication != null)
                    {
                        downloadHTTPFile["PassthroughAuthentication"] = ExpressionConverter.ConvertO(downloadHTTPFilepassthroughAuthentication);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["PassthroughAuthentication"] = false;
                    downloadHTTPFilepropCount++;
                }

                if (downloadHTTPFileuserAgent != null)
                {
                    if (downloadHTTPFileuserAgent != null)
                    {
                        downloadHTTPFile["UserAgent"] = ExpressionConverter.ConvertO(downloadHTTPFileuserAgent);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["UserAgent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.193 Safari/537.36";
                    downloadHTTPFilepropCount++;
                }

                if (downloadHTTPFileaccept != null)
                {
                    if (downloadHTTPFileaccept != null)
                    {
                        downloadHTTPFile["Accept"] = ExpressionConverter.ConvertO(downloadHTTPFileaccept);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["Accept"] = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                    downloadHTTPFilepropCount++;
                }

                if (downloadHTTPFilesupportTLS10 != null)
                {
                    if (downloadHTTPFilesupportTLS10 != null)
                    {
                        downloadHTTPFile["SupportTLS10"] = ExpressionConverter.ConvertO(downloadHTTPFilesupportTLS10);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["SupportTLS10"] = true;
                    downloadHTTPFilepropCount++;
                }

                if (downloadHTTPFilesupportTLS11 != null)
                {
                    if (downloadHTTPFilesupportTLS11 != null)
                    {
                        downloadHTTPFile["SupportTLS11"] = ExpressionConverter.ConvertO(downloadHTTPFilesupportTLS11);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["SupportTLS11"] = true;
                    downloadHTTPFilepropCount++;
                }

                if (downloadHTTPFilesupportTLS12 != null)
                {
                    if (downloadHTTPFilesupportTLS12 != null)
                    {
                        downloadHTTPFile["SupportTLS12"] = ExpressionConverter.ConvertO(downloadHTTPFilesupportTLS12);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["SupportTLS12"] = true;
                    downloadHTTPFilepropCount++;
                }

                if (downloadHTTPFileautoDecompressDeflate != null)
                {
                    if (downloadHTTPFileautoDecompressDeflate != null)
                    {
                        downloadHTTPFile["AutoDecompressDeflate"] = ExpressionConverter.ConvertO(downloadHTTPFileautoDecompressDeflate);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["AutoDecompressDeflate"] = true;
                    downloadHTTPFilepropCount++;
                }

                if (downloadHTTPFileautoDecompressGZIP != null)
                {
                    if (downloadHTTPFileautoDecompressGZIP != null)
                    {
                        downloadHTTPFile["AutoDecompressGZIP"] = ExpressionConverter.ConvertO(downloadHTTPFileautoDecompressGZIP);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["AutoDecompressGZIP"] = true;
                    downloadHTTPFilepropCount++;
                }

                if (downloadHTTPFilereturnContentsAsString != null)
                {
                    if (downloadHTTPFilereturnContentsAsString != null)
                    {
                        downloadHTTPFile["ReturnContentsAsString"] = ExpressionConverter.ConvertO(downloadHTTPFilereturnContentsAsString);
                        downloadHTTPFilepropCount++;
                    }

                    downloadHTTPFilepropCount++;
                }
                else
                {
                    downloadHTTPFile["ReturnContentsAsString"] = false;
                    downloadHTTPFilepropCount++;
                }

                if (downloadHTTPFilereturnContentEncoding != null)
                {
                    if (downloadHTTPFilereturnContentEncoding != null)
                    {
                        downloadHTTPFile["ReturnContentEncoding"] = ExpressionConverter.ConvertO(downloadHTTPFilereturnContentEncoding);
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
                downloadHTTPFile["Workflow"] = ExpressionConverter.ConvertO(downloadHTTPFileworkflow);
                if (downloadHTTPFilepropCount > 0)
                {
                    callPayload.Body = downloadHTTPFile;
                }

                return new ApiConnectionAction<DownloadHTTPFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildUnZIPFile))]
        public IBodyWorkflowAction<UnZIPFileResponse> UnZIPFile([WorkflowExpression] Func<string> unZIPFilezIPFilename, [WorkflowExpression] Func<string> unZIPFileworkflow, [WorkflowExpression] Func<string> unZIPFileextractFolder = null, [WorkflowExpression] Func<bool> unZIPFileextractAllFilesToSingleFolder = null, [WorkflowExpression] Func<string> unZIPFileincludeFilesRegEx = null, [WorkflowExpression] Func<string> unZIPFileexcludeFilesRegEx = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UnZIPFileResponse> __BuildUnZIPFile(WorkflowValue<string> unZIPFilezIPFilename, WorkflowValue<string> unZIPFileworkflow, WorkflowValue<string> unZIPFileextractFolder = null, WorkflowValue<bool> unZIPFileextractAllFilesToSingleFolder = null, WorkflowValue<string> unZIPFileincludeFilesRegEx = null, WorkflowValue<string> unZIPFileexcludeFilesRegEx = null)
        {
            WorkflowValue.Validate(unZIPFilezIPFilename, nameof(unZIPFilezIPFilename), required: true);
            WorkflowValue.Validate(unZIPFileworkflow, nameof(unZIPFileworkflow), required: true);
            WorkflowValue.Validate(unZIPFileextractFolder, nameof(unZIPFileextractFolder), required: false);
            WorkflowValue.Validate(unZIPFileextractAllFilesToSingleFolder, nameof(unZIPFileextractAllFilesToSingleFolder), required: false);
            WorkflowValue.Validate(unZIPFileincludeFilesRegEx, nameof(unZIPFileincludeFilesRegEx), required: false);
            WorkflowValue.Validate(unZIPFileexcludeFilesRegEx, nameof(unZIPFileexcludeFilesRegEx), required: false);
            return new DeferredBodyAction<UnZIPFileResponse>(() =>
            {
                var apiCallPath = "/FileManagement/UnZIPFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var unZIPFile = new JObject();
                var unZIPFilepropCount = 0;
                unZIPFilepropCount++;
                unZIPFile["ZIPFilename"] = ExpressionConverter.ConvertO(unZIPFilezIPFilename);
                if (unZIPFileextractFolder != null)
                {
                    unZIPFile["ExtractFolder"] = ExpressionConverter.ConvertO(unZIPFileextractFolder);
                    unZIPFilepropCount++;
                }

                if (unZIPFileextractAllFilesToSingleFolder != null)
                {
                    if (unZIPFileextractAllFilesToSingleFolder != null)
                    {
                        unZIPFile["ExtractAllFilesToSingleFolder"] = ExpressionConverter.ConvertO(unZIPFileextractAllFilesToSingleFolder);
                        unZIPFilepropCount++;
                    }

                    unZIPFilepropCount++;
                }
                else
                {
                    unZIPFile["ExtractAllFilesToSingleFolder"] = false;
                    unZIPFilepropCount++;
                }

                if (unZIPFileincludeFilesRegEx != null)
                {
                    unZIPFile["IncludeFilesRegEx"] = ExpressionConverter.ConvertO(unZIPFileincludeFilesRegEx);
                    unZIPFilepropCount++;
                }

                if (unZIPFileexcludeFilesRegEx != null)
                {
                    unZIPFile["ExcludeFilesRegEx"] = ExpressionConverter.ConvertO(unZIPFileexcludeFilesRegEx);
                    unZIPFilepropCount++;
                }

                unZIPFilepropCount++;
                unZIPFile["Workflow"] = ExpressionConverter.ConvertO(unZIPFileworkflow);
                if (unZIPFilepropCount > 0)
                {
                    callPayload.Body = unZIPFile;
                }

                return new ApiConnectionAction<UnZIPFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildAddFileToZIP))]
        public IWorkflowAction AddFileToZIP([WorkflowExpression] Func<string> addFileToZIPsourceFilenameToAddToZIP, [WorkflowExpression] Func<string> addFileToZIPoutputZIPFilename, [WorkflowExpression] Func<string> addFileToZIPworkflow, [WorkflowExpression] Func<string> addFileToZIPaddFilenameToFolderInZIP = null, [WorkflowExpression] Func<string> addFileToZIPsourceFilenameToAddToZIPComment = null, [WorkflowExpression] Func<bool> addFileToZIPcompress = null, [WorkflowExpression] Func<bool> addFileToZIPaddToExistingZIPFile = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddFileToZIP(WorkflowValue<string> addFileToZIPsourceFilenameToAddToZIP, WorkflowValue<string> addFileToZIPoutputZIPFilename, WorkflowValue<string> addFileToZIPworkflow, WorkflowValue<string> addFileToZIPaddFilenameToFolderInZIP = null, WorkflowValue<string> addFileToZIPsourceFilenameToAddToZIPComment = null, WorkflowValue<bool> addFileToZIPcompress = null, WorkflowValue<bool> addFileToZIPaddToExistingZIPFile = null)
        {
            WorkflowValue.Validate(addFileToZIPsourceFilenameToAddToZIP, nameof(addFileToZIPsourceFilenameToAddToZIP), required: true);
            WorkflowValue.Validate(addFileToZIPoutputZIPFilename, nameof(addFileToZIPoutputZIPFilename), required: true);
            WorkflowValue.Validate(addFileToZIPworkflow, nameof(addFileToZIPworkflow), required: true);
            WorkflowValue.Validate(addFileToZIPaddFilenameToFolderInZIP, nameof(addFileToZIPaddFilenameToFolderInZIP), required: false);
            WorkflowValue.Validate(addFileToZIPsourceFilenameToAddToZIPComment, nameof(addFileToZIPsourceFilenameToAddToZIPComment), required: false);
            WorkflowValue.Validate(addFileToZIPcompress, nameof(addFileToZIPcompress), required: false);
            WorkflowValue.Validate(addFileToZIPaddToExistingZIPFile, nameof(addFileToZIPaddToExistingZIPFile), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FileManagement/AddFileToZIP";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addFileToZIP = new JObject();
                var addFileToZIPpropCount = 0;
                addFileToZIPpropCount++;
                addFileToZIP["SourceFilenameToAddToZIP"] = ExpressionConverter.ConvertO(addFileToZIPsourceFilenameToAddToZIP);
                addFileToZIPpropCount++;
                addFileToZIP["OutputZIPFilename"] = ExpressionConverter.ConvertO(addFileToZIPoutputZIPFilename);
                if (addFileToZIPaddFilenameToFolderInZIP != null)
                {
                    addFileToZIP["AddFilenameToFolderInZIP"] = ExpressionConverter.ConvertO(addFileToZIPaddFilenameToFolderInZIP);
                    addFileToZIPpropCount++;
                }

                if (addFileToZIPsourceFilenameToAddToZIPComment != null)
                {
                    addFileToZIP["SourceFilenameToAddToZIPComment"] = ExpressionConverter.ConvertO(addFileToZIPsourceFilenameToAddToZIPComment);
                    addFileToZIPpropCount++;
                }

                if (addFileToZIPcompress != null)
                {
                    if (addFileToZIPcompress != null)
                    {
                        addFileToZIP["Compress"] = ExpressionConverter.ConvertO(addFileToZIPcompress);
                        addFileToZIPpropCount++;
                    }

                    addFileToZIPpropCount++;
                }
                else
                {
                    addFileToZIP["Compress"] = true;
                    addFileToZIPpropCount++;
                }

                if (addFileToZIPaddToExistingZIPFile != null)
                {
                    if (addFileToZIPaddToExistingZIPFile != null)
                    {
                        addFileToZIP["AddToExistingZIPFile"] = ExpressionConverter.ConvertO(addFileToZIPaddToExistingZIPFile);
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
                addFileToZIP["Workflow"] = ExpressionConverter.ConvertO(addFileToZIPworkflow);
                if (addFileToZIPpropCount > 0)
                {
                    callPayload.Body = addFileToZIP;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildAddFolderToZIP))]
        public IBodyWorkflowAction<AddFolderToZIPResponse> AddFolderToZIP([WorkflowExpression] Func<string> addFolderToZIPsourceFolderToAddToZIP, [WorkflowExpression] Func<string> addFolderToZIPoutputZIPFilename, [WorkflowExpression] Func<string> addFolderToZIPworkflow, [WorkflowExpression] Func<string> addFolderToZIPaddFilesToFolderInZIP = null, [WorkflowExpression] Func<bool> addFolderToZIPcompress = null, [WorkflowExpression] Func<bool> addFolderToZIPaddToExistingZIPFile = null, [WorkflowExpression] Func<bool> addFolderToZIPincludeSubfolders = null, [WorkflowExpression] Func<string> addFolderToZIPincludeFilesRegEx = null, [WorkflowExpression] Func<string> addFolderToZIPexcludeFilesRegEx = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddFolderToZIPResponse> __BuildAddFolderToZIP(WorkflowValue<string> addFolderToZIPsourceFolderToAddToZIP, WorkflowValue<string> addFolderToZIPoutputZIPFilename, WorkflowValue<string> addFolderToZIPworkflow, WorkflowValue<string> addFolderToZIPaddFilesToFolderInZIP = null, WorkflowValue<bool> addFolderToZIPcompress = null, WorkflowValue<bool> addFolderToZIPaddToExistingZIPFile = null, WorkflowValue<bool> addFolderToZIPincludeSubfolders = null, WorkflowValue<string> addFolderToZIPincludeFilesRegEx = null, WorkflowValue<string> addFolderToZIPexcludeFilesRegEx = null)
        {
            WorkflowValue.Validate(addFolderToZIPsourceFolderToAddToZIP, nameof(addFolderToZIPsourceFolderToAddToZIP), required: true);
            WorkflowValue.Validate(addFolderToZIPoutputZIPFilename, nameof(addFolderToZIPoutputZIPFilename), required: true);
            WorkflowValue.Validate(addFolderToZIPworkflow, nameof(addFolderToZIPworkflow), required: true);
            WorkflowValue.Validate(addFolderToZIPaddFilesToFolderInZIP, nameof(addFolderToZIPaddFilesToFolderInZIP), required: false);
            WorkflowValue.Validate(addFolderToZIPcompress, nameof(addFolderToZIPcompress), required: false);
            WorkflowValue.Validate(addFolderToZIPaddToExistingZIPFile, nameof(addFolderToZIPaddToExistingZIPFile), required: false);
            WorkflowValue.Validate(addFolderToZIPincludeSubfolders, nameof(addFolderToZIPincludeSubfolders), required: false);
            WorkflowValue.Validate(addFolderToZIPincludeFilesRegEx, nameof(addFolderToZIPincludeFilesRegEx), required: false);
            WorkflowValue.Validate(addFolderToZIPexcludeFilesRegEx, nameof(addFolderToZIPexcludeFilesRegEx), required: false);
            return new DeferredBodyAction<AddFolderToZIPResponse>(() =>
            {
                var apiCallPath = "/FileManagement/AddFolderToZIP";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addFolderToZIP = new JObject();
                var addFolderToZIPpropCount = 0;
                addFolderToZIPpropCount++;
                addFolderToZIP["SourceFolderToAddToZIP"] = ExpressionConverter.ConvertO(addFolderToZIPsourceFolderToAddToZIP);
                addFolderToZIPpropCount++;
                addFolderToZIP["OutputZIPFilename"] = ExpressionConverter.ConvertO(addFolderToZIPoutputZIPFilename);
                if (addFolderToZIPaddFilesToFolderInZIP != null)
                {
                    addFolderToZIP["AddFilesToFolderInZIP"] = ExpressionConverter.ConvertO(addFolderToZIPaddFilesToFolderInZIP);
                    addFolderToZIPpropCount++;
                }

                if (addFolderToZIPcompress != null)
                {
                    if (addFolderToZIPcompress != null)
                    {
                        addFolderToZIP["Compress"] = ExpressionConverter.ConvertO(addFolderToZIPcompress);
                        addFolderToZIPpropCount++;
                    }

                    addFolderToZIPpropCount++;
                }
                else
                {
                    addFolderToZIP["Compress"] = true;
                    addFolderToZIPpropCount++;
                }

                if (addFolderToZIPaddToExistingZIPFile != null)
                {
                    if (addFolderToZIPaddToExistingZIPFile != null)
                    {
                        addFolderToZIP["AddToExistingZIPFile"] = ExpressionConverter.ConvertO(addFolderToZIPaddToExistingZIPFile);
                        addFolderToZIPpropCount++;
                    }

                    addFolderToZIPpropCount++;
                }
                else
                {
                    addFolderToZIP["AddToExistingZIPFile"] = false;
                    addFolderToZIPpropCount++;
                }

                if (addFolderToZIPincludeSubfolders != null)
                {
                    if (addFolderToZIPincludeSubfolders != null)
                    {
                        addFolderToZIP["IncludeSubfolders"] = ExpressionConverter.ConvertO(addFolderToZIPincludeSubfolders);
                        addFolderToZIPpropCount++;
                    }

                    addFolderToZIPpropCount++;
                }
                else
                {
                    addFolderToZIP["IncludeSubfolders"] = true;
                    addFolderToZIPpropCount++;
                }

                if (addFolderToZIPincludeFilesRegEx != null)
                {
                    addFolderToZIP["IncludeFilesRegEx"] = ExpressionConverter.ConvertO(addFolderToZIPincludeFilesRegEx);
                    addFolderToZIPpropCount++;
                }

                if (addFolderToZIPexcludeFilesRegEx != null)
                {
                    addFolderToZIP["ExcludeFilesRegEx"] = ExpressionConverter.ConvertO(addFolderToZIPexcludeFilesRegEx);
                    addFolderToZIPpropCount++;
                }

                addFolderToZIPpropCount++;
                addFolderToZIP["Workflow"] = ExpressionConverter.ConvertO(addFolderToZIPworkflow);
                if (addFolderToZIPpropCount > 0)
                {
                    callPayload.Body = addFolderToZIP;
                }

                return new ApiConnectionAction<AddFolderToZIPResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContentsAsBase64))]
        public IBodyWorkflowAction<GetFileContentsAsBase64Response> GetFileContentsAsBase64([WorkflowExpression] Func<string> getFileContentsAsBase64filePath, [WorkflowExpression] Func<string> getFileContentsAsBase64workflow, [WorkflowExpression] Func<bool> getFileContentsAsBase64compress = null, [WorkflowExpression] Func<int> getFileContentsAsBase64maxFileSize = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFileContentsAsBase64Response> __BuildGetFileContentsAsBase64(WorkflowValue<string> getFileContentsAsBase64filePath, WorkflowValue<string> getFileContentsAsBase64workflow, WorkflowValue<bool> getFileContentsAsBase64compress = null, WorkflowValue<int> getFileContentsAsBase64maxFileSize = null)
        {
            WorkflowValue.Validate(getFileContentsAsBase64filePath, nameof(getFileContentsAsBase64filePath), required: true);
            WorkflowValue.Validate(getFileContentsAsBase64workflow, nameof(getFileContentsAsBase64workflow), required: true);
            WorkflowValue.Validate(getFileContentsAsBase64compress, nameof(getFileContentsAsBase64compress), required: false);
            WorkflowValue.Validate(getFileContentsAsBase64maxFileSize, nameof(getFileContentsAsBase64maxFileSize), required: false);
            return new DeferredBodyAction<GetFileContentsAsBase64Response>(() =>
            {
                var apiCallPath = "/FileManagement/GetFileContentsAsBase64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getFileContentsAsBase64 = new JObject();
                var getFileContentsAsBase64propCount = 0;
                getFileContentsAsBase64propCount++;
                getFileContentsAsBase64["FilePath"] = ExpressionConverter.ConvertO(getFileContentsAsBase64filePath);
                if (getFileContentsAsBase64compress != null)
                {
                    if (getFileContentsAsBase64compress != null)
                    {
                        getFileContentsAsBase64["Compress"] = ExpressionConverter.ConvertO(getFileContentsAsBase64compress);
                        getFileContentsAsBase64propCount++;
                    }

                    getFileContentsAsBase64propCount++;
                }
                else
                {
                    getFileContentsAsBase64["Compress"] = false;
                    getFileContentsAsBase64propCount++;
                }

                if (getFileContentsAsBase64maxFileSize != null)
                {
                    if (getFileContentsAsBase64maxFileSize != null)
                    {
                        getFileContentsAsBase64["MaxFileSize"] = ExpressionConverter.ConvertO(getFileContentsAsBase64maxFileSize);
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
                getFileContentsAsBase64["Workflow"] = ExpressionConverter.ConvertO(getFileContentsAsBase64workflow);
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

    public enum runProcessstandardOutputEncodingInput
    {
        UTF8,
        UTF7,
        UTF16,
        ASCII,
        UTF16BE
    }

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

    public enum runPowerShellProcessstandardOutputEncodingInput
    {
        UTF8,
        UTF7,
        UTF16,
        ASCII,
        UTF16BE
    }

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

    public enum credentialWritecredentialTypeInput
    {
        Windows,
        Generic
    }

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

    public enum credentialDeletecredentialTypeInput
    {
        Windows,
        Generic
    }

    public class GenerateRDPFileResponse
    {
        public string RDPFilePath { get; set; }
    }

    public enum generateRDPFilecredentialTypeInput
    {
        Windows,
        Generic
    }

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

    public enum setAgentGlobalCoordinateConfigurationmultiMonitorFunctionalityInput
    {
        NotSet,
        [EnumMember(Value = "PrimaryMonitor")]
        PrimaryDisplayOnly,
        [EnumMember(Value = "MultiMonitor")]
        AllDisplays
    }

    public enum setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplierInput
    {
        [EnumMember(Value = "Auto")]
        Automatic,
        Manual,
        NotSet
    }

    public enum setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplierInput
    {
        [EnumMember(Value = "Auto")]
        Automatic,
        Manual,
        NotSet
    }

    public enum setAgentGlobalCoordinateConfigurationjavaCoordinateSystemInput
    {
        NotSet,
        Virtual,
        Physical
    }

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

    public enum writeCollectionToCSVFileoutputEncodingInput
    {
        UTF8,
        UTF7,
        Unicode,
        ASCII
    }

    public enum addPermissionToFolderpermissionInput
    {
        Read,
        ReadAndExecute,
        Modify,
        FullControl
    }

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
