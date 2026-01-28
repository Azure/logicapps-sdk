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
            getMachineName["Workflow"] = ExpressionConverter.ConvertO(getMachineNameworkflow);
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
            getMachineDomain["Workflow"] = ExpressionConverter.ConvertO(getMachineDomainworkflow);
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
            getRemoteSessionClientHostname["Workflow"] = ExpressionConverter.ConvertO(getRemoteSessionClientHostnameworkflow);
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
        public IBodyWorkflowAction<KillProcessResponse> KillProcess(Expression<Func<string>> killProcessprocessName, Expression<Func<string>> killProcessworkflow)
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
        public IBodyWorkflowAction<KillProcessIDResponse> KillProcessID(Expression<Func<int>> killProcessIDprocessID, Expression<Func<string>> killProcessIDworkflow)
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
        public IBodyWorkflowAction<GetProcessCountByNameResponse> GetProcessCountByName(Expression<Func<string>> getProcessCountByNameprocessName, Expression<Func<string>> getProcessCountByNameworkflow)
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
        public IBodyWorkflowAction<GetAgentProcessCountResponse> GetAgentProcessCount(Expression<Func<string>> getAgentProcessCountworkflow)
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
        public IBodyWorkflowAction<KillAllOtherAgentsResponse> KillAllOtherAgents(Expression<Func<string>> killAllOtherAgentsworkflow)
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
        public IBodyWorkflowAction<GetProcessByPIDResponse> GetProcessByPID(Expression<Func<int>> getProcessByPIDprocessId, Expression<Func<string>> getProcessByPIDworkflow)
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
        public IBodyWorkflowAction<GetProcessesResponse> GetProcesses(Expression<Func<string>> getProcessesworkflow, Expression<Func<string>> getProcessesprocessName = null, Expression<Func<bool>> getProcessesgetProcessCommandLine = null)
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
                getProcesses["GetProcessCommandLine"] = ExpressionConverter.ConvertO(getProcessesgetProcessCommandLine);
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
        public IBodyWorkflowAction<RunProcessResponse> RunProcess(Expression<Func<string>> runProcessprocessName, Expression<Func<string>> runProcessworkflow, Expression<Func<string>> runProcessarguments = null, Expression<Func<string>> runProcessworkingDirectory = null, Expression<Func<bool>> runProcessuseShellExecute = null, Expression<Func<bool>> runProcesscreateNoWindow = null, Expression<Func<runProcesswindowStyleInput>> runProcesswindowStyle = null, Expression<Func<bool>> runProcesswaitForProcess = null, Expression<Func<bool>> runProcessredirectStandardOutput = null, Expression<Func<bool>> runProcessredirectStandardError = null, Expression<Func<bool>> runProcessredirectStandardErrorToOutput = null, Expression<Func<runProcessstandardOutputEncodingInput>> runProcessstandardOutputEncoding = null, Expression<Func<runProcessstandardErrorEncodingInput>> runProcessstandardErrorEncoding = null, Expression<Func<string>> runProcessrunAsDomain = null, Expression<Func<string>> runProcessrunAsUsername = null, Expression<Func<string>> runProcessrunAsPassword = null, Expression<Func<bool>> runProcessrunAsLoadUserProfile = null, Expression<Func<bool>> runProcessrunAsElevate = null, Expression<Func<int>> runProcesstimeoutInSeconds = null)
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
                runProcess["UseShellExecute"] = ExpressionConverter.ConvertO(runProcessuseShellExecute);
                runProcesspropCount++;
            }

            if (runProcesscreateNoWindow != null)
            {
                runProcess["CreateNoWindow"] = ExpressionConverter.ConvertO(runProcesscreateNoWindow);
                runProcesspropCount++;
            }

            if (runProcesswindowStyle != null)
            {
                runProcess["WindowStyle"] = ExpressionConverter.ConvertO(runProcesswindowStyle);
                runProcesspropCount++;
            }

            if (runProcesswaitForProcess != null)
            {
                runProcess["WaitForProcess"] = ExpressionConverter.ConvertO(runProcesswaitForProcess);
                runProcesspropCount++;
            }

            if (runProcessredirectStandardOutput != null)
            {
                runProcess["RedirectStandardOutput"] = ExpressionConverter.ConvertO(runProcessredirectStandardOutput);
                runProcesspropCount++;
            }

            if (runProcessredirectStandardError != null)
            {
                runProcess["RedirectStandardError"] = ExpressionConverter.ConvertO(runProcessredirectStandardError);
                runProcesspropCount++;
            }

            if (runProcessredirectStandardErrorToOutput != null)
            {
                runProcess["RedirectStandardErrorToOutput"] = ExpressionConverter.ConvertO(runProcessredirectStandardErrorToOutput);
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
                runProcess["RunAsLoadUserProfile"] = ExpressionConverter.ConvertO(runProcessrunAsLoadUserProfile);
                runProcesspropCount++;
            }

            if (runProcessrunAsElevate != null)
            {
                runProcess["RunAsElevate"] = ExpressionConverter.ConvertO(runProcessrunAsElevate);
                runProcesspropCount++;
            }

            if (runProcesstimeoutInSeconds != null)
            {
                runProcess["TimeoutInSeconds"] = ExpressionConverter.ConvertO(runProcesstimeoutInSeconds);
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
        public IBodyWorkflowAction<RunPowerShellProcessResponse> RunPowerShellProcess(Expression<Func<string>> runPowerShellProcessworkflow, Expression<Func<string>> runPowerShellProcesspowerShellExecutable = null, Expression<Func<string>> runPowerShellProcesspowerShellScriptFilePath = null, Expression<Func<string>> runPowerShellProcesspowerShellScriptContents = null, Expression<Func<string>> runPowerShellProcessworkingDirectory = null, Expression<Func<bool>> runPowerShellProcesscreateNoWindow = null, Expression<Func<runPowerShellProcesswindowStyleInput>> runPowerShellProcesswindowStyle = null, Expression<Func<bool>> runPowerShellProcesswaitForProcess = null, Expression<Func<bool>> runPowerShellProcessredirectStandardOutput = null, Expression<Func<bool>> runPowerShellProcessredirectStandardError = null, Expression<Func<bool>> runPowerShellProcessredirectStandardErrorToOutput = null, Expression<Func<runPowerShellProcessstandardOutputEncodingInput>> runPowerShellProcessstandardOutputEncoding = null, Expression<Func<runPowerShellProcessstandardErrorEncodingInput>> runPowerShellProcessstandardErrorEncoding = null, Expression<Func<string>> runPowerShellProcessrunAsDomain = null, Expression<Func<string>> runPowerShellProcessrunAsUsername = null, Expression<Func<string>> runPowerShellProcessrunAsPassword = null, Expression<Func<bool>> runPowerShellProcessrunAsLoadUserProfile = null, Expression<Func<bool>> runPowerShellProcessrunAsElevate = null, Expression<Func<int>> runPowerShellProcesstimeoutInSeconds = null, Expression<Func<string>> runPowerShellProcesspowerShellScriptTempFolder = null)
        {
            var apiCallPath = "/Environment/RunPowerShellProcess";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runPowerShellProcess = new JObject();
            var runPowerShellProcesspropCount = 0;
            if (runPowerShellProcesspowerShellExecutable != null)
            {
                runPowerShellProcess["PowerShellExecutable"] = ExpressionConverter.ConvertO(runPowerShellProcesspowerShellExecutable);
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
                runPowerShellProcess["CreateNoWindow"] = ExpressionConverter.ConvertO(runPowerShellProcesscreateNoWindow);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcesswindowStyle != null)
            {
                runPowerShellProcess["WindowStyle"] = ExpressionConverter.ConvertO(runPowerShellProcesswindowStyle);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcesswaitForProcess != null)
            {
                runPowerShellProcess["WaitForProcess"] = ExpressionConverter.ConvertO(runPowerShellProcesswaitForProcess);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessredirectStandardOutput != null)
            {
                runPowerShellProcess["RedirectStandardOutput"] = ExpressionConverter.ConvertO(runPowerShellProcessredirectStandardOutput);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessredirectStandardError != null)
            {
                runPowerShellProcess["RedirectStandardError"] = ExpressionConverter.ConvertO(runPowerShellProcessredirectStandardError);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessredirectStandardErrorToOutput != null)
            {
                runPowerShellProcess["RedirectStandardErrorToOutput"] = ExpressionConverter.ConvertO(runPowerShellProcessredirectStandardErrorToOutput);
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
                runPowerShellProcess["RunAsLoadUserProfile"] = ExpressionConverter.ConvertO(runPowerShellProcessrunAsLoadUserProfile);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcessrunAsElevate != null)
            {
                runPowerShellProcess["RunAsElevate"] = ExpressionConverter.ConvertO(runPowerShellProcessrunAsElevate);
                runPowerShellProcesspropCount++;
            }

            if (runPowerShellProcesstimeoutInSeconds != null)
            {
                runPowerShellProcess["TimeoutInSeconds"] = ExpressionConverter.ConvertO(runPowerShellProcesstimeoutInSeconds);
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
        public IBodyWorkflowAction<GetScreenResolutionResponse> GetScreenResolution(Expression<Func<string>> getScreenResolutionworkflow)
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
        public IWorkflowAction SetDefaultPrinter(Expression<Func<string>> setDefaultPrinterdefaultPrinterName, Expression<Func<string>> setDefaultPrinterworkflow)
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
        public IBodyWorkflowAction<GetDefaultPrinterResponse> GetDefaultPrinter(Expression<Func<string>> getDefaultPrinterworkflow)
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
        public IBodyWorkflowAction<GetListOfPrintersResponse> GetListOfPrinters(Expression<Func<string>> getListOfPrintersworkflow, Expression<Func<bool>> getListOfPrinterslistLocalPrinters = null, Expression<Func<bool>> getListOfPrinterslistNetworkPrinters = null, Expression<Func<bool>> getListOfPrintersreturnDetailedInformation = null)
        {
            var apiCallPath = "/Environment/GetListOfPrinters";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getListOfPrinters = new JObject();
            var getListOfPrinterspropCount = 0;
            if (getListOfPrinterslistLocalPrinters != null)
            {
                getListOfPrinters["ListLocalPrinters"] = ExpressionConverter.ConvertO(getListOfPrinterslistLocalPrinters);
                getListOfPrinterspropCount++;
            }

            if (getListOfPrinterslistNetworkPrinters != null)
            {
                getListOfPrinters["ListNetworkPrinters"] = ExpressionConverter.ConvertO(getListOfPrinterslistNetworkPrinters);
                getListOfPrinterspropCount++;
            }

            if (getListOfPrintersreturnDetailedInformation != null)
            {
                getListOfPrinters["ReturnDetailedInformation"] = ExpressionConverter.ConvertO(getListOfPrintersreturnDetailedInformation);
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
        public IWorkflowAction SetMouseMultiplier(Expression<Func<string>> setMouseMultiplierworkflow, Expression<Func<double>> setMouseMultipliermouseXMultiplier = null, Expression<Func<double>> setMouseMultipliermouseYMultiplier = null, Expression<Func<bool>> setMouseMultiplierapplyToMouseEvent = null, Expression<Func<bool>> setMouseMultiplierapplyToSetCursorPos = null, Expression<Func<bool>> setMouseMultiplierapplyToCurrentMouseMoveMethod = null)
        {
            var apiCallPath = "/Environment/SetMouseMultiplier";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setMouseMultiplier = new JObject();
            var setMouseMultiplierpropCount = 0;
            if (setMouseMultipliermouseXMultiplier != null)
            {
                setMouseMultiplier["MouseXMultiplier"] = ExpressionConverter.ConvertO(setMouseMultipliermouseXMultiplier);
                setMouseMultiplierpropCount++;
            }

            if (setMouseMultipliermouseYMultiplier != null)
            {
                setMouseMultiplier["MouseYMultiplier"] = ExpressionConverter.ConvertO(setMouseMultipliermouseYMultiplier);
                setMouseMultiplierpropCount++;
            }

            if (setMouseMultiplierapplyToMouseEvent != null)
            {
                setMouseMultiplier["ApplyToMouseEvent"] = ExpressionConverter.ConvertO(setMouseMultiplierapplyToMouseEvent);
                setMouseMultiplierpropCount++;
            }

            if (setMouseMultiplierapplyToSetCursorPos != null)
            {
                setMouseMultiplier["ApplyToSetCursorPos"] = ExpressionConverter.ConvertO(setMouseMultiplierapplyToSetCursorPos);
                setMouseMultiplierpropCount++;
            }

            if (setMouseMultiplierapplyToCurrentMouseMoveMethod != null)
            {
                setMouseMultiplier["ApplyToCurrentMouseMoveMethod"] = ExpressionConverter.ConvertO(setMouseMultiplierapplyToCurrentMouseMoveMethod);
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
        public IBodyWorkflowAction<GetMouseMultiplierResponse> GetMouseMultiplier(Expression<Func<string>> getMouseMultiplierworkflow)
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
        public IWorkflowAction MoveMouseToCoordinate(Expression<Func<int>> moveMouseToCoordinatexCoord, Expression<Func<int>> moveMouseToCoordinateyCoord, Expression<Func<string>> moveMouseToCoordinateworkflow)
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
        public IWorkflowAction MoveMouseRelative(Expression<Func<int>> moveMouseRelativexCoord, Expression<Func<int>> moveMouseRelativeyCoord, Expression<Func<string>> moveMouseRelativeworkflow)
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
        public IWorkflowAction LeftMouseButtonDown(Expression<Func<string>> leftMouseButtonDownworkflow)
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
        public IWorkflowAction LeftMouseButtonUp(Expression<Func<string>> leftMouseButtonUpworkflow)
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
        public IWorkflowAction LeftClickMouse(Expression<Func<string>> leftClickMouseworkflow)
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
        public IWorkflowAction LeftClickMouseAtCoordinate(Expression<Func<int>> leftClickMouseAtCoordinatexCoord, Expression<Func<int>> leftClickMouseAtCoordinateyCoord, Expression<Func<string>> leftClickMouseAtCoordinateworkflow)
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
        public IWorkflowAction LeftHoldMouse(Expression<Func<double>> leftHoldMousesecondsToHold, Expression<Func<string>> leftHoldMouseworkflow)
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
        public IWorkflowAction LeftHoldMouseAtCoordinate(Expression<Func<int>> leftHoldMouseAtCoordinatexCoord, Expression<Func<int>> leftHoldMouseAtCoordinateyCoord, Expression<Func<double>> leftHoldMouseAtCoordinatesecondsToHold, Expression<Func<string>> leftHoldMouseAtCoordinateworkflow)
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
        public IWorkflowAction RightMouseButtonDown(Expression<Func<string>> rightMouseButtonDownworkflow)
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
        public IWorkflowAction RightMouseButtonUp(Expression<Func<string>> rightMouseButtonUpworkflow)
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
        public IWorkflowAction RightClickMouse(Expression<Func<string>> rightClickMouseworkflow)
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
        public IWorkflowAction RightClickMouseAtCoordinate(Expression<Func<int>> rightClickMouseAtCoordinatexCoord, Expression<Func<int>> rightClickMouseAtCoordinateyCoord, Expression<Func<string>> rightClickMouseAtCoordinateworkflow)
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
        public IWorkflowAction RightHoldMouse(Expression<Func<double>> rightHoldMousesecondsToHold, Expression<Func<string>> rightHoldMouseworkflow)
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
        public IWorkflowAction RightHoldMouseAtCoordinate(Expression<Func<int>> rightHoldMouseAtCoordinatexCoord, Expression<Func<int>> rightHoldMouseAtCoordinateyCoord, Expression<Func<double>> rightHoldMouseAtCoordinatesecondsToHold, Expression<Func<string>> rightHoldMouseAtCoordinateworkflow)
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
        public IWorkflowAction MiddleMouseButtonDown(Expression<Func<string>> middleMouseButtonDownworkflow)
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
        public IWorkflowAction MiddleMouseButtonUp(Expression<Func<string>> middleMouseButtonUpworkflow)
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
        public IWorkflowAction MiddleClickMouse(Expression<Func<string>> middleClickMouseworkflow)
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
        public IWorkflowAction MiddleClickMouseAtCoordinate(Expression<Func<int>> middleClickMouseAtCoordinatexCoord, Expression<Func<int>> middleClickMouseAtCoordinateyCoord, Expression<Func<string>> middleClickMouseAtCoordinateworkflow)
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
        public IWorkflowAction MiddleHoldMouse(Expression<Func<double>> middleHoldMousesecondsToHold, Expression<Func<string>> middleHoldMouseworkflow)
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
        public IWorkflowAction MiddleHoldMouseAtCoordinate(Expression<Func<int>> middleHoldMouseAtCoordinatexCoord, Expression<Func<int>> middleHoldMouseAtCoordinateyCoord, Expression<Func<double>> middleHoldMouseAtCoordinatesecondsToHold, Expression<Func<string>> middleHoldMouseAtCoordinateworkflow)
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
        public IWorkflowAction DoubleLeftClickMouse(Expression<Func<string>> doubleLeftClickMouseworkflow, Expression<Func<int>> doubleLeftClickMousedelayInMilliseconds = null)
        {
            var apiCallPath = "/Environment/DoubleLeftClickMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var doubleLeftClickMouse = new JObject();
            var doubleLeftClickMousepropCount = 0;
            if (doubleLeftClickMousedelayInMilliseconds != null)
            {
                doubleLeftClickMouse["DelayInMilliseconds"] = ExpressionConverter.ConvertO(doubleLeftClickMousedelayInMilliseconds);
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
        public IWorkflowAction DoubleLeftClickMouseAtCoordinate(Expression<Func<int>> doubleLeftClickMouseAtCoordinatexCoord, Expression<Func<int>> doubleLeftClickMouseAtCoordinateyCoord, Expression<Func<string>> doubleLeftClickMouseAtCoordinateworkflow, Expression<Func<int>> doubleLeftClickMouseAtCoordinatedelayInMilliseconds = null)
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
                doubleLeftClickMouseAtCoordinate["DelayInMilliseconds"] = ExpressionConverter.ConvertO(doubleLeftClickMouseAtCoordinatedelayInMilliseconds);
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
        public IWorkflowAction LeftMouseDragBetweenCoordinates(Expression<Func<int>> leftMouseDragBetweenCoordinatesstartXCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesstartYCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesendXCoord, Expression<Func<int>> leftMouseDragBetweenCoordinatesendYCoord, Expression<Func<string>> leftMouseDragBetweenCoordinatesworkflow, Expression<Func<int>> leftMouseDragBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> leftMouseDragBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
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
                leftMouseDragBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesnumberOfSteps);
                leftMouseDragBetweenCoordinatespropCount++;
            }

            if (leftMouseDragBetweenCoordinatestotalTimeInSeconds != null)
            {
                leftMouseDragBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatestotalTimeInSeconds);
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
                leftMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(leftMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
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
        public IWorkflowAction RightMouseDragBetweenCoordinates(Expression<Func<int>> rightMouseDragBetweenCoordinatesstartXCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesstartYCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesendXCoord, Expression<Func<int>> rightMouseDragBetweenCoordinatesendYCoord, Expression<Func<string>> rightMouseDragBetweenCoordinatesworkflow, Expression<Func<int>> rightMouseDragBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> rightMouseDragBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
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
                rightMouseDragBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesnumberOfSteps);
                rightMouseDragBetweenCoordinatespropCount++;
            }

            if (rightMouseDragBetweenCoordinatestotalTimeInSeconds != null)
            {
                rightMouseDragBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatestotalTimeInSeconds);
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
                rightMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(rightMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
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
        public IWorkflowAction MiddleMouseDragBetweenCoordinates(Expression<Func<int>> middleMouseDragBetweenCoordinatesstartXCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesstartYCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesendXCoord, Expression<Func<int>> middleMouseDragBetweenCoordinatesendYCoord, Expression<Func<string>> middleMouseDragBetweenCoordinatesworkflow, Expression<Func<int>> middleMouseDragBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> middleMouseDragBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
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
                middleMouseDragBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesnumberOfSteps);
                middleMouseDragBetweenCoordinatespropCount++;
            }

            if (middleMouseDragBetweenCoordinatestotalTimeInSeconds != null)
            {
                middleMouseDragBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatestotalTimeInSeconds);
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
                middleMouseDragBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(middleMouseDragBetweenCoordinatesmaximumMovementPixelJitterDelta);
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
        public IWorkflowAction MoveMouseBetweenCoordinates(Expression<Func<int>> moveMouseBetweenCoordinatesstartXCoord, Expression<Func<int>> moveMouseBetweenCoordinatesstartYCoord, Expression<Func<int>> moveMouseBetweenCoordinatesendXCoord, Expression<Func<int>> moveMouseBetweenCoordinatesendYCoord, Expression<Func<string>> moveMouseBetweenCoordinatesworkflow, Expression<Func<int>> moveMouseBetweenCoordinatesnumberOfSteps = null, Expression<Func<double>> moveMouseBetweenCoordinatestotalTimeInSeconds = null, Expression<Func<int>> moveMouseBetweenCoordinatesmaximumMovementPixelJitter = null, Expression<Func<int>> moveMouseBetweenCoordinatesmaximumEndPixelJitter = null, Expression<Func<int>> moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta = null)
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
                moveMouseBetweenCoordinates["NumberOfSteps"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesnumberOfSteps);
                moveMouseBetweenCoordinatespropCount++;
            }

            if (moveMouseBetweenCoordinatestotalTimeInSeconds != null)
            {
                moveMouseBetweenCoordinates["TotalTimeInSeconds"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatestotalTimeInSeconds);
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
                moveMouseBetweenCoordinates["MaximumMovementPixelJitterDelta"] = ExpressionConverter.ConvertO(moveMouseBetweenCoordinatesmaximumMovementPixelJitterDelta);
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
        public IWorkflowAction TurnMouseWheel(Expression<Func<int>> turnMouseWheelwheelTurns, Expression<Func<string>> turnMouseWheelworkflow)
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
        public IWorkflowAction SetCursorPos(Expression<Func<int>> setCursorPosx, Expression<Func<int>> setCursorPosy, Expression<Func<string>> setCursorPosworkflow)
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
        public IBodyWorkflowAction<GetCursorPosResponse> GetCursorPos(Expression<Func<string>> getCursorPosworkflow)
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
        public IBodyWorkflowAction<CalibrateMouseEventResponse> CalibrateMouseEvent(Expression<Func<string>> calibrateMouseEventworkflow, Expression<Func<int>> calibrateMouseEventcalibrationSizeInPixels = null)
        {
            var apiCallPath = "/Environment/CalibrateMouseEvent";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var calibrateMouseEvent = new JObject();
            var calibrateMouseEventpropCount = 0;
            if (calibrateMouseEventcalibrationSizeInPixels != null)
            {
                calibrateMouseEvent["CalibrationSizeInPixels"] = ExpressionConverter.ConvertO(calibrateMouseEventcalibrationSizeInPixels);
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
        public IBodyWorkflowAction<GetMouseMoveMethodResponse> GetMouseMoveMethod(Expression<Func<string>> getMouseMoveMethodworkflow)
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
        public IWorkflowAction SetMouseMoveMethod(Expression<Func<setMouseMoveMethodmouseMoveMethodInput>> setMouseMoveMethodmouseMoveMethod, Expression<Func<string>> setMouseMoveMethodworkflow)
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
        public IWorkflowAction WiggleMouse(Expression<Func<string>> wiggleMouseworkflow, Expression<Func<int>> wiggleMousexWiggle = null, Expression<Func<int>> wiggleMouseyWiggle = null, Expression<Func<double>> wiggleMousewiggleDelayInSeconds = null)
        {
            var apiCallPath = "/Environment/WiggleMouse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var wiggleMouse = new JObject();
            var wiggleMousepropCount = 0;
            if (wiggleMousexWiggle != null)
            {
                wiggleMouse["XWiggle"] = ExpressionConverter.ConvertO(wiggleMousexWiggle);
                wiggleMousepropCount++;
            }

            if (wiggleMouseyWiggle != null)
            {
                wiggleMouse["YWiggle"] = ExpressionConverter.ConvertO(wiggleMouseyWiggle);
                wiggleMousepropCount++;
            }

            if (wiggleMousewiggleDelayInSeconds != null)
            {
                wiggleMouse["WiggleDelayInSeconds"] = ExpressionConverter.ConvertO(wiggleMousewiggleDelayInSeconds);
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
        public IWorkflowAction SendKeyEvents(Expression<Func<string>> sendKeyEventstext, Expression<Func<string>> sendKeyEventsworkflow, Expression<Func<int>> sendKeyEventsinterval = null, Expression<Func<bool>> sendKeyEventsisPassword = null, Expression<Func<bool>> sendKeyEventsdontInterpretSymbols = null)
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
                sendKeyEvents["Interval"] = ExpressionConverter.ConvertO(sendKeyEventsinterval);
                sendKeyEventspropCount++;
            }

            if (sendKeyEventsisPassword != null)
            {
                sendKeyEvents["IsPassword"] = ExpressionConverter.ConvertO(sendKeyEventsisPassword);
                sendKeyEventspropCount++;
            }

            if (sendKeyEventsdontInterpretSymbols != null)
            {
                sendKeyEvents["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sendKeyEventsdontInterpretSymbols);
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
        public IWorkflowAction SendPasswordKeyEvents(Expression<Func<string>> sendPasswordKeyEventspassword, Expression<Func<string>> sendPasswordKeyEventsworkflow, Expression<Func<int>> sendPasswordKeyEventsinterval = null, Expression<Func<bool>> sendPasswordKeyEventsdontInterpretSymbols = null, Expression<Func<bool>> sendPasswordKeyEventspasswordContainsStoredPassword = null)
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
                sendPasswordKeyEvents["Interval"] = ExpressionConverter.ConvertO(sendPasswordKeyEventsinterval);
                sendPasswordKeyEventspropCount++;
            }

            if (sendPasswordKeyEventsdontInterpretSymbols != null)
            {
                sendPasswordKeyEvents["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sendPasswordKeyEventsdontInterpretSymbols);
                sendPasswordKeyEventspropCount++;
            }

            if (sendPasswordKeyEventspasswordContainsStoredPassword != null)
            {
                sendPasswordKeyEvents["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(sendPasswordKeyEventspasswordContainsStoredPassword);
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
        public IWorkflowAction SendKeys(Expression<Func<string>> sendKeystext, Expression<Func<string>> sendKeysworkflow, Expression<Func<int>> sendKeysinterval = null, Expression<Func<bool>> sendKeysisPassword = null, Expression<Func<bool>> sendKeysdontInterpretSymbols = null)
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
                sendKeys["Interval"] = ExpressionConverter.ConvertO(sendKeysinterval);
                sendKeyspropCount++;
            }

            if (sendKeysisPassword != null)
            {
                sendKeys["IsPassword"] = ExpressionConverter.ConvertO(sendKeysisPassword);
                sendKeyspropCount++;
            }

            if (sendKeysdontInterpretSymbols != null)
            {
                sendKeys["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sendKeysdontInterpretSymbols);
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
        public IWorkflowAction SendPasswordKeys(Expression<Func<string>> sendPasswordKeyspassword, Expression<Func<string>> sendPasswordKeysworkflow, Expression<Func<int>> sendPasswordKeysinterval = null, Expression<Func<bool>> sendPasswordKeysdontInterpretSymbols = null, Expression<Func<bool>> sendPasswordKeyspasswordContainsStoredPassword = null)
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
                sendPasswordKeys["Interval"] = ExpressionConverter.ConvertO(sendPasswordKeysinterval);
                sendPasswordKeyspropCount++;
            }

            if (sendPasswordKeysdontInterpretSymbols != null)
            {
                sendPasswordKeys["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sendPasswordKeysdontInterpretSymbols);
                sendPasswordKeyspropCount++;
            }

            if (sendPasswordKeyspasswordContainsStoredPassword != null)
            {
                sendPasswordKeys["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(sendPasswordKeyspasswordContainsStoredPassword);
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
        public IWorkflowAction ClearClipboard(Expression<Func<string>> clearClipboardworkflow)
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
        public IWorkflowAction SetClipboardData(Expression<Func<string>> setClipboardDataworkflow, Expression<Func<string>> setClipboardDatanewClipboardData = null)
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
        public IBodyWorkflowAction<GetClipboardDataResponse> GetClipboardData(Expression<Func<string>> getClipboardDataworkflow)
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
        public IBodyWorkflowAction<TakeScreenshotResponse> TakeScreenshot(Expression<Func<string>> takeScreenshotworkflow, Expression<Func<bool>> takeScreenshotfullscreen = null, Expression<Func<int>> takeScreenshotleftXPixels = null, Expression<Func<int>> takeScreenshottopYPixels = null, Expression<Func<int>> takeScreenshotwidthPixels = null, Expression<Func<int>> takeScreenshotheightPixels = null, Expression<Func<takeScreenshotimageFormatInput>> takeScreenshotimageFormat = null, Expression<Func<bool>> takeScreenshotuseDisplayDevice = null, Expression<Func<bool>> takeScreenshotraiseExceptionOnError = null, Expression<Func<bool>> takeScreenshothideAgent = null, Expression<Func<bool>> takeScreenshotusePhysicalCoordinates = null, Expression<Func<int>> takeScreenshotdisplayDeviceId = null)
        {
            var apiCallPath = "/Environment/TakeScreenshot";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var takeScreenshot = new JObject();
            var takeScreenshotpropCount = 0;
            if (takeScreenshotfullscreen != null)
            {
                takeScreenshot["Fullscreen"] = ExpressionConverter.ConvertO(takeScreenshotfullscreen);
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
                takeScreenshot["UseDisplayDevice"] = ExpressionConverter.ConvertO(takeScreenshotuseDisplayDevice);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotraiseExceptionOnError != null)
            {
                takeScreenshot["RaiseExceptionOnError"] = ExpressionConverter.ConvertO(takeScreenshotraiseExceptionOnError);
                takeScreenshotpropCount++;
            }

            if (takeScreenshothideAgent != null)
            {
                takeScreenshot["HideAgent"] = ExpressionConverter.ConvertO(takeScreenshothideAgent);
                takeScreenshotpropCount++;
            }

            if (takeScreenshotusePhysicalCoordinates != null)
            {
                takeScreenshot["UsePhysicalCoordinates"] = ExpressionConverter.ConvertO(takeScreenshotusePhysicalCoordinates);
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
        public IBodyWorkflowAction<GetEnvironmentInfoResponse> GetEnvironmentInfo(Expression<Func<string>> getEnvironmentInfoworkflow)
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
        public IBodyWorkflowAction<IsScreenReaderEnabledResponse> IsScreenReaderEnabled(Expression<Func<string>> isScreenReaderEnabledworkflow)
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
        public IWorkflowAction SetScreenReader(Expression<Func<string>> setScreenReaderworkflow, Expression<Func<bool>> setScreenReaderenableScreenReader = null)
        {
            var apiCallPath = "/Environment/SetScreenReader";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setScreenReader = new JObject();
            var setScreenReaderpropCount = 0;
            if (setScreenReaderenableScreenReader != null)
            {
                setScreenReader["EnableScreenReader"] = ExpressionConverter.ConvertO(setScreenReaderenableScreenReader);
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
        public IBodyWorkflowAction<GetParentProcessIdResponse> GetParentProcessId(Expression<Func<int>> getParentProcessIdprocessId, Expression<Func<string>> getParentProcessIdworkflow)
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
        public IBodyWorkflowAction<GetProcessIdCommandLineResponse> GetProcessIdCommandLine(Expression<Func<int>> getProcessIdCommandLineprocessId, Expression<Func<string>> getProcessIdCommandLineworkflow)
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
        public IBodyWorkflowAction<GetLastInputInfoResponse> GetLastInputInfo(Expression<Func<string>> getLastInputInfoworkflow)
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
        public IBodyWorkflowAction<KeepSessionAliveResponse> KeepSessionAlive(Expression<Func<string>> keepSessionAliveworkflow, Expression<Func<int>> keepSessionAlivexWiggle = null, Expression<Func<int>> keepSessionAliveyWiggle = null, Expression<Func<double>> keepSessionAlivewiggleDelayInSeconds = null, Expression<Func<int>> keepSessionAliveidleThresholdInSeconds = null, Expression<Func<int>> keepSessionAliveidleCheckPeriodInSeconds = null, Expression<Func<int>> keepSessionAlivetotalKeepaliveRuntimeInSeconds = null)
        {
            var apiCallPath = "/Environment/KeepSessionAlive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var keepSessionAlive = new JObject();
            var keepSessionAlivepropCount = 0;
            if (keepSessionAlivexWiggle != null)
            {
                keepSessionAlive["XWiggle"] = ExpressionConverter.ConvertO(keepSessionAlivexWiggle);
                keepSessionAlivepropCount++;
            }

            if (keepSessionAliveyWiggle != null)
            {
                keepSessionAlive["YWiggle"] = ExpressionConverter.ConvertO(keepSessionAliveyWiggle);
                keepSessionAlivepropCount++;
            }

            if (keepSessionAlivewiggleDelayInSeconds != null)
            {
                keepSessionAlive["WiggleDelayInSeconds"] = ExpressionConverter.ConvertO(keepSessionAlivewiggleDelayInSeconds);
                keepSessionAlivepropCount++;
            }

            if (keepSessionAliveidleThresholdInSeconds != null)
            {
                keepSessionAlive["IdleThresholdInSeconds"] = ExpressionConverter.ConvertO(keepSessionAliveidleThresholdInSeconds);
                keepSessionAlivepropCount++;
            }

            if (keepSessionAliveidleCheckPeriodInSeconds != null)
            {
                keepSessionAlive["IdleCheckPeriodInSeconds"] = ExpressionConverter.ConvertO(keepSessionAliveidleCheckPeriodInSeconds);
                keepSessionAlivepropCount++;
            }

            if (keepSessionAlivetotalKeepaliveRuntimeInSeconds != null)
            {
                keepSessionAlive["TotalKeepaliveRuntimeInSeconds"] = ExpressionConverter.ConvertO(keepSessionAlivetotalKeepaliveRuntimeInSeconds);
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
        public IBodyWorkflowAction<StopKeepSessionAliveResponse> StopKeepSessionAlive(Expression<Func<string>> stopKeepSessionAliveworkflow)
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
        public IBodyWorkflowAction<CopyFileToClipboardResponse> CopyFileToClipboard(Expression<Func<string>> copyFileToClipboardfilepath, Expression<Func<string>> copyFileToClipboardworkflow, Expression<Func<bool>> copyFileToClipboardcut = null)
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
                copyFileToClipboard["Cut"] = ExpressionConverter.ConvertO(copyFileToClipboardcut);
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
        public IBodyWorkflowAction<GetRemoteSessionInfoResponse> GetRemoteSessionInfo(Expression<Func<string>> getRemoteSessionInfoworkflow)
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
        public IBodyWorkflowAction<GeneratePasswordResponse> GeneratePassword(Expression<Func<string>> generatePasswordpasswordFormat, Expression<Func<string>> generatePasswordworkflow, Expression<Func<int>> generatePasswordminimumLength = null, Expression<Func<bool>> generatePasswordreturnAsPlainText = null, Expression<Func<string>> generatePasswordstorePasswordAsIdentifier = null, Expression<Func<string>> generatePasswordsupportedSymbols = null, Expression<Func<bool>> generatePasswordattemptUniquePasswords = null, Expression<Func<generatePasswordgenerateAtInput>> generatePasswordgenerateAt = null, Expression<Func<int>> generatePasswordminimumLowercase = null, Expression<Func<int>> generatePasswordminimumUppercase = null, Expression<Func<int>> generatePasswordminimumNumbers = null, Expression<Func<int>> generatePasswordminimumSymbols = null)
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
                generatePassword["ReturnAsPlainText"] = ExpressionConverter.ConvertO(generatePasswordreturnAsPlainText);
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
                generatePassword["AttemptUniquePasswords"] = ExpressionConverter.ConvertO(generatePasswordattemptUniquePasswords);
                generatePasswordpropCount++;
            }

            if (generatePasswordgenerateAt != null)
            {
                generatePassword["GenerateAt"] = ExpressionConverter.ConvertO(generatePasswordgenerateAt);
                generatePasswordpropCount++;
            }

            if (generatePasswordminimumLowercase != null)
            {
                generatePassword["MinimumLowercase"] = ExpressionConverter.ConvertO(generatePasswordminimumLowercase);
                generatePasswordpropCount++;
            }

            if (generatePasswordminimumUppercase != null)
            {
                generatePassword["MinimumUppercase"] = ExpressionConverter.ConvertO(generatePasswordminimumUppercase);
                generatePasswordpropCount++;
            }

            if (generatePasswordminimumNumbers != null)
            {
                generatePassword["MinimumNumbers"] = ExpressionConverter.ConvertO(generatePasswordminimumNumbers);
                generatePasswordpropCount++;
            }

            if (generatePasswordminimumSymbols != null)
            {
                generatePassword["MinimumSymbols"] = ExpressionConverter.ConvertO(generatePasswordminimumSymbols);
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
        public IBodyWorkflowAction<GetStoredPasswordResponse> GetStoredPassword(Expression<Func<string>> getStoredPasswordworkflow, Expression<Func<string>> getStoredPasswordpasswordIdentifier = null)
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
        public IBodyWorkflowAction<ExpandPasswordStringResponse> ExpandPasswordString(Expression<Func<string>> expandPasswordStringworkflow, Expression<Func<string>> expandPasswordStringinputString = null)
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
        public IBodyWorkflowAction<StorePasswordInAgentMemoryResponse> StorePasswordInAgentMemory(Expression<Func<string>> storePasswordInAgentMemoryidentifier, Expression<Func<string>> storePasswordInAgentMemorypassword, Expression<Func<string>> storePasswordInAgentMemoryworkflow)
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
        public IBodyWorkflowAction<DeletePasswordInAgentMemoryResponse> DeletePasswordInAgentMemory(Expression<Func<string>> deletePasswordInAgentMemoryworkflow, Expression<Func<bool>> deletePasswordInAgentMemorydeleteAllPasswords = null, Expression<Func<string>> deletePasswordInAgentMemoryidentifier = null)
        {
            var apiCallPath = "/Environment/DeletePasswordInAgentMemory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deletePasswordInAgentMemory = new JObject();
            var deletePasswordInAgentMemorypropCount = 0;
            if (deletePasswordInAgentMemorydeleteAllPasswords != null)
            {
                deletePasswordInAgentMemory["DeleteAllPasswords"] = ExpressionConverter.ConvertO(deletePasswordInAgentMemorydeleteAllPasswords);
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
        public IBodyWorkflowAction<CredentialWriteResponse> CredentialWrite(Expression<Func<string>> credentialWritecredentialAddress, Expression<Func<string>> credentialWriteuserName, Expression<Func<string>> credentialWritepassword, Expression<Func<credentialWritecredentialTypeInput>> credentialWritecredentialType, Expression<Func<string>> credentialWriteworkflow, Expression<Func<credentialWritecredentialPersistenceInput>> credentialWritecredentialPersistence = null, Expression<Func<string>> credentialWritesymmetricKey = null, Expression<Func<string>> credentialWritestorePasswordAsIdentifier = null)
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
                credentialWrite["CredentialPersistence"] = ExpressionConverter.ConvertO(credentialWritecredentialPersistence);
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
        public IBodyWorkflowAction<CredentialReadResponse> CredentialRead(Expression<Func<string>> credentialReadcredentialAddress, Expression<Func<credentialReadcredentialTypeInput>> credentialReadcredentialType, Expression<Func<string>> credentialReadworkflow, Expression<Func<string>> credentialReadsymmetricKey = null, Expression<Func<string>> credentialReadstorePasswordAsIdentifier = null, Expression<Func<bool>> credentialReaddontReturnPassword = null)
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
                credentialRead["DontReturnPassword"] = ExpressionConverter.ConvertO(credentialReaddontReturnPassword);
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
        public IBodyWorkflowAction<CredentialDeleteResponse> CredentialDelete(Expression<Func<string>> credentialDeletecredentialAddress, Expression<Func<credentialDeletecredentialTypeInput>> credentialDeletecredentialType, Expression<Func<string>> credentialDeleteworkflow)
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
        public IBodyWorkflowAction<GenerateRDPFileResponse> GenerateRDPFile(Expression<Func<string>> generateRDPFileremoteAddress, Expression<Func<string>> generateRDPFileoutputFolderPath, Expression<Func<string>> generateRDPFilerDPFileName, Expression<Func<string>> generateRDPFileworkflow, Expression<Func<bool>> generateRDPFileoverwriteRDPFileIfAlreadyExists = null, Expression<Func<bool>> generateRDPFiletrustRemoteComputer = null, Expression<Func<bool>> generateRDPFilestoreCredentials = null, Expression<Func<string>> generateRDPFileuserName = null, Expression<Func<string>> generateRDPFilepassword = null, Expression<Func<generateRDPFilecredentialTypeInput>> generateRDPFilecredentialType = null, Expression<Func<generateRDPFilecredentialPersistenceInput>> generateRDPFilecredentialPersistence = null, Expression<Func<bool>> generateRDPFileredirectPrinters = null, Expression<Func<bool>> generateRDPFileredirectAllDrives = null, Expression<Func<bool>> generateRDPFileredirectClipboard = null, Expression<Func<bool>> generateRDPFilefullscreen = null, Expression<Func<int>> generateRDPFiledesktopWidth = null, Expression<Func<int>> generateRDPFiledesktopHeight = null, Expression<Func<bool>> generateRDPFileuseMultiMonitor = null, Expression<Func<int>> generateRDPFilesessionBPP = null, Expression<Func<bool>> generateRDPFilesmartSizing = null)
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
                generateRDPFile["OverwriteRDPFileIfAlreadyExists"] = ExpressionConverter.ConvertO(generateRDPFileoverwriteRDPFileIfAlreadyExists);
                generateRDPFilepropCount++;
            }

            if (generateRDPFiletrustRemoteComputer != null)
            {
                generateRDPFile["TrustRemoteComputer"] = ExpressionConverter.ConvertO(generateRDPFiletrustRemoteComputer);
                generateRDPFilepropCount++;
            }

            if (generateRDPFilestoreCredentials != null)
            {
                generateRDPFile["StoreCredentials"] = ExpressionConverter.ConvertO(generateRDPFilestoreCredentials);
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
                generateRDPFile["CredentialType"] = ExpressionConverter.ConvertO(generateRDPFilecredentialType);
                generateRDPFilepropCount++;
            }

            if (generateRDPFilecredentialPersistence != null)
            {
                generateRDPFile["CredentialPersistence"] = ExpressionConverter.ConvertO(generateRDPFilecredentialPersistence);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileredirectPrinters != null)
            {
                generateRDPFile["RedirectPrinters"] = ExpressionConverter.ConvertO(generateRDPFileredirectPrinters);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileredirectAllDrives != null)
            {
                generateRDPFile["RedirectAllDrives"] = ExpressionConverter.ConvertO(generateRDPFileredirectAllDrives);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileredirectClipboard != null)
            {
                generateRDPFile["RedirectClipboard"] = ExpressionConverter.ConvertO(generateRDPFileredirectClipboard);
                generateRDPFilepropCount++;
            }

            if (generateRDPFilefullscreen != null)
            {
                generateRDPFile["Fullscreen"] = ExpressionConverter.ConvertO(generateRDPFilefullscreen);
                generateRDPFilepropCount++;
            }

            if (generateRDPFiledesktopWidth != null)
            {
                generateRDPFile["DesktopWidth"] = ExpressionConverter.ConvertO(generateRDPFiledesktopWidth);
                generateRDPFilepropCount++;
            }

            if (generateRDPFiledesktopHeight != null)
            {
                generateRDPFile["DesktopHeight"] = ExpressionConverter.ConvertO(generateRDPFiledesktopHeight);
                generateRDPFilepropCount++;
            }

            if (generateRDPFileuseMultiMonitor != null)
            {
                generateRDPFile["UseMultiMonitor"] = ExpressionConverter.ConvertO(generateRDPFileuseMultiMonitor);
                generateRDPFilepropCount++;
            }

            if (generateRDPFilesessionBPP != null)
            {
                generateRDPFile["SessionBPP"] = ExpressionConverter.ConvertO(generateRDPFilesessionBPP);
                generateRDPFilepropCount++;
            }

            if (generateRDPFilesmartSizing != null)
            {
                generateRDPFile["SmartSizing"] = ExpressionConverter.ConvertO(generateRDPFilesmartSizing);
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
        public IBodyWorkflowAction<LaunchRemoteDesktopSessionResponse> LaunchRemoteDesktopSession(Expression<Func<string>> launchRemoteDesktopSessionrDPFilePath, Expression<Func<string>> launchRemoteDesktopSessionworkflow, Expression<Func<bool>> launchRemoteDesktopSessiontrustRemoteComputer = null)
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
                launchRemoteDesktopSession["TrustRemoteComputer"] = ExpressionConverter.ConvertO(launchRemoteDesktopSessiontrustRemoteComputer);
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
        public IBodyWorkflowAction<IsTCPPortRespondingResponse> IsTCPPortResponding(Expression<Func<string>> isTCPPortRespondingremoteHost, Expression<Func<int>> isTCPPortRespondingtCPPort, Expression<Func<string>> isTCPPortRespondingworkflow, Expression<Func<int>> isTCPPortRespondingtimeoutInSeconds = null)
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
                isTCPPortResponding["TimeoutInSeconds"] = ExpressionConverter.ConvertO(isTCPPortRespondingtimeoutInSeconds);
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
        public IBodyWorkflowAction<UnlockSessionResponse> UnlockSession(Expression<Func<string>> unlockSessionunlockPassword, Expression<Func<bool>> unlockSessiondetectIfLocked, Expression<Func<bool>> unlockSessiondetectCredentialProvider, Expression<Func<string>> unlockSessionworkflow, Expression<Func<bool>> unlockSessionpasswordContainsStoredPassword = null, Expression<Func<int>> unlockSessionsecondsToWaitForUnlock = null)
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
                unlockSession["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(unlockSessionpasswordContainsStoredPassword);
                unlockSessionpropCount++;
            }

            unlockSessionpropCount++;
            unlockSession["DetectIfLocked"] = ExpressionConverter.ConvertO(unlockSessiondetectIfLocked);
            unlockSessionpropCount++;
            unlockSession["DetectCredentialProvider"] = ExpressionConverter.ConvertO(unlockSessiondetectCredentialProvider);
            if (unlockSessionsecondsToWaitForUnlock != null)
            {
                unlockSession["SecondsToWaitForUnlock"] = ExpressionConverter.ConvertO(unlockSessionsecondsToWaitForUnlock);
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
        public IBodyWorkflowAction<LockSessionResponse> LockSession(Expression<Func<string>> lockSessionworkflow, Expression<Func<int>> lockSessionlockAfterMinutesOfActionInactivity = null, Expression<Func<int>> lockSessionsecondsToWaitAfterLock = null)
        {
            var apiCallPath = "/Environment/LockSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var lockSession = new JObject();
            var lockSessionpropCount = 0;
            if (lockSessionlockAfterMinutesOfActionInactivity != null)
            {
                lockSession["LockAfterMinutesOfActionInactivity"] = ExpressionConverter.ConvertO(lockSessionlockAfterMinutesOfActionInactivity);
                lockSessionpropCount++;
            }

            if (lockSessionsecondsToWaitAfterLock != null)
            {
                lockSession["SecondsToWaitAfterLock"] = ExpressionConverter.ConvertO(lockSessionsecondsToWaitAfterLock);
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
        public IBodyWorkflowAction<IsSessionLockedResponse> IsSessionLocked(Expression<Func<string>> isSessionLockedworkflow)
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
        public IBodyWorkflowAction<GetGenericCredentialFromOrchestratorResponse> GetGenericCredentialFromOrchestrator(Expression<Func<string>> getGenericCredentialFromOrchestratorfriendlyName = null, Expression<Func<bool>> getGenericCredentialFromOrchestratorretrievePlainTextPassword = null)
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
                getGenericCredentialFromOrchestrator["RetrievePlainTextPassword"] = ExpressionConverter.ConvertO(getGenericCredentialFromOrchestratorretrievePlainTextPassword);
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
            drawRectangleOnScreen["RectangleLeftPixelXCoord"] = ExpressionConverter.ConvertO(drawRectangleOnScreenrectangleLeftPixelXCoord);
            drawRectangleOnScreenpropCount++;
            drawRectangleOnScreen["RectangleRightPixelXCoord"] = ExpressionConverter.ConvertO(drawRectangleOnScreenrectangleRightPixelXCoord);
            drawRectangleOnScreenpropCount++;
            drawRectangleOnScreen["RectangleTopPixelYCoord"] = ExpressionConverter.ConvertO(drawRectangleOnScreenrectangleTopPixelYCoord);
            drawRectangleOnScreenpropCount++;
            drawRectangleOnScreen["RectangleBottomPixelYCoord"] = ExpressionConverter.ConvertO(drawRectangleOnScreenrectangleBottomPixelYCoord);
            if (drawRectangleOnScreenpenColour != null)
            {
                drawRectangleOnScreen["PenColour"] = ExpressionConverter.ConvertO(drawRectangleOnScreenpenColour);
                drawRectangleOnScreenpropCount++;
            }

            if (drawRectangleOnScreenpenThicknessPixels != null)
            {
                drawRectangleOnScreen["PenThicknessPixels"] = ExpressionConverter.ConvertO(drawRectangleOnScreenpenThicknessPixels);
                drawRectangleOnScreenpropCount++;
            }

            if (drawRectangleOnScreensecondsToDisplay != null)
            {
                drawRectangleOnScreen["SecondsToDisplay"] = ExpressionConverter.ConvertO(drawRectangleOnScreensecondsToDisplay);
                drawRectangleOnScreenpropCount++;
            }

            if (drawRectangleOnScreencoordinatesArePhysical != null)
            {
                drawRectangleOnScreen["CoordinatesArePhysical"] = ExpressionConverter.ConvertO(drawRectangleOnScreencoordinatesArePhysical);
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
        public IBodyWorkflowAction<GetFailedActionErrorMessageFromPowerAutomateResultJSONResponse> GetFailedActionErrorMessageFromPowerAutomateResultJSON(Expression<Func<string[]>> getFailedActionErrorMessageFromPowerAutomateResultJSONpowerAutomateResultJSON, Expression<Func<string>> getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus = null)
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
                getFailedActionErrorMessageFromPowerAutomateResultJSON["SearchStatus"] = ExpressionConverter.ConvertO(getFailedActionErrorMessageFromPowerAutomateResultJSONsearchStatus);
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
            getPixelColourAtCoordinate["LeftXPixels"] = ExpressionConverter.ConvertO(getPixelColourAtCoordinateleftXPixels);
            getPixelColourAtCoordinatepropCount++;
            getPixelColourAtCoordinate["TopYPixels"] = ExpressionConverter.ConvertO(getPixelColourAtCoordinatetopYPixels);
            if (getPixelColourAtCoordinatehideAgent != null)
            {
                getPixelColourAtCoordinate["HideAgent"] = ExpressionConverter.ConvertO(getPixelColourAtCoordinatehideAgent);
                getPixelColourAtCoordinatepropCount++;
            }

            if (getPixelColourAtCoordinateusePhysicalCoordinates != null)
            {
                getPixelColourAtCoordinate["UsePhysicalCoordinates"] = ExpressionConverter.ConvertO(getPixelColourAtCoordinateusePhysicalCoordinates);
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
        public IBodyWorkflowAction<ConvertRectangleCoordinatesResponse> ConvertRectangleCoordinates(Expression<Func<int>> convertRectangleCoordinatesrectangleLeftPixelXCoord, Expression<Func<int>> convertRectangleCoordinatesrectangleTopPixelYCoord, Expression<Func<int>> convertRectangleCoordinatesrectangleRightPixelXCoord, Expression<Func<int>> convertRectangleCoordinatesrectangleBottomPixelYCoord, Expression<Func<convertRectangleCoordinatesconversionTypeInput>> convertRectangleCoordinatesconversionType, Expression<Func<string>> convertRectangleCoordinatesworkflow)
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
        public IBodyWorkflowAction<SendMessageToWebAPIResponse> SendMessageToWebAPI(Expression<Func<string>> sendMessageToWebAPIworkflow, Expression<Func<string>> sendMessageToWebAPIuRL = null, Expression<Func<sendMessageToWebAPImethodInput>> sendMessageToWebAPImethod = null, Expression<Func<int>> sendMessageToWebAPItimeoutInSeconds = null, Expression<Func<string>> sendMessageToWebAPIcontentType = null, Expression<Func<string>> sendMessageToWebAPIaccept = null, Expression<Func<string>> sendMessageToWebAPImessageBody = null, Expression<Func<sendMessageToWebAPItransmitEncodingInput>> sendMessageToWebAPItransmitEncoding = null, Expression<Func<sendMessageToWebAPIresponseEncodingInput>> sendMessageToWebAPIresponseEncoding = null, Expression<Func<int>> sendMessageToWebAPIbufferSize = null, Expression<Func<sendMessageToWebAPIhTTPRequestHeadersListInputItem[]>> sendMessageToWebAPIhTTPRequestHeadersList = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS10 = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS11 = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS12 = null, Expression<Func<bool>> sendMessageToWebAPInegotiateTLS13 = null, Expression<Func<bool>> sendMessageToWebAPIkeepAlive = null, Expression<Func<bool>> sendMessageToWebAPIexpect100Continue = null, Expression<Func<bool>> sendMessageToWebAPIreturnResponseHeaders = null, Expression<Func<bool>> sendMessageToWebAPIrunAsThread = null, Expression<Func<bool>> sendMessageToWebAPIwaitForThread = null, Expression<Func<int>> sendMessageToWebAPIretrieveOutputDataFromThreadId = null)
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
                sendMessageToWebAPI["Method"] = ExpressionConverter.ConvertO(sendMessageToWebAPImethod);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPItimeoutInSeconds != null)
            {
                sendMessageToWebAPI["TimeoutInSeconds"] = ExpressionConverter.ConvertO(sendMessageToWebAPItimeoutInSeconds);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIcontentType != null)
            {
                sendMessageToWebAPI["ContentType"] = ExpressionConverter.ConvertO(sendMessageToWebAPIcontentType);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIaccept != null)
            {
                sendMessageToWebAPI["Accept"] = ExpressionConverter.ConvertO(sendMessageToWebAPIaccept);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPImessageBody != null)
            {
                sendMessageToWebAPI["MessageBody"] = ExpressionConverter.ConvertO(sendMessageToWebAPImessageBody);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPItransmitEncoding != null)
            {
                sendMessageToWebAPI["TransmitEncoding"] = ExpressionConverter.ConvertO(sendMessageToWebAPItransmitEncoding);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIresponseEncoding != null)
            {
                sendMessageToWebAPI["ResponseEncoding"] = ExpressionConverter.ConvertO(sendMessageToWebAPIresponseEncoding);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIbufferSize != null)
            {
                sendMessageToWebAPI["BufferSize"] = ExpressionConverter.ConvertO(sendMessageToWebAPIbufferSize);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIhTTPRequestHeadersList != null)
            {
                sendMessageToWebAPI["HTTPRequestHeadersList"] = ExpressionConverter.ConvertO(sendMessageToWebAPIhTTPRequestHeadersList);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPInegotiateTLS10 != null)
            {
                sendMessageToWebAPI["NegotiateTLS10"] = ExpressionConverter.ConvertO(sendMessageToWebAPInegotiateTLS10);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPInegotiateTLS11 != null)
            {
                sendMessageToWebAPI["NegotiateTLS11"] = ExpressionConverter.ConvertO(sendMessageToWebAPInegotiateTLS11);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPInegotiateTLS12 != null)
            {
                sendMessageToWebAPI["NegotiateTLS12"] = ExpressionConverter.ConvertO(sendMessageToWebAPInegotiateTLS12);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPInegotiateTLS13 != null)
            {
                sendMessageToWebAPI["NegotiateTLS13"] = ExpressionConverter.ConvertO(sendMessageToWebAPInegotiateTLS13);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIkeepAlive != null)
            {
                sendMessageToWebAPI["KeepAlive"] = ExpressionConverter.ConvertO(sendMessageToWebAPIkeepAlive);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIexpect100Continue != null)
            {
                sendMessageToWebAPI["Expect100Continue"] = ExpressionConverter.ConvertO(sendMessageToWebAPIexpect100Continue);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIreturnResponseHeaders != null)
            {
                sendMessageToWebAPI["ReturnResponseHeaders"] = ExpressionConverter.ConvertO(sendMessageToWebAPIreturnResponseHeaders);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIrunAsThread != null)
            {
                sendMessageToWebAPI["RunAsThread"] = ExpressionConverter.ConvertO(sendMessageToWebAPIrunAsThread);
                sendMessageToWebAPIpropCount++;
            }

            if (sendMessageToWebAPIwaitForThread != null)
            {
                sendMessageToWebAPI["WaitForThread"] = ExpressionConverter.ConvertO(sendMessageToWebAPIwaitForThread);
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
        public IBodyWorkflowAction<TasksAddNewTaskResponse> TasksAddNewTask(Expression<Func<string>> tasksAddNewTaskworkflow, Expression<Func<tasksAddNewTasksetAutomationNameInput>> tasksAddNewTasksetAutomationName = null, Expression<Func<string>> tasksAddNewTaskautomationName = null, Expression<Func<string>> tasksAddNewTasktaskInputData = null, Expression<Func<string>> tasksAddNewTaskprocessStage = null, Expression<Func<int>> tasksAddNewTaskpriority = null, Expression<Func<int>> tasksAddNewTasksLA = null, Expression<Func<bool>> tasksAddNewTasktaskOnHold = null, Expression<Func<string>> tasksAddNewTaskorganisation = null, Expression<Func<string>> tasksAddNewTaskdepartment = null, Expression<Func<string>> tasksAddNewTaskdescription = null, Expression<Func<string>> tasksAddNewTasktags = null)
        {
            var apiCallPath = "/Environment/TasksAddNewTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksAddNewTask = new JObject();
            var tasksAddNewTaskpropCount = 0;
            if (tasksAddNewTasksetAutomationName != null)
            {
                tasksAddNewTask["SetAutomationName"] = ExpressionConverter.ConvertO(tasksAddNewTasksetAutomationName);
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
                tasksAddNewTask["Priority"] = ExpressionConverter.ConvertO(tasksAddNewTaskpriority);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTasksLA != null)
            {
                tasksAddNewTask["SLA"] = ExpressionConverter.ConvertO(tasksAddNewTasksLA);
                tasksAddNewTaskpropCount++;
            }

            if (tasksAddNewTasktaskOnHold != null)
            {
                tasksAddNewTask["TaskOnHold"] = ExpressionConverter.ConvertO(tasksAddNewTasktaskOnHold);
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
        public IBodyWorkflowAction<TasksAddNewDeferralResponse> TasksAddNewDeferral(Expression<Func<string>> tasksAddNewDeferralworkflow, Expression<Func<tasksAddNewDeferralsetAutomationNameInput>> tasksAddNewDeferralsetAutomationName = null, Expression<Func<string>> tasksAddNewDeferralautomationName = null, Expression<Func<int>> tasksAddNewDeferraldeferralTimeInMinutes = null, Expression<Func<string>> tasksAddNewDeferraltaskInputData = null, Expression<Func<string>> tasksAddNewDeferraldeferralStoredData = null, Expression<Func<string>> tasksAddNewDeferralprocessStage = null, Expression<Func<int>> tasksAddNewDeferralpriority = null, Expression<Func<bool>> tasksAddNewDeferraltaskOnHold = null, Expression<Func<string>> tasksAddNewDeferralorganisation = null, Expression<Func<string>> tasksAddNewDeferraldepartment = null, Expression<Func<string>> tasksAddNewDeferraldescription = null, Expression<Func<string>> tasksAddNewDeferraltags = null)
        {
            var apiCallPath = "/Environment/TasksAddNewDeferral";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var tasksAddNewDeferral = new JObject();
            var tasksAddNewDeferralpropCount = 0;
            if (tasksAddNewDeferralsetAutomationName != null)
            {
                tasksAddNewDeferral["SetAutomationName"] = ExpressionConverter.ConvertO(tasksAddNewDeferralsetAutomationName);
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
                tasksAddNewDeferral["Priority"] = ExpressionConverter.ConvertO(tasksAddNewDeferralpriority);
                tasksAddNewDeferralpropCount++;
            }

            if (tasksAddNewDeferraltaskOnHold != null)
            {
                tasksAddNewDeferral["TaskOnHold"] = ExpressionConverter.ConvertO(tasksAddNewDeferraltaskOnHold);
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
        public IBodyWorkflowAction<TasksDeferExistingTaskResponse> TasksDeferExistingTask(Expression<Func<int>> tasksDeferExistingTasktaskId, Expression<Func<int>> tasksDeferExistingTaskdeferralTimeInMinutes = null, Expression<Func<string>> tasksDeferExistingTaskdeferralStoredData = null, Expression<Func<string>> tasksDeferExistingTaskprocessStage = null, Expression<Func<int>> tasksDeferExistingTaskpriority = null, Expression<Func<bool>> tasksDeferExistingTasktaskOnHold = null)
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
                tasksDeferExistingTask["Priority"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskpriority);
                tasksDeferExistingTaskpropCount++;
            }

            if (tasksDeferExistingTasktaskOnHold != null)
            {
                tasksDeferExistingTask["TaskOnHold"] = ExpressionConverter.ConvertO(tasksDeferExistingTasktaskOnHold);
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
                tasksDeferExistingTaskOperation["Priority"] = ExpressionConverter.ConvertO(tasksDeferExistingTaskOperationpriority);
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
            tasksDeleteTask["TaskId"] = ExpressionConverter.ConvertO(tasksDeleteTasktaskId);
            if (tasksDeleteTaskupdateSourceSystem != null)
            {
                tasksDeleteTask["UpdateSourceSystem"] = ExpressionConverter.ConvertO(tasksDeleteTaskupdateSourceSystem);
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
            tasksDeleteTaskOperation["OperationId"] = ExpressionConverter.ConvertO(tasksDeleteTaskOperationoperationId);
            if (tasksDeleteTaskOperationupdateSourceSystem != null)
            {
                tasksDeleteTaskOperation["UpdateSourceSystem"] = ExpressionConverter.ConvertO(tasksDeleteTaskOperationupdateSourceSystem);
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
                tasksGetAllTasks["SortByDeferralDate"] = ExpressionConverter.ConvertO(tasksGetAllTaskssortByDeferralDate);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksretrieveOnHoldTasks != null)
            {
                tasksGetAllTasks["RetrieveOnHoldTasks"] = ExpressionConverter.ConvertO(tasksGetAllTasksretrieveOnHoldTasks);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksskip != null)
            {
                tasksGetAllTasks["Skip"] = ExpressionConverter.ConvertO(tasksGetAllTasksskip);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksmaxResults != null)
            {
                tasksGetAllTasks["MaxResults"] = ExpressionConverter.ConvertO(tasksGetAllTasksmaxResults);
                tasksGetAllTaskspropCount++;
            }

            if (tasksGetAllTasksexcludeTaskData != null)
            {
                tasksGetAllTasks["ExcludeTaskData"] = ExpressionConverter.ConvertO(tasksGetAllTasksexcludeTaskData);
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
            tasksGetTask["TaskId"] = ExpressionConverter.ConvertO(tasksGetTasktaskId);
            if (tasksGetTaskstatusChange != null)
            {
                tasksGetTask["StatusChange"] = ExpressionConverter.ConvertO(tasksGetTaskstatusChange);
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
                tasksGetNextTask["StatusChange"] = ExpressionConverter.ConvertO(tasksGetNextTaskstatusChange);
                tasksGetNextTaskpropCount++;
            }

            if (tasksGetNextTaskminutesUntilDeferralDate != null)
            {
                tasksGetNextTask["MinutesUntilDeferralDate"] = ExpressionConverter.ConvertO(tasksGetNextTaskminutesUntilDeferralDate);
                tasksGetNextTaskpropCount++;
            }

            if (tasksGetNextTaskignoreSLA != null)
            {
                tasksGetNextTask["IgnoreSLA"] = ExpressionConverter.ConvertO(tasksGetNextTaskignoreSLA);
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
        public IBodyWorkflowAction<TasksChangeTaskStatusResponse> TasksChangeTaskStatus(Expression<Func<int>> tasksChangeTaskStatustaskId, Expression<Func<tasksChangeTaskStatusautomationTaskStatusInput>> tasksChangeTaskStatusautomationTaskStatus = null, Expression<Func<bool>> tasksChangeTaskStatustaskOnHold = null, Expression<Func<bool>> tasksChangeTaskStatuseraseTaskInputData = null, Expression<Func<bool>> tasksChangeTaskStatuseraseDeferralStoredData = null, Expression<Func<bool>> tasksChangeTaskStatusupdateSourceSystem = null, Expression<Func<string>> tasksChangeTaskStatustaskClosureReason = null)
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
                tasksChangeTaskStatus["TaskOnHold"] = ExpressionConverter.ConvertO(tasksChangeTaskStatustaskOnHold);
                tasksChangeTaskStatuspropCount++;
            }

            if (tasksChangeTaskStatuseraseTaskInputData != null)
            {
                tasksChangeTaskStatus["EraseTaskInputData"] = ExpressionConverter.ConvertO(tasksChangeTaskStatuseraseTaskInputData);
                tasksChangeTaskStatuspropCount++;
            }

            if (tasksChangeTaskStatuseraseDeferralStoredData != null)
            {
                tasksChangeTaskStatus["EraseDeferralStoredData"] = ExpressionConverter.ConvertO(tasksChangeTaskStatuseraseDeferralStoredData);
                tasksChangeTaskStatuspropCount++;
            }

            if (tasksChangeTaskStatusupdateSourceSystem != null)
            {
                tasksChangeTaskStatus["UpdateSourceSystem"] = ExpressionConverter.ConvertO(tasksChangeTaskStatusupdateSourceSystem);
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
        public IBodyWorkflowAction<TasksAddNoteResponse> TasksAddNote(Expression<Func<int>> tasksAddNotetaskId, Expression<Func<string>> tasksAddNotenoteText, Expression<Func<tasksAddNotenoteTypeInput>> tasksAddNotenoteType = null, Expression<Func<string>> tasksAddNotenoteTypeOther = null)
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
                tasksAddNote["NoteType"] = ExpressionConverter.ConvertO(tasksAddNotenoteType);
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
        public IBodyWorkflowAction<TasksAssignTaskResponse> TasksAssignTask(Expression<Func<int>> tasksAssignTasktaskId, Expression<Func<string>> tasksAssignTaskassignToUserId = null, Expression<Func<string>> tasksAssignTaskassignToUserName = null, Expression<Func<string>> tasksAssignTaskassignToGroupId = null, Expression<Func<string>> tasksAssignTaskassignToGroupName = null, Expression<Func<bool>> tasksAssignTaskremoveUserAssignmentIfBlank = null, Expression<Func<bool>> tasksAssignTaskremoveGroupAssignmentIfBlank = null)
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
                tasksAssignTask["RemoveUserAssignmentIfBlank"] = ExpressionConverter.ConvertO(tasksAssignTaskremoveUserAssignmentIfBlank);
                tasksAssignTaskpropCount++;
            }

            if (tasksAssignTaskremoveGroupAssignmentIfBlank != null)
            {
                tasksAssignTask["RemoveGroupAssignmentIfBlank"] = ExpressionConverter.ConvertO(tasksAssignTaskremoveGroupAssignmentIfBlank);
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
        public IBodyWorkflowAction<TasksAddNewTaskOperationResponse> TasksAddNewTaskOperation(Expression<Func<string>> tasksAddNewTaskOperationautomationName = null, Expression<Func<string>> tasksAddNewTaskOperationtaskInputData = null, Expression<Func<string>> tasksAddNewTaskOperationprocessStage = null, Expression<Func<int>> tasksAddNewTaskOperationpriority = null, Expression<Func<int>> tasksAddNewTaskOperationsLA = null, Expression<Func<string>> tasksAddNewTaskOperationorganisation = null, Expression<Func<string>> tasksAddNewTaskOperationdepartment = null, Expression<Func<string>> tasksAddNewTaskOperationdescription = null, Expression<Func<string>> tasksAddNewTaskOperationtags = null)
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
                tasksAddNewTaskOperation["Priority"] = ExpressionConverter.ConvertO(tasksAddNewTaskOperationpriority);
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
        public IBodyWorkflowAction<TasksAddNewDeferralOperationResponse> TasksAddNewDeferralOperation(Expression<Func<string>> tasksAddNewDeferralOperationautomationName = null, Expression<Func<int>> tasksAddNewDeferralOperationdeferralTimeInMinutes = null, Expression<Func<string>> tasksAddNewDeferralOperationtaskInputData = null, Expression<Func<string>> tasksAddNewDeferralOperationdeferralStoredData = null, Expression<Func<string>> tasksAddNewDeferralOperationprocessStage = null, Expression<Func<int>> tasksAddNewDeferralOperationpriority = null, Expression<Func<string>> tasksAddNewDeferralOperationorganisation = null, Expression<Func<string>> tasksAddNewDeferralOperationdepartment = null, Expression<Func<string>> tasksAddNewDeferralOperationdescription = null, Expression<Func<string>> tasksAddNewDeferralOperationtags = null)
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
                tasksAddNewDeferralOperation["Priority"] = ExpressionConverter.ConvertO(tasksAddNewDeferralOperationpriority);
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
        public IBodyWorkflowAction<TasksGetTaskOperationResponse> TasksGetTaskOperation(Expression<Func<string>> tasksGetTaskOperationoperationId)
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
        public IWorkflowAction SetRemoteLoggingLevel(Expression<Func<int>> setRemoteLoggingLevelloggingLevel, Expression<Func<string>> setRemoteLoggingLevelworkflow)
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
        public IBodyWorkflowAction<GetRemoteLoggingLevelResponse> GetRemoteLoggingLevel(Expression<Func<string>> getRemoteLoggingLevelworkflow)
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
        public IWorkflowAction SetLicenseCode(Expression<Func<string>> setLicenseCodecustomerNETBIOSDomainName, Expression<Func<string>> setLicenseCodecustomerDisplayName, Expression<Func<string>> setLicenseCodevendorName, Expression<Func<string>> setLicenseCodelicenseExpiryDate, Expression<Func<string>> setLicenseCodeactivationCode, Expression<Func<string>> setLicenseCodeworkflow, Expression<Func<bool>> setLicenseCodestoreInRegistry = null)
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
                setLicenseCode["StoreInRegistry"] = ExpressionConverter.ConvertO(setLicenseCodestoreInRegistry);
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
        public IBodyWorkflowAction<SetLicenseStringResponse> SetLicenseString(Expression<Func<string>> setLicenseStringlicenseString, Expression<Func<string>> setLicenseStringworkflow, Expression<Func<bool>> setLicenseStringstoreInRegistry = null)
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
                setLicenseString["StoreInRegistry"] = ExpressionConverter.ConvertO(setLicenseStringstoreInRegistry);
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
        public IBodyWorkflowAction<GetLicenseStateResponse> GetLicenseState(Expression<Func<string>> getLicenseStateworkflow)
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
        public IWorkflowAction SetRSAGUITopmost(Expression<Func<string>> setRSAGUITopmostworkflow, Expression<Func<bool>> setRSAGUITopmosttopMost = null)
        {
            var apiCallPath = "/DriverControl/SetRSAGUITopmost";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setRSAGUITopmost = new JObject();
            var setRSAGUITopmostpropCount = 0;
            if (setRSAGUITopmosttopMost != null)
            {
                setRSAGUITopmost["TopMost"] = ExpressionConverter.ConvertO(setRSAGUITopmosttopMost);
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
        public IWorkflowAction SetRSAGUIOpacity(Expression<Func<double>> setRSAGUIOpacityopacity, Expression<Func<string>> setRSAGUIOpacityworkflow)
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
        public IWorkflowAction SetRSAGUIPosition(Expression<Func<int>> setRSAGUIPositionx, Expression<Func<int>> setRSAGUIPositiony, Expression<Func<string>> setRSAGUIPositionworkflow)
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
        public IWorkflowAction BringRSAGUIToFront(Expression<Func<string>> bringRSAGUIToFrontworkflow, Expression<Func<bool>> bringRSAGUIToFrontfocus = null, Expression<Func<bool>> bringRSAGUIToFrontglobalLeftMouseClick = null)
        {
            var apiCallPath = "/DriverControl/BringRSAGUIToFront";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var bringRSAGUIToFront = new JObject();
            var bringRSAGUIToFrontpropCount = 0;
            if (bringRSAGUIToFrontfocus != null)
            {
                bringRSAGUIToFront["Focus"] = ExpressionConverter.ConvertO(bringRSAGUIToFrontfocus);
                bringRSAGUIToFrontpropCount++;
            }

            if (bringRSAGUIToFrontglobalLeftMouseClick != null)
            {
                bringRSAGUIToFront["GlobalLeftMouseClick"] = ExpressionConverter.ConvertO(bringRSAGUIToFrontglobalLeftMouseClick);
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
        public IWorkflowAction DisconnectSession(Expression<Func<string>> disconnectSessionworkflow, Expression<Func<int>> disconnectSessionsecondsToWait = null, Expression<Func<bool>> disconnectSessiondoNotDisconnectIfLocalAgent = null)
        {
            var apiCallPath = "/DriverControl/DisconnectSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var disconnectSession = new JObject();
            var disconnectSessionpropCount = 0;
            if (disconnectSessionsecondsToWait != null)
            {
                disconnectSession["SecondsToWait"] = ExpressionConverter.ConvertO(disconnectSessionsecondsToWait);
                disconnectSessionpropCount++;
            }

            if (disconnectSessiondoNotDisconnectIfLocalAgent != null)
            {
                disconnectSession["DoNotDisconnectIfLocalAgent"] = ExpressionConverter.ConvertO(disconnectSessiondoNotDisconnectIfLocalAgent);
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
        public IWorkflowAction LogoffSession(Expression<Func<string>> logoffSessionworkflow, Expression<Func<int>> logoffSessionsecondsToWait = null)
        {
            var apiCallPath = "/DriverControl/LogoffSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var logoffSession = new JObject();
            var logoffSessionpropCount = 0;
            if (logoffSessionsecondsToWait != null)
            {
                logoffSession["SecondsToWait"] = ExpressionConverter.ConvertO(logoffSessionsecondsToWait);
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
        public IWorkflowAction CloseRSAServer(Expression<Func<string>> closeRSAServerworkflow, Expression<Func<int>> closeRSAServersecondsToWait = null)
        {
            var apiCallPath = "/DriverControl/CloseRSAServer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var closeRSAServer = new JObject();
            var closeRSAServerpropCount = 0;
            if (closeRSAServersecondsToWait != null)
            {
                closeRSAServer["SecondsToWait"] = ExpressionConverter.ConvertO(closeRSAServersecondsToWait);
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
        public IWorkflowAction SetRPACommandTimeout(Expression<Func<int>> setRPACommandTimeoutcommandTimeoutInSeconds, Expression<Func<string>> setRPACommandTimeoutworkflow, Expression<Func<bool>> setRPACommandTimeoutterminateTimedoutRPACommandThreads = null)
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
                setRPACommandTimeout["TerminateTimedoutRPACommandThreads"] = ExpressionConverter.ConvertO(setRPACommandTimeoutterminateTimedoutRPACommandThreads);
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
        public IWorkflowAction RunAlternativeIAConnect(Expression<Func<string>> runAlternativeIAConnectfilename, Expression<Func<string>> runAlternativeIAConnectworkflow, Expression<Func<string>> runAlternativeIAConnectarguments = null, Expression<Func<bool>> runAlternativeIAConnectloadIntoMemory = null)
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
                runAlternativeIAConnect["LoadIntoMemory"] = ExpressionConverter.ConvertO(runAlternativeIAConnectloadIntoMemory);
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
        public IBodyWorkflowAction<RunAlternativeIAConnectSentFromDirectorResponse> RunAlternativeIAConnectSentFromDirector(Expression<Func<string>> runAlternativeIAConnectSentFromDirectorlocalFilename, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorworkflow, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorremoteFilename = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorcompress = null, Expression<Func<string>> runAlternativeIAConnectSentFromDirectorarguments = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorpermitDowngrade = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorskipVersionCheck = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorloadIntoMemory = null, Expression<Func<bool>> runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory = null)
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
                runAlternativeIAConnectSentFromDirector["Compress"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorcompress);
                runAlternativeIAConnectSentFromDirectorpropCount++;
            }

            if (runAlternativeIAConnectSentFromDirectorarguments != null)
            {
                runAlternativeIAConnectSentFromDirector["Arguments"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorarguments);
                runAlternativeIAConnectSentFromDirectorpropCount++;
            }

            if (runAlternativeIAConnectSentFromDirectorpermitDowngrade != null)
            {
                runAlternativeIAConnectSentFromDirector["PermitDowngrade"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorpermitDowngrade);
                runAlternativeIAConnectSentFromDirectorpropCount++;
            }

            if (runAlternativeIAConnectSentFromDirectorskipVersionCheck != null)
            {
                runAlternativeIAConnectSentFromDirector["SkipVersionCheck"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorskipVersionCheck);
                runAlternativeIAConnectSentFromDirectorpropCount++;
            }

            if (runAlternativeIAConnectSentFromDirectorloadIntoMemory != null)
            {
                runAlternativeIAConnectSentFromDirector["LoadIntoMemory"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorloadIntoMemory);
                runAlternativeIAConnectSentFromDirectorpropCount++;
            }

            if (runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory != null)
            {
                runAlternativeIAConnectSentFromDirector["SaveToDiskEvenIfRunningFromMemory"] = ExpressionConverter.ConvertO(runAlternativeIAConnectSentFromDirectorsaveToDiskEvenIfRunningFromMemory);
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
        public IBodyWorkflowAction<GetIAConnectAgentInfoResponse> GetIAConnectAgentInfo(Expression<Func<string>> getIAConnectAgentInfoworkflow)
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
        public IBodyWorkflowAction<GetIAConnectAgentLogResponse> GetIAConnectAgentLog(Expression<Func<string>> getIAConnectAgentLogworkflow, Expression<Func<bool>> getIAConnectAgentLogcompress = null, Expression<Func<bool>> getIAConnectAgentLogreturnLastCommandOnly = null, Expression<Func<bool>> getIAConnectAgentLogsaveLogToFile = null, Expression<Func<bool>> getIAConnectAgentLogplaceLogContentInDataItem = null, Expression<Func<string>> getIAConnectAgentLoglocalSaveFolder = null, Expression<Func<bool>> getIAConnectAgentLoguseAgentLogFilename = null, Expression<Func<string>> getIAConnectAgentLoglocalSaveFilename = null, Expression<Func<int>> getIAConnectAgentLogmaxBytesToRead = null)
        {
            var apiCallPath = "/DriverControl/GetIAConnectAgentLog";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getIAConnectAgentLog = new JObject();
            var getIAConnectAgentLogpropCount = 0;
            if (getIAConnectAgentLogcompress != null)
            {
                getIAConnectAgentLog["Compress"] = ExpressionConverter.ConvertO(getIAConnectAgentLogcompress);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLogreturnLastCommandOnly != null)
            {
                getIAConnectAgentLog["ReturnLastCommandOnly"] = ExpressionConverter.ConvertO(getIAConnectAgentLogreturnLastCommandOnly);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLogsaveLogToFile != null)
            {
                getIAConnectAgentLog["SaveLogToFile"] = ExpressionConverter.ConvertO(getIAConnectAgentLogsaveLogToFile);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLogplaceLogContentInDataItem != null)
            {
                getIAConnectAgentLog["PlaceLogContentInDataItem"] = ExpressionConverter.ConvertO(getIAConnectAgentLogplaceLogContentInDataItem);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLoglocalSaveFolder != null)
            {
                getIAConnectAgentLog["LocalSaveFolder"] = ExpressionConverter.ConvertO(getIAConnectAgentLoglocalSaveFolder);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLoguseAgentLogFilename != null)
            {
                getIAConnectAgentLog["UseAgentLogFilename"] = ExpressionConverter.ConvertO(getIAConnectAgentLoguseAgentLogFilename);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLoglocalSaveFilename != null)
            {
                getIAConnectAgentLog["LocalSaveFilename"] = ExpressionConverter.ConvertO(getIAConnectAgentLoglocalSaveFilename);
                getIAConnectAgentLogpropCount++;
            }

            if (getIAConnectAgentLogmaxBytesToRead != null)
            {
                getIAConnectAgentLog["MaxBytesToRead"] = ExpressionConverter.ConvertO(getIAConnectAgentLogmaxBytesToRead);
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
        public IWorkflowAction ResetCommandStats(Expression<Func<string>> resetCommandStatsworkflow)
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
        public IBodyWorkflowAction<GetAllCommandStatsResponse> GetAllCommandStats(Expression<Func<string>> getAllCommandStatsworkflow)
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
        public IBodyWorkflowAction<EnableNextHopResponse> EnableNextHop(Expression<Func<string>> enableNextHopworkflow, Expression<Func<string>> enableNextHopnextHopDirectorAddress = null, Expression<Func<int>> enableNextHopnextHopDirectorTCPPort = null, Expression<Func<bool>> enableNextHopnextHopDirectorUsesHTTPS = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsLocalhostname = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsHostname = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsFQDN = null, Expression<Func<bool>> enableNextHopincrementNextHopDirectorTCPPortBySessionId = null, Expression<Func<bool>> enableNextHopdisableBeforeEnable = null, Expression<Func<bool>> enableNextHopcheckNextHopDirectorIsRunning = null, Expression<Func<bool>> enableNextHopcheckNextHopAgentIsRunning = null, Expression<Func<bool>> enableNextHopnextHopDirectorAddressIsNamedPipe = null)
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
                enableNextHop["NextHopDirectorTCPPort"] = ExpressionConverter.ConvertO(enableNextHopnextHopDirectorTCPPort);
                enableNextHoppropCount++;
            }

            if (enableNextHopnextHopDirectorUsesHTTPS != null)
            {
                enableNextHop["NextHopDirectorUsesHTTPS"] = ExpressionConverter.ConvertO(enableNextHopnextHopDirectorUsesHTTPS);
                enableNextHoppropCount++;
            }

            if (enableNextHopnextHopDirectorAddressIsLocalhostname != null)
            {
                enableNextHop["NextHopDirectorAddressIsLocalhostname"] = ExpressionConverter.ConvertO(enableNextHopnextHopDirectorAddressIsLocalhostname);
                enableNextHoppropCount++;
            }

            if (enableNextHopnextHopDirectorAddressIsHostname != null)
            {
                enableNextHop["NextHopDirectorAddressIsHostname"] = ExpressionConverter.ConvertO(enableNextHopnextHopDirectorAddressIsHostname);
                enableNextHoppropCount++;
            }

            if (enableNextHopnextHopDirectorAddressIsFQDN != null)
            {
                enableNextHop["NextHopDirectorAddressIsFQDN"] = ExpressionConverter.ConvertO(enableNextHopnextHopDirectorAddressIsFQDN);
                enableNextHoppropCount++;
            }

            if (enableNextHopincrementNextHopDirectorTCPPortBySessionId != null)
            {
                enableNextHop["IncrementNextHopDirectorTCPPortBySessionId"] = ExpressionConverter.ConvertO(enableNextHopincrementNextHopDirectorTCPPortBySessionId);
                enableNextHoppropCount++;
            }

            if (enableNextHopdisableBeforeEnable != null)
            {
                enableNextHop["DisableBeforeEnable"] = ExpressionConverter.ConvertO(enableNextHopdisableBeforeEnable);
                enableNextHoppropCount++;
            }

            if (enableNextHopcheckNextHopDirectorIsRunning != null)
            {
                enableNextHop["CheckNextHopDirectorIsRunning"] = ExpressionConverter.ConvertO(enableNextHopcheckNextHopDirectorIsRunning);
                enableNextHoppropCount++;
            }

            if (enableNextHopcheckNextHopAgentIsRunning != null)
            {
                enableNextHop["CheckNextHopAgentIsRunning"] = ExpressionConverter.ConvertO(enableNextHopcheckNextHopAgentIsRunning);
                enableNextHoppropCount++;
            }

            if (enableNextHopnextHopDirectorAddressIsNamedPipe != null)
            {
                enableNextHop["NextHopDirectorAddressIsNamedPipe"] = ExpressionConverter.ConvertO(enableNextHopnextHopDirectorAddressIsNamedPipe);
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
        public IWorkflowAction DisableNextHop(Expression<Func<string>> disableNextHopworkflow)
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
        public IBodyWorkflowAction<GetNextHopStatusResponse> GetNextHopStatus(Expression<Func<string>> getNextHopStatusworkflow, Expression<Func<bool>> getNextHopStatuscheckNextHopDirectorIsRunning = null, Expression<Func<bool>> getNextHopStatuscheckNextHopAgentIsRunning = null)
        {
            var apiCallPath = "/DriverControl/GetNextHopStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getNextHopStatus = new JObject();
            var getNextHopStatuspropCount = 0;
            if (getNextHopStatuscheckNextHopDirectorIsRunning != null)
            {
                getNextHopStatus["CheckNextHopDirectorIsRunning"] = ExpressionConverter.ConvertO(getNextHopStatuscheckNextHopDirectorIsRunning);
                getNextHopStatuspropCount++;
            }

            if (getNextHopStatuscheckNextHopAgentIsRunning != null)
            {
                getNextHopStatus["CheckNextHopAgentIsRunning"] = ExpressionConverter.ConvertO(getNextHopStatuscheckNextHopAgentIsRunning);
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
        public IBodyWorkflowAction<WaitForNextHopSessionToConnectResponse> WaitForNextHopSessionToConnect(Expression<Func<string>> waitForNextHopSessionToConnectworkflow, Expression<Func<string>> waitForNextHopSessionToConnectnextHopDirectorAddress = null, Expression<Func<int>> waitForNextHopSessionToConnectnextHopDirectorTCPPort = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN = null, Expression<Func<bool>> waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId = null, Expression<Func<double>> waitForNextHopSessionToConnectsecondsToWait = null, Expression<Func<bool>> waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe = null, Expression<Func<bool>> waitForNextHopSessionToConnectdisableExistingNextHop = null)
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
                waitForNextHopSessionToConnect["NextHopDirectorTCPPort"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectnextHopDirectorTCPPort);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS != null)
            {
                waitForNextHopSessionToConnect["NextHopDirectorUsesHTTPS"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectnextHopDirectorUsesHTTPS);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname != null)
            {
                waitForNextHopSessionToConnect["NextHopDirectorAddressIsLocalhostname"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectnextHopDirectorAddressIsLocalhostname);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname != null)
            {
                waitForNextHopSessionToConnect["NextHopDirectorAddressIsHostname"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectnextHopDirectorAddressIsHostname);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN != null)
            {
                waitForNextHopSessionToConnect["NextHopDirectorAddressIsFQDN"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectnextHopDirectorAddressIsFQDN);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId != null)
            {
                waitForNextHopSessionToConnect["IncrementNextHopDirectorTCPPortBySessionId"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectincrementNextHopDirectorTCPPortBySessionId);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectsecondsToWait != null)
            {
                waitForNextHopSessionToConnect["SecondsToWait"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectsecondsToWait);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe != null)
            {
                waitForNextHopSessionToConnect["NextHopDirectorAddressIsNamedPipe"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectnextHopDirectorAddressIsNamedPipe);
                waitForNextHopSessionToConnectpropCount++;
            }

            if (waitForNextHopSessionToConnectdisableExistingNextHop != null)
            {
                waitForNextHopSessionToConnect["DisableExistingNextHop"] = ExpressionConverter.ConvertO(waitForNextHopSessionToConnectdisableExistingNextHop);
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
        public IWorkflowAction ConfigureNextHopDirector(Expression<Func<string>> configureNextHopDirectorworkflow, Expression<Func<bool>> configureNextHopDirectorsOAPEnabled = null, Expression<Func<bool>> configureNextHopDirectorrESTEnabled = null, Expression<Func<bool>> configureNextHopDirectorwebServerEnabled = null, Expression<Func<bool>> configureNextHopDirectordirectorIsLocalhostOnly = null, Expression<Func<int>> configureNextHopDirectorsOAPTCPPort = null, Expression<Func<int>> configureNextHopDirectorrESTTCPPort = null, Expression<Func<bool>> configureNextHopDirectorsOAPUsesHTTPS = null, Expression<Func<bool>> configureNextHopDirectorrESTUsesHTTPS = null, Expression<Func<bool>> configureNextHopDirectorincrementDirectorTCPPortBySessionId = null, Expression<Func<bool>> configureNextHopDirectorsOAPUsesUserAuthentication = null, Expression<Func<bool>> configureNextHopDirectorrESTUsesUserAuthentication = null, Expression<Func<bool>> configureNextHopDirectorcommandNamedPipeEnabled = null)
        {
            var apiCallPath = "/DriverControl/ConfigureNextHopDirector";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var configureNextHopDirector = new JObject();
            var configureNextHopDirectorpropCount = 0;
            if (configureNextHopDirectorsOAPEnabled != null)
            {
                configureNextHopDirector["SOAPEnabled"] = ExpressionConverter.ConvertO(configureNextHopDirectorsOAPEnabled);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorrESTEnabled != null)
            {
                configureNextHopDirector["RESTEnabled"] = ExpressionConverter.ConvertO(configureNextHopDirectorrESTEnabled);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorwebServerEnabled != null)
            {
                configureNextHopDirector["WebServerEnabled"] = ExpressionConverter.ConvertO(configureNextHopDirectorwebServerEnabled);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectordirectorIsLocalhostOnly != null)
            {
                configureNextHopDirector["DirectorIsLocalhostOnly"] = ExpressionConverter.ConvertO(configureNextHopDirectordirectorIsLocalhostOnly);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorsOAPTCPPort != null)
            {
                configureNextHopDirector["SOAPTCPPort"] = ExpressionConverter.ConvertO(configureNextHopDirectorsOAPTCPPort);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorrESTTCPPort != null)
            {
                configureNextHopDirector["RESTTCPPort"] = ExpressionConverter.ConvertO(configureNextHopDirectorrESTTCPPort);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorsOAPUsesHTTPS != null)
            {
                configureNextHopDirector["SOAPUsesHTTPS"] = ExpressionConverter.ConvertO(configureNextHopDirectorsOAPUsesHTTPS);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorrESTUsesHTTPS != null)
            {
                configureNextHopDirector["RESTUsesHTTPS"] = ExpressionConverter.ConvertO(configureNextHopDirectorrESTUsesHTTPS);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorincrementDirectorTCPPortBySessionId != null)
            {
                configureNextHopDirector["IncrementDirectorTCPPortBySessionId"] = ExpressionConverter.ConvertO(configureNextHopDirectorincrementDirectorTCPPortBySessionId);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorsOAPUsesUserAuthentication != null)
            {
                configureNextHopDirector["SOAPUsesUserAuthentication"] = ExpressionConverter.ConvertO(configureNextHopDirectorsOAPUsesUserAuthentication);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorrESTUsesUserAuthentication != null)
            {
                configureNextHopDirector["RESTUsesUserAuthentication"] = ExpressionConverter.ConvertO(configureNextHopDirectorrESTUsesUserAuthentication);
                configureNextHopDirectorpropCount++;
            }

            if (configureNextHopDirectorcommandNamedPipeEnabled != null)
            {
                configureNextHopDirector["CommandNamedPipeEnabled"] = ExpressionConverter.ConvertO(configureNextHopDirectorcommandNamedPipeEnabled);
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
        public IWorkflowAction ResetNextHopDirectorSettings(Expression<Func<string>> resetNextHopDirectorSettingsworkflow)
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
        public IWorkflowAction WorkflowCompleted(Expression<Func<string>> workflowCompletedworkflow)
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
        public IBodyWorkflowAction<RaiseExceptionResponse> RaiseException(Expression<Func<string>> raiseExceptioninputException = null, Expression<Func<string>> raiseExceptionexceptionMessage = null)
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
        public IBodyWorkflowAction<UpdateOrchestratorFlowStatsResultResponse> UpdateOrchestratorFlowStatsResult(Expression<Func<string>> updateOrchestratorFlowStatsResultworkflow, Expression<Func<bool>> updateOrchestratorFlowStatsResultflowLastActionSuccess = null, Expression<Func<string>> updateOrchestratorFlowStatsResultflowLastActionErrorMessage = null, Expression<Func<int>> updateOrchestratorFlowStatsResultflowLastActionCode = null)
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
        public IBodyWorkflowAction<GetLastFailedActionFromOrchestratorFlowStatsResponse> GetLastFailedActionFromOrchestratorFlowStats(Expression<Func<string>> getLastFailedActionFromOrchestratorFlowStatsworkflow)
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
        public IBodyWorkflowAction<GetOrchestratorFlowStatsResponse> GetOrchestratorFlowStats(Expression<Func<int>> getOrchestratorFlowStatswithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorFlowStatssearchFlowName = null, Expression<Func<bool>> getOrchestratorFlowStatssearchFlowLastActionResult = null, Expression<Func<string>> getOrchestratorFlowStatssearchFlowStartTimeStartWindow = null, Expression<Func<string>> getOrchestratorFlowStatssearchFlowStartTimeEndWindow = null)
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
        public IBodyWorkflowAction<GetOrchestratorWorkerAvailabilityStatsResponse> GetOrchestratorWorkerAvailabilityStats(Expression<Func<int>> getOrchestratorWorkerAvailabilityStatswithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorWorkerAvailabilityStatssearchFlowName = null, Expression<Func<string>> getOrchestratorWorkerAvailabilityStatssearchFlowStartTimeStartWindow = null)
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
        public IBodyWorkflowAction<GetOrchestratorWorkerFlowUsageHeatmapResponse> GetOrchestratorWorkerFlowUsageHeatmap(Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapsearchStartDateStartWindow, Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapsearchStartDateEndWindow, Expression<Func<int>> getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC = null, Expression<Func<string>> getOrchestratorWorkerFlowUsageHeatmapworkerNames = null)
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
                getOrchestratorWorkerFlowUsageHeatmap["TimeZoneMinutesOffsetFromUTC"] = ExpressionConverter.ConvertO(getOrchestratorWorkerFlowUsageHeatmaptimeZoneMinutesOffsetFromUTC);
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
        public IBodyWorkflowAction<GetOrchestratorLoginHistoryResponse> GetOrchestratorLoginHistory(Expression<Func<int>> getOrchestratorLoginHistorywithinLastNumberOfDays = null, Expression<Func<string>> getOrchestratorLoginHistorysearchByEmail = null, Expression<Func<string>> getOrchestratorLoginHistorysearchLoginHistoryTimeStartWindow = null, Expression<Func<string>> getOrchestratorLoginHistorysearchLoginHistoryTimeEndWindow = null)
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
        public IWorkflowAction SetLocalLoggingLevel(Expression<Func<int>> setLocalLoggingLevelloggingLevel, Expression<Func<string>> setLocalLoggingLevelworkflow)
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
        public IBodyWorkflowAction<RunCommandResponse> RunCommand(Expression<Func<string>> runCommandcommandName, Expression<Func<string>> runCommandworkflow, Expression<Func<string>> runCommandinputJSON = null)
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
        public IBodyWorkflowAction<GetLocalLoggingLevelResponse> GetLocalLoggingLevel(Expression<Func<string>> getLocalLoggingLevelworkflow)
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
        public IBodyWorkflowAction<GetRemoteClientTypeResponse> GetRemoteClientType(Expression<Func<string>> getRemoteClientTypeworkflow)
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
        public IBodyWorkflowAction<GetIAConnectDirectorInfoResponse> GetIAConnectDirectorInfo(Expression<Func<string>> getIAConnectDirectorInfoworkflow)
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
        public IBodyWorkflowAction<GetAvailableIAConnectSessionsResponse> GetAvailableIAConnectSessions(Expression<Func<string>> getAvailableIAConnectSessionsworkflow)
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
        public IWorkflowAction AttachToIAConnectSessionByName(Expression<Func<string>> attachToIAConnectSessionByNameiAConnectSessionName, Expression<Func<string>> attachToIAConnectSessionByNameworkflow, Expression<Func<bool>> attachToIAConnectSessionByNamevirtualChannelMustBeConnected = null)
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
                attachToIAConnectSessionByName["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByNamevirtualChannelMustBeConnected);
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
        public IBodyWorkflowAction<AttachToTier1IAConnectSessionResponse> AttachToTier1IAConnectSession(Expression<Func<string>> attachToTier1IAConnectSessionworkflow, Expression<Func<bool>> attachToTier1IAConnectSessionvirtualChannelMustBeConnected = null)
        {
            var apiCallPath = "/DriverControl/AttachToTier1IAConnectSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var attachToTier1IAConnectSession = new JObject();
            var attachToTier1IAConnectSessionpropCount = 0;
            if (attachToTier1IAConnectSessionvirtualChannelMustBeConnected != null)
            {
                attachToTier1IAConnectSession["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(attachToTier1IAConnectSessionvirtualChannelMustBeConnected);
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
        public IBodyWorkflowAction<AttachToIAConnectSessionByIndexResponse> AttachToIAConnectSessionByIndex(Expression<Func<string>> attachToIAConnectSessionByIndexworkflow, Expression<Func<attachToIAConnectSessionByIndexsearchIAConnectSessionTypeInput>> attachToIAConnectSessionByIndexsearchIAConnectSessionType = null, Expression<Func<int>> attachToIAConnectSessionByIndexsearchIAConnectSessionIndex = null, Expression<Func<int>> attachToIAConnectSessionByIndextimeToWaitInSeconds = null, Expression<Func<bool>> attachToIAConnectSessionByIndexraiseExceptionIfTimedout = null, Expression<Func<bool>> attachToIAConnectSessionByIndexvirtualChannelMustBeConnected = null, Expression<Func<bool>> attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore = null)
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
                attachToIAConnectSessionByIndex["RaiseExceptionIfTimedout"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexraiseExceptionIfTimedout);
                attachToIAConnectSessionByIndexpropCount++;
            }

            if (attachToIAConnectSessionByIndexvirtualChannelMustBeConnected != null)
            {
                attachToIAConnectSessionByIndex["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexvirtualChannelMustBeConnected);
                attachToIAConnectSessionByIndexpropCount++;
            }

            if (attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore != null)
            {
                attachToIAConnectSessionByIndex["OnlyCountSessionsNotSeenBefore"] = ExpressionConverter.ConvertO(attachToIAConnectSessionByIndexonlyCountSessionsNotSeenBefore);
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
        public IBodyWorkflowAction<AttachToMostRecentIAConnectSessionResponse> AttachToMostRecentIAConnectSession(Expression<Func<string>> attachToMostRecentIAConnectSessionworkflow, Expression<Func<attachToMostRecentIAConnectSessionsearchIAConnectSessionTypeInput>> attachToMostRecentIAConnectSessionsearchIAConnectSessionType = null, Expression<Func<int>> attachToMostRecentIAConnectSessiontimeToWaitInSeconds = null, Expression<Func<bool>> attachToMostRecentIAConnectSessionraiseExceptionIfTimedout = null, Expression<Func<bool>> attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected = null, Expression<Func<bool>> attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore = null)
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
                attachToMostRecentIAConnectSession["RaiseExceptionIfTimedout"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessionraiseExceptionIfTimedout);
                attachToMostRecentIAConnectSessionpropCount++;
            }

            if (attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected != null)
            {
                attachToMostRecentIAConnectSession["VirtualChannelMustBeConnected"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessionvirtualChannelMustBeConnected);
                attachToMostRecentIAConnectSessionpropCount++;
            }

            if (attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore != null)
            {
                attachToMostRecentIAConnectSession["OnlyCountSessionsNotSeenBefore"] = ExpressionConverter.ConvertO(attachToMostRecentIAConnectSessiononlyCountSessionsNotSeenBefore);
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
        public IBodyWorkflowAction<GetDirectorUpTimeResponse> GetDirectorUpTime(Expression<Func<string>> getDirectorUpTimeworkflow)
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
        public IBodyWorkflowAction<DoesIAConnectSessionExistByNameResponse> DoesIAConnectSessionExistByName(Expression<Func<string>> doesIAConnectSessionExistByNameiAConnectSessionName, Expression<Func<string>> doesIAConnectSessionExistByNameworkflow)
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
        public IBodyWorkflowAction<WaitForIAConnectSessionToCloseByNameResponse> WaitForIAConnectSessionToCloseByName(Expression<Func<string>> waitForIAConnectSessionToCloseByNameiAConnectSessionName, Expression<Func<string>> waitForIAConnectSessionToCloseByNameworkflow, Expression<Func<int>> waitForIAConnectSessionToCloseByNametimeToWaitInSeconds = null, Expression<Func<bool>> waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout = null, Expression<Func<bool>> waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess = null)
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
                waitForIAConnectSessionToCloseByName["RaiseExceptionIfTimedout"] = ExpressionConverter.ConvertO(waitForIAConnectSessionToCloseByNameraiseExceptionIfTimedout);
                waitForIAConnectSessionToCloseByNamepropCount++;
            }

            if (waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess != null)
            {
                waitForIAConnectSessionToCloseByName["AttachToTier1IAConnectSessionOnSuccess"] = ExpressionConverter.ConvertO(waitForIAConnectSessionToCloseByNameattachToTier1IAConnectSessionOnSuccess);
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
        public IBodyWorkflowAction<KillIAConnectSessionByNameResponse> KillIAConnectSessionByName(Expression<Func<string>> killIAConnectSessionByNameiAConnectSessionName, Expression<Func<string>> killIAConnectSessionByNameworkflow, Expression<Func<bool>> killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess = null)
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
                killIAConnectSessionByName["AttachToTier1IAConnectSessionOnSuccess"] = ExpressionConverter.ConvertO(killIAConnectSessionByNameattachToTier1IAConnectSessionOnSuccess);
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
        public IBodyWorkflowAction<SetAgentGlobalCoordinateConfigurationResponse> SetAgentGlobalCoordinateConfiguration(Expression<Func<string>> setAgentGlobalCoordinateConfigurationworkflow, Expression<Func<setAgentGlobalCoordinateConfigurationmultiMonitorFunctionalityInput>> setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality = null, Expression<Func<setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplierInput>> setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier = null, Expression<Func<setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplierInput>> setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier = null, Expression<Func<double>> setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos = null, Expression<Func<bool>> setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod = null, Expression<Func<setAgentGlobalCoordinateConfigurationjavaCoordinateSystemInput>> setAgentGlobalCoordinateConfigurationjavaCoordinateSystem = null, Expression<Func<setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystemInput>> setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem = null)
        {
            var apiCallPath = "/DriverControl/SetAgentGlobalCoordinateConfiguration";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setAgentGlobalCoordinateConfiguration = new JObject();
            var setAgentGlobalCoordinateConfigurationpropCount = 0;
            if (setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality != null)
            {
                setAgentGlobalCoordinateConfiguration["MultiMonitorFunctionality"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationmultiMonitorFunctionality);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier != null)
            {
                setAgentGlobalCoordinateConfiguration["AutoSetMouseInspectionMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationautoSetMouseInspectionMultiplier);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier != null)
            {
                setAgentGlobalCoordinateConfiguration["AutoSetGlobalMouseMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationautoSetGlobalMouseMultiplier);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier != null)
            {
                setAgentGlobalCoordinateConfiguration["MouseInspectionXMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationmouseInspectionXMultiplier);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier != null)
            {
                setAgentGlobalCoordinateConfiguration["MouseInspectionYMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationmouseInspectionYMultiplier);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier != null)
            {
                setAgentGlobalCoordinateConfiguration["GlobalMouseXMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationglobalMouseXMultiplier);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier != null)
            {
                setAgentGlobalCoordinateConfiguration["GlobalMouseYMultiplier"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationglobalMouseYMultiplier);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent != null)
            {
                setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToMouseEvent"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToMouseEvent);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos != null)
            {
                setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToSetCursorPos"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToSetCursorPos);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod != null)
            {
                setAgentGlobalCoordinateConfiguration["GlobalMouseMultiplierApplyToCurrentMouseMoveMethod"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationglobalMouseMultiplierApplyToCurrentMouseMoveMethod);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationjavaCoordinateSystem != null)
            {
                setAgentGlobalCoordinateConfiguration["JavaCoordinateSystem"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationjavaCoordinateSystem);
                setAgentGlobalCoordinateConfigurationpropCount++;
            }

            if (setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem != null)
            {
                setAgentGlobalCoordinateConfiguration["SAPGUICoordinateSystem"] = ExpressionConverter.ConvertO(setAgentGlobalCoordinateConfigurationsAPGUICoordinateSystem);
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
        public IBodyWorkflowAction<GetAgentGlobalCoordinateConfigurationResponse> GetAgentGlobalCoordinateConfiguration(Expression<Func<string>> getAgentGlobalCoordinateConfigurationworkflow)
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
        public IBodyWorkflowAction<GetAgentThreadStatusResponse> GetAgentThreadStatus(Expression<Func<int>> getAgentThreadStatusthreadId, Expression<Func<string>> getAgentThreadStatusworkflow, Expression<Func<bool>> getAgentThreadStatusretrieveThreadOutputData = null, Expression<Func<bool>> getAgentThreadStatusclearOutputDataFromMemoryOnceRead = null)
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
                getAgentThreadStatus["RetrieveThreadOutputData"] = ExpressionConverter.ConvertO(getAgentThreadStatusretrieveThreadOutputData);
                getAgentThreadStatuspropCount++;
            }

            if (getAgentThreadStatusclearOutputDataFromMemoryOnceRead != null)
            {
                getAgentThreadStatus["ClearOutputDataFromMemoryOnceRead"] = ExpressionConverter.ConvertO(getAgentThreadStatusclearOutputDataFromMemoryOnceRead);
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
        public IBodyWorkflowAction<WaitForAgentThreadToCompleteSuccessfullyResponse> WaitForAgentThreadToCompleteSuccessfully(Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullythreadId, Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullysecondsToWaitForThread, Expression<Func<string>> waitForAgentThreadToCompleteSuccessfullyworkflow, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted = null, Expression<Func<bool>> waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError = null, Expression<Func<int>> waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall = null)
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
                waitForAgentThreadToCompleteSuccessfully["RetrieveThreadOutputData"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyretrieveThreadOutputData);
                waitForAgentThreadToCompleteSuccessfullypropCount++;
            }

            if (waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead != null)
            {
                waitForAgentThreadToCompleteSuccessfully["ClearOutputDataFromMemoryOnceRead"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyclearOutputDataFromMemoryOnceRead);
                waitForAgentThreadToCompleteSuccessfullypropCount++;
            }

            if (waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted != null)
            {
                waitForAgentThreadToCompleteSuccessfully["RaiseExceptionIfThreadNotCompleted"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadNotCompleted);
                waitForAgentThreadToCompleteSuccessfullypropCount++;
            }

            if (waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError != null)
            {
                waitForAgentThreadToCompleteSuccessfully["RaiseExceptionIfThreadError"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullyraiseExceptionIfThreadError);
                waitForAgentThreadToCompleteSuccessfullypropCount++;
            }

            if (waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall != null)
            {
                waitForAgentThreadToCompleteSuccessfully["SecondsToWaitPerCall"] = ExpressionConverter.ConvertO(waitForAgentThreadToCompleteSuccessfullysecondsToWaitPerCall);
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
        public IBodyWorkflowAction<GetAgentThreadsResponse> GetAgentThreads(Expression<Func<string>> getAgentThreadsworkflow, Expression<Func<getAgentThreadssortOrderInput>> getAgentThreadssortOrder = null)
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
        public IBodyWorkflowAction<KillAgentThreadResponse> KillAgentThread(Expression<Func<int>> killAgentThreadthreadId, Expression<Func<string>> killAgentThreadworkflow)
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
        public IBodyWorkflowAction<DeleteAgentThreadResponse> DeleteAgentThread(Expression<Func<string>> deleteAgentThreadworkflow, Expression<Func<int>> deleteAgentThreadthreadId = null, Expression<Func<bool>> deleteAgentThreaddeleteAllAgentThreads = null, Expression<Func<bool>> deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete = null)
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
                deleteAgentThread["DeleteAllAgentThreads"] = ExpressionConverter.ConvertO(deleteAgentThreaddeleteAllAgentThreads);
                deleteAgentThreadpropCount++;
            }

            if (deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete != null)
            {
                deleteAgentThread["RaiseExceptionIfAgentThreadFailsToDelete"] = ExpressionConverter.ConvertO(deleteAgentThreadraiseExceptionIfAgentThreadFailsToDelete);
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
        public IBodyWorkflowAction<AllocateWorkerFromOrchestratorResponse> AllocateWorkerFromOrchestrator(Expression<Func<string>> allocateWorkerFromOrchestratorworkflow, Expression<Func<string>> allocateWorkerFromOrchestratorworkerTag = null, Expression<Func<string>> allocateWorkerFromOrchestratorworkerName = null, Expression<Func<bool>> allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable = null)
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
                allocateWorkerFromOrchestrator["RaiseExceptionIfWorkerNotImmediatelyAvailable"] = ExpressionConverter.ConvertO(allocateWorkerFromOrchestratorraiseExceptionIfWorkerNotImmediatelyAvailable);
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
        public IBodyWorkflowAction<SetOrchestratorWorkerMaintenanceModeResponse> SetOrchestratorWorkerMaintenanceMode(Expression<Func<int>> setOrchestratorWorkerMaintenanceModeworkerId = null, Expression<Func<string>> setOrchestratorWorkerMaintenanceModeworkerName = null, Expression<Func<bool>> setOrchestratorWorkerMaintenanceModemaintenanceMode = null)
        {
            var apiCallPath = "/DriverControl/SetOrchestratorWorkerMaintenanceMode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setOrchestratorWorkerMaintenanceMode = new JObject();
            var setOrchestratorWorkerMaintenanceModepropCount = 0;
            if (setOrchestratorWorkerMaintenanceModeworkerId != null)
            {
                setOrchestratorWorkerMaintenanceMode["WorkerId"] = ExpressionConverter.ConvertO(setOrchestratorWorkerMaintenanceModeworkerId);
                setOrchestratorWorkerMaintenanceModepropCount++;
            }

            if (setOrchestratorWorkerMaintenanceModeworkerName != null)
            {
                setOrchestratorWorkerMaintenanceMode["WorkerName"] = ExpressionConverter.ConvertO(setOrchestratorWorkerMaintenanceModeworkerName);
                setOrchestratorWorkerMaintenanceModepropCount++;
            }

            if (setOrchestratorWorkerMaintenanceModemaintenanceMode != null)
            {
                setOrchestratorWorkerMaintenanceMode["MaintenanceMode"] = ExpressionConverter.ConvertO(setOrchestratorWorkerMaintenanceModemaintenanceMode);
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
                createOrchestratorOneTimeSecret["MaximumRetrievalsBeforeDeletion"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretmaximumRetrievalsBeforeDeletion);
                createOrchestratorOneTimeSecretpropCount++;
            }

            if (createOrchestratorOneTimeSecretsecretHasAStartDate != null)
            {
                createOrchestratorOneTimeSecret["SecretHasAStartDate"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretsecretHasAStartDate);
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
                createOrchestratorOneTimeSecret["SecretHasAnExpiryDate"] = ExpressionConverter.ConvertO(createOrchestratorOneTimeSecretsecretHasAnExpiryDate);
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
        public IBodyWorkflowAction<GetListOfOrchestratorWorkersResponse> GetListOfOrchestratorWorkers(Expression<Func<bool>> getListOfOrchestratorWorkersonlyReturnLiveWorkers = null)
        {
            var apiCallPath = "/DriverControl/GetListOfOrchestratorWorkers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getListOfOrchestratorWorkers = new JObject();
            var getListOfOrchestratorWorkerspropCount = 0;
            if (getListOfOrchestratorWorkersonlyReturnLiveWorkers != null)
            {
                getListOfOrchestratorWorkers["OnlyReturnLiveWorkers"] = ExpressionConverter.ConvertO(getListOfOrchestratorWorkersonlyReturnLiveWorkers);
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
        public IBodyWorkflowAction<FileExistsResponse> FileExists(Expression<Func<string>> fileExistsfilename, Expression<Func<string>> fileExistsworkflow)
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
        public IBodyWorkflowAction<DirectoryExistsResponse> DirectoryExists(Expression<Func<string>> directoryExistsdirectoryPath, Expression<Func<string>> directoryExistsworkflow)
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
        public IWorkflowAction DeleteFile(Expression<Func<string>> deleteFilefilename, Expression<Func<string>> deleteFileworkflow)
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
        public IWorkflowAction DeleteDirectory(Expression<Func<string>> deleteDirectorydirectoryPath, Expression<Func<string>> deleteDirectoryworkflow, Expression<Func<bool>> deleteDirectoryrecursive = null)
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
                deleteDirectory["Recursive"] = ExpressionConverter.ConvertO(deleteDirectoryrecursive);
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
        public IWorkflowAction PurgeDirectory(Expression<Func<string>> purgeDirectorydirectoryPath, Expression<Func<string>> purgeDirectoryworkflow, Expression<Func<bool>> purgeDirectoryrecursive = null, Expression<Func<bool>> purgeDirectorydeleteTopLevel = null)
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
                purgeDirectory["Recursive"] = ExpressionConverter.ConvertO(purgeDirectoryrecursive);
                purgeDirectorypropCount++;
            }

            if (purgeDirectorydeleteTopLevel != null)
            {
                purgeDirectory["DeleteTopLevel"] = ExpressionConverter.ConvertO(purgeDirectorydeleteTopLevel);
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
        public IWorkflowAction CopyFile(Expression<Func<string>> copyFilesourceFilePath, Expression<Func<string>> copyFiledestFilePath, Expression<Func<string>> copyFileworkflow)
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
        public IWorkflowAction MoveFile(Expression<Func<string>> moveFilesourceFilePath, Expression<Func<string>> moveFiledestFilePath, Expression<Func<string>> moveFileworkflow)
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
        public IWorkflowAction CreateDirectory(Expression<Func<string>> createDirectorydirectoryPath, Expression<Func<string>> createDirectoryworkflow, Expression<Func<bool>> createDirectoryerrorIfAlreadyExists = null)
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
                createDirectory["ErrorIfAlreadyExists"] = ExpressionConverter.ConvertO(createDirectoryerrorIfAlreadyExists);
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
        public IBodyWorkflowAction<GetFileSizeResponse> GetFileSize(Expression<Func<string>> getFileSizefilename, Expression<Func<string>> getFileSizeworkflow)
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
        public IWorkflowAction WriteTextFile(Expression<Func<string>> writeTextFilefilename, Expression<Func<string>> writeTextFileworkflow, Expression<Func<string>> writeTextFiletextToWrite = null, Expression<Func<bool>> writeTextFileappendExistingFile = null, Expression<Func<writeTextFileencodingInput>> writeTextFileencoding = null, Expression<Func<bool>> writeTextFilecreateFolderIfRequired = null)
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
                writeTextFile["AppendExistingFile"] = ExpressionConverter.ConvertO(writeTextFileappendExistingFile);
                writeTextFilepropCount++;
            }

            if (writeTextFileencoding != null)
            {
                writeTextFile["Encoding"] = ExpressionConverter.ConvertO(writeTextFileencoding);
                writeTextFilepropCount++;
            }

            if (writeTextFilecreateFolderIfRequired != null)
            {
                writeTextFile["CreateFolderIfRequired"] = ExpressionConverter.ConvertO(writeTextFilecreateFolderIfRequired);
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
        public IBodyWorkflowAction<ReadAllTextFromFileResponse> ReadAllTextFromFile(Expression<Func<string>> readAllTextFromFilefilename, Expression<Func<string>> readAllTextFromFileworkflow)
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
        public IBodyWorkflowAction<GetFilesResponse> GetFiles(Expression<Func<string>> getFilesdirectoryPath, Expression<Func<string>> getFilespatternsCSV, Expression<Func<string>> getFilesworkflow)
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
        public IBodyWorkflowAction<GetFoldersResponse> GetFolders(Expression<Func<string>> getFoldersdirectoryPath, Expression<Func<string>> getFoldersworkflow)
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
        public IBodyWorkflowAction<DeleteFilesResponse> DeleteFiles(Expression<Func<string>> deleteFilesdirectoryPath, Expression<Func<string>> deleteFilesworkflow, Expression<Func<string>> deleteFilespattern = null)
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
        public IBodyWorkflowAction<GetDiskFreeSpaceResponse> GetDiskFreeSpace(Expression<Func<string>> getDiskFreeSpacedriveLetter, Expression<Func<string>> getDiskFreeSpaceworkflow)
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
        public IBodyWorkflowAction<GetListOfDrivesResponse> GetListOfDrives(Expression<Func<string>> getListOfDrivesworkflow)
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
        public IBodyWorkflowAction<DirectoryIsAccessibleResponse> DirectoryIsAccessible(Expression<Func<string>> directoryIsAccessibledirectoryPath, Expression<Func<string>> directoryIsAccessibleworkflow)
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
        public IBodyWorkflowAction<GetCSVTextAsCollectionResponse> GetCSVTextAsCollection(Expression<Func<string>> getCSVTextAsCollectioncSVFilePath, Expression<Func<string>> getCSVTextAsCollectionworkflow, Expression<Func<bool>> getCSVTextAsCollectionfirstLineIsHeader = null, Expression<Func<bool>> getCSVTextAsCollectiontrimHeaders = null, Expression<Func<bool>> getCSVTextAsCollectionallowBlankRows = null, Expression<Func<bool>> getCSVTextAsCollectionextendColumnsIfRequired = null)
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
                getCSVTextAsCollection["FirstLineIsHeader"] = ExpressionConverter.ConvertO(getCSVTextAsCollectionfirstLineIsHeader);
                getCSVTextAsCollectionpropCount++;
            }

            if (getCSVTextAsCollectiontrimHeaders != null)
            {
                getCSVTextAsCollection["TrimHeaders"] = ExpressionConverter.ConvertO(getCSVTextAsCollectiontrimHeaders);
                getCSVTextAsCollectionpropCount++;
            }

            if (getCSVTextAsCollectionallowBlankRows != null)
            {
                getCSVTextAsCollection["AllowBlankRows"] = ExpressionConverter.ConvertO(getCSVTextAsCollectionallowBlankRows);
                getCSVTextAsCollectionpropCount++;
            }

            if (getCSVTextAsCollectionextendColumnsIfRequired != null)
            {
                getCSVTextAsCollection["ExtendColumnsIfRequired"] = ExpressionConverter.ConvertO(getCSVTextAsCollectionextendColumnsIfRequired);
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
        public IBodyWorkflowAction<WriteCollectionToCSVFileResponse> WriteCollectionToCSVFile(Expression<Func<string>> writeCollectionToCSVFilecSVFilePath, Expression<Func<string>> writeCollectionToCSVFileworkflow, Expression<Func<JToken[]>> writeCollectionToCSVFileinputTable = null, Expression<Func<string>> writeCollectionToCSVFileinputTableJSON = null, Expression<Func<writeCollectionToCSVFileoutputEncodingInput>> writeCollectionToCSVFileoutputEncoding = null)
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
                writeCollectionToCSVFile["OutputEncoding"] = ExpressionConverter.ConvertO(writeCollectionToCSVFileoutputEncoding);
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
        public IWorkflowAction SetOwnerOnFolder(Expression<Func<string>> setOwnerOnFolderfolderPath, Expression<Func<string>> setOwnerOnFolderuserIdentity, Expression<Func<string>> setOwnerOnFolderworkflow)
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
        public IWorkflowAction SetOwnerOnFile(Expression<Func<string>> setOwnerOnFilefilePath, Expression<Func<string>> setOwnerOnFileuserIdentity, Expression<Func<string>> setOwnerOnFileworkflow)
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
        public IWorkflowAction AddPermissionToFolder(Expression<Func<string>> addPermissionToFolderfolderPath, Expression<Func<string>> addPermissionToFolderidentity, Expression<Func<addPermissionToFolderpermissionInput>> addPermissionToFolderpermission, Expression<Func<string>> addPermissionToFolderworkflow, Expression<Func<bool>> addPermissionToFolderapplyToFolder = null, Expression<Func<bool>> addPermissionToFolderapplyToSubFolders = null, Expression<Func<bool>> addPermissionToFolderapplyToFiles = null, Expression<Func<bool>> addPermissionToFolderdeny = null)
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
                addPermissionToFolder["ApplyToFolder"] = ExpressionConverter.ConvertO(addPermissionToFolderapplyToFolder);
                addPermissionToFolderpropCount++;
            }

            if (addPermissionToFolderapplyToSubFolders != null)
            {
                addPermissionToFolder["ApplyToSubFolders"] = ExpressionConverter.ConvertO(addPermissionToFolderapplyToSubFolders);
                addPermissionToFolderpropCount++;
            }

            if (addPermissionToFolderapplyToFiles != null)
            {
                addPermissionToFolder["ApplyToFiles"] = ExpressionConverter.ConvertO(addPermissionToFolderapplyToFiles);
                addPermissionToFolderpropCount++;
            }

            if (addPermissionToFolderdeny != null)
            {
                addPermissionToFolder["Deny"] = ExpressionConverter.ConvertO(addPermissionToFolderdeny);
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
        public IWorkflowAction AddPermissionToFile(Expression<Func<string>> addPermissionToFilefilePath, Expression<Func<string>> addPermissionToFileidentity, Expression<Func<addPermissionToFilepermissionInput>> addPermissionToFilepermission, Expression<Func<string>> addPermissionToFileworkflow, Expression<Func<bool>> addPermissionToFiledeny = null)
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
                addPermissionToFile["Deny"] = ExpressionConverter.ConvertO(addPermissionToFiledeny);
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
        public IWorkflowAction BreakFolderSecurityInheritance(Expression<Func<string>> breakFolderSecurityInheritancefolderPath, Expression<Func<string>> breakFolderSecurityInheritanceworkflow, Expression<Func<bool>> breakFolderSecurityInheritanceconvertInheritedToExplicit = null)
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
                breakFolderSecurityInheritance["ConvertInheritedToExplicit"] = ExpressionConverter.ConvertO(breakFolderSecurityInheritanceconvertInheritedToExplicit);
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
        public IWorkflowAction EnableFolderSecurityInheritance(Expression<Func<string>> enableFolderSecurityInheritancefolderPath, Expression<Func<string>> enableFolderSecurityInheritanceworkflow)
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
        public IBodyWorkflowAction<GetFolderSecurityPermissionsResponse> GetFolderSecurityPermissions(Expression<Func<string>> getFolderSecurityPermissionsfolderPath, Expression<Func<string>> getFolderSecurityPermissionsworkflow)
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
        public IBodyWorkflowAction<GetFileSecurityPermissionsResponse> GetFileSecurityPermissions(Expression<Func<string>> getFileSecurityPermissionsfilePath, Expression<Func<string>> getFileSecurityPermissionsworkflow)
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
        public IBodyWorkflowAction<RemoveIdentityFromFolderSecurityResponse> RemoveIdentityFromFolderSecurity(Expression<Func<string>> removeIdentityFromFolderSecurityfolderPath, Expression<Func<string>> removeIdentityFromFolderSecurityidentityToRemove, Expression<Func<string>> removeIdentityFromFolderSecurityworkflow)
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
        public IBodyWorkflowAction<RemoveIdentityFromFileSecurityResponse> RemoveIdentityFromFileSecurity(Expression<Func<string>> removeIdentityFromFileSecurityfilePath, Expression<Func<string>> removeIdentityFromFileSecurityidentityToRemove, Expression<Func<string>> removeIdentityFromFileSecurityworkflow)
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
        public IWorkflowAction CopyFileFromClientToServer(Expression<Func<string>> copyFileFromClientToServerclientFilePath, Expression<Func<string>> copyFileFromClientToServerserverFilePath, Expression<Func<string>> copyFileFromClientToServerworkflow, Expression<Func<bool>> copyFileFromClientToServercompress = null)
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
                copyFileFromClientToServer["Compress"] = ExpressionConverter.ConvertO(copyFileFromClientToServercompress);
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
        public IWorkflowAction ReplaceVariableDataInINIFile(Expression<Func<string>> replaceVariableDataInINIFileinputFilename, Expression<Func<string>> replaceVariableDataInINIFileworkflow, Expression<Func<string>> replaceVariableDataInINIFileoutputFilename = null, Expression<Func<string>> replaceVariableDataInINIFilesearchSection = null, Expression<Func<string>> replaceVariableDataInINIFilesearchVariable = null, Expression<Func<string>> replaceVariableDataInINIFilereplaceData = null, Expression<Func<string>> replaceVariableDataInINIFileinputFilenameEncoding = null, Expression<Func<bool>> replaceVariableDataInINIFilecreateNewFileIfNotExists = null, Expression<Func<bool>> replaceVariableDataInINIFilewriteSpaceBeforeEquals = null, Expression<Func<bool>> replaceVariableDataInINIFilewriteSpaceAfterEquals = null)
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
                replaceVariableDataInINIFile["CreateNewFileIfNotExists"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFilecreateNewFileIfNotExists);
                replaceVariableDataInINIFilepropCount++;
            }

            if (replaceVariableDataInINIFilewriteSpaceBeforeEquals != null)
            {
                replaceVariableDataInINIFile["WriteSpaceBeforeEquals"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFilewriteSpaceBeforeEquals);
                replaceVariableDataInINIFilepropCount++;
            }

            if (replaceVariableDataInINIFilewriteSpaceAfterEquals != null)
            {
                replaceVariableDataInINIFile["WriteSpaceAfterEquals"] = ExpressionConverter.ConvertO(replaceVariableDataInINIFilewriteSpaceAfterEquals);
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
        public IBodyWorkflowAction<DownloadHTTPFileResponse> DownloadHTTPFile(Expression<Func<string>> downloadHTTPFiledownloadURL, Expression<Func<string>> downloadHTTPFileworkflow, Expression<Func<string>> downloadHTTPFilesaveFilename = null, Expression<Func<bool>> downloadHTTPFileoverwriteExistingFile = null, Expression<Func<bool>> downloadHTTPFilepassthroughAuthentication = null, Expression<Func<string>> downloadHTTPFileuserAgent = null, Expression<Func<string>> downloadHTTPFileaccept = null, Expression<Func<bool>> downloadHTTPFilesupportTLS10 = null, Expression<Func<bool>> downloadHTTPFilesupportTLS11 = null, Expression<Func<bool>> downloadHTTPFilesupportTLS12 = null, Expression<Func<bool>> downloadHTTPFileautoDecompressDeflate = null, Expression<Func<bool>> downloadHTTPFileautoDecompressGZIP = null, Expression<Func<bool>> downloadHTTPFilereturnContentsAsString = null, Expression<Func<downloadHTTPFilereturnContentEncodingInput>> downloadHTTPFilereturnContentEncoding = null)
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
                downloadHTTPFile["OverwriteExistingFile"] = ExpressionConverter.ConvertO(downloadHTTPFileoverwriteExistingFile);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFilepassthroughAuthentication != null)
            {
                downloadHTTPFile["PassthroughAuthentication"] = ExpressionConverter.ConvertO(downloadHTTPFilepassthroughAuthentication);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileuserAgent != null)
            {
                downloadHTTPFile["UserAgent"] = ExpressionConverter.ConvertO(downloadHTTPFileuserAgent);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileaccept != null)
            {
                downloadHTTPFile["Accept"] = ExpressionConverter.ConvertO(downloadHTTPFileaccept);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFilesupportTLS10 != null)
            {
                downloadHTTPFile["SupportTLS10"] = ExpressionConverter.ConvertO(downloadHTTPFilesupportTLS10);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFilesupportTLS11 != null)
            {
                downloadHTTPFile["SupportTLS11"] = ExpressionConverter.ConvertO(downloadHTTPFilesupportTLS11);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFilesupportTLS12 != null)
            {
                downloadHTTPFile["SupportTLS12"] = ExpressionConverter.ConvertO(downloadHTTPFilesupportTLS12);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileautoDecompressDeflate != null)
            {
                downloadHTTPFile["AutoDecompressDeflate"] = ExpressionConverter.ConvertO(downloadHTTPFileautoDecompressDeflate);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFileautoDecompressGZIP != null)
            {
                downloadHTTPFile["AutoDecompressGZIP"] = ExpressionConverter.ConvertO(downloadHTTPFileautoDecompressGZIP);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFilereturnContentsAsString != null)
            {
                downloadHTTPFile["ReturnContentsAsString"] = ExpressionConverter.ConvertO(downloadHTTPFilereturnContentsAsString);
                downloadHTTPFilepropCount++;
            }

            if (downloadHTTPFilereturnContentEncoding != null)
            {
                downloadHTTPFile["ReturnContentEncoding"] = ExpressionConverter.ConvertO(downloadHTTPFilereturnContentEncoding);
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
        public IBodyWorkflowAction<UnZIPFileResponse> UnZIPFile(Expression<Func<string>> unZIPFilezIPFilename, Expression<Func<string>> unZIPFileworkflow, Expression<Func<string>> unZIPFileextractFolder = null, Expression<Func<bool>> unZIPFileextractAllFilesToSingleFolder = null, Expression<Func<string>> unZIPFileincludeFilesRegEx = null, Expression<Func<string>> unZIPFileexcludeFilesRegEx = null)
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
                unZIPFile["ExtractAllFilesToSingleFolder"] = ExpressionConverter.ConvertO(unZIPFileextractAllFilesToSingleFolder);
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
        public IWorkflowAction AddFileToZIP(Expression<Func<string>> addFileToZIPsourceFilenameToAddToZIP, Expression<Func<string>> addFileToZIPoutputZIPFilename, Expression<Func<string>> addFileToZIPworkflow, Expression<Func<string>> addFileToZIPaddFilenameToFolderInZIP = null, Expression<Func<string>> addFileToZIPsourceFilenameToAddToZIPComment = null, Expression<Func<bool>> addFileToZIPcompress = null, Expression<Func<bool>> addFileToZIPaddToExistingZIPFile = null)
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
                addFileToZIP["Compress"] = ExpressionConverter.ConvertO(addFileToZIPcompress);
                addFileToZIPpropCount++;
            }

            if (addFileToZIPaddToExistingZIPFile != null)
            {
                addFileToZIP["AddToExistingZIPFile"] = ExpressionConverter.ConvertO(addFileToZIPaddToExistingZIPFile);
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
        public IBodyWorkflowAction<AddFolderToZIPResponse> AddFolderToZIP(Expression<Func<string>> addFolderToZIPsourceFolderToAddToZIP, Expression<Func<string>> addFolderToZIPoutputZIPFilename, Expression<Func<string>> addFolderToZIPworkflow, Expression<Func<string>> addFolderToZIPaddFilesToFolderInZIP = null, Expression<Func<bool>> addFolderToZIPcompress = null, Expression<Func<bool>> addFolderToZIPaddToExistingZIPFile = null, Expression<Func<bool>> addFolderToZIPincludeSubfolders = null, Expression<Func<string>> addFolderToZIPincludeFilesRegEx = null, Expression<Func<string>> addFolderToZIPexcludeFilesRegEx = null)
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
                addFolderToZIP["Compress"] = ExpressionConverter.ConvertO(addFolderToZIPcompress);
                addFolderToZIPpropCount++;
            }

            if (addFolderToZIPaddToExistingZIPFile != null)
            {
                addFolderToZIP["AddToExistingZIPFile"] = ExpressionConverter.ConvertO(addFolderToZIPaddToExistingZIPFile);
                addFolderToZIPpropCount++;
            }

            if (addFolderToZIPincludeSubfolders != null)
            {
                addFolderToZIP["IncludeSubfolders"] = ExpressionConverter.ConvertO(addFolderToZIPincludeSubfolders);
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
        public IBodyWorkflowAction<GetFileContentsAsBase64Response> GetFileContentsAsBase64(Expression<Func<string>> getFileContentsAsBase64filePath, Expression<Func<string>> getFileContentsAsBase64workflow, Expression<Func<bool>> getFileContentsAsBase64compress = null, Expression<Func<int>> getFileContentsAsBase64maxFileSize = null)
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
                getFileContentsAsBase64["Compress"] = ExpressionConverter.ConvertO(getFileContentsAsBase64compress);
                getFileContentsAsBase64propCount++;
            }

            if (getFileContentsAsBase64maxFileSize != null)
            {
                getFileContentsAsBase64["MaxFileSize"] = ExpressionConverter.ConvertO(getFileContentsAsBase64maxFileSize);
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