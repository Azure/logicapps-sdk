//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectdynamiccode
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectdynamiccodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildImportAssemblyFromLocalFile))]
        public IWorkflowAction ImportAssemblyFromLocalFile([WorkflowExpression] Func<string> importAssemblyFromLocalFilelocalAssemblyFilePath, [WorkflowExpression] Func<string> importAssemblyFromLocalFileassemblyName, [WorkflowExpression] Func<string> importAssemblyFromLocalFileworkflow, [WorkflowExpression] Func<bool> importAssemblyFromLocalFilecompress = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildImportAssemblyFromLocalFile(WorkflowValue<string> importAssemblyFromLocalFilelocalAssemblyFilePath, WorkflowValue<string> importAssemblyFromLocalFileassemblyName, WorkflowValue<string> importAssemblyFromLocalFileworkflow, WorkflowValue<bool> importAssemblyFromLocalFilecompress = null)
        {
            WorkflowValue.Validate(importAssemblyFromLocalFilelocalAssemblyFilePath, nameof(importAssemblyFromLocalFilelocalAssemblyFilePath), required: true);
            WorkflowValue.Validate(importAssemblyFromLocalFileassemblyName, nameof(importAssemblyFromLocalFileassemblyName), required: true);
            WorkflowValue.Validate(importAssemblyFromLocalFileworkflow, nameof(importAssemblyFromLocalFileworkflow), required: true);
            WorkflowValue.Validate(importAssemblyFromLocalFilecompress, nameof(importAssemblyFromLocalFilecompress), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DynamicCode/ImportAssemblyFromLocalFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var importAssemblyFromLocalFile = new JObject();
                var importAssemblyFromLocalFilepropCount = 0;
                importAssemblyFromLocalFilepropCount++;
                importAssemblyFromLocalFile["LocalAssemblyFilePath"] = ExpressionConverter.ConvertO(importAssemblyFromLocalFilelocalAssemblyFilePath);
                importAssemblyFromLocalFilepropCount++;
                importAssemblyFromLocalFile["AssemblyName"] = ExpressionConverter.ConvertO(importAssemblyFromLocalFileassemblyName);
                if (importAssemblyFromLocalFilecompress != null)
                {
                    if (importAssemblyFromLocalFilecompress != null)
                    {
                        importAssemblyFromLocalFile["Compress"] = ExpressionConverter.ConvertO(importAssemblyFromLocalFilecompress);
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
                importAssemblyFromLocalFile["Workflow"] = ExpressionConverter.ConvertO(importAssemblyFromLocalFileworkflow);
                if (importAssemblyFromLocalFilepropCount > 0)
                {
                    callPayload.Body = importAssemblyFromLocalFile;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildAddAssemblySearchFolder))]
        public IWorkflowAction AddAssemblySearchFolder([WorkflowExpression] Func<string> addAssemblySearchFolderfolderPath, [WorkflowExpression] Func<string> addAssemblySearchFolderworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddAssemblySearchFolder(WorkflowValue<string> addAssemblySearchFolderfolderPath, WorkflowValue<string> addAssemblySearchFolderworkflow)
        {
            WorkflowValue.Validate(addAssemblySearchFolderfolderPath, nameof(addAssemblySearchFolderfolderPath), required: true);
            WorkflowValue.Validate(addAssemblySearchFolderworkflow, nameof(addAssemblySearchFolderworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DynamicCode/AddAssemblySearchFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addAssemblySearchFolder = new JObject();
                var addAssemblySearchFolderpropCount = 0;
                addAssemblySearchFolderpropCount++;
                addAssemblySearchFolder["FolderPath"] = ExpressionConverter.ConvertO(addAssemblySearchFolderfolderPath);
                addAssemblySearchFolderpropCount++;
                addAssemblySearchFolder["Workflow"] = ExpressionConverter.ConvertO(addAssemblySearchFolderworkflow);
                if (addAssemblySearchFolderpropCount > 0)
                {
                    callPayload.Body = addAssemblySearchFolder;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildClearAssemblySearchFolders))]
        public IWorkflowAction ClearAssemblySearchFolders([WorkflowExpression] Func<string> clearAssemblySearchFoldersworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildClearAssemblySearchFolders(WorkflowValue<string> clearAssemblySearchFoldersworkflow)
        {
            WorkflowValue.Validate(clearAssemblySearchFoldersworkflow, nameof(clearAssemblySearchFoldersworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DynamicCode/ClearAssemblySearchFolders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var clearAssemblySearchFolders = new JObject();
                var clearAssemblySearchFolderspropCount = 0;
                clearAssemblySearchFolderspropCount++;
                clearAssemblySearchFolders["Workflow"] = ExpressionConverter.ConvertO(clearAssemblySearchFoldersworkflow);
                if (clearAssemblySearchFolderspropCount > 0)
                {
                    callPayload.Body = clearAssemblySearchFolders;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildIsPowerShellAutomationInstalled))]
        public IBodyWorkflowAction<IsPowerShellAutomationInstalledResponse> IsPowerShellAutomationInstalled([WorkflowExpression] Func<string> isPowerShellAutomationInstalledworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsPowerShellAutomationInstalledResponse> __BuildIsPowerShellAutomationInstalled(WorkflowValue<string> isPowerShellAutomationInstalledworkflow)
        {
            WorkflowValue.Validate(isPowerShellAutomationInstalledworkflow, nameof(isPowerShellAutomationInstalledworkflow), required: true);
            return new DeferredBodyAction<IsPowerShellAutomationInstalledResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/isPowerShellAutomationInstalled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isPowerShellAutomationInstalled = new JObject();
                var isPowerShellAutomationInstalledpropCount = 0;
                isPowerShellAutomationInstalledpropCount++;
                isPowerShellAutomationInstalled["Workflow"] = ExpressionConverter.ConvertO(isPowerShellAutomationInstalledworkflow);
                if (isPowerShellAutomationInstalledpropCount > 0)
                {
                    callPayload.Body = isPowerShellAutomationInstalled;
                }

                return new ApiConnectionAction<IsPowerShellAutomationInstalledResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildIsPowerShellModuleInstalled))]
        public IBodyWorkflowAction<IsPowerShellModuleInstalledResponse> IsPowerShellModuleInstalled([WorkflowExpression] Func<string> isPowerShellModuleInstalledpowerShellModuleName, [WorkflowExpression] Func<string> isPowerShellModuleInstalledworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsPowerShellModuleInstalledResponse> __BuildIsPowerShellModuleInstalled(WorkflowValue<string> isPowerShellModuleInstalledpowerShellModuleName, WorkflowValue<string> isPowerShellModuleInstalledworkflow)
        {
            WorkflowValue.Validate(isPowerShellModuleInstalledpowerShellModuleName, nameof(isPowerShellModuleInstalledpowerShellModuleName), required: true);
            WorkflowValue.Validate(isPowerShellModuleInstalledworkflow, nameof(isPowerShellModuleInstalledworkflow), required: true);
            return new DeferredBodyAction<IsPowerShellModuleInstalledResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/isPowerShellModuleInstalled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isPowerShellModuleInstalled = new JObject();
                var isPowerShellModuleInstalledpropCount = 0;
                isPowerShellModuleInstalledpropCount++;
                isPowerShellModuleInstalled["PowerShellModuleName"] = ExpressionConverter.ConvertO(isPowerShellModuleInstalledpowerShellModuleName);
                isPowerShellModuleInstalledpropCount++;
                isPowerShellModuleInstalled["Workflow"] = ExpressionConverter.ConvertO(isPowerShellModuleInstalledworkflow);
                if (isPowerShellModuleInstalledpropCount > 0)
                {
                    callPayload.Body = isPowerShellModuleInstalled;
                }

                return new ApiConnectionAction<IsPowerShellModuleInstalledResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildRunPowerShellAutomationScript))]
        public IBodyWorkflowAction<RunPowerShellAutomationScriptResponse> RunPowerShellAutomationScript([WorkflowExpression] Func<string> runPowerShellAutomationScriptworkflow, [WorkflowExpression] Func<string> runPowerShellAutomationScriptpowerShellScriptContents = null, [WorkflowExpression] Func<string> runPowerShellAutomationScriptcomputerName = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptisNoResultAnError = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptreturnComplexTypes = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptreturnBooleanAsBoolean = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptreturnNumericAsDecimal = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptreturnDateAsDate = null, [WorkflowExpression] Func<string> runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<runPowerShellAutomationScriptauthenticationMechanismInput> runPowerShellAutomationScriptauthenticationMechanism = null, [WorkflowExpression] Func<int> runPowerShellAutomationScriptconnectionAttempts = null, [WorkflowExpression] Func<string> runPowerShellAutomationScriptusername = null, [WorkflowExpression] Func<string> runPowerShellAutomationScriptpassword = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptrunScriptAsThread = null, [WorkflowExpression] Func<int> runPowerShellAutomationScriptretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> runPowerShellAutomationScriptsecondsToWaitForThread = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptscriptContainsStoredPassword = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptlogVerboseOutput = null, [WorkflowExpression] Func<bool> runPowerShellAutomationScriptreturnSecureStrings = null, [WorkflowExpression] Func<string> runPowerShellAutomationScriptpropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> runPowerShellAutomationScriptpropertyTypesToSerializeJSON = null, [WorkflowExpression] Func<runPowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runPowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunPowerShellAutomationScriptResponse> __BuildRunPowerShellAutomationScript(WorkflowValue<string> runPowerShellAutomationScriptworkflow, WorkflowValue<string> runPowerShellAutomationScriptpowerShellScriptContents = null, WorkflowValue<string> runPowerShellAutomationScriptcomputerName = null, WorkflowValue<bool> runPowerShellAutomationScriptisNoResultAnError = null, WorkflowValue<bool> runPowerShellAutomationScriptreturnComplexTypes = null, WorkflowValue<bool> runPowerShellAutomationScriptreturnBooleanAsBoolean = null, WorkflowValue<bool> runPowerShellAutomationScriptreturnNumericAsDecimal = null, WorkflowValue<bool> runPowerShellAutomationScriptreturnDateAsDate = null, WorkflowValue<string> runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, WorkflowValue<runPowerShellAutomationScriptauthenticationMechanismInput> runPowerShellAutomationScriptauthenticationMechanism = null, WorkflowValue<int> runPowerShellAutomationScriptconnectionAttempts = null, WorkflowValue<string> runPowerShellAutomationScriptusername = null, WorkflowValue<string> runPowerShellAutomationScriptpassword = null, WorkflowValue<bool> runPowerShellAutomationScriptrunScriptAsThread = null, WorkflowValue<int> runPowerShellAutomationScriptretrieveOutputDataFromThreadId = null, WorkflowValue<int> runPowerShellAutomationScriptsecondsToWaitForThread = null, WorkflowValue<bool> runPowerShellAutomationScriptscriptContainsStoredPassword = null, WorkflowValue<bool> runPowerShellAutomationScriptlogVerboseOutput = null, WorkflowValue<bool> runPowerShellAutomationScriptreturnSecureStrings = null, WorkflowValue<string> runPowerShellAutomationScriptpropertyNamesToSerializeJSON = null, WorkflowValue<string> runPowerShellAutomationScriptpropertyTypesToSerializeJSON = null, WorkflowValue<runPowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runPowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            WorkflowValue.Validate(runPowerShellAutomationScriptworkflow, nameof(runPowerShellAutomationScriptworkflow), required: true);
            WorkflowValue.Validate(runPowerShellAutomationScriptpowerShellScriptContents, nameof(runPowerShellAutomationScriptpowerShellScriptContents), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptcomputerName, nameof(runPowerShellAutomationScriptcomputerName), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptisNoResultAnError, nameof(runPowerShellAutomationScriptisNoResultAnError), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptreturnComplexTypes, nameof(runPowerShellAutomationScriptreturnComplexTypes), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptreturnBooleanAsBoolean, nameof(runPowerShellAutomationScriptreturnBooleanAsBoolean), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptreturnNumericAsDecimal, nameof(runPowerShellAutomationScriptreturnNumericAsDecimal), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptreturnDateAsDate, nameof(runPowerShellAutomationScriptreturnDateAsDate), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON, nameof(runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptauthenticationMechanism, nameof(runPowerShellAutomationScriptauthenticationMechanism), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptconnectionAttempts, nameof(runPowerShellAutomationScriptconnectionAttempts), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptusername, nameof(runPowerShellAutomationScriptusername), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptpassword, nameof(runPowerShellAutomationScriptpassword), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptrunScriptAsThread, nameof(runPowerShellAutomationScriptrunScriptAsThread), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptretrieveOutputDataFromThreadId, nameof(runPowerShellAutomationScriptretrieveOutputDataFromThreadId), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptsecondsToWaitForThread, nameof(runPowerShellAutomationScriptsecondsToWaitForThread), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptscriptContainsStoredPassword, nameof(runPowerShellAutomationScriptscriptContainsStoredPassword), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptlogVerboseOutput, nameof(runPowerShellAutomationScriptlogVerboseOutput), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptreturnSecureStrings, nameof(runPowerShellAutomationScriptreturnSecureStrings), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptpropertyNamesToSerializeJSON, nameof(runPowerShellAutomationScriptpropertyNamesToSerializeJSON), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptpropertyTypesToSerializeJSON, nameof(runPowerShellAutomationScriptpropertyTypesToSerializeJSON), required: false);
            WorkflowValue.Validate(runPowerShellAutomationScriptpowerShellCommandParameters, nameof(runPowerShellAutomationScriptpowerShellCommandParameters), required: false);
            return new DeferredBodyAction<RunPowerShellAutomationScriptResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/RunPowerShellScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runPowerShellAutomationScript = new JObject();
                var runPowerShellAutomationScriptpropCount = 0;
                if (runPowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runPowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptpowerShellScriptContents);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptcomputerName != null)
                {
                    runPowerShellAutomationScript["ComputerName"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptcomputerName);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (runPowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runPowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptisNoResultAnError);
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
                        runPowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptreturnComplexTypes);
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
                        runPowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptreturnBooleanAsBoolean);
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
                        runPowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptreturnNumericAsDecimal);
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
                        runPowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptreturnDateAsDate);
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
                    runPowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptauthenticationMechanism != null)
                {
                    runPowerShellAutomationScript["AuthenticationMechanism"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptauthenticationMechanism);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptconnectionAttempts != null)
                {
                    if (runPowerShellAutomationScriptconnectionAttempts != null)
                    {
                        runPowerShellAutomationScript["ConnectionAttempts"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptconnectionAttempts);
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
                    runPowerShellAutomationScript["Username"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptusername);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptpassword != null)
                {
                    runPowerShellAutomationScript["Password"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptpassword);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (runPowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runPowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptrunScriptAsThread);
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
                    runPowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (runPowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runPowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptsecondsToWaitForThread);
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
                        runPowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptscriptContainsStoredPassword);
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
                        runPowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptlogVerboseOutput);
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
                        runPowerShellAutomationScript["ReturnSecureStrings"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptreturnSecureStrings);
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
                    runPowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runPowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (runPowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runPowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptpowerShellCommandParameters);
                    runPowerShellAutomationScriptpropCount++;
                }

                runPowerShellAutomationScriptpropCount++;
                runPowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(runPowerShellAutomationScriptworkflow);
                if (runPowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runPowerShellAutomationScript;
                }

                return new ApiConnectionAction<RunPowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetPowerShellVersion))]
        public IBodyWorkflowAction<GetPowerShellVersionResponse> GetPowerShellVersion([WorkflowExpression] Func<string> getPowerShellVersionworkflow, [WorkflowExpression] Func<string> getPowerShellVersioncomputerName = null, [WorkflowExpression] Func<getPowerShellVersionauthenticationMechanismInput> getPowerShellVersionauthenticationMechanism = null, [WorkflowExpression] Func<int> getPowerShellVersionconnectionAttempts = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPowerShellVersionResponse> __BuildGetPowerShellVersion(WorkflowValue<string> getPowerShellVersionworkflow, WorkflowValue<string> getPowerShellVersioncomputerName = null, WorkflowValue<getPowerShellVersionauthenticationMechanismInput> getPowerShellVersionauthenticationMechanism = null, WorkflowValue<int> getPowerShellVersionconnectionAttempts = null)
        {
            WorkflowValue.Validate(getPowerShellVersionworkflow, nameof(getPowerShellVersionworkflow), required: true);
            WorkflowValue.Validate(getPowerShellVersioncomputerName, nameof(getPowerShellVersioncomputerName), required: false);
            WorkflowValue.Validate(getPowerShellVersionauthenticationMechanism, nameof(getPowerShellVersionauthenticationMechanism), required: false);
            WorkflowValue.Validate(getPowerShellVersionconnectionAttempts, nameof(getPowerShellVersionconnectionAttempts), required: false);
            return new DeferredBodyAction<GetPowerShellVersionResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/GetPowerShellVersion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getPowerShellVersion = new JObject();
                var getPowerShellVersionpropCount = 0;
                if (getPowerShellVersioncomputerName != null)
                {
                    getPowerShellVersion["ComputerName"] = ExpressionConverter.ConvertO(getPowerShellVersioncomputerName);
                    getPowerShellVersionpropCount++;
                }

                if (getPowerShellVersionauthenticationMechanism != null)
                {
                    getPowerShellVersion["AuthenticationMechanism"] = ExpressionConverter.ConvertO(getPowerShellVersionauthenticationMechanism);
                    getPowerShellVersionpropCount++;
                }

                if (getPowerShellVersionconnectionAttempts != null)
                {
                    if (getPowerShellVersionconnectionAttempts != null)
                    {
                        getPowerShellVersion["ConnectionAttempts"] = ExpressionConverter.ConvertO(getPowerShellVersionconnectionAttempts);
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
                getPowerShellVersion["Workflow"] = ExpressionConverter.ConvertO(getPowerShellVersionworkflow);
                if (getPowerShellVersionpropCount > 0)
                {
                    callPayload.Body = getPowerShellVersion;
                }

                return new ApiConnectionAction<GetPowerShellVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetRegexMatch))]
        public IBodyWorkflowAction<GetRegexMatchResponse> GetRegexMatch([WorkflowExpression] Func<string> getRegexMatchtextToMatch, [WorkflowExpression] Func<string> getRegexMatchregex, [WorkflowExpression] Func<int> getRegexMatchsearchIndex = null, [WorkflowExpression] Func<bool> getRegexMatchcaseSensitive = null, [WorkflowExpression] Func<int> getRegexMatchregexTimeoutInSeconds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRegexMatchResponse> __BuildGetRegexMatch(WorkflowValue<string> getRegexMatchtextToMatch, WorkflowValue<string> getRegexMatchregex, WorkflowValue<int> getRegexMatchsearchIndex = null, WorkflowValue<bool> getRegexMatchcaseSensitive = null, WorkflowValue<int> getRegexMatchregexTimeoutInSeconds = null)
        {
            WorkflowValue.Validate(getRegexMatchtextToMatch, nameof(getRegexMatchtextToMatch), required: true);
            WorkflowValue.Validate(getRegexMatchregex, nameof(getRegexMatchregex), required: true);
            WorkflowValue.Validate(getRegexMatchsearchIndex, nameof(getRegexMatchsearchIndex), required: false);
            WorkflowValue.Validate(getRegexMatchcaseSensitive, nameof(getRegexMatchcaseSensitive), required: false);
            WorkflowValue.Validate(getRegexMatchregexTimeoutInSeconds, nameof(getRegexMatchregexTimeoutInSeconds), required: false);
            return new DeferredBodyAction<GetRegexMatchResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetRegexMatch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRegexMatch = new JObject();
                var getRegexMatchpropCount = 0;
                getRegexMatchpropCount++;
                getRegexMatch["TextToMatch"] = ExpressionConverter.ConvertO(getRegexMatchtextToMatch);
                getRegexMatchpropCount++;
                getRegexMatch["Regex"] = ExpressionConverter.ConvertO(getRegexMatchregex);
                if (getRegexMatchsearchIndex != null)
                {
                    if (getRegexMatchsearchIndex != null)
                    {
                        getRegexMatch["SearchIndex"] = ExpressionConverter.ConvertO(getRegexMatchsearchIndex);
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
                        getRegexMatch["CaseSensitive"] = ExpressionConverter.ConvertO(getRegexMatchcaseSensitive);
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
                        getRegexMatch["RegexTimeoutInSeconds"] = ExpressionConverter.ConvertO(getRegexMatchregexTimeoutInSeconds);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetRegexMatches))]
        public IBodyWorkflowAction<GetRegexMatchesResponse> GetRegexMatches([WorkflowExpression] Func<string> getRegexMatchestextToMatch, [WorkflowExpression] Func<string> getRegexMatchesregex, [WorkflowExpression] Func<int> getRegexMatchesmaximumMatches = null, [WorkflowExpression] Func<bool> getRegexMatchescaseSensitive = null, [WorkflowExpression] Func<bool> getRegexMatchestrimResults = null, [WorkflowExpression] Func<bool> getRegexMatchesremoveEmptyResults = null, [WorkflowExpression] Func<int> getRegexMatchesregexTimeoutInSeconds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRegexMatchesResponse> __BuildGetRegexMatches(WorkflowValue<string> getRegexMatchestextToMatch, WorkflowValue<string> getRegexMatchesregex, WorkflowValue<int> getRegexMatchesmaximumMatches = null, WorkflowValue<bool> getRegexMatchescaseSensitive = null, WorkflowValue<bool> getRegexMatchestrimResults = null, WorkflowValue<bool> getRegexMatchesremoveEmptyResults = null, WorkflowValue<int> getRegexMatchesregexTimeoutInSeconds = null)
        {
            WorkflowValue.Validate(getRegexMatchestextToMatch, nameof(getRegexMatchestextToMatch), required: true);
            WorkflowValue.Validate(getRegexMatchesregex, nameof(getRegexMatchesregex), required: true);
            WorkflowValue.Validate(getRegexMatchesmaximumMatches, nameof(getRegexMatchesmaximumMatches), required: false);
            WorkflowValue.Validate(getRegexMatchescaseSensitive, nameof(getRegexMatchescaseSensitive), required: false);
            WorkflowValue.Validate(getRegexMatchestrimResults, nameof(getRegexMatchestrimResults), required: false);
            WorkflowValue.Validate(getRegexMatchesremoveEmptyResults, nameof(getRegexMatchesremoveEmptyResults), required: false);
            WorkflowValue.Validate(getRegexMatchesregexTimeoutInSeconds, nameof(getRegexMatchesregexTimeoutInSeconds), required: false);
            return new DeferredBodyAction<GetRegexMatchesResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetRegexMatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRegexMatches = new JObject();
                var getRegexMatchespropCount = 0;
                getRegexMatchespropCount++;
                getRegexMatches["TextToMatch"] = ExpressionConverter.ConvertO(getRegexMatchestextToMatch);
                getRegexMatchespropCount++;
                getRegexMatches["Regex"] = ExpressionConverter.ConvertO(getRegexMatchesregex);
                if (getRegexMatchesmaximumMatches != null)
                {
                    if (getRegexMatchesmaximumMatches != null)
                    {
                        getRegexMatches["MaximumMatches"] = ExpressionConverter.ConvertO(getRegexMatchesmaximumMatches);
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
                        getRegexMatches["CaseSensitive"] = ExpressionConverter.ConvertO(getRegexMatchescaseSensitive);
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
                        getRegexMatches["TrimResults"] = ExpressionConverter.ConvertO(getRegexMatchestrimResults);
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
                        getRegexMatches["RemoveEmptyResults"] = ExpressionConverter.ConvertO(getRegexMatchesremoveEmptyResults);
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
                        getRegexMatches["RegexTimeoutInSeconds"] = ExpressionConverter.ConvertO(getRegexMatchesregexTimeoutInSeconds);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetRegexSplit))]
        public IBodyWorkflowAction<GetRegexSplitResponse> GetRegexSplit([WorkflowExpression] Func<string> getRegexSplittextToSplit, [WorkflowExpression] Func<string> getRegexSplitregex, [WorkflowExpression] Func<bool> getRegexSplitcaseSensitive = null, [WorkflowExpression] Func<bool> getRegexSplittrimResults = null, [WorkflowExpression] Func<bool> getRegexSplitremoveEmptyResults = null, [WorkflowExpression] Func<int> getRegexSplitregexTimeoutInSeconds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRegexSplitResponse> __BuildGetRegexSplit(WorkflowValue<string> getRegexSplittextToSplit, WorkflowValue<string> getRegexSplitregex, WorkflowValue<bool> getRegexSplitcaseSensitive = null, WorkflowValue<bool> getRegexSplittrimResults = null, WorkflowValue<bool> getRegexSplitremoveEmptyResults = null, WorkflowValue<int> getRegexSplitregexTimeoutInSeconds = null)
        {
            WorkflowValue.Validate(getRegexSplittextToSplit, nameof(getRegexSplittextToSplit), required: true);
            WorkflowValue.Validate(getRegexSplitregex, nameof(getRegexSplitregex), required: true);
            WorkflowValue.Validate(getRegexSplitcaseSensitive, nameof(getRegexSplitcaseSensitive), required: false);
            WorkflowValue.Validate(getRegexSplittrimResults, nameof(getRegexSplittrimResults), required: false);
            WorkflowValue.Validate(getRegexSplitremoveEmptyResults, nameof(getRegexSplitremoveEmptyResults), required: false);
            WorkflowValue.Validate(getRegexSplitregexTimeoutInSeconds, nameof(getRegexSplitregexTimeoutInSeconds), required: false);
            return new DeferredBodyAction<GetRegexSplitResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetRegexSplit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRegexSplit = new JObject();
                var getRegexSplitpropCount = 0;
                getRegexSplitpropCount++;
                getRegexSplit["TextToSplit"] = ExpressionConverter.ConvertO(getRegexSplittextToSplit);
                getRegexSplitpropCount++;
                getRegexSplit["Regex"] = ExpressionConverter.ConvertO(getRegexSplitregex);
                if (getRegexSplitcaseSensitive != null)
                {
                    if (getRegexSplitcaseSensitive != null)
                    {
                        getRegexSplit["CaseSensitive"] = ExpressionConverter.ConvertO(getRegexSplitcaseSensitive);
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
                        getRegexSplit["TrimResults"] = ExpressionConverter.ConvertO(getRegexSplittrimResults);
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
                        getRegexSplit["RemoveEmptyResults"] = ExpressionConverter.ConvertO(getRegexSplitremoveEmptyResults);
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
                        getRegexSplit["RegexTimeoutInSeconds"] = ExpressionConverter.ConvertO(getRegexSplitregexTimeoutInSeconds);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetRegexGroupMatches))]
        public IBodyWorkflowAction<GetRegexGroupMatchesResponse> GetRegexGroupMatches([WorkflowExpression] Func<string> getRegexGroupMatchestextToMatch, [WorkflowExpression] Func<string> getRegexGroupMatchesregex, [WorkflowExpression] Func<string[]> getRegexGroupMatchesgroupsToRetrieve = null, [WorkflowExpression] Func<int> getRegexGroupMatchessearchIndex = null, [WorkflowExpression] Func<bool> getRegexGroupMatchescaseSensitive = null, [WorkflowExpression] Func<int> getRegexGroupMatchesregexTimeoutInSeconds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRegexGroupMatchesResponse> __BuildGetRegexGroupMatches(WorkflowValue<string> getRegexGroupMatchestextToMatch, WorkflowValue<string> getRegexGroupMatchesregex, WorkflowValue<string[]> getRegexGroupMatchesgroupsToRetrieve = null, WorkflowValue<int> getRegexGroupMatchessearchIndex = null, WorkflowValue<bool> getRegexGroupMatchescaseSensitive = null, WorkflowValue<int> getRegexGroupMatchesregexTimeoutInSeconds = null)
        {
            WorkflowValue.Validate(getRegexGroupMatchestextToMatch, nameof(getRegexGroupMatchestextToMatch), required: true);
            WorkflowValue.Validate(getRegexGroupMatchesregex, nameof(getRegexGroupMatchesregex), required: true);
            WorkflowValue.Validate(getRegexGroupMatchesgroupsToRetrieve, nameof(getRegexGroupMatchesgroupsToRetrieve), required: false);
            WorkflowValue.Validate(getRegexGroupMatchessearchIndex, nameof(getRegexGroupMatchessearchIndex), required: false);
            WorkflowValue.Validate(getRegexGroupMatchescaseSensitive, nameof(getRegexGroupMatchescaseSensitive), required: false);
            WorkflowValue.Validate(getRegexGroupMatchesregexTimeoutInSeconds, nameof(getRegexGroupMatchesregexTimeoutInSeconds), required: false);
            return new DeferredBodyAction<GetRegexGroupMatchesResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetRegexGroupMatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRegexGroupMatches = new JObject();
                var getRegexGroupMatchespropCount = 0;
                getRegexGroupMatchespropCount++;
                getRegexGroupMatches["TextToMatch"] = ExpressionConverter.ConvertO(getRegexGroupMatchestextToMatch);
                getRegexGroupMatchespropCount++;
                getRegexGroupMatches["Regex"] = ExpressionConverter.ConvertO(getRegexGroupMatchesregex);
                if (getRegexGroupMatchesgroupsToRetrieve != null)
                {
                    getRegexGroupMatches["GroupsToRetrieve"] = ExpressionConverter.ConvertO(getRegexGroupMatchesgroupsToRetrieve);
                    getRegexGroupMatchespropCount++;
                }

                if (getRegexGroupMatchessearchIndex != null)
                {
                    if (getRegexGroupMatchessearchIndex != null)
                    {
                        getRegexGroupMatches["SearchIndex"] = ExpressionConverter.ConvertO(getRegexGroupMatchessearchIndex);
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
                        getRegexGroupMatches["CaseSensitive"] = ExpressionConverter.ConvertO(getRegexGroupMatchescaseSensitive);
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
                        getRegexGroupMatches["RegexTimeoutInSeconds"] = ExpressionConverter.ConvertO(getRegexGroupMatchesregexTimeoutInSeconds);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildCreateJSONFromInputVariables))]
        public IBodyWorkflowAction<CreateJSONFromInputVariablesResponse> CreateJSONFromInputVariables([WorkflowExpression] Func<createJSONFromInputVariablesinputVariablesInputItem[]> createJSONFromInputVariablesinputVariables, [WorkflowExpression] Func<bool> createJSONFromInputVariablesreturnAsJSONTable)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateJSONFromInputVariablesResponse> __BuildCreateJSONFromInputVariables(WorkflowValue<createJSONFromInputVariablesinputVariablesInputItem[]> createJSONFromInputVariablesinputVariables, WorkflowValue<bool> createJSONFromInputVariablesreturnAsJSONTable)
        {
            WorkflowValue.Validate(createJSONFromInputVariablesinputVariables, nameof(createJSONFromInputVariablesinputVariables), required: true);
            WorkflowValue.Validate(createJSONFromInputVariablesreturnAsJSONTable, nameof(createJSONFromInputVariablesreturnAsJSONTable), required: true);
            return new DeferredBodyAction<CreateJSONFromInputVariablesResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/CreateJSONFromInputVariables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createJSONFromInputVariables = new JObject();
                var createJSONFromInputVariablespropCount = 0;
                createJSONFromInputVariablespropCount++;
                createJSONFromInputVariables["InputVariables"] = ExpressionConverter.ConvertO(createJSONFromInputVariablesinputVariables);
                createJSONFromInputVariablespropCount++;
                createJSONFromInputVariables["ReturnAsJSONTable"] = ExpressionConverter.ConvertO(createJSONFromInputVariablesreturnAsJSONTable);
                if (createJSONFromInputVariablespropCount > 0)
                {
                    callPayload.Body = createJSONFromInputVariables;
                }

                return new ApiConnectionAction<CreateJSONFromInputVariablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetJSONTableFromStringArray))]
        public IBodyWorkflowAction<GetJSONTableFromStringArrayResponse> GetJSONTableFromStringArray([WorkflowExpression] Func<string[]> getJSONTableFromStringArrayinputArray, [WorkflowExpression] Func<string> getJSONTableFromStringArraycolumnName, [WorkflowExpression] Func<bool> getJSONTableFromStringArraydropEmptyItems = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetJSONTableFromStringArrayResponse> __BuildGetJSONTableFromStringArray(WorkflowValue<string[]> getJSONTableFromStringArrayinputArray, WorkflowValue<string> getJSONTableFromStringArraycolumnName, WorkflowValue<bool> getJSONTableFromStringArraydropEmptyItems = null)
        {
            WorkflowValue.Validate(getJSONTableFromStringArrayinputArray, nameof(getJSONTableFromStringArrayinputArray), required: true);
            WorkflowValue.Validate(getJSONTableFromStringArraycolumnName, nameof(getJSONTableFromStringArraycolumnName), required: true);
            WorkflowValue.Validate(getJSONTableFromStringArraydropEmptyItems, nameof(getJSONTableFromStringArraydropEmptyItems), required: false);
            return new DeferredBodyAction<GetJSONTableFromStringArrayResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetJSONTableFromStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getJSONTableFromStringArray = new JObject();
                var getJSONTableFromStringArraypropCount = 0;
                getJSONTableFromStringArraypropCount++;
                getJSONTableFromStringArray["InputArray"] = ExpressionConverter.ConvertO(getJSONTableFromStringArrayinputArray);
                getJSONTableFromStringArraypropCount++;
                getJSONTableFromStringArray["ColumnName"] = ExpressionConverter.ConvertO(getJSONTableFromStringArraycolumnName);
                if (getJSONTableFromStringArraydropEmptyItems != null)
                {
                    if (getJSONTableFromStringArraydropEmptyItems != null)
                    {
                        getJSONTableFromStringArray["DropEmptyItems"] = ExpressionConverter.ConvertO(getJSONTableFromStringArraydropEmptyItems);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildFilterJSONTable))]
        public IBodyWorkflowAction<FilterJSONTableResponse> FilterJSONTable([WorkflowExpression] Func<string> filterJSONTablejSONTable, [WorkflowExpression] Func<string> filterJSONTablefilter, [WorkflowExpression] Func<string> filterJSONTablesortColumnName = null, [WorkflowExpression] Func<bool> filterJSONTableascending = null, [WorkflowExpression] Func<string> filterJSONTablesortColumnName2 = null, [WorkflowExpression] Func<bool> filterJSONTableascending2 = null, [WorkflowExpression] Func<string> filterJSONTablesortColumnName3 = null, [WorkflowExpression] Func<bool> filterJSONTableascending3 = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FilterJSONTableResponse> __BuildFilterJSONTable(WorkflowValue<string> filterJSONTablejSONTable, WorkflowValue<string> filterJSONTablefilter, WorkflowValue<string> filterJSONTablesortColumnName = null, WorkflowValue<bool> filterJSONTableascending = null, WorkflowValue<string> filterJSONTablesortColumnName2 = null, WorkflowValue<bool> filterJSONTableascending2 = null, WorkflowValue<string> filterJSONTablesortColumnName3 = null, WorkflowValue<bool> filterJSONTableascending3 = null)
        {
            WorkflowValue.Validate(filterJSONTablejSONTable, nameof(filterJSONTablejSONTable), required: true);
            WorkflowValue.Validate(filterJSONTablefilter, nameof(filterJSONTablefilter), required: true);
            WorkflowValue.Validate(filterJSONTablesortColumnName, nameof(filterJSONTablesortColumnName), required: false);
            WorkflowValue.Validate(filterJSONTableascending, nameof(filterJSONTableascending), required: false);
            WorkflowValue.Validate(filterJSONTablesortColumnName2, nameof(filterJSONTablesortColumnName2), required: false);
            WorkflowValue.Validate(filterJSONTableascending2, nameof(filterJSONTableascending2), required: false);
            WorkflowValue.Validate(filterJSONTablesortColumnName3, nameof(filterJSONTablesortColumnName3), required: false);
            WorkflowValue.Validate(filterJSONTableascending3, nameof(filterJSONTableascending3), required: false);
            return new DeferredBodyAction<FilterJSONTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/FilterJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var filterJSONTable = new JObject();
                var filterJSONTablepropCount = 0;
                filterJSONTablepropCount++;
                filterJSONTable["JSONTable"] = ExpressionConverter.ConvertO(filterJSONTablejSONTable);
                filterJSONTablepropCount++;
                filterJSONTable["Filter"] = ExpressionConverter.ConvertO(filterJSONTablefilter);
                if (filterJSONTablesortColumnName != null)
                {
                    filterJSONTable["SortColumnName"] = ExpressionConverter.ConvertO(filterJSONTablesortColumnName);
                    filterJSONTablepropCount++;
                }

                if (filterJSONTableascending != null)
                {
                    if (filterJSONTableascending != null)
                    {
                        filterJSONTable["Ascending"] = ExpressionConverter.ConvertO(filterJSONTableascending);
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
                    filterJSONTable["SortColumnName2"] = ExpressionConverter.ConvertO(filterJSONTablesortColumnName2);
                    filterJSONTablepropCount++;
                }

                if (filterJSONTableascending2 != null)
                {
                    if (filterJSONTableascending2 != null)
                    {
                        filterJSONTable["Ascending2"] = ExpressionConverter.ConvertO(filterJSONTableascending2);
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
                    filterJSONTable["SortColumnName3"] = ExpressionConverter.ConvertO(filterJSONTablesortColumnName3);
                    filterJSONTablepropCount++;
                }

                if (filterJSONTableascending3 != null)
                {
                    if (filterJSONTableascending3 != null)
                    {
                        filterJSONTable["Ascending3"] = ExpressionConverter.ConvertO(filterJSONTableascending3);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildFilterTable))]
        public IBodyWorkflowAction<FilterTableResponse> FilterTable([WorkflowExpression] Func<JToken[]> filterTableinputTable, [WorkflowExpression] Func<string> filterTablefilter, [WorkflowExpression] Func<string> filterTablesortColumnName = null, [WorkflowExpression] Func<bool> filterTableascending = null, [WorkflowExpression] Func<string> filterTablesortColumnName2 = null, [WorkflowExpression] Func<bool> filterTableascending2 = null, [WorkflowExpression] Func<string> filterTablesortColumnName3 = null, [WorkflowExpression] Func<bool> filterTableascending3 = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FilterTableResponse> __BuildFilterTable(WorkflowValue<JToken[]> filterTableinputTable, WorkflowValue<string> filterTablefilter, WorkflowValue<string> filterTablesortColumnName = null, WorkflowValue<bool> filterTableascending = null, WorkflowValue<string> filterTablesortColumnName2 = null, WorkflowValue<bool> filterTableascending2 = null, WorkflowValue<string> filterTablesortColumnName3 = null, WorkflowValue<bool> filterTableascending3 = null)
        {
            WorkflowValue.Validate(filterTableinputTable, nameof(filterTableinputTable), required: true);
            WorkflowValue.Validate(filterTablefilter, nameof(filterTablefilter), required: true);
            WorkflowValue.Validate(filterTablesortColumnName, nameof(filterTablesortColumnName), required: false);
            WorkflowValue.Validate(filterTableascending, nameof(filterTableascending), required: false);
            WorkflowValue.Validate(filterTablesortColumnName2, nameof(filterTablesortColumnName2), required: false);
            WorkflowValue.Validate(filterTableascending2, nameof(filterTableascending2), required: false);
            WorkflowValue.Validate(filterTablesortColumnName3, nameof(filterTablesortColumnName3), required: false);
            WorkflowValue.Validate(filterTableascending3, nameof(filterTableascending3), required: false);
            return new DeferredBodyAction<FilterTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/FilterTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var filterTable = new JObject();
                var filterTablepropCount = 0;
                filterTablepropCount++;
                filterTable["InputTable"] = ExpressionConverter.ConvertO(filterTableinputTable);
                filterTablepropCount++;
                filterTable["Filter"] = ExpressionConverter.ConvertO(filterTablefilter);
                if (filterTablesortColumnName != null)
                {
                    filterTable["SortColumnName"] = ExpressionConverter.ConvertO(filterTablesortColumnName);
                    filterTablepropCount++;
                }

                if (filterTableascending != null)
                {
                    if (filterTableascending != null)
                    {
                        filterTable["Ascending"] = ExpressionConverter.ConvertO(filterTableascending);
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
                    filterTable["SortColumnName2"] = ExpressionConverter.ConvertO(filterTablesortColumnName2);
                    filterTablepropCount++;
                }

                if (filterTableascending2 != null)
                {
                    if (filterTableascending2 != null)
                    {
                        filterTable["Ascending2"] = ExpressionConverter.ConvertO(filterTableascending2);
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
                    filterTable["SortColumnName3"] = ExpressionConverter.ConvertO(filterTablesortColumnName3);
                    filterTablepropCount++;
                }

                if (filterTableascending3 != null)
                {
                    if (filterTableascending3 != null)
                    {
                        filterTable["Ascending3"] = ExpressionConverter.ConvertO(filterTableascending3);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildSortTable))]
        public IBodyWorkflowAction<SortTableResponse> SortTable([WorkflowExpression] Func<JToken[]> sortTableinputTable, [WorkflowExpression] Func<string> sortTablesortColumnName, [WorkflowExpression] Func<bool> sortTableascending, [WorkflowExpression] Func<string> sortTablesortColumnName2 = null, [WorkflowExpression] Func<bool> sortTableascending2 = null, [WorkflowExpression] Func<string> sortTablesortColumnName3 = null, [WorkflowExpression] Func<bool> sortTableascending3 = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SortTableResponse> __BuildSortTable(WorkflowValue<JToken[]> sortTableinputTable, WorkflowValue<string> sortTablesortColumnName, WorkflowValue<bool> sortTableascending, WorkflowValue<string> sortTablesortColumnName2 = null, WorkflowValue<bool> sortTableascending2 = null, WorkflowValue<string> sortTablesortColumnName3 = null, WorkflowValue<bool> sortTableascending3 = null)
        {
            WorkflowValue.Validate(sortTableinputTable, nameof(sortTableinputTable), required: true);
            WorkflowValue.Validate(sortTablesortColumnName, nameof(sortTablesortColumnName), required: true);
            WorkflowValue.Validate(sortTableascending, nameof(sortTableascending), required: true);
            WorkflowValue.Validate(sortTablesortColumnName2, nameof(sortTablesortColumnName2), required: false);
            WorkflowValue.Validate(sortTableascending2, nameof(sortTableascending2), required: false);
            WorkflowValue.Validate(sortTablesortColumnName3, nameof(sortTablesortColumnName3), required: false);
            WorkflowValue.Validate(sortTableascending3, nameof(sortTableascending3), required: false);
            return new DeferredBodyAction<SortTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/SortTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sortTable = new JObject();
                var sortTablepropCount = 0;
                sortTablepropCount++;
                sortTable["InputTable"] = ExpressionConverter.ConvertO(sortTableinputTable);
                sortTablepropCount++;
                sortTable["SortColumnName"] = ExpressionConverter.ConvertO(sortTablesortColumnName);
                sortTablepropCount++;
                sortTable["Ascending"] = ExpressionConverter.ConvertO(sortTableascending);
                if (sortTablesortColumnName2 != null)
                {
                    sortTable["SortColumnName2"] = ExpressionConverter.ConvertO(sortTablesortColumnName2);
                    sortTablepropCount++;
                }

                if (sortTableascending2 != null)
                {
                    if (sortTableascending2 != null)
                    {
                        sortTable["Ascending2"] = ExpressionConverter.ConvertO(sortTableascending2);
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
                    sortTable["SortColumnName3"] = ExpressionConverter.ConvertO(sortTablesortColumnName3);
                    sortTablepropCount++;
                }

                if (sortTableascending3 != null)
                {
                    if (sortTableascending3 != null)
                    {
                        sortTable["Ascending3"] = ExpressionConverter.ConvertO(sortTableascending3);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildSortJSONTable))]
        public IBodyWorkflowAction<SortJSONTableResponse> SortJSONTable([WorkflowExpression] Func<string> sortJSONTablejSONTable, [WorkflowExpression] Func<string> sortJSONTablesortColumnName, [WorkflowExpression] Func<bool> sortJSONTableascending = null, [WorkflowExpression] Func<string> sortJSONTablesortColumnName2 = null, [WorkflowExpression] Func<bool> sortJSONTableascending2 = null, [WorkflowExpression] Func<string> sortJSONTablesortColumnName3 = null, [WorkflowExpression] Func<bool> sortJSONTableascending3 = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SortJSONTableResponse> __BuildSortJSONTable(WorkflowValue<string> sortJSONTablejSONTable, WorkflowValue<string> sortJSONTablesortColumnName, WorkflowValue<bool> sortJSONTableascending = null, WorkflowValue<string> sortJSONTablesortColumnName2 = null, WorkflowValue<bool> sortJSONTableascending2 = null, WorkflowValue<string> sortJSONTablesortColumnName3 = null, WorkflowValue<bool> sortJSONTableascending3 = null)
        {
            WorkflowValue.Validate(sortJSONTablejSONTable, nameof(sortJSONTablejSONTable), required: true);
            WorkflowValue.Validate(sortJSONTablesortColumnName, nameof(sortJSONTablesortColumnName), required: true);
            WorkflowValue.Validate(sortJSONTableascending, nameof(sortJSONTableascending), required: false);
            WorkflowValue.Validate(sortJSONTablesortColumnName2, nameof(sortJSONTablesortColumnName2), required: false);
            WorkflowValue.Validate(sortJSONTableascending2, nameof(sortJSONTableascending2), required: false);
            WorkflowValue.Validate(sortJSONTablesortColumnName3, nameof(sortJSONTablesortColumnName3), required: false);
            WorkflowValue.Validate(sortJSONTableascending3, nameof(sortJSONTableascending3), required: false);
            return new DeferredBodyAction<SortJSONTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/SortJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sortJSONTable = new JObject();
                var sortJSONTablepropCount = 0;
                sortJSONTablepropCount++;
                sortJSONTable["JSONTable"] = ExpressionConverter.ConvertO(sortJSONTablejSONTable);
                sortJSONTablepropCount++;
                sortJSONTable["SortColumnName"] = ExpressionConverter.ConvertO(sortJSONTablesortColumnName);
                if (sortJSONTableascending != null)
                {
                    if (sortJSONTableascending != null)
                    {
                        sortJSONTable["Ascending"] = ExpressionConverter.ConvertO(sortJSONTableascending);
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
                    sortJSONTable["SortColumnName2"] = ExpressionConverter.ConvertO(sortJSONTablesortColumnName2);
                    sortJSONTablepropCount++;
                }

                if (sortJSONTableascending2 != null)
                {
                    if (sortJSONTableascending2 != null)
                    {
                        sortJSONTable["Ascending2"] = ExpressionConverter.ConvertO(sortJSONTableascending2);
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
                    sortJSONTable["SortColumnName3"] = ExpressionConverter.ConvertO(sortJSONTablesortColumnName3);
                    sortJSONTablepropCount++;
                }

                if (sortJSONTableascending3 != null)
                {
                    if (sortJSONTableascending3 != null)
                    {
                        sortJSONTable["Ascending3"] = ExpressionConverter.ConvertO(sortJSONTableascending3);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetTableFromStringArray))]
        public IBodyWorkflowAction<GetTableFromStringArrayResponse> GetTableFromStringArray([WorkflowExpression] Func<string[]> getTableFromStringArrayinputArray, [WorkflowExpression] Func<string> getTableFromStringArraycolumnName, [WorkflowExpression] Func<bool> getTableFromStringArraydropEmptyItems = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTableFromStringArrayResponse> __BuildGetTableFromStringArray(WorkflowValue<string[]> getTableFromStringArrayinputArray, WorkflowValue<string> getTableFromStringArraycolumnName, WorkflowValue<bool> getTableFromStringArraydropEmptyItems = null)
        {
            WorkflowValue.Validate(getTableFromStringArrayinputArray, nameof(getTableFromStringArrayinputArray), required: true);
            WorkflowValue.Validate(getTableFromStringArraycolumnName, nameof(getTableFromStringArraycolumnName), required: true);
            WorkflowValue.Validate(getTableFromStringArraydropEmptyItems, nameof(getTableFromStringArraydropEmptyItems), required: false);
            return new DeferredBodyAction<GetTableFromStringArrayResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetTableFromStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getTableFromStringArray = new JObject();
                var getTableFromStringArraypropCount = 0;
                getTableFromStringArraypropCount++;
                getTableFromStringArray["InputArray"] = ExpressionConverter.ConvertO(getTableFromStringArrayinputArray);
                getTableFromStringArraypropCount++;
                getTableFromStringArray["ColumnName"] = ExpressionConverter.ConvertO(getTableFromStringArraycolumnName);
                if (getTableFromStringArraydropEmptyItems != null)
                {
                    if (getTableFromStringArraydropEmptyItems != null)
                    {
                        getTableFromStringArray["DropEmptyItems"] = ExpressionConverter.ConvertO(getTableFromStringArraydropEmptyItems);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetTableFromJSON))]
        public IBodyWorkflowAction<GetTableFromJSONResponse> GetTableFromJSON([WorkflowExpression] Func<string> getTableFromJSONjSONTable, [WorkflowExpression] Func<int> getTableFromJSONstartRowIndex, [WorkflowExpression] Func<int> getTableFromJSONnumberOfRowsToRetrieve = null, [WorkflowExpression] Func<int> getTableFromJSONstartColumnIndex = null, [WorkflowExpression] Func<string> getTableFromJSONstartColumnName = null, [WorkflowExpression] Func<int> getTableFromJSONnumberOfColumnsToRetrieve = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTableFromJSONResponse> __BuildGetTableFromJSON(WorkflowValue<string> getTableFromJSONjSONTable, WorkflowValue<int> getTableFromJSONstartRowIndex, WorkflowValue<int> getTableFromJSONnumberOfRowsToRetrieve = null, WorkflowValue<int> getTableFromJSONstartColumnIndex = null, WorkflowValue<string> getTableFromJSONstartColumnName = null, WorkflowValue<int> getTableFromJSONnumberOfColumnsToRetrieve = null)
        {
            WorkflowValue.Validate(getTableFromJSONjSONTable, nameof(getTableFromJSONjSONTable), required: true);
            WorkflowValue.Validate(getTableFromJSONstartRowIndex, nameof(getTableFromJSONstartRowIndex), required: true);
            WorkflowValue.Validate(getTableFromJSONnumberOfRowsToRetrieve, nameof(getTableFromJSONnumberOfRowsToRetrieve), required: false);
            WorkflowValue.Validate(getTableFromJSONstartColumnIndex, nameof(getTableFromJSONstartColumnIndex), required: false);
            WorkflowValue.Validate(getTableFromJSONstartColumnName, nameof(getTableFromJSONstartColumnName), required: false);
            WorkflowValue.Validate(getTableFromJSONnumberOfColumnsToRetrieve, nameof(getTableFromJSONnumberOfColumnsToRetrieve), required: false);
            return new DeferredBodyAction<GetTableFromJSONResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetTableFromJSON";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getTableFromJSON = new JObject();
                var getTableFromJSONpropCount = 0;
                getTableFromJSONpropCount++;
                getTableFromJSON["JSONTable"] = ExpressionConverter.ConvertO(getTableFromJSONjSONTable);
                getTableFromJSONpropCount++;
                getTableFromJSON["StartRowIndex"] = ExpressionConverter.ConvertO(getTableFromJSONstartRowIndex);
                if (getTableFromJSONnumberOfRowsToRetrieve != null)
                {
                    getTableFromJSON["NumberOfRowsToRetrieve"] = ExpressionConverter.ConvertO(getTableFromJSONnumberOfRowsToRetrieve);
                    getTableFromJSONpropCount++;
                }

                if (getTableFromJSONstartColumnIndex != null)
                {
                    if (getTableFromJSONstartColumnIndex != null)
                    {
                        getTableFromJSON["StartColumnIndex"] = ExpressionConverter.ConvertO(getTableFromJSONstartColumnIndex);
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
                    getTableFromJSON["StartColumnName"] = ExpressionConverter.ConvertO(getTableFromJSONstartColumnName);
                    getTableFromJSONpropCount++;
                }

                if (getTableFromJSONnumberOfColumnsToRetrieve != null)
                {
                    getTableFromJSON["NumberOfColumnsToRetrieve"] = ExpressionConverter.ConvertO(getTableFromJSONnumberOfColumnsToRetrieve);
                    getTableFromJSONpropCount++;
                }

                if (getTableFromJSONpropCount > 0)
                {
                    callPayload.Body = getTableFromJSON;
                }

                return new ApiConnectionAction<GetTableFromJSONResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildSortStringArray))]
        public IBodyWorkflowAction<SortStringArrayResponse> SortStringArray([WorkflowExpression] Func<string[]> sortStringArrayinputArray, [WorkflowExpression] Func<bool> sortStringArrayascending = null, [WorkflowExpression] Func<bool> sortStringArraycaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SortStringArrayResponse> __BuildSortStringArray(WorkflowValue<string[]> sortStringArrayinputArray, WorkflowValue<bool> sortStringArrayascending = null, WorkflowValue<bool> sortStringArraycaseSensitive = null)
        {
            WorkflowValue.Validate(sortStringArrayinputArray, nameof(sortStringArrayinputArray), required: true);
            WorkflowValue.Validate(sortStringArrayascending, nameof(sortStringArrayascending), required: false);
            WorkflowValue.Validate(sortStringArraycaseSensitive, nameof(sortStringArraycaseSensitive), required: false);
            return new DeferredBodyAction<SortStringArrayResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/SortStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sortStringArray = new JObject();
                var sortStringArraypropCount = 0;
                sortStringArraypropCount++;
                sortStringArray["InputArray"] = ExpressionConverter.ConvertO(sortStringArrayinputArray);
                if (sortStringArrayascending != null)
                {
                    if (sortStringArrayascending != null)
                    {
                        sortStringArray["Ascending"] = ExpressionConverter.ConvertO(sortStringArrayascending);
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
                        sortStringArray["CaseSensitive"] = ExpressionConverter.ConvertO(sortStringArraycaseSensitive);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildFilterStringArray))]
        public IBodyWorkflowAction<FilterStringArrayResponse> FilterStringArray([WorkflowExpression] Func<string[]> filterStringArrayinputArray, [WorkflowExpression] Func<string> filterStringArraycolumnName, [WorkflowExpression] Func<string> filterStringArrayfilter)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FilterStringArrayResponse> __BuildFilterStringArray(WorkflowValue<string[]> filterStringArrayinputArray, WorkflowValue<string> filterStringArraycolumnName, WorkflowValue<string> filterStringArrayfilter)
        {
            WorkflowValue.Validate(filterStringArrayinputArray, nameof(filterStringArrayinputArray), required: true);
            WorkflowValue.Validate(filterStringArraycolumnName, nameof(filterStringArraycolumnName), required: true);
            WorkflowValue.Validate(filterStringArrayfilter, nameof(filterStringArrayfilter), required: true);
            return new DeferredBodyAction<FilterStringArrayResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/FilterStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var filterStringArray = new JObject();
                var filterStringArraypropCount = 0;
                filterStringArraypropCount++;
                filterStringArray["InputArray"] = ExpressionConverter.ConvertO(filterStringArrayinputArray);
                filterStringArraypropCount++;
                filterStringArray["ColumnName"] = ExpressionConverter.ConvertO(filterStringArraycolumnName);
                filterStringArraypropCount++;
                filterStringArray["Filter"] = ExpressionConverter.ConvertO(filterStringArrayfilter);
                if (filterStringArraypropCount > 0)
                {
                    callPayload.Body = filterStringArray;
                }

                return new ApiConnectionAction<FilterStringArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildInsertRowInStringArray))]
        public IBodyWorkflowAction<InsertRowInStringArrayResponse> InsertRowInStringArray([WorkflowExpression] Func<string[]> insertRowInStringArrayinputArray, [WorkflowExpression] Func<int> insertRowInStringArrayrowIndex, [WorkflowExpression] Func<string> insertRowInStringArrayvalueToInsert = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InsertRowInStringArrayResponse> __BuildInsertRowInStringArray(WorkflowValue<string[]> insertRowInStringArrayinputArray, WorkflowValue<int> insertRowInStringArrayrowIndex, WorkflowValue<string> insertRowInStringArrayvalueToInsert = null)
        {
            WorkflowValue.Validate(insertRowInStringArrayinputArray, nameof(insertRowInStringArrayinputArray), required: true);
            WorkflowValue.Validate(insertRowInStringArrayrowIndex, nameof(insertRowInStringArrayrowIndex), required: true);
            WorkflowValue.Validate(insertRowInStringArrayvalueToInsert, nameof(insertRowInStringArrayvalueToInsert), required: false);
            return new DeferredBodyAction<InsertRowInStringArrayResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/InsertRowInStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var insertRowInStringArray = new JObject();
                var insertRowInStringArraypropCount = 0;
                insertRowInStringArraypropCount++;
                insertRowInStringArray["InputArray"] = ExpressionConverter.ConvertO(insertRowInStringArrayinputArray);
                insertRowInStringArraypropCount++;
                insertRowInStringArray["RowIndex"] = ExpressionConverter.ConvertO(insertRowInStringArrayrowIndex);
                if (insertRowInStringArrayvalueToInsert != null)
                {
                    insertRowInStringArray["ValueToInsert"] = ExpressionConverter.ConvertO(insertRowInStringArrayvalueToInsert);
                    insertRowInStringArraypropCount++;
                }

                if (insertRowInStringArraypropCount > 0)
                {
                    callPayload.Body = insertRowInStringArray;
                }

                return new ApiConnectionAction<InsertRowInStringArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildInsertRowInTable))]
        public IBodyWorkflowAction<InsertRowInTableResponse> InsertRowInTable([WorkflowExpression] Func<JToken[]> insertRowInTableinputTable, [WorkflowExpression] Func<int> insertRowInTablerowIndex, [WorkflowExpression] Func<string> insertRowInTablerowToInsertJSON = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InsertRowInTableResponse> __BuildInsertRowInTable(WorkflowValue<JToken[]> insertRowInTableinputTable, WorkflowValue<int> insertRowInTablerowIndex, WorkflowValue<string> insertRowInTablerowToInsertJSON = null)
        {
            WorkflowValue.Validate(insertRowInTableinputTable, nameof(insertRowInTableinputTable), required: true);
            WorkflowValue.Validate(insertRowInTablerowIndex, nameof(insertRowInTablerowIndex), required: true);
            WorkflowValue.Validate(insertRowInTablerowToInsertJSON, nameof(insertRowInTablerowToInsertJSON), required: false);
            return new DeferredBodyAction<InsertRowInTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/InsertRowInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var insertRowInTable = new JObject();
                var insertRowInTablepropCount = 0;
                insertRowInTablepropCount++;
                insertRowInTable["InputTable"] = ExpressionConverter.ConvertO(insertRowInTableinputTable);
                insertRowInTablepropCount++;
                insertRowInTable["RowIndex"] = ExpressionConverter.ConvertO(insertRowInTablerowIndex);
                if (insertRowInTablerowToInsertJSON != null)
                {
                    insertRowInTable["RowToInsertJSON"] = ExpressionConverter.ConvertO(insertRowInTablerowToInsertJSON);
                    insertRowInTablepropCount++;
                }

                if (insertRowInTablepropCount > 0)
                {
                    callPayload.Body = insertRowInTable;
                }

                return new ApiConnectionAction<InsertRowInTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildInsertRowInJSONTable))]
        public IBodyWorkflowAction<InsertRowInJSONTableResponse> InsertRowInJSONTable([WorkflowExpression] Func<string> insertRowInJSONTablejSONTable, [WorkflowExpression] Func<int> insertRowInJSONTablerowIndex, [WorkflowExpression] Func<string> insertRowInJSONTablerowToInsertJSON = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InsertRowInJSONTableResponse> __BuildInsertRowInJSONTable(WorkflowValue<string> insertRowInJSONTablejSONTable, WorkflowValue<int> insertRowInJSONTablerowIndex, WorkflowValue<string> insertRowInJSONTablerowToInsertJSON = null)
        {
            WorkflowValue.Validate(insertRowInJSONTablejSONTable, nameof(insertRowInJSONTablejSONTable), required: true);
            WorkflowValue.Validate(insertRowInJSONTablerowIndex, nameof(insertRowInJSONTablerowIndex), required: true);
            WorkflowValue.Validate(insertRowInJSONTablerowToInsertJSON, nameof(insertRowInJSONTablerowToInsertJSON), required: false);
            return new DeferredBodyAction<InsertRowInJSONTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/InsertRowInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var insertRowInJSONTable = new JObject();
                var insertRowInJSONTablepropCount = 0;
                insertRowInJSONTablepropCount++;
                insertRowInJSONTable["JSONTable"] = ExpressionConverter.ConvertO(insertRowInJSONTablejSONTable);
                insertRowInJSONTablepropCount++;
                insertRowInJSONTable["RowIndex"] = ExpressionConverter.ConvertO(insertRowInJSONTablerowIndex);
                if (insertRowInJSONTablerowToInsertJSON != null)
                {
                    insertRowInJSONTable["RowToInsertJSON"] = ExpressionConverter.ConvertO(insertRowInJSONTablerowToInsertJSON);
                    insertRowInJSONTablepropCount++;
                }

                if (insertRowInJSONTablepropCount > 0)
                {
                    callPayload.Body = insertRowInJSONTable;
                }

                return new ApiConnectionAction<InsertRowInJSONTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildInsertRowInJSONTableFromInputVariables))]
        public IBodyWorkflowAction<InsertRowInJSONTableFromInputVariablesResponse> InsertRowInJSONTableFromInputVariables([WorkflowExpression] Func<string> insertRowInJSONTableFromInputVariablesjSONTable, [WorkflowExpression] Func<int> insertRowInJSONTableFromInputVariablesrowIndex, [WorkflowExpression] Func<insertRowInJSONTableFromInputVariablesrowToInsertInputVariablesInputItem[]> insertRowInJSONTableFromInputVariablesrowToInsertInputVariables)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InsertRowInJSONTableFromInputVariablesResponse> __BuildInsertRowInJSONTableFromInputVariables(WorkflowValue<string> insertRowInJSONTableFromInputVariablesjSONTable, WorkflowValue<int> insertRowInJSONTableFromInputVariablesrowIndex, WorkflowValue<insertRowInJSONTableFromInputVariablesrowToInsertInputVariablesInputItem[]> insertRowInJSONTableFromInputVariablesrowToInsertInputVariables)
        {
            WorkflowValue.Validate(insertRowInJSONTableFromInputVariablesjSONTable, nameof(insertRowInJSONTableFromInputVariablesjSONTable), required: true);
            WorkflowValue.Validate(insertRowInJSONTableFromInputVariablesrowIndex, nameof(insertRowInJSONTableFromInputVariablesrowIndex), required: true);
            WorkflowValue.Validate(insertRowInJSONTableFromInputVariablesrowToInsertInputVariables, nameof(insertRowInJSONTableFromInputVariablesrowToInsertInputVariables), required: true);
            return new DeferredBodyAction<InsertRowInJSONTableFromInputVariablesResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/InsertRowInJSONTableFromInputVariables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var insertRowInJSONTableFromInputVariables = new JObject();
                var insertRowInJSONTableFromInputVariablespropCount = 0;
                insertRowInJSONTableFromInputVariablespropCount++;
                insertRowInJSONTableFromInputVariables["JSONTable"] = ExpressionConverter.ConvertO(insertRowInJSONTableFromInputVariablesjSONTable);
                insertRowInJSONTableFromInputVariablespropCount++;
                insertRowInJSONTableFromInputVariables["RowIndex"] = ExpressionConverter.ConvertO(insertRowInJSONTableFromInputVariablesrowIndex);
                insertRowInJSONTableFromInputVariablespropCount++;
                insertRowInJSONTableFromInputVariables["RowToInsertInputVariables"] = ExpressionConverter.ConvertO(insertRowInJSONTableFromInputVariablesrowToInsertInputVariables);
                if (insertRowInJSONTableFromInputVariablespropCount > 0)
                {
                    callPayload.Body = insertRowInJSONTableFromInputVariables;
                }

                return new ApiConnectionAction<InsertRowInJSONTableFromInputVariablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteItemsInStringArray))]
        public IBodyWorkflowAction<DeleteItemsInStringArrayResponse> DeleteItemsInStringArray([WorkflowExpression] Func<string[]> deleteItemsInStringArrayinputArray, [WorkflowExpression] Func<int> deleteItemsInStringArraystartItemIndex, [WorkflowExpression] Func<int> deleteItemsInStringArraynumberOfItemsToDelete)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteItemsInStringArrayResponse> __BuildDeleteItemsInStringArray(WorkflowValue<string[]> deleteItemsInStringArrayinputArray, WorkflowValue<int> deleteItemsInStringArraystartItemIndex, WorkflowValue<int> deleteItemsInStringArraynumberOfItemsToDelete)
        {
            WorkflowValue.Validate(deleteItemsInStringArrayinputArray, nameof(deleteItemsInStringArrayinputArray), required: true);
            WorkflowValue.Validate(deleteItemsInStringArraystartItemIndex, nameof(deleteItemsInStringArraystartItemIndex), required: true);
            WorkflowValue.Validate(deleteItemsInStringArraynumberOfItemsToDelete, nameof(deleteItemsInStringArraynumberOfItemsToDelete), required: true);
            return new DeferredBodyAction<DeleteItemsInStringArrayResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteItemsInStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteItemsInStringArray = new JObject();
                var deleteItemsInStringArraypropCount = 0;
                deleteItemsInStringArraypropCount++;
                deleteItemsInStringArray["InputArray"] = ExpressionConverter.ConvertO(deleteItemsInStringArrayinputArray);
                deleteItemsInStringArraypropCount++;
                deleteItemsInStringArray["StartItemIndex"] = ExpressionConverter.ConvertO(deleteItemsInStringArraystartItemIndex);
                deleteItemsInStringArraypropCount++;
                deleteItemsInStringArray["NumberOfItemsToDelete"] = ExpressionConverter.ConvertO(deleteItemsInStringArraynumberOfItemsToDelete);
                if (deleteItemsInStringArraypropCount > 0)
                {
                    callPayload.Body = deleteItemsInStringArray;
                }

                return new ApiConnectionAction<DeleteItemsInStringArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteRowsInTable))]
        public IBodyWorkflowAction<DeleteRowsInTableResponse> DeleteRowsInTable([WorkflowExpression] Func<JToken[]> deleteRowsInTableinputTable, [WorkflowExpression] Func<int> deleteRowsInTablestartRowIndex, [WorkflowExpression] Func<int> deleteRowsInTablenumberOfRowsToDelete)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteRowsInTableResponse> __BuildDeleteRowsInTable(WorkflowValue<JToken[]> deleteRowsInTableinputTable, WorkflowValue<int> deleteRowsInTablestartRowIndex, WorkflowValue<int> deleteRowsInTablenumberOfRowsToDelete)
        {
            WorkflowValue.Validate(deleteRowsInTableinputTable, nameof(deleteRowsInTableinputTable), required: true);
            WorkflowValue.Validate(deleteRowsInTablestartRowIndex, nameof(deleteRowsInTablestartRowIndex), required: true);
            WorkflowValue.Validate(deleteRowsInTablenumberOfRowsToDelete, nameof(deleteRowsInTablenumberOfRowsToDelete), required: true);
            return new DeferredBodyAction<DeleteRowsInTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteRowsInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteRowsInTable = new JObject();
                var deleteRowsInTablepropCount = 0;
                deleteRowsInTablepropCount++;
                deleteRowsInTable["InputTable"] = ExpressionConverter.ConvertO(deleteRowsInTableinputTable);
                deleteRowsInTablepropCount++;
                deleteRowsInTable["StartRowIndex"] = ExpressionConverter.ConvertO(deleteRowsInTablestartRowIndex);
                deleteRowsInTablepropCount++;
                deleteRowsInTable["NumberOfRowsToDelete"] = ExpressionConverter.ConvertO(deleteRowsInTablenumberOfRowsToDelete);
                if (deleteRowsInTablepropCount > 0)
                {
                    callPayload.Body = deleteRowsInTable;
                }

                return new ApiConnectionAction<DeleteRowsInTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteRowsInJSONTable))]
        public IBodyWorkflowAction<DeleteRowsInJSONTableResponse> DeleteRowsInJSONTable([WorkflowExpression] Func<string> deleteRowsInJSONTablejSONTable, [WorkflowExpression] Func<int> deleteRowsInJSONTablestartRowIndex, [WorkflowExpression] Func<int> deleteRowsInJSONTablenumberOfRowsToDelete)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteRowsInJSONTableResponse> __BuildDeleteRowsInJSONTable(WorkflowValue<string> deleteRowsInJSONTablejSONTable, WorkflowValue<int> deleteRowsInJSONTablestartRowIndex, WorkflowValue<int> deleteRowsInJSONTablenumberOfRowsToDelete)
        {
            WorkflowValue.Validate(deleteRowsInJSONTablejSONTable, nameof(deleteRowsInJSONTablejSONTable), required: true);
            WorkflowValue.Validate(deleteRowsInJSONTablestartRowIndex, nameof(deleteRowsInJSONTablestartRowIndex), required: true);
            WorkflowValue.Validate(deleteRowsInJSONTablenumberOfRowsToDelete, nameof(deleteRowsInJSONTablenumberOfRowsToDelete), required: true);
            return new DeferredBodyAction<DeleteRowsInJSONTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteRowsInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteRowsInJSONTable = new JObject();
                var deleteRowsInJSONTablepropCount = 0;
                deleteRowsInJSONTablepropCount++;
                deleteRowsInJSONTable["JSONTable"] = ExpressionConverter.ConvertO(deleteRowsInJSONTablejSONTable);
                deleteRowsInJSONTablepropCount++;
                deleteRowsInJSONTable["StartRowIndex"] = ExpressionConverter.ConvertO(deleteRowsInJSONTablestartRowIndex);
                deleteRowsInJSONTablepropCount++;
                deleteRowsInJSONTable["NumberOfRowsToDelete"] = ExpressionConverter.ConvertO(deleteRowsInJSONTablenumberOfRowsToDelete);
                if (deleteRowsInJSONTablepropCount > 0)
                {
                    callPayload.Body = deleteRowsInJSONTable;
                }

                return new ApiConnectionAction<DeleteRowsInJSONTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildRenameColumnInTable))]
        public IBodyWorkflowAction<RenameColumnInTableResponse> RenameColumnInTable([WorkflowExpression] Func<JToken[]> renameColumnInTableinputTable, [WorkflowExpression] Func<string> renameColumnInTablesourceColumnName, [WorkflowExpression] Func<string> renameColumnInTablenewColumnName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RenameColumnInTableResponse> __BuildRenameColumnInTable(WorkflowValue<JToken[]> renameColumnInTableinputTable, WorkflowValue<string> renameColumnInTablesourceColumnName, WorkflowValue<string> renameColumnInTablenewColumnName)
        {
            WorkflowValue.Validate(renameColumnInTableinputTable, nameof(renameColumnInTableinputTable), required: true);
            WorkflowValue.Validate(renameColumnInTablesourceColumnName, nameof(renameColumnInTablesourceColumnName), required: true);
            WorkflowValue.Validate(renameColumnInTablenewColumnName, nameof(renameColumnInTablenewColumnName), required: true);
            return new DeferredBodyAction<RenameColumnInTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/RenameColumnInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var renameColumnInTable = new JObject();
                var renameColumnInTablepropCount = 0;
                renameColumnInTablepropCount++;
                renameColumnInTable["InputTable"] = ExpressionConverter.ConvertO(renameColumnInTableinputTable);
                renameColumnInTablepropCount++;
                renameColumnInTable["SourceColumnName"] = ExpressionConverter.ConvertO(renameColumnInTablesourceColumnName);
                renameColumnInTablepropCount++;
                renameColumnInTable["NewColumnName"] = ExpressionConverter.ConvertO(renameColumnInTablenewColumnName);
                if (renameColumnInTablepropCount > 0)
                {
                    callPayload.Body = renameColumnInTable;
                }

                return new ApiConnectionAction<RenameColumnInTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildRenameColumnInJSONTable))]
        public IBodyWorkflowAction<RenameColumnInJSONTableResponse> RenameColumnInJSONTable([WorkflowExpression] Func<string> renameColumnInJSONTablejSONTable, [WorkflowExpression] Func<string> renameColumnInJSONTablesourceColumnName, [WorkflowExpression] Func<string> renameColumnInJSONTablenewColumnName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RenameColumnInJSONTableResponse> __BuildRenameColumnInJSONTable(WorkflowValue<string> renameColumnInJSONTablejSONTable, WorkflowValue<string> renameColumnInJSONTablesourceColumnName, WorkflowValue<string> renameColumnInJSONTablenewColumnName)
        {
            WorkflowValue.Validate(renameColumnInJSONTablejSONTable, nameof(renameColumnInJSONTablejSONTable), required: true);
            WorkflowValue.Validate(renameColumnInJSONTablesourceColumnName, nameof(renameColumnInJSONTablesourceColumnName), required: true);
            WorkflowValue.Validate(renameColumnInJSONTablenewColumnName, nameof(renameColumnInJSONTablenewColumnName), required: true);
            return new DeferredBodyAction<RenameColumnInJSONTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/RenameColumnInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var renameColumnInJSONTable = new JObject();
                var renameColumnInJSONTablepropCount = 0;
                renameColumnInJSONTablepropCount++;
                renameColumnInJSONTable["JSONTable"] = ExpressionConverter.ConvertO(renameColumnInJSONTablejSONTable);
                renameColumnInJSONTablepropCount++;
                renameColumnInJSONTable["SourceColumnName"] = ExpressionConverter.ConvertO(renameColumnInJSONTablesourceColumnName);
                renameColumnInJSONTablepropCount++;
                renameColumnInJSONTable["NewColumnName"] = ExpressionConverter.ConvertO(renameColumnInJSONTablenewColumnName);
                if (renameColumnInJSONTablepropCount > 0)
                {
                    callPayload.Body = renameColumnInJSONTable;
                }

                return new ApiConnectionAction<RenameColumnInJSONTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteColumnsInTable))]
        public IBodyWorkflowAction<DeleteColumnsInTableResponse> DeleteColumnsInTable([WorkflowExpression] Func<JToken[]> deleteColumnsInTableinputTable, [WorkflowExpression] Func<int> deleteColumnsInTablenumberOfColumnsToDelete, [WorkflowExpression] Func<int> deleteColumnsInTablestartColumnIndex = null, [WorkflowExpression] Func<string> deleteColumnsInTablecolumnNameToDelete = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteColumnsInTableResponse> __BuildDeleteColumnsInTable(WorkflowValue<JToken[]> deleteColumnsInTableinputTable, WorkflowValue<int> deleteColumnsInTablenumberOfColumnsToDelete, WorkflowValue<int> deleteColumnsInTablestartColumnIndex = null, WorkflowValue<string> deleteColumnsInTablecolumnNameToDelete = null)
        {
            WorkflowValue.Validate(deleteColumnsInTableinputTable, nameof(deleteColumnsInTableinputTable), required: true);
            WorkflowValue.Validate(deleteColumnsInTablenumberOfColumnsToDelete, nameof(deleteColumnsInTablenumberOfColumnsToDelete), required: true);
            WorkflowValue.Validate(deleteColumnsInTablestartColumnIndex, nameof(deleteColumnsInTablestartColumnIndex), required: false);
            WorkflowValue.Validate(deleteColumnsInTablecolumnNameToDelete, nameof(deleteColumnsInTablecolumnNameToDelete), required: false);
            return new DeferredBodyAction<DeleteColumnsInTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteColumnsInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteColumnsInTable = new JObject();
                var deleteColumnsInTablepropCount = 0;
                deleteColumnsInTablepropCount++;
                deleteColumnsInTable["InputTable"] = ExpressionConverter.ConvertO(deleteColumnsInTableinputTable);
                if (deleteColumnsInTablestartColumnIndex != null)
                {
                    deleteColumnsInTable["StartColumnIndex"] = ExpressionConverter.ConvertO(deleteColumnsInTablestartColumnIndex);
                    deleteColumnsInTablepropCount++;
                }

                if (deleteColumnsInTablecolumnNameToDelete != null)
                {
                    deleteColumnsInTable["ColumnNameToDelete"] = ExpressionConverter.ConvertO(deleteColumnsInTablecolumnNameToDelete);
                    deleteColumnsInTablepropCount++;
                }

                deleteColumnsInTablepropCount++;
                deleteColumnsInTable["NumberOfColumnsToDelete"] = ExpressionConverter.ConvertO(deleteColumnsInTablenumberOfColumnsToDelete);
                if (deleteColumnsInTablepropCount > 0)
                {
                    callPayload.Body = deleteColumnsInTable;
                }

                return new ApiConnectionAction<DeleteColumnsInTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteColumnsInJSONTable))]
        public IBodyWorkflowAction<DeleteColumnsInJSONTableResponse> DeleteColumnsInJSONTable([WorkflowExpression] Func<string> deleteColumnsInJSONTablejSONTable, [WorkflowExpression] Func<int> deleteColumnsInJSONTablenumberOfColumnsToDelete, [WorkflowExpression] Func<int> deleteColumnsInJSONTablestartColumnIndex = null, [WorkflowExpression] Func<string> deleteColumnsInJSONTablecolumnNameToDelete = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteColumnsInJSONTableResponse> __BuildDeleteColumnsInJSONTable(WorkflowValue<string> deleteColumnsInJSONTablejSONTable, WorkflowValue<int> deleteColumnsInJSONTablenumberOfColumnsToDelete, WorkflowValue<int> deleteColumnsInJSONTablestartColumnIndex = null, WorkflowValue<string> deleteColumnsInJSONTablecolumnNameToDelete = null)
        {
            WorkflowValue.Validate(deleteColumnsInJSONTablejSONTable, nameof(deleteColumnsInJSONTablejSONTable), required: true);
            WorkflowValue.Validate(deleteColumnsInJSONTablenumberOfColumnsToDelete, nameof(deleteColumnsInJSONTablenumberOfColumnsToDelete), required: true);
            WorkflowValue.Validate(deleteColumnsInJSONTablestartColumnIndex, nameof(deleteColumnsInJSONTablestartColumnIndex), required: false);
            WorkflowValue.Validate(deleteColumnsInJSONTablecolumnNameToDelete, nameof(deleteColumnsInJSONTablecolumnNameToDelete), required: false);
            return new DeferredBodyAction<DeleteColumnsInJSONTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteColumnsInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteColumnsInJSONTable = new JObject();
                var deleteColumnsInJSONTablepropCount = 0;
                deleteColumnsInJSONTablepropCount++;
                deleteColumnsInJSONTable["JSONTable"] = ExpressionConverter.ConvertO(deleteColumnsInJSONTablejSONTable);
                if (deleteColumnsInJSONTablestartColumnIndex != null)
                {
                    deleteColumnsInJSONTable["StartColumnIndex"] = ExpressionConverter.ConvertO(deleteColumnsInJSONTablestartColumnIndex);
                    deleteColumnsInJSONTablepropCount++;
                }

                if (deleteColumnsInJSONTablecolumnNameToDelete != null)
                {
                    deleteColumnsInJSONTable["ColumnNameToDelete"] = ExpressionConverter.ConvertO(deleteColumnsInJSONTablecolumnNameToDelete);
                    deleteColumnsInJSONTablepropCount++;
                }

                deleteColumnsInJSONTablepropCount++;
                deleteColumnsInJSONTable["NumberOfColumnsToDelete"] = ExpressionConverter.ConvertO(deleteColumnsInJSONTablenumberOfColumnsToDelete);
                if (deleteColumnsInJSONTablepropCount > 0)
                {
                    callPayload.Body = deleteColumnsInJSONTable;
                }

                return new ApiConnectionAction<DeleteColumnsInJSONTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetStringArrayFromTableColumn))]
        public IBodyWorkflowAction<GetStringArrayFromTableColumnResponse> GetStringArrayFromTableColumn([WorkflowExpression] Func<JToken[]> getStringArrayFromTableColumninputTable, [WorkflowExpression] Func<int> getStringArrayFromTableColumncolumnIndex = null, [WorkflowExpression] Func<string> getStringArrayFromTableColumncolumnName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStringArrayFromTableColumnResponse> __BuildGetStringArrayFromTableColumn(WorkflowValue<JToken[]> getStringArrayFromTableColumninputTable, WorkflowValue<int> getStringArrayFromTableColumncolumnIndex = null, WorkflowValue<string> getStringArrayFromTableColumncolumnName = null)
        {
            WorkflowValue.Validate(getStringArrayFromTableColumninputTable, nameof(getStringArrayFromTableColumninputTable), required: true);
            WorkflowValue.Validate(getStringArrayFromTableColumncolumnIndex, nameof(getStringArrayFromTableColumncolumnIndex), required: false);
            WorkflowValue.Validate(getStringArrayFromTableColumncolumnName, nameof(getStringArrayFromTableColumncolumnName), required: false);
            return new DeferredBodyAction<GetStringArrayFromTableColumnResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetStringArrayFromTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getStringArrayFromTableColumn = new JObject();
                var getStringArrayFromTableColumnpropCount = 0;
                getStringArrayFromTableColumnpropCount++;
                getStringArrayFromTableColumn["InputTable"] = ExpressionConverter.ConvertO(getStringArrayFromTableColumninputTable);
                if (getStringArrayFromTableColumncolumnIndex != null)
                {
                    getStringArrayFromTableColumn["ColumnIndex"] = ExpressionConverter.ConvertO(getStringArrayFromTableColumncolumnIndex);
                    getStringArrayFromTableColumnpropCount++;
                }

                if (getStringArrayFromTableColumncolumnName != null)
                {
                    getStringArrayFromTableColumn["ColumnName"] = ExpressionConverter.ConvertO(getStringArrayFromTableColumncolumnName);
                    getStringArrayFromTableColumnpropCount++;
                }

                if (getStringArrayFromTableColumnpropCount > 0)
                {
                    callPayload.Body = getStringArrayFromTableColumn;
                }

                return new ApiConnectionAction<GetStringArrayFromTableColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetStringArrayFromJSONTableColumn))]
        public IBodyWorkflowAction<GetStringArrayFromJSONTableColumnResponse> GetStringArrayFromJSONTableColumn([WorkflowExpression] Func<string> getStringArrayFromJSONTableColumnjSONTable, [WorkflowExpression] Func<int> getStringArrayFromJSONTableColumncolumnIndex = null, [WorkflowExpression] Func<string> getStringArrayFromJSONTableColumncolumnName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStringArrayFromJSONTableColumnResponse> __BuildGetStringArrayFromJSONTableColumn(WorkflowValue<string> getStringArrayFromJSONTableColumnjSONTable, WorkflowValue<int> getStringArrayFromJSONTableColumncolumnIndex = null, WorkflowValue<string> getStringArrayFromJSONTableColumncolumnName = null)
        {
            WorkflowValue.Validate(getStringArrayFromJSONTableColumnjSONTable, nameof(getStringArrayFromJSONTableColumnjSONTable), required: true);
            WorkflowValue.Validate(getStringArrayFromJSONTableColumncolumnIndex, nameof(getStringArrayFromJSONTableColumncolumnIndex), required: false);
            WorkflowValue.Validate(getStringArrayFromJSONTableColumncolumnName, nameof(getStringArrayFromJSONTableColumncolumnName), required: false);
            return new DeferredBodyAction<GetStringArrayFromJSONTableColumnResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetStringArrayFromJSONTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getStringArrayFromJSONTableColumn = new JObject();
                var getStringArrayFromJSONTableColumnpropCount = 0;
                getStringArrayFromJSONTableColumnpropCount++;
                getStringArrayFromJSONTableColumn["JSONTable"] = ExpressionConverter.ConvertO(getStringArrayFromJSONTableColumnjSONTable);
                if (getStringArrayFromJSONTableColumncolumnIndex != null)
                {
                    getStringArrayFromJSONTableColumn["ColumnIndex"] = ExpressionConverter.ConvertO(getStringArrayFromJSONTableColumncolumnIndex);
                    getStringArrayFromJSONTableColumnpropCount++;
                }

                if (getStringArrayFromJSONTableColumncolumnName != null)
                {
                    getStringArrayFromJSONTableColumn["ColumnName"] = ExpressionConverter.ConvertO(getStringArrayFromJSONTableColumncolumnName);
                    getStringArrayFromJSONTableColumnpropCount++;
                }

                if (getStringArrayFromJSONTableColumnpropCount > 0)
                {
                    callPayload.Body = getStringArrayFromJSONTableColumn;
                }

                return new ApiConnectionAction<GetStringArrayFromJSONTableColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetStringFromJSONTableCell))]
        public IBodyWorkflowAction<GetStringFromJSONTableCellResponse> GetStringFromJSONTableCell([WorkflowExpression] Func<string> getStringFromJSONTableCelljSONTable, [WorkflowExpression] Func<int> getStringFromJSONTableCellrowIndex = null, [WorkflowExpression] Func<int> getStringFromJSONTableCellcolumnIndex = null, [WorkflowExpression] Func<string> getStringFromJSONTableCellcolumnName = null, [WorkflowExpression] Func<bool> getStringFromJSONTableCellfallBackIfCellDoesNotExist = null, [WorkflowExpression] Func<string> getStringFromJSONTableCellfallbackValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStringFromJSONTableCellResponse> __BuildGetStringFromJSONTableCell(WorkflowValue<string> getStringFromJSONTableCelljSONTable, WorkflowValue<int> getStringFromJSONTableCellrowIndex = null, WorkflowValue<int> getStringFromJSONTableCellcolumnIndex = null, WorkflowValue<string> getStringFromJSONTableCellcolumnName = null, WorkflowValue<bool> getStringFromJSONTableCellfallBackIfCellDoesNotExist = null, WorkflowValue<string> getStringFromJSONTableCellfallbackValue = null)
        {
            WorkflowValue.Validate(getStringFromJSONTableCelljSONTable, nameof(getStringFromJSONTableCelljSONTable), required: true);
            WorkflowValue.Validate(getStringFromJSONTableCellrowIndex, nameof(getStringFromJSONTableCellrowIndex), required: false);
            WorkflowValue.Validate(getStringFromJSONTableCellcolumnIndex, nameof(getStringFromJSONTableCellcolumnIndex), required: false);
            WorkflowValue.Validate(getStringFromJSONTableCellcolumnName, nameof(getStringFromJSONTableCellcolumnName), required: false);
            WorkflowValue.Validate(getStringFromJSONTableCellfallBackIfCellDoesNotExist, nameof(getStringFromJSONTableCellfallBackIfCellDoesNotExist), required: false);
            WorkflowValue.Validate(getStringFromJSONTableCellfallbackValue, nameof(getStringFromJSONTableCellfallbackValue), required: false);
            return new DeferredBodyAction<GetStringFromJSONTableCellResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetStringFromJSONTableCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getStringFromJSONTableCell = new JObject();
                var getStringFromJSONTableCellpropCount = 0;
                getStringFromJSONTableCellpropCount++;
                getStringFromJSONTableCell["JSONTable"] = ExpressionConverter.ConvertO(getStringFromJSONTableCelljSONTable);
                if (getStringFromJSONTableCellrowIndex != null)
                {
                    getStringFromJSONTableCell["RowIndex"] = ExpressionConverter.ConvertO(getStringFromJSONTableCellrowIndex);
                    getStringFromJSONTableCellpropCount++;
                }

                if (getStringFromJSONTableCellcolumnIndex != null)
                {
                    getStringFromJSONTableCell["ColumnIndex"] = ExpressionConverter.ConvertO(getStringFromJSONTableCellcolumnIndex);
                    getStringFromJSONTableCellpropCount++;
                }

                if (getStringFromJSONTableCellcolumnName != null)
                {
                    getStringFromJSONTableCell["ColumnName"] = ExpressionConverter.ConvertO(getStringFromJSONTableCellcolumnName);
                    getStringFromJSONTableCellpropCount++;
                }

                if (getStringFromJSONTableCellfallBackIfCellDoesNotExist != null)
                {
                    if (getStringFromJSONTableCellfallBackIfCellDoesNotExist != null)
                    {
                        getStringFromJSONTableCell["FallBackIfCellDoesNotExist"] = ExpressionConverter.ConvertO(getStringFromJSONTableCellfallBackIfCellDoesNotExist);
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
                    getStringFromJSONTableCell["FallbackValue"] = ExpressionConverter.ConvertO(getStringFromJSONTableCellfallbackValue);
                    getStringFromJSONTableCellpropCount++;
                }

                if (getStringFromJSONTableCellpropCount > 0)
                {
                    callPayload.Body = getStringFromJSONTableCell;
                }

                return new ApiConnectionAction<GetStringFromJSONTableCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetStringBetween))]
        public IBodyWorkflowAction<GetStringBetweenResponse> GetStringBetween([WorkflowExpression] Func<string> getStringBetweeninputString = null, [WorkflowExpression] Func<string> getStringBetweenstartSearchString = null, [WorkflowExpression] Func<string> getStringBetweenendSearchString = null, [WorkflowExpression] Func<bool> getStringBetweensearchLineByLine = null, [WorkflowExpression] Func<bool> getStringBetweenthrowExceptionIfNotFound = null, [WorkflowExpression] Func<bool> getStringBetweentrimResult = null, [WorkflowExpression] Func<bool> getStringBetweensearchIsRegularExpression = null, [WorkflowExpression] Func<bool> getStringBetweencaseSensitiveSearch = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStringBetweenResponse> __BuildGetStringBetween(WorkflowValue<string> getStringBetweeninputString = null, WorkflowValue<string> getStringBetweenstartSearchString = null, WorkflowValue<string> getStringBetweenendSearchString = null, WorkflowValue<bool> getStringBetweensearchLineByLine = null, WorkflowValue<bool> getStringBetweenthrowExceptionIfNotFound = null, WorkflowValue<bool> getStringBetweentrimResult = null, WorkflowValue<bool> getStringBetweensearchIsRegularExpression = null, WorkflowValue<bool> getStringBetweencaseSensitiveSearch = null)
        {
            WorkflowValue.Validate(getStringBetweeninputString, nameof(getStringBetweeninputString), required: false);
            WorkflowValue.Validate(getStringBetweenstartSearchString, nameof(getStringBetweenstartSearchString), required: false);
            WorkflowValue.Validate(getStringBetweenendSearchString, nameof(getStringBetweenendSearchString), required: false);
            WorkflowValue.Validate(getStringBetweensearchLineByLine, nameof(getStringBetweensearchLineByLine), required: false);
            WorkflowValue.Validate(getStringBetweenthrowExceptionIfNotFound, nameof(getStringBetweenthrowExceptionIfNotFound), required: false);
            WorkflowValue.Validate(getStringBetweentrimResult, nameof(getStringBetweentrimResult), required: false);
            WorkflowValue.Validate(getStringBetweensearchIsRegularExpression, nameof(getStringBetweensearchIsRegularExpression), required: false);
            WorkflowValue.Validate(getStringBetweencaseSensitiveSearch, nameof(getStringBetweencaseSensitiveSearch), required: false);
            return new DeferredBodyAction<GetStringBetweenResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetStringBetween";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getStringBetween = new JObject();
                var getStringBetweenpropCount = 0;
                if (getStringBetweeninputString != null)
                {
                    getStringBetween["InputString"] = ExpressionConverter.ConvertO(getStringBetweeninputString);
                    getStringBetweenpropCount++;
                }

                if (getStringBetweenstartSearchString != null)
                {
                    getStringBetween["StartSearchString"] = ExpressionConverter.ConvertO(getStringBetweenstartSearchString);
                    getStringBetweenpropCount++;
                }

                if (getStringBetweenendSearchString != null)
                {
                    getStringBetween["EndSearchString"] = ExpressionConverter.ConvertO(getStringBetweenendSearchString);
                    getStringBetweenpropCount++;
                }

                if (getStringBetweensearchLineByLine != null)
                {
                    if (getStringBetweensearchLineByLine != null)
                    {
                        getStringBetween["SearchLineByLine"] = ExpressionConverter.ConvertO(getStringBetweensearchLineByLine);
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
                        getStringBetween["ThrowExceptionIfNotFound"] = ExpressionConverter.ConvertO(getStringBetweenthrowExceptionIfNotFound);
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
                        getStringBetween["TrimResult"] = ExpressionConverter.ConvertO(getStringBetweentrimResult);
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
                        getStringBetween["SearchIsRegularExpression"] = ExpressionConverter.ConvertO(getStringBetweensearchIsRegularExpression);
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
                        getStringBetween["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(getStringBetweencaseSensitiveSearch);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildLoadIAConnectLookupTable))]
        public IBodyWorkflowAction<LoadIAConnectLookupTableResponse> LoadIAConnectLookupTable([WorkflowExpression] Func<string> loadIAConnectLookupTablepath, [WorkflowExpression] Func<bool> loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad, [WorkflowExpression] Func<string> loadIAConnectLookupTableworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LoadIAConnectLookupTableResponse> __BuildLoadIAConnectLookupTable(WorkflowValue<string> loadIAConnectLookupTablepath, WorkflowValue<bool> loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad, WorkflowValue<string> loadIAConnectLookupTableworkflow)
        {
            WorkflowValue.Validate(loadIAConnectLookupTablepath, nameof(loadIAConnectLookupTablepath), required: true);
            WorkflowValue.Validate(loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad, nameof(loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad), required: true);
            WorkflowValue.Validate(loadIAConnectLookupTableworkflow, nameof(loadIAConnectLookupTableworkflow), required: true);
            return new DeferredBodyAction<LoadIAConnectLookupTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/LoadIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var loadIAConnectLookupTable = new JObject();
                var loadIAConnectLookupTablepropCount = 0;
                loadIAConnectLookupTablepropCount++;
                loadIAConnectLookupTable["Path"] = ExpressionConverter.ConvertO(loadIAConnectLookupTablepath);
                loadIAConnectLookupTablepropCount++;
                loadIAConnectLookupTable["RaiseExceptionIfAnyTableFailsToLoad"] = ExpressionConverter.ConvertO(loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad);
                loadIAConnectLookupTablepropCount++;
                loadIAConnectLookupTable["Workflow"] = ExpressionConverter.ConvertO(loadIAConnectLookupTableworkflow);
                if (loadIAConnectLookupTablepropCount > 0)
                {
                    callPayload.Body = loadIAConnectLookupTable;
                }

                return new ApiConnectionAction<LoadIAConnectLookupTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetIAConnectLookupTableSummary))]
        public IBodyWorkflowAction<GetIAConnectLookupTableSummaryResponse> GetIAConnectLookupTableSummary([WorkflowExpression] Func<string> getIAConnectLookupTableSummaryworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIAConnectLookupTableSummaryResponse> __BuildGetIAConnectLookupTableSummary(WorkflowValue<string> getIAConnectLookupTableSummaryworkflow)
        {
            WorkflowValue.Validate(getIAConnectLookupTableSummaryworkflow, nameof(getIAConnectLookupTableSummaryworkflow), required: true);
            return new DeferredBodyAction<GetIAConnectLookupTableSummaryResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetIAConnectLookupTableSummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectLookupTableSummary = new JObject();
                var getIAConnectLookupTableSummarypropCount = 0;
                getIAConnectLookupTableSummarypropCount++;
                getIAConnectLookupTableSummary["Workflow"] = ExpressionConverter.ConvertO(getIAConnectLookupTableSummaryworkflow);
                if (getIAConnectLookupTableSummarypropCount > 0)
                {
                    callPayload.Body = getIAConnectLookupTableSummary;
                }

                return new ApiConnectionAction<GetIAConnectLookupTableSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveIAConnectLookupTable))]
        public IBodyWorkflowAction<RemoveIAConnectLookupTableResponse> RemoveIAConnectLookupTable([WorkflowExpression] Func<string> removeIAConnectLookupTablelookupTableName, [WorkflowExpression] Func<string> removeIAConnectLookupTableworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemoveIAConnectLookupTableResponse> __BuildRemoveIAConnectLookupTable(WorkflowValue<string> removeIAConnectLookupTablelookupTableName, WorkflowValue<string> removeIAConnectLookupTableworkflow)
        {
            WorkflowValue.Validate(removeIAConnectLookupTablelookupTableName, nameof(removeIAConnectLookupTablelookupTableName), required: true);
            WorkflowValue.Validate(removeIAConnectLookupTableworkflow, nameof(removeIAConnectLookupTableworkflow), required: true);
            return new DeferredBodyAction<RemoveIAConnectLookupTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/RemoveIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var removeIAConnectLookupTable = new JObject();
                var removeIAConnectLookupTablepropCount = 0;
                removeIAConnectLookupTablepropCount++;
                removeIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(removeIAConnectLookupTablelookupTableName);
                removeIAConnectLookupTablepropCount++;
                removeIAConnectLookupTable["Workflow"] = ExpressionConverter.ConvertO(removeIAConnectLookupTableworkflow);
                if (removeIAConnectLookupTablepropCount > 0)
                {
                    callPayload.Body = removeIAConnectLookupTable;
                }

                return new ApiConnectionAction<RemoveIAConnectLookupTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveAllIAConnectLookupTables))]
        public IBodyWorkflowAction<RemoveAllIAConnectLookupTablesResponse> RemoveAllIAConnectLookupTables([WorkflowExpression] Func<string> removeAllIAConnectLookupTablesworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemoveAllIAConnectLookupTablesResponse> __BuildRemoveAllIAConnectLookupTables(WorkflowValue<string> removeAllIAConnectLookupTablesworkflow)
        {
            WorkflowValue.Validate(removeAllIAConnectLookupTablesworkflow, nameof(removeAllIAConnectLookupTablesworkflow), required: true);
            return new DeferredBodyAction<RemoveAllIAConnectLookupTablesResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/RemoveAllIAConnectLookupTables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var removeAllIAConnectLookupTables = new JObject();
                var removeAllIAConnectLookupTablespropCount = 0;
                removeAllIAConnectLookupTablespropCount++;
                removeAllIAConnectLookupTables["Workflow"] = ExpressionConverter.ConvertO(removeAllIAConnectLookupTablesworkflow);
                if (removeAllIAConnectLookupTablespropCount > 0)
                {
                    callPayload.Body = removeAllIAConnectLookupTables;
                }

                return new ApiConnectionAction<RemoveAllIAConnectLookupTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildLookupValueFromIAConnectLookupTable))]
        public IBodyWorkflowAction<LookupValueFromIAConnectLookupTableResponse> LookupValueFromIAConnectLookupTable([WorkflowExpression] Func<string> lookupValueFromIAConnectLookupTablelookupTableName, [WorkflowExpression] Func<string> lookupValueFromIAConnectLookupTablesearchResultValueColumnName, [WorkflowExpression] Func<string> lookupValueFromIAConnectLookupTableworkflow, [WorkflowExpression] Func<string> lookupValueFromIAConnectLookupTableinputDataJSON = null, [WorkflowExpression] Func<int> lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex = null, [WorkflowExpression] Func<bool> lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LookupValueFromIAConnectLookupTableResponse> __BuildLookupValueFromIAConnectLookupTable(WorkflowValue<string> lookupValueFromIAConnectLookupTablelookupTableName, WorkflowValue<string> lookupValueFromIAConnectLookupTablesearchResultValueColumnName, WorkflowValue<string> lookupValueFromIAConnectLookupTableworkflow, WorkflowValue<string> lookupValueFromIAConnectLookupTableinputDataJSON = null, WorkflowValue<int> lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex = null, WorkflowValue<bool> lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch = null)
        {
            WorkflowValue.Validate(lookupValueFromIAConnectLookupTablelookupTableName, nameof(lookupValueFromIAConnectLookupTablelookupTableName), required: true);
            WorkflowValue.Validate(lookupValueFromIAConnectLookupTablesearchResultValueColumnName, nameof(lookupValueFromIAConnectLookupTablesearchResultValueColumnName), required: true);
            WorkflowValue.Validate(lookupValueFromIAConnectLookupTableworkflow, nameof(lookupValueFromIAConnectLookupTableworkflow), required: true);
            WorkflowValue.Validate(lookupValueFromIAConnectLookupTableinputDataJSON, nameof(lookupValueFromIAConnectLookupTableinputDataJSON), required: false);
            WorkflowValue.Validate(lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex, nameof(lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex), required: false);
            WorkflowValue.Validate(lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch, nameof(lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch), required: false);
            return new DeferredBodyAction<LookupValueFromIAConnectLookupTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/LookupValueFromIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lookupValueFromIAConnectLookupTable = new JObject();
                var lookupValueFromIAConnectLookupTablepropCount = 0;
                lookupValueFromIAConnectLookupTablepropCount++;
                lookupValueFromIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(lookupValueFromIAConnectLookupTablelookupTableName);
                if (lookupValueFromIAConnectLookupTableinputDataJSON != null)
                {
                    lookupValueFromIAConnectLookupTable["InputDataJSON"] = ExpressionConverter.ConvertO(lookupValueFromIAConnectLookupTableinputDataJSON);
                    lookupValueFromIAConnectLookupTablepropCount++;
                }

                lookupValueFromIAConnectLookupTablepropCount++;
                lookupValueFromIAConnectLookupTable["SearchResultValueColumnName"] = ExpressionConverter.ConvertO(lookupValueFromIAConnectLookupTablesearchResultValueColumnName);
                if (lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex != null)
                {
                    if (lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex != null)
                    {
                        lookupValueFromIAConnectLookupTable["SearchResultValueColumnIndex"] = ExpressionConverter.ConvertO(lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex);
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
                        lookupValueFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = ExpressionConverter.ConvertO(lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch);
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
                lookupValueFromIAConnectLookupTable["Workflow"] = ExpressionConverter.ConvertO(lookupValueFromIAConnectLookupTableworkflow);
                if (lookupValueFromIAConnectLookupTablepropCount > 0)
                {
                    callPayload.Body = lookupValueFromIAConnectLookupTable;
                }

                return new ApiConnectionAction<LookupValueFromIAConnectLookupTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildLookupColumnsFromIAConnectLookupTable))]
        public IBodyWorkflowAction<LookupColumnsFromIAConnectLookupTableResponse> LookupColumnsFromIAConnectLookupTable([WorkflowExpression] Func<string> lookupColumnsFromIAConnectLookupTablelookupTableName, [WorkflowExpression] Func<string> lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName, [WorkflowExpression] Func<string> lookupColumnsFromIAConnectLookupTableworkflow, [WorkflowExpression] Func<string> lookupColumnsFromIAConnectLookupTableinputDataJSON = null, [WorkflowExpression] Func<bool> lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch = null, [WorkflowExpression] Func<bool> lookupColumnsFromIAConnectLookupTablereturnBlankCells = null, [WorkflowExpression] Func<lookupColumnsFromIAConnectLookupTablereturnFormatInput> lookupColumnsFromIAConnectLookupTablereturnFormat = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LookupColumnsFromIAConnectLookupTableResponse> __BuildLookupColumnsFromIAConnectLookupTable(WorkflowValue<string> lookupColumnsFromIAConnectLookupTablelookupTableName, WorkflowValue<string> lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName, WorkflowValue<string> lookupColumnsFromIAConnectLookupTableworkflow, WorkflowValue<string> lookupColumnsFromIAConnectLookupTableinputDataJSON = null, WorkflowValue<bool> lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch = null, WorkflowValue<bool> lookupColumnsFromIAConnectLookupTablereturnBlankCells = null, WorkflowValue<lookupColumnsFromIAConnectLookupTablereturnFormatInput> lookupColumnsFromIAConnectLookupTablereturnFormat = null)
        {
            WorkflowValue.Validate(lookupColumnsFromIAConnectLookupTablelookupTableName, nameof(lookupColumnsFromIAConnectLookupTablelookupTableName), required: true);
            WorkflowValue.Validate(lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName, nameof(lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName), required: true);
            WorkflowValue.Validate(lookupColumnsFromIAConnectLookupTableworkflow, nameof(lookupColumnsFromIAConnectLookupTableworkflow), required: true);
            WorkflowValue.Validate(lookupColumnsFromIAConnectLookupTableinputDataJSON, nameof(lookupColumnsFromIAConnectLookupTableinputDataJSON), required: false);
            WorkflowValue.Validate(lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch, nameof(lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch), required: false);
            WorkflowValue.Validate(lookupColumnsFromIAConnectLookupTablereturnBlankCells, nameof(lookupColumnsFromIAConnectLookupTablereturnBlankCells), required: false);
            WorkflowValue.Validate(lookupColumnsFromIAConnectLookupTablereturnFormat, nameof(lookupColumnsFromIAConnectLookupTablereturnFormat), required: false);
            return new DeferredBodyAction<LookupColumnsFromIAConnectLookupTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/LookupColumnsFromIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lookupColumnsFromIAConnectLookupTable = new JObject();
                var lookupColumnsFromIAConnectLookupTablepropCount = 0;
                lookupColumnsFromIAConnectLookupTablepropCount++;
                lookupColumnsFromIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(lookupColumnsFromIAConnectLookupTablelookupTableName);
                if (lookupColumnsFromIAConnectLookupTableinputDataJSON != null)
                {
                    lookupColumnsFromIAConnectLookupTable["InputDataJSON"] = ExpressionConverter.ConvertO(lookupColumnsFromIAConnectLookupTableinputDataJSON);
                    lookupColumnsFromIAConnectLookupTablepropCount++;
                }

                lookupColumnsFromIAConnectLookupTablepropCount++;
                lookupColumnsFromIAConnectLookupTable["SearchResultTableColumnName"] = ExpressionConverter.ConvertO(lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName);
                if (lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                {
                    if (lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                    {
                        lookupColumnsFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = ExpressionConverter.ConvertO(lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch);
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
                        lookupColumnsFromIAConnectLookupTable["ReturnBlankCells"] = ExpressionConverter.ConvertO(lookupColumnsFromIAConnectLookupTablereturnBlankCells);
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
                        lookupColumnsFromIAConnectLookupTable["ReturnFormat"] = ExpressionConverter.ConvertO(lookupColumnsFromIAConnectLookupTablereturnFormat);
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
                lookupColumnsFromIAConnectLookupTable["Workflow"] = ExpressionConverter.ConvertO(lookupColumnsFromIAConnectLookupTableworkflow);
                if (lookupColumnsFromIAConnectLookupTablepropCount > 0)
                {
                    callPayload.Body = lookupColumnsFromIAConnectLookupTable;
                }

                return new ApiConnectionAction<LookupColumnsFromIAConnectLookupTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveCharactersFromString))]
        public IBodyWorkflowAction<RemoveCharactersFromStringResponse> RemoveCharactersFromString([WorkflowExpression] Func<string> removeCharactersFromStringinputString = null, [WorkflowExpression] Func<string> removeCharactersFromStringcharactersToRemoveFromInputString = null, [WorkflowExpression] Func<bool> removeCharactersFromStringremoveDiacriticsFromInputString = null, [WorkflowExpression] Func<bool> removeCharactersFromStringremoveNonAlphaNumericFromInputString = null, [WorkflowExpression] Func<bool> removeCharactersFromStringremoveNumericFromInputString = null, [WorkflowExpression] Func<bool> removeCharactersFromStringremoveLowercaseCharactersFromInputString = null, [WorkflowExpression] Func<bool> removeCharactersFromStringremoveUppercaseCharactersFromInputString = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemoveCharactersFromStringResponse> __BuildRemoveCharactersFromString(WorkflowValue<string> removeCharactersFromStringinputString = null, WorkflowValue<string> removeCharactersFromStringcharactersToRemoveFromInputString = null, WorkflowValue<bool> removeCharactersFromStringremoveDiacriticsFromInputString = null, WorkflowValue<bool> removeCharactersFromStringremoveNonAlphaNumericFromInputString = null, WorkflowValue<bool> removeCharactersFromStringremoveNumericFromInputString = null, WorkflowValue<bool> removeCharactersFromStringremoveLowercaseCharactersFromInputString = null, WorkflowValue<bool> removeCharactersFromStringremoveUppercaseCharactersFromInputString = null)
        {
            WorkflowValue.Validate(removeCharactersFromStringinputString, nameof(removeCharactersFromStringinputString), required: false);
            WorkflowValue.Validate(removeCharactersFromStringcharactersToRemoveFromInputString, nameof(removeCharactersFromStringcharactersToRemoveFromInputString), required: false);
            WorkflowValue.Validate(removeCharactersFromStringremoveDiacriticsFromInputString, nameof(removeCharactersFromStringremoveDiacriticsFromInputString), required: false);
            WorkflowValue.Validate(removeCharactersFromStringremoveNonAlphaNumericFromInputString, nameof(removeCharactersFromStringremoveNonAlphaNumericFromInputString), required: false);
            WorkflowValue.Validate(removeCharactersFromStringremoveNumericFromInputString, nameof(removeCharactersFromStringremoveNumericFromInputString), required: false);
            WorkflowValue.Validate(removeCharactersFromStringremoveLowercaseCharactersFromInputString, nameof(removeCharactersFromStringremoveLowercaseCharactersFromInputString), required: false);
            WorkflowValue.Validate(removeCharactersFromStringremoveUppercaseCharactersFromInputString, nameof(removeCharactersFromStringremoveUppercaseCharactersFromInputString), required: false);
            return new DeferredBodyAction<RemoveCharactersFromStringResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/RemoveCharactersFromString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var removeCharactersFromString = new JObject();
                var removeCharactersFromStringpropCount = 0;
                if (removeCharactersFromStringinputString != null)
                {
                    removeCharactersFromString["InputString"] = ExpressionConverter.ConvertO(removeCharactersFromStringinputString);
                    removeCharactersFromStringpropCount++;
                }

                if (removeCharactersFromStringcharactersToRemoveFromInputString != null)
                {
                    removeCharactersFromString["CharactersToRemoveFromInputString"] = ExpressionConverter.ConvertO(removeCharactersFromStringcharactersToRemoveFromInputString);
                    removeCharactersFromStringpropCount++;
                }

                if (removeCharactersFromStringremoveDiacriticsFromInputString != null)
                {
                    if (removeCharactersFromStringremoveDiacriticsFromInputString != null)
                    {
                        removeCharactersFromString["RemoveDiacriticsFromInputString"] = ExpressionConverter.ConvertO(removeCharactersFromStringremoveDiacriticsFromInputString);
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
                        removeCharactersFromString["RemoveNonAlphaNumericFromInputString"] = ExpressionConverter.ConvertO(removeCharactersFromStringremoveNonAlphaNumericFromInputString);
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
                        removeCharactersFromString["RemoveNumericFromInputString"] = ExpressionConverter.ConvertO(removeCharactersFromStringremoveNumericFromInputString);
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
                        removeCharactersFromString["RemoveLowercaseCharactersFromInputString"] = ExpressionConverter.ConvertO(removeCharactersFromStringremoveLowercaseCharactersFromInputString);
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
                        removeCharactersFromString["RemoveUppercaseCharactersFromInputString"] = ExpressionConverter.ConvertO(removeCharactersFromStringremoveUppercaseCharactersFromInputString);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetColumnFromIAConnectList))]
        public IBodyWorkflowAction<GetColumnFromIAConnectListResponse> GetColumnFromIAConnectList([WorkflowExpression] Func<string> getColumnFromIAConnectListlistName, [WorkflowExpression] Func<int> getColumnFromIAConnectListsearchColumnIndex = null, [WorkflowExpression] Func<string> getColumnFromIAConnectListsearchColumnName = null, [WorkflowExpression] Func<bool> getColumnFromIAConnectListreturnBlankCells = null, [WorkflowExpression] Func<bool> getColumnFromIAConnectListfallBackIfListDoesNotExist = null, [WorkflowExpression] Func<string> getColumnFromIAConnectListfallbackValue = null, [WorkflowExpression] Func<getColumnFromIAConnectListreturnFormatInput> getColumnFromIAConnectListreturnFormat = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetColumnFromIAConnectListResponse> __BuildGetColumnFromIAConnectList(WorkflowValue<string> getColumnFromIAConnectListlistName, WorkflowValue<int> getColumnFromIAConnectListsearchColumnIndex = null, WorkflowValue<string> getColumnFromIAConnectListsearchColumnName = null, WorkflowValue<bool> getColumnFromIAConnectListreturnBlankCells = null, WorkflowValue<bool> getColumnFromIAConnectListfallBackIfListDoesNotExist = null, WorkflowValue<string> getColumnFromIAConnectListfallbackValue = null, WorkflowValue<getColumnFromIAConnectListreturnFormatInput> getColumnFromIAConnectListreturnFormat = null)
        {
            WorkflowValue.Validate(getColumnFromIAConnectListlistName, nameof(getColumnFromIAConnectListlistName), required: true);
            WorkflowValue.Validate(getColumnFromIAConnectListsearchColumnIndex, nameof(getColumnFromIAConnectListsearchColumnIndex), required: false);
            WorkflowValue.Validate(getColumnFromIAConnectListsearchColumnName, nameof(getColumnFromIAConnectListsearchColumnName), required: false);
            WorkflowValue.Validate(getColumnFromIAConnectListreturnBlankCells, nameof(getColumnFromIAConnectListreturnBlankCells), required: false);
            WorkflowValue.Validate(getColumnFromIAConnectListfallBackIfListDoesNotExist, nameof(getColumnFromIAConnectListfallBackIfListDoesNotExist), required: false);
            WorkflowValue.Validate(getColumnFromIAConnectListfallbackValue, nameof(getColumnFromIAConnectListfallbackValue), required: false);
            WorkflowValue.Validate(getColumnFromIAConnectListreturnFormat, nameof(getColumnFromIAConnectListreturnFormat), required: false);
            return new DeferredBodyAction<GetColumnFromIAConnectListResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetColumnFromIAConnectList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getColumnFromIAConnectList = new JObject();
                var getColumnFromIAConnectListpropCount = 0;
                getColumnFromIAConnectListpropCount++;
                getColumnFromIAConnectList["ListName"] = ExpressionConverter.ConvertO(getColumnFromIAConnectListlistName);
                if (getColumnFromIAConnectListsearchColumnIndex != null)
                {
                    if (getColumnFromIAConnectListsearchColumnIndex != null)
                    {
                        getColumnFromIAConnectList["SearchColumnIndex"] = ExpressionConverter.ConvertO(getColumnFromIAConnectListsearchColumnIndex);
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
                    getColumnFromIAConnectList["SearchColumnName"] = ExpressionConverter.ConvertO(getColumnFromIAConnectListsearchColumnName);
                    getColumnFromIAConnectListpropCount++;
                }

                if (getColumnFromIAConnectListreturnBlankCells != null)
                {
                    if (getColumnFromIAConnectListreturnBlankCells != null)
                    {
                        getColumnFromIAConnectList["ReturnBlankCells"] = ExpressionConverter.ConvertO(getColumnFromIAConnectListreturnBlankCells);
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
                        getColumnFromIAConnectList["FallBackIfListDoesNotExist"] = ExpressionConverter.ConvertO(getColumnFromIAConnectListfallBackIfListDoesNotExist);
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
                    getColumnFromIAConnectList["FallbackValue"] = ExpressionConverter.ConvertO(getColumnFromIAConnectListfallbackValue);
                    getColumnFromIAConnectListpropCount++;
                }

                if (getColumnFromIAConnectListreturnFormat != null)
                {
                    if (getColumnFromIAConnectListreturnFormat != null)
                    {
                        getColumnFromIAConnectList["ReturnFormat"] = ExpressionConverter.ConvertO(getColumnFromIAConnectListreturnFormat);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetIAConnectListContents))]
        public IBodyWorkflowAction<GetIAConnectListContentsResponse> GetIAConnectListContents([WorkflowExpression] Func<string> getIAConnectListContentslistName, [WorkflowExpression] Func<getIAConnectListContentsreturnFormatInput> getIAConnectListContentsreturnFormat = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIAConnectListContentsResponse> __BuildGetIAConnectListContents(WorkflowValue<string> getIAConnectListContentslistName, WorkflowValue<getIAConnectListContentsreturnFormatInput> getIAConnectListContentsreturnFormat = null)
        {
            WorkflowValue.Validate(getIAConnectListContentslistName, nameof(getIAConnectListContentslistName), required: true);
            WorkflowValue.Validate(getIAConnectListContentsreturnFormat, nameof(getIAConnectListContentsreturnFormat), required: false);
            return new DeferredBodyAction<GetIAConnectListContentsResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetIAConnectListContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectListContents = new JObject();
                var getIAConnectListContentspropCount = 0;
                getIAConnectListContentspropCount++;
                getIAConnectListContents["ListName"] = ExpressionConverter.ConvertO(getIAConnectListContentslistName);
                if (getIAConnectListContentsreturnFormat != null)
                {
                    if (getIAConnectListContentsreturnFormat != null)
                    {
                        getIAConnectListContents["ReturnFormat"] = ExpressionConverter.ConvertO(getIAConnectListContentsreturnFormat);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildLookupDataCellsFromIAConnectLookupTable))]
        public IBodyWorkflowAction<LookupDataCellsFromIAConnectLookupTableResponse> LookupDataCellsFromIAConnectLookupTable([WorkflowExpression] Func<string> lookupDataCellsFromIAConnectLookupTablelookupTableName, [WorkflowExpression] Func<string> lookupDataCellsFromIAConnectLookupTableinputDataJSON = null, [WorkflowExpression] Func<bool> lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch = null, [WorkflowExpression] Func<bool> lookupDataCellsFromIAConnectLookupTablereturnBlankCells = null, [WorkflowExpression] Func<lookupDataCellsFromIAConnectLookupTablereturnFormatInput> lookupDataCellsFromIAConnectLookupTablereturnFormat = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LookupDataCellsFromIAConnectLookupTableResponse> __BuildLookupDataCellsFromIAConnectLookupTable(WorkflowValue<string> lookupDataCellsFromIAConnectLookupTablelookupTableName, WorkflowValue<string> lookupDataCellsFromIAConnectLookupTableinputDataJSON = null, WorkflowValue<bool> lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch = null, WorkflowValue<bool> lookupDataCellsFromIAConnectLookupTablereturnBlankCells = null, WorkflowValue<lookupDataCellsFromIAConnectLookupTablereturnFormatInput> lookupDataCellsFromIAConnectLookupTablereturnFormat = null)
        {
            WorkflowValue.Validate(lookupDataCellsFromIAConnectLookupTablelookupTableName, nameof(lookupDataCellsFromIAConnectLookupTablelookupTableName), required: true);
            WorkflowValue.Validate(lookupDataCellsFromIAConnectLookupTableinputDataJSON, nameof(lookupDataCellsFromIAConnectLookupTableinputDataJSON), required: false);
            WorkflowValue.Validate(lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch, nameof(lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch), required: false);
            WorkflowValue.Validate(lookupDataCellsFromIAConnectLookupTablereturnBlankCells, nameof(lookupDataCellsFromIAConnectLookupTablereturnBlankCells), required: false);
            WorkflowValue.Validate(lookupDataCellsFromIAConnectLookupTablereturnFormat, nameof(lookupDataCellsFromIAConnectLookupTablereturnFormat), required: false);
            return new DeferredBodyAction<LookupDataCellsFromIAConnectLookupTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/LookupDataCellsFromIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lookupDataCellsFromIAConnectLookupTable = new JObject();
                var lookupDataCellsFromIAConnectLookupTablepropCount = 0;
                lookupDataCellsFromIAConnectLookupTablepropCount++;
                lookupDataCellsFromIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(lookupDataCellsFromIAConnectLookupTablelookupTableName);
                if (lookupDataCellsFromIAConnectLookupTableinputDataJSON != null)
                {
                    lookupDataCellsFromIAConnectLookupTable["InputDataJSON"] = ExpressionConverter.ConvertO(lookupDataCellsFromIAConnectLookupTableinputDataJSON);
                    lookupDataCellsFromIAConnectLookupTablepropCount++;
                }

                if (lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                {
                    if (lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                    {
                        lookupDataCellsFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = ExpressionConverter.ConvertO(lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch);
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
                        lookupDataCellsFromIAConnectLookupTable["ReturnBlankCells"] = ExpressionConverter.ConvertO(lookupDataCellsFromIAConnectLookupTablereturnBlankCells);
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
                        lookupDataCellsFromIAConnectLookupTable["ReturnFormat"] = ExpressionConverter.ConvertO(lookupDataCellsFromIAConnectLookupTablereturnFormat);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildGetIAConnectLookupTableContents))]
        public IBodyWorkflowAction<GetIAConnectLookupTableContentsResponse> GetIAConnectLookupTableContents([WorkflowExpression] Func<string> getIAConnectLookupTableContentslookupTableName, [WorkflowExpression] Func<getIAConnectLookupTableContentsreturnFormatInput> getIAConnectLookupTableContentsreturnFormat = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIAConnectLookupTableContentsResponse> __BuildGetIAConnectLookupTableContents(WorkflowValue<string> getIAConnectLookupTableContentslookupTableName, WorkflowValue<getIAConnectLookupTableContentsreturnFormatInput> getIAConnectLookupTableContentsreturnFormat = null)
        {
            WorkflowValue.Validate(getIAConnectLookupTableContentslookupTableName, nameof(getIAConnectLookupTableContentslookupTableName), required: true);
            WorkflowValue.Validate(getIAConnectLookupTableContentsreturnFormat, nameof(getIAConnectLookupTableContentsreturnFormat), required: false);
            return new DeferredBodyAction<GetIAConnectLookupTableContentsResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetIAConnectLookupTableContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectLookupTableContents = new JObject();
                var getIAConnectLookupTableContentspropCount = 0;
                getIAConnectLookupTableContentspropCount++;
                getIAConnectLookupTableContents["LookupTableName"] = ExpressionConverter.ConvertO(getIAConnectLookupTableContentslookupTableName);
                if (getIAConnectLookupTableContentsreturnFormat != null)
                {
                    if (getIAConnectLookupTableContentsreturnFormat != null)
                    {
                        getIAConnectLookupTableContents["ReturnFormat"] = ExpressionConverter.ConvertO(getIAConnectLookupTableContentsreturnFormat);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildUploadCSVToIAConnectLookupTable))]
        public IBodyWorkflowAction<UploadCSVToIAConnectLookupTableResponse> UploadCSVToIAConnectLookupTable([WorkflowExpression] Func<string> uploadCSVToIAConnectLookupTablelookupTableName, [WorkflowExpression] Func<string> uploadCSVToIAConnectLookupTablecSVData, [WorkflowExpression] Func<bool> uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadCSVToIAConnectLookupTableResponse> __BuildUploadCSVToIAConnectLookupTable(WorkflowValue<string> uploadCSVToIAConnectLookupTablelookupTableName, WorkflowValue<string> uploadCSVToIAConnectLookupTablecSVData, WorkflowValue<bool> uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist = null)
        {
            WorkflowValue.Validate(uploadCSVToIAConnectLookupTablelookupTableName, nameof(uploadCSVToIAConnectLookupTablelookupTableName), required: true);
            WorkflowValue.Validate(uploadCSVToIAConnectLookupTablecSVData, nameof(uploadCSVToIAConnectLookupTablecSVData), required: true);
            WorkflowValue.Validate(uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist, nameof(uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist), required: false);
            return new DeferredBodyAction<UploadCSVToIAConnectLookupTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/UploadCSVToIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uploadCSVToIAConnectLookupTable = new JObject();
                var uploadCSVToIAConnectLookupTablepropCount = 0;
                uploadCSVToIAConnectLookupTablepropCount++;
                uploadCSVToIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(uploadCSVToIAConnectLookupTablelookupTableName);
                uploadCSVToIAConnectLookupTablepropCount++;
                uploadCSVToIAConnectLookupTable["CSVData"] = ExpressionConverter.ConvertO(uploadCSVToIAConnectLookupTablecSVData);
                if (uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist != null)
                {
                    if (uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist != null)
                    {
                        uploadCSVToIAConnectLookupTable["CreateLookupTableIfNotExist"] = ExpressionConverter.ConvertO(uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildUploadCSVToIAConnectList))]
        public IBodyWorkflowAction<UploadCSVToIAConnectListResponse> UploadCSVToIAConnectList([WorkflowExpression] Func<string> uploadCSVToIAConnectListlistName, [WorkflowExpression] Func<string> uploadCSVToIAConnectListcSVData, [WorkflowExpression] Func<bool> uploadCSVToIAConnectListcreateListIfNotExist = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadCSVToIAConnectListResponse> __BuildUploadCSVToIAConnectList(WorkflowValue<string> uploadCSVToIAConnectListlistName, WorkflowValue<string> uploadCSVToIAConnectListcSVData, WorkflowValue<bool> uploadCSVToIAConnectListcreateListIfNotExist = null)
        {
            WorkflowValue.Validate(uploadCSVToIAConnectListlistName, nameof(uploadCSVToIAConnectListlistName), required: true);
            WorkflowValue.Validate(uploadCSVToIAConnectListcSVData, nameof(uploadCSVToIAConnectListcSVData), required: true);
            WorkflowValue.Validate(uploadCSVToIAConnectListcreateListIfNotExist, nameof(uploadCSVToIAConnectListcreateListIfNotExist), required: false);
            return new DeferredBodyAction<UploadCSVToIAConnectListResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/UploadCSVToIAConnectList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uploadCSVToIAConnectList = new JObject();
                var uploadCSVToIAConnectListpropCount = 0;
                uploadCSVToIAConnectListpropCount++;
                uploadCSVToIAConnectList["ListName"] = ExpressionConverter.ConvertO(uploadCSVToIAConnectListlistName);
                uploadCSVToIAConnectListpropCount++;
                uploadCSVToIAConnectList["CSVData"] = ExpressionConverter.ConvertO(uploadCSVToIAConnectListcSVData);
                if (uploadCSVToIAConnectListcreateListIfNotExist != null)
                {
                    if (uploadCSVToIAConnectListcreateListIfNotExist != null)
                    {
                        uploadCSVToIAConnectList["CreateListIfNotExist"] = ExpressionConverter.ConvertO(uploadCSVToIAConnectListcreateListIfNotExist);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        [WorkflowExpressionFactory(nameof(__BuildConvertArrayToJSON))]
        public IBodyWorkflowAction<ConvertArrayToJSONResponse> ConvertArrayToJSON([WorkflowExpression] Func<JToken[]> convertArrayToJSONinputObject)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConvertArrayToJSONResponse> __BuildConvertArrayToJSON(WorkflowValue<JToken[]> convertArrayToJSONinputObject)
        {
            WorkflowValue.Validate(convertArrayToJSONinputObject, nameof(convertArrayToJSONinputObject), required: true);
            return new DeferredBodyAction<ConvertArrayToJSONResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/ConvertArrayToJSON";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var convertArrayToJSON = new JObject();
                var convertArrayToJSONpropCount = 0;
                convertArrayToJSONpropCount++;
                convertArrayToJSON["InputObject"] = ExpressionConverter.ConvertO(convertArrayToJSONinputObject);
                if (convertArrayToJSONpropCount > 0)
                {
                    callPayload.Body = convertArrayToJSON;
                }

                return new ApiConnectionAction<ConvertArrayToJSONResponse>(callPayload);
            });
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
