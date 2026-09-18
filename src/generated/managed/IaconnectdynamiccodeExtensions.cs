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
        public IWorkflowAction ImportAssemblyFromLocalFile([WorkflowExpression] Func<string> importAssemblyFromLocalFilelocalAssemblyFilePath, [WorkflowExpression] Func<string> importAssemblyFromLocalFileassemblyName, [WorkflowExpression] Func<string> importAssemblyFromLocalFileworkflow, [WorkflowExpression] Func<bool> importAssemblyFromLocalFilecompress = null)
        {
            SourceExpression.Validate(importAssemblyFromLocalFilelocalAssemblyFilePath, nameof(importAssemblyFromLocalFilelocalAssemblyFilePath), required: true);
            SourceExpression.Validate(importAssemblyFromLocalFileassemblyName, nameof(importAssemblyFromLocalFileassemblyName), required: true);
            SourceExpression.Validate(importAssemblyFromLocalFileworkflow, nameof(importAssemblyFromLocalFileworkflow), required: true);
            SourceExpression.Validate(importAssemblyFromLocalFilecompress, nameof(importAssemblyFromLocalFilecompress), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/ImportAssemblyFromLocalFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var importAssemblyFromLocalFile = new JObject();
                var importAssemblyFromLocalFilepropCount = 0;
                importAssemblyFromLocalFilepropCount++;
                importAssemblyFromLocalFile["LocalAssemblyFilePath"] = SourceExpressionConverter.ConvertToken(importAssemblyFromLocalFilelocalAssemblyFilePath);
                importAssemblyFromLocalFilepropCount++;
                importAssemblyFromLocalFile["AssemblyName"] = SourceExpressionConverter.ConvertToken(importAssemblyFromLocalFileassemblyName);
                if (importAssemblyFromLocalFilecompress != null)
                {
                    if (importAssemblyFromLocalFilecompress != null)
                    {
                        importAssemblyFromLocalFile["Compress"] = SourceExpressionConverter.ConvertToken(importAssemblyFromLocalFilecompress);
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
                importAssemblyFromLocalFile["Workflow"] = SourceExpressionConverter.ConvertToken(importAssemblyFromLocalFileworkflow);
                if (importAssemblyFromLocalFilepropCount > 0)
                {
                    callPayload.Body = importAssemblyFromLocalFile;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IWorkflowAction AddAssemblySearchFolder([WorkflowExpression] Func<string> addAssemblySearchFolderfolderPath, [WorkflowExpression] Func<string> addAssemblySearchFolderworkflow)
        {
            SourceExpression.Validate(addAssemblySearchFolderfolderPath, nameof(addAssemblySearchFolderfolderPath), required: true);
            SourceExpression.Validate(addAssemblySearchFolderworkflow, nameof(addAssemblySearchFolderworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/AddAssemblySearchFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addAssemblySearchFolder = new JObject();
                var addAssemblySearchFolderpropCount = 0;
                addAssemblySearchFolderpropCount++;
                addAssemblySearchFolder["FolderPath"] = SourceExpressionConverter.ConvertToken(addAssemblySearchFolderfolderPath);
                addAssemblySearchFolderpropCount++;
                addAssemblySearchFolder["Workflow"] = SourceExpressionConverter.ConvertToken(addAssemblySearchFolderworkflow);
                if (addAssemblySearchFolderpropCount > 0)
                {
                    callPayload.Body = addAssemblySearchFolder;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IWorkflowAction ClearAssemblySearchFolders([WorkflowExpression] Func<string> clearAssemblySearchFoldersworkflow)
        {
            SourceExpression.Validate(clearAssemblySearchFoldersworkflow, nameof(clearAssemblySearchFoldersworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/ClearAssemblySearchFolders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var clearAssemblySearchFolders = new JObject();
                var clearAssemblySearchFolderspropCount = 0;
                clearAssemblySearchFolderspropCount++;
                clearAssemblySearchFolders["Workflow"] = SourceExpressionConverter.ConvertToken(clearAssemblySearchFoldersworkflow);
                if (clearAssemblySearchFolderspropCount > 0)
                {
                    callPayload.Body = clearAssemblySearchFolders;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<IsPowerShellAutomationInstalledResponse> IsPowerShellAutomationInstalled([WorkflowExpression] Func<string> isPowerShellAutomationInstalledworkflow)
        {
            SourceExpression.Validate(isPowerShellAutomationInstalledworkflow, nameof(isPowerShellAutomationInstalledworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/isPowerShellAutomationInstalled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isPowerShellAutomationInstalled = new JObject();
                var isPowerShellAutomationInstalledpropCount = 0;
                isPowerShellAutomationInstalledpropCount++;
                isPowerShellAutomationInstalled["Workflow"] = SourceExpressionConverter.ConvertToken(isPowerShellAutomationInstalledworkflow);
                if (isPowerShellAutomationInstalledpropCount > 0)
                {
                    callPayload.Body = isPowerShellAutomationInstalled;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsPowerShellAutomationInstalledResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<IsPowerShellModuleInstalledResponse> IsPowerShellModuleInstalled([WorkflowExpression] Func<string> isPowerShellModuleInstalledpowerShellModuleName, [WorkflowExpression] Func<string> isPowerShellModuleInstalledworkflow)
        {
            SourceExpression.Validate(isPowerShellModuleInstalledpowerShellModuleName, nameof(isPowerShellModuleInstalledpowerShellModuleName), required: true);
            SourceExpression.Validate(isPowerShellModuleInstalledworkflow, nameof(isPowerShellModuleInstalledworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/isPowerShellModuleInstalled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isPowerShellModuleInstalled = new JObject();
                var isPowerShellModuleInstalledpropCount = 0;
                isPowerShellModuleInstalledpropCount++;
                isPowerShellModuleInstalled["PowerShellModuleName"] = SourceExpressionConverter.ConvertToken(isPowerShellModuleInstalledpowerShellModuleName);
                isPowerShellModuleInstalledpropCount++;
                isPowerShellModuleInstalled["Workflow"] = SourceExpressionConverter.ConvertToken(isPowerShellModuleInstalledworkflow);
                if (isPowerShellModuleInstalledpropCount > 0)
                {
                    callPayload.Body = isPowerShellModuleInstalled;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsPowerShellModuleInstalledResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RunPowerShellAutomationScriptResponse> RunPowerShellAutomationScript([WorkflowExpression] Func<string> runPowerShellAutomationScriptworkflow, [WorkflowExpression] Func<string> runPowerShellAutomationScriptpowerShellScriptContents = null, [WorkflowExpression] Func<string> runPowerShellAutomationScriptcomputerName = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptisNoResultAnError = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptreturnComplexTypes = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptreturnBooleanAsBoolean = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptreturnNumericAsDecimal = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptreturnDateAsDate = null, [WorkflowExpression] Func<string> runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<runPowerShellAutomationScriptauthenticationMechanismInput> runPowerShellAutomationScriptauthenticationMechanism = null, [WorkflowExpression] Func<int> runPowerShellAutomationScriptconnectionAttempts = null, [WorkflowExpression] Func<string> runPowerShellAutomationScriptusername = null, [WorkflowExpression] Func<string> runPowerShellAutomationScriptpassword = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptrunScriptAsThread = null, [WorkflowExpression] Func<int> runPowerShellAutomationScriptretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> runPowerShellAutomationScriptsecondsToWaitForThread = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptscriptContainsStoredPassword = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptlogVerboseOutput = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptreturnSecureStrings = null, [WorkflowExpression] Func<string> runPowerShellAutomationScriptpropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> runPowerShellAutomationScriptpropertyTypesToSerializeJSON = null, [WorkflowExpression] Func<runPowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runPowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            SourceExpression.Validate(runPowerShellAutomationScriptworkflow, nameof(runPowerShellAutomationScriptworkflow), required: true);
            SourceExpression.Validate(runPowerShellAutomationScriptpowerShellScriptContents, nameof(runPowerShellAutomationScriptpowerShellScriptContents), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptcomputerName, nameof(runPowerShellAutomationScriptcomputerName), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptisNoResultAnError, nameof(runPowerShellAutomationScriptisNoResultAnError), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptreturnComplexTypes, nameof(runPowerShellAutomationScriptreturnComplexTypes), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptreturnBooleanAsBoolean, nameof(runPowerShellAutomationScriptreturnBooleanAsBoolean), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptreturnNumericAsDecimal, nameof(runPowerShellAutomationScriptreturnNumericAsDecimal), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptreturnDateAsDate, nameof(runPowerShellAutomationScriptreturnDateAsDate), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON, nameof(runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptauthenticationMechanism, nameof(runPowerShellAutomationScriptauthenticationMechanism), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptconnectionAttempts, nameof(runPowerShellAutomationScriptconnectionAttempts), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptusername, nameof(runPowerShellAutomationScriptusername), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptpassword, nameof(runPowerShellAutomationScriptpassword), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptrunScriptAsThread, nameof(runPowerShellAutomationScriptrunScriptAsThread), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptretrieveOutputDataFromThreadId, nameof(runPowerShellAutomationScriptretrieveOutputDataFromThreadId), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptsecondsToWaitForThread, nameof(runPowerShellAutomationScriptsecondsToWaitForThread), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptscriptContainsStoredPassword, nameof(runPowerShellAutomationScriptscriptContainsStoredPassword), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptlogVerboseOutput, nameof(runPowerShellAutomationScriptlogVerboseOutput), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptreturnSecureStrings, nameof(runPowerShellAutomationScriptreturnSecureStrings), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptpropertyNamesToSerializeJSON, nameof(runPowerShellAutomationScriptpropertyNamesToSerializeJSON), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptpropertyTypesToSerializeJSON, nameof(runPowerShellAutomationScriptpropertyTypesToSerializeJSON), required: false);
            SourceExpression.Validate(runPowerShellAutomationScriptpowerShellCommandParameters, nameof(runPowerShellAutomationScriptpowerShellCommandParameters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/RunPowerShellScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runPowerShellAutomationScript = new JObject();
                var runPowerShellAutomationScriptpropCount = 0;
                if (runPowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runPowerShellAutomationScript["PowerShellScriptContents"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptpowerShellScriptContents);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptcomputerName != null)
                {
                    runPowerShellAutomationScript["ComputerName"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptcomputerName);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (runPowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runPowerShellAutomationScript["IsNoResultAnError"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptisNoResultAnError);
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
                        runPowerShellAutomationScript["ReturnComplexTypes"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptreturnComplexTypes);
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
                        runPowerShellAutomationScript["ReturnBooleanAsBoolean"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptreturnBooleanAsBoolean);
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
                        runPowerShellAutomationScript["ReturnNumericAsDecimal"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptreturnNumericAsDecimal);
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
                        runPowerShellAutomationScript["ReturnDateAsDate"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptreturnDateAsDate);
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
                    runPowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptauthenticationMechanism != null)
                {
                    runPowerShellAutomationScript["AuthenticationMechanism"] = SourceExpressionConverter.Convert(runPowerShellAutomationScriptauthenticationMechanism);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptconnectionAttempts != null)
                {
                    if (runPowerShellAutomationScriptconnectionAttempts != null)
                    {
                        runPowerShellAutomationScript["ConnectionAttempts"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptconnectionAttempts);
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
                    runPowerShellAutomationScript["Username"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptusername);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptpassword != null)
                {
                    runPowerShellAutomationScript["Password"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptpassword);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (runPowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runPowerShellAutomationScript["RunScriptAsThread"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptrunScriptAsThread);
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
                    runPowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (runPowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runPowerShellAutomationScript["SecondsToWaitForThread"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptsecondsToWaitForThread);
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
                        runPowerShellAutomationScript["ScriptContainsStoredPassword"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptscriptContainsStoredPassword);
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
                        runPowerShellAutomationScript["LogVerboseOutput"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptlogVerboseOutput);
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
                        runPowerShellAutomationScript["ReturnSecureStrings"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptreturnSecureStrings);
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
                    runPowerShellAutomationScript["PropertyNamesToSerializeJSON"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runPowerShellAutomationScript["PropertyTypesToSerializeJSON"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runPowerShellAutomationScript["PowerShellCommandParameters"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptpowerShellCommandParameters);
                    runPowerShellAutomationScriptpropCount++;
                }

                runPowerShellAutomationScriptpropCount++;
                runPowerShellAutomationScript["Workflow"] = SourceExpressionConverter.ConvertToken(runPowerShellAutomationScriptworkflow);
                if (runPowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runPowerShellAutomationScript;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RunPowerShellAutomationScriptResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetPowerShellVersionResponse> GetPowerShellVersion([WorkflowExpression] Func<string> getPowerShellVersionworkflow, [WorkflowExpression] Func<string> getPowerShellVersioncomputerName = null, [WorkflowExpression] Func<getPowerShellVersionauthenticationMechanismInput> getPowerShellVersionauthenticationMechanism = null, [WorkflowExpression] Func<int> getPowerShellVersionconnectionAttempts = null)
        {
            SourceExpression.Validate(getPowerShellVersionworkflow, nameof(getPowerShellVersionworkflow), required: true);
            SourceExpression.Validate(getPowerShellVersioncomputerName, nameof(getPowerShellVersioncomputerName), required: false);
            SourceExpression.Validate(getPowerShellVersionauthenticationMechanism, nameof(getPowerShellVersionauthenticationMechanism), required: false);
            SourceExpression.Validate(getPowerShellVersionconnectionAttempts, nameof(getPowerShellVersionconnectionAttempts), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/GetPowerShellVersion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getPowerShellVersion = new JObject();
                var getPowerShellVersionpropCount = 0;
                if (getPowerShellVersioncomputerName != null)
                {
                    getPowerShellVersion["ComputerName"] = SourceExpressionConverter.ConvertToken(getPowerShellVersioncomputerName);
                    getPowerShellVersionpropCount++;
                }

                if (getPowerShellVersionauthenticationMechanism != null)
                {
                    getPowerShellVersion["AuthenticationMechanism"] = SourceExpressionConverter.Convert(getPowerShellVersionauthenticationMechanism);
                    getPowerShellVersionpropCount++;
                }

                if (getPowerShellVersionconnectionAttempts != null)
                {
                    if (getPowerShellVersionconnectionAttempts != null)
                    {
                        getPowerShellVersion["ConnectionAttempts"] = SourceExpressionConverter.ConvertToken(getPowerShellVersionconnectionAttempts);
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
                getPowerShellVersion["Workflow"] = SourceExpressionConverter.ConvertToken(getPowerShellVersionworkflow);
                if (getPowerShellVersionpropCount > 0)
                {
                    callPayload.Body = getPowerShellVersion;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetPowerShellVersionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexMatchResponse> GetRegexMatch([WorkflowExpression] Func<string> getRegexMatchtextToMatch, [WorkflowExpression] Func<string> getRegexMatchregex, [WorkflowExpression] Func<int> getRegexMatchsearchIndex = null, [WorkflowExpression] Func<bool> getRegexMatchcaseSensitive = null, [WorkflowExpression] Func<int> getRegexMatchregexTimeoutInSeconds = null)
        {
            SourceExpression.Validate(getRegexMatchtextToMatch, nameof(getRegexMatchtextToMatch), required: true);
            SourceExpression.Validate(getRegexMatchregex, nameof(getRegexMatchregex), required: true);
            SourceExpression.Validate(getRegexMatchsearchIndex, nameof(getRegexMatchsearchIndex), required: false);
            SourceExpression.Validate(getRegexMatchcaseSensitive, nameof(getRegexMatchcaseSensitive), required: false);
            SourceExpression.Validate(getRegexMatchregexTimeoutInSeconds, nameof(getRegexMatchregexTimeoutInSeconds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetRegexMatch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRegexMatch = new JObject();
                var getRegexMatchpropCount = 0;
                getRegexMatchpropCount++;
                getRegexMatch["TextToMatch"] = SourceExpressionConverter.ConvertToken(getRegexMatchtextToMatch);
                getRegexMatchpropCount++;
                getRegexMatch["Regex"] = SourceExpressionConverter.ConvertToken(getRegexMatchregex);
                if (getRegexMatchsearchIndex != null)
                {
                    if (getRegexMatchsearchIndex != null)
                    {
                        getRegexMatch["SearchIndex"] = SourceExpressionConverter.ConvertToken(getRegexMatchsearchIndex);
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
                        getRegexMatch["CaseSensitive"] = SourceExpressionConverter.ConvertToken(getRegexMatchcaseSensitive);
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
                        getRegexMatch["RegexTimeoutInSeconds"] = SourceExpressionConverter.ConvertToken(getRegexMatchregexTimeoutInSeconds);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetRegexMatchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexMatchesResponse> GetRegexMatches([WorkflowExpression] Func<string> getRegexMatchestextToMatch, [WorkflowExpression] Func<string> getRegexMatchesregex, [WorkflowExpression] Func<int> getRegexMatchesmaximumMatches = null, [WorkflowExpression] Func<bool> getRegexMatchescaseSensitive = null, [WorkflowExpression] Func<bool> getRegexMatchestrimResults = null, [WorkflowExpression] Func<bool> getRegexMatchesremoveEmptyResults = null, [WorkflowExpression] Func<int> getRegexMatchesregexTimeoutInSeconds = null)
        {
            SourceExpression.Validate(getRegexMatchestextToMatch, nameof(getRegexMatchestextToMatch), required: true);
            SourceExpression.Validate(getRegexMatchesregex, nameof(getRegexMatchesregex), required: true);
            SourceExpression.Validate(getRegexMatchesmaximumMatches, nameof(getRegexMatchesmaximumMatches), required: false);
            SourceExpression.Validate(getRegexMatchescaseSensitive, nameof(getRegexMatchescaseSensitive), required: false);
            SourceExpression.Validate(getRegexMatchestrimResults, nameof(getRegexMatchestrimResults), required: false);
            SourceExpression.Validate(getRegexMatchesremoveEmptyResults, nameof(getRegexMatchesremoveEmptyResults), required: false);
            SourceExpression.Validate(getRegexMatchesregexTimeoutInSeconds, nameof(getRegexMatchesregexTimeoutInSeconds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetRegexMatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRegexMatches = new JObject();
                var getRegexMatchespropCount = 0;
                getRegexMatchespropCount++;
                getRegexMatches["TextToMatch"] = SourceExpressionConverter.ConvertToken(getRegexMatchestextToMatch);
                getRegexMatchespropCount++;
                getRegexMatches["Regex"] = SourceExpressionConverter.ConvertToken(getRegexMatchesregex);
                if (getRegexMatchesmaximumMatches != null)
                {
                    if (getRegexMatchesmaximumMatches != null)
                    {
                        getRegexMatches["MaximumMatches"] = SourceExpressionConverter.ConvertToken(getRegexMatchesmaximumMatches);
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
                        getRegexMatches["CaseSensitive"] = SourceExpressionConverter.ConvertToken(getRegexMatchescaseSensitive);
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
                        getRegexMatches["TrimResults"] = SourceExpressionConverter.ConvertToken(getRegexMatchestrimResults);
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
                        getRegexMatches["RemoveEmptyResults"] = SourceExpressionConverter.ConvertToken(getRegexMatchesremoveEmptyResults);
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
                        getRegexMatches["RegexTimeoutInSeconds"] = SourceExpressionConverter.ConvertToken(getRegexMatchesregexTimeoutInSeconds);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetRegexMatchesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexSplitResponse> GetRegexSplit([WorkflowExpression] Func<string> getRegexSplittextToSplit, [WorkflowExpression] Func<string> getRegexSplitregex, [WorkflowExpression] Func<bool> getRegexSplitcaseSensitive = null, [WorkflowExpression] Func<bool> getRegexSplittrimResults = null, [WorkflowExpression] Func<bool> getRegexSplitremoveEmptyResults = null, [WorkflowExpression] Func<int> getRegexSplitregexTimeoutInSeconds = null)
        {
            SourceExpression.Validate(getRegexSplittextToSplit, nameof(getRegexSplittextToSplit), required: true);
            SourceExpression.Validate(getRegexSplitregex, nameof(getRegexSplitregex), required: true);
            SourceExpression.Validate(getRegexSplitcaseSensitive, nameof(getRegexSplitcaseSensitive), required: false);
            SourceExpression.Validate(getRegexSplittrimResults, nameof(getRegexSplittrimResults), required: false);
            SourceExpression.Validate(getRegexSplitremoveEmptyResults, nameof(getRegexSplitremoveEmptyResults), required: false);
            SourceExpression.Validate(getRegexSplitregexTimeoutInSeconds, nameof(getRegexSplitregexTimeoutInSeconds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetRegexSplit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRegexSplit = new JObject();
                var getRegexSplitpropCount = 0;
                getRegexSplitpropCount++;
                getRegexSplit["TextToSplit"] = SourceExpressionConverter.ConvertToken(getRegexSplittextToSplit);
                getRegexSplitpropCount++;
                getRegexSplit["Regex"] = SourceExpressionConverter.ConvertToken(getRegexSplitregex);
                if (getRegexSplitcaseSensitive != null)
                {
                    if (getRegexSplitcaseSensitive != null)
                    {
                        getRegexSplit["CaseSensitive"] = SourceExpressionConverter.ConvertToken(getRegexSplitcaseSensitive);
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
                        getRegexSplit["TrimResults"] = SourceExpressionConverter.ConvertToken(getRegexSplittrimResults);
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
                        getRegexSplit["RemoveEmptyResults"] = SourceExpressionConverter.ConvertToken(getRegexSplitremoveEmptyResults);
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
                        getRegexSplit["RegexTimeoutInSeconds"] = SourceExpressionConverter.ConvertToken(getRegexSplitregexTimeoutInSeconds);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetRegexSplitResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexGroupMatchesResponse> GetRegexGroupMatches([WorkflowExpression] Func<string> getRegexGroupMatchestextToMatch, [WorkflowExpression] Func<string> getRegexGroupMatchesregex, [WorkflowExpression] Func<string[]> getRegexGroupMatchesgroupsToRetrieve = null, [WorkflowExpression] Func<int> getRegexGroupMatchessearchIndex = null, [WorkflowExpression] Func<bool> getRegexGroupMatchescaseSensitive = null, [WorkflowExpression] Func<int> getRegexGroupMatchesregexTimeoutInSeconds = null)
        {
            SourceExpression.Validate(getRegexGroupMatchestextToMatch, nameof(getRegexGroupMatchestextToMatch), required: true);
            SourceExpression.Validate(getRegexGroupMatchesregex, nameof(getRegexGroupMatchesregex), required: true);
            SourceExpression.Validate(getRegexGroupMatchesgroupsToRetrieve, nameof(getRegexGroupMatchesgroupsToRetrieve), required: false);
            SourceExpression.Validate(getRegexGroupMatchessearchIndex, nameof(getRegexGroupMatchessearchIndex), required: false);
            SourceExpression.Validate(getRegexGroupMatchescaseSensitive, nameof(getRegexGroupMatchescaseSensitive), required: false);
            SourceExpression.Validate(getRegexGroupMatchesregexTimeoutInSeconds, nameof(getRegexGroupMatchesregexTimeoutInSeconds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetRegexGroupMatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRegexGroupMatches = new JObject();
                var getRegexGroupMatchespropCount = 0;
                getRegexGroupMatchespropCount++;
                getRegexGroupMatches["TextToMatch"] = SourceExpressionConverter.ConvertToken(getRegexGroupMatchestextToMatch);
                getRegexGroupMatchespropCount++;
                getRegexGroupMatches["Regex"] = SourceExpressionConverter.ConvertToken(getRegexGroupMatchesregex);
                if (getRegexGroupMatchesgroupsToRetrieve != null)
                {
                    getRegexGroupMatches["GroupsToRetrieve"] = SourceExpressionConverter.ConvertToken(getRegexGroupMatchesgroupsToRetrieve);
                    getRegexGroupMatchespropCount++;
                }

                if (getRegexGroupMatchessearchIndex != null)
                {
                    if (getRegexGroupMatchessearchIndex != null)
                    {
                        getRegexGroupMatches["SearchIndex"] = SourceExpressionConverter.ConvertToken(getRegexGroupMatchessearchIndex);
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
                        getRegexGroupMatches["CaseSensitive"] = SourceExpressionConverter.ConvertToken(getRegexGroupMatchescaseSensitive);
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
                        getRegexGroupMatches["RegexTimeoutInSeconds"] = SourceExpressionConverter.ConvertToken(getRegexGroupMatchesregexTimeoutInSeconds);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetRegexGroupMatchesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<CreateJSONFromInputVariablesResponse> CreateJSONFromInputVariables([WorkflowExpression] Func<createJSONFromInputVariablesinputVariablesInputItem[]> createJSONFromInputVariablesinputVariables, [WorkflowExpression] Func<bool> createJSONFromInputVariablesreturnAsJSONTable)
        {
            SourceExpression.Validate(createJSONFromInputVariablesinputVariables, nameof(createJSONFromInputVariablesinputVariables), required: true);
            SourceExpression.Validate(createJSONFromInputVariablesreturnAsJSONTable, nameof(createJSONFromInputVariablesreturnAsJSONTable), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/CreateJSONFromInputVariables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createJSONFromInputVariables = new JObject();
                var createJSONFromInputVariablespropCount = 0;
                createJSONFromInputVariablespropCount++;
                createJSONFromInputVariables["InputVariables"] = SourceExpressionConverter.ConvertToken(createJSONFromInputVariablesinputVariables);
                createJSONFromInputVariablespropCount++;
                createJSONFromInputVariables["ReturnAsJSONTable"] = SourceExpressionConverter.ConvertToken(createJSONFromInputVariablesreturnAsJSONTable);
                if (createJSONFromInputVariablespropCount > 0)
                {
                    callPayload.Body = createJSONFromInputVariables;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateJSONFromInputVariablesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetJSONTableFromStringArrayResponse> GetJSONTableFromStringArray([WorkflowExpression] Func<string[]> getJSONTableFromStringArrayinputArray, [WorkflowExpression] Func<string> getJSONTableFromStringArraycolumnName, [WorkflowExpression] Func<bool> getJSONTableFromStringArraydropEmptyItems = null)
        {
            SourceExpression.Validate(getJSONTableFromStringArrayinputArray, nameof(getJSONTableFromStringArrayinputArray), required: true);
            SourceExpression.Validate(getJSONTableFromStringArraycolumnName, nameof(getJSONTableFromStringArraycolumnName), required: true);
            SourceExpression.Validate(getJSONTableFromStringArraydropEmptyItems, nameof(getJSONTableFromStringArraydropEmptyItems), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetJSONTableFromStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getJSONTableFromStringArray = new JObject();
                var getJSONTableFromStringArraypropCount = 0;
                getJSONTableFromStringArraypropCount++;
                getJSONTableFromStringArray["InputArray"] = SourceExpressionConverter.ConvertToken(getJSONTableFromStringArrayinputArray);
                getJSONTableFromStringArraypropCount++;
                getJSONTableFromStringArray["ColumnName"] = SourceExpressionConverter.ConvertToken(getJSONTableFromStringArraycolumnName);
                if (getJSONTableFromStringArraydropEmptyItems != null)
                {
                    if (getJSONTableFromStringArraydropEmptyItems != null)
                    {
                        getJSONTableFromStringArray["DropEmptyItems"] = SourceExpressionConverter.ConvertToken(getJSONTableFromStringArraydropEmptyItems);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetJSONTableFromStringArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<FilterJSONTableResponse> FilterJSONTable([WorkflowExpression] Func<string> filterJSONTablejSONTable, [WorkflowExpression] Func<string> filterJSONTablefilter, [WorkflowExpression] Func<string> filterJSONTablesortColumnName = null, [WorkflowExpression] Func<bool> filterJSONTableascending = null, [WorkflowExpression] Func<string> filterJSONTablesortColumnName2 = null, [WorkflowExpression] Func<bool> filterJSONTableascending2 = null, [WorkflowExpression] Func<string> filterJSONTablesortColumnName3 = null, [WorkflowExpression] Func<bool> filterJSONTableascending3 = null)
        {
            SourceExpression.Validate(filterJSONTablejSONTable, nameof(filterJSONTablejSONTable), required: true);
            SourceExpression.Validate(filterJSONTablefilter, nameof(filterJSONTablefilter), required: true);
            SourceExpression.Validate(filterJSONTablesortColumnName, nameof(filterJSONTablesortColumnName), required: false);
            SourceExpression.Validate(filterJSONTableascending, nameof(filterJSONTableascending), required: false);
            SourceExpression.Validate(filterJSONTablesortColumnName2, nameof(filterJSONTablesortColumnName2), required: false);
            SourceExpression.Validate(filterJSONTableascending2, nameof(filterJSONTableascending2), required: false);
            SourceExpression.Validate(filterJSONTablesortColumnName3, nameof(filterJSONTablesortColumnName3), required: false);
            SourceExpression.Validate(filterJSONTableascending3, nameof(filterJSONTableascending3), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/FilterJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var filterJSONTable = new JObject();
                var filterJSONTablepropCount = 0;
                filterJSONTablepropCount++;
                filterJSONTable["JSONTable"] = SourceExpressionConverter.ConvertToken(filterJSONTablejSONTable);
                filterJSONTablepropCount++;
                filterJSONTable["Filter"] = SourceExpressionConverter.ConvertToken(filterJSONTablefilter);
                if (filterJSONTablesortColumnName != null)
                {
                    filterJSONTable["SortColumnName"] = SourceExpressionConverter.ConvertToken(filterJSONTablesortColumnName);
                    filterJSONTablepropCount++;
                }

                if (filterJSONTableascending != null)
                {
                    if (filterJSONTableascending != null)
                    {
                        filterJSONTable["Ascending"] = SourceExpressionConverter.ConvertToken(filterJSONTableascending);
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
                    filterJSONTable["SortColumnName2"] = SourceExpressionConverter.ConvertToken(filterJSONTablesortColumnName2);
                    filterJSONTablepropCount++;
                }

                if (filterJSONTableascending2 != null)
                {
                    if (filterJSONTableascending2 != null)
                    {
                        filterJSONTable["Ascending2"] = SourceExpressionConverter.ConvertToken(filterJSONTableascending2);
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
                    filterJSONTable["SortColumnName3"] = SourceExpressionConverter.ConvertToken(filterJSONTablesortColumnName3);
                    filterJSONTablepropCount++;
                }

                if (filterJSONTableascending3 != null)
                {
                    if (filterJSONTableascending3 != null)
                    {
                        filterJSONTable["Ascending3"] = SourceExpressionConverter.ConvertToken(filterJSONTableascending3);
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
                return callPayload;
            }

            return new ApiConnectionAction<FilterJSONTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<FilterTableResponse> FilterTable([WorkflowExpression] Func<JToken[]> filterTableinputTable, [WorkflowExpression] Func<string> filterTablefilter, [WorkflowExpression] Func<string> filterTablesortColumnName = null, [WorkflowExpression] Func<bool> filterTableascending = null, [WorkflowExpression] Func<string> filterTablesortColumnName2 = null, [WorkflowExpression] Func<bool> filterTableascending2 = null, [WorkflowExpression] Func<string> filterTablesortColumnName3 = null, [WorkflowExpression] Func<bool> filterTableascending3 = null)
        {
            SourceExpression.Validate(filterTableinputTable, nameof(filterTableinputTable), required: true);
            SourceExpression.Validate(filterTablefilter, nameof(filterTablefilter), required: true);
            SourceExpression.Validate(filterTablesortColumnName, nameof(filterTablesortColumnName), required: false);
            SourceExpression.Validate(filterTableascending, nameof(filterTableascending), required: false);
            SourceExpression.Validate(filterTablesortColumnName2, nameof(filterTablesortColumnName2), required: false);
            SourceExpression.Validate(filterTableascending2, nameof(filterTableascending2), required: false);
            SourceExpression.Validate(filterTablesortColumnName3, nameof(filterTablesortColumnName3), required: false);
            SourceExpression.Validate(filterTableascending3, nameof(filterTableascending3), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/FilterTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var filterTable = new JObject();
                var filterTablepropCount = 0;
                filterTablepropCount++;
                filterTable["InputTable"] = SourceExpressionConverter.ConvertToken(filterTableinputTable);
                filterTablepropCount++;
                filterTable["Filter"] = SourceExpressionConverter.ConvertToken(filterTablefilter);
                if (filterTablesortColumnName != null)
                {
                    filterTable["SortColumnName"] = SourceExpressionConverter.ConvertToken(filterTablesortColumnName);
                    filterTablepropCount++;
                }

                if (filterTableascending != null)
                {
                    if (filterTableascending != null)
                    {
                        filterTable["Ascending"] = SourceExpressionConverter.ConvertToken(filterTableascending);
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
                    filterTable["SortColumnName2"] = SourceExpressionConverter.ConvertToken(filterTablesortColumnName2);
                    filterTablepropCount++;
                }

                if (filterTableascending2 != null)
                {
                    if (filterTableascending2 != null)
                    {
                        filterTable["Ascending2"] = SourceExpressionConverter.ConvertToken(filterTableascending2);
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
                    filterTable["SortColumnName3"] = SourceExpressionConverter.ConvertToken(filterTablesortColumnName3);
                    filterTablepropCount++;
                }

                if (filterTableascending3 != null)
                {
                    if (filterTableascending3 != null)
                    {
                        filterTable["Ascending3"] = SourceExpressionConverter.ConvertToken(filterTableascending3);
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
                return callPayload;
            }

            return new ApiConnectionAction<FilterTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<SortTableResponse> SortTable([WorkflowExpression] Func<JToken[]> sortTableinputTable, [WorkflowExpression] Func<string> sortTablesortColumnName, [WorkflowExpression] Func<bool> sortTableascending, [WorkflowExpression] Func<string> sortTablesortColumnName2 = null, [WorkflowExpression] Func<bool> sortTableascending2 = null, [WorkflowExpression] Func<string> sortTablesortColumnName3 = null, [WorkflowExpression] Func<bool> sortTableascending3 = null)
        {
            SourceExpression.Validate(sortTableinputTable, nameof(sortTableinputTable), required: true);
            SourceExpression.Validate(sortTablesortColumnName, nameof(sortTablesortColumnName), required: true);
            SourceExpression.Validate(sortTableascending, nameof(sortTableascending), required: true);
            SourceExpression.Validate(sortTablesortColumnName2, nameof(sortTablesortColumnName2), required: false);
            SourceExpression.Validate(sortTableascending2, nameof(sortTableascending2), required: false);
            SourceExpression.Validate(sortTablesortColumnName3, nameof(sortTablesortColumnName3), required: false);
            SourceExpression.Validate(sortTableascending3, nameof(sortTableascending3), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/SortTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sortTable = new JObject();
                var sortTablepropCount = 0;
                sortTablepropCount++;
                sortTable["InputTable"] = SourceExpressionConverter.ConvertToken(sortTableinputTable);
                sortTablepropCount++;
                sortTable["SortColumnName"] = SourceExpressionConverter.ConvertToken(sortTablesortColumnName);
                sortTablepropCount++;
                sortTable["Ascending"] = SourceExpressionConverter.ConvertToken(sortTableascending);
                if (sortTablesortColumnName2 != null)
                {
                    sortTable["SortColumnName2"] = SourceExpressionConverter.ConvertToken(sortTablesortColumnName2);
                    sortTablepropCount++;
                }

                if (sortTableascending2 != null)
                {
                    if (sortTableascending2 != null)
                    {
                        sortTable["Ascending2"] = SourceExpressionConverter.ConvertToken(sortTableascending2);
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
                    sortTable["SortColumnName3"] = SourceExpressionConverter.ConvertToken(sortTablesortColumnName3);
                    sortTablepropCount++;
                }

                if (sortTableascending3 != null)
                {
                    if (sortTableascending3 != null)
                    {
                        sortTable["Ascending3"] = SourceExpressionConverter.ConvertToken(sortTableascending3);
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
                return callPayload;
            }

            return new ApiConnectionAction<SortTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<SortJSONTableResponse> SortJSONTable([WorkflowExpression] Func<string> sortJSONTablejSONTable, [WorkflowExpression] Func<string> sortJSONTablesortColumnName, [WorkflowExpression] Func<bool> sortJSONTableascending = null, [WorkflowExpression] Func<string> sortJSONTablesortColumnName2 = null, [WorkflowExpression] Func<bool> sortJSONTableascending2 = null, [WorkflowExpression] Func<string> sortJSONTablesortColumnName3 = null, [WorkflowExpression] Func<bool> sortJSONTableascending3 = null)
        {
            SourceExpression.Validate(sortJSONTablejSONTable, nameof(sortJSONTablejSONTable), required: true);
            SourceExpression.Validate(sortJSONTablesortColumnName, nameof(sortJSONTablesortColumnName), required: true);
            SourceExpression.Validate(sortJSONTableascending, nameof(sortJSONTableascending), required: false);
            SourceExpression.Validate(sortJSONTablesortColumnName2, nameof(sortJSONTablesortColumnName2), required: false);
            SourceExpression.Validate(sortJSONTableascending2, nameof(sortJSONTableascending2), required: false);
            SourceExpression.Validate(sortJSONTablesortColumnName3, nameof(sortJSONTablesortColumnName3), required: false);
            SourceExpression.Validate(sortJSONTableascending3, nameof(sortJSONTableascending3), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/SortJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sortJSONTable = new JObject();
                var sortJSONTablepropCount = 0;
                sortJSONTablepropCount++;
                sortJSONTable["JSONTable"] = SourceExpressionConverter.ConvertToken(sortJSONTablejSONTable);
                sortJSONTablepropCount++;
                sortJSONTable["SortColumnName"] = SourceExpressionConverter.ConvertToken(sortJSONTablesortColumnName);
                if (sortJSONTableascending != null)
                {
                    if (sortJSONTableascending != null)
                    {
                        sortJSONTable["Ascending"] = SourceExpressionConverter.ConvertToken(sortJSONTableascending);
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
                    sortJSONTable["SortColumnName2"] = SourceExpressionConverter.ConvertToken(sortJSONTablesortColumnName2);
                    sortJSONTablepropCount++;
                }

                if (sortJSONTableascending2 != null)
                {
                    if (sortJSONTableascending2 != null)
                    {
                        sortJSONTable["Ascending2"] = SourceExpressionConverter.ConvertToken(sortJSONTableascending2);
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
                    sortJSONTable["SortColumnName3"] = SourceExpressionConverter.ConvertToken(sortJSONTablesortColumnName3);
                    sortJSONTablepropCount++;
                }

                if (sortJSONTableascending3 != null)
                {
                    if (sortJSONTableascending3 != null)
                    {
                        sortJSONTable["Ascending3"] = SourceExpressionConverter.ConvertToken(sortJSONTableascending3);
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
                return callPayload;
            }

            return new ApiConnectionAction<SortJSONTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetTableFromStringArrayResponse> GetTableFromStringArray([WorkflowExpression] Func<string[]> getTableFromStringArrayinputArray, [WorkflowExpression] Func<string> getTableFromStringArraycolumnName, [WorkflowExpression] Func<bool> getTableFromStringArraydropEmptyItems = null)
        {
            SourceExpression.Validate(getTableFromStringArrayinputArray, nameof(getTableFromStringArrayinputArray), required: true);
            SourceExpression.Validate(getTableFromStringArraycolumnName, nameof(getTableFromStringArraycolumnName), required: true);
            SourceExpression.Validate(getTableFromStringArraydropEmptyItems, nameof(getTableFromStringArraydropEmptyItems), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetTableFromStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getTableFromStringArray = new JObject();
                var getTableFromStringArraypropCount = 0;
                getTableFromStringArraypropCount++;
                getTableFromStringArray["InputArray"] = SourceExpressionConverter.ConvertToken(getTableFromStringArrayinputArray);
                getTableFromStringArraypropCount++;
                getTableFromStringArray["ColumnName"] = SourceExpressionConverter.ConvertToken(getTableFromStringArraycolumnName);
                if (getTableFromStringArraydropEmptyItems != null)
                {
                    if (getTableFromStringArraydropEmptyItems != null)
                    {
                        getTableFromStringArray["DropEmptyItems"] = SourceExpressionConverter.ConvertToken(getTableFromStringArraydropEmptyItems);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetTableFromStringArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetTableFromJSONResponse> GetTableFromJSON([WorkflowExpression] Func<string> getTableFromJSONjSONTable, [WorkflowExpression] Func<int> getTableFromJSONstartRowIndex, [WorkflowExpression] Func<int> getTableFromJSONnumberOfRowsToRetrieve = null, [WorkflowExpression] Func<int> getTableFromJSONstartColumnIndex = null, [WorkflowExpression] Func<string> getTableFromJSONstartColumnName = null, [WorkflowExpression] Func<int> getTableFromJSONnumberOfColumnsToRetrieve = null)
        {
            SourceExpression.Validate(getTableFromJSONjSONTable, nameof(getTableFromJSONjSONTable), required: true);
            SourceExpression.Validate(getTableFromJSONstartRowIndex, nameof(getTableFromJSONstartRowIndex), required: true);
            SourceExpression.Validate(getTableFromJSONnumberOfRowsToRetrieve, nameof(getTableFromJSONnumberOfRowsToRetrieve), required: false);
            SourceExpression.Validate(getTableFromJSONstartColumnIndex, nameof(getTableFromJSONstartColumnIndex), required: false);
            SourceExpression.Validate(getTableFromJSONstartColumnName, nameof(getTableFromJSONstartColumnName), required: false);
            SourceExpression.Validate(getTableFromJSONnumberOfColumnsToRetrieve, nameof(getTableFromJSONnumberOfColumnsToRetrieve), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetTableFromJSON";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getTableFromJSON = new JObject();
                var getTableFromJSONpropCount = 0;
                getTableFromJSONpropCount++;
                getTableFromJSON["JSONTable"] = SourceExpressionConverter.ConvertToken(getTableFromJSONjSONTable);
                getTableFromJSONpropCount++;
                getTableFromJSON["StartRowIndex"] = SourceExpressionConverter.ConvertToken(getTableFromJSONstartRowIndex);
                if (getTableFromJSONnumberOfRowsToRetrieve != null)
                {
                    getTableFromJSON["NumberOfRowsToRetrieve"] = SourceExpressionConverter.ConvertToken(getTableFromJSONnumberOfRowsToRetrieve);
                    getTableFromJSONpropCount++;
                }

                if (getTableFromJSONstartColumnIndex != null)
                {
                    if (getTableFromJSONstartColumnIndex != null)
                    {
                        getTableFromJSON["StartColumnIndex"] = SourceExpressionConverter.ConvertToken(getTableFromJSONstartColumnIndex);
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
                    getTableFromJSON["StartColumnName"] = SourceExpressionConverter.ConvertToken(getTableFromJSONstartColumnName);
                    getTableFromJSONpropCount++;
                }

                if (getTableFromJSONnumberOfColumnsToRetrieve != null)
                {
                    getTableFromJSON["NumberOfColumnsToRetrieve"] = SourceExpressionConverter.ConvertToken(getTableFromJSONnumberOfColumnsToRetrieve);
                    getTableFromJSONpropCount++;
                }

                if (getTableFromJSONpropCount > 0)
                {
                    callPayload.Body = getTableFromJSON;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetTableFromJSONResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<SortStringArrayResponse> SortStringArray([WorkflowExpression] Func<string[]> sortStringArrayinputArray, [WorkflowExpression] Func<bool> sortStringArrayascending = null, [WorkflowExpression] Func<bool> sortStringArraycaseSensitive = null)
        {
            SourceExpression.Validate(sortStringArrayinputArray, nameof(sortStringArrayinputArray), required: true);
            SourceExpression.Validate(sortStringArrayascending, nameof(sortStringArrayascending), required: false);
            SourceExpression.Validate(sortStringArraycaseSensitive, nameof(sortStringArraycaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/SortStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sortStringArray = new JObject();
                var sortStringArraypropCount = 0;
                sortStringArraypropCount++;
                sortStringArray["InputArray"] = SourceExpressionConverter.ConvertToken(sortStringArrayinputArray);
                if (sortStringArrayascending != null)
                {
                    if (sortStringArrayascending != null)
                    {
                        sortStringArray["Ascending"] = SourceExpressionConverter.ConvertToken(sortStringArrayascending);
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
                        sortStringArray["CaseSensitive"] = SourceExpressionConverter.ConvertToken(sortStringArraycaseSensitive);
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
                return callPayload;
            }

            return new ApiConnectionAction<SortStringArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<FilterStringArrayResponse> FilterStringArray([WorkflowExpression] Func<string[]> filterStringArrayinputArray, [WorkflowExpression] Func<string> filterStringArraycolumnName, [WorkflowExpression] Func<string> filterStringArrayfilter)
        {
            SourceExpression.Validate(filterStringArrayinputArray, nameof(filterStringArrayinputArray), required: true);
            SourceExpression.Validate(filterStringArraycolumnName, nameof(filterStringArraycolumnName), required: true);
            SourceExpression.Validate(filterStringArrayfilter, nameof(filterStringArrayfilter), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/FilterStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var filterStringArray = new JObject();
                var filterStringArraypropCount = 0;
                filterStringArraypropCount++;
                filterStringArray["InputArray"] = SourceExpressionConverter.ConvertToken(filterStringArrayinputArray);
                filterStringArraypropCount++;
                filterStringArray["ColumnName"] = SourceExpressionConverter.ConvertToken(filterStringArraycolumnName);
                filterStringArraypropCount++;
                filterStringArray["Filter"] = SourceExpressionConverter.ConvertToken(filterStringArrayfilter);
                if (filterStringArraypropCount > 0)
                {
                    callPayload.Body = filterStringArray;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FilterStringArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInStringArrayResponse> InsertRowInStringArray([WorkflowExpression] Func<string[]> insertRowInStringArrayinputArray, [WorkflowExpression] Func<int> insertRowInStringArrayrowIndex, [WorkflowExpression] Func<string> insertRowInStringArrayvalueToInsert = null)
        {
            SourceExpression.Validate(insertRowInStringArrayinputArray, nameof(insertRowInStringArrayinputArray), required: true);
            SourceExpression.Validate(insertRowInStringArrayrowIndex, nameof(insertRowInStringArrayrowIndex), required: true);
            SourceExpression.Validate(insertRowInStringArrayvalueToInsert, nameof(insertRowInStringArrayvalueToInsert), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/InsertRowInStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var insertRowInStringArray = new JObject();
                var insertRowInStringArraypropCount = 0;
                insertRowInStringArraypropCount++;
                insertRowInStringArray["InputArray"] = SourceExpressionConverter.ConvertToken(insertRowInStringArrayinputArray);
                insertRowInStringArraypropCount++;
                insertRowInStringArray["RowIndex"] = SourceExpressionConverter.ConvertToken(insertRowInStringArrayrowIndex);
                if (insertRowInStringArrayvalueToInsert != null)
                {
                    insertRowInStringArray["ValueToInsert"] = SourceExpressionConverter.ConvertToken(insertRowInStringArrayvalueToInsert);
                    insertRowInStringArraypropCount++;
                }

                if (insertRowInStringArraypropCount > 0)
                {
                    callPayload.Body = insertRowInStringArray;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InsertRowInStringArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInTableResponse> InsertRowInTable([WorkflowExpression] Func<JToken[]> insertRowInTableinputTable, [WorkflowExpression] Func<int> insertRowInTablerowIndex, [WorkflowExpression] Func<string> insertRowInTablerowToInsertJSON = null)
        {
            SourceExpression.Validate(insertRowInTableinputTable, nameof(insertRowInTableinputTable), required: true);
            SourceExpression.Validate(insertRowInTablerowIndex, nameof(insertRowInTablerowIndex), required: true);
            SourceExpression.Validate(insertRowInTablerowToInsertJSON, nameof(insertRowInTablerowToInsertJSON), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/InsertRowInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var insertRowInTable = new JObject();
                var insertRowInTablepropCount = 0;
                insertRowInTablepropCount++;
                insertRowInTable["InputTable"] = SourceExpressionConverter.ConvertToken(insertRowInTableinputTable);
                insertRowInTablepropCount++;
                insertRowInTable["RowIndex"] = SourceExpressionConverter.ConvertToken(insertRowInTablerowIndex);
                if (insertRowInTablerowToInsertJSON != null)
                {
                    insertRowInTable["RowToInsertJSON"] = SourceExpressionConverter.ConvertToken(insertRowInTablerowToInsertJSON);
                    insertRowInTablepropCount++;
                }

                if (insertRowInTablepropCount > 0)
                {
                    callPayload.Body = insertRowInTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InsertRowInTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInJSONTableResponse> InsertRowInJSONTable([WorkflowExpression] Func<string> insertRowInJSONTablejSONTable, [WorkflowExpression] Func<int> insertRowInJSONTablerowIndex, [WorkflowExpression] Func<string> insertRowInJSONTablerowToInsertJSON = null)
        {
            SourceExpression.Validate(insertRowInJSONTablejSONTable, nameof(insertRowInJSONTablejSONTable), required: true);
            SourceExpression.Validate(insertRowInJSONTablerowIndex, nameof(insertRowInJSONTablerowIndex), required: true);
            SourceExpression.Validate(insertRowInJSONTablerowToInsertJSON, nameof(insertRowInJSONTablerowToInsertJSON), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/InsertRowInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var insertRowInJSONTable = new JObject();
                var insertRowInJSONTablepropCount = 0;
                insertRowInJSONTablepropCount++;
                insertRowInJSONTable["JSONTable"] = SourceExpressionConverter.ConvertToken(insertRowInJSONTablejSONTable);
                insertRowInJSONTablepropCount++;
                insertRowInJSONTable["RowIndex"] = SourceExpressionConverter.ConvertToken(insertRowInJSONTablerowIndex);
                if (insertRowInJSONTablerowToInsertJSON != null)
                {
                    insertRowInJSONTable["RowToInsertJSON"] = SourceExpressionConverter.ConvertToken(insertRowInJSONTablerowToInsertJSON);
                    insertRowInJSONTablepropCount++;
                }

                if (insertRowInJSONTablepropCount > 0)
                {
                    callPayload.Body = insertRowInJSONTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InsertRowInJSONTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInJSONTableFromInputVariablesResponse> InsertRowInJSONTableFromInputVariables([WorkflowExpression] Func<string> insertRowInJSONTableFromInputVariablesjSONTable, [WorkflowExpression] Func<int> insertRowInJSONTableFromInputVariablesrowIndex, [WorkflowExpression] Func<insertRowInJSONTableFromInputVariablesrowToInsertInputVariablesInputItem[]> insertRowInJSONTableFromInputVariablesrowToInsertInputVariables)
        {
            SourceExpression.Validate(insertRowInJSONTableFromInputVariablesjSONTable, nameof(insertRowInJSONTableFromInputVariablesjSONTable), required: true);
            SourceExpression.Validate(insertRowInJSONTableFromInputVariablesrowIndex, nameof(insertRowInJSONTableFromInputVariablesrowIndex), required: true);
            SourceExpression.Validate(insertRowInJSONTableFromInputVariablesrowToInsertInputVariables, nameof(insertRowInJSONTableFromInputVariablesrowToInsertInputVariables), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/InsertRowInJSONTableFromInputVariables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var insertRowInJSONTableFromInputVariables = new JObject();
                var insertRowInJSONTableFromInputVariablespropCount = 0;
                insertRowInJSONTableFromInputVariablespropCount++;
                insertRowInJSONTableFromInputVariables["JSONTable"] = SourceExpressionConverter.ConvertToken(insertRowInJSONTableFromInputVariablesjSONTable);
                insertRowInJSONTableFromInputVariablespropCount++;
                insertRowInJSONTableFromInputVariables["RowIndex"] = SourceExpressionConverter.ConvertToken(insertRowInJSONTableFromInputVariablesrowIndex);
                insertRowInJSONTableFromInputVariablespropCount++;
                insertRowInJSONTableFromInputVariables["RowToInsertInputVariables"] = SourceExpressionConverter.ConvertToken(insertRowInJSONTableFromInputVariablesrowToInsertInputVariables);
                if (insertRowInJSONTableFromInputVariablespropCount > 0)
                {
                    callPayload.Body = insertRowInJSONTableFromInputVariables;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InsertRowInJSONTableFromInputVariablesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteItemsInStringArrayResponse> DeleteItemsInStringArray([WorkflowExpression] Func<string[]> deleteItemsInStringArrayinputArray, [WorkflowExpression] Func<int> deleteItemsInStringArraystartItemIndex, [WorkflowExpression] Func<int> deleteItemsInStringArraynumberOfItemsToDelete)
        {
            SourceExpression.Validate(deleteItemsInStringArrayinputArray, nameof(deleteItemsInStringArrayinputArray), required: true);
            SourceExpression.Validate(deleteItemsInStringArraystartItemIndex, nameof(deleteItemsInStringArraystartItemIndex), required: true);
            SourceExpression.Validate(deleteItemsInStringArraynumberOfItemsToDelete, nameof(deleteItemsInStringArraynumberOfItemsToDelete), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/DeleteItemsInStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteItemsInStringArray = new JObject();
                var deleteItemsInStringArraypropCount = 0;
                deleteItemsInStringArraypropCount++;
                deleteItemsInStringArray["InputArray"] = SourceExpressionConverter.ConvertToken(deleteItemsInStringArrayinputArray);
                deleteItemsInStringArraypropCount++;
                deleteItemsInStringArray["StartItemIndex"] = SourceExpressionConverter.ConvertToken(deleteItemsInStringArraystartItemIndex);
                deleteItemsInStringArraypropCount++;
                deleteItemsInStringArray["NumberOfItemsToDelete"] = SourceExpressionConverter.ConvertToken(deleteItemsInStringArraynumberOfItemsToDelete);
                if (deleteItemsInStringArraypropCount > 0)
                {
                    callPayload.Body = deleteItemsInStringArray;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteItemsInStringArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteRowsInTableResponse> DeleteRowsInTable([WorkflowExpression] Func<JToken[]> deleteRowsInTableinputTable, [WorkflowExpression] Func<int> deleteRowsInTablestartRowIndex, [WorkflowExpression] Func<int> deleteRowsInTablenumberOfRowsToDelete)
        {
            SourceExpression.Validate(deleteRowsInTableinputTable, nameof(deleteRowsInTableinputTable), required: true);
            SourceExpression.Validate(deleteRowsInTablestartRowIndex, nameof(deleteRowsInTablestartRowIndex), required: true);
            SourceExpression.Validate(deleteRowsInTablenumberOfRowsToDelete, nameof(deleteRowsInTablenumberOfRowsToDelete), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/DeleteRowsInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteRowsInTable = new JObject();
                var deleteRowsInTablepropCount = 0;
                deleteRowsInTablepropCount++;
                deleteRowsInTable["InputTable"] = SourceExpressionConverter.ConvertToken(deleteRowsInTableinputTable);
                deleteRowsInTablepropCount++;
                deleteRowsInTable["StartRowIndex"] = SourceExpressionConverter.ConvertToken(deleteRowsInTablestartRowIndex);
                deleteRowsInTablepropCount++;
                deleteRowsInTable["NumberOfRowsToDelete"] = SourceExpressionConverter.ConvertToken(deleteRowsInTablenumberOfRowsToDelete);
                if (deleteRowsInTablepropCount > 0)
                {
                    callPayload.Body = deleteRowsInTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteRowsInTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteRowsInJSONTableResponse> DeleteRowsInJSONTable([WorkflowExpression] Func<string> deleteRowsInJSONTablejSONTable, [WorkflowExpression] Func<int> deleteRowsInJSONTablestartRowIndex, [WorkflowExpression] Func<int> deleteRowsInJSONTablenumberOfRowsToDelete)
        {
            SourceExpression.Validate(deleteRowsInJSONTablejSONTable, nameof(deleteRowsInJSONTablejSONTable), required: true);
            SourceExpression.Validate(deleteRowsInJSONTablestartRowIndex, nameof(deleteRowsInJSONTablestartRowIndex), required: true);
            SourceExpression.Validate(deleteRowsInJSONTablenumberOfRowsToDelete, nameof(deleteRowsInJSONTablenumberOfRowsToDelete), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/DeleteRowsInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteRowsInJSONTable = new JObject();
                var deleteRowsInJSONTablepropCount = 0;
                deleteRowsInJSONTablepropCount++;
                deleteRowsInJSONTable["JSONTable"] = SourceExpressionConverter.ConvertToken(deleteRowsInJSONTablejSONTable);
                deleteRowsInJSONTablepropCount++;
                deleteRowsInJSONTable["StartRowIndex"] = SourceExpressionConverter.ConvertToken(deleteRowsInJSONTablestartRowIndex);
                deleteRowsInJSONTablepropCount++;
                deleteRowsInJSONTable["NumberOfRowsToDelete"] = SourceExpressionConverter.ConvertToken(deleteRowsInJSONTablenumberOfRowsToDelete);
                if (deleteRowsInJSONTablepropCount > 0)
                {
                    callPayload.Body = deleteRowsInJSONTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteRowsInJSONTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RenameColumnInTableResponse> RenameColumnInTable([WorkflowExpression] Func<JToken[]> renameColumnInTableinputTable, [WorkflowExpression] Func<string> renameColumnInTablesourceColumnName, [WorkflowExpression] Func<string> renameColumnInTablenewColumnName)
        {
            SourceExpression.Validate(renameColumnInTableinputTable, nameof(renameColumnInTableinputTable), required: true);
            SourceExpression.Validate(renameColumnInTablesourceColumnName, nameof(renameColumnInTablesourceColumnName), required: true);
            SourceExpression.Validate(renameColumnInTablenewColumnName, nameof(renameColumnInTablenewColumnName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/RenameColumnInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var renameColumnInTable = new JObject();
                var renameColumnInTablepropCount = 0;
                renameColumnInTablepropCount++;
                renameColumnInTable["InputTable"] = SourceExpressionConverter.ConvertToken(renameColumnInTableinputTable);
                renameColumnInTablepropCount++;
                renameColumnInTable["SourceColumnName"] = SourceExpressionConverter.ConvertToken(renameColumnInTablesourceColumnName);
                renameColumnInTablepropCount++;
                renameColumnInTable["NewColumnName"] = SourceExpressionConverter.ConvertToken(renameColumnInTablenewColumnName);
                if (renameColumnInTablepropCount > 0)
                {
                    callPayload.Body = renameColumnInTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RenameColumnInTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RenameColumnInJSONTableResponse> RenameColumnInJSONTable([WorkflowExpression] Func<string> renameColumnInJSONTablejSONTable, [WorkflowExpression] Func<string> renameColumnInJSONTablesourceColumnName, [WorkflowExpression] Func<string> renameColumnInJSONTablenewColumnName)
        {
            SourceExpression.Validate(renameColumnInJSONTablejSONTable, nameof(renameColumnInJSONTablejSONTable), required: true);
            SourceExpression.Validate(renameColumnInJSONTablesourceColumnName, nameof(renameColumnInJSONTablesourceColumnName), required: true);
            SourceExpression.Validate(renameColumnInJSONTablenewColumnName, nameof(renameColumnInJSONTablenewColumnName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/RenameColumnInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var renameColumnInJSONTable = new JObject();
                var renameColumnInJSONTablepropCount = 0;
                renameColumnInJSONTablepropCount++;
                renameColumnInJSONTable["JSONTable"] = SourceExpressionConverter.ConvertToken(renameColumnInJSONTablejSONTable);
                renameColumnInJSONTablepropCount++;
                renameColumnInJSONTable["SourceColumnName"] = SourceExpressionConverter.ConvertToken(renameColumnInJSONTablesourceColumnName);
                renameColumnInJSONTablepropCount++;
                renameColumnInJSONTable["NewColumnName"] = SourceExpressionConverter.ConvertToken(renameColumnInJSONTablenewColumnName);
                if (renameColumnInJSONTablepropCount > 0)
                {
                    callPayload.Body = renameColumnInJSONTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RenameColumnInJSONTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteColumnsInTableResponse> DeleteColumnsInTable([WorkflowExpression] Func<JToken[]> deleteColumnsInTableinputTable, [WorkflowExpression] Func<int> deleteColumnsInTablenumberOfColumnsToDelete, [WorkflowExpression] Func<int> deleteColumnsInTablestartColumnIndex = null, [WorkflowExpression] Func<string> deleteColumnsInTablecolumnNameToDelete = null)
        {
            SourceExpression.Validate(deleteColumnsInTableinputTable, nameof(deleteColumnsInTableinputTable), required: true);
            SourceExpression.Validate(deleteColumnsInTablenumberOfColumnsToDelete, nameof(deleteColumnsInTablenumberOfColumnsToDelete), required: true);
            SourceExpression.Validate(deleteColumnsInTablestartColumnIndex, nameof(deleteColumnsInTablestartColumnIndex), required: false);
            SourceExpression.Validate(deleteColumnsInTablecolumnNameToDelete, nameof(deleteColumnsInTablecolumnNameToDelete), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/DeleteColumnsInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteColumnsInTable = new JObject();
                var deleteColumnsInTablepropCount = 0;
                deleteColumnsInTablepropCount++;
                deleteColumnsInTable["InputTable"] = SourceExpressionConverter.ConvertToken(deleteColumnsInTableinputTable);
                if (deleteColumnsInTablestartColumnIndex != null)
                {
                    deleteColumnsInTable["StartColumnIndex"] = SourceExpressionConverter.ConvertToken(deleteColumnsInTablestartColumnIndex);
                    deleteColumnsInTablepropCount++;
                }

                if (deleteColumnsInTablecolumnNameToDelete != null)
                {
                    deleteColumnsInTable["ColumnNameToDelete"] = SourceExpressionConverter.ConvertToken(deleteColumnsInTablecolumnNameToDelete);
                    deleteColumnsInTablepropCount++;
                }

                deleteColumnsInTablepropCount++;
                deleteColumnsInTable["NumberOfColumnsToDelete"] = SourceExpressionConverter.ConvertToken(deleteColumnsInTablenumberOfColumnsToDelete);
                if (deleteColumnsInTablepropCount > 0)
                {
                    callPayload.Body = deleteColumnsInTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteColumnsInTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteColumnsInJSONTableResponse> DeleteColumnsInJSONTable([WorkflowExpression] Func<string> deleteColumnsInJSONTablejSONTable, [WorkflowExpression] Func<int> deleteColumnsInJSONTablenumberOfColumnsToDelete, [WorkflowExpression] Func<int> deleteColumnsInJSONTablestartColumnIndex = null, [WorkflowExpression] Func<string> deleteColumnsInJSONTablecolumnNameToDelete = null)
        {
            SourceExpression.Validate(deleteColumnsInJSONTablejSONTable, nameof(deleteColumnsInJSONTablejSONTable), required: true);
            SourceExpression.Validate(deleteColumnsInJSONTablenumberOfColumnsToDelete, nameof(deleteColumnsInJSONTablenumberOfColumnsToDelete), required: true);
            SourceExpression.Validate(deleteColumnsInJSONTablestartColumnIndex, nameof(deleteColumnsInJSONTablestartColumnIndex), required: false);
            SourceExpression.Validate(deleteColumnsInJSONTablecolumnNameToDelete, nameof(deleteColumnsInJSONTablecolumnNameToDelete), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/DeleteColumnsInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteColumnsInJSONTable = new JObject();
                var deleteColumnsInJSONTablepropCount = 0;
                deleteColumnsInJSONTablepropCount++;
                deleteColumnsInJSONTable["JSONTable"] = SourceExpressionConverter.ConvertToken(deleteColumnsInJSONTablejSONTable);
                if (deleteColumnsInJSONTablestartColumnIndex != null)
                {
                    deleteColumnsInJSONTable["StartColumnIndex"] = SourceExpressionConverter.ConvertToken(deleteColumnsInJSONTablestartColumnIndex);
                    deleteColumnsInJSONTablepropCount++;
                }

                if (deleteColumnsInJSONTablecolumnNameToDelete != null)
                {
                    deleteColumnsInJSONTable["ColumnNameToDelete"] = SourceExpressionConverter.ConvertToken(deleteColumnsInJSONTablecolumnNameToDelete);
                    deleteColumnsInJSONTablepropCount++;
                }

                deleteColumnsInJSONTablepropCount++;
                deleteColumnsInJSONTable["NumberOfColumnsToDelete"] = SourceExpressionConverter.ConvertToken(deleteColumnsInJSONTablenumberOfColumnsToDelete);
                if (deleteColumnsInJSONTablepropCount > 0)
                {
                    callPayload.Body = deleteColumnsInJSONTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteColumnsInJSONTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringArrayFromTableColumnResponse> GetStringArrayFromTableColumn([WorkflowExpression] Func<JToken[]> getStringArrayFromTableColumninputTable, [WorkflowExpression] Func<int> getStringArrayFromTableColumncolumnIndex = null, [WorkflowExpression] Func<string> getStringArrayFromTableColumncolumnName = null)
        {
            SourceExpression.Validate(getStringArrayFromTableColumninputTable, nameof(getStringArrayFromTableColumninputTable), required: true);
            SourceExpression.Validate(getStringArrayFromTableColumncolumnIndex, nameof(getStringArrayFromTableColumncolumnIndex), required: false);
            SourceExpression.Validate(getStringArrayFromTableColumncolumnName, nameof(getStringArrayFromTableColumncolumnName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetStringArrayFromTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getStringArrayFromTableColumn = new JObject();
                var getStringArrayFromTableColumnpropCount = 0;
                getStringArrayFromTableColumnpropCount++;
                getStringArrayFromTableColumn["InputTable"] = SourceExpressionConverter.ConvertToken(getStringArrayFromTableColumninputTable);
                if (getStringArrayFromTableColumncolumnIndex != null)
                {
                    getStringArrayFromTableColumn["ColumnIndex"] = SourceExpressionConverter.ConvertToken(getStringArrayFromTableColumncolumnIndex);
                    getStringArrayFromTableColumnpropCount++;
                }

                if (getStringArrayFromTableColumncolumnName != null)
                {
                    getStringArrayFromTableColumn["ColumnName"] = SourceExpressionConverter.ConvertToken(getStringArrayFromTableColumncolumnName);
                    getStringArrayFromTableColumnpropCount++;
                }

                if (getStringArrayFromTableColumnpropCount > 0)
                {
                    callPayload.Body = getStringArrayFromTableColumn;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetStringArrayFromTableColumnResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringArrayFromJSONTableColumnResponse> GetStringArrayFromJSONTableColumn([WorkflowExpression] Func<string> getStringArrayFromJSONTableColumnjSONTable, [WorkflowExpression] Func<int> getStringArrayFromJSONTableColumncolumnIndex = null, [WorkflowExpression] Func<string> getStringArrayFromJSONTableColumncolumnName = null)
        {
            SourceExpression.Validate(getStringArrayFromJSONTableColumnjSONTable, nameof(getStringArrayFromJSONTableColumnjSONTable), required: true);
            SourceExpression.Validate(getStringArrayFromJSONTableColumncolumnIndex, nameof(getStringArrayFromJSONTableColumncolumnIndex), required: false);
            SourceExpression.Validate(getStringArrayFromJSONTableColumncolumnName, nameof(getStringArrayFromJSONTableColumncolumnName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetStringArrayFromJSONTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getStringArrayFromJSONTableColumn = new JObject();
                var getStringArrayFromJSONTableColumnpropCount = 0;
                getStringArrayFromJSONTableColumnpropCount++;
                getStringArrayFromJSONTableColumn["JSONTable"] = SourceExpressionConverter.ConvertToken(getStringArrayFromJSONTableColumnjSONTable);
                if (getStringArrayFromJSONTableColumncolumnIndex != null)
                {
                    getStringArrayFromJSONTableColumn["ColumnIndex"] = SourceExpressionConverter.ConvertToken(getStringArrayFromJSONTableColumncolumnIndex);
                    getStringArrayFromJSONTableColumnpropCount++;
                }

                if (getStringArrayFromJSONTableColumncolumnName != null)
                {
                    getStringArrayFromJSONTableColumn["ColumnName"] = SourceExpressionConverter.ConvertToken(getStringArrayFromJSONTableColumncolumnName);
                    getStringArrayFromJSONTableColumnpropCount++;
                }

                if (getStringArrayFromJSONTableColumnpropCount > 0)
                {
                    callPayload.Body = getStringArrayFromJSONTableColumn;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetStringArrayFromJSONTableColumnResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringFromJSONTableCellResponse> GetStringFromJSONTableCell([WorkflowExpression] Func<string> getStringFromJSONTableCelljSONTable, [WorkflowExpression] Func<int> getStringFromJSONTableCellrowIndex = null, [WorkflowExpression] Func<int> getStringFromJSONTableCellcolumnIndex = null, [WorkflowExpression] Func<string> getStringFromJSONTableCellcolumnName = null, [WorkflowExpression] Func<bool> getStringFromJSONTableCellfallBackIfCellDoesNotExist = null, [WorkflowExpression] Func<string> getStringFromJSONTableCellfallbackValue = null)
        {
            SourceExpression.Validate(getStringFromJSONTableCelljSONTable, nameof(getStringFromJSONTableCelljSONTable), required: true);
            SourceExpression.Validate(getStringFromJSONTableCellrowIndex, nameof(getStringFromJSONTableCellrowIndex), required: false);
            SourceExpression.Validate(getStringFromJSONTableCellcolumnIndex, nameof(getStringFromJSONTableCellcolumnIndex), required: false);
            SourceExpression.Validate(getStringFromJSONTableCellcolumnName, nameof(getStringFromJSONTableCellcolumnName), required: false);
            SourceExpression.Validate(getStringFromJSONTableCellfallBackIfCellDoesNotExist, nameof(getStringFromJSONTableCellfallBackIfCellDoesNotExist), required: false);
            SourceExpression.Validate(getStringFromJSONTableCellfallbackValue, nameof(getStringFromJSONTableCellfallbackValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetStringFromJSONTableCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getStringFromJSONTableCell = new JObject();
                var getStringFromJSONTableCellpropCount = 0;
                getStringFromJSONTableCellpropCount++;
                getStringFromJSONTableCell["JSONTable"] = SourceExpressionConverter.ConvertToken(getStringFromJSONTableCelljSONTable);
                if (getStringFromJSONTableCellrowIndex != null)
                {
                    getStringFromJSONTableCell["RowIndex"] = SourceExpressionConverter.ConvertToken(getStringFromJSONTableCellrowIndex);
                    getStringFromJSONTableCellpropCount++;
                }

                if (getStringFromJSONTableCellcolumnIndex != null)
                {
                    getStringFromJSONTableCell["ColumnIndex"] = SourceExpressionConverter.ConvertToken(getStringFromJSONTableCellcolumnIndex);
                    getStringFromJSONTableCellpropCount++;
                }

                if (getStringFromJSONTableCellcolumnName != null)
                {
                    getStringFromJSONTableCell["ColumnName"] = SourceExpressionConverter.ConvertToken(getStringFromJSONTableCellcolumnName);
                    getStringFromJSONTableCellpropCount++;
                }

                if (getStringFromJSONTableCellfallBackIfCellDoesNotExist != null)
                {
                    if (getStringFromJSONTableCellfallBackIfCellDoesNotExist != null)
                    {
                        getStringFromJSONTableCell["FallBackIfCellDoesNotExist"] = SourceExpressionConverter.ConvertToken(getStringFromJSONTableCellfallBackIfCellDoesNotExist);
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
                    getStringFromJSONTableCell["FallbackValue"] = SourceExpressionConverter.ConvertToken(getStringFromJSONTableCellfallbackValue);
                    getStringFromJSONTableCellpropCount++;
                }

                if (getStringFromJSONTableCellpropCount > 0)
                {
                    callPayload.Body = getStringFromJSONTableCell;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetStringFromJSONTableCellResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringBetweenResponse> GetStringBetween([WorkflowExpression] Func<string> getStringBetweeninputString = null, [WorkflowExpression] Func<string> getStringBetweenstartSearchString = null, [WorkflowExpression] Func<string> getStringBetweenendSearchString = null, [WorkflowExpression] Func<bool> getStringBetweensearchLineByLine = null, [WorkflowExpression] Func<bool> getStringBetweenthrowExceptionIfNotFound = null, [WorkflowExpression] Func<bool> getStringBetweentrimResult = null, [WorkflowExpression] Func<bool> getStringBetweensearchIsRegularExpression = null, [WorkflowExpression] Func<bool> getStringBetweencaseSensitiveSearch = null)
        {
            SourceExpression.Validate(getStringBetweeninputString, nameof(getStringBetweeninputString), required: false);
            SourceExpression.Validate(getStringBetweenstartSearchString, nameof(getStringBetweenstartSearchString), required: false);
            SourceExpression.Validate(getStringBetweenendSearchString, nameof(getStringBetweenendSearchString), required: false);
            SourceExpression.Validate(getStringBetweensearchLineByLine, nameof(getStringBetweensearchLineByLine), required: false);
            SourceExpression.Validate(getStringBetweenthrowExceptionIfNotFound, nameof(getStringBetweenthrowExceptionIfNotFound), required: false);
            SourceExpression.Validate(getStringBetweentrimResult, nameof(getStringBetweentrimResult), required: false);
            SourceExpression.Validate(getStringBetweensearchIsRegularExpression, nameof(getStringBetweensearchIsRegularExpression), required: false);
            SourceExpression.Validate(getStringBetweencaseSensitiveSearch, nameof(getStringBetweencaseSensitiveSearch), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetStringBetween";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getStringBetween = new JObject();
                var getStringBetweenpropCount = 0;
                if (getStringBetweeninputString != null)
                {
                    getStringBetween["InputString"] = SourceExpressionConverter.ConvertToken(getStringBetweeninputString);
                    getStringBetweenpropCount++;
                }

                if (getStringBetweenstartSearchString != null)
                {
                    getStringBetween["StartSearchString"] = SourceExpressionConverter.ConvertToken(getStringBetweenstartSearchString);
                    getStringBetweenpropCount++;
                }

                if (getStringBetweenendSearchString != null)
                {
                    getStringBetween["EndSearchString"] = SourceExpressionConverter.ConvertToken(getStringBetweenendSearchString);
                    getStringBetweenpropCount++;
                }

                if (getStringBetweensearchLineByLine != null)
                {
                    if (getStringBetweensearchLineByLine != null)
                    {
                        getStringBetween["SearchLineByLine"] = SourceExpressionConverter.ConvertToken(getStringBetweensearchLineByLine);
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
                        getStringBetween["ThrowExceptionIfNotFound"] = SourceExpressionConverter.ConvertToken(getStringBetweenthrowExceptionIfNotFound);
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
                        getStringBetween["TrimResult"] = SourceExpressionConverter.ConvertToken(getStringBetweentrimResult);
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
                        getStringBetween["SearchIsRegularExpression"] = SourceExpressionConverter.ConvertToken(getStringBetweensearchIsRegularExpression);
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
                        getStringBetween["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(getStringBetweencaseSensitiveSearch);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetStringBetweenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LoadIAConnectLookupTableResponse> LoadIAConnectLookupTable([WorkflowExpression] Func<string> loadIAConnectLookupTablepath, [WorkflowExpression] Func<bool> loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad, [WorkflowExpression] Func<string> loadIAConnectLookupTableworkflow)
        {
            SourceExpression.Validate(loadIAConnectLookupTablepath, nameof(loadIAConnectLookupTablepath), required: true);
            SourceExpression.Validate(loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad, nameof(loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad), required: true);
            SourceExpression.Validate(loadIAConnectLookupTableworkflow, nameof(loadIAConnectLookupTableworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/LoadIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var loadIAConnectLookupTable = new JObject();
                var loadIAConnectLookupTablepropCount = 0;
                loadIAConnectLookupTablepropCount++;
                loadIAConnectLookupTable["Path"] = SourceExpressionConverter.ConvertToken(loadIAConnectLookupTablepath);
                loadIAConnectLookupTablepropCount++;
                loadIAConnectLookupTable["RaiseExceptionIfAnyTableFailsToLoad"] = SourceExpressionConverter.ConvertToken(loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad);
                loadIAConnectLookupTablepropCount++;
                loadIAConnectLookupTable["Workflow"] = SourceExpressionConverter.ConvertToken(loadIAConnectLookupTableworkflow);
                if (loadIAConnectLookupTablepropCount > 0)
                {
                    callPayload.Body = loadIAConnectLookupTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LoadIAConnectLookupTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetIAConnectLookupTableSummaryResponse> GetIAConnectLookupTableSummary([WorkflowExpression] Func<string> getIAConnectLookupTableSummaryworkflow)
        {
            SourceExpression.Validate(getIAConnectLookupTableSummaryworkflow, nameof(getIAConnectLookupTableSummaryworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetIAConnectLookupTableSummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectLookupTableSummary = new JObject();
                var getIAConnectLookupTableSummarypropCount = 0;
                getIAConnectLookupTableSummarypropCount++;
                getIAConnectLookupTableSummary["Workflow"] = SourceExpressionConverter.ConvertToken(getIAConnectLookupTableSummaryworkflow);
                if (getIAConnectLookupTableSummarypropCount > 0)
                {
                    callPayload.Body = getIAConnectLookupTableSummary;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetIAConnectLookupTableSummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveIAConnectLookupTableResponse> RemoveIAConnectLookupTable([WorkflowExpression] Func<string> removeIAConnectLookupTablelookupTableName, [WorkflowExpression] Func<string> removeIAConnectLookupTableworkflow)
        {
            SourceExpression.Validate(removeIAConnectLookupTablelookupTableName, nameof(removeIAConnectLookupTablelookupTableName), required: true);
            SourceExpression.Validate(removeIAConnectLookupTableworkflow, nameof(removeIAConnectLookupTableworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/RemoveIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var removeIAConnectLookupTable = new JObject();
                var removeIAConnectLookupTablepropCount = 0;
                removeIAConnectLookupTablepropCount++;
                removeIAConnectLookupTable["LookupTableName"] = SourceExpressionConverter.ConvertToken(removeIAConnectLookupTablelookupTableName);
                removeIAConnectLookupTablepropCount++;
                removeIAConnectLookupTable["Workflow"] = SourceExpressionConverter.ConvertToken(removeIAConnectLookupTableworkflow);
                if (removeIAConnectLookupTablepropCount > 0)
                {
                    callPayload.Body = removeIAConnectLookupTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RemoveIAConnectLookupTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveAllIAConnectLookupTablesResponse> RemoveAllIAConnectLookupTables([WorkflowExpression] Func<string> removeAllIAConnectLookupTablesworkflow)
        {
            SourceExpression.Validate(removeAllIAConnectLookupTablesworkflow, nameof(removeAllIAConnectLookupTablesworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/RemoveAllIAConnectLookupTables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var removeAllIAConnectLookupTables = new JObject();
                var removeAllIAConnectLookupTablespropCount = 0;
                removeAllIAConnectLookupTablespropCount++;
                removeAllIAConnectLookupTables["Workflow"] = SourceExpressionConverter.ConvertToken(removeAllIAConnectLookupTablesworkflow);
                if (removeAllIAConnectLookupTablespropCount > 0)
                {
                    callPayload.Body = removeAllIAConnectLookupTables;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RemoveAllIAConnectLookupTablesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LookupValueFromIAConnectLookupTableResponse> LookupValueFromIAConnectLookupTable([WorkflowExpression] Func<string> lookupValueFromIAConnectLookupTablelookupTableName, [WorkflowExpression] Func<string> lookupValueFromIAConnectLookupTablesearchResultValueColumnName, [WorkflowExpression] Func<string> lookupValueFromIAConnectLookupTableworkflow, [WorkflowExpression] Func<string> lookupValueFromIAConnectLookupTableinputDataJSON = null, [WorkflowExpression] Func<int> lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex = null, [WorkflowExpression] Func<bool> lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch = null)
        {
            SourceExpression.Validate(lookupValueFromIAConnectLookupTablelookupTableName, nameof(lookupValueFromIAConnectLookupTablelookupTableName), required: true);
            SourceExpression.Validate(lookupValueFromIAConnectLookupTablesearchResultValueColumnName, nameof(lookupValueFromIAConnectLookupTablesearchResultValueColumnName), required: true);
            SourceExpression.Validate(lookupValueFromIAConnectLookupTableworkflow, nameof(lookupValueFromIAConnectLookupTableworkflow), required: true);
            SourceExpression.Validate(lookupValueFromIAConnectLookupTableinputDataJSON, nameof(lookupValueFromIAConnectLookupTableinputDataJSON), required: false);
            SourceExpression.Validate(lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex, nameof(lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex), required: false);
            SourceExpression.Validate(lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch, nameof(lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/LookupValueFromIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lookupValueFromIAConnectLookupTable = new JObject();
                var lookupValueFromIAConnectLookupTablepropCount = 0;
                lookupValueFromIAConnectLookupTablepropCount++;
                lookupValueFromIAConnectLookupTable["LookupTableName"] = SourceExpressionConverter.ConvertToken(lookupValueFromIAConnectLookupTablelookupTableName);
                if (lookupValueFromIAConnectLookupTableinputDataJSON != null)
                {
                    lookupValueFromIAConnectLookupTable["InputDataJSON"] = SourceExpressionConverter.ConvertToken(lookupValueFromIAConnectLookupTableinputDataJSON);
                    lookupValueFromIAConnectLookupTablepropCount++;
                }

                lookupValueFromIAConnectLookupTablepropCount++;
                lookupValueFromIAConnectLookupTable["SearchResultValueColumnName"] = SourceExpressionConverter.ConvertToken(lookupValueFromIAConnectLookupTablesearchResultValueColumnName);
                if (lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex != null)
                {
                    if (lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex != null)
                    {
                        lookupValueFromIAConnectLookupTable["SearchResultValueColumnIndex"] = SourceExpressionConverter.ConvertToken(lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex);
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
                        lookupValueFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = SourceExpressionConverter.ConvertToken(lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch);
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
                lookupValueFromIAConnectLookupTable["Workflow"] = SourceExpressionConverter.ConvertToken(lookupValueFromIAConnectLookupTableworkflow);
                if (lookupValueFromIAConnectLookupTablepropCount > 0)
                {
                    callPayload.Body = lookupValueFromIAConnectLookupTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LookupValueFromIAConnectLookupTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LookupColumnsFromIAConnectLookupTableResponse> LookupColumnsFromIAConnectLookupTable([WorkflowExpression] Func<string> lookupColumnsFromIAConnectLookupTablelookupTableName, [WorkflowExpression] Func<string> lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName, [WorkflowExpression] Func<string> lookupColumnsFromIAConnectLookupTableworkflow, [WorkflowExpression] Func<string> lookupColumnsFromIAConnectLookupTableinputDataJSON = null, [WorkflowExpression] Func<bool> lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch = null, [WorkflowExpression] Func<bool> lookupColumnsFromIAConnectLookupTablereturnBlankCells = null, [WorkflowExpression] Func<lookupColumnsFromIAConnectLookupTablereturnFormatInput> lookupColumnsFromIAConnectLookupTablereturnFormat = null)
        {
            SourceExpression.Validate(lookupColumnsFromIAConnectLookupTablelookupTableName, nameof(lookupColumnsFromIAConnectLookupTablelookupTableName), required: true);
            SourceExpression.Validate(lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName, nameof(lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName), required: true);
            SourceExpression.Validate(lookupColumnsFromIAConnectLookupTableworkflow, nameof(lookupColumnsFromIAConnectLookupTableworkflow), required: true);
            SourceExpression.Validate(lookupColumnsFromIAConnectLookupTableinputDataJSON, nameof(lookupColumnsFromIAConnectLookupTableinputDataJSON), required: false);
            SourceExpression.Validate(lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch, nameof(lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch), required: false);
            SourceExpression.Validate(lookupColumnsFromIAConnectLookupTablereturnBlankCells, nameof(lookupColumnsFromIAConnectLookupTablereturnBlankCells), required: false);
            SourceExpression.Validate(lookupColumnsFromIAConnectLookupTablereturnFormat, nameof(lookupColumnsFromIAConnectLookupTablereturnFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/LookupColumnsFromIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lookupColumnsFromIAConnectLookupTable = new JObject();
                var lookupColumnsFromIAConnectLookupTablepropCount = 0;
                lookupColumnsFromIAConnectLookupTablepropCount++;
                lookupColumnsFromIAConnectLookupTable["LookupTableName"] = SourceExpressionConverter.ConvertToken(lookupColumnsFromIAConnectLookupTablelookupTableName);
                if (lookupColumnsFromIAConnectLookupTableinputDataJSON != null)
                {
                    lookupColumnsFromIAConnectLookupTable["InputDataJSON"] = SourceExpressionConverter.ConvertToken(lookupColumnsFromIAConnectLookupTableinputDataJSON);
                    lookupColumnsFromIAConnectLookupTablepropCount++;
                }

                lookupColumnsFromIAConnectLookupTablepropCount++;
                lookupColumnsFromIAConnectLookupTable["SearchResultTableColumnName"] = SourceExpressionConverter.ConvertToken(lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName);
                if (lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                {
                    if (lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                    {
                        lookupColumnsFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = SourceExpressionConverter.ConvertToken(lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch);
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
                        lookupColumnsFromIAConnectLookupTable["ReturnBlankCells"] = SourceExpressionConverter.ConvertToken(lookupColumnsFromIAConnectLookupTablereturnBlankCells);
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
                        lookupColumnsFromIAConnectLookupTable["ReturnFormat"] = SourceExpressionConverter.Convert(lookupColumnsFromIAConnectLookupTablereturnFormat);
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
                lookupColumnsFromIAConnectLookupTable["Workflow"] = SourceExpressionConverter.ConvertToken(lookupColumnsFromIAConnectLookupTableworkflow);
                if (lookupColumnsFromIAConnectLookupTablepropCount > 0)
                {
                    callPayload.Body = lookupColumnsFromIAConnectLookupTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LookupColumnsFromIAConnectLookupTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveCharactersFromStringResponse> RemoveCharactersFromString([WorkflowExpression] Func<string> removeCharactersFromStringinputString = null, [WorkflowExpression] Func<string> removeCharactersFromStringcharactersToRemoveFromInputString = null, [WorkflowExpression] Func<bool> removeCharactersFromStringremoveDiacriticsFromInputString = null, [WorkflowExpression] Func<bool> removeCharactersFromStringremoveNonAlphaNumericFromInputString = null, [WorkflowExpression] Func<bool> removeCharactersFromStringremoveNumericFromInputString = null, [WorkflowExpression] Func<bool> removeCharactersFromStringremoveLowercaseCharactersFromInputString = null, [WorkflowExpression] Func<bool> removeCharactersFromStringremoveUppercaseCharactersFromInputString = null)
        {
            SourceExpression.Validate(removeCharactersFromStringinputString, nameof(removeCharactersFromStringinputString), required: false);
            SourceExpression.Validate(removeCharactersFromStringcharactersToRemoveFromInputString, nameof(removeCharactersFromStringcharactersToRemoveFromInputString), required: false);
            SourceExpression.Validate(removeCharactersFromStringremoveDiacriticsFromInputString, nameof(removeCharactersFromStringremoveDiacriticsFromInputString), required: false);
            SourceExpression.Validate(removeCharactersFromStringremoveNonAlphaNumericFromInputString, nameof(removeCharactersFromStringremoveNonAlphaNumericFromInputString), required: false);
            SourceExpression.Validate(removeCharactersFromStringremoveNumericFromInputString, nameof(removeCharactersFromStringremoveNumericFromInputString), required: false);
            SourceExpression.Validate(removeCharactersFromStringremoveLowercaseCharactersFromInputString, nameof(removeCharactersFromStringremoveLowercaseCharactersFromInputString), required: false);
            SourceExpression.Validate(removeCharactersFromStringremoveUppercaseCharactersFromInputString, nameof(removeCharactersFromStringremoveUppercaseCharactersFromInputString), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/RemoveCharactersFromString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var removeCharactersFromString = new JObject();
                var removeCharactersFromStringpropCount = 0;
                if (removeCharactersFromStringinputString != null)
                {
                    removeCharactersFromString["InputString"] = SourceExpressionConverter.ConvertToken(removeCharactersFromStringinputString);
                    removeCharactersFromStringpropCount++;
                }

                if (removeCharactersFromStringcharactersToRemoveFromInputString != null)
                {
                    removeCharactersFromString["CharactersToRemoveFromInputString"] = SourceExpressionConverter.ConvertToken(removeCharactersFromStringcharactersToRemoveFromInputString);
                    removeCharactersFromStringpropCount++;
                }

                if (removeCharactersFromStringremoveDiacriticsFromInputString != null)
                {
                    if (removeCharactersFromStringremoveDiacriticsFromInputString != null)
                    {
                        removeCharactersFromString["RemoveDiacriticsFromInputString"] = SourceExpressionConverter.ConvertToken(removeCharactersFromStringremoveDiacriticsFromInputString);
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
                        removeCharactersFromString["RemoveNonAlphaNumericFromInputString"] = SourceExpressionConverter.ConvertToken(removeCharactersFromStringremoveNonAlphaNumericFromInputString);
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
                        removeCharactersFromString["RemoveNumericFromInputString"] = SourceExpressionConverter.ConvertToken(removeCharactersFromStringremoveNumericFromInputString);
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
                        removeCharactersFromString["RemoveLowercaseCharactersFromInputString"] = SourceExpressionConverter.ConvertToken(removeCharactersFromStringremoveLowercaseCharactersFromInputString);
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
                        removeCharactersFromString["RemoveUppercaseCharactersFromInputString"] = SourceExpressionConverter.ConvertToken(removeCharactersFromStringremoveUppercaseCharactersFromInputString);
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
                return callPayload;
            }

            return new ApiConnectionAction<RemoveCharactersFromStringResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetColumnFromIAConnectListResponse> GetColumnFromIAConnectList([WorkflowExpression] Func<string> getColumnFromIAConnectListlistName, [WorkflowExpression] Func<int> getColumnFromIAConnectListsearchColumnIndex = null, [WorkflowExpression] Func<string> getColumnFromIAConnectListsearchColumnName = null, [WorkflowExpression] Func<bool> getColumnFromIAConnectListreturnBlankCells = null, [WorkflowExpression] Func<bool> getColumnFromIAConnectListfallBackIfListDoesNotExist = null, [WorkflowExpression] Func<string> getColumnFromIAConnectListfallbackValue = null, [WorkflowExpression] Func<getColumnFromIAConnectListreturnFormatInput> getColumnFromIAConnectListreturnFormat = null)
        {
            SourceExpression.Validate(getColumnFromIAConnectListlistName, nameof(getColumnFromIAConnectListlistName), required: true);
            SourceExpression.Validate(getColumnFromIAConnectListsearchColumnIndex, nameof(getColumnFromIAConnectListsearchColumnIndex), required: false);
            SourceExpression.Validate(getColumnFromIAConnectListsearchColumnName, nameof(getColumnFromIAConnectListsearchColumnName), required: false);
            SourceExpression.Validate(getColumnFromIAConnectListreturnBlankCells, nameof(getColumnFromIAConnectListreturnBlankCells), required: false);
            SourceExpression.Validate(getColumnFromIAConnectListfallBackIfListDoesNotExist, nameof(getColumnFromIAConnectListfallBackIfListDoesNotExist), required: false);
            SourceExpression.Validate(getColumnFromIAConnectListfallbackValue, nameof(getColumnFromIAConnectListfallbackValue), required: false);
            SourceExpression.Validate(getColumnFromIAConnectListreturnFormat, nameof(getColumnFromIAConnectListreturnFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetColumnFromIAConnectList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getColumnFromIAConnectList = new JObject();
                var getColumnFromIAConnectListpropCount = 0;
                getColumnFromIAConnectListpropCount++;
                getColumnFromIAConnectList["ListName"] = SourceExpressionConverter.ConvertToken(getColumnFromIAConnectListlistName);
                if (getColumnFromIAConnectListsearchColumnIndex != null)
                {
                    if (getColumnFromIAConnectListsearchColumnIndex != null)
                    {
                        getColumnFromIAConnectList["SearchColumnIndex"] = SourceExpressionConverter.ConvertToken(getColumnFromIAConnectListsearchColumnIndex);
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
                    getColumnFromIAConnectList["SearchColumnName"] = SourceExpressionConverter.ConvertToken(getColumnFromIAConnectListsearchColumnName);
                    getColumnFromIAConnectListpropCount++;
                }

                if (getColumnFromIAConnectListreturnBlankCells != null)
                {
                    if (getColumnFromIAConnectListreturnBlankCells != null)
                    {
                        getColumnFromIAConnectList["ReturnBlankCells"] = SourceExpressionConverter.ConvertToken(getColumnFromIAConnectListreturnBlankCells);
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
                        getColumnFromIAConnectList["FallBackIfListDoesNotExist"] = SourceExpressionConverter.ConvertToken(getColumnFromIAConnectListfallBackIfListDoesNotExist);
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
                    getColumnFromIAConnectList["FallbackValue"] = SourceExpressionConverter.ConvertToken(getColumnFromIAConnectListfallbackValue);
                    getColumnFromIAConnectListpropCount++;
                }

                if (getColumnFromIAConnectListreturnFormat != null)
                {
                    if (getColumnFromIAConnectListreturnFormat != null)
                    {
                        getColumnFromIAConnectList["ReturnFormat"] = SourceExpressionConverter.Convert(getColumnFromIAConnectListreturnFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetColumnFromIAConnectListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetIAConnectListContentsResponse> GetIAConnectListContents([WorkflowExpression] Func<string> getIAConnectListContentslistName, [WorkflowExpression] Func<getIAConnectListContentsreturnFormatInput> getIAConnectListContentsreturnFormat = null)
        {
            SourceExpression.Validate(getIAConnectListContentslistName, nameof(getIAConnectListContentslistName), required: true);
            SourceExpression.Validate(getIAConnectListContentsreturnFormat, nameof(getIAConnectListContentsreturnFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetIAConnectListContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectListContents = new JObject();
                var getIAConnectListContentspropCount = 0;
                getIAConnectListContentspropCount++;
                getIAConnectListContents["ListName"] = SourceExpressionConverter.ConvertToken(getIAConnectListContentslistName);
                if (getIAConnectListContentsreturnFormat != null)
                {
                    if (getIAConnectListContentsreturnFormat != null)
                    {
                        getIAConnectListContents["ReturnFormat"] = SourceExpressionConverter.Convert(getIAConnectListContentsreturnFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetIAConnectListContentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LookupDataCellsFromIAConnectLookupTableResponse> LookupDataCellsFromIAConnectLookupTable([WorkflowExpression] Func<string> lookupDataCellsFromIAConnectLookupTablelookupTableName, [WorkflowExpression] Func<string> lookupDataCellsFromIAConnectLookupTableinputDataJSON = null, [WorkflowExpression] Func<bool> lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch = null, [WorkflowExpression] Func<bool> lookupDataCellsFromIAConnectLookupTablereturnBlankCells = null, [WorkflowExpression] Func<lookupDataCellsFromIAConnectLookupTablereturnFormatInput> lookupDataCellsFromIAConnectLookupTablereturnFormat = null)
        {
            SourceExpression.Validate(lookupDataCellsFromIAConnectLookupTablelookupTableName, nameof(lookupDataCellsFromIAConnectLookupTablelookupTableName), required: true);
            SourceExpression.Validate(lookupDataCellsFromIAConnectLookupTableinputDataJSON, nameof(lookupDataCellsFromIAConnectLookupTableinputDataJSON), required: false);
            SourceExpression.Validate(lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch, nameof(lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch), required: false);
            SourceExpression.Validate(lookupDataCellsFromIAConnectLookupTablereturnBlankCells, nameof(lookupDataCellsFromIAConnectLookupTablereturnBlankCells), required: false);
            SourceExpression.Validate(lookupDataCellsFromIAConnectLookupTablereturnFormat, nameof(lookupDataCellsFromIAConnectLookupTablereturnFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/LookupDataCellsFromIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lookupDataCellsFromIAConnectLookupTable = new JObject();
                var lookupDataCellsFromIAConnectLookupTablepropCount = 0;
                lookupDataCellsFromIAConnectLookupTablepropCount++;
                lookupDataCellsFromIAConnectLookupTable["LookupTableName"] = SourceExpressionConverter.ConvertToken(lookupDataCellsFromIAConnectLookupTablelookupTableName);
                if (lookupDataCellsFromIAConnectLookupTableinputDataJSON != null)
                {
                    lookupDataCellsFromIAConnectLookupTable["InputDataJSON"] = SourceExpressionConverter.ConvertToken(lookupDataCellsFromIAConnectLookupTableinputDataJSON);
                    lookupDataCellsFromIAConnectLookupTablepropCount++;
                }

                if (lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                {
                    if (lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                    {
                        lookupDataCellsFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = SourceExpressionConverter.ConvertToken(lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch);
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
                        lookupDataCellsFromIAConnectLookupTable["ReturnBlankCells"] = SourceExpressionConverter.ConvertToken(lookupDataCellsFromIAConnectLookupTablereturnBlankCells);
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
                        lookupDataCellsFromIAConnectLookupTable["ReturnFormat"] = SourceExpressionConverter.Convert(lookupDataCellsFromIAConnectLookupTablereturnFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction<LookupDataCellsFromIAConnectLookupTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetIAConnectLookupTableContentsResponse> GetIAConnectLookupTableContents([WorkflowExpression] Func<string> getIAConnectLookupTableContentslookupTableName, [WorkflowExpression] Func<getIAConnectLookupTableContentsreturnFormatInput> getIAConnectLookupTableContentsreturnFormat = null)
        {
            SourceExpression.Validate(getIAConnectLookupTableContentslookupTableName, nameof(getIAConnectLookupTableContentslookupTableName), required: true);
            SourceExpression.Validate(getIAConnectLookupTableContentsreturnFormat, nameof(getIAConnectLookupTableContentsreturnFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/GetIAConnectLookupTableContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectLookupTableContents = new JObject();
                var getIAConnectLookupTableContentspropCount = 0;
                getIAConnectLookupTableContentspropCount++;
                getIAConnectLookupTableContents["LookupTableName"] = SourceExpressionConverter.ConvertToken(getIAConnectLookupTableContentslookupTableName);
                if (getIAConnectLookupTableContentsreturnFormat != null)
                {
                    if (getIAConnectLookupTableContentsreturnFormat != null)
                    {
                        getIAConnectLookupTableContents["ReturnFormat"] = SourceExpressionConverter.Convert(getIAConnectLookupTableContentsreturnFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetIAConnectLookupTableContentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<UploadCSVToIAConnectLookupTableResponse> UploadCSVToIAConnectLookupTable([WorkflowExpression] Func<string> uploadCSVToIAConnectLookupTablelookupTableName, [WorkflowExpression] Func<string> uploadCSVToIAConnectLookupTablecSVData, [WorkflowExpression] Func<bool> uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist = null)
        {
            SourceExpression.Validate(uploadCSVToIAConnectLookupTablelookupTableName, nameof(uploadCSVToIAConnectLookupTablelookupTableName), required: true);
            SourceExpression.Validate(uploadCSVToIAConnectLookupTablecSVData, nameof(uploadCSVToIAConnectLookupTablecSVData), required: true);
            SourceExpression.Validate(uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist, nameof(uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/UploadCSVToIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uploadCSVToIAConnectLookupTable = new JObject();
                var uploadCSVToIAConnectLookupTablepropCount = 0;
                uploadCSVToIAConnectLookupTablepropCount++;
                uploadCSVToIAConnectLookupTable["LookupTableName"] = SourceExpressionConverter.ConvertToken(uploadCSVToIAConnectLookupTablelookupTableName);
                uploadCSVToIAConnectLookupTablepropCount++;
                uploadCSVToIAConnectLookupTable["CSVData"] = SourceExpressionConverter.ConvertToken(uploadCSVToIAConnectLookupTablecSVData);
                if (uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist != null)
                {
                    if (uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist != null)
                    {
                        uploadCSVToIAConnectLookupTable["CreateLookupTableIfNotExist"] = SourceExpressionConverter.ConvertToken(uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist);
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
                return callPayload;
            }

            return new ApiConnectionAction<UploadCSVToIAConnectLookupTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<UploadCSVToIAConnectListResponse> UploadCSVToIAConnectList([WorkflowExpression] Func<string> uploadCSVToIAConnectListlistName, [WorkflowExpression] Func<string> uploadCSVToIAConnectListcSVData, [WorkflowExpression] Func<bool> uploadCSVToIAConnectListcreateListIfNotExist = null)
        {
            SourceExpression.Validate(uploadCSVToIAConnectListlistName, nameof(uploadCSVToIAConnectListlistName), required: true);
            SourceExpression.Validate(uploadCSVToIAConnectListcSVData, nameof(uploadCSVToIAConnectListcSVData), required: true);
            SourceExpression.Validate(uploadCSVToIAConnectListcreateListIfNotExist, nameof(uploadCSVToIAConnectListcreateListIfNotExist), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/UploadCSVToIAConnectList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uploadCSVToIAConnectList = new JObject();
                var uploadCSVToIAConnectListpropCount = 0;
                uploadCSVToIAConnectListpropCount++;
                uploadCSVToIAConnectList["ListName"] = SourceExpressionConverter.ConvertToken(uploadCSVToIAConnectListlistName);
                uploadCSVToIAConnectListpropCount++;
                uploadCSVToIAConnectList["CSVData"] = SourceExpressionConverter.ConvertToken(uploadCSVToIAConnectListcSVData);
                if (uploadCSVToIAConnectListcreateListIfNotExist != null)
                {
                    if (uploadCSVToIAConnectListcreateListIfNotExist != null)
                    {
                        uploadCSVToIAConnectList["CreateListIfNotExist"] = SourceExpressionConverter.ConvertToken(uploadCSVToIAConnectListcreateListIfNotExist);
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
                return callPayload;
            }

            return new ApiConnectionAction<UploadCSVToIAConnectListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<ConvertArrayToJSONResponse> ConvertArrayToJSON([WorkflowExpression] Func<JToken[]> convertArrayToJSONinputObject)
        {
            SourceExpression.Validate(convertArrayToJSONinputObject, nameof(convertArrayToJSONinputObject), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DynamicCode/ConvertArrayToJSON";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var convertArrayToJSON = new JObject();
                var convertArrayToJSONpropCount = 0;
                convertArrayToJSONpropCount++;
                convertArrayToJSON["InputObject"] = SourceExpressionConverter.ConvertToken(convertArrayToJSONinputObject);
                if (convertArrayToJSONpropCount > 0)
                {
                    callPayload.Body = convertArrayToJSON;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConvertArrayToJSONResponse>(BuildSourceInput);
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