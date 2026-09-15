//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectsessionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMachineNameResponse> GetMachineName(Expression<Func<string>> getMachineNameworkflow)
        {
            var apiCallPath = "/Environment/GetMachineName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getMachineName = new JObject();
            var getMachineNamepropCount = 0;
            getMachineNamepropCount++;
            getMachineName["Workflow"] = CSharpExpressionConverter.ConvertToken(getMachineNameworkflow);
            if (getMachineNamepropCount > 0)
            {
                callPayload.Body = getMachineName;
            }

            return new ApiConnectionAction<GetMachineNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMachineDomainResponse> GetMachineDomain(Expression<Func<string>> getMachineDomainworkflow)
        {
            var apiCallPath = "/Environment/GetMachineDomain";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getMachineDomain = new JObject();
            var getMachineDomainpropCount = 0;
            getMachineDomainpropCount++;
            getMachineDomain["Workflow"] = CSharpExpressionConverter.ConvertToken(getMachineDomainworkflow);
            if (getMachineDomainpropCount > 0)
            {
                callPayload.Body = getMachineDomain;
            }

            return new ApiConnectionAction<GetMachineDomainResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteSessionClientHostnameResponse> GetRemoteSessionClientHostname(Expression<Func<string>> getRemoteSessionClientHostnameworkflow)
        {
            var apiCallPath = "/Environment/GetRemoteSessionClientHostname";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRemoteSessionClientHostname = new JObject();
            var getRemoteSessionClientHostnamepropCount = 0;
            getRemoteSessionClientHostnamepropCount++;
            getRemoteSessionClientHostname["Workflow"] = CSharpExpressionConverter.ConvertToken(getRemoteSessionClientHostnameworkflow);
            if (getRemoteSessionClientHostnamepropCount > 0)
            {
                callPayload.Body = getRemoteSessionClientHostname;
            }

            return new ApiConnectionAction<GetRemoteSessionClientHostnameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ExpandEnvironmentVariableResponse> ExpandEnvironmentVariable(Expression<Func<string>> expandEnvironmentVariableinputString, Expression<Func<string>> expandEnvironmentVariableworkflow)
        {
            var apiCallPath = "/Environment/ExpandEnvironmentVariable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var expandEnvironmentVariable = new JObject();
            var expandEnvironmentVariablepropCount = 0;
            expandEnvironmentVariablepropCount++;
            expandEnvironmentVariable["InputString"] = CSharpExpressionConverter.ConvertToken(expandEnvironmentVariableinputString);
            expandEnvironmentVariablepropCount++;
            expandEnvironmentVariable["Workflow"] = CSharpExpressionConverter.ConvertToken(expandEnvironmentVariableworkflow);
            if (expandEnvironmentVariablepropCount > 0)
            {
                callPayload.Body = expandEnvironmentVariable;
            }

            return new ApiConnectionAction<ExpandEnvironmentVariableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillProcessResponse> KillProcess(Expression<Func<string>> killProcessprocessName, Expression<Func<string>> killProcessworkflow)
        {
            var apiCallPath = "/Environment/KillProcess";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var killProcess = new JObject();
            var killProcesspropCount = 0;
            killProcesspropCount++;
            killProcess["ProcessName"] = CSharpExpressionConverter.ConvertToken(killProcessprocessName);
            killProcesspropCount++;
            killProcess["Workflow"] = CSharpExpressionConverter.ConvertToken(killProcessworkflow);
            if (killProcesspropCount > 0)
            {
                callPayload.Body = killProcess;
            }

            return new ApiConnectionAction<KillProcessResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillProcessIDResponse> KillProcessID(Expression<Func<int>> killProcessIDprocessID, Expression<Func<string>> killProcessIDworkflow)
        {
            var apiCallPath = "/Environment/KillProcessID";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var killProcessID = new JObject();
            var killProcessIDpropCount = 0;
            killProcessIDpropCount++;
            killProcessID["ProcessID"] = CSharpExpressionConverter.ConvertToken(killProcessIDprocessID);
            killProcessIDpropCount++;
            killProcessID["Workflow"] = CSharpExpressionConverter.ConvertToken(killProcessIDworkflow);
            if (killProcessIDpropCount > 0)
            {
                callPayload.Body = killProcessID;
            }

            return new ApiConnectionAction<KillProcessIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessCountByNameResponse> GetProcessCountByName(Expression<Func<string>> getProcessCountByNameprocessName, Expression<Func<string>> getProcessCountByNameworkflow)
        {
            var apiCallPath = "/Environment/GetProcessCountByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getProcessCountByName = new JObject();
            var getProcessCountByNamepropCount = 0;
            getProcessCountByNamepropCount++;
            getProcessCountByName["ProcessName"] = CSharpExpressionConverter.ConvertToken(getProcessCountByNameprocessName);
            getProcessCountByNamepropCount++;
            getProcessCountByName["Workflow"] = CSharpExpressionConverter.ConvertToken(getProcessCountByNameworkflow);
            if (getProcessCountByNamepropCount > 0)
            {
                callPayload.Body = getProcessCountByName;
            }

            return new ApiConnectionAction<GetProcessCountByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentProcessCountResponse> GetAgentProcessCount(Expression<Func<string>> getAgentProcessCountworkflow)
        {
            var apiCallPath = "/Environment/GetAgentProcessCount";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getAgentProcessCount = new JObject();
            var getAgentProcessCountpropCount = 0;
            getAgentProcessCountpropCount++;
            getAgentProcessCount["Workflow"] = CSharpExpressionConverter.ConvertToken(getAgentProcessCountworkflow);
            if (getAgentProcessCountpropCount > 0)
            {
                callPayload.Body = getAgentProcessCount;
            }

            return new ApiConnectionAction<GetAgentProcessCountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillAllOtherAgentsResponse> KillAllOtherAgents(Expression<Func<string>> killAllOtherAgentsworkflow)
        {
            var apiCallPath = "/Environment/KillAllOtherAgents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var killAllOtherAgents = new JObject();
            var killAllOtherAgentspropCount = 0;
            killAllOtherAgentspropCount++;
            killAllOtherAgents["Workflow"] = CSharpExpressionConverter.ConvertToken(killAllOtherAgentsworkflow);
            if (killAllOtherAgentspropCount > 0)
            {
                callPayload.Body = killAllOtherAgents;
            }

            return new ApiConnectionAction<KillAllOtherAgentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessByPIDResponse> GetProcessByPID(Expression<Func<int>> getProcessByPIDprocessId, Expression<Func<string>> getProcessByPIDworkflow)
        {
            var apiCallPath = "/Environment/GetProcessByPID";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getProcessByPID = new JObject();
            var getProcessByPIDpropCount = 0;
            getProcessByPIDpropCount++;
            getProcessByPID["ProcessId"] = CSharpExpressionConverter.ConvertToken(getProcessByPIDprocessId);
            getProcessByPIDpropCount++;
            getProcessByPID["Workflow"] = CSharpExpressionConverter.ConvertToken(getProcessByPIDworkflow);
            if (getProcessByPIDpropCount > 0)
            {
                callPayload.Body = getProcessByPID;
            }

            return new ApiConnectionAction<GetProcessByPIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessesResponse> GetProcesses(Expression<Func<string>> getProcessesworkflow, Expression<Func<string>> getProcessesprocessName = null, Expression<Func<bool>> getProcessesgetProcessCommandLine = null)
        {
            var apiCallPath = "/Environment/GetProcesses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getProcesses = new JObject();
            var getProcessespropCount = 0;
            if (getProcessesprocessName != null)
            {
                getProcesses["ProcessName"] = CSharpExpressionConverter.ConvertToken(getProcessesprocessName);
                getProcessespropCount++;
            }

            if (getProcessesgetProcessCommandLine != null)
            {
                if (getProcessesgetProcessCommandLine != null)
                {
                    getProcesses["GetProcessCommandLine"] = CSharpExpressionConverter.ConvertToken(getProcessesgetProcessCommandLine);
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
            getProcesses["Workflow"] = CSharpExpressionConverter.ConvertToken(getProcessesworkflow);
            if (getProcessespropCount > 0)
            {
                callPayload.Body = getProcesses;
            }

            return new ApiConnectionAction<GetProcessesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunProcessResponse> RunProcess(Expression<Func<string>> runProcessprocessName, Expression<Func<string>> runProcessworkflow, Expression<Func<string>> runProcessarguments = null, Expression<Func<string>> runProcessworkingDirectory = null, Expression<Func<bool>> runProcessuseShellExecute = null, Expression<Func<bool>> runProcesscreateNoWindow = null, Expression<Func<runProcesswindowStyleInput>> runProcesswindowStyle = null, Expression<Func<bool>> runProcesswaitForProcess = null, Expression<Func<bool>> runProcessredirectStandardOutput = null, Expression<Func<bool>> runProcessredirectStandardError = null, Expression<Func<bool>> runProcessredirectStandardErrorToOutput = null, Expression<Func<runProcessstandardOutputEncodingInput>> runProcessstandardOutputEncoding = null, Expression<Func<runProcessstandardErrorEncodingInput>> runProcessstandardErrorEncoding = null, Expression<Func<string>> runProcessrunAsDomain = null, Expression<Func<string>> runProcessrunAsUsername = null, Expression<Func<string>> runProcessrunAsPassword = null, Expression<Func<bool>> runProcessrunAsLoadUserProfile = null, Expression<Func<bool>> runProcessrunAsElevate = null, Expression<Func<int>> runProcesstimeoutInSeconds = null)
        {
            var apiCallPath = "/Environment/RunProcess";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runProcess = new JObject();
            var runProcesspropCount = 0;
            runProcesspropCount++;
            runProcess["ProcessName"] = CSharpExpressionConverter.ConvertToken(runProcessprocessName);
            if (runProcessarguments != null)
            {
                runProcess["Arguments"] = CSharpExpressionConverter.ConvertToken(runProcessarguments);
                runProcesspropCount++;
            }

            if (runProcessworkingDirectory != null)
            {
                runProcess["WorkingDirectory"] = CSharpExpressionConverter.ConvertToken(runProcessworkingDirectory);
                runProcesspropCount++;
            }

            if (runProcessuseShellExecute != null)
            {
                if (runProcessuseShellExecute != null)
                {
                    runProcess["UseShellExecute"] = CSharpExpressionConverter.ConvertToken(runProcessuseShellExecute);
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
                    runProcess["CreateNoWindow"] = CSharpExpressionConverter.ConvertToken(runProcesscreateNoWindow);
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
                    runProcess["WindowStyle"] = CSharpExpressionConverter.Convert(runProcesswindowStyle);
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
                    runProcess["WaitForProcess"] = CSharpExpressionConverter.ConvertToken(runProcesswaitForProcess);
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
                    runProcess["RedirectStandardOutput"] = CSharpExpressionConverter.ConvertToken(runProcessredirectStandardOutput);
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
                    runProcess["RedirectStandardError"] = CSharpExpressionConverter.ConvertToken(runProcessredirectStandardError);
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
                    runProcess["RedirectStandardErrorToOutput"] = CSharpExpressionConverter.ConvertToken(runProcessredirectStandardErrorToOutput);
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
                runProcess["StandardOutputEncoding"] = CSharpExpressionConverter.Convert(runProcessstandardOutputEncoding);
                runProcesspropCount++;
            }

            if (runProcessstandardErrorEncoding != null)
            {
                runProcess["StandardErrorEncoding"] = CSharpExpressionConverter.Convert(runProcessstandardErrorEncoding);
                runProcesspropCount++;
            }

            if (runProcessrunAsDomain != null)
            {
                runProcess["RunAsDomain"] = CSharpExpressionConverter.ConvertToken(runProcessrunAsDomain);
                runProcesspropCount++;
            }

            if (runProcessrunAsUsername != null)
            {
                runProcess["RunAsUsername"] = CSharpExpressionConverter.ConvertToken(runProcessrunAsUsername);
                runProcesspropCount++;
            }

            if (runProcessrunAsPassword != null)
            {
                runProcess["RunAsPassword"] = CSharpExpressionConverter.ConvertToken(runProcessrunAsPassword);
                runProcesspropCount++;
            }

            if (runProcessrunAsLoadUserProfile != null)
            {
                if (runProcessrunAsLoadUserProfile != null)
                {
                    runProcess["RunAsLoadUserProfile"] = CSharpExpressionConverter.ConvertToken(runProcessrunAsLoadUserProfile);
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
                    runProcess["RunAsElevate"] = CSharpExpressionConverter.ConvertToken(runProcessrunAsElevate);
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
                    runProcess["TimeoutInSeconds"] = CSharpExpressionConverter.ConvertToken(runProcesstimeoutInSeconds);
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
            runProcess["Workflow"] = CSharpExpressionConverter.ConvertToken(runProcessworkflow);
            if (runProcesspropCount > 0)
            {
                callPayload.Body = runProcess;
            }

            return new ApiConnectionAction<RunProcessResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunPowerShellProcessResponse> RunPowerShellProcess(Expression<Func<string>> runPowerShellProcessworkflow, Expression<Func<string>> runPowerShellProcesspowerShellExecutable = null, Expression<Func<string>> runPowerShellProcesspowerShellScriptFilePath = null, Expression<Func<string>> runPowerShellProcesspowerShellScriptContents = null, Expression<Func<string>> runPowerShellProcessworkingDirectory = null, Expression<Func<bool>> runPowerShellProcesscreateNoWindow = null, Expression<Func<runPowerShellProcesswindowStyleInput>> runPowerShellProcesswindowStyle = null, Expression<Func<bool>> runPowerShellProcesswaitForProcess = null, Expression<Func<bool>> runPowerShellProcessredirectStandardOutput = null, Expression<Func<bool>> runPowerShellProcessredirectStandardError = null, Expression<Func<bool>> runPowerShellProcessredirectStandardErrorToOutput = null, Expression<Func<runPowerShellProcessstandardOutputEncodingInput>> runPowerShellProcessstandardOutputEncoding = null, Expression<Func<runPowerShellProcessstandardErrorEncodingInput>> runPowerShellProcessstandardErrorEncoding = null, Expression<Func<string>> runPowerShellProcessrunAsDomain = null, Expression<Func<string>> runPowerShellProcessrunAsUsername = null, Expression<Func<string>> runPowerShellProcessrunAsPassword = null, Expression<Func<bool>> runPowerShellProcessrunAsLoadUserProfile = null, Expression<Func<bool>> runPowerShellProcessrunAsElevate = null, Expression<Func<int>> runPowerShellProcesstimeoutInSeconds = null, Expression<Func<string>> runPowerShellProcesspowerShellScriptTempFolder = null)
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
                    runPowerShellProcess["PowerShellExecutable"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcesspowerShellExecutable);
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
                runPowerShellProcess["PowerShellScriptFilePath"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcesspowerShellScriptFilePath);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcesspowerShellScriptContents != null)
            {
                runPowerShellProcess["PowerShellScriptContents"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcesspowerShellScriptContents);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessworkingDirectory != null)
            {
                runPowerShellProcess["WorkingDirectory"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcessworkingDirectory);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcesscreateNoWindow != null)
            {
                if (runPowerShellProcesscreateNoWindow != null)
                {
                    runPowerShellProcess["CreateNoWindow"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcesscreateNoWindow);
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
                    runPowerShellProcess["WindowStyle"] = CSharpExpressionConverter.Convert(runPowerShellProcesswindowStyle);
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
                    runPowerShellProcess["WaitForProcess"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcesswaitForProcess);
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
                    runPowerShellProcess["RedirectStandardOutput"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcessredirectStandardOutput);
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
                    runPowerShellProcess["RedirectStandardError"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcessredirectStandardError);
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
                    runPowerShellProcess["RedirectStandardErrorToOutput"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcessredirectStandardErrorToOutput);
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
                runPowerShellProcess["StandardOutputEncoding"] = CSharpExpressionConverter.Convert(runPowerShellProcessstandardOutputEncoding);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessstandardErrorEncoding != null)
            {
                runPowerShellProcess["StandardErrorEncoding"] = CSharpExpressionConverter.Convert(runPowerShellProcessstandardErrorEncoding);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessrunAsDomain != null)
            {
                runPowerShellProcess["RunAsDomain"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcessrunAsDomain);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessrunAsUsername != null)
            {
                runPowerShellProcess["RunAsUsername"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcessrunAsUsername);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessrunAsPassword != null)
            {
                runPowerShellProcess["RunAsPassword"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcessrunAsPassword);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessrunAsLoadUserProfile != null)
            {
                if (runPowerShellProcessrunAsLoadUserProfile != null)
                {
                    runPowerShellProcess["RunAsLoadUserProfile"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcessrunAsLoadUserProfile);
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
                    runPowerShellProcess["RunAsElevate"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcessrunAsElevate);
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
                    runPowerShellProcess["TimeoutInSeconds"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcesstimeoutInSeconds);
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
                runPowerShellProcess["PowerShellScriptTempFolder"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcesspowerShellScriptTempFolder);
                runPowerShellProcesspropCount++;
            }

            runPowerShellProcesspropCount++;
            runPowerShellProcess["Workflow"] = CSharpExpressionConverter.ConvertToken(runPowerShellProcessworkflow);
            if (runPowerShellProcesspropCount > 0)
            {
                callPayload.Body = runPowerShellProcess;
            }

            return new ApiConnectionAction<RunPowerShellProcessResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetScreenResolutionResponse> GetScreenResolution(Expression<Func<string>> getScreenResolutionworkflow)
        {
            var apiCallPath = "/Environment/GetScreenResolution";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getScreenResolution = new JObject();
            var getScreenResolutionpropCount = 0;
            getScreenResolutionpropCount++;
            getScreenResolution["Workflow"] = CSharpExpressionConverter.ConvertToken(getScreenResolutionworkflow);
            if (getScreenResolutionpropCount > 0)
            {
                callPayload.Body = getScreenResolution;
            }

            return new ApiConnectionAction<GetScreenResolutionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetDefaultPrinter(Expression<Func<string>> setDefaultPrinterdefaultPrinterName, Expression<Func<string>> setDefaultPrinterworkflow)
        {
            var apiCallPath = "/Environment/SetDefaultPrinter";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setDefaultPrinter = new JObject();
            var setDefaultPrinterpropCount = 0;
            setDefaultPrinterpropCount++;
            setDefaultPrinter["DefaultPrinterName"] = CSharpExpressionConverter.ConvertToken(setDefaultPrinterdefaultPrinterName);
            setDefaultPrinterpropCount++;
            setDefaultPrinter["Workflow"] = CSharpExpressionConverter.ConvertToken(setDefaultPrinterworkflow);
            if (setDefaultPrinterpropCount > 0)
            {
                callPayload.Body = setDefaultPrinter;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDefaultPrinterResponse> GetDefaultPrinter(Expression<Func<string>> getDefaultPrinterworkflow)
        {
            var apiCallPath = "/Environment/GetDefaultPrinter";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getDefaultPrinter = new JObject();
            var getDefaultPrinterpropCount = 0;
            getDefaultPrinterpropCount++;
            getDefaultPrinter["Workflow"] = CSharpExpressionConverter.ConvertToken(getDefaultPrinterworkflow);
            if (getDefaultPrinterpropCount > 0)
            {
                callPayload.Body = getDefaultPrinter;
            }

            return new ApiConnectionAction<GetDefaultPrinterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfPrintersResponse> GetListOfPrinters(Expression<Func<string>> getListOfPrintersworkflow, Expression<Func<bool>> getListOfPrinterslistLocalPrinters = null, Expression<Func<bool>> getListOfPrinterslistNetworkPrinters = null, Expression<Func<bool>> getListOfPrintersreturnDetailedInformation = null)
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
                    getListOfPrinters["ListLocalPrinters"] = CSharpExpressionConverter.ConvertToken(getListOfPrinterslistLocalPrinters);
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
                    getListOfPrinters["ListNetworkPrinters"] = CSharpExpressionConverter.ConvertToken(getListOfPrinterslistNetworkPrinters);
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
                    getListOfPrinters["ReturnDetailedInformation"] = CSharpExpressionConverter.ConvertToken(getListOfPrintersreturnDetailedInformation);
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
            getListOfPrinters["Workflow"] = CSharpExpressionConverter.ConvertToken(getListOfPrintersworkflow);
            if (getListOfPrinterspropCount > 0)
            {
                callPayload.Body = getListOfPrinters;
            }

            return new ApiConnectionAction<GetListOfPrintersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetMouseMultiplier(Expression<Func<string>> setMouseMultiplierworkflow, Expression<Func<double>> setMouseMultipliermouseXMultiplier = null, Expression<Func<double>> setMouseMultipliermouseYMultiplier = null, Expression<Func<bool>> setMouseMultiplierapplyToMouseEvent = null, Expression<Func<bool>> setMouseMultiplierapplyToSetCursorPos = null, Expression<Func<bool>> setMouseMultiplierapplyToCurrentMouseMoveMethod = null)
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
                    setMouseMultiplier["MouseXMultiplier"] = CSharpExpressionConverter.ConvertToken(setMouseMultipliermouseXMultiplier);
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
                    setMouseMultiplier["MouseYMultiplier"] = CSharpExpressionConverter.ConvertToken(setMouseMultipliermouseYMultiplier);
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
                    setMouseMultiplier["ApplyToMouseEvent"] = CSharpExpressionConverter.ConvertToken(setMouseMultiplierapplyToMouseEvent);
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
                    setMouseMultiplier["ApplyToSetCursorPos"] = CSharpExpressionConverter.ConvertToken(setMouseMultiplierapplyToSetCursorPos);
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
                    setMouseMultiplier["ApplyToCurrentMouseMoveMethod"] = CSharpExpressionConverter.ConvertToken(setMouseMultiplierapplyToCurrentMouseMoveMethod);
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
            setMouseMultiplier["Workflow"] = CSharpExpressionConverter.ConvertToken(setMouseMultiplierworkflow);
            if (setMouseMultiplierpropCount > 0)
            {
                callPayload.Body = setMouseMultiplier;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMouseMultiplierResponse> GetMouseMultiplier(Expression<Func<string>> getMouseMultiplierworkflow)
        {
            var apiCallPath = "/Environment/GetMouseMultiplier";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getMouseMultiplier = new JObject();
            var getMouseMultiplierpropCount = 0;
            getMouseMultiplierpropCount++;
            getMouseMultiplier["Workflow"] = CSharpExpressionConverter.ConvertToken(getMouseMultiplierworkflow);
            if (getMouseMultiplierpropCount > 0)
            {
                callPayload.Body = getMouseMultiplier;
            }

            return new ApiConnectionAction<GetMouseMultiplierResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseToCoordinate(Expression<Func<int>> moveMouseToCoordinatexCoord, Expression<Func<int>> moveMouseToCoordinateyCoord, Expression<Func<string>> moveMouseToCoordinateworkflow)
        {
            var apiCallPath = "/Environment/MoveMouseToCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var moveMouseToCoordinate = new JObject();
            var moveMouseToCoordinatepropCount = 0;
            moveMouseToCoordinatepropCount++;
            moveMouseToCoordinate["XCoord"] = CSharpExpressionConverter.ConvertToken(moveMouseToCoordinatexCoord);
            moveMouseToCoordinatepropCount++;
            moveMouseToCoordinate["YCoord"] = CSharpExpressionConverter.ConvertToken(moveMouseToCoordinateyCoord);
            moveMouseToCoordinatepropCount++;
            moveMouseToCoordinate["Workflow"] = CSharpExpressionConverter.ConvertToken(moveMouseToCoordinateworkflow);
            if (moveMouseToCoordinatepropCount > 0)
            {
                callPayload.Body = moveMouseToCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseRelative(Expression<Func<int>> moveMouseRelativexCoord, Expression<Func<int>> moveMouseRelativeyCoord, Expression<Func<string>> moveMouseRelativeworkflow)
        {
            var apiCallPath = "/Environment/MoveMouseRelative";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var moveMouseRelative = new JObject();
            var moveMouseRelativepropCount = 0;
            moveMouseRelativepropCount++;
            moveMouseRelative["XCoord"] = CSharpExpressionConverter.ConvertToken(moveMouseRelativexCoord);
            moveMouseRelativepropCount++;
            moveMouseRelative["YCoord"] = CSharpExpressionConverter.ConvertToken(moveMouseRelativeyCoord);
            moveMouseRelativepropCount++;
            moveMouseRelative["Workflow"] = CSharpExpressionConverter.ConvertToken(moveMouseRelativeworkflow);
            if (moveMouseRelativepropCount > 0)
            {
                callPayload.Body = moveMouseRelative;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseButtonDown(Expression<Func<string>> leftMouseButtonDownworkflow)
        {
            var apiCallPath = "/Environment/LeftMouseButtonDown";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var leftMouseButtonDown = new JObject();
            var leftMouseButtonDownpropCount = 0;
            leftMouseButtonDownpropCount++;
            leftMouseButtonDown["Workflow"] = CSharpExpressionConverter.ConvertToken(leftMouseButtonDownworkflow);
            if (leftMouseButtonDownpropCount > 0)
            {
                callPayload.Body = leftMouseButtonDown;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseButtonUp(Expression<Func<string>> leftMouseButtonUpworkflow)
        {
            var apiCallPath = "/Environment/LeftMouseButtonUp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var leftMouseButtonUp = new JObject();
            var leftMouseButtonUppropCount = 0;
            leftMouseButtonUppropCount++;
            leftMouseButtonUp["Workflow"] = CSharpExpressionConverter.ConvertToken(leftMouseButtonUpworkflow);
            if (leftMouseButtonUppropCount > 0)
            {
                callPayload.Body = leftMouseButtonUp;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftClickMouse(Expression<Func<string>> leftClickMouseworkflow)
        {
            var apiCallPath = "/Environment/LeftClickMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var leftClickMouse = new JObject();
            var leftClickMousepropCount = 0;
            leftClickMousepropCount++;
            leftClickMouse["Workflow"] = CSharpExpressionConverter.ConvertToken(leftClickMouseworkflow);
            if (leftClickMousepropCount > 0)
            {
                callPayload.Body = leftClickMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftClickMouseAtCoordinate(Expression<Func<int>> leftClickMouseAtCoordinatexCoord, Expression<Func<int>> leftClickMouseAtCoordinateyCoord, Expression<Func<string>> leftClickMouseAtCoordinateworkflow)
        {
            var apiCallPath = "/Environment/LeftClickMouseAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var leftClickMouseAtCoordinate = new JObject();
            var leftClickMouseAtCoordinatepropCount = 0;
            leftClickMouseAtCoordinatepropCount++;
            leftClickMouseAtCoordinate["XCoord"] = CSharpExpressionConverter.ConvertToken(leftClickMouseAtCoordinatexCoord);
            leftClickMouseAtCoordinatepropCount++;
            leftClickMouseAtCoordinate["YCoord"] = CSharpExpressionConverter.ConvertToken(leftClickMouseAtCoordinateyCoord);
            leftClickMouseAtCoordinatepropCount++;
            leftClickMouseAtCoordinate["Workflow"] = CSharpExpressionConverter.ConvertToken(leftClickMouseAtCoordinateworkflow);
            if (leftClickMouseAtCoordinatepropCount > 0)
            {
                callPayload.Body = leftClickMouseAtCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftHoldMouse(Expression<Func<double>> leftHoldMousesecondsToHold, Expression<Func<string>> leftHoldMouseworkflow)
        {
            var apiCallPath = "/Environment/LeftHoldMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var leftHoldMouse = new JObject();
            var leftHoldMousepropCount = 0;
            leftHoldMousepropCount++;
            leftHoldMouse["SecondsToHold"] = CSharpExpressionConverter.ConvertToken(leftHoldMousesecondsToHold);
            leftHoldMousepropCount++;
            leftHoldMouse["Workflow"] = CSharpExpressionConverter.ConvertToken(leftHoldMouseworkflow);
            if (leftHoldMousepropCount > 0)
            {
                callPayload.Body = leftHoldMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftHoldMouseAtCoordinate(Expression<Func<int>> leftHoldMouseAtCoordinatexCoord, Expression<Func<int>> leftHoldMouseAtCoordinateyCoord, Expression<Func<double>> leftHoldMouseAtCoordinatesecondsToHold, Expression<Func<string>> leftHoldMouseAtCoordinateworkflow)
        {
            var apiCallPath = "/Environment/LeftHoldMouseAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var leftHoldMouseAtCoordinate = new JObject();
            var leftHoldMouseAtCoordinatepropCount = 0;
            leftHoldMouseAtCoordinatepropCount++;
            leftHoldMouseAtCoordinate["XCoord"] = CSharpExpressionConverter.ConvertToken(leftHoldMouseAtCoordinatexCoord);
            leftHoldMouseAtCoordinatepropCount++;
            leftHoldMouseAtCoordinate["YCoord"] = CSharpExpressionConverter.ConvertToken(leftHoldMouseAtCoordinateyCoord);
            leftHoldMouseAtCoordinatepropCount++;
            leftHoldMouseAtCoordinate["SecondsToHold"] = CSharpExpressionConverter.ConvertToken(leftHoldMouseAtCoordinatesecondsToHold);
            leftHoldMouseAtCoordinatepropCount++;
            leftHoldMouseAtCoordinate["Workflow"] = CSharpExpressionConverter.ConvertToken(leftHoldMouseAtCoordinateworkflow);
            if (leftHoldMouseAtCoordinatepropCount > 0)
            {
                callPayload.Body = leftHoldMouseAtCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseButtonDown(Expression<Func<string>> rightMouseButtonDownworkflow)
        {
            var apiCallPath = "/Environment/RightMouseButtonDown";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rightMouseButtonDown = new JObject();
            var rightMouseButtonDownpropCount = 0;
            rightMouseButtonDownpropCount++;
            rightMouseButtonDown["Workflow"] = CSharpExpressionConverter.ConvertToken(rightMouseButtonDownworkflow);
            if (rightMouseButtonDownpropCount > 0)
            {
                callPayload.Body = rightMouseButtonDown;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseButtonUp(Expression<Func<string>> rightMouseButtonUpworkflow)
        {
            var apiCallPath = "/Environment/RightMouseButtonUp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rightMouseButtonUp = new JObject();
            var rightMouseButtonUppropCount = 0;
            rightMouseButtonUppropCount++;
            rightMouseButtonUp["Workflow"] = CSharpExpressionConverter.ConvertToken(rightMouseButtonUpworkflow);
            if (rightMouseButtonUppropCount > 0)
            {
                callPayload.Body = rightMouseButtonUp;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightClickMouse(Expression<Func<string>> rightClickMouseworkflow)
        {
            var apiCallPath = "/Environment/RightClickMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rightClickMouse = new JObject();
            var rightClickMousepropCount = 0;
            rightClickMousepropCount++;
            rightClickMouse["Workflow"] = CSharpExpressionConverter.ConvertToken(rightClickMouseworkflow);
            if (rightClickMousepropCount > 0)
            {
                callPayload.Body = rightClickMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightClickMouseAtCoordinate(Expression<Func<int>> rightClickMouseAtCoordinatexCoord, Expression<Func<int>> rightClickMouseAtCoordinateyCoord, Expression<Func<string>> rightClickMouseAtCoordinateworkflow)
        {
            var apiCallPath = "/Environment/RightClickMouseAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rightClickMouseAtCoordinate = new JObject();
            var rightClickMouseAtCoordinatepropCount = 0;
            rightClickMouseAtCoordinatepropCount++;
            rightClickMouseAtCoordinate["XCoord"] = CSharpExpressionConverter.ConvertToken(rightClickMouseAtCoordinatexCoord);
            rightClickMouseAtCoordinatepropCount++;
            rightClickMouseAtCoordinate["YCoord"] = CSharpExpressionConverter.ConvertToken(rightClickMouseAtCoordinateyCoord);
            rightClickMouseAtCoordinatepropCount++;
            rightClickMouseAtCoordinate["Workflow"] = CSharpExpressionConverter.ConvertToken(rightClickMouseAtCoordinateworkflow);
            if (rightClickMouseAtCoordinatepropCount > 0)
            {
                callPayload.Body = rightClickMouseAtCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightHoldMouse(Expression<Func<double>> rightHoldMousesecondsToHold, Expression<Func<string>> rightHoldMouseworkflow)
        {
            var apiCallPath = "/Environment/RightHoldMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rightHoldMouse = new JObject();
            var rightHoldMousepropCount = 0;
            rightHoldMousepropCount++;
            rightHoldMouse["SecondsToHold"] = CSharpExpressionConverter.ConvertToken(rightHoldMousesecondsToHold);
            rightHoldMousepropCount++;
            rightHoldMouse["Workflow"] = CSharpExpressionConverter.ConvertToken(rightHoldMouseworkflow);
            if (rightHoldMousepropCount > 0)
            {
                callPayload.Body = rightHoldMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightHoldMouseAtCoordinate(Expression<Func<int>> rightHoldMouseAtCoordinatexCoord, Expression<Func<int>> rightHoldMouseAtCoordinateyCoord, Expression<Func<double>> rightHoldMouseAtCoordinatesecondsToHold, Expression<Func<string>> rightHoldMouseAtCoordinateworkflow)
        {
            var apiCallPath = "/Environment/RightHoldMouseAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rightHoldMouseAtCoordinate = new JObject();
            var rightHoldMouseAtCoordinatepropCount = 0;
            rightHoldMouseAtCoordinatepropCount++;
            rightHoldMouseAtCoordinate["XCoord"] = CSharpExpressionConverter.ConvertToken(rightHoldMouseAtCoordinatexCoord);
            rightHoldMouseAtCoordinatepropCount++;
            rightHoldMouseAtCoordinate["YCoord"] = CSharpExpressionConverter.ConvertToken(rightHoldMouseAtCoordinateyCoord);
            rightHoldMouseAtCoordinatepropCount++;
            rightHoldMouseAtCoordinate["SecondsToHold"] = CSharpExpressionConverter.ConvertToken(rightHoldMouseAtCoordinatesecondsToHold);
            rightHoldMouseAtCoordinatepropCount++;
            rightHoldMouseAtCoordinate["Workflow"] = CSharpExpressionConverter.ConvertToken(rightHoldMouseAtCoordinateworkflow);
            if (rightHoldMouseAtCoordinatepropCount > 0)
            {
                callPayload.Body = rightHoldMouseAtCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseButtonDown(Expression<Func<string>> middleMouseButtonDownworkflow)
        {
            var apiCallPath = "/Environment/MiddleMouseButtonDown";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var middleMouseButtonDown = new JObject();
            var middleMouseButtonDownpropCount = 0;
            middleMouseButtonDownpropCount++;
            middleMouseButtonDown["Workflow"] = CSharpExpressionConverter.ConvertToken(middleMouseButtonDownworkflow);
            if (middleMouseButtonDownpropCount > 0)
            {
                callPayload.Body = middleMouseButtonDown;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseButtonUp(Expression<Func<string>> middleMouseButtonUpworkflow)
        {
            var apiCallPath = "/Environment/MiddleMouseButtonUp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var middleMouseButtonUp = new JObject();
            var middleMouseButtonUppropCount = 0;
            middleMouseButtonUppropCount++;
            middleMouseButtonUp["Workflow"] = CSharpExpressionConverter.ConvertToken(middleMouseButtonUpworkflow);
            if (middleMouseButtonUppropCount > 0)
            {
                callPayload.Body = middleMouseButtonUp;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleClickMouse(Expression<Func<string>> middleClickMouseworkflow)
        {
            var apiCallPath = "/Environment/MiddleClickMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var middleClickMouse = new JObject();
            var middleClickMousepropCount = 0;
            middleClickMousepropCount++;
            middleClickMouse["Workflow"] = CSharpExpressionConverter.ConvertToken(middleClickMouseworkflow);
            if (middleClickMousepropCount > 0)
            {
                callPayload.Body = middleClickMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleClickMouseAtCoordinate(Expression<Func<int>> middleClickMouseAtCoordinatexCoord, Expression<Func<int>> middleClickMouseAtCoordinateyCoord, Expression<Func<string>> middleClickMouseAtCoordinateworkflow)
        {
            var apiCallPath = "/Environment/MiddleClickMouseAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var middleClickMouseAtCoordinate = new JObject();
            var middleClickMouseAtCoordinatepropCount = 0;
            middleClickMouseAtCoordinatepropCount++;
            middleClickMouseAtCoordinate["XCoord"] = CSharpExpressionConverter.ConvertToken(middleClickMouseAtCoordinatexCoord);
            middleClickMouseAtCoordinatepropCount++;
            middleClickMouseAtCoordinate["YCoord"] = CSharpExpressionConverter.ConvertToken(middleClickMouseAtCoordinateyCoord);
            middleClickMouseAtCoordinatepropCount++;
            middleClickMouseAtCoordinate["Workflow"] = CSharpExpressionConverter.ConvertToken(middleClickMouseAtCoordinateworkflow);
            if (middleClickMouseAtCoordinatepropCount > 0)
            {
                callPayload.Body = middleClickMouseAtCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleHoldMouse(Expression<Func<double>> middleHoldMousesecondsToHold, Expression<Func<string>> middleHoldMouseworkflow)
        {
            var apiCallPath = "/Environment/MiddleHoldMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var middleHoldMouse = new JObject();
            var middleHoldMousepropCount = 0;
            middleHoldMousepropCount++;
            middleHoldMouse["SecondsToHold"] = CSharpExpressionConverter.ConvertToken(middleHoldMousesecondsToHold);
            middleHoldMousepropCount++;
            middleHoldMouse["Workflow"] = CSharpExpressionConverter.ConvertToken(middleHoldMouseworkflow);
            if (middleHoldMousepropCount > 0)
            {
                callPayload.Body = middleHoldMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleHoldMouseAtCoordinate(Expression<Func<int>> middleHoldMouseAtCoordinatexCoord, Expression<Func<int>> middleHoldMouseAtCoordinateyCoord, Expression<Func<double>> middleHoldMouseAtCoordinatesecondsToHold, Expression<Func<string>> middleHoldMouseAtCoordinateworkflow)
        {
            var apiCallPath = "/Environment/MiddleHoldMouseAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var middleHoldMouseAtCoordinate = new JObject();
            var middleHoldMouseAtCoordinatepropCount = 0;
            middleHoldMouseAtCoordinatepropCount++;
            middleHoldMouseAtCoordinate["XCoord"] = CSharpExpressionConverter.ConvertToken(middleHoldMouseAtCoordinatexCoord);
            middleHoldMouseAtCoordinatepropCount++;
            middleHoldMouseAtCoordinate["YCoord"] = CSharpExpressionConverter.ConvertToken(middleHoldMouseAtCoordinateyCoord);
            middleHoldMouseAtCoordinatepropCount++;
            middleHoldMouseAtCoordinate["SecondsToHold"] = CSharpExpressionConverter.ConvertToken(middleHoldMouseAtCoordinatesecondsToHold);
            middleHoldMouseAtCoordinatepropCount++;
            middleHoldMouseAtCoordinate["Workflow"] = CSharpExpressionConverter.ConvertToken(middleHoldMouseAtCoordinateworkflow);
            if (middleHoldMouseAtCoordinatepropCount > 0)
            {
                callPayload.Body = middleHoldMouseAtCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DoubleLeftClickMouse(Expression<Func<string>> doubleLeftClickMouseworkflow, Expression<Func<int>> doubleLeftClickMousedelayInMilliseconds = null)
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
                    doubleLeftClickMouse["DelayInMilliseconds"] = CSharpExpressionConverter.ConvertToken(doubleLeftClickMousedelayInMilliseconds);
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
            doubleLeftClickMouse["Workflow"] = CSharpExpressionConverter.ConvertToken(doubleLeftClickMouseworkflow);
            if (doubleLeftClickMousepropCount > 0)
            {
                callPayload.Body = doubleLeftClickMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DoubleLeftClickMouseAtCoordinate(Expression<Func<int>> doubleLeftClickMouseAtCoordinatexCoord, Expression<Func<int>> doubleLeftClickMouseAtCoordinateyCoord, Expression<Func<string>> doubleLeftClickMouseAtCoordinateworkflow, Expression<Func<int>> doubleLeftClickMouseAtCoordinatedelayInMilliseconds = null)
        {
            var apiCallPath = "/Environment/DoubleLeftClickMouseAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var doubleLeftClickMouseAtCoordinate = new JObject();
            var doubleLeftClickMouseAtCoordinatepropCount = 0;
            doubleLeftClickMouseAtCoordinatepropCount++;
            doubleLeftClickMouseAtCoordinate["XCoord"] = CSharpExpressionConverter.ConvertToken(doubleLeftClickMouseAtCoordinatexCoord);
            doubleLeftClickMouseAtCoordinatepropCount++;
            doubleLeftClickMouseAtCoordinate["YCoord"] = CSharpExpressionConverter.ConvertToken(doubleLeftClickMouseAtCoordinateyCoord);
            if (doubleLeftClickMouseAtCoordinatedelayInMilliseconds != null)
            {
                if (doubleLeftClickMouseAtCoordinatedelayInMilliseconds != null)
                {
                    doubleLeftClickMouseAtCoordinate["DelayInMilliseconds"] = CSharpExpressionConverter.ConvertToken(doubleLeftClickMouseAtCoordinatedelayInMilliseconds);
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
            doubleLeftClickMouseAtCoordinate["Workflow"] = CSharpExpressionConverter.ConvertToken(doubleLeftClickMouseAtCoordinateworkflow);
            if (doubleLeftClickMouseAtCoordinatepropCount > 0)
            {
                callPayload.Body = doubleLeftClickMouseAtCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseDragBetweenCoordinates(Expression<Func<int>> leftMouseDragBetweenCoordinatesstartXCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesstartYCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesendXCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesendYCoord, Expression<Func<string>> leftMouseDragBetweenCoordinatesworkflow, Expression<Func<int>> leftMouseDragBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> leftMouseDragBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            var apiCallPath = "/Environment/LeftMouseDragBetweenCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var leftMouseDragBetweenCoordinates = new JObject();
            var leftMouseDragBetweenCoordinatespropCount = 0;
            leftMouseDragBetweenCoordinatespropCount++;
            leftMouseDragBetweenCoordinates["StartXCoord"] = CSharpExpressionConverter.ConvertToken(leftMouseDragBetweenCoordinatesstartXCoord);
            leftMouseDragBetweenCoordinatespropCount++;
            leftMouseDragBetweenCoordinates["StartYCoord"] = CSharpExpressionConverter.ConvertToken(leftMouseDragBetweenCoordinatesstartYCoord);
            leftMouseDragBetweenCoordinatespropCount++;
            leftMouseDragBetweenCoordinates["EndXCoord"] = CSharpExpressionConverter.ConvertToken(leftMouseDragBetweenCoordinatesendXCoord);
            leftMouseDragBetweenCoordinatespropCount++;
            leftMouseDragBetweenCoordinates["EndYCoord"] = CSharpExpressionConverter.ConvertToken(leftMouseDragBetweenCoordinatesendYCoord);
            if (leftMouseDragBetweenCoordinatesnumberOfSteps != null)
            {
                if (leftMouseDragBetweenCoordinatesnumberOfSteps != null)
                {
                    leftMouseDragBetweenCoordinates["NumberOfSteps"] = CSharpExpressionConverter.ConvertToken(leftMouseDragBetweenCoordinatesnumberOfSteps);
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
                    leftMouseDragBetweenCoordinates["TotalTimeInSeconds"] = CSharpExpressionConverter.ConvertToken(leftMouseDragBetweenCoordinatestotalTimeInSeconds);
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
                leftMouseDragBetweenCoordinates["MaximumMovementPixelJitter"] = CSharpExpressionConverter.ConvertToken(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter);
                leftMouseDragBetweenCoordinatespropCount++;
            }

            if (leftMouseDragBetweenCoordinatesmaximumEndPixelJitter != null)
            {
                leftMouseDragBetweenCoordinates["MaximumEndPixelJitter"] = CSharpExpressionConverter.ConvertToken(leftMouseDragBetweenCoordinatesmaximumEndPixelJitter);
                leftMouseDragBetweenCoordinatespropCount++;
            }

            if (leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
            {
                if (leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                {
                    leftMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = CSharpExpressionConverter.ConvertToken(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
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
            leftMouseDragBetweenCoordinates["Workflow"] = CSharpExpressionConverter.ConvertToken(leftMouseDragBetweenCoordinatesworkflow);
            if (leftMouseDragBetweenCoordinatespropCount > 0)
            {
                callPayload.Body = leftMouseDragBetweenCoordinates;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseDragBetweenCoordinates(Expression<Func<int>> rightMouseDragBetweenCoordinatesstartXCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesstartYCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesendXCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesendYCoord, Expression<Func<string>> rightMouseDragBetweenCoordinatesworkflow, Expression<Func<int>> rightMouseDragBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> rightMouseDragBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            var apiCallPath = "/Environment/RightMouseDragBetweenCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rightMouseDragBetweenCoordinates = new JObject();
            var rightMouseDragBetweenCoordinatespropCount = 0;
            rightMouseDragBetweenCoordinatespropCount++;
            rightMouseDragBetweenCoordinates["StartXCoord"] = CSharpExpressionConverter.ConvertToken(rightMouseDragBetweenCoordinatesstartXCoord);
            rightMouseDragBetweenCoordinatespropCount++;
            rightMouseDragBetweenCoordinates["StartYCoord"] = CSharpExpressionConverter.ConvertToken(rightMouseDragBetweenCoordinatesstartYCoord);
            rightMouseDragBetweenCoordinatespropCount++;
            rightMouseDragBetweenCoordinates["EndXCoord"] = CSharpExpressionConverter.ConvertToken(rightMouseDragBetweenCoordinatesendXCoord);
            rightMouseDragBetweenCoordinatespropCount++;
            rightMouseDragBetweenCoordinates["EndYCoord"] = CSharpExpressionConverter.ConvertToken(rightMouseDragBetweenCoordinatesendYCoord);
            if (rightMouseDragBetweenCoordinatesnumberOfSteps != null)
            {
                if (rightMouseDragBetweenCoordinatesnumberOfSteps != null)
                {
                    rightMouseDragBetweenCoordinates["NumberOfSteps"] = CSharpExpressionConverter.ConvertToken(rightMouseDragBetweenCoordinatesnumberOfSteps);
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
                    rightMouseDragBetweenCoordinates["TotalTimeInSeconds"] = CSharpExpressionConverter.ConvertToken(rightMouseDragBetweenCoordinatestotalTimeInSeconds);
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
                rightMouseDragBetweenCoordinates["MaximumMovementPixelJitter"] = CSharpExpressionConverter.ConvertToken(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter);
                rightMouseDragBetweenCoordinatespropCount++;
            }

            if (rightMouseDragBetweenCoordinatesmaximumEndPixelJitter != null)
            {
                rightMouseDragBetweenCoordinates["MaximumEndPixelJitter"] = CSharpExpressionConverter.ConvertToken(rightMouseDragBetweenCoordinatesmaximumEndPixelJitter);
                rightMouseDragBetweenCoordinatespropCount++;
            }

            if (rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
            {
                if (rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                {
                    rightMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = CSharpExpressionConverter.ConvertToken(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
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
            rightMouseDragBetweenCoordinates["Workflow"] = CSharpExpressionConverter.ConvertToken(rightMouseDragBetweenCoordinatesworkflow);
            if (rightMouseDragBetweenCoordinatespropCount > 0)
            {
                callPayload.Body = rightMouseDragBetweenCoordinates;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseDragBetweenCoordinates(Expression<Func<int>> middleMouseDragBetweenCoordinatesstartXCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesstartYCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesendXCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesendYCoord, Expression<Func<string>> middleMouseDragBetweenCoordinatesworkflow, Expression<Func<int>> middleMouseDragBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> middleMouseDragBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            var apiCallPath = "/Environment/MiddleMouseDragBetweenCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var middleMouseDragBetweenCoordinates = new JObject();
            var middleMouseDragBetweenCoordinatespropCount = 0;
            middleMouseDragBetweenCoordinatespropCount++;
            middleMouseDragBetweenCoordinates["StartXCoord"] = CSharpExpressionConverter.ConvertToken(middleMouseDragBetweenCoordinatesstartXCoord);
            middleMouseDragBetweenCoordinatespropCount++;
            middleMouseDragBetweenCoordinates["StartYCoord"] = CSharpExpressionConverter.ConvertToken(middleMouseDragBetweenCoordinatesstartYCoord);
            middleMouseDragBetweenCoordinatespropCount++;
            middleMouseDragBetweenCoordinates["EndXCoord"] = CSharpExpressionConverter.ConvertToken(middleMouseDragBetweenCoordinatesendXCoord);
            middleMouseDragBetweenCoordinatespropCount++;
            middleMouseDragBetweenCoordinates["EndYCoord"] = CSharpExpressionConverter.ConvertToken(middleMouseDragBetweenCoordinatesendYCoord);
            if (middleMouseDragBetweenCoordinatesnumberOfSteps != null)
            {
                if (middleMouseDragBetweenCoordinatesnumberOfSteps != null)
                {
                    middleMouseDragBetweenCoordinates["NumberOfSteps"] = CSharpExpressionConverter.ConvertToken(middleMouseDragBetweenCoordinatesnumberOfSteps);
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
                    middleMouseDragBetweenCoordinates["TotalTimeInSeconds"] = CSharpExpressionConverter.ConvertToken(middleMouseDragBetweenCoordinatestotalTimeInSeconds);
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
                middleMouseDragBetweenCoordinates["MaximumMovementPixelJitter"] = CSharpExpressionConverter.ConvertToken(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter);
                middleMouseDragBetweenCoordinatespropCount++;
            }

            if (middleMouseDragBetweenCoordinatesmaximumEndPixelJitter != null)
            {
                middleMouseDragBetweenCoordinates["MaximumEndPixelJitter"] = CSharpExpressionConverter.ConvertToken(middleMouseDragBetweenCoordinatesmaximumEndPixelJitter);
                middleMouseDragBetweenCoordinatespropCount++;
            }

            if (middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
            {
                if (middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                {
                    middleMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = CSharpExpressionConverter.ConvertToken(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
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
            middleMouseDragBetweenCoordinates["Workflow"] = CSharpExpressionConverter.ConvertToken(middleMouseDragBetweenCoordinatesworkflow);
            if (middleMouseDragBetweenCoordinatespropCount > 0)
            {
                callPayload.Body = middleMouseDragBetweenCoordinates;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseBetweenCoordinates(Expression<Func<int>> moveMouseBetweenCoordinatesstartXCoord, Expression<Func<int>> moveMouseBetweenCoordinatesstartYCoord, Expression<Func<int>> moveMouseBetweenCoordinatesendXCoord, Expression<Func<int>> moveMouseBetweenCoordinatesendYCoord, Expression<Func<string>> moveMouseBetweenCoordinatesworkflow, Expression<Func<int>> moveMouseBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> moveMouseBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> moveMouseBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> moveMouseBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
        {
            var apiCallPath = "/Environment/MoveMouseBetweenCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var moveMouseBetweenCoordinates = new JObject();
            var moveMouseBetweenCoordinatespropCount = 0;
            moveMouseBetweenCoordinatespropCount++;
            moveMouseBetweenCoordinates["StartXCoord"] = CSharpExpressionConverter.ConvertToken(moveMouseBetweenCoordinatesstartXCoord);
            moveMouseBetweenCoordinatespropCount++;
            moveMouseBetweenCoordinates["StartYCoord"] = CSharpExpressionConverter.ConvertToken(moveMouseBetweenCoordinatesstartYCoord);
            moveMouseBetweenCoordinatespropCount++;
            moveMouseBetweenCoordinates["EndXCoord"] = CSharpExpressionConverter.ConvertToken(moveMouseBetweenCoordinatesendXCoord);
            moveMouseBetweenCoordinatespropCount++;
            moveMouseBetweenCoordinates["EndYCoord"] = CSharpExpressionConverter.ConvertToken(moveMouseBetweenCoordinatesendYCoord);
            if (moveMouseBetweenCoordinatesnumberOfSteps != null)
            {
                if (moveMouseBetweenCoordinatesnumberOfSteps != null)
                {
                    moveMouseBetweenCoordinates["NumberOfSteps"] = CSharpExpressionConverter.ConvertToken(moveMouseBetweenCoordinatesnumberOfSteps);
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
                    moveMouseBetweenCoordinates["TotalTimeInSeconds"] = CSharpExpressionConverter.ConvertToken(moveMouseBetweenCoordinatestotalTimeInSeconds);
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
                moveMouseBetweenCoordinates["MaximumMovementPixelJitter"] = CSharpExpressionConverter.ConvertToken(moveMouseBetweenCoordinatesmaximumMovementPixelJitter);
                moveMouseBetweenCoordinatespropCount++;
            }

            if (moveMouseBetweenCoordinatesmaximumEndPixelJitter != null)
            {
                moveMouseBetweenCoordinates["MaximumEndPixelJitter"] = CSharpExpressionConverter.ConvertToken(moveMouseBetweenCoordinatesmaximumEndPixelJitter);
                moveMouseBetweenCoordinatespropCount++;
            }

            if (moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
            {
                if (moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta != null)
                {
                    moveMouseBetweenCoordinates["MaximumMovementPixelJitterDelta"] = CSharpExpressionConverter.ConvertToken(moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta);
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
            moveMouseBetweenCoordinates["Workflow"] = CSharpExpressionConverter.ConvertToken(moveMouseBetweenCoordinatesworkflow);
            if (moveMouseBetweenCoordinatespropCount > 0)
            {
                callPayload.Body = moveMouseBetweenCoordinates;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction TurnMouseWheel(Expression<Func<int>> turnMouseWheelwheelTurns, Expression<Func<string>> turnMouseWheelworkflow)
        {
            var apiCallPath = "/Environment/TurnMouseWheel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var turnMouseWheel = new JObject();
            var turnMouseWheelpropCount = 0;
            turnMouseWheelpropCount++;
            turnMouseWheel["WheelTurns"] = CSharpExpressionConverter.ConvertToken(turnMouseWheelwheelTurns);
            turnMouseWheelpropCount++;
            turnMouseWheel["Workflow"] = CSharpExpressionConverter.ConvertToken(turnMouseWheelworkflow);
            if (turnMouseWheelpropCount > 0)
            {
                callPayload.Body = turnMouseWheel;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetCursorPos(Expression<Func<int>> setCursorPosx, Expression<Func<int>> setCursorPosy, Expression<Func<string>> setCursorPosworkflow)
        {
            var apiCallPath = "/Environment/SetCursorPos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setCursorPos = new JObject();
            var setCursorPospropCount = 0;
            setCursorPospropCount++;
            setCursorPos["X"] = CSharpExpressionConverter.ConvertToken(setCursorPosx);
            setCursorPospropCount++;
            setCursorPos["Y"] = CSharpExpressionConverter.ConvertToken(setCursorPosy);
            setCursorPospropCount++;
            setCursorPos["Workflow"] = CSharpExpressionConverter.ConvertToken(setCursorPosworkflow);
            if (setCursorPospropCount > 0)
            {
                callPayload.Body = setCursorPos;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetCursorPosResponse> GetCursorPos(Expression<Func<string>> getCursorPosworkflow)
        {
            var apiCallPath = "/Environment/GetCursorPos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getCursorPos = new JObject();
            var getCursorPospropCount = 0;
            getCursorPospropCount++;
            getCursorPos["Workflow"] = CSharpExpressionConverter.ConvertToken(getCursorPosworkflow);
            if (getCursorPospropCount > 0)
            {
                callPayload.Body = getCursorPos;
            }

            return new ApiConnectionAction<GetCursorPosResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CalibrateMouseEventResponse> CalibrateMouseEvent(Expression<Func<string>> calibrateMouseEventworkflow, Expression<Func<int>> calibrateMouseEventcalibrationSizeInPixels = null)
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
                    calibrateMouseEvent["CalibrationSizeInPixels"] = CSharpExpressionConverter.ConvertToken(calibrateMouseEventcalibrationSizeInPixels);
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
            calibrateMouseEvent["Workflow"] = CSharpExpressionConverter.ConvertToken(calibrateMouseEventworkflow);
            if (calibrateMouseEventpropCount > 0)
            {
                callPayload.Body = calibrateMouseEvent;
            }

            return new ApiConnectionAction<CalibrateMouseEventResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMouseMoveMethodResponse> GetMouseMoveMethod(Expression<Func<string>> getMouseMoveMethodworkflow)
        {
            var apiCallPath = "/Environment/GetMouseMoveMethod";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getMouseMoveMethod = new JObject();
            var getMouseMoveMethodpropCount = 0;
            getMouseMoveMethodpropCount++;
            getMouseMoveMethod["Workflow"] = CSharpExpressionConverter.ConvertToken(getMouseMoveMethodworkflow);
            if (getMouseMoveMethodpropCount > 0)
            {
                callPayload.Body = getMouseMoveMethod;
            }

            return new ApiConnectionAction<GetMouseMoveMethodResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetMouseMoveMethod(Expression<Func<setMouseMoveMethodmouseMoveMethodInput>> setMouseMoveMethodmouseMoveMethod, Expression<Func<string>> setMouseMoveMethodworkflow)
        {
            var apiCallPath = "/Environment/SetMouseMoveMethod";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setMouseMoveMethod = new JObject();
            var setMouseMoveMethodpropCount = 0;
            setMouseMoveMethodpropCount++;
            setMouseMoveMethod["MouseMoveMethod"] = CSharpExpressionConverter.Convert(setMouseMoveMethodmouseMoveMethod);
            setMouseMoveMethodpropCount++;
            setMouseMoveMethod["Workflow"] = CSharpExpressionConverter.ConvertToken(setMouseMoveMethodworkflow);
            if (setMouseMoveMethodpropCount > 0)
            {
                callPayload.Body = setMouseMoveMethod;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WiggleMouse(Expression<Func<string>> wiggleMouseworkflow, Expression<Func<int>> wiggleMousexWiggle = null, Expression<Func<int>> wiggleMouseyWiggle = null, Expression<Func<double>> wiggleMousewiggleDelayInSeconds = null)
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
                    wiggleMouse["XWiggle"] = CSharpExpressionConverter.ConvertToken(wiggleMousexWiggle);
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
                wiggleMouse["YWiggle"] = CSharpExpressionConverter.ConvertToken(wiggleMouseyWiggle);
                wiggleMousepropCount++;
            }

            if (wiggleMousewiggleDelayInSeconds != null)
            {
                if (wiggleMousewiggleDelayInSeconds != null)
                {
                    wiggleMouse["WiggleDelayInSeconds"] = CSharpExpressionConverter.ConvertToken(wiggleMousewiggleDelayInSeconds);
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
            wiggleMouse["Workflow"] = CSharpExpressionConverter.ConvertToken(wiggleMouseworkflow);
            if (wiggleMousepropCount > 0)
            {
                callPayload.Body = wiggleMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendKeyEvents(Expression<Func<string>> sendKeyEventstext, Expression<Func<string>> sendKeyEventsworkflow, Expression<Func<int>> sendKeyEventsinterval = null, Expression<Func<bool>> sendKeyEventsisPassword = null, Expression<Func<bool>> sendKeyEventsdontInterpretSymbols = null)
        {
            var apiCallPath = "/Environment/SendKeyEvents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sendKeyEvents = new JObject();
            var sendKeyEventspropCount = 0;
            sendKeyEventspropCount++;
            sendKeyEvents["Text"] = CSharpExpressionConverter.ConvertToken(sendKeyEventstext);
            if (sendKeyEventsinterval != null)
            {
                if (sendKeyEventsinterval != null)
                {
                    sendKeyEvents["Interval"] = CSharpExpressionConverter.ConvertToken(sendKeyEventsinterval);
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
                    sendKeyEvents["IsPassword"] = CSharpExpressionConverter.ConvertToken(sendKeyEventsisPassword);
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
                    sendKeyEvents["DontInterpretSymbols"] = CSharpExpressionConverter.ConvertToken(sendKeyEventsdontInterpretSymbols);
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
            sendKeyEvents["Workflow"] = CSharpExpressionConverter.ConvertToken(sendKeyEventsworkflow);
            if (sendKeyEventspropCount > 0)
            {
                callPayload.Body = sendKeyEvents;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendPasswordKeyEvents(Expression<Func<string>> sendPasswordKeyEventspassword, Expression<Func<string>> sendPasswordKeyEventsworkflow, Expression<Func<int>> sendPasswordKeyEventsinterval = null, Expression<Func<bool>> sendPasswordKeyEventsdontInterpretSymbols = null, Expression<Func<bool>> sendPasswordKeyEventspasswordContainsStoredPassword = null)
        {
            var apiCallPath = "/Environment/SendPasswordKeyEvents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sendPasswordKeyEvents = new JObject();
            var sendPasswordKeyEventspropCount = 0;
            sendPasswordKeyEventspropCount++;
            sendPasswordKeyEvents["Password"] = CSharpExpressionConverter.ConvertToken(sendPasswordKeyEventspassword);
            if (sendPasswordKeyEventsinterval != null)
            {
                if (sendPasswordKeyEventsinterval != null)
                {
                    sendPasswordKeyEvents["Interval"] = CSharpExpressionConverter.ConvertToken(sendPasswordKeyEventsinterval);
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
                    sendPasswordKeyEvents["DontInterpretSymbols"] = CSharpExpressionConverter.ConvertToken(sendPasswordKeyEventsdontInterpretSymbols);
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
                    sendPasswordKeyEvents["PasswordContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(sendPasswordKeyEventspasswordContainsStoredPassword);
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
            sendPasswordKeyEvents["Workflow"] = CSharpExpressionConverter.ConvertToken(sendPasswordKeyEventsworkflow);
            if (sendPasswordKeyEventspropCount > 0)
            {
                callPayload.Body = sendPasswordKeyEvents;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendKeys(Expression<Func<string>> sendKeystext, Expression<Func<string>> sendKeysworkflow, Expression<Func<int>> sendKeysinterval = null, Expression<Func<bool>> sendKeysisPassword = null, Expression<Func<bool>> sendKeysdontInterpretSymbols = null)
        {
            var apiCallPath = "/Environment/SendKeys";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sendKeys = new JObject();
            var sendKeyspropCount = 0;
            sendKeyspropCount++;
            sendKeys["Text"] = CSharpExpressionConverter.ConvertToken(sendKeystext);
            if (sendKeysinterval != null)
            {
                if (sendKeysinterval != null)
                {
                    sendKeys["Interval"] = CSharpExpressionConverter.ConvertToken(sendKeysinterval);
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
                    sendKeys["IsPassword"] = CSharpExpressionConverter.ConvertToken(sendKeysisPassword);
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
                    sendKeys["DontInterpretSymbols"] = CSharpExpressionConverter.ConvertToken(sendKeysdontInterpretSymbols);
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
            sendKeys["Workflow"] = CSharpExpressionConverter.ConvertToken(sendKeysworkflow);
            if (sendKeyspropCount > 0)
            {
                callPayload.Body = sendKeys;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendPasswordKeys(Expression<Func<string>> sendPasswordKeyspassword, Expression<Func<string>> sendPasswordKeysworkflow, Expression<Func<int>> sendPasswordKeysinterval = null, Expression<Func<bool>> sendPasswordKeysdontInterpretSymbols = null, Expression<Func<bool>> sendPasswordKeyspasswordContainsStoredPassword = null)
        {
            var apiCallPath = "/Environment/SendPasswordKeys";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sendPasswordKeys = new JObject();
            var sendPasswordKeyspropCount = 0;
            sendPasswordKeyspropCount++;
            sendPasswordKeys["Password"] = CSharpExpressionConverter.ConvertToken(sendPasswordKeyspassword);
            if (sendPasswordKeysinterval != null)
            {
                if (sendPasswordKeysinterval != null)
                {
                    sendPasswordKeys["Interval"] = CSharpExpressionConverter.ConvertToken(sendPasswordKeysinterval);
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
                    sendPasswordKeys["DontInterpretSymbols"] = CSharpExpressionConverter.ConvertToken(sendPasswordKeysdontInterpretSymbols);
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
                    sendPasswordKeys["PasswordContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(sendPasswordKeyspasswordContainsStoredPassword);
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
            sendPasswordKeys["Workflow"] = CSharpExpressionConverter.ConvertToken(sendPasswordKeysworkflow);
            if (sendPasswordKeyspropCount > 0)
            {
                callPayload.Body = sendPasswordKeys;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ClearClipboard(Expression<Func<string>> clearClipboardworkflow)
        {
            var apiCallPath = "/Environment/ClearClipboard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var clearClipboard = new JObject();
            var clearClipboardpropCount = 0;
            clearClipboardpropCount++;
            clearClipboard["Workflow"] = CSharpExpressionConverter.ConvertToken(clearClipboardworkflow);
            if (clearClipboardpropCount > 0)
            {
                callPayload.Body = clearClipboard;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetClipboardData(Expression<Func<string>> setClipboardDataworkflow, Expression<Func<string>> setClipboardDatanewClipboardData = null)
        {
            var apiCallPath = "/Environment/SetClipboardData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setClipboardData = new JObject();
            var setClipboardDatapropCount = 0;
            if (setClipboardDatanewClipboardData != null)
            {
                setClipboardData["NewClipboardData"] = CSharpExpressionConverter.ConvertToken(setClipboardDatanewClipboardData);
                setClipboardDatapropCount++;
            }

            setClipboardDatapropCount++;
            setClipboardData["Workflow"] = CSharpExpressionConverter.ConvertToken(setClipboardDataworkflow);
            if (setClipboardDatapropCount > 0)
            {
                callPayload.Body = setClipboardData;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetClipboardDataResponse> GetClipboardData(Expression<Func<string>> getClipboardDataworkflow)
        {
            var apiCallPath = "/Environment/GetClipboardData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getClipboardData = new JObject();
            var getClipboardDatapropCount = 0;
            getClipboardDatapropCount++;
            getClipboardData["Workflow"] = CSharpExpressionConverter.ConvertToken(getClipboardDataworkflow);
            if (getClipboardDatapropCount > 0)
            {
                callPayload.Body = getClipboardData;
            }

            return new ApiConnectionAction<GetClipboardDataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TakeScreenshotResponse> TakeScreenshot(Expression<Func<string>> takeScreenshotworkflow, Expression<Func<bool>> takeScreenshotfullscreen = null, Expression<Func<int>> takeScreenshotleftXPixels = null, Expression<Func<int>> takeScreenshottopYPixels = null, Expression<Func<int>> takeScreenshotwidthPixels = null, Expression<Func<int>> takeScreenshotheightPixels = null, Expression<Func<takeScreenshotimageFormatInput>> takeScreenshotimageFormat = null, Expression<Func<bool>> takeScreenshotuseDisplayDevice = null, Expression<Func<bool>> takeScreenshotraiseExceptionOnError = null, Expression<Func<bool>> takeScreenshothideAgent = null, Expression<Func<bool>> takeScreenshotusePhysicalCoordinates = null, Expression<Func<int>> takeScreenshotdisplayDeviceId = null)
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
                    takeScreenshot["Fullscreen"] = CSharpExpressionConverter.ConvertToken(takeScreenshotfullscreen);
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
                takeScreenshot["LeftXPixels"] = CSharpExpressionConverter.ConvertToken(takeScreenshotleftXPixels);
                takeScreenshotpropCount++;
            }

            if (takeScreenshottopYPixels != null)
            {
                takeScreenshot["TopYPixels"] = CSharpExpressionConverter.ConvertToken(takeScreenshottopYPixels);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotwidthPixels != null)
            {
                takeScreenshot["WidthPixels"] = CSharpExpressionConverter.ConvertToken(takeScreenshotwidthPixels);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotheightPixels != null)
            {
                takeScreenshot["HeightPixels"] = CSharpExpressionConverter.ConvertToken(takeScreenshotheightPixels);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotimageFormat != null)
            {
                takeScreenshot["ImageFormat"] = CSharpExpressionConverter.Convert(takeScreenshotimageFormat);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotuseDisplayDevice != null)
            {
                if (takeScreenshotuseDisplayDevice != null)
                {
                    takeScreenshot["UseDisplayDevice"] = CSharpExpressionConverter.ConvertToken(takeScreenshotuseDisplayDevice);
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
                    takeScreenshot["RaiseExceptionOnError"] = CSharpExpressionConverter.ConvertToken(takeScreenshotraiseExceptionOnError);
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
                    takeScreenshot["HideAgent"] = CSharpExpressionConverter.ConvertToken(takeScreenshothideAgent);
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
                    takeScreenshot["UsePhysicalCoordinates"] = CSharpExpressionConverter.ConvertToken(takeScreenshotusePhysicalCoordinates);
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
                takeScreenshot["DisplayDeviceId"] = CSharpExpressionConverter.ConvertToken(takeScreenshotdisplayDeviceId);
                takeScreenshotpropCount++;
            }

            takeScreenshotpropCount++;
            takeScreenshot["Workflow"] = CSharpExpressionConverter.ConvertToken(takeScreenshotworkflow);
            if (takeScreenshotpropCount > 0)
            {
                callPayload.Body = takeScreenshot;
            }

            return new ApiConnectionAction<TakeScreenshotResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetEnvironmentInfoResponse> GetEnvironmentInfo(Expression<Func<string>> getEnvironmentInfoworkflow)
        {
            var apiCallPath = "/Environment/GetEnvironmentInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getEnvironmentInfo = new JObject();
            var getEnvironmentInfopropCount = 0;
            getEnvironmentInfopropCount++;
            getEnvironmentInfo["Workflow"] = CSharpExpressionConverter.ConvertToken(getEnvironmentInfoworkflow);
            if (getEnvironmentInfopropCount > 0)
            {
                callPayload.Body = getEnvironmentInfo;
            }

            return new ApiConnectionAction<GetEnvironmentInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsScreenReaderEnabledResponse> IsScreenReaderEnabled(Expression<Func<string>> isScreenReaderEnabledworkflow)
        {
            var apiCallPath = "/Environment/IsScreenReaderEnabled";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isScreenReaderEnabled = new JObject();
            var isScreenReaderEnabledpropCount = 0;
            isScreenReaderEnabledpropCount++;
            isScreenReaderEnabled["Workflow"] = CSharpExpressionConverter.ConvertToken(isScreenReaderEnabledworkflow);
            if (isScreenReaderEnabledpropCount > 0)
            {
                callPayload.Body = isScreenReaderEnabled;
            }

            return new ApiConnectionAction<IsScreenReaderEnabledResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetScreenReader(Expression<Func<string>> setScreenReaderworkflow, Expression<Func<bool>> setScreenReaderenableScreenReader = null)
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
                    setScreenReader["EnableScreenReader"] = CSharpExpressionConverter.ConvertToken(setScreenReaderenableScreenReader);
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
            setScreenReader["Workflow"] = CSharpExpressionConverter.ConvertToken(setScreenReaderworkflow);
            if (setScreenReaderpropCount > 0)
            {
                callPayload.Body = setScreenReader;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetParentProcessIdResponse> GetParentProcessId(Expression<Func<int>> getParentProcessIdprocessId, Expression<Func<string>> getParentProcessIdworkflow)
        {
            var apiCallPath = "/Environment/GetParentProcessId";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getParentProcessId = new JObject();
            var getParentProcessIdpropCount = 0;
            getParentProcessIdpropCount++;
            getParentProcessId["ProcessId"] = CSharpExpressionConverter.ConvertToken(getParentProcessIdprocessId);
            getParentProcessIdpropCount++;
            getParentProcessId["Workflow"] = CSharpExpressionConverter.ConvertToken(getParentProcessIdworkflow);
            if (getParentProcessIdpropCount > 0)
            {
                callPayload.Body = getParentProcessId;
            }

            return new ApiConnectionAction<GetParentProcessIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessIdCommandLineResponse> GetProcessIdCommandLine(Expression<Func<int>> getProcessIdCommandLineprocessId, Expression<Func<string>> getProcessIdCommandLineworkflow)
        {
            var apiCallPath = "/Environment/GetProcessIdCommandLine";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getProcessIdCommandLine = new JObject();
            var getProcessIdCommandLinepropCount = 0;
            getProcessIdCommandLinepropCount++;
            getProcessIdCommandLine["ProcessId"] = CSharpExpressionConverter.ConvertToken(getProcessIdCommandLineprocessId);
            getProcessIdCommandLinepropCount++;
            getProcessIdCommandLine["Workflow"] = CSharpExpressionConverter.ConvertToken(getProcessIdCommandLineworkflow);
            if (getProcessIdCommandLinepropCount > 0)
            {
                callPayload.Body = getProcessIdCommandLine;
            }

            return new ApiConnectionAction<GetProcessIdCommandLineResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLastInputInfoResponse> GetLastInputInfo(Expression<Func<string>> getLastInputInfoworkflow)
        {
            var apiCallPath = "/Environment/GetLastInputInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getLastInputInfo = new JObject();
            var getLastInputInfopropCount = 0;
            getLastInputInfopropCount++;
            getLastInputInfo["Workflow"] = CSharpExpressionConverter.ConvertToken(getLastInputInfoworkflow);
            if (getLastInputInfopropCount > 0)
            {
                callPayload.Body = getLastInputInfo;
            }

            return new ApiConnectionAction<GetLastInputInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KeepSessionAliveResponse> KeepSessionAlive(Expression<Func<string>> keepSessionAliveworkflow, Expression<Func<int>> keepSessionAlivexWiggle = null, Expression<Func<int>> keepSessionAliveyWiggle = null, Expression<Func<double>> keepSessionAlivewiggleDelayInSeconds = null, Expression<Func<int>> keepSessionAliveidleThresholdInSeconds = null, Expression<Func<int>> keepSessionAliveidleCheckPeriodInSeconds = null, Expression<Func<int>> keepSessionAlivetotalKeepaliveRuntimeInSeconds = null)
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
                    keepSessionAlive["XWiggle"] = CSharpExpressionConverter.ConvertToken(keepSessionAlivexWiggle);
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
                keepSessionAlive["YWiggle"] = CSharpExpressionConverter.ConvertToken(keepSessionAliveyWiggle);
                keepSessionAlivepropCount++;
            }

            if (keepSessionAlivewiggleDelayInSeconds != null)
            {
                if (keepSessionAlivewiggleDelayInSeconds != null)
                {
                    keepSessionAlive["WiggleDelayInSeconds"] = CSharpExpressionConverter.ConvertToken(keepSessionAlivewiggleDelayInSeconds);
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
                    keepSessionAlive["IdleThresholdInSeconds"] = CSharpExpressionConverter.ConvertToken(keepSessionAliveidleThresholdInSeconds);
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
                    keepSessionAlive["IdleCheckPeriodInSeconds"] = CSharpExpressionConverter.ConvertToken(keepSessionAliveidleCheckPeriodInSeconds);
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
                    keepSessionAlive["TotalKeepaliveRuntimeInSeconds"] = CSharpExpressionConverter.ConvertToken(keepSessionAlivetotalKeepaliveRuntimeInSeconds);
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
            keepSessionAlive["Workflow"] = CSharpExpressionConverter.ConvertToken(keepSessionAliveworkflow);
            if (keepSessionAlivepropCount > 0)
            {
                callPayload.Body = keepSessionAlive;
            }

            return new ApiConnectionAction<KeepSessionAliveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<StopKeepSessionAliveResponse> StopKeepSessionAlive(Expression<Func<string>> stopKeepSessionAliveworkflow)
        {
            var apiCallPath = "/Environment/StopKeepSessionAlive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var stopKeepSessionAlive = new JObject();
            var stopKeepSessionAlivepropCount = 0;
            stopKeepSessionAlivepropCount++;
            stopKeepSessionAlive["Workflow"] = CSharpExpressionConverter.ConvertToken(stopKeepSessionAliveworkflow);
            if (stopKeepSessionAlivepropCount > 0)
            {
                callPayload.Body = stopKeepSessionAlive;
            }

            return new ApiConnectionAction<StopKeepSessionAliveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CopyFileToClipboardResponse> CopyFileToClipboard(Expression<Func<string>> copyFileToClipboardfilepath, Expression<Func<string>> copyFileToClipboardworkflow, Expression<Func<bool>> copyFileToClipboardcut = null)
        {
            var apiCallPath = "/Environment/CopyFileToClipboard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var copyFileToClipboard = new JObject();
            var copyFileToClipboardpropCount = 0;
            copyFileToClipboardpropCount++;
            copyFileToClipboard["Filepath"] = CSharpExpressionConverter.ConvertToken(copyFileToClipboardfilepath);
            if (copyFileToClipboardcut != null)
            {
                if (copyFileToClipboardcut != null)
                {
                    copyFileToClipboard["Cut"] = CSharpExpressionConverter.ConvertToken(copyFileToClipboardcut);
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
            copyFileToClipboard["Workflow"] = CSharpExpressionConverter.ConvertToken(copyFileToClipboardworkflow);
            if (copyFileToClipboardpropCount > 0)
            {
                callPayload.Body = copyFileToClipboard;
            }

            return new ApiConnectionAction<CopyFileToClipboardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteSessionInfoResponse> GetRemoteSessionInfo(Expression<Func<string>> getRemoteSessionInfoworkflow)
        {
            var apiCallPath = "/Environment/GetRemoteSessionInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRemoteSessionInfo = new JObject();
            var getRemoteSessionInfopropCount = 0;
            getRemoteSessionInfopropCount++;
            getRemoteSessionInfo["Workflow"] = CSharpExpressionConverter.ConvertToken(getRemoteSessionInfoworkflow);
            if (getRemoteSessionInfopropCount > 0)
            {
                callPayload.Body = getRemoteSessionInfo;
            }

            return new ApiConnectionAction<GetRemoteSessionInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GeneratePasswordResponse> GeneratePassword(Expression<Func<string>> generatePasswordpasswordFormat, Expression<Func<string>> generatePasswordworkflow, Expression<Func<int>> generatePasswordminimumLength = null, Expression<Func<bool>> generatePasswordreturnAsPlainText = null, Expression<Func<string>> generatePasswordstorePasswordAsIdentifier = null, Expression<Func<string>> generatePasswordsupportedSymbols = null, Expression<Func<bool>> generatePasswordattemptUniquePasswords = null, Expression<Func<generatePasswordgenerateAtInput>> generatePasswordgenerateAt = null, Expression<Func<int>> generatePasswordminimumLowercase = null, Expression<Func<int>> generatePasswordminimumUppercase = null, Expression<Func<int>> generatePasswordminimumNumbers = null, Expression<Func<int>> generatePasswordminimumSymbols = null)
        {
            var apiCallPath = "/Environment/GeneratePassword";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var generatePassword = new JObject();
            var generatePasswordpropCount = 0;
            generatePasswordpropCount++;
            generatePassword["PasswordFormat"] = CSharpExpressionConverter.ConvertToken(generatePasswordpasswordFormat);
            if (generatePasswordminimumLength != null)
            {
                generatePassword["MinimumLength"] = CSharpExpressionConverter.ConvertToken(generatePasswordminimumLength);
                generatePasswordpropCount++;
            }

            if (generatePasswordreturnAsPlainText != null)
            {
                if (generatePasswordreturnAsPlainText != null)
                {
                    generatePassword["ReturnAsPlainText"] = CSharpExpressionConverter.ConvertToken(generatePasswordreturnAsPlainText);
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
                generatePassword["StorePasswordAsIdentifier"] = CSharpExpressionConverter.ConvertToken(generatePasswordstorePasswordAsIdentifier);
                generatePasswordpropCount++;
            }

            if (generatePasswordsupportedSymbols != null)
            {
                generatePassword["SupportedSymbols"] = CSharpExpressionConverter.ConvertToken(generatePasswordsupportedSymbols);
                generatePasswordpropCount++;
            }

            if (generatePasswordattemptUniquePasswords != null)
            {
                if (generatePasswordattemptUniquePasswords != null)
                {
                    generatePassword["AttemptUniquePasswords"] = CSharpExpressionConverter.ConvertToken(generatePasswordattemptUniquePasswords);
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
                    generatePassword["GenerateAt"] = CSharpExpressionConverter.Convert(generatePasswordgenerateAt);
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
                    generatePassword["MinimumLowercase"] = CSharpExpressionConverter.ConvertToken(generatePasswordminimumLowercase);
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
                    generatePassword["MinimumUppercase"] = CSharpExpressionConverter.ConvertToken(generatePasswordminimumUppercase);
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
                    generatePassword["MinimumNumbers"] = CSharpExpressionConverter.ConvertToken(generatePasswordminimumNumbers);
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
                    generatePassword["MinimumSymbols"] = CSharpExpressionConverter.ConvertToken(generatePasswordminimumSymbols);
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
            generatePassword["Workflow"] = CSharpExpressionConverter.ConvertToken(generatePasswordworkflow);
            if (generatePasswordpropCount > 0)
            {
                callPayload.Body = generatePassword;
            }

            return new ApiConnectionAction<GeneratePasswordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetStoredPasswordResponse> GetStoredPassword(Expression<Func<string>> getStoredPasswordworkflow, Expression<Func<string>> getStoredPasswordpasswordIdentifier = null)
        {
            var apiCallPath = "/Environment/GetStoredPassword";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getStoredPassword = new JObject();
            var getStoredPasswordpropCount = 0;
            if (getStoredPasswordpasswordIdentifier != null)
            {
                getStoredPassword["PasswordIdentifier"] = CSharpExpressionConverter.ConvertToken(getStoredPasswordpasswordIdentifier);
                getStoredPasswordpropCount++;
            }

            getStoredPasswordpropCount++;
            getStoredPassword["Workflow"] = CSharpExpressionConverter.ConvertToken(getStoredPasswordworkflow);
            if (getStoredPasswordpropCount > 0)
            {
                callPayload.Body = getStoredPassword;
            }

            return new ApiConnectionAction<GetStoredPasswordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ExpandPasswordStringResponse> ExpandPasswordString(Expression<Func<string>> expandPasswordStringworkflow, Expression<Func<string>> expandPasswordStringinputString = null)
        {
            var apiCallPath = "/Environment/ExpandPasswordString";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var expandPasswordString = new JObject();
            var expandPasswordStringpropCount = 0;
            if (expandPasswordStringinputString != null)
            {
                expandPasswordString["InputString"] = CSharpExpressionConverter.ConvertToken(expandPasswordStringinputString);
                expandPasswordStringpropCount++;
            }

            expandPasswordStringpropCount++;
            expandPasswordString["Workflow"] = CSharpExpressionConverter.ConvertToken(expandPasswordStringworkflow);
            if (expandPasswordStringpropCount > 0)
            {
                callPayload.Body = expandPasswordString;
            }

            return new ApiConnectionAction<ExpandPasswordStringResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<StorePasswordInAgentMemoryResponse> StorePasswordInAgentMemory(Expression<Func<string>> storePasswordInAgentMemoryidentifier, Expression<Func<string>> storePasswordInAgentMemorypassword, Expression<Func<string>> storePasswordInAgentMemoryworkflow)
        {
            var apiCallPath = "/Environment/StorePasswordInAgentMemory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var storePasswordInAgentMemory = new JObject();
            var storePasswordInAgentMemorypropCount = 0;
            storePasswordInAgentMemorypropCount++;
            storePasswordInAgentMemory["Identifier"] = CSharpExpressionConverter.ConvertToken(storePasswordInAgentMemoryidentifier);
            storePasswordInAgentMemorypropCount++;
            storePasswordInAgentMemory["Password"] = CSharpExpressionConverter.ConvertToken(storePasswordInAgentMemorypassword);
            storePasswordInAgentMemorypropCount++;
            storePasswordInAgentMemory["Workflow"] = CSharpExpressionConverter.ConvertToken(storePasswordInAgentMemoryworkflow);
            if (storePasswordInAgentMemorypropCount > 0)
            {
                callPayload.Body = storePasswordInAgentMemory;
            }

            return new ApiConnectionAction<StorePasswordInAgentMemoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeletePasswordInAgentMemoryResponse> DeletePasswordInAgentMemory(Expression<Func<string>> deletePasswordInAgentMemoryworkflow, Expression<Func<bool>> deletePasswordInAgentMemorydeleteAllPasswords = null, Expression<Func<string>> deletePasswordInAgentMemoryidentifier = null)
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
                    deletePasswordInAgentMemory["DeleteAllPasswords"] = CSharpExpressionConverter.ConvertToken(deletePasswordInAgentMemorydeleteAllPasswords);
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
                deletePasswordInAgentMemory["Identifier"] = CSharpExpressionConverter.ConvertToken(deletePasswordInAgentMemoryidentifier);
                deletePasswordInAgentMemorypropCount++;
            }

            deletePasswordInAgentMemorypropCount++;
            deletePasswordInAgentMemory["Workflow"] = CSharpExpressionConverter.ConvertToken(deletePasswordInAgentMemoryworkflow);
            if (deletePasswordInAgentMemorypropCount > 0)
            {
                callPayload.Body = deletePasswordInAgentMemory;
            }

            return new ApiConnectionAction<DeletePasswordInAgentMemoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialWriteResponse> CredentialWrite(Expression<Func<string>> credentialWritecredentialAddress, Expression<Func<string>> credentialWriteuserName, Expression<Func<string>> credentialWritepassword, Expression<Func<credentialWritecredentialTypeInput>> credentialWritecredentialType, Expression<Func<string>> credentialWriteworkflow, Expression<Func<credentialWritecredentialPersistenceInput>> credentialWritecredentialPersistence = null, Expression<Func<string>> credentialWritesymmetricKey = null, Expression<Func<string>> credentialWritestorePasswordAsIdentifier = null)
        {
            var apiCallPath = "/Environment/CredentialWrite";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var credentialWrite = new JObject();
            var credentialWritepropCount = 0;
            credentialWritepropCount++;
            credentialWrite["CredentialAddress"] = CSharpExpressionConverter.ConvertToken(credentialWritecredentialAddress);
            credentialWritepropCount++;
            credentialWrite["UserName"] = CSharpExpressionConverter.ConvertToken(credentialWriteuserName);
            credentialWritepropCount++;
            credentialWrite["Password"] = CSharpExpressionConverter.ConvertToken(credentialWritepassword);
            credentialWritepropCount++;
            credentialWrite["CredentialType"] = CSharpExpressionConverter.Convert(credentialWritecredentialType);
            if (credentialWritecredentialPersistence != null)
            {
                if (credentialWritecredentialPersistence != null)
                {
                    credentialWrite["CredentialPersistence"] = CSharpExpressionConverter.Convert(credentialWritecredentialPersistence);
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
                credentialWrite["SymmetricKey"] = CSharpExpressionConverter.ConvertToken(credentialWritesymmetricKey);
                credentialWritepropCount++;
            }

            if (credentialWritestorePasswordAsIdentifier != null)
            {
                credentialWrite["StorePasswordAsIdentifier"] = CSharpExpressionConverter.ConvertToken(credentialWritestorePasswordAsIdentifier);
                credentialWritepropCount++;
            }

            credentialWritepropCount++;
            credentialWrite["Workflow"] = CSharpExpressionConverter.ConvertToken(credentialWriteworkflow);
            if (credentialWritepropCount > 0)
            {
                callPayload.Body = credentialWrite;
            }

            return new ApiConnectionAction<CredentialWriteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialReadResponse> CredentialRead(Expression<Func<string>> credentialReadcredentialAddress, Expression<Func<credentialReadcredentialTypeInput>> credentialReadcredentialType, Expression<Func<string>> credentialReadworkflow, Expression<Func<string>> credentialReadsymmetricKey = null, Expression<Func<string>> credentialReadstorePasswordAsIdentifier = null, Expression<Func<bool>> credentialReaddontReturnPassword = null)
        {
            var apiCallPath = "/Environment/CredentialRead";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var credentialRead = new JObject();
            var credentialReadpropCount = 0;
            credentialReadpropCount++;
            credentialRead["CredentialAddress"] = CSharpExpressionConverter.ConvertToken(credentialReadcredentialAddress);
            credentialReadpropCount++;
            credentialRead["CredentialType"] = CSharpExpressionConverter.Convert(credentialReadcredentialType);
            if (credentialReadsymmetricKey != null)
            {
                credentialRead["SymmetricKey"] = CSharpExpressionConverter.ConvertToken(credentialReadsymmetricKey);
                credentialReadpropCount++;
            }

            if (credentialReadstorePasswordAsIdentifier != null)
            {
                credentialRead["StorePasswordAsIdentifier"] = CSharpExpressionConverter.ConvertToken(credentialReadstorePasswordAsIdentifier);
                credentialReadpropCount++;
            }

            if (credentialReaddontReturnPassword != null)
            {
                if (credentialReaddontReturnPassword != null)
                {
                    credentialRead["DontReturnPassword"] = CSharpExpressionConverter.ConvertToken(credentialReaddontReturnPassword);
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
            credentialRead["Workflow"] = CSharpExpressionConverter.ConvertToken(credentialReadworkflow);
            if (credentialReadpropCount > 0)
            {
                callPayload.Body = credentialRead;
            }

            return new ApiConnectionAction<CredentialReadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialDeleteResponse> CredentialDelete(Expression<Func<string>> credentialDeletecredentialAddress, Expression<Func<credentialDeletecredentialTypeInput>> credentialDeletecredentialType, Expression<Func<string>> credentialDeleteworkflow)
        {
            var apiCallPath = "/Environment/CredentialDelete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var credentialDelete = new JObject();
            var credentialDeletepropCount = 0;
            credentialDeletepropCount++;
            credentialDelete["CredentialAddress"] = CSharpExpressionConverter.ConvertToken(credentialDeletecredentialAddress);
            credentialDeletepropCount++;
            credentialDelete["CredentialType"] = CSharpExpressionConverter.Convert(credentialDeletecredentialType);
            credentialDeletepropCount++;
            credentialDelete["Workflow"] = CSharpExpressionConverter.ConvertToken(credentialDeleteworkflow);
            if (credentialDeletepropCount > 0)
            {
                callPayload.Body = credentialDelete;
            }

            return new ApiConnectionAction<CredentialDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GenerateRDPFileResponse> GenerateRDPFile(Expression<Func<string>> generateRDPFileremoteAddress, Expression<Func<string>> generateRDPFileoutputFolderPath, Expression<Func<string>> generateRDPFilerDPFileName, Expression<Func<string>> generateRDPFileworkflow, Expression<Func<bool>> generateRDPFileoverwriteRDPFileIfAlreadyExists = null, Expression<Func<bool>> generateRDPFiletrustRemoteComputer = null, Expression<Func<bool>> generateRDPFilestoreCredentials = null, Expression<Func<string>> generateRDPFileuserName = null, Expression<Func<string>> generateRDPFilepassword = null, Expression<Func<generateRDPFilecredentialTypeInput>> generateRDPFilecredentialType = null, Expression<Func<generateRDPFilecredentialPersistenceInput>> generateRDPFilecredentialPersistence = null, Expression<Func<bool>> generateRDPFileredirectPrinters = null, Expression<Func<bool>> generateRDPFileredirectAllDrives = null, Expression<Func<bool>> generateRDPFileredirectClipboard = null, Expression<Func<bool>> generateRDPFilefullscreen = null, Expression<Func<int>> generateRDPFiledesktopWidth = null, Expression<Func<int>> generateRDPFiledesktopHeight = null, Expression<Func<bool>> generateRDPFileuseMultiMonitor = null, Expression<Func<int>> generateRDPFilesessionBPP = null, Expression<Func<bool>> generateRDPFilesmartSizing = null)
        {
            var apiCallPath = "/Environment/GenerateRDPFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var generateRDPFile = new JObject();
            var generateRDPFilepropCount = 0;
            generateRDPFilepropCount++;
            generateRDPFile["RemoteAddress"] = CSharpExpressionConverter.ConvertToken(generateRDPFileremoteAddress);
            generateRDPFilepropCount++;
            generateRDPFile["OutputFolderPath"] = CSharpExpressionConverter.ConvertToken(generateRDPFileoutputFolderPath);
            generateRDPFilepropCount++;
            generateRDPFile["RDPFileName"] = CSharpExpressionConverter.ConvertToken(generateRDPFilerDPFileName);
            if (generateRDPFileoverwriteRDPFileIfAlreadyExists != null)
            {
                if (generateRDPFileoverwriteRDPFileIfAlreadyExists != null)
                {
                    generateRDPFile["OverwriteRDPFileIfAlreadyExists"] = CSharpExpressionConverter.ConvertToken(generateRDPFileoverwriteRDPFileIfAlreadyExists);
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
                    generateRDPFile["TrustRemoteComputer"] = CSharpExpressionConverter.ConvertToken(generateRDPFiletrustRemoteComputer);
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
                    generateRDPFile["StoreCredentials"] = CSharpExpressionConverter.ConvertToken(generateRDPFilestoreCredentials);
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
                generateRDPFile["UserName"] = CSharpExpressionConverter.ConvertToken(generateRDPFileuserName);
                generateRDPFilepropCount++;
            }

            if (generateRDPFilepassword != null)
            {
                generateRDPFile["Password"] = CSharpExpressionConverter.ConvertToken(generateRDPFilepassword);
                generateRDPFilepropCount++;
            }

            if (generateRDPFilecredentialType != null)
            {
                if (generateRDPFilecredentialType != null)
                {
                    generateRDPFile["CredentialType"] = CSharpExpressionConverter.Convert(generateRDPFilecredentialType);
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
                    generateRDPFile["CredentialPersistence"] = CSharpExpressionConverter.Convert(generateRDPFilecredentialPersistence);
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
                    generateRDPFile["RedirectPrinters"] = CSharpExpressionConverter.ConvertToken(generateRDPFileredirectPrinters);
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
                    generateRDPFile["RedirectAllDrives"] = CSharpExpressionConverter.ConvertToken(generateRDPFileredirectAllDrives);
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
                    generateRDPFile["RedirectClipboard"] = CSharpExpressionConverter.ConvertToken(generateRDPFileredirectClipboard);
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
                    generateRDPFile["Fullscreen"] = CSharpExpressionConverter.ConvertToken(generateRDPFilefullscreen);
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
                    generateRDPFile["DesktopWidth"] = CSharpExpressionConverter.ConvertToken(generateRDPFiledesktopWidth);
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
                    generateRDPFile["DesktopHeight"] = CSharpExpressionConverter.ConvertToken(generateRDPFiledesktopHeight);
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
                    generateRDPFile["UseMultiMonitor"] = CSharpExpressionConverter.ConvertToken(generateRDPFileuseMultiMonitor);
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
                    generateRDPFile["SessionBPP"] = CSharpExpressionConverter.ConvertToken(generateRDPFilesessionBPP);
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
                    generateRDPFile["SmartSizing"] = CSharpExpressionConverter.ConvertToken(generateRDPFilesmartSizing);
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
            generateRDPFile["Workflow"] = CSharpExpressionConverter.ConvertToken(generateRDPFileworkflow);
            if (generateRDPFilepropCount > 0)
            {
                callPayload.Body = generateRDPFile;
            }

            return new ApiConnectionAction<GenerateRDPFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<LaunchRemoteDesktopSessionResponse> LaunchRemoteDesktopSession(Expression<Func<string>> launchRemoteDesktopSessionrDPFilePath, Expression<Func<string>> launchRemoteDesktopSessionworkflow, Expression<Func<bool>> launchRemoteDesktopSessiontrustRemoteComputer = null)
        {
            var apiCallPath = "/Environment/LaunchRemoteDesktopSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var launchRemoteDesktopSession = new JObject();
            var launchRemoteDesktopSessionpropCount = 0;
            launchRemoteDesktopSessionpropCount++;
            launchRemoteDesktopSession["RDPFilePath"] = CSharpExpressionConverter.ConvertToken(launchRemoteDesktopSessionrDPFilePath);
            if (launchRemoteDesktopSessiontrustRemoteComputer != null)
            {
                if (launchRemoteDesktopSessiontrustRemoteComputer != null)
                {
                    launchRemoteDesktopSession["TrustRemoteComputer"] = CSharpExpressionConverter.ConvertToken(launchRemoteDesktopSessiontrustRemoteComputer);
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
            launchRemoteDesktopSession["Workflow"] = CSharpExpressionConverter.ConvertToken(launchRemoteDesktopSessionworkflow);
            if (launchRemoteDesktopSessionpropCount > 0)
            {
                callPayload.Body = launchRemoteDesktopSession;
            }

            return new ApiConnectionAction<LaunchRemoteDesktopSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsTCPPortRespondingResponse> IsTCPPortResponding(Expression<Func<string>> isTCPPortRespondingremoteHost, Expression<Func<int>> isTCPPortRespondingtCPPort, Expression<Func<string>> isTCPPortRespondingworkflow, Expression<Func<int>> isTCPPortRespondingtimeoutInSeconds = null)
        {
            var apiCallPath = "/Environment/IsTCPPortResponding";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isTCPPortResponding = new JObject();
            var isTCPPortRespondingpropCount = 0;
            isTCPPortRespondingpropCount++;
            isTCPPortResponding["RemoteHost"] = CSharpExpressionConverter.ConvertToken(isTCPPortRespondingremoteHost);
            isTCPPortRespondingpropCount++;
            isTCPPortResponding["TCPPort"] = CSharpExpressionConverter.ConvertToken(isTCPPortRespondingtCPPort);
            if (isTCPPortRespondingtimeoutInSeconds != null)
            {
                if (isTCPPortRespondingtimeoutInSeconds != null)
                {
                    isTCPPortResponding["TimeoutInSeconds"] = CSharpExpressionConverter.ConvertToken(isTCPPortRespondingtimeoutInSeconds);
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
            isTCPPortResponding["Workflow"] = CSharpExpressionConverter.ConvertToken(isTCPPortRespondingworkflow);
            if (isTCPPortRespondingpropCount > 0)
            {
                callPayload.Body = isTCPPortResponding;
            }

            return new ApiConnectionAction<IsTCPPortRespondingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UnlockSessionResponse> UnlockSession(Expression<Func<string>> unlockSessionunlockPassword, Expression<Func<bool>> unlockSessiondetectIfLocked, Expression<Func<bool>> unlockSessiondetectCredentialProvider, Expression<Func<string>> unlockSessionworkflow, Expression<Func<bool>> unlockSessionpasswordContainsStoredPassword = null, Expression<Func<int>> unlockSessionsecondsToWaitForUnlock = null)
        {
            var apiCallPath = "/Environment/UnlockSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var unlockSession = new JObject();
            var unlockSessionpropCount = 0;
            unlockSessionpropCount++;
            unlockSession["UnlockPassword"] = CSharpExpressionConverter.ConvertToken(unlockSessionunlockPassword);
            if (unlockSessionpasswordContainsStoredPassword != null)
            {
                if (unlockSessionpasswordContainsStoredPassword != null)
                {
                    unlockSession["PasswordContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(unlockSessionpasswordContainsStoredPassword);
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
            unlockSession["DetectIfLocked"] = CSharpExpressionConverter.ConvertToken(unlockSessiondetectIfLocked);
            unlockSessionpropCount++;
            unlockSession["DetectCredentialProvider"] = CSharpExpressionConverter.ConvertToken(unlockSessiondetectCredentialProvider);
            if (unlockSessionsecondsToWaitForUnlock != null)
            {
                if (unlockSessionsecondsToWaitForUnlock != null)
                {
                    unlockSession["SecondsToWaitForUnlock"] = CSharpExpressionConverter.ConvertToken(unlockSessionsecondsToWaitForUnlock);
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
            unlockSession["Workflow"] = CSharpExpressionConverter.ConvertToken(unlockSessionworkflow);
            if (unlockSessionpropCount > 0)
            {
                callPayload.Body = unlockSession;
            }

            return new ApiConnectionAction<UnlockSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<LockSessionResponse> LockSession(Expression<Func<string>> lockSessionworkflow, Expression<Func<int>> lockSessionlockAfterMinutesOfActionInactivity = null, Expression<Func<int>> lockSessionsecondsToWaitAfterLock = null)
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
                    lockSession["LockAfterMinutesOfActionInactivity"] = CSharpExpressionConverter.ConvertToken(lockSessionlockAfterMinutesOfActionInactivity);
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
                    lockSession["SecondsToWaitAfterLock"] = CSharpExpressionConverter.ConvertToken(lockSessionsecondsToWaitAfterLock);
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
            lockSession["Workflow"] = CSharpExpressionConverter.ConvertToken(lockSessionworkflow);
            if (lockSessionpropCount > 0)
            {
                callPayload.Body = lockSession;
            }

            return new ApiConnectionAction<LockSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsSessionLockedResponse> IsSessionLocked(Expression<Func<string>> isSessionLockedworkflow)
        {
            var apiCallPath = "/Environment/IsSessionLocked";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isSessionLocked = new JObject();
            var isSessionLockedpropCount = 0;
            isSessionLockedpropCount++;
            isSessionLocked["Workflow"] = CSharpExpressionConverter.ConvertToken(isSessionLockedworkflow);
            if (isSessionLockedpropCount > 0)
            {
                callPayload.Body = isSessionLocked;
            }

            return new ApiConnectionAction<IsSessionLockedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetGenericCredentialFromOrchestratorResponse> GetGenericCredentialFromOrchestrator(Expression<Func<string>> getGenericCredentialFromOrchestratorfriendlyName = null, Expression<Func<bool>> getGenericCredentialFromOrchestratorretrievePlainTextPassword = null)
        {
            var apiCallPath = "/Environment/GetGenericCredentialFromOrchestrator";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getGenericCredentialFromOrchestrator = new JObject();
            var getGenericCredentialFromOrchestratorpropCount = 0;
            if (getGenericCredentialFromOrchestratorfriendlyName != null)
            {
                getGenericCredentialFromOrchestrator["FriendlyName"] = CSharpExpressionConverter.ConvertToken(getGenericCredentialFromOrchestratorfriendlyName);
                getGenericCredentialFromOrchestratorpropCount++;
            }

            if (getGenericCredentialFromOrchestratorretrievePlainTextPassword != null)
            {
                if (getGenericCredentialFromOrchestratorretrievePlainTextPassword != null)
                {
                    getGenericCredentialFromOrchestrator["RetrievePlainTextPassword"] = CSharpExpressionConverter.ConvertToken(getGenericCredentialFromOrchestratorretrievePlainTextPassword);
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
        public IBodyWorkflowAction<DrawRectangleOnScreenResponse> DrawRectangleOnScreen(Expression<Func<int>> drawRectangleOnScreenrectangleLeftPixelXCoord, Expression<Func<int>> drawRectangleOnScreenrectangleRightPixelXCoord, Expression<Func<int>> drawRectangleOnScreenrectangleTopPixelYCoord, Expression<Func<int>> drawRectangleOnScreenrectangleBottomPixelYCoord, Expression<Func<string>> drawRectangleOnScreenworkflow, Expression<Func<string>> drawRectangleOnScreenpenColour = null, Expression<Func<int>> drawRectangleOnScreenpenThicknessPixels = null, Expression<Func<int>> drawRectangleOnScreensecondsToDisplay = null, Expression<Func<bool>> drawRectangleOnScreencoordinatesArePhysical = null)
        {
            var apiCallPath = "/Environment/DrawRectangleOnScreen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var drawRectangleOnScreen = new JObject();
            var drawRectangleOnScreenpropCount = 0;
            drawRectangleOnScreenpropCount++;
            drawRectangleOnScreen["RectangleLeftPixelXCoord"] = CSharpExpressionConverter.ConvertToken(drawRectangleOnScreenrectangleLeftPixelXCoord);
            drawRectangleOnScreenpropCount++;
            drawRectangleOnScreen["RectangleRightPixelXCoord"] = CSharpExpressionConverter.ConvertToken(drawRectangleOnScreenrectangleRightPixelXCoord);
            drawRectangleOnScreenpropCount++;
            drawRectangleOnScreen["RectangleTopPixelYCoord"] = CSharpExpressionConverter.ConvertToken(drawRectangleOnScreenrectangleTopPixelYCoord);
            drawRectangleOnScreenpropCount++;
            drawRectangleOnScreen["RectangleBottomPixelYCoord"] = CSharpExpressionConverter.ConvertToken(drawRectangleOnScreenrectangleBottomPixelYCoord);
            if (drawRectangleOnScreenpenColour != null)
            {
                if (drawRectangleOnScreenpenColour != null)
                {
                    drawRectangleOnScreen["PenColour"] = CSharpExpressionConverter.ConvertToken(drawRectangleOnScreenpenColour);
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
                    drawRectangleOnScreen["PenThicknessPixels"] = CSharpExpressionConverter.ConvertToken(drawRectangleOnScreenpenThicknessPixels);
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
                    drawRectangleOnScreen["SecondsToDisplay"] = CSharpExpressionConverter.ConvertToken(drawRectangleOnScreensecondsToDisplay);
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
                    drawRectangleOnScreen["CoordinatesArePhysical"] = CSharpExpressionConverter.ConvertToken(drawRectangleOnScreencoordinatesArePhysical);
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
            drawRectangleOnScreen["Workflow"] = CSharpExpressionConverter.ConvertToken(drawRectangleOnScreenworkflow);
            if (drawRectangleOnScreenpropCount > 0)
            {
                callPayload.Body = drawRectangleOnScreen;
            }

            return new ApiConnectionAction<DrawRectangleOnScreenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFailedActionErrorMessageFromPowerAutomateResultJSONResponse> GetFailedActionErrorMessageFromPowerAutomateResultJSON(Expression<Func<string[]>> getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON, Expression<Func<string>> getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus = null)
        {
            var apiCallPath = "/Environment/GetFailedActionErrorMessageFromPowerAutomateResultJSON";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getFailedActionErrorMessageFromPowerAutomateResultJSON = new JObject();
            var getFailedActionErrorMessageFromPowerAutomateResultJSONpropCount = 0;
            getFailedActionErrorMessageFromPowerAutomateResultJSONpropCount++;
            getFailedActionErrorMessageFromPowerAutomateResultJSON["PowerAutomateResultJSON"] = CSharpExpressionConverter.ConvertToken(getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON);
            if (getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus != null)
            {
                if (getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus != null)
                {
                    getFailedActionErrorMessageFromPowerAutomateResultJSON["SearchStatus"] = CSharpExpressionConverter.ConvertToken(getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus);
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
        public IBodyWorkflowAction<GetPixelColourAtCoordinateResponse> GetPixelColourAtCoordinate(Expression<Func<int>> getPixelColourAtCoordinateleftXPixels, Expression<Func<int>> getPixelColourAtCoordinatetopYPixels, Expression<Func<string>> getPixelColourAtCoordinateworkflow, Expression<Func<bool>> getPixelColourAtCoordinatehideAgent = null, Expression<Func<bool>> getPixelColourAtCoordinateusePhysicalCoordinates = null)
        {
            var apiCallPath = "/Environment/GetPixelColourAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getPixelColourAtCoordinate = new JObject();
            var getPixelColourAtCoordinatepropCount = 0;
            getPixelColourAtCoordinatepropCount++;
            getPixelColourAtCoordinate["LeftXPixels"] = CSharpExpressionConverter.ConvertToken(getPixelColourAtCoordinateleftXPixels);
            getPixelColourAtCoordinatepropCount++;
            getPixelColourAtCoordinate["TopYPixels"] = CSharpExpressionConverter.ConvertToken(getPixelColourAtCoordinatetopYPixels);
            if (getPixelColourAtCoordinatehideAgent != null)
            {
                if (getPixelColourAtCoordinatehideAgent != null)
                {
                    getPixelColourAtCoordinate["HideAgent"] = CSharpExpressionConverter.ConvertToken(getPixelColourAtCoordinatehideAgent);
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
                    getPixelColourAtCoordinate["UsePhysicalCoordinates"] = CSharpExpressionConverter.ConvertToken(getPixelColourAtCoordinateusePhysicalCoordinates);
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
            getPixelColourAtCoordinate["Workflow"] = CSharpExpressionConverter.ConvertToken(getPixelColourAtCoordinateworkflow);
            if (getPixelColourAtCoordinatepropCount > 0)
            {
                callPayload.Body = getPixelColourAtCoordinate;
            }

            return new ApiConnectionAction<GetPixelColourAtCoordinateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ConvertRectangleCoordinatesResponse> ConvertRectangleCoordinates(Expression<Func<int>> convertRectangleCoordinatesrectangleLeftPixelXCoord, Expression<Func<int>> convertRectangleCoordinatesrectangleTopPixelYCoord, Expression<Func<int>> convertRectangleCoordinatesrectangleRightPixelXCoord, Expression<Func<int>> convertRectangleCoordinatesrectangleBottomPixelYCoord, Expression<Func<convertRectangleCoordinatesconversionTypeInput>> convertRectangleCoordinatesconversionType, Expression<Func<string>> convertRectangleCoordinatesworkflow)
        {
            var apiCallPath = "/Environment/ConvertRectangleCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var convertRectangleCoordinates = new JObject();
            var convertRectangleCoordinatespropCount = 0;
            convertRectangleCoordinatespropCount++;
            convertRectangleCoordinates["RectangleLeftPixelXCoord"] = CSharpExpressionConverter.ConvertToken(convertRectangleCoordinatesrectangleLeftPixelXCoord);
            convertRectangleCoordinatespropCount++;
            convertRectangleCoordinates["RectangleTopPixelYCoord"] = CSharpExpressionConverter.ConvertToken(convertRectangleCoordinatesrectangleTopPixelYCoord);
            convertRectangleCoordinatespropCount++;
            convertRectangleCoordinates["RectangleRightPixelXCoord"] = CSharpExpressionConverter.ConvertToken(convertRectangleCoordinatesrectangleRightPixelXCoord);
            convertRectangleCoordinatespropCount++;
            convertRectangleCoordinates["RectangleBottomPixelYCoord"] = CSharpExpressionConverter.ConvertToken(convertRectangleCoordinatesrectangleBottomPixelYCoord);
            convertRectangleCoordinatespropCount++;
            convertRectangleCoordinates["ConversionType"] = CSharpExpressionConverter.Convert(convertRectangleCoordinatesconversionType);
            convertRectangleCoordinatespropCount++;
            convertRectangleCoordinates["Workflow"] = CSharpExpressionConverter.ConvertToken(convertRectangleCoordinatesworkflow);
            if (convertRectangleCoordinatespropCount > 0)
            {
                callPayload.Body = convertRectangleCoordinates;
            }

            return new ApiConnectionAction<ConvertRectangleCoordinatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SendMessageToWebAPIResponse> SendMessageToWebAPI(Expression<Func<string>> sendMessageToWebAPIworkflow, Expression<Func<string>> sendMessageToWebAPIuRL = null, Expression<Func<sendMessageToWebAPImethodInput>> sendMessageToWebAPImethod = null, Expression<Func<int>> sendMessageToWebAPItimeoutInSeconds = null, Expression<Func<string>> sendMessageToWebAPIcontentType = null, Expression<Func<string>> sendMessageToWebAPIaccept = null, Expression<Func<string>> sendMessageToWebAPImessageBody = null, Expression<Func<sendMessageToWebAPItransmitEncodingInput>> sendMessageToWebAPItransmitEncoding = null, Expression<Func<sendMessageToWebAPIresponseEncodingInput>> sendMessageToWebAPIresponseEncoding = null, Expression<Func<int>> sendMessageToWebAPIbufferSize = null, Expression<Func<sendMessageToWebAPIhTTPRequestHeadersListInputItem[]>> sendMessageToWebAPIhTTPRequestHeadersList = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS10 = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS11 = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS12 = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS13 = null, Expression<Func<bool>> sendMessageToWebAPIkeepAlive = null, Expression<Func<bool>> sendMessageToWebAPIexpect100Continue = null, Expression<Func<bool>> sendMessageToWebAPIreturnResponseHeaders = null, Expression<Func<bool>> sendMessageToWebAPIrunAsThread = null, Expression<Func<bool>> sendMessageToWebAPIwaitForThread = null, Expression<Func<int>> sendMessageToWebAPIretrieveOutputDataFromThreadId = null)
        {
            var apiCallPath = "/Environment/SendMessageToWebAPI";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sendMessageToWebAPI = new JObject();
            var sendMessageToWebAPIpropCount = 0;
            if (sendMessageToWebAPIuRL != null)
            {
                sendMessageToWebAPI["URL"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPIuRL);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPImethod != null)
            {
                if (sendMessageToWebAPImethod != null)
                {
                    sendMessageToWebAPI["Method"] = CSharpExpressionConverter.Convert(sendMessageToWebAPImethod);
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
                    sendMessageToWebAPI["TimeoutInSeconds"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPItimeoutInSeconds);
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
                    sendMessageToWebAPI["ContentType"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPIcontentType);
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
                    sendMessageToWebAPI["Accept"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPIaccept);
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
                sendMessageToWebAPI["MessageBody"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPImessageBody);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPItransmitEncoding != null)
            {
                if (sendMessageToWebAPItransmitEncoding != null)
                {
                    sendMessageToWebAPI["TransmitEncoding"] = CSharpExpressionConverter.Convert(sendMessageToWebAPItransmitEncoding);
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
                    sendMessageToWebAPI["ResponseEncoding"] = CSharpExpressionConverter.Convert(sendMessageToWebAPIresponseEncoding);
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
                    sendMessageToWebAPI["BufferSize"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPIbufferSize);
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
                sendMessageToWebAPI["HTTPRequestHeadersList"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPIhTTPRequestHeadersList);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPInegotiateTLS10 != null)
            {
                if (sendMessageToWebAPInegotiateTLS10 != null)
                {
                    sendMessageToWebAPI["NegotiateTLS10"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPInegotiateTLS10);
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
                    sendMessageToWebAPI["NegotiateTLS11"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPInegotiateTLS11);
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
                    sendMessageToWebAPI["NegotiateTLS12"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPInegotiateTLS12);
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
                    sendMessageToWebAPI["NegotiateTLS13"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPInegotiateTLS13);
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
                    sendMessageToWebAPI["KeepAlive"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPIkeepAlive);
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
                    sendMessageToWebAPI["Expect100Continue"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPIexpect100Continue);
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
                    sendMessageToWebAPI["ReturnResponseHeaders"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPIreturnResponseHeaders);
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
                    sendMessageToWebAPI["RunAsThread"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPIrunAsThread);
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
                    sendMessageToWebAPI["WaitForThread"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPIwaitForThread);
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
                sendMessageToWebAPI["RetrieveOutputDataFromThreadId"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPIretrieveOutputDataFromThreadId);
                sendMessageToWebAPIpropCount++;
            }

            sendMessageToWebAPIpropCount++;
            sendMessageToWebAPI["Workflow"] = CSharpExpressionConverter.ConvertToken(sendMessageToWebAPIworkflow);
            if (sendMessageToWebAPIpropCount > 0)
            {
                callPayload.Body = sendMessageToWebAPI;
            }

            return new ApiConnectionAction<SendMessageToWebAPIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewTaskResponse> TasksAddNewTask(Expression<Func<string>> tasksAddNewTaskworkflow, Expression<Func<tasksAddNewTasksetAutomationNameInput>> tasksAddNewTasksetAutomationName = null, Expression<Func<string>> tasksAddNewTaskautomationName = null, Expression<Func<string>> tasksAddNewTasktaskInputData = null, Expression<Func<string>> tasksAddNewTaskprocessStage = null, Expression<Func<int>> tasksAddNewTaskpriority = null, Expression<Func<int>> tasksAddNewTasksLA = null, Expression<Func<bool>> tasksAddNewTasktaskOnHold = null, Expression<Func<string>> tasksAddNewTaskorganisation = null, Expression<Func<string>> tasksAddNewTaskdepartment = null, Expression<Func<string>> tasksAddNewTaskdescription = null, Expression<Func<string>> tasksAddNewTasktags = null)
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
                    tasksAddNewTask["SetAutomationName"] = CSharpExpressionConverter.Convert(tasksAddNewTasksetAutomationName);
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
                tasksAddNewTask["AutomationName"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskautomationName);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTasktaskInputData != null)
            {
                tasksAddNewTask["TaskInputData"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTasktaskInputData);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTaskprocessStage != null)
            {
                tasksAddNewTask["ProcessStage"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskprocessStage);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTaskpriority != null)
            {
                if (tasksAddNewTaskpriority != null)
                {
                    tasksAddNewTask["Priority"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskpriority);
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
                tasksAddNewTask["SLA"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTasksLA);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTasktaskOnHold != null)
            {
                if (tasksAddNewTasktaskOnHold != null)
                {
                    tasksAddNewTask["TaskOnHold"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTasktaskOnHold);
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
                tasksAddNewTask["Organisation"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskorganisation);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTaskdepartment != null)
            {
                tasksAddNewTask["Department"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskdepartment);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTaskdescription != null)
            {
                tasksAddNewTask["Description"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskdescription);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTasktags != null)
            {
                tasksAddNewTask["Tags"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTasktags);
                tasksAddNewTaskpropCount++;
            }

            tasksAddNewTaskpropCount++;
            tasksAddNewTask["Workflow"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskworkflow);
            if (tasksAddNewTaskpropCount > 0)
            {
                callPayload.Body = tasksAddNewTask;
            }

            return new ApiConnectionAction<TasksAddNewTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewDeferralResponse> TasksAddNewDeferral(Expression<Func<string>> tasksAddNewDeferralworkflow, Expression<Func<tasksAddNewDeferralsetAutomationNameInput>> tasksAddNewDeferralsetAutomationName = null, Expression<Func<string>> tasksAddNewDeferralautomationName = null, Expression<Func<int>> tasksAddNewDeferraldeferralTimeInMinutes = null, Expression<Func<string>> tasksAddNewDeferraltaskInputData = null, Expression<Func<string>> tasksAddNewDeferraldeferralStoredData = null, Expression<Func<string>> tasksAddNewDeferralprocessStage = null, Expression<Func<int>> tasksAddNewDeferralpriority = null, Expression<Func<bool>> tasksAddNewDeferraltaskOnHold = null, Expression<Func<string>> tasksAddNewDeferralorganisation = null, Expression<Func<string>> tasksAddNewDeferraldepartment = null, Expression<Func<string>> tasksAddNewDeferraldescription = null, Expression<Func<string>> tasksAddNewDeferraltags = null)
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
                    tasksAddNewDeferral["SetAutomationName"] = CSharpExpressionConverter.Convert(tasksAddNewDeferralsetAutomationName);
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
                tasksAddNewDeferral["AutomationName"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralautomationName);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferraldeferralTimeInMinutes != null)
            {
                tasksAddNewDeferral["DeferralTimeInMinutes"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferraldeferralTimeInMinutes);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferraltaskInputData != null)
            {
                tasksAddNewDeferral["TaskInputData"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferraltaskInputData);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferraldeferralStoredData != null)
            {
                tasksAddNewDeferral["DeferralStoredData"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferraldeferralStoredData);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferralprocessStage != null)
            {
                tasksAddNewDeferral["ProcessStage"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralprocessStage);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferralpriority != null)
            {
                if (tasksAddNewDeferralpriority != null)
                {
                    tasksAddNewDeferral["Priority"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralpriority);
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
                    tasksAddNewDeferral["TaskOnHold"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferraltaskOnHold);
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
                tasksAddNewDeferral["Organisation"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralorganisation);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferraldepartment != null)
            {
                tasksAddNewDeferral["Department"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferraldepartment);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferraldescription != null)
            {
                tasksAddNewDeferral["Description"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferraldescription);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferraltags != null)
            {
                tasksAddNewDeferral["Tags"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferraltags);
                tasksAddNewDeferralpropCount++;
            }

            tasksAddNewDeferralpropCount++;
            tasksAddNewDeferral["Workflow"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralworkflow);
            if (tasksAddNewDeferralpropCount > 0)
            {
                callPayload.Body = tasksAddNewDeferral;
            }

            return new ApiConnectionAction<TasksAddNewDeferralResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeferExistingTaskResponse> TasksDeferExistingTask(Expression<Func<int>> tasksDeferExistingTasktaskId, Expression<Func<int>> tasksDeferExistingTaskdeferralTimeInMinutes = null, Expression<Func<string>> tasksDeferExistingTaskdeferralStoredData = null, Expression<Func<string>> tasksDeferExistingTaskprocessStage = null, Expression<Func<int>> tasksDeferExistingTaskpriority = null, Expression<Func<bool>> tasksDeferExistingTasktaskOnHold = null)
        {
            var apiCallPath = "/Environment/TasksDeferExistingTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksDeferExistingTask = new JObject();
            var tasksDeferExistingTaskpropCount = 0;
            tasksDeferExistingTaskpropCount++;
            tasksDeferExistingTask["TaskId"] = CSharpExpressionConverter.ConvertToken(tasksDeferExistingTasktaskId);
            if (tasksDeferExistingTaskdeferralTimeInMinutes != null)
            {
                tasksDeferExistingTask["DeferralTimeInMinutes"] = CSharpExpressionConverter.ConvertToken(tasksDeferExistingTaskdeferralTimeInMinutes);
                tasksDeferExistingTaskpropCount++;
            }

            if (tasksDeferExistingTaskdeferralStoredData != null)
            {
                tasksDeferExistingTask["DeferralStoredData"] = CSharpExpressionConverter.ConvertToken(tasksDeferExistingTaskdeferralStoredData);
                tasksDeferExistingTaskpropCount++;
            }

            if (tasksDeferExistingTaskprocessStage != null)
            {
                tasksDeferExistingTask["ProcessStage"] = CSharpExpressionConverter.ConvertToken(tasksDeferExistingTaskprocessStage);
                tasksDeferExistingTaskpropCount++;
            }

            if (tasksDeferExistingTaskpriority != null)
            {
                if (tasksDeferExistingTaskpriority != null)
                {
                    tasksDeferExistingTask["Priority"] = CSharpExpressionConverter.ConvertToken(tasksDeferExistingTaskpriority);
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
                    tasksDeferExistingTask["TaskOnHold"] = CSharpExpressionConverter.ConvertToken(tasksDeferExistingTasktaskOnHold);
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
        public IBodyWorkflowAction<TasksDeferExistingTaskOperationResponse> TasksDeferExistingTaskOperation(Expression<Func<string>> tasksDeferExistingTaskOperationoperationId, Expression<Func<int>> tasksDeferExistingTaskOperationdeferralTimeInMinutes = null, Expression<Func<string>> tasksDeferExistingTaskOperationdeferralStoredData = null, Expression<Func<string>> tasksDeferExistingTaskOperationprocessStage = null, Expression<Func<int>> tasksDeferExistingTaskOperationpriority = null)
        {
            var apiCallPath = "/Environment/TasksDeferExistingTaskOperation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksDeferExistingTaskOperation = new JObject();
            var tasksDeferExistingTaskOperationpropCount = 0;
            tasksDeferExistingTaskOperationpropCount++;
            tasksDeferExistingTaskOperation["OperationId"] = CSharpExpressionConverter.ConvertToken(tasksDeferExistingTaskOperationoperationId);
            if (tasksDeferExistingTaskOperationdeferralTimeInMinutes != null)
            {
                tasksDeferExistingTaskOperation["DeferralTimeInMinutes"] = CSharpExpressionConverter.ConvertToken(tasksDeferExistingTaskOperationdeferralTimeInMinutes);
                tasksDeferExistingTaskOperationpropCount++;
            }

            if (tasksDeferExistingTaskOperationdeferralStoredData != null)
            {
                tasksDeferExistingTaskOperation["DeferralStoredData"] = CSharpExpressionConverter.ConvertToken(tasksDeferExistingTaskOperationdeferralStoredData);
                tasksDeferExistingTaskOperationpropCount++;
            }

            if (tasksDeferExistingTaskOperationprocessStage != null)
            {
                tasksDeferExistingTaskOperation["ProcessStage"] = CSharpExpressionConverter.ConvertToken(tasksDeferExistingTaskOperationprocessStage);
                tasksDeferExistingTaskOperationpropCount++;
            }

            if (tasksDeferExistingTaskOperationpriority != null)
            {
                if (tasksDeferExistingTaskOperationpriority != null)
                {
                    tasksDeferExistingTaskOperation["Priority"] = CSharpExpressionConverter.ConvertToken(tasksDeferExistingTaskOperationpriority);
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
        public IBodyWorkflowAction<TasksDeleteTaskResponse> TasksDeleteTask(Expression<Func<int>> tasksDeleteTasktaskId, Expression<Func<bool>> tasksDeleteTaskupdateSourceSystem = null)
        {
            var apiCallPath = "/Environment/TasksDeleteTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksDeleteTask = new JObject();
            var tasksDeleteTaskpropCount = 0;
            tasksDeleteTaskpropCount++;
            tasksDeleteTask["TaskId"] = CSharpExpressionConverter.ConvertToken(tasksDeleteTasktaskId);
            if (tasksDeleteTaskupdateSourceSystem != null)
            {
                if (tasksDeleteTaskupdateSourceSystem != null)
                {
                    tasksDeleteTask["UpdateSourceSystem"] = CSharpExpressionConverter.ConvertToken(tasksDeleteTaskupdateSourceSystem);
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
        public IBodyWorkflowAction<TasksDeleteTaskOperationResponse> TasksDeleteTaskOperation(Expression<Func<string>> tasksDeleteTaskOperationoperationId, Expression<Func<bool>> tasksDeleteTaskOperationupdateSourceSystem = null)
        {
            var apiCallPath = "/Environment/TasksDeleteTaskOperation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksDeleteTaskOperation = new JObject();
            var tasksDeleteTaskOperationpropCount = 0;
            tasksDeleteTaskOperationpropCount++;
            tasksDeleteTaskOperation["OperationId"] = CSharpExpressionConverter.ConvertToken(tasksDeleteTaskOperationoperationId);
            if (tasksDeleteTaskOperationupdateSourceSystem != null)
            {
                if (tasksDeleteTaskOperationupdateSourceSystem != null)
                {
                    tasksDeleteTaskOperation["UpdateSourceSystem"] = CSharpExpressionConverter.ConvertToken(tasksDeleteTaskOperationupdateSourceSystem);
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
        public IBodyWorkflowAction<TasksGetAllTasksResponse> TasksGetAllTasks(Expression<Func<string>> tasksGetAllTasksautomationName = null, Expression<Func<tasksGetAllTasksautomationTaskStatusInput>> tasksGetAllTasksautomationTaskStatus = null, Expression<Func<string>> tasksGetAllTasksfilterByPropertyQuery = null, Expression<Func<int>> tasksGetAllTasksminutesUntilDeferralDate = null, Expression<Func<int>> tasksGetAllTasksminimumPriorityLevel = null, Expression<Func<bool>> tasksGetAllTaskssortByDeferralDate = null, Expression<Func<bool>> tasksGetAllTasksretrieveOnHoldTasks = null, Expression<Func<int>> tasksGetAllTasksskip = null, Expression<Func<int>> tasksGetAllTasksmaxResults = null, Expression<Func<bool>> tasksGetAllTasksexcludeTaskData = null)
        {
            var apiCallPath = "/Environment/TasksGetAllTasks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksGetAllTasks = new JObject();
            var tasksGetAllTaskspropCount = 0;
            if (tasksGetAllTasksautomationName != null)
            {
                tasksGetAllTasks["AutomationName"] = CSharpExpressionConverter.ConvertToken(tasksGetAllTasksautomationName);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksautomationTaskStatus != null)
            {
                tasksGetAllTasks["AutomationTaskStatus"] = CSharpExpressionConverter.Convert(tasksGetAllTasksautomationTaskStatus);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksfilterByPropertyQuery != null)
            {
                tasksGetAllTasks["FilterByPropertyQuery"] = CSharpExpressionConverter.ConvertToken(tasksGetAllTasksfilterByPropertyQuery);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksminutesUntilDeferralDate != null)
            {
                tasksGetAllTasks["MinutesUntilDeferralDate"] = CSharpExpressionConverter.ConvertToken(tasksGetAllTasksminutesUntilDeferralDate);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksminimumPriorityLevel != null)
            {
                tasksGetAllTasks["MinimumPriorityLevel"] = CSharpExpressionConverter.ConvertToken(tasksGetAllTasksminimumPriorityLevel);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTaskssortByDeferralDate != null)
            {
                if (tasksGetAllTaskssortByDeferralDate != null)
                {
                    tasksGetAllTasks["SortByDeferralDate"] = CSharpExpressionConverter.ConvertToken(tasksGetAllTaskssortByDeferralDate);
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
                    tasksGetAllTasks["RetrieveOnHoldTasks"] = CSharpExpressionConverter.ConvertToken(tasksGetAllTasksretrieveOnHoldTasks);
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
                    tasksGetAllTasks["Skip"] = CSharpExpressionConverter.ConvertToken(tasksGetAllTasksskip);
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
                    tasksGetAllTasks["MaxResults"] = CSharpExpressionConverter.ConvertToken(tasksGetAllTasksmaxResults);
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
                    tasksGetAllTasks["ExcludeTaskData"] = CSharpExpressionConverter.ConvertToken(tasksGetAllTasksexcludeTaskData);
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
        public IBodyWorkflowAction<TasksGetTaskResponse> TasksGetTask(Expression<Func<int>> tasksGetTasktaskId, Expression<Func<tasksGetTaskstatusChangeInput>> tasksGetTaskstatusChange = null)
        {
            var apiCallPath = "/Environment/TasksGetTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksGetTask = new JObject();
            var tasksGetTaskpropCount = 0;
            tasksGetTaskpropCount++;
            tasksGetTask["TaskId"] = CSharpExpressionConverter.ConvertToken(tasksGetTasktaskId);
            if (tasksGetTaskstatusChange != null)
            {
                if (tasksGetTaskstatusChange != null)
                {
                    tasksGetTask["StatusChange"] = CSharpExpressionConverter.Convert(tasksGetTaskstatusChange);
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
        public IBodyWorkflowAction<TasksGetNextTaskResponse> TasksGetNextTask(Expression<Func<string>> tasksGetNextTaskautomationName = null, Expression<Func<string[]>> tasksGetNextTaskautomationNames = null, Expression<Func<int>> tasksGetNextTaskminimumPriorityLevel = null, Expression<Func<tasksGetNextTaskstatusChangeInput>> tasksGetNextTaskstatusChange = null, Expression<Func<int>> tasksGetNextTaskminutesUntilDeferralDate = null, Expression<Func<bool>> tasksGetNextTaskignoreSLA = null, Expression<Func<int[]>> tasksGetNextTaskexcludeTaskIds = null)
        {
            var apiCallPath = "/Environment/TasksGetNextTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksGetNextTask = new JObject();
            var tasksGetNextTaskpropCount = 0;
            if (tasksGetNextTaskautomationName != null)
            {
                tasksGetNextTask["AutomationName"] = CSharpExpressionConverter.ConvertToken(tasksGetNextTaskautomationName);
                tasksGetNextTaskpropCount++;
            }

            if (tasksGetNextTaskautomationNames != null)
            {
                tasksGetNextTask["AutomationNames"] = CSharpExpressionConverter.ConvertToken(tasksGetNextTaskautomationNames);
                tasksGetNextTaskpropCount++;
            }

            if (tasksGetNextTaskminimumPriorityLevel != null)
            {
                tasksGetNextTask["MinimumPriorityLevel"] = CSharpExpressionConverter.ConvertToken(tasksGetNextTaskminimumPriorityLevel);
                tasksGetNextTaskpropCount++;
            }

            if (tasksGetNextTaskstatusChange != null)
            {
                if (tasksGetNextTaskstatusChange != null)
                {
                    tasksGetNextTask["StatusChange"] = CSharpExpressionConverter.Convert(tasksGetNextTaskstatusChange);
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
                    tasksGetNextTask["MinutesUntilDeferralDate"] = CSharpExpressionConverter.ConvertToken(tasksGetNextTaskminutesUntilDeferralDate);
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
                    tasksGetNextTask["IgnoreSLA"] = CSharpExpressionConverter.ConvertToken(tasksGetNextTaskignoreSLA);
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
                tasksGetNextTask["ExcludeTaskIds"] = CSharpExpressionConverter.ConvertToken(tasksGetNextTaskexcludeTaskIds);
                tasksGetNextTaskpropCount++;
            }

            if (tasksGetNextTaskpropCount > 0)
            {
                callPayload.Body = tasksGetNextTask;
            }

            return new ApiConnectionAction<TasksGetNextTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksChangeTaskStatusResponse> TasksChangeTaskStatus(Expression<Func<int>> tasksChangeTaskStatustaskId, Expression<Func<tasksChangeTaskStatusautomationTaskStatusInput>> tasksChangeTaskStatusautomationTaskStatus = null, Expression<Func<bool>> tasksChangeTaskStatustaskOnHold = null, Expression<Func<bool>> tasksChangeTaskStatuseraseTaskInputData = null, Expression<Func<bool>> tasksChangeTaskStatuseraseDeferralStoredData = null, Expression<Func<bool>> tasksChangeTaskStatusupdateSourceSystem = null, Expression<Func<string>> tasksChangeTaskStatustaskClosureReason = null)
        {
            var apiCallPath = "/Environment/TasksChangeTaskStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksChangeTaskStatus = new JObject();
            var tasksChangeTaskStatuspropCount = 0;
            tasksChangeTaskStatuspropCount++;
            tasksChangeTaskStatus["TaskId"] = CSharpExpressionConverter.ConvertToken(tasksChangeTaskStatustaskId);
            if (tasksChangeTaskStatusautomationTaskStatus != null)
            {
                tasksChangeTaskStatus["AutomationTaskStatus"] = CSharpExpressionConverter.Convert(tasksChangeTaskStatusautomationTaskStatus);
                tasksChangeTaskStatuspropCount++;
            }

            if (tasksChangeTaskStatustaskOnHold != null)
            {
                if (tasksChangeTaskStatustaskOnHold != null)
                {
                    tasksChangeTaskStatus["TaskOnHold"] = CSharpExpressionConverter.ConvertToken(tasksChangeTaskStatustaskOnHold);
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
                    tasksChangeTaskStatus["EraseTaskInputData"] = CSharpExpressionConverter.ConvertToken(tasksChangeTaskStatuseraseTaskInputData);
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
                    tasksChangeTaskStatus["EraseDeferralStoredData"] = CSharpExpressionConverter.ConvertToken(tasksChangeTaskStatuseraseDeferralStoredData);
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
                    tasksChangeTaskStatus["UpdateSourceSystem"] = CSharpExpressionConverter.ConvertToken(tasksChangeTaskStatusupdateSourceSystem);
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
                tasksChangeTaskStatus["TaskClosureReason"] = CSharpExpressionConverter.ConvertToken(tasksChangeTaskStatustaskClosureReason);
                tasksChangeTaskStatuspropCount++;
            }

            if (tasksChangeTaskStatuspropCount > 0)
            {
                callPayload.Body = tasksChangeTaskStatus;
            }

            return new ApiConnectionAction<TasksChangeTaskStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNoteResponse> TasksAddNote(Expression<Func<int>> tasksAddNotetaskId, Expression<Func<string>> tasksAddNotenoteText, Expression<Func<tasksAddNotenoteTypeInput>> tasksAddNotenoteType = null, Expression<Func<string>> tasksAddNotenoteTypeOther = null)
        {
            var apiCallPath = "/Environment/TasksAddNote";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksAddNote = new JObject();
            var tasksAddNotepropCount = 0;
            tasksAddNotepropCount++;
            tasksAddNote["TaskId"] = CSharpExpressionConverter.ConvertToken(tasksAddNotetaskId);
            tasksAddNotepropCount++;
            tasksAddNote["NoteText"] = CSharpExpressionConverter.ConvertToken(tasksAddNotenoteText);
            if (tasksAddNotenoteType != null)
            {
                if (tasksAddNotenoteType != null)
                {
                    tasksAddNote["NoteType"] = CSharpExpressionConverter.Convert(tasksAddNotenoteType);
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
                tasksAddNote["NoteTypeOther"] = CSharpExpressionConverter.ConvertToken(tasksAddNotenoteTypeOther);
                tasksAddNotepropCount++;
            }

            if (tasksAddNotepropCount > 0)
            {
                callPayload.Body = tasksAddNote;
            }

            return new ApiConnectionAction<TasksAddNoteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAssignTaskResponse> TasksAssignTask(Expression<Func<int>> tasksAssignTasktaskId, Expression<Func<string>> tasksAssignTaskassignToUserId = null, Expression<Func<string>> tasksAssignTaskassignToUserName = null, Expression<Func<string>> tasksAssignTaskassignToGroupId = null, Expression<Func<string>> tasksAssignTaskassignToGroupName = null, Expression<Func<bool>> tasksAssignTaskremoveUserAssignmentIfBlank = null, Expression<Func<bool>> tasksAssignTaskremoveGroupAssignmentIfBlank = null)
        {
            var apiCallPath = "/Environment/TasksAssignTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksAssignTask = new JObject();
            var tasksAssignTaskpropCount = 0;
            tasksAssignTaskpropCount++;
            tasksAssignTask["TaskId"] = CSharpExpressionConverter.ConvertToken(tasksAssignTasktaskId);
            if (tasksAssignTaskassignToUserId != null)
            {
                tasksAssignTask["AssignToUserId"] = CSharpExpressionConverter.ConvertToken(tasksAssignTaskassignToUserId);
                tasksAssignTaskpropCount++;
            }

            if (tasksAssignTaskassignToUserName != null)
            {
                tasksAssignTask["AssignToUserName"] = CSharpExpressionConverter.ConvertToken(tasksAssignTaskassignToUserName);
                tasksAssignTaskpropCount++;
            }

            if (tasksAssignTaskassignToGroupId != null)
            {
                tasksAssignTask["AssignToGroupId"] = CSharpExpressionConverter.ConvertToken(tasksAssignTaskassignToGroupId);
                tasksAssignTaskpropCount++;
            }

            if (tasksAssignTaskassignToGroupName != null)
            {
                tasksAssignTask["AssignToGroupName"] = CSharpExpressionConverter.ConvertToken(tasksAssignTaskassignToGroupName);
                tasksAssignTaskpropCount++;
            }

            if (tasksAssignTaskremoveUserAssignmentIfBlank != null)
            {
                if (tasksAssignTaskremoveUserAssignmentIfBlank != null)
                {
                    tasksAssignTask["RemoveUserAssignmentIfBlank"] = CSharpExpressionConverter.ConvertToken(tasksAssignTaskremoveUserAssignmentIfBlank);
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
                    tasksAssignTask["RemoveGroupAssignmentIfBlank"] = CSharpExpressionConverter.ConvertToken(tasksAssignTaskremoveGroupAssignmentIfBlank);
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
        public IBodyWorkflowAction<TasksSetOutputDataResponse> TasksSetOutputData(Expression<Func<int>> tasksSetOutputDatataskId, Expression<Func<string>> tasksSetOutputDatataskOutputData = null)
        {
            var apiCallPath = "/Environment/TasksSetOutputData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksSetOutputData = new JObject();
            var tasksSetOutputDatapropCount = 0;
            tasksSetOutputDatapropCount++;
            tasksSetOutputData["TaskId"] = CSharpExpressionConverter.ConvertToken(tasksSetOutputDatataskId);
            if (tasksSetOutputDatataskOutputData != null)
            {
                tasksSetOutputData["TaskOutputData"] = CSharpExpressionConverter.ConvertToken(tasksSetOutputDatataskOutputData);
                tasksSetOutputDatapropCount++;
            }

            if (tasksSetOutputDatapropCount > 0)
            {
                callPayload.Body = tasksSetOutputData;
            }

            return new ApiConnectionAction<TasksSetOutputDataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewTaskOperationResponse> TasksAddNewTaskOperation(Expression<Func<string>> tasksAddNewTaskOperationautomationName = null, Expression<Func<string>> tasksAddNewTaskOperationtaskInputData = null, Expression<Func<string>> tasksAddNewTaskOperationprocessStage = null, Expression<Func<int>> tasksAddNewTaskOperationpriority = null, Expression<Func<int>> tasksAddNewTaskOperationsLA = null, Expression<Func<string>> tasksAddNewTaskOperationorganisation = null, Expression<Func<string>> tasksAddNewTaskOperationdepartment = null, Expression<Func<string>> tasksAddNewTaskOperationdescription = null, Expression<Func<string>> tasksAddNewTaskOperationtags = null)
        {
            var apiCallPath = "/Environment/TasksAddNewTaskOperation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksAddNewTaskOperation = new JObject();
            var tasksAddNewTaskOperationpropCount = 0;
            if (tasksAddNewTaskOperationautomationName != null)
            {
                tasksAddNewTaskOperation["AutomationName"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskOperationautomationName);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationtaskInputData != null)
            {
                tasksAddNewTaskOperation["TaskInputData"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskOperationtaskInputData);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationprocessStage != null)
            {
                tasksAddNewTaskOperation["ProcessStage"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskOperationprocessStage);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationpriority != null)
            {
                if (tasksAddNewTaskOperationpriority != null)
                {
                    tasksAddNewTaskOperation["Priority"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskOperationpriority);
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
                tasksAddNewTaskOperation["SLA"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskOperationsLA);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationorganisation != null)
            {
                tasksAddNewTaskOperation["Organisation"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskOperationorganisation);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationdepartment != null)
            {
                tasksAddNewTaskOperation["Department"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskOperationdepartment);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationdescription != null)
            {
                tasksAddNewTaskOperation["Description"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskOperationdescription);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationtags != null)
            {
                tasksAddNewTaskOperation["Tags"] = CSharpExpressionConverter.ConvertToken(tasksAddNewTaskOperationtags);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationpropCount > 0)
            {
                callPayload.Body = tasksAddNewTaskOperation;
            }

            return new ApiConnectionAction<TasksAddNewTaskOperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewDeferralOperationResponse> TasksAddNewDeferralOperation(Expression<Func<string>> tasksAddNewDeferralOperationautomationName = null, Expression<Func<int>> tasksAddNewDeferralOperationdeferralTimeInMinutes = null, Expression<Func<string>> tasksAddNewDeferralOperationtaskInputData = null, Expression<Func<string>> tasksAddNewDeferralOperationdeferralStoredData = null, Expression<Func<string>> tasksAddNewDeferralOperationprocessStage = null, Expression<Func<int>> tasksAddNewDeferralOperationpriority = null, Expression<Func<string>> tasksAddNewDeferralOperationorganisation = null, Expression<Func<string>> tasksAddNewDeferralOperationdepartment = null, Expression<Func<string>> tasksAddNewDeferralOperationdescription = null, Expression<Func<string>> tasksAddNewDeferralOperationtags = null)
        {
            var apiCallPath = "/Environment/TasksAddNewDeferralOperation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksAddNewDeferralOperation = new JObject();
            var tasksAddNewDeferralOperationpropCount = 0;
            if (tasksAddNewDeferralOperationautomationName != null)
            {
                tasksAddNewDeferralOperation["AutomationName"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralOperationautomationName);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationdeferralTimeInMinutes != null)
            {
                tasksAddNewDeferralOperation["DeferralTimeInMinutes"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralOperationdeferralTimeInMinutes);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationtaskInputData != null)
            {
                tasksAddNewDeferralOperation["TaskInputData"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralOperationtaskInputData);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationdeferralStoredData != null)
            {
                tasksAddNewDeferralOperation["DeferralStoredData"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralOperationdeferralStoredData);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationprocessStage != null)
            {
                tasksAddNewDeferralOperation["ProcessStage"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralOperationprocessStage);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationpriority != null)
            {
                if (tasksAddNewDeferralOperationpriority != null)
                {
                    tasksAddNewDeferralOperation["Priority"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralOperationpriority);
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
                tasksAddNewDeferralOperation["Organisation"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralOperationorganisation);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationdepartment != null)
            {
                tasksAddNewDeferralOperation["Department"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralOperationdepartment);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationdescription != null)
            {
                tasksAddNewDeferralOperation["Description"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralOperationdescription);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationtags != null)
            {
                tasksAddNewDeferralOperation["Tags"] = CSharpExpressionConverter.ConvertToken(tasksAddNewDeferralOperationtags);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationpropCount > 0)
            {
                callPayload.Body = tasksAddNewDeferralOperation;
            }

            return new ApiConnectionAction<TasksAddNewDeferralOperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetTaskOperationResponse> TasksGetTaskOperation(Expression<Func<string>> tasksGetTaskOperationoperationId)
        {
            var apiCallPath = "/Environment/TasksGetTaskOperation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksGetTaskOperation = new JObject();
            var tasksGetTaskOperationpropCount = 0;
            tasksGetTaskOperationpropCount++;
            tasksGetTaskOperation["OperationId"] = CSharpExpressionConverter.ConvertToken(tasksGetTaskOperationoperationId);
            if (tasksGetTaskOperationpropCount > 0)
            {
                callPayload.Body = tasksGetTaskOperation;
            }

            return new ApiConnectionAction<TasksGetTaskOperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRemoteLoggingLevel(Expression<Func<int>> setRemoteLoggingLevelloggingLevel, Expression<Func<string>> setRemoteLoggingLevelworkflow)
        {
            var apiCallPath = "/DriverControl/SetRemoteLoggingLevel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setRemoteLoggingLevel = new JObject();
            var setRemoteLoggingLevelpropCount = 0;
            setRemoteLoggingLevelpropCount++;
            setRemoteLoggingLevel["LoggingLevel"] = CSharpExpressionConverter.ConvertToken(setRemoteLoggingLevelloggingLevel);
            setRemoteLoggingLevelpropCount++;
            setRemoteLoggingLevel["Workflow"] = CSharpExpressionConverter.ConvertToken(setRemoteLoggingLevelworkflow);
            if (setRemoteLoggingLevelpropCount > 0)
            {
                callPayload.Body = setRemoteLoggingLevel;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteLoggingLevelResponse> GetRemoteLoggingLevel(Expression<Func<string>> getRemoteLoggingLevelworkflow)
        {
            var apiCallPath = "/DriverControl/GetRemoteLoggingLevel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRemoteLoggingLevel = new JObject();
            var getRemoteLoggingLevelpropCount = 0;
            getRemoteLoggingLevelpropCount++;
            getRemoteLoggingLevel["Workflow"] = CSharpExpressionConverter.ConvertToken(getRemoteLoggingLevelworkflow);
            if (getRemoteLoggingLevelpropCount > 0)
            {
                callPayload.Body = getRemoteLoggingLevel;
            }

            return new ApiConnectionAction<GetRemoteLoggingLevelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetLicenseCode(Expression<Func<string>> setLicenseCodecustomerNETBIOSDomainName, Expression<Func<string>> setLicenseCodecustomerDisplayName, Expression<Func<string>> setLicenseCodevendorName, Expression<Func<string>> setLicenseCodelicenseExpiryDate, Expression<Func<string>> setLicenseCodeactivationCode, Expression<Func<string>> setLicenseCodeworkflow, Expression<Func<bool>> setLicenseCodestoreInRegistry = null)
        {
            var apiCallPath = "/DriverControl/SetLicenseCode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setLicenseCode = new JObject();
            var setLicenseCodepropCount = 0;
            setLicenseCodepropCount++;
            setLicenseCode["CustomerNETBIOSDomainName"] = CSharpExpressionConverter.ConvertToken(setLicenseCodecustomerNETBIOSDomainName);
            setLicenseCodepropCount++;
            setLicenseCode["CustomerDisplayName"] = CSharpExpressionConverter.ConvertToken(setLicenseCodecustomerDisplayName);
            setLicenseCodepropCount++;
            setLicenseCode["VendorName"] = CSharpExpressionConverter.ConvertToken(setLicenseCodevendorName);
            setLicenseCodepropCount++;
            setLicenseCode["LicenseExpiryDate"] = CSharpExpressionConverter.ConvertToken(setLicenseCodelicenseExpiryDate);
            setLicenseCodepropCount++;
            setLicenseCode["ActivationCode"] = CSharpExpressionConverter.ConvertToken(setLicenseCodeactivationCode);
            if (setLicenseCodestoreInRegistry != null)
            {
                if (setLicenseCodestoreInRegistry != null)
                {
                    setLicenseCode["StoreInRegistry"] = CSharpExpressionConverter.ConvertToken(setLicenseCodestoreInRegistry);
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
            setLicenseCode["Workflow"] = CSharpExpressionConverter.ConvertToken(setLicenseCodeworkflow);
            if (setLicenseCodepropCount > 0)
            {
                callPayload.Body = setLicenseCode;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetLicenseStringResponse> SetLicenseString(Expression<Func<string>> setLicenseStringlicenseString, Expression<Func<string>> setLicenseStringworkflow, Expression<Func<bool>> setLicenseStringstoreInRegistry = null)
        {
            var apiCallPath = "/DriverControl/SetLicenseString";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setLicenseString = new JObject();
            var setLicenseStringpropCount = 0;
            setLicenseStringpropCount++;
            setLicenseString["LicenseString"] = CSharpExpressionConverter.ConvertToken(setLicenseStringlicenseString);
            if (setLicenseStringstoreInRegistry != null)
            {
                if (setLicenseStringstoreInRegistry != null)
                {
                    setLicenseString["StoreInRegistry"] = CSharpExpressionConverter.ConvertToken(setLicenseStringstoreInRegistry);
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
            setLicenseString["Workflow"] = CSharpExpressionConverter.ConvertToken(setLicenseStringworkflow);
            if (setLicenseStringpropCount > 0)
            {
                callPayload.Body = setLicenseString;
            }

            return new ApiConnectionAction<SetLicenseStringResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLicenseStateResponse> GetLicenseState(Expression<Func<string>> getLicenseStateworkflow)
        {
            var apiCallPath = "/DriverControl/GetLicenseState";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getLicenseState = new JObject();
            var getLicenseStatepropCount = 0;
            getLicenseStatepropCount++;
            getLicenseState["Workflow"] = CSharpExpressionConverter.ConvertToken(getLicenseStateworkflow);
            if (getLicenseStatepropCount > 0)
            {
                callPayload.Body = getLicenseState;
            }

            return new ApiConnectionAction<GetLicenseStateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUITopmost(Expression<Func<string>> setRSAGUITopmostworkflow, Expression<Func<bool>> setRSAGUITopmosttopMost = null)
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
                    setRSAGUITopmost["TopMost"] = CSharpExpressionConverter.ConvertToken(setRSAGUITopmosttopMost);
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
            setRSAGUITopmost["Workflow"] = CSharpExpressionConverter.ConvertToken(setRSAGUITopmostworkflow);
            if (setRSAGUITopmostpropCount > 0)
            {
                callPayload.Body = setRSAGUITopmost;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUIOpacity(Expression<Func<double>> setRSAGUIOpacityopacity, Expression<Func<string>> setRSAGUIOpacityworkflow)
        {
            var apiCallPath = "/DriverControl/SetRSAGUIOpacity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setRSAGUIOpacity = new JObject();
            var setRSAGUIOpacitypropCount = 0;
            setRSAGUIOpacitypropCount++;
            setRSAGUIOpacity["Opacity"] = CSharpExpressionConverter.ConvertToken(setRSAGUIOpacityopacity);
            setRSAGUIOpacitypropCount++;
            setRSAGUIOpacity["Workflow"] = CSharpExpressionConverter.ConvertToken(setRSAGUIOpacityworkflow);
            if (setRSAGUIOpacitypropCount > 0)
            {
                callPayload.Body = setRSAGUIOpacity;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUIPosition(Expression<Func<int>> setRSAGUIPositionx, Expression<Func<int>> setRSAGUIPositiony, Expression<Func<string>> setRSAGUIPositionworkflow)
        {
            var apiCallPath = "/DriverControl/SetRSAGUIPosition";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setRSAGUIPosition = new JObject();
            var setRSAGUIPositionpropCount = 0;
            setRSAGUIPositionpropCount++;
            setRSAGUIPosition["X"] = CSharpExpressionConverter.ConvertToken(setRSAGUIPositionx);
            setRSAGUIPositionpropCount++;
            setRSAGUIPosition["Y"] = CSharpExpressionConverter.ConvertToken(setRSAGUIPositiony);
            setRSAGUIPositionpropCount++;
            setRSAGUIPosition["Workflow"] = CSharpExpressionConverter.ConvertToken(setRSAGUIPositionworkflow);
            if (setRSAGUIPositionpropCount > 0)
            {
                callPayload.Body = setRSAGUIPosition;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction BringRSAGUIToFront(Expression<Func<string>> bringRSAGUIToFrontworkflow, Expression<Func<bool>> bringRSAGUIToFrontfocus = null, Expression<Func<bool>> bringRSAGUIToFrontglobalLeftMouseClick = null)
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
                    bringRSAGUIToFront["Focus"] = CSharpExpressionConverter.ConvertToken(bringRSAGUIToFrontfocus);
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
                    bringRSAGUIToFront["GlobalLeftMouseClick"] = CSharpExpressionConverter.ConvertToken(bringRSAGUIToFrontglobalLeftMouseClick);
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
            bringRSAGUIToFront["Workflow"] = CSharpExpressionConverter.ConvertToken(bringRSAGUIToFrontworkflow);
            if (bringRSAGUIToFrontpropCount > 0)
            {
                callPayload.Body = bringRSAGUIToFront;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DisconnectSession(Expression<Func<string>> disconnectSessionworkflow, Expression<Func<int>> disconnectSessionsecondsToWait = null, Expression<Func<bool>> disconnectSessiondoNotDisconnectIfLocalAgent = null)
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
                    disconnectSession["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(disconnectSessionsecondsToWait);
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
                    disconnectSession["DoNotDisconnectIfLocalAgent"] = CSharpExpressionConverter.ConvertToken(disconnectSessiondoNotDisconnectIfLocalAgent);
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
            disconnectSession["Workflow"] = CSharpExpressionConverter.ConvertToken(disconnectSessionworkflow);
            if (disconnectSessionpropCount > 0)
            {
                callPayload.Body = disconnectSession;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LogoffSession(Expression<Func<string>> logoffSessionworkflow, Expression<Func<int>> logoffSessionsecondsToWait = null)
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
                    logoffSession["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(logoffSessionsecondsToWait);
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
            logoffSession["Workflow"] = CSharpExpressionConverter.ConvertToken(logoffSessionworkflow);
            if (logoffSessionpropCount > 0)
            {
                callPayload.Body = logoffSession;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CloseRSAServer(Expression<Func<string>> closeRSAServerworkflow, Expression<Func<int>> closeRSAServersecondsToWait = null)
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
                    closeRSAServer["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(closeRSAServersecondsToWait);
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
            closeRSAServer["Workflow"] = CSharpExpressionConverter.ConvertToken(closeRSAServerworkflow);
            if (closeRSAServerpropCount > 0)
            {
                callPayload.Body = closeRSAServer;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRPACommandTimeout(Expression<Func<int>> setRPACommandTimeoutcommandTimeoutInSeconds, Expression<Func<string>> setRPACommandTimeoutworkflow, Expression<Func<bool>> setRPACommandTimeoutterminateTimedoutRPACommandThreads = null)
        {
            var apiCallPath = "/DriverControl/SetRPACommandTimeout";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setRPACommandTimeout = new JObject();
            var setRPACommandTimeoutpropCount = 0;
            setRPACommandTimeoutpropCount++;
            setRPACommandTimeout["CommandTimeoutInSeconds"] = CSharpExpressionConverter.ConvertToken(setRPACommandTimeoutcommandTimeoutInSeconds);
            if (setRPACommandTimeoutterminateTimedoutRPACommandThreads != null)
            {
                if (setRPACommandTimeoutterminateTimedoutRPACommandThreads != null)
                {
                    setRPACommandTimeout["TerminateTimedoutRPACommandThreads"] = CSharpExpressionConverter.ConvertToken(setRPACommandTimeoutterminateTimedoutRPACommandThreads);
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
            setRPACommandTimeout["Workflow"] = CSharpExpressionConverter.ConvertToken(setRPACommandTimeoutworkflow);
            if (setRPACommandTimeoutpropCount > 0)
            {
                callPayload.Body = setRPACommandTimeout;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RunAlternativeIAConnect(Expression<Func<string>> runAlternativeIAConnectfilename, Expression<Func<string>> runAlternativeIAConnectworkflow, Expression<Func<string>> runAlternativeIAConnectarguments = null, Expression<Func<bool>> runAlternativeIAConnectloadIntoMemory = null)
        {
            var apiCallPath = "/DriverControl/RunAlternativeIAConnect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runAlternativeIAConnect = new JObject();
            var runAlternativeIAConnectpropCount = 0;
            runAlternativeIAConnectpropCount++;
            runAlternativeIAConnect["Filename"] = CSharpExpressionConverter.ConvertToken(runAlternativeIAConnectfilename);
            if (runAlternativeIAConnectarguments != null)
            {
                runAlternativeIAConnect["Arguments"] = CSharpExpressionConverter.ConvertToken(runAlternativeIAConnectarguments);
                runAlternativeIAConnectpropCount++;
            }

            if (runAlternativeIAConnectloadIntoMemory != null)
            {
                if (runAlternativeIAConnectloadIntoMemory != null)
                {
                    runAlternativeIAConnect["LoadIntoMemory"] = CSharpExpressionConverter.ConvertToken(runAlternativeIAConnectloadIntoMemory);
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
            runAlternativeIAConnect["Workflow"] = CSharpExpressionConverter.ConvertToken(runAlternativeIAConnectworkflow);
            if (runAlternativeIAConnectpropCount > 0)
            {
                callPayload.Body = runAlternativeIAConnect;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunAlternativeIAConnectSentFromDirectorResponse> RunAlternativeIAConnectSentFromDirector(Expression<Func<string>> runAlternativeIAConnectSentFromDirectorlocalFilename, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorworkflow, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorremoteFilename = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorcompress = null, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorarguments = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorpermitDowngrade = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorskipVersionCheck = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorloadIntoMemory = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory = null)
        {
            var apiCallPath = "/DriverControl/RunAlternativeIAConnectSentFromDirector";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runAlternativeIAConnectSentFromDirector = new JObject();
            var runAlternativeIAConnectSentFromDirectorpropCount = 0;
            runAlternativeIAConnectSentFromDirectorpropCount++;
            runAlternativeIAConnectSentFromDirector["LocalFilename"] = CSharpExpressionConverter.ConvertToken(runAlternativeIAConnectSentFromDirectorlocalFilename);
            if (runAlternativeIAConnectSentFromDirectorremoteFilename != null)
            {
                runAlternativeIAConnectSentFromDirector["RemoteFilename"] = CSharpExpressionConverter.ConvertToken(runAlternativeIAConnectSentFromDirectorremoteFilename);
                runAlternativeIAConnectSentFromDirectorpropCount++;
            }

            if (runAlternativeIAConnectSentFromDirectorcompress != null)
            {
                if (runAlternativeIAConnectSentFromDirectorcompress != null)
                {
                    runAlternativeIAConnectSentFromDirector["Compress"] = CSharpExpressionConverter.ConvertToken(runAlternativeIAConnectSentFromDirectorcompress);
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
                runAlternativeIAConnectSentFromDirector["Arguments"] = CSharpExpressionConverter.ConvertToken(runAlternativeIAConnectSentFromDirectorarguments);
                runAlternativeIAConnectSentFromDirectorpropCount++;
            }

            if (runAlternativeIAConnectSentFromDirectorpermitDowngrade != null)
            {
                if (runAlternativeIAConnectSentFromDirectorpermitDowngrade != null)
                {
                    runAlternativeIAConnectSentFromDirector["PermitDowngrade"] = CSharpExpressionConverter.ConvertToken(runAlternativeIAConnectSentFromDirectorpermitDowngrade);
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
                    runAlternativeIAConnectSentFromDirector["SkipVersionCheck"] = CSharpExpressionConverter.ConvertToken(runAlternativeIAConnectSentFromDirectorskipVersionCheck);
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
                    runAlternativeIAConnectSentFromDirector["LoadIntoMemory"] = CSharpExpressionConverter.ConvertToken(runAlternativeIAConnectSentFromDirectorloadIntoMemory);
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
                    runAlternativeIAConnectSentFromDirector["SaveToDiskEvenIfRunningFromMemory"] = CSharpExpressionConverter.ConvertToken(runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory);
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
            runAlternativeIAConnectSentFromDirector["Workflow"] = CSharpExpressionConverter.ConvertToken(runAlternativeIAConnectSentFromDirectorworkflow);
            if (runAlternativeIAConnectSentFromDirectorpropCount > 0)
            {
                callPayload.Body = runAlternativeIAConnectSentFromDirector;
            }

            return new ApiConnectionAction<RunAlternativeIAConnectSentFromDirectorResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectAgentInfoResponse> GetIAConnectAgentInfo(Expression<Func<string>> getIAConnectAgentInfoworkflow)
        {
            var apiCallPath = "/DriverControl/GetIAConnectAgentInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getIAConnectAgentInfo = new JObject();
            var getIAConnectAgentInfopropCount = 0;
            getIAConnectAgentInfopropCount++;
            getIAConnectAgentInfo["Workflow"] = CSharpExpressionConverter.ConvertToken(getIAConnectAgentInfoworkflow);
            if (getIAConnectAgentInfopropCount > 0)
            {
                callPayload.Body = getIAConnectAgentInfo;
            }

            return new ApiConnectionAction<GetIAConnectAgentInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectAgentLogResponse> GetIAConnectAgentLog(Expression<Func<string>> getIAConnectAgentLogworkflow, Expression<Func<bool>> getIAConnectAgentLogcompress = null, Expression<Func<bool>> getIAConnectAgentLogreturnLastCommandOnly = null, Expression<Func<bool>> getIAConnectAgentLogsaveLogToFile = null, Expression<Func<bool>> getIAConnectAgentLogplaceLogContentInDataItem = null, Expression<Func<string>> getIAConnectAgentLoglocalSaveFolder = null, Expression<Func<bool>> getIAConnectAgentLoguseAgentLogFilename = null, Expression<Func<string>> getIAConnectAgentLoglocalSaveFilename = null, Expression<Func<int>> getIAConnectAgentLogmaxBytesToRead = null)
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
                    getIAConnectAgentLog["Compress"] = CSharpExpressionConverter.ConvertToken(getIAConnectAgentLogcompress);
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
                    getIAConnectAgentLog["ReturnLastCommandOnly"] = CSharpExpressionConverter.ConvertToken(getIAConnectAgentLogreturnLastCommandOnly);
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
                    getIAConnectAgentLog["SaveLogToFile"] = CSharpExpressionConverter.ConvertToken(getIAConnectAgentLogsaveLogToFile);
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
                    getIAConnectAgentLog["PlaceLogContentInDataItem"] = CSharpExpressionConverter.ConvertToken(getIAConnectAgentLogplaceLogContentInDataItem);
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
                getIAConnectAgentLog["LocalSaveFolder"] = CSharpExpressionConverter.ConvertToken(getIAConnectAgentLoglocalSaveFolder);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLoguseAgentLogFilename != null)
            {
                if (getIAConnectAgentLoguseAgentLogFilename != null)
                {
                    getIAConnectAgentLog["UseAgentLogFilename"] = CSharpExpressionConverter.ConvertToken(getIAConnectAgentLoguseAgentLogFilename);
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
                getIAConnectAgentLog["LocalSaveFilename"] = CSharpExpressionConverter.ConvertToken(getIAConnectAgentLoglocalSaveFilename);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLogmaxBytesToRead != null)
            {
                if (getIAConnectAgentLogmaxBytesToRead != null)
                {
                    getIAConnectAgentLog["MaxBytesToRead"] = CSharpExpressionConverter.ConvertToken(getIAConnectAgentLogmaxBytesToRead);
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
            getIAConnectAgentLog["Workflow"] = CSharpExpressionConverter.ConvertToken(getIAConnectAgentLogworkflow);
            if (getIAConnectAgentLogpropCount > 0)
            {
                callPayload.Body = getIAConnectAgentLog;
            }

            return new ApiConnectionAction<GetIAConnectAgentLogResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ResetCommandStats(Expression<Func<string>> resetCommandStatsworkflow)
        {
            var apiCallPath = "/DriverControl/ResetCommandStats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var resetCommandStats = new JObject();
            var resetCommandStatspropCount = 0;
            resetCommandStatspropCount++;
            resetCommandStats["Workflow"] = CSharpExpressionConverter.ConvertToken(resetCommandStatsworkflow);
            if (resetCommandStatspropCount > 0)
            {
                callPayload.Body = resetCommandStats;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAllCommandStatsResponse> GetAllCommandStats(Expression<Func<string>> getAllCommandStatsworkflow)
        {
            var apiCallPath = "/DriverControl/GetAllCommandStats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getAllCommandStats = new JObject();
            var getAllCommandStatspropCount = 0;
            getAllCommandStatspropCount++;
            getAllCommandStats["Workflow"] = CSharpExpressionConverter.ConvertToken(getAllCommandStatsworkflow);
            if (getAllCommandStatspropCount > 0)
            {
                callPayload.Body = getAllCommandStats;
            }

            return new ApiConnectionAction<GetAllCommandStatsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<EnableNextHopResponse> EnableNextHop(Expression<Func<string>> enableNextHopworkflow, Expression<Func<string>> enableNextHopnextHopDirectorAddress = null, Expression<Func<int>> enableNextHopnextHopDirectorTCPPort = null, Expression<Func<bool>> enableNextHopnextHopDirectorUsesHTTPS = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsLocalhostname = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsHostname = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsFQDN = null, Expression<Func<bool>> enableNextHopincrementNextHopDirectorTCPPortBySessionId = null, Expression<Func<bool>> enableNextHopdisableBeforeEnable = null, Expression<Func<bool>> enableNextHopcheckNextHopDirectorIsRunning = null, Expression<Func<bool>> enableNextHopcheckNextHopAgentIsRunning = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsNamedPipe = null)
        {
            var apiCallPath = "/DriverControl/EnableNextHop";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var enableNextHop = new JObject();
            var enableNextHoppropCount = 0;
            if (enableNextHopnextHopDirectorAddress != null)
            {
                enableNextHop["NextHopDirectorAddress"] = CSharpExpressionConverter.ConvertToken(enableNextHopnextHopDirectorAddress);
                enableNextHoppropCount++;
            }

            if (enableNextHopnextHopDirectorTCPPort != null)
            {
                if (enableNextHopnextHopDirectorTCPPort != null)
                {
                    enableNextHop["NextHopDirectorTCPPort"] = CSharpExpressionConverter.ConvertToken(enableNextHopnextHopDirectorTCPPort);
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
                    enableNextHop["NextHopDirectorUsesHTTPS"] = CSharpExpressionConverter.ConvertToken(enableNextHopnextHopDirectorUsesHTTPS);
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
                    enableNextHop["NextHopDirectorAddressIsLocalhostname"] = CSharpExpressionConverter.ConvertToken(enableNextHopnextHopDirectorAddressIsLocalhostname);
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
                    enableNextHop["NextHopDirectorAddressIsHostname"] = CSharpExpressionConverter.ConvertToken(enableNextHopnextHopDirectorAddressIsHostname);
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
                    enableNextHop["NextHopDirectorAddressIsFQDN"] = CSharpExpressionConverter.ConvertToken(enableNextHopnextHopDirectorAddressIsFQDN);
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
                    enableNextHop["IncrementNextHopDirectorTCPPortBySessionId"] = CSharpExpressionConverter.ConvertToken(enableNextHopincrementNextHopDirectorTCPPortBySessionId);
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
                    enableNextHop["DisableBeforeEnable"] = CSharpExpressionConverter.ConvertToken(enableNextHopdisableBeforeEnable);
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
                    enableNextHop["CheckNextHopDirectorIsRunning"] = CSharpExpressionConverter.ConvertToken(enableNextHopcheckNextHopDirectorIsRunning);
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
                    enableNextHop["CheckNextHopAgentIsRunning"] = CSharpExpressionConverter.ConvertToken(enableNextHopcheckNextHopAgentIsRunning);
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
                    enableNextHop["NextHopDirectorAddressIsNamedPipe"] = CSharpExpressionConverter.ConvertToken(enableNextHopnextHopDirectorAddressIsNamedPipe);
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
            enableNextHop["Workflow"] = CSharpExpressionConverter.ConvertToken(enableNextHopworkflow);
            if (enableNextHoppropCount > 0)
            {
                callPayload.Body = enableNextHop;
            }

            return new ApiConnectionAction<EnableNextHopResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DisableNextHop(Expression<Func<string>> disableNextHopworkflow)
        {
            var apiCallPath = "/DriverControl/DisableNextHop";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var disableNextHop = new JObject();
            var disableNextHoppropCount = 0;
            disableNextHoppropCount++;
            disableNextHop["Workflow"] = CSharpExpressionConverter.ConvertToken(disableNextHopworkflow);
            if (disableNextHoppropCount > 0)
            {
                callPayload.Body = disableNextHop;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetNextHopStatusResponse> GetNextHopStatus(Expression<Func<string>> getNextHopStatusworkflow, Expression<Func<bool>> getNextHopStatuscheckNextHopDirectorIsRunning = null, Expression<Func<bool>> getNextHopStatuscheckNextHopAgentIsRunning = null)
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
                    getNextHopStatus["CheckNextHopDirectorIsRunning"] = CSharpExpressionConverter.ConvertToken(getNextHopStatuscheckNextHopDirectorIsRunning);
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
                    getNextHopStatus["CheckNextHopAgentIsRunning"] = CSharpExpressionConverter.ConvertToken(getNextHopStatuscheckNextHopAgentIsRunning);
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
            getNextHopStatus["Workflow"] = CSharpExpressionConverter.ConvertToken(getNextHopStatusworkflow);
            if (getNextHopStatuspropCount > 0)
            {
                callPayload.Body = getNextHopStatus;
            }

            return new ApiConnectionAction<GetNextHopStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForNextHopSessionToConnectResponse> WaitForNextHopSessionToConnect(Expression<Func<string>> waitForNextHopSessionToConnectworkflow, Expression<Func<string>> waitForNextHopSessionToConnectnextHopDirectorAddress = null, Expression<Func<int>> waitForNextHopSessionToConnectnextHopDirectorTCPPort = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN = null, Expression<Func<bool>> waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId = null, Expression<Func<double>> waitForNextHopSessionToConnectsecondsToWait = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe = null, Expression<Func<bool>> waitForNextHopSessionToConnectdisableExistingNextHop = null)
        {
            var apiCallPath = "/DriverControl/WaitForNextHopSessionToConnect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var waitForNextHopSessionToConnect = new JObject();
            var waitForNextHopSessionToConnectpropCount = 0;
            if (waitForNextHopSessionToConnectnextHopDirectorAddress != null)
            {
                waitForNextHopSessionToConnect["NextHopDirectorAddress"] = CSharpExpressionConverter.ConvertToken(waitForNextHopSessionToConnectnextHopDirectorAddress);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectnextHopDirectorTCPPort != null)
            {
                if (waitForNextHopSessionToConnectnextHopDirectorTCPPort != null)
                {
                    waitForNextHopSessionToConnect["NextHopDirectorTCPPort"] = CSharpExpressionConverter.ConvertToken(waitForNextHopSessionToConnectnextHopDirectorTCPPort);
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
                    waitForNextHopSessionToConnect["NextHopDirectorUsesHTTPS"] = CSharpExpressionConverter.ConvertToken(waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS);
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
                    waitForNextHopSessionToConnect["NextHopDirectorAddressIsLocalhostname"] = CSharpExpressionConverter.ConvertToken(waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname);
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
                    waitForNextHopSessionToConnect["NextHopDirectorAddressIsHostname"] = CSharpExpressionConverter.ConvertToken(waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname);
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
                    waitForNextHopSessionToConnect["NextHopDirectorAddressIsFQDN"] = CSharpExpressionConverter.ConvertToken(waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN);
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
                    waitForNextHopSessionToConnect["IncrementNextHopDirectorTCPPortBySessionId"] = CSharpExpressionConverter.ConvertToken(waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId);
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
                    waitForNextHopSessionToConnect["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(waitForNextHopSessionToConnectsecondsToWait);
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
                    waitForNextHopSessionToConnect["NextHopDirectorAddressIsNamedPipe"] = CSharpExpressionConverter.ConvertToken(waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe);
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
                    waitForNextHopSessionToConnect["DisableExistingNextHop"] = CSharpExpressionConverter.ConvertToken(waitForNextHopSessionToConnectdisableExistingNextHop);
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
            waitForNextHopSessionToConnect["Workflow"] = CSharpExpressionConverter.ConvertToken(waitForNextHopSessionToConnectworkflow);
            if (waitForNextHopSessionToConnectpropCount > 0)
            {
                callPayload.Body = waitForNextHopSessionToConnect;
            }

            return new ApiConnectionAction<WaitForNextHopSessionToConnectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ConfigureNextHopDirector(Expression<Func<string>> configureNextHopDirectorworkflow, Expression<Func<bool>> configureNextHopDirectorsOAPEnabled = null, Expression<Func<bool>> configureNextHopDirectorrESTEnabled = null, Expression<Func<bool>> configureNextHopDirectorwebServerEnabled = null, Expression<Func<bool>> configureNextHopDirectordirectorIsLocalhostOnly = null, Expression<Func<int>> configureNextHopDirectorsOAPTCPPort = null, Expression<Func<int>> configureNextHopDirectorrESTTCPPort = null, Expression<Func<bool>> configureNextHopDirectorsOAPUsesHTTPS = null, Expression<Func<bool>> configureNextHopDirectorrESTUsesHTTPS = null, Expression<Func<bool>> configureNextHopDirectorincrementDirectorTCPPortBySessionId = null, Expression<Func<bool>> configureNextHopDirectorsOAPUsesUserAuthentication = null, Expression<Func<bool>> configureNextHopDirectorrESTUsesUserAuthentication = null, Expression<Func<bool>> configureNextHopDirectorcommandNamedPipeEnabled = null)
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
                    configureNextHopDirector["SOAPEnabled"] = CSharpExpressionConverter.ConvertToken(configureNextHopDirectorsOAPEnabled);
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
                    configureNextHopDirector["RESTEnabled"] = CSharpExpressionConverter.ConvertToken(configureNextHopDirectorrESTEnabled);
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
                    configureNextHopDirector["WebServerEnabled"] = CSharpExpressionConverter.ConvertToken(configureNextHopDirectorwebServerEnabled);
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
                    configureNextHopDirector["DirectorIsLocalhostOnly"] = CSharpExpressionConverter.ConvertToken(configureNextHopDirectordirectorIsLocalhostOnly);
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
                    configureNextHopDirector["SOAPTCPPort"] = CSharpExpressionConverter.ConvertToken(configureNextHopDirectorsOAPTCPPort);
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
                    configureNextHopDirector["RESTTCPPort"] = CSharpExpressionConverter.ConvertToken(configureNextHopDirectorrESTTCPPort);
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
                    configureNextHopDirector["SOAPUsesHTTPS"] = CSharpExpressionConverter.ConvertToken(configureNextHopDirectorsOAPUsesHTTPS);
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
                    configureNextHopDirector["RESTUsesHTTPS"] = CSharpExpressionConverter.ConvertToken(configureNextHopDirectorrESTUsesHTTPS);
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
                    configureNextHopDirector["IncrementDirectorTCPPortBySessionId"] = CSharpExpressionConverter.ConvertToken(configureNextHopDirectorincrementDirectorTCPPortBySessionId);
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
                    configureNextHopDirector["SOAPUsesUserAuthentication"] = CSharpExpressionConverter.ConvertToken(configureNextHopDirectorsOAPUsesUserAuthentication);
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
                    configureNextHopDirector["RESTUsesUserAuthentication"] = CSharpExpressionConverter.ConvertToken(configureNextHopDirectorrESTUsesUserAuthentication);
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
                    configureNextHopDirector["CommandNamedPipeEnabled"] = CSharpExpressionConverter.ConvertToken(configureNextHopDirectorcommandNamedPipeEnabled);
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
            configureNextHopDirector["Workflow"] = CSharpExpressionConverter.ConvertToken(configureNextHopDirectorworkflow);
            if (configureNextHopDirectorpropCount > 0)
            {
                callPayload.Body = configureNextHopDirector;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ResetNextHopDirectorSettings(Expression<Func<string>> resetNextHopDirectorSettingsworkflow)
        {
            var apiCallPath = "/DriverControl/ResetNextHopDirectorSettings";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var resetNextHopDirectorSettings = new JObject();
            var resetNextHopDirectorSettingspropCount = 0;
            resetNextHopDirectorSettingspropCount++;
            resetNextHopDirectorSettings["Workflow"] = CSharpExpressionConverter.ConvertToken(resetNextHopDirectorSettingsworkflow);
            if (resetNextHopDirectorSettingspropCount > 0)
            {
                callPayload.Body = resetNextHopDirectorSettings;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WorkflowCompleted(Expression<Func<string>> workflowCompletedworkflow)
        {
            var apiCallPath = "/DriverControl/WorkflowCompleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var workflowCompleted = new JObject();
            var workflowCompletedpropCount = 0;
            workflowCompletedpropCount++;
            workflowCompleted["Workflow"] = CSharpExpressionConverter.ConvertToken(workflowCompletedworkflow);
            if (workflowCompletedpropCount > 0)
            {
                callPayload.Body = workflowCompleted;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RaiseExceptionResponse> RaiseException(Expression<Func<string>> raiseExceptioninputException = null, Expression<Func<string>> raiseExceptionexceptionMessage = null)
        {
            var apiCallPath = "/DriverControl/RaiseException";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var raiseException = new JObject();
            var raiseExceptionpropCount = 0;
            if (raiseExceptioninputException != null)
            {
                raiseException["InputException"] = CSharpExpressionConverter.ConvertToken(raiseExceptioninputException);
                raiseExceptionpropCount++;
            }

            if (raiseExceptionexceptionMessage != null)
            {
                raiseException["ExceptionMessage"] = CSharpExpressionConverter.ConvertToken(raiseExceptionexceptionMessage);
                raiseExceptionpropCount++;
            }

            if (raiseExceptionpropCount > 0)
            {
                callPayload.Body = raiseException;
            }

            return new ApiConnectionAction<RaiseExceptionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UpdateOrchestratorFlowStatsResultResponse> UpdateOrchestratorFlowStatsResult(Expression<Func<string>> updateOrchestratorFlowStatsResultworkflow, Expression<Func<bool>> updateOrchestratorFlowStatsResultflowLastActionSuccess = null, Expression<Func<string>> updateOrchestratorFlowStatsResultflowLastActionErrorMessage = null, Expression<Func<int>> updateOrchestratorFlowStatsResultflowLastActionCode = null)
        {
            var apiCallPath = "/DriverControl/UpdateOrchestratorFlowStatsResult";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var updateOrchestratorFlowStatsResult = new JObject();
            var updateOrchestratorFlowStatsResultpropCount = 0;
            if (updateOrchestratorFlowStatsResultflowLastActionSuccess != null)
            {
                updateOrchestratorFlowStatsResult["FlowLastActionSuccess"] = CSharpExpressionConverter.ConvertToken(updateOrchestratorFlowStatsResultflowLastActionSuccess);
                updateOrchestratorFlowStatsResultpropCount++;
            }

            if (updateOrchestratorFlowStatsResultflowLastActionErrorMessage != null)
            {
                updateOrchestratorFlowStatsResult["FlowLastActionErrorMessage"] = CSharpExpressionConverter.ConvertToken(updateOrchestratorFlowStatsResultflowLastActionErrorMessage);
                updateOrchestratorFlowStatsResultpropCount++;
            }

            if (updateOrchestratorFlowStatsResultflowLastActionCode != null)
            {
                updateOrchestratorFlowStatsResult["FlowLastActionCode"] = CSharpExpressionConverter.ConvertToken(updateOrchestratorFlowStatsResultflowLastActionCode);
                updateOrchestratorFlowStatsResultpropCount++;
            }

            updateOrchestratorFlowStatsResultpropCount++;
            updateOrchestratorFlowStatsResult["Workflow"] = CSharpExpressionConverter.ConvertToken(updateOrchestratorFlowStatsResultworkflow);
            if (updateOrchestratorFlowStatsResultpropCount > 0)
            {
                callPayload.Body = updateOrchestratorFlowStatsResult;
            }

            return new ApiConnectionAction<UpdateOrchestratorFlowStatsResultResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLastFailedActionFromOrchestratorFlowStatsResponse> GetLastFailedActionFromOrchestratorFlowStats(Expression<Func<string>> getLastFailedActionFromOrchestratorFlowStatsworkflow)
        {
            var apiCallPath = "/DriverControl/GetLastFailedActionFromOrchestratorFlowStats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getLastFailedActionFromOrchestratorFlowStats = new JObject();
            var getLastFailedActionFromOrchestratorFlowStatspropCount = 0;
            getLastFailedActionFromOrchestratorFlowStatspropCount++;
            getLastFailedActionFromOrchestratorFlowStats["Workflow"] = CSharpExpressionConverter.ConvertToken(getLastFailedActionFromOrchestratorFlowStatsworkflow);
            if (getLastFailedActionFromOrchestratorFlowStatspropCount > 0)
            {
                callPayload.Body = getLastFailedActionFromOrchestratorFlowStats;
            }

            return new ApiConnectionAction<GetLastFailedActionFromOrchestratorFlowStatsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorFlowStatsResponse> GetOrchestratorFlowStats(Expression<Func<int>> getOrchestratorFlowStatswithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorFlowStatssearchFlowName = null, Expression<Func<bool>> getOrchestratorFlowStatssearchFlowLastActionResult = null, Expression<Func<string>> getOrchestratorFlowStatssearchFlowStartTimeStartWindow = null, Expression<Func<string>> getOrchestratorFlowStatssearchFlowStartTimeEndWindow = null)
        {
            var apiCallPath = "/DriverControl/GetOrchestratorFlowStats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getOrchestratorFlowStats = new JObject();
            var getOrchestratorFlowStatspropCount = 0;
            if (getOrchestratorFlowStatswithinLastNumberOfDays != null)
            {
                getOrchestratorFlowStats["WithinLastNumberOfDays"] = CSharpExpressionConverter.ConvertToken(getOrchestratorFlowStatswithinLastNumberOfDays);
                getOrchestratorFlowStatspropCount++;
            }

            if (getOrchestratorFlowStatssearchFlowName != null)
            {
                getOrchestratorFlowStats["SearchFlowName"] = CSharpExpressionConverter.ConvertToken(getOrchestratorFlowStatssearchFlowName);
                getOrchestratorFlowStatspropCount++;
            }

            if (getOrchestratorFlowStatssearchFlowLastActionResult != null)
            {
                getOrchestratorFlowStats["SearchFlowLastActionResult"] = CSharpExpressionConverter.ConvertToken(getOrchestratorFlowStatssearchFlowLastActionResult);
                getOrchestratorFlowStatspropCount++;
            }

            if (getOrchestratorFlowStatssearchFlowStartTimeStartWindow != null)
            {
                getOrchestratorFlowStats["SearchFlowStartTimeStartWindow"] = CSharpExpressionConverter.ConvertToken(getOrchestratorFlowStatssearchFlowStartTimeStartWindow);
                getOrchestratorFlowStatspropCount++;
            }

            if (getOrchestratorFlowStatssearchFlowStartTimeEndWindow != null)
            {
                getOrchestratorFlowStats["SearchFlowStartTimeEndWindow"] = CSharpExpressionConverter.ConvertToken(getOrchestratorFlowStatssearchFlowStartTimeEndWindow);
                getOrchestratorFlowStatspropCount++;
            }

            if (getOrchestratorFlowStatspropCount > 0)
            {
                callPayload.Body = getOrchestratorFlowStats;
            }

            return new ApiConnectionAction<GetOrchestratorFlowStatsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerAvailabilityStatsResponse> GetOrchestratorWorkerAvailabilityStats(Expression<Func<int>> getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorWorkerAvailabilityStatssearchFlowName = null, Expression<Func<string>> getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow = null)
        {
            var apiCallPath = "/DriverControl/GetOrchestratorWorkerAvailabilityStats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getOrchestratorWorkerAvailabilityStats = new JObject();
            var getOrchestratorWorkerAvailabilityStatspropCount = 0;
            if (getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays != null)
            {
                getOrchestratorWorkerAvailabilityStats["WithinLastNumberOfDays"] = CSharpExpressionConverter.ConvertToken(getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays);
                getOrchestratorWorkerAvailabilityStatspropCount++;
            }

            if (getOrchestratorWorkerAvailabilityStatssearchFlowName != null)
            {
                getOrchestratorWorkerAvailabilityStats["SearchFlowName"] = CSharpExpressionConverter.ConvertToken(getOrchestratorWorkerAvailabilityStatssearchFlowName);
                getOrchestratorWorkerAvailabilityStatspropCount++;
            }

            if (getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow != null)
            {
                getOrchestratorWorkerAvailabilityStats["SearchFlowStartTimeStartWindow"] = CSharpExpressionConverter.ConvertToken(getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow);
                getOrchestratorWorkerAvailabilityStatspropCount++;
            }

            if (getOrchestratorWorkerAvailabilityStatspropCount > 0)
            {
                callPayload.Body = getOrchestratorWorkerAvailabilityStats;
            }

            return new ApiConnectionAction<GetOrchestratorWorkerAvailabilityStatsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerFlowUsageHeatmapResponse> GetOrchestratorWorkerFlowUsageHeatmap(Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow, Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow, Expression<Func<int>> getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC = null, Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapworkerNames = null)
        {
            var apiCallPath = "/DriverControl/GetOrchestratorWorkerFlowUsageHeatmap";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getOrchestratorWorkerFlowUsageHeatmap = new JObject();
            var getOrchestratorWorkerFlowUsageHeatmappropCount = 0;
            getOrchestratorWorkerFlowUsageHeatmappropCount++;
            getOrchestratorWorkerFlowUsageHeatmap["SearchStartDateStartWindow"] = CSharpExpressionConverter.ConvertToken(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow);
            getOrchestratorWorkerFlowUsageHeatmappropCount++;
            getOrchestratorWorkerFlowUsageHeatmap["SearchStartDateEndWindow"] = CSharpExpressionConverter.ConvertToken(getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow);
            if (getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC != null)
            {
                if (getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC != null)
                {
                    getOrchestratorWorkerFlowUsageHeatmap["TimeZoneMinutesOffsetFromUTC"] = CSharpExpressionConverter.ConvertToken(getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC);
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
                getOrchestratorWorkerFlowUsageHeatmap["WorkerNames"] = CSharpExpressionConverter.ConvertToken(getOrchestratorWorkerFlowUsageHeatmapworkerNames);
                getOrchestratorWorkerFlowUsageHeatmappropCount++;
            }

            if (getOrchestratorWorkerFlowUsageHeatmappropCount > 0)
            {
                callPayload.Body = getOrchestratorWorkerFlowUsageHeatmap;
            }

            return new ApiConnectionAction<GetOrchestratorWorkerFlowUsageHeatmapResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorLoginHistoryResponse> GetOrchestratorLoginHistory(Expression<Func<int>> getOrchestratorLoginHistorywithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorLoginHistorysearchByEmail = null, Expression<Func<string>> getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow = null, Expression<Func<string>> getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow = null)
        {
            var apiCallPath = "/DriverControl/GetOrchestratorLoginHistory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getOrchestratorLoginHistory = new JObject();
            var getOrchestratorLoginHistorypropCount = 0;
            if (getOrchestratorLoginHistorywithinLastNumberOfDays != null)
            {
                getOrchestratorLoginHistory["WithinLastNumberOfDays"] = CSharpExpressionConverter.ConvertToken(getOrchestratorLoginHistorywithinLastNumberOfDays);
                getOrchestratorLoginHistorypropCount++;
            }

            if (getOrchestratorLoginHistorysearchByEmail != null)
            {
                getOrchestratorLoginHistory["SearchByEmail"] = CSharpExpressionConverter.ConvertToken(getOrchestratorLoginHistorysearchByEmail);
                getOrchestratorLoginHistorypropCount++;
            }

            if (getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow != null)
            {
                getOrchestratorLoginHistory["SearchLoginHistoryTimeStartWindow"] = CSharpExpressionConverter.ConvertToken(getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow);
                getOrchestratorLoginHistorypropCount++;
            }

            if (getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow != null)
            {
                getOrchestratorLoginHistory["SearchLoginHistoryTimeEndWindow"] = CSharpExpressionConverter.ConvertToken(getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow);
                getOrchestratorLoginHistorypropCount++;
            }

            if (getOrchestratorLoginHistorypropCount > 0)
            {
                callPayload.Body = getOrchestratorLoginHistory;
            }

            return new ApiConnectionAction<GetOrchestratorLoginHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetLocalLoggingLevel(Expression<Func<int>> setLocalLoggingLevelloggingLevel, Expression<Func<string>> setLocalLoggingLevelworkflow)
        {
            var apiCallPath = "/DriverControl/SetLocalLoggingLevel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setLocalLoggingLevel = new JObject();
            var setLocalLoggingLevelpropCount = 0;
            setLocalLoggingLevelpropCount++;
            setLocalLoggingLevel["LoggingLevel"] = CSharpExpressionConverter.ConvertToken(setLocalLoggingLevelloggingLevel);
            setLocalLoggingLevelpropCount++;
            setLocalLoggingLevel["Workflow"] = CSharpExpressionConverter.ConvertToken(setLocalLoggingLevelworkflow);
            if (setLocalLoggingLevelpropCount > 0)
            {
                callPayload.Body = setLocalLoggingLevel;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunCommandResponse> RunCommand(Expression<Func<string>> runCommandcommandName, Expression<Func<string>> runCommandworkflow, Expression<Func<string>> runCommandinputJSON = null)
        {
            var apiCallPath = "/DriverControl/RunCommand";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runCommand = new JObject();
            var runCommandpropCount = 0;
            runCommandpropCount++;
            runCommand["CommandName"] = CSharpExpressionConverter.ConvertToken(runCommandcommandName);
            if (runCommandinputJSON != null)
            {
                runCommand["InputJSON"] = CSharpExpressionConverter.ConvertToken(runCommandinputJSON);
                runCommandpropCount++;
            }

            runCommandpropCount++;
            runCommand["Workflow"] = CSharpExpressionConverter.ConvertToken(runCommandworkflow);
            if (runCommandpropCount > 0)
            {
                callPayload.Body = runCommand;
            }

            return new ApiConnectionAction<RunCommandResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLocalLoggingLevelResponse> GetLocalLoggingLevel(Expression<Func<string>> getLocalLoggingLevelworkflow)
        {
            var apiCallPath = "/DriverControl/GetLocalLoggingLevel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getLocalLoggingLevel = new JObject();
            var getLocalLoggingLevelpropCount = 0;
            getLocalLoggingLevelpropCount++;
            getLocalLoggingLevel["Workflow"] = CSharpExpressionConverter.ConvertToken(getLocalLoggingLevelworkflow);
            if (getLocalLoggingLevelpropCount > 0)
            {
                callPayload.Body = getLocalLoggingLevel;
            }

            return new ApiConnectionAction<GetLocalLoggingLevelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteClientTypeResponse> GetRemoteClientType(Expression<Func<string>> getRemoteClientTypeworkflow)
        {
            var apiCallPath = "/DriverControl/GetRemoteClientType";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRemoteClientType = new JObject();
            var getRemoteClientTypepropCount = 0;
            getRemoteClientTypepropCount++;
            getRemoteClientType["Workflow"] = CSharpExpressionConverter.ConvertToken(getRemoteClientTypeworkflow);
            if (getRemoteClientTypepropCount > 0)
            {
                callPayload.Body = getRemoteClientType;
            }

            return new ApiConnectionAction<GetRemoteClientTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectDirectorInfoResponse> GetIAConnectDirectorInfo(Expression<Func<string>> getIAConnectDirectorInfoworkflow)
        {
            var apiCallPath = "/DriverControl/GetIAConnectDirectorInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getIAConnectDirectorInfo = new JObject();
            var getIAConnectDirectorInfopropCount = 0;
            getIAConnectDirectorInfopropCount++;
            getIAConnectDirectorInfo["Workflow"] = CSharpExpressionConverter.ConvertToken(getIAConnectDirectorInfoworkflow);
            if (getIAConnectDirectorInfopropCount > 0)
            {
                callPayload.Body = getIAConnectDirectorInfo;
            }

            return new ApiConnectionAction<GetIAConnectDirectorInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAvailableIAConnectSessionsResponse> GetAvailableIAConnectSessions(Expression<Func<string>> getAvailableIAConnectSessionsworkflow)
        {
            var apiCallPath = "/DriverControl/GetAvailableIAConnectSessions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getAvailableIAConnectSessions = new JObject();
            var getAvailableIAConnectSessionspropCount = 0;
            getAvailableIAConnectSessionspropCount++;
            getAvailableIAConnectSessions["Workflow"] = CSharpExpressionConverter.ConvertToken(getAvailableIAConnectSessionsworkflow);
            if (getAvailableIAConnectSessionspropCount > 0)
            {
                callPayload.Body = getAvailableIAConnectSessions;
            }

            return new ApiConnectionAction<GetAvailableIAConnectSessionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AttachToIAConnectSessionByName(Expression<Func<string>> attachToIAConnectSessionByNameiAConnectSessionName, Expression<Func<string>> attachToIAConnectSessionByNameworkflow, Expression<Func<bool>> attachToIAConnectSessionByNamevirtualChannelMustBeConnected = null)
        {
            var apiCallPath = "/DriverControl/AttachToIAConnectSessionByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var attachToIAConnectSessionByName = new JObject();
            var attachToIAConnectSessionByNamepropCount = 0;
            attachToIAConnectSessionByNamepropCount++;
            attachToIAConnectSessionByName["IAConnectSessionName"] = CSharpExpressionConverter.ConvertToken(attachToIAConnectSessionByNameiAConnectSessionName);
            if (attachToIAConnectSessionByNamevirtualChannelMustBeConnected != null)
            {
                if (attachToIAConnectSessionByNamevirtualChannelMustBeConnected != null)
                {
                    attachToIAConnectSessionByName["VirtualChannelMustBeConnected"] = CSharpExpressionConverter.ConvertToken(attachToIAConnectSessionByNamevirtualChannelMustBeConnected);
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
            attachToIAConnectSessionByName["Workflow"] = CSharpExpressionConverter.ConvertToken(attachToIAConnectSessionByNameworkflow);
            if (attachToIAConnectSessionByNamepropCount > 0)
            {
                callPayload.Body = attachToIAConnectSessionByName;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToTier1IAConnectSessionResponse> AttachToTier1IAConnectSession(Expression<Func<string>> attachToTier1IAConnectSessionworkflow, Expression<Func<bool>> attachToTier1IAConnectSessionvirtualChannelMustBeConnected = null)
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
                    attachToTier1IAConnectSession["VirtualChannelMustBeConnected"] = CSharpExpressionConverter.ConvertToken(attachToTier1IAConnectSessionvirtualChannelMustBeConnected);
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
            attachToTier1IAConnectSession["Workflow"] = CSharpExpressionConverter.ConvertToken(attachToTier1IAConnectSessionworkflow);
            if (attachToTier1IAConnectSessionpropCount > 0)
            {
                callPayload.Body = attachToTier1IAConnectSession;
            }

            return new ApiConnectionAction<AttachToTier1IAConnectSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToIAConnectSessionByIndexResponse> AttachToIAConnectSessionByIndex(Expression<Func<string>> attachToIAConnectSessionByIndexworkflow, Expression<Func<attachToIAConnectSessionByIndexsearchIAConnectSessionTypeInput>> attachToIAConnectSessionByIndexsearchIAConnectSessionType = null, Expression<Func<int>> attachToIAConnectSessionByIndexsearchIAConnectSessionIndex = null, Expression<Func<int>> attachToIAConnectSessionByIndextimeToWaitInSeconds = null, Expression<Func<bool>> attachToIAConnectSessionByIndexraiseExceptionIfTimedout = null, Expression<Func<bool>> attachToIAConnectSessionByIndexvirtualChannelMustBeConnected = null, Expression<Func<bool>> attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore = null)
        {
            var apiCallPath = "/DriverControl/AttachToIAConnectSessionByIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var attachToIAConnectSessionByIndex = new JObject();
            var attachToIAConnectSessionByIndexpropCount = 0;
            if (attachToIAConnectSessionByIndexsearchIAConnectSessionType != null)
            {
                attachToIAConnectSessionByIndex["SearchIAConnectSessionType"] = CSharpExpressionConverter.Convert(attachToIAConnectSessionByIndexsearchIAConnectSessionType);
                attachToIAConnectSessionByIndexpropCount++;
            }

            if (attachToIAConnectSessionByIndexsearchIAConnectSessionIndex != null)
            {
                attachToIAConnectSessionByIndex["SearchIAConnectSessionIndex"] = CSharpExpressionConverter.ConvertToken(attachToIAConnectSessionByIndexsearchIAConnectSessionIndex);
                attachToIAConnectSessionByIndexpropCount++;
            }

            if (attachToIAConnectSessionByIndextimeToWaitInSeconds != null)
            {
                attachToIAConnectSessionByIndex["TimeToWaitInSeconds"] = CSharpExpressionConverter.ConvertToken(attachToIAConnectSessionByIndextimeToWaitInSeconds);
                attachToIAConnectSessionByIndexpropCount++;
            }

            if (attachToIAConnectSessionByIndexraiseExceptionIfTimedout != null)
            {
                if (attachToIAConnectSessionByIndexraiseExceptionIfTimedout != null)
                {
                    attachToIAConnectSessionByIndex["RaiseExceptionIfTimedout"] = CSharpExpressionConverter.ConvertToken(attachToIAConnectSessionByIndexraiseExceptionIfTimedout);
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
                    attachToIAConnectSessionByIndex["VirtualChannelMustBeConnected"] = CSharpExpressionConverter.ConvertToken(attachToIAConnectSessionByIndexvirtualChannelMustBeConnected);
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
                    attachToIAConnectSessionByIndex["OnlyCountSessionsNotSeenBefore"] = CSharpExpressionConverter.ConvertToken(attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore);
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
            attachToIAConnectSessionByIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(attachToIAConnectSessionByIndexworkflow);
            if (attachToIAConnectSessionByIndexpropCount > 0)
            {
                callPayload.Body = attachToIAConnectSessionByIndex;
            }

            return new ApiConnectionAction<AttachToIAConnectSessionByIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToMostRecentIAConnectSessionResponse> AttachToMostRecentIAConnectSession(Expression<Func<string>> attachToMostRecentIAConnectSessionworkflow, Expression<Func<attachToMostRecentIAConnectSessionsearchIAConnectSessionTypeInput>> attachToMostRecentIAConnectSessionsearchIAConnectSessionType = null, Expression<Func<int>> attachToMostRecentIAConnectSessiontimeToWaitInSeconds = null, Expression<Func<bool>> attachToMostRecentIAConnectSessionraiseExceptionIfTimedout = null, Expression<Func<bool>> attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected = null, Expression<Func<bool>> attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore = null)
        {
            var apiCallPath = "/DriverControl/AttachToMostRecentIAConnectSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var attachToMostRecentIAConnectSession = new JObject();
            var attachToMostRecentIAConnectSessionpropCount = 0;
            if (attachToMostRecentIAConnectSessionsearchIAConnectSessionType != null)
            {
                attachToMostRecentIAConnectSession["SearchIAConnectSessionType"] = CSharpExpressionConverter.Convert(attachToMostRecentIAConnectSessionsearchIAConnectSessionType);
                attachToMostRecentIAConnectSessionpropCount++;
            }

            if (attachToMostRecentIAConnectSessiontimeToWaitInSeconds != null)
            {
                attachToMostRecentIAConnectSession["TimeToWaitInSeconds"] = CSharpExpressionConverter.ConvertToken(attachToMostRecentIAConnectSessiontimeToWaitInSeconds);
                attachToMostRecentIAConnectSessionpropCount++;
            }

            if (attachToMostRecentIAConnectSessionraiseExceptionIfTimedout != null)
            {
                if (attachToMostRecentIAConnectSessionraiseExceptionIfTimedout != null)
                {
                    attachToMostRecentIAConnectSession["RaiseExceptionIfTimedout"] = CSharpExpressionConverter.ConvertToken(attachToMostRecentIAConnectSessionraiseExceptionIfTimedout);
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
                    attachToMostRecentIAConnectSession["VirtualChannelMustBeConnected"] = CSharpExpressionConverter.ConvertToken(attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected);
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
                    attachToMostRecentIAConnectSession["OnlyCountSessionsNotSeenBefore"] = CSharpExpressionConverter.ConvertToken(attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore);
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
            attachToMostRecentIAConnectSession["Workflow"] = CSharpExpressionConverter.ConvertToken(attachToMostRecentIAConnectSessionworkflow);
            if (attachToMostRecentIAConnectSessionpropCount > 0)
            {
                callPayload.Body = attachToMostRecentIAConnectSession;
            }

            return new ApiConnectionAction<AttachToMostRecentIAConnectSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDirectorUpTimeResponse> GetDirectorUpTime(Expression<Func<string>> getDirectorUpTimeworkflow)
        {
            var apiCallPath = "/DriverControl/GetDirectorUpTime";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getDirectorUpTime = new JObject();
            var getDirectorUpTimepropCount = 0;
            getDirectorUpTimepropCount++;
            getDirectorUpTime["Workflow"] = CSharpExpressionConverter.ConvertToken(getDirectorUpTimeworkflow);
            if (getDirectorUpTimepropCount > 0)
            {
                callPayload.Body = getDirectorUpTime;
            }

            return new ApiConnectionAction<GetDirectorUpTimeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DoesIAConnectSessionExistByNameResponse> DoesIAConnectSessionExistByName(Expression<Func<string>> doesIAConnectSessionExistByNameiAConnectSessionName, Expression<Func<string>> doesIAConnectSessionExistByNameworkflow)
        {
            var apiCallPath = "/DriverControl/DoesIAConnectSessionExistByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var doesIAConnectSessionExistByName = new JObject();
            var doesIAConnectSessionExistByNamepropCount = 0;
            doesIAConnectSessionExistByNamepropCount++;
            doesIAConnectSessionExistByName["IAConnectSessionName"] = CSharpExpressionConverter.ConvertToken(doesIAConnectSessionExistByNameiAConnectSessionName);
            doesIAConnectSessionExistByNamepropCount++;
            doesIAConnectSessionExistByName["Workflow"] = CSharpExpressionConverter.ConvertToken(doesIAConnectSessionExistByNameworkflow);
            if (doesIAConnectSessionExistByNamepropCount > 0)
            {
                callPayload.Body = doesIAConnectSessionExistByName;
            }

            return new ApiConnectionAction<DoesIAConnectSessionExistByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForIAConnectSessionToCloseByNameResponse> WaitForIAConnectSessionToCloseByName(Expression<Func<string>> waitForIAConnectSessionToCloseByNameiAConnectSessionName, Expression<Func<string>> waitForIAConnectSessionToCloseByNameworkflow, Expression<Func<int>> waitForIAConnectSessionToCloseByNametimeToWaitInSeconds = null, Expression<Func<bool>> waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout = null, Expression<Func<bool>> waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess = null)
        {
            var apiCallPath = "/DriverControl/WaitForIAConnectSessionToCloseByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var waitForIAConnectSessionToCloseByName = new JObject();
            var waitForIAConnectSessionToCloseByNamepropCount = 0;
            waitForIAConnectSessionToCloseByNamepropCount++;
            waitForIAConnectSessionToCloseByName["IAConnectSessionName"] = CSharpExpressionConverter.ConvertToken(waitForIAConnectSessionToCloseByNameiAConnectSessionName);
            if (waitForIAConnectSessionToCloseByNametimeToWaitInSeconds != null)
            {
                waitForIAConnectSessionToCloseByName["TimeToWaitInSeconds"] = CSharpExpressionConverter.ConvertToken(waitForIAConnectSessionToCloseByNametimeToWaitInSeconds);
                waitForIAConnectSessionToCloseByNamepropCount++;
            }

            if (waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout != null)
            {
                if (waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout != null)
                {
                    waitForIAConnectSessionToCloseByName["RaiseExceptionIfTimedout"] = CSharpExpressionConverter.ConvertToken(waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout);
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
                    waitForIAConnectSessionToCloseByName["AttachToTier1IAConnectSessionOnSuccess"] = CSharpExpressionConverter.ConvertToken(waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess);
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
            waitForIAConnectSessionToCloseByName["Workflow"] = CSharpExpressionConverter.ConvertToken(waitForIAConnectSessionToCloseByNameworkflow);
            if (waitForIAConnectSessionToCloseByNamepropCount > 0)
            {
                callPayload.Body = waitForIAConnectSessionToCloseByName;
            }

            return new ApiConnectionAction<WaitForIAConnectSessionToCloseByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillIAConnectSessionByNameResponse> KillIAConnectSessionByName(Expression<Func<string>> killIAConnectSessionByNameiAConnectSessionName, Expression<Func<string>> killIAConnectSessionByNameworkflow, Expression<Func<bool>> killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess = null)
        {
            var apiCallPath = "/DriverControl/KillIAConnectSessionByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var killIAConnectSessionByName = new JObject();
            var killIAConnectSessionByNamepropCount = 0;
            killIAConnectSessionByNamepropCount++;
            killIAConnectSessionByName["IAConnectSessionName"] = CSharpExpressionConverter.ConvertToken(killIAConnectSessionByNameiAConnectSessionName);
            if (killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess != null)
            {
                if (killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess != null)
                {
                    killIAConnectSessionByName["AttachToTier1IAConnectSessionOnSuccess"] = CSharpExpressionConverter.ConvertToken(killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess);
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
            killIAConnectSessionByName["Workflow"] = CSharpExpressionConverter.ConvertToken(killIAConnectSessionByNameworkflow);
            if (killIAConnectSessionByNamepropCount > 0)
            {
                callPayload.Body = killIAConnectSessionByName;
            }

            return new ApiConnectionAction<KillIAConnectSessionByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetAgentGlobalCoordinateConfigurationResponse> SetAgentGlobalCoordinateConfiguration(Expression<Func<string>> setAgentGlobalCoordinateConfigurationworkflow, Expression<Func<setAgentGlobalCoordinateConfigurationmultiMonitorFunctionalityInput>> setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality = null, Expression<Func<setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplierInput>> setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier = null, Expression<Func<setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplierInput>> setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod = null, Expression<Func<setAgentGlobalCoordinateConfigurationjavaCoordinateSystemInput>> setAgentGlobalCoordinateConfigurationjavaCoordinateSystem = null, Expression<Func<setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystemInput>> setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem = null)
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
                    setAgentGlobalCoordinateConfiguration["MultiMonitorFunctionality"] = CSharpExpressionConverter.Convert(setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality);
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
                    setAgentGlobalCoordinateConfiguration["AutoSetMouseInspectionMultiplier"] = CSharpExpressionConverter.Convert(setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier);
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
                    setAgentGlobalCoordinateConfiguration["AutoSetGlobalMouseMultiplier"] = CSharpExpressionConverter.Convert(setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier);
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
                    setAgentGlobalCoordinateConfiguration["MouseInspectionXMultiplier"] = CSharpExpressionConverter.ConvertToken(setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier);
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
                    setAgentGlobalCoordinateConfiguration["MouseInspectionYMultiplier"] = CSharpExpressionConverter.ConvertToken(setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier);
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
                    setAgentGlobalCoordinateConfiguration["GlobalMouseXMultiplier"] = CSharpExpressionConverter.ConvertToken(setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier);
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
                    setAgentGlobalCoordinateConfiguration["GlobalMouseYMultiplier"] = CSharpExpressionConverter.ConvertToken(setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier);
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
                    setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToMouseEvent"] = CSharpExpressionConverter.ConvertToken(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent);
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
                    setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToSetCursorPos"] = CSharpExpressionConverter.ConvertToken(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos);
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
                    setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToCurrentMouseMoveMethod"] = CSharpExpressionConverter.ConvertToken(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod);
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
                    setAgentGlobalCoordinateConfiguration["JavaCoordinateSystem"] = CSharpExpressionConverter.Convert(setAgentGlobalCoordinateConfigurationjavaCoordinateSystem);
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
                    setAgentGlobalCoordinateConfiguration["SAPGUICoordinateSystem"] = CSharpExpressionConverter.Convert(setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem);
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
            setAgentGlobalCoordinateConfiguration["Workflow"] = CSharpExpressionConverter.ConvertToken(setAgentGlobalCoordinateConfigurationworkflow);
            if (setAgentGlobalCoordinateConfigurationpropCount > 0)
            {
                callPayload.Body = setAgentGlobalCoordinateConfiguration;
            }

            return new ApiConnectionAction<SetAgentGlobalCoordinateConfigurationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentGlobalCoordinateConfigurationResponse> GetAgentGlobalCoordinateConfiguration(Expression<Func<string>> getAgentGlobalCoordinateConfigurationworkflow)
        {
            var apiCallPath = "/DriverControl/GetAgentGlobalCoordinateConfiguration";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getAgentGlobalCoordinateConfiguration = new JObject();
            var getAgentGlobalCoordinateConfigurationpropCount = 0;
            getAgentGlobalCoordinateConfigurationpropCount++;
            getAgentGlobalCoordinateConfiguration["Workflow"] = CSharpExpressionConverter.ConvertToken(getAgentGlobalCoordinateConfigurationworkflow);
            if (getAgentGlobalCoordinateConfigurationpropCount > 0)
            {
                callPayload.Body = getAgentGlobalCoordinateConfiguration;
            }

            return new ApiConnectionAction<GetAgentGlobalCoordinateConfigurationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentThreadStatusResponse> GetAgentThreadStatus(Expression<Func<int>> getAgentThreadStatusthreadId, Expression<Func<string>> getAgentThreadStatusworkflow, Expression<Func<bool>> getAgentThreadStatusretrieveThreadOutputData = null, Expression<Func<bool>> getAgentThreadStatusclearOutputDataFromMemoryOnceRead = null)
        {
            var apiCallPath = "/DriverControl/GetAgentThreadStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getAgentThreadStatus = new JObject();
            var getAgentThreadStatuspropCount = 0;
            getAgentThreadStatuspropCount++;
            getAgentThreadStatus["ThreadId"] = CSharpExpressionConverter.ConvertToken(getAgentThreadStatusthreadId);
            if (getAgentThreadStatusretrieveThreadOutputData != null)
            {
                if (getAgentThreadStatusretrieveThreadOutputData != null)
                {
                    getAgentThreadStatus["RetrieveThreadOutputData"] = CSharpExpressionConverter.ConvertToken(getAgentThreadStatusretrieveThreadOutputData);
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
                    getAgentThreadStatus["ClearOutputDataFromMemoryOnceRead"] = CSharpExpressionConverter.ConvertToken(getAgentThreadStatusclearOutputDataFromMemoryOnceRead);
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
            getAgentThreadStatus["Workflow"] = CSharpExpressionConverter.ConvertToken(getAgentThreadStatusworkflow);
            if (getAgentThreadStatuspropCount > 0)
            {
                callPayload.Body = getAgentThreadStatus;
            }

            return new ApiConnectionAction<GetAgentThreadStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForAgentThreadToCompleteSuccessfullyResponse> WaitForAgentThreadToCompleteSuccessfully(Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullythreadId, Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread, Expression<Func<string>> waitForAgentThreadToCompleteSuccessfullyworkflow, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError = null, Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall = null)
        {
            var apiCallPath = "/DriverControl/WaitForAgentThreadToCompleteSuccessfully";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var waitForAgentThreadToCompleteSuccessfully = new JObject();
            var waitForAgentThreadToCompleteSuccessfullypropCount = 0;
            waitForAgentThreadToCompleteSuccessfullypropCount++;
            waitForAgentThreadToCompleteSuccessfully["ThreadId"] = CSharpExpressionConverter.ConvertToken(waitForAgentThreadToCompleteSuccessfullythreadId);
            waitForAgentThreadToCompleteSuccessfullypropCount++;
            waitForAgentThreadToCompleteSuccessfully["SecondsToWaitForThread"] = CSharpExpressionConverter.ConvertToken(waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread);
            if (waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData != null)
            {
                if (waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData != null)
                {
                    waitForAgentThreadToCompleteSuccessfully["RetrieveThreadOutputData"] = CSharpExpressionConverter.ConvertToken(waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData);
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
                    waitForAgentThreadToCompleteSuccessfully["ClearOutputDataFromMemoryOnceRead"] = CSharpExpressionConverter.ConvertToken(waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead);
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
                    waitForAgentThreadToCompleteSuccessfully["RaiseExceptionIfThreadNotCompleted"] = CSharpExpressionConverter.ConvertToken(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted);
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
                    waitForAgentThreadToCompleteSuccessfully["RaiseExceptionIfThreadError"] = CSharpExpressionConverter.ConvertToken(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError);
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
                    waitForAgentThreadToCompleteSuccessfully["SecondsToWaitPerCall"] = CSharpExpressionConverter.ConvertToken(waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall);
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
            waitForAgentThreadToCompleteSuccessfully["Workflow"] = CSharpExpressionConverter.ConvertToken(waitForAgentThreadToCompleteSuccessfullyworkflow);
            if (waitForAgentThreadToCompleteSuccessfullypropCount > 0)
            {
                callPayload.Body = waitForAgentThreadToCompleteSuccessfully;
            }

            return new ApiConnectionAction<WaitForAgentThreadToCompleteSuccessfullyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentThreadsResponse> GetAgentThreads(Expression<Func<string>> getAgentThreadsworkflow, Expression<Func<getAgentThreadssortOrderInput>> getAgentThreadssortOrder = null)
        {
            var apiCallPath = "/DriverControl/GetAgentThreads";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getAgentThreads = new JObject();
            var getAgentThreadspropCount = 0;
            if (getAgentThreadssortOrder != null)
            {
                getAgentThreads["SortOrder"] = CSharpExpressionConverter.Convert(getAgentThreadssortOrder);
                getAgentThreadspropCount++;
            }

            getAgentThreadspropCount++;
            getAgentThreads["Workflow"] = CSharpExpressionConverter.ConvertToken(getAgentThreadsworkflow);
            if (getAgentThreadspropCount > 0)
            {
                callPayload.Body = getAgentThreads;
            }

            return new ApiConnectionAction<GetAgentThreadsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillAgentThreadResponse> KillAgentThread(Expression<Func<int>> killAgentThreadthreadId, Expression<Func<string>> killAgentThreadworkflow)
        {
            var apiCallPath = "/DriverControl/KillAgentThread";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var killAgentThread = new JObject();
            var killAgentThreadpropCount = 0;
            killAgentThreadpropCount++;
            killAgentThread["ThreadId"] = CSharpExpressionConverter.ConvertToken(killAgentThreadthreadId);
            killAgentThreadpropCount++;
            killAgentThread["Workflow"] = CSharpExpressionConverter.ConvertToken(killAgentThreadworkflow);
            if (killAgentThreadpropCount > 0)
            {
                callPayload.Body = killAgentThread;
            }

            return new ApiConnectionAction<KillAgentThreadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeleteAgentThreadResponse> DeleteAgentThread(Expression<Func<string>> deleteAgentThreadworkflow, Expression<Func<int>> deleteAgentThreadthreadId = null, Expression<Func<bool>> deleteAgentThreaddeleteAllAgentThreads = null, Expression<Func<bool>> deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete = null)
        {
            var apiCallPath = "/DriverControl/DeleteAgentThread";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteAgentThread = new JObject();
            var deleteAgentThreadpropCount = 0;
            if (deleteAgentThreadthreadId != null)
            {
                deleteAgentThread["ThreadId"] = CSharpExpressionConverter.ConvertToken(deleteAgentThreadthreadId);
                deleteAgentThreadpropCount++;
            }

            if (deleteAgentThreaddeleteAllAgentThreads != null)
            {
                if (deleteAgentThreaddeleteAllAgentThreads != null)
                {
                    deleteAgentThread["DeleteAllAgentThreads"] = CSharpExpressionConverter.ConvertToken(deleteAgentThreaddeleteAllAgentThreads);
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
                    deleteAgentThread["RaiseExceptionIfAgentThreadFailsToDelete"] = CSharpExpressionConverter.ConvertToken(deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete);
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
            deleteAgentThread["Workflow"] = CSharpExpressionConverter.ConvertToken(deleteAgentThreadworkflow);
            if (deleteAgentThreadpropCount > 0)
            {
                callPayload.Body = deleteAgentThread;
            }

            return new ApiConnectionAction<DeleteAgentThreadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AllocateWorkerFromOrchestratorResponse> AllocateWorkerFromOrchestrator(Expression<Func<string>> allocateWorkerFromOrchestratorworkflow, Expression<Func<string>> allocateWorkerFromOrchestratorworkerTag = null, Expression<Func<string>> allocateWorkerFromOrchestratorworkerName = null, Expression<Func<bool>> allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable = null)
        {
            var apiCallPath = "/DriverControl/AllocateWorkerFromOrchestrator";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var allocateWorkerFromOrchestrator = new JObject();
            var allocateWorkerFromOrchestratorpropCount = 0;
            if (allocateWorkerFromOrchestratorworkerTag != null)
            {
                allocateWorkerFromOrchestrator["WorkerTag"] = CSharpExpressionConverter.ConvertToken(allocateWorkerFromOrchestratorworkerTag);
                allocateWorkerFromOrchestratorpropCount++;
            }

            if (allocateWorkerFromOrchestratorworkerName != null)
            {
                allocateWorkerFromOrchestrator["WorkerName"] = CSharpExpressionConverter.ConvertToken(allocateWorkerFromOrchestratorworkerName);
                allocateWorkerFromOrchestratorpropCount++;
            }

            if (allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable != null)
            {
                if (allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable != null)
                {
                    allocateWorkerFromOrchestrator["RaiseExceptionIfWorkerNotImmediatelyAvailable"] = CSharpExpressionConverter.ConvertToken(allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable);
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
            allocateWorkerFromOrchestrator["Workflow"] = CSharpExpressionConverter.ConvertToken(allocateWorkerFromOrchestratorworkflow);
            if (allocateWorkerFromOrchestratorpropCount > 0)
            {
                callPayload.Body = allocateWorkerFromOrchestrator;
            }

            return new ApiConnectionAction<AllocateWorkerFromOrchestratorResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetOrchestratorWorkerMaintenanceModeResponse> SetOrchestratorWorkerMaintenanceMode(Expression<Func<int>> setOrchestratorWorkerMaintenanceModeworkerId = null, Expression<Func<string>> setOrchestratorWorkerMaintenanceModeworkerName = null, Expression<Func<bool>> setOrchestratorWorkerMaintenanceModemaintenanceMode = null)
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
                    setOrchestratorWorkerMaintenanceMode["WorkerId"] = CSharpExpressionConverter.ConvertToken(setOrchestratorWorkerMaintenanceModeworkerId);
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
                setOrchestratorWorkerMaintenanceMode["WorkerName"] = CSharpExpressionConverter.ConvertToken(setOrchestratorWorkerMaintenanceModeworkerName);
                setOrchestratorWorkerMaintenanceModepropCount++;
            }

            if (setOrchestratorWorkerMaintenanceModemaintenanceMode != null)
            {
                if (setOrchestratorWorkerMaintenanceModemaintenanceMode != null)
                {
                    setOrchestratorWorkerMaintenanceMode["MaintenanceMode"] = CSharpExpressionConverter.ConvertToken(setOrchestratorWorkerMaintenanceModemaintenanceMode);
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
        public IBodyWorkflowAction<CreateOrchestratorOneTimeSecretResponse> CreateOrchestratorOneTimeSecret(Expression<Func<string>> createOrchestratorOneTimeSecretfriendlyName, Expression<Func<string>> createOrchestratorOneTimeSecretsecretValue = null, Expression<Func<string>> createOrchestratorOneTimeSecretretrievalPhrase1 = null, Expression<Func<string>> createOrchestratorOneTimeSecretretrievalPhrase2 = null, Expression<Func<int>> createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion = null, Expression<Func<bool>> createOrchestratorOneTimeSecretsecretHasAStartDate = null, Expression<Func<string>> createOrchestratorOneTimeSecretsecretStartDateTime = null, Expression<Func<int>> createOrchestratorOneTimeSecrethoursUntilSecretStartTime = null, Expression<Func<bool>> createOrchestratorOneTimeSecretsecretHasAnExpiryDate = null, Expression<Func<string>> createOrchestratorOneTimeSecretsecretExpiryDateTime = null, Expression<Func<int>> createOrchestratorOneTimeSecrethoursUntilSecretExpiry = null)
        {
            var apiCallPath = "/DriverControl/CreateOrchestratorOneTimeSecret";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var createOrchestratorOneTimeSecret = new JObject();
            var createOrchestratorOneTimeSecretpropCount = 0;
            createOrchestratorOneTimeSecretpropCount++;
            createOrchestratorOneTimeSecret["FriendlyName"] = CSharpExpressionConverter.ConvertToken(createOrchestratorOneTimeSecretfriendlyName);
            if (createOrchestratorOneTimeSecretsecretValue != null)
            {
                createOrchestratorOneTimeSecret["SecretValue"] = CSharpExpressionConverter.ConvertToken(createOrchestratorOneTimeSecretsecretValue);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretretrievalPhrase1 != null)
            {
                createOrchestratorOneTimeSecret["RetrievalPhrase1"] = CSharpExpressionConverter.ConvertToken(createOrchestratorOneTimeSecretretrievalPhrase1);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretretrievalPhrase2 != null)
            {
                createOrchestratorOneTimeSecret["RetrievalPhrase2"] = CSharpExpressionConverter.ConvertToken(createOrchestratorOneTimeSecretretrievalPhrase2);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion != null)
            {
                if (createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion != null)
                {
                    createOrchestratorOneTimeSecret["MaximumRetrievalsBeforeDeletion"] = CSharpExpressionConverter.ConvertToken(createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion);
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
                    createOrchestratorOneTimeSecret["SecretHasAStartDate"] = CSharpExpressionConverter.ConvertToken(createOrchestratorOneTimeSecretsecretHasAStartDate);
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
                createOrchestratorOneTimeSecret["SecretStartDateTime"] = CSharpExpressionConverter.ConvertToken(createOrchestratorOneTimeSecretsecretStartDateTime);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecrethoursUntilSecretStartTime != null)
            {
                createOrchestratorOneTimeSecret["HoursUntilSecretStartTime"] = CSharpExpressionConverter.ConvertToken(createOrchestratorOneTimeSecrethoursUntilSecretStartTime);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretsecretHasAnExpiryDate != null)
            {
                if (createOrchestratorOneTimeSecretsecretHasAnExpiryDate != null)
                {
                    createOrchestratorOneTimeSecret["SecretHasAnExpiryDate"] = CSharpExpressionConverter.ConvertToken(createOrchestratorOneTimeSecretsecretHasAnExpiryDate);
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
                createOrchestratorOneTimeSecret["SecretExpiryDateTime"] = CSharpExpressionConverter.ConvertToken(createOrchestratorOneTimeSecretsecretExpiryDateTime);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecrethoursUntilSecretExpiry != null)
            {
                createOrchestratorOneTimeSecret["HoursUntilSecretExpiry"] = CSharpExpressionConverter.ConvertToken(createOrchestratorOneTimeSecrethoursUntilSecretExpiry);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretpropCount > 0)
            {
                callPayload.Body = createOrchestratorOneTimeSecret;
            }

            return new ApiConnectionAction<CreateOrchestratorOneTimeSecretResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfOrchestratorWorkersResponse> GetListOfOrchestratorWorkers(Expression<Func<bool>> getListOfOrchestratorWorkersonlyReturnLiveWorkers = null)
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
                    getListOfOrchestratorWorkers["OnlyReturnLiveWorkers"] = CSharpExpressionConverter.ConvertToken(getListOfOrchestratorWorkersonlyReturnLiveWorkers);
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
        public IBodyWorkflowAction<GetOrchestratorWorkerResponse> GetOrchestratorWorker(Expression<Func<int>> getOrchestratorWorkersearchWorkerId = null, Expression<Func<string>> getOrchestratorWorkersearchWorkerName = null)
        {
            var apiCallPath = "/DriverControl/GetOrchestratorWorker";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getOrchestratorWorker = new JObject();
            var getOrchestratorWorkerpropCount = 0;
            if (getOrchestratorWorkersearchWorkerId != null)
            {
                getOrchestratorWorker["SearchWorkerId"] = CSharpExpressionConverter.ConvertToken(getOrchestratorWorkersearchWorkerId);
                getOrchestratorWorkerpropCount++;
            }

            if (getOrchestratorWorkersearchWorkerName != null)
            {
                getOrchestratorWorker["SearchWorkerName"] = CSharpExpressionConverter.ConvertToken(getOrchestratorWorkersearchWorkerName);
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
        public IBodyWorkflowAction<FileExistsResponse> FileExists(Expression<Func<string>> fileExistsfilename, Expression<Func<string>> fileExistsworkflow)
        {
            var apiCallPath = "/FileManagement/FileExists";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var fileExists = new JObject();
            var fileExistspropCount = 0;
            fileExistspropCount++;
            fileExists["Filename"] = CSharpExpressionConverter.ConvertToken(fileExistsfilename);
            fileExistspropCount++;
            fileExists["Workflow"] = CSharpExpressionConverter.ConvertToken(fileExistsworkflow);
            if (fileExistspropCount > 0)
            {
                callPayload.Body = fileExists;
            }

            return new ApiConnectionAction<FileExistsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DirectoryExistsResponse> DirectoryExists(Expression<Func<string>> directoryExistsdirectoryPath, Expression<Func<string>> directoryExistsworkflow)
        {
            var apiCallPath = "/FileManagement/DirectoryExists";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var directoryExists = new JObject();
            var directoryExistspropCount = 0;
            directoryExistspropCount++;
            directoryExists["DirectoryPath"] = CSharpExpressionConverter.ConvertToken(directoryExistsdirectoryPath);
            directoryExistspropCount++;
            directoryExists["Workflow"] = CSharpExpressionConverter.ConvertToken(directoryExistsworkflow);
            if (directoryExistspropCount > 0)
            {
                callPayload.Body = directoryExists;
            }

            return new ApiConnectionAction<DirectoryExistsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DeleteFile(Expression<Func<string>> deleteFilefilename, Expression<Func<string>> deleteFileworkflow)
        {
            var apiCallPath = "/FileManagement/DeleteFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteFile = new JObject();
            var deleteFilepropCount = 0;
            deleteFilepropCount++;
            deleteFile["Filename"] = CSharpExpressionConverter.ConvertToken(deleteFilefilename);
            deleteFilepropCount++;
            deleteFile["Workflow"] = CSharpExpressionConverter.ConvertToken(deleteFileworkflow);
            if (deleteFilepropCount > 0)
            {
                callPayload.Body = deleteFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DeleteDirectory(Expression<Func<string>> deleteDirectorydirectoryPath, Expression<Func<string>> deleteDirectoryworkflow, Expression<Func<bool>> deleteDirectoryrecursive = null)
        {
            var apiCallPath = "/FileManagement/DeleteDirectory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteDirectory = new JObject();
            var deleteDirectorypropCount = 0;
            deleteDirectorypropCount++;
            deleteDirectory["DirectoryPath"] = CSharpExpressionConverter.ConvertToken(deleteDirectorydirectoryPath);
            if (deleteDirectoryrecursive != null)
            {
                if (deleteDirectoryrecursive != null)
                {
                    deleteDirectory["Recursive"] = CSharpExpressionConverter.ConvertToken(deleteDirectoryrecursive);
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
            deleteDirectory["Workflow"] = CSharpExpressionConverter.ConvertToken(deleteDirectoryworkflow);
            if (deleteDirectorypropCount > 0)
            {
                callPayload.Body = deleteDirectory;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction PurgeDirectory(Expression<Func<string>> purgeDirectorydirectoryPath, Expression<Func<string>> purgeDirectoryworkflow, Expression<Func<bool>> purgeDirectoryrecursive = null, Expression<Func<bool>> purgeDirectorydeleteTopLevel = null)
        {
            var apiCallPath = "/FileManagement/PurgeDirectory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var purgeDirectory = new JObject();
            var purgeDirectorypropCount = 0;
            purgeDirectorypropCount++;
            purgeDirectory["DirectoryPath"] = CSharpExpressionConverter.ConvertToken(purgeDirectorydirectoryPath);
            if (purgeDirectoryrecursive != null)
            {
                if (purgeDirectoryrecursive != null)
                {
                    purgeDirectory["Recursive"] = CSharpExpressionConverter.ConvertToken(purgeDirectoryrecursive);
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
                    purgeDirectory["DeleteTopLevel"] = CSharpExpressionConverter.ConvertToken(purgeDirectorydeleteTopLevel);
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
            purgeDirectory["Workflow"] = CSharpExpressionConverter.ConvertToken(purgeDirectoryworkflow);
            if (purgeDirectorypropCount > 0)
            {
                callPayload.Body = purgeDirectory;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CopyFile(Expression<Func<string>> copyFilesourceFilePath, Expression<Func<string>> copyFiledestFilePath, Expression<Func<string>> copyFileworkflow)
        {
            var apiCallPath = "/FileManagement/CopyFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var copyFile = new JObject();
            var copyFilepropCount = 0;
            copyFilepropCount++;
            copyFile["SourceFilePath"] = CSharpExpressionConverter.ConvertToken(copyFilesourceFilePath);
            copyFilepropCount++;
            copyFile["DestFilePath"] = CSharpExpressionConverter.ConvertToken(copyFiledestFilePath);
            copyFilepropCount++;
            copyFile["Workflow"] = CSharpExpressionConverter.ConvertToken(copyFileworkflow);
            if (copyFilepropCount > 0)
            {
                callPayload.Body = copyFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveFile(Expression<Func<string>> moveFilesourceFilePath, Expression<Func<string>> moveFiledestFilePath, Expression<Func<string>> moveFileworkflow)
        {
            var apiCallPath = "/FileManagement/MoveFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var moveFile = new JObject();
            var moveFilepropCount = 0;
            moveFilepropCount++;
            moveFile["SourceFilePath"] = CSharpExpressionConverter.ConvertToken(moveFilesourceFilePath);
            moveFilepropCount++;
            moveFile["DestFilePath"] = CSharpExpressionConverter.ConvertToken(moveFiledestFilePath);
            moveFilepropCount++;
            moveFile["Workflow"] = CSharpExpressionConverter.ConvertToken(moveFileworkflow);
            if (moveFilepropCount > 0)
            {
                callPayload.Body = moveFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CreateDirectory(Expression<Func<string>> createDirectorydirectoryPath, Expression<Func<string>> createDirectoryworkflow, Expression<Func<bool>> createDirectoryerrorIfAlreadyExists = null)
        {
            var apiCallPath = "/FileManagement/CreateDirectory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var createDirectory = new JObject();
            var createDirectorypropCount = 0;
            createDirectorypropCount++;
            createDirectory["DirectoryPath"] = CSharpExpressionConverter.ConvertToken(createDirectorydirectoryPath);
            if (createDirectoryerrorIfAlreadyExists != null)
            {
                if (createDirectoryerrorIfAlreadyExists != null)
                {
                    createDirectory["ErrorIfAlreadyExists"] = CSharpExpressionConverter.ConvertToken(createDirectoryerrorIfAlreadyExists);
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
            createDirectory["Workflow"] = CSharpExpressionConverter.ConvertToken(createDirectoryworkflow);
            if (createDirectorypropCount > 0)
            {
                callPayload.Body = createDirectory;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileSizeResponse> GetFileSize(Expression<Func<string>> getFileSizefilename, Expression<Func<string>> getFileSizeworkflow)
        {
            var apiCallPath = "/FileManagement/GetFileSize";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getFileSize = new JObject();
            var getFileSizepropCount = 0;
            getFileSizepropCount++;
            getFileSize["Filename"] = CSharpExpressionConverter.ConvertToken(getFileSizefilename);
            getFileSizepropCount++;
            getFileSize["Workflow"] = CSharpExpressionConverter.ConvertToken(getFileSizeworkflow);
            if (getFileSizepropCount > 0)
            {
                callPayload.Body = getFileSize;
            }

            return new ApiConnectionAction<GetFileSizeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WriteTextFile(Expression<Func<string>> writeTextFilefilename, Expression<Func<string>> writeTextFileworkflow, Expression<Func<string>> writeTextFiletextToWrite = null, Expression<Func<bool>> writeTextFileappendExistingFile = null, Expression<Func<writeTextFileencodingInput>> writeTextFileencoding = null, Expression<Func<bool>> writeTextFilecreateFolderIfRequired = null)
        {
            var apiCallPath = "/FileManagement/WriteTextFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var writeTextFile = new JObject();
            var writeTextFilepropCount = 0;
            writeTextFilepropCount++;
            writeTextFile["Filename"] = CSharpExpressionConverter.ConvertToken(writeTextFilefilename);
            if (writeTextFiletextToWrite != null)
            {
                writeTextFile["TextToWrite"] = CSharpExpressionConverter.ConvertToken(writeTextFiletextToWrite);
                writeTextFilepropCount++;
            }

            if (writeTextFileappendExistingFile != null)
            {
                if (writeTextFileappendExistingFile != null)
                {
                    writeTextFile["AppendExistingFile"] = CSharpExpressionConverter.ConvertToken(writeTextFileappendExistingFile);
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
                writeTextFile["Encoding"] = CSharpExpressionConverter.Convert(writeTextFileencoding);
                writeTextFilepropCount++;
            }

            if (writeTextFilecreateFolderIfRequired != null)
            {
                if (writeTextFilecreateFolderIfRequired != null)
                {
                    writeTextFile["CreateFolderIfRequired"] = CSharpExpressionConverter.ConvertToken(writeTextFilecreateFolderIfRequired);
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
            writeTextFile["Workflow"] = CSharpExpressionConverter.ConvertToken(writeTextFileworkflow);
            if (writeTextFilepropCount > 0)
            {
                callPayload.Body = writeTextFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ReadAllTextFromFileResponse> ReadAllTextFromFile(Expression<Func<string>> readAllTextFromFilefilename, Expression<Func<string>> readAllTextFromFileworkflow)
        {
            var apiCallPath = "/FileManagement/ReadAllTextFromFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var readAllTextFromFile = new JObject();
            var readAllTextFromFilepropCount = 0;
            readAllTextFromFilepropCount++;
            readAllTextFromFile["Filename"] = CSharpExpressionConverter.ConvertToken(readAllTextFromFilefilename);
            readAllTextFromFilepropCount++;
            readAllTextFromFile["Workflow"] = CSharpExpressionConverter.ConvertToken(readAllTextFromFileworkflow);
            if (readAllTextFromFilepropCount > 0)
            {
                callPayload.Body = readAllTextFromFile;
            }

            return new ApiConnectionAction<ReadAllTextFromFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFilesResponse> GetFiles(Expression<Func<string>> getFilesdirectoryPath, Expression<Func<string>> getFilespatternsCSV, Expression<Func<string>> getFilesworkflow)
        {
            var apiCallPath = "/FileManagement/GetFiles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getFiles = new JObject();
            var getFilespropCount = 0;
            getFilespropCount++;
            getFiles["DirectoryPath"] = CSharpExpressionConverter.ConvertToken(getFilesdirectoryPath);
            getFilespropCount++;
            getFiles["PatternsCSV"] = CSharpExpressionConverter.ConvertToken(getFilespatternsCSV);
            getFilespropCount++;
            getFiles["Workflow"] = CSharpExpressionConverter.ConvertToken(getFilesworkflow);
            if (getFilespropCount > 0)
            {
                callPayload.Body = getFiles;
            }

            return new ApiConnectionAction<GetFilesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFoldersResponse> GetFolders(Expression<Func<string>> getFoldersdirectoryPath, Expression<Func<string>> getFoldersworkflow)
        {
            var apiCallPath = "/FileManagement/GetFolders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getFolders = new JObject();
            var getFolderspropCount = 0;
            getFolderspropCount++;
            getFolders["DirectoryPath"] = CSharpExpressionConverter.ConvertToken(getFoldersdirectoryPath);
            getFolderspropCount++;
            getFolders["Workflow"] = CSharpExpressionConverter.ConvertToken(getFoldersworkflow);
            if (getFolderspropCount > 0)
            {
                callPayload.Body = getFolders;
            }

            return new ApiConnectionAction<GetFoldersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeleteFilesResponse> DeleteFiles(Expression<Func<string>> deleteFilesdirectoryPath, Expression<Func<string>> deleteFilesworkflow, Expression<Func<string>> deleteFilespattern = null)
        {
            var apiCallPath = "/FileManagement/DeleteFiles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteFiles = new JObject();
            var deleteFilespropCount = 0;
            deleteFilespropCount++;
            deleteFiles["DirectoryPath"] = CSharpExpressionConverter.ConvertToken(deleteFilesdirectoryPath);
            if (deleteFilespattern != null)
            {
                deleteFiles["Pattern"] = CSharpExpressionConverter.ConvertToken(deleteFilespattern);
                deleteFilespropCount++;
            }

            deleteFilespropCount++;
            deleteFiles["Workflow"] = CSharpExpressionConverter.ConvertToken(deleteFilesworkflow);
            if (deleteFilespropCount > 0)
            {
                callPayload.Body = deleteFiles;
            }

            return new ApiConnectionAction<DeleteFilesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDiskFreeSpaceResponse> GetDiskFreeSpace(Expression<Func<string>> getDiskFreeSpacedriveLetter, Expression<Func<string>> getDiskFreeSpaceworkflow)
        {
            var apiCallPath = "/FileManagement/GetDiskFreeSpace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getDiskFreeSpace = new JObject();
            var getDiskFreeSpacepropCount = 0;
            getDiskFreeSpacepropCount++;
            getDiskFreeSpace["DriveLetter"] = CSharpExpressionConverter.ConvertToken(getDiskFreeSpacedriveLetter);
            getDiskFreeSpacepropCount++;
            getDiskFreeSpace["Workflow"] = CSharpExpressionConverter.ConvertToken(getDiskFreeSpaceworkflow);
            if (getDiskFreeSpacepropCount > 0)
            {
                callPayload.Body = getDiskFreeSpace;
            }

            return new ApiConnectionAction<GetDiskFreeSpaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfDrivesResponse> GetListOfDrives(Expression<Func<string>> getListOfDrivesworkflow)
        {
            var apiCallPath = "/FileManagement/GetListOfDrives";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getListOfDrives = new JObject();
            var getListOfDrivespropCount = 0;
            getListOfDrivespropCount++;
            getListOfDrives["Workflow"] = CSharpExpressionConverter.ConvertToken(getListOfDrivesworkflow);
            if (getListOfDrivespropCount > 0)
            {
                callPayload.Body = getListOfDrives;
            }

            return new ApiConnectionAction<GetListOfDrivesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DirectoryIsAccessibleResponse> DirectoryIsAccessible(Expression<Func<string>> directoryIsAccessibledirectoryPath, Expression<Func<string>> directoryIsAccessibleworkflow)
        {
            var apiCallPath = "/FileManagement/DirectoryIsAccessible";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var directoryIsAccessible = new JObject();
            var directoryIsAccessiblepropCount = 0;
            directoryIsAccessiblepropCount++;
            directoryIsAccessible["DirectoryPath"] = CSharpExpressionConverter.ConvertToken(directoryIsAccessibledirectoryPath);
            directoryIsAccessiblepropCount++;
            directoryIsAccessible["Workflow"] = CSharpExpressionConverter.ConvertToken(directoryIsAccessibleworkflow);
            if (directoryIsAccessiblepropCount > 0)
            {
                callPayload.Body = directoryIsAccessible;
            }

            return new ApiConnectionAction<DirectoryIsAccessibleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetCSVTextAsCollectionResponse> GetCSVTextAsCollection(Expression<Func<string>> getCSVTextAsCollectioncSVFilePath, Expression<Func<string>> getCSVTextAsCollectionworkflow, Expression<Func<bool>> getCSVTextAsCollectionfirstLineIsHeader = null, Expression<Func<bool>> getCSVTextAsCollectiontrimHeaders = null, Expression<Func<bool>> getCSVTextAsCollectionallowBlankRows = null, Expression<Func<bool>> getCSVTextAsCollectionextendColumnsIfRequired = null)
        {
            var apiCallPath = "/FileManagement/GetCSVTextAsCollection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getCSVTextAsCollection = new JObject();
            var getCSVTextAsCollectionpropCount = 0;
            getCSVTextAsCollectionpropCount++;
            getCSVTextAsCollection["CSVFilePath"] = CSharpExpressionConverter.ConvertToken(getCSVTextAsCollectioncSVFilePath);
            if (getCSVTextAsCollectionfirstLineIsHeader != null)
            {
                if (getCSVTextAsCollectionfirstLineIsHeader != null)
                {
                    getCSVTextAsCollection["FirstLineIsHeader"] = CSharpExpressionConverter.ConvertToken(getCSVTextAsCollectionfirstLineIsHeader);
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
                    getCSVTextAsCollection["TrimHeaders"] = CSharpExpressionConverter.ConvertToken(getCSVTextAsCollectiontrimHeaders);
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
                    getCSVTextAsCollection["AllowBlankRows"] = CSharpExpressionConverter.ConvertToken(getCSVTextAsCollectionallowBlankRows);
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
                    getCSVTextAsCollection["ExtendColumnsIfRequired"] = CSharpExpressionConverter.ConvertToken(getCSVTextAsCollectionextendColumnsIfRequired);
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
            getCSVTextAsCollection["Workflow"] = CSharpExpressionConverter.ConvertToken(getCSVTextAsCollectionworkflow);
            if (getCSVTextAsCollectionpropCount > 0)
            {
                callPayload.Body = getCSVTextAsCollection;
            }

            return new ApiConnectionAction<GetCSVTextAsCollectionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WriteCollectionToCSVFileResponse> WriteCollectionToCSVFile(Expression<Func<string>> writeCollectionToCSVFilecSVFilePath, Expression<Func<string>> writeCollectionToCSVFileworkflow, Expression<Func<JToken[]>> writeCollectionToCSVFileinputTable = null, Expression<Func<string>> writeCollectionToCSVFileinputTableJSON = null, Expression<Func<writeCollectionToCSVFileoutputEncodingInput>> writeCollectionToCSVFileoutputEncoding = null)
        {
            var apiCallPath = "/FileManagement/WriteCollectionToCSVFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var writeCollectionToCSVFile = new JObject();
            var writeCollectionToCSVFilepropCount = 0;
            if (writeCollectionToCSVFileinputTable != null)
            {
                writeCollectionToCSVFile["InputTable"] = CSharpExpressionConverter.ConvertToken(writeCollectionToCSVFileinputTable);
                writeCollectionToCSVFilepropCount++;
            }

            if (writeCollectionToCSVFileinputTableJSON != null)
            {
                writeCollectionToCSVFile["InputTableJSON"] = CSharpExpressionConverter.ConvertToken(writeCollectionToCSVFileinputTableJSON);
                writeCollectionToCSVFilepropCount++;
            }

            writeCollectionToCSVFilepropCount++;
            writeCollectionToCSVFile["CSVFilePath"] = CSharpExpressionConverter.ConvertToken(writeCollectionToCSVFilecSVFilePath);
            if (writeCollectionToCSVFileoutputEncoding != null)
            {
                if (writeCollectionToCSVFileoutputEncoding != null)
                {
                    writeCollectionToCSVFile["OutputEncoding"] = CSharpExpressionConverter.Convert(writeCollectionToCSVFileoutputEncoding);
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
            writeCollectionToCSVFile["Workflow"] = CSharpExpressionConverter.ConvertToken(writeCollectionToCSVFileworkflow);
            if (writeCollectionToCSVFilepropCount > 0)
            {
                callPayload.Body = writeCollectionToCSVFile;
            }

            return new ApiConnectionAction<WriteCollectionToCSVFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetOwnerOnFolder(Expression<Func<string>> setOwnerOnFolderfolderPath, Expression<Func<string>> setOwnerOnFolderuserIdentity, Expression<Func<string>> setOwnerOnFolderworkflow)
        {
            var apiCallPath = "/FileManagement/SetOwnerOnFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setOwnerOnFolder = new JObject();
            var setOwnerOnFolderpropCount = 0;
            setOwnerOnFolderpropCount++;
            setOwnerOnFolder["FolderPath"] = CSharpExpressionConverter.ConvertToken(setOwnerOnFolderfolderPath);
            setOwnerOnFolderpropCount++;
            setOwnerOnFolder["UserIdentity"] = CSharpExpressionConverter.ConvertToken(setOwnerOnFolderuserIdentity);
            setOwnerOnFolderpropCount++;
            setOwnerOnFolder["Workflow"] = CSharpExpressionConverter.ConvertToken(setOwnerOnFolderworkflow);
            if (setOwnerOnFolderpropCount > 0)
            {
                callPayload.Body = setOwnerOnFolder;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetOwnerOnFile(Expression<Func<string>> setOwnerOnFilefilePath, Expression<Func<string>> setOwnerOnFileuserIdentity, Expression<Func<string>> setOwnerOnFileworkflow)
        {
            var apiCallPath = "/FileManagement/SetOwnerOnFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setOwnerOnFile = new JObject();
            var setOwnerOnFilepropCount = 0;
            setOwnerOnFilepropCount++;
            setOwnerOnFile["FilePath"] = CSharpExpressionConverter.ConvertToken(setOwnerOnFilefilePath);
            setOwnerOnFilepropCount++;
            setOwnerOnFile["UserIdentity"] = CSharpExpressionConverter.ConvertToken(setOwnerOnFileuserIdentity);
            setOwnerOnFilepropCount++;
            setOwnerOnFile["Workflow"] = CSharpExpressionConverter.ConvertToken(setOwnerOnFileworkflow);
            if (setOwnerOnFilepropCount > 0)
            {
                callPayload.Body = setOwnerOnFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddPermissionToFolder(Expression<Func<string>> addPermissionToFolderfolderPath, Expression<Func<string>> addPermissionToFolderidentity, Expression<Func<addPermissionToFolderpermissionInput>> addPermissionToFolderpermission, Expression<Func<string>> addPermissionToFolderworkflow, Expression<Func<bool>> addPermissionToFolderapplyToFolder = null, Expression<Func<bool>> addPermissionToFolderapplyToSubFolders = null, Expression<Func<bool>> addPermissionToFolderapplyToFiles = null, Expression<Func<bool>> addPermissionToFolderdeny = null)
        {
            var apiCallPath = "/FileManagement/AddPermissionToFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addPermissionToFolder = new JObject();
            var addPermissionToFolderpropCount = 0;
            addPermissionToFolderpropCount++;
            addPermissionToFolder["FolderPath"] = CSharpExpressionConverter.ConvertToken(addPermissionToFolderfolderPath);
            addPermissionToFolderpropCount++;
            addPermissionToFolder["Identity"] = CSharpExpressionConverter.ConvertToken(addPermissionToFolderidentity);
            addPermissionToFolderpropCount++;
            addPermissionToFolder["Permission"] = CSharpExpressionConverter.Convert(addPermissionToFolderpermission);
            if (addPermissionToFolderapplyToFolder != null)
            {
                if (addPermissionToFolderapplyToFolder != null)
                {
                    addPermissionToFolder["ApplyToFolder"] = CSharpExpressionConverter.ConvertToken(addPermissionToFolderapplyToFolder);
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
                    addPermissionToFolder["ApplyToSubFolders"] = CSharpExpressionConverter.ConvertToken(addPermissionToFolderapplyToSubFolders);
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
                    addPermissionToFolder["ApplyToFiles"] = CSharpExpressionConverter.ConvertToken(addPermissionToFolderapplyToFiles);
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
                    addPermissionToFolder["Deny"] = CSharpExpressionConverter.ConvertToken(addPermissionToFolderdeny);
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
            addPermissionToFolder["Workflow"] = CSharpExpressionConverter.ConvertToken(addPermissionToFolderworkflow);
            if (addPermissionToFolderpropCount > 0)
            {
                callPayload.Body = addPermissionToFolder;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddPermissionToFile(Expression<Func<string>> addPermissionToFilefilePath, Expression<Func<string>> addPermissionToFileidentity, Expression<Func<addPermissionToFilepermissionInput>> addPermissionToFilepermission, Expression<Func<string>> addPermissionToFileworkflow, Expression<Func<bool>> addPermissionToFiledeny = null)
        {
            var apiCallPath = "/FileManagement/AddPermissionToFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addPermissionToFile = new JObject();
            var addPermissionToFilepropCount = 0;
            addPermissionToFilepropCount++;
            addPermissionToFile["FilePath"] = CSharpExpressionConverter.ConvertToken(addPermissionToFilefilePath);
            addPermissionToFilepropCount++;
            addPermissionToFile["Identity"] = CSharpExpressionConverter.ConvertToken(addPermissionToFileidentity);
            addPermissionToFilepropCount++;
            addPermissionToFile["Permission"] = CSharpExpressionConverter.Convert(addPermissionToFilepermission);
            if (addPermissionToFiledeny != null)
            {
                if (addPermissionToFiledeny != null)
                {
                    addPermissionToFile["Deny"] = CSharpExpressionConverter.ConvertToken(addPermissionToFiledeny);
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
            addPermissionToFile["Workflow"] = CSharpExpressionConverter.ConvertToken(addPermissionToFileworkflow);
            if (addPermissionToFilepropCount > 0)
            {
                callPayload.Body = addPermissionToFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction BreakFolderSecurityInheritance(Expression<Func<string>> breakFolderSecurityInheritancefolderPath, Expression<Func<string>> breakFolderSecurityInheritanceworkflow, Expression<Func<bool>> breakFolderSecurityInheritanceconvertInheritedToExplicit = null)
        {
            var apiCallPath = "/FileManagement/BreakFolderSecurityInheritance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var breakFolderSecurityInheritance = new JObject();
            var breakFolderSecurityInheritancepropCount = 0;
            breakFolderSecurityInheritancepropCount++;
            breakFolderSecurityInheritance["FolderPath"] = CSharpExpressionConverter.ConvertToken(breakFolderSecurityInheritancefolderPath);
            if (breakFolderSecurityInheritanceconvertInheritedToExplicit != null)
            {
                if (breakFolderSecurityInheritanceconvertInheritedToExplicit != null)
                {
                    breakFolderSecurityInheritance["ConvertInheritedToExplicit"] = CSharpExpressionConverter.ConvertToken(breakFolderSecurityInheritanceconvertInheritedToExplicit);
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
            breakFolderSecurityInheritance["Workflow"] = CSharpExpressionConverter.ConvertToken(breakFolderSecurityInheritanceworkflow);
            if (breakFolderSecurityInheritancepropCount > 0)
            {
                callPayload.Body = breakFolderSecurityInheritance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction EnableFolderSecurityInheritance(Expression<Func<string>> enableFolderSecurityInheritancefolderPath, Expression<Func<string>> enableFolderSecurityInheritanceworkflow)
        {
            var apiCallPath = "/FileManagement/EnableFolderSecurityInheritance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var enableFolderSecurityInheritance = new JObject();
            var enableFolderSecurityInheritancepropCount = 0;
            enableFolderSecurityInheritancepropCount++;
            enableFolderSecurityInheritance["FolderPath"] = CSharpExpressionConverter.ConvertToken(enableFolderSecurityInheritancefolderPath);
            enableFolderSecurityInheritancepropCount++;
            enableFolderSecurityInheritance["Workflow"] = CSharpExpressionConverter.ConvertToken(enableFolderSecurityInheritanceworkflow);
            if (enableFolderSecurityInheritancepropCount > 0)
            {
                callPayload.Body = enableFolderSecurityInheritance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFolderSecurityPermissionsResponse> GetFolderSecurityPermissions(Expression<Func<string>> getFolderSecurityPermissionsfolderPath, Expression<Func<string>> getFolderSecurityPermissionsworkflow)
        {
            var apiCallPath = "/FileManagement/GetFolderSecurityPermissions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getFolderSecurityPermissions = new JObject();
            var getFolderSecurityPermissionspropCount = 0;
            getFolderSecurityPermissionspropCount++;
            getFolderSecurityPermissions["FolderPath"] = CSharpExpressionConverter.ConvertToken(getFolderSecurityPermissionsfolderPath);
            getFolderSecurityPermissionspropCount++;
            getFolderSecurityPermissions["Workflow"] = CSharpExpressionConverter.ConvertToken(getFolderSecurityPermissionsworkflow);
            if (getFolderSecurityPermissionspropCount > 0)
            {
                callPayload.Body = getFolderSecurityPermissions;
            }

            return new ApiConnectionAction<GetFolderSecurityPermissionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileSecurityPermissionsResponse> GetFileSecurityPermissions(Expression<Func<string>> getFileSecurityPermissionsfilePath, Expression<Func<string>> getFileSecurityPermissionsworkflow)
        {
            var apiCallPath = "/FileManagement/GetFileSecurityPermissions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getFileSecurityPermissions = new JObject();
            var getFileSecurityPermissionspropCount = 0;
            getFileSecurityPermissionspropCount++;
            getFileSecurityPermissions["FilePath"] = CSharpExpressionConverter.ConvertToken(getFileSecurityPermissionsfilePath);
            getFileSecurityPermissionspropCount++;
            getFileSecurityPermissions["Workflow"] = CSharpExpressionConverter.ConvertToken(getFileSecurityPermissionsworkflow);
            if (getFileSecurityPermissionspropCount > 0)
            {
                callPayload.Body = getFileSecurityPermissions;
            }

            return new ApiConnectionAction<GetFileSecurityPermissionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RemoveIdentityFromFolderSecurityResponse> RemoveIdentityFromFolderSecurity(Expression<Func<string>> removeIdentityFromFolderSecurityfolderPath, Expression<Func<string>> removeIdentityFromFolderSecurityidentityToRemove, Expression<Func<string>> removeIdentityFromFolderSecurityworkflow)
        {
            var apiCallPath = "/FileManagement/RemoveIdentityFromFolderSecurity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var removeIdentityFromFolderSecurity = new JObject();
            var removeIdentityFromFolderSecuritypropCount = 0;
            removeIdentityFromFolderSecuritypropCount++;
            removeIdentityFromFolderSecurity["FolderPath"] = CSharpExpressionConverter.ConvertToken(removeIdentityFromFolderSecurityfolderPath);
            removeIdentityFromFolderSecuritypropCount++;
            removeIdentityFromFolderSecurity["IdentityToRemove"] = CSharpExpressionConverter.ConvertToken(removeIdentityFromFolderSecurityidentityToRemove);
            removeIdentityFromFolderSecuritypropCount++;
            removeIdentityFromFolderSecurity["Workflow"] = CSharpExpressionConverter.ConvertToken(removeIdentityFromFolderSecurityworkflow);
            if (removeIdentityFromFolderSecuritypropCount > 0)
            {
                callPayload.Body = removeIdentityFromFolderSecurity;
            }

            return new ApiConnectionAction<RemoveIdentityFromFolderSecurityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RemoveIdentityFromFileSecurityResponse> RemoveIdentityFromFileSecurity(Expression<Func<string>> removeIdentityFromFileSecurityfilePath, Expression<Func<string>> removeIdentityFromFileSecurityidentityToRemove, Expression<Func<string>> removeIdentityFromFileSecurityworkflow)
        {
            var apiCallPath = "/FileManagement/RemoveIdentityFromFileSecurity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var removeIdentityFromFileSecurity = new JObject();
            var removeIdentityFromFileSecuritypropCount = 0;
            removeIdentityFromFileSecuritypropCount++;
            removeIdentityFromFileSecurity["FilePath"] = CSharpExpressionConverter.ConvertToken(removeIdentityFromFileSecurityfilePath);
            removeIdentityFromFileSecuritypropCount++;
            removeIdentityFromFileSecurity["IdentityToRemove"] = CSharpExpressionConverter.ConvertToken(removeIdentityFromFileSecurityidentityToRemove);
            removeIdentityFromFileSecuritypropCount++;
            removeIdentityFromFileSecurity["Workflow"] = CSharpExpressionConverter.ConvertToken(removeIdentityFromFileSecurityworkflow);
            if (removeIdentityFromFileSecuritypropCount > 0)
            {
                callPayload.Body = removeIdentityFromFileSecurity;
            }

            return new ApiConnectionAction<RemoveIdentityFromFileSecurityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CopyFileFromClientToServer(Expression<Func<string>> copyFileFromClientToServerclientFilePath, Expression<Func<string>> copyFileFromClientToServerserverFilePath, Expression<Func<string>> copyFileFromClientToServerworkflow, Expression<Func<bool>> copyFileFromClientToServercompress = null)
        {
            var apiCallPath = "/FileManagement/CopyFileFromClientToServer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var copyFileFromClientToServer = new JObject();
            var copyFileFromClientToServerpropCount = 0;
            copyFileFromClientToServerpropCount++;
            copyFileFromClientToServer["ClientFilePath"] = CSharpExpressionConverter.ConvertToken(copyFileFromClientToServerclientFilePath);
            copyFileFromClientToServerpropCount++;
            copyFileFromClientToServer["ServerFilePath"] = CSharpExpressionConverter.ConvertToken(copyFileFromClientToServerserverFilePath);
            if (copyFileFromClientToServercompress != null)
            {
                if (copyFileFromClientToServercompress != null)
                {
                    copyFileFromClientToServer["Compress"] = CSharpExpressionConverter.ConvertToken(copyFileFromClientToServercompress);
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
            copyFileFromClientToServer["Workflow"] = CSharpExpressionConverter.ConvertToken(copyFileFromClientToServerworkflow);
            if (copyFileFromClientToServerpropCount > 0)
            {
                callPayload.Body = copyFileFromClientToServer;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ReplaceVariableDataInINIFile(Expression<Func<string>> replaceVariableDataInINIFileinputFilename, Expression<Func<string>> replaceVariableDataInINIFileworkflow, Expression<Func<string>> replaceVariableDataInINIFileoutputFilename = null, Expression<Func<string>> replaceVariableDataInINIFilesearchSection = null, Expression<Func<string>> replaceVariableDataInINIFilesearchVariable = null, Expression<Func<string>> replaceVariableDataInINIFilereplaceData = null, Expression<Func<string>> replaceVariableDataInINIFileinputFilenameEncoding = null, Expression<Func<bool>> replaceVariableDataInINIFilecreateNewFileIfNotExists = null, Expression<Func<bool>> replaceVariableDataInINIFilewriteSpaceBeforeEquals = null, Expression<Func<bool>> replaceVariableDataInINIFilewriteSpaceAfterEquals = null)
        {
            var apiCallPath = "/FileManagement/ReplaceVariableDataInINIFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var replaceVariableDataInINIFile = new JObject();
            var replaceVariableDataInINIFilepropCount = 0;
            replaceVariableDataInINIFilepropCount++;
            replaceVariableDataInINIFile["InputFilename"] = CSharpExpressionConverter.ConvertToken(replaceVariableDataInINIFileinputFilename);
            if (replaceVariableDataInINIFileoutputFilename != null)
            {
                replaceVariableDataInINIFile["OutputFilename"] = CSharpExpressionConverter.ConvertToken(replaceVariableDataInINIFileoutputFilename);
                replaceVariableDataInINIFilepropCount++;
            }

            if (replaceVariableDataInINIFilesearchSection != null)
            {
                replaceVariableDataInINIFile["SearchSection"] = CSharpExpressionConverter.ConvertToken(replaceVariableDataInINIFilesearchSection);
                replaceVariableDataInINIFilepropCount++;
            }

            if (replaceVariableDataInINIFilesearchVariable != null)
            {
                replaceVariableDataInINIFile["SearchVariable"] = CSharpExpressionConverter.ConvertToken(replaceVariableDataInINIFilesearchVariable);
                replaceVariableDataInINIFilepropCount++;
            }

            if (replaceVariableDataInINIFilereplaceData != null)
            {
                replaceVariableDataInINIFile["ReplaceData"] = CSharpExpressionConverter.ConvertToken(replaceVariableDataInINIFilereplaceData);
                replaceVariableDataInINIFilepropCount++;
            }

            if (replaceVariableDataInINIFileinputFilenameEncoding != null)
            {
                replaceVariableDataInINIFile["InputFilenameEncoding"] = CSharpExpressionConverter.ConvertToken(replaceVariableDataInINIFileinputFilenameEncoding);
                replaceVariableDataInINIFilepropCount++;
            }

            if (replaceVariableDataInINIFilecreateNewFileIfNotExists != null)
            {
                if (replaceVariableDataInINIFilecreateNewFileIfNotExists != null)
                {
                    replaceVariableDataInINIFile["CreateNewFileIfNotExists"] = CSharpExpressionConverter.ConvertToken(replaceVariableDataInINIFilecreateNewFileIfNotExists);
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
                    replaceVariableDataInINIFile["WriteSpaceBeforeEquals"] = CSharpExpressionConverter.ConvertToken(replaceVariableDataInINIFilewriteSpaceBeforeEquals);
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
                    replaceVariableDataInINIFile["WriteSpaceAfterEquals"] = CSharpExpressionConverter.ConvertToken(replaceVariableDataInINIFilewriteSpaceAfterEquals);
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
            replaceVariableDataInINIFile["Workflow"] = CSharpExpressionConverter.ConvertToken(replaceVariableDataInINIFileworkflow);
            if (replaceVariableDataInINIFilepropCount > 0)
            {
                callPayload.Body = replaceVariableDataInINIFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DownloadHTTPFileResponse> DownloadHTTPFile(Expression<Func<string>> downloadHTTPFiledownloadURL, Expression<Func<string>> downloadHTTPFileworkflow, Expression<Func<string>> downloadHTTPFilesaveFilename = null, Expression<Func<bool>> downloadHTTPFileoverwriteExistingFile = null, Expression<Func<bool>> downloadHTTPFilepassthroughAuthentication = null, Expression<Func<string>> downloadHTTPFileuserAgent = null, Expression<Func<string>> downloadHTTPFileaccept = null, Expression<Func<bool>> downloadHTTPFilesupportTLS10 = null, Expression<Func<bool>> downloadHTTPFilesupportTLS11 = null, Expression<Func<bool>> downloadHTTPFilesupportTLS12 = null, Expression<Func<bool>> downloadHTTPFileautoDecompressDeflate = null, Expression<Func<bool>> downloadHTTPFileautoDecompressGZIP = null, Expression<Func<bool>> downloadHTTPFilereturnContentsAsString = null, Expression<Func<downloadHTTPFilereturnContentEncodingInput>> downloadHTTPFilereturnContentEncoding = null)
        {
            var apiCallPath = "/FileManagement/DownloadHTTPFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var downloadHTTPFile = new JObject();
            var downloadHTTPFilepropCount = 0;
            downloadHTTPFilepropCount++;
            downloadHTTPFile["DownloadURL"] = CSharpExpressionConverter.ConvertToken(downloadHTTPFiledownloadURL);
            if (downloadHTTPFilesaveFilename != null)
            {
                downloadHTTPFile["SaveFilename"] = CSharpExpressionConverter.ConvertToken(downloadHTTPFilesaveFilename);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileoverwriteExistingFile != null)
            {
                if (downloadHTTPFileoverwriteExistingFile != null)
                {
                    downloadHTTPFile["OverwriteExistingFile"] = CSharpExpressionConverter.ConvertToken(downloadHTTPFileoverwriteExistingFile);
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
                    downloadHTTPFile["PassthroughAuthentication"] = CSharpExpressionConverter.ConvertToken(downloadHTTPFilepassthroughAuthentication);
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
                    downloadHTTPFile["UserAgent"] = CSharpExpressionConverter.ConvertToken(downloadHTTPFileuserAgent);
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
                    downloadHTTPFile["Accept"] = CSharpExpressionConverter.ConvertToken(downloadHTTPFileaccept);
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
                    downloadHTTPFile["SupportTLS10"] = CSharpExpressionConverter.ConvertToken(downloadHTTPFilesupportTLS10);
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
                    downloadHTTPFile["SupportTLS11"] = CSharpExpressionConverter.ConvertToken(downloadHTTPFilesupportTLS11);
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
                    downloadHTTPFile["SupportTLS12"] = CSharpExpressionConverter.ConvertToken(downloadHTTPFilesupportTLS12);
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
                    downloadHTTPFile["AutoDecompressDeflate"] = CSharpExpressionConverter.ConvertToken(downloadHTTPFileautoDecompressDeflate);
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
                    downloadHTTPFile["AutoDecompressGZIP"] = CSharpExpressionConverter.ConvertToken(downloadHTTPFileautoDecompressGZIP);
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
                    downloadHTTPFile["ReturnContentsAsString"] = CSharpExpressionConverter.ConvertToken(downloadHTTPFilereturnContentsAsString);
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
                    downloadHTTPFile["ReturnContentEncoding"] = CSharpExpressionConverter.Convert(downloadHTTPFilereturnContentEncoding);
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
            downloadHTTPFile["Workflow"] = CSharpExpressionConverter.ConvertToken(downloadHTTPFileworkflow);
            if (downloadHTTPFilepropCount > 0)
            {
                callPayload.Body = downloadHTTPFile;
            }

            return new ApiConnectionAction<DownloadHTTPFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UnZIPFileResponse> UnZIPFile(Expression<Func<string>> unZIPFilezIPFilename, Expression<Func<string>> unZIPFileworkflow, Expression<Func<string>> unZIPFileextractFolder = null, Expression<Func<bool>> unZIPFileextractAllFilesToSingleFolder = null, Expression<Func<string>> unZIPFileincludeFilesRegEx = null, Expression<Func<string>> unZIPFileexcludeFilesRegEx = null)
        {
            var apiCallPath = "/FileManagement/UnZIPFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var unZIPFile = new JObject();
            var unZIPFilepropCount = 0;
            unZIPFilepropCount++;
            unZIPFile["ZIPFilename"] = CSharpExpressionConverter.ConvertToken(unZIPFilezIPFilename);
            if (unZIPFileextractFolder != null)
            {
                unZIPFile["ExtractFolder"] = CSharpExpressionConverter.ConvertToken(unZIPFileextractFolder);
                unZIPFilepropCount++;
            }

            if (unZIPFileextractAllFilesToSingleFolder != null)
            {
                if (unZIPFileextractAllFilesToSingleFolder != null)
                {
                    unZIPFile["ExtractAllFilesToSingleFolder"] = CSharpExpressionConverter.ConvertToken(unZIPFileextractAllFilesToSingleFolder);
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
                unZIPFile["IncludeFilesRegEx"] = CSharpExpressionConverter.ConvertToken(unZIPFileincludeFilesRegEx);
                unZIPFilepropCount++;
            }

            if (unZIPFileexcludeFilesRegEx != null)
            {
                unZIPFile["ExcludeFilesRegEx"] = CSharpExpressionConverter.ConvertToken(unZIPFileexcludeFilesRegEx);
                unZIPFilepropCount++;
            }

            unZIPFilepropCount++;
            unZIPFile["Workflow"] = CSharpExpressionConverter.ConvertToken(unZIPFileworkflow);
            if (unZIPFilepropCount > 0)
            {
                callPayload.Body = unZIPFile;
            }

            return new ApiConnectionAction<UnZIPFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddFileToZIP(Expression<Func<string>> addFileToZIPsourceFilenameToAddToZIP, Expression<Func<string>> addFileToZIPoutputZIPFilename, Expression<Func<string>> addFileToZIPworkflow, Expression<Func<string>> addFileToZIPaddFilenameToFolderInZIP = null, Expression<Func<string>> addFileToZIPsourceFilenameToAddToZIPComment = null, Expression<Func<bool>> addFileToZIPcompress = null, Expression<Func<bool>> addFileToZIPaddToExistingZIPFile = null)
        {
            var apiCallPath = "/FileManagement/AddFileToZIP";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addFileToZIP = new JObject();
            var addFileToZIPpropCount = 0;
            addFileToZIPpropCount++;
            addFileToZIP["SourceFilenameToAddToZIP"] = CSharpExpressionConverter.ConvertToken(addFileToZIPsourceFilenameToAddToZIP);
            addFileToZIPpropCount++;
            addFileToZIP["OutputZIPFilename"] = CSharpExpressionConverter.ConvertToken(addFileToZIPoutputZIPFilename);
            if (addFileToZIPaddFilenameToFolderInZIP != null)
            {
                addFileToZIP["AddFilenameToFolderInZIP"] = CSharpExpressionConverter.ConvertToken(addFileToZIPaddFilenameToFolderInZIP);
                addFileToZIPpropCount++;
            }

            if (addFileToZIPsourceFilenameToAddToZIPComment != null)
            {
                addFileToZIP["SourceFilenameToAddToZIPComment"] = CSharpExpressionConverter.ConvertToken(addFileToZIPsourceFilenameToAddToZIPComment);
                addFileToZIPpropCount++;
            }

            if (addFileToZIPcompress != null)
            {
                if (addFileToZIPcompress != null)
                {
                    addFileToZIP["Compress"] = CSharpExpressionConverter.ConvertToken(addFileToZIPcompress);
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
                    addFileToZIP["AddToExistingZIPFile"] = CSharpExpressionConverter.ConvertToken(addFileToZIPaddToExistingZIPFile);
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
            addFileToZIP["Workflow"] = CSharpExpressionConverter.ConvertToken(addFileToZIPworkflow);
            if (addFileToZIPpropCount > 0)
            {
                callPayload.Body = addFileToZIP;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AddFolderToZIPResponse> AddFolderToZIP(Expression<Func<string>> addFolderToZIPsourceFolderToAddToZIP, Expression<Func<string>> addFolderToZIPoutputZIPFilename, Expression<Func<string>> addFolderToZIPworkflow, Expression<Func<string>> addFolderToZIPaddFilesToFolderInZIP = null, Expression<Func<bool>> addFolderToZIPcompress = null, Expression<Func<bool>> addFolderToZIPaddToExistingZIPFile = null, Expression<Func<bool>> addFolderToZIPincludeSubfolders = null, Expression<Func<string>> addFolderToZIPincludeFilesRegEx = null, Expression<Func<string>> addFolderToZIPexcludeFilesRegEx = null)
        {
            var apiCallPath = "/FileManagement/AddFolderToZIP";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addFolderToZIP = new JObject();
            var addFolderToZIPpropCount = 0;
            addFolderToZIPpropCount++;
            addFolderToZIP["SourceFolderToAddToZIP"] = CSharpExpressionConverter.ConvertToken(addFolderToZIPsourceFolderToAddToZIP);
            addFolderToZIPpropCount++;
            addFolderToZIP["OutputZIPFilename"] = CSharpExpressionConverter.ConvertToken(addFolderToZIPoutputZIPFilename);
            if (addFolderToZIPaddFilesToFolderInZIP != null)
            {
                addFolderToZIP["AddFilesToFolderInZIP"] = CSharpExpressionConverter.ConvertToken(addFolderToZIPaddFilesToFolderInZIP);
                addFolderToZIPpropCount++;
            }

            if (addFolderToZIPcompress != null)
            {
                if (addFolderToZIPcompress != null)
                {
                    addFolderToZIP["Compress"] = CSharpExpressionConverter.ConvertToken(addFolderToZIPcompress);
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
                    addFolderToZIP["AddToExistingZIPFile"] = CSharpExpressionConverter.ConvertToken(addFolderToZIPaddToExistingZIPFile);
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
                    addFolderToZIP["IncludeSubfolders"] = CSharpExpressionConverter.ConvertToken(addFolderToZIPincludeSubfolders);
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
                addFolderToZIP["IncludeFilesRegEx"] = CSharpExpressionConverter.ConvertToken(addFolderToZIPincludeFilesRegEx);
                addFolderToZIPpropCount++;
            }

            if (addFolderToZIPexcludeFilesRegEx != null)
            {
                addFolderToZIP["ExcludeFilesRegEx"] = CSharpExpressionConverter.ConvertToken(addFolderToZIPexcludeFilesRegEx);
                addFolderToZIPpropCount++;
            }

            addFolderToZIPpropCount++;
            addFolderToZIP["Workflow"] = CSharpExpressionConverter.ConvertToken(addFolderToZIPworkflow);
            if (addFolderToZIPpropCount > 0)
            {
                callPayload.Body = addFolderToZIP;
            }

            return new ApiConnectionAction<AddFolderToZIPResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileContentsAsBase64Response> GetFileContentsAsBase64(Expression<Func<string>> getFileContentsAsBase64filePath, Expression<Func<string>> getFileContentsAsBase64workflow, Expression<Func<bool>> getFileContentsAsBase64compress = null, Expression<Func<int>> getFileContentsAsBase64maxFileSize = null)
        {
            var apiCallPath = "/FileManagement/GetFileContentsAsBase64";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getFileContentsAsBase64 = new JObject();
            var getFileContentsAsBase64propCount = 0;
            getFileContentsAsBase64propCount++;
            getFileContentsAsBase64["FilePath"] = CSharpExpressionConverter.ConvertToken(getFileContentsAsBase64filePath);
            if (getFileContentsAsBase64compress != null)
            {
                if (getFileContentsAsBase64compress != null)
                {
                    getFileContentsAsBase64["Compress"] = CSharpExpressionConverter.ConvertToken(getFileContentsAsBase64compress);
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
                    getFileContentsAsBase64["MaxFileSize"] = CSharpExpressionConverter.ConvertToken(getFileContentsAsBase64maxFileSize);
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
            getFileContentsAsBase64["Workflow"] = CSharpExpressionConverter.ConvertToken(getFileContentsAsBase64workflow);
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