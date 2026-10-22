//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectjml
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectjmlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunActiveDirectoryPowerShellAutomationScriptResponse, ApiConnectionActionConfiguration> RunActiveDirectoryPowerShellAutomationScript(Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptworkflow, Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptisNoResultAnError = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate = null, Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread = null, Expression<Func<int>> runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId = null, Expression<Func<int>> runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput = null, Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON = null, Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON = null, Expression<Func<runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParametersInputItem[]>> runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            var __workflow_runActiveDirectoryPowerShellAutomationScriptworkflow = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptworkflow, nameof(runActiveDirectoryPowerShellAutomationScriptworkflow), required: true);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents, nameof(runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents), required: false);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptisNoResultAnError = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptisNoResultAnError, nameof(runActiveDirectoryPowerShellAutomationScriptisNoResultAnError), required: false);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes, nameof(runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes), required: false);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean, nameof(runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean), required: false);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal, nameof(runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal), required: false);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate, nameof(runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate), required: false);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON, nameof(runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON), required: false);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread, nameof(runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread), required: false);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId, nameof(runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId), required: false);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread, nameof(runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread), required: false);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword, nameof(runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword), required: false);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput, nameof(runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput), required: false);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON, nameof(runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON), required: false);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON, nameof(runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON), required: false);
            var __workflow_runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters, nameof(runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters), required: false);
            return new DeferredBodyAction<RunActiveDirectoryPowerShellAutomationScriptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/RunActiveDirectoryPowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runActiveDirectoryPowerShellAutomationScript = new JObject();
                var runActiveDirectoryPowerShellAutomationScriptpropCount = 0;
                if (__workflow_runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runActiveDirectoryPowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (__workflow_runActiveDirectoryPowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptisNoResultAnError);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["IsNoResultAnError"] = false;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes != null)
                {
                    if (__workflow_runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["ReturnComplexTypes"] = false;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean != null)
                {
                    if (__workflow_runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["ReturnBooleanAsBoolean"] = false;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal != null)
                {
                    if (__workflow_runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["ReturnNumericAsDecimal"] = false;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate != null)
                {
                    if (__workflow_runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["ReturnDateAsDate"] = false;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (__workflow_runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["RunScriptAsThread"] = false;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (__workflow_runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["SecondsToWaitForThread"] = 90;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword != null)
                {
                    if (__workflow_runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["ScriptContainsStoredPassword"] = true;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput != null)
                {
                    if (__workflow_runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["LogVerboseOutput"] = false;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                runActiveDirectoryPowerShellAutomationScriptpropCount++;
                runActiveDirectoryPowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScriptworkflow);
                if (runActiveDirectoryPowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runActiveDirectoryPowerShellAutomationScript;
                }

                return new ApiConnectionAction<RunActiveDirectoryPowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse, ApiConnectionActionConfiguration> OpenActiveDirectoryPowerShellRunspaceWithCredentials(Expression<Func<string>> openActiveDirectoryPowerShellRunspaceWithCredentialsusername, Expression<Func<string>> openActiveDirectoryPowerShellRunspaceWithCredentialspassword, Expression<Func<string>> openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow, Expression<Func<string>> openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer = null, Expression<Func<bool>> openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL = null, Expression<Func<int>> openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort = null)
        {
            var __workflow_openActiveDirectoryPowerShellRunspaceWithCredentialsusername = WorkflowExpression.Compile(openActiveDirectoryPowerShellRunspaceWithCredentialsusername, nameof(openActiveDirectoryPowerShellRunspaceWithCredentialsusername), required: true);
            var __workflow_openActiveDirectoryPowerShellRunspaceWithCredentialspassword = WorkflowExpression.Compile(openActiveDirectoryPowerShellRunspaceWithCredentialspassword, nameof(openActiveDirectoryPowerShellRunspaceWithCredentialspassword), required: true);
            var __workflow_openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow = WorkflowExpression.Compile(openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow, nameof(openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow), required: true);
            var __workflow_openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer = WorkflowExpression.Compile(openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer, nameof(openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer), required: false);
            var __workflow_openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL = WorkflowExpression.Compile(openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL, nameof(openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL), required: false);
            var __workflow_openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort = WorkflowExpression.Compile(openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort, nameof(openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort), required: false);
            return new DeferredBodyAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenActiveDirectoryPowerShellRunspaceWithCredentials";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openActiveDirectoryPowerShellRunspaceWithCredentials = new JObject();
                var openActiveDirectoryPowerShellRunspaceWithCredentialspropCount = 0;
                openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                openActiveDirectoryPowerShellRunspaceWithCredentials["Username"] = ExpressionConverter.ConvertO(__workflow_openActiveDirectoryPowerShellRunspaceWithCredentialsusername);
                openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                openActiveDirectoryPowerShellRunspaceWithCredentials["Password"] = ExpressionConverter.ConvertO(__workflow_openActiveDirectoryPowerShellRunspaceWithCredentialspassword);
                if (__workflow_openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer != null)
                {
                    openActiveDirectoryPowerShellRunspaceWithCredentials["RemoteComputer"] = ExpressionConverter.ConvertO(__workflow_openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer);
                    openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                }

                if (__workflow_openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL != null)
                {
                    if (__workflow_openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL != null)
                    {
                        openActiveDirectoryPowerShellRunspaceWithCredentials["UseSSL"] = ExpressionConverter.ConvertO(__workflow_openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL);
                        openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                    }

                    openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                }
                else
                {
                    openActiveDirectoryPowerShellRunspaceWithCredentials["UseSSL"] = false;
                    openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                }

                if (__workflow_openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort != null)
                {
                    openActiveDirectoryPowerShellRunspaceWithCredentials["AlternativeTCPPort"] = ExpressionConverter.ConvertO(__workflow_openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort);
                    openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                }

                openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                openActiveDirectoryPowerShellRunspaceWithCredentials["Workflow"] = ExpressionConverter.ConvertO(__workflow_openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow);
                if (openActiveDirectoryPowerShellRunspaceWithCredentialspropCount > 0)
                {
                    callPayload.Body = openActiveDirectoryPowerShellRunspaceWithCredentials;
                }

                return new ApiConnectionAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseActiveDirectoryPowerShellRunspaceResponse, ApiConnectionActionConfiguration> CloseActiveDirectoryPowerShellRunspace(Expression<Func<string>> closeActiveDirectoryPowerShellRunspaceworkflow)
        {
            var __workflow_closeActiveDirectoryPowerShellRunspaceworkflow = WorkflowExpression.Compile(closeActiveDirectoryPowerShellRunspaceworkflow, nameof(closeActiveDirectoryPowerShellRunspaceworkflow), required: true);
            return new DeferredBodyAction<CloseActiveDirectoryPowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/CloseActiveDirectoryPowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var closeActiveDirectoryPowerShellRunspace = new JObject();
                var closeActiveDirectoryPowerShellRunspacepropCount = 0;
                closeActiveDirectoryPowerShellRunspacepropCount++;
                closeActiveDirectoryPowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(__workflow_closeActiveDirectoryPowerShellRunspaceworkflow);
                if (closeActiveDirectoryPowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = closeActiveDirectoryPowerShellRunspace;
                }

                return new ApiConnectionAction<CloseActiveDirectoryPowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsActiveDirectoryPowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration> IsActiveDirectoryPowerShellRunspaceOpen(Expression<Func<string>> isActiveDirectoryPowerShellRunspaceOpenworkflow)
        {
            var __workflow_isActiveDirectoryPowerShellRunspaceOpenworkflow = WorkflowExpression.Compile(isActiveDirectoryPowerShellRunspaceOpenworkflow, nameof(isActiveDirectoryPowerShellRunspaceOpenworkflow), required: true);
            return new DeferredBodyAction<IsActiveDirectoryPowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/IsActiveDirectoryPowerShellRunspaceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isActiveDirectoryPowerShellRunspaceOpen = new JObject();
                var isActiveDirectoryPowerShellRunspaceOpenpropCount = 0;
                isActiveDirectoryPowerShellRunspaceOpenpropCount++;
                isActiveDirectoryPowerShellRunspaceOpen["Workflow"] = ExpressionConverter.ConvertO(__workflow_isActiveDirectoryPowerShellRunspaceOpenworkflow);
                if (isActiveDirectoryPowerShellRunspaceOpenpropCount > 0)
                {
                    callPayload.Body = isActiveDirectoryPowerShellRunspaceOpen;
                }

                return new ApiConnectionAction<IsActiveDirectoryPowerShellRunspaceOpenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse, ApiConnectionActionConfiguration> OpenLocalPassthroughActiveDirectoryPowerShellRunspace(Expression<Func<string>> openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow)
        {
            var __workflow_openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow = WorkflowExpression.Compile(openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow, nameof(openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow), required: true);
            return new DeferredBodyAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenLocalPassthroughActiveDirectoryPowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openLocalPassthroughActiveDirectoryPowerShellRunspace = new JObject();
                var openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount = 0;
                openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount++;
                openLocalPassthroughActiveDirectoryPowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(__workflow_openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow);
                if (openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = openLocalPassthroughActiveDirectoryPowerShellRunspace;
                }

                return new ApiConnectionAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserResponse, ApiConnectionActionConfiguration> ActiveDirectoryAddADUser(Expression<Func<string>> activeDirectoryAddADUsername, Expression<Func<string>> activeDirectoryAddADUserworkflow, Expression<Func<string>> activeDirectoryAddADUseruserPrincipalName = null, Expression<Func<string>> activeDirectoryAddADUsersamAccountName = null, Expression<Func<string>> activeDirectoryAddADUsergivenName = null, Expression<Func<string>> activeDirectoryAddADUsersurName = null, Expression<Func<string>> activeDirectoryAddADUserpath = null, Expression<Func<string>> activeDirectoryAddADUserdescription = null, Expression<Func<string>> activeDirectoryAddADUserdisplayName = null, Expression<Func<string>> activeDirectoryAddADUseraccountPassword = null, Expression<Func<bool>> activeDirectoryAddADUseraccountPasswordIsStoredPassword = null, Expression<Func<bool>> activeDirectoryAddADUserenabled = null, Expression<Func<bool>> activeDirectoryAddADUserchangePasswordAtLogon = null, Expression<Func<bool>> activeDirectoryAddADUsercannotChangePassword = null, Expression<Func<bool>> activeDirectoryAddADUserpasswordNeverExpires = null, Expression<Func<string>> activeDirectoryAddADUseraDServer = null)
        {
            var __workflow_activeDirectoryAddADUsername = WorkflowExpression.Compile(activeDirectoryAddADUsername, nameof(activeDirectoryAddADUsername), required: true);
            var __workflow_activeDirectoryAddADUserworkflow = WorkflowExpression.Compile(activeDirectoryAddADUserworkflow, nameof(activeDirectoryAddADUserworkflow), required: true);
            var __workflow_activeDirectoryAddADUseruserPrincipalName = WorkflowExpression.Compile(activeDirectoryAddADUseruserPrincipalName, nameof(activeDirectoryAddADUseruserPrincipalName), required: false);
            var __workflow_activeDirectoryAddADUsersamAccountName = WorkflowExpression.Compile(activeDirectoryAddADUsersamAccountName, nameof(activeDirectoryAddADUsersamAccountName), required: false);
            var __workflow_activeDirectoryAddADUsergivenName = WorkflowExpression.Compile(activeDirectoryAddADUsergivenName, nameof(activeDirectoryAddADUsergivenName), required: false);
            var __workflow_activeDirectoryAddADUsersurName = WorkflowExpression.Compile(activeDirectoryAddADUsersurName, nameof(activeDirectoryAddADUsersurName), required: false);
            var __workflow_activeDirectoryAddADUserpath = WorkflowExpression.Compile(activeDirectoryAddADUserpath, nameof(activeDirectoryAddADUserpath), required: false);
            var __workflow_activeDirectoryAddADUserdescription = WorkflowExpression.Compile(activeDirectoryAddADUserdescription, nameof(activeDirectoryAddADUserdescription), required: false);
            var __workflow_activeDirectoryAddADUserdisplayName = WorkflowExpression.Compile(activeDirectoryAddADUserdisplayName, nameof(activeDirectoryAddADUserdisplayName), required: false);
            var __workflow_activeDirectoryAddADUseraccountPassword = WorkflowExpression.Compile(activeDirectoryAddADUseraccountPassword, nameof(activeDirectoryAddADUseraccountPassword), required: false);
            var __workflow_activeDirectoryAddADUseraccountPasswordIsStoredPassword = WorkflowExpression.Compile(activeDirectoryAddADUseraccountPasswordIsStoredPassword, nameof(activeDirectoryAddADUseraccountPasswordIsStoredPassword), required: false);
            var __workflow_activeDirectoryAddADUserenabled = WorkflowExpression.Compile(activeDirectoryAddADUserenabled, nameof(activeDirectoryAddADUserenabled), required: false);
            var __workflow_activeDirectoryAddADUserchangePasswordAtLogon = WorkflowExpression.Compile(activeDirectoryAddADUserchangePasswordAtLogon, nameof(activeDirectoryAddADUserchangePasswordAtLogon), required: false);
            var __workflow_activeDirectoryAddADUsercannotChangePassword = WorkflowExpression.Compile(activeDirectoryAddADUsercannotChangePassword, nameof(activeDirectoryAddADUsercannotChangePassword), required: false);
            var __workflow_activeDirectoryAddADUserpasswordNeverExpires = WorkflowExpression.Compile(activeDirectoryAddADUserpasswordNeverExpires, nameof(activeDirectoryAddADUserpasswordNeverExpires), required: false);
            var __workflow_activeDirectoryAddADUseraDServer = WorkflowExpression.Compile(activeDirectoryAddADUseraDServer, nameof(activeDirectoryAddADUseraDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryAddADUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddADUser = new JObject();
                var activeDirectoryAddADUserpropCount = 0;
                activeDirectoryAddADUserpropCount++;
                activeDirectoryAddADUser["Name"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUsername);
                if (__workflow_activeDirectoryAddADUseruserPrincipalName != null)
                {
                    activeDirectoryAddADUser["UserPrincipalName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUseruserPrincipalName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (__workflow_activeDirectoryAddADUsersamAccountName != null)
                {
                    activeDirectoryAddADUser["SamAccountName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUsersamAccountName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (__workflow_activeDirectoryAddADUsergivenName != null)
                {
                    activeDirectoryAddADUser["GivenName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUsergivenName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (__workflow_activeDirectoryAddADUsersurName != null)
                {
                    activeDirectoryAddADUser["SurName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUsersurName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (__workflow_activeDirectoryAddADUserpath != null)
                {
                    activeDirectoryAddADUser["Path"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserpath);
                    activeDirectoryAddADUserpropCount++;
                }

                if (__workflow_activeDirectoryAddADUserdescription != null)
                {
                    activeDirectoryAddADUser["Description"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserdescription);
                    activeDirectoryAddADUserpropCount++;
                }

                if (__workflow_activeDirectoryAddADUserdisplayName != null)
                {
                    activeDirectoryAddADUser["DisplayName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserdisplayName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (__workflow_activeDirectoryAddADUseraccountPassword != null)
                {
                    activeDirectoryAddADUser["AccountPassword"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUseraccountPassword);
                    activeDirectoryAddADUserpropCount++;
                }

                if (__workflow_activeDirectoryAddADUseraccountPasswordIsStoredPassword != null)
                {
                    if (__workflow_activeDirectoryAddADUseraccountPasswordIsStoredPassword != null)
                    {
                        activeDirectoryAddADUser["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUseraccountPasswordIsStoredPassword);
                        activeDirectoryAddADUserpropCount++;
                    }

                    activeDirectoryAddADUserpropCount++;
                }
                else
                {
                    activeDirectoryAddADUser["AccountPasswordIsStoredPassword"] = false;
                    activeDirectoryAddADUserpropCount++;
                }

                if (__workflow_activeDirectoryAddADUserenabled != null)
                {
                    if (__workflow_activeDirectoryAddADUserenabled != null)
                    {
                        activeDirectoryAddADUser["Enabled"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserenabled);
                        activeDirectoryAddADUserpropCount++;
                    }

                    activeDirectoryAddADUserpropCount++;
                }
                else
                {
                    activeDirectoryAddADUser["Enabled"] = true;
                    activeDirectoryAddADUserpropCount++;
                }

                if (__workflow_activeDirectoryAddADUserchangePasswordAtLogon != null)
                {
                    if (__workflow_activeDirectoryAddADUserchangePasswordAtLogon != null)
                    {
                        activeDirectoryAddADUser["ChangePasswordAtLogon"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserchangePasswordAtLogon);
                        activeDirectoryAddADUserpropCount++;
                    }

                    activeDirectoryAddADUserpropCount++;
                }
                else
                {
                    activeDirectoryAddADUser["ChangePasswordAtLogon"] = true;
                    activeDirectoryAddADUserpropCount++;
                }

                if (__workflow_activeDirectoryAddADUsercannotChangePassword != null)
                {
                    if (__workflow_activeDirectoryAddADUsercannotChangePassword != null)
                    {
                        activeDirectoryAddADUser["CannotChangePassword"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUsercannotChangePassword);
                        activeDirectoryAddADUserpropCount++;
                    }

                    activeDirectoryAddADUserpropCount++;
                }
                else
                {
                    activeDirectoryAddADUser["CannotChangePassword"] = false;
                    activeDirectoryAddADUserpropCount++;
                }

                if (__workflow_activeDirectoryAddADUserpasswordNeverExpires != null)
                {
                    if (__workflow_activeDirectoryAddADUserpasswordNeverExpires != null)
                    {
                        activeDirectoryAddADUser["PasswordNeverExpires"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserpasswordNeverExpires);
                        activeDirectoryAddADUserpropCount++;
                    }

                    activeDirectoryAddADUserpropCount++;
                }
                else
                {
                    activeDirectoryAddADUser["PasswordNeverExpires"] = false;
                    activeDirectoryAddADUserpropCount++;
                }

                if (__workflow_activeDirectoryAddADUseraDServer != null)
                {
                    activeDirectoryAddADUser["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUseraDServer);
                    activeDirectoryAddADUserpropCount++;
                }

                activeDirectoryAddADUserpropCount++;
                activeDirectoryAddADUser["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserworkflow);
                if (activeDirectoryAddADUserpropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddADUser;
                }

                return new ApiConnectionAction<ActiveDirectoryAddADUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryGetADUserByIdentity(Expression<Func<string>> activeDirectoryGetADUserByIdentityworkflow, Expression<Func<string>> activeDirectoryGetADUserByIdentityidentity = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityfilterPropertyName = null, Expression<Func<activeDirectoryGetADUserByIdentityfilterPropertyComparisonInput>> activeDirectoryGetADUserByIdentityfilterPropertyComparison = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityfilterPropertyValue = null, Expression<Func<string>> activeDirectoryGetADUserByIdentitysearchOUBase = null, Expression<Func<bool>> activeDirectoryGetADUserByIdentitysearchOUBaseSubtree = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityproperties = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityaDServer = null, Expression<Func<string>> activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON = null, Expression<Func<string>> activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON = null, Expression<Func<string>> activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON = null)
        {
            var __workflow_activeDirectoryGetADUserByIdentityworkflow = WorkflowExpression.Compile(activeDirectoryGetADUserByIdentityworkflow, nameof(activeDirectoryGetADUserByIdentityworkflow), required: true);
            var __workflow_activeDirectoryGetADUserByIdentityidentity = WorkflowExpression.Compile(activeDirectoryGetADUserByIdentityidentity, nameof(activeDirectoryGetADUserByIdentityidentity), required: false);
            var __workflow_activeDirectoryGetADUserByIdentityfilterPropertyName = WorkflowExpression.Compile(activeDirectoryGetADUserByIdentityfilterPropertyName, nameof(activeDirectoryGetADUserByIdentityfilterPropertyName), required: false);
            var __workflow_activeDirectoryGetADUserByIdentityfilterPropertyComparison = WorkflowExpression.Compile(activeDirectoryGetADUserByIdentityfilterPropertyComparison, nameof(activeDirectoryGetADUserByIdentityfilterPropertyComparison), required: false);
            var __workflow_activeDirectoryGetADUserByIdentityfilterPropertyValue = WorkflowExpression.Compile(activeDirectoryGetADUserByIdentityfilterPropertyValue, nameof(activeDirectoryGetADUserByIdentityfilterPropertyValue), required: false);
            var __workflow_activeDirectoryGetADUserByIdentitysearchOUBase = WorkflowExpression.Compile(activeDirectoryGetADUserByIdentitysearchOUBase, nameof(activeDirectoryGetADUserByIdentitysearchOUBase), required: false);
            var __workflow_activeDirectoryGetADUserByIdentitysearchOUBaseSubtree = WorkflowExpression.Compile(activeDirectoryGetADUserByIdentitysearchOUBaseSubtree, nameof(activeDirectoryGetADUserByIdentitysearchOUBaseSubtree), required: false);
            var __workflow_activeDirectoryGetADUserByIdentityproperties = WorkflowExpression.Compile(activeDirectoryGetADUserByIdentityproperties, nameof(activeDirectoryGetADUserByIdentityproperties), required: false);
            var __workflow_activeDirectoryGetADUserByIdentityaDServer = WorkflowExpression.Compile(activeDirectoryGetADUserByIdentityaDServer, nameof(activeDirectoryGetADUserByIdentityaDServer), required: false);
            var __workflow_activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON = WorkflowExpression.Compile(activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON, nameof(activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON), required: false);
            var __workflow_activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON = WorkflowExpression.Compile(activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON, nameof(activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON), required: false);
            var __workflow_activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON = WorkflowExpression.Compile(activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON, nameof(activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON), required: false);
            return new DeferredBodyAction<ActiveDirectoryGetADUserByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetADUserByIdentity = new JObject();
                var activeDirectoryGetADUserByIdentitypropCount = 0;
                if (__workflow_activeDirectoryGetADUserByIdentityidentity != null)
                {
                    activeDirectoryGetADUserByIdentity["Identity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserByIdentityidentity);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADUserByIdentityfilterPropertyName != null)
                {
                    activeDirectoryGetADUserByIdentity["FilterPropertyName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserByIdentityfilterPropertyName);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADUserByIdentityfilterPropertyComparison != null)
                {
                    if (__workflow_activeDirectoryGetADUserByIdentityfilterPropertyComparison != null)
                    {
                        activeDirectoryGetADUserByIdentity["FilterPropertyComparison"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserByIdentityfilterPropertyComparison);
                        activeDirectoryGetADUserByIdentitypropCount++;
                    }

                    activeDirectoryGetADUserByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryGetADUserByIdentity["FilterPropertyComparison"] = "Equals";
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADUserByIdentityfilterPropertyValue != null)
                {
                    activeDirectoryGetADUserByIdentity["FilterPropertyValue"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserByIdentityfilterPropertyValue);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADUserByIdentitysearchOUBase != null)
                {
                    activeDirectoryGetADUserByIdentity["SearchOUBase"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserByIdentitysearchOUBase);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADUserByIdentitysearchOUBaseSubtree != null)
                {
                    if (__workflow_activeDirectoryGetADUserByIdentitysearchOUBaseSubtree != null)
                    {
                        activeDirectoryGetADUserByIdentity["SearchOUBaseSubtree"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserByIdentitysearchOUBaseSubtree);
                        activeDirectoryGetADUserByIdentitypropCount++;
                    }

                    activeDirectoryGetADUserByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryGetADUserByIdentity["SearchOUBaseSubtree"] = true;
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADUserByIdentityproperties != null)
                {
                    activeDirectoryGetADUserByIdentity["Properties"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserByIdentityproperties);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADUserByIdentityaDServer != null)
                {
                    activeDirectoryGetADUserByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserByIdentityaDServer);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON != null)
                {
                    activeDirectoryGetADUserByIdentity["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON != null)
                {
                    activeDirectoryGetADUserByIdentity["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON != null)
                {
                    activeDirectoryGetADUserByIdentity["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                activeDirectoryGetADUserByIdentitypropCount++;
                activeDirectoryGetADUserByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserByIdentityworkflow);
                if (activeDirectoryGetADUserByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetADUserByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryGetADUserByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetOUFromUserDNResponse, ApiConnectionActionConfiguration> ActiveDirectoryGetOUFromUserDN(Expression<Func<string>> activeDirectoryGetOUFromUserDNuserDN, Expression<Func<string>> activeDirectoryGetOUFromUserDNworkflow)
        {
            var __workflow_activeDirectoryGetOUFromUserDNuserDN = WorkflowExpression.Compile(activeDirectoryGetOUFromUserDNuserDN, nameof(activeDirectoryGetOUFromUserDNuserDN), required: true);
            var __workflow_activeDirectoryGetOUFromUserDNworkflow = WorkflowExpression.Compile(activeDirectoryGetOUFromUserDNworkflow, nameof(activeDirectoryGetOUFromUserDNworkflow), required: true);
            return new DeferredBodyAction<ActiveDirectoryGetOUFromUserDNResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetOUFromUserDN";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetOUFromUserDN = new JObject();
                var activeDirectoryGetOUFromUserDNpropCount = 0;
                activeDirectoryGetOUFromUserDNpropCount++;
                activeDirectoryGetOUFromUserDN["UserDN"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetOUFromUserDNuserDN);
                activeDirectoryGetOUFromUserDNpropCount++;
                activeDirectoryGetOUFromUserDN["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetOUFromUserDNworkflow);
                if (activeDirectoryGetOUFromUserDNpropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetOUFromUserDN;
                }

                return new ApiConnectionAction<ActiveDirectoryGetOUFromUserDNResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainFQDNFromDNResponse, ApiConnectionActionConfiguration> ActiveDirectoryGetDomainFQDNFromDN(Expression<Func<string>> activeDirectoryGetDomainFQDNFromDNdN, Expression<Func<string>> activeDirectoryGetDomainFQDNFromDNworkflow)
        {
            var __workflow_activeDirectoryGetDomainFQDNFromDNdN = WorkflowExpression.Compile(activeDirectoryGetDomainFQDNFromDNdN, nameof(activeDirectoryGetDomainFQDNFromDNdN), required: true);
            var __workflow_activeDirectoryGetDomainFQDNFromDNworkflow = WorkflowExpression.Compile(activeDirectoryGetDomainFQDNFromDNworkflow, nameof(activeDirectoryGetDomainFQDNFromDNworkflow), required: true);
            return new DeferredBodyAction<ActiveDirectoryGetDomainFQDNFromDNResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetDomainFQDNFromDN";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetDomainFQDNFromDN = new JObject();
                var activeDirectoryGetDomainFQDNFromDNpropCount = 0;
                activeDirectoryGetDomainFQDNFromDNpropCount++;
                activeDirectoryGetDomainFQDNFromDN["DN"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetDomainFQDNFromDNdN);
                activeDirectoryGetDomainFQDNFromDNpropCount++;
                activeDirectoryGetDomainFQDNFromDN["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetDomainFQDNFromDNworkflow);
                if (activeDirectoryGetDomainFQDNFromDNpropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetDomainFQDNFromDN;
                }

                return new ApiConnectionAction<ActiveDirectoryGetDomainFQDNFromDNResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryGetADGroupByIdentity(Expression<Func<string>> activeDirectoryGetADGroupByIdentityworkflow, Expression<Func<string>> activeDirectoryGetADGroupByIdentityidentity = null, Expression<Func<string>> activeDirectoryGetADGroupByIdentityfilterPropertyName = null, Expression<Func<activeDirectoryGetADGroupByIdentityfilterPropertyComparisonInput>> activeDirectoryGetADGroupByIdentityfilterPropertyComparison = null, Expression<Func<string>> activeDirectoryGetADGroupByIdentityfilterPropertyValue = null, Expression<Func<string>> activeDirectoryGetADGroupByIdentitysearchOUBase = null, Expression<Func<bool>> activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree = null, Expression<Func<bool>> activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist = null, Expression<Func<string>> activeDirectoryGetADGroupByIdentityaDServer = null)
        {
            var __workflow_activeDirectoryGetADGroupByIdentityworkflow = WorkflowExpression.Compile(activeDirectoryGetADGroupByIdentityworkflow, nameof(activeDirectoryGetADGroupByIdentityworkflow), required: true);
            var __workflow_activeDirectoryGetADGroupByIdentityidentity = WorkflowExpression.Compile(activeDirectoryGetADGroupByIdentityidentity, nameof(activeDirectoryGetADGroupByIdentityidentity), required: false);
            var __workflow_activeDirectoryGetADGroupByIdentityfilterPropertyName = WorkflowExpression.Compile(activeDirectoryGetADGroupByIdentityfilterPropertyName, nameof(activeDirectoryGetADGroupByIdentityfilterPropertyName), required: false);
            var __workflow_activeDirectoryGetADGroupByIdentityfilterPropertyComparison = WorkflowExpression.Compile(activeDirectoryGetADGroupByIdentityfilterPropertyComparison, nameof(activeDirectoryGetADGroupByIdentityfilterPropertyComparison), required: false);
            var __workflow_activeDirectoryGetADGroupByIdentityfilterPropertyValue = WorkflowExpression.Compile(activeDirectoryGetADGroupByIdentityfilterPropertyValue, nameof(activeDirectoryGetADGroupByIdentityfilterPropertyValue), required: false);
            var __workflow_activeDirectoryGetADGroupByIdentitysearchOUBase = WorkflowExpression.Compile(activeDirectoryGetADGroupByIdentitysearchOUBase, nameof(activeDirectoryGetADGroupByIdentitysearchOUBase), required: false);
            var __workflow_activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree = WorkflowExpression.Compile(activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree, nameof(activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree), required: false);
            var __workflow_activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist = WorkflowExpression.Compile(activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist, nameof(activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist), required: false);
            var __workflow_activeDirectoryGetADGroupByIdentityaDServer = WorkflowExpression.Compile(activeDirectoryGetADGroupByIdentityaDServer, nameof(activeDirectoryGetADGroupByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryGetADGroupByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADGroupByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetADGroupByIdentity = new JObject();
                var activeDirectoryGetADGroupByIdentitypropCount = 0;
                if (__workflow_activeDirectoryGetADGroupByIdentityidentity != null)
                {
                    activeDirectoryGetADGroupByIdentity["Identity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupByIdentityidentity);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADGroupByIdentityfilterPropertyName != null)
                {
                    activeDirectoryGetADGroupByIdentity["FilterPropertyName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupByIdentityfilterPropertyName);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADGroupByIdentityfilterPropertyComparison != null)
                {
                    if (__workflow_activeDirectoryGetADGroupByIdentityfilterPropertyComparison != null)
                    {
                        activeDirectoryGetADGroupByIdentity["FilterPropertyComparison"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupByIdentityfilterPropertyComparison);
                        activeDirectoryGetADGroupByIdentitypropCount++;
                    }

                    activeDirectoryGetADGroupByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryGetADGroupByIdentity["FilterPropertyComparison"] = "Equals";
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADGroupByIdentityfilterPropertyValue != null)
                {
                    activeDirectoryGetADGroupByIdentity["FilterPropertyValue"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupByIdentityfilterPropertyValue);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADGroupByIdentitysearchOUBase != null)
                {
                    activeDirectoryGetADGroupByIdentity["SearchOUBase"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupByIdentitysearchOUBase);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree != null)
                {
                    if (__workflow_activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree != null)
                    {
                        activeDirectoryGetADGroupByIdentity["SearchOUBaseSubtree"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree);
                        activeDirectoryGetADGroupByIdentitypropCount++;
                    }

                    activeDirectoryGetADGroupByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryGetADGroupByIdentity["SearchOUBaseSubtree"] = true;
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist != null)
                {
                    if (__workflow_activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist != null)
                    {
                        activeDirectoryGetADGroupByIdentity["RaiseExceptionIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist);
                        activeDirectoryGetADGroupByIdentitypropCount++;
                    }

                    activeDirectoryGetADGroupByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryGetADGroupByIdentity["RaiseExceptionIfGroupDoesNotExist"] = false;
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryGetADGroupByIdentityaDServer != null)
                {
                    activeDirectoryGetADGroupByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupByIdentityaDServer);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                activeDirectoryGetADGroupByIdentitypropCount++;
                activeDirectoryGetADGroupByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupByIdentityworkflow);
                if (activeDirectoryGetADGroupByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetADGroupByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryGetADGroupByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupMemberByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryAddADGroupMemberByIdentity(Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentityuserIdentity, Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentityworkflow, Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentitygroupIdentity = null, Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentitygroupName = null, Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentityaDServer = null)
        {
            var __workflow_activeDirectoryAddADGroupMemberByIdentityuserIdentity = WorkflowExpression.Compile(activeDirectoryAddADGroupMemberByIdentityuserIdentity, nameof(activeDirectoryAddADGroupMemberByIdentityuserIdentity), required: true);
            var __workflow_activeDirectoryAddADGroupMemberByIdentityworkflow = WorkflowExpression.Compile(activeDirectoryAddADGroupMemberByIdentityworkflow, nameof(activeDirectoryAddADGroupMemberByIdentityworkflow), required: true);
            var __workflow_activeDirectoryAddADGroupMemberByIdentitygroupIdentity = WorkflowExpression.Compile(activeDirectoryAddADGroupMemberByIdentitygroupIdentity, nameof(activeDirectoryAddADGroupMemberByIdentitygroupIdentity), required: false);
            var __workflow_activeDirectoryAddADGroupMemberByIdentitygroupName = WorkflowExpression.Compile(activeDirectoryAddADGroupMemberByIdentitygroupName, nameof(activeDirectoryAddADGroupMemberByIdentitygroupName), required: false);
            var __workflow_activeDirectoryAddADGroupMemberByIdentityaDServer = WorkflowExpression.Compile(activeDirectoryAddADGroupMemberByIdentityaDServer, nameof(activeDirectoryAddADGroupMemberByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryAddADGroupMemberByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADGroupMemberByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddADGroupMemberByIdentity = new JObject();
                var activeDirectoryAddADGroupMemberByIdentitypropCount = 0;
                if (__workflow_activeDirectoryAddADGroupMemberByIdentitygroupIdentity != null)
                {
                    activeDirectoryAddADGroupMemberByIdentity["GroupIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupMemberByIdentitygroupIdentity);
                    activeDirectoryAddADGroupMemberByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryAddADGroupMemberByIdentitygroupName != null)
                {
                    activeDirectoryAddADGroupMemberByIdentity["GroupName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupMemberByIdentitygroupName);
                    activeDirectoryAddADGroupMemberByIdentitypropCount++;
                }

                activeDirectoryAddADGroupMemberByIdentitypropCount++;
                activeDirectoryAddADGroupMemberByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupMemberByIdentityuserIdentity);
                if (__workflow_activeDirectoryAddADGroupMemberByIdentityaDServer != null)
                {
                    activeDirectoryAddADGroupMemberByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupMemberByIdentityaDServer);
                    activeDirectoryAddADGroupMemberByIdentitypropCount++;
                }

                activeDirectoryAddADGroupMemberByIdentitypropCount++;
                activeDirectoryAddADGroupMemberByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupMemberByIdentityworkflow);
                if (activeDirectoryAddADGroupMemberByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddADGroupMemberByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryAddADGroupMemberByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryAddMultipleADGroupMembersByIdentity(Expression<Func<string>> activeDirectoryAddMultipleADGroupMembersByIdentityworkflow, Expression<Func<string>> activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity = null, Expression<Func<string>> activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON = null, Expression<Func<bool>> activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd = null, Expression<Func<bool>> activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd = null, Expression<Func<bool>> activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall = null, Expression<Func<string>> activeDirectoryAddMultipleADGroupMembersByIdentityaDServer = null)
        {
            var __workflow_activeDirectoryAddMultipleADGroupMembersByIdentityworkflow = WorkflowExpression.Compile(activeDirectoryAddMultipleADGroupMembersByIdentityworkflow, nameof(activeDirectoryAddMultipleADGroupMembersByIdentityworkflow), required: true);
            var __workflow_activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity = WorkflowExpression.Compile(activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity, nameof(activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity), required: false);
            var __workflow_activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON = WorkflowExpression.Compile(activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON, nameof(activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON), required: false);
            var __workflow_activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd = WorkflowExpression.Compile(activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd, nameof(activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd), required: false);
            var __workflow_activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd = WorkflowExpression.Compile(activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd, nameof(activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd), required: false);
            var __workflow_activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall = WorkflowExpression.Compile(activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall, nameof(activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall), required: false);
            var __workflow_activeDirectoryAddMultipleADGroupMembersByIdentityaDServer = WorkflowExpression.Compile(activeDirectoryAddMultipleADGroupMembersByIdentityaDServer, nameof(activeDirectoryAddMultipleADGroupMembersByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddMultipleADGroupMembersByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddMultipleADGroupMembersByIdentity = new JObject();
                var activeDirectoryAddMultipleADGroupMembersByIdentitypropCount = 0;
                if (__workflow_activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity != null)
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["GroupIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity);
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON != null)
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["GroupMembersJSON"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON);
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd != null)
                {
                    if (__workflow_activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd != null)
                    {
                        activeDirectoryAddMultipleADGroupMembersByIdentity["ExceptionIfAnyMembersFailToAdd"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd);
                        activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                    }

                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["ExceptionIfAnyMembersFailToAdd"] = false;
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd != null)
                {
                    if (__workflow_activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd != null)
                    {
                        activeDirectoryAddMultipleADGroupMembersByIdentity["ExceptionIfAllMembersFailToAdd"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd);
                        activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                    }

                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["ExceptionIfAllMembersFailToAdd"] = false;
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall != null)
                {
                    if (__workflow_activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall != null)
                    {
                        activeDirectoryAddMultipleADGroupMembersByIdentity["AddAllMembersInASingleCall"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall);
                        activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                    }

                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["AddAllMembersInASingleCall"] = false;
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryAddMultipleADGroupMembersByIdentityaDServer != null)
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddMultipleADGroupMembersByIdentityaDServer);
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                activeDirectoryAddMultipleADGroupMembersByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddMultipleADGroupMembersByIdentityworkflow);
                if (activeDirectoryAddMultipleADGroupMembersByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddMultipleADGroupMembersByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse, ApiConnectionActionConfiguration> ActiveDirectoryAddADUserToMultipleADGroupsByName(Expression<Func<string>> activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity, Expression<Func<string>> activeDirectoryAddADUserToMultipleADGroupsByNameworkflow, Expression<Func<string>> activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON = null, Expression<Func<bool>> activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd = null, Expression<Func<bool>> activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd = null, Expression<Func<string>> activeDirectoryAddADUserToMultipleADGroupsByNameaDServer = null, Expression<Func<int>> activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall = null)
        {
            var __workflow_activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity = WorkflowExpression.Compile(activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity, nameof(activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity), required: true);
            var __workflow_activeDirectoryAddADUserToMultipleADGroupsByNameworkflow = WorkflowExpression.Compile(activeDirectoryAddADUserToMultipleADGroupsByNameworkflow, nameof(activeDirectoryAddADUserToMultipleADGroupsByNameworkflow), required: true);
            var __workflow_activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON = WorkflowExpression.Compile(activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON, nameof(activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON), required: false);
            var __workflow_activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd = WorkflowExpression.Compile(activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd, nameof(activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd), required: false);
            var __workflow_activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd = WorkflowExpression.Compile(activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd, nameof(activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd), required: false);
            var __workflow_activeDirectoryAddADUserToMultipleADGroupsByNameaDServer = WorkflowExpression.Compile(activeDirectoryAddADUserToMultipleADGroupsByNameaDServer, nameof(activeDirectoryAddADUserToMultipleADGroupsByNameaDServer), required: false);
            var __workflow_activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall = WorkflowExpression.Compile(activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall, nameof(activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall), required: false);
            return new DeferredBodyAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADUserToMultipleADGroupsByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddADUserToMultipleADGroupsByName = new JObject();
                var activeDirectoryAddADUserToMultipleADGroupsByNamepropCount = 0;
                activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                activeDirectoryAddADUserToMultipleADGroupsByName["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity);
                if (__workflow_activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON != null)
                {
                    activeDirectoryAddADUserToMultipleADGroupsByName["GroupNamesJSON"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON);
                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }

                if (__workflow_activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd != null)
                {
                    if (__workflow_activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd != null)
                    {
                        activeDirectoryAddADUserToMultipleADGroupsByName["ExceptionIfAnyGroupsFailToAdd"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd);
                        activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                    }

                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }
                else
                {
                    activeDirectoryAddADUserToMultipleADGroupsByName["ExceptionIfAnyGroupsFailToAdd"] = false;
                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }

                if (__workflow_activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd != null)
                {
                    if (__workflow_activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd != null)
                    {
                        activeDirectoryAddADUserToMultipleADGroupsByName["ExceptionIfAllGroupsFailToAdd"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd);
                        activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                    }

                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }
                else
                {
                    activeDirectoryAddADUserToMultipleADGroupsByName["ExceptionIfAllGroupsFailToAdd"] = false;
                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }

                if (__workflow_activeDirectoryAddADUserToMultipleADGroupsByNameaDServer != null)
                {
                    activeDirectoryAddADUserToMultipleADGroupsByName["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserToMultipleADGroupsByNameaDServer);
                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }

                if (__workflow_activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall != null)
                {
                    activeDirectoryAddADUserToMultipleADGroupsByName["MaxGroupsPerCall"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall);
                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }

                activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                activeDirectoryAddADUserToMultipleADGroupsByName["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserToMultipleADGroupsByNameworkflow);
                if (activeDirectoryAddADUserToMultipleADGroupsByNamepropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddADUserToMultipleADGroupsByName;
                }

                return new ApiConnectionAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserGroupMembershipResponse, ApiConnectionActionConfiguration> ActiveDirectoryGetADUserGroupMembership(Expression<Func<string>> activeDirectoryGetADUserGroupMembershipuserIdentity, Expression<Func<string>> activeDirectoryGetADUserGroupMembershipworkflow, Expression<Func<string>> activeDirectoryGetADUserGroupMembershipaDServer = null)
        {
            var __workflow_activeDirectoryGetADUserGroupMembershipuserIdentity = WorkflowExpression.Compile(activeDirectoryGetADUserGroupMembershipuserIdentity, nameof(activeDirectoryGetADUserGroupMembershipuserIdentity), required: true);
            var __workflow_activeDirectoryGetADUserGroupMembershipworkflow = WorkflowExpression.Compile(activeDirectoryGetADUserGroupMembershipworkflow, nameof(activeDirectoryGetADUserGroupMembershipworkflow), required: true);
            var __workflow_activeDirectoryGetADUserGroupMembershipaDServer = WorkflowExpression.Compile(activeDirectoryGetADUserGroupMembershipaDServer, nameof(activeDirectoryGetADUserGroupMembershipaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryGetADUserGroupMembershipResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADUserGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetADUserGroupMembership = new JObject();
                var activeDirectoryGetADUserGroupMembershippropCount = 0;
                activeDirectoryGetADUserGroupMembershippropCount++;
                activeDirectoryGetADUserGroupMembership["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserGroupMembershipuserIdentity);
                if (__workflow_activeDirectoryGetADUserGroupMembershipaDServer != null)
                {
                    activeDirectoryGetADUserGroupMembership["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserGroupMembershipaDServer);
                    activeDirectoryGetADUserGroupMembershippropCount++;
                }

                activeDirectoryGetADUserGroupMembershippropCount++;
                activeDirectoryGetADUserGroupMembership["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserGroupMembershipworkflow);
                if (activeDirectoryGetADUserGroupMembershippropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetADUserGroupMembership;
                }

                return new ApiConnectionAction<ActiveDirectoryGetADUserGroupMembershipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryModifyADUserStringPropertyByIdentity(Expression<Func<string>> activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity, Expression<Func<string>> activeDirectoryModifyADUserStringPropertyByIdentityworkflow, Expression<Func<activeDirectoryModifyADUserStringPropertyByIdentitypropertiesListInputItem[]>> activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList = null, Expression<Func<string>> activeDirectoryModifyADUserStringPropertyByIdentityaDServer = null, Expression<Func<bool>> activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue = null)
        {
            var __workflow_activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity = WorkflowExpression.Compile(activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity, nameof(activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity), required: true);
            var __workflow_activeDirectoryModifyADUserStringPropertyByIdentityworkflow = WorkflowExpression.Compile(activeDirectoryModifyADUserStringPropertyByIdentityworkflow, nameof(activeDirectoryModifyADUserStringPropertyByIdentityworkflow), required: true);
            var __workflow_activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList = WorkflowExpression.Compile(activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList, nameof(activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList), required: false);
            var __workflow_activeDirectoryModifyADUserStringPropertyByIdentityaDServer = WorkflowExpression.Compile(activeDirectoryModifyADUserStringPropertyByIdentityaDServer, nameof(activeDirectoryModifyADUserStringPropertyByIdentityaDServer), required: false);
            var __workflow_activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue = WorkflowExpression.Compile(activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue, nameof(activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue), required: false);
            return new DeferredBodyAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserStringPropertyByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryModifyADUserStringPropertyByIdentity = new JObject();
                var activeDirectoryModifyADUserStringPropertyByIdentitypropCount = 0;
                activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
                activeDirectoryModifyADUserStringPropertyByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity);
                if (__workflow_activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList != null)
                {
                    activeDirectoryModifyADUserStringPropertyByIdentity["PropertiesList"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList);
                    activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserStringPropertyByIdentityaDServer != null)
                {
                    activeDirectoryModifyADUserStringPropertyByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserStringPropertyByIdentityaDServer);
                    activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue != null)
                {
                    if (__workflow_activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue != null)
                    {
                        activeDirectoryModifyADUserStringPropertyByIdentity["ReplaceValue"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue);
                        activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
                    }

                    activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryModifyADUserStringPropertyByIdentity["ReplaceValue"] = true;
                    activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
                }

                activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
                activeDirectoryModifyADUserStringPropertyByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserStringPropertyByIdentityworkflow);
                if (activeDirectoryModifyADUserStringPropertyByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryModifyADUserStringPropertyByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryModifyADUserBooleanPropertyByIdentity(Expression<Func<string>> activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity, Expression<Func<string>> activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName, Expression<Func<string>> activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow, Expression<Func<bool>> activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue = null, Expression<Func<string>> activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer = null)
        {
            var __workflow_activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity = WorkflowExpression.Compile(activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity, nameof(activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity), required: true);
            var __workflow_activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName = WorkflowExpression.Compile(activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName, nameof(activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName), required: true);
            var __workflow_activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow = WorkflowExpression.Compile(activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow, nameof(activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow), required: true);
            var __workflow_activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue = WorkflowExpression.Compile(activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue, nameof(activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue), required: false);
            var __workflow_activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer = WorkflowExpression.Compile(activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer, nameof(activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserBooleanPropertyByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryModifyADUserBooleanPropertyByIdentity = new JObject();
                var activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount = 0;
                activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                activeDirectoryModifyADUserBooleanPropertyByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity);
                activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                activeDirectoryModifyADUserBooleanPropertyByIdentity["PropertyName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName);
                if (__workflow_activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue != null)
                {
                    if (__workflow_activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue != null)
                    {
                        activeDirectoryModifyADUserBooleanPropertyByIdentity["PropertyValue"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue);
                        activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                    }

                    activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryModifyADUserBooleanPropertyByIdentity["PropertyValue"] = false;
                    activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer != null)
                {
                    activeDirectoryModifyADUserBooleanPropertyByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer);
                    activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                }

                activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                activeDirectoryModifyADUserBooleanPropertyByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow);
                if (activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryModifyADUserBooleanPropertyByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserPropertiesResponse, ApiConnectionActionConfiguration> ActiveDirectoryModifyADUserProperties(Expression<Func<string>> activeDirectoryModifyADUserPropertiesuserIdentity, Expression<Func<string>> activeDirectoryModifyADUserPropertiesworkflow, Expression<Func<string>> activeDirectoryModifyADUserPropertiescity = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiescompany = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiescountry = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiescountryString = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiescountryISO3166 = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesdepartment = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesdescription = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesdisplayName = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesemailAddress = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesgivenName = null, Expression<Func<string>> activeDirectoryModifyADUserPropertieshomePhone = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesinitials = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesiPPhone = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesmanager = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesmobilePhone = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesnotes = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesoffice = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesofficePhone = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiespostalCode = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesprofilePath = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesscriptPath = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesstate = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesstreetAddress = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiessurname = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiestitle = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesaDServer = null)
        {
            var __workflow_activeDirectoryModifyADUserPropertiesuserIdentity = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesuserIdentity, nameof(activeDirectoryModifyADUserPropertiesuserIdentity), required: true);
            var __workflow_activeDirectoryModifyADUserPropertiesworkflow = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesworkflow, nameof(activeDirectoryModifyADUserPropertiesworkflow), required: true);
            var __workflow_activeDirectoryModifyADUserPropertiescity = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiescity, nameof(activeDirectoryModifyADUserPropertiescity), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiescompany = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiescompany, nameof(activeDirectoryModifyADUserPropertiescompany), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiescountry = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiescountry, nameof(activeDirectoryModifyADUserPropertiescountry), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiescountryString = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiescountryString, nameof(activeDirectoryModifyADUserPropertiescountryString), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiescountryISO3166 = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiescountryISO3166, nameof(activeDirectoryModifyADUserPropertiescountryISO3166), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesdepartment = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesdepartment, nameof(activeDirectoryModifyADUserPropertiesdepartment), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesdescription = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesdescription, nameof(activeDirectoryModifyADUserPropertiesdescription), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesdisplayName = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesdisplayName, nameof(activeDirectoryModifyADUserPropertiesdisplayName), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesemailAddress = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesemailAddress, nameof(activeDirectoryModifyADUserPropertiesemailAddress), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesgivenName = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesgivenName, nameof(activeDirectoryModifyADUserPropertiesgivenName), required: false);
            var __workflow_activeDirectoryModifyADUserPropertieshomePhone = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertieshomePhone, nameof(activeDirectoryModifyADUserPropertieshomePhone), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesinitials = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesinitials, nameof(activeDirectoryModifyADUserPropertiesinitials), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesiPPhone = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesiPPhone, nameof(activeDirectoryModifyADUserPropertiesiPPhone), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesmanager = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesmanager, nameof(activeDirectoryModifyADUserPropertiesmanager), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesmobilePhone = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesmobilePhone, nameof(activeDirectoryModifyADUserPropertiesmobilePhone), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesnotes = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesnotes, nameof(activeDirectoryModifyADUserPropertiesnotes), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesoffice = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesoffice, nameof(activeDirectoryModifyADUserPropertiesoffice), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesofficePhone = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesofficePhone, nameof(activeDirectoryModifyADUserPropertiesofficePhone), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiespostalCode = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiespostalCode, nameof(activeDirectoryModifyADUserPropertiespostalCode), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesprofilePath = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesprofilePath, nameof(activeDirectoryModifyADUserPropertiesprofilePath), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesscriptPath = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesscriptPath, nameof(activeDirectoryModifyADUserPropertiesscriptPath), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesstate = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesstate, nameof(activeDirectoryModifyADUserPropertiesstate), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesstreetAddress = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesstreetAddress, nameof(activeDirectoryModifyADUserPropertiesstreetAddress), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiessurname = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiessurname, nameof(activeDirectoryModifyADUserPropertiessurname), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiestitle = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiestitle, nameof(activeDirectoryModifyADUserPropertiestitle), required: false);
            var __workflow_activeDirectoryModifyADUserPropertiesaDServer = WorkflowExpression.Compile(activeDirectoryModifyADUserPropertiesaDServer, nameof(activeDirectoryModifyADUserPropertiesaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryModifyADUserPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryModifyADUserProperties = new JObject();
                var activeDirectoryModifyADUserPropertiespropCount = 0;
                activeDirectoryModifyADUserPropertiespropCount++;
                activeDirectoryModifyADUserProperties["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesuserIdentity);
                if (__workflow_activeDirectoryModifyADUserPropertiescity != null)
                {
                    activeDirectoryModifyADUserProperties["City"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiescity);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiescompany != null)
                {
                    activeDirectoryModifyADUserProperties["Company"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiescompany);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiescountry != null)
                {
                    activeDirectoryModifyADUserProperties["Country"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiescountry);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiescountryString != null)
                {
                    activeDirectoryModifyADUserProperties["CountryString"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiescountryString);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiescountryISO3166 != null)
                {
                    activeDirectoryModifyADUserProperties["CountryISO3166"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiescountryISO3166);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesdepartment != null)
                {
                    activeDirectoryModifyADUserProperties["Department"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesdepartment);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesdescription != null)
                {
                    activeDirectoryModifyADUserProperties["Description"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesdescription);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesdisplayName != null)
                {
                    activeDirectoryModifyADUserProperties["DisplayName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesdisplayName);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesemailAddress != null)
                {
                    activeDirectoryModifyADUserProperties["EmailAddress"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesemailAddress);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesgivenName != null)
                {
                    activeDirectoryModifyADUserProperties["GivenName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesgivenName);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertieshomePhone != null)
                {
                    activeDirectoryModifyADUserProperties["HomePhone"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertieshomePhone);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesinitials != null)
                {
                    activeDirectoryModifyADUserProperties["Initials"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesinitials);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesiPPhone != null)
                {
                    activeDirectoryModifyADUserProperties["IPPhone"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesiPPhone);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesmanager != null)
                {
                    activeDirectoryModifyADUserProperties["Manager"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesmanager);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesmobilePhone != null)
                {
                    activeDirectoryModifyADUserProperties["MobilePhone"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesmobilePhone);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesnotes != null)
                {
                    activeDirectoryModifyADUserProperties["Notes"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesnotes);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesoffice != null)
                {
                    activeDirectoryModifyADUserProperties["Office"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesoffice);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesofficePhone != null)
                {
                    activeDirectoryModifyADUserProperties["OfficePhone"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesofficePhone);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiespostalCode != null)
                {
                    activeDirectoryModifyADUserProperties["PostalCode"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiespostalCode);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesprofilePath != null)
                {
                    activeDirectoryModifyADUserProperties["ProfilePath"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesprofilePath);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesscriptPath != null)
                {
                    activeDirectoryModifyADUserProperties["ScriptPath"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesscriptPath);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesstate != null)
                {
                    activeDirectoryModifyADUserProperties["State"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesstate);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesstreetAddress != null)
                {
                    activeDirectoryModifyADUserProperties["StreetAddress"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesstreetAddress);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiessurname != null)
                {
                    activeDirectoryModifyADUserProperties["Surname"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiessurname);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiestitle != null)
                {
                    activeDirectoryModifyADUserProperties["Title"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiestitle);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (__workflow_activeDirectoryModifyADUserPropertiesaDServer != null)
                {
                    activeDirectoryModifyADUserProperties["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesaDServer);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                activeDirectoryModifyADUserPropertiespropCount++;
                activeDirectoryModifyADUserProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserPropertiesworkflow);
                if (activeDirectoryModifyADUserPropertiespropCount > 0)
                {
                    callPayload.Body = activeDirectoryModifyADUserProperties;
                }

                return new ApiConnectionAction<ActiveDirectoryModifyADUserPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryMoveADUserToOUByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryMoveADUserToOUByIdentity(Expression<Func<string>> activeDirectoryMoveADUserToOUByIdentityuserIdentity, Expression<Func<string>> activeDirectoryMoveADUserToOUByIdentitytargetPath, Expression<Func<string>> activeDirectoryMoveADUserToOUByIdentityworkflow, Expression<Func<string>> activeDirectoryMoveADUserToOUByIdentityaDServer = null)
        {
            var __workflow_activeDirectoryMoveADUserToOUByIdentityuserIdentity = WorkflowExpression.Compile(activeDirectoryMoveADUserToOUByIdentityuserIdentity, nameof(activeDirectoryMoveADUserToOUByIdentityuserIdentity), required: true);
            var __workflow_activeDirectoryMoveADUserToOUByIdentitytargetPath = WorkflowExpression.Compile(activeDirectoryMoveADUserToOUByIdentitytargetPath, nameof(activeDirectoryMoveADUserToOUByIdentitytargetPath), required: true);
            var __workflow_activeDirectoryMoveADUserToOUByIdentityworkflow = WorkflowExpression.Compile(activeDirectoryMoveADUserToOUByIdentityworkflow, nameof(activeDirectoryMoveADUserToOUByIdentityworkflow), required: true);
            var __workflow_activeDirectoryMoveADUserToOUByIdentityaDServer = WorkflowExpression.Compile(activeDirectoryMoveADUserToOUByIdentityaDServer, nameof(activeDirectoryMoveADUserToOUByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryMoveADUserToOUByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryMoveADUserToOUByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryMoveADUserToOUByIdentity = new JObject();
                var activeDirectoryMoveADUserToOUByIdentitypropCount = 0;
                activeDirectoryMoveADUserToOUByIdentitypropCount++;
                activeDirectoryMoveADUserToOUByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryMoveADUserToOUByIdentityuserIdentity);
                activeDirectoryMoveADUserToOUByIdentitypropCount++;
                activeDirectoryMoveADUserToOUByIdentity["TargetPath"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryMoveADUserToOUByIdentitytargetPath);
                if (__workflow_activeDirectoryMoveADUserToOUByIdentityaDServer != null)
                {
                    activeDirectoryMoveADUserToOUByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryMoveADUserToOUByIdentityaDServer);
                    activeDirectoryMoveADUserToOUByIdentitypropCount++;
                }

                activeDirectoryMoveADUserToOUByIdentitypropCount++;
                activeDirectoryMoveADUserToOUByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryMoveADUserToOUByIdentityworkflow);
                if (activeDirectoryMoveADUserToOUByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryMoveADUserToOUByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryMoveADUserToOUByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryClearADUserAccountExpirationResponse, ApiConnectionActionConfiguration> ActiveDirectoryClearADUserAccountExpiration(Expression<Func<string>> activeDirectoryClearADUserAccountExpirationuserIdentity, Expression<Func<string>> activeDirectoryClearADUserAccountExpirationworkflow, Expression<Func<string>> activeDirectoryClearADUserAccountExpirationaDServer = null)
        {
            var __workflow_activeDirectoryClearADUserAccountExpirationuserIdentity = WorkflowExpression.Compile(activeDirectoryClearADUserAccountExpirationuserIdentity, nameof(activeDirectoryClearADUserAccountExpirationuserIdentity), required: true);
            var __workflow_activeDirectoryClearADUserAccountExpirationworkflow = WorkflowExpression.Compile(activeDirectoryClearADUserAccountExpirationworkflow, nameof(activeDirectoryClearADUserAccountExpirationworkflow), required: true);
            var __workflow_activeDirectoryClearADUserAccountExpirationaDServer = WorkflowExpression.Compile(activeDirectoryClearADUserAccountExpirationaDServer, nameof(activeDirectoryClearADUserAccountExpirationaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryClearADUserAccountExpirationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryClearADUserAccountExpiration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryClearADUserAccountExpiration = new JObject();
                var activeDirectoryClearADUserAccountExpirationpropCount = 0;
                activeDirectoryClearADUserAccountExpirationpropCount++;
                activeDirectoryClearADUserAccountExpiration["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryClearADUserAccountExpirationuserIdentity);
                if (__workflow_activeDirectoryClearADUserAccountExpirationaDServer != null)
                {
                    activeDirectoryClearADUserAccountExpiration["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryClearADUserAccountExpirationaDServer);
                    activeDirectoryClearADUserAccountExpirationpropCount++;
                }

                activeDirectoryClearADUserAccountExpirationpropCount++;
                activeDirectoryClearADUserAccountExpiration["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryClearADUserAccountExpirationworkflow);
                if (activeDirectoryClearADUserAccountExpirationpropCount > 0)
                {
                    callPayload.Body = activeDirectoryClearADUserAccountExpiration;
                }

                return new ApiConnectionAction<ActiveDirectoryClearADUserAccountExpirationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDirSyncResponse, ApiConnectionActionConfiguration> ActiveDirectoryDirSync(Expression<Func<string>> activeDirectoryDirSyncworkflow, Expression<Func<activeDirectoryDirSyncpolicyTypeInput>> activeDirectoryDirSyncpolicyType = null, Expression<Func<string>> activeDirectoryDirSynccomputerName = null, Expression<Func<int>> activeDirectoryDirSyncmaxRetryAttempts = null, Expression<Func<int>> activeDirectoryDirSyncsecondsBetweenRetries = null)
        {
            var __workflow_activeDirectoryDirSyncworkflow = WorkflowExpression.Compile(activeDirectoryDirSyncworkflow, nameof(activeDirectoryDirSyncworkflow), required: true);
            var __workflow_activeDirectoryDirSyncpolicyType = WorkflowExpression.Compile(activeDirectoryDirSyncpolicyType, nameof(activeDirectoryDirSyncpolicyType), required: false);
            var __workflow_activeDirectoryDirSynccomputerName = WorkflowExpression.Compile(activeDirectoryDirSynccomputerName, nameof(activeDirectoryDirSynccomputerName), required: false);
            var __workflow_activeDirectoryDirSyncmaxRetryAttempts = WorkflowExpression.Compile(activeDirectoryDirSyncmaxRetryAttempts, nameof(activeDirectoryDirSyncmaxRetryAttempts), required: false);
            var __workflow_activeDirectoryDirSyncsecondsBetweenRetries = WorkflowExpression.Compile(activeDirectoryDirSyncsecondsBetweenRetries, nameof(activeDirectoryDirSyncsecondsBetweenRetries), required: false);
            return new DeferredBodyAction<ActiveDirectoryDirSyncResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDirSync";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryDirSync = new JObject();
                var activeDirectoryDirSyncpropCount = 0;
                if (__workflow_activeDirectoryDirSyncpolicyType != null)
                {
                    activeDirectoryDirSync["PolicyType"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryDirSyncpolicyType);
                    activeDirectoryDirSyncpropCount++;
                }

                if (__workflow_activeDirectoryDirSynccomputerName != null)
                {
                    activeDirectoryDirSync["ComputerName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryDirSynccomputerName);
                    activeDirectoryDirSyncpropCount++;
                }

                if (__workflow_activeDirectoryDirSyncmaxRetryAttempts != null)
                {
                    if (__workflow_activeDirectoryDirSyncmaxRetryAttempts != null)
                    {
                        activeDirectoryDirSync["MaxRetryAttempts"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryDirSyncmaxRetryAttempts);
                        activeDirectoryDirSyncpropCount++;
                    }

                    activeDirectoryDirSyncpropCount++;
                }
                else
                {
                    activeDirectoryDirSync["MaxRetryAttempts"] = 3;
                    activeDirectoryDirSyncpropCount++;
                }

                if (__workflow_activeDirectoryDirSyncsecondsBetweenRetries != null)
                {
                    if (__workflow_activeDirectoryDirSyncsecondsBetweenRetries != null)
                    {
                        activeDirectoryDirSync["SecondsBetweenRetries"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryDirSyncsecondsBetweenRetries);
                        activeDirectoryDirSyncpropCount++;
                    }

                    activeDirectoryDirSyncpropCount++;
                }
                else
                {
                    activeDirectoryDirSync["SecondsBetweenRetries"] = 10;
                    activeDirectoryDirSyncpropCount++;
                }

                activeDirectoryDirSyncpropCount++;
                activeDirectoryDirSync["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryDirSyncworkflow);
                if (activeDirectoryDirSyncpropCount > 0)
                {
                    callPayload.Body = activeDirectoryDirSync;
                }

                return new ApiConnectionAction<ActiveDirectoryDirSyncResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryRemoveADUserByIdentity(Expression<Func<string>> activeDirectoryRemoveADUserByIdentityuserIdentity, Expression<Func<string>> activeDirectoryRemoveADUserByIdentityworkflow, Expression<Func<bool>> activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion = null, Expression<Func<bool>> activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects = null, Expression<Func<bool>> activeDirectoryRemoveADUserByIdentityforceDeleteRecursive = null, Expression<Func<string>> activeDirectoryRemoveADUserByIdentityaDServer = null)
        {
            var __workflow_activeDirectoryRemoveADUserByIdentityuserIdentity = WorkflowExpression.Compile(activeDirectoryRemoveADUserByIdentityuserIdentity, nameof(activeDirectoryRemoveADUserByIdentityuserIdentity), required: true);
            var __workflow_activeDirectoryRemoveADUserByIdentityworkflow = WorkflowExpression.Compile(activeDirectoryRemoveADUserByIdentityworkflow, nameof(activeDirectoryRemoveADUserByIdentityworkflow), required: true);
            var __workflow_activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion = WorkflowExpression.Compile(activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion, nameof(activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion), required: false);
            var __workflow_activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects = WorkflowExpression.Compile(activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects, nameof(activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects), required: false);
            var __workflow_activeDirectoryRemoveADUserByIdentityforceDeleteRecursive = WorkflowExpression.Compile(activeDirectoryRemoveADUserByIdentityforceDeleteRecursive, nameof(activeDirectoryRemoveADUserByIdentityforceDeleteRecursive), required: false);
            var __workflow_activeDirectoryRemoveADUserByIdentityaDServer = WorkflowExpression.Compile(activeDirectoryRemoveADUserByIdentityaDServer, nameof(activeDirectoryRemoveADUserByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryRemoveADUserByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADUserByIdentity = new JObject();
                var activeDirectoryRemoveADUserByIdentitypropCount = 0;
                activeDirectoryRemoveADUserByIdentitypropCount++;
                activeDirectoryRemoveADUserByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserByIdentityuserIdentity);
                if (__workflow_activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion != null)
                {
                    if (__workflow_activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion != null)
                    {
                        activeDirectoryRemoveADUserByIdentity["RemoveProtectionFromAccidentalDeletion"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion);
                        activeDirectoryRemoveADUserByIdentitypropCount++;
                    }

                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserByIdentity["RemoveProtectionFromAccidentalDeletion"] = false;
                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects != null)
                {
                    if (__workflow_activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects != null)
                    {
                        activeDirectoryRemoveADUserByIdentity["DeleteEvenIfUserHasSubObjects"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects);
                        activeDirectoryRemoveADUserByIdentitypropCount++;
                    }

                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserByIdentity["DeleteEvenIfUserHasSubObjects"] = false;
                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryRemoveADUserByIdentityforceDeleteRecursive != null)
                {
                    if (__workflow_activeDirectoryRemoveADUserByIdentityforceDeleteRecursive != null)
                    {
                        activeDirectoryRemoveADUserByIdentity["ForceDeleteRecursive"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserByIdentityforceDeleteRecursive);
                        activeDirectoryRemoveADUserByIdentitypropCount++;
                    }

                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserByIdentity["ForceDeleteRecursive"] = false;
                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryRemoveADUserByIdentityaDServer != null)
                {
                    activeDirectoryRemoveADUserByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserByIdentityaDServer);
                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }

                activeDirectoryRemoveADUserByIdentitypropCount++;
                activeDirectoryRemoveADUserByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserByIdentityworkflow);
                if (activeDirectoryRemoveADUserByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADUserByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryRemoveADUserByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryResetADUserPasswordByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryResetADUserPasswordByIdentity(Expression<Func<string>> activeDirectoryResetADUserPasswordByIdentityuserIdentity, Expression<Func<string>> activeDirectoryResetADUserPasswordByIdentitynewPassword, Expression<Func<string>> activeDirectoryResetADUserPasswordByIdentityworkflow, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentitycannotChangePassword = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice = null, Expression<Func<string>> activeDirectoryResetADUserPasswordByIdentityaDServer = null)
        {
            var __workflow_activeDirectoryResetADUserPasswordByIdentityuserIdentity = WorkflowExpression.Compile(activeDirectoryResetADUserPasswordByIdentityuserIdentity, nameof(activeDirectoryResetADUserPasswordByIdentityuserIdentity), required: true);
            var __workflow_activeDirectoryResetADUserPasswordByIdentitynewPassword = WorkflowExpression.Compile(activeDirectoryResetADUserPasswordByIdentitynewPassword, nameof(activeDirectoryResetADUserPasswordByIdentitynewPassword), required: true);
            var __workflow_activeDirectoryResetADUserPasswordByIdentityworkflow = WorkflowExpression.Compile(activeDirectoryResetADUserPasswordByIdentityworkflow, nameof(activeDirectoryResetADUserPasswordByIdentityworkflow), required: true);
            var __workflow_activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword = WorkflowExpression.Compile(activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword, nameof(activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword), required: false);
            var __workflow_activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties = WorkflowExpression.Compile(activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties, nameof(activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties), required: false);
            var __workflow_activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon = WorkflowExpression.Compile(activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon, nameof(activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon), required: false);
            var __workflow_activeDirectoryResetADUserPasswordByIdentitycannotChangePassword = WorkflowExpression.Compile(activeDirectoryResetADUserPasswordByIdentitycannotChangePassword, nameof(activeDirectoryResetADUserPasswordByIdentitycannotChangePassword), required: false);
            var __workflow_activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires = WorkflowExpression.Compile(activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires, nameof(activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires), required: false);
            var __workflow_activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice = WorkflowExpression.Compile(activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice, nameof(activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice), required: false);
            var __workflow_activeDirectoryResetADUserPasswordByIdentityaDServer = WorkflowExpression.Compile(activeDirectoryResetADUserPasswordByIdentityaDServer, nameof(activeDirectoryResetADUserPasswordByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryResetADUserPasswordByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryResetADUserPasswordByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryResetADUserPasswordByIdentity = new JObject();
                var activeDirectoryResetADUserPasswordByIdentitypropCount = 0;
                activeDirectoryResetADUserPasswordByIdentitypropCount++;
                activeDirectoryResetADUserPasswordByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryResetADUserPasswordByIdentityuserIdentity);
                activeDirectoryResetADUserPasswordByIdentitypropCount++;
                activeDirectoryResetADUserPasswordByIdentity["NewPassword"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryResetADUserPasswordByIdentitynewPassword);
                if (__workflow_activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword != null)
                {
                    if (__workflow_activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword != null)
                    {
                        activeDirectoryResetADUserPasswordByIdentity["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword);
                        activeDirectoryResetADUserPasswordByIdentitypropCount++;
                    }

                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryResetADUserPasswordByIdentity["AccountPasswordIsStoredPassword"] = false;
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties != null)
                {
                    if (__workflow_activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties != null)
                    {
                        activeDirectoryResetADUserPasswordByIdentity["SetUserPasswordProperties"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties);
                        activeDirectoryResetADUserPasswordByIdentitypropCount++;
                    }

                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryResetADUserPasswordByIdentity["SetUserPasswordProperties"] = true;
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon != null)
                {
                    if (__workflow_activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon != null)
                    {
                        activeDirectoryResetADUserPasswordByIdentity["ChangePasswordAtLogon"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon);
                        activeDirectoryResetADUserPasswordByIdentitypropCount++;
                    }

                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryResetADUserPasswordByIdentity["ChangePasswordAtLogon"] = true;
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryResetADUserPasswordByIdentitycannotChangePassword != null)
                {
                    if (__workflow_activeDirectoryResetADUserPasswordByIdentitycannotChangePassword != null)
                    {
                        activeDirectoryResetADUserPasswordByIdentity["CannotChangePassword"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryResetADUserPasswordByIdentitycannotChangePassword);
                        activeDirectoryResetADUserPasswordByIdentitypropCount++;
                    }

                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryResetADUserPasswordByIdentity["CannotChangePassword"] = false;
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires != null)
                {
                    if (__workflow_activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires != null)
                    {
                        activeDirectoryResetADUserPasswordByIdentity["PasswordNeverExpires"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires);
                        activeDirectoryResetADUserPasswordByIdentitypropCount++;
                    }

                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryResetADUserPasswordByIdentity["PasswordNeverExpires"] = false;
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice != null)
                {
                    if (__workflow_activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice != null)
                    {
                        activeDirectoryResetADUserPasswordByIdentity["ResetPasswordTwice"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice);
                        activeDirectoryResetADUserPasswordByIdentitypropCount++;
                    }

                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryResetADUserPasswordByIdentity["ResetPasswordTwice"] = false;
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryResetADUserPasswordByIdentityaDServer != null)
                {
                    activeDirectoryResetADUserPasswordByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryResetADUserPasswordByIdentityaDServer);
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                activeDirectoryResetADUserPasswordByIdentitypropCount++;
                activeDirectoryResetADUserPasswordByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryResetADUserPasswordByIdentityworkflow);
                if (activeDirectoryResetADUserPasswordByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryResetADUserPasswordByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryResetADUserPasswordByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity(Expression<Func<string>> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity, Expression<Func<bool>> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion, Expression<Func<string>> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow, Expression<Func<string>> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer = null)
        {
            var __workflow_activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity = WorkflowExpression.Compile(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity, nameof(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity), required: true);
            var __workflow_activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion = WorkflowExpression.Compile(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion, nameof(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion), required: true);
            var __workflow_activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow = WorkflowExpression.Compile(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow, nameof(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow), required: true);
            var __workflow_activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer = WorkflowExpression.Compile(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer, nameof(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity = new JObject();
                var activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount = 0;
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity);
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["ProtectedFromAccidentalDeletion"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion);
                if (__workflow_activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer != null)
                {
                    activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer);
                    activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
                }

                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow);
                if (activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDisableADUserByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryDisableADUserByIdentity(Expression<Func<string>> activeDirectoryDisableADUserByIdentityuserIdentity, Expression<Func<string>> activeDirectoryDisableADUserByIdentityworkflow, Expression<Func<string>> activeDirectoryDisableADUserByIdentityaDServer = null)
        {
            var __workflow_activeDirectoryDisableADUserByIdentityuserIdentity = WorkflowExpression.Compile(activeDirectoryDisableADUserByIdentityuserIdentity, nameof(activeDirectoryDisableADUserByIdentityuserIdentity), required: true);
            var __workflow_activeDirectoryDisableADUserByIdentityworkflow = WorkflowExpression.Compile(activeDirectoryDisableADUserByIdentityworkflow, nameof(activeDirectoryDisableADUserByIdentityworkflow), required: true);
            var __workflow_activeDirectoryDisableADUserByIdentityaDServer = WorkflowExpression.Compile(activeDirectoryDisableADUserByIdentityaDServer, nameof(activeDirectoryDisableADUserByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryDisableADUserByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDisableADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryDisableADUserByIdentity = new JObject();
                var activeDirectoryDisableADUserByIdentitypropCount = 0;
                activeDirectoryDisableADUserByIdentitypropCount++;
                activeDirectoryDisableADUserByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryDisableADUserByIdentityuserIdentity);
                if (__workflow_activeDirectoryDisableADUserByIdentityaDServer != null)
                {
                    activeDirectoryDisableADUserByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryDisableADUserByIdentityaDServer);
                    activeDirectoryDisableADUserByIdentitypropCount++;
                }

                activeDirectoryDisableADUserByIdentitypropCount++;
                activeDirectoryDisableADUserByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryDisableADUserByIdentityworkflow);
                if (activeDirectoryDisableADUserByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryDisableADUserByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryDisableADUserByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryEnableADUserByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryEnableADUserByIdentity(Expression<Func<string>> activeDirectoryEnableADUserByIdentityuserIdentity, Expression<Func<string>> activeDirectoryEnableADUserByIdentityworkflow, Expression<Func<string>> activeDirectoryEnableADUserByIdentityaDServer = null)
        {
            var __workflow_activeDirectoryEnableADUserByIdentityuserIdentity = WorkflowExpression.Compile(activeDirectoryEnableADUserByIdentityuserIdentity, nameof(activeDirectoryEnableADUserByIdentityuserIdentity), required: true);
            var __workflow_activeDirectoryEnableADUserByIdentityworkflow = WorkflowExpression.Compile(activeDirectoryEnableADUserByIdentityworkflow, nameof(activeDirectoryEnableADUserByIdentityworkflow), required: true);
            var __workflow_activeDirectoryEnableADUserByIdentityaDServer = WorkflowExpression.Compile(activeDirectoryEnableADUserByIdentityaDServer, nameof(activeDirectoryEnableADUserByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryEnableADUserByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryEnableADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryEnableADUserByIdentity = new JObject();
                var activeDirectoryEnableADUserByIdentitypropCount = 0;
                activeDirectoryEnableADUserByIdentitypropCount++;
                activeDirectoryEnableADUserByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryEnableADUserByIdentityuserIdentity);
                if (__workflow_activeDirectoryEnableADUserByIdentityaDServer != null)
                {
                    activeDirectoryEnableADUserByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryEnableADUserByIdentityaDServer);
                    activeDirectoryEnableADUserByIdentitypropCount++;
                }

                activeDirectoryEnableADUserByIdentitypropCount++;
                activeDirectoryEnableADUserByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryEnableADUserByIdentityworkflow);
                if (activeDirectoryEnableADUserByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryEnableADUserByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryEnableADUserByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectorySetADUserHomeFolderByIdentity(Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityuserIdentity, Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityworkflow, Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityhomeDrive = null, Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityhomeDirectory = null, Expression<Func<bool>> activeDirectorySetADUserHomeFolderByIdentitycreateFolder = null, Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityaDServer = null)
        {
            var __workflow_activeDirectorySetADUserHomeFolderByIdentityuserIdentity = WorkflowExpression.Compile(activeDirectorySetADUserHomeFolderByIdentityuserIdentity, nameof(activeDirectorySetADUserHomeFolderByIdentityuserIdentity), required: true);
            var __workflow_activeDirectorySetADUserHomeFolderByIdentityworkflow = WorkflowExpression.Compile(activeDirectorySetADUserHomeFolderByIdentityworkflow, nameof(activeDirectorySetADUserHomeFolderByIdentityworkflow), required: true);
            var __workflow_activeDirectorySetADUserHomeFolderByIdentityhomeDrive = WorkflowExpression.Compile(activeDirectorySetADUserHomeFolderByIdentityhomeDrive, nameof(activeDirectorySetADUserHomeFolderByIdentityhomeDrive), required: false);
            var __workflow_activeDirectorySetADUserHomeFolderByIdentityhomeDirectory = WorkflowExpression.Compile(activeDirectorySetADUserHomeFolderByIdentityhomeDirectory, nameof(activeDirectorySetADUserHomeFolderByIdentityhomeDirectory), required: false);
            var __workflow_activeDirectorySetADUserHomeFolderByIdentitycreateFolder = WorkflowExpression.Compile(activeDirectorySetADUserHomeFolderByIdentitycreateFolder, nameof(activeDirectorySetADUserHomeFolderByIdentitycreateFolder), required: false);
            var __workflow_activeDirectorySetADUserHomeFolderByIdentityaDServer = WorkflowExpression.Compile(activeDirectorySetADUserHomeFolderByIdentityaDServer, nameof(activeDirectorySetADUserHomeFolderByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserHomeFolderByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectorySetADUserHomeFolderByIdentity = new JObject();
                var activeDirectorySetADUserHomeFolderByIdentitypropCount = 0;
                activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                activeDirectorySetADUserHomeFolderByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserHomeFolderByIdentityuserIdentity);
                if (__workflow_activeDirectorySetADUserHomeFolderByIdentityhomeDrive != null)
                {
                    activeDirectorySetADUserHomeFolderByIdentity["HomeDrive"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserHomeFolderByIdentityhomeDrive);
                    activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                }

                if (__workflow_activeDirectorySetADUserHomeFolderByIdentityhomeDirectory != null)
                {
                    activeDirectorySetADUserHomeFolderByIdentity["HomeDirectory"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserHomeFolderByIdentityhomeDirectory);
                    activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                }

                if (__workflow_activeDirectorySetADUserHomeFolderByIdentitycreateFolder != null)
                {
                    if (__workflow_activeDirectorySetADUserHomeFolderByIdentitycreateFolder != null)
                    {
                        activeDirectorySetADUserHomeFolderByIdentity["CreateFolder"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserHomeFolderByIdentitycreateFolder);
                        activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                    }

                    activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                }
                else
                {
                    activeDirectorySetADUserHomeFolderByIdentity["CreateFolder"] = false;
                    activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                }

                if (__workflow_activeDirectorySetADUserHomeFolderByIdentityaDServer != null)
                {
                    activeDirectorySetADUserHomeFolderByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserHomeFolderByIdentityaDServer);
                    activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                }

                activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                activeDirectorySetADUserHomeFolderByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserHomeFolderByIdentityworkflow);
                if (activeDirectorySetADUserHomeFolderByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectorySetADUserHomeFolderByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserGroupsResponse, ApiConnectionActionConfiguration> ActiveDirectoryCloneADUserGroups(Expression<Func<string>> activeDirectoryCloneADUserGroupssourceUserIdentity, Expression<Func<string>> activeDirectoryCloneADUserGroupsdestinationUserIdentity, Expression<Func<string>> activeDirectoryCloneADUserGroupsworkflow, Expression<Func<string>> activeDirectoryCloneADUserGroupsaDServer = null)
        {
            var __workflow_activeDirectoryCloneADUserGroupssourceUserIdentity = WorkflowExpression.Compile(activeDirectoryCloneADUserGroupssourceUserIdentity, nameof(activeDirectoryCloneADUserGroupssourceUserIdentity), required: true);
            var __workflow_activeDirectoryCloneADUserGroupsdestinationUserIdentity = WorkflowExpression.Compile(activeDirectoryCloneADUserGroupsdestinationUserIdentity, nameof(activeDirectoryCloneADUserGroupsdestinationUserIdentity), required: true);
            var __workflow_activeDirectoryCloneADUserGroupsworkflow = WorkflowExpression.Compile(activeDirectoryCloneADUserGroupsworkflow, nameof(activeDirectoryCloneADUserGroupsworkflow), required: true);
            var __workflow_activeDirectoryCloneADUserGroupsaDServer = WorkflowExpression.Compile(activeDirectoryCloneADUserGroupsaDServer, nameof(activeDirectoryCloneADUserGroupsaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryCloneADUserGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCloneADUserGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryCloneADUserGroups = new JObject();
                var activeDirectoryCloneADUserGroupspropCount = 0;
                activeDirectoryCloneADUserGroupspropCount++;
                activeDirectoryCloneADUserGroups["SourceUserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryCloneADUserGroupssourceUserIdentity);
                activeDirectoryCloneADUserGroupspropCount++;
                activeDirectoryCloneADUserGroups["DestinationUserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryCloneADUserGroupsdestinationUserIdentity);
                if (__workflow_activeDirectoryCloneADUserGroupsaDServer != null)
                {
                    activeDirectoryCloneADUserGroups["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryCloneADUserGroupsaDServer);
                    activeDirectoryCloneADUserGroupspropCount++;
                }

                activeDirectoryCloneADUserGroupspropCount++;
                activeDirectoryCloneADUserGroups["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryCloneADUserGroupsworkflow);
                if (activeDirectoryCloneADUserGroupspropCount > 0)
                {
                    callPayload.Body = activeDirectoryCloneADUserGroups;
                }

                return new ApiConnectionAction<ActiveDirectoryCloneADUserGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserPropertiesResponse, ApiConnectionActionConfiguration> ActiveDirectoryCloneADUserProperties(Expression<Func<string>> activeDirectoryCloneADUserPropertiessourceUserIdentity, Expression<Func<string>> activeDirectoryCloneADUserPropertiesdestinationUserIdentity, Expression<Func<string>> activeDirectoryCloneADUserPropertiespropertiesToClone, Expression<Func<string>> activeDirectoryCloneADUserPropertiesworkflow, Expression<Func<string>> activeDirectoryCloneADUserPropertiesaDServer = null)
        {
            var __workflow_activeDirectoryCloneADUserPropertiessourceUserIdentity = WorkflowExpression.Compile(activeDirectoryCloneADUserPropertiessourceUserIdentity, nameof(activeDirectoryCloneADUserPropertiessourceUserIdentity), required: true);
            var __workflow_activeDirectoryCloneADUserPropertiesdestinationUserIdentity = WorkflowExpression.Compile(activeDirectoryCloneADUserPropertiesdestinationUserIdentity, nameof(activeDirectoryCloneADUserPropertiesdestinationUserIdentity), required: true);
            var __workflow_activeDirectoryCloneADUserPropertiespropertiesToClone = WorkflowExpression.Compile(activeDirectoryCloneADUserPropertiespropertiesToClone, nameof(activeDirectoryCloneADUserPropertiespropertiesToClone), required: true);
            var __workflow_activeDirectoryCloneADUserPropertiesworkflow = WorkflowExpression.Compile(activeDirectoryCloneADUserPropertiesworkflow, nameof(activeDirectoryCloneADUserPropertiesworkflow), required: true);
            var __workflow_activeDirectoryCloneADUserPropertiesaDServer = WorkflowExpression.Compile(activeDirectoryCloneADUserPropertiesaDServer, nameof(activeDirectoryCloneADUserPropertiesaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryCloneADUserPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCloneADUserProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryCloneADUserProperties = new JObject();
                var activeDirectoryCloneADUserPropertiespropCount = 0;
                activeDirectoryCloneADUserPropertiespropCount++;
                activeDirectoryCloneADUserProperties["SourceUserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryCloneADUserPropertiessourceUserIdentity);
                activeDirectoryCloneADUserPropertiespropCount++;
                activeDirectoryCloneADUserProperties["DestinationUserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryCloneADUserPropertiesdestinationUserIdentity);
                activeDirectoryCloneADUserPropertiespropCount++;
                activeDirectoryCloneADUserProperties["PropertiesToClone"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryCloneADUserPropertiespropertiesToClone);
                if (__workflow_activeDirectoryCloneADUserPropertiesaDServer != null)
                {
                    activeDirectoryCloneADUserProperties["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryCloneADUserPropertiesaDServer);
                    activeDirectoryCloneADUserPropertiespropCount++;
                }

                activeDirectoryCloneADUserPropertiespropCount++;
                activeDirectoryCloneADUserProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryCloneADUserPropertiesworkflow);
                if (activeDirectoryCloneADUserPropertiespropCount > 0)
                {
                    callPayload.Body = activeDirectoryCloneADUserProperties;
                }

                return new ApiConnectionAction<ActiveDirectoryCloneADUserPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse, ApiConnectionActionConfiguration> ActiveDirectoryRemoveADUserFromMultipleADGroupsByName(Expression<Func<string>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity, Expression<Func<string>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow, Expression<Func<string>> activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON = null, Expression<Func<bool>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove = null, Expression<Func<bool>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove = null, Expression<Func<string>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer = null, Expression<Func<int>> activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall = null)
        {
            var __workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity), required: true);
            var __workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow), required: true);
            var __workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON), required: false);
            var __workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove), required: false);
            var __workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove), required: false);
            var __workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer), required: false);
            var __workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall), required: false);
            return new DeferredBodyAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserFromMultipleADGroupsByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADUserFromMultipleADGroupsByName = new JObject();
                var activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount = 0;
                activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                activeDirectoryRemoveADUserFromMultipleADGroupsByName["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity);
                if (__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON != null)
                {
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["GroupNamesJSON"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON);
                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }

                if (__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove != null)
                {
                    if (__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove != null)
                    {
                        activeDirectoryRemoveADUserFromMultipleADGroupsByName["ExceptionIfAnyGroupsFailToRemove"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove);
                        activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                    }

                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["ExceptionIfAnyGroupsFailToRemove"] = false;
                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }

                if (__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove != null)
                {
                    if (__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove != null)
                    {
                        activeDirectoryRemoveADUserFromMultipleADGroupsByName["ExceptionIfAllGroupsFailToRemove"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove);
                        activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                    }

                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["ExceptionIfAllGroupsFailToRemove"] = false;
                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }

                if (__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer != null)
                {
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer);
                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }

                if (__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall != null)
                {
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["MaxGroupsPerCall"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall);
                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }

                activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                activeDirectoryRemoveADUserFromMultipleADGroupsByName["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow);
                if (activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADUserFromMultipleADGroupsByName;
                }

                return new ApiConnectionAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse, ApiConnectionActionConfiguration> ActiveDirectoryRemoveADUserFromAllGroups(Expression<Func<string>> activeDirectoryRemoveADUserFromAllGroupsworkflow, Expression<Func<string>> activeDirectoryRemoveADUserFromAllGroupsuserIdentity = null, Expression<Func<string>> activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON = null, Expression<Func<bool>> activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist = null, Expression<Func<string>> activeDirectoryRemoveADUserFromAllGroupsaDServer = null, Expression<Func<bool>> activeDirectoryRemoveADUserFromAllGroupsrunAsThread = null, Expression<Func<int>> activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId = null, Expression<Func<int>> activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread = null)
        {
            var __workflow_activeDirectoryRemoveADUserFromAllGroupsworkflow = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromAllGroupsworkflow, nameof(activeDirectoryRemoveADUserFromAllGroupsworkflow), required: true);
            var __workflow_activeDirectoryRemoveADUserFromAllGroupsuserIdentity = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromAllGroupsuserIdentity, nameof(activeDirectoryRemoveADUserFromAllGroupsuserIdentity), required: false);
            var __workflow_activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON, nameof(activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON), required: false);
            var __workflow_activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist, nameof(activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist), required: false);
            var __workflow_activeDirectoryRemoveADUserFromAllGroupsaDServer = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromAllGroupsaDServer, nameof(activeDirectoryRemoveADUserFromAllGroupsaDServer), required: false);
            var __workflow_activeDirectoryRemoveADUserFromAllGroupsrunAsThread = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromAllGroupsrunAsThread, nameof(activeDirectoryRemoveADUserFromAllGroupsrunAsThread), required: false);
            var __workflow_activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId, nameof(activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId), required: false);
            var __workflow_activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread, nameof(activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread), required: false);
            return new DeferredBodyAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserFromAllGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADUserFromAllGroups = new JObject();
                var activeDirectoryRemoveADUserFromAllGroupspropCount = 0;
                if (__workflow_activeDirectoryRemoveADUserFromAllGroupsuserIdentity != null)
                {
                    activeDirectoryRemoveADUserFromAllGroups["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromAllGroupsuserIdentity);
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (__workflow_activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON != null)
                {
                    activeDirectoryRemoveADUserFromAllGroups["GroupsToExcludeJSON"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON);
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (__workflow_activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist != null)
                {
                    if (__workflow_activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist != null)
                    {
                        activeDirectoryRemoveADUserFromAllGroups["ExceptionIfExcludedGroupDoesNotExist"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist);
                        activeDirectoryRemoveADUserFromAllGroupspropCount++;
                    }

                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserFromAllGroups["ExceptionIfExcludedGroupDoesNotExist"] = false;
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (__workflow_activeDirectoryRemoveADUserFromAllGroupsaDServer != null)
                {
                    activeDirectoryRemoveADUserFromAllGroups["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromAllGroupsaDServer);
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (__workflow_activeDirectoryRemoveADUserFromAllGroupsrunAsThread != null)
                {
                    if (__workflow_activeDirectoryRemoveADUserFromAllGroupsrunAsThread != null)
                    {
                        activeDirectoryRemoveADUserFromAllGroups["RunAsThread"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromAllGroupsrunAsThread);
                        activeDirectoryRemoveADUserFromAllGroupspropCount++;
                    }

                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserFromAllGroups["RunAsThread"] = false;
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (__workflow_activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId != null)
                {
                    activeDirectoryRemoveADUserFromAllGroups["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId);
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (__workflow_activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread != null)
                {
                    if (__workflow_activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread != null)
                    {
                        activeDirectoryRemoveADUserFromAllGroups["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread);
                        activeDirectoryRemoveADUserFromAllGroupspropCount++;
                    }

                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserFromAllGroups["SecondsToWaitForThread"] = 90;
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                activeDirectoryRemoveADUserFromAllGroupspropCount++;
                activeDirectoryRemoveADUserFromAllGroups["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromAllGroupsworkflow);
                if (activeDirectoryRemoveADUserFromAllGroupspropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADUserFromAllGroups;
                }

                return new ApiConnectionAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCheckOUExistsResponse, ApiConnectionActionConfiguration> ActiveDirectoryCheckOUExists(Expression<Func<string>> activeDirectoryCheckOUExistsoUIdentity, Expression<Func<string>> activeDirectoryCheckOUExistsworkflow, Expression<Func<string>> activeDirectoryCheckOUExistsaDServer = null)
        {
            var __workflow_activeDirectoryCheckOUExistsoUIdentity = WorkflowExpression.Compile(activeDirectoryCheckOUExistsoUIdentity, nameof(activeDirectoryCheckOUExistsoUIdentity), required: true);
            var __workflow_activeDirectoryCheckOUExistsworkflow = WorkflowExpression.Compile(activeDirectoryCheckOUExistsworkflow, nameof(activeDirectoryCheckOUExistsworkflow), required: true);
            var __workflow_activeDirectoryCheckOUExistsaDServer = WorkflowExpression.Compile(activeDirectoryCheckOUExistsaDServer, nameof(activeDirectoryCheckOUExistsaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryCheckOUExistsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCheckOUExists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryCheckOUExists = new JObject();
                var activeDirectoryCheckOUExistspropCount = 0;
                activeDirectoryCheckOUExistspropCount++;
                activeDirectoryCheckOUExists["OUIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryCheckOUExistsoUIdentity);
                if (__workflow_activeDirectoryCheckOUExistsaDServer != null)
                {
                    activeDirectoryCheckOUExists["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryCheckOUExistsaDServer);
                    activeDirectoryCheckOUExistspropCount++;
                }

                activeDirectoryCheckOUExistspropCount++;
                activeDirectoryCheckOUExists["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryCheckOUExistsworkflow);
                if (activeDirectoryCheckOUExistspropCount > 0)
                {
                    callPayload.Body = activeDirectoryCheckOUExists;
                }

                return new ApiConnectionAction<ActiveDirectoryCheckOUExistsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryRemoveADGroupMemberByGroupIdentity(Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity, Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow, Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity = null, Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName = null, Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer = null)
        {
            var __workflow_activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity = WorkflowExpression.Compile(activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity, nameof(activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity), required: true);
            var __workflow_activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow = WorkflowExpression.Compile(activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow, nameof(activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow), required: true);
            var __workflow_activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity = WorkflowExpression.Compile(activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity, nameof(activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity), required: false);
            var __workflow_activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName = WorkflowExpression.Compile(activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName, nameof(activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName), required: false);
            var __workflow_activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer = WorkflowExpression.Compile(activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer, nameof(activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADGroupMemberByGroupIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADGroupMemberByGroupIdentity = new JObject();
                var activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount = 0;
                if (__workflow_activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity != null)
                {
                    activeDirectoryRemoveADGroupMemberByGroupIdentity["GroupIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity);
                    activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                }

                if (__workflow_activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName != null)
                {
                    activeDirectoryRemoveADGroupMemberByGroupIdentity["GroupName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName);
                    activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                }

                activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                activeDirectoryRemoveADGroupMemberByGroupIdentity["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity);
                if (__workflow_activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer != null)
                {
                    activeDirectoryRemoveADGroupMemberByGroupIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer);
                    activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                }

                activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                activeDirectoryRemoveADGroupMemberByGroupIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow);
                if (activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADGroupMemberByGroupIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryRemoveMultipleADGroupMembersByIdentity(Expression<Func<string>> activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow, Expression<Func<string>> activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity = null, Expression<Func<string>> activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON = null, Expression<Func<bool>> activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove = null, Expression<Func<bool>> activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove = null, Expression<Func<bool>> activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall = null, Expression<Func<string>> activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer = null)
        {
            var __workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow = WorkflowExpression.Compile(activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow), required: true);
            var __workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity = WorkflowExpression.Compile(activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity), required: false);
            var __workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON = WorkflowExpression.Compile(activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON), required: false);
            var __workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove = WorkflowExpression.Compile(activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove), required: false);
            var __workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove = WorkflowExpression.Compile(activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove), required: false);
            var __workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall = WorkflowExpression.Compile(activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall), required: false);
            var __workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer = WorkflowExpression.Compile(activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveMultipleADGroupMembersByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveMultipleADGroupMembersByIdentity = new JObject();
                var activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount = 0;
                if (__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity != null)
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["GroupIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity);
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON != null)
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["GroupMembersJSON"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON);
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove != null)
                {
                    if (__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove != null)
                    {
                        activeDirectoryRemoveMultipleADGroupMembersByIdentity["ExceptionIfAnyMembersFailToRemove"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove);
                        activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                    }

                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["ExceptionIfAnyMembersFailToRemove"] = false;
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove != null)
                {
                    if (__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove != null)
                    {
                        activeDirectoryRemoveMultipleADGroupMembersByIdentity["ExceptionIfAllMembersFailToRemove"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove);
                        activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                    }

                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["ExceptionIfAllMembersFailToRemove"] = false;
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall != null)
                {
                    if (__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall != null)
                    {
                        activeDirectoryRemoveMultipleADGroupMembersByIdentity["RemoveAllMembersInASingleCall"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall);
                        activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                    }

                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["RemoveAllMembersInASingleCall"] = false;
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                if (__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer != null)
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer);
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                activeDirectoryRemoveMultipleADGroupMembersByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow);
                if (activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveMultipleADGroupMembersByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryUnlockADAccountByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryUnlockADAccountByIdentity(Expression<Func<string>> activeDirectoryUnlockADAccountByIdentityuserIdentity, Expression<Func<string>> activeDirectoryUnlockADAccountByIdentityworkflow, Expression<Func<string>> activeDirectoryUnlockADAccountByIdentityaDServer = null)
        {
            var __workflow_activeDirectoryUnlockADAccountByIdentityuserIdentity = WorkflowExpression.Compile(activeDirectoryUnlockADAccountByIdentityuserIdentity, nameof(activeDirectoryUnlockADAccountByIdentityuserIdentity), required: true);
            var __workflow_activeDirectoryUnlockADAccountByIdentityworkflow = WorkflowExpression.Compile(activeDirectoryUnlockADAccountByIdentityworkflow, nameof(activeDirectoryUnlockADAccountByIdentityworkflow), required: true);
            var __workflow_activeDirectoryUnlockADAccountByIdentityaDServer = WorkflowExpression.Compile(activeDirectoryUnlockADAccountByIdentityaDServer, nameof(activeDirectoryUnlockADAccountByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryUnlockADAccountByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryUnlockADAccountByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryUnlockADAccountByIdentity = new JObject();
                var activeDirectoryUnlockADAccountByIdentitypropCount = 0;
                activeDirectoryUnlockADAccountByIdentitypropCount++;
                activeDirectoryUnlockADAccountByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryUnlockADAccountByIdentityuserIdentity);
                if (__workflow_activeDirectoryUnlockADAccountByIdentityaDServer != null)
                {
                    activeDirectoryUnlockADAccountByIdentity["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryUnlockADAccountByIdentityaDServer);
                    activeDirectoryUnlockADAccountByIdentitypropCount++;
                }

                activeDirectoryUnlockADAccountByIdentitypropCount++;
                activeDirectoryUnlockADAccountByIdentity["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryUnlockADAccountByIdentityworkflow);
                if (activeDirectoryUnlockADAccountByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryUnlockADAccountByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryUnlockADAccountByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADServerResponse, ApiConnectionActionConfiguration> ActiveDirectorySetADServer(Expression<Func<string>> activeDirectorySetADServerworkflow, Expression<Func<activeDirectorySetADServerpredefinedADServerChoiceInput>> activeDirectorySetADServerpredefinedADServerChoice = null, Expression<Func<string>> activeDirectorySetADServeraDServer = null)
        {
            var __workflow_activeDirectorySetADServerworkflow = WorkflowExpression.Compile(activeDirectorySetADServerworkflow, nameof(activeDirectorySetADServerworkflow), required: true);
            var __workflow_activeDirectorySetADServerpredefinedADServerChoice = WorkflowExpression.Compile(activeDirectorySetADServerpredefinedADServerChoice, nameof(activeDirectorySetADServerpredefinedADServerChoice), required: false);
            var __workflow_activeDirectorySetADServeraDServer = WorkflowExpression.Compile(activeDirectorySetADServeraDServer, nameof(activeDirectorySetADServeraDServer), required: false);
            return new DeferredBodyAction<ActiveDirectorySetADServerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADServer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectorySetADServer = new JObject();
                var activeDirectorySetADServerpropCount = 0;
                if (__workflow_activeDirectorySetADServerpredefinedADServerChoice != null)
                {
                    if (__workflow_activeDirectorySetADServerpredefinedADServerChoice != null)
                    {
                        activeDirectorySetADServer["PredefinedADServerChoice"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADServerpredefinedADServerChoice);
                        activeDirectorySetADServerpropCount++;
                    }

                    activeDirectorySetADServerpropCount++;
                }
                else
                {
                    activeDirectorySetADServer["PredefinedADServerChoice"] = "Manual: Specify in AD server field";
                    activeDirectorySetADServerpropCount++;
                }

                if (__workflow_activeDirectorySetADServeraDServer != null)
                {
                    activeDirectorySetADServer["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADServeraDServer);
                    activeDirectorySetADServerpropCount++;
                }

                activeDirectorySetADServerpropCount++;
                activeDirectorySetADServer["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADServerworkflow);
                if (activeDirectorySetADServerpropCount > 0)
                {
                    callPayload.Body = activeDirectorySetADServer;
                }

                return new ApiConnectionAction<ActiveDirectorySetADServerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainInfoResponse, ApiConnectionActionConfiguration> ActiveDirectoryGetDomainInfo(Expression<Func<string>> activeDirectoryGetDomainInfoworkflow, Expression<Func<string>> activeDirectoryGetDomainInfoaDServer = null, Expression<Func<activeDirectoryGetDomainInfopredefinedIdentityInput>> activeDirectoryGetDomainInfopredefinedIdentity = null, Expression<Func<string>> activeDirectoryGetDomainInfoidentity = null)
        {
            var __workflow_activeDirectoryGetDomainInfoworkflow = WorkflowExpression.Compile(activeDirectoryGetDomainInfoworkflow, nameof(activeDirectoryGetDomainInfoworkflow), required: true);
            var __workflow_activeDirectoryGetDomainInfoaDServer = WorkflowExpression.Compile(activeDirectoryGetDomainInfoaDServer, nameof(activeDirectoryGetDomainInfoaDServer), required: false);
            var __workflow_activeDirectoryGetDomainInfopredefinedIdentity = WorkflowExpression.Compile(activeDirectoryGetDomainInfopredefinedIdentity, nameof(activeDirectoryGetDomainInfopredefinedIdentity), required: false);
            var __workflow_activeDirectoryGetDomainInfoidentity = WorkflowExpression.Compile(activeDirectoryGetDomainInfoidentity, nameof(activeDirectoryGetDomainInfoidentity), required: false);
            return new DeferredBodyAction<ActiveDirectoryGetDomainInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetDomainInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetDomainInfo = new JObject();
                var activeDirectoryGetDomainInfopropCount = 0;
                if (__workflow_activeDirectoryGetDomainInfoaDServer != null)
                {
                    activeDirectoryGetDomainInfo["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetDomainInfoaDServer);
                    activeDirectoryGetDomainInfopropCount++;
                }

                if (__workflow_activeDirectoryGetDomainInfopredefinedIdentity != null)
                {
                    if (__workflow_activeDirectoryGetDomainInfopredefinedIdentity != null)
                    {
                        activeDirectoryGetDomainInfo["PredefinedIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetDomainInfopredefinedIdentity);
                        activeDirectoryGetDomainInfopropCount++;
                    }

                    activeDirectoryGetDomainInfopropCount++;
                }
                else
                {
                    activeDirectoryGetDomainInfo["PredefinedIdentity"] = "Manual: Specify in Domain identity field";
                    activeDirectoryGetDomainInfopropCount++;
                }

                if (__workflow_activeDirectoryGetDomainInfoidentity != null)
                {
                    activeDirectoryGetDomainInfo["Identity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetDomainInfoidentity);
                    activeDirectoryGetDomainInfopropCount++;
                }

                activeDirectoryGetDomainInfopropCount++;
                activeDirectoryGetDomainInfo["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetDomainInfoworkflow);
                if (activeDirectoryGetDomainInfopropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetDomainInfo;
                }

                return new ApiConnectionAction<ActiveDirectoryGetDomainInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupResponse, ApiConnectionActionConfiguration> ActiveDirectoryAddADGroup(Expression<Func<string>> activeDirectoryAddADGroupname, Expression<Func<activeDirectoryAddADGroupgroupCategoryInput>> activeDirectoryAddADGroupgroupCategory, Expression<Func<activeDirectoryAddADGroupgroupScopeInput>> activeDirectoryAddADGroupgroupScope, Expression<Func<string>> activeDirectoryAddADGroupworkflow, Expression<Func<string>> activeDirectoryAddADGroupsamAccountName = null, Expression<Func<string>> activeDirectoryAddADGrouppath = null, Expression<Func<string>> activeDirectoryAddADGroupdescription = null, Expression<Func<string>> activeDirectoryAddADGroupnotes = null, Expression<Func<string>> activeDirectoryAddADGroupdisplayName = null, Expression<Func<string>> activeDirectoryAddADGrouphomePage = null, Expression<Func<string>> activeDirectoryAddADGroupmanagedBy = null, Expression<Func<bool>> activeDirectoryAddADGroupprotectedFromAccidentalDeletion = null, Expression<Func<string>> activeDirectoryAddADGroupaDServer = null)
        {
            var __workflow_activeDirectoryAddADGroupname = WorkflowExpression.Compile(activeDirectoryAddADGroupname, nameof(activeDirectoryAddADGroupname), required: true);
            var __workflow_activeDirectoryAddADGroupgroupCategory = WorkflowExpression.Compile(activeDirectoryAddADGroupgroupCategory, nameof(activeDirectoryAddADGroupgroupCategory), required: true);
            var __workflow_activeDirectoryAddADGroupgroupScope = WorkflowExpression.Compile(activeDirectoryAddADGroupgroupScope, nameof(activeDirectoryAddADGroupgroupScope), required: true);
            var __workflow_activeDirectoryAddADGroupworkflow = WorkflowExpression.Compile(activeDirectoryAddADGroupworkflow, nameof(activeDirectoryAddADGroupworkflow), required: true);
            var __workflow_activeDirectoryAddADGroupsamAccountName = WorkflowExpression.Compile(activeDirectoryAddADGroupsamAccountName, nameof(activeDirectoryAddADGroupsamAccountName), required: false);
            var __workflow_activeDirectoryAddADGrouppath = WorkflowExpression.Compile(activeDirectoryAddADGrouppath, nameof(activeDirectoryAddADGrouppath), required: false);
            var __workflow_activeDirectoryAddADGroupdescription = WorkflowExpression.Compile(activeDirectoryAddADGroupdescription, nameof(activeDirectoryAddADGroupdescription), required: false);
            var __workflow_activeDirectoryAddADGroupnotes = WorkflowExpression.Compile(activeDirectoryAddADGroupnotes, nameof(activeDirectoryAddADGroupnotes), required: false);
            var __workflow_activeDirectoryAddADGroupdisplayName = WorkflowExpression.Compile(activeDirectoryAddADGroupdisplayName, nameof(activeDirectoryAddADGroupdisplayName), required: false);
            var __workflow_activeDirectoryAddADGrouphomePage = WorkflowExpression.Compile(activeDirectoryAddADGrouphomePage, nameof(activeDirectoryAddADGrouphomePage), required: false);
            var __workflow_activeDirectoryAddADGroupmanagedBy = WorkflowExpression.Compile(activeDirectoryAddADGroupmanagedBy, nameof(activeDirectoryAddADGroupmanagedBy), required: false);
            var __workflow_activeDirectoryAddADGroupprotectedFromAccidentalDeletion = WorkflowExpression.Compile(activeDirectoryAddADGroupprotectedFromAccidentalDeletion, nameof(activeDirectoryAddADGroupprotectedFromAccidentalDeletion), required: false);
            var __workflow_activeDirectoryAddADGroupaDServer = WorkflowExpression.Compile(activeDirectoryAddADGroupaDServer, nameof(activeDirectoryAddADGroupaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryAddADGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddADGroup = new JObject();
                var activeDirectoryAddADGrouppropCount = 0;
                activeDirectoryAddADGrouppropCount++;
                activeDirectoryAddADGroup["Name"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupname);
                if (__workflow_activeDirectoryAddADGroupsamAccountName != null)
                {
                    activeDirectoryAddADGroup["SamAccountName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupsamAccountName);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (__workflow_activeDirectoryAddADGrouppath != null)
                {
                    activeDirectoryAddADGroup["Path"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGrouppath);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (__workflow_activeDirectoryAddADGroupdescription != null)
                {
                    activeDirectoryAddADGroup["Description"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupdescription);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (__workflow_activeDirectoryAddADGroupnotes != null)
                {
                    activeDirectoryAddADGroup["Notes"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupnotes);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (__workflow_activeDirectoryAddADGroupdisplayName != null)
                {
                    activeDirectoryAddADGroup["DisplayName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupdisplayName);
                    activeDirectoryAddADGrouppropCount++;
                }

                activeDirectoryAddADGrouppropCount++;
                activeDirectoryAddADGroup["GroupCategory"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupgroupCategory);
                activeDirectoryAddADGrouppropCount++;
                activeDirectoryAddADGroup["GroupScope"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupgroupScope);
                if (__workflow_activeDirectoryAddADGrouphomePage != null)
                {
                    activeDirectoryAddADGroup["HomePage"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGrouphomePage);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (__workflow_activeDirectoryAddADGroupmanagedBy != null)
                {
                    activeDirectoryAddADGroup["ManagedBy"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupmanagedBy);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (__workflow_activeDirectoryAddADGroupprotectedFromAccidentalDeletion != null)
                {
                    if (__workflow_activeDirectoryAddADGroupprotectedFromAccidentalDeletion != null)
                    {
                        activeDirectoryAddADGroup["ProtectedFromAccidentalDeletion"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupprotectedFromAccidentalDeletion);
                        activeDirectoryAddADGrouppropCount++;
                    }

                    activeDirectoryAddADGrouppropCount++;
                }
                else
                {
                    activeDirectoryAddADGroup["ProtectedFromAccidentalDeletion"] = false;
                    activeDirectoryAddADGrouppropCount++;
                }

                if (__workflow_activeDirectoryAddADGroupaDServer != null)
                {
                    activeDirectoryAddADGroup["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupaDServer);
                    activeDirectoryAddADGrouppropCount++;
                }

                activeDirectoryAddADGrouppropCount++;
                activeDirectoryAddADGroup["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupworkflow);
                if (activeDirectoryAddADGrouppropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddADGroup;
                }

                return new ApiConnectionAction<ActiveDirectoryAddADGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDoesADGroupExistResponse, ApiConnectionActionConfiguration> ActiveDirectoryDoesADGroupExist(Expression<Func<string>> activeDirectoryDoesADGroupExistgroupIdentity, Expression<Func<string>> activeDirectoryDoesADGroupExistworkflow, Expression<Func<string>> activeDirectoryDoesADGroupExistaDServer = null)
        {
            var __workflow_activeDirectoryDoesADGroupExistgroupIdentity = WorkflowExpression.Compile(activeDirectoryDoesADGroupExistgroupIdentity, nameof(activeDirectoryDoesADGroupExistgroupIdentity), required: true);
            var __workflow_activeDirectoryDoesADGroupExistworkflow = WorkflowExpression.Compile(activeDirectoryDoesADGroupExistworkflow, nameof(activeDirectoryDoesADGroupExistworkflow), required: true);
            var __workflow_activeDirectoryDoesADGroupExistaDServer = WorkflowExpression.Compile(activeDirectoryDoesADGroupExistaDServer, nameof(activeDirectoryDoesADGroupExistaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryDoesADGroupExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDoesADGroupExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryDoesADGroupExist = new JObject();
                var activeDirectoryDoesADGroupExistpropCount = 0;
                activeDirectoryDoesADGroupExistpropCount++;
                activeDirectoryDoesADGroupExist["GroupIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryDoesADGroupExistgroupIdentity);
                if (__workflow_activeDirectoryDoesADGroupExistaDServer != null)
                {
                    activeDirectoryDoesADGroupExist["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryDoesADGroupExistaDServer);
                    activeDirectoryDoesADGroupExistpropCount++;
                }

                activeDirectoryDoesADGroupExistpropCount++;
                activeDirectoryDoesADGroupExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryDoesADGroupExistworkflow);
                if (activeDirectoryDoesADGroupExistpropCount > 0)
                {
                    callPayload.Body = activeDirectoryDoesADGroupExist;
                }

                return new ApiConnectionAction<ActiveDirectoryDoesADGroupExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupResponse, ApiConnectionActionConfiguration> ActiveDirectoryRemoveADGroup(Expression<Func<string>> activeDirectoryRemoveADGroupgroupIdentity, Expression<Func<string>> activeDirectoryRemoveADGroupworkflow, Expression<Func<bool>> activeDirectoryRemoveADGroupdeleteEvenIfProtected = null, Expression<Func<bool>> activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist = null, Expression<Func<string>> activeDirectoryRemoveADGroupaDServer = null)
        {
            var __workflow_activeDirectoryRemoveADGroupgroupIdentity = WorkflowExpression.Compile(activeDirectoryRemoveADGroupgroupIdentity, nameof(activeDirectoryRemoveADGroupgroupIdentity), required: true);
            var __workflow_activeDirectoryRemoveADGroupworkflow = WorkflowExpression.Compile(activeDirectoryRemoveADGroupworkflow, nameof(activeDirectoryRemoveADGroupworkflow), required: true);
            var __workflow_activeDirectoryRemoveADGroupdeleteEvenIfProtected = WorkflowExpression.Compile(activeDirectoryRemoveADGroupdeleteEvenIfProtected, nameof(activeDirectoryRemoveADGroupdeleteEvenIfProtected), required: false);
            var __workflow_activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist = WorkflowExpression.Compile(activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist, nameof(activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist), required: false);
            var __workflow_activeDirectoryRemoveADGroupaDServer = WorkflowExpression.Compile(activeDirectoryRemoveADGroupaDServer, nameof(activeDirectoryRemoveADGroupaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryRemoveADGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADGroup = new JObject();
                var activeDirectoryRemoveADGrouppropCount = 0;
                activeDirectoryRemoveADGrouppropCount++;
                activeDirectoryRemoveADGroup["GroupIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADGroupgroupIdentity);
                if (__workflow_activeDirectoryRemoveADGroupdeleteEvenIfProtected != null)
                {
                    if (__workflow_activeDirectoryRemoveADGroupdeleteEvenIfProtected != null)
                    {
                        activeDirectoryRemoveADGroup["DeleteEvenIfProtected"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADGroupdeleteEvenIfProtected);
                        activeDirectoryRemoveADGrouppropCount++;
                    }

                    activeDirectoryRemoveADGrouppropCount++;
                }
                else
                {
                    activeDirectoryRemoveADGroup["DeleteEvenIfProtected"] = false;
                    activeDirectoryRemoveADGrouppropCount++;
                }

                if (__workflow_activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist != null)
                {
                    if (__workflow_activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist != null)
                    {
                        activeDirectoryRemoveADGroup["RaiseExceptionIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist);
                        activeDirectoryRemoveADGrouppropCount++;
                    }

                    activeDirectoryRemoveADGrouppropCount++;
                }
                else
                {
                    activeDirectoryRemoveADGroup["RaiseExceptionIfGroupDoesNotExist"] = false;
                    activeDirectoryRemoveADGrouppropCount++;
                }

                if (__workflow_activeDirectoryRemoveADGroupaDServer != null)
                {
                    activeDirectoryRemoveADGroup["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADGroupaDServer);
                    activeDirectoryRemoveADGrouppropCount++;
                }

                activeDirectoryRemoveADGrouppropCount++;
                activeDirectoryRemoveADGroup["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADGroupworkflow);
                if (activeDirectoryRemoveADGrouppropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADGroup;
                }

                return new ApiConnectionAction<ActiveDirectoryRemoveADGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddOUResponse, ApiConnectionActionConfiguration> ActiveDirectoryAddOU(Expression<Func<string>> activeDirectoryAddOUname, Expression<Func<string>> activeDirectoryAddOUworkflow, Expression<Func<string>> activeDirectoryAddOUpath = null, Expression<Func<string>> activeDirectoryAddOUdescription = null, Expression<Func<string>> activeDirectoryAddOUdisplayName = null, Expression<Func<string>> activeDirectoryAddOUmanagedBy = null, Expression<Func<bool>> activeDirectoryAddOUprotectedFromAccidentalDeletion = null, Expression<Func<string>> activeDirectoryAddOUstreetAddress = null, Expression<Func<string>> activeDirectoryAddOUcity = null, Expression<Func<string>> activeDirectoryAddOUstate = null, Expression<Func<string>> activeDirectoryAddOUpostalCode = null, Expression<Func<string>> activeDirectoryAddOUaDServer = null)
        {
            var __workflow_activeDirectoryAddOUname = WorkflowExpression.Compile(activeDirectoryAddOUname, nameof(activeDirectoryAddOUname), required: true);
            var __workflow_activeDirectoryAddOUworkflow = WorkflowExpression.Compile(activeDirectoryAddOUworkflow, nameof(activeDirectoryAddOUworkflow), required: true);
            var __workflow_activeDirectoryAddOUpath = WorkflowExpression.Compile(activeDirectoryAddOUpath, nameof(activeDirectoryAddOUpath), required: false);
            var __workflow_activeDirectoryAddOUdescription = WorkflowExpression.Compile(activeDirectoryAddOUdescription, nameof(activeDirectoryAddOUdescription), required: false);
            var __workflow_activeDirectoryAddOUdisplayName = WorkflowExpression.Compile(activeDirectoryAddOUdisplayName, nameof(activeDirectoryAddOUdisplayName), required: false);
            var __workflow_activeDirectoryAddOUmanagedBy = WorkflowExpression.Compile(activeDirectoryAddOUmanagedBy, nameof(activeDirectoryAddOUmanagedBy), required: false);
            var __workflow_activeDirectoryAddOUprotectedFromAccidentalDeletion = WorkflowExpression.Compile(activeDirectoryAddOUprotectedFromAccidentalDeletion, nameof(activeDirectoryAddOUprotectedFromAccidentalDeletion), required: false);
            var __workflow_activeDirectoryAddOUstreetAddress = WorkflowExpression.Compile(activeDirectoryAddOUstreetAddress, nameof(activeDirectoryAddOUstreetAddress), required: false);
            var __workflow_activeDirectoryAddOUcity = WorkflowExpression.Compile(activeDirectoryAddOUcity, nameof(activeDirectoryAddOUcity), required: false);
            var __workflow_activeDirectoryAddOUstate = WorkflowExpression.Compile(activeDirectoryAddOUstate, nameof(activeDirectoryAddOUstate), required: false);
            var __workflow_activeDirectoryAddOUpostalCode = WorkflowExpression.Compile(activeDirectoryAddOUpostalCode, nameof(activeDirectoryAddOUpostalCode), required: false);
            var __workflow_activeDirectoryAddOUaDServer = WorkflowExpression.Compile(activeDirectoryAddOUaDServer, nameof(activeDirectoryAddOUaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryAddOUResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddOU";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddOU = new JObject();
                var activeDirectoryAddOUpropCount = 0;
                activeDirectoryAddOUpropCount++;
                activeDirectoryAddOU["Name"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddOUname);
                if (__workflow_activeDirectoryAddOUpath != null)
                {
                    activeDirectoryAddOU["Path"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddOUpath);
                    activeDirectoryAddOUpropCount++;
                }

                if (__workflow_activeDirectoryAddOUdescription != null)
                {
                    activeDirectoryAddOU["Description"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddOUdescription);
                    activeDirectoryAddOUpropCount++;
                }

                if (__workflow_activeDirectoryAddOUdisplayName != null)
                {
                    activeDirectoryAddOU["DisplayName"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddOUdisplayName);
                    activeDirectoryAddOUpropCount++;
                }

                if (__workflow_activeDirectoryAddOUmanagedBy != null)
                {
                    activeDirectoryAddOU["ManagedBy"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddOUmanagedBy);
                    activeDirectoryAddOUpropCount++;
                }

                if (__workflow_activeDirectoryAddOUprotectedFromAccidentalDeletion != null)
                {
                    if (__workflow_activeDirectoryAddOUprotectedFromAccidentalDeletion != null)
                    {
                        activeDirectoryAddOU["ProtectedFromAccidentalDeletion"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddOUprotectedFromAccidentalDeletion);
                        activeDirectoryAddOUpropCount++;
                    }

                    activeDirectoryAddOUpropCount++;
                }
                else
                {
                    activeDirectoryAddOU["ProtectedFromAccidentalDeletion"] = true;
                    activeDirectoryAddOUpropCount++;
                }

                if (__workflow_activeDirectoryAddOUstreetAddress != null)
                {
                    activeDirectoryAddOU["StreetAddress"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddOUstreetAddress);
                    activeDirectoryAddOUpropCount++;
                }

                if (__workflow_activeDirectoryAddOUcity != null)
                {
                    activeDirectoryAddOU["City"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddOUcity);
                    activeDirectoryAddOUpropCount++;
                }

                if (__workflow_activeDirectoryAddOUstate != null)
                {
                    activeDirectoryAddOU["State"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddOUstate);
                    activeDirectoryAddOUpropCount++;
                }

                if (__workflow_activeDirectoryAddOUpostalCode != null)
                {
                    activeDirectoryAddOU["PostalCode"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddOUpostalCode);
                    activeDirectoryAddOUpropCount++;
                }

                if (__workflow_activeDirectoryAddOUaDServer != null)
                {
                    activeDirectoryAddOU["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddOUaDServer);
                    activeDirectoryAddOUpropCount++;
                }

                activeDirectoryAddOUpropCount++;
                activeDirectoryAddOU["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddOUworkflow);
                if (activeDirectoryAddOUpropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddOU;
                }

                return new ApiConnectionAction<ActiveDirectoryAddOUResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveOUResponse, ApiConnectionActionConfiguration> ActiveDirectoryRemoveOU(Expression<Func<string>> activeDirectoryRemoveOUoUIdentity, Expression<Func<string>> activeDirectoryRemoveOUworkflow, Expression<Func<bool>> activeDirectoryRemoveOUdeleteEvenIfProtected = null, Expression<Func<bool>> activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist = null, Expression<Func<string>> activeDirectoryRemoveOUaDServer = null)
        {
            var __workflow_activeDirectoryRemoveOUoUIdentity = WorkflowExpression.Compile(activeDirectoryRemoveOUoUIdentity, nameof(activeDirectoryRemoveOUoUIdentity), required: true);
            var __workflow_activeDirectoryRemoveOUworkflow = WorkflowExpression.Compile(activeDirectoryRemoveOUworkflow, nameof(activeDirectoryRemoveOUworkflow), required: true);
            var __workflow_activeDirectoryRemoveOUdeleteEvenIfProtected = WorkflowExpression.Compile(activeDirectoryRemoveOUdeleteEvenIfProtected, nameof(activeDirectoryRemoveOUdeleteEvenIfProtected), required: false);
            var __workflow_activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist = WorkflowExpression.Compile(activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist, nameof(activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist), required: false);
            var __workflow_activeDirectoryRemoveOUaDServer = WorkflowExpression.Compile(activeDirectoryRemoveOUaDServer, nameof(activeDirectoryRemoveOUaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryRemoveOUResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveOU";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveOU = new JObject();
                var activeDirectoryRemoveOUpropCount = 0;
                activeDirectoryRemoveOUpropCount++;
                activeDirectoryRemoveOU["OUIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveOUoUIdentity);
                if (__workflow_activeDirectoryRemoveOUdeleteEvenIfProtected != null)
                {
                    if (__workflow_activeDirectoryRemoveOUdeleteEvenIfProtected != null)
                    {
                        activeDirectoryRemoveOU["DeleteEvenIfProtected"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveOUdeleteEvenIfProtected);
                        activeDirectoryRemoveOUpropCount++;
                    }

                    activeDirectoryRemoveOUpropCount++;
                }
                else
                {
                    activeDirectoryRemoveOU["DeleteEvenIfProtected"] = false;
                    activeDirectoryRemoveOUpropCount++;
                }

                if (__workflow_activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist != null)
                {
                    if (__workflow_activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist != null)
                    {
                        activeDirectoryRemoveOU["RaiseExceptionIfOUDoesNotExist"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist);
                        activeDirectoryRemoveOUpropCount++;
                    }

                    activeDirectoryRemoveOUpropCount++;
                }
                else
                {
                    activeDirectoryRemoveOU["RaiseExceptionIfOUDoesNotExist"] = false;
                    activeDirectoryRemoveOUpropCount++;
                }

                if (__workflow_activeDirectoryRemoveOUaDServer != null)
                {
                    activeDirectoryRemoveOU["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveOUaDServer);
                    activeDirectoryRemoveOUpropCount++;
                }

                activeDirectoryRemoveOUpropCount++;
                activeDirectoryRemoveOU["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveOUworkflow);
                if (activeDirectoryRemoveOUpropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveOU;
                }

                return new ApiConnectionAction<ActiveDirectoryRemoveOUResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse, ApiConnectionActionConfiguration> ActiveDirectorySetADUserAccountExpirationEndOfDate(Expression<Func<string>> activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity, Expression<Func<int>> activeDirectorySetADUserAccountExpirationEndOfDateyear, Expression<Func<int>> activeDirectorySetADUserAccountExpirationEndOfDatemonth, Expression<Func<int>> activeDirectorySetADUserAccountExpirationEndOfDateday, Expression<Func<string>> activeDirectorySetADUserAccountExpirationEndOfDateworkflow, Expression<Func<string>> activeDirectorySetADUserAccountExpirationEndOfDateaDServer = null)
        {
            var __workflow_activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity = WorkflowExpression.Compile(activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity, nameof(activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity), required: true);
            var __workflow_activeDirectorySetADUserAccountExpirationEndOfDateyear = WorkflowExpression.Compile(activeDirectorySetADUserAccountExpirationEndOfDateyear, nameof(activeDirectorySetADUserAccountExpirationEndOfDateyear), required: true);
            var __workflow_activeDirectorySetADUserAccountExpirationEndOfDatemonth = WorkflowExpression.Compile(activeDirectorySetADUserAccountExpirationEndOfDatemonth, nameof(activeDirectorySetADUserAccountExpirationEndOfDatemonth), required: true);
            var __workflow_activeDirectorySetADUserAccountExpirationEndOfDateday = WorkflowExpression.Compile(activeDirectorySetADUserAccountExpirationEndOfDateday, nameof(activeDirectorySetADUserAccountExpirationEndOfDateday), required: true);
            var __workflow_activeDirectorySetADUserAccountExpirationEndOfDateworkflow = WorkflowExpression.Compile(activeDirectorySetADUserAccountExpirationEndOfDateworkflow, nameof(activeDirectorySetADUserAccountExpirationEndOfDateworkflow), required: true);
            var __workflow_activeDirectorySetADUserAccountExpirationEndOfDateaDServer = WorkflowExpression.Compile(activeDirectorySetADUserAccountExpirationEndOfDateaDServer, nameof(activeDirectorySetADUserAccountExpirationEndOfDateaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserAccountExpirationEndOfDate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectorySetADUserAccountExpirationEndOfDate = new JObject();
                var activeDirectorySetADUserAccountExpirationEndOfDatepropCount = 0;
                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["UserIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity);
                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["Year"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserAccountExpirationEndOfDateyear);
                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["Month"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserAccountExpirationEndOfDatemonth);
                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["Day"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserAccountExpirationEndOfDateday);
                if (__workflow_activeDirectorySetADUserAccountExpirationEndOfDateaDServer != null)
                {
                    activeDirectorySetADUserAccountExpirationEndOfDate["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserAccountExpirationEndOfDateaDServer);
                    activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                }

                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserAccountExpirationEndOfDateworkflow);
                if (activeDirectorySetADUserAccountExpirationEndOfDatepropCount > 0)
                {
                    callPayload.Body = activeDirectorySetADUserAccountExpirationEndOfDate;
                }

                return new ApiConnectionAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupMembersResponse, ApiConnectionActionConfiguration> ActiveDirectoryGetADGroupMembers(Expression<Func<string>> activeDirectoryGetADGroupMembersgroupIdentity, Expression<Func<string>> activeDirectoryGetADGroupMembersworkflow, Expression<Func<bool>> activeDirectoryGetADGroupMembersrecursive = null, Expression<Func<string>> activeDirectoryGetADGroupMembersaDServer = null)
        {
            var __workflow_activeDirectoryGetADGroupMembersgroupIdentity = WorkflowExpression.Compile(activeDirectoryGetADGroupMembersgroupIdentity, nameof(activeDirectoryGetADGroupMembersgroupIdentity), required: true);
            var __workflow_activeDirectoryGetADGroupMembersworkflow = WorkflowExpression.Compile(activeDirectoryGetADGroupMembersworkflow, nameof(activeDirectoryGetADGroupMembersworkflow), required: true);
            var __workflow_activeDirectoryGetADGroupMembersrecursive = WorkflowExpression.Compile(activeDirectoryGetADGroupMembersrecursive, nameof(activeDirectoryGetADGroupMembersrecursive), required: false);
            var __workflow_activeDirectoryGetADGroupMembersaDServer = WorkflowExpression.Compile(activeDirectoryGetADGroupMembersaDServer, nameof(activeDirectoryGetADGroupMembersaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryGetADGroupMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetADGroupMembers = new JObject();
                var activeDirectoryGetADGroupMemberspropCount = 0;
                activeDirectoryGetADGroupMemberspropCount++;
                activeDirectoryGetADGroupMembers["GroupIdentity"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupMembersgroupIdentity);
                if (__workflow_activeDirectoryGetADGroupMembersrecursive != null)
                {
                    if (__workflow_activeDirectoryGetADGroupMembersrecursive != null)
                    {
                        activeDirectoryGetADGroupMembers["Recursive"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupMembersrecursive);
                        activeDirectoryGetADGroupMemberspropCount++;
                    }

                    activeDirectoryGetADGroupMemberspropCount++;
                }
                else
                {
                    activeDirectoryGetADGroupMembers["Recursive"] = false;
                    activeDirectoryGetADGroupMemberspropCount++;
                }

                if (__workflow_activeDirectoryGetADGroupMembersaDServer != null)
                {
                    activeDirectoryGetADGroupMembers["ADServer"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupMembersaDServer);
                    activeDirectoryGetADGroupMemberspropCount++;
                }

                activeDirectoryGetADGroupMemberspropCount++;
                activeDirectoryGetADGroupMembers["Workflow"] = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupMembersworkflow);
                if (activeDirectoryGetADGroupMemberspropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetADGroupMembers;
                }

                return new ApiConnectionAction<ActiveDirectoryGetADGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenExchangePowerShellRunspaceResponse, ApiConnectionActionConfiguration> OpenExchangePowerShellRunspace(Expression<Func<string>> openExchangePowerShellRunspaceexchangeServerFQDN, Expression<Func<string>> openExchangePowerShellRunspaceworkflow, Expression<Func<string>> openExchangePowerShellRunspaceusername = null, Expression<Func<string>> openExchangePowerShellRunspacepassword = null, Expression<Func<bool>> openExchangePowerShellRunspaceuseSSL = null, Expression<Func<openExchangePowerShellRunspaceconnectionMethodInput>> openExchangePowerShellRunspaceconnectionMethod = null, Expression<Func<openExchangePowerShellRunspaceauthenticationMechanismInput>> openExchangePowerShellRunspaceauthenticationMechanism = null, Expression<Func<bool>> openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected = null, Expression<Func<openExchangePowerShellRunspacecommandTypesToImportLocallyInput>> openExchangePowerShellRunspacecommandTypesToImportLocally = null, Expression<Func<string>> openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV = null)
        {
            var __workflow_openExchangePowerShellRunspaceexchangeServerFQDN = WorkflowExpression.Compile(openExchangePowerShellRunspaceexchangeServerFQDN, nameof(openExchangePowerShellRunspaceexchangeServerFQDN), required: true);
            var __workflow_openExchangePowerShellRunspaceworkflow = WorkflowExpression.Compile(openExchangePowerShellRunspaceworkflow, nameof(openExchangePowerShellRunspaceworkflow), required: true);
            var __workflow_openExchangePowerShellRunspaceusername = WorkflowExpression.Compile(openExchangePowerShellRunspaceusername, nameof(openExchangePowerShellRunspaceusername), required: false);
            var __workflow_openExchangePowerShellRunspacepassword = WorkflowExpression.Compile(openExchangePowerShellRunspacepassword, nameof(openExchangePowerShellRunspacepassword), required: false);
            var __workflow_openExchangePowerShellRunspaceuseSSL = WorkflowExpression.Compile(openExchangePowerShellRunspaceuseSSL, nameof(openExchangePowerShellRunspaceuseSSL), required: false);
            var __workflow_openExchangePowerShellRunspaceconnectionMethod = WorkflowExpression.Compile(openExchangePowerShellRunspaceconnectionMethod, nameof(openExchangePowerShellRunspaceconnectionMethod), required: false);
            var __workflow_openExchangePowerShellRunspaceauthenticationMechanism = WorkflowExpression.Compile(openExchangePowerShellRunspaceauthenticationMechanism, nameof(openExchangePowerShellRunspaceauthenticationMechanism), required: false);
            var __workflow_openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected = WorkflowExpression.Compile(openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected, nameof(openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected), required: false);
            var __workflow_openExchangePowerShellRunspacecommandTypesToImportLocally = WorkflowExpression.Compile(openExchangePowerShellRunspacecommandTypesToImportLocally, nameof(openExchangePowerShellRunspacecommandTypesToImportLocally), required: false);
            var __workflow_openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV = WorkflowExpression.Compile(openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV, nameof(openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV), required: false);
            return new DeferredBodyAction<OpenExchangePowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenExchangePowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openExchangePowerShellRunspace = new JObject();
                var openExchangePowerShellRunspacepropCount = 0;
                if (__workflow_openExchangePowerShellRunspaceusername != null)
                {
                    openExchangePowerShellRunspace["Username"] = ExpressionConverter.ConvertO(__workflow_openExchangePowerShellRunspaceusername);
                    openExchangePowerShellRunspacepropCount++;
                }

                if (__workflow_openExchangePowerShellRunspacepassword != null)
                {
                    openExchangePowerShellRunspace["Password"] = ExpressionConverter.ConvertO(__workflow_openExchangePowerShellRunspacepassword);
                    openExchangePowerShellRunspacepropCount++;
                }

                openExchangePowerShellRunspacepropCount++;
                openExchangePowerShellRunspace["ExchangeServerFQDN"] = ExpressionConverter.ConvertO(__workflow_openExchangePowerShellRunspaceexchangeServerFQDN);
                if (__workflow_openExchangePowerShellRunspaceuseSSL != null)
                {
                    if (__workflow_openExchangePowerShellRunspaceuseSSL != null)
                    {
                        openExchangePowerShellRunspace["UseSSL"] = ExpressionConverter.ConvertO(__workflow_openExchangePowerShellRunspaceuseSSL);
                        openExchangePowerShellRunspacepropCount++;
                    }

                    openExchangePowerShellRunspacepropCount++;
                }
                else
                {
                    openExchangePowerShellRunspace["UseSSL"] = false;
                    openExchangePowerShellRunspacepropCount++;
                }

                if (__workflow_openExchangePowerShellRunspaceconnectionMethod != null)
                {
                    if (__workflow_openExchangePowerShellRunspaceconnectionMethod != null)
                    {
                        openExchangePowerShellRunspace["ConnectionMethod"] = ExpressionConverter.ConvertO(__workflow_openExchangePowerShellRunspaceconnectionMethod);
                        openExchangePowerShellRunspacepropCount++;
                    }

                    openExchangePowerShellRunspacepropCount++;
                }
                else
                {
                    openExchangePowerShellRunspace["ConnectionMethod"] = "Remote";
                    openExchangePowerShellRunspacepropCount++;
                }

                if (__workflow_openExchangePowerShellRunspaceauthenticationMechanism != null)
                {
                    if (__workflow_openExchangePowerShellRunspaceauthenticationMechanism != null)
                    {
                        openExchangePowerShellRunspace["AuthenticationMechanism"] = ExpressionConverter.ConvertO(__workflow_openExchangePowerShellRunspaceauthenticationMechanism);
                        openExchangePowerShellRunspacepropCount++;
                    }

                    openExchangePowerShellRunspacepropCount++;
                }
                else
                {
                    openExchangePowerShellRunspace["AuthenticationMechanism"] = "Kerberos";
                    openExchangePowerShellRunspacepropCount++;
                }

                if (__workflow_openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected != null)
                {
                    if (__workflow_openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected != null)
                    {
                        openExchangePowerShellRunspace["OnlyConnectIfNotAlreadyConnected"] = ExpressionConverter.ConvertO(__workflow_openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected);
                        openExchangePowerShellRunspacepropCount++;
                    }

                    openExchangePowerShellRunspacepropCount++;
                }
                else
                {
                    openExchangePowerShellRunspace["OnlyConnectIfNotAlreadyConnected"] = true;
                    openExchangePowerShellRunspacepropCount++;
                }

                if (__workflow_openExchangePowerShellRunspacecommandTypesToImportLocally != null)
                {
                    if (__workflow_openExchangePowerShellRunspacecommandTypesToImportLocally != null)
                    {
                        openExchangePowerShellRunspace["CommandTypesToImportLocally"] = ExpressionConverter.ConvertO(__workflow_openExchangePowerShellRunspacecommandTypesToImportLocally);
                        openExchangePowerShellRunspacepropCount++;
                    }

                    openExchangePowerShellRunspacepropCount++;
                }
                else
                {
                    openExchangePowerShellRunspace["CommandTypesToImportLocally"] = "All";
                    openExchangePowerShellRunspacepropCount++;
                }

                if (__workflow_openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV != null)
                {
                    openExchangePowerShellRunspace["AdditionalCommandsToImportLocallyCSV"] = ExpressionConverter.ConvertO(__workflow_openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV);
                    openExchangePowerShellRunspacepropCount++;
                }

                openExchangePowerShellRunspacepropCount++;
                openExchangePowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(__workflow_openExchangePowerShellRunspaceworkflow);
                if (openExchangePowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = openExchangePowerShellRunspace;
                }

                return new ApiConnectionAction<OpenExchangePowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsExchangePowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration> IsExchangePowerShellRunspaceOpen(Expression<Func<string>> isExchangePowerShellRunspaceOpenworkflow, Expression<Func<bool>> isExchangePowerShellRunspaceOpentestCommunications = null, Expression<Func<bool>> isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
        {
            var __workflow_isExchangePowerShellRunspaceOpenworkflow = WorkflowExpression.Compile(isExchangePowerShellRunspaceOpenworkflow, nameof(isExchangePowerShellRunspaceOpenworkflow), required: true);
            var __workflow_isExchangePowerShellRunspaceOpentestCommunications = WorkflowExpression.Compile(isExchangePowerShellRunspaceOpentestCommunications, nameof(isExchangePowerShellRunspaceOpentestCommunications), required: false);
            var __workflow_isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID = WorkflowExpression.Compile(isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID, nameof(isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID), required: false);
            return new DeferredBodyAction<IsExchangePowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/IsExchangePowerShellRunspaceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isExchangePowerShellRunspaceOpen = new JObject();
                var isExchangePowerShellRunspaceOpenpropCount = 0;
                if (__workflow_isExchangePowerShellRunspaceOpentestCommunications != null)
                {
                    if (__workflow_isExchangePowerShellRunspaceOpentestCommunications != null)
                    {
                        isExchangePowerShellRunspaceOpen["TestCommunications"] = ExpressionConverter.ConvertO(__workflow_isExchangePowerShellRunspaceOpentestCommunications);
                        isExchangePowerShellRunspaceOpenpropCount++;
                    }

                    isExchangePowerShellRunspaceOpenpropCount++;
                }
                else
                {
                    isExchangePowerShellRunspaceOpen["TestCommunications"] = true;
                    isExchangePowerShellRunspaceOpenpropCount++;
                }

                if (__workflow_isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID != null)
                {
                    if (__workflow_isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID != null)
                    {
                        isExchangePowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = ExpressionConverter.ConvertO(__workflow_isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID);
                        isExchangePowerShellRunspaceOpenpropCount++;
                    }

                    isExchangePowerShellRunspaceOpenpropCount++;
                }
                else
                {
                    isExchangePowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = false;
                    isExchangePowerShellRunspaceOpenpropCount++;
                }

                isExchangePowerShellRunspaceOpenpropCount++;
                isExchangePowerShellRunspaceOpen["Workflow"] = ExpressionConverter.ConvertO(__workflow_isExchangePowerShellRunspaceOpenworkflow);
                if (isExchangePowerShellRunspaceOpenpropCount > 0)
                {
                    callPayload.Body = isExchangePowerShellRunspaceOpen;
                }

                return new ApiConnectionAction<IsExchangePowerShellRunspaceOpenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunExchangePowerShellAutomationScriptResponse, ApiConnectionActionConfiguration> RunExchangePowerShellAutomationScript(Expression<Func<string>> runExchangePowerShellAutomationScriptworkflow, Expression<Func<string>> runExchangePowerShellAutomationScriptpowerShellScriptContents = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptisNoResultAnError = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptreturnComplexTypes = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptreturnBooleanAsBoolean = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptreturnNumericAsDecimal = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptreturnDateAsDate = null, Expression<Func<string>> runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptrunScriptAsThread = null, Expression<Func<int>> runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId = null, Expression<Func<int>> runExchangePowerShellAutomationScriptsecondsToWaitForThread = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptscriptContainsStoredPassword = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptlogVerboseOutput = null, Expression<Func<string>> runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON = null, Expression<Func<string>> runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON = null, Expression<Func<runExchangePowerShellAutomationScriptpowerShellCommandParametersInputItem[]>> runExchangePowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            var __workflow_runExchangePowerShellAutomationScriptworkflow = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptworkflow, nameof(runExchangePowerShellAutomationScriptworkflow), required: true);
            var __workflow_runExchangePowerShellAutomationScriptpowerShellScriptContents = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptpowerShellScriptContents, nameof(runExchangePowerShellAutomationScriptpowerShellScriptContents), required: false);
            var __workflow_runExchangePowerShellAutomationScriptisNoResultAnError = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptisNoResultAnError, nameof(runExchangePowerShellAutomationScriptisNoResultAnError), required: false);
            var __workflow_runExchangePowerShellAutomationScriptreturnComplexTypes = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptreturnComplexTypes, nameof(runExchangePowerShellAutomationScriptreturnComplexTypes), required: false);
            var __workflow_runExchangePowerShellAutomationScriptreturnBooleanAsBoolean = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptreturnBooleanAsBoolean, nameof(runExchangePowerShellAutomationScriptreturnBooleanAsBoolean), required: false);
            var __workflow_runExchangePowerShellAutomationScriptreturnNumericAsDecimal = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptreturnNumericAsDecimal, nameof(runExchangePowerShellAutomationScriptreturnNumericAsDecimal), required: false);
            var __workflow_runExchangePowerShellAutomationScriptreturnDateAsDate = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptreturnDateAsDate, nameof(runExchangePowerShellAutomationScriptreturnDateAsDate), required: false);
            var __workflow_runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON, nameof(runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON), required: false);
            var __workflow_runExchangePowerShellAutomationScriptrunScriptAsThread = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptrunScriptAsThread, nameof(runExchangePowerShellAutomationScriptrunScriptAsThread), required: false);
            var __workflow_runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId, nameof(runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId), required: false);
            var __workflow_runExchangePowerShellAutomationScriptsecondsToWaitForThread = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptsecondsToWaitForThread, nameof(runExchangePowerShellAutomationScriptsecondsToWaitForThread), required: false);
            var __workflow_runExchangePowerShellAutomationScriptscriptContainsStoredPassword = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptscriptContainsStoredPassword, nameof(runExchangePowerShellAutomationScriptscriptContainsStoredPassword), required: false);
            var __workflow_runExchangePowerShellAutomationScriptlogVerboseOutput = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptlogVerboseOutput, nameof(runExchangePowerShellAutomationScriptlogVerboseOutput), required: false);
            var __workflow_runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON, nameof(runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON), required: false);
            var __workflow_runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON, nameof(runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON), required: false);
            var __workflow_runExchangePowerShellAutomationScriptpowerShellCommandParameters = WorkflowExpression.Compile(runExchangePowerShellAutomationScriptpowerShellCommandParameters, nameof(runExchangePowerShellAutomationScriptpowerShellCommandParameters), required: false);
            return new DeferredBodyAction<RunExchangePowerShellAutomationScriptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/RunExchangePowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runExchangePowerShellAutomationScript = new JObject();
                var runExchangePowerShellAutomationScriptpropCount = 0;
                if (__workflow_runExchangePowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runExchangePowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptpowerShellScriptContents);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runExchangePowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (__workflow_runExchangePowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runExchangePowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptisNoResultAnError);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["IsNoResultAnError"] = false;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runExchangePowerShellAutomationScriptreturnComplexTypes != null)
                {
                    if (__workflow_runExchangePowerShellAutomationScriptreturnComplexTypes != null)
                    {
                        runExchangePowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptreturnComplexTypes);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["ReturnComplexTypes"] = false;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runExchangePowerShellAutomationScriptreturnBooleanAsBoolean != null)
                {
                    if (__workflow_runExchangePowerShellAutomationScriptreturnBooleanAsBoolean != null)
                    {
                        runExchangePowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptreturnBooleanAsBoolean);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["ReturnBooleanAsBoolean"] = false;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runExchangePowerShellAutomationScriptreturnNumericAsDecimal != null)
                {
                    if (__workflow_runExchangePowerShellAutomationScriptreturnNumericAsDecimal != null)
                    {
                        runExchangePowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptreturnNumericAsDecimal);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["ReturnNumericAsDecimal"] = false;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runExchangePowerShellAutomationScriptreturnDateAsDate != null)
                {
                    if (__workflow_runExchangePowerShellAutomationScriptreturnDateAsDate != null)
                    {
                        runExchangePowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptreturnDateAsDate);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["ReturnDateAsDate"] = false;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON != null)
                {
                    runExchangePowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runExchangePowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (__workflow_runExchangePowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runExchangePowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptrunScriptAsThread);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["RunScriptAsThread"] = false;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId != null)
                {
                    runExchangePowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runExchangePowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (__workflow_runExchangePowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runExchangePowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptsecondsToWaitForThread);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["SecondsToWaitForThread"] = 90;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runExchangePowerShellAutomationScriptscriptContainsStoredPassword != null)
                {
                    if (__workflow_runExchangePowerShellAutomationScriptscriptContainsStoredPassword != null)
                    {
                        runExchangePowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptscriptContainsStoredPassword);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["ScriptContainsStoredPassword"] = true;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runExchangePowerShellAutomationScriptlogVerboseOutput != null)
                {
                    if (__workflow_runExchangePowerShellAutomationScriptlogVerboseOutput != null)
                    {
                        runExchangePowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptlogVerboseOutput);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["LogVerboseOutput"] = false;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON != null)
                {
                    runExchangePowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runExchangePowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runExchangePowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runExchangePowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptpowerShellCommandParameters);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                runExchangePowerShellAutomationScriptpropCount++;
                runExchangePowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScriptworkflow);
                if (runExchangePowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runExchangePowerShellAutomationScript;
                }

                return new ApiConnectionAction<RunExchangePowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseExchangePowerShellRunspaceResponse, ApiConnectionActionConfiguration> CloseExchangePowerShellRunspace(Expression<Func<string>> closeExchangePowerShellRunspaceworkflow)
        {
            var __workflow_closeExchangePowerShellRunspaceworkflow = WorkflowExpression.Compile(closeExchangePowerShellRunspaceworkflow, nameof(closeExchangePowerShellRunspaceworkflow), required: true);
            return new DeferredBodyAction<CloseExchangePowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/CloseExchangePowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var closeExchangePowerShellRunspace = new JObject();
                var closeExchangePowerShellRunspacepropCount = 0;
                closeExchangePowerShellRunspacepropCount++;
                closeExchangePowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(__workflow_closeExchangePowerShellRunspaceworkflow);
                if (closeExchangePowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = closeExchangePowerShellRunspace;
                }

                return new ApiConnectionAction<CloseExchangePowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxResponse, ApiConnectionActionConfiguration> ExchangeGetMailbox(Expression<Func<string>> exchangeGetMailboxworkflow, Expression<Func<string>> exchangeGetMailboxidentity = null, Expression<Func<string>> exchangeGetMailboxfilterPropertyName = null, Expression<Func<exchangeGetMailboxfilterPropertyComparisonInput>> exchangeGetMailboxfilterPropertyComparison = null, Expression<Func<string>> exchangeGetMailboxfilterPropertyValue = null, Expression<Func<exchangeGetMailboxrecipientTypeDetailsInput>> exchangeGetMailboxrecipientTypeDetails = null, Expression<Func<bool>> exchangeGetMailboxnoResultIsAnException = null)
        {
            var __workflow_exchangeGetMailboxworkflow = WorkflowExpression.Compile(exchangeGetMailboxworkflow, nameof(exchangeGetMailboxworkflow), required: true);
            var __workflow_exchangeGetMailboxidentity = WorkflowExpression.Compile(exchangeGetMailboxidentity, nameof(exchangeGetMailboxidentity), required: false);
            var __workflow_exchangeGetMailboxfilterPropertyName = WorkflowExpression.Compile(exchangeGetMailboxfilterPropertyName, nameof(exchangeGetMailboxfilterPropertyName), required: false);
            var __workflow_exchangeGetMailboxfilterPropertyComparison = WorkflowExpression.Compile(exchangeGetMailboxfilterPropertyComparison, nameof(exchangeGetMailboxfilterPropertyComparison), required: false);
            var __workflow_exchangeGetMailboxfilterPropertyValue = WorkflowExpression.Compile(exchangeGetMailboxfilterPropertyValue, nameof(exchangeGetMailboxfilterPropertyValue), required: false);
            var __workflow_exchangeGetMailboxrecipientTypeDetails = WorkflowExpression.Compile(exchangeGetMailboxrecipientTypeDetails, nameof(exchangeGetMailboxrecipientTypeDetails), required: false);
            var __workflow_exchangeGetMailboxnoResultIsAnException = WorkflowExpression.Compile(exchangeGetMailboxnoResultIsAnException, nameof(exchangeGetMailboxnoResultIsAnException), required: false);
            return new DeferredBodyAction<ExchangeGetMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetMailbox = new JObject();
                var exchangeGetMailboxpropCount = 0;
                if (__workflow_exchangeGetMailboxidentity != null)
                {
                    exchangeGetMailbox["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeGetMailboxidentity);
                    exchangeGetMailboxpropCount++;
                }

                if (__workflow_exchangeGetMailboxfilterPropertyName != null)
                {
                    exchangeGetMailbox["FilterPropertyName"] = ExpressionConverter.ConvertO(__workflow_exchangeGetMailboxfilterPropertyName);
                    exchangeGetMailboxpropCount++;
                }

                if (__workflow_exchangeGetMailboxfilterPropertyComparison != null)
                {
                    if (__workflow_exchangeGetMailboxfilterPropertyComparison != null)
                    {
                        exchangeGetMailbox["FilterPropertyComparison"] = ExpressionConverter.ConvertO(__workflow_exchangeGetMailboxfilterPropertyComparison);
                        exchangeGetMailboxpropCount++;
                    }

                    exchangeGetMailboxpropCount++;
                }
                else
                {
                    exchangeGetMailbox["FilterPropertyComparison"] = "Equals";
                    exchangeGetMailboxpropCount++;
                }

                if (__workflow_exchangeGetMailboxfilterPropertyValue != null)
                {
                    exchangeGetMailbox["FilterPropertyValue"] = ExpressionConverter.ConvertO(__workflow_exchangeGetMailboxfilterPropertyValue);
                    exchangeGetMailboxpropCount++;
                }

                if (__workflow_exchangeGetMailboxrecipientTypeDetails != null)
                {
                    exchangeGetMailbox["RecipientTypeDetails"] = ExpressionConverter.ConvertO(__workflow_exchangeGetMailboxrecipientTypeDetails);
                    exchangeGetMailboxpropCount++;
                }

                if (__workflow_exchangeGetMailboxnoResultIsAnException != null)
                {
                    if (__workflow_exchangeGetMailboxnoResultIsAnException != null)
                    {
                        exchangeGetMailbox["NoResultIsAnException"] = ExpressionConverter.ConvertO(__workflow_exchangeGetMailboxnoResultIsAnException);
                        exchangeGetMailboxpropCount++;
                    }

                    exchangeGetMailboxpropCount++;
                }
                else
                {
                    exchangeGetMailbox["NoResultIsAnException"] = false;
                    exchangeGetMailboxpropCount++;
                }

                exchangeGetMailboxpropCount++;
                exchangeGetMailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeGetMailboxworkflow);
                if (exchangeGetMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeGetMailbox;
                }

                return new ApiConnectionAction<ExchangeGetMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDoesMailboxExistResponse, ApiConnectionActionConfiguration> ExchangeDoesMailboxExist(Expression<Func<string>> exchangeDoesMailboxExistworkflow, Expression<Func<string>> exchangeDoesMailboxExistidentity = null, Expression<Func<string>> exchangeDoesMailboxExistfilterPropertyName = null, Expression<Func<exchangeDoesMailboxExistfilterPropertyComparisonInput>> exchangeDoesMailboxExistfilterPropertyComparison = null, Expression<Func<string>> exchangeDoesMailboxExistfilterPropertyValue = null, Expression<Func<exchangeDoesMailboxExistrecipientTypeDetailsInput>> exchangeDoesMailboxExistrecipientTypeDetails = null)
        {
            var __workflow_exchangeDoesMailboxExistworkflow = WorkflowExpression.Compile(exchangeDoesMailboxExistworkflow, nameof(exchangeDoesMailboxExistworkflow), required: true);
            var __workflow_exchangeDoesMailboxExistidentity = WorkflowExpression.Compile(exchangeDoesMailboxExistidentity, nameof(exchangeDoesMailboxExistidentity), required: false);
            var __workflow_exchangeDoesMailboxExistfilterPropertyName = WorkflowExpression.Compile(exchangeDoesMailboxExistfilterPropertyName, nameof(exchangeDoesMailboxExistfilterPropertyName), required: false);
            var __workflow_exchangeDoesMailboxExistfilterPropertyComparison = WorkflowExpression.Compile(exchangeDoesMailboxExistfilterPropertyComparison, nameof(exchangeDoesMailboxExistfilterPropertyComparison), required: false);
            var __workflow_exchangeDoesMailboxExistfilterPropertyValue = WorkflowExpression.Compile(exchangeDoesMailboxExistfilterPropertyValue, nameof(exchangeDoesMailboxExistfilterPropertyValue), required: false);
            var __workflow_exchangeDoesMailboxExistrecipientTypeDetails = WorkflowExpression.Compile(exchangeDoesMailboxExistrecipientTypeDetails, nameof(exchangeDoesMailboxExistrecipientTypeDetails), required: false);
            return new DeferredBodyAction<ExchangeDoesMailboxExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDoesMailboxExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeDoesMailboxExist = new JObject();
                var exchangeDoesMailboxExistpropCount = 0;
                if (__workflow_exchangeDoesMailboxExistidentity != null)
                {
                    exchangeDoesMailboxExist["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeDoesMailboxExistidentity);
                    exchangeDoesMailboxExistpropCount++;
                }

                if (__workflow_exchangeDoesMailboxExistfilterPropertyName != null)
                {
                    exchangeDoesMailboxExist["FilterPropertyName"] = ExpressionConverter.ConvertO(__workflow_exchangeDoesMailboxExistfilterPropertyName);
                    exchangeDoesMailboxExistpropCount++;
                }

                if (__workflow_exchangeDoesMailboxExistfilterPropertyComparison != null)
                {
                    if (__workflow_exchangeDoesMailboxExistfilterPropertyComparison != null)
                    {
                        exchangeDoesMailboxExist["FilterPropertyComparison"] = ExpressionConverter.ConvertO(__workflow_exchangeDoesMailboxExistfilterPropertyComparison);
                        exchangeDoesMailboxExistpropCount++;
                    }

                    exchangeDoesMailboxExistpropCount++;
                }
                else
                {
                    exchangeDoesMailboxExist["FilterPropertyComparison"] = "Equals";
                    exchangeDoesMailboxExistpropCount++;
                }

                if (__workflow_exchangeDoesMailboxExistfilterPropertyValue != null)
                {
                    exchangeDoesMailboxExist["FilterPropertyValue"] = ExpressionConverter.ConvertO(__workflow_exchangeDoesMailboxExistfilterPropertyValue);
                    exchangeDoesMailboxExistpropCount++;
                }

                if (__workflow_exchangeDoesMailboxExistrecipientTypeDetails != null)
                {
                    exchangeDoesMailboxExist["RecipientTypeDetails"] = ExpressionConverter.ConvertO(__workflow_exchangeDoesMailboxExistrecipientTypeDetails);
                    exchangeDoesMailboxExistpropCount++;
                }

                exchangeDoesMailboxExistpropCount++;
                exchangeDoesMailboxExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeDoesMailboxExistworkflow);
                if (exchangeDoesMailboxExistpropCount > 0)
                {
                    callPayload.Body = exchangeDoesMailboxExist;
                }

                return new ApiConnectionAction<ExchangeDoesMailboxExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddDistributionGroupMemberResponse, ApiConnectionActionConfiguration> ExchangeAddDistributionGroupMember(Expression<Func<string>> exchangeAddDistributionGroupMemberidentity, Expression<Func<string>> exchangeAddDistributionGroupMembermember, Expression<Func<string>> exchangeAddDistributionGroupMemberworkflow)
        {
            var __workflow_exchangeAddDistributionGroupMemberidentity = WorkflowExpression.Compile(exchangeAddDistributionGroupMemberidentity, nameof(exchangeAddDistributionGroupMemberidentity), required: true);
            var __workflow_exchangeAddDistributionGroupMembermember = WorkflowExpression.Compile(exchangeAddDistributionGroupMembermember, nameof(exchangeAddDistributionGroupMembermember), required: true);
            var __workflow_exchangeAddDistributionGroupMemberworkflow = WorkflowExpression.Compile(exchangeAddDistributionGroupMemberworkflow, nameof(exchangeAddDistributionGroupMemberworkflow), required: true);
            return new DeferredBodyAction<ExchangeAddDistributionGroupMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeAddDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeAddDistributionGroupMember = new JObject();
                var exchangeAddDistributionGroupMemberpropCount = 0;
                exchangeAddDistributionGroupMemberpropCount++;
                exchangeAddDistributionGroupMember["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeAddDistributionGroupMemberidentity);
                exchangeAddDistributionGroupMemberpropCount++;
                exchangeAddDistributionGroupMember["Member"] = ExpressionConverter.ConvertO(__workflow_exchangeAddDistributionGroupMembermember);
                exchangeAddDistributionGroupMemberpropCount++;
                exchangeAddDistributionGroupMember["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeAddDistributionGroupMemberworkflow);
                if (exchangeAddDistributionGroupMemberpropCount > 0)
                {
                    callPayload.Body = exchangeAddDistributionGroupMember;
                }

                return new ApiConnectionAction<ExchangeAddDistributionGroupMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupMemberResponse, ApiConnectionActionConfiguration> ExchangeRemoveDistributionGroupMember(Expression<Func<string>> exchangeRemoveDistributionGroupMemberidentity, Expression<Func<string>> exchangeRemoveDistributionGroupMembermember, Expression<Func<string>> exchangeRemoveDistributionGroupMemberworkflow, Expression<Func<bool>> exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck = null)
        {
            var __workflow_exchangeRemoveDistributionGroupMemberidentity = WorkflowExpression.Compile(exchangeRemoveDistributionGroupMemberidentity, nameof(exchangeRemoveDistributionGroupMemberidentity), required: true);
            var __workflow_exchangeRemoveDistributionGroupMembermember = WorkflowExpression.Compile(exchangeRemoveDistributionGroupMembermember, nameof(exchangeRemoveDistributionGroupMembermember), required: true);
            var __workflow_exchangeRemoveDistributionGroupMemberworkflow = WorkflowExpression.Compile(exchangeRemoveDistributionGroupMemberworkflow, nameof(exchangeRemoveDistributionGroupMemberworkflow), required: true);
            var __workflow_exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck = WorkflowExpression.Compile(exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck, nameof(exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck), required: false);
            return new DeferredBodyAction<ExchangeRemoveDistributionGroupMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeRemoveDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeRemoveDistributionGroupMember = new JObject();
                var exchangeRemoveDistributionGroupMemberpropCount = 0;
                exchangeRemoveDistributionGroupMemberpropCount++;
                exchangeRemoveDistributionGroupMember["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeRemoveDistributionGroupMemberidentity);
                exchangeRemoveDistributionGroupMemberpropCount++;
                exchangeRemoveDistributionGroupMember["Member"] = ExpressionConverter.ConvertO(__workflow_exchangeRemoveDistributionGroupMembermember);
                if (__workflow_exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                {
                    if (__workflow_exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                    {
                        exchangeRemoveDistributionGroupMember["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(__workflow_exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck);
                        exchangeRemoveDistributionGroupMemberpropCount++;
                    }

                    exchangeRemoveDistributionGroupMemberpropCount++;
                }
                else
                {
                    exchangeRemoveDistributionGroupMember["BypassSecurityGroupManagerCheck"] = true;
                    exchangeRemoveDistributionGroupMemberpropCount++;
                }

                exchangeRemoveDistributionGroupMemberpropCount++;
                exchangeRemoveDistributionGroupMember["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeRemoveDistributionGroupMemberworkflow);
                if (exchangeRemoveDistributionGroupMemberpropCount > 0)
                {
                    callPayload.Body = exchangeRemoveDistributionGroupMember;
                }

                return new ApiConnectionAction<ExchangeRemoveDistributionGroupMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupResponse, ApiConnectionActionConfiguration> ExchangeGetDistributionGroup(Expression<Func<string>> exchangeGetDistributionGroupworkflow, Expression<Func<string>> exchangeGetDistributionGroupidentity = null, Expression<Func<string>> exchangeGetDistributionGroupfilterPropertyName = null, Expression<Func<exchangeGetDistributionGroupfilterPropertyComparisonInput>> exchangeGetDistributionGroupfilterPropertyComparison = null, Expression<Func<string>> exchangeGetDistributionGroupfilterPropertyValue = null, Expression<Func<bool>> exchangeGetDistributionGroupnoResultIsAnException = null)
        {
            var __workflow_exchangeGetDistributionGroupworkflow = WorkflowExpression.Compile(exchangeGetDistributionGroupworkflow, nameof(exchangeGetDistributionGroupworkflow), required: true);
            var __workflow_exchangeGetDistributionGroupidentity = WorkflowExpression.Compile(exchangeGetDistributionGroupidentity, nameof(exchangeGetDistributionGroupidentity), required: false);
            var __workflow_exchangeGetDistributionGroupfilterPropertyName = WorkflowExpression.Compile(exchangeGetDistributionGroupfilterPropertyName, nameof(exchangeGetDistributionGroupfilterPropertyName), required: false);
            var __workflow_exchangeGetDistributionGroupfilterPropertyComparison = WorkflowExpression.Compile(exchangeGetDistributionGroupfilterPropertyComparison, nameof(exchangeGetDistributionGroupfilterPropertyComparison), required: false);
            var __workflow_exchangeGetDistributionGroupfilterPropertyValue = WorkflowExpression.Compile(exchangeGetDistributionGroupfilterPropertyValue, nameof(exchangeGetDistributionGroupfilterPropertyValue), required: false);
            var __workflow_exchangeGetDistributionGroupnoResultIsAnException = WorkflowExpression.Compile(exchangeGetDistributionGroupnoResultIsAnException, nameof(exchangeGetDistributionGroupnoResultIsAnException), required: false);
            return new DeferredBodyAction<ExchangeGetDistributionGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetDistributionGroup = new JObject();
                var exchangeGetDistributionGrouppropCount = 0;
                if (__workflow_exchangeGetDistributionGroupidentity != null)
                {
                    exchangeGetDistributionGroup["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeGetDistributionGroupidentity);
                    exchangeGetDistributionGrouppropCount++;
                }

                if (__workflow_exchangeGetDistributionGroupfilterPropertyName != null)
                {
                    exchangeGetDistributionGroup["FilterPropertyName"] = ExpressionConverter.ConvertO(__workflow_exchangeGetDistributionGroupfilterPropertyName);
                    exchangeGetDistributionGrouppropCount++;
                }

                if (__workflow_exchangeGetDistributionGroupfilterPropertyComparison != null)
                {
                    if (__workflow_exchangeGetDistributionGroupfilterPropertyComparison != null)
                    {
                        exchangeGetDistributionGroup["FilterPropertyComparison"] = ExpressionConverter.ConvertO(__workflow_exchangeGetDistributionGroupfilterPropertyComparison);
                        exchangeGetDistributionGrouppropCount++;
                    }

                    exchangeGetDistributionGrouppropCount++;
                }
                else
                {
                    exchangeGetDistributionGroup["FilterPropertyComparison"] = "Equals";
                    exchangeGetDistributionGrouppropCount++;
                }

                if (__workflow_exchangeGetDistributionGroupfilterPropertyValue != null)
                {
                    exchangeGetDistributionGroup["FilterPropertyValue"] = ExpressionConverter.ConvertO(__workflow_exchangeGetDistributionGroupfilterPropertyValue);
                    exchangeGetDistributionGrouppropCount++;
                }

                if (__workflow_exchangeGetDistributionGroupnoResultIsAnException != null)
                {
                    if (__workflow_exchangeGetDistributionGroupnoResultIsAnException != null)
                    {
                        exchangeGetDistributionGroup["NoResultIsAnException"] = ExpressionConverter.ConvertO(__workflow_exchangeGetDistributionGroupnoResultIsAnException);
                        exchangeGetDistributionGrouppropCount++;
                    }

                    exchangeGetDistributionGrouppropCount++;
                }
                else
                {
                    exchangeGetDistributionGroup["NoResultIsAnException"] = false;
                    exchangeGetDistributionGrouppropCount++;
                }

                exchangeGetDistributionGrouppropCount++;
                exchangeGetDistributionGroup["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeGetDistributionGroupworkflow);
                if (exchangeGetDistributionGrouppropCount > 0)
                {
                    callPayload.Body = exchangeGetDistributionGroup;
                }

                return new ApiConnectionAction<ExchangeGetDistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupMembersResponse, ApiConnectionActionConfiguration> ExchangeGetDistributionGroupMembers(Expression<Func<string>> exchangeGetDistributionGroupMembersidentity, Expression<Func<string>> exchangeGetDistributionGroupMembersworkflow)
        {
            var __workflow_exchangeGetDistributionGroupMembersidentity = WorkflowExpression.Compile(exchangeGetDistributionGroupMembersidentity, nameof(exchangeGetDistributionGroupMembersidentity), required: true);
            var __workflow_exchangeGetDistributionGroupMembersworkflow = WorkflowExpression.Compile(exchangeGetDistributionGroupMembersworkflow, nameof(exchangeGetDistributionGroupMembersworkflow), required: true);
            return new DeferredBodyAction<ExchangeGetDistributionGroupMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetDistributionGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetDistributionGroupMembers = new JObject();
                var exchangeGetDistributionGroupMemberspropCount = 0;
                exchangeGetDistributionGroupMemberspropCount++;
                exchangeGetDistributionGroupMembers["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeGetDistributionGroupMembersidentity);
                exchangeGetDistributionGroupMemberspropCount++;
                exchangeGetDistributionGroupMembers["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeGetDistributionGroupMembersworkflow);
                if (exchangeGetDistributionGroupMemberspropCount > 0)
                {
                    callPayload.Body = exchangeGetDistributionGroupMembers;
                }

                return new ApiConnectionAction<ExchangeGetDistributionGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxDistributionGroupMembershipResponse, ApiConnectionActionConfiguration> ExchangeGetMailboxDistributionGroupMembership(Expression<Func<string>> exchangeGetMailboxDistributionGroupMembershipidentity, Expression<Func<string>> exchangeGetMailboxDistributionGroupMembershipworkflow)
        {
            var __workflow_exchangeGetMailboxDistributionGroupMembershipidentity = WorkflowExpression.Compile(exchangeGetMailboxDistributionGroupMembershipidentity, nameof(exchangeGetMailboxDistributionGroupMembershipidentity), required: true);
            var __workflow_exchangeGetMailboxDistributionGroupMembershipworkflow = WorkflowExpression.Compile(exchangeGetMailboxDistributionGroupMembershipworkflow, nameof(exchangeGetMailboxDistributionGroupMembershipworkflow), required: true);
            return new DeferredBodyAction<ExchangeGetMailboxDistributionGroupMembershipResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetMailboxDistributionGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetMailboxDistributionGroupMembership = new JObject();
                var exchangeGetMailboxDistributionGroupMembershippropCount = 0;
                exchangeGetMailboxDistributionGroupMembershippropCount++;
                exchangeGetMailboxDistributionGroupMembership["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeGetMailboxDistributionGroupMembershipidentity);
                exchangeGetMailboxDistributionGroupMembershippropCount++;
                exchangeGetMailboxDistributionGroupMembership["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeGetMailboxDistributionGroupMembershipworkflow);
                if (exchangeGetMailboxDistributionGroupMembershippropCount > 0)
                {
                    callPayload.Body = exchangeGetMailboxDistributionGroupMembership;
                }

                return new ApiConnectionAction<ExchangeGetMailboxDistributionGroupMembershipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewDistributionGroupResponse, ApiConnectionActionConfiguration> ExchangeNewDistributionGroup(Expression<Func<string>> exchangeNewDistributionGroupname, Expression<Func<string>> exchangeNewDistributionGroupworkflow, Expression<Func<string>> exchangeNewDistributionGroupalias = null, Expression<Func<string>> exchangeNewDistributionGroupdisplayName = null, Expression<Func<string>> exchangeNewDistributionGroupnotes = null, Expression<Func<string>> exchangeNewDistributionGroupmanagedBy = null, Expression<Func<string>> exchangeNewDistributionGroupmembers = null, Expression<Func<string>> exchangeNewDistributionGrouporganizationalUnit = null, Expression<Func<string>> exchangeNewDistributionGroupprimarySmtpAddress = null, Expression<Func<exchangeNewDistributionGroupmemberDepartRestrictionInput>> exchangeNewDistributionGroupmemberDepartRestriction = null, Expression<Func<exchangeNewDistributionGroupmemberJoinRestrictionInput>> exchangeNewDistributionGroupmemberJoinRestriction = null, Expression<Func<bool>> exchangeNewDistributionGrouprequireSenderAuthenticationEnabled = null, Expression<Func<exchangeNewDistributionGrouptypeInput>> exchangeNewDistributionGrouptype = null, Expression<Func<bool>> exchangeNewDistributionGrouperrorIfGroupAlreadyExists = null)
        {
            var __workflow_exchangeNewDistributionGroupname = WorkflowExpression.Compile(exchangeNewDistributionGroupname, nameof(exchangeNewDistributionGroupname), required: true);
            var __workflow_exchangeNewDistributionGroupworkflow = WorkflowExpression.Compile(exchangeNewDistributionGroupworkflow, nameof(exchangeNewDistributionGroupworkflow), required: true);
            var __workflow_exchangeNewDistributionGroupalias = WorkflowExpression.Compile(exchangeNewDistributionGroupalias, nameof(exchangeNewDistributionGroupalias), required: false);
            var __workflow_exchangeNewDistributionGroupdisplayName = WorkflowExpression.Compile(exchangeNewDistributionGroupdisplayName, nameof(exchangeNewDistributionGroupdisplayName), required: false);
            var __workflow_exchangeNewDistributionGroupnotes = WorkflowExpression.Compile(exchangeNewDistributionGroupnotes, nameof(exchangeNewDistributionGroupnotes), required: false);
            var __workflow_exchangeNewDistributionGroupmanagedBy = WorkflowExpression.Compile(exchangeNewDistributionGroupmanagedBy, nameof(exchangeNewDistributionGroupmanagedBy), required: false);
            var __workflow_exchangeNewDistributionGroupmembers = WorkflowExpression.Compile(exchangeNewDistributionGroupmembers, nameof(exchangeNewDistributionGroupmembers), required: false);
            var __workflow_exchangeNewDistributionGrouporganizationalUnit = WorkflowExpression.Compile(exchangeNewDistributionGrouporganizationalUnit, nameof(exchangeNewDistributionGrouporganizationalUnit), required: false);
            var __workflow_exchangeNewDistributionGroupprimarySmtpAddress = WorkflowExpression.Compile(exchangeNewDistributionGroupprimarySmtpAddress, nameof(exchangeNewDistributionGroupprimarySmtpAddress), required: false);
            var __workflow_exchangeNewDistributionGroupmemberDepartRestriction = WorkflowExpression.Compile(exchangeNewDistributionGroupmemberDepartRestriction, nameof(exchangeNewDistributionGroupmemberDepartRestriction), required: false);
            var __workflow_exchangeNewDistributionGroupmemberJoinRestriction = WorkflowExpression.Compile(exchangeNewDistributionGroupmemberJoinRestriction, nameof(exchangeNewDistributionGroupmemberJoinRestriction), required: false);
            var __workflow_exchangeNewDistributionGrouprequireSenderAuthenticationEnabled = WorkflowExpression.Compile(exchangeNewDistributionGrouprequireSenderAuthenticationEnabled, nameof(exchangeNewDistributionGrouprequireSenderAuthenticationEnabled), required: false);
            var __workflow_exchangeNewDistributionGrouptype = WorkflowExpression.Compile(exchangeNewDistributionGrouptype, nameof(exchangeNewDistributionGrouptype), required: false);
            var __workflow_exchangeNewDistributionGrouperrorIfGroupAlreadyExists = WorkflowExpression.Compile(exchangeNewDistributionGrouperrorIfGroupAlreadyExists, nameof(exchangeNewDistributionGrouperrorIfGroupAlreadyExists), required: false);
            return new DeferredBodyAction<ExchangeNewDistributionGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeNewDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeNewDistributionGroup = new JObject();
                var exchangeNewDistributionGrouppropCount = 0;
                exchangeNewDistributionGrouppropCount++;
                exchangeNewDistributionGroup["Name"] = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGroupname);
                if (__workflow_exchangeNewDistributionGroupalias != null)
                {
                    exchangeNewDistributionGroup["Alias"] = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGroupalias);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (__workflow_exchangeNewDistributionGroupdisplayName != null)
                {
                    exchangeNewDistributionGroup["DisplayName"] = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGroupdisplayName);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (__workflow_exchangeNewDistributionGroupnotes != null)
                {
                    exchangeNewDistributionGroup["Notes"] = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGroupnotes);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (__workflow_exchangeNewDistributionGroupmanagedBy != null)
                {
                    exchangeNewDistributionGroup["ManagedBy"] = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGroupmanagedBy);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (__workflow_exchangeNewDistributionGroupmembers != null)
                {
                    exchangeNewDistributionGroup["Members"] = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGroupmembers);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (__workflow_exchangeNewDistributionGrouporganizationalUnit != null)
                {
                    exchangeNewDistributionGroup["OrganizationalUnit"] = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGrouporganizationalUnit);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (__workflow_exchangeNewDistributionGroupprimarySmtpAddress != null)
                {
                    exchangeNewDistributionGroup["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGroupprimarySmtpAddress);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (__workflow_exchangeNewDistributionGroupmemberDepartRestriction != null)
                {
                    if (__workflow_exchangeNewDistributionGroupmemberDepartRestriction != null)
                    {
                        exchangeNewDistributionGroup["MemberDepartRestriction"] = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGroupmemberDepartRestriction);
                        exchangeNewDistributionGrouppropCount++;
                    }

                    exchangeNewDistributionGrouppropCount++;
                }
                else
                {
                    exchangeNewDistributionGroup["MemberDepartRestriction"] = "Open";
                    exchangeNewDistributionGrouppropCount++;
                }

                if (__workflow_exchangeNewDistributionGroupmemberJoinRestriction != null)
                {
                    if (__workflow_exchangeNewDistributionGroupmemberJoinRestriction != null)
                    {
                        exchangeNewDistributionGroup["MemberJoinRestriction"] = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGroupmemberJoinRestriction);
                        exchangeNewDistributionGrouppropCount++;
                    }

                    exchangeNewDistributionGrouppropCount++;
                }
                else
                {
                    exchangeNewDistributionGroup["MemberJoinRestriction"] = "Closed";
                    exchangeNewDistributionGrouppropCount++;
                }

                if (__workflow_exchangeNewDistributionGrouprequireSenderAuthenticationEnabled != null)
                {
                    if (__workflow_exchangeNewDistributionGrouprequireSenderAuthenticationEnabled != null)
                    {
                        exchangeNewDistributionGroup["RequireSenderAuthenticationEnabled"] = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGrouprequireSenderAuthenticationEnabled);
                        exchangeNewDistributionGrouppropCount++;
                    }

                    exchangeNewDistributionGrouppropCount++;
                }
                else
                {
                    exchangeNewDistributionGroup["RequireSenderAuthenticationEnabled"] = false;
                    exchangeNewDistributionGrouppropCount++;
                }

                if (__workflow_exchangeNewDistributionGrouptype != null)
                {
                    if (__workflow_exchangeNewDistributionGrouptype != null)
                    {
                        exchangeNewDistributionGroup["Type"] = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGrouptype);
                        exchangeNewDistributionGrouppropCount++;
                    }

                    exchangeNewDistributionGrouppropCount++;
                }
                else
                {
                    exchangeNewDistributionGroup["Type"] = "Distribution";
                    exchangeNewDistributionGrouppropCount++;
                }

                if (__workflow_exchangeNewDistributionGrouperrorIfGroupAlreadyExists != null)
                {
                    if (__workflow_exchangeNewDistributionGrouperrorIfGroupAlreadyExists != null)
                    {
                        exchangeNewDistributionGroup["ErrorIfGroupAlreadyExists"] = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGrouperrorIfGroupAlreadyExists);
                        exchangeNewDistributionGrouppropCount++;
                    }

                    exchangeNewDistributionGrouppropCount++;
                }
                else
                {
                    exchangeNewDistributionGroup["ErrorIfGroupAlreadyExists"] = true;
                    exchangeNewDistributionGrouppropCount++;
                }

                exchangeNewDistributionGrouppropCount++;
                exchangeNewDistributionGroup["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGroupworkflow);
                if (exchangeNewDistributionGrouppropCount > 0)
                {
                    callPayload.Body = exchangeNewDistributionGroup;
                }

                return new ApiConnectionAction<ExchangeNewDistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupResponse, ApiConnectionActionConfiguration> ExchangeRemoveDistributionGroup(Expression<Func<string>> exchangeRemoveDistributionGroupidentity, Expression<Func<string>> exchangeRemoveDistributionGroupworkflow, Expression<Func<bool>> exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck = null, Expression<Func<bool>> exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist = null)
        {
            var __workflow_exchangeRemoveDistributionGroupidentity = WorkflowExpression.Compile(exchangeRemoveDistributionGroupidentity, nameof(exchangeRemoveDistributionGroupidentity), required: true);
            var __workflow_exchangeRemoveDistributionGroupworkflow = WorkflowExpression.Compile(exchangeRemoveDistributionGroupworkflow, nameof(exchangeRemoveDistributionGroupworkflow), required: true);
            var __workflow_exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck = WorkflowExpression.Compile(exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck, nameof(exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck), required: false);
            var __workflow_exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist = WorkflowExpression.Compile(exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist, nameof(exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist), required: false);
            return new DeferredBodyAction<ExchangeRemoveDistributionGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeRemoveDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeRemoveDistributionGroup = new JObject();
                var exchangeRemoveDistributionGrouppropCount = 0;
                exchangeRemoveDistributionGrouppropCount++;
                exchangeRemoveDistributionGroup["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeRemoveDistributionGroupidentity);
                if (__workflow_exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
                {
                    if (__workflow_exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
                    {
                        exchangeRemoveDistributionGroup["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(__workflow_exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck);
                        exchangeRemoveDistributionGrouppropCount++;
                    }

                    exchangeRemoveDistributionGrouppropCount++;
                }
                else
                {
                    exchangeRemoveDistributionGroup["BypassSecurityGroupManagerCheck"] = true;
                    exchangeRemoveDistributionGrouppropCount++;
                }

                if (__workflow_exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist != null)
                {
                    if (__workflow_exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist != null)
                    {
                        exchangeRemoveDistributionGroup["ErrorIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(__workflow_exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist);
                        exchangeRemoveDistributionGrouppropCount++;
                    }

                    exchangeRemoveDistributionGrouppropCount++;
                }
                else
                {
                    exchangeRemoveDistributionGroup["ErrorIfGroupDoesNotExist"] = false;
                    exchangeRemoveDistributionGrouppropCount++;
                }

                exchangeRemoveDistributionGrouppropCount++;
                exchangeRemoveDistributionGroup["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeRemoveDistributionGroupworkflow);
                if (exchangeRemoveDistributionGrouppropCount > 0)
                {
                    callPayload.Body = exchangeRemoveDistributionGroup;
                }

                return new ApiConnectionAction<ExchangeRemoveDistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddMailboxPermissionResponse, ApiConnectionActionConfiguration> ExchangeAddMailboxPermission(Expression<Func<string>> exchangeAddMailboxPermissionidentity, Expression<Func<string>> exchangeAddMailboxPermissionuser, Expression<Func<string>> exchangeAddMailboxPermissionaccessRights, Expression<Func<string>> exchangeAddMailboxPermissionworkflow, Expression<Func<bool>> exchangeAddMailboxPermissionautoMapping = null)
        {
            var __workflow_exchangeAddMailboxPermissionidentity = WorkflowExpression.Compile(exchangeAddMailboxPermissionidentity, nameof(exchangeAddMailboxPermissionidentity), required: true);
            var __workflow_exchangeAddMailboxPermissionuser = WorkflowExpression.Compile(exchangeAddMailboxPermissionuser, nameof(exchangeAddMailboxPermissionuser), required: true);
            var __workflow_exchangeAddMailboxPermissionaccessRights = WorkflowExpression.Compile(exchangeAddMailboxPermissionaccessRights, nameof(exchangeAddMailboxPermissionaccessRights), required: true);
            var __workflow_exchangeAddMailboxPermissionworkflow = WorkflowExpression.Compile(exchangeAddMailboxPermissionworkflow, nameof(exchangeAddMailboxPermissionworkflow), required: true);
            var __workflow_exchangeAddMailboxPermissionautoMapping = WorkflowExpression.Compile(exchangeAddMailboxPermissionautoMapping, nameof(exchangeAddMailboxPermissionautoMapping), required: false);
            return new DeferredBodyAction<ExchangeAddMailboxPermissionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeAddMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeAddMailboxPermission = new JObject();
                var exchangeAddMailboxPermissionpropCount = 0;
                exchangeAddMailboxPermissionpropCount++;
                exchangeAddMailboxPermission["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeAddMailboxPermissionidentity);
                exchangeAddMailboxPermissionpropCount++;
                exchangeAddMailboxPermission["User"] = ExpressionConverter.ConvertO(__workflow_exchangeAddMailboxPermissionuser);
                exchangeAddMailboxPermissionpropCount++;
                exchangeAddMailboxPermission["AccessRights"] = ExpressionConverter.ConvertO(__workflow_exchangeAddMailboxPermissionaccessRights);
                if (__workflow_exchangeAddMailboxPermissionautoMapping != null)
                {
                    if (__workflow_exchangeAddMailboxPermissionautoMapping != null)
                    {
                        exchangeAddMailboxPermission["AutoMapping"] = ExpressionConverter.ConvertO(__workflow_exchangeAddMailboxPermissionautoMapping);
                        exchangeAddMailboxPermissionpropCount++;
                    }

                    exchangeAddMailboxPermissionpropCount++;
                }
                else
                {
                    exchangeAddMailboxPermission["AutoMapping"] = false;
                    exchangeAddMailboxPermissionpropCount++;
                }

                exchangeAddMailboxPermissionpropCount++;
                exchangeAddMailboxPermission["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeAddMailboxPermissionworkflow);
                if (exchangeAddMailboxPermissionpropCount > 0)
                {
                    callPayload.Body = exchangeAddMailboxPermission;
                }

                return new ApiConnectionAction<ExchangeAddMailboxPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveMailboxPermissionResponse, ApiConnectionActionConfiguration> ExchangeRemoveMailboxPermission(Expression<Func<string>> exchangeRemoveMailboxPermissionidentity, Expression<Func<string>> exchangeRemoveMailboxPermissionuser, Expression<Func<string>> exchangeRemoveMailboxPermissionaccessRights, Expression<Func<string>> exchangeRemoveMailboxPermissionworkflow)
        {
            var __workflow_exchangeRemoveMailboxPermissionidentity = WorkflowExpression.Compile(exchangeRemoveMailboxPermissionidentity, nameof(exchangeRemoveMailboxPermissionidentity), required: true);
            var __workflow_exchangeRemoveMailboxPermissionuser = WorkflowExpression.Compile(exchangeRemoveMailboxPermissionuser, nameof(exchangeRemoveMailboxPermissionuser), required: true);
            var __workflow_exchangeRemoveMailboxPermissionaccessRights = WorkflowExpression.Compile(exchangeRemoveMailboxPermissionaccessRights, nameof(exchangeRemoveMailboxPermissionaccessRights), required: true);
            var __workflow_exchangeRemoveMailboxPermissionworkflow = WorkflowExpression.Compile(exchangeRemoveMailboxPermissionworkflow, nameof(exchangeRemoveMailboxPermissionworkflow), required: true);
            return new DeferredBodyAction<ExchangeRemoveMailboxPermissionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeRemoveMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeRemoveMailboxPermission = new JObject();
                var exchangeRemoveMailboxPermissionpropCount = 0;
                exchangeRemoveMailboxPermissionpropCount++;
                exchangeRemoveMailboxPermission["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeRemoveMailboxPermissionidentity);
                exchangeRemoveMailboxPermissionpropCount++;
                exchangeRemoveMailboxPermission["User"] = ExpressionConverter.ConvertO(__workflow_exchangeRemoveMailboxPermissionuser);
                exchangeRemoveMailboxPermissionpropCount++;
                exchangeRemoveMailboxPermission["AccessRights"] = ExpressionConverter.ConvertO(__workflow_exchangeRemoveMailboxPermissionaccessRights);
                exchangeRemoveMailboxPermissionpropCount++;
                exchangeRemoveMailboxPermission["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeRemoveMailboxPermissionworkflow);
                if (exchangeRemoveMailboxPermissionpropCount > 0)
                {
                    callPayload.Body = exchangeRemoveMailboxPermission;
                }

                return new ApiConnectionAction<ExchangeRemoveMailboxPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDisableMailboxResponse, ApiConnectionActionConfiguration> ExchangeDisableMailbox(Expression<Func<string>> exchangeDisableMailboxidentity, Expression<Func<string>> exchangeDisableMailboxworkflow)
        {
            var __workflow_exchangeDisableMailboxidentity = WorkflowExpression.Compile(exchangeDisableMailboxidentity, nameof(exchangeDisableMailboxidentity), required: true);
            var __workflow_exchangeDisableMailboxworkflow = WorkflowExpression.Compile(exchangeDisableMailboxworkflow, nameof(exchangeDisableMailboxworkflow), required: true);
            return new DeferredBodyAction<ExchangeDisableMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDisableMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeDisableMailbox = new JObject();
                var exchangeDisableMailboxpropCount = 0;
                exchangeDisableMailboxpropCount++;
                exchangeDisableMailbox["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeDisableMailboxidentity);
                exchangeDisableMailboxpropCount++;
                exchangeDisableMailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeDisableMailboxworkflow);
                if (exchangeDisableMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeDisableMailbox;
                }

                return new ApiConnectionAction<ExchangeDisableMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDisableRemoteMailboxResponse, ApiConnectionActionConfiguration> ExchangeDisableRemoteMailbox(Expression<Func<string>> exchangeDisableRemoteMailboxidentity, Expression<Func<string>> exchangeDisableRemoteMailboxworkflow)
        {
            var __workflow_exchangeDisableRemoteMailboxidentity = WorkflowExpression.Compile(exchangeDisableRemoteMailboxidentity, nameof(exchangeDisableRemoteMailboxidentity), required: true);
            var __workflow_exchangeDisableRemoteMailboxworkflow = WorkflowExpression.Compile(exchangeDisableRemoteMailboxworkflow, nameof(exchangeDisableRemoteMailboxworkflow), required: true);
            return new DeferredBodyAction<ExchangeDisableRemoteMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDisableRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeDisableRemoteMailbox = new JObject();
                var exchangeDisableRemoteMailboxpropCount = 0;
                exchangeDisableRemoteMailboxpropCount++;
                exchangeDisableRemoteMailbox["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeDisableRemoteMailboxidentity);
                exchangeDisableRemoteMailboxpropCount++;
                exchangeDisableRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeDisableRemoteMailboxworkflow);
                if (exchangeDisableRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeDisableRemoteMailbox;
                }

                return new ApiConnectionAction<ExchangeDisableRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeEnableMailboxResponse, ApiConnectionActionConfiguration> ExchangeEnableMailbox(Expression<Func<string>> exchangeEnableMailboxidentity, Expression<Func<string>> exchangeEnableMailboxworkflow, Expression<Func<string>> exchangeEnableMailboxalias = null, Expression<Func<string>> exchangeEnableMailboxdisplayName = null, Expression<Func<string>> exchangeEnableMailboxlinkedDomainController = null, Expression<Func<string>> exchangeEnableMailboxlinkedMasterAccount = null, Expression<Func<string>> exchangeEnableMailboxdatabase = null, Expression<Func<string>> exchangeEnableMailboxprimarySmtpAddress = null, Expression<Func<bool>> exchangeEnableMailboxemailAddressPolicyEnabled = null)
        {
            var __workflow_exchangeEnableMailboxidentity = WorkflowExpression.Compile(exchangeEnableMailboxidentity, nameof(exchangeEnableMailboxidentity), required: true);
            var __workflow_exchangeEnableMailboxworkflow = WorkflowExpression.Compile(exchangeEnableMailboxworkflow, nameof(exchangeEnableMailboxworkflow), required: true);
            var __workflow_exchangeEnableMailboxalias = WorkflowExpression.Compile(exchangeEnableMailboxalias, nameof(exchangeEnableMailboxalias), required: false);
            var __workflow_exchangeEnableMailboxdisplayName = WorkflowExpression.Compile(exchangeEnableMailboxdisplayName, nameof(exchangeEnableMailboxdisplayName), required: false);
            var __workflow_exchangeEnableMailboxlinkedDomainController = WorkflowExpression.Compile(exchangeEnableMailboxlinkedDomainController, nameof(exchangeEnableMailboxlinkedDomainController), required: false);
            var __workflow_exchangeEnableMailboxlinkedMasterAccount = WorkflowExpression.Compile(exchangeEnableMailboxlinkedMasterAccount, nameof(exchangeEnableMailboxlinkedMasterAccount), required: false);
            var __workflow_exchangeEnableMailboxdatabase = WorkflowExpression.Compile(exchangeEnableMailboxdatabase, nameof(exchangeEnableMailboxdatabase), required: false);
            var __workflow_exchangeEnableMailboxprimarySmtpAddress = WorkflowExpression.Compile(exchangeEnableMailboxprimarySmtpAddress, nameof(exchangeEnableMailboxprimarySmtpAddress), required: false);
            var __workflow_exchangeEnableMailboxemailAddressPolicyEnabled = WorkflowExpression.Compile(exchangeEnableMailboxemailAddressPolicyEnabled, nameof(exchangeEnableMailboxemailAddressPolicyEnabled), required: false);
            return new DeferredBodyAction<ExchangeEnableMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeEnableMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeEnableMailbox = new JObject();
                var exchangeEnableMailboxpropCount = 0;
                exchangeEnableMailboxpropCount++;
                exchangeEnableMailbox["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableMailboxidentity);
                if (__workflow_exchangeEnableMailboxalias != null)
                {
                    exchangeEnableMailbox["Alias"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableMailboxalias);
                    exchangeEnableMailboxpropCount++;
                }

                if (__workflow_exchangeEnableMailboxdisplayName != null)
                {
                    exchangeEnableMailbox["DisplayName"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableMailboxdisplayName);
                    exchangeEnableMailboxpropCount++;
                }

                if (__workflow_exchangeEnableMailboxlinkedDomainController != null)
                {
                    exchangeEnableMailbox["LinkedDomainController"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableMailboxlinkedDomainController);
                    exchangeEnableMailboxpropCount++;
                }

                if (__workflow_exchangeEnableMailboxlinkedMasterAccount != null)
                {
                    exchangeEnableMailbox["LinkedMasterAccount"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableMailboxlinkedMasterAccount);
                    exchangeEnableMailboxpropCount++;
                }

                if (__workflow_exchangeEnableMailboxdatabase != null)
                {
                    exchangeEnableMailbox["Database"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableMailboxdatabase);
                    exchangeEnableMailboxpropCount++;
                }

                if (__workflow_exchangeEnableMailboxprimarySmtpAddress != null)
                {
                    exchangeEnableMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableMailboxprimarySmtpAddress);
                    exchangeEnableMailboxpropCount++;
                }

                if (__workflow_exchangeEnableMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeEnableMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableMailboxemailAddressPolicyEnabled);
                    exchangeEnableMailboxpropCount++;
                }

                exchangeEnableMailboxpropCount++;
                exchangeEnableMailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableMailboxworkflow);
                if (exchangeEnableMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeEnableMailbox;
                }

                return new ApiConnectionAction<ExchangeEnableMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeEnableRemoteMailboxResponse, ApiConnectionActionConfiguration> ExchangeEnableRemoteMailbox(Expression<Func<string>> exchangeEnableRemoteMailboxidentity, Expression<Func<string>> exchangeEnableRemoteMailboxworkflow, Expression<Func<string>> exchangeEnableRemoteMailboxalias = null, Expression<Func<string>> exchangeEnableRemoteMailboxdisplayName = null, Expression<Func<string>> exchangeEnableRemoteMailboxremoteRoutingAddress = null, Expression<Func<string>> exchangeEnableRemoteMailboxprimarySmtpAddress = null, Expression<Func<bool>> exchangeEnableRemoteMailboxarchive = null, Expression<Func<bool>> exchangeEnableRemoteMailboxemailAddressPolicyEnabled = null)
        {
            var __workflow_exchangeEnableRemoteMailboxidentity = WorkflowExpression.Compile(exchangeEnableRemoteMailboxidentity, nameof(exchangeEnableRemoteMailboxidentity), required: true);
            var __workflow_exchangeEnableRemoteMailboxworkflow = WorkflowExpression.Compile(exchangeEnableRemoteMailboxworkflow, nameof(exchangeEnableRemoteMailboxworkflow), required: true);
            var __workflow_exchangeEnableRemoteMailboxalias = WorkflowExpression.Compile(exchangeEnableRemoteMailboxalias, nameof(exchangeEnableRemoteMailboxalias), required: false);
            var __workflow_exchangeEnableRemoteMailboxdisplayName = WorkflowExpression.Compile(exchangeEnableRemoteMailboxdisplayName, nameof(exchangeEnableRemoteMailboxdisplayName), required: false);
            var __workflow_exchangeEnableRemoteMailboxremoteRoutingAddress = WorkflowExpression.Compile(exchangeEnableRemoteMailboxremoteRoutingAddress, nameof(exchangeEnableRemoteMailboxremoteRoutingAddress), required: false);
            var __workflow_exchangeEnableRemoteMailboxprimarySmtpAddress = WorkflowExpression.Compile(exchangeEnableRemoteMailboxprimarySmtpAddress, nameof(exchangeEnableRemoteMailboxprimarySmtpAddress), required: false);
            var __workflow_exchangeEnableRemoteMailboxarchive = WorkflowExpression.Compile(exchangeEnableRemoteMailboxarchive, nameof(exchangeEnableRemoteMailboxarchive), required: false);
            var __workflow_exchangeEnableRemoteMailboxemailAddressPolicyEnabled = WorkflowExpression.Compile(exchangeEnableRemoteMailboxemailAddressPolicyEnabled, nameof(exchangeEnableRemoteMailboxemailAddressPolicyEnabled), required: false);
            return new DeferredBodyAction<ExchangeEnableRemoteMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeEnableRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeEnableRemoteMailbox = new JObject();
                var exchangeEnableRemoteMailboxpropCount = 0;
                exchangeEnableRemoteMailboxpropCount++;
                exchangeEnableRemoteMailbox["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableRemoteMailboxidentity);
                if (__workflow_exchangeEnableRemoteMailboxalias != null)
                {
                    exchangeEnableRemoteMailbox["Alias"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableRemoteMailboxalias);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeEnableRemoteMailboxdisplayName != null)
                {
                    exchangeEnableRemoteMailbox["DisplayName"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableRemoteMailboxdisplayName);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeEnableRemoteMailboxremoteRoutingAddress != null)
                {
                    exchangeEnableRemoteMailbox["RemoteRoutingAddress"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableRemoteMailboxremoteRoutingAddress);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeEnableRemoteMailboxprimarySmtpAddress != null)
                {
                    exchangeEnableRemoteMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableRemoteMailboxprimarySmtpAddress);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeEnableRemoteMailboxarchive != null)
                {
                    if (__workflow_exchangeEnableRemoteMailboxarchive != null)
                    {
                        exchangeEnableRemoteMailbox["Archive"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableRemoteMailboxarchive);
                        exchangeEnableRemoteMailboxpropCount++;
                    }

                    exchangeEnableRemoteMailboxpropCount++;
                }
                else
                {
                    exchangeEnableRemoteMailbox["Archive"] = false;
                    exchangeEnableRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeEnableRemoteMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeEnableRemoteMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableRemoteMailboxemailAddressPolicyEnabled);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                exchangeEnableRemoteMailboxpropCount++;
                exchangeEnableRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeEnableRemoteMailboxworkflow);
                if (exchangeEnableRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeEnableRemoteMailbox;
                }

                return new ApiConnectionAction<ExchangeEnableRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxResponse, ApiConnectionActionConfiguration> ExchangeGetRemoteMailbox(Expression<Func<string>> exchangeGetRemoteMailboxworkflow, Expression<Func<string>> exchangeGetRemoteMailboxidentity = null, Expression<Func<string>> exchangeGetRemoteMailboxfilterPropertyName = null, Expression<Func<exchangeGetRemoteMailboxfilterPropertyComparisonInput>> exchangeGetRemoteMailboxfilterPropertyComparison = null, Expression<Func<string>> exchangeGetRemoteMailboxfilterPropertyValue = null, Expression<Func<bool>> exchangeGetRemoteMailboxnoResultIsAnException = null)
        {
            var __workflow_exchangeGetRemoteMailboxworkflow = WorkflowExpression.Compile(exchangeGetRemoteMailboxworkflow, nameof(exchangeGetRemoteMailboxworkflow), required: true);
            var __workflow_exchangeGetRemoteMailboxidentity = WorkflowExpression.Compile(exchangeGetRemoteMailboxidentity, nameof(exchangeGetRemoteMailboxidentity), required: false);
            var __workflow_exchangeGetRemoteMailboxfilterPropertyName = WorkflowExpression.Compile(exchangeGetRemoteMailboxfilterPropertyName, nameof(exchangeGetRemoteMailboxfilterPropertyName), required: false);
            var __workflow_exchangeGetRemoteMailboxfilterPropertyComparison = WorkflowExpression.Compile(exchangeGetRemoteMailboxfilterPropertyComparison, nameof(exchangeGetRemoteMailboxfilterPropertyComparison), required: false);
            var __workflow_exchangeGetRemoteMailboxfilterPropertyValue = WorkflowExpression.Compile(exchangeGetRemoteMailboxfilterPropertyValue, nameof(exchangeGetRemoteMailboxfilterPropertyValue), required: false);
            var __workflow_exchangeGetRemoteMailboxnoResultIsAnException = WorkflowExpression.Compile(exchangeGetRemoteMailboxnoResultIsAnException, nameof(exchangeGetRemoteMailboxnoResultIsAnException), required: false);
            return new DeferredBodyAction<ExchangeGetRemoteMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetRemoteMailbox = new JObject();
                var exchangeGetRemoteMailboxpropCount = 0;
                if (__workflow_exchangeGetRemoteMailboxidentity != null)
                {
                    exchangeGetRemoteMailbox["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeGetRemoteMailboxidentity);
                    exchangeGetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeGetRemoteMailboxfilterPropertyName != null)
                {
                    exchangeGetRemoteMailbox["FilterPropertyName"] = ExpressionConverter.ConvertO(__workflow_exchangeGetRemoteMailboxfilterPropertyName);
                    exchangeGetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeGetRemoteMailboxfilterPropertyComparison != null)
                {
                    if (__workflow_exchangeGetRemoteMailboxfilterPropertyComparison != null)
                    {
                        exchangeGetRemoteMailbox["FilterPropertyComparison"] = ExpressionConverter.ConvertO(__workflow_exchangeGetRemoteMailboxfilterPropertyComparison);
                        exchangeGetRemoteMailboxpropCount++;
                    }

                    exchangeGetRemoteMailboxpropCount++;
                }
                else
                {
                    exchangeGetRemoteMailbox["FilterPropertyComparison"] = "Equals";
                    exchangeGetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeGetRemoteMailboxfilterPropertyValue != null)
                {
                    exchangeGetRemoteMailbox["FilterPropertyValue"] = ExpressionConverter.ConvertO(__workflow_exchangeGetRemoteMailboxfilterPropertyValue);
                    exchangeGetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeGetRemoteMailboxnoResultIsAnException != null)
                {
                    if (__workflow_exchangeGetRemoteMailboxnoResultIsAnException != null)
                    {
                        exchangeGetRemoteMailbox["NoResultIsAnException"] = ExpressionConverter.ConvertO(__workflow_exchangeGetRemoteMailboxnoResultIsAnException);
                        exchangeGetRemoteMailboxpropCount++;
                    }

                    exchangeGetRemoteMailboxpropCount++;
                }
                else
                {
                    exchangeGetRemoteMailbox["NoResultIsAnException"] = false;
                    exchangeGetRemoteMailboxpropCount++;
                }

                exchangeGetRemoteMailboxpropCount++;
                exchangeGetRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeGetRemoteMailboxworkflow);
                if (exchangeGetRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeGetRemoteMailbox;
                }

                return new ApiConnectionAction<ExchangeGetRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDoesRemoteMailboxExistResponse, ApiConnectionActionConfiguration> ExchangeDoesRemoteMailboxExist(Expression<Func<string>> exchangeDoesRemoteMailboxExistworkflow, Expression<Func<string>> exchangeDoesRemoteMailboxExistidentity = null, Expression<Func<string>> exchangeDoesRemoteMailboxExistfilterPropertyName = null, Expression<Func<exchangeDoesRemoteMailboxExistfilterPropertyComparisonInput>> exchangeDoesRemoteMailboxExistfilterPropertyComparison = null, Expression<Func<string>> exchangeDoesRemoteMailboxExistfilterPropertyValue = null)
        {
            var __workflow_exchangeDoesRemoteMailboxExistworkflow = WorkflowExpression.Compile(exchangeDoesRemoteMailboxExistworkflow, nameof(exchangeDoesRemoteMailboxExistworkflow), required: true);
            var __workflow_exchangeDoesRemoteMailboxExistidentity = WorkflowExpression.Compile(exchangeDoesRemoteMailboxExistidentity, nameof(exchangeDoesRemoteMailboxExistidentity), required: false);
            var __workflow_exchangeDoesRemoteMailboxExistfilterPropertyName = WorkflowExpression.Compile(exchangeDoesRemoteMailboxExistfilterPropertyName, nameof(exchangeDoesRemoteMailboxExistfilterPropertyName), required: false);
            var __workflow_exchangeDoesRemoteMailboxExistfilterPropertyComparison = WorkflowExpression.Compile(exchangeDoesRemoteMailboxExistfilterPropertyComparison, nameof(exchangeDoesRemoteMailboxExistfilterPropertyComparison), required: false);
            var __workflow_exchangeDoesRemoteMailboxExistfilterPropertyValue = WorkflowExpression.Compile(exchangeDoesRemoteMailboxExistfilterPropertyValue, nameof(exchangeDoesRemoteMailboxExistfilterPropertyValue), required: false);
            return new DeferredBodyAction<ExchangeDoesRemoteMailboxExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDoesRemoteMailboxExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeDoesRemoteMailboxExist = new JObject();
                var exchangeDoesRemoteMailboxExistpropCount = 0;
                if (__workflow_exchangeDoesRemoteMailboxExistidentity != null)
                {
                    exchangeDoesRemoteMailboxExist["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeDoesRemoteMailboxExistidentity);
                    exchangeDoesRemoteMailboxExistpropCount++;
                }

                if (__workflow_exchangeDoesRemoteMailboxExistfilterPropertyName != null)
                {
                    exchangeDoesRemoteMailboxExist["FilterPropertyName"] = ExpressionConverter.ConvertO(__workflow_exchangeDoesRemoteMailboxExistfilterPropertyName);
                    exchangeDoesRemoteMailboxExistpropCount++;
                }

                if (__workflow_exchangeDoesRemoteMailboxExistfilterPropertyComparison != null)
                {
                    if (__workflow_exchangeDoesRemoteMailboxExistfilterPropertyComparison != null)
                    {
                        exchangeDoesRemoteMailboxExist["FilterPropertyComparison"] = ExpressionConverter.ConvertO(__workflow_exchangeDoesRemoteMailboxExistfilterPropertyComparison);
                        exchangeDoesRemoteMailboxExistpropCount++;
                    }

                    exchangeDoesRemoteMailboxExistpropCount++;
                }
                else
                {
                    exchangeDoesRemoteMailboxExist["FilterPropertyComparison"] = "Equals";
                    exchangeDoesRemoteMailboxExistpropCount++;
                }

                if (__workflow_exchangeDoesRemoteMailboxExistfilterPropertyValue != null)
                {
                    exchangeDoesRemoteMailboxExist["FilterPropertyValue"] = ExpressionConverter.ConvertO(__workflow_exchangeDoesRemoteMailboxExistfilterPropertyValue);
                    exchangeDoesRemoteMailboxExistpropCount++;
                }

                exchangeDoesRemoteMailboxExistpropCount++;
                exchangeDoesRemoteMailboxExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeDoesRemoteMailboxExistworkflow);
                if (exchangeDoesRemoteMailboxExistpropCount > 0)
                {
                    callPayload.Body = exchangeDoesRemoteMailboxExist;
                }

                return new ApiConnectionAction<ExchangeDoesRemoteMailboxExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewMailboxResponse, ApiConnectionActionConfiguration> ExchangeNewMailbox(Expression<Func<string>> exchangeNewMailboxname, Expression<Func<string>> exchangeNewMailboxuserPrincipalName, Expression<Func<string>> exchangeNewMailboxworkflow, Expression<Func<string>> exchangeNewMailboxfirstName = null, Expression<Func<string>> exchangeNewMailboxlastName = null, Expression<Func<string>> exchangeNewMailboxorganizationalUnit = null, Expression<Func<string>> exchangeNewMailboxdisplayName = null, Expression<Func<string>> exchangeNewMailboxalias = null, Expression<Func<string>> exchangeNewMailboxprimarySmtpAddress = null, Expression<Func<string>> exchangeNewMailboxsamAccountName = null, Expression<Func<string>> exchangeNewMailboxpassword = null, Expression<Func<bool>> exchangeNewMailboxaccountPasswordIsStoredPassword = null, Expression<Func<bool>> exchangeNewMailboxresetPasswordOnNextLogon = null, Expression<Func<string>> exchangeNewMailboxdatabase = null, Expression<Func<bool>> exchangeNewMailboxsharedMailbox = null, Expression<Func<bool>> exchangeNewMailboxemailAddressPolicyEnabled = null, Expression<Func<bool>> exchangeNewMailboxarchive = null)
        {
            var __workflow_exchangeNewMailboxname = WorkflowExpression.Compile(exchangeNewMailboxname, nameof(exchangeNewMailboxname), required: true);
            var __workflow_exchangeNewMailboxuserPrincipalName = WorkflowExpression.Compile(exchangeNewMailboxuserPrincipalName, nameof(exchangeNewMailboxuserPrincipalName), required: true);
            var __workflow_exchangeNewMailboxworkflow = WorkflowExpression.Compile(exchangeNewMailboxworkflow, nameof(exchangeNewMailboxworkflow), required: true);
            var __workflow_exchangeNewMailboxfirstName = WorkflowExpression.Compile(exchangeNewMailboxfirstName, nameof(exchangeNewMailboxfirstName), required: false);
            var __workflow_exchangeNewMailboxlastName = WorkflowExpression.Compile(exchangeNewMailboxlastName, nameof(exchangeNewMailboxlastName), required: false);
            var __workflow_exchangeNewMailboxorganizationalUnit = WorkflowExpression.Compile(exchangeNewMailboxorganizationalUnit, nameof(exchangeNewMailboxorganizationalUnit), required: false);
            var __workflow_exchangeNewMailboxdisplayName = WorkflowExpression.Compile(exchangeNewMailboxdisplayName, nameof(exchangeNewMailboxdisplayName), required: false);
            var __workflow_exchangeNewMailboxalias = WorkflowExpression.Compile(exchangeNewMailboxalias, nameof(exchangeNewMailboxalias), required: false);
            var __workflow_exchangeNewMailboxprimarySmtpAddress = WorkflowExpression.Compile(exchangeNewMailboxprimarySmtpAddress, nameof(exchangeNewMailboxprimarySmtpAddress), required: false);
            var __workflow_exchangeNewMailboxsamAccountName = WorkflowExpression.Compile(exchangeNewMailboxsamAccountName, nameof(exchangeNewMailboxsamAccountName), required: false);
            var __workflow_exchangeNewMailboxpassword = WorkflowExpression.Compile(exchangeNewMailboxpassword, nameof(exchangeNewMailboxpassword), required: false);
            var __workflow_exchangeNewMailboxaccountPasswordIsStoredPassword = WorkflowExpression.Compile(exchangeNewMailboxaccountPasswordIsStoredPassword, nameof(exchangeNewMailboxaccountPasswordIsStoredPassword), required: false);
            var __workflow_exchangeNewMailboxresetPasswordOnNextLogon = WorkflowExpression.Compile(exchangeNewMailboxresetPasswordOnNextLogon, nameof(exchangeNewMailboxresetPasswordOnNextLogon), required: false);
            var __workflow_exchangeNewMailboxdatabase = WorkflowExpression.Compile(exchangeNewMailboxdatabase, nameof(exchangeNewMailboxdatabase), required: false);
            var __workflow_exchangeNewMailboxsharedMailbox = WorkflowExpression.Compile(exchangeNewMailboxsharedMailbox, nameof(exchangeNewMailboxsharedMailbox), required: false);
            var __workflow_exchangeNewMailboxemailAddressPolicyEnabled = WorkflowExpression.Compile(exchangeNewMailboxemailAddressPolicyEnabled, nameof(exchangeNewMailboxemailAddressPolicyEnabled), required: false);
            var __workflow_exchangeNewMailboxarchive = WorkflowExpression.Compile(exchangeNewMailboxarchive, nameof(exchangeNewMailboxarchive), required: false);
            return new DeferredBodyAction<ExchangeNewMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeNewMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeNewMailbox = new JObject();
                var exchangeNewMailboxpropCount = 0;
                if (__workflow_exchangeNewMailboxfirstName != null)
                {
                    exchangeNewMailbox["FirstName"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxfirstName);
                    exchangeNewMailboxpropCount++;
                }

                if (__workflow_exchangeNewMailboxlastName != null)
                {
                    exchangeNewMailbox["LastName"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxlastName);
                    exchangeNewMailboxpropCount++;
                }

                if (__workflow_exchangeNewMailboxorganizationalUnit != null)
                {
                    exchangeNewMailbox["OrganizationalUnit"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxorganizationalUnit);
                    exchangeNewMailboxpropCount++;
                }

                exchangeNewMailboxpropCount++;
                exchangeNewMailbox["Name"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxname);
                if (__workflow_exchangeNewMailboxdisplayName != null)
                {
                    exchangeNewMailbox["DisplayName"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxdisplayName);
                    exchangeNewMailboxpropCount++;
                }

                if (__workflow_exchangeNewMailboxalias != null)
                {
                    exchangeNewMailbox["Alias"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxalias);
                    exchangeNewMailboxpropCount++;
                }

                if (__workflow_exchangeNewMailboxprimarySmtpAddress != null)
                {
                    exchangeNewMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxprimarySmtpAddress);
                    exchangeNewMailboxpropCount++;
                }

                exchangeNewMailboxpropCount++;
                exchangeNewMailbox["UserPrincipalName"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxuserPrincipalName);
                if (__workflow_exchangeNewMailboxsamAccountName != null)
                {
                    exchangeNewMailbox["SamAccountName"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxsamAccountName);
                    exchangeNewMailboxpropCount++;
                }

                if (__workflow_exchangeNewMailboxpassword != null)
                {
                    exchangeNewMailbox["Password"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxpassword);
                    exchangeNewMailboxpropCount++;
                }

                if (__workflow_exchangeNewMailboxaccountPasswordIsStoredPassword != null)
                {
                    if (__workflow_exchangeNewMailboxaccountPasswordIsStoredPassword != null)
                    {
                        exchangeNewMailbox["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxaccountPasswordIsStoredPassword);
                        exchangeNewMailboxpropCount++;
                    }

                    exchangeNewMailboxpropCount++;
                }
                else
                {
                    exchangeNewMailbox["AccountPasswordIsStoredPassword"] = false;
                    exchangeNewMailboxpropCount++;
                }

                if (__workflow_exchangeNewMailboxresetPasswordOnNextLogon != null)
                {
                    if (__workflow_exchangeNewMailboxresetPasswordOnNextLogon != null)
                    {
                        exchangeNewMailbox["ResetPasswordOnNextLogon"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxresetPasswordOnNextLogon);
                        exchangeNewMailboxpropCount++;
                    }

                    exchangeNewMailboxpropCount++;
                }
                else
                {
                    exchangeNewMailbox["ResetPasswordOnNextLogon"] = true;
                    exchangeNewMailboxpropCount++;
                }

                if (__workflow_exchangeNewMailboxdatabase != null)
                {
                    exchangeNewMailbox["Database"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxdatabase);
                    exchangeNewMailboxpropCount++;
                }

                if (__workflow_exchangeNewMailboxsharedMailbox != null)
                {
                    if (__workflow_exchangeNewMailboxsharedMailbox != null)
                    {
                        exchangeNewMailbox["SharedMailbox"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxsharedMailbox);
                        exchangeNewMailboxpropCount++;
                    }

                    exchangeNewMailboxpropCount++;
                }
                else
                {
                    exchangeNewMailbox["SharedMailbox"] = false;
                    exchangeNewMailboxpropCount++;
                }

                if (__workflow_exchangeNewMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeNewMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxemailAddressPolicyEnabled);
                    exchangeNewMailboxpropCount++;
                }

                if (__workflow_exchangeNewMailboxarchive != null)
                {
                    if (__workflow_exchangeNewMailboxarchive != null)
                    {
                        exchangeNewMailbox["Archive"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxarchive);
                        exchangeNewMailboxpropCount++;
                    }

                    exchangeNewMailboxpropCount++;
                }
                else
                {
                    exchangeNewMailbox["Archive"] = false;
                    exchangeNewMailboxpropCount++;
                }

                exchangeNewMailboxpropCount++;
                exchangeNewMailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeNewMailboxworkflow);
                if (exchangeNewMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeNewMailbox;
                }

                return new ApiConnectionAction<ExchangeNewMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewRemoteMailboxResponse, ApiConnectionActionConfiguration> ExchangeNewRemoteMailbox(Expression<Func<string>> exchangeNewRemoteMailboxname, Expression<Func<string>> exchangeNewRemoteMailboxuserPrincipalName, Expression<Func<string>> exchangeNewRemoteMailboxworkflow, Expression<Func<string>> exchangeNewRemoteMailboxfirstName = null, Expression<Func<string>> exchangeNewRemoteMailboxlastName = null, Expression<Func<string>> exchangeNewRemoteMailboxonPremisesOrganizationalUnit = null, Expression<Func<string>> exchangeNewRemoteMailboxdisplayName = null, Expression<Func<string>> exchangeNewRemoteMailboxremoteRoutingAddress = null, Expression<Func<string>> exchangeNewRemoteMailboxalias = null, Expression<Func<string>> exchangeNewRemoteMailboxprimarySmtpAddress = null, Expression<Func<string>> exchangeNewRemoteMailboxsamAccountName = null, Expression<Func<string>> exchangeNewRemoteMailboxpassword = null, Expression<Func<bool>> exchangeNewRemoteMailboxaccountPasswordIsStoredPassword = null, Expression<Func<bool>> exchangeNewRemoteMailboxresetPasswordOnNextLogon = null, Expression<Func<bool>> exchangeNewRemoteMailboxsharedMailbox = null, Expression<Func<bool>> exchangeNewRemoteMailboxemailAddressPolicyEnabled = null, Expression<Func<bool>> exchangeNewRemoteMailboxarchive = null)
        {
            var __workflow_exchangeNewRemoteMailboxname = WorkflowExpression.Compile(exchangeNewRemoteMailboxname, nameof(exchangeNewRemoteMailboxname), required: true);
            var __workflow_exchangeNewRemoteMailboxuserPrincipalName = WorkflowExpression.Compile(exchangeNewRemoteMailboxuserPrincipalName, nameof(exchangeNewRemoteMailboxuserPrincipalName), required: true);
            var __workflow_exchangeNewRemoteMailboxworkflow = WorkflowExpression.Compile(exchangeNewRemoteMailboxworkflow, nameof(exchangeNewRemoteMailboxworkflow), required: true);
            var __workflow_exchangeNewRemoteMailboxfirstName = WorkflowExpression.Compile(exchangeNewRemoteMailboxfirstName, nameof(exchangeNewRemoteMailboxfirstName), required: false);
            var __workflow_exchangeNewRemoteMailboxlastName = WorkflowExpression.Compile(exchangeNewRemoteMailboxlastName, nameof(exchangeNewRemoteMailboxlastName), required: false);
            var __workflow_exchangeNewRemoteMailboxonPremisesOrganizationalUnit = WorkflowExpression.Compile(exchangeNewRemoteMailboxonPremisesOrganizationalUnit, nameof(exchangeNewRemoteMailboxonPremisesOrganizationalUnit), required: false);
            var __workflow_exchangeNewRemoteMailboxdisplayName = WorkflowExpression.Compile(exchangeNewRemoteMailboxdisplayName, nameof(exchangeNewRemoteMailboxdisplayName), required: false);
            var __workflow_exchangeNewRemoteMailboxremoteRoutingAddress = WorkflowExpression.Compile(exchangeNewRemoteMailboxremoteRoutingAddress, nameof(exchangeNewRemoteMailboxremoteRoutingAddress), required: false);
            var __workflow_exchangeNewRemoteMailboxalias = WorkflowExpression.Compile(exchangeNewRemoteMailboxalias, nameof(exchangeNewRemoteMailboxalias), required: false);
            var __workflow_exchangeNewRemoteMailboxprimarySmtpAddress = WorkflowExpression.Compile(exchangeNewRemoteMailboxprimarySmtpAddress, nameof(exchangeNewRemoteMailboxprimarySmtpAddress), required: false);
            var __workflow_exchangeNewRemoteMailboxsamAccountName = WorkflowExpression.Compile(exchangeNewRemoteMailboxsamAccountName, nameof(exchangeNewRemoteMailboxsamAccountName), required: false);
            var __workflow_exchangeNewRemoteMailboxpassword = WorkflowExpression.Compile(exchangeNewRemoteMailboxpassword, nameof(exchangeNewRemoteMailboxpassword), required: false);
            var __workflow_exchangeNewRemoteMailboxaccountPasswordIsStoredPassword = WorkflowExpression.Compile(exchangeNewRemoteMailboxaccountPasswordIsStoredPassword, nameof(exchangeNewRemoteMailboxaccountPasswordIsStoredPassword), required: false);
            var __workflow_exchangeNewRemoteMailboxresetPasswordOnNextLogon = WorkflowExpression.Compile(exchangeNewRemoteMailboxresetPasswordOnNextLogon, nameof(exchangeNewRemoteMailboxresetPasswordOnNextLogon), required: false);
            var __workflow_exchangeNewRemoteMailboxsharedMailbox = WorkflowExpression.Compile(exchangeNewRemoteMailboxsharedMailbox, nameof(exchangeNewRemoteMailboxsharedMailbox), required: false);
            var __workflow_exchangeNewRemoteMailboxemailAddressPolicyEnabled = WorkflowExpression.Compile(exchangeNewRemoteMailboxemailAddressPolicyEnabled, nameof(exchangeNewRemoteMailboxemailAddressPolicyEnabled), required: false);
            var __workflow_exchangeNewRemoteMailboxarchive = WorkflowExpression.Compile(exchangeNewRemoteMailboxarchive, nameof(exchangeNewRemoteMailboxarchive), required: false);
            return new DeferredBodyAction<ExchangeNewRemoteMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeNewRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeNewRemoteMailbox = new JObject();
                var exchangeNewRemoteMailboxpropCount = 0;
                if (__workflow_exchangeNewRemoteMailboxfirstName != null)
                {
                    exchangeNewRemoteMailbox["FirstName"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxfirstName);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeNewRemoteMailboxlastName != null)
                {
                    exchangeNewRemoteMailbox["LastName"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxlastName);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeNewRemoteMailboxonPremisesOrganizationalUnit != null)
                {
                    exchangeNewRemoteMailbox["OnPremisesOrganizationalUnit"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxonPremisesOrganizationalUnit);
                    exchangeNewRemoteMailboxpropCount++;
                }

                exchangeNewRemoteMailboxpropCount++;
                exchangeNewRemoteMailbox["Name"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxname);
                if (__workflow_exchangeNewRemoteMailboxdisplayName != null)
                {
                    exchangeNewRemoteMailbox["DisplayName"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxdisplayName);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeNewRemoteMailboxremoteRoutingAddress != null)
                {
                    exchangeNewRemoteMailbox["RemoteRoutingAddress"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxremoteRoutingAddress);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeNewRemoteMailboxalias != null)
                {
                    exchangeNewRemoteMailbox["Alias"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxalias);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeNewRemoteMailboxprimarySmtpAddress != null)
                {
                    exchangeNewRemoteMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxprimarySmtpAddress);
                    exchangeNewRemoteMailboxpropCount++;
                }

                exchangeNewRemoteMailboxpropCount++;
                exchangeNewRemoteMailbox["UserPrincipalName"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxuserPrincipalName);
                if (__workflow_exchangeNewRemoteMailboxsamAccountName != null)
                {
                    exchangeNewRemoteMailbox["SamAccountName"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxsamAccountName);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeNewRemoteMailboxpassword != null)
                {
                    exchangeNewRemoteMailbox["Password"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxpassword);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeNewRemoteMailboxaccountPasswordIsStoredPassword != null)
                {
                    if (__workflow_exchangeNewRemoteMailboxaccountPasswordIsStoredPassword != null)
                    {
                        exchangeNewRemoteMailbox["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxaccountPasswordIsStoredPassword);
                        exchangeNewRemoteMailboxpropCount++;
                    }

                    exchangeNewRemoteMailboxpropCount++;
                }
                else
                {
                    exchangeNewRemoteMailbox["AccountPasswordIsStoredPassword"] = false;
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeNewRemoteMailboxresetPasswordOnNextLogon != null)
                {
                    if (__workflow_exchangeNewRemoteMailboxresetPasswordOnNextLogon != null)
                    {
                        exchangeNewRemoteMailbox["ResetPasswordOnNextLogon"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxresetPasswordOnNextLogon);
                        exchangeNewRemoteMailboxpropCount++;
                    }

                    exchangeNewRemoteMailboxpropCount++;
                }
                else
                {
                    exchangeNewRemoteMailbox["ResetPasswordOnNextLogon"] = true;
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeNewRemoteMailboxsharedMailbox != null)
                {
                    if (__workflow_exchangeNewRemoteMailboxsharedMailbox != null)
                    {
                        exchangeNewRemoteMailbox["SharedMailbox"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxsharedMailbox);
                        exchangeNewRemoteMailboxpropCount++;
                    }

                    exchangeNewRemoteMailboxpropCount++;
                }
                else
                {
                    exchangeNewRemoteMailbox["SharedMailbox"] = false;
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeNewRemoteMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeNewRemoteMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxemailAddressPolicyEnabled);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeNewRemoteMailboxarchive != null)
                {
                    if (__workflow_exchangeNewRemoteMailboxarchive != null)
                    {
                        exchangeNewRemoteMailbox["Archive"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxarchive);
                        exchangeNewRemoteMailboxpropCount++;
                    }

                    exchangeNewRemoteMailboxpropCount++;
                }
                else
                {
                    exchangeNewRemoteMailbox["Archive"] = false;
                    exchangeNewRemoteMailboxpropCount++;
                }

                exchangeNewRemoteMailboxpropCount++;
                exchangeNewRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailboxworkflow);
                if (exchangeNewRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeNewRemoteMailbox;
                }

                return new ApiConnectionAction<ExchangeNewRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetADServerToViewEntireForestResponse, ApiConnectionActionConfiguration> ExchangeSetADServerToViewEntireForest(Expression<Func<bool>> exchangeSetADServerToViewEntireForestviewEntireForest, Expression<Func<string>> exchangeSetADServerToViewEntireForestworkflow)
        {
            var __workflow_exchangeSetADServerToViewEntireForestviewEntireForest = WorkflowExpression.Compile(exchangeSetADServerToViewEntireForestviewEntireForest, nameof(exchangeSetADServerToViewEntireForestviewEntireForest), required: true);
            var __workflow_exchangeSetADServerToViewEntireForestworkflow = WorkflowExpression.Compile(exchangeSetADServerToViewEntireForestworkflow, nameof(exchangeSetADServerToViewEntireForestworkflow), required: true);
            return new DeferredBodyAction<ExchangeSetADServerToViewEntireForestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetADServerToViewEntireForest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetADServerToViewEntireForest = new JObject();
                var exchangeSetADServerToViewEntireForestpropCount = 0;
                exchangeSetADServerToViewEntireForestpropCount++;
                exchangeSetADServerToViewEntireForest["ViewEntireForest"] = ExpressionConverter.ConvertO(__workflow_exchangeSetADServerToViewEntireForestviewEntireForest);
                exchangeSetADServerToViewEntireForestpropCount++;
                exchangeSetADServerToViewEntireForest["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeSetADServerToViewEntireForestworkflow);
                if (exchangeSetADServerToViewEntireForestpropCount > 0)
                {
                    callPayload.Body = exchangeSetADServerToViewEntireForest;
                }

                return new ApiConnectionAction<ExchangeSetADServerToViewEntireForestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxResponse, ApiConnectionActionConfiguration> ExchangeSetMailbox(Expression<Func<string>> exchangeSetMailboxidentity, Expression<Func<string>> exchangeSetMailboxworkflow, Expression<Func<bool>> exchangeSetMailboxaccountDisabled = null, Expression<Func<string>> exchangeSetMailboxalias = null, Expression<Func<string>> exchangeSetMailboxdisplayName = null, Expression<Func<string>> exchangeSetMailboxprimarySmtpAddress = null, Expression<Func<bool>> exchangeSetMailboxhiddenFromAddressListsEnabled = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute1 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute2 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute3 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute4 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute5 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute6 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute7 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute8 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute9 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute10 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute11 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute12 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute13 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute14 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute15 = null, Expression<Func<bool>> exchangeSetMailboxemailAddressPolicyEnabled = null)
        {
            var __workflow_exchangeSetMailboxidentity = WorkflowExpression.Compile(exchangeSetMailboxidentity, nameof(exchangeSetMailboxidentity), required: true);
            var __workflow_exchangeSetMailboxworkflow = WorkflowExpression.Compile(exchangeSetMailboxworkflow, nameof(exchangeSetMailboxworkflow), required: true);
            var __workflow_exchangeSetMailboxaccountDisabled = WorkflowExpression.Compile(exchangeSetMailboxaccountDisabled, nameof(exchangeSetMailboxaccountDisabled), required: false);
            var __workflow_exchangeSetMailboxalias = WorkflowExpression.Compile(exchangeSetMailboxalias, nameof(exchangeSetMailboxalias), required: false);
            var __workflow_exchangeSetMailboxdisplayName = WorkflowExpression.Compile(exchangeSetMailboxdisplayName, nameof(exchangeSetMailboxdisplayName), required: false);
            var __workflow_exchangeSetMailboxprimarySmtpAddress = WorkflowExpression.Compile(exchangeSetMailboxprimarySmtpAddress, nameof(exchangeSetMailboxprimarySmtpAddress), required: false);
            var __workflow_exchangeSetMailboxhiddenFromAddressListsEnabled = WorkflowExpression.Compile(exchangeSetMailboxhiddenFromAddressListsEnabled, nameof(exchangeSetMailboxhiddenFromAddressListsEnabled), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute1 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute1, nameof(exchangeSetMailboxcustomAttribute1), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute2 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute2, nameof(exchangeSetMailboxcustomAttribute2), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute3 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute3, nameof(exchangeSetMailboxcustomAttribute3), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute4 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute4, nameof(exchangeSetMailboxcustomAttribute4), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute5 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute5, nameof(exchangeSetMailboxcustomAttribute5), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute6 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute6, nameof(exchangeSetMailboxcustomAttribute6), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute7 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute7, nameof(exchangeSetMailboxcustomAttribute7), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute8 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute8, nameof(exchangeSetMailboxcustomAttribute8), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute9 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute9, nameof(exchangeSetMailboxcustomAttribute9), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute10 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute10, nameof(exchangeSetMailboxcustomAttribute10), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute11 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute11, nameof(exchangeSetMailboxcustomAttribute11), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute12 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute12, nameof(exchangeSetMailboxcustomAttribute12), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute13 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute13, nameof(exchangeSetMailboxcustomAttribute13), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute14 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute14, nameof(exchangeSetMailboxcustomAttribute14), required: false);
            var __workflow_exchangeSetMailboxcustomAttribute15 = WorkflowExpression.Compile(exchangeSetMailboxcustomAttribute15, nameof(exchangeSetMailboxcustomAttribute15), required: false);
            var __workflow_exchangeSetMailboxemailAddressPolicyEnabled = WorkflowExpression.Compile(exchangeSetMailboxemailAddressPolicyEnabled, nameof(exchangeSetMailboxemailAddressPolicyEnabled), required: false);
            return new DeferredBodyAction<ExchangeSetMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetMailbox = new JObject();
                var exchangeSetMailboxpropCount = 0;
                exchangeSetMailboxpropCount++;
                exchangeSetMailbox["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxidentity);
                if (__workflow_exchangeSetMailboxaccountDisabled != null)
                {
                    exchangeSetMailbox["AccountDisabled"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxaccountDisabled);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxalias != null)
                {
                    exchangeSetMailbox["Alias"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxalias);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxdisplayName != null)
                {
                    exchangeSetMailbox["DisplayName"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxdisplayName);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxprimarySmtpAddress != null)
                {
                    exchangeSetMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxprimarySmtpAddress);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxhiddenFromAddressListsEnabled != null)
                {
                    exchangeSetMailbox["HiddenFromAddressListsEnabled"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxhiddenFromAddressListsEnabled);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute1 != null)
                {
                    exchangeSetMailbox["CustomAttribute1"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute1);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute2 != null)
                {
                    exchangeSetMailbox["CustomAttribute2"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute2);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute3 != null)
                {
                    exchangeSetMailbox["CustomAttribute3"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute3);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute4 != null)
                {
                    exchangeSetMailbox["CustomAttribute4"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute4);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute5 != null)
                {
                    exchangeSetMailbox["CustomAttribute5"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute5);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute6 != null)
                {
                    exchangeSetMailbox["CustomAttribute6"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute6);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute7 != null)
                {
                    exchangeSetMailbox["CustomAttribute7"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute7);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute8 != null)
                {
                    exchangeSetMailbox["CustomAttribute8"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute8);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute9 != null)
                {
                    exchangeSetMailbox["CustomAttribute9"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute9);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute10 != null)
                {
                    exchangeSetMailbox["CustomAttribute10"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute10);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute11 != null)
                {
                    exchangeSetMailbox["CustomAttribute11"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute11);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute12 != null)
                {
                    exchangeSetMailbox["CustomAttribute12"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute12);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute13 != null)
                {
                    exchangeSetMailbox["CustomAttribute13"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute13);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute14 != null)
                {
                    exchangeSetMailbox["CustomAttribute14"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute14);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxcustomAttribute15 != null)
                {
                    exchangeSetMailbox["CustomAttribute15"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxcustomAttribute15);
                    exchangeSetMailboxpropCount++;
                }

                if (__workflow_exchangeSetMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeSetMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxemailAddressPolicyEnabled);
                    exchangeSetMailboxpropCount++;
                }

                exchangeSetMailboxpropCount++;
                exchangeSetMailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxworkflow);
                if (exchangeSetMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeSetMailbox;
                }

                return new ApiConnectionAction<ExchangeSetMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxEmailAddressesResponse, ApiConnectionActionConfiguration> ExchangeSetMailboxEmailAddresses(Expression<Func<string>> exchangeSetMailboxEmailAddressesidentity, Expression<Func<string>> exchangeSetMailboxEmailAddressesworkflow, Expression<Func<string>> exchangeSetMailboxEmailAddressesalias = null, Expression<Func<string>> exchangeSetMailboxEmailAddressesprimarySmtpAddress = null, Expression<Func<bool>> exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled = null, Expression<Func<string[]>> exchangeSetMailboxEmailAddressesemailAddressesToAddList = null, Expression<Func<bool>> exchangeSetMailboxEmailAddressesreplaceEmailAddresses = null, Expression<Func<string[]>> exchangeSetMailboxEmailAddressesemailAddressesToRemoveList = null)
        {
            var __workflow_exchangeSetMailboxEmailAddressesidentity = WorkflowExpression.Compile(exchangeSetMailboxEmailAddressesidentity, nameof(exchangeSetMailboxEmailAddressesidentity), required: true);
            var __workflow_exchangeSetMailboxEmailAddressesworkflow = WorkflowExpression.Compile(exchangeSetMailboxEmailAddressesworkflow, nameof(exchangeSetMailboxEmailAddressesworkflow), required: true);
            var __workflow_exchangeSetMailboxEmailAddressesalias = WorkflowExpression.Compile(exchangeSetMailboxEmailAddressesalias, nameof(exchangeSetMailboxEmailAddressesalias), required: false);
            var __workflow_exchangeSetMailboxEmailAddressesprimarySmtpAddress = WorkflowExpression.Compile(exchangeSetMailboxEmailAddressesprimarySmtpAddress, nameof(exchangeSetMailboxEmailAddressesprimarySmtpAddress), required: false);
            var __workflow_exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled = WorkflowExpression.Compile(exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled, nameof(exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled), required: false);
            var __workflow_exchangeSetMailboxEmailAddressesemailAddressesToAddList = WorkflowExpression.Compile(exchangeSetMailboxEmailAddressesemailAddressesToAddList, nameof(exchangeSetMailboxEmailAddressesemailAddressesToAddList), required: false);
            var __workflow_exchangeSetMailboxEmailAddressesreplaceEmailAddresses = WorkflowExpression.Compile(exchangeSetMailboxEmailAddressesreplaceEmailAddresses, nameof(exchangeSetMailboxEmailAddressesreplaceEmailAddresses), required: false);
            var __workflow_exchangeSetMailboxEmailAddressesemailAddressesToRemoveList = WorkflowExpression.Compile(exchangeSetMailboxEmailAddressesemailAddressesToRemoveList, nameof(exchangeSetMailboxEmailAddressesemailAddressesToRemoveList), required: false);
            return new DeferredBodyAction<ExchangeSetMailboxEmailAddressesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetMailboxEmailAddresses = new JObject();
                var exchangeSetMailboxEmailAddressespropCount = 0;
                exchangeSetMailboxEmailAddressespropCount++;
                exchangeSetMailboxEmailAddresses["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxEmailAddressesidentity);
                if (__workflow_exchangeSetMailboxEmailAddressesalias != null)
                {
                    exchangeSetMailboxEmailAddresses["Alias"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxEmailAddressesalias);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                if (__workflow_exchangeSetMailboxEmailAddressesprimarySmtpAddress != null)
                {
                    exchangeSetMailboxEmailAddresses["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxEmailAddressesprimarySmtpAddress);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                if (__workflow_exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled != null)
                {
                    exchangeSetMailboxEmailAddresses["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                if (__workflow_exchangeSetMailboxEmailAddressesemailAddressesToAddList != null)
                {
                    exchangeSetMailboxEmailAddresses["EmailAddressesToAddList"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxEmailAddressesemailAddressesToAddList);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                if (__workflow_exchangeSetMailboxEmailAddressesreplaceEmailAddresses != null)
                {
                    if (__workflow_exchangeSetMailboxEmailAddressesreplaceEmailAddresses != null)
                    {
                        exchangeSetMailboxEmailAddresses["ReplaceEmailAddresses"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxEmailAddressesreplaceEmailAddresses);
                        exchangeSetMailboxEmailAddressespropCount++;
                    }

                    exchangeSetMailboxEmailAddressespropCount++;
                }
                else
                {
                    exchangeSetMailboxEmailAddresses["ReplaceEmailAddresses"] = true;
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                if (__workflow_exchangeSetMailboxEmailAddressesemailAddressesToRemoveList != null)
                {
                    exchangeSetMailboxEmailAddresses["EmailAddressesToRemoveList"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxEmailAddressesemailAddressesToRemoveList);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                exchangeSetMailboxEmailAddressespropCount++;
                exchangeSetMailboxEmailAddresses["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxEmailAddressesworkflow);
                if (exchangeSetMailboxEmailAddressespropCount > 0)
                {
                    callPayload.Body = exchangeSetMailboxEmailAddresses;
                }

                return new ApiConnectionAction<ExchangeSetMailboxEmailAddressesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxEmailAddressesResponse, ApiConnectionActionConfiguration> ExchangeGetMailboxEmailAddresses(Expression<Func<string>> exchangeGetMailboxEmailAddressesidentity, Expression<Func<string>> exchangeGetMailboxEmailAddressesworkflow)
        {
            var __workflow_exchangeGetMailboxEmailAddressesidentity = WorkflowExpression.Compile(exchangeGetMailboxEmailAddressesidentity, nameof(exchangeGetMailboxEmailAddressesidentity), required: true);
            var __workflow_exchangeGetMailboxEmailAddressesworkflow = WorkflowExpression.Compile(exchangeGetMailboxEmailAddressesworkflow, nameof(exchangeGetMailboxEmailAddressesworkflow), required: true);
            return new DeferredBodyAction<ExchangeGetMailboxEmailAddressesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetMailboxEmailAddresses = new JObject();
                var exchangeGetMailboxEmailAddressespropCount = 0;
                exchangeGetMailboxEmailAddressespropCount++;
                exchangeGetMailboxEmailAddresses["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeGetMailboxEmailAddressesidentity);
                exchangeGetMailboxEmailAddressespropCount++;
                exchangeGetMailboxEmailAddresses["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeGetMailboxEmailAddressesworkflow);
                if (exchangeGetMailboxEmailAddressespropCount > 0)
                {
                    callPayload.Body = exchangeGetMailboxEmailAddresses;
                }

                return new ApiConnectionAction<ExchangeGetMailboxEmailAddressesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxEmailAddressesResponse, ApiConnectionActionConfiguration> ExchangeSetRemoteMailboxEmailAddresses(Expression<Func<string>> exchangeSetRemoteMailboxEmailAddressesidentity, Expression<Func<string>> exchangeSetRemoteMailboxEmailAddressesworkflow, Expression<Func<string>> exchangeSetRemoteMailboxEmailAddressesalias = null, Expression<Func<string>> exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress = null, Expression<Func<bool>> exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled = null, Expression<Func<string[]>> exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList = null, Expression<Func<bool>> exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses = null, Expression<Func<string[]>> exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList = null)
        {
            var __workflow_exchangeSetRemoteMailboxEmailAddressesidentity = WorkflowExpression.Compile(exchangeSetRemoteMailboxEmailAddressesidentity, nameof(exchangeSetRemoteMailboxEmailAddressesidentity), required: true);
            var __workflow_exchangeSetRemoteMailboxEmailAddressesworkflow = WorkflowExpression.Compile(exchangeSetRemoteMailboxEmailAddressesworkflow, nameof(exchangeSetRemoteMailboxEmailAddressesworkflow), required: true);
            var __workflow_exchangeSetRemoteMailboxEmailAddressesalias = WorkflowExpression.Compile(exchangeSetRemoteMailboxEmailAddressesalias, nameof(exchangeSetRemoteMailboxEmailAddressesalias), required: false);
            var __workflow_exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress = WorkflowExpression.Compile(exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress, nameof(exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress), required: false);
            var __workflow_exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled = WorkflowExpression.Compile(exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled, nameof(exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled), required: false);
            var __workflow_exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList = WorkflowExpression.Compile(exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList, nameof(exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList), required: false);
            var __workflow_exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses = WorkflowExpression.Compile(exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses, nameof(exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses), required: false);
            var __workflow_exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList = WorkflowExpression.Compile(exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList, nameof(exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList), required: false);
            return new DeferredBodyAction<ExchangeSetRemoteMailboxEmailAddressesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetRemoteMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetRemoteMailboxEmailAddresses = new JObject();
                var exchangeSetRemoteMailboxEmailAddressespropCount = 0;
                exchangeSetRemoteMailboxEmailAddressespropCount++;
                exchangeSetRemoteMailboxEmailAddresses["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxEmailAddressesidentity);
                if (__workflow_exchangeSetRemoteMailboxEmailAddressesalias != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["Alias"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxEmailAddressesalias);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["EmailAddressesToAddList"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses != null)
                {
                    if (__workflow_exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses != null)
                    {
                        exchangeSetRemoteMailboxEmailAddresses["ReplaceEmailAddresses"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses);
                        exchangeSetRemoteMailboxEmailAddressespropCount++;
                    }

                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }
                else
                {
                    exchangeSetRemoteMailboxEmailAddresses["ReplaceEmailAddresses"] = true;
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["EmailAddressesToRemoveList"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                exchangeSetRemoteMailboxEmailAddressespropCount++;
                exchangeSetRemoteMailboxEmailAddresses["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxEmailAddressesworkflow);
                if (exchangeSetRemoteMailboxEmailAddressespropCount > 0)
                {
                    callPayload.Body = exchangeSetRemoteMailboxEmailAddresses;
                }

                return new ApiConnectionAction<ExchangeSetRemoteMailboxEmailAddressesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxEmailAddressesResponse, ApiConnectionActionConfiguration> ExchangeGetRemoteMailboxEmailAddresses(Expression<Func<string>> exchangeGetRemoteMailboxEmailAddressesidentity, Expression<Func<string>> exchangeGetRemoteMailboxEmailAddressesworkflow)
        {
            var __workflow_exchangeGetRemoteMailboxEmailAddressesidentity = WorkflowExpression.Compile(exchangeGetRemoteMailboxEmailAddressesidentity, nameof(exchangeGetRemoteMailboxEmailAddressesidentity), required: true);
            var __workflow_exchangeGetRemoteMailboxEmailAddressesworkflow = WorkflowExpression.Compile(exchangeGetRemoteMailboxEmailAddressesworkflow, nameof(exchangeGetRemoteMailboxEmailAddressesworkflow), required: true);
            return new DeferredBodyAction<ExchangeGetRemoteMailboxEmailAddressesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetRemoteMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetRemoteMailboxEmailAddresses = new JObject();
                var exchangeGetRemoteMailboxEmailAddressespropCount = 0;
                exchangeGetRemoteMailboxEmailAddressespropCount++;
                exchangeGetRemoteMailboxEmailAddresses["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeGetRemoteMailboxEmailAddressesidentity);
                exchangeGetRemoteMailboxEmailAddressespropCount++;
                exchangeGetRemoteMailboxEmailAddresses["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeGetRemoteMailboxEmailAddressesworkflow);
                if (exchangeGetRemoteMailboxEmailAddressespropCount > 0)
                {
                    callPayload.Body = exchangeGetRemoteMailboxEmailAddresses;
                }

                return new ApiConnectionAction<ExchangeGetRemoteMailboxEmailAddressesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeResetMailboxAttributesResponse, ApiConnectionActionConfiguration> ExchangeResetMailboxAttributes(Expression<Func<string>> exchangeResetMailboxAttributesidentity, Expression<Func<string>> exchangeResetMailboxAttributesworkflow, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute1 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute2 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute3 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute4 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute5 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute6 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute7 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute8 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute9 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute10 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute11 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute12 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute13 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute14 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute15 = null)
        {
            var __workflow_exchangeResetMailboxAttributesidentity = WorkflowExpression.Compile(exchangeResetMailboxAttributesidentity, nameof(exchangeResetMailboxAttributesidentity), required: true);
            var __workflow_exchangeResetMailboxAttributesworkflow = WorkflowExpression.Compile(exchangeResetMailboxAttributesworkflow, nameof(exchangeResetMailboxAttributesworkflow), required: true);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute1 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute1, nameof(exchangeResetMailboxAttributesresetCustomAttribute1), required: false);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute2 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute2, nameof(exchangeResetMailboxAttributesresetCustomAttribute2), required: false);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute3 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute3, nameof(exchangeResetMailboxAttributesresetCustomAttribute3), required: false);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute4 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute4, nameof(exchangeResetMailboxAttributesresetCustomAttribute4), required: false);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute5 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute5, nameof(exchangeResetMailboxAttributesresetCustomAttribute5), required: false);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute6 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute6, nameof(exchangeResetMailboxAttributesresetCustomAttribute6), required: false);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute7 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute7, nameof(exchangeResetMailboxAttributesresetCustomAttribute7), required: false);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute8 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute8, nameof(exchangeResetMailboxAttributesresetCustomAttribute8), required: false);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute9 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute9, nameof(exchangeResetMailboxAttributesresetCustomAttribute9), required: false);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute10 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute10, nameof(exchangeResetMailboxAttributesresetCustomAttribute10), required: false);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute11 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute11, nameof(exchangeResetMailboxAttributesresetCustomAttribute11), required: false);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute12 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute12, nameof(exchangeResetMailboxAttributesresetCustomAttribute12), required: false);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute13 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute13, nameof(exchangeResetMailboxAttributesresetCustomAttribute13), required: false);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute14 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute14, nameof(exchangeResetMailboxAttributesresetCustomAttribute14), required: false);
            var __workflow_exchangeResetMailboxAttributesresetCustomAttribute15 = WorkflowExpression.Compile(exchangeResetMailboxAttributesresetCustomAttribute15, nameof(exchangeResetMailboxAttributesresetCustomAttribute15), required: false);
            return new DeferredBodyAction<ExchangeResetMailboxAttributesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeResetMailboxAttributes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeResetMailboxAttributes = new JObject();
                var exchangeResetMailboxAttributespropCount = 0;
                exchangeResetMailboxAttributespropCount++;
                exchangeResetMailboxAttributes["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesidentity);
                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute1 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute1 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute1"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute1);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute1"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute2 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute2 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute2"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute2);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute2"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute3 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute3 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute3"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute3);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute3"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute4 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute4 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute4"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute4);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute4"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute5 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute5 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute5"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute5);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute5"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute6 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute6 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute6"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute6);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute6"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute7 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute7 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute7"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute7);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute7"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute8 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute8 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute8"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute8);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute8"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute9 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute9 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute9"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute9);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute9"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute10 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute10 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute10"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute10);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute10"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute11 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute11 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute11"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute11);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute11"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute12 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute12 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute12"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute12);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute12"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute13 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute13 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute13"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute13);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute13"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute14 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute14 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute14"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute14);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute14"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute15 != null)
                {
                    if (__workflow_exchangeResetMailboxAttributesresetCustomAttribute15 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute15"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesresetCustomAttribute15);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute15"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                exchangeResetMailboxAttributespropCount++;
                exchangeResetMailboxAttributes["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributesworkflow);
                if (exchangeResetMailboxAttributespropCount > 0)
                {
                    callPayload.Body = exchangeResetMailboxAttributes;
                }

                return new ApiConnectionAction<ExchangeResetMailboxAttributesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeResetRemoteMailboxAttributesResponse, ApiConnectionActionConfiguration> ExchangeResetRemoteMailboxAttributes(Expression<Func<string>> exchangeResetRemoteMailboxAttributesidentity, Expression<Func<string>> exchangeResetRemoteMailboxAttributesworkflow, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute1 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute2 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute3 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute4 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute5 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute6 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute7 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute8 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute9 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute10 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute11 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute12 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute13 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute14 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute15 = null)
        {
            var __workflow_exchangeResetRemoteMailboxAttributesidentity = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesidentity, nameof(exchangeResetRemoteMailboxAttributesidentity), required: true);
            var __workflow_exchangeResetRemoteMailboxAttributesworkflow = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesworkflow, nameof(exchangeResetRemoteMailboxAttributesworkflow), required: true);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute1 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute1, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute1), required: false);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute2 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute2, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute2), required: false);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute3 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute3, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute3), required: false);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute4 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute4, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute4), required: false);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute5 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute5, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute5), required: false);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute6 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute6, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute6), required: false);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute7 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute7, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute7), required: false);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute8 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute8, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute8), required: false);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute9 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute9, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute9), required: false);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute10 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute10, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute10), required: false);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute11 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute11, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute11), required: false);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute12 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute12, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute12), required: false);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute13 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute13, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute13), required: false);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute14 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute14, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute14), required: false);
            var __workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute15 = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributesresetCustomAttribute15, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute15), required: false);
            return new DeferredBodyAction<ExchangeResetRemoteMailboxAttributesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeResetRemoteMailboxAttributes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeResetRemoteMailboxAttributes = new JObject();
                var exchangeResetRemoteMailboxAttributespropCount = 0;
                exchangeResetRemoteMailboxAttributespropCount++;
                exchangeResetRemoteMailboxAttributes["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesidentity);
                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute1 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute1 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute1"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute1);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute1"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute2 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute2 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute2"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute2);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute2"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute3 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute3 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute3"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute3);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute3"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute4 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute4 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute4"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute4);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute4"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute5 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute5 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute5"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute5);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute5"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute6 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute6 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute6"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute6);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute6"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute7 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute7 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute7"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute7);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute7"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute8 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute8 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute8"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute8);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute8"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute9 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute9 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute9"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute9);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute9"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute10 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute10 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute10"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute10);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute10"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute11 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute11 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute11"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute11);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute11"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute12 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute12 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute12"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute12);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute12"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute13 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute13 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute13"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute13);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute13"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute14 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute14 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute14"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute14);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute14"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute15 != null)
                {
                    if (__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute15 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute15"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesresetCustomAttribute15);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute15"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                exchangeResetRemoteMailboxAttributespropCount++;
                exchangeResetRemoteMailboxAttributes["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributesworkflow);
                if (exchangeResetRemoteMailboxAttributespropCount > 0)
                {
                    callPayload.Body = exchangeResetRemoteMailboxAttributes;
                }

                return new ApiConnectionAction<ExchangeResetRemoteMailboxAttributesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxResponse, ApiConnectionActionConfiguration> ExchangeSetRemoteMailbox(Expression<Func<string>> exchangeSetRemoteMailboxidentity, Expression<Func<string>> exchangeSetRemoteMailboxworkflow, Expression<Func<string>> exchangeSetRemoteMailboxalias = null, Expression<Func<string>> exchangeSetRemoteMailboxdisplayName = null, Expression<Func<string>> exchangeSetRemoteMailboxprimarySmtpAddress = null, Expression<Func<exchangeSetRemoteMailboxtypeInput>> exchangeSetRemoteMailboxtype = null, Expression<Func<bool>> exchangeSetRemoteMailboxhiddenFromAddressListsEnabled = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute1 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute2 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute3 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute4 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute5 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute6 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute7 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute8 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute9 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute10 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute11 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute12 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute13 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute14 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute15 = null, Expression<Func<bool>> exchangeSetRemoteMailboxemailAddressPolicyEnabled = null)
        {
            var __workflow_exchangeSetRemoteMailboxidentity = WorkflowExpression.Compile(exchangeSetRemoteMailboxidentity, nameof(exchangeSetRemoteMailboxidentity), required: true);
            var __workflow_exchangeSetRemoteMailboxworkflow = WorkflowExpression.Compile(exchangeSetRemoteMailboxworkflow, nameof(exchangeSetRemoteMailboxworkflow), required: true);
            var __workflow_exchangeSetRemoteMailboxalias = WorkflowExpression.Compile(exchangeSetRemoteMailboxalias, nameof(exchangeSetRemoteMailboxalias), required: false);
            var __workflow_exchangeSetRemoteMailboxdisplayName = WorkflowExpression.Compile(exchangeSetRemoteMailboxdisplayName, nameof(exchangeSetRemoteMailboxdisplayName), required: false);
            var __workflow_exchangeSetRemoteMailboxprimarySmtpAddress = WorkflowExpression.Compile(exchangeSetRemoteMailboxprimarySmtpAddress, nameof(exchangeSetRemoteMailboxprimarySmtpAddress), required: false);
            var __workflow_exchangeSetRemoteMailboxtype = WorkflowExpression.Compile(exchangeSetRemoteMailboxtype, nameof(exchangeSetRemoteMailboxtype), required: false);
            var __workflow_exchangeSetRemoteMailboxhiddenFromAddressListsEnabled = WorkflowExpression.Compile(exchangeSetRemoteMailboxhiddenFromAddressListsEnabled, nameof(exchangeSetRemoteMailboxhiddenFromAddressListsEnabled), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute1 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute1, nameof(exchangeSetRemoteMailboxcustomAttribute1), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute2 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute2, nameof(exchangeSetRemoteMailboxcustomAttribute2), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute3 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute3, nameof(exchangeSetRemoteMailboxcustomAttribute3), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute4 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute4, nameof(exchangeSetRemoteMailboxcustomAttribute4), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute5 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute5, nameof(exchangeSetRemoteMailboxcustomAttribute5), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute6 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute6, nameof(exchangeSetRemoteMailboxcustomAttribute6), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute7 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute7, nameof(exchangeSetRemoteMailboxcustomAttribute7), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute8 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute8, nameof(exchangeSetRemoteMailboxcustomAttribute8), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute9 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute9, nameof(exchangeSetRemoteMailboxcustomAttribute9), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute10 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute10, nameof(exchangeSetRemoteMailboxcustomAttribute10), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute11 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute11, nameof(exchangeSetRemoteMailboxcustomAttribute11), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute12 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute12, nameof(exchangeSetRemoteMailboxcustomAttribute12), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute13 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute13, nameof(exchangeSetRemoteMailboxcustomAttribute13), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute14 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute14, nameof(exchangeSetRemoteMailboxcustomAttribute14), required: false);
            var __workflow_exchangeSetRemoteMailboxcustomAttribute15 = WorkflowExpression.Compile(exchangeSetRemoteMailboxcustomAttribute15, nameof(exchangeSetRemoteMailboxcustomAttribute15), required: false);
            var __workflow_exchangeSetRemoteMailboxemailAddressPolicyEnabled = WorkflowExpression.Compile(exchangeSetRemoteMailboxemailAddressPolicyEnabled, nameof(exchangeSetRemoteMailboxemailAddressPolicyEnabled), required: false);
            return new DeferredBodyAction<ExchangeSetRemoteMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetRemoteMailbox = new JObject();
                var exchangeSetRemoteMailboxpropCount = 0;
                exchangeSetRemoteMailboxpropCount++;
                exchangeSetRemoteMailbox["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxidentity);
                if (__workflow_exchangeSetRemoteMailboxalias != null)
                {
                    exchangeSetRemoteMailbox["Alias"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxalias);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxdisplayName != null)
                {
                    exchangeSetRemoteMailbox["DisplayName"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxdisplayName);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxprimarySmtpAddress != null)
                {
                    exchangeSetRemoteMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxprimarySmtpAddress);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxtype != null)
                {
                    exchangeSetRemoteMailbox["Type"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxtype);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxhiddenFromAddressListsEnabled != null)
                {
                    exchangeSetRemoteMailbox["HiddenFromAddressListsEnabled"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxhiddenFromAddressListsEnabled);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute1 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute1"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute1);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute2 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute2"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute2);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute3 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute3"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute3);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute4 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute4"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute4);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute5 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute5"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute5);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute6 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute6"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute6);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute7 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute7"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute7);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute8 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute8"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute8);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute9 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute9"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute9);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute10 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute10"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute10);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute11 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute11"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute11);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute12 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute12"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute12);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute13 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute13"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute13);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute14 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute14"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute14);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxcustomAttribute15 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute15"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxcustomAttribute15);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (__workflow_exchangeSetRemoteMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeSetRemoteMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxemailAddressPolicyEnabled);
                    exchangeSetRemoteMailboxpropCount++;
                }

                exchangeSetRemoteMailboxpropCount++;
                exchangeSetRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxworkflow);
                if (exchangeSetRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeSetRemoteMailbox;
                }

                return new ApiConnectionAction<ExchangeSetRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse, ApiConnectionActionConfiguration> ExchangeSetMailboxSendOnBehalfOfPermission(Expression<Func<string>> exchangeSetMailboxSendOnBehalfOfPermissionidentity, Expression<Func<string>> exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo, Expression<Func<string>> exchangeSetMailboxSendOnBehalfOfPermissionworkflow)
        {
            var __workflow_exchangeSetMailboxSendOnBehalfOfPermissionidentity = WorkflowExpression.Compile(exchangeSetMailboxSendOnBehalfOfPermissionidentity, nameof(exchangeSetMailboxSendOnBehalfOfPermissionidentity), required: true);
            var __workflow_exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo = WorkflowExpression.Compile(exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo, nameof(exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo), required: true);
            var __workflow_exchangeSetMailboxSendOnBehalfOfPermissionworkflow = WorkflowExpression.Compile(exchangeSetMailboxSendOnBehalfOfPermissionworkflow, nameof(exchangeSetMailboxSendOnBehalfOfPermissionworkflow), required: true);
            return new DeferredBodyAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxSendOnBehalfOfPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetMailboxSendOnBehalfOfPermission = new JObject();
                var exchangeSetMailboxSendOnBehalfOfPermissionpropCount = 0;
                exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
                exchangeSetMailboxSendOnBehalfOfPermission["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxSendOnBehalfOfPermissionidentity);
                exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
                exchangeSetMailboxSendOnBehalfOfPermission["GrantSendOnBehalfTo"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo);
                exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
                exchangeSetMailboxSendOnBehalfOfPermission["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxSendOnBehalfOfPermissionworkflow);
                if (exchangeSetMailboxSendOnBehalfOfPermissionpropCount > 0)
                {
                    callPayload.Body = exchangeSetMailboxSendOnBehalfOfPermission;
                }

                return new ApiConnectionAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddADPermissionResponse, ApiConnectionActionConfiguration> ExchangeAddADPermission(Expression<Func<string>> exchangeAddADPermissionidentity, Expression<Func<string>> exchangeAddADPermissionuser, Expression<Func<string>> exchangeAddADPermissionworkflow, Expression<Func<string>> exchangeAddADPermissionaccessRights = null, Expression<Func<string>> exchangeAddADPermissionextendedRights = null)
        {
            var __workflow_exchangeAddADPermissionidentity = WorkflowExpression.Compile(exchangeAddADPermissionidentity, nameof(exchangeAddADPermissionidentity), required: true);
            var __workflow_exchangeAddADPermissionuser = WorkflowExpression.Compile(exchangeAddADPermissionuser, nameof(exchangeAddADPermissionuser), required: true);
            var __workflow_exchangeAddADPermissionworkflow = WorkflowExpression.Compile(exchangeAddADPermissionworkflow, nameof(exchangeAddADPermissionworkflow), required: true);
            var __workflow_exchangeAddADPermissionaccessRights = WorkflowExpression.Compile(exchangeAddADPermissionaccessRights, nameof(exchangeAddADPermissionaccessRights), required: false);
            var __workflow_exchangeAddADPermissionextendedRights = WorkflowExpression.Compile(exchangeAddADPermissionextendedRights, nameof(exchangeAddADPermissionextendedRights), required: false);
            return new DeferredBodyAction<ExchangeAddADPermissionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeAddADPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeAddADPermission = new JObject();
                var exchangeAddADPermissionpropCount = 0;
                exchangeAddADPermissionpropCount++;
                exchangeAddADPermission["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeAddADPermissionidentity);
                exchangeAddADPermissionpropCount++;
                exchangeAddADPermission["User"] = ExpressionConverter.ConvertO(__workflow_exchangeAddADPermissionuser);
                if (__workflow_exchangeAddADPermissionaccessRights != null)
                {
                    exchangeAddADPermission["AccessRights"] = ExpressionConverter.ConvertO(__workflow_exchangeAddADPermissionaccessRights);
                    exchangeAddADPermissionpropCount++;
                }

                if (__workflow_exchangeAddADPermissionextendedRights != null)
                {
                    exchangeAddADPermission["ExtendedRights"] = ExpressionConverter.ConvertO(__workflow_exchangeAddADPermissionextendedRights);
                    exchangeAddADPermissionpropCount++;
                }

                exchangeAddADPermissionpropCount++;
                exchangeAddADPermission["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeAddADPermissionworkflow);
                if (exchangeAddADPermissionpropCount > 0)
                {
                    callPayload.Body = exchangeAddADPermission;
                }

                return new ApiConnectionAction<ExchangeAddADPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxAutoReplyConfigurationResponse, ApiConnectionActionConfiguration> ExchangeSetMailboxAutoReplyConfiguration(Expression<Func<string>> exchangeSetMailboxAutoReplyConfigurationidentity, Expression<Func<exchangeSetMailboxAutoReplyConfigurationautoReplyStateInput>> exchangeSetMailboxAutoReplyConfigurationautoReplyState, Expression<Func<string>> exchangeSetMailboxAutoReplyConfigurationworkflow, Expression<Func<string>> exchangeSetMailboxAutoReplyConfigurationinternalMessage = null, Expression<Func<exchangeSetMailboxAutoReplyConfigurationexternalAudienceInput>> exchangeSetMailboxAutoReplyConfigurationexternalAudience = null, Expression<Func<string>> exchangeSetMailboxAutoReplyConfigurationexternalMessage = null)
        {
            var __workflow_exchangeSetMailboxAutoReplyConfigurationidentity = WorkflowExpression.Compile(exchangeSetMailboxAutoReplyConfigurationidentity, nameof(exchangeSetMailboxAutoReplyConfigurationidentity), required: true);
            var __workflow_exchangeSetMailboxAutoReplyConfigurationautoReplyState = WorkflowExpression.Compile(exchangeSetMailboxAutoReplyConfigurationautoReplyState, nameof(exchangeSetMailboxAutoReplyConfigurationautoReplyState), required: true);
            var __workflow_exchangeSetMailboxAutoReplyConfigurationworkflow = WorkflowExpression.Compile(exchangeSetMailboxAutoReplyConfigurationworkflow, nameof(exchangeSetMailboxAutoReplyConfigurationworkflow), required: true);
            var __workflow_exchangeSetMailboxAutoReplyConfigurationinternalMessage = WorkflowExpression.Compile(exchangeSetMailboxAutoReplyConfigurationinternalMessage, nameof(exchangeSetMailboxAutoReplyConfigurationinternalMessage), required: false);
            var __workflow_exchangeSetMailboxAutoReplyConfigurationexternalAudience = WorkflowExpression.Compile(exchangeSetMailboxAutoReplyConfigurationexternalAudience, nameof(exchangeSetMailboxAutoReplyConfigurationexternalAudience), required: false);
            var __workflow_exchangeSetMailboxAutoReplyConfigurationexternalMessage = WorkflowExpression.Compile(exchangeSetMailboxAutoReplyConfigurationexternalMessage, nameof(exchangeSetMailboxAutoReplyConfigurationexternalMessage), required: false);
            return new DeferredBodyAction<ExchangeSetMailboxAutoReplyConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxAutoReplyConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetMailboxAutoReplyConfiguration = new JObject();
                var exchangeSetMailboxAutoReplyConfigurationpropCount = 0;
                exchangeSetMailboxAutoReplyConfigurationpropCount++;
                exchangeSetMailboxAutoReplyConfiguration["Identity"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxAutoReplyConfigurationidentity);
                exchangeSetMailboxAutoReplyConfigurationpropCount++;
                exchangeSetMailboxAutoReplyConfiguration["AutoReplyState"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxAutoReplyConfigurationautoReplyState);
                if (__workflow_exchangeSetMailboxAutoReplyConfigurationinternalMessage != null)
                {
                    exchangeSetMailboxAutoReplyConfiguration["InternalMessage"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxAutoReplyConfigurationinternalMessage);
                    exchangeSetMailboxAutoReplyConfigurationpropCount++;
                }

                if (__workflow_exchangeSetMailboxAutoReplyConfigurationexternalAudience != null)
                {
                    if (__workflow_exchangeSetMailboxAutoReplyConfigurationexternalAudience != null)
                    {
                        exchangeSetMailboxAutoReplyConfiguration["ExternalAudience"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxAutoReplyConfigurationexternalAudience);
                        exchangeSetMailboxAutoReplyConfigurationpropCount++;
                    }

                    exchangeSetMailboxAutoReplyConfigurationpropCount++;
                }
                else
                {
                    exchangeSetMailboxAutoReplyConfiguration["ExternalAudience"] = "All";
                    exchangeSetMailboxAutoReplyConfigurationpropCount++;
                }

                if (__workflow_exchangeSetMailboxAutoReplyConfigurationexternalMessage != null)
                {
                    exchangeSetMailboxAutoReplyConfiguration["ExternalMessage"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxAutoReplyConfigurationexternalMessage);
                    exchangeSetMailboxAutoReplyConfigurationpropCount++;
                }

                exchangeSetMailboxAutoReplyConfigurationpropCount++;
                exchangeSetMailboxAutoReplyConfiguration["Workflow"] = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxAutoReplyConfigurationworkflow);
                if (exchangeSetMailboxAutoReplyConfigurationpropCount > 0)
                {
                    callPayload.Body = exchangeSetMailboxAutoReplyConfiguration;
                }

                return new ApiConnectionAction<ExchangeSetMailboxAutoReplyConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsAzureADv2PowerShellModuleInstalledResponse, ApiConnectionActionConfiguration> IsAzureADv2PowerShellModuleInstalled(Expression<Func<string>> isAzureADv2PowerShellModuleInstalledworkflow)
        {
            var __workflow_isAzureADv2PowerShellModuleInstalledworkflow = WorkflowExpression.Compile(isAzureADv2PowerShellModuleInstalledworkflow, nameof(isAzureADv2PowerShellModuleInstalledworkflow), required: true);
            return new DeferredBodyAction<IsAzureADv2PowerShellModuleInstalledResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/IsAzureADv2PowerShellModuleInstalled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isAzureADv2PowerShellModuleInstalled = new JObject();
                var isAzureADv2PowerShellModuleInstalledpropCount = 0;
                isAzureADv2PowerShellModuleInstalledpropCount++;
                isAzureADv2PowerShellModuleInstalled["Workflow"] = ExpressionConverter.ConvertO(__workflow_isAzureADv2PowerShellModuleInstalledworkflow);
                if (isAzureADv2PowerShellModuleInstalledpropCount > 0)
                {
                    callPayload.Body = isAzureADv2PowerShellModuleInstalled;
                }

                return new ApiConnectionAction<IsAzureADv2PowerShellModuleInstalledResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceResponse, ApiConnectionActionConfiguration> OpenAzureADv2PowerShellRunspace(Expression<Func<string>> openAzureADv2PowerShellRunspaceusername, Expression<Func<string>> openAzureADv2PowerShellRunspacepassword, Expression<Func<string>> openAzureADv2PowerShellRunspaceworkflow, Expression<Func<string>> openAzureADv2PowerShellRunspacetenantId = null, Expression<Func<openAzureADv2PowerShellRunspaceaPIToUseInput>> openAzureADv2PowerShellRunspaceaPIToUse = null, Expression<Func<string>> openAzureADv2PowerShellRunspaceauthenticationScope = null)
        {
            var __workflow_openAzureADv2PowerShellRunspaceusername = WorkflowExpression.Compile(openAzureADv2PowerShellRunspaceusername, nameof(openAzureADv2PowerShellRunspaceusername), required: true);
            var __workflow_openAzureADv2PowerShellRunspacepassword = WorkflowExpression.Compile(openAzureADv2PowerShellRunspacepassword, nameof(openAzureADv2PowerShellRunspacepassword), required: true);
            var __workflow_openAzureADv2PowerShellRunspaceworkflow = WorkflowExpression.Compile(openAzureADv2PowerShellRunspaceworkflow, nameof(openAzureADv2PowerShellRunspaceworkflow), required: true);
            var __workflow_openAzureADv2PowerShellRunspacetenantId = WorkflowExpression.Compile(openAzureADv2PowerShellRunspacetenantId, nameof(openAzureADv2PowerShellRunspacetenantId), required: false);
            var __workflow_openAzureADv2PowerShellRunspaceaPIToUse = WorkflowExpression.Compile(openAzureADv2PowerShellRunspaceaPIToUse, nameof(openAzureADv2PowerShellRunspaceaPIToUse), required: false);
            var __workflow_openAzureADv2PowerShellRunspaceauthenticationScope = WorkflowExpression.Compile(openAzureADv2PowerShellRunspaceauthenticationScope, nameof(openAzureADv2PowerShellRunspaceauthenticationScope), required: false);
            return new DeferredBodyAction<OpenAzureADv2PowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/OpenAzureADv2PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openAzureADv2PowerShellRunspace = new JObject();
                var openAzureADv2PowerShellRunspacepropCount = 0;
                openAzureADv2PowerShellRunspacepropCount++;
                openAzureADv2PowerShellRunspace["Username"] = ExpressionConverter.ConvertO(__workflow_openAzureADv2PowerShellRunspaceusername);
                openAzureADv2PowerShellRunspacepropCount++;
                openAzureADv2PowerShellRunspace["Password"] = ExpressionConverter.ConvertO(__workflow_openAzureADv2PowerShellRunspacepassword);
                if (__workflow_openAzureADv2PowerShellRunspacetenantId != null)
                {
                    openAzureADv2PowerShellRunspace["TenantId"] = ExpressionConverter.ConvertO(__workflow_openAzureADv2PowerShellRunspacetenantId);
                    openAzureADv2PowerShellRunspacepropCount++;
                }

                if (__workflow_openAzureADv2PowerShellRunspaceaPIToUse != null)
                {
                    if (__workflow_openAzureADv2PowerShellRunspaceaPIToUse != null)
                    {
                        openAzureADv2PowerShellRunspace["APIToUse"] = ExpressionConverter.ConvertO(__workflow_openAzureADv2PowerShellRunspaceaPIToUse);
                        openAzureADv2PowerShellRunspacepropCount++;
                    }

                    openAzureADv2PowerShellRunspacepropCount++;
                }
                else
                {
                    openAzureADv2PowerShellRunspace["APIToUse"] = "Auto";
                    openAzureADv2PowerShellRunspacepropCount++;
                }

                if (__workflow_openAzureADv2PowerShellRunspaceauthenticationScope != null)
                {
                    if (__workflow_openAzureADv2PowerShellRunspaceauthenticationScope != null)
                    {
                        openAzureADv2PowerShellRunspace["AuthenticationScope"] = ExpressionConverter.ConvertO(__workflow_openAzureADv2PowerShellRunspaceauthenticationScope);
                        openAzureADv2PowerShellRunspacepropCount++;
                    }

                    openAzureADv2PowerShellRunspacepropCount++;
                }
                else
                {
                    openAzureADv2PowerShellRunspace["AuthenticationScope"] = "User.ReadWrite.All Group.ReadWrite.All LicenseAssignment.ReadWrite.All";
                    openAzureADv2PowerShellRunspacepropCount++;
                }

                openAzureADv2PowerShellRunspacepropCount++;
                openAzureADv2PowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(__workflow_openAzureADv2PowerShellRunspaceworkflow);
                if (openAzureADv2PowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = openAzureADv2PowerShellRunspace;
                }

                return new ApiConnectionAction<OpenAzureADv2PowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse, ApiConnectionActionConfiguration> OpenAzureADv2PowerShellRunspaceWithCertificate(Expression<Func<string>> openAzureADv2PowerShellRunspaceWithCertificateapplicationId, Expression<Func<string>> openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint, Expression<Func<string>> openAzureADv2PowerShellRunspaceWithCertificatetenantId, Expression<Func<string>> openAzureADv2PowerShellRunspaceWithCertificateworkflow, Expression<Func<openAzureADv2PowerShellRunspaceWithCertificateaPIToUseInput>> openAzureADv2PowerShellRunspaceWithCertificateaPIToUse = null)
        {
            var __workflow_openAzureADv2PowerShellRunspaceWithCertificateapplicationId = WorkflowExpression.Compile(openAzureADv2PowerShellRunspaceWithCertificateapplicationId, nameof(openAzureADv2PowerShellRunspaceWithCertificateapplicationId), required: true);
            var __workflow_openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint = WorkflowExpression.Compile(openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint, nameof(openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint), required: true);
            var __workflow_openAzureADv2PowerShellRunspaceWithCertificatetenantId = WorkflowExpression.Compile(openAzureADv2PowerShellRunspaceWithCertificatetenantId, nameof(openAzureADv2PowerShellRunspaceWithCertificatetenantId), required: true);
            var __workflow_openAzureADv2PowerShellRunspaceWithCertificateworkflow = WorkflowExpression.Compile(openAzureADv2PowerShellRunspaceWithCertificateworkflow, nameof(openAzureADv2PowerShellRunspaceWithCertificateworkflow), required: true);
            var __workflow_openAzureADv2PowerShellRunspaceWithCertificateaPIToUse = WorkflowExpression.Compile(openAzureADv2PowerShellRunspaceWithCertificateaPIToUse, nameof(openAzureADv2PowerShellRunspaceWithCertificateaPIToUse), required: false);
            return new DeferredBodyAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/OpenAzureADv2PowerShellRunspaceWithCertificate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openAzureADv2PowerShellRunspaceWithCertificate = new JObject();
                var openAzureADv2PowerShellRunspaceWithCertificatepropCount = 0;
                openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
                openAzureADv2PowerShellRunspaceWithCertificate["ApplicationId"] = ExpressionConverter.ConvertO(__workflow_openAzureADv2PowerShellRunspaceWithCertificateapplicationId);
                openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
                openAzureADv2PowerShellRunspaceWithCertificate["CertificateThumbprint"] = ExpressionConverter.ConvertO(__workflow_openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint);
                openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
                openAzureADv2PowerShellRunspaceWithCertificate["TenantId"] = ExpressionConverter.ConvertO(__workflow_openAzureADv2PowerShellRunspaceWithCertificatetenantId);
                if (__workflow_openAzureADv2PowerShellRunspaceWithCertificateaPIToUse != null)
                {
                    if (__workflow_openAzureADv2PowerShellRunspaceWithCertificateaPIToUse != null)
                    {
                        openAzureADv2PowerShellRunspaceWithCertificate["APIToUse"] = ExpressionConverter.ConvertO(__workflow_openAzureADv2PowerShellRunspaceWithCertificateaPIToUse);
                        openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
                    }

                    openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
                }
                else
                {
                    openAzureADv2PowerShellRunspaceWithCertificate["APIToUse"] = "Auto";
                    openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
                }

                openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
                openAzureADv2PowerShellRunspaceWithCertificate["Workflow"] = ExpressionConverter.ConvertO(__workflow_openAzureADv2PowerShellRunspaceWithCertificateworkflow);
                if (openAzureADv2PowerShellRunspaceWithCertificatepropCount > 0)
                {
                    callPayload.Body = openAzureADv2PowerShellRunspaceWithCertificate;
                }

                return new ApiConnectionAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsAzureADv2PowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration> IsAzureADv2PowerShellRunspaceOpen(Expression<Func<string>> isAzureADv2PowerShellRunspaceOpenworkflow, Expression<Func<bool>> isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
        {
            var __workflow_isAzureADv2PowerShellRunspaceOpenworkflow = WorkflowExpression.Compile(isAzureADv2PowerShellRunspaceOpenworkflow, nameof(isAzureADv2PowerShellRunspaceOpenworkflow), required: true);
            var __workflow_isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID = WorkflowExpression.Compile(isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID, nameof(isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID), required: false);
            return new DeferredBodyAction<IsAzureADv2PowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/IsAzureADv2PowerShellRunspaceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isAzureADv2PowerShellRunspaceOpen = new JObject();
                var isAzureADv2PowerShellRunspaceOpenpropCount = 0;
                if (__workflow_isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID != null)
                {
                    if (__workflow_isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID != null)
                    {
                        isAzureADv2PowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = ExpressionConverter.ConvertO(__workflow_isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID);
                        isAzureADv2PowerShellRunspaceOpenpropCount++;
                    }

                    isAzureADv2PowerShellRunspaceOpenpropCount++;
                }
                else
                {
                    isAzureADv2PowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = false;
                    isAzureADv2PowerShellRunspaceOpenpropCount++;
                }

                isAzureADv2PowerShellRunspaceOpenpropCount++;
                isAzureADv2PowerShellRunspaceOpen["Workflow"] = ExpressionConverter.ConvertO(__workflow_isAzureADv2PowerShellRunspaceOpenworkflow);
                if (isAzureADv2PowerShellRunspaceOpenpropCount > 0)
                {
                    callPayload.Body = isAzureADv2PowerShellRunspaceOpen;
                }

                return new ApiConnectionAction<IsAzureADv2PowerShellRunspaceOpenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunAzureADv2PowerShellAutomationScriptResponse, ApiConnectionActionConfiguration> RunAzureADv2PowerShellAutomationScript(Expression<Func<string>> runAzureADv2PowerShellAutomationScriptworkflow, Expression<Func<string>> runAzureADv2PowerShellAutomationScriptpowerShellScriptContents = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptisNoResultAnError = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptreturnComplexTypes = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptreturnDateAsDate = null, Expression<Func<string>> runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptrunScriptAsThread = null, Expression<Func<int>> runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId = null, Expression<Func<int>> runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptlogVerboseOutput = null, Expression<Func<string>> runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON = null, Expression<Func<string>> runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON = null, Expression<Func<runAzureADv2PowerShellAutomationScriptpowerShellCommandParametersInputItem[]>> runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            var __workflow_runAzureADv2PowerShellAutomationScriptworkflow = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptworkflow, nameof(runAzureADv2PowerShellAutomationScriptworkflow), required: true);
            var __workflow_runAzureADv2PowerShellAutomationScriptpowerShellScriptContents = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptpowerShellScriptContents, nameof(runAzureADv2PowerShellAutomationScriptpowerShellScriptContents), required: false);
            var __workflow_runAzureADv2PowerShellAutomationScriptisNoResultAnError = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptisNoResultAnError, nameof(runAzureADv2PowerShellAutomationScriptisNoResultAnError), required: false);
            var __workflow_runAzureADv2PowerShellAutomationScriptreturnComplexTypes = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptreturnComplexTypes, nameof(runAzureADv2PowerShellAutomationScriptreturnComplexTypes), required: false);
            var __workflow_runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean, nameof(runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean), required: false);
            var __workflow_runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal, nameof(runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal), required: false);
            var __workflow_runAzureADv2PowerShellAutomationScriptreturnDateAsDate = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptreturnDateAsDate, nameof(runAzureADv2PowerShellAutomationScriptreturnDateAsDate), required: false);
            var __workflow_runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON, nameof(runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON), required: false);
            var __workflow_runAzureADv2PowerShellAutomationScriptrunScriptAsThread = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptrunScriptAsThread, nameof(runAzureADv2PowerShellAutomationScriptrunScriptAsThread), required: false);
            var __workflow_runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId, nameof(runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId), required: false);
            var __workflow_runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread, nameof(runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread), required: false);
            var __workflow_runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword, nameof(runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword), required: false);
            var __workflow_runAzureADv2PowerShellAutomationScriptlogVerboseOutput = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptlogVerboseOutput, nameof(runAzureADv2PowerShellAutomationScriptlogVerboseOutput), required: false);
            var __workflow_runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON, nameof(runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON), required: false);
            var __workflow_runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON, nameof(runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON), required: false);
            var __workflow_runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters, nameof(runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters), required: false);
            return new DeferredBodyAction<RunAzureADv2PowerShellAutomationScriptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/RunAzureADv2PowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runAzureADv2PowerShellAutomationScript = new JObject();
                var runAzureADv2PowerShellAutomationScriptpropCount = 0;
                if (__workflow_runAzureADv2PowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runAzureADv2PowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptpowerShellScriptContents);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runAzureADv2PowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (__workflow_runAzureADv2PowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runAzureADv2PowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptisNoResultAnError);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["IsNoResultAnError"] = false;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runAzureADv2PowerShellAutomationScriptreturnComplexTypes != null)
                {
                    if (__workflow_runAzureADv2PowerShellAutomationScriptreturnComplexTypes != null)
                    {
                        runAzureADv2PowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptreturnComplexTypes);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["ReturnComplexTypes"] = false;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean != null)
                {
                    if (__workflow_runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean != null)
                    {
                        runAzureADv2PowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["ReturnBooleanAsBoolean"] = false;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal != null)
                {
                    if (__workflow_runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal != null)
                    {
                        runAzureADv2PowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["ReturnNumericAsDecimal"] = false;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runAzureADv2PowerShellAutomationScriptreturnDateAsDate != null)
                {
                    if (__workflow_runAzureADv2PowerShellAutomationScriptreturnDateAsDate != null)
                    {
                        runAzureADv2PowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptreturnDateAsDate);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["ReturnDateAsDate"] = false;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON != null)
                {
                    runAzureADv2PowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runAzureADv2PowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (__workflow_runAzureADv2PowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runAzureADv2PowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptrunScriptAsThread);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["RunScriptAsThread"] = false;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId != null)
                {
                    runAzureADv2PowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (__workflow_runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runAzureADv2PowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["SecondsToWaitForThread"] = 90;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword != null)
                {
                    if (__workflow_runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword != null)
                    {
                        runAzureADv2PowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["ScriptContainsStoredPassword"] = true;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runAzureADv2PowerShellAutomationScriptlogVerboseOutput != null)
                {
                    if (__workflow_runAzureADv2PowerShellAutomationScriptlogVerboseOutput != null)
                    {
                        runAzureADv2PowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptlogVerboseOutput);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["LogVerboseOutput"] = false;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON != null)
                {
                    runAzureADv2PowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runAzureADv2PowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runAzureADv2PowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                runAzureADv2PowerShellAutomationScriptpropCount++;
                runAzureADv2PowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScriptworkflow);
                if (runAzureADv2PowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runAzureADv2PowerShellAutomationScript;
                }

                return new ApiConnectionAction<RunAzureADv2PowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseAzureADv2PowerShellRunspaceResponse, ApiConnectionActionConfiguration> CloseAzureADv2PowerShellRunspace(Expression<Func<string>> closeAzureADv2PowerShellRunspaceworkflow)
        {
            var __workflow_closeAzureADv2PowerShellRunspaceworkflow = WorkflowExpression.Compile(closeAzureADv2PowerShellRunspaceworkflow, nameof(closeAzureADv2PowerShellRunspaceworkflow), required: true);
            return new DeferredBodyAction<CloseAzureADv2PowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/CloseAzureADv2PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var closeAzureADv2PowerShellRunspace = new JObject();
                var closeAzureADv2PowerShellRunspacepropCount = 0;
                closeAzureADv2PowerShellRunspacepropCount++;
                closeAzureADv2PowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(__workflow_closeAzureADv2PowerShellRunspaceworkflow);
                if (closeAzureADv2PowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = closeAzureADv2PowerShellRunspace;
                }

                return new ApiConnectionAction<CloseAzureADv2PowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUsersResponse, ApiConnectionActionConfiguration> AzureADv2GetAzureADUsers(Expression<Func<string>> azureADv2GetAzureADUsersworkflow, Expression<Func<string>> azureADv2GetAzureADUsersobjectId = null, Expression<Func<string>> azureADv2GetAzureADUsersfilterPropertyName = null, Expression<Func<azureADv2GetAzureADUsersfilterPropertyComparisonInput>> azureADv2GetAzureADUsersfilterPropertyComparison = null, Expression<Func<string>> azureADv2GetAzureADUsersfilterPropertyValue = null, Expression<Func<bool>> azureADv2GetAzureADUsersnoResultIsAnException = null, Expression<Func<string>> azureADv2GetAzureADUserspropertiesToReturn = null)
        {
            var __workflow_azureADv2GetAzureADUsersworkflow = WorkflowExpression.Compile(azureADv2GetAzureADUsersworkflow, nameof(azureADv2GetAzureADUsersworkflow), required: true);
            var __workflow_azureADv2GetAzureADUsersobjectId = WorkflowExpression.Compile(azureADv2GetAzureADUsersobjectId, nameof(azureADv2GetAzureADUsersobjectId), required: false);
            var __workflow_azureADv2GetAzureADUsersfilterPropertyName = WorkflowExpression.Compile(azureADv2GetAzureADUsersfilterPropertyName, nameof(azureADv2GetAzureADUsersfilterPropertyName), required: false);
            var __workflow_azureADv2GetAzureADUsersfilterPropertyComparison = WorkflowExpression.Compile(azureADv2GetAzureADUsersfilterPropertyComparison, nameof(azureADv2GetAzureADUsersfilterPropertyComparison), required: false);
            var __workflow_azureADv2GetAzureADUsersfilterPropertyValue = WorkflowExpression.Compile(azureADv2GetAzureADUsersfilterPropertyValue, nameof(azureADv2GetAzureADUsersfilterPropertyValue), required: false);
            var __workflow_azureADv2GetAzureADUsersnoResultIsAnException = WorkflowExpression.Compile(azureADv2GetAzureADUsersnoResultIsAnException, nameof(azureADv2GetAzureADUsersnoResultIsAnException), required: false);
            var __workflow_azureADv2GetAzureADUserspropertiesToReturn = WorkflowExpression.Compile(azureADv2GetAzureADUserspropertiesToReturn, nameof(azureADv2GetAzureADUserspropertiesToReturn), required: false);
            return new DeferredBodyAction<AzureADv2GetAzureADUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUsers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUsers = new JObject();
                var azureADv2GetAzureADUserspropCount = 0;
                if (__workflow_azureADv2GetAzureADUsersobjectId != null)
                {
                    azureADv2GetAzureADUsers["ObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUsersobjectId);
                    azureADv2GetAzureADUserspropCount++;
                }

                if (__workflow_azureADv2GetAzureADUsersfilterPropertyName != null)
                {
                    azureADv2GetAzureADUsers["FilterPropertyName"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUsersfilterPropertyName);
                    azureADv2GetAzureADUserspropCount++;
                }

                if (__workflow_azureADv2GetAzureADUsersfilterPropertyComparison != null)
                {
                    if (__workflow_azureADv2GetAzureADUsersfilterPropertyComparison != null)
                    {
                        azureADv2GetAzureADUsers["FilterPropertyComparison"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUsersfilterPropertyComparison);
                        azureADv2GetAzureADUserspropCount++;
                    }

                    azureADv2GetAzureADUserspropCount++;
                }
                else
                {
                    azureADv2GetAzureADUsers["FilterPropertyComparison"] = "Equals";
                    azureADv2GetAzureADUserspropCount++;
                }

                if (__workflow_azureADv2GetAzureADUsersfilterPropertyValue != null)
                {
                    azureADv2GetAzureADUsers["FilterPropertyValue"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUsersfilterPropertyValue);
                    azureADv2GetAzureADUserspropCount++;
                }

                if (__workflow_azureADv2GetAzureADUsersnoResultIsAnException != null)
                {
                    if (__workflow_azureADv2GetAzureADUsersnoResultIsAnException != null)
                    {
                        azureADv2GetAzureADUsers["NoResultIsAnException"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUsersnoResultIsAnException);
                        azureADv2GetAzureADUserspropCount++;
                    }

                    azureADv2GetAzureADUserspropCount++;
                }
                else
                {
                    azureADv2GetAzureADUsers["NoResultIsAnException"] = false;
                    azureADv2GetAzureADUserspropCount++;
                }

                if (__workflow_azureADv2GetAzureADUserspropertiesToReturn != null)
                {
                    azureADv2GetAzureADUsers["PropertiesToReturn"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserspropertiesToReturn);
                    azureADv2GetAzureADUserspropCount++;
                }

                azureADv2GetAzureADUserspropCount++;
                azureADv2GetAzureADUsers["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUsersworkflow);
                if (azureADv2GetAzureADUserspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUsers;
                }

                return new ApiConnectionAction<AzureADv2GetAzureADUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddAzureADUserResponse, ApiConnectionActionConfiguration> AzureADv2AddAzureADUser(Expression<Func<string>> azureADv2AddAzureADUseruserPrincipalName, Expression<Func<bool>> azureADv2AddAzureADUseraccountEnabled, Expression<Func<string>> azureADv2AddAzureADUseraccountPassword, Expression<Func<string>> azureADv2AddAzureADUserdisplayName, Expression<Func<string>> azureADv2AddAzureADUsermailNickName, Expression<Func<string>> azureADv2AddAzureADUserworkflow, Expression<Func<bool>> azureADv2AddAzureADUseraccountPasswordIsStoredPassword = null, Expression<Func<string>> azureADv2AddAzureADUserfirstName = null, Expression<Func<string>> azureADv2AddAzureADUserlastName = null, Expression<Func<string>> azureADv2AddAzureADUsercity = null, Expression<Func<string>> azureADv2AddAzureADUsercompanyName = null, Expression<Func<string>> azureADv2AddAzureADUsercountry = null, Expression<Func<string>> azureADv2AddAzureADUserdepartment = null, Expression<Func<string>> azureADv2AddAzureADUserfaxNumber = null, Expression<Func<string>> azureADv2AddAzureADUserjobTitle = null, Expression<Func<string>> azureADv2AddAzureADUsermobilePhone = null, Expression<Func<string>> azureADv2AddAzureADUseroffice = null, Expression<Func<string>> azureADv2AddAzureADUserphoneNumber = null, Expression<Func<string>> azureADv2AddAzureADUserpostalCode = null, Expression<Func<string>> azureADv2AddAzureADUserpreferredLanguage = null, Expression<Func<string>> azureADv2AddAzureADUserstate = null, Expression<Func<string>> azureADv2AddAzureADUserstreetAddress = null, Expression<Func<string>> azureADv2AddAzureADUserusageLocation = null, Expression<Func<azureADv2AddAzureADUserageGroupInput>> azureADv2AddAzureADUserageGroup = null, Expression<Func<azureADv2AddAzureADUserconsentProvidedForMinorInput>> azureADv2AddAzureADUserconsentProvidedForMinor = null, Expression<Func<string>> azureADv2AddAzureADUseremployeeId = null, Expression<Func<bool>> azureADv2AddAzureADUserforceChangePasswordNextLogin = null, Expression<Func<bool>> azureADv2AddAzureADUserenforceChangePasswordPolicy = null, Expression<Func<bool>> azureADv2AddAzureADUserpasswordNeverExpires = null)
        {
            var __workflow_azureADv2AddAzureADUseruserPrincipalName = WorkflowExpression.Compile(azureADv2AddAzureADUseruserPrincipalName, nameof(azureADv2AddAzureADUseruserPrincipalName), required: true);
            var __workflow_azureADv2AddAzureADUseraccountEnabled = WorkflowExpression.Compile(azureADv2AddAzureADUseraccountEnabled, nameof(azureADv2AddAzureADUseraccountEnabled), required: true);
            var __workflow_azureADv2AddAzureADUseraccountPassword = WorkflowExpression.Compile(azureADv2AddAzureADUseraccountPassword, nameof(azureADv2AddAzureADUseraccountPassword), required: true);
            var __workflow_azureADv2AddAzureADUserdisplayName = WorkflowExpression.Compile(azureADv2AddAzureADUserdisplayName, nameof(azureADv2AddAzureADUserdisplayName), required: true);
            var __workflow_azureADv2AddAzureADUsermailNickName = WorkflowExpression.Compile(azureADv2AddAzureADUsermailNickName, nameof(azureADv2AddAzureADUsermailNickName), required: true);
            var __workflow_azureADv2AddAzureADUserworkflow = WorkflowExpression.Compile(azureADv2AddAzureADUserworkflow, nameof(azureADv2AddAzureADUserworkflow), required: true);
            var __workflow_azureADv2AddAzureADUseraccountPasswordIsStoredPassword = WorkflowExpression.Compile(azureADv2AddAzureADUseraccountPasswordIsStoredPassword, nameof(azureADv2AddAzureADUseraccountPasswordIsStoredPassword), required: false);
            var __workflow_azureADv2AddAzureADUserfirstName = WorkflowExpression.Compile(azureADv2AddAzureADUserfirstName, nameof(azureADv2AddAzureADUserfirstName), required: false);
            var __workflow_azureADv2AddAzureADUserlastName = WorkflowExpression.Compile(azureADv2AddAzureADUserlastName, nameof(azureADv2AddAzureADUserlastName), required: false);
            var __workflow_azureADv2AddAzureADUsercity = WorkflowExpression.Compile(azureADv2AddAzureADUsercity, nameof(azureADv2AddAzureADUsercity), required: false);
            var __workflow_azureADv2AddAzureADUsercompanyName = WorkflowExpression.Compile(azureADv2AddAzureADUsercompanyName, nameof(azureADv2AddAzureADUsercompanyName), required: false);
            var __workflow_azureADv2AddAzureADUsercountry = WorkflowExpression.Compile(azureADv2AddAzureADUsercountry, nameof(azureADv2AddAzureADUsercountry), required: false);
            var __workflow_azureADv2AddAzureADUserdepartment = WorkflowExpression.Compile(azureADv2AddAzureADUserdepartment, nameof(azureADv2AddAzureADUserdepartment), required: false);
            var __workflow_azureADv2AddAzureADUserfaxNumber = WorkflowExpression.Compile(azureADv2AddAzureADUserfaxNumber, nameof(azureADv2AddAzureADUserfaxNumber), required: false);
            var __workflow_azureADv2AddAzureADUserjobTitle = WorkflowExpression.Compile(azureADv2AddAzureADUserjobTitle, nameof(azureADv2AddAzureADUserjobTitle), required: false);
            var __workflow_azureADv2AddAzureADUsermobilePhone = WorkflowExpression.Compile(azureADv2AddAzureADUsermobilePhone, nameof(azureADv2AddAzureADUsermobilePhone), required: false);
            var __workflow_azureADv2AddAzureADUseroffice = WorkflowExpression.Compile(azureADv2AddAzureADUseroffice, nameof(azureADv2AddAzureADUseroffice), required: false);
            var __workflow_azureADv2AddAzureADUserphoneNumber = WorkflowExpression.Compile(azureADv2AddAzureADUserphoneNumber, nameof(azureADv2AddAzureADUserphoneNumber), required: false);
            var __workflow_azureADv2AddAzureADUserpostalCode = WorkflowExpression.Compile(azureADv2AddAzureADUserpostalCode, nameof(azureADv2AddAzureADUserpostalCode), required: false);
            var __workflow_azureADv2AddAzureADUserpreferredLanguage = WorkflowExpression.Compile(azureADv2AddAzureADUserpreferredLanguage, nameof(azureADv2AddAzureADUserpreferredLanguage), required: false);
            var __workflow_azureADv2AddAzureADUserstate = WorkflowExpression.Compile(azureADv2AddAzureADUserstate, nameof(azureADv2AddAzureADUserstate), required: false);
            var __workflow_azureADv2AddAzureADUserstreetAddress = WorkflowExpression.Compile(azureADv2AddAzureADUserstreetAddress, nameof(azureADv2AddAzureADUserstreetAddress), required: false);
            var __workflow_azureADv2AddAzureADUserusageLocation = WorkflowExpression.Compile(azureADv2AddAzureADUserusageLocation, nameof(azureADv2AddAzureADUserusageLocation), required: false);
            var __workflow_azureADv2AddAzureADUserageGroup = WorkflowExpression.Compile(azureADv2AddAzureADUserageGroup, nameof(azureADv2AddAzureADUserageGroup), required: false);
            var __workflow_azureADv2AddAzureADUserconsentProvidedForMinor = WorkflowExpression.Compile(azureADv2AddAzureADUserconsentProvidedForMinor, nameof(azureADv2AddAzureADUserconsentProvidedForMinor), required: false);
            var __workflow_azureADv2AddAzureADUseremployeeId = WorkflowExpression.Compile(azureADv2AddAzureADUseremployeeId, nameof(azureADv2AddAzureADUseremployeeId), required: false);
            var __workflow_azureADv2AddAzureADUserforceChangePasswordNextLogin = WorkflowExpression.Compile(azureADv2AddAzureADUserforceChangePasswordNextLogin, nameof(azureADv2AddAzureADUserforceChangePasswordNextLogin), required: false);
            var __workflow_azureADv2AddAzureADUserenforceChangePasswordPolicy = WorkflowExpression.Compile(azureADv2AddAzureADUserenforceChangePasswordPolicy, nameof(azureADv2AddAzureADUserenforceChangePasswordPolicy), required: false);
            var __workflow_azureADv2AddAzureADUserpasswordNeverExpires = WorkflowExpression.Compile(azureADv2AddAzureADUserpasswordNeverExpires, nameof(azureADv2AddAzureADUserpasswordNeverExpires), required: false);
            return new DeferredBodyAction<AzureADv2AddAzureADUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddAzureADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AddAzureADUser = new JObject();
                var azureADv2AddAzureADUserpropCount = 0;
                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["UserPrincipalName"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUseruserPrincipalName);
                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["AccountEnabled"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUseraccountEnabled);
                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["AccountPassword"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUseraccountPassword);
                if (__workflow_azureADv2AddAzureADUseraccountPasswordIsStoredPassword != null)
                {
                    if (__workflow_azureADv2AddAzureADUseraccountPasswordIsStoredPassword != null)
                    {
                        azureADv2AddAzureADUser["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUseraccountPasswordIsStoredPassword);
                        azureADv2AddAzureADUserpropCount++;
                    }

                    azureADv2AddAzureADUserpropCount++;
                }
                else
                {
                    azureADv2AddAzureADUser["AccountPasswordIsStoredPassword"] = false;
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserfirstName != null)
                {
                    azureADv2AddAzureADUser["FirstName"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserfirstName);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserlastName != null)
                {
                    azureADv2AddAzureADUser["LastName"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserlastName);
                    azureADv2AddAzureADUserpropCount++;
                }

                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["DisplayName"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserdisplayName);
                if (__workflow_azureADv2AddAzureADUsercity != null)
                {
                    azureADv2AddAzureADUser["City"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUsercity);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUsercompanyName != null)
                {
                    azureADv2AddAzureADUser["CompanyName"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUsercompanyName);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUsercountry != null)
                {
                    azureADv2AddAzureADUser["Country"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUsercountry);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserdepartment != null)
                {
                    azureADv2AddAzureADUser["Department"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserdepartment);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserfaxNumber != null)
                {
                    azureADv2AddAzureADUser["FaxNumber"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserfaxNumber);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserjobTitle != null)
                {
                    azureADv2AddAzureADUser["JobTitle"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserjobTitle);
                    azureADv2AddAzureADUserpropCount++;
                }

                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["MailNickName"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUsermailNickName);
                if (__workflow_azureADv2AddAzureADUsermobilePhone != null)
                {
                    azureADv2AddAzureADUser["MobilePhone"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUsermobilePhone);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUseroffice != null)
                {
                    azureADv2AddAzureADUser["Office"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUseroffice);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserphoneNumber != null)
                {
                    azureADv2AddAzureADUser["PhoneNumber"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserphoneNumber);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserpostalCode != null)
                {
                    azureADv2AddAzureADUser["PostalCode"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserpostalCode);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserpreferredLanguage != null)
                {
                    azureADv2AddAzureADUser["PreferredLanguage"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserpreferredLanguage);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserstate != null)
                {
                    azureADv2AddAzureADUser["State"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserstate);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserstreetAddress != null)
                {
                    azureADv2AddAzureADUser["StreetAddress"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserstreetAddress);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserusageLocation != null)
                {
                    azureADv2AddAzureADUser["UsageLocation"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserusageLocation);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserageGroup != null)
                {
                    azureADv2AddAzureADUser["AgeGroup"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserageGroup);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserconsentProvidedForMinor != null)
                {
                    azureADv2AddAzureADUser["ConsentProvidedForMinor"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserconsentProvidedForMinor);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUseremployeeId != null)
                {
                    azureADv2AddAzureADUser["EmployeeId"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUseremployeeId);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserforceChangePasswordNextLogin != null)
                {
                    if (__workflow_azureADv2AddAzureADUserforceChangePasswordNextLogin != null)
                    {
                        azureADv2AddAzureADUser["ForceChangePasswordNextLogin"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserforceChangePasswordNextLogin);
                        azureADv2AddAzureADUserpropCount++;
                    }

                    azureADv2AddAzureADUserpropCount++;
                }
                else
                {
                    azureADv2AddAzureADUser["ForceChangePasswordNextLogin"] = true;
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserenforceChangePasswordPolicy != null)
                {
                    if (__workflow_azureADv2AddAzureADUserenforceChangePasswordPolicy != null)
                    {
                        azureADv2AddAzureADUser["EnforceChangePasswordPolicy"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserenforceChangePasswordPolicy);
                        azureADv2AddAzureADUserpropCount++;
                    }

                    azureADv2AddAzureADUserpropCount++;
                }
                else
                {
                    azureADv2AddAzureADUser["EnforceChangePasswordPolicy"] = false;
                    azureADv2AddAzureADUserpropCount++;
                }

                if (__workflow_azureADv2AddAzureADUserpasswordNeverExpires != null)
                {
                    if (__workflow_azureADv2AddAzureADUserpasswordNeverExpires != null)
                    {
                        azureADv2AddAzureADUser["PasswordNeverExpires"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserpasswordNeverExpires);
                        azureADv2AddAzureADUserpropCount++;
                    }

                    azureADv2AddAzureADUserpropCount++;
                }
                else
                {
                    azureADv2AddAzureADUser["PasswordNeverExpires"] = false;
                    azureADv2AddAzureADUserpropCount++;
                }

                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUserworkflow);
                if (azureADv2AddAzureADUserpropCount > 0)
                {
                    callPayload.Body = azureADv2AddAzureADUser;
                }

                return new ApiConnectionAction<AzureADv2AddAzureADUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveAzureADUserResponse, ApiConnectionActionConfiguration> AzureADv2RemoveAzureADUser(Expression<Func<string>> azureADv2RemoveAzureADUserobjectId, Expression<Func<string>> azureADv2RemoveAzureADUserworkflow, Expression<Func<bool>> azureADv2RemoveAzureADUsererrorIfUserDoesNotExist = null)
        {
            var __workflow_azureADv2RemoveAzureADUserobjectId = WorkflowExpression.Compile(azureADv2RemoveAzureADUserobjectId, nameof(azureADv2RemoveAzureADUserobjectId), required: true);
            var __workflow_azureADv2RemoveAzureADUserworkflow = WorkflowExpression.Compile(azureADv2RemoveAzureADUserworkflow, nameof(azureADv2RemoveAzureADUserworkflow), required: true);
            var __workflow_azureADv2RemoveAzureADUsererrorIfUserDoesNotExist = WorkflowExpression.Compile(azureADv2RemoveAzureADUsererrorIfUserDoesNotExist, nameof(azureADv2RemoveAzureADUsererrorIfUserDoesNotExist), required: false);
            return new DeferredBodyAction<AzureADv2RemoveAzureADUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveAzureADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveAzureADUser = new JObject();
                var azureADv2RemoveAzureADUserpropCount = 0;
                azureADv2RemoveAzureADUserpropCount++;
                azureADv2RemoveAzureADUser["ObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveAzureADUserobjectId);
                if (__workflow_azureADv2RemoveAzureADUsererrorIfUserDoesNotExist != null)
                {
                    if (__workflow_azureADv2RemoveAzureADUsererrorIfUserDoesNotExist != null)
                    {
                        azureADv2RemoveAzureADUser["ErrorIfUserDoesNotExist"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveAzureADUsererrorIfUserDoesNotExist);
                        azureADv2RemoveAzureADUserpropCount++;
                    }

                    azureADv2RemoveAzureADUserpropCount++;
                }
                else
                {
                    azureADv2RemoveAzureADUser["ErrorIfUserDoesNotExist"] = false;
                    azureADv2RemoveAzureADUserpropCount++;
                }

                azureADv2RemoveAzureADUserpropCount++;
                azureADv2RemoveAzureADUser["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveAzureADUserworkflow);
                if (azureADv2RemoveAzureADUserpropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveAzureADUser;
                }

                return new ApiConnectionAction<AzureADv2RemoveAzureADUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPasswordResponse, ApiConnectionActionConfiguration> AzureADv2ResetAzureADUserPassword(Expression<Func<string>> azureADv2ResetAzureADUserPassworduserPrincipalName, Expression<Func<string>> azureADv2ResetAzureADUserPasswordnewPassword, Expression<Func<string>> azureADv2ResetAzureADUserPasswordworkflow, Expression<Func<bool>> azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword = null, Expression<Func<bool>> azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin = null, Expression<Func<bool>> azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy = null)
        {
            var __workflow_azureADv2ResetAzureADUserPassworduserPrincipalName = WorkflowExpression.Compile(azureADv2ResetAzureADUserPassworduserPrincipalName, nameof(azureADv2ResetAzureADUserPassworduserPrincipalName), required: true);
            var __workflow_azureADv2ResetAzureADUserPasswordnewPassword = WorkflowExpression.Compile(azureADv2ResetAzureADUserPasswordnewPassword, nameof(azureADv2ResetAzureADUserPasswordnewPassword), required: true);
            var __workflow_azureADv2ResetAzureADUserPasswordworkflow = WorkflowExpression.Compile(azureADv2ResetAzureADUserPasswordworkflow, nameof(azureADv2ResetAzureADUserPasswordworkflow), required: true);
            var __workflow_azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword = WorkflowExpression.Compile(azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword, nameof(azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword), required: false);
            var __workflow_azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin = WorkflowExpression.Compile(azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin, nameof(azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin), required: false);
            var __workflow_azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy = WorkflowExpression.Compile(azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy, nameof(azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy), required: false);
            return new DeferredBodyAction<AzureADv2ResetAzureADUserPasswordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2ResetAzureADUserPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2ResetAzureADUserPassword = new JObject();
                var azureADv2ResetAzureADUserPasswordpropCount = 0;
                azureADv2ResetAzureADUserPasswordpropCount++;
                azureADv2ResetAzureADUserPassword["UserPrincipalName"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPassworduserPrincipalName);
                azureADv2ResetAzureADUserPasswordpropCount++;
                azureADv2ResetAzureADUserPassword["NewPassword"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPasswordnewPassword);
                if (__workflow_azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword != null)
                    {
                        azureADv2ResetAzureADUserPassword["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword);
                        azureADv2ResetAzureADUserPasswordpropCount++;
                    }

                    azureADv2ResetAzureADUserPasswordpropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserPassword["AccountPasswordIsStoredPassword"] = false;
                    azureADv2ResetAzureADUserPasswordpropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin != null)
                    {
                        azureADv2ResetAzureADUserPassword["ForceChangePasswordNextLogin"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin);
                        azureADv2ResetAzureADUserPasswordpropCount++;
                    }

                    azureADv2ResetAzureADUserPasswordpropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserPassword["ForceChangePasswordNextLogin"] = true;
                    azureADv2ResetAzureADUserPasswordpropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy != null)
                    {
                        azureADv2ResetAzureADUserPassword["EnforceChangePasswordPolicy"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy);
                        azureADv2ResetAzureADUserPasswordpropCount++;
                    }

                    azureADv2ResetAzureADUserPasswordpropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserPassword["EnforceChangePasswordPolicy"] = false;
                    azureADv2ResetAzureADUserPasswordpropCount++;
                }

                azureADv2ResetAzureADUserPasswordpropCount++;
                azureADv2ResetAzureADUserPassword["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPasswordworkflow);
                if (azureADv2ResetAzureADUserPasswordpropCount > 0)
                {
                    callPayload.Body = azureADv2ResetAzureADUserPassword;
                }

                return new ApiConnectionAction<AzureADv2ResetAzureADUserPasswordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserGroupMembershipResponse, ApiConnectionActionConfiguration> AzureADv2GetAzureADUserGroupMembership(Expression<Func<string>> azureADv2GetAzureADUserGroupMembershipobjectId, Expression<Func<string>> azureADv2GetAzureADUserGroupMembershipworkflow, Expression<Func<string>> azureADv2GetAzureADUserGroupMembershippropertiesToReturn = null)
        {
            var __workflow_azureADv2GetAzureADUserGroupMembershipobjectId = WorkflowExpression.Compile(azureADv2GetAzureADUserGroupMembershipobjectId, nameof(azureADv2GetAzureADUserGroupMembershipobjectId), required: true);
            var __workflow_azureADv2GetAzureADUserGroupMembershipworkflow = WorkflowExpression.Compile(azureADv2GetAzureADUserGroupMembershipworkflow, nameof(azureADv2GetAzureADUserGroupMembershipworkflow), required: true);
            var __workflow_azureADv2GetAzureADUserGroupMembershippropertiesToReturn = WorkflowExpression.Compile(azureADv2GetAzureADUserGroupMembershippropertiesToReturn, nameof(azureADv2GetAzureADUserGroupMembershippropertiesToReturn), required: false);
            return new DeferredBodyAction<AzureADv2GetAzureADUserGroupMembershipResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUserGroupMembership = new JObject();
                var azureADv2GetAzureADUserGroupMembershippropCount = 0;
                azureADv2GetAzureADUserGroupMembershippropCount++;
                azureADv2GetAzureADUserGroupMembership["ObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserGroupMembershipobjectId);
                if (__workflow_azureADv2GetAzureADUserGroupMembershippropertiesToReturn != null)
                {
                    azureADv2GetAzureADUserGroupMembership["PropertiesToReturn"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserGroupMembershippropertiesToReturn);
                    azureADv2GetAzureADUserGroupMembershippropCount++;
                }

                azureADv2GetAzureADUserGroupMembershippropCount++;
                azureADv2GetAzureADUserGroupMembership["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserGroupMembershipworkflow);
                if (azureADv2GetAzureADUserGroupMembershippropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUserGroupMembership;
                }

                return new ApiConnectionAction<AzureADv2GetAzureADUserGroupMembershipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2IsUserInAzureADUserGroupResponse, ApiConnectionActionConfiguration> AzureADv2IsUserInAzureADUserGroup(Expression<Func<string>> azureADv2IsUserInAzureADUserGroupobjectId, Expression<Func<string>> azureADv2IsUserInAzureADUserGroupgroupObjectId, Expression<Func<string>> azureADv2IsUserInAzureADUserGroupworkflow)
        {
            var __workflow_azureADv2IsUserInAzureADUserGroupobjectId = WorkflowExpression.Compile(azureADv2IsUserInAzureADUserGroupobjectId, nameof(azureADv2IsUserInAzureADUserGroupobjectId), required: true);
            var __workflow_azureADv2IsUserInAzureADUserGroupgroupObjectId = WorkflowExpression.Compile(azureADv2IsUserInAzureADUserGroupgroupObjectId, nameof(azureADv2IsUserInAzureADUserGroupgroupObjectId), required: true);
            var __workflow_azureADv2IsUserInAzureADUserGroupworkflow = WorkflowExpression.Compile(azureADv2IsUserInAzureADUserGroupworkflow, nameof(azureADv2IsUserInAzureADUserGroupworkflow), required: true);
            return new DeferredBodyAction<AzureADv2IsUserInAzureADUserGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2IsUserInAzureADUserGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2IsUserInAzureADUserGroup = new JObject();
                var azureADv2IsUserInAzureADUserGrouppropCount = 0;
                azureADv2IsUserInAzureADUserGrouppropCount++;
                azureADv2IsUserInAzureADUserGroup["ObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2IsUserInAzureADUserGroupobjectId);
                azureADv2IsUserInAzureADUserGrouppropCount++;
                azureADv2IsUserInAzureADUserGroup["GroupObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2IsUserInAzureADUserGroupgroupObjectId);
                azureADv2IsUserInAzureADUserGrouppropCount++;
                azureADv2IsUserInAzureADUserGroup["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2IsUserInAzureADUserGroupworkflow);
                if (azureADv2IsUserInAzureADUserGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2IsUserInAzureADUserGroup;
                }

                return new ApiConnectionAction<AzureADv2IsUserInAzureADUserGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddUserToGroupResponse, ApiConnectionActionConfiguration> AzureADv2AddUserToGroup(Expression<Func<string>> azureADv2AddUserToGroupuserObjectId, Expression<Func<string>> azureADv2AddUserToGroupgroupObjectId, Expression<Func<string>> azureADv2AddUserToGroupworkflow, Expression<Func<bool>> azureADv2AddUserToGroupcheckUserGroupMembershipsFirst = null)
        {
            var __workflow_azureADv2AddUserToGroupuserObjectId = WorkflowExpression.Compile(azureADv2AddUserToGroupuserObjectId, nameof(azureADv2AddUserToGroupuserObjectId), required: true);
            var __workflow_azureADv2AddUserToGroupgroupObjectId = WorkflowExpression.Compile(azureADv2AddUserToGroupgroupObjectId, nameof(azureADv2AddUserToGroupgroupObjectId), required: true);
            var __workflow_azureADv2AddUserToGroupworkflow = WorkflowExpression.Compile(azureADv2AddUserToGroupworkflow, nameof(azureADv2AddUserToGroupworkflow), required: true);
            var __workflow_azureADv2AddUserToGroupcheckUserGroupMembershipsFirst = WorkflowExpression.Compile(azureADv2AddUserToGroupcheckUserGroupMembershipsFirst, nameof(azureADv2AddUserToGroupcheckUserGroupMembershipsFirst), required: false);
            return new DeferredBodyAction<AzureADv2AddUserToGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddUserToGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AddUserToGroup = new JObject();
                var azureADv2AddUserToGrouppropCount = 0;
                azureADv2AddUserToGrouppropCount++;
                azureADv2AddUserToGroup["UserObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddUserToGroupuserObjectId);
                azureADv2AddUserToGrouppropCount++;
                azureADv2AddUserToGroup["GroupObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddUserToGroupgroupObjectId);
                if (__workflow_azureADv2AddUserToGroupcheckUserGroupMembershipsFirst != null)
                {
                    if (__workflow_azureADv2AddUserToGroupcheckUserGroupMembershipsFirst != null)
                    {
                        azureADv2AddUserToGroup["CheckUserGroupMembershipsFirst"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddUserToGroupcheckUserGroupMembershipsFirst);
                        azureADv2AddUserToGrouppropCount++;
                    }

                    azureADv2AddUserToGrouppropCount++;
                }
                else
                {
                    azureADv2AddUserToGroup["CheckUserGroupMembershipsFirst"] = true;
                    azureADv2AddUserToGrouppropCount++;
                }

                azureADv2AddUserToGrouppropCount++;
                azureADv2AddUserToGroup["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddUserToGroupworkflow);
                if (azureADv2AddUserToGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2AddUserToGroup;
                }

                return new ApiConnectionAction<AzureADv2AddUserToGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromGroupResponse, ApiConnectionActionConfiguration> AzureADv2RemoveUserFromGroup(Expression<Func<string>> azureADv2RemoveUserFromGroupuserObjectId, Expression<Func<string>> azureADv2RemoveUserFromGroupgroupObjectId, Expression<Func<string>> azureADv2RemoveUserFromGroupworkflow, Expression<Func<bool>> azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst = null)
        {
            var __workflow_azureADv2RemoveUserFromGroupuserObjectId = WorkflowExpression.Compile(azureADv2RemoveUserFromGroupuserObjectId, nameof(azureADv2RemoveUserFromGroupuserObjectId), required: true);
            var __workflow_azureADv2RemoveUserFromGroupgroupObjectId = WorkflowExpression.Compile(azureADv2RemoveUserFromGroupgroupObjectId, nameof(azureADv2RemoveUserFromGroupgroupObjectId), required: true);
            var __workflow_azureADv2RemoveUserFromGroupworkflow = WorkflowExpression.Compile(azureADv2RemoveUserFromGroupworkflow, nameof(azureADv2RemoveUserFromGroupworkflow), required: true);
            var __workflow_azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst = WorkflowExpression.Compile(azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst, nameof(azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst), required: false);
            return new DeferredBodyAction<AzureADv2RemoveUserFromGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromGroup = new JObject();
                var azureADv2RemoveUserFromGrouppropCount = 0;
                azureADv2RemoveUserFromGrouppropCount++;
                azureADv2RemoveUserFromGroup["UserObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromGroupuserObjectId);
                azureADv2RemoveUserFromGrouppropCount++;
                azureADv2RemoveUserFromGroup["GroupObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromGroupgroupObjectId);
                if (__workflow_azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst != null)
                {
                    if (__workflow_azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst != null)
                    {
                        azureADv2RemoveUserFromGroup["CheckUserGroupMembershipsFirst"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst);
                        azureADv2RemoveUserFromGrouppropCount++;
                    }

                    azureADv2RemoveUserFromGrouppropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromGroup["CheckUserGroupMembershipsFirst"] = true;
                    azureADv2RemoveUserFromGrouppropCount++;
                }

                azureADv2RemoveUserFromGrouppropCount++;
                azureADv2RemoveUserFromGroup["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromGroupworkflow);
                if (azureADv2RemoveUserFromGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromGroup;
                }

                return new ApiConnectionAction<AzureADv2RemoveUserFromGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddADUserToMultipleADGroupsResponse, ApiConnectionActionConfiguration> AzureADv2AddADUserToMultipleADGroups(Expression<Func<string>> azureADv2AddADUserToMultipleADGroupsuserObjectId, Expression<Func<string>> azureADv2AddADUserToMultipleADGroupsworkflow, Expression<Func<string>> azureADv2AddADUserToMultipleADGroupsgroupNamesJSON = null, Expression<Func<bool>> azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd = null, Expression<Func<bool>> azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd = null, Expression<Func<bool>> azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst = null, Expression<Func<int>> azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall = null)
        {
            var __workflow_azureADv2AddADUserToMultipleADGroupsuserObjectId = WorkflowExpression.Compile(azureADv2AddADUserToMultipleADGroupsuserObjectId, nameof(azureADv2AddADUserToMultipleADGroupsuserObjectId), required: true);
            var __workflow_azureADv2AddADUserToMultipleADGroupsworkflow = WorkflowExpression.Compile(azureADv2AddADUserToMultipleADGroupsworkflow, nameof(azureADv2AddADUserToMultipleADGroupsworkflow), required: true);
            var __workflow_azureADv2AddADUserToMultipleADGroupsgroupNamesJSON = WorkflowExpression.Compile(azureADv2AddADUserToMultipleADGroupsgroupNamesJSON, nameof(azureADv2AddADUserToMultipleADGroupsgroupNamesJSON), required: false);
            var __workflow_azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd = WorkflowExpression.Compile(azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd, nameof(azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd), required: false);
            var __workflow_azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd = WorkflowExpression.Compile(azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd, nameof(azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd), required: false);
            var __workflow_azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst = WorkflowExpression.Compile(azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst, nameof(azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst), required: false);
            var __workflow_azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall = WorkflowExpression.Compile(azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall, nameof(azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall), required: false);
            return new DeferredBodyAction<AzureADv2AddADUserToMultipleADGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddADUserToMultipleADGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AddADUserToMultipleADGroups = new JObject();
                var azureADv2AddADUserToMultipleADGroupspropCount = 0;
                azureADv2AddADUserToMultipleADGroupspropCount++;
                azureADv2AddADUserToMultipleADGroups["UserObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddADUserToMultipleADGroupsuserObjectId);
                if (__workflow_azureADv2AddADUserToMultipleADGroupsgroupNamesJSON != null)
                {
                    azureADv2AddADUserToMultipleADGroups["GroupNamesJSON"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddADUserToMultipleADGroupsgroupNamesJSON);
                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }

                if (__workflow_azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd != null)
                {
                    if (__workflow_azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd != null)
                    {
                        azureADv2AddADUserToMultipleADGroups["ExceptionIfAnyGroupsFailToAdd"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd);
                        azureADv2AddADUserToMultipleADGroupspropCount++;
                    }

                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }
                else
                {
                    azureADv2AddADUserToMultipleADGroups["ExceptionIfAnyGroupsFailToAdd"] = false;
                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }

                if (__workflow_azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd != null)
                {
                    if (__workflow_azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd != null)
                    {
                        azureADv2AddADUserToMultipleADGroups["ExceptionIfAllGroupsFailToAdd"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd);
                        azureADv2AddADUserToMultipleADGroupspropCount++;
                    }

                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }
                else
                {
                    azureADv2AddADUserToMultipleADGroups["ExceptionIfAllGroupsFailToAdd"] = false;
                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }

                if (__workflow_azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst != null)
                {
                    if (__workflow_azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst != null)
                    {
                        azureADv2AddADUserToMultipleADGroups["CheckUserGroupMembershipsFirst"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst);
                        azureADv2AddADUserToMultipleADGroupspropCount++;
                    }

                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }
                else
                {
                    azureADv2AddADUserToMultipleADGroups["CheckUserGroupMembershipsFirst"] = true;
                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }

                if (__workflow_azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall != null)
                {
                    azureADv2AddADUserToMultipleADGroups["MaxAzureADGroupsPerCall"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall);
                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }

                azureADv2AddADUserToMultipleADGroupspropCount++;
                azureADv2AddADUserToMultipleADGroups["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2AddADUserToMultipleADGroupsworkflow);
                if (azureADv2AddADUserToMultipleADGroupspropCount > 0)
                {
                    callPayload.Body = azureADv2AddADUserToMultipleADGroups;
                }

                return new ApiConnectionAction<AzureADv2AddADUserToMultipleADGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse, ApiConnectionActionConfiguration> AzureADv2RemoveADUserFromMultipleADGroups(Expression<Func<string>> azureADv2RemoveADUserFromMultipleADGroupsuserObjectId, Expression<Func<string>> azureADv2RemoveADUserFromMultipleADGroupsworkflow, Expression<Func<string>> azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON = null, Expression<Func<bool>> azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove = null, Expression<Func<bool>> azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove = null, Expression<Func<bool>> azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst = null, Expression<Func<int>> azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall = null)
        {
            var __workflow_azureADv2RemoveADUserFromMultipleADGroupsuserObjectId = WorkflowExpression.Compile(azureADv2RemoveADUserFromMultipleADGroupsuserObjectId, nameof(azureADv2RemoveADUserFromMultipleADGroupsuserObjectId), required: true);
            var __workflow_azureADv2RemoveADUserFromMultipleADGroupsworkflow = WorkflowExpression.Compile(azureADv2RemoveADUserFromMultipleADGroupsworkflow, nameof(azureADv2RemoveADUserFromMultipleADGroupsworkflow), required: true);
            var __workflow_azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON = WorkflowExpression.Compile(azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON, nameof(azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON), required: false);
            var __workflow_azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove = WorkflowExpression.Compile(azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove, nameof(azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove), required: false);
            var __workflow_azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove = WorkflowExpression.Compile(azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove, nameof(azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove), required: false);
            var __workflow_azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst = WorkflowExpression.Compile(azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst, nameof(azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst), required: false);
            var __workflow_azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall = WorkflowExpression.Compile(azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall, nameof(azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall), required: false);
            return new DeferredBodyAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveADUserFromMultipleADGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveADUserFromMultipleADGroups = new JObject();
                var azureADv2RemoveADUserFromMultipleADGroupspropCount = 0;
                azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                azureADv2RemoveADUserFromMultipleADGroups["UserObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveADUserFromMultipleADGroupsuserObjectId);
                if (__workflow_azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON != null)
                {
                    azureADv2RemoveADUserFromMultipleADGroups["GroupNamesJSON"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON);
                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }

                if (__workflow_azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove != null)
                {
                    if (__workflow_azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove != null)
                    {
                        azureADv2RemoveADUserFromMultipleADGroups["ExceptionIfAnyGroupsFailToRemove"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove);
                        azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                    }

                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }
                else
                {
                    azureADv2RemoveADUserFromMultipleADGroups["ExceptionIfAnyGroupsFailToRemove"] = false;
                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }

                if (__workflow_azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove != null)
                {
                    if (__workflow_azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove != null)
                    {
                        azureADv2RemoveADUserFromMultipleADGroups["ExceptionIfAllGroupsFailToRemove"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove);
                        azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                    }

                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }
                else
                {
                    azureADv2RemoveADUserFromMultipleADGroups["ExceptionIfAllGroupsFailToRemove"] = false;
                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }

                if (__workflow_azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst != null)
                {
                    if (__workflow_azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst != null)
                    {
                        azureADv2RemoveADUserFromMultipleADGroups["CheckUserGroupMembershipsFirst"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst);
                        azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                    }

                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }
                else
                {
                    azureADv2RemoveADUserFromMultipleADGroups["CheckUserGroupMembershipsFirst"] = true;
                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }

                if (__workflow_azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall != null)
                {
                    azureADv2RemoveADUserFromMultipleADGroups["MaxAzureADGroupsPerCall"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall);
                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }

                azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                azureADv2RemoveADUserFromMultipleADGroups["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveADUserFromMultipleADGroupsworkflow);
                if (azureADv2RemoveADUserFromMultipleADGroupspropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveADUserFromMultipleADGroups;
                }

                return new ApiConnectionAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllGroupsResponse, ApiConnectionActionConfiguration> AzureADv2RemoveUserFromAllGroups(Expression<Func<string>> azureADv2RemoveUserFromAllGroupsuserObjectId, Expression<Func<string>> azureADv2RemoveUserFromAllGroupsworkflow, Expression<Func<bool>> azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove = null, Expression<Func<bool>> azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove = null, Expression<Func<int>> azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall = null)
        {
            var __workflow_azureADv2RemoveUserFromAllGroupsuserObjectId = WorkflowExpression.Compile(azureADv2RemoveUserFromAllGroupsuserObjectId, nameof(azureADv2RemoveUserFromAllGroupsuserObjectId), required: true);
            var __workflow_azureADv2RemoveUserFromAllGroupsworkflow = WorkflowExpression.Compile(azureADv2RemoveUserFromAllGroupsworkflow, nameof(azureADv2RemoveUserFromAllGroupsworkflow), required: true);
            var __workflow_azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove = WorkflowExpression.Compile(azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove, nameof(azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove), required: false);
            var __workflow_azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove = WorkflowExpression.Compile(azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove, nameof(azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove), required: false);
            var __workflow_azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall = WorkflowExpression.Compile(azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall, nameof(azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall), required: false);
            return new DeferredBodyAction<AzureADv2RemoveUserFromAllGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromAllGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromAllGroups = new JObject();
                var azureADv2RemoveUserFromAllGroupspropCount = 0;
                azureADv2RemoveUserFromAllGroupspropCount++;
                azureADv2RemoveUserFromAllGroups["UserObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromAllGroupsuserObjectId);
                if (__workflow_azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove != null)
                {
                    if (__workflow_azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove != null)
                    {
                        azureADv2RemoveUserFromAllGroups["ExceptionIfAnyGroupsFailToRemove"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove);
                        azureADv2RemoveUserFromAllGroupspropCount++;
                    }

                    azureADv2RemoveUserFromAllGroupspropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromAllGroups["ExceptionIfAnyGroupsFailToRemove"] = false;
                    azureADv2RemoveUserFromAllGroupspropCount++;
                }

                if (__workflow_azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove != null)
                {
                    if (__workflow_azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove != null)
                    {
                        azureADv2RemoveUserFromAllGroups["ExceptionIfAllGroupsFailToRemove"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove);
                        azureADv2RemoveUserFromAllGroupspropCount++;
                    }

                    azureADv2RemoveUserFromAllGroupspropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromAllGroups["ExceptionIfAllGroupsFailToRemove"] = false;
                    azureADv2RemoveUserFromAllGroupspropCount++;
                }

                if (__workflow_azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall != null)
                {
                    azureADv2RemoveUserFromAllGroups["MaxAzureADGroupsPerCall"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall);
                    azureADv2RemoveUserFromAllGroupspropCount++;
                }

                azureADv2RemoveUserFromAllGroupspropCount++;
                azureADv2RemoveUserFromAllGroups["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromAllGroupsworkflow);
                if (azureADv2RemoveUserFromAllGroupspropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromAllGroups;
                }

                return new ApiConnectionAction<AzureADv2RemoveUserFromAllGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADLicenseSKUsResponse, ApiConnectionActionConfiguration> AzureADv2GetAzureADLicenseSKUs(Expression<Func<string>> azureADv2GetAzureADLicenseSKUsworkflow, Expression<Func<azureADv2GetAzureADLicenseSKUsexpandPropertyInput>> azureADv2GetAzureADLicenseSKUsexpandProperty = null)
        {
            var __workflow_azureADv2GetAzureADLicenseSKUsworkflow = WorkflowExpression.Compile(azureADv2GetAzureADLicenseSKUsworkflow, nameof(azureADv2GetAzureADLicenseSKUsworkflow), required: true);
            var __workflow_azureADv2GetAzureADLicenseSKUsexpandProperty = WorkflowExpression.Compile(azureADv2GetAzureADLicenseSKUsexpandProperty, nameof(azureADv2GetAzureADLicenseSKUsexpandProperty), required: false);
            return new DeferredBodyAction<AzureADv2GetAzureADLicenseSKUsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADLicenseSKUs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADLicenseSKUs = new JObject();
                var azureADv2GetAzureADLicenseSKUspropCount = 0;
                if (__workflow_azureADv2GetAzureADLicenseSKUsexpandProperty != null)
                {
                    if (__workflow_azureADv2GetAzureADLicenseSKUsexpandProperty != null)
                    {
                        azureADv2GetAzureADLicenseSKUs["ExpandProperty"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADLicenseSKUsexpandProperty);
                        azureADv2GetAzureADLicenseSKUspropCount++;
                    }

                    azureADv2GetAzureADLicenseSKUspropCount++;
                }
                else
                {
                    azureADv2GetAzureADLicenseSKUs["ExpandProperty"] = "None";
                    azureADv2GetAzureADLicenseSKUspropCount++;
                }

                azureADv2GetAzureADLicenseSKUspropCount++;
                azureADv2GetAzureADLicenseSKUs["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADLicenseSKUsworkflow);
                if (azureADv2GetAzureADLicenseSKUspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADLicenseSKUs;
                }

                return new ApiConnectionAction<AzureADv2GetAzureADLicenseSKUsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserLicenseResponse, ApiConnectionActionConfiguration> AzureADv2SetAzureADUserLicense(Expression<Func<string>> azureADv2SetAzureADUserLicenseobjectId, Expression<Func<string>> azureADv2SetAzureADUserLicenseworkflow, Expression<Func<string>> azureADv2SetAzureADUserLicenselicenseToAdd = null, Expression<Func<azureADv2SetAzureADUserLicenselicensePlansChoiceInput>> azureADv2SetAzureADUserLicenselicensePlansChoice = null, Expression<Func<string>> azureADv2SetAzureADUserLicenselicensePlansCSV = null, Expression<Func<string>> azureADv2SetAzureADUserLicenselicensesToRemoveCSV = null, Expression<Func<string>> azureADv2SetAzureADUserLicenseusageLocation = null, Expression<Func<bool>> azureADv2SetAzureADUserLicenselocalScope = null)
        {
            var __workflow_azureADv2SetAzureADUserLicenseobjectId = WorkflowExpression.Compile(azureADv2SetAzureADUserLicenseobjectId, nameof(azureADv2SetAzureADUserLicenseobjectId), required: true);
            var __workflow_azureADv2SetAzureADUserLicenseworkflow = WorkflowExpression.Compile(azureADv2SetAzureADUserLicenseworkflow, nameof(azureADv2SetAzureADUserLicenseworkflow), required: true);
            var __workflow_azureADv2SetAzureADUserLicenselicenseToAdd = WorkflowExpression.Compile(azureADv2SetAzureADUserLicenselicenseToAdd, nameof(azureADv2SetAzureADUserLicenselicenseToAdd), required: false);
            var __workflow_azureADv2SetAzureADUserLicenselicensePlansChoice = WorkflowExpression.Compile(azureADv2SetAzureADUserLicenselicensePlansChoice, nameof(azureADv2SetAzureADUserLicenselicensePlansChoice), required: false);
            var __workflow_azureADv2SetAzureADUserLicenselicensePlansCSV = WorkflowExpression.Compile(azureADv2SetAzureADUserLicenselicensePlansCSV, nameof(azureADv2SetAzureADUserLicenselicensePlansCSV), required: false);
            var __workflow_azureADv2SetAzureADUserLicenselicensesToRemoveCSV = WorkflowExpression.Compile(azureADv2SetAzureADUserLicenselicensesToRemoveCSV, nameof(azureADv2SetAzureADUserLicenselicensesToRemoveCSV), required: false);
            var __workflow_azureADv2SetAzureADUserLicenseusageLocation = WorkflowExpression.Compile(azureADv2SetAzureADUserLicenseusageLocation, nameof(azureADv2SetAzureADUserLicenseusageLocation), required: false);
            var __workflow_azureADv2SetAzureADUserLicenselocalScope = WorkflowExpression.Compile(azureADv2SetAzureADUserLicenselocalScope, nameof(azureADv2SetAzureADUserLicenselocalScope), required: false);
            return new DeferredBodyAction<AzureADv2SetAzureADUserLicenseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUserLicense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2SetAzureADUserLicense = new JObject();
                var azureADv2SetAzureADUserLicensepropCount = 0;
                azureADv2SetAzureADUserLicensepropCount++;
                azureADv2SetAzureADUserLicense["ObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserLicenseobjectId);
                if (__workflow_azureADv2SetAzureADUserLicenselicenseToAdd != null)
                {
                    azureADv2SetAzureADUserLicense["LicenseToAdd"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserLicenselicenseToAdd);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserLicenselicensePlansChoice != null)
                {
                    if (__workflow_azureADv2SetAzureADUserLicenselicensePlansChoice != null)
                    {
                        azureADv2SetAzureADUserLicense["LicensePlansChoice"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserLicenselicensePlansChoice);
                        azureADv2SetAzureADUserLicensepropCount++;
                    }

                    azureADv2SetAzureADUserLicensepropCount++;
                }
                else
                {
                    azureADv2SetAzureADUserLicense["LicensePlansChoice"] = "All";
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserLicenselicensePlansCSV != null)
                {
                    azureADv2SetAzureADUserLicense["LicensePlansCSV"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserLicenselicensePlansCSV);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserLicenselicensesToRemoveCSV != null)
                {
                    azureADv2SetAzureADUserLicense["LicensesToRemoveCSV"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserLicenselicensesToRemoveCSV);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserLicenseusageLocation != null)
                {
                    azureADv2SetAzureADUserLicense["UsageLocation"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserLicenseusageLocation);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserLicenselocalScope != null)
                {
                    azureADv2SetAzureADUserLicense["LocalScope"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserLicenselocalScope);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                azureADv2SetAzureADUserLicensepropCount++;
                azureADv2SetAzureADUserLicense["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserLicenseworkflow);
                if (azureADv2SetAzureADUserLicensepropCount > 0)
                {
                    callPayload.Body = azureADv2SetAzureADUserLicense;
                }

                return new ApiConnectionAction<AzureADv2SetAzureADUserLicenseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicensesResponse, ApiConnectionActionConfiguration> AzureADv2GetAzureADUserLicenses(Expression<Func<string>> azureADv2GetAzureADUserLicensesobjectId, Expression<Func<string>> azureADv2GetAzureADUserLicensesworkflow)
        {
            var __workflow_azureADv2GetAzureADUserLicensesobjectId = WorkflowExpression.Compile(azureADv2GetAzureADUserLicensesobjectId, nameof(azureADv2GetAzureADUserLicensesobjectId), required: true);
            var __workflow_azureADv2GetAzureADUserLicensesworkflow = WorkflowExpression.Compile(azureADv2GetAzureADUserLicensesworkflow, nameof(azureADv2GetAzureADUserLicensesworkflow), required: true);
            return new DeferredBodyAction<AzureADv2GetAzureADUserLicensesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserLicenses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUserLicenses = new JObject();
                var azureADv2GetAzureADUserLicensespropCount = 0;
                azureADv2GetAzureADUserLicensespropCount++;
                azureADv2GetAzureADUserLicenses["ObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserLicensesobjectId);
                azureADv2GetAzureADUserLicensespropCount++;
                azureADv2GetAzureADUserLicenses["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserLicensesworkflow);
                if (azureADv2GetAzureADUserLicensespropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUserLicenses;
                }

                return new ApiConnectionAction<AzureADv2GetAzureADUserLicensesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicenseServicePlansResponse, ApiConnectionActionConfiguration> AzureADv2GetAzureADUserLicenseServicePlans(Expression<Func<string>> azureADv2GetAzureADUserLicenseServicePlansobjectId, Expression<Func<string>> azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber, Expression<Func<string>> azureADv2GetAzureADUserLicenseServicePlansworkflow)
        {
            var __workflow_azureADv2GetAzureADUserLicenseServicePlansobjectId = WorkflowExpression.Compile(azureADv2GetAzureADUserLicenseServicePlansobjectId, nameof(azureADv2GetAzureADUserLicenseServicePlansobjectId), required: true);
            var __workflow_azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber = WorkflowExpression.Compile(azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber, nameof(azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber), required: true);
            var __workflow_azureADv2GetAzureADUserLicenseServicePlansworkflow = WorkflowExpression.Compile(azureADv2GetAzureADUserLicenseServicePlansworkflow, nameof(azureADv2GetAzureADUserLicenseServicePlansworkflow), required: true);
            return new DeferredBodyAction<AzureADv2GetAzureADUserLicenseServicePlansResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserLicenseServicePlans";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUserLicenseServicePlans = new JObject();
                var azureADv2GetAzureADUserLicenseServicePlanspropCount = 0;
                azureADv2GetAzureADUserLicenseServicePlanspropCount++;
                azureADv2GetAzureADUserLicenseServicePlans["ObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserLicenseServicePlansobjectId);
                azureADv2GetAzureADUserLicenseServicePlanspropCount++;
                azureADv2GetAzureADUserLicenseServicePlans["LicenseSKUPartNumber"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber);
                azureADv2GetAzureADUserLicenseServicePlanspropCount++;
                azureADv2GetAzureADUserLicenseServicePlans["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserLicenseServicePlansworkflow);
                if (azureADv2GetAzureADUserLicenseServicePlanspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUserLicenseServicePlans;
                }

                return new ApiConnectionAction<AzureADv2GetAzureADUserLicenseServicePlansResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveAllAzureADUserLicenseResponse, ApiConnectionActionConfiguration> AzureADv2RemoveAllAzureADUserLicense(Expression<Func<string>> azureADv2RemoveAllAzureADUserLicenseobjectId, Expression<Func<string>> azureADv2RemoveAllAzureADUserLicenseworkflow)
        {
            var __workflow_azureADv2RemoveAllAzureADUserLicenseobjectId = WorkflowExpression.Compile(azureADv2RemoveAllAzureADUserLicenseobjectId, nameof(azureADv2RemoveAllAzureADUserLicenseobjectId), required: true);
            var __workflow_azureADv2RemoveAllAzureADUserLicenseworkflow = WorkflowExpression.Compile(azureADv2RemoveAllAzureADUserLicenseworkflow, nameof(azureADv2RemoveAllAzureADUserLicenseworkflow), required: true);
            return new DeferredBodyAction<AzureADv2RemoveAllAzureADUserLicenseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveAllAzureADUserLicense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveAllAzureADUserLicense = new JObject();
                var azureADv2RemoveAllAzureADUserLicensepropCount = 0;
                azureADv2RemoveAllAzureADUserLicensepropCount++;
                azureADv2RemoveAllAzureADUserLicense["ObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveAllAzureADUserLicenseobjectId);
                azureADv2RemoveAllAzureADUserLicensepropCount++;
                azureADv2RemoveAllAzureADUserLicense["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveAllAzureADUserLicenseworkflow);
                if (azureADv2RemoveAllAzureADUserLicensepropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveAllAzureADUserLicense;
                }

                return new ApiConnectionAction<AzureADv2RemoveAllAzureADUserLicenseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserResponse, ApiConnectionActionConfiguration> AzureADv2SetAzureADUser(Expression<Func<string>> azureADv2SetAzureADUserobjectId, Expression<Func<string>> azureADv2SetAzureADUserworkflow, Expression<Func<string>> azureADv2SetAzureADUserfirstName = null, Expression<Func<string>> azureADv2SetAzureADUserlastName = null, Expression<Func<string>> azureADv2SetAzureADUserdisplayName = null, Expression<Func<string>> azureADv2SetAzureADUsercity = null, Expression<Func<string>> azureADv2SetAzureADUsercompanyName = null, Expression<Func<string>> azureADv2SetAzureADUsercountry = null, Expression<Func<string>> azureADv2SetAzureADUserdepartment = null, Expression<Func<string>> azureADv2SetAzureADUserfaxNumber = null, Expression<Func<string>> azureADv2SetAzureADUserjobTitle = null, Expression<Func<string>> azureADv2SetAzureADUsermobilePhone = null, Expression<Func<string>> azureADv2SetAzureADUseroffice = null, Expression<Func<string>> azureADv2SetAzureADUserphoneNumber = null, Expression<Func<string>> azureADv2SetAzureADUserpostalCode = null, Expression<Func<string>> azureADv2SetAzureADUserpreferredLanguage = null, Expression<Func<string>> azureADv2SetAzureADUserstate = null, Expression<Func<string>> azureADv2SetAzureADUserstreetAddress = null, Expression<Func<string>> azureADv2SetAzureADUserusageLocation = null, Expression<Func<azureADv2SetAzureADUserageGroupInput>> azureADv2SetAzureADUserageGroup = null, Expression<Func<azureADv2SetAzureADUserconsentProvidedForMinorInput>> azureADv2SetAzureADUserconsentProvidedForMinor = null, Expression<Func<string>> azureADv2SetAzureADUsermailNickName = null, Expression<Func<string>> azureADv2SetAzureADUseremployeeId = null)
        {
            var __workflow_azureADv2SetAzureADUserobjectId = WorkflowExpression.Compile(azureADv2SetAzureADUserobjectId, nameof(azureADv2SetAzureADUserobjectId), required: true);
            var __workflow_azureADv2SetAzureADUserworkflow = WorkflowExpression.Compile(azureADv2SetAzureADUserworkflow, nameof(azureADv2SetAzureADUserworkflow), required: true);
            var __workflow_azureADv2SetAzureADUserfirstName = WorkflowExpression.Compile(azureADv2SetAzureADUserfirstName, nameof(azureADv2SetAzureADUserfirstName), required: false);
            var __workflow_azureADv2SetAzureADUserlastName = WorkflowExpression.Compile(azureADv2SetAzureADUserlastName, nameof(azureADv2SetAzureADUserlastName), required: false);
            var __workflow_azureADv2SetAzureADUserdisplayName = WorkflowExpression.Compile(azureADv2SetAzureADUserdisplayName, nameof(azureADv2SetAzureADUserdisplayName), required: false);
            var __workflow_azureADv2SetAzureADUsercity = WorkflowExpression.Compile(azureADv2SetAzureADUsercity, nameof(azureADv2SetAzureADUsercity), required: false);
            var __workflow_azureADv2SetAzureADUsercompanyName = WorkflowExpression.Compile(azureADv2SetAzureADUsercompanyName, nameof(azureADv2SetAzureADUsercompanyName), required: false);
            var __workflow_azureADv2SetAzureADUsercountry = WorkflowExpression.Compile(azureADv2SetAzureADUsercountry, nameof(azureADv2SetAzureADUsercountry), required: false);
            var __workflow_azureADv2SetAzureADUserdepartment = WorkflowExpression.Compile(azureADv2SetAzureADUserdepartment, nameof(azureADv2SetAzureADUserdepartment), required: false);
            var __workflow_azureADv2SetAzureADUserfaxNumber = WorkflowExpression.Compile(azureADv2SetAzureADUserfaxNumber, nameof(azureADv2SetAzureADUserfaxNumber), required: false);
            var __workflow_azureADv2SetAzureADUserjobTitle = WorkflowExpression.Compile(azureADv2SetAzureADUserjobTitle, nameof(azureADv2SetAzureADUserjobTitle), required: false);
            var __workflow_azureADv2SetAzureADUsermobilePhone = WorkflowExpression.Compile(azureADv2SetAzureADUsermobilePhone, nameof(azureADv2SetAzureADUsermobilePhone), required: false);
            var __workflow_azureADv2SetAzureADUseroffice = WorkflowExpression.Compile(azureADv2SetAzureADUseroffice, nameof(azureADv2SetAzureADUseroffice), required: false);
            var __workflow_azureADv2SetAzureADUserphoneNumber = WorkflowExpression.Compile(azureADv2SetAzureADUserphoneNumber, nameof(azureADv2SetAzureADUserphoneNumber), required: false);
            var __workflow_azureADv2SetAzureADUserpostalCode = WorkflowExpression.Compile(azureADv2SetAzureADUserpostalCode, nameof(azureADv2SetAzureADUserpostalCode), required: false);
            var __workflow_azureADv2SetAzureADUserpreferredLanguage = WorkflowExpression.Compile(azureADv2SetAzureADUserpreferredLanguage, nameof(azureADv2SetAzureADUserpreferredLanguage), required: false);
            var __workflow_azureADv2SetAzureADUserstate = WorkflowExpression.Compile(azureADv2SetAzureADUserstate, nameof(azureADv2SetAzureADUserstate), required: false);
            var __workflow_azureADv2SetAzureADUserstreetAddress = WorkflowExpression.Compile(azureADv2SetAzureADUserstreetAddress, nameof(azureADv2SetAzureADUserstreetAddress), required: false);
            var __workflow_azureADv2SetAzureADUserusageLocation = WorkflowExpression.Compile(azureADv2SetAzureADUserusageLocation, nameof(azureADv2SetAzureADUserusageLocation), required: false);
            var __workflow_azureADv2SetAzureADUserageGroup = WorkflowExpression.Compile(azureADv2SetAzureADUserageGroup, nameof(azureADv2SetAzureADUserageGroup), required: false);
            var __workflow_azureADv2SetAzureADUserconsentProvidedForMinor = WorkflowExpression.Compile(azureADv2SetAzureADUserconsentProvidedForMinor, nameof(azureADv2SetAzureADUserconsentProvidedForMinor), required: false);
            var __workflow_azureADv2SetAzureADUsermailNickName = WorkflowExpression.Compile(azureADv2SetAzureADUsermailNickName, nameof(azureADv2SetAzureADUsermailNickName), required: false);
            var __workflow_azureADv2SetAzureADUseremployeeId = WorkflowExpression.Compile(azureADv2SetAzureADUseremployeeId, nameof(azureADv2SetAzureADUseremployeeId), required: false);
            return new DeferredBodyAction<AzureADv2SetAzureADUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2SetAzureADUser = new JObject();
                var azureADv2SetAzureADUserpropCount = 0;
                azureADv2SetAzureADUserpropCount++;
                azureADv2SetAzureADUser["ObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserobjectId);
                if (__workflow_azureADv2SetAzureADUserfirstName != null)
                {
                    azureADv2SetAzureADUser["FirstName"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserfirstName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserlastName != null)
                {
                    azureADv2SetAzureADUser["LastName"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserlastName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserdisplayName != null)
                {
                    azureADv2SetAzureADUser["DisplayName"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserdisplayName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUsercity != null)
                {
                    azureADv2SetAzureADUser["City"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUsercity);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUsercompanyName != null)
                {
                    azureADv2SetAzureADUser["CompanyName"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUsercompanyName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUsercountry != null)
                {
                    azureADv2SetAzureADUser["Country"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUsercountry);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserdepartment != null)
                {
                    azureADv2SetAzureADUser["Department"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserdepartment);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserfaxNumber != null)
                {
                    azureADv2SetAzureADUser["FaxNumber"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserfaxNumber);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserjobTitle != null)
                {
                    azureADv2SetAzureADUser["JobTitle"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserjobTitle);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUsermobilePhone != null)
                {
                    azureADv2SetAzureADUser["MobilePhone"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUsermobilePhone);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUseroffice != null)
                {
                    azureADv2SetAzureADUser["Office"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUseroffice);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserphoneNumber != null)
                {
                    azureADv2SetAzureADUser["PhoneNumber"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserphoneNumber);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserpostalCode != null)
                {
                    azureADv2SetAzureADUser["PostalCode"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserpostalCode);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserpreferredLanguage != null)
                {
                    azureADv2SetAzureADUser["PreferredLanguage"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserpreferredLanguage);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserstate != null)
                {
                    azureADv2SetAzureADUser["State"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserstate);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserstreetAddress != null)
                {
                    azureADv2SetAzureADUser["StreetAddress"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserstreetAddress);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserusageLocation != null)
                {
                    azureADv2SetAzureADUser["UsageLocation"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserusageLocation);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserageGroup != null)
                {
                    azureADv2SetAzureADUser["AgeGroup"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserageGroup);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUserconsentProvidedForMinor != null)
                {
                    azureADv2SetAzureADUser["ConsentProvidedForMinor"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserconsentProvidedForMinor);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUsermailNickName != null)
                {
                    azureADv2SetAzureADUser["MailNickName"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUsermailNickName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (__workflow_azureADv2SetAzureADUseremployeeId != null)
                {
                    azureADv2SetAzureADUser["EmployeeId"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUseremployeeId);
                    azureADv2SetAzureADUserpropCount++;
                }

                azureADv2SetAzureADUserpropCount++;
                azureADv2SetAzureADUser["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserworkflow);
                if (azureADv2SetAzureADUserpropCount > 0)
                {
                    callPayload.Body = azureADv2SetAzureADUser;
                }

                return new ApiConnectionAction<AzureADv2SetAzureADUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPropertiesResponse, ApiConnectionActionConfiguration> AzureADv2ResetAzureADUserProperties(Expression<Func<string>> azureADv2ResetAzureADUserPropertiesobjectId, Expression<Func<string>> azureADv2ResetAzureADUserPropertiesworkflow, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetFirstName = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetLastName = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetCity = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetCompanyName = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetCountry = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetDepartment = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetFaxNumber = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetJobTitle = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetMobilePhone = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetOffice = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetPhoneNumber = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetPostalCode = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetPreferredLanguage = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetState = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetStreetAddress = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetUsageLocation = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetAgeGroup = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetEmployeeId = null)
        {
            var __workflow_azureADv2ResetAzureADUserPropertiesobjectId = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesobjectId, nameof(azureADv2ResetAzureADUserPropertiesobjectId), required: true);
            var __workflow_azureADv2ResetAzureADUserPropertiesworkflow = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesworkflow, nameof(azureADv2ResetAzureADUserPropertiesworkflow), required: true);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetFirstName = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetFirstName, nameof(azureADv2ResetAzureADUserPropertiesresetFirstName), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetLastName = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetLastName, nameof(azureADv2ResetAzureADUserPropertiesresetLastName), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetCity = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetCity, nameof(azureADv2ResetAzureADUserPropertiesresetCity), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetCompanyName = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetCompanyName, nameof(azureADv2ResetAzureADUserPropertiesresetCompanyName), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetCountry = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetCountry, nameof(azureADv2ResetAzureADUserPropertiesresetCountry), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetDepartment = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetDepartment, nameof(azureADv2ResetAzureADUserPropertiesresetDepartment), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetFaxNumber = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetFaxNumber, nameof(azureADv2ResetAzureADUserPropertiesresetFaxNumber), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetJobTitle = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetJobTitle, nameof(azureADv2ResetAzureADUserPropertiesresetJobTitle), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetMobilePhone = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetMobilePhone, nameof(azureADv2ResetAzureADUserPropertiesresetMobilePhone), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetOffice = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetOffice, nameof(azureADv2ResetAzureADUserPropertiesresetOffice), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetPhoneNumber = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetPhoneNumber, nameof(azureADv2ResetAzureADUserPropertiesresetPhoneNumber), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetPostalCode = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetPostalCode, nameof(azureADv2ResetAzureADUserPropertiesresetPostalCode), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetPreferredLanguage = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetPreferredLanguage, nameof(azureADv2ResetAzureADUserPropertiesresetPreferredLanguage), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetState = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetState, nameof(azureADv2ResetAzureADUserPropertiesresetState), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetStreetAddress = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetStreetAddress, nameof(azureADv2ResetAzureADUserPropertiesresetStreetAddress), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetUsageLocation = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetUsageLocation, nameof(azureADv2ResetAzureADUserPropertiesresetUsageLocation), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetAgeGroup = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetAgeGroup, nameof(azureADv2ResetAzureADUserPropertiesresetAgeGroup), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor, nameof(azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor), required: false);
            var __workflow_azureADv2ResetAzureADUserPropertiesresetEmployeeId = WorkflowExpression.Compile(azureADv2ResetAzureADUserPropertiesresetEmployeeId, nameof(azureADv2ResetAzureADUserPropertiesresetEmployeeId), required: false);
            return new DeferredBodyAction<AzureADv2ResetAzureADUserPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2ResetAzureADUserProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2ResetAzureADUserProperties = new JObject();
                var azureADv2ResetAzureADUserPropertiespropCount = 0;
                azureADv2ResetAzureADUserPropertiespropCount++;
                azureADv2ResetAzureADUserProperties["ObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesobjectId);
                if (__workflow_azureADv2ResetAzureADUserPropertiesresetFirstName != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetFirstName != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetFirstName"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetFirstName);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetFirstName"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetLastName != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetLastName != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetLastName"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetLastName);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetLastName"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetCity != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetCity != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetCity"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetCity);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetCity"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetCompanyName != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetCompanyName != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetCompanyName"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetCompanyName);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetCompanyName"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetCountry != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetCountry != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetCountry"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetCountry);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetCountry"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetDepartment != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetDepartment != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetDepartment"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetDepartment);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetDepartment"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetFaxNumber != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetFaxNumber != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetFaxNumber"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetFaxNumber);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetFaxNumber"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetJobTitle != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetJobTitle != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetJobTitle"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetJobTitle);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetJobTitle"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetMobilePhone != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetMobilePhone != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetMobilePhone"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetMobilePhone);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetMobilePhone"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetOffice != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetOffice != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetOffice"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetOffice);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetOffice"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetPhoneNumber != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetPhoneNumber != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetPhoneNumber"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetPhoneNumber);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetPhoneNumber"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetPostalCode != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetPostalCode != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetPostalCode"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetPostalCode);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetPostalCode"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetPreferredLanguage != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetPreferredLanguage != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetPreferredLanguage"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetPreferredLanguage);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetPreferredLanguage"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetState != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetState != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetState"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetState);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetState"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetStreetAddress != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetStreetAddress != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetStreetAddress"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetStreetAddress);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetStreetAddress"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetUsageLocation != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetUsageLocation != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetUsageLocation"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetUsageLocation);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetUsageLocation"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetAgeGroup != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetAgeGroup != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetAgeGroup"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetAgeGroup);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetAgeGroup"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetConsentProvidedForMinor"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetConsentProvidedForMinor"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (__workflow_azureADv2ResetAzureADUserPropertiesresetEmployeeId != null)
                {
                    if (__workflow_azureADv2ResetAzureADUserPropertiesresetEmployeeId != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetEmployeeId"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesresetEmployeeId);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetEmployeeId"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                azureADv2ResetAzureADUserPropertiespropCount++;
                azureADv2ResetAzureADUserProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPropertiesworkflow);
                if (azureADv2ResetAzureADUserPropertiespropCount > 0)
                {
                    callPayload.Body = azureADv2ResetAzureADUserProperties;
                }

                return new ApiConnectionAction<AzureADv2ResetAzureADUserPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserManagerResponse, ApiConnectionActionConfiguration> AzureADv2SetAzureADUserManager(Expression<Func<string>> azureADv2SetAzureADUserManagerobjectId, Expression<Func<string>> azureADv2SetAzureADUserManagerworkflow, Expression<Func<string>> azureADv2SetAzureADUserManagermanager = null)
        {
            var __workflow_azureADv2SetAzureADUserManagerobjectId = WorkflowExpression.Compile(azureADv2SetAzureADUserManagerobjectId, nameof(azureADv2SetAzureADUserManagerobjectId), required: true);
            var __workflow_azureADv2SetAzureADUserManagerworkflow = WorkflowExpression.Compile(azureADv2SetAzureADUserManagerworkflow, nameof(azureADv2SetAzureADUserManagerworkflow), required: true);
            var __workflow_azureADv2SetAzureADUserManagermanager = WorkflowExpression.Compile(azureADv2SetAzureADUserManagermanager, nameof(azureADv2SetAzureADUserManagermanager), required: false);
            return new DeferredBodyAction<AzureADv2SetAzureADUserManagerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUserManager";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2SetAzureADUserManager = new JObject();
                var azureADv2SetAzureADUserManagerpropCount = 0;
                azureADv2SetAzureADUserManagerpropCount++;
                azureADv2SetAzureADUserManager["ObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserManagerobjectId);
                if (__workflow_azureADv2SetAzureADUserManagermanager != null)
                {
                    azureADv2SetAzureADUserManager["Manager"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserManagermanager);
                    azureADv2SetAzureADUserManagerpropCount++;
                }

                azureADv2SetAzureADUserManagerpropCount++;
                azureADv2SetAzureADUserManager["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserManagerworkflow);
                if (azureADv2SetAzureADUserManagerpropCount > 0)
                {
                    callPayload.Body = azureADv2SetAzureADUserManager;
                }

                return new ApiConnectionAction<AzureADv2SetAzureADUserManagerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2NewSecurityGroupResponse, ApiConnectionActionConfiguration> AzureADv2NewSecurityGroup(Expression<Func<string>> azureADv2NewSecurityGroupdisplayName, Expression<Func<string>> azureADv2NewSecurityGroupworkflow, Expression<Func<string>> azureADv2NewSecurityGroupdescription = null, Expression<Func<bool>> azureADv2NewSecurityGroupcheckGroupExists = null)
        {
            var __workflow_azureADv2NewSecurityGroupdisplayName = WorkflowExpression.Compile(azureADv2NewSecurityGroupdisplayName, nameof(azureADv2NewSecurityGroupdisplayName), required: true);
            var __workflow_azureADv2NewSecurityGroupworkflow = WorkflowExpression.Compile(azureADv2NewSecurityGroupworkflow, nameof(azureADv2NewSecurityGroupworkflow), required: true);
            var __workflow_azureADv2NewSecurityGroupdescription = WorkflowExpression.Compile(azureADv2NewSecurityGroupdescription, nameof(azureADv2NewSecurityGroupdescription), required: false);
            var __workflow_azureADv2NewSecurityGroupcheckGroupExists = WorkflowExpression.Compile(azureADv2NewSecurityGroupcheckGroupExists, nameof(azureADv2NewSecurityGroupcheckGroupExists), required: false);
            return new DeferredBodyAction<AzureADv2NewSecurityGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2NewSecurityGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2NewSecurityGroup = new JObject();
                var azureADv2NewSecurityGrouppropCount = 0;
                azureADv2NewSecurityGrouppropCount++;
                azureADv2NewSecurityGroup["DisplayName"] = ExpressionConverter.ConvertO(__workflow_azureADv2NewSecurityGroupdisplayName);
                if (__workflow_azureADv2NewSecurityGroupdescription != null)
                {
                    azureADv2NewSecurityGroup["Description"] = ExpressionConverter.ConvertO(__workflow_azureADv2NewSecurityGroupdescription);
                    azureADv2NewSecurityGrouppropCount++;
                }

                if (__workflow_azureADv2NewSecurityGroupcheckGroupExists != null)
                {
                    if (__workflow_azureADv2NewSecurityGroupcheckGroupExists != null)
                    {
                        azureADv2NewSecurityGroup["CheckGroupExists"] = ExpressionConverter.ConvertO(__workflow_azureADv2NewSecurityGroupcheckGroupExists);
                        azureADv2NewSecurityGrouppropCount++;
                    }

                    azureADv2NewSecurityGrouppropCount++;
                }
                else
                {
                    azureADv2NewSecurityGroup["CheckGroupExists"] = true;
                    azureADv2NewSecurityGrouppropCount++;
                }

                azureADv2NewSecurityGrouppropCount++;
                azureADv2NewSecurityGroup["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2NewSecurityGroupworkflow);
                if (azureADv2NewSecurityGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2NewSecurityGroup;
                }

                return new ApiConnectionAction<AzureADv2NewSecurityGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveSecurityGroupResponse, ApiConnectionActionConfiguration> AzureADv2RemoveSecurityGroup(Expression<Func<string>> azureADv2RemoveSecurityGroupgroupObjectId, Expression<Func<string>> azureADv2RemoveSecurityGroupworkflow, Expression<Func<bool>> azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist = null)
        {
            var __workflow_azureADv2RemoveSecurityGroupgroupObjectId = WorkflowExpression.Compile(azureADv2RemoveSecurityGroupgroupObjectId, nameof(azureADv2RemoveSecurityGroupgroupObjectId), required: true);
            var __workflow_azureADv2RemoveSecurityGroupworkflow = WorkflowExpression.Compile(azureADv2RemoveSecurityGroupworkflow, nameof(azureADv2RemoveSecurityGroupworkflow), required: true);
            var __workflow_azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist = WorkflowExpression.Compile(azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist, nameof(azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist), required: false);
            return new DeferredBodyAction<AzureADv2RemoveSecurityGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveSecurityGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveSecurityGroup = new JObject();
                var azureADv2RemoveSecurityGrouppropCount = 0;
                azureADv2RemoveSecurityGrouppropCount++;
                azureADv2RemoveSecurityGroup["GroupObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveSecurityGroupgroupObjectId);
                if (__workflow_azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist != null)
                {
                    if (__workflow_azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist != null)
                    {
                        azureADv2RemoveSecurityGroup["ErrorIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist);
                        azureADv2RemoveSecurityGrouppropCount++;
                    }

                    azureADv2RemoveSecurityGrouppropCount++;
                }
                else
                {
                    azureADv2RemoveSecurityGroup["ErrorIfGroupDoesNotExist"] = false;
                    azureADv2RemoveSecurityGrouppropCount++;
                }

                azureADv2RemoveSecurityGrouppropCount++;
                azureADv2RemoveSecurityGroup["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveSecurityGroupworkflow);
                if (azureADv2RemoveSecurityGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveSecurityGroup;
                }

                return new ApiConnectionAction<AzureADv2RemoveSecurityGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2NewMicrosoft365GroupResponse, ApiConnectionActionConfiguration> AzureADv2NewMicrosoft365Group(Expression<Func<string>> azureADv2NewMicrosoft365GroupdisplayName, Expression<Func<string>> azureADv2NewMicrosoft365Groupworkflow, Expression<Func<string>> azureADv2NewMicrosoft365Groupdescription = null, Expression<Func<string>> azureADv2NewMicrosoft365GroupmailNickname = null, Expression<Func<azureADv2NewMicrosoft365GroupgroupVisibilityInput>> azureADv2NewMicrosoft365GroupgroupVisibility = null, Expression<Func<bool>> azureADv2NewMicrosoft365GroupcheckGroupExists = null)
        {
            var __workflow_azureADv2NewMicrosoft365GroupdisplayName = WorkflowExpression.Compile(azureADv2NewMicrosoft365GroupdisplayName, nameof(azureADv2NewMicrosoft365GroupdisplayName), required: true);
            var __workflow_azureADv2NewMicrosoft365Groupworkflow = WorkflowExpression.Compile(azureADv2NewMicrosoft365Groupworkflow, nameof(azureADv2NewMicrosoft365Groupworkflow), required: true);
            var __workflow_azureADv2NewMicrosoft365Groupdescription = WorkflowExpression.Compile(azureADv2NewMicrosoft365Groupdescription, nameof(azureADv2NewMicrosoft365Groupdescription), required: false);
            var __workflow_azureADv2NewMicrosoft365GroupmailNickname = WorkflowExpression.Compile(azureADv2NewMicrosoft365GroupmailNickname, nameof(azureADv2NewMicrosoft365GroupmailNickname), required: false);
            var __workflow_azureADv2NewMicrosoft365GroupgroupVisibility = WorkflowExpression.Compile(azureADv2NewMicrosoft365GroupgroupVisibility, nameof(azureADv2NewMicrosoft365GroupgroupVisibility), required: false);
            var __workflow_azureADv2NewMicrosoft365GroupcheckGroupExists = WorkflowExpression.Compile(azureADv2NewMicrosoft365GroupcheckGroupExists, nameof(azureADv2NewMicrosoft365GroupcheckGroupExists), required: false);
            return new DeferredBodyAction<AzureADv2NewMicrosoft365GroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2NewMicrosoft365Group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2NewMicrosoft365Group = new JObject();
                var azureADv2NewMicrosoft365GrouppropCount = 0;
                azureADv2NewMicrosoft365GrouppropCount++;
                azureADv2NewMicrosoft365Group["DisplayName"] = ExpressionConverter.ConvertO(__workflow_azureADv2NewMicrosoft365GroupdisplayName);
                if (__workflow_azureADv2NewMicrosoft365Groupdescription != null)
                {
                    azureADv2NewMicrosoft365Group["Description"] = ExpressionConverter.ConvertO(__workflow_azureADv2NewMicrosoft365Groupdescription);
                    azureADv2NewMicrosoft365GrouppropCount++;
                }

                if (__workflow_azureADv2NewMicrosoft365GroupmailNickname != null)
                {
                    azureADv2NewMicrosoft365Group["MailNickname"] = ExpressionConverter.ConvertO(__workflow_azureADv2NewMicrosoft365GroupmailNickname);
                    azureADv2NewMicrosoft365GrouppropCount++;
                }

                if (__workflow_azureADv2NewMicrosoft365GroupgroupVisibility != null)
                {
                    if (__workflow_azureADv2NewMicrosoft365GroupgroupVisibility != null)
                    {
                        azureADv2NewMicrosoft365Group["GroupVisibility"] = ExpressionConverter.ConvertO(__workflow_azureADv2NewMicrosoft365GroupgroupVisibility);
                        azureADv2NewMicrosoft365GrouppropCount++;
                    }

                    azureADv2NewMicrosoft365GrouppropCount++;
                }
                else
                {
                    azureADv2NewMicrosoft365Group["GroupVisibility"] = "Public";
                    azureADv2NewMicrosoft365GrouppropCount++;
                }

                if (__workflow_azureADv2NewMicrosoft365GroupcheckGroupExists != null)
                {
                    if (__workflow_azureADv2NewMicrosoft365GroupcheckGroupExists != null)
                    {
                        azureADv2NewMicrosoft365Group["CheckGroupExists"] = ExpressionConverter.ConvertO(__workflow_azureADv2NewMicrosoft365GroupcheckGroupExists);
                        azureADv2NewMicrosoft365GrouppropCount++;
                    }

                    azureADv2NewMicrosoft365GrouppropCount++;
                }
                else
                {
                    azureADv2NewMicrosoft365Group["CheckGroupExists"] = true;
                    azureADv2NewMicrosoft365GrouppropCount++;
                }

                azureADv2NewMicrosoft365GrouppropCount++;
                azureADv2NewMicrosoft365Group["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2NewMicrosoft365Groupworkflow);
                if (azureADv2NewMicrosoft365GrouppropCount > 0)
                {
                    callPayload.Body = azureADv2NewMicrosoft365Group;
                }

                return new ApiConnectionAction<AzureADv2NewMicrosoft365GroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetGroupsResponse, ApiConnectionActionConfiguration> AzureADv2GetGroups(Expression<Func<string>> azureADv2GetGroupsworkflow, Expression<Func<string>> azureADv2GetGroupsobjectId = null, Expression<Func<string>> azureADv2GetGroupsfilterPropertyName = null, Expression<Func<azureADv2GetGroupsfilterPropertyComparisonInput>> azureADv2GetGroupsfilterPropertyComparison = null, Expression<Func<string>> azureADv2GetGroupsfilterPropertyValue = null, Expression<Func<bool>> azureADv2GetGroupsnoResultIsAnException = null, Expression<Func<string>> azureADv2GetGroupspropertiesToReturn = null)
        {
            var __workflow_azureADv2GetGroupsworkflow = WorkflowExpression.Compile(azureADv2GetGroupsworkflow, nameof(azureADv2GetGroupsworkflow), required: true);
            var __workflow_azureADv2GetGroupsobjectId = WorkflowExpression.Compile(azureADv2GetGroupsobjectId, nameof(azureADv2GetGroupsobjectId), required: false);
            var __workflow_azureADv2GetGroupsfilterPropertyName = WorkflowExpression.Compile(azureADv2GetGroupsfilterPropertyName, nameof(azureADv2GetGroupsfilterPropertyName), required: false);
            var __workflow_azureADv2GetGroupsfilterPropertyComparison = WorkflowExpression.Compile(azureADv2GetGroupsfilterPropertyComparison, nameof(azureADv2GetGroupsfilterPropertyComparison), required: false);
            var __workflow_azureADv2GetGroupsfilterPropertyValue = WorkflowExpression.Compile(azureADv2GetGroupsfilterPropertyValue, nameof(azureADv2GetGroupsfilterPropertyValue), required: false);
            var __workflow_azureADv2GetGroupsnoResultIsAnException = WorkflowExpression.Compile(azureADv2GetGroupsnoResultIsAnException, nameof(azureADv2GetGroupsnoResultIsAnException), required: false);
            var __workflow_azureADv2GetGroupspropertiesToReturn = WorkflowExpression.Compile(azureADv2GetGroupspropertiesToReturn, nameof(azureADv2GetGroupspropertiesToReturn), required: false);
            return new DeferredBodyAction<AzureADv2GetGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetGroups = new JObject();
                var azureADv2GetGroupspropCount = 0;
                if (__workflow_azureADv2GetGroupsobjectId != null)
                {
                    azureADv2GetGroups["ObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetGroupsobjectId);
                    azureADv2GetGroupspropCount++;
                }

                if (__workflow_azureADv2GetGroupsfilterPropertyName != null)
                {
                    azureADv2GetGroups["FilterPropertyName"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetGroupsfilterPropertyName);
                    azureADv2GetGroupspropCount++;
                }

                if (__workflow_azureADv2GetGroupsfilterPropertyComparison != null)
                {
                    if (__workflow_azureADv2GetGroupsfilterPropertyComparison != null)
                    {
                        azureADv2GetGroups["FilterPropertyComparison"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetGroupsfilterPropertyComparison);
                        azureADv2GetGroupspropCount++;
                    }

                    azureADv2GetGroupspropCount++;
                }
                else
                {
                    azureADv2GetGroups["FilterPropertyComparison"] = "Equals";
                    azureADv2GetGroupspropCount++;
                }

                if (__workflow_azureADv2GetGroupsfilterPropertyValue != null)
                {
                    azureADv2GetGroups["FilterPropertyValue"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetGroupsfilterPropertyValue);
                    azureADv2GetGroupspropCount++;
                }

                if (__workflow_azureADv2GetGroupsnoResultIsAnException != null)
                {
                    if (__workflow_azureADv2GetGroupsnoResultIsAnException != null)
                    {
                        azureADv2GetGroups["NoResultIsAnException"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetGroupsnoResultIsAnException);
                        azureADv2GetGroupspropCount++;
                    }

                    azureADv2GetGroupspropCount++;
                }
                else
                {
                    azureADv2GetGroups["NoResultIsAnException"] = false;
                    azureADv2GetGroupspropCount++;
                }

                if (__workflow_azureADv2GetGroupspropertiesToReturn != null)
                {
                    azureADv2GetGroups["PropertiesToReturn"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetGroupspropertiesToReturn);
                    azureADv2GetGroupspropCount++;
                }

                azureADv2GetGroupspropCount++;
                azureADv2GetGroups["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetGroupsworkflow);
                if (azureADv2GetGroupspropCount > 0)
                {
                    callPayload.Body = azureADv2GetGroups;
                }

                return new ApiConnectionAction<AzureADv2GetGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2EnableUserResponse, ApiConnectionActionConfiguration> AzureADv2EnableUser(Expression<Func<string>> azureADv2EnableUseruserObjectId, Expression<Func<string>> azureADv2EnableUserworkflow)
        {
            var __workflow_azureADv2EnableUseruserObjectId = WorkflowExpression.Compile(azureADv2EnableUseruserObjectId, nameof(azureADv2EnableUseruserObjectId), required: true);
            var __workflow_azureADv2EnableUserworkflow = WorkflowExpression.Compile(azureADv2EnableUserworkflow, nameof(azureADv2EnableUserworkflow), required: true);
            return new DeferredBodyAction<AzureADv2EnableUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2EnableUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2EnableUser = new JObject();
                var azureADv2EnableUserpropCount = 0;
                azureADv2EnableUserpropCount++;
                azureADv2EnableUser["UserObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2EnableUseruserObjectId);
                azureADv2EnableUserpropCount++;
                azureADv2EnableUser["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2EnableUserworkflow);
                if (azureADv2EnableUserpropCount > 0)
                {
                    callPayload.Body = azureADv2EnableUser;
                }

                return new ApiConnectionAction<AzureADv2EnableUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2DisableUserResponse, ApiConnectionActionConfiguration> AzureADv2DisableUser(Expression<Func<string>> azureADv2DisableUseruserObjectId, Expression<Func<string>> azureADv2DisableUserworkflow, Expression<Func<bool>> azureADv2DisableUserrevokeUserRefreshTokens = null)
        {
            var __workflow_azureADv2DisableUseruserObjectId = WorkflowExpression.Compile(azureADv2DisableUseruserObjectId, nameof(azureADv2DisableUseruserObjectId), required: true);
            var __workflow_azureADv2DisableUserworkflow = WorkflowExpression.Compile(azureADv2DisableUserworkflow, nameof(azureADv2DisableUserworkflow), required: true);
            var __workflow_azureADv2DisableUserrevokeUserRefreshTokens = WorkflowExpression.Compile(azureADv2DisableUserrevokeUserRefreshTokens, nameof(azureADv2DisableUserrevokeUserRefreshTokens), required: false);
            return new DeferredBodyAction<AzureADv2DisableUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2DisableUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2DisableUser = new JObject();
                var azureADv2DisableUserpropCount = 0;
                azureADv2DisableUserpropCount++;
                azureADv2DisableUser["UserObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2DisableUseruserObjectId);
                if (__workflow_azureADv2DisableUserrevokeUserRefreshTokens != null)
                {
                    if (__workflow_azureADv2DisableUserrevokeUserRefreshTokens != null)
                    {
                        azureADv2DisableUser["RevokeUserRefreshTokens"] = ExpressionConverter.ConvertO(__workflow_azureADv2DisableUserrevokeUserRefreshTokens);
                        azureADv2DisableUserpropCount++;
                    }

                    azureADv2DisableUserpropCount++;
                }
                else
                {
                    azureADv2DisableUser["RevokeUserRefreshTokens"] = true;
                    azureADv2DisableUserpropCount++;
                }

                azureADv2DisableUserpropCount++;
                azureADv2DisableUser["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2DisableUserworkflow);
                if (azureADv2DisableUserpropCount > 0)
                {
                    callPayload.Body = azureADv2DisableUser;
                }

                return new ApiConnectionAction<AzureADv2DisableUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AssignUserToRoleResponse, ApiConnectionActionConfiguration> AzureADv2AssignUserToRole(Expression<Func<string>> azureADv2AssignUserToRoleuserObjectId, Expression<Func<string>> azureADv2AssignUserToRoleroleObjectId, Expression<Func<string>> azureADv2AssignUserToRoleworkflow, Expression<Func<string>> azureADv2AssignUserToRoledirectoryScopeId = null, Expression<Func<bool>> azureADv2AssignUserToRolecheckUserRoleMembershipsFirst = null)
        {
            var __workflow_azureADv2AssignUserToRoleuserObjectId = WorkflowExpression.Compile(azureADv2AssignUserToRoleuserObjectId, nameof(azureADv2AssignUserToRoleuserObjectId), required: true);
            var __workflow_azureADv2AssignUserToRoleroleObjectId = WorkflowExpression.Compile(azureADv2AssignUserToRoleroleObjectId, nameof(azureADv2AssignUserToRoleroleObjectId), required: true);
            var __workflow_azureADv2AssignUserToRoleworkflow = WorkflowExpression.Compile(azureADv2AssignUserToRoleworkflow, nameof(azureADv2AssignUserToRoleworkflow), required: true);
            var __workflow_azureADv2AssignUserToRoledirectoryScopeId = WorkflowExpression.Compile(azureADv2AssignUserToRoledirectoryScopeId, nameof(azureADv2AssignUserToRoledirectoryScopeId), required: false);
            var __workflow_azureADv2AssignUserToRolecheckUserRoleMembershipsFirst = WorkflowExpression.Compile(azureADv2AssignUserToRolecheckUserRoleMembershipsFirst, nameof(azureADv2AssignUserToRolecheckUserRoleMembershipsFirst), required: false);
            return new DeferredBodyAction<AzureADv2AssignUserToRoleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AssignUserToRole";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AssignUserToRole = new JObject();
                var azureADv2AssignUserToRolepropCount = 0;
                azureADv2AssignUserToRolepropCount++;
                azureADv2AssignUserToRole["UserObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToRoleuserObjectId);
                azureADv2AssignUserToRolepropCount++;
                azureADv2AssignUserToRole["RoleObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToRoleroleObjectId);
                if (__workflow_azureADv2AssignUserToRoledirectoryScopeId != null)
                {
                    if (__workflow_azureADv2AssignUserToRoledirectoryScopeId != null)
                    {
                        azureADv2AssignUserToRole["DirectoryScopeId"] = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToRoledirectoryScopeId);
                        azureADv2AssignUserToRolepropCount++;
                    }

                    azureADv2AssignUserToRolepropCount++;
                }
                else
                {
                    azureADv2AssignUserToRole["DirectoryScopeId"] = "/";
                    azureADv2AssignUserToRolepropCount++;
                }

                if (__workflow_azureADv2AssignUserToRolecheckUserRoleMembershipsFirst != null)
                {
                    if (__workflow_azureADv2AssignUserToRolecheckUserRoleMembershipsFirst != null)
                    {
                        azureADv2AssignUserToRole["CheckUserRoleMembershipsFirst"] = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToRolecheckUserRoleMembershipsFirst);
                        azureADv2AssignUserToRolepropCount++;
                    }

                    azureADv2AssignUserToRolepropCount++;
                }
                else
                {
                    azureADv2AssignUserToRole["CheckUserRoleMembershipsFirst"] = true;
                    azureADv2AssignUserToRolepropCount++;
                }

                azureADv2AssignUserToRolepropCount++;
                azureADv2AssignUserToRole["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToRoleworkflow);
                if (azureADv2AssignUserToRolepropCount > 0)
                {
                    callPayload.Body = azureADv2AssignUserToRole;
                }

                return new ApiConnectionAction<AzureADv2AssignUserToRoleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AssignUserToMultipleRolesResponse, ApiConnectionActionConfiguration> AzureADv2AssignUserToMultipleRoles(Expression<Func<string>> azureADv2AssignUserToMultipleRolesuserObjectId, Expression<Func<string>> azureADv2AssignUserToMultipleRolesworkflow, Expression<Func<string>> azureADv2AssignUserToMultipleRolesrolesJSON = null, Expression<Func<bool>> azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign = null, Expression<Func<bool>> azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign = null, Expression<Func<string>> azureADv2AssignUserToMultipleRolesdirectoryScopeId = null, Expression<Func<bool>> azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst = null, Expression<Func<bool>> azureADv2AssignUserToMultipleRolescheckRoleIdsExist = null)
        {
            var __workflow_azureADv2AssignUserToMultipleRolesuserObjectId = WorkflowExpression.Compile(azureADv2AssignUserToMultipleRolesuserObjectId, nameof(azureADv2AssignUserToMultipleRolesuserObjectId), required: true);
            var __workflow_azureADv2AssignUserToMultipleRolesworkflow = WorkflowExpression.Compile(azureADv2AssignUserToMultipleRolesworkflow, nameof(azureADv2AssignUserToMultipleRolesworkflow), required: true);
            var __workflow_azureADv2AssignUserToMultipleRolesrolesJSON = WorkflowExpression.Compile(azureADv2AssignUserToMultipleRolesrolesJSON, nameof(azureADv2AssignUserToMultipleRolesrolesJSON), required: false);
            var __workflow_azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign = WorkflowExpression.Compile(azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign, nameof(azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign), required: false);
            var __workflow_azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign = WorkflowExpression.Compile(azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign, nameof(azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign), required: false);
            var __workflow_azureADv2AssignUserToMultipleRolesdirectoryScopeId = WorkflowExpression.Compile(azureADv2AssignUserToMultipleRolesdirectoryScopeId, nameof(azureADv2AssignUserToMultipleRolesdirectoryScopeId), required: false);
            var __workflow_azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst = WorkflowExpression.Compile(azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst, nameof(azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst), required: false);
            var __workflow_azureADv2AssignUserToMultipleRolescheckRoleIdsExist = WorkflowExpression.Compile(azureADv2AssignUserToMultipleRolescheckRoleIdsExist, nameof(azureADv2AssignUserToMultipleRolescheckRoleIdsExist), required: false);
            return new DeferredBodyAction<AzureADv2AssignUserToMultipleRolesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AssignUserToMultipleRoles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AssignUserToMultipleRoles = new JObject();
                var azureADv2AssignUserToMultipleRolespropCount = 0;
                azureADv2AssignUserToMultipleRolespropCount++;
                azureADv2AssignUserToMultipleRoles["UserObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToMultipleRolesuserObjectId);
                if (__workflow_azureADv2AssignUserToMultipleRolesrolesJSON != null)
                {
                    azureADv2AssignUserToMultipleRoles["RolesJSON"] = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToMultipleRolesrolesJSON);
                    azureADv2AssignUserToMultipleRolespropCount++;
                }

                if (__workflow_azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign != null)
                {
                    if (__workflow_azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign != null)
                    {
                        azureADv2AssignUserToMultipleRoles["ExceptionIfAnyRolesFailToAssign"] = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign);
                        azureADv2AssignUserToMultipleRolespropCount++;
                    }

                    azureADv2AssignUserToMultipleRolespropCount++;
                }
                else
                {
                    azureADv2AssignUserToMultipleRoles["ExceptionIfAnyRolesFailToAssign"] = false;
                    azureADv2AssignUserToMultipleRolespropCount++;
                }

                if (__workflow_azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign != null)
                {
                    if (__workflow_azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign != null)
                    {
                        azureADv2AssignUserToMultipleRoles["ExceptionIfAllRolesFailToAssign"] = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign);
                        azureADv2AssignUserToMultipleRolespropCount++;
                    }

                    azureADv2AssignUserToMultipleRolespropCount++;
                }
                else
                {
                    azureADv2AssignUserToMultipleRoles["ExceptionIfAllRolesFailToAssign"] = false;
                    azureADv2AssignUserToMultipleRolespropCount++;
                }

                if (__workflow_azureADv2AssignUserToMultipleRolesdirectoryScopeId != null)
                {
                    if (__workflow_azureADv2AssignUserToMultipleRolesdirectoryScopeId != null)
                    {
                        azureADv2AssignUserToMultipleRoles["DirectoryScopeId"] = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToMultipleRolesdirectoryScopeId);
                        azureADv2AssignUserToMultipleRolespropCount++;
                    }

                    azureADv2AssignUserToMultipleRolespropCount++;
                }
                else
                {
                    azureADv2AssignUserToMultipleRoles["DirectoryScopeId"] = "/";
                    azureADv2AssignUserToMultipleRolespropCount++;
                }

                if (__workflow_azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst != null)
                {
                    if (__workflow_azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst != null)
                    {
                        azureADv2AssignUserToMultipleRoles["CheckUserRoleMembershipsFirst"] = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst);
                        azureADv2AssignUserToMultipleRolespropCount++;
                    }

                    azureADv2AssignUserToMultipleRolespropCount++;
                }
                else
                {
                    azureADv2AssignUserToMultipleRoles["CheckUserRoleMembershipsFirst"] = true;
                    azureADv2AssignUserToMultipleRolespropCount++;
                }

                if (__workflow_azureADv2AssignUserToMultipleRolescheckRoleIdsExist != null)
                {
                    if (__workflow_azureADv2AssignUserToMultipleRolescheckRoleIdsExist != null)
                    {
                        azureADv2AssignUserToMultipleRoles["CheckRoleIdsExist"] = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToMultipleRolescheckRoleIdsExist);
                        azureADv2AssignUserToMultipleRolespropCount++;
                    }

                    azureADv2AssignUserToMultipleRolespropCount++;
                }
                else
                {
                    azureADv2AssignUserToMultipleRoles["CheckRoleIdsExist"] = true;
                    azureADv2AssignUserToMultipleRolespropCount++;
                }

                azureADv2AssignUserToMultipleRolespropCount++;
                azureADv2AssignUserToMultipleRoles["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToMultipleRolesworkflow);
                if (azureADv2AssignUserToMultipleRolespropCount > 0)
                {
                    callPayload.Body = azureADv2AssignUserToMultipleRoles;
                }

                return new ApiConnectionAction<AzureADv2AssignUserToMultipleRolesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromMultipleRolesResponse, ApiConnectionActionConfiguration> AzureADv2RemoveUserFromMultipleRoles(Expression<Func<string>> azureADv2RemoveUserFromMultipleRolesuserObjectId, Expression<Func<string>> azureADv2RemoveUserFromMultipleRolesworkflow, Expression<Func<string>> azureADv2RemoveUserFromMultipleRolesrolesJSON = null, Expression<Func<string>> azureADv2RemoveUserFromMultipleRolesdirectoryScopeId = null, Expression<Func<bool>> azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove = null, Expression<Func<bool>> azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove = null, Expression<Func<bool>> azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist = null)
        {
            var __workflow_azureADv2RemoveUserFromMultipleRolesuserObjectId = WorkflowExpression.Compile(azureADv2RemoveUserFromMultipleRolesuserObjectId, nameof(azureADv2RemoveUserFromMultipleRolesuserObjectId), required: true);
            var __workflow_azureADv2RemoveUserFromMultipleRolesworkflow = WorkflowExpression.Compile(azureADv2RemoveUserFromMultipleRolesworkflow, nameof(azureADv2RemoveUserFromMultipleRolesworkflow), required: true);
            var __workflow_azureADv2RemoveUserFromMultipleRolesrolesJSON = WorkflowExpression.Compile(azureADv2RemoveUserFromMultipleRolesrolesJSON, nameof(azureADv2RemoveUserFromMultipleRolesrolesJSON), required: false);
            var __workflow_azureADv2RemoveUserFromMultipleRolesdirectoryScopeId = WorkflowExpression.Compile(azureADv2RemoveUserFromMultipleRolesdirectoryScopeId, nameof(azureADv2RemoveUserFromMultipleRolesdirectoryScopeId), required: false);
            var __workflow_azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove = WorkflowExpression.Compile(azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove, nameof(azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove), required: false);
            var __workflow_azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove = WorkflowExpression.Compile(azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove, nameof(azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove), required: false);
            var __workflow_azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist = WorkflowExpression.Compile(azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist, nameof(azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist), required: false);
            return new DeferredBodyAction<AzureADv2RemoveUserFromMultipleRolesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromMultipleRoles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromMultipleRoles = new JObject();
                var azureADv2RemoveUserFromMultipleRolespropCount = 0;
                azureADv2RemoveUserFromMultipleRolespropCount++;
                azureADv2RemoveUserFromMultipleRoles["UserObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromMultipleRolesuserObjectId);
                if (__workflow_azureADv2RemoveUserFromMultipleRolesrolesJSON != null)
                {
                    azureADv2RemoveUserFromMultipleRoles["RolesJSON"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromMultipleRolesrolesJSON);
                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }

                if (__workflow_azureADv2RemoveUserFromMultipleRolesdirectoryScopeId != null)
                {
                    if (__workflow_azureADv2RemoveUserFromMultipleRolesdirectoryScopeId != null)
                    {
                        azureADv2RemoveUserFromMultipleRoles["DirectoryScopeId"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromMultipleRolesdirectoryScopeId);
                        azureADv2RemoveUserFromMultipleRolespropCount++;
                    }

                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromMultipleRoles["DirectoryScopeId"] = "*";
                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }

                if (__workflow_azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove != null)
                {
                    if (__workflow_azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove != null)
                    {
                        azureADv2RemoveUserFromMultipleRoles["ExceptionIfAnyRolesFailToRemove"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove);
                        azureADv2RemoveUserFromMultipleRolespropCount++;
                    }

                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromMultipleRoles["ExceptionIfAnyRolesFailToRemove"] = false;
                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }

                if (__workflow_azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove != null)
                {
                    if (__workflow_azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove != null)
                    {
                        azureADv2RemoveUserFromMultipleRoles["ExceptionIfAllRolesFailToRemove"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove);
                        azureADv2RemoveUserFromMultipleRolespropCount++;
                    }

                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromMultipleRoles["ExceptionIfAllRolesFailToRemove"] = false;
                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }

                if (__workflow_azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist != null)
                {
                    if (__workflow_azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist != null)
                    {
                        azureADv2RemoveUserFromMultipleRoles["ExceptionIfRoleDoesNotExist"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist);
                        azureADv2RemoveUserFromMultipleRolespropCount++;
                    }

                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromMultipleRoles["ExceptionIfRoleDoesNotExist"] = false;
                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }

                azureADv2RemoveUserFromMultipleRolespropCount++;
                azureADv2RemoveUserFromMultipleRoles["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromMultipleRolesworkflow);
                if (azureADv2RemoveUserFromMultipleRolespropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromMultipleRoles;
                }

                return new ApiConnectionAction<AzureADv2RemoveUserFromMultipleRolesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2IsUserInRoleResponse, ApiConnectionActionConfiguration> AzureADv2IsUserInRole(Expression<Func<string>> azureADv2IsUserInRoleuserObjectId, Expression<Func<string>> azureADv2IsUserInRoleroleObjectId, Expression<Func<string>> azureADv2IsUserInRoleworkflow)
        {
            var __workflow_azureADv2IsUserInRoleuserObjectId = WorkflowExpression.Compile(azureADv2IsUserInRoleuserObjectId, nameof(azureADv2IsUserInRoleuserObjectId), required: true);
            var __workflow_azureADv2IsUserInRoleroleObjectId = WorkflowExpression.Compile(azureADv2IsUserInRoleroleObjectId, nameof(azureADv2IsUserInRoleroleObjectId), required: true);
            var __workflow_azureADv2IsUserInRoleworkflow = WorkflowExpression.Compile(azureADv2IsUserInRoleworkflow, nameof(azureADv2IsUserInRoleworkflow), required: true);
            return new DeferredBodyAction<AzureADv2IsUserInRoleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2IsUserInRole";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2IsUserInRole = new JObject();
                var azureADv2IsUserInRolepropCount = 0;
                azureADv2IsUserInRolepropCount++;
                azureADv2IsUserInRole["UserObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2IsUserInRoleuserObjectId);
                azureADv2IsUserInRolepropCount++;
                azureADv2IsUserInRole["RoleObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2IsUserInRoleroleObjectId);
                azureADv2IsUserInRolepropCount++;
                azureADv2IsUserInRole["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2IsUserInRoleworkflow);
                if (azureADv2IsUserInRolepropCount > 0)
                {
                    callPayload.Body = azureADv2IsUserInRole;
                }

                return new ApiConnectionAction<AzureADv2IsUserInRoleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserRoleAssignmentsResponse, ApiConnectionActionConfiguration> AzureADv2GetAzureADUserRoleAssignments(Expression<Func<string>> azureADv2GetAzureADUserRoleAssignmentsobjectId, Expression<Func<string>> azureADv2GetAzureADUserRoleAssignmentsworkflow, Expression<Func<bool>> azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames = null, Expression<Func<bool>> azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds = null)
        {
            var __workflow_azureADv2GetAzureADUserRoleAssignmentsobjectId = WorkflowExpression.Compile(azureADv2GetAzureADUserRoleAssignmentsobjectId, nameof(azureADv2GetAzureADUserRoleAssignmentsobjectId), required: true);
            var __workflow_azureADv2GetAzureADUserRoleAssignmentsworkflow = WorkflowExpression.Compile(azureADv2GetAzureADUserRoleAssignmentsworkflow, nameof(azureADv2GetAzureADUserRoleAssignmentsworkflow), required: true);
            var __workflow_azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames = WorkflowExpression.Compile(azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames, nameof(azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames), required: false);
            var __workflow_azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds = WorkflowExpression.Compile(azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds, nameof(azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds), required: false);
            return new DeferredBodyAction<AzureADv2GetAzureADUserRoleAssignmentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserRoleAssignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUserRoleAssignments = new JObject();
                var azureADv2GetAzureADUserRoleAssignmentspropCount = 0;
                azureADv2GetAzureADUserRoleAssignmentspropCount++;
                azureADv2GetAzureADUserRoleAssignments["ObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserRoleAssignmentsobjectId);
                if (__workflow_azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames != null)
                {
                    if (__workflow_azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames != null)
                    {
                        azureADv2GetAzureADUserRoleAssignments["RetrieveAdminRoleNames"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames);
                        azureADv2GetAzureADUserRoleAssignmentspropCount++;
                    }

                    azureADv2GetAzureADUserRoleAssignmentspropCount++;
                }
                else
                {
                    azureADv2GetAzureADUserRoleAssignments["RetrieveAdminRoleNames"] = true;
                    azureADv2GetAzureADUserRoleAssignmentspropCount++;
                }

                if (__workflow_azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds != null)
                {
                    if (__workflow_azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds != null)
                    {
                        azureADv2GetAzureADUserRoleAssignments["ReturnAssignmentIds"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds);
                        azureADv2GetAzureADUserRoleAssignmentspropCount++;
                    }

                    azureADv2GetAzureADUserRoleAssignmentspropCount++;
                }
                else
                {
                    azureADv2GetAzureADUserRoleAssignments["ReturnAssignmentIds"] = false;
                    azureADv2GetAzureADUserRoleAssignmentspropCount++;
                }

                azureADv2GetAzureADUserRoleAssignmentspropCount++;
                azureADv2GetAzureADUserRoleAssignments["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserRoleAssignmentsworkflow);
                if (azureADv2GetAzureADUserRoleAssignmentspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUserRoleAssignments;
                }

                return new ApiConnectionAction<AzureADv2GetAzureADUserRoleAssignmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromRoleResponse, ApiConnectionActionConfiguration> AzureADv2RemoveUserFromRole(Expression<Func<string>> azureADv2RemoveUserFromRoleuserObjectId, Expression<Func<string>> azureADv2RemoveUserFromRoleroleObjectId, Expression<Func<string>> azureADv2RemoveUserFromRoleworkflow, Expression<Func<string>> azureADv2RemoveUserFromRoledirectoryScopeId = null)
        {
            var __workflow_azureADv2RemoveUserFromRoleuserObjectId = WorkflowExpression.Compile(azureADv2RemoveUserFromRoleuserObjectId, nameof(azureADv2RemoveUserFromRoleuserObjectId), required: true);
            var __workflow_azureADv2RemoveUserFromRoleroleObjectId = WorkflowExpression.Compile(azureADv2RemoveUserFromRoleroleObjectId, nameof(azureADv2RemoveUserFromRoleroleObjectId), required: true);
            var __workflow_azureADv2RemoveUserFromRoleworkflow = WorkflowExpression.Compile(azureADv2RemoveUserFromRoleworkflow, nameof(azureADv2RemoveUserFromRoleworkflow), required: true);
            var __workflow_azureADv2RemoveUserFromRoledirectoryScopeId = WorkflowExpression.Compile(azureADv2RemoveUserFromRoledirectoryScopeId, nameof(azureADv2RemoveUserFromRoledirectoryScopeId), required: false);
            return new DeferredBodyAction<AzureADv2RemoveUserFromRoleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromRole";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromRole = new JObject();
                var azureADv2RemoveUserFromRolepropCount = 0;
                azureADv2RemoveUserFromRolepropCount++;
                azureADv2RemoveUserFromRole["UserObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromRoleuserObjectId);
                azureADv2RemoveUserFromRolepropCount++;
                azureADv2RemoveUserFromRole["RoleObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromRoleroleObjectId);
                if (__workflow_azureADv2RemoveUserFromRoledirectoryScopeId != null)
                {
                    if (__workflow_azureADv2RemoveUserFromRoledirectoryScopeId != null)
                    {
                        azureADv2RemoveUserFromRole["DirectoryScopeId"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromRoledirectoryScopeId);
                        azureADv2RemoveUserFromRolepropCount++;
                    }

                    azureADv2RemoveUserFromRolepropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromRole["DirectoryScopeId"] = "*";
                    azureADv2RemoveUserFromRolepropCount++;
                }

                azureADv2RemoveUserFromRolepropCount++;
                azureADv2RemoveUserFromRole["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromRoleworkflow);
                if (azureADv2RemoveUserFromRolepropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromRole;
                }

                return new ApiConnectionAction<AzureADv2RemoveUserFromRoleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllRolesResponse, ApiConnectionActionConfiguration> AzureADv2RemoveUserFromAllRoles(Expression<Func<string>> azureADv2RemoveUserFromAllRolesuserObjectId, Expression<Func<string>> azureADv2RemoveUserFromAllRolesworkflow, Expression<Func<bool>> azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove = null, Expression<Func<bool>> azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove = null)
        {
            var __workflow_azureADv2RemoveUserFromAllRolesuserObjectId = WorkflowExpression.Compile(azureADv2RemoveUserFromAllRolesuserObjectId, nameof(azureADv2RemoveUserFromAllRolesuserObjectId), required: true);
            var __workflow_azureADv2RemoveUserFromAllRolesworkflow = WorkflowExpression.Compile(azureADv2RemoveUserFromAllRolesworkflow, nameof(azureADv2RemoveUserFromAllRolesworkflow), required: true);
            var __workflow_azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove = WorkflowExpression.Compile(azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove, nameof(azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove), required: false);
            var __workflow_azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove = WorkflowExpression.Compile(azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove, nameof(azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove), required: false);
            return new DeferredBodyAction<AzureADv2RemoveUserFromAllRolesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromAllRoles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromAllRoles = new JObject();
                var azureADv2RemoveUserFromAllRolespropCount = 0;
                azureADv2RemoveUserFromAllRolespropCount++;
                azureADv2RemoveUserFromAllRoles["UserObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromAllRolesuserObjectId);
                if (__workflow_azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove != null)
                {
                    if (__workflow_azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove != null)
                    {
                        azureADv2RemoveUserFromAllRoles["ExceptionIfAnyRolesFailToRemove"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove);
                        azureADv2RemoveUserFromAllRolespropCount++;
                    }

                    azureADv2RemoveUserFromAllRolespropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromAllRoles["ExceptionIfAnyRolesFailToRemove"] = false;
                    azureADv2RemoveUserFromAllRolespropCount++;
                }

                if (__workflow_azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove != null)
                {
                    if (__workflow_azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove != null)
                    {
                        azureADv2RemoveUserFromAllRoles["ExceptionIfAllRolesFailToRemove"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove);
                        azureADv2RemoveUserFromAllRolespropCount++;
                    }

                    azureADv2RemoveUserFromAllRolespropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromAllRoles["ExceptionIfAllRolesFailToRemove"] = true;
                    azureADv2RemoveUserFromAllRolespropCount++;
                }

                azureADv2RemoveUserFromAllRolespropCount++;
                azureADv2RemoveUserFromAllRoles["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromAllRolesworkflow);
                if (azureADv2RemoveUserFromAllRolespropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromAllRoles;
                }

                return new ApiConnectionAction<AzureADv2RemoveUserFromAllRolesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADGroupMembersResponse, ApiConnectionActionConfiguration> AzureADv2GetAzureADGroupMembers(Expression<Func<string>> azureADv2GetAzureADGroupMembersgroupObjectId, Expression<Func<string>> azureADv2GetAzureADGroupMembersworkflow, Expression<Func<string>> azureADv2GetAzureADGroupMemberspropertiesToReturn = null, Expression<Func<string>> azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn = null)
        {
            var __workflow_azureADv2GetAzureADGroupMembersgroupObjectId = WorkflowExpression.Compile(azureADv2GetAzureADGroupMembersgroupObjectId, nameof(azureADv2GetAzureADGroupMembersgroupObjectId), required: true);
            var __workflow_azureADv2GetAzureADGroupMembersworkflow = WorkflowExpression.Compile(azureADv2GetAzureADGroupMembersworkflow, nameof(azureADv2GetAzureADGroupMembersworkflow), required: true);
            var __workflow_azureADv2GetAzureADGroupMemberspropertiesToReturn = WorkflowExpression.Compile(azureADv2GetAzureADGroupMemberspropertiesToReturn, nameof(azureADv2GetAzureADGroupMemberspropertiesToReturn), required: false);
            var __workflow_azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn = WorkflowExpression.Compile(azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn, nameof(azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn), required: false);
            return new DeferredBodyAction<AzureADv2GetAzureADGroupMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADGroupMembers = new JObject();
                var azureADv2GetAzureADGroupMemberspropCount = 0;
                azureADv2GetAzureADGroupMemberspropCount++;
                azureADv2GetAzureADGroupMembers["GroupObjectId"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADGroupMembersgroupObjectId);
                if (__workflow_azureADv2GetAzureADGroupMemberspropertiesToReturn != null)
                {
                    azureADv2GetAzureADGroupMembers["PropertiesToReturn"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADGroupMemberspropertiesToReturn);
                    azureADv2GetAzureADGroupMemberspropCount++;
                }

                if (__workflow_azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn != null)
                {
                    azureADv2GetAzureADGroupMembers["MemberObjectTypesToReturn"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn);
                    azureADv2GetAzureADGroupMemberspropCount++;
                }

                azureADv2GetAzureADGroupMemberspropCount++;
                azureADv2GetAzureADGroupMembers["Workflow"] = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADGroupMembersworkflow);
                if (azureADv2GetAzureADGroupMemberspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADGroupMembers;
                }

                return new ApiConnectionAction<AzureADv2GetAzureADGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceResponse, ApiConnectionActionConfiguration> OpenO365PowerShellRunspace(Expression<Func<string>> openO365PowerShellRunspaceoffice365Username, Expression<Func<string>> openO365PowerShellRunspaceoffice365Password, Expression<Func<string>> openO365PowerShellRunspaceworkflow, Expression<Func<string>> openO365PowerShellRunspaceexchangeURL = null, Expression<Func<openO365PowerShellRunspaceconnectionMethodInput>> openO365PowerShellRunspaceconnectionMethod = null, Expression<Func<bool>> openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected = null, Expression<Func<openO365PowerShellRunspacecommandTypesToImportLocallyInput>> openO365PowerShellRunspacecommandTypesToImportLocally = null, Expression<Func<string>> openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV = null)
        {
            var __workflow_openO365PowerShellRunspaceoffice365Username = WorkflowExpression.Compile(openO365PowerShellRunspaceoffice365Username, nameof(openO365PowerShellRunspaceoffice365Username), required: true);
            var __workflow_openO365PowerShellRunspaceoffice365Password = WorkflowExpression.Compile(openO365PowerShellRunspaceoffice365Password, nameof(openO365PowerShellRunspaceoffice365Password), required: true);
            var __workflow_openO365PowerShellRunspaceworkflow = WorkflowExpression.Compile(openO365PowerShellRunspaceworkflow, nameof(openO365PowerShellRunspaceworkflow), required: true);
            var __workflow_openO365PowerShellRunspaceexchangeURL = WorkflowExpression.Compile(openO365PowerShellRunspaceexchangeURL, nameof(openO365PowerShellRunspaceexchangeURL), required: false);
            var __workflow_openO365PowerShellRunspaceconnectionMethod = WorkflowExpression.Compile(openO365PowerShellRunspaceconnectionMethod, nameof(openO365PowerShellRunspaceconnectionMethod), required: false);
            var __workflow_openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected = WorkflowExpression.Compile(openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected, nameof(openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected), required: false);
            var __workflow_openO365PowerShellRunspacecommandTypesToImportLocally = WorkflowExpression.Compile(openO365PowerShellRunspacecommandTypesToImportLocally, nameof(openO365PowerShellRunspacecommandTypesToImportLocally), required: false);
            var __workflow_openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV = WorkflowExpression.Compile(openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV, nameof(openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV), required: false);
            return new DeferredBodyAction<OpenO365PowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenO365PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openO365PowerShellRunspace = new JObject();
                var openO365PowerShellRunspacepropCount = 0;
                openO365PowerShellRunspacepropCount++;
                openO365PowerShellRunspace["Office365Username"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceoffice365Username);
                openO365PowerShellRunspacepropCount++;
                openO365PowerShellRunspace["Office365Password"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceoffice365Password);
                if (__workflow_openO365PowerShellRunspaceexchangeURL != null)
                {
                    openO365PowerShellRunspace["ExchangeURL"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceexchangeURL);
                    openO365PowerShellRunspacepropCount++;
                }

                if (__workflow_openO365PowerShellRunspaceconnectionMethod != null)
                {
                    if (__workflow_openO365PowerShellRunspaceconnectionMethod != null)
                    {
                        openO365PowerShellRunspace["ConnectionMethod"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceconnectionMethod);
                        openO365PowerShellRunspacepropCount++;
                    }

                    openO365PowerShellRunspacepropCount++;
                }
                else
                {
                    openO365PowerShellRunspace["ConnectionMethod"] = "EXO V1 local";
                    openO365PowerShellRunspacepropCount++;
                }

                if (__workflow_openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected != null)
                {
                    if (__workflow_openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected != null)
                    {
                        openO365PowerShellRunspace["OnlyConnectIfNotAlreadyConnected"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected);
                        openO365PowerShellRunspacepropCount++;
                    }

                    openO365PowerShellRunspacepropCount++;
                }
                else
                {
                    openO365PowerShellRunspace["OnlyConnectIfNotAlreadyConnected"] = true;
                    openO365PowerShellRunspacepropCount++;
                }

                if (__workflow_openO365PowerShellRunspacecommandTypesToImportLocally != null)
                {
                    if (__workflow_openO365PowerShellRunspacecommandTypesToImportLocally != null)
                    {
                        openO365PowerShellRunspace["CommandTypesToImportLocally"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspacecommandTypesToImportLocally);
                        openO365PowerShellRunspacepropCount++;
                    }

                    openO365PowerShellRunspacepropCount++;
                }
                else
                {
                    openO365PowerShellRunspace["CommandTypesToImportLocally"] = "All";
                    openO365PowerShellRunspacepropCount++;
                }

                if (__workflow_openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV != null)
                {
                    openO365PowerShellRunspace["AdditionalCommandsToImportLocallyCSV"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV);
                    openO365PowerShellRunspacepropCount++;
                }

                openO365PowerShellRunspacepropCount++;
                openO365PowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceworkflow);
                if (openO365PowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = openO365PowerShellRunspace;
                }

                return new ApiConnectionAction<OpenO365PowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceWithCertificateResponse, ApiConnectionActionConfiguration> OpenO365PowerShellRunspaceWithCertificate(Expression<Func<string>> openO365PowerShellRunspaceWithCertificateapplicationId, Expression<Func<string>> openO365PowerShellRunspaceWithCertificatecertificateThumbprint, Expression<Func<string>> openO365PowerShellRunspaceWithCertificateorganization, Expression<Func<string>> openO365PowerShellRunspaceWithCertificateworkflow, Expression<Func<string>> openO365PowerShellRunspaceWithCertificateexchangeURL = null, Expression<Func<openO365PowerShellRunspaceWithCertificateconnectionMethodInput>> openO365PowerShellRunspaceWithCertificateconnectionMethod = null, Expression<Func<bool>> openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected = null, Expression<Func<openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocallyInput>> openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally = null, Expression<Func<string>> openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV = null)
        {
            var __workflow_openO365PowerShellRunspaceWithCertificateapplicationId = WorkflowExpression.Compile(openO365PowerShellRunspaceWithCertificateapplicationId, nameof(openO365PowerShellRunspaceWithCertificateapplicationId), required: true);
            var __workflow_openO365PowerShellRunspaceWithCertificatecertificateThumbprint = WorkflowExpression.Compile(openO365PowerShellRunspaceWithCertificatecertificateThumbprint, nameof(openO365PowerShellRunspaceWithCertificatecertificateThumbprint), required: true);
            var __workflow_openO365PowerShellRunspaceWithCertificateorganization = WorkflowExpression.Compile(openO365PowerShellRunspaceWithCertificateorganization, nameof(openO365PowerShellRunspaceWithCertificateorganization), required: true);
            var __workflow_openO365PowerShellRunspaceWithCertificateworkflow = WorkflowExpression.Compile(openO365PowerShellRunspaceWithCertificateworkflow, nameof(openO365PowerShellRunspaceWithCertificateworkflow), required: true);
            var __workflow_openO365PowerShellRunspaceWithCertificateexchangeURL = WorkflowExpression.Compile(openO365PowerShellRunspaceWithCertificateexchangeURL, nameof(openO365PowerShellRunspaceWithCertificateexchangeURL), required: false);
            var __workflow_openO365PowerShellRunspaceWithCertificateconnectionMethod = WorkflowExpression.Compile(openO365PowerShellRunspaceWithCertificateconnectionMethod, nameof(openO365PowerShellRunspaceWithCertificateconnectionMethod), required: false);
            var __workflow_openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected = WorkflowExpression.Compile(openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected, nameof(openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected), required: false);
            var __workflow_openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally = WorkflowExpression.Compile(openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally, nameof(openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally), required: false);
            var __workflow_openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV = WorkflowExpression.Compile(openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV, nameof(openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV), required: false);
            return new DeferredBodyAction<OpenO365PowerShellRunspaceWithCertificateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenO365PowerShellRunspaceWithCertificate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openO365PowerShellRunspaceWithCertificate = new JObject();
                var openO365PowerShellRunspaceWithCertificatepropCount = 0;
                openO365PowerShellRunspaceWithCertificatepropCount++;
                openO365PowerShellRunspaceWithCertificate["ApplicationId"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceWithCertificateapplicationId);
                openO365PowerShellRunspaceWithCertificatepropCount++;
                openO365PowerShellRunspaceWithCertificate["CertificateThumbprint"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceWithCertificatecertificateThumbprint);
                openO365PowerShellRunspaceWithCertificatepropCount++;
                openO365PowerShellRunspaceWithCertificate["Organization"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceWithCertificateorganization);
                if (__workflow_openO365PowerShellRunspaceWithCertificateexchangeURL != null)
                {
                    openO365PowerShellRunspaceWithCertificate["ExchangeURL"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceWithCertificateexchangeURL);
                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }

                if (__workflow_openO365PowerShellRunspaceWithCertificateconnectionMethod != null)
                {
                    if (__workflow_openO365PowerShellRunspaceWithCertificateconnectionMethod != null)
                    {
                        openO365PowerShellRunspaceWithCertificate["ConnectionMethod"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceWithCertificateconnectionMethod);
                        openO365PowerShellRunspaceWithCertificatepropCount++;
                    }

                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }
                else
                {
                    openO365PowerShellRunspaceWithCertificate["ConnectionMethod"] = "EXO V2";
                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }

                if (__workflow_openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected != null)
                {
                    if (__workflow_openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected != null)
                    {
                        openO365PowerShellRunspaceWithCertificate["OnlyConnectIfNotAlreadyConnected"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected);
                        openO365PowerShellRunspaceWithCertificatepropCount++;
                    }

                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }
                else
                {
                    openO365PowerShellRunspaceWithCertificate["OnlyConnectIfNotAlreadyConnected"] = true;
                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }

                if (__workflow_openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally != null)
                {
                    if (__workflow_openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally != null)
                    {
                        openO365PowerShellRunspaceWithCertificate["CommandTypesToImportLocally"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally);
                        openO365PowerShellRunspaceWithCertificatepropCount++;
                    }

                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }
                else
                {
                    openO365PowerShellRunspaceWithCertificate["CommandTypesToImportLocally"] = "All";
                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }

                if (__workflow_openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV != null)
                {
                    openO365PowerShellRunspaceWithCertificate["AdditionalCommandsToImportLocallyCSV"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV);
                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }

                openO365PowerShellRunspaceWithCertificatepropCount++;
                openO365PowerShellRunspaceWithCertificate["Workflow"] = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceWithCertificateworkflow);
                if (openO365PowerShellRunspaceWithCertificatepropCount > 0)
                {
                    callPayload.Body = openO365PowerShellRunspaceWithCertificate;
                }

                return new ApiConnectionAction<OpenO365PowerShellRunspaceWithCertificateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsO365PowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration> IsO365PowerShellRunspaceOpen(Expression<Func<string>> isO365PowerShellRunspaceOpenworkflow, Expression<Func<bool>> isO365PowerShellRunspaceOpentestCommunications = null, Expression<Func<bool>> isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
        {
            var __workflow_isO365PowerShellRunspaceOpenworkflow = WorkflowExpression.Compile(isO365PowerShellRunspaceOpenworkflow, nameof(isO365PowerShellRunspaceOpenworkflow), required: true);
            var __workflow_isO365PowerShellRunspaceOpentestCommunications = WorkflowExpression.Compile(isO365PowerShellRunspaceOpentestCommunications, nameof(isO365PowerShellRunspaceOpentestCommunications), required: false);
            var __workflow_isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID = WorkflowExpression.Compile(isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID, nameof(isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID), required: false);
            return new DeferredBodyAction<IsO365PowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/IsO365PowerShellRunspaceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isO365PowerShellRunspaceOpen = new JObject();
                var isO365PowerShellRunspaceOpenpropCount = 0;
                if (__workflow_isO365PowerShellRunspaceOpentestCommunications != null)
                {
                    if (__workflow_isO365PowerShellRunspaceOpentestCommunications != null)
                    {
                        isO365PowerShellRunspaceOpen["TestCommunications"] = ExpressionConverter.ConvertO(__workflow_isO365PowerShellRunspaceOpentestCommunications);
                        isO365PowerShellRunspaceOpenpropCount++;
                    }

                    isO365PowerShellRunspaceOpenpropCount++;
                }
                else
                {
                    isO365PowerShellRunspaceOpen["TestCommunications"] = true;
                    isO365PowerShellRunspaceOpenpropCount++;
                }

                if (__workflow_isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID != null)
                {
                    if (__workflow_isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID != null)
                    {
                        isO365PowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = ExpressionConverter.ConvertO(__workflow_isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID);
                        isO365PowerShellRunspaceOpenpropCount++;
                    }

                    isO365PowerShellRunspaceOpenpropCount++;
                }
                else
                {
                    isO365PowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = false;
                    isO365PowerShellRunspaceOpenpropCount++;
                }

                isO365PowerShellRunspaceOpenpropCount++;
                isO365PowerShellRunspaceOpen["Workflow"] = ExpressionConverter.ConvertO(__workflow_isO365PowerShellRunspaceOpenworkflow);
                if (isO365PowerShellRunspaceOpenpropCount > 0)
                {
                    callPayload.Body = isO365PowerShellRunspaceOpen;
                }

                return new ApiConnectionAction<IsO365PowerShellRunspaceOpenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunO365PowerShellAutomationScriptResponse, ApiConnectionActionConfiguration> RunO365PowerShellAutomationScript(Expression<Func<string>> runO365PowerShellAutomationScriptworkflow, Expression<Func<string>> runO365PowerShellAutomationScriptpowerShellScriptContents = null, Expression<Func<bool>> runO365PowerShellAutomationScriptisNoResultAnError = null, Expression<Func<bool>> runO365PowerShellAutomationScriptreturnComplexTypes = null, Expression<Func<bool>> runO365PowerShellAutomationScriptreturnBooleanAsBoolean = null, Expression<Func<bool>> runO365PowerShellAutomationScriptreturnNumericAsDecimal = null, Expression<Func<bool>> runO365PowerShellAutomationScriptreturnDateAsDate = null, Expression<Func<string>> runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, Expression<Func<bool>> runO365PowerShellAutomationScriptlocalScope = null, Expression<Func<bool>> runO365PowerShellAutomationScriptrunScriptAsThread = null, Expression<Func<int>> runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId = null, Expression<Func<int>> runO365PowerShellAutomationScriptsecondsToWaitForThread = null, Expression<Func<bool>> runO365PowerShellAutomationScriptscriptContainsStoredPassword = null, Expression<Func<bool>> runO365PowerShellAutomationScriptlogVerboseOutput = null, Expression<Func<string>> runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON = null, Expression<Func<string>> runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON = null, Expression<Func<runO365PowerShellAutomationScriptpowerShellCommandParametersInputItem[]>> runO365PowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            var __workflow_runO365PowerShellAutomationScriptworkflow = WorkflowExpression.Compile(runO365PowerShellAutomationScriptworkflow, nameof(runO365PowerShellAutomationScriptworkflow), required: true);
            var __workflow_runO365PowerShellAutomationScriptpowerShellScriptContents = WorkflowExpression.Compile(runO365PowerShellAutomationScriptpowerShellScriptContents, nameof(runO365PowerShellAutomationScriptpowerShellScriptContents), required: false);
            var __workflow_runO365PowerShellAutomationScriptisNoResultAnError = WorkflowExpression.Compile(runO365PowerShellAutomationScriptisNoResultAnError, nameof(runO365PowerShellAutomationScriptisNoResultAnError), required: false);
            var __workflow_runO365PowerShellAutomationScriptreturnComplexTypes = WorkflowExpression.Compile(runO365PowerShellAutomationScriptreturnComplexTypes, nameof(runO365PowerShellAutomationScriptreturnComplexTypes), required: false);
            var __workflow_runO365PowerShellAutomationScriptreturnBooleanAsBoolean = WorkflowExpression.Compile(runO365PowerShellAutomationScriptreturnBooleanAsBoolean, nameof(runO365PowerShellAutomationScriptreturnBooleanAsBoolean), required: false);
            var __workflow_runO365PowerShellAutomationScriptreturnNumericAsDecimal = WorkflowExpression.Compile(runO365PowerShellAutomationScriptreturnNumericAsDecimal, nameof(runO365PowerShellAutomationScriptreturnNumericAsDecimal), required: false);
            var __workflow_runO365PowerShellAutomationScriptreturnDateAsDate = WorkflowExpression.Compile(runO365PowerShellAutomationScriptreturnDateAsDate, nameof(runO365PowerShellAutomationScriptreturnDateAsDate), required: false);
            var __workflow_runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = WorkflowExpression.Compile(runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON, nameof(runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON), required: false);
            var __workflow_runO365PowerShellAutomationScriptlocalScope = WorkflowExpression.Compile(runO365PowerShellAutomationScriptlocalScope, nameof(runO365PowerShellAutomationScriptlocalScope), required: false);
            var __workflow_runO365PowerShellAutomationScriptrunScriptAsThread = WorkflowExpression.Compile(runO365PowerShellAutomationScriptrunScriptAsThread, nameof(runO365PowerShellAutomationScriptrunScriptAsThread), required: false);
            var __workflow_runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId = WorkflowExpression.Compile(runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId, nameof(runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId), required: false);
            var __workflow_runO365PowerShellAutomationScriptsecondsToWaitForThread = WorkflowExpression.Compile(runO365PowerShellAutomationScriptsecondsToWaitForThread, nameof(runO365PowerShellAutomationScriptsecondsToWaitForThread), required: false);
            var __workflow_runO365PowerShellAutomationScriptscriptContainsStoredPassword = WorkflowExpression.Compile(runO365PowerShellAutomationScriptscriptContainsStoredPassword, nameof(runO365PowerShellAutomationScriptscriptContainsStoredPassword), required: false);
            var __workflow_runO365PowerShellAutomationScriptlogVerboseOutput = WorkflowExpression.Compile(runO365PowerShellAutomationScriptlogVerboseOutput, nameof(runO365PowerShellAutomationScriptlogVerboseOutput), required: false);
            var __workflow_runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON = WorkflowExpression.Compile(runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON, nameof(runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON), required: false);
            var __workflow_runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON = WorkflowExpression.Compile(runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON, nameof(runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON), required: false);
            var __workflow_runO365PowerShellAutomationScriptpowerShellCommandParameters = WorkflowExpression.Compile(runO365PowerShellAutomationScriptpowerShellCommandParameters, nameof(runO365PowerShellAutomationScriptpowerShellCommandParameters), required: false);
            return new DeferredBodyAction<RunO365PowerShellAutomationScriptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/RunO365PowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runO365PowerShellAutomationScript = new JObject();
                var runO365PowerShellAutomationScriptpropCount = 0;
                if (__workflow_runO365PowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runO365PowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptpowerShellScriptContents);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (__workflow_runO365PowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runO365PowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptisNoResultAnError);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["IsNoResultAnError"] = false;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptreturnComplexTypes != null)
                {
                    if (__workflow_runO365PowerShellAutomationScriptreturnComplexTypes != null)
                    {
                        runO365PowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptreturnComplexTypes);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["ReturnComplexTypes"] = false;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptreturnBooleanAsBoolean != null)
                {
                    if (__workflow_runO365PowerShellAutomationScriptreturnBooleanAsBoolean != null)
                    {
                        runO365PowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptreturnBooleanAsBoolean);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["ReturnBooleanAsBoolean"] = false;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptreturnNumericAsDecimal != null)
                {
                    if (__workflow_runO365PowerShellAutomationScriptreturnNumericAsDecimal != null)
                    {
                        runO365PowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptreturnNumericAsDecimal);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["ReturnNumericAsDecimal"] = false;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptreturnDateAsDate != null)
                {
                    if (__workflow_runO365PowerShellAutomationScriptreturnDateAsDate != null)
                    {
                        runO365PowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptreturnDateAsDate);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["ReturnDateAsDate"] = false;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON != null)
                {
                    runO365PowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptlocalScope != null)
                {
                    runO365PowerShellAutomationScript["LocalScope"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptlocalScope);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (__workflow_runO365PowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runO365PowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptrunScriptAsThread);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["RunScriptAsThread"] = false;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId != null)
                {
                    runO365PowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (__workflow_runO365PowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runO365PowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptsecondsToWaitForThread);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["SecondsToWaitForThread"] = 90;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptscriptContainsStoredPassword != null)
                {
                    if (__workflow_runO365PowerShellAutomationScriptscriptContainsStoredPassword != null)
                    {
                        runO365PowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptscriptContainsStoredPassword);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["ScriptContainsStoredPassword"] = true;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptlogVerboseOutput != null)
                {
                    if (__workflow_runO365PowerShellAutomationScriptlogVerboseOutput != null)
                    {
                        runO365PowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptlogVerboseOutput);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["LogVerboseOutput"] = false;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON != null)
                {
                    runO365PowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runO365PowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (__workflow_runO365PowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runO365PowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptpowerShellCommandParameters);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                runO365PowerShellAutomationScriptpropCount++;
                runO365PowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScriptworkflow);
                if (runO365PowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runO365PowerShellAutomationScript;
                }

                return new ApiConnectionAction<RunO365PowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseO365PowerShellRunspaceResponse, ApiConnectionActionConfiguration> CloseO365PowerShellRunspace(Expression<Func<string>> closeO365PowerShellRunspaceworkflow)
        {
            var __workflow_closeO365PowerShellRunspaceworkflow = WorkflowExpression.Compile(closeO365PowerShellRunspaceworkflow, nameof(closeO365PowerShellRunspaceworkflow), required: true);
            return new DeferredBodyAction<CloseO365PowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/CloseO365PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var closeO365PowerShellRunspace = new JObject();
                var closeO365PowerShellRunspacepropCount = 0;
                closeO365PowerShellRunspacepropCount++;
                closeO365PowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(__workflow_closeO365PowerShellRunspaceworkflow);
                if (closeO365PowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = closeO365PowerShellRunspace;
                }

                return new ApiConnectionAction<CloseO365PowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetO365MailboxResponse, ApiConnectionActionConfiguration> O365GetO365Mailbox(Expression<Func<string>> o365GetO365Mailboxworkflow, Expression<Func<string>> o365GetO365Mailboxidentity = null, Expression<Func<string>> o365GetO365MailboxfilterPropertyName = null, Expression<Func<o365GetO365MailboxfilterPropertyComparisonInput>> o365GetO365MailboxfilterPropertyComparison = null, Expression<Func<string>> o365GetO365MailboxfilterPropertyValue = null, Expression<Func<o365GetO365MailboxrecipientTypeDetailsInput>> o365GetO365MailboxrecipientTypeDetails = null, Expression<Func<bool>> o365GetO365MailboxnoResultIsAnException = null)
        {
            var __workflow_o365GetO365Mailboxworkflow = WorkflowExpression.Compile(o365GetO365Mailboxworkflow, nameof(o365GetO365Mailboxworkflow), required: true);
            var __workflow_o365GetO365Mailboxidentity = WorkflowExpression.Compile(o365GetO365Mailboxidentity, nameof(o365GetO365Mailboxidentity), required: false);
            var __workflow_o365GetO365MailboxfilterPropertyName = WorkflowExpression.Compile(o365GetO365MailboxfilterPropertyName, nameof(o365GetO365MailboxfilterPropertyName), required: false);
            var __workflow_o365GetO365MailboxfilterPropertyComparison = WorkflowExpression.Compile(o365GetO365MailboxfilterPropertyComparison, nameof(o365GetO365MailboxfilterPropertyComparison), required: false);
            var __workflow_o365GetO365MailboxfilterPropertyValue = WorkflowExpression.Compile(o365GetO365MailboxfilterPropertyValue, nameof(o365GetO365MailboxfilterPropertyValue), required: false);
            var __workflow_o365GetO365MailboxrecipientTypeDetails = WorkflowExpression.Compile(o365GetO365MailboxrecipientTypeDetails, nameof(o365GetO365MailboxrecipientTypeDetails), required: false);
            var __workflow_o365GetO365MailboxnoResultIsAnException = WorkflowExpression.Compile(o365GetO365MailboxnoResultIsAnException, nameof(o365GetO365MailboxnoResultIsAnException), required: false);
            return new DeferredBodyAction<O365GetO365MailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365GetO365Mailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365GetO365Mailbox = new JObject();
                var o365GetO365MailboxpropCount = 0;
                if (__workflow_o365GetO365Mailboxidentity != null)
                {
                    o365GetO365Mailbox["Identity"] = ExpressionConverter.ConvertO(__workflow_o365GetO365Mailboxidentity);
                    o365GetO365MailboxpropCount++;
                }

                if (__workflow_o365GetO365MailboxfilterPropertyName != null)
                {
                    o365GetO365Mailbox["FilterPropertyName"] = ExpressionConverter.ConvertO(__workflow_o365GetO365MailboxfilterPropertyName);
                    o365GetO365MailboxpropCount++;
                }

                if (__workflow_o365GetO365MailboxfilterPropertyComparison != null)
                {
                    if (__workflow_o365GetO365MailboxfilterPropertyComparison != null)
                    {
                        o365GetO365Mailbox["FilterPropertyComparison"] = ExpressionConverter.ConvertO(__workflow_o365GetO365MailboxfilterPropertyComparison);
                        o365GetO365MailboxpropCount++;
                    }

                    o365GetO365MailboxpropCount++;
                }
                else
                {
                    o365GetO365Mailbox["FilterPropertyComparison"] = "Equals";
                    o365GetO365MailboxpropCount++;
                }

                if (__workflow_o365GetO365MailboxfilterPropertyValue != null)
                {
                    o365GetO365Mailbox["FilterPropertyValue"] = ExpressionConverter.ConvertO(__workflow_o365GetO365MailboxfilterPropertyValue);
                    o365GetO365MailboxpropCount++;
                }

                if (__workflow_o365GetO365MailboxrecipientTypeDetails != null)
                {
                    o365GetO365Mailbox["RecipientTypeDetails"] = ExpressionConverter.ConvertO(__workflow_o365GetO365MailboxrecipientTypeDetails);
                    o365GetO365MailboxpropCount++;
                }

                if (__workflow_o365GetO365MailboxnoResultIsAnException != null)
                {
                    if (__workflow_o365GetO365MailboxnoResultIsAnException != null)
                    {
                        o365GetO365Mailbox["NoResultIsAnException"] = ExpressionConverter.ConvertO(__workflow_o365GetO365MailboxnoResultIsAnException);
                        o365GetO365MailboxpropCount++;
                    }

                    o365GetO365MailboxpropCount++;
                }
                else
                {
                    o365GetO365Mailbox["NoResultIsAnException"] = false;
                    o365GetO365MailboxpropCount++;
                }

                o365GetO365MailboxpropCount++;
                o365GetO365Mailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365GetO365Mailboxworkflow);
                if (o365GetO365MailboxpropCount > 0)
                {
                    callPayload.Body = o365GetO365Mailbox;
                }

                return new ApiConnectionAction<O365GetO365MailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365AddMailboxPermissionResponse, ApiConnectionActionConfiguration> O365AddMailboxPermission(Expression<Func<string>> o365AddMailboxPermissionidentity, Expression<Func<string>> o365AddMailboxPermissionuser, Expression<Func<string>> o365AddMailboxPermissionaccessRights, Expression<Func<string>> o365AddMailboxPermissionworkflow, Expression<Func<bool>> o365AddMailboxPermissionautoMapping = null)
        {
            var __workflow_o365AddMailboxPermissionidentity = WorkflowExpression.Compile(o365AddMailboxPermissionidentity, nameof(o365AddMailboxPermissionidentity), required: true);
            var __workflow_o365AddMailboxPermissionuser = WorkflowExpression.Compile(o365AddMailboxPermissionuser, nameof(o365AddMailboxPermissionuser), required: true);
            var __workflow_o365AddMailboxPermissionaccessRights = WorkflowExpression.Compile(o365AddMailboxPermissionaccessRights, nameof(o365AddMailboxPermissionaccessRights), required: true);
            var __workflow_o365AddMailboxPermissionworkflow = WorkflowExpression.Compile(o365AddMailboxPermissionworkflow, nameof(o365AddMailboxPermissionworkflow), required: true);
            var __workflow_o365AddMailboxPermissionautoMapping = WorkflowExpression.Compile(o365AddMailboxPermissionautoMapping, nameof(o365AddMailboxPermissionautoMapping), required: false);
            return new DeferredBodyAction<O365AddMailboxPermissionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365AddMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365AddMailboxPermission = new JObject();
                var o365AddMailboxPermissionpropCount = 0;
                o365AddMailboxPermissionpropCount++;
                o365AddMailboxPermission["Identity"] = ExpressionConverter.ConvertO(__workflow_o365AddMailboxPermissionidentity);
                o365AddMailboxPermissionpropCount++;
                o365AddMailboxPermission["User"] = ExpressionConverter.ConvertO(__workflow_o365AddMailboxPermissionuser);
                o365AddMailboxPermissionpropCount++;
                o365AddMailboxPermission["AccessRights"] = ExpressionConverter.ConvertO(__workflow_o365AddMailboxPermissionaccessRights);
                if (__workflow_o365AddMailboxPermissionautoMapping != null)
                {
                    if (__workflow_o365AddMailboxPermissionautoMapping != null)
                    {
                        o365AddMailboxPermission["AutoMapping"] = ExpressionConverter.ConvertO(__workflow_o365AddMailboxPermissionautoMapping);
                        o365AddMailboxPermissionpropCount++;
                    }

                    o365AddMailboxPermissionpropCount++;
                }
                else
                {
                    o365AddMailboxPermission["AutoMapping"] = false;
                    o365AddMailboxPermissionpropCount++;
                }

                o365AddMailboxPermissionpropCount++;
                o365AddMailboxPermission["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365AddMailboxPermissionworkflow);
                if (o365AddMailboxPermissionpropCount > 0)
                {
                    callPayload.Body = o365AddMailboxPermission;
                }

                return new ApiConnectionAction<O365AddMailboxPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveMailboxPermissionResponse, ApiConnectionActionConfiguration> O365RemoveMailboxPermission(Expression<Func<string>> o365RemoveMailboxPermissionidentity, Expression<Func<string>> o365RemoveMailboxPermissionuser, Expression<Func<string>> o365RemoveMailboxPermissionaccessRights, Expression<Func<string>> o365RemoveMailboxPermissionworkflow)
        {
            var __workflow_o365RemoveMailboxPermissionidentity = WorkflowExpression.Compile(o365RemoveMailboxPermissionidentity, nameof(o365RemoveMailboxPermissionidentity), required: true);
            var __workflow_o365RemoveMailboxPermissionuser = WorkflowExpression.Compile(o365RemoveMailboxPermissionuser, nameof(o365RemoveMailboxPermissionuser), required: true);
            var __workflow_o365RemoveMailboxPermissionaccessRights = WorkflowExpression.Compile(o365RemoveMailboxPermissionaccessRights, nameof(o365RemoveMailboxPermissionaccessRights), required: true);
            var __workflow_o365RemoveMailboxPermissionworkflow = WorkflowExpression.Compile(o365RemoveMailboxPermissionworkflow, nameof(o365RemoveMailboxPermissionworkflow), required: true);
            return new DeferredBodyAction<O365RemoveMailboxPermissionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365RemoveMailboxPermission = new JObject();
                var o365RemoveMailboxPermissionpropCount = 0;
                o365RemoveMailboxPermissionpropCount++;
                o365RemoveMailboxPermission["Identity"] = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxPermissionidentity);
                o365RemoveMailboxPermissionpropCount++;
                o365RemoveMailboxPermission["User"] = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxPermissionuser);
                o365RemoveMailboxPermissionpropCount++;
                o365RemoveMailboxPermission["AccessRights"] = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxPermissionaccessRights);
                o365RemoveMailboxPermissionpropCount++;
                o365RemoveMailboxPermission["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxPermissionworkflow);
                if (o365RemoveMailboxPermissionpropCount > 0)
                {
                    callPayload.Body = o365RemoveMailboxPermission;
                }

                return new ApiConnectionAction<O365RemoveMailboxPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365AddDistributionGroupMemberResponse, ApiConnectionActionConfiguration> O365AddDistributionGroupMember(Expression<Func<string>> o365AddDistributionGroupMemberidentity, Expression<Func<string>> o365AddDistributionGroupMembermember, Expression<Func<string>> o365AddDistributionGroupMemberworkflow, Expression<Func<bool>> o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck = null)
        {
            var __workflow_o365AddDistributionGroupMemberidentity = WorkflowExpression.Compile(o365AddDistributionGroupMemberidentity, nameof(o365AddDistributionGroupMemberidentity), required: true);
            var __workflow_o365AddDistributionGroupMembermember = WorkflowExpression.Compile(o365AddDistributionGroupMembermember, nameof(o365AddDistributionGroupMembermember), required: true);
            var __workflow_o365AddDistributionGroupMemberworkflow = WorkflowExpression.Compile(o365AddDistributionGroupMemberworkflow, nameof(o365AddDistributionGroupMemberworkflow), required: true);
            var __workflow_o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck = WorkflowExpression.Compile(o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck, nameof(o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck), required: false);
            return new DeferredBodyAction<O365AddDistributionGroupMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365AddDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365AddDistributionGroupMember = new JObject();
                var o365AddDistributionGroupMemberpropCount = 0;
                o365AddDistributionGroupMemberpropCount++;
                o365AddDistributionGroupMember["Identity"] = ExpressionConverter.ConvertO(__workflow_o365AddDistributionGroupMemberidentity);
                o365AddDistributionGroupMemberpropCount++;
                o365AddDistributionGroupMember["Member"] = ExpressionConverter.ConvertO(__workflow_o365AddDistributionGroupMembermember);
                if (__workflow_o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                {
                    if (__workflow_o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                    {
                        o365AddDistributionGroupMember["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(__workflow_o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck);
                        o365AddDistributionGroupMemberpropCount++;
                    }

                    o365AddDistributionGroupMemberpropCount++;
                }
                else
                {
                    o365AddDistributionGroupMember["BypassSecurityGroupManagerCheck"] = false;
                    o365AddDistributionGroupMemberpropCount++;
                }

                o365AddDistributionGroupMemberpropCount++;
                o365AddDistributionGroupMember["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365AddDistributionGroupMemberworkflow);
                if (o365AddDistributionGroupMemberpropCount > 0)
                {
                    callPayload.Body = o365AddDistributionGroupMember;
                }

                return new ApiConnectionAction<O365AddDistributionGroupMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetO365DistributionGroupResponse, ApiConnectionActionConfiguration> O365GetO365DistributionGroup(Expression<Func<string>> o365GetO365DistributionGroupworkflow, Expression<Func<string>> o365GetO365DistributionGroupidentity = null, Expression<Func<string>> o365GetO365DistributionGroupfilterPropertyName = null, Expression<Func<o365GetO365DistributionGroupfilterPropertyComparisonInput>> o365GetO365DistributionGroupfilterPropertyComparison = null, Expression<Func<string>> o365GetO365DistributionGroupfilterPropertyValue = null, Expression<Func<bool>> o365GetO365DistributionGroupnoResultIsAnException = null)
        {
            var __workflow_o365GetO365DistributionGroupworkflow = WorkflowExpression.Compile(o365GetO365DistributionGroupworkflow, nameof(o365GetO365DistributionGroupworkflow), required: true);
            var __workflow_o365GetO365DistributionGroupidentity = WorkflowExpression.Compile(o365GetO365DistributionGroupidentity, nameof(o365GetO365DistributionGroupidentity), required: false);
            var __workflow_o365GetO365DistributionGroupfilterPropertyName = WorkflowExpression.Compile(o365GetO365DistributionGroupfilterPropertyName, nameof(o365GetO365DistributionGroupfilterPropertyName), required: false);
            var __workflow_o365GetO365DistributionGroupfilterPropertyComparison = WorkflowExpression.Compile(o365GetO365DistributionGroupfilterPropertyComparison, nameof(o365GetO365DistributionGroupfilterPropertyComparison), required: false);
            var __workflow_o365GetO365DistributionGroupfilterPropertyValue = WorkflowExpression.Compile(o365GetO365DistributionGroupfilterPropertyValue, nameof(o365GetO365DistributionGroupfilterPropertyValue), required: false);
            var __workflow_o365GetO365DistributionGroupnoResultIsAnException = WorkflowExpression.Compile(o365GetO365DistributionGroupnoResultIsAnException, nameof(o365GetO365DistributionGroupnoResultIsAnException), required: false);
            return new DeferredBodyAction<O365GetO365DistributionGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365GetO365DistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365GetO365DistributionGroup = new JObject();
                var o365GetO365DistributionGrouppropCount = 0;
                if (__workflow_o365GetO365DistributionGroupidentity != null)
                {
                    o365GetO365DistributionGroup["Identity"] = ExpressionConverter.ConvertO(__workflow_o365GetO365DistributionGroupidentity);
                    o365GetO365DistributionGrouppropCount++;
                }

                if (__workflow_o365GetO365DistributionGroupfilterPropertyName != null)
                {
                    o365GetO365DistributionGroup["FilterPropertyName"] = ExpressionConverter.ConvertO(__workflow_o365GetO365DistributionGroupfilterPropertyName);
                    o365GetO365DistributionGrouppropCount++;
                }

                if (__workflow_o365GetO365DistributionGroupfilterPropertyComparison != null)
                {
                    if (__workflow_o365GetO365DistributionGroupfilterPropertyComparison != null)
                    {
                        o365GetO365DistributionGroup["FilterPropertyComparison"] = ExpressionConverter.ConvertO(__workflow_o365GetO365DistributionGroupfilterPropertyComparison);
                        o365GetO365DistributionGrouppropCount++;
                    }

                    o365GetO365DistributionGrouppropCount++;
                }
                else
                {
                    o365GetO365DistributionGroup["FilterPropertyComparison"] = "Equals";
                    o365GetO365DistributionGrouppropCount++;
                }

                if (__workflow_o365GetO365DistributionGroupfilterPropertyValue != null)
                {
                    o365GetO365DistributionGroup["FilterPropertyValue"] = ExpressionConverter.ConvertO(__workflow_o365GetO365DistributionGroupfilterPropertyValue);
                    o365GetO365DistributionGrouppropCount++;
                }

                if (__workflow_o365GetO365DistributionGroupnoResultIsAnException != null)
                {
                    if (__workflow_o365GetO365DistributionGroupnoResultIsAnException != null)
                    {
                        o365GetO365DistributionGroup["NoResultIsAnException"] = ExpressionConverter.ConvertO(__workflow_o365GetO365DistributionGroupnoResultIsAnException);
                        o365GetO365DistributionGrouppropCount++;
                    }

                    o365GetO365DistributionGrouppropCount++;
                }
                else
                {
                    o365GetO365DistributionGroup["NoResultIsAnException"] = false;
                    o365GetO365DistributionGrouppropCount++;
                }

                o365GetO365DistributionGrouppropCount++;
                o365GetO365DistributionGroup["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365GetO365DistributionGroupworkflow);
                if (o365GetO365DistributionGrouppropCount > 0)
                {
                    callPayload.Body = o365GetO365DistributionGroup;
                }

                return new ApiConnectionAction<O365GetO365DistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewO365DistributionGroupResponse, ApiConnectionActionConfiguration> O365NewO365DistributionGroup(Expression<Func<string>> o365NewO365DistributionGroupname, Expression<Func<string>> o365NewO365DistributionGroupworkflow, Expression<Func<string>> o365NewO365DistributionGroupalias = null, Expression<Func<string>> o365NewO365DistributionGroupdisplayName = null, Expression<Func<string>> o365NewO365DistributionGroupnotes = null, Expression<Func<string>> o365NewO365DistributionGroupmanagedBy = null, Expression<Func<string>> o365NewO365DistributionGroupmembers = null, Expression<Func<string>> o365NewO365DistributionGrouporganizationalUnit = null, Expression<Func<string>> o365NewO365DistributionGroupprimarySmtpAddress = null, Expression<Func<o365NewO365DistributionGroupmemberDepartRestrictionInput>> o365NewO365DistributionGroupmemberDepartRestriction = null, Expression<Func<o365NewO365DistributionGroupmemberJoinRestrictionInput>> o365NewO365DistributionGroupmemberJoinRestriction = null, Expression<Func<bool>> o365NewO365DistributionGrouprequireSenderAuthenticationEnabled = null, Expression<Func<o365NewO365DistributionGrouptypeInput>> o365NewO365DistributionGrouptype = null)
        {
            var __workflow_o365NewO365DistributionGroupname = WorkflowExpression.Compile(o365NewO365DistributionGroupname, nameof(o365NewO365DistributionGroupname), required: true);
            var __workflow_o365NewO365DistributionGroupworkflow = WorkflowExpression.Compile(o365NewO365DistributionGroupworkflow, nameof(o365NewO365DistributionGroupworkflow), required: true);
            var __workflow_o365NewO365DistributionGroupalias = WorkflowExpression.Compile(o365NewO365DistributionGroupalias, nameof(o365NewO365DistributionGroupalias), required: false);
            var __workflow_o365NewO365DistributionGroupdisplayName = WorkflowExpression.Compile(o365NewO365DistributionGroupdisplayName, nameof(o365NewO365DistributionGroupdisplayName), required: false);
            var __workflow_o365NewO365DistributionGroupnotes = WorkflowExpression.Compile(o365NewO365DistributionGroupnotes, nameof(o365NewO365DistributionGroupnotes), required: false);
            var __workflow_o365NewO365DistributionGroupmanagedBy = WorkflowExpression.Compile(o365NewO365DistributionGroupmanagedBy, nameof(o365NewO365DistributionGroupmanagedBy), required: false);
            var __workflow_o365NewO365DistributionGroupmembers = WorkflowExpression.Compile(o365NewO365DistributionGroupmembers, nameof(o365NewO365DistributionGroupmembers), required: false);
            var __workflow_o365NewO365DistributionGrouporganizationalUnit = WorkflowExpression.Compile(o365NewO365DistributionGrouporganizationalUnit, nameof(o365NewO365DistributionGrouporganizationalUnit), required: false);
            var __workflow_o365NewO365DistributionGroupprimarySmtpAddress = WorkflowExpression.Compile(o365NewO365DistributionGroupprimarySmtpAddress, nameof(o365NewO365DistributionGroupprimarySmtpAddress), required: false);
            var __workflow_o365NewO365DistributionGroupmemberDepartRestriction = WorkflowExpression.Compile(o365NewO365DistributionGroupmemberDepartRestriction, nameof(o365NewO365DistributionGroupmemberDepartRestriction), required: false);
            var __workflow_o365NewO365DistributionGroupmemberJoinRestriction = WorkflowExpression.Compile(o365NewO365DistributionGroupmemberJoinRestriction, nameof(o365NewO365DistributionGroupmemberJoinRestriction), required: false);
            var __workflow_o365NewO365DistributionGrouprequireSenderAuthenticationEnabled = WorkflowExpression.Compile(o365NewO365DistributionGrouprequireSenderAuthenticationEnabled, nameof(o365NewO365DistributionGrouprequireSenderAuthenticationEnabled), required: false);
            var __workflow_o365NewO365DistributionGrouptype = WorkflowExpression.Compile(o365NewO365DistributionGrouptype, nameof(o365NewO365DistributionGrouptype), required: false);
            return new DeferredBodyAction<O365NewO365DistributionGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365NewO365DistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365NewO365DistributionGroup = new JObject();
                var o365NewO365DistributionGrouppropCount = 0;
                o365NewO365DistributionGrouppropCount++;
                o365NewO365DistributionGroup["Name"] = ExpressionConverter.ConvertO(__workflow_o365NewO365DistributionGroupname);
                if (__workflow_o365NewO365DistributionGroupalias != null)
                {
                    o365NewO365DistributionGroup["Alias"] = ExpressionConverter.ConvertO(__workflow_o365NewO365DistributionGroupalias);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (__workflow_o365NewO365DistributionGroupdisplayName != null)
                {
                    o365NewO365DistributionGroup["DisplayName"] = ExpressionConverter.ConvertO(__workflow_o365NewO365DistributionGroupdisplayName);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (__workflow_o365NewO365DistributionGroupnotes != null)
                {
                    o365NewO365DistributionGroup["Notes"] = ExpressionConverter.ConvertO(__workflow_o365NewO365DistributionGroupnotes);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (__workflow_o365NewO365DistributionGroupmanagedBy != null)
                {
                    o365NewO365DistributionGroup["ManagedBy"] = ExpressionConverter.ConvertO(__workflow_o365NewO365DistributionGroupmanagedBy);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (__workflow_o365NewO365DistributionGroupmembers != null)
                {
                    o365NewO365DistributionGroup["Members"] = ExpressionConverter.ConvertO(__workflow_o365NewO365DistributionGroupmembers);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (__workflow_o365NewO365DistributionGrouporganizationalUnit != null)
                {
                    o365NewO365DistributionGroup["OrganizationalUnit"] = ExpressionConverter.ConvertO(__workflow_o365NewO365DistributionGrouporganizationalUnit);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (__workflow_o365NewO365DistributionGroupprimarySmtpAddress != null)
                {
                    o365NewO365DistributionGroup["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(__workflow_o365NewO365DistributionGroupprimarySmtpAddress);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (__workflow_o365NewO365DistributionGroupmemberDepartRestriction != null)
                {
                    if (__workflow_o365NewO365DistributionGroupmemberDepartRestriction != null)
                    {
                        o365NewO365DistributionGroup["MemberDepartRestriction"] = ExpressionConverter.ConvertO(__workflow_o365NewO365DistributionGroupmemberDepartRestriction);
                        o365NewO365DistributionGrouppropCount++;
                    }

                    o365NewO365DistributionGrouppropCount++;
                }
                else
                {
                    o365NewO365DistributionGroup["MemberDepartRestriction"] = "Open";
                    o365NewO365DistributionGrouppropCount++;
                }

                if (__workflow_o365NewO365DistributionGroupmemberJoinRestriction != null)
                {
                    if (__workflow_o365NewO365DistributionGroupmemberJoinRestriction != null)
                    {
                        o365NewO365DistributionGroup["MemberJoinRestriction"] = ExpressionConverter.ConvertO(__workflow_o365NewO365DistributionGroupmemberJoinRestriction);
                        o365NewO365DistributionGrouppropCount++;
                    }

                    o365NewO365DistributionGrouppropCount++;
                }
                else
                {
                    o365NewO365DistributionGroup["MemberJoinRestriction"] = "Closed";
                    o365NewO365DistributionGrouppropCount++;
                }

                if (__workflow_o365NewO365DistributionGrouprequireSenderAuthenticationEnabled != null)
                {
                    if (__workflow_o365NewO365DistributionGrouprequireSenderAuthenticationEnabled != null)
                    {
                        o365NewO365DistributionGroup["RequireSenderAuthenticationEnabled"] = ExpressionConverter.ConvertO(__workflow_o365NewO365DistributionGrouprequireSenderAuthenticationEnabled);
                        o365NewO365DistributionGrouppropCount++;
                    }

                    o365NewO365DistributionGrouppropCount++;
                }
                else
                {
                    o365NewO365DistributionGroup["RequireSenderAuthenticationEnabled"] = false;
                    o365NewO365DistributionGrouppropCount++;
                }

                if (__workflow_o365NewO365DistributionGrouptype != null)
                {
                    o365NewO365DistributionGroup["Type"] = ExpressionConverter.ConvertO(__workflow_o365NewO365DistributionGrouptype);
                    o365NewO365DistributionGrouppropCount++;
                }

                o365NewO365DistributionGrouppropCount++;
                o365NewO365DistributionGroup["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365NewO365DistributionGroupworkflow);
                if (o365NewO365DistributionGrouppropCount > 0)
                {
                    callPayload.Body = o365NewO365DistributionGroup;
                }

                return new ApiConnectionAction<O365NewO365DistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveDistributionGroupResponse, ApiConnectionActionConfiguration> O365RemoveDistributionGroup(Expression<Func<string>> o365RemoveDistributionGroupidentity, Expression<Func<string>> o365RemoveDistributionGroupworkflow, Expression<Func<bool>> o365RemoveDistributionGroupbypassSecurityGroupManagerCheck = null, Expression<Func<bool>> o365RemoveDistributionGrouperrorIfGroupDoesNotExist = null)
        {
            var __workflow_o365RemoveDistributionGroupidentity = WorkflowExpression.Compile(o365RemoveDistributionGroupidentity, nameof(o365RemoveDistributionGroupidentity), required: true);
            var __workflow_o365RemoveDistributionGroupworkflow = WorkflowExpression.Compile(o365RemoveDistributionGroupworkflow, nameof(o365RemoveDistributionGroupworkflow), required: true);
            var __workflow_o365RemoveDistributionGroupbypassSecurityGroupManagerCheck = WorkflowExpression.Compile(o365RemoveDistributionGroupbypassSecurityGroupManagerCheck, nameof(o365RemoveDistributionGroupbypassSecurityGroupManagerCheck), required: false);
            var __workflow_o365RemoveDistributionGrouperrorIfGroupDoesNotExist = WorkflowExpression.Compile(o365RemoveDistributionGrouperrorIfGroupDoesNotExist, nameof(o365RemoveDistributionGrouperrorIfGroupDoesNotExist), required: false);
            return new DeferredBodyAction<O365RemoveDistributionGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365RemoveDistributionGroup = new JObject();
                var o365RemoveDistributionGrouppropCount = 0;
                o365RemoveDistributionGrouppropCount++;
                o365RemoveDistributionGroup["Identity"] = ExpressionConverter.ConvertO(__workflow_o365RemoveDistributionGroupidentity);
                if (__workflow_o365RemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
                {
                    if (__workflow_o365RemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
                    {
                        o365RemoveDistributionGroup["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(__workflow_o365RemoveDistributionGroupbypassSecurityGroupManagerCheck);
                        o365RemoveDistributionGrouppropCount++;
                    }

                    o365RemoveDistributionGrouppropCount++;
                }
                else
                {
                    o365RemoveDistributionGroup["BypassSecurityGroupManagerCheck"] = true;
                    o365RemoveDistributionGrouppropCount++;
                }

                if (__workflow_o365RemoveDistributionGrouperrorIfGroupDoesNotExist != null)
                {
                    if (__workflow_o365RemoveDistributionGrouperrorIfGroupDoesNotExist != null)
                    {
                        o365RemoveDistributionGroup["ErrorIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(__workflow_o365RemoveDistributionGrouperrorIfGroupDoesNotExist);
                        o365RemoveDistributionGrouppropCount++;
                    }

                    o365RemoveDistributionGrouppropCount++;
                }
                else
                {
                    o365RemoveDistributionGroup["ErrorIfGroupDoesNotExist"] = false;
                    o365RemoveDistributionGrouppropCount++;
                }

                o365RemoveDistributionGrouppropCount++;
                o365RemoveDistributionGroup["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365RemoveDistributionGroupworkflow);
                if (o365RemoveDistributionGrouppropCount > 0)
                {
                    callPayload.Body = o365RemoveDistributionGroup;
                }

                return new ApiConnectionAction<O365RemoveDistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365SetO365MailboxResponse, ApiConnectionActionConfiguration> O365SetO365Mailbox(Expression<Func<string>> o365SetO365Mailboxidentity, Expression<Func<string>> o365SetO365Mailboxworkflow, Expression<Func<bool>> o365SetO365MailboxaccountDisabled = null, Expression<Func<string>> o365SetO365Mailboxalias = null, Expression<Func<string>> o365SetO365MailboxdisplayName = null, Expression<Func<bool>> o365SetO365MailboxhiddenFromAddressListsEnabled = null, Expression<Func<string>> o365SetO365MailboxcustomAttribute1 = null, Expression<Func<string>> o365SetO365MailboxcustomAttribute2 = null, Expression<Func<string>> o365SetO365MailboxcustomAttribute3 = null, Expression<Func<string>> o365SetO365MailboxcustomAttribute4 = null, Expression<Func<o365SetO365MailboxtypeInput>> o365SetO365Mailboxtype = null)
        {
            var __workflow_o365SetO365Mailboxidentity = WorkflowExpression.Compile(o365SetO365Mailboxidentity, nameof(o365SetO365Mailboxidentity), required: true);
            var __workflow_o365SetO365Mailboxworkflow = WorkflowExpression.Compile(o365SetO365Mailboxworkflow, nameof(o365SetO365Mailboxworkflow), required: true);
            var __workflow_o365SetO365MailboxaccountDisabled = WorkflowExpression.Compile(o365SetO365MailboxaccountDisabled, nameof(o365SetO365MailboxaccountDisabled), required: false);
            var __workflow_o365SetO365Mailboxalias = WorkflowExpression.Compile(o365SetO365Mailboxalias, nameof(o365SetO365Mailboxalias), required: false);
            var __workflow_o365SetO365MailboxdisplayName = WorkflowExpression.Compile(o365SetO365MailboxdisplayName, nameof(o365SetO365MailboxdisplayName), required: false);
            var __workflow_o365SetO365MailboxhiddenFromAddressListsEnabled = WorkflowExpression.Compile(o365SetO365MailboxhiddenFromAddressListsEnabled, nameof(o365SetO365MailboxhiddenFromAddressListsEnabled), required: false);
            var __workflow_o365SetO365MailboxcustomAttribute1 = WorkflowExpression.Compile(o365SetO365MailboxcustomAttribute1, nameof(o365SetO365MailboxcustomAttribute1), required: false);
            var __workflow_o365SetO365MailboxcustomAttribute2 = WorkflowExpression.Compile(o365SetO365MailboxcustomAttribute2, nameof(o365SetO365MailboxcustomAttribute2), required: false);
            var __workflow_o365SetO365MailboxcustomAttribute3 = WorkflowExpression.Compile(o365SetO365MailboxcustomAttribute3, nameof(o365SetO365MailboxcustomAttribute3), required: false);
            var __workflow_o365SetO365MailboxcustomAttribute4 = WorkflowExpression.Compile(o365SetO365MailboxcustomAttribute4, nameof(o365SetO365MailboxcustomAttribute4), required: false);
            var __workflow_o365SetO365Mailboxtype = WorkflowExpression.Compile(o365SetO365Mailboxtype, nameof(o365SetO365Mailboxtype), required: false);
            return new DeferredBodyAction<O365SetO365MailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365SetO365Mailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365SetO365Mailbox = new JObject();
                var o365SetO365MailboxpropCount = 0;
                o365SetO365MailboxpropCount++;
                o365SetO365Mailbox["Identity"] = ExpressionConverter.ConvertO(__workflow_o365SetO365Mailboxidentity);
                if (__workflow_o365SetO365MailboxaccountDisabled != null)
                {
                    o365SetO365Mailbox["AccountDisabled"] = ExpressionConverter.ConvertO(__workflow_o365SetO365MailboxaccountDisabled);
                    o365SetO365MailboxpropCount++;
                }

                if (__workflow_o365SetO365Mailboxalias != null)
                {
                    o365SetO365Mailbox["Alias"] = ExpressionConverter.ConvertO(__workflow_o365SetO365Mailboxalias);
                    o365SetO365MailboxpropCount++;
                }

                if (__workflow_o365SetO365MailboxdisplayName != null)
                {
                    o365SetO365Mailbox["DisplayName"] = ExpressionConverter.ConvertO(__workflow_o365SetO365MailboxdisplayName);
                    o365SetO365MailboxpropCount++;
                }

                if (__workflow_o365SetO365MailboxhiddenFromAddressListsEnabled != null)
                {
                    o365SetO365Mailbox["HiddenFromAddressListsEnabled"] = ExpressionConverter.ConvertO(__workflow_o365SetO365MailboxhiddenFromAddressListsEnabled);
                    o365SetO365MailboxpropCount++;
                }

                if (__workflow_o365SetO365MailboxcustomAttribute1 != null)
                {
                    o365SetO365Mailbox["CustomAttribute1"] = ExpressionConverter.ConvertO(__workflow_o365SetO365MailboxcustomAttribute1);
                    o365SetO365MailboxpropCount++;
                }

                if (__workflow_o365SetO365MailboxcustomAttribute2 != null)
                {
                    o365SetO365Mailbox["CustomAttribute2"] = ExpressionConverter.ConvertO(__workflow_o365SetO365MailboxcustomAttribute2);
                    o365SetO365MailboxpropCount++;
                }

                if (__workflow_o365SetO365MailboxcustomAttribute3 != null)
                {
                    o365SetO365Mailbox["CustomAttribute3"] = ExpressionConverter.ConvertO(__workflow_o365SetO365MailboxcustomAttribute3);
                    o365SetO365MailboxpropCount++;
                }

                if (__workflow_o365SetO365MailboxcustomAttribute4 != null)
                {
                    o365SetO365Mailbox["CustomAttribute4"] = ExpressionConverter.ConvertO(__workflow_o365SetO365MailboxcustomAttribute4);
                    o365SetO365MailboxpropCount++;
                }

                if (__workflow_o365SetO365Mailboxtype != null)
                {
                    o365SetO365Mailbox["Type"] = ExpressionConverter.ConvertO(__workflow_o365SetO365Mailboxtype);
                    o365SetO365MailboxpropCount++;
                }

                o365SetO365MailboxpropCount++;
                o365SetO365Mailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365SetO365Mailboxworkflow);
                if (o365SetO365MailboxpropCount > 0)
                {
                    callPayload.Body = o365SetO365Mailbox;
                }

                return new ApiConnectionAction<O365SetO365MailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365WaitForO365MailboxResponse, ApiConnectionActionConfiguration> O365WaitForO365Mailbox(Expression<Func<string>> o365WaitForO365Mailboxidentity, Expression<Func<int>> o365WaitForO365MailboxnumberOfTimesToCheck, Expression<Func<int>> o365WaitForO365MailboxsecondsBetweenTries, Expression<Func<string>> o365WaitForO365Mailboxworkflow, Expression<Func<o365WaitForO365MailboxrecipientTypeDetailsInput>> o365WaitForO365MailboxrecipientTypeDetails = null)
        {
            var __workflow_o365WaitForO365Mailboxidentity = WorkflowExpression.Compile(o365WaitForO365Mailboxidentity, nameof(o365WaitForO365Mailboxidentity), required: true);
            var __workflow_o365WaitForO365MailboxnumberOfTimesToCheck = WorkflowExpression.Compile(o365WaitForO365MailboxnumberOfTimesToCheck, nameof(o365WaitForO365MailboxnumberOfTimesToCheck), required: true);
            var __workflow_o365WaitForO365MailboxsecondsBetweenTries = WorkflowExpression.Compile(o365WaitForO365MailboxsecondsBetweenTries, nameof(o365WaitForO365MailboxsecondsBetweenTries), required: true);
            var __workflow_o365WaitForO365Mailboxworkflow = WorkflowExpression.Compile(o365WaitForO365Mailboxworkflow, nameof(o365WaitForO365Mailboxworkflow), required: true);
            var __workflow_o365WaitForO365MailboxrecipientTypeDetails = WorkflowExpression.Compile(o365WaitForO365MailboxrecipientTypeDetails, nameof(o365WaitForO365MailboxrecipientTypeDetails), required: false);
            return new DeferredBodyAction<O365WaitForO365MailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365WaitForO365Mailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365WaitForO365Mailbox = new JObject();
                var o365WaitForO365MailboxpropCount = 0;
                o365WaitForO365MailboxpropCount++;
                o365WaitForO365Mailbox["Identity"] = ExpressionConverter.ConvertO(__workflow_o365WaitForO365Mailboxidentity);
                if (__workflow_o365WaitForO365MailboxrecipientTypeDetails != null)
                {
                    o365WaitForO365Mailbox["RecipientTypeDetails"] = ExpressionConverter.ConvertO(__workflow_o365WaitForO365MailboxrecipientTypeDetails);
                    o365WaitForO365MailboxpropCount++;
                }

                o365WaitForO365MailboxpropCount++;
                o365WaitForO365Mailbox["NumberOfTimesToCheck"] = ExpressionConverter.ConvertO(__workflow_o365WaitForO365MailboxnumberOfTimesToCheck);
                o365WaitForO365MailboxpropCount++;
                o365WaitForO365Mailbox["SecondsBetweenTries"] = ExpressionConverter.ConvertO(__workflow_o365WaitForO365MailboxsecondsBetweenTries);
                o365WaitForO365MailboxpropCount++;
                o365WaitForO365Mailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365WaitForO365Mailboxworkflow);
                if (o365WaitForO365MailboxpropCount > 0)
                {
                    callPayload.Body = o365WaitForO365Mailbox;
                }

                return new ApiConnectionAction<O365WaitForO365MailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365SetO365MailboxAutoReplyConfigurationResponse, ApiConnectionActionConfiguration> O365SetO365MailboxAutoReplyConfiguration(Expression<Func<string>> o365SetO365MailboxAutoReplyConfigurationidentity, Expression<Func<o365SetO365MailboxAutoReplyConfigurationautoReplyStateInput>> o365SetO365MailboxAutoReplyConfigurationautoReplyState, Expression<Func<string>> o365SetO365MailboxAutoReplyConfigurationworkflow, Expression<Func<string>> o365SetO365MailboxAutoReplyConfigurationinternalMessage = null, Expression<Func<o365SetO365MailboxAutoReplyConfigurationexternalAudienceInput>> o365SetO365MailboxAutoReplyConfigurationexternalAudience = null, Expression<Func<string>> o365SetO365MailboxAutoReplyConfigurationexternalMessage = null)
        {
            var __workflow_o365SetO365MailboxAutoReplyConfigurationidentity = WorkflowExpression.Compile(o365SetO365MailboxAutoReplyConfigurationidentity, nameof(o365SetO365MailboxAutoReplyConfigurationidentity), required: true);
            var __workflow_o365SetO365MailboxAutoReplyConfigurationautoReplyState = WorkflowExpression.Compile(o365SetO365MailboxAutoReplyConfigurationautoReplyState, nameof(o365SetO365MailboxAutoReplyConfigurationautoReplyState), required: true);
            var __workflow_o365SetO365MailboxAutoReplyConfigurationworkflow = WorkflowExpression.Compile(o365SetO365MailboxAutoReplyConfigurationworkflow, nameof(o365SetO365MailboxAutoReplyConfigurationworkflow), required: true);
            var __workflow_o365SetO365MailboxAutoReplyConfigurationinternalMessage = WorkflowExpression.Compile(o365SetO365MailboxAutoReplyConfigurationinternalMessage, nameof(o365SetO365MailboxAutoReplyConfigurationinternalMessage), required: false);
            var __workflow_o365SetO365MailboxAutoReplyConfigurationexternalAudience = WorkflowExpression.Compile(o365SetO365MailboxAutoReplyConfigurationexternalAudience, nameof(o365SetO365MailboxAutoReplyConfigurationexternalAudience), required: false);
            var __workflow_o365SetO365MailboxAutoReplyConfigurationexternalMessage = WorkflowExpression.Compile(o365SetO365MailboxAutoReplyConfigurationexternalMessage, nameof(o365SetO365MailboxAutoReplyConfigurationexternalMessage), required: false);
            return new DeferredBodyAction<O365SetO365MailboxAutoReplyConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365SetO365MailboxAutoReplyConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365SetO365MailboxAutoReplyConfiguration = new JObject();
                var o365SetO365MailboxAutoReplyConfigurationpropCount = 0;
                o365SetO365MailboxAutoReplyConfigurationpropCount++;
                o365SetO365MailboxAutoReplyConfiguration["Identity"] = ExpressionConverter.ConvertO(__workflow_o365SetO365MailboxAutoReplyConfigurationidentity);
                o365SetO365MailboxAutoReplyConfigurationpropCount++;
                o365SetO365MailboxAutoReplyConfiguration["AutoReplyState"] = ExpressionConverter.ConvertO(__workflow_o365SetO365MailboxAutoReplyConfigurationautoReplyState);
                if (__workflow_o365SetO365MailboxAutoReplyConfigurationinternalMessage != null)
                {
                    o365SetO365MailboxAutoReplyConfiguration["InternalMessage"] = ExpressionConverter.ConvertO(__workflow_o365SetO365MailboxAutoReplyConfigurationinternalMessage);
                    o365SetO365MailboxAutoReplyConfigurationpropCount++;
                }

                if (__workflow_o365SetO365MailboxAutoReplyConfigurationexternalAudience != null)
                {
                    if (__workflow_o365SetO365MailboxAutoReplyConfigurationexternalAudience != null)
                    {
                        o365SetO365MailboxAutoReplyConfiguration["ExternalAudience"] = ExpressionConverter.ConvertO(__workflow_o365SetO365MailboxAutoReplyConfigurationexternalAudience);
                        o365SetO365MailboxAutoReplyConfigurationpropCount++;
                    }

                    o365SetO365MailboxAutoReplyConfigurationpropCount++;
                }
                else
                {
                    o365SetO365MailboxAutoReplyConfiguration["ExternalAudience"] = "All";
                    o365SetO365MailboxAutoReplyConfigurationpropCount++;
                }

                if (__workflow_o365SetO365MailboxAutoReplyConfigurationexternalMessage != null)
                {
                    o365SetO365MailboxAutoReplyConfiguration["ExternalMessage"] = ExpressionConverter.ConvertO(__workflow_o365SetO365MailboxAutoReplyConfigurationexternalMessage);
                    o365SetO365MailboxAutoReplyConfigurationpropCount++;
                }

                o365SetO365MailboxAutoReplyConfigurationpropCount++;
                o365SetO365MailboxAutoReplyConfiguration["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365SetO365MailboxAutoReplyConfigurationworkflow);
                if (o365SetO365MailboxAutoReplyConfigurationpropCount > 0)
                {
                    callPayload.Body = o365SetO365MailboxAutoReplyConfiguration;
                }

                return new ApiConnectionAction<O365SetO365MailboxAutoReplyConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveDistributionGroupMemberResponse, ApiConnectionActionConfiguration> O365RemoveDistributionGroupMember(Expression<Func<string>> o365RemoveDistributionGroupMembergroupIdentity, Expression<Func<string>> o365RemoveDistributionGroupMembermember, Expression<Func<string>> o365RemoveDistributionGroupMemberworkflow, Expression<Func<bool>> o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck = null, Expression<Func<bool>> o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup = null)
        {
            var __workflow_o365RemoveDistributionGroupMembergroupIdentity = WorkflowExpression.Compile(o365RemoveDistributionGroupMembergroupIdentity, nameof(o365RemoveDistributionGroupMembergroupIdentity), required: true);
            var __workflow_o365RemoveDistributionGroupMembermember = WorkflowExpression.Compile(o365RemoveDistributionGroupMembermember, nameof(o365RemoveDistributionGroupMembermember), required: true);
            var __workflow_o365RemoveDistributionGroupMemberworkflow = WorkflowExpression.Compile(o365RemoveDistributionGroupMemberworkflow, nameof(o365RemoveDistributionGroupMemberworkflow), required: true);
            var __workflow_o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck = WorkflowExpression.Compile(o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck, nameof(o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck), required: false);
            var __workflow_o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup = WorkflowExpression.Compile(o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup, nameof(o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup), required: false);
            return new DeferredBodyAction<O365RemoveDistributionGroupMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365RemoveDistributionGroupMember = new JObject();
                var o365RemoveDistributionGroupMemberpropCount = 0;
                o365RemoveDistributionGroupMemberpropCount++;
                o365RemoveDistributionGroupMember["GroupIdentity"] = ExpressionConverter.ConvertO(__workflow_o365RemoveDistributionGroupMembergroupIdentity);
                o365RemoveDistributionGroupMemberpropCount++;
                o365RemoveDistributionGroupMember["Member"] = ExpressionConverter.ConvertO(__workflow_o365RemoveDistributionGroupMembermember);
                if (__workflow_o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                {
                    if (__workflow_o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                    {
                        o365RemoveDistributionGroupMember["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(__workflow_o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck);
                        o365RemoveDistributionGroupMemberpropCount++;
                    }

                    o365RemoveDistributionGroupMemberpropCount++;
                }
                else
                {
                    o365RemoveDistributionGroupMember["BypassSecurityGroupManagerCheck"] = true;
                    o365RemoveDistributionGroupMemberpropCount++;
                }

                if (__workflow_o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup != null)
                {
                    if (__workflow_o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup != null)
                    {
                        o365RemoveDistributionGroupMember["ExceptionIfMemberNotInGroup"] = ExpressionConverter.ConvertO(__workflow_o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup);
                        o365RemoveDistributionGroupMemberpropCount++;
                    }

                    o365RemoveDistributionGroupMemberpropCount++;
                }
                else
                {
                    o365RemoveDistributionGroupMember["ExceptionIfMemberNotInGroup"] = false;
                    o365RemoveDistributionGroupMemberpropCount++;
                }

                o365RemoveDistributionGroupMemberpropCount++;
                o365RemoveDistributionGroupMember["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365RemoveDistributionGroupMemberworkflow);
                if (o365RemoveDistributionGroupMemberpropCount > 0)
                {
                    callPayload.Body = o365RemoveDistributionGroupMember;
                }

                return new ApiConnectionAction<O365RemoveDistributionGroupMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetMailboxDistributionGroupMembershipResponse, ApiConnectionActionConfiguration> O365GetMailboxDistributionGroupMembership(Expression<Func<string>> o365GetMailboxDistributionGroupMembershipmailboxIdentity, Expression<Func<string>> o365GetMailboxDistributionGroupMembershipworkflow, Expression<Func<string>> o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON = null)
        {
            var __workflow_o365GetMailboxDistributionGroupMembershipmailboxIdentity = WorkflowExpression.Compile(o365GetMailboxDistributionGroupMembershipmailboxIdentity, nameof(o365GetMailboxDistributionGroupMembershipmailboxIdentity), required: true);
            var __workflow_o365GetMailboxDistributionGroupMembershipworkflow = WorkflowExpression.Compile(o365GetMailboxDistributionGroupMembershipworkflow, nameof(o365GetMailboxDistributionGroupMembershipworkflow), required: true);
            var __workflow_o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON = WorkflowExpression.Compile(o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON, nameof(o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON), required: false);
            return new DeferredBodyAction<O365GetMailboxDistributionGroupMembershipResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365GetMailboxDistributionGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365GetMailboxDistributionGroupMembership = new JObject();
                var o365GetMailboxDistributionGroupMembershippropCount = 0;
                o365GetMailboxDistributionGroupMembershippropCount++;
                o365GetMailboxDistributionGroupMembership["MailboxIdentity"] = ExpressionConverter.ConvertO(__workflow_o365GetMailboxDistributionGroupMembershipmailboxIdentity);
                if (__workflow_o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON != null)
                {
                    o365GetMailboxDistributionGroupMembership["PropertiesToRetrieveJSON"] = ExpressionConverter.ConvertO(__workflow_o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON);
                    o365GetMailboxDistributionGroupMembershippropCount++;
                }

                o365GetMailboxDistributionGroupMembershippropCount++;
                o365GetMailboxDistributionGroupMembership["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365GetMailboxDistributionGroupMembershipworkflow);
                if (o365GetMailboxDistributionGroupMembershippropCount > 0)
                {
                    callPayload.Body = o365GetMailboxDistributionGroupMembership;
                }

                return new ApiConnectionAction<O365GetMailboxDistributionGroupMembershipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetDistributionGroupMembersResponse, ApiConnectionActionConfiguration> O365GetDistributionGroupMembers(Expression<Func<string>> o365GetDistributionGroupMembersgroupIdentity, Expression<Func<string>> o365GetDistributionGroupMembersworkflow, Expression<Func<string>> o365GetDistributionGroupMemberspropertiesToRetrieveJSON = null)
        {
            var __workflow_o365GetDistributionGroupMembersgroupIdentity = WorkflowExpression.Compile(o365GetDistributionGroupMembersgroupIdentity, nameof(o365GetDistributionGroupMembersgroupIdentity), required: true);
            var __workflow_o365GetDistributionGroupMembersworkflow = WorkflowExpression.Compile(o365GetDistributionGroupMembersworkflow, nameof(o365GetDistributionGroupMembersworkflow), required: true);
            var __workflow_o365GetDistributionGroupMemberspropertiesToRetrieveJSON = WorkflowExpression.Compile(o365GetDistributionGroupMemberspropertiesToRetrieveJSON, nameof(o365GetDistributionGroupMemberspropertiesToRetrieveJSON), required: false);
            return new DeferredBodyAction<O365GetDistributionGroupMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365GetDistributionGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365GetDistributionGroupMembers = new JObject();
                var o365GetDistributionGroupMemberspropCount = 0;
                o365GetDistributionGroupMemberspropCount++;
                o365GetDistributionGroupMembers["GroupIdentity"] = ExpressionConverter.ConvertO(__workflow_o365GetDistributionGroupMembersgroupIdentity);
                if (__workflow_o365GetDistributionGroupMemberspropertiesToRetrieveJSON != null)
                {
                    o365GetDistributionGroupMembers["PropertiesToRetrieveJSON"] = ExpressionConverter.ConvertO(__workflow_o365GetDistributionGroupMemberspropertiesToRetrieveJSON);
                    o365GetDistributionGroupMemberspropCount++;
                }

                o365GetDistributionGroupMemberspropCount++;
                o365GetDistributionGroupMembers["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365GetDistributionGroupMembersworkflow);
                if (o365GetDistributionGroupMemberspropCount > 0)
                {
                    callPayload.Body = o365GetDistributionGroupMembers;
                }

                return new ApiConnectionAction<O365GetDistributionGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveMailboxFromAllDistributionGroupsResponse, ApiConnectionActionConfiguration> O365RemoveMailboxFromAllDistributionGroups(Expression<Func<string>> o365RemoveMailboxFromAllDistributionGroupsworkflow, Expression<Func<string>> o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity = null, Expression<Func<bool>> o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck = null, Expression<Func<bool>> o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove = null, Expression<Func<bool>> o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove = null, Expression<Func<string>> o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON = null, Expression<Func<bool>> o365RemoveMailboxFromAllDistributionGroupsrunAsThread = null, Expression<Func<int>> o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId = null, Expression<Func<int>> o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread = null)
        {
            var __workflow_o365RemoveMailboxFromAllDistributionGroupsworkflow = WorkflowExpression.Compile(o365RemoveMailboxFromAllDistributionGroupsworkflow, nameof(o365RemoveMailboxFromAllDistributionGroupsworkflow), required: true);
            var __workflow_o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity = WorkflowExpression.Compile(o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity, nameof(o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity), required: false);
            var __workflow_o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck = WorkflowExpression.Compile(o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck, nameof(o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck), required: false);
            var __workflow_o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove = WorkflowExpression.Compile(o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove, nameof(o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove), required: false);
            var __workflow_o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove = WorkflowExpression.Compile(o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove, nameof(o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove), required: false);
            var __workflow_o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON = WorkflowExpression.Compile(o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON, nameof(o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON), required: false);
            var __workflow_o365RemoveMailboxFromAllDistributionGroupsrunAsThread = WorkflowExpression.Compile(o365RemoveMailboxFromAllDistributionGroupsrunAsThread, nameof(o365RemoveMailboxFromAllDistributionGroupsrunAsThread), required: false);
            var __workflow_o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId = WorkflowExpression.Compile(o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId, nameof(o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId), required: false);
            var __workflow_o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread = WorkflowExpression.Compile(o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread, nameof(o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread), required: false);
            return new DeferredBodyAction<O365RemoveMailboxFromAllDistributionGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveMailboxFromAllDistributionGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365RemoveMailboxFromAllDistributionGroups = new JObject();
                var o365RemoveMailboxFromAllDistributionGroupspropCount = 0;
                if (__workflow_o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity != null)
                {
                    o365RemoveMailboxFromAllDistributionGroups["MailboxIdentity"] = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity);
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (__workflow_o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck != null)
                {
                    if (__workflow_o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck != null)
                    {
                        o365RemoveMailboxFromAllDistributionGroups["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck);
                        o365RemoveMailboxFromAllDistributionGroupspropCount++;
                    }

                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }
                else
                {
                    o365RemoveMailboxFromAllDistributionGroups["BypassSecurityGroupManagerCheck"] = true;
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (__workflow_o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove != null)
                {
                    if (__workflow_o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove != null)
                    {
                        o365RemoveMailboxFromAllDistributionGroups["ExceptionIfAnyGroupsFailToRemove"] = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove);
                        o365RemoveMailboxFromAllDistributionGroupspropCount++;
                    }

                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }
                else
                {
                    o365RemoveMailboxFromAllDistributionGroups["ExceptionIfAnyGroupsFailToRemove"] = false;
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (__workflow_o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove != null)
                {
                    if (__workflow_o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove != null)
                    {
                        o365RemoveMailboxFromAllDistributionGroups["ExceptionIfAllGroupsFailToRemove"] = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove);
                        o365RemoveMailboxFromAllDistributionGroupspropCount++;
                    }

                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }
                else
                {
                    o365RemoveMailboxFromAllDistributionGroups["ExceptionIfAllGroupsFailToRemove"] = true;
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (__workflow_o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON != null)
                {
                    o365RemoveMailboxFromAllDistributionGroups["GroupDNsToExcludeJSON"] = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON);
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (__workflow_o365RemoveMailboxFromAllDistributionGroupsrunAsThread != null)
                {
                    if (__workflow_o365RemoveMailboxFromAllDistributionGroupsrunAsThread != null)
                    {
                        o365RemoveMailboxFromAllDistributionGroups["RunAsThread"] = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxFromAllDistributionGroupsrunAsThread);
                        o365RemoveMailboxFromAllDistributionGroupspropCount++;
                    }

                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }
                else
                {
                    o365RemoveMailboxFromAllDistributionGroups["RunAsThread"] = false;
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (__workflow_o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId != null)
                {
                    o365RemoveMailboxFromAllDistributionGroups["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId);
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (__workflow_o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread != null)
                {
                    if (__workflow_o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread != null)
                    {
                        o365RemoveMailboxFromAllDistributionGroups["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread);
                        o365RemoveMailboxFromAllDistributionGroupspropCount++;
                    }

                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }
                else
                {
                    o365RemoveMailboxFromAllDistributionGroups["SecondsToWaitForThread"] = 90;
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                o365RemoveMailboxFromAllDistributionGroupspropCount++;
                o365RemoveMailboxFromAllDistributionGroups["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxFromAllDistributionGroupsworkflow);
                if (o365RemoveMailboxFromAllDistributionGroupspropCount > 0)
                {
                    callPayload.Body = o365RemoveMailboxFromAllDistributionGroups;
                }

                return new ApiConnectionAction<O365RemoveMailboxFromAllDistributionGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewMailboxResponse, ApiConnectionActionConfiguration> O365NewMailbox(Expression<Func<string>> o365NewMailboxmicrosoftOnlineServicesID, Expression<Func<string>> o365NewMailboxname, Expression<Func<string>> o365NewMailboxworkflow, Expression<Func<string>> o365NewMailboxfirstName = null, Expression<Func<string>> o365NewMailboxlastName = null, Expression<Func<string>> o365NewMailboxinitials = null, Expression<Func<string>> o365NewMailboxdisplayName = null, Expression<Func<string>> o365NewMailboxalias = null, Expression<Func<string>> o365NewMailboxprimarySmtpAddress = null, Expression<Func<string>> o365NewMailboxpassword = null, Expression<Func<bool>> o365NewMailboxaccountPasswordIsStoredPassword = null, Expression<Func<bool>> o365NewMailboxresetPasswordOnNextLogon = null, Expression<Func<bool>> o365NewMailboxarchive = null, Expression<Func<string>> o365NewMailboxmailboxPlan = null, Expression<Func<string>> o365NewMailboxmailboxRegion = null)
        {
            var __workflow_o365NewMailboxmicrosoftOnlineServicesID = WorkflowExpression.Compile(o365NewMailboxmicrosoftOnlineServicesID, nameof(o365NewMailboxmicrosoftOnlineServicesID), required: true);
            var __workflow_o365NewMailboxname = WorkflowExpression.Compile(o365NewMailboxname, nameof(o365NewMailboxname), required: true);
            var __workflow_o365NewMailboxworkflow = WorkflowExpression.Compile(o365NewMailboxworkflow, nameof(o365NewMailboxworkflow), required: true);
            var __workflow_o365NewMailboxfirstName = WorkflowExpression.Compile(o365NewMailboxfirstName, nameof(o365NewMailboxfirstName), required: false);
            var __workflow_o365NewMailboxlastName = WorkflowExpression.Compile(o365NewMailboxlastName, nameof(o365NewMailboxlastName), required: false);
            var __workflow_o365NewMailboxinitials = WorkflowExpression.Compile(o365NewMailboxinitials, nameof(o365NewMailboxinitials), required: false);
            var __workflow_o365NewMailboxdisplayName = WorkflowExpression.Compile(o365NewMailboxdisplayName, nameof(o365NewMailboxdisplayName), required: false);
            var __workflow_o365NewMailboxalias = WorkflowExpression.Compile(o365NewMailboxalias, nameof(o365NewMailboxalias), required: false);
            var __workflow_o365NewMailboxprimarySmtpAddress = WorkflowExpression.Compile(o365NewMailboxprimarySmtpAddress, nameof(o365NewMailboxprimarySmtpAddress), required: false);
            var __workflow_o365NewMailboxpassword = WorkflowExpression.Compile(o365NewMailboxpassword, nameof(o365NewMailboxpassword), required: false);
            var __workflow_o365NewMailboxaccountPasswordIsStoredPassword = WorkflowExpression.Compile(o365NewMailboxaccountPasswordIsStoredPassword, nameof(o365NewMailboxaccountPasswordIsStoredPassword), required: false);
            var __workflow_o365NewMailboxresetPasswordOnNextLogon = WorkflowExpression.Compile(o365NewMailboxresetPasswordOnNextLogon, nameof(o365NewMailboxresetPasswordOnNextLogon), required: false);
            var __workflow_o365NewMailboxarchive = WorkflowExpression.Compile(o365NewMailboxarchive, nameof(o365NewMailboxarchive), required: false);
            var __workflow_o365NewMailboxmailboxPlan = WorkflowExpression.Compile(o365NewMailboxmailboxPlan, nameof(o365NewMailboxmailboxPlan), required: false);
            var __workflow_o365NewMailboxmailboxRegion = WorkflowExpression.Compile(o365NewMailboxmailboxRegion, nameof(o365NewMailboxmailboxRegion), required: false);
            return new DeferredBodyAction<O365NewMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365NewMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365NewMailbox = new JObject();
                var o365NewMailboxpropCount = 0;
                o365NewMailboxpropCount++;
                o365NewMailbox["MicrosoftOnlineServicesID"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxmicrosoftOnlineServicesID);
                o365NewMailboxpropCount++;
                o365NewMailbox["Name"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxname);
                if (__workflow_o365NewMailboxfirstName != null)
                {
                    o365NewMailbox["FirstName"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxfirstName);
                    o365NewMailboxpropCount++;
                }

                if (__workflow_o365NewMailboxlastName != null)
                {
                    o365NewMailbox["LastName"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxlastName);
                    o365NewMailboxpropCount++;
                }

                if (__workflow_o365NewMailboxinitials != null)
                {
                    o365NewMailbox["Initials"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxinitials);
                    o365NewMailboxpropCount++;
                }

                if (__workflow_o365NewMailboxdisplayName != null)
                {
                    o365NewMailbox["DisplayName"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxdisplayName);
                    o365NewMailboxpropCount++;
                }

                if (__workflow_o365NewMailboxalias != null)
                {
                    o365NewMailbox["Alias"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxalias);
                    o365NewMailboxpropCount++;
                }

                if (__workflow_o365NewMailboxprimarySmtpAddress != null)
                {
                    o365NewMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxprimarySmtpAddress);
                    o365NewMailboxpropCount++;
                }

                if (__workflow_o365NewMailboxpassword != null)
                {
                    o365NewMailbox["Password"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxpassword);
                    o365NewMailboxpropCount++;
                }

                if (__workflow_o365NewMailboxaccountPasswordIsStoredPassword != null)
                {
                    if (__workflow_o365NewMailboxaccountPasswordIsStoredPassword != null)
                    {
                        o365NewMailbox["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxaccountPasswordIsStoredPassword);
                        o365NewMailboxpropCount++;
                    }

                    o365NewMailboxpropCount++;
                }
                else
                {
                    o365NewMailbox["AccountPasswordIsStoredPassword"] = false;
                    o365NewMailboxpropCount++;
                }

                if (__workflow_o365NewMailboxresetPasswordOnNextLogon != null)
                {
                    if (__workflow_o365NewMailboxresetPasswordOnNextLogon != null)
                    {
                        o365NewMailbox["ResetPasswordOnNextLogon"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxresetPasswordOnNextLogon);
                        o365NewMailboxpropCount++;
                    }

                    o365NewMailboxpropCount++;
                }
                else
                {
                    o365NewMailbox["ResetPasswordOnNextLogon"] = true;
                    o365NewMailboxpropCount++;
                }

                if (__workflow_o365NewMailboxarchive != null)
                {
                    if (__workflow_o365NewMailboxarchive != null)
                    {
                        o365NewMailbox["Archive"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxarchive);
                        o365NewMailboxpropCount++;
                    }

                    o365NewMailboxpropCount++;
                }
                else
                {
                    o365NewMailbox["Archive"] = false;
                    o365NewMailboxpropCount++;
                }

                if (__workflow_o365NewMailboxmailboxPlan != null)
                {
                    o365NewMailbox["MailboxPlan"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxmailboxPlan);
                    o365NewMailboxpropCount++;
                }

                if (__workflow_o365NewMailboxmailboxRegion != null)
                {
                    o365NewMailbox["MailboxRegion"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxmailboxRegion);
                    o365NewMailboxpropCount++;
                }

                o365NewMailboxpropCount++;
                o365NewMailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365NewMailboxworkflow);
                if (o365NewMailboxpropCount > 0)
                {
                    callPayload.Body = o365NewMailbox;
                }

                return new ApiConnectionAction<O365NewMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewSharedMailboxResponse, ApiConnectionActionConfiguration> O365NewSharedMailbox(Expression<Func<string>> o365NewSharedMailboxname, Expression<Func<string>> o365NewSharedMailboxworkflow, Expression<Func<string>> o365NewSharedMailboxfirstName = null, Expression<Func<string>> o365NewSharedMailboxlastName = null, Expression<Func<string>> o365NewSharedMailboxinitials = null, Expression<Func<string>> o365NewSharedMailboxdisplayName = null, Expression<Func<string>> o365NewSharedMailboxalias = null, Expression<Func<string>> o365NewSharedMailboxprimarySmtpAddress = null, Expression<Func<bool>> o365NewSharedMailboxarchive = null, Expression<Func<string>> o365NewSharedMailboxmailboxRegion = null)
        {
            var __workflow_o365NewSharedMailboxname = WorkflowExpression.Compile(o365NewSharedMailboxname, nameof(o365NewSharedMailboxname), required: true);
            var __workflow_o365NewSharedMailboxworkflow = WorkflowExpression.Compile(o365NewSharedMailboxworkflow, nameof(o365NewSharedMailboxworkflow), required: true);
            var __workflow_o365NewSharedMailboxfirstName = WorkflowExpression.Compile(o365NewSharedMailboxfirstName, nameof(o365NewSharedMailboxfirstName), required: false);
            var __workflow_o365NewSharedMailboxlastName = WorkflowExpression.Compile(o365NewSharedMailboxlastName, nameof(o365NewSharedMailboxlastName), required: false);
            var __workflow_o365NewSharedMailboxinitials = WorkflowExpression.Compile(o365NewSharedMailboxinitials, nameof(o365NewSharedMailboxinitials), required: false);
            var __workflow_o365NewSharedMailboxdisplayName = WorkflowExpression.Compile(o365NewSharedMailboxdisplayName, nameof(o365NewSharedMailboxdisplayName), required: false);
            var __workflow_o365NewSharedMailboxalias = WorkflowExpression.Compile(o365NewSharedMailboxalias, nameof(o365NewSharedMailboxalias), required: false);
            var __workflow_o365NewSharedMailboxprimarySmtpAddress = WorkflowExpression.Compile(o365NewSharedMailboxprimarySmtpAddress, nameof(o365NewSharedMailboxprimarySmtpAddress), required: false);
            var __workflow_o365NewSharedMailboxarchive = WorkflowExpression.Compile(o365NewSharedMailboxarchive, nameof(o365NewSharedMailboxarchive), required: false);
            var __workflow_o365NewSharedMailboxmailboxRegion = WorkflowExpression.Compile(o365NewSharedMailboxmailboxRegion, nameof(o365NewSharedMailboxmailboxRegion), required: false);
            return new DeferredBodyAction<O365NewSharedMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365NewSharedMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365NewSharedMailbox = new JObject();
                var o365NewSharedMailboxpropCount = 0;
                o365NewSharedMailboxpropCount++;
                o365NewSharedMailbox["Name"] = ExpressionConverter.ConvertO(__workflow_o365NewSharedMailboxname);
                if (__workflow_o365NewSharedMailboxfirstName != null)
                {
                    o365NewSharedMailbox["FirstName"] = ExpressionConverter.ConvertO(__workflow_o365NewSharedMailboxfirstName);
                    o365NewSharedMailboxpropCount++;
                }

                if (__workflow_o365NewSharedMailboxlastName != null)
                {
                    o365NewSharedMailbox["LastName"] = ExpressionConverter.ConvertO(__workflow_o365NewSharedMailboxlastName);
                    o365NewSharedMailboxpropCount++;
                }

                if (__workflow_o365NewSharedMailboxinitials != null)
                {
                    o365NewSharedMailbox["Initials"] = ExpressionConverter.ConvertO(__workflow_o365NewSharedMailboxinitials);
                    o365NewSharedMailboxpropCount++;
                }

                if (__workflow_o365NewSharedMailboxdisplayName != null)
                {
                    o365NewSharedMailbox["DisplayName"] = ExpressionConverter.ConvertO(__workflow_o365NewSharedMailboxdisplayName);
                    o365NewSharedMailboxpropCount++;
                }

                if (__workflow_o365NewSharedMailboxalias != null)
                {
                    o365NewSharedMailbox["Alias"] = ExpressionConverter.ConvertO(__workflow_o365NewSharedMailboxalias);
                    o365NewSharedMailboxpropCount++;
                }

                if (__workflow_o365NewSharedMailboxprimarySmtpAddress != null)
                {
                    o365NewSharedMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(__workflow_o365NewSharedMailboxprimarySmtpAddress);
                    o365NewSharedMailboxpropCount++;
                }

                if (__workflow_o365NewSharedMailboxarchive != null)
                {
                    if (__workflow_o365NewSharedMailboxarchive != null)
                    {
                        o365NewSharedMailbox["Archive"] = ExpressionConverter.ConvertO(__workflow_o365NewSharedMailboxarchive);
                        o365NewSharedMailboxpropCount++;
                    }

                    o365NewSharedMailboxpropCount++;
                }
                else
                {
                    o365NewSharedMailbox["Archive"] = false;
                    o365NewSharedMailboxpropCount++;
                }

                if (__workflow_o365NewSharedMailboxmailboxRegion != null)
                {
                    o365NewSharedMailbox["MailboxRegion"] = ExpressionConverter.ConvertO(__workflow_o365NewSharedMailboxmailboxRegion);
                    o365NewSharedMailboxpropCount++;
                }

                o365NewSharedMailboxpropCount++;
                o365NewSharedMailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365NewSharedMailboxworkflow);
                if (o365NewSharedMailboxpropCount > 0)
                {
                    callPayload.Body = o365NewSharedMailbox;
                }

                return new ApiConnectionAction<O365NewSharedMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365EnableArchiveMailboxResponse, ApiConnectionActionConfiguration> O365EnableArchiveMailbox(Expression<Func<string>> o365EnableArchiveMailboxidentity, Expression<Func<string>> o365EnableArchiveMailboxworkflow, Expression<Func<bool>> o365EnableArchiveMailboxcheckIfArchiveExists = null, Expression<Func<string>> o365EnableArchiveMailboxarchiveName = null, Expression<Func<bool>> o365EnableArchiveMailboxautoExpandingArchive = null)
        {
            var __workflow_o365EnableArchiveMailboxidentity = WorkflowExpression.Compile(o365EnableArchiveMailboxidentity, nameof(o365EnableArchiveMailboxidentity), required: true);
            var __workflow_o365EnableArchiveMailboxworkflow = WorkflowExpression.Compile(o365EnableArchiveMailboxworkflow, nameof(o365EnableArchiveMailboxworkflow), required: true);
            var __workflow_o365EnableArchiveMailboxcheckIfArchiveExists = WorkflowExpression.Compile(o365EnableArchiveMailboxcheckIfArchiveExists, nameof(o365EnableArchiveMailboxcheckIfArchiveExists), required: false);
            var __workflow_o365EnableArchiveMailboxarchiveName = WorkflowExpression.Compile(o365EnableArchiveMailboxarchiveName, nameof(o365EnableArchiveMailboxarchiveName), required: false);
            var __workflow_o365EnableArchiveMailboxautoExpandingArchive = WorkflowExpression.Compile(o365EnableArchiveMailboxautoExpandingArchive, nameof(o365EnableArchiveMailboxautoExpandingArchive), required: false);
            return new DeferredBodyAction<O365EnableArchiveMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365EnableArchiveMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365EnableArchiveMailbox = new JObject();
                var o365EnableArchiveMailboxpropCount = 0;
                o365EnableArchiveMailboxpropCount++;
                o365EnableArchiveMailbox["Identity"] = ExpressionConverter.ConvertO(__workflow_o365EnableArchiveMailboxidentity);
                if (__workflow_o365EnableArchiveMailboxcheckIfArchiveExists != null)
                {
                    if (__workflow_o365EnableArchiveMailboxcheckIfArchiveExists != null)
                    {
                        o365EnableArchiveMailbox["CheckIfArchiveExists"] = ExpressionConverter.ConvertO(__workflow_o365EnableArchiveMailboxcheckIfArchiveExists);
                        o365EnableArchiveMailboxpropCount++;
                    }

                    o365EnableArchiveMailboxpropCount++;
                }
                else
                {
                    o365EnableArchiveMailbox["CheckIfArchiveExists"] = true;
                    o365EnableArchiveMailboxpropCount++;
                }

                if (__workflow_o365EnableArchiveMailboxarchiveName != null)
                {
                    o365EnableArchiveMailbox["ArchiveName"] = ExpressionConverter.ConvertO(__workflow_o365EnableArchiveMailboxarchiveName);
                    o365EnableArchiveMailboxpropCount++;
                }

                if (__workflow_o365EnableArchiveMailboxautoExpandingArchive != null)
                {
                    if (__workflow_o365EnableArchiveMailboxautoExpandingArchive != null)
                    {
                        o365EnableArchiveMailbox["AutoExpandingArchive"] = ExpressionConverter.ConvertO(__workflow_o365EnableArchiveMailboxautoExpandingArchive);
                        o365EnableArchiveMailboxpropCount++;
                    }

                    o365EnableArchiveMailboxpropCount++;
                }
                else
                {
                    o365EnableArchiveMailbox["AutoExpandingArchive"] = false;
                    o365EnableArchiveMailboxpropCount++;
                }

                o365EnableArchiveMailboxpropCount++;
                o365EnableArchiveMailbox["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365EnableArchiveMailboxworkflow);
                if (o365EnableArchiveMailboxpropCount > 0)
                {
                    callPayload.Body = o365EnableArchiveMailbox;
                }

                return new ApiConnectionAction<O365EnableArchiveMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365DoesMailboxHaveAnArchiveResponse, ApiConnectionActionConfiguration> O365DoesMailboxHaveAnArchive(Expression<Func<string>> o365DoesMailboxHaveAnArchiveidentity, Expression<Func<string>> o365DoesMailboxHaveAnArchiveworkflow)
        {
            var __workflow_o365DoesMailboxHaveAnArchiveidentity = WorkflowExpression.Compile(o365DoesMailboxHaveAnArchiveidentity, nameof(o365DoesMailboxHaveAnArchiveidentity), required: true);
            var __workflow_o365DoesMailboxHaveAnArchiveworkflow = WorkflowExpression.Compile(o365DoesMailboxHaveAnArchiveworkflow, nameof(o365DoesMailboxHaveAnArchiveworkflow), required: true);
            return new DeferredBodyAction<O365DoesMailboxHaveAnArchiveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365DoesMailboxHaveAnArchive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365DoesMailboxHaveAnArchive = new JObject();
                var o365DoesMailboxHaveAnArchivepropCount = 0;
                o365DoesMailboxHaveAnArchivepropCount++;
                o365DoesMailboxHaveAnArchive["Identity"] = ExpressionConverter.ConvertO(__workflow_o365DoesMailboxHaveAnArchiveidentity);
                o365DoesMailboxHaveAnArchivepropCount++;
                o365DoesMailboxHaveAnArchive["Workflow"] = ExpressionConverter.ConvertO(__workflow_o365DoesMailboxHaveAnArchiveworkflow);
                if (o365DoesMailboxHaveAnArchivepropCount > 0)
                {
                    callPayload.Body = o365DoesMailboxHaveAnArchive;
                }

                return new ApiConnectionAction<O365DoesMailboxHaveAnArchiveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<JMLGetNextAvailableAccountNameResponse, ApiConnectionActionConfiguration> JMLGetNextAvailableAccountName(Expression<Func<string>> jMLGetNextAvailableAccountNameworkflow, Expression<Func<string>> jMLGetNextAvailableAccountNamefirstName = null, Expression<Func<string>> jMLGetNextAvailableAccountNamemiddleName = null, Expression<Func<string>> jMLGetNextAvailableAccountNamelastName = null, Expression<Func<string>> jMLGetNextAvailableAccountNamefieldA = null, Expression<Func<string>> jMLGetNextAvailableAccountNamefieldB = null, Expression<Func<string>> jMLGetNextAvailableAccountNamefieldC = null, Expression<Func<string>> jMLGetNextAvailableAccountNamefieldD = null, Expression<Func<int>> jMLGetNextAvailableAccountNamevariableMStartValue = null, Expression<Func<int>> jMLGetNextAvailableAccountNamevariableNStartValue = null, Expression<Func<int>> jMLGetNextAvailableAccountNamevariableXStartValue = null, Expression<Func<int>> jMLGetNextAvailableAccountNamemaxAttempts = null, Expression<Func<bool>> jMLGetNextAvailableAccountNamefallbackCausesRetest = null, Expression<Func<string>> jMLGetNextAvailableAccountNamenumbersNotToUse = null, Expression<Func<string>> jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs = null, Expression<Func<bool>> jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs = null, Expression<Func<bool>> jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs = null, Expression<Func<string>> jMLGetNextAvailableAccountNamesequenceA1 = null, Expression<Func<jMLGetNextAvailableAccountNamepropertiesToCheckListInputItem[]>> jMLGetNextAvailableAccountNamepropertiesToCheckList = null)
        {
            var __workflow_jMLGetNextAvailableAccountNameworkflow = WorkflowExpression.Compile(jMLGetNextAvailableAccountNameworkflow, nameof(jMLGetNextAvailableAccountNameworkflow), required: true);
            var __workflow_jMLGetNextAvailableAccountNamefirstName = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamefirstName, nameof(jMLGetNextAvailableAccountNamefirstName), required: false);
            var __workflow_jMLGetNextAvailableAccountNamemiddleName = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamemiddleName, nameof(jMLGetNextAvailableAccountNamemiddleName), required: false);
            var __workflow_jMLGetNextAvailableAccountNamelastName = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamelastName, nameof(jMLGetNextAvailableAccountNamelastName), required: false);
            var __workflow_jMLGetNextAvailableAccountNamefieldA = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamefieldA, nameof(jMLGetNextAvailableAccountNamefieldA), required: false);
            var __workflow_jMLGetNextAvailableAccountNamefieldB = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamefieldB, nameof(jMLGetNextAvailableAccountNamefieldB), required: false);
            var __workflow_jMLGetNextAvailableAccountNamefieldC = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamefieldC, nameof(jMLGetNextAvailableAccountNamefieldC), required: false);
            var __workflow_jMLGetNextAvailableAccountNamefieldD = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamefieldD, nameof(jMLGetNextAvailableAccountNamefieldD), required: false);
            var __workflow_jMLGetNextAvailableAccountNamevariableMStartValue = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamevariableMStartValue, nameof(jMLGetNextAvailableAccountNamevariableMStartValue), required: false);
            var __workflow_jMLGetNextAvailableAccountNamevariableNStartValue = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamevariableNStartValue, nameof(jMLGetNextAvailableAccountNamevariableNStartValue), required: false);
            var __workflow_jMLGetNextAvailableAccountNamevariableXStartValue = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamevariableXStartValue, nameof(jMLGetNextAvailableAccountNamevariableXStartValue), required: false);
            var __workflow_jMLGetNextAvailableAccountNamemaxAttempts = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamemaxAttempts, nameof(jMLGetNextAvailableAccountNamemaxAttempts), required: false);
            var __workflow_jMLGetNextAvailableAccountNamefallbackCausesRetest = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamefallbackCausesRetest, nameof(jMLGetNextAvailableAccountNamefallbackCausesRetest), required: false);
            var __workflow_jMLGetNextAvailableAccountNamenumbersNotToUse = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamenumbersNotToUse, nameof(jMLGetNextAvailableAccountNamenumbersNotToUse), required: false);
            var __workflow_jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs, nameof(jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs), required: false);
            var __workflow_jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs = WorkflowExpression.Compile(jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs, nameof(jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs), required: false);
            var __workflow_jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs = WorkflowExpression.Compile(jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs, nameof(jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs), required: false);
            var __workflow_jMLGetNextAvailableAccountNamesequenceA1 = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamesequenceA1, nameof(jMLGetNextAvailableAccountNamesequenceA1), required: false);
            var __workflow_jMLGetNextAvailableAccountNamepropertiesToCheckList = WorkflowExpression.Compile(jMLGetNextAvailableAccountNamepropertiesToCheckList, nameof(jMLGetNextAvailableAccountNamepropertiesToCheckList), required: false);
            return new DeferredBodyAction<JMLGetNextAvailableAccountNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/JMLGetNextAvailableAccountName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jMLGetNextAvailableAccountName = new JObject();
                var jMLGetNextAvailableAccountNamepropCount = 0;
                if (__workflow_jMLGetNextAvailableAccountNamefirstName != null)
                {
                    jMLGetNextAvailableAccountName["FirstName"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamefirstName);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamemiddleName != null)
                {
                    jMLGetNextAvailableAccountName["MiddleName"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamemiddleName);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamelastName != null)
                {
                    jMLGetNextAvailableAccountName["LastName"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamelastName);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamefieldA != null)
                {
                    jMLGetNextAvailableAccountName["FieldA"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamefieldA);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamefieldB != null)
                {
                    jMLGetNextAvailableAccountName["FieldB"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamefieldB);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamefieldC != null)
                {
                    jMLGetNextAvailableAccountName["FieldC"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamefieldC);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamefieldD != null)
                {
                    jMLGetNextAvailableAccountName["FieldD"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamefieldD);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamevariableMStartValue != null)
                {
                    if (__workflow_jMLGetNextAvailableAccountNamevariableMStartValue != null)
                    {
                        jMLGetNextAvailableAccountName["VariableMStartValue"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamevariableMStartValue);
                        jMLGetNextAvailableAccountNamepropCount++;
                    }

                    jMLGetNextAvailableAccountNamepropCount++;
                }
                else
                {
                    jMLGetNextAvailableAccountName["VariableMStartValue"] = 2;
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamevariableNStartValue != null)
                {
                    if (__workflow_jMLGetNextAvailableAccountNamevariableNStartValue != null)
                    {
                        jMLGetNextAvailableAccountName["VariableNStartValue"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamevariableNStartValue);
                        jMLGetNextAvailableAccountNamepropCount++;
                    }

                    jMLGetNextAvailableAccountNamepropCount++;
                }
                else
                {
                    jMLGetNextAvailableAccountName["VariableNStartValue"] = 2;
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamevariableXStartValue != null)
                {
                    if (__workflow_jMLGetNextAvailableAccountNamevariableXStartValue != null)
                    {
                        jMLGetNextAvailableAccountName["VariableXStartValue"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamevariableXStartValue);
                        jMLGetNextAvailableAccountNamepropCount++;
                    }

                    jMLGetNextAvailableAccountNamepropCount++;
                }
                else
                {
                    jMLGetNextAvailableAccountName["VariableXStartValue"] = 2;
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamemaxAttempts != null)
                {
                    if (__workflow_jMLGetNextAvailableAccountNamemaxAttempts != null)
                    {
                        jMLGetNextAvailableAccountName["MaxAttempts"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamemaxAttempts);
                        jMLGetNextAvailableAccountNamepropCount++;
                    }

                    jMLGetNextAvailableAccountNamepropCount++;
                }
                else
                {
                    jMLGetNextAvailableAccountName["MaxAttempts"] = 20;
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamefallbackCausesRetest != null)
                {
                    if (__workflow_jMLGetNextAvailableAccountNamefallbackCausesRetest != null)
                    {
                        jMLGetNextAvailableAccountName["FallbackCausesRetest"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamefallbackCausesRetest);
                        jMLGetNextAvailableAccountNamepropCount++;
                    }

                    jMLGetNextAvailableAccountNamepropCount++;
                }
                else
                {
                    jMLGetNextAvailableAccountName["FallbackCausesRetest"] = true;
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamenumbersNotToUse != null)
                {
                    jMLGetNextAvailableAccountName["NumbersNotToUse"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamenumbersNotToUse);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs != null)
                {
                    jMLGetNextAvailableAccountName["CharactersToRemoveFromInputs"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs != null)
                {
                    if (__workflow_jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs != null)
                    {
                        jMLGetNextAvailableAccountName["RemoveDiacriticsFromInputs"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs);
                        jMLGetNextAvailableAccountNamepropCount++;
                    }

                    jMLGetNextAvailableAccountNamepropCount++;
                }
                else
                {
                    jMLGetNextAvailableAccountName["RemoveDiacriticsFromInputs"] = true;
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs != null)
                {
                    if (__workflow_jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs != null)
                    {
                        jMLGetNextAvailableAccountName["RemoveNonAlphaNumericFromInputs"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs);
                        jMLGetNextAvailableAccountNamepropCount++;
                    }

                    jMLGetNextAvailableAccountNamepropCount++;
                }
                else
                {
                    jMLGetNextAvailableAccountName["RemoveNonAlphaNumericFromInputs"] = true;
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamesequenceA1 != null)
                {
                    jMLGetNextAvailableAccountName["SequenceA1"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamesequenceA1);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (__workflow_jMLGetNextAvailableAccountNamepropertiesToCheckList != null)
                {
                    jMLGetNextAvailableAccountName["PropertiesToCheckList"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNamepropertiesToCheckList);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                jMLGetNextAvailableAccountNamepropCount++;
                jMLGetNextAvailableAccountName["Workflow"] = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountNameworkflow);
                if (jMLGetNextAvailableAccountNamepropCount > 0)
                {
                    callPayload.Body = jMLGetNextAvailableAccountName;
                }

                return new ApiConnectionAction<JMLGetNextAvailableAccountNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<JMLConnectToJMLEnvironmentResponse, ApiConnectionActionConfiguration> JMLConnectToJMLEnvironment(Expression<Func<string>> jMLConnectToJMLEnvironmentworkflow, Expression<Func<string>> jMLConnectToJMLEnvironmentfriendlyName = null, Expression<Func<bool>> jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected = null)
        {
            var __workflow_jMLConnectToJMLEnvironmentworkflow = WorkflowExpression.Compile(jMLConnectToJMLEnvironmentworkflow, nameof(jMLConnectToJMLEnvironmentworkflow), required: true);
            var __workflow_jMLConnectToJMLEnvironmentfriendlyName = WorkflowExpression.Compile(jMLConnectToJMLEnvironmentfriendlyName, nameof(jMLConnectToJMLEnvironmentfriendlyName), required: false);
            var __workflow_jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected = WorkflowExpression.Compile(jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected, nameof(jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected), required: false);
            return new DeferredBodyAction<JMLConnectToJMLEnvironmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/JMLConnectToJMLEnvironment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jMLConnectToJMLEnvironment = new JObject();
                var jMLConnectToJMLEnvironmentpropCount = 0;
                if (__workflow_jMLConnectToJMLEnvironmentfriendlyName != null)
                {
                    jMLConnectToJMLEnvironment["FriendlyName"] = ExpressionConverter.ConvertO(__workflow_jMLConnectToJMLEnvironmentfriendlyName);
                    jMLConnectToJMLEnvironmentpropCount++;
                }

                if (__workflow_jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected != null)
                {
                    if (__workflow_jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected != null)
                    {
                        jMLConnectToJMLEnvironment["OnlyConnectIfNotAlreadyConnected"] = ExpressionConverter.ConvertO(__workflow_jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected);
                        jMLConnectToJMLEnvironmentpropCount++;
                    }

                    jMLConnectToJMLEnvironmentpropCount++;
                }
                else
                {
                    jMLConnectToJMLEnvironment["OnlyConnectIfNotAlreadyConnected"] = true;
                    jMLConnectToJMLEnvironmentpropCount++;
                }

                jMLConnectToJMLEnvironmentpropCount++;
                jMLConnectToJMLEnvironment["Workflow"] = ExpressionConverter.ConvertO(__workflow_jMLConnectToJMLEnvironmentworkflow);
                if (jMLConnectToJMLEnvironmentpropCount > 0)
                {
                    callPayload.Body = jMLConnectToJMLEnvironment;
                }

                return new ApiConnectionAction<JMLConnectToJMLEnvironmentResponse>(callPayload);
            });
        }
    }

    public class IaconnectjmlTriggers([ConnectionName] string connectionId)
    {
    }

    public class RunActiveDirectoryPowerShellAutomationScriptResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int ThreadId { get; set; }
    }

    public class runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParametersInputItem
    {
        public string Name { get; set; }
        public string StringValue { get; set; }
        public int IntValue { get; set; }
        public bool BooleanValue { get; set; }
        public double DecimalValue { get; set; }
        public JToken ObjectValue { get; set; }
    }

    public class OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse
    {
        public bool OpenActiveDirectoryPowerShellRunspaceWithCredentialsResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class CloseActiveDirectoryPowerShellRunspaceResponse
    {
        public bool CloseActiveDirectoryPowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class IsActiveDirectoryPowerShellRunspaceOpenResponse
    {
        public bool ActiveDirectoryRunspaceOpen { get; set; }
        public bool ActiveDirectoryLocalPassthroughRunspace { get; set; }
        public string ActiveDirectoryServer { get; set; }
        public string ActiveDirectoryDNSDomain { get; set; }
        public string ActiveDirectoryDomainDN { get; set; }
        public string AuthenticatedUsername { get; set; }
    }

    public class OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse
    {
        public bool OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryAddADUserResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string CreatedUserDistinguishedName { get; set; }
        public string CreatedUserSAMAccountName { get; set; }
        public string CreatedUserPrincipalName { get; set; }
    }

    public class ActiveDirectoryGetADUserByIdentityResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfUsersFound { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum activeDirectoryGetADUserByIdentityfilterPropertyComparisonInput
    {
        [EnumMember(Value = "Equals")]
        EqualsExactMatch,
        [EnumMember(Value = "Not equals")]
        NotEqualsNotEqualsExactMatch,
        [EnumMember(Value = "Like")]
        LikeEqualsWithWildcards,
        [EnumMember(Value = "Not like")]
        NotLikeNotEqualsWithWildcards,
        [EnumMember(Value = "Greater than")]
        GreaterThanNumericComparison,
        [EnumMember(Value = "Less than")]
        LessThanNumericComparison,
        [EnumMember(Value = "Raw")]
        RawEnterFilterManually,
        [EnumMember(Value = "LDAP")]
        LDAPEnterLDAPFilter
    }

    public class ActiveDirectoryGetOUFromUserDNResponse
    {
        public string UserOU { get; set; }
    }

    public class ActiveDirectoryGetDomainFQDNFromDNResponse
    {
        public string DomainFQDN { get; set; }
    }

    public class ActiveDirectoryGetADGroupByIdentityResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfGroupsFound { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum activeDirectoryGetADGroupByIdentityfilterPropertyComparisonInput
    {
        [EnumMember(Value = "Equals")]
        EqualsExactMatch,
        [EnumMember(Value = "Not equals")]
        NotEqualsNotEqualsExactMatch,
        [EnumMember(Value = "Like")]
        LikeEqualsWithWildcards,
        [EnumMember(Value = "Not like")]
        NotLikeNotEqualsWithWildcards,
        [EnumMember(Value = "Greater than")]
        GreaterThanNumericComparison,
        [EnumMember(Value = "Less than")]
        LessThanNumericComparison,
        [EnumMember(Value = "Raw")]
        RawEnterFilterManually,
        [EnumMember(Value = "LDAP")]
        LDAPEnterLDAPFilter
    }

    public class ActiveDirectoryAddADGroupMemberByIdentityResponse
    {
        public bool ActiveDirectoryAddADGroupMemberByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse
    {
        public int ADGroupMembersAddedSuccessfully { get; set; }
        public int ADGroupMembersFailedToAdd { get; set; }
        public string AddADGroupMembersMasterErrorMessage { get; set; }
    }

    public class ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse
    {
        public int ADGroupsAddedSuccessfully { get; set; }
        public int ADGroupsFailedToAdd { get; set; }
        public string AddADGroupsMasterErrorMessage { get; set; }
    }

    public class ActiveDirectoryGetADUserGroupMembershipResponse
    {
        public string GroupMembershipJSON { get; set; }
        public int CountOfGroupsFound { get; set; }
    }

    public class ActiveDirectoryModifyADUserStringPropertyByIdentityResponse
    {
        public bool ActiveDirectoryModifyADUserStringPropertyByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class activeDirectoryModifyADUserStringPropertyByIdentitypropertiesListInputItem
    {
        public string Property { get; set; }
        public string Value { get; set; }
    }

    public class ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse
    {
        public bool ActiveDirectoryModifyADUserBooleanPropertyByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryModifyADUserPropertiesResponse
    {
        public bool ActiveDirectoryModifyADUserPropertiesResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryMoveADUserToOUByIdentityResponse
    {
        public bool ActiveDirectoryMoveADUserToOUByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryClearADUserAccountExpirationResponse
    {
        public bool ActiveDirectoryClearADUserAccountExpirationResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryDirSyncResponse
    {
        public string PowerShellJSONOutput { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum activeDirectoryDirSyncpolicyTypeInput
    {
        Delta,
        Initial
    }

    public class ActiveDirectoryRemoveADUserByIdentityResponse
    {
        public bool ActiveDirectoryRemoveADUserByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryResetADUserPasswordByIdentityResponse
    {
        public bool ActiveDirectoryResetADUserPasswordByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse
    {
        public bool ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryDisableADUserByIdentityResponse
    {
        public bool ActiveDirectoryDisableADUserByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryEnableADUserByIdentityResponse
    {
        public bool ActiveDirectoryEnableADUserByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectorySetADUserHomeFolderByIdentityResponse
    {
        public bool ActiveDirectorySetADUserHomeFolderByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryCloneADUserGroupsResponse
    {
        public int ADGroupsAddedSuccessfully { get; set; }
        public int ADGroupsFailedToAdd { get; set; }
        public string AddADGroupsMasterErrorMessage { get; set; }
    }

    public class ActiveDirectoryCloneADUserPropertiesResponse
    {
        public bool ActiveDirectoryCloneADUserPropertiesResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse
    {
        public int ADGroupsRemovedSuccessfully { get; set; }
        public int ADGroupsFailedToRemove { get; set; }
        public string RemoveADGroupsMasterErrorMessage { get; set; }
    }

    public class ActiveDirectoryRemoveADUserFromAllGroupsResponse
    {
        public int ADGroupsRemovedSuccessfully { get; set; }
        public int ADGroupsFailedToRemove { get; set; }
        public int ADGroupsExcludedFromRemoval { get; set; }
        public string RemoveADGroupsMasterErrorMessage { get; set; }
        public int ThreadId { get; set; }
    }

    public class ActiveDirectoryCheckOUExistsResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public bool OUExists { get; set; }
    }

    public class ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse
    {
        public bool ActiveDirectoryRemoveADGroupMemberByGroupIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse
    {
        public int ADGroupMembersRemovedSuccessfully { get; set; }
        public int ADGroupMembersFailedToRemove { get; set; }
        public string RemoveADGroupMembersMasterErrorMessage { get; set; }
    }

    public class ActiveDirectoryUnlockADAccountByIdentityResponse
    {
        public bool ActiveDirectoryUnlockADAccountByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectorySetADServerResponse
    {
        public bool ActiveDirectorySetADServerResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum activeDirectorySetADServerpredefinedADServerChoiceInput
    {
        [EnumMember(Value = "User PDC: PDC emulator of logged-in user domain")]
        UserPDCPDCEmulatorOfLoggedInUserDomain,
        [EnumMember(Value = "Computer PDC: PDC emulator of local computer domain")]
        ComputerPDCPDCEmulatorOfLocalComputerDomain,
        [EnumMember(Value = "Manual: Specify in AD server field")]
        ManualSpecifyInADServerField
    }

    public class ActiveDirectoryGetDomainInfoResponse
    {
        public string DistinguishedName { get; set; }
        public string DNSRoot { get; set; }
        public string DomainMode { get; set; }
        public string DomainSID { get; set; }
        public string Forest { get; set; }
        public string InfrastructureMaster { get; set; }
        public string NetBIOSName { get; set; }
        public string ObjectGUID { get; set; }
        public string PDCEmulator { get; set; }
        public string RIDMaster { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum activeDirectoryGetDomainInfopredefinedIdentityInput
    {
        [EnumMember(Value = "User: Logged-in user domain")]
        UserLoggedInUserDomain,
        [EnumMember(Value = "Computer: Local computer domain")]
        ComputerLocalComputerDomain,
        [EnumMember(Value = "Manual: Specify in Domain identity field")]
        ManualSpecifyInDomainIdentityField
    }

    public class ActiveDirectoryAddADGroupResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string CreatedGroupDistinguishedName { get; set; }
        public string CreatedGroupSAMAccountName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum activeDirectoryAddADGroupgroupCategoryInput
    {
        [EnumMember(Value = "Security")]
        SecurityGroup,
        [EnumMember(Value = "Distribution")]
        DistributionGroup
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum activeDirectoryAddADGroupgroupScopeInput
    {
        DomainLocal,
        Global,
        Universal
    }

    public class ActiveDirectoryDoesADGroupExistResponse
    {
        public bool ADGroupExists { get; set; }
        public string ADGroupDN { get; set; }
    }

    public class ActiveDirectoryRemoveADGroupResponse
    {
        public int NumberOfGroupsDeleted { get; set; }
    }

    public class ActiveDirectoryAddOUResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string CreatedOUDistinguishedName { get; set; }
    }

    public class ActiveDirectoryRemoveOUResponse
    {
        public int NumberOfOUsDeleted { get; set; }
    }

    public class ActiveDirectorySetADUserAccountExpirationEndOfDateResponse
    {
        public bool ActiveDirectorySetADUserAccountExpirationEndOfDateResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryGetADGroupMembersResponse
    {
        public string GroupMembersJSON { get; set; }
        public int CountOfGroupMembersFound { get; set; }
    }

    public class OpenExchangePowerShellRunspaceResponse
    {
        public bool OpenExchangePowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum openExchangePowerShellRunspaceconnectionMethodInput
    {
        [EnumMember(Value = "Local")]
        LocalRemoteExchangeRunspaceIsImportedLocally,
        [EnumMember(Value = "Remote")]
        RemoteCommandsRunInRemoteExchangeRunspace
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum openExchangePowerShellRunspaceauthenticationMechanismInput
    {
        Basic,
        CredSSP,
        Default,
        Digest,
        Kerberos,
        Negotiate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum openExchangePowerShellRunspacecommandTypesToImportLocallyInput
    {
        [EnumMember(Value = "All")]
        AllAllExchangePSCommands,
        [EnumMember(Value = "IA-Connect only")]
        IAConnectOnlyOnlyExchangePSCommandsUsedByIAConnect,
        [EnumMember(Value = "Specified")]
        SpecifiedOnlySpecifiedExchangePSCommands
    }

    public class IsExchangePowerShellRunspaceOpenResponse
    {
        public bool ExchangeRunspaceOpen { get; set; }
        public string ExchangeConnectionMethod { get; set; }
        public int PowerShellRunspacePID { get; set; }
        public bool IsAgentHostingPowerShellRunSpace { get; set; }
    }

    public class RunExchangePowerShellAutomationScriptResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int ThreadId { get; set; }
    }

    public class runExchangePowerShellAutomationScriptpowerShellCommandParametersInputItem
    {
        public string Name { get; set; }
        public string StringValue { get; set; }
        public int IntValue { get; set; }
        public bool BooleanValue { get; set; }
        public double DecimalValue { get; set; }
        public JToken ObjectValue { get; set; }
    }

    public class CloseExchangePowerShellRunspaceResponse
    {
        public bool CloseExchangePowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeGetMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfMailboxesFound { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exchangeGetMailboxfilterPropertyComparisonInput
    {
        [EnumMember(Value = "Equals")]
        EqualsExactMatch,
        [EnumMember(Value = "Not equals")]
        NotEqualsNotEqualsExactMatch,
        [EnumMember(Value = "Like")]
        LikeEqualsWithWildcards,
        [EnumMember(Value = "Not like")]
        NotLikeNotEqualsWithWildcards,
        [EnumMember(Value = "Greater than")]
        GreaterThanNumericComparison,
        [EnumMember(Value = "Less than")]
        LessThanNumericComparison,
        [EnumMember(Value = "Raw")]
        RawEnterFilterManually
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exchangeGetMailboxrecipientTypeDetailsInput
    {
        DiscoveryMailbox,
        EquipmentMailbox,
        GroupMailbox,
        LegacyMailbox,
        LinkedMailbox,
        LinkedRoomMailbox,
        RoomMailbox,
        SchedulingMailbox,
        SharedMailbox,
        TeamMailbox,
        UserMailbox
    }

    public class ExchangeDoesMailboxExistResponse
    {
        public bool MailboxExists { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exchangeDoesMailboxExistfilterPropertyComparisonInput
    {
        [EnumMember(Value = "Equals")]
        EqualsExactMatch,
        [EnumMember(Value = "Not equals")]
        NotEqualsNotEqualsExactMatch,
        [EnumMember(Value = "Like")]
        LikeEqualsWithWildcards,
        [EnumMember(Value = "Not like")]
        NotLikeNotEqualsWithWildcards,
        [EnumMember(Value = "Greater than")]
        GreaterThanNumericComparison,
        [EnumMember(Value = "Less than")]
        LessThanNumericComparison,
        [EnumMember(Value = "Raw")]
        RawEnterFilterManually
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exchangeDoesMailboxExistrecipientTypeDetailsInput
    {
        DiscoveryMailbox,
        EquipmentMailbox,
        GroupMailbox,
        LegacyMailbox,
        LinkedMailbox,
        LinkedRoomMailbox,
        RoomMailbox,
        SchedulingMailbox,
        SharedMailbox,
        TeamMailbox,
        UserMailbox
    }

    public class ExchangeAddDistributionGroupMemberResponse
    {
        public bool ExchangeAddDistributionGroupMemberResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeRemoveDistributionGroupMemberResponse
    {
        public bool ExchangeRemoveDistributionGroupMemberResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeGetDistributionGroupResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfDistributionGroupsFound { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exchangeGetDistributionGroupfilterPropertyComparisonInput
    {
        [EnumMember(Value = "Equals")]
        EqualsExactMatch,
        [EnumMember(Value = "Not equals")]
        NotEqualsNotEqualsExactMatch,
        [EnumMember(Value = "Like")]
        LikeEqualsWithWildcards,
        [EnumMember(Value = "Not like")]
        NotLikeNotEqualsWithWildcards,
        [EnumMember(Value = "Greater than")]
        GreaterThanNumericComparison,
        [EnumMember(Value = "Less than")]
        LessThanNumericComparison,
        [EnumMember(Value = "Raw")]
        RawEnterFilterManually
    }

    public class ExchangeGetDistributionGroupMembersResponse
    {
        public string DistributionGroupMembersJSON { get; set; }
        public int CountOfDistributionGroupsMembers { get; set; }
    }

    public class ExchangeGetMailboxDistributionGroupMembershipResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfDistributionGroupsFound { get; set; }
    }

    public class ExchangeNewDistributionGroupResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public bool GroupAlreadyExists { get; set; }
        public string NewGroupDN { get; set; }
        public string NewGroupGUID { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exchangeNewDistributionGroupmemberDepartRestrictionInput
    {
        Open,
        Closed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exchangeNewDistributionGroupmemberJoinRestrictionInput
    {
        Open,
        Closed,
        ApprovalRequired
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exchangeNewDistributionGrouptypeInput
    {
        Distribution,
        Security
    }

    public class ExchangeRemoveDistributionGroupResponse
    {
        public bool ExchangeRemoveDistributionGroupResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeAddMailboxPermissionResponse
    {
        public bool ExchangeAddMailboxPermissionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeRemoveMailboxPermissionResponse
    {
        public bool ExchangeRemoveMailboxPermissionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeDisableMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
    }

    public class ExchangeDisableRemoteMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
    }

    public class ExchangeEnableMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string NewMailboxDN { get; set; }
        public string NewMailboxGUID { get; set; }
    }

    public class ExchangeEnableRemoteMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string NewMailboxDN { get; set; }
        public string NewMailboxGUID { get; set; }
    }

    public class ExchangeGetRemoteMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfMailboxesFound { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exchangeGetRemoteMailboxfilterPropertyComparisonInput
    {
        [EnumMember(Value = "Equals")]
        EqualsExactMatch,
        [EnumMember(Value = "Not equals")]
        NotEqualsNotEqualsExactMatch,
        [EnumMember(Value = "Like")]
        LikeEqualsWithWildcards,
        [EnumMember(Value = "Not like")]
        NotLikeNotEqualsWithWildcards,
        [EnumMember(Value = "Greater than")]
        GreaterThanNumericComparison,
        [EnumMember(Value = "Less than")]
        LessThanNumericComparison,
        [EnumMember(Value = "Raw")]
        RawEnterFilterManually
    }

    public class ExchangeDoesRemoteMailboxExistResponse
    {
        public bool MailboxExists { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exchangeDoesRemoteMailboxExistfilterPropertyComparisonInput
    {
        [EnumMember(Value = "Equals")]
        EqualsExactMatch,
        [EnumMember(Value = "Not equals")]
        NotEqualsNotEqualsExactMatch,
        [EnumMember(Value = "Like")]
        LikeEqualsWithWildcards,
        [EnumMember(Value = "Not like")]
        NotLikeNotEqualsWithWildcards,
        [EnumMember(Value = "Greater than")]
        GreaterThanNumericComparison,
        [EnumMember(Value = "Less than")]
        LessThanNumericComparison,
        [EnumMember(Value = "Raw")]
        RawEnterFilterManually
    }

    public class ExchangeNewMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string NewMailboxDN { get; set; }
        public string NewMailboxGUID { get; set; }
    }

    public class ExchangeNewRemoteMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string NewMailboxDN { get; set; }
        public string NewMailboxGUID { get; set; }
    }

    public class ExchangeSetADServerToViewEntireForestResponse
    {
        public bool ExchangeSetADServerToViewEntireForestResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeSetMailboxResponse
    {
        public bool ExchangeSetMailboxResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeSetMailboxEmailAddressesResponse
    {
        public string[] MailboxEmailAddresses { get; set; }
    }

    public class ExchangeGetMailboxEmailAddressesResponse
    {
        public string[] MailboxEmailAddresses { get; set; }
    }

    public class ExchangeSetRemoteMailboxEmailAddressesResponse
    {
        public string[] MailboxEmailAddresses { get; set; }
    }

    public class ExchangeGetRemoteMailboxEmailAddressesResponse
    {
        public string[] MailboxEmailAddresses { get; set; }
    }

    public class ExchangeResetMailboxAttributesResponse
    {
        public bool ExchangeResetMailboxAttributesResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeResetRemoteMailboxAttributesResponse
    {
        public bool ExchangeResetRemoteMailboxAttributesResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeSetRemoteMailboxResponse
    {
        public bool ExchangeSetRemoteMailboxResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exchangeSetRemoteMailboxtypeInput
    {
        Regular,
        Room,
        Equipment,
        Shared
    }

    public class ExchangeSetMailboxSendOnBehalfOfPermissionResponse
    {
        public bool ExchangeSetMailboxSendOnBehalfOfPermissionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeAddADPermissionResponse
    {
        public bool ExchangeAddADPermissionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeSetMailboxAutoReplyConfigurationResponse
    {
        public bool ExchangeSetMailboxAutoReplyConfigurationResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exchangeSetMailboxAutoReplyConfigurationautoReplyStateInput
    {
        [EnumMember(Value = "Enabled")]
        EnabledAutomaticRepliesAreSent,
        [EnumMember(Value = "Disabled")]
        DisabledAutomaticRepliesAreNotSent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exchangeSetMailboxAutoReplyConfigurationexternalAudienceInput
    {
        [EnumMember(Value = "None")]
        NoneRepliesAreNotSentToExternalSenders,
        [EnumMember(Value = "Known")]
        KnownRepliesAreOnlySentToSendersInContactList,
        [EnumMember(Value = "All")]
        AllRepliesAreSentToAllSenders
    }

    public class IsAzureADv2PowerShellModuleInstalledResponse
    {
        public bool AzureADv2PowerShellModuleInstalled { get; set; }
        public bool MSGraphUsersPowerShellModuleInstalled { get; set; }
    }

    public class OpenAzureADv2PowerShellRunspaceResponse
    {
        public bool OpenAzureADv2PowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum openAzureADv2PowerShellRunspaceaPIToUseInput
    {
        [EnumMember(Value = "Auto")]
        AutoDetect,
        [EnumMember(Value = "AzureADv2")]
        AzureADV2Powershell,
        [EnumMember(Value = "MSGraphUsersPS")]
        MicrosoftGraphUsersPowerShell
    }

    public class OpenAzureADv2PowerShellRunspaceWithCertificateResponse
    {
        public bool OpenAzureADv2PowerShellRunspaceWithCertificateResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum openAzureADv2PowerShellRunspaceWithCertificateaPIToUseInput
    {
        [EnumMember(Value = "Auto")]
        AutoDetect,
        [EnumMember(Value = "AzureADv2")]
        AzureADV2Powershell,
        [EnumMember(Value = "MSGraphUsersPS")]
        MicrosoftGraphUsersPowerShell
    }

    public class IsAzureADv2PowerShellRunspaceOpenResponse
    {
        public bool AzureADv2RunspaceOpen { get; set; }
        public string AzureADAPI { get; set; }
        public int PowerShellRunspacePID { get; set; }
        public bool IsAgentHostingPowerShellRunSpace { get; set; }
    }

    public class RunAzureADv2PowerShellAutomationScriptResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int ThreadId { get; set; }
    }

    public class runAzureADv2PowerShellAutomationScriptpowerShellCommandParametersInputItem
    {
        public string Name { get; set; }
        public string StringValue { get; set; }
        public int IntValue { get; set; }
        public bool BooleanValue { get; set; }
        public double DecimalValue { get; set; }
        public JToken ObjectValue { get; set; }
    }

    public class CloseAzureADv2PowerShellRunspaceResponse
    {
        public bool CloseAzureADv2PowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2GetAzureADUsersResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfUsersFound { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum azureADv2GetAzureADUsersfilterPropertyComparisonInput
    {
        [EnumMember(Value = "Equals")]
        EqualsExactMatch,
        [EnumMember(Value = "Not equals")]
        NotEqualsNotEqualsExactMatch,
        [EnumMember(Value = "Starts with")]
        StartsWithStringStartsWith,
        [EnumMember(Value = "Raw")]
        RawEnterFilterManually
    }

    public class AzureADv2AddAzureADUserResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string CreatedUserPrincipalName { get; set; }
        public string CreatedUserObjectId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum azureADv2AddAzureADUserageGroupInput
    {
        None,
        Minor,
        NotAdult,
        Adult
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum azureADv2AddAzureADUserconsentProvidedForMinorInput
    {
        None,
        Granted,
        Denied,
        NotRequired
    }

    public class AzureADv2RemoveAzureADUserResponse
    {
        public bool UserExisted { get; set; }
    }

    public class AzureADv2ResetAzureADUserPasswordResponse
    {
        public bool AzureADv2ResetAzureADUserPasswordResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2GetAzureADUserGroupMembershipResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfGroupsFound { get; set; }
    }

    public class AzureADv2IsUserInAzureADUserGroupResponse
    {
        public bool UserIsInGroup { get; set; }
    }

    public class AzureADv2AddUserToGroupResponse
    {
        public bool AzureADv2AddUserToGroupResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2RemoveUserFromGroupResponse
    {
        public bool AzureADv2RemoveUserFromGroupResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2AddADUserToMultipleADGroupsResponse
    {
        public int AzureADGroupsAddedSuccessfully { get; set; }
        public int AzureADGroupsFailedToAdd { get; set; }
        public string AddAzureADGroupsMasterErrorMessage { get; set; }
    }

    public class AzureADv2RemoveADUserFromMultipleADGroupsResponse
    {
        public int AzureADGroupsRemovedSuccessfully { get; set; }
        public int AzureADGroupsFailedToRemove { get; set; }
        public string RemoveAzureADGroupsErrorMessage { get; set; }
    }

    public class AzureADv2RemoveUserFromAllGroupsResponse
    {
        public int AzureADGroupsRemovedSuccessfully { get; set; }
        public int AzureADGroupsFailedToRemove { get; set; }
        public string RemoveAzureADGroupsErrorMessage { get; set; }
    }

    public class AzureADv2GetAzureADLicenseSKUsResponse
    {
        public string LicenseSKUJSONOutput { get; set; }
        public int CountOfSKUsFound { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum azureADv2GetAzureADLicenseSKUsexpandPropertyInput
    {
        None,
        PrepaidUnits,
        ServicePlans
    }

    public class AzureADv2SetAzureADUserLicenseResponse
    {
        public bool AzureADv2SetAzureADUserLicenseResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum azureADv2SetAzureADUserLicenselicensePlansChoiceInput
    {
        [EnumMember(Value = "All")]
        AllEnableAllPlans,
        [EnumMember(Value = "Opt-in")]
        OptInSpecifyPlansToEnable,
        [EnumMember(Value = "Opt-out")]
        OptOutSpecifyPlansToDisable
    }

    public class AzureADv2GetAzureADUserLicensesResponse
    {
        public string UserLicenseSKUJSONOutput { get; set; }
        public int CountOfUserLicenseSKUsFound { get; set; }
    }

    public class AzureADv2GetAzureADUserLicenseServicePlansResponse
    {
        public string UserLicenseSKUServicePlansJSONOutput { get; set; }
        public int CountOfUserLicenseSKUServicePlansFound { get; set; }
    }

    public class AzureADv2RemoveAllAzureADUserLicenseResponse
    {
        public bool AzureADv2RemoveAllAzureADUserLicenseResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2SetAzureADUserResponse
    {
        public bool AzureADv2SetAzureADUserResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum azureADv2SetAzureADUserageGroupInput
    {
        None,
        Minor,
        NotAdult,
        Adult
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum azureADv2SetAzureADUserconsentProvidedForMinorInput
    {
        None,
        Granted,
        Denied,
        NotRequired
    }

    public class AzureADv2ResetAzureADUserPropertiesResponse
    {
        public bool AzureADv2ResetAzureADUserPropertiesResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2SetAzureADUserManagerResponse
    {
        public bool AzureADv2SetAzureADUserManagerResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2NewSecurityGroupResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public bool GroupAlreadyExists { get; set; }
        public string CreatedGroupObjectId { get; set; }
    }

    public class AzureADv2RemoveSecurityGroupResponse
    {
        public bool GroupExisted { get; set; }
    }

    public class AzureADv2NewMicrosoft365GroupResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public bool GroupAlreadyExists { get; set; }
        public string CreatedGroupObjectId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum azureADv2NewMicrosoft365GroupgroupVisibilityInput
    {
        [EnumMember(Value = "Public")]
        PublicAnyoneCanViewOrJoin,
        [EnumMember(Value = "Private")]
        PrivateOnlyMembersCanView
    }

    public class AzureADv2GetGroupsResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfGroupsFound { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum azureADv2GetGroupsfilterPropertyComparisonInput
    {
        [EnumMember(Value = "All")]
        AllReturnAllItems,
        [EnumMember(Value = "Equals")]
        EqualsExactMatch,
        [EnumMember(Value = "Not equals")]
        NotEqualsNotEqualsExactMatch,
        [EnumMember(Value = "Starts with")]
        StartsWithStringStartsWith,
        [EnumMember(Value = "Raw")]
        RawEnterFilterManually
    }

    public class AzureADv2EnableUserResponse
    {
        public bool AzureADv2EnableUserResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2DisableUserResponse
    {
        public bool AzureADv2DisableUserResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2AssignUserToRoleResponse
    {
        public bool AzureADv2AssignUserToRoleResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2AssignUserToMultipleRolesResponse
    {
        public int AzureADRolesAssignedSuccessfully { get; set; }
        public int AzureADRolesFailedToAssign { get; set; }
        public string AssignAzureADRolesMasterErrorMessage { get; set; }
    }

    public class AzureADv2RemoveUserFromMultipleRolesResponse
    {
        public int AzureADRolesRemovedSuccessfully { get; set; }
        public int AzureADRolesFailedToRemove { get; set; }
        public string RemoveAzureADRolesMasterErrorMessage { get; set; }
    }

    public class AzureADv2IsUserInRoleResponse
    {
        public bool UserIsAssignedToRole { get; set; }
    }

    public class AzureADv2GetAzureADUserRoleAssignmentsResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfRoleAssignmentsFound { get; set; }
    }

    public class AzureADv2RemoveUserFromRoleResponse
    {
        public bool UserRemovedFromRole { get; set; }
    }

    public class AzureADv2RemoveUserFromAllRolesResponse
    {
        public int AzureADRolesRemovedSuccessfully { get; set; }
        public int AzureADRolesFailedToRemove { get; set; }
        public string RemoveAzureADRolesErrorMessage { get; set; }
    }

    public class AzureADv2GetAzureADGroupMembersResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfGroupMembersFound { get; set; }
    }

    public class OpenO365PowerShellRunspaceResponse
    {
        public bool OpenO365PowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum openO365PowerShellRunspaceconnectionMethodInput
    {
        [EnumMember(Value = "EXO V1 local")]
        EXOV1LocalRemoteExchangeOnlineIsImportedLocally,
        [EnumMember(Value = "EXO V1 remote")]
        EXOV1RemoteCommandsRunInRemoteExchangeOnline,
        [EnumMember(Value = "EXO V2")]
        EXOV2ExchangeOnlinePowerShellV2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum openO365PowerShellRunspacecommandTypesToImportLocallyInput
    {
        [EnumMember(Value = "All")]
        AllAllO365ExchangePSCommands,
        [EnumMember(Value = "IA-Connect only")]
        IAConnectOnlyOnlyO365ExchangePSCommandsUsedByIAConnect,
        [EnumMember(Value = "Specified")]
        SpecifiedOnlySpecifiedO365ExchangePSCommands
    }

    public class OpenO365PowerShellRunspaceWithCertificateResponse
    {
        public bool OpenO365PowerShellRunspaceWithCertificateResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum openO365PowerShellRunspaceWithCertificateconnectionMethodInput
    {
        [EnumMember(Value = "EXO V2")]
        EXOV2ExchangeOnlinePowerShellV2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocallyInput
    {
        [EnumMember(Value = "All")]
        AllAllO365ExchangePSCommands,
        [EnumMember(Value = "IA-Connect only")]
        IAConnectOnlyOnlyO365ExchangePSCommandsUsedByIAConnect,
        [EnumMember(Value = "Specified")]
        SpecifiedOnlySpecifiedO365ExchangePSCommands
    }

    public class IsO365PowerShellRunspaceOpenResponse
    {
        public bool O365RunspaceOpen { get; set; }
        public string Office365ConnectionMethod { get; set; }
        public int PowerShellRunspacePID { get; set; }
        public bool IsAgentHostingPowerShellRunSpace { get; set; }
    }

    public class RunO365PowerShellAutomationScriptResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int ThreadId { get; set; }
    }

    public class runO365PowerShellAutomationScriptpowerShellCommandParametersInputItem
    {
        public string Name { get; set; }
        public string StringValue { get; set; }
        public int IntValue { get; set; }
        public bool BooleanValue { get; set; }
        public double DecimalValue { get; set; }
        public JToken ObjectValue { get; set; }
    }

    public class CloseO365PowerShellRunspaceResponse
    {
        public bool CloseO365PowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class O365GetO365MailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfMailboxesFound { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum o365GetO365MailboxfilterPropertyComparisonInput
    {
        [EnumMember(Value = "Equals")]
        EqualsExactMatch,
        [EnumMember(Value = "Not equals")]
        NotEqualsNotEqualsExactMatch,
        [EnumMember(Value = "Like")]
        LikeEqualsWithWildcards,
        [EnumMember(Value = "Not like")]
        NotLikeNotEqualsWithWildcards,
        [EnumMember(Value = "Greater than")]
        GreaterThanNumericComparison,
        [EnumMember(Value = "Less than")]
        LessThanNumericComparison,
        [EnumMember(Value = "Raw")]
        RawEnterFilterManually
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum o365GetO365MailboxrecipientTypeDetailsInput
    {
        DiscoveryMailbox,
        EquipmentMailbox,
        GroupMailbox,
        LegacyMailbox,
        LinkedMailbox,
        LinkedRoomMailbox,
        RoomMailbox,
        SchedulingMailbox,
        SharedMailbox,
        TeamMailbox,
        UserMailbox
    }

    public class O365AddMailboxPermissionResponse
    {
        public bool O365AddMailboxPermissionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class O365RemoveMailboxPermissionResponse
    {
        public bool O365RemoveMailboxPermissionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class O365AddDistributionGroupMemberResponse
    {
        public bool O365AddDistributionGroupMemberResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class O365GetO365DistributionGroupResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfGroupsFound { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum o365GetO365DistributionGroupfilterPropertyComparisonInput
    {
        [EnumMember(Value = "Equals")]
        EqualsExactMatch,
        [EnumMember(Value = "Not equals")]
        NotEqualsNotEqualsExactMatch,
        [EnumMember(Value = "Like")]
        LikeEqualsWithWildcards,
        [EnumMember(Value = "Not like")]
        NotLikeNotEqualsWithWildcards,
        [EnumMember(Value = "Greater than")]
        GreaterThanNumericComparison,
        [EnumMember(Value = "Less than")]
        LessThanNumericComparison,
        [EnumMember(Value = "Raw")]
        RawEnterFilterManually
    }

    public class O365NewO365DistributionGroupResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public bool GroupAlreadyExists { get; set; }
        public string CreatedGroupDN { get; set; }
        public string CreatedGroupGUID { get; set; }
        public string CreatedGroupIdentity { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum o365NewO365DistributionGroupmemberDepartRestrictionInput
    {
        Open,
        Closed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum o365NewO365DistributionGroupmemberJoinRestrictionInput
    {
        Open,
        Closed,
        ApprovalRequired
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum o365NewO365DistributionGrouptypeInput
    {
        Distribution,
        Security
    }

    public class O365RemoveDistributionGroupResponse
    {
        public bool O365RemoveDistributionGroupResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class O365SetO365MailboxResponse
    {
        public bool O365SetO365MailboxResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum o365SetO365MailboxtypeInput
    {
        Regular,
        Room,
        Equipment,
        Shared,
        Workspace
    }

    public class O365WaitForO365MailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfMailboxesFound { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum o365WaitForO365MailboxrecipientTypeDetailsInput
    {
        DiscoveryMailbox,
        EquipmentMailbox,
        GroupMailbox,
        LegacyMailbox,
        LinkedMailbox,
        LinkedRoomMailbox,
        RoomMailbox,
        SchedulingMailbox,
        SharedMailbox,
        TeamMailbox,
        UserMailbox
    }

    public class O365SetO365MailboxAutoReplyConfigurationResponse
    {
        public bool O365SetO365MailboxAutoReplyConfigurationResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum o365SetO365MailboxAutoReplyConfigurationautoReplyStateInput
    {
        [EnumMember(Value = "Enabled")]
        EnabledAutomaticRepliesAreSent,
        [EnumMember(Value = "Disabled")]
        DisabledAutomaticRepliesAreNotSent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum o365SetO365MailboxAutoReplyConfigurationexternalAudienceInput
    {
        [EnumMember(Value = "None")]
        NoneRepliesAreNotSentToExternalSenders,
        [EnumMember(Value = "Known")]
        KnownRepliesAreOnlySentToSendersInContactList,
        [EnumMember(Value = "All")]
        AllRepliesAreSentToAllSenders
    }

    public class O365RemoveDistributionGroupMemberResponse
    {
        public bool O365RemoveDistributionGroupMemberResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class O365GetMailboxDistributionGroupMembershipResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfDistributionGroupsFound { get; set; }
    }

    public class O365GetDistributionGroupMembersResponse
    {
        public string O365DistributionGroupMembersJSON { get; set; }
        public int O365CountOfDistributionGroupsMembers { get; set; }
    }

    public class O365RemoveMailboxFromAllDistributionGroupsResponse
    {
        public int O365GroupsRemovedSuccessfully { get; set; }
        public int O365GroupsFailedToRemove { get; set; }
        public int O365GroupsExcludedFromRemoval { get; set; }
        public string RemoveO365GroupsErrorMessage { get; set; }
        public int ThreadId { get; set; }
    }

    public class O365NewMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string NewUserMicrosoftOnlineServicesID { get; set; }
        public string NewMailboxGUID { get; set; }
        public string NewMailboxPrimarySmtpAddress { get; set; }
    }

    public class O365NewSharedMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string NewUserMicrosoftOnlineServicesID { get; set; }
        public string NewMailboxGUID { get; set; }
        public string NewMailboxPrimarySmtpAddress { get; set; }
    }

    public class O365EnableArchiveMailboxResponse
    {
        public bool O365EnableArchiveMailboxResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class O365DoesMailboxHaveAnArchiveResponse
    {
        public bool MailboxHasAnArchive { get; set; }
    }

    public class JMLGetNextAvailableAccountNameResponse
    {
        public string ActiveDirectorySAMAccountName { get; set; }
        public string ActiveDirectoryAccountName { get; set; }
        public string ActiveDirectoryUPN { get; set; }
        public string ActiveDirectoryEmailAddress { get; set; }
        public string ExchangeMailboxAddress { get; set; }
        public string ExchangeMailboxAlias { get; set; }
        public string ExchangeRemoteMailboxAddress { get; set; }
        public string AzureADUPN { get; set; }
        public string Office365UPN { get; set; }
        public string Office365MailboxEmailAddress { get; set; }
        public int MValue { get; set; }
        public int NValue { get; set; }
        public int XValue { get; set; }
        public int FormatIndexUsed { get; set; }
    }

    public class jMLGetNextAvailableAccountNamepropertiesToCheckListInputItem
    {
        public jMLGetNextAvailableAccountNamepropertiesToCheckListInputItemPropertyToCheckType PropertyToCheck { get; set; }
        public string PropertyNameFormat { get; set; }
        public string PropertyNameFallbackFormat { get; set; }
        public string PropertyNameFallbackFormat2 { get; set; }
        public int PropertyNameMaxLength { get; set; }
        public jMLGetNextAvailableAccountNamepropertiesToCheckListInputItemPropertyNameMaxLengthFieldToCutType PropertyNameMaxLengthFieldToCut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum jMLGetNextAvailableAccountNamepropertiesToCheckListInputItemPropertyToCheckType
    {
        [EnumMember(Value = "ADSAMAccountName")]
        ActiveDirectorySAMAccountName,
        [EnumMember(Value = "ADAccountName")]
        ActiveDirectoryAccountName,
        [EnumMember(Value = "ADUPN")]
        ActiveDirectoryUserPrincipalName,
        [EnumMember(Value = "ADEmailAddress")]
        ActiveDirectoryEmailAddress,
        [EnumMember(Value = "ExchangeMailboxAddress")]
        ExchangeMailboxPrimaryMailAddress,
        [EnumMember(Value = "ExchangeRecipientAddress")]
        ExchangeMailboxEmailAddressesCheckRecipients,
        ExchangeMailboxAlias,
        [EnumMember(Value = "ExchangeRemoteMailboxAddress")]
        ExchangeRemoteMailboxEmailAddress,
        [EnumMember(Value = "AzureADUPN")]
        AzureADUserPrincipalName,
        [EnumMember(Value = "Office365UPN")]
        Office365UserPrincipalName,
        Office365MailboxEmailAddress
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum jMLGetNextAvailableAccountNamepropertiesToCheckListInputItemPropertyNameMaxLengthFieldToCutType
    {
        FirstName,
        MiddleName,
        LastName,
        FieldA,
        FieldB,
        FieldC,
        FieldD
    }

    public class JMLConnectToJMLEnvironmentResponse
    {
        public bool JMLConnectToJMLEnvironmentResult { get; set; }
        public string ErrorMessage { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectjml;

    public partial class WorkflowManagedActions
    {
        public IaconnectjmlActions Iaconnectjml(string connectionId) => new IaconnectjmlActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectjmlTriggers Iaconnectjml(string connectionId) => new IaconnectjmlTriggers(connectionId);
    }
}
