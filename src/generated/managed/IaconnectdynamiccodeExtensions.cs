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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildImportAssemblyFromLocalFile(WorkflowExpression<string> importAssemblyFromLocalFilelocalAssemblyFilePath, WorkflowExpression<string> importAssemblyFromLocalFileassemblyName, WorkflowExpression<string> importAssemblyFromLocalFileworkflow, WorkflowExpression<bool> importAssemblyFromLocalFilecompress = null)
        {
            WorkflowExpression.Validate(importAssemblyFromLocalFilelocalAssemblyFilePath, nameof(importAssemblyFromLocalFilelocalAssemblyFilePath), required: true);
            WorkflowExpression.Validate(importAssemblyFromLocalFileassemblyName, nameof(importAssemblyFromLocalFileassemblyName), required: true);
            WorkflowExpression.Validate(importAssemblyFromLocalFileworkflow, nameof(importAssemblyFromLocalFileworkflow), required: true);
            WorkflowExpression.Validate(importAssemblyFromLocalFilecompress, nameof(importAssemblyFromLocalFilecompress), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddAssemblySearchFolder(WorkflowExpression<string> addAssemblySearchFolderfolderPath, WorkflowExpression<string> addAssemblySearchFolderworkflow)
        {
            WorkflowExpression.Validate(addAssemblySearchFolderfolderPath, nameof(addAssemblySearchFolderfolderPath), required: true);
            WorkflowExpression.Validate(addAssemblySearchFolderworkflow, nameof(addAssemblySearchFolderworkflow), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildClearAssemblySearchFolders(WorkflowExpression<string> clearAssemblySearchFoldersworkflow)
        {
            WorkflowExpression.Validate(clearAssemblySearchFoldersworkflow, nameof(clearAssemblySearchFoldersworkflow), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsPowerShellAutomationInstalledResponse> __BuildIsPowerShellAutomationInstalled(WorkflowExpression<string> isPowerShellAutomationInstalledworkflow)
        {
            WorkflowExpression.Validate(isPowerShellAutomationInstalledworkflow, nameof(isPowerShellAutomationInstalledworkflow), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsPowerShellModuleInstalledResponse> __BuildIsPowerShellModuleInstalled(WorkflowExpression<string> isPowerShellModuleInstalledpowerShellModuleName, WorkflowExpression<string> isPowerShellModuleInstalledworkflow)
        {
            WorkflowExpression.Validate(isPowerShellModuleInstalledpowerShellModuleName, nameof(isPowerShellModuleInstalledpowerShellModuleName), required: true);
            WorkflowExpression.Validate(isPowerShellModuleInstalledworkflow, nameof(isPowerShellModuleInstalledworkflow), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunPowerShellAutomationScriptResponse> __BuildRunPowerShellAutomationScript(WorkflowExpression<string> runPowerShellAutomationScriptworkflow, WorkflowExpression<string> runPowerShellAutomationScriptpowerShellScriptContents = null, WorkflowExpression<string> runPowerShellAutomationScriptcomputerName = null, WorkflowExpression<bool> runPowerShellAutomationScriptisNoResultAnError = null, WorkflowExpression<bool> runPowerShellAutomationScriptreturnComplexTypes = null, WorkflowExpression<bool> runPowerShellAutomationScriptreturnBooleanAsBoolean = null, WorkflowExpression<bool> runPowerShellAutomationScriptreturnNumericAsDecimal = null, WorkflowExpression<bool> runPowerShellAutomationScriptreturnDateAsDate = null, WorkflowExpression<string> runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, WorkflowExpression<runPowerShellAutomationScriptauthenticationMechanismInput> runPowerShellAutomationScriptauthenticationMechanism = null, WorkflowExpression<int> runPowerShellAutomationScriptconnectionAttempts = null, WorkflowExpression<string> runPowerShellAutomationScriptusername = null, WorkflowExpression<string> runPowerShellAutomationScriptpassword = null, WorkflowExpression<bool> runPowerShellAutomationScriptrunScriptAsThread = null, WorkflowExpression<int> runPowerShellAutomationScriptretrieveOutputDataFromThreadId = null, WorkflowExpression<int> runPowerShellAutomationScriptsecondsToWaitForThread = null, WorkflowExpression<bool> runPowerShellAutomationScriptscriptContainsStoredPassword = null, WorkflowExpression<bool> runPowerShellAutomationScriptlogVerboseOutput = null, WorkflowExpression<bool> runPowerShellAutomationScriptreturnSecureStrings = null, WorkflowExpression<string> runPowerShellAutomationScriptpropertyNamesToSerializeJSON = null, WorkflowExpression<string> runPowerShellAutomationScriptpropertyTypesToSerializeJSON = null, WorkflowExpression<runPowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runPowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            WorkflowExpression.Validate(runPowerShellAutomationScriptworkflow, nameof(runPowerShellAutomationScriptworkflow), required: true);
            WorkflowExpression.Validate(runPowerShellAutomationScriptpowerShellScriptContents, nameof(runPowerShellAutomationScriptpowerShellScriptContents), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptcomputerName, nameof(runPowerShellAutomationScriptcomputerName), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptisNoResultAnError, nameof(runPowerShellAutomationScriptisNoResultAnError), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptreturnComplexTypes, nameof(runPowerShellAutomationScriptreturnComplexTypes), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptreturnBooleanAsBoolean, nameof(runPowerShellAutomationScriptreturnBooleanAsBoolean), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptreturnNumericAsDecimal, nameof(runPowerShellAutomationScriptreturnNumericAsDecimal), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptreturnDateAsDate, nameof(runPowerShellAutomationScriptreturnDateAsDate), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON, nameof(runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptauthenticationMechanism, nameof(runPowerShellAutomationScriptauthenticationMechanism), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptconnectionAttempts, nameof(runPowerShellAutomationScriptconnectionAttempts), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptusername, nameof(runPowerShellAutomationScriptusername), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptpassword, nameof(runPowerShellAutomationScriptpassword), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptrunScriptAsThread, nameof(runPowerShellAutomationScriptrunScriptAsThread), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptretrieveOutputDataFromThreadId, nameof(runPowerShellAutomationScriptretrieveOutputDataFromThreadId), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptsecondsToWaitForThread, nameof(runPowerShellAutomationScriptsecondsToWaitForThread), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptscriptContainsStoredPassword, nameof(runPowerShellAutomationScriptscriptContainsStoredPassword), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptlogVerboseOutput, nameof(runPowerShellAutomationScriptlogVerboseOutput), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptreturnSecureStrings, nameof(runPowerShellAutomationScriptreturnSecureStrings), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptpropertyNamesToSerializeJSON, nameof(runPowerShellAutomationScriptpropertyNamesToSerializeJSON), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptpropertyTypesToSerializeJSON, nameof(runPowerShellAutomationScriptpropertyTypesToSerializeJSON), required: false);
            WorkflowExpression.Validate(runPowerShellAutomationScriptpowerShellCommandParameters, nameof(runPowerShellAutomationScriptpowerShellCommandParameters), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPowerShellVersionResponse> __BuildGetPowerShellVersion(WorkflowExpression<string> getPowerShellVersionworkflow, WorkflowExpression<string> getPowerShellVersioncomputerName = null, WorkflowExpression<getPowerShellVersionauthenticationMechanismInput> getPowerShellVersionauthenticationMechanism = null, WorkflowExpression<int> getPowerShellVersionconnectionAttempts = null)
        {
            WorkflowExpression.Validate(getPowerShellVersionworkflow, nameof(getPowerShellVersionworkflow), required: true);
            WorkflowExpression.Validate(getPowerShellVersioncomputerName, nameof(getPowerShellVersioncomputerName), required: false);
            WorkflowExpression.Validate(getPowerShellVersionauthenticationMechanism, nameof(getPowerShellVersionauthenticationMechanism), required: false);
            WorkflowExpression.Validate(getPowerShellVersionconnectionAttempts, nameof(getPowerShellVersionconnectionAttempts), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRegexMatchResponse> __BuildGetRegexMatch(WorkflowExpression<string> getRegexMatchtextToMatch, WorkflowExpression<string> getRegexMatchregex, WorkflowExpression<int> getRegexMatchsearchIndex = null, WorkflowExpression<bool> getRegexMatchcaseSensitive = null, WorkflowExpression<int> getRegexMatchregexTimeoutInSeconds = null)
        {
            WorkflowExpression.Validate(getRegexMatchtextToMatch, nameof(getRegexMatchtextToMatch), required: true);
            WorkflowExpression.Validate(getRegexMatchregex, nameof(getRegexMatchregex), required: true);
            WorkflowExpression.Validate(getRegexMatchsearchIndex, nameof(getRegexMatchsearchIndex), required: false);
            WorkflowExpression.Validate(getRegexMatchcaseSensitive, nameof(getRegexMatchcaseSensitive), required: false);
            WorkflowExpression.Validate(getRegexMatchregexTimeoutInSeconds, nameof(getRegexMatchregexTimeoutInSeconds), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRegexMatchesResponse> __BuildGetRegexMatches(WorkflowExpression<string> getRegexMatchestextToMatch, WorkflowExpression<string> getRegexMatchesregex, WorkflowExpression<int> getRegexMatchesmaximumMatches = null, WorkflowExpression<bool> getRegexMatchescaseSensitive = null, WorkflowExpression<bool> getRegexMatchestrimResults = null, WorkflowExpression<bool> getRegexMatchesremoveEmptyResults = null, WorkflowExpression<int> getRegexMatchesregexTimeoutInSeconds = null)
        {
            WorkflowExpression.Validate(getRegexMatchestextToMatch, nameof(getRegexMatchestextToMatch), required: true);
            WorkflowExpression.Validate(getRegexMatchesregex, nameof(getRegexMatchesregex), required: true);
            WorkflowExpression.Validate(getRegexMatchesmaximumMatches, nameof(getRegexMatchesmaximumMatches), required: false);
            WorkflowExpression.Validate(getRegexMatchescaseSensitive, nameof(getRegexMatchescaseSensitive), required: false);
            WorkflowExpression.Validate(getRegexMatchestrimResults, nameof(getRegexMatchestrimResults), required: false);
            WorkflowExpression.Validate(getRegexMatchesremoveEmptyResults, nameof(getRegexMatchesremoveEmptyResults), required: false);
            WorkflowExpression.Validate(getRegexMatchesregexTimeoutInSeconds, nameof(getRegexMatchesregexTimeoutInSeconds), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRegexSplitResponse> __BuildGetRegexSplit(WorkflowExpression<string> getRegexSplittextToSplit, WorkflowExpression<string> getRegexSplitregex, WorkflowExpression<bool> getRegexSplitcaseSensitive = null, WorkflowExpression<bool> getRegexSplittrimResults = null, WorkflowExpression<bool> getRegexSplitremoveEmptyResults = null, WorkflowExpression<int> getRegexSplitregexTimeoutInSeconds = null)
        {
            WorkflowExpression.Validate(getRegexSplittextToSplit, nameof(getRegexSplittextToSplit), required: true);
            WorkflowExpression.Validate(getRegexSplitregex, nameof(getRegexSplitregex), required: true);
            WorkflowExpression.Validate(getRegexSplitcaseSensitive, nameof(getRegexSplitcaseSensitive), required: false);
            WorkflowExpression.Validate(getRegexSplittrimResults, nameof(getRegexSplittrimResults), required: false);
            WorkflowExpression.Validate(getRegexSplitremoveEmptyResults, nameof(getRegexSplitremoveEmptyResults), required: false);
            WorkflowExpression.Validate(getRegexSplitregexTimeoutInSeconds, nameof(getRegexSplitregexTimeoutInSeconds), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRegexGroupMatchesResponse> __BuildGetRegexGroupMatches(WorkflowExpression<string> getRegexGroupMatchestextToMatch, WorkflowExpression<string> getRegexGroupMatchesregex, WorkflowExpression<string[]> getRegexGroupMatchesgroupsToRetrieve = null, WorkflowExpression<int> getRegexGroupMatchessearchIndex = null, WorkflowExpression<bool> getRegexGroupMatchescaseSensitive = null, WorkflowExpression<int> getRegexGroupMatchesregexTimeoutInSeconds = null)
        {
            WorkflowExpression.Validate(getRegexGroupMatchestextToMatch, nameof(getRegexGroupMatchestextToMatch), required: true);
            WorkflowExpression.Validate(getRegexGroupMatchesregex, nameof(getRegexGroupMatchesregex), required: true);
            WorkflowExpression.Validate(getRegexGroupMatchesgroupsToRetrieve, nameof(getRegexGroupMatchesgroupsToRetrieve), required: false);
            WorkflowExpression.Validate(getRegexGroupMatchessearchIndex, nameof(getRegexGroupMatchessearchIndex), required: false);
            WorkflowExpression.Validate(getRegexGroupMatchescaseSensitive, nameof(getRegexGroupMatchescaseSensitive), required: false);
            WorkflowExpression.Validate(getRegexGroupMatchesregexTimeoutInSeconds, nameof(getRegexGroupMatchesregexTimeoutInSeconds), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateJSONFromInputVariablesResponse> __BuildCreateJSONFromInputVariables(WorkflowExpression<createJSONFromInputVariablesinputVariablesInputItem[]> createJSONFromInputVariablesinputVariables, WorkflowExpression<bool> createJSONFromInputVariablesreturnAsJSONTable)
        {
            WorkflowExpression.Validate(createJSONFromInputVariablesinputVariables, nameof(createJSONFromInputVariablesinputVariables), required: true);
            WorkflowExpression.Validate(createJSONFromInputVariablesreturnAsJSONTable, nameof(createJSONFromInputVariablesreturnAsJSONTable), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetJSONTableFromStringArrayResponse> __BuildGetJSONTableFromStringArray(WorkflowExpression<string[]> getJSONTableFromStringArrayinputArray, WorkflowExpression<string> getJSONTableFromStringArraycolumnName, WorkflowExpression<bool> getJSONTableFromStringArraydropEmptyItems = null)
        {
            WorkflowExpression.Validate(getJSONTableFromStringArrayinputArray, nameof(getJSONTableFromStringArrayinputArray), required: true);
            WorkflowExpression.Validate(getJSONTableFromStringArraycolumnName, nameof(getJSONTableFromStringArraycolumnName), required: true);
            WorkflowExpression.Validate(getJSONTableFromStringArraydropEmptyItems, nameof(getJSONTableFromStringArraydropEmptyItems), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FilterJSONTableResponse> __BuildFilterJSONTable(WorkflowExpression<string> filterJSONTablejSONTable, WorkflowExpression<string> filterJSONTablefilter, WorkflowExpression<string> filterJSONTablesortColumnName = null, WorkflowExpression<bool> filterJSONTableascending = null, WorkflowExpression<string> filterJSONTablesortColumnName2 = null, WorkflowExpression<bool> filterJSONTableascending2 = null, WorkflowExpression<string> filterJSONTablesortColumnName3 = null, WorkflowExpression<bool> filterJSONTableascending3 = null)
        {
            WorkflowExpression.Validate(filterJSONTablejSONTable, nameof(filterJSONTablejSONTable), required: true);
            WorkflowExpression.Validate(filterJSONTablefilter, nameof(filterJSONTablefilter), required: true);
            WorkflowExpression.Validate(filterJSONTablesortColumnName, nameof(filterJSONTablesortColumnName), required: false);
            WorkflowExpression.Validate(filterJSONTableascending, nameof(filterJSONTableascending), required: false);
            WorkflowExpression.Validate(filterJSONTablesortColumnName2, nameof(filterJSONTablesortColumnName2), required: false);
            WorkflowExpression.Validate(filterJSONTableascending2, nameof(filterJSONTableascending2), required: false);
            WorkflowExpression.Validate(filterJSONTablesortColumnName3, nameof(filterJSONTablesortColumnName3), required: false);
            WorkflowExpression.Validate(filterJSONTableascending3, nameof(filterJSONTableascending3), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FilterTableResponse> __BuildFilterTable(WorkflowExpression<JToken[]> filterTableinputTable, WorkflowExpression<string> filterTablefilter, WorkflowExpression<string> filterTablesortColumnName = null, WorkflowExpression<bool> filterTableascending = null, WorkflowExpression<string> filterTablesortColumnName2 = null, WorkflowExpression<bool> filterTableascending2 = null, WorkflowExpression<string> filterTablesortColumnName3 = null, WorkflowExpression<bool> filterTableascending3 = null)
        {
            WorkflowExpression.Validate(filterTableinputTable, nameof(filterTableinputTable), required: true);
            WorkflowExpression.Validate(filterTablefilter, nameof(filterTablefilter), required: true);
            WorkflowExpression.Validate(filterTablesortColumnName, nameof(filterTablesortColumnName), required: false);
            WorkflowExpression.Validate(filterTableascending, nameof(filterTableascending), required: false);
            WorkflowExpression.Validate(filterTablesortColumnName2, nameof(filterTablesortColumnName2), required: false);
            WorkflowExpression.Validate(filterTableascending2, nameof(filterTableascending2), required: false);
            WorkflowExpression.Validate(filterTablesortColumnName3, nameof(filterTablesortColumnName3), required: false);
            WorkflowExpression.Validate(filterTableascending3, nameof(filterTableascending3), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SortTableResponse> __BuildSortTable(WorkflowExpression<JToken[]> sortTableinputTable, WorkflowExpression<string> sortTablesortColumnName, WorkflowExpression<bool> sortTableascending, WorkflowExpression<string> sortTablesortColumnName2 = null, WorkflowExpression<bool> sortTableascending2 = null, WorkflowExpression<string> sortTablesortColumnName3 = null, WorkflowExpression<bool> sortTableascending3 = null)
        {
            WorkflowExpression.Validate(sortTableinputTable, nameof(sortTableinputTable), required: true);
            WorkflowExpression.Validate(sortTablesortColumnName, nameof(sortTablesortColumnName), required: true);
            WorkflowExpression.Validate(sortTableascending, nameof(sortTableascending), required: true);
            WorkflowExpression.Validate(sortTablesortColumnName2, nameof(sortTablesortColumnName2), required: false);
            WorkflowExpression.Validate(sortTableascending2, nameof(sortTableascending2), required: false);
            WorkflowExpression.Validate(sortTablesortColumnName3, nameof(sortTablesortColumnName3), required: false);
            WorkflowExpression.Validate(sortTableascending3, nameof(sortTableascending3), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SortJSONTableResponse> __BuildSortJSONTable(WorkflowExpression<string> sortJSONTablejSONTable, WorkflowExpression<string> sortJSONTablesortColumnName, WorkflowExpression<bool> sortJSONTableascending = null, WorkflowExpression<string> sortJSONTablesortColumnName2 = null, WorkflowExpression<bool> sortJSONTableascending2 = null, WorkflowExpression<string> sortJSONTablesortColumnName3 = null, WorkflowExpression<bool> sortJSONTableascending3 = null)
        {
            WorkflowExpression.Validate(sortJSONTablejSONTable, nameof(sortJSONTablejSONTable), required: true);
            WorkflowExpression.Validate(sortJSONTablesortColumnName, nameof(sortJSONTablesortColumnName), required: true);
            WorkflowExpression.Validate(sortJSONTableascending, nameof(sortJSONTableascending), required: false);
            WorkflowExpression.Validate(sortJSONTablesortColumnName2, nameof(sortJSONTablesortColumnName2), required: false);
            WorkflowExpression.Validate(sortJSONTableascending2, nameof(sortJSONTableascending2), required: false);
            WorkflowExpression.Validate(sortJSONTablesortColumnName3, nameof(sortJSONTablesortColumnName3), required: false);
            WorkflowExpression.Validate(sortJSONTableascending3, nameof(sortJSONTableascending3), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTableFromStringArrayResponse> __BuildGetTableFromStringArray(WorkflowExpression<string[]> getTableFromStringArrayinputArray, WorkflowExpression<string> getTableFromStringArraycolumnName, WorkflowExpression<bool> getTableFromStringArraydropEmptyItems = null)
        {
            WorkflowExpression.Validate(getTableFromStringArrayinputArray, nameof(getTableFromStringArrayinputArray), required: true);
            WorkflowExpression.Validate(getTableFromStringArraycolumnName, nameof(getTableFromStringArraycolumnName), required: true);
            WorkflowExpression.Validate(getTableFromStringArraydropEmptyItems, nameof(getTableFromStringArraydropEmptyItems), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTableFromJSONResponse> __BuildGetTableFromJSON(WorkflowExpression<string> getTableFromJSONjSONTable, WorkflowExpression<int> getTableFromJSONstartRowIndex, WorkflowExpression<int> getTableFromJSONnumberOfRowsToRetrieve = null, WorkflowExpression<int> getTableFromJSONstartColumnIndex = null, WorkflowExpression<string> getTableFromJSONstartColumnName = null, WorkflowExpression<int> getTableFromJSONnumberOfColumnsToRetrieve = null)
        {
            WorkflowExpression.Validate(getTableFromJSONjSONTable, nameof(getTableFromJSONjSONTable), required: true);
            WorkflowExpression.Validate(getTableFromJSONstartRowIndex, nameof(getTableFromJSONstartRowIndex), required: true);
            WorkflowExpression.Validate(getTableFromJSONnumberOfRowsToRetrieve, nameof(getTableFromJSONnumberOfRowsToRetrieve), required: false);
            WorkflowExpression.Validate(getTableFromJSONstartColumnIndex, nameof(getTableFromJSONstartColumnIndex), required: false);
            WorkflowExpression.Validate(getTableFromJSONstartColumnName, nameof(getTableFromJSONstartColumnName), required: false);
            WorkflowExpression.Validate(getTableFromJSONnumberOfColumnsToRetrieve, nameof(getTableFromJSONnumberOfColumnsToRetrieve), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SortStringArrayResponse> __BuildSortStringArray(WorkflowExpression<string[]> sortStringArrayinputArray, WorkflowExpression<bool> sortStringArrayascending = null, WorkflowExpression<bool> sortStringArraycaseSensitive = null)
        {
            WorkflowExpression.Validate(sortStringArrayinputArray, nameof(sortStringArrayinputArray), required: true);
            WorkflowExpression.Validate(sortStringArrayascending, nameof(sortStringArrayascending), required: false);
            WorkflowExpression.Validate(sortStringArraycaseSensitive, nameof(sortStringArraycaseSensitive), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FilterStringArrayResponse> __BuildFilterStringArray(WorkflowExpression<string[]> filterStringArrayinputArray, WorkflowExpression<string> filterStringArraycolumnName, WorkflowExpression<string> filterStringArrayfilter)
        {
            WorkflowExpression.Validate(filterStringArrayinputArray, nameof(filterStringArrayinputArray), required: true);
            WorkflowExpression.Validate(filterStringArraycolumnName, nameof(filterStringArraycolumnName), required: true);
            WorkflowExpression.Validate(filterStringArrayfilter, nameof(filterStringArrayfilter), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InsertRowInStringArrayResponse> __BuildInsertRowInStringArray(WorkflowExpression<string[]> insertRowInStringArrayinputArray, WorkflowExpression<int> insertRowInStringArrayrowIndex, WorkflowExpression<string> insertRowInStringArrayvalueToInsert = null)
        {
            WorkflowExpression.Validate(insertRowInStringArrayinputArray, nameof(insertRowInStringArrayinputArray), required: true);
            WorkflowExpression.Validate(insertRowInStringArrayrowIndex, nameof(insertRowInStringArrayrowIndex), required: true);
            WorkflowExpression.Validate(insertRowInStringArrayvalueToInsert, nameof(insertRowInStringArrayvalueToInsert), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InsertRowInTableResponse> __BuildInsertRowInTable(WorkflowExpression<JToken[]> insertRowInTableinputTable, WorkflowExpression<int> insertRowInTablerowIndex, WorkflowExpression<string> insertRowInTablerowToInsertJSON = null)
        {
            WorkflowExpression.Validate(insertRowInTableinputTable, nameof(insertRowInTableinputTable), required: true);
            WorkflowExpression.Validate(insertRowInTablerowIndex, nameof(insertRowInTablerowIndex), required: true);
            WorkflowExpression.Validate(insertRowInTablerowToInsertJSON, nameof(insertRowInTablerowToInsertJSON), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InsertRowInJSONTableResponse> __BuildInsertRowInJSONTable(WorkflowExpression<string> insertRowInJSONTablejSONTable, WorkflowExpression<int> insertRowInJSONTablerowIndex, WorkflowExpression<string> insertRowInJSONTablerowToInsertJSON = null)
        {
            WorkflowExpression.Validate(insertRowInJSONTablejSONTable, nameof(insertRowInJSONTablejSONTable), required: true);
            WorkflowExpression.Validate(insertRowInJSONTablerowIndex, nameof(insertRowInJSONTablerowIndex), required: true);
            WorkflowExpression.Validate(insertRowInJSONTablerowToInsertJSON, nameof(insertRowInJSONTablerowToInsertJSON), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InsertRowInJSONTableFromInputVariablesResponse> __BuildInsertRowInJSONTableFromInputVariables(WorkflowExpression<string> insertRowInJSONTableFromInputVariablesjSONTable, WorkflowExpression<int> insertRowInJSONTableFromInputVariablesrowIndex, WorkflowExpression<insertRowInJSONTableFromInputVariablesrowToInsertInputVariablesInputItem[]> insertRowInJSONTableFromInputVariablesrowToInsertInputVariables)
        {
            WorkflowExpression.Validate(insertRowInJSONTableFromInputVariablesjSONTable, nameof(insertRowInJSONTableFromInputVariablesjSONTable), required: true);
            WorkflowExpression.Validate(insertRowInJSONTableFromInputVariablesrowIndex, nameof(insertRowInJSONTableFromInputVariablesrowIndex), required: true);
            WorkflowExpression.Validate(insertRowInJSONTableFromInputVariablesrowToInsertInputVariables, nameof(insertRowInJSONTableFromInputVariablesrowToInsertInputVariables), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteItemsInStringArrayResponse> __BuildDeleteItemsInStringArray(WorkflowExpression<string[]> deleteItemsInStringArrayinputArray, WorkflowExpression<int> deleteItemsInStringArraystartItemIndex, WorkflowExpression<int> deleteItemsInStringArraynumberOfItemsToDelete)
        {
            WorkflowExpression.Validate(deleteItemsInStringArrayinputArray, nameof(deleteItemsInStringArrayinputArray), required: true);
            WorkflowExpression.Validate(deleteItemsInStringArraystartItemIndex, nameof(deleteItemsInStringArraystartItemIndex), required: true);
            WorkflowExpression.Validate(deleteItemsInStringArraynumberOfItemsToDelete, nameof(deleteItemsInStringArraynumberOfItemsToDelete), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteRowsInTableResponse> __BuildDeleteRowsInTable(WorkflowExpression<JToken[]> deleteRowsInTableinputTable, WorkflowExpression<int> deleteRowsInTablestartRowIndex, WorkflowExpression<int> deleteRowsInTablenumberOfRowsToDelete)
        {
            WorkflowExpression.Validate(deleteRowsInTableinputTable, nameof(deleteRowsInTableinputTable), required: true);
            WorkflowExpression.Validate(deleteRowsInTablestartRowIndex, nameof(deleteRowsInTablestartRowIndex), required: true);
            WorkflowExpression.Validate(deleteRowsInTablenumberOfRowsToDelete, nameof(deleteRowsInTablenumberOfRowsToDelete), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteRowsInJSONTableResponse> __BuildDeleteRowsInJSONTable(WorkflowExpression<string> deleteRowsInJSONTablejSONTable, WorkflowExpression<int> deleteRowsInJSONTablestartRowIndex, WorkflowExpression<int> deleteRowsInJSONTablenumberOfRowsToDelete)
        {
            WorkflowExpression.Validate(deleteRowsInJSONTablejSONTable, nameof(deleteRowsInJSONTablejSONTable), required: true);
            WorkflowExpression.Validate(deleteRowsInJSONTablestartRowIndex, nameof(deleteRowsInJSONTablestartRowIndex), required: true);
            WorkflowExpression.Validate(deleteRowsInJSONTablenumberOfRowsToDelete, nameof(deleteRowsInJSONTablenumberOfRowsToDelete), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RenameColumnInTableResponse> __BuildRenameColumnInTable(WorkflowExpression<JToken[]> renameColumnInTableinputTable, WorkflowExpression<string> renameColumnInTablesourceColumnName, WorkflowExpression<string> renameColumnInTablenewColumnName)
        {
            WorkflowExpression.Validate(renameColumnInTableinputTable, nameof(renameColumnInTableinputTable), required: true);
            WorkflowExpression.Validate(renameColumnInTablesourceColumnName, nameof(renameColumnInTablesourceColumnName), required: true);
            WorkflowExpression.Validate(renameColumnInTablenewColumnName, nameof(renameColumnInTablenewColumnName), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RenameColumnInJSONTableResponse> __BuildRenameColumnInJSONTable(WorkflowExpression<string> renameColumnInJSONTablejSONTable, WorkflowExpression<string> renameColumnInJSONTablesourceColumnName, WorkflowExpression<string> renameColumnInJSONTablenewColumnName)
        {
            WorkflowExpression.Validate(renameColumnInJSONTablejSONTable, nameof(renameColumnInJSONTablejSONTable), required: true);
            WorkflowExpression.Validate(renameColumnInJSONTablesourceColumnName, nameof(renameColumnInJSONTablesourceColumnName), required: true);
            WorkflowExpression.Validate(renameColumnInJSONTablenewColumnName, nameof(renameColumnInJSONTablenewColumnName), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteColumnsInTableResponse> __BuildDeleteColumnsInTable(WorkflowExpression<JToken[]> deleteColumnsInTableinputTable, WorkflowExpression<int> deleteColumnsInTablenumberOfColumnsToDelete, WorkflowExpression<int> deleteColumnsInTablestartColumnIndex = null, WorkflowExpression<string> deleteColumnsInTablecolumnNameToDelete = null)
        {
            WorkflowExpression.Validate(deleteColumnsInTableinputTable, nameof(deleteColumnsInTableinputTable), required: true);
            WorkflowExpression.Validate(deleteColumnsInTablenumberOfColumnsToDelete, nameof(deleteColumnsInTablenumberOfColumnsToDelete), required: true);
            WorkflowExpression.Validate(deleteColumnsInTablestartColumnIndex, nameof(deleteColumnsInTablestartColumnIndex), required: false);
            WorkflowExpression.Validate(deleteColumnsInTablecolumnNameToDelete, nameof(deleteColumnsInTablecolumnNameToDelete), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteColumnsInJSONTableResponse> __BuildDeleteColumnsInJSONTable(WorkflowExpression<string> deleteColumnsInJSONTablejSONTable, WorkflowExpression<int> deleteColumnsInJSONTablenumberOfColumnsToDelete, WorkflowExpression<int> deleteColumnsInJSONTablestartColumnIndex = null, WorkflowExpression<string> deleteColumnsInJSONTablecolumnNameToDelete = null)
        {
            WorkflowExpression.Validate(deleteColumnsInJSONTablejSONTable, nameof(deleteColumnsInJSONTablejSONTable), required: true);
            WorkflowExpression.Validate(deleteColumnsInJSONTablenumberOfColumnsToDelete, nameof(deleteColumnsInJSONTablenumberOfColumnsToDelete), required: true);
            WorkflowExpression.Validate(deleteColumnsInJSONTablestartColumnIndex, nameof(deleteColumnsInJSONTablestartColumnIndex), required: false);
            WorkflowExpression.Validate(deleteColumnsInJSONTablecolumnNameToDelete, nameof(deleteColumnsInJSONTablecolumnNameToDelete), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStringArrayFromTableColumnResponse> __BuildGetStringArrayFromTableColumn(WorkflowExpression<JToken[]> getStringArrayFromTableColumninputTable, WorkflowExpression<int> getStringArrayFromTableColumncolumnIndex = null, WorkflowExpression<string> getStringArrayFromTableColumncolumnName = null)
        {
            WorkflowExpression.Validate(getStringArrayFromTableColumninputTable, nameof(getStringArrayFromTableColumninputTable), required: true);
            WorkflowExpression.Validate(getStringArrayFromTableColumncolumnIndex, nameof(getStringArrayFromTableColumncolumnIndex), required: false);
            WorkflowExpression.Validate(getStringArrayFromTableColumncolumnName, nameof(getStringArrayFromTableColumncolumnName), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStringArrayFromJSONTableColumnResponse> __BuildGetStringArrayFromJSONTableColumn(WorkflowExpression<string> getStringArrayFromJSONTableColumnjSONTable, WorkflowExpression<int> getStringArrayFromJSONTableColumncolumnIndex = null, WorkflowExpression<string> getStringArrayFromJSONTableColumncolumnName = null)
        {
            WorkflowExpression.Validate(getStringArrayFromJSONTableColumnjSONTable, nameof(getStringArrayFromJSONTableColumnjSONTable), required: true);
            WorkflowExpression.Validate(getStringArrayFromJSONTableColumncolumnIndex, nameof(getStringArrayFromJSONTableColumncolumnIndex), required: false);
            WorkflowExpression.Validate(getStringArrayFromJSONTableColumncolumnName, nameof(getStringArrayFromJSONTableColumncolumnName), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStringFromJSONTableCellResponse> __BuildGetStringFromJSONTableCell(WorkflowExpression<string> getStringFromJSONTableCelljSONTable, WorkflowExpression<int> getStringFromJSONTableCellrowIndex = null, WorkflowExpression<int> getStringFromJSONTableCellcolumnIndex = null, WorkflowExpression<string> getStringFromJSONTableCellcolumnName = null, WorkflowExpression<bool> getStringFromJSONTableCellfallBackIfCellDoesNotExist = null, WorkflowExpression<string> getStringFromJSONTableCellfallbackValue = null)
        {
            WorkflowExpression.Validate(getStringFromJSONTableCelljSONTable, nameof(getStringFromJSONTableCelljSONTable), required: true);
            WorkflowExpression.Validate(getStringFromJSONTableCellrowIndex, nameof(getStringFromJSONTableCellrowIndex), required: false);
            WorkflowExpression.Validate(getStringFromJSONTableCellcolumnIndex, nameof(getStringFromJSONTableCellcolumnIndex), required: false);
            WorkflowExpression.Validate(getStringFromJSONTableCellcolumnName, nameof(getStringFromJSONTableCellcolumnName), required: false);
            WorkflowExpression.Validate(getStringFromJSONTableCellfallBackIfCellDoesNotExist, nameof(getStringFromJSONTableCellfallBackIfCellDoesNotExist), required: false);
            WorkflowExpression.Validate(getStringFromJSONTableCellfallbackValue, nameof(getStringFromJSONTableCellfallbackValue), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStringBetweenResponse> __BuildGetStringBetween(WorkflowExpression<string> getStringBetweeninputString = null, WorkflowExpression<string> getStringBetweenstartSearchString = null, WorkflowExpression<string> getStringBetweenendSearchString = null, WorkflowExpression<bool> getStringBetweensearchLineByLine = null, WorkflowExpression<bool> getStringBetweenthrowExceptionIfNotFound = null, WorkflowExpression<bool> getStringBetweentrimResult = null, WorkflowExpression<bool> getStringBetweensearchIsRegularExpression = null, WorkflowExpression<bool> getStringBetweencaseSensitiveSearch = null)
        {
            WorkflowExpression.Validate(getStringBetweeninputString, nameof(getStringBetweeninputString), required: false);
            WorkflowExpression.Validate(getStringBetweenstartSearchString, nameof(getStringBetweenstartSearchString), required: false);
            WorkflowExpression.Validate(getStringBetweenendSearchString, nameof(getStringBetweenendSearchString), required: false);
            WorkflowExpression.Validate(getStringBetweensearchLineByLine, nameof(getStringBetweensearchLineByLine), required: false);
            WorkflowExpression.Validate(getStringBetweenthrowExceptionIfNotFound, nameof(getStringBetweenthrowExceptionIfNotFound), required: false);
            WorkflowExpression.Validate(getStringBetweentrimResult, nameof(getStringBetweentrimResult), required: false);
            WorkflowExpression.Validate(getStringBetweensearchIsRegularExpression, nameof(getStringBetweensearchIsRegularExpression), required: false);
            WorkflowExpression.Validate(getStringBetweencaseSensitiveSearch, nameof(getStringBetweencaseSensitiveSearch), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LoadIAConnectLookupTableResponse> __BuildLoadIAConnectLookupTable(WorkflowExpression<string> loadIAConnectLookupTablepath, WorkflowExpression<bool> loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad, WorkflowExpression<string> loadIAConnectLookupTableworkflow)
        {
            WorkflowExpression.Validate(loadIAConnectLookupTablepath, nameof(loadIAConnectLookupTablepath), required: true);
            WorkflowExpression.Validate(loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad, nameof(loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad), required: true);
            WorkflowExpression.Validate(loadIAConnectLookupTableworkflow, nameof(loadIAConnectLookupTableworkflow), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIAConnectLookupTableSummaryResponse> __BuildGetIAConnectLookupTableSummary(WorkflowExpression<string> getIAConnectLookupTableSummaryworkflow)
        {
            WorkflowExpression.Validate(getIAConnectLookupTableSummaryworkflow, nameof(getIAConnectLookupTableSummaryworkflow), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemoveIAConnectLookupTableResponse> __BuildRemoveIAConnectLookupTable(WorkflowExpression<string> removeIAConnectLookupTablelookupTableName, WorkflowExpression<string> removeIAConnectLookupTableworkflow)
        {
            WorkflowExpression.Validate(removeIAConnectLookupTablelookupTableName, nameof(removeIAConnectLookupTablelookupTableName), required: true);
            WorkflowExpression.Validate(removeIAConnectLookupTableworkflow, nameof(removeIAConnectLookupTableworkflow), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemoveAllIAConnectLookupTablesResponse> __BuildRemoveAllIAConnectLookupTables(WorkflowExpression<string> removeAllIAConnectLookupTablesworkflow)
        {
            WorkflowExpression.Validate(removeAllIAConnectLookupTablesworkflow, nameof(removeAllIAConnectLookupTablesworkflow), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LookupValueFromIAConnectLookupTableResponse> __BuildLookupValueFromIAConnectLookupTable(WorkflowExpression<string> lookupValueFromIAConnectLookupTablelookupTableName, WorkflowExpression<string> lookupValueFromIAConnectLookupTablesearchResultValueColumnName, WorkflowExpression<string> lookupValueFromIAConnectLookupTableworkflow, WorkflowExpression<string> lookupValueFromIAConnectLookupTableinputDataJSON = null, WorkflowExpression<int> lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex = null, WorkflowExpression<bool> lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch = null)
        {
            WorkflowExpression.Validate(lookupValueFromIAConnectLookupTablelookupTableName, nameof(lookupValueFromIAConnectLookupTablelookupTableName), required: true);
            WorkflowExpression.Validate(lookupValueFromIAConnectLookupTablesearchResultValueColumnName, nameof(lookupValueFromIAConnectLookupTablesearchResultValueColumnName), required: true);
            WorkflowExpression.Validate(lookupValueFromIAConnectLookupTableworkflow, nameof(lookupValueFromIAConnectLookupTableworkflow), required: true);
            WorkflowExpression.Validate(lookupValueFromIAConnectLookupTableinputDataJSON, nameof(lookupValueFromIAConnectLookupTableinputDataJSON), required: false);
            WorkflowExpression.Validate(lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex, nameof(lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex), required: false);
            WorkflowExpression.Validate(lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch, nameof(lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LookupColumnsFromIAConnectLookupTableResponse> __BuildLookupColumnsFromIAConnectLookupTable(WorkflowExpression<string> lookupColumnsFromIAConnectLookupTablelookupTableName, WorkflowExpression<string> lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName, WorkflowExpression<string> lookupColumnsFromIAConnectLookupTableworkflow, WorkflowExpression<string> lookupColumnsFromIAConnectLookupTableinputDataJSON = null, WorkflowExpression<bool> lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch = null, WorkflowExpression<bool> lookupColumnsFromIAConnectLookupTablereturnBlankCells = null, WorkflowExpression<lookupColumnsFromIAConnectLookupTablereturnFormatInput> lookupColumnsFromIAConnectLookupTablereturnFormat = null)
        {
            WorkflowExpression.Validate(lookupColumnsFromIAConnectLookupTablelookupTableName, nameof(lookupColumnsFromIAConnectLookupTablelookupTableName), required: true);
            WorkflowExpression.Validate(lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName, nameof(lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName), required: true);
            WorkflowExpression.Validate(lookupColumnsFromIAConnectLookupTableworkflow, nameof(lookupColumnsFromIAConnectLookupTableworkflow), required: true);
            WorkflowExpression.Validate(lookupColumnsFromIAConnectLookupTableinputDataJSON, nameof(lookupColumnsFromIAConnectLookupTableinputDataJSON), required: false);
            WorkflowExpression.Validate(lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch, nameof(lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch), required: false);
            WorkflowExpression.Validate(lookupColumnsFromIAConnectLookupTablereturnBlankCells, nameof(lookupColumnsFromIAConnectLookupTablereturnBlankCells), required: false);
            WorkflowExpression.Validate(lookupColumnsFromIAConnectLookupTablereturnFormat, nameof(lookupColumnsFromIAConnectLookupTablereturnFormat), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemoveCharactersFromStringResponse> __BuildRemoveCharactersFromString(WorkflowExpression<string> removeCharactersFromStringinputString = null, WorkflowExpression<string> removeCharactersFromStringcharactersToRemoveFromInputString = null, WorkflowExpression<bool> removeCharactersFromStringremoveDiacriticsFromInputString = null, WorkflowExpression<bool> removeCharactersFromStringremoveNonAlphaNumericFromInputString = null, WorkflowExpression<bool> removeCharactersFromStringremoveNumericFromInputString = null, WorkflowExpression<bool> removeCharactersFromStringremoveLowercaseCharactersFromInputString = null, WorkflowExpression<bool> removeCharactersFromStringremoveUppercaseCharactersFromInputString = null)
        {
            WorkflowExpression.Validate(removeCharactersFromStringinputString, nameof(removeCharactersFromStringinputString), required: false);
            WorkflowExpression.Validate(removeCharactersFromStringcharactersToRemoveFromInputString, nameof(removeCharactersFromStringcharactersToRemoveFromInputString), required: false);
            WorkflowExpression.Validate(removeCharactersFromStringremoveDiacriticsFromInputString, nameof(removeCharactersFromStringremoveDiacriticsFromInputString), required: false);
            WorkflowExpression.Validate(removeCharactersFromStringremoveNonAlphaNumericFromInputString, nameof(removeCharactersFromStringremoveNonAlphaNumericFromInputString), required: false);
            WorkflowExpression.Validate(removeCharactersFromStringremoveNumericFromInputString, nameof(removeCharactersFromStringremoveNumericFromInputString), required: false);
            WorkflowExpression.Validate(removeCharactersFromStringremoveLowercaseCharactersFromInputString, nameof(removeCharactersFromStringremoveLowercaseCharactersFromInputString), required: false);
            WorkflowExpression.Validate(removeCharactersFromStringremoveUppercaseCharactersFromInputString, nameof(removeCharactersFromStringremoveUppercaseCharactersFromInputString), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetColumnFromIAConnectListResponse> __BuildGetColumnFromIAConnectList(WorkflowExpression<string> getColumnFromIAConnectListlistName, WorkflowExpression<int> getColumnFromIAConnectListsearchColumnIndex = null, WorkflowExpression<string> getColumnFromIAConnectListsearchColumnName = null, WorkflowExpression<bool> getColumnFromIAConnectListreturnBlankCells = null, WorkflowExpression<bool> getColumnFromIAConnectListfallBackIfListDoesNotExist = null, WorkflowExpression<string> getColumnFromIAConnectListfallbackValue = null, WorkflowExpression<getColumnFromIAConnectListreturnFormatInput> getColumnFromIAConnectListreturnFormat = null)
        {
            WorkflowExpression.Validate(getColumnFromIAConnectListlistName, nameof(getColumnFromIAConnectListlistName), required: true);
            WorkflowExpression.Validate(getColumnFromIAConnectListsearchColumnIndex, nameof(getColumnFromIAConnectListsearchColumnIndex), required: false);
            WorkflowExpression.Validate(getColumnFromIAConnectListsearchColumnName, nameof(getColumnFromIAConnectListsearchColumnName), required: false);
            WorkflowExpression.Validate(getColumnFromIAConnectListreturnBlankCells, nameof(getColumnFromIAConnectListreturnBlankCells), required: false);
            WorkflowExpression.Validate(getColumnFromIAConnectListfallBackIfListDoesNotExist, nameof(getColumnFromIAConnectListfallBackIfListDoesNotExist), required: false);
            WorkflowExpression.Validate(getColumnFromIAConnectListfallbackValue, nameof(getColumnFromIAConnectListfallbackValue), required: false);
            WorkflowExpression.Validate(getColumnFromIAConnectListreturnFormat, nameof(getColumnFromIAConnectListreturnFormat), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIAConnectListContentsResponse> __BuildGetIAConnectListContents(WorkflowExpression<string> getIAConnectListContentslistName, WorkflowExpression<getIAConnectListContentsreturnFormatInput> getIAConnectListContentsreturnFormat = null)
        {
            WorkflowExpression.Validate(getIAConnectListContentslistName, nameof(getIAConnectListContentslistName), required: true);
            WorkflowExpression.Validate(getIAConnectListContentsreturnFormat, nameof(getIAConnectListContentsreturnFormat), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LookupDataCellsFromIAConnectLookupTableResponse> __BuildLookupDataCellsFromIAConnectLookupTable(WorkflowExpression<string> lookupDataCellsFromIAConnectLookupTablelookupTableName, WorkflowExpression<string> lookupDataCellsFromIAConnectLookupTableinputDataJSON = null, WorkflowExpression<bool> lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch = null, WorkflowExpression<bool> lookupDataCellsFromIAConnectLookupTablereturnBlankCells = null, WorkflowExpression<lookupDataCellsFromIAConnectLookupTablereturnFormatInput> lookupDataCellsFromIAConnectLookupTablereturnFormat = null)
        {
            WorkflowExpression.Validate(lookupDataCellsFromIAConnectLookupTablelookupTableName, nameof(lookupDataCellsFromIAConnectLookupTablelookupTableName), required: true);
            WorkflowExpression.Validate(lookupDataCellsFromIAConnectLookupTableinputDataJSON, nameof(lookupDataCellsFromIAConnectLookupTableinputDataJSON), required: false);
            WorkflowExpression.Validate(lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch, nameof(lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch), required: false);
            WorkflowExpression.Validate(lookupDataCellsFromIAConnectLookupTablereturnBlankCells, nameof(lookupDataCellsFromIAConnectLookupTablereturnBlankCells), required: false);
            WorkflowExpression.Validate(lookupDataCellsFromIAConnectLookupTablereturnFormat, nameof(lookupDataCellsFromIAConnectLookupTablereturnFormat), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIAConnectLookupTableContentsResponse> __BuildGetIAConnectLookupTableContents(WorkflowExpression<string> getIAConnectLookupTableContentslookupTableName, WorkflowExpression<getIAConnectLookupTableContentsreturnFormatInput> getIAConnectLookupTableContentsreturnFormat = null)
        {
            WorkflowExpression.Validate(getIAConnectLookupTableContentslookupTableName, nameof(getIAConnectLookupTableContentslookupTableName), required: true);
            WorkflowExpression.Validate(getIAConnectLookupTableContentsreturnFormat, nameof(getIAConnectLookupTableContentsreturnFormat), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadCSVToIAConnectLookupTableResponse> __BuildUploadCSVToIAConnectLookupTable(WorkflowExpression<string> uploadCSVToIAConnectLookupTablelookupTableName, WorkflowExpression<string> uploadCSVToIAConnectLookupTablecSVData, WorkflowExpression<bool> uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist = null)
        {
            WorkflowExpression.Validate(uploadCSVToIAConnectLookupTablelookupTableName, nameof(uploadCSVToIAConnectLookupTablelookupTableName), required: true);
            WorkflowExpression.Validate(uploadCSVToIAConnectLookupTablecSVData, nameof(uploadCSVToIAConnectLookupTablecSVData), required: true);
            WorkflowExpression.Validate(uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist, nameof(uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadCSVToIAConnectListResponse> __BuildUploadCSVToIAConnectList(WorkflowExpression<string> uploadCSVToIAConnectListlistName, WorkflowExpression<string> uploadCSVToIAConnectListcSVData, WorkflowExpression<bool> uploadCSVToIAConnectListcreateListIfNotExist = null)
        {
            WorkflowExpression.Validate(uploadCSVToIAConnectListlistName, nameof(uploadCSVToIAConnectListlistName), required: true);
            WorkflowExpression.Validate(uploadCSVToIAConnectListcSVData, nameof(uploadCSVToIAConnectListcSVData), required: true);
            WorkflowExpression.Validate(uploadCSVToIAConnectListcreateListIfNotExist, nameof(uploadCSVToIAConnectListcreateListIfNotExist), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConvertArrayToJSONResponse> __BuildConvertArrayToJSON(WorkflowExpression<JToken[]> convertArrayToJSONinputObject)
        {
            WorkflowExpression.Validate(convertArrayToJSONinputObject, nameof(convertArrayToJSONinputObject), required: true);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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