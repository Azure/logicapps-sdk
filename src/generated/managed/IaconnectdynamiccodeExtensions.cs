//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectdynamiccode
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class IaconnectdynamiccodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IWorkflowAction ImportAssemblyFromLocalFile(Expression<Func<string>> importAssemblyFromLocalFilelocalAssemblyFilePath, Expression<Func<string>> importAssemblyFromLocalFileassemblyName, Expression<Func<string>> importAssemblyFromLocalFileworkflow, Expression<Func<bool>> importAssemblyFromLocalFilecompress = null)
        {
            var __workflow_importAssemblyFromLocalFilelocalAssemblyFilePath = importAssemblyFromLocalFilelocalAssemblyFilePath == null ? null : WorkflowExpression.Compile(importAssemblyFromLocalFilelocalAssemblyFilePath);
            WorkflowExpression.Validate(__workflow_importAssemblyFromLocalFilelocalAssemblyFilePath, nameof(importAssemblyFromLocalFilelocalAssemblyFilePath), required: true);
            var __workflow_importAssemblyFromLocalFileassemblyName = importAssemblyFromLocalFileassemblyName == null ? null : WorkflowExpression.Compile(importAssemblyFromLocalFileassemblyName);
            WorkflowExpression.Validate(__workflow_importAssemblyFromLocalFileassemblyName, nameof(importAssemblyFromLocalFileassemblyName), required: true);
            var __workflow_importAssemblyFromLocalFileworkflow = importAssemblyFromLocalFileworkflow == null ? null : WorkflowExpression.Compile(importAssemblyFromLocalFileworkflow);
            WorkflowExpression.Validate(__workflow_importAssemblyFromLocalFileworkflow, nameof(importAssemblyFromLocalFileworkflow), required: true);
            var __workflow_importAssemblyFromLocalFilecompress = importAssemblyFromLocalFilecompress == null ? null : WorkflowExpression.Compile(importAssemblyFromLocalFilecompress);
            WorkflowExpression.Validate(__workflow_importAssemblyFromLocalFilecompress, nameof(importAssemblyFromLocalFilecompress), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DynamicCode/ImportAssemblyFromLocalFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var importAssemblyFromLocalFile = new JObject();
                var importAssemblyFromLocalFilepropCount = 0;
                importAssemblyFromLocalFilepropCount++;
                importAssemblyFromLocalFile["LocalAssemblyFilePath"] = ExpressionConverter.ConvertO(__workflow_importAssemblyFromLocalFilelocalAssemblyFilePath);
                importAssemblyFromLocalFilepropCount++;
                importAssemblyFromLocalFile["AssemblyName"] = ExpressionConverter.ConvertO(__workflow_importAssemblyFromLocalFileassemblyName);
                if (__workflow_importAssemblyFromLocalFilecompress != null)
                {
                    if (__workflow_importAssemblyFromLocalFilecompress != null)
                    {
                        importAssemblyFromLocalFile["Compress"] = ExpressionConverter.ConvertO(__workflow_importAssemblyFromLocalFilecompress);
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
                importAssemblyFromLocalFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_importAssemblyFromLocalFileworkflow);
                if (importAssemblyFromLocalFilepropCount > 0)
                {
                    callPayload.Body = importAssemblyFromLocalFile;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IWorkflowAction AddAssemblySearchFolder(Expression<Func<string>> addAssemblySearchFolderfolderPath, Expression<Func<string>> addAssemblySearchFolderworkflow)
        {
            var __workflow_addAssemblySearchFolderfolderPath = addAssemblySearchFolderfolderPath == null ? null : WorkflowExpression.Compile(addAssemblySearchFolderfolderPath);
            WorkflowExpression.Validate(__workflow_addAssemblySearchFolderfolderPath, nameof(addAssemblySearchFolderfolderPath), required: true);
            var __workflow_addAssemblySearchFolderworkflow = addAssemblySearchFolderworkflow == null ? null : WorkflowExpression.Compile(addAssemblySearchFolderworkflow);
            WorkflowExpression.Validate(__workflow_addAssemblySearchFolderworkflow, nameof(addAssemblySearchFolderworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DynamicCode/AddAssemblySearchFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addAssemblySearchFolder = new JObject();
                var addAssemblySearchFolderpropCount = 0;
                addAssemblySearchFolderpropCount++;
                addAssemblySearchFolder["FolderPath"] = ExpressionConverter.ConvertO(__workflow_addAssemblySearchFolderfolderPath);
                addAssemblySearchFolderpropCount++;
                addAssemblySearchFolder["Workflow"] = ExpressionConverter.ConvertO(__workflow_addAssemblySearchFolderworkflow);
                if (addAssemblySearchFolderpropCount > 0)
                {
                    callPayload.Body = addAssemblySearchFolder;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IWorkflowAction ClearAssemblySearchFolders(Expression<Func<string>> clearAssemblySearchFoldersworkflow)
        {
            var __workflow_clearAssemblySearchFoldersworkflow = clearAssemblySearchFoldersworkflow == null ? null : WorkflowExpression.Compile(clearAssemblySearchFoldersworkflow);
            WorkflowExpression.Validate(__workflow_clearAssemblySearchFoldersworkflow, nameof(clearAssemblySearchFoldersworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/DynamicCode/ClearAssemblySearchFolders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var clearAssemblySearchFolders = new JObject();
                var clearAssemblySearchFolderspropCount = 0;
                clearAssemblySearchFolderspropCount++;
                clearAssemblySearchFolders["Workflow"] = ExpressionConverter.ConvertO(__workflow_clearAssemblySearchFoldersworkflow);
                if (clearAssemblySearchFolderspropCount > 0)
                {
                    callPayload.Body = clearAssemblySearchFolders;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<IsPowerShellAutomationInstalledResponse> IsPowerShellAutomationInstalled(Expression<Func<string>> isPowerShellAutomationInstalledworkflow)
        {
            var __workflow_isPowerShellAutomationInstalledworkflow = isPowerShellAutomationInstalledworkflow == null ? null : WorkflowExpression.Compile(isPowerShellAutomationInstalledworkflow);
            WorkflowExpression.Validate(__workflow_isPowerShellAutomationInstalledworkflow, nameof(isPowerShellAutomationInstalledworkflow), required: true);
            return new DeferredBodyAction<IsPowerShellAutomationInstalledResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/isPowerShellAutomationInstalled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isPowerShellAutomationInstalled = new JObject();
                var isPowerShellAutomationInstalledpropCount = 0;
                isPowerShellAutomationInstalledpropCount++;
                isPowerShellAutomationInstalled["Workflow"] = ExpressionConverter.ConvertO(__workflow_isPowerShellAutomationInstalledworkflow);
                if (isPowerShellAutomationInstalledpropCount > 0)
                {
                    callPayload.Body = isPowerShellAutomationInstalled;
                }

                return new ApiConnectionAction<IsPowerShellAutomationInstalledResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<IsPowerShellModuleInstalledResponse> IsPowerShellModuleInstalled(Expression<Func<string>> isPowerShellModuleInstalledpowerShellModuleName, Expression<Func<string>> isPowerShellModuleInstalledworkflow)
        {
            var __workflow_isPowerShellModuleInstalledpowerShellModuleName = isPowerShellModuleInstalledpowerShellModuleName == null ? null : WorkflowExpression.Compile(isPowerShellModuleInstalledpowerShellModuleName);
            WorkflowExpression.Validate(__workflow_isPowerShellModuleInstalledpowerShellModuleName, nameof(isPowerShellModuleInstalledpowerShellModuleName), required: true);
            var __workflow_isPowerShellModuleInstalledworkflow = isPowerShellModuleInstalledworkflow == null ? null : WorkflowExpression.Compile(isPowerShellModuleInstalledworkflow);
            WorkflowExpression.Validate(__workflow_isPowerShellModuleInstalledworkflow, nameof(isPowerShellModuleInstalledworkflow), required: true);
            return new DeferredBodyAction<IsPowerShellModuleInstalledResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/isPowerShellModuleInstalled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isPowerShellModuleInstalled = new JObject();
                var isPowerShellModuleInstalledpropCount = 0;
                isPowerShellModuleInstalledpropCount++;
                isPowerShellModuleInstalled["PowerShellModuleName"] = ExpressionConverter.ConvertO(__workflow_isPowerShellModuleInstalledpowerShellModuleName);
                isPowerShellModuleInstalledpropCount++;
                isPowerShellModuleInstalled["Workflow"] = ExpressionConverter.ConvertO(__workflow_isPowerShellModuleInstalledworkflow);
                if (isPowerShellModuleInstalledpropCount > 0)
                {
                    callPayload.Body = isPowerShellModuleInstalled;
                }

                return new ApiConnectionAction<IsPowerShellModuleInstalledResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RunPowerShellAutomationScriptResponse> RunPowerShellAutomationScript(Expression<Func<string>> runPowerShellAutomationScriptworkflow, Expression<Func<string>> runPowerShellAutomationScriptpowerShellScriptContents = null, Expression<Func<string>> runPowerShellAutomationScriptcomputerName = null, Expression<Func<bool>> runPowerShellAutomationScriptisNoResultAnError = null, Expression<Func<bool>> runPowerShellAutomationScriptreturnComplexTypes = null, Expression<Func<bool>> runPowerShellAutomationScriptreturnBooleanAsBoolean = null, Expression<Func<bool>> runPowerShellAutomationScriptreturnNumericAsDecimal = null, Expression<Func<bool>> runPowerShellAutomationScriptreturnDateAsDate = null, Expression<Func<string>> runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, Expression<Func<runPowerShellAutomationScriptauthenticationMechanismInput>> runPowerShellAutomationScriptauthenticationMechanism = null, Expression<Func<int>> runPowerShellAutomationScriptconnectionAttempts = null, Expression<Func<string>> runPowerShellAutomationScriptusername = null, Expression<Func<string>> runPowerShellAutomationScriptpassword = null, Expression<Func<bool>> runPowerShellAutomationScriptrunScriptAsThread = null, Expression<Func<int>> runPowerShellAutomationScriptretrieveOutputDataFromThreadId = null, Expression<Func<int>> runPowerShellAutomationScriptsecondsToWaitForThread = null, Expression<Func<bool>> runPowerShellAutomationScriptscriptContainsStoredPassword = null, Expression<Func<bool>> runPowerShellAutomationScriptlogVerboseOutput = null, Expression<Func<bool>> runPowerShellAutomationScriptreturnSecureStrings = null, Expression<Func<string>> runPowerShellAutomationScriptpropertyNamesToSerializeJSON = null, Expression<Func<string>> runPowerShellAutomationScriptpropertyTypesToSerializeJSON = null, Expression<Func<runPowerShellAutomationScriptpowerShellCommandParametersInputItem[]>> runPowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            var __workflow_runPowerShellAutomationScriptworkflow = runPowerShellAutomationScriptworkflow == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptworkflow);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptworkflow, nameof(runPowerShellAutomationScriptworkflow), required: true);
            var __workflow_runPowerShellAutomationScriptpowerShellScriptContents = runPowerShellAutomationScriptpowerShellScriptContents == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptpowerShellScriptContents);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptpowerShellScriptContents, nameof(runPowerShellAutomationScriptpowerShellScriptContents), required: false);
            var __workflow_runPowerShellAutomationScriptcomputerName = runPowerShellAutomationScriptcomputerName == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptcomputerName);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptcomputerName, nameof(runPowerShellAutomationScriptcomputerName), required: false);
            var __workflow_runPowerShellAutomationScriptisNoResultAnError = runPowerShellAutomationScriptisNoResultAnError == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptisNoResultAnError);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptisNoResultAnError, nameof(runPowerShellAutomationScriptisNoResultAnError), required: false);
            var __workflow_runPowerShellAutomationScriptreturnComplexTypes = runPowerShellAutomationScriptreturnComplexTypes == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptreturnComplexTypes);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptreturnComplexTypes, nameof(runPowerShellAutomationScriptreturnComplexTypes), required: false);
            var __workflow_runPowerShellAutomationScriptreturnBooleanAsBoolean = runPowerShellAutomationScriptreturnBooleanAsBoolean == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptreturnBooleanAsBoolean);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptreturnBooleanAsBoolean, nameof(runPowerShellAutomationScriptreturnBooleanAsBoolean), required: false);
            var __workflow_runPowerShellAutomationScriptreturnNumericAsDecimal = runPowerShellAutomationScriptreturnNumericAsDecimal == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptreturnNumericAsDecimal);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptreturnNumericAsDecimal, nameof(runPowerShellAutomationScriptreturnNumericAsDecimal), required: false);
            var __workflow_runPowerShellAutomationScriptreturnDateAsDate = runPowerShellAutomationScriptreturnDateAsDate == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptreturnDateAsDate);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptreturnDateAsDate, nameof(runPowerShellAutomationScriptreturnDateAsDate), required: false);
            var __workflow_runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON, nameof(runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON), required: false);
            var __workflow_runPowerShellAutomationScriptauthenticationMechanism = runPowerShellAutomationScriptauthenticationMechanism == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptauthenticationMechanism);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptauthenticationMechanism, nameof(runPowerShellAutomationScriptauthenticationMechanism), required: false);
            var __workflow_runPowerShellAutomationScriptconnectionAttempts = runPowerShellAutomationScriptconnectionAttempts == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptconnectionAttempts);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptconnectionAttempts, nameof(runPowerShellAutomationScriptconnectionAttempts), required: false);
            var __workflow_runPowerShellAutomationScriptusername = runPowerShellAutomationScriptusername == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptusername);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptusername, nameof(runPowerShellAutomationScriptusername), required: false);
            var __workflow_runPowerShellAutomationScriptpassword = runPowerShellAutomationScriptpassword == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptpassword);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptpassword, nameof(runPowerShellAutomationScriptpassword), required: false);
            var __workflow_runPowerShellAutomationScriptrunScriptAsThread = runPowerShellAutomationScriptrunScriptAsThread == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptrunScriptAsThread);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptrunScriptAsThread, nameof(runPowerShellAutomationScriptrunScriptAsThread), required: false);
            var __workflow_runPowerShellAutomationScriptretrieveOutputDataFromThreadId = runPowerShellAutomationScriptretrieveOutputDataFromThreadId == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptretrieveOutputDataFromThreadId);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptretrieveOutputDataFromThreadId, nameof(runPowerShellAutomationScriptretrieveOutputDataFromThreadId), required: false);
            var __workflow_runPowerShellAutomationScriptsecondsToWaitForThread = runPowerShellAutomationScriptsecondsToWaitForThread == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptsecondsToWaitForThread);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptsecondsToWaitForThread, nameof(runPowerShellAutomationScriptsecondsToWaitForThread), required: false);
            var __workflow_runPowerShellAutomationScriptscriptContainsStoredPassword = runPowerShellAutomationScriptscriptContainsStoredPassword == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptscriptContainsStoredPassword);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptscriptContainsStoredPassword, nameof(runPowerShellAutomationScriptscriptContainsStoredPassword), required: false);
            var __workflow_runPowerShellAutomationScriptlogVerboseOutput = runPowerShellAutomationScriptlogVerboseOutput == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptlogVerboseOutput);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptlogVerboseOutput, nameof(runPowerShellAutomationScriptlogVerboseOutput), required: false);
            var __workflow_runPowerShellAutomationScriptreturnSecureStrings = runPowerShellAutomationScriptreturnSecureStrings == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptreturnSecureStrings);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptreturnSecureStrings, nameof(runPowerShellAutomationScriptreturnSecureStrings), required: false);
            var __workflow_runPowerShellAutomationScriptpropertyNamesToSerializeJSON = runPowerShellAutomationScriptpropertyNamesToSerializeJSON == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptpropertyNamesToSerializeJSON);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptpropertyNamesToSerializeJSON, nameof(runPowerShellAutomationScriptpropertyNamesToSerializeJSON), required: false);
            var __workflow_runPowerShellAutomationScriptpropertyTypesToSerializeJSON = runPowerShellAutomationScriptpropertyTypesToSerializeJSON == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptpropertyTypesToSerializeJSON);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptpropertyTypesToSerializeJSON, nameof(runPowerShellAutomationScriptpropertyTypesToSerializeJSON), required: false);
            var __workflow_runPowerShellAutomationScriptpowerShellCommandParameters = runPowerShellAutomationScriptpowerShellCommandParameters == null ? null : WorkflowExpression.Compile(runPowerShellAutomationScriptpowerShellCommandParameters);
            WorkflowExpression.Validate(__workflow_runPowerShellAutomationScriptpowerShellCommandParameters, nameof(runPowerShellAutomationScriptpowerShellCommandParameters), required: false);
            return new DeferredBodyAction<RunPowerShellAutomationScriptResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/RunPowerShellScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runPowerShellAutomationScript = new JObject();
                var runPowerShellAutomationScriptpropCount = 0;
                if (__workflow_runPowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runPowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptpowerShellScriptContents);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptcomputerName != null)
                {
                    runPowerShellAutomationScript["ComputerName"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptcomputerName);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (__workflow_runPowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runPowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptisNoResultAnError);
                        runPowerShellAutomationScriptpropCount++;
                    }

                    runPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runPowerShellAutomationScript["IsNoResultAnError"] = false;
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptreturnComplexTypes != null)
                {
                    if (__workflow_runPowerShellAutomationScriptreturnComplexTypes != null)
                    {
                        runPowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptreturnComplexTypes);
                        runPowerShellAutomationScriptpropCount++;
                    }

                    runPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runPowerShellAutomationScript["ReturnComplexTypes"] = false;
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptreturnBooleanAsBoolean != null)
                {
                    if (__workflow_runPowerShellAutomationScriptreturnBooleanAsBoolean != null)
                    {
                        runPowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptreturnBooleanAsBoolean);
                        runPowerShellAutomationScriptpropCount++;
                    }

                    runPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runPowerShellAutomationScript["ReturnBooleanAsBoolean"] = false;
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptreturnNumericAsDecimal != null)
                {
                    if (__workflow_runPowerShellAutomationScriptreturnNumericAsDecimal != null)
                    {
                        runPowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptreturnNumericAsDecimal);
                        runPowerShellAutomationScriptpropCount++;
                    }

                    runPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runPowerShellAutomationScript["ReturnNumericAsDecimal"] = false;
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptreturnDateAsDate != null)
                {
                    if (__workflow_runPowerShellAutomationScriptreturnDateAsDate != null)
                    {
                        runPowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptreturnDateAsDate);
                        runPowerShellAutomationScriptpropCount++;
                    }

                    runPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runPowerShellAutomationScript["ReturnDateAsDate"] = false;
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON != null)
                {
                    runPowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptauthenticationMechanism != null)
                {
                    runPowerShellAutomationScript["AuthenticationMechanism"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptauthenticationMechanism);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptconnectionAttempts != null)
                {
                    if (__workflow_runPowerShellAutomationScriptconnectionAttempts != null)
                    {
                        runPowerShellAutomationScript["ConnectionAttempts"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptconnectionAttempts);
                        runPowerShellAutomationScriptpropCount++;
                    }

                    runPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runPowerShellAutomationScript["ConnectionAttempts"] = 1;
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptusername != null)
                {
                    runPowerShellAutomationScript["Username"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptusername);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptpassword != null)
                {
                    runPowerShellAutomationScript["Password"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptpassword);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (__workflow_runPowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runPowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptrunScriptAsThread);
                        runPowerShellAutomationScriptpropCount++;
                    }

                    runPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runPowerShellAutomationScript["RunScriptAsThread"] = false;
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptretrieveOutputDataFromThreadId != null)
                {
                    runPowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (__workflow_runPowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runPowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptsecondsToWaitForThread);
                        runPowerShellAutomationScriptpropCount++;
                    }

                    runPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runPowerShellAutomationScript["SecondsToWaitForThread"] = 90;
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptscriptContainsStoredPassword != null)
                {
                    if (__workflow_runPowerShellAutomationScriptscriptContainsStoredPassword != null)
                    {
                        runPowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptscriptContainsStoredPassword);
                        runPowerShellAutomationScriptpropCount++;
                    }

                    runPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runPowerShellAutomationScript["ScriptContainsStoredPassword"] = true;
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptlogVerboseOutput != null)
                {
                    if (__workflow_runPowerShellAutomationScriptlogVerboseOutput != null)
                    {
                        runPowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptlogVerboseOutput);
                        runPowerShellAutomationScriptpropCount++;
                    }

                    runPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runPowerShellAutomationScript["LogVerboseOutput"] = false;
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptreturnSecureStrings != null)
                {
                    if (__workflow_runPowerShellAutomationScriptreturnSecureStrings != null)
                    {
                        runPowerShellAutomationScript["ReturnSecureStrings"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptreturnSecureStrings);
                        runPowerShellAutomationScriptpropCount++;
                    }

                    runPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runPowerShellAutomationScript["ReturnSecureStrings"] = false;
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptpropertyNamesToSerializeJSON != null)
                {
                    runPowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runPowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runPowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runPowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptpowerShellCommandParameters);
                    runPowerShellAutomationScriptpropCount++;
                }

                runPowerShellAutomationScriptpropCount++;
                runPowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(__workflow_runPowerShellAutomationScriptworkflow);
                if (runPowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runPowerShellAutomationScript;
                }

                return new ApiConnectionAction<RunPowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetPowerShellVersionResponse> GetPowerShellVersion(Expression<Func<string>> getPowerShellVersionworkflow, Expression<Func<string>> getPowerShellVersioncomputerName = null, Expression<Func<getPowerShellVersionauthenticationMechanismInput>> getPowerShellVersionauthenticationMechanism = null, Expression<Func<int>> getPowerShellVersionconnectionAttempts = null)
        {
            var __workflow_getPowerShellVersionworkflow = getPowerShellVersionworkflow == null ? null : WorkflowExpression.Compile(getPowerShellVersionworkflow);
            WorkflowExpression.Validate(__workflow_getPowerShellVersionworkflow, nameof(getPowerShellVersionworkflow), required: true);
            var __workflow_getPowerShellVersioncomputerName = getPowerShellVersioncomputerName == null ? null : WorkflowExpression.Compile(getPowerShellVersioncomputerName);
            WorkflowExpression.Validate(__workflow_getPowerShellVersioncomputerName, nameof(getPowerShellVersioncomputerName), required: false);
            var __workflow_getPowerShellVersionauthenticationMechanism = getPowerShellVersionauthenticationMechanism == null ? null : WorkflowExpression.Compile(getPowerShellVersionauthenticationMechanism);
            WorkflowExpression.Validate(__workflow_getPowerShellVersionauthenticationMechanism, nameof(getPowerShellVersionauthenticationMechanism), required: false);
            var __workflow_getPowerShellVersionconnectionAttempts = getPowerShellVersionconnectionAttempts == null ? null : WorkflowExpression.Compile(getPowerShellVersionconnectionAttempts);
            WorkflowExpression.Validate(__workflow_getPowerShellVersionconnectionAttempts, nameof(getPowerShellVersionconnectionAttempts), required: false);
            return new DeferredBodyAction<GetPowerShellVersionResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/GetPowerShellVersion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getPowerShellVersion = new JObject();
                var getPowerShellVersionpropCount = 0;
                if (__workflow_getPowerShellVersioncomputerName != null)
                {
                    getPowerShellVersion["ComputerName"] = ExpressionConverter.ConvertO(__workflow_getPowerShellVersioncomputerName);
                    getPowerShellVersionpropCount++;
                }

                if (__workflow_getPowerShellVersionauthenticationMechanism != null)
                {
                    getPowerShellVersion["AuthenticationMechanism"] = ExpressionConverter.ConvertO(__workflow_getPowerShellVersionauthenticationMechanism);
                    getPowerShellVersionpropCount++;
                }

                if (__workflow_getPowerShellVersionconnectionAttempts != null)
                {
                    if (__workflow_getPowerShellVersionconnectionAttempts != null)
                    {
                        getPowerShellVersion["ConnectionAttempts"] = ExpressionConverter.ConvertO(__workflow_getPowerShellVersionconnectionAttempts);
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
                getPowerShellVersion["Workflow"] = ExpressionConverter.ConvertO(__workflow_getPowerShellVersionworkflow);
                if (getPowerShellVersionpropCount > 0)
                {
                    callPayload.Body = getPowerShellVersion;
                }

                return new ApiConnectionAction<GetPowerShellVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetRegexMatchResponse> GetRegexMatch(Expression<Func<string>> getRegexMatchtextToMatch, Expression<Func<string>> getRegexMatchregex, Expression<Func<int>> getRegexMatchsearchIndex = null, Expression<Func<bool>> getRegexMatchcaseSensitive = null, Expression<Func<int>> getRegexMatchregexTimeoutInSeconds = null)
        {
            var __workflow_getRegexMatchtextToMatch = getRegexMatchtextToMatch == null ? null : WorkflowExpression.Compile(getRegexMatchtextToMatch);
            WorkflowExpression.Validate(__workflow_getRegexMatchtextToMatch, nameof(getRegexMatchtextToMatch), required: true);
            var __workflow_getRegexMatchregex = getRegexMatchregex == null ? null : WorkflowExpression.Compile(getRegexMatchregex);
            WorkflowExpression.Validate(__workflow_getRegexMatchregex, nameof(getRegexMatchregex), required: true);
            var __workflow_getRegexMatchsearchIndex = getRegexMatchsearchIndex == null ? null : WorkflowExpression.Compile(getRegexMatchsearchIndex);
            WorkflowExpression.Validate(__workflow_getRegexMatchsearchIndex, nameof(getRegexMatchsearchIndex), required: false);
            var __workflow_getRegexMatchcaseSensitive = getRegexMatchcaseSensitive == null ? null : WorkflowExpression.Compile(getRegexMatchcaseSensitive);
            WorkflowExpression.Validate(__workflow_getRegexMatchcaseSensitive, nameof(getRegexMatchcaseSensitive), required: false);
            var __workflow_getRegexMatchregexTimeoutInSeconds = getRegexMatchregexTimeoutInSeconds == null ? null : WorkflowExpression.Compile(getRegexMatchregexTimeoutInSeconds);
            WorkflowExpression.Validate(__workflow_getRegexMatchregexTimeoutInSeconds, nameof(getRegexMatchregexTimeoutInSeconds), required: false);
            return new DeferredBodyAction<GetRegexMatchResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetRegexMatch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRegexMatch = new JObject();
                var getRegexMatchpropCount = 0;
                getRegexMatchpropCount++;
                getRegexMatch["TextToMatch"] = ExpressionConverter.ConvertO(__workflow_getRegexMatchtextToMatch);
                getRegexMatchpropCount++;
                getRegexMatch["Regex"] = ExpressionConverter.ConvertO(__workflow_getRegexMatchregex);
                if (__workflow_getRegexMatchsearchIndex != null)
                {
                    if (__workflow_getRegexMatchsearchIndex != null)
                    {
                        getRegexMatch["SearchIndex"] = ExpressionConverter.ConvertO(__workflow_getRegexMatchsearchIndex);
                        getRegexMatchpropCount++;
                    }

                    getRegexMatchpropCount++;
                }
                else
                {
                    getRegexMatch["SearchIndex"] = 1;
                    getRegexMatchpropCount++;
                }

                if (__workflow_getRegexMatchcaseSensitive != null)
                {
                    if (__workflow_getRegexMatchcaseSensitive != null)
                    {
                        getRegexMatch["CaseSensitive"] = ExpressionConverter.ConvertO(__workflow_getRegexMatchcaseSensitive);
                        getRegexMatchpropCount++;
                    }

                    getRegexMatchpropCount++;
                }
                else
                {
                    getRegexMatch["CaseSensitive"] = true;
                    getRegexMatchpropCount++;
                }

                if (__workflow_getRegexMatchregexTimeoutInSeconds != null)
                {
                    if (__workflow_getRegexMatchregexTimeoutInSeconds != null)
                    {
                        getRegexMatch["RegexTimeoutInSeconds"] = ExpressionConverter.ConvertO(__workflow_getRegexMatchregexTimeoutInSeconds);
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
        public IBodyWorkflowAction<GetRegexMatchesResponse> GetRegexMatches(Expression<Func<string>> getRegexMatchestextToMatch, Expression<Func<string>> getRegexMatchesregex, Expression<Func<int>> getRegexMatchesmaximumMatches = null, Expression<Func<bool>> getRegexMatchescaseSensitive = null, Expression<Func<bool>> getRegexMatchestrimResults = null, Expression<Func<bool>> getRegexMatchesremoveEmptyResults = null, Expression<Func<int>> getRegexMatchesregexTimeoutInSeconds = null)
        {
            var __workflow_getRegexMatchestextToMatch = getRegexMatchestextToMatch == null ? null : WorkflowExpression.Compile(getRegexMatchestextToMatch);
            WorkflowExpression.Validate(__workflow_getRegexMatchestextToMatch, nameof(getRegexMatchestextToMatch), required: true);
            var __workflow_getRegexMatchesregex = getRegexMatchesregex == null ? null : WorkflowExpression.Compile(getRegexMatchesregex);
            WorkflowExpression.Validate(__workflow_getRegexMatchesregex, nameof(getRegexMatchesregex), required: true);
            var __workflow_getRegexMatchesmaximumMatches = getRegexMatchesmaximumMatches == null ? null : WorkflowExpression.Compile(getRegexMatchesmaximumMatches);
            WorkflowExpression.Validate(__workflow_getRegexMatchesmaximumMatches, nameof(getRegexMatchesmaximumMatches), required: false);
            var __workflow_getRegexMatchescaseSensitive = getRegexMatchescaseSensitive == null ? null : WorkflowExpression.Compile(getRegexMatchescaseSensitive);
            WorkflowExpression.Validate(__workflow_getRegexMatchescaseSensitive, nameof(getRegexMatchescaseSensitive), required: false);
            var __workflow_getRegexMatchestrimResults = getRegexMatchestrimResults == null ? null : WorkflowExpression.Compile(getRegexMatchestrimResults);
            WorkflowExpression.Validate(__workflow_getRegexMatchestrimResults, nameof(getRegexMatchestrimResults), required: false);
            var __workflow_getRegexMatchesremoveEmptyResults = getRegexMatchesremoveEmptyResults == null ? null : WorkflowExpression.Compile(getRegexMatchesremoveEmptyResults);
            WorkflowExpression.Validate(__workflow_getRegexMatchesremoveEmptyResults, nameof(getRegexMatchesremoveEmptyResults), required: false);
            var __workflow_getRegexMatchesregexTimeoutInSeconds = getRegexMatchesregexTimeoutInSeconds == null ? null : WorkflowExpression.Compile(getRegexMatchesregexTimeoutInSeconds);
            WorkflowExpression.Validate(__workflow_getRegexMatchesregexTimeoutInSeconds, nameof(getRegexMatchesregexTimeoutInSeconds), required: false);
            return new DeferredBodyAction<GetRegexMatchesResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetRegexMatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRegexMatches = new JObject();
                var getRegexMatchespropCount = 0;
                getRegexMatchespropCount++;
                getRegexMatches["TextToMatch"] = ExpressionConverter.ConvertO(__workflow_getRegexMatchestextToMatch);
                getRegexMatchespropCount++;
                getRegexMatches["Regex"] = ExpressionConverter.ConvertO(__workflow_getRegexMatchesregex);
                if (__workflow_getRegexMatchesmaximumMatches != null)
                {
                    if (__workflow_getRegexMatchesmaximumMatches != null)
                    {
                        getRegexMatches["MaximumMatches"] = ExpressionConverter.ConvertO(__workflow_getRegexMatchesmaximumMatches);
                        getRegexMatchespropCount++;
                    }

                    getRegexMatchespropCount++;
                }
                else
                {
                    getRegexMatches["MaximumMatches"] = 0;
                    getRegexMatchespropCount++;
                }

                if (__workflow_getRegexMatchescaseSensitive != null)
                {
                    if (__workflow_getRegexMatchescaseSensitive != null)
                    {
                        getRegexMatches["CaseSensitive"] = ExpressionConverter.ConvertO(__workflow_getRegexMatchescaseSensitive);
                        getRegexMatchespropCount++;
                    }

                    getRegexMatchespropCount++;
                }
                else
                {
                    getRegexMatches["CaseSensitive"] = true;
                    getRegexMatchespropCount++;
                }

                if (__workflow_getRegexMatchestrimResults != null)
                {
                    if (__workflow_getRegexMatchestrimResults != null)
                    {
                        getRegexMatches["TrimResults"] = ExpressionConverter.ConvertO(__workflow_getRegexMatchestrimResults);
                        getRegexMatchespropCount++;
                    }

                    getRegexMatchespropCount++;
                }
                else
                {
                    getRegexMatches["TrimResults"] = true;
                    getRegexMatchespropCount++;
                }

                if (__workflow_getRegexMatchesremoveEmptyResults != null)
                {
                    if (__workflow_getRegexMatchesremoveEmptyResults != null)
                    {
                        getRegexMatches["RemoveEmptyResults"] = ExpressionConverter.ConvertO(__workflow_getRegexMatchesremoveEmptyResults);
                        getRegexMatchespropCount++;
                    }

                    getRegexMatchespropCount++;
                }
                else
                {
                    getRegexMatches["RemoveEmptyResults"] = false;
                    getRegexMatchespropCount++;
                }

                if (__workflow_getRegexMatchesregexTimeoutInSeconds != null)
                {
                    if (__workflow_getRegexMatchesregexTimeoutInSeconds != null)
                    {
                        getRegexMatches["RegexTimeoutInSeconds"] = ExpressionConverter.ConvertO(__workflow_getRegexMatchesregexTimeoutInSeconds);
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
        public IBodyWorkflowAction<GetRegexSplitResponse> GetRegexSplit(Expression<Func<string>> getRegexSplittextToSplit, Expression<Func<string>> getRegexSplitregex, Expression<Func<bool>> getRegexSplitcaseSensitive = null, Expression<Func<bool>> getRegexSplittrimResults = null, Expression<Func<bool>> getRegexSplitremoveEmptyResults = null, Expression<Func<int>> getRegexSplitregexTimeoutInSeconds = null)
        {
            var __workflow_getRegexSplittextToSplit = getRegexSplittextToSplit == null ? null : WorkflowExpression.Compile(getRegexSplittextToSplit);
            WorkflowExpression.Validate(__workflow_getRegexSplittextToSplit, nameof(getRegexSplittextToSplit), required: true);
            var __workflow_getRegexSplitregex = getRegexSplitregex == null ? null : WorkflowExpression.Compile(getRegexSplitregex);
            WorkflowExpression.Validate(__workflow_getRegexSplitregex, nameof(getRegexSplitregex), required: true);
            var __workflow_getRegexSplitcaseSensitive = getRegexSplitcaseSensitive == null ? null : WorkflowExpression.Compile(getRegexSplitcaseSensitive);
            WorkflowExpression.Validate(__workflow_getRegexSplitcaseSensitive, nameof(getRegexSplitcaseSensitive), required: false);
            var __workflow_getRegexSplittrimResults = getRegexSplittrimResults == null ? null : WorkflowExpression.Compile(getRegexSplittrimResults);
            WorkflowExpression.Validate(__workflow_getRegexSplittrimResults, nameof(getRegexSplittrimResults), required: false);
            var __workflow_getRegexSplitremoveEmptyResults = getRegexSplitremoveEmptyResults == null ? null : WorkflowExpression.Compile(getRegexSplitremoveEmptyResults);
            WorkflowExpression.Validate(__workflow_getRegexSplitremoveEmptyResults, nameof(getRegexSplitremoveEmptyResults), required: false);
            var __workflow_getRegexSplitregexTimeoutInSeconds = getRegexSplitregexTimeoutInSeconds == null ? null : WorkflowExpression.Compile(getRegexSplitregexTimeoutInSeconds);
            WorkflowExpression.Validate(__workflow_getRegexSplitregexTimeoutInSeconds, nameof(getRegexSplitregexTimeoutInSeconds), required: false);
            return new DeferredBodyAction<GetRegexSplitResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetRegexSplit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRegexSplit = new JObject();
                var getRegexSplitpropCount = 0;
                getRegexSplitpropCount++;
                getRegexSplit["TextToSplit"] = ExpressionConverter.ConvertO(__workflow_getRegexSplittextToSplit);
                getRegexSplitpropCount++;
                getRegexSplit["Regex"] = ExpressionConverter.ConvertO(__workflow_getRegexSplitregex);
                if (__workflow_getRegexSplitcaseSensitive != null)
                {
                    if (__workflow_getRegexSplitcaseSensitive != null)
                    {
                        getRegexSplit["CaseSensitive"] = ExpressionConverter.ConvertO(__workflow_getRegexSplitcaseSensitive);
                        getRegexSplitpropCount++;
                    }

                    getRegexSplitpropCount++;
                }
                else
                {
                    getRegexSplit["CaseSensitive"] = true;
                    getRegexSplitpropCount++;
                }

                if (__workflow_getRegexSplittrimResults != null)
                {
                    if (__workflow_getRegexSplittrimResults != null)
                    {
                        getRegexSplit["TrimResults"] = ExpressionConverter.ConvertO(__workflow_getRegexSplittrimResults);
                        getRegexSplitpropCount++;
                    }

                    getRegexSplitpropCount++;
                }
                else
                {
                    getRegexSplit["TrimResults"] = true;
                    getRegexSplitpropCount++;
                }

                if (__workflow_getRegexSplitremoveEmptyResults != null)
                {
                    if (__workflow_getRegexSplitremoveEmptyResults != null)
                    {
                        getRegexSplit["RemoveEmptyResults"] = ExpressionConverter.ConvertO(__workflow_getRegexSplitremoveEmptyResults);
                        getRegexSplitpropCount++;
                    }

                    getRegexSplitpropCount++;
                }
                else
                {
                    getRegexSplit["RemoveEmptyResults"] = false;
                    getRegexSplitpropCount++;
                }

                if (__workflow_getRegexSplitregexTimeoutInSeconds != null)
                {
                    if (__workflow_getRegexSplitregexTimeoutInSeconds != null)
                    {
                        getRegexSplit["RegexTimeoutInSeconds"] = ExpressionConverter.ConvertO(__workflow_getRegexSplitregexTimeoutInSeconds);
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
        public IBodyWorkflowAction<GetRegexGroupMatchesResponse> GetRegexGroupMatches(Expression<Func<string>> getRegexGroupMatchestextToMatch, Expression<Func<string>> getRegexGroupMatchesregex, Expression<Func<string[]>> getRegexGroupMatchesgroupsToRetrieve = null, Expression<Func<int>> getRegexGroupMatchessearchIndex = null, Expression<Func<bool>> getRegexGroupMatchescaseSensitive = null, Expression<Func<int>> getRegexGroupMatchesregexTimeoutInSeconds = null)
        {
            var __workflow_getRegexGroupMatchestextToMatch = getRegexGroupMatchestextToMatch == null ? null : WorkflowExpression.Compile(getRegexGroupMatchestextToMatch);
            WorkflowExpression.Validate(__workflow_getRegexGroupMatchestextToMatch, nameof(getRegexGroupMatchestextToMatch), required: true);
            var __workflow_getRegexGroupMatchesregex = getRegexGroupMatchesregex == null ? null : WorkflowExpression.Compile(getRegexGroupMatchesregex);
            WorkflowExpression.Validate(__workflow_getRegexGroupMatchesregex, nameof(getRegexGroupMatchesregex), required: true);
            var __workflow_getRegexGroupMatchesgroupsToRetrieve = getRegexGroupMatchesgroupsToRetrieve == null ? null : WorkflowExpression.Compile(getRegexGroupMatchesgroupsToRetrieve);
            WorkflowExpression.Validate(__workflow_getRegexGroupMatchesgroupsToRetrieve, nameof(getRegexGroupMatchesgroupsToRetrieve), required: false);
            var __workflow_getRegexGroupMatchessearchIndex = getRegexGroupMatchessearchIndex == null ? null : WorkflowExpression.Compile(getRegexGroupMatchessearchIndex);
            WorkflowExpression.Validate(__workflow_getRegexGroupMatchessearchIndex, nameof(getRegexGroupMatchessearchIndex), required: false);
            var __workflow_getRegexGroupMatchescaseSensitive = getRegexGroupMatchescaseSensitive == null ? null : WorkflowExpression.Compile(getRegexGroupMatchescaseSensitive);
            WorkflowExpression.Validate(__workflow_getRegexGroupMatchescaseSensitive, nameof(getRegexGroupMatchescaseSensitive), required: false);
            var __workflow_getRegexGroupMatchesregexTimeoutInSeconds = getRegexGroupMatchesregexTimeoutInSeconds == null ? null : WorkflowExpression.Compile(getRegexGroupMatchesregexTimeoutInSeconds);
            WorkflowExpression.Validate(__workflow_getRegexGroupMatchesregexTimeoutInSeconds, nameof(getRegexGroupMatchesregexTimeoutInSeconds), required: false);
            return new DeferredBodyAction<GetRegexGroupMatchesResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetRegexGroupMatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getRegexGroupMatches = new JObject();
                var getRegexGroupMatchespropCount = 0;
                getRegexGroupMatchespropCount++;
                getRegexGroupMatches["TextToMatch"] = ExpressionConverter.ConvertO(__workflow_getRegexGroupMatchestextToMatch);
                getRegexGroupMatchespropCount++;
                getRegexGroupMatches["Regex"] = ExpressionConverter.ConvertO(__workflow_getRegexGroupMatchesregex);
                if (__workflow_getRegexGroupMatchesgroupsToRetrieve != null)
                {
                    getRegexGroupMatches["GroupsToRetrieve"] = ExpressionConverter.ConvertO(__workflow_getRegexGroupMatchesgroupsToRetrieve);
                    getRegexGroupMatchespropCount++;
                }

                if (__workflow_getRegexGroupMatchessearchIndex != null)
                {
                    if (__workflow_getRegexGroupMatchessearchIndex != null)
                    {
                        getRegexGroupMatches["SearchIndex"] = ExpressionConverter.ConvertO(__workflow_getRegexGroupMatchessearchIndex);
                        getRegexGroupMatchespropCount++;
                    }

                    getRegexGroupMatchespropCount++;
                }
                else
                {
                    getRegexGroupMatches["SearchIndex"] = 1;
                    getRegexGroupMatchespropCount++;
                }

                if (__workflow_getRegexGroupMatchescaseSensitive != null)
                {
                    if (__workflow_getRegexGroupMatchescaseSensitive != null)
                    {
                        getRegexGroupMatches["CaseSensitive"] = ExpressionConverter.ConvertO(__workflow_getRegexGroupMatchescaseSensitive);
                        getRegexGroupMatchespropCount++;
                    }

                    getRegexGroupMatchespropCount++;
                }
                else
                {
                    getRegexGroupMatches["CaseSensitive"] = true;
                    getRegexGroupMatchespropCount++;
                }

                if (__workflow_getRegexGroupMatchesregexTimeoutInSeconds != null)
                {
                    if (__workflow_getRegexGroupMatchesregexTimeoutInSeconds != null)
                    {
                        getRegexGroupMatches["RegexTimeoutInSeconds"] = ExpressionConverter.ConvertO(__workflow_getRegexGroupMatchesregexTimeoutInSeconds);
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
        public IBodyWorkflowAction<CreateJSONFromInputVariablesResponse> CreateJSONFromInputVariables(Expression<Func<createJSONFromInputVariablesinputVariablesInputItem[]>> createJSONFromInputVariablesinputVariables, Expression<Func<bool>> createJSONFromInputVariablesreturnAsJSONTable)
        {
            var __workflow_createJSONFromInputVariablesinputVariables = createJSONFromInputVariablesinputVariables == null ? null : WorkflowExpression.Compile(createJSONFromInputVariablesinputVariables);
            WorkflowExpression.Validate(__workflow_createJSONFromInputVariablesinputVariables, nameof(createJSONFromInputVariablesinputVariables), required: true);
            var __workflow_createJSONFromInputVariablesreturnAsJSONTable = createJSONFromInputVariablesreturnAsJSONTable == null ? null : WorkflowExpression.Compile(createJSONFromInputVariablesreturnAsJSONTable);
            WorkflowExpression.Validate(__workflow_createJSONFromInputVariablesreturnAsJSONTable, nameof(createJSONFromInputVariablesreturnAsJSONTable), required: true);
            return new DeferredBodyAction<CreateJSONFromInputVariablesResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/CreateJSONFromInputVariables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createJSONFromInputVariables = new JObject();
                var createJSONFromInputVariablespropCount = 0;
                createJSONFromInputVariablespropCount++;
                createJSONFromInputVariables["InputVariables"] = ExpressionConverter.ConvertO(__workflow_createJSONFromInputVariablesinputVariables);
                createJSONFromInputVariablespropCount++;
                createJSONFromInputVariables["ReturnAsJSONTable"] = ExpressionConverter.ConvertO(__workflow_createJSONFromInputVariablesreturnAsJSONTable);
                if (createJSONFromInputVariablespropCount > 0)
                {
                    callPayload.Body = createJSONFromInputVariables;
                }

                return new ApiConnectionAction<CreateJSONFromInputVariablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetJSONTableFromStringArrayResponse> GetJSONTableFromStringArray(Expression<Func<string[]>> getJSONTableFromStringArrayinputArray, Expression<Func<string>> getJSONTableFromStringArraycolumnName, Expression<Func<bool>> getJSONTableFromStringArraydropEmptyItems = null)
        {
            var __workflow_getJSONTableFromStringArrayinputArray = getJSONTableFromStringArrayinputArray == null ? null : WorkflowExpression.Compile(getJSONTableFromStringArrayinputArray);
            WorkflowExpression.Validate(__workflow_getJSONTableFromStringArrayinputArray, nameof(getJSONTableFromStringArrayinputArray), required: true);
            var __workflow_getJSONTableFromStringArraycolumnName = getJSONTableFromStringArraycolumnName == null ? null : WorkflowExpression.Compile(getJSONTableFromStringArraycolumnName);
            WorkflowExpression.Validate(__workflow_getJSONTableFromStringArraycolumnName, nameof(getJSONTableFromStringArraycolumnName), required: true);
            var __workflow_getJSONTableFromStringArraydropEmptyItems = getJSONTableFromStringArraydropEmptyItems == null ? null : WorkflowExpression.Compile(getJSONTableFromStringArraydropEmptyItems);
            WorkflowExpression.Validate(__workflow_getJSONTableFromStringArraydropEmptyItems, nameof(getJSONTableFromStringArraydropEmptyItems), required: false);
            return new DeferredBodyAction<GetJSONTableFromStringArrayResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetJSONTableFromStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getJSONTableFromStringArray = new JObject();
                var getJSONTableFromStringArraypropCount = 0;
                getJSONTableFromStringArraypropCount++;
                getJSONTableFromStringArray["InputArray"] = ExpressionConverter.ConvertO(__workflow_getJSONTableFromStringArrayinputArray);
                getJSONTableFromStringArraypropCount++;
                getJSONTableFromStringArray["ColumnName"] = ExpressionConverter.ConvertO(__workflow_getJSONTableFromStringArraycolumnName);
                if (__workflow_getJSONTableFromStringArraydropEmptyItems != null)
                {
                    if (__workflow_getJSONTableFromStringArraydropEmptyItems != null)
                    {
                        getJSONTableFromStringArray["DropEmptyItems"] = ExpressionConverter.ConvertO(__workflow_getJSONTableFromStringArraydropEmptyItems);
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
        public IBodyWorkflowAction<FilterJSONTableResponse> FilterJSONTable(Expression<Func<string>> filterJSONTablejSONTable, Expression<Func<string>> filterJSONTablefilter, Expression<Func<string>> filterJSONTablesortColumnName = null, Expression<Func<bool>> filterJSONTableascending = null, Expression<Func<string>> filterJSONTablesortColumnName2 = null, Expression<Func<bool>> filterJSONTableascending2 = null, Expression<Func<string>> filterJSONTablesortColumnName3 = null, Expression<Func<bool>> filterJSONTableascending3 = null)
        {
            var __workflow_filterJSONTablejSONTable = filterJSONTablejSONTable == null ? null : WorkflowExpression.Compile(filterJSONTablejSONTable);
            WorkflowExpression.Validate(__workflow_filterJSONTablejSONTable, nameof(filterJSONTablejSONTable), required: true);
            var __workflow_filterJSONTablefilter = filterJSONTablefilter == null ? null : WorkflowExpression.Compile(filterJSONTablefilter);
            WorkflowExpression.Validate(__workflow_filterJSONTablefilter, nameof(filterJSONTablefilter), required: true);
            var __workflow_filterJSONTablesortColumnName = filterJSONTablesortColumnName == null ? null : WorkflowExpression.Compile(filterJSONTablesortColumnName);
            WorkflowExpression.Validate(__workflow_filterJSONTablesortColumnName, nameof(filterJSONTablesortColumnName), required: false);
            var __workflow_filterJSONTableascending = filterJSONTableascending == null ? null : WorkflowExpression.Compile(filterJSONTableascending);
            WorkflowExpression.Validate(__workflow_filterJSONTableascending, nameof(filterJSONTableascending), required: false);
            var __workflow_filterJSONTablesortColumnName2 = filterJSONTablesortColumnName2 == null ? null : WorkflowExpression.Compile(filterJSONTablesortColumnName2);
            WorkflowExpression.Validate(__workflow_filterJSONTablesortColumnName2, nameof(filterJSONTablesortColumnName2), required: false);
            var __workflow_filterJSONTableascending2 = filterJSONTableascending2 == null ? null : WorkflowExpression.Compile(filterJSONTableascending2);
            WorkflowExpression.Validate(__workflow_filterJSONTableascending2, nameof(filterJSONTableascending2), required: false);
            var __workflow_filterJSONTablesortColumnName3 = filterJSONTablesortColumnName3 == null ? null : WorkflowExpression.Compile(filterJSONTablesortColumnName3);
            WorkflowExpression.Validate(__workflow_filterJSONTablesortColumnName3, nameof(filterJSONTablesortColumnName3), required: false);
            var __workflow_filterJSONTableascending3 = filterJSONTableascending3 == null ? null : WorkflowExpression.Compile(filterJSONTableascending3);
            WorkflowExpression.Validate(__workflow_filterJSONTableascending3, nameof(filterJSONTableascending3), required: false);
            return new DeferredBodyAction<FilterJSONTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/FilterJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var filterJSONTable = new JObject();
                var filterJSONTablepropCount = 0;
                filterJSONTablepropCount++;
                filterJSONTable["JSONTable"] = ExpressionConverter.ConvertO(__workflow_filterJSONTablejSONTable);
                filterJSONTablepropCount++;
                filterJSONTable["Filter"] = ExpressionConverter.ConvertO(__workflow_filterJSONTablefilter);
                if (__workflow_filterJSONTablesortColumnName != null)
                {
                    filterJSONTable["SortColumnName"] = ExpressionConverter.ConvertO(__workflow_filterJSONTablesortColumnName);
                    filterJSONTablepropCount++;
                }

                if (__workflow_filterJSONTableascending != null)
                {
                    if (__workflow_filterJSONTableascending != null)
                    {
                        filterJSONTable["Ascending"] = ExpressionConverter.ConvertO(__workflow_filterJSONTableascending);
                        filterJSONTablepropCount++;
                    }

                    filterJSONTablepropCount++;
                }
                else
                {
                    filterJSONTable["Ascending"] = true;
                    filterJSONTablepropCount++;
                }

                if (__workflow_filterJSONTablesortColumnName2 != null)
                {
                    filterJSONTable["SortColumnName2"] = ExpressionConverter.ConvertO(__workflow_filterJSONTablesortColumnName2);
                    filterJSONTablepropCount++;
                }

                if (__workflow_filterJSONTableascending2 != null)
                {
                    if (__workflow_filterJSONTableascending2 != null)
                    {
                        filterJSONTable["Ascending2"] = ExpressionConverter.ConvertO(__workflow_filterJSONTableascending2);
                        filterJSONTablepropCount++;
                    }

                    filterJSONTablepropCount++;
                }
                else
                {
                    filterJSONTable["Ascending2"] = true;
                    filterJSONTablepropCount++;
                }

                if (__workflow_filterJSONTablesortColumnName3 != null)
                {
                    filterJSONTable["SortColumnName3"] = ExpressionConverter.ConvertO(__workflow_filterJSONTablesortColumnName3);
                    filterJSONTablepropCount++;
                }

                if (__workflow_filterJSONTableascending3 != null)
                {
                    if (__workflow_filterJSONTableascending3 != null)
                    {
                        filterJSONTable["Ascending3"] = ExpressionConverter.ConvertO(__workflow_filterJSONTableascending3);
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
        public IBodyWorkflowAction<FilterTableResponse> FilterTable(Expression<Func<JToken[]>> filterTableinputTable, Expression<Func<string>> filterTablefilter, Expression<Func<string>> filterTablesortColumnName = null, Expression<Func<bool>> filterTableascending = null, Expression<Func<string>> filterTablesortColumnName2 = null, Expression<Func<bool>> filterTableascending2 = null, Expression<Func<string>> filterTablesortColumnName3 = null, Expression<Func<bool>> filterTableascending3 = null)
        {
            var __workflow_filterTableinputTable = filterTableinputTable == null ? null : WorkflowExpression.Compile(filterTableinputTable);
            WorkflowExpression.Validate(__workflow_filterTableinputTable, nameof(filterTableinputTable), required: true);
            var __workflow_filterTablefilter = filterTablefilter == null ? null : WorkflowExpression.Compile(filterTablefilter);
            WorkflowExpression.Validate(__workflow_filterTablefilter, nameof(filterTablefilter), required: true);
            var __workflow_filterTablesortColumnName = filterTablesortColumnName == null ? null : WorkflowExpression.Compile(filterTablesortColumnName);
            WorkflowExpression.Validate(__workflow_filterTablesortColumnName, nameof(filterTablesortColumnName), required: false);
            var __workflow_filterTableascending = filterTableascending == null ? null : WorkflowExpression.Compile(filterTableascending);
            WorkflowExpression.Validate(__workflow_filterTableascending, nameof(filterTableascending), required: false);
            var __workflow_filterTablesortColumnName2 = filterTablesortColumnName2 == null ? null : WorkflowExpression.Compile(filterTablesortColumnName2);
            WorkflowExpression.Validate(__workflow_filterTablesortColumnName2, nameof(filterTablesortColumnName2), required: false);
            var __workflow_filterTableascending2 = filterTableascending2 == null ? null : WorkflowExpression.Compile(filterTableascending2);
            WorkflowExpression.Validate(__workflow_filterTableascending2, nameof(filterTableascending2), required: false);
            var __workflow_filterTablesortColumnName3 = filterTablesortColumnName3 == null ? null : WorkflowExpression.Compile(filterTablesortColumnName3);
            WorkflowExpression.Validate(__workflow_filterTablesortColumnName3, nameof(filterTablesortColumnName3), required: false);
            var __workflow_filterTableascending3 = filterTableascending3 == null ? null : WorkflowExpression.Compile(filterTableascending3);
            WorkflowExpression.Validate(__workflow_filterTableascending3, nameof(filterTableascending3), required: false);
            return new DeferredBodyAction<FilterTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/FilterTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var filterTable = new JObject();
                var filterTablepropCount = 0;
                filterTablepropCount++;
                filterTable["InputTable"] = ExpressionConverter.ConvertO(__workflow_filterTableinputTable);
                filterTablepropCount++;
                filterTable["Filter"] = ExpressionConverter.ConvertO(__workflow_filterTablefilter);
                if (__workflow_filterTablesortColumnName != null)
                {
                    filterTable["SortColumnName"] = ExpressionConverter.ConvertO(__workflow_filterTablesortColumnName);
                    filterTablepropCount++;
                }

                if (__workflow_filterTableascending != null)
                {
                    if (__workflow_filterTableascending != null)
                    {
                        filterTable["Ascending"] = ExpressionConverter.ConvertO(__workflow_filterTableascending);
                        filterTablepropCount++;
                    }

                    filterTablepropCount++;
                }
                else
                {
                    filterTable["Ascending"] = true;
                    filterTablepropCount++;
                }

                if (__workflow_filterTablesortColumnName2 != null)
                {
                    filterTable["SortColumnName2"] = ExpressionConverter.ConvertO(__workflow_filterTablesortColumnName2);
                    filterTablepropCount++;
                }

                if (__workflow_filterTableascending2 != null)
                {
                    if (__workflow_filterTableascending2 != null)
                    {
                        filterTable["Ascending2"] = ExpressionConverter.ConvertO(__workflow_filterTableascending2);
                        filterTablepropCount++;
                    }

                    filterTablepropCount++;
                }
                else
                {
                    filterTable["Ascending2"] = true;
                    filterTablepropCount++;
                }

                if (__workflow_filterTablesortColumnName3 != null)
                {
                    filterTable["SortColumnName3"] = ExpressionConverter.ConvertO(__workflow_filterTablesortColumnName3);
                    filterTablepropCount++;
                }

                if (__workflow_filterTableascending3 != null)
                {
                    if (__workflow_filterTableascending3 != null)
                    {
                        filterTable["Ascending3"] = ExpressionConverter.ConvertO(__workflow_filterTableascending3);
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
        public IBodyWorkflowAction<SortTableResponse> SortTable(Expression<Func<JToken[]>> sortTableinputTable, Expression<Func<string>> sortTablesortColumnName, Expression<Func<bool>> sortTableascending, Expression<Func<string>> sortTablesortColumnName2 = null, Expression<Func<bool>> sortTableascending2 = null, Expression<Func<string>> sortTablesortColumnName3 = null, Expression<Func<bool>> sortTableascending3 = null)
        {
            var __workflow_sortTableinputTable = sortTableinputTable == null ? null : WorkflowExpression.Compile(sortTableinputTable);
            WorkflowExpression.Validate(__workflow_sortTableinputTable, nameof(sortTableinputTable), required: true);
            var __workflow_sortTablesortColumnName = sortTablesortColumnName == null ? null : WorkflowExpression.Compile(sortTablesortColumnName);
            WorkflowExpression.Validate(__workflow_sortTablesortColumnName, nameof(sortTablesortColumnName), required: true);
            var __workflow_sortTableascending = sortTableascending == null ? null : WorkflowExpression.Compile(sortTableascending);
            WorkflowExpression.Validate(__workflow_sortTableascending, nameof(sortTableascending), required: true);
            var __workflow_sortTablesortColumnName2 = sortTablesortColumnName2 == null ? null : WorkflowExpression.Compile(sortTablesortColumnName2);
            WorkflowExpression.Validate(__workflow_sortTablesortColumnName2, nameof(sortTablesortColumnName2), required: false);
            var __workflow_sortTableascending2 = sortTableascending2 == null ? null : WorkflowExpression.Compile(sortTableascending2);
            WorkflowExpression.Validate(__workflow_sortTableascending2, nameof(sortTableascending2), required: false);
            var __workflow_sortTablesortColumnName3 = sortTablesortColumnName3 == null ? null : WorkflowExpression.Compile(sortTablesortColumnName3);
            WorkflowExpression.Validate(__workflow_sortTablesortColumnName3, nameof(sortTablesortColumnName3), required: false);
            var __workflow_sortTableascending3 = sortTableascending3 == null ? null : WorkflowExpression.Compile(sortTableascending3);
            WorkflowExpression.Validate(__workflow_sortTableascending3, nameof(sortTableascending3), required: false);
            return new DeferredBodyAction<SortTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/SortTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sortTable = new JObject();
                var sortTablepropCount = 0;
                sortTablepropCount++;
                sortTable["InputTable"] = ExpressionConverter.ConvertO(__workflow_sortTableinputTable);
                sortTablepropCount++;
                sortTable["SortColumnName"] = ExpressionConverter.ConvertO(__workflow_sortTablesortColumnName);
                sortTablepropCount++;
                sortTable["Ascending"] = ExpressionConverter.ConvertO(__workflow_sortTableascending);
                if (__workflow_sortTablesortColumnName2 != null)
                {
                    sortTable["SortColumnName2"] = ExpressionConverter.ConvertO(__workflow_sortTablesortColumnName2);
                    sortTablepropCount++;
                }

                if (__workflow_sortTableascending2 != null)
                {
                    if (__workflow_sortTableascending2 != null)
                    {
                        sortTable["Ascending2"] = ExpressionConverter.ConvertO(__workflow_sortTableascending2);
                        sortTablepropCount++;
                    }

                    sortTablepropCount++;
                }
                else
                {
                    sortTable["Ascending2"] = true;
                    sortTablepropCount++;
                }

                if (__workflow_sortTablesortColumnName3 != null)
                {
                    sortTable["SortColumnName3"] = ExpressionConverter.ConvertO(__workflow_sortTablesortColumnName3);
                    sortTablepropCount++;
                }

                if (__workflow_sortTableascending3 != null)
                {
                    if (__workflow_sortTableascending3 != null)
                    {
                        sortTable["Ascending3"] = ExpressionConverter.ConvertO(__workflow_sortTableascending3);
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
        public IBodyWorkflowAction<SortJSONTableResponse> SortJSONTable(Expression<Func<string>> sortJSONTablejSONTable, Expression<Func<string>> sortJSONTablesortColumnName, Expression<Func<bool>> sortJSONTableascending = null, Expression<Func<string>> sortJSONTablesortColumnName2 = null, Expression<Func<bool>> sortJSONTableascending2 = null, Expression<Func<string>> sortJSONTablesortColumnName3 = null, Expression<Func<bool>> sortJSONTableascending3 = null)
        {
            var __workflow_sortJSONTablejSONTable = sortJSONTablejSONTable == null ? null : WorkflowExpression.Compile(sortJSONTablejSONTable);
            WorkflowExpression.Validate(__workflow_sortJSONTablejSONTable, nameof(sortJSONTablejSONTable), required: true);
            var __workflow_sortJSONTablesortColumnName = sortJSONTablesortColumnName == null ? null : WorkflowExpression.Compile(sortJSONTablesortColumnName);
            WorkflowExpression.Validate(__workflow_sortJSONTablesortColumnName, nameof(sortJSONTablesortColumnName), required: true);
            var __workflow_sortJSONTableascending = sortJSONTableascending == null ? null : WorkflowExpression.Compile(sortJSONTableascending);
            WorkflowExpression.Validate(__workflow_sortJSONTableascending, nameof(sortJSONTableascending), required: false);
            var __workflow_sortJSONTablesortColumnName2 = sortJSONTablesortColumnName2 == null ? null : WorkflowExpression.Compile(sortJSONTablesortColumnName2);
            WorkflowExpression.Validate(__workflow_sortJSONTablesortColumnName2, nameof(sortJSONTablesortColumnName2), required: false);
            var __workflow_sortJSONTableascending2 = sortJSONTableascending2 == null ? null : WorkflowExpression.Compile(sortJSONTableascending2);
            WorkflowExpression.Validate(__workflow_sortJSONTableascending2, nameof(sortJSONTableascending2), required: false);
            var __workflow_sortJSONTablesortColumnName3 = sortJSONTablesortColumnName3 == null ? null : WorkflowExpression.Compile(sortJSONTablesortColumnName3);
            WorkflowExpression.Validate(__workflow_sortJSONTablesortColumnName3, nameof(sortJSONTablesortColumnName3), required: false);
            var __workflow_sortJSONTableascending3 = sortJSONTableascending3 == null ? null : WorkflowExpression.Compile(sortJSONTableascending3);
            WorkflowExpression.Validate(__workflow_sortJSONTableascending3, nameof(sortJSONTableascending3), required: false);
            return new DeferredBodyAction<SortJSONTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/SortJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sortJSONTable = new JObject();
                var sortJSONTablepropCount = 0;
                sortJSONTablepropCount++;
                sortJSONTable["JSONTable"] = ExpressionConverter.ConvertO(__workflow_sortJSONTablejSONTable);
                sortJSONTablepropCount++;
                sortJSONTable["SortColumnName"] = ExpressionConverter.ConvertO(__workflow_sortJSONTablesortColumnName);
                if (__workflow_sortJSONTableascending != null)
                {
                    if (__workflow_sortJSONTableascending != null)
                    {
                        sortJSONTable["Ascending"] = ExpressionConverter.ConvertO(__workflow_sortJSONTableascending);
                        sortJSONTablepropCount++;
                    }

                    sortJSONTablepropCount++;
                }
                else
                {
                    sortJSONTable["Ascending"] = true;
                    sortJSONTablepropCount++;
                }

                if (__workflow_sortJSONTablesortColumnName2 != null)
                {
                    sortJSONTable["SortColumnName2"] = ExpressionConverter.ConvertO(__workflow_sortJSONTablesortColumnName2);
                    sortJSONTablepropCount++;
                }

                if (__workflow_sortJSONTableascending2 != null)
                {
                    if (__workflow_sortJSONTableascending2 != null)
                    {
                        sortJSONTable["Ascending2"] = ExpressionConverter.ConvertO(__workflow_sortJSONTableascending2);
                        sortJSONTablepropCount++;
                    }

                    sortJSONTablepropCount++;
                }
                else
                {
                    sortJSONTable["Ascending2"] = true;
                    sortJSONTablepropCount++;
                }

                if (__workflow_sortJSONTablesortColumnName3 != null)
                {
                    sortJSONTable["SortColumnName3"] = ExpressionConverter.ConvertO(__workflow_sortJSONTablesortColumnName3);
                    sortJSONTablepropCount++;
                }

                if (__workflow_sortJSONTableascending3 != null)
                {
                    if (__workflow_sortJSONTableascending3 != null)
                    {
                        sortJSONTable["Ascending3"] = ExpressionConverter.ConvertO(__workflow_sortJSONTableascending3);
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
        public IBodyWorkflowAction<GetTableFromStringArrayResponse> GetTableFromStringArray(Expression<Func<string[]>> getTableFromStringArrayinputArray, Expression<Func<string>> getTableFromStringArraycolumnName, Expression<Func<bool>> getTableFromStringArraydropEmptyItems = null)
        {
            var __workflow_getTableFromStringArrayinputArray = getTableFromStringArrayinputArray == null ? null : WorkflowExpression.Compile(getTableFromStringArrayinputArray);
            WorkflowExpression.Validate(__workflow_getTableFromStringArrayinputArray, nameof(getTableFromStringArrayinputArray), required: true);
            var __workflow_getTableFromStringArraycolumnName = getTableFromStringArraycolumnName == null ? null : WorkflowExpression.Compile(getTableFromStringArraycolumnName);
            WorkflowExpression.Validate(__workflow_getTableFromStringArraycolumnName, nameof(getTableFromStringArraycolumnName), required: true);
            var __workflow_getTableFromStringArraydropEmptyItems = getTableFromStringArraydropEmptyItems == null ? null : WorkflowExpression.Compile(getTableFromStringArraydropEmptyItems);
            WorkflowExpression.Validate(__workflow_getTableFromStringArraydropEmptyItems, nameof(getTableFromStringArraydropEmptyItems), required: false);
            return new DeferredBodyAction<GetTableFromStringArrayResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetTableFromStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getTableFromStringArray = new JObject();
                var getTableFromStringArraypropCount = 0;
                getTableFromStringArraypropCount++;
                getTableFromStringArray["InputArray"] = ExpressionConverter.ConvertO(__workflow_getTableFromStringArrayinputArray);
                getTableFromStringArraypropCount++;
                getTableFromStringArray["ColumnName"] = ExpressionConverter.ConvertO(__workflow_getTableFromStringArraycolumnName);
                if (__workflow_getTableFromStringArraydropEmptyItems != null)
                {
                    if (__workflow_getTableFromStringArraydropEmptyItems != null)
                    {
                        getTableFromStringArray["DropEmptyItems"] = ExpressionConverter.ConvertO(__workflow_getTableFromStringArraydropEmptyItems);
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
        public IBodyWorkflowAction<GetTableFromJSONResponse> GetTableFromJSON(Expression<Func<string>> getTableFromJSONjSONTable, Expression<Func<int>> getTableFromJSONstartRowIndex, Expression<Func<int>> getTableFromJSONnumberOfRowsToRetrieve = null, Expression<Func<int>> getTableFromJSONstartColumnIndex = null, Expression<Func<string>> getTableFromJSONstartColumnName = null, Expression<Func<int>> getTableFromJSONnumberOfColumnsToRetrieve = null)
        {
            var __workflow_getTableFromJSONjSONTable = getTableFromJSONjSONTable == null ? null : WorkflowExpression.Compile(getTableFromJSONjSONTable);
            WorkflowExpression.Validate(__workflow_getTableFromJSONjSONTable, nameof(getTableFromJSONjSONTable), required: true);
            var __workflow_getTableFromJSONstartRowIndex = getTableFromJSONstartRowIndex == null ? null : WorkflowExpression.Compile(getTableFromJSONstartRowIndex);
            WorkflowExpression.Validate(__workflow_getTableFromJSONstartRowIndex, nameof(getTableFromJSONstartRowIndex), required: true);
            var __workflow_getTableFromJSONnumberOfRowsToRetrieve = getTableFromJSONnumberOfRowsToRetrieve == null ? null : WorkflowExpression.Compile(getTableFromJSONnumberOfRowsToRetrieve);
            WorkflowExpression.Validate(__workflow_getTableFromJSONnumberOfRowsToRetrieve, nameof(getTableFromJSONnumberOfRowsToRetrieve), required: false);
            var __workflow_getTableFromJSONstartColumnIndex = getTableFromJSONstartColumnIndex == null ? null : WorkflowExpression.Compile(getTableFromJSONstartColumnIndex);
            WorkflowExpression.Validate(__workflow_getTableFromJSONstartColumnIndex, nameof(getTableFromJSONstartColumnIndex), required: false);
            var __workflow_getTableFromJSONstartColumnName = getTableFromJSONstartColumnName == null ? null : WorkflowExpression.Compile(getTableFromJSONstartColumnName);
            WorkflowExpression.Validate(__workflow_getTableFromJSONstartColumnName, nameof(getTableFromJSONstartColumnName), required: false);
            var __workflow_getTableFromJSONnumberOfColumnsToRetrieve = getTableFromJSONnumberOfColumnsToRetrieve == null ? null : WorkflowExpression.Compile(getTableFromJSONnumberOfColumnsToRetrieve);
            WorkflowExpression.Validate(__workflow_getTableFromJSONnumberOfColumnsToRetrieve, nameof(getTableFromJSONnumberOfColumnsToRetrieve), required: false);
            return new DeferredBodyAction<GetTableFromJSONResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetTableFromJSON";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getTableFromJSON = new JObject();
                var getTableFromJSONpropCount = 0;
                getTableFromJSONpropCount++;
                getTableFromJSON["JSONTable"] = ExpressionConverter.ConvertO(__workflow_getTableFromJSONjSONTable);
                getTableFromJSONpropCount++;
                getTableFromJSON["StartRowIndex"] = ExpressionConverter.ConvertO(__workflow_getTableFromJSONstartRowIndex);
                if (__workflow_getTableFromJSONnumberOfRowsToRetrieve != null)
                {
                    getTableFromJSON["NumberOfRowsToRetrieve"] = ExpressionConverter.ConvertO(__workflow_getTableFromJSONnumberOfRowsToRetrieve);
                    getTableFromJSONpropCount++;
                }

                if (__workflow_getTableFromJSONstartColumnIndex != null)
                {
                    if (__workflow_getTableFromJSONstartColumnIndex != null)
                    {
                        getTableFromJSON["StartColumnIndex"] = ExpressionConverter.ConvertO(__workflow_getTableFromJSONstartColumnIndex);
                        getTableFromJSONpropCount++;
                    }

                    getTableFromJSONpropCount++;
                }
                else
                {
                    getTableFromJSON["StartColumnIndex"] = 1;
                    getTableFromJSONpropCount++;
                }

                if (__workflow_getTableFromJSONstartColumnName != null)
                {
                    getTableFromJSON["StartColumnName"] = ExpressionConverter.ConvertO(__workflow_getTableFromJSONstartColumnName);
                    getTableFromJSONpropCount++;
                }

                if (__workflow_getTableFromJSONnumberOfColumnsToRetrieve != null)
                {
                    getTableFromJSON["NumberOfColumnsToRetrieve"] = ExpressionConverter.ConvertO(__workflow_getTableFromJSONnumberOfColumnsToRetrieve);
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
        public IBodyWorkflowAction<SortStringArrayResponse> SortStringArray(Expression<Func<string[]>> sortStringArrayinputArray, Expression<Func<bool>> sortStringArrayascending = null, Expression<Func<bool>> sortStringArraycaseSensitive = null)
        {
            var __workflow_sortStringArrayinputArray = sortStringArrayinputArray == null ? null : WorkflowExpression.Compile(sortStringArrayinputArray);
            WorkflowExpression.Validate(__workflow_sortStringArrayinputArray, nameof(sortStringArrayinputArray), required: true);
            var __workflow_sortStringArrayascending = sortStringArrayascending == null ? null : WorkflowExpression.Compile(sortStringArrayascending);
            WorkflowExpression.Validate(__workflow_sortStringArrayascending, nameof(sortStringArrayascending), required: false);
            var __workflow_sortStringArraycaseSensitive = sortStringArraycaseSensitive == null ? null : WorkflowExpression.Compile(sortStringArraycaseSensitive);
            WorkflowExpression.Validate(__workflow_sortStringArraycaseSensitive, nameof(sortStringArraycaseSensitive), required: false);
            return new DeferredBodyAction<SortStringArrayResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/SortStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sortStringArray = new JObject();
                var sortStringArraypropCount = 0;
                sortStringArraypropCount++;
                sortStringArray["InputArray"] = ExpressionConverter.ConvertO(__workflow_sortStringArrayinputArray);
                if (__workflow_sortStringArrayascending != null)
                {
                    if (__workflow_sortStringArrayascending != null)
                    {
                        sortStringArray["Ascending"] = ExpressionConverter.ConvertO(__workflow_sortStringArrayascending);
                        sortStringArraypropCount++;
                    }

                    sortStringArraypropCount++;
                }
                else
                {
                    sortStringArray["Ascending"] = true;
                    sortStringArraypropCount++;
                }

                if (__workflow_sortStringArraycaseSensitive != null)
                {
                    if (__workflow_sortStringArraycaseSensitive != null)
                    {
                        sortStringArray["CaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sortStringArraycaseSensitive);
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
        public IBodyWorkflowAction<FilterStringArrayResponse> FilterStringArray(Expression<Func<string[]>> filterStringArrayinputArray, Expression<Func<string>> filterStringArraycolumnName, Expression<Func<string>> filterStringArrayfilter)
        {
            var __workflow_filterStringArrayinputArray = filterStringArrayinputArray == null ? null : WorkflowExpression.Compile(filterStringArrayinputArray);
            WorkflowExpression.Validate(__workflow_filterStringArrayinputArray, nameof(filterStringArrayinputArray), required: true);
            var __workflow_filterStringArraycolumnName = filterStringArraycolumnName == null ? null : WorkflowExpression.Compile(filterStringArraycolumnName);
            WorkflowExpression.Validate(__workflow_filterStringArraycolumnName, nameof(filterStringArraycolumnName), required: true);
            var __workflow_filterStringArrayfilter = filterStringArrayfilter == null ? null : WorkflowExpression.Compile(filterStringArrayfilter);
            WorkflowExpression.Validate(__workflow_filterStringArrayfilter, nameof(filterStringArrayfilter), required: true);
            return new DeferredBodyAction<FilterStringArrayResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/FilterStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var filterStringArray = new JObject();
                var filterStringArraypropCount = 0;
                filterStringArraypropCount++;
                filterStringArray["InputArray"] = ExpressionConverter.ConvertO(__workflow_filterStringArrayinputArray);
                filterStringArraypropCount++;
                filterStringArray["ColumnName"] = ExpressionConverter.ConvertO(__workflow_filterStringArraycolumnName);
                filterStringArraypropCount++;
                filterStringArray["Filter"] = ExpressionConverter.ConvertO(__workflow_filterStringArrayfilter);
                if (filterStringArraypropCount > 0)
                {
                    callPayload.Body = filterStringArray;
                }

                return new ApiConnectionAction<FilterStringArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<InsertRowInStringArrayResponse> InsertRowInStringArray(Expression<Func<string[]>> insertRowInStringArrayinputArray, Expression<Func<int>> insertRowInStringArrayrowIndex, Expression<Func<string>> insertRowInStringArrayvalueToInsert = null)
        {
            var __workflow_insertRowInStringArrayinputArray = insertRowInStringArrayinputArray == null ? null : WorkflowExpression.Compile(insertRowInStringArrayinputArray);
            WorkflowExpression.Validate(__workflow_insertRowInStringArrayinputArray, nameof(insertRowInStringArrayinputArray), required: true);
            var __workflow_insertRowInStringArrayrowIndex = insertRowInStringArrayrowIndex == null ? null : WorkflowExpression.Compile(insertRowInStringArrayrowIndex);
            WorkflowExpression.Validate(__workflow_insertRowInStringArrayrowIndex, nameof(insertRowInStringArrayrowIndex), required: true);
            var __workflow_insertRowInStringArrayvalueToInsert = insertRowInStringArrayvalueToInsert == null ? null : WorkflowExpression.Compile(insertRowInStringArrayvalueToInsert);
            WorkflowExpression.Validate(__workflow_insertRowInStringArrayvalueToInsert, nameof(insertRowInStringArrayvalueToInsert), required: false);
            return new DeferredBodyAction<InsertRowInStringArrayResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/InsertRowInStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var insertRowInStringArray = new JObject();
                var insertRowInStringArraypropCount = 0;
                insertRowInStringArraypropCount++;
                insertRowInStringArray["InputArray"] = ExpressionConverter.ConvertO(__workflow_insertRowInStringArrayinputArray);
                insertRowInStringArraypropCount++;
                insertRowInStringArray["RowIndex"] = ExpressionConverter.ConvertO(__workflow_insertRowInStringArrayrowIndex);
                if (__workflow_insertRowInStringArrayvalueToInsert != null)
                {
                    insertRowInStringArray["ValueToInsert"] = ExpressionConverter.ConvertO(__workflow_insertRowInStringArrayvalueToInsert);
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
        public IBodyWorkflowAction<InsertRowInTableResponse> InsertRowInTable(Expression<Func<JToken[]>> insertRowInTableinputTable, Expression<Func<int>> insertRowInTablerowIndex, Expression<Func<string>> insertRowInTablerowToInsertJSON = null)
        {
            var __workflow_insertRowInTableinputTable = insertRowInTableinputTable == null ? null : WorkflowExpression.Compile(insertRowInTableinputTable);
            WorkflowExpression.Validate(__workflow_insertRowInTableinputTable, nameof(insertRowInTableinputTable), required: true);
            var __workflow_insertRowInTablerowIndex = insertRowInTablerowIndex == null ? null : WorkflowExpression.Compile(insertRowInTablerowIndex);
            WorkflowExpression.Validate(__workflow_insertRowInTablerowIndex, nameof(insertRowInTablerowIndex), required: true);
            var __workflow_insertRowInTablerowToInsertJSON = insertRowInTablerowToInsertJSON == null ? null : WorkflowExpression.Compile(insertRowInTablerowToInsertJSON);
            WorkflowExpression.Validate(__workflow_insertRowInTablerowToInsertJSON, nameof(insertRowInTablerowToInsertJSON), required: false);
            return new DeferredBodyAction<InsertRowInTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/InsertRowInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var insertRowInTable = new JObject();
                var insertRowInTablepropCount = 0;
                insertRowInTablepropCount++;
                insertRowInTable["InputTable"] = ExpressionConverter.ConvertO(__workflow_insertRowInTableinputTable);
                insertRowInTablepropCount++;
                insertRowInTable["RowIndex"] = ExpressionConverter.ConvertO(__workflow_insertRowInTablerowIndex);
                if (__workflow_insertRowInTablerowToInsertJSON != null)
                {
                    insertRowInTable["RowToInsertJSON"] = ExpressionConverter.ConvertO(__workflow_insertRowInTablerowToInsertJSON);
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
        public IBodyWorkflowAction<InsertRowInJSONTableResponse> InsertRowInJSONTable(Expression<Func<string>> insertRowInJSONTablejSONTable, Expression<Func<int>> insertRowInJSONTablerowIndex, Expression<Func<string>> insertRowInJSONTablerowToInsertJSON = null)
        {
            var __workflow_insertRowInJSONTablejSONTable = insertRowInJSONTablejSONTable == null ? null : WorkflowExpression.Compile(insertRowInJSONTablejSONTable);
            WorkflowExpression.Validate(__workflow_insertRowInJSONTablejSONTable, nameof(insertRowInJSONTablejSONTable), required: true);
            var __workflow_insertRowInJSONTablerowIndex = insertRowInJSONTablerowIndex == null ? null : WorkflowExpression.Compile(insertRowInJSONTablerowIndex);
            WorkflowExpression.Validate(__workflow_insertRowInJSONTablerowIndex, nameof(insertRowInJSONTablerowIndex), required: true);
            var __workflow_insertRowInJSONTablerowToInsertJSON = insertRowInJSONTablerowToInsertJSON == null ? null : WorkflowExpression.Compile(insertRowInJSONTablerowToInsertJSON);
            WorkflowExpression.Validate(__workflow_insertRowInJSONTablerowToInsertJSON, nameof(insertRowInJSONTablerowToInsertJSON), required: false);
            return new DeferredBodyAction<InsertRowInJSONTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/InsertRowInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var insertRowInJSONTable = new JObject();
                var insertRowInJSONTablepropCount = 0;
                insertRowInJSONTablepropCount++;
                insertRowInJSONTable["JSONTable"] = ExpressionConverter.ConvertO(__workflow_insertRowInJSONTablejSONTable);
                insertRowInJSONTablepropCount++;
                insertRowInJSONTable["RowIndex"] = ExpressionConverter.ConvertO(__workflow_insertRowInJSONTablerowIndex);
                if (__workflow_insertRowInJSONTablerowToInsertJSON != null)
                {
                    insertRowInJSONTable["RowToInsertJSON"] = ExpressionConverter.ConvertO(__workflow_insertRowInJSONTablerowToInsertJSON);
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
        public IBodyWorkflowAction<InsertRowInJSONTableFromInputVariablesResponse> InsertRowInJSONTableFromInputVariables(Expression<Func<string>> insertRowInJSONTableFromInputVariablesjSONTable, Expression<Func<int>> insertRowInJSONTableFromInputVariablesrowIndex, Expression<Func<insertRowInJSONTableFromInputVariablesrowToInsertInputVariablesInputItem[]>> insertRowInJSONTableFromInputVariablesrowToInsertInputVariables)
        {
            var __workflow_insertRowInJSONTableFromInputVariablesjSONTable = insertRowInJSONTableFromInputVariablesjSONTable == null ? null : WorkflowExpression.Compile(insertRowInJSONTableFromInputVariablesjSONTable);
            WorkflowExpression.Validate(__workflow_insertRowInJSONTableFromInputVariablesjSONTable, nameof(insertRowInJSONTableFromInputVariablesjSONTable), required: true);
            var __workflow_insertRowInJSONTableFromInputVariablesrowIndex = insertRowInJSONTableFromInputVariablesrowIndex == null ? null : WorkflowExpression.Compile(insertRowInJSONTableFromInputVariablesrowIndex);
            WorkflowExpression.Validate(__workflow_insertRowInJSONTableFromInputVariablesrowIndex, nameof(insertRowInJSONTableFromInputVariablesrowIndex), required: true);
            var __workflow_insertRowInJSONTableFromInputVariablesrowToInsertInputVariables = insertRowInJSONTableFromInputVariablesrowToInsertInputVariables == null ? null : WorkflowExpression.Compile(insertRowInJSONTableFromInputVariablesrowToInsertInputVariables);
            WorkflowExpression.Validate(__workflow_insertRowInJSONTableFromInputVariablesrowToInsertInputVariables, nameof(insertRowInJSONTableFromInputVariablesrowToInsertInputVariables), required: true);
            return new DeferredBodyAction<InsertRowInJSONTableFromInputVariablesResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/InsertRowInJSONTableFromInputVariables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var insertRowInJSONTableFromInputVariables = new JObject();
                var insertRowInJSONTableFromInputVariablespropCount = 0;
                insertRowInJSONTableFromInputVariablespropCount++;
                insertRowInJSONTableFromInputVariables["JSONTable"] = ExpressionConverter.ConvertO(__workflow_insertRowInJSONTableFromInputVariablesjSONTable);
                insertRowInJSONTableFromInputVariablespropCount++;
                insertRowInJSONTableFromInputVariables["RowIndex"] = ExpressionConverter.ConvertO(__workflow_insertRowInJSONTableFromInputVariablesrowIndex);
                insertRowInJSONTableFromInputVariablespropCount++;
                insertRowInJSONTableFromInputVariables["RowToInsertInputVariables"] = ExpressionConverter.ConvertO(__workflow_insertRowInJSONTableFromInputVariablesrowToInsertInputVariables);
                if (insertRowInJSONTableFromInputVariablespropCount > 0)
                {
                    callPayload.Body = insertRowInJSONTableFromInputVariables;
                }

                return new ApiConnectionAction<InsertRowInJSONTableFromInputVariablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteItemsInStringArrayResponse> DeleteItemsInStringArray(Expression<Func<string[]>> deleteItemsInStringArrayinputArray, Expression<Func<int>> deleteItemsInStringArraystartItemIndex, Expression<Func<int>> deleteItemsInStringArraynumberOfItemsToDelete)
        {
            var __workflow_deleteItemsInStringArrayinputArray = deleteItemsInStringArrayinputArray == null ? null : WorkflowExpression.Compile(deleteItemsInStringArrayinputArray);
            WorkflowExpression.Validate(__workflow_deleteItemsInStringArrayinputArray, nameof(deleteItemsInStringArrayinputArray), required: true);
            var __workflow_deleteItemsInStringArraystartItemIndex = deleteItemsInStringArraystartItemIndex == null ? null : WorkflowExpression.Compile(deleteItemsInStringArraystartItemIndex);
            WorkflowExpression.Validate(__workflow_deleteItemsInStringArraystartItemIndex, nameof(deleteItemsInStringArraystartItemIndex), required: true);
            var __workflow_deleteItemsInStringArraynumberOfItemsToDelete = deleteItemsInStringArraynumberOfItemsToDelete == null ? null : WorkflowExpression.Compile(deleteItemsInStringArraynumberOfItemsToDelete);
            WorkflowExpression.Validate(__workflow_deleteItemsInStringArraynumberOfItemsToDelete, nameof(deleteItemsInStringArraynumberOfItemsToDelete), required: true);
            return new DeferredBodyAction<DeleteItemsInStringArrayResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteItemsInStringArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteItemsInStringArray = new JObject();
                var deleteItemsInStringArraypropCount = 0;
                deleteItemsInStringArraypropCount++;
                deleteItemsInStringArray["InputArray"] = ExpressionConverter.ConvertO(__workflow_deleteItemsInStringArrayinputArray);
                deleteItemsInStringArraypropCount++;
                deleteItemsInStringArray["StartItemIndex"] = ExpressionConverter.ConvertO(__workflow_deleteItemsInStringArraystartItemIndex);
                deleteItemsInStringArraypropCount++;
                deleteItemsInStringArray["NumberOfItemsToDelete"] = ExpressionConverter.ConvertO(__workflow_deleteItemsInStringArraynumberOfItemsToDelete);
                if (deleteItemsInStringArraypropCount > 0)
                {
                    callPayload.Body = deleteItemsInStringArray;
                }

                return new ApiConnectionAction<DeleteItemsInStringArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteRowsInTableResponse> DeleteRowsInTable(Expression<Func<JToken[]>> deleteRowsInTableinputTable, Expression<Func<int>> deleteRowsInTablestartRowIndex, Expression<Func<int>> deleteRowsInTablenumberOfRowsToDelete)
        {
            var __workflow_deleteRowsInTableinputTable = deleteRowsInTableinputTable == null ? null : WorkflowExpression.Compile(deleteRowsInTableinputTable);
            WorkflowExpression.Validate(__workflow_deleteRowsInTableinputTable, nameof(deleteRowsInTableinputTable), required: true);
            var __workflow_deleteRowsInTablestartRowIndex = deleteRowsInTablestartRowIndex == null ? null : WorkflowExpression.Compile(deleteRowsInTablestartRowIndex);
            WorkflowExpression.Validate(__workflow_deleteRowsInTablestartRowIndex, nameof(deleteRowsInTablestartRowIndex), required: true);
            var __workflow_deleteRowsInTablenumberOfRowsToDelete = deleteRowsInTablenumberOfRowsToDelete == null ? null : WorkflowExpression.Compile(deleteRowsInTablenumberOfRowsToDelete);
            WorkflowExpression.Validate(__workflow_deleteRowsInTablenumberOfRowsToDelete, nameof(deleteRowsInTablenumberOfRowsToDelete), required: true);
            return new DeferredBodyAction<DeleteRowsInTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteRowsInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteRowsInTable = new JObject();
                var deleteRowsInTablepropCount = 0;
                deleteRowsInTablepropCount++;
                deleteRowsInTable["InputTable"] = ExpressionConverter.ConvertO(__workflow_deleteRowsInTableinputTable);
                deleteRowsInTablepropCount++;
                deleteRowsInTable["StartRowIndex"] = ExpressionConverter.ConvertO(__workflow_deleteRowsInTablestartRowIndex);
                deleteRowsInTablepropCount++;
                deleteRowsInTable["NumberOfRowsToDelete"] = ExpressionConverter.ConvertO(__workflow_deleteRowsInTablenumberOfRowsToDelete);
                if (deleteRowsInTablepropCount > 0)
                {
                    callPayload.Body = deleteRowsInTable;
                }

                return new ApiConnectionAction<DeleteRowsInTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteRowsInJSONTableResponse> DeleteRowsInJSONTable(Expression<Func<string>> deleteRowsInJSONTablejSONTable, Expression<Func<int>> deleteRowsInJSONTablestartRowIndex, Expression<Func<int>> deleteRowsInJSONTablenumberOfRowsToDelete)
        {
            var __workflow_deleteRowsInJSONTablejSONTable = deleteRowsInJSONTablejSONTable == null ? null : WorkflowExpression.Compile(deleteRowsInJSONTablejSONTable);
            WorkflowExpression.Validate(__workflow_deleteRowsInJSONTablejSONTable, nameof(deleteRowsInJSONTablejSONTable), required: true);
            var __workflow_deleteRowsInJSONTablestartRowIndex = deleteRowsInJSONTablestartRowIndex == null ? null : WorkflowExpression.Compile(deleteRowsInJSONTablestartRowIndex);
            WorkflowExpression.Validate(__workflow_deleteRowsInJSONTablestartRowIndex, nameof(deleteRowsInJSONTablestartRowIndex), required: true);
            var __workflow_deleteRowsInJSONTablenumberOfRowsToDelete = deleteRowsInJSONTablenumberOfRowsToDelete == null ? null : WorkflowExpression.Compile(deleteRowsInJSONTablenumberOfRowsToDelete);
            WorkflowExpression.Validate(__workflow_deleteRowsInJSONTablenumberOfRowsToDelete, nameof(deleteRowsInJSONTablenumberOfRowsToDelete), required: true);
            return new DeferredBodyAction<DeleteRowsInJSONTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteRowsInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteRowsInJSONTable = new JObject();
                var deleteRowsInJSONTablepropCount = 0;
                deleteRowsInJSONTablepropCount++;
                deleteRowsInJSONTable["JSONTable"] = ExpressionConverter.ConvertO(__workflow_deleteRowsInJSONTablejSONTable);
                deleteRowsInJSONTablepropCount++;
                deleteRowsInJSONTable["StartRowIndex"] = ExpressionConverter.ConvertO(__workflow_deleteRowsInJSONTablestartRowIndex);
                deleteRowsInJSONTablepropCount++;
                deleteRowsInJSONTable["NumberOfRowsToDelete"] = ExpressionConverter.ConvertO(__workflow_deleteRowsInJSONTablenumberOfRowsToDelete);
                if (deleteRowsInJSONTablepropCount > 0)
                {
                    callPayload.Body = deleteRowsInJSONTable;
                }

                return new ApiConnectionAction<DeleteRowsInJSONTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RenameColumnInTableResponse> RenameColumnInTable(Expression<Func<JToken[]>> renameColumnInTableinputTable, Expression<Func<string>> renameColumnInTablesourceColumnName, Expression<Func<string>> renameColumnInTablenewColumnName)
        {
            var __workflow_renameColumnInTableinputTable = renameColumnInTableinputTable == null ? null : WorkflowExpression.Compile(renameColumnInTableinputTable);
            WorkflowExpression.Validate(__workflow_renameColumnInTableinputTable, nameof(renameColumnInTableinputTable), required: true);
            var __workflow_renameColumnInTablesourceColumnName = renameColumnInTablesourceColumnName == null ? null : WorkflowExpression.Compile(renameColumnInTablesourceColumnName);
            WorkflowExpression.Validate(__workflow_renameColumnInTablesourceColumnName, nameof(renameColumnInTablesourceColumnName), required: true);
            var __workflow_renameColumnInTablenewColumnName = renameColumnInTablenewColumnName == null ? null : WorkflowExpression.Compile(renameColumnInTablenewColumnName);
            WorkflowExpression.Validate(__workflow_renameColumnInTablenewColumnName, nameof(renameColumnInTablenewColumnName), required: true);
            return new DeferredBodyAction<RenameColumnInTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/RenameColumnInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var renameColumnInTable = new JObject();
                var renameColumnInTablepropCount = 0;
                renameColumnInTablepropCount++;
                renameColumnInTable["InputTable"] = ExpressionConverter.ConvertO(__workflow_renameColumnInTableinputTable);
                renameColumnInTablepropCount++;
                renameColumnInTable["SourceColumnName"] = ExpressionConverter.ConvertO(__workflow_renameColumnInTablesourceColumnName);
                renameColumnInTablepropCount++;
                renameColumnInTable["NewColumnName"] = ExpressionConverter.ConvertO(__workflow_renameColumnInTablenewColumnName);
                if (renameColumnInTablepropCount > 0)
                {
                    callPayload.Body = renameColumnInTable;
                }

                return new ApiConnectionAction<RenameColumnInTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RenameColumnInJSONTableResponse> RenameColumnInJSONTable(Expression<Func<string>> renameColumnInJSONTablejSONTable, Expression<Func<string>> renameColumnInJSONTablesourceColumnName, Expression<Func<string>> renameColumnInJSONTablenewColumnName)
        {
            var __workflow_renameColumnInJSONTablejSONTable = renameColumnInJSONTablejSONTable == null ? null : WorkflowExpression.Compile(renameColumnInJSONTablejSONTable);
            WorkflowExpression.Validate(__workflow_renameColumnInJSONTablejSONTable, nameof(renameColumnInJSONTablejSONTable), required: true);
            var __workflow_renameColumnInJSONTablesourceColumnName = renameColumnInJSONTablesourceColumnName == null ? null : WorkflowExpression.Compile(renameColumnInJSONTablesourceColumnName);
            WorkflowExpression.Validate(__workflow_renameColumnInJSONTablesourceColumnName, nameof(renameColumnInJSONTablesourceColumnName), required: true);
            var __workflow_renameColumnInJSONTablenewColumnName = renameColumnInJSONTablenewColumnName == null ? null : WorkflowExpression.Compile(renameColumnInJSONTablenewColumnName);
            WorkflowExpression.Validate(__workflow_renameColumnInJSONTablenewColumnName, nameof(renameColumnInJSONTablenewColumnName), required: true);
            return new DeferredBodyAction<RenameColumnInJSONTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/RenameColumnInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var renameColumnInJSONTable = new JObject();
                var renameColumnInJSONTablepropCount = 0;
                renameColumnInJSONTablepropCount++;
                renameColumnInJSONTable["JSONTable"] = ExpressionConverter.ConvertO(__workflow_renameColumnInJSONTablejSONTable);
                renameColumnInJSONTablepropCount++;
                renameColumnInJSONTable["SourceColumnName"] = ExpressionConverter.ConvertO(__workflow_renameColumnInJSONTablesourceColumnName);
                renameColumnInJSONTablepropCount++;
                renameColumnInJSONTable["NewColumnName"] = ExpressionConverter.ConvertO(__workflow_renameColumnInJSONTablenewColumnName);
                if (renameColumnInJSONTablepropCount > 0)
                {
                    callPayload.Body = renameColumnInJSONTable;
                }

                return new ApiConnectionAction<RenameColumnInJSONTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteColumnsInTableResponse> DeleteColumnsInTable(Expression<Func<JToken[]>> deleteColumnsInTableinputTable, Expression<Func<int>> deleteColumnsInTablenumberOfColumnsToDelete, Expression<Func<int>> deleteColumnsInTablestartColumnIndex = null, Expression<Func<string>> deleteColumnsInTablecolumnNameToDelete = null)
        {
            var __workflow_deleteColumnsInTableinputTable = deleteColumnsInTableinputTable == null ? null : WorkflowExpression.Compile(deleteColumnsInTableinputTable);
            WorkflowExpression.Validate(__workflow_deleteColumnsInTableinputTable, nameof(deleteColumnsInTableinputTable), required: true);
            var __workflow_deleteColumnsInTablenumberOfColumnsToDelete = deleteColumnsInTablenumberOfColumnsToDelete == null ? null : WorkflowExpression.Compile(deleteColumnsInTablenumberOfColumnsToDelete);
            WorkflowExpression.Validate(__workflow_deleteColumnsInTablenumberOfColumnsToDelete, nameof(deleteColumnsInTablenumberOfColumnsToDelete), required: true);
            var __workflow_deleteColumnsInTablestartColumnIndex = deleteColumnsInTablestartColumnIndex == null ? null : WorkflowExpression.Compile(deleteColumnsInTablestartColumnIndex);
            WorkflowExpression.Validate(__workflow_deleteColumnsInTablestartColumnIndex, nameof(deleteColumnsInTablestartColumnIndex), required: false);
            var __workflow_deleteColumnsInTablecolumnNameToDelete = deleteColumnsInTablecolumnNameToDelete == null ? null : WorkflowExpression.Compile(deleteColumnsInTablecolumnNameToDelete);
            WorkflowExpression.Validate(__workflow_deleteColumnsInTablecolumnNameToDelete, nameof(deleteColumnsInTablecolumnNameToDelete), required: false);
            return new DeferredBodyAction<DeleteColumnsInTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteColumnsInTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteColumnsInTable = new JObject();
                var deleteColumnsInTablepropCount = 0;
                deleteColumnsInTablepropCount++;
                deleteColumnsInTable["InputTable"] = ExpressionConverter.ConvertO(__workflow_deleteColumnsInTableinputTable);
                if (__workflow_deleteColumnsInTablestartColumnIndex != null)
                {
                    deleteColumnsInTable["StartColumnIndex"] = ExpressionConverter.ConvertO(__workflow_deleteColumnsInTablestartColumnIndex);
                    deleteColumnsInTablepropCount++;
                }

                if (__workflow_deleteColumnsInTablecolumnNameToDelete != null)
                {
                    deleteColumnsInTable["ColumnNameToDelete"] = ExpressionConverter.ConvertO(__workflow_deleteColumnsInTablecolumnNameToDelete);
                    deleteColumnsInTablepropCount++;
                }

                deleteColumnsInTablepropCount++;
                deleteColumnsInTable["NumberOfColumnsToDelete"] = ExpressionConverter.ConvertO(__workflow_deleteColumnsInTablenumberOfColumnsToDelete);
                if (deleteColumnsInTablepropCount > 0)
                {
                    callPayload.Body = deleteColumnsInTable;
                }

                return new ApiConnectionAction<DeleteColumnsInTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<DeleteColumnsInJSONTableResponse> DeleteColumnsInJSONTable(Expression<Func<string>> deleteColumnsInJSONTablejSONTable, Expression<Func<int>> deleteColumnsInJSONTablenumberOfColumnsToDelete, Expression<Func<int>> deleteColumnsInJSONTablestartColumnIndex = null, Expression<Func<string>> deleteColumnsInJSONTablecolumnNameToDelete = null)
        {
            var __workflow_deleteColumnsInJSONTablejSONTable = deleteColumnsInJSONTablejSONTable == null ? null : WorkflowExpression.Compile(deleteColumnsInJSONTablejSONTable);
            WorkflowExpression.Validate(__workflow_deleteColumnsInJSONTablejSONTable, nameof(deleteColumnsInJSONTablejSONTable), required: true);
            var __workflow_deleteColumnsInJSONTablenumberOfColumnsToDelete = deleteColumnsInJSONTablenumberOfColumnsToDelete == null ? null : WorkflowExpression.Compile(deleteColumnsInJSONTablenumberOfColumnsToDelete);
            WorkflowExpression.Validate(__workflow_deleteColumnsInJSONTablenumberOfColumnsToDelete, nameof(deleteColumnsInJSONTablenumberOfColumnsToDelete), required: true);
            var __workflow_deleteColumnsInJSONTablestartColumnIndex = deleteColumnsInJSONTablestartColumnIndex == null ? null : WorkflowExpression.Compile(deleteColumnsInJSONTablestartColumnIndex);
            WorkflowExpression.Validate(__workflow_deleteColumnsInJSONTablestartColumnIndex, nameof(deleteColumnsInJSONTablestartColumnIndex), required: false);
            var __workflow_deleteColumnsInJSONTablecolumnNameToDelete = deleteColumnsInJSONTablecolumnNameToDelete == null ? null : WorkflowExpression.Compile(deleteColumnsInJSONTablecolumnNameToDelete);
            WorkflowExpression.Validate(__workflow_deleteColumnsInJSONTablecolumnNameToDelete, nameof(deleteColumnsInJSONTablecolumnNameToDelete), required: false);
            return new DeferredBodyAction<DeleteColumnsInJSONTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/DeleteColumnsInJSONTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteColumnsInJSONTable = new JObject();
                var deleteColumnsInJSONTablepropCount = 0;
                deleteColumnsInJSONTablepropCount++;
                deleteColumnsInJSONTable["JSONTable"] = ExpressionConverter.ConvertO(__workflow_deleteColumnsInJSONTablejSONTable);
                if (__workflow_deleteColumnsInJSONTablestartColumnIndex != null)
                {
                    deleteColumnsInJSONTable["StartColumnIndex"] = ExpressionConverter.ConvertO(__workflow_deleteColumnsInJSONTablestartColumnIndex);
                    deleteColumnsInJSONTablepropCount++;
                }

                if (__workflow_deleteColumnsInJSONTablecolumnNameToDelete != null)
                {
                    deleteColumnsInJSONTable["ColumnNameToDelete"] = ExpressionConverter.ConvertO(__workflow_deleteColumnsInJSONTablecolumnNameToDelete);
                    deleteColumnsInJSONTablepropCount++;
                }

                deleteColumnsInJSONTablepropCount++;
                deleteColumnsInJSONTable["NumberOfColumnsToDelete"] = ExpressionConverter.ConvertO(__workflow_deleteColumnsInJSONTablenumberOfColumnsToDelete);
                if (deleteColumnsInJSONTablepropCount > 0)
                {
                    callPayload.Body = deleteColumnsInJSONTable;
                }

                return new ApiConnectionAction<DeleteColumnsInJSONTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetStringArrayFromTableColumnResponse> GetStringArrayFromTableColumn(Expression<Func<JToken[]>> getStringArrayFromTableColumninputTable, Expression<Func<int>> getStringArrayFromTableColumncolumnIndex = null, Expression<Func<string>> getStringArrayFromTableColumncolumnName = null)
        {
            var __workflow_getStringArrayFromTableColumninputTable = getStringArrayFromTableColumninputTable == null ? null : WorkflowExpression.Compile(getStringArrayFromTableColumninputTable);
            WorkflowExpression.Validate(__workflow_getStringArrayFromTableColumninputTable, nameof(getStringArrayFromTableColumninputTable), required: true);
            var __workflow_getStringArrayFromTableColumncolumnIndex = getStringArrayFromTableColumncolumnIndex == null ? null : WorkflowExpression.Compile(getStringArrayFromTableColumncolumnIndex);
            WorkflowExpression.Validate(__workflow_getStringArrayFromTableColumncolumnIndex, nameof(getStringArrayFromTableColumncolumnIndex), required: false);
            var __workflow_getStringArrayFromTableColumncolumnName = getStringArrayFromTableColumncolumnName == null ? null : WorkflowExpression.Compile(getStringArrayFromTableColumncolumnName);
            WorkflowExpression.Validate(__workflow_getStringArrayFromTableColumncolumnName, nameof(getStringArrayFromTableColumncolumnName), required: false);
            return new DeferredBodyAction<GetStringArrayFromTableColumnResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetStringArrayFromTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getStringArrayFromTableColumn = new JObject();
                var getStringArrayFromTableColumnpropCount = 0;
                getStringArrayFromTableColumnpropCount++;
                getStringArrayFromTableColumn["InputTable"] = ExpressionConverter.ConvertO(__workflow_getStringArrayFromTableColumninputTable);
                if (__workflow_getStringArrayFromTableColumncolumnIndex != null)
                {
                    getStringArrayFromTableColumn["ColumnIndex"] = ExpressionConverter.ConvertO(__workflow_getStringArrayFromTableColumncolumnIndex);
                    getStringArrayFromTableColumnpropCount++;
                }

                if (__workflow_getStringArrayFromTableColumncolumnName != null)
                {
                    getStringArrayFromTableColumn["ColumnName"] = ExpressionConverter.ConvertO(__workflow_getStringArrayFromTableColumncolumnName);
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
        public IBodyWorkflowAction<GetStringArrayFromJSONTableColumnResponse> GetStringArrayFromJSONTableColumn(Expression<Func<string>> getStringArrayFromJSONTableColumnjSONTable, Expression<Func<int>> getStringArrayFromJSONTableColumncolumnIndex = null, Expression<Func<string>> getStringArrayFromJSONTableColumncolumnName = null)
        {
            var __workflow_getStringArrayFromJSONTableColumnjSONTable = getStringArrayFromJSONTableColumnjSONTable == null ? null : WorkflowExpression.Compile(getStringArrayFromJSONTableColumnjSONTable);
            WorkflowExpression.Validate(__workflow_getStringArrayFromJSONTableColumnjSONTable, nameof(getStringArrayFromJSONTableColumnjSONTable), required: true);
            var __workflow_getStringArrayFromJSONTableColumncolumnIndex = getStringArrayFromJSONTableColumncolumnIndex == null ? null : WorkflowExpression.Compile(getStringArrayFromJSONTableColumncolumnIndex);
            WorkflowExpression.Validate(__workflow_getStringArrayFromJSONTableColumncolumnIndex, nameof(getStringArrayFromJSONTableColumncolumnIndex), required: false);
            var __workflow_getStringArrayFromJSONTableColumncolumnName = getStringArrayFromJSONTableColumncolumnName == null ? null : WorkflowExpression.Compile(getStringArrayFromJSONTableColumncolumnName);
            WorkflowExpression.Validate(__workflow_getStringArrayFromJSONTableColumncolumnName, nameof(getStringArrayFromJSONTableColumncolumnName), required: false);
            return new DeferredBodyAction<GetStringArrayFromJSONTableColumnResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetStringArrayFromJSONTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getStringArrayFromJSONTableColumn = new JObject();
                var getStringArrayFromJSONTableColumnpropCount = 0;
                getStringArrayFromJSONTableColumnpropCount++;
                getStringArrayFromJSONTableColumn["JSONTable"] = ExpressionConverter.ConvertO(__workflow_getStringArrayFromJSONTableColumnjSONTable);
                if (__workflow_getStringArrayFromJSONTableColumncolumnIndex != null)
                {
                    getStringArrayFromJSONTableColumn["ColumnIndex"] = ExpressionConverter.ConvertO(__workflow_getStringArrayFromJSONTableColumncolumnIndex);
                    getStringArrayFromJSONTableColumnpropCount++;
                }

                if (__workflow_getStringArrayFromJSONTableColumncolumnName != null)
                {
                    getStringArrayFromJSONTableColumn["ColumnName"] = ExpressionConverter.ConvertO(__workflow_getStringArrayFromJSONTableColumncolumnName);
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
        public IBodyWorkflowAction<GetStringFromJSONTableCellResponse> GetStringFromJSONTableCell(Expression<Func<string>> getStringFromJSONTableCelljSONTable, Expression<Func<int>> getStringFromJSONTableCellrowIndex = null, Expression<Func<int>> getStringFromJSONTableCellcolumnIndex = null, Expression<Func<string>> getStringFromJSONTableCellcolumnName = null, Expression<Func<bool>> getStringFromJSONTableCellfallBackIfCellDoesNotExist = null, Expression<Func<string>> getStringFromJSONTableCellfallbackValue = null)
        {
            var __workflow_getStringFromJSONTableCelljSONTable = getStringFromJSONTableCelljSONTable == null ? null : WorkflowExpression.Compile(getStringFromJSONTableCelljSONTable);
            WorkflowExpression.Validate(__workflow_getStringFromJSONTableCelljSONTable, nameof(getStringFromJSONTableCelljSONTable), required: true);
            var __workflow_getStringFromJSONTableCellrowIndex = getStringFromJSONTableCellrowIndex == null ? null : WorkflowExpression.Compile(getStringFromJSONTableCellrowIndex);
            WorkflowExpression.Validate(__workflow_getStringFromJSONTableCellrowIndex, nameof(getStringFromJSONTableCellrowIndex), required: false);
            var __workflow_getStringFromJSONTableCellcolumnIndex = getStringFromJSONTableCellcolumnIndex == null ? null : WorkflowExpression.Compile(getStringFromJSONTableCellcolumnIndex);
            WorkflowExpression.Validate(__workflow_getStringFromJSONTableCellcolumnIndex, nameof(getStringFromJSONTableCellcolumnIndex), required: false);
            var __workflow_getStringFromJSONTableCellcolumnName = getStringFromJSONTableCellcolumnName == null ? null : WorkflowExpression.Compile(getStringFromJSONTableCellcolumnName);
            WorkflowExpression.Validate(__workflow_getStringFromJSONTableCellcolumnName, nameof(getStringFromJSONTableCellcolumnName), required: false);
            var __workflow_getStringFromJSONTableCellfallBackIfCellDoesNotExist = getStringFromJSONTableCellfallBackIfCellDoesNotExist == null ? null : WorkflowExpression.Compile(getStringFromJSONTableCellfallBackIfCellDoesNotExist);
            WorkflowExpression.Validate(__workflow_getStringFromJSONTableCellfallBackIfCellDoesNotExist, nameof(getStringFromJSONTableCellfallBackIfCellDoesNotExist), required: false);
            var __workflow_getStringFromJSONTableCellfallbackValue = getStringFromJSONTableCellfallbackValue == null ? null : WorkflowExpression.Compile(getStringFromJSONTableCellfallbackValue);
            WorkflowExpression.Validate(__workflow_getStringFromJSONTableCellfallbackValue, nameof(getStringFromJSONTableCellfallbackValue), required: false);
            return new DeferredBodyAction<GetStringFromJSONTableCellResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetStringFromJSONTableCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getStringFromJSONTableCell = new JObject();
                var getStringFromJSONTableCellpropCount = 0;
                getStringFromJSONTableCellpropCount++;
                getStringFromJSONTableCell["JSONTable"] = ExpressionConverter.ConvertO(__workflow_getStringFromJSONTableCelljSONTable);
                if (__workflow_getStringFromJSONTableCellrowIndex != null)
                {
                    getStringFromJSONTableCell["RowIndex"] = ExpressionConverter.ConvertO(__workflow_getStringFromJSONTableCellrowIndex);
                    getStringFromJSONTableCellpropCount++;
                }

                if (__workflow_getStringFromJSONTableCellcolumnIndex != null)
                {
                    getStringFromJSONTableCell["ColumnIndex"] = ExpressionConverter.ConvertO(__workflow_getStringFromJSONTableCellcolumnIndex);
                    getStringFromJSONTableCellpropCount++;
                }

                if (__workflow_getStringFromJSONTableCellcolumnName != null)
                {
                    getStringFromJSONTableCell["ColumnName"] = ExpressionConverter.ConvertO(__workflow_getStringFromJSONTableCellcolumnName);
                    getStringFromJSONTableCellpropCount++;
                }

                if (__workflow_getStringFromJSONTableCellfallBackIfCellDoesNotExist != null)
                {
                    if (__workflow_getStringFromJSONTableCellfallBackIfCellDoesNotExist != null)
                    {
                        getStringFromJSONTableCell["FallBackIfCellDoesNotExist"] = ExpressionConverter.ConvertO(__workflow_getStringFromJSONTableCellfallBackIfCellDoesNotExist);
                        getStringFromJSONTableCellpropCount++;
                    }

                    getStringFromJSONTableCellpropCount++;
                }
                else
                {
                    getStringFromJSONTableCell["FallBackIfCellDoesNotExist"] = false;
                    getStringFromJSONTableCellpropCount++;
                }

                if (__workflow_getStringFromJSONTableCellfallbackValue != null)
                {
                    getStringFromJSONTableCell["FallbackValue"] = ExpressionConverter.ConvertO(__workflow_getStringFromJSONTableCellfallbackValue);
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
        public IBodyWorkflowAction<GetStringBetweenResponse> GetStringBetween(Expression<Func<string>> getStringBetweeninputString = null, Expression<Func<string>> getStringBetweenstartSearchString = null, Expression<Func<string>> getStringBetweenendSearchString = null, Expression<Func<bool>> getStringBetweensearchLineByLine = null, Expression<Func<bool>> getStringBetweenthrowExceptionIfNotFound = null, Expression<Func<bool>> getStringBetweentrimResult = null, Expression<Func<bool>> getStringBetweensearchIsRegularExpression = null, Expression<Func<bool>> getStringBetweencaseSensitiveSearch = null)
        {
            var __workflow_getStringBetweeninputString = getStringBetweeninputString == null ? null : WorkflowExpression.Compile(getStringBetweeninputString);
            WorkflowExpression.Validate(__workflow_getStringBetweeninputString, nameof(getStringBetweeninputString), required: false);
            var __workflow_getStringBetweenstartSearchString = getStringBetweenstartSearchString == null ? null : WorkflowExpression.Compile(getStringBetweenstartSearchString);
            WorkflowExpression.Validate(__workflow_getStringBetweenstartSearchString, nameof(getStringBetweenstartSearchString), required: false);
            var __workflow_getStringBetweenendSearchString = getStringBetweenendSearchString == null ? null : WorkflowExpression.Compile(getStringBetweenendSearchString);
            WorkflowExpression.Validate(__workflow_getStringBetweenendSearchString, nameof(getStringBetweenendSearchString), required: false);
            var __workflow_getStringBetweensearchLineByLine = getStringBetweensearchLineByLine == null ? null : WorkflowExpression.Compile(getStringBetweensearchLineByLine);
            WorkflowExpression.Validate(__workflow_getStringBetweensearchLineByLine, nameof(getStringBetweensearchLineByLine), required: false);
            var __workflow_getStringBetweenthrowExceptionIfNotFound = getStringBetweenthrowExceptionIfNotFound == null ? null : WorkflowExpression.Compile(getStringBetweenthrowExceptionIfNotFound);
            WorkflowExpression.Validate(__workflow_getStringBetweenthrowExceptionIfNotFound, nameof(getStringBetweenthrowExceptionIfNotFound), required: false);
            var __workflow_getStringBetweentrimResult = getStringBetweentrimResult == null ? null : WorkflowExpression.Compile(getStringBetweentrimResult);
            WorkflowExpression.Validate(__workflow_getStringBetweentrimResult, nameof(getStringBetweentrimResult), required: false);
            var __workflow_getStringBetweensearchIsRegularExpression = getStringBetweensearchIsRegularExpression == null ? null : WorkflowExpression.Compile(getStringBetweensearchIsRegularExpression);
            WorkflowExpression.Validate(__workflow_getStringBetweensearchIsRegularExpression, nameof(getStringBetweensearchIsRegularExpression), required: false);
            var __workflow_getStringBetweencaseSensitiveSearch = getStringBetweencaseSensitiveSearch == null ? null : WorkflowExpression.Compile(getStringBetweencaseSensitiveSearch);
            WorkflowExpression.Validate(__workflow_getStringBetweencaseSensitiveSearch, nameof(getStringBetweencaseSensitiveSearch), required: false);
            return new DeferredBodyAction<GetStringBetweenResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetStringBetween";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getStringBetween = new JObject();
                var getStringBetweenpropCount = 0;
                if (__workflow_getStringBetweeninputString != null)
                {
                    getStringBetween["InputString"] = ExpressionConverter.ConvertO(__workflow_getStringBetweeninputString);
                    getStringBetweenpropCount++;
                }

                if (__workflow_getStringBetweenstartSearchString != null)
                {
                    getStringBetween["StartSearchString"] = ExpressionConverter.ConvertO(__workflow_getStringBetweenstartSearchString);
                    getStringBetweenpropCount++;
                }

                if (__workflow_getStringBetweenendSearchString != null)
                {
                    getStringBetween["EndSearchString"] = ExpressionConverter.ConvertO(__workflow_getStringBetweenendSearchString);
                    getStringBetweenpropCount++;
                }

                if (__workflow_getStringBetweensearchLineByLine != null)
                {
                    if (__workflow_getStringBetweensearchLineByLine != null)
                    {
                        getStringBetween["SearchLineByLine"] = ExpressionConverter.ConvertO(__workflow_getStringBetweensearchLineByLine);
                        getStringBetweenpropCount++;
                    }

                    getStringBetweenpropCount++;
                }
                else
                {
                    getStringBetween["SearchLineByLine"] = true;
                    getStringBetweenpropCount++;
                }

                if (__workflow_getStringBetweenthrowExceptionIfNotFound != null)
                {
                    if (__workflow_getStringBetweenthrowExceptionIfNotFound != null)
                    {
                        getStringBetween["ThrowExceptionIfNotFound"] = ExpressionConverter.ConvertO(__workflow_getStringBetweenthrowExceptionIfNotFound);
                        getStringBetweenpropCount++;
                    }

                    getStringBetweenpropCount++;
                }
                else
                {
                    getStringBetween["ThrowExceptionIfNotFound"] = true;
                    getStringBetweenpropCount++;
                }

                if (__workflow_getStringBetweentrimResult != null)
                {
                    if (__workflow_getStringBetweentrimResult != null)
                    {
                        getStringBetween["TrimResult"] = ExpressionConverter.ConvertO(__workflow_getStringBetweentrimResult);
                        getStringBetweenpropCount++;
                    }

                    getStringBetweenpropCount++;
                }
                else
                {
                    getStringBetween["TrimResult"] = true;
                    getStringBetweenpropCount++;
                }

                if (__workflow_getStringBetweensearchIsRegularExpression != null)
                {
                    if (__workflow_getStringBetweensearchIsRegularExpression != null)
                    {
                        getStringBetween["SearchIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_getStringBetweensearchIsRegularExpression);
                        getStringBetweenpropCount++;
                    }

                    getStringBetweenpropCount++;
                }
                else
                {
                    getStringBetween["SearchIsRegularExpression"] = false;
                    getStringBetweenpropCount++;
                }

                if (__workflow_getStringBetweencaseSensitiveSearch != null)
                {
                    if (__workflow_getStringBetweencaseSensitiveSearch != null)
                    {
                        getStringBetween["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_getStringBetweencaseSensitiveSearch);
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
        public IBodyWorkflowAction<LoadIAConnectLookupTableResponse> LoadIAConnectLookupTable(Expression<Func<string>> loadIAConnectLookupTablepath, Expression<Func<bool>> loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad, Expression<Func<string>> loadIAConnectLookupTableworkflow)
        {
            var __workflow_loadIAConnectLookupTablepath = loadIAConnectLookupTablepath == null ? null : WorkflowExpression.Compile(loadIAConnectLookupTablepath);
            WorkflowExpression.Validate(__workflow_loadIAConnectLookupTablepath, nameof(loadIAConnectLookupTablepath), required: true);
            var __workflow_loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad = loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad == null ? null : WorkflowExpression.Compile(loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad);
            WorkflowExpression.Validate(__workflow_loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad, nameof(loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad), required: true);
            var __workflow_loadIAConnectLookupTableworkflow = loadIAConnectLookupTableworkflow == null ? null : WorkflowExpression.Compile(loadIAConnectLookupTableworkflow);
            WorkflowExpression.Validate(__workflow_loadIAConnectLookupTableworkflow, nameof(loadIAConnectLookupTableworkflow), required: true);
            return new DeferredBodyAction<LoadIAConnectLookupTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/LoadIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var loadIAConnectLookupTable = new JObject();
                var loadIAConnectLookupTablepropCount = 0;
                loadIAConnectLookupTablepropCount++;
                loadIAConnectLookupTable["Path"] = ExpressionConverter.ConvertO(__workflow_loadIAConnectLookupTablepath);
                loadIAConnectLookupTablepropCount++;
                loadIAConnectLookupTable["RaiseExceptionIfAnyTableFailsToLoad"] = ExpressionConverter.ConvertO(__workflow_loadIAConnectLookupTableraiseExceptionIfAnyTableFailsToLoad);
                loadIAConnectLookupTablepropCount++;
                loadIAConnectLookupTable["Workflow"] = ExpressionConverter.ConvertO(__workflow_loadIAConnectLookupTableworkflow);
                if (loadIAConnectLookupTablepropCount > 0)
                {
                    callPayload.Body = loadIAConnectLookupTable;
                }

                return new ApiConnectionAction<LoadIAConnectLookupTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<GetIAConnectLookupTableSummaryResponse> GetIAConnectLookupTableSummary(Expression<Func<string>> getIAConnectLookupTableSummaryworkflow)
        {
            var __workflow_getIAConnectLookupTableSummaryworkflow = getIAConnectLookupTableSummaryworkflow == null ? null : WorkflowExpression.Compile(getIAConnectLookupTableSummaryworkflow);
            WorkflowExpression.Validate(__workflow_getIAConnectLookupTableSummaryworkflow, nameof(getIAConnectLookupTableSummaryworkflow), required: true);
            return new DeferredBodyAction<GetIAConnectLookupTableSummaryResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetIAConnectLookupTableSummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectLookupTableSummary = new JObject();
                var getIAConnectLookupTableSummarypropCount = 0;
                getIAConnectLookupTableSummarypropCount++;
                getIAConnectLookupTableSummary["Workflow"] = ExpressionConverter.ConvertO(__workflow_getIAConnectLookupTableSummaryworkflow);
                if (getIAConnectLookupTableSummarypropCount > 0)
                {
                    callPayload.Body = getIAConnectLookupTableSummary;
                }

                return new ApiConnectionAction<GetIAConnectLookupTableSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveIAConnectLookupTableResponse> RemoveIAConnectLookupTable(Expression<Func<string>> removeIAConnectLookupTablelookupTableName, Expression<Func<string>> removeIAConnectLookupTableworkflow)
        {
            var __workflow_removeIAConnectLookupTablelookupTableName = removeIAConnectLookupTablelookupTableName == null ? null : WorkflowExpression.Compile(removeIAConnectLookupTablelookupTableName);
            WorkflowExpression.Validate(__workflow_removeIAConnectLookupTablelookupTableName, nameof(removeIAConnectLookupTablelookupTableName), required: true);
            var __workflow_removeIAConnectLookupTableworkflow = removeIAConnectLookupTableworkflow == null ? null : WorkflowExpression.Compile(removeIAConnectLookupTableworkflow);
            WorkflowExpression.Validate(__workflow_removeIAConnectLookupTableworkflow, nameof(removeIAConnectLookupTableworkflow), required: true);
            return new DeferredBodyAction<RemoveIAConnectLookupTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/RemoveIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var removeIAConnectLookupTable = new JObject();
                var removeIAConnectLookupTablepropCount = 0;
                removeIAConnectLookupTablepropCount++;
                removeIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(__workflow_removeIAConnectLookupTablelookupTableName);
                removeIAConnectLookupTablepropCount++;
                removeIAConnectLookupTable["Workflow"] = ExpressionConverter.ConvertO(__workflow_removeIAConnectLookupTableworkflow);
                if (removeIAConnectLookupTablepropCount > 0)
                {
                    callPayload.Body = removeIAConnectLookupTable;
                }

                return new ApiConnectionAction<RemoveIAConnectLookupTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveAllIAConnectLookupTablesResponse> RemoveAllIAConnectLookupTables(Expression<Func<string>> removeAllIAConnectLookupTablesworkflow)
        {
            var __workflow_removeAllIAConnectLookupTablesworkflow = removeAllIAConnectLookupTablesworkflow == null ? null : WorkflowExpression.Compile(removeAllIAConnectLookupTablesworkflow);
            WorkflowExpression.Validate(__workflow_removeAllIAConnectLookupTablesworkflow, nameof(removeAllIAConnectLookupTablesworkflow), required: true);
            return new DeferredBodyAction<RemoveAllIAConnectLookupTablesResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/RemoveAllIAConnectLookupTables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var removeAllIAConnectLookupTables = new JObject();
                var removeAllIAConnectLookupTablespropCount = 0;
                removeAllIAConnectLookupTablespropCount++;
                removeAllIAConnectLookupTables["Workflow"] = ExpressionConverter.ConvertO(__workflow_removeAllIAConnectLookupTablesworkflow);
                if (removeAllIAConnectLookupTablespropCount > 0)
                {
                    callPayload.Body = removeAllIAConnectLookupTables;
                }

                return new ApiConnectionAction<RemoveAllIAConnectLookupTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LookupValueFromIAConnectLookupTableResponse> LookupValueFromIAConnectLookupTable(Expression<Func<string>> lookupValueFromIAConnectLookupTablelookupTableName, Expression<Func<string>> lookupValueFromIAConnectLookupTablesearchResultValueColumnName, Expression<Func<string>> lookupValueFromIAConnectLookupTableworkflow, Expression<Func<string>> lookupValueFromIAConnectLookupTableinputDataJSON = null, Expression<Func<int>> lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex = null, Expression<Func<bool>> lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch = null)
        {
            var __workflow_lookupValueFromIAConnectLookupTablelookupTableName = lookupValueFromIAConnectLookupTablelookupTableName == null ? null : WorkflowExpression.Compile(lookupValueFromIAConnectLookupTablelookupTableName);
            WorkflowExpression.Validate(__workflow_lookupValueFromIAConnectLookupTablelookupTableName, nameof(lookupValueFromIAConnectLookupTablelookupTableName), required: true);
            var __workflow_lookupValueFromIAConnectLookupTablesearchResultValueColumnName = lookupValueFromIAConnectLookupTablesearchResultValueColumnName == null ? null : WorkflowExpression.Compile(lookupValueFromIAConnectLookupTablesearchResultValueColumnName);
            WorkflowExpression.Validate(__workflow_lookupValueFromIAConnectLookupTablesearchResultValueColumnName, nameof(lookupValueFromIAConnectLookupTablesearchResultValueColumnName), required: true);
            var __workflow_lookupValueFromIAConnectLookupTableworkflow = lookupValueFromIAConnectLookupTableworkflow == null ? null : WorkflowExpression.Compile(lookupValueFromIAConnectLookupTableworkflow);
            WorkflowExpression.Validate(__workflow_lookupValueFromIAConnectLookupTableworkflow, nameof(lookupValueFromIAConnectLookupTableworkflow), required: true);
            var __workflow_lookupValueFromIAConnectLookupTableinputDataJSON = lookupValueFromIAConnectLookupTableinputDataJSON == null ? null : WorkflowExpression.Compile(lookupValueFromIAConnectLookupTableinputDataJSON);
            WorkflowExpression.Validate(__workflow_lookupValueFromIAConnectLookupTableinputDataJSON, nameof(lookupValueFromIAConnectLookupTableinputDataJSON), required: false);
            var __workflow_lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex = lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex == null ? null : WorkflowExpression.Compile(lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex);
            WorkflowExpression.Validate(__workflow_lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex, nameof(lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex), required: false);
            var __workflow_lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch = lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch == null ? null : WorkflowExpression.Compile(lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch);
            WorkflowExpression.Validate(__workflow_lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch, nameof(lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch), required: false);
            return new DeferredBodyAction<LookupValueFromIAConnectLookupTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/LookupValueFromIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lookupValueFromIAConnectLookupTable = new JObject();
                var lookupValueFromIAConnectLookupTablepropCount = 0;
                lookupValueFromIAConnectLookupTablepropCount++;
                lookupValueFromIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(__workflow_lookupValueFromIAConnectLookupTablelookupTableName);
                if (__workflow_lookupValueFromIAConnectLookupTableinputDataJSON != null)
                {
                    lookupValueFromIAConnectLookupTable["InputDataJSON"] = ExpressionConverter.ConvertO(__workflow_lookupValueFromIAConnectLookupTableinputDataJSON);
                    lookupValueFromIAConnectLookupTablepropCount++;
                }

                lookupValueFromIAConnectLookupTablepropCount++;
                lookupValueFromIAConnectLookupTable["SearchResultValueColumnName"] = ExpressionConverter.ConvertO(__workflow_lookupValueFromIAConnectLookupTablesearchResultValueColumnName);
                if (__workflow_lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex != null)
                {
                    if (__workflow_lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex != null)
                    {
                        lookupValueFromIAConnectLookupTable["SearchResultValueColumnIndex"] = ExpressionConverter.ConvertO(__workflow_lookupValueFromIAConnectLookupTablesearchResultValueColumnIndex);
                        lookupValueFromIAConnectLookupTablepropCount++;
                    }

                    lookupValueFromIAConnectLookupTablepropCount++;
                }
                else
                {
                    lookupValueFromIAConnectLookupTable["SearchResultValueColumnIndex"] = 1;
                    lookupValueFromIAConnectLookupTablepropCount++;
                }

                if (__workflow_lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                {
                    if (__workflow_lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                    {
                        lookupValueFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = ExpressionConverter.ConvertO(__workflow_lookupValueFromIAConnectLookupTableraiseExceptionIfNoMatch);
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
                lookupValueFromIAConnectLookupTable["Workflow"] = ExpressionConverter.ConvertO(__workflow_lookupValueFromIAConnectLookupTableworkflow);
                if (lookupValueFromIAConnectLookupTablepropCount > 0)
                {
                    callPayload.Body = lookupValueFromIAConnectLookupTable;
                }

                return new ApiConnectionAction<LookupValueFromIAConnectLookupTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<LookupColumnsFromIAConnectLookupTableResponse> LookupColumnsFromIAConnectLookupTable(Expression<Func<string>> lookupColumnsFromIAConnectLookupTablelookupTableName, Expression<Func<string>> lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName, Expression<Func<string>> lookupColumnsFromIAConnectLookupTableworkflow, Expression<Func<string>> lookupColumnsFromIAConnectLookupTableinputDataJSON = null, Expression<Func<bool>> lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch = null, Expression<Func<bool>> lookupColumnsFromIAConnectLookupTablereturnBlankCells = null, Expression<Func<lookupColumnsFromIAConnectLookupTablereturnFormatInput>> lookupColumnsFromIAConnectLookupTablereturnFormat = null)
        {
            var __workflow_lookupColumnsFromIAConnectLookupTablelookupTableName = lookupColumnsFromIAConnectLookupTablelookupTableName == null ? null : WorkflowExpression.Compile(lookupColumnsFromIAConnectLookupTablelookupTableName);
            WorkflowExpression.Validate(__workflow_lookupColumnsFromIAConnectLookupTablelookupTableName, nameof(lookupColumnsFromIAConnectLookupTablelookupTableName), required: true);
            var __workflow_lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName = lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName == null ? null : WorkflowExpression.Compile(lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName);
            WorkflowExpression.Validate(__workflow_lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName, nameof(lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName), required: true);
            var __workflow_lookupColumnsFromIAConnectLookupTableworkflow = lookupColumnsFromIAConnectLookupTableworkflow == null ? null : WorkflowExpression.Compile(lookupColumnsFromIAConnectLookupTableworkflow);
            WorkflowExpression.Validate(__workflow_lookupColumnsFromIAConnectLookupTableworkflow, nameof(lookupColumnsFromIAConnectLookupTableworkflow), required: true);
            var __workflow_lookupColumnsFromIAConnectLookupTableinputDataJSON = lookupColumnsFromIAConnectLookupTableinputDataJSON == null ? null : WorkflowExpression.Compile(lookupColumnsFromIAConnectLookupTableinputDataJSON);
            WorkflowExpression.Validate(__workflow_lookupColumnsFromIAConnectLookupTableinputDataJSON, nameof(lookupColumnsFromIAConnectLookupTableinputDataJSON), required: false);
            var __workflow_lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch = lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch == null ? null : WorkflowExpression.Compile(lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch);
            WorkflowExpression.Validate(__workflow_lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch, nameof(lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch), required: false);
            var __workflow_lookupColumnsFromIAConnectLookupTablereturnBlankCells = lookupColumnsFromIAConnectLookupTablereturnBlankCells == null ? null : WorkflowExpression.Compile(lookupColumnsFromIAConnectLookupTablereturnBlankCells);
            WorkflowExpression.Validate(__workflow_lookupColumnsFromIAConnectLookupTablereturnBlankCells, nameof(lookupColumnsFromIAConnectLookupTablereturnBlankCells), required: false);
            var __workflow_lookupColumnsFromIAConnectLookupTablereturnFormat = lookupColumnsFromIAConnectLookupTablereturnFormat == null ? null : WorkflowExpression.Compile(lookupColumnsFromIAConnectLookupTablereturnFormat);
            WorkflowExpression.Validate(__workflow_lookupColumnsFromIAConnectLookupTablereturnFormat, nameof(lookupColumnsFromIAConnectLookupTablereturnFormat), required: false);
            return new DeferredBodyAction<LookupColumnsFromIAConnectLookupTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/LookupColumnsFromIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lookupColumnsFromIAConnectLookupTable = new JObject();
                var lookupColumnsFromIAConnectLookupTablepropCount = 0;
                lookupColumnsFromIAConnectLookupTablepropCount++;
                lookupColumnsFromIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(__workflow_lookupColumnsFromIAConnectLookupTablelookupTableName);
                if (__workflow_lookupColumnsFromIAConnectLookupTableinputDataJSON != null)
                {
                    lookupColumnsFromIAConnectLookupTable["InputDataJSON"] = ExpressionConverter.ConvertO(__workflow_lookupColumnsFromIAConnectLookupTableinputDataJSON);
                    lookupColumnsFromIAConnectLookupTablepropCount++;
                }

                lookupColumnsFromIAConnectLookupTablepropCount++;
                lookupColumnsFromIAConnectLookupTable["SearchResultTableColumnName"] = ExpressionConverter.ConvertO(__workflow_lookupColumnsFromIAConnectLookupTablesearchResultTableColumnName);
                if (__workflow_lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                {
                    if (__workflow_lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                    {
                        lookupColumnsFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = ExpressionConverter.ConvertO(__workflow_lookupColumnsFromIAConnectLookupTableraiseExceptionIfNoMatch);
                        lookupColumnsFromIAConnectLookupTablepropCount++;
                    }

                    lookupColumnsFromIAConnectLookupTablepropCount++;
                }
                else
                {
                    lookupColumnsFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = true;
                    lookupColumnsFromIAConnectLookupTablepropCount++;
                }

                if (__workflow_lookupColumnsFromIAConnectLookupTablereturnBlankCells != null)
                {
                    if (__workflow_lookupColumnsFromIAConnectLookupTablereturnBlankCells != null)
                    {
                        lookupColumnsFromIAConnectLookupTable["ReturnBlankCells"] = ExpressionConverter.ConvertO(__workflow_lookupColumnsFromIAConnectLookupTablereturnBlankCells);
                        lookupColumnsFromIAConnectLookupTablepropCount++;
                    }

                    lookupColumnsFromIAConnectLookupTablepropCount++;
                }
                else
                {
                    lookupColumnsFromIAConnectLookupTable["ReturnBlankCells"] = false;
                    lookupColumnsFromIAConnectLookupTablepropCount++;
                }

                if (__workflow_lookupColumnsFromIAConnectLookupTablereturnFormat != null)
                {
                    if (__workflow_lookupColumnsFromIAConnectLookupTablereturnFormat != null)
                    {
                        lookupColumnsFromIAConnectLookupTable["ReturnFormat"] = ExpressionConverter.ConvertO(__workflow_lookupColumnsFromIAConnectLookupTablereturnFormat);
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
                lookupColumnsFromIAConnectLookupTable["Workflow"] = ExpressionConverter.ConvertO(__workflow_lookupColumnsFromIAConnectLookupTableworkflow);
                if (lookupColumnsFromIAConnectLookupTablepropCount > 0)
                {
                    callPayload.Body = lookupColumnsFromIAConnectLookupTable;
                }

                return new ApiConnectionAction<LookupColumnsFromIAConnectLookupTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectdynamiccode")]
        public IBodyWorkflowAction<RemoveCharactersFromStringResponse> RemoveCharactersFromString(Expression<Func<string>> removeCharactersFromStringinputString = null, Expression<Func<string>> removeCharactersFromStringcharactersToRemoveFromInputString = null, Expression<Func<bool>> removeCharactersFromStringremoveDiacriticsFromInputString = null, Expression<Func<bool>> removeCharactersFromStringremoveNonAlphaNumericFromInputString = null, Expression<Func<bool>> removeCharactersFromStringremoveNumericFromInputString = null, Expression<Func<bool>> removeCharactersFromStringremoveLowercaseCharactersFromInputString = null, Expression<Func<bool>> removeCharactersFromStringremoveUppercaseCharactersFromInputString = null)
        {
            var __workflow_removeCharactersFromStringinputString = removeCharactersFromStringinputString == null ? null : WorkflowExpression.Compile(removeCharactersFromStringinputString);
            WorkflowExpression.Validate(__workflow_removeCharactersFromStringinputString, nameof(removeCharactersFromStringinputString), required: false);
            var __workflow_removeCharactersFromStringcharactersToRemoveFromInputString = removeCharactersFromStringcharactersToRemoveFromInputString == null ? null : WorkflowExpression.Compile(removeCharactersFromStringcharactersToRemoveFromInputString);
            WorkflowExpression.Validate(__workflow_removeCharactersFromStringcharactersToRemoveFromInputString, nameof(removeCharactersFromStringcharactersToRemoveFromInputString), required: false);
            var __workflow_removeCharactersFromStringremoveDiacriticsFromInputString = removeCharactersFromStringremoveDiacriticsFromInputString == null ? null : WorkflowExpression.Compile(removeCharactersFromStringremoveDiacriticsFromInputString);
            WorkflowExpression.Validate(__workflow_removeCharactersFromStringremoveDiacriticsFromInputString, nameof(removeCharactersFromStringremoveDiacriticsFromInputString), required: false);
            var __workflow_removeCharactersFromStringremoveNonAlphaNumericFromInputString = removeCharactersFromStringremoveNonAlphaNumericFromInputString == null ? null : WorkflowExpression.Compile(removeCharactersFromStringremoveNonAlphaNumericFromInputString);
            WorkflowExpression.Validate(__workflow_removeCharactersFromStringremoveNonAlphaNumericFromInputString, nameof(removeCharactersFromStringremoveNonAlphaNumericFromInputString), required: false);
            var __workflow_removeCharactersFromStringremoveNumericFromInputString = removeCharactersFromStringremoveNumericFromInputString == null ? null : WorkflowExpression.Compile(removeCharactersFromStringremoveNumericFromInputString);
            WorkflowExpression.Validate(__workflow_removeCharactersFromStringremoveNumericFromInputString, nameof(removeCharactersFromStringremoveNumericFromInputString), required: false);
            var __workflow_removeCharactersFromStringremoveLowercaseCharactersFromInputString = removeCharactersFromStringremoveLowercaseCharactersFromInputString == null ? null : WorkflowExpression.Compile(removeCharactersFromStringremoveLowercaseCharactersFromInputString);
            WorkflowExpression.Validate(__workflow_removeCharactersFromStringremoveLowercaseCharactersFromInputString, nameof(removeCharactersFromStringremoveLowercaseCharactersFromInputString), required: false);
            var __workflow_removeCharactersFromStringremoveUppercaseCharactersFromInputString = removeCharactersFromStringremoveUppercaseCharactersFromInputString == null ? null : WorkflowExpression.Compile(removeCharactersFromStringremoveUppercaseCharactersFromInputString);
            WorkflowExpression.Validate(__workflow_removeCharactersFromStringremoveUppercaseCharactersFromInputString, nameof(removeCharactersFromStringremoveUppercaseCharactersFromInputString), required: false);
            return new DeferredBodyAction<RemoveCharactersFromStringResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/RemoveCharactersFromString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var removeCharactersFromString = new JObject();
                var removeCharactersFromStringpropCount = 0;
                if (__workflow_removeCharactersFromStringinputString != null)
                {
                    removeCharactersFromString["InputString"] = ExpressionConverter.ConvertO(__workflow_removeCharactersFromStringinputString);
                    removeCharactersFromStringpropCount++;
                }

                if (__workflow_removeCharactersFromStringcharactersToRemoveFromInputString != null)
                {
                    removeCharactersFromString["CharactersToRemoveFromInputString"] = ExpressionConverter.ConvertO(__workflow_removeCharactersFromStringcharactersToRemoveFromInputString);
                    removeCharactersFromStringpropCount++;
                }

                if (__workflow_removeCharactersFromStringremoveDiacriticsFromInputString != null)
                {
                    if (__workflow_removeCharactersFromStringremoveDiacriticsFromInputString != null)
                    {
                        removeCharactersFromString["RemoveDiacriticsFromInputString"] = ExpressionConverter.ConvertO(__workflow_removeCharactersFromStringremoveDiacriticsFromInputString);
                        removeCharactersFromStringpropCount++;
                    }

                    removeCharactersFromStringpropCount++;
                }
                else
                {
                    removeCharactersFromString["RemoveDiacriticsFromInputString"] = false;
                    removeCharactersFromStringpropCount++;
                }

                if (__workflow_removeCharactersFromStringremoveNonAlphaNumericFromInputString != null)
                {
                    if (__workflow_removeCharactersFromStringremoveNonAlphaNumericFromInputString != null)
                    {
                        removeCharactersFromString["RemoveNonAlphaNumericFromInputString"] = ExpressionConverter.ConvertO(__workflow_removeCharactersFromStringremoveNonAlphaNumericFromInputString);
                        removeCharactersFromStringpropCount++;
                    }

                    removeCharactersFromStringpropCount++;
                }
                else
                {
                    removeCharactersFromString["RemoveNonAlphaNumericFromInputString"] = false;
                    removeCharactersFromStringpropCount++;
                }

                if (__workflow_removeCharactersFromStringremoveNumericFromInputString != null)
                {
                    if (__workflow_removeCharactersFromStringremoveNumericFromInputString != null)
                    {
                        removeCharactersFromString["RemoveNumericFromInputString"] = ExpressionConverter.ConvertO(__workflow_removeCharactersFromStringremoveNumericFromInputString);
                        removeCharactersFromStringpropCount++;
                    }

                    removeCharactersFromStringpropCount++;
                }
                else
                {
                    removeCharactersFromString["RemoveNumericFromInputString"] = false;
                    removeCharactersFromStringpropCount++;
                }

                if (__workflow_removeCharactersFromStringremoveLowercaseCharactersFromInputString != null)
                {
                    if (__workflow_removeCharactersFromStringremoveLowercaseCharactersFromInputString != null)
                    {
                        removeCharactersFromString["RemoveLowercaseCharactersFromInputString"] = ExpressionConverter.ConvertO(__workflow_removeCharactersFromStringremoveLowercaseCharactersFromInputString);
                        removeCharactersFromStringpropCount++;
                    }

                    removeCharactersFromStringpropCount++;
                }
                else
                {
                    removeCharactersFromString["RemoveLowercaseCharactersFromInputString"] = false;
                    removeCharactersFromStringpropCount++;
                }

                if (__workflow_removeCharactersFromStringremoveUppercaseCharactersFromInputString != null)
                {
                    if (__workflow_removeCharactersFromStringremoveUppercaseCharactersFromInputString != null)
                    {
                        removeCharactersFromString["RemoveUppercaseCharactersFromInputString"] = ExpressionConverter.ConvertO(__workflow_removeCharactersFromStringremoveUppercaseCharactersFromInputString);
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
        public IBodyWorkflowAction<GetColumnFromIAConnectListResponse> GetColumnFromIAConnectList(Expression<Func<string>> getColumnFromIAConnectListlistName, Expression<Func<int>> getColumnFromIAConnectListsearchColumnIndex = null, Expression<Func<string>> getColumnFromIAConnectListsearchColumnName = null, Expression<Func<bool>> getColumnFromIAConnectListreturnBlankCells = null, Expression<Func<bool>> getColumnFromIAConnectListfallBackIfListDoesNotExist = null, Expression<Func<string>> getColumnFromIAConnectListfallbackValue = null, Expression<Func<getColumnFromIAConnectListreturnFormatInput>> getColumnFromIAConnectListreturnFormat = null)
        {
            var __workflow_getColumnFromIAConnectListlistName = getColumnFromIAConnectListlistName == null ? null : WorkflowExpression.Compile(getColumnFromIAConnectListlistName);
            WorkflowExpression.Validate(__workflow_getColumnFromIAConnectListlistName, nameof(getColumnFromIAConnectListlistName), required: true);
            var __workflow_getColumnFromIAConnectListsearchColumnIndex = getColumnFromIAConnectListsearchColumnIndex == null ? null : WorkflowExpression.Compile(getColumnFromIAConnectListsearchColumnIndex);
            WorkflowExpression.Validate(__workflow_getColumnFromIAConnectListsearchColumnIndex, nameof(getColumnFromIAConnectListsearchColumnIndex), required: false);
            var __workflow_getColumnFromIAConnectListsearchColumnName = getColumnFromIAConnectListsearchColumnName == null ? null : WorkflowExpression.Compile(getColumnFromIAConnectListsearchColumnName);
            WorkflowExpression.Validate(__workflow_getColumnFromIAConnectListsearchColumnName, nameof(getColumnFromIAConnectListsearchColumnName), required: false);
            var __workflow_getColumnFromIAConnectListreturnBlankCells = getColumnFromIAConnectListreturnBlankCells == null ? null : WorkflowExpression.Compile(getColumnFromIAConnectListreturnBlankCells);
            WorkflowExpression.Validate(__workflow_getColumnFromIAConnectListreturnBlankCells, nameof(getColumnFromIAConnectListreturnBlankCells), required: false);
            var __workflow_getColumnFromIAConnectListfallBackIfListDoesNotExist = getColumnFromIAConnectListfallBackIfListDoesNotExist == null ? null : WorkflowExpression.Compile(getColumnFromIAConnectListfallBackIfListDoesNotExist);
            WorkflowExpression.Validate(__workflow_getColumnFromIAConnectListfallBackIfListDoesNotExist, nameof(getColumnFromIAConnectListfallBackIfListDoesNotExist), required: false);
            var __workflow_getColumnFromIAConnectListfallbackValue = getColumnFromIAConnectListfallbackValue == null ? null : WorkflowExpression.Compile(getColumnFromIAConnectListfallbackValue);
            WorkflowExpression.Validate(__workflow_getColumnFromIAConnectListfallbackValue, nameof(getColumnFromIAConnectListfallbackValue), required: false);
            var __workflow_getColumnFromIAConnectListreturnFormat = getColumnFromIAConnectListreturnFormat == null ? null : WorkflowExpression.Compile(getColumnFromIAConnectListreturnFormat);
            WorkflowExpression.Validate(__workflow_getColumnFromIAConnectListreturnFormat, nameof(getColumnFromIAConnectListreturnFormat), required: false);
            return new DeferredBodyAction<GetColumnFromIAConnectListResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetColumnFromIAConnectList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getColumnFromIAConnectList = new JObject();
                var getColumnFromIAConnectListpropCount = 0;
                getColumnFromIAConnectListpropCount++;
                getColumnFromIAConnectList["ListName"] = ExpressionConverter.ConvertO(__workflow_getColumnFromIAConnectListlistName);
                if (__workflow_getColumnFromIAConnectListsearchColumnIndex != null)
                {
                    if (__workflow_getColumnFromIAConnectListsearchColumnIndex != null)
                    {
                        getColumnFromIAConnectList["SearchColumnIndex"] = ExpressionConverter.ConvertO(__workflow_getColumnFromIAConnectListsearchColumnIndex);
                        getColumnFromIAConnectListpropCount++;
                    }

                    getColumnFromIAConnectListpropCount++;
                }
                else
                {
                    getColumnFromIAConnectList["SearchColumnIndex"] = 1;
                    getColumnFromIAConnectListpropCount++;
                }

                if (__workflow_getColumnFromIAConnectListsearchColumnName != null)
                {
                    getColumnFromIAConnectList["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_getColumnFromIAConnectListsearchColumnName);
                    getColumnFromIAConnectListpropCount++;
                }

                if (__workflow_getColumnFromIAConnectListreturnBlankCells != null)
                {
                    if (__workflow_getColumnFromIAConnectListreturnBlankCells != null)
                    {
                        getColumnFromIAConnectList["ReturnBlankCells"] = ExpressionConverter.ConvertO(__workflow_getColumnFromIAConnectListreturnBlankCells);
                        getColumnFromIAConnectListpropCount++;
                    }

                    getColumnFromIAConnectListpropCount++;
                }
                else
                {
                    getColumnFromIAConnectList["ReturnBlankCells"] = false;
                    getColumnFromIAConnectListpropCount++;
                }

                if (__workflow_getColumnFromIAConnectListfallBackIfListDoesNotExist != null)
                {
                    if (__workflow_getColumnFromIAConnectListfallBackIfListDoesNotExist != null)
                    {
                        getColumnFromIAConnectList["FallBackIfListDoesNotExist"] = ExpressionConverter.ConvertO(__workflow_getColumnFromIAConnectListfallBackIfListDoesNotExist);
                        getColumnFromIAConnectListpropCount++;
                    }

                    getColumnFromIAConnectListpropCount++;
                }
                else
                {
                    getColumnFromIAConnectList["FallBackIfListDoesNotExist"] = false;
                    getColumnFromIAConnectListpropCount++;
                }

                if (__workflow_getColumnFromIAConnectListfallbackValue != null)
                {
                    getColumnFromIAConnectList["FallbackValue"] = ExpressionConverter.ConvertO(__workflow_getColumnFromIAConnectListfallbackValue);
                    getColumnFromIAConnectListpropCount++;
                }

                if (__workflow_getColumnFromIAConnectListreturnFormat != null)
                {
                    if (__workflow_getColumnFromIAConnectListreturnFormat != null)
                    {
                        getColumnFromIAConnectList["ReturnFormat"] = ExpressionConverter.ConvertO(__workflow_getColumnFromIAConnectListreturnFormat);
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
        public IBodyWorkflowAction<GetIAConnectListContentsResponse> GetIAConnectListContents(Expression<Func<string>> getIAConnectListContentslistName, Expression<Func<getIAConnectListContentsreturnFormatInput>> getIAConnectListContentsreturnFormat = null)
        {
            var __workflow_getIAConnectListContentslistName = getIAConnectListContentslistName == null ? null : WorkflowExpression.Compile(getIAConnectListContentslistName);
            WorkflowExpression.Validate(__workflow_getIAConnectListContentslistName, nameof(getIAConnectListContentslistName), required: true);
            var __workflow_getIAConnectListContentsreturnFormat = getIAConnectListContentsreturnFormat == null ? null : WorkflowExpression.Compile(getIAConnectListContentsreturnFormat);
            WorkflowExpression.Validate(__workflow_getIAConnectListContentsreturnFormat, nameof(getIAConnectListContentsreturnFormat), required: false);
            return new DeferredBodyAction<GetIAConnectListContentsResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetIAConnectListContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectListContents = new JObject();
                var getIAConnectListContentspropCount = 0;
                getIAConnectListContentspropCount++;
                getIAConnectListContents["ListName"] = ExpressionConverter.ConvertO(__workflow_getIAConnectListContentslistName);
                if (__workflow_getIAConnectListContentsreturnFormat != null)
                {
                    if (__workflow_getIAConnectListContentsreturnFormat != null)
                    {
                        getIAConnectListContents["ReturnFormat"] = ExpressionConverter.ConvertO(__workflow_getIAConnectListContentsreturnFormat);
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
        public IBodyWorkflowAction<LookupDataCellsFromIAConnectLookupTableResponse> LookupDataCellsFromIAConnectLookupTable(Expression<Func<string>> lookupDataCellsFromIAConnectLookupTablelookupTableName, Expression<Func<string>> lookupDataCellsFromIAConnectLookupTableinputDataJSON = null, Expression<Func<bool>> lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch = null, Expression<Func<bool>> lookupDataCellsFromIAConnectLookupTablereturnBlankCells = null, Expression<Func<lookupDataCellsFromIAConnectLookupTablereturnFormatInput>> lookupDataCellsFromIAConnectLookupTablereturnFormat = null)
        {
            var __workflow_lookupDataCellsFromIAConnectLookupTablelookupTableName = lookupDataCellsFromIAConnectLookupTablelookupTableName == null ? null : WorkflowExpression.Compile(lookupDataCellsFromIAConnectLookupTablelookupTableName);
            WorkflowExpression.Validate(__workflow_lookupDataCellsFromIAConnectLookupTablelookupTableName, nameof(lookupDataCellsFromIAConnectLookupTablelookupTableName), required: true);
            var __workflow_lookupDataCellsFromIAConnectLookupTableinputDataJSON = lookupDataCellsFromIAConnectLookupTableinputDataJSON == null ? null : WorkflowExpression.Compile(lookupDataCellsFromIAConnectLookupTableinputDataJSON);
            WorkflowExpression.Validate(__workflow_lookupDataCellsFromIAConnectLookupTableinputDataJSON, nameof(lookupDataCellsFromIAConnectLookupTableinputDataJSON), required: false);
            var __workflow_lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch = lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch == null ? null : WorkflowExpression.Compile(lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch);
            WorkflowExpression.Validate(__workflow_lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch, nameof(lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch), required: false);
            var __workflow_lookupDataCellsFromIAConnectLookupTablereturnBlankCells = lookupDataCellsFromIAConnectLookupTablereturnBlankCells == null ? null : WorkflowExpression.Compile(lookupDataCellsFromIAConnectLookupTablereturnBlankCells);
            WorkflowExpression.Validate(__workflow_lookupDataCellsFromIAConnectLookupTablereturnBlankCells, nameof(lookupDataCellsFromIAConnectLookupTablereturnBlankCells), required: false);
            var __workflow_lookupDataCellsFromIAConnectLookupTablereturnFormat = lookupDataCellsFromIAConnectLookupTablereturnFormat == null ? null : WorkflowExpression.Compile(lookupDataCellsFromIAConnectLookupTablereturnFormat);
            WorkflowExpression.Validate(__workflow_lookupDataCellsFromIAConnectLookupTablereturnFormat, nameof(lookupDataCellsFromIAConnectLookupTablereturnFormat), required: false);
            return new DeferredBodyAction<LookupDataCellsFromIAConnectLookupTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/LookupDataCellsFromIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lookupDataCellsFromIAConnectLookupTable = new JObject();
                var lookupDataCellsFromIAConnectLookupTablepropCount = 0;
                lookupDataCellsFromIAConnectLookupTablepropCount++;
                lookupDataCellsFromIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(__workflow_lookupDataCellsFromIAConnectLookupTablelookupTableName);
                if (__workflow_lookupDataCellsFromIAConnectLookupTableinputDataJSON != null)
                {
                    lookupDataCellsFromIAConnectLookupTable["InputDataJSON"] = ExpressionConverter.ConvertO(__workflow_lookupDataCellsFromIAConnectLookupTableinputDataJSON);
                    lookupDataCellsFromIAConnectLookupTablepropCount++;
                }

                if (__workflow_lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                {
                    if (__workflow_lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch != null)
                    {
                        lookupDataCellsFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = ExpressionConverter.ConvertO(__workflow_lookupDataCellsFromIAConnectLookupTableraiseExceptionIfNoMatch);
                        lookupDataCellsFromIAConnectLookupTablepropCount++;
                    }

                    lookupDataCellsFromIAConnectLookupTablepropCount++;
                }
                else
                {
                    lookupDataCellsFromIAConnectLookupTable["RaiseExceptionIfNoMatch"] = true;
                    lookupDataCellsFromIAConnectLookupTablepropCount++;
                }

                if (__workflow_lookupDataCellsFromIAConnectLookupTablereturnBlankCells != null)
                {
                    if (__workflow_lookupDataCellsFromIAConnectLookupTablereturnBlankCells != null)
                    {
                        lookupDataCellsFromIAConnectLookupTable["ReturnBlankCells"] = ExpressionConverter.ConvertO(__workflow_lookupDataCellsFromIAConnectLookupTablereturnBlankCells);
                        lookupDataCellsFromIAConnectLookupTablepropCount++;
                    }

                    lookupDataCellsFromIAConnectLookupTablepropCount++;
                }
                else
                {
                    lookupDataCellsFromIAConnectLookupTable["ReturnBlankCells"] = false;
                    lookupDataCellsFromIAConnectLookupTablepropCount++;
                }

                if (__workflow_lookupDataCellsFromIAConnectLookupTablereturnFormat != null)
                {
                    if (__workflow_lookupDataCellsFromIAConnectLookupTablereturnFormat != null)
                    {
                        lookupDataCellsFromIAConnectLookupTable["ReturnFormat"] = ExpressionConverter.ConvertO(__workflow_lookupDataCellsFromIAConnectLookupTablereturnFormat);
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
        public IBodyWorkflowAction<GetIAConnectLookupTableContentsResponse> GetIAConnectLookupTableContents(Expression<Func<string>> getIAConnectLookupTableContentslookupTableName, Expression<Func<getIAConnectLookupTableContentsreturnFormatInput>> getIAConnectLookupTableContentsreturnFormat = null)
        {
            var __workflow_getIAConnectLookupTableContentslookupTableName = getIAConnectLookupTableContentslookupTableName == null ? null : WorkflowExpression.Compile(getIAConnectLookupTableContentslookupTableName);
            WorkflowExpression.Validate(__workflow_getIAConnectLookupTableContentslookupTableName, nameof(getIAConnectLookupTableContentslookupTableName), required: true);
            var __workflow_getIAConnectLookupTableContentsreturnFormat = getIAConnectLookupTableContentsreturnFormat == null ? null : WorkflowExpression.Compile(getIAConnectLookupTableContentsreturnFormat);
            WorkflowExpression.Validate(__workflow_getIAConnectLookupTableContentsreturnFormat, nameof(getIAConnectLookupTableContentsreturnFormat), required: false);
            return new DeferredBodyAction<GetIAConnectLookupTableContentsResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/GetIAConnectLookupTableContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getIAConnectLookupTableContents = new JObject();
                var getIAConnectLookupTableContentspropCount = 0;
                getIAConnectLookupTableContentspropCount++;
                getIAConnectLookupTableContents["LookupTableName"] = ExpressionConverter.ConvertO(__workflow_getIAConnectLookupTableContentslookupTableName);
                if (__workflow_getIAConnectLookupTableContentsreturnFormat != null)
                {
                    if (__workflow_getIAConnectLookupTableContentsreturnFormat != null)
                    {
                        getIAConnectLookupTableContents["ReturnFormat"] = ExpressionConverter.ConvertO(__workflow_getIAConnectLookupTableContentsreturnFormat);
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
        public IBodyWorkflowAction<UploadCSVToIAConnectLookupTableResponse> UploadCSVToIAConnectLookupTable(Expression<Func<string>> uploadCSVToIAConnectLookupTablelookupTableName, Expression<Func<string>> uploadCSVToIAConnectLookupTablecSVData, Expression<Func<bool>> uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist = null)
        {
            var __workflow_uploadCSVToIAConnectLookupTablelookupTableName = uploadCSVToIAConnectLookupTablelookupTableName == null ? null : WorkflowExpression.Compile(uploadCSVToIAConnectLookupTablelookupTableName);
            WorkflowExpression.Validate(__workflow_uploadCSVToIAConnectLookupTablelookupTableName, nameof(uploadCSVToIAConnectLookupTablelookupTableName), required: true);
            var __workflow_uploadCSVToIAConnectLookupTablecSVData = uploadCSVToIAConnectLookupTablecSVData == null ? null : WorkflowExpression.Compile(uploadCSVToIAConnectLookupTablecSVData);
            WorkflowExpression.Validate(__workflow_uploadCSVToIAConnectLookupTablecSVData, nameof(uploadCSVToIAConnectLookupTablecSVData), required: true);
            var __workflow_uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist = uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist == null ? null : WorkflowExpression.Compile(uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist);
            WorkflowExpression.Validate(__workflow_uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist, nameof(uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist), required: false);
            return new DeferredBodyAction<UploadCSVToIAConnectLookupTableResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/UploadCSVToIAConnectLookupTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uploadCSVToIAConnectLookupTable = new JObject();
                var uploadCSVToIAConnectLookupTablepropCount = 0;
                uploadCSVToIAConnectLookupTablepropCount++;
                uploadCSVToIAConnectLookupTable["LookupTableName"] = ExpressionConverter.ConvertO(__workflow_uploadCSVToIAConnectLookupTablelookupTableName);
                uploadCSVToIAConnectLookupTablepropCount++;
                uploadCSVToIAConnectLookupTable["CSVData"] = ExpressionConverter.ConvertO(__workflow_uploadCSVToIAConnectLookupTablecSVData);
                if (__workflow_uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist != null)
                {
                    if (__workflow_uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist != null)
                    {
                        uploadCSVToIAConnectLookupTable["CreateLookupTableIfNotExist"] = ExpressionConverter.ConvertO(__workflow_uploadCSVToIAConnectLookupTablecreateLookupTableIfNotExist);
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
        public IBodyWorkflowAction<UploadCSVToIAConnectListResponse> UploadCSVToIAConnectList(Expression<Func<string>> uploadCSVToIAConnectListlistName, Expression<Func<string>> uploadCSVToIAConnectListcSVData, Expression<Func<bool>> uploadCSVToIAConnectListcreateListIfNotExist = null)
        {
            var __workflow_uploadCSVToIAConnectListlistName = uploadCSVToIAConnectListlistName == null ? null : WorkflowExpression.Compile(uploadCSVToIAConnectListlistName);
            WorkflowExpression.Validate(__workflow_uploadCSVToIAConnectListlistName, nameof(uploadCSVToIAConnectListlistName), required: true);
            var __workflow_uploadCSVToIAConnectListcSVData = uploadCSVToIAConnectListcSVData == null ? null : WorkflowExpression.Compile(uploadCSVToIAConnectListcSVData);
            WorkflowExpression.Validate(__workflow_uploadCSVToIAConnectListcSVData, nameof(uploadCSVToIAConnectListcSVData), required: true);
            var __workflow_uploadCSVToIAConnectListcreateListIfNotExist = uploadCSVToIAConnectListcreateListIfNotExist == null ? null : WorkflowExpression.Compile(uploadCSVToIAConnectListcreateListIfNotExist);
            WorkflowExpression.Validate(__workflow_uploadCSVToIAConnectListcreateListIfNotExist, nameof(uploadCSVToIAConnectListcreateListIfNotExist), required: false);
            return new DeferredBodyAction<UploadCSVToIAConnectListResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/UploadCSVToIAConnectList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uploadCSVToIAConnectList = new JObject();
                var uploadCSVToIAConnectListpropCount = 0;
                uploadCSVToIAConnectListpropCount++;
                uploadCSVToIAConnectList["ListName"] = ExpressionConverter.ConvertO(__workflow_uploadCSVToIAConnectListlistName);
                uploadCSVToIAConnectListpropCount++;
                uploadCSVToIAConnectList["CSVData"] = ExpressionConverter.ConvertO(__workflow_uploadCSVToIAConnectListcSVData);
                if (__workflow_uploadCSVToIAConnectListcreateListIfNotExist != null)
                {
                    if (__workflow_uploadCSVToIAConnectListcreateListIfNotExist != null)
                    {
                        uploadCSVToIAConnectList["CreateListIfNotExist"] = ExpressionConverter.ConvertO(__workflow_uploadCSVToIAConnectListcreateListIfNotExist);
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
        public IBodyWorkflowAction<ConvertArrayToJSONResponse> ConvertArrayToJSON(Expression<Func<JToken[]>> convertArrayToJSONinputObject)
        {
            var __workflow_convertArrayToJSONinputObject = convertArrayToJSONinputObject == null ? null : WorkflowExpression.Compile(convertArrayToJSONinputObject);
            WorkflowExpression.Validate(__workflow_convertArrayToJSONinputObject, nameof(convertArrayToJSONinputObject), required: true);
            return new DeferredBodyAction<ConvertArrayToJSONResponse>(() =>
            {
                var apiCallPath = "/DynamicCode/ConvertArrayToJSON";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var convertArrayToJSON = new JObject();
                var convertArrayToJSONpropCount = 0;
                convertArrayToJSONpropCount++;
                convertArrayToJSON["InputObject"] = ExpressionConverter.ConvertO(__workflow_convertArrayToJSONinputObject);
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
