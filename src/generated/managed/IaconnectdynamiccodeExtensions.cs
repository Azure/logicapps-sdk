//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectdynamiccode
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectdynamiccodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IWorkflowAction ImportAssemblyFromLocalFile(Expression<Func<string>> importAssemblyFromLocalFilelocalAssemblyFilePath, Expression<Func<string>> importAssemblyFromLocalFileassemblyName, Expression<Func<string>> importAssemblyFromLocalFileworkflow, Expression<Func<bool>> importAssemblyFromLocalFilecompress = null)
        {
            var apiCallPath = "/DynamicCode/ImportAssemblyFromLocalFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var importAssemblyFromLocalFile = new JObject();
            var importAssemblyFromLocalFilepropCount = 0;
            importAssemblyFromLocalFilepropCount++;
            importAssemblyFromLocalFile["LocalAssemblyFilePath"] = CSharpExpressionConverter.ConvertToken(importAssemblyFromLocalFilelocalAssemblyFilePath);
            importAssemblyFromLocalFilepropCount++;
            importAssemblyFromLocalFile["AssemblyName"] = CSharpExpressionConverter.ConvertToken(importAssemblyFromLocalFileassemblyName);
            if (importAssemblyFromLocalFilecompress != null)
            {
                if (importAssemblyFromLocalFilecompress != null)
                {
                    importAssemblyFromLocalFile["Compress"] = CSharpExpressionConverter.ConvertToken(importAssemblyFromLocalFilecompress);
                    importAssemblyFromLocalFilepropCount++;
                }

                importAssemblyFromLocalFilepropCount++;
            }
            else
            {
                importAssemblyFromLocalFile["Compress"] = true;
                importAssemblyFromLocalFilepropCount++;
            }

            importAssemblyFromLocalFilepropCount++;
            importAssemblyFromLocalFile["Workflow"] = CSharpExpressionConverter.ConvertToken(importAssemblyFromLocalFileworkflow);
            if (importAssemblyFromLocalFilepropCount > 0)
            {
                callPayload.Body = importAssemblyFromLocalFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IWorkflowAction AddAssemblySearchFolder(Expression<Func<string>> addAssemblySearchFolderfolderPath, Expression<Func<string>> addAssemblySearchFolderworkflow)
        {
            var apiCallPath = "/DynamicCode/AddAssemblySearchFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addAssemblySearchFolder = new JObject();
            var addAssemblySearchFolderpropCount = 0;
            addAssemblySearchFolderpropCount++;
            addAssemblySearchFolder["FolderPath"] = CSharpExpressionConverter.ConvertToken(addAssemblySearchFolderfolderPath);
            addAssemblySearchFolderpropCount++;
            addAssemblySearchFolder["Workflow"] = CSharpExpressionConverter.ConvertToken(addAssemblySearchFolderworkflow);
            if (addAssemblySearchFolderpropCount > 0)
            {
                callPayload.Body = addAssemblySearchFolder;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IWorkflowAction ClearAssemblySearchFolders(Expression<Func<string>> clearAssemblySearchFoldersworkflow)
        {
            var apiCallPath = "/DynamicCode/ClearAssemblySearchFolders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var clearAssemblySearchFolders = new JObject();
            var clearAssemblySearchFolderspropCount = 0;
            clearAssemblySearchFolderspropCount++;
            clearAssemblySearchFolders["Workflow"] = CSharpExpressionConverter.ConvertToken(clearAssemblySearchFoldersworkflow);
            if (clearAssemblySearchFolderspropCount > 0)
            {
                callPayload.Body = clearAssemblySearchFolders;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<IsPowerShellAutomationInstalledResponse> IsPowerShellAutomationInstalled(Expression<Func<string>> isPowerShellAutomationInstalledworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/isPowerShellAutomationInstalled";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isPowerShellAutomationInstalled = new JObject();
            var isPowerShellAutomationInstalledpropCount = 0;
            isPowerShellAutomationInstalledpropCount++;
            isPowerShellAutomationInstalled["Workflow"] = CSharpExpressionConverter.ConvertToken(isPowerShellAutomationInstalledworkflow);
            if (isPowerShellAutomationInstalledpropCount > 0)
            {
                callPayload.Body = isPowerShellAutomationInstalled;
            }

            return new ApiConnectionAction<IsPowerShellAutomationInstalledResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<IsPowerShellModuleInstalledResponse> IsPowerShellModuleInstalled(Expression<Func<string>> isPowerShellModuleInstalledpowerShellModuleName, Expression<Func<string>> isPowerShellModuleInstalledworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/isPowerShellModuleInstalled";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isPowerShellModuleInstalled = new JObject();
            var isPowerShellModuleInstalledpropCount = 0;
            isPowerShellModuleInstalledpropCount++;
            isPowerShellModuleInstalled["PowerShellModuleName"] = CSharpExpressionConverter.ConvertToken(isPowerShellModuleInstalledpowerShellModuleName);
            isPowerShellModuleInstalledpropCount++;
            isPowerShellModuleInstalled["Workflow"] = CSharpExpressionConverter.ConvertToken(isPowerShellModuleInstalledworkflow);
            if (isPowerShellModuleInstalledpropCount > 0)
            {
                callPayload.Body = isPowerShellModuleInstalled;
            }

            return new ApiConnectionAction<IsPowerShellModuleInstalledResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RunPowerShellAutomationScriptResponse> RunPowerShellAutomationScript(Expression<Func<string>> runPowerShellAutomationScriptworkflow, Expression<Func<string>> runPowerShellAutomationScriptpowerShellScriptContents = null, Expression<Func<string>> runPowerShellAutomationScriptcomputerName = null, Expression<Func<bool>> runPowerShellAutomationScriptisNoResultAnError = null, Expression<Func<bool>> runPowerShellAutomationScriptreturnComplexTypes = null, Expression<Func<bool>> runPowerShellAutomationScriptreturnBooleanAsBoolean = null, Expression<Func<bool>> runPowerShellAutomationScriptreturnNumericAsDecimal = null, Expression<Func<bool>> runPowerShellAutomationScriptreturnDateAsDate = null, Expression<Func<string>> runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, Expression<Func<runPowerShellAutomationScriptauthenticationMechanismInput>> runPowerShellAutomationScriptauthenticationMechanism = null, Expression<Func<int>> runPowerShellAutomationScriptconnectionAttempts = null, Expression<Func<string>> runPowerShellAutomationScriptusername = null, Expression<Func<string>> runPowerShellAutomationScriptpassword = null, Expression<Func<bool>> runPowerShellAutomationScriptrunScriptAsThread = null, Expression<Func<int>> runPowerShellAutomationScriptretrieveOutputDataFromThreadId = null, Expression<Func<int>> runPowerShellAutomationScriptsecondsToWaitForThread = null, Expression<Func<bool>> runPowerShellAutomationScriptscriptContainsStoredPassword = null, Expression<Func<bool>> runPowerShellAutomationScriptlogVerboseOutput = null, Expression<Func<bool>> runPowerShellAutomationScriptreturnSecureStrings = null, Expression<Func<string>> runPowerShellAutomationScriptpropertyNamesToSerializeJSON = null, Expression<Func<string>> runPowerShellAutomationScriptpropertyTypesToSerializeJSON = null, Expression<Func<runPowerShellAutomationScriptpowerShellCommandParametersInputItem[]>> runPowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            var apiCallPath = "/PowerShellAutomation/RunPowerShellScript";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runPowerShellAutomationScript = new JObject();
            var runPowerShellAutomationScriptpropCount = 0;
            if (runPowerShellAutomationScriptpowerShellScriptContents != null)
            {
                runPowerShellAutomationScript["PowerShellScriptContents"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptpowerShellScriptContents);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptcomputerName != null)
            {
                runPowerShellAutomationScript["ComputerName"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptcomputerName);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptisNoResultAnError != null)
            {
                if (runPowerShellAutomationScriptisNoResultAnError != null)
                {
                    runPowerShellAutomationScript["IsNoResultAnError"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptisNoResultAnError);
                    runPowerShellAutomationScriptpropCount++;
                }

                runPowerShellAutomationScriptpropCount++;
            }
            else
            {
                runPowerShellAutomationScript["IsNoResultAnError"] = false;
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptreturnComplexTypes != null)
            {
                if (runPowerShellAutomationScriptreturnComplexTypes != null)
                {
                    runPowerShellAutomationScript["ReturnComplexTypes"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptreturnComplexTypes);
                    runPowerShellAutomationScriptpropCount++;
                }

                runPowerShellAutomationScriptpropCount++;
            }
            else
            {
                runPowerShellAutomationScript["ReturnComplexTypes"] = false;
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptreturnBooleanAsBoolean != null)
            {
                if (runPowerShellAutomationScriptreturnBooleanAsBoolean != null)
                {
                    runPowerShellAutomationScript["ReturnBooleanAsBoolean"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptreturnBooleanAsBoolean);
                    runPowerShellAutomationScriptpropCount++;
                }

                runPowerShellAutomationScriptpropCount++;
            }
            else
            {
                runPowerShellAutomationScript["ReturnBooleanAsBoolean"] = false;
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptreturnNumericAsDecimal != null)
            {
                if (runPowerShellAutomationScriptreturnNumericAsDecimal != null)
                {
                    runPowerShellAutomationScript["ReturnNumericAsDecimal"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptreturnNumericAsDecimal);
                    runPowerShellAutomationScriptpropCount++;
                }

                runPowerShellAutomationScriptpropCount++;
            }
            else
            {
                runPowerShellAutomationScript["ReturnNumericAsDecimal"] = false;
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptreturnDateAsDate != null)
            {
                if (runPowerShellAutomationScriptreturnDateAsDate != null)
                {
                    runPowerShellAutomationScript["ReturnDateAsDate"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptreturnDateAsDate);
                    runPowerShellAutomationScriptpropCount++;
                }

                runPowerShellAutomationScriptpropCount++;
            }
            else
            {
                runPowerShellAutomationScript["ReturnDateAsDate"] = false;
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON != null)
            {
                runPowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptauthenticationMechanism != null)
            {
                runPowerShellAutomationScript["AuthenticationMechanism"] = CSharpExpressionConverter.Convert(runPowerShellAutomationScriptauthenticationMechanism);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptconnectionAttempts != null)
            {
                if (runPowerShellAutomationScriptconnectionAttempts != null)
                {
                    runPowerShellAutomationScript["ConnectionAttempts"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptconnectionAttempts);
                    runPowerShellAutomationScriptpropCount++;
                }

                runPowerShellAutomationScriptpropCount++;
            }
            else
            {
                runPowerShellAutomationScript["ConnectionAttempts"] = 1;
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptusername != null)
            {
                runPowerShellAutomationScript["Username"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptusername);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptpassword != null)
            {
                runPowerShellAutomationScript["Password"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptpassword);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptrunScriptAsThread != null)
            {
                if (runPowerShellAutomationScriptrunScriptAsThread != null)
                {
                    runPowerShellAutomationScript["RunScriptAsThread"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptrunScriptAsThread);
                    runPowerShellAutomationScriptpropCount++;
                }

                runPowerShellAutomationScriptpropCount++;
            }
            else
            {
                runPowerShellAutomationScript["RunScriptAsThread"] = false;
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptretrieveOutputDataFromThreadId != null)
            {
                runPowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptretrieveOutputDataFromThreadId);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptsecondsToWaitForThread != null)
            {
                if (runPowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    runPowerShellAutomationScript["SecondsToWaitForThread"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptsecondsToWaitForThread);
                    runPowerShellAutomationScriptpropCount++;
                }

                runPowerShellAutomationScriptpropCount++;
            }
            else
            {
                runPowerShellAutomationScript["SecondsToWaitForThread"] = 90;
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptscriptContainsStoredPassword != null)
            {
                if (runPowerShellAutomationScriptscriptContainsStoredPassword != null)
                {
                    runPowerShellAutomationScript["ScriptContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptscriptContainsStoredPassword);
                    runPowerShellAutomationScriptpropCount++;
                }

                runPowerShellAutomationScriptpropCount++;
            }
            else
            {
                runPowerShellAutomationScript["ScriptContainsStoredPassword"] = true;
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptlogVerboseOutput != null)
            {
                if (runPowerShellAutomationScriptlogVerboseOutput != null)
                {
                    runPowerShellAutomationScript["LogVerboseOutput"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptlogVerboseOutput);
                    runPowerShellAutomationScriptpropCount++;
                }

                runPowerShellAutomationScriptpropCount++;
            }
            else
            {
                runPowerShellAutomationScript["LogVerboseOutput"] = false;
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptreturnSecureStrings != null)
            {
                if (runPowerShellAutomationScriptreturnSecureStrings != null)
                {
                    runPowerShellAutomationScript["ReturnSecureStrings"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptreturnSecureStrings);
                    runPowerShellAutomationScriptpropCount++;
                }

                runPowerShellAutomationScriptpropCount++;
            }
            else
            {
                runPowerShellAutomationScript["ReturnSecureStrings"] = false;
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptpropertyNamesToSerializeJSON != null)
            {
                runPowerShellAutomationScript["PropertyNamesToSerializeJSON"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptpropertyNamesToSerializeJSON);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
            {
                runPowerShellAutomationScript["PropertyTypesToSerializeJSON"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptpropertyTypesToSerializeJSON);
                runPowerShellAutomationScriptpropCount++;
            }

            if (runPowerShellAutomationScriptpowerShellCommandParameters != null)
            {
                runPowerShellAutomationScript["PowerShellCommandParameters"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptpowerShellCommandParameters);
                runPowerShellAutomationScriptpropCount++;
            }

            runPowerShellAutomationScriptpropCount++;
            runPowerShellAutomationScript["Workflow"] = CSharpExpressionConverter.ConvertToken(runPowerShellAutomationScriptworkflow);
            if (runPowerShellAutomationScriptpropCount > 0)
            {
                callPayload.Body = runPowerShellAutomationScript;
            }

            return new ApiConnectionAction<RunPowerShellAutomationScriptResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetPowerShellVersionResponse> GetPowerShellVersion(Expression<Func<string>> getPowerShellVersionworkflow, Expression<Func<string>> getPowerShellVersioncomputerName = null, Expression<Func<getPowerShellVersionauthenticationMechanismInput>> getPowerShellVersionauthenticationMechanism = null, Expression<Func<int>> getPowerShellVersionconnectionAttempts = null)
        {
            var apiCallPath = "/PowerShellAutomation/GetPowerShellVersion";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getPowerShellVersion = new JObject();
            var getPowerShellVersionpropCount = 0;
            if (getPowerShellVersioncomputerName != null)
            {
                getPowerShellVersion["ComputerName"] = CSharpExpressionConverter.ConvertToken(getPowerShellVersioncomputerName);
                getPowerShellVersionpropCount++;
            }

            if (getPowerShellVersionauthenticationMechanism != null)
            {
                getPowerShellVersion["AuthenticationMechanism"] = CSharpExpressionConverter.Convert(getPowerShellVersionauthenticationMechanism);
                getPowerShellVersionpropCount++;
            }

            if (getPowerShellVersionconnectionAttempts != null)
            {
                if (getPowerShellVersionconnectionAttempts != null)
                {
                    getPowerShellVersion["ConnectionAttempts"] = CSharpExpressionConverter.ConvertToken(getPowerShellVersionconnectionAttempts);
                    getPowerShellVersionpropCount++;
                }

                getPowerShellVersionpropCount++;
            }
            else
            {
                getPowerShellVersion["ConnectionAttempts"] = 1;
                getPowerShellVersionpropCount++;
            }

            getPowerShellVersionpropCount++;
            getPowerShellVersion["Workflow"] = CSharpExpressionConverter.ConvertToken(getPowerShellVersionworkflow);
            if (getPowerShellVersionpropCount > 0)
            {
                callPayload.Body = getPowerShellVersion;
            }

            return new ApiConnectionAction<GetPowerShellVersionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexMatchResponse> GetRegexMatch(Expression<Func<string>> getRegexMatchtextToMatch, Expression<Func<string>> getRegexMatchregex, Expression<Func<int>> getRegexMatchsearchIndex = null, Expression<Func<bool>> getRegexMatchcaseSensitive = null, Expression<Func<int>> getRegexMatchregexTimeoutInSeconds = null)
        {
            var apiCallPath = "/DynamicCode/GetRegexMatch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRegexMatch = new JObject();
            var getRegexMatchpropCount = 0;
            getRegexMatchpropCount++;
            getRegexMatch["TextToMatch"] = CSharpExpressionConverter.ConvertToken(getRegexMatchtextToMatch);
            getRegexMatchpropCount++;
            getRegexMatch["Regex"] = CSharpExpressionConverter.ConvertToken(getRegexMatchregex);
            if (getRegexMatchsearchIndex != null)
            {
                if (getRegexMatchsearchIndex != null)
                {
                    getRegexMatch["SearchIndex"] = CSharpExpressionConverter.ConvertToken(getRegexMatchsearchIndex);
                    getRegexMatchpropCount++;
                }

                getRegexMatchpropCount++;
            }
            else
            {
                getRegexMatch["SearchIndex"] = 1;
                getRegexMatchpropCount++;
            }

            if (getRegexMatchcaseSensitive != null)
            {
                if (getRegexMatchcaseSensitive != null)
                {
                    getRegexMatch["CaseSensitive"] = CSharpExpressionConverter.ConvertToken(getRegexMatchcaseSensitive);
                    getRegexMatchpropCount++;
                }

                getRegexMatchpropCount++;
            }
            else
            {
                getRegexMatch["CaseSensitive"] = true;
                getRegexMatchpropCount++;
            }

            if (getRegexMatchregexTimeoutInSeconds != null)
            {
                if (getRegexMatchregexTimeoutInSeconds != null)
                {
                    getRegexMatch["RegexTimeoutInSeconds"] = CSharpExpressionConverter.ConvertToken(getRegexMatchregexTimeoutInSeconds);
                    getRegexMatchpropCount++;
                }

                getRegexMatchpropCount++;
            }
            else
            {
                getRegexMatch["RegexTimeoutInSeconds"] = 10;
                getRegexMatchpropCount++;
            }

            if (getRegexMatchpropCount > 0)
            {
                callPayload.Body = getRegexMatch;
            }

            return new ApiConnectionAction<GetRegexMatchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexMatchesResponse> GetRegexMatches(Expression<Func<string>> getRegexMatchestextToMatch, Expression<Func<string>> getRegexMatchesregex, Expression<Func<int>> getRegexMatchesmaximumMatches = null, Expression<Func<bool>> getRegexMatchescaseSensitive = null, Expression<Func<bool>> getRegexMatchestrimResults = null, Expression<Func<bool>> getRegexMatchesremoveEmptyResults = null, Expression<Func<int>> getRegexMatchesregexTimeoutInSeconds = null)
        {
            var apiCallPath = "/DynamicCode/GetRegexMatches";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRegexMatches = new JObject();
            var getRegexMatchespropCount = 0;
            getRegexMatchespropCount++;
            getRegexMatches["TextToMatch"] = CSharpExpressionConverter.ConvertToken(getRegexMatchestextToMatch);
            getRegexMatchespropCount++;
            getRegexMatches["Regex"] = CSharpExpressionConverter.ConvertToken(getRegexMatchesregex);
            if (getRegexMatchesmaximumMatches != null)
            {
                if (getRegexMatchesmaximumMatches != null)
                {
                    getRegexMatches["MaximumMatches"] = CSharpExpressionConverter.ConvertToken(getRegexMatchesmaximumMatches);
                    getRegexMatchespropCount++;
                }

                getRegexMatchespropCount++;
            }
            else
            {
                getRegexMatches["MaximumMatches"] = 0;
                getRegexMatchespropCount++;
            }

            if (getRegexMatchescaseSensitive != null)
            {
                if (getRegexMatchescaseSensitive != null)
                {
                    getRegexMatches["CaseSensitive"] = CSharpExpressionConverter.ConvertToken(getRegexMatchescaseSensitive);
                    getRegexMatchespropCount++;
                }

                getRegexMatchespropCount++;
            }
            else
            {
                getRegexMatches["CaseSensitive"] = true;
                getRegexMatchespropCount++;
            }

            if (getRegexMatchestrimResults != null)
            {
                if (getRegexMatchestrimResults != null)
                {
                    getRegexMatches["TrimResults"] = CSharpExpressionConverter.ConvertToken(getRegexMatchestrimResults);
                    getRegexMatchespropCount++;
                }

                getRegexMatchespropCount++;
            }
            else
            {
                getRegexMatches["TrimResults"] = true;
                getRegexMatchespropCount++;
            }

            if (getRegexMatchesremoveEmptyResults != null)
            {
                if (getRegexMatchesremoveEmptyResults != null)
                {
                    getRegexMatches["RemoveEmptyResults"] = CSharpExpressionConverter.ConvertToken(getRegexMatchesremoveEmptyResults);
                    getRegexMatchespropCount++;
                }

                getRegexMatchespropCount++;
            }
            else
            {
                getRegexMatches["RemoveEmptyResults"] = false;
                getRegexMatchespropCount++;
            }

            if (getRegexMatchesregexTimeoutInSeconds != null)
            {
                if (getRegexMatchesregexTimeoutInSeconds != null)
                {
                    getRegexMatches["RegexTimeoutInSeconds"] = CSharpExpressionConverter.ConvertToken(getRegexMatchesregexTimeoutInSeconds);
                    getRegexMatchespropCount++;
                }

                getRegexMatchespropCount++;
            }
            else
            {
                getRegexMatches["RegexTimeoutInSeconds"] = 10;
                getRegexMatchespropCount++;
            }

            if (getRegexMatchespropCount > 0)
            {
                callPayload.Body = getRegexMatches;
            }

            return new ApiConnectionAction<GetRegexMatchesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexSplitResponse> GetRegexSplit(Expression<Func<string>> getRegexSplittextToSplit, Expression<Func<string>> getRegexSplitregex, Expression<Func<bool>> getRegexSplitcaseSensitive = null, Expression<Func<bool>> getRegexSplittrimResults = null, Expression<Func<bool>> getRegexSplitremoveEmptyResults = null, Expression<Func<int>> getRegexSplitregexTimeoutInSeconds = null)
        {
            var apiCallPath = "/DynamicCode/GetRegexSplit";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRegexSplit = new JObject();
            var getRegexSplitpropCount = 0;
            getRegexSplitpropCount++;
            getRegexSplit["TextToSplit"] = CSharpExpressionConverter.ConvertToken(getRegexSplittextToSplit);
            getRegexSplitpropCount++;
            getRegexSplit["Regex"] = CSharpExpressionConverter.ConvertToken(getRegexSplitregex);
            if (getRegexSplitcaseSensitive != null)
            {
                if (getRegexSplitcaseSensitive != null)
                {
                    getRegexSplit["CaseSensitive"] = CSharpExpressionConverter.ConvertToken(getRegexSplitcaseSensitive);
                    getRegexSplitpropCount++;
                }

                getRegexSplitpropCount++;
            }
            else
            {
                getRegexSplit["CaseSensitive"] = true;
                getRegexSplitpropCount++;
            }

            if (getRegexSplittrimResults != null)
            {
                if (getRegexSplittrimResults != null)
                {
                    getRegexSplit["TrimResults"] = CSharpExpressionConverter.ConvertToken(getRegexSplittrimResults);
                    getRegexSplitpropCount++;
                }

                getRegexSplitpropCount++;
            }
            else
            {
                getRegexSplit["TrimResults"] = true;
                getRegexSplitpropCount++;
            }

            if (getRegexSplitremoveEmptyResults != null)
            {
                if (getRegexSplitremoveEmptyResults != null)
                {
                    getRegexSplit["RemoveEmptyResults"] = CSharpExpressionConverter.ConvertToken(getRegexSplitremoveEmptyResults);
                    getRegexSplitpropCount++;
                }

                getRegexSplitpropCount++;
            }
            else
            {
                getRegexSplit["RemoveEmptyResults"] = false;
                getRegexSplitpropCount++;
            }

            if (getRegexSplitregexTimeoutInSeconds != null)
            {
                if (getRegexSplitregexTimeoutInSeconds != null)
                {
                    getRegexSplit["RegexTimeoutInSeconds"] = CSharpExpressionConverter.ConvertToken(getRegexSplitregexTimeoutInSeconds);
                    getRegexSplitpropCount++;
                }

                getRegexSplitpropCount++;
            }
            else
            {
                getRegexSplit["RegexTimeoutInSeconds"] = 10;
                getRegexSplitpropCount++;
            }

            if (getRegexSplitpropCount > 0)
            {
                callPayload.Body = getRegexSplit;
            }

            return new ApiConnectionAction<GetRegexSplitResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexGroupMatchesResponse> GetRegexGroupMatches(Expression<Func<string>> getRegexGroupMatchestextToMatch, Expression<Func<string>> getRegexGroupMatchesregex, Expression<Func<string[]>> getRegexGroupMatchesgroupsToRetrieve = null, Expression<Func<int>> getRegexGroupMatchessearchIndex = null, Expression<Func<bool>> getRegexGroupMatchescaseSensitive = null, Expression<Func<int>> getRegexGroupMatchesregexTimeoutInSeconds = null)
        {
            var apiCallPath = "/DynamicCode/GetRegexGroupMatches";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getRegexGroupMatches = new JObject();
            var getRegexGroupMatchespropCount = 0;
            getRegexGroupMatchespropCount++;
            getRegexGroupMatches["TextToMatch"] = CSharpExpressionConverter.ConvertToken(getRegexGroupMatchestextToMatch);
            getRegexGroupMatchespropCount++;
            getRegexGroupMatches["Regex"] = CSharpExpressionConverter.ConvertToken(getRegexGroupMatchesregex);
            if (getRegexGroupMatchesgroupsToRetrieve != null)
            {
                getRegexGroupMatches["GroupsToRetrieve"] = CSharpExpressionConverter.ConvertToken(getRegexGroupMatchesgroupsToRetrieve);
                getRegexGroupMatchespropCount++;
            }

            if (getRegexGroupMatchessearchIndex != null)
            {
                if (getRegexGroupMatchessearchIndex != null)
                {
                    getRegexGroupMatches["SearchIndex"] = CSharpExpressionConverter.ConvertToken(getRegexGroupMatchessearchIndex);
                    getRegexGroupMatchespropCount++;
                }

                getRegexGroupMatchespropCount++;
            }
            else
            {
                getRegexGroupMatches["SearchIndex"] = 1;
                getRegexGroupMatchespropCount++;
            }

            if (getRegexGroupMatchescaseSensitive != null)
            {
                if (getRegexGroupMatchescaseSensitive != null)
                {
                    getRegexGroupMatches["CaseSensitive"] = CSharpExpressionConverter.ConvertToken(getRegexGroupMatchescaseSensitive);
                    getRegexGroupMatchespropCount++;
                }

                getRegexGroupMatchespropCount++;
            }
            else
            {
                getRegexGroupMatches["CaseSensitive"] = true;
                getRegexGroupMatchespropCount++;
            }

            if (getRegexGroupMatchesregexTimeoutInSeconds != null)
            {
                if (getRegexGroupMatchesregexTimeoutInSeconds != null)
                {
                    getRegexGroupMatches["RegexTimeoutInSeconds"] = CSharpExpressionConverter.ConvertToken(getRegexGroupMatchesregexTimeoutInSeconds);
                    getRegexGroupMatchespropCount++;
                }

                getRegexGroupMatchespropCount++;
            }
            else
            {
                getRegexGroupMatches["RegexTimeoutInSeconds"] = 10;
                getRegexGroupMatchespropCount++;
            }

            if (getRegexGroupMatchespropCount > 0)
            {
                callPayload.Body = getRegexGroupMatches;
            }

            return new ApiConnectionAction<GetRegexGroupMatchesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<CreateJSONFromInputVariablesResponse> CreateJSONFromInputVariables(Expression<Func<createJSONFromInputVariablesinputVariablesInputItem[]>> createJSONFromInputVariablesinputVariables, Expression<Func<bool>> createJSONFromInputVariablesreturnAsJSONTable)
        {
            var apiCallPath = "/DynamicCode/CreateJSONFromInputVariables";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var createJSONFromInputVariables = new JObject();
            var createJSONFromInputVariablespropCount = 0;
            createJSONFromInputVariablespropCount++;
            createJSONFromInputVariables["InputVariables"] = CSharpExpressionConverter.ConvertToken(createJSONFromInputVariablesinputVariables);
            createJSONFromInputVariablespropCount++;
            createJSONFromInputVariables["ReturnAsJSONTable"] = CSharpExpressionConverter.ConvertToken(createJSONFromInputVariablesreturnAsJSONTable);
            if (createJSONFromInputVariablespropCount > 0)
            {
                callPayload.Body = createJSONFromInputVariables;
            }

            return new ApiConnectionAction<CreateJSONFromInputVariablesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetJSONTableFromStringArrayResponse> GetJSONTableFromStringArray(Expression<Func<string[]>> getJSONTableFromStringArrayinputArray, Expression<Func<string>> getJSONTableFromStringArraycolumnName, Expression<Func<bool>> getJSONTableFromStringArraydropEmptyItems = null)
        {
            var apiCallPath = "/DynamicCode/GetJSONTableFromStringArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getJSONTableFromStringArray = new JObject();
            var getJSONTableFromStringArraypropCount = 0;
            getJSONTableFromStringArraypropCount++;
            getJSONTableFromStringArray["InputArray"] = CSharpExpressionConverter.ConvertToken(getJSONTableFromStringArrayinputArray);
            getJSONTableFromStringArraypropCount++;
            getJSONTableFromStringArray["ColumnName"] = CSharpExpressionConverter.ConvertToken(getJSONTableFromStringArraycolumnName);
            if (getJSONTableFromStringArraydropEmptyItems != null)
            {
                if (getJSONTableFromStringArraydropEmptyItems != null)
                {
                    getJSONTableFromStringArray["DropEmptyItems"] = CSharpExpressionConverter.ConvertToken(getJSONTableFromStringArraydropEmptyItems);
                    getJSONTableFromStringArraypropCount++;
                }

                getJSONTableFromStringArraypropCount++;
            }
            else
            {
                getJSONTableFromStringArray["DropEmptyItems"] = false;
                getJSONTableFromStringArraypropCount++;
            }

            if (getJSONTableFromStringArraypropCount > 0)
            {
                callPayload.Body = getJSONTableFromStringArray;
            }

            return new ApiConnectionAction<GetJSONTableFromStringArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<FilterJSONTableResponse> FilterJSONTable(Expression<Func<string>> filterJSONTablejSONTable, Expression<Func<string>> filterJSONTablefilter, Expression<Func<string>> filterJSONTablesortColumnName = null, Expression<Func<bool>> filterJSONTableascending = null, Expression<Func<string>> filterJSONTablesortColumnName2 = null, Expression<Func<bool>> filterJSONTableascending2 = null, Expression<Func<string>> filterJSONTablesortColumnName3 = null, Expression<Func<bool>> filterJSONTableascending3 = null)
        {
            var apiCallPath = "/DynamicCode/FilterJSONTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var filterJSONTable = new JObject();
            var filterJSONTablepropCount = 0;
            filterJSONTablepropCount++;
            filterJSONTable["JSONTable"] = CSharpExpressionConverter.ConvertToken(filterJSONTablejSONTable);
            filterJSONTablepropCount++;
            filterJSONTable["Filter"] = CSharpExpressionConverter.ConvertToken(filterJSONTablefilter);
            if (filterJSONTablesortColumnName != null)
            {
                filterJSONTable["SortColumnName"] = CSharpExpressionConverter.ConvertToken(filterJSONTablesortColumnName);
                filterJSONTablepropCount++;
            }

            if (filterJSONTableascending != null)
            {
                if (filterJSONTableascending != null)
                {
                    filterJSONTable["Ascending"] = CSharpExpressionConverter.ConvertToken(filterJSONTableascending);
                    filterJSONTablepropCount++;
                }

                filterJSONTablepropCount++;
            }
            else
            {
                filterJSONTable["Ascending"] = true;
                filterJSONTablepropCount++;
            }

            if (filterJSONTablesortColumnName2 != null)
            {
                filterJSONTable["SortColumnName2"] = CSharpExpressionConverter.ConvertToken(filterJSONTablesortColumnName2);
                filterJSONTablepropCount++;
            }

            if (filterJSONTableascending2 != null)
            {
                if (filterJSONTableascending2 != null)
                {
                    filterJSONTable["Ascending2"] = CSharpExpressionConverter.ConvertToken(filterJSONTableascending2);
                    filterJSONTablepropCount++;
                }

                filterJSONTablepropCount++;
            }
            else
            {
                filterJSONTable["Ascending2"] = true;
                filterJSONTablepropCount++;
            }

            if (filterJSONTablesortColumnName3 != null)
            {
                filterJSONTable["SortColumnName3"] = CSharpExpressionConverter.ConvertToken(filterJSONTablesortColumnName3);
                filterJSONTablepropCount++;
            }

            if (filterJSONTableascending3 != null)
            {
                if (filterJSONTableascending3 != null)
                {
                    filterJSONTable["Ascending3"] = CSharpExpressionConverter.ConvertToken(filterJSONTableascending3);
                    filterJSONTablepropCount++;
                }

                filterJSONTablepropCount++;
            }
            else
            {
                filterJSONTable["Ascending3"] = true;
                filterJSONTablepropCount++;
            }

            if (filterJSONTablepropCount > 0)
            {
                callPayload.Body = filterJSONTable;
            }

            return new ApiConnectionAction<FilterJSONTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<FilterTableResponse> FilterTable(Expression<Func<JToken[]>> filterTableinputTable, Expression<Func<string>> filterTablefilter, Expression<Func<string>> filterTablesortColumnName = null, Expression<Func<bool>> filterTableascending = null, Expression<Func<string>> filterTablesortColumnName2 = null, Expression<Func<bool>> filterTableascending2 = null, Expression<Func<string>> filterTablesortColumnName3 = null, Expression<Func<bool>> filterTableascending3 = null)
        {
            var apiCallPath = "/DynamicCode/FilterTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var filterTable = new JObject();
            var filterTablepropCount = 0;
            filterTablepropCount++;
            filterTable["InputTable"] = CSharpExpressionConverter.ConvertToken(filterTableinputTable);
            filterTablepropCount++;
            filterTable["Filter"] = CSharpExpressionConverter.ConvertToken(filterTablefilter);
            if (filterTablesortColumnName != null)
            {
                filterTable["SortColumnName"] = CSharpExpressionConverter.ConvertToken(filterTablesortColumnName);
                filterTablepropCount++;
            }

            if (filterTableascending != null)
            {
                if (filterTableascending != null)
                {
                    filterTable["Ascending"] = CSharpExpressionConverter.ConvertToken(filterTableascending);
                    filterTablepropCount++;
                }

                filterTablepropCount++;
            }
            else
            {
                filterTable["Ascending"] = true;
                filterTablepropCount++;
            }

            if (filterTablesortColumnName2 != null)
            {
                filterTable["SortColumnName2"] = CSharpExpressionConverter.ConvertToken(filterTablesortColumnName2);
                filterTablepropCount++;
            }

            if (filterTableascending2 != null)
            {
                if (filterTableascending2 != null)
                {
                    filterTable["Ascending2"] = CSharpExpressionConverter.ConvertToken(filterTableascending2);
                    filterTablepropCount++;
                }

                filterTablepropCount++;
            }
            else
            {
                filterTable["Ascending2"] = true;
                filterTablepropCount++;
            }

            if (filterTablesortColumnName3 != null)
            {
                filterTable["SortColumnName3"] = CSharpExpressionConverter.ConvertToken(filterTablesortColumnName3);
                filterTablepropCount++;
            }

            if (filterTableascending3 != null)
            {
                if (filterTableascending3 != null)
                {
                    filterTable["Ascending3"] = CSharpExpressionConverter.ConvertToken(filterTableascending3);
                    filterTablepropCount++;
                }

                filterTablepropCount++;
            }
            else
            {
                filterTable["Ascending3"] = true;
                filterTablepropCount++;
            }

            if (filterTablepropCount > 0)
            {
                callPayload.Body = filterTable;
            }

            return new ApiConnectionAction<FilterTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<SortTableResponse> SortTable(Expression<Func<JToken[]>> sortTableinputTable, Expression<Func<string>> sortTablesortColumnName, Expression<Func<bool>> sortTableascending, Expression<Func<string>> sortTablesortColumnName2 = null, Expression<Func<bool>> sortTableascending2 = null, Expression<Func<string>> sortTablesortColumnName3 = null, Expression<Func<bool>> sortTableascending3 = null)
        {
            var apiCallPath = "/DynamicCode/SortTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sortTable = new JObject();
            var sortTablepropCount = 0;
            sortTablepropCount++;
            sortTable["InputTable"] = CSharpExpressionConverter.ConvertToken(sortTableinputTable);
            sortTablepropCount++;
            sortTable["SortColumnName"] = CSharpExpressionConverter.ConvertToken(sortTablesortColumnName);
            sortTablepropCount++;
            sortTable["Ascending"] = CSharpExpressionConverter.ConvertToken(sortTableascending);
            if (sortTablesortColumnName2 != null)
            {
                sortTable["SortColumnName2"] = CSharpExpressionConverter.ConvertToken(sortTablesortColumnName2);
                sortTablepropCount++;
            }

            if (sortTableascending2 != null)
            {
                if (sortTableascending2 != null)
                {
                    sortTable["Ascending2"] = CSharpExpressionConverter.ConvertToken(sortTableascending2);
                    sortTablepropCount++;
                }

                sortTablepropCount++;
            }
            else
            {
                sortTable["Ascending2"] = true;
                sortTablepropCount++;
            }

            if (sortTablesortColumnName3 != null)
            {
                sortTable["SortColumnName3"] = CSharpExpressionConverter.ConvertToken(sortTablesortColumnName3);
                sortTablepropCount++;
            }

            if (sortTableascending3 != null)
            {
                if (sortTableascending3 != null)
                {
                    sortTable["Ascending3"] = CSharpExpressionConverter.ConvertToken(sortTableascending3);
                    sortTablepropCount++;
                }

                sortTablepropCount++;
            }
            else
            {
                sortTable["Ascending3"] = true;
                sortTablepropCount++;
            }

            if (sortTablepropCount > 0)
            {
                callPayload.Body = sortTable;
            }

            return new ApiConnectionAction<SortTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<SortJSONTableResponse> SortJSONTable(Expression<Func<string>> sortJSONTablejSONTable, Expression<Func<string>> sortJSONTablesortColumnName, Expression<Func<bool>> sortJSONTableascending = null, Expression<Func<string>> sortJSONTablesortColumnName2 = null, Expression<Func<bool>> sortJSONTableascending2 = null, Expression<Func<string>> sortJSONTablesortColumnName3 = null, Expression<Func<bool>> sortJSONTableascending3 = null)
        {
            var apiCallPath = "/DynamicCode/SortJSONTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sortJSONTable = new JObject();
            var sortJSONTablepropCount = 0;
            sortJSONTablepropCount++;
            sortJSONTable["JSONTable"] = CSharpExpressionConverter.ConvertToken(sortJSONTablejSONTable);
            sortJSONTablepropCount++;
            sortJSONTable["SortColumnName"] = CSharpExpressionConverter.ConvertToken(sortJSONTablesortColumnName);
            if (sortJSONTableascending != null)
            {
                if (sortJSONTableascending != null)
                {
                    sortJSONTable["Ascending"] = CSharpExpressionConverter.ConvertToken(sortJSONTableascending);
                    sortJSONTablepropCount++;
                }

                sortJSONTablepropCount++;
            }
            else
            {
                sortJSONTable["Ascending"] = true;
                sortJSONTablepropCount++;
            }

            if (sortJSONTablesortColumnName2 != null)
            {
                sortJSONTable["SortColumnName2"] = CSharpExpressionConverter.ConvertToken(sortJSONTablesortColumnName2);
                sortJSONTablepropCount++;
            }

            if (sortJSONTableascending2 != null)
            {
                if (sortJSONTableascending2 != null)
                {
                    sortJSONTable["Ascending2"] = CSharpExpressionConverter.ConvertToken(sortJSONTableascending2);
                    sortJSONTablepropCount++;
                }

                sortJSONTablepropCount++;
            }
            else
            {
                sortJSONTable["Ascending2"] = true;
                sortJSONTablepropCount++;
            }

            if (sortJSONTablesortColumnName3 != null)
            {
                sortJSONTable["SortColumnName3"] = CSharpExpressionConverter.ConvertToken(sortJSONTablesortColumnName3);
                sortJSONTablepropCount++;
            }

            if (sortJSONTableascending3 != null)
            {
                if (sortJSONTableascending3 != null)
                {
                    sortJSONTable["Ascending3"] = CSharpExpressionConverter.ConvertToken(sortJSONTableascending3);
                    sortJSONTablepropCount++;
                }

                sortJSONTablepropCount++;
            }
            else
            {
                sortJSONTable["Ascending3"] = true;
                sortJSONTablepropCount++;
            }

            if (sortJSONTablepropCount > 0)
            {
                callPayload.Body = sortJSONTable;
            }

            return new ApiConnectionAction<SortJSONTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetTableFromStringArrayResponse> GetTableFromStringArray(Expression<Func<string[]>> getTableFromStringArrayinputArray, Expression<Func<string>> getTableFromStringArraycolumnName, Expression<Func<bool>> getTableFromStringArraydropEmptyItems = null)
        {
            var apiCallPath = "/DynamicCode/GetTableFromStringArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getTableFromStringArray = new JObject();
            var getTableFromStringArraypropCount = 0;
            getTableFromStringArraypropCount++;
            getTableFromStringArray["InputArray"] = CSharpExpressionConverter.ConvertToken(getTableFromStringArrayinputArray);
            getTableFromStringArraypropCount++;
            getTableFromStringArray["ColumnName"] = CSharpExpressionConverter.ConvertToken(getTableFromStringArraycolumnName);
            if (getTableFromStringArraydropEmptyItems != null)
            {
                if (getTableFromStringArraydropEmptyItems != null)
                {
                    getTableFromStringArray["DropEmptyItems"] = CSharpExpressionConverter.ConvertToken(getTableFromStringArraydropEmptyItems);
                    getTableFromStringArraypropCount++;
                }

                getTableFromStringArraypropCount++;
            }
            else
            {
                getTableFromStringArray["DropEmptyItems"] = false;
                getTableFromStringArraypropCount++;
            }

            if (getTableFromStringArraypropCount > 0)
            {
                callPayload.Body = getTableFromStringArray;
            }

            return new ApiConnectionAction<GetTableFromStringArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetTableFromJSONResponse> GetTableFromJSON(Expression<Func<string>> getTableFromJSONjSONTable, Expression<Func<int>> getTableFromJSONstartRowIndex, Expression<Func<int>> getTableFromJSONnumberOfRowsToRetrieve = null, Expression<Func<int>> getTableFromJSONstartColumnIndex = null, Expression<Func<string>> getTableFromJSONstartColumnName = null, Expression<Func<int>> getTableFromJSONnumberOfColumnsToRetrieve = null)
        {
            var apiCallPath = "/DynamicCode/GetTableFromJSON";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getTableFromJSON = new JObject();
            var getTableFromJSONpropCount = 0;
            getTableFromJSONpropCount++;
            getTableFromJSON["JSONTable"] = CSharpExpressionConverter.ConvertToken(getTableFromJSONjSONTable);
            getTableFromJSONpropCount++;
            getTableFromJSON["StartRowIndex"] = CSharpExpressionConverter.ConvertToken(getTableFromJSONstartRowIndex);
            if (getTableFromJSONnumberOfRowsToRetrieve != null)
            {
                getTableFromJSON["NumberOfRowsToRetrieve"] = CSharpExpressionConverter.ConvertToken(getTableFromJSONnumberOfRowsToRetrieve);
                getTableFromJSONpropCount++;
            }

            if (getTableFromJSONstartColumnIndex != null)
            {
                if (getTableFromJSONstartColumnIndex != null)
                {
                    getTableFromJSON["StartColumnIndex"] = CSharpExpressionConverter.ConvertToken(getTableFromJSONstartColumnIndex);
                    getTableFromJSONpropCount++;
                }

                getTableFromJSONpropCount++;
            }
            else
            {
                getTableFromJSON["StartColumnIndex"] = 1;
                getTableFromJSONpropCount++;
            }

            if (getTableFromJSONstartColumnName != null)
            {
                getTableFromJSON["StartColumnName"] = CSharpExpressionConverter.ConvertToken(getTableFromJSONstartColumnName);
                getTableFromJSONpropCount++;
            }

            if (getTableFromJSONnumberOfColumnsToRetrieve != null)
            {
                getTableFromJSON["NumberOfColumnsToRetrieve"] = CSharpExpressionConverter.ConvertToken(getTableFromJSONnumberOfColumnsToRetrieve);
                getTableFromJSONpropCount++;
            }

            if (getTableFromJSONpropCount > 0)
            {
                callPayload.Body = getTableFromJSON;
            }

            return new ApiConnectionAction<GetTableFromJSONResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<SortStringArrayResponse> SortStringArray(Expression<Func<string[]>> sortStringArrayinputArray, Expression<Func<bool>> sortStringArrayascending = null, Expression<Func<bool>> sortStringArraycaseSensitive = null)
        {
            var apiCallPath = "/DynamicCode/SortStringArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sortStringArray = new JObject();
            var sortStringArraypropCount = 0;
            sortStringArraypropCount++;
            sortStringArray["InputArray"] = CSharpExpressionConverter.ConvertToken(sortStringArrayinputArray);
            if (sortStringArrayascending != null)
            {
                if (sortStringArrayascending != null)
                {
                    sortStringArray["Ascending"] = CSharpExpressionConverter.ConvertToken(sortStringArrayascending);
                    sortStringArraypropCount++;
                }

                sortStringArraypropCount++;
            }
            else
            {
                sortStringArray["Ascending"] = true;
                sortStringArraypropCount++;
            }

            if (sortStringArraycaseSensitive != null)
            {
                if (sortStringArraycaseSensitive != null)
                {
                    sortStringArray["CaseSensitive"] = CSharpExpressionConverter.ConvertToken(sortStringArraycaseSensitive);
                    sortStringArraypropCount++;
                }

                sortStringArraypropCount++;
            }
            else
            {
                sortStringArray["CaseSensitive"] = false;
                sortStringArraypropCount++;
            }

            if (sortStringArraypropCount > 0)
            {
                callPayload.Body = sortStringArray;
            }

            return new ApiConnectionAction<SortStringArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<FilterStringArrayResponse> FilterStringArray(Expression<Func<string[]>> filterStringArrayinputArray, Expression<Func<string>> filterStringArraycolumnName, Expression<Func<string>> filterStringArrayfilter)
        {
            var apiCallPath = "/DynamicCode/FilterStringArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var filterStringArray = new JObject();
            var filterStringArraypropCount = 0;
            filterStringArraypropCount++;
            filterStringArray["InputArray"] = CSharpExpressionConverter.ConvertToken(filterStringArrayinputArray);
            filterStringArraypropCount++;
            filterStringArray["ColumnName"] = CSharpExpressionConverter.ConvertToken(filterStringArraycolumnName);
            filterStringArraypropCount++;
            filterStringArray["Filter"] = CSharpExpressionConverter.ConvertToken(filterStringArrayfilter);
            if (filterStringArraypropCount > 0)
            {
                callPayload.Body = filterStringArray;
            }

            return new ApiConnectionAction<FilterStringArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInStringArrayResponse> InsertRowInStringArray(Expression<Func<string[]>> insertRowInStringArrayinputArray, Expression<Func<int>> insertRowInStringArrayrowIndex, Expression<Func<string>> insertRowInStringArrayvalueToInsert = null)
        {
            var apiCallPath = "/DynamicCode/InsertRowInStringArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var insertRowInStringArray = new JObject();
            var insertRowInStringArraypropCount = 0;
            insertRowInStringArraypropCount++;
            insertRowInStringArray["InputArray"] = CSharpExpressionConverter.ConvertToken(insertRowInStringArrayinputArray);
            insertRowInStringArraypropCount++;
            insertRowInStringArray["RowIndex"] = CSharpExpressionConverter.ConvertToken(insertRowInStringArrayrowIndex);
            if (insertRowInStringArrayvalueToInsert != null)
            {
                insertRowInStringArray["ValueToInsert"] = CSharpExpressionConverter.ConvertToken(insertRowInStringArrayvalueToInsert);
                insertRowInStringArraypropCount++;
            }

            if (insertRowInStringArraypropCount > 0)
            {
                callPayload.Body = insertRowInStringArray;
            }

            return new ApiConnectionAction<InsertRowInStringArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInTableResponse> InsertRowInTable(Expression<Func<JToken[]>> insertRowInTableinputTable, Expression<Func<int>> insertRowInTablerowIndex, Expression<Func<string>> insertRowInTablerowToInsertJSON = null)
        {
            var apiCallPath = "/DynamicCode/InsertRowInTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var insertRowInTable = new JObject();
            var insertRowInTablepropCount = 0;
            insertRowInTablepropCount++;
            insertRowInTable["InputTable"] = CSharpExpressionConverter.ConvertToken(insertRowInTableinputTable);
            insertRowInTablepropCount++;
            insertRowInTable["RowIndex"] = CSharpExpressionConverter.ConvertToken(insertRowInTablerowIndex);
            if (insertRowInTablerowToInsertJSON != null)
            {
                insertRowInTable["RowToInsertJSON"] = CSharpExpressionConverter.ConvertToken(insertRowInTablerowToInsertJSON);
                insertRowInTablepropCount++;
            }

            if (insertRowInTablepropCount > 0)
            {
                callPayload.Body = insertRowInTable;
            }

            return new ApiConnectionAction<InsertRowInTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInJSONTableResponse> InsertRowInJSONTable(Expression<Func<string>> insertRowInJSONTablejSONTable, Expression<Func<int>> insertRowInJSONTablerowIndex, Expression<Func<string>> insertRowInJSONTablerowToInsertJSON = null)
        {
            var apiCallPath = "/DynamicCode/InsertRowInJSONTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var insertRowInJSONTable = new JObject();
            var insertRowInJSONTablepropCount = 0;
            insertRowInJSONTablepropCount++;
            insertRowInJSONTable["JSONTable"] = CSharpExpressionConverter.ConvertToken(insertRowInJSONTablejSONTable);
            insertRowInJSONTablepropCount++;
            insertRowInJSONTable["RowIndex"] = CSharpExpressionConverter.ConvertToken(insertRowInJSONTablerowIndex);
            if (insertRowInJSONTablerowToInsertJSON != null)
            {
                insertRowInJSONTable["RowToInsertJSON"] = CSharpExpressionConverter.ConvertToken(insertRowInJSONTablerowToInsertJSON);
                insertRowInJSONTablepropCount++;
            }

            if (insertRowInJSONTablepropCount > 0)
            {
                callPayload.Body = insertRowInJSONTable;
            }

            return new ApiConnectionAction<InsertRowInJSONTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInJSONTableFromInputVariablesResponse> InsertRowInJSONTableFromInputVariables(Expression<Func<string>> insertRowInJSONTableFromInputVariablesjSONTable, Expression<Func<int>> insertRowInJSONTableFromInputVariablesrowIndex, Expression<Func<insertRowInJSONTableFromInputVariablesrowToInsertInputVariablesInputItem[]>> insertRowInJSONTableFromInputVariablesrowToInsertInputVariables)
        {
            var apiCallPath = "/DynamicCode/InsertRowInJSONTableFromInputVariables";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var insertRowInJSONTableFromInputVariables = new JObject();
            var insertRowInJSONTableFromInputVariablespropCount = 0;
            insertRowInJSONTableFromInputVariablespropCount++;
            insertRowInJSONTableFromInputVariables["JSONTable"] = CSharpExpressionConverter.ConvertToken(insertRowInJSONTableFromInputVariablesjSONTable);
            insertRowInJSONTableFromInputVariablespropCount++;
            insertRowInJSONTableFromInputVariables["RowIndex"] = CSharpExpressionConverter.ConvertToken(insertRowInJSONTableFromInputVariablesrowIndex);
            insertRowInJSONTableFromInputVariablespropCount++;
            insertRowInJSONTableFromInputVariables["RowToInsertInputVariables"] = CSharpExpressionConverter.ConvertToken(insertRowInJSONTableFromInputVariablesrowToInsertInputVariables);
            if (insertRowInJSONTableFromInputVariablespropCount > 0)
            {
                callPayload.Body = insertRowInJSONTableFromInputVariables;
            }

            return new ApiConnectionAction<InsertRowInJSONTableFromInputVariablesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteItemsInStringArrayResponse> DeleteItemsInStringArray(Expression<Func<string[]>> deleteItemsInStringArrayinputArray, Expression<Func<int>> deleteItemsInStringArraystartItemIndex, Expression<Func<int>> deleteItemsInStringArraynumberOfItemsToDelete)
        {
            var apiCallPath = "/DynamicCode/DeleteItemsInStringArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteItemsInStringArray = new JObject();
            var deleteItemsInStringArraypropCount = 0;
            deleteItemsInStringArraypropCount++;
            deleteItemsInStringArray["InputArray"] = CSharpExpressionConverter.ConvertToken(deleteItemsInStringArrayinputArray);
            deleteItemsInStringArraypropCount++;
            deleteItemsInStringArray["StartItemIndex"] = CSharpExpressionConverter.ConvertToken(deleteItemsInStringArraystartItemIndex);
            deleteItemsInStringArraypropCount++;
            deleteItemsInStringArray["NumberOfItemsToDelete"] = CSharpExpressionConverter.ConvertToken(deleteItemsInStringArraynumberOfItemsToDelete);
            if (deleteItemsInStringArraypropCount > 0)
            {
                callPayload.Body = deleteItemsInStringArray;
            }

            return new ApiConnectionAction<DeleteItemsInStringArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteRowsInTableResponse> DeleteRowsInTable(Expression<Func<JToken[]>> deleteRowsInTableinputTable, Expression<Func<int>> deleteRowsInTablestartRowIndex, Expression<Func<int>> deleteRowsInTablenumberOfRowsToDelete)
        {
            var apiCallPath = "/DynamicCode/DeleteRowsInTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteRowsInTable = new JObject();
            var deleteRowsInTablepropCount = 0;
            deleteRowsInTablepropCount++;
            deleteRowsInTable["InputTable"] = CSharpExpressionConverter.ConvertToken(deleteRowsInTableinputTable);
            deleteRowsInTablepropCount++;
            deleteRowsInTable["StartRowIndex"] = CSharpExpressionConverter.ConvertToken(deleteRowsInTablestartRowIndex);
            deleteRowsInTablepropCount++;
            deleteRowsInTable["NumberOfRowsToDelete"] = CSharpExpressionConverter.ConvertToken(deleteRowsInTablenumberOfRowsToDelete);
            if (deleteRowsInTablepropCount > 0)
            {
                callPayload.Body = deleteRowsInTable;
            }

            return new ApiConnectionAction<DeleteRowsInTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteRowsInJSONTableResponse> DeleteRowsInJSONTable(Expression<Func<string>> deleteRowsInJSONTablejSONTable, Expression<Func<int>> deleteRowsInJSONTablestartRowIndex, Expression<Func<int>> deleteRowsInJSONTablenumberOfRowsToDelete)
        {
            var apiCallPath = "/DynamicCode/DeleteRowsInJSONTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteRowsInJSONTable = new JObject();
            var deleteRowsInJSONTablepropCount = 0;
            deleteRowsInJSONTablepropCount++;
            deleteRowsInJSONTable["JSONTable"] = CSharpExpressionConverter.ConvertToken(deleteRowsInJSONTablejSONTable);
            deleteRowsInJSONTablepropCount++;
            deleteRowsInJSONTable["StartRowIndex"] = CSharpExpressionConverter.ConvertToken(deleteRowsInJSONTablestartRowIndex);
            deleteRowsInJSONTablepropCount++;
            deleteRowsInJSONTable["NumberOfRowsToDelete"] = CSharpExpressionConverter.ConvertToken(deleteRowsInJSONTablenumberOfRowsToDelete);
            if (deleteRowsInJSONTablepropCount > 0)
            {
                callPayload.Body = deleteRowsInJSONTable;
            }

            return new ApiConnectionAction<DeleteRowsInJSONTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RenameColumnInTableResponse> RenameColumnInTable(Expression<Func<JToken[]>> renameColumnInTableinputTable, Expression<Func<string>> renameColumnInTablesourceColumnName, Expression<Func<string>> renameColumnInTablenewColumnName)
        {
            var apiCallPath = "/DynamicCode/RenameColumnInTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var renameColumnInTable = new JObject();
            var renameColumnInTablepropCount = 0;
            renameColumnInTablepropCount++;
            renameColumnInTable["InputTable"] = CSharpExpressionConverter.ConvertToken(renameColumnInTableinputTable);
            renameColumnInTablepropCount++;
            renameColumnInTable["SourceColumnName"] = CSharpExpressionConverter.ConvertToken(renameColumnInTablesourceColumnName);
            renameColumnInTablepropCount++;
            renameColumnInTable["NewColumnName"] = CSharpExpressionConverter.ConvertToken(renameColumnInTablenewColumnName);
            if (renameColumnInTablepropCount > 0)
            {
                callPayload.Body = renameColumnInTable;
            }

            return new ApiConnectionAction<RenameColumnInTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RenameColumnInJSONTableResponse> RenameColumnInJSONTable(Expression<Func<string>> renameColumnInJSONTablejSONTable, Expression<Func<string>> renameColumnInJSONTablesourceColumnName, Expression<Func<string>> renameColumnInJSONTablenewColumnName)
        {
            var apiCallPath = "/DynamicCode/RenameColumnInJSONTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var renameColumnInJSONTable = new JObject();
            var renameColumnInJSONTablepropCount = 0;
            renameColumnInJSONTablepropCount++;
            renameColumnInJSONTable["JSONTable"] = CSharpExpressionConverter.ConvertToken(renameColumnInJSONTablejSONTable);
            renameColumnInJSONTablepropCount++;
            renameColumnInJSONTable["SourceColumnName"] = CSharpExpressionConverter.ConvertToken(renameColumnInJSONTablesourceColumnName);
            renameColumnInJSONTablepropCount++;
            renameColumnInJSONTable["NewColumnName"] = CSharpExpressionConverter.ConvertToken(renameColumnInJSONTablenewColumnName);
            if (renameColumnInJSONTablepropCount > 0)
            {
                callPayload.Body = renameColumnInJSONTable;
            }

            return new ApiConnectionAction<RenameColumnInJSONTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteColumnsInTableResponse> DeleteColumnsInTable(Expression<Func<JToken[]>> deleteColumnsInTableinputTable, Expression<Func<int>> deleteColumnsInTablenumberOfColumnsToDelete, Expression<Func<int>> deleteColumnsInTablestartColumnIndex = null, Expression<Func<string>> deleteColumnsInTablecolumnNameToDelete = null)
        {
            var apiCallPath = "/DynamicCode/DeleteColumnsInTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteColumnsInTable = new JObject();
            var deleteColumnsInTablepropCount = 0;
            deleteColumnsInTablepropCount++;
            deleteColumnsInTable["InputTable"] = CSharpExpressionConverter.ConvertToken(deleteColumnsInTableinputTable);
            if (deleteColumnsInTablestartColumnIndex != null)
            {
                deleteColumnsInTable["StartColumnIndex"] = CSharpExpressionConverter.ConvertToken(deleteColumnsInTablestartColumnIndex);
                deleteColumnsInTablepropCount++;
            }

            if (deleteColumnsInTablecolumnNameToDelete != null)
            {
                deleteColumnsInTable["ColumnNameToDelete"] = CSharpExpressionConverter.ConvertToken(deleteColumnsInTablecolumnNameToDelete);
                deleteColumnsInTablepropCount++;
            }

            deleteColumnsInTablepropCount++;
            deleteColumnsInTable["NumberOfColumnsToDelete"] = CSharpExpressionConverter.ConvertToken(deleteColumnsInTablenumberOfColumnsToDelete);
            if (deleteColumnsInTablepropCount > 0)
            {
                callPayload.Body = deleteColumnsInTable;
            }

            return new ApiConnectionAction<DeleteColumnsInTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteColumnsInJSONTableResponse> DeleteColumnsInJSONTable(Expression<Func<string>> deleteColumnsInJSONTablejSONTable, Expression<Func<int>> deleteColumnsInJSONTablenumberOfColumnsToDelete, Expression<Func<int>> deleteColumnsInJSONTablestartColumnIndex = null, Expression<Func<string>> deleteColumnsInJSONTablecolumnNameToDelete = null)
        {
            var apiCallPath = "/DynamicCode/DeleteColumnsInJSONTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteColumnsInJSONTable = new JObject();
            var deleteColumnsInJSONTablepropCount = 0;
            deleteColumnsInJSONTablepropCount++;
            deleteColumnsInJSONTable["JSONTable"] = CSharpExpressionConverter.ConvertToken(deleteColumnsInJSONTablejSONTable);
            if (deleteColumnsInJSONTablestartColumnIndex != null)
            {
                deleteColumnsInJSONTable["StartColumnIndex"] = CSharpExpressionConverter.ConvertToken(deleteColumnsInJSONTablestartColumnIndex);
                deleteColumnsInJSONTablepropCount++;
            }

            if (deleteColumnsInJSONTablecolumnNameToDelete != null)
            {
                deleteColumnsInJSONTable["ColumnNameToDelete"] = CSharpExpressionConverter.ConvertToken(deleteColumnsInJSONTablecolumnNameToDelete);
                deleteColumnsInJSONTablepropCount++;
            }

            deleteColumnsInJSONTablepropCount++;
            deleteColumnsInJSONTable["NumberOfColumnsToDelete"] = CSharpExpressionConverter.ConvertToken(deleteColumnsInJSONTablenumberOfColumnsToDelete);
            if (deleteColumnsInJSONTablepropCount > 0)
            {
                callPayload.Body = deleteColumnsInJSONTable;
            }

            return new ApiConnectionAction<DeleteColumnsInJSONTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringArrayFromTableColumnResponse> GetStringArrayFromTableColumn(Expression<Func<JToken[]>> getStringArrayFromTableColumninputTable, Expression<Func<int>> getStringArrayFromTableColumncolumnIndex = null, Expression<Func<string>> getStringArrayFromTableColumncolumnName = null)
        {
            var apiCallPath = "/DynamicCode/GetStringArrayFromTableColumn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getStringArrayFromTableColumn = new JObject();
            var getStringArrayFromTableColumnpropCount = 0;
            getStringArrayFromTableColumnpropCount++;
            getStringArrayFromTableColumn["InputTable"] = CSharpExpressionConverter.ConvertToken(getStringArrayFromTableColumninputTable);
            if (getStringArrayFromTableColumncolumnIndex != null)
            {
                getStringArrayFromTableColumn["ColumnIndex"] = CSharpExpressionConverter.ConvertToken(getStringArrayFromTableColumncolumnIndex);
                getStringArrayFromTableColumnpropCount++;
            }

            if (getStringArrayFromTableColumncolumnName != null)
            {
                getStringArrayFromTableColumn["ColumnName"] = CSharpExpressionConverter.ConvertToken(getStringArrayFromTableColumncolumnName);
                getStringArrayFromTableColumnpropCount++;
            }

            if (getStringArrayFromTableColumnpropCount > 0)
            {
                callPayload.Body = getStringArrayFromTableColumn;
            }

            return new ApiConnectionAction<GetStringArrayFromTableColumnResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringArrayFromJSONTableColumnResponse> GetStringArrayFromJSONTableColumn(Expression<Func<string>> getStringArrayFromJSONTableColumnjSONTable, Expression<Func<int>> getStringArrayFromJSONTableColumncolumnIndex = null, Expression<Func<string>> getStringArrayFromJSONTableColumncolumnName = null)
        {
            var apiCallPath = "/DynamicCode/GetStringArrayFromJSONTableColumn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getStringArrayFromJSONTableColumn = new JObject();
            var getStringArrayFromJSONTableColumnpropCount = 0;
            getStringArrayFromJSONTableColumnpropCount++;
            getStringArrayFromJSONTableColumn["JSONTable"] = CSharpExpressionConverter.ConvertToken(getStringArrayFromJSONTableColumnjSONTable);
            if (getStringArrayFromJSONTableColumncolumnIndex != null)
            {
                getStringArrayFromJSONTableColumn["ColumnIndex"] = CSharpExpressionConverter.ConvertToken(getStringArrayFromJSONTableColumncolumnIndex);
                getStringArrayFromJSONTableColumnpropCount++;
            }

            if (getStringArrayFromJSONTableColumncolumnName != null)
            {
                getStringArrayFromJSONTableColumn["ColumnName"] = CSharpExpressionConverter.ConvertToken(getStringArrayFromJSONTableColumncolumnName);
                getStringArrayFromJSONTableColumnpropCount++;
            }

            if (getStringArrayFromJSONTableColumnpropCount > 0)
            {
                callPayload.Body = getStringArrayFromJSONTableColumn;
            }

            return new ApiConnectionAction<GetStringArrayFromJSONTableColumnResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringFromJSONTableCellResponse> GetStringFromJSONTableCell(Expression<Func<string>> getStringFromJSONTableCelljSONTable, Expression<Func<int>> getStringFromJSONTableCellrowIndex = null, Expression<Func<int>> getStringFromJSONTableCellcolumnIndex = null, Expression<Func<string>> getStringFromJSONTableCellcolumnName = null, Expression<Func<bool>> getStringFromJSONTableCellfallBackIfCellDoesNotExist = null, Expression<Func<string>> getStringFromJSONTableCellfallbackValue = null)
        {
            var apiCallPath = "/DynamicCode/GetStringFromJSONTableCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getStringFromJSONTableCell = new JObject();
            var getStringFromJSONTableCellpropCount = 0;
            getStringFromJSONTableCellpropCount++;
            getStringFromJSONTableCell["JSONTable"] = CSharpExpressionConverter.ConvertToken(getStringFromJSONTableCelljSONTable);
            if (getStringFromJSONTableCellrowIndex != null)
            {
                getStringFromJSONTableCell["RowIndex"] = CSharpExpressionConverter.ConvertToken(getStringFromJSONTableCellrowIndex);
                getStringFromJSONTableCellpropCount++;
            }

            if (getStringFromJSONTableCellcolumnIndex != null)
            {
                getStringFromJSONTableCell["ColumnIndex"] = CSharpExpressionConverter.ConvertToken(getStringFromJSONTableCellcolumnIndex);
                getStringFromJSONTableCellpropCount++;
            }

            if (getStringFromJSONTableCellcolumnName != null)
            {
                getStringFromJSONTableCell["ColumnName"] = CSharpExpressionConverter.ConvertToken(getStringFromJSONTableCellcolumnName);
                getStringFromJSONTableCellpropCount++;
            }

            if (getStringFromJSONTableCellfallBackIfCellDoesNotExist != null)
            {
                if (getStringFromJSONTableCellfallBackIfCellDoesNotExist != null)
                {
                    getStringFromJSONTableCell["FallBackIfCellDoesNotExist"] = CSharpExpressionConverter.ConvertToken(getStringFromJSONTableCellfallBackIfCellDoesNotExist);
                    getStringFromJSONTableCellpropCount++;
                }

                getStringFromJSONTableCellpropCount++;
            }
            else
            {
                getStringFromJSONTableCell["FallBackIfCellDoesNotExist"] = false;
                getStringFromJSONTableCellpropCount++;
            }

            if (getStringFromJSONTableCellfallbackValue != null)
            {
                getStringFromJSONTableCell["FallbackValue"] = CSharpExpressionConverter.ConvertToken(getStringFromJSONTableCellfallbackValue);
                getStringFromJSONTableCellpropCount++;
            }

            if (getStringFromJSONTableCellpropCount > 0)
            {
                callPayload.Body = getStringFromJSONTableCell;
            }

            return new ApiConnectionAction<GetStringFromJSONTableCellResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringBetweenResponse> GetStringBetween(Expression<Func<string>> getStringBetweeninputString = null, Expression<Func<string>> getStringBetweenstartSearchString = null, Expression<Func<string>> getStringBetweenendSearchString = null, Expression<Func<bool>> getStringBetweensearchLineByLine = null, Expression<Func<bool>> getStringBetweenthrowExceptionIfNotFound = null, Expression<Func<bool>> getStringBetweentrimResult = null, Expression<Func<bool>> getStringBetweensearchIsRegularExpression = null, Expression<Func<bool>> getStringBetweencaseSensitiveSearch = null)
        {
            var apiCallPath = "/DynamicCode/GetStringBetween";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getStringBetween = new JObject();
            var getStringBetweenpropCount = 0;
            if (getStringBetweeninputString != null)
            {
                getStringBetween["InputString"] = CSharpExpressionConverter.ConvertToken(getStringBetweeninputString);
                getStringBetweenpropCount++;
            }

            if (getStringBetweenstartSearchString != null)
            {
                getStringBetween["StartSearchString"] = CSharpExpressionConverter.ConvertToken(getStringBetweenstartSearchString);
                getStringBetweenpropCount++;
            }

            if (getStringBetweenendSearchString != null)
            {
                getStringBetween["EndSearchString"] = CSharpExpressionConverter.ConvertToken(getStringBetweenendSearchString);
                getStringBetweenpropCount++;
            }

            if (getStringBetweensearchLineByLine != null)
            {
                if (getStringBetweensearchLineByLine != null)
                {
                    getStringBetween["SearchLineByLine"] = CSharpExpressionConverter.ConvertToken(getStringBetweensearchLineByLine);
                    getStringBetweenpropCount++;
                }

                getStringBetweenpropCount++;
            }
            else
            {
                getStringBetween["SearchLineByLine"] = true;
                getStringBetweenpropCount++;
            }

            if (getStringBetweenthrowExceptionIfNotFound != null)
            {
                if (getStringBetweenthrowExceptionIfNotFound != null)
                {
                    getStringBetween["ThrowExceptionIfNotFound"] = CSharpExpressionConverter.ConvertToken(getStringBetweenthrowExceptionIfNotFound);
                    getStringBetweenpropCount++;
                }

                getStringBetweenpropCount++;
            }
            else
            {
                getStringBetween["ThrowExceptionIfNotFound"] = true;
                getStringBetweenpropCount++;
            }

            if (getStringBetweentrimResult != null)
            {
                if (getStringBetweentrimResult != null)
                {
                    getStringBetween["TrimResult"] = CSharpExpressionConverter.ConvertToken(getStringBetweentrimResult);
                    getStringBetweenpropCount++;
                }

                getStringBetweenpropCount++;
            }
            else
            {
                getStringBetween["TrimResult"] = true;
                getStringBetweenpropCount++;
            }

            if (getStringBetweensearchIsRegularExpression != null)
            {
                if (getStringBetweensearchIsRegularExpression != null)
                {
                    getStringBetween["SearchIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(getStringBetweensearchIsRegularExpression);
                    getStringBetweenpropCount++;
                }

                getStringBetweenpropCount++;
            }
            else
            {
                getStringBetween["SearchIsRegularExpression"] = false;
                getStringBetweenpropCount++;
            }

            if (getStringBetweencaseSensitiveSearch != null)
            {
                if (getStringBetweencaseSensitiveSearch != null)
                {
                    getStringBetween["CaseSensitiveSearch"] = CSharpExpressionConverter.ConvertToken(getStringBetweencaseSensitiveSearch);
                    getStringBetweenpropCount++;
                }

                getStringBetweenpropCount++;
            }
            else
            {
                getStringBetween["CaseSensitiveSearch"] = false;
                getStringBetweenpropCount++;
            }

            if (getStringBetweenpropCount > 0)
            {
                callPayload.Body = getStringBetween;
            }

            return new ApiConnectionAction<GetStringBetweenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LoadIAConnectLookupTableResponse> LoadIAConnectLookupTable(Expression<Func<string>> loadIAConnectLookupTablepath, Expression<Func<bool>> loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad, Expression<Func<string>> loadIAConnectLookupTableworkflow)
        {
            var apiCallPath = "/DynamicCode/LoadIAConnectLookupTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var loadIAConnectLookupTable = new JObject();
            var loadIAConnectLookupTablepropCount = 0;
            loadIAConnectLookupTablepropCount++;
            loadIAConnectLookupTable["Path"] = CSharpExpressionConverter.ConvertToken(loadIAConnectLookupTablepath);
            loadIAConnectLookupTablepropCount++;
            loadIAConnectLookupTable["RaiseExceptionIfAnyTableFailsToLoad"] = CSharpExpressionConverter.ConvertToken(loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad);
            loadIAConnectLookupTablepropCount++;
            loadIAConnectLookupTable["Workflow"] = CSharpExpressionConverter.ConvertToken(loadIAConnectLookupTableworkflow);
            if (loadIAConnectLookupTablepropCount > 0)
            {
                callPayload.Body = loadIAConnectLookupTable;
            }

            return new ApiConnectionAction<LoadIAConnectLookupTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetIAConnectLookupTableSummaryResponse> GetIAConnectLookupTableSummary(Expression<Func<string>> getIAConnectLookupTableSummaryworkflow)
        {
            var apiCallPath = "/DynamicCode/GetIAConnectLookupTableSummary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getIAConnectLookupTableSummary = new JObject();
            var getIAConnectLookupTableSummarypropCount = 0;
            getIAConnectLookupTableSummarypropCount++;
            getIAConnectLookupTableSummary["Workflow"] = CSharpExpressionConverter.ConvertToken(getIAConnectLookupTableSummaryworkflow);
            if (getIAConnectLookupTableSummarypropCount > 0)
            {
                callPayload.Body = getIAConnectLookupTableSummary;
            }

            return new ApiConnectionAction<GetIAConnectLookupTableSummaryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveIAConnectLookupTableResponse> RemoveIAConnectLookupTable(Expression<Func<string>> removeIAConnectLookupTablelookupTableName, Expression<Func<string>> removeIAConnectLookupTableworkflow)
        {
            var apiCallPath = "/DynamicCode/RemoveIAConnectLookupTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var removeIAConnectLookupTable = new JObject();
            var removeIAConnectLookupTablepropCount = 0;
            removeIAConnectLookupTablepropCount++;
            removeIAConnectLookupTable["LookupTableName"] = CSharpExpressionConverter.ConvertToken(removeIAConnectLookupTablelookupTableName);
            removeIAConnectLookupTablepropCount++;
            removeIAConnectLookupTable["Workflow"] = CSharpExpressionConverter.ConvertToken(removeIAConnectLookupTableworkflow);
            if (removeIAConnectLookupTablepropCount > 0)
            {
                callPayload.Body = removeIAConnectLookupTable;
            }

            return new ApiConnectionAction<RemoveIAConnectLookupTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveAllIAConnectLookupTablesResponse> RemoveAllIAConnectLookupTables(Expression<Func<string>> removeAllIAConnectLookupTablesworkflow)
        {
            var apiCallPath = "/DynamicCode/RemoveAllIAConnectLookupTables";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var removeAllIAConnectLookupTables = new JObject();
            var removeAllIAConnectLookupTablespropCount = 0;
            removeAllIAConnectLookupTablespropCount++;
            removeAllIAConnectLookupTables["Workflow"] = CSharpExpressionConverter.ConvertToken(removeAllIAConnectLookupTablesworkflow);
            if (removeAllIAConnectLookupTablespropCount > 0)
            {
                callPayload.Body = removeAllIAConnectLookupTables;
            }

            return new ApiConnectionAction<RemoveAllIAConnectLookupTablesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LookupValueFromIAConnectLookupTableResponse> LookupValueFromIAConnectLookupTable(Expression<Func<string>> lookupValueFromIAConnectLookupTablelookupTableName, Expression<Func<string>> lookupValueFromIAConnectLookupTablesearchResultValueColumnName, Expression<Func<string>> lookupValueFromIAConnectLookupTableworkflow, Expression<Func<string>> lookupValueFromIAConnectLookupTableinputDataJSON = null, Expression<Func<int>> lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex = null, Expression<Func<bool>> lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch = null)
        {
            var apiCallPath = "/DynamicCode/LookupValueFromIAConnectLookupTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var lookupValueFromIAConnectLookupTable = new JObject();
            var lookupValueFromIAConnectLookupTablepropCount = 0;
            lookupValueFromIAConnectLookupTablepropCount++;
            lookupValueFromIAConnectLookupTable["LookupTableName"] = CSharpExpressionConverter.ConvertToken(lookupValueFromIAConnectLookupTablelookupTableName);
            if (lookupValueFromIAConnectLookupTableinputDataJSON != null)
            {
                lookupValueFromIAConnectLookupTable["InputDataJSON"] = CSharpExpressionConverter.ConvertToken(lookupValueFromIAConnectLookupTableinputDataJSON);
                lookupValueFromIAConnectLookupTablepropCount++;
            }

            lookupValueFromIAConnectLookupTablepropCount++;
            lookupValueFromIAConnectLookupTable["SearchResultValueColumnName"] = CSharpExpressionConverter.ConvertToken(lookupValueFromIAConnectLookupTablesearchResultValueColumnName);
            if (lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex != null)
            {
                if (lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex != null)
                {
                    lookupValueFromIAConnectLookupTable["SearchResultValueColumnIndex"] = CSharpExpressionConverter.ConvertToken(lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex);
                    lookupValueFromIAConnectLookupTablepropCount++;
                }

                lookupValueFromIAConnectLookupTablepropCount++;
            }
            else
            {
                lookupValueFromIAConnectLookupTable["SearchResultValueColumnIndex"] = 1;
                lookupValueFromIAConnectLookupTablepropCount++;
            }

            if (lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
            {
                if (lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                {
                    lookupValueFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = CSharpExpressionConverter.ConvertToken(lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch);
                    lookupValueFromIAConnectLookupTablepropCount++;
                }

                lookupValueFromIAConnectLookupTablepropCount++;
            }
            else
            {
                lookupValueFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = true;
                lookupValueFromIAConnectLookupTablepropCount++;
            }

            lookupValueFromIAConnectLookupTablepropCount++;
            lookupValueFromIAConnectLookupTable["Workflow"] = CSharpExpressionConverter.ConvertToken(lookupValueFromIAConnectLookupTableworkflow);
            if (lookupValueFromIAConnectLookupTablepropCount > 0)
            {
                callPayload.Body = lookupValueFromIAConnectLookupTable;
            }

            return new ApiConnectionAction<LookupValueFromIAConnectLookupTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LookupColumnsFromIAConnectLookupTableResponse> LookupColumnsFromIAConnectLookupTable(Expression<Func<string>> lookupColumnsFromIAConnectLookupTablelookupTableName, Expression<Func<string>> lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName, Expression<Func<string>> lookupColumnsFromIAConnectLookupTableworkflow, Expression<Func<string>> lookupColumnsFromIAConnectLookupTableinputDataJSON = null, Expression<Func<bool>> lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch = null, Expression<Func<bool>> lookupColumnsFromIAConnectLookupTablereturnBlankCells = null, Expression<Func<lookupColumnsFromIAConnectLookupTablereturnFormatInput>> lookupColumnsFromIAConnectLookupTablereturnFormat = null)
        {
            var apiCallPath = "/DynamicCode/LookupColumnsFromIAConnectLookupTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var lookupColumnsFromIAConnectLookupTable = new JObject();
            var lookupColumnsFromIAConnectLookupTablepropCount = 0;
            lookupColumnsFromIAConnectLookupTablepropCount++;
            lookupColumnsFromIAConnectLookupTable["LookupTableName"] = CSharpExpressionConverter.ConvertToken(lookupColumnsFromIAConnectLookupTablelookupTableName);
            if (lookupColumnsFromIAConnectLookupTableinputDataJSON != null)
            {
                lookupColumnsFromIAConnectLookupTable["InputDataJSON"] = CSharpExpressionConverter.ConvertToken(lookupColumnsFromIAConnectLookupTableinputDataJSON);
                lookupColumnsFromIAConnectLookupTablepropCount++;
            }

            lookupColumnsFromIAConnectLookupTablepropCount++;
            lookupColumnsFromIAConnectLookupTable["SearchResultTableColumnName"] = CSharpExpressionConverter.ConvertToken(lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName);
            if (lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
            {
                if (lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                {
                    lookupColumnsFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = CSharpExpressionConverter.ConvertToken(lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch);
                    lookupColumnsFromIAConnectLookupTablepropCount++;
                }

                lookupColumnsFromIAConnectLookupTablepropCount++;
            }
            else
            {
                lookupColumnsFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = true;
                lookupColumnsFromIAConnectLookupTablepropCount++;
            }

            if (lookupColumnsFromIAConnectLookupTablereturnBlankCells != null)
            {
                if (lookupColumnsFromIAConnectLookupTablereturnBlankCells != null)
                {
                    lookupColumnsFromIAConnectLookupTable["ReturnBlankCells"] = CSharpExpressionConverter.ConvertToken(lookupColumnsFromIAConnectLookupTablereturnBlankCells);
                    lookupColumnsFromIAConnectLookupTablepropCount++;
                }

                lookupColumnsFromIAConnectLookupTablepropCount++;
            }
            else
            {
                lookupColumnsFromIAConnectLookupTable["ReturnBlankCells"] = false;
                lookupColumnsFromIAConnectLookupTablepropCount++;
            }

            if (lookupColumnsFromIAConnectLookupTablereturnFormat != null)
            {
                if (lookupColumnsFromIAConnectLookupTablereturnFormat != null)
                {
                    lookupColumnsFromIAConnectLookupTable["ReturnFormat"] = CSharpExpressionConverter.Convert(lookupColumnsFromIAConnectLookupTablereturnFormat);
                    lookupColumnsFromIAConnectLookupTablepropCount++;
                }

                lookupColumnsFromIAConnectLookupTablepropCount++;
            }
            else
            {
                lookupColumnsFromIAConnectLookupTable["ReturnFormat"] = "JSON";
                lookupColumnsFromIAConnectLookupTablepropCount++;
            }

            lookupColumnsFromIAConnectLookupTablepropCount++;
            lookupColumnsFromIAConnectLookupTable["Workflow"] = CSharpExpressionConverter.ConvertToken(lookupColumnsFromIAConnectLookupTableworkflow);
            if (lookupColumnsFromIAConnectLookupTablepropCount > 0)
            {
                callPayload.Body = lookupColumnsFromIAConnectLookupTable;
            }

            return new ApiConnectionAction<LookupColumnsFromIAConnectLookupTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveCharactersFromStringResponse> RemoveCharactersFromString(Expression<Func<string>> removeCharactersFromStringinputString = null, Expression<Func<string>> removeCharactersFromStringcharactersToRemoveFromInputString = null, Expression<Func<bool>> removeCharactersFromStringremoveDiacriticsFromInputString = null, Expression<Func<bool>> removeCharactersFromStringremoveNonAlphaNumericFromInputString = null, Expression<Func<bool>> removeCharactersFromStringremoveNumericFromInputString = null, Expression<Func<bool>> removeCharactersFromStringremoveLowercaseCharactersFromInputString = null, Expression<Func<bool>> removeCharactersFromStringremoveUppercaseCharactersFromInputString = null)
        {
            var apiCallPath = "/DynamicCode/RemoveCharactersFromString";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var removeCharactersFromString = new JObject();
            var removeCharactersFromStringpropCount = 0;
            if (removeCharactersFromStringinputString != null)
            {
                removeCharactersFromString["InputString"] = CSharpExpressionConverter.ConvertToken(removeCharactersFromStringinputString);
                removeCharactersFromStringpropCount++;
            }

            if (removeCharactersFromStringcharactersToRemoveFromInputString != null)
            {
                removeCharactersFromString["CharactersToRemoveFromInputString"] = CSharpExpressionConverter.ConvertToken(removeCharactersFromStringcharactersToRemoveFromInputString);
                removeCharactersFromStringpropCount++;
            }

            if (removeCharactersFromStringremoveDiacriticsFromInputString != null)
            {
                if (removeCharactersFromStringremoveDiacriticsFromInputString != null)
                {
                    removeCharactersFromString["RemoveDiacriticsFromInputString"] = CSharpExpressionConverter.ConvertToken(removeCharactersFromStringremoveDiacriticsFromInputString);
                    removeCharactersFromStringpropCount++;
                }

                removeCharactersFromStringpropCount++;
            }
            else
            {
                removeCharactersFromString["RemoveDiacriticsFromInputString"] = false;
                removeCharactersFromStringpropCount++;
            }

            if (removeCharactersFromStringremoveNonAlphaNumericFromInputString != null)
            {
                if (removeCharactersFromStringremoveNonAlphaNumericFromInputString != null)
                {
                    removeCharactersFromString["RemoveNonAlphaNumericFromInputString"] = CSharpExpressionConverter.ConvertToken(removeCharactersFromStringremoveNonAlphaNumericFromInputString);
                    removeCharactersFromStringpropCount++;
                }

                removeCharactersFromStringpropCount++;
            }
            else
            {
                removeCharactersFromString["RemoveNonAlphaNumericFromInputString"] = false;
                removeCharactersFromStringpropCount++;
            }

            if (removeCharactersFromStringremoveNumericFromInputString != null)
            {
                if (removeCharactersFromStringremoveNumericFromInputString != null)
                {
                    removeCharactersFromString["RemoveNumericFromInputString"] = CSharpExpressionConverter.ConvertToken(removeCharactersFromStringremoveNumericFromInputString);
                    removeCharactersFromStringpropCount++;
                }

                removeCharactersFromStringpropCount++;
            }
            else
            {
                removeCharactersFromString["RemoveNumericFromInputString"] = false;
                removeCharactersFromStringpropCount++;
            }

            if (removeCharactersFromStringremoveLowercaseCharactersFromInputString != null)
            {
                if (removeCharactersFromStringremoveLowercaseCharactersFromInputString != null)
                {
                    removeCharactersFromString["RemoveLowercaseCharactersFromInputString"] = CSharpExpressionConverter.ConvertToken(removeCharactersFromStringremoveLowercaseCharactersFromInputString);
                    removeCharactersFromStringpropCount++;
                }

                removeCharactersFromStringpropCount++;
            }
            else
            {
                removeCharactersFromString["RemoveLowercaseCharactersFromInputString"] = false;
                removeCharactersFromStringpropCount++;
            }

            if (removeCharactersFromStringremoveUppercaseCharactersFromInputString != null)
            {
                if (removeCharactersFromStringremoveUppercaseCharactersFromInputString != null)
                {
                    removeCharactersFromString["RemoveUppercaseCharactersFromInputString"] = CSharpExpressionConverter.ConvertToken(removeCharactersFromStringremoveUppercaseCharactersFromInputString);
                    removeCharactersFromStringpropCount++;
                }

                removeCharactersFromStringpropCount++;
            }
            else
            {
                removeCharactersFromString["RemoveUppercaseCharactersFromInputString"] = false;
                removeCharactersFromStringpropCount++;
            }

            if (removeCharactersFromStringpropCount > 0)
            {
                callPayload.Body = removeCharactersFromString;
            }

            return new ApiConnectionAction<RemoveCharactersFromStringResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetColumnFromIAConnectListResponse> GetColumnFromIAConnectList(Expression<Func<string>> getColumnFromIAConnectListlistName, Expression<Func<int>> getColumnFromIAConnectListsearchColumnIndex = null, Expression<Func<string>> getColumnFromIAConnectListsearchColumnName = null, Expression<Func<bool>> getColumnFromIAConnectListreturnBlankCells = null, Expression<Func<bool>> getColumnFromIAConnectListfallBackIfListDoesNotExist = null, Expression<Func<string>> getColumnFromIAConnectListfallbackValue = null, Expression<Func<getColumnFromIAConnectListreturnFormatInput>> getColumnFromIAConnectListreturnFormat = null)
        {
            var apiCallPath = "/DynamicCode/GetColumnFromIAConnectList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getColumnFromIAConnectList = new JObject();
            var getColumnFromIAConnectListpropCount = 0;
            getColumnFromIAConnectListpropCount++;
            getColumnFromIAConnectList["ListName"] = CSharpExpressionConverter.ConvertToken(getColumnFromIAConnectListlistName);
            if (getColumnFromIAConnectListsearchColumnIndex != null)
            {
                if (getColumnFromIAConnectListsearchColumnIndex != null)
                {
                    getColumnFromIAConnectList["SearchColumnIndex"] = CSharpExpressionConverter.ConvertToken(getColumnFromIAConnectListsearchColumnIndex);
                    getColumnFromIAConnectListpropCount++;
                }

                getColumnFromIAConnectListpropCount++;
            }
            else
            {
                getColumnFromIAConnectList["SearchColumnIndex"] = 1;
                getColumnFromIAConnectListpropCount++;
            }

            if (getColumnFromIAConnectListsearchColumnName != null)
            {
                getColumnFromIAConnectList["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(getColumnFromIAConnectListsearchColumnName);
                getColumnFromIAConnectListpropCount++;
            }

            if (getColumnFromIAConnectListreturnBlankCells != null)
            {
                if (getColumnFromIAConnectListreturnBlankCells != null)
                {
                    getColumnFromIAConnectList["ReturnBlankCells"] = CSharpExpressionConverter.ConvertToken(getColumnFromIAConnectListreturnBlankCells);
                    getColumnFromIAConnectListpropCount++;
                }

                getColumnFromIAConnectListpropCount++;
            }
            else
            {
                getColumnFromIAConnectList["ReturnBlankCells"] = false;
                getColumnFromIAConnectListpropCount++;
            }

            if (getColumnFromIAConnectListfallBackIfListDoesNotExist != null)
            {
                if (getColumnFromIAConnectListfallBackIfListDoesNotExist != null)
                {
                    getColumnFromIAConnectList["FallBackIfListDoesNotExist"] = CSharpExpressionConverter.ConvertToken(getColumnFromIAConnectListfallBackIfListDoesNotExist);
                    getColumnFromIAConnectListpropCount++;
                }

                getColumnFromIAConnectListpropCount++;
            }
            else
            {
                getColumnFromIAConnectList["FallBackIfListDoesNotExist"] = false;
                getColumnFromIAConnectListpropCount++;
            }

            if (getColumnFromIAConnectListfallbackValue != null)
            {
                getColumnFromIAConnectList["FallbackValue"] = CSharpExpressionConverter.ConvertToken(getColumnFromIAConnectListfallbackValue);
                getColumnFromIAConnectListpropCount++;
            }

            if (getColumnFromIAConnectListreturnFormat != null)
            {
                if (getColumnFromIAConnectListreturnFormat != null)
                {
                    getColumnFromIAConnectList["ReturnFormat"] = CSharpExpressionConverter.Convert(getColumnFromIAConnectListreturnFormat);
                    getColumnFromIAConnectListpropCount++;
                }

                getColumnFromIAConnectListpropCount++;
            }
            else
            {
                getColumnFromIAConnectList["ReturnFormat"] = "JSON";
                getColumnFromIAConnectListpropCount++;
            }

            if (getColumnFromIAConnectListpropCount > 0)
            {
                callPayload.Body = getColumnFromIAConnectList;
            }

            return new ApiConnectionAction<GetColumnFromIAConnectListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetIAConnectListContentsResponse> GetIAConnectListContents(Expression<Func<string>> getIAConnectListContentslistName, Expression<Func<getIAConnectListContentsreturnFormatInput>> getIAConnectListContentsreturnFormat = null)
        {
            var apiCallPath = "/DynamicCode/GetIAConnectListContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getIAConnectListContents = new JObject();
            var getIAConnectListContentspropCount = 0;
            getIAConnectListContentspropCount++;
            getIAConnectListContents["ListName"] = CSharpExpressionConverter.ConvertToken(getIAConnectListContentslistName);
            if (getIAConnectListContentsreturnFormat != null)
            {
                if (getIAConnectListContentsreturnFormat != null)
                {
                    getIAConnectListContents["ReturnFormat"] = CSharpExpressionConverter.Convert(getIAConnectListContentsreturnFormat);
                    getIAConnectListContentspropCount++;
                }

                getIAConnectListContentspropCount++;
            }
            else
            {
                getIAConnectListContents["ReturnFormat"] = "JSON";
                getIAConnectListContentspropCount++;
            }

            if (getIAConnectListContentspropCount > 0)
            {
                callPayload.Body = getIAConnectListContents;
            }

            return new ApiConnectionAction<GetIAConnectListContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LookupDataCellsFromIAConnectLookupTableResponse> LookupDataCellsFromIAConnectLookupTable(Expression<Func<string>> lookupDataCellsFromIAConnectLookupTablelookupTableName, Expression<Func<string>> lookupDataCellsFromIAConnectLookupTableinputDataJSON = null, Expression<Func<bool>> lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch = null, Expression<Func<bool>> lookupDataCellsFromIAConnectLookupTablereturnBlankCells = null, Expression<Func<lookupDataCellsFromIAConnectLookupTablereturnFormatInput>> lookupDataCellsFromIAConnectLookupTablereturnFormat = null)
        {
            var apiCallPath = "/DynamicCode/LookupDataCellsFromIAConnectLookupTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var lookupDataCellsFromIAConnectLookupTable = new JObject();
            var lookupDataCellsFromIAConnectLookupTablepropCount = 0;
            lookupDataCellsFromIAConnectLookupTablepropCount++;
            lookupDataCellsFromIAConnectLookupTable["LookupTableName"] = CSharpExpressionConverter.ConvertToken(lookupDataCellsFromIAConnectLookupTablelookupTableName);
            if (lookupDataCellsFromIAConnectLookupTableinputDataJSON != null)
            {
                lookupDataCellsFromIAConnectLookupTable["InputDataJSON"] = CSharpExpressionConverter.ConvertToken(lookupDataCellsFromIAConnectLookupTableinputDataJSON);
                lookupDataCellsFromIAConnectLookupTablepropCount++;
            }

            if (lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
            {
                if (lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                {
                    lookupDataCellsFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = CSharpExpressionConverter.ConvertToken(lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch);
                    lookupDataCellsFromIAConnectLookupTablepropCount++;
                }

                lookupDataCellsFromIAConnectLookupTablepropCount++;
            }
            else
            {
                lookupDataCellsFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = true;
                lookupDataCellsFromIAConnectLookupTablepropCount++;
            }

            if (lookupDataCellsFromIAConnectLookupTablereturnBlankCells != null)
            {
                if (lookupDataCellsFromIAConnectLookupTablereturnBlankCells != null)
                {
                    lookupDataCellsFromIAConnectLookupTable["ReturnBlankCells"] = CSharpExpressionConverter.ConvertToken(lookupDataCellsFromIAConnectLookupTablereturnBlankCells);
                    lookupDataCellsFromIAConnectLookupTablepropCount++;
                }

                lookupDataCellsFromIAConnectLookupTablepropCount++;
            }
            else
            {
                lookupDataCellsFromIAConnectLookupTable["ReturnBlankCells"] = false;
                lookupDataCellsFromIAConnectLookupTablepropCount++;
            }

            if (lookupDataCellsFromIAConnectLookupTablereturnFormat != null)
            {
                if (lookupDataCellsFromIAConnectLookupTablereturnFormat != null)
                {
                    lookupDataCellsFromIAConnectLookupTable["ReturnFormat"] = CSharpExpressionConverter.Convert(lookupDataCellsFromIAConnectLookupTablereturnFormat);
                    lookupDataCellsFromIAConnectLookupTablepropCount++;
                }

                lookupDataCellsFromIAConnectLookupTablepropCount++;
            }
            else
            {
                lookupDataCellsFromIAConnectLookupTable["ReturnFormat"] = "JSON";
                lookupDataCellsFromIAConnectLookupTablepropCount++;
            }

            if (lookupDataCellsFromIAConnectLookupTablepropCount > 0)
            {
                callPayload.Body = lookupDataCellsFromIAConnectLookupTable;
            }

            return new ApiConnectionAction<LookupDataCellsFromIAConnectLookupTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetIAConnectLookupTableContentsResponse> GetIAConnectLookupTableContents(Expression<Func<string>> getIAConnectLookupTableContentslookupTableName, Expression<Func<getIAConnectLookupTableContentsreturnFormatInput>> getIAConnectLookupTableContentsreturnFormat = null)
        {
            var apiCallPath = "/DynamicCode/GetIAConnectLookupTableContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getIAConnectLookupTableContents = new JObject();
            var getIAConnectLookupTableContentspropCount = 0;
            getIAConnectLookupTableContentspropCount++;
            getIAConnectLookupTableContents["LookupTableName"] = CSharpExpressionConverter.ConvertToken(getIAConnectLookupTableContentslookupTableName);
            if (getIAConnectLookupTableContentsreturnFormat != null)
            {
                if (getIAConnectLookupTableContentsreturnFormat != null)
                {
                    getIAConnectLookupTableContents["ReturnFormat"] = CSharpExpressionConverter.Convert(getIAConnectLookupTableContentsreturnFormat);
                    getIAConnectLookupTableContentspropCount++;
                }

                getIAConnectLookupTableContentspropCount++;
            }
            else
            {
                getIAConnectLookupTableContents["ReturnFormat"] = "JSON";
                getIAConnectLookupTableContentspropCount++;
            }

            if (getIAConnectLookupTableContentspropCount > 0)
            {
                callPayload.Body = getIAConnectLookupTableContents;
            }

            return new ApiConnectionAction<GetIAConnectLookupTableContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<UploadCSVToIAConnectLookupTableResponse> UploadCSVToIAConnectLookupTable(Expression<Func<string>> uploadCSVToIAConnectLookupTablelookupTableName, Expression<Func<string>> uploadCSVToIAConnectLookupTablecSVData, Expression<Func<bool>> uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist = null)
        {
            var apiCallPath = "/DynamicCode/UploadCSVToIAConnectLookupTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uploadCSVToIAConnectLookupTable = new JObject();
            var uploadCSVToIAConnectLookupTablepropCount = 0;
            uploadCSVToIAConnectLookupTablepropCount++;
            uploadCSVToIAConnectLookupTable["LookupTableName"] = CSharpExpressionConverter.ConvertToken(uploadCSVToIAConnectLookupTablelookupTableName);
            uploadCSVToIAConnectLookupTablepropCount++;
            uploadCSVToIAConnectLookupTable["CSVData"] = CSharpExpressionConverter.ConvertToken(uploadCSVToIAConnectLookupTablecSVData);
            if (uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist != null)
            {
                if (uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist != null)
                {
                    uploadCSVToIAConnectLookupTable["CreateLookupTableIfNotExist"] = CSharpExpressionConverter.ConvertToken(uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist);
                    uploadCSVToIAConnectLookupTablepropCount++;
                }

                uploadCSVToIAConnectLookupTablepropCount++;
            }
            else
            {
                uploadCSVToIAConnectLookupTable["CreateLookupTableIfNotExist"] = false;
                uploadCSVToIAConnectLookupTablepropCount++;
            }

            if (uploadCSVToIAConnectLookupTablepropCount > 0)
            {
                callPayload.Body = uploadCSVToIAConnectLookupTable;
            }

            return new ApiConnectionAction<UploadCSVToIAConnectLookupTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<UploadCSVToIAConnectListResponse> UploadCSVToIAConnectList(Expression<Func<string>> uploadCSVToIAConnectListlistName, Expression<Func<string>> uploadCSVToIAConnectListcSVData, Expression<Func<bool>> uploadCSVToIAConnectListcreateListIfNotExist = null)
        {
            var apiCallPath = "/DynamicCode/UploadCSVToIAConnectList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uploadCSVToIAConnectList = new JObject();
            var uploadCSVToIAConnectListpropCount = 0;
            uploadCSVToIAConnectListpropCount++;
            uploadCSVToIAConnectList["ListName"] = CSharpExpressionConverter.ConvertToken(uploadCSVToIAConnectListlistName);
            uploadCSVToIAConnectListpropCount++;
            uploadCSVToIAConnectList["CSVData"] = CSharpExpressionConverter.ConvertToken(uploadCSVToIAConnectListcSVData);
            if (uploadCSVToIAConnectListcreateListIfNotExist != null)
            {
                if (uploadCSVToIAConnectListcreateListIfNotExist != null)
                {
                    uploadCSVToIAConnectList["CreateListIfNotExist"] = CSharpExpressionConverter.ConvertToken(uploadCSVToIAConnectListcreateListIfNotExist);
                    uploadCSVToIAConnectListpropCount++;
                }

                uploadCSVToIAConnectListpropCount++;
            }
            else
            {
                uploadCSVToIAConnectList["CreateListIfNotExist"] = false;
                uploadCSVToIAConnectListpropCount++;
            }

            if (uploadCSVToIAConnectListpropCount > 0)
            {
                callPayload.Body = uploadCSVToIAConnectList;
            }

            return new ApiConnectionAction<UploadCSVToIAConnectListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<ConvertArrayToJSONResponse> ConvertArrayToJSON(Expression<Func<JToken[]>> convertArrayToJSONinputObject)
        {
            var apiCallPath = "/DynamicCode/ConvertArrayToJSON";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var convertArrayToJSON = new JObject();
            var convertArrayToJSONpropCount = 0;
            convertArrayToJSONpropCount++;
            convertArrayToJSON["InputObject"] = CSharpExpressionConverter.ConvertToken(convertArrayToJSONinputObject);
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

    public enum runPowerShellAutomationScriptauthenticationMechanismInput
    {
        Basic,
        Credssp,
        Default,
        Digest,
        Kerberos,
        Negotiate
    }

    public class runPowerShellAutomationScriptpowerShellCommandParametersInputItem
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

    public enum getPowerShellVersionauthenticationMechanismInput
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

    public class createJSONFromInputVariablesinputVariablesInputItem
    {
        public string PropertyName { get; set; }
        public createJSONFromInputVariablesinputVariablesInputItemDataTypeType DataType { get; set; }
        public string Value { get; set; }
    }

    public enum createJSONFromInputVariablesinputVariablesInputItemDataTypeType
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

    public class insertRowInJSONTableFromInputVariablesrowToInsertInputVariablesInputItem
    {
        public string PropertyName { get; set; }
        public insertRowInJSONTableFromInputVariablesrowToInsertInputVariablesInputItemDataTypeType DataType { get; set; }
        public string Value { get; set; }
    }

    public enum insertRowInJSONTableFromInputVariablesrowToInsertInputVariablesInputItemDataTypeType
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

    public enum lookupColumnsFromIAConnectLookupTablereturnFormatInput
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

    public enum getColumnFromIAConnectListreturnFormatInput
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

    public enum getIAConnectListContentsreturnFormatInput
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

    public enum lookupDataCellsFromIAConnectLookupTablereturnFormatInput
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

    public enum getIAConnectLookupTableContentsreturnFormatInput
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectdynamiccode;

    public partial class WorkflowManagedActions
    {
        public IaconnectdynamiccodeActions Iaconnectdynamiccode(string connectionId) => new IaconnectdynamiccodeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectdynamiccodeTriggers Iaconnectdynamiccode(string connectionId) => new IaconnectdynamiccodeTriggers(connectionId);
    }
}