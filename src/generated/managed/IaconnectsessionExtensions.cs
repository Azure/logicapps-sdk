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
        public IBodyWorkflowAction<GetMachineNameResponse> GetMachineName([WorkflowExpression] Func<string> getMachineNameworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMachineDomainResponse> GetMachineDomain([WorkflowExpression] Func<string> getMachineDomainworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteSessionClientHostnameResponse> GetRemoteSessionClientHostname([WorkflowExpression] Func<string> getRemoteSessionClientHostnameworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ExpandEnvironmentVariableResponse> ExpandEnvironmentVariable([WorkflowExpression] Func<string> expandEnvironmentVariableinputString, [WorkflowExpression] Func<string> expandEnvironmentVariableworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillProcessResponse> KillProcess([WorkflowExpression] Func<string> killProcessprocessName, [WorkflowExpression] Func<string> killProcessworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillProcessIDResponse> KillProcessID([WorkflowExpression] Func<int> killProcessIDprocessID, [WorkflowExpression] Func<string> killProcessIDworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessCountByNameResponse> GetProcessCountByName([WorkflowExpression] Func<string> getProcessCountByNameprocessName, [WorkflowExpression] Func<string> getProcessCountByNameworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentProcessCountResponse> GetAgentProcessCount([WorkflowExpression] Func<string> getAgentProcessCountworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillAllOtherAgentsResponse> KillAllOtherAgents([WorkflowExpression] Func<string> killAllOtherAgentsworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessByPIDResponse> GetProcessByPID([WorkflowExpression] Func<int> getProcessByPIDprocessId, [WorkflowExpression] Func<string> getProcessByPIDworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessesResponse> GetProcesses([WorkflowExpression] Func<string> getProcessesworkflow, [WorkflowExpression] Func<string> getProcessesprocessName = null, [WorkflowExpression] Func<bool> getProcessesgetProcessCommandLine = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunProcessResponse> RunProcess([WorkflowExpression] Func<string> runProcessprocessName, [WorkflowExpression] Func<string> runProcessworkflow, [WorkflowExpression] Func<string> runProcessarguments = null, [WorkflowExpression] Func<string> runProcessworkingDirectory = null, [WorkflowExpression] Func<bool> runProcessuseShellExecute = null, [WorkflowExpression] Func<bool> runProcesscreateNoWindow = null, [WorkflowExpression] Func<runProcesswindowStyleInput> runProcesswindowStyle = null, [WorkflowExpression] Func<bool> runProcesswaitForProcess = null, [WorkflowExpression] Func<bool> runProcessredirectStandardOutput = null, [WorkflowExpression] Func<bool> runProcessredirectStandardError = null, [WorkflowExpression] Func<bool> runProcessredirectStandardErrorToOutput = null, [WorkflowExpression] Func<runProcessstandardOutputEncodingInput> runProcessstandardOutputEncoding = null, [WorkflowExpression] Func<runProcessstandardErrorEncodingInput> runProcessstandardErrorEncoding = null, [WorkflowExpression] Func<string> runProcessrunAsDomain = null, [WorkflowExpression] Func<string> runProcessrunAsUsername = null, [WorkflowExpression] Func<string> runProcessrunAsPassword = null, [WorkflowExpression] Func<bool> runProcessrunAsLoadUserProfile = null, [WorkflowExpression] Func<bool> runProcessrunAsElevate = null, [WorkflowExpression] Func<int> runProcesstimeoutInSeconds = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunPowerShellProcessResponse> RunPowerShellProcess([WorkflowExpression] Func<string> runPowerShellProcessworkflow, [WorkflowExpression] Func<string> runPowerShellProcesspowerShellExecutable = null, [WorkflowExpression] Func<string> runPowerShellProcesspowerShellScriptFilePath = null, [WorkflowExpression] Func<string> runPowerShellProcesspowerShellScriptContents = null, [WorkflowExpression] Func<string> runPowerShellProcessworkingDirectory = null, [WorkflowExpression] Func<bool> runPowerShellProcesscreateNoWindow = null, [WorkflowExpression] Func<runPowerShellProcesswindowStyleInput> runPowerShellProcesswindowStyle = null, [WorkflowExpression] Func<bool> runPowerShellProcesswaitForProcess = null, [WorkflowExpression] Func<bool> runPowerShellProcessredirectStandardOutput = null, [WorkflowExpression] Func<bool> runPowerShellProcessredirectStandardError = null, [WorkflowExpression] Func<bool> runPowerShellProcessredirectStandardErrorToOutput = null, [WorkflowExpression] Func<runPowerShellProcessstandardOutputEncodingInput> runPowerShellProcessstandardOutputEncoding = null, [WorkflowExpression] Func<runPowerShellProcessstandardErrorEncodingInput> runPowerShellProcessstandardErrorEncoding = null, [WorkflowExpression] Func<string> runPowerShellProcessrunAsDomain = null, [WorkflowExpression] Func<string> runPowerShellProcessrunAsUsername = null, [WorkflowExpression] Func<string> runPowerShellProcessrunAsPassword = null, [WorkflowExpression] Func<bool> runPowerShellProcessrunAsLoadUserProfile = null, [WorkflowExpression] Func<bool> runPowerShellProcessrunAsElevate = null, [WorkflowExpression] Func<int> runPowerShellProcesstimeoutInSeconds = null, [WorkflowExpression] Func<string> runPowerShellProcesspowerShellScriptTempFolder = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetScreenResolutionResponse> GetScreenResolution([WorkflowExpression] Func<string> getScreenResolutionworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetDefaultPrinter([WorkflowExpression] Func<string> setDefaultPrinterdefaultPrinterName, [WorkflowExpression] Func<string> setDefaultPrinterworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDefaultPrinterResponse> GetDefaultPrinter([WorkflowExpression] Func<string> getDefaultPrinterworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfPrintersResponse> GetListOfPrinters([WorkflowExpression] Func<string> getListOfPrintersworkflow, [WorkflowExpression] Func<bool> getListOfPrinterslistLocalPrinters = null, [WorkflowExpression] Func<bool> getListOfPrinterslistNetworkPrinters = null, [WorkflowExpression] Func<bool> getListOfPrintersreturnDetailedInformation = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetMouseMultiplier([WorkflowExpression] Func<string> setMouseMultiplierworkflow, [WorkflowExpression] Func<double> setMouseMultipliermouseXMultiplier = null, [WorkflowExpression] Func<double> setMouseMultipliermouseYMultiplier = null, [WorkflowExpression] Func<bool> setMouseMultiplierapplyToMouseEvent = null, [WorkflowExpression] Func<bool> setMouseMultiplierapplyToSetCursorPos = null, [WorkflowExpression] Func<bool> setMouseMultiplierapplyToCurrentMouseMoveMethod = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMouseMultiplierResponse> GetMouseMultiplier([WorkflowExpression] Func<string> getMouseMultiplierworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseToCoordinate([WorkflowExpression] Func<int> moveMouseToCoordinatexCoord, [WorkflowExpression] Func<int> moveMouseToCoordinateyCoord, [WorkflowExpression] Func<string> moveMouseToCoordinateworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseRelative([WorkflowExpression] Func<int> moveMouseRelativexCoord, [WorkflowExpression] Func<int> moveMouseRelativeyCoord, [WorkflowExpression] Func<string> moveMouseRelativeworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseButtonDown([WorkflowExpression] Func<string> leftMouseButtonDownworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseButtonUp([WorkflowExpression] Func<string> leftMouseButtonUpworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftClickMouse([WorkflowExpression] Func<string> leftClickMouseworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftClickMouseAtCoordinate([WorkflowExpression] Func<int> leftClickMouseAtCoordinatexCoord, [WorkflowExpression] Func<int> leftClickMouseAtCoordinateyCoord, [WorkflowExpression] Func<string> leftClickMouseAtCoordinateworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftHoldMouse([WorkflowExpression] Func<double> leftHoldMousesecondsToHold, [WorkflowExpression] Func<string> leftHoldMouseworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftHoldMouseAtCoordinate([WorkflowExpression] Func<int> leftHoldMouseAtCoordinatexCoord, [WorkflowExpression] Func<int> leftHoldMouseAtCoordinateyCoord, [WorkflowExpression] Func<double> leftHoldMouseAtCoordinatesecondsToHold, [WorkflowExpression] Func<string> leftHoldMouseAtCoordinateworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseButtonDown([WorkflowExpression] Func<string> rightMouseButtonDownworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseButtonUp([WorkflowExpression] Func<string> rightMouseButtonUpworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightClickMouse([WorkflowExpression] Func<string> rightClickMouseworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightClickMouseAtCoordinate([WorkflowExpression] Func<int> rightClickMouseAtCoordinatexCoord, [WorkflowExpression] Func<int> rightClickMouseAtCoordinateyCoord, [WorkflowExpression] Func<string> rightClickMouseAtCoordinateworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightHoldMouse([WorkflowExpression] Func<double> rightHoldMousesecondsToHold, [WorkflowExpression] Func<string> rightHoldMouseworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightHoldMouseAtCoordinate([WorkflowExpression] Func<int> rightHoldMouseAtCoordinatexCoord, [WorkflowExpression] Func<int> rightHoldMouseAtCoordinateyCoord, [WorkflowExpression] Func<double> rightHoldMouseAtCoordinatesecondsToHold, [WorkflowExpression] Func<string> rightHoldMouseAtCoordinateworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseButtonDown([WorkflowExpression] Func<string> middleMouseButtonDownworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseButtonUp([WorkflowExpression] Func<string> middleMouseButtonUpworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleClickMouse([WorkflowExpression] Func<string> middleClickMouseworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleClickMouseAtCoordinate([WorkflowExpression] Func<int> middleClickMouseAtCoordinatexCoord, [WorkflowExpression] Func<int> middleClickMouseAtCoordinateyCoord, [WorkflowExpression] Func<string> middleClickMouseAtCoordinateworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleHoldMouse([WorkflowExpression] Func<double> middleHoldMousesecondsToHold, [WorkflowExpression] Func<string> middleHoldMouseworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleHoldMouseAtCoordinate([WorkflowExpression] Func<int> middleHoldMouseAtCoordinatexCoord, [WorkflowExpression] Func<int> middleHoldMouseAtCoordinateyCoord, [WorkflowExpression] Func<double> middleHoldMouseAtCoordinatesecondsToHold, [WorkflowExpression] Func<string> middleHoldMouseAtCoordinateworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DoubleLeftClickMouse([WorkflowExpression] Func<string> doubleLeftClickMouseworkflow, [WorkflowExpression] Func<int> doubleLeftClickMousedelayInMilliseconds = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DoubleLeftClickMouseAtCoordinate([WorkflowExpression] Func<int> doubleLeftClickMouseAtCoordinatexCoord, [WorkflowExpression] Func<int> doubleLeftClickMouseAtCoordinateyCoord, [WorkflowExpression] Func<string> doubleLeftClickMouseAtCoordinateworkflow, [WorkflowExpression] Func<int> doubleLeftClickMouseAtCoordinatedelayInMilliseconds = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseDragBetweenCoordinates([WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesstartXCoord, [WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesstartYCoord, [WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesendXCoord, [WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesendYCoord, [WorkflowExpression] Func<string> leftMouseDragBetweenCoordinatesworkflow, [WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesnumberOfSteps = null, [WorkflowExpression] Func<double> leftMouseDragBetweenCoordinatestotalTimeInSeconds = null, [WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, [WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, [WorkflowExpression] Func<int> leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseDragBetweenCoordinates([WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesstartXCoord, [WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesstartYCoord, [WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesendXCoord, [WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesendYCoord, [WorkflowExpression] Func<string> rightMouseDragBetweenCoordinatesworkflow, [WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesnumberOfSteps = null, [WorkflowExpression] Func<double> rightMouseDragBetweenCoordinatestotalTimeInSeconds = null, [WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, [WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, [WorkflowExpression] Func<int> rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseDragBetweenCoordinates([WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesstartXCoord, [WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesstartYCoord, [WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesendXCoord, [WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesendYCoord, [WorkflowExpression] Func<string> middleMouseDragBetweenCoordinatesworkflow, [WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesnumberOfSteps = null, [WorkflowExpression] Func<double> middleMouseDragBetweenCoordinatestotalTimeInSeconds = null, [WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, [WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, [WorkflowExpression] Func<int> middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseBetweenCoordinates([WorkflowExpression] Func<int> moveMouseBetweenCoordinatesstartXCoord, [WorkflowExpression] Func<int> moveMouseBetweenCoordinatesstartYCoord, [WorkflowExpression] Func<int> moveMouseBetweenCoordinatesendXCoord, [WorkflowExpression] Func<int> moveMouseBetweenCoordinatesendYCoord, [WorkflowExpression] Func<string> moveMouseBetweenCoordinatesworkflow, [WorkflowExpression] Func<int> moveMouseBetweenCoordinatesnumberOfSteps = null, [WorkflowExpression] Func<double> moveMouseBetweenCoordinatestotalTimeInSeconds = null, [WorkflowExpression] Func<int> moveMouseBetweenCoordinatesmaximumMovementPixelJitter = null, [WorkflowExpression] Func<int> moveMouseBetweenCoordinatesmaximumEndPixelJitter = null, [WorkflowExpression] Func<int> moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction TurnMouseWheel([WorkflowExpression] Func<int> turnMouseWheelwheelTurns, [WorkflowExpression] Func<string> turnMouseWheelworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetCursorPos([WorkflowExpression] Func<int> setCursorPosx, [WorkflowExpression] Func<int> setCursorPosy, [WorkflowExpression] Func<string> setCursorPosworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetCursorPosResponse> GetCursorPos([WorkflowExpression] Func<string> getCursorPosworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CalibrateMouseEventResponse> CalibrateMouseEvent([WorkflowExpression] Func<string> calibrateMouseEventworkflow, [WorkflowExpression] Func<int> calibrateMouseEventcalibrationSizeInPixels = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMouseMoveMethodResponse> GetMouseMoveMethod([WorkflowExpression] Func<string> getMouseMoveMethodworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetMouseMoveMethod([WorkflowExpression] Func<setMouseMoveMethodmouseMoveMethodInput> setMouseMoveMethodmouseMoveMethod, [WorkflowExpression] Func<string> setMouseMoveMethodworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WiggleMouse([WorkflowExpression] Func<string> wiggleMouseworkflow, [WorkflowExpression] Func<int> wiggleMousexWiggle = null, [WorkflowExpression] Func<int> wiggleMouseyWiggle = null, [WorkflowExpression] Func<double> wiggleMousewiggleDelayInSeconds = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendKeyEvents([WorkflowExpression] Func<string> sendKeyEventstext, [WorkflowExpression] Func<string> sendKeyEventsworkflow, [WorkflowExpression] Func<int> sendKeyEventsinterval = null, [WorkflowExpression] Func<bool> sendKeyEventsisPassword = null, [WorkflowExpression] Func<bool> sendKeyEventsdontInterpretSymbols = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendPasswordKeyEvents([WorkflowExpression] Func<string> sendPasswordKeyEventspassword, [WorkflowExpression] Func<string> sendPasswordKeyEventsworkflow, [WorkflowExpression] Func<int> sendPasswordKeyEventsinterval = null, [WorkflowExpression] Func<bool> sendPasswordKeyEventsdontInterpretSymbols = null, [WorkflowExpression] Func<bool> sendPasswordKeyEventspasswordContainsStoredPassword = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendKeys([WorkflowExpression] Func<string> sendKeystext, [WorkflowExpression] Func<string> sendKeysworkflow, [WorkflowExpression] Func<int> sendKeysinterval = null, [WorkflowExpression] Func<bool> sendKeysisPassword = null, [WorkflowExpression] Func<bool> sendKeysdontInterpretSymbols = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendPasswordKeys([WorkflowExpression] Func<string> sendPasswordKeyspassword, [WorkflowExpression] Func<string> sendPasswordKeysworkflow, [WorkflowExpression] Func<int> sendPasswordKeysinterval = null, [WorkflowExpression] Func<bool> sendPasswordKeysdontInterpretSymbols = null, [WorkflowExpression] Func<bool> sendPasswordKeyspasswordContainsStoredPassword = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ClearClipboard([WorkflowExpression] Func<string> clearClipboardworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetClipboardData([WorkflowExpression] Func<string> setClipboardDataworkflow, [WorkflowExpression] Func<string> setClipboardDatanewClipboardData = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetClipboardDataResponse> GetClipboardData([WorkflowExpression] Func<string> getClipboardDataworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TakeScreenshotResponse> TakeScreenshot([WorkflowExpression] Func<string> takeScreenshotworkflow, [WorkflowExpression] Func<bool> takeScreenshotfullscreen = null, [WorkflowExpression] Func<int> takeScreenshotleftXPixels = null, [WorkflowExpression] Func<int> takeScreenshottopYPixels = null, [WorkflowExpression] Func<int> takeScreenshotwidthPixels = null, [WorkflowExpression] Func<int> takeScreenshotheightPixels = null, [WorkflowExpression] Func<takeScreenshotimageFormatInput> takeScreenshotimageFormat = null, [WorkflowExpression] Func<bool> takeScreenshotuseDisplayDevice = null, [WorkflowExpression] Func<bool> takeScreenshotraiseExceptionOnError = null, [WorkflowExpression] Func<bool> takeScreenshothideAgent = null, [WorkflowExpression] Func<bool> takeScreenshotusePhysicalCoordinates = null, [WorkflowExpression] Func<int> takeScreenshotdisplayDeviceId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetEnvironmentInfoResponse> GetEnvironmentInfo([WorkflowExpression] Func<string> getEnvironmentInfoworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsScreenReaderEnabledResponse> IsScreenReaderEnabled([WorkflowExpression] Func<string> isScreenReaderEnabledworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetScreenReader([WorkflowExpression] Func<string> setScreenReaderworkflow, [WorkflowExpression] Func<bool> setScreenReaderenableScreenReader = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetParentProcessIdResponse> GetParentProcessId([WorkflowExpression] Func<int> getParentProcessIdprocessId, [WorkflowExpression] Func<string> getParentProcessIdworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessIdCommandLineResponse> GetProcessIdCommandLine([WorkflowExpression] Func<int> getProcessIdCommandLineprocessId, [WorkflowExpression] Func<string> getProcessIdCommandLineworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLastInputInfoResponse> GetLastInputInfo([WorkflowExpression] Func<string> getLastInputInfoworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KeepSessionAliveResponse> KeepSessionAlive([WorkflowExpression] Func<string> keepSessionAliveworkflow, [WorkflowExpression] Func<int> keepSessionAlivexWiggle = null, [WorkflowExpression] Func<int> keepSessionAliveyWiggle = null, [WorkflowExpression] Func<double> keepSessionAlivewiggleDelayInSeconds = null, [WorkflowExpression] Func<int> keepSessionAliveidleThresholdInSeconds = null, [WorkflowExpression] Func<int> keepSessionAliveidleCheckPeriodInSeconds = null, [WorkflowExpression] Func<int> keepSessionAlivetotalKeepaliveRuntimeInSeconds = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<StopKeepSessionAliveResponse> StopKeepSessionAlive([WorkflowExpression] Func<string> stopKeepSessionAliveworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CopyFileToClipboardResponse> CopyFileToClipboard([WorkflowExpression] Func<string> copyFileToClipboardfilepath, [WorkflowExpression] Func<string> copyFileToClipboardworkflow, [WorkflowExpression] Func<bool> copyFileToClipboardcut = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteSessionInfoResponse> GetRemoteSessionInfo([WorkflowExpression] Func<string> getRemoteSessionInfoworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GeneratePasswordResponse> GeneratePassword([WorkflowExpression] Func<string> generatePasswordpasswordFormat, [WorkflowExpression] Func<string> generatePasswordworkflow, [WorkflowExpression] Func<int> generatePasswordminimumLength = null, [WorkflowExpression] Func<bool> generatePasswordreturnAsPlainText = null, [WorkflowExpression] Func<string> generatePasswordstorePasswordAsIdentifier = null, [WorkflowExpression] Func<string> generatePasswordsupportedSymbols = null, [WorkflowExpression] Func<bool> generatePasswordattemptUniquePasswords = null, [WorkflowExpression] Func<generatePasswordgenerateAtInput> generatePasswordgenerateAt = null, [WorkflowExpression] Func<int> generatePasswordminimumLowercase = null, [WorkflowExpression] Func<int> generatePasswordminimumUppercase = null, [WorkflowExpression] Func<int> generatePasswordminimumNumbers = null, [WorkflowExpression] Func<int> generatePasswordminimumSymbols = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetStoredPasswordResponse> GetStoredPassword([WorkflowExpression] Func<string> getStoredPasswordworkflow, [WorkflowExpression] Func<string> getStoredPasswordpasswordIdentifier = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ExpandPasswordStringResponse> ExpandPasswordString([WorkflowExpression] Func<string> expandPasswordStringworkflow, [WorkflowExpression] Func<string> expandPasswordStringinputString = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<StorePasswordInAgentMemoryResponse> StorePasswordInAgentMemory([WorkflowExpression] Func<string> storePasswordInAgentMemoryidentifier, [WorkflowExpression] Func<string> storePasswordInAgentMemorypassword, [WorkflowExpression] Func<string> storePasswordInAgentMemoryworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeletePasswordInAgentMemoryResponse> DeletePasswordInAgentMemory([WorkflowExpression] Func<string> deletePasswordInAgentMemoryworkflow, [WorkflowExpression] Func<bool> deletePasswordInAgentMemorydeleteAllPasswords = null, [WorkflowExpression] Func<string> deletePasswordInAgentMemoryidentifier = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialWriteResponse> CredentialWrite([WorkflowExpression] Func<string> credentialWritecredentialAddress, [WorkflowExpression] Func<string> credentialWriteuserName, [WorkflowExpression] Func<string> credentialWritepassword, [WorkflowExpression] Func<credentialWritecredentialTypeInput> credentialWritecredentialType, [WorkflowExpression] Func<string> credentialWriteworkflow, [WorkflowExpression] Func<credentialWritecredentialPersistenceInput> credentialWritecredentialPersistence = null, [WorkflowExpression] Func<string> credentialWritesymmetricKey = null, [WorkflowExpression] Func<string> credentialWritestorePasswordAsIdentifier = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialReadResponse> CredentialRead([WorkflowExpression] Func<string> credentialReadcredentialAddress, [WorkflowExpression] Func<credentialReadcredentialTypeInput> credentialReadcredentialType, [WorkflowExpression] Func<string> credentialReadworkflow, [WorkflowExpression] Func<string> credentialReadsymmetricKey = null, [WorkflowExpression] Func<string> credentialReadstorePasswordAsIdentifier = null, [WorkflowExpression] Func<bool> credentialReaddontReturnPassword = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialDeleteResponse> CredentialDelete([WorkflowExpression] Func<string> credentialDeletecredentialAddress, [WorkflowExpression] Func<credentialDeletecredentialTypeInput> credentialDeletecredentialType, [WorkflowExpression] Func<string> credentialDeleteworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GenerateRDPFileResponse> GenerateRDPFile([WorkflowExpression] Func<string> generateRDPFileremoteAddress, [WorkflowExpression] Func<string> generateRDPFileoutputFolderPath, [WorkflowExpression] Func<string> generateRDPFilerDPFileName, [WorkflowExpression] Func<string> generateRDPFileworkflow, [WorkflowExpression] Func<bool> generateRDPFileoverwriteRDPFileIfAlreadyExists = null, [WorkflowExpression] Func<bool> generateRDPFiletrustRemoteComputer = null, [WorkflowExpression] Func<bool> generateRDPFilestoreCredentials = null, [WorkflowExpression] Func<string> generateRDPFileuserName = null, [WorkflowExpression] Func<string> generateRDPFilepassword = null, [WorkflowExpression] Func<generateRDPFilecredentialTypeInput> generateRDPFilecredentialType = null, [WorkflowExpression] Func<generateRDPFilecredentialPersistenceInput> generateRDPFilecredentialPersistence = null, [WorkflowExpression] Func<bool> generateRDPFileredirectPrinters = null, [WorkflowExpression] Func<bool> generateRDPFileredirectAllDrives = null, [WorkflowExpression] Func<bool> generateRDPFileredirectClipboard = null, [WorkflowExpression] Func<bool> generateRDPFilefullscreen = null, [WorkflowExpression] Func<int> generateRDPFiledesktopWidth = null, [WorkflowExpression] Func<int> generateRDPFiledesktopHeight = null, [WorkflowExpression] Func<bool> generateRDPFileuseMultiMonitor = null, [WorkflowExpression] Func<int> generateRDPFilesessionBPP = null, [WorkflowExpression] Func<bool> generateRDPFilesmartSizing = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<LaunchRemoteDesktopSessionResponse> LaunchRemoteDesktopSession([WorkflowExpression] Func<string> launchRemoteDesktopSessionrDPFilePath, [WorkflowExpression] Func<string> launchRemoteDesktopSessionworkflow, [WorkflowExpression] Func<bool> launchRemoteDesktopSessiontrustRemoteComputer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsTCPPortRespondingResponse> IsTCPPortResponding([WorkflowExpression] Func<string> isTCPPortRespondingremoteHost, [WorkflowExpression] Func<int> isTCPPortRespondingtCPPort, [WorkflowExpression] Func<string> isTCPPortRespondingworkflow, [WorkflowExpression] Func<int> isTCPPortRespondingtimeoutInSeconds = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UnlockSessionResponse> UnlockSession([WorkflowExpression] Func<string> unlockSessionunlockPassword, [WorkflowExpression] Func<bool> unlockSessiondetectIfLocked, [WorkflowExpression] Func<bool> unlockSessiondetectCredentialProvider, [WorkflowExpression] Func<string> unlockSessionworkflow, [WorkflowExpression] Func<bool> unlockSessionpasswordContainsStoredPassword = null, [WorkflowExpression] Func<int> unlockSessionsecondsToWaitForUnlock = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<LockSessionResponse> LockSession([WorkflowExpression] Func<string> lockSessionworkflow, [WorkflowExpression] Func<int> lockSessionlockAfterMinutesOfActionInactivity = null, [WorkflowExpression] Func<int> lockSessionsecondsToWaitAfterLock = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsSessionLockedResponse> IsSessionLocked([WorkflowExpression] Func<string> isSessionLockedworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetGenericCredentialFromOrchestratorResponse> GetGenericCredentialFromOrchestrator([WorkflowExpression] Func<string> getGenericCredentialFromOrchestratorfriendlyName = null, [WorkflowExpression] Func<bool> getGenericCredentialFromOrchestratorretrievePlainTextPassword = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DrawRectangleOnScreenResponse> DrawRectangleOnScreen([WorkflowExpression] Func<int> drawRectangleOnScreenrectangleLeftPixelXCoord, [WorkflowExpression] Func<int> drawRectangleOnScreenrectangleRightPixelXCoord, [WorkflowExpression] Func<int> drawRectangleOnScreenrectangleTopPixelYCoord, [WorkflowExpression] Func<int> drawRectangleOnScreenrectangleBottomPixelYCoord, [WorkflowExpression] Func<string> drawRectangleOnScreenworkflow, [WorkflowExpression] Func<string> drawRectangleOnScreenpenColour = null, [WorkflowExpression] Func<int> drawRectangleOnScreenpenThicknessPixels = null, [WorkflowExpression] Func<int> drawRectangleOnScreensecondsToDisplay = null, [WorkflowExpression] Func<bool> drawRectangleOnScreencoordinatesArePhysical = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFailedActionErrorMessageFromPowerAutomateResultJSONResponse> GetFailedActionErrorMessageFromPowerAutomateResultJSON([WorkflowExpression] Func<string[]> getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON, [WorkflowExpression] Func<string> getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetPixelColourAtCoordinateResponse> GetPixelColourAtCoordinate([WorkflowExpression] Func<int> getPixelColourAtCoordinateleftXPixels, [WorkflowExpression] Func<int> getPixelColourAtCoordinatetopYPixels, [WorkflowExpression] Func<string> getPixelColourAtCoordinateworkflow, [WorkflowExpression] Func<bool> getPixelColourAtCoordinatehideAgent = null, [WorkflowExpression] Func<bool> getPixelColourAtCoordinateusePhysicalCoordinates = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ConvertRectangleCoordinatesResponse> ConvertRectangleCoordinates([WorkflowExpression] Func<int> convertRectangleCoordinatesrectangleLeftPixelXCoord, [WorkflowExpression] Func<int> convertRectangleCoordinatesrectangleTopPixelYCoord, [WorkflowExpression] Func<int> convertRectangleCoordinatesrectangleRightPixelXCoord, [WorkflowExpression] Func<int> convertRectangleCoordinatesrectangleBottomPixelYCoord, [WorkflowExpression] Func<convertRectangleCoordinatesconversionTypeInput> convertRectangleCoordinatesconversionType, [WorkflowExpression] Func<string> convertRectangleCoordinatesworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SendMessageToWebAPIResponse> SendMessageToWebAPI([WorkflowExpression] Func<string> sendMessageToWebAPIworkflow, [WorkflowExpression] Func<string> sendMessageToWebAPIuRL = null, [WorkflowExpression] Func<sendMessageToWebAPImethodInput> sendMessageToWebAPImethod = null, [WorkflowExpression] Func<int> sendMessageToWebAPItimeoutInSeconds = null, [WorkflowExpression] Func<string> sendMessageToWebAPIcontentType = null, [WorkflowExpression] Func<string> sendMessageToWebAPIaccept = null, [WorkflowExpression] Func<string> sendMessageToWebAPImessageBody = null, [WorkflowExpression] Func<sendMessageToWebAPItransmitEncodingInput> sendMessageToWebAPItransmitEncoding = null, [WorkflowExpression] Func<sendMessageToWebAPIresponseEncodingInput> sendMessageToWebAPIresponseEncoding = null, [WorkflowExpression] Func<int> sendMessageToWebAPIbufferSize = null, [WorkflowExpression] Func<sendMessageToWebAPIhTTPRequestHeadersListInputItem[]> sendMessageToWebAPIhTTPRequestHeadersList = null, [WorkflowExpression] Func<bool> sendMessageToWebAPInegotiateTLS10 = null, [WorkflowExpression] Func<bool> sendMessageToWebAPInegotiateTLS11 = null, [WorkflowExpression] Func<bool> sendMessageToWebAPInegotiateTLS12 = null, [WorkflowExpression] Func<bool> sendMessageToWebAPInegotiateTLS13 = null, [WorkflowExpression] Func<bool> sendMessageToWebAPIkeepAlive = null, [WorkflowExpression] Func<bool> sendMessageToWebAPIexpect100Continue = null, [WorkflowExpression] Func<bool> sendMessageToWebAPIreturnResponseHeaders = null, [WorkflowExpression] Func<bool> sendMessageToWebAPIrunAsThread = null, [WorkflowExpression] Func<bool> sendMessageToWebAPIwaitForThread = null, [WorkflowExpression] Func<int> sendMessageToWebAPIretrieveOutputDataFromThreadId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewTaskResponse> TasksAddNewTask([WorkflowExpression] Func<string> tasksAddNewTaskworkflow, [WorkflowExpression] Func<tasksAddNewTasksetAutomationNameInput> tasksAddNewTasksetAutomationName = null, [WorkflowExpression] Func<string> tasksAddNewTaskautomationName = null, [WorkflowExpression] Func<string> tasksAddNewTasktaskInputData = null, [WorkflowExpression] Func<string> tasksAddNewTaskprocessStage = null, [WorkflowExpression] Func<int> tasksAddNewTaskpriority = null, [WorkflowExpression] Func<int> tasksAddNewTasksLA = null, [WorkflowExpression] Func<bool> tasksAddNewTasktaskOnHold = null, [WorkflowExpression] Func<string> tasksAddNewTaskorganisation = null, [WorkflowExpression] Func<string> tasksAddNewTaskdepartment = null, [WorkflowExpression] Func<string> tasksAddNewTaskdescription = null, [WorkflowExpression] Func<string> tasksAddNewTasktags = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewDeferralResponse> TasksAddNewDeferral([WorkflowExpression] Func<string> tasksAddNewDeferralworkflow, [WorkflowExpression] Func<tasksAddNewDeferralsetAutomationNameInput> tasksAddNewDeferralsetAutomationName = null, [WorkflowExpression] Func<string> tasksAddNewDeferralautomationName = null, [WorkflowExpression] Func<int> tasksAddNewDeferraldeferralTimeInMinutes = null, [WorkflowExpression] Func<string> tasksAddNewDeferraltaskInputData = null, [WorkflowExpression] Func<string> tasksAddNewDeferraldeferralStoredData = null, [WorkflowExpression] Func<string> tasksAddNewDeferralprocessStage = null, [WorkflowExpression] Func<int> tasksAddNewDeferralpriority = null, [WorkflowExpression] Func<bool> tasksAddNewDeferraltaskOnHold = null, [WorkflowExpression] Func<string> tasksAddNewDeferralorganisation = null, [WorkflowExpression] Func<string> tasksAddNewDeferraldepartment = null, [WorkflowExpression] Func<string> tasksAddNewDeferraldescription = null, [WorkflowExpression] Func<string> tasksAddNewDeferraltags = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeferExistingTaskResponse> TasksDeferExistingTask([WorkflowExpression] Func<int> tasksDeferExistingTasktaskId, [WorkflowExpression] Func<int> tasksDeferExistingTaskdeferralTimeInMinutes = null, [WorkflowExpression] Func<string> tasksDeferExistingTaskdeferralStoredData = null, [WorkflowExpression] Func<string> tasksDeferExistingTaskprocessStage = null, [WorkflowExpression] Func<int> tasksDeferExistingTaskpriority = null, [WorkflowExpression] Func<bool> tasksDeferExistingTasktaskOnHold = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeferExistingTaskOperationResponse> TasksDeferExistingTaskOperation([WorkflowExpression] Func<string> tasksDeferExistingTaskOperationoperationId, [WorkflowExpression] Func<int> tasksDeferExistingTaskOperationdeferralTimeInMinutes = null, [WorkflowExpression] Func<string> tasksDeferExistingTaskOperationdeferralStoredData = null, [WorkflowExpression] Func<string> tasksDeferExistingTaskOperationprocessStage = null, [WorkflowExpression] Func<int> tasksDeferExistingTaskOperationpriority = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeleteTaskResponse> TasksDeleteTask([WorkflowExpression] Func<int> tasksDeleteTasktaskId, [WorkflowExpression] Func<bool> tasksDeleteTaskupdateSourceSystem = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeleteTaskOperationResponse> TasksDeleteTaskOperation([WorkflowExpression] Func<string> tasksDeleteTaskOperationoperationId, [WorkflowExpression] Func<bool> tasksDeleteTaskOperationupdateSourceSystem = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetAllTasksResponse> TasksGetAllTasks([WorkflowExpression] Func<string> tasksGetAllTasksautomationName = null, [WorkflowExpression] Func<tasksGetAllTasksautomationTaskStatusInput> tasksGetAllTasksautomationTaskStatus = null, [WorkflowExpression] Func<string> tasksGetAllTasksfilterByPropertyQuery = null, [WorkflowExpression] Func<int> tasksGetAllTasksminutesUntilDeferralDate = null, [WorkflowExpression] Func<int> tasksGetAllTasksminimumPriorityLevel = null, [WorkflowExpression] Func<bool> tasksGetAllTaskssortByDeferralDate = null, [WorkflowExpression] Func<bool> tasksGetAllTasksretrieveOnHoldTasks = null, [WorkflowExpression] Func<int> tasksGetAllTasksskip = null, [WorkflowExpression] Func<int> tasksGetAllTasksmaxResults = null, [WorkflowExpression] Func<bool> tasksGetAllTasksexcludeTaskData = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetTaskResponse> TasksGetTask([WorkflowExpression] Func<int> tasksGetTasktaskId, [WorkflowExpression] Func<tasksGetTaskstatusChangeInput> tasksGetTaskstatusChange = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetNextTaskResponse> TasksGetNextTask([WorkflowExpression] Func<string> tasksGetNextTaskautomationName = null, [WorkflowExpression] Func<string[]> tasksGetNextTaskautomationNames = null, [WorkflowExpression] Func<int> tasksGetNextTaskminimumPriorityLevel = null, [WorkflowExpression] Func<tasksGetNextTaskstatusChangeInput> tasksGetNextTaskstatusChange = null, [WorkflowExpression] Func<int> tasksGetNextTaskminutesUntilDeferralDate = null, [WorkflowExpression] Func<bool> tasksGetNextTaskignoreSLA = null, [WorkflowExpression] Func<int[]> tasksGetNextTaskexcludeTaskIds = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksChangeTaskStatusResponse> TasksChangeTaskStatus([WorkflowExpression] Func<int> tasksChangeTaskStatustaskId, [WorkflowExpression] Func<tasksChangeTaskStatusautomationTaskStatusInput> tasksChangeTaskStatusautomationTaskStatus = null, [WorkflowExpression] Func<bool> tasksChangeTaskStatustaskOnHold = null, [WorkflowExpression] Func<bool> tasksChangeTaskStatuseraseTaskInputData = null, [WorkflowExpression] Func<bool> tasksChangeTaskStatuseraseDeferralStoredData = null, [WorkflowExpression] Func<bool> tasksChangeTaskStatusupdateSourceSystem = null, [WorkflowExpression] Func<string> tasksChangeTaskStatustaskClosureReason = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNoteResponse> TasksAddNote([WorkflowExpression] Func<int> tasksAddNotetaskId, [WorkflowExpression] Func<string> tasksAddNotenoteText, [WorkflowExpression] Func<tasksAddNotenoteTypeInput> tasksAddNotenoteType = null, [WorkflowExpression] Func<string> tasksAddNotenoteTypeOther = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAssignTaskResponse> TasksAssignTask([WorkflowExpression] Func<int> tasksAssignTasktaskId, [WorkflowExpression] Func<string> tasksAssignTaskassignToUserId = null, [WorkflowExpression] Func<string> tasksAssignTaskassignToUserName = null, [WorkflowExpression] Func<string> tasksAssignTaskassignToGroupId = null, [WorkflowExpression] Func<string> tasksAssignTaskassignToGroupName = null, [WorkflowExpression] Func<bool> tasksAssignTaskremoveUserAssignmentIfBlank = null, [WorkflowExpression] Func<bool> tasksAssignTaskremoveGroupAssignmentIfBlank = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksSetOutputDataResponse> TasksSetOutputData([WorkflowExpression] Func<int> tasksSetOutputDatataskId, [WorkflowExpression] Func<string> tasksSetOutputDatataskOutputData = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewTaskOperationResponse> TasksAddNewTaskOperation([WorkflowExpression] Func<string> tasksAddNewTaskOperationautomationName = null, [WorkflowExpression] Func<string> tasksAddNewTaskOperationtaskInputData = null, [WorkflowExpression] Func<string> tasksAddNewTaskOperationprocessStage = null, [WorkflowExpression] Func<int> tasksAddNewTaskOperationpriority = null, [WorkflowExpression] Func<int> tasksAddNewTaskOperationsLA = null, [WorkflowExpression] Func<string> tasksAddNewTaskOperationorganisation = null, [WorkflowExpression] Func<string> tasksAddNewTaskOperationdepartment = null, [WorkflowExpression] Func<string> tasksAddNewTaskOperationdescription = null, [WorkflowExpression] Func<string> tasksAddNewTaskOperationtags = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewDeferralOperationResponse> TasksAddNewDeferralOperation([WorkflowExpression] Func<string> tasksAddNewDeferralOperationautomationName = null, [WorkflowExpression] Func<int> tasksAddNewDeferralOperationdeferralTimeInMinutes = null, [WorkflowExpression] Func<string> tasksAddNewDeferralOperationtaskInputData = null, [WorkflowExpression] Func<string> tasksAddNewDeferralOperationdeferralStoredData = null, [WorkflowExpression] Func<string> tasksAddNewDeferralOperationprocessStage = null, [WorkflowExpression] Func<int> tasksAddNewDeferralOperationpriority = null, [WorkflowExpression] Func<string> tasksAddNewDeferralOperationorganisation = null, [WorkflowExpression] Func<string> tasksAddNewDeferralOperationdepartment = null, [WorkflowExpression] Func<string> tasksAddNewDeferralOperationdescription = null, [WorkflowExpression] Func<string> tasksAddNewDeferralOperationtags = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetTaskOperationResponse> TasksGetTaskOperation([WorkflowExpression] Func<string> tasksGetTaskOperationoperationId)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRemoteLoggingLevel([WorkflowExpression] Func<int> setRemoteLoggingLevelloggingLevel, [WorkflowExpression] Func<string> setRemoteLoggingLevelworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteLoggingLevelResponse> GetRemoteLoggingLevel([WorkflowExpression] Func<string> getRemoteLoggingLevelworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetLicenseCode([WorkflowExpression] Func<string> setLicenseCodecustomerNETBIOSDomainName, [WorkflowExpression] Func<string> setLicenseCodecustomerDisplayName, [WorkflowExpression] Func<string> setLicenseCodevendorName, [WorkflowExpression] Func<string> setLicenseCodelicenseExpiryDate, [WorkflowExpression] Func<string> setLicenseCodeactivationCode, [WorkflowExpression] Func<string> setLicenseCodeworkflow, [WorkflowExpression] Func<bool> setLicenseCodestoreInRegistry = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetLicenseStringResponse> SetLicenseString([WorkflowExpression] Func<string> setLicenseStringlicenseString, [WorkflowExpression] Func<string> setLicenseStringworkflow, [WorkflowExpression] Func<bool> setLicenseStringstoreInRegistry = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLicenseStateResponse> GetLicenseState([WorkflowExpression] Func<string> getLicenseStateworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUITopmost([WorkflowExpression] Func<string> setRSAGUITopmostworkflow, [WorkflowExpression] Func<bool> setRSAGUITopmosttopMost = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUIOpacity([WorkflowExpression] Func<double> setRSAGUIOpacityopacity, [WorkflowExpression] Func<string> setRSAGUIOpacityworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUIPosition([WorkflowExpression] Func<int> setRSAGUIPositionx, [WorkflowExpression] Func<int> setRSAGUIPositiony, [WorkflowExpression] Func<string> setRSAGUIPositionworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction BringRSAGUIToFront([WorkflowExpression] Func<string> bringRSAGUIToFrontworkflow, [WorkflowExpression] Func<bool> bringRSAGUIToFrontfocus = null, [WorkflowExpression] Func<bool> bringRSAGUIToFrontglobalLeftMouseClick = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DisconnectSession([WorkflowExpression] Func<string> disconnectSessionworkflow, [WorkflowExpression] Func<int> disconnectSessionsecondsToWait = null, [WorkflowExpression] Func<bool> disconnectSessiondoNotDisconnectIfLocalAgent = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LogoffSession([WorkflowExpression] Func<string> logoffSessionworkflow, [WorkflowExpression] Func<int> logoffSessionsecondsToWait = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CloseRSAServer([WorkflowExpression] Func<string> closeRSAServerworkflow, [WorkflowExpression] Func<int> closeRSAServersecondsToWait = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRPACommandTimeout([WorkflowExpression] Func<int> setRPACommandTimeoutcommandTimeoutInSeconds, [WorkflowExpression] Func<string> setRPACommandTimeoutworkflow, [WorkflowExpression] Func<bool> setRPACommandTimeoutterminateTimedoutRPACommandThreads = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RunAlternativeIAConnect([WorkflowExpression] Func<string> runAlternativeIAConnectfilename, [WorkflowExpression] Func<string> runAlternativeIAConnectworkflow, [WorkflowExpression] Func<string> runAlternativeIAConnectarguments = null, [WorkflowExpression] Func<bool> runAlternativeIAConnectloadIntoMemory = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunAlternativeIAConnectSentFromDirectorResponse> RunAlternativeIAConnectSentFromDirector([WorkflowExpression] Func<string> runAlternativeIAConnectSentFromDirectorlocalFilename, [WorkflowExpression] Func<string> runAlternativeIAConnectSentFromDirectorworkflow, [WorkflowExpression] Func<string> runAlternativeIAConnectSentFromDirectorremoteFilename = null, [WorkflowExpression] Func<bool> runAlternativeIAConnectSentFromDirectorcompress = null, [WorkflowExpression] Func<string> runAlternativeIAConnectSentFromDirectorarguments = null, [WorkflowExpression] Func<bool> runAlternativeIAConnectSentFromDirectorpermitDowngrade = null, [WorkflowExpression] Func<bool> runAlternativeIAConnectSentFromDirectorskipVersionCheck = null, [WorkflowExpression] Func<bool> runAlternativeIAConnectSentFromDirectorloadIntoMemory = null, [WorkflowExpression] Func<bool> runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectAgentInfoResponse> GetIAConnectAgentInfo([WorkflowExpression] Func<string> getIAConnectAgentInfoworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectAgentLogResponse> GetIAConnectAgentLog([WorkflowExpression] Func<string> getIAConnectAgentLogworkflow, [WorkflowExpression] Func<bool> getIAConnectAgentLogcompress = null, [WorkflowExpression] Func<bool> getIAConnectAgentLogreturnLastCommandOnly = null, [WorkflowExpression] Func<bool> getIAConnectAgentLogsaveLogToFile = null, [WorkflowExpression] Func<bool> getIAConnectAgentLogplaceLogContentInDataItem = null, [WorkflowExpression] Func<string> getIAConnectAgentLoglocalSaveFolder = null, [WorkflowExpression] Func<bool> getIAConnectAgentLoguseAgentLogFilename = null, [WorkflowExpression] Func<string> getIAConnectAgentLoglocalSaveFilename = null, [WorkflowExpression] Func<int> getIAConnectAgentLogmaxBytesToRead = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ResetCommandStats([WorkflowExpression] Func<string> resetCommandStatsworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAllCommandStatsResponse> GetAllCommandStats([WorkflowExpression] Func<string> getAllCommandStatsworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<EnableNextHopResponse> EnableNextHop([WorkflowExpression] Func<string> enableNextHopworkflow, [WorkflowExpression] Func<string> enableNextHopnextHopDirectorAddress = null, [WorkflowExpression] Func<int> enableNextHopnextHopDirectorTCPPort = null, [WorkflowExpression] Func<bool> enableNextHopnextHopDirectorUsesHTTPS = null, [WorkflowExpression] Func<bool> enableNextHopnextHopDirectorAddressIsLocalhostname = null, [WorkflowExpression] Func<bool> enableNextHopnextHopDirectorAddressIsHostname = null, [WorkflowExpression] Func<bool> enableNextHopnextHopDirectorAddressIsFQDN = null, [WorkflowExpression] Func<bool> enableNextHopincrementNextHopDirectorTCPPortBySessionId = null, [WorkflowExpression] Func<bool> enableNextHopdisableBeforeEnable = null, [WorkflowExpression] Func<bool> enableNextHopcheckNextHopDirectorIsRunning = null, [WorkflowExpression] Func<bool> enableNextHopcheckNextHopAgentIsRunning = null, [WorkflowExpression] Func<bool> enableNextHopnextHopDirectorAddressIsNamedPipe = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DisableNextHop([WorkflowExpression] Func<string> disableNextHopworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetNextHopStatusResponse> GetNextHopStatus([WorkflowExpression] Func<string> getNextHopStatusworkflow, [WorkflowExpression] Func<bool> getNextHopStatuscheckNextHopDirectorIsRunning = null, [WorkflowExpression] Func<bool> getNextHopStatuscheckNextHopAgentIsRunning = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForNextHopSessionToConnectResponse> WaitForNextHopSessionToConnect([WorkflowExpression] Func<string> waitForNextHopSessionToConnectworkflow, [WorkflowExpression] Func<string> waitForNextHopSessionToConnectnextHopDirectorAddress = null, [WorkflowExpression] Func<int> waitForNextHopSessionToConnectnextHopDirectorTCPPort = null, [WorkflowExpression] Func<bool> waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS = null, [WorkflowExpression] Func<bool> waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname = null, [WorkflowExpression] Func<bool> waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname = null, [WorkflowExpression] Func<bool> waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN = null, [WorkflowExpression] Func<bool> waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId = null, [WorkflowExpression] Func<double> waitForNextHopSessionToConnectsecondsToWait = null, [WorkflowExpression] Func<bool> waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe = null, [WorkflowExpression] Func<bool> waitForNextHopSessionToConnectdisableExistingNextHop = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ConfigureNextHopDirector([WorkflowExpression] Func<string> configureNextHopDirectorworkflow, [WorkflowExpression] Func<bool> configureNextHopDirectorsOAPEnabled = null, [WorkflowExpression] Func<bool> configureNextHopDirectorrESTEnabled = null, [WorkflowExpression] Func<bool> configureNextHopDirectorwebServerEnabled = null, [WorkflowExpression] Func<bool> configureNextHopDirectordirectorIsLocalhostOnly = null, [WorkflowExpression] Func<int> configureNextHopDirectorsOAPTCPPort = null, [WorkflowExpression] Func<int> configureNextHopDirectorrESTTCPPort = null, [WorkflowExpression] Func<bool> configureNextHopDirectorsOAPUsesHTTPS = null, [WorkflowExpression] Func<bool> configureNextHopDirectorrESTUsesHTTPS = null, [WorkflowExpression] Func<bool> configureNextHopDirectorincrementDirectorTCPPortBySessionId = null, [WorkflowExpression] Func<bool> configureNextHopDirectorsOAPUsesUserAuthentication = null, [WorkflowExpression] Func<bool> configureNextHopDirectorrESTUsesUserAuthentication = null, [WorkflowExpression] Func<bool> configureNextHopDirectorcommandNamedPipeEnabled = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ResetNextHopDirectorSettings([WorkflowExpression] Func<string> resetNextHopDirectorSettingsworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WorkflowCompleted([WorkflowExpression] Func<string> workflowCompletedworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RaiseExceptionResponse> RaiseException([WorkflowExpression] Func<string> raiseExceptioninputException = null, [WorkflowExpression] Func<string> raiseExceptionexceptionMessage = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UpdateOrchestratorFlowStatsResultResponse> UpdateOrchestratorFlowStatsResult([WorkflowExpression] Func<string> updateOrchestratorFlowStatsResultworkflow, [WorkflowExpression] Func<bool> updateOrchestratorFlowStatsResultflowLastActionSuccess = null, [WorkflowExpression] Func<string> updateOrchestratorFlowStatsResultflowLastActionErrorMessage = null, [WorkflowExpression] Func<int> updateOrchestratorFlowStatsResultflowLastActionCode = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLastFailedActionFromOrchestratorFlowStatsResponse> GetLastFailedActionFromOrchestratorFlowStats([WorkflowExpression] Func<string> getLastFailedActionFromOrchestratorFlowStatsworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorFlowStatsResponse> GetOrchestratorFlowStats([WorkflowExpression] Func<int> getOrchestratorFlowStatswithinLastNumberOfDays = null, [WorkflowExpression] Func<string> getOrchestratorFlowStatssearchFlowName = null, [WorkflowExpression] Func<bool> getOrchestratorFlowStatssearchFlowLastActionResult = null, [WorkflowExpression] Func<string> getOrchestratorFlowStatssearchFlowStartTimeStartWindow = null, [WorkflowExpression] Func<string> getOrchestratorFlowStatssearchFlowStartTimeEndWindow = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerAvailabilityStatsResponse> GetOrchestratorWorkerAvailabilityStats([WorkflowExpression] Func<int> getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays = null, [WorkflowExpression] Func<string> getOrchestratorWorkerAvailabilityStatssearchFlowName = null, [WorkflowExpression] Func<string> getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerFlowUsageHeatmapResponse> GetOrchestratorWorkerFlowUsageHeatmap([WorkflowExpression] Func<string> getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow, [WorkflowExpression] Func<string> getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow, [WorkflowExpression] Func<int> getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC = null, [WorkflowExpression] Func<string> getOrchestratorWorkerFlowUsageHeatmapworkerNames = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorLoginHistoryResponse> GetOrchestratorLoginHistory([WorkflowExpression] Func<int> getOrchestratorLoginHistorywithinLastNumberOfDays = null, [WorkflowExpression] Func<string> getOrchestratorLoginHistorysearchByEmail = null, [WorkflowExpression] Func<string> getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow = null, [WorkflowExpression] Func<string> getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetLocalLoggingLevel([WorkflowExpression] Func<int> setLocalLoggingLevelloggingLevel, [WorkflowExpression] Func<string> setLocalLoggingLevelworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunCommandResponse> RunCommand([WorkflowExpression] Func<string> runCommandcommandName, [WorkflowExpression] Func<string> runCommandworkflow, [WorkflowExpression] Func<string> runCommandinputJSON = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLocalLoggingLevelResponse> GetLocalLoggingLevel([WorkflowExpression] Func<string> getLocalLoggingLevelworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteClientTypeResponse> GetRemoteClientType([WorkflowExpression] Func<string> getRemoteClientTypeworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectDirectorInfoResponse> GetIAConnectDirectorInfo([WorkflowExpression] Func<string> getIAConnectDirectorInfoworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAvailableIAConnectSessionsResponse> GetAvailableIAConnectSessions([WorkflowExpression] Func<string> getAvailableIAConnectSessionsworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AttachToIAConnectSessionByName([WorkflowExpression] Func<string> attachToIAConnectSessionByNameiAConnectSessionName, [WorkflowExpression] Func<string> attachToIAConnectSessionByNameworkflow, [WorkflowExpression] Func<bool> attachToIAConnectSessionByNamevirtualChannelMustBeConnected = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToTier1IAConnectSessionResponse> AttachToTier1IAConnectSession([WorkflowExpression] Func<string> attachToTier1IAConnectSessionworkflow, [WorkflowExpression] Func<bool> attachToTier1IAConnectSessionvirtualChannelMustBeConnected = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToIAConnectSessionByIndexResponse> AttachToIAConnectSessionByIndex([WorkflowExpression] Func<string> attachToIAConnectSessionByIndexworkflow, [WorkflowExpression] Func<attachToIAConnectSessionByIndexsearchIAConnectSessionTypeInput> attachToIAConnectSessionByIndexsearchIAConnectSessionType = null, [WorkflowExpression] Func<int> attachToIAConnectSessionByIndexsearchIAConnectSessionIndex = null, [WorkflowExpression] Func<int> attachToIAConnectSessionByIndextimeToWaitInSeconds = null, [WorkflowExpression] Func<bool> attachToIAConnectSessionByIndexraiseExceptionIfTimedout = null, [WorkflowExpression] Func<bool> attachToIAConnectSessionByIndexvirtualChannelMustBeConnected = null, [WorkflowExpression] Func<bool> attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToMostRecentIAConnectSessionResponse> AttachToMostRecentIAConnectSession([WorkflowExpression] Func<string> attachToMostRecentIAConnectSessionworkflow, [WorkflowExpression] Func<attachToMostRecentIAConnectSessionsearchIAConnectSessionTypeInput> attachToMostRecentIAConnectSessionsearchIAConnectSessionType = null, [WorkflowExpression] Func<int> attachToMostRecentIAConnectSessiontimeToWaitInSeconds = null, [WorkflowExpression] Func<bool> attachToMostRecentIAConnectSessionraiseExceptionIfTimedout = null, [WorkflowExpression] Func<bool> attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected = null, [WorkflowExpression] Func<bool> attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDirectorUpTimeResponse> GetDirectorUpTime([WorkflowExpression] Func<string> getDirectorUpTimeworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DoesIAConnectSessionExistByNameResponse> DoesIAConnectSessionExistByName([WorkflowExpression] Func<string> doesIAConnectSessionExistByNameiAConnectSessionName, [WorkflowExpression] Func<string> doesIAConnectSessionExistByNameworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForIAConnectSessionToCloseByNameResponse> WaitForIAConnectSessionToCloseByName([WorkflowExpression] Func<string> waitForIAConnectSessionToCloseByNameiAConnectSessionName, [WorkflowExpression] Func<string> waitForIAConnectSessionToCloseByNameworkflow, [WorkflowExpression] Func<int> waitForIAConnectSessionToCloseByNametimeToWaitInSeconds = null, [WorkflowExpression] Func<bool> waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout = null, [WorkflowExpression] Func<bool> waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillIAConnectSessionByNameResponse> KillIAConnectSessionByName([WorkflowExpression] Func<string> killIAConnectSessionByNameiAConnectSessionName, [WorkflowExpression] Func<string> killIAConnectSessionByNameworkflow, [WorkflowExpression] Func<bool> killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetAgentGlobalCoordinateConfigurationResponse> SetAgentGlobalCoordinateConfiguration([WorkflowExpression] Func<string> setAgentGlobalCoordinateConfigurationworkflow, [WorkflowExpression] Func<setAgentGlobalCoordinateConfigurationmultiMonitorFunctionalityInput> setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality = null, [WorkflowExpression] Func<setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplierInput> setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier = null, [WorkflowExpression] Func<setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplierInput> setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier = null, [WorkflowExpression] Func<double> setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier = null, [WorkflowExpression] Func<double> setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier = null, [WorkflowExpression] Func<double> setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier = null, [WorkflowExpression] Func<double> setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier = null, [WorkflowExpression] Func<bool> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent = null, [WorkflowExpression] Func<bool> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos = null, [WorkflowExpression] Func<bool> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod = null, [WorkflowExpression] Func<setAgentGlobalCoordinateConfigurationjavaCoordinateSystemInput> setAgentGlobalCoordinateConfigurationjavaCoordinateSystem = null, [WorkflowExpression] Func<setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystemInput> setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentGlobalCoordinateConfigurationResponse> GetAgentGlobalCoordinateConfiguration([WorkflowExpression] Func<string> getAgentGlobalCoordinateConfigurationworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentThreadStatusResponse> GetAgentThreadStatus([WorkflowExpression] Func<int> getAgentThreadStatusthreadId, [WorkflowExpression] Func<string> getAgentThreadStatusworkflow, [WorkflowExpression] Func<bool> getAgentThreadStatusretrieveThreadOutputData = null, [WorkflowExpression] Func<bool> getAgentThreadStatusclearOutputDataFromMemoryOnceRead = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForAgentThreadToCompleteSuccessfullyResponse> WaitForAgentThreadToCompleteSuccessfully([WorkflowExpression] Func<int> waitForAgentThreadToCompleteSuccessfullythreadId, [WorkflowExpression] Func<int> waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread, [WorkflowExpression] Func<string> waitForAgentThreadToCompleteSuccessfullyworkflow, [WorkflowExpression] Func<bool> waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData = null, [WorkflowExpression] Func<bool> waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead = null, [WorkflowExpression] Func<bool> waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted = null, [WorkflowExpression] Func<bool> waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError = null, [WorkflowExpression] Func<int> waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentThreadsResponse> GetAgentThreads([WorkflowExpression] Func<string> getAgentThreadsworkflow, [WorkflowExpression] Func<getAgentThreadssortOrderInput> getAgentThreadssortOrder = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillAgentThreadResponse> KillAgentThread([WorkflowExpression] Func<int> killAgentThreadthreadId, [WorkflowExpression] Func<string> killAgentThreadworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeleteAgentThreadResponse> DeleteAgentThread([WorkflowExpression] Func<string> deleteAgentThreadworkflow, [WorkflowExpression] Func<int> deleteAgentThreadthreadId = null, [WorkflowExpression] Func<bool> deleteAgentThreaddeleteAllAgentThreads = null, [WorkflowExpression] Func<bool> deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AllocateWorkerFromOrchestratorResponse> AllocateWorkerFromOrchestrator([WorkflowExpression] Func<string> allocateWorkerFromOrchestratorworkflow, [WorkflowExpression] Func<string> allocateWorkerFromOrchestratorworkerTag = null, [WorkflowExpression] Func<string> allocateWorkerFromOrchestratorworkerName = null, [WorkflowExpression] Func<bool> allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetOrchestratorWorkerMaintenanceModeResponse> SetOrchestratorWorkerMaintenanceMode([WorkflowExpression] Func<int> setOrchestratorWorkerMaintenanceModeworkerId = null, [WorkflowExpression] Func<string> setOrchestratorWorkerMaintenanceModeworkerName = null, [WorkflowExpression] Func<bool> setOrchestratorWorkerMaintenanceModemaintenanceMode = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CreateOrchestratorOneTimeSecretResponse> CreateOrchestratorOneTimeSecret([WorkflowExpression] Func<string> createOrchestratorOneTimeSecretfriendlyName, [WorkflowExpression] Func<string> createOrchestratorOneTimeSecretsecretValue = null, [WorkflowExpression] Func<string> createOrchestratorOneTimeSecretretrievalPhrase1 = null, [WorkflowExpression] Func<string> createOrchestratorOneTimeSecretretrievalPhrase2 = null, [WorkflowExpression] Func<int> createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion = null, [WorkflowExpression] Func<bool> createOrchestratorOneTimeSecretsecretHasAStartDate = null, [WorkflowExpression] Func<string> createOrchestratorOneTimeSecretsecretStartDateTime = null, [WorkflowExpression] Func<int> createOrchestratorOneTimeSecrethoursUntilSecretStartTime = null, [WorkflowExpression] Func<bool> createOrchestratorOneTimeSecretsecretHasAnExpiryDate = null, [WorkflowExpression] Func<string> createOrchestratorOneTimeSecretsecretExpiryDateTime = null, [WorkflowExpression] Func<int> createOrchestratorOneTimeSecrethoursUntilSecretExpiry = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfOrchestratorWorkersResponse> GetListOfOrchestratorWorkers([WorkflowExpression] Func<bool> getListOfOrchestratorWorkersonlyReturnLiveWorkers = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerResponse> GetOrchestratorWorker([WorkflowExpression] Func<int> getOrchestratorWorkersearchWorkerId = null, [WorkflowExpression] Func<string> getOrchestratorWorkersearchWorkerName = null)
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
        public IBodyWorkflowAction<FileExistsResponse> FileExists([WorkflowExpression] Func<string> fileExistsfilename, [WorkflowExpression] Func<string> fileExistsworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DirectoryExistsResponse> DirectoryExists([WorkflowExpression] Func<string> directoryExistsdirectoryPath, [WorkflowExpression] Func<string> directoryExistsworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DeleteFile([WorkflowExpression] Func<string> deleteFilefilename, [WorkflowExpression] Func<string> deleteFileworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DeleteDirectory([WorkflowExpression] Func<string> deleteDirectorydirectoryPath, [WorkflowExpression] Func<string> deleteDirectoryworkflow, [WorkflowExpression] Func<bool> deleteDirectoryrecursive = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction PurgeDirectory([WorkflowExpression] Func<string> purgeDirectorydirectoryPath, [WorkflowExpression] Func<string> purgeDirectoryworkflow, [WorkflowExpression] Func<bool> purgeDirectoryrecursive = null, [WorkflowExpression] Func<bool> purgeDirectorydeleteTopLevel = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CopyFile([WorkflowExpression] Func<string> copyFilesourceFilePath, [WorkflowExpression] Func<string> copyFiledestFilePath, [WorkflowExpression] Func<string> copyFileworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveFile([WorkflowExpression] Func<string> moveFilesourceFilePath, [WorkflowExpression] Func<string> moveFiledestFilePath, [WorkflowExpression] Func<string> moveFileworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CreateDirectory([WorkflowExpression] Func<string> createDirectorydirectoryPath, [WorkflowExpression] Func<string> createDirectoryworkflow, [WorkflowExpression] Func<bool> createDirectoryerrorIfAlreadyExists = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileSizeResponse> GetFileSize([WorkflowExpression] Func<string> getFileSizefilename, [WorkflowExpression] Func<string> getFileSizeworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WriteTextFile([WorkflowExpression] Func<string> writeTextFilefilename, [WorkflowExpression] Func<string> writeTextFileworkflow, [WorkflowExpression] Func<string> writeTextFiletextToWrite = null, [WorkflowExpression] Func<bool> writeTextFileappendExistingFile = null, [WorkflowExpression] Func<writeTextFileencodingInput> writeTextFileencoding = null, [WorkflowExpression] Func<bool> writeTextFilecreateFolderIfRequired = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ReadAllTextFromFileResponse> ReadAllTextFromFile([WorkflowExpression] Func<string> readAllTextFromFilefilename, [WorkflowExpression] Func<string> readAllTextFromFileworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFilesResponse> GetFiles([WorkflowExpression] Func<string> getFilesdirectoryPath, [WorkflowExpression] Func<string> getFilespatternsCSV, [WorkflowExpression] Func<string> getFilesworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFoldersResponse> GetFolders([WorkflowExpression] Func<string> getFoldersdirectoryPath, [WorkflowExpression] Func<string> getFoldersworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeleteFilesResponse> DeleteFiles([WorkflowExpression] Func<string> deleteFilesdirectoryPath, [WorkflowExpression] Func<string> deleteFilesworkflow, [WorkflowExpression] Func<string> deleteFilespattern = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDiskFreeSpaceResponse> GetDiskFreeSpace([WorkflowExpression] Func<string> getDiskFreeSpacedriveLetter, [WorkflowExpression] Func<string> getDiskFreeSpaceworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfDrivesResponse> GetListOfDrives([WorkflowExpression] Func<string> getListOfDrivesworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DirectoryIsAccessibleResponse> DirectoryIsAccessible([WorkflowExpression] Func<string> directoryIsAccessibledirectoryPath, [WorkflowExpression] Func<string> directoryIsAccessibleworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetCSVTextAsCollectionResponse> GetCSVTextAsCollection([WorkflowExpression] Func<string> getCSVTextAsCollectioncSVFilePath, [WorkflowExpression] Func<string> getCSVTextAsCollectionworkflow, [WorkflowExpression] Func<bool> getCSVTextAsCollectionfirstLineIsHeader = null, [WorkflowExpression] Func<bool> getCSVTextAsCollectiontrimHeaders = null, [WorkflowExpression] Func<bool> getCSVTextAsCollectionallowBlankRows = null, [WorkflowExpression] Func<bool> getCSVTextAsCollectionextendColumnsIfRequired = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WriteCollectionToCSVFileResponse> WriteCollectionToCSVFile([WorkflowExpression] Func<string> writeCollectionToCSVFilecSVFilePath, [WorkflowExpression] Func<string> writeCollectionToCSVFileworkflow, [WorkflowExpression] Func<JToken[]> writeCollectionToCSVFileinputTable = null, [WorkflowExpression] Func<string> writeCollectionToCSVFileinputTableJSON = null, [WorkflowExpression] Func<writeCollectionToCSVFileoutputEncodingInput> writeCollectionToCSVFileoutputEncoding = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetOwnerOnFolder([WorkflowExpression] Func<string> setOwnerOnFolderfolderPath, [WorkflowExpression] Func<string> setOwnerOnFolderuserIdentity, [WorkflowExpression] Func<string> setOwnerOnFolderworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetOwnerOnFile([WorkflowExpression] Func<string> setOwnerOnFilefilePath, [WorkflowExpression] Func<string> setOwnerOnFileuserIdentity, [WorkflowExpression] Func<string> setOwnerOnFileworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddPermissionToFolder([WorkflowExpression] Func<string> addPermissionToFolderfolderPath, [WorkflowExpression] Func<string> addPermissionToFolderidentity, [WorkflowExpression] Func<addPermissionToFolderpermissionInput> addPermissionToFolderpermission, [WorkflowExpression] Func<string> addPermissionToFolderworkflow, [WorkflowExpression] Func<bool> addPermissionToFolderapplyToFolder = null, [WorkflowExpression] Func<bool> addPermissionToFolderapplyToSubFolders = null, [WorkflowExpression] Func<bool> addPermissionToFolderapplyToFiles = null, [WorkflowExpression] Func<bool> addPermissionToFolderdeny = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddPermissionToFile([WorkflowExpression] Func<string> addPermissionToFilefilePath, [WorkflowExpression] Func<string> addPermissionToFileidentity, [WorkflowExpression] Func<addPermissionToFilepermissionInput> addPermissionToFilepermission, [WorkflowExpression] Func<string> addPermissionToFileworkflow, [WorkflowExpression] Func<bool> addPermissionToFiledeny = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction BreakFolderSecurityInheritance([WorkflowExpression] Func<string> breakFolderSecurityInheritancefolderPath, [WorkflowExpression] Func<string> breakFolderSecurityInheritanceworkflow, [WorkflowExpression] Func<bool> breakFolderSecurityInheritanceconvertInheritedToExplicit = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction EnableFolderSecurityInheritance([WorkflowExpression] Func<string> enableFolderSecurityInheritancefolderPath, [WorkflowExpression] Func<string> enableFolderSecurityInheritanceworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFolderSecurityPermissionsResponse> GetFolderSecurityPermissions([WorkflowExpression] Func<string> getFolderSecurityPermissionsfolderPath, [WorkflowExpression] Func<string> getFolderSecurityPermissionsworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileSecurityPermissionsResponse> GetFileSecurityPermissions([WorkflowExpression] Func<string> getFileSecurityPermissionsfilePath, [WorkflowExpression] Func<string> getFileSecurityPermissionsworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RemoveIdentityFromFolderSecurityResponse> RemoveIdentityFromFolderSecurity([WorkflowExpression] Func<string> removeIdentityFromFolderSecurityfolderPath, [WorkflowExpression] Func<string> removeIdentityFromFolderSecurityidentityToRemove, [WorkflowExpression] Func<string> removeIdentityFromFolderSecurityworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RemoveIdentityFromFileSecurityResponse> RemoveIdentityFromFileSecurity([WorkflowExpression] Func<string> removeIdentityFromFileSecurityfilePath, [WorkflowExpression] Func<string> removeIdentityFromFileSecurityidentityToRemove, [WorkflowExpression] Func<string> removeIdentityFromFileSecurityworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CopyFileFromClientToServer([WorkflowExpression] Func<string> copyFileFromClientToServerclientFilePath, [WorkflowExpression] Func<string> copyFileFromClientToServerserverFilePath, [WorkflowExpression] Func<string> copyFileFromClientToServerworkflow, [WorkflowExpression] Func<bool> copyFileFromClientToServercompress = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ReplaceVariableDataInINIFile([WorkflowExpression] Func<string> replaceVariableDataInINIFileinputFilename, [WorkflowExpression] Func<string> replaceVariableDataInINIFileworkflow, [WorkflowExpression] Func<string> replaceVariableDataInINIFileoutputFilename = null, [WorkflowExpression] Func<string> replaceVariableDataInINIFilesearchSection = null, [WorkflowExpression] Func<string> replaceVariableDataInINIFilesearchVariable = null, [WorkflowExpression] Func<string> replaceVariableDataInINIFilereplaceData = null, [WorkflowExpression] Func<string> replaceVariableDataInINIFileinputFilenameEncoding = null, [WorkflowExpression] Func<bool> replaceVariableDataInINIFilecreateNewFileIfNotExists = null, [WorkflowExpression] Func<bool> replaceVariableDataInINIFilewriteSpaceBeforeEquals = null, [WorkflowExpression] Func<bool> replaceVariableDataInINIFilewriteSpaceAfterEquals = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DownloadHTTPFileResponse> DownloadHTTPFile([WorkflowExpression] Func<string> downloadHTTPFiledownloadURL, [WorkflowExpression] Func<string> downloadHTTPFileworkflow, [WorkflowExpression] Func<string> downloadHTTPFilesaveFilename = null, [WorkflowExpression] Func<bool> downloadHTTPFileoverwriteExistingFile = null, [WorkflowExpression] Func<bool> downloadHTTPFilepassthroughAuthentication = null, [WorkflowExpression] Func<string> downloadHTTPFileuserAgent = null, [WorkflowExpression] Func<string> downloadHTTPFileaccept = null, [WorkflowExpression] Func<bool> downloadHTTPFilesupportTLS10 = null, [WorkflowExpression] Func<bool> downloadHTTPFilesupportTLS11 = null, [WorkflowExpression] Func<bool> downloadHTTPFilesupportTLS12 = null, [WorkflowExpression] Func<bool> downloadHTTPFileautoDecompressDeflate = null, [WorkflowExpression] Func<bool> downloadHTTPFileautoDecompressGZIP = null, [WorkflowExpression] Func<bool> downloadHTTPFilereturnContentsAsString = null, [WorkflowExpression] Func<downloadHTTPFilereturnContentEncodingInput> downloadHTTPFilereturnContentEncoding = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UnZIPFileResponse> UnZIPFile([WorkflowExpression] Func<string> unZIPFilezIPFilename, [WorkflowExpression] Func<string> unZIPFileworkflow, [WorkflowExpression] Func<string> unZIPFileextractFolder = null, [WorkflowExpression] Func<bool> unZIPFileextractAllFilesToSingleFolder = null, [WorkflowExpression] Func<string> unZIPFileincludeFilesRegEx = null, [WorkflowExpression] Func<string> unZIPFileexcludeFilesRegEx = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddFileToZIP([WorkflowExpression] Func<string> addFileToZIPsourceFilenameToAddToZIP, [WorkflowExpression] Func<string> addFileToZIPoutputZIPFilename, [WorkflowExpression] Func<string> addFileToZIPworkflow, [WorkflowExpression] Func<string> addFileToZIPaddFilenameToFolderInZIP = null, [WorkflowExpression] Func<string> addFileToZIPsourceFilenameToAddToZIPComment = null, [WorkflowExpression] Func<bool> addFileToZIPcompress = null, [WorkflowExpression] Func<bool> addFileToZIPaddToExistingZIPFile = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AddFolderToZIPResponse> AddFolderToZIP([WorkflowExpression] Func<string> addFolderToZIPsourceFolderToAddToZIP, [WorkflowExpression] Func<string> addFolderToZIPoutputZIPFilename, [WorkflowExpression] Func<string> addFolderToZIPworkflow, [WorkflowExpression] Func<string> addFolderToZIPaddFilesToFolderInZIP = null, [WorkflowExpression] Func<bool> addFolderToZIPcompress = null, [WorkflowExpression] Func<bool> addFolderToZIPaddToExistingZIPFile = null, [WorkflowExpression] Func<bool> addFolderToZIPincludeSubfolders = null, [WorkflowExpression] Func<string> addFolderToZIPincludeFilesRegEx = null, [WorkflowExpression] Func<string> addFolderToZIPexcludeFilesRegEx = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileContentsAsBase64Response> GetFileContentsAsBase64([WorkflowExpression] Func<string> getFileContentsAsBase64filePath, [WorkflowExpression] Func<string> getFileContentsAsBase64workflow, [WorkflowExpression] Func<bool> getFileContentsAsBase64compress = null, [WorkflowExpression] Func<int> getFileContentsAsBase64maxFileSize = null)
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