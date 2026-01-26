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
        public IBodyWorkflowAction<GetMachineNameResponse> GetMachineName(Expression<Func<string>> getMachineNameWorkflow)
        {
            var apiCallPath = "/Environment/GetMachineName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getMachineName = new JObject();
            var getMachineNamepropCount = 0;
            getMachineNamepropCount++;
            getMachineName["Workflow"] = ExpressionConverter.ConvertO(getMachineNameWorkflow);
            if (getMachineNamepropCount > 0)
            {
                callPayload.Body = getMachineName;
            }

            return new ApiConnectionAction<GetMachineNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMachineDomainResponse> GetMachineDomain(Expression<Func<string>> getMachineDomainWorkflow)
        {
            var apiCallPath = "/Environment/GetMachineDomain";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getMachineDomain = new JObject();
            var getMachineDomainpropCount = 0;
            getMachineDomainpropCount++;
            getMachineDomain["Workflow"] = ExpressionConverter.ConvertO(getMachineDomainWorkflow);
            if (getMachineDomainpropCount > 0)
            {
                callPayload.Body = getMachineDomain;
            }

            return new ApiConnectionAction<GetMachineDomainResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteSessionClientHostnameResponse> GetRemoteSessionClientHostname(Expression<Func<string>> getRemoteSessionClientHostnameWorkflow)
        {
            var apiCallPath = "/Environment/GetRemoteSessionClientHostname";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRemoteSessionClientHostname = new JObject();
            var getRemoteSessionClientHostnamepropCount = 0;
            getRemoteSessionClientHostnamepropCount++;
            getRemoteSessionClientHostname["Workflow"] = ExpressionConverter.ConvertO(getRemoteSessionClientHostnameWorkflow);
            if (getRemoteSessionClientHostnamepropCount > 0)
            {
                callPayload.Body = getRemoteSessionClientHostname;
            }

            return new ApiConnectionAction<GetRemoteSessionClientHostnameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ExpandEnvironmentVariableResponse> ExpandEnvironmentVariable(Expression<Func<string>> expandEnvironmentVariableInputString, Expression<Func<string>> expandEnvironmentVariableWorkflow)
        {
            var apiCallPath = "/Environment/ExpandEnvironmentVariable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var expandEnvironmentVariable = new JObject();
            var expandEnvironmentVariablepropCount = 0;
            expandEnvironmentVariablepropCount++;
            expandEnvironmentVariable["InputString"] = ExpressionConverter.ConvertO(expandEnvironmentVariableInputString);
            expandEnvironmentVariablepropCount++;
            expandEnvironmentVariable["Workflow"] = ExpressionConverter.ConvertO(expandEnvironmentVariableWorkflow);
            if (expandEnvironmentVariablepropCount > 0)
            {
                callPayload.Body = expandEnvironmentVariable;
            }

            return new ApiConnectionAction<ExpandEnvironmentVariableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillProcessResponse> KillProcess(Expression<Func<string>> killProcessProcessName, Expression<Func<string>> killProcessWorkflow)
        {
            var apiCallPath = "/Environment/KillProcess";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var killProcess = new JObject();
            var killProcesspropCount = 0;
            killProcesspropCount++;
            killProcess["ProcessName"] = ExpressionConverter.ConvertO(killProcessProcessName);
            killProcesspropCount++;
            killProcess["Workflow"] = ExpressionConverter.ConvertO(killProcessWorkflow);
            if (killProcesspropCount > 0)
            {
                callPayload.Body = killProcess;
            }

            return new ApiConnectionAction<KillProcessResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillProcessIDResponse> KillProcessID(Expression<Func<int>> killProcessIDProcessID, Expression<Func<string>> killProcessIDWorkflow)
        {
            var apiCallPath = "/Environment/KillProcessID";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var killProcessID = new JObject();
            var killProcessIDpropCount = 0;
            killProcessIDpropCount++;
            killProcessID["ProcessID"] = ExpressionConverter.ConvertO(killProcessIDProcessID);
            killProcessIDpropCount++;
            killProcessID["Workflow"] = ExpressionConverter.ConvertO(killProcessIDWorkflow);
            if (killProcessIDpropCount > 0)
            {
                callPayload.Body = killProcessID;
            }

            return new ApiConnectionAction<KillProcessIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessCountByNameResponse> GetProcessCountByName(Expression<Func<string>> getProcessCountByNameProcessName, Expression<Func<string>> getProcessCountByNameWorkflow)
        {
            var apiCallPath = "/Environment/GetProcessCountByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getProcessCountByName = new JObject();
            var getProcessCountByNamepropCount = 0;
            getProcessCountByNamepropCount++;
            getProcessCountByName["ProcessName"] = ExpressionConverter.ConvertO(getProcessCountByNameProcessName);
            getProcessCountByNamepropCount++;
            getProcessCountByName["Workflow"] = ExpressionConverter.ConvertO(getProcessCountByNameWorkflow);
            if (getProcessCountByNamepropCount > 0)
            {
                callPayload.Body = getProcessCountByName;
            }

            return new ApiConnectionAction<GetProcessCountByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentProcessCountResponse> GetAgentProcessCount(Expression<Func<string>> getAgentProcessCountWorkflow)
        {
            var apiCallPath = "/Environment/GetAgentProcessCount";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getAgentProcessCount = new JObject();
            var getAgentProcessCountpropCount = 0;
            getAgentProcessCountpropCount++;
            getAgentProcessCount["Workflow"] = ExpressionConverter.ConvertO(getAgentProcessCountWorkflow);
            if (getAgentProcessCountpropCount > 0)
            {
                callPayload.Body = getAgentProcessCount;
            }

            return new ApiConnectionAction<GetAgentProcessCountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillAllOtherAgentsResponse> KillAllOtherAgents(Expression<Func<string>> killAllOtherAgentsWorkflow)
        {
            var apiCallPath = "/Environment/KillAllOtherAgents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var killAllOtherAgents = new JObject();
            var killAllOtherAgentspropCount = 0;
            killAllOtherAgentspropCount++;
            killAllOtherAgents["Workflow"] = ExpressionConverter.ConvertO(killAllOtherAgentsWorkflow);
            if (killAllOtherAgentspropCount > 0)
            {
                callPayload.Body = killAllOtherAgents;
            }

            return new ApiConnectionAction<KillAllOtherAgentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessByPIDResponse> GetProcessByPID(Expression<Func<int>> getProcessByPIDProcessId, Expression<Func<string>> getProcessByPIDWorkflow)
        {
            var apiCallPath = "/Environment/GetProcessByPID";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getProcessByPID = new JObject();
            var getProcessByPIDpropCount = 0;
            getProcessByPIDpropCount++;
            getProcessByPID["ProcessId"] = ExpressionConverter.ConvertO(getProcessByPIDProcessId);
            getProcessByPIDpropCount++;
            getProcessByPID["Workflow"] = ExpressionConverter.ConvertO(getProcessByPIDWorkflow);
            if (getProcessByPIDpropCount > 0)
            {
                callPayload.Body = getProcessByPID;
            }

            return new ApiConnectionAction<GetProcessByPIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessesResponse> GetProcesses(Expression<Func<string>> getProcessesWorkflow, Expression<Func<string>> getProcessesProcessName = null, Expression<Func<bool>> getProcessesGetProcessCommandLine = null)
        {
            var apiCallPath = "/Environment/GetProcesses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getProcesses = new JObject();
            var getProcessespropCount = 0;
            if (getProcessesProcessName != null)
            {
                getProcesses["ProcessName"] = ExpressionConverter.ConvertO(getProcessesProcessName);
                getProcessespropCount++;
            }

            if (getProcessesGetProcessCommandLine != null)
            {
                getProcesses["GetProcessCommandLine"] = ExpressionConverter.ConvertO(getProcessesGetProcessCommandLine);
                getProcessespropCount++;
            }

            getProcessespropCount++;
            getProcesses["Workflow"] = ExpressionConverter.ConvertO(getProcessesWorkflow);
            if (getProcessespropCount > 0)
            {
                callPayload.Body = getProcesses;
            }

            return new ApiConnectionAction<GetProcessesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunProcessResponse> RunProcess(Expression<Func<string>> runProcessProcessName, Expression<Func<string>> runProcessWorkflow, Expression<Func<string>> runProcessArguments = null, Expression<Func<string>> runProcessWorkingDirectory = null, Expression<Func<bool>> runProcessUseShellExecute = null, Expression<Func<bool>> runProcessCreateNoWindow = null, Expression<Func<runProcessWindowStyleInput>> runProcessWindowStyle = null, Expression<Func<bool>> runProcessWaitForProcess = null, Expression<Func<bool>> runProcessRedirectStandardOutput = null, Expression<Func<bool>> runProcessRedirectStandardError = null, Expression<Func<bool>> runProcessRedirectStandardErrorToOutput = null, Expression<Func<runProcessStandardOutputEncodingInput>> runProcessStandardOutputEncoding = null, Expression<Func<runProcessStandardErrorEncodingInput>> runProcessStandardErrorEncoding = null, Expression<Func<string>> runProcessRunAsDomain = null, Expression<Func<string>> runProcessRunAsUsername = null, Expression<Func<string>> runProcessRunAsPassword = null, Expression<Func<bool>> runProcessRunAsLoadUserProfile = null, Expression<Func<bool>> runProcessRunAsElevate = null, Expression<Func<int>> runProcessTimeoutInSeconds = null)
        {
            var apiCallPath = "/Environment/RunProcess";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runProcess = new JObject();
            var runProcesspropCount = 0;
            runProcesspropCount++;
            runProcess["ProcessName"] = ExpressionConverter.ConvertO(runProcessProcessName);
            if (runProcessArguments != null)
            {
                runProcess["Arguments"] = ExpressionConverter.ConvertO(runProcessArguments);
                runProcesspropCount++;
            }

            if (runProcessWorkingDirectory != null)
            {
                runProcess["WorkingDirectory"] = ExpressionConverter.ConvertO(runProcessWorkingDirectory);
                runProcesspropCount++;
            }

            if (runProcessUseShellExecute != null)
            {
                runProcess["UseShellExecute"] = ExpressionConverter.ConvertO(runProcessUseShellExecute);
                runProcesspropCount++;
            }

            if (runProcessCreateNoWindow != null)
            {
                runProcess["CreateNoWindow"] = ExpressionConverter.ConvertO(runProcessCreateNoWindow);
                runProcesspropCount++;
            }

            if (runProcessWindowStyle != null)
            {
                runProcess["WindowStyle"] = ExpressionConverter.ConvertO(runProcessWindowStyle);
                runProcesspropCount++;
            }

            if (runProcessWaitForProcess != null)
            {
                runProcess["WaitForProcess"] = ExpressionConverter.ConvertO(runProcessWaitForProcess);
                runProcesspropCount++;
            }

            if (runProcessRedirectStandardOutput != null)
            {
                runProcess["RedirectStandardOutput"] = ExpressionConverter.ConvertO(runProcessRedirectStandardOutput);
                runProcesspropCount++;
            }

            if (runProcessRedirectStandardError != null)
            {
                runProcess["RedirectStandardError"] = ExpressionConverter.ConvertO(runProcessRedirectStandardError);
                runProcesspropCount++;
            }

            if (runProcessRedirectStandardErrorToOutput != null)
            {
                runProcess["RedirectStandardErrorToOutput"] = ExpressionConverter.ConvertO(runProcessRedirectStandardErrorToOutput);
                runProcesspropCount++;
            }

            if (runProcessStandardOutputEncoding != null)
            {
                runProcess["StandardOutputEncoding"] = ExpressionConverter.ConvertO(runProcessStandardOutputEncoding);
                runProcesspropCount++;
            }

            if (runProcessStandardErrorEncoding != null)
            {
                runProcess["StandardErrorEncoding"] = ExpressionConverter.ConvertO(runProcessStandardErrorEncoding);
                runProcesspropCount++;
            }

            if (runProcessRunAsDomain != null)
            {
                runProcess["RunAsDomain"] = ExpressionConverter.ConvertO(runProcessRunAsDomain);
                runProcesspropCount++;
            }

            if (runProcessRunAsUsername != null)
            {
                runProcess["RunAsUsername"] = ExpressionConverter.ConvertO(runProcessRunAsUsername);
                runProcesspropCount++;
            }

            if (runProcessRunAsPassword != null)
            {
                runProcess["RunAsPassword"] = ExpressionConverter.ConvertO(runProcessRunAsPassword);
                runProcesspropCount++;
            }

            if (runProcessRunAsLoadUserProfile != null)
            {
                runProcess["RunAsLoadUserProfile"] = ExpressionConverter.ConvertO(runProcessRunAsLoadUserProfile);
                runProcesspropCount++;
            }

            if (runProcessRunAsElevate != null)
            {
                runProcess["RunAsElevate"] = ExpressionConverter.ConvertO(runProcessRunAsElevate);
                runProcesspropCount++;
            }

            if (runProcessTimeoutInSeconds != null)
            {
                runProcess["TimeoutInSeconds"] = ExpressionConverter.ConvertO(runProcessTimeoutInSeconds);
                runProcesspropCount++;
            }

            runProcesspropCount++;
            runProcess["Workflow"] = ExpressionConverter.ConvertO(runProcessWorkflow);
            if (runProcesspropCount > 0)
            {
                callPayload.Body = runProcess;
            }

            return new ApiConnectionAction<RunProcessResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunPowerShellProcessResponse> RunPowerShellProcess(Expression<Func<string>> runPowerShellProcessWorkflow, Expression<Func<string>> runPowerShellProcessPowerShellExecutable = null, Expression<Func<string>> runPowerShellProcessPowerShellScriptFilePath = null, Expression<Func<string>> runPowerShellProcessPowerShellScriptContents = null, Expression<Func<string>> runPowerShellProcessWorkingDirectory = null, Expression<Func<bool>> runPowerShellProcessCreateNoWindow = null, Expression<Func<runPowerShellProcessWindowStyleInput>> runPowerShellProcessWindowStyle = null, Expression<Func<bool>> runPowerShellProcessWaitForProcess = null, Expression<Func<bool>> runPowerShellProcessRedirectStandardOutput = null, Expression<Func<bool>> runPowerShellProcessRedirectStandardError = null, Expression<Func<bool>> runPowerShellProcessRedirectStandardErrorToOutput = null, Expression<Func<runPowerShellProcessStandardOutputEncodingInput>> runPowerShellProcessStandardOutputEncoding = null, Expression<Func<runPowerShellProcessStandardErrorEncodingInput>> runPowerShellProcessStandardErrorEncoding = null, Expression<Func<string>> runPowerShellProcessRunAsDomain = null, Expression<Func<string>> runPowerShellProcessRunAsUsername = null, Expression<Func<string>> runPowerShellProcessRunAsPassword = null, Expression<Func<bool>> runPowerShellProcessRunAsLoadUserProfile = null, Expression<Func<bool>> runPowerShellProcessRunAsElevate = null, Expression<Func<int>> runPowerShellProcessTimeoutInSeconds = null, Expression<Func<string>> runPowerShellProcessPowerShellScriptTempFolder = null)
        {
            var apiCallPath = "/Environment/RunPowerShellProcess";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runPowerShellProcess = new JObject();
            var runPowerShellProcesspropCount = 0;
            if (runPowerShellProcessPowerShellExecutable != null)
            {
                runPowerShellProcess["PowerShellExecutable"] = ExpressionConverter.ConvertO(runPowerShellProcessPowerShellExecutable);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessPowerShellScriptFilePath != null)
            {
                runPowerShellProcess["PowerShellScriptFilePath"] = ExpressionConverter.ConvertO(runPowerShellProcessPowerShellScriptFilePath);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessPowerShellScriptContents != null)
            {
                runPowerShellProcess["PowerShellScriptContents"] = ExpressionConverter.ConvertO(runPowerShellProcessPowerShellScriptContents);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessWorkingDirectory != null)
            {
                runPowerShellProcess["WorkingDirectory"] = ExpressionConverter.ConvertO(runPowerShellProcessWorkingDirectory);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessCreateNoWindow != null)
            {
                runPowerShellProcess["CreateNoWindow"] = ExpressionConverter.ConvertO(runPowerShellProcessCreateNoWindow);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessWindowStyle != null)
            {
                runPowerShellProcess["WindowStyle"] = ExpressionConverter.ConvertO(runPowerShellProcessWindowStyle);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessWaitForProcess != null)
            {
                runPowerShellProcess["WaitForProcess"] = ExpressionConverter.ConvertO(runPowerShellProcessWaitForProcess);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessRedirectStandardOutput != null)
            {
                runPowerShellProcess["RedirectStandardOutput"] = ExpressionConverter.ConvertO(runPowerShellProcessRedirectStandardOutput);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessRedirectStandardError != null)
            {
                runPowerShellProcess["RedirectStandardError"] = ExpressionConverter.ConvertO(runPowerShellProcessRedirectStandardError);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessRedirectStandardErrorToOutput != null)
            {
                runPowerShellProcess["RedirectStandardErrorToOutput"] = ExpressionConverter.ConvertO(runPowerShellProcessRedirectStandardErrorToOutput);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessStandardOutputEncoding != null)
            {
                runPowerShellProcess["StandardOutputEncoding"] = ExpressionConverter.ConvertO(runPowerShellProcessStandardOutputEncoding);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessStandardErrorEncoding != null)
            {
                runPowerShellProcess["StandardErrorEncoding"] = ExpressionConverter.ConvertO(runPowerShellProcessStandardErrorEncoding);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessRunAsDomain != null)
            {
                runPowerShellProcess["RunAsDomain"] = ExpressionConverter.ConvertO(runPowerShellProcessRunAsDomain);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessRunAsUsername != null)
            {
                runPowerShellProcess["RunAsUsername"] = ExpressionConverter.ConvertO(runPowerShellProcessRunAsUsername);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessRunAsPassword != null)
            {
                runPowerShellProcess["RunAsPassword"] = ExpressionConverter.ConvertO(runPowerShellProcessRunAsPassword);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessRunAsLoadUserProfile != null)
            {
                runPowerShellProcess["RunAsLoadUserProfile"] = ExpressionConverter.ConvertO(runPowerShellProcessRunAsLoadUserProfile);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessRunAsElevate != null)
            {
                runPowerShellProcess["RunAsElevate"] = ExpressionConverter.ConvertO(runPowerShellProcessRunAsElevate);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessTimeoutInSeconds != null)
            {
                runPowerShellProcess["TimeoutInSeconds"] = ExpressionConverter.ConvertO(runPowerShellProcessTimeoutInSeconds);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessPowerShellScriptTempFolder != null)
            {
                runPowerShellProcess["PowerShellScriptTempFolder"] = ExpressionConverter.ConvertO(runPowerShellProcessPowerShellScriptTempFolder);
                runPowerShellProcesspropCount++;
            }

            runPowerShellProcesspropCount++;
            runPowerShellProcess["Workflow"] = ExpressionConverter.ConvertO(runPowerShellProcessWorkflow);
            if (runPowerShellProcesspropCount > 0)
            {
                callPayload.Body = runPowerShellProcess;
            }

            return new ApiConnectionAction<RunPowerShellProcessResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetScreenResolutionResponse> GetScreenResolution(Expression<Func<string>> getScreenResolutionWorkflow)
        {
            var apiCallPath = "/Environment/GetScreenResolution";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getScreenResolution = new JObject();
            var getScreenResolutionpropCount = 0;
            getScreenResolutionpropCount++;
            getScreenResolution["Workflow"] = ExpressionConverter.ConvertO(getScreenResolutionWorkflow);
            if (getScreenResolutionpropCount > 0)
            {
                callPayload.Body = getScreenResolution;
            }

            return new ApiConnectionAction<GetScreenResolutionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetDefaultPrinter(Expression<Func<string>> setDefaultPrinterDefaultPrinterName, Expression<Func<string>> setDefaultPrinterWorkflow)
        {
            var apiCallPath = "/Environment/SetDefaultPrinter";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setDefaultPrinter = new JObject();
            var setDefaultPrinterpropCount = 0;
            setDefaultPrinterpropCount++;
            setDefaultPrinter["DefaultPrinterName"] = ExpressionConverter.ConvertO(setDefaultPrinterDefaultPrinterName);
            setDefaultPrinterpropCount++;
            setDefaultPrinter["Workflow"] = ExpressionConverter.ConvertO(setDefaultPrinterWorkflow);
            if (setDefaultPrinterpropCount > 0)
            {
                callPayload.Body = setDefaultPrinter;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDefaultPrinterResponse> GetDefaultPrinter(Expression<Func<string>> getDefaultPrinterWorkflow)
        {
            var apiCallPath = "/Environment/GetDefaultPrinter";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getDefaultPrinter = new JObject();
            var getDefaultPrinterpropCount = 0;
            getDefaultPrinterpropCount++;
            getDefaultPrinter["Workflow"] = ExpressionConverter.ConvertO(getDefaultPrinterWorkflow);
            if (getDefaultPrinterpropCount > 0)
            {
                callPayload.Body = getDefaultPrinter;
            }

            return new ApiConnectionAction<GetDefaultPrinterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfPrintersResponse> GetListOfPrinters(Expression<Func<string>> getListOfPrintersWorkflow, Expression<Func<bool>> getListOfPrintersListLocalPrinters = null, Expression<Func<bool>> getListOfPrintersListNetworkPrinters = null, Expression<Func<bool>> getListOfPrintersReturnDetailedInformation = null)
        {
            var apiCallPath = "/Environment/GetListOfPrinters";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getListOfPrinters = new JObject();
            var getListOfPrinterspropCount = 0;
            if (getListOfPrintersListLocalPrinters != null)
            {
                getListOfPrinters["ListLocalPrinters"] = ExpressionConverter.ConvertO(getListOfPrintersListLocalPrinters);
                getListOfPrinterspropCount++;
            }

            if (getListOfPrintersListNetworkPrinters != null)
            {
                getListOfPrinters["ListNetworkPrinters"] = ExpressionConverter.ConvertO(getListOfPrintersListNetworkPrinters);
                getListOfPrinterspropCount++;
            }

            if (getListOfPrintersReturnDetailedInformation != null)
            {
                getListOfPrinters["ReturnDetailedInformation"] = ExpressionConverter.ConvertO(getListOfPrintersReturnDetailedInformation);
                getListOfPrinterspropCount++;
            }

            getListOfPrinterspropCount++;
            getListOfPrinters["Workflow"] = ExpressionConverter.ConvertO(getListOfPrintersWorkflow);
            if (getListOfPrinterspropCount > 0)
            {
                callPayload.Body = getListOfPrinters;
            }

            return new ApiConnectionAction<GetListOfPrintersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetMouseMultiplier(Expression<Func<string>> setMouseMultiplierWorkflow, Expression<Func<double>> setMouseMultiplierMouseXMultiplier = null, Expression<Func<double>> setMouseMultiplierMouseYMultiplier = null, Expression<Func<bool>> setMouseMultiplierApplyToMouseEvent = null, Expression<Func<bool>> setMouseMultiplierApplyToSetCursorPos = null, Expression<Func<bool>> setMouseMultiplierApplyToCurrentMouseMoveMethod = null)
        {
            var apiCallPath = "/Environment/SetMouseMultiplier";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setMouseMultiplier = new JObject();
            var setMouseMultiplierpropCount = 0;
            if (setMouseMultiplierMouseXMultiplier != null)
            {
                setMouseMultiplier["MouseXMultiplier"] = ExpressionConverter.ConvertO(setMouseMultiplierMouseXMultiplier);
                setMouseMultiplierpropCount++;
            }

            if (setMouseMultiplierMouseYMultiplier != null)
            {
                setMouseMultiplier["MouseYMultiplier"] = ExpressionConverter.ConvertO(setMouseMultiplierMouseYMultiplier);
                setMouseMultiplierpropCount++;
            }

            if (setMouseMultiplierApplyToMouseEvent != null)
            {
                setMouseMultiplier["ApplyToMouseEvent"] = ExpressionConverter.ConvertO(setMouseMultiplierApplyToMouseEvent);
                setMouseMultiplierpropCount++;
            }

            if (setMouseMultiplierApplyToSetCursorPos != null)
            {
                setMouseMultiplier["ApplyToSetCursorPos"] = ExpressionConverter.ConvertO(setMouseMultiplierApplyToSetCursorPos);
                setMouseMultiplierpropCount++;
            }

            if (setMouseMultiplierApplyToCurrentMouseMoveMethod != null)
            {
                setMouseMultiplier["ApplyToCurrentMouseMoveMethod"] = ExpressionConverter.ConvertO(setMouseMultiplierApplyToCurrentMouseMoveMethod);
                setMouseMultiplierpropCount++;
            }

            setMouseMultiplierpropCount++;
            setMouseMultiplier["Workflow"] = ExpressionConverter.ConvertO(setMouseMultiplierWorkflow);
            if (setMouseMultiplierpropCount > 0)
            {
                callPayload.Body = setMouseMultiplier;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMouseMultiplierResponse> GetMouseMultiplier(Expression<Func<string>> getMouseMultiplierWorkflow)
        {
            var apiCallPath = "/Environment/GetMouseMultiplier";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getMouseMultiplier = new JObject();
            var getMouseMultiplierpropCount = 0;
            getMouseMultiplierpropCount++;
            getMouseMultiplier["Workflow"] = ExpressionConverter.ConvertO(getMouseMultiplierWorkflow);
            if (getMouseMultiplierpropCount > 0)
            {
                callPayload.Body = getMouseMultiplier;
            }

            return new ApiConnectionAction<GetMouseMultiplierResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseToCoordinate(Expression<Func<int>> moveMouseToCoordinateXCoord, Expression<Func<int>> moveMouseToCoordinateYCoord, Expression<Func<string>> moveMouseToCoordinateWorkflow)
        {
            var apiCallPath = "/Environment/MoveMouseToCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var moveMouseToCoordinate = new JObject();
            var moveMouseToCoordinatepropCount = 0;
            moveMouseToCoordinatepropCount++;
            moveMouseToCoordinate["XCoord"] = ExpressionConverter.ConvertO(moveMouseToCoordinateXCoord);
            moveMouseToCoordinatepropCount++;
            moveMouseToCoordinate["YCoord"] = ExpressionConverter.ConvertO(moveMouseToCoordinateYCoord);
            moveMouseToCoordinatepropCount++;
            moveMouseToCoordinate["Workflow"] = ExpressionConverter.ConvertO(moveMouseToCoordinateWorkflow);
            if (moveMouseToCoordinatepropCount > 0)
            {
                callPayload.Body = moveMouseToCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseRelative(Expression<Func<int>> moveMouseRelativeXCoord, Expression<Func<int>> moveMouseRelativeYCoord, Expression<Func<string>> moveMouseRelativeWorkflow)
        {
            var apiCallPath = "/Environment/MoveMouseRelative";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var moveMouseRelative = new JObject();
            var moveMouseRelativepropCount = 0;
            moveMouseRelativepropCount++;
            moveMouseRelative["XCoord"] = ExpressionConverter.ConvertO(moveMouseRelativeXCoord);
            moveMouseRelativepropCount++;
            moveMouseRelative["YCoord"] = ExpressionConverter.ConvertO(moveMouseRelativeYCoord);
            moveMouseRelativepropCount++;
            moveMouseRelative["Workflow"] = ExpressionConverter.ConvertO(moveMouseRelativeWorkflow);
            if (moveMouseRelativepropCount > 0)
            {
                callPayload.Body = moveMouseRelative;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseButtonDown(Expression<Func<string>> leftMouseButtonDownWorkflow)
        {
            var apiCallPath = "/Environment/LeftMouseButtonDown";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var leftMouseButtonDown = new JObject();
            var leftMouseButtonDownpropCount = 0;
            leftMouseButtonDownpropCount++;
            leftMouseButtonDown["Workflow"] = ExpressionConverter.ConvertO(leftMouseButtonDownWorkflow);
            if (leftMouseButtonDownpropCount > 0)
            {
                callPayload.Body = leftMouseButtonDown;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseButtonUp(Expression<Func<string>> leftMouseButtonUpWorkflow)
        {
            var apiCallPath = "/Environment/LeftMouseButtonUp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var leftMouseButtonUp = new JObject();
            var leftMouseButtonUppropCount = 0;
            leftMouseButtonUppropCount++;
            leftMouseButtonUp["Workflow"] = ExpressionConverter.ConvertO(leftMouseButtonUpWorkflow);
            if (leftMouseButtonUppropCount > 0)
            {
                callPayload.Body = leftMouseButtonUp;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftClickMouse(Expression<Func<string>> leftClickMouseWorkflow)
        {
            var apiCallPath = "/Environment/LeftClickMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var leftClickMouse = new JObject();
            var leftClickMousepropCount = 0;
            leftClickMousepropCount++;
            leftClickMouse["Workflow"] = ExpressionConverter.ConvertO(leftClickMouseWorkflow);
            if (leftClickMousepropCount > 0)
            {
                callPayload.Body = leftClickMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftClickMouseAtCoordinate(Expression<Func<int>> leftClickMouseAtCoordinateXCoord, Expression<Func<int>> leftClickMouseAtCoordinateYCoord, Expression<Func<string>> leftClickMouseAtCoordinateWorkflow)
        {
            var apiCallPath = "/Environment/LeftClickMouseAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var leftClickMouseAtCoordinate = new JObject();
            var leftClickMouseAtCoordinatepropCount = 0;
            leftClickMouseAtCoordinatepropCount++;
            leftClickMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(leftClickMouseAtCoordinateXCoord);
            leftClickMouseAtCoordinatepropCount++;
            leftClickMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(leftClickMouseAtCoordinateYCoord);
            leftClickMouseAtCoordinatepropCount++;
            leftClickMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(leftClickMouseAtCoordinateWorkflow);
            if (leftClickMouseAtCoordinatepropCount > 0)
            {
                callPayload.Body = leftClickMouseAtCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftHoldMouse(Expression<Func<double>> leftHoldMouseSecondsToHold, Expression<Func<string>> leftHoldMouseWorkflow)
        {
            var apiCallPath = "/Environment/LeftHoldMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var leftHoldMouse = new JObject();
            var leftHoldMousepropCount = 0;
            leftHoldMousepropCount++;
            leftHoldMouse["SecondsToHold"] = ExpressionConverter.ConvertO(leftHoldMouseSecondsToHold);
            leftHoldMousepropCount++;
            leftHoldMouse["Workflow"] = ExpressionConverter.ConvertO(leftHoldMouseWorkflow);
            if (leftHoldMousepropCount > 0)
            {
                callPayload.Body = leftHoldMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftHoldMouseAtCoordinate(Expression<Func<int>> leftHoldMouseAtCoordinateXCoord, Expression<Func<int>> leftHoldMouseAtCoordinateYCoord, Expression<Func<double>> leftHoldMouseAtCoordinateSecondsToHold, Expression<Func<string>> leftHoldMouseAtCoordinateWorkflow)
        {
            var apiCallPath = "/Environment/LeftHoldMouseAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var leftHoldMouseAtCoordinate = new JObject();
            var leftHoldMouseAtCoordinatepropCount = 0;
            leftHoldMouseAtCoordinatepropCount++;
            leftHoldMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(leftHoldMouseAtCoordinateXCoord);
            leftHoldMouseAtCoordinatepropCount++;
            leftHoldMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(leftHoldMouseAtCoordinateYCoord);
            leftHoldMouseAtCoordinatepropCount++;
            leftHoldMouseAtCoordinate["SecondsToHold"] = ExpressionConverter.ConvertO(leftHoldMouseAtCoordinateSecondsToHold);
            leftHoldMouseAtCoordinatepropCount++;
            leftHoldMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(leftHoldMouseAtCoordinateWorkflow);
            if (leftHoldMouseAtCoordinatepropCount > 0)
            {
                callPayload.Body = leftHoldMouseAtCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseButtonDown(Expression<Func<string>> rightMouseButtonDownWorkflow)
        {
            var apiCallPath = "/Environment/RightMouseButtonDown";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rightMouseButtonDown = new JObject();
            var rightMouseButtonDownpropCount = 0;
            rightMouseButtonDownpropCount++;
            rightMouseButtonDown["Workflow"] = ExpressionConverter.ConvertO(rightMouseButtonDownWorkflow);
            if (rightMouseButtonDownpropCount > 0)
            {
                callPayload.Body = rightMouseButtonDown;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseButtonUp(Expression<Func<string>> rightMouseButtonUpWorkflow)
        {
            var apiCallPath = "/Environment/RightMouseButtonUp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rightMouseButtonUp = new JObject();
            var rightMouseButtonUppropCount = 0;
            rightMouseButtonUppropCount++;
            rightMouseButtonUp["Workflow"] = ExpressionConverter.ConvertO(rightMouseButtonUpWorkflow);
            if (rightMouseButtonUppropCount > 0)
            {
                callPayload.Body = rightMouseButtonUp;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightClickMouse(Expression<Func<string>> rightClickMouseWorkflow)
        {
            var apiCallPath = "/Environment/RightClickMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rightClickMouse = new JObject();
            var rightClickMousepropCount = 0;
            rightClickMousepropCount++;
            rightClickMouse["Workflow"] = ExpressionConverter.ConvertO(rightClickMouseWorkflow);
            if (rightClickMousepropCount > 0)
            {
                callPayload.Body = rightClickMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightClickMouseAtCoordinate(Expression<Func<int>> rightClickMouseAtCoordinateXCoord, Expression<Func<int>> rightClickMouseAtCoordinateYCoord, Expression<Func<string>> rightClickMouseAtCoordinateWorkflow)
        {
            var apiCallPath = "/Environment/RightClickMouseAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rightClickMouseAtCoordinate = new JObject();
            var rightClickMouseAtCoordinatepropCount = 0;
            rightClickMouseAtCoordinatepropCount++;
            rightClickMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(rightClickMouseAtCoordinateXCoord);
            rightClickMouseAtCoordinatepropCount++;
            rightClickMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(rightClickMouseAtCoordinateYCoord);
            rightClickMouseAtCoordinatepropCount++;
            rightClickMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(rightClickMouseAtCoordinateWorkflow);
            if (rightClickMouseAtCoordinatepropCount > 0)
            {
                callPayload.Body = rightClickMouseAtCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightHoldMouse(Expression<Func<double>> rightHoldMouseSecondsToHold, Expression<Func<string>> rightHoldMouseWorkflow)
        {
            var apiCallPath = "/Environment/RightHoldMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rightHoldMouse = new JObject();
            var rightHoldMousepropCount = 0;
            rightHoldMousepropCount++;
            rightHoldMouse["SecondsToHold"] = ExpressionConverter.ConvertO(rightHoldMouseSecondsToHold);
            rightHoldMousepropCount++;
            rightHoldMouse["Workflow"] = ExpressionConverter.ConvertO(rightHoldMouseWorkflow);
            if (rightHoldMousepropCount > 0)
            {
                callPayload.Body = rightHoldMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightHoldMouseAtCoordinate(Expression<Func<int>> rightHoldMouseAtCoordinateXCoord, Expression<Func<int>> rightHoldMouseAtCoordinateYCoord, Expression<Func<double>> rightHoldMouseAtCoordinateSecondsToHold, Expression<Func<string>> rightHoldMouseAtCoordinateWorkflow)
        {
            var apiCallPath = "/Environment/RightHoldMouseAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rightHoldMouseAtCoordinate = new JObject();
            var rightHoldMouseAtCoordinatepropCount = 0;
            rightHoldMouseAtCoordinatepropCount++;
            rightHoldMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(rightHoldMouseAtCoordinateXCoord);
            rightHoldMouseAtCoordinatepropCount++;
            rightHoldMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(rightHoldMouseAtCoordinateYCoord);
            rightHoldMouseAtCoordinatepropCount++;
            rightHoldMouseAtCoordinate["SecondsToHold"] = ExpressionConverter.ConvertO(rightHoldMouseAtCoordinateSecondsToHold);
            rightHoldMouseAtCoordinatepropCount++;
            rightHoldMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(rightHoldMouseAtCoordinateWorkflow);
            if (rightHoldMouseAtCoordinatepropCount > 0)
            {
                callPayload.Body = rightHoldMouseAtCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseButtonDown(Expression<Func<string>> middleMouseButtonDownWorkflow)
        {
            var apiCallPath = "/Environment/MiddleMouseButtonDown";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var middleMouseButtonDown = new JObject();
            var middleMouseButtonDownpropCount = 0;
            middleMouseButtonDownpropCount++;
            middleMouseButtonDown["Workflow"] = ExpressionConverter.ConvertO(middleMouseButtonDownWorkflow);
            if (middleMouseButtonDownpropCount > 0)
            {
                callPayload.Body = middleMouseButtonDown;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseButtonUp(Expression<Func<string>> middleMouseButtonUpWorkflow)
        {
            var apiCallPath = "/Environment/MiddleMouseButtonUp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var middleMouseButtonUp = new JObject();
            var middleMouseButtonUppropCount = 0;
            middleMouseButtonUppropCount++;
            middleMouseButtonUp["Workflow"] = ExpressionConverter.ConvertO(middleMouseButtonUpWorkflow);
            if (middleMouseButtonUppropCount > 0)
            {
                callPayload.Body = middleMouseButtonUp;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleClickMouse(Expression<Func<string>> middleClickMouseWorkflow)
        {
            var apiCallPath = "/Environment/MiddleClickMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var middleClickMouse = new JObject();
            var middleClickMousepropCount = 0;
            middleClickMousepropCount++;
            middleClickMouse["Workflow"] = ExpressionConverter.ConvertO(middleClickMouseWorkflow);
            if (middleClickMousepropCount > 0)
            {
                callPayload.Body = middleClickMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleClickMouseAtCoordinate(Expression<Func<int>> middleClickMouseAtCoordinateXCoord, Expression<Func<int>> middleClickMouseAtCoordinateYCoord, Expression<Func<string>> middleClickMouseAtCoordinateWorkflow)
        {
            var apiCallPath = "/Environment/MiddleClickMouseAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var middleClickMouseAtCoordinate = new JObject();
            var middleClickMouseAtCoordinatepropCount = 0;
            middleClickMouseAtCoordinatepropCount++;
            middleClickMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(middleClickMouseAtCoordinateXCoord);
            middleClickMouseAtCoordinatepropCount++;
            middleClickMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(middleClickMouseAtCoordinateYCoord);
            middleClickMouseAtCoordinatepropCount++;
            middleClickMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(middleClickMouseAtCoordinateWorkflow);
            if (middleClickMouseAtCoordinatepropCount > 0)
            {
                callPayload.Body = middleClickMouseAtCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleHoldMouse(Expression<Func<double>> middleHoldMouseSecondsToHold, Expression<Func<string>> middleHoldMouseWorkflow)
        {
            var apiCallPath = "/Environment/MiddleHoldMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var middleHoldMouse = new JObject();
            var middleHoldMousepropCount = 0;
            middleHoldMousepropCount++;
            middleHoldMouse["SecondsToHold"] = ExpressionConverter.ConvertO(middleHoldMouseSecondsToHold);
            middleHoldMousepropCount++;
            middleHoldMouse["Workflow"] = ExpressionConverter.ConvertO(middleHoldMouseWorkflow);
            if (middleHoldMousepropCount > 0)
            {
                callPayload.Body = middleHoldMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleHoldMouseAtCoordinate(Expression<Func<int>> middleHoldMouseAtCoordinateXCoord, Expression<Func<int>> middleHoldMouseAtCoordinateYCoord, Expression<Func<double>> middleHoldMouseAtCoordinateSecondsToHold, Expression<Func<string>> middleHoldMouseAtCoordinateWorkflow)
        {
            var apiCallPath = "/Environment/MiddleHoldMouseAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var middleHoldMouseAtCoordinate = new JObject();
            var middleHoldMouseAtCoordinatepropCount = 0;
            middleHoldMouseAtCoordinatepropCount++;
            middleHoldMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(middleHoldMouseAtCoordinateXCoord);
            middleHoldMouseAtCoordinatepropCount++;
            middleHoldMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(middleHoldMouseAtCoordinateYCoord);
            middleHoldMouseAtCoordinatepropCount++;
            middleHoldMouseAtCoordinate["SecondsToHold"] = ExpressionConverter.ConvertO(middleHoldMouseAtCoordinateSecondsToHold);
            middleHoldMouseAtCoordinatepropCount++;
            middleHoldMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(middleHoldMouseAtCoordinateWorkflow);
            if (middleHoldMouseAtCoordinatepropCount > 0)
            {
                callPayload.Body = middleHoldMouseAtCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DoubleLeftClickMouse(Expression<Func<string>> doubleLeftClickMouseWorkflow, Expression<Func<int>> doubleLeftClickMouseDelayInMilliseconds = null)
        {
            var apiCallPath = "/Environment/DoubleLeftClickMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var doubleLeftClickMouse = new JObject();
            var doubleLeftClickMousepropCount = 0;
            if (doubleLeftClickMouseDelayInMilliseconds != null)
            {
                doubleLeftClickMouse["DelayInMilliseconds"] = ExpressionConverter.ConvertO(doubleLeftClickMouseDelayInMilliseconds);
                doubleLeftClickMousepropCount++;
            }

            doubleLeftClickMousepropCount++;
            doubleLeftClickMouse["Workflow"] = ExpressionConverter.ConvertO(doubleLeftClickMouseWorkflow);
            if (doubleLeftClickMousepropCount > 0)
            {
                callPayload.Body = doubleLeftClickMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DoubleLeftClickMouseAtCoordinate(Expression<Func<int>> doubleLeftClickMouseAtCoordinateXCoord, Expression<Func<int>> doubleLeftClickMouseAtCoordinateYCoord, Expression<Func<string>> doubleLeftClickMouseAtCoordinateWorkflow, Expression<Func<int>> doubleLeftClickMouseAtCoordinateDelayInMilliseconds = null)
        {
            var apiCallPath = "/Environment/DoubleLeftClickMouseAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var doubleLeftClickMouseAtCoordinate = new JObject();
            var doubleLeftClickMouseAtCoordinatepropCount = 0;
            doubleLeftClickMouseAtCoordinatepropCount++;
            doubleLeftClickMouseAtCoordinate["XCoord"] = ExpressionConverter.ConvertO(doubleLeftClickMouseAtCoordinateXCoord);
            doubleLeftClickMouseAtCoordinatepropCount++;
            doubleLeftClickMouseAtCoordinate["YCoord"] = ExpressionConverter.ConvertO(doubleLeftClickMouseAtCoordinateYCoord);
            if (doubleLeftClickMouseAtCoordinateDelayInMilliseconds != null)
            {
                doubleLeftClickMouseAtCoordinate["DelayInMilliseconds"] = ExpressionConverter.ConvertO(doubleLeftClickMouseAtCoordinateDelayInMilliseconds);
                doubleLeftClickMouseAtCoordinatepropCount++;
            }

            doubleLeftClickMouseAtCoordinatepropCount++;
            doubleLeftClickMouseAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(doubleLeftClickMouseAtCoordinateWorkflow);
            if (doubleLeftClickMouseAtCoordinatepropCount > 0)
            {
                callPayload.Body = doubleLeftClickMouseAtCoordinate;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LeftMouseDragBetweenCoordinates(Expression<Func<int>> leftMouseDragBetweenCoordinatesStartXCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesStartYCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesEndXCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesEndYCoord, Expression<Func<string>> leftMouseDragBetweenCoordinatesWorkflow, Expression<Func<int>> leftMouseDragBetweenCoordinatesNumberOfSteps = null, Expression<Func<double>> leftMouseDragBetweenCoordinatesTotalTimeInSeconds = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesMaximumMovementPixelJitter = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesMaximumEndPixelJitter = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesMaximumMovementPixelJitterDelta = null)
        {
            var apiCallPath = "/Environment/LeftMouseDragBetweenCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var leftMouseDragBetweenCoordinates = new JObject();
            var leftMouseDragBetweenCoordinatespropCount = 0;
            leftMouseDragBetweenCoordinatespropCount++;
            leftMouseDragBetweenCoordinates["StartXCoord"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesStartXCoord);
            leftMouseDragBetweenCoordinatespropCount++;
            leftMouseDragBetweenCoordinates["StartYCoord"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesStartYCoord);
            leftMouseDragBetweenCoordinatespropCount++;
            leftMouseDragBetweenCoordinates["EndXCoord"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesEndXCoord);
            leftMouseDragBetweenCoordinatespropCount++;
            leftMouseDragBetweenCoordinates["EndYCoord"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesEndYCoord);
            if (leftMouseDragBetweenCoordinatesNumberOfSteps != null)
            {
                leftMouseDragBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesNumberOfSteps);
                leftMouseDragBetweenCoordinatespropCount++;
            }

            if (leftMouseDragBetweenCoordinatesTotalTimeInSeconds != null)
            {
                leftMouseDragBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesTotalTimeInSeconds);
                leftMouseDragBetweenCoordinatespropCount++;
            }

            if (leftMouseDragBetweenCoordinatesMaximumMovementPixelJitter != null)
            {
                leftMouseDragBetweenCoordinates["MaximumMovementPixelJitter"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesMaximumMovementPixelJitter);
                leftMouseDragBetweenCoordinatespropCount++;
            }

            if (leftMouseDragBetweenCoordinatesMaximumEndPixelJitter != null)
            {
                leftMouseDragBetweenCoordinates["MaximumEndPixelJitter"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesMaximumEndPixelJitter);
                leftMouseDragBetweenCoordinatespropCount++;
            }

            if (leftMouseDragBetweenCoordinatesMaximumMovementPixelJitterDelta != null)
            {
                leftMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesMaximumMovementPixelJitterDelta);
                leftMouseDragBetweenCoordinatespropCount++;
            }

            leftMouseDragBetweenCoordinatespropCount++;
            leftMouseDragBetweenCoordinates["Workflow"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesWorkflow);
            if (leftMouseDragBetweenCoordinatespropCount > 0)
            {
                callPayload.Body = leftMouseDragBetweenCoordinates;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RightMouseDragBetweenCoordinates(Expression<Func<int>> rightMouseDragBetweenCoordinatesStartXCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesStartYCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesEndXCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesEndYCoord, Expression<Func<string>> rightMouseDragBetweenCoordinatesWorkflow, Expression<Func<int>> rightMouseDragBetweenCoordinatesNumberOfSteps = null, Expression<Func<double>> rightMouseDragBetweenCoordinatesTotalTimeInSeconds = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesMaximumMovementPixelJitter = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesMaximumEndPixelJitter = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesMaximumMovementPixelJitterDelta = null)
        {
            var apiCallPath = "/Environment/RightMouseDragBetweenCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rightMouseDragBetweenCoordinates = new JObject();
            var rightMouseDragBetweenCoordinatespropCount = 0;
            rightMouseDragBetweenCoordinatespropCount++;
            rightMouseDragBetweenCoordinates["StartXCoord"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesStartXCoord);
            rightMouseDragBetweenCoordinatespropCount++;
            rightMouseDragBetweenCoordinates["StartYCoord"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesStartYCoord);
            rightMouseDragBetweenCoordinatespropCount++;
            rightMouseDragBetweenCoordinates["EndXCoord"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesEndXCoord);
            rightMouseDragBetweenCoordinatespropCount++;
            rightMouseDragBetweenCoordinates["EndYCoord"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesEndYCoord);
            if (rightMouseDragBetweenCoordinatesNumberOfSteps != null)
            {
                rightMouseDragBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesNumberOfSteps);
                rightMouseDragBetweenCoordinatespropCount++;
            }

            if (rightMouseDragBetweenCoordinatesTotalTimeInSeconds != null)
            {
                rightMouseDragBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesTotalTimeInSeconds);
                rightMouseDragBetweenCoordinatespropCount++;
            }

            if (rightMouseDragBetweenCoordinatesMaximumMovementPixelJitter != null)
            {
                rightMouseDragBetweenCoordinates["MaximumMovementPixelJitter"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesMaximumMovementPixelJitter);
                rightMouseDragBetweenCoordinatespropCount++;
            }

            if (rightMouseDragBetweenCoordinatesMaximumEndPixelJitter != null)
            {
                rightMouseDragBetweenCoordinates["MaximumEndPixelJitter"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesMaximumEndPixelJitter);
                rightMouseDragBetweenCoordinatespropCount++;
            }

            if (rightMouseDragBetweenCoordinatesMaximumMovementPixelJitterDelta != null)
            {
                rightMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesMaximumMovementPixelJitterDelta);
                rightMouseDragBetweenCoordinatespropCount++;
            }

            rightMouseDragBetweenCoordinatespropCount++;
            rightMouseDragBetweenCoordinates["Workflow"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesWorkflow);
            if (rightMouseDragBetweenCoordinatespropCount > 0)
            {
                callPayload.Body = rightMouseDragBetweenCoordinates;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MiddleMouseDragBetweenCoordinates(Expression<Func<int>> middleMouseDragBetweenCoordinatesStartXCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesStartYCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesEndXCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesEndYCoord, Expression<Func<string>> middleMouseDragBetweenCoordinatesWorkflow, Expression<Func<int>> middleMouseDragBetweenCoordinatesNumberOfSteps = null, Expression<Func<double>> middleMouseDragBetweenCoordinatesTotalTimeInSeconds = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesMaximumMovementPixelJitter = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesMaximumEndPixelJitter = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesMaximumMovementPixelJitterDelta = null)
        {
            var apiCallPath = "/Environment/MiddleMouseDragBetweenCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var middleMouseDragBetweenCoordinates = new JObject();
            var middleMouseDragBetweenCoordinatespropCount = 0;
            middleMouseDragBetweenCoordinatespropCount++;
            middleMouseDragBetweenCoordinates["StartXCoord"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesStartXCoord);
            middleMouseDragBetweenCoordinatespropCount++;
            middleMouseDragBetweenCoordinates["StartYCoord"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesStartYCoord);
            middleMouseDragBetweenCoordinatespropCount++;
            middleMouseDragBetweenCoordinates["EndXCoord"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesEndXCoord);
            middleMouseDragBetweenCoordinatespropCount++;
            middleMouseDragBetweenCoordinates["EndYCoord"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesEndYCoord);
            if (middleMouseDragBetweenCoordinatesNumberOfSteps != null)
            {
                middleMouseDragBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesNumberOfSteps);
                middleMouseDragBetweenCoordinatespropCount++;
            }

            if (middleMouseDragBetweenCoordinatesTotalTimeInSeconds != null)
            {
                middleMouseDragBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesTotalTimeInSeconds);
                middleMouseDragBetweenCoordinatespropCount++;
            }

            if (middleMouseDragBetweenCoordinatesMaximumMovementPixelJitter != null)
            {
                middleMouseDragBetweenCoordinates["MaximumMovementPixelJitter"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesMaximumMovementPixelJitter);
                middleMouseDragBetweenCoordinatespropCount++;
            }

            if (middleMouseDragBetweenCoordinatesMaximumEndPixelJitter != null)
            {
                middleMouseDragBetweenCoordinates["MaximumEndPixelJitter"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesMaximumEndPixelJitter);
                middleMouseDragBetweenCoordinatespropCount++;
            }

            if (middleMouseDragBetweenCoordinatesMaximumMovementPixelJitterDelta != null)
            {
                middleMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesMaximumMovementPixelJitterDelta);
                middleMouseDragBetweenCoordinatespropCount++;
            }

            middleMouseDragBetweenCoordinatespropCount++;
            middleMouseDragBetweenCoordinates["Workflow"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesWorkflow);
            if (middleMouseDragBetweenCoordinatespropCount > 0)
            {
                callPayload.Body = middleMouseDragBetweenCoordinates;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveMouseBetweenCoordinates(Expression<Func<int>> moveMouseBetweenCoordinatesStartXCoord, Expression<Func<int>> moveMouseBetweenCoordinatesStartYCoord, Expression<Func<int>> moveMouseBetweenCoordinatesEndXCoord, Expression<Func<int>> moveMouseBetweenCoordinatesEndYCoord, Expression<Func<string>> moveMouseBetweenCoordinatesWorkflow, Expression<Func<int>> moveMouseBetweenCoordinatesNumberOfSteps = null, Expression<Func<double>> moveMouseBetweenCoordinatesTotalTimeInSeconds = null, Expression<Func<int>> moveMouseBetweenCoordinatesMaximumMovementPixelJitter = null, Expression<Func<int>> moveMouseBetweenCoordinatesMaximumEndPixelJitter = null, Expression<Func<int>> moveMouseBetweenCoordinatesMaximumMovementPixelJitterDelta = null)
        {
            var apiCallPath = "/Environment/MoveMouseBetweenCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var moveMouseBetweenCoordinates = new JObject();
            var moveMouseBetweenCoordinatespropCount = 0;
            moveMouseBetweenCoordinatespropCount++;
            moveMouseBetweenCoordinates["StartXCoord"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesStartXCoord);
            moveMouseBetweenCoordinatespropCount++;
            moveMouseBetweenCoordinates["StartYCoord"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesStartYCoord);
            moveMouseBetweenCoordinatespropCount++;
            moveMouseBetweenCoordinates["EndXCoord"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesEndXCoord);
            moveMouseBetweenCoordinatespropCount++;
            moveMouseBetweenCoordinates["EndYCoord"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesEndYCoord);
            if (moveMouseBetweenCoordinatesNumberOfSteps != null)
            {
                moveMouseBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesNumberOfSteps);
                moveMouseBetweenCoordinatespropCount++;
            }

            if (moveMouseBetweenCoordinatesTotalTimeInSeconds != null)
            {
                moveMouseBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesTotalTimeInSeconds);
                moveMouseBetweenCoordinatespropCount++;
            }

            if (moveMouseBetweenCoordinatesMaximumMovementPixelJitter != null)
            {
                moveMouseBetweenCoordinates["MaximumMovementPixelJitter"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesMaximumMovementPixelJitter);
                moveMouseBetweenCoordinatespropCount++;
            }

            if (moveMouseBetweenCoordinatesMaximumEndPixelJitter != null)
            {
                moveMouseBetweenCoordinates["MaximumEndPixelJitter"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesMaximumEndPixelJitter);
                moveMouseBetweenCoordinatespropCount++;
            }

            if (moveMouseBetweenCoordinatesMaximumMovementPixelJitterDelta != null)
            {
                moveMouseBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesMaximumMovementPixelJitterDelta);
                moveMouseBetweenCoordinatespropCount++;
            }

            moveMouseBetweenCoordinatespropCount++;
            moveMouseBetweenCoordinates["Workflow"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesWorkflow);
            if (moveMouseBetweenCoordinatespropCount > 0)
            {
                callPayload.Body = moveMouseBetweenCoordinates;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction TurnMouseWheel(Expression<Func<int>> turnMouseWheelWheelTurns, Expression<Func<string>> turnMouseWheelWorkflow)
        {
            var apiCallPath = "/Environment/TurnMouseWheel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var turnMouseWheel = new JObject();
            var turnMouseWheelpropCount = 0;
            turnMouseWheelpropCount++;
            turnMouseWheel["WheelTurns"] = ExpressionConverter.ConvertO(turnMouseWheelWheelTurns);
            turnMouseWheelpropCount++;
            turnMouseWheel["Workflow"] = ExpressionConverter.ConvertO(turnMouseWheelWorkflow);
            if (turnMouseWheelpropCount > 0)
            {
                callPayload.Body = turnMouseWheel;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetCursorPos(Expression<Func<int>> setCursorPosX, Expression<Func<int>> setCursorPosY, Expression<Func<string>> setCursorPosWorkflow)
        {
            var apiCallPath = "/Environment/SetCursorPos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setCursorPos = new JObject();
            var setCursorPospropCount = 0;
            setCursorPospropCount++;
            setCursorPos["X"] = ExpressionConverter.ConvertO(setCursorPosX);
            setCursorPospropCount++;
            setCursorPos["Y"] = ExpressionConverter.ConvertO(setCursorPosY);
            setCursorPospropCount++;
            setCursorPos["Workflow"] = ExpressionConverter.ConvertO(setCursorPosWorkflow);
            if (setCursorPospropCount > 0)
            {
                callPayload.Body = setCursorPos;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetCursorPosResponse> GetCursorPos(Expression<Func<string>> getCursorPosWorkflow)
        {
            var apiCallPath = "/Environment/GetCursorPos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getCursorPos = new JObject();
            var getCursorPospropCount = 0;
            getCursorPospropCount++;
            getCursorPos["Workflow"] = ExpressionConverter.ConvertO(getCursorPosWorkflow);
            if (getCursorPospropCount > 0)
            {
                callPayload.Body = getCursorPos;
            }

            return new ApiConnectionAction<GetCursorPosResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CalibrateMouseEventResponse> CalibrateMouseEvent(Expression<Func<string>> calibrateMouseEventWorkflow, Expression<Func<int>> calibrateMouseEventCalibrationSizeInPixels = null)
        {
            var apiCallPath = "/Environment/CalibrateMouseEvent";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var calibrateMouseEvent = new JObject();
            var calibrateMouseEventpropCount = 0;
            if (calibrateMouseEventCalibrationSizeInPixels != null)
            {
                calibrateMouseEvent["CalibrationSizeInPixels"] = ExpressionConverter.ConvertO(calibrateMouseEventCalibrationSizeInPixels);
                calibrateMouseEventpropCount++;
            }

            calibrateMouseEventpropCount++;
            calibrateMouseEvent["Workflow"] = ExpressionConverter.ConvertO(calibrateMouseEventWorkflow);
            if (calibrateMouseEventpropCount > 0)
            {
                callPayload.Body = calibrateMouseEvent;
            }

            return new ApiConnectionAction<CalibrateMouseEventResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMouseMoveMethodResponse> GetMouseMoveMethod(Expression<Func<string>> getMouseMoveMethodWorkflow)
        {
            var apiCallPath = "/Environment/GetMouseMoveMethod";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getMouseMoveMethod = new JObject();
            var getMouseMoveMethodpropCount = 0;
            getMouseMoveMethodpropCount++;
            getMouseMoveMethod["Workflow"] = ExpressionConverter.ConvertO(getMouseMoveMethodWorkflow);
            if (getMouseMoveMethodpropCount > 0)
            {
                callPayload.Body = getMouseMoveMethod;
            }

            return new ApiConnectionAction<GetMouseMoveMethodResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetMouseMoveMethod(Expression<Func<setMouseMoveMethodMouseMoveMethodInput>> setMouseMoveMethodMouseMoveMethod, Expression<Func<string>> setMouseMoveMethodWorkflow)
        {
            var apiCallPath = "/Environment/SetMouseMoveMethod";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setMouseMoveMethod = new JObject();
            var setMouseMoveMethodpropCount = 0;
            setMouseMoveMethodpropCount++;
            setMouseMoveMethod["MouseMoveMethod"] = ExpressionConverter.ConvertO(setMouseMoveMethodMouseMoveMethod);
            setMouseMoveMethodpropCount++;
            setMouseMoveMethod["Workflow"] = ExpressionConverter.ConvertO(setMouseMoveMethodWorkflow);
            if (setMouseMoveMethodpropCount > 0)
            {
                callPayload.Body = setMouseMoveMethod;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WiggleMouse(Expression<Func<string>> wiggleMouseWorkflow, Expression<Func<int>> wiggleMouseXWiggle = null, Expression<Func<int>> wiggleMouseYWiggle = null, Expression<Func<double>> wiggleMouseWiggleDelayInSeconds = null)
        {
            var apiCallPath = "/Environment/WiggleMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var wiggleMouse = new JObject();
            var wiggleMousepropCount = 0;
            if (wiggleMouseXWiggle != null)
            {
                wiggleMouse["XWiggle"] = ExpressionConverter.ConvertO(wiggleMouseXWiggle);
                wiggleMousepropCount++;
            }

            if (wiggleMouseYWiggle != null)
            {
                wiggleMouse["YWiggle"] = ExpressionConverter.ConvertO(wiggleMouseYWiggle);
                wiggleMousepropCount++;
            }

            if (wiggleMouseWiggleDelayInSeconds != null)
            {
                wiggleMouse["WiggleDelayInSeconds"] = ExpressionConverter.ConvertO(wiggleMouseWiggleDelayInSeconds);
                wiggleMousepropCount++;
            }

            wiggleMousepropCount++;
            wiggleMouse["Workflow"] = ExpressionConverter.ConvertO(wiggleMouseWorkflow);
            if (wiggleMousepropCount > 0)
            {
                callPayload.Body = wiggleMouse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendKeyEvents(Expression<Func<string>> sendKeyEventsText, Expression<Func<string>> sendKeyEventsWorkflow, Expression<Func<int>> sendKeyEventsInterval = null, Expression<Func<bool>> sendKeyEventsIsPassword = null, Expression<Func<bool>> sendKeyEventsDontInterpretSymbols = null)
        {
            var apiCallPath = "/Environment/SendKeyEvents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sendKeyEvents = new JObject();
            var sendKeyEventspropCount = 0;
            sendKeyEventspropCount++;
            sendKeyEvents["Text"] = ExpressionConverter.ConvertO(sendKeyEventsText);
            if (sendKeyEventsInterval != null)
            {
                sendKeyEvents["Interval"] = ExpressionConverter.ConvertO(sendKeyEventsInterval);
                sendKeyEventspropCount++;
            }

            if (sendKeyEventsIsPassword != null)
            {
                sendKeyEvents["IsPassword"] = ExpressionConverter.ConvertO(sendKeyEventsIsPassword);
                sendKeyEventspropCount++;
            }

            if (sendKeyEventsDontInterpretSymbols != null)
            {
                sendKeyEvents["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sendKeyEventsDontInterpretSymbols);
                sendKeyEventspropCount++;
            }

            sendKeyEventspropCount++;
            sendKeyEvents["Workflow"] = ExpressionConverter.ConvertO(sendKeyEventsWorkflow);
            if (sendKeyEventspropCount > 0)
            {
                callPayload.Body = sendKeyEvents;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendPasswordKeyEvents(Expression<Func<string>> sendPasswordKeyEventsPassword, Expression<Func<string>> sendPasswordKeyEventsWorkflow, Expression<Func<int>> sendPasswordKeyEventsInterval = null, Expression<Func<bool>> sendPasswordKeyEventsDontInterpretSymbols = null, Expression<Func<bool>> sendPasswordKeyEventsPasswordContainsStoredPassword = null)
        {
            var apiCallPath = "/Environment/SendPasswordKeyEvents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sendPasswordKeyEvents = new JObject();
            var sendPasswordKeyEventspropCount = 0;
            sendPasswordKeyEventspropCount++;
            sendPasswordKeyEvents["Password"] = ExpressionConverter.ConvertO(sendPasswordKeyEventsPassword);
            if (sendPasswordKeyEventsInterval != null)
            {
                sendPasswordKeyEvents["Interval"] = ExpressionConverter.ConvertO(sendPasswordKeyEventsInterval);
                sendPasswordKeyEventspropCount++;
            }

            if (sendPasswordKeyEventsDontInterpretSymbols != null)
            {
                sendPasswordKeyEvents["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sendPasswordKeyEventsDontInterpretSymbols);
                sendPasswordKeyEventspropCount++;
            }

            if (sendPasswordKeyEventsPasswordContainsStoredPassword != null)
            {
                sendPasswordKeyEvents["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(sendPasswordKeyEventsPasswordContainsStoredPassword);
                sendPasswordKeyEventspropCount++;
            }

            sendPasswordKeyEventspropCount++;
            sendPasswordKeyEvents["Workflow"] = ExpressionConverter.ConvertO(sendPasswordKeyEventsWorkflow);
            if (sendPasswordKeyEventspropCount > 0)
            {
                callPayload.Body = sendPasswordKeyEvents;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendKeys(Expression<Func<string>> sendKeysText, Expression<Func<string>> sendKeysWorkflow, Expression<Func<int>> sendKeysInterval = null, Expression<Func<bool>> sendKeysIsPassword = null, Expression<Func<bool>> sendKeysDontInterpretSymbols = null)
        {
            var apiCallPath = "/Environment/SendKeys";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sendKeys = new JObject();
            var sendKeyspropCount = 0;
            sendKeyspropCount++;
            sendKeys["Text"] = ExpressionConverter.ConvertO(sendKeysText);
            if (sendKeysInterval != null)
            {
                sendKeys["Interval"] = ExpressionConverter.ConvertO(sendKeysInterval);
                sendKeyspropCount++;
            }

            if (sendKeysIsPassword != null)
            {
                sendKeys["IsPassword"] = ExpressionConverter.ConvertO(sendKeysIsPassword);
                sendKeyspropCount++;
            }

            if (sendKeysDontInterpretSymbols != null)
            {
                sendKeys["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sendKeysDontInterpretSymbols);
                sendKeyspropCount++;
            }

            sendKeyspropCount++;
            sendKeys["Workflow"] = ExpressionConverter.ConvertO(sendKeysWorkflow);
            if (sendKeyspropCount > 0)
            {
                callPayload.Body = sendKeys;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SendPasswordKeys(Expression<Func<string>> sendPasswordKeysPassword, Expression<Func<string>> sendPasswordKeysWorkflow, Expression<Func<int>> sendPasswordKeysInterval = null, Expression<Func<bool>> sendPasswordKeysDontInterpretSymbols = null, Expression<Func<bool>> sendPasswordKeysPasswordContainsStoredPassword = null)
        {
            var apiCallPath = "/Environment/SendPasswordKeys";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sendPasswordKeys = new JObject();
            var sendPasswordKeyspropCount = 0;
            sendPasswordKeyspropCount++;
            sendPasswordKeys["Password"] = ExpressionConverter.ConvertO(sendPasswordKeysPassword);
            if (sendPasswordKeysInterval != null)
            {
                sendPasswordKeys["Interval"] = ExpressionConverter.ConvertO(sendPasswordKeysInterval);
                sendPasswordKeyspropCount++;
            }

            if (sendPasswordKeysDontInterpretSymbols != null)
            {
                sendPasswordKeys["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sendPasswordKeysDontInterpretSymbols);
                sendPasswordKeyspropCount++;
            }

            if (sendPasswordKeysPasswordContainsStoredPassword != null)
            {
                sendPasswordKeys["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(sendPasswordKeysPasswordContainsStoredPassword);
                sendPasswordKeyspropCount++;
            }

            sendPasswordKeyspropCount++;
            sendPasswordKeys["Workflow"] = ExpressionConverter.ConvertO(sendPasswordKeysWorkflow);
            if (sendPasswordKeyspropCount > 0)
            {
                callPayload.Body = sendPasswordKeys;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ClearClipboard(Expression<Func<string>> clearClipboardWorkflow)
        {
            var apiCallPath = "/Environment/ClearClipboard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var clearClipboard = new JObject();
            var clearClipboardpropCount = 0;
            clearClipboardpropCount++;
            clearClipboard["Workflow"] = ExpressionConverter.ConvertO(clearClipboardWorkflow);
            if (clearClipboardpropCount > 0)
            {
                callPayload.Body = clearClipboard;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetClipboardData(Expression<Func<string>> setClipboardDataWorkflow, Expression<Func<string>> setClipboardDataNewClipboardData = null)
        {
            var apiCallPath = "/Environment/SetClipboardData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setClipboardData = new JObject();
            var setClipboardDatapropCount = 0;
            if (setClipboardDataNewClipboardData != null)
            {
                setClipboardData["NewClipboardData"] = ExpressionConverter.ConvertO(setClipboardDataNewClipboardData);
                setClipboardDatapropCount++;
            }

            setClipboardDatapropCount++;
            setClipboardData["Workflow"] = ExpressionConverter.ConvertO(setClipboardDataWorkflow);
            if (setClipboardDatapropCount > 0)
            {
                callPayload.Body = setClipboardData;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetClipboardDataResponse> GetClipboardData(Expression<Func<string>> getClipboardDataWorkflow)
        {
            var apiCallPath = "/Environment/GetClipboardData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getClipboardData = new JObject();
            var getClipboardDatapropCount = 0;
            getClipboardDatapropCount++;
            getClipboardData["Workflow"] = ExpressionConverter.ConvertO(getClipboardDataWorkflow);
            if (getClipboardDatapropCount > 0)
            {
                callPayload.Body = getClipboardData;
            }

            return new ApiConnectionAction<GetClipboardDataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TakeScreenshotResponse> TakeScreenshot(Expression<Func<string>> takeScreenshotWorkflow, Expression<Func<bool>> takeScreenshotFullscreen = null, Expression<Func<int>> takeScreenshotLeftXPixels = null, Expression<Func<int>> takeScreenshotTopYPixels = null, Expression<Func<int>> takeScreenshotWidthPixels = null, Expression<Func<int>> takeScreenshotHeightPixels = null, Expression<Func<takeScreenshotImageFormatInput>> takeScreenshotImageFormat = null, Expression<Func<bool>> takeScreenshotUseDisplayDevice = null, Expression<Func<bool>> takeScreenshotRaiseExceptionOnError = null, Expression<Func<bool>> takeScreenshotHideAgent = null, Expression<Func<bool>> takeScreenshotUsePhysicalCoordinates = null, Expression<Func<int>> takeScreenshotDisplayDeviceId = null)
        {
            var apiCallPath = "/Environment/TakeScreenshot";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var takeScreenshot = new JObject();
            var takeScreenshotpropCount = 0;
            if (takeScreenshotFullscreen != null)
            {
                takeScreenshot["Fullscreen"] = ExpressionConverter.ConvertO(takeScreenshotFullscreen);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotLeftXPixels != null)
            {
                takeScreenshot["LeftXPixels"] = ExpressionConverter.ConvertO(takeScreenshotLeftXPixels);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotTopYPixels != null)
            {
                takeScreenshot["TopYPixels"] = ExpressionConverter.ConvertO(takeScreenshotTopYPixels);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotWidthPixels != null)
            {
                takeScreenshot["WidthPixels"] = ExpressionConverter.ConvertO(takeScreenshotWidthPixels);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotHeightPixels != null)
            {
                takeScreenshot["HeightPixels"] = ExpressionConverter.ConvertO(takeScreenshotHeightPixels);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotImageFormat != null)
            {
                takeScreenshot["ImageFormat"] = ExpressionConverter.ConvertO(takeScreenshotImageFormat);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotUseDisplayDevice != null)
            {
                takeScreenshot["UseDisplayDevice"] = ExpressionConverter.ConvertO(takeScreenshotUseDisplayDevice);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotRaiseExceptionOnError != null)
            {
                takeScreenshot["RaiseExceptionOnError"] = ExpressionConverter.ConvertO(takeScreenshotRaiseExceptionOnError);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotHideAgent != null)
            {
                takeScreenshot["HideAgent"] = ExpressionConverter.ConvertO(takeScreenshotHideAgent);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotUsePhysicalCoordinates != null)
            {
                takeScreenshot["UsePhysicalCoordinates"] = ExpressionConverter.ConvertO(takeScreenshotUsePhysicalCoordinates);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotDisplayDeviceId != null)
            {
                takeScreenshot["DisplayDeviceId"] = ExpressionConverter.ConvertO(takeScreenshotDisplayDeviceId);
                takeScreenshotpropCount++;
            }

            takeScreenshotpropCount++;
            takeScreenshot["Workflow"] = ExpressionConverter.ConvertO(takeScreenshotWorkflow);
            if (takeScreenshotpropCount > 0)
            {
                callPayload.Body = takeScreenshot;
            }

            return new ApiConnectionAction<TakeScreenshotResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetEnvironmentInfoResponse> GetEnvironmentInfo(Expression<Func<string>> getEnvironmentInfoWorkflow)
        {
            var apiCallPath = "/Environment/GetEnvironmentInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getEnvironmentInfo = new JObject();
            var getEnvironmentInfopropCount = 0;
            getEnvironmentInfopropCount++;
            getEnvironmentInfo["Workflow"] = ExpressionConverter.ConvertO(getEnvironmentInfoWorkflow);
            if (getEnvironmentInfopropCount > 0)
            {
                callPayload.Body = getEnvironmentInfo;
            }

            return new ApiConnectionAction<GetEnvironmentInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsScreenReaderEnabledResponse> IsScreenReaderEnabled(Expression<Func<string>> isScreenReaderEnabledWorkflow)
        {
            var apiCallPath = "/Environment/IsScreenReaderEnabled";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isScreenReaderEnabled = new JObject();
            var isScreenReaderEnabledpropCount = 0;
            isScreenReaderEnabledpropCount++;
            isScreenReaderEnabled["Workflow"] = ExpressionConverter.ConvertO(isScreenReaderEnabledWorkflow);
            if (isScreenReaderEnabledpropCount > 0)
            {
                callPayload.Body = isScreenReaderEnabled;
            }

            return new ApiConnectionAction<IsScreenReaderEnabledResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetScreenReader(Expression<Func<string>> setScreenReaderWorkflow, Expression<Func<bool>> setScreenReaderEnableScreenReader = null)
        {
            var apiCallPath = "/Environment/SetScreenReader";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setScreenReader = new JObject();
            var setScreenReaderpropCount = 0;
            if (setScreenReaderEnableScreenReader != null)
            {
                setScreenReader["EnableScreenReader"] = ExpressionConverter.ConvertO(setScreenReaderEnableScreenReader);
                setScreenReaderpropCount++;
            }

            setScreenReaderpropCount++;
            setScreenReader["Workflow"] = ExpressionConverter.ConvertO(setScreenReaderWorkflow);
            if (setScreenReaderpropCount > 0)
            {
                callPayload.Body = setScreenReader;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetParentProcessIdResponse> GetParentProcessId(Expression<Func<int>> getParentProcessIdProcessId, Expression<Func<string>> getParentProcessIdWorkflow)
        {
            var apiCallPath = "/Environment/GetParentProcessId";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getParentProcessId = new JObject();
            var getParentProcessIdpropCount = 0;
            getParentProcessIdpropCount++;
            getParentProcessId["ProcessId"] = ExpressionConverter.ConvertO(getParentProcessIdProcessId);
            getParentProcessIdpropCount++;
            getParentProcessId["Workflow"] = ExpressionConverter.ConvertO(getParentProcessIdWorkflow);
            if (getParentProcessIdpropCount > 0)
            {
                callPayload.Body = getParentProcessId;
            }

            return new ApiConnectionAction<GetParentProcessIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessIdCommandLineResponse> GetProcessIdCommandLine(Expression<Func<int>> getProcessIdCommandLineProcessId, Expression<Func<string>> getProcessIdCommandLineWorkflow)
        {
            var apiCallPath = "/Environment/GetProcessIdCommandLine";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getProcessIdCommandLine = new JObject();
            var getProcessIdCommandLinepropCount = 0;
            getProcessIdCommandLinepropCount++;
            getProcessIdCommandLine["ProcessId"] = ExpressionConverter.ConvertO(getProcessIdCommandLineProcessId);
            getProcessIdCommandLinepropCount++;
            getProcessIdCommandLine["Workflow"] = ExpressionConverter.ConvertO(getProcessIdCommandLineWorkflow);
            if (getProcessIdCommandLinepropCount > 0)
            {
                callPayload.Body = getProcessIdCommandLine;
            }

            return new ApiConnectionAction<GetProcessIdCommandLineResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLastInputInfoResponse> GetLastInputInfo(Expression<Func<string>> getLastInputInfoWorkflow)
        {
            var apiCallPath = "/Environment/GetLastInputInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getLastInputInfo = new JObject();
            var getLastInputInfopropCount = 0;
            getLastInputInfopropCount++;
            getLastInputInfo["Workflow"] = ExpressionConverter.ConvertO(getLastInputInfoWorkflow);
            if (getLastInputInfopropCount > 0)
            {
                callPayload.Body = getLastInputInfo;
            }

            return new ApiConnectionAction<GetLastInputInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KeepSessionAliveResponse> KeepSessionAlive(Expression<Func<string>> keepSessionAliveWorkflow, Expression<Func<int>> keepSessionAliveXWiggle = null, Expression<Func<int>> keepSessionAliveYWiggle = null, Expression<Func<double>> keepSessionAliveWiggleDelayInSeconds = null, Expression<Func<int>> keepSessionAliveIdleThresholdInSeconds = null, Expression<Func<int>> keepSessionAliveIdleCheckPeriodInSeconds = null, Expression<Func<int>> keepSessionAliveTotalKeepaliveRuntimeInSeconds = null)
        {
            var apiCallPath = "/Environment/KeepSessionAlive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var keepSessionAlive = new JObject();
            var keepSessionAlivepropCount = 0;
            if (keepSessionAliveXWiggle != null)
            {
                keepSessionAlive["XWiggle"] = ExpressionConverter.ConvertO(keepSessionAliveXWiggle);
                keepSessionAlivepropCount++;
            }

            if (keepSessionAliveYWiggle != null)
            {
                keepSessionAlive["YWiggle"] = ExpressionConverter.ConvertO(keepSessionAliveYWiggle);
                keepSessionAlivepropCount++;
            }

            if (keepSessionAliveWiggleDelayInSeconds != null)
            {
                keepSessionAlive["WiggleDelayInSeconds"] = ExpressionConverter.ConvertO(keepSessionAliveWiggleDelayInSeconds);
                keepSessionAlivepropCount++;
            }

            if (keepSessionAliveIdleThresholdInSeconds != null)
            {
                keepSessionAlive["IdleThresholdInSeconds"] = ExpressionConverter.ConvertO(keepSessionAliveIdleThresholdInSeconds);
                keepSessionAlivepropCount++;
            }

            if (keepSessionAliveIdleCheckPeriodInSeconds != null)
            {
                keepSessionAlive["IdleCheckPeriodInSeconds"] = ExpressionConverter.ConvertO(keepSessionAliveIdleCheckPeriodInSeconds);
                keepSessionAlivepropCount++;
            }

            if (keepSessionAliveTotalKeepaliveRuntimeInSeconds != null)
            {
                keepSessionAlive["TotalKeepaliveRuntimeInSeconds"] = ExpressionConverter.ConvertO(keepSessionAliveTotalKeepaliveRuntimeInSeconds);
                keepSessionAlivepropCount++;
            }

            keepSessionAlivepropCount++;
            keepSessionAlive["Workflow"] = ExpressionConverter.ConvertO(keepSessionAliveWorkflow);
            if (keepSessionAlivepropCount > 0)
            {
                callPayload.Body = keepSessionAlive;
            }

            return new ApiConnectionAction<KeepSessionAliveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<StopKeepSessionAliveResponse> StopKeepSessionAlive(Expression<Func<string>> stopKeepSessionAliveWorkflow)
        {
            var apiCallPath = "/Environment/StopKeepSessionAlive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var stopKeepSessionAlive = new JObject();
            var stopKeepSessionAlivepropCount = 0;
            stopKeepSessionAlivepropCount++;
            stopKeepSessionAlive["Workflow"] = ExpressionConverter.ConvertO(stopKeepSessionAliveWorkflow);
            if (stopKeepSessionAlivepropCount > 0)
            {
                callPayload.Body = stopKeepSessionAlive;
            }

            return new ApiConnectionAction<StopKeepSessionAliveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CopyFileToClipboardResponse> CopyFileToClipboard(Expression<Func<string>> copyFileToClipboardFilepath, Expression<Func<string>> copyFileToClipboardWorkflow, Expression<Func<bool>> copyFileToClipboardCut = null)
        {
            var apiCallPath = "/Environment/CopyFileToClipboard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var copyFileToClipboard = new JObject();
            var copyFileToClipboardpropCount = 0;
            copyFileToClipboardpropCount++;
            copyFileToClipboard["Filepath"] = ExpressionConverter.ConvertO(copyFileToClipboardFilepath);
            if (copyFileToClipboardCut != null)
            {
                copyFileToClipboard["Cut"] = ExpressionConverter.ConvertO(copyFileToClipboardCut);
                copyFileToClipboardpropCount++;
            }

            copyFileToClipboardpropCount++;
            copyFileToClipboard["Workflow"] = ExpressionConverter.ConvertO(copyFileToClipboardWorkflow);
            if (copyFileToClipboardpropCount > 0)
            {
                callPayload.Body = copyFileToClipboard;
            }

            return new ApiConnectionAction<CopyFileToClipboardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteSessionInfoResponse> GetRemoteSessionInfo(Expression<Func<string>> getRemoteSessionInfoWorkflow)
        {
            var apiCallPath = "/Environment/GetRemoteSessionInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRemoteSessionInfo = new JObject();
            var getRemoteSessionInfopropCount = 0;
            getRemoteSessionInfopropCount++;
            getRemoteSessionInfo["Workflow"] = ExpressionConverter.ConvertO(getRemoteSessionInfoWorkflow);
            if (getRemoteSessionInfopropCount > 0)
            {
                callPayload.Body = getRemoteSessionInfo;
            }

            return new ApiConnectionAction<GetRemoteSessionInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GeneratePasswordResponse> GeneratePassword(Expression<Func<string>> generatePasswordPasswordFormat, Expression<Func<string>> generatePasswordWorkflow, Expression<Func<int>> generatePasswordMinimumLength = null, Expression<Func<bool>> generatePasswordReturnAsPlainText = null, Expression<Func<string>> generatePasswordStorePasswordAsIdentifier = null, Expression<Func<string>> generatePasswordSupportedSymbols = null, Expression<Func<bool>> generatePasswordAttemptUniquePasswords = null, Expression<Func<generatePasswordGenerateAtInput>> generatePasswordGenerateAt = null, Expression<Func<int>> generatePasswordMinimumLowercase = null, Expression<Func<int>> generatePasswordMinimumUppercase = null, Expression<Func<int>> generatePasswordMinimumNumbers = null, Expression<Func<int>> generatePasswordMinimumSymbols = null)
        {
            var apiCallPath = "/Environment/GeneratePassword";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var generatePassword = new JObject();
            var generatePasswordpropCount = 0;
            generatePasswordpropCount++;
            generatePassword["PasswordFormat"] = ExpressionConverter.ConvertO(generatePasswordPasswordFormat);
            if (generatePasswordMinimumLength != null)
            {
                generatePassword["MinimumLength"] = ExpressionConverter.ConvertO(generatePasswordMinimumLength);
                generatePasswordpropCount++;
            }

            if (generatePasswordReturnAsPlainText != null)
            {
                generatePassword["ReturnAsPlainText"] = ExpressionConverter.ConvertO(generatePasswordReturnAsPlainText);
                generatePasswordpropCount++;
            }

            if (generatePasswordStorePasswordAsIdentifier != null)
            {
                generatePassword["StorePasswordAsIdentifier"] = ExpressionConverter.ConvertO(generatePasswordStorePasswordAsIdentifier);
                generatePasswordpropCount++;
            }

            if (generatePasswordSupportedSymbols != null)
            {
                generatePassword["SupportedSymbols"] = ExpressionConverter.ConvertO(generatePasswordSupportedSymbols);
                generatePasswordpropCount++;
            }

            if (generatePasswordAttemptUniquePasswords != null)
            {
                generatePassword["AttemptUniquePasswords"] = ExpressionConverter.ConvertO(generatePasswordAttemptUniquePasswords);
                generatePasswordpropCount++;
            }

            if (generatePasswordGenerateAt != null)
            {
                generatePassword["GenerateAt"] = ExpressionConverter.ConvertO(generatePasswordGenerateAt);
                generatePasswordpropCount++;
            }

            if (generatePasswordMinimumLowercase != null)
            {
                generatePassword["MinimumLowercase"] = ExpressionConverter.ConvertO(generatePasswordMinimumLowercase);
                generatePasswordpropCount++;
            }

            if (generatePasswordMinimumUppercase != null)
            {
                generatePassword["MinimumUppercase"] = ExpressionConverter.ConvertO(generatePasswordMinimumUppercase);
                generatePasswordpropCount++;
            }

            if (generatePasswordMinimumNumbers != null)
            {
                generatePassword["MinimumNumbers"] = ExpressionConverter.ConvertO(generatePasswordMinimumNumbers);
                generatePasswordpropCount++;
            }

            if (generatePasswordMinimumSymbols != null)
            {
                generatePassword["MinimumSymbols"] = ExpressionConverter.ConvertO(generatePasswordMinimumSymbols);
                generatePasswordpropCount++;
            }

            generatePasswordpropCount++;
            generatePassword["Workflow"] = ExpressionConverter.ConvertO(generatePasswordWorkflow);
            if (generatePasswordpropCount > 0)
            {
                callPayload.Body = generatePassword;
            }

            return new ApiConnectionAction<GeneratePasswordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetStoredPasswordResponse> GetStoredPassword(Expression<Func<string>> getStoredPasswordWorkflow, Expression<Func<string>> getStoredPasswordPasswordIdentifier = null)
        {
            var apiCallPath = "/Environment/GetStoredPassword";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getStoredPassword = new JObject();
            var getStoredPasswordpropCount = 0;
            if (getStoredPasswordPasswordIdentifier != null)
            {
                getStoredPassword["PasswordIdentifier"] = ExpressionConverter.ConvertO(getStoredPasswordPasswordIdentifier);
                getStoredPasswordpropCount++;
            }

            getStoredPasswordpropCount++;
            getStoredPassword["Workflow"] = ExpressionConverter.ConvertO(getStoredPasswordWorkflow);
            if (getStoredPasswordpropCount > 0)
            {
                callPayload.Body = getStoredPassword;
            }

            return new ApiConnectionAction<GetStoredPasswordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ExpandPasswordStringResponse> ExpandPasswordString(Expression<Func<string>> expandPasswordStringWorkflow, Expression<Func<string>> expandPasswordStringInputString = null)
        {
            var apiCallPath = "/Environment/ExpandPasswordString";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var expandPasswordString = new JObject();
            var expandPasswordStringpropCount = 0;
            if (expandPasswordStringInputString != null)
            {
                expandPasswordString["InputString"] = ExpressionConverter.ConvertO(expandPasswordStringInputString);
                expandPasswordStringpropCount++;
            }

            expandPasswordStringpropCount++;
            expandPasswordString["Workflow"] = ExpressionConverter.ConvertO(expandPasswordStringWorkflow);
            if (expandPasswordStringpropCount > 0)
            {
                callPayload.Body = expandPasswordString;
            }

            return new ApiConnectionAction<ExpandPasswordStringResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<StorePasswordInAgentMemoryResponse> StorePasswordInAgentMemory(Expression<Func<string>> storePasswordInAgentMemoryIdentifier, Expression<Func<string>> storePasswordInAgentMemoryPassword, Expression<Func<string>> storePasswordInAgentMemoryWorkflow)
        {
            var apiCallPath = "/Environment/StorePasswordInAgentMemory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var storePasswordInAgentMemory = new JObject();
            var storePasswordInAgentMemorypropCount = 0;
            storePasswordInAgentMemorypropCount++;
            storePasswordInAgentMemory["Identifier"] = ExpressionConverter.ConvertO(storePasswordInAgentMemoryIdentifier);
            storePasswordInAgentMemorypropCount++;
            storePasswordInAgentMemory["Password"] = ExpressionConverter.ConvertO(storePasswordInAgentMemoryPassword);
            storePasswordInAgentMemorypropCount++;
            storePasswordInAgentMemory["Workflow"] = ExpressionConverter.ConvertO(storePasswordInAgentMemoryWorkflow);
            if (storePasswordInAgentMemorypropCount > 0)
            {
                callPayload.Body = storePasswordInAgentMemory;
            }

            return new ApiConnectionAction<StorePasswordInAgentMemoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeletePasswordInAgentMemoryResponse> DeletePasswordInAgentMemory(Expression<Func<string>> deletePasswordInAgentMemoryWorkflow, Expression<Func<bool>> deletePasswordInAgentMemoryDeleteAllPasswords = null, Expression<Func<string>> deletePasswordInAgentMemoryIdentifier = null)
        {
            var apiCallPath = "/Environment/DeletePasswordInAgentMemory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deletePasswordInAgentMemory = new JObject();
            var deletePasswordInAgentMemorypropCount = 0;
            if (deletePasswordInAgentMemoryDeleteAllPasswords != null)
            {
                deletePasswordInAgentMemory["DeleteAllPasswords"] = ExpressionConverter.ConvertO(deletePasswordInAgentMemoryDeleteAllPasswords);
                deletePasswordInAgentMemorypropCount++;
            }

            if (deletePasswordInAgentMemoryIdentifier != null)
            {
                deletePasswordInAgentMemory["Identifier"] = ExpressionConverter.ConvertO(deletePasswordInAgentMemoryIdentifier);
                deletePasswordInAgentMemorypropCount++;
            }

            deletePasswordInAgentMemorypropCount++;
            deletePasswordInAgentMemory["Workflow"] = ExpressionConverter.ConvertO(deletePasswordInAgentMemoryWorkflow);
            if (deletePasswordInAgentMemorypropCount > 0)
            {
                callPayload.Body = deletePasswordInAgentMemory;
            }

            return new ApiConnectionAction<DeletePasswordInAgentMemoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialWriteResponse> CredentialWrite(Expression<Func<string>> credentialWriteCredentialAddress, Expression<Func<string>> credentialWriteUserName, Expression<Func<string>> credentialWritePassword, Expression<Func<credentialWriteCredentialTypeInput>> credentialWriteCredentialType, Expression<Func<string>> credentialWriteWorkflow, Expression<Func<credentialWriteCredentialPersistenceInput>> credentialWriteCredentialPersistence = null, Expression<Func<string>> credentialWriteSymmetricKey = null, Expression<Func<string>> credentialWriteStorePasswordAsIdentifier = null)
        {
            var apiCallPath = "/Environment/CredentialWrite";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var credentialWrite = new JObject();
            var credentialWritepropCount = 0;
            credentialWritepropCount++;
            credentialWrite["CredentialAddress"] = ExpressionConverter.ConvertO(credentialWriteCredentialAddress);
            credentialWritepropCount++;
            credentialWrite["UserName"] = ExpressionConverter.ConvertO(credentialWriteUserName);
            credentialWritepropCount++;
            credentialWrite["Password"] = ExpressionConverter.ConvertO(credentialWritePassword);
            credentialWritepropCount++;
            credentialWrite["CredentialType"] = ExpressionConverter.ConvertO(credentialWriteCredentialType);
            if (credentialWriteCredentialPersistence != null)
            {
                credentialWrite["CredentialPersistence"] = ExpressionConverter.ConvertO(credentialWriteCredentialPersistence);
                credentialWritepropCount++;
            }

            if (credentialWriteSymmetricKey != null)
            {
                credentialWrite["SymmetricKey"] = ExpressionConverter.ConvertO(credentialWriteSymmetricKey);
                credentialWritepropCount++;
            }

            if (credentialWriteStorePasswordAsIdentifier != null)
            {
                credentialWrite["StorePasswordAsIdentifier"] = ExpressionConverter.ConvertO(credentialWriteStorePasswordAsIdentifier);
                credentialWritepropCount++;
            }

            credentialWritepropCount++;
            credentialWrite["Workflow"] = ExpressionConverter.ConvertO(credentialWriteWorkflow);
            if (credentialWritepropCount > 0)
            {
                callPayload.Body = credentialWrite;
            }

            return new ApiConnectionAction<CredentialWriteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialReadResponse> CredentialRead(Expression<Func<string>> credentialReadCredentialAddress, Expression<Func<credentialReadCredentialTypeInput>> credentialReadCredentialType, Expression<Func<string>> credentialReadWorkflow, Expression<Func<string>> credentialReadSymmetricKey = null, Expression<Func<string>> credentialReadStorePasswordAsIdentifier = null, Expression<Func<bool>> credentialReadDontReturnPassword = null)
        {
            var apiCallPath = "/Environment/CredentialRead";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var credentialRead = new JObject();
            var credentialReadpropCount = 0;
            credentialReadpropCount++;
            credentialRead["CredentialAddress"] = ExpressionConverter.ConvertO(credentialReadCredentialAddress);
            credentialReadpropCount++;
            credentialRead["CredentialType"] = ExpressionConverter.ConvertO(credentialReadCredentialType);
            if (credentialReadSymmetricKey != null)
            {
                credentialRead["SymmetricKey"] = ExpressionConverter.ConvertO(credentialReadSymmetricKey);
                credentialReadpropCount++;
            }

            if (credentialReadStorePasswordAsIdentifier != null)
            {
                credentialRead["StorePasswordAsIdentifier"] = ExpressionConverter.ConvertO(credentialReadStorePasswordAsIdentifier);
                credentialReadpropCount++;
            }

            if (credentialReadDontReturnPassword != null)
            {
                credentialRead["DontReturnPassword"] = ExpressionConverter.ConvertO(credentialReadDontReturnPassword);
                credentialReadpropCount++;
            }

            credentialReadpropCount++;
            credentialRead["Workflow"] = ExpressionConverter.ConvertO(credentialReadWorkflow);
            if (credentialReadpropCount > 0)
            {
                callPayload.Body = credentialRead;
            }

            return new ApiConnectionAction<CredentialReadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialDeleteResponse> CredentialDelete(Expression<Func<string>> credentialDeleteCredentialAddress, Expression<Func<credentialDeleteCredentialTypeInput>> credentialDeleteCredentialType, Expression<Func<string>> credentialDeleteWorkflow)
        {
            var apiCallPath = "/Environment/CredentialDelete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var credentialDelete = new JObject();
            var credentialDeletepropCount = 0;
            credentialDeletepropCount++;
            credentialDelete["CredentialAddress"] = ExpressionConverter.ConvertO(credentialDeleteCredentialAddress);
            credentialDeletepropCount++;
            credentialDelete["CredentialType"] = ExpressionConverter.ConvertO(credentialDeleteCredentialType);
            credentialDeletepropCount++;
            credentialDelete["Workflow"] = ExpressionConverter.ConvertO(credentialDeleteWorkflow);
            if (credentialDeletepropCount > 0)
            {
                callPayload.Body = credentialDelete;
            }

            return new ApiConnectionAction<CredentialDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GenerateRDPFileResponse> GenerateRDPFile(Expression<Func<string>> generateRDPFileRemoteAddress, Expression<Func<string>> generateRDPFileOutputFolderPath, Expression<Func<string>> generateRDPFileRDPFileName, Expression<Func<string>> generateRDPFileWorkflow, Expression<Func<bool>> generateRDPFileOverwriteRDPFileIfAlreadyExists = null, Expression<Func<bool>> generateRDPFileTrustRemoteComputer = null, Expression<Func<bool>> generateRDPFileStoreCredentials = null, Expression<Func<string>> generateRDPFileUserName = null, Expression<Func<string>> generateRDPFilePassword = null, Expression<Func<generateRDPFileCredentialTypeInput>> generateRDPFileCredentialType = null, Expression<Func<generateRDPFileCredentialPersistenceInput>> generateRDPFileCredentialPersistence = null, Expression<Func<bool>> generateRDPFileRedirectPrinters = null, Expression<Func<bool>> generateRDPFileRedirectAllDrives = null, Expression<Func<bool>> generateRDPFileRedirectClipboard = null, Expression<Func<bool>> generateRDPFileFullscreen = null, Expression<Func<int>> generateRDPFileDesktopWidth = null, Expression<Func<int>> generateRDPFileDesktopHeight = null, Expression<Func<bool>> generateRDPFileUseMultiMonitor = null, Expression<Func<int>> generateRDPFileSessionBPP = null, Expression<Func<bool>> generateRDPFileSmartSizing = null)
        {
            var apiCallPath = "/Environment/GenerateRDPFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var generateRDPFile = new JObject();
            var generateRDPFilepropCount = 0;
            generateRDPFilepropCount++;
            generateRDPFile["RemoteAddress"] = ExpressionConverter.ConvertO(generateRDPFileRemoteAddress);
            generateRDPFilepropCount++;
            generateRDPFile["OutputFolderPath"] = ExpressionConverter.ConvertO(generateRDPFileOutputFolderPath);
            generateRDPFilepropCount++;
            generateRDPFile["RDPFileName"] = ExpressionConverter.ConvertO(generateRDPFileRDPFileName);
            if (generateRDPFileOverwriteRDPFileIfAlreadyExists != null)
            {
                generateRDPFile["OverwriteRDPFileIfAlreadyExists"] = ExpressionConverter.ConvertO(generateRDPFileOverwriteRDPFileIfAlreadyExists);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileTrustRemoteComputer != null)
            {
                generateRDPFile["TrustRemoteComputer"] = ExpressionConverter.ConvertO(generateRDPFileTrustRemoteComputer);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileStoreCredentials != null)
            {
                generateRDPFile["StoreCredentials"] = ExpressionConverter.ConvertO(generateRDPFileStoreCredentials);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileUserName != null)
            {
                generateRDPFile["UserName"] = ExpressionConverter.ConvertO(generateRDPFileUserName);
                generateRDPFilepropCount++;
            }

            if (generateRDPFilePassword != null)
            {
                generateRDPFile["Password"] = ExpressionConverter.ConvertO(generateRDPFilePassword);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileCredentialType != null)
            {
                generateRDPFile["CredentialType"] = ExpressionConverter.ConvertO(generateRDPFileCredentialType);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileCredentialPersistence != null)
            {
                generateRDPFile["CredentialPersistence"] = ExpressionConverter.ConvertO(generateRDPFileCredentialPersistence);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileRedirectPrinters != null)
            {
                generateRDPFile["RedirectPrinters"] = ExpressionConverter.ConvertO(generateRDPFileRedirectPrinters);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileRedirectAllDrives != null)
            {
                generateRDPFile["RedirectAllDrives"] = ExpressionConverter.ConvertO(generateRDPFileRedirectAllDrives);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileRedirectClipboard != null)
            {
                generateRDPFile["RedirectClipboard"] = ExpressionConverter.ConvertO(generateRDPFileRedirectClipboard);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileFullscreen != null)
            {
                generateRDPFile["Fullscreen"] = ExpressionConverter.ConvertO(generateRDPFileFullscreen);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileDesktopWidth != null)
            {
                generateRDPFile["DesktopWidth"] = ExpressionConverter.ConvertO(generateRDPFileDesktopWidth);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileDesktopHeight != null)
            {
                generateRDPFile["DesktopHeight"] = ExpressionConverter.ConvertO(generateRDPFileDesktopHeight);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileUseMultiMonitor != null)
            {
                generateRDPFile["UseMultiMonitor"] = ExpressionConverter.ConvertO(generateRDPFileUseMultiMonitor);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileSessionBPP != null)
            {
                generateRDPFile["SessionBPP"] = ExpressionConverter.ConvertO(generateRDPFileSessionBPP);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileSmartSizing != null)
            {
                generateRDPFile["SmartSizing"] = ExpressionConverter.ConvertO(generateRDPFileSmartSizing);
                generateRDPFilepropCount++;
            }

            generateRDPFilepropCount++;
            generateRDPFile["Workflow"] = ExpressionConverter.ConvertO(generateRDPFileWorkflow);
            if (generateRDPFilepropCount > 0)
            {
                callPayload.Body = generateRDPFile;
            }

            return new ApiConnectionAction<GenerateRDPFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<LaunchRemoteDesktopSessionResponse> LaunchRemoteDesktopSession(Expression<Func<string>> launchRemoteDesktopSessionRDPFilePath, Expression<Func<string>> launchRemoteDesktopSessionWorkflow, Expression<Func<bool>> launchRemoteDesktopSessionTrustRemoteComputer = null)
        {
            var apiCallPath = "/Environment/LaunchRemoteDesktopSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var launchRemoteDesktopSession = new JObject();
            var launchRemoteDesktopSessionpropCount = 0;
            launchRemoteDesktopSessionpropCount++;
            launchRemoteDesktopSession["RDPFilePath"] = ExpressionConverter.ConvertO(launchRemoteDesktopSessionRDPFilePath);
            if (launchRemoteDesktopSessionTrustRemoteComputer != null)
            {
                launchRemoteDesktopSession["TrustRemoteComputer"] = ExpressionConverter.ConvertO(launchRemoteDesktopSessionTrustRemoteComputer);
                launchRemoteDesktopSessionpropCount++;
            }

            launchRemoteDesktopSessionpropCount++;
            launchRemoteDesktopSession["Workflow"] = ExpressionConverter.ConvertO(launchRemoteDesktopSessionWorkflow);
            if (launchRemoteDesktopSessionpropCount > 0)
            {
                callPayload.Body = launchRemoteDesktopSession;
            }

            return new ApiConnectionAction<LaunchRemoteDesktopSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsTCPPortRespondingResponse> IsTCPPortResponding(Expression<Func<string>> isTCPPortRespondingRemoteHost, Expression<Func<int>> isTCPPortRespondingTCPPort, Expression<Func<string>> isTCPPortRespondingWorkflow, Expression<Func<int>> isTCPPortRespondingTimeoutInSeconds = null)
        {
            var apiCallPath = "/Environment/IsTCPPortResponding";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isTCPPortResponding = new JObject();
            var isTCPPortRespondingpropCount = 0;
            isTCPPortRespondingpropCount++;
            isTCPPortResponding["RemoteHost"] = ExpressionConverter.ConvertO(isTCPPortRespondingRemoteHost);
            isTCPPortRespondingpropCount++;
            isTCPPortResponding["TCPPort"] = ExpressionConverter.ConvertO(isTCPPortRespondingTCPPort);
            if (isTCPPortRespondingTimeoutInSeconds != null)
            {
                isTCPPortResponding["TimeoutInSeconds"] = ExpressionConverter.ConvertO(isTCPPortRespondingTimeoutInSeconds);
                isTCPPortRespondingpropCount++;
            }

            isTCPPortRespondingpropCount++;
            isTCPPortResponding["Workflow"] = ExpressionConverter.ConvertO(isTCPPortRespondingWorkflow);
            if (isTCPPortRespondingpropCount > 0)
            {
                callPayload.Body = isTCPPortResponding;
            }

            return new ApiConnectionAction<IsTCPPortRespondingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UnlockSessionResponse> UnlockSession(Expression<Func<string>> unlockSessionUnlockPassword, Expression<Func<bool>> unlockSessionDetectIfLocked, Expression<Func<bool>> unlockSessionDetectCredentialProvider, Expression<Func<string>> unlockSessionWorkflow, Expression<Func<bool>> unlockSessionPasswordContainsStoredPassword = null, Expression<Func<int>> unlockSessionSecondsToWaitForUnlock = null)
        {
            var apiCallPath = "/Environment/UnlockSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var unlockSession = new JObject();
            var unlockSessionpropCount = 0;
            unlockSessionpropCount++;
            unlockSession["UnlockPassword"] = ExpressionConverter.ConvertO(unlockSessionUnlockPassword);
            if (unlockSessionPasswordContainsStoredPassword != null)
            {
                unlockSession["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(unlockSessionPasswordContainsStoredPassword);
                unlockSessionpropCount++;
            }

            unlockSessionpropCount++;
            unlockSession["DetectIfLocked"] = ExpressionConverter.ConvertO(unlockSessionDetectIfLocked);
            unlockSessionpropCount++;
            unlockSession["DetectCredentialProvider"] = ExpressionConverter.ConvertO(unlockSessionDetectCredentialProvider);
            if (unlockSessionSecondsToWaitForUnlock != null)
            {
                unlockSession["SecondsToWaitForUnlock"] = ExpressionConverter.ConvertO(unlockSessionSecondsToWaitForUnlock);
                unlockSessionpropCount++;
            }

            unlockSessionpropCount++;
            unlockSession["Workflow"] = ExpressionConverter.ConvertO(unlockSessionWorkflow);
            if (unlockSessionpropCount > 0)
            {
                callPayload.Body = unlockSession;
            }

            return new ApiConnectionAction<UnlockSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<LockSessionResponse> LockSession(Expression<Func<string>> lockSessionWorkflow, Expression<Func<int>> lockSessionLockAfterMinutesOfActionInactivity = null, Expression<Func<int>> lockSessionSecondsToWaitAfterLock = null)
        {
            var apiCallPath = "/Environment/LockSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var lockSession = new JObject();
            var lockSessionpropCount = 0;
            if (lockSessionLockAfterMinutesOfActionInactivity != null)
            {
                lockSession["LockAfterMinutesOfActionInactivity"] = ExpressionConverter.ConvertO(lockSessionLockAfterMinutesOfActionInactivity);
                lockSessionpropCount++;
            }

            if (lockSessionSecondsToWaitAfterLock != null)
            {
                lockSession["SecondsToWaitAfterLock"] = ExpressionConverter.ConvertO(lockSessionSecondsToWaitAfterLock);
                lockSessionpropCount++;
            }

            lockSessionpropCount++;
            lockSession["Workflow"] = ExpressionConverter.ConvertO(lockSessionWorkflow);
            if (lockSessionpropCount > 0)
            {
                callPayload.Body = lockSession;
            }

            return new ApiConnectionAction<LockSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsSessionLockedResponse> IsSessionLocked(Expression<Func<string>> isSessionLockedWorkflow)
        {
            var apiCallPath = "/Environment/IsSessionLocked";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isSessionLocked = new JObject();
            var isSessionLockedpropCount = 0;
            isSessionLockedpropCount++;
            isSessionLocked["Workflow"] = ExpressionConverter.ConvertO(isSessionLockedWorkflow);
            if (isSessionLockedpropCount > 0)
            {
                callPayload.Body = isSessionLocked;
            }

            return new ApiConnectionAction<IsSessionLockedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetGenericCredentialFromOrchestratorResponse> GetGenericCredentialFromOrchestrator(Expression<Func<string>> getGenericCredentialFromOrchestratorFriendlyName = null, Expression<Func<bool>> getGenericCredentialFromOrchestratorRetrievePlainTextPassword = null)
        {
            var apiCallPath = "/Environment/GetGenericCredentialFromOrchestrator";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getGenericCredentialFromOrchestrator = new JObject();
            var getGenericCredentialFromOrchestratorpropCount = 0;
            if (getGenericCredentialFromOrchestratorFriendlyName != null)
            {
                getGenericCredentialFromOrchestrator["FriendlyName"] = ExpressionConverter.ConvertO(getGenericCredentialFromOrchestratorFriendlyName);
                getGenericCredentialFromOrchestratorpropCount++;
            }

            if (getGenericCredentialFromOrchestratorRetrievePlainTextPassword != null)
            {
                getGenericCredentialFromOrchestrator["RetrievePlainTextPassword"] = ExpressionConverter.ConvertO(getGenericCredentialFromOrchestratorRetrievePlainTextPassword);
                getGenericCredentialFromOrchestratorpropCount++;
            }

            if (getGenericCredentialFromOrchestratorpropCount > 0)
            {
                callPayload.Body = getGenericCredentialFromOrchestrator;
            }

            return new ApiConnectionAction<GetGenericCredentialFromOrchestratorResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DrawRectangleOnScreenResponse> DrawRectangleOnScreen(Expression<Func<int>> drawRectangleOnScreenRectangleLeftPixelXCoord, Expression<Func<int>> drawRectangleOnScreenRectangleRightPixelXCoord, Expression<Func<int>> drawRectangleOnScreenRectangleTopPixelYCoord, Expression<Func<int>> drawRectangleOnScreenRectangleBottomPixelYCoord, Expression<Func<string>> drawRectangleOnScreenWorkflow, Expression<Func<string>> drawRectangleOnScreenPenColour = null, Expression<Func<int>> drawRectangleOnScreenPenThicknessPixels = null, Expression<Func<int>> drawRectangleOnScreenSecondsToDisplay = null, Expression<Func<bool>> drawRectangleOnScreenCoordinatesArePhysical = null)
        {
            var apiCallPath = "/Environment/DrawRectangleOnScreen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var drawRectangleOnScreen = new JObject();
            var drawRectangleOnScreenpropCount = 0;
            drawRectangleOnScreenpropCount++;
            drawRectangleOnScreen["RectangleLeftPixelXCoord"] = ExpressionConverter.ConvertO(drawRectangleOnScreenRectangleLeftPixelXCoord);
            drawRectangleOnScreenpropCount++;
            drawRectangleOnScreen["RectangleRightPixelXCoord"] = ExpressionConverter.ConvertO(drawRectangleOnScreenRectangleRightPixelXCoord);
            drawRectangleOnScreenpropCount++;
            drawRectangleOnScreen["RectangleTopPixelYCoord"] = ExpressionConverter.ConvertO(drawRectangleOnScreenRectangleTopPixelYCoord);
            drawRectangleOnScreenpropCount++;
            drawRectangleOnScreen["RectangleBottomPixelYCoord"] = ExpressionConverter.ConvertO(drawRectangleOnScreenRectangleBottomPixelYCoord);
            if (drawRectangleOnScreenPenColour != null)
            {
                drawRectangleOnScreen["PenColour"] = ExpressionConverter.ConvertO(drawRectangleOnScreenPenColour);
                drawRectangleOnScreenpropCount++;
            }

            if (drawRectangleOnScreenPenThicknessPixels != null)
            {
                drawRectangleOnScreen["PenThicknessPixels"] = ExpressionConverter.ConvertO(drawRectangleOnScreenPenThicknessPixels);
                drawRectangleOnScreenpropCount++;
            }

            if (drawRectangleOnScreenSecondsToDisplay != null)
            {
                drawRectangleOnScreen["SecondsToDisplay"] = ExpressionConverter.ConvertO(drawRectangleOnScreenSecondsToDisplay);
                drawRectangleOnScreenpropCount++;
            }

            if (drawRectangleOnScreenCoordinatesArePhysical != null)
            {
                drawRectangleOnScreen["CoordinatesArePhysical"] = ExpressionConverter.ConvertO(drawRectangleOnScreenCoordinatesArePhysical);
                drawRectangleOnScreenpropCount++;
            }

            drawRectangleOnScreenpropCount++;
            drawRectangleOnScreen["Workflow"] = ExpressionConverter.ConvertO(drawRectangleOnScreenWorkflow);
            if (drawRectangleOnScreenpropCount > 0)
            {
                callPayload.Body = drawRectangleOnScreen;
            }

            return new ApiConnectionAction<DrawRectangleOnScreenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFailedActionErrorMessageFromPowerAutomateResultJSONResponse> GetFailedActionErrorMessageFromPowerAutomateResultJSON(Expression<Func<string[]>> getFailedActionErrorMessageFromPowerAutomateResultJSONPowerAutomateResultJSON, Expression<Func<string>> getFailedActionErrorMessageFromPowerAutomateResultJSONSearchStatus = null)
        {
            var apiCallPath = "/Environment/GetFailedActionErrorMessageFromPowerAutomateResultJSON";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getFailedActionErrorMessageFromPowerAutomateResultJSON = new JObject();
            var getFailedActionErrorMessageFromPowerAutomateResultJSONpropCount = 0;
            getFailedActionErrorMessageFromPowerAutomateResultJSONpropCount++;
            getFailedActionErrorMessageFromPowerAutomateResultJSON["PowerAutomateResultJSON"] = ExpressionConverter.ConvertO(getFailedActionErrorMessageFromPowerAutomateResultJSONPowerAutomateResultJSON);
            if (getFailedActionErrorMessageFromPowerAutomateResultJSONSearchStatus != null)
            {
                getFailedActionErrorMessageFromPowerAutomateResultJSON["SearchStatus"] = ExpressionConverter.ConvertO(getFailedActionErrorMessageFromPowerAutomateResultJSONSearchStatus);
                getFailedActionErrorMessageFromPowerAutomateResultJSONpropCount++;
            }

            if (getFailedActionErrorMessageFromPowerAutomateResultJSONpropCount > 0)
            {
                callPayload.Body = getFailedActionErrorMessageFromPowerAutomateResultJSON;
            }

            return new ApiConnectionAction<GetFailedActionErrorMessageFromPowerAutomateResultJSONResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetPixelColourAtCoordinateResponse> GetPixelColourAtCoordinate(Expression<Func<int>> getPixelColourAtCoordinateLeftXPixels, Expression<Func<int>> getPixelColourAtCoordinateTopYPixels, Expression<Func<string>> getPixelColourAtCoordinateWorkflow, Expression<Func<bool>> getPixelColourAtCoordinateHideAgent = null, Expression<Func<bool>> getPixelColourAtCoordinateUsePhysicalCoordinates = null)
        {
            var apiCallPath = "/Environment/GetPixelColourAtCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getPixelColourAtCoordinate = new JObject();
            var getPixelColourAtCoordinatepropCount = 0;
            getPixelColourAtCoordinatepropCount++;
            getPixelColourAtCoordinate["LeftXPixels"] = ExpressionConverter.ConvertO(getPixelColourAtCoordinateLeftXPixels);
            getPixelColourAtCoordinatepropCount++;
            getPixelColourAtCoordinate["TopYPixels"] = ExpressionConverter.ConvertO(getPixelColourAtCoordinateTopYPixels);
            if (getPixelColourAtCoordinateHideAgent != null)
            {
                getPixelColourAtCoordinate["HideAgent"] = ExpressionConverter.ConvertO(getPixelColourAtCoordinateHideAgent);
                getPixelColourAtCoordinatepropCount++;
            }

            if (getPixelColourAtCoordinateUsePhysicalCoordinates != null)
            {
                getPixelColourAtCoordinate["UsePhysicalCoordinates"] = ExpressionConverter.ConvertO(getPixelColourAtCoordinateUsePhysicalCoordinates);
                getPixelColourAtCoordinatepropCount++;
            }

            getPixelColourAtCoordinatepropCount++;
            getPixelColourAtCoordinate["Workflow"] = ExpressionConverter.ConvertO(getPixelColourAtCoordinateWorkflow);
            if (getPixelColourAtCoordinatepropCount > 0)
            {
                callPayload.Body = getPixelColourAtCoordinate;
            }

            return new ApiConnectionAction<GetPixelColourAtCoordinateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ConvertRectangleCoordinatesResponse> ConvertRectangleCoordinates(Expression<Func<int>> convertRectangleCoordinatesRectangleLeftPixelXCoord, Expression<Func<int>> convertRectangleCoordinatesRectangleTopPixelYCoord, Expression<Func<int>> convertRectangleCoordinatesRectangleRightPixelXCoord, Expression<Func<int>> convertRectangleCoordinatesRectangleBottomPixelYCoord, Expression<Func<convertRectangleCoordinatesConversionTypeInput>> convertRectangleCoordinatesConversionType, Expression<Func<string>> convertRectangleCoordinatesWorkflow)
        {
            var apiCallPath = "/Environment/ConvertRectangleCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var convertRectangleCoordinates = new JObject();
            var convertRectangleCoordinatespropCount = 0;
            convertRectangleCoordinatespropCount++;
            convertRectangleCoordinates["RectangleLeftPixelXCoord"] = ExpressionConverter.ConvertO(convertRectangleCoordinatesRectangleLeftPixelXCoord);
            convertRectangleCoordinatespropCount++;
            convertRectangleCoordinates["RectangleTopPixelYCoord"] = ExpressionConverter.ConvertO(convertRectangleCoordinatesRectangleTopPixelYCoord);
            convertRectangleCoordinatespropCount++;
            convertRectangleCoordinates["RectangleRightPixelXCoord"] = ExpressionConverter.ConvertO(convertRectangleCoordinatesRectangleRightPixelXCoord);
            convertRectangleCoordinatespropCount++;
            convertRectangleCoordinates["RectangleBottomPixelYCoord"] = ExpressionConverter.ConvertO(convertRectangleCoordinatesRectangleBottomPixelYCoord);
            convertRectangleCoordinatespropCount++;
            convertRectangleCoordinates["ConversionType"] = ExpressionConverter.ConvertO(convertRectangleCoordinatesConversionType);
            convertRectangleCoordinatespropCount++;
            convertRectangleCoordinates["Workflow"] = ExpressionConverter.ConvertO(convertRectangleCoordinatesWorkflow);
            if (convertRectangleCoordinatespropCount > 0)
            {
                callPayload.Body = convertRectangleCoordinates;
            }

            return new ApiConnectionAction<ConvertRectangleCoordinatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SendMessageToWebAPIResponse> SendMessageToWebAPI(Expression<Func<string>> sendMessageToWebAPIWorkflow, Expression<Func<string>> sendMessageToWebAPIURL = null, Expression<Func<sendMessageToWebAPIMethodInput>> sendMessageToWebAPIMethod = null, Expression<Func<int>> sendMessageToWebAPITimeoutInSeconds = null, Expression<Func<string>> sendMessageToWebAPIContentType = null, Expression<Func<string>> sendMessageToWebAPIAccept = null, Expression<Func<string>> sendMessageToWebAPIMessageBody = null, Expression<Func<sendMessageToWebAPITransmitEncodingInput>> sendMessageToWebAPITransmitEncoding = null, Expression<Func<sendMessageToWebAPIResponseEncodingInput>> sendMessageToWebAPIResponseEncoding = null, Expression<Func<int>> sendMessageToWebAPIBufferSize = null, Expression<Func<sendMessageToWebAPIHTTPRequestHeadersListInputItem[]>> sendMessageToWebAPIHTTPRequestHeadersList = null, Expression<Func<bool>> sendMessageToWebAPINegotiateTLS10 = null, Expression<Func<bool>> sendMessageToWebAPINegotiateTLS11 = null, Expression<Func<bool>> sendMessageToWebAPINegotiateTLS12 = null, Expression<Func<bool>> sendMessageToWebAPINegotiateTLS13 = null, Expression<Func<bool>> sendMessageToWebAPIKeepAlive = null, Expression<Func<bool>> sendMessageToWebAPIExpect100Continue = null, Expression<Func<bool>> sendMessageToWebAPIReturnResponseHeaders = null, Expression<Func<bool>> sendMessageToWebAPIRunAsThread = null, Expression<Func<bool>> sendMessageToWebAPIWaitForThread = null, Expression<Func<int>> sendMessageToWebAPIRetrieveOutputDataFromThreadId = null)
        {
            var apiCallPath = "/Environment/SendMessageToWebAPI";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sendMessageToWebAPI = new JObject();
            var sendMessageToWebAPIpropCount = 0;
            if (sendMessageToWebAPIURL != null)
            {
                sendMessageToWebAPI["URL"] = ExpressionConverter.ConvertO(sendMessageToWebAPIURL);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIMethod != null)
            {
                sendMessageToWebAPI["Method"] = ExpressionConverter.ConvertO(sendMessageToWebAPIMethod);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPITimeoutInSeconds != null)
            {
                sendMessageToWebAPI["TimeoutInSeconds"] = ExpressionConverter.ConvertO(sendMessageToWebAPITimeoutInSeconds);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIContentType != null)
            {
                sendMessageToWebAPI["ContentType"] = ExpressionConverter.ConvertO(sendMessageToWebAPIContentType);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIAccept != null)
            {
                sendMessageToWebAPI["Accept"] = ExpressionConverter.ConvertO(sendMessageToWebAPIAccept);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIMessageBody != null)
            {
                sendMessageToWebAPI["MessageBody"] = ExpressionConverter.ConvertO(sendMessageToWebAPIMessageBody);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPITransmitEncoding != null)
            {
                sendMessageToWebAPI["TransmitEncoding"] = ExpressionConverter.ConvertO(sendMessageToWebAPITransmitEncoding);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIResponseEncoding != null)
            {
                sendMessageToWebAPI["ResponseEncoding"] = ExpressionConverter.ConvertO(sendMessageToWebAPIResponseEncoding);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIBufferSize != null)
            {
                sendMessageToWebAPI["BufferSize"] = ExpressionConverter.ConvertO(sendMessageToWebAPIBufferSize);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIHTTPRequestHeadersList != null)
            {
                sendMessageToWebAPI["HTTPRequestHeadersList"] = ExpressionConverter.ConvertO(sendMessageToWebAPIHTTPRequestHeadersList);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPINegotiateTLS10 != null)
            {
                sendMessageToWebAPI["NegotiateTLS10"] = ExpressionConverter.ConvertO(sendMessageToWebAPINegotiateTLS10);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPINegotiateTLS11 != null)
            {
                sendMessageToWebAPI["NegotiateTLS11"] = ExpressionConverter.ConvertO(sendMessageToWebAPINegotiateTLS11);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPINegotiateTLS12 != null)
            {
                sendMessageToWebAPI["NegotiateTLS12"] = ExpressionConverter.ConvertO(sendMessageToWebAPINegotiateTLS12);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPINegotiateTLS13 != null)
            {
                sendMessageToWebAPI["NegotiateTLS13"] = ExpressionConverter.ConvertO(sendMessageToWebAPINegotiateTLS13);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIKeepAlive != null)
            {
                sendMessageToWebAPI["KeepAlive"] = ExpressionConverter.ConvertO(sendMessageToWebAPIKeepAlive);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIExpect100Continue != null)
            {
                sendMessageToWebAPI["Expect100Continue"] = ExpressionConverter.ConvertO(sendMessageToWebAPIExpect100Continue);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIReturnResponseHeaders != null)
            {
                sendMessageToWebAPI["ReturnResponseHeaders"] = ExpressionConverter.ConvertO(sendMessageToWebAPIReturnResponseHeaders);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIRunAsThread != null)
            {
                sendMessageToWebAPI["RunAsThread"] = ExpressionConverter.ConvertO(sendMessageToWebAPIRunAsThread);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIWaitForThread != null)
            {
                sendMessageToWebAPI["WaitForThread"] = ExpressionConverter.ConvertO(sendMessageToWebAPIWaitForThread);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIRetrieveOutputDataFromThreadId != null)
            {
                sendMessageToWebAPI["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(sendMessageToWebAPIRetrieveOutputDataFromThreadId);
                sendMessageToWebAPIpropCount++;
            }

            sendMessageToWebAPIpropCount++;
            sendMessageToWebAPI["Workflow"] = ExpressionConverter.ConvertO(sendMessageToWebAPIWorkflow);
            if (sendMessageToWebAPIpropCount > 0)
            {
                callPayload.Body = sendMessageToWebAPI;
            }

            return new ApiConnectionAction<SendMessageToWebAPIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewTaskResponse> TasksAddNewTask(Expression<Func<string>> tasksAddNewTaskWorkflow, Expression<Func<tasksAddNewTaskSetAutomationNameInput>> tasksAddNewTaskSetAutomationName = null, Expression<Func<string>> tasksAddNewTaskAutomationName = null, Expression<Func<string>> tasksAddNewTaskTaskInputData = null, Expression<Func<string>> tasksAddNewTaskProcessStage = null, Expression<Func<int>> tasksAddNewTaskPriority = null, Expression<Func<int>> tasksAddNewTaskSLA = null, Expression<Func<bool>> tasksAddNewTaskTaskOnHold = null, Expression<Func<string>> tasksAddNewTaskOrganisation = null, Expression<Func<string>> tasksAddNewTaskDepartment = null, Expression<Func<string>> tasksAddNewTaskDescription = null, Expression<Func<string>> tasksAddNewTaskTags = null)
        {
            var apiCallPath = "/Environment/TasksAddNewTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksAddNewTask = new JObject();
            var tasksAddNewTaskpropCount = 0;
            if (tasksAddNewTaskSetAutomationName != null)
            {
                tasksAddNewTask["SetAutomationName"] = ExpressionConverter.ConvertO(tasksAddNewTaskSetAutomationName);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTaskAutomationName != null)
            {
                tasksAddNewTask["AutomationName"] = ExpressionConverter.ConvertO(tasksAddNewTaskAutomationName);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTaskTaskInputData != null)
            {
                tasksAddNewTask["TaskInputData"] = ExpressionConverter.ConvertO(tasksAddNewTaskTaskInputData);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTaskProcessStage != null)
            {
                tasksAddNewTask["ProcessStage"] = ExpressionConverter.ConvertO(tasksAddNewTaskProcessStage);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTaskPriority != null)
            {
                tasksAddNewTask["Priority"] = ExpressionConverter.ConvertO(tasksAddNewTaskPriority);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTaskSLA != null)
            {
                tasksAddNewTask["SLA"] = ExpressionConverter.ConvertO(tasksAddNewTaskSLA);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTaskTaskOnHold != null)
            {
                tasksAddNewTask["TaskOnHold"] = ExpressionConverter.ConvertO(tasksAddNewTaskTaskOnHold);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTaskOrganisation != null)
            {
                tasksAddNewTask["Organisation"] = ExpressionConverter.ConvertO(tasksAddNewTaskOrganisation);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTaskDepartment != null)
            {
                tasksAddNewTask["Department"] = ExpressionConverter.ConvertO(tasksAddNewTaskDepartment);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTaskDescription != null)
            {
                tasksAddNewTask["Description"] = ExpressionConverter.ConvertO(tasksAddNewTaskDescription);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTaskTags != null)
            {
                tasksAddNewTask["Tags"] = ExpressionConverter.ConvertO(tasksAddNewTaskTags);
                tasksAddNewTaskpropCount++;
            }

            tasksAddNewTaskpropCount++;
            tasksAddNewTask["Workflow"] = ExpressionConverter.ConvertO(tasksAddNewTaskWorkflow);
            if (tasksAddNewTaskpropCount > 0)
            {
                callPayload.Body = tasksAddNewTask;
            }

            return new ApiConnectionAction<TasksAddNewTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewDeferralResponse> TasksAddNewDeferral(Expression<Func<string>> tasksAddNewDeferralWorkflow, Expression<Func<tasksAddNewDeferralSetAutomationNameInput>> tasksAddNewDeferralSetAutomationName = null, Expression<Func<string>> tasksAddNewDeferralAutomationName = null, Expression<Func<int>> tasksAddNewDeferralDeferralTimeInMinutes = null, Expression<Func<string>> tasksAddNewDeferralTaskInputData = null, Expression<Func<string>> tasksAddNewDeferralDeferralStoredData = null, Expression<Func<string>> tasksAddNewDeferralProcessStage = null, Expression<Func<int>> tasksAddNewDeferralPriority = null, Expression<Func<bool>> tasksAddNewDeferralTaskOnHold = null, Expression<Func<string>> tasksAddNewDeferralOrganisation = null, Expression<Func<string>> tasksAddNewDeferralDepartment = null, Expression<Func<string>> tasksAddNewDeferralDescription = null, Expression<Func<string>> tasksAddNewDeferralTags = null)
        {
            var apiCallPath = "/Environment/TasksAddNewDeferral";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksAddNewDeferral = new JObject();
            var tasksAddNewDeferralpropCount = 0;
            if (tasksAddNewDeferralSetAutomationName != null)
            {
                tasksAddNewDeferral["SetAutomationName"] = ExpressionConverter.ConvertO(tasksAddNewDeferralSetAutomationName);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferralAutomationName != null)
            {
                tasksAddNewDeferral["AutomationName"] = ExpressionConverter.ConvertO(tasksAddNewDeferralAutomationName);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferralDeferralTimeInMinutes != null)
            {
                tasksAddNewDeferral["DeferralTimeInMinutes"] = ExpressionConverter.ConvertO(tasksAddNewDeferralDeferralTimeInMinutes);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferralTaskInputData != null)
            {
                tasksAddNewDeferral["TaskInputData"] = ExpressionConverter.ConvertO(tasksAddNewDeferralTaskInputData);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferralDeferralStoredData != null)
            {
                tasksAddNewDeferral["DeferralStoredData"] = ExpressionConverter.ConvertO(tasksAddNewDeferralDeferralStoredData);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferralProcessStage != null)
            {
                tasksAddNewDeferral["ProcessStage"] = ExpressionConverter.ConvertO(tasksAddNewDeferralProcessStage);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferralPriority != null)
            {
                tasksAddNewDeferral["Priority"] = ExpressionConverter.ConvertO(tasksAddNewDeferralPriority);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferralTaskOnHold != null)
            {
                tasksAddNewDeferral["TaskOnHold"] = ExpressionConverter.ConvertO(tasksAddNewDeferralTaskOnHold);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferralOrganisation != null)
            {
                tasksAddNewDeferral["Organisation"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOrganisation);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferralDepartment != null)
            {
                tasksAddNewDeferral["Department"] = ExpressionConverter.ConvertO(tasksAddNewDeferralDepartment);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferralDescription != null)
            {
                tasksAddNewDeferral["Description"] = ExpressionConverter.ConvertO(tasksAddNewDeferralDescription);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferralTags != null)
            {
                tasksAddNewDeferral["Tags"] = ExpressionConverter.ConvertO(tasksAddNewDeferralTags);
                tasksAddNewDeferralpropCount++;
            }

            tasksAddNewDeferralpropCount++;
            tasksAddNewDeferral["Workflow"] = ExpressionConverter.ConvertO(tasksAddNewDeferralWorkflow);
            if (tasksAddNewDeferralpropCount > 0)
            {
                callPayload.Body = tasksAddNewDeferral;
            }

            return new ApiConnectionAction<TasksAddNewDeferralResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeferExistingTaskResponse> TasksDeferExistingTask(Expression<Func<int>> tasksDeferExistingTaskTaskId, Expression<Func<int>> tasksDeferExistingTaskDeferralTimeInMinutes = null, Expression<Func<string>> tasksDeferExistingTaskDeferralStoredData = null, Expression<Func<string>> tasksDeferExistingTaskProcessStage = null, Expression<Func<int>> tasksDeferExistingTaskPriority = null, Expression<Func<bool>> tasksDeferExistingTaskTaskOnHold = null)
        {
            var apiCallPath = "/Environment/TasksDeferExistingTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksDeferExistingTask = new JObject();
            var tasksDeferExistingTaskpropCount = 0;
            tasksDeferExistingTaskpropCount++;
            tasksDeferExistingTask["TaskId"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskTaskId);
            if (tasksDeferExistingTaskDeferralTimeInMinutes != null)
            {
                tasksDeferExistingTask["DeferralTimeInMinutes"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskDeferralTimeInMinutes);
                tasksDeferExistingTaskpropCount++;
            }

            if (tasksDeferExistingTaskDeferralStoredData != null)
            {
                tasksDeferExistingTask["DeferralStoredData"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskDeferralStoredData);
                tasksDeferExistingTaskpropCount++;
            }

            if (tasksDeferExistingTaskProcessStage != null)
            {
                tasksDeferExistingTask["ProcessStage"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskProcessStage);
                tasksDeferExistingTaskpropCount++;
            }

            if (tasksDeferExistingTaskPriority != null)
            {
                tasksDeferExistingTask["Priority"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskPriority);
                tasksDeferExistingTaskpropCount++;
            }

            if (tasksDeferExistingTaskTaskOnHold != null)
            {
                tasksDeferExistingTask["TaskOnHold"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskTaskOnHold);
                tasksDeferExistingTaskpropCount++;
            }

            if (tasksDeferExistingTaskpropCount > 0)
            {
                callPayload.Body = tasksDeferExistingTask;
            }

            return new ApiConnectionAction<TasksDeferExistingTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeferExistingTaskOperationResponse> TasksDeferExistingTaskOperation(Expression<Func<string>> tasksDeferExistingTaskOperationOperationId, Expression<Func<int>> tasksDeferExistingTaskOperationDeferralTimeInMinutes = null, Expression<Func<string>> tasksDeferExistingTaskOperationDeferralStoredData = null, Expression<Func<string>> tasksDeferExistingTaskOperationProcessStage = null, Expression<Func<int>> tasksDeferExistingTaskOperationPriority = null)
        {
            var apiCallPath = "/Environment/TasksDeferExistingTaskOperation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksDeferExistingTaskOperation = new JObject();
            var tasksDeferExistingTaskOperationpropCount = 0;
            tasksDeferExistingTaskOperationpropCount++;
            tasksDeferExistingTaskOperation["OperationId"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskOperationOperationId);
            if (tasksDeferExistingTaskOperationDeferralTimeInMinutes != null)
            {
                tasksDeferExistingTaskOperation["DeferralTimeInMinutes"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskOperationDeferralTimeInMinutes);
                tasksDeferExistingTaskOperationpropCount++;
            }

            if (tasksDeferExistingTaskOperationDeferralStoredData != null)
            {
                tasksDeferExistingTaskOperation["DeferralStoredData"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskOperationDeferralStoredData);
                tasksDeferExistingTaskOperationpropCount++;
            }

            if (tasksDeferExistingTaskOperationProcessStage != null)
            {
                tasksDeferExistingTaskOperation["ProcessStage"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskOperationProcessStage);
                tasksDeferExistingTaskOperationpropCount++;
            }

            if (tasksDeferExistingTaskOperationPriority != null)
            {
                tasksDeferExistingTaskOperation["Priority"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskOperationPriority);
                tasksDeferExistingTaskOperationpropCount++;
            }

            if (tasksDeferExistingTaskOperationpropCount > 0)
            {
                callPayload.Body = tasksDeferExistingTaskOperation;
            }

            return new ApiConnectionAction<TasksDeferExistingTaskOperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeleteTaskResponse> TasksDeleteTask(Expression<Func<int>> tasksDeleteTaskTaskId, Expression<Func<bool>> tasksDeleteTaskUpdateSourceSystem = null)
        {
            var apiCallPath = "/Environment/TasksDeleteTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksDeleteTask = new JObject();
            var tasksDeleteTaskpropCount = 0;
            tasksDeleteTaskpropCount++;
            tasksDeleteTask["TaskId"] = ExpressionConverter.ConvertO(tasksDeleteTaskTaskId);
            if (tasksDeleteTaskUpdateSourceSystem != null)
            {
                tasksDeleteTask["UpdateSourceSystem"] = ExpressionConverter.ConvertO(tasksDeleteTaskUpdateSourceSystem);
                tasksDeleteTaskpropCount++;
            }

            if (tasksDeleteTaskpropCount > 0)
            {
                callPayload.Body = tasksDeleteTask;
            }

            return new ApiConnectionAction<TasksDeleteTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeleteTaskOperationResponse> TasksDeleteTaskOperation(Expression<Func<string>> tasksDeleteTaskOperationOperationId, Expression<Func<bool>> tasksDeleteTaskOperationUpdateSourceSystem = null)
        {
            var apiCallPath = "/Environment/TasksDeleteTaskOperation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksDeleteTaskOperation = new JObject();
            var tasksDeleteTaskOperationpropCount = 0;
            tasksDeleteTaskOperationpropCount++;
            tasksDeleteTaskOperation["OperationId"] = ExpressionConverter.ConvertO(tasksDeleteTaskOperationOperationId);
            if (tasksDeleteTaskOperationUpdateSourceSystem != null)
            {
                tasksDeleteTaskOperation["UpdateSourceSystem"] = ExpressionConverter.ConvertO(tasksDeleteTaskOperationUpdateSourceSystem);
                tasksDeleteTaskOperationpropCount++;
            }

            if (tasksDeleteTaskOperationpropCount > 0)
            {
                callPayload.Body = tasksDeleteTaskOperation;
            }

            return new ApiConnectionAction<TasksDeleteTaskOperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetAllTasksResponse> TasksGetAllTasks(Expression<Func<string>> tasksGetAllTasksAutomationName = null, Expression<Func<tasksGetAllTasksAutomationTaskStatusInput>> tasksGetAllTasksAutomationTaskStatus = null, Expression<Func<string>> tasksGetAllTasksFilterByPropertyQuery = null, Expression<Func<int>> tasksGetAllTasksMinutesUntilDeferralDate = null, Expression<Func<int>> tasksGetAllTasksMinimumPriorityLevel = null, Expression<Func<bool>> tasksGetAllTasksSortByDeferralDate = null, Expression<Func<bool>> tasksGetAllTasksRetrieveOnHoldTasks = null, Expression<Func<int>> tasksGetAllTasksSkip = null, Expression<Func<int>> tasksGetAllTasksMaxResults = null, Expression<Func<bool>> tasksGetAllTasksExcludeTaskData = null)
        {
            var apiCallPath = "/Environment/TasksGetAllTasks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksGetAllTasks = new JObject();
            var tasksGetAllTaskspropCount = 0;
            if (tasksGetAllTasksAutomationName != null)
            {
                tasksGetAllTasks["AutomationName"] = ExpressionConverter.ConvertO(tasksGetAllTasksAutomationName);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksAutomationTaskStatus != null)
            {
                tasksGetAllTasks["AutomationTaskStatus"] = ExpressionConverter.ConvertO(tasksGetAllTasksAutomationTaskStatus);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksFilterByPropertyQuery != null)
            {
                tasksGetAllTasks["FilterByPropertyQuery"] = ExpressionConverter.ConvertO(tasksGetAllTasksFilterByPropertyQuery);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksMinutesUntilDeferralDate != null)
            {
                tasksGetAllTasks["MinutesUntilDeferralDate"] = ExpressionConverter.ConvertO(tasksGetAllTasksMinutesUntilDeferralDate);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksMinimumPriorityLevel != null)
            {
                tasksGetAllTasks["MinimumPriorityLevel"] = ExpressionConverter.ConvertO(tasksGetAllTasksMinimumPriorityLevel);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksSortByDeferralDate != null)
            {
                tasksGetAllTasks["SortByDeferralDate"] = ExpressionConverter.ConvertO(tasksGetAllTasksSortByDeferralDate);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksRetrieveOnHoldTasks != null)
            {
                tasksGetAllTasks["RetrieveOnHoldTasks"] = ExpressionConverter.ConvertO(tasksGetAllTasksRetrieveOnHoldTasks);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksSkip != null)
            {
                tasksGetAllTasks["Skip"] = ExpressionConverter.ConvertO(tasksGetAllTasksSkip);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksMaxResults != null)
            {
                tasksGetAllTasks["MaxResults"] = ExpressionConverter.ConvertO(tasksGetAllTasksMaxResults);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksExcludeTaskData != null)
            {
                tasksGetAllTasks["ExcludeTaskData"] = ExpressionConverter.ConvertO(tasksGetAllTasksExcludeTaskData);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTaskspropCount > 0)
            {
                callPayload.Body = tasksGetAllTasks;
            }

            return new ApiConnectionAction<TasksGetAllTasksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetTaskResponse> TasksGetTask(Expression<Func<int>> tasksGetTaskTaskId, Expression<Func<tasksGetTaskStatusChangeInput>> tasksGetTaskStatusChange = null)
        {
            var apiCallPath = "/Environment/TasksGetTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksGetTask = new JObject();
            var tasksGetTaskpropCount = 0;
            tasksGetTaskpropCount++;
            tasksGetTask["TaskId"] = ExpressionConverter.ConvertO(tasksGetTaskTaskId);
            if (tasksGetTaskStatusChange != null)
            {
                tasksGetTask["StatusChange"] = ExpressionConverter.ConvertO(tasksGetTaskStatusChange);
                tasksGetTaskpropCount++;
            }

            if (tasksGetTaskpropCount > 0)
            {
                callPayload.Body = tasksGetTask;
            }

            return new ApiConnectionAction<TasksGetTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetNextTaskResponse> TasksGetNextTask(Expression<Func<string>> tasksGetNextTaskAutomationName = null, Expression<Func<string[]>> tasksGetNextTaskAutomationNames = null, Expression<Func<int>> tasksGetNextTaskMinimumPriorityLevel = null, Expression<Func<tasksGetNextTaskStatusChangeInput>> tasksGetNextTaskStatusChange = null, Expression<Func<int>> tasksGetNextTaskMinutesUntilDeferralDate = null, Expression<Func<bool>> tasksGetNextTaskIgnoreSLA = null, Expression<Func<int[]>> tasksGetNextTaskExcludeTaskIds = null)
        {
            var apiCallPath = "/Environment/TasksGetNextTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksGetNextTask = new JObject();
            var tasksGetNextTaskpropCount = 0;
            if (tasksGetNextTaskAutomationName != null)
            {
                tasksGetNextTask["AutomationName"] = ExpressionConverter.ConvertO(tasksGetNextTaskAutomationName);
                tasksGetNextTaskpropCount++;
            }

            if (tasksGetNextTaskAutomationNames != null)
            {
                tasksGetNextTask["AutomationNames"] = ExpressionConverter.ConvertO(tasksGetNextTaskAutomationNames);
                tasksGetNextTaskpropCount++;
            }

            if (tasksGetNextTaskMinimumPriorityLevel != null)
            {
                tasksGetNextTask["MinimumPriorityLevel"] = ExpressionConverter.ConvertO(tasksGetNextTaskMinimumPriorityLevel);
                tasksGetNextTaskpropCount++;
            }

            if (tasksGetNextTaskStatusChange != null)
            {
                tasksGetNextTask["StatusChange"] = ExpressionConverter.ConvertO(tasksGetNextTaskStatusChange);
                tasksGetNextTaskpropCount++;
            }

            if (tasksGetNextTaskMinutesUntilDeferralDate != null)
            {
                tasksGetNextTask["MinutesUntilDeferralDate"] = ExpressionConverter.ConvertO(tasksGetNextTaskMinutesUntilDeferralDate);
                tasksGetNextTaskpropCount++;
            }

            if (tasksGetNextTaskIgnoreSLA != null)
            {
                tasksGetNextTask["IgnoreSLA"] = ExpressionConverter.ConvertO(tasksGetNextTaskIgnoreSLA);
                tasksGetNextTaskpropCount++;
            }

            if (tasksGetNextTaskExcludeTaskIds != null)
            {
                tasksGetNextTask["ExcludeTaskIds"] = ExpressionConverter.ConvertO(tasksGetNextTaskExcludeTaskIds);
                tasksGetNextTaskpropCount++;
            }

            if (tasksGetNextTaskpropCount > 0)
            {
                callPayload.Body = tasksGetNextTask;
            }

            return new ApiConnectionAction<TasksGetNextTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksChangeTaskStatusResponse> TasksChangeTaskStatus(Expression<Func<int>> tasksChangeTaskStatusTaskId, Expression<Func<tasksChangeTaskStatusAutomationTaskStatusInput>> tasksChangeTaskStatusAutomationTaskStatus = null, Expression<Func<bool>> tasksChangeTaskStatusTaskOnHold = null, Expression<Func<bool>> tasksChangeTaskStatusEraseTaskInputData = null, Expression<Func<bool>> tasksChangeTaskStatusEraseDeferralStoredData = null, Expression<Func<bool>> tasksChangeTaskStatusUpdateSourceSystem = null, Expression<Func<string>> tasksChangeTaskStatusTaskClosureReason = null)
        {
            var apiCallPath = "/Environment/TasksChangeTaskStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksChangeTaskStatus = new JObject();
            var tasksChangeTaskStatuspropCount = 0;
            tasksChangeTaskStatuspropCount++;
            tasksChangeTaskStatus["TaskId"] = ExpressionConverter.ConvertO(tasksChangeTaskStatusTaskId);
            if (tasksChangeTaskStatusAutomationTaskStatus != null)
            {
                tasksChangeTaskStatus["AutomationTaskStatus"] = ExpressionConverter.ConvertO(tasksChangeTaskStatusAutomationTaskStatus);
                tasksChangeTaskStatuspropCount++;
            }

            if (tasksChangeTaskStatusTaskOnHold != null)
            {
                tasksChangeTaskStatus["TaskOnHold"] = ExpressionConverter.ConvertO(tasksChangeTaskStatusTaskOnHold);
                tasksChangeTaskStatuspropCount++;
            }

            if (tasksChangeTaskStatusEraseTaskInputData != null)
            {
                tasksChangeTaskStatus["EraseTaskInputData"] = ExpressionConverter.ConvertO(tasksChangeTaskStatusEraseTaskInputData);
                tasksChangeTaskStatuspropCount++;
            }

            if (tasksChangeTaskStatusEraseDeferralStoredData != null)
            {
                tasksChangeTaskStatus["EraseDeferralStoredData"] = ExpressionConverter.ConvertO(tasksChangeTaskStatusEraseDeferralStoredData);
                tasksChangeTaskStatuspropCount++;
            }

            if (tasksChangeTaskStatusUpdateSourceSystem != null)
            {
                tasksChangeTaskStatus["UpdateSourceSystem"] = ExpressionConverter.ConvertO(tasksChangeTaskStatusUpdateSourceSystem);
                tasksChangeTaskStatuspropCount++;
            }

            if (tasksChangeTaskStatusTaskClosureReason != null)
            {
                tasksChangeTaskStatus["TaskClosureReason"] = ExpressionConverter.ConvertO(tasksChangeTaskStatusTaskClosureReason);
                tasksChangeTaskStatuspropCount++;
            }

            if (tasksChangeTaskStatuspropCount > 0)
            {
                callPayload.Body = tasksChangeTaskStatus;
            }

            return new ApiConnectionAction<TasksChangeTaskStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNoteResponse> TasksAddNote(Expression<Func<int>> tasksAddNoteTaskId, Expression<Func<string>> tasksAddNoteNoteText, Expression<Func<tasksAddNoteNoteTypeInput>> tasksAddNoteNoteType = null, Expression<Func<string>> tasksAddNoteNoteTypeOther = null)
        {
            var apiCallPath = "/Environment/TasksAddNote";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksAddNote = new JObject();
            var tasksAddNotepropCount = 0;
            tasksAddNotepropCount++;
            tasksAddNote["TaskId"] = ExpressionConverter.ConvertO(tasksAddNoteTaskId);
            tasksAddNotepropCount++;
            tasksAddNote["NoteText"] = ExpressionConverter.ConvertO(tasksAddNoteNoteText);
            if (tasksAddNoteNoteType != null)
            {
                tasksAddNote["NoteType"] = ExpressionConverter.ConvertO(tasksAddNoteNoteType);
                tasksAddNotepropCount++;
            }

            if (tasksAddNoteNoteTypeOther != null)
            {
                tasksAddNote["NoteTypeOther"] = ExpressionConverter.ConvertO(tasksAddNoteNoteTypeOther);
                tasksAddNotepropCount++;
            }

            if (tasksAddNotepropCount > 0)
            {
                callPayload.Body = tasksAddNote;
            }

            return new ApiConnectionAction<TasksAddNoteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAssignTaskResponse> TasksAssignTask(Expression<Func<int>> tasksAssignTaskTaskId, Expression<Func<string>> tasksAssignTaskAssignToUserId = null, Expression<Func<string>> tasksAssignTaskAssignToUserName = null, Expression<Func<string>> tasksAssignTaskAssignToGroupId = null, Expression<Func<string>> tasksAssignTaskAssignToGroupName = null, Expression<Func<bool>> tasksAssignTaskRemoveUserAssignmentIfBlank = null, Expression<Func<bool>> tasksAssignTaskRemoveGroupAssignmentIfBlank = null)
        {
            var apiCallPath = "/Environment/TasksAssignTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksAssignTask = new JObject();
            var tasksAssignTaskpropCount = 0;
            tasksAssignTaskpropCount++;
            tasksAssignTask["TaskId"] = ExpressionConverter.ConvertO(tasksAssignTaskTaskId);
            if (tasksAssignTaskAssignToUserId != null)
            {
                tasksAssignTask["AssignToUserId"] = ExpressionConverter.ConvertO(tasksAssignTaskAssignToUserId);
                tasksAssignTaskpropCount++;
            }

            if (tasksAssignTaskAssignToUserName != null)
            {
                tasksAssignTask["AssignToUserName"] = ExpressionConverter.ConvertO(tasksAssignTaskAssignToUserName);
                tasksAssignTaskpropCount++;
            }

            if (tasksAssignTaskAssignToGroupId != null)
            {
                tasksAssignTask["AssignToGroupId"] = ExpressionConverter.ConvertO(tasksAssignTaskAssignToGroupId);
                tasksAssignTaskpropCount++;
            }

            if (tasksAssignTaskAssignToGroupName != null)
            {
                tasksAssignTask["AssignToGroupName"] = ExpressionConverter.ConvertO(tasksAssignTaskAssignToGroupName);
                tasksAssignTaskpropCount++;
            }

            if (tasksAssignTaskRemoveUserAssignmentIfBlank != null)
            {
                tasksAssignTask["RemoveUserAssignmentIfBlank"] = ExpressionConverter.ConvertO(tasksAssignTaskRemoveUserAssignmentIfBlank);
                tasksAssignTaskpropCount++;
            }

            if (tasksAssignTaskRemoveGroupAssignmentIfBlank != null)
            {
                tasksAssignTask["RemoveGroupAssignmentIfBlank"] = ExpressionConverter.ConvertO(tasksAssignTaskRemoveGroupAssignmentIfBlank);
                tasksAssignTaskpropCount++;
            }

            if (tasksAssignTaskpropCount > 0)
            {
                callPayload.Body = tasksAssignTask;
            }

            return new ApiConnectionAction<TasksAssignTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksSetOutputDataResponse> TasksSetOutputData(Expression<Func<int>> tasksSetOutputDataTaskId, Expression<Func<string>> tasksSetOutputDataTaskOutputData = null)
        {
            var apiCallPath = "/Environment/TasksSetOutputData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksSetOutputData = new JObject();
            var tasksSetOutputDatapropCount = 0;
            tasksSetOutputDatapropCount++;
            tasksSetOutputData["TaskId"] = ExpressionConverter.ConvertO(tasksSetOutputDataTaskId);
            if (tasksSetOutputDataTaskOutputData != null)
            {
                tasksSetOutputData["TaskOutputData"] = ExpressionConverter.ConvertO(tasksSetOutputDataTaskOutputData);
                tasksSetOutputDatapropCount++;
            }

            if (tasksSetOutputDatapropCount > 0)
            {
                callPayload.Body = tasksSetOutputData;
            }

            return new ApiConnectionAction<TasksSetOutputDataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewTaskOperationResponse> TasksAddNewTaskOperation(Expression<Func<string>> tasksAddNewTaskOperationAutomationName = null, Expression<Func<string>> tasksAddNewTaskOperationTaskInputData = null, Expression<Func<string>> tasksAddNewTaskOperationProcessStage = null, Expression<Func<int>> tasksAddNewTaskOperationPriority = null, Expression<Func<int>> tasksAddNewTaskOperationSLA = null, Expression<Func<string>> tasksAddNewTaskOperationOrganisation = null, Expression<Func<string>> tasksAddNewTaskOperationDepartment = null, Expression<Func<string>> tasksAddNewTaskOperationDescription = null, Expression<Func<string>> tasksAddNewTaskOperationTags = null)
        {
            var apiCallPath = "/Environment/TasksAddNewTaskOperation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksAddNewTaskOperation = new JObject();
            var tasksAddNewTaskOperationpropCount = 0;
            if (tasksAddNewTaskOperationAutomationName != null)
            {
                tasksAddNewTaskOperation["AutomationName"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationAutomationName);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationTaskInputData != null)
            {
                tasksAddNewTaskOperation["TaskInputData"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationTaskInputData);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationProcessStage != null)
            {
                tasksAddNewTaskOperation["ProcessStage"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationProcessStage);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationPriority != null)
            {
                tasksAddNewTaskOperation["Priority"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationPriority);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationSLA != null)
            {
                tasksAddNewTaskOperation["SLA"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationSLA);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationOrganisation != null)
            {
                tasksAddNewTaskOperation["Organisation"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationOrganisation);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationDepartment != null)
            {
                tasksAddNewTaskOperation["Department"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationDepartment);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationDescription != null)
            {
                tasksAddNewTaskOperation["Description"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationDescription);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationTags != null)
            {
                tasksAddNewTaskOperation["Tags"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationTags);
                tasksAddNewTaskOperationpropCount++;
            }

            if (tasksAddNewTaskOperationpropCount > 0)
            {
                callPayload.Body = tasksAddNewTaskOperation;
            }

            return new ApiConnectionAction<TasksAddNewTaskOperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewDeferralOperationResponse> TasksAddNewDeferralOperation(Expression<Func<string>> tasksAddNewDeferralOperationAutomationName = null, Expression<Func<int>> tasksAddNewDeferralOperationDeferralTimeInMinutes = null, Expression<Func<string>> tasksAddNewDeferralOperationTaskInputData = null, Expression<Func<string>> tasksAddNewDeferralOperationDeferralStoredData = null, Expression<Func<string>> tasksAddNewDeferralOperationProcessStage = null, Expression<Func<int>> tasksAddNewDeferralOperationPriority = null, Expression<Func<string>> tasksAddNewDeferralOperationOrganisation = null, Expression<Func<string>> tasksAddNewDeferralOperationDepartment = null, Expression<Func<string>> tasksAddNewDeferralOperationDescription = null, Expression<Func<string>> tasksAddNewDeferralOperationTags = null)
        {
            var apiCallPath = "/Environment/TasksAddNewDeferralOperation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksAddNewDeferralOperation = new JObject();
            var tasksAddNewDeferralOperationpropCount = 0;
            if (tasksAddNewDeferralOperationAutomationName != null)
            {
                tasksAddNewDeferralOperation["AutomationName"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationAutomationName);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationDeferralTimeInMinutes != null)
            {
                tasksAddNewDeferralOperation["DeferralTimeInMinutes"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationDeferralTimeInMinutes);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationTaskInputData != null)
            {
                tasksAddNewDeferralOperation["TaskInputData"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationTaskInputData);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationDeferralStoredData != null)
            {
                tasksAddNewDeferralOperation["DeferralStoredData"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationDeferralStoredData);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationProcessStage != null)
            {
                tasksAddNewDeferralOperation["ProcessStage"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationProcessStage);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationPriority != null)
            {
                tasksAddNewDeferralOperation["Priority"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationPriority);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationOrganisation != null)
            {
                tasksAddNewDeferralOperation["Organisation"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationOrganisation);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationDepartment != null)
            {
                tasksAddNewDeferralOperation["Department"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationDepartment);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationDescription != null)
            {
                tasksAddNewDeferralOperation["Description"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationDescription);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationTags != null)
            {
                tasksAddNewDeferralOperation["Tags"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationTags);
                tasksAddNewDeferralOperationpropCount++;
            }

            if (tasksAddNewDeferralOperationpropCount > 0)
            {
                callPayload.Body = tasksAddNewDeferralOperation;
            }

            return new ApiConnectionAction<TasksAddNewDeferralOperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetTaskOperationResponse> TasksGetTaskOperation(Expression<Func<string>> tasksGetTaskOperationOperationId)
        {
            var apiCallPath = "/Environment/TasksGetTaskOperation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksGetTaskOperation = new JObject();
            var tasksGetTaskOperationpropCount = 0;
            tasksGetTaskOperationpropCount++;
            tasksGetTaskOperation["OperationId"] = ExpressionConverter.ConvertO(tasksGetTaskOperationOperationId);
            if (tasksGetTaskOperationpropCount > 0)
            {
                callPayload.Body = tasksGetTaskOperation;
            }

            return new ApiConnectionAction<TasksGetTaskOperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRemoteLoggingLevel(Expression<Func<int>> setRemoteLoggingLevelLoggingLevel, Expression<Func<string>> setRemoteLoggingLevelWorkflow)
        {
            var apiCallPath = "/DriverControl/SetRemoteLoggingLevel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setRemoteLoggingLevel = new JObject();
            var setRemoteLoggingLevelpropCount = 0;
            setRemoteLoggingLevelpropCount++;
            setRemoteLoggingLevel["LoggingLevel"] = ExpressionConverter.ConvertO(setRemoteLoggingLevelLoggingLevel);
            setRemoteLoggingLevelpropCount++;
            setRemoteLoggingLevel["Workflow"] = ExpressionConverter.ConvertO(setRemoteLoggingLevelWorkflow);
            if (setRemoteLoggingLevelpropCount > 0)
            {
                callPayload.Body = setRemoteLoggingLevel;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteLoggingLevelResponse> GetRemoteLoggingLevel(Expression<Func<string>> getRemoteLoggingLevelWorkflow)
        {
            var apiCallPath = "/DriverControl/GetRemoteLoggingLevel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRemoteLoggingLevel = new JObject();
            var getRemoteLoggingLevelpropCount = 0;
            getRemoteLoggingLevelpropCount++;
            getRemoteLoggingLevel["Workflow"] = ExpressionConverter.ConvertO(getRemoteLoggingLevelWorkflow);
            if (getRemoteLoggingLevelpropCount > 0)
            {
                callPayload.Body = getRemoteLoggingLevel;
            }

            return new ApiConnectionAction<GetRemoteLoggingLevelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetLicenseCode(Expression<Func<string>> setLicenseCodeCustomerNETBIOSDomainName, Expression<Func<string>> setLicenseCodeCustomerDisplayName, Expression<Func<string>> setLicenseCodeVendorName, Expression<Func<string>> setLicenseCodeLicenseExpiryDate, Expression<Func<string>> setLicenseCodeActivationCode, Expression<Func<string>> setLicenseCodeWorkflow, Expression<Func<bool>> setLicenseCodeStoreInRegistry = null)
        {
            var apiCallPath = "/DriverControl/SetLicenseCode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setLicenseCode = new JObject();
            var setLicenseCodepropCount = 0;
            setLicenseCodepropCount++;
            setLicenseCode["CustomerNETBIOSDomainName"] = ExpressionConverter.ConvertO(setLicenseCodeCustomerNETBIOSDomainName);
            setLicenseCodepropCount++;
            setLicenseCode["CustomerDisplayName"] = ExpressionConverter.ConvertO(setLicenseCodeCustomerDisplayName);
            setLicenseCodepropCount++;
            setLicenseCode["VendorName"] = ExpressionConverter.ConvertO(setLicenseCodeVendorName);
            setLicenseCodepropCount++;
            setLicenseCode["LicenseExpiryDate"] = ExpressionConverter.ConvertO(setLicenseCodeLicenseExpiryDate);
            setLicenseCodepropCount++;
            setLicenseCode["ActivationCode"] = ExpressionConverter.ConvertO(setLicenseCodeActivationCode);
            if (setLicenseCodeStoreInRegistry != null)
            {
                setLicenseCode["StoreInRegistry"] = ExpressionConverter.ConvertO(setLicenseCodeStoreInRegistry);
                setLicenseCodepropCount++;
            }

            setLicenseCodepropCount++;
            setLicenseCode["Workflow"] = ExpressionConverter.ConvertO(setLicenseCodeWorkflow);
            if (setLicenseCodepropCount > 0)
            {
                callPayload.Body = setLicenseCode;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetLicenseStringResponse> SetLicenseString(Expression<Func<string>> setLicenseStringLicenseString, Expression<Func<string>> setLicenseStringWorkflow, Expression<Func<bool>> setLicenseStringStoreInRegistry = null)
        {
            var apiCallPath = "/DriverControl/SetLicenseString";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setLicenseString = new JObject();
            var setLicenseStringpropCount = 0;
            setLicenseStringpropCount++;
            setLicenseString["LicenseString"] = ExpressionConverter.ConvertO(setLicenseStringLicenseString);
            if (setLicenseStringStoreInRegistry != null)
            {
                setLicenseString["StoreInRegistry"] = ExpressionConverter.ConvertO(setLicenseStringStoreInRegistry);
                setLicenseStringpropCount++;
            }

            setLicenseStringpropCount++;
            setLicenseString["Workflow"] = ExpressionConverter.ConvertO(setLicenseStringWorkflow);
            if (setLicenseStringpropCount > 0)
            {
                callPayload.Body = setLicenseString;
            }

            return new ApiConnectionAction<SetLicenseStringResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLicenseStateResponse> GetLicenseState(Expression<Func<string>> getLicenseStateWorkflow)
        {
            var apiCallPath = "/DriverControl/GetLicenseState";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getLicenseState = new JObject();
            var getLicenseStatepropCount = 0;
            getLicenseStatepropCount++;
            getLicenseState["Workflow"] = ExpressionConverter.ConvertO(getLicenseStateWorkflow);
            if (getLicenseStatepropCount > 0)
            {
                callPayload.Body = getLicenseState;
            }

            return new ApiConnectionAction<GetLicenseStateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUITopmost(Expression<Func<string>> setRSAGUITopmostWorkflow, Expression<Func<bool>> setRSAGUITopmostTopMost = null)
        {
            var apiCallPath = "/DriverControl/SetRSAGUITopmost";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setRSAGUITopmost = new JObject();
            var setRSAGUITopmostpropCount = 0;
            if (setRSAGUITopmostTopMost != null)
            {
                setRSAGUITopmost["TopMost"] = ExpressionConverter.ConvertO(setRSAGUITopmostTopMost);
                setRSAGUITopmostpropCount++;
            }

            setRSAGUITopmostpropCount++;
            setRSAGUITopmost["Workflow"] = ExpressionConverter.ConvertO(setRSAGUITopmostWorkflow);
            if (setRSAGUITopmostpropCount > 0)
            {
                callPayload.Body = setRSAGUITopmost;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUIOpacity(Expression<Func<double>> setRSAGUIOpacityOpacity, Expression<Func<string>> setRSAGUIOpacityWorkflow)
        {
            var apiCallPath = "/DriverControl/SetRSAGUIOpacity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setRSAGUIOpacity = new JObject();
            var setRSAGUIOpacitypropCount = 0;
            setRSAGUIOpacitypropCount++;
            setRSAGUIOpacity["Opacity"] = ExpressionConverter.ConvertO(setRSAGUIOpacityOpacity);
            setRSAGUIOpacitypropCount++;
            setRSAGUIOpacity["Workflow"] = ExpressionConverter.ConvertO(setRSAGUIOpacityWorkflow);
            if (setRSAGUIOpacitypropCount > 0)
            {
                callPayload.Body = setRSAGUIOpacity;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRSAGUIPosition(Expression<Func<int>> setRSAGUIPositionX, Expression<Func<int>> setRSAGUIPositionY, Expression<Func<string>> setRSAGUIPositionWorkflow)
        {
            var apiCallPath = "/DriverControl/SetRSAGUIPosition";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setRSAGUIPosition = new JObject();
            var setRSAGUIPositionpropCount = 0;
            setRSAGUIPositionpropCount++;
            setRSAGUIPosition["X"] = ExpressionConverter.ConvertO(setRSAGUIPositionX);
            setRSAGUIPositionpropCount++;
            setRSAGUIPosition["Y"] = ExpressionConverter.ConvertO(setRSAGUIPositionY);
            setRSAGUIPositionpropCount++;
            setRSAGUIPosition["Workflow"] = ExpressionConverter.ConvertO(setRSAGUIPositionWorkflow);
            if (setRSAGUIPositionpropCount > 0)
            {
                callPayload.Body = setRSAGUIPosition;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction BringRSAGUIToFront(Expression<Func<string>> bringRSAGUIToFrontWorkflow, Expression<Func<bool>> bringRSAGUIToFrontFocus = null, Expression<Func<bool>> bringRSAGUIToFrontGlobalLeftMouseClick = null)
        {
            var apiCallPath = "/DriverControl/BringRSAGUIToFront";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var bringRSAGUIToFront = new JObject();
            var bringRSAGUIToFrontpropCount = 0;
            if (bringRSAGUIToFrontFocus != null)
            {
                bringRSAGUIToFront["Focus"] = ExpressionConverter.ConvertO(bringRSAGUIToFrontFocus);
                bringRSAGUIToFrontpropCount++;
            }

            if (bringRSAGUIToFrontGlobalLeftMouseClick != null)
            {
                bringRSAGUIToFront["GlobalLeftMouseClick"] = ExpressionConverter.ConvertO(bringRSAGUIToFrontGlobalLeftMouseClick);
                bringRSAGUIToFrontpropCount++;
            }

            bringRSAGUIToFrontpropCount++;
            bringRSAGUIToFront["Workflow"] = ExpressionConverter.ConvertO(bringRSAGUIToFrontWorkflow);
            if (bringRSAGUIToFrontpropCount > 0)
            {
                callPayload.Body = bringRSAGUIToFront;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DisconnectSession(Expression<Func<string>> disconnectSessionWorkflow, Expression<Func<int>> disconnectSessionSecondsToWait = null, Expression<Func<bool>> disconnectSessionDoNotDisconnectIfLocalAgent = null)
        {
            var apiCallPath = "/DriverControl/DisconnectSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var disconnectSession = new JObject();
            var disconnectSessionpropCount = 0;
            if (disconnectSessionSecondsToWait != null)
            {
                disconnectSession["SecondsToWait"] = ExpressionConverter.ConvertO(disconnectSessionSecondsToWait);
                disconnectSessionpropCount++;
            }

            if (disconnectSessionDoNotDisconnectIfLocalAgent != null)
            {
                disconnectSession["DoNotDisconnectIfLocalAgent"] = ExpressionConverter.ConvertO(disconnectSessionDoNotDisconnectIfLocalAgent);
                disconnectSessionpropCount++;
            }

            disconnectSessionpropCount++;
            disconnectSession["Workflow"] = ExpressionConverter.ConvertO(disconnectSessionWorkflow);
            if (disconnectSessionpropCount > 0)
            {
                callPayload.Body = disconnectSession;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction LogoffSession(Expression<Func<string>> logoffSessionWorkflow, Expression<Func<int>> logoffSessionSecondsToWait = null)
        {
            var apiCallPath = "/DriverControl/LogoffSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var logoffSession = new JObject();
            var logoffSessionpropCount = 0;
            if (logoffSessionSecondsToWait != null)
            {
                logoffSession["SecondsToWait"] = ExpressionConverter.ConvertO(logoffSessionSecondsToWait);
                logoffSessionpropCount++;
            }

            logoffSessionpropCount++;
            logoffSession["Workflow"] = ExpressionConverter.ConvertO(logoffSessionWorkflow);
            if (logoffSessionpropCount > 0)
            {
                callPayload.Body = logoffSession;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CloseRSAServer(Expression<Func<string>> closeRSAServerWorkflow, Expression<Func<int>> closeRSAServerSecondsToWait = null)
        {
            var apiCallPath = "/DriverControl/CloseRSAServer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var closeRSAServer = new JObject();
            var closeRSAServerpropCount = 0;
            if (closeRSAServerSecondsToWait != null)
            {
                closeRSAServer["SecondsToWait"] = ExpressionConverter.ConvertO(closeRSAServerSecondsToWait);
                closeRSAServerpropCount++;
            }

            closeRSAServerpropCount++;
            closeRSAServer["Workflow"] = ExpressionConverter.ConvertO(closeRSAServerWorkflow);
            if (closeRSAServerpropCount > 0)
            {
                callPayload.Body = closeRSAServer;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetRPACommandTimeout(Expression<Func<int>> setRPACommandTimeoutCommandTimeoutInSeconds, Expression<Func<string>> setRPACommandTimeoutWorkflow, Expression<Func<bool>> setRPACommandTimeoutTerminateTimedoutRPACommandThreads = null)
        {
            var apiCallPath = "/DriverControl/SetRPACommandTimeout";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setRPACommandTimeout = new JObject();
            var setRPACommandTimeoutpropCount = 0;
            setRPACommandTimeoutpropCount++;
            setRPACommandTimeout["CommandTimeoutInSeconds"] = ExpressionConverter.ConvertO(setRPACommandTimeoutCommandTimeoutInSeconds);
            if (setRPACommandTimeoutTerminateTimedoutRPACommandThreads != null)
            {
                setRPACommandTimeout["TerminateTimedoutRPACommandThreads"] = ExpressionConverter.ConvertO(setRPACommandTimeoutTerminateTimedoutRPACommandThreads);
                setRPACommandTimeoutpropCount++;
            }

            setRPACommandTimeoutpropCount++;
            setRPACommandTimeout["Workflow"] = ExpressionConverter.ConvertO(setRPACommandTimeoutWorkflow);
            if (setRPACommandTimeoutpropCount > 0)
            {
                callPayload.Body = setRPACommandTimeout;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction RunAlternativeIAConnect(Expression<Func<string>> runAlternativeIAConnectFilename, Expression<Func<string>> runAlternativeIAConnectWorkflow, Expression<Func<string>> runAlternativeIAConnectArguments = null, Expression<Func<bool>> runAlternativeIAConnectLoadIntoMemory = null)
        {
            var apiCallPath = "/DriverControl/RunAlternativeIAConnect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runAlternativeIAConnect = new JObject();
            var runAlternativeIAConnectpropCount = 0;
            runAlternativeIAConnectpropCount++;
            runAlternativeIAConnect["Filename"] = ExpressionConverter.ConvertO(runAlternativeIAConnectFilename);
            if (runAlternativeIAConnectArguments != null)
            {
                runAlternativeIAConnect["Arguments"] = ExpressionConverter.ConvertO(runAlternativeIAConnectArguments);
                runAlternativeIAConnectpropCount++;
            }

            if (runAlternativeIAConnectLoadIntoMemory != null)
            {
                runAlternativeIAConnect["LoadIntoMemory"] = ExpressionConverter.ConvertO(runAlternativeIAConnectLoadIntoMemory);
                runAlternativeIAConnectpropCount++;
            }

            runAlternativeIAConnectpropCount++;
            runAlternativeIAConnect["Workflow"] = ExpressionConverter.ConvertO(runAlternativeIAConnectWorkflow);
            if (runAlternativeIAConnectpropCount > 0)
            {
                callPayload.Body = runAlternativeIAConnect;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunAlternativeIAConnectSentFromDirectorResponse> RunAlternativeIAConnectSentFromDirector(Expression<Func<string>> runAlternativeIAConnectSentFromDirectorLocalFilename, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorWorkflow, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorRemoteFilename = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorCompress = null, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorArguments = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorPermitDowngrade = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorSkipVersionCheck = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorLoadIntoMemory = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorSaveToDiskEvenIfRunningFromMemory = null)
        {
            var apiCallPath = "/DriverControl/RunAlternativeIAConnectSentFromDirector";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runAlternativeIAConnectSentFromDirector = new JObject();
            var runAlternativeIAConnectSentFromDirectorpropCount = 0;
            runAlternativeIAConnectSentFromDirectorpropCount++;
            runAlternativeIAConnectSentFromDirector["LocalFilename"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorLocalFilename);
            if (runAlternativeIAConnectSentFromDirectorRemoteFilename != null)
            {
                runAlternativeIAConnectSentFromDirector["RemoteFilename"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorRemoteFilename);
                runAlternativeIAConnectSentFromDirectorpropCount++;
            }

            if (runAlternativeIAConnectSentFromDirectorCompress != null)
            {
                runAlternativeIAConnectSentFromDirector["Compress"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorCompress);
                runAlternativeIAConnectSentFromDirectorpropCount++;
            }

            if (runAlternativeIAConnectSentFromDirectorArguments != null)
            {
                runAlternativeIAConnectSentFromDirector["Arguments"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorArguments);
                runAlternativeIAConnectSentFromDirectorpropCount++;
            }

            if (runAlternativeIAConnectSentFromDirectorPermitDowngrade != null)
            {
                runAlternativeIAConnectSentFromDirector["PermitDowngrade"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorPermitDowngrade);
                runAlternativeIAConnectSentFromDirectorpropCount++;
            }

            if (runAlternativeIAConnectSentFromDirectorSkipVersionCheck != null)
            {
                runAlternativeIAConnectSentFromDirector["SkipVersionCheck"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorSkipVersionCheck);
                runAlternativeIAConnectSentFromDirectorpropCount++;
            }

            if (runAlternativeIAConnectSentFromDirectorLoadIntoMemory != null)
            {
                runAlternativeIAConnectSentFromDirector["LoadIntoMemory"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorLoadIntoMemory);
                runAlternativeIAConnectSentFromDirectorpropCount++;
            }

            if (runAlternativeIAConnectSentFromDirectorSaveToDiskEvenIfRunningFromMemory != null)
            {
                runAlternativeIAConnectSentFromDirector["SaveToDiskEvenIfRunningFromMemory"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorSaveToDiskEvenIfRunningFromMemory);
                runAlternativeIAConnectSentFromDirectorpropCount++;
            }

            runAlternativeIAConnectSentFromDirectorpropCount++;
            runAlternativeIAConnectSentFromDirector["Workflow"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorWorkflow);
            if (runAlternativeIAConnectSentFromDirectorpropCount > 0)
            {
                callPayload.Body = runAlternativeIAConnectSentFromDirector;
            }

            return new ApiConnectionAction<RunAlternativeIAConnectSentFromDirectorResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectAgentInfoResponse> GetIAConnectAgentInfo(Expression<Func<string>> getIAConnectAgentInfoWorkflow)
        {
            var apiCallPath = "/DriverControl/GetIAConnectAgentInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getIAConnectAgentInfo = new JObject();
            var getIAConnectAgentInfopropCount = 0;
            getIAConnectAgentInfopropCount++;
            getIAConnectAgentInfo["Workflow"] = ExpressionConverter.ConvertO(getIAConnectAgentInfoWorkflow);
            if (getIAConnectAgentInfopropCount > 0)
            {
                callPayload.Body = getIAConnectAgentInfo;
            }

            return new ApiConnectionAction<GetIAConnectAgentInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectAgentLogResponse> GetIAConnectAgentLog(Expression<Func<string>> getIAConnectAgentLogWorkflow, Expression<Func<bool>> getIAConnectAgentLogCompress = null, Expression<Func<bool>> getIAConnectAgentLogReturnLastCommandOnly = null, Expression<Func<bool>> getIAConnectAgentLogSaveLogToFile = null, Expression<Func<bool>> getIAConnectAgentLogPlaceLogContentInDataItem = null, Expression<Func<string>> getIAConnectAgentLogLocalSaveFolder = null, Expression<Func<bool>> getIAConnectAgentLogUseAgentLogFilename = null, Expression<Func<string>> getIAConnectAgentLogLocalSaveFilename = null, Expression<Func<int>> getIAConnectAgentLogMaxBytesToRead = null)
        {
            var apiCallPath = "/DriverControl/GetIAConnectAgentLog";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getIAConnectAgentLog = new JObject();
            var getIAConnectAgentLogpropCount = 0;
            if (getIAConnectAgentLogCompress != null)
            {
                getIAConnectAgentLog["Compress"] = ExpressionConverter.ConvertO(getIAConnectAgentLogCompress);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLogReturnLastCommandOnly != null)
            {
                getIAConnectAgentLog["ReturnLastCommandOnly"] = ExpressionConverter.ConvertO(getIAConnectAgentLogReturnLastCommandOnly);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLogSaveLogToFile != null)
            {
                getIAConnectAgentLog["SaveLogToFile"] = ExpressionConverter.ConvertO(getIAConnectAgentLogSaveLogToFile);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLogPlaceLogContentInDataItem != null)
            {
                getIAConnectAgentLog["PlaceLogContentInDataItem"] = ExpressionConverter.ConvertO(getIAConnectAgentLogPlaceLogContentInDataItem);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLogLocalSaveFolder != null)
            {
                getIAConnectAgentLog["LocalSaveFolder"] = ExpressionConverter.ConvertO(getIAConnectAgentLogLocalSaveFolder);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLogUseAgentLogFilename != null)
            {
                getIAConnectAgentLog["UseAgentLogFilename"] = ExpressionConverter.ConvertO(getIAConnectAgentLogUseAgentLogFilename);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLogLocalSaveFilename != null)
            {
                getIAConnectAgentLog["LocalSaveFilename"] = ExpressionConverter.ConvertO(getIAConnectAgentLogLocalSaveFilename);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLogMaxBytesToRead != null)
            {
                getIAConnectAgentLog["MaxBytesToRead"] = ExpressionConverter.ConvertO(getIAConnectAgentLogMaxBytesToRead);
                getIAConnectAgentLogpropCount++;
            }

            getIAConnectAgentLogpropCount++;
            getIAConnectAgentLog["Workflow"] = ExpressionConverter.ConvertO(getIAConnectAgentLogWorkflow);
            if (getIAConnectAgentLogpropCount > 0)
            {
                callPayload.Body = getIAConnectAgentLog;
            }

            return new ApiConnectionAction<GetIAConnectAgentLogResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ResetCommandStats(Expression<Func<string>> resetCommandStatsWorkflow)
        {
            var apiCallPath = "/DriverControl/ResetCommandStats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var resetCommandStats = new JObject();
            var resetCommandStatspropCount = 0;
            resetCommandStatspropCount++;
            resetCommandStats["Workflow"] = ExpressionConverter.ConvertO(resetCommandStatsWorkflow);
            if (resetCommandStatspropCount > 0)
            {
                callPayload.Body = resetCommandStats;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAllCommandStatsResponse> GetAllCommandStats(Expression<Func<string>> getAllCommandStatsWorkflow)
        {
            var apiCallPath = "/DriverControl/GetAllCommandStats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getAllCommandStats = new JObject();
            var getAllCommandStatspropCount = 0;
            getAllCommandStatspropCount++;
            getAllCommandStats["Workflow"] = ExpressionConverter.ConvertO(getAllCommandStatsWorkflow);
            if (getAllCommandStatspropCount > 0)
            {
                callPayload.Body = getAllCommandStats;
            }

            return new ApiConnectionAction<GetAllCommandStatsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<EnableNextHopResponse> EnableNextHop(Expression<Func<string>> enableNextHopWorkflow, Expression<Func<string>> enableNextHopNextHopDirectorAddress = null, Expression<Func<int>> enableNextHopNextHopDirectorTCPPort = null, Expression<Func<bool>> enableNextHopNextHopDirectorUsesHTTPS = null, Expression<Func<bool>> enableNextHopNextHopDirectorAddressIsLocalhostname = null, Expression<Func<bool>> enableNextHopNextHopDirectorAddressIsHostname = null, Expression<Func<bool>> enableNextHopNextHopDirectorAddressIsFQDN = null, Expression<Func<bool>> enableNextHopIncrementNextHopDirectorTCPPortBySessionId = null, Expression<Func<bool>> enableNextHopDisableBeforeEnable = null, Expression<Func<bool>> enableNextHopCheckNextHopDirectorIsRunning = null, Expression<Func<bool>> enableNextHopCheckNextHopAgentIsRunning = null, Expression<Func<bool>> enableNextHopNextHopDirectorAddressIsNamedPipe = null)
        {
            var apiCallPath = "/DriverControl/EnableNextHop";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var enableNextHop = new JObject();
            var enableNextHoppropCount = 0;
            if (enableNextHopNextHopDirectorAddress != null)
            {
                enableNextHop["NextHopDirectorAddress"] = ExpressionConverter.ConvertO(enableNextHopNextHopDirectorAddress);
                enableNextHoppropCount++;
            }

            if (enableNextHopNextHopDirectorTCPPort != null)
            {
                enableNextHop["NextHopDirectorTCPPort"] = ExpressionConverter.ConvertO(enableNextHopNextHopDirectorTCPPort);
                enableNextHoppropCount++;
            }

            if (enableNextHopNextHopDirectorUsesHTTPS != null)
            {
                enableNextHop["NextHopDirectorUsesHTTPS"] = ExpressionConverter.ConvertO(enableNextHopNextHopDirectorUsesHTTPS);
                enableNextHoppropCount++;
            }

            if (enableNextHopNextHopDirectorAddressIsLocalhostname != null)
            {
                enableNextHop["NextHopDirectorAddressIsLocalhostname"] = ExpressionConverter.ConvertO(enableNextHopNextHopDirectorAddressIsLocalhostname);
                enableNextHoppropCount++;
            }

            if (enableNextHopNextHopDirectorAddressIsHostname != null)
            {
                enableNextHop["NextHopDirectorAddressIsHostname"] = ExpressionConverter.ConvertO(enableNextHopNextHopDirectorAddressIsHostname);
                enableNextHoppropCount++;
            }

            if (enableNextHopNextHopDirectorAddressIsFQDN != null)
            {
                enableNextHop["NextHopDirectorAddressIsFQDN"] = ExpressionConverter.ConvertO(enableNextHopNextHopDirectorAddressIsFQDN);
                enableNextHoppropCount++;
            }

            if (enableNextHopIncrementNextHopDirectorTCPPortBySessionId != null)
            {
                enableNextHop["IncrementNextHopDirectorTCPPortBySessionId"] = ExpressionConverter.ConvertO(enableNextHopIncrementNextHopDirectorTCPPortBySessionId);
                enableNextHoppropCount++;
            }

            if (enableNextHopDisableBeforeEnable != null)
            {
                enableNextHop["DisableBeforeEnable"] = ExpressionConverter.ConvertO(enableNextHopDisableBeforeEnable);
                enableNextHoppropCount++;
            }

            if (enableNextHopCheckNextHopDirectorIsRunning != null)
            {
                enableNextHop["CheckNextHopDirectorIsRunning"] = ExpressionConverter.ConvertO(enableNextHopCheckNextHopDirectorIsRunning);
                enableNextHoppropCount++;
            }

            if (enableNextHopCheckNextHopAgentIsRunning != null)
            {
                enableNextHop["CheckNextHopAgentIsRunning"] = ExpressionConverter.ConvertO(enableNextHopCheckNextHopAgentIsRunning);
                enableNextHoppropCount++;
            }

            if (enableNextHopNextHopDirectorAddressIsNamedPipe != null)
            {
                enableNextHop["NextHopDirectorAddressIsNamedPipe"] = ExpressionConverter.ConvertO(enableNextHopNextHopDirectorAddressIsNamedPipe);
                enableNextHoppropCount++;
            }

            enableNextHoppropCount++;
            enableNextHop["Workflow"] = ExpressionConverter.ConvertO(enableNextHopWorkflow);
            if (enableNextHoppropCount > 0)
            {
                callPayload.Body = enableNextHop;
            }

            return new ApiConnectionAction<EnableNextHopResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DisableNextHop(Expression<Func<string>> disableNextHopWorkflow)
        {
            var apiCallPath = "/DriverControl/DisableNextHop";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var disableNextHop = new JObject();
            var disableNextHoppropCount = 0;
            disableNextHoppropCount++;
            disableNextHop["Workflow"] = ExpressionConverter.ConvertO(disableNextHopWorkflow);
            if (disableNextHoppropCount > 0)
            {
                callPayload.Body = disableNextHop;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetNextHopStatusResponse> GetNextHopStatus(Expression<Func<string>> getNextHopStatusWorkflow, Expression<Func<bool>> getNextHopStatusCheckNextHopDirectorIsRunning = null, Expression<Func<bool>> getNextHopStatusCheckNextHopAgentIsRunning = null)
        {
            var apiCallPath = "/DriverControl/GetNextHopStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getNextHopStatus = new JObject();
            var getNextHopStatuspropCount = 0;
            if (getNextHopStatusCheckNextHopDirectorIsRunning != null)
            {
                getNextHopStatus["CheckNextHopDirectorIsRunning"] = ExpressionConverter.ConvertO(getNextHopStatusCheckNextHopDirectorIsRunning);
                getNextHopStatuspropCount++;
            }

            if (getNextHopStatusCheckNextHopAgentIsRunning != null)
            {
                getNextHopStatus["CheckNextHopAgentIsRunning"] = ExpressionConverter.ConvertO(getNextHopStatusCheckNextHopAgentIsRunning);
                getNextHopStatuspropCount++;
            }

            getNextHopStatuspropCount++;
            getNextHopStatus["Workflow"] = ExpressionConverter.ConvertO(getNextHopStatusWorkflow);
            if (getNextHopStatuspropCount > 0)
            {
                callPayload.Body = getNextHopStatus;
            }

            return new ApiConnectionAction<GetNextHopStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForNextHopSessionToConnectResponse> WaitForNextHopSessionToConnect(Expression<Func<string>> waitForNextHopSessionToConnectWorkflow, Expression<Func<string>> waitForNextHopSessionToConnectNextHopDirectorAddress = null, Expression<Func<int>> waitForNextHopSessionToConnectNextHopDirectorTCPPort = null, Expression<Func<bool>> waitForNextHopSessionToConnectNextHopDirectorUsesHTTPS = null, Expression<Func<bool>> waitForNextHopSessionToConnectNextHopDirectorAddressIsLocalhostname = null, Expression<Func<bool>> waitForNextHopSessionToConnectNextHopDirectorAddressIsHostname = null, Expression<Func<bool>> waitForNextHopSessionToConnectNextHopDirectorAddressIsFQDN = null, Expression<Func<bool>> waitForNextHopSessionToConnectIncrementNextHopDirectorTCPPortBySessionId = null, Expression<Func<double>> waitForNextHopSessionToConnectSecondsToWait = null, Expression<Func<bool>> waitForNextHopSessionToConnectNextHopDirectorAddressIsNamedPipe = null, Expression<Func<bool>> waitForNextHopSessionToConnectDisableExistingNextHop = null)
        {
            var apiCallPath = "/DriverControl/WaitForNextHopSessionToConnect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var waitForNextHopSessionToConnect = new JObject();
            var waitForNextHopSessionToConnectpropCount = 0;
            if (waitForNextHopSessionToConnectNextHopDirectorAddress != null)
            {
                waitForNextHopSessionToConnect["NextHopDirectorAddress"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectNextHopDirectorAddress);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectNextHopDirectorTCPPort != null)
            {
                waitForNextHopSessionToConnect["NextHopDirectorTCPPort"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectNextHopDirectorTCPPort);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectNextHopDirectorUsesHTTPS != null)
            {
                waitForNextHopSessionToConnect["NextHopDirectorUsesHTTPS"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectNextHopDirectorUsesHTTPS);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectNextHopDirectorAddressIsLocalhostname != null)
            {
                waitForNextHopSessionToConnect["NextHopDirectorAddressIsLocalhostname"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectNextHopDirectorAddressIsLocalhostname);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectNextHopDirectorAddressIsHostname != null)
            {
                waitForNextHopSessionToConnect["NextHopDirectorAddressIsHostname"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectNextHopDirectorAddressIsHostname);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectNextHopDirectorAddressIsFQDN != null)
            {
                waitForNextHopSessionToConnect["NextHopDirectorAddressIsFQDN"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectNextHopDirectorAddressIsFQDN);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectIncrementNextHopDirectorTCPPortBySessionId != null)
            {
                waitForNextHopSessionToConnect["IncrementNextHopDirectorTCPPortBySessionId"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectIncrementNextHopDirectorTCPPortBySessionId);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectSecondsToWait != null)
            {
                waitForNextHopSessionToConnect["SecondsToWait"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectSecondsToWait);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectNextHopDirectorAddressIsNamedPipe != null)
            {
                waitForNextHopSessionToConnect["NextHopDirectorAddressIsNamedPipe"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectNextHopDirectorAddressIsNamedPipe);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectDisableExistingNextHop != null)
            {
                waitForNextHopSessionToConnect["DisableExistingNextHop"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectDisableExistingNextHop);
                waitForNextHopSessionToConnectpropCount++;
            }

            waitForNextHopSessionToConnectpropCount++;
            waitForNextHopSessionToConnect["Workflow"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectWorkflow);
            if (waitForNextHopSessionToConnectpropCount > 0)
            {
                callPayload.Body = waitForNextHopSessionToConnect;
            }

            return new ApiConnectionAction<WaitForNextHopSessionToConnectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ConfigureNextHopDirector(Expression<Func<string>> configureNextHopDirectorWorkflow, Expression<Func<bool>> configureNextHopDirectorSOAPEnabled = null, Expression<Func<bool>> configureNextHopDirectorRESTEnabled = null, Expression<Func<bool>> configureNextHopDirectorWebServerEnabled = null, Expression<Func<bool>> configureNextHopDirectorDirectorIsLocalhostOnly = null, Expression<Func<int>> configureNextHopDirectorSOAPTCPPort = null, Expression<Func<int>> configureNextHopDirectorRESTTCPPort = null, Expression<Func<bool>> configureNextHopDirectorSOAPUsesHTTPS = null, Expression<Func<bool>> configureNextHopDirectorRESTUsesHTTPS = null, Expression<Func<bool>> configureNextHopDirectorIncrementDirectorTCPPortBySessionId = null, Expression<Func<bool>> configureNextHopDirectorSOAPUsesUserAuthentication = null, Expression<Func<bool>> configureNextHopDirectorRESTUsesUserAuthentication = null, Expression<Func<bool>> configureNextHopDirectorCommandNamedPipeEnabled = null)
        {
            var apiCallPath = "/DriverControl/ConfigureNextHopDirector";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var configureNextHopDirector = new JObject();
            var configureNextHopDirectorpropCount = 0;
            if (configureNextHopDirectorSOAPEnabled != null)
            {
                configureNextHopDirector["SOAPEnabled"] = ExpressionConverter.ConvertO(configureNextHopDirectorSOAPEnabled);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorRESTEnabled != null)
            {
                configureNextHopDirector["RESTEnabled"] = ExpressionConverter.ConvertO(configureNextHopDirectorRESTEnabled);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorWebServerEnabled != null)
            {
                configureNextHopDirector["WebServerEnabled"] = ExpressionConverter.ConvertO(configureNextHopDirectorWebServerEnabled);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorDirectorIsLocalhostOnly != null)
            {
                configureNextHopDirector["DirectorIsLocalhostOnly"] = ExpressionConverter.ConvertO(configureNextHopDirectorDirectorIsLocalhostOnly);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorSOAPTCPPort != null)
            {
                configureNextHopDirector["SOAPTCPPort"] = ExpressionConverter.ConvertO(configureNextHopDirectorSOAPTCPPort);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorRESTTCPPort != null)
            {
                configureNextHopDirector["RESTTCPPort"] = ExpressionConverter.ConvertO(configureNextHopDirectorRESTTCPPort);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorSOAPUsesHTTPS != null)
            {
                configureNextHopDirector["SOAPUsesHTTPS"] = ExpressionConverter.ConvertO(configureNextHopDirectorSOAPUsesHTTPS);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorRESTUsesHTTPS != null)
            {
                configureNextHopDirector["RESTUsesHTTPS"] = ExpressionConverter.ConvertO(configureNextHopDirectorRESTUsesHTTPS);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorIncrementDirectorTCPPortBySessionId != null)
            {
                configureNextHopDirector["IncrementDirectorTCPPortBySessionId"] = ExpressionConverter.ConvertO(configureNextHopDirectorIncrementDirectorTCPPortBySessionId);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorSOAPUsesUserAuthentication != null)
            {
                configureNextHopDirector["SOAPUsesUserAuthentication"] = ExpressionConverter.ConvertO(configureNextHopDirectorSOAPUsesUserAuthentication);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorRESTUsesUserAuthentication != null)
            {
                configureNextHopDirector["RESTUsesUserAuthentication"] = ExpressionConverter.ConvertO(configureNextHopDirectorRESTUsesUserAuthentication);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorCommandNamedPipeEnabled != null)
            {
                configureNextHopDirector["CommandNamedPipeEnabled"] = ExpressionConverter.ConvertO(configureNextHopDirectorCommandNamedPipeEnabled);
                configureNextHopDirectorpropCount++;
            }

            configureNextHopDirectorpropCount++;
            configureNextHopDirector["Workflow"] = ExpressionConverter.ConvertO(configureNextHopDirectorWorkflow);
            if (configureNextHopDirectorpropCount > 0)
            {
                callPayload.Body = configureNextHopDirector;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ResetNextHopDirectorSettings(Expression<Func<string>> resetNextHopDirectorSettingsWorkflow)
        {
            var apiCallPath = "/DriverControl/ResetNextHopDirectorSettings";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var resetNextHopDirectorSettings = new JObject();
            var resetNextHopDirectorSettingspropCount = 0;
            resetNextHopDirectorSettingspropCount++;
            resetNextHopDirectorSettings["Workflow"] = ExpressionConverter.ConvertO(resetNextHopDirectorSettingsWorkflow);
            if (resetNextHopDirectorSettingspropCount > 0)
            {
                callPayload.Body = resetNextHopDirectorSettings;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WorkflowCompleted(Expression<Func<string>> workflowCompletedWorkflow)
        {
            var apiCallPath = "/DriverControl/WorkflowCompleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var workflowCompleted = new JObject();
            var workflowCompletedpropCount = 0;
            workflowCompletedpropCount++;
            workflowCompleted["Workflow"] = ExpressionConverter.ConvertO(workflowCompletedWorkflow);
            if (workflowCompletedpropCount > 0)
            {
                callPayload.Body = workflowCompleted;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RaiseExceptionResponse> RaiseException(Expression<Func<string>> raiseExceptionInputException = null, Expression<Func<string>> raiseExceptionExceptionMessage = null)
        {
            var apiCallPath = "/DriverControl/RaiseException";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var raiseException = new JObject();
            var raiseExceptionpropCount = 0;
            if (raiseExceptionInputException != null)
            {
                raiseException["InputException"] = ExpressionConverter.ConvertO(raiseExceptionInputException);
                raiseExceptionpropCount++;
            }

            if (raiseExceptionExceptionMessage != null)
            {
                raiseException["ExceptionMessage"] = ExpressionConverter.ConvertO(raiseExceptionExceptionMessage);
                raiseExceptionpropCount++;
            }

            if (raiseExceptionpropCount > 0)
            {
                callPayload.Body = raiseException;
            }

            return new ApiConnectionAction<RaiseExceptionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UpdateOrchestratorFlowStatsResultResponse> UpdateOrchestratorFlowStatsResult(Expression<Func<string>> updateOrchestratorFlowStatsResultWorkflow, Expression<Func<bool>> updateOrchestratorFlowStatsResultFlowLastActionSuccess = null, Expression<Func<string>> updateOrchestratorFlowStatsResultFlowLastActionErrorMessage = null, Expression<Func<int>> updateOrchestratorFlowStatsResultFlowLastActionCode = null)
        {
            var apiCallPath = "/DriverControl/UpdateOrchestratorFlowStatsResult";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var updateOrchestratorFlowStatsResult = new JObject();
            var updateOrchestratorFlowStatsResultpropCount = 0;
            if (updateOrchestratorFlowStatsResultFlowLastActionSuccess != null)
            {
                updateOrchestratorFlowStatsResult["FlowLastActionSuccess"] = ExpressionConverter.ConvertO(updateOrchestratorFlowStatsResultFlowLastActionSuccess);
                updateOrchestratorFlowStatsResultpropCount++;
            }

            if (updateOrchestratorFlowStatsResultFlowLastActionErrorMessage != null)
            {
                updateOrchestratorFlowStatsResult["FlowLastActionErrorMessage"] = ExpressionConverter.ConvertO(updateOrchestratorFlowStatsResultFlowLastActionErrorMessage);
                updateOrchestratorFlowStatsResultpropCount++;
            }

            if (updateOrchestratorFlowStatsResultFlowLastActionCode != null)
            {
                updateOrchestratorFlowStatsResult["FlowLastActionCode"] = ExpressionConverter.ConvertO(updateOrchestratorFlowStatsResultFlowLastActionCode);
                updateOrchestratorFlowStatsResultpropCount++;
            }

            updateOrchestratorFlowStatsResultpropCount++;
            updateOrchestratorFlowStatsResult["Workflow"] = ExpressionConverter.ConvertO(updateOrchestratorFlowStatsResultWorkflow);
            if (updateOrchestratorFlowStatsResultpropCount > 0)
            {
                callPayload.Body = updateOrchestratorFlowStatsResult;
            }

            return new ApiConnectionAction<UpdateOrchestratorFlowStatsResultResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLastFailedActionFromOrchestratorFlowStatsResponse> GetLastFailedActionFromOrchestratorFlowStats(Expression<Func<string>> getLastFailedActionFromOrchestratorFlowStatsWorkflow)
        {
            var apiCallPath = "/DriverControl/GetLastFailedActionFromOrchestratorFlowStats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getLastFailedActionFromOrchestratorFlowStats = new JObject();
            var getLastFailedActionFromOrchestratorFlowStatspropCount = 0;
            getLastFailedActionFromOrchestratorFlowStatspropCount++;
            getLastFailedActionFromOrchestratorFlowStats["Workflow"] = ExpressionConverter.ConvertO(getLastFailedActionFromOrchestratorFlowStatsWorkflow);
            if (getLastFailedActionFromOrchestratorFlowStatspropCount > 0)
            {
                callPayload.Body = getLastFailedActionFromOrchestratorFlowStats;
            }

            return new ApiConnectionAction<GetLastFailedActionFromOrchestratorFlowStatsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorFlowStatsResponse> GetOrchestratorFlowStats(Expression<Func<int>> getOrchestratorFlowStatsWithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorFlowStatsSearchFlowName = null, Expression<Func<bool>> getOrchestratorFlowStatsSearchFlowLastActionResult = null, Expression<Func<string>> getOrchestratorFlowStatsSearchFlowStartTimeStartWindow = null, Expression<Func<string>> getOrchestratorFlowStatsSearchFlowStartTimeEndWindow = null)
        {
            var apiCallPath = "/DriverControl/GetOrchestratorFlowStats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getOrchestratorFlowStats = new JObject();
            var getOrchestratorFlowStatspropCount = 0;
            if (getOrchestratorFlowStatsWithinLastNumberOfDays != null)
            {
                getOrchestratorFlowStats["WithinLastNumberOfDays"] = ExpressionConverter.ConvertO(getOrchestratorFlowStatsWithinLastNumberOfDays);
                getOrchestratorFlowStatspropCount++;
            }

            if (getOrchestratorFlowStatsSearchFlowName != null)
            {
                getOrchestratorFlowStats["SearchFlowName"] = ExpressionConverter.ConvertO(getOrchestratorFlowStatsSearchFlowName);
                getOrchestratorFlowStatspropCount++;
            }

            if (getOrchestratorFlowStatsSearchFlowLastActionResult != null)
            {
                getOrchestratorFlowStats["SearchFlowLastActionResult"] = ExpressionConverter.ConvertO(getOrchestratorFlowStatsSearchFlowLastActionResult);
                getOrchestratorFlowStatspropCount++;
            }

            if (getOrchestratorFlowStatsSearchFlowStartTimeStartWindow != null)
            {
                getOrchestratorFlowStats["SearchFlowStartTimeStartWindow"] = ExpressionConverter.ConvertO(getOrchestratorFlowStatsSearchFlowStartTimeStartWindow);
                getOrchestratorFlowStatspropCount++;
            }

            if (getOrchestratorFlowStatsSearchFlowStartTimeEndWindow != null)
            {
                getOrchestratorFlowStats["SearchFlowStartTimeEndWindow"] = ExpressionConverter.ConvertO(getOrchestratorFlowStatsSearchFlowStartTimeEndWindow);
                getOrchestratorFlowStatspropCount++;
            }

            if (getOrchestratorFlowStatspropCount > 0)
            {
                callPayload.Body = getOrchestratorFlowStats;
            }

            return new ApiConnectionAction<GetOrchestratorFlowStatsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerAvailabilityStatsResponse> GetOrchestratorWorkerAvailabilityStats(Expression<Func<int>> getOrchestratorWorkerAvailabilityStatsWithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorWorkerAvailabilityStatsSearchFlowName = null, Expression<Func<string>> getOrchestratorWorkerAvailabilityStatsSearchFlowStartTimeStartWindow = null)
        {
            var apiCallPath = "/DriverControl/GetOrchestratorWorkerAvailabilityStats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getOrchestratorWorkerAvailabilityStats = new JObject();
            var getOrchestratorWorkerAvailabilityStatspropCount = 0;
            if (getOrchestratorWorkerAvailabilityStatsWithinLastNumberOfDays != null)
            {
                getOrchestratorWorkerAvailabilityStats["WithinLastNumberOfDays"] = ExpressionConverter.ConvertO(getOrchestratorWorkerAvailabilityStatsWithinLastNumberOfDays);
                getOrchestratorWorkerAvailabilityStatspropCount++;
            }

            if (getOrchestratorWorkerAvailabilityStatsSearchFlowName != null)
            {
                getOrchestratorWorkerAvailabilityStats["SearchFlowName"] = ExpressionConverter.ConvertO(getOrchestratorWorkerAvailabilityStatsSearchFlowName);
                getOrchestratorWorkerAvailabilityStatspropCount++;
            }

            if (getOrchestratorWorkerAvailabilityStatsSearchFlowStartTimeStartWindow != null)
            {
                getOrchestratorWorkerAvailabilityStats["SearchFlowStartTimeStartWindow"] = ExpressionConverter.ConvertO(getOrchestratorWorkerAvailabilityStatsSearchFlowStartTimeStartWindow);
                getOrchestratorWorkerAvailabilityStatspropCount++;
            }

            if (getOrchestratorWorkerAvailabilityStatspropCount > 0)
            {
                callPayload.Body = getOrchestratorWorkerAvailabilityStats;
            }

            return new ApiConnectionAction<GetOrchestratorWorkerAvailabilityStatsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerFlowUsageHeatmapResponse> GetOrchestratorWorkerFlowUsageHeatmap(Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapSearchStartDateStartWindow, Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapSearchStartDateEndWindow, Expression<Func<int>> getOrchestratorWorkerFlowUsageHeatmapTimeZoneMinutesOffsetFromUTC = null, Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapWorkerNames = null)
        {
            var apiCallPath = "/DriverControl/GetOrchestratorWorkerFlowUsageHeatmap";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getOrchestratorWorkerFlowUsageHeatmap = new JObject();
            var getOrchestratorWorkerFlowUsageHeatmappropCount = 0;
            getOrchestratorWorkerFlowUsageHeatmappropCount++;
            getOrchestratorWorkerFlowUsageHeatmap["SearchStartDateStartWindow"] = ExpressionConverter.ConvertO(getOrchestratorWorkerFlowUsageHeatmapSearchStartDateStartWindow);
            getOrchestratorWorkerFlowUsageHeatmappropCount++;
            getOrchestratorWorkerFlowUsageHeatmap["SearchStartDateEndWindow"] = ExpressionConverter.ConvertO(getOrchestratorWorkerFlowUsageHeatmapSearchStartDateEndWindow);
            if (getOrchestratorWorkerFlowUsageHeatmapTimeZoneMinutesOffsetFromUTC != null)
            {
                getOrchestratorWorkerFlowUsageHeatmap["TimeZoneMinutesOffsetFromUTC"] = ExpressionConverter.ConvertO(getOrchestratorWorkerFlowUsageHeatmapTimeZoneMinutesOffsetFromUTC);
                getOrchestratorWorkerFlowUsageHeatmappropCount++;
            }

            if (getOrchestratorWorkerFlowUsageHeatmapWorkerNames != null)
            {
                getOrchestratorWorkerFlowUsageHeatmap["WorkerNames"] = ExpressionConverter.ConvertO(getOrchestratorWorkerFlowUsageHeatmapWorkerNames);
                getOrchestratorWorkerFlowUsageHeatmappropCount++;
            }

            if (getOrchestratorWorkerFlowUsageHeatmappropCount > 0)
            {
                callPayload.Body = getOrchestratorWorkerFlowUsageHeatmap;
            }

            return new ApiConnectionAction<GetOrchestratorWorkerFlowUsageHeatmapResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorLoginHistoryResponse> GetOrchestratorLoginHistory(Expression<Func<int>> getOrchestratorLoginHistoryWithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorLoginHistorySearchByEmail = null, Expression<Func<string>> getOrchestratorLoginHistorySearchLoginHistoryTimeStartWindow = null, Expression<Func<string>> getOrchestratorLoginHistorySearchLoginHistoryTimeEndWindow = null)
        {
            var apiCallPath = "/DriverControl/GetOrchestratorLoginHistory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getOrchestratorLoginHistory = new JObject();
            var getOrchestratorLoginHistorypropCount = 0;
            if (getOrchestratorLoginHistoryWithinLastNumberOfDays != null)
            {
                getOrchestratorLoginHistory["WithinLastNumberOfDays"] = ExpressionConverter.ConvertO(getOrchestratorLoginHistoryWithinLastNumberOfDays);
                getOrchestratorLoginHistorypropCount++;
            }

            if (getOrchestratorLoginHistorySearchByEmail != null)
            {
                getOrchestratorLoginHistory["SearchByEmail"] = ExpressionConverter.ConvertO(getOrchestratorLoginHistorySearchByEmail);
                getOrchestratorLoginHistorypropCount++;
            }

            if (getOrchestratorLoginHistorySearchLoginHistoryTimeStartWindow != null)
            {
                getOrchestratorLoginHistory["SearchLoginHistoryTimeStartWindow"] = ExpressionConverter.ConvertO(getOrchestratorLoginHistorySearchLoginHistoryTimeStartWindow);
                getOrchestratorLoginHistorypropCount++;
            }

            if (getOrchestratorLoginHistorySearchLoginHistoryTimeEndWindow != null)
            {
                getOrchestratorLoginHistory["SearchLoginHistoryTimeEndWindow"] = ExpressionConverter.ConvertO(getOrchestratorLoginHistorySearchLoginHistoryTimeEndWindow);
                getOrchestratorLoginHistorypropCount++;
            }

            if (getOrchestratorLoginHistorypropCount > 0)
            {
                callPayload.Body = getOrchestratorLoginHistory;
            }

            return new ApiConnectionAction<GetOrchestratorLoginHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetLocalLoggingLevel(Expression<Func<int>> setLocalLoggingLevelLoggingLevel, Expression<Func<string>> setLocalLoggingLevelWorkflow)
        {
            var apiCallPath = "/DriverControl/SetLocalLoggingLevel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setLocalLoggingLevel = new JObject();
            var setLocalLoggingLevelpropCount = 0;
            setLocalLoggingLevelpropCount++;
            setLocalLoggingLevel["LoggingLevel"] = ExpressionConverter.ConvertO(setLocalLoggingLevelLoggingLevel);
            setLocalLoggingLevelpropCount++;
            setLocalLoggingLevel["Workflow"] = ExpressionConverter.ConvertO(setLocalLoggingLevelWorkflow);
            if (setLocalLoggingLevelpropCount > 0)
            {
                callPayload.Body = setLocalLoggingLevel;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunCommandResponse> RunCommand(Expression<Func<string>> runCommandCommandName, Expression<Func<string>> runCommandWorkflow, Expression<Func<string>> runCommandInputJSON = null)
        {
            var apiCallPath = "/DriverControl/RunCommand";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runCommand = new JObject();
            var runCommandpropCount = 0;
            runCommandpropCount++;
            runCommand["CommandName"] = ExpressionConverter.ConvertO(runCommandCommandName);
            if (runCommandInputJSON != null)
            {
                runCommand["InputJSON"] = ExpressionConverter.ConvertO(runCommandInputJSON);
                runCommandpropCount++;
            }

            runCommandpropCount++;
            runCommand["Workflow"] = ExpressionConverter.ConvertO(runCommandWorkflow);
            if (runCommandpropCount > 0)
            {
                callPayload.Body = runCommand;
            }

            return new ApiConnectionAction<RunCommandResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLocalLoggingLevelResponse> GetLocalLoggingLevel(Expression<Func<string>> getLocalLoggingLevelWorkflow)
        {
            var apiCallPath = "/DriverControl/GetLocalLoggingLevel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getLocalLoggingLevel = new JObject();
            var getLocalLoggingLevelpropCount = 0;
            getLocalLoggingLevelpropCount++;
            getLocalLoggingLevel["Workflow"] = ExpressionConverter.ConvertO(getLocalLoggingLevelWorkflow);
            if (getLocalLoggingLevelpropCount > 0)
            {
                callPayload.Body = getLocalLoggingLevel;
            }

            return new ApiConnectionAction<GetLocalLoggingLevelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteClientTypeResponse> GetRemoteClientType(Expression<Func<string>> getRemoteClientTypeWorkflow)
        {
            var apiCallPath = "/DriverControl/GetRemoteClientType";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRemoteClientType = new JObject();
            var getRemoteClientTypepropCount = 0;
            getRemoteClientTypepropCount++;
            getRemoteClientType["Workflow"] = ExpressionConverter.ConvertO(getRemoteClientTypeWorkflow);
            if (getRemoteClientTypepropCount > 0)
            {
                callPayload.Body = getRemoteClientType;
            }

            return new ApiConnectionAction<GetRemoteClientTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectDirectorInfoResponse> GetIAConnectDirectorInfo(Expression<Func<string>> getIAConnectDirectorInfoWorkflow)
        {
            var apiCallPath = "/DriverControl/GetIAConnectDirectorInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getIAConnectDirectorInfo = new JObject();
            var getIAConnectDirectorInfopropCount = 0;
            getIAConnectDirectorInfopropCount++;
            getIAConnectDirectorInfo["Workflow"] = ExpressionConverter.ConvertO(getIAConnectDirectorInfoWorkflow);
            if (getIAConnectDirectorInfopropCount > 0)
            {
                callPayload.Body = getIAConnectDirectorInfo;
            }

            return new ApiConnectionAction<GetIAConnectDirectorInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAvailableIAConnectSessionsResponse> GetAvailableIAConnectSessions(Expression<Func<string>> getAvailableIAConnectSessionsWorkflow)
        {
            var apiCallPath = "/DriverControl/GetAvailableIAConnectSessions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getAvailableIAConnectSessions = new JObject();
            var getAvailableIAConnectSessionspropCount = 0;
            getAvailableIAConnectSessionspropCount++;
            getAvailableIAConnectSessions["Workflow"] = ExpressionConverter.ConvertO(getAvailableIAConnectSessionsWorkflow);
            if (getAvailableIAConnectSessionspropCount > 0)
            {
                callPayload.Body = getAvailableIAConnectSessions;
            }

            return new ApiConnectionAction<GetAvailableIAConnectSessionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AttachToIAConnectSessionByName(Expression<Func<string>> attachToIAConnectSessionByNameIAConnectSessionName, Expression<Func<string>> attachToIAConnectSessionByNameWorkflow, Expression<Func<bool>> attachToIAConnectSessionByNameVirtualChannelMustBeConnected = null)
        {
            var apiCallPath = "/DriverControl/AttachToIAConnectSessionByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var attachToIAConnectSessionByName = new JObject();
            var attachToIAConnectSessionByNamepropCount = 0;
            attachToIAConnectSessionByNamepropCount++;
            attachToIAConnectSessionByName["IAConnectSessionName"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByNameIAConnectSessionName);
            if (attachToIAConnectSessionByNameVirtualChannelMustBeConnected != null)
            {
                attachToIAConnectSessionByName["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByNameVirtualChannelMustBeConnected);
                attachToIAConnectSessionByNamepropCount++;
            }

            attachToIAConnectSessionByNamepropCount++;
            attachToIAConnectSessionByName["Workflow"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByNameWorkflow);
            if (attachToIAConnectSessionByNamepropCount > 0)
            {
                callPayload.Body = attachToIAConnectSessionByName;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToTier1IAConnectSessionResponse> AttachToTier1IAConnectSession(Expression<Func<string>> attachToTier1IAConnectSessionWorkflow, Expression<Func<bool>> attachToTier1IAConnectSessionVirtualChannelMustBeConnected = null)
        {
            var apiCallPath = "/DriverControl/AttachToTier1IAConnectSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var attachToTier1IAConnectSession = new JObject();
            var attachToTier1IAConnectSessionpropCount = 0;
            if (attachToTier1IAConnectSessionVirtualChannelMustBeConnected != null)
            {
                attachToTier1IAConnectSession["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(attachToTier1IAConnectSessionVirtualChannelMustBeConnected);
                attachToTier1IAConnectSessionpropCount++;
            }

            attachToTier1IAConnectSessionpropCount++;
            attachToTier1IAConnectSession["Workflow"] = ExpressionConverter.ConvertO(attachToTier1IAConnectSessionWorkflow);
            if (attachToTier1IAConnectSessionpropCount > 0)
            {
                callPayload.Body = attachToTier1IAConnectSession;
            }

            return new ApiConnectionAction<AttachToTier1IAConnectSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToIAConnectSessionByIndexResponse> AttachToIAConnectSessionByIndex(Expression<Func<string>> attachToIAConnectSessionByIndexWorkflow, Expression<Func<attachToIAConnectSessionByIndexSearchIAConnectSessionTypeInput>> attachToIAConnectSessionByIndexSearchIAConnectSessionType = null, Expression<Func<int>> attachToIAConnectSessionByIndexSearchIAConnectSessionIndex = null, Expression<Func<int>> attachToIAConnectSessionByIndexTimeToWaitInSeconds = null, Expression<Func<bool>> attachToIAConnectSessionByIndexRaiseExceptionIfTimedout = null, Expression<Func<bool>> attachToIAConnectSessionByIndexVirtualChannelMustBeConnected = null, Expression<Func<bool>> attachToIAConnectSessionByIndexOnlyCountSessionsNotSeenBefore = null)
        {
            var apiCallPath = "/DriverControl/AttachToIAConnectSessionByIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var attachToIAConnectSessionByIndex = new JObject();
            var attachToIAConnectSessionByIndexpropCount = 0;
            if (attachToIAConnectSessionByIndexSearchIAConnectSessionType != null)
            {
                attachToIAConnectSessionByIndex["SearchIAConnectSessionType"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexSearchIAConnectSessionType);
                attachToIAConnectSessionByIndexpropCount++;
            }

            if (attachToIAConnectSessionByIndexSearchIAConnectSessionIndex != null)
            {
                attachToIAConnectSessionByIndex["SearchIAConnectSessionIndex"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexSearchIAConnectSessionIndex);
                attachToIAConnectSessionByIndexpropCount++;
            }

            if (attachToIAConnectSessionByIndexTimeToWaitInSeconds != null)
            {
                attachToIAConnectSessionByIndex["TimeToWaitInSeconds"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexTimeToWaitInSeconds);
                attachToIAConnectSessionByIndexpropCount++;
            }

            if (attachToIAConnectSessionByIndexRaiseExceptionIfTimedout != null)
            {
                attachToIAConnectSessionByIndex["RaiseExceptionIfTimedout"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexRaiseExceptionIfTimedout);
                attachToIAConnectSessionByIndexpropCount++;
            }

            if (attachToIAConnectSessionByIndexVirtualChannelMustBeConnected != null)
            {
                attachToIAConnectSessionByIndex["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexVirtualChannelMustBeConnected);
                attachToIAConnectSessionByIndexpropCount++;
            }

            if (attachToIAConnectSessionByIndexOnlyCountSessionsNotSeenBefore != null)
            {
                attachToIAConnectSessionByIndex["OnlyCountSessionsNotSeenBefore"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexOnlyCountSessionsNotSeenBefore);
                attachToIAConnectSessionByIndexpropCount++;
            }

            attachToIAConnectSessionByIndexpropCount++;
            attachToIAConnectSessionByIndex["Workflow"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexWorkflow);
            if (attachToIAConnectSessionByIndexpropCount > 0)
            {
                callPayload.Body = attachToIAConnectSessionByIndex;
            }

            return new ApiConnectionAction<AttachToIAConnectSessionByIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToMostRecentIAConnectSessionResponse> AttachToMostRecentIAConnectSession(Expression<Func<string>> attachToMostRecentIAConnectSessionWorkflow, Expression<Func<attachToMostRecentIAConnectSessionSearchIAConnectSessionTypeInput>> attachToMostRecentIAConnectSessionSearchIAConnectSessionType = null, Expression<Func<int>> attachToMostRecentIAConnectSessionTimeToWaitInSeconds = null, Expression<Func<bool>> attachToMostRecentIAConnectSessionRaiseExceptionIfTimedout = null, Expression<Func<bool>> attachToMostRecentIAConnectSessionVirtualChannelMustBeConnected = null, Expression<Func<bool>> attachToMostRecentIAConnectSessionOnlyCountSessionsNotSeenBefore = null)
        {
            var apiCallPath = "/DriverControl/AttachToMostRecentIAConnectSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var attachToMostRecentIAConnectSession = new JObject();
            var attachToMostRecentIAConnectSessionpropCount = 0;
            if (attachToMostRecentIAConnectSessionSearchIAConnectSessionType != null)
            {
                attachToMostRecentIAConnectSession["SearchIAConnectSessionType"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessionSearchIAConnectSessionType);
                attachToMostRecentIAConnectSessionpropCount++;
            }

            if (attachToMostRecentIAConnectSessionTimeToWaitInSeconds != null)
            {
                attachToMostRecentIAConnectSession["TimeToWaitInSeconds"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessionTimeToWaitInSeconds);
                attachToMostRecentIAConnectSessionpropCount++;
            }

            if (attachToMostRecentIAConnectSessionRaiseExceptionIfTimedout != null)
            {
                attachToMostRecentIAConnectSession["RaiseExceptionIfTimedout"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessionRaiseExceptionIfTimedout);
                attachToMostRecentIAConnectSessionpropCount++;
            }

            if (attachToMostRecentIAConnectSessionVirtualChannelMustBeConnected != null)
            {
                attachToMostRecentIAConnectSession["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessionVirtualChannelMustBeConnected);
                attachToMostRecentIAConnectSessionpropCount++;
            }

            if (attachToMostRecentIAConnectSessionOnlyCountSessionsNotSeenBefore != null)
            {
                attachToMostRecentIAConnectSession["OnlyCountSessionsNotSeenBefore"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessionOnlyCountSessionsNotSeenBefore);
                attachToMostRecentIAConnectSessionpropCount++;
            }

            attachToMostRecentIAConnectSessionpropCount++;
            attachToMostRecentIAConnectSession["Workflow"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessionWorkflow);
            if (attachToMostRecentIAConnectSessionpropCount > 0)
            {
                callPayload.Body = attachToMostRecentIAConnectSession;
            }

            return new ApiConnectionAction<AttachToMostRecentIAConnectSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDirectorUpTimeResponse> GetDirectorUpTime(Expression<Func<string>> getDirectorUpTimeWorkflow)
        {
            var apiCallPath = "/DriverControl/GetDirectorUpTime";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getDirectorUpTime = new JObject();
            var getDirectorUpTimepropCount = 0;
            getDirectorUpTimepropCount++;
            getDirectorUpTime["Workflow"] = ExpressionConverter.ConvertO(getDirectorUpTimeWorkflow);
            if (getDirectorUpTimepropCount > 0)
            {
                callPayload.Body = getDirectorUpTime;
            }

            return new ApiConnectionAction<GetDirectorUpTimeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DoesIAConnectSessionExistByNameResponse> DoesIAConnectSessionExistByName(Expression<Func<string>> doesIAConnectSessionExistByNameIAConnectSessionName, Expression<Func<string>> doesIAConnectSessionExistByNameWorkflow)
        {
            var apiCallPath = "/DriverControl/DoesIAConnectSessionExistByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var doesIAConnectSessionExistByName = new JObject();
            var doesIAConnectSessionExistByNamepropCount = 0;
            doesIAConnectSessionExistByNamepropCount++;
            doesIAConnectSessionExistByName["IAConnectSessionName"] = ExpressionConverter.ConvertO(doesIAConnectSessionExistByNameIAConnectSessionName);
            doesIAConnectSessionExistByNamepropCount++;
            doesIAConnectSessionExistByName["Workflow"] = ExpressionConverter.ConvertO(doesIAConnectSessionExistByNameWorkflow);
            if (doesIAConnectSessionExistByNamepropCount > 0)
            {
                callPayload.Body = doesIAConnectSessionExistByName;
            }

            return new ApiConnectionAction<DoesIAConnectSessionExistByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForIAConnectSessionToCloseByNameResponse> WaitForIAConnectSessionToCloseByName(Expression<Func<string>> waitForIAConnectSessionToCloseByNameIAConnectSessionName, Expression<Func<string>> waitForIAConnectSessionToCloseByNameWorkflow, Expression<Func<int>> waitForIAConnectSessionToCloseByNameTimeToWaitInSeconds = null, Expression<Func<bool>> waitForIAConnectSessionToCloseByNameRaiseExceptionIfTimedout = null, Expression<Func<bool>> waitForIAConnectSessionToCloseByNameAttachToTier1IAConnectSessionOnSuccess = null)
        {
            var apiCallPath = "/DriverControl/WaitForIAConnectSessionToCloseByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var waitForIAConnectSessionToCloseByName = new JObject();
            var waitForIAConnectSessionToCloseByNamepropCount = 0;
            waitForIAConnectSessionToCloseByNamepropCount++;
            waitForIAConnectSessionToCloseByName["IAConnectSessionName"] = ExpressionConverter.ConvertO(waitForIAConnectSessionToCloseByNameIAConnectSessionName);
            if (waitForIAConnectSessionToCloseByNameTimeToWaitInSeconds != null)
            {
                waitForIAConnectSessionToCloseByName["TimeToWaitInSeconds"] = ExpressionConverter.ConvertO(waitForIAConnectSessionToCloseByNameTimeToWaitInSeconds);
                waitForIAConnectSessionToCloseByNamepropCount++;
            }

            if (waitForIAConnectSessionToCloseByNameRaiseExceptionIfTimedout != null)
            {
                waitForIAConnectSessionToCloseByName["RaiseExceptionIfTimedout"] = ExpressionConverter.ConvertO(waitForIAConnectSessionToCloseByNameRaiseExceptionIfTimedout);
                waitForIAConnectSessionToCloseByNamepropCount++;
            }

            if (waitForIAConnectSessionToCloseByNameAttachToTier1IAConnectSessionOnSuccess != null)
            {
                waitForIAConnectSessionToCloseByName["AttachToTier1IAConnectSessionOnSuccess"] = ExpressionConverter.ConvertO(waitForIAConnectSessionToCloseByNameAttachToTier1IAConnectSessionOnSuccess);
                waitForIAConnectSessionToCloseByNamepropCount++;
            }

            waitForIAConnectSessionToCloseByNamepropCount++;
            waitForIAConnectSessionToCloseByName["Workflow"] = ExpressionConverter.ConvertO(waitForIAConnectSessionToCloseByNameWorkflow);
            if (waitForIAConnectSessionToCloseByNamepropCount > 0)
            {
                callPayload.Body = waitForIAConnectSessionToCloseByName;
            }

            return new ApiConnectionAction<WaitForIAConnectSessionToCloseByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillIAConnectSessionByNameResponse> KillIAConnectSessionByName(Expression<Func<string>> killIAConnectSessionByNameIAConnectSessionName, Expression<Func<string>> killIAConnectSessionByNameWorkflow, Expression<Func<bool>> killIAConnectSessionByNameAttachToTier1IAConnectSessionOnSuccess = null)
        {
            var apiCallPath = "/DriverControl/KillIAConnectSessionByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var killIAConnectSessionByName = new JObject();
            var killIAConnectSessionByNamepropCount = 0;
            killIAConnectSessionByNamepropCount++;
            killIAConnectSessionByName["IAConnectSessionName"] = ExpressionConverter.ConvertO(killIAConnectSessionByNameIAConnectSessionName);
            if (killIAConnectSessionByNameAttachToTier1IAConnectSessionOnSuccess != null)
            {
                killIAConnectSessionByName["AttachToTier1IAConnectSessionOnSuccess"] = ExpressionConverter.ConvertO(killIAConnectSessionByNameAttachToTier1IAConnectSessionOnSuccess);
                killIAConnectSessionByNamepropCount++;
            }

            killIAConnectSessionByNamepropCount++;
            killIAConnectSessionByName["Workflow"] = ExpressionConverter.ConvertO(killIAConnectSessionByNameWorkflow);
            if (killIAConnectSessionByNamepropCount > 0)
            {
                callPayload.Body = killIAConnectSessionByName;
            }

            return new ApiConnectionAction<KillIAConnectSessionByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetAgentGlobalCoordinateConfigurationResponse> SetAgentGlobalCoordinateConfiguration(Expression<Func<string>> setAgentGlobalCoordinateConfigurationWorkflow, Expression<Func<setAgentGlobalCoordinateConfigurationMultiMonitorFunctionalityInput>> setAgentGlobalCoordinateConfigurationMultiMonitorFunctionality = null, Expression<Func<setAgentGlobalCoordinateConfigurationAutoSetMouseInspectionMultiplierInput>> setAgentGlobalCoordinateConfigurationAutoSetMouseInspectionMultiplier = null, Expression<Func<setAgentGlobalCoordinateConfigurationAutoSetGlobalMouseMultiplierInput>> setAgentGlobalCoordinateConfigurationAutoSetGlobalMouseMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationMouseInspectionXMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationMouseInspectionYMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationGlobalMouseXMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationGlobalMouseYMultiplier = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationGlobalMouseMultiplierApplyToMouseEvent = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationGlobalMouseMultiplierApplyToSetCursorPos = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationGlobalMouseMultiplierApplyToCurrentMouseMoveMethod = null, Expression<Func<setAgentGlobalCoordinateConfigurationJavaCoordinateSystemInput>> setAgentGlobalCoordinateConfigurationJavaCoordinateSystem = null, Expression<Func<setAgentGlobalCoordinateConfigurationSAPGUICoordinateSystemInput>> setAgentGlobalCoordinateConfigurationSAPGUICoordinateSystem = null)
        {
            var apiCallPath = "/DriverControl/SetAgentGlobalCoordinateConfiguration";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setAgentGlobalCoordinateConfiguration = new JObject();
            var setAgentGlobalCoordinateConfigurationpropCount = 0;
            if (setAgentGlobalCoordinateConfigurationMultiMonitorFunctionality != null)
            {
                setAgentGlobalCoordinateConfiguration["MultiMonitorFunctionality"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationMultiMonitorFunctionality);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationAutoSetMouseInspectionMultiplier != null)
            {
                setAgentGlobalCoordinateConfiguration["AutoSetMouseInspectionMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationAutoSetMouseInspectionMultiplier);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationAutoSetGlobalMouseMultiplier != null)
            {
                setAgentGlobalCoordinateConfiguration["AutoSetGlobalMouseMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationAutoSetGlobalMouseMultiplier);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationMouseInspectionXMultiplier != null)
            {
                setAgentGlobalCoordinateConfiguration["MouseInspectionXMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationMouseInspectionXMultiplier);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationMouseInspectionYMultiplier != null)
            {
                setAgentGlobalCoordinateConfiguration["MouseInspectionYMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationMouseInspectionYMultiplier);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationGlobalMouseXMultiplier != null)
            {
                setAgentGlobalCoordinateConfiguration["GlobalMouseXMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationGlobalMouseXMultiplier);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationGlobalMouseYMultiplier != null)
            {
                setAgentGlobalCoordinateConfiguration["GlobalMouseYMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationGlobalMouseYMultiplier);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationGlobalMouseMultiplierApplyToMouseEvent != null)
            {
                setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToMouseEvent"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationGlobalMouseMultiplierApplyToMouseEvent);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationGlobalMouseMultiplierApplyToSetCursorPos != null)
            {
                setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToSetCursorPos"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationGlobalMouseMultiplierApplyToSetCursorPos);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationGlobalMouseMultiplierApplyToCurrentMouseMoveMethod != null)
            {
                setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToCurrentMouseMoveMethod"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationGlobalMouseMultiplierApplyToCurrentMouseMoveMethod);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationJavaCoordinateSystem != null)
            {
                setAgentGlobalCoordinateConfiguration["JavaCoordinateSystem"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationJavaCoordinateSystem);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationSAPGUICoordinateSystem != null)
            {
                setAgentGlobalCoordinateConfiguration["SAPGUICoordinateSystem"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationSAPGUICoordinateSystem);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            setAgentGlobalCoordinateConfigurationpropCount++;
            setAgentGlobalCoordinateConfiguration["Workflow"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationWorkflow);
            if (setAgentGlobalCoordinateConfigurationpropCount > 0)
            {
                callPayload.Body = setAgentGlobalCoordinateConfiguration;
            }

            return new ApiConnectionAction<SetAgentGlobalCoordinateConfigurationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentGlobalCoordinateConfigurationResponse> GetAgentGlobalCoordinateConfiguration(Expression<Func<string>> getAgentGlobalCoordinateConfigurationWorkflow)
        {
            var apiCallPath = "/DriverControl/GetAgentGlobalCoordinateConfiguration";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getAgentGlobalCoordinateConfiguration = new JObject();
            var getAgentGlobalCoordinateConfigurationpropCount = 0;
            getAgentGlobalCoordinateConfigurationpropCount++;
            getAgentGlobalCoordinateConfiguration["Workflow"] = ExpressionConverter.ConvertO(getAgentGlobalCoordinateConfigurationWorkflow);
            if (getAgentGlobalCoordinateConfigurationpropCount > 0)
            {
                callPayload.Body = getAgentGlobalCoordinateConfiguration;
            }

            return new ApiConnectionAction<GetAgentGlobalCoordinateConfigurationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentThreadStatusResponse> GetAgentThreadStatus(Expression<Func<int>> getAgentThreadStatusThreadId, Expression<Func<string>> getAgentThreadStatusWorkflow, Expression<Func<bool>> getAgentThreadStatusRetrieveThreadOutputData = null, Expression<Func<bool>> getAgentThreadStatusClearOutputDataFromMemoryOnceRead = null)
        {
            var apiCallPath = "/DriverControl/GetAgentThreadStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getAgentThreadStatus = new JObject();
            var getAgentThreadStatuspropCount = 0;
            getAgentThreadStatuspropCount++;
            getAgentThreadStatus["ThreadId"] = ExpressionConverter.ConvertO(getAgentThreadStatusThreadId);
            if (getAgentThreadStatusRetrieveThreadOutputData != null)
            {
                getAgentThreadStatus["RetrieveThreadOutputData"] = ExpressionConverter.ConvertO(getAgentThreadStatusRetrieveThreadOutputData);
                getAgentThreadStatuspropCount++;
            }

            if (getAgentThreadStatusClearOutputDataFromMemoryOnceRead != null)
            {
                getAgentThreadStatus["ClearOutputDataFromMemoryOnceRead"] = ExpressionConverter.ConvertO(getAgentThreadStatusClearOutputDataFromMemoryOnceRead);
                getAgentThreadStatuspropCount++;
            }

            getAgentThreadStatuspropCount++;
            getAgentThreadStatus["Workflow"] = ExpressionConverter.ConvertO(getAgentThreadStatusWorkflow);
            if (getAgentThreadStatuspropCount > 0)
            {
                callPayload.Body = getAgentThreadStatus;
            }

            return new ApiConnectionAction<GetAgentThreadStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForAgentThreadToCompleteSuccessfullyResponse> WaitForAgentThreadToCompleteSuccessfully(Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullyThreadId, Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullySecondsToWaitForThread, Expression<Func<string>> waitForAgentThreadToCompleteSuccessfullyWorkflow, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyRetrieveThreadOutputData = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyClearOutputDataFromMemoryOnceRead = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyRaiseExceptionIfThreadNotCompleted = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyRaiseExceptionIfThreadError = null, Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullySecondsToWaitPerCall = null)
        {
            var apiCallPath = "/DriverControl/WaitForAgentThreadToCompleteSuccessfully";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var waitForAgentThreadToCompleteSuccessfully = new JObject();
            var waitForAgentThreadToCompleteSuccessfullypropCount = 0;
            waitForAgentThreadToCompleteSuccessfullypropCount++;
            waitForAgentThreadToCompleteSuccessfully["ThreadId"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyThreadId);
            waitForAgentThreadToCompleteSuccessfullypropCount++;
            waitForAgentThreadToCompleteSuccessfully["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullySecondsToWaitForThread);
            if (waitForAgentThreadToCompleteSuccessfullyRetrieveThreadOutputData != null)
            {
                waitForAgentThreadToCompleteSuccessfully["RetrieveThreadOutputData"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyRetrieveThreadOutputData);
                waitForAgentThreadToCompleteSuccessfullypropCount++;
            }

            if (waitForAgentThreadToCompleteSuccessfullyClearOutputDataFromMemoryOnceRead != null)
            {
                waitForAgentThreadToCompleteSuccessfully["ClearOutputDataFromMemoryOnceRead"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyClearOutputDataFromMemoryOnceRead);
                waitForAgentThreadToCompleteSuccessfullypropCount++;
            }

            if (waitForAgentThreadToCompleteSuccessfullyRaiseExceptionIfThreadNotCompleted != null)
            {
                waitForAgentThreadToCompleteSuccessfully["RaiseExceptionIfThreadNotCompleted"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyRaiseExceptionIfThreadNotCompleted);
                waitForAgentThreadToCompleteSuccessfullypropCount++;
            }

            if (waitForAgentThreadToCompleteSuccessfullyRaiseExceptionIfThreadError != null)
            {
                waitForAgentThreadToCompleteSuccessfully["RaiseExceptionIfThreadError"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyRaiseExceptionIfThreadError);
                waitForAgentThreadToCompleteSuccessfullypropCount++;
            }

            if (waitForAgentThreadToCompleteSuccessfullySecondsToWaitPerCall != null)
            {
                waitForAgentThreadToCompleteSuccessfully["SecondsToWaitPerCall"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullySecondsToWaitPerCall);
                waitForAgentThreadToCompleteSuccessfullypropCount++;
            }

            waitForAgentThreadToCompleteSuccessfullypropCount++;
            waitForAgentThreadToCompleteSuccessfully["Workflow"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyWorkflow);
            if (waitForAgentThreadToCompleteSuccessfullypropCount > 0)
            {
                callPayload.Body = waitForAgentThreadToCompleteSuccessfully;
            }

            return new ApiConnectionAction<WaitForAgentThreadToCompleteSuccessfullyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentThreadsResponse> GetAgentThreads(Expression<Func<string>> getAgentThreadsWorkflow, Expression<Func<getAgentThreadsSortOrderInput>> getAgentThreadsSortOrder = null)
        {
            var apiCallPath = "/DriverControl/GetAgentThreads";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getAgentThreads = new JObject();
            var getAgentThreadspropCount = 0;
            if (getAgentThreadsSortOrder != null)
            {
                getAgentThreads["SortOrder"] = ExpressionConverter.ConvertO(getAgentThreadsSortOrder);
                getAgentThreadspropCount++;
            }

            getAgentThreadspropCount++;
            getAgentThreads["Workflow"] = ExpressionConverter.ConvertO(getAgentThreadsWorkflow);
            if (getAgentThreadspropCount > 0)
            {
                callPayload.Body = getAgentThreads;
            }

            return new ApiConnectionAction<GetAgentThreadsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillAgentThreadResponse> KillAgentThread(Expression<Func<int>> killAgentThreadThreadId, Expression<Func<string>> killAgentThreadWorkflow)
        {
            var apiCallPath = "/DriverControl/KillAgentThread";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var killAgentThread = new JObject();
            var killAgentThreadpropCount = 0;
            killAgentThreadpropCount++;
            killAgentThread["ThreadId"] = ExpressionConverter.ConvertO(killAgentThreadThreadId);
            killAgentThreadpropCount++;
            killAgentThread["Workflow"] = ExpressionConverter.ConvertO(killAgentThreadWorkflow);
            if (killAgentThreadpropCount > 0)
            {
                callPayload.Body = killAgentThread;
            }

            return new ApiConnectionAction<KillAgentThreadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeleteAgentThreadResponse> DeleteAgentThread(Expression<Func<string>> deleteAgentThreadWorkflow, Expression<Func<int>> deleteAgentThreadThreadId = null, Expression<Func<bool>> deleteAgentThreadDeleteAllAgentThreads = null, Expression<Func<bool>> deleteAgentThreadRaiseExceptionIfAgentThreadFailsToDelete = null)
        {
            var apiCallPath = "/DriverControl/DeleteAgentThread";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteAgentThread = new JObject();
            var deleteAgentThreadpropCount = 0;
            if (deleteAgentThreadThreadId != null)
            {
                deleteAgentThread["ThreadId"] = ExpressionConverter.ConvertO(deleteAgentThreadThreadId);
                deleteAgentThreadpropCount++;
            }

            if (deleteAgentThreadDeleteAllAgentThreads != null)
            {
                deleteAgentThread["DeleteAllAgentThreads"] = ExpressionConverter.ConvertO(deleteAgentThreadDeleteAllAgentThreads);
                deleteAgentThreadpropCount++;
            }

            if (deleteAgentThreadRaiseExceptionIfAgentThreadFailsToDelete != null)
            {
                deleteAgentThread["RaiseExceptionIfAgentThreadFailsToDelete"] = ExpressionConverter.ConvertO(deleteAgentThreadRaiseExceptionIfAgentThreadFailsToDelete);
                deleteAgentThreadpropCount++;
            }

            deleteAgentThreadpropCount++;
            deleteAgentThread["Workflow"] = ExpressionConverter.ConvertO(deleteAgentThreadWorkflow);
            if (deleteAgentThreadpropCount > 0)
            {
                callPayload.Body = deleteAgentThread;
            }

            return new ApiConnectionAction<DeleteAgentThreadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AllocateWorkerFromOrchestratorResponse> AllocateWorkerFromOrchestrator(Expression<Func<string>> allocateWorkerFromOrchestratorWorkflow, Expression<Func<string>> allocateWorkerFromOrchestratorWorkerTag = null, Expression<Func<string>> allocateWorkerFromOrchestratorWorkerName = null, Expression<Func<bool>> allocateWorkerFromOrchestratorRaiseExceptionIfWorkerNotImmediatelyAvailable = null)
        {
            var apiCallPath = "/DriverControl/AllocateWorkerFromOrchestrator";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var allocateWorkerFromOrchestrator = new JObject();
            var allocateWorkerFromOrchestratorpropCount = 0;
            if (allocateWorkerFromOrchestratorWorkerTag != null)
            {
                allocateWorkerFromOrchestrator["WorkerTag"] = ExpressionConverter.ConvertO(allocateWorkerFromOrchestratorWorkerTag);
                allocateWorkerFromOrchestratorpropCount++;
            }

            if (allocateWorkerFromOrchestratorWorkerName != null)
            {
                allocateWorkerFromOrchestrator["WorkerName"] = ExpressionConverter.ConvertO(allocateWorkerFromOrchestratorWorkerName);
                allocateWorkerFromOrchestratorpropCount++;
            }

            if (allocateWorkerFromOrchestratorRaiseExceptionIfWorkerNotImmediatelyAvailable != null)
            {
                allocateWorkerFromOrchestrator["RaiseExceptionIfWorkerNotImmediatelyAvailable"] = ExpressionConverter.ConvertO(allocateWorkerFromOrchestratorRaiseExceptionIfWorkerNotImmediatelyAvailable);
                allocateWorkerFromOrchestratorpropCount++;
            }

            allocateWorkerFromOrchestratorpropCount++;
            allocateWorkerFromOrchestrator["Workflow"] = ExpressionConverter.ConvertO(allocateWorkerFromOrchestratorWorkflow);
            if (allocateWorkerFromOrchestratorpropCount > 0)
            {
                callPayload.Body = allocateWorkerFromOrchestrator;
            }

            return new ApiConnectionAction<AllocateWorkerFromOrchestratorResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetOrchestratorWorkerMaintenanceModeResponse> SetOrchestratorWorkerMaintenanceMode(Expression<Func<int>> setOrchestratorWorkerMaintenanceModeWorkerId = null, Expression<Func<string>> setOrchestratorWorkerMaintenanceModeWorkerName = null, Expression<Func<bool>> setOrchestratorWorkerMaintenanceModeMaintenanceMode = null)
        {
            var apiCallPath = "/DriverControl/SetOrchestratorWorkerMaintenanceMode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setOrchestratorWorkerMaintenanceMode = new JObject();
            var setOrchestratorWorkerMaintenanceModepropCount = 0;
            if (setOrchestratorWorkerMaintenanceModeWorkerId != null)
            {
                setOrchestratorWorkerMaintenanceMode["WorkerId"] = ExpressionConverter.ConvertO(setOrchestratorWorkerMaintenanceModeWorkerId);
                setOrchestratorWorkerMaintenanceModepropCount++;
            }

            if (setOrchestratorWorkerMaintenanceModeWorkerName != null)
            {
                setOrchestratorWorkerMaintenanceMode["WorkerName"] = ExpressionConverter.ConvertO(setOrchestratorWorkerMaintenanceModeWorkerName);
                setOrchestratorWorkerMaintenanceModepropCount++;
            }

            if (setOrchestratorWorkerMaintenanceModeMaintenanceMode != null)
            {
                setOrchestratorWorkerMaintenanceMode["MaintenanceMode"] = ExpressionConverter.ConvertO(setOrchestratorWorkerMaintenanceModeMaintenanceMode);
                setOrchestratorWorkerMaintenanceModepropCount++;
            }

            if (setOrchestratorWorkerMaintenanceModepropCount > 0)
            {
                callPayload.Body = setOrchestratorWorkerMaintenanceMode;
            }

            return new ApiConnectionAction<SetOrchestratorWorkerMaintenanceModeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CreateOrchestratorOneTimeSecretResponse> CreateOrchestratorOneTimeSecret(Expression<Func<string>> createOrchestratorOneTimeSecretFriendlyName, Expression<Func<string>> createOrchestratorOneTimeSecretSecretValue = null, Expression<Func<string>> createOrchestratorOneTimeSecretRetrievalPhrase1 = null, Expression<Func<string>> createOrchestratorOneTimeSecretRetrievalPhrase2 = null, Expression<Func<int>> createOrchestratorOneTimeSecretMaximumRetrievalsBeforeDeletion = null, Expression<Func<bool>> createOrchestratorOneTimeSecretSecretHasAStartDate = null, Expression<Func<string>> createOrchestratorOneTimeSecretSecretStartDateTime = null, Expression<Func<int>> createOrchestratorOneTimeSecretHoursUntilSecretStartTime = null, Expression<Func<bool>> createOrchestratorOneTimeSecretSecretHasAnExpiryDate = null, Expression<Func<string>> createOrchestratorOneTimeSecretSecretExpiryDateTime = null, Expression<Func<int>> createOrchestratorOneTimeSecretHoursUntilSecretExpiry = null)
        {
            var apiCallPath = "/DriverControl/CreateOrchestratorOneTimeSecret";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var createOrchestratorOneTimeSecret = new JObject();
            var createOrchestratorOneTimeSecretpropCount = 0;
            createOrchestratorOneTimeSecretpropCount++;
            createOrchestratorOneTimeSecret["FriendlyName"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretFriendlyName);
            if (createOrchestratorOneTimeSecretSecretValue != null)
            {
                createOrchestratorOneTimeSecret["SecretValue"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretSecretValue);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretRetrievalPhrase1 != null)
            {
                createOrchestratorOneTimeSecret["RetrievalPhrase1"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretRetrievalPhrase1);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretRetrievalPhrase2 != null)
            {
                createOrchestratorOneTimeSecret["RetrievalPhrase2"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretRetrievalPhrase2);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretMaximumRetrievalsBeforeDeletion != null)
            {
                createOrchestratorOneTimeSecret["MaximumRetrievalsBeforeDeletion"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretMaximumRetrievalsBeforeDeletion);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretSecretHasAStartDate != null)
            {
                createOrchestratorOneTimeSecret["SecretHasAStartDate"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretSecretHasAStartDate);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretSecretStartDateTime != null)
            {
                createOrchestratorOneTimeSecret["SecretStartDateTime"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretSecretStartDateTime);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretHoursUntilSecretStartTime != null)
            {
                createOrchestratorOneTimeSecret["HoursUntilSecretStartTime"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretHoursUntilSecretStartTime);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretSecretHasAnExpiryDate != null)
            {
                createOrchestratorOneTimeSecret["SecretHasAnExpiryDate"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretSecretHasAnExpiryDate);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretSecretExpiryDateTime != null)
            {
                createOrchestratorOneTimeSecret["SecretExpiryDateTime"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretSecretExpiryDateTime);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretHoursUntilSecretExpiry != null)
            {
                createOrchestratorOneTimeSecret["HoursUntilSecretExpiry"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretHoursUntilSecretExpiry);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretpropCount > 0)
            {
                callPayload.Body = createOrchestratorOneTimeSecret;
            }

            return new ApiConnectionAction<CreateOrchestratorOneTimeSecretResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfOrchestratorWorkersResponse> GetListOfOrchestratorWorkers(Expression<Func<bool>> getListOfOrchestratorWorkersOnlyReturnLiveWorkers = null)
        {
            var apiCallPath = "/DriverControl/GetListOfOrchestratorWorkers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getListOfOrchestratorWorkers = new JObject();
            var getListOfOrchestratorWorkerspropCount = 0;
            if (getListOfOrchestratorWorkersOnlyReturnLiveWorkers != null)
            {
                getListOfOrchestratorWorkers["OnlyReturnLiveWorkers"] = ExpressionConverter.ConvertO(getListOfOrchestratorWorkersOnlyReturnLiveWorkers);
                getListOfOrchestratorWorkerspropCount++;
            }

            if (getListOfOrchestratorWorkerspropCount > 0)
            {
                callPayload.Body = getListOfOrchestratorWorkers;
            }

            return new ApiConnectionAction<GetListOfOrchestratorWorkersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerResponse> GetOrchestratorWorker(Expression<Func<int>> getOrchestratorWorkerSearchWorkerId = null, Expression<Func<string>> getOrchestratorWorkerSearchWorkerName = null)
        {
            var apiCallPath = "/DriverControl/GetOrchestratorWorker";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getOrchestratorWorker = new JObject();
            var getOrchestratorWorkerpropCount = 0;
            if (getOrchestratorWorkerSearchWorkerId != null)
            {
                getOrchestratorWorker["SearchWorkerId"] = ExpressionConverter.ConvertO(getOrchestratorWorkerSearchWorkerId);
                getOrchestratorWorkerpropCount++;
            }

            if (getOrchestratorWorkerSearchWorkerName != null)
            {
                getOrchestratorWorker["SearchWorkerName"] = ExpressionConverter.ConvertO(getOrchestratorWorkerSearchWorkerName);
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
        public IBodyWorkflowAction<FileExistsResponse> FileExists(Expression<Func<string>> fileExistsFilename, Expression<Func<string>> fileExistsWorkflow)
        {
            var apiCallPath = "/FileManagement/FileExists";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var fileExists = new JObject();
            var fileExistspropCount = 0;
            fileExistspropCount++;
            fileExists["Filename"] = ExpressionConverter.ConvertO(fileExistsFilename);
            fileExistspropCount++;
            fileExists["Workflow"] = ExpressionConverter.ConvertO(fileExistsWorkflow);
            if (fileExistspropCount > 0)
            {
                callPayload.Body = fileExists;
            }

            return new ApiConnectionAction<FileExistsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DirectoryExistsResponse> DirectoryExists(Expression<Func<string>> directoryExistsDirectoryPath, Expression<Func<string>> directoryExistsWorkflow)
        {
            var apiCallPath = "/FileManagement/DirectoryExists";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var directoryExists = new JObject();
            var directoryExistspropCount = 0;
            directoryExistspropCount++;
            directoryExists["DirectoryPath"] = ExpressionConverter.ConvertO(directoryExistsDirectoryPath);
            directoryExistspropCount++;
            directoryExists["Workflow"] = ExpressionConverter.ConvertO(directoryExistsWorkflow);
            if (directoryExistspropCount > 0)
            {
                callPayload.Body = directoryExists;
            }

            return new ApiConnectionAction<DirectoryExistsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DeleteFile(Expression<Func<string>> deleteFileFilename, Expression<Func<string>> deleteFileWorkflow)
        {
            var apiCallPath = "/FileManagement/DeleteFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteFile = new JObject();
            var deleteFilepropCount = 0;
            deleteFilepropCount++;
            deleteFile["Filename"] = ExpressionConverter.ConvertO(deleteFileFilename);
            deleteFilepropCount++;
            deleteFile["Workflow"] = ExpressionConverter.ConvertO(deleteFileWorkflow);
            if (deleteFilepropCount > 0)
            {
                callPayload.Body = deleteFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction DeleteDirectory(Expression<Func<string>> deleteDirectoryDirectoryPath, Expression<Func<string>> deleteDirectoryWorkflow, Expression<Func<bool>> deleteDirectoryRecursive = null)
        {
            var apiCallPath = "/FileManagement/DeleteDirectory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteDirectory = new JObject();
            var deleteDirectorypropCount = 0;
            deleteDirectorypropCount++;
            deleteDirectory["DirectoryPath"] = ExpressionConverter.ConvertO(deleteDirectoryDirectoryPath);
            if (deleteDirectoryRecursive != null)
            {
                deleteDirectory["Recursive"] = ExpressionConverter.ConvertO(deleteDirectoryRecursive);
                deleteDirectorypropCount++;
            }

            deleteDirectorypropCount++;
            deleteDirectory["Workflow"] = ExpressionConverter.ConvertO(deleteDirectoryWorkflow);
            if (deleteDirectorypropCount > 0)
            {
                callPayload.Body = deleteDirectory;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction PurgeDirectory(Expression<Func<string>> purgeDirectoryDirectoryPath, Expression<Func<string>> purgeDirectoryWorkflow, Expression<Func<bool>> purgeDirectoryRecursive = null, Expression<Func<bool>> purgeDirectoryDeleteTopLevel = null)
        {
            var apiCallPath = "/FileManagement/PurgeDirectory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var purgeDirectory = new JObject();
            var purgeDirectorypropCount = 0;
            purgeDirectorypropCount++;
            purgeDirectory["DirectoryPath"] = ExpressionConverter.ConvertO(purgeDirectoryDirectoryPath);
            if (purgeDirectoryRecursive != null)
            {
                purgeDirectory["Recursive"] = ExpressionConverter.ConvertO(purgeDirectoryRecursive);
                purgeDirectorypropCount++;
            }

            if (purgeDirectoryDeleteTopLevel != null)
            {
                purgeDirectory["DeleteTopLevel"] = ExpressionConverter.ConvertO(purgeDirectoryDeleteTopLevel);
                purgeDirectorypropCount++;
            }

            purgeDirectorypropCount++;
            purgeDirectory["Workflow"] = ExpressionConverter.ConvertO(purgeDirectoryWorkflow);
            if (purgeDirectorypropCount > 0)
            {
                callPayload.Body = purgeDirectory;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CopyFile(Expression<Func<string>> copyFileSourceFilePath, Expression<Func<string>> copyFileDestFilePath, Expression<Func<string>> copyFileWorkflow)
        {
            var apiCallPath = "/FileManagement/CopyFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var copyFile = new JObject();
            var copyFilepropCount = 0;
            copyFilepropCount++;
            copyFile["SourceFilePath"] = ExpressionConverter.ConvertO(copyFileSourceFilePath);
            copyFilepropCount++;
            copyFile["DestFilePath"] = ExpressionConverter.ConvertO(copyFileDestFilePath);
            copyFilepropCount++;
            copyFile["Workflow"] = ExpressionConverter.ConvertO(copyFileWorkflow);
            if (copyFilepropCount > 0)
            {
                callPayload.Body = copyFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction MoveFile(Expression<Func<string>> moveFileSourceFilePath, Expression<Func<string>> moveFileDestFilePath, Expression<Func<string>> moveFileWorkflow)
        {
            var apiCallPath = "/FileManagement/MoveFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var moveFile = new JObject();
            var moveFilepropCount = 0;
            moveFilepropCount++;
            moveFile["SourceFilePath"] = ExpressionConverter.ConvertO(moveFileSourceFilePath);
            moveFilepropCount++;
            moveFile["DestFilePath"] = ExpressionConverter.ConvertO(moveFileDestFilePath);
            moveFilepropCount++;
            moveFile["Workflow"] = ExpressionConverter.ConvertO(moveFileWorkflow);
            if (moveFilepropCount > 0)
            {
                callPayload.Body = moveFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CreateDirectory(Expression<Func<string>> createDirectoryDirectoryPath, Expression<Func<string>> createDirectoryWorkflow, Expression<Func<bool>> createDirectoryErrorIfAlreadyExists = null)
        {
            var apiCallPath = "/FileManagement/CreateDirectory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var createDirectory = new JObject();
            var createDirectorypropCount = 0;
            createDirectorypropCount++;
            createDirectory["DirectoryPath"] = ExpressionConverter.ConvertO(createDirectoryDirectoryPath);
            if (createDirectoryErrorIfAlreadyExists != null)
            {
                createDirectory["ErrorIfAlreadyExists"] = ExpressionConverter.ConvertO(createDirectoryErrorIfAlreadyExists);
                createDirectorypropCount++;
            }

            createDirectorypropCount++;
            createDirectory["Workflow"] = ExpressionConverter.ConvertO(createDirectoryWorkflow);
            if (createDirectorypropCount > 0)
            {
                callPayload.Body = createDirectory;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileSizeResponse> GetFileSize(Expression<Func<string>> getFileSizeFilename, Expression<Func<string>> getFileSizeWorkflow)
        {
            var apiCallPath = "/FileManagement/GetFileSize";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getFileSize = new JObject();
            var getFileSizepropCount = 0;
            getFileSizepropCount++;
            getFileSize["Filename"] = ExpressionConverter.ConvertO(getFileSizeFilename);
            getFileSizepropCount++;
            getFileSize["Workflow"] = ExpressionConverter.ConvertO(getFileSizeWorkflow);
            if (getFileSizepropCount > 0)
            {
                callPayload.Body = getFileSize;
            }

            return new ApiConnectionAction<GetFileSizeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction WriteTextFile(Expression<Func<string>> writeTextFileFilename, Expression<Func<string>> writeTextFileWorkflow, Expression<Func<string>> writeTextFileTextToWrite = null, Expression<Func<bool>> writeTextFileAppendExistingFile = null, Expression<Func<writeTextFileEncodingInput>> writeTextFileEncoding = null, Expression<Func<bool>> writeTextFileCreateFolderIfRequired = null)
        {
            var apiCallPath = "/FileManagement/WriteTextFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var writeTextFile = new JObject();
            var writeTextFilepropCount = 0;
            writeTextFilepropCount++;
            writeTextFile["Filename"] = ExpressionConverter.ConvertO(writeTextFileFilename);
            if (writeTextFileTextToWrite != null)
            {
                writeTextFile["TextToWrite"] = ExpressionConverter.ConvertO(writeTextFileTextToWrite);
                writeTextFilepropCount++;
            }

            if (writeTextFileAppendExistingFile != null)
            {
                writeTextFile["AppendExistingFile"] = ExpressionConverter.ConvertO(writeTextFileAppendExistingFile);
                writeTextFilepropCount++;
            }

            if (writeTextFileEncoding != null)
            {
                writeTextFile["Encoding"] = ExpressionConverter.ConvertO(writeTextFileEncoding);
                writeTextFilepropCount++;
            }

            if (writeTextFileCreateFolderIfRequired != null)
            {
                writeTextFile["CreateFolderIfRequired"] = ExpressionConverter.ConvertO(writeTextFileCreateFolderIfRequired);
                writeTextFilepropCount++;
            }

            writeTextFilepropCount++;
            writeTextFile["Workflow"] = ExpressionConverter.ConvertO(writeTextFileWorkflow);
            if (writeTextFilepropCount > 0)
            {
                callPayload.Body = writeTextFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ReadAllTextFromFileResponse> ReadAllTextFromFile(Expression<Func<string>> readAllTextFromFileFilename, Expression<Func<string>> readAllTextFromFileWorkflow)
        {
            var apiCallPath = "/FileManagement/ReadAllTextFromFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var readAllTextFromFile = new JObject();
            var readAllTextFromFilepropCount = 0;
            readAllTextFromFilepropCount++;
            readAllTextFromFile["Filename"] = ExpressionConverter.ConvertO(readAllTextFromFileFilename);
            readAllTextFromFilepropCount++;
            readAllTextFromFile["Workflow"] = ExpressionConverter.ConvertO(readAllTextFromFileWorkflow);
            if (readAllTextFromFilepropCount > 0)
            {
                callPayload.Body = readAllTextFromFile;
            }

            return new ApiConnectionAction<ReadAllTextFromFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFilesResponse> GetFiles(Expression<Func<string>> getFilesDirectoryPath, Expression<Func<string>> getFilesPatternsCSV, Expression<Func<string>> getFilesWorkflow)
        {
            var apiCallPath = "/FileManagement/GetFiles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getFiles = new JObject();
            var getFilespropCount = 0;
            getFilespropCount++;
            getFiles["DirectoryPath"] = ExpressionConverter.ConvertO(getFilesDirectoryPath);
            getFilespropCount++;
            getFiles["PatternsCSV"] = ExpressionConverter.ConvertO(getFilesPatternsCSV);
            getFilespropCount++;
            getFiles["Workflow"] = ExpressionConverter.ConvertO(getFilesWorkflow);
            if (getFilespropCount > 0)
            {
                callPayload.Body = getFiles;
            }

            return new ApiConnectionAction<GetFilesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFoldersResponse> GetFolders(Expression<Func<string>> getFoldersDirectoryPath, Expression<Func<string>> getFoldersWorkflow)
        {
            var apiCallPath = "/FileManagement/GetFolders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getFolders = new JObject();
            var getFolderspropCount = 0;
            getFolderspropCount++;
            getFolders["DirectoryPath"] = ExpressionConverter.ConvertO(getFoldersDirectoryPath);
            getFolderspropCount++;
            getFolders["Workflow"] = ExpressionConverter.ConvertO(getFoldersWorkflow);
            if (getFolderspropCount > 0)
            {
                callPayload.Body = getFolders;
            }

            return new ApiConnectionAction<GetFoldersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeleteFilesResponse> DeleteFiles(Expression<Func<string>> deleteFilesDirectoryPath, Expression<Func<string>> deleteFilesWorkflow, Expression<Func<string>> deleteFilesPattern = null)
        {
            var apiCallPath = "/FileManagement/DeleteFiles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteFiles = new JObject();
            var deleteFilespropCount = 0;
            deleteFilespropCount++;
            deleteFiles["DirectoryPath"] = ExpressionConverter.ConvertO(deleteFilesDirectoryPath);
            if (deleteFilesPattern != null)
            {
                deleteFiles["Pattern"] = ExpressionConverter.ConvertO(deleteFilesPattern);
                deleteFilespropCount++;
            }

            deleteFilespropCount++;
            deleteFiles["Workflow"] = ExpressionConverter.ConvertO(deleteFilesWorkflow);
            if (deleteFilespropCount > 0)
            {
                callPayload.Body = deleteFiles;
            }

            return new ApiConnectionAction<DeleteFilesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDiskFreeSpaceResponse> GetDiskFreeSpace(Expression<Func<string>> getDiskFreeSpaceDriveLetter, Expression<Func<string>> getDiskFreeSpaceWorkflow)
        {
            var apiCallPath = "/FileManagement/GetDiskFreeSpace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getDiskFreeSpace = new JObject();
            var getDiskFreeSpacepropCount = 0;
            getDiskFreeSpacepropCount++;
            getDiskFreeSpace["DriveLetter"] = ExpressionConverter.ConvertO(getDiskFreeSpaceDriveLetter);
            getDiskFreeSpacepropCount++;
            getDiskFreeSpace["Workflow"] = ExpressionConverter.ConvertO(getDiskFreeSpaceWorkflow);
            if (getDiskFreeSpacepropCount > 0)
            {
                callPayload.Body = getDiskFreeSpace;
            }

            return new ApiConnectionAction<GetDiskFreeSpaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfDrivesResponse> GetListOfDrives(Expression<Func<string>> getListOfDrivesWorkflow)
        {
            var apiCallPath = "/FileManagement/GetListOfDrives";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getListOfDrives = new JObject();
            var getListOfDrivespropCount = 0;
            getListOfDrivespropCount++;
            getListOfDrives["Workflow"] = ExpressionConverter.ConvertO(getListOfDrivesWorkflow);
            if (getListOfDrivespropCount > 0)
            {
                callPayload.Body = getListOfDrives;
            }

            return new ApiConnectionAction<GetListOfDrivesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DirectoryIsAccessibleResponse> DirectoryIsAccessible(Expression<Func<string>> directoryIsAccessibleDirectoryPath, Expression<Func<string>> directoryIsAccessibleWorkflow)
        {
            var apiCallPath = "/FileManagement/DirectoryIsAccessible";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var directoryIsAccessible = new JObject();
            var directoryIsAccessiblepropCount = 0;
            directoryIsAccessiblepropCount++;
            directoryIsAccessible["DirectoryPath"] = ExpressionConverter.ConvertO(directoryIsAccessibleDirectoryPath);
            directoryIsAccessiblepropCount++;
            directoryIsAccessible["Workflow"] = ExpressionConverter.ConvertO(directoryIsAccessibleWorkflow);
            if (directoryIsAccessiblepropCount > 0)
            {
                callPayload.Body = directoryIsAccessible;
            }

            return new ApiConnectionAction<DirectoryIsAccessibleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetCSVTextAsCollectionResponse> GetCSVTextAsCollection(Expression<Func<string>> getCSVTextAsCollectionCSVFilePath, Expression<Func<string>> getCSVTextAsCollectionWorkflow, Expression<Func<bool>> getCSVTextAsCollectionFirstLineIsHeader = null, Expression<Func<bool>> getCSVTextAsCollectionTrimHeaders = null, Expression<Func<bool>> getCSVTextAsCollectionAllowBlankRows = null, Expression<Func<bool>> getCSVTextAsCollectionExtendColumnsIfRequired = null)
        {
            var apiCallPath = "/FileManagement/GetCSVTextAsCollection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getCSVTextAsCollection = new JObject();
            var getCSVTextAsCollectionpropCount = 0;
            getCSVTextAsCollectionpropCount++;
            getCSVTextAsCollection["CSVFilePath"] = ExpressionConverter.ConvertO(getCSVTextAsCollectionCSVFilePath);
            if (getCSVTextAsCollectionFirstLineIsHeader != null)
            {
                getCSVTextAsCollection["FirstLineIsHeader"] = ExpressionConverter.ConvertO(getCSVTextAsCollectionFirstLineIsHeader);
                getCSVTextAsCollectionpropCount++;
            }

            if (getCSVTextAsCollectionTrimHeaders != null)
            {
                getCSVTextAsCollection["TrimHeaders"] = ExpressionConverter.ConvertO(getCSVTextAsCollectionTrimHeaders);
                getCSVTextAsCollectionpropCount++;
            }

            if (getCSVTextAsCollectionAllowBlankRows != null)
            {
                getCSVTextAsCollection["AllowBlankRows"] = ExpressionConverter.ConvertO(getCSVTextAsCollectionAllowBlankRows);
                getCSVTextAsCollectionpropCount++;
            }

            if (getCSVTextAsCollectionExtendColumnsIfRequired != null)
            {
                getCSVTextAsCollection["ExtendColumnsIfRequired"] = ExpressionConverter.ConvertO(getCSVTextAsCollectionExtendColumnsIfRequired);
                getCSVTextAsCollectionpropCount++;
            }

            getCSVTextAsCollectionpropCount++;
            getCSVTextAsCollection["Workflow"] = ExpressionConverter.ConvertO(getCSVTextAsCollectionWorkflow);
            if (getCSVTextAsCollectionpropCount > 0)
            {
                callPayload.Body = getCSVTextAsCollection;
            }

            return new ApiConnectionAction<GetCSVTextAsCollectionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WriteCollectionToCSVFileResponse> WriteCollectionToCSVFile(Expression<Func<string>> writeCollectionToCSVFileCSVFilePath, Expression<Func<string>> writeCollectionToCSVFileWorkflow, Expression<Func<JToken[]>> writeCollectionToCSVFileInputTable = null, Expression<Func<string>> writeCollectionToCSVFileInputTableJSON = null, Expression<Func<writeCollectionToCSVFileOutputEncodingInput>> writeCollectionToCSVFileOutputEncoding = null)
        {
            var apiCallPath = "/FileManagement/WriteCollectionToCSVFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var writeCollectionToCSVFile = new JObject();
            var writeCollectionToCSVFilepropCount = 0;
            if (writeCollectionToCSVFileInputTable != null)
            {
                writeCollectionToCSVFile["InputTable"] = ExpressionConverter.ConvertO(writeCollectionToCSVFileInputTable);
                writeCollectionToCSVFilepropCount++;
            }

            if (writeCollectionToCSVFileInputTableJSON != null)
            {
                writeCollectionToCSVFile["InputTableJSON"] = ExpressionConverter.ConvertO(writeCollectionToCSVFileInputTableJSON);
                writeCollectionToCSVFilepropCount++;
            }

            writeCollectionToCSVFilepropCount++;
            writeCollectionToCSVFile["CSVFilePath"] = ExpressionConverter.ConvertO(writeCollectionToCSVFileCSVFilePath);
            if (writeCollectionToCSVFileOutputEncoding != null)
            {
                writeCollectionToCSVFile["OutputEncoding"] = ExpressionConverter.ConvertO(writeCollectionToCSVFileOutputEncoding);
                writeCollectionToCSVFilepropCount++;
            }

            writeCollectionToCSVFilepropCount++;
            writeCollectionToCSVFile["Workflow"] = ExpressionConverter.ConvertO(writeCollectionToCSVFileWorkflow);
            if (writeCollectionToCSVFilepropCount > 0)
            {
                callPayload.Body = writeCollectionToCSVFile;
            }

            return new ApiConnectionAction<WriteCollectionToCSVFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetOwnerOnFolder(Expression<Func<string>> setOwnerOnFolderFolderPath, Expression<Func<string>> setOwnerOnFolderUserIdentity, Expression<Func<string>> setOwnerOnFolderWorkflow)
        {
            var apiCallPath = "/FileManagement/SetOwnerOnFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setOwnerOnFolder = new JObject();
            var setOwnerOnFolderpropCount = 0;
            setOwnerOnFolderpropCount++;
            setOwnerOnFolder["FolderPath"] = ExpressionConverter.ConvertO(setOwnerOnFolderFolderPath);
            setOwnerOnFolderpropCount++;
            setOwnerOnFolder["UserIdentity"] = ExpressionConverter.ConvertO(setOwnerOnFolderUserIdentity);
            setOwnerOnFolderpropCount++;
            setOwnerOnFolder["Workflow"] = ExpressionConverter.ConvertO(setOwnerOnFolderWorkflow);
            if (setOwnerOnFolderpropCount > 0)
            {
                callPayload.Body = setOwnerOnFolder;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction SetOwnerOnFile(Expression<Func<string>> setOwnerOnFileFilePath, Expression<Func<string>> setOwnerOnFileUserIdentity, Expression<Func<string>> setOwnerOnFileWorkflow)
        {
            var apiCallPath = "/FileManagement/SetOwnerOnFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setOwnerOnFile = new JObject();
            var setOwnerOnFilepropCount = 0;
            setOwnerOnFilepropCount++;
            setOwnerOnFile["FilePath"] = ExpressionConverter.ConvertO(setOwnerOnFileFilePath);
            setOwnerOnFilepropCount++;
            setOwnerOnFile["UserIdentity"] = ExpressionConverter.ConvertO(setOwnerOnFileUserIdentity);
            setOwnerOnFilepropCount++;
            setOwnerOnFile["Workflow"] = ExpressionConverter.ConvertO(setOwnerOnFileWorkflow);
            if (setOwnerOnFilepropCount > 0)
            {
                callPayload.Body = setOwnerOnFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddPermissionToFolder(Expression<Func<string>> addPermissionToFolderFolderPath, Expression<Func<string>> addPermissionToFolderIdentity, Expression<Func<addPermissionToFolderPermissionInput>> addPermissionToFolderPermission, Expression<Func<string>> addPermissionToFolderWorkflow, Expression<Func<bool>> addPermissionToFolderApplyToFolder = null, Expression<Func<bool>> addPermissionToFolderApplyToSubFolders = null, Expression<Func<bool>> addPermissionToFolderApplyToFiles = null, Expression<Func<bool>> addPermissionToFolderDeny = null)
        {
            var apiCallPath = "/FileManagement/AddPermissionToFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addPermissionToFolder = new JObject();
            var addPermissionToFolderpropCount = 0;
            addPermissionToFolderpropCount++;
            addPermissionToFolder["FolderPath"] = ExpressionConverter.ConvertO(addPermissionToFolderFolderPath);
            addPermissionToFolderpropCount++;
            addPermissionToFolder["Identity"] = ExpressionConverter.ConvertO(addPermissionToFolderIdentity);
            addPermissionToFolderpropCount++;
            addPermissionToFolder["Permission"] = ExpressionConverter.ConvertO(addPermissionToFolderPermission);
            if (addPermissionToFolderApplyToFolder != null)
            {
                addPermissionToFolder["ApplyToFolder"] = ExpressionConverter.ConvertO(addPermissionToFolderApplyToFolder);
                addPermissionToFolderpropCount++;
            }

            if (addPermissionToFolderApplyToSubFolders != null)
            {
                addPermissionToFolder["ApplyToSubFolders"] = ExpressionConverter.ConvertO(addPermissionToFolderApplyToSubFolders);
                addPermissionToFolderpropCount++;
            }

            if (addPermissionToFolderApplyToFiles != null)
            {
                addPermissionToFolder["ApplyToFiles"] = ExpressionConverter.ConvertO(addPermissionToFolderApplyToFiles);
                addPermissionToFolderpropCount++;
            }

            if (addPermissionToFolderDeny != null)
            {
                addPermissionToFolder["Deny"] = ExpressionConverter.ConvertO(addPermissionToFolderDeny);
                addPermissionToFolderpropCount++;
            }

            addPermissionToFolderpropCount++;
            addPermissionToFolder["Workflow"] = ExpressionConverter.ConvertO(addPermissionToFolderWorkflow);
            if (addPermissionToFolderpropCount > 0)
            {
                callPayload.Body = addPermissionToFolder;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddPermissionToFile(Expression<Func<string>> addPermissionToFileFilePath, Expression<Func<string>> addPermissionToFileIdentity, Expression<Func<addPermissionToFilePermissionInput>> addPermissionToFilePermission, Expression<Func<string>> addPermissionToFileWorkflow, Expression<Func<bool>> addPermissionToFileDeny = null)
        {
            var apiCallPath = "/FileManagement/AddPermissionToFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addPermissionToFile = new JObject();
            var addPermissionToFilepropCount = 0;
            addPermissionToFilepropCount++;
            addPermissionToFile["FilePath"] = ExpressionConverter.ConvertO(addPermissionToFileFilePath);
            addPermissionToFilepropCount++;
            addPermissionToFile["Identity"] = ExpressionConverter.ConvertO(addPermissionToFileIdentity);
            addPermissionToFilepropCount++;
            addPermissionToFile["Permission"] = ExpressionConverter.ConvertO(addPermissionToFilePermission);
            if (addPermissionToFileDeny != null)
            {
                addPermissionToFile["Deny"] = ExpressionConverter.ConvertO(addPermissionToFileDeny);
                addPermissionToFilepropCount++;
            }

            addPermissionToFilepropCount++;
            addPermissionToFile["Workflow"] = ExpressionConverter.ConvertO(addPermissionToFileWorkflow);
            if (addPermissionToFilepropCount > 0)
            {
                callPayload.Body = addPermissionToFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction BreakFolderSecurityInheritance(Expression<Func<string>> breakFolderSecurityInheritanceFolderPath, Expression<Func<string>> breakFolderSecurityInheritanceWorkflow, Expression<Func<bool>> breakFolderSecurityInheritanceConvertInheritedToExplicit = null)
        {
            var apiCallPath = "/FileManagement/BreakFolderSecurityInheritance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var breakFolderSecurityInheritance = new JObject();
            var breakFolderSecurityInheritancepropCount = 0;
            breakFolderSecurityInheritancepropCount++;
            breakFolderSecurityInheritance["FolderPath"] = ExpressionConverter.ConvertO(breakFolderSecurityInheritanceFolderPath);
            if (breakFolderSecurityInheritanceConvertInheritedToExplicit != null)
            {
                breakFolderSecurityInheritance["ConvertInheritedToExplicit"] = ExpressionConverter.ConvertO(breakFolderSecurityInheritanceConvertInheritedToExplicit);
                breakFolderSecurityInheritancepropCount++;
            }

            breakFolderSecurityInheritancepropCount++;
            breakFolderSecurityInheritance["Workflow"] = ExpressionConverter.ConvertO(breakFolderSecurityInheritanceWorkflow);
            if (breakFolderSecurityInheritancepropCount > 0)
            {
                callPayload.Body = breakFolderSecurityInheritance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction EnableFolderSecurityInheritance(Expression<Func<string>> enableFolderSecurityInheritanceFolderPath, Expression<Func<string>> enableFolderSecurityInheritanceWorkflow)
        {
            var apiCallPath = "/FileManagement/EnableFolderSecurityInheritance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var enableFolderSecurityInheritance = new JObject();
            var enableFolderSecurityInheritancepropCount = 0;
            enableFolderSecurityInheritancepropCount++;
            enableFolderSecurityInheritance["FolderPath"] = ExpressionConverter.ConvertO(enableFolderSecurityInheritanceFolderPath);
            enableFolderSecurityInheritancepropCount++;
            enableFolderSecurityInheritance["Workflow"] = ExpressionConverter.ConvertO(enableFolderSecurityInheritanceWorkflow);
            if (enableFolderSecurityInheritancepropCount > 0)
            {
                callPayload.Body = enableFolderSecurityInheritance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFolderSecurityPermissionsResponse> GetFolderSecurityPermissions(Expression<Func<string>> getFolderSecurityPermissionsFolderPath, Expression<Func<string>> getFolderSecurityPermissionsWorkflow)
        {
            var apiCallPath = "/FileManagement/GetFolderSecurityPermissions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getFolderSecurityPermissions = new JObject();
            var getFolderSecurityPermissionspropCount = 0;
            getFolderSecurityPermissionspropCount++;
            getFolderSecurityPermissions["FolderPath"] = ExpressionConverter.ConvertO(getFolderSecurityPermissionsFolderPath);
            getFolderSecurityPermissionspropCount++;
            getFolderSecurityPermissions["Workflow"] = ExpressionConverter.ConvertO(getFolderSecurityPermissionsWorkflow);
            if (getFolderSecurityPermissionspropCount > 0)
            {
                callPayload.Body = getFolderSecurityPermissions;
            }

            return new ApiConnectionAction<GetFolderSecurityPermissionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileSecurityPermissionsResponse> GetFileSecurityPermissions(Expression<Func<string>> getFileSecurityPermissionsFilePath, Expression<Func<string>> getFileSecurityPermissionsWorkflow)
        {
            var apiCallPath = "/FileManagement/GetFileSecurityPermissions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getFileSecurityPermissions = new JObject();
            var getFileSecurityPermissionspropCount = 0;
            getFileSecurityPermissionspropCount++;
            getFileSecurityPermissions["FilePath"] = ExpressionConverter.ConvertO(getFileSecurityPermissionsFilePath);
            getFileSecurityPermissionspropCount++;
            getFileSecurityPermissions["Workflow"] = ExpressionConverter.ConvertO(getFileSecurityPermissionsWorkflow);
            if (getFileSecurityPermissionspropCount > 0)
            {
                callPayload.Body = getFileSecurityPermissions;
            }

            return new ApiConnectionAction<GetFileSecurityPermissionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RemoveIdentityFromFolderSecurityResponse> RemoveIdentityFromFolderSecurity(Expression<Func<string>> removeIdentityFromFolderSecurityFolderPath, Expression<Func<string>> removeIdentityFromFolderSecurityIdentityToRemove, Expression<Func<string>> removeIdentityFromFolderSecurityWorkflow)
        {
            var apiCallPath = "/FileManagement/RemoveIdentityFromFolderSecurity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var removeIdentityFromFolderSecurity = new JObject();
            var removeIdentityFromFolderSecuritypropCount = 0;
            removeIdentityFromFolderSecuritypropCount++;
            removeIdentityFromFolderSecurity["FolderPath"] = ExpressionConverter.ConvertO(removeIdentityFromFolderSecurityFolderPath);
            removeIdentityFromFolderSecuritypropCount++;
            removeIdentityFromFolderSecurity["IdentityToRemove"] = ExpressionConverter.ConvertO(removeIdentityFromFolderSecurityIdentityToRemove);
            removeIdentityFromFolderSecuritypropCount++;
            removeIdentityFromFolderSecurity["Workflow"] = ExpressionConverter.ConvertO(removeIdentityFromFolderSecurityWorkflow);
            if (removeIdentityFromFolderSecuritypropCount > 0)
            {
                callPayload.Body = removeIdentityFromFolderSecurity;
            }

            return new ApiConnectionAction<RemoveIdentityFromFolderSecurityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RemoveIdentityFromFileSecurityResponse> RemoveIdentityFromFileSecurity(Expression<Func<string>> removeIdentityFromFileSecurityFilePath, Expression<Func<string>> removeIdentityFromFileSecurityIdentityToRemove, Expression<Func<string>> removeIdentityFromFileSecurityWorkflow)
        {
            var apiCallPath = "/FileManagement/RemoveIdentityFromFileSecurity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var removeIdentityFromFileSecurity = new JObject();
            var removeIdentityFromFileSecuritypropCount = 0;
            removeIdentityFromFileSecuritypropCount++;
            removeIdentityFromFileSecurity["FilePath"] = ExpressionConverter.ConvertO(removeIdentityFromFileSecurityFilePath);
            removeIdentityFromFileSecuritypropCount++;
            removeIdentityFromFileSecurity["IdentityToRemove"] = ExpressionConverter.ConvertO(removeIdentityFromFileSecurityIdentityToRemove);
            removeIdentityFromFileSecuritypropCount++;
            removeIdentityFromFileSecurity["Workflow"] = ExpressionConverter.ConvertO(removeIdentityFromFileSecurityWorkflow);
            if (removeIdentityFromFileSecuritypropCount > 0)
            {
                callPayload.Body = removeIdentityFromFileSecurity;
            }

            return new ApiConnectionAction<RemoveIdentityFromFileSecurityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction CopyFileFromClientToServer(Expression<Func<string>> copyFileFromClientToServerClientFilePath, Expression<Func<string>> copyFileFromClientToServerServerFilePath, Expression<Func<string>> copyFileFromClientToServerWorkflow, Expression<Func<bool>> copyFileFromClientToServerCompress = null)
        {
            var apiCallPath = "/FileManagement/CopyFileFromClientToServer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var copyFileFromClientToServer = new JObject();
            var copyFileFromClientToServerpropCount = 0;
            copyFileFromClientToServerpropCount++;
            copyFileFromClientToServer["ClientFilePath"] = ExpressionConverter.ConvertO(copyFileFromClientToServerClientFilePath);
            copyFileFromClientToServerpropCount++;
            copyFileFromClientToServer["ServerFilePath"] = ExpressionConverter.ConvertO(copyFileFromClientToServerServerFilePath);
            if (copyFileFromClientToServerCompress != null)
            {
                copyFileFromClientToServer["Compress"] = ExpressionConverter.ConvertO(copyFileFromClientToServerCompress);
                copyFileFromClientToServerpropCount++;
            }

            copyFileFromClientToServerpropCount++;
            copyFileFromClientToServer["Workflow"] = ExpressionConverter.ConvertO(copyFileFromClientToServerWorkflow);
            if (copyFileFromClientToServerpropCount > 0)
            {
                callPayload.Body = copyFileFromClientToServer;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction ReplaceVariableDataInINIFile(Expression<Func<string>> replaceVariableDataInINIFileInputFilename, Expression<Func<string>> replaceVariableDataInINIFileWorkflow, Expression<Func<string>> replaceVariableDataInINIFileOutputFilename = null, Expression<Func<string>> replaceVariableDataInINIFileSearchSection = null, Expression<Func<string>> replaceVariableDataInINIFileSearchVariable = null, Expression<Func<string>> replaceVariableDataInINIFileReplaceData = null, Expression<Func<string>> replaceVariableDataInINIFileInputFilenameEncoding = null, Expression<Func<bool>> replaceVariableDataInINIFileCreateNewFileIfNotExists = null, Expression<Func<bool>> replaceVariableDataInINIFileWriteSpaceBeforeEquals = null, Expression<Func<bool>> replaceVariableDataInINIFileWriteSpaceAfterEquals = null)
        {
            var apiCallPath = "/FileManagement/ReplaceVariableDataInINIFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var replaceVariableDataInINIFile = new JObject();
            var replaceVariableDataInINIFilepropCount = 0;
            replaceVariableDataInINIFilepropCount++;
            replaceVariableDataInINIFile["InputFilename"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFileInputFilename);
            if (replaceVariableDataInINIFileOutputFilename != null)
            {
                replaceVariableDataInINIFile["OutputFilename"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFileOutputFilename);
                replaceVariableDataInINIFilepropCount++;
            }

            if (replaceVariableDataInINIFileSearchSection != null)
            {
                replaceVariableDataInINIFile["SearchSection"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFileSearchSection);
                replaceVariableDataInINIFilepropCount++;
            }

            if (replaceVariableDataInINIFileSearchVariable != null)
            {
                replaceVariableDataInINIFile["SearchVariable"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFileSearchVariable);
                replaceVariableDataInINIFilepropCount++;
            }

            if (replaceVariableDataInINIFileReplaceData != null)
            {
                replaceVariableDataInINIFile["ReplaceData"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFileReplaceData);
                replaceVariableDataInINIFilepropCount++;
            }

            if (replaceVariableDataInINIFileInputFilenameEncoding != null)
            {
                replaceVariableDataInINIFile["InputFilenameEncoding"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFileInputFilenameEncoding);
                replaceVariableDataInINIFilepropCount++;
            }

            if (replaceVariableDataInINIFileCreateNewFileIfNotExists != null)
            {
                replaceVariableDataInINIFile["CreateNewFileIfNotExists"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFileCreateNewFileIfNotExists);
                replaceVariableDataInINIFilepropCount++;
            }

            if (replaceVariableDataInINIFileWriteSpaceBeforeEquals != null)
            {
                replaceVariableDataInINIFile["WriteSpaceBeforeEquals"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFileWriteSpaceBeforeEquals);
                replaceVariableDataInINIFilepropCount++;
            }

            if (replaceVariableDataInINIFileWriteSpaceAfterEquals != null)
            {
                replaceVariableDataInINIFile["WriteSpaceAfterEquals"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFileWriteSpaceAfterEquals);
                replaceVariableDataInINIFilepropCount++;
            }

            replaceVariableDataInINIFilepropCount++;
            replaceVariableDataInINIFile["Workflow"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFileWorkflow);
            if (replaceVariableDataInINIFilepropCount > 0)
            {
                callPayload.Body = replaceVariableDataInINIFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DownloadHTTPFileResponse> DownloadHTTPFile(Expression<Func<string>> downloadHTTPFileDownloadURL, Expression<Func<string>> downloadHTTPFileWorkflow, Expression<Func<string>> downloadHTTPFileSaveFilename = null, Expression<Func<bool>> downloadHTTPFileOverwriteExistingFile = null, Expression<Func<bool>> downloadHTTPFilePassthroughAuthentication = null, Expression<Func<string>> downloadHTTPFileUserAgent = null, Expression<Func<string>> downloadHTTPFileAccept = null, Expression<Func<bool>> downloadHTTPFileSupportTLS10 = null, Expression<Func<bool>> downloadHTTPFileSupportTLS11 = null, Expression<Func<bool>> downloadHTTPFileSupportTLS12 = null, Expression<Func<bool>> downloadHTTPFileAutoDecompressDeflate = null, Expression<Func<bool>> downloadHTTPFileAutoDecompressGZIP = null, Expression<Func<bool>> downloadHTTPFileReturnContentsAsString = null, Expression<Func<downloadHTTPFileReturnContentEncodingInput>> downloadHTTPFileReturnContentEncoding = null)
        {
            var apiCallPath = "/FileManagement/DownloadHTTPFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var downloadHTTPFile = new JObject();
            var downloadHTTPFilepropCount = 0;
            downloadHTTPFilepropCount++;
            downloadHTTPFile["DownloadURL"] = ExpressionConverter.ConvertO(downloadHTTPFileDownloadURL);
            if (downloadHTTPFileSaveFilename != null)
            {
                downloadHTTPFile["SaveFilename"] = ExpressionConverter.ConvertO(downloadHTTPFileSaveFilename);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileOverwriteExistingFile != null)
            {
                downloadHTTPFile["OverwriteExistingFile"] = ExpressionConverter.ConvertO(downloadHTTPFileOverwriteExistingFile);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFilePassthroughAuthentication != null)
            {
                downloadHTTPFile["PassthroughAuthentication"] = ExpressionConverter.ConvertO(downloadHTTPFilePassthroughAuthentication);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileUserAgent != null)
            {
                downloadHTTPFile["UserAgent"] = ExpressionConverter.ConvertO(downloadHTTPFileUserAgent);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileAccept != null)
            {
                downloadHTTPFile["Accept"] = ExpressionConverter.ConvertO(downloadHTTPFileAccept);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileSupportTLS10 != null)
            {
                downloadHTTPFile["SupportTLS10"] = ExpressionConverter.ConvertO(downloadHTTPFileSupportTLS10);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileSupportTLS11 != null)
            {
                downloadHTTPFile["SupportTLS11"] = ExpressionConverter.ConvertO(downloadHTTPFileSupportTLS11);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileSupportTLS12 != null)
            {
                downloadHTTPFile["SupportTLS12"] = ExpressionConverter.ConvertO(downloadHTTPFileSupportTLS12);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileAutoDecompressDeflate != null)
            {
                downloadHTTPFile["AutoDecompressDeflate"] = ExpressionConverter.ConvertO(downloadHTTPFileAutoDecompressDeflate);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileAutoDecompressGZIP != null)
            {
                downloadHTTPFile["AutoDecompressGZIP"] = ExpressionConverter.ConvertO(downloadHTTPFileAutoDecompressGZIP);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileReturnContentsAsString != null)
            {
                downloadHTTPFile["ReturnContentsAsString"] = ExpressionConverter.ConvertO(downloadHTTPFileReturnContentsAsString);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileReturnContentEncoding != null)
            {
                downloadHTTPFile["ReturnContentEncoding"] = ExpressionConverter.ConvertO(downloadHTTPFileReturnContentEncoding);
                downloadHTTPFilepropCount++;
            }

            downloadHTTPFilepropCount++;
            downloadHTTPFile["Workflow"] = ExpressionConverter.ConvertO(downloadHTTPFileWorkflow);
            if (downloadHTTPFilepropCount > 0)
            {
                callPayload.Body = downloadHTTPFile;
            }

            return new ApiConnectionAction<DownloadHTTPFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UnZIPFileResponse> UnZIPFile(Expression<Func<string>> unZIPFileZIPFilename, Expression<Func<string>> unZIPFileWorkflow, Expression<Func<string>> unZIPFileExtractFolder = null, Expression<Func<bool>> unZIPFileExtractAllFilesToSingleFolder = null, Expression<Func<string>> unZIPFileIncludeFilesRegEx = null, Expression<Func<string>> unZIPFileExcludeFilesRegEx = null)
        {
            var apiCallPath = "/FileManagement/UnZIPFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var unZIPFile = new JObject();
            var unZIPFilepropCount = 0;
            unZIPFilepropCount++;
            unZIPFile["ZIPFilename"] = ExpressionConverter.ConvertO(unZIPFileZIPFilename);
            if (unZIPFileExtractFolder != null)
            {
                unZIPFile["ExtractFolder"] = ExpressionConverter.ConvertO(unZIPFileExtractFolder);
                unZIPFilepropCount++;
            }

            if (unZIPFileExtractAllFilesToSingleFolder != null)
            {
                unZIPFile["ExtractAllFilesToSingleFolder"] = ExpressionConverter.ConvertO(unZIPFileExtractAllFilesToSingleFolder);
                unZIPFilepropCount++;
            }

            if (unZIPFileIncludeFilesRegEx != null)
            {
                unZIPFile["IncludeFilesRegEx"] = ExpressionConverter.ConvertO(unZIPFileIncludeFilesRegEx);
                unZIPFilepropCount++;
            }

            if (unZIPFileExcludeFilesRegEx != null)
            {
                unZIPFile["ExcludeFilesRegEx"] = ExpressionConverter.ConvertO(unZIPFileExcludeFilesRegEx);
                unZIPFilepropCount++;
            }

            unZIPFilepropCount++;
            unZIPFile["Workflow"] = ExpressionConverter.ConvertO(unZIPFileWorkflow);
            if (unZIPFilepropCount > 0)
            {
                callPayload.Body = unZIPFile;
            }

            return new ApiConnectionAction<UnZIPFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction AddFileToZIP(Expression<Func<string>> addFileToZIPSourceFilenameToAddToZIP, Expression<Func<string>> addFileToZIPOutputZIPFilename, Expression<Func<string>> addFileToZIPWorkflow, Expression<Func<string>> addFileToZIPAddFilenameToFolderInZIP = null, Expression<Func<string>> addFileToZIPSourceFilenameToAddToZIPComment = null, Expression<Func<bool>> addFileToZIPCompress = null, Expression<Func<bool>> addFileToZIPAddToExistingZIPFile = null)
        {
            var apiCallPath = "/FileManagement/AddFileToZIP";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addFileToZIP = new JObject();
            var addFileToZIPpropCount = 0;
            addFileToZIPpropCount++;
            addFileToZIP["SourceFilenameToAddToZIP"] = ExpressionConverter.ConvertO(addFileToZIPSourceFilenameToAddToZIP);
            addFileToZIPpropCount++;
            addFileToZIP["OutputZIPFilename"] = ExpressionConverter.ConvertO(addFileToZIPOutputZIPFilename);
            if (addFileToZIPAddFilenameToFolderInZIP != null)
            {
                addFileToZIP["AddFilenameToFolderInZIP"] = ExpressionConverter.ConvertO(addFileToZIPAddFilenameToFolderInZIP);
                addFileToZIPpropCount++;
            }

            if (addFileToZIPSourceFilenameToAddToZIPComment != null)
            {
                addFileToZIP["SourceFilenameToAddToZIPComment"] = ExpressionConverter.ConvertO(addFileToZIPSourceFilenameToAddToZIPComment);
                addFileToZIPpropCount++;
            }

            if (addFileToZIPCompress != null)
            {
                addFileToZIP["Compress"] = ExpressionConverter.ConvertO(addFileToZIPCompress);
                addFileToZIPpropCount++;
            }

            if (addFileToZIPAddToExistingZIPFile != null)
            {
                addFileToZIP["AddToExistingZIPFile"] = ExpressionConverter.ConvertO(addFileToZIPAddToExistingZIPFile);
                addFileToZIPpropCount++;
            }

            addFileToZIPpropCount++;
            addFileToZIP["Workflow"] = ExpressionConverter.ConvertO(addFileToZIPWorkflow);
            if (addFileToZIPpropCount > 0)
            {
                callPayload.Body = addFileToZIP;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AddFolderToZIPResponse> AddFolderToZIP(Expression<Func<string>> addFolderToZIPSourceFolderToAddToZIP, Expression<Func<string>> addFolderToZIPOutputZIPFilename, Expression<Func<string>> addFolderToZIPWorkflow, Expression<Func<string>> addFolderToZIPAddFilesToFolderInZIP = null, Expression<Func<bool>> addFolderToZIPCompress = null, Expression<Func<bool>> addFolderToZIPAddToExistingZIPFile = null, Expression<Func<bool>> addFolderToZIPIncludeSubfolders = null, Expression<Func<string>> addFolderToZIPIncludeFilesRegEx = null, Expression<Func<string>> addFolderToZIPExcludeFilesRegEx = null)
        {
            var apiCallPath = "/FileManagement/AddFolderToZIP";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addFolderToZIP = new JObject();
            var addFolderToZIPpropCount = 0;
            addFolderToZIPpropCount++;
            addFolderToZIP["SourceFolderToAddToZIP"] = ExpressionConverter.ConvertO(addFolderToZIPSourceFolderToAddToZIP);
            addFolderToZIPpropCount++;
            addFolderToZIP["OutputZIPFilename"] = ExpressionConverter.ConvertO(addFolderToZIPOutputZIPFilename);
            if (addFolderToZIPAddFilesToFolderInZIP != null)
            {
                addFolderToZIP["AddFilesToFolderInZIP"] = ExpressionConverter.ConvertO(addFolderToZIPAddFilesToFolderInZIP);
                addFolderToZIPpropCount++;
            }

            if (addFolderToZIPCompress != null)
            {
                addFolderToZIP["Compress"] = ExpressionConverter.ConvertO(addFolderToZIPCompress);
                addFolderToZIPpropCount++;
            }

            if (addFolderToZIPAddToExistingZIPFile != null)
            {
                addFolderToZIP["AddToExistingZIPFile"] = ExpressionConverter.ConvertO(addFolderToZIPAddToExistingZIPFile);
                addFolderToZIPpropCount++;
            }

            if (addFolderToZIPIncludeSubfolders != null)
            {
                addFolderToZIP["IncludeSubfolders"] = ExpressionConverter.ConvertO(addFolderToZIPIncludeSubfolders);
                addFolderToZIPpropCount++;
            }

            if (addFolderToZIPIncludeFilesRegEx != null)
            {
                addFolderToZIP["IncludeFilesRegEx"] = ExpressionConverter.ConvertO(addFolderToZIPIncludeFilesRegEx);
                addFolderToZIPpropCount++;
            }

            if (addFolderToZIPExcludeFilesRegEx != null)
            {
                addFolderToZIP["ExcludeFilesRegEx"] = ExpressionConverter.ConvertO(addFolderToZIPExcludeFilesRegEx);
                addFolderToZIPpropCount++;
            }

            addFolderToZIPpropCount++;
            addFolderToZIP["Workflow"] = ExpressionConverter.ConvertO(addFolderToZIPWorkflow);
            if (addFolderToZIPpropCount > 0)
            {
                callPayload.Body = addFolderToZIP;
            }

            return new ApiConnectionAction<AddFolderToZIPResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileContentsAsBase64Response> GetFileContentsAsBase64(Expression<Func<string>> getFileContentsAsBase64FilePath, Expression<Func<string>> getFileContentsAsBase64Workflow, Expression<Func<bool>> getFileContentsAsBase64Compress = null, Expression<Func<int>> getFileContentsAsBase64MaxFileSize = null)
        {
            var apiCallPath = "/FileManagement/GetFileContentsAsBase64";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getFileContentsAsBase64 = new JObject();
            var getFileContentsAsBase64propCount = 0;
            getFileContentsAsBase64propCount++;
            getFileContentsAsBase64["FilePath"] = ExpressionConverter.ConvertO(getFileContentsAsBase64FilePath);
            if (getFileContentsAsBase64Compress != null)
            {
                getFileContentsAsBase64["Compress"] = ExpressionConverter.ConvertO(getFileContentsAsBase64Compress);
                getFileContentsAsBase64propCount++;
            }

            if (getFileContentsAsBase64MaxFileSize != null)
            {
                getFileContentsAsBase64["MaxFileSize"] = ExpressionConverter.ConvertO(getFileContentsAsBase64MaxFileSize);
                getFileContentsAsBase64propCount++;
            }

            getFileContentsAsBase64propCount++;
            getFileContentsAsBase64["Workflow"] = ExpressionConverter.ConvertO(getFileContentsAsBase64Workflow);
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

    public enum runProcessWindowStyleInput
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

    public enum runProcessStandardOutputEncodingInput
    {
        UTF8,
        UTF7,
        UTF16,
        ASCII,
        UTF16BE
    }

    public enum runProcessStandardErrorEncodingInput
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

    public enum runPowerShellProcessWindowStyleInput
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

    public enum runPowerShellProcessStandardOutputEncodingInput
    {
        UTF8,
        UTF7,
        UTF16,
        ASCII,
        UTF16BE
    }

    public enum runPowerShellProcessStandardErrorEncodingInput
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

    public enum setMouseMoveMethodMouseMoveMethodInput
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

    public enum takeScreenshotImageFormatInput
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

    public enum generatePasswordGenerateAtInput
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

    public enum credentialWriteCredentialTypeInput
    {
        Windows,
        Generic
    }

    public enum credentialWriteCredentialPersistenceInput
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

    public enum credentialReadCredentialTypeInput
    {
        Windows,
        Generic
    }

    public class CredentialDeleteResponse
    {
        public bool CredentialDeleteResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public enum credentialDeleteCredentialTypeInput
    {
        Windows,
        Generic
    }

    public class GenerateRDPFileResponse
    {
        public string RDPFilePath { get; set; }
    }

    public enum generateRDPFileCredentialTypeInput
    {
        Windows,
        Generic
    }

    public enum generateRDPFileCredentialPersistenceInput
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

    public enum convertRectangleCoordinatesConversionTypeInput
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

    public enum sendMessageToWebAPIMethodInput
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

    public enum sendMessageToWebAPITransmitEncodingInput
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

    public enum sendMessageToWebAPIResponseEncodingInput
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

    public class sendMessageToWebAPIHTTPRequestHeadersListInputItem
    {
        public string Property { get; set; }
        public string Value { get; set; }
    }

    public class TasksAddNewTaskResponse
    {
        public int TaskId { get; set; }
    }

    public enum tasksAddNewTaskSetAutomationNameInput
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

    public enum tasksAddNewDeferralSetAutomationNameInput
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

    public enum tasksGetAllTasksAutomationTaskStatusInput
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

    public enum tasksGetTaskStatusChangeInput
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

    public enum tasksGetNextTaskStatusChangeInput
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

    public enum tasksChangeTaskStatusAutomationTaskStatusInput
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

    public enum tasksAddNoteNoteTypeInput
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

    public enum attachToIAConnectSessionByIndexSearchIAConnectSessionTypeInput
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

    public enum attachToMostRecentIAConnectSessionSearchIAConnectSessionTypeInput
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

    public enum setAgentGlobalCoordinateConfigurationMultiMonitorFunctionalityInput
    {
        NotSet,
        [EnumMember(Value = "PrimaryMonitor")]
        PrimaryDisplayOnly,
        [EnumMember(Value = "MultiMonitor")]
        AllDisplays
    }

    public enum setAgentGlobalCoordinateConfigurationAutoSetMouseInspectionMultiplierInput
    {
        [EnumMember(Value = "Auto")]
        Automatic,
        Manual,
        NotSet
    }

    public enum setAgentGlobalCoordinateConfigurationAutoSetGlobalMouseMultiplierInput
    {
        [EnumMember(Value = "Auto")]
        Automatic,
        Manual,
        NotSet
    }

    public enum setAgentGlobalCoordinateConfigurationJavaCoordinateSystemInput
    {
        NotSet,
        Virtual,
        Physical
    }

    public enum setAgentGlobalCoordinateConfigurationSAPGUICoordinateSystemInput
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

    public enum getAgentThreadsSortOrderInput
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

    public enum writeTextFileEncodingInput
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

    public enum writeCollectionToCSVFileOutputEncodingInput
    {
        UTF8,
        UTF7,
        Unicode,
        ASCII
    }

    public enum addPermissionToFolderPermissionInput
    {
        Read,
        ReadAndExecute,
        Modify,
        FullControl
    }

    public enum addPermissionToFilePermissionInput
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

    public enum downloadHTTPFileReturnContentEncodingInput
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