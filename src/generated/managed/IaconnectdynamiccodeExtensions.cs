//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Iaconnectdynamiccode
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectdynamiccodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IWorkflowAction ImportAssemblyFromLocalFile(Expression<Func<string>> importAssemblyFromLocalFileLocalAssemblyFilePath, Expression<Func<string>> importAssemblyFromLocalFileAssemblyName, Expression<Func<string>> importAssemblyFromLocalFileWorkflow, Expression<Func<bool>> importAssemblyFromLocalFileCompress = null)
        {
            var apiCallPath = "/DynamicCode/ImportAssemblyFromLocalFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var importAssemblyFromLocalFile = new JObject();
            var importAssemblyFromLocalFilepropCount = 0;
            importAssemblyFromLocalFilepropCount++;
            importAssemblyFromLocalFile["LocalAssemblyFilePath"] = ExpressionConverter.ConvertO(importAssemblyFromLocalFileLocalAssemblyFilePath);
            importAssemblyFromLocalFilepropCount++;
            importAssemblyFromLocalFile["AssemblyName"] = ExpressionConverter.ConvertO(importAssemblyFromLocalFileAssemblyName);
            if (importAssemblyFromLocalFileCompress != null)
            {
                importAssemblyFromLocalFile["Compress"] = ExpressionConverter.ConvertO(importAssemblyFromLocalFileCompress);
                importAssemblyFromLocalFilepropCount++;
            }

            importAssemblyFromLocalFilepropCount++;
            importAssemblyFromLocalFile["Workflow"] = ExpressionConverter.ConvertO(importAssemblyFromLocalFileWorkflow);
            if (importAssemblyFromLocalFilepropCount > 0)
            {
                callPayload.Body = importAssemblyFromLocalFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IWorkflowAction AddAssemblySearchFolder(Expression<Func<string>> addAssemblySearchFolderFolderPath, Expression<Func<string>> addAssemblySearchFolderWorkflow)
        {
            var apiCallPath = "/DynamicCode/AddAssemblySearchFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addAssemblySearchFolder = new JObject();
            var addAssemblySearchFolderpropCount = 0;
            addAssemblySearchFolderpropCount++;
            addAssemblySearchFolder["FolderPath"] = ExpressionConverter.ConvertO(addAssemblySearchFolderFolderPath);
            addAssemblySearchFolderpropCount++;
            addAssemblySearchFolder["Workflow"] = ExpressionConverter.ConvertO(addAssemblySearchFolderWorkflow);
            if (addAssemblySearchFolderpropCount > 0)
            {
                callPayload.Body = addAssemblySearchFolder;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IWorkflowAction ClearAssemblySearchFolders(Expression<Func<string>> clearAssemblySearchFoldersWorkflow)
        {
            var apiCallPath = "/DynamicCode/ClearAssemblySearchFolders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var clearAssemblySearchFolders = new JObject();
            var clearAssemblySearchFolderspropCount = 0;
            clearAssemblySearchFolderspropCount++;
            clearAssemblySearchFolders["Workflow"] = ExpressionConverter.ConvertO(clearAssemblySearchFoldersWorkflow);
            if (clearAssemblySearchFolderspropCount > 0)
            {
                callPayload.Body = clearAssemblySearchFolders;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<IsPowerShellAutomationInstalledResponse> IsPowerShellAutomationInstalled(Expression<Func<string>> isPowerShellAutomationInstalledWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/isPowerShellAutomationInstalled";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isPowerShellAutomationInstalled = new JObject();
            var isPowerShellAutomationInstalledpropCount = 0;
            isPowerShellAutomationInstalledpropCount++;
            isPowerShellAutomationInstalled["Workflow"] = ExpressionConverter.ConvertO(isPowerShellAutomationInstalledWorkflow);
            if (isPowerShellAutomationInstalledpropCount > 0)
            {
                callPayload.Body = isPowerShellAutomationInstalled;
            }

            return new ApiConnectionAction<IsPowerShellAutomationInstalledResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<IsPowerShellModuleInstalledResponse> IsPowerShellModuleInstalled(Expression<Func<string>> isPowerShellModuleInstalledPowerShellModuleName, Expression<Func<string>> isPowerShellModuleInstalledWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/isPowerShellModuleInstalled";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isPowerShellModuleInstalled = new JObject();
            var isPowerShellModuleInstalledpropCount = 0;
            isPowerShellModuleInstalledpropCount++;
            isPowerShellModuleInstalled["PowerShellModuleName"] = ExpressionConverter.ConvertO(isPowerShellModuleInstalledPowerShellModuleName);
            isPowerShellModuleInstalledpropCount++;
            isPowerShellModuleInstalled["Workflow"] = ExpressionConverter.ConvertO(isPowerShellModuleInstalledWorkflow);
            if (isPowerShellModuleInstalledpropCount > 0)
            {
                callPayload.Body = isPowerShellModuleInstalled;
            }

            return new ApiConnectionAction<IsPowerShellModuleInstalledResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RunPowerShellAutomationScriptResponse> RunPowerShellAutomationScript(Expression<Func<string>> runPowerShellAutomationScriptWorkflow, Expression<Func<string>> runPowerShellAutomationScriptPowerShellScriptContents = null, Expression<Func<string>> runPowerShellAutomationScriptComputerName = null, Expression<Func<bool>> runPowerShellAutomationScriptIsNoResultAnError = null, Expression<Func<bool>> runPowerShellAutomationScriptReturnComplexTypes = null, Expression<Func<bool>> runPowerShellAutomationScriptReturnBooleanAsBoolean = null, Expression<Func<bool>> runPowerShellAutomationScriptReturnNumericAsDecimal = null, Expression<Func<bool>> runPowerShellAutomationScriptReturnDateAsDate = null, Expression<Func<string>> runPowerShellAutomationScriptPropertiesToReturnAsCollectionJSON = null, Expression<Func<runPowerShellAutomationScriptAuthenticationMechanismInput>> runPowerShellAutomationScriptAuthenticationMechanism = null, Expression<Func<int>> runPowerShellAutomationScriptConnectionAttempts = null, Expression<Func<string>> runPowerShellAutomationScriptUsername = null, Expression<Func<string>> runPowerShellAutomationScriptPassword = null, Expression<Func<bool>> runPowerShellAutomationScriptRunScriptAsThread = null, Expression<Func<int>> runPowerShellAutomationScriptRetrieveOutputDataFromThreadId = null, Expression<Func<int>> runPowerShellAutomationScriptSecondsToWaitForThread = null, Expression<Func<bool>> runPowerShellAutomationScriptScriptContainsStoredPassword = null, Expression<Func<bool>> runPowerShellAutomationScriptLogVerboseOutput = null, Expression<Func<bool>> runPowerShellAutomationScriptReturnSecureStrings = null, Expression<Func<string>> runPowerShellAutomationScriptPropertyNamesToSerializeJSON = null, Expression<Func<string>> runPowerShellAutomationScriptPropertyTypesToSerializeJSON = null, Expression<Func<runPowerShellAutomationScriptPowerShellCommandParametersInputItem[]>> runPowerShellAutomationScriptPowerShellCommandParameters = null)
        {
            var apiCallPath = "/PowerShellAutomation/RunPowerShellScript";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runPowerShellAutomationScript = new JObject();
            var runPowerShellAutomationScriptpropCount = 0;
            if (runPowerShellAutomationScriptPowerShellScriptContents != null)
            {
                runPowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptPowerShellScriptContents);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptComputerName != null)
            {
                runPowerShellAutomationScript["ComputerName"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptComputerName);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptIsNoResultAnError != null)
            {
                runPowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptIsNoResultAnError);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptReturnComplexTypes != null)
            {
                runPowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptReturnComplexTypes);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptReturnBooleanAsBoolean != null)
            {
                runPowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptReturnBooleanAsBoolean);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptReturnNumericAsDecimal != null)
            {
                runPowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptReturnNumericAsDecimal);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptReturnDateAsDate != null)
            {
                runPowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptReturnDateAsDate);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptPropertiesToReturnAsCollectionJSON != null)
            {
                runPowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptPropertiesToReturnAsCollectionJSON);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptAuthenticationMechanism != null)
            {
                runPowerShellAutomationScript["AuthenticationMechanism"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptAuthenticationMechanism);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptConnectionAttempts != null)
            {
                runPowerShellAutomationScript["ConnectionAttempts"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptConnectionAttempts);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptUsername != null)
            {
                runPowerShellAutomationScript["Username"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptUsername);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptPassword != null)
            {
                runPowerShellAutomationScript["Password"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptPassword);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptRunScriptAsThread != null)
            {
                runPowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptRunScriptAsThread);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptRetrieveOutputDataFromThreadId != null)
            {
                runPowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptRetrieveOutputDataFromThreadId);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptSecondsToWaitForThread != null)
            {
                runPowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptSecondsToWaitForThread);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptScriptContainsStoredPassword != null)
            {
                runPowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptScriptContainsStoredPassword);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptLogVerboseOutput != null)
            {
                runPowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptLogVerboseOutput);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptReturnSecureStrings != null)
            {
                runPowerShellAutomationScript["ReturnSecureStrings"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptReturnSecureStrings);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptPropertyNamesToSerializeJSON != null)
            {
                runPowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptPropertyNamesToSerializeJSON);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptPropertyTypesToSerializeJSON != null)
            {
                runPowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptPropertyTypesToSerializeJSON);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptPowerShellCommandParameters != null)
            {
                runPowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptPowerShellCommandParameters);
                runPowerShellAutomationScriptpropCount++;
            }

            runPowerShellAutomationScriptpropCount++;
            runPowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptWorkflow);
            if (runPowerShellAutomationScriptpropCount > 0)
            {
                callPayload.Body = runPowerShellAutomationScript;
            }

            return new ApiConnectionAction<RunPowerShellAutomationScriptResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetPowerShellVersionResponse> GetPowerShellVersion(Expression<Func<string>> getPowerShellVersionWorkflow, Expression<Func<string>> getPowerShellVersionComputerName = null, Expression<Func<getPowerShellVersionAuthenticationMechanismInput>> getPowerShellVersionAuthenticationMechanism = null, Expression<Func<int>> getPowerShellVersionConnectionAttempts = null)
        {
            var apiCallPath = "/PowerShellAutomation/GetPowerShellVersion";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getPowerShellVersion = new JObject();
            var getPowerShellVersionpropCount = 0;
            if (getPowerShellVersionComputerName != null)
            {
                getPowerShellVersion["ComputerName"] = ExpressionConverter.ConvertO(getPowerShellVersionComputerName);
                getPowerShellVersionpropCount++;
            }

            if (getPowerShellVersionAuthenticationMechanism != null)
            {
                getPowerShellVersion["AuthenticationMechanism"] = ExpressionConverter.ConvertO(getPowerShellVersionAuthenticationMechanism);
                getPowerShellVersionpropCount++;
            }

            if (getPowerShellVersionConnectionAttempts != null)
            {
                getPowerShellVersion["ConnectionAttempts"] = ExpressionConverter.ConvertO(getPowerShellVersionConnectionAttempts);
                getPowerShellVersionpropCount++;
            }

            getPowerShellVersionpropCount++;
            getPowerShellVersion["Workflow"] = ExpressionConverter.ConvertO(getPowerShellVersionWorkflow);
            if (getPowerShellVersionpropCount > 0)
            {
                callPayload.Body = getPowerShellVersion;
            }

            return new ApiConnectionAction<GetPowerShellVersionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexMatchResponse> GetRegexMatch(Expression<Func<string>> getRegexMatchTextToMatch, Expression<Func<string>> getRegexMatchRegex, Expression<Func<int>> getRegexMatchSearchIndex = null, Expression<Func<bool>> getRegexMatchCaseSensitive = null, Expression<Func<int>> getRegexMatchRegexTimeoutInSeconds = null)
        {
            var apiCallPath = "/DynamicCode/GetRegexMatch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRegexMatch = new JObject();
            var getRegexMatchpropCount = 0;
            getRegexMatchpropCount++;
            getRegexMatch["TextToMatch"] = ExpressionConverter.ConvertO(getRegexMatchTextToMatch);
            getRegexMatchpropCount++;
            getRegexMatch["Regex"] = ExpressionConverter.ConvertO(getRegexMatchRegex);
            if (getRegexMatchSearchIndex != null)
            {
                getRegexMatch["SearchIndex"] = ExpressionConverter.ConvertO(getRegexMatchSearchIndex);
                getRegexMatchpropCount++;
            }

            if (getRegexMatchCaseSensitive != null)
            {
                getRegexMatch["CaseSensitive"] = ExpressionConverter.ConvertO(getRegexMatchCaseSensitive);
                getRegexMatchpropCount++;
            }

            if (getRegexMatchRegexTimeoutInSeconds != null)
            {
                getRegexMatch["RegexTimeoutInSeconds"] = ExpressionConverter.ConvertO(getRegexMatchRegexTimeoutInSeconds);
                getRegexMatchpropCount++;
            }

            if (getRegexMatchpropCount > 0)
            {
                callPayload.Body = getRegexMatch;
            }

            return new ApiConnectionAction<GetRegexMatchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexMatchesResponse> GetRegexMatches(Expression<Func<string>> getRegexMatchesTextToMatch, Expression<Func<string>> getRegexMatchesRegex, Expression<Func<int>> getRegexMatchesMaximumMatches = null, Expression<Func<bool>> getRegexMatchesCaseSensitive = null, Expression<Func<bool>> getRegexMatchesTrimResults = null, Expression<Func<bool>> getRegexMatchesRemoveEmptyResults = null, Expression<Func<int>> getRegexMatchesRegexTimeoutInSeconds = null)
        {
            var apiCallPath = "/DynamicCode/GetRegexMatches";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRegexMatches = new JObject();
            var getRegexMatchespropCount = 0;
            getRegexMatchespropCount++;
            getRegexMatches["TextToMatch"] = ExpressionConverter.ConvertO(getRegexMatchesTextToMatch);
            getRegexMatchespropCount++;
            getRegexMatches["Regex"] = ExpressionConverter.ConvertO(getRegexMatchesRegex);
            if (getRegexMatchesMaximumMatches != null)
            {
                getRegexMatches["MaximumMatches"] = ExpressionConverter.ConvertO(getRegexMatchesMaximumMatches);
                getRegexMatchespropCount++;
            }

            if (getRegexMatchesCaseSensitive != null)
            {
                getRegexMatches["CaseSensitive"] = ExpressionConverter.ConvertO(getRegexMatchesCaseSensitive);
                getRegexMatchespropCount++;
            }

            if (getRegexMatchesTrimResults != null)
            {
                getRegexMatches["TrimResults"] = ExpressionConverter.ConvertO(getRegexMatchesTrimResults);
                getRegexMatchespropCount++;
            }

            if (getRegexMatchesRemoveEmptyResults != null)
            {
                getRegexMatches["RemoveEmptyResults"] = ExpressionConverter.ConvertO(getRegexMatchesRemoveEmptyResults);
                getRegexMatchespropCount++;
            }

            if (getRegexMatchesRegexTimeoutInSeconds != null)
            {
                getRegexMatches["RegexTimeoutInSeconds"] = ExpressionConverter.ConvertO(getRegexMatchesRegexTimeoutInSeconds);
                getRegexMatchespropCount++;
            }

            if (getRegexMatchespropCount > 0)
            {
                callPayload.Body = getRegexMatches;
            }

            return new ApiConnectionAction<GetRegexMatchesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexSplitResponse> GetRegexSplit(Expression<Func<string>> getRegexSplitTextToSplit, Expression<Func<string>> getRegexSplitRegex, Expression<Func<bool>> getRegexSplitCaseSensitive = null, Expression<Func<bool>> getRegexSplitTrimResults = null, Expression<Func<bool>> getRegexSplitRemoveEmptyResults = null, Expression<Func<int>> getRegexSplitRegexTimeoutInSeconds = null)
        {
            var apiCallPath = "/DynamicCode/GetRegexSplit";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRegexSplit = new JObject();
            var getRegexSplitpropCount = 0;
            getRegexSplitpropCount++;
            getRegexSplit["TextToSplit"] = ExpressionConverter.ConvertO(getRegexSplitTextToSplit);
            getRegexSplitpropCount++;
            getRegexSplit["Regex"] = ExpressionConverter.ConvertO(getRegexSplitRegex);
            if (getRegexSplitCaseSensitive != null)
            {
                getRegexSplit["CaseSensitive"] = ExpressionConverter.ConvertO(getRegexSplitCaseSensitive);
                getRegexSplitpropCount++;
            }

            if (getRegexSplitTrimResults != null)
            {
                getRegexSplit["TrimResults"] = ExpressionConverter.ConvertO(getRegexSplitTrimResults);
                getRegexSplitpropCount++;
            }

            if (getRegexSplitRemoveEmptyResults != null)
            {
                getRegexSplit["RemoveEmptyResults"] = ExpressionConverter.ConvertO(getRegexSplitRemoveEmptyResults);
                getRegexSplitpropCount++;
            }

            if (getRegexSplitRegexTimeoutInSeconds != null)
            {
                getRegexSplit["RegexTimeoutInSeconds"] = ExpressionConverter.ConvertO(getRegexSplitRegexTimeoutInSeconds);
                getRegexSplitpropCount++;
            }

            if (getRegexSplitpropCount > 0)
            {
                callPayload.Body = getRegexSplit;
            }

            return new ApiConnectionAction<GetRegexSplitResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexGroupMatchesResponse> GetRegexGroupMatches(Expression<Func<string>> getRegexGroupMatchesTextToMatch, Expression<Func<string>> getRegexGroupMatchesRegex, Expression<Func<string[]>> getRegexGroupMatchesGroupsToRetrieve = null, Expression<Func<int>> getRegexGroupMatchesSearchIndex = null, Expression<Func<bool>> getRegexGroupMatchesCaseSensitive = null, Expression<Func<int>> getRegexGroupMatchesRegexTimeoutInSeconds = null)
        {
            var apiCallPath = "/DynamicCode/GetRegexGroupMatches";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRegexGroupMatches = new JObject();
            var getRegexGroupMatchespropCount = 0;
            getRegexGroupMatchespropCount++;
            getRegexGroupMatches["TextToMatch"] = ExpressionConverter.ConvertO(getRegexGroupMatchesTextToMatch);
            getRegexGroupMatchespropCount++;
            getRegexGroupMatches["Regex"] = ExpressionConverter.ConvertO(getRegexGroupMatchesRegex);
            if (getRegexGroupMatchesGroupsToRetrieve != null)
            {
                getRegexGroupMatches["GroupsToRetrieve"] = ExpressionConverter.ConvertO(getRegexGroupMatchesGroupsToRetrieve);
                getRegexGroupMatchespropCount++;
            }

            if (getRegexGroupMatchesSearchIndex != null)
            {
                getRegexGroupMatches["SearchIndex"] = ExpressionConverter.ConvertO(getRegexGroupMatchesSearchIndex);
                getRegexGroupMatchespropCount++;
            }

            if (getRegexGroupMatchesCaseSensitive != null)
            {
                getRegexGroupMatches["CaseSensitive"] = ExpressionConverter.ConvertO(getRegexGroupMatchesCaseSensitive);
                getRegexGroupMatchespropCount++;
            }

            if (getRegexGroupMatchesRegexTimeoutInSeconds != null)
            {
                getRegexGroupMatches["RegexTimeoutInSeconds"] = ExpressionConverter.ConvertO(getRegexGroupMatchesRegexTimeoutInSeconds);
                getRegexGroupMatchespropCount++;
            }

            if (getRegexGroupMatchespropCount > 0)
            {
                callPayload.Body = getRegexGroupMatches;
            }

            return new ApiConnectionAction<GetRegexGroupMatchesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<CreateJSONFromInputVariablesResponse> CreateJSONFromInputVariables(Expression<Func<createJSONFromInputVariablesInputVariablesInputItem[]>> createJSONFromInputVariablesInputVariables, Expression<Func<bool>> createJSONFromInputVariablesReturnAsJSONTable)
        {
            var apiCallPath = "/DynamicCode/CreateJSONFromInputVariables";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var createJSONFromInputVariables = new JObject();
            var createJSONFromInputVariablespropCount = 0;
            createJSONFromInputVariablespropCount++;
            createJSONFromInputVariables["InputVariables"] = ExpressionConverter.ConvertO(createJSONFromInputVariablesInputVariables);
            createJSONFromInputVariablespropCount++;
            createJSONFromInputVariables["ReturnAsJSONTable"] = ExpressionConverter.ConvertO(createJSONFromInputVariablesReturnAsJSONTable);
            if (createJSONFromInputVariablespropCount > 0)
            {
                callPayload.Body = createJSONFromInputVariables;
            }

            return new ApiConnectionAction<CreateJSONFromInputVariablesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetJSONTableFromStringArrayResponse> GetJSONTableFromStringArray(Expression<Func<string[]>> getJSONTableFromStringArrayInputArray, Expression<Func<string>> getJSONTableFromStringArrayColumnName, Expression<Func<bool>> getJSONTableFromStringArrayDropEmptyItems = null)
        {
            var apiCallPath = "/DynamicCode/GetJSONTableFromStringArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getJSONTableFromStringArray = new JObject();
            var getJSONTableFromStringArraypropCount = 0;
            getJSONTableFromStringArraypropCount++;
            getJSONTableFromStringArray["InputArray"] = ExpressionConverter.ConvertO(getJSONTableFromStringArrayInputArray);
            getJSONTableFromStringArraypropCount++;
            getJSONTableFromStringArray["ColumnName"] = ExpressionConverter.ConvertO(getJSONTableFromStringArrayColumnName);
            if (getJSONTableFromStringArrayDropEmptyItems != null)
            {
                getJSONTableFromStringArray["DropEmptyItems"] = ExpressionConverter.ConvertO(getJSONTableFromStringArrayDropEmptyItems);
                getJSONTableFromStringArraypropCount++;
            }

            if (getJSONTableFromStringArraypropCount > 0)
            {
                callPayload.Body = getJSONTableFromStringArray;
            }

            return new ApiConnectionAction<GetJSONTableFromStringArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<FilterJSONTableResponse> FilterJSONTable(Expression<Func<string>> filterJSONTableJSONTable, Expression<Func<string>> filterJSONTableFilter, Expression<Func<string>> filterJSONTableSortColumnName = null, Expression<Func<bool>> filterJSONTableAscending = null, Expression<Func<string>> filterJSONTableSortColumnName2 = null, Expression<Func<bool>> filterJSONTableAscending2 = null, Expression<Func<string>> filterJSONTableSortColumnName3 = null, Expression<Func<bool>> filterJSONTableAscending3 = null)
        {
            var apiCallPath = "/DynamicCode/FilterJSONTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var filterJSONTable = new JObject();
            var filterJSONTablepropCount = 0;
            filterJSONTablepropCount++;
            filterJSONTable["JSONTable"] = ExpressionConverter.ConvertO(filterJSONTableJSONTable);
            filterJSONTablepropCount++;
            filterJSONTable["Filter"] = ExpressionConverter.ConvertO(filterJSONTableFilter);
            if (filterJSONTableSortColumnName != null)
            {
                filterJSONTable["SortColumnName"] = ExpressionConverter.ConvertO(filterJSONTableSortColumnName);
                filterJSONTablepropCount++;
            }

            if (filterJSONTableAscending != null)
            {
                filterJSONTable["Ascending"] = ExpressionConverter.ConvertO(filterJSONTableAscending);
                filterJSONTablepropCount++;
            }

            if (filterJSONTableSortColumnName2 != null)
            {
                filterJSONTable["SortColumnName2"] = ExpressionConverter.ConvertO(filterJSONTableSortColumnName2);
                filterJSONTablepropCount++;
            }

            if (filterJSONTableAscending2 != null)
            {
                filterJSONTable["Ascending2"] = ExpressionConverter.ConvertO(filterJSONTableAscending2);
                filterJSONTablepropCount++;
            }

            if (filterJSONTableSortColumnName3 != null)
            {
                filterJSONTable["SortColumnName3"] = ExpressionConverter.ConvertO(filterJSONTableSortColumnName3);
                filterJSONTablepropCount++;
            }

            if (filterJSONTableAscending3 != null)
            {
                filterJSONTable["Ascending3"] = ExpressionConverter.ConvertO(filterJSONTableAscending3);
                filterJSONTablepropCount++;
            }

            if (filterJSONTablepropCount > 0)
            {
                callPayload.Body = filterJSONTable;
            }

            return new ApiConnectionAction<FilterJSONTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<FilterTableResponse> FilterTable(Expression<Func<JToken[]>> filterTableInputTable, Expression<Func<string>> filterTableFilter, Expression<Func<string>> filterTableSortColumnName = null, Expression<Func<bool>> filterTableAscending = null, Expression<Func<string>> filterTableSortColumnName2 = null, Expression<Func<bool>> filterTableAscending2 = null, Expression<Func<string>> filterTableSortColumnName3 = null, Expression<Func<bool>> filterTableAscending3 = null)
        {
            var apiCallPath = "/DynamicCode/FilterTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var filterTable = new JObject();
            var filterTablepropCount = 0;
            filterTablepropCount++;
            filterTable["InputTable"] = ExpressionConverter.ConvertO(filterTableInputTable);
            filterTablepropCount++;
            filterTable["Filter"] = ExpressionConverter.ConvertO(filterTableFilter);
            if (filterTableSortColumnName != null)
            {
                filterTable["SortColumnName"] = ExpressionConverter.ConvertO(filterTableSortColumnName);
                filterTablepropCount++;
            }

            if (filterTableAscending != null)
            {
                filterTable["Ascending"] = ExpressionConverter.ConvertO(filterTableAscending);
                filterTablepropCount++;
            }

            if (filterTableSortColumnName2 != null)
            {
                filterTable["SortColumnName2"] = ExpressionConverter.ConvertO(filterTableSortColumnName2);
                filterTablepropCount++;
            }

            if (filterTableAscending2 != null)
            {
                filterTable["Ascending2"] = ExpressionConverter.ConvertO(filterTableAscending2);
                filterTablepropCount++;
            }

            if (filterTableSortColumnName3 != null)
            {
                filterTable["SortColumnName3"] = ExpressionConverter.ConvertO(filterTableSortColumnName3);
                filterTablepropCount++;
            }

            if (filterTableAscending3 != null)
            {
                filterTable["Ascending3"] = ExpressionConverter.ConvertO(filterTableAscending3);
                filterTablepropCount++;
            }

            if (filterTablepropCount > 0)
            {
                callPayload.Body = filterTable;
            }

            return new ApiConnectionAction<FilterTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<SortTableResponse> SortTable(Expression<Func<JToken[]>> sortTableInputTable, Expression<Func<string>> sortTableSortColumnName, Expression<Func<bool>> sortTableAscending, Expression<Func<string>> sortTableSortColumnName2 = null, Expression<Func<bool>> sortTableAscending2 = null, Expression<Func<string>> sortTableSortColumnName3 = null, Expression<Func<bool>> sortTableAscending3 = null)
        {
            var apiCallPath = "/DynamicCode/SortTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sortTable = new JObject();
            var sortTablepropCount = 0;
            sortTablepropCount++;
            sortTable["InputTable"] = ExpressionConverter.ConvertO(sortTableInputTable);
            sortTablepropCount++;
            sortTable["SortColumnName"] = ExpressionConverter.ConvertO(sortTableSortColumnName);
            sortTablepropCount++;
            sortTable["Ascending"] = ExpressionConverter.ConvertO(sortTableAscending);
            if (sortTableSortColumnName2 != null)
            {
                sortTable["SortColumnName2"] = ExpressionConverter.ConvertO(sortTableSortColumnName2);
                sortTablepropCount++;
            }

            if (sortTableAscending2 != null)
            {
                sortTable["Ascending2"] = ExpressionConverter.ConvertO(sortTableAscending2);
                sortTablepropCount++;
            }

            if (sortTableSortColumnName3 != null)
            {
                sortTable["SortColumnName3"] = ExpressionConverter.ConvertO(sortTableSortColumnName3);
                sortTablepropCount++;
            }

            if (sortTableAscending3 != null)
            {
                sortTable["Ascending3"] = ExpressionConverter.ConvertO(sortTableAscending3);
                sortTablepropCount++;
            }

            if (sortTablepropCount > 0)
            {
                callPayload.Body = sortTable;
            }

            return new ApiConnectionAction<SortTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<SortJSONTableResponse> SortJSONTable(Expression<Func<string>> sortJSONTableJSONTable, Expression<Func<string>> sortJSONTableSortColumnName, Expression<Func<bool>> sortJSONTableAscending = null, Expression<Func<string>> sortJSONTableSortColumnName2 = null, Expression<Func<bool>> sortJSONTableAscending2 = null, Expression<Func<string>> sortJSONTableSortColumnName3 = null, Expression<Func<bool>> sortJSONTableAscending3 = null)
        {
            var apiCallPath = "/DynamicCode/SortJSONTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sortJSONTable = new JObject();
            var sortJSONTablepropCount = 0;
            sortJSONTablepropCount++;
            sortJSONTable["JSONTable"] = ExpressionConverter.ConvertO(sortJSONTableJSONTable);
            sortJSONTablepropCount++;
            sortJSONTable["SortColumnName"] = ExpressionConverter.ConvertO(sortJSONTableSortColumnName);
            if (sortJSONTableAscending != null)
            {
                sortJSONTable["Ascending"] = ExpressionConverter.ConvertO(sortJSONTableAscending);
                sortJSONTablepropCount++;
            }

            if (sortJSONTableSortColumnName2 != null)
            {
                sortJSONTable["SortColumnName2"] = ExpressionConverter.ConvertO(sortJSONTableSortColumnName2);
                sortJSONTablepropCount++;
            }

            if (sortJSONTableAscending2 != null)
            {
                sortJSONTable["Ascending2"] = ExpressionConverter.ConvertO(sortJSONTableAscending2);
                sortJSONTablepropCount++;
            }

            if (sortJSONTableSortColumnName3 != null)
            {
                sortJSONTable["SortColumnName3"] = ExpressionConverter.ConvertO(sortJSONTableSortColumnName3);
                sortJSONTablepropCount++;
            }

            if (sortJSONTableAscending3 != null)
            {
                sortJSONTable["Ascending3"] = ExpressionConverter.ConvertO(sortJSONTableAscending3);
                sortJSONTablepropCount++;
            }

            if (sortJSONTablepropCount > 0)
            {
                callPayload.Body = sortJSONTable;
            }

            return new ApiConnectionAction<SortJSONTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetTableFromStringArrayResponse> GetTableFromStringArray(Expression<Func<string[]>> getTableFromStringArrayInputArray, Expression<Func<string>> getTableFromStringArrayColumnName, Expression<Func<bool>> getTableFromStringArrayDropEmptyItems = null)
        {
            var apiCallPath = "/DynamicCode/GetTableFromStringArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getTableFromStringArray = new JObject();
            var getTableFromStringArraypropCount = 0;
            getTableFromStringArraypropCount++;
            getTableFromStringArray["InputArray"] = ExpressionConverter.ConvertO(getTableFromStringArrayInputArray);
            getTableFromStringArraypropCount++;
            getTableFromStringArray["ColumnName"] = ExpressionConverter.ConvertO(getTableFromStringArrayColumnName);
            if (getTableFromStringArrayDropEmptyItems != null)
            {
                getTableFromStringArray["DropEmptyItems"] = ExpressionConverter.ConvertO(getTableFromStringArrayDropEmptyItems);
                getTableFromStringArraypropCount++;
            }

            if (getTableFromStringArraypropCount > 0)
            {
                callPayload.Body = getTableFromStringArray;
            }

            return new ApiConnectionAction<GetTableFromStringArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetTableFromJSONResponse> GetTableFromJSON(Expression<Func<string>> getTableFromJSONJSONTable, Expression<Func<int>> getTableFromJSONStartRowIndex, Expression<Func<int>> getTableFromJSONNumberOfRowsToRetrieve = null, Expression<Func<int>> getTableFromJSONStartColumnIndex = null, Expression<Func<string>> getTableFromJSONStartColumnName = null, Expression<Func<int>> getTableFromJSONNumberOfColumnsToRetrieve = null)
        {
            var apiCallPath = "/DynamicCode/GetTableFromJSON";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getTableFromJSON = new JObject();
            var getTableFromJSONpropCount = 0;
            getTableFromJSONpropCount++;
            getTableFromJSON["JSONTable"] = ExpressionConverter.ConvertO(getTableFromJSONJSONTable);
            getTableFromJSONpropCount++;
            getTableFromJSON["StartRowIndex"] = ExpressionConverter.ConvertO(getTableFromJSONStartRowIndex);
            if (getTableFromJSONNumberOfRowsToRetrieve != null)
            {
                getTableFromJSON["NumberOfRowsToRetrieve"] = ExpressionConverter.ConvertO(getTableFromJSONNumberOfRowsToRetrieve);
                getTableFromJSONpropCount++;
            }

            if (getTableFromJSONStartColumnIndex != null)
            {
                getTableFromJSON["StartColumnIndex"] = ExpressionConverter.ConvertO(getTableFromJSONStartColumnIndex);
                getTableFromJSONpropCount++;
            }

            if (getTableFromJSONStartColumnName != null)
            {
                getTableFromJSON["StartColumnName"] = ExpressionConverter.ConvertO(getTableFromJSONStartColumnName);
                getTableFromJSONpropCount++;
            }

            if (getTableFromJSONNumberOfColumnsToRetrieve != null)
            {
                getTableFromJSON["NumberOfColumnsToRetrieve"] = ExpressionConverter.ConvertO(getTableFromJSONNumberOfColumnsToRetrieve);
                getTableFromJSONpropCount++;
            }

            if (getTableFromJSONpropCount > 0)
            {
                callPayload.Body = getTableFromJSON;
            }

            return new ApiConnectionAction<GetTableFromJSONResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<SortStringArrayResponse> SortStringArray(Expression<Func<string[]>> sortStringArrayInputArray, Expression<Func<bool>> sortStringArrayAscending = null, Expression<Func<bool>> sortStringArrayCaseSensitive = null)
        {
            var apiCallPath = "/DynamicCode/SortStringArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sortStringArray = new JObject();
            var sortStringArraypropCount = 0;
            sortStringArraypropCount++;
            sortStringArray["InputArray"] = ExpressionConverter.ConvertO(sortStringArrayInputArray);
            if (sortStringArrayAscending != null)
            {
                sortStringArray["Ascending"] = ExpressionConverter.ConvertO(sortStringArrayAscending);
                sortStringArraypropCount++;
            }

            if (sortStringArrayCaseSensitive != null)
            {
                sortStringArray["CaseSensitive"] = ExpressionConverter.ConvertO(sortStringArrayCaseSensitive);
                sortStringArraypropCount++;
            }

            if (sortStringArraypropCount > 0)
            {
                callPayload.Body = sortStringArray;
            }

            return new ApiConnectionAction<SortStringArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<FilterStringArrayResponse> FilterStringArray(Expression<Func<string[]>> filterStringArrayInputArray, Expression<Func<string>> filterStringArrayColumnName, Expression<Func<string>> filterStringArrayFilter)
        {
            var apiCallPath = "/DynamicCode/FilterStringArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var filterStringArray = new JObject();
            var filterStringArraypropCount = 0;
            filterStringArraypropCount++;
            filterStringArray["InputArray"] = ExpressionConverter.ConvertO(filterStringArrayInputArray);
            filterStringArraypropCount++;
            filterStringArray["ColumnName"] = ExpressionConverter.ConvertO(filterStringArrayColumnName);
            filterStringArraypropCount++;
            filterStringArray["Filter"] = ExpressionConverter.ConvertO(filterStringArrayFilter);
            if (filterStringArraypropCount > 0)
            {
                callPayload.Body = filterStringArray;
            }

            return new ApiConnectionAction<FilterStringArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInStringArrayResponse> InsertRowInStringArray(Expression<Func<string[]>> insertRowInStringArrayInputArray, Expression<Func<int>> insertRowInStringArrayRowIndex, Expression<Func<string>> insertRowInStringArrayValueToInsert = null)
        {
            var apiCallPath = "/DynamicCode/InsertRowInStringArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var insertRowInStringArray = new JObject();
            var insertRowInStringArraypropCount = 0;
            insertRowInStringArraypropCount++;
            insertRowInStringArray["InputArray"] = ExpressionConverter.ConvertO(insertRowInStringArrayInputArray);
            insertRowInStringArraypropCount++;
            insertRowInStringArray["RowIndex"] = ExpressionConverter.ConvertO(insertRowInStringArrayRowIndex);
            if (insertRowInStringArrayValueToInsert != null)
            {
                insertRowInStringArray["ValueToInsert"] = ExpressionConverter.ConvertO(insertRowInStringArrayValueToInsert);
                insertRowInStringArraypropCount++;
            }

            if (insertRowInStringArraypropCount > 0)
            {
                callPayload.Body = insertRowInStringArray;
            }

            return new ApiConnectionAction<InsertRowInStringArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInTableResponse> InsertRowInTable(Expression<Func<JToken[]>> insertRowInTableInputTable, Expression<Func<int>> insertRowInTableRowIndex, Expression<Func<string>> insertRowInTableRowToInsertJSON = null)
        {
            var apiCallPath = "/DynamicCode/InsertRowInTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var insertRowInTable = new JObject();
            var insertRowInTablepropCount = 0;
            insertRowInTablepropCount++;
            insertRowInTable["InputTable"] = ExpressionConverter.ConvertO(insertRowInTableInputTable);
            insertRowInTablepropCount++;
            insertRowInTable["RowIndex"] = ExpressionConverter.ConvertO(insertRowInTableRowIndex);
            if (insertRowInTableRowToInsertJSON != null)
            {
                insertRowInTable["RowToInsertJSON"] = ExpressionConverter.ConvertO(insertRowInTableRowToInsertJSON);
                insertRowInTablepropCount++;
            }

            if (insertRowInTablepropCount > 0)
            {
                callPayload.Body = insertRowInTable;
            }

            return new ApiConnectionAction<InsertRowInTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInJSONTableResponse> InsertRowInJSONTable(Expression<Func<string>> insertRowInJSONTableJSONTable, Expression<Func<int>> insertRowInJSONTableRowIndex, Expression<Func<string>> insertRowInJSONTableRowToInsertJSON = null)
        {
            var apiCallPath = "/DynamicCode/InsertRowInJSONTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var insertRowInJSONTable = new JObject();
            var insertRowInJSONTablepropCount = 0;
            insertRowInJSONTablepropCount++;
            insertRowInJSONTable["JSONTable"] = ExpressionConverter.ConvertO(insertRowInJSONTableJSONTable);
            insertRowInJSONTablepropCount++;
            insertRowInJSONTable["RowIndex"] = ExpressionConverter.ConvertO(insertRowInJSONTableRowIndex);
            if (insertRowInJSONTableRowToInsertJSON != null)
            {
                insertRowInJSONTable["RowToInsertJSON"] = ExpressionConverter.ConvertO(insertRowInJSONTableRowToInsertJSON);
                insertRowInJSONTablepropCount++;
            }

            if (insertRowInJSONTablepropCount > 0)
            {
                callPayload.Body = insertRowInJSONTable;
            }

            return new ApiConnectionAction<InsertRowInJSONTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInJSONTableFromInputVariablesResponse> InsertRowInJSONTableFromInputVariables(Expression<Func<string>> insertRowInJSONTableFromInputVariablesJSONTable, Expression<Func<int>> insertRowInJSONTableFromInputVariablesRowIndex, Expression<Func<insertRowInJSONTableFromInputVariablesRowToInsertInputVariablesInputItem[]>> insertRowInJSONTableFromInputVariablesRowToInsertInputVariables)
        {
            var apiCallPath = "/DynamicCode/InsertRowInJSONTableFromInputVariables";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var insertRowInJSONTableFromInputVariables = new JObject();
            var insertRowInJSONTableFromInputVariablespropCount = 0;
            insertRowInJSONTableFromInputVariablespropCount++;
            insertRowInJSONTableFromInputVariables["JSONTable"] = ExpressionConverter.ConvertO(insertRowInJSONTableFromInputVariablesJSONTable);
            insertRowInJSONTableFromInputVariablespropCount++;
            insertRowInJSONTableFromInputVariables["RowIndex"] = ExpressionConverter.ConvertO(insertRowInJSONTableFromInputVariablesRowIndex);
            insertRowInJSONTableFromInputVariablespropCount++;
            insertRowInJSONTableFromInputVariables["RowToInsertInputVariables"] = ExpressionConverter.ConvertO(insertRowInJSONTableFromInputVariablesRowToInsertInputVariables);
            if (insertRowInJSONTableFromInputVariablespropCount > 0)
            {
                callPayload.Body = insertRowInJSONTableFromInputVariables;
            }

            return new ApiConnectionAction<InsertRowInJSONTableFromInputVariablesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteItemsInStringArrayResponse> DeleteItemsInStringArray(Expression<Func<string[]>> deleteItemsInStringArrayInputArray, Expression<Func<int>> deleteItemsInStringArrayStartItemIndex, Expression<Func<int>> deleteItemsInStringArrayNumberOfItemsToDelete)
        {
            var apiCallPath = "/DynamicCode/DeleteItemsInStringArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteItemsInStringArray = new JObject();
            var deleteItemsInStringArraypropCount = 0;
            deleteItemsInStringArraypropCount++;
            deleteItemsInStringArray["InputArray"] = ExpressionConverter.ConvertO(deleteItemsInStringArrayInputArray);
            deleteItemsInStringArraypropCount++;
            deleteItemsInStringArray["StartItemIndex"] = ExpressionConverter.ConvertO(deleteItemsInStringArrayStartItemIndex);
            deleteItemsInStringArraypropCount++;
            deleteItemsInStringArray["NumberOfItemsToDelete"] = ExpressionConverter.ConvertO(deleteItemsInStringArrayNumberOfItemsToDelete);
            if (deleteItemsInStringArraypropCount > 0)
            {
                callPayload.Body = deleteItemsInStringArray;
            }

            return new ApiConnectionAction<DeleteItemsInStringArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteRowsInTableResponse> DeleteRowsInTable(Expression<Func<JToken[]>> deleteRowsInTableInputTable, Expression<Func<int>> deleteRowsInTableStartRowIndex, Expression<Func<int>> deleteRowsInTableNumberOfRowsToDelete)
        {
            var apiCallPath = "/DynamicCode/DeleteRowsInTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteRowsInTable = new JObject();
            var deleteRowsInTablepropCount = 0;
            deleteRowsInTablepropCount++;
            deleteRowsInTable["InputTable"] = ExpressionConverter.ConvertO(deleteRowsInTableInputTable);
            deleteRowsInTablepropCount++;
            deleteRowsInTable["StartRowIndex"] = ExpressionConverter.ConvertO(deleteRowsInTableStartRowIndex);
            deleteRowsInTablepropCount++;
            deleteRowsInTable["NumberOfRowsToDelete"] = ExpressionConverter.ConvertO(deleteRowsInTableNumberOfRowsToDelete);
            if (deleteRowsInTablepropCount > 0)
            {
                callPayload.Body = deleteRowsInTable;
            }

            return new ApiConnectionAction<DeleteRowsInTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteRowsInJSONTableResponse> DeleteRowsInJSONTable(Expression<Func<string>> deleteRowsInJSONTableJSONTable, Expression<Func<int>> deleteRowsInJSONTableStartRowIndex, Expression<Func<int>> deleteRowsInJSONTableNumberOfRowsToDelete)
        {
            var apiCallPath = "/DynamicCode/DeleteRowsInJSONTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteRowsInJSONTable = new JObject();
            var deleteRowsInJSONTablepropCount = 0;
            deleteRowsInJSONTablepropCount++;
            deleteRowsInJSONTable["JSONTable"] = ExpressionConverter.ConvertO(deleteRowsInJSONTableJSONTable);
            deleteRowsInJSONTablepropCount++;
            deleteRowsInJSONTable["StartRowIndex"] = ExpressionConverter.ConvertO(deleteRowsInJSONTableStartRowIndex);
            deleteRowsInJSONTablepropCount++;
            deleteRowsInJSONTable["NumberOfRowsToDelete"] = ExpressionConverter.ConvertO(deleteRowsInJSONTableNumberOfRowsToDelete);
            if (deleteRowsInJSONTablepropCount > 0)
            {
                callPayload.Body = deleteRowsInJSONTable;
            }

            return new ApiConnectionAction<DeleteRowsInJSONTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RenameColumnInTableResponse> RenameColumnInTable(Expression<Func<JToken[]>> renameColumnInTableInputTable, Expression<Func<string>> renameColumnInTableSourceColumnName, Expression<Func<string>> renameColumnInTableNewColumnName)
        {
            var apiCallPath = "/DynamicCode/RenameColumnInTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var renameColumnInTable = new JObject();
            var renameColumnInTablepropCount = 0;
            renameColumnInTablepropCount++;
            renameColumnInTable["InputTable"] = ExpressionConverter.ConvertO(renameColumnInTableInputTable);
            renameColumnInTablepropCount++;
            renameColumnInTable["SourceColumnName"] = ExpressionConverter.ConvertO(renameColumnInTableSourceColumnName);
            renameColumnInTablepropCount++;
            renameColumnInTable["NewColumnName"] = ExpressionConverter.ConvertO(renameColumnInTableNewColumnName);
            if (renameColumnInTablepropCount > 0)
            {
                callPayload.Body = renameColumnInTable;
            }

            return new ApiConnectionAction<RenameColumnInTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RenameColumnInJSONTableResponse> RenameColumnInJSONTable(Expression<Func<string>> renameColumnInJSONTableJSONTable, Expression<Func<string>> renameColumnInJSONTableSourceColumnName, Expression<Func<string>> renameColumnInJSONTableNewColumnName)
        {
            var apiCallPath = "/DynamicCode/RenameColumnInJSONTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var renameColumnInJSONTable = new JObject();
            var renameColumnInJSONTablepropCount = 0;
            renameColumnInJSONTablepropCount++;
            renameColumnInJSONTable["JSONTable"] = ExpressionConverter.ConvertO(renameColumnInJSONTableJSONTable);
            renameColumnInJSONTablepropCount++;
            renameColumnInJSONTable["SourceColumnName"] = ExpressionConverter.ConvertO(renameColumnInJSONTableSourceColumnName);
            renameColumnInJSONTablepropCount++;
            renameColumnInJSONTable["NewColumnName"] = ExpressionConverter.ConvertO(renameColumnInJSONTableNewColumnName);
            if (renameColumnInJSONTablepropCount > 0)
            {
                callPayload.Body = renameColumnInJSONTable;
            }

            return new ApiConnectionAction<RenameColumnInJSONTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteColumnsInTableResponse> DeleteColumnsInTable(Expression<Func<JToken[]>> deleteColumnsInTableInputTable, Expression<Func<int>> deleteColumnsInTableNumberOfColumnsToDelete, Expression<Func<int>> deleteColumnsInTableStartColumnIndex = null, Expression<Func<string>> deleteColumnsInTableColumnNameToDelete = null)
        {
            var apiCallPath = "/DynamicCode/DeleteColumnsInTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteColumnsInTable = new JObject();
            var deleteColumnsInTablepropCount = 0;
            deleteColumnsInTablepropCount++;
            deleteColumnsInTable["InputTable"] = ExpressionConverter.ConvertO(deleteColumnsInTableInputTable);
            if (deleteColumnsInTableStartColumnIndex != null)
            {
                deleteColumnsInTable["StartColumnIndex"] = ExpressionConverter.ConvertO(deleteColumnsInTableStartColumnIndex);
                deleteColumnsInTablepropCount++;
            }

            if (deleteColumnsInTableColumnNameToDelete != null)
            {
                deleteColumnsInTable["ColumnNameToDelete"] = ExpressionConverter.ConvertO(deleteColumnsInTableColumnNameToDelete);
                deleteColumnsInTablepropCount++;
            }

            deleteColumnsInTablepropCount++;
            deleteColumnsInTable["NumberOfColumnsToDelete"] = ExpressionConverter.ConvertO(deleteColumnsInTableNumberOfColumnsToDelete);
            if (deleteColumnsInTablepropCount > 0)
            {
                callPayload.Body = deleteColumnsInTable;
            }

            return new ApiConnectionAction<DeleteColumnsInTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteColumnsInJSONTableResponse> DeleteColumnsInJSONTable(Expression<Func<string>> deleteColumnsInJSONTableJSONTable, Expression<Func<int>> deleteColumnsInJSONTableNumberOfColumnsToDelete, Expression<Func<int>> deleteColumnsInJSONTableStartColumnIndex = null, Expression<Func<string>> deleteColumnsInJSONTableColumnNameToDelete = null)
        {
            var apiCallPath = "/DynamicCode/DeleteColumnsInJSONTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteColumnsInJSONTable = new JObject();
            var deleteColumnsInJSONTablepropCount = 0;
            deleteColumnsInJSONTablepropCount++;
            deleteColumnsInJSONTable["JSONTable"] = ExpressionConverter.ConvertO(deleteColumnsInJSONTableJSONTable);
            if (deleteColumnsInJSONTableStartColumnIndex != null)
            {
                deleteColumnsInJSONTable["StartColumnIndex"] = ExpressionConverter.ConvertO(deleteColumnsInJSONTableStartColumnIndex);
                deleteColumnsInJSONTablepropCount++;
            }

            if (deleteColumnsInJSONTableColumnNameToDelete != null)
            {
                deleteColumnsInJSONTable["ColumnNameToDelete"] = ExpressionConverter.ConvertO(deleteColumnsInJSONTableColumnNameToDelete);
                deleteColumnsInJSONTablepropCount++;
            }

            deleteColumnsInJSONTablepropCount++;
            deleteColumnsInJSONTable["NumberOfColumnsToDelete"] = ExpressionConverter.ConvertO(deleteColumnsInJSONTableNumberOfColumnsToDelete);
            if (deleteColumnsInJSONTablepropCount > 0)
            {
                callPayload.Body = deleteColumnsInJSONTable;
            }

            return new ApiConnectionAction<DeleteColumnsInJSONTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringArrayFromTableColumnResponse> GetStringArrayFromTableColumn(Expression<Func<JToken[]>> getStringArrayFromTableColumnInputTable, Expression<Func<int>> getStringArrayFromTableColumnColumnIndex = null, Expression<Func<string>> getStringArrayFromTableColumnColumnName = null)
        {
            var apiCallPath = "/DynamicCode/GetStringArrayFromTableColumn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getStringArrayFromTableColumn = new JObject();
            var getStringArrayFromTableColumnpropCount = 0;
            getStringArrayFromTableColumnpropCount++;
            getStringArrayFromTableColumn["InputTable"] = ExpressionConverter.ConvertO(getStringArrayFromTableColumnInputTable);
            if (getStringArrayFromTableColumnColumnIndex != null)
            {
                getStringArrayFromTableColumn["ColumnIndex"] = ExpressionConverter.ConvertO(getStringArrayFromTableColumnColumnIndex);
                getStringArrayFromTableColumnpropCount++;
            }

            if (getStringArrayFromTableColumnColumnName != null)
            {
                getStringArrayFromTableColumn["ColumnName"] = ExpressionConverter.ConvertO(getStringArrayFromTableColumnColumnName);
                getStringArrayFromTableColumnpropCount++;
            }

            if (getStringArrayFromTableColumnpropCount > 0)
            {
                callPayload.Body = getStringArrayFromTableColumn;
            }

            return new ApiConnectionAction<GetStringArrayFromTableColumnResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringArrayFromJSONTableColumnResponse> GetStringArrayFromJSONTableColumn(Expression<Func<string>> getStringArrayFromJSONTableColumnJSONTable, Expression<Func<int>> getStringArrayFromJSONTableColumnColumnIndex = null, Expression<Func<string>> getStringArrayFromJSONTableColumnColumnName = null)
        {
            var apiCallPath = "/DynamicCode/GetStringArrayFromJSONTableColumn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getStringArrayFromJSONTableColumn = new JObject();
            var getStringArrayFromJSONTableColumnpropCount = 0;
            getStringArrayFromJSONTableColumnpropCount++;
            getStringArrayFromJSONTableColumn["JSONTable"] = ExpressionConverter.ConvertO(getStringArrayFromJSONTableColumnJSONTable);
            if (getStringArrayFromJSONTableColumnColumnIndex != null)
            {
                getStringArrayFromJSONTableColumn["ColumnIndex"] = ExpressionConverter.ConvertO(getStringArrayFromJSONTableColumnColumnIndex);
                getStringArrayFromJSONTableColumnpropCount++;
            }

            if (getStringArrayFromJSONTableColumnColumnName != null)
            {
                getStringArrayFromJSONTableColumn["ColumnName"] = ExpressionConverter.ConvertO(getStringArrayFromJSONTableColumnColumnName);
                getStringArrayFromJSONTableColumnpropCount++;
            }

            if (getStringArrayFromJSONTableColumnpropCount > 0)
            {
                callPayload.Body = getStringArrayFromJSONTableColumn;
            }

            return new ApiConnectionAction<GetStringArrayFromJSONTableColumnResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringFromJSONTableCellResponse> GetStringFromJSONTableCell(Expression<Func<string>> getStringFromJSONTableCellJSONTable, Expression<Func<int>> getStringFromJSONTableCellRowIndex = null, Expression<Func<int>> getStringFromJSONTableCellColumnIndex = null, Expression<Func<string>> getStringFromJSONTableCellColumnName = null, Expression<Func<bool>> getStringFromJSONTableCellFallBackIfCellDoesNotExist = null, Expression<Func<string>> getStringFromJSONTableCellFallbackValue = null)
        {
            var apiCallPath = "/DynamicCode/GetStringFromJSONTableCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getStringFromJSONTableCell = new JObject();
            var getStringFromJSONTableCellpropCount = 0;
            getStringFromJSONTableCellpropCount++;
            getStringFromJSONTableCell["JSONTable"] = ExpressionConverter.ConvertO(getStringFromJSONTableCellJSONTable);
            if (getStringFromJSONTableCellRowIndex != null)
            {
                getStringFromJSONTableCell["RowIndex"] = ExpressionConverter.ConvertO(getStringFromJSONTableCellRowIndex);
                getStringFromJSONTableCellpropCount++;
            }

            if (getStringFromJSONTableCellColumnIndex != null)
            {
                getStringFromJSONTableCell["ColumnIndex"] = ExpressionConverter.ConvertO(getStringFromJSONTableCellColumnIndex);
                getStringFromJSONTableCellpropCount++;
            }

            if (getStringFromJSONTableCellColumnName != null)
            {
                getStringFromJSONTableCell["ColumnName"] = ExpressionConverter.ConvertO(getStringFromJSONTableCellColumnName);
                getStringFromJSONTableCellpropCount++;
            }

            if (getStringFromJSONTableCellFallBackIfCellDoesNotExist != null)
            {
                getStringFromJSONTableCell["FallBackIfCellDoesNotExist"] = ExpressionConverter.ConvertO(getStringFromJSONTableCellFallBackIfCellDoesNotExist);
                getStringFromJSONTableCellpropCount++;
            }

            if (getStringFromJSONTableCellFallbackValue != null)
            {
                getStringFromJSONTableCell["FallbackValue"] = ExpressionConverter.ConvertO(getStringFromJSONTableCellFallbackValue);
                getStringFromJSONTableCellpropCount++;
            }

            if (getStringFromJSONTableCellpropCount > 0)
            {
                callPayload.Body = getStringFromJSONTableCell;
            }

            return new ApiConnectionAction<GetStringFromJSONTableCellResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringBetweenResponse> GetStringBetween(Expression<Func<string>> getStringBetweenInputString = null, Expression<Func<string>> getStringBetweenStartSearchString = null, Expression<Func<string>> getStringBetweenEndSearchString = null, Expression<Func<bool>> getStringBetweenSearchLineByLine = null, Expression<Func<bool>> getStringBetweenThrowExceptionIfNotFound = null, Expression<Func<bool>> getStringBetweenTrimResult = null, Expression<Func<bool>> getStringBetweenSearchIsRegularExpression = null, Expression<Func<bool>> getStringBetweenCaseSensitiveSearch = null)
        {
            var apiCallPath = "/DynamicCode/GetStringBetween";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getStringBetween = new JObject();
            var getStringBetweenpropCount = 0;
            if (getStringBetweenInputString != null)
            {
                getStringBetween["InputString"] = ExpressionConverter.ConvertO(getStringBetweenInputString);
                getStringBetweenpropCount++;
            }

            if (getStringBetweenStartSearchString != null)
            {
                getStringBetween["StartSearchString"] = ExpressionConverter.ConvertO(getStringBetweenStartSearchString);
                getStringBetweenpropCount++;
            }

            if (getStringBetweenEndSearchString != null)
            {
                getStringBetween["EndSearchString"] = ExpressionConverter.ConvertO(getStringBetweenEndSearchString);
                getStringBetweenpropCount++;
            }

            if (getStringBetweenSearchLineByLine != null)
            {
                getStringBetween["SearchLineByLine"] = ExpressionConverter.ConvertO(getStringBetweenSearchLineByLine);
                getStringBetweenpropCount++;
            }

            if (getStringBetweenThrowExceptionIfNotFound != null)
            {
                getStringBetween["ThrowExceptionIfNotFound"] = ExpressionConverter.ConvertO(getStringBetweenThrowExceptionIfNotFound);
                getStringBetweenpropCount++;
            }

            if (getStringBetweenTrimResult != null)
            {
                getStringBetween["TrimResult"] = ExpressionConverter.ConvertO(getStringBetweenTrimResult);
                getStringBetweenpropCount++;
            }

            if (getStringBetweenSearchIsRegularExpression != null)
            {
                getStringBetween["SearchIsRegularExpression"] = ExpressionConverter.ConvertO(getStringBetweenSearchIsRegularExpression);
                getStringBetweenpropCount++;
            }

            if (getStringBetweenCaseSensitiveSearch != null)
            {
                getStringBetween["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(getStringBetweenCaseSensitiveSearch);
                getStringBetweenpropCount++;
            }

            if (getStringBetweenpropCount > 0)
            {
                callPayload.Body = getStringBetween;
            }

            return new ApiConnectionAction<GetStringBetweenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LoadIAConnectLookupTableResponse> LoadIAConnectLookupTable(Expression<Func<string>> loadIAConnectLookupTablePath, Expression<Func<bool>> loadIAConnectLookupTableRaiseExceptionIfAnyTableFailsToLoad, Expression<Func<string>> loadIAConnectLookupTableWorkflow)
        {
            var apiCallPath = "/DynamicCode/LoadIAConnectLookupTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var loadIAConnectLookupTable = new JObject();
            var loadIAConnectLookupTablepropCount = 0;
            loadIAConnectLookupTablepropCount++;
            loadIAConnectLookupTable["Path"] = ExpressionConverter.ConvertO(loadIAConnectLookupTablePath);
            loadIAConnectLookupTablepropCount++;
            loadIAConnectLookupTable["RaiseExceptionIfAnyTableFailsToLoad"] = ExpressionConverter.ConvertO(loadIAConnectLookupTableRaiseExceptionIfAnyTableFailsToLoad);
            loadIAConnectLookupTablepropCount++;
            loadIAConnectLookupTable["Workflow"] = ExpressionConverter.ConvertO(loadIAConnectLookupTableWorkflow);
            if (loadIAConnectLookupTablepropCount > 0)
            {
                callPayload.Body = loadIAConnectLookupTable;
            }

            return new ApiConnectionAction<LoadIAConnectLookupTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetIAConnectLookupTableSummaryResponse> GetIAConnectLookupTableSummary(Expression<Func<string>> getIAConnectLookupTableSummaryWorkflow)
        {
            var apiCallPath = "/DynamicCode/GetIAConnectLookupTableSummary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getIAConnectLookupTableSummary = new JObject();
            var getIAConnectLookupTableSummarypropCount = 0;
            getIAConnectLookupTableSummarypropCount++;
            getIAConnectLookupTableSummary["Workflow"] = ExpressionConverter.ConvertO(getIAConnectLookupTableSummaryWorkflow);
            if (getIAConnectLookupTableSummarypropCount > 0)
            {
                callPayload.Body = getIAConnectLookupTableSummary;
            }

            return new ApiConnectionAction<GetIAConnectLookupTableSummaryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveIAConnectLookupTableResponse> RemoveIAConnectLookupTable(Expression<Func<string>> removeIAConnectLookupTableLookupTableName, Expression<Func<string>> removeIAConnectLookupTableWorkflow)
        {
            var apiCallPath = "/DynamicCode/RemoveIAConnectLookupTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var removeIAConnectLookupTable = new JObject();
            var removeIAConnectLookupTablepropCount = 0;
            removeIAConnectLookupTablepropCount++;
            removeIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(removeIAConnectLookupTableLookupTableName);
            removeIAConnectLookupTablepropCount++;
            removeIAConnectLookupTable["Workflow"] = ExpressionConverter.ConvertO(removeIAConnectLookupTableWorkflow);
            if (removeIAConnectLookupTablepropCount > 0)
            {
                callPayload.Body = removeIAConnectLookupTable;
            }

            return new ApiConnectionAction<RemoveIAConnectLookupTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveAllIAConnectLookupTablesResponse> RemoveAllIAConnectLookupTables(Expression<Func<string>> removeAllIAConnectLookupTablesWorkflow)
        {
            var apiCallPath = "/DynamicCode/RemoveAllIAConnectLookupTables";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var removeAllIAConnectLookupTables = new JObject();
            var removeAllIAConnectLookupTablespropCount = 0;
            removeAllIAConnectLookupTablespropCount++;
            removeAllIAConnectLookupTables["Workflow"] = ExpressionConverter.ConvertO(removeAllIAConnectLookupTablesWorkflow);
            if (removeAllIAConnectLookupTablespropCount > 0)
            {
                callPayload.Body = removeAllIAConnectLookupTables;
            }

            return new ApiConnectionAction<RemoveAllIAConnectLookupTablesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LookupValueFromIAConnectLookupTableResponse> LookupValueFromIAConnectLookupTable(Expression<Func<string>> lookupValueFromIAConnectLookupTableLookupTableName, Expression<Func<string>> lookupValueFromIAConnectLookupTableSearchResultValueColumnName, Expression<Func<string>> lookupValueFromIAConnectLookupTableWorkflow, Expression<Func<string>> lookupValueFromIAConnectLookupTableInputDataJSON = null, Expression<Func<int>> lookupValueFromIAConnectLookupTableSearchResultValueColumnIndex = null, Expression<Func<bool>> lookupValueFromIAConnectLookupTableRaiseExceptionIfNoMatch = null)
        {
            var apiCallPath = "/DynamicCode/LookupValueFromIAConnectLookupTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var lookupValueFromIAConnectLookupTable = new JObject();
            var lookupValueFromIAConnectLookupTablepropCount = 0;
            lookupValueFromIAConnectLookupTablepropCount++;
            lookupValueFromIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(lookupValueFromIAConnectLookupTableLookupTableName);
            if (lookupValueFromIAConnectLookupTableInputDataJSON != null)
            {
                lookupValueFromIAConnectLookupTable["InputDataJSON"] = ExpressionConverter.ConvertO(lookupValueFromIAConnectLookupTableInputDataJSON);
                lookupValueFromIAConnectLookupTablepropCount++;
            }

            lookupValueFromIAConnectLookupTablepropCount++;
            lookupValueFromIAConnectLookupTable["SearchResultValueColumnName"] = ExpressionConverter.ConvertO(lookupValueFromIAConnectLookupTableSearchResultValueColumnName);
            if (lookupValueFromIAConnectLookupTableSearchResultValueColumnIndex != null)
            {
                lookupValueFromIAConnectLookupTable["SearchResultValueColumnIndex"] = ExpressionConverter.ConvertO(lookupValueFromIAConnectLookupTableSearchResultValueColumnIndex);
                lookupValueFromIAConnectLookupTablepropCount++;
            }

            if (lookupValueFromIAConnectLookupTableRaiseExceptionIfNoMatch != null)
            {
                lookupValueFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = ExpressionConverter.ConvertO(lookupValueFromIAConnectLookupTableRaiseExceptionIfNoMatch);
                lookupValueFromIAConnectLookupTablepropCount++;
            }

            lookupValueFromIAConnectLookupTablepropCount++;
            lookupValueFromIAConnectLookupTable["Workflow"] = ExpressionConverter.ConvertO(lookupValueFromIAConnectLookupTableWorkflow);
            if (lookupValueFromIAConnectLookupTablepropCount > 0)
            {
                callPayload.Body = lookupValueFromIAConnectLookupTable;
            }

            return new ApiConnectionAction<LookupValueFromIAConnectLookupTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LookupColumnsFromIAConnectLookupTableResponse> LookupColumnsFromIAConnectLookupTable(Expression<Func<string>> lookupColumnsFromIAConnectLookupTableLookupTableName, Expression<Func<string>> lookupColumnsFromIAConnectLookupTableSearchResultTableColumnName, Expression<Func<string>> lookupColumnsFromIAConnectLookupTableWorkflow, Expression<Func<string>> lookupColumnsFromIAConnectLookupTableInputDataJSON = null, Expression<Func<bool>> lookupColumnsFromIAConnectLookupTableRaiseExceptionIfNoMatch = null, Expression<Func<bool>> lookupColumnsFromIAConnectLookupTableReturnBlankCells = null, Expression<Func<lookupColumnsFromIAConnectLookupTableReturnFormatInput>> lookupColumnsFromIAConnectLookupTableReturnFormat = null)
        {
            var apiCallPath = "/DynamicCode/LookupColumnsFromIAConnectLookupTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var lookupColumnsFromIAConnectLookupTable = new JObject();
            var lookupColumnsFromIAConnectLookupTablepropCount = 0;
            lookupColumnsFromIAConnectLookupTablepropCount++;
            lookupColumnsFromIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(lookupColumnsFromIAConnectLookupTableLookupTableName);
            if (lookupColumnsFromIAConnectLookupTableInputDataJSON != null)
            {
                lookupColumnsFromIAConnectLookupTable["InputDataJSON"] = ExpressionConverter.ConvertO(lookupColumnsFromIAConnectLookupTableInputDataJSON);
                lookupColumnsFromIAConnectLookupTablepropCount++;
            }

            lookupColumnsFromIAConnectLookupTablepropCount++;
            lookupColumnsFromIAConnectLookupTable["SearchResultTableColumnName"] = ExpressionConverter.ConvertO(lookupColumnsFromIAConnectLookupTableSearchResultTableColumnName);
            if (lookupColumnsFromIAConnectLookupTableRaiseExceptionIfNoMatch != null)
            {
                lookupColumnsFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = ExpressionConverter.ConvertO(lookupColumnsFromIAConnectLookupTableRaiseExceptionIfNoMatch);
                lookupColumnsFromIAConnectLookupTablepropCount++;
            }

            if (lookupColumnsFromIAConnectLookupTableReturnBlankCells != null)
            {
                lookupColumnsFromIAConnectLookupTable["ReturnBlankCells"] = ExpressionConverter.ConvertO(lookupColumnsFromIAConnectLookupTableReturnBlankCells);
                lookupColumnsFromIAConnectLookupTablepropCount++;
            }

            if (lookupColumnsFromIAConnectLookupTableReturnFormat != null)
            {
                lookupColumnsFromIAConnectLookupTable["ReturnFormat"] = ExpressionConverter.ConvertO(lookupColumnsFromIAConnectLookupTableReturnFormat);
                lookupColumnsFromIAConnectLookupTablepropCount++;
            }

            lookupColumnsFromIAConnectLookupTablepropCount++;
            lookupColumnsFromIAConnectLookupTable["Workflow"] = ExpressionConverter.ConvertO(lookupColumnsFromIAConnectLookupTableWorkflow);
            if (lookupColumnsFromIAConnectLookupTablepropCount > 0)
            {
                callPayload.Body = lookupColumnsFromIAConnectLookupTable;
            }

            return new ApiConnectionAction<LookupColumnsFromIAConnectLookupTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveCharactersFromStringResponse> RemoveCharactersFromString(Expression<Func<string>> removeCharactersFromStringInputString = null, Expression<Func<string>> removeCharactersFromStringCharactersToRemoveFromInputString = null, Expression<Func<bool>> removeCharactersFromStringRemoveDiacriticsFromInputString = null, Expression<Func<bool>> removeCharactersFromStringRemoveNonAlphaNumericFromInputString = null, Expression<Func<bool>> removeCharactersFromStringRemoveNumericFromInputString = null, Expression<Func<bool>> removeCharactersFromStringRemoveLowercaseCharactersFromInputString = null, Expression<Func<bool>> removeCharactersFromStringRemoveUppercaseCharactersFromInputString = null)
        {
            var apiCallPath = "/DynamicCode/RemoveCharactersFromString";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var removeCharactersFromString = new JObject();
            var removeCharactersFromStringpropCount = 0;
            if (removeCharactersFromStringInputString != null)
            {
                removeCharactersFromString["InputString"] = ExpressionConverter.ConvertO(removeCharactersFromStringInputString);
                removeCharactersFromStringpropCount++;
            }

            if (removeCharactersFromStringCharactersToRemoveFromInputString != null)
            {
                removeCharactersFromString["CharactersToRemoveFromInputString"] = ExpressionConverter.ConvertO(removeCharactersFromStringCharactersToRemoveFromInputString);
                removeCharactersFromStringpropCount++;
            }

            if (removeCharactersFromStringRemoveDiacriticsFromInputString != null)
            {
                removeCharactersFromString["RemoveDiacriticsFromInputString"] = ExpressionConverter.ConvertO(removeCharactersFromStringRemoveDiacriticsFromInputString);
                removeCharactersFromStringpropCount++;
            }

            if (removeCharactersFromStringRemoveNonAlphaNumericFromInputString != null)
            {
                removeCharactersFromString["RemoveNonAlphaNumericFromInputString"] = ExpressionConverter.ConvertO(removeCharactersFromStringRemoveNonAlphaNumericFromInputString);
                removeCharactersFromStringpropCount++;
            }

            if (removeCharactersFromStringRemoveNumericFromInputString != null)
            {
                removeCharactersFromString["RemoveNumericFromInputString"] = ExpressionConverter.ConvertO(removeCharactersFromStringRemoveNumericFromInputString);
                removeCharactersFromStringpropCount++;
            }

            if (removeCharactersFromStringRemoveLowercaseCharactersFromInputString != null)
            {
                removeCharactersFromString["RemoveLowercaseCharactersFromInputString"] = ExpressionConverter.ConvertO(removeCharactersFromStringRemoveLowercaseCharactersFromInputString);
                removeCharactersFromStringpropCount++;
            }

            if (removeCharactersFromStringRemoveUppercaseCharactersFromInputString != null)
            {
                removeCharactersFromString["RemoveUppercaseCharactersFromInputString"] = ExpressionConverter.ConvertO(removeCharactersFromStringRemoveUppercaseCharactersFromInputString);
                removeCharactersFromStringpropCount++;
            }

            if (removeCharactersFromStringpropCount > 0)
            {
                callPayload.Body = removeCharactersFromString;
            }

            return new ApiConnectionAction<RemoveCharactersFromStringResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetColumnFromIAConnectListResponse> GetColumnFromIAConnectList(Expression<Func<string>> getColumnFromIAConnectListListName, Expression<Func<int>> getColumnFromIAConnectListSearchColumnIndex = null, Expression<Func<string>> getColumnFromIAConnectListSearchColumnName = null, Expression<Func<bool>> getColumnFromIAConnectListReturnBlankCells = null, Expression<Func<bool>> getColumnFromIAConnectListFallBackIfListDoesNotExist = null, Expression<Func<string>> getColumnFromIAConnectListFallbackValue = null, Expression<Func<getColumnFromIAConnectListReturnFormatInput>> getColumnFromIAConnectListReturnFormat = null)
        {
            var apiCallPath = "/DynamicCode/GetColumnFromIAConnectList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getColumnFromIAConnectList = new JObject();
            var getColumnFromIAConnectListpropCount = 0;
            getColumnFromIAConnectListpropCount++;
            getColumnFromIAConnectList["ListName"] = ExpressionConverter.ConvertO(getColumnFromIAConnectListListName);
            if (getColumnFromIAConnectListSearchColumnIndex != null)
            {
                getColumnFromIAConnectList["SearchColumnIndex"] = ExpressionConverter.ConvertO(getColumnFromIAConnectListSearchColumnIndex);
                getColumnFromIAConnectListpropCount++;
            }

            if (getColumnFromIAConnectListSearchColumnName != null)
            {
                getColumnFromIAConnectList["SearchColumnName"] = ExpressionConverter.ConvertO(getColumnFromIAConnectListSearchColumnName);
                getColumnFromIAConnectListpropCount++;
            }

            if (getColumnFromIAConnectListReturnBlankCells != null)
            {
                getColumnFromIAConnectList["ReturnBlankCells"] = ExpressionConverter.ConvertO(getColumnFromIAConnectListReturnBlankCells);
                getColumnFromIAConnectListpropCount++;
            }

            if (getColumnFromIAConnectListFallBackIfListDoesNotExist != null)
            {
                getColumnFromIAConnectList["FallBackIfListDoesNotExist"] = ExpressionConverter.ConvertO(getColumnFromIAConnectListFallBackIfListDoesNotExist);
                getColumnFromIAConnectListpropCount++;
            }

            if (getColumnFromIAConnectListFallbackValue != null)
            {
                getColumnFromIAConnectList["FallbackValue"] = ExpressionConverter.ConvertO(getColumnFromIAConnectListFallbackValue);
                getColumnFromIAConnectListpropCount++;
            }

            if (getColumnFromIAConnectListReturnFormat != null)
            {
                getColumnFromIAConnectList["ReturnFormat"] = ExpressionConverter.ConvertO(getColumnFromIAConnectListReturnFormat);
                getColumnFromIAConnectListpropCount++;
            }

            if (getColumnFromIAConnectListpropCount > 0)
            {
                callPayload.Body = getColumnFromIAConnectList;
            }

            return new ApiConnectionAction<GetColumnFromIAConnectListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetIAConnectListContentsResponse> GetIAConnectListContents(Expression<Func<string>> getIAConnectListContentsListName, Expression<Func<getIAConnectListContentsReturnFormatInput>> getIAConnectListContentsReturnFormat = null)
        {
            var apiCallPath = "/DynamicCode/GetIAConnectListContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getIAConnectListContents = new JObject();
            var getIAConnectListContentspropCount = 0;
            getIAConnectListContentspropCount++;
            getIAConnectListContents["ListName"] = ExpressionConverter.ConvertO(getIAConnectListContentsListName);
            if (getIAConnectListContentsReturnFormat != null)
            {
                getIAConnectListContents["ReturnFormat"] = ExpressionConverter.ConvertO(getIAConnectListContentsReturnFormat);
                getIAConnectListContentspropCount++;
            }

            if (getIAConnectListContentspropCount > 0)
            {
                callPayload.Body = getIAConnectListContents;
            }

            return new ApiConnectionAction<GetIAConnectListContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LookupDataCellsFromIAConnectLookupTableResponse> LookupDataCellsFromIAConnectLookupTable(Expression<Func<string>> lookupDataCellsFromIAConnectLookupTableLookupTableName, Expression<Func<string>> lookupDataCellsFromIAConnectLookupTableInputDataJSON = null, Expression<Func<bool>> lookupDataCellsFromIAConnectLookupTableRaiseExceptionIfNoMatch = null, Expression<Func<bool>> lookupDataCellsFromIAConnectLookupTableReturnBlankCells = null, Expression<Func<lookupDataCellsFromIAConnectLookupTableReturnFormatInput>> lookupDataCellsFromIAConnectLookupTableReturnFormat = null)
        {
            var apiCallPath = "/DynamicCode/LookupDataCellsFromIAConnectLookupTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var lookupDataCellsFromIAConnectLookupTable = new JObject();
            var lookupDataCellsFromIAConnectLookupTablepropCount = 0;
            lookupDataCellsFromIAConnectLookupTablepropCount++;
            lookupDataCellsFromIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(lookupDataCellsFromIAConnectLookupTableLookupTableName);
            if (lookupDataCellsFromIAConnectLookupTableInputDataJSON != null)
            {
                lookupDataCellsFromIAConnectLookupTable["InputDataJSON"] = ExpressionConverter.ConvertO(lookupDataCellsFromIAConnectLookupTableInputDataJSON);
                lookupDataCellsFromIAConnectLookupTablepropCount++;
            }

            if (lookupDataCellsFromIAConnectLookupTableRaiseExceptionIfNoMatch != null)
            {
                lookupDataCellsFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = ExpressionConverter.ConvertO(lookupDataCellsFromIAConnectLookupTableRaiseExceptionIfNoMatch);
                lookupDataCellsFromIAConnectLookupTablepropCount++;
            }

            if (lookupDataCellsFromIAConnectLookupTableReturnBlankCells != null)
            {
                lookupDataCellsFromIAConnectLookupTable["ReturnBlankCells"] = ExpressionConverter.ConvertO(lookupDataCellsFromIAConnectLookupTableReturnBlankCells);
                lookupDataCellsFromIAConnectLookupTablepropCount++;
            }

            if (lookupDataCellsFromIAConnectLookupTableReturnFormat != null)
            {
                lookupDataCellsFromIAConnectLookupTable["ReturnFormat"] = ExpressionConverter.ConvertO(lookupDataCellsFromIAConnectLookupTableReturnFormat);
                lookupDataCellsFromIAConnectLookupTablepropCount++;
            }

            if (lookupDataCellsFromIAConnectLookupTablepropCount > 0)
            {
                callPayload.Body = lookupDataCellsFromIAConnectLookupTable;
            }

            return new ApiConnectionAction<LookupDataCellsFromIAConnectLookupTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetIAConnectLookupTableContentsResponse> GetIAConnectLookupTableContents(Expression<Func<string>> getIAConnectLookupTableContentsLookupTableName, Expression<Func<getIAConnectLookupTableContentsReturnFormatInput>> getIAConnectLookupTableContentsReturnFormat = null)
        {
            var apiCallPath = "/DynamicCode/GetIAConnectLookupTableContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getIAConnectLookupTableContents = new JObject();
            var getIAConnectLookupTableContentspropCount = 0;
            getIAConnectLookupTableContentspropCount++;
            getIAConnectLookupTableContents["LookupTableName"] = ExpressionConverter.ConvertO(getIAConnectLookupTableContentsLookupTableName);
            if (getIAConnectLookupTableContentsReturnFormat != null)
            {
                getIAConnectLookupTableContents["ReturnFormat"] = ExpressionConverter.ConvertO(getIAConnectLookupTableContentsReturnFormat);
                getIAConnectLookupTableContentspropCount++;
            }

            if (getIAConnectLookupTableContentspropCount > 0)
            {
                callPayload.Body = getIAConnectLookupTableContents;
            }

            return new ApiConnectionAction<GetIAConnectLookupTableContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<UploadCSVToIAConnectLookupTableResponse> UploadCSVToIAConnectLookupTable(Expression<Func<string>> uploadCSVToIAConnectLookupTableLookupTableName, Expression<Func<string>> uploadCSVToIAConnectLookupTableCSVData, Expression<Func<bool>> uploadCSVToIAConnectLookupTableCreateLookupTableIfNotExist = null)
        {
            var apiCallPath = "/DynamicCode/UploadCSVToIAConnectLookupTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uploadCSVToIAConnectLookupTable = new JObject();
            var uploadCSVToIAConnectLookupTablepropCount = 0;
            uploadCSVToIAConnectLookupTablepropCount++;
            uploadCSVToIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(uploadCSVToIAConnectLookupTableLookupTableName);
            uploadCSVToIAConnectLookupTablepropCount++;
            uploadCSVToIAConnectLookupTable["CSVData"] = ExpressionConverter.ConvertO(uploadCSVToIAConnectLookupTableCSVData);
            if (uploadCSVToIAConnectLookupTableCreateLookupTableIfNotExist != null)
            {
                uploadCSVToIAConnectLookupTable["CreateLookupTableIfNotExist"] = ExpressionConverter.ConvertO(uploadCSVToIAConnectLookupTableCreateLookupTableIfNotExist);
                uploadCSVToIAConnectLookupTablepropCount++;
            }

            if (uploadCSVToIAConnectLookupTablepropCount > 0)
            {
                callPayload.Body = uploadCSVToIAConnectLookupTable;
            }

            return new ApiConnectionAction<UploadCSVToIAConnectLookupTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<UploadCSVToIAConnectListResponse> UploadCSVToIAConnectList(Expression<Func<string>> uploadCSVToIAConnectListListName, Expression<Func<string>> uploadCSVToIAConnectListCSVData, Expression<Func<bool>> uploadCSVToIAConnectListCreateListIfNotExist = null)
        {
            var apiCallPath = "/DynamicCode/UploadCSVToIAConnectList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uploadCSVToIAConnectList = new JObject();
            var uploadCSVToIAConnectListpropCount = 0;
            uploadCSVToIAConnectListpropCount++;
            uploadCSVToIAConnectList["ListName"] = ExpressionConverter.ConvertO(uploadCSVToIAConnectListListName);
            uploadCSVToIAConnectListpropCount++;
            uploadCSVToIAConnectList["CSVData"] = ExpressionConverter.ConvertO(uploadCSVToIAConnectListCSVData);
            if (uploadCSVToIAConnectListCreateListIfNotExist != null)
            {
                uploadCSVToIAConnectList["CreateListIfNotExist"] = ExpressionConverter.ConvertO(uploadCSVToIAConnectListCreateListIfNotExist);
                uploadCSVToIAConnectListpropCount++;
            }

            if (uploadCSVToIAConnectListpropCount > 0)
            {
                callPayload.Body = uploadCSVToIAConnectList;
            }

            return new ApiConnectionAction<UploadCSVToIAConnectListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<ConvertArrayToJSONResponse> ConvertArrayToJSON(Expression<Func<JToken[]>> convertArrayToJSONInputObject)
        {
            var apiCallPath = "/DynamicCode/ConvertArrayToJSON";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var convertArrayToJSON = new JObject();
            var convertArrayToJSONpropCount = 0;
            convertArrayToJSONpropCount++;
            convertArrayToJSON["InputObject"] = ExpressionConverter.ConvertO(convertArrayToJSONInputObject);
            if (convertArrayToJSONpropCount > 0)
            {
                callPayload.Body = convertArrayToJSON;
            }

            return new ApiConnectionAction<ConvertArrayToJSONResponse>(callPayload);
        }
    }

    public class IaconnectdynamiccodeTriggers([ConnectionName] string connectionId)
    {
    }

    public class IsPowerShellAutomationInstalledResponse
    {
        public bool PowerShellAutomationIsInstalled { get; set; }
    }

    public class IsPowerShellModuleInstalledResponse
    {
        public bool PowerShellModuleIsInstalled { get; set; }
    }

    public class RunPowerShellAutomationScriptResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int ThreadId { get; set; }
    }

    public enum runPowerShellAutomationScriptAuthenticationMechanismInput
    {
        Basic,
        Credssp,
        Default,
        Digest,
        Kerberos,
        Negotiate
    }

    public class runPowerShellAutomationScriptPowerShellCommandParametersInputItem
    {
        public string Name { get; set; }
        public string StringValue { get; set; }
        public int IntValue { get; set; }
        public bool BooleanValue { get; set; }
        public double DecimalValue { get; set; }
        public JToken ObjectValue { get; set; }
    }

    public class GetPowerShellVersionResponse
    {
        public int PowerShellMajorVersion { get; set; }
        public int PowerShellMinorVersion { get; set; }
    }

    public enum getPowerShellVersionAuthenticationMechanismInput
    {
        Basic,
        Credssp,
        Default,
        Digest,
        Kerberos,
        Negotiate
    }

    public class GetRegexMatchResponse
    {
        public bool SuccessfulMatch { get; set; }
        public string MatchStringValue { get; set; }
        public int MatchIndex { get; set; }
        public int MatchStringLength { get; set; }
    }

    public class GetRegexMatchesResponse
    {
        public JToken[] OutputArray { get; set; }
        public int NumberOfElementsInOutput { get; set; }
    }

    public class GetRegexSplitResponse
    {
        public JToken[] OutputArray { get; set; }
        public int NumberOfElementsInOutput { get; set; }
    }

    public class GetRegexGroupMatchesResponse
    {
        public GetRegexGroupMatchesResponseRegexGroupsTypeItem[] RegexGroups { get; set; }
        public int NumberOfRegexGroups { get; set; }
    }

    public class GetRegexGroupMatchesResponseRegexGroupsTypeItem
    {
        public string Property { get; set; }
        public string Value { get; set; }
    }

    public class CreateJSONFromInputVariablesResponse
    {
        public string OutputJSON { get; set; }
    }

    public class createJSONFromInputVariablesInputVariablesInputItem
    {
        public string PropertyName { get; set; }
        public createJSONFromInputVariablesInputVariablesInputItemDataTypeType DataType { get; set; }
        public string Value { get; set; }
    }

    public enum createJSONFromInputVariablesInputVariablesInputItemDataTypeType
    {
        String,
        Integer,
        Float,
        Boolean
    }

    public class GetJSONTableFromStringArrayResponse
    {
        public string OutputJSONTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class FilterJSONTableResponse
    {
        public string OutputJSONTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class FilterTableResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class SortTableResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class SortJSONTableResponse
    {
        public string OutputJSONTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class GetTableFromStringArrayResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class GetTableFromJSONResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class SortStringArrayResponse
    {
        public string[] OutputArray { get; set; }
        public int NumberOfItems { get; set; }
    }

    public class FilterStringArrayResponse
    {
        public string[] OutputArray { get; set; }
        public int NumberOfItems { get; set; }
    }

    public class InsertRowInStringArrayResponse
    {
        public string[] OutputArray { get; set; }
        public int NumberOfItems { get; set; }
    }

    public class InsertRowInTableResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class InsertRowInJSONTableResponse
    {
        public string OutputJSONTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class InsertRowInJSONTableFromInputVariablesResponse
    {
        public string OutputJSONTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class insertRowInJSONTableFromInputVariablesRowToInsertInputVariablesInputItem
    {
        public string PropertyName { get; set; }
        public insertRowInJSONTableFromInputVariablesRowToInsertInputVariablesInputItemDataTypeType DataType { get; set; }
        public string Value { get; set; }
    }

    public enum insertRowInJSONTableFromInputVariablesRowToInsertInputVariablesInputItemDataTypeType
    {
        String,
        Integer,
        Float,
        Boolean
    }

    public class DeleteItemsInStringArrayResponse
    {
        public string[] OutputArray { get; set; }
        public int NumberOfItems { get; set; }
    }

    public class DeleteRowsInTableResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class DeleteRowsInJSONTableResponse
    {
        public string OutputJSONTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class RenameColumnInTableResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class RenameColumnInJSONTableResponse
    {
        public string OutputJSONTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class DeleteColumnsInTableResponse
    {
        public JToken[] OutputTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class DeleteColumnsInJSONTableResponse
    {
        public string OutputJSONTable { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class GetStringArrayFromTableColumnResponse
    {
        public string[] OutputArray { get; set; }
        public int NumberOfItems { get; set; }
    }

    public class GetStringArrayFromJSONTableColumnResponse
    {
        public string[] OutputArray { get; set; }
        public int NumberOfItems { get; set; }
    }

    public class GetStringFromJSONTableCellResponse
    {
        public string OutputString { get; set; }
    }

    public class GetStringBetweenResponse
    {
        public bool SearchStringFound { get; set; }
        public string StringBetween { get; set; }
    }

    public class LoadIAConnectLookupTableResponse
    {
        public int NumberOfLookupTablesLoaded { get; set; }
        public int NumberOfLookupTablesFailedToLoad { get; set; }
    }

    public class GetIAConnectLookupTableSummaryResponse
    {
        public GetIAConnectLookupTableSummaryResponseLookupTablesJSONTypeItem[] LookupTablesJSON { get; set; }
        public int NumberOfLookupTables { get; set; }
    }

    public class GetIAConnectLookupTableSummaryResponseLookupTablesJSONTypeItem
    {
        public string Name { get; set; }
        public int ThenColumnIndex { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
        public int NumberOfUniqueHeaderProperties { get; set; }
    }

    public class RemoveIAConnectLookupTableResponse
    {
        public bool RemoveIAConnectLookupTableResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class RemoveAllIAConnectLookupTablesResponse
    {
        public bool RemoveAllIAConnectLookupTablesResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class LookupValueFromIAConnectLookupTableResponse
    {
        public string OutputLookupValue { get; set; }
    }

    public class LookupColumnsFromIAConnectLookupTableResponse
    {
        public string OutputLookupTableJSON { get; set; }
        public JToken[] OutputLookupTable { get; set; }
        public JToken[] OutputLookupArray { get; set; }
        public int NumberOfRowsInOutput { get; set; }
    }

    public enum lookupColumnsFromIAConnectLookupTableReturnFormatInput
    {
        JSON,
        Array,
        Table
    }

    public class RemoveCharactersFromStringResponse
    {
        public string OutputString { get; set; }
    }

    public class GetColumnFromIAConnectListResponse
    {
        public string OutputListJSON { get; set; }
        public JToken[] OutputList { get; set; }
        public JToken[] OutputListArray { get; set; }
        public int NumberOfRowsInOutput { get; set; }
    }

    public enum getColumnFromIAConnectListReturnFormatInput
    {
        JSON,
        Array,
        Table
    }

    public class GetIAConnectListContentsResponse
    {
        public string OutputListJSON { get; set; }
        public JToken[] OutputList { get; set; }
        public string OutputListCSV { get; set; }
        public int NumberOfRowsInOutput { get; set; }
        public int NumberOfColumnsInOutput { get; set; }
    }

    public enum getIAConnectListContentsReturnFormatInput
    {
        JSON,
        Table,
        CSV
    }

    public class LookupDataCellsFromIAConnectLookupTableResponse
    {
        public string OutputLookupTableJSON { get; set; }
        public JToken[] OutputLookupTable { get; set; }
        public int NumberOfCellsInOutput { get; set; }
    }

    public enum lookupDataCellsFromIAConnectLookupTableReturnFormatInput
    {
        JSON,
        Table
    }

    public class GetIAConnectLookupTableContentsResponse
    {
        public string OutputLookupTableJSON { get; set; }
        public JToken[] OutputLookupTable { get; set; }
        public string OutputLookupTableCSV { get; set; }
        public int NumberOfRowsInOutput { get; set; }
        public int NumberOfColumnsInOutput { get; set; }
    }

    public enum getIAConnectLookupTableContentsReturnFormatInput
    {
        JSON,
        Table,
        CSV
    }

    public class UploadCSVToIAConnectLookupTableResponse
    {
        public bool UploadCSVToIAConnectLookupTableResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UploadCSVToIAConnectListResponse
    {
        public bool UploadCSVToIAConnectListResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ConvertArrayToJSONResponse
    {
        public string OutputJSON { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Iaconnectdynamiccode;

    public partial class WorkflowManagedActions
    {
        public IaconnectdynamiccodeActions Iaconnectdynamiccode(string connectionId) => new IaconnectdynamiccodeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectdynamiccodeTriggers Iaconnectdynamiccode(string connectionId) => new IaconnectdynamiccodeTriggers(connectionId);
    }
}