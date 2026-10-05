//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectjml
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectjmlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildRunActiveDirectoryPowerShellAutomationScript))]
        public IBodyWorkflowAction<RunActiveDirectoryPowerShellAutomationScriptResponse> RunActiveDirectoryPowerShellAutomationScript([WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptworkflow, [WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptisNoResultAnError = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate = null, [WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread = null, [WorkflowExpression] Func<int> runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput = null, [WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON = null, [WorkflowExpression] Func<runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunActiveDirectoryPowerShellAutomationScriptResponse> __BuildRunActiveDirectoryPowerShellAutomationScript(WorkflowValue<string> runActiveDirectoryPowerShellAutomationScriptworkflow, WorkflowValue<string> runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents = null, WorkflowValue<bool> runActiveDirectoryPowerShellAutomationScriptisNoResultAnError = null, WorkflowValue<bool> runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes = null, WorkflowValue<bool> runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean = null, WorkflowValue<bool> runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal = null, WorkflowValue<bool> runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate = null, WorkflowValue<string> runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, WorkflowValue<bool> runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread = null, WorkflowValue<int> runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId = null, WorkflowValue<int> runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread = null, WorkflowValue<bool> runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword = null, WorkflowValue<bool> runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput = null, WorkflowValue<string> runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON = null, WorkflowValue<string> runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON = null, WorkflowValue<runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptworkflow, nameof(runActiveDirectoryPowerShellAutomationScriptworkflow), required: true);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents, nameof(runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents), required: false);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptisNoResultAnError, nameof(runActiveDirectoryPowerShellAutomationScriptisNoResultAnError), required: false);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes, nameof(runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes), required: false);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean, nameof(runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean), required: false);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal, nameof(runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal), required: false);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate, nameof(runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate), required: false);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON, nameof(runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON), required: false);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread, nameof(runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread), required: false);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId, nameof(runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId), required: false);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread, nameof(runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread), required: false);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword, nameof(runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword), required: false);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput, nameof(runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput), required: false);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON, nameof(runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON), required: false);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON, nameof(runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON), required: false);
            WorkflowValue.Validate(runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters, nameof(runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters), required: false);
            return new DeferredBodyAction<RunActiveDirectoryPowerShellAutomationScriptResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/RunActiveDirectoryPowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runActiveDirectoryPowerShellAutomationScript = new JObject();
                var runActiveDirectoryPowerShellAutomationScriptpropCount = 0;
                if (runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (runActiveDirectoryPowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptisNoResultAnError);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["IsNoResultAnError"] = false;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes != null)
                {
                    if (runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["ReturnComplexTypes"] = false;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean != null)
                {
                    if (runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["ReturnBooleanAsBoolean"] = false;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal != null)
                {
                    if (runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["ReturnNumericAsDecimal"] = false;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate != null)
                {
                    if (runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["ReturnDateAsDate"] = false;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["RunScriptAsThread"] = false;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["SecondsToWaitForThread"] = 90;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword != null)
                {
                    if (runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["ScriptContainsStoredPassword"] = true;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput != null)
                {
                    if (runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput);
                        runActiveDirectoryPowerShellAutomationScriptpropCount++;
                    }

                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runActiveDirectoryPowerShellAutomationScript["LogVerboseOutput"] = false;
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                runActiveDirectoryPowerShellAutomationScriptpropCount++;
                runActiveDirectoryPowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptworkflow);
                if (runActiveDirectoryPowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runActiveDirectoryPowerShellAutomationScript;
                }

                return new ApiConnectionAction<RunActiveDirectoryPowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildOpenActiveDirectoryPowerShellRunspaceWithCredentials))]
        public IBodyWorkflowAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse> OpenActiveDirectoryPowerShellRunspaceWithCredentials([WorkflowExpression] Func<string> openActiveDirectoryPowerShellRunspaceWithCredentialsusername, [WorkflowExpression] Func<string> openActiveDirectoryPowerShellRunspaceWithCredentialspassword, [WorkflowExpression] Func<string> openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow, [WorkflowExpression] Func<string> openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer = null, [WorkflowExpression] Func<bool> openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL = null, [WorkflowExpression] Func<int> openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse> __BuildOpenActiveDirectoryPowerShellRunspaceWithCredentials(WorkflowValue<string> openActiveDirectoryPowerShellRunspaceWithCredentialsusername, WorkflowValue<string> openActiveDirectoryPowerShellRunspaceWithCredentialspassword, WorkflowValue<string> openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow, WorkflowValue<string> openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer = null, WorkflowValue<bool> openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL = null, WorkflowValue<int> openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort = null)
        {
            WorkflowValue.Validate(openActiveDirectoryPowerShellRunspaceWithCredentialsusername, nameof(openActiveDirectoryPowerShellRunspaceWithCredentialsusername), required: true);
            WorkflowValue.Validate(openActiveDirectoryPowerShellRunspaceWithCredentialspassword, nameof(openActiveDirectoryPowerShellRunspaceWithCredentialspassword), required: true);
            WorkflowValue.Validate(openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow, nameof(openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow), required: true);
            WorkflowValue.Validate(openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer, nameof(openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer), required: false);
            WorkflowValue.Validate(openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL, nameof(openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL), required: false);
            WorkflowValue.Validate(openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort, nameof(openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort), required: false);
            return new DeferredBodyAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenActiveDirectoryPowerShellRunspaceWithCredentials";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openActiveDirectoryPowerShellRunspaceWithCredentials = new JObject();
                var openActiveDirectoryPowerShellRunspaceWithCredentialspropCount = 0;
                openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                openActiveDirectoryPowerShellRunspaceWithCredentials["Username"] = ExpressionConverter.ConvertO(openActiveDirectoryPowerShellRunspaceWithCredentialsusername);
                openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                openActiveDirectoryPowerShellRunspaceWithCredentials["Password"] = ExpressionConverter.ConvertO(openActiveDirectoryPowerShellRunspaceWithCredentialspassword);
                if (openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer != null)
                {
                    openActiveDirectoryPowerShellRunspaceWithCredentials["RemoteComputer"] = ExpressionConverter.ConvertO(openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer);
                    openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                }

                if (openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL != null)
                {
                    if (openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL != null)
                    {
                        openActiveDirectoryPowerShellRunspaceWithCredentials["UseSSL"] = ExpressionConverter.ConvertO(openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL);
                        openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                    }

                    openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                }
                else
                {
                    openActiveDirectoryPowerShellRunspaceWithCredentials["UseSSL"] = false;
                    openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                }

                if (openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort != null)
                {
                    openActiveDirectoryPowerShellRunspaceWithCredentials["AlternativeTCPPort"] = ExpressionConverter.ConvertO(openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort);
                    openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                }

                openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                openActiveDirectoryPowerShellRunspaceWithCredentials["Workflow"] = ExpressionConverter.ConvertO(openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow);
                if (openActiveDirectoryPowerShellRunspaceWithCredentialspropCount > 0)
                {
                    callPayload.Body = openActiveDirectoryPowerShellRunspaceWithCredentials;
                }

                return new ApiConnectionAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildCloseActiveDirectoryPowerShellRunspace))]
        public IBodyWorkflowAction<CloseActiveDirectoryPowerShellRunspaceResponse> CloseActiveDirectoryPowerShellRunspace([WorkflowExpression] Func<string> closeActiveDirectoryPowerShellRunspaceworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CloseActiveDirectoryPowerShellRunspaceResponse> __BuildCloseActiveDirectoryPowerShellRunspace(WorkflowValue<string> closeActiveDirectoryPowerShellRunspaceworkflow)
        {
            WorkflowValue.Validate(closeActiveDirectoryPowerShellRunspaceworkflow, nameof(closeActiveDirectoryPowerShellRunspaceworkflow), required: true);
            return new DeferredBodyAction<CloseActiveDirectoryPowerShellRunspaceResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/CloseActiveDirectoryPowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var closeActiveDirectoryPowerShellRunspace = new JObject();
                var closeActiveDirectoryPowerShellRunspacepropCount = 0;
                closeActiveDirectoryPowerShellRunspacepropCount++;
                closeActiveDirectoryPowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(closeActiveDirectoryPowerShellRunspaceworkflow);
                if (closeActiveDirectoryPowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = closeActiveDirectoryPowerShellRunspace;
                }

                return new ApiConnectionAction<CloseActiveDirectoryPowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildIsActiveDirectoryPowerShellRunspaceOpen))]
        public IBodyWorkflowAction<IsActiveDirectoryPowerShellRunspaceOpenResponse> IsActiveDirectoryPowerShellRunspaceOpen([WorkflowExpression] Func<string> isActiveDirectoryPowerShellRunspaceOpenworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsActiveDirectoryPowerShellRunspaceOpenResponse> __BuildIsActiveDirectoryPowerShellRunspaceOpen(WorkflowValue<string> isActiveDirectoryPowerShellRunspaceOpenworkflow)
        {
            WorkflowValue.Validate(isActiveDirectoryPowerShellRunspaceOpenworkflow, nameof(isActiveDirectoryPowerShellRunspaceOpenworkflow), required: true);
            return new DeferredBodyAction<IsActiveDirectoryPowerShellRunspaceOpenResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/IsActiveDirectoryPowerShellRunspaceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isActiveDirectoryPowerShellRunspaceOpen = new JObject();
                var isActiveDirectoryPowerShellRunspaceOpenpropCount = 0;
                isActiveDirectoryPowerShellRunspaceOpenpropCount++;
                isActiveDirectoryPowerShellRunspaceOpen["Workflow"] = ExpressionConverter.ConvertO(isActiveDirectoryPowerShellRunspaceOpenworkflow);
                if (isActiveDirectoryPowerShellRunspaceOpenpropCount > 0)
                {
                    callPayload.Body = isActiveDirectoryPowerShellRunspaceOpen;
                }

                return new ApiConnectionAction<IsActiveDirectoryPowerShellRunspaceOpenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildOpenLocalPassthroughActiveDirectoryPowerShellRunspace))]
        public IBodyWorkflowAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse> OpenLocalPassthroughActiveDirectoryPowerShellRunspace([WorkflowExpression] Func<string> openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse> __BuildOpenLocalPassthroughActiveDirectoryPowerShellRunspace(WorkflowValue<string> openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow)
        {
            WorkflowValue.Validate(openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow, nameof(openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow), required: true);
            return new DeferredBodyAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenLocalPassthroughActiveDirectoryPowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openLocalPassthroughActiveDirectoryPowerShellRunspace = new JObject();
                var openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount = 0;
                openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount++;
                openLocalPassthroughActiveDirectoryPowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow);
                if (openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = openLocalPassthroughActiveDirectoryPowerShellRunspace;
                }

                return new ApiConnectionAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryAddADUser))]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserResponse> ActiveDirectoryAddADUser([WorkflowExpression] Func<string> activeDirectoryAddADUsername, [WorkflowExpression] Func<string> activeDirectoryAddADUserworkflow, [WorkflowExpression] Func<string> activeDirectoryAddADUseruserPrincipalName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUsersamAccountName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUsergivenName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUsersurName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUserpath = null, [WorkflowExpression] Func<string> activeDirectoryAddADUserdescription = null, [WorkflowExpression] Func<string> activeDirectoryAddADUserdisplayName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUseraccountPassword = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUseraccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserenabled = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserchangePasswordAtLogon = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUsercannotChangePassword = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserpasswordNeverExpires = null, [WorkflowExpression] Func<string> activeDirectoryAddADUseraDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserResponse> __BuildActiveDirectoryAddADUser(WorkflowValue<string> activeDirectoryAddADUsername, WorkflowValue<string> activeDirectoryAddADUserworkflow, WorkflowValue<string> activeDirectoryAddADUseruserPrincipalName = null, WorkflowValue<string> activeDirectoryAddADUsersamAccountName = null, WorkflowValue<string> activeDirectoryAddADUsergivenName = null, WorkflowValue<string> activeDirectoryAddADUsersurName = null, WorkflowValue<string> activeDirectoryAddADUserpath = null, WorkflowValue<string> activeDirectoryAddADUserdescription = null, WorkflowValue<string> activeDirectoryAddADUserdisplayName = null, WorkflowValue<string> activeDirectoryAddADUseraccountPassword = null, WorkflowValue<bool> activeDirectoryAddADUseraccountPasswordIsStoredPassword = null, WorkflowValue<bool> activeDirectoryAddADUserenabled = null, WorkflowValue<bool> activeDirectoryAddADUserchangePasswordAtLogon = null, WorkflowValue<bool> activeDirectoryAddADUsercannotChangePassword = null, WorkflowValue<bool> activeDirectoryAddADUserpasswordNeverExpires = null, WorkflowValue<string> activeDirectoryAddADUseraDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryAddADUsername, nameof(activeDirectoryAddADUsername), required: true);
            WorkflowValue.Validate(activeDirectoryAddADUserworkflow, nameof(activeDirectoryAddADUserworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryAddADUseruserPrincipalName, nameof(activeDirectoryAddADUseruserPrincipalName), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUsersamAccountName, nameof(activeDirectoryAddADUsersamAccountName), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUsergivenName, nameof(activeDirectoryAddADUsergivenName), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUsersurName, nameof(activeDirectoryAddADUsersurName), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUserpath, nameof(activeDirectoryAddADUserpath), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUserdescription, nameof(activeDirectoryAddADUserdescription), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUserdisplayName, nameof(activeDirectoryAddADUserdisplayName), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUseraccountPassword, nameof(activeDirectoryAddADUseraccountPassword), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUseraccountPasswordIsStoredPassword, nameof(activeDirectoryAddADUseraccountPasswordIsStoredPassword), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUserenabled, nameof(activeDirectoryAddADUserenabled), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUserchangePasswordAtLogon, nameof(activeDirectoryAddADUserchangePasswordAtLogon), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUsercannotChangePassword, nameof(activeDirectoryAddADUsercannotChangePassword), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUserpasswordNeverExpires, nameof(activeDirectoryAddADUserpasswordNeverExpires), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUseraDServer, nameof(activeDirectoryAddADUseraDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryAddADUserResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddADUser = new JObject();
                var activeDirectoryAddADUserpropCount = 0;
                activeDirectoryAddADUserpropCount++;
                activeDirectoryAddADUser["Name"] = ExpressionConverter.ConvertO(activeDirectoryAddADUsername);
                if (activeDirectoryAddADUseruserPrincipalName != null)
                {
                    activeDirectoryAddADUser["UserPrincipalName"] = ExpressionConverter.ConvertO(activeDirectoryAddADUseruserPrincipalName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUsersamAccountName != null)
                {
                    activeDirectoryAddADUser["SamAccountName"] = ExpressionConverter.ConvertO(activeDirectoryAddADUsersamAccountName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUsergivenName != null)
                {
                    activeDirectoryAddADUser["GivenName"] = ExpressionConverter.ConvertO(activeDirectoryAddADUsergivenName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUsersurName != null)
                {
                    activeDirectoryAddADUser["SurName"] = ExpressionConverter.ConvertO(activeDirectoryAddADUsersurName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUserpath != null)
                {
                    activeDirectoryAddADUser["Path"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserpath);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUserdescription != null)
                {
                    activeDirectoryAddADUser["Description"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserdescription);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUserdisplayName != null)
                {
                    activeDirectoryAddADUser["DisplayName"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserdisplayName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUseraccountPassword != null)
                {
                    activeDirectoryAddADUser["AccountPassword"] = ExpressionConverter.ConvertO(activeDirectoryAddADUseraccountPassword);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUseraccountPasswordIsStoredPassword != null)
                {
                    if (activeDirectoryAddADUseraccountPasswordIsStoredPassword != null)
                    {
                        activeDirectoryAddADUser["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(activeDirectoryAddADUseraccountPasswordIsStoredPassword);
                        activeDirectoryAddADUserpropCount++;
                    }

                    activeDirectoryAddADUserpropCount++;
                }
                else
                {
                    activeDirectoryAddADUser["AccountPasswordIsStoredPassword"] = false;
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUserenabled != null)
                {
                    if (activeDirectoryAddADUserenabled != null)
                    {
                        activeDirectoryAddADUser["Enabled"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserenabled);
                        activeDirectoryAddADUserpropCount++;
                    }

                    activeDirectoryAddADUserpropCount++;
                }
                else
                {
                    activeDirectoryAddADUser["Enabled"] = true;
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUserchangePasswordAtLogon != null)
                {
                    if (activeDirectoryAddADUserchangePasswordAtLogon != null)
                    {
                        activeDirectoryAddADUser["ChangePasswordAtLogon"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserchangePasswordAtLogon);
                        activeDirectoryAddADUserpropCount++;
                    }

                    activeDirectoryAddADUserpropCount++;
                }
                else
                {
                    activeDirectoryAddADUser["ChangePasswordAtLogon"] = true;
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUsercannotChangePassword != null)
                {
                    if (activeDirectoryAddADUsercannotChangePassword != null)
                    {
                        activeDirectoryAddADUser["CannotChangePassword"] = ExpressionConverter.ConvertO(activeDirectoryAddADUsercannotChangePassword);
                        activeDirectoryAddADUserpropCount++;
                    }

                    activeDirectoryAddADUserpropCount++;
                }
                else
                {
                    activeDirectoryAddADUser["CannotChangePassword"] = false;
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUserpasswordNeverExpires != null)
                {
                    if (activeDirectoryAddADUserpasswordNeverExpires != null)
                    {
                        activeDirectoryAddADUser["PasswordNeverExpires"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserpasswordNeverExpires);
                        activeDirectoryAddADUserpropCount++;
                    }

                    activeDirectoryAddADUserpropCount++;
                }
                else
                {
                    activeDirectoryAddADUser["PasswordNeverExpires"] = false;
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUseraDServer != null)
                {
                    activeDirectoryAddADUser["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryAddADUseraDServer);
                    activeDirectoryAddADUserpropCount++;
                }

                activeDirectoryAddADUserpropCount++;
                activeDirectoryAddADUser["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserworkflow);
                if (activeDirectoryAddADUserpropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddADUser;
                }

                return new ApiConnectionAction<ActiveDirectoryAddADUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryGetADUserByIdentity))]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserByIdentityResponse> ActiveDirectoryGetADUserByIdentity([WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityidentity = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityfilterPropertyName = null, [WorkflowExpression] Func<activeDirectoryGetADUserByIdentityfilterPropertyComparisonInput> activeDirectoryGetADUserByIdentityfilterPropertyComparison = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityfilterPropertyValue = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentitysearchOUBase = null, [WorkflowExpression] Func<bool> activeDirectoryGetADUserByIdentitysearchOUBaseSubtree = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityproperties = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityaDServer = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserByIdentityResponse> __BuildActiveDirectoryGetADUserByIdentity(WorkflowValue<string> activeDirectoryGetADUserByIdentityworkflow, WorkflowValue<string> activeDirectoryGetADUserByIdentityidentity = null, WorkflowValue<string> activeDirectoryGetADUserByIdentityfilterPropertyName = null, WorkflowValue<activeDirectoryGetADUserByIdentityfilterPropertyComparisonInput> activeDirectoryGetADUserByIdentityfilterPropertyComparison = null, WorkflowValue<string> activeDirectoryGetADUserByIdentityfilterPropertyValue = null, WorkflowValue<string> activeDirectoryGetADUserByIdentitysearchOUBase = null, WorkflowValue<bool> activeDirectoryGetADUserByIdentitysearchOUBaseSubtree = null, WorkflowValue<string> activeDirectoryGetADUserByIdentityproperties = null, WorkflowValue<string> activeDirectoryGetADUserByIdentityaDServer = null, WorkflowValue<string> activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON = null, WorkflowValue<string> activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON = null, WorkflowValue<string> activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON = null)
        {
            WorkflowValue.Validate(activeDirectoryGetADUserByIdentityworkflow, nameof(activeDirectoryGetADUserByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryGetADUserByIdentityidentity, nameof(activeDirectoryGetADUserByIdentityidentity), required: false);
            WorkflowValue.Validate(activeDirectoryGetADUserByIdentityfilterPropertyName, nameof(activeDirectoryGetADUserByIdentityfilterPropertyName), required: false);
            WorkflowValue.Validate(activeDirectoryGetADUserByIdentityfilterPropertyComparison, nameof(activeDirectoryGetADUserByIdentityfilterPropertyComparison), required: false);
            WorkflowValue.Validate(activeDirectoryGetADUserByIdentityfilterPropertyValue, nameof(activeDirectoryGetADUserByIdentityfilterPropertyValue), required: false);
            WorkflowValue.Validate(activeDirectoryGetADUserByIdentitysearchOUBase, nameof(activeDirectoryGetADUserByIdentitysearchOUBase), required: false);
            WorkflowValue.Validate(activeDirectoryGetADUserByIdentitysearchOUBaseSubtree, nameof(activeDirectoryGetADUserByIdentitysearchOUBaseSubtree), required: false);
            WorkflowValue.Validate(activeDirectoryGetADUserByIdentityproperties, nameof(activeDirectoryGetADUserByIdentityproperties), required: false);
            WorkflowValue.Validate(activeDirectoryGetADUserByIdentityaDServer, nameof(activeDirectoryGetADUserByIdentityaDServer), required: false);
            WorkflowValue.Validate(activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON, nameof(activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON), required: false);
            WorkflowValue.Validate(activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON, nameof(activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON), required: false);
            WorkflowValue.Validate(activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON, nameof(activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON), required: false);
            return new DeferredBodyAction<ActiveDirectoryGetADUserByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetADUserByIdentity = new JObject();
                var activeDirectoryGetADUserByIdentitypropCount = 0;
                if (activeDirectoryGetADUserByIdentityidentity != null)
                {
                    activeDirectoryGetADUserByIdentity["Identity"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityidentity);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentityfilterPropertyName != null)
                {
                    activeDirectoryGetADUserByIdentity["FilterPropertyName"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityfilterPropertyName);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentityfilterPropertyComparison != null)
                {
                    if (activeDirectoryGetADUserByIdentityfilterPropertyComparison != null)
                    {
                        activeDirectoryGetADUserByIdentity["FilterPropertyComparison"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityfilterPropertyComparison);
                        activeDirectoryGetADUserByIdentitypropCount++;
                    }

                    activeDirectoryGetADUserByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryGetADUserByIdentity["FilterPropertyComparison"] = "Equals";
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentityfilterPropertyValue != null)
                {
                    activeDirectoryGetADUserByIdentity["FilterPropertyValue"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityfilterPropertyValue);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentitysearchOUBase != null)
                {
                    activeDirectoryGetADUserByIdentity["SearchOUBase"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentitysearchOUBase);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentitysearchOUBaseSubtree != null)
                {
                    if (activeDirectoryGetADUserByIdentitysearchOUBaseSubtree != null)
                    {
                        activeDirectoryGetADUserByIdentity["SearchOUBaseSubtree"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentitysearchOUBaseSubtree);
                        activeDirectoryGetADUserByIdentitypropCount++;
                    }

                    activeDirectoryGetADUserByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryGetADUserByIdentity["SearchOUBaseSubtree"] = true;
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentityproperties != null)
                {
                    activeDirectoryGetADUserByIdentity["Properties"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityproperties);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentityaDServer != null)
                {
                    activeDirectoryGetADUserByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityaDServer);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON != null)
                {
                    activeDirectoryGetADUserByIdentity["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON != null)
                {
                    activeDirectoryGetADUserByIdentity["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON != null)
                {
                    activeDirectoryGetADUserByIdentity["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                activeDirectoryGetADUserByIdentitypropCount++;
                activeDirectoryGetADUserByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityworkflow);
                if (activeDirectoryGetADUserByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetADUserByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryGetADUserByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryGetOUFromUserDN))]
        public IBodyWorkflowAction<ActiveDirectoryGetOUFromUserDNResponse> ActiveDirectoryGetOUFromUserDN([WorkflowExpression] Func<string> activeDirectoryGetOUFromUserDNuserDN, [WorkflowExpression] Func<string> activeDirectoryGetOUFromUserDNworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryGetOUFromUserDNResponse> __BuildActiveDirectoryGetOUFromUserDN(WorkflowValue<string> activeDirectoryGetOUFromUserDNuserDN, WorkflowValue<string> activeDirectoryGetOUFromUserDNworkflow)
        {
            WorkflowValue.Validate(activeDirectoryGetOUFromUserDNuserDN, nameof(activeDirectoryGetOUFromUserDNuserDN), required: true);
            WorkflowValue.Validate(activeDirectoryGetOUFromUserDNworkflow, nameof(activeDirectoryGetOUFromUserDNworkflow), required: true);
            return new DeferredBodyAction<ActiveDirectoryGetOUFromUserDNResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetOUFromUserDN";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetOUFromUserDN = new JObject();
                var activeDirectoryGetOUFromUserDNpropCount = 0;
                activeDirectoryGetOUFromUserDNpropCount++;
                activeDirectoryGetOUFromUserDN["UserDN"] = ExpressionConverter.ConvertO(activeDirectoryGetOUFromUserDNuserDN);
                activeDirectoryGetOUFromUserDNpropCount++;
                activeDirectoryGetOUFromUserDN["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryGetOUFromUserDNworkflow);
                if (activeDirectoryGetOUFromUserDNpropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetOUFromUserDN;
                }

                return new ApiConnectionAction<ActiveDirectoryGetOUFromUserDNResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryGetDomainFQDNFromDN))]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainFQDNFromDNResponse> ActiveDirectoryGetDomainFQDNFromDN([WorkflowExpression] Func<string> activeDirectoryGetDomainFQDNFromDNdN, [WorkflowExpression] Func<string> activeDirectoryGetDomainFQDNFromDNworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainFQDNFromDNResponse> __BuildActiveDirectoryGetDomainFQDNFromDN(WorkflowValue<string> activeDirectoryGetDomainFQDNFromDNdN, WorkflowValue<string> activeDirectoryGetDomainFQDNFromDNworkflow)
        {
            WorkflowValue.Validate(activeDirectoryGetDomainFQDNFromDNdN, nameof(activeDirectoryGetDomainFQDNFromDNdN), required: true);
            WorkflowValue.Validate(activeDirectoryGetDomainFQDNFromDNworkflow, nameof(activeDirectoryGetDomainFQDNFromDNworkflow), required: true);
            return new DeferredBodyAction<ActiveDirectoryGetDomainFQDNFromDNResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetDomainFQDNFromDN";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetDomainFQDNFromDN = new JObject();
                var activeDirectoryGetDomainFQDNFromDNpropCount = 0;
                activeDirectoryGetDomainFQDNFromDNpropCount++;
                activeDirectoryGetDomainFQDNFromDN["DN"] = ExpressionConverter.ConvertO(activeDirectoryGetDomainFQDNFromDNdN);
                activeDirectoryGetDomainFQDNFromDNpropCount++;
                activeDirectoryGetDomainFQDNFromDN["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryGetDomainFQDNFromDNworkflow);
                if (activeDirectoryGetDomainFQDNFromDNpropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetDomainFQDNFromDN;
                }

                return new ApiConnectionAction<ActiveDirectoryGetDomainFQDNFromDNResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryGetADGroupByIdentity))]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupByIdentityResponse> ActiveDirectoryGetADGroupByIdentity([WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityidentity = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityfilterPropertyName = null, [WorkflowExpression] Func<activeDirectoryGetADGroupByIdentityfilterPropertyComparisonInput> activeDirectoryGetADGroupByIdentityfilterPropertyComparison = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityfilterPropertyValue = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentitysearchOUBase = null, [WorkflowExpression] Func<bool> activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree = null, [WorkflowExpression] Func<bool> activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupByIdentityResponse> __BuildActiveDirectoryGetADGroupByIdentity(WorkflowValue<string> activeDirectoryGetADGroupByIdentityworkflow, WorkflowValue<string> activeDirectoryGetADGroupByIdentityidentity = null, WorkflowValue<string> activeDirectoryGetADGroupByIdentityfilterPropertyName = null, WorkflowValue<activeDirectoryGetADGroupByIdentityfilterPropertyComparisonInput> activeDirectoryGetADGroupByIdentityfilterPropertyComparison = null, WorkflowValue<string> activeDirectoryGetADGroupByIdentityfilterPropertyValue = null, WorkflowValue<string> activeDirectoryGetADGroupByIdentitysearchOUBase = null, WorkflowValue<bool> activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree = null, WorkflowValue<bool> activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist = null, WorkflowValue<string> activeDirectoryGetADGroupByIdentityaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryGetADGroupByIdentityworkflow, nameof(activeDirectoryGetADGroupByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryGetADGroupByIdentityidentity, nameof(activeDirectoryGetADGroupByIdentityidentity), required: false);
            WorkflowValue.Validate(activeDirectoryGetADGroupByIdentityfilterPropertyName, nameof(activeDirectoryGetADGroupByIdentityfilterPropertyName), required: false);
            WorkflowValue.Validate(activeDirectoryGetADGroupByIdentityfilterPropertyComparison, nameof(activeDirectoryGetADGroupByIdentityfilterPropertyComparison), required: false);
            WorkflowValue.Validate(activeDirectoryGetADGroupByIdentityfilterPropertyValue, nameof(activeDirectoryGetADGroupByIdentityfilterPropertyValue), required: false);
            WorkflowValue.Validate(activeDirectoryGetADGroupByIdentitysearchOUBase, nameof(activeDirectoryGetADGroupByIdentitysearchOUBase), required: false);
            WorkflowValue.Validate(activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree, nameof(activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree), required: false);
            WorkflowValue.Validate(activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist, nameof(activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist), required: false);
            WorkflowValue.Validate(activeDirectoryGetADGroupByIdentityaDServer, nameof(activeDirectoryGetADGroupByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryGetADGroupByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADGroupByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetADGroupByIdentity = new JObject();
                var activeDirectoryGetADGroupByIdentitypropCount = 0;
                if (activeDirectoryGetADGroupByIdentityidentity != null)
                {
                    activeDirectoryGetADGroupByIdentity["Identity"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentityidentity);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (activeDirectoryGetADGroupByIdentityfilterPropertyName != null)
                {
                    activeDirectoryGetADGroupByIdentity["FilterPropertyName"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentityfilterPropertyName);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (activeDirectoryGetADGroupByIdentityfilterPropertyComparison != null)
                {
                    if (activeDirectoryGetADGroupByIdentityfilterPropertyComparison != null)
                    {
                        activeDirectoryGetADGroupByIdentity["FilterPropertyComparison"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentityfilterPropertyComparison);
                        activeDirectoryGetADGroupByIdentitypropCount++;
                    }

                    activeDirectoryGetADGroupByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryGetADGroupByIdentity["FilterPropertyComparison"] = "Equals";
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (activeDirectoryGetADGroupByIdentityfilterPropertyValue != null)
                {
                    activeDirectoryGetADGroupByIdentity["FilterPropertyValue"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentityfilterPropertyValue);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (activeDirectoryGetADGroupByIdentitysearchOUBase != null)
                {
                    activeDirectoryGetADGroupByIdentity["SearchOUBase"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentitysearchOUBase);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree != null)
                {
                    if (activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree != null)
                    {
                        activeDirectoryGetADGroupByIdentity["SearchOUBaseSubtree"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree);
                        activeDirectoryGetADGroupByIdentitypropCount++;
                    }

                    activeDirectoryGetADGroupByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryGetADGroupByIdentity["SearchOUBaseSubtree"] = true;
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist != null)
                {
                    if (activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist != null)
                    {
                        activeDirectoryGetADGroupByIdentity["RaiseExceptionIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist);
                        activeDirectoryGetADGroupByIdentitypropCount++;
                    }

                    activeDirectoryGetADGroupByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryGetADGroupByIdentity["RaiseExceptionIfGroupDoesNotExist"] = false;
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (activeDirectoryGetADGroupByIdentityaDServer != null)
                {
                    activeDirectoryGetADGroupByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentityaDServer);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                activeDirectoryGetADGroupByIdentitypropCount++;
                activeDirectoryGetADGroupByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentityworkflow);
                if (activeDirectoryGetADGroupByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetADGroupByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryGetADGroupByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryAddADGroupMemberByIdentity))]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupMemberByIdentityResponse> ActiveDirectoryAddADGroupMemberByIdentity([WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentitygroupIdentity = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentitygroupName = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentityaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupMemberByIdentityResponse> __BuildActiveDirectoryAddADGroupMemberByIdentity(WorkflowValue<string> activeDirectoryAddADGroupMemberByIdentityuserIdentity, WorkflowValue<string> activeDirectoryAddADGroupMemberByIdentityworkflow, WorkflowValue<string> activeDirectoryAddADGroupMemberByIdentitygroupIdentity = null, WorkflowValue<string> activeDirectoryAddADGroupMemberByIdentitygroupName = null, WorkflowValue<string> activeDirectoryAddADGroupMemberByIdentityaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryAddADGroupMemberByIdentityuserIdentity, nameof(activeDirectoryAddADGroupMemberByIdentityuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryAddADGroupMemberByIdentityworkflow, nameof(activeDirectoryAddADGroupMemberByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryAddADGroupMemberByIdentitygroupIdentity, nameof(activeDirectoryAddADGroupMemberByIdentitygroupIdentity), required: false);
            WorkflowValue.Validate(activeDirectoryAddADGroupMemberByIdentitygroupName, nameof(activeDirectoryAddADGroupMemberByIdentitygroupName), required: false);
            WorkflowValue.Validate(activeDirectoryAddADGroupMemberByIdentityaDServer, nameof(activeDirectoryAddADGroupMemberByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryAddADGroupMemberByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADGroupMemberByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddADGroupMemberByIdentity = new JObject();
                var activeDirectoryAddADGroupMemberByIdentitypropCount = 0;
                if (activeDirectoryAddADGroupMemberByIdentitygroupIdentity != null)
                {
                    activeDirectoryAddADGroupMemberByIdentity["GroupIdentity"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupMemberByIdentitygroupIdentity);
                    activeDirectoryAddADGroupMemberByIdentitypropCount++;
                }

                if (activeDirectoryAddADGroupMemberByIdentitygroupName != null)
                {
                    activeDirectoryAddADGroupMemberByIdentity["GroupName"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupMemberByIdentitygroupName);
                    activeDirectoryAddADGroupMemberByIdentitypropCount++;
                }

                activeDirectoryAddADGroupMemberByIdentitypropCount++;
                activeDirectoryAddADGroupMemberByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupMemberByIdentityuserIdentity);
                if (activeDirectoryAddADGroupMemberByIdentityaDServer != null)
                {
                    activeDirectoryAddADGroupMemberByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupMemberByIdentityaDServer);
                    activeDirectoryAddADGroupMemberByIdentitypropCount++;
                }

                activeDirectoryAddADGroupMemberByIdentitypropCount++;
                activeDirectoryAddADGroupMemberByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupMemberByIdentityworkflow);
                if (activeDirectoryAddADGroupMemberByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddADGroupMemberByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryAddADGroupMemberByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryAddMultipleADGroupMembersByIdentity))]
        public IBodyWorkflowAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse> ActiveDirectoryAddMultipleADGroupMembersByIdentity([WorkflowExpression] Func<string> activeDirectoryAddMultipleADGroupMembersByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity = null, [WorkflowExpression] Func<string> activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON = null, [WorkflowExpression] Func<bool> activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd = null, [WorkflowExpression] Func<bool> activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd = null, [WorkflowExpression] Func<bool> activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall = null, [WorkflowExpression] Func<string> activeDirectoryAddMultipleADGroupMembersByIdentityaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse> __BuildActiveDirectoryAddMultipleADGroupMembersByIdentity(WorkflowValue<string> activeDirectoryAddMultipleADGroupMembersByIdentityworkflow, WorkflowValue<string> activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity = null, WorkflowValue<string> activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON = null, WorkflowValue<bool> activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd = null, WorkflowValue<bool> activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd = null, WorkflowValue<bool> activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall = null, WorkflowValue<string> activeDirectoryAddMultipleADGroupMembersByIdentityaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryAddMultipleADGroupMembersByIdentityworkflow, nameof(activeDirectoryAddMultipleADGroupMembersByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity, nameof(activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity), required: false);
            WorkflowValue.Validate(activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON, nameof(activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON), required: false);
            WorkflowValue.Validate(activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd, nameof(activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd), required: false);
            WorkflowValue.Validate(activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd, nameof(activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd), required: false);
            WorkflowValue.Validate(activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall, nameof(activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall), required: false);
            WorkflowValue.Validate(activeDirectoryAddMultipleADGroupMembersByIdentityaDServer, nameof(activeDirectoryAddMultipleADGroupMembersByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddMultipleADGroupMembersByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddMultipleADGroupMembersByIdentity = new JObject();
                var activeDirectoryAddMultipleADGroupMembersByIdentitypropCount = 0;
                if (activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity != null)
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["GroupIdentity"] = ExpressionConverter.ConvertO(activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity);
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                if (activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON != null)
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["GroupMembersJSON"] = ExpressionConverter.ConvertO(activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON);
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                if (activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd != null)
                {
                    if (activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd != null)
                    {
                        activeDirectoryAddMultipleADGroupMembersByIdentity["ExceptionIfAnyMembersFailToAdd"] = ExpressionConverter.ConvertO(activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd);
                        activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                    }

                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["ExceptionIfAnyMembersFailToAdd"] = false;
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                if (activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd != null)
                {
                    if (activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd != null)
                    {
                        activeDirectoryAddMultipleADGroupMembersByIdentity["ExceptionIfAllMembersFailToAdd"] = ExpressionConverter.ConvertO(activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd);
                        activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                    }

                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["ExceptionIfAllMembersFailToAdd"] = false;
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                if (activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall != null)
                {
                    if (activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall != null)
                    {
                        activeDirectoryAddMultipleADGroupMembersByIdentity["AddAllMembersInASingleCall"] = ExpressionConverter.ConvertO(activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall);
                        activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                    }

                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["AddAllMembersInASingleCall"] = false;
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                if (activeDirectoryAddMultipleADGroupMembersByIdentityaDServer != null)
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryAddMultipleADGroupMembersByIdentityaDServer);
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                activeDirectoryAddMultipleADGroupMembersByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryAddMultipleADGroupMembersByIdentityworkflow);
                if (activeDirectoryAddMultipleADGroupMembersByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddMultipleADGroupMembersByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryAddADUserToMultipleADGroupsByName))]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse> ActiveDirectoryAddADUserToMultipleADGroupsByName([WorkflowExpression] Func<string> activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity, [WorkflowExpression] Func<string> activeDirectoryAddADUserToMultipleADGroupsByNameworkflow, [WorkflowExpression] Func<string> activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd = null, [WorkflowExpression] Func<string> activeDirectoryAddADUserToMultipleADGroupsByNameaDServer = null, [WorkflowExpression] Func<int> activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse> __BuildActiveDirectoryAddADUserToMultipleADGroupsByName(WorkflowValue<string> activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity, WorkflowValue<string> activeDirectoryAddADUserToMultipleADGroupsByNameworkflow, WorkflowValue<string> activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON = null, WorkflowValue<bool> activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd = null, WorkflowValue<bool> activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd = null, WorkflowValue<string> activeDirectoryAddADUserToMultipleADGroupsByNameaDServer = null, WorkflowValue<int> activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall = null)
        {
            WorkflowValue.Validate(activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity, nameof(activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryAddADUserToMultipleADGroupsByNameworkflow, nameof(activeDirectoryAddADUserToMultipleADGroupsByNameworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON, nameof(activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd, nameof(activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd, nameof(activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUserToMultipleADGroupsByNameaDServer, nameof(activeDirectoryAddADUserToMultipleADGroupsByNameaDServer), required: false);
            WorkflowValue.Validate(activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall, nameof(activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall), required: false);
            return new DeferredBodyAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADUserToMultipleADGroupsByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddADUserToMultipleADGroupsByName = new JObject();
                var activeDirectoryAddADUserToMultipleADGroupsByNamepropCount = 0;
                activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                activeDirectoryAddADUserToMultipleADGroupsByName["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity);
                if (activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON != null)
                {
                    activeDirectoryAddADUserToMultipleADGroupsByName["GroupNamesJSON"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON);
                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }

                if (activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd != null)
                {
                    if (activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd != null)
                    {
                        activeDirectoryAddADUserToMultipleADGroupsByName["ExceptionIfAnyGroupsFailToAdd"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd);
                        activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                    }

                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }
                else
                {
                    activeDirectoryAddADUserToMultipleADGroupsByName["ExceptionIfAnyGroupsFailToAdd"] = false;
                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }

                if (activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd != null)
                {
                    if (activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd != null)
                    {
                        activeDirectoryAddADUserToMultipleADGroupsByName["ExceptionIfAllGroupsFailToAdd"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd);
                        activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                    }

                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }
                else
                {
                    activeDirectoryAddADUserToMultipleADGroupsByName["ExceptionIfAllGroupsFailToAdd"] = false;
                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }

                if (activeDirectoryAddADUserToMultipleADGroupsByNameaDServer != null)
                {
                    activeDirectoryAddADUserToMultipleADGroupsByName["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserToMultipleADGroupsByNameaDServer);
                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }

                if (activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall != null)
                {
                    activeDirectoryAddADUserToMultipleADGroupsByName["MaxGroupsPerCall"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall);
                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }

                activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                activeDirectoryAddADUserToMultipleADGroupsByName["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserToMultipleADGroupsByNameworkflow);
                if (activeDirectoryAddADUserToMultipleADGroupsByNamepropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddADUserToMultipleADGroupsByName;
                }

                return new ApiConnectionAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryGetADUserGroupMembership))]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserGroupMembershipResponse> ActiveDirectoryGetADUserGroupMembership([WorkflowExpression] Func<string> activeDirectoryGetADUserGroupMembershipuserIdentity, [WorkflowExpression] Func<string> activeDirectoryGetADUserGroupMembershipworkflow, [WorkflowExpression] Func<string> activeDirectoryGetADUserGroupMembershipaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserGroupMembershipResponse> __BuildActiveDirectoryGetADUserGroupMembership(WorkflowValue<string> activeDirectoryGetADUserGroupMembershipuserIdentity, WorkflowValue<string> activeDirectoryGetADUserGroupMembershipworkflow, WorkflowValue<string> activeDirectoryGetADUserGroupMembershipaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryGetADUserGroupMembershipuserIdentity, nameof(activeDirectoryGetADUserGroupMembershipuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryGetADUserGroupMembershipworkflow, nameof(activeDirectoryGetADUserGroupMembershipworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryGetADUserGroupMembershipaDServer, nameof(activeDirectoryGetADUserGroupMembershipaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryGetADUserGroupMembershipResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADUserGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetADUserGroupMembership = new JObject();
                var activeDirectoryGetADUserGroupMembershippropCount = 0;
                activeDirectoryGetADUserGroupMembershippropCount++;
                activeDirectoryGetADUserGroupMembership["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserGroupMembershipuserIdentity);
                if (activeDirectoryGetADUserGroupMembershipaDServer != null)
                {
                    activeDirectoryGetADUserGroupMembership["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserGroupMembershipaDServer);
                    activeDirectoryGetADUserGroupMembershippropCount++;
                }

                activeDirectoryGetADUserGroupMembershippropCount++;
                activeDirectoryGetADUserGroupMembership["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserGroupMembershipworkflow);
                if (activeDirectoryGetADUserGroupMembershippropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetADUserGroupMembership;
                }

                return new ApiConnectionAction<ActiveDirectoryGetADUserGroupMembershipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryModifyADUserStringPropertyByIdentity))]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse> ActiveDirectoryModifyADUserStringPropertyByIdentity([WorkflowExpression] Func<string> activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryModifyADUserStringPropertyByIdentityworkflow, [WorkflowExpression] Func<activeDirectoryModifyADUserStringPropertyByIdentitypropertiesListInputItem[]> activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserStringPropertyByIdentityaDServer = null, [WorkflowExpression] Func<bool> activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse> __BuildActiveDirectoryModifyADUserStringPropertyByIdentity(WorkflowValue<string> activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity, WorkflowValue<string> activeDirectoryModifyADUserStringPropertyByIdentityworkflow, WorkflowValue<activeDirectoryModifyADUserStringPropertyByIdentitypropertiesListInputItem[]> activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList = null, WorkflowValue<string> activeDirectoryModifyADUserStringPropertyByIdentityaDServer = null, WorkflowValue<bool> activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue = null)
        {
            WorkflowValue.Validate(activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity, nameof(activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryModifyADUserStringPropertyByIdentityworkflow, nameof(activeDirectoryModifyADUserStringPropertyByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList, nameof(activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserStringPropertyByIdentityaDServer, nameof(activeDirectoryModifyADUserStringPropertyByIdentityaDServer), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue, nameof(activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue), required: false);
            return new DeferredBodyAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserStringPropertyByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryModifyADUserStringPropertyByIdentity = new JObject();
                var activeDirectoryModifyADUserStringPropertyByIdentitypropCount = 0;
                activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
                activeDirectoryModifyADUserStringPropertyByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity);
                if (activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList != null)
                {
                    activeDirectoryModifyADUserStringPropertyByIdentity["PropertiesList"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList);
                    activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
                }

                if (activeDirectoryModifyADUserStringPropertyByIdentityaDServer != null)
                {
                    activeDirectoryModifyADUserStringPropertyByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserStringPropertyByIdentityaDServer);
                    activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
                }

                if (activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue != null)
                {
                    if (activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue != null)
                    {
                        activeDirectoryModifyADUserStringPropertyByIdentity["ReplaceValue"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue);
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
                activeDirectoryModifyADUserStringPropertyByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserStringPropertyByIdentityworkflow);
                if (activeDirectoryModifyADUserStringPropertyByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryModifyADUserStringPropertyByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryModifyADUserBooleanPropertyByIdentity))]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse> ActiveDirectoryModifyADUserBooleanPropertyByIdentity([WorkflowExpression] Func<string> activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName, [WorkflowExpression] Func<string> activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow, [WorkflowExpression] Func<bool> activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse> __BuildActiveDirectoryModifyADUserBooleanPropertyByIdentity(WorkflowValue<string> activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity, WorkflowValue<string> activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName, WorkflowValue<string> activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow, WorkflowValue<bool> activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue = null, WorkflowValue<string> activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity, nameof(activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName, nameof(activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName), required: true);
            WorkflowValue.Validate(activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow, nameof(activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue, nameof(activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer, nameof(activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserBooleanPropertyByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryModifyADUserBooleanPropertyByIdentity = new JObject();
                var activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount = 0;
                activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                activeDirectoryModifyADUserBooleanPropertyByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity);
                activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                activeDirectoryModifyADUserBooleanPropertyByIdentity["PropertyName"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName);
                if (activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue != null)
                {
                    if (activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue != null)
                    {
                        activeDirectoryModifyADUserBooleanPropertyByIdentity["PropertyValue"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue);
                        activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                    }

                    activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryModifyADUserBooleanPropertyByIdentity["PropertyValue"] = false;
                    activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                }

                if (activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer != null)
                {
                    activeDirectoryModifyADUserBooleanPropertyByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer);
                    activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                }

                activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                activeDirectoryModifyADUserBooleanPropertyByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow);
                if (activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryModifyADUserBooleanPropertyByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryModifyADUserProperties))]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserPropertiesResponse> ActiveDirectoryModifyADUserProperties([WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesuserIdentity, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesworkflow, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescity = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescompany = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescountry = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescountryString = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescountryISO3166 = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesdepartment = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesdescription = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesdisplayName = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesemailAddress = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesgivenName = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertieshomePhone = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesinitials = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesiPPhone = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesmanager = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesmobilePhone = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesnotes = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesoffice = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesofficePhone = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiespostalCode = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesprofilePath = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesscriptPath = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesstate = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesstreetAddress = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiessurname = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiestitle = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserPropertiesResponse> __BuildActiveDirectoryModifyADUserProperties(WorkflowValue<string> activeDirectoryModifyADUserPropertiesuserIdentity, WorkflowValue<string> activeDirectoryModifyADUserPropertiesworkflow, WorkflowValue<string> activeDirectoryModifyADUserPropertiescity = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiescompany = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiescountry = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiescountryString = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiescountryISO3166 = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesdepartment = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesdescription = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesdisplayName = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesemailAddress = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesgivenName = null, WorkflowValue<string> activeDirectoryModifyADUserPropertieshomePhone = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesinitials = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesiPPhone = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesmanager = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesmobilePhone = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesnotes = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesoffice = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesofficePhone = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiespostalCode = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesprofilePath = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesscriptPath = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesstate = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesstreetAddress = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiessurname = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiestitle = null, WorkflowValue<string> activeDirectoryModifyADUserPropertiesaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesuserIdentity, nameof(activeDirectoryModifyADUserPropertiesuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesworkflow, nameof(activeDirectoryModifyADUserPropertiesworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiescity, nameof(activeDirectoryModifyADUserPropertiescity), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiescompany, nameof(activeDirectoryModifyADUserPropertiescompany), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiescountry, nameof(activeDirectoryModifyADUserPropertiescountry), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiescountryString, nameof(activeDirectoryModifyADUserPropertiescountryString), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiescountryISO3166, nameof(activeDirectoryModifyADUserPropertiescountryISO3166), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesdepartment, nameof(activeDirectoryModifyADUserPropertiesdepartment), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesdescription, nameof(activeDirectoryModifyADUserPropertiesdescription), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesdisplayName, nameof(activeDirectoryModifyADUserPropertiesdisplayName), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesemailAddress, nameof(activeDirectoryModifyADUserPropertiesemailAddress), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesgivenName, nameof(activeDirectoryModifyADUserPropertiesgivenName), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertieshomePhone, nameof(activeDirectoryModifyADUserPropertieshomePhone), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesinitials, nameof(activeDirectoryModifyADUserPropertiesinitials), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesiPPhone, nameof(activeDirectoryModifyADUserPropertiesiPPhone), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesmanager, nameof(activeDirectoryModifyADUserPropertiesmanager), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesmobilePhone, nameof(activeDirectoryModifyADUserPropertiesmobilePhone), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesnotes, nameof(activeDirectoryModifyADUserPropertiesnotes), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesoffice, nameof(activeDirectoryModifyADUserPropertiesoffice), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesofficePhone, nameof(activeDirectoryModifyADUserPropertiesofficePhone), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiespostalCode, nameof(activeDirectoryModifyADUserPropertiespostalCode), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesprofilePath, nameof(activeDirectoryModifyADUserPropertiesprofilePath), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesscriptPath, nameof(activeDirectoryModifyADUserPropertiesscriptPath), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesstate, nameof(activeDirectoryModifyADUserPropertiesstate), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesstreetAddress, nameof(activeDirectoryModifyADUserPropertiesstreetAddress), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiessurname, nameof(activeDirectoryModifyADUserPropertiessurname), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiestitle, nameof(activeDirectoryModifyADUserPropertiestitle), required: false);
            WorkflowValue.Validate(activeDirectoryModifyADUserPropertiesaDServer, nameof(activeDirectoryModifyADUserPropertiesaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryModifyADUserPropertiesResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryModifyADUserProperties = new JObject();
                var activeDirectoryModifyADUserPropertiespropCount = 0;
                activeDirectoryModifyADUserPropertiespropCount++;
                activeDirectoryModifyADUserProperties["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesuserIdentity);
                if (activeDirectoryModifyADUserPropertiescity != null)
                {
                    activeDirectoryModifyADUserProperties["City"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiescity);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiescompany != null)
                {
                    activeDirectoryModifyADUserProperties["Company"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiescompany);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiescountry != null)
                {
                    activeDirectoryModifyADUserProperties["Country"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiescountry);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiescountryString != null)
                {
                    activeDirectoryModifyADUserProperties["CountryString"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiescountryString);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiescountryISO3166 != null)
                {
                    activeDirectoryModifyADUserProperties["CountryISO3166"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiescountryISO3166);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesdepartment != null)
                {
                    activeDirectoryModifyADUserProperties["Department"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesdepartment);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesdescription != null)
                {
                    activeDirectoryModifyADUserProperties["Description"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesdescription);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesdisplayName != null)
                {
                    activeDirectoryModifyADUserProperties["DisplayName"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesdisplayName);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesemailAddress != null)
                {
                    activeDirectoryModifyADUserProperties["EmailAddress"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesemailAddress);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesgivenName != null)
                {
                    activeDirectoryModifyADUserProperties["GivenName"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesgivenName);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertieshomePhone != null)
                {
                    activeDirectoryModifyADUserProperties["HomePhone"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertieshomePhone);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesinitials != null)
                {
                    activeDirectoryModifyADUserProperties["Initials"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesinitials);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesiPPhone != null)
                {
                    activeDirectoryModifyADUserProperties["IPPhone"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesiPPhone);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesmanager != null)
                {
                    activeDirectoryModifyADUserProperties["Manager"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesmanager);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesmobilePhone != null)
                {
                    activeDirectoryModifyADUserProperties["MobilePhone"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesmobilePhone);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesnotes != null)
                {
                    activeDirectoryModifyADUserProperties["Notes"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesnotes);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesoffice != null)
                {
                    activeDirectoryModifyADUserProperties["Office"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesoffice);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesofficePhone != null)
                {
                    activeDirectoryModifyADUserProperties["OfficePhone"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesofficePhone);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiespostalCode != null)
                {
                    activeDirectoryModifyADUserProperties["PostalCode"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiespostalCode);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesprofilePath != null)
                {
                    activeDirectoryModifyADUserProperties["ProfilePath"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesprofilePath);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesscriptPath != null)
                {
                    activeDirectoryModifyADUserProperties["ScriptPath"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesscriptPath);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesstate != null)
                {
                    activeDirectoryModifyADUserProperties["State"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesstate);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesstreetAddress != null)
                {
                    activeDirectoryModifyADUserProperties["StreetAddress"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesstreetAddress);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiessurname != null)
                {
                    activeDirectoryModifyADUserProperties["Surname"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiessurname);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiestitle != null)
                {
                    activeDirectoryModifyADUserProperties["Title"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiestitle);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesaDServer != null)
                {
                    activeDirectoryModifyADUserProperties["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesaDServer);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                activeDirectoryModifyADUserPropertiespropCount++;
                activeDirectoryModifyADUserProperties["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesworkflow);
                if (activeDirectoryModifyADUserPropertiespropCount > 0)
                {
                    callPayload.Body = activeDirectoryModifyADUserProperties;
                }

                return new ApiConnectionAction<ActiveDirectoryModifyADUserPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryMoveADUserToOUByIdentity))]
        public IBodyWorkflowAction<ActiveDirectoryMoveADUserToOUByIdentityResponse> ActiveDirectoryMoveADUserToOUByIdentity([WorkflowExpression] Func<string> activeDirectoryMoveADUserToOUByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryMoveADUserToOUByIdentitytargetPath, [WorkflowExpression] Func<string> activeDirectoryMoveADUserToOUByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryMoveADUserToOUByIdentityaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryMoveADUserToOUByIdentityResponse> __BuildActiveDirectoryMoveADUserToOUByIdentity(WorkflowValue<string> activeDirectoryMoveADUserToOUByIdentityuserIdentity, WorkflowValue<string> activeDirectoryMoveADUserToOUByIdentitytargetPath, WorkflowValue<string> activeDirectoryMoveADUserToOUByIdentityworkflow, WorkflowValue<string> activeDirectoryMoveADUserToOUByIdentityaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryMoveADUserToOUByIdentityuserIdentity, nameof(activeDirectoryMoveADUserToOUByIdentityuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryMoveADUserToOUByIdentitytargetPath, nameof(activeDirectoryMoveADUserToOUByIdentitytargetPath), required: true);
            WorkflowValue.Validate(activeDirectoryMoveADUserToOUByIdentityworkflow, nameof(activeDirectoryMoveADUserToOUByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryMoveADUserToOUByIdentityaDServer, nameof(activeDirectoryMoveADUserToOUByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryMoveADUserToOUByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryMoveADUserToOUByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryMoveADUserToOUByIdentity = new JObject();
                var activeDirectoryMoveADUserToOUByIdentitypropCount = 0;
                activeDirectoryMoveADUserToOUByIdentitypropCount++;
                activeDirectoryMoveADUserToOUByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryMoveADUserToOUByIdentityuserIdentity);
                activeDirectoryMoveADUserToOUByIdentitypropCount++;
                activeDirectoryMoveADUserToOUByIdentity["TargetPath"] = ExpressionConverter.ConvertO(activeDirectoryMoveADUserToOUByIdentitytargetPath);
                if (activeDirectoryMoveADUserToOUByIdentityaDServer != null)
                {
                    activeDirectoryMoveADUserToOUByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryMoveADUserToOUByIdentityaDServer);
                    activeDirectoryMoveADUserToOUByIdentitypropCount++;
                }

                activeDirectoryMoveADUserToOUByIdentitypropCount++;
                activeDirectoryMoveADUserToOUByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryMoveADUserToOUByIdentityworkflow);
                if (activeDirectoryMoveADUserToOUByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryMoveADUserToOUByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryMoveADUserToOUByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryClearADUserAccountExpiration))]
        public IBodyWorkflowAction<ActiveDirectoryClearADUserAccountExpirationResponse> ActiveDirectoryClearADUserAccountExpiration([WorkflowExpression] Func<string> activeDirectoryClearADUserAccountExpirationuserIdentity, [WorkflowExpression] Func<string> activeDirectoryClearADUserAccountExpirationworkflow, [WorkflowExpression] Func<string> activeDirectoryClearADUserAccountExpirationaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryClearADUserAccountExpirationResponse> __BuildActiveDirectoryClearADUserAccountExpiration(WorkflowValue<string> activeDirectoryClearADUserAccountExpirationuserIdentity, WorkflowValue<string> activeDirectoryClearADUserAccountExpirationworkflow, WorkflowValue<string> activeDirectoryClearADUserAccountExpirationaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryClearADUserAccountExpirationuserIdentity, nameof(activeDirectoryClearADUserAccountExpirationuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryClearADUserAccountExpirationworkflow, nameof(activeDirectoryClearADUserAccountExpirationworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryClearADUserAccountExpirationaDServer, nameof(activeDirectoryClearADUserAccountExpirationaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryClearADUserAccountExpirationResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryClearADUserAccountExpiration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryClearADUserAccountExpiration = new JObject();
                var activeDirectoryClearADUserAccountExpirationpropCount = 0;
                activeDirectoryClearADUserAccountExpirationpropCount++;
                activeDirectoryClearADUserAccountExpiration["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryClearADUserAccountExpirationuserIdentity);
                if (activeDirectoryClearADUserAccountExpirationaDServer != null)
                {
                    activeDirectoryClearADUserAccountExpiration["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryClearADUserAccountExpirationaDServer);
                    activeDirectoryClearADUserAccountExpirationpropCount++;
                }

                activeDirectoryClearADUserAccountExpirationpropCount++;
                activeDirectoryClearADUserAccountExpiration["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryClearADUserAccountExpirationworkflow);
                if (activeDirectoryClearADUserAccountExpirationpropCount > 0)
                {
                    callPayload.Body = activeDirectoryClearADUserAccountExpiration;
                }

                return new ApiConnectionAction<ActiveDirectoryClearADUserAccountExpirationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryDirSync))]
        public IBodyWorkflowAction<ActiveDirectoryDirSyncResponse> ActiveDirectoryDirSync([WorkflowExpression] Func<string> activeDirectoryDirSyncworkflow, [WorkflowExpression] Func<activeDirectoryDirSyncpolicyTypeInput> activeDirectoryDirSyncpolicyType = null, [WorkflowExpression] Func<string> activeDirectoryDirSynccomputerName = null, [WorkflowExpression] Func<int> activeDirectoryDirSyncmaxRetryAttempts = null, [WorkflowExpression] Func<int> activeDirectoryDirSyncsecondsBetweenRetries = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryDirSyncResponse> __BuildActiveDirectoryDirSync(WorkflowValue<string> activeDirectoryDirSyncworkflow, WorkflowValue<activeDirectoryDirSyncpolicyTypeInput> activeDirectoryDirSyncpolicyType = null, WorkflowValue<string> activeDirectoryDirSynccomputerName = null, WorkflowValue<int> activeDirectoryDirSyncmaxRetryAttempts = null, WorkflowValue<int> activeDirectoryDirSyncsecondsBetweenRetries = null)
        {
            WorkflowValue.Validate(activeDirectoryDirSyncworkflow, nameof(activeDirectoryDirSyncworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryDirSyncpolicyType, nameof(activeDirectoryDirSyncpolicyType), required: false);
            WorkflowValue.Validate(activeDirectoryDirSynccomputerName, nameof(activeDirectoryDirSynccomputerName), required: false);
            WorkflowValue.Validate(activeDirectoryDirSyncmaxRetryAttempts, nameof(activeDirectoryDirSyncmaxRetryAttempts), required: false);
            WorkflowValue.Validate(activeDirectoryDirSyncsecondsBetweenRetries, nameof(activeDirectoryDirSyncsecondsBetweenRetries), required: false);
            return new DeferredBodyAction<ActiveDirectoryDirSyncResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDirSync";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryDirSync = new JObject();
                var activeDirectoryDirSyncpropCount = 0;
                if (activeDirectoryDirSyncpolicyType != null)
                {
                    activeDirectoryDirSync["PolicyType"] = ExpressionConverter.ConvertO(activeDirectoryDirSyncpolicyType);
                    activeDirectoryDirSyncpropCount++;
                }

                if (activeDirectoryDirSynccomputerName != null)
                {
                    activeDirectoryDirSync["ComputerName"] = ExpressionConverter.ConvertO(activeDirectoryDirSynccomputerName);
                    activeDirectoryDirSyncpropCount++;
                }

                if (activeDirectoryDirSyncmaxRetryAttempts != null)
                {
                    if (activeDirectoryDirSyncmaxRetryAttempts != null)
                    {
                        activeDirectoryDirSync["MaxRetryAttempts"] = ExpressionConverter.ConvertO(activeDirectoryDirSyncmaxRetryAttempts);
                        activeDirectoryDirSyncpropCount++;
                    }

                    activeDirectoryDirSyncpropCount++;
                }
                else
                {
                    activeDirectoryDirSync["MaxRetryAttempts"] = 3;
                    activeDirectoryDirSyncpropCount++;
                }

                if (activeDirectoryDirSyncsecondsBetweenRetries != null)
                {
                    if (activeDirectoryDirSyncsecondsBetweenRetries != null)
                    {
                        activeDirectoryDirSync["SecondsBetweenRetries"] = ExpressionConverter.ConvertO(activeDirectoryDirSyncsecondsBetweenRetries);
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
                activeDirectoryDirSync["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryDirSyncworkflow);
                if (activeDirectoryDirSyncpropCount > 0)
                {
                    callPayload.Body = activeDirectoryDirSync;
                }

                return new ApiConnectionAction<ActiveDirectoryDirSyncResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryRemoveADUserByIdentity))]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserByIdentityResponse> ActiveDirectoryRemoveADUserByIdentity([WorkflowExpression] Func<string> activeDirectoryRemoveADUserByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserByIdentityworkflow, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserByIdentityforceDeleteRecursive = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserByIdentityaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserByIdentityResponse> __BuildActiveDirectoryRemoveADUserByIdentity(WorkflowValue<string> activeDirectoryRemoveADUserByIdentityuserIdentity, WorkflowValue<string> activeDirectoryRemoveADUserByIdentityworkflow, WorkflowValue<bool> activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion = null, WorkflowValue<bool> activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects = null, WorkflowValue<bool> activeDirectoryRemoveADUserByIdentityforceDeleteRecursive = null, WorkflowValue<string> activeDirectoryRemoveADUserByIdentityaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryRemoveADUserByIdentityuserIdentity, nameof(activeDirectoryRemoveADUserByIdentityuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryRemoveADUserByIdentityworkflow, nameof(activeDirectoryRemoveADUserByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion, nameof(activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects, nameof(activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADUserByIdentityforceDeleteRecursive, nameof(activeDirectoryRemoveADUserByIdentityforceDeleteRecursive), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADUserByIdentityaDServer, nameof(activeDirectoryRemoveADUserByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryRemoveADUserByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADUserByIdentity = new JObject();
                var activeDirectoryRemoveADUserByIdentitypropCount = 0;
                activeDirectoryRemoveADUserByIdentitypropCount++;
                activeDirectoryRemoveADUserByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserByIdentityuserIdentity);
                if (activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion != null)
                {
                    if (activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion != null)
                    {
                        activeDirectoryRemoveADUserByIdentity["RemoveProtectionFromAccidentalDeletion"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion);
                        activeDirectoryRemoveADUserByIdentitypropCount++;
                    }

                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserByIdentity["RemoveProtectionFromAccidentalDeletion"] = false;
                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }

                if (activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects != null)
                {
                    if (activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects != null)
                    {
                        activeDirectoryRemoveADUserByIdentity["DeleteEvenIfUserHasSubObjects"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects);
                        activeDirectoryRemoveADUserByIdentitypropCount++;
                    }

                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserByIdentity["DeleteEvenIfUserHasSubObjects"] = false;
                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }

                if (activeDirectoryRemoveADUserByIdentityforceDeleteRecursive != null)
                {
                    if (activeDirectoryRemoveADUserByIdentityforceDeleteRecursive != null)
                    {
                        activeDirectoryRemoveADUserByIdentity["ForceDeleteRecursive"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserByIdentityforceDeleteRecursive);
                        activeDirectoryRemoveADUserByIdentitypropCount++;
                    }

                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserByIdentity["ForceDeleteRecursive"] = false;
                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }

                if (activeDirectoryRemoveADUserByIdentityaDServer != null)
                {
                    activeDirectoryRemoveADUserByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserByIdentityaDServer);
                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }

                activeDirectoryRemoveADUserByIdentitypropCount++;
                activeDirectoryRemoveADUserByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserByIdentityworkflow);
                if (activeDirectoryRemoveADUserByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADUserByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryRemoveADUserByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryResetADUserPasswordByIdentity))]
        public IBodyWorkflowAction<ActiveDirectoryResetADUserPasswordByIdentityResponse> ActiveDirectoryResetADUserPasswordByIdentity([WorkflowExpression] Func<string> activeDirectoryResetADUserPasswordByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryResetADUserPasswordByIdentitynewPassword, [WorkflowExpression] Func<string> activeDirectoryResetADUserPasswordByIdentityworkflow, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentitycannotChangePassword = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice = null, [WorkflowExpression] Func<string> activeDirectoryResetADUserPasswordByIdentityaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryResetADUserPasswordByIdentityResponse> __BuildActiveDirectoryResetADUserPasswordByIdentity(WorkflowValue<string> activeDirectoryResetADUserPasswordByIdentityuserIdentity, WorkflowValue<string> activeDirectoryResetADUserPasswordByIdentitynewPassword, WorkflowValue<string> activeDirectoryResetADUserPasswordByIdentityworkflow, WorkflowValue<bool> activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword = null, WorkflowValue<bool> activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties = null, WorkflowValue<bool> activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon = null, WorkflowValue<bool> activeDirectoryResetADUserPasswordByIdentitycannotChangePassword = null, WorkflowValue<bool> activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires = null, WorkflowValue<bool> activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice = null, WorkflowValue<string> activeDirectoryResetADUserPasswordByIdentityaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryResetADUserPasswordByIdentityuserIdentity, nameof(activeDirectoryResetADUserPasswordByIdentityuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryResetADUserPasswordByIdentitynewPassword, nameof(activeDirectoryResetADUserPasswordByIdentitynewPassword), required: true);
            WorkflowValue.Validate(activeDirectoryResetADUserPasswordByIdentityworkflow, nameof(activeDirectoryResetADUserPasswordByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword, nameof(activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword), required: false);
            WorkflowValue.Validate(activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties, nameof(activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties), required: false);
            WorkflowValue.Validate(activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon, nameof(activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon), required: false);
            WorkflowValue.Validate(activeDirectoryResetADUserPasswordByIdentitycannotChangePassword, nameof(activeDirectoryResetADUserPasswordByIdentitycannotChangePassword), required: false);
            WorkflowValue.Validate(activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires, nameof(activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires), required: false);
            WorkflowValue.Validate(activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice, nameof(activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice), required: false);
            WorkflowValue.Validate(activeDirectoryResetADUserPasswordByIdentityaDServer, nameof(activeDirectoryResetADUserPasswordByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryResetADUserPasswordByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryResetADUserPasswordByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryResetADUserPasswordByIdentity = new JObject();
                var activeDirectoryResetADUserPasswordByIdentitypropCount = 0;
                activeDirectoryResetADUserPasswordByIdentitypropCount++;
                activeDirectoryResetADUserPasswordByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentityuserIdentity);
                activeDirectoryResetADUserPasswordByIdentitypropCount++;
                activeDirectoryResetADUserPasswordByIdentity["NewPassword"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentitynewPassword);
                if (activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword != null)
                {
                    if (activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword != null)
                    {
                        activeDirectoryResetADUserPasswordByIdentity["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword);
                        activeDirectoryResetADUserPasswordByIdentitypropCount++;
                    }

                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryResetADUserPasswordByIdentity["AccountPasswordIsStoredPassword"] = false;
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                if (activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties != null)
                {
                    if (activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties != null)
                    {
                        activeDirectoryResetADUserPasswordByIdentity["SetUserPasswordProperties"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties);
                        activeDirectoryResetADUserPasswordByIdentitypropCount++;
                    }

                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryResetADUserPasswordByIdentity["SetUserPasswordProperties"] = true;
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                if (activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon != null)
                {
                    if (activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon != null)
                    {
                        activeDirectoryResetADUserPasswordByIdentity["ChangePasswordAtLogon"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon);
                        activeDirectoryResetADUserPasswordByIdentitypropCount++;
                    }

                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryResetADUserPasswordByIdentity["ChangePasswordAtLogon"] = true;
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                if (activeDirectoryResetADUserPasswordByIdentitycannotChangePassword != null)
                {
                    if (activeDirectoryResetADUserPasswordByIdentitycannotChangePassword != null)
                    {
                        activeDirectoryResetADUserPasswordByIdentity["CannotChangePassword"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentitycannotChangePassword);
                        activeDirectoryResetADUserPasswordByIdentitypropCount++;
                    }

                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryResetADUserPasswordByIdentity["CannotChangePassword"] = false;
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                if (activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires != null)
                {
                    if (activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires != null)
                    {
                        activeDirectoryResetADUserPasswordByIdentity["PasswordNeverExpires"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires);
                        activeDirectoryResetADUserPasswordByIdentitypropCount++;
                    }

                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryResetADUserPasswordByIdentity["PasswordNeverExpires"] = false;
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                if (activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice != null)
                {
                    if (activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice != null)
                    {
                        activeDirectoryResetADUserPasswordByIdentity["ResetPasswordTwice"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice);
                        activeDirectoryResetADUserPasswordByIdentitypropCount++;
                    }

                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryResetADUserPasswordByIdentity["ResetPasswordTwice"] = false;
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                if (activeDirectoryResetADUserPasswordByIdentityaDServer != null)
                {
                    activeDirectoryResetADUserPasswordByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentityaDServer);
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                activeDirectoryResetADUserPasswordByIdentitypropCount++;
                activeDirectoryResetADUserPasswordByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentityworkflow);
                if (activeDirectoryResetADUserPasswordByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryResetADUserPasswordByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryResetADUserPasswordByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity))]
        public IBodyWorkflowAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse> ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity([WorkflowExpression] Func<string> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity, [WorkflowExpression] Func<bool> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion, [WorkflowExpression] Func<string> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse> __BuildActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity(WorkflowValue<string> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity, WorkflowValue<bool> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion, WorkflowValue<string> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow, WorkflowValue<string> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer = null)
        {
            WorkflowValue.Validate(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity, nameof(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion, nameof(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion), required: true);
            WorkflowValue.Validate(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow, nameof(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer, nameof(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity = new JObject();
                var activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount = 0;
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity);
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["ProtectedFromAccidentalDeletion"] = ExpressionConverter.ConvertO(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion);
                if (activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer != null)
                {
                    activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer);
                    activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
                }

                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow);
                if (activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryDisableADUserByIdentity))]
        public IBodyWorkflowAction<ActiveDirectoryDisableADUserByIdentityResponse> ActiveDirectoryDisableADUserByIdentity([WorkflowExpression] Func<string> activeDirectoryDisableADUserByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryDisableADUserByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryDisableADUserByIdentityaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryDisableADUserByIdentityResponse> __BuildActiveDirectoryDisableADUserByIdentity(WorkflowValue<string> activeDirectoryDisableADUserByIdentityuserIdentity, WorkflowValue<string> activeDirectoryDisableADUserByIdentityworkflow, WorkflowValue<string> activeDirectoryDisableADUserByIdentityaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryDisableADUserByIdentityuserIdentity, nameof(activeDirectoryDisableADUserByIdentityuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryDisableADUserByIdentityworkflow, nameof(activeDirectoryDisableADUserByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryDisableADUserByIdentityaDServer, nameof(activeDirectoryDisableADUserByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryDisableADUserByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDisableADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryDisableADUserByIdentity = new JObject();
                var activeDirectoryDisableADUserByIdentitypropCount = 0;
                activeDirectoryDisableADUserByIdentitypropCount++;
                activeDirectoryDisableADUserByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryDisableADUserByIdentityuserIdentity);
                if (activeDirectoryDisableADUserByIdentityaDServer != null)
                {
                    activeDirectoryDisableADUserByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryDisableADUserByIdentityaDServer);
                    activeDirectoryDisableADUserByIdentitypropCount++;
                }

                activeDirectoryDisableADUserByIdentitypropCount++;
                activeDirectoryDisableADUserByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryDisableADUserByIdentityworkflow);
                if (activeDirectoryDisableADUserByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryDisableADUserByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryDisableADUserByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryEnableADUserByIdentity))]
        public IBodyWorkflowAction<ActiveDirectoryEnableADUserByIdentityResponse> ActiveDirectoryEnableADUserByIdentity([WorkflowExpression] Func<string> activeDirectoryEnableADUserByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryEnableADUserByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryEnableADUserByIdentityaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryEnableADUserByIdentityResponse> __BuildActiveDirectoryEnableADUserByIdentity(WorkflowValue<string> activeDirectoryEnableADUserByIdentityuserIdentity, WorkflowValue<string> activeDirectoryEnableADUserByIdentityworkflow, WorkflowValue<string> activeDirectoryEnableADUserByIdentityaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryEnableADUserByIdentityuserIdentity, nameof(activeDirectoryEnableADUserByIdentityuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryEnableADUserByIdentityworkflow, nameof(activeDirectoryEnableADUserByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryEnableADUserByIdentityaDServer, nameof(activeDirectoryEnableADUserByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryEnableADUserByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryEnableADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryEnableADUserByIdentity = new JObject();
                var activeDirectoryEnableADUserByIdentitypropCount = 0;
                activeDirectoryEnableADUserByIdentitypropCount++;
                activeDirectoryEnableADUserByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryEnableADUserByIdentityuserIdentity);
                if (activeDirectoryEnableADUserByIdentityaDServer != null)
                {
                    activeDirectoryEnableADUserByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryEnableADUserByIdentityaDServer);
                    activeDirectoryEnableADUserByIdentitypropCount++;
                }

                activeDirectoryEnableADUserByIdentitypropCount++;
                activeDirectoryEnableADUserByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryEnableADUserByIdentityworkflow);
                if (activeDirectoryEnableADUserByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryEnableADUserByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryEnableADUserByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectorySetADUserHomeFolderByIdentity))]
        public IBodyWorkflowAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse> ActiveDirectorySetADUserHomeFolderByIdentity([WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityhomeDrive = null, [WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityhomeDirectory = null, [WorkflowExpression] Func<bool> activeDirectorySetADUserHomeFolderByIdentitycreateFolder = null, [WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse> __BuildActiveDirectorySetADUserHomeFolderByIdentity(WorkflowValue<string> activeDirectorySetADUserHomeFolderByIdentityuserIdentity, WorkflowValue<string> activeDirectorySetADUserHomeFolderByIdentityworkflow, WorkflowValue<string> activeDirectorySetADUserHomeFolderByIdentityhomeDrive = null, WorkflowValue<string> activeDirectorySetADUserHomeFolderByIdentityhomeDirectory = null, WorkflowValue<bool> activeDirectorySetADUserHomeFolderByIdentitycreateFolder = null, WorkflowValue<string> activeDirectorySetADUserHomeFolderByIdentityaDServer = null)
        {
            WorkflowValue.Validate(activeDirectorySetADUserHomeFolderByIdentityuserIdentity, nameof(activeDirectorySetADUserHomeFolderByIdentityuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectorySetADUserHomeFolderByIdentityworkflow, nameof(activeDirectorySetADUserHomeFolderByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectorySetADUserHomeFolderByIdentityhomeDrive, nameof(activeDirectorySetADUserHomeFolderByIdentityhomeDrive), required: false);
            WorkflowValue.Validate(activeDirectorySetADUserHomeFolderByIdentityhomeDirectory, nameof(activeDirectorySetADUserHomeFolderByIdentityhomeDirectory), required: false);
            WorkflowValue.Validate(activeDirectorySetADUserHomeFolderByIdentitycreateFolder, nameof(activeDirectorySetADUserHomeFolderByIdentitycreateFolder), required: false);
            WorkflowValue.Validate(activeDirectorySetADUserHomeFolderByIdentityaDServer, nameof(activeDirectorySetADUserHomeFolderByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserHomeFolderByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectorySetADUserHomeFolderByIdentity = new JObject();
                var activeDirectorySetADUserHomeFolderByIdentitypropCount = 0;
                activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                activeDirectorySetADUserHomeFolderByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectorySetADUserHomeFolderByIdentityuserIdentity);
                if (activeDirectorySetADUserHomeFolderByIdentityhomeDrive != null)
                {
                    activeDirectorySetADUserHomeFolderByIdentity["HomeDrive"] = ExpressionConverter.ConvertO(activeDirectorySetADUserHomeFolderByIdentityhomeDrive);
                    activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                }

                if (activeDirectorySetADUserHomeFolderByIdentityhomeDirectory != null)
                {
                    activeDirectorySetADUserHomeFolderByIdentity["HomeDirectory"] = ExpressionConverter.ConvertO(activeDirectorySetADUserHomeFolderByIdentityhomeDirectory);
                    activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                }

                if (activeDirectorySetADUserHomeFolderByIdentitycreateFolder != null)
                {
                    if (activeDirectorySetADUserHomeFolderByIdentitycreateFolder != null)
                    {
                        activeDirectorySetADUserHomeFolderByIdentity["CreateFolder"] = ExpressionConverter.ConvertO(activeDirectorySetADUserHomeFolderByIdentitycreateFolder);
                        activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                    }

                    activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                }
                else
                {
                    activeDirectorySetADUserHomeFolderByIdentity["CreateFolder"] = false;
                    activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                }

                if (activeDirectorySetADUserHomeFolderByIdentityaDServer != null)
                {
                    activeDirectorySetADUserHomeFolderByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectorySetADUserHomeFolderByIdentityaDServer);
                    activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                }

                activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                activeDirectorySetADUserHomeFolderByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectorySetADUserHomeFolderByIdentityworkflow);
                if (activeDirectorySetADUserHomeFolderByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectorySetADUserHomeFolderByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryCloneADUserGroups))]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserGroupsResponse> ActiveDirectoryCloneADUserGroups([WorkflowExpression] Func<string> activeDirectoryCloneADUserGroupssourceUserIdentity, [WorkflowExpression] Func<string> activeDirectoryCloneADUserGroupsdestinationUserIdentity, [WorkflowExpression] Func<string> activeDirectoryCloneADUserGroupsworkflow, [WorkflowExpression] Func<string> activeDirectoryCloneADUserGroupsaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserGroupsResponse> __BuildActiveDirectoryCloneADUserGroups(WorkflowValue<string> activeDirectoryCloneADUserGroupssourceUserIdentity, WorkflowValue<string> activeDirectoryCloneADUserGroupsdestinationUserIdentity, WorkflowValue<string> activeDirectoryCloneADUserGroupsworkflow, WorkflowValue<string> activeDirectoryCloneADUserGroupsaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryCloneADUserGroupssourceUserIdentity, nameof(activeDirectoryCloneADUserGroupssourceUserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryCloneADUserGroupsdestinationUserIdentity, nameof(activeDirectoryCloneADUserGroupsdestinationUserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryCloneADUserGroupsworkflow, nameof(activeDirectoryCloneADUserGroupsworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryCloneADUserGroupsaDServer, nameof(activeDirectoryCloneADUserGroupsaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryCloneADUserGroupsResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCloneADUserGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryCloneADUserGroups = new JObject();
                var activeDirectoryCloneADUserGroupspropCount = 0;
                activeDirectoryCloneADUserGroupspropCount++;
                activeDirectoryCloneADUserGroups["SourceUserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserGroupssourceUserIdentity);
                activeDirectoryCloneADUserGroupspropCount++;
                activeDirectoryCloneADUserGroups["DestinationUserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserGroupsdestinationUserIdentity);
                if (activeDirectoryCloneADUserGroupsaDServer != null)
                {
                    activeDirectoryCloneADUserGroups["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserGroupsaDServer);
                    activeDirectoryCloneADUserGroupspropCount++;
                }

                activeDirectoryCloneADUserGroupspropCount++;
                activeDirectoryCloneADUserGroups["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserGroupsworkflow);
                if (activeDirectoryCloneADUserGroupspropCount > 0)
                {
                    callPayload.Body = activeDirectoryCloneADUserGroups;
                }

                return new ApiConnectionAction<ActiveDirectoryCloneADUserGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryCloneADUserProperties))]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserPropertiesResponse> ActiveDirectoryCloneADUserProperties([WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiessourceUserIdentity, [WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiesdestinationUserIdentity, [WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiespropertiesToClone, [WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiesworkflow, [WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiesaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserPropertiesResponse> __BuildActiveDirectoryCloneADUserProperties(WorkflowValue<string> activeDirectoryCloneADUserPropertiessourceUserIdentity, WorkflowValue<string> activeDirectoryCloneADUserPropertiesdestinationUserIdentity, WorkflowValue<string> activeDirectoryCloneADUserPropertiespropertiesToClone, WorkflowValue<string> activeDirectoryCloneADUserPropertiesworkflow, WorkflowValue<string> activeDirectoryCloneADUserPropertiesaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryCloneADUserPropertiessourceUserIdentity, nameof(activeDirectoryCloneADUserPropertiessourceUserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryCloneADUserPropertiesdestinationUserIdentity, nameof(activeDirectoryCloneADUserPropertiesdestinationUserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryCloneADUserPropertiespropertiesToClone, nameof(activeDirectoryCloneADUserPropertiespropertiesToClone), required: true);
            WorkflowValue.Validate(activeDirectoryCloneADUserPropertiesworkflow, nameof(activeDirectoryCloneADUserPropertiesworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryCloneADUserPropertiesaDServer, nameof(activeDirectoryCloneADUserPropertiesaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryCloneADUserPropertiesResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCloneADUserProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryCloneADUserProperties = new JObject();
                var activeDirectoryCloneADUserPropertiespropCount = 0;
                activeDirectoryCloneADUserPropertiespropCount++;
                activeDirectoryCloneADUserProperties["SourceUserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserPropertiessourceUserIdentity);
                activeDirectoryCloneADUserPropertiespropCount++;
                activeDirectoryCloneADUserProperties["DestinationUserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserPropertiesdestinationUserIdentity);
                activeDirectoryCloneADUserPropertiespropCount++;
                activeDirectoryCloneADUserProperties["PropertiesToClone"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserPropertiespropertiesToClone);
                if (activeDirectoryCloneADUserPropertiesaDServer != null)
                {
                    activeDirectoryCloneADUserProperties["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserPropertiesaDServer);
                    activeDirectoryCloneADUserPropertiespropCount++;
                }

                activeDirectoryCloneADUserPropertiespropCount++;
                activeDirectoryCloneADUserProperties["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserPropertiesworkflow);
                if (activeDirectoryCloneADUserPropertiespropCount > 0)
                {
                    callPayload.Body = activeDirectoryCloneADUserProperties;
                }

                return new ApiConnectionAction<ActiveDirectoryCloneADUserPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryRemoveADUserFromMultipleADGroupsByName))]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse> ActiveDirectoryRemoveADUserFromMultipleADGroupsByName([WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer = null, [WorkflowExpression] Func<int> activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse> __BuildActiveDirectoryRemoveADUserFromMultipleADGroupsByName(WorkflowValue<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity, WorkflowValue<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow, WorkflowValue<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON = null, WorkflowValue<bool> activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove = null, WorkflowValue<bool> activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove = null, WorkflowValue<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer = null, WorkflowValue<int> activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall = null)
        {
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall), required: false);
            return new DeferredBodyAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserFromMultipleADGroupsByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADUserFromMultipleADGroupsByName = new JObject();
                var activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount = 0;
                activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                activeDirectoryRemoveADUserFromMultipleADGroupsByName["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity);
                if (activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON != null)
                {
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["GroupNamesJSON"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON);
                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }

                if (activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove != null)
                {
                    if (activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove != null)
                    {
                        activeDirectoryRemoveADUserFromMultipleADGroupsByName["ExceptionIfAnyGroupsFailToRemove"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove);
                        activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                    }

                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["ExceptionIfAnyGroupsFailToRemove"] = false;
                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }

                if (activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove != null)
                {
                    if (activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove != null)
                    {
                        activeDirectoryRemoveADUserFromMultipleADGroupsByName["ExceptionIfAllGroupsFailToRemove"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove);
                        activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                    }

                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["ExceptionIfAllGroupsFailToRemove"] = false;
                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }

                if (activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer != null)
                {
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer);
                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }

                if (activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall != null)
                {
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["MaxGroupsPerCall"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall);
                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }

                activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                activeDirectoryRemoveADUserFromMultipleADGroupsByName["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow);
                if (activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADUserFromMultipleADGroupsByName;
                }

                return new ApiConnectionAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryRemoveADUserFromAllGroups))]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse> ActiveDirectoryRemoveADUserFromAllGroups([WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromAllGroupsworkflow, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromAllGroupsuserIdentity = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromAllGroupsaDServer = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserFromAllGroupsrunAsThread = null, [WorkflowExpression] Func<int> activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse> __BuildActiveDirectoryRemoveADUserFromAllGroups(WorkflowValue<string> activeDirectoryRemoveADUserFromAllGroupsworkflow, WorkflowValue<string> activeDirectoryRemoveADUserFromAllGroupsuserIdentity = null, WorkflowValue<string> activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON = null, WorkflowValue<bool> activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist = null, WorkflowValue<string> activeDirectoryRemoveADUserFromAllGroupsaDServer = null, WorkflowValue<bool> activeDirectoryRemoveADUserFromAllGroupsrunAsThread = null, WorkflowValue<int> activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId = null, WorkflowValue<int> activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread = null)
        {
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromAllGroupsworkflow, nameof(activeDirectoryRemoveADUserFromAllGroupsworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromAllGroupsuserIdentity, nameof(activeDirectoryRemoveADUserFromAllGroupsuserIdentity), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON, nameof(activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist, nameof(activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromAllGroupsaDServer, nameof(activeDirectoryRemoveADUserFromAllGroupsaDServer), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromAllGroupsrunAsThread, nameof(activeDirectoryRemoveADUserFromAllGroupsrunAsThread), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId, nameof(activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread, nameof(activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread), required: false);
            return new DeferredBodyAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserFromAllGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADUserFromAllGroups = new JObject();
                var activeDirectoryRemoveADUserFromAllGroupspropCount = 0;
                if (activeDirectoryRemoveADUserFromAllGroupsuserIdentity != null)
                {
                    activeDirectoryRemoveADUserFromAllGroups["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsuserIdentity);
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON != null)
                {
                    activeDirectoryRemoveADUserFromAllGroups["GroupsToExcludeJSON"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON);
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist != null)
                {
                    if (activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist != null)
                    {
                        activeDirectoryRemoveADUserFromAllGroups["ExceptionIfExcludedGroupDoesNotExist"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist);
                        activeDirectoryRemoveADUserFromAllGroupspropCount++;
                    }

                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserFromAllGroups["ExceptionIfExcludedGroupDoesNotExist"] = false;
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (activeDirectoryRemoveADUserFromAllGroupsaDServer != null)
                {
                    activeDirectoryRemoveADUserFromAllGroups["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsaDServer);
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (activeDirectoryRemoveADUserFromAllGroupsrunAsThread != null)
                {
                    if (activeDirectoryRemoveADUserFromAllGroupsrunAsThread != null)
                    {
                        activeDirectoryRemoveADUserFromAllGroups["RunAsThread"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsrunAsThread);
                        activeDirectoryRemoveADUserFromAllGroupspropCount++;
                    }

                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }
                else
                {
                    activeDirectoryRemoveADUserFromAllGroups["RunAsThread"] = false;
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId != null)
                {
                    activeDirectoryRemoveADUserFromAllGroups["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId);
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread != null)
                {
                    if (activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread != null)
                    {
                        activeDirectoryRemoveADUserFromAllGroups["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread);
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
                activeDirectoryRemoveADUserFromAllGroups["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsworkflow);
                if (activeDirectoryRemoveADUserFromAllGroupspropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADUserFromAllGroups;
                }

                return new ApiConnectionAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryCheckOUExists))]
        public IBodyWorkflowAction<ActiveDirectoryCheckOUExistsResponse> ActiveDirectoryCheckOUExists([WorkflowExpression] Func<string> activeDirectoryCheckOUExistsoUIdentity, [WorkflowExpression] Func<string> activeDirectoryCheckOUExistsworkflow, [WorkflowExpression] Func<string> activeDirectoryCheckOUExistsaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryCheckOUExistsResponse> __BuildActiveDirectoryCheckOUExists(WorkflowValue<string> activeDirectoryCheckOUExistsoUIdentity, WorkflowValue<string> activeDirectoryCheckOUExistsworkflow, WorkflowValue<string> activeDirectoryCheckOUExistsaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryCheckOUExistsoUIdentity, nameof(activeDirectoryCheckOUExistsoUIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryCheckOUExistsworkflow, nameof(activeDirectoryCheckOUExistsworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryCheckOUExistsaDServer, nameof(activeDirectoryCheckOUExistsaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryCheckOUExistsResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCheckOUExists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryCheckOUExists = new JObject();
                var activeDirectoryCheckOUExistspropCount = 0;
                activeDirectoryCheckOUExistspropCount++;
                activeDirectoryCheckOUExists["OUIdentity"] = ExpressionConverter.ConvertO(activeDirectoryCheckOUExistsoUIdentity);
                if (activeDirectoryCheckOUExistsaDServer != null)
                {
                    activeDirectoryCheckOUExists["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryCheckOUExistsaDServer);
                    activeDirectoryCheckOUExistspropCount++;
                }

                activeDirectoryCheckOUExistspropCount++;
                activeDirectoryCheckOUExists["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryCheckOUExistsworkflow);
                if (activeDirectoryCheckOUExistspropCount > 0)
                {
                    callPayload.Body = activeDirectoryCheckOUExists;
                }

                return new ApiConnectionAction<ActiveDirectoryCheckOUExistsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryRemoveADGroupMemberByGroupIdentity))]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse> ActiveDirectoryRemoveADGroupMemberByGroupIdentity([WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse> __BuildActiveDirectoryRemoveADGroupMemberByGroupIdentity(WorkflowValue<string> activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity, WorkflowValue<string> activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow, WorkflowValue<string> activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity = null, WorkflowValue<string> activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName = null, WorkflowValue<string> activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity, nameof(activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow, nameof(activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity, nameof(activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName, nameof(activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer, nameof(activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADGroupMemberByGroupIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADGroupMemberByGroupIdentity = new JObject();
                var activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount = 0;
                if (activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity != null)
                {
                    activeDirectoryRemoveADGroupMemberByGroupIdentity["GroupIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity);
                    activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                }

                if (activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName != null)
                {
                    activeDirectoryRemoveADGroupMemberByGroupIdentity["GroupName"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName);
                    activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                }

                activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                activeDirectoryRemoveADGroupMemberByGroupIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity);
                if (activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer != null)
                {
                    activeDirectoryRemoveADGroupMemberByGroupIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer);
                    activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                }

                activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                activeDirectoryRemoveADGroupMemberByGroupIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow);
                if (activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADGroupMemberByGroupIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryRemoveMultipleADGroupMembersByIdentity))]
        public IBodyWorkflowAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse> ActiveDirectoryRemoveMultipleADGroupMembersByIdentity([WorkflowExpression] Func<string> activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity = null, [WorkflowExpression] Func<string> activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall = null, [WorkflowExpression] Func<string> activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse> __BuildActiveDirectoryRemoveMultipleADGroupMembersByIdentity(WorkflowValue<string> activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow, WorkflowValue<string> activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity = null, WorkflowValue<string> activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON = null, WorkflowValue<bool> activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove = null, WorkflowValue<bool> activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove = null, WorkflowValue<bool> activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall = null, WorkflowValue<string> activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveMultipleADGroupMembersByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveMultipleADGroupMembersByIdentity = new JObject();
                var activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount = 0;
                if (activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity != null)
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["GroupIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity);
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                if (activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON != null)
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["GroupMembersJSON"] = ExpressionConverter.ConvertO(activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON);
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                if (activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove != null)
                {
                    if (activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove != null)
                    {
                        activeDirectoryRemoveMultipleADGroupMembersByIdentity["ExceptionIfAnyMembersFailToRemove"] = ExpressionConverter.ConvertO(activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove);
                        activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                    }

                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["ExceptionIfAnyMembersFailToRemove"] = false;
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                if (activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove != null)
                {
                    if (activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove != null)
                    {
                        activeDirectoryRemoveMultipleADGroupMembersByIdentity["ExceptionIfAllMembersFailToRemove"] = ExpressionConverter.ConvertO(activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove);
                        activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                    }

                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["ExceptionIfAllMembersFailToRemove"] = false;
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                if (activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall != null)
                {
                    if (activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall != null)
                    {
                        activeDirectoryRemoveMultipleADGroupMembersByIdentity["RemoveAllMembersInASingleCall"] = ExpressionConverter.ConvertO(activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall);
                        activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                    }

                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }
                else
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["RemoveAllMembersInASingleCall"] = false;
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                if (activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer != null)
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer);
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                activeDirectoryRemoveMultipleADGroupMembersByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow);
                if (activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveMultipleADGroupMembersByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryUnlockADAccountByIdentity))]
        public IBodyWorkflowAction<ActiveDirectoryUnlockADAccountByIdentityResponse> ActiveDirectoryUnlockADAccountByIdentity([WorkflowExpression] Func<string> activeDirectoryUnlockADAccountByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryUnlockADAccountByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryUnlockADAccountByIdentityaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryUnlockADAccountByIdentityResponse> __BuildActiveDirectoryUnlockADAccountByIdentity(WorkflowValue<string> activeDirectoryUnlockADAccountByIdentityuserIdentity, WorkflowValue<string> activeDirectoryUnlockADAccountByIdentityworkflow, WorkflowValue<string> activeDirectoryUnlockADAccountByIdentityaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryUnlockADAccountByIdentityuserIdentity, nameof(activeDirectoryUnlockADAccountByIdentityuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryUnlockADAccountByIdentityworkflow, nameof(activeDirectoryUnlockADAccountByIdentityworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryUnlockADAccountByIdentityaDServer, nameof(activeDirectoryUnlockADAccountByIdentityaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryUnlockADAccountByIdentityResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryUnlockADAccountByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryUnlockADAccountByIdentity = new JObject();
                var activeDirectoryUnlockADAccountByIdentitypropCount = 0;
                activeDirectoryUnlockADAccountByIdentitypropCount++;
                activeDirectoryUnlockADAccountByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryUnlockADAccountByIdentityuserIdentity);
                if (activeDirectoryUnlockADAccountByIdentityaDServer != null)
                {
                    activeDirectoryUnlockADAccountByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryUnlockADAccountByIdentityaDServer);
                    activeDirectoryUnlockADAccountByIdentitypropCount++;
                }

                activeDirectoryUnlockADAccountByIdentitypropCount++;
                activeDirectoryUnlockADAccountByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryUnlockADAccountByIdentityworkflow);
                if (activeDirectoryUnlockADAccountByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryUnlockADAccountByIdentity;
                }

                return new ApiConnectionAction<ActiveDirectoryUnlockADAccountByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectorySetADServer))]
        public IBodyWorkflowAction<ActiveDirectorySetADServerResponse> ActiveDirectorySetADServer([WorkflowExpression] Func<string> activeDirectorySetADServerworkflow, [WorkflowExpression] Func<activeDirectorySetADServerpredefinedADServerChoiceInput> activeDirectorySetADServerpredefinedADServerChoice = null, [WorkflowExpression] Func<string> activeDirectorySetADServeraDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectorySetADServerResponse> __BuildActiveDirectorySetADServer(WorkflowValue<string> activeDirectorySetADServerworkflow, WorkflowValue<activeDirectorySetADServerpredefinedADServerChoiceInput> activeDirectorySetADServerpredefinedADServerChoice = null, WorkflowValue<string> activeDirectorySetADServeraDServer = null)
        {
            WorkflowValue.Validate(activeDirectorySetADServerworkflow, nameof(activeDirectorySetADServerworkflow), required: true);
            WorkflowValue.Validate(activeDirectorySetADServerpredefinedADServerChoice, nameof(activeDirectorySetADServerpredefinedADServerChoice), required: false);
            WorkflowValue.Validate(activeDirectorySetADServeraDServer, nameof(activeDirectorySetADServeraDServer), required: false);
            return new DeferredBodyAction<ActiveDirectorySetADServerResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADServer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectorySetADServer = new JObject();
                var activeDirectorySetADServerpropCount = 0;
                if (activeDirectorySetADServerpredefinedADServerChoice != null)
                {
                    if (activeDirectorySetADServerpredefinedADServerChoice != null)
                    {
                        activeDirectorySetADServer["PredefinedADServerChoice"] = ExpressionConverter.ConvertO(activeDirectorySetADServerpredefinedADServerChoice);
                        activeDirectorySetADServerpropCount++;
                    }

                    activeDirectorySetADServerpropCount++;
                }
                else
                {
                    activeDirectorySetADServer["PredefinedADServerChoice"] = "Manual: Specify in AD server field";
                    activeDirectorySetADServerpropCount++;
                }

                if (activeDirectorySetADServeraDServer != null)
                {
                    activeDirectorySetADServer["ADServer"] = ExpressionConverter.ConvertO(activeDirectorySetADServeraDServer);
                    activeDirectorySetADServerpropCount++;
                }

                activeDirectorySetADServerpropCount++;
                activeDirectorySetADServer["Workflow"] = ExpressionConverter.ConvertO(activeDirectorySetADServerworkflow);
                if (activeDirectorySetADServerpropCount > 0)
                {
                    callPayload.Body = activeDirectorySetADServer;
                }

                return new ApiConnectionAction<ActiveDirectorySetADServerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryGetDomainInfo))]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainInfoResponse> ActiveDirectoryGetDomainInfo([WorkflowExpression] Func<string> activeDirectoryGetDomainInfoworkflow, [WorkflowExpression] Func<string> activeDirectoryGetDomainInfoaDServer = null, [WorkflowExpression] Func<activeDirectoryGetDomainInfopredefinedIdentityInput> activeDirectoryGetDomainInfopredefinedIdentity = null, [WorkflowExpression] Func<string> activeDirectoryGetDomainInfoidentity = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainInfoResponse> __BuildActiveDirectoryGetDomainInfo(WorkflowValue<string> activeDirectoryGetDomainInfoworkflow, WorkflowValue<string> activeDirectoryGetDomainInfoaDServer = null, WorkflowValue<activeDirectoryGetDomainInfopredefinedIdentityInput> activeDirectoryGetDomainInfopredefinedIdentity = null, WorkflowValue<string> activeDirectoryGetDomainInfoidentity = null)
        {
            WorkflowValue.Validate(activeDirectoryGetDomainInfoworkflow, nameof(activeDirectoryGetDomainInfoworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryGetDomainInfoaDServer, nameof(activeDirectoryGetDomainInfoaDServer), required: false);
            WorkflowValue.Validate(activeDirectoryGetDomainInfopredefinedIdentity, nameof(activeDirectoryGetDomainInfopredefinedIdentity), required: false);
            WorkflowValue.Validate(activeDirectoryGetDomainInfoidentity, nameof(activeDirectoryGetDomainInfoidentity), required: false);
            return new DeferredBodyAction<ActiveDirectoryGetDomainInfoResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetDomainInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetDomainInfo = new JObject();
                var activeDirectoryGetDomainInfopropCount = 0;
                if (activeDirectoryGetDomainInfoaDServer != null)
                {
                    activeDirectoryGetDomainInfo["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryGetDomainInfoaDServer);
                    activeDirectoryGetDomainInfopropCount++;
                }

                if (activeDirectoryGetDomainInfopredefinedIdentity != null)
                {
                    if (activeDirectoryGetDomainInfopredefinedIdentity != null)
                    {
                        activeDirectoryGetDomainInfo["PredefinedIdentity"] = ExpressionConverter.ConvertO(activeDirectoryGetDomainInfopredefinedIdentity);
                        activeDirectoryGetDomainInfopropCount++;
                    }

                    activeDirectoryGetDomainInfopropCount++;
                }
                else
                {
                    activeDirectoryGetDomainInfo["PredefinedIdentity"] = "Manual: Specify in Domain identity field";
                    activeDirectoryGetDomainInfopropCount++;
                }

                if (activeDirectoryGetDomainInfoidentity != null)
                {
                    activeDirectoryGetDomainInfo["Identity"] = ExpressionConverter.ConvertO(activeDirectoryGetDomainInfoidentity);
                    activeDirectoryGetDomainInfopropCount++;
                }

                activeDirectoryGetDomainInfopropCount++;
                activeDirectoryGetDomainInfo["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryGetDomainInfoworkflow);
                if (activeDirectoryGetDomainInfopropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetDomainInfo;
                }

                return new ApiConnectionAction<ActiveDirectoryGetDomainInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryAddADGroup))]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupResponse> ActiveDirectoryAddADGroup([WorkflowExpression] Func<string> activeDirectoryAddADGroupname, [WorkflowExpression] Func<activeDirectoryAddADGroupgroupCategoryInput> activeDirectoryAddADGroupgroupCategory, [WorkflowExpression] Func<activeDirectoryAddADGroupgroupScopeInput> activeDirectoryAddADGroupgroupScope, [WorkflowExpression] Func<string> activeDirectoryAddADGroupworkflow, [WorkflowExpression] Func<string> activeDirectoryAddADGroupsamAccountName = null, [WorkflowExpression] Func<string> activeDirectoryAddADGrouppath = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupdescription = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupnotes = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupdisplayName = null, [WorkflowExpression] Func<string> activeDirectoryAddADGrouphomePage = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupmanagedBy = null, [WorkflowExpression] Func<bool> activeDirectoryAddADGroupprotectedFromAccidentalDeletion = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupResponse> __BuildActiveDirectoryAddADGroup(WorkflowValue<string> activeDirectoryAddADGroupname, WorkflowValue<activeDirectoryAddADGroupgroupCategoryInput> activeDirectoryAddADGroupgroupCategory, WorkflowValue<activeDirectoryAddADGroupgroupScopeInput> activeDirectoryAddADGroupgroupScope, WorkflowValue<string> activeDirectoryAddADGroupworkflow, WorkflowValue<string> activeDirectoryAddADGroupsamAccountName = null, WorkflowValue<string> activeDirectoryAddADGrouppath = null, WorkflowValue<string> activeDirectoryAddADGroupdescription = null, WorkflowValue<string> activeDirectoryAddADGroupnotes = null, WorkflowValue<string> activeDirectoryAddADGroupdisplayName = null, WorkflowValue<string> activeDirectoryAddADGrouphomePage = null, WorkflowValue<string> activeDirectoryAddADGroupmanagedBy = null, WorkflowValue<bool> activeDirectoryAddADGroupprotectedFromAccidentalDeletion = null, WorkflowValue<string> activeDirectoryAddADGroupaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryAddADGroupname, nameof(activeDirectoryAddADGroupname), required: true);
            WorkflowValue.Validate(activeDirectoryAddADGroupgroupCategory, nameof(activeDirectoryAddADGroupgroupCategory), required: true);
            WorkflowValue.Validate(activeDirectoryAddADGroupgroupScope, nameof(activeDirectoryAddADGroupgroupScope), required: true);
            WorkflowValue.Validate(activeDirectoryAddADGroupworkflow, nameof(activeDirectoryAddADGroupworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryAddADGroupsamAccountName, nameof(activeDirectoryAddADGroupsamAccountName), required: false);
            WorkflowValue.Validate(activeDirectoryAddADGrouppath, nameof(activeDirectoryAddADGrouppath), required: false);
            WorkflowValue.Validate(activeDirectoryAddADGroupdescription, nameof(activeDirectoryAddADGroupdescription), required: false);
            WorkflowValue.Validate(activeDirectoryAddADGroupnotes, nameof(activeDirectoryAddADGroupnotes), required: false);
            WorkflowValue.Validate(activeDirectoryAddADGroupdisplayName, nameof(activeDirectoryAddADGroupdisplayName), required: false);
            WorkflowValue.Validate(activeDirectoryAddADGrouphomePage, nameof(activeDirectoryAddADGrouphomePage), required: false);
            WorkflowValue.Validate(activeDirectoryAddADGroupmanagedBy, nameof(activeDirectoryAddADGroupmanagedBy), required: false);
            WorkflowValue.Validate(activeDirectoryAddADGroupprotectedFromAccidentalDeletion, nameof(activeDirectoryAddADGroupprotectedFromAccidentalDeletion), required: false);
            WorkflowValue.Validate(activeDirectoryAddADGroupaDServer, nameof(activeDirectoryAddADGroupaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryAddADGroupResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddADGroup = new JObject();
                var activeDirectoryAddADGrouppropCount = 0;
                activeDirectoryAddADGrouppropCount++;
                activeDirectoryAddADGroup["Name"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupname);
                if (activeDirectoryAddADGroupsamAccountName != null)
                {
                    activeDirectoryAddADGroup["SamAccountName"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupsamAccountName);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (activeDirectoryAddADGrouppath != null)
                {
                    activeDirectoryAddADGroup["Path"] = ExpressionConverter.ConvertO(activeDirectoryAddADGrouppath);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (activeDirectoryAddADGroupdescription != null)
                {
                    activeDirectoryAddADGroup["Description"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupdescription);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (activeDirectoryAddADGroupnotes != null)
                {
                    activeDirectoryAddADGroup["Notes"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupnotes);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (activeDirectoryAddADGroupdisplayName != null)
                {
                    activeDirectoryAddADGroup["DisplayName"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupdisplayName);
                    activeDirectoryAddADGrouppropCount++;
                }

                activeDirectoryAddADGrouppropCount++;
                activeDirectoryAddADGroup["GroupCategory"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupgroupCategory);
                activeDirectoryAddADGrouppropCount++;
                activeDirectoryAddADGroup["GroupScope"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupgroupScope);
                if (activeDirectoryAddADGrouphomePage != null)
                {
                    activeDirectoryAddADGroup["HomePage"] = ExpressionConverter.ConvertO(activeDirectoryAddADGrouphomePage);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (activeDirectoryAddADGroupmanagedBy != null)
                {
                    activeDirectoryAddADGroup["ManagedBy"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupmanagedBy);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (activeDirectoryAddADGroupprotectedFromAccidentalDeletion != null)
                {
                    if (activeDirectoryAddADGroupprotectedFromAccidentalDeletion != null)
                    {
                        activeDirectoryAddADGroup["ProtectedFromAccidentalDeletion"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupprotectedFromAccidentalDeletion);
                        activeDirectoryAddADGrouppropCount++;
                    }

                    activeDirectoryAddADGrouppropCount++;
                }
                else
                {
                    activeDirectoryAddADGroup["ProtectedFromAccidentalDeletion"] = false;
                    activeDirectoryAddADGrouppropCount++;
                }

                if (activeDirectoryAddADGroupaDServer != null)
                {
                    activeDirectoryAddADGroup["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupaDServer);
                    activeDirectoryAddADGrouppropCount++;
                }

                activeDirectoryAddADGrouppropCount++;
                activeDirectoryAddADGroup["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupworkflow);
                if (activeDirectoryAddADGrouppropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddADGroup;
                }

                return new ApiConnectionAction<ActiveDirectoryAddADGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryDoesADGroupExist))]
        public IBodyWorkflowAction<ActiveDirectoryDoesADGroupExistResponse> ActiveDirectoryDoesADGroupExist([WorkflowExpression] Func<string> activeDirectoryDoesADGroupExistgroupIdentity, [WorkflowExpression] Func<string> activeDirectoryDoesADGroupExistworkflow, [WorkflowExpression] Func<string> activeDirectoryDoesADGroupExistaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryDoesADGroupExistResponse> __BuildActiveDirectoryDoesADGroupExist(WorkflowValue<string> activeDirectoryDoesADGroupExistgroupIdentity, WorkflowValue<string> activeDirectoryDoesADGroupExistworkflow, WorkflowValue<string> activeDirectoryDoesADGroupExistaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryDoesADGroupExistgroupIdentity, nameof(activeDirectoryDoesADGroupExistgroupIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryDoesADGroupExistworkflow, nameof(activeDirectoryDoesADGroupExistworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryDoesADGroupExistaDServer, nameof(activeDirectoryDoesADGroupExistaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryDoesADGroupExistResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDoesADGroupExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryDoesADGroupExist = new JObject();
                var activeDirectoryDoesADGroupExistpropCount = 0;
                activeDirectoryDoesADGroupExistpropCount++;
                activeDirectoryDoesADGroupExist["GroupIdentity"] = ExpressionConverter.ConvertO(activeDirectoryDoesADGroupExistgroupIdentity);
                if (activeDirectoryDoesADGroupExistaDServer != null)
                {
                    activeDirectoryDoesADGroupExist["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryDoesADGroupExistaDServer);
                    activeDirectoryDoesADGroupExistpropCount++;
                }

                activeDirectoryDoesADGroupExistpropCount++;
                activeDirectoryDoesADGroupExist["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryDoesADGroupExistworkflow);
                if (activeDirectoryDoesADGroupExistpropCount > 0)
                {
                    callPayload.Body = activeDirectoryDoesADGroupExist;
                }

                return new ApiConnectionAction<ActiveDirectoryDoesADGroupExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryRemoveADGroup))]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupResponse> ActiveDirectoryRemoveADGroup([WorkflowExpression] Func<string> activeDirectoryRemoveADGroupgroupIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupworkflow, [WorkflowExpression] Func<bool> activeDirectoryRemoveADGroupdeleteEvenIfProtected = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupResponse> __BuildActiveDirectoryRemoveADGroup(WorkflowValue<string> activeDirectoryRemoveADGroupgroupIdentity, WorkflowValue<string> activeDirectoryRemoveADGroupworkflow, WorkflowValue<bool> activeDirectoryRemoveADGroupdeleteEvenIfProtected = null, WorkflowValue<bool> activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist = null, WorkflowValue<string> activeDirectoryRemoveADGroupaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryRemoveADGroupgroupIdentity, nameof(activeDirectoryRemoveADGroupgroupIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryRemoveADGroupworkflow, nameof(activeDirectoryRemoveADGroupworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryRemoveADGroupdeleteEvenIfProtected, nameof(activeDirectoryRemoveADGroupdeleteEvenIfProtected), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist, nameof(activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveADGroupaDServer, nameof(activeDirectoryRemoveADGroupaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryRemoveADGroupResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADGroup = new JObject();
                var activeDirectoryRemoveADGrouppropCount = 0;
                activeDirectoryRemoveADGrouppropCount++;
                activeDirectoryRemoveADGroup["GroupIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupgroupIdentity);
                if (activeDirectoryRemoveADGroupdeleteEvenIfProtected != null)
                {
                    if (activeDirectoryRemoveADGroupdeleteEvenIfProtected != null)
                    {
                        activeDirectoryRemoveADGroup["DeleteEvenIfProtected"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupdeleteEvenIfProtected);
                        activeDirectoryRemoveADGrouppropCount++;
                    }

                    activeDirectoryRemoveADGrouppropCount++;
                }
                else
                {
                    activeDirectoryRemoveADGroup["DeleteEvenIfProtected"] = false;
                    activeDirectoryRemoveADGrouppropCount++;
                }

                if (activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist != null)
                {
                    if (activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist != null)
                    {
                        activeDirectoryRemoveADGroup["RaiseExceptionIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist);
                        activeDirectoryRemoveADGrouppropCount++;
                    }

                    activeDirectoryRemoveADGrouppropCount++;
                }
                else
                {
                    activeDirectoryRemoveADGroup["RaiseExceptionIfGroupDoesNotExist"] = false;
                    activeDirectoryRemoveADGrouppropCount++;
                }

                if (activeDirectoryRemoveADGroupaDServer != null)
                {
                    activeDirectoryRemoveADGroup["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupaDServer);
                    activeDirectoryRemoveADGrouppropCount++;
                }

                activeDirectoryRemoveADGrouppropCount++;
                activeDirectoryRemoveADGroup["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupworkflow);
                if (activeDirectoryRemoveADGrouppropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADGroup;
                }

                return new ApiConnectionAction<ActiveDirectoryRemoveADGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryAddOU))]
        public IBodyWorkflowAction<ActiveDirectoryAddOUResponse> ActiveDirectoryAddOU([WorkflowExpression] Func<string> activeDirectoryAddOUname, [WorkflowExpression] Func<string> activeDirectoryAddOUworkflow, [WorkflowExpression] Func<string> activeDirectoryAddOUpath = null, [WorkflowExpression] Func<string> activeDirectoryAddOUdescription = null, [WorkflowExpression] Func<string> activeDirectoryAddOUdisplayName = null, [WorkflowExpression] Func<string> activeDirectoryAddOUmanagedBy = null, [WorkflowExpression] Func<bool> activeDirectoryAddOUprotectedFromAccidentalDeletion = null, [WorkflowExpression] Func<string> activeDirectoryAddOUstreetAddress = null, [WorkflowExpression] Func<string> activeDirectoryAddOUcity = null, [WorkflowExpression] Func<string> activeDirectoryAddOUstate = null, [WorkflowExpression] Func<string> activeDirectoryAddOUpostalCode = null, [WorkflowExpression] Func<string> activeDirectoryAddOUaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryAddOUResponse> __BuildActiveDirectoryAddOU(WorkflowValue<string> activeDirectoryAddOUname, WorkflowValue<string> activeDirectoryAddOUworkflow, WorkflowValue<string> activeDirectoryAddOUpath = null, WorkflowValue<string> activeDirectoryAddOUdescription = null, WorkflowValue<string> activeDirectoryAddOUdisplayName = null, WorkflowValue<string> activeDirectoryAddOUmanagedBy = null, WorkflowValue<bool> activeDirectoryAddOUprotectedFromAccidentalDeletion = null, WorkflowValue<string> activeDirectoryAddOUstreetAddress = null, WorkflowValue<string> activeDirectoryAddOUcity = null, WorkflowValue<string> activeDirectoryAddOUstate = null, WorkflowValue<string> activeDirectoryAddOUpostalCode = null, WorkflowValue<string> activeDirectoryAddOUaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryAddOUname, nameof(activeDirectoryAddOUname), required: true);
            WorkflowValue.Validate(activeDirectoryAddOUworkflow, nameof(activeDirectoryAddOUworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryAddOUpath, nameof(activeDirectoryAddOUpath), required: false);
            WorkflowValue.Validate(activeDirectoryAddOUdescription, nameof(activeDirectoryAddOUdescription), required: false);
            WorkflowValue.Validate(activeDirectoryAddOUdisplayName, nameof(activeDirectoryAddOUdisplayName), required: false);
            WorkflowValue.Validate(activeDirectoryAddOUmanagedBy, nameof(activeDirectoryAddOUmanagedBy), required: false);
            WorkflowValue.Validate(activeDirectoryAddOUprotectedFromAccidentalDeletion, nameof(activeDirectoryAddOUprotectedFromAccidentalDeletion), required: false);
            WorkflowValue.Validate(activeDirectoryAddOUstreetAddress, nameof(activeDirectoryAddOUstreetAddress), required: false);
            WorkflowValue.Validate(activeDirectoryAddOUcity, nameof(activeDirectoryAddOUcity), required: false);
            WorkflowValue.Validate(activeDirectoryAddOUstate, nameof(activeDirectoryAddOUstate), required: false);
            WorkflowValue.Validate(activeDirectoryAddOUpostalCode, nameof(activeDirectoryAddOUpostalCode), required: false);
            WorkflowValue.Validate(activeDirectoryAddOUaDServer, nameof(activeDirectoryAddOUaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryAddOUResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddOU";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddOU = new JObject();
                var activeDirectoryAddOUpropCount = 0;
                activeDirectoryAddOUpropCount++;
                activeDirectoryAddOU["Name"] = ExpressionConverter.ConvertO(activeDirectoryAddOUname);
                if (activeDirectoryAddOUpath != null)
                {
                    activeDirectoryAddOU["Path"] = ExpressionConverter.ConvertO(activeDirectoryAddOUpath);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUdescription != null)
                {
                    activeDirectoryAddOU["Description"] = ExpressionConverter.ConvertO(activeDirectoryAddOUdescription);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUdisplayName != null)
                {
                    activeDirectoryAddOU["DisplayName"] = ExpressionConverter.ConvertO(activeDirectoryAddOUdisplayName);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUmanagedBy != null)
                {
                    activeDirectoryAddOU["ManagedBy"] = ExpressionConverter.ConvertO(activeDirectoryAddOUmanagedBy);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUprotectedFromAccidentalDeletion != null)
                {
                    if (activeDirectoryAddOUprotectedFromAccidentalDeletion != null)
                    {
                        activeDirectoryAddOU["ProtectedFromAccidentalDeletion"] = ExpressionConverter.ConvertO(activeDirectoryAddOUprotectedFromAccidentalDeletion);
                        activeDirectoryAddOUpropCount++;
                    }

                    activeDirectoryAddOUpropCount++;
                }
                else
                {
                    activeDirectoryAddOU["ProtectedFromAccidentalDeletion"] = true;
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUstreetAddress != null)
                {
                    activeDirectoryAddOU["StreetAddress"] = ExpressionConverter.ConvertO(activeDirectoryAddOUstreetAddress);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUcity != null)
                {
                    activeDirectoryAddOU["City"] = ExpressionConverter.ConvertO(activeDirectoryAddOUcity);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUstate != null)
                {
                    activeDirectoryAddOU["State"] = ExpressionConverter.ConvertO(activeDirectoryAddOUstate);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUpostalCode != null)
                {
                    activeDirectoryAddOU["PostalCode"] = ExpressionConverter.ConvertO(activeDirectoryAddOUpostalCode);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUaDServer != null)
                {
                    activeDirectoryAddOU["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryAddOUaDServer);
                    activeDirectoryAddOUpropCount++;
                }

                activeDirectoryAddOUpropCount++;
                activeDirectoryAddOU["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryAddOUworkflow);
                if (activeDirectoryAddOUpropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddOU;
                }

                return new ApiConnectionAction<ActiveDirectoryAddOUResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryRemoveOU))]
        public IBodyWorkflowAction<ActiveDirectoryRemoveOUResponse> ActiveDirectoryRemoveOU([WorkflowExpression] Func<string> activeDirectoryRemoveOUoUIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveOUworkflow, [WorkflowExpression] Func<bool> activeDirectoryRemoveOUdeleteEvenIfProtected = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist = null, [WorkflowExpression] Func<string> activeDirectoryRemoveOUaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryRemoveOUResponse> __BuildActiveDirectoryRemoveOU(WorkflowValue<string> activeDirectoryRemoveOUoUIdentity, WorkflowValue<string> activeDirectoryRemoveOUworkflow, WorkflowValue<bool> activeDirectoryRemoveOUdeleteEvenIfProtected = null, WorkflowValue<bool> activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist = null, WorkflowValue<string> activeDirectoryRemoveOUaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryRemoveOUoUIdentity, nameof(activeDirectoryRemoveOUoUIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryRemoveOUworkflow, nameof(activeDirectoryRemoveOUworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryRemoveOUdeleteEvenIfProtected, nameof(activeDirectoryRemoveOUdeleteEvenIfProtected), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist, nameof(activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist), required: false);
            WorkflowValue.Validate(activeDirectoryRemoveOUaDServer, nameof(activeDirectoryRemoveOUaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryRemoveOUResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveOU";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveOU = new JObject();
                var activeDirectoryRemoveOUpropCount = 0;
                activeDirectoryRemoveOUpropCount++;
                activeDirectoryRemoveOU["OUIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveOUoUIdentity);
                if (activeDirectoryRemoveOUdeleteEvenIfProtected != null)
                {
                    if (activeDirectoryRemoveOUdeleteEvenIfProtected != null)
                    {
                        activeDirectoryRemoveOU["DeleteEvenIfProtected"] = ExpressionConverter.ConvertO(activeDirectoryRemoveOUdeleteEvenIfProtected);
                        activeDirectoryRemoveOUpropCount++;
                    }

                    activeDirectoryRemoveOUpropCount++;
                }
                else
                {
                    activeDirectoryRemoveOU["DeleteEvenIfProtected"] = false;
                    activeDirectoryRemoveOUpropCount++;
                }

                if (activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist != null)
                {
                    if (activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist != null)
                    {
                        activeDirectoryRemoveOU["RaiseExceptionIfOUDoesNotExist"] = ExpressionConverter.ConvertO(activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist);
                        activeDirectoryRemoveOUpropCount++;
                    }

                    activeDirectoryRemoveOUpropCount++;
                }
                else
                {
                    activeDirectoryRemoveOU["RaiseExceptionIfOUDoesNotExist"] = false;
                    activeDirectoryRemoveOUpropCount++;
                }

                if (activeDirectoryRemoveOUaDServer != null)
                {
                    activeDirectoryRemoveOU["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryRemoveOUaDServer);
                    activeDirectoryRemoveOUpropCount++;
                }

                activeDirectoryRemoveOUpropCount++;
                activeDirectoryRemoveOU["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryRemoveOUworkflow);
                if (activeDirectoryRemoveOUpropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveOU;
                }

                return new ApiConnectionAction<ActiveDirectoryRemoveOUResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectorySetADUserAccountExpirationEndOfDate))]
        public IBodyWorkflowAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse> ActiveDirectorySetADUserAccountExpirationEndOfDate([WorkflowExpression] Func<string> activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity, [WorkflowExpression] Func<int> activeDirectorySetADUserAccountExpirationEndOfDateyear, [WorkflowExpression] Func<int> activeDirectorySetADUserAccountExpirationEndOfDatemonth, [WorkflowExpression] Func<int> activeDirectorySetADUserAccountExpirationEndOfDateday, [WorkflowExpression] Func<string> activeDirectorySetADUserAccountExpirationEndOfDateworkflow, [WorkflowExpression] Func<string> activeDirectorySetADUserAccountExpirationEndOfDateaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse> __BuildActiveDirectorySetADUserAccountExpirationEndOfDate(WorkflowValue<string> activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity, WorkflowValue<int> activeDirectorySetADUserAccountExpirationEndOfDateyear, WorkflowValue<int> activeDirectorySetADUserAccountExpirationEndOfDatemonth, WorkflowValue<int> activeDirectorySetADUserAccountExpirationEndOfDateday, WorkflowValue<string> activeDirectorySetADUserAccountExpirationEndOfDateworkflow, WorkflowValue<string> activeDirectorySetADUserAccountExpirationEndOfDateaDServer = null)
        {
            WorkflowValue.Validate(activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity, nameof(activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity), required: true);
            WorkflowValue.Validate(activeDirectorySetADUserAccountExpirationEndOfDateyear, nameof(activeDirectorySetADUserAccountExpirationEndOfDateyear), required: true);
            WorkflowValue.Validate(activeDirectorySetADUserAccountExpirationEndOfDatemonth, nameof(activeDirectorySetADUserAccountExpirationEndOfDatemonth), required: true);
            WorkflowValue.Validate(activeDirectorySetADUserAccountExpirationEndOfDateday, nameof(activeDirectorySetADUserAccountExpirationEndOfDateday), required: true);
            WorkflowValue.Validate(activeDirectorySetADUserAccountExpirationEndOfDateworkflow, nameof(activeDirectorySetADUserAccountExpirationEndOfDateworkflow), required: true);
            WorkflowValue.Validate(activeDirectorySetADUserAccountExpirationEndOfDateaDServer, nameof(activeDirectorySetADUserAccountExpirationEndOfDateaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserAccountExpirationEndOfDate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectorySetADUserAccountExpirationEndOfDate = new JObject();
                var activeDirectorySetADUserAccountExpirationEndOfDatepropCount = 0;
                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity);
                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["Year"] = ExpressionConverter.ConvertO(activeDirectorySetADUserAccountExpirationEndOfDateyear);
                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["Month"] = ExpressionConverter.ConvertO(activeDirectorySetADUserAccountExpirationEndOfDatemonth);
                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["Day"] = ExpressionConverter.ConvertO(activeDirectorySetADUserAccountExpirationEndOfDateday);
                if (activeDirectorySetADUserAccountExpirationEndOfDateaDServer != null)
                {
                    activeDirectorySetADUserAccountExpirationEndOfDate["ADServer"] = ExpressionConverter.ConvertO(activeDirectorySetADUserAccountExpirationEndOfDateaDServer);
                    activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                }

                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["Workflow"] = ExpressionConverter.ConvertO(activeDirectorySetADUserAccountExpirationEndOfDateworkflow);
                if (activeDirectorySetADUserAccountExpirationEndOfDatepropCount > 0)
                {
                    callPayload.Body = activeDirectorySetADUserAccountExpirationEndOfDate;
                }

                return new ApiConnectionAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildActiveDirectoryGetADGroupMembers))]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupMembersResponse> ActiveDirectoryGetADGroupMembers([WorkflowExpression] Func<string> activeDirectoryGetADGroupMembersgroupIdentity, [WorkflowExpression] Func<string> activeDirectoryGetADGroupMembersworkflow, [WorkflowExpression] Func<bool> activeDirectoryGetADGroupMembersrecursive = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupMembersaDServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupMembersResponse> __BuildActiveDirectoryGetADGroupMembers(WorkflowValue<string> activeDirectoryGetADGroupMembersgroupIdentity, WorkflowValue<string> activeDirectoryGetADGroupMembersworkflow, WorkflowValue<bool> activeDirectoryGetADGroupMembersrecursive = null, WorkflowValue<string> activeDirectoryGetADGroupMembersaDServer = null)
        {
            WorkflowValue.Validate(activeDirectoryGetADGroupMembersgroupIdentity, nameof(activeDirectoryGetADGroupMembersgroupIdentity), required: true);
            WorkflowValue.Validate(activeDirectoryGetADGroupMembersworkflow, nameof(activeDirectoryGetADGroupMembersworkflow), required: true);
            WorkflowValue.Validate(activeDirectoryGetADGroupMembersrecursive, nameof(activeDirectoryGetADGroupMembersrecursive), required: false);
            WorkflowValue.Validate(activeDirectoryGetADGroupMembersaDServer, nameof(activeDirectoryGetADGroupMembersaDServer), required: false);
            return new DeferredBodyAction<ActiveDirectoryGetADGroupMembersResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetADGroupMembers = new JObject();
                var activeDirectoryGetADGroupMemberspropCount = 0;
                activeDirectoryGetADGroupMemberspropCount++;
                activeDirectoryGetADGroupMembers["GroupIdentity"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupMembersgroupIdentity);
                if (activeDirectoryGetADGroupMembersrecursive != null)
                {
                    if (activeDirectoryGetADGroupMembersrecursive != null)
                    {
                        activeDirectoryGetADGroupMembers["Recursive"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupMembersrecursive);
                        activeDirectoryGetADGroupMemberspropCount++;
                    }

                    activeDirectoryGetADGroupMemberspropCount++;
                }
                else
                {
                    activeDirectoryGetADGroupMembers["Recursive"] = false;
                    activeDirectoryGetADGroupMemberspropCount++;
                }

                if (activeDirectoryGetADGroupMembersaDServer != null)
                {
                    activeDirectoryGetADGroupMembers["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupMembersaDServer);
                    activeDirectoryGetADGroupMemberspropCount++;
                }

                activeDirectoryGetADGroupMemberspropCount++;
                activeDirectoryGetADGroupMembers["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupMembersworkflow);
                if (activeDirectoryGetADGroupMemberspropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetADGroupMembers;
                }

                return new ApiConnectionAction<ActiveDirectoryGetADGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildOpenExchangePowerShellRunspace))]
        public IBodyWorkflowAction<OpenExchangePowerShellRunspaceResponse> OpenExchangePowerShellRunspace([WorkflowExpression] Func<string> openExchangePowerShellRunspaceexchangeServerFQDN, [WorkflowExpression] Func<string> openExchangePowerShellRunspaceworkflow, [WorkflowExpression] Func<string> openExchangePowerShellRunspaceusername = null, [WorkflowExpression] Func<string> openExchangePowerShellRunspacepassword = null, [WorkflowExpression] Func<bool> openExchangePowerShellRunspaceuseSSL = null, [WorkflowExpression] Func<openExchangePowerShellRunspaceconnectionMethodInput> openExchangePowerShellRunspaceconnectionMethod = null, [WorkflowExpression] Func<openExchangePowerShellRunspaceauthenticationMechanismInput> openExchangePowerShellRunspaceauthenticationMechanism = null, [WorkflowExpression] Func<bool> openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected = null, [WorkflowExpression] Func<openExchangePowerShellRunspacecommandTypesToImportLocallyInput> openExchangePowerShellRunspacecommandTypesToImportLocally = null, [WorkflowExpression] Func<string> openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenExchangePowerShellRunspaceResponse> __BuildOpenExchangePowerShellRunspace(WorkflowValue<string> openExchangePowerShellRunspaceexchangeServerFQDN, WorkflowValue<string> openExchangePowerShellRunspaceworkflow, WorkflowValue<string> openExchangePowerShellRunspaceusername = null, WorkflowValue<string> openExchangePowerShellRunspacepassword = null, WorkflowValue<bool> openExchangePowerShellRunspaceuseSSL = null, WorkflowValue<openExchangePowerShellRunspaceconnectionMethodInput> openExchangePowerShellRunspaceconnectionMethod = null, WorkflowValue<openExchangePowerShellRunspaceauthenticationMechanismInput> openExchangePowerShellRunspaceauthenticationMechanism = null, WorkflowValue<bool> openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected = null, WorkflowValue<openExchangePowerShellRunspacecommandTypesToImportLocallyInput> openExchangePowerShellRunspacecommandTypesToImportLocally = null, WorkflowValue<string> openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV = null)
        {
            WorkflowValue.Validate(openExchangePowerShellRunspaceexchangeServerFQDN, nameof(openExchangePowerShellRunspaceexchangeServerFQDN), required: true);
            WorkflowValue.Validate(openExchangePowerShellRunspaceworkflow, nameof(openExchangePowerShellRunspaceworkflow), required: true);
            WorkflowValue.Validate(openExchangePowerShellRunspaceusername, nameof(openExchangePowerShellRunspaceusername), required: false);
            WorkflowValue.Validate(openExchangePowerShellRunspacepassword, nameof(openExchangePowerShellRunspacepassword), required: false);
            WorkflowValue.Validate(openExchangePowerShellRunspaceuseSSL, nameof(openExchangePowerShellRunspaceuseSSL), required: false);
            WorkflowValue.Validate(openExchangePowerShellRunspaceconnectionMethod, nameof(openExchangePowerShellRunspaceconnectionMethod), required: false);
            WorkflowValue.Validate(openExchangePowerShellRunspaceauthenticationMechanism, nameof(openExchangePowerShellRunspaceauthenticationMechanism), required: false);
            WorkflowValue.Validate(openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected, nameof(openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected), required: false);
            WorkflowValue.Validate(openExchangePowerShellRunspacecommandTypesToImportLocally, nameof(openExchangePowerShellRunspacecommandTypesToImportLocally), required: false);
            WorkflowValue.Validate(openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV, nameof(openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV), required: false);
            return new DeferredBodyAction<OpenExchangePowerShellRunspaceResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenExchangePowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openExchangePowerShellRunspace = new JObject();
                var openExchangePowerShellRunspacepropCount = 0;
                if (openExchangePowerShellRunspaceusername != null)
                {
                    openExchangePowerShellRunspace["Username"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceusername);
                    openExchangePowerShellRunspacepropCount++;
                }

                if (openExchangePowerShellRunspacepassword != null)
                {
                    openExchangePowerShellRunspace["Password"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspacepassword);
                    openExchangePowerShellRunspacepropCount++;
                }

                openExchangePowerShellRunspacepropCount++;
                openExchangePowerShellRunspace["ExchangeServerFQDN"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceexchangeServerFQDN);
                if (openExchangePowerShellRunspaceuseSSL != null)
                {
                    if (openExchangePowerShellRunspaceuseSSL != null)
                    {
                        openExchangePowerShellRunspace["UseSSL"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceuseSSL);
                        openExchangePowerShellRunspacepropCount++;
                    }

                    openExchangePowerShellRunspacepropCount++;
                }
                else
                {
                    openExchangePowerShellRunspace["UseSSL"] = false;
                    openExchangePowerShellRunspacepropCount++;
                }

                if (openExchangePowerShellRunspaceconnectionMethod != null)
                {
                    if (openExchangePowerShellRunspaceconnectionMethod != null)
                    {
                        openExchangePowerShellRunspace["ConnectionMethod"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceconnectionMethod);
                        openExchangePowerShellRunspacepropCount++;
                    }

                    openExchangePowerShellRunspacepropCount++;
                }
                else
                {
                    openExchangePowerShellRunspace["ConnectionMethod"] = "Remote";
                    openExchangePowerShellRunspacepropCount++;
                }

                if (openExchangePowerShellRunspaceauthenticationMechanism != null)
                {
                    if (openExchangePowerShellRunspaceauthenticationMechanism != null)
                    {
                        openExchangePowerShellRunspace["AuthenticationMechanism"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceauthenticationMechanism);
                        openExchangePowerShellRunspacepropCount++;
                    }

                    openExchangePowerShellRunspacepropCount++;
                }
                else
                {
                    openExchangePowerShellRunspace["AuthenticationMechanism"] = "Kerberos";
                    openExchangePowerShellRunspacepropCount++;
                }

                if (openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected != null)
                {
                    if (openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected != null)
                    {
                        openExchangePowerShellRunspace["OnlyConnectIfNotAlreadyConnected"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected);
                        openExchangePowerShellRunspacepropCount++;
                    }

                    openExchangePowerShellRunspacepropCount++;
                }
                else
                {
                    openExchangePowerShellRunspace["OnlyConnectIfNotAlreadyConnected"] = true;
                    openExchangePowerShellRunspacepropCount++;
                }

                if (openExchangePowerShellRunspacecommandTypesToImportLocally != null)
                {
                    if (openExchangePowerShellRunspacecommandTypesToImportLocally != null)
                    {
                        openExchangePowerShellRunspace["CommandTypesToImportLocally"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspacecommandTypesToImportLocally);
                        openExchangePowerShellRunspacepropCount++;
                    }

                    openExchangePowerShellRunspacepropCount++;
                }
                else
                {
                    openExchangePowerShellRunspace["CommandTypesToImportLocally"] = "All";
                    openExchangePowerShellRunspacepropCount++;
                }

                if (openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV != null)
                {
                    openExchangePowerShellRunspace["AdditionalCommandsToImportLocallyCSV"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV);
                    openExchangePowerShellRunspacepropCount++;
                }

                openExchangePowerShellRunspacepropCount++;
                openExchangePowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceworkflow);
                if (openExchangePowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = openExchangePowerShellRunspace;
                }

                return new ApiConnectionAction<OpenExchangePowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildIsExchangePowerShellRunspaceOpen))]
        public IBodyWorkflowAction<IsExchangePowerShellRunspaceOpenResponse> IsExchangePowerShellRunspaceOpen([WorkflowExpression] Func<string> isExchangePowerShellRunspaceOpenworkflow, [WorkflowExpression] Func<bool> isExchangePowerShellRunspaceOpentestCommunications = null, [WorkflowExpression] Func<bool> isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsExchangePowerShellRunspaceOpenResponse> __BuildIsExchangePowerShellRunspaceOpen(WorkflowValue<string> isExchangePowerShellRunspaceOpenworkflow, WorkflowValue<bool> isExchangePowerShellRunspaceOpentestCommunications = null, WorkflowValue<bool> isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
        {
            WorkflowValue.Validate(isExchangePowerShellRunspaceOpenworkflow, nameof(isExchangePowerShellRunspaceOpenworkflow), required: true);
            WorkflowValue.Validate(isExchangePowerShellRunspaceOpentestCommunications, nameof(isExchangePowerShellRunspaceOpentestCommunications), required: false);
            WorkflowValue.Validate(isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID, nameof(isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID), required: false);
            return new DeferredBodyAction<IsExchangePowerShellRunspaceOpenResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/IsExchangePowerShellRunspaceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isExchangePowerShellRunspaceOpen = new JObject();
                var isExchangePowerShellRunspaceOpenpropCount = 0;
                if (isExchangePowerShellRunspaceOpentestCommunications != null)
                {
                    if (isExchangePowerShellRunspaceOpentestCommunications != null)
                    {
                        isExchangePowerShellRunspaceOpen["TestCommunications"] = ExpressionConverter.ConvertO(isExchangePowerShellRunspaceOpentestCommunications);
                        isExchangePowerShellRunspaceOpenpropCount++;
                    }

                    isExchangePowerShellRunspaceOpenpropCount++;
                }
                else
                {
                    isExchangePowerShellRunspaceOpen["TestCommunications"] = true;
                    isExchangePowerShellRunspaceOpenpropCount++;
                }

                if (isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID != null)
                {
                    if (isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID != null)
                    {
                        isExchangePowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = ExpressionConverter.ConvertO(isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID);
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
                isExchangePowerShellRunspaceOpen["Workflow"] = ExpressionConverter.ConvertO(isExchangePowerShellRunspaceOpenworkflow);
                if (isExchangePowerShellRunspaceOpenpropCount > 0)
                {
                    callPayload.Body = isExchangePowerShellRunspaceOpen;
                }

                return new ApiConnectionAction<IsExchangePowerShellRunspaceOpenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildRunExchangePowerShellAutomationScript))]
        public IBodyWorkflowAction<RunExchangePowerShellAutomationScriptResponse> RunExchangePowerShellAutomationScript([WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptworkflow, [WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptpowerShellScriptContents = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptisNoResultAnError = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptreturnComplexTypes = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptreturnBooleanAsBoolean = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptreturnNumericAsDecimal = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptreturnDateAsDate = null, [WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptrunScriptAsThread = null, [WorkflowExpression] Func<int> runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> runExchangePowerShellAutomationScriptsecondsToWaitForThread = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptscriptContainsStoredPassword = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptlogVerboseOutput = null, [WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON = null, [WorkflowExpression] Func<runExchangePowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runExchangePowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunExchangePowerShellAutomationScriptResponse> __BuildRunExchangePowerShellAutomationScript(WorkflowValue<string> runExchangePowerShellAutomationScriptworkflow, WorkflowValue<string> runExchangePowerShellAutomationScriptpowerShellScriptContents = null, WorkflowValue<bool> runExchangePowerShellAutomationScriptisNoResultAnError = null, WorkflowValue<bool> runExchangePowerShellAutomationScriptreturnComplexTypes = null, WorkflowValue<bool> runExchangePowerShellAutomationScriptreturnBooleanAsBoolean = null, WorkflowValue<bool> runExchangePowerShellAutomationScriptreturnNumericAsDecimal = null, WorkflowValue<bool> runExchangePowerShellAutomationScriptreturnDateAsDate = null, WorkflowValue<string> runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, WorkflowValue<bool> runExchangePowerShellAutomationScriptrunScriptAsThread = null, WorkflowValue<int> runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId = null, WorkflowValue<int> runExchangePowerShellAutomationScriptsecondsToWaitForThread = null, WorkflowValue<bool> runExchangePowerShellAutomationScriptscriptContainsStoredPassword = null, WorkflowValue<bool> runExchangePowerShellAutomationScriptlogVerboseOutput = null, WorkflowValue<string> runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON = null, WorkflowValue<string> runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON = null, WorkflowValue<runExchangePowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runExchangePowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptworkflow, nameof(runExchangePowerShellAutomationScriptworkflow), required: true);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptpowerShellScriptContents, nameof(runExchangePowerShellAutomationScriptpowerShellScriptContents), required: false);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptisNoResultAnError, nameof(runExchangePowerShellAutomationScriptisNoResultAnError), required: false);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptreturnComplexTypes, nameof(runExchangePowerShellAutomationScriptreturnComplexTypes), required: false);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptreturnBooleanAsBoolean, nameof(runExchangePowerShellAutomationScriptreturnBooleanAsBoolean), required: false);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptreturnNumericAsDecimal, nameof(runExchangePowerShellAutomationScriptreturnNumericAsDecimal), required: false);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptreturnDateAsDate, nameof(runExchangePowerShellAutomationScriptreturnDateAsDate), required: false);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON, nameof(runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON), required: false);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptrunScriptAsThread, nameof(runExchangePowerShellAutomationScriptrunScriptAsThread), required: false);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId, nameof(runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId), required: false);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptsecondsToWaitForThread, nameof(runExchangePowerShellAutomationScriptsecondsToWaitForThread), required: false);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptscriptContainsStoredPassword, nameof(runExchangePowerShellAutomationScriptscriptContainsStoredPassword), required: false);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptlogVerboseOutput, nameof(runExchangePowerShellAutomationScriptlogVerboseOutput), required: false);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON, nameof(runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON), required: false);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON, nameof(runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON), required: false);
            WorkflowValue.Validate(runExchangePowerShellAutomationScriptpowerShellCommandParameters, nameof(runExchangePowerShellAutomationScriptpowerShellCommandParameters), required: false);
            return new DeferredBodyAction<RunExchangePowerShellAutomationScriptResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/RunExchangePowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runExchangePowerShellAutomationScript = new JObject();
                var runExchangePowerShellAutomationScriptpropCount = 0;
                if (runExchangePowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runExchangePowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptpowerShellScriptContents);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (runExchangePowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runExchangePowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptisNoResultAnError);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["IsNoResultAnError"] = false;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptreturnComplexTypes != null)
                {
                    if (runExchangePowerShellAutomationScriptreturnComplexTypes != null)
                    {
                        runExchangePowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptreturnComplexTypes);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["ReturnComplexTypes"] = false;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptreturnBooleanAsBoolean != null)
                {
                    if (runExchangePowerShellAutomationScriptreturnBooleanAsBoolean != null)
                    {
                        runExchangePowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptreturnBooleanAsBoolean);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["ReturnBooleanAsBoolean"] = false;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptreturnNumericAsDecimal != null)
                {
                    if (runExchangePowerShellAutomationScriptreturnNumericAsDecimal != null)
                    {
                        runExchangePowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptreturnNumericAsDecimal);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["ReturnNumericAsDecimal"] = false;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptreturnDateAsDate != null)
                {
                    if (runExchangePowerShellAutomationScriptreturnDateAsDate != null)
                    {
                        runExchangePowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptreturnDateAsDate);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["ReturnDateAsDate"] = false;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON != null)
                {
                    runExchangePowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (runExchangePowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runExchangePowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptrunScriptAsThread);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["RunScriptAsThread"] = false;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId != null)
                {
                    runExchangePowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (runExchangePowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runExchangePowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptsecondsToWaitForThread);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["SecondsToWaitForThread"] = 90;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptscriptContainsStoredPassword != null)
                {
                    if (runExchangePowerShellAutomationScriptscriptContainsStoredPassword != null)
                    {
                        runExchangePowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptscriptContainsStoredPassword);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["ScriptContainsStoredPassword"] = true;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptlogVerboseOutput != null)
                {
                    if (runExchangePowerShellAutomationScriptlogVerboseOutput != null)
                    {
                        runExchangePowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptlogVerboseOutput);
                        runExchangePowerShellAutomationScriptpropCount++;
                    }

                    runExchangePowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runExchangePowerShellAutomationScript["LogVerboseOutput"] = false;
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON != null)
                {
                    runExchangePowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runExchangePowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runExchangePowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptpowerShellCommandParameters);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                runExchangePowerShellAutomationScriptpropCount++;
                runExchangePowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptworkflow);
                if (runExchangePowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runExchangePowerShellAutomationScript;
                }

                return new ApiConnectionAction<RunExchangePowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildCloseExchangePowerShellRunspace))]
        public IBodyWorkflowAction<CloseExchangePowerShellRunspaceResponse> CloseExchangePowerShellRunspace([WorkflowExpression] Func<string> closeExchangePowerShellRunspaceworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CloseExchangePowerShellRunspaceResponse> __BuildCloseExchangePowerShellRunspace(WorkflowValue<string> closeExchangePowerShellRunspaceworkflow)
        {
            WorkflowValue.Validate(closeExchangePowerShellRunspaceworkflow, nameof(closeExchangePowerShellRunspaceworkflow), required: true);
            return new DeferredBodyAction<CloseExchangePowerShellRunspaceResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/CloseExchangePowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var closeExchangePowerShellRunspace = new JObject();
                var closeExchangePowerShellRunspacepropCount = 0;
                closeExchangePowerShellRunspacepropCount++;
                closeExchangePowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(closeExchangePowerShellRunspaceworkflow);
                if (closeExchangePowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = closeExchangePowerShellRunspace;
                }

                return new ApiConnectionAction<CloseExchangePowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeGetMailbox))]
        public IBodyWorkflowAction<ExchangeGetMailboxResponse> ExchangeGetMailbox([WorkflowExpression] Func<string> exchangeGetMailboxworkflow, [WorkflowExpression] Func<string> exchangeGetMailboxidentity = null, [WorkflowExpression] Func<string> exchangeGetMailboxfilterPropertyName = null, [WorkflowExpression] Func<exchangeGetMailboxfilterPropertyComparisonInput> exchangeGetMailboxfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeGetMailboxfilterPropertyValue = null, [WorkflowExpression] Func<exchangeGetMailboxrecipientTypeDetailsInput> exchangeGetMailboxrecipientTypeDetails = null, [WorkflowExpression] Func<bool> exchangeGetMailboxnoResultIsAnException = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeGetMailboxResponse> __BuildExchangeGetMailbox(WorkflowValue<string> exchangeGetMailboxworkflow, WorkflowValue<string> exchangeGetMailboxidentity = null, WorkflowValue<string> exchangeGetMailboxfilterPropertyName = null, WorkflowValue<exchangeGetMailboxfilterPropertyComparisonInput> exchangeGetMailboxfilterPropertyComparison = null, WorkflowValue<string> exchangeGetMailboxfilterPropertyValue = null, WorkflowValue<exchangeGetMailboxrecipientTypeDetailsInput> exchangeGetMailboxrecipientTypeDetails = null, WorkflowValue<bool> exchangeGetMailboxnoResultIsAnException = null)
        {
            WorkflowValue.Validate(exchangeGetMailboxworkflow, nameof(exchangeGetMailboxworkflow), required: true);
            WorkflowValue.Validate(exchangeGetMailboxidentity, nameof(exchangeGetMailboxidentity), required: false);
            WorkflowValue.Validate(exchangeGetMailboxfilterPropertyName, nameof(exchangeGetMailboxfilterPropertyName), required: false);
            WorkflowValue.Validate(exchangeGetMailboxfilterPropertyComparison, nameof(exchangeGetMailboxfilterPropertyComparison), required: false);
            WorkflowValue.Validate(exchangeGetMailboxfilterPropertyValue, nameof(exchangeGetMailboxfilterPropertyValue), required: false);
            WorkflowValue.Validate(exchangeGetMailboxrecipientTypeDetails, nameof(exchangeGetMailboxrecipientTypeDetails), required: false);
            WorkflowValue.Validate(exchangeGetMailboxnoResultIsAnException, nameof(exchangeGetMailboxnoResultIsAnException), required: false);
            return new DeferredBodyAction<ExchangeGetMailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetMailbox = new JObject();
                var exchangeGetMailboxpropCount = 0;
                if (exchangeGetMailboxidentity != null)
                {
                    exchangeGetMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeGetMailboxidentity);
                    exchangeGetMailboxpropCount++;
                }

                if (exchangeGetMailboxfilterPropertyName != null)
                {
                    exchangeGetMailbox["FilterPropertyName"] = ExpressionConverter.ConvertO(exchangeGetMailboxfilterPropertyName);
                    exchangeGetMailboxpropCount++;
                }

                if (exchangeGetMailboxfilterPropertyComparison != null)
                {
                    if (exchangeGetMailboxfilterPropertyComparison != null)
                    {
                        exchangeGetMailbox["FilterPropertyComparison"] = ExpressionConverter.ConvertO(exchangeGetMailboxfilterPropertyComparison);
                        exchangeGetMailboxpropCount++;
                    }

                    exchangeGetMailboxpropCount++;
                }
                else
                {
                    exchangeGetMailbox["FilterPropertyComparison"] = "Equals";
                    exchangeGetMailboxpropCount++;
                }

                if (exchangeGetMailboxfilterPropertyValue != null)
                {
                    exchangeGetMailbox["FilterPropertyValue"] = ExpressionConverter.ConvertO(exchangeGetMailboxfilterPropertyValue);
                    exchangeGetMailboxpropCount++;
                }

                if (exchangeGetMailboxrecipientTypeDetails != null)
                {
                    exchangeGetMailbox["RecipientTypeDetails"] = ExpressionConverter.ConvertO(exchangeGetMailboxrecipientTypeDetails);
                    exchangeGetMailboxpropCount++;
                }

                if (exchangeGetMailboxnoResultIsAnException != null)
                {
                    if (exchangeGetMailboxnoResultIsAnException != null)
                    {
                        exchangeGetMailbox["NoResultIsAnException"] = ExpressionConverter.ConvertO(exchangeGetMailboxnoResultIsAnException);
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
                exchangeGetMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeGetMailboxworkflow);
                if (exchangeGetMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeGetMailbox;
                }

                return new ApiConnectionAction<ExchangeGetMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeDoesMailboxExist))]
        public IBodyWorkflowAction<ExchangeDoesMailboxExistResponse> ExchangeDoesMailboxExist([WorkflowExpression] Func<string> exchangeDoesMailboxExistworkflow, [WorkflowExpression] Func<string> exchangeDoesMailboxExistidentity = null, [WorkflowExpression] Func<string> exchangeDoesMailboxExistfilterPropertyName = null, [WorkflowExpression] Func<exchangeDoesMailboxExistfilterPropertyComparisonInput> exchangeDoesMailboxExistfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeDoesMailboxExistfilterPropertyValue = null, [WorkflowExpression] Func<exchangeDoesMailboxExistrecipientTypeDetailsInput> exchangeDoesMailboxExistrecipientTypeDetails = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeDoesMailboxExistResponse> __BuildExchangeDoesMailboxExist(WorkflowValue<string> exchangeDoesMailboxExistworkflow, WorkflowValue<string> exchangeDoesMailboxExistidentity = null, WorkflowValue<string> exchangeDoesMailboxExistfilterPropertyName = null, WorkflowValue<exchangeDoesMailboxExistfilterPropertyComparisonInput> exchangeDoesMailboxExistfilterPropertyComparison = null, WorkflowValue<string> exchangeDoesMailboxExistfilterPropertyValue = null, WorkflowValue<exchangeDoesMailboxExistrecipientTypeDetailsInput> exchangeDoesMailboxExistrecipientTypeDetails = null)
        {
            WorkflowValue.Validate(exchangeDoesMailboxExistworkflow, nameof(exchangeDoesMailboxExistworkflow), required: true);
            WorkflowValue.Validate(exchangeDoesMailboxExistidentity, nameof(exchangeDoesMailboxExistidentity), required: false);
            WorkflowValue.Validate(exchangeDoesMailboxExistfilterPropertyName, nameof(exchangeDoesMailboxExistfilterPropertyName), required: false);
            WorkflowValue.Validate(exchangeDoesMailboxExistfilterPropertyComparison, nameof(exchangeDoesMailboxExistfilterPropertyComparison), required: false);
            WorkflowValue.Validate(exchangeDoesMailboxExistfilterPropertyValue, nameof(exchangeDoesMailboxExistfilterPropertyValue), required: false);
            WorkflowValue.Validate(exchangeDoesMailboxExistrecipientTypeDetails, nameof(exchangeDoesMailboxExistrecipientTypeDetails), required: false);
            return new DeferredBodyAction<ExchangeDoesMailboxExistResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDoesMailboxExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeDoesMailboxExist = new JObject();
                var exchangeDoesMailboxExistpropCount = 0;
                if (exchangeDoesMailboxExistidentity != null)
                {
                    exchangeDoesMailboxExist["Identity"] = ExpressionConverter.ConvertO(exchangeDoesMailboxExistidentity);
                    exchangeDoesMailboxExistpropCount++;
                }

                if (exchangeDoesMailboxExistfilterPropertyName != null)
                {
                    exchangeDoesMailboxExist["FilterPropertyName"] = ExpressionConverter.ConvertO(exchangeDoesMailboxExistfilterPropertyName);
                    exchangeDoesMailboxExistpropCount++;
                }

                if (exchangeDoesMailboxExistfilterPropertyComparison != null)
                {
                    if (exchangeDoesMailboxExistfilterPropertyComparison != null)
                    {
                        exchangeDoesMailboxExist["FilterPropertyComparison"] = ExpressionConverter.ConvertO(exchangeDoesMailboxExistfilterPropertyComparison);
                        exchangeDoesMailboxExistpropCount++;
                    }

                    exchangeDoesMailboxExistpropCount++;
                }
                else
                {
                    exchangeDoesMailboxExist["FilterPropertyComparison"] = "Equals";
                    exchangeDoesMailboxExistpropCount++;
                }

                if (exchangeDoesMailboxExistfilterPropertyValue != null)
                {
                    exchangeDoesMailboxExist["FilterPropertyValue"] = ExpressionConverter.ConvertO(exchangeDoesMailboxExistfilterPropertyValue);
                    exchangeDoesMailboxExistpropCount++;
                }

                if (exchangeDoesMailboxExistrecipientTypeDetails != null)
                {
                    exchangeDoesMailboxExist["RecipientTypeDetails"] = ExpressionConverter.ConvertO(exchangeDoesMailboxExistrecipientTypeDetails);
                    exchangeDoesMailboxExistpropCount++;
                }

                exchangeDoesMailboxExistpropCount++;
                exchangeDoesMailboxExist["Workflow"] = ExpressionConverter.ConvertO(exchangeDoesMailboxExistworkflow);
                if (exchangeDoesMailboxExistpropCount > 0)
                {
                    callPayload.Body = exchangeDoesMailboxExist;
                }

                return new ApiConnectionAction<ExchangeDoesMailboxExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeAddDistributionGroupMember))]
        public IBodyWorkflowAction<ExchangeAddDistributionGroupMemberResponse> ExchangeAddDistributionGroupMember([WorkflowExpression] Func<string> exchangeAddDistributionGroupMemberidentity, [WorkflowExpression] Func<string> exchangeAddDistributionGroupMembermember, [WorkflowExpression] Func<string> exchangeAddDistributionGroupMemberworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeAddDistributionGroupMemberResponse> __BuildExchangeAddDistributionGroupMember(WorkflowValue<string> exchangeAddDistributionGroupMemberidentity, WorkflowValue<string> exchangeAddDistributionGroupMembermember, WorkflowValue<string> exchangeAddDistributionGroupMemberworkflow)
        {
            WorkflowValue.Validate(exchangeAddDistributionGroupMemberidentity, nameof(exchangeAddDistributionGroupMemberidentity), required: true);
            WorkflowValue.Validate(exchangeAddDistributionGroupMembermember, nameof(exchangeAddDistributionGroupMembermember), required: true);
            WorkflowValue.Validate(exchangeAddDistributionGroupMemberworkflow, nameof(exchangeAddDistributionGroupMemberworkflow), required: true);
            return new DeferredBodyAction<ExchangeAddDistributionGroupMemberResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeAddDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeAddDistributionGroupMember = new JObject();
                var exchangeAddDistributionGroupMemberpropCount = 0;
                exchangeAddDistributionGroupMemberpropCount++;
                exchangeAddDistributionGroupMember["Identity"] = ExpressionConverter.ConvertO(exchangeAddDistributionGroupMemberidentity);
                exchangeAddDistributionGroupMemberpropCount++;
                exchangeAddDistributionGroupMember["Member"] = ExpressionConverter.ConvertO(exchangeAddDistributionGroupMembermember);
                exchangeAddDistributionGroupMemberpropCount++;
                exchangeAddDistributionGroupMember["Workflow"] = ExpressionConverter.ConvertO(exchangeAddDistributionGroupMemberworkflow);
                if (exchangeAddDistributionGroupMemberpropCount > 0)
                {
                    callPayload.Body = exchangeAddDistributionGroupMember;
                }

                return new ApiConnectionAction<ExchangeAddDistributionGroupMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeRemoveDistributionGroupMember))]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupMemberResponse> ExchangeRemoveDistributionGroupMember([WorkflowExpression] Func<string> exchangeRemoveDistributionGroupMemberidentity, [WorkflowExpression] Func<string> exchangeRemoveDistributionGroupMembermember, [WorkflowExpression] Func<string> exchangeRemoveDistributionGroupMemberworkflow, [WorkflowExpression] Func<bool> exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupMemberResponse> __BuildExchangeRemoveDistributionGroupMember(WorkflowValue<string> exchangeRemoveDistributionGroupMemberidentity, WorkflowValue<string> exchangeRemoveDistributionGroupMembermember, WorkflowValue<string> exchangeRemoveDistributionGroupMemberworkflow, WorkflowValue<bool> exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck = null)
        {
            WorkflowValue.Validate(exchangeRemoveDistributionGroupMemberidentity, nameof(exchangeRemoveDistributionGroupMemberidentity), required: true);
            WorkflowValue.Validate(exchangeRemoveDistributionGroupMembermember, nameof(exchangeRemoveDistributionGroupMembermember), required: true);
            WorkflowValue.Validate(exchangeRemoveDistributionGroupMemberworkflow, nameof(exchangeRemoveDistributionGroupMemberworkflow), required: true);
            WorkflowValue.Validate(exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck, nameof(exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck), required: false);
            return new DeferredBodyAction<ExchangeRemoveDistributionGroupMemberResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeRemoveDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeRemoveDistributionGroupMember = new JObject();
                var exchangeRemoveDistributionGroupMemberpropCount = 0;
                exchangeRemoveDistributionGroupMemberpropCount++;
                exchangeRemoveDistributionGroupMember["Identity"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupMemberidentity);
                exchangeRemoveDistributionGroupMemberpropCount++;
                exchangeRemoveDistributionGroupMember["Member"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupMembermember);
                if (exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                {
                    if (exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                    {
                        exchangeRemoveDistributionGroupMember["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck);
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
                exchangeRemoveDistributionGroupMember["Workflow"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupMemberworkflow);
                if (exchangeRemoveDistributionGroupMemberpropCount > 0)
                {
                    callPayload.Body = exchangeRemoveDistributionGroupMember;
                }

                return new ApiConnectionAction<ExchangeRemoveDistributionGroupMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeGetDistributionGroup))]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupResponse> ExchangeGetDistributionGroup([WorkflowExpression] Func<string> exchangeGetDistributionGroupworkflow, [WorkflowExpression] Func<string> exchangeGetDistributionGroupidentity = null, [WorkflowExpression] Func<string> exchangeGetDistributionGroupfilterPropertyName = null, [WorkflowExpression] Func<exchangeGetDistributionGroupfilterPropertyComparisonInput> exchangeGetDistributionGroupfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeGetDistributionGroupfilterPropertyValue = null, [WorkflowExpression] Func<bool> exchangeGetDistributionGroupnoResultIsAnException = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupResponse> __BuildExchangeGetDistributionGroup(WorkflowValue<string> exchangeGetDistributionGroupworkflow, WorkflowValue<string> exchangeGetDistributionGroupidentity = null, WorkflowValue<string> exchangeGetDistributionGroupfilterPropertyName = null, WorkflowValue<exchangeGetDistributionGroupfilterPropertyComparisonInput> exchangeGetDistributionGroupfilterPropertyComparison = null, WorkflowValue<string> exchangeGetDistributionGroupfilterPropertyValue = null, WorkflowValue<bool> exchangeGetDistributionGroupnoResultIsAnException = null)
        {
            WorkflowValue.Validate(exchangeGetDistributionGroupworkflow, nameof(exchangeGetDistributionGroupworkflow), required: true);
            WorkflowValue.Validate(exchangeGetDistributionGroupidentity, nameof(exchangeGetDistributionGroupidentity), required: false);
            WorkflowValue.Validate(exchangeGetDistributionGroupfilterPropertyName, nameof(exchangeGetDistributionGroupfilterPropertyName), required: false);
            WorkflowValue.Validate(exchangeGetDistributionGroupfilterPropertyComparison, nameof(exchangeGetDistributionGroupfilterPropertyComparison), required: false);
            WorkflowValue.Validate(exchangeGetDistributionGroupfilterPropertyValue, nameof(exchangeGetDistributionGroupfilterPropertyValue), required: false);
            WorkflowValue.Validate(exchangeGetDistributionGroupnoResultIsAnException, nameof(exchangeGetDistributionGroupnoResultIsAnException), required: false);
            return new DeferredBodyAction<ExchangeGetDistributionGroupResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetDistributionGroup = new JObject();
                var exchangeGetDistributionGrouppropCount = 0;
                if (exchangeGetDistributionGroupidentity != null)
                {
                    exchangeGetDistributionGroup["Identity"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupidentity);
                    exchangeGetDistributionGrouppropCount++;
                }

                if (exchangeGetDistributionGroupfilterPropertyName != null)
                {
                    exchangeGetDistributionGroup["FilterPropertyName"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupfilterPropertyName);
                    exchangeGetDistributionGrouppropCount++;
                }

                if (exchangeGetDistributionGroupfilterPropertyComparison != null)
                {
                    if (exchangeGetDistributionGroupfilterPropertyComparison != null)
                    {
                        exchangeGetDistributionGroup["FilterPropertyComparison"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupfilterPropertyComparison);
                        exchangeGetDistributionGrouppropCount++;
                    }

                    exchangeGetDistributionGrouppropCount++;
                }
                else
                {
                    exchangeGetDistributionGroup["FilterPropertyComparison"] = "Equals";
                    exchangeGetDistributionGrouppropCount++;
                }

                if (exchangeGetDistributionGroupfilterPropertyValue != null)
                {
                    exchangeGetDistributionGroup["FilterPropertyValue"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupfilterPropertyValue);
                    exchangeGetDistributionGrouppropCount++;
                }

                if (exchangeGetDistributionGroupnoResultIsAnException != null)
                {
                    if (exchangeGetDistributionGroupnoResultIsAnException != null)
                    {
                        exchangeGetDistributionGroup["NoResultIsAnException"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupnoResultIsAnException);
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
                exchangeGetDistributionGroup["Workflow"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupworkflow);
                if (exchangeGetDistributionGrouppropCount > 0)
                {
                    callPayload.Body = exchangeGetDistributionGroup;
                }

                return new ApiConnectionAction<ExchangeGetDistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeGetDistributionGroupMembers))]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupMembersResponse> ExchangeGetDistributionGroupMembers([WorkflowExpression] Func<string> exchangeGetDistributionGroupMembersidentity, [WorkflowExpression] Func<string> exchangeGetDistributionGroupMembersworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupMembersResponse> __BuildExchangeGetDistributionGroupMembers(WorkflowValue<string> exchangeGetDistributionGroupMembersidentity, WorkflowValue<string> exchangeGetDistributionGroupMembersworkflow)
        {
            WorkflowValue.Validate(exchangeGetDistributionGroupMembersidentity, nameof(exchangeGetDistributionGroupMembersidentity), required: true);
            WorkflowValue.Validate(exchangeGetDistributionGroupMembersworkflow, nameof(exchangeGetDistributionGroupMembersworkflow), required: true);
            return new DeferredBodyAction<ExchangeGetDistributionGroupMembersResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetDistributionGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetDistributionGroupMembers = new JObject();
                var exchangeGetDistributionGroupMemberspropCount = 0;
                exchangeGetDistributionGroupMemberspropCount++;
                exchangeGetDistributionGroupMembers["Identity"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupMembersidentity);
                exchangeGetDistributionGroupMemberspropCount++;
                exchangeGetDistributionGroupMembers["Workflow"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupMembersworkflow);
                if (exchangeGetDistributionGroupMemberspropCount > 0)
                {
                    callPayload.Body = exchangeGetDistributionGroupMembers;
                }

                return new ApiConnectionAction<ExchangeGetDistributionGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeGetMailboxDistributionGroupMembership))]
        public IBodyWorkflowAction<ExchangeGetMailboxDistributionGroupMembershipResponse> ExchangeGetMailboxDistributionGroupMembership([WorkflowExpression] Func<string> exchangeGetMailboxDistributionGroupMembershipidentity, [WorkflowExpression] Func<string> exchangeGetMailboxDistributionGroupMembershipworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeGetMailboxDistributionGroupMembershipResponse> __BuildExchangeGetMailboxDistributionGroupMembership(WorkflowValue<string> exchangeGetMailboxDistributionGroupMembershipidentity, WorkflowValue<string> exchangeGetMailboxDistributionGroupMembershipworkflow)
        {
            WorkflowValue.Validate(exchangeGetMailboxDistributionGroupMembershipidentity, nameof(exchangeGetMailboxDistributionGroupMembershipidentity), required: true);
            WorkflowValue.Validate(exchangeGetMailboxDistributionGroupMembershipworkflow, nameof(exchangeGetMailboxDistributionGroupMembershipworkflow), required: true);
            return new DeferredBodyAction<ExchangeGetMailboxDistributionGroupMembershipResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetMailboxDistributionGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetMailboxDistributionGroupMembership = new JObject();
                var exchangeGetMailboxDistributionGroupMembershippropCount = 0;
                exchangeGetMailboxDistributionGroupMembershippropCount++;
                exchangeGetMailboxDistributionGroupMembership["Identity"] = ExpressionConverter.ConvertO(exchangeGetMailboxDistributionGroupMembershipidentity);
                exchangeGetMailboxDistributionGroupMembershippropCount++;
                exchangeGetMailboxDistributionGroupMembership["Workflow"] = ExpressionConverter.ConvertO(exchangeGetMailboxDistributionGroupMembershipworkflow);
                if (exchangeGetMailboxDistributionGroupMembershippropCount > 0)
                {
                    callPayload.Body = exchangeGetMailboxDistributionGroupMembership;
                }

                return new ApiConnectionAction<ExchangeGetMailboxDistributionGroupMembershipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeNewDistributionGroup))]
        public IBodyWorkflowAction<ExchangeNewDistributionGroupResponse> ExchangeNewDistributionGroup([WorkflowExpression] Func<string> exchangeNewDistributionGroupname, [WorkflowExpression] Func<string> exchangeNewDistributionGroupworkflow, [WorkflowExpression] Func<string> exchangeNewDistributionGroupalias = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupdisplayName = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupnotes = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupmanagedBy = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupmembers = null, [WorkflowExpression] Func<string> exchangeNewDistributionGrouporganizationalUnit = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupprimarySmtpAddress = null, [WorkflowExpression] Func<exchangeNewDistributionGroupmemberDepartRestrictionInput> exchangeNewDistributionGroupmemberDepartRestriction = null, [WorkflowExpression] Func<exchangeNewDistributionGroupmemberJoinRestrictionInput> exchangeNewDistributionGroupmemberJoinRestriction = null, [WorkflowExpression] Func<bool> exchangeNewDistributionGrouprequireSenderAuthenticationEnabled = null, [WorkflowExpression] Func<exchangeNewDistributionGrouptypeInput> exchangeNewDistributionGrouptype = null, [WorkflowExpression] Func<bool> exchangeNewDistributionGrouperrorIfGroupAlreadyExists = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeNewDistributionGroupResponse> __BuildExchangeNewDistributionGroup(WorkflowValue<string> exchangeNewDistributionGroupname, WorkflowValue<string> exchangeNewDistributionGroupworkflow, WorkflowValue<string> exchangeNewDistributionGroupalias = null, WorkflowValue<string> exchangeNewDistributionGroupdisplayName = null, WorkflowValue<string> exchangeNewDistributionGroupnotes = null, WorkflowValue<string> exchangeNewDistributionGroupmanagedBy = null, WorkflowValue<string> exchangeNewDistributionGroupmembers = null, WorkflowValue<string> exchangeNewDistributionGrouporganizationalUnit = null, WorkflowValue<string> exchangeNewDistributionGroupprimarySmtpAddress = null, WorkflowValue<exchangeNewDistributionGroupmemberDepartRestrictionInput> exchangeNewDistributionGroupmemberDepartRestriction = null, WorkflowValue<exchangeNewDistributionGroupmemberJoinRestrictionInput> exchangeNewDistributionGroupmemberJoinRestriction = null, WorkflowValue<bool> exchangeNewDistributionGrouprequireSenderAuthenticationEnabled = null, WorkflowValue<exchangeNewDistributionGrouptypeInput> exchangeNewDistributionGrouptype = null, WorkflowValue<bool> exchangeNewDistributionGrouperrorIfGroupAlreadyExists = null)
        {
            WorkflowValue.Validate(exchangeNewDistributionGroupname, nameof(exchangeNewDistributionGroupname), required: true);
            WorkflowValue.Validate(exchangeNewDistributionGroupworkflow, nameof(exchangeNewDistributionGroupworkflow), required: true);
            WorkflowValue.Validate(exchangeNewDistributionGroupalias, nameof(exchangeNewDistributionGroupalias), required: false);
            WorkflowValue.Validate(exchangeNewDistributionGroupdisplayName, nameof(exchangeNewDistributionGroupdisplayName), required: false);
            WorkflowValue.Validate(exchangeNewDistributionGroupnotes, nameof(exchangeNewDistributionGroupnotes), required: false);
            WorkflowValue.Validate(exchangeNewDistributionGroupmanagedBy, nameof(exchangeNewDistributionGroupmanagedBy), required: false);
            WorkflowValue.Validate(exchangeNewDistributionGroupmembers, nameof(exchangeNewDistributionGroupmembers), required: false);
            WorkflowValue.Validate(exchangeNewDistributionGrouporganizationalUnit, nameof(exchangeNewDistributionGrouporganizationalUnit), required: false);
            WorkflowValue.Validate(exchangeNewDistributionGroupprimarySmtpAddress, nameof(exchangeNewDistributionGroupprimarySmtpAddress), required: false);
            WorkflowValue.Validate(exchangeNewDistributionGroupmemberDepartRestriction, nameof(exchangeNewDistributionGroupmemberDepartRestriction), required: false);
            WorkflowValue.Validate(exchangeNewDistributionGroupmemberJoinRestriction, nameof(exchangeNewDistributionGroupmemberJoinRestriction), required: false);
            WorkflowValue.Validate(exchangeNewDistributionGrouprequireSenderAuthenticationEnabled, nameof(exchangeNewDistributionGrouprequireSenderAuthenticationEnabled), required: false);
            WorkflowValue.Validate(exchangeNewDistributionGrouptype, nameof(exchangeNewDistributionGrouptype), required: false);
            WorkflowValue.Validate(exchangeNewDistributionGrouperrorIfGroupAlreadyExists, nameof(exchangeNewDistributionGrouperrorIfGroupAlreadyExists), required: false);
            return new DeferredBodyAction<ExchangeNewDistributionGroupResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeNewDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeNewDistributionGroup = new JObject();
                var exchangeNewDistributionGrouppropCount = 0;
                exchangeNewDistributionGrouppropCount++;
                exchangeNewDistributionGroup["Name"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupname);
                if (exchangeNewDistributionGroupalias != null)
                {
                    exchangeNewDistributionGroup["Alias"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupalias);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGroupdisplayName != null)
                {
                    exchangeNewDistributionGroup["DisplayName"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupdisplayName);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGroupnotes != null)
                {
                    exchangeNewDistributionGroup["Notes"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupnotes);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGroupmanagedBy != null)
                {
                    exchangeNewDistributionGroup["ManagedBy"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupmanagedBy);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGroupmembers != null)
                {
                    exchangeNewDistributionGroup["Members"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupmembers);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGrouporganizationalUnit != null)
                {
                    exchangeNewDistributionGroup["OrganizationalUnit"] = ExpressionConverter.ConvertO(exchangeNewDistributionGrouporganizationalUnit);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGroupprimarySmtpAddress != null)
                {
                    exchangeNewDistributionGroup["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupprimarySmtpAddress);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGroupmemberDepartRestriction != null)
                {
                    if (exchangeNewDistributionGroupmemberDepartRestriction != null)
                    {
                        exchangeNewDistributionGroup["MemberDepartRestriction"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupmemberDepartRestriction);
                        exchangeNewDistributionGrouppropCount++;
                    }

                    exchangeNewDistributionGrouppropCount++;
                }
                else
                {
                    exchangeNewDistributionGroup["MemberDepartRestriction"] = "Open";
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGroupmemberJoinRestriction != null)
                {
                    if (exchangeNewDistributionGroupmemberJoinRestriction != null)
                    {
                        exchangeNewDistributionGroup["MemberJoinRestriction"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupmemberJoinRestriction);
                        exchangeNewDistributionGrouppropCount++;
                    }

                    exchangeNewDistributionGrouppropCount++;
                }
                else
                {
                    exchangeNewDistributionGroup["MemberJoinRestriction"] = "Closed";
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGrouprequireSenderAuthenticationEnabled != null)
                {
                    if (exchangeNewDistributionGrouprequireSenderAuthenticationEnabled != null)
                    {
                        exchangeNewDistributionGroup["RequireSenderAuthenticationEnabled"] = ExpressionConverter.ConvertO(exchangeNewDistributionGrouprequireSenderAuthenticationEnabled);
                        exchangeNewDistributionGrouppropCount++;
                    }

                    exchangeNewDistributionGrouppropCount++;
                }
                else
                {
                    exchangeNewDistributionGroup["RequireSenderAuthenticationEnabled"] = false;
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGrouptype != null)
                {
                    if (exchangeNewDistributionGrouptype != null)
                    {
                        exchangeNewDistributionGroup["Type"] = ExpressionConverter.ConvertO(exchangeNewDistributionGrouptype);
                        exchangeNewDistributionGrouppropCount++;
                    }

                    exchangeNewDistributionGrouppropCount++;
                }
                else
                {
                    exchangeNewDistributionGroup["Type"] = "Distribution";
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGrouperrorIfGroupAlreadyExists != null)
                {
                    if (exchangeNewDistributionGrouperrorIfGroupAlreadyExists != null)
                    {
                        exchangeNewDistributionGroup["ErrorIfGroupAlreadyExists"] = ExpressionConverter.ConvertO(exchangeNewDistributionGrouperrorIfGroupAlreadyExists);
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
                exchangeNewDistributionGroup["Workflow"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupworkflow);
                if (exchangeNewDistributionGrouppropCount > 0)
                {
                    callPayload.Body = exchangeNewDistributionGroup;
                }

                return new ApiConnectionAction<ExchangeNewDistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeRemoveDistributionGroup))]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupResponse> ExchangeRemoveDistributionGroup([WorkflowExpression] Func<string> exchangeRemoveDistributionGroupidentity, [WorkflowExpression] Func<string> exchangeRemoveDistributionGroupworkflow, [WorkflowExpression] Func<bool> exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck = null, [WorkflowExpression] Func<bool> exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupResponse> __BuildExchangeRemoveDistributionGroup(WorkflowValue<string> exchangeRemoveDistributionGroupidentity, WorkflowValue<string> exchangeRemoveDistributionGroupworkflow, WorkflowValue<bool> exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck = null, WorkflowValue<bool> exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist = null)
        {
            WorkflowValue.Validate(exchangeRemoveDistributionGroupidentity, nameof(exchangeRemoveDistributionGroupidentity), required: true);
            WorkflowValue.Validate(exchangeRemoveDistributionGroupworkflow, nameof(exchangeRemoveDistributionGroupworkflow), required: true);
            WorkflowValue.Validate(exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck, nameof(exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck), required: false);
            WorkflowValue.Validate(exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist, nameof(exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist), required: false);
            return new DeferredBodyAction<ExchangeRemoveDistributionGroupResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeRemoveDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeRemoveDistributionGroup = new JObject();
                var exchangeRemoveDistributionGrouppropCount = 0;
                exchangeRemoveDistributionGrouppropCount++;
                exchangeRemoveDistributionGroup["Identity"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupidentity);
                if (exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
                {
                    if (exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
                    {
                        exchangeRemoveDistributionGroup["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck);
                        exchangeRemoveDistributionGrouppropCount++;
                    }

                    exchangeRemoveDistributionGrouppropCount++;
                }
                else
                {
                    exchangeRemoveDistributionGroup["BypassSecurityGroupManagerCheck"] = true;
                    exchangeRemoveDistributionGrouppropCount++;
                }

                if (exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist != null)
                {
                    if (exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist != null)
                    {
                        exchangeRemoveDistributionGroup["ErrorIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist);
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
                exchangeRemoveDistributionGroup["Workflow"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupworkflow);
                if (exchangeRemoveDistributionGrouppropCount > 0)
                {
                    callPayload.Body = exchangeRemoveDistributionGroup;
                }

                return new ApiConnectionAction<ExchangeRemoveDistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeAddMailboxPermission))]
        public IBodyWorkflowAction<ExchangeAddMailboxPermissionResponse> ExchangeAddMailboxPermission([WorkflowExpression] Func<string> exchangeAddMailboxPermissionidentity, [WorkflowExpression] Func<string> exchangeAddMailboxPermissionuser, [WorkflowExpression] Func<string> exchangeAddMailboxPermissionaccessRights, [WorkflowExpression] Func<string> exchangeAddMailboxPermissionworkflow, [WorkflowExpression] Func<bool> exchangeAddMailboxPermissionautoMapping = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeAddMailboxPermissionResponse> __BuildExchangeAddMailboxPermission(WorkflowValue<string> exchangeAddMailboxPermissionidentity, WorkflowValue<string> exchangeAddMailboxPermissionuser, WorkflowValue<string> exchangeAddMailboxPermissionaccessRights, WorkflowValue<string> exchangeAddMailboxPermissionworkflow, WorkflowValue<bool> exchangeAddMailboxPermissionautoMapping = null)
        {
            WorkflowValue.Validate(exchangeAddMailboxPermissionidentity, nameof(exchangeAddMailboxPermissionidentity), required: true);
            WorkflowValue.Validate(exchangeAddMailboxPermissionuser, nameof(exchangeAddMailboxPermissionuser), required: true);
            WorkflowValue.Validate(exchangeAddMailboxPermissionaccessRights, nameof(exchangeAddMailboxPermissionaccessRights), required: true);
            WorkflowValue.Validate(exchangeAddMailboxPermissionworkflow, nameof(exchangeAddMailboxPermissionworkflow), required: true);
            WorkflowValue.Validate(exchangeAddMailboxPermissionautoMapping, nameof(exchangeAddMailboxPermissionautoMapping), required: false);
            return new DeferredBodyAction<ExchangeAddMailboxPermissionResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeAddMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeAddMailboxPermission = new JObject();
                var exchangeAddMailboxPermissionpropCount = 0;
                exchangeAddMailboxPermissionpropCount++;
                exchangeAddMailboxPermission["Identity"] = ExpressionConverter.ConvertO(exchangeAddMailboxPermissionidentity);
                exchangeAddMailboxPermissionpropCount++;
                exchangeAddMailboxPermission["User"] = ExpressionConverter.ConvertO(exchangeAddMailboxPermissionuser);
                exchangeAddMailboxPermissionpropCount++;
                exchangeAddMailboxPermission["AccessRights"] = ExpressionConverter.ConvertO(exchangeAddMailboxPermissionaccessRights);
                if (exchangeAddMailboxPermissionautoMapping != null)
                {
                    if (exchangeAddMailboxPermissionautoMapping != null)
                    {
                        exchangeAddMailboxPermission["AutoMapping"] = ExpressionConverter.ConvertO(exchangeAddMailboxPermissionautoMapping);
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
                exchangeAddMailboxPermission["Workflow"] = ExpressionConverter.ConvertO(exchangeAddMailboxPermissionworkflow);
                if (exchangeAddMailboxPermissionpropCount > 0)
                {
                    callPayload.Body = exchangeAddMailboxPermission;
                }

                return new ApiConnectionAction<ExchangeAddMailboxPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeRemoveMailboxPermission))]
        public IBodyWorkflowAction<ExchangeRemoveMailboxPermissionResponse> ExchangeRemoveMailboxPermission([WorkflowExpression] Func<string> exchangeRemoveMailboxPermissionidentity, [WorkflowExpression] Func<string> exchangeRemoveMailboxPermissionuser, [WorkflowExpression] Func<string> exchangeRemoveMailboxPermissionaccessRights, [WorkflowExpression] Func<string> exchangeRemoveMailboxPermissionworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeRemoveMailboxPermissionResponse> __BuildExchangeRemoveMailboxPermission(WorkflowValue<string> exchangeRemoveMailboxPermissionidentity, WorkflowValue<string> exchangeRemoveMailboxPermissionuser, WorkflowValue<string> exchangeRemoveMailboxPermissionaccessRights, WorkflowValue<string> exchangeRemoveMailboxPermissionworkflow)
        {
            WorkflowValue.Validate(exchangeRemoveMailboxPermissionidentity, nameof(exchangeRemoveMailboxPermissionidentity), required: true);
            WorkflowValue.Validate(exchangeRemoveMailboxPermissionuser, nameof(exchangeRemoveMailboxPermissionuser), required: true);
            WorkflowValue.Validate(exchangeRemoveMailboxPermissionaccessRights, nameof(exchangeRemoveMailboxPermissionaccessRights), required: true);
            WorkflowValue.Validate(exchangeRemoveMailboxPermissionworkflow, nameof(exchangeRemoveMailboxPermissionworkflow), required: true);
            return new DeferredBodyAction<ExchangeRemoveMailboxPermissionResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeRemoveMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeRemoveMailboxPermission = new JObject();
                var exchangeRemoveMailboxPermissionpropCount = 0;
                exchangeRemoveMailboxPermissionpropCount++;
                exchangeRemoveMailboxPermission["Identity"] = ExpressionConverter.ConvertO(exchangeRemoveMailboxPermissionidentity);
                exchangeRemoveMailboxPermissionpropCount++;
                exchangeRemoveMailboxPermission["User"] = ExpressionConverter.ConvertO(exchangeRemoveMailboxPermissionuser);
                exchangeRemoveMailboxPermissionpropCount++;
                exchangeRemoveMailboxPermission["AccessRights"] = ExpressionConverter.ConvertO(exchangeRemoveMailboxPermissionaccessRights);
                exchangeRemoveMailboxPermissionpropCount++;
                exchangeRemoveMailboxPermission["Workflow"] = ExpressionConverter.ConvertO(exchangeRemoveMailboxPermissionworkflow);
                if (exchangeRemoveMailboxPermissionpropCount > 0)
                {
                    callPayload.Body = exchangeRemoveMailboxPermission;
                }

                return new ApiConnectionAction<ExchangeRemoveMailboxPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeDisableMailbox))]
        public IBodyWorkflowAction<ExchangeDisableMailboxResponse> ExchangeDisableMailbox([WorkflowExpression] Func<string> exchangeDisableMailboxidentity, [WorkflowExpression] Func<string> exchangeDisableMailboxworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeDisableMailboxResponse> __BuildExchangeDisableMailbox(WorkflowValue<string> exchangeDisableMailboxidentity, WorkflowValue<string> exchangeDisableMailboxworkflow)
        {
            WorkflowValue.Validate(exchangeDisableMailboxidentity, nameof(exchangeDisableMailboxidentity), required: true);
            WorkflowValue.Validate(exchangeDisableMailboxworkflow, nameof(exchangeDisableMailboxworkflow), required: true);
            return new DeferredBodyAction<ExchangeDisableMailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDisableMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeDisableMailbox = new JObject();
                var exchangeDisableMailboxpropCount = 0;
                exchangeDisableMailboxpropCount++;
                exchangeDisableMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeDisableMailboxidentity);
                exchangeDisableMailboxpropCount++;
                exchangeDisableMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeDisableMailboxworkflow);
                if (exchangeDisableMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeDisableMailbox;
                }

                return new ApiConnectionAction<ExchangeDisableMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeDisableRemoteMailbox))]
        public IBodyWorkflowAction<ExchangeDisableRemoteMailboxResponse> ExchangeDisableRemoteMailbox([WorkflowExpression] Func<string> exchangeDisableRemoteMailboxidentity, [WorkflowExpression] Func<string> exchangeDisableRemoteMailboxworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeDisableRemoteMailboxResponse> __BuildExchangeDisableRemoteMailbox(WorkflowValue<string> exchangeDisableRemoteMailboxidentity, WorkflowValue<string> exchangeDisableRemoteMailboxworkflow)
        {
            WorkflowValue.Validate(exchangeDisableRemoteMailboxidentity, nameof(exchangeDisableRemoteMailboxidentity), required: true);
            WorkflowValue.Validate(exchangeDisableRemoteMailboxworkflow, nameof(exchangeDisableRemoteMailboxworkflow), required: true);
            return new DeferredBodyAction<ExchangeDisableRemoteMailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDisableRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeDisableRemoteMailbox = new JObject();
                var exchangeDisableRemoteMailboxpropCount = 0;
                exchangeDisableRemoteMailboxpropCount++;
                exchangeDisableRemoteMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeDisableRemoteMailboxidentity);
                exchangeDisableRemoteMailboxpropCount++;
                exchangeDisableRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeDisableRemoteMailboxworkflow);
                if (exchangeDisableRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeDisableRemoteMailbox;
                }

                return new ApiConnectionAction<ExchangeDisableRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeEnableMailbox))]
        public IBodyWorkflowAction<ExchangeEnableMailboxResponse> ExchangeEnableMailbox([WorkflowExpression] Func<string> exchangeEnableMailboxidentity, [WorkflowExpression] Func<string> exchangeEnableMailboxworkflow, [WorkflowExpression] Func<string> exchangeEnableMailboxalias = null, [WorkflowExpression] Func<string> exchangeEnableMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeEnableMailboxlinkedDomainController = null, [WorkflowExpression] Func<string> exchangeEnableMailboxlinkedMasterAccount = null, [WorkflowExpression] Func<string> exchangeEnableMailboxdatabase = null, [WorkflowExpression] Func<string> exchangeEnableMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeEnableMailboxemailAddressPolicyEnabled = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeEnableMailboxResponse> __BuildExchangeEnableMailbox(WorkflowValue<string> exchangeEnableMailboxidentity, WorkflowValue<string> exchangeEnableMailboxworkflow, WorkflowValue<string> exchangeEnableMailboxalias = null, WorkflowValue<string> exchangeEnableMailboxdisplayName = null, WorkflowValue<string> exchangeEnableMailboxlinkedDomainController = null, WorkflowValue<string> exchangeEnableMailboxlinkedMasterAccount = null, WorkflowValue<string> exchangeEnableMailboxdatabase = null, WorkflowValue<string> exchangeEnableMailboxprimarySmtpAddress = null, WorkflowValue<bool> exchangeEnableMailboxemailAddressPolicyEnabled = null)
        {
            WorkflowValue.Validate(exchangeEnableMailboxidentity, nameof(exchangeEnableMailboxidentity), required: true);
            WorkflowValue.Validate(exchangeEnableMailboxworkflow, nameof(exchangeEnableMailboxworkflow), required: true);
            WorkflowValue.Validate(exchangeEnableMailboxalias, nameof(exchangeEnableMailboxalias), required: false);
            WorkflowValue.Validate(exchangeEnableMailboxdisplayName, nameof(exchangeEnableMailboxdisplayName), required: false);
            WorkflowValue.Validate(exchangeEnableMailboxlinkedDomainController, nameof(exchangeEnableMailboxlinkedDomainController), required: false);
            WorkflowValue.Validate(exchangeEnableMailboxlinkedMasterAccount, nameof(exchangeEnableMailboxlinkedMasterAccount), required: false);
            WorkflowValue.Validate(exchangeEnableMailboxdatabase, nameof(exchangeEnableMailboxdatabase), required: false);
            WorkflowValue.Validate(exchangeEnableMailboxprimarySmtpAddress, nameof(exchangeEnableMailboxprimarySmtpAddress), required: false);
            WorkflowValue.Validate(exchangeEnableMailboxemailAddressPolicyEnabled, nameof(exchangeEnableMailboxemailAddressPolicyEnabled), required: false);
            return new DeferredBodyAction<ExchangeEnableMailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeEnableMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeEnableMailbox = new JObject();
                var exchangeEnableMailboxpropCount = 0;
                exchangeEnableMailboxpropCount++;
                exchangeEnableMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeEnableMailboxidentity);
                if (exchangeEnableMailboxalias != null)
                {
                    exchangeEnableMailbox["Alias"] = ExpressionConverter.ConvertO(exchangeEnableMailboxalias);
                    exchangeEnableMailboxpropCount++;
                }

                if (exchangeEnableMailboxdisplayName != null)
                {
                    exchangeEnableMailbox["DisplayName"] = ExpressionConverter.ConvertO(exchangeEnableMailboxdisplayName);
                    exchangeEnableMailboxpropCount++;
                }

                if (exchangeEnableMailboxlinkedDomainController != null)
                {
                    exchangeEnableMailbox["LinkedDomainController"] = ExpressionConverter.ConvertO(exchangeEnableMailboxlinkedDomainController);
                    exchangeEnableMailboxpropCount++;
                }

                if (exchangeEnableMailboxlinkedMasterAccount != null)
                {
                    exchangeEnableMailbox["LinkedMasterAccount"] = ExpressionConverter.ConvertO(exchangeEnableMailboxlinkedMasterAccount);
                    exchangeEnableMailboxpropCount++;
                }

                if (exchangeEnableMailboxdatabase != null)
                {
                    exchangeEnableMailbox["Database"] = ExpressionConverter.ConvertO(exchangeEnableMailboxdatabase);
                    exchangeEnableMailboxpropCount++;
                }

                if (exchangeEnableMailboxprimarySmtpAddress != null)
                {
                    exchangeEnableMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeEnableMailboxprimarySmtpAddress);
                    exchangeEnableMailboxpropCount++;
                }

                if (exchangeEnableMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeEnableMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeEnableMailboxemailAddressPolicyEnabled);
                    exchangeEnableMailboxpropCount++;
                }

                exchangeEnableMailboxpropCount++;
                exchangeEnableMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeEnableMailboxworkflow);
                if (exchangeEnableMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeEnableMailbox;
                }

                return new ApiConnectionAction<ExchangeEnableMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeEnableRemoteMailbox))]
        public IBodyWorkflowAction<ExchangeEnableRemoteMailboxResponse> ExchangeEnableRemoteMailbox([WorkflowExpression] Func<string> exchangeEnableRemoteMailboxidentity, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxworkflow, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxalias = null, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxremoteRoutingAddress = null, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeEnableRemoteMailboxarchive = null, [WorkflowExpression] Func<bool> exchangeEnableRemoteMailboxemailAddressPolicyEnabled = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeEnableRemoteMailboxResponse> __BuildExchangeEnableRemoteMailbox(WorkflowValue<string> exchangeEnableRemoteMailboxidentity, WorkflowValue<string> exchangeEnableRemoteMailboxworkflow, WorkflowValue<string> exchangeEnableRemoteMailboxalias = null, WorkflowValue<string> exchangeEnableRemoteMailboxdisplayName = null, WorkflowValue<string> exchangeEnableRemoteMailboxremoteRoutingAddress = null, WorkflowValue<string> exchangeEnableRemoteMailboxprimarySmtpAddress = null, WorkflowValue<bool> exchangeEnableRemoteMailboxarchive = null, WorkflowValue<bool> exchangeEnableRemoteMailboxemailAddressPolicyEnabled = null)
        {
            WorkflowValue.Validate(exchangeEnableRemoteMailboxidentity, nameof(exchangeEnableRemoteMailboxidentity), required: true);
            WorkflowValue.Validate(exchangeEnableRemoteMailboxworkflow, nameof(exchangeEnableRemoteMailboxworkflow), required: true);
            WorkflowValue.Validate(exchangeEnableRemoteMailboxalias, nameof(exchangeEnableRemoteMailboxalias), required: false);
            WorkflowValue.Validate(exchangeEnableRemoteMailboxdisplayName, nameof(exchangeEnableRemoteMailboxdisplayName), required: false);
            WorkflowValue.Validate(exchangeEnableRemoteMailboxremoteRoutingAddress, nameof(exchangeEnableRemoteMailboxremoteRoutingAddress), required: false);
            WorkflowValue.Validate(exchangeEnableRemoteMailboxprimarySmtpAddress, nameof(exchangeEnableRemoteMailboxprimarySmtpAddress), required: false);
            WorkflowValue.Validate(exchangeEnableRemoteMailboxarchive, nameof(exchangeEnableRemoteMailboxarchive), required: false);
            WorkflowValue.Validate(exchangeEnableRemoteMailboxemailAddressPolicyEnabled, nameof(exchangeEnableRemoteMailboxemailAddressPolicyEnabled), required: false);
            return new DeferredBodyAction<ExchangeEnableRemoteMailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeEnableRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeEnableRemoteMailbox = new JObject();
                var exchangeEnableRemoteMailboxpropCount = 0;
                exchangeEnableRemoteMailboxpropCount++;
                exchangeEnableRemoteMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxidentity);
                if (exchangeEnableRemoteMailboxalias != null)
                {
                    exchangeEnableRemoteMailbox["Alias"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxalias);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                if (exchangeEnableRemoteMailboxdisplayName != null)
                {
                    exchangeEnableRemoteMailbox["DisplayName"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxdisplayName);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                if (exchangeEnableRemoteMailboxremoteRoutingAddress != null)
                {
                    exchangeEnableRemoteMailbox["RemoteRoutingAddress"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxremoteRoutingAddress);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                if (exchangeEnableRemoteMailboxprimarySmtpAddress != null)
                {
                    exchangeEnableRemoteMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxprimarySmtpAddress);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                if (exchangeEnableRemoteMailboxarchive != null)
                {
                    if (exchangeEnableRemoteMailboxarchive != null)
                    {
                        exchangeEnableRemoteMailbox["Archive"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxarchive);
                        exchangeEnableRemoteMailboxpropCount++;
                    }

                    exchangeEnableRemoteMailboxpropCount++;
                }
                else
                {
                    exchangeEnableRemoteMailbox["Archive"] = false;
                    exchangeEnableRemoteMailboxpropCount++;
                }

                if (exchangeEnableRemoteMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeEnableRemoteMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxemailAddressPolicyEnabled);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                exchangeEnableRemoteMailboxpropCount++;
                exchangeEnableRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxworkflow);
                if (exchangeEnableRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeEnableRemoteMailbox;
                }

                return new ApiConnectionAction<ExchangeEnableRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeGetRemoteMailbox))]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxResponse> ExchangeGetRemoteMailbox([WorkflowExpression] Func<string> exchangeGetRemoteMailboxworkflow, [WorkflowExpression] Func<string> exchangeGetRemoteMailboxidentity = null, [WorkflowExpression] Func<string> exchangeGetRemoteMailboxfilterPropertyName = null, [WorkflowExpression] Func<exchangeGetRemoteMailboxfilterPropertyComparisonInput> exchangeGetRemoteMailboxfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeGetRemoteMailboxfilterPropertyValue = null, [WorkflowExpression] Func<bool> exchangeGetRemoteMailboxnoResultIsAnException = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxResponse> __BuildExchangeGetRemoteMailbox(WorkflowValue<string> exchangeGetRemoteMailboxworkflow, WorkflowValue<string> exchangeGetRemoteMailboxidentity = null, WorkflowValue<string> exchangeGetRemoteMailboxfilterPropertyName = null, WorkflowValue<exchangeGetRemoteMailboxfilterPropertyComparisonInput> exchangeGetRemoteMailboxfilterPropertyComparison = null, WorkflowValue<string> exchangeGetRemoteMailboxfilterPropertyValue = null, WorkflowValue<bool> exchangeGetRemoteMailboxnoResultIsAnException = null)
        {
            WorkflowValue.Validate(exchangeGetRemoteMailboxworkflow, nameof(exchangeGetRemoteMailboxworkflow), required: true);
            WorkflowValue.Validate(exchangeGetRemoteMailboxidentity, nameof(exchangeGetRemoteMailboxidentity), required: false);
            WorkflowValue.Validate(exchangeGetRemoteMailboxfilterPropertyName, nameof(exchangeGetRemoteMailboxfilterPropertyName), required: false);
            WorkflowValue.Validate(exchangeGetRemoteMailboxfilterPropertyComparison, nameof(exchangeGetRemoteMailboxfilterPropertyComparison), required: false);
            WorkflowValue.Validate(exchangeGetRemoteMailboxfilterPropertyValue, nameof(exchangeGetRemoteMailboxfilterPropertyValue), required: false);
            WorkflowValue.Validate(exchangeGetRemoteMailboxnoResultIsAnException, nameof(exchangeGetRemoteMailboxnoResultIsAnException), required: false);
            return new DeferredBodyAction<ExchangeGetRemoteMailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetRemoteMailbox = new JObject();
                var exchangeGetRemoteMailboxpropCount = 0;
                if (exchangeGetRemoteMailboxidentity != null)
                {
                    exchangeGetRemoteMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxidentity);
                    exchangeGetRemoteMailboxpropCount++;
                }

                if (exchangeGetRemoteMailboxfilterPropertyName != null)
                {
                    exchangeGetRemoteMailbox["FilterPropertyName"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxfilterPropertyName);
                    exchangeGetRemoteMailboxpropCount++;
                }

                if (exchangeGetRemoteMailboxfilterPropertyComparison != null)
                {
                    if (exchangeGetRemoteMailboxfilterPropertyComparison != null)
                    {
                        exchangeGetRemoteMailbox["FilterPropertyComparison"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxfilterPropertyComparison);
                        exchangeGetRemoteMailboxpropCount++;
                    }

                    exchangeGetRemoteMailboxpropCount++;
                }
                else
                {
                    exchangeGetRemoteMailbox["FilterPropertyComparison"] = "Equals";
                    exchangeGetRemoteMailboxpropCount++;
                }

                if (exchangeGetRemoteMailboxfilterPropertyValue != null)
                {
                    exchangeGetRemoteMailbox["FilterPropertyValue"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxfilterPropertyValue);
                    exchangeGetRemoteMailboxpropCount++;
                }

                if (exchangeGetRemoteMailboxnoResultIsAnException != null)
                {
                    if (exchangeGetRemoteMailboxnoResultIsAnException != null)
                    {
                        exchangeGetRemoteMailbox["NoResultIsAnException"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxnoResultIsAnException);
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
                exchangeGetRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxworkflow);
                if (exchangeGetRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeGetRemoteMailbox;
                }

                return new ApiConnectionAction<ExchangeGetRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeDoesRemoteMailboxExist))]
        public IBodyWorkflowAction<ExchangeDoesRemoteMailboxExistResponse> ExchangeDoesRemoteMailboxExist([WorkflowExpression] Func<string> exchangeDoesRemoteMailboxExistworkflow, [WorkflowExpression] Func<string> exchangeDoesRemoteMailboxExistidentity = null, [WorkflowExpression] Func<string> exchangeDoesRemoteMailboxExistfilterPropertyName = null, [WorkflowExpression] Func<exchangeDoesRemoteMailboxExistfilterPropertyComparisonInput> exchangeDoesRemoteMailboxExistfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeDoesRemoteMailboxExistfilterPropertyValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeDoesRemoteMailboxExistResponse> __BuildExchangeDoesRemoteMailboxExist(WorkflowValue<string> exchangeDoesRemoteMailboxExistworkflow, WorkflowValue<string> exchangeDoesRemoteMailboxExistidentity = null, WorkflowValue<string> exchangeDoesRemoteMailboxExistfilterPropertyName = null, WorkflowValue<exchangeDoesRemoteMailboxExistfilterPropertyComparisonInput> exchangeDoesRemoteMailboxExistfilterPropertyComparison = null, WorkflowValue<string> exchangeDoesRemoteMailboxExistfilterPropertyValue = null)
        {
            WorkflowValue.Validate(exchangeDoesRemoteMailboxExistworkflow, nameof(exchangeDoesRemoteMailboxExistworkflow), required: true);
            WorkflowValue.Validate(exchangeDoesRemoteMailboxExistidentity, nameof(exchangeDoesRemoteMailboxExistidentity), required: false);
            WorkflowValue.Validate(exchangeDoesRemoteMailboxExistfilterPropertyName, nameof(exchangeDoesRemoteMailboxExistfilterPropertyName), required: false);
            WorkflowValue.Validate(exchangeDoesRemoteMailboxExistfilterPropertyComparison, nameof(exchangeDoesRemoteMailboxExistfilterPropertyComparison), required: false);
            WorkflowValue.Validate(exchangeDoesRemoteMailboxExistfilterPropertyValue, nameof(exchangeDoesRemoteMailboxExistfilterPropertyValue), required: false);
            return new DeferredBodyAction<ExchangeDoesRemoteMailboxExistResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDoesRemoteMailboxExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeDoesRemoteMailboxExist = new JObject();
                var exchangeDoesRemoteMailboxExistpropCount = 0;
                if (exchangeDoesRemoteMailboxExistidentity != null)
                {
                    exchangeDoesRemoteMailboxExist["Identity"] = ExpressionConverter.ConvertO(exchangeDoesRemoteMailboxExistidentity);
                    exchangeDoesRemoteMailboxExistpropCount++;
                }

                if (exchangeDoesRemoteMailboxExistfilterPropertyName != null)
                {
                    exchangeDoesRemoteMailboxExist["FilterPropertyName"] = ExpressionConverter.ConvertO(exchangeDoesRemoteMailboxExistfilterPropertyName);
                    exchangeDoesRemoteMailboxExistpropCount++;
                }

                if (exchangeDoesRemoteMailboxExistfilterPropertyComparison != null)
                {
                    if (exchangeDoesRemoteMailboxExistfilterPropertyComparison != null)
                    {
                        exchangeDoesRemoteMailboxExist["FilterPropertyComparison"] = ExpressionConverter.ConvertO(exchangeDoesRemoteMailboxExistfilterPropertyComparison);
                        exchangeDoesRemoteMailboxExistpropCount++;
                    }

                    exchangeDoesRemoteMailboxExistpropCount++;
                }
                else
                {
                    exchangeDoesRemoteMailboxExist["FilterPropertyComparison"] = "Equals";
                    exchangeDoesRemoteMailboxExistpropCount++;
                }

                if (exchangeDoesRemoteMailboxExistfilterPropertyValue != null)
                {
                    exchangeDoesRemoteMailboxExist["FilterPropertyValue"] = ExpressionConverter.ConvertO(exchangeDoesRemoteMailboxExistfilterPropertyValue);
                    exchangeDoesRemoteMailboxExistpropCount++;
                }

                exchangeDoesRemoteMailboxExistpropCount++;
                exchangeDoesRemoteMailboxExist["Workflow"] = ExpressionConverter.ConvertO(exchangeDoesRemoteMailboxExistworkflow);
                if (exchangeDoesRemoteMailboxExistpropCount > 0)
                {
                    callPayload.Body = exchangeDoesRemoteMailboxExist;
                }

                return new ApiConnectionAction<ExchangeDoesRemoteMailboxExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeNewMailbox))]
        public IBodyWorkflowAction<ExchangeNewMailboxResponse> ExchangeNewMailbox([WorkflowExpression] Func<string> exchangeNewMailboxname, [WorkflowExpression] Func<string> exchangeNewMailboxuserPrincipalName, [WorkflowExpression] Func<string> exchangeNewMailboxworkflow, [WorkflowExpression] Func<string> exchangeNewMailboxfirstName = null, [WorkflowExpression] Func<string> exchangeNewMailboxlastName = null, [WorkflowExpression] Func<string> exchangeNewMailboxorganizationalUnit = null, [WorkflowExpression] Func<string> exchangeNewMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeNewMailboxalias = null, [WorkflowExpression] Func<string> exchangeNewMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<string> exchangeNewMailboxsamAccountName = null, [WorkflowExpression] Func<string> exchangeNewMailboxpassword = null, [WorkflowExpression] Func<bool> exchangeNewMailboxaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> exchangeNewMailboxresetPasswordOnNextLogon = null, [WorkflowExpression] Func<string> exchangeNewMailboxdatabase = null, [WorkflowExpression] Func<bool> exchangeNewMailboxsharedMailbox = null, [WorkflowExpression] Func<bool> exchangeNewMailboxemailAddressPolicyEnabled = null, [WorkflowExpression] Func<bool> exchangeNewMailboxarchive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeNewMailboxResponse> __BuildExchangeNewMailbox(WorkflowValue<string> exchangeNewMailboxname, WorkflowValue<string> exchangeNewMailboxuserPrincipalName, WorkflowValue<string> exchangeNewMailboxworkflow, WorkflowValue<string> exchangeNewMailboxfirstName = null, WorkflowValue<string> exchangeNewMailboxlastName = null, WorkflowValue<string> exchangeNewMailboxorganizationalUnit = null, WorkflowValue<string> exchangeNewMailboxdisplayName = null, WorkflowValue<string> exchangeNewMailboxalias = null, WorkflowValue<string> exchangeNewMailboxprimarySmtpAddress = null, WorkflowValue<string> exchangeNewMailboxsamAccountName = null, WorkflowValue<string> exchangeNewMailboxpassword = null, WorkflowValue<bool> exchangeNewMailboxaccountPasswordIsStoredPassword = null, WorkflowValue<bool> exchangeNewMailboxresetPasswordOnNextLogon = null, WorkflowValue<string> exchangeNewMailboxdatabase = null, WorkflowValue<bool> exchangeNewMailboxsharedMailbox = null, WorkflowValue<bool> exchangeNewMailboxemailAddressPolicyEnabled = null, WorkflowValue<bool> exchangeNewMailboxarchive = null)
        {
            WorkflowValue.Validate(exchangeNewMailboxname, nameof(exchangeNewMailboxname), required: true);
            WorkflowValue.Validate(exchangeNewMailboxuserPrincipalName, nameof(exchangeNewMailboxuserPrincipalName), required: true);
            WorkflowValue.Validate(exchangeNewMailboxworkflow, nameof(exchangeNewMailboxworkflow), required: true);
            WorkflowValue.Validate(exchangeNewMailboxfirstName, nameof(exchangeNewMailboxfirstName), required: false);
            WorkflowValue.Validate(exchangeNewMailboxlastName, nameof(exchangeNewMailboxlastName), required: false);
            WorkflowValue.Validate(exchangeNewMailboxorganizationalUnit, nameof(exchangeNewMailboxorganizationalUnit), required: false);
            WorkflowValue.Validate(exchangeNewMailboxdisplayName, nameof(exchangeNewMailboxdisplayName), required: false);
            WorkflowValue.Validate(exchangeNewMailboxalias, nameof(exchangeNewMailboxalias), required: false);
            WorkflowValue.Validate(exchangeNewMailboxprimarySmtpAddress, nameof(exchangeNewMailboxprimarySmtpAddress), required: false);
            WorkflowValue.Validate(exchangeNewMailboxsamAccountName, nameof(exchangeNewMailboxsamAccountName), required: false);
            WorkflowValue.Validate(exchangeNewMailboxpassword, nameof(exchangeNewMailboxpassword), required: false);
            WorkflowValue.Validate(exchangeNewMailboxaccountPasswordIsStoredPassword, nameof(exchangeNewMailboxaccountPasswordIsStoredPassword), required: false);
            WorkflowValue.Validate(exchangeNewMailboxresetPasswordOnNextLogon, nameof(exchangeNewMailboxresetPasswordOnNextLogon), required: false);
            WorkflowValue.Validate(exchangeNewMailboxdatabase, nameof(exchangeNewMailboxdatabase), required: false);
            WorkflowValue.Validate(exchangeNewMailboxsharedMailbox, nameof(exchangeNewMailboxsharedMailbox), required: false);
            WorkflowValue.Validate(exchangeNewMailboxemailAddressPolicyEnabled, nameof(exchangeNewMailboxemailAddressPolicyEnabled), required: false);
            WorkflowValue.Validate(exchangeNewMailboxarchive, nameof(exchangeNewMailboxarchive), required: false);
            return new DeferredBodyAction<ExchangeNewMailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeNewMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeNewMailbox = new JObject();
                var exchangeNewMailboxpropCount = 0;
                if (exchangeNewMailboxfirstName != null)
                {
                    exchangeNewMailbox["FirstName"] = ExpressionConverter.ConvertO(exchangeNewMailboxfirstName);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxlastName != null)
                {
                    exchangeNewMailbox["LastName"] = ExpressionConverter.ConvertO(exchangeNewMailboxlastName);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxorganizationalUnit != null)
                {
                    exchangeNewMailbox["OrganizationalUnit"] = ExpressionConverter.ConvertO(exchangeNewMailboxorganizationalUnit);
                    exchangeNewMailboxpropCount++;
                }

                exchangeNewMailboxpropCount++;
                exchangeNewMailbox["Name"] = ExpressionConverter.ConvertO(exchangeNewMailboxname);
                if (exchangeNewMailboxdisplayName != null)
                {
                    exchangeNewMailbox["DisplayName"] = ExpressionConverter.ConvertO(exchangeNewMailboxdisplayName);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxalias != null)
                {
                    exchangeNewMailbox["Alias"] = ExpressionConverter.ConvertO(exchangeNewMailboxalias);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxprimarySmtpAddress != null)
                {
                    exchangeNewMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeNewMailboxprimarySmtpAddress);
                    exchangeNewMailboxpropCount++;
                }

                exchangeNewMailboxpropCount++;
                exchangeNewMailbox["UserPrincipalName"] = ExpressionConverter.ConvertO(exchangeNewMailboxuserPrincipalName);
                if (exchangeNewMailboxsamAccountName != null)
                {
                    exchangeNewMailbox["SamAccountName"] = ExpressionConverter.ConvertO(exchangeNewMailboxsamAccountName);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxpassword != null)
                {
                    exchangeNewMailbox["Password"] = ExpressionConverter.ConvertO(exchangeNewMailboxpassword);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxaccountPasswordIsStoredPassword != null)
                {
                    if (exchangeNewMailboxaccountPasswordIsStoredPassword != null)
                    {
                        exchangeNewMailbox["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(exchangeNewMailboxaccountPasswordIsStoredPassword);
                        exchangeNewMailboxpropCount++;
                    }

                    exchangeNewMailboxpropCount++;
                }
                else
                {
                    exchangeNewMailbox["AccountPasswordIsStoredPassword"] = false;
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxresetPasswordOnNextLogon != null)
                {
                    if (exchangeNewMailboxresetPasswordOnNextLogon != null)
                    {
                        exchangeNewMailbox["ResetPasswordOnNextLogon"] = ExpressionConverter.ConvertO(exchangeNewMailboxresetPasswordOnNextLogon);
                        exchangeNewMailboxpropCount++;
                    }

                    exchangeNewMailboxpropCount++;
                }
                else
                {
                    exchangeNewMailbox["ResetPasswordOnNextLogon"] = true;
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxdatabase != null)
                {
                    exchangeNewMailbox["Database"] = ExpressionConverter.ConvertO(exchangeNewMailboxdatabase);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxsharedMailbox != null)
                {
                    if (exchangeNewMailboxsharedMailbox != null)
                    {
                        exchangeNewMailbox["SharedMailbox"] = ExpressionConverter.ConvertO(exchangeNewMailboxsharedMailbox);
                        exchangeNewMailboxpropCount++;
                    }

                    exchangeNewMailboxpropCount++;
                }
                else
                {
                    exchangeNewMailbox["SharedMailbox"] = false;
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeNewMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeNewMailboxemailAddressPolicyEnabled);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxarchive != null)
                {
                    if (exchangeNewMailboxarchive != null)
                    {
                        exchangeNewMailbox["Archive"] = ExpressionConverter.ConvertO(exchangeNewMailboxarchive);
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
                exchangeNewMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeNewMailboxworkflow);
                if (exchangeNewMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeNewMailbox;
                }

                return new ApiConnectionAction<ExchangeNewMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeNewRemoteMailbox))]
        public IBodyWorkflowAction<ExchangeNewRemoteMailboxResponse> ExchangeNewRemoteMailbox([WorkflowExpression] Func<string> exchangeNewRemoteMailboxname, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxuserPrincipalName, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxworkflow, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxfirstName = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxlastName = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxonPremisesOrganizationalUnit = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxremoteRoutingAddress = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxalias = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxsamAccountName = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxpassword = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxresetPasswordOnNextLogon = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxsharedMailbox = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxemailAddressPolicyEnabled = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxarchive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeNewRemoteMailboxResponse> __BuildExchangeNewRemoteMailbox(WorkflowValue<string> exchangeNewRemoteMailboxname, WorkflowValue<string> exchangeNewRemoteMailboxuserPrincipalName, WorkflowValue<string> exchangeNewRemoteMailboxworkflow, WorkflowValue<string> exchangeNewRemoteMailboxfirstName = null, WorkflowValue<string> exchangeNewRemoteMailboxlastName = null, WorkflowValue<string> exchangeNewRemoteMailboxonPremisesOrganizationalUnit = null, WorkflowValue<string> exchangeNewRemoteMailboxdisplayName = null, WorkflowValue<string> exchangeNewRemoteMailboxremoteRoutingAddress = null, WorkflowValue<string> exchangeNewRemoteMailboxalias = null, WorkflowValue<string> exchangeNewRemoteMailboxprimarySmtpAddress = null, WorkflowValue<string> exchangeNewRemoteMailboxsamAccountName = null, WorkflowValue<string> exchangeNewRemoteMailboxpassword = null, WorkflowValue<bool> exchangeNewRemoteMailboxaccountPasswordIsStoredPassword = null, WorkflowValue<bool> exchangeNewRemoteMailboxresetPasswordOnNextLogon = null, WorkflowValue<bool> exchangeNewRemoteMailboxsharedMailbox = null, WorkflowValue<bool> exchangeNewRemoteMailboxemailAddressPolicyEnabled = null, WorkflowValue<bool> exchangeNewRemoteMailboxarchive = null)
        {
            WorkflowValue.Validate(exchangeNewRemoteMailboxname, nameof(exchangeNewRemoteMailboxname), required: true);
            WorkflowValue.Validate(exchangeNewRemoteMailboxuserPrincipalName, nameof(exchangeNewRemoteMailboxuserPrincipalName), required: true);
            WorkflowValue.Validate(exchangeNewRemoteMailboxworkflow, nameof(exchangeNewRemoteMailboxworkflow), required: true);
            WorkflowValue.Validate(exchangeNewRemoteMailboxfirstName, nameof(exchangeNewRemoteMailboxfirstName), required: false);
            WorkflowValue.Validate(exchangeNewRemoteMailboxlastName, nameof(exchangeNewRemoteMailboxlastName), required: false);
            WorkflowValue.Validate(exchangeNewRemoteMailboxonPremisesOrganizationalUnit, nameof(exchangeNewRemoteMailboxonPremisesOrganizationalUnit), required: false);
            WorkflowValue.Validate(exchangeNewRemoteMailboxdisplayName, nameof(exchangeNewRemoteMailboxdisplayName), required: false);
            WorkflowValue.Validate(exchangeNewRemoteMailboxremoteRoutingAddress, nameof(exchangeNewRemoteMailboxremoteRoutingAddress), required: false);
            WorkflowValue.Validate(exchangeNewRemoteMailboxalias, nameof(exchangeNewRemoteMailboxalias), required: false);
            WorkflowValue.Validate(exchangeNewRemoteMailboxprimarySmtpAddress, nameof(exchangeNewRemoteMailboxprimarySmtpAddress), required: false);
            WorkflowValue.Validate(exchangeNewRemoteMailboxsamAccountName, nameof(exchangeNewRemoteMailboxsamAccountName), required: false);
            WorkflowValue.Validate(exchangeNewRemoteMailboxpassword, nameof(exchangeNewRemoteMailboxpassword), required: false);
            WorkflowValue.Validate(exchangeNewRemoteMailboxaccountPasswordIsStoredPassword, nameof(exchangeNewRemoteMailboxaccountPasswordIsStoredPassword), required: false);
            WorkflowValue.Validate(exchangeNewRemoteMailboxresetPasswordOnNextLogon, nameof(exchangeNewRemoteMailboxresetPasswordOnNextLogon), required: false);
            WorkflowValue.Validate(exchangeNewRemoteMailboxsharedMailbox, nameof(exchangeNewRemoteMailboxsharedMailbox), required: false);
            WorkflowValue.Validate(exchangeNewRemoteMailboxemailAddressPolicyEnabled, nameof(exchangeNewRemoteMailboxemailAddressPolicyEnabled), required: false);
            WorkflowValue.Validate(exchangeNewRemoteMailboxarchive, nameof(exchangeNewRemoteMailboxarchive), required: false);
            return new DeferredBodyAction<ExchangeNewRemoteMailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeNewRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeNewRemoteMailbox = new JObject();
                var exchangeNewRemoteMailboxpropCount = 0;
                if (exchangeNewRemoteMailboxfirstName != null)
                {
                    exchangeNewRemoteMailbox["FirstName"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxfirstName);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxlastName != null)
                {
                    exchangeNewRemoteMailbox["LastName"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxlastName);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxonPremisesOrganizationalUnit != null)
                {
                    exchangeNewRemoteMailbox["OnPremisesOrganizationalUnit"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxonPremisesOrganizationalUnit);
                    exchangeNewRemoteMailboxpropCount++;
                }

                exchangeNewRemoteMailboxpropCount++;
                exchangeNewRemoteMailbox["Name"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxname);
                if (exchangeNewRemoteMailboxdisplayName != null)
                {
                    exchangeNewRemoteMailbox["DisplayName"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxdisplayName);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxremoteRoutingAddress != null)
                {
                    exchangeNewRemoteMailbox["RemoteRoutingAddress"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxremoteRoutingAddress);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxalias != null)
                {
                    exchangeNewRemoteMailbox["Alias"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxalias);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxprimarySmtpAddress != null)
                {
                    exchangeNewRemoteMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxprimarySmtpAddress);
                    exchangeNewRemoteMailboxpropCount++;
                }

                exchangeNewRemoteMailboxpropCount++;
                exchangeNewRemoteMailbox["UserPrincipalName"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxuserPrincipalName);
                if (exchangeNewRemoteMailboxsamAccountName != null)
                {
                    exchangeNewRemoteMailbox["SamAccountName"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxsamAccountName);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxpassword != null)
                {
                    exchangeNewRemoteMailbox["Password"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxpassword);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxaccountPasswordIsStoredPassword != null)
                {
                    if (exchangeNewRemoteMailboxaccountPasswordIsStoredPassword != null)
                    {
                        exchangeNewRemoteMailbox["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxaccountPasswordIsStoredPassword);
                        exchangeNewRemoteMailboxpropCount++;
                    }

                    exchangeNewRemoteMailboxpropCount++;
                }
                else
                {
                    exchangeNewRemoteMailbox["AccountPasswordIsStoredPassword"] = false;
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxresetPasswordOnNextLogon != null)
                {
                    if (exchangeNewRemoteMailboxresetPasswordOnNextLogon != null)
                    {
                        exchangeNewRemoteMailbox["ResetPasswordOnNextLogon"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxresetPasswordOnNextLogon);
                        exchangeNewRemoteMailboxpropCount++;
                    }

                    exchangeNewRemoteMailboxpropCount++;
                }
                else
                {
                    exchangeNewRemoteMailbox["ResetPasswordOnNextLogon"] = true;
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxsharedMailbox != null)
                {
                    if (exchangeNewRemoteMailboxsharedMailbox != null)
                    {
                        exchangeNewRemoteMailbox["SharedMailbox"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxsharedMailbox);
                        exchangeNewRemoteMailboxpropCount++;
                    }

                    exchangeNewRemoteMailboxpropCount++;
                }
                else
                {
                    exchangeNewRemoteMailbox["SharedMailbox"] = false;
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeNewRemoteMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxemailAddressPolicyEnabled);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxarchive != null)
                {
                    if (exchangeNewRemoteMailboxarchive != null)
                    {
                        exchangeNewRemoteMailbox["Archive"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxarchive);
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
                exchangeNewRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxworkflow);
                if (exchangeNewRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeNewRemoteMailbox;
                }

                return new ApiConnectionAction<ExchangeNewRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeSetADServerToViewEntireForest))]
        public IBodyWorkflowAction<ExchangeSetADServerToViewEntireForestResponse> ExchangeSetADServerToViewEntireForest([WorkflowExpression] Func<bool> exchangeSetADServerToViewEntireForestviewEntireForest, [WorkflowExpression] Func<string> exchangeSetADServerToViewEntireForestworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeSetADServerToViewEntireForestResponse> __BuildExchangeSetADServerToViewEntireForest(WorkflowValue<bool> exchangeSetADServerToViewEntireForestviewEntireForest, WorkflowValue<string> exchangeSetADServerToViewEntireForestworkflow)
        {
            WorkflowValue.Validate(exchangeSetADServerToViewEntireForestviewEntireForest, nameof(exchangeSetADServerToViewEntireForestviewEntireForest), required: true);
            WorkflowValue.Validate(exchangeSetADServerToViewEntireForestworkflow, nameof(exchangeSetADServerToViewEntireForestworkflow), required: true);
            return new DeferredBodyAction<ExchangeSetADServerToViewEntireForestResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetADServerToViewEntireForest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetADServerToViewEntireForest = new JObject();
                var exchangeSetADServerToViewEntireForestpropCount = 0;
                exchangeSetADServerToViewEntireForestpropCount++;
                exchangeSetADServerToViewEntireForest["ViewEntireForest"] = ExpressionConverter.ConvertO(exchangeSetADServerToViewEntireForestviewEntireForest);
                exchangeSetADServerToViewEntireForestpropCount++;
                exchangeSetADServerToViewEntireForest["Workflow"] = ExpressionConverter.ConvertO(exchangeSetADServerToViewEntireForestworkflow);
                if (exchangeSetADServerToViewEntireForestpropCount > 0)
                {
                    callPayload.Body = exchangeSetADServerToViewEntireForest;
                }

                return new ApiConnectionAction<ExchangeSetADServerToViewEntireForestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeSetMailbox))]
        public IBodyWorkflowAction<ExchangeSetMailboxResponse> ExchangeSetMailbox([WorkflowExpression] Func<string> exchangeSetMailboxidentity, [WorkflowExpression] Func<string> exchangeSetMailboxworkflow, [WorkflowExpression] Func<bool> exchangeSetMailboxaccountDisabled = null, [WorkflowExpression] Func<string> exchangeSetMailboxalias = null, [WorkflowExpression] Func<string> exchangeSetMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeSetMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeSetMailboxhiddenFromAddressListsEnabled = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute1 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute2 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute3 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute4 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute5 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute6 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute7 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute8 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute9 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute10 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute11 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute12 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute13 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute14 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute15 = null, [WorkflowExpression] Func<bool> exchangeSetMailboxemailAddressPolicyEnabled = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeSetMailboxResponse> __BuildExchangeSetMailbox(WorkflowValue<string> exchangeSetMailboxidentity, WorkflowValue<string> exchangeSetMailboxworkflow, WorkflowValue<bool> exchangeSetMailboxaccountDisabled = null, WorkflowValue<string> exchangeSetMailboxalias = null, WorkflowValue<string> exchangeSetMailboxdisplayName = null, WorkflowValue<string> exchangeSetMailboxprimarySmtpAddress = null, WorkflowValue<bool> exchangeSetMailboxhiddenFromAddressListsEnabled = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute1 = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute2 = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute3 = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute4 = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute5 = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute6 = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute7 = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute8 = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute9 = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute10 = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute11 = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute12 = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute13 = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute14 = null, WorkflowValue<string> exchangeSetMailboxcustomAttribute15 = null, WorkflowValue<bool> exchangeSetMailboxemailAddressPolicyEnabled = null)
        {
            WorkflowValue.Validate(exchangeSetMailboxidentity, nameof(exchangeSetMailboxidentity), required: true);
            WorkflowValue.Validate(exchangeSetMailboxworkflow, nameof(exchangeSetMailboxworkflow), required: true);
            WorkflowValue.Validate(exchangeSetMailboxaccountDisabled, nameof(exchangeSetMailboxaccountDisabled), required: false);
            WorkflowValue.Validate(exchangeSetMailboxalias, nameof(exchangeSetMailboxalias), required: false);
            WorkflowValue.Validate(exchangeSetMailboxdisplayName, nameof(exchangeSetMailboxdisplayName), required: false);
            WorkflowValue.Validate(exchangeSetMailboxprimarySmtpAddress, nameof(exchangeSetMailboxprimarySmtpAddress), required: false);
            WorkflowValue.Validate(exchangeSetMailboxhiddenFromAddressListsEnabled, nameof(exchangeSetMailboxhiddenFromAddressListsEnabled), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute1, nameof(exchangeSetMailboxcustomAttribute1), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute2, nameof(exchangeSetMailboxcustomAttribute2), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute3, nameof(exchangeSetMailboxcustomAttribute3), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute4, nameof(exchangeSetMailboxcustomAttribute4), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute5, nameof(exchangeSetMailboxcustomAttribute5), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute6, nameof(exchangeSetMailboxcustomAttribute6), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute7, nameof(exchangeSetMailboxcustomAttribute7), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute8, nameof(exchangeSetMailboxcustomAttribute8), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute9, nameof(exchangeSetMailboxcustomAttribute9), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute10, nameof(exchangeSetMailboxcustomAttribute10), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute11, nameof(exchangeSetMailboxcustomAttribute11), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute12, nameof(exchangeSetMailboxcustomAttribute12), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute13, nameof(exchangeSetMailboxcustomAttribute13), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute14, nameof(exchangeSetMailboxcustomAttribute14), required: false);
            WorkflowValue.Validate(exchangeSetMailboxcustomAttribute15, nameof(exchangeSetMailboxcustomAttribute15), required: false);
            WorkflowValue.Validate(exchangeSetMailboxemailAddressPolicyEnabled, nameof(exchangeSetMailboxemailAddressPolicyEnabled), required: false);
            return new DeferredBodyAction<ExchangeSetMailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetMailbox = new JObject();
                var exchangeSetMailboxpropCount = 0;
                exchangeSetMailboxpropCount++;
                exchangeSetMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeSetMailboxidentity);
                if (exchangeSetMailboxaccountDisabled != null)
                {
                    exchangeSetMailbox["AccountDisabled"] = ExpressionConverter.ConvertO(exchangeSetMailboxaccountDisabled);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxalias != null)
                {
                    exchangeSetMailbox["Alias"] = ExpressionConverter.ConvertO(exchangeSetMailboxalias);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxdisplayName != null)
                {
                    exchangeSetMailbox["DisplayName"] = ExpressionConverter.ConvertO(exchangeSetMailboxdisplayName);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxprimarySmtpAddress != null)
                {
                    exchangeSetMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeSetMailboxprimarySmtpAddress);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxhiddenFromAddressListsEnabled != null)
                {
                    exchangeSetMailbox["HiddenFromAddressListsEnabled"] = ExpressionConverter.ConvertO(exchangeSetMailboxhiddenFromAddressListsEnabled);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute1 != null)
                {
                    exchangeSetMailbox["CustomAttribute1"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute1);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute2 != null)
                {
                    exchangeSetMailbox["CustomAttribute2"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute2);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute3 != null)
                {
                    exchangeSetMailbox["CustomAttribute3"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute3);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute4 != null)
                {
                    exchangeSetMailbox["CustomAttribute4"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute4);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute5 != null)
                {
                    exchangeSetMailbox["CustomAttribute5"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute5);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute6 != null)
                {
                    exchangeSetMailbox["CustomAttribute6"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute6);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute7 != null)
                {
                    exchangeSetMailbox["CustomAttribute7"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute7);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute8 != null)
                {
                    exchangeSetMailbox["CustomAttribute8"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute8);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute9 != null)
                {
                    exchangeSetMailbox["CustomAttribute9"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute9);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute10 != null)
                {
                    exchangeSetMailbox["CustomAttribute10"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute10);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute11 != null)
                {
                    exchangeSetMailbox["CustomAttribute11"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute11);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute12 != null)
                {
                    exchangeSetMailbox["CustomAttribute12"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute12);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute13 != null)
                {
                    exchangeSetMailbox["CustomAttribute13"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute13);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute14 != null)
                {
                    exchangeSetMailbox["CustomAttribute14"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute14);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute15 != null)
                {
                    exchangeSetMailbox["CustomAttribute15"] = ExpressionConverter.ConvertO(exchangeSetMailboxcustomAttribute15);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeSetMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeSetMailboxemailAddressPolicyEnabled);
                    exchangeSetMailboxpropCount++;
                }

                exchangeSetMailboxpropCount++;
                exchangeSetMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeSetMailboxworkflow);
                if (exchangeSetMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeSetMailbox;
                }

                return new ApiConnectionAction<ExchangeSetMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeSetMailboxEmailAddresses))]
        public IBodyWorkflowAction<ExchangeSetMailboxEmailAddressesResponse> ExchangeSetMailboxEmailAddresses([WorkflowExpression] Func<string> exchangeSetMailboxEmailAddressesidentity, [WorkflowExpression] Func<string> exchangeSetMailboxEmailAddressesworkflow, [WorkflowExpression] Func<string> exchangeSetMailboxEmailAddressesalias = null, [WorkflowExpression] Func<string> exchangeSetMailboxEmailAddressesprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled = null, [WorkflowExpression] Func<string[]> exchangeSetMailboxEmailAddressesemailAddressesToAddList = null, [WorkflowExpression] Func<bool> exchangeSetMailboxEmailAddressesreplaceEmailAddresses = null, [WorkflowExpression] Func<string[]> exchangeSetMailboxEmailAddressesemailAddressesToRemoveList = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeSetMailboxEmailAddressesResponse> __BuildExchangeSetMailboxEmailAddresses(WorkflowValue<string> exchangeSetMailboxEmailAddressesidentity, WorkflowValue<string> exchangeSetMailboxEmailAddressesworkflow, WorkflowValue<string> exchangeSetMailboxEmailAddressesalias = null, WorkflowValue<string> exchangeSetMailboxEmailAddressesprimarySmtpAddress = null, WorkflowValue<bool> exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled = null, WorkflowValue<string[]> exchangeSetMailboxEmailAddressesemailAddressesToAddList = null, WorkflowValue<bool> exchangeSetMailboxEmailAddressesreplaceEmailAddresses = null, WorkflowValue<string[]> exchangeSetMailboxEmailAddressesemailAddressesToRemoveList = null)
        {
            WorkflowValue.Validate(exchangeSetMailboxEmailAddressesidentity, nameof(exchangeSetMailboxEmailAddressesidentity), required: true);
            WorkflowValue.Validate(exchangeSetMailboxEmailAddressesworkflow, nameof(exchangeSetMailboxEmailAddressesworkflow), required: true);
            WorkflowValue.Validate(exchangeSetMailboxEmailAddressesalias, nameof(exchangeSetMailboxEmailAddressesalias), required: false);
            WorkflowValue.Validate(exchangeSetMailboxEmailAddressesprimarySmtpAddress, nameof(exchangeSetMailboxEmailAddressesprimarySmtpAddress), required: false);
            WorkflowValue.Validate(exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled, nameof(exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled), required: false);
            WorkflowValue.Validate(exchangeSetMailboxEmailAddressesemailAddressesToAddList, nameof(exchangeSetMailboxEmailAddressesemailAddressesToAddList), required: false);
            WorkflowValue.Validate(exchangeSetMailboxEmailAddressesreplaceEmailAddresses, nameof(exchangeSetMailboxEmailAddressesreplaceEmailAddresses), required: false);
            WorkflowValue.Validate(exchangeSetMailboxEmailAddressesemailAddressesToRemoveList, nameof(exchangeSetMailboxEmailAddressesemailAddressesToRemoveList), required: false);
            return new DeferredBodyAction<ExchangeSetMailboxEmailAddressesResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetMailboxEmailAddresses = new JObject();
                var exchangeSetMailboxEmailAddressespropCount = 0;
                exchangeSetMailboxEmailAddressespropCount++;
                exchangeSetMailboxEmailAddresses["Identity"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesidentity);
                if (exchangeSetMailboxEmailAddressesalias != null)
                {
                    exchangeSetMailboxEmailAddresses["Alias"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesalias);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                if (exchangeSetMailboxEmailAddressesprimarySmtpAddress != null)
                {
                    exchangeSetMailboxEmailAddresses["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesprimarySmtpAddress);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                if (exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled != null)
                {
                    exchangeSetMailboxEmailAddresses["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                if (exchangeSetMailboxEmailAddressesemailAddressesToAddList != null)
                {
                    exchangeSetMailboxEmailAddresses["EmailAddressesToAddList"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesemailAddressesToAddList);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                if (exchangeSetMailboxEmailAddressesreplaceEmailAddresses != null)
                {
                    if (exchangeSetMailboxEmailAddressesreplaceEmailAddresses != null)
                    {
                        exchangeSetMailboxEmailAddresses["ReplaceEmailAddresses"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesreplaceEmailAddresses);
                        exchangeSetMailboxEmailAddressespropCount++;
                    }

                    exchangeSetMailboxEmailAddressespropCount++;
                }
                else
                {
                    exchangeSetMailboxEmailAddresses["ReplaceEmailAddresses"] = true;
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                if (exchangeSetMailboxEmailAddressesemailAddressesToRemoveList != null)
                {
                    exchangeSetMailboxEmailAddresses["EmailAddressesToRemoveList"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesemailAddressesToRemoveList);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                exchangeSetMailboxEmailAddressespropCount++;
                exchangeSetMailboxEmailAddresses["Workflow"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesworkflow);
                if (exchangeSetMailboxEmailAddressespropCount > 0)
                {
                    callPayload.Body = exchangeSetMailboxEmailAddresses;
                }

                return new ApiConnectionAction<ExchangeSetMailboxEmailAddressesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeGetMailboxEmailAddresses))]
        public IBodyWorkflowAction<ExchangeGetMailboxEmailAddressesResponse> ExchangeGetMailboxEmailAddresses([WorkflowExpression] Func<string> exchangeGetMailboxEmailAddressesidentity, [WorkflowExpression] Func<string> exchangeGetMailboxEmailAddressesworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeGetMailboxEmailAddressesResponse> __BuildExchangeGetMailboxEmailAddresses(WorkflowValue<string> exchangeGetMailboxEmailAddressesidentity, WorkflowValue<string> exchangeGetMailboxEmailAddressesworkflow)
        {
            WorkflowValue.Validate(exchangeGetMailboxEmailAddressesidentity, nameof(exchangeGetMailboxEmailAddressesidentity), required: true);
            WorkflowValue.Validate(exchangeGetMailboxEmailAddressesworkflow, nameof(exchangeGetMailboxEmailAddressesworkflow), required: true);
            return new DeferredBodyAction<ExchangeGetMailboxEmailAddressesResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetMailboxEmailAddresses = new JObject();
                var exchangeGetMailboxEmailAddressespropCount = 0;
                exchangeGetMailboxEmailAddressespropCount++;
                exchangeGetMailboxEmailAddresses["Identity"] = ExpressionConverter.ConvertO(exchangeGetMailboxEmailAddressesidentity);
                exchangeGetMailboxEmailAddressespropCount++;
                exchangeGetMailboxEmailAddresses["Workflow"] = ExpressionConverter.ConvertO(exchangeGetMailboxEmailAddressesworkflow);
                if (exchangeGetMailboxEmailAddressespropCount > 0)
                {
                    callPayload.Body = exchangeGetMailboxEmailAddresses;
                }

                return new ApiConnectionAction<ExchangeGetMailboxEmailAddressesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeSetRemoteMailboxEmailAddresses))]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxEmailAddressesResponse> ExchangeSetRemoteMailboxEmailAddresses([WorkflowExpression] Func<string> exchangeSetRemoteMailboxEmailAddressesidentity, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxEmailAddressesworkflow, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxEmailAddressesalias = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled = null, [WorkflowExpression] Func<string[]> exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList = null, [WorkflowExpression] Func<bool> exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses = null, [WorkflowExpression] Func<string[]> exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxEmailAddressesResponse> __BuildExchangeSetRemoteMailboxEmailAddresses(WorkflowValue<string> exchangeSetRemoteMailboxEmailAddressesidentity, WorkflowValue<string> exchangeSetRemoteMailboxEmailAddressesworkflow, WorkflowValue<string> exchangeSetRemoteMailboxEmailAddressesalias = null, WorkflowValue<string> exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress = null, WorkflowValue<bool> exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled = null, WorkflowValue<string[]> exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList = null, WorkflowValue<bool> exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses = null, WorkflowValue<string[]> exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList = null)
        {
            WorkflowValue.Validate(exchangeSetRemoteMailboxEmailAddressesidentity, nameof(exchangeSetRemoteMailboxEmailAddressesidentity), required: true);
            WorkflowValue.Validate(exchangeSetRemoteMailboxEmailAddressesworkflow, nameof(exchangeSetRemoteMailboxEmailAddressesworkflow), required: true);
            WorkflowValue.Validate(exchangeSetRemoteMailboxEmailAddressesalias, nameof(exchangeSetRemoteMailboxEmailAddressesalias), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress, nameof(exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled, nameof(exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList, nameof(exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses, nameof(exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList, nameof(exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList), required: false);
            return new DeferredBodyAction<ExchangeSetRemoteMailboxEmailAddressesResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetRemoteMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetRemoteMailboxEmailAddresses = new JObject();
                var exchangeSetRemoteMailboxEmailAddressespropCount = 0;
                exchangeSetRemoteMailboxEmailAddressespropCount++;
                exchangeSetRemoteMailboxEmailAddresses["Identity"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesidentity);
                if (exchangeSetRemoteMailboxEmailAddressesalias != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["Alias"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesalias);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                if (exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                if (exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                if (exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["EmailAddressesToAddList"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                if (exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses != null)
                {
                    if (exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses != null)
                    {
                        exchangeSetRemoteMailboxEmailAddresses["ReplaceEmailAddresses"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses);
                        exchangeSetRemoteMailboxEmailAddressespropCount++;
                    }

                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }
                else
                {
                    exchangeSetRemoteMailboxEmailAddresses["ReplaceEmailAddresses"] = true;
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                if (exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["EmailAddressesToRemoveList"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                exchangeSetRemoteMailboxEmailAddressespropCount++;
                exchangeSetRemoteMailboxEmailAddresses["Workflow"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesworkflow);
                if (exchangeSetRemoteMailboxEmailAddressespropCount > 0)
                {
                    callPayload.Body = exchangeSetRemoteMailboxEmailAddresses;
                }

                return new ApiConnectionAction<ExchangeSetRemoteMailboxEmailAddressesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeGetRemoteMailboxEmailAddresses))]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxEmailAddressesResponse> ExchangeGetRemoteMailboxEmailAddresses([WorkflowExpression] Func<string> exchangeGetRemoteMailboxEmailAddressesidentity, [WorkflowExpression] Func<string> exchangeGetRemoteMailboxEmailAddressesworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxEmailAddressesResponse> __BuildExchangeGetRemoteMailboxEmailAddresses(WorkflowValue<string> exchangeGetRemoteMailboxEmailAddressesidentity, WorkflowValue<string> exchangeGetRemoteMailboxEmailAddressesworkflow)
        {
            WorkflowValue.Validate(exchangeGetRemoteMailboxEmailAddressesidentity, nameof(exchangeGetRemoteMailboxEmailAddressesidentity), required: true);
            WorkflowValue.Validate(exchangeGetRemoteMailboxEmailAddressesworkflow, nameof(exchangeGetRemoteMailboxEmailAddressesworkflow), required: true);
            return new DeferredBodyAction<ExchangeGetRemoteMailboxEmailAddressesResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetRemoteMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetRemoteMailboxEmailAddresses = new JObject();
                var exchangeGetRemoteMailboxEmailAddressespropCount = 0;
                exchangeGetRemoteMailboxEmailAddressespropCount++;
                exchangeGetRemoteMailboxEmailAddresses["Identity"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxEmailAddressesidentity);
                exchangeGetRemoteMailboxEmailAddressespropCount++;
                exchangeGetRemoteMailboxEmailAddresses["Workflow"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxEmailAddressesworkflow);
                if (exchangeGetRemoteMailboxEmailAddressespropCount > 0)
                {
                    callPayload.Body = exchangeGetRemoteMailboxEmailAddresses;
                }

                return new ApiConnectionAction<ExchangeGetRemoteMailboxEmailAddressesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeResetMailboxAttributes))]
        public IBodyWorkflowAction<ExchangeResetMailboxAttributesResponse> ExchangeResetMailboxAttributes([WorkflowExpression] Func<string> exchangeResetMailboxAttributesidentity, [WorkflowExpression] Func<string> exchangeResetMailboxAttributesworkflow, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute1 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute2 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute3 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute4 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute5 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute6 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute7 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute8 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute9 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute10 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute11 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute12 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute13 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute14 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute15 = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeResetMailboxAttributesResponse> __BuildExchangeResetMailboxAttributes(WorkflowValue<string> exchangeResetMailboxAttributesidentity, WorkflowValue<string> exchangeResetMailboxAttributesworkflow, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute1 = null, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute2 = null, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute3 = null, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute4 = null, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute5 = null, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute6 = null, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute7 = null, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute8 = null, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute9 = null, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute10 = null, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute11 = null, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute12 = null, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute13 = null, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute14 = null, WorkflowValue<bool> exchangeResetMailboxAttributesresetCustomAttribute15 = null)
        {
            WorkflowValue.Validate(exchangeResetMailboxAttributesidentity, nameof(exchangeResetMailboxAttributesidentity), required: true);
            WorkflowValue.Validate(exchangeResetMailboxAttributesworkflow, nameof(exchangeResetMailboxAttributesworkflow), required: true);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute1, nameof(exchangeResetMailboxAttributesresetCustomAttribute1), required: false);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute2, nameof(exchangeResetMailboxAttributesresetCustomAttribute2), required: false);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute3, nameof(exchangeResetMailboxAttributesresetCustomAttribute3), required: false);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute4, nameof(exchangeResetMailboxAttributesresetCustomAttribute4), required: false);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute5, nameof(exchangeResetMailboxAttributesresetCustomAttribute5), required: false);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute6, nameof(exchangeResetMailboxAttributesresetCustomAttribute6), required: false);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute7, nameof(exchangeResetMailboxAttributesresetCustomAttribute7), required: false);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute8, nameof(exchangeResetMailboxAttributesresetCustomAttribute8), required: false);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute9, nameof(exchangeResetMailboxAttributesresetCustomAttribute9), required: false);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute10, nameof(exchangeResetMailboxAttributesresetCustomAttribute10), required: false);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute11, nameof(exchangeResetMailboxAttributesresetCustomAttribute11), required: false);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute12, nameof(exchangeResetMailboxAttributesresetCustomAttribute12), required: false);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute13, nameof(exchangeResetMailboxAttributesresetCustomAttribute13), required: false);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute14, nameof(exchangeResetMailboxAttributesresetCustomAttribute14), required: false);
            WorkflowValue.Validate(exchangeResetMailboxAttributesresetCustomAttribute15, nameof(exchangeResetMailboxAttributesresetCustomAttribute15), required: false);
            return new DeferredBodyAction<ExchangeResetMailboxAttributesResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeResetMailboxAttributes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeResetMailboxAttributes = new JObject();
                var exchangeResetMailboxAttributespropCount = 0;
                exchangeResetMailboxAttributespropCount++;
                exchangeResetMailboxAttributes["Identity"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesidentity);
                if (exchangeResetMailboxAttributesresetCustomAttribute1 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute1 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute1"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute1);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute1"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (exchangeResetMailboxAttributesresetCustomAttribute2 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute2 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute2"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute2);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute2"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (exchangeResetMailboxAttributesresetCustomAttribute3 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute3 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute3"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute3);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute3"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (exchangeResetMailboxAttributesresetCustomAttribute4 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute4 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute4"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute4);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute4"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (exchangeResetMailboxAttributesresetCustomAttribute5 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute5 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute5"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute5);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute5"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (exchangeResetMailboxAttributesresetCustomAttribute6 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute6 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute6"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute6);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute6"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (exchangeResetMailboxAttributesresetCustomAttribute7 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute7 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute7"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute7);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute7"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (exchangeResetMailboxAttributesresetCustomAttribute8 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute8 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute8"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute8);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute8"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (exchangeResetMailboxAttributesresetCustomAttribute9 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute9 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute9"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute9);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute9"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (exchangeResetMailboxAttributesresetCustomAttribute10 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute10 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute10"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute10);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute10"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (exchangeResetMailboxAttributesresetCustomAttribute11 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute11 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute11"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute11);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute11"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (exchangeResetMailboxAttributesresetCustomAttribute12 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute12 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute12"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute12);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute12"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (exchangeResetMailboxAttributesresetCustomAttribute13 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute13 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute13"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute13);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute13"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (exchangeResetMailboxAttributesresetCustomAttribute14 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute14 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute14"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute14);
                        exchangeResetMailboxAttributespropCount++;
                    }

                    exchangeResetMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute14"] = false;
                    exchangeResetMailboxAttributespropCount++;
                }

                if (exchangeResetMailboxAttributesresetCustomAttribute15 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute15 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute15"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesresetCustomAttribute15);
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
                exchangeResetMailboxAttributes["Workflow"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesworkflow);
                if (exchangeResetMailboxAttributespropCount > 0)
                {
                    callPayload.Body = exchangeResetMailboxAttributes;
                }

                return new ApiConnectionAction<ExchangeResetMailboxAttributesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeResetRemoteMailboxAttributes))]
        public IBodyWorkflowAction<ExchangeResetRemoteMailboxAttributesResponse> ExchangeResetRemoteMailboxAttributes([WorkflowExpression] Func<string> exchangeResetRemoteMailboxAttributesidentity, [WorkflowExpression] Func<string> exchangeResetRemoteMailboxAttributesworkflow, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute1 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute2 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute3 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute4 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute5 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute6 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute7 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute8 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute9 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute10 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute11 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute12 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute13 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute14 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute15 = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeResetRemoteMailboxAttributesResponse> __BuildExchangeResetRemoteMailboxAttributes(WorkflowValue<string> exchangeResetRemoteMailboxAttributesidentity, WorkflowValue<string> exchangeResetRemoteMailboxAttributesworkflow, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute1 = null, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute2 = null, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute3 = null, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute4 = null, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute5 = null, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute6 = null, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute7 = null, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute8 = null, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute9 = null, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute10 = null, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute11 = null, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute12 = null, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute13 = null, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute14 = null, WorkflowValue<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute15 = null)
        {
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesidentity, nameof(exchangeResetRemoteMailboxAttributesidentity), required: true);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesworkflow, nameof(exchangeResetRemoteMailboxAttributesworkflow), required: true);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute1, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute1), required: false);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute2, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute2), required: false);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute3, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute3), required: false);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute4, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute4), required: false);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute5, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute5), required: false);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute6, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute6), required: false);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute7, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute7), required: false);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute8, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute8), required: false);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute9, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute9), required: false);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute10, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute10), required: false);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute11, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute11), required: false);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute12, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute12), required: false);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute13, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute13), required: false);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute14, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute14), required: false);
            WorkflowValue.Validate(exchangeResetRemoteMailboxAttributesresetCustomAttribute15, nameof(exchangeResetRemoteMailboxAttributesresetCustomAttribute15), required: false);
            return new DeferredBodyAction<ExchangeResetRemoteMailboxAttributesResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeResetRemoteMailboxAttributes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeResetRemoteMailboxAttributes = new JObject();
                var exchangeResetRemoteMailboxAttributespropCount = 0;
                exchangeResetRemoteMailboxAttributespropCount++;
                exchangeResetRemoteMailboxAttributes["Identity"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesidentity);
                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute1 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute1 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute1"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute1);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute1"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute2 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute2 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute2"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute2);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute2"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute3 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute3 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute3"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute3);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute3"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute4 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute4 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute4"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute4);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute4"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute5 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute5 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute5"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute5);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute5"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute6 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute6 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute6"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute6);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute6"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute7 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute7 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute7"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute7);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute7"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute8 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute8 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute8"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute8);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute8"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute9 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute9 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute9"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute9);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute9"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute10 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute10 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute10"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute10);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute10"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute11 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute11 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute11"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute11);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute11"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute12 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute12 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute12"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute12);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute12"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute13 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute13 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute13"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute13);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute13"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute14 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute14 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute14"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute14);
                        exchangeResetRemoteMailboxAttributespropCount++;
                    }

                    exchangeResetRemoteMailboxAttributespropCount++;
                }
                else
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute14"] = false;
                    exchangeResetRemoteMailboxAttributespropCount++;
                }

                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute15 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute15 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute15"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesresetCustomAttribute15);
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
                exchangeResetRemoteMailboxAttributes["Workflow"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesworkflow);
                if (exchangeResetRemoteMailboxAttributespropCount > 0)
                {
                    callPayload.Body = exchangeResetRemoteMailboxAttributes;
                }

                return new ApiConnectionAction<ExchangeResetRemoteMailboxAttributesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeSetRemoteMailbox))]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxResponse> ExchangeSetRemoteMailbox([WorkflowExpression] Func<string> exchangeSetRemoteMailboxidentity, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxworkflow, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxalias = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<exchangeSetRemoteMailboxtypeInput> exchangeSetRemoteMailboxtype = null, [WorkflowExpression] Func<bool> exchangeSetRemoteMailboxhiddenFromAddressListsEnabled = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute1 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute2 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute3 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute4 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute5 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute6 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute7 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute8 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute9 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute10 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute11 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute12 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute13 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute14 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute15 = null, [WorkflowExpression] Func<bool> exchangeSetRemoteMailboxemailAddressPolicyEnabled = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxResponse> __BuildExchangeSetRemoteMailbox(WorkflowValue<string> exchangeSetRemoteMailboxidentity, WorkflowValue<string> exchangeSetRemoteMailboxworkflow, WorkflowValue<string> exchangeSetRemoteMailboxalias = null, WorkflowValue<string> exchangeSetRemoteMailboxdisplayName = null, WorkflowValue<string> exchangeSetRemoteMailboxprimarySmtpAddress = null, WorkflowValue<exchangeSetRemoteMailboxtypeInput> exchangeSetRemoteMailboxtype = null, WorkflowValue<bool> exchangeSetRemoteMailboxhiddenFromAddressListsEnabled = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute1 = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute2 = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute3 = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute4 = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute5 = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute6 = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute7 = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute8 = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute9 = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute10 = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute11 = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute12 = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute13 = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute14 = null, WorkflowValue<string> exchangeSetRemoteMailboxcustomAttribute15 = null, WorkflowValue<bool> exchangeSetRemoteMailboxemailAddressPolicyEnabled = null)
        {
            WorkflowValue.Validate(exchangeSetRemoteMailboxidentity, nameof(exchangeSetRemoteMailboxidentity), required: true);
            WorkflowValue.Validate(exchangeSetRemoteMailboxworkflow, nameof(exchangeSetRemoteMailboxworkflow), required: true);
            WorkflowValue.Validate(exchangeSetRemoteMailboxalias, nameof(exchangeSetRemoteMailboxalias), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxdisplayName, nameof(exchangeSetRemoteMailboxdisplayName), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxprimarySmtpAddress, nameof(exchangeSetRemoteMailboxprimarySmtpAddress), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxtype, nameof(exchangeSetRemoteMailboxtype), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxhiddenFromAddressListsEnabled, nameof(exchangeSetRemoteMailboxhiddenFromAddressListsEnabled), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute1, nameof(exchangeSetRemoteMailboxcustomAttribute1), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute2, nameof(exchangeSetRemoteMailboxcustomAttribute2), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute3, nameof(exchangeSetRemoteMailboxcustomAttribute3), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute4, nameof(exchangeSetRemoteMailboxcustomAttribute4), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute5, nameof(exchangeSetRemoteMailboxcustomAttribute5), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute6, nameof(exchangeSetRemoteMailboxcustomAttribute6), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute7, nameof(exchangeSetRemoteMailboxcustomAttribute7), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute8, nameof(exchangeSetRemoteMailboxcustomAttribute8), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute9, nameof(exchangeSetRemoteMailboxcustomAttribute9), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute10, nameof(exchangeSetRemoteMailboxcustomAttribute10), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute11, nameof(exchangeSetRemoteMailboxcustomAttribute11), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute12, nameof(exchangeSetRemoteMailboxcustomAttribute12), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute13, nameof(exchangeSetRemoteMailboxcustomAttribute13), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute14, nameof(exchangeSetRemoteMailboxcustomAttribute14), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxcustomAttribute15, nameof(exchangeSetRemoteMailboxcustomAttribute15), required: false);
            WorkflowValue.Validate(exchangeSetRemoteMailboxemailAddressPolicyEnabled, nameof(exchangeSetRemoteMailboxemailAddressPolicyEnabled), required: false);
            return new DeferredBodyAction<ExchangeSetRemoteMailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetRemoteMailbox = new JObject();
                var exchangeSetRemoteMailboxpropCount = 0;
                exchangeSetRemoteMailboxpropCount++;
                exchangeSetRemoteMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxidentity);
                if (exchangeSetRemoteMailboxalias != null)
                {
                    exchangeSetRemoteMailbox["Alias"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxalias);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxdisplayName != null)
                {
                    exchangeSetRemoteMailbox["DisplayName"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxdisplayName);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxprimarySmtpAddress != null)
                {
                    exchangeSetRemoteMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxprimarySmtpAddress);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxtype != null)
                {
                    exchangeSetRemoteMailbox["Type"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxtype);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxhiddenFromAddressListsEnabled != null)
                {
                    exchangeSetRemoteMailbox["HiddenFromAddressListsEnabled"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxhiddenFromAddressListsEnabled);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute1 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute1"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute1);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute2 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute2"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute2);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute3 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute3"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute3);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute4 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute4"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute4);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute5 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute5"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute5);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute6 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute6"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute6);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute7 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute7"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute7);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute8 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute8"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute8);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute9 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute9"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute9);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute10 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute10"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute10);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute11 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute11"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute11);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute12 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute12"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute12);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute13 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute13"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute13);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute14 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute14"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute14);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute15 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute15"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxcustomAttribute15);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeSetRemoteMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxemailAddressPolicyEnabled);
                    exchangeSetRemoteMailboxpropCount++;
                }

                exchangeSetRemoteMailboxpropCount++;
                exchangeSetRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxworkflow);
                if (exchangeSetRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeSetRemoteMailbox;
                }

                return new ApiConnectionAction<ExchangeSetRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeSetMailboxSendOnBehalfOfPermission))]
        public IBodyWorkflowAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse> ExchangeSetMailboxSendOnBehalfOfPermission([WorkflowExpression] Func<string> exchangeSetMailboxSendOnBehalfOfPermissionidentity, [WorkflowExpression] Func<string> exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo, [WorkflowExpression] Func<string> exchangeSetMailboxSendOnBehalfOfPermissionworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse> __BuildExchangeSetMailboxSendOnBehalfOfPermission(WorkflowValue<string> exchangeSetMailboxSendOnBehalfOfPermissionidentity, WorkflowValue<string> exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo, WorkflowValue<string> exchangeSetMailboxSendOnBehalfOfPermissionworkflow)
        {
            WorkflowValue.Validate(exchangeSetMailboxSendOnBehalfOfPermissionidentity, nameof(exchangeSetMailboxSendOnBehalfOfPermissionidentity), required: true);
            WorkflowValue.Validate(exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo, nameof(exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo), required: true);
            WorkflowValue.Validate(exchangeSetMailboxSendOnBehalfOfPermissionworkflow, nameof(exchangeSetMailboxSendOnBehalfOfPermissionworkflow), required: true);
            return new DeferredBodyAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxSendOnBehalfOfPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetMailboxSendOnBehalfOfPermission = new JObject();
                var exchangeSetMailboxSendOnBehalfOfPermissionpropCount = 0;
                exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
                exchangeSetMailboxSendOnBehalfOfPermission["Identity"] = ExpressionConverter.ConvertO(exchangeSetMailboxSendOnBehalfOfPermissionidentity);
                exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
                exchangeSetMailboxSendOnBehalfOfPermission["GrantSendOnBehalfTo"] = ExpressionConverter.ConvertO(exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo);
                exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
                exchangeSetMailboxSendOnBehalfOfPermission["Workflow"] = ExpressionConverter.ConvertO(exchangeSetMailboxSendOnBehalfOfPermissionworkflow);
                if (exchangeSetMailboxSendOnBehalfOfPermissionpropCount > 0)
                {
                    callPayload.Body = exchangeSetMailboxSendOnBehalfOfPermission;
                }

                return new ApiConnectionAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeAddADPermission))]
        public IBodyWorkflowAction<ExchangeAddADPermissionResponse> ExchangeAddADPermission([WorkflowExpression] Func<string> exchangeAddADPermissionidentity, [WorkflowExpression] Func<string> exchangeAddADPermissionuser, [WorkflowExpression] Func<string> exchangeAddADPermissionworkflow, [WorkflowExpression] Func<string> exchangeAddADPermissionaccessRights = null, [WorkflowExpression] Func<string> exchangeAddADPermissionextendedRights = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeAddADPermissionResponse> __BuildExchangeAddADPermission(WorkflowValue<string> exchangeAddADPermissionidentity, WorkflowValue<string> exchangeAddADPermissionuser, WorkflowValue<string> exchangeAddADPermissionworkflow, WorkflowValue<string> exchangeAddADPermissionaccessRights = null, WorkflowValue<string> exchangeAddADPermissionextendedRights = null)
        {
            WorkflowValue.Validate(exchangeAddADPermissionidentity, nameof(exchangeAddADPermissionidentity), required: true);
            WorkflowValue.Validate(exchangeAddADPermissionuser, nameof(exchangeAddADPermissionuser), required: true);
            WorkflowValue.Validate(exchangeAddADPermissionworkflow, nameof(exchangeAddADPermissionworkflow), required: true);
            WorkflowValue.Validate(exchangeAddADPermissionaccessRights, nameof(exchangeAddADPermissionaccessRights), required: false);
            WorkflowValue.Validate(exchangeAddADPermissionextendedRights, nameof(exchangeAddADPermissionextendedRights), required: false);
            return new DeferredBodyAction<ExchangeAddADPermissionResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeAddADPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeAddADPermission = new JObject();
                var exchangeAddADPermissionpropCount = 0;
                exchangeAddADPermissionpropCount++;
                exchangeAddADPermission["Identity"] = ExpressionConverter.ConvertO(exchangeAddADPermissionidentity);
                exchangeAddADPermissionpropCount++;
                exchangeAddADPermission["User"] = ExpressionConverter.ConvertO(exchangeAddADPermissionuser);
                if (exchangeAddADPermissionaccessRights != null)
                {
                    exchangeAddADPermission["AccessRights"] = ExpressionConverter.ConvertO(exchangeAddADPermissionaccessRights);
                    exchangeAddADPermissionpropCount++;
                }

                if (exchangeAddADPermissionextendedRights != null)
                {
                    exchangeAddADPermission["ExtendedRights"] = ExpressionConverter.ConvertO(exchangeAddADPermissionextendedRights);
                    exchangeAddADPermissionpropCount++;
                }

                exchangeAddADPermissionpropCount++;
                exchangeAddADPermission["Workflow"] = ExpressionConverter.ConvertO(exchangeAddADPermissionworkflow);
                if (exchangeAddADPermissionpropCount > 0)
                {
                    callPayload.Body = exchangeAddADPermission;
                }

                return new ApiConnectionAction<ExchangeAddADPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildExchangeSetMailboxAutoReplyConfiguration))]
        public IBodyWorkflowAction<ExchangeSetMailboxAutoReplyConfigurationResponse> ExchangeSetMailboxAutoReplyConfiguration([WorkflowExpression] Func<string> exchangeSetMailboxAutoReplyConfigurationidentity, [WorkflowExpression] Func<exchangeSetMailboxAutoReplyConfigurationautoReplyStateInput> exchangeSetMailboxAutoReplyConfigurationautoReplyState, [WorkflowExpression] Func<string> exchangeSetMailboxAutoReplyConfigurationworkflow, [WorkflowExpression] Func<string> exchangeSetMailboxAutoReplyConfigurationinternalMessage = null, [WorkflowExpression] Func<exchangeSetMailboxAutoReplyConfigurationexternalAudienceInput> exchangeSetMailboxAutoReplyConfigurationexternalAudience = null, [WorkflowExpression] Func<string> exchangeSetMailboxAutoReplyConfigurationexternalMessage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeSetMailboxAutoReplyConfigurationResponse> __BuildExchangeSetMailboxAutoReplyConfiguration(WorkflowValue<string> exchangeSetMailboxAutoReplyConfigurationidentity, WorkflowValue<exchangeSetMailboxAutoReplyConfigurationautoReplyStateInput> exchangeSetMailboxAutoReplyConfigurationautoReplyState, WorkflowValue<string> exchangeSetMailboxAutoReplyConfigurationworkflow, WorkflowValue<string> exchangeSetMailboxAutoReplyConfigurationinternalMessage = null, WorkflowValue<exchangeSetMailboxAutoReplyConfigurationexternalAudienceInput> exchangeSetMailboxAutoReplyConfigurationexternalAudience = null, WorkflowValue<string> exchangeSetMailboxAutoReplyConfigurationexternalMessage = null)
        {
            WorkflowValue.Validate(exchangeSetMailboxAutoReplyConfigurationidentity, nameof(exchangeSetMailboxAutoReplyConfigurationidentity), required: true);
            WorkflowValue.Validate(exchangeSetMailboxAutoReplyConfigurationautoReplyState, nameof(exchangeSetMailboxAutoReplyConfigurationautoReplyState), required: true);
            WorkflowValue.Validate(exchangeSetMailboxAutoReplyConfigurationworkflow, nameof(exchangeSetMailboxAutoReplyConfigurationworkflow), required: true);
            WorkflowValue.Validate(exchangeSetMailboxAutoReplyConfigurationinternalMessage, nameof(exchangeSetMailboxAutoReplyConfigurationinternalMessage), required: false);
            WorkflowValue.Validate(exchangeSetMailboxAutoReplyConfigurationexternalAudience, nameof(exchangeSetMailboxAutoReplyConfigurationexternalAudience), required: false);
            WorkflowValue.Validate(exchangeSetMailboxAutoReplyConfigurationexternalMessage, nameof(exchangeSetMailboxAutoReplyConfigurationexternalMessage), required: false);
            return new DeferredBodyAction<ExchangeSetMailboxAutoReplyConfigurationResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxAutoReplyConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetMailboxAutoReplyConfiguration = new JObject();
                var exchangeSetMailboxAutoReplyConfigurationpropCount = 0;
                exchangeSetMailboxAutoReplyConfigurationpropCount++;
                exchangeSetMailboxAutoReplyConfiguration["Identity"] = ExpressionConverter.ConvertO(exchangeSetMailboxAutoReplyConfigurationidentity);
                exchangeSetMailboxAutoReplyConfigurationpropCount++;
                exchangeSetMailboxAutoReplyConfiguration["AutoReplyState"] = ExpressionConverter.ConvertO(exchangeSetMailboxAutoReplyConfigurationautoReplyState);
                if (exchangeSetMailboxAutoReplyConfigurationinternalMessage != null)
                {
                    exchangeSetMailboxAutoReplyConfiguration["InternalMessage"] = ExpressionConverter.ConvertO(exchangeSetMailboxAutoReplyConfigurationinternalMessage);
                    exchangeSetMailboxAutoReplyConfigurationpropCount++;
                }

                if (exchangeSetMailboxAutoReplyConfigurationexternalAudience != null)
                {
                    if (exchangeSetMailboxAutoReplyConfigurationexternalAudience != null)
                    {
                        exchangeSetMailboxAutoReplyConfiguration["ExternalAudience"] = ExpressionConverter.ConvertO(exchangeSetMailboxAutoReplyConfigurationexternalAudience);
                        exchangeSetMailboxAutoReplyConfigurationpropCount++;
                    }

                    exchangeSetMailboxAutoReplyConfigurationpropCount++;
                }
                else
                {
                    exchangeSetMailboxAutoReplyConfiguration["ExternalAudience"] = "All";
                    exchangeSetMailboxAutoReplyConfigurationpropCount++;
                }

                if (exchangeSetMailboxAutoReplyConfigurationexternalMessage != null)
                {
                    exchangeSetMailboxAutoReplyConfiguration["ExternalMessage"] = ExpressionConverter.ConvertO(exchangeSetMailboxAutoReplyConfigurationexternalMessage);
                    exchangeSetMailboxAutoReplyConfigurationpropCount++;
                }

                exchangeSetMailboxAutoReplyConfigurationpropCount++;
                exchangeSetMailboxAutoReplyConfiguration["Workflow"] = ExpressionConverter.ConvertO(exchangeSetMailboxAutoReplyConfigurationworkflow);
                if (exchangeSetMailboxAutoReplyConfigurationpropCount > 0)
                {
                    callPayload.Body = exchangeSetMailboxAutoReplyConfiguration;
                }

                return new ApiConnectionAction<ExchangeSetMailboxAutoReplyConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildIsAzureADv2PowerShellModuleInstalled))]
        public IBodyWorkflowAction<IsAzureADv2PowerShellModuleInstalledResponse> IsAzureADv2PowerShellModuleInstalled([WorkflowExpression] Func<string> isAzureADv2PowerShellModuleInstalledworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsAzureADv2PowerShellModuleInstalledResponse> __BuildIsAzureADv2PowerShellModuleInstalled(WorkflowValue<string> isAzureADv2PowerShellModuleInstalledworkflow)
        {
            WorkflowValue.Validate(isAzureADv2PowerShellModuleInstalledworkflow, nameof(isAzureADv2PowerShellModuleInstalledworkflow), required: true);
            return new DeferredBodyAction<IsAzureADv2PowerShellModuleInstalledResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/IsAzureADv2PowerShellModuleInstalled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isAzureADv2PowerShellModuleInstalled = new JObject();
                var isAzureADv2PowerShellModuleInstalledpropCount = 0;
                isAzureADv2PowerShellModuleInstalledpropCount++;
                isAzureADv2PowerShellModuleInstalled["Workflow"] = ExpressionConverter.ConvertO(isAzureADv2PowerShellModuleInstalledworkflow);
                if (isAzureADv2PowerShellModuleInstalledpropCount > 0)
                {
                    callPayload.Body = isAzureADv2PowerShellModuleInstalled;
                }

                return new ApiConnectionAction<IsAzureADv2PowerShellModuleInstalledResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildOpenAzureADv2PowerShellRunspace))]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceResponse> OpenAzureADv2PowerShellRunspace([WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceusername, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspacepassword, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceworkflow, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspacetenantId = null, [WorkflowExpression] Func<openAzureADv2PowerShellRunspaceaPIToUseInput> openAzureADv2PowerShellRunspaceaPIToUse = null, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceauthenticationScope = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceResponse> __BuildOpenAzureADv2PowerShellRunspace(WorkflowValue<string> openAzureADv2PowerShellRunspaceusername, WorkflowValue<string> openAzureADv2PowerShellRunspacepassword, WorkflowValue<string> openAzureADv2PowerShellRunspaceworkflow, WorkflowValue<string> openAzureADv2PowerShellRunspacetenantId = null, WorkflowValue<openAzureADv2PowerShellRunspaceaPIToUseInput> openAzureADv2PowerShellRunspaceaPIToUse = null, WorkflowValue<string> openAzureADv2PowerShellRunspaceauthenticationScope = null)
        {
            WorkflowValue.Validate(openAzureADv2PowerShellRunspaceusername, nameof(openAzureADv2PowerShellRunspaceusername), required: true);
            WorkflowValue.Validate(openAzureADv2PowerShellRunspacepassword, nameof(openAzureADv2PowerShellRunspacepassword), required: true);
            WorkflowValue.Validate(openAzureADv2PowerShellRunspaceworkflow, nameof(openAzureADv2PowerShellRunspaceworkflow), required: true);
            WorkflowValue.Validate(openAzureADv2PowerShellRunspacetenantId, nameof(openAzureADv2PowerShellRunspacetenantId), required: false);
            WorkflowValue.Validate(openAzureADv2PowerShellRunspaceaPIToUse, nameof(openAzureADv2PowerShellRunspaceaPIToUse), required: false);
            WorkflowValue.Validate(openAzureADv2PowerShellRunspaceauthenticationScope, nameof(openAzureADv2PowerShellRunspaceauthenticationScope), required: false);
            return new DeferredBodyAction<OpenAzureADv2PowerShellRunspaceResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/OpenAzureADv2PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openAzureADv2PowerShellRunspace = new JObject();
                var openAzureADv2PowerShellRunspacepropCount = 0;
                openAzureADv2PowerShellRunspacepropCount++;
                openAzureADv2PowerShellRunspace["Username"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceusername);
                openAzureADv2PowerShellRunspacepropCount++;
                openAzureADv2PowerShellRunspace["Password"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspacepassword);
                if (openAzureADv2PowerShellRunspacetenantId != null)
                {
                    openAzureADv2PowerShellRunspace["TenantId"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspacetenantId);
                    openAzureADv2PowerShellRunspacepropCount++;
                }

                if (openAzureADv2PowerShellRunspaceaPIToUse != null)
                {
                    if (openAzureADv2PowerShellRunspaceaPIToUse != null)
                    {
                        openAzureADv2PowerShellRunspace["APIToUse"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceaPIToUse);
                        openAzureADv2PowerShellRunspacepropCount++;
                    }

                    openAzureADv2PowerShellRunspacepropCount++;
                }
                else
                {
                    openAzureADv2PowerShellRunspace["APIToUse"] = "Auto";
                    openAzureADv2PowerShellRunspacepropCount++;
                }

                if (openAzureADv2PowerShellRunspaceauthenticationScope != null)
                {
                    if (openAzureADv2PowerShellRunspaceauthenticationScope != null)
                    {
                        openAzureADv2PowerShellRunspace["AuthenticationScope"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceauthenticationScope);
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
                openAzureADv2PowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceworkflow);
                if (openAzureADv2PowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = openAzureADv2PowerShellRunspace;
                }

                return new ApiConnectionAction<OpenAzureADv2PowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildOpenAzureADv2PowerShellRunspaceWithCertificate))]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse> OpenAzureADv2PowerShellRunspaceWithCertificate([WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceWithCertificateapplicationId, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceWithCertificatetenantId, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceWithCertificateworkflow, [WorkflowExpression] Func<openAzureADv2PowerShellRunspaceWithCertificateaPIToUseInput> openAzureADv2PowerShellRunspaceWithCertificateaPIToUse = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse> __BuildOpenAzureADv2PowerShellRunspaceWithCertificate(WorkflowValue<string> openAzureADv2PowerShellRunspaceWithCertificateapplicationId, WorkflowValue<string> openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint, WorkflowValue<string> openAzureADv2PowerShellRunspaceWithCertificatetenantId, WorkflowValue<string> openAzureADv2PowerShellRunspaceWithCertificateworkflow, WorkflowValue<openAzureADv2PowerShellRunspaceWithCertificateaPIToUseInput> openAzureADv2PowerShellRunspaceWithCertificateaPIToUse = null)
        {
            WorkflowValue.Validate(openAzureADv2PowerShellRunspaceWithCertificateapplicationId, nameof(openAzureADv2PowerShellRunspaceWithCertificateapplicationId), required: true);
            WorkflowValue.Validate(openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint, nameof(openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint), required: true);
            WorkflowValue.Validate(openAzureADv2PowerShellRunspaceWithCertificatetenantId, nameof(openAzureADv2PowerShellRunspaceWithCertificatetenantId), required: true);
            WorkflowValue.Validate(openAzureADv2PowerShellRunspaceWithCertificateworkflow, nameof(openAzureADv2PowerShellRunspaceWithCertificateworkflow), required: true);
            WorkflowValue.Validate(openAzureADv2PowerShellRunspaceWithCertificateaPIToUse, nameof(openAzureADv2PowerShellRunspaceWithCertificateaPIToUse), required: false);
            return new DeferredBodyAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/OpenAzureADv2PowerShellRunspaceWithCertificate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openAzureADv2PowerShellRunspaceWithCertificate = new JObject();
                var openAzureADv2PowerShellRunspaceWithCertificatepropCount = 0;
                openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
                openAzureADv2PowerShellRunspaceWithCertificate["ApplicationId"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceWithCertificateapplicationId);
                openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
                openAzureADv2PowerShellRunspaceWithCertificate["CertificateThumbprint"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint);
                openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
                openAzureADv2PowerShellRunspaceWithCertificate["TenantId"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceWithCertificatetenantId);
                if (openAzureADv2PowerShellRunspaceWithCertificateaPIToUse != null)
                {
                    if (openAzureADv2PowerShellRunspaceWithCertificateaPIToUse != null)
                    {
                        openAzureADv2PowerShellRunspaceWithCertificate["APIToUse"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceWithCertificateaPIToUse);
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
                openAzureADv2PowerShellRunspaceWithCertificate["Workflow"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceWithCertificateworkflow);
                if (openAzureADv2PowerShellRunspaceWithCertificatepropCount > 0)
                {
                    callPayload.Body = openAzureADv2PowerShellRunspaceWithCertificate;
                }

                return new ApiConnectionAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildIsAzureADv2PowerShellRunspaceOpen))]
        public IBodyWorkflowAction<IsAzureADv2PowerShellRunspaceOpenResponse> IsAzureADv2PowerShellRunspaceOpen([WorkflowExpression] Func<string> isAzureADv2PowerShellRunspaceOpenworkflow, [WorkflowExpression] Func<bool> isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsAzureADv2PowerShellRunspaceOpenResponse> __BuildIsAzureADv2PowerShellRunspaceOpen(WorkflowValue<string> isAzureADv2PowerShellRunspaceOpenworkflow, WorkflowValue<bool> isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
        {
            WorkflowValue.Validate(isAzureADv2PowerShellRunspaceOpenworkflow, nameof(isAzureADv2PowerShellRunspaceOpenworkflow), required: true);
            WorkflowValue.Validate(isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID, nameof(isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID), required: false);
            return new DeferredBodyAction<IsAzureADv2PowerShellRunspaceOpenResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/IsAzureADv2PowerShellRunspaceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isAzureADv2PowerShellRunspaceOpen = new JObject();
                var isAzureADv2PowerShellRunspaceOpenpropCount = 0;
                if (isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID != null)
                {
                    if (isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID != null)
                    {
                        isAzureADv2PowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = ExpressionConverter.ConvertO(isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID);
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
                isAzureADv2PowerShellRunspaceOpen["Workflow"] = ExpressionConverter.ConvertO(isAzureADv2PowerShellRunspaceOpenworkflow);
                if (isAzureADv2PowerShellRunspaceOpenpropCount > 0)
                {
                    callPayload.Body = isAzureADv2PowerShellRunspaceOpen;
                }

                return new ApiConnectionAction<IsAzureADv2PowerShellRunspaceOpenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildRunAzureADv2PowerShellAutomationScript))]
        public IBodyWorkflowAction<RunAzureADv2PowerShellAutomationScriptResponse> RunAzureADv2PowerShellAutomationScript([WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptworkflow, [WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptpowerShellScriptContents = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptisNoResultAnError = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptreturnComplexTypes = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptreturnDateAsDate = null, [WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptrunScriptAsThread = null, [WorkflowExpression] Func<int> runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptlogVerboseOutput = null, [WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON = null, [WorkflowExpression] Func<runAzureADv2PowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunAzureADv2PowerShellAutomationScriptResponse> __BuildRunAzureADv2PowerShellAutomationScript(WorkflowValue<string> runAzureADv2PowerShellAutomationScriptworkflow, WorkflowValue<string> runAzureADv2PowerShellAutomationScriptpowerShellScriptContents = null, WorkflowValue<bool> runAzureADv2PowerShellAutomationScriptisNoResultAnError = null, WorkflowValue<bool> runAzureADv2PowerShellAutomationScriptreturnComplexTypes = null, WorkflowValue<bool> runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean = null, WorkflowValue<bool> runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal = null, WorkflowValue<bool> runAzureADv2PowerShellAutomationScriptreturnDateAsDate = null, WorkflowValue<string> runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, WorkflowValue<bool> runAzureADv2PowerShellAutomationScriptrunScriptAsThread = null, WorkflowValue<int> runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId = null, WorkflowValue<int> runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread = null, WorkflowValue<bool> runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword = null, WorkflowValue<bool> runAzureADv2PowerShellAutomationScriptlogVerboseOutput = null, WorkflowValue<string> runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON = null, WorkflowValue<string> runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON = null, WorkflowValue<runAzureADv2PowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptworkflow, nameof(runAzureADv2PowerShellAutomationScriptworkflow), required: true);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptpowerShellScriptContents, nameof(runAzureADv2PowerShellAutomationScriptpowerShellScriptContents), required: false);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptisNoResultAnError, nameof(runAzureADv2PowerShellAutomationScriptisNoResultAnError), required: false);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptreturnComplexTypes, nameof(runAzureADv2PowerShellAutomationScriptreturnComplexTypes), required: false);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean, nameof(runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean), required: false);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal, nameof(runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal), required: false);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptreturnDateAsDate, nameof(runAzureADv2PowerShellAutomationScriptreturnDateAsDate), required: false);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON, nameof(runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON), required: false);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptrunScriptAsThread, nameof(runAzureADv2PowerShellAutomationScriptrunScriptAsThread), required: false);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId, nameof(runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId), required: false);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread, nameof(runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread), required: false);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword, nameof(runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword), required: false);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptlogVerboseOutput, nameof(runAzureADv2PowerShellAutomationScriptlogVerboseOutput), required: false);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON, nameof(runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON), required: false);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON, nameof(runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON), required: false);
            WorkflowValue.Validate(runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters, nameof(runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters), required: false);
            return new DeferredBodyAction<RunAzureADv2PowerShellAutomationScriptResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/RunAzureADv2PowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runAzureADv2PowerShellAutomationScript = new JObject();
                var runAzureADv2PowerShellAutomationScriptpropCount = 0;
                if (runAzureADv2PowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runAzureADv2PowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptpowerShellScriptContents);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (runAzureADv2PowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runAzureADv2PowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptisNoResultAnError);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["IsNoResultAnError"] = false;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptreturnComplexTypes != null)
                {
                    if (runAzureADv2PowerShellAutomationScriptreturnComplexTypes != null)
                    {
                        runAzureADv2PowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptreturnComplexTypes);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["ReturnComplexTypes"] = false;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean != null)
                {
                    if (runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean != null)
                    {
                        runAzureADv2PowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["ReturnBooleanAsBoolean"] = false;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal != null)
                {
                    if (runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal != null)
                    {
                        runAzureADv2PowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["ReturnNumericAsDecimal"] = false;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptreturnDateAsDate != null)
                {
                    if (runAzureADv2PowerShellAutomationScriptreturnDateAsDate != null)
                    {
                        runAzureADv2PowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptreturnDateAsDate);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["ReturnDateAsDate"] = false;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON != null)
                {
                    runAzureADv2PowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (runAzureADv2PowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runAzureADv2PowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptrunScriptAsThread);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["RunScriptAsThread"] = false;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId != null)
                {
                    runAzureADv2PowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runAzureADv2PowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["SecondsToWaitForThread"] = 90;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword != null)
                {
                    if (runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword != null)
                    {
                        runAzureADv2PowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["ScriptContainsStoredPassword"] = true;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptlogVerboseOutput != null)
                {
                    if (runAzureADv2PowerShellAutomationScriptlogVerboseOutput != null)
                    {
                        runAzureADv2PowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptlogVerboseOutput);
                        runAzureADv2PowerShellAutomationScriptpropCount++;
                    }

                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runAzureADv2PowerShellAutomationScript["LogVerboseOutput"] = false;
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON != null)
                {
                    runAzureADv2PowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runAzureADv2PowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runAzureADv2PowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                runAzureADv2PowerShellAutomationScriptpropCount++;
                runAzureADv2PowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptworkflow);
                if (runAzureADv2PowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runAzureADv2PowerShellAutomationScript;
                }

                return new ApiConnectionAction<RunAzureADv2PowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildCloseAzureADv2PowerShellRunspace))]
        public IBodyWorkflowAction<CloseAzureADv2PowerShellRunspaceResponse> CloseAzureADv2PowerShellRunspace([WorkflowExpression] Func<string> closeAzureADv2PowerShellRunspaceworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CloseAzureADv2PowerShellRunspaceResponse> __BuildCloseAzureADv2PowerShellRunspace(WorkflowValue<string> closeAzureADv2PowerShellRunspaceworkflow)
        {
            WorkflowValue.Validate(closeAzureADv2PowerShellRunspaceworkflow, nameof(closeAzureADv2PowerShellRunspaceworkflow), required: true);
            return new DeferredBodyAction<CloseAzureADv2PowerShellRunspaceResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/CloseAzureADv2PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var closeAzureADv2PowerShellRunspace = new JObject();
                var closeAzureADv2PowerShellRunspacepropCount = 0;
                closeAzureADv2PowerShellRunspacepropCount++;
                closeAzureADv2PowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(closeAzureADv2PowerShellRunspaceworkflow);
                if (closeAzureADv2PowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = closeAzureADv2PowerShellRunspace;
                }

                return new ApiConnectionAction<CloseAzureADv2PowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2GetAzureADUsers))]
        public IBodyWorkflowAction<AzureADv2GetAzureADUsersResponse> AzureADv2GetAzureADUsers([WorkflowExpression] Func<string> azureADv2GetAzureADUsersworkflow, [WorkflowExpression] Func<string> azureADv2GetAzureADUsersobjectId = null, [WorkflowExpression] Func<string> azureADv2GetAzureADUsersfilterPropertyName = null, [WorkflowExpression] Func<azureADv2GetAzureADUsersfilterPropertyComparisonInput> azureADv2GetAzureADUsersfilterPropertyComparison = null, [WorkflowExpression] Func<string> azureADv2GetAzureADUsersfilterPropertyValue = null, [WorkflowExpression] Func<bool> azureADv2GetAzureADUsersnoResultIsAnException = null, [WorkflowExpression] Func<string> azureADv2GetAzureADUserspropertiesToReturn = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2GetAzureADUsersResponse> __BuildAzureADv2GetAzureADUsers(WorkflowValue<string> azureADv2GetAzureADUsersworkflow, WorkflowValue<string> azureADv2GetAzureADUsersobjectId = null, WorkflowValue<string> azureADv2GetAzureADUsersfilterPropertyName = null, WorkflowValue<azureADv2GetAzureADUsersfilterPropertyComparisonInput> azureADv2GetAzureADUsersfilterPropertyComparison = null, WorkflowValue<string> azureADv2GetAzureADUsersfilterPropertyValue = null, WorkflowValue<bool> azureADv2GetAzureADUsersnoResultIsAnException = null, WorkflowValue<string> azureADv2GetAzureADUserspropertiesToReturn = null)
        {
            WorkflowValue.Validate(azureADv2GetAzureADUsersworkflow, nameof(azureADv2GetAzureADUsersworkflow), required: true);
            WorkflowValue.Validate(azureADv2GetAzureADUsersobjectId, nameof(azureADv2GetAzureADUsersobjectId), required: false);
            WorkflowValue.Validate(azureADv2GetAzureADUsersfilterPropertyName, nameof(azureADv2GetAzureADUsersfilterPropertyName), required: false);
            WorkflowValue.Validate(azureADv2GetAzureADUsersfilterPropertyComparison, nameof(azureADv2GetAzureADUsersfilterPropertyComparison), required: false);
            WorkflowValue.Validate(azureADv2GetAzureADUsersfilterPropertyValue, nameof(azureADv2GetAzureADUsersfilterPropertyValue), required: false);
            WorkflowValue.Validate(azureADv2GetAzureADUsersnoResultIsAnException, nameof(azureADv2GetAzureADUsersnoResultIsAnException), required: false);
            WorkflowValue.Validate(azureADv2GetAzureADUserspropertiesToReturn, nameof(azureADv2GetAzureADUserspropertiesToReturn), required: false);
            return new DeferredBodyAction<AzureADv2GetAzureADUsersResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUsers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUsers = new JObject();
                var azureADv2GetAzureADUserspropCount = 0;
                if (azureADv2GetAzureADUsersobjectId != null)
                {
                    azureADv2GetAzureADUsers["ObjectId"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUsersobjectId);
                    azureADv2GetAzureADUserspropCount++;
                }

                if (azureADv2GetAzureADUsersfilterPropertyName != null)
                {
                    azureADv2GetAzureADUsers["FilterPropertyName"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUsersfilterPropertyName);
                    azureADv2GetAzureADUserspropCount++;
                }

                if (azureADv2GetAzureADUsersfilterPropertyComparison != null)
                {
                    if (azureADv2GetAzureADUsersfilterPropertyComparison != null)
                    {
                        azureADv2GetAzureADUsers["FilterPropertyComparison"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUsersfilterPropertyComparison);
                        azureADv2GetAzureADUserspropCount++;
                    }

                    azureADv2GetAzureADUserspropCount++;
                }
                else
                {
                    azureADv2GetAzureADUsers["FilterPropertyComparison"] = "Equals";
                    azureADv2GetAzureADUserspropCount++;
                }

                if (azureADv2GetAzureADUsersfilterPropertyValue != null)
                {
                    azureADv2GetAzureADUsers["FilterPropertyValue"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUsersfilterPropertyValue);
                    azureADv2GetAzureADUserspropCount++;
                }

                if (azureADv2GetAzureADUsersnoResultIsAnException != null)
                {
                    if (azureADv2GetAzureADUsersnoResultIsAnException != null)
                    {
                        azureADv2GetAzureADUsers["NoResultIsAnException"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUsersnoResultIsAnException);
                        azureADv2GetAzureADUserspropCount++;
                    }

                    azureADv2GetAzureADUserspropCount++;
                }
                else
                {
                    azureADv2GetAzureADUsers["NoResultIsAnException"] = false;
                    azureADv2GetAzureADUserspropCount++;
                }

                if (azureADv2GetAzureADUserspropertiesToReturn != null)
                {
                    azureADv2GetAzureADUsers["PropertiesToReturn"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserspropertiesToReturn);
                    azureADv2GetAzureADUserspropCount++;
                }

                azureADv2GetAzureADUserspropCount++;
                azureADv2GetAzureADUsers["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUsersworkflow);
                if (azureADv2GetAzureADUserspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUsers;
                }

                return new ApiConnectionAction<AzureADv2GetAzureADUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2AddAzureADUser))]
        public IBodyWorkflowAction<AzureADv2AddAzureADUserResponse> AzureADv2AddAzureADUser([WorkflowExpression] Func<string> azureADv2AddAzureADUseruserPrincipalName, [WorkflowExpression] Func<bool> azureADv2AddAzureADUseraccountEnabled, [WorkflowExpression] Func<string> azureADv2AddAzureADUseraccountPassword, [WorkflowExpression] Func<string> azureADv2AddAzureADUserdisplayName, [WorkflowExpression] Func<string> azureADv2AddAzureADUsermailNickName, [WorkflowExpression] Func<string> azureADv2AddAzureADUserworkflow, [WorkflowExpression] Func<bool> azureADv2AddAzureADUseraccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserfirstName = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserlastName = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUsercity = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUsercompanyName = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUsercountry = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserdepartment = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserfaxNumber = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserjobTitle = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUsermobilePhone = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUseroffice = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserphoneNumber = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserpostalCode = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserpreferredLanguage = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserstate = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserstreetAddress = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserusageLocation = null, [WorkflowExpression] Func<azureADv2AddAzureADUserageGroupInput> azureADv2AddAzureADUserageGroup = null, [WorkflowExpression] Func<azureADv2AddAzureADUserconsentProvidedForMinorInput> azureADv2AddAzureADUserconsentProvidedForMinor = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUseremployeeId = null, [WorkflowExpression] Func<bool> azureADv2AddAzureADUserforceChangePasswordNextLogin = null, [WorkflowExpression] Func<bool> azureADv2AddAzureADUserenforceChangePasswordPolicy = null, [WorkflowExpression] Func<bool> azureADv2AddAzureADUserpasswordNeverExpires = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2AddAzureADUserResponse> __BuildAzureADv2AddAzureADUser(WorkflowValue<string> azureADv2AddAzureADUseruserPrincipalName, WorkflowValue<bool> azureADv2AddAzureADUseraccountEnabled, WorkflowValue<string> azureADv2AddAzureADUseraccountPassword, WorkflowValue<string> azureADv2AddAzureADUserdisplayName, WorkflowValue<string> azureADv2AddAzureADUsermailNickName, WorkflowValue<string> azureADv2AddAzureADUserworkflow, WorkflowValue<bool> azureADv2AddAzureADUseraccountPasswordIsStoredPassword = null, WorkflowValue<string> azureADv2AddAzureADUserfirstName = null, WorkflowValue<string> azureADv2AddAzureADUserlastName = null, WorkflowValue<string> azureADv2AddAzureADUsercity = null, WorkflowValue<string> azureADv2AddAzureADUsercompanyName = null, WorkflowValue<string> azureADv2AddAzureADUsercountry = null, WorkflowValue<string> azureADv2AddAzureADUserdepartment = null, WorkflowValue<string> azureADv2AddAzureADUserfaxNumber = null, WorkflowValue<string> azureADv2AddAzureADUserjobTitle = null, WorkflowValue<string> azureADv2AddAzureADUsermobilePhone = null, WorkflowValue<string> azureADv2AddAzureADUseroffice = null, WorkflowValue<string> azureADv2AddAzureADUserphoneNumber = null, WorkflowValue<string> azureADv2AddAzureADUserpostalCode = null, WorkflowValue<string> azureADv2AddAzureADUserpreferredLanguage = null, WorkflowValue<string> azureADv2AddAzureADUserstate = null, WorkflowValue<string> azureADv2AddAzureADUserstreetAddress = null, WorkflowValue<string> azureADv2AddAzureADUserusageLocation = null, WorkflowValue<azureADv2AddAzureADUserageGroupInput> azureADv2AddAzureADUserageGroup = null, WorkflowValue<azureADv2AddAzureADUserconsentProvidedForMinorInput> azureADv2AddAzureADUserconsentProvidedForMinor = null, WorkflowValue<string> azureADv2AddAzureADUseremployeeId = null, WorkflowValue<bool> azureADv2AddAzureADUserforceChangePasswordNextLogin = null, WorkflowValue<bool> azureADv2AddAzureADUserenforceChangePasswordPolicy = null, WorkflowValue<bool> azureADv2AddAzureADUserpasswordNeverExpires = null)
        {
            WorkflowValue.Validate(azureADv2AddAzureADUseruserPrincipalName, nameof(azureADv2AddAzureADUseruserPrincipalName), required: true);
            WorkflowValue.Validate(azureADv2AddAzureADUseraccountEnabled, nameof(azureADv2AddAzureADUseraccountEnabled), required: true);
            WorkflowValue.Validate(azureADv2AddAzureADUseraccountPassword, nameof(azureADv2AddAzureADUseraccountPassword), required: true);
            WorkflowValue.Validate(azureADv2AddAzureADUserdisplayName, nameof(azureADv2AddAzureADUserdisplayName), required: true);
            WorkflowValue.Validate(azureADv2AddAzureADUsermailNickName, nameof(azureADv2AddAzureADUsermailNickName), required: true);
            WorkflowValue.Validate(azureADv2AddAzureADUserworkflow, nameof(azureADv2AddAzureADUserworkflow), required: true);
            WorkflowValue.Validate(azureADv2AddAzureADUseraccountPasswordIsStoredPassword, nameof(azureADv2AddAzureADUseraccountPasswordIsStoredPassword), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserfirstName, nameof(azureADv2AddAzureADUserfirstName), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserlastName, nameof(azureADv2AddAzureADUserlastName), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUsercity, nameof(azureADv2AddAzureADUsercity), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUsercompanyName, nameof(azureADv2AddAzureADUsercompanyName), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUsercountry, nameof(azureADv2AddAzureADUsercountry), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserdepartment, nameof(azureADv2AddAzureADUserdepartment), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserfaxNumber, nameof(azureADv2AddAzureADUserfaxNumber), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserjobTitle, nameof(azureADv2AddAzureADUserjobTitle), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUsermobilePhone, nameof(azureADv2AddAzureADUsermobilePhone), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUseroffice, nameof(azureADv2AddAzureADUseroffice), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserphoneNumber, nameof(azureADv2AddAzureADUserphoneNumber), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserpostalCode, nameof(azureADv2AddAzureADUserpostalCode), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserpreferredLanguage, nameof(azureADv2AddAzureADUserpreferredLanguage), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserstate, nameof(azureADv2AddAzureADUserstate), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserstreetAddress, nameof(azureADv2AddAzureADUserstreetAddress), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserusageLocation, nameof(azureADv2AddAzureADUserusageLocation), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserageGroup, nameof(azureADv2AddAzureADUserageGroup), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserconsentProvidedForMinor, nameof(azureADv2AddAzureADUserconsentProvidedForMinor), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUseremployeeId, nameof(azureADv2AddAzureADUseremployeeId), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserforceChangePasswordNextLogin, nameof(azureADv2AddAzureADUserforceChangePasswordNextLogin), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserenforceChangePasswordPolicy, nameof(azureADv2AddAzureADUserenforceChangePasswordPolicy), required: false);
            WorkflowValue.Validate(azureADv2AddAzureADUserpasswordNeverExpires, nameof(azureADv2AddAzureADUserpasswordNeverExpires), required: false);
            return new DeferredBodyAction<AzureADv2AddAzureADUserResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddAzureADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AddAzureADUser = new JObject();
                var azureADv2AddAzureADUserpropCount = 0;
                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["UserPrincipalName"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUseruserPrincipalName);
                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["AccountEnabled"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUseraccountEnabled);
                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["AccountPassword"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUseraccountPassword);
                if (azureADv2AddAzureADUseraccountPasswordIsStoredPassword != null)
                {
                    if (azureADv2AddAzureADUseraccountPasswordIsStoredPassword != null)
                    {
                        azureADv2AddAzureADUser["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUseraccountPasswordIsStoredPassword);
                        azureADv2AddAzureADUserpropCount++;
                    }

                    azureADv2AddAzureADUserpropCount++;
                }
                else
                {
                    azureADv2AddAzureADUser["AccountPasswordIsStoredPassword"] = false;
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserfirstName != null)
                {
                    azureADv2AddAzureADUser["FirstName"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserfirstName);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserlastName != null)
                {
                    azureADv2AddAzureADUser["LastName"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserlastName);
                    azureADv2AddAzureADUserpropCount++;
                }

                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["DisplayName"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserdisplayName);
                if (azureADv2AddAzureADUsercity != null)
                {
                    azureADv2AddAzureADUser["City"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUsercity);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUsercompanyName != null)
                {
                    azureADv2AddAzureADUser["CompanyName"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUsercompanyName);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUsercountry != null)
                {
                    azureADv2AddAzureADUser["Country"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUsercountry);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserdepartment != null)
                {
                    azureADv2AddAzureADUser["Department"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserdepartment);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserfaxNumber != null)
                {
                    azureADv2AddAzureADUser["FaxNumber"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserfaxNumber);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserjobTitle != null)
                {
                    azureADv2AddAzureADUser["JobTitle"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserjobTitle);
                    azureADv2AddAzureADUserpropCount++;
                }

                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["MailNickName"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUsermailNickName);
                if (azureADv2AddAzureADUsermobilePhone != null)
                {
                    azureADv2AddAzureADUser["MobilePhone"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUsermobilePhone);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUseroffice != null)
                {
                    azureADv2AddAzureADUser["Office"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUseroffice);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserphoneNumber != null)
                {
                    azureADv2AddAzureADUser["PhoneNumber"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserphoneNumber);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserpostalCode != null)
                {
                    azureADv2AddAzureADUser["PostalCode"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserpostalCode);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserpreferredLanguage != null)
                {
                    azureADv2AddAzureADUser["PreferredLanguage"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserpreferredLanguage);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserstate != null)
                {
                    azureADv2AddAzureADUser["State"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserstate);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserstreetAddress != null)
                {
                    azureADv2AddAzureADUser["StreetAddress"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserstreetAddress);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserusageLocation != null)
                {
                    azureADv2AddAzureADUser["UsageLocation"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserusageLocation);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserageGroup != null)
                {
                    azureADv2AddAzureADUser["AgeGroup"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserageGroup);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserconsentProvidedForMinor != null)
                {
                    azureADv2AddAzureADUser["ConsentProvidedForMinor"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserconsentProvidedForMinor);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUseremployeeId != null)
                {
                    azureADv2AddAzureADUser["EmployeeId"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUseremployeeId);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserforceChangePasswordNextLogin != null)
                {
                    if (azureADv2AddAzureADUserforceChangePasswordNextLogin != null)
                    {
                        azureADv2AddAzureADUser["ForceChangePasswordNextLogin"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserforceChangePasswordNextLogin);
                        azureADv2AddAzureADUserpropCount++;
                    }

                    azureADv2AddAzureADUserpropCount++;
                }
                else
                {
                    azureADv2AddAzureADUser["ForceChangePasswordNextLogin"] = true;
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserenforceChangePasswordPolicy != null)
                {
                    if (azureADv2AddAzureADUserenforceChangePasswordPolicy != null)
                    {
                        azureADv2AddAzureADUser["EnforceChangePasswordPolicy"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserenforceChangePasswordPolicy);
                        azureADv2AddAzureADUserpropCount++;
                    }

                    azureADv2AddAzureADUserpropCount++;
                }
                else
                {
                    azureADv2AddAzureADUser["EnforceChangePasswordPolicy"] = false;
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserpasswordNeverExpires != null)
                {
                    if (azureADv2AddAzureADUserpasswordNeverExpires != null)
                    {
                        azureADv2AddAzureADUser["PasswordNeverExpires"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserpasswordNeverExpires);
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
                azureADv2AddAzureADUser["Workflow"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserworkflow);
                if (azureADv2AddAzureADUserpropCount > 0)
                {
                    callPayload.Body = azureADv2AddAzureADUser;
                }

                return new ApiConnectionAction<AzureADv2AddAzureADUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2RemoveAzureADUser))]
        public IBodyWorkflowAction<AzureADv2RemoveAzureADUserResponse> AzureADv2RemoveAzureADUser([WorkflowExpression] Func<string> azureADv2RemoveAzureADUserobjectId, [WorkflowExpression] Func<string> azureADv2RemoveAzureADUserworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveAzureADUsererrorIfUserDoesNotExist = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2RemoveAzureADUserResponse> __BuildAzureADv2RemoveAzureADUser(WorkflowValue<string> azureADv2RemoveAzureADUserobjectId, WorkflowValue<string> azureADv2RemoveAzureADUserworkflow, WorkflowValue<bool> azureADv2RemoveAzureADUsererrorIfUserDoesNotExist = null)
        {
            WorkflowValue.Validate(azureADv2RemoveAzureADUserobjectId, nameof(azureADv2RemoveAzureADUserobjectId), required: true);
            WorkflowValue.Validate(azureADv2RemoveAzureADUserworkflow, nameof(azureADv2RemoveAzureADUserworkflow), required: true);
            WorkflowValue.Validate(azureADv2RemoveAzureADUsererrorIfUserDoesNotExist, nameof(azureADv2RemoveAzureADUsererrorIfUserDoesNotExist), required: false);
            return new DeferredBodyAction<AzureADv2RemoveAzureADUserResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveAzureADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveAzureADUser = new JObject();
                var azureADv2RemoveAzureADUserpropCount = 0;
                azureADv2RemoveAzureADUserpropCount++;
                azureADv2RemoveAzureADUser["ObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveAzureADUserobjectId);
                if (azureADv2RemoveAzureADUsererrorIfUserDoesNotExist != null)
                {
                    if (azureADv2RemoveAzureADUsererrorIfUserDoesNotExist != null)
                    {
                        azureADv2RemoveAzureADUser["ErrorIfUserDoesNotExist"] = ExpressionConverter.ConvertO(azureADv2RemoveAzureADUsererrorIfUserDoesNotExist);
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
                azureADv2RemoveAzureADUser["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveAzureADUserworkflow);
                if (azureADv2RemoveAzureADUserpropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveAzureADUser;
                }

                return new ApiConnectionAction<AzureADv2RemoveAzureADUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2ResetAzureADUserPassword))]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPasswordResponse> AzureADv2ResetAzureADUserPassword([WorkflowExpression] Func<string> azureADv2ResetAzureADUserPassworduserPrincipalName, [WorkflowExpression] Func<string> azureADv2ResetAzureADUserPasswordnewPassword, [WorkflowExpression] Func<string> azureADv2ResetAzureADUserPasswordworkflow, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPasswordResponse> __BuildAzureADv2ResetAzureADUserPassword(WorkflowValue<string> azureADv2ResetAzureADUserPassworduserPrincipalName, WorkflowValue<string> azureADv2ResetAzureADUserPasswordnewPassword, WorkflowValue<string> azureADv2ResetAzureADUserPasswordworkflow, WorkflowValue<bool> azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword = null, WorkflowValue<bool> azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin = null, WorkflowValue<bool> azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy = null)
        {
            WorkflowValue.Validate(azureADv2ResetAzureADUserPassworduserPrincipalName, nameof(azureADv2ResetAzureADUserPassworduserPrincipalName), required: true);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPasswordnewPassword, nameof(azureADv2ResetAzureADUserPasswordnewPassword), required: true);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPasswordworkflow, nameof(azureADv2ResetAzureADUserPasswordworkflow), required: true);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword, nameof(azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin, nameof(azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy, nameof(azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy), required: false);
            return new DeferredBodyAction<AzureADv2ResetAzureADUserPasswordResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2ResetAzureADUserPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2ResetAzureADUserPassword = new JObject();
                var azureADv2ResetAzureADUserPasswordpropCount = 0;
                azureADv2ResetAzureADUserPasswordpropCount++;
                azureADv2ResetAzureADUserPassword["UserPrincipalName"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPassworduserPrincipalName);
                azureADv2ResetAzureADUserPasswordpropCount++;
                azureADv2ResetAzureADUserPassword["NewPassword"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPasswordnewPassword);
                if (azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword != null)
                {
                    if (azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword != null)
                    {
                        azureADv2ResetAzureADUserPassword["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword);
                        azureADv2ResetAzureADUserPasswordpropCount++;
                    }

                    azureADv2ResetAzureADUserPasswordpropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserPassword["AccountPasswordIsStoredPassword"] = false;
                    azureADv2ResetAzureADUserPasswordpropCount++;
                }

                if (azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin != null)
                {
                    if (azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin != null)
                    {
                        azureADv2ResetAzureADUserPassword["ForceChangePasswordNextLogin"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin);
                        azureADv2ResetAzureADUserPasswordpropCount++;
                    }

                    azureADv2ResetAzureADUserPasswordpropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserPassword["ForceChangePasswordNextLogin"] = true;
                    azureADv2ResetAzureADUserPasswordpropCount++;
                }

                if (azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy != null)
                {
                    if (azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy != null)
                    {
                        azureADv2ResetAzureADUserPassword["EnforceChangePasswordPolicy"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy);
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
                azureADv2ResetAzureADUserPassword["Workflow"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPasswordworkflow);
                if (azureADv2ResetAzureADUserPasswordpropCount > 0)
                {
                    callPayload.Body = azureADv2ResetAzureADUserPassword;
                }

                return new ApiConnectionAction<AzureADv2ResetAzureADUserPasswordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2GetAzureADUserGroupMembership))]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserGroupMembershipResponse> AzureADv2GetAzureADUserGroupMembership([WorkflowExpression] Func<string> azureADv2GetAzureADUserGroupMembershipobjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADUserGroupMembershipworkflow, [WorkflowExpression] Func<string> azureADv2GetAzureADUserGroupMembershippropertiesToReturn = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserGroupMembershipResponse> __BuildAzureADv2GetAzureADUserGroupMembership(WorkflowValue<string> azureADv2GetAzureADUserGroupMembershipobjectId, WorkflowValue<string> azureADv2GetAzureADUserGroupMembershipworkflow, WorkflowValue<string> azureADv2GetAzureADUserGroupMembershippropertiesToReturn = null)
        {
            WorkflowValue.Validate(azureADv2GetAzureADUserGroupMembershipobjectId, nameof(azureADv2GetAzureADUserGroupMembershipobjectId), required: true);
            WorkflowValue.Validate(azureADv2GetAzureADUserGroupMembershipworkflow, nameof(azureADv2GetAzureADUserGroupMembershipworkflow), required: true);
            WorkflowValue.Validate(azureADv2GetAzureADUserGroupMembershippropertiesToReturn, nameof(azureADv2GetAzureADUserGroupMembershippropertiesToReturn), required: false);
            return new DeferredBodyAction<AzureADv2GetAzureADUserGroupMembershipResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUserGroupMembership = new JObject();
                var azureADv2GetAzureADUserGroupMembershippropCount = 0;
                azureADv2GetAzureADUserGroupMembershippropCount++;
                azureADv2GetAzureADUserGroupMembership["ObjectId"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserGroupMembershipobjectId);
                if (azureADv2GetAzureADUserGroupMembershippropertiesToReturn != null)
                {
                    azureADv2GetAzureADUserGroupMembership["PropertiesToReturn"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserGroupMembershippropertiesToReturn);
                    azureADv2GetAzureADUserGroupMembershippropCount++;
                }

                azureADv2GetAzureADUserGroupMembershippropCount++;
                azureADv2GetAzureADUserGroupMembership["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserGroupMembershipworkflow);
                if (azureADv2GetAzureADUserGroupMembershippropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUserGroupMembership;
                }

                return new ApiConnectionAction<AzureADv2GetAzureADUserGroupMembershipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2IsUserInAzureADUserGroup))]
        public IBodyWorkflowAction<AzureADv2IsUserInAzureADUserGroupResponse> AzureADv2IsUserInAzureADUserGroup([WorkflowExpression] Func<string> azureADv2IsUserInAzureADUserGroupobjectId, [WorkflowExpression] Func<string> azureADv2IsUserInAzureADUserGroupgroupObjectId, [WorkflowExpression] Func<string> azureADv2IsUserInAzureADUserGroupworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2IsUserInAzureADUserGroupResponse> __BuildAzureADv2IsUserInAzureADUserGroup(WorkflowValue<string> azureADv2IsUserInAzureADUserGroupobjectId, WorkflowValue<string> azureADv2IsUserInAzureADUserGroupgroupObjectId, WorkflowValue<string> azureADv2IsUserInAzureADUserGroupworkflow)
        {
            WorkflowValue.Validate(azureADv2IsUserInAzureADUserGroupobjectId, nameof(azureADv2IsUserInAzureADUserGroupobjectId), required: true);
            WorkflowValue.Validate(azureADv2IsUserInAzureADUserGroupgroupObjectId, nameof(azureADv2IsUserInAzureADUserGroupgroupObjectId), required: true);
            WorkflowValue.Validate(azureADv2IsUserInAzureADUserGroupworkflow, nameof(azureADv2IsUserInAzureADUserGroupworkflow), required: true);
            return new DeferredBodyAction<AzureADv2IsUserInAzureADUserGroupResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2IsUserInAzureADUserGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2IsUserInAzureADUserGroup = new JObject();
                var azureADv2IsUserInAzureADUserGrouppropCount = 0;
                azureADv2IsUserInAzureADUserGrouppropCount++;
                azureADv2IsUserInAzureADUserGroup["ObjectId"] = ExpressionConverter.ConvertO(azureADv2IsUserInAzureADUserGroupobjectId);
                azureADv2IsUserInAzureADUserGrouppropCount++;
                azureADv2IsUserInAzureADUserGroup["GroupObjectId"] = ExpressionConverter.ConvertO(azureADv2IsUserInAzureADUserGroupgroupObjectId);
                azureADv2IsUserInAzureADUserGrouppropCount++;
                azureADv2IsUserInAzureADUserGroup["Workflow"] = ExpressionConverter.ConvertO(azureADv2IsUserInAzureADUserGroupworkflow);
                if (azureADv2IsUserInAzureADUserGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2IsUserInAzureADUserGroup;
                }

                return new ApiConnectionAction<AzureADv2IsUserInAzureADUserGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2AddUserToGroup))]
        public IBodyWorkflowAction<AzureADv2AddUserToGroupResponse> AzureADv2AddUserToGroup([WorkflowExpression] Func<string> azureADv2AddUserToGroupuserObjectId, [WorkflowExpression] Func<string> azureADv2AddUserToGroupgroupObjectId, [WorkflowExpression] Func<string> azureADv2AddUserToGroupworkflow, [WorkflowExpression] Func<bool> azureADv2AddUserToGroupcheckUserGroupMembershipsFirst = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2AddUserToGroupResponse> __BuildAzureADv2AddUserToGroup(WorkflowValue<string> azureADv2AddUserToGroupuserObjectId, WorkflowValue<string> azureADv2AddUserToGroupgroupObjectId, WorkflowValue<string> azureADv2AddUserToGroupworkflow, WorkflowValue<bool> azureADv2AddUserToGroupcheckUserGroupMembershipsFirst = null)
        {
            WorkflowValue.Validate(azureADv2AddUserToGroupuserObjectId, nameof(azureADv2AddUserToGroupuserObjectId), required: true);
            WorkflowValue.Validate(azureADv2AddUserToGroupgroupObjectId, nameof(azureADv2AddUserToGroupgroupObjectId), required: true);
            WorkflowValue.Validate(azureADv2AddUserToGroupworkflow, nameof(azureADv2AddUserToGroupworkflow), required: true);
            WorkflowValue.Validate(azureADv2AddUserToGroupcheckUserGroupMembershipsFirst, nameof(azureADv2AddUserToGroupcheckUserGroupMembershipsFirst), required: false);
            return new DeferredBodyAction<AzureADv2AddUserToGroupResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddUserToGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AddUserToGroup = new JObject();
                var azureADv2AddUserToGrouppropCount = 0;
                azureADv2AddUserToGrouppropCount++;
                azureADv2AddUserToGroup["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2AddUserToGroupuserObjectId);
                azureADv2AddUserToGrouppropCount++;
                azureADv2AddUserToGroup["GroupObjectId"] = ExpressionConverter.ConvertO(azureADv2AddUserToGroupgroupObjectId);
                if (azureADv2AddUserToGroupcheckUserGroupMembershipsFirst != null)
                {
                    if (azureADv2AddUserToGroupcheckUserGroupMembershipsFirst != null)
                    {
                        azureADv2AddUserToGroup["CheckUserGroupMembershipsFirst"] = ExpressionConverter.ConvertO(azureADv2AddUserToGroupcheckUserGroupMembershipsFirst);
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
                azureADv2AddUserToGroup["Workflow"] = ExpressionConverter.ConvertO(azureADv2AddUserToGroupworkflow);
                if (azureADv2AddUserToGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2AddUserToGroup;
                }

                return new ApiConnectionAction<AzureADv2AddUserToGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2RemoveUserFromGroup))]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromGroupResponse> AzureADv2RemoveUserFromGroup([WorkflowExpression] Func<string> azureADv2RemoveUserFromGroupuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromGroupgroupObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromGroupworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromGroupResponse> __BuildAzureADv2RemoveUserFromGroup(WorkflowValue<string> azureADv2RemoveUserFromGroupuserObjectId, WorkflowValue<string> azureADv2RemoveUserFromGroupgroupObjectId, WorkflowValue<string> azureADv2RemoveUserFromGroupworkflow, WorkflowValue<bool> azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst = null)
        {
            WorkflowValue.Validate(azureADv2RemoveUserFromGroupuserObjectId, nameof(azureADv2RemoveUserFromGroupuserObjectId), required: true);
            WorkflowValue.Validate(azureADv2RemoveUserFromGroupgroupObjectId, nameof(azureADv2RemoveUserFromGroupgroupObjectId), required: true);
            WorkflowValue.Validate(azureADv2RemoveUserFromGroupworkflow, nameof(azureADv2RemoveUserFromGroupworkflow), required: true);
            WorkflowValue.Validate(azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst, nameof(azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst), required: false);
            return new DeferredBodyAction<AzureADv2RemoveUserFromGroupResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromGroup = new JObject();
                var azureADv2RemoveUserFromGrouppropCount = 0;
                azureADv2RemoveUserFromGrouppropCount++;
                azureADv2RemoveUserFromGroup["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromGroupuserObjectId);
                azureADv2RemoveUserFromGrouppropCount++;
                azureADv2RemoveUserFromGroup["GroupObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromGroupgroupObjectId);
                if (azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst != null)
                {
                    if (azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst != null)
                    {
                        azureADv2RemoveUserFromGroup["CheckUserGroupMembershipsFirst"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst);
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
                azureADv2RemoveUserFromGroup["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromGroupworkflow);
                if (azureADv2RemoveUserFromGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromGroup;
                }

                return new ApiConnectionAction<AzureADv2RemoveUserFromGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2AddADUserToMultipleADGroups))]
        public IBodyWorkflowAction<AzureADv2AddADUserToMultipleADGroupsResponse> AzureADv2AddADUserToMultipleADGroups([WorkflowExpression] Func<string> azureADv2AddADUserToMultipleADGroupsuserObjectId, [WorkflowExpression] Func<string> azureADv2AddADUserToMultipleADGroupsworkflow, [WorkflowExpression] Func<string> azureADv2AddADUserToMultipleADGroupsgroupNamesJSON = null, [WorkflowExpression] Func<bool> azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd = null, [WorkflowExpression] Func<bool> azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd = null, [WorkflowExpression] Func<bool> azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst = null, [WorkflowExpression] Func<int> azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2AddADUserToMultipleADGroupsResponse> __BuildAzureADv2AddADUserToMultipleADGroups(WorkflowValue<string> azureADv2AddADUserToMultipleADGroupsuserObjectId, WorkflowValue<string> azureADv2AddADUserToMultipleADGroupsworkflow, WorkflowValue<string> azureADv2AddADUserToMultipleADGroupsgroupNamesJSON = null, WorkflowValue<bool> azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd = null, WorkflowValue<bool> azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd = null, WorkflowValue<bool> azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst = null, WorkflowValue<int> azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall = null)
        {
            WorkflowValue.Validate(azureADv2AddADUserToMultipleADGroupsuserObjectId, nameof(azureADv2AddADUserToMultipleADGroupsuserObjectId), required: true);
            WorkflowValue.Validate(azureADv2AddADUserToMultipleADGroupsworkflow, nameof(azureADv2AddADUserToMultipleADGroupsworkflow), required: true);
            WorkflowValue.Validate(azureADv2AddADUserToMultipleADGroupsgroupNamesJSON, nameof(azureADv2AddADUserToMultipleADGroupsgroupNamesJSON), required: false);
            WorkflowValue.Validate(azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd, nameof(azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd), required: false);
            WorkflowValue.Validate(azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd, nameof(azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd), required: false);
            WorkflowValue.Validate(azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst, nameof(azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst), required: false);
            WorkflowValue.Validate(azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall, nameof(azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall), required: false);
            return new DeferredBodyAction<AzureADv2AddADUserToMultipleADGroupsResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddADUserToMultipleADGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AddADUserToMultipleADGroups = new JObject();
                var azureADv2AddADUserToMultipleADGroupspropCount = 0;
                azureADv2AddADUserToMultipleADGroupspropCount++;
                azureADv2AddADUserToMultipleADGroups["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2AddADUserToMultipleADGroupsuserObjectId);
                if (azureADv2AddADUserToMultipleADGroupsgroupNamesJSON != null)
                {
                    azureADv2AddADUserToMultipleADGroups["GroupNamesJSON"] = ExpressionConverter.ConvertO(azureADv2AddADUserToMultipleADGroupsgroupNamesJSON);
                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }

                if (azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd != null)
                {
                    if (azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd != null)
                    {
                        azureADv2AddADUserToMultipleADGroups["ExceptionIfAnyGroupsFailToAdd"] = ExpressionConverter.ConvertO(azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd);
                        azureADv2AddADUserToMultipleADGroupspropCount++;
                    }

                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }
                else
                {
                    azureADv2AddADUserToMultipleADGroups["ExceptionIfAnyGroupsFailToAdd"] = false;
                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }

                if (azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd != null)
                {
                    if (azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd != null)
                    {
                        azureADv2AddADUserToMultipleADGroups["ExceptionIfAllGroupsFailToAdd"] = ExpressionConverter.ConvertO(azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd);
                        azureADv2AddADUserToMultipleADGroupspropCount++;
                    }

                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }
                else
                {
                    azureADv2AddADUserToMultipleADGroups["ExceptionIfAllGroupsFailToAdd"] = false;
                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }

                if (azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst != null)
                {
                    if (azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst != null)
                    {
                        azureADv2AddADUserToMultipleADGroups["CheckUserGroupMembershipsFirst"] = ExpressionConverter.ConvertO(azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst);
                        azureADv2AddADUserToMultipleADGroupspropCount++;
                    }

                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }
                else
                {
                    azureADv2AddADUserToMultipleADGroups["CheckUserGroupMembershipsFirst"] = true;
                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }

                if (azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall != null)
                {
                    azureADv2AddADUserToMultipleADGroups["MaxAzureADGroupsPerCall"] = ExpressionConverter.ConvertO(azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall);
                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }

                azureADv2AddADUserToMultipleADGroupspropCount++;
                azureADv2AddADUserToMultipleADGroups["Workflow"] = ExpressionConverter.ConvertO(azureADv2AddADUserToMultipleADGroupsworkflow);
                if (azureADv2AddADUserToMultipleADGroupspropCount > 0)
                {
                    callPayload.Body = azureADv2AddADUserToMultipleADGroups;
                }

                return new ApiConnectionAction<AzureADv2AddADUserToMultipleADGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2RemoveADUserFromMultipleADGroups))]
        public IBodyWorkflowAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse> AzureADv2RemoveADUserFromMultipleADGroups([WorkflowExpression] Func<string> azureADv2RemoveADUserFromMultipleADGroupsuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveADUserFromMultipleADGroupsworkflow, [WorkflowExpression] Func<string> azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON = null, [WorkflowExpression] Func<bool> azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst = null, [WorkflowExpression] Func<int> azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse> __BuildAzureADv2RemoveADUserFromMultipleADGroups(WorkflowValue<string> azureADv2RemoveADUserFromMultipleADGroupsuserObjectId, WorkflowValue<string> azureADv2RemoveADUserFromMultipleADGroupsworkflow, WorkflowValue<string> azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON = null, WorkflowValue<bool> azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove = null, WorkflowValue<bool> azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove = null, WorkflowValue<bool> azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst = null, WorkflowValue<int> azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall = null)
        {
            WorkflowValue.Validate(azureADv2RemoveADUserFromMultipleADGroupsuserObjectId, nameof(azureADv2RemoveADUserFromMultipleADGroupsuserObjectId), required: true);
            WorkflowValue.Validate(azureADv2RemoveADUserFromMultipleADGroupsworkflow, nameof(azureADv2RemoveADUserFromMultipleADGroupsworkflow), required: true);
            WorkflowValue.Validate(azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON, nameof(azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON), required: false);
            WorkflowValue.Validate(azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove, nameof(azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove), required: false);
            WorkflowValue.Validate(azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove, nameof(azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove), required: false);
            WorkflowValue.Validate(azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst, nameof(azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst), required: false);
            WorkflowValue.Validate(azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall, nameof(azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall), required: false);
            return new DeferredBodyAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveADUserFromMultipleADGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveADUserFromMultipleADGroups = new JObject();
                var azureADv2RemoveADUserFromMultipleADGroupspropCount = 0;
                azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                azureADv2RemoveADUserFromMultipleADGroups["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveADUserFromMultipleADGroupsuserObjectId);
                if (azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON != null)
                {
                    azureADv2RemoveADUserFromMultipleADGroups["GroupNamesJSON"] = ExpressionConverter.ConvertO(azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON);
                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }

                if (azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove != null)
                {
                    if (azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove != null)
                    {
                        azureADv2RemoveADUserFromMultipleADGroups["ExceptionIfAnyGroupsFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove);
                        azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                    }

                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }
                else
                {
                    azureADv2RemoveADUserFromMultipleADGroups["ExceptionIfAnyGroupsFailToRemove"] = false;
                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }

                if (azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove != null)
                {
                    if (azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove != null)
                    {
                        azureADv2RemoveADUserFromMultipleADGroups["ExceptionIfAllGroupsFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove);
                        azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                    }

                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }
                else
                {
                    azureADv2RemoveADUserFromMultipleADGroups["ExceptionIfAllGroupsFailToRemove"] = false;
                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }

                if (azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst != null)
                {
                    if (azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst != null)
                    {
                        azureADv2RemoveADUserFromMultipleADGroups["CheckUserGroupMembershipsFirst"] = ExpressionConverter.ConvertO(azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst);
                        azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                    }

                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }
                else
                {
                    azureADv2RemoveADUserFromMultipleADGroups["CheckUserGroupMembershipsFirst"] = true;
                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }

                if (azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall != null)
                {
                    azureADv2RemoveADUserFromMultipleADGroups["MaxAzureADGroupsPerCall"] = ExpressionConverter.ConvertO(azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall);
                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }

                azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                azureADv2RemoveADUserFromMultipleADGroups["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveADUserFromMultipleADGroupsworkflow);
                if (azureADv2RemoveADUserFromMultipleADGroupspropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveADUserFromMultipleADGroups;
                }

                return new ApiConnectionAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2RemoveUserFromAllGroups))]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllGroupsResponse> AzureADv2RemoveUserFromAllGroups([WorkflowExpression] Func<string> azureADv2RemoveUserFromAllGroupsuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromAllGroupsworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove = null, [WorkflowExpression] Func<int> azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllGroupsResponse> __BuildAzureADv2RemoveUserFromAllGroups(WorkflowValue<string> azureADv2RemoveUserFromAllGroupsuserObjectId, WorkflowValue<string> azureADv2RemoveUserFromAllGroupsworkflow, WorkflowValue<bool> azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove = null, WorkflowValue<bool> azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove = null, WorkflowValue<int> azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall = null)
        {
            WorkflowValue.Validate(azureADv2RemoveUserFromAllGroupsuserObjectId, nameof(azureADv2RemoveUserFromAllGroupsuserObjectId), required: true);
            WorkflowValue.Validate(azureADv2RemoveUserFromAllGroupsworkflow, nameof(azureADv2RemoveUserFromAllGroupsworkflow), required: true);
            WorkflowValue.Validate(azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove, nameof(azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove), required: false);
            WorkflowValue.Validate(azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove, nameof(azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove), required: false);
            WorkflowValue.Validate(azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall, nameof(azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall), required: false);
            return new DeferredBodyAction<AzureADv2RemoveUserFromAllGroupsResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromAllGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromAllGroups = new JObject();
                var azureADv2RemoveUserFromAllGroupspropCount = 0;
                azureADv2RemoveUserFromAllGroupspropCount++;
                azureADv2RemoveUserFromAllGroups["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllGroupsuserObjectId);
                if (azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove != null)
                {
                    if (azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove != null)
                    {
                        azureADv2RemoveUserFromAllGroups["ExceptionIfAnyGroupsFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove);
                        azureADv2RemoveUserFromAllGroupspropCount++;
                    }

                    azureADv2RemoveUserFromAllGroupspropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromAllGroups["ExceptionIfAnyGroupsFailToRemove"] = false;
                    azureADv2RemoveUserFromAllGroupspropCount++;
                }

                if (azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove != null)
                {
                    if (azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove != null)
                    {
                        azureADv2RemoveUserFromAllGroups["ExceptionIfAllGroupsFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove);
                        azureADv2RemoveUserFromAllGroupspropCount++;
                    }

                    azureADv2RemoveUserFromAllGroupspropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromAllGroups["ExceptionIfAllGroupsFailToRemove"] = false;
                    azureADv2RemoveUserFromAllGroupspropCount++;
                }

                if (azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall != null)
                {
                    azureADv2RemoveUserFromAllGroups["MaxAzureADGroupsPerCall"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall);
                    azureADv2RemoveUserFromAllGroupspropCount++;
                }

                azureADv2RemoveUserFromAllGroupspropCount++;
                azureADv2RemoveUserFromAllGroups["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllGroupsworkflow);
                if (azureADv2RemoveUserFromAllGroupspropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromAllGroups;
                }

                return new ApiConnectionAction<AzureADv2RemoveUserFromAllGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2GetAzureADLicenseSKUs))]
        public IBodyWorkflowAction<AzureADv2GetAzureADLicenseSKUsResponse> AzureADv2GetAzureADLicenseSKUs([WorkflowExpression] Func<string> azureADv2GetAzureADLicenseSKUsworkflow, [WorkflowExpression] Func<azureADv2GetAzureADLicenseSKUsexpandPropertyInput> azureADv2GetAzureADLicenseSKUsexpandProperty = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2GetAzureADLicenseSKUsResponse> __BuildAzureADv2GetAzureADLicenseSKUs(WorkflowValue<string> azureADv2GetAzureADLicenseSKUsworkflow, WorkflowValue<azureADv2GetAzureADLicenseSKUsexpandPropertyInput> azureADv2GetAzureADLicenseSKUsexpandProperty = null)
        {
            WorkflowValue.Validate(azureADv2GetAzureADLicenseSKUsworkflow, nameof(azureADv2GetAzureADLicenseSKUsworkflow), required: true);
            WorkflowValue.Validate(azureADv2GetAzureADLicenseSKUsexpandProperty, nameof(azureADv2GetAzureADLicenseSKUsexpandProperty), required: false);
            return new DeferredBodyAction<AzureADv2GetAzureADLicenseSKUsResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADLicenseSKUs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADLicenseSKUs = new JObject();
                var azureADv2GetAzureADLicenseSKUspropCount = 0;
                if (azureADv2GetAzureADLicenseSKUsexpandProperty != null)
                {
                    if (azureADv2GetAzureADLicenseSKUsexpandProperty != null)
                    {
                        azureADv2GetAzureADLicenseSKUs["ExpandProperty"] = ExpressionConverter.ConvertO(azureADv2GetAzureADLicenseSKUsexpandProperty);
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
                azureADv2GetAzureADLicenseSKUs["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetAzureADLicenseSKUsworkflow);
                if (azureADv2GetAzureADLicenseSKUspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADLicenseSKUs;
                }

                return new ApiConnectionAction<AzureADv2GetAzureADLicenseSKUsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2SetAzureADUserLicense))]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserLicenseResponse> AzureADv2SetAzureADUserLicense([WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenseobjectId, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenseworkflow, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenselicenseToAdd = null, [WorkflowExpression] Func<azureADv2SetAzureADUserLicenselicensePlansChoiceInput> azureADv2SetAzureADUserLicenselicensePlansChoice = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenselicensePlansCSV = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenselicensesToRemoveCSV = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenseusageLocation = null, [WorkflowExpression] Func<bool> azureADv2SetAzureADUserLicenselocalScope = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserLicenseResponse> __BuildAzureADv2SetAzureADUserLicense(WorkflowValue<string> azureADv2SetAzureADUserLicenseobjectId, WorkflowValue<string> azureADv2SetAzureADUserLicenseworkflow, WorkflowValue<string> azureADv2SetAzureADUserLicenselicenseToAdd = null, WorkflowValue<azureADv2SetAzureADUserLicenselicensePlansChoiceInput> azureADv2SetAzureADUserLicenselicensePlansChoice = null, WorkflowValue<string> azureADv2SetAzureADUserLicenselicensePlansCSV = null, WorkflowValue<string> azureADv2SetAzureADUserLicenselicensesToRemoveCSV = null, WorkflowValue<string> azureADv2SetAzureADUserLicenseusageLocation = null, WorkflowValue<bool> azureADv2SetAzureADUserLicenselocalScope = null)
        {
            WorkflowValue.Validate(azureADv2SetAzureADUserLicenseobjectId, nameof(azureADv2SetAzureADUserLicenseobjectId), required: true);
            WorkflowValue.Validate(azureADv2SetAzureADUserLicenseworkflow, nameof(azureADv2SetAzureADUserLicenseworkflow), required: true);
            WorkflowValue.Validate(azureADv2SetAzureADUserLicenselicenseToAdd, nameof(azureADv2SetAzureADUserLicenselicenseToAdd), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserLicenselicensePlansChoice, nameof(azureADv2SetAzureADUserLicenselicensePlansChoice), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserLicenselicensePlansCSV, nameof(azureADv2SetAzureADUserLicenselicensePlansCSV), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserLicenselicensesToRemoveCSV, nameof(azureADv2SetAzureADUserLicenselicensesToRemoveCSV), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserLicenseusageLocation, nameof(azureADv2SetAzureADUserLicenseusageLocation), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserLicenselocalScope, nameof(azureADv2SetAzureADUserLicenselocalScope), required: false);
            return new DeferredBodyAction<AzureADv2SetAzureADUserLicenseResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUserLicense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2SetAzureADUserLicense = new JObject();
                var azureADv2SetAzureADUserLicensepropCount = 0;
                azureADv2SetAzureADUserLicensepropCount++;
                azureADv2SetAzureADUserLicense["ObjectId"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenseobjectId);
                if (azureADv2SetAzureADUserLicenselicenseToAdd != null)
                {
                    azureADv2SetAzureADUserLicense["LicenseToAdd"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenselicenseToAdd);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                if (azureADv2SetAzureADUserLicenselicensePlansChoice != null)
                {
                    if (azureADv2SetAzureADUserLicenselicensePlansChoice != null)
                    {
                        azureADv2SetAzureADUserLicense["LicensePlansChoice"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenselicensePlansChoice);
                        azureADv2SetAzureADUserLicensepropCount++;
                    }

                    azureADv2SetAzureADUserLicensepropCount++;
                }
                else
                {
                    azureADv2SetAzureADUserLicense["LicensePlansChoice"] = "All";
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                if (azureADv2SetAzureADUserLicenselicensePlansCSV != null)
                {
                    azureADv2SetAzureADUserLicense["LicensePlansCSV"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenselicensePlansCSV);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                if (azureADv2SetAzureADUserLicenselicensesToRemoveCSV != null)
                {
                    azureADv2SetAzureADUserLicense["LicensesToRemoveCSV"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenselicensesToRemoveCSV);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                if (azureADv2SetAzureADUserLicenseusageLocation != null)
                {
                    azureADv2SetAzureADUserLicense["UsageLocation"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenseusageLocation);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                if (azureADv2SetAzureADUserLicenselocalScope != null)
                {
                    azureADv2SetAzureADUserLicense["LocalScope"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenselocalScope);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                azureADv2SetAzureADUserLicensepropCount++;
                azureADv2SetAzureADUserLicense["Workflow"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenseworkflow);
                if (azureADv2SetAzureADUserLicensepropCount > 0)
                {
                    callPayload.Body = azureADv2SetAzureADUserLicense;
                }

                return new ApiConnectionAction<AzureADv2SetAzureADUserLicenseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2GetAzureADUserLicenses))]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicensesResponse> AzureADv2GetAzureADUserLicenses([WorkflowExpression] Func<string> azureADv2GetAzureADUserLicensesobjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADUserLicensesworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicensesResponse> __BuildAzureADv2GetAzureADUserLicenses(WorkflowValue<string> azureADv2GetAzureADUserLicensesobjectId, WorkflowValue<string> azureADv2GetAzureADUserLicensesworkflow)
        {
            WorkflowValue.Validate(azureADv2GetAzureADUserLicensesobjectId, nameof(azureADv2GetAzureADUserLicensesobjectId), required: true);
            WorkflowValue.Validate(azureADv2GetAzureADUserLicensesworkflow, nameof(azureADv2GetAzureADUserLicensesworkflow), required: true);
            return new DeferredBodyAction<AzureADv2GetAzureADUserLicensesResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserLicenses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUserLicenses = new JObject();
                var azureADv2GetAzureADUserLicensespropCount = 0;
                azureADv2GetAzureADUserLicensespropCount++;
                azureADv2GetAzureADUserLicenses["ObjectId"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserLicensesobjectId);
                azureADv2GetAzureADUserLicensespropCount++;
                azureADv2GetAzureADUserLicenses["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserLicensesworkflow);
                if (azureADv2GetAzureADUserLicensespropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUserLicenses;
                }

                return new ApiConnectionAction<AzureADv2GetAzureADUserLicensesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2GetAzureADUserLicenseServicePlans))]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicenseServicePlansResponse> AzureADv2GetAzureADUserLicenseServicePlans([WorkflowExpression] Func<string> azureADv2GetAzureADUserLicenseServicePlansobjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber, [WorkflowExpression] Func<string> azureADv2GetAzureADUserLicenseServicePlansworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicenseServicePlansResponse> __BuildAzureADv2GetAzureADUserLicenseServicePlans(WorkflowValue<string> azureADv2GetAzureADUserLicenseServicePlansobjectId, WorkflowValue<string> azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber, WorkflowValue<string> azureADv2GetAzureADUserLicenseServicePlansworkflow)
        {
            WorkflowValue.Validate(azureADv2GetAzureADUserLicenseServicePlansobjectId, nameof(azureADv2GetAzureADUserLicenseServicePlansobjectId), required: true);
            WorkflowValue.Validate(azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber, nameof(azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber), required: true);
            WorkflowValue.Validate(azureADv2GetAzureADUserLicenseServicePlansworkflow, nameof(azureADv2GetAzureADUserLicenseServicePlansworkflow), required: true);
            return new DeferredBodyAction<AzureADv2GetAzureADUserLicenseServicePlansResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserLicenseServicePlans";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUserLicenseServicePlans = new JObject();
                var azureADv2GetAzureADUserLicenseServicePlanspropCount = 0;
                azureADv2GetAzureADUserLicenseServicePlanspropCount++;
                azureADv2GetAzureADUserLicenseServicePlans["ObjectId"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserLicenseServicePlansobjectId);
                azureADv2GetAzureADUserLicenseServicePlanspropCount++;
                azureADv2GetAzureADUserLicenseServicePlans["LicenseSKUPartNumber"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber);
                azureADv2GetAzureADUserLicenseServicePlanspropCount++;
                azureADv2GetAzureADUserLicenseServicePlans["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserLicenseServicePlansworkflow);
                if (azureADv2GetAzureADUserLicenseServicePlanspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUserLicenseServicePlans;
                }

                return new ApiConnectionAction<AzureADv2GetAzureADUserLicenseServicePlansResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2RemoveAllAzureADUserLicense))]
        public IBodyWorkflowAction<AzureADv2RemoveAllAzureADUserLicenseResponse> AzureADv2RemoveAllAzureADUserLicense([WorkflowExpression] Func<string> azureADv2RemoveAllAzureADUserLicenseobjectId, [WorkflowExpression] Func<string> azureADv2RemoveAllAzureADUserLicenseworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2RemoveAllAzureADUserLicenseResponse> __BuildAzureADv2RemoveAllAzureADUserLicense(WorkflowValue<string> azureADv2RemoveAllAzureADUserLicenseobjectId, WorkflowValue<string> azureADv2RemoveAllAzureADUserLicenseworkflow)
        {
            WorkflowValue.Validate(azureADv2RemoveAllAzureADUserLicenseobjectId, nameof(azureADv2RemoveAllAzureADUserLicenseobjectId), required: true);
            WorkflowValue.Validate(azureADv2RemoveAllAzureADUserLicenseworkflow, nameof(azureADv2RemoveAllAzureADUserLicenseworkflow), required: true);
            return new DeferredBodyAction<AzureADv2RemoveAllAzureADUserLicenseResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveAllAzureADUserLicense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveAllAzureADUserLicense = new JObject();
                var azureADv2RemoveAllAzureADUserLicensepropCount = 0;
                azureADv2RemoveAllAzureADUserLicensepropCount++;
                azureADv2RemoveAllAzureADUserLicense["ObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveAllAzureADUserLicenseobjectId);
                azureADv2RemoveAllAzureADUserLicensepropCount++;
                azureADv2RemoveAllAzureADUserLicense["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveAllAzureADUserLicenseworkflow);
                if (azureADv2RemoveAllAzureADUserLicensepropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveAllAzureADUserLicense;
                }

                return new ApiConnectionAction<AzureADv2RemoveAllAzureADUserLicenseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2SetAzureADUser))]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserResponse> AzureADv2SetAzureADUser([WorkflowExpression] Func<string> azureADv2SetAzureADUserobjectId, [WorkflowExpression] Func<string> azureADv2SetAzureADUserworkflow, [WorkflowExpression] Func<string> azureADv2SetAzureADUserfirstName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserlastName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserdisplayName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsercity = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsercompanyName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsercountry = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserdepartment = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserfaxNumber = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserjobTitle = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsermobilePhone = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUseroffice = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserphoneNumber = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserpostalCode = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserpreferredLanguage = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserstate = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserstreetAddress = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserusageLocation = null, [WorkflowExpression] Func<azureADv2SetAzureADUserageGroupInput> azureADv2SetAzureADUserageGroup = null, [WorkflowExpression] Func<azureADv2SetAzureADUserconsentProvidedForMinorInput> azureADv2SetAzureADUserconsentProvidedForMinor = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsermailNickName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUseremployeeId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserResponse> __BuildAzureADv2SetAzureADUser(WorkflowValue<string> azureADv2SetAzureADUserobjectId, WorkflowValue<string> azureADv2SetAzureADUserworkflow, WorkflowValue<string> azureADv2SetAzureADUserfirstName = null, WorkflowValue<string> azureADv2SetAzureADUserlastName = null, WorkflowValue<string> azureADv2SetAzureADUserdisplayName = null, WorkflowValue<string> azureADv2SetAzureADUsercity = null, WorkflowValue<string> azureADv2SetAzureADUsercompanyName = null, WorkflowValue<string> azureADv2SetAzureADUsercountry = null, WorkflowValue<string> azureADv2SetAzureADUserdepartment = null, WorkflowValue<string> azureADv2SetAzureADUserfaxNumber = null, WorkflowValue<string> azureADv2SetAzureADUserjobTitle = null, WorkflowValue<string> azureADv2SetAzureADUsermobilePhone = null, WorkflowValue<string> azureADv2SetAzureADUseroffice = null, WorkflowValue<string> azureADv2SetAzureADUserphoneNumber = null, WorkflowValue<string> azureADv2SetAzureADUserpostalCode = null, WorkflowValue<string> azureADv2SetAzureADUserpreferredLanguage = null, WorkflowValue<string> azureADv2SetAzureADUserstate = null, WorkflowValue<string> azureADv2SetAzureADUserstreetAddress = null, WorkflowValue<string> azureADv2SetAzureADUserusageLocation = null, WorkflowValue<azureADv2SetAzureADUserageGroupInput> azureADv2SetAzureADUserageGroup = null, WorkflowValue<azureADv2SetAzureADUserconsentProvidedForMinorInput> azureADv2SetAzureADUserconsentProvidedForMinor = null, WorkflowValue<string> azureADv2SetAzureADUsermailNickName = null, WorkflowValue<string> azureADv2SetAzureADUseremployeeId = null)
        {
            WorkflowValue.Validate(azureADv2SetAzureADUserobjectId, nameof(azureADv2SetAzureADUserobjectId), required: true);
            WorkflowValue.Validate(azureADv2SetAzureADUserworkflow, nameof(azureADv2SetAzureADUserworkflow), required: true);
            WorkflowValue.Validate(azureADv2SetAzureADUserfirstName, nameof(azureADv2SetAzureADUserfirstName), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserlastName, nameof(azureADv2SetAzureADUserlastName), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserdisplayName, nameof(azureADv2SetAzureADUserdisplayName), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUsercity, nameof(azureADv2SetAzureADUsercity), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUsercompanyName, nameof(azureADv2SetAzureADUsercompanyName), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUsercountry, nameof(azureADv2SetAzureADUsercountry), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserdepartment, nameof(azureADv2SetAzureADUserdepartment), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserfaxNumber, nameof(azureADv2SetAzureADUserfaxNumber), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserjobTitle, nameof(azureADv2SetAzureADUserjobTitle), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUsermobilePhone, nameof(azureADv2SetAzureADUsermobilePhone), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUseroffice, nameof(azureADv2SetAzureADUseroffice), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserphoneNumber, nameof(azureADv2SetAzureADUserphoneNumber), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserpostalCode, nameof(azureADv2SetAzureADUserpostalCode), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserpreferredLanguage, nameof(azureADv2SetAzureADUserpreferredLanguage), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserstate, nameof(azureADv2SetAzureADUserstate), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserstreetAddress, nameof(azureADv2SetAzureADUserstreetAddress), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserusageLocation, nameof(azureADv2SetAzureADUserusageLocation), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserageGroup, nameof(azureADv2SetAzureADUserageGroup), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUserconsentProvidedForMinor, nameof(azureADv2SetAzureADUserconsentProvidedForMinor), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUsermailNickName, nameof(azureADv2SetAzureADUsermailNickName), required: false);
            WorkflowValue.Validate(azureADv2SetAzureADUseremployeeId, nameof(azureADv2SetAzureADUseremployeeId), required: false);
            return new DeferredBodyAction<AzureADv2SetAzureADUserResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2SetAzureADUser = new JObject();
                var azureADv2SetAzureADUserpropCount = 0;
                azureADv2SetAzureADUserpropCount++;
                azureADv2SetAzureADUser["ObjectId"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserobjectId);
                if (azureADv2SetAzureADUserfirstName != null)
                {
                    azureADv2SetAzureADUser["FirstName"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserfirstName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserlastName != null)
                {
                    azureADv2SetAzureADUser["LastName"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserlastName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserdisplayName != null)
                {
                    azureADv2SetAzureADUser["DisplayName"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserdisplayName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUsercity != null)
                {
                    azureADv2SetAzureADUser["City"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUsercity);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUsercompanyName != null)
                {
                    azureADv2SetAzureADUser["CompanyName"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUsercompanyName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUsercountry != null)
                {
                    azureADv2SetAzureADUser["Country"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUsercountry);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserdepartment != null)
                {
                    azureADv2SetAzureADUser["Department"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserdepartment);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserfaxNumber != null)
                {
                    azureADv2SetAzureADUser["FaxNumber"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserfaxNumber);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserjobTitle != null)
                {
                    azureADv2SetAzureADUser["JobTitle"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserjobTitle);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUsermobilePhone != null)
                {
                    azureADv2SetAzureADUser["MobilePhone"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUsermobilePhone);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUseroffice != null)
                {
                    azureADv2SetAzureADUser["Office"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUseroffice);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserphoneNumber != null)
                {
                    azureADv2SetAzureADUser["PhoneNumber"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserphoneNumber);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserpostalCode != null)
                {
                    azureADv2SetAzureADUser["PostalCode"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserpostalCode);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserpreferredLanguage != null)
                {
                    azureADv2SetAzureADUser["PreferredLanguage"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserpreferredLanguage);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserstate != null)
                {
                    azureADv2SetAzureADUser["State"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserstate);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserstreetAddress != null)
                {
                    azureADv2SetAzureADUser["StreetAddress"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserstreetAddress);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserusageLocation != null)
                {
                    azureADv2SetAzureADUser["UsageLocation"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserusageLocation);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserageGroup != null)
                {
                    azureADv2SetAzureADUser["AgeGroup"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserageGroup);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserconsentProvidedForMinor != null)
                {
                    azureADv2SetAzureADUser["ConsentProvidedForMinor"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserconsentProvidedForMinor);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUsermailNickName != null)
                {
                    azureADv2SetAzureADUser["MailNickName"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUsermailNickName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUseremployeeId != null)
                {
                    azureADv2SetAzureADUser["EmployeeId"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUseremployeeId);
                    azureADv2SetAzureADUserpropCount++;
                }

                azureADv2SetAzureADUserpropCount++;
                azureADv2SetAzureADUser["Workflow"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserworkflow);
                if (azureADv2SetAzureADUserpropCount > 0)
                {
                    callPayload.Body = azureADv2SetAzureADUser;
                }

                return new ApiConnectionAction<AzureADv2SetAzureADUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2ResetAzureADUserProperties))]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPropertiesResponse> AzureADv2ResetAzureADUserProperties([WorkflowExpression] Func<string> azureADv2ResetAzureADUserPropertiesobjectId, [WorkflowExpression] Func<string> azureADv2ResetAzureADUserPropertiesworkflow, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetFirstName = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetLastName = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetCity = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetCompanyName = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetCountry = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetDepartment = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetFaxNumber = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetJobTitle = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetMobilePhone = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetOffice = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetPhoneNumber = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetPostalCode = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetPreferredLanguage = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetState = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetStreetAddress = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetUsageLocation = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetAgeGroup = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetEmployeeId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPropertiesResponse> __BuildAzureADv2ResetAzureADUserProperties(WorkflowValue<string> azureADv2ResetAzureADUserPropertiesobjectId, WorkflowValue<string> azureADv2ResetAzureADUserPropertiesworkflow, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetFirstName = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetLastName = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetCity = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetCompanyName = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetCountry = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetDepartment = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetFaxNumber = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetJobTitle = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetMobilePhone = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetOffice = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetPhoneNumber = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetPostalCode = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetPreferredLanguage = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetState = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetStreetAddress = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetUsageLocation = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetAgeGroup = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor = null, WorkflowValue<bool> azureADv2ResetAzureADUserPropertiesresetEmployeeId = null)
        {
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesobjectId, nameof(azureADv2ResetAzureADUserPropertiesobjectId), required: true);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesworkflow, nameof(azureADv2ResetAzureADUserPropertiesworkflow), required: true);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetFirstName, nameof(azureADv2ResetAzureADUserPropertiesresetFirstName), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetLastName, nameof(azureADv2ResetAzureADUserPropertiesresetLastName), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetCity, nameof(azureADv2ResetAzureADUserPropertiesresetCity), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetCompanyName, nameof(azureADv2ResetAzureADUserPropertiesresetCompanyName), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetCountry, nameof(azureADv2ResetAzureADUserPropertiesresetCountry), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetDepartment, nameof(azureADv2ResetAzureADUserPropertiesresetDepartment), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetFaxNumber, nameof(azureADv2ResetAzureADUserPropertiesresetFaxNumber), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetJobTitle, nameof(azureADv2ResetAzureADUserPropertiesresetJobTitle), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetMobilePhone, nameof(azureADv2ResetAzureADUserPropertiesresetMobilePhone), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetOffice, nameof(azureADv2ResetAzureADUserPropertiesresetOffice), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetPhoneNumber, nameof(azureADv2ResetAzureADUserPropertiesresetPhoneNumber), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetPostalCode, nameof(azureADv2ResetAzureADUserPropertiesresetPostalCode), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetPreferredLanguage, nameof(azureADv2ResetAzureADUserPropertiesresetPreferredLanguage), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetState, nameof(azureADv2ResetAzureADUserPropertiesresetState), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetStreetAddress, nameof(azureADv2ResetAzureADUserPropertiesresetStreetAddress), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetUsageLocation, nameof(azureADv2ResetAzureADUserPropertiesresetUsageLocation), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetAgeGroup, nameof(azureADv2ResetAzureADUserPropertiesresetAgeGroup), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor, nameof(azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor), required: false);
            WorkflowValue.Validate(azureADv2ResetAzureADUserPropertiesresetEmployeeId, nameof(azureADv2ResetAzureADUserPropertiesresetEmployeeId), required: false);
            return new DeferredBodyAction<AzureADv2ResetAzureADUserPropertiesResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2ResetAzureADUserProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2ResetAzureADUserProperties = new JObject();
                var azureADv2ResetAzureADUserPropertiespropCount = 0;
                azureADv2ResetAzureADUserPropertiespropCount++;
                azureADv2ResetAzureADUserProperties["ObjectId"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesobjectId);
                if (azureADv2ResetAzureADUserPropertiesresetFirstName != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetFirstName != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetFirstName"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetFirstName);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetFirstName"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetLastName != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetLastName != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetLastName"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetLastName);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetLastName"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetCity != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetCity != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetCity"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetCity);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetCity"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetCompanyName != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetCompanyName != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetCompanyName"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetCompanyName);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetCompanyName"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetCountry != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetCountry != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetCountry"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetCountry);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetCountry"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetDepartment != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetDepartment != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetDepartment"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetDepartment);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetDepartment"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetFaxNumber != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetFaxNumber != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetFaxNumber"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetFaxNumber);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetFaxNumber"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetJobTitle != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetJobTitle != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetJobTitle"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetJobTitle);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetJobTitle"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetMobilePhone != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetMobilePhone != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetMobilePhone"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetMobilePhone);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetMobilePhone"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetOffice != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetOffice != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetOffice"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetOffice);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetOffice"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetPhoneNumber != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetPhoneNumber != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetPhoneNumber"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetPhoneNumber);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetPhoneNumber"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetPostalCode != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetPostalCode != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetPostalCode"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetPostalCode);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetPostalCode"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetPreferredLanguage != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetPreferredLanguage != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetPreferredLanguage"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetPreferredLanguage);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetPreferredLanguage"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetState != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetState != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetState"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetState);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetState"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetStreetAddress != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetStreetAddress != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetStreetAddress"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetStreetAddress);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetStreetAddress"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetUsageLocation != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetUsageLocation != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetUsageLocation"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetUsageLocation);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetUsageLocation"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetAgeGroup != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetAgeGroup != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetAgeGroup"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetAgeGroup);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetAgeGroup"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetConsentProvidedForMinor"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor);
                        azureADv2ResetAzureADUserPropertiespropCount++;
                    }

                    azureADv2ResetAzureADUserPropertiespropCount++;
                }
                else
                {
                    azureADv2ResetAzureADUserProperties["ResetConsentProvidedForMinor"] = false;
                    azureADv2ResetAzureADUserPropertiespropCount++;
                }

                if (azureADv2ResetAzureADUserPropertiesresetEmployeeId != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetEmployeeId != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetEmployeeId"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesresetEmployeeId);
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
                azureADv2ResetAzureADUserProperties["Workflow"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesworkflow);
                if (azureADv2ResetAzureADUserPropertiespropCount > 0)
                {
                    callPayload.Body = azureADv2ResetAzureADUserProperties;
                }

                return new ApiConnectionAction<AzureADv2ResetAzureADUserPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2SetAzureADUserManager))]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserManagerResponse> AzureADv2SetAzureADUserManager([WorkflowExpression] Func<string> azureADv2SetAzureADUserManagerobjectId, [WorkflowExpression] Func<string> azureADv2SetAzureADUserManagerworkflow, [WorkflowExpression] Func<string> azureADv2SetAzureADUserManagermanager = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserManagerResponse> __BuildAzureADv2SetAzureADUserManager(WorkflowValue<string> azureADv2SetAzureADUserManagerobjectId, WorkflowValue<string> azureADv2SetAzureADUserManagerworkflow, WorkflowValue<string> azureADv2SetAzureADUserManagermanager = null)
        {
            WorkflowValue.Validate(azureADv2SetAzureADUserManagerobjectId, nameof(azureADv2SetAzureADUserManagerobjectId), required: true);
            WorkflowValue.Validate(azureADv2SetAzureADUserManagerworkflow, nameof(azureADv2SetAzureADUserManagerworkflow), required: true);
            WorkflowValue.Validate(azureADv2SetAzureADUserManagermanager, nameof(azureADv2SetAzureADUserManagermanager), required: false);
            return new DeferredBodyAction<AzureADv2SetAzureADUserManagerResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUserManager";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2SetAzureADUserManager = new JObject();
                var azureADv2SetAzureADUserManagerpropCount = 0;
                azureADv2SetAzureADUserManagerpropCount++;
                azureADv2SetAzureADUserManager["ObjectId"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserManagerobjectId);
                if (azureADv2SetAzureADUserManagermanager != null)
                {
                    azureADv2SetAzureADUserManager["Manager"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserManagermanager);
                    azureADv2SetAzureADUserManagerpropCount++;
                }

                azureADv2SetAzureADUserManagerpropCount++;
                azureADv2SetAzureADUserManager["Workflow"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserManagerworkflow);
                if (azureADv2SetAzureADUserManagerpropCount > 0)
                {
                    callPayload.Body = azureADv2SetAzureADUserManager;
                }

                return new ApiConnectionAction<AzureADv2SetAzureADUserManagerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2NewSecurityGroup))]
        public IBodyWorkflowAction<AzureADv2NewSecurityGroupResponse> AzureADv2NewSecurityGroup([WorkflowExpression] Func<string> azureADv2NewSecurityGroupdisplayName, [WorkflowExpression] Func<string> azureADv2NewSecurityGroupworkflow, [WorkflowExpression] Func<string> azureADv2NewSecurityGroupdescription = null, [WorkflowExpression] Func<bool> azureADv2NewSecurityGroupcheckGroupExists = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2NewSecurityGroupResponse> __BuildAzureADv2NewSecurityGroup(WorkflowValue<string> azureADv2NewSecurityGroupdisplayName, WorkflowValue<string> azureADv2NewSecurityGroupworkflow, WorkflowValue<string> azureADv2NewSecurityGroupdescription = null, WorkflowValue<bool> azureADv2NewSecurityGroupcheckGroupExists = null)
        {
            WorkflowValue.Validate(azureADv2NewSecurityGroupdisplayName, nameof(azureADv2NewSecurityGroupdisplayName), required: true);
            WorkflowValue.Validate(azureADv2NewSecurityGroupworkflow, nameof(azureADv2NewSecurityGroupworkflow), required: true);
            WorkflowValue.Validate(azureADv2NewSecurityGroupdescription, nameof(azureADv2NewSecurityGroupdescription), required: false);
            WorkflowValue.Validate(azureADv2NewSecurityGroupcheckGroupExists, nameof(azureADv2NewSecurityGroupcheckGroupExists), required: false);
            return new DeferredBodyAction<AzureADv2NewSecurityGroupResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2NewSecurityGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2NewSecurityGroup = new JObject();
                var azureADv2NewSecurityGrouppropCount = 0;
                azureADv2NewSecurityGrouppropCount++;
                azureADv2NewSecurityGroup["DisplayName"] = ExpressionConverter.ConvertO(azureADv2NewSecurityGroupdisplayName);
                if (azureADv2NewSecurityGroupdescription != null)
                {
                    azureADv2NewSecurityGroup["Description"] = ExpressionConverter.ConvertO(azureADv2NewSecurityGroupdescription);
                    azureADv2NewSecurityGrouppropCount++;
                }

                if (azureADv2NewSecurityGroupcheckGroupExists != null)
                {
                    if (azureADv2NewSecurityGroupcheckGroupExists != null)
                    {
                        azureADv2NewSecurityGroup["CheckGroupExists"] = ExpressionConverter.ConvertO(azureADv2NewSecurityGroupcheckGroupExists);
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
                azureADv2NewSecurityGroup["Workflow"] = ExpressionConverter.ConvertO(azureADv2NewSecurityGroupworkflow);
                if (azureADv2NewSecurityGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2NewSecurityGroup;
                }

                return new ApiConnectionAction<AzureADv2NewSecurityGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2RemoveSecurityGroup))]
        public IBodyWorkflowAction<AzureADv2RemoveSecurityGroupResponse> AzureADv2RemoveSecurityGroup([WorkflowExpression] Func<string> azureADv2RemoveSecurityGroupgroupObjectId, [WorkflowExpression] Func<string> azureADv2RemoveSecurityGroupworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2RemoveSecurityGroupResponse> __BuildAzureADv2RemoveSecurityGroup(WorkflowValue<string> azureADv2RemoveSecurityGroupgroupObjectId, WorkflowValue<string> azureADv2RemoveSecurityGroupworkflow, WorkflowValue<bool> azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist = null)
        {
            WorkflowValue.Validate(azureADv2RemoveSecurityGroupgroupObjectId, nameof(azureADv2RemoveSecurityGroupgroupObjectId), required: true);
            WorkflowValue.Validate(azureADv2RemoveSecurityGroupworkflow, nameof(azureADv2RemoveSecurityGroupworkflow), required: true);
            WorkflowValue.Validate(azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist, nameof(azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist), required: false);
            return new DeferredBodyAction<AzureADv2RemoveSecurityGroupResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveSecurityGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveSecurityGroup = new JObject();
                var azureADv2RemoveSecurityGrouppropCount = 0;
                azureADv2RemoveSecurityGrouppropCount++;
                azureADv2RemoveSecurityGroup["GroupObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveSecurityGroupgroupObjectId);
                if (azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist != null)
                {
                    if (azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist != null)
                    {
                        azureADv2RemoveSecurityGroup["ErrorIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist);
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
                azureADv2RemoveSecurityGroup["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveSecurityGroupworkflow);
                if (azureADv2RemoveSecurityGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveSecurityGroup;
                }

                return new ApiConnectionAction<AzureADv2RemoveSecurityGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2NewMicrosoft365Group))]
        public IBodyWorkflowAction<AzureADv2NewMicrosoft365GroupResponse> AzureADv2NewMicrosoft365Group([WorkflowExpression] Func<string> azureADv2NewMicrosoft365GroupdisplayName, [WorkflowExpression] Func<string> azureADv2NewMicrosoft365Groupworkflow, [WorkflowExpression] Func<string> azureADv2NewMicrosoft365Groupdescription = null, [WorkflowExpression] Func<string> azureADv2NewMicrosoft365GroupmailNickname = null, [WorkflowExpression] Func<azureADv2NewMicrosoft365GroupgroupVisibilityInput> azureADv2NewMicrosoft365GroupgroupVisibility = null, [WorkflowExpression] Func<bool> azureADv2NewMicrosoft365GroupcheckGroupExists = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2NewMicrosoft365GroupResponse> __BuildAzureADv2NewMicrosoft365Group(WorkflowValue<string> azureADv2NewMicrosoft365GroupdisplayName, WorkflowValue<string> azureADv2NewMicrosoft365Groupworkflow, WorkflowValue<string> azureADv2NewMicrosoft365Groupdescription = null, WorkflowValue<string> azureADv2NewMicrosoft365GroupmailNickname = null, WorkflowValue<azureADv2NewMicrosoft365GroupgroupVisibilityInput> azureADv2NewMicrosoft365GroupgroupVisibility = null, WorkflowValue<bool> azureADv2NewMicrosoft365GroupcheckGroupExists = null)
        {
            WorkflowValue.Validate(azureADv2NewMicrosoft365GroupdisplayName, nameof(azureADv2NewMicrosoft365GroupdisplayName), required: true);
            WorkflowValue.Validate(azureADv2NewMicrosoft365Groupworkflow, nameof(azureADv2NewMicrosoft365Groupworkflow), required: true);
            WorkflowValue.Validate(azureADv2NewMicrosoft365Groupdescription, nameof(azureADv2NewMicrosoft365Groupdescription), required: false);
            WorkflowValue.Validate(azureADv2NewMicrosoft365GroupmailNickname, nameof(azureADv2NewMicrosoft365GroupmailNickname), required: false);
            WorkflowValue.Validate(azureADv2NewMicrosoft365GroupgroupVisibility, nameof(azureADv2NewMicrosoft365GroupgroupVisibility), required: false);
            WorkflowValue.Validate(azureADv2NewMicrosoft365GroupcheckGroupExists, nameof(azureADv2NewMicrosoft365GroupcheckGroupExists), required: false);
            return new DeferredBodyAction<AzureADv2NewMicrosoft365GroupResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2NewMicrosoft365Group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2NewMicrosoft365Group = new JObject();
                var azureADv2NewMicrosoft365GrouppropCount = 0;
                azureADv2NewMicrosoft365GrouppropCount++;
                azureADv2NewMicrosoft365Group["DisplayName"] = ExpressionConverter.ConvertO(azureADv2NewMicrosoft365GroupdisplayName);
                if (azureADv2NewMicrosoft365Groupdescription != null)
                {
                    azureADv2NewMicrosoft365Group["Description"] = ExpressionConverter.ConvertO(azureADv2NewMicrosoft365Groupdescription);
                    azureADv2NewMicrosoft365GrouppropCount++;
                }

                if (azureADv2NewMicrosoft365GroupmailNickname != null)
                {
                    azureADv2NewMicrosoft365Group["MailNickname"] = ExpressionConverter.ConvertO(azureADv2NewMicrosoft365GroupmailNickname);
                    azureADv2NewMicrosoft365GrouppropCount++;
                }

                if (azureADv2NewMicrosoft365GroupgroupVisibility != null)
                {
                    if (azureADv2NewMicrosoft365GroupgroupVisibility != null)
                    {
                        azureADv2NewMicrosoft365Group["GroupVisibility"] = ExpressionConverter.ConvertO(azureADv2NewMicrosoft365GroupgroupVisibility);
                        azureADv2NewMicrosoft365GrouppropCount++;
                    }

                    azureADv2NewMicrosoft365GrouppropCount++;
                }
                else
                {
                    azureADv2NewMicrosoft365Group["GroupVisibility"] = "Public";
                    azureADv2NewMicrosoft365GrouppropCount++;
                }

                if (azureADv2NewMicrosoft365GroupcheckGroupExists != null)
                {
                    if (azureADv2NewMicrosoft365GroupcheckGroupExists != null)
                    {
                        azureADv2NewMicrosoft365Group["CheckGroupExists"] = ExpressionConverter.ConvertO(azureADv2NewMicrosoft365GroupcheckGroupExists);
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
                azureADv2NewMicrosoft365Group["Workflow"] = ExpressionConverter.ConvertO(azureADv2NewMicrosoft365Groupworkflow);
                if (azureADv2NewMicrosoft365GrouppropCount > 0)
                {
                    callPayload.Body = azureADv2NewMicrosoft365Group;
                }

                return new ApiConnectionAction<AzureADv2NewMicrosoft365GroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2GetGroups))]
        public IBodyWorkflowAction<AzureADv2GetGroupsResponse> AzureADv2GetGroups([WorkflowExpression] Func<string> azureADv2GetGroupsworkflow, [WorkflowExpression] Func<string> azureADv2GetGroupsobjectId = null, [WorkflowExpression] Func<string> azureADv2GetGroupsfilterPropertyName = null, [WorkflowExpression] Func<azureADv2GetGroupsfilterPropertyComparisonInput> azureADv2GetGroupsfilterPropertyComparison = null, [WorkflowExpression] Func<string> azureADv2GetGroupsfilterPropertyValue = null, [WorkflowExpression] Func<bool> azureADv2GetGroupsnoResultIsAnException = null, [WorkflowExpression] Func<string> azureADv2GetGroupspropertiesToReturn = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2GetGroupsResponse> __BuildAzureADv2GetGroups(WorkflowValue<string> azureADv2GetGroupsworkflow, WorkflowValue<string> azureADv2GetGroupsobjectId = null, WorkflowValue<string> azureADv2GetGroupsfilterPropertyName = null, WorkflowValue<azureADv2GetGroupsfilterPropertyComparisonInput> azureADv2GetGroupsfilterPropertyComparison = null, WorkflowValue<string> azureADv2GetGroupsfilterPropertyValue = null, WorkflowValue<bool> azureADv2GetGroupsnoResultIsAnException = null, WorkflowValue<string> azureADv2GetGroupspropertiesToReturn = null)
        {
            WorkflowValue.Validate(azureADv2GetGroupsworkflow, nameof(azureADv2GetGroupsworkflow), required: true);
            WorkflowValue.Validate(azureADv2GetGroupsobjectId, nameof(azureADv2GetGroupsobjectId), required: false);
            WorkflowValue.Validate(azureADv2GetGroupsfilterPropertyName, nameof(azureADv2GetGroupsfilterPropertyName), required: false);
            WorkflowValue.Validate(azureADv2GetGroupsfilterPropertyComparison, nameof(azureADv2GetGroupsfilterPropertyComparison), required: false);
            WorkflowValue.Validate(azureADv2GetGroupsfilterPropertyValue, nameof(azureADv2GetGroupsfilterPropertyValue), required: false);
            WorkflowValue.Validate(azureADv2GetGroupsnoResultIsAnException, nameof(azureADv2GetGroupsnoResultIsAnException), required: false);
            WorkflowValue.Validate(azureADv2GetGroupspropertiesToReturn, nameof(azureADv2GetGroupspropertiesToReturn), required: false);
            return new DeferredBodyAction<AzureADv2GetGroupsResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetGroups = new JObject();
                var azureADv2GetGroupspropCount = 0;
                if (azureADv2GetGroupsobjectId != null)
                {
                    azureADv2GetGroups["ObjectId"] = ExpressionConverter.ConvertO(azureADv2GetGroupsobjectId);
                    azureADv2GetGroupspropCount++;
                }

                if (azureADv2GetGroupsfilterPropertyName != null)
                {
                    azureADv2GetGroups["FilterPropertyName"] = ExpressionConverter.ConvertO(azureADv2GetGroupsfilterPropertyName);
                    azureADv2GetGroupspropCount++;
                }

                if (azureADv2GetGroupsfilterPropertyComparison != null)
                {
                    if (azureADv2GetGroupsfilterPropertyComparison != null)
                    {
                        azureADv2GetGroups["FilterPropertyComparison"] = ExpressionConverter.ConvertO(azureADv2GetGroupsfilterPropertyComparison);
                        azureADv2GetGroupspropCount++;
                    }

                    azureADv2GetGroupspropCount++;
                }
                else
                {
                    azureADv2GetGroups["FilterPropertyComparison"] = "Equals";
                    azureADv2GetGroupspropCount++;
                }

                if (azureADv2GetGroupsfilterPropertyValue != null)
                {
                    azureADv2GetGroups["FilterPropertyValue"] = ExpressionConverter.ConvertO(azureADv2GetGroupsfilterPropertyValue);
                    azureADv2GetGroupspropCount++;
                }

                if (azureADv2GetGroupsnoResultIsAnException != null)
                {
                    if (azureADv2GetGroupsnoResultIsAnException != null)
                    {
                        azureADv2GetGroups["NoResultIsAnException"] = ExpressionConverter.ConvertO(azureADv2GetGroupsnoResultIsAnException);
                        azureADv2GetGroupspropCount++;
                    }

                    azureADv2GetGroupspropCount++;
                }
                else
                {
                    azureADv2GetGroups["NoResultIsAnException"] = false;
                    azureADv2GetGroupspropCount++;
                }

                if (azureADv2GetGroupspropertiesToReturn != null)
                {
                    azureADv2GetGroups["PropertiesToReturn"] = ExpressionConverter.ConvertO(azureADv2GetGroupspropertiesToReturn);
                    azureADv2GetGroupspropCount++;
                }

                azureADv2GetGroupspropCount++;
                azureADv2GetGroups["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetGroupsworkflow);
                if (azureADv2GetGroupspropCount > 0)
                {
                    callPayload.Body = azureADv2GetGroups;
                }

                return new ApiConnectionAction<AzureADv2GetGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2EnableUser))]
        public IBodyWorkflowAction<AzureADv2EnableUserResponse> AzureADv2EnableUser([WorkflowExpression] Func<string> azureADv2EnableUseruserObjectId, [WorkflowExpression] Func<string> azureADv2EnableUserworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2EnableUserResponse> __BuildAzureADv2EnableUser(WorkflowValue<string> azureADv2EnableUseruserObjectId, WorkflowValue<string> azureADv2EnableUserworkflow)
        {
            WorkflowValue.Validate(azureADv2EnableUseruserObjectId, nameof(azureADv2EnableUseruserObjectId), required: true);
            WorkflowValue.Validate(azureADv2EnableUserworkflow, nameof(azureADv2EnableUserworkflow), required: true);
            return new DeferredBodyAction<AzureADv2EnableUserResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2EnableUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2EnableUser = new JObject();
                var azureADv2EnableUserpropCount = 0;
                azureADv2EnableUserpropCount++;
                azureADv2EnableUser["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2EnableUseruserObjectId);
                azureADv2EnableUserpropCount++;
                azureADv2EnableUser["Workflow"] = ExpressionConverter.ConvertO(azureADv2EnableUserworkflow);
                if (azureADv2EnableUserpropCount > 0)
                {
                    callPayload.Body = azureADv2EnableUser;
                }

                return new ApiConnectionAction<AzureADv2EnableUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2DisableUser))]
        public IBodyWorkflowAction<AzureADv2DisableUserResponse> AzureADv2DisableUser([WorkflowExpression] Func<string> azureADv2DisableUseruserObjectId, [WorkflowExpression] Func<string> azureADv2DisableUserworkflow, [WorkflowExpression] Func<bool> azureADv2DisableUserrevokeUserRefreshTokens = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2DisableUserResponse> __BuildAzureADv2DisableUser(WorkflowValue<string> azureADv2DisableUseruserObjectId, WorkflowValue<string> azureADv2DisableUserworkflow, WorkflowValue<bool> azureADv2DisableUserrevokeUserRefreshTokens = null)
        {
            WorkflowValue.Validate(azureADv2DisableUseruserObjectId, nameof(azureADv2DisableUseruserObjectId), required: true);
            WorkflowValue.Validate(azureADv2DisableUserworkflow, nameof(azureADv2DisableUserworkflow), required: true);
            WorkflowValue.Validate(azureADv2DisableUserrevokeUserRefreshTokens, nameof(azureADv2DisableUserrevokeUserRefreshTokens), required: false);
            return new DeferredBodyAction<AzureADv2DisableUserResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2DisableUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2DisableUser = new JObject();
                var azureADv2DisableUserpropCount = 0;
                azureADv2DisableUserpropCount++;
                azureADv2DisableUser["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2DisableUseruserObjectId);
                if (azureADv2DisableUserrevokeUserRefreshTokens != null)
                {
                    if (azureADv2DisableUserrevokeUserRefreshTokens != null)
                    {
                        azureADv2DisableUser["RevokeUserRefreshTokens"] = ExpressionConverter.ConvertO(azureADv2DisableUserrevokeUserRefreshTokens);
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
                azureADv2DisableUser["Workflow"] = ExpressionConverter.ConvertO(azureADv2DisableUserworkflow);
                if (azureADv2DisableUserpropCount > 0)
                {
                    callPayload.Body = azureADv2DisableUser;
                }

                return new ApiConnectionAction<AzureADv2DisableUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2AssignUserToRole))]
        public IBodyWorkflowAction<AzureADv2AssignUserToRoleResponse> AzureADv2AssignUserToRole([WorkflowExpression] Func<string> azureADv2AssignUserToRoleuserObjectId, [WorkflowExpression] Func<string> azureADv2AssignUserToRoleroleObjectId, [WorkflowExpression] Func<string> azureADv2AssignUserToRoleworkflow, [WorkflowExpression] Func<string> azureADv2AssignUserToRoledirectoryScopeId = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToRolecheckUserRoleMembershipsFirst = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2AssignUserToRoleResponse> __BuildAzureADv2AssignUserToRole(WorkflowValue<string> azureADv2AssignUserToRoleuserObjectId, WorkflowValue<string> azureADv2AssignUserToRoleroleObjectId, WorkflowValue<string> azureADv2AssignUserToRoleworkflow, WorkflowValue<string> azureADv2AssignUserToRoledirectoryScopeId = null, WorkflowValue<bool> azureADv2AssignUserToRolecheckUserRoleMembershipsFirst = null)
        {
            WorkflowValue.Validate(azureADv2AssignUserToRoleuserObjectId, nameof(azureADv2AssignUserToRoleuserObjectId), required: true);
            WorkflowValue.Validate(azureADv2AssignUserToRoleroleObjectId, nameof(azureADv2AssignUserToRoleroleObjectId), required: true);
            WorkflowValue.Validate(azureADv2AssignUserToRoleworkflow, nameof(azureADv2AssignUserToRoleworkflow), required: true);
            WorkflowValue.Validate(azureADv2AssignUserToRoledirectoryScopeId, nameof(azureADv2AssignUserToRoledirectoryScopeId), required: false);
            WorkflowValue.Validate(azureADv2AssignUserToRolecheckUserRoleMembershipsFirst, nameof(azureADv2AssignUserToRolecheckUserRoleMembershipsFirst), required: false);
            return new DeferredBodyAction<AzureADv2AssignUserToRoleResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AssignUserToRole";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AssignUserToRole = new JObject();
                var azureADv2AssignUserToRolepropCount = 0;
                azureADv2AssignUserToRolepropCount++;
                azureADv2AssignUserToRole["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2AssignUserToRoleuserObjectId);
                azureADv2AssignUserToRolepropCount++;
                azureADv2AssignUserToRole["RoleObjectId"] = ExpressionConverter.ConvertO(azureADv2AssignUserToRoleroleObjectId);
                if (azureADv2AssignUserToRoledirectoryScopeId != null)
                {
                    if (azureADv2AssignUserToRoledirectoryScopeId != null)
                    {
                        azureADv2AssignUserToRole["DirectoryScopeId"] = ExpressionConverter.ConvertO(azureADv2AssignUserToRoledirectoryScopeId);
                        azureADv2AssignUserToRolepropCount++;
                    }

                    azureADv2AssignUserToRolepropCount++;
                }
                else
                {
                    azureADv2AssignUserToRole["DirectoryScopeId"] = "/";
                    azureADv2AssignUserToRolepropCount++;
                }

                if (azureADv2AssignUserToRolecheckUserRoleMembershipsFirst != null)
                {
                    if (azureADv2AssignUserToRolecheckUserRoleMembershipsFirst != null)
                    {
                        azureADv2AssignUserToRole["CheckUserRoleMembershipsFirst"] = ExpressionConverter.ConvertO(azureADv2AssignUserToRolecheckUserRoleMembershipsFirst);
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
                azureADv2AssignUserToRole["Workflow"] = ExpressionConverter.ConvertO(azureADv2AssignUserToRoleworkflow);
                if (azureADv2AssignUserToRolepropCount > 0)
                {
                    callPayload.Body = azureADv2AssignUserToRole;
                }

                return new ApiConnectionAction<AzureADv2AssignUserToRoleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2AssignUserToMultipleRoles))]
        public IBodyWorkflowAction<AzureADv2AssignUserToMultipleRolesResponse> AzureADv2AssignUserToMultipleRoles([WorkflowExpression] Func<string> azureADv2AssignUserToMultipleRolesuserObjectId, [WorkflowExpression] Func<string> azureADv2AssignUserToMultipleRolesworkflow, [WorkflowExpression] Func<string> azureADv2AssignUserToMultipleRolesrolesJSON = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign = null, [WorkflowExpression] Func<string> azureADv2AssignUserToMultipleRolesdirectoryScopeId = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToMultipleRolescheckRoleIdsExist = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2AssignUserToMultipleRolesResponse> __BuildAzureADv2AssignUserToMultipleRoles(WorkflowValue<string> azureADv2AssignUserToMultipleRolesuserObjectId, WorkflowValue<string> azureADv2AssignUserToMultipleRolesworkflow, WorkflowValue<string> azureADv2AssignUserToMultipleRolesrolesJSON = null, WorkflowValue<bool> azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign = null, WorkflowValue<bool> azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign = null, WorkflowValue<string> azureADv2AssignUserToMultipleRolesdirectoryScopeId = null, WorkflowValue<bool> azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst = null, WorkflowValue<bool> azureADv2AssignUserToMultipleRolescheckRoleIdsExist = null)
        {
            WorkflowValue.Validate(azureADv2AssignUserToMultipleRolesuserObjectId, nameof(azureADv2AssignUserToMultipleRolesuserObjectId), required: true);
            WorkflowValue.Validate(azureADv2AssignUserToMultipleRolesworkflow, nameof(azureADv2AssignUserToMultipleRolesworkflow), required: true);
            WorkflowValue.Validate(azureADv2AssignUserToMultipleRolesrolesJSON, nameof(azureADv2AssignUserToMultipleRolesrolesJSON), required: false);
            WorkflowValue.Validate(azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign, nameof(azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign), required: false);
            WorkflowValue.Validate(azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign, nameof(azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign), required: false);
            WorkflowValue.Validate(azureADv2AssignUserToMultipleRolesdirectoryScopeId, nameof(azureADv2AssignUserToMultipleRolesdirectoryScopeId), required: false);
            WorkflowValue.Validate(azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst, nameof(azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst), required: false);
            WorkflowValue.Validate(azureADv2AssignUserToMultipleRolescheckRoleIdsExist, nameof(azureADv2AssignUserToMultipleRolescheckRoleIdsExist), required: false);
            return new DeferredBodyAction<AzureADv2AssignUserToMultipleRolesResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AssignUserToMultipleRoles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AssignUserToMultipleRoles = new JObject();
                var azureADv2AssignUserToMultipleRolespropCount = 0;
                azureADv2AssignUserToMultipleRolespropCount++;
                azureADv2AssignUserToMultipleRoles["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolesuserObjectId);
                if (azureADv2AssignUserToMultipleRolesrolesJSON != null)
                {
                    azureADv2AssignUserToMultipleRoles["RolesJSON"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolesrolesJSON);
                    azureADv2AssignUserToMultipleRolespropCount++;
                }

                if (azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign != null)
                {
                    if (azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign != null)
                    {
                        azureADv2AssignUserToMultipleRoles["ExceptionIfAnyRolesFailToAssign"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign);
                        azureADv2AssignUserToMultipleRolespropCount++;
                    }

                    azureADv2AssignUserToMultipleRolespropCount++;
                }
                else
                {
                    azureADv2AssignUserToMultipleRoles["ExceptionIfAnyRolesFailToAssign"] = false;
                    azureADv2AssignUserToMultipleRolespropCount++;
                }

                if (azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign != null)
                {
                    if (azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign != null)
                    {
                        azureADv2AssignUserToMultipleRoles["ExceptionIfAllRolesFailToAssign"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign);
                        azureADv2AssignUserToMultipleRolespropCount++;
                    }

                    azureADv2AssignUserToMultipleRolespropCount++;
                }
                else
                {
                    azureADv2AssignUserToMultipleRoles["ExceptionIfAllRolesFailToAssign"] = false;
                    azureADv2AssignUserToMultipleRolespropCount++;
                }

                if (azureADv2AssignUserToMultipleRolesdirectoryScopeId != null)
                {
                    if (azureADv2AssignUserToMultipleRolesdirectoryScopeId != null)
                    {
                        azureADv2AssignUserToMultipleRoles["DirectoryScopeId"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolesdirectoryScopeId);
                        azureADv2AssignUserToMultipleRolespropCount++;
                    }

                    azureADv2AssignUserToMultipleRolespropCount++;
                }
                else
                {
                    azureADv2AssignUserToMultipleRoles["DirectoryScopeId"] = "/";
                    azureADv2AssignUserToMultipleRolespropCount++;
                }

                if (azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst != null)
                {
                    if (azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst != null)
                    {
                        azureADv2AssignUserToMultipleRoles["CheckUserRoleMembershipsFirst"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst);
                        azureADv2AssignUserToMultipleRolespropCount++;
                    }

                    azureADv2AssignUserToMultipleRolespropCount++;
                }
                else
                {
                    azureADv2AssignUserToMultipleRoles["CheckUserRoleMembershipsFirst"] = true;
                    azureADv2AssignUserToMultipleRolespropCount++;
                }

                if (azureADv2AssignUserToMultipleRolescheckRoleIdsExist != null)
                {
                    if (azureADv2AssignUserToMultipleRolescheckRoleIdsExist != null)
                    {
                        azureADv2AssignUserToMultipleRoles["CheckRoleIdsExist"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolescheckRoleIdsExist);
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
                azureADv2AssignUserToMultipleRoles["Workflow"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolesworkflow);
                if (azureADv2AssignUserToMultipleRolespropCount > 0)
                {
                    callPayload.Body = azureADv2AssignUserToMultipleRoles;
                }

                return new ApiConnectionAction<AzureADv2AssignUserToMultipleRolesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2RemoveUserFromMultipleRoles))]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromMultipleRolesResponse> AzureADv2RemoveUserFromMultipleRoles([WorkflowExpression] Func<string> azureADv2RemoveUserFromMultipleRolesuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromMultipleRolesworkflow, [WorkflowExpression] Func<string> azureADv2RemoveUserFromMultipleRolesrolesJSON = null, [WorkflowExpression] Func<string> azureADv2RemoveUserFromMultipleRolesdirectoryScopeId = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromMultipleRolesResponse> __BuildAzureADv2RemoveUserFromMultipleRoles(WorkflowValue<string> azureADv2RemoveUserFromMultipleRolesuserObjectId, WorkflowValue<string> azureADv2RemoveUserFromMultipleRolesworkflow, WorkflowValue<string> azureADv2RemoveUserFromMultipleRolesrolesJSON = null, WorkflowValue<string> azureADv2RemoveUserFromMultipleRolesdirectoryScopeId = null, WorkflowValue<bool> azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove = null, WorkflowValue<bool> azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove = null, WorkflowValue<bool> azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist = null)
        {
            WorkflowValue.Validate(azureADv2RemoveUserFromMultipleRolesuserObjectId, nameof(azureADv2RemoveUserFromMultipleRolesuserObjectId), required: true);
            WorkflowValue.Validate(azureADv2RemoveUserFromMultipleRolesworkflow, nameof(azureADv2RemoveUserFromMultipleRolesworkflow), required: true);
            WorkflowValue.Validate(azureADv2RemoveUserFromMultipleRolesrolesJSON, nameof(azureADv2RemoveUserFromMultipleRolesrolesJSON), required: false);
            WorkflowValue.Validate(azureADv2RemoveUserFromMultipleRolesdirectoryScopeId, nameof(azureADv2RemoveUserFromMultipleRolesdirectoryScopeId), required: false);
            WorkflowValue.Validate(azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove, nameof(azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove), required: false);
            WorkflowValue.Validate(azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove, nameof(azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove), required: false);
            WorkflowValue.Validate(azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist, nameof(azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist), required: false);
            return new DeferredBodyAction<AzureADv2RemoveUserFromMultipleRolesResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromMultipleRoles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromMultipleRoles = new JObject();
                var azureADv2RemoveUserFromMultipleRolespropCount = 0;
                azureADv2RemoveUserFromMultipleRolespropCount++;
                azureADv2RemoveUserFromMultipleRoles["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromMultipleRolesuserObjectId);
                if (azureADv2RemoveUserFromMultipleRolesrolesJSON != null)
                {
                    azureADv2RemoveUserFromMultipleRoles["RolesJSON"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromMultipleRolesrolesJSON);
                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }

                if (azureADv2RemoveUserFromMultipleRolesdirectoryScopeId != null)
                {
                    if (azureADv2RemoveUserFromMultipleRolesdirectoryScopeId != null)
                    {
                        azureADv2RemoveUserFromMultipleRoles["DirectoryScopeId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromMultipleRolesdirectoryScopeId);
                        azureADv2RemoveUserFromMultipleRolespropCount++;
                    }

                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromMultipleRoles["DirectoryScopeId"] = "*";
                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }

                if (azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove != null)
                {
                    if (azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove != null)
                    {
                        azureADv2RemoveUserFromMultipleRoles["ExceptionIfAnyRolesFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove);
                        azureADv2RemoveUserFromMultipleRolespropCount++;
                    }

                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromMultipleRoles["ExceptionIfAnyRolesFailToRemove"] = false;
                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }

                if (azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove != null)
                {
                    if (azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove != null)
                    {
                        azureADv2RemoveUserFromMultipleRoles["ExceptionIfAllRolesFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove);
                        azureADv2RemoveUserFromMultipleRolespropCount++;
                    }

                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromMultipleRoles["ExceptionIfAllRolesFailToRemove"] = false;
                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }

                if (azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist != null)
                {
                    if (azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist != null)
                    {
                        azureADv2RemoveUserFromMultipleRoles["ExceptionIfRoleDoesNotExist"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist);
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
                azureADv2RemoveUserFromMultipleRoles["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromMultipleRolesworkflow);
                if (azureADv2RemoveUserFromMultipleRolespropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromMultipleRoles;
                }

                return new ApiConnectionAction<AzureADv2RemoveUserFromMultipleRolesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2IsUserInRole))]
        public IBodyWorkflowAction<AzureADv2IsUserInRoleResponse> AzureADv2IsUserInRole([WorkflowExpression] Func<string> azureADv2IsUserInRoleuserObjectId, [WorkflowExpression] Func<string> azureADv2IsUserInRoleroleObjectId, [WorkflowExpression] Func<string> azureADv2IsUserInRoleworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2IsUserInRoleResponse> __BuildAzureADv2IsUserInRole(WorkflowValue<string> azureADv2IsUserInRoleuserObjectId, WorkflowValue<string> azureADv2IsUserInRoleroleObjectId, WorkflowValue<string> azureADv2IsUserInRoleworkflow)
        {
            WorkflowValue.Validate(azureADv2IsUserInRoleuserObjectId, nameof(azureADv2IsUserInRoleuserObjectId), required: true);
            WorkflowValue.Validate(azureADv2IsUserInRoleroleObjectId, nameof(azureADv2IsUserInRoleroleObjectId), required: true);
            WorkflowValue.Validate(azureADv2IsUserInRoleworkflow, nameof(azureADv2IsUserInRoleworkflow), required: true);
            return new DeferredBodyAction<AzureADv2IsUserInRoleResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2IsUserInRole";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2IsUserInRole = new JObject();
                var azureADv2IsUserInRolepropCount = 0;
                azureADv2IsUserInRolepropCount++;
                azureADv2IsUserInRole["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2IsUserInRoleuserObjectId);
                azureADv2IsUserInRolepropCount++;
                azureADv2IsUserInRole["RoleObjectId"] = ExpressionConverter.ConvertO(azureADv2IsUserInRoleroleObjectId);
                azureADv2IsUserInRolepropCount++;
                azureADv2IsUserInRole["Workflow"] = ExpressionConverter.ConvertO(azureADv2IsUserInRoleworkflow);
                if (azureADv2IsUserInRolepropCount > 0)
                {
                    callPayload.Body = azureADv2IsUserInRole;
                }

                return new ApiConnectionAction<AzureADv2IsUserInRoleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2GetAzureADUserRoleAssignments))]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserRoleAssignmentsResponse> AzureADv2GetAzureADUserRoleAssignments([WorkflowExpression] Func<string> azureADv2GetAzureADUserRoleAssignmentsobjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADUserRoleAssignmentsworkflow, [WorkflowExpression] Func<bool> azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames = null, [WorkflowExpression] Func<bool> azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserRoleAssignmentsResponse> __BuildAzureADv2GetAzureADUserRoleAssignments(WorkflowValue<string> azureADv2GetAzureADUserRoleAssignmentsobjectId, WorkflowValue<string> azureADv2GetAzureADUserRoleAssignmentsworkflow, WorkflowValue<bool> azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames = null, WorkflowValue<bool> azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds = null)
        {
            WorkflowValue.Validate(azureADv2GetAzureADUserRoleAssignmentsobjectId, nameof(azureADv2GetAzureADUserRoleAssignmentsobjectId), required: true);
            WorkflowValue.Validate(azureADv2GetAzureADUserRoleAssignmentsworkflow, nameof(azureADv2GetAzureADUserRoleAssignmentsworkflow), required: true);
            WorkflowValue.Validate(azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames, nameof(azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames), required: false);
            WorkflowValue.Validate(azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds, nameof(azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds), required: false);
            return new DeferredBodyAction<AzureADv2GetAzureADUserRoleAssignmentsResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserRoleAssignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUserRoleAssignments = new JObject();
                var azureADv2GetAzureADUserRoleAssignmentspropCount = 0;
                azureADv2GetAzureADUserRoleAssignmentspropCount++;
                azureADv2GetAzureADUserRoleAssignments["ObjectId"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserRoleAssignmentsobjectId);
                if (azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames != null)
                {
                    if (azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames != null)
                    {
                        azureADv2GetAzureADUserRoleAssignments["RetrieveAdminRoleNames"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames);
                        azureADv2GetAzureADUserRoleAssignmentspropCount++;
                    }

                    azureADv2GetAzureADUserRoleAssignmentspropCount++;
                }
                else
                {
                    azureADv2GetAzureADUserRoleAssignments["RetrieveAdminRoleNames"] = true;
                    azureADv2GetAzureADUserRoleAssignmentspropCount++;
                }

                if (azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds != null)
                {
                    if (azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds != null)
                    {
                        azureADv2GetAzureADUserRoleAssignments["ReturnAssignmentIds"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds);
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
                azureADv2GetAzureADUserRoleAssignments["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserRoleAssignmentsworkflow);
                if (azureADv2GetAzureADUserRoleAssignmentspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUserRoleAssignments;
                }

                return new ApiConnectionAction<AzureADv2GetAzureADUserRoleAssignmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2RemoveUserFromRole))]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromRoleResponse> AzureADv2RemoveUserFromRole([WorkflowExpression] Func<string> azureADv2RemoveUserFromRoleuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromRoleroleObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromRoleworkflow, [WorkflowExpression] Func<string> azureADv2RemoveUserFromRoledirectoryScopeId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromRoleResponse> __BuildAzureADv2RemoveUserFromRole(WorkflowValue<string> azureADv2RemoveUserFromRoleuserObjectId, WorkflowValue<string> azureADv2RemoveUserFromRoleroleObjectId, WorkflowValue<string> azureADv2RemoveUserFromRoleworkflow, WorkflowValue<string> azureADv2RemoveUserFromRoledirectoryScopeId = null)
        {
            WorkflowValue.Validate(azureADv2RemoveUserFromRoleuserObjectId, nameof(azureADv2RemoveUserFromRoleuserObjectId), required: true);
            WorkflowValue.Validate(azureADv2RemoveUserFromRoleroleObjectId, nameof(azureADv2RemoveUserFromRoleroleObjectId), required: true);
            WorkflowValue.Validate(azureADv2RemoveUserFromRoleworkflow, nameof(azureADv2RemoveUserFromRoleworkflow), required: true);
            WorkflowValue.Validate(azureADv2RemoveUserFromRoledirectoryScopeId, nameof(azureADv2RemoveUserFromRoledirectoryScopeId), required: false);
            return new DeferredBodyAction<AzureADv2RemoveUserFromRoleResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromRole";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromRole = new JObject();
                var azureADv2RemoveUserFromRolepropCount = 0;
                azureADv2RemoveUserFromRolepropCount++;
                azureADv2RemoveUserFromRole["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromRoleuserObjectId);
                azureADv2RemoveUserFromRolepropCount++;
                azureADv2RemoveUserFromRole["RoleObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromRoleroleObjectId);
                if (azureADv2RemoveUserFromRoledirectoryScopeId != null)
                {
                    if (azureADv2RemoveUserFromRoledirectoryScopeId != null)
                    {
                        azureADv2RemoveUserFromRole["DirectoryScopeId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromRoledirectoryScopeId);
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
                azureADv2RemoveUserFromRole["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromRoleworkflow);
                if (azureADv2RemoveUserFromRolepropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromRole;
                }

                return new ApiConnectionAction<AzureADv2RemoveUserFromRoleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2RemoveUserFromAllRoles))]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllRolesResponse> AzureADv2RemoveUserFromAllRoles([WorkflowExpression] Func<string> azureADv2RemoveUserFromAllRolesuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromAllRolesworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllRolesResponse> __BuildAzureADv2RemoveUserFromAllRoles(WorkflowValue<string> azureADv2RemoveUserFromAllRolesuserObjectId, WorkflowValue<string> azureADv2RemoveUserFromAllRolesworkflow, WorkflowValue<bool> azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove = null, WorkflowValue<bool> azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove = null)
        {
            WorkflowValue.Validate(azureADv2RemoveUserFromAllRolesuserObjectId, nameof(azureADv2RemoveUserFromAllRolesuserObjectId), required: true);
            WorkflowValue.Validate(azureADv2RemoveUserFromAllRolesworkflow, nameof(azureADv2RemoveUserFromAllRolesworkflow), required: true);
            WorkflowValue.Validate(azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove, nameof(azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove), required: false);
            WorkflowValue.Validate(azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove, nameof(azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove), required: false);
            return new DeferredBodyAction<AzureADv2RemoveUserFromAllRolesResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromAllRoles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromAllRoles = new JObject();
                var azureADv2RemoveUserFromAllRolespropCount = 0;
                azureADv2RemoveUserFromAllRolespropCount++;
                azureADv2RemoveUserFromAllRoles["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllRolesuserObjectId);
                if (azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove != null)
                {
                    if (azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove != null)
                    {
                        azureADv2RemoveUserFromAllRoles["ExceptionIfAnyRolesFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove);
                        azureADv2RemoveUserFromAllRolespropCount++;
                    }

                    azureADv2RemoveUserFromAllRolespropCount++;
                }
                else
                {
                    azureADv2RemoveUserFromAllRoles["ExceptionIfAnyRolesFailToRemove"] = false;
                    azureADv2RemoveUserFromAllRolespropCount++;
                }

                if (azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove != null)
                {
                    if (azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove != null)
                    {
                        azureADv2RemoveUserFromAllRoles["ExceptionIfAllRolesFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove);
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
                azureADv2RemoveUserFromAllRoles["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllRolesworkflow);
                if (azureADv2RemoveUserFromAllRolespropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromAllRoles;
                }

                return new ApiConnectionAction<AzureADv2RemoveUserFromAllRolesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildAzureADv2GetAzureADGroupMembers))]
        public IBodyWorkflowAction<AzureADv2GetAzureADGroupMembersResponse> AzureADv2GetAzureADGroupMembers([WorkflowExpression] Func<string> azureADv2GetAzureADGroupMembersgroupObjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADGroupMembersworkflow, [WorkflowExpression] Func<string> azureADv2GetAzureADGroupMemberspropertiesToReturn = null, [WorkflowExpression] Func<string> azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AzureADv2GetAzureADGroupMembersResponse> __BuildAzureADv2GetAzureADGroupMembers(WorkflowValue<string> azureADv2GetAzureADGroupMembersgroupObjectId, WorkflowValue<string> azureADv2GetAzureADGroupMembersworkflow, WorkflowValue<string> azureADv2GetAzureADGroupMemberspropertiesToReturn = null, WorkflowValue<string> azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn = null)
        {
            WorkflowValue.Validate(azureADv2GetAzureADGroupMembersgroupObjectId, nameof(azureADv2GetAzureADGroupMembersgroupObjectId), required: true);
            WorkflowValue.Validate(azureADv2GetAzureADGroupMembersworkflow, nameof(azureADv2GetAzureADGroupMembersworkflow), required: true);
            WorkflowValue.Validate(azureADv2GetAzureADGroupMemberspropertiesToReturn, nameof(azureADv2GetAzureADGroupMemberspropertiesToReturn), required: false);
            WorkflowValue.Validate(azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn, nameof(azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn), required: false);
            return new DeferredBodyAction<AzureADv2GetAzureADGroupMembersResponse>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADGroupMembers = new JObject();
                var azureADv2GetAzureADGroupMemberspropCount = 0;
                azureADv2GetAzureADGroupMemberspropCount++;
                azureADv2GetAzureADGroupMembers["GroupObjectId"] = ExpressionConverter.ConvertO(azureADv2GetAzureADGroupMembersgroupObjectId);
                if (azureADv2GetAzureADGroupMemberspropertiesToReturn != null)
                {
                    azureADv2GetAzureADGroupMembers["PropertiesToReturn"] = ExpressionConverter.ConvertO(azureADv2GetAzureADGroupMemberspropertiesToReturn);
                    azureADv2GetAzureADGroupMemberspropCount++;
                }

                if (azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn != null)
                {
                    azureADv2GetAzureADGroupMembers["MemberObjectTypesToReturn"] = ExpressionConverter.ConvertO(azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn);
                    azureADv2GetAzureADGroupMemberspropCount++;
                }

                azureADv2GetAzureADGroupMemberspropCount++;
                azureADv2GetAzureADGroupMembers["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetAzureADGroupMembersworkflow);
                if (azureADv2GetAzureADGroupMemberspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADGroupMembers;
                }

                return new ApiConnectionAction<AzureADv2GetAzureADGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildOpenO365PowerShellRunspace))]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceResponse> OpenO365PowerShellRunspace([WorkflowExpression] Func<string> openO365PowerShellRunspaceoffice365Username, [WorkflowExpression] Func<string> openO365PowerShellRunspaceoffice365Password, [WorkflowExpression] Func<string> openO365PowerShellRunspaceworkflow, [WorkflowExpression] Func<string> openO365PowerShellRunspaceexchangeURL = null, [WorkflowExpression] Func<openO365PowerShellRunspaceconnectionMethodInput> openO365PowerShellRunspaceconnectionMethod = null, [WorkflowExpression] Func<bool> openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected = null, [WorkflowExpression] Func<openO365PowerShellRunspacecommandTypesToImportLocallyInput> openO365PowerShellRunspacecommandTypesToImportLocally = null, [WorkflowExpression] Func<string> openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceResponse> __BuildOpenO365PowerShellRunspace(WorkflowValue<string> openO365PowerShellRunspaceoffice365Username, WorkflowValue<string> openO365PowerShellRunspaceoffice365Password, WorkflowValue<string> openO365PowerShellRunspaceworkflow, WorkflowValue<string> openO365PowerShellRunspaceexchangeURL = null, WorkflowValue<openO365PowerShellRunspaceconnectionMethodInput> openO365PowerShellRunspaceconnectionMethod = null, WorkflowValue<bool> openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected = null, WorkflowValue<openO365PowerShellRunspacecommandTypesToImportLocallyInput> openO365PowerShellRunspacecommandTypesToImportLocally = null, WorkflowValue<string> openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV = null)
        {
            WorkflowValue.Validate(openO365PowerShellRunspaceoffice365Username, nameof(openO365PowerShellRunspaceoffice365Username), required: true);
            WorkflowValue.Validate(openO365PowerShellRunspaceoffice365Password, nameof(openO365PowerShellRunspaceoffice365Password), required: true);
            WorkflowValue.Validate(openO365PowerShellRunspaceworkflow, nameof(openO365PowerShellRunspaceworkflow), required: true);
            WorkflowValue.Validate(openO365PowerShellRunspaceexchangeURL, nameof(openO365PowerShellRunspaceexchangeURL), required: false);
            WorkflowValue.Validate(openO365PowerShellRunspaceconnectionMethod, nameof(openO365PowerShellRunspaceconnectionMethod), required: false);
            WorkflowValue.Validate(openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected, nameof(openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected), required: false);
            WorkflowValue.Validate(openO365PowerShellRunspacecommandTypesToImportLocally, nameof(openO365PowerShellRunspacecommandTypesToImportLocally), required: false);
            WorkflowValue.Validate(openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV, nameof(openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV), required: false);
            return new DeferredBodyAction<OpenO365PowerShellRunspaceResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenO365PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openO365PowerShellRunspace = new JObject();
                var openO365PowerShellRunspacepropCount = 0;
                openO365PowerShellRunspacepropCount++;
                openO365PowerShellRunspace["Office365Username"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceoffice365Username);
                openO365PowerShellRunspacepropCount++;
                openO365PowerShellRunspace["Office365Password"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceoffice365Password);
                if (openO365PowerShellRunspaceexchangeURL != null)
                {
                    openO365PowerShellRunspace["ExchangeURL"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceexchangeURL);
                    openO365PowerShellRunspacepropCount++;
                }

                if (openO365PowerShellRunspaceconnectionMethod != null)
                {
                    if (openO365PowerShellRunspaceconnectionMethod != null)
                    {
                        openO365PowerShellRunspace["ConnectionMethod"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceconnectionMethod);
                        openO365PowerShellRunspacepropCount++;
                    }

                    openO365PowerShellRunspacepropCount++;
                }
                else
                {
                    openO365PowerShellRunspace["ConnectionMethod"] = "EXO V1 local";
                    openO365PowerShellRunspacepropCount++;
                }

                if (openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected != null)
                {
                    if (openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected != null)
                    {
                        openO365PowerShellRunspace["OnlyConnectIfNotAlreadyConnected"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected);
                        openO365PowerShellRunspacepropCount++;
                    }

                    openO365PowerShellRunspacepropCount++;
                }
                else
                {
                    openO365PowerShellRunspace["OnlyConnectIfNotAlreadyConnected"] = true;
                    openO365PowerShellRunspacepropCount++;
                }

                if (openO365PowerShellRunspacecommandTypesToImportLocally != null)
                {
                    if (openO365PowerShellRunspacecommandTypesToImportLocally != null)
                    {
                        openO365PowerShellRunspace["CommandTypesToImportLocally"] = ExpressionConverter.ConvertO(openO365PowerShellRunspacecommandTypesToImportLocally);
                        openO365PowerShellRunspacepropCount++;
                    }

                    openO365PowerShellRunspacepropCount++;
                }
                else
                {
                    openO365PowerShellRunspace["CommandTypesToImportLocally"] = "All";
                    openO365PowerShellRunspacepropCount++;
                }

                if (openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV != null)
                {
                    openO365PowerShellRunspace["AdditionalCommandsToImportLocallyCSV"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV);
                    openO365PowerShellRunspacepropCount++;
                }

                openO365PowerShellRunspacepropCount++;
                openO365PowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceworkflow);
                if (openO365PowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = openO365PowerShellRunspace;
                }

                return new ApiConnectionAction<OpenO365PowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildOpenO365PowerShellRunspaceWithCertificate))]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceWithCertificateResponse> OpenO365PowerShellRunspaceWithCertificate([WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateapplicationId, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificatecertificateThumbprint, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateorganization, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateworkflow, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateexchangeURL = null, [WorkflowExpression] Func<openO365PowerShellRunspaceWithCertificateconnectionMethodInput> openO365PowerShellRunspaceWithCertificateconnectionMethod = null, [WorkflowExpression] Func<bool> openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected = null, [WorkflowExpression] Func<openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocallyInput> openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally = null, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceWithCertificateResponse> __BuildOpenO365PowerShellRunspaceWithCertificate(WorkflowValue<string> openO365PowerShellRunspaceWithCertificateapplicationId, WorkflowValue<string> openO365PowerShellRunspaceWithCertificatecertificateThumbprint, WorkflowValue<string> openO365PowerShellRunspaceWithCertificateorganization, WorkflowValue<string> openO365PowerShellRunspaceWithCertificateworkflow, WorkflowValue<string> openO365PowerShellRunspaceWithCertificateexchangeURL = null, WorkflowValue<openO365PowerShellRunspaceWithCertificateconnectionMethodInput> openO365PowerShellRunspaceWithCertificateconnectionMethod = null, WorkflowValue<bool> openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected = null, WorkflowValue<openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocallyInput> openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally = null, WorkflowValue<string> openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV = null)
        {
            WorkflowValue.Validate(openO365PowerShellRunspaceWithCertificateapplicationId, nameof(openO365PowerShellRunspaceWithCertificateapplicationId), required: true);
            WorkflowValue.Validate(openO365PowerShellRunspaceWithCertificatecertificateThumbprint, nameof(openO365PowerShellRunspaceWithCertificatecertificateThumbprint), required: true);
            WorkflowValue.Validate(openO365PowerShellRunspaceWithCertificateorganization, nameof(openO365PowerShellRunspaceWithCertificateorganization), required: true);
            WorkflowValue.Validate(openO365PowerShellRunspaceWithCertificateworkflow, nameof(openO365PowerShellRunspaceWithCertificateworkflow), required: true);
            WorkflowValue.Validate(openO365PowerShellRunspaceWithCertificateexchangeURL, nameof(openO365PowerShellRunspaceWithCertificateexchangeURL), required: false);
            WorkflowValue.Validate(openO365PowerShellRunspaceWithCertificateconnectionMethod, nameof(openO365PowerShellRunspaceWithCertificateconnectionMethod), required: false);
            WorkflowValue.Validate(openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected, nameof(openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected), required: false);
            WorkflowValue.Validate(openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally, nameof(openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally), required: false);
            WorkflowValue.Validate(openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV, nameof(openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV), required: false);
            return new DeferredBodyAction<OpenO365PowerShellRunspaceWithCertificateResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenO365PowerShellRunspaceWithCertificate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openO365PowerShellRunspaceWithCertificate = new JObject();
                var openO365PowerShellRunspaceWithCertificatepropCount = 0;
                openO365PowerShellRunspaceWithCertificatepropCount++;
                openO365PowerShellRunspaceWithCertificate["ApplicationId"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateapplicationId);
                openO365PowerShellRunspaceWithCertificatepropCount++;
                openO365PowerShellRunspaceWithCertificate["CertificateThumbprint"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificatecertificateThumbprint);
                openO365PowerShellRunspaceWithCertificatepropCount++;
                openO365PowerShellRunspaceWithCertificate["Organization"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateorganization);
                if (openO365PowerShellRunspaceWithCertificateexchangeURL != null)
                {
                    openO365PowerShellRunspaceWithCertificate["ExchangeURL"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateexchangeURL);
                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }

                if (openO365PowerShellRunspaceWithCertificateconnectionMethod != null)
                {
                    if (openO365PowerShellRunspaceWithCertificateconnectionMethod != null)
                    {
                        openO365PowerShellRunspaceWithCertificate["ConnectionMethod"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateconnectionMethod);
                        openO365PowerShellRunspaceWithCertificatepropCount++;
                    }

                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }
                else
                {
                    openO365PowerShellRunspaceWithCertificate["ConnectionMethod"] = "EXO V2";
                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }

                if (openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected != null)
                {
                    if (openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected != null)
                    {
                        openO365PowerShellRunspaceWithCertificate["OnlyConnectIfNotAlreadyConnected"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected);
                        openO365PowerShellRunspaceWithCertificatepropCount++;
                    }

                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }
                else
                {
                    openO365PowerShellRunspaceWithCertificate["OnlyConnectIfNotAlreadyConnected"] = true;
                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }

                if (openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally != null)
                {
                    if (openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally != null)
                    {
                        openO365PowerShellRunspaceWithCertificate["CommandTypesToImportLocally"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally);
                        openO365PowerShellRunspaceWithCertificatepropCount++;
                    }

                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }
                else
                {
                    openO365PowerShellRunspaceWithCertificate["CommandTypesToImportLocally"] = "All";
                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }

                if (openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV != null)
                {
                    openO365PowerShellRunspaceWithCertificate["AdditionalCommandsToImportLocallyCSV"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV);
                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }

                openO365PowerShellRunspaceWithCertificatepropCount++;
                openO365PowerShellRunspaceWithCertificate["Workflow"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateworkflow);
                if (openO365PowerShellRunspaceWithCertificatepropCount > 0)
                {
                    callPayload.Body = openO365PowerShellRunspaceWithCertificate;
                }

                return new ApiConnectionAction<OpenO365PowerShellRunspaceWithCertificateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildIsO365PowerShellRunspaceOpen))]
        public IBodyWorkflowAction<IsO365PowerShellRunspaceOpenResponse> IsO365PowerShellRunspaceOpen([WorkflowExpression] Func<string> isO365PowerShellRunspaceOpenworkflow, [WorkflowExpression] Func<bool> isO365PowerShellRunspaceOpentestCommunications = null, [WorkflowExpression] Func<bool> isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsO365PowerShellRunspaceOpenResponse> __BuildIsO365PowerShellRunspaceOpen(WorkflowValue<string> isO365PowerShellRunspaceOpenworkflow, WorkflowValue<bool> isO365PowerShellRunspaceOpentestCommunications = null, WorkflowValue<bool> isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
        {
            WorkflowValue.Validate(isO365PowerShellRunspaceOpenworkflow, nameof(isO365PowerShellRunspaceOpenworkflow), required: true);
            WorkflowValue.Validate(isO365PowerShellRunspaceOpentestCommunications, nameof(isO365PowerShellRunspaceOpentestCommunications), required: false);
            WorkflowValue.Validate(isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID, nameof(isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID), required: false);
            return new DeferredBodyAction<IsO365PowerShellRunspaceOpenResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/IsO365PowerShellRunspaceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isO365PowerShellRunspaceOpen = new JObject();
                var isO365PowerShellRunspaceOpenpropCount = 0;
                if (isO365PowerShellRunspaceOpentestCommunications != null)
                {
                    if (isO365PowerShellRunspaceOpentestCommunications != null)
                    {
                        isO365PowerShellRunspaceOpen["TestCommunications"] = ExpressionConverter.ConvertO(isO365PowerShellRunspaceOpentestCommunications);
                        isO365PowerShellRunspaceOpenpropCount++;
                    }

                    isO365PowerShellRunspaceOpenpropCount++;
                }
                else
                {
                    isO365PowerShellRunspaceOpen["TestCommunications"] = true;
                    isO365PowerShellRunspaceOpenpropCount++;
                }

                if (isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID != null)
                {
                    if (isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID != null)
                    {
                        isO365PowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = ExpressionConverter.ConvertO(isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID);
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
                isO365PowerShellRunspaceOpen["Workflow"] = ExpressionConverter.ConvertO(isO365PowerShellRunspaceOpenworkflow);
                if (isO365PowerShellRunspaceOpenpropCount > 0)
                {
                    callPayload.Body = isO365PowerShellRunspaceOpen;
                }

                return new ApiConnectionAction<IsO365PowerShellRunspaceOpenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildRunO365PowerShellAutomationScript))]
        public IBodyWorkflowAction<RunO365PowerShellAutomationScriptResponse> RunO365PowerShellAutomationScript([WorkflowExpression] Func<string> runO365PowerShellAutomationScriptworkflow, [WorkflowExpression] Func<string> runO365PowerShellAutomationScriptpowerShellScriptContents = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptisNoResultAnError = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptreturnComplexTypes = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptreturnBooleanAsBoolean = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptreturnNumericAsDecimal = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptreturnDateAsDate = null, [WorkflowExpression] Func<string> runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptlocalScope = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptrunScriptAsThread = null, [WorkflowExpression] Func<int> runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> runO365PowerShellAutomationScriptsecondsToWaitForThread = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptscriptContainsStoredPassword = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptlogVerboseOutput = null, [WorkflowExpression] Func<string> runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON = null, [WorkflowExpression] Func<runO365PowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runO365PowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunO365PowerShellAutomationScriptResponse> __BuildRunO365PowerShellAutomationScript(WorkflowValue<string> runO365PowerShellAutomationScriptworkflow, WorkflowValue<string> runO365PowerShellAutomationScriptpowerShellScriptContents = null, WorkflowValue<bool> runO365PowerShellAutomationScriptisNoResultAnError = null, WorkflowValue<bool> runO365PowerShellAutomationScriptreturnComplexTypes = null, WorkflowValue<bool> runO365PowerShellAutomationScriptreturnBooleanAsBoolean = null, WorkflowValue<bool> runO365PowerShellAutomationScriptreturnNumericAsDecimal = null, WorkflowValue<bool> runO365PowerShellAutomationScriptreturnDateAsDate = null, WorkflowValue<string> runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, WorkflowValue<bool> runO365PowerShellAutomationScriptlocalScope = null, WorkflowValue<bool> runO365PowerShellAutomationScriptrunScriptAsThread = null, WorkflowValue<int> runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId = null, WorkflowValue<int> runO365PowerShellAutomationScriptsecondsToWaitForThread = null, WorkflowValue<bool> runO365PowerShellAutomationScriptscriptContainsStoredPassword = null, WorkflowValue<bool> runO365PowerShellAutomationScriptlogVerboseOutput = null, WorkflowValue<string> runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON = null, WorkflowValue<string> runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON = null, WorkflowValue<runO365PowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runO365PowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            WorkflowValue.Validate(runO365PowerShellAutomationScriptworkflow, nameof(runO365PowerShellAutomationScriptworkflow), required: true);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptpowerShellScriptContents, nameof(runO365PowerShellAutomationScriptpowerShellScriptContents), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptisNoResultAnError, nameof(runO365PowerShellAutomationScriptisNoResultAnError), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptreturnComplexTypes, nameof(runO365PowerShellAutomationScriptreturnComplexTypes), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptreturnBooleanAsBoolean, nameof(runO365PowerShellAutomationScriptreturnBooleanAsBoolean), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptreturnNumericAsDecimal, nameof(runO365PowerShellAutomationScriptreturnNumericAsDecimal), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptreturnDateAsDate, nameof(runO365PowerShellAutomationScriptreturnDateAsDate), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON, nameof(runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptlocalScope, nameof(runO365PowerShellAutomationScriptlocalScope), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptrunScriptAsThread, nameof(runO365PowerShellAutomationScriptrunScriptAsThread), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId, nameof(runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptsecondsToWaitForThread, nameof(runO365PowerShellAutomationScriptsecondsToWaitForThread), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptscriptContainsStoredPassword, nameof(runO365PowerShellAutomationScriptscriptContainsStoredPassword), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptlogVerboseOutput, nameof(runO365PowerShellAutomationScriptlogVerboseOutput), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON, nameof(runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON, nameof(runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON), required: false);
            WorkflowValue.Validate(runO365PowerShellAutomationScriptpowerShellCommandParameters, nameof(runO365PowerShellAutomationScriptpowerShellCommandParameters), required: false);
            return new DeferredBodyAction<RunO365PowerShellAutomationScriptResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/RunO365PowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runO365PowerShellAutomationScript = new JObject();
                var runO365PowerShellAutomationScriptpropCount = 0;
                if (runO365PowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runO365PowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptpowerShellScriptContents);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (runO365PowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runO365PowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptisNoResultAnError);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["IsNoResultAnError"] = false;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptreturnComplexTypes != null)
                {
                    if (runO365PowerShellAutomationScriptreturnComplexTypes != null)
                    {
                        runO365PowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptreturnComplexTypes);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["ReturnComplexTypes"] = false;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptreturnBooleanAsBoolean != null)
                {
                    if (runO365PowerShellAutomationScriptreturnBooleanAsBoolean != null)
                    {
                        runO365PowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptreturnBooleanAsBoolean);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["ReturnBooleanAsBoolean"] = false;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptreturnNumericAsDecimal != null)
                {
                    if (runO365PowerShellAutomationScriptreturnNumericAsDecimal != null)
                    {
                        runO365PowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptreturnNumericAsDecimal);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["ReturnNumericAsDecimal"] = false;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptreturnDateAsDate != null)
                {
                    if (runO365PowerShellAutomationScriptreturnDateAsDate != null)
                    {
                        runO365PowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptreturnDateAsDate);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["ReturnDateAsDate"] = false;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON != null)
                {
                    runO365PowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptlocalScope != null)
                {
                    runO365PowerShellAutomationScript["LocalScope"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptlocalScope);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (runO365PowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runO365PowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptrunScriptAsThread);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["RunScriptAsThread"] = false;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId != null)
                {
                    runO365PowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (runO365PowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runO365PowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptsecondsToWaitForThread);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["SecondsToWaitForThread"] = 90;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptscriptContainsStoredPassword != null)
                {
                    if (runO365PowerShellAutomationScriptscriptContainsStoredPassword != null)
                    {
                        runO365PowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptscriptContainsStoredPassword);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["ScriptContainsStoredPassword"] = true;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptlogVerboseOutput != null)
                {
                    if (runO365PowerShellAutomationScriptlogVerboseOutput != null)
                    {
                        runO365PowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptlogVerboseOutput);
                        runO365PowerShellAutomationScriptpropCount++;
                    }

                    runO365PowerShellAutomationScriptpropCount++;
                }
                else
                {
                    runO365PowerShellAutomationScript["LogVerboseOutput"] = false;
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON != null)
                {
                    runO365PowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runO365PowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runO365PowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptpowerShellCommandParameters);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                runO365PowerShellAutomationScriptpropCount++;
                runO365PowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptworkflow);
                if (runO365PowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runO365PowerShellAutomationScript;
                }

                return new ApiConnectionAction<RunO365PowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildCloseO365PowerShellRunspace))]
        public IBodyWorkflowAction<CloseO365PowerShellRunspaceResponse> CloseO365PowerShellRunspace([WorkflowExpression] Func<string> closeO365PowerShellRunspaceworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CloseO365PowerShellRunspaceResponse> __BuildCloseO365PowerShellRunspace(WorkflowValue<string> closeO365PowerShellRunspaceworkflow)
        {
            WorkflowValue.Validate(closeO365PowerShellRunspaceworkflow, nameof(closeO365PowerShellRunspaceworkflow), required: true);
            return new DeferredBodyAction<CloseO365PowerShellRunspaceResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/CloseO365PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var closeO365PowerShellRunspace = new JObject();
                var closeO365PowerShellRunspacepropCount = 0;
                closeO365PowerShellRunspacepropCount++;
                closeO365PowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(closeO365PowerShellRunspaceworkflow);
                if (closeO365PowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = closeO365PowerShellRunspace;
                }

                return new ApiConnectionAction<CloseO365PowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365GetO365Mailbox))]
        public IBodyWorkflowAction<O365GetO365MailboxResponse> O365GetO365Mailbox([WorkflowExpression] Func<string> o365GetO365Mailboxworkflow, [WorkflowExpression] Func<string> o365GetO365Mailboxidentity = null, [WorkflowExpression] Func<string> o365GetO365MailboxfilterPropertyName = null, [WorkflowExpression] Func<o365GetO365MailboxfilterPropertyComparisonInput> o365GetO365MailboxfilterPropertyComparison = null, [WorkflowExpression] Func<string> o365GetO365MailboxfilterPropertyValue = null, [WorkflowExpression] Func<o365GetO365MailboxrecipientTypeDetailsInput> o365GetO365MailboxrecipientTypeDetails = null, [WorkflowExpression] Func<bool> o365GetO365MailboxnoResultIsAnException = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365GetO365MailboxResponse> __BuildO365GetO365Mailbox(WorkflowValue<string> o365GetO365Mailboxworkflow, WorkflowValue<string> o365GetO365Mailboxidentity = null, WorkflowValue<string> o365GetO365MailboxfilterPropertyName = null, WorkflowValue<o365GetO365MailboxfilterPropertyComparisonInput> o365GetO365MailboxfilterPropertyComparison = null, WorkflowValue<string> o365GetO365MailboxfilterPropertyValue = null, WorkflowValue<o365GetO365MailboxrecipientTypeDetailsInput> o365GetO365MailboxrecipientTypeDetails = null, WorkflowValue<bool> o365GetO365MailboxnoResultIsAnException = null)
        {
            WorkflowValue.Validate(o365GetO365Mailboxworkflow, nameof(o365GetO365Mailboxworkflow), required: true);
            WorkflowValue.Validate(o365GetO365Mailboxidentity, nameof(o365GetO365Mailboxidentity), required: false);
            WorkflowValue.Validate(o365GetO365MailboxfilterPropertyName, nameof(o365GetO365MailboxfilterPropertyName), required: false);
            WorkflowValue.Validate(o365GetO365MailboxfilterPropertyComparison, nameof(o365GetO365MailboxfilterPropertyComparison), required: false);
            WorkflowValue.Validate(o365GetO365MailboxfilterPropertyValue, nameof(o365GetO365MailboxfilterPropertyValue), required: false);
            WorkflowValue.Validate(o365GetO365MailboxrecipientTypeDetails, nameof(o365GetO365MailboxrecipientTypeDetails), required: false);
            WorkflowValue.Validate(o365GetO365MailboxnoResultIsAnException, nameof(o365GetO365MailboxnoResultIsAnException), required: false);
            return new DeferredBodyAction<O365GetO365MailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365GetO365Mailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365GetO365Mailbox = new JObject();
                var o365GetO365MailboxpropCount = 0;
                if (o365GetO365Mailboxidentity != null)
                {
                    o365GetO365Mailbox["Identity"] = ExpressionConverter.ConvertO(o365GetO365Mailboxidentity);
                    o365GetO365MailboxpropCount++;
                }

                if (o365GetO365MailboxfilterPropertyName != null)
                {
                    o365GetO365Mailbox["FilterPropertyName"] = ExpressionConverter.ConvertO(o365GetO365MailboxfilterPropertyName);
                    o365GetO365MailboxpropCount++;
                }

                if (o365GetO365MailboxfilterPropertyComparison != null)
                {
                    if (o365GetO365MailboxfilterPropertyComparison != null)
                    {
                        o365GetO365Mailbox["FilterPropertyComparison"] = ExpressionConverter.ConvertO(o365GetO365MailboxfilterPropertyComparison);
                        o365GetO365MailboxpropCount++;
                    }

                    o365GetO365MailboxpropCount++;
                }
                else
                {
                    o365GetO365Mailbox["FilterPropertyComparison"] = "Equals";
                    o365GetO365MailboxpropCount++;
                }

                if (o365GetO365MailboxfilterPropertyValue != null)
                {
                    o365GetO365Mailbox["FilterPropertyValue"] = ExpressionConverter.ConvertO(o365GetO365MailboxfilterPropertyValue);
                    o365GetO365MailboxpropCount++;
                }

                if (o365GetO365MailboxrecipientTypeDetails != null)
                {
                    o365GetO365Mailbox["RecipientTypeDetails"] = ExpressionConverter.ConvertO(o365GetO365MailboxrecipientTypeDetails);
                    o365GetO365MailboxpropCount++;
                }

                if (o365GetO365MailboxnoResultIsAnException != null)
                {
                    if (o365GetO365MailboxnoResultIsAnException != null)
                    {
                        o365GetO365Mailbox["NoResultIsAnException"] = ExpressionConverter.ConvertO(o365GetO365MailboxnoResultIsAnException);
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
                o365GetO365Mailbox["Workflow"] = ExpressionConverter.ConvertO(o365GetO365Mailboxworkflow);
                if (o365GetO365MailboxpropCount > 0)
                {
                    callPayload.Body = o365GetO365Mailbox;
                }

                return new ApiConnectionAction<O365GetO365MailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365AddMailboxPermission))]
        public IBodyWorkflowAction<O365AddMailboxPermissionResponse> O365AddMailboxPermission([WorkflowExpression] Func<string> o365AddMailboxPermissionidentity, [WorkflowExpression] Func<string> o365AddMailboxPermissionuser, [WorkflowExpression] Func<string> o365AddMailboxPermissionaccessRights, [WorkflowExpression] Func<string> o365AddMailboxPermissionworkflow, [WorkflowExpression] Func<bool> o365AddMailboxPermissionautoMapping = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365AddMailboxPermissionResponse> __BuildO365AddMailboxPermission(WorkflowValue<string> o365AddMailboxPermissionidentity, WorkflowValue<string> o365AddMailboxPermissionuser, WorkflowValue<string> o365AddMailboxPermissionaccessRights, WorkflowValue<string> o365AddMailboxPermissionworkflow, WorkflowValue<bool> o365AddMailboxPermissionautoMapping = null)
        {
            WorkflowValue.Validate(o365AddMailboxPermissionidentity, nameof(o365AddMailboxPermissionidentity), required: true);
            WorkflowValue.Validate(o365AddMailboxPermissionuser, nameof(o365AddMailboxPermissionuser), required: true);
            WorkflowValue.Validate(o365AddMailboxPermissionaccessRights, nameof(o365AddMailboxPermissionaccessRights), required: true);
            WorkflowValue.Validate(o365AddMailboxPermissionworkflow, nameof(o365AddMailboxPermissionworkflow), required: true);
            WorkflowValue.Validate(o365AddMailboxPermissionautoMapping, nameof(o365AddMailboxPermissionautoMapping), required: false);
            return new DeferredBodyAction<O365AddMailboxPermissionResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365AddMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365AddMailboxPermission = new JObject();
                var o365AddMailboxPermissionpropCount = 0;
                o365AddMailboxPermissionpropCount++;
                o365AddMailboxPermission["Identity"] = ExpressionConverter.ConvertO(o365AddMailboxPermissionidentity);
                o365AddMailboxPermissionpropCount++;
                o365AddMailboxPermission["User"] = ExpressionConverter.ConvertO(o365AddMailboxPermissionuser);
                o365AddMailboxPermissionpropCount++;
                o365AddMailboxPermission["AccessRights"] = ExpressionConverter.ConvertO(o365AddMailboxPermissionaccessRights);
                if (o365AddMailboxPermissionautoMapping != null)
                {
                    if (o365AddMailboxPermissionautoMapping != null)
                    {
                        o365AddMailboxPermission["AutoMapping"] = ExpressionConverter.ConvertO(o365AddMailboxPermissionautoMapping);
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
                o365AddMailboxPermission["Workflow"] = ExpressionConverter.ConvertO(o365AddMailboxPermissionworkflow);
                if (o365AddMailboxPermissionpropCount > 0)
                {
                    callPayload.Body = o365AddMailboxPermission;
                }

                return new ApiConnectionAction<O365AddMailboxPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365RemoveMailboxPermission))]
        public IBodyWorkflowAction<O365RemoveMailboxPermissionResponse> O365RemoveMailboxPermission([WorkflowExpression] Func<string> o365RemoveMailboxPermissionidentity, [WorkflowExpression] Func<string> o365RemoveMailboxPermissionuser, [WorkflowExpression] Func<string> o365RemoveMailboxPermissionaccessRights, [WorkflowExpression] Func<string> o365RemoveMailboxPermissionworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365RemoveMailboxPermissionResponse> __BuildO365RemoveMailboxPermission(WorkflowValue<string> o365RemoveMailboxPermissionidentity, WorkflowValue<string> o365RemoveMailboxPermissionuser, WorkflowValue<string> o365RemoveMailboxPermissionaccessRights, WorkflowValue<string> o365RemoveMailboxPermissionworkflow)
        {
            WorkflowValue.Validate(o365RemoveMailboxPermissionidentity, nameof(o365RemoveMailboxPermissionidentity), required: true);
            WorkflowValue.Validate(o365RemoveMailboxPermissionuser, nameof(o365RemoveMailboxPermissionuser), required: true);
            WorkflowValue.Validate(o365RemoveMailboxPermissionaccessRights, nameof(o365RemoveMailboxPermissionaccessRights), required: true);
            WorkflowValue.Validate(o365RemoveMailboxPermissionworkflow, nameof(o365RemoveMailboxPermissionworkflow), required: true);
            return new DeferredBodyAction<O365RemoveMailboxPermissionResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365RemoveMailboxPermission = new JObject();
                var o365RemoveMailboxPermissionpropCount = 0;
                o365RemoveMailboxPermissionpropCount++;
                o365RemoveMailboxPermission["Identity"] = ExpressionConverter.ConvertO(o365RemoveMailboxPermissionidentity);
                o365RemoveMailboxPermissionpropCount++;
                o365RemoveMailboxPermission["User"] = ExpressionConverter.ConvertO(o365RemoveMailboxPermissionuser);
                o365RemoveMailboxPermissionpropCount++;
                o365RemoveMailboxPermission["AccessRights"] = ExpressionConverter.ConvertO(o365RemoveMailboxPermissionaccessRights);
                o365RemoveMailboxPermissionpropCount++;
                o365RemoveMailboxPermission["Workflow"] = ExpressionConverter.ConvertO(o365RemoveMailboxPermissionworkflow);
                if (o365RemoveMailboxPermissionpropCount > 0)
                {
                    callPayload.Body = o365RemoveMailboxPermission;
                }

                return new ApiConnectionAction<O365RemoveMailboxPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365AddDistributionGroupMember))]
        public IBodyWorkflowAction<O365AddDistributionGroupMemberResponse> O365AddDistributionGroupMember([WorkflowExpression] Func<string> o365AddDistributionGroupMemberidentity, [WorkflowExpression] Func<string> o365AddDistributionGroupMembermember, [WorkflowExpression] Func<string> o365AddDistributionGroupMemberworkflow, [WorkflowExpression] Func<bool> o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365AddDistributionGroupMemberResponse> __BuildO365AddDistributionGroupMember(WorkflowValue<string> o365AddDistributionGroupMemberidentity, WorkflowValue<string> o365AddDistributionGroupMembermember, WorkflowValue<string> o365AddDistributionGroupMemberworkflow, WorkflowValue<bool> o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck = null)
        {
            WorkflowValue.Validate(o365AddDistributionGroupMemberidentity, nameof(o365AddDistributionGroupMemberidentity), required: true);
            WorkflowValue.Validate(o365AddDistributionGroupMembermember, nameof(o365AddDistributionGroupMembermember), required: true);
            WorkflowValue.Validate(o365AddDistributionGroupMemberworkflow, nameof(o365AddDistributionGroupMemberworkflow), required: true);
            WorkflowValue.Validate(o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck, nameof(o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck), required: false);
            return new DeferredBodyAction<O365AddDistributionGroupMemberResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365AddDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365AddDistributionGroupMember = new JObject();
                var o365AddDistributionGroupMemberpropCount = 0;
                o365AddDistributionGroupMemberpropCount++;
                o365AddDistributionGroupMember["Identity"] = ExpressionConverter.ConvertO(o365AddDistributionGroupMemberidentity);
                o365AddDistributionGroupMemberpropCount++;
                o365AddDistributionGroupMember["Member"] = ExpressionConverter.ConvertO(o365AddDistributionGroupMembermember);
                if (o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                {
                    if (o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                    {
                        o365AddDistributionGroupMember["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck);
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
                o365AddDistributionGroupMember["Workflow"] = ExpressionConverter.ConvertO(o365AddDistributionGroupMemberworkflow);
                if (o365AddDistributionGroupMemberpropCount > 0)
                {
                    callPayload.Body = o365AddDistributionGroupMember;
                }

                return new ApiConnectionAction<O365AddDistributionGroupMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365GetO365DistributionGroup))]
        public IBodyWorkflowAction<O365GetO365DistributionGroupResponse> O365GetO365DistributionGroup([WorkflowExpression] Func<string> o365GetO365DistributionGroupworkflow, [WorkflowExpression] Func<string> o365GetO365DistributionGroupidentity = null, [WorkflowExpression] Func<string> o365GetO365DistributionGroupfilterPropertyName = null, [WorkflowExpression] Func<o365GetO365DistributionGroupfilterPropertyComparisonInput> o365GetO365DistributionGroupfilterPropertyComparison = null, [WorkflowExpression] Func<string> o365GetO365DistributionGroupfilterPropertyValue = null, [WorkflowExpression] Func<bool> o365GetO365DistributionGroupnoResultIsAnException = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365GetO365DistributionGroupResponse> __BuildO365GetO365DistributionGroup(WorkflowValue<string> o365GetO365DistributionGroupworkflow, WorkflowValue<string> o365GetO365DistributionGroupidentity = null, WorkflowValue<string> o365GetO365DistributionGroupfilterPropertyName = null, WorkflowValue<o365GetO365DistributionGroupfilterPropertyComparisonInput> o365GetO365DistributionGroupfilterPropertyComparison = null, WorkflowValue<string> o365GetO365DistributionGroupfilterPropertyValue = null, WorkflowValue<bool> o365GetO365DistributionGroupnoResultIsAnException = null)
        {
            WorkflowValue.Validate(o365GetO365DistributionGroupworkflow, nameof(o365GetO365DistributionGroupworkflow), required: true);
            WorkflowValue.Validate(o365GetO365DistributionGroupidentity, nameof(o365GetO365DistributionGroupidentity), required: false);
            WorkflowValue.Validate(o365GetO365DistributionGroupfilterPropertyName, nameof(o365GetO365DistributionGroupfilterPropertyName), required: false);
            WorkflowValue.Validate(o365GetO365DistributionGroupfilterPropertyComparison, nameof(o365GetO365DistributionGroupfilterPropertyComparison), required: false);
            WorkflowValue.Validate(o365GetO365DistributionGroupfilterPropertyValue, nameof(o365GetO365DistributionGroupfilterPropertyValue), required: false);
            WorkflowValue.Validate(o365GetO365DistributionGroupnoResultIsAnException, nameof(o365GetO365DistributionGroupnoResultIsAnException), required: false);
            return new DeferredBodyAction<O365GetO365DistributionGroupResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365GetO365DistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365GetO365DistributionGroup = new JObject();
                var o365GetO365DistributionGrouppropCount = 0;
                if (o365GetO365DistributionGroupidentity != null)
                {
                    o365GetO365DistributionGroup["Identity"] = ExpressionConverter.ConvertO(o365GetO365DistributionGroupidentity);
                    o365GetO365DistributionGrouppropCount++;
                }

                if (o365GetO365DistributionGroupfilterPropertyName != null)
                {
                    o365GetO365DistributionGroup["FilterPropertyName"] = ExpressionConverter.ConvertO(o365GetO365DistributionGroupfilterPropertyName);
                    o365GetO365DistributionGrouppropCount++;
                }

                if (o365GetO365DistributionGroupfilterPropertyComparison != null)
                {
                    if (o365GetO365DistributionGroupfilterPropertyComparison != null)
                    {
                        o365GetO365DistributionGroup["FilterPropertyComparison"] = ExpressionConverter.ConvertO(o365GetO365DistributionGroupfilterPropertyComparison);
                        o365GetO365DistributionGrouppropCount++;
                    }

                    o365GetO365DistributionGrouppropCount++;
                }
                else
                {
                    o365GetO365DistributionGroup["FilterPropertyComparison"] = "Equals";
                    o365GetO365DistributionGrouppropCount++;
                }

                if (o365GetO365DistributionGroupfilterPropertyValue != null)
                {
                    o365GetO365DistributionGroup["FilterPropertyValue"] = ExpressionConverter.ConvertO(o365GetO365DistributionGroupfilterPropertyValue);
                    o365GetO365DistributionGrouppropCount++;
                }

                if (o365GetO365DistributionGroupnoResultIsAnException != null)
                {
                    if (o365GetO365DistributionGroupnoResultIsAnException != null)
                    {
                        o365GetO365DistributionGroup["NoResultIsAnException"] = ExpressionConverter.ConvertO(o365GetO365DistributionGroupnoResultIsAnException);
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
                o365GetO365DistributionGroup["Workflow"] = ExpressionConverter.ConvertO(o365GetO365DistributionGroupworkflow);
                if (o365GetO365DistributionGrouppropCount > 0)
                {
                    callPayload.Body = o365GetO365DistributionGroup;
                }

                return new ApiConnectionAction<O365GetO365DistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365NewO365DistributionGroup))]
        public IBodyWorkflowAction<O365NewO365DistributionGroupResponse> O365NewO365DistributionGroup([WorkflowExpression] Func<string> o365NewO365DistributionGroupname, [WorkflowExpression] Func<string> o365NewO365DistributionGroupworkflow, [WorkflowExpression] Func<string> o365NewO365DistributionGroupalias = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupdisplayName = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupnotes = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupmanagedBy = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupmembers = null, [WorkflowExpression] Func<string> o365NewO365DistributionGrouporganizationalUnit = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupprimarySmtpAddress = null, [WorkflowExpression] Func<o365NewO365DistributionGroupmemberDepartRestrictionInput> o365NewO365DistributionGroupmemberDepartRestriction = null, [WorkflowExpression] Func<o365NewO365DistributionGroupmemberJoinRestrictionInput> o365NewO365DistributionGroupmemberJoinRestriction = null, [WorkflowExpression] Func<bool> o365NewO365DistributionGrouprequireSenderAuthenticationEnabled = null, [WorkflowExpression] Func<o365NewO365DistributionGrouptypeInput> o365NewO365DistributionGrouptype = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365NewO365DistributionGroupResponse> __BuildO365NewO365DistributionGroup(WorkflowValue<string> o365NewO365DistributionGroupname, WorkflowValue<string> o365NewO365DistributionGroupworkflow, WorkflowValue<string> o365NewO365DistributionGroupalias = null, WorkflowValue<string> o365NewO365DistributionGroupdisplayName = null, WorkflowValue<string> o365NewO365DistributionGroupnotes = null, WorkflowValue<string> o365NewO365DistributionGroupmanagedBy = null, WorkflowValue<string> o365NewO365DistributionGroupmembers = null, WorkflowValue<string> o365NewO365DistributionGrouporganizationalUnit = null, WorkflowValue<string> o365NewO365DistributionGroupprimarySmtpAddress = null, WorkflowValue<o365NewO365DistributionGroupmemberDepartRestrictionInput> o365NewO365DistributionGroupmemberDepartRestriction = null, WorkflowValue<o365NewO365DistributionGroupmemberJoinRestrictionInput> o365NewO365DistributionGroupmemberJoinRestriction = null, WorkflowValue<bool> o365NewO365DistributionGrouprequireSenderAuthenticationEnabled = null, WorkflowValue<o365NewO365DistributionGrouptypeInput> o365NewO365DistributionGrouptype = null)
        {
            WorkflowValue.Validate(o365NewO365DistributionGroupname, nameof(o365NewO365DistributionGroupname), required: true);
            WorkflowValue.Validate(o365NewO365DistributionGroupworkflow, nameof(o365NewO365DistributionGroupworkflow), required: true);
            WorkflowValue.Validate(o365NewO365DistributionGroupalias, nameof(o365NewO365DistributionGroupalias), required: false);
            WorkflowValue.Validate(o365NewO365DistributionGroupdisplayName, nameof(o365NewO365DistributionGroupdisplayName), required: false);
            WorkflowValue.Validate(o365NewO365DistributionGroupnotes, nameof(o365NewO365DistributionGroupnotes), required: false);
            WorkflowValue.Validate(o365NewO365DistributionGroupmanagedBy, nameof(o365NewO365DistributionGroupmanagedBy), required: false);
            WorkflowValue.Validate(o365NewO365DistributionGroupmembers, nameof(o365NewO365DistributionGroupmembers), required: false);
            WorkflowValue.Validate(o365NewO365DistributionGrouporganizationalUnit, nameof(o365NewO365DistributionGrouporganizationalUnit), required: false);
            WorkflowValue.Validate(o365NewO365DistributionGroupprimarySmtpAddress, nameof(o365NewO365DistributionGroupprimarySmtpAddress), required: false);
            WorkflowValue.Validate(o365NewO365DistributionGroupmemberDepartRestriction, nameof(o365NewO365DistributionGroupmemberDepartRestriction), required: false);
            WorkflowValue.Validate(o365NewO365DistributionGroupmemberJoinRestriction, nameof(o365NewO365DistributionGroupmemberJoinRestriction), required: false);
            WorkflowValue.Validate(o365NewO365DistributionGrouprequireSenderAuthenticationEnabled, nameof(o365NewO365DistributionGrouprequireSenderAuthenticationEnabled), required: false);
            WorkflowValue.Validate(o365NewO365DistributionGrouptype, nameof(o365NewO365DistributionGrouptype), required: false);
            return new DeferredBodyAction<O365NewO365DistributionGroupResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365NewO365DistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365NewO365DistributionGroup = new JObject();
                var o365NewO365DistributionGrouppropCount = 0;
                o365NewO365DistributionGrouppropCount++;
                o365NewO365DistributionGroup["Name"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupname);
                if (o365NewO365DistributionGroupalias != null)
                {
                    o365NewO365DistributionGroup["Alias"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupalias);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGroupdisplayName != null)
                {
                    o365NewO365DistributionGroup["DisplayName"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupdisplayName);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGroupnotes != null)
                {
                    o365NewO365DistributionGroup["Notes"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupnotes);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGroupmanagedBy != null)
                {
                    o365NewO365DistributionGroup["ManagedBy"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupmanagedBy);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGroupmembers != null)
                {
                    o365NewO365DistributionGroup["Members"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupmembers);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGrouporganizationalUnit != null)
                {
                    o365NewO365DistributionGroup["OrganizationalUnit"] = ExpressionConverter.ConvertO(o365NewO365DistributionGrouporganizationalUnit);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGroupprimarySmtpAddress != null)
                {
                    o365NewO365DistributionGroup["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupprimarySmtpAddress);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGroupmemberDepartRestriction != null)
                {
                    if (o365NewO365DistributionGroupmemberDepartRestriction != null)
                    {
                        o365NewO365DistributionGroup["MemberDepartRestriction"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupmemberDepartRestriction);
                        o365NewO365DistributionGrouppropCount++;
                    }

                    o365NewO365DistributionGrouppropCount++;
                }
                else
                {
                    o365NewO365DistributionGroup["MemberDepartRestriction"] = "Open";
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGroupmemberJoinRestriction != null)
                {
                    if (o365NewO365DistributionGroupmemberJoinRestriction != null)
                    {
                        o365NewO365DistributionGroup["MemberJoinRestriction"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupmemberJoinRestriction);
                        o365NewO365DistributionGrouppropCount++;
                    }

                    o365NewO365DistributionGrouppropCount++;
                }
                else
                {
                    o365NewO365DistributionGroup["MemberJoinRestriction"] = "Closed";
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGrouprequireSenderAuthenticationEnabled != null)
                {
                    if (o365NewO365DistributionGrouprequireSenderAuthenticationEnabled != null)
                    {
                        o365NewO365DistributionGroup["RequireSenderAuthenticationEnabled"] = ExpressionConverter.ConvertO(o365NewO365DistributionGrouprequireSenderAuthenticationEnabled);
                        o365NewO365DistributionGrouppropCount++;
                    }

                    o365NewO365DistributionGrouppropCount++;
                }
                else
                {
                    o365NewO365DistributionGroup["RequireSenderAuthenticationEnabled"] = false;
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGrouptype != null)
                {
                    o365NewO365DistributionGroup["Type"] = ExpressionConverter.ConvertO(o365NewO365DistributionGrouptype);
                    o365NewO365DistributionGrouppropCount++;
                }

                o365NewO365DistributionGrouppropCount++;
                o365NewO365DistributionGroup["Workflow"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupworkflow);
                if (o365NewO365DistributionGrouppropCount > 0)
                {
                    callPayload.Body = o365NewO365DistributionGroup;
                }

                return new ApiConnectionAction<O365NewO365DistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365RemoveDistributionGroup))]
        public IBodyWorkflowAction<O365RemoveDistributionGroupResponse> O365RemoveDistributionGroup([WorkflowExpression] Func<string> o365RemoveDistributionGroupidentity, [WorkflowExpression] Func<string> o365RemoveDistributionGroupworkflow, [WorkflowExpression] Func<bool> o365RemoveDistributionGroupbypassSecurityGroupManagerCheck = null, [WorkflowExpression] Func<bool> o365RemoveDistributionGrouperrorIfGroupDoesNotExist = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365RemoveDistributionGroupResponse> __BuildO365RemoveDistributionGroup(WorkflowValue<string> o365RemoveDistributionGroupidentity, WorkflowValue<string> o365RemoveDistributionGroupworkflow, WorkflowValue<bool> o365RemoveDistributionGroupbypassSecurityGroupManagerCheck = null, WorkflowValue<bool> o365RemoveDistributionGrouperrorIfGroupDoesNotExist = null)
        {
            WorkflowValue.Validate(o365RemoveDistributionGroupidentity, nameof(o365RemoveDistributionGroupidentity), required: true);
            WorkflowValue.Validate(o365RemoveDistributionGroupworkflow, nameof(o365RemoveDistributionGroupworkflow), required: true);
            WorkflowValue.Validate(o365RemoveDistributionGroupbypassSecurityGroupManagerCheck, nameof(o365RemoveDistributionGroupbypassSecurityGroupManagerCheck), required: false);
            WorkflowValue.Validate(o365RemoveDistributionGrouperrorIfGroupDoesNotExist, nameof(o365RemoveDistributionGrouperrorIfGroupDoesNotExist), required: false);
            return new DeferredBodyAction<O365RemoveDistributionGroupResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365RemoveDistributionGroup = new JObject();
                var o365RemoveDistributionGrouppropCount = 0;
                o365RemoveDistributionGrouppropCount++;
                o365RemoveDistributionGroup["Identity"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupidentity);
                if (o365RemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
                {
                    if (o365RemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
                    {
                        o365RemoveDistributionGroup["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupbypassSecurityGroupManagerCheck);
                        o365RemoveDistributionGrouppropCount++;
                    }

                    o365RemoveDistributionGrouppropCount++;
                }
                else
                {
                    o365RemoveDistributionGroup["BypassSecurityGroupManagerCheck"] = true;
                    o365RemoveDistributionGrouppropCount++;
                }

                if (o365RemoveDistributionGrouperrorIfGroupDoesNotExist != null)
                {
                    if (o365RemoveDistributionGrouperrorIfGroupDoesNotExist != null)
                    {
                        o365RemoveDistributionGroup["ErrorIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(o365RemoveDistributionGrouperrorIfGroupDoesNotExist);
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
                o365RemoveDistributionGroup["Workflow"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupworkflow);
                if (o365RemoveDistributionGrouppropCount > 0)
                {
                    callPayload.Body = o365RemoveDistributionGroup;
                }

                return new ApiConnectionAction<O365RemoveDistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365SetO365Mailbox))]
        public IBodyWorkflowAction<O365SetO365MailboxResponse> O365SetO365Mailbox([WorkflowExpression] Func<string> o365SetO365Mailboxidentity, [WorkflowExpression] Func<string> o365SetO365Mailboxworkflow, [WorkflowExpression] Func<bool> o365SetO365MailboxaccountDisabled = null, [WorkflowExpression] Func<string> o365SetO365Mailboxalias = null, [WorkflowExpression] Func<string> o365SetO365MailboxdisplayName = null, [WorkflowExpression] Func<bool> o365SetO365MailboxhiddenFromAddressListsEnabled = null, [WorkflowExpression] Func<string> o365SetO365MailboxcustomAttribute1 = null, [WorkflowExpression] Func<string> o365SetO365MailboxcustomAttribute2 = null, [WorkflowExpression] Func<string> o365SetO365MailboxcustomAttribute3 = null, [WorkflowExpression] Func<string> o365SetO365MailboxcustomAttribute4 = null, [WorkflowExpression] Func<o365SetO365MailboxtypeInput> o365SetO365Mailboxtype = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365SetO365MailboxResponse> __BuildO365SetO365Mailbox(WorkflowValue<string> o365SetO365Mailboxidentity, WorkflowValue<string> o365SetO365Mailboxworkflow, WorkflowValue<bool> o365SetO365MailboxaccountDisabled = null, WorkflowValue<string> o365SetO365Mailboxalias = null, WorkflowValue<string> o365SetO365MailboxdisplayName = null, WorkflowValue<bool> o365SetO365MailboxhiddenFromAddressListsEnabled = null, WorkflowValue<string> o365SetO365MailboxcustomAttribute1 = null, WorkflowValue<string> o365SetO365MailboxcustomAttribute2 = null, WorkflowValue<string> o365SetO365MailboxcustomAttribute3 = null, WorkflowValue<string> o365SetO365MailboxcustomAttribute4 = null, WorkflowValue<o365SetO365MailboxtypeInput> o365SetO365Mailboxtype = null)
        {
            WorkflowValue.Validate(o365SetO365Mailboxidentity, nameof(o365SetO365Mailboxidentity), required: true);
            WorkflowValue.Validate(o365SetO365Mailboxworkflow, nameof(o365SetO365Mailboxworkflow), required: true);
            WorkflowValue.Validate(o365SetO365MailboxaccountDisabled, nameof(o365SetO365MailboxaccountDisabled), required: false);
            WorkflowValue.Validate(o365SetO365Mailboxalias, nameof(o365SetO365Mailboxalias), required: false);
            WorkflowValue.Validate(o365SetO365MailboxdisplayName, nameof(o365SetO365MailboxdisplayName), required: false);
            WorkflowValue.Validate(o365SetO365MailboxhiddenFromAddressListsEnabled, nameof(o365SetO365MailboxhiddenFromAddressListsEnabled), required: false);
            WorkflowValue.Validate(o365SetO365MailboxcustomAttribute1, nameof(o365SetO365MailboxcustomAttribute1), required: false);
            WorkflowValue.Validate(o365SetO365MailboxcustomAttribute2, nameof(o365SetO365MailboxcustomAttribute2), required: false);
            WorkflowValue.Validate(o365SetO365MailboxcustomAttribute3, nameof(o365SetO365MailboxcustomAttribute3), required: false);
            WorkflowValue.Validate(o365SetO365MailboxcustomAttribute4, nameof(o365SetO365MailboxcustomAttribute4), required: false);
            WorkflowValue.Validate(o365SetO365Mailboxtype, nameof(o365SetO365Mailboxtype), required: false);
            return new DeferredBodyAction<O365SetO365MailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365SetO365Mailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365SetO365Mailbox = new JObject();
                var o365SetO365MailboxpropCount = 0;
                o365SetO365MailboxpropCount++;
                o365SetO365Mailbox["Identity"] = ExpressionConverter.ConvertO(o365SetO365Mailboxidentity);
                if (o365SetO365MailboxaccountDisabled != null)
                {
                    o365SetO365Mailbox["AccountDisabled"] = ExpressionConverter.ConvertO(o365SetO365MailboxaccountDisabled);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365Mailboxalias != null)
                {
                    o365SetO365Mailbox["Alias"] = ExpressionConverter.ConvertO(o365SetO365Mailboxalias);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365MailboxdisplayName != null)
                {
                    o365SetO365Mailbox["DisplayName"] = ExpressionConverter.ConvertO(o365SetO365MailboxdisplayName);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365MailboxhiddenFromAddressListsEnabled != null)
                {
                    o365SetO365Mailbox["HiddenFromAddressListsEnabled"] = ExpressionConverter.ConvertO(o365SetO365MailboxhiddenFromAddressListsEnabled);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365MailboxcustomAttribute1 != null)
                {
                    o365SetO365Mailbox["CustomAttribute1"] = ExpressionConverter.ConvertO(o365SetO365MailboxcustomAttribute1);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365MailboxcustomAttribute2 != null)
                {
                    o365SetO365Mailbox["CustomAttribute2"] = ExpressionConverter.ConvertO(o365SetO365MailboxcustomAttribute2);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365MailboxcustomAttribute3 != null)
                {
                    o365SetO365Mailbox["CustomAttribute3"] = ExpressionConverter.ConvertO(o365SetO365MailboxcustomAttribute3);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365MailboxcustomAttribute4 != null)
                {
                    o365SetO365Mailbox["CustomAttribute4"] = ExpressionConverter.ConvertO(o365SetO365MailboxcustomAttribute4);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365Mailboxtype != null)
                {
                    o365SetO365Mailbox["Type"] = ExpressionConverter.ConvertO(o365SetO365Mailboxtype);
                    o365SetO365MailboxpropCount++;
                }

                o365SetO365MailboxpropCount++;
                o365SetO365Mailbox["Workflow"] = ExpressionConverter.ConvertO(o365SetO365Mailboxworkflow);
                if (o365SetO365MailboxpropCount > 0)
                {
                    callPayload.Body = o365SetO365Mailbox;
                }

                return new ApiConnectionAction<O365SetO365MailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365WaitForO365Mailbox))]
        public IBodyWorkflowAction<O365WaitForO365MailboxResponse> O365WaitForO365Mailbox([WorkflowExpression] Func<string> o365WaitForO365Mailboxidentity, [WorkflowExpression] Func<int> o365WaitForO365MailboxnumberOfTimesToCheck, [WorkflowExpression] Func<int> o365WaitForO365MailboxsecondsBetweenTries, [WorkflowExpression] Func<string> o365WaitForO365Mailboxworkflow, [WorkflowExpression] Func<o365WaitForO365MailboxrecipientTypeDetailsInput> o365WaitForO365MailboxrecipientTypeDetails = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365WaitForO365MailboxResponse> __BuildO365WaitForO365Mailbox(WorkflowValue<string> o365WaitForO365Mailboxidentity, WorkflowValue<int> o365WaitForO365MailboxnumberOfTimesToCheck, WorkflowValue<int> o365WaitForO365MailboxsecondsBetweenTries, WorkflowValue<string> o365WaitForO365Mailboxworkflow, WorkflowValue<o365WaitForO365MailboxrecipientTypeDetailsInput> o365WaitForO365MailboxrecipientTypeDetails = null)
        {
            WorkflowValue.Validate(o365WaitForO365Mailboxidentity, nameof(o365WaitForO365Mailboxidentity), required: true);
            WorkflowValue.Validate(o365WaitForO365MailboxnumberOfTimesToCheck, nameof(o365WaitForO365MailboxnumberOfTimesToCheck), required: true);
            WorkflowValue.Validate(o365WaitForO365MailboxsecondsBetweenTries, nameof(o365WaitForO365MailboxsecondsBetweenTries), required: true);
            WorkflowValue.Validate(o365WaitForO365Mailboxworkflow, nameof(o365WaitForO365Mailboxworkflow), required: true);
            WorkflowValue.Validate(o365WaitForO365MailboxrecipientTypeDetails, nameof(o365WaitForO365MailboxrecipientTypeDetails), required: false);
            return new DeferredBodyAction<O365WaitForO365MailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365WaitForO365Mailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365WaitForO365Mailbox = new JObject();
                var o365WaitForO365MailboxpropCount = 0;
                o365WaitForO365MailboxpropCount++;
                o365WaitForO365Mailbox["Identity"] = ExpressionConverter.ConvertO(o365WaitForO365Mailboxidentity);
                if (o365WaitForO365MailboxrecipientTypeDetails != null)
                {
                    o365WaitForO365Mailbox["RecipientTypeDetails"] = ExpressionConverter.ConvertO(o365WaitForO365MailboxrecipientTypeDetails);
                    o365WaitForO365MailboxpropCount++;
                }

                o365WaitForO365MailboxpropCount++;
                o365WaitForO365Mailbox["NumberOfTimesToCheck"] = ExpressionConverter.ConvertO(o365WaitForO365MailboxnumberOfTimesToCheck);
                o365WaitForO365MailboxpropCount++;
                o365WaitForO365Mailbox["SecondsBetweenTries"] = ExpressionConverter.ConvertO(o365WaitForO365MailboxsecondsBetweenTries);
                o365WaitForO365MailboxpropCount++;
                o365WaitForO365Mailbox["Workflow"] = ExpressionConverter.ConvertO(o365WaitForO365Mailboxworkflow);
                if (o365WaitForO365MailboxpropCount > 0)
                {
                    callPayload.Body = o365WaitForO365Mailbox;
                }

                return new ApiConnectionAction<O365WaitForO365MailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365SetO365MailboxAutoReplyConfiguration))]
        public IBodyWorkflowAction<O365SetO365MailboxAutoReplyConfigurationResponse> O365SetO365MailboxAutoReplyConfiguration([WorkflowExpression] Func<string> o365SetO365MailboxAutoReplyConfigurationidentity, [WorkflowExpression] Func<o365SetO365MailboxAutoReplyConfigurationautoReplyStateInput> o365SetO365MailboxAutoReplyConfigurationautoReplyState, [WorkflowExpression] Func<string> o365SetO365MailboxAutoReplyConfigurationworkflow, [WorkflowExpression] Func<string> o365SetO365MailboxAutoReplyConfigurationinternalMessage = null, [WorkflowExpression] Func<o365SetO365MailboxAutoReplyConfigurationexternalAudienceInput> o365SetO365MailboxAutoReplyConfigurationexternalAudience = null, [WorkflowExpression] Func<string> o365SetO365MailboxAutoReplyConfigurationexternalMessage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365SetO365MailboxAutoReplyConfigurationResponse> __BuildO365SetO365MailboxAutoReplyConfiguration(WorkflowValue<string> o365SetO365MailboxAutoReplyConfigurationidentity, WorkflowValue<o365SetO365MailboxAutoReplyConfigurationautoReplyStateInput> o365SetO365MailboxAutoReplyConfigurationautoReplyState, WorkflowValue<string> o365SetO365MailboxAutoReplyConfigurationworkflow, WorkflowValue<string> o365SetO365MailboxAutoReplyConfigurationinternalMessage = null, WorkflowValue<o365SetO365MailboxAutoReplyConfigurationexternalAudienceInput> o365SetO365MailboxAutoReplyConfigurationexternalAudience = null, WorkflowValue<string> o365SetO365MailboxAutoReplyConfigurationexternalMessage = null)
        {
            WorkflowValue.Validate(o365SetO365MailboxAutoReplyConfigurationidentity, nameof(o365SetO365MailboxAutoReplyConfigurationidentity), required: true);
            WorkflowValue.Validate(o365SetO365MailboxAutoReplyConfigurationautoReplyState, nameof(o365SetO365MailboxAutoReplyConfigurationautoReplyState), required: true);
            WorkflowValue.Validate(o365SetO365MailboxAutoReplyConfigurationworkflow, nameof(o365SetO365MailboxAutoReplyConfigurationworkflow), required: true);
            WorkflowValue.Validate(o365SetO365MailboxAutoReplyConfigurationinternalMessage, nameof(o365SetO365MailboxAutoReplyConfigurationinternalMessage), required: false);
            WorkflowValue.Validate(o365SetO365MailboxAutoReplyConfigurationexternalAudience, nameof(o365SetO365MailboxAutoReplyConfigurationexternalAudience), required: false);
            WorkflowValue.Validate(o365SetO365MailboxAutoReplyConfigurationexternalMessage, nameof(o365SetO365MailboxAutoReplyConfigurationexternalMessage), required: false);
            return new DeferredBodyAction<O365SetO365MailboxAutoReplyConfigurationResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365SetO365MailboxAutoReplyConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365SetO365MailboxAutoReplyConfiguration = new JObject();
                var o365SetO365MailboxAutoReplyConfigurationpropCount = 0;
                o365SetO365MailboxAutoReplyConfigurationpropCount++;
                o365SetO365MailboxAutoReplyConfiguration["Identity"] = ExpressionConverter.ConvertO(o365SetO365MailboxAutoReplyConfigurationidentity);
                o365SetO365MailboxAutoReplyConfigurationpropCount++;
                o365SetO365MailboxAutoReplyConfiguration["AutoReplyState"] = ExpressionConverter.ConvertO(o365SetO365MailboxAutoReplyConfigurationautoReplyState);
                if (o365SetO365MailboxAutoReplyConfigurationinternalMessage != null)
                {
                    o365SetO365MailboxAutoReplyConfiguration["InternalMessage"] = ExpressionConverter.ConvertO(o365SetO365MailboxAutoReplyConfigurationinternalMessage);
                    o365SetO365MailboxAutoReplyConfigurationpropCount++;
                }

                if (o365SetO365MailboxAutoReplyConfigurationexternalAudience != null)
                {
                    if (o365SetO365MailboxAutoReplyConfigurationexternalAudience != null)
                    {
                        o365SetO365MailboxAutoReplyConfiguration["ExternalAudience"] = ExpressionConverter.ConvertO(o365SetO365MailboxAutoReplyConfigurationexternalAudience);
                        o365SetO365MailboxAutoReplyConfigurationpropCount++;
                    }

                    o365SetO365MailboxAutoReplyConfigurationpropCount++;
                }
                else
                {
                    o365SetO365MailboxAutoReplyConfiguration["ExternalAudience"] = "All";
                    o365SetO365MailboxAutoReplyConfigurationpropCount++;
                }

                if (o365SetO365MailboxAutoReplyConfigurationexternalMessage != null)
                {
                    o365SetO365MailboxAutoReplyConfiguration["ExternalMessage"] = ExpressionConverter.ConvertO(o365SetO365MailboxAutoReplyConfigurationexternalMessage);
                    o365SetO365MailboxAutoReplyConfigurationpropCount++;
                }

                o365SetO365MailboxAutoReplyConfigurationpropCount++;
                o365SetO365MailboxAutoReplyConfiguration["Workflow"] = ExpressionConverter.ConvertO(o365SetO365MailboxAutoReplyConfigurationworkflow);
                if (o365SetO365MailboxAutoReplyConfigurationpropCount > 0)
                {
                    callPayload.Body = o365SetO365MailboxAutoReplyConfiguration;
                }

                return new ApiConnectionAction<O365SetO365MailboxAutoReplyConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365RemoveDistributionGroupMember))]
        public IBodyWorkflowAction<O365RemoveDistributionGroupMemberResponse> O365RemoveDistributionGroupMember([WorkflowExpression] Func<string> o365RemoveDistributionGroupMembergroupIdentity, [WorkflowExpression] Func<string> o365RemoveDistributionGroupMembermember, [WorkflowExpression] Func<string> o365RemoveDistributionGroupMemberworkflow, [WorkflowExpression] Func<bool> o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck = null, [WorkflowExpression] Func<bool> o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365RemoveDistributionGroupMemberResponse> __BuildO365RemoveDistributionGroupMember(WorkflowValue<string> o365RemoveDistributionGroupMembergroupIdentity, WorkflowValue<string> o365RemoveDistributionGroupMembermember, WorkflowValue<string> o365RemoveDistributionGroupMemberworkflow, WorkflowValue<bool> o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck = null, WorkflowValue<bool> o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup = null)
        {
            WorkflowValue.Validate(o365RemoveDistributionGroupMembergroupIdentity, nameof(o365RemoveDistributionGroupMembergroupIdentity), required: true);
            WorkflowValue.Validate(o365RemoveDistributionGroupMembermember, nameof(o365RemoveDistributionGroupMembermember), required: true);
            WorkflowValue.Validate(o365RemoveDistributionGroupMemberworkflow, nameof(o365RemoveDistributionGroupMemberworkflow), required: true);
            WorkflowValue.Validate(o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck, nameof(o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck), required: false);
            WorkflowValue.Validate(o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup, nameof(o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup), required: false);
            return new DeferredBodyAction<O365RemoveDistributionGroupMemberResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365RemoveDistributionGroupMember = new JObject();
                var o365RemoveDistributionGroupMemberpropCount = 0;
                o365RemoveDistributionGroupMemberpropCount++;
                o365RemoveDistributionGroupMember["GroupIdentity"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupMembergroupIdentity);
                o365RemoveDistributionGroupMemberpropCount++;
                o365RemoveDistributionGroupMember["Member"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupMembermember);
                if (o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                {
                    if (o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                    {
                        o365RemoveDistributionGroupMember["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck);
                        o365RemoveDistributionGroupMemberpropCount++;
                    }

                    o365RemoveDistributionGroupMemberpropCount++;
                }
                else
                {
                    o365RemoveDistributionGroupMember["BypassSecurityGroupManagerCheck"] = true;
                    o365RemoveDistributionGroupMemberpropCount++;
                }

                if (o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup != null)
                {
                    if (o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup != null)
                    {
                        o365RemoveDistributionGroupMember["ExceptionIfMemberNotInGroup"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup);
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
                o365RemoveDistributionGroupMember["Workflow"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupMemberworkflow);
                if (o365RemoveDistributionGroupMemberpropCount > 0)
                {
                    callPayload.Body = o365RemoveDistributionGroupMember;
                }

                return new ApiConnectionAction<O365RemoveDistributionGroupMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365GetMailboxDistributionGroupMembership))]
        public IBodyWorkflowAction<O365GetMailboxDistributionGroupMembershipResponse> O365GetMailboxDistributionGroupMembership([WorkflowExpression] Func<string> o365GetMailboxDistributionGroupMembershipmailboxIdentity, [WorkflowExpression] Func<string> o365GetMailboxDistributionGroupMembershipworkflow, [WorkflowExpression] Func<string> o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365GetMailboxDistributionGroupMembershipResponse> __BuildO365GetMailboxDistributionGroupMembership(WorkflowValue<string> o365GetMailboxDistributionGroupMembershipmailboxIdentity, WorkflowValue<string> o365GetMailboxDistributionGroupMembershipworkflow, WorkflowValue<string> o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON = null)
        {
            WorkflowValue.Validate(o365GetMailboxDistributionGroupMembershipmailboxIdentity, nameof(o365GetMailboxDistributionGroupMembershipmailboxIdentity), required: true);
            WorkflowValue.Validate(o365GetMailboxDistributionGroupMembershipworkflow, nameof(o365GetMailboxDistributionGroupMembershipworkflow), required: true);
            WorkflowValue.Validate(o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON, nameof(o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON), required: false);
            return new DeferredBodyAction<O365GetMailboxDistributionGroupMembershipResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365GetMailboxDistributionGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365GetMailboxDistributionGroupMembership = new JObject();
                var o365GetMailboxDistributionGroupMembershippropCount = 0;
                o365GetMailboxDistributionGroupMembershippropCount++;
                o365GetMailboxDistributionGroupMembership["MailboxIdentity"] = ExpressionConverter.ConvertO(o365GetMailboxDistributionGroupMembershipmailboxIdentity);
                if (o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON != null)
                {
                    o365GetMailboxDistributionGroupMembership["PropertiesToRetrieveJSON"] = ExpressionConverter.ConvertO(o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON);
                    o365GetMailboxDistributionGroupMembershippropCount++;
                }

                o365GetMailboxDistributionGroupMembershippropCount++;
                o365GetMailboxDistributionGroupMembership["Workflow"] = ExpressionConverter.ConvertO(o365GetMailboxDistributionGroupMembershipworkflow);
                if (o365GetMailboxDistributionGroupMembershippropCount > 0)
                {
                    callPayload.Body = o365GetMailboxDistributionGroupMembership;
                }

                return new ApiConnectionAction<O365GetMailboxDistributionGroupMembershipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365GetDistributionGroupMembers))]
        public IBodyWorkflowAction<O365GetDistributionGroupMembersResponse> O365GetDistributionGroupMembers([WorkflowExpression] Func<string> o365GetDistributionGroupMembersgroupIdentity, [WorkflowExpression] Func<string> o365GetDistributionGroupMembersworkflow, [WorkflowExpression] Func<string> o365GetDistributionGroupMemberspropertiesToRetrieveJSON = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365GetDistributionGroupMembersResponse> __BuildO365GetDistributionGroupMembers(WorkflowValue<string> o365GetDistributionGroupMembersgroupIdentity, WorkflowValue<string> o365GetDistributionGroupMembersworkflow, WorkflowValue<string> o365GetDistributionGroupMemberspropertiesToRetrieveJSON = null)
        {
            WorkflowValue.Validate(o365GetDistributionGroupMembersgroupIdentity, nameof(o365GetDistributionGroupMembersgroupIdentity), required: true);
            WorkflowValue.Validate(o365GetDistributionGroupMembersworkflow, nameof(o365GetDistributionGroupMembersworkflow), required: true);
            WorkflowValue.Validate(o365GetDistributionGroupMemberspropertiesToRetrieveJSON, nameof(o365GetDistributionGroupMemberspropertiesToRetrieveJSON), required: false);
            return new DeferredBodyAction<O365GetDistributionGroupMembersResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365GetDistributionGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365GetDistributionGroupMembers = new JObject();
                var o365GetDistributionGroupMemberspropCount = 0;
                o365GetDistributionGroupMemberspropCount++;
                o365GetDistributionGroupMembers["GroupIdentity"] = ExpressionConverter.ConvertO(o365GetDistributionGroupMembersgroupIdentity);
                if (o365GetDistributionGroupMemberspropertiesToRetrieveJSON != null)
                {
                    o365GetDistributionGroupMembers["PropertiesToRetrieveJSON"] = ExpressionConverter.ConvertO(o365GetDistributionGroupMemberspropertiesToRetrieveJSON);
                    o365GetDistributionGroupMemberspropCount++;
                }

                o365GetDistributionGroupMemberspropCount++;
                o365GetDistributionGroupMembers["Workflow"] = ExpressionConverter.ConvertO(o365GetDistributionGroupMembersworkflow);
                if (o365GetDistributionGroupMemberspropCount > 0)
                {
                    callPayload.Body = o365GetDistributionGroupMembers;
                }

                return new ApiConnectionAction<O365GetDistributionGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365RemoveMailboxFromAllDistributionGroups))]
        public IBodyWorkflowAction<O365RemoveMailboxFromAllDistributionGroupsResponse> O365RemoveMailboxFromAllDistributionGroups([WorkflowExpression] Func<string> o365RemoveMailboxFromAllDistributionGroupsworkflow, [WorkflowExpression] Func<string> o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity = null, [WorkflowExpression] Func<bool> o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck = null, [WorkflowExpression] Func<bool> o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove = null, [WorkflowExpression] Func<bool> o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove = null, [WorkflowExpression] Func<string> o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON = null, [WorkflowExpression] Func<bool> o365RemoveMailboxFromAllDistributionGroupsrunAsThread = null, [WorkflowExpression] Func<int> o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365RemoveMailboxFromAllDistributionGroupsResponse> __BuildO365RemoveMailboxFromAllDistributionGroups(WorkflowValue<string> o365RemoveMailboxFromAllDistributionGroupsworkflow, WorkflowValue<string> o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity = null, WorkflowValue<bool> o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck = null, WorkflowValue<bool> o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove = null, WorkflowValue<bool> o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove = null, WorkflowValue<string> o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON = null, WorkflowValue<bool> o365RemoveMailboxFromAllDistributionGroupsrunAsThread = null, WorkflowValue<int> o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId = null, WorkflowValue<int> o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread = null)
        {
            WorkflowValue.Validate(o365RemoveMailboxFromAllDistributionGroupsworkflow, nameof(o365RemoveMailboxFromAllDistributionGroupsworkflow), required: true);
            WorkflowValue.Validate(o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity, nameof(o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity), required: false);
            WorkflowValue.Validate(o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck, nameof(o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck), required: false);
            WorkflowValue.Validate(o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove, nameof(o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove), required: false);
            WorkflowValue.Validate(o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove, nameof(o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove), required: false);
            WorkflowValue.Validate(o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON, nameof(o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON), required: false);
            WorkflowValue.Validate(o365RemoveMailboxFromAllDistributionGroupsrunAsThread, nameof(o365RemoveMailboxFromAllDistributionGroupsrunAsThread), required: false);
            WorkflowValue.Validate(o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId, nameof(o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId), required: false);
            WorkflowValue.Validate(o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread, nameof(o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread), required: false);
            return new DeferredBodyAction<O365RemoveMailboxFromAllDistributionGroupsResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveMailboxFromAllDistributionGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365RemoveMailboxFromAllDistributionGroups = new JObject();
                var o365RemoveMailboxFromAllDistributionGroupspropCount = 0;
                if (o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity != null)
                {
                    o365RemoveMailboxFromAllDistributionGroups["MailboxIdentity"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity);
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck != null)
                {
                    if (o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck != null)
                    {
                        o365RemoveMailboxFromAllDistributionGroups["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck);
                        o365RemoveMailboxFromAllDistributionGroupspropCount++;
                    }

                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }
                else
                {
                    o365RemoveMailboxFromAllDistributionGroups["BypassSecurityGroupManagerCheck"] = true;
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove != null)
                {
                    if (o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove != null)
                    {
                        o365RemoveMailboxFromAllDistributionGroups["ExceptionIfAnyGroupsFailToRemove"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove);
                        o365RemoveMailboxFromAllDistributionGroupspropCount++;
                    }

                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }
                else
                {
                    o365RemoveMailboxFromAllDistributionGroups["ExceptionIfAnyGroupsFailToRemove"] = false;
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove != null)
                {
                    if (o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove != null)
                    {
                        o365RemoveMailboxFromAllDistributionGroups["ExceptionIfAllGroupsFailToRemove"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove);
                        o365RemoveMailboxFromAllDistributionGroupspropCount++;
                    }

                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }
                else
                {
                    o365RemoveMailboxFromAllDistributionGroups["ExceptionIfAllGroupsFailToRemove"] = true;
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON != null)
                {
                    o365RemoveMailboxFromAllDistributionGroups["GroupDNsToExcludeJSON"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON);
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (o365RemoveMailboxFromAllDistributionGroupsrunAsThread != null)
                {
                    if (o365RemoveMailboxFromAllDistributionGroupsrunAsThread != null)
                    {
                        o365RemoveMailboxFromAllDistributionGroups["RunAsThread"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsrunAsThread);
                        o365RemoveMailboxFromAllDistributionGroupspropCount++;
                    }

                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }
                else
                {
                    o365RemoveMailboxFromAllDistributionGroups["RunAsThread"] = false;
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId != null)
                {
                    o365RemoveMailboxFromAllDistributionGroups["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId);
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread != null)
                {
                    if (o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread != null)
                    {
                        o365RemoveMailboxFromAllDistributionGroups["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread);
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
                o365RemoveMailboxFromAllDistributionGroups["Workflow"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsworkflow);
                if (o365RemoveMailboxFromAllDistributionGroupspropCount > 0)
                {
                    callPayload.Body = o365RemoveMailboxFromAllDistributionGroups;
                }

                return new ApiConnectionAction<O365RemoveMailboxFromAllDistributionGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365NewMailbox))]
        public IBodyWorkflowAction<O365NewMailboxResponse> O365NewMailbox([WorkflowExpression] Func<string> o365NewMailboxmicrosoftOnlineServicesID, [WorkflowExpression] Func<string> o365NewMailboxname, [WorkflowExpression] Func<string> o365NewMailboxworkflow, [WorkflowExpression] Func<string> o365NewMailboxfirstName = null, [WorkflowExpression] Func<string> o365NewMailboxlastName = null, [WorkflowExpression] Func<string> o365NewMailboxinitials = null, [WorkflowExpression] Func<string> o365NewMailboxdisplayName = null, [WorkflowExpression] Func<string> o365NewMailboxalias = null, [WorkflowExpression] Func<string> o365NewMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<string> o365NewMailboxpassword = null, [WorkflowExpression] Func<bool> o365NewMailboxaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> o365NewMailboxresetPasswordOnNextLogon = null, [WorkflowExpression] Func<bool> o365NewMailboxarchive = null, [WorkflowExpression] Func<string> o365NewMailboxmailboxPlan = null, [WorkflowExpression] Func<string> o365NewMailboxmailboxRegion = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365NewMailboxResponse> __BuildO365NewMailbox(WorkflowValue<string> o365NewMailboxmicrosoftOnlineServicesID, WorkflowValue<string> o365NewMailboxname, WorkflowValue<string> o365NewMailboxworkflow, WorkflowValue<string> o365NewMailboxfirstName = null, WorkflowValue<string> o365NewMailboxlastName = null, WorkflowValue<string> o365NewMailboxinitials = null, WorkflowValue<string> o365NewMailboxdisplayName = null, WorkflowValue<string> o365NewMailboxalias = null, WorkflowValue<string> o365NewMailboxprimarySmtpAddress = null, WorkflowValue<string> o365NewMailboxpassword = null, WorkflowValue<bool> o365NewMailboxaccountPasswordIsStoredPassword = null, WorkflowValue<bool> o365NewMailboxresetPasswordOnNextLogon = null, WorkflowValue<bool> o365NewMailboxarchive = null, WorkflowValue<string> o365NewMailboxmailboxPlan = null, WorkflowValue<string> o365NewMailboxmailboxRegion = null)
        {
            WorkflowValue.Validate(o365NewMailboxmicrosoftOnlineServicesID, nameof(o365NewMailboxmicrosoftOnlineServicesID), required: true);
            WorkflowValue.Validate(o365NewMailboxname, nameof(o365NewMailboxname), required: true);
            WorkflowValue.Validate(o365NewMailboxworkflow, nameof(o365NewMailboxworkflow), required: true);
            WorkflowValue.Validate(o365NewMailboxfirstName, nameof(o365NewMailboxfirstName), required: false);
            WorkflowValue.Validate(o365NewMailboxlastName, nameof(o365NewMailboxlastName), required: false);
            WorkflowValue.Validate(o365NewMailboxinitials, nameof(o365NewMailboxinitials), required: false);
            WorkflowValue.Validate(o365NewMailboxdisplayName, nameof(o365NewMailboxdisplayName), required: false);
            WorkflowValue.Validate(o365NewMailboxalias, nameof(o365NewMailboxalias), required: false);
            WorkflowValue.Validate(o365NewMailboxprimarySmtpAddress, nameof(o365NewMailboxprimarySmtpAddress), required: false);
            WorkflowValue.Validate(o365NewMailboxpassword, nameof(o365NewMailboxpassword), required: false);
            WorkflowValue.Validate(o365NewMailboxaccountPasswordIsStoredPassword, nameof(o365NewMailboxaccountPasswordIsStoredPassword), required: false);
            WorkflowValue.Validate(o365NewMailboxresetPasswordOnNextLogon, nameof(o365NewMailboxresetPasswordOnNextLogon), required: false);
            WorkflowValue.Validate(o365NewMailboxarchive, nameof(o365NewMailboxarchive), required: false);
            WorkflowValue.Validate(o365NewMailboxmailboxPlan, nameof(o365NewMailboxmailboxPlan), required: false);
            WorkflowValue.Validate(o365NewMailboxmailboxRegion, nameof(o365NewMailboxmailboxRegion), required: false);
            return new DeferredBodyAction<O365NewMailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365NewMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365NewMailbox = new JObject();
                var o365NewMailboxpropCount = 0;
                o365NewMailboxpropCount++;
                o365NewMailbox["MicrosoftOnlineServicesID"] = ExpressionConverter.ConvertO(o365NewMailboxmicrosoftOnlineServicesID);
                o365NewMailboxpropCount++;
                o365NewMailbox["Name"] = ExpressionConverter.ConvertO(o365NewMailboxname);
                if (o365NewMailboxfirstName != null)
                {
                    o365NewMailbox["FirstName"] = ExpressionConverter.ConvertO(o365NewMailboxfirstName);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxlastName != null)
                {
                    o365NewMailbox["LastName"] = ExpressionConverter.ConvertO(o365NewMailboxlastName);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxinitials != null)
                {
                    o365NewMailbox["Initials"] = ExpressionConverter.ConvertO(o365NewMailboxinitials);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxdisplayName != null)
                {
                    o365NewMailbox["DisplayName"] = ExpressionConverter.ConvertO(o365NewMailboxdisplayName);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxalias != null)
                {
                    o365NewMailbox["Alias"] = ExpressionConverter.ConvertO(o365NewMailboxalias);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxprimarySmtpAddress != null)
                {
                    o365NewMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(o365NewMailboxprimarySmtpAddress);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxpassword != null)
                {
                    o365NewMailbox["Password"] = ExpressionConverter.ConvertO(o365NewMailboxpassword);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxaccountPasswordIsStoredPassword != null)
                {
                    if (o365NewMailboxaccountPasswordIsStoredPassword != null)
                    {
                        o365NewMailbox["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(o365NewMailboxaccountPasswordIsStoredPassword);
                        o365NewMailboxpropCount++;
                    }

                    o365NewMailboxpropCount++;
                }
                else
                {
                    o365NewMailbox["AccountPasswordIsStoredPassword"] = false;
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxresetPasswordOnNextLogon != null)
                {
                    if (o365NewMailboxresetPasswordOnNextLogon != null)
                    {
                        o365NewMailbox["ResetPasswordOnNextLogon"] = ExpressionConverter.ConvertO(o365NewMailboxresetPasswordOnNextLogon);
                        o365NewMailboxpropCount++;
                    }

                    o365NewMailboxpropCount++;
                }
                else
                {
                    o365NewMailbox["ResetPasswordOnNextLogon"] = true;
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxarchive != null)
                {
                    if (o365NewMailboxarchive != null)
                    {
                        o365NewMailbox["Archive"] = ExpressionConverter.ConvertO(o365NewMailboxarchive);
                        o365NewMailboxpropCount++;
                    }

                    o365NewMailboxpropCount++;
                }
                else
                {
                    o365NewMailbox["Archive"] = false;
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxmailboxPlan != null)
                {
                    o365NewMailbox["MailboxPlan"] = ExpressionConverter.ConvertO(o365NewMailboxmailboxPlan);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxmailboxRegion != null)
                {
                    o365NewMailbox["MailboxRegion"] = ExpressionConverter.ConvertO(o365NewMailboxmailboxRegion);
                    o365NewMailboxpropCount++;
                }

                o365NewMailboxpropCount++;
                o365NewMailbox["Workflow"] = ExpressionConverter.ConvertO(o365NewMailboxworkflow);
                if (o365NewMailboxpropCount > 0)
                {
                    callPayload.Body = o365NewMailbox;
                }

                return new ApiConnectionAction<O365NewMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365NewSharedMailbox))]
        public IBodyWorkflowAction<O365NewSharedMailboxResponse> O365NewSharedMailbox([WorkflowExpression] Func<string> o365NewSharedMailboxname, [WorkflowExpression] Func<string> o365NewSharedMailboxworkflow, [WorkflowExpression] Func<string> o365NewSharedMailboxfirstName = null, [WorkflowExpression] Func<string> o365NewSharedMailboxlastName = null, [WorkflowExpression] Func<string> o365NewSharedMailboxinitials = null, [WorkflowExpression] Func<string> o365NewSharedMailboxdisplayName = null, [WorkflowExpression] Func<string> o365NewSharedMailboxalias = null, [WorkflowExpression] Func<string> o365NewSharedMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<bool> o365NewSharedMailboxarchive = null, [WorkflowExpression] Func<string> o365NewSharedMailboxmailboxRegion = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365NewSharedMailboxResponse> __BuildO365NewSharedMailbox(WorkflowValue<string> o365NewSharedMailboxname, WorkflowValue<string> o365NewSharedMailboxworkflow, WorkflowValue<string> o365NewSharedMailboxfirstName = null, WorkflowValue<string> o365NewSharedMailboxlastName = null, WorkflowValue<string> o365NewSharedMailboxinitials = null, WorkflowValue<string> o365NewSharedMailboxdisplayName = null, WorkflowValue<string> o365NewSharedMailboxalias = null, WorkflowValue<string> o365NewSharedMailboxprimarySmtpAddress = null, WorkflowValue<bool> o365NewSharedMailboxarchive = null, WorkflowValue<string> o365NewSharedMailboxmailboxRegion = null)
        {
            WorkflowValue.Validate(o365NewSharedMailboxname, nameof(o365NewSharedMailboxname), required: true);
            WorkflowValue.Validate(o365NewSharedMailboxworkflow, nameof(o365NewSharedMailboxworkflow), required: true);
            WorkflowValue.Validate(o365NewSharedMailboxfirstName, nameof(o365NewSharedMailboxfirstName), required: false);
            WorkflowValue.Validate(o365NewSharedMailboxlastName, nameof(o365NewSharedMailboxlastName), required: false);
            WorkflowValue.Validate(o365NewSharedMailboxinitials, nameof(o365NewSharedMailboxinitials), required: false);
            WorkflowValue.Validate(o365NewSharedMailboxdisplayName, nameof(o365NewSharedMailboxdisplayName), required: false);
            WorkflowValue.Validate(o365NewSharedMailboxalias, nameof(o365NewSharedMailboxalias), required: false);
            WorkflowValue.Validate(o365NewSharedMailboxprimarySmtpAddress, nameof(o365NewSharedMailboxprimarySmtpAddress), required: false);
            WorkflowValue.Validate(o365NewSharedMailboxarchive, nameof(o365NewSharedMailboxarchive), required: false);
            WorkflowValue.Validate(o365NewSharedMailboxmailboxRegion, nameof(o365NewSharedMailboxmailboxRegion), required: false);
            return new DeferredBodyAction<O365NewSharedMailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365NewSharedMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365NewSharedMailbox = new JObject();
                var o365NewSharedMailboxpropCount = 0;
                o365NewSharedMailboxpropCount++;
                o365NewSharedMailbox["Name"] = ExpressionConverter.ConvertO(o365NewSharedMailboxname);
                if (o365NewSharedMailboxfirstName != null)
                {
                    o365NewSharedMailbox["FirstName"] = ExpressionConverter.ConvertO(o365NewSharedMailboxfirstName);
                    o365NewSharedMailboxpropCount++;
                }

                if (o365NewSharedMailboxlastName != null)
                {
                    o365NewSharedMailbox["LastName"] = ExpressionConverter.ConvertO(o365NewSharedMailboxlastName);
                    o365NewSharedMailboxpropCount++;
                }

                if (o365NewSharedMailboxinitials != null)
                {
                    o365NewSharedMailbox["Initials"] = ExpressionConverter.ConvertO(o365NewSharedMailboxinitials);
                    o365NewSharedMailboxpropCount++;
                }

                if (o365NewSharedMailboxdisplayName != null)
                {
                    o365NewSharedMailbox["DisplayName"] = ExpressionConverter.ConvertO(o365NewSharedMailboxdisplayName);
                    o365NewSharedMailboxpropCount++;
                }

                if (o365NewSharedMailboxalias != null)
                {
                    o365NewSharedMailbox["Alias"] = ExpressionConverter.ConvertO(o365NewSharedMailboxalias);
                    o365NewSharedMailboxpropCount++;
                }

                if (o365NewSharedMailboxprimarySmtpAddress != null)
                {
                    o365NewSharedMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(o365NewSharedMailboxprimarySmtpAddress);
                    o365NewSharedMailboxpropCount++;
                }

                if (o365NewSharedMailboxarchive != null)
                {
                    if (o365NewSharedMailboxarchive != null)
                    {
                        o365NewSharedMailbox["Archive"] = ExpressionConverter.ConvertO(o365NewSharedMailboxarchive);
                        o365NewSharedMailboxpropCount++;
                    }

                    o365NewSharedMailboxpropCount++;
                }
                else
                {
                    o365NewSharedMailbox["Archive"] = false;
                    o365NewSharedMailboxpropCount++;
                }

                if (o365NewSharedMailboxmailboxRegion != null)
                {
                    o365NewSharedMailbox["MailboxRegion"] = ExpressionConverter.ConvertO(o365NewSharedMailboxmailboxRegion);
                    o365NewSharedMailboxpropCount++;
                }

                o365NewSharedMailboxpropCount++;
                o365NewSharedMailbox["Workflow"] = ExpressionConverter.ConvertO(o365NewSharedMailboxworkflow);
                if (o365NewSharedMailboxpropCount > 0)
                {
                    callPayload.Body = o365NewSharedMailbox;
                }

                return new ApiConnectionAction<O365NewSharedMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365EnableArchiveMailbox))]
        public IBodyWorkflowAction<O365EnableArchiveMailboxResponse> O365EnableArchiveMailbox([WorkflowExpression] Func<string> o365EnableArchiveMailboxidentity, [WorkflowExpression] Func<string> o365EnableArchiveMailboxworkflow, [WorkflowExpression] Func<bool> o365EnableArchiveMailboxcheckIfArchiveExists = null, [WorkflowExpression] Func<string> o365EnableArchiveMailboxarchiveName = null, [WorkflowExpression] Func<bool> o365EnableArchiveMailboxautoExpandingArchive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365EnableArchiveMailboxResponse> __BuildO365EnableArchiveMailbox(WorkflowValue<string> o365EnableArchiveMailboxidentity, WorkflowValue<string> o365EnableArchiveMailboxworkflow, WorkflowValue<bool> o365EnableArchiveMailboxcheckIfArchiveExists = null, WorkflowValue<string> o365EnableArchiveMailboxarchiveName = null, WorkflowValue<bool> o365EnableArchiveMailboxautoExpandingArchive = null)
        {
            WorkflowValue.Validate(o365EnableArchiveMailboxidentity, nameof(o365EnableArchiveMailboxidentity), required: true);
            WorkflowValue.Validate(o365EnableArchiveMailboxworkflow, nameof(o365EnableArchiveMailboxworkflow), required: true);
            WorkflowValue.Validate(o365EnableArchiveMailboxcheckIfArchiveExists, nameof(o365EnableArchiveMailboxcheckIfArchiveExists), required: false);
            WorkflowValue.Validate(o365EnableArchiveMailboxarchiveName, nameof(o365EnableArchiveMailboxarchiveName), required: false);
            WorkflowValue.Validate(o365EnableArchiveMailboxautoExpandingArchive, nameof(o365EnableArchiveMailboxautoExpandingArchive), required: false);
            return new DeferredBodyAction<O365EnableArchiveMailboxResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365EnableArchiveMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365EnableArchiveMailbox = new JObject();
                var o365EnableArchiveMailboxpropCount = 0;
                o365EnableArchiveMailboxpropCount++;
                o365EnableArchiveMailbox["Identity"] = ExpressionConverter.ConvertO(o365EnableArchiveMailboxidentity);
                if (o365EnableArchiveMailboxcheckIfArchiveExists != null)
                {
                    if (o365EnableArchiveMailboxcheckIfArchiveExists != null)
                    {
                        o365EnableArchiveMailbox["CheckIfArchiveExists"] = ExpressionConverter.ConvertO(o365EnableArchiveMailboxcheckIfArchiveExists);
                        o365EnableArchiveMailboxpropCount++;
                    }

                    o365EnableArchiveMailboxpropCount++;
                }
                else
                {
                    o365EnableArchiveMailbox["CheckIfArchiveExists"] = true;
                    o365EnableArchiveMailboxpropCount++;
                }

                if (o365EnableArchiveMailboxarchiveName != null)
                {
                    o365EnableArchiveMailbox["ArchiveName"] = ExpressionConverter.ConvertO(o365EnableArchiveMailboxarchiveName);
                    o365EnableArchiveMailboxpropCount++;
                }

                if (o365EnableArchiveMailboxautoExpandingArchive != null)
                {
                    if (o365EnableArchiveMailboxautoExpandingArchive != null)
                    {
                        o365EnableArchiveMailbox["AutoExpandingArchive"] = ExpressionConverter.ConvertO(o365EnableArchiveMailboxautoExpandingArchive);
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
                o365EnableArchiveMailbox["Workflow"] = ExpressionConverter.ConvertO(o365EnableArchiveMailboxworkflow);
                if (o365EnableArchiveMailboxpropCount > 0)
                {
                    callPayload.Body = o365EnableArchiveMailbox;
                }

                return new ApiConnectionAction<O365EnableArchiveMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildO365DoesMailboxHaveAnArchive))]
        public IBodyWorkflowAction<O365DoesMailboxHaveAnArchiveResponse> O365DoesMailboxHaveAnArchive([WorkflowExpression] Func<string> o365DoesMailboxHaveAnArchiveidentity, [WorkflowExpression] Func<string> o365DoesMailboxHaveAnArchiveworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<O365DoesMailboxHaveAnArchiveResponse> __BuildO365DoesMailboxHaveAnArchive(WorkflowValue<string> o365DoesMailboxHaveAnArchiveidentity, WorkflowValue<string> o365DoesMailboxHaveAnArchiveworkflow)
        {
            WorkflowValue.Validate(o365DoesMailboxHaveAnArchiveidentity, nameof(o365DoesMailboxHaveAnArchiveidentity), required: true);
            WorkflowValue.Validate(o365DoesMailboxHaveAnArchiveworkflow, nameof(o365DoesMailboxHaveAnArchiveworkflow), required: true);
            return new DeferredBodyAction<O365DoesMailboxHaveAnArchiveResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365DoesMailboxHaveAnArchive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365DoesMailboxHaveAnArchive = new JObject();
                var o365DoesMailboxHaveAnArchivepropCount = 0;
                o365DoesMailboxHaveAnArchivepropCount++;
                o365DoesMailboxHaveAnArchive["Identity"] = ExpressionConverter.ConvertO(o365DoesMailboxHaveAnArchiveidentity);
                o365DoesMailboxHaveAnArchivepropCount++;
                o365DoesMailboxHaveAnArchive["Workflow"] = ExpressionConverter.ConvertO(o365DoesMailboxHaveAnArchiveworkflow);
                if (o365DoesMailboxHaveAnArchivepropCount > 0)
                {
                    callPayload.Body = o365DoesMailboxHaveAnArchive;
                }

                return new ApiConnectionAction<O365DoesMailboxHaveAnArchiveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildJMLGetNextAvailableAccountName))]
        public IBodyWorkflowAction<JMLGetNextAvailableAccountNameResponse> JMLGetNextAvailableAccountName([WorkflowExpression] Func<string> jMLGetNextAvailableAccountNameworkflow, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefirstName = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamemiddleName = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamelastName = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefieldA = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefieldB = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefieldC = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefieldD = null, [WorkflowExpression] Func<int> jMLGetNextAvailableAccountNamevariableMStartValue = null, [WorkflowExpression] Func<int> jMLGetNextAvailableAccountNamevariableNStartValue = null, [WorkflowExpression] Func<int> jMLGetNextAvailableAccountNamevariableXStartValue = null, [WorkflowExpression] Func<int> jMLGetNextAvailableAccountNamemaxAttempts = null, [WorkflowExpression] Func<bool> jMLGetNextAvailableAccountNamefallbackCausesRetest = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamenumbersNotToUse = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs = null, [WorkflowExpression] Func<bool> jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs = null, [WorkflowExpression] Func<bool> jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamesequenceA1 = null, [WorkflowExpression] Func<jMLGetNextAvailableAccountNamepropertiesToCheckListInputItem[]> jMLGetNextAvailableAccountNamepropertiesToCheckList = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JMLGetNextAvailableAccountNameResponse> __BuildJMLGetNextAvailableAccountName(WorkflowValue<string> jMLGetNextAvailableAccountNameworkflow, WorkflowValue<string> jMLGetNextAvailableAccountNamefirstName = null, WorkflowValue<string> jMLGetNextAvailableAccountNamemiddleName = null, WorkflowValue<string> jMLGetNextAvailableAccountNamelastName = null, WorkflowValue<string> jMLGetNextAvailableAccountNamefieldA = null, WorkflowValue<string> jMLGetNextAvailableAccountNamefieldB = null, WorkflowValue<string> jMLGetNextAvailableAccountNamefieldC = null, WorkflowValue<string> jMLGetNextAvailableAccountNamefieldD = null, WorkflowValue<int> jMLGetNextAvailableAccountNamevariableMStartValue = null, WorkflowValue<int> jMLGetNextAvailableAccountNamevariableNStartValue = null, WorkflowValue<int> jMLGetNextAvailableAccountNamevariableXStartValue = null, WorkflowValue<int> jMLGetNextAvailableAccountNamemaxAttempts = null, WorkflowValue<bool> jMLGetNextAvailableAccountNamefallbackCausesRetest = null, WorkflowValue<string> jMLGetNextAvailableAccountNamenumbersNotToUse = null, WorkflowValue<string> jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs = null, WorkflowValue<bool> jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs = null, WorkflowValue<bool> jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs = null, WorkflowValue<string> jMLGetNextAvailableAccountNamesequenceA1 = null, WorkflowValue<jMLGetNextAvailableAccountNamepropertiesToCheckListInputItem[]> jMLGetNextAvailableAccountNamepropertiesToCheckList = null)
        {
            WorkflowValue.Validate(jMLGetNextAvailableAccountNameworkflow, nameof(jMLGetNextAvailableAccountNameworkflow), required: true);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamefirstName, nameof(jMLGetNextAvailableAccountNamefirstName), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamemiddleName, nameof(jMLGetNextAvailableAccountNamemiddleName), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamelastName, nameof(jMLGetNextAvailableAccountNamelastName), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamefieldA, nameof(jMLGetNextAvailableAccountNamefieldA), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamefieldB, nameof(jMLGetNextAvailableAccountNamefieldB), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamefieldC, nameof(jMLGetNextAvailableAccountNamefieldC), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamefieldD, nameof(jMLGetNextAvailableAccountNamefieldD), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamevariableMStartValue, nameof(jMLGetNextAvailableAccountNamevariableMStartValue), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamevariableNStartValue, nameof(jMLGetNextAvailableAccountNamevariableNStartValue), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamevariableXStartValue, nameof(jMLGetNextAvailableAccountNamevariableXStartValue), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamemaxAttempts, nameof(jMLGetNextAvailableAccountNamemaxAttempts), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamefallbackCausesRetest, nameof(jMLGetNextAvailableAccountNamefallbackCausesRetest), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamenumbersNotToUse, nameof(jMLGetNextAvailableAccountNamenumbersNotToUse), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs, nameof(jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs, nameof(jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs, nameof(jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamesequenceA1, nameof(jMLGetNextAvailableAccountNamesequenceA1), required: false);
            WorkflowValue.Validate(jMLGetNextAvailableAccountNamepropertiesToCheckList, nameof(jMLGetNextAvailableAccountNamepropertiesToCheckList), required: false);
            return new DeferredBodyAction<JMLGetNextAvailableAccountNameResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/JMLGetNextAvailableAccountName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jMLGetNextAvailableAccountName = new JObject();
                var jMLGetNextAvailableAccountNamepropCount = 0;
                if (jMLGetNextAvailableAccountNamefirstName != null)
                {
                    jMLGetNextAvailableAccountName["FirstName"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamefirstName);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamemiddleName != null)
                {
                    jMLGetNextAvailableAccountName["MiddleName"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamemiddleName);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamelastName != null)
                {
                    jMLGetNextAvailableAccountName["LastName"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamelastName);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamefieldA != null)
                {
                    jMLGetNextAvailableAccountName["FieldA"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamefieldA);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamefieldB != null)
                {
                    jMLGetNextAvailableAccountName["FieldB"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamefieldB);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamefieldC != null)
                {
                    jMLGetNextAvailableAccountName["FieldC"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamefieldC);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamefieldD != null)
                {
                    jMLGetNextAvailableAccountName["FieldD"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamefieldD);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamevariableMStartValue != null)
                {
                    if (jMLGetNextAvailableAccountNamevariableMStartValue != null)
                    {
                        jMLGetNextAvailableAccountName["VariableMStartValue"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamevariableMStartValue);
                        jMLGetNextAvailableAccountNamepropCount++;
                    }

                    jMLGetNextAvailableAccountNamepropCount++;
                }
                else
                {
                    jMLGetNextAvailableAccountName["VariableMStartValue"] = 2;
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamevariableNStartValue != null)
                {
                    if (jMLGetNextAvailableAccountNamevariableNStartValue != null)
                    {
                        jMLGetNextAvailableAccountName["VariableNStartValue"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamevariableNStartValue);
                        jMLGetNextAvailableAccountNamepropCount++;
                    }

                    jMLGetNextAvailableAccountNamepropCount++;
                }
                else
                {
                    jMLGetNextAvailableAccountName["VariableNStartValue"] = 2;
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamevariableXStartValue != null)
                {
                    if (jMLGetNextAvailableAccountNamevariableXStartValue != null)
                    {
                        jMLGetNextAvailableAccountName["VariableXStartValue"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamevariableXStartValue);
                        jMLGetNextAvailableAccountNamepropCount++;
                    }

                    jMLGetNextAvailableAccountNamepropCount++;
                }
                else
                {
                    jMLGetNextAvailableAccountName["VariableXStartValue"] = 2;
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamemaxAttempts != null)
                {
                    if (jMLGetNextAvailableAccountNamemaxAttempts != null)
                    {
                        jMLGetNextAvailableAccountName["MaxAttempts"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamemaxAttempts);
                        jMLGetNextAvailableAccountNamepropCount++;
                    }

                    jMLGetNextAvailableAccountNamepropCount++;
                }
                else
                {
                    jMLGetNextAvailableAccountName["MaxAttempts"] = 20;
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamefallbackCausesRetest != null)
                {
                    if (jMLGetNextAvailableAccountNamefallbackCausesRetest != null)
                    {
                        jMLGetNextAvailableAccountName["FallbackCausesRetest"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamefallbackCausesRetest);
                        jMLGetNextAvailableAccountNamepropCount++;
                    }

                    jMLGetNextAvailableAccountNamepropCount++;
                }
                else
                {
                    jMLGetNextAvailableAccountName["FallbackCausesRetest"] = true;
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamenumbersNotToUse != null)
                {
                    jMLGetNextAvailableAccountName["NumbersNotToUse"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamenumbersNotToUse);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs != null)
                {
                    jMLGetNextAvailableAccountName["CharactersToRemoveFromInputs"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs != null)
                {
                    if (jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs != null)
                    {
                        jMLGetNextAvailableAccountName["RemoveDiacriticsFromInputs"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs);
                        jMLGetNextAvailableAccountNamepropCount++;
                    }

                    jMLGetNextAvailableAccountNamepropCount++;
                }
                else
                {
                    jMLGetNextAvailableAccountName["RemoveDiacriticsFromInputs"] = true;
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs != null)
                {
                    if (jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs != null)
                    {
                        jMLGetNextAvailableAccountName["RemoveNonAlphaNumericFromInputs"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs);
                        jMLGetNextAvailableAccountNamepropCount++;
                    }

                    jMLGetNextAvailableAccountNamepropCount++;
                }
                else
                {
                    jMLGetNextAvailableAccountName["RemoveNonAlphaNumericFromInputs"] = true;
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamesequenceA1 != null)
                {
                    jMLGetNextAvailableAccountName["SequenceA1"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamesequenceA1);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamepropertiesToCheckList != null)
                {
                    jMLGetNextAvailableAccountName["PropertiesToCheckList"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamepropertiesToCheckList);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                jMLGetNextAvailableAccountNamepropCount++;
                jMLGetNextAvailableAccountName["Workflow"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameworkflow);
                if (jMLGetNextAvailableAccountNamepropCount > 0)
                {
                    callPayload.Body = jMLGetNextAvailableAccountName;
                }

                return new ApiConnectionAction<JMLGetNextAvailableAccountNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        [WorkflowExpressionFactory(nameof(__BuildJMLConnectToJMLEnvironment))]
        public IBodyWorkflowAction<JMLConnectToJMLEnvironmentResponse> JMLConnectToJMLEnvironment([WorkflowExpression] Func<string> jMLConnectToJMLEnvironmentworkflow, [WorkflowExpression] Func<string> jMLConnectToJMLEnvironmentfriendlyName = null, [WorkflowExpression] Func<bool> jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JMLConnectToJMLEnvironmentResponse> __BuildJMLConnectToJMLEnvironment(WorkflowValue<string> jMLConnectToJMLEnvironmentworkflow, WorkflowValue<string> jMLConnectToJMLEnvironmentfriendlyName = null, WorkflowValue<bool> jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected = null)
        {
            WorkflowValue.Validate(jMLConnectToJMLEnvironmentworkflow, nameof(jMLConnectToJMLEnvironmentworkflow), required: true);
            WorkflowValue.Validate(jMLConnectToJMLEnvironmentfriendlyName, nameof(jMLConnectToJMLEnvironmentfriendlyName), required: false);
            WorkflowValue.Validate(jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected, nameof(jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected), required: false);
            return new DeferredBodyAction<JMLConnectToJMLEnvironmentResponse>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/JMLConnectToJMLEnvironment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jMLConnectToJMLEnvironment = new JObject();
                var jMLConnectToJMLEnvironmentpropCount = 0;
                if (jMLConnectToJMLEnvironmentfriendlyName != null)
                {
                    jMLConnectToJMLEnvironment["FriendlyName"] = ExpressionConverter.ConvertO(jMLConnectToJMLEnvironmentfriendlyName);
                    jMLConnectToJMLEnvironmentpropCount++;
                }

                if (jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected != null)
                {
                    if (jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected != null)
                    {
                        jMLConnectToJMLEnvironment["OnlyConnectIfNotAlreadyConnected"] = ExpressionConverter.ConvertO(jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected);
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
                jMLConnectToJMLEnvironment["Workflow"] = ExpressionConverter.ConvertO(jMLConnectToJMLEnvironmentworkflow);
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

    public enum activeDirectoryAddADGroupgroupCategoryInput
    {
        [EnumMember(Value = "Security")]
        SecurityGroup,
        [EnumMember(Value = "Distribution")]
        DistributionGroup
    }

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

    public enum openExchangePowerShellRunspaceconnectionMethodInput
    {
        [EnumMember(Value = "Local")]
        LocalRemoteExchangeRunspaceIsImportedLocally,
        [EnumMember(Value = "Remote")]
        RemoteCommandsRunInRemoteExchangeRunspace
    }

    public enum openExchangePowerShellRunspaceauthenticationMechanismInput
    {
        Basic,
        CredSSP,
        Default,
        Digest,
        Kerberos,
        Negotiate
    }

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

    public enum exchangeNewDistributionGroupmemberDepartRestrictionInput
    {
        Open,
        Closed
    }

    public enum exchangeNewDistributionGroupmemberJoinRestrictionInput
    {
        Open,
        Closed,
        ApprovalRequired
    }

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

    public enum exchangeSetMailboxAutoReplyConfigurationautoReplyStateInput
    {
        [EnumMember(Value = "Enabled")]
        EnabledAutomaticRepliesAreSent,
        [EnumMember(Value = "Disabled")]
        DisabledAutomaticRepliesAreNotSent
    }

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

    public enum azureADv2AddAzureADUserageGroupInput
    {
        None,
        Minor,
        NotAdult,
        Adult
    }

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

    public enum azureADv2SetAzureADUserageGroupInput
    {
        None,
        Minor,
        NotAdult,
        Adult
    }

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

    public enum openO365PowerShellRunspaceconnectionMethodInput
    {
        [EnumMember(Value = "EXO V1 local")]
        EXOV1LocalRemoteExchangeOnlineIsImportedLocally,
        [EnumMember(Value = "EXO V1 remote")]
        EXOV1RemoteCommandsRunInRemoteExchangeOnline,
        [EnumMember(Value = "EXO V2")]
        EXOV2ExchangeOnlinePowerShellV2
    }

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

    public enum openO365PowerShellRunspaceWithCertificateconnectionMethodInput
    {
        [EnumMember(Value = "EXO V2")]
        EXOV2ExchangeOnlinePowerShellV2
    }

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

    public enum o365NewO365DistributionGroupmemberDepartRestrictionInput
    {
        Open,
        Closed
    }

    public enum o365NewO365DistributionGroupmemberJoinRestrictionInput
    {
        Open,
        Closed,
        ApprovalRequired
    }

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

    public enum o365SetO365MailboxAutoReplyConfigurationautoReplyStateInput
    {
        [EnumMember(Value = "Enabled")]
        EnabledAutomaticRepliesAreSent,
        [EnumMember(Value = "Disabled")]
        DisabledAutomaticRepliesAreNotSent
    }

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
